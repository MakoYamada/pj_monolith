Imports CommonLib
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

            '画面項目表示
            SetForm()
        End If

        'マステーページ設定
        With Me.Master
            .DispTaxiMenu = True
            .PageTitle = "タクシーチケスットキャンデータ取込"
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

    '画面項目 表示
    Private Sub SetForm()
    End Sub

    '[スキャンデータ取込]
    Protected Sub BtnUpload_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnUpload.Click
        'ファイルチェック
        If Not Check_File() Then Exit Sub

        '指定されたファイルをアップロードする
        Dim CsvFileName As String = CmnModule.GetSysDateTime() & "_" & System.IO.Path.GetFileName(Me.FileUpload1.PostedFile.FileName)
        Dim CsvPath As String
        CsvPath = WebConfig.Site.SCAN_CSV & CsvFileName
        Me.FileUpload1.PostedFile.SaveAs(CsvPath)

        'ファイル内容チェック
        If Not Check_Csv(CsvPath) Then
            'バックアップ作成
            System.IO.File.Move(CsvPath, WebConfig.Site.SCAN_CSV_BK & CsvFileName)
            '作業用に保存したファイルを削除
            Try
                System.IO.File.Delete(CsvPath)
            Catch ex As Exception
            End Try
            Exit Sub
        End If

        'ログ登録
        MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiScan, True, "アップロードファイル：" & Me.FileUpload1.PostedFile.FileName, MyBase.DbConnection)

        'DB
        Dim UpdatedCount As Integer = 0
        If UpdateData(CsvPath, System.IO.Path.GetFileName(Me.FileUpload1.PostedFile.FileName), UpdatedCount) Then
            Me.TrError.Visible = False
            Me.TrEnd.Visible = True
            Me.LabelUpdatedCount.Text = UpdatedCount.ToString
        Else
            Me.TrError.Visible = True
            Me.TrEnd.Visible = False
        End If

        'バックアップ作成
        System.IO.File.Move(CsvPath, WebConfig.Site.SCAN_CSV_BK & CsvFileName)
        '作業用に保存したファイルを削除
        Try
            System.IO.File.Delete(CsvPath)
        Catch ex As Exception
        End Try
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
        Dim wLineCnt As Integer = 0
        Dim ErrorMessage As String = ""
        Dim wLength As Integer

        '読み込みできる文字がなくなるまで繰り返す
        While (cReader.Peek() >= 0)
            'ファイルを1行ずつ読み込む
            Dim stBuffer As String = cReader.ReadLine()

            wLineCnt += 1

            If Trim(stBuffer) <> "" Then
                '文字列数チェック
                wLength = MyModule.Csv.TaxiScan.Length.SALEFORCE_ID _
                        + MyModule.Csv.TaxiScan.Length.SANKASHA_ID _
                        + MyModule.Csv.TaxiScan.Length.KOUENKAI_NO _
                        + MyModule.Csv.TaxiScan.Length.TIME_STAMP_BYL _
                        + MyModule.Csv.TaxiScan.Length.DR_MPID _
                        + MyModule.Csv.TaxiScan.Length.TKT_LINE_NO _
                        + MyModule.Csv.TaxiScan.Length.TKT_NO
                If CmnModule.LenB(stBuffer) <> wLength Then
                    ErrorMessage &= "【" & wLineCnt.ToString & "行目】文字数が正しくありません。 " & vbNewLine
                Else
                    '項目毎のチェック
                    Dim ScanData As MyModule.Csv.TaxiScan.DataStruct
                    wLength = 1

                    ScanData.SALEFORCE_ID = Trim(Mid(stBuffer, wLength, MyModule.Csv.TaxiScan.Length.SALEFORCE_ID))
                    wLength += MyModule.Csv.TaxiScan.Length.SALEFORCE_ID
                    If ScanData.SALEFORCE_ID = "" Then
                        ErrorMessage &= "【" & wLineCnt.ToString & "行目】SalesForceIDが記載されていません。" & vbNewLine
                    End If

                    ScanData.SANKASHA_ID = Trim(Mid(stBuffer, wLength, MyModule.Csv.TaxiScan.Length.SANKASHA_ID))
                    wLength += MyModule.Csv.TaxiScan.Length.SANKASHA_ID
                    If ScanData.SANKASHA_ID = "" Then
                        ErrorMessage &= "【" & wLineCnt.ToString & "行目】参加者IDが記載されていません。" & vbNewLine
                    End If

                    ScanData.KOUENKAI_NO = Trim(Mid(stBuffer, wLength, MyModule.Csv.TaxiScan.Length.KOUENKAI_NO))
                    wLength += MyModule.Csv.TaxiScan.Length.KOUENKAI_NO
                    If ScanData.KOUENKAI_NO = "" Then
                        ErrorMessage &= "【" & wLineCnt.ToString & "行目】講演会番号が記載されていません。" & vbNewLine
                    End If

                    ScanData.TIME_STAMP_BYL = Trim(Mid(stBuffer, wLength, MyModule.Csv.TaxiScan.Length.TIME_STAMP_BYL))
                    wLength += MyModule.Csv.TaxiScan.Length.TIME_STAMP_BYL
                    If ScanData.TIME_STAMP_BYL = "" Then
                        ErrorMessage &= "【" & wLineCnt.ToString & "行目】Timestamp(BYL)が記載されていません。" & vbNewLine
                    ElseIf Not CmnCheck.IsNumberOnly(ScanData.TIME_STAMP_BYL) Then
                        ErrorMessage &= "【" & wLineCnt.ToString & "行目】Timestamp(BYL)に数字以外の文字があります。" & vbNewLine
                    End If

                    ScanData.DR_MPID = Trim(Mid(stBuffer, wLength, MyModule.Csv.TaxiScan.Length.DR_MPID))
                    wLength += MyModule.Csv.TaxiScan.Length.DR_MPID
                    If ScanData.DR_MPID = "" Then
                        ErrorMessage &= "【" & wLineCnt.ToString & "行目】MPIDが記載されていません。" & vbNewLine
                    End If

                    ScanData.TKT_LINE_NO = Trim(Mid(stBuffer, wLength, MyModule.Csv.TaxiScan.Length.TKT_LINE_NO))
                    wLength += MyModule.Csv.TaxiScan.Length.TKT_LINE_NO
                    If ScanData.TKT_LINE_NO = "" Then
                        ErrorMessage &= "【" & wLineCnt.ToString & "行目】行番号が記載されていません。" & vbNewLine
                    ElseIf Not CmnCheck.IsNumberOnly(ScanData.TKT_LINE_NO) Then
                        ErrorMessage &= "【" & wLineCnt.ToString & "行目】行番号に数字以外の文字があります。" & vbNewLine
                    ElseIf Val(ScanData.TKT_LINE_NO) < 1 OrElse Val(ScanData.TKT_LINE_NO) > 20 Then
                        ErrorMessage &= "【" & wLineCnt.ToString & "行目】行番号に1～20以外の数値が入っています。" & vbNewLine
                    End If

                    ScanData.TKT_NO = Trim(Mid(stBuffer, wLength, MyModule.Csv.TaxiScan.Length.TKT_NO))
                    wLength += MyModule.Csv.TaxiScan.Length.TKT_NO
                    If ScanData.TKT_NO = "" Then
                        ErrorMessage &= "【" & wLineCnt.ToString & "行目】タクシーチケット番号が記載されていません。" & vbNewLine
                    End If

                    '取込み済み チェック
                    If CmnDb.IsExist(SQL.TBL_TAXITICKET_HAKKO.TaxiScanCsvCheck(ScanData.TKT_NO), MyBase.DbConnection) Then
                        ErrorMessage &= "【" & wLineCnt.ToString & "行目】タクシーチケット番号［" & ScanData.TKT_NO & "］はスキャンデータ取込済みです。" & vbNewLine
                    End If
                End If
            End If
        End While

        'cReader を閉じる (正しくは オブジェクトの破棄を保証する を参照)
        cReader.Close()

        If Trim(ErrorMessage) <> "" Then
            Me.TrError.Visible = True
            Me.TrEnd.Visible = False
            Me.LabelErrorMessage.Text = ErrorMessage
            Return False
        Else
            Return True
        End If
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
    Private Function UpdateData(ByVal CsvPath As String, ByVal CsvFileName As String, ByRef UpdatedCount As Integer) As Boolean
        Dim CsvData As New System.IO.StreamReader(CsvPath, System.Text.Encoding.Default)
        Dim wLineCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
        Dim TBL_TAXITICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim wStr As String = ""
        Dim TKT_HAKKO_FEE As String = "0"
        Dim wUpdateCntTAXI As Integer = 0
        Dim wUpdateCntKOTSUHOTEL As Integer = 0
        Dim wTKT_IMPORT_DATE As String = CmnModule.GetSysDate()

        '発行手数料
        wFlag = False
        strSQL = SQL.MS_CODE.byCODE(AppConst.MS_CODE.TAXI_TESURYO)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wFlag = True
            TKT_HAKKO_FEE = CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)
        End If
        RsData.Close()

        If wFlag = False Then
            CmnModule.AlertMessage("タクシーチケット発行手数料の設定が正しくありません。コードマスタを再確認してください。", Me)
            Return False
        End If

        '読み込みできる文字がなくなるまで繰り返す
        wFlag = False
        While (CsvData.Peek() >= 0)
            'ファイルを1行ずつ読み込む
            Dim stBuffer As String = CsvData.ReadLine()

            wLineCnt += 1
            If Trim(stBuffer) <> "" Then
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

                '発行手数料
                TBL_TAXITICKET_HAKKO(wCnt).TKT_HAKKO_FEE = TKT_HAKKO_FEE
                '取込日
                TBL_TAXITICKET_HAKKO(wCnt).TKT_IMPORT_DATE = wTKT_IMPORT_DATE
                '使用者
                TBL_TAXITICKET_HAKKO(wCnt).UPDATE_USER = Session.Item(SessionDef.LoginID)

                wCnt += 1
            End If
        End While
        CsvData.Close()

        'ログ登録
        MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiScan, True, wLineCnt.ToString & "件のスキャンデータを読込みました。", MyBase.DbConnection)

        '交通宿泊テーブル 読込
        'タクシー会社、券種取得
        ReDim TBL_KOTSUHOTEL(UBound(TBL_TAXITICKET_HAKKO))
        For wCnt = LBound(TBL_TAXITICKET_HAKKO) To UBound(TBL_TAXITICKET_HAKKO)
            strSQL = SQL.TBL_KOTSUHOTEL.TaxiScanCsv(TBL_TAXITICKET_HAKKO(wCnt))
            RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
            If RsData.Read() Then
                Select Case Val(TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO)
                    Case 1
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_1, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_1, RsData))
                    Case 2
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_2, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_2, RsData))
                    Case 3
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_3, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_3, RsData))
                    Case 4
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_4, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_4, RsData))
                    Case 5
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_5, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_5, RsData))
                    Case 6
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_6, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_6, RsData))
                    Case 7
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_7, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_7, RsData))
                    Case 8
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_8, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_8, RsData))
                    Case 9
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_9, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_9, RsData))
                    Case 10
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_10, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_10, RsData))
                    Case 11
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_11, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_11, RsData))
                    Case 12
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_12, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_12, RsData))
                    Case 13
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_13, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_13, RsData))
                    Case 14
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_14, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_14, RsData))
                    Case 15
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_15, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_15, RsData))
                    Case 16
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_16, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_16, RsData))
                    Case 17
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_17, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_17, RsData))
                    Case 18
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_18, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_18, RsData))
                    Case 19
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_19, RsData))
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = GetName_TKT_KAISHA(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_19, RsData))
                    Case 20
                        TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = GetName_TKT_KENSHU(CmnDb.DbData(TableDef.TBL_KOTSUHOTEL.Column.ANS_TAXI_KENSHU_20, RsData))
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
            TBL_KOTSUHOTEL(wCnt).SCAN_IMPORT_DATE = TBL_TAXITICKET_HAKKO(wCnt).TKT_IMPORT_DATE

            Select Case Val(TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO)
                Case 1
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_1 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 2
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_2 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 3
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_3 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 4
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_4 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 5
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_5 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 6
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_6 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 7
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_7 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 8
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_8 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 9
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_9 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 10
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_10 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 11
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_11 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 12
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_12 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 13
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_13 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 14
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_14 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 15
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_15 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 16
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_16 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 17
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_17 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 18
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_18 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 19
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_19 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                Case 20
                    TBL_KOTSUHOTEL(wCnt).ANS_TAXI_NO_20 = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
            End Select
            TBL_KOTSUHOTEL(wCnt).UPDATE_USER = Session.Item(SessionDef.LoginID)
        Next

        'データ更新
        wStr = ""
        UpdatedCount = 0
        Dim RtnTBL_TAXITICKET_HAKKO As Integer
        Dim RtnTBL_KOTSUHOTEL As Integer
        MyBase.BeginTransaction()
        Try
            For wCnt = LBound(TBL_TAXITICKET_HAKKO) To UBound(TBL_TAXITICKET_HAKKO)
                'タクチケテーブル
                strSQL = SQL.TBL_TAXITICKET_HAKKO.Update_TaxiScan(TBL_TAXITICKET_HAKKO(wCnt))
                RtnTBL_TAXITICKET_HAKKO = CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

                If RtnTBL_TAXITICKET_HAKKO = 0 Then
                    wStr &= CsvFileName & "【" & wCnt + 1.ToString & "行目】タクシーチケット発行テーブル 該当データなし" & vbNewLine
                    'ログ登録
                    MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiScan, False, CsvFileName & "【" & wCnt + 1.ToString & "行目】タクシーチケット発行テーブル 該当データなし", MyBase.DbConnection, MyBase.DbTransaction)
                Else
                    wUpdateCntTAXI += 1
                    'ログ登録
                    MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiScan, TBL_TAXITICKET_HAKKO(wCnt), TBL_KOTSUHOTEL(wCnt), True, "", "TBL_TAXITICKET_HAKKO", MyBase.DbConnection, MyBase.DbTransaction)
                End If

                '交通宿泊手配テーブル
                strSQL = SQL.TBL_KOTSUHOTEL.Update_TaxiScan(TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO, TBL_KOTSUHOTEL(wCnt))
                RtnTBL_KOTSUHOTEL = CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

                If RtnTBL_KOTSUHOTEL = 0 Then
                    wStr &= CsvFileName & "【" & wCnt + 1.ToString & "行目】交通宿泊手配テーブル 該当データなし" & vbNewLine
                    'ログ登録
                    MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiScan, False, CsvFileName & "【" & wCnt + 1.ToString & "行目】交通宿泊手配テーブル 該当データなし", MyBase.DbConnection, MyBase.DbTransaction)
                Else
                    wUpdateCntKOTSUHOTEL += 1
                    'ログ登録
                    MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiScan, TBL_TAXITICKET_HAKKO(wCnt), TBL_KOTSUHOTEL(wCnt), True, "", "TBL_KOTSUHOTEL", MyBase.DbConnection, MyBase.DbTransaction)
                End If

                If RtnTBL_TAXITICKET_HAKKO = 1 AndAlso RtnTBL_KOTSUHOTEL = 1 Then
                    UpdatedCount += 1
                End If
            Next wCnt

            MyBase.Commit()
        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiScan, False, CsvFileName & "【" & wCnt + 1.ToString & "行目】" & Session.Item(SessionDef.DbError), MyBase.DbConnection)

            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))

            Return False
        End Try

        'ログ登録
        MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiScan, True, "タクシーチケット発行テーブル：" & wUpdateCntTAXI.ToString & "件、交通宿泊手配テーブル：" & wUpdateCntKOTSUHOTEL.ToString & "件を登録しました。", MyBase.DbConnection)

        If TBL_TAXITICKET_HAKKO.Length <> wUpdateCntTAXI OrElse TBL_KOTSUHOTEL.Length <> wUpdateCntKOTSUHOTEL Then
            Me.LabelErrorMessage.Text = wStr
            Return False
        Else
            Return True
        End If
    End Function

    Private Function GetName_TKT_KENSHU(ByVal TAXI_KENSHU As String) As String
        If Trim(TAXI_KENSHU) = "" Then
            Return ""
        Else
            If CmnCheck.IsNumberOnly(TAXI_KENSHU) Then
                Return "DC" & Trim(TAXI_KENSHU)
            Else
                Return Trim(TAXI_KENSHU)
            End If
        End If
    End Function

    Private Function GetName_TKT_KAISHA(ByVal TAXI_KENSHU As String) As String
        If Trim(TAXI_KENSHU) = "" Then
            Return ""
        Else
            Dim wStr As String = TAXI_KENSHU.ToUpper
            If CmnCheck.IsNumberOnly(TAXI_KENSHU) Then
                Return "DC"
            Else
                Return Left(TAXI_KENSHU, 2)
            End If
        End If
    End Function

End Class
