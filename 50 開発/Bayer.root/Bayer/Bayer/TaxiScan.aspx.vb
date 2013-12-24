﻿Imports CommonLib
Imports AppLib
Partial Public Class TaxiScan
    Inherits WebBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '共通チェック
        MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納
        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()
        End If

        'マステーページ設定
        With Me.Master
            .DispTaxiMenu = True
            .PageTitle = "スキャンデータ取込"
        End With
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        Me.TrError.Visible = False
        Me.TrEnd.Visible = False

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '[スキャンデータ取込]
    Protected Sub BtnUpload_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnUpload.Click
        'ファイルチェック
        If Not Check_File() Then Exit Sub

        '指定されたファイルをアップロードする
        Dim CsvFileName As String = CmnModule.GetSysDateTime() & ".csv"
        Dim CsvPath As String
        CsvPath = WebConfig.Site.SCAN_CSV & CsvFileName
        Me.FileUpload1.PostedFile.SaveAs(CsvPath)

        'ファイル内容チェック
        If Not Check_Csv(CsvPath) Then Exit Sub

        'DB
        If UpdateData(CsvPath) Then
            Me.TrError.Visible = False
            Me.TrEnd.Visible = True
            'バックアップ作成
            System.IO.File.Move(CsvPath, WebConfig.Site.SCAN_CSV_BK & CsvFileName)
        Else
            Me.TrError.Visible = True
            Me.TrEnd.Visible = False
        End If
    End Sub

    'ファイルチェック
    Private Function Check_File() As Boolean
        '必須
        If Trim(Me.FileUpload1.PostedFile.FileName) = "" Then
            CmnModule.AlertMessage(MessageDef.Error.MustSelect("送信するファイル"), Me)
            Return False
        End If
        'アップしようとするファイルのチェック(拡張子)
        If System.IO.Path.GetExtension(Me.FileUpload1.PostedFile.FileName).ToString = "" Then
            CmnModule.AlertMessage(MessageDef.Error.Csv.InvalidFile, Me)
            Return False
        End If
        'ファイルのサイズをチェック
        If Me.FileUpload1.PostedFile.ContentLength < 1 Then
            CmnModule.AlertMessage(MessageDef.Error.Csv.InvalidFile, Me)
            Return False
        End If

        Return True
    End Function

    'ファイル内容チェック
    Private Function Check_Csv(ByVal CsvPath As String) As Boolean
        Dim cReader As New System.IO.StreamReader(CsvPath, System.Text.Encoding.Default)
        Dim wSplit() As String
        Dim wLineCount As Integer = 0
        Dim ErrorMessage As String = ""

        '読み込みできる文字がなくなるまで繰り返す
        While (cReader.Peek() >= 0)
            'ファイルを1行ずつ読み込む
            Dim stBuffer As String = cReader.ReadLine()
            'stBuffer = Replace(stBuffer, """", "")  'ダブルクォーテーション除去

            wLineCount += 1

            If Trim(stBuffer) <> "" Then
                'チェック
                Dim ScanData As MyModule.Csv.TaxiScan.DataStruct
                Dim wLength As Integer = 1

                ScanData.SALEFORCE_ID = Trim(Mid(stBuffer, wLength, MyModule.Csv.TaxiScan.Length.SALEFORCE_ID))
                wLength += MyModule.Csv.TaxiScan.Length.SALEFORCE_ID
                If ScanData.SALEFORCE_ID = "" Then
                    ErrorMessage = "SalesForceID"
                End If

                ScanData.SANKASHA_ID = Trim(Mid(stBuffer, wLength, MyModule.Csv.TaxiScan.Length.SANKASHA_ID))
                wLength += MyModule.Csv.TaxiScan.Length.SANKASHA_ID
                If ScanData.SANKASHA_ID = "" Then
                    ErrorMessage = "参加者ID"
                End If

                ScanData.KOUENKAI_NO = Trim(Mid(stBuffer, wLength, MyModule.Csv.TaxiScan.Length.KOUENKAI_NO))
                wLength += MyModule.Csv.TaxiScan.Length.KOUENKAI_NO
                If ScanData.KOUENKAI_NO = "" Then
                    ErrorMessage = "講演会番号"
                End If

                ScanData.TIME_STAMP_BYL = Trim(Mid(stBuffer, wLength, MyModule.Csv.TaxiScan.Length.TIME_STAMP_BYL))
                wLength += MyModule.Csv.TaxiScan.Length.TIME_STAMP_BYL
                If ScanData.TIME_STAMP_BYL = "" Then
                    ErrorMessage = "Timestamp(BYL)"
                End If

                ScanData.DR_MPID = Trim(Mid(stBuffer, wLength, MyModule.Csv.TaxiScan.Length.DR_MPID))
                wLength += MyModule.Csv.TaxiScan.Length.DR_MPID
                If ScanData.DR_MPID = "" Then
                    ErrorMessage = "MPID"
                End If

                ScanData.TKT_LINE_NO = Trim(Mid(stBuffer, wLength, MyModule.Csv.TaxiScan.Length.TKT_LINE_NO))
                wLength += MyModule.Csv.TaxiScan.Length.TKT_LINE_NO
                If ScanData.TKT_LINE_NO = "" Then
                    ErrorMessage = "行番号"
                End If

                ScanData.TKT_NO = Trim(Mid(stBuffer, wLength, MyModule.Csv.TaxiScan.Length.TKT_NO))
                wLength += MyModule.Csv.TaxiScan.Length.TKT_NO
                If ScanData.TKT_NO = "" Then
                    ErrorMessage = "タクシーチケット番号"
                End If
            End If
        End While

        'cReader を閉じる (正しくは オブジェクトの破棄を保証する を参照)
        cReader.Close()

        If Trim(ErrorMessage) <> "" Then
            Me.TrError.Visible = True
            Me.TrEnd.Visible = False
            Me.ErrorMessage.Text = ErrorMessage
            Return False
        Else
            Return True
        End If
    End Function

    'Csvデータをチェック
    Private Function CheckCsvData(ByRef ErrorMessage As String, ByVal CsvData As String) As MyModule.Csv.TaxiScan.DataStruct
        Dim wCsvData As MyModule.Csv.TaxiScan.DataStruct
        Dim wLength As Integer = 1

        If Trim(CsvData) = "" Then
            ErrorMessage = "値なし"
            Return Nothing
        End If

        wCsvData.SALEFORCE_ID = Trim(Mid(CsvData, wLength, MyModule.Csv.TaxiScan.Length.SALEFORCE_ID))
        wLength += MyModule.Csv.TaxiScan.Length.SALEFORCE_ID
        If wCsvData.SALEFORCE_ID = "" Then
            ErrorMessage = "SalesForceID"
            Return Nothing
        End If

        wCsvData.SANKASHA_ID = Trim(Mid(CsvData, wLength, MyModule.Csv.TaxiScan.Length.SANKASHA_ID))
        wLength += MyModule.Csv.TaxiScan.Length.SANKASHA_ID
        If wCsvData.SANKASHA_ID = "" Then
            ErrorMessage = "参加者ID"
            Return Nothing
        End If

        wCsvData.KOUENKAI_NO = Trim(Mid(CsvData, wLength, MyModule.Csv.TaxiScan.Length.KOUENKAI_NO))
        wLength += MyModule.Csv.TaxiScan.Length.KOUENKAI_NO
        If wCsvData.KOUENKAI_NO = "" Then
            ErrorMessage = "講演会番号"
            Return Nothing
        End If

        wCsvData.TIME_STAMP_BYL = Trim(Mid(CsvData, wLength, MyModule.Csv.TaxiScan.Length.TIME_STAMP_BYL))
        wLength += MyModule.Csv.TaxiScan.Length.TIME_STAMP_BYL
        If wCsvData.TIME_STAMP_BYL = "" Then
            ErrorMessage = "Timestamp(BYL)"
            Return Nothing
        End If

        wCsvData.DR_MPID = Trim(Mid(CsvData, wLength, MyModule.Csv.TaxiScan.Length.DR_MPID))
        wLength += MyModule.Csv.TaxiScan.Length.DR_MPID
        If wCsvData.DR_MPID = "" Then
            ErrorMessage = "MPID"
            Return Nothing
        End If

        wCsvData.TKT_LINE_NO = Trim(Mid(CsvData, wLength, MyModule.Csv.TaxiScan.Length.TKT_LINE_NO))
        wLength += MyModule.Csv.TaxiScan.Length.TKT_LINE_NO
        If wCsvData.TKT_LINE_NO = "" Then
            ErrorMessage = "行番号"
            Return Nothing
        End If

        wCsvData.TKT_NO = Trim(Mid(CsvData, wLength, MyModule.Csv.TaxiScan.Length.TKT_NO))
        wLength += MyModule.Csv.TaxiScan.Length.TKT_NO
        If wCsvData.TKT_NO = "" Then
            ErrorMessage = "タクシーチケット番号"
            Return Nothing
        End If
 
        Return wCsvData
    End Function

    'Csvのデータを構造体にセット
    Private Function SetScanData(ByVal CsvData As String) As MyModule.Csv.TaxiScan.DataStruct
        Dim wCsvData As MyModule.Csv.TaxiScan.DataStruct
        Dim wLength As Integer = 1

        wCsvData.SALEFORCE_ID = Trim(Mid(CsvData, wLength, MyModule.Csv.TaxiScan.Length.SALEFORCE_ID))
        wLength += MyModule.Csv.TaxiScan.Length.SALEFORCE_ID

        wCsvData.SANKASHA_ID = Trim(Mid(CsvData, wLength, MyModule.Csv.TaxiScan.Length.SANKASHA_ID))
        wLength += MyModule.Csv.TaxiScan.Length.SANKASHA_ID

        wCsvData.KOUENKAI_NO = Trim(Mid(CsvData, wLength, MyModule.Csv.TaxiScan.Length.KOUENKAI_NO))
        wLength += MyModule.Csv.TaxiScan.Length.KOUENKAI_NO

        wCsvData.TIME_STAMP_BYL = Trim(Mid(CsvData, wLength, MyModule.Csv.TaxiScan.Length.TIME_STAMP_BYL))
        wLength += MyModule.Csv.TaxiScan.Length.TIME_STAMP_BYL

        wCsvData.DR_MPID = Trim(Mid(CsvData, wLength, MyModule.Csv.TaxiScan.Length.DR_MPID))
        wLength += MyModule.Csv.TaxiScan.Length.DR_MPID

        wCsvData.TKT_LINE_NO = Trim(Mid(CsvData, wLength, MyModule.Csv.TaxiScan.Length.TKT_LINE_NO))
        wLength += MyModule.Csv.TaxiScan.Length.TKT_LINE_NO

        wCsvData.TKT_NO = Trim(Mid(CsvData, wLength, MyModule.Csv.TaxiScan.Length.TKT_NO))
        wLength += MyModule.Csv.TaxiScan.Length.TKT_NO

        Return wCsvData
    End Function

    'Csv読込 → DB展開
    Private Function UpdateData(ByVal CsvPath As String) As Boolean
        Dim CsvData As New System.IO.StreamReader(CsvPath, System.Text.Encoding.Default)
        Dim wSplit() As String
        Dim wLineCount As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
        Dim TBL_TAXITICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim wStr As String = ""
        Dim TKT_HAKKO_FEE As String = "0"

        '発行手数料
        strSQL = SQL.MS_CODE.byCODE(AppConst.MS_CODE.TAXI_TESURYO)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            TKT_HAKKO_FEE = CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)
        End If
        RsData.Close()

        '読み込みできる文字がなくなるまで繰り返す
        While (CsvData.Peek() >= 0)
            'ファイルを1行ずつ読み込む
            Dim stBuffer As String = CsvData.ReadLine()
            stBuffer = Replace(stBuffer, """", "")

            wLineCount += 1

            If Trim(stBuffer) <> "" Then
                wSplit = Split(stBuffer, ",")

                wFlag = True
 
                ReDim Preserve TBL_TAXITICKET_HAKKO(wCnt)

                Dim ScanData As MyModule.Csv.TaxiScan.DataStruct
                ScanData = SetScanData(stBuffer)

                TBL_TAXITICKET_HAKKO(wCnt).SALEFORCE_ID = Trim(ScanData.SALEFORCE_ID)
                TBL_TAXITICKET_HAKKO(wCnt).SANKASHA_ID = Trim(ScanData.SANKASHA_ID)
                TBL_TAXITICKET_HAKKO(wCnt).KOUENKAI_NO = Trim(ScanData.KOUENKAI_NO)
                TBL_TAXITICKET_HAKKO(wCnt).TIME_STAMP_BYL = Trim(ScanData.TIME_STAMP_BYL)
                TBL_TAXITICKET_HAKKO(wCnt).DR_MPID = Trim(ScanData.DR_MPID)
                TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO = Trim(ScanData.TKT_LINE_NO)
                TBL_TAXITICKET_HAKKO(wCnt).TKT_NO = Trim(ScanData.TKT_NO)

                '発行日
                TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE = CmnModule.GetSysDate()
                '発行手数料
                TBL_TAXITICKET_HAKKO(wCnt).TKT_HAKKO_FEE = TKT_HAKKO_FEE

                wCnt += 1
            End If
        End While
        CsvData.Close()

        '交通宿泊テーブル 読込
        'タクシー会社、券種取得
        ReDim TBL_KOTSUHOTEL(UBound(TBL_TAXITICKET_HAKKO))
        For wCnt = LBound(TBL_TAXITICKET_HAKKO) To UBound(TBL_TAXITICKET_HAKKO)
            strSQL = SQL.TBL_KOTSUHOTEL.TaxiScanCsv(TBL_TAXITICKET_HAKKO(wCnt))
            RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
            If RsData.Read() Then
                Select Case Val(TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO)
                    Case 1
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_1, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_1, RsData))
                    Case 2
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_2, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_2, RsData))
                    Case 3
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_3, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_3, RsData))
                    Case 4
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_4, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_4, RsData))
                    Case 5
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_5, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_5, RsData))
                    Case 6
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_6, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_6, RsData))
                    Case 7
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_7, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_7, RsData))
                    Case 8
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_8, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_8, RsData))
                    Case 9
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_9, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_9, RsData))
                    Case 10
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_10, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_10, RsData))
                    Case 11
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_11, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_11, RsData))
                    Case 12
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_12, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_12, RsData))
                    Case 13
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_13, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_13, RsData))
                    Case 14
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_14, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_14, RsData))
                    Case 15
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_15, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_15, RsData))
                    Case 16
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_16, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_16, RsData))
                    Case 17
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_17, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_17, RsData))
                    Case 18
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_18, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_18, RsData))
                    Case 19
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_19, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_19, RsData))
                    Case 20
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TAXI_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_20, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_20, RsData))
                End Select
            End If
            RsData.Close()
        Next wCnt

        '交通宿泊テーブル 更新用
        ReDim TBL_KOTSUHOTEL(UBound(TBL_TAXITICKET_HAKKO))
        For wCnt = LBound(TBL_TAXITICKET_HAKKO) To UBound(TBL_TAXITICKET_HAKKO)
            'キー項目
            TBL_KOTSUHOTEL(wCnt).SALEFORCE_ID = TBL_TAXITICKET_HAKKO(wCnt).SALEFORCE_ID
            TBL_KOTSUHOTEL(wCnt).SANKASHA_ID = TBL_TAXITICKET_HAKKO(wCnt).SANKASHA_ID
            TBL_KOTSUHOTEL(wCnt).KOUENKAI_NO = TBL_TAXITICKET_HAKKO(wCnt).KOUENKAI_NO
            TBL_KOTSUHOTEL(wCnt).TIME_STAMP_BYL = TBL_TAXITICKET_HAKKO(wCnt).TIME_STAMP_BYL
            TBL_KOTSUHOTEL(wCnt).DR_MPID = TBL_TAXITICKET_HAKKO(wCnt).DR_MPID

            Select Case Val(TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO)
                Case 1
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_1 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_1 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 2
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_2 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_2 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 3
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_3 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_3 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 4
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_4 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_4 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 5
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_5 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_5 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 6
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_6 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_6 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 7
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_7 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_7 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 8
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_8 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_8 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 9
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_9 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_9 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 10
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_10 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_10 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 11
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_11 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_11 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 12
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_12 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_12 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 13
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_13 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_13 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 14
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_14 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_14 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 15
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_15 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_15 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 16
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_16 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_16 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 17
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_17 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_17 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 18
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_18 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_18 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 19
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_19 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_19 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
                Case 20
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_20 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                    'QQQ TBL_KOTSUHOTEL(wCnt).ANS_TAXI_HAKKO_DATE_20 = TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE
            End Select
        Next

        ''データ更新
        'MyBase.BeginTransaction()
        'Try
        '    For wCnt = LBound(TBL_TAXITICKET_HAKKO) To UBound(TBL_TAXITICKET_HAKKO)
        '        'タクチケテーブル
        '        strSQL = SQL.TBL_TAXITICKET_HAKKO.Update_Scan(TBL_TAXITICKET_HAKKO(wCnt))
        '        CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

        '        '交通宿泊手配テーブル
        '        strSQL = SQL.TBL_KOTSUHOTEL.Update_ANS_TAXI_HAKKO_DATE(TBL_KOTSUHOTEL(wCnt))
        '        CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
        '    Next wCnt

        '    MyBase.Commit()
        'Catch ex As Exception
        '    MyBase.Rollback()

        '    Return False
        'End Try

        Return True
    End Function

    Private Function GetName_TAXI_KENSHU(ByVal TAXI_KENSHU As String) As String
        Return Trim(TAXI_KENSHU)
    End Function

    Private Function GetName_TKT_KAISHA(ByVal TAXI_KENSHU As String) As String
        Dim wStr As String = TAXI_KENSHU.ToUpper
        If InStr(wStr, "TK") > 0 Then
            Return "TK"
        ElseIf InStr(wStr, "NG") > 0 Then
            Return "NG"
        Else
            Return "DC"
        End If
    End Function

End Class
