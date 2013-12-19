Imports CommonLib
Imports AppLib
Partial Public Class TaxiScan
    Inherits WebBase

    Enum CsvIndex
        TKT_KAISHA = 0
        TKT_NO
        TKT_KENSHU
        KOUENKAI_NO
        SANKASHA_ID
        TKT_LINE_NO
        TAXI_HAKKO_DATE
    End Enum

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
        Dim wStr As String = ""

        '読み込みできる文字がなくなるまで繰り返す
        While (cReader.Peek() >= 0)
            'ファイルを1行ずつ読み込む
            Dim stBuffer As String = cReader.ReadLine()
            stBuffer = Replace(stBuffer, """", "")  'ダブルクォーテーション除去

            wLineCount += 1

            'カンマが1つ以上あるか
            If Trim(stBuffer) <> "" Then
                If InStr(stBuffer, ",") <= 0 Then
                    wStr &= MessageDef.Error.Csv.NoComma(wLineCount) & vbNewLine
                End If
                wSplit = Split(stBuffer, ",")
                '& vbNewLine 列数 フォーマットが決まったら復活
                'If UBound(wSplit) <> 1 Then
                '    wStr &= MessageDef.Error.csv.Format(wLineCount) & vbNewLine
                'End If

                If Trim(wSplit(CsvIndex.TKT_KAISHA)) = "" Then
                    wStr &= MessageDef.Error.Csv.Invalid(wLineCount, TableDef.TBL_TAXITICKET_HAKKO.Name.TKT_KAISHA) & vbNewLine
                End If
                If Trim(wSplit(CsvIndex.TKT_NO)) = "" Then
                    wStr &= MessageDef.Error.Csv.Invalid(wLineCount, TableDef.TBL_TAXITICKET_HAKKO.Name.TKT_NO) & vbNewLine
                End If
                If Trim(wSplit(CsvIndex.TKT_KENSHU)) = "" Then
                    wStr &= MessageDef.Error.Csv.Invalid(wLineCount, TableDef.TBL_TAXITICKET_HAKKO.Name.TKT_KENSHU) & vbNewLine
                End If
                If Trim(wSplit(CsvIndex.KOUENKAI_NO)) = "" Then
                    wStr &= MessageDef.Error.Csv.Invalid(wLineCount, TableDef.TBL_TAXITICKET_HAKKO.Name.KOUENKAI_NO) & vbNewLine
                End If
                If Trim(wSplit(CsvIndex.SANKASHA_ID)) = "" Then
                    wStr &= MessageDef.Error.Csv.Invalid(wLineCount, TableDef.TBL_TAXITICKET_HAKKO.Name.SANKASHA_ID) & vbNewLine
                End If
                If Trim(wSplit(CsvIndex.TKT_LINE_NO)) = "" Then
                    wStr &= MessageDef.Error.Csv.Invalid(wLineCount, TableDef.TBL_TAXITICKET_HAKKO.Name.TKT_LINE_NO) & vbNewLine
                End If
            End If
        End While

        'cReader を閉じる (正しくは オブジェクトの破棄を保証する を参照)
        cReader.Close()

        If Trim(wStr) <> "" Then
            Me.TrError.Visible = True
            Me.TrEnd.Visible = False
            Me.ErrorMessage.Text = wStr
            Return False
        Else
            Return True
        End If
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
                TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA = Trim(wSplit(CsvIndex.TKT_KAISHA))
                TBL_TAXITICKET_HAKKO(wCnt).TKT_NO = Trim(wSplit(CsvIndex.TKT_NO))
                TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU = Trim(wSplit(CsvIndex.TKT_KENSHU))
                TBL_TAXITICKET_HAKKO(wCnt).KOUENKAI_NO = Trim(wSplit(CsvIndex.KOUENKAI_NO))
                TBL_TAXITICKET_HAKKO(wCnt).SANKASHA_ID = Trim(wSplit(CsvIndex.SANKASHA_ID))
                TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO = Trim(wSplit(CsvIndex.TKT_LINE_NO))
                TBL_TAXITICKET_HAKKO(wCnt).TAXI_HAKKO_DATE = Trim(wSplit(CsvIndex.TAXI_HAKKO_DATE))
                TBL_TAXITICKET_HAKKO(wCnt).TKT_HAKKO_FEE = TKT_HAKKO_FEE

                wCnt += 1
            End If
        End While
        CsvData.Close()

        '交通宿泊テーブル 更新用
        ReDim TBL_KOTSUHOTEL(UBound(TBL_TAXITICKET_HAKKO))
        For wCnt = LBound(TBL_TAXITICKET_HAKKO) To UBound(TBL_TAXITICKET_HAKKO)
            TBL_KOTSUHOTEL(wCnt).KOUENKAI_NO = TBL_TAXITICKET_HAKKO(wCnt).KOUENKAI_NO
            TBL_KOTSUHOTEL(wCnt).SANKASHA_ID = TBL_TAXITICKET_HAKKO(wCnt).SANKASHA_ID

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

End Class
