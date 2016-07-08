Imports CommonLib
Imports AppLib
Imports System.IO
Partial Public Class TaxiJissekiOTH
    Inherits WebBase

    Private Const COL_COUNT As Integer = 16 'ファイルの項目数
    'Private Const COL_COUNT_AK As Integer = 14 'ファイルの項目数
    'Private Const COL_COUNT_HW As Integer = 16 'ファイルの項目数
    'Private Const COL_COUNT_OTH As Integer = 15 'ファイルの項目数
    'Private Const COL_COUNT_SM As Integer = 15 'ファイルの項目数
    'Private Const COL_COUNT_TN As Integer = 15 'ファイルの項目数
    'Private Const COL_COUNT_KN As Integer = 15 'ファイルの項目数
    Private Const pDelimiter As String = ","
    Private SEISAN_TESURYO As String = "108"
    Private HAKKO_TESURYO As String = "324"
    Private TBL_TAXITICKET_HAKKO As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
    Private TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct

    Private Enum COL_NO
        KAISHA_CD = 0
        TKT_NO
        KOUENKAI_NAME
        TKT_USED_DATE
        TKT_USED_MM
        TKT_USED_DD
        KOUENKAI_NO
        SANKASHA_ID
        DR_NAME
        TKT_HAKKO_DATE
        TKT_LINE_NO
        TKT_URIAGE
        TKT_JISSHA_DATE
        'TKT_VOID
        TKT_OTHER
        TKT_HATUTI
        TKT_CHAKUTI
    End Enum

    Private Class COL_NAME
        Public Const KAISHA_CD As String = "会社コード"
        Public Const TKT_NO As String = "チケット番号"
        Public Const KOUENKAI_NAME As String = "講演会名"
        Public Const TKT_USED_DATE As String = "利用年月日"
        Public Const TKT_USED_MM As String = "利用月"
        Public Const TKT_USED_DD As String = "利用日"
        Public Const KOUENKAI_NO As String = "講演会番号"
        Public Const SANKASHA_ID As String = "参加者ID"
        Public Const DR_NAME As String = "DR氏名"
        Public Const TKT_HAKKO_DATE As String = "発行日"
        Public Const TKT_LINE_NO As String = "行番号"
        Public Const TKT_URIAGE As String = "実車料金"
        Public Const TKT_JISSHA_DATE As String = "実車日"
        'Public Const TKT_VOID As String = "VOID"
        Public Const TKT_OTHER As String = "その他"
        Public Const TKT_HATUTI As String = "実車発地"
        Public Const TKT_CHAKUTI As String = "実車着地"
    End Class

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '遷移元チェック
        If Not Page.IsPostBack Then
            If Not MyModule.IsReferer(Request) Then
                Session.Abandon()
                Response.Redirect(URL.SorryPage)
            End If
        End If

        '共通チェック
        MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()
        End If

        'マスターページ設定
        With Me.Master
            .DispTaxiMenu = True
            .PageTitle = "その他タクチケ実績データ取込"
        End With

    End Sub

    '画面項目 初期化
    Private Sub InitControls()
        Me.TrError.Visible = False
        Me.TrEnd.Visible = False

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '[取込開始]
    Private Sub BtnTorikomi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTorikomi.Click
        Me.LabelErrorMessage.Text = ""
        Me.TrError.Visible = False
        Me.TrEnd.Visible = False

        '入力チェック
        If Not Check() Then Exit Sub

        'フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
        If Not Directory.Exists(Server.MapPath(WebConfig.Site.JISSEKI_CSV)) Then Directory.CreateDirectory(Server.MapPath(WebConfig.Site.JISSEKI_CSV))
        If Not Directory.Exists(Server.MapPath(WebConfig.Site.JISSEKI_CSV_BK)) Then Directory.CreateDirectory(Server.MapPath(WebConfig.Site.JISSEKI_CSV_BK))

        '指定されたファイルをサーバに保存
        Try
            FileUpload1.PostedFile.SaveAs(Server.MapPath(WebConfig.Site.JISSEKI_CSV) & FileUpload1.FileName)
        Catch ex As Exception
            CmnModule.AlertMessage("実績データをアップロードできませんでした。", Me)
            Exit Sub
        End Try

        'CSVファイルをタクチケTBLへImport
        Dim workFiles() As String = Directory.GetFiles(Server.MapPath(WebConfig.Site.JISSEKI_CSV))
        workFiles = Directory.GetFiles(Server.MapPath(WebConfig.Site.JISSEKI_CSV))
        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
        If workFiles.Length = 0 Then
            CmnModule.AlertMessage("取込対象CSVファイルが存在しません。", Me)
            Exit Sub
        End If

        Dim insCnt As Integer = 0  '取込み件数カウント        Dim filePath As String = Server.MapPath(WebConfig.Site.JISSEKI_CSV) & FileUpload1.FileName
        ImportData(filePath, insCnt)

        Me.LabelErrorMessage.Text &= (insCnt * -1).ToString & "件のデータを登録しました。" & vbNewLine

        '作業フォルダ→バックアップフォルダへコピー
        '作業フォルダからファイルを削除
        Try
            File.Copy(filePath, Server.MapPath(WebConfig.Site.JISSEKI_CSV_BK) & Path.GetFileName(filePath))
        Catch ex As Exception
            File.Copy(filePath, Server.MapPath(WebConfig.Site.JISSEKI_CSV_BK) & Path.GetFileNameWithoutExtension(filePath) _
                                                                    & "_" & Now.ToString("yyyyMMddHHmmss") & Path.GetExtension(filePath))
        End Try
        File.Delete(filePath)
    End Sub

    'ファイル読み込み
    Private Function ImportData(ByVal strFilePath As String, ByRef insCnt As Integer) As Boolean

        Dim parser As FileIO.TextFieldParser
        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        'ファイルの有無チェック
        If File.Exists(strFilePath) Then
            'CSVファイルをTextFieldParserクラスを使用して読み込む
            parser = New FileIO.TextFieldParser(strFilePath, System.Text.Encoding.GetEncoding("SHIFT-JIS"))
        Else
            'MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiJisseki, TBL_LOG, False, strFilePath & "が見つかりません。", MyBase.DbConnection)
            Me.LabelErrorMessage.Text &= strFilePath & "が見つかりません。" & vbNewLine
            Exit Function
        End If

        'フィールドが区切られていることを指定
        parser.TextFieldType = FileIO.FieldType.Delimited
        parser.SetDelimiters(pDelimiter)

        'ダブルクォート囲み、ダブルクォートのエスケープ対応
        parser.HasFieldsEnclosedInQuotes = True

        Dim strFileName As String = Path.GetFileName(strFilePath)
        Dim rowCnt As Integer = 0  '行数カウント
        Dim ErrorMessage As String = String.Empty

        While Not parser.EndOfData
            Dim fileData As String() = parser.ReadFields() ' 1行読み込み
            rowCnt += 1

            '1行目はタイトル行のため読み飛ばす
            If rowCnt > 1 Then
                If CheckInput(fileData, strFileName, rowCnt.ToString, ErrorMessage) Then
                    'タクチケ発行テーブル更新
                    insCnt += UpdateTable(fileData, strFileName, rowCnt, ErrorMessage)
                End If
            End If
        End While

        'インスタンス開放
        parser.Dispose()

        If Trim(ErrorMessage) <> "" Then
            Me.TrError.Visible = True
            Me.TrEnd.Visible = False
            Me.LabelErrorMessage.Text = ErrorMessage
            Return False
        Else
            Me.TrError.Visible = False
            Me.TrEnd.Visible = True
            Me.LabelUpdatedCount.Text = (rowCnt - 1).ToString
            Return True
        End If

    End Function

    '入力チェック
    Private Function Check() As Boolean
        If Me.FileUpload1.FileName.Trim = String.Empty Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("取込む実績データ"), Me)
            Return False
        End If
        Return True
    End Function

    'CSVデータ内容チェック
    Private Function CheckInput(ByVal fileData As String(), ByVal strfileName As String, ByVal strRowCnt As String, ByRef ErrorMessage As String) As Boolean
        Dim errFlag As Boolean = True
        Try
            '項目数チェック
            If fileData.Count <> COL_COUNT Then
                errFlag = False
                ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & "項目数が不正です。" & vbNewLine
            End If
            'Select Case fileData(COL_NO.KAISHA_CD)
            '    Case "AK"
            '        If fileData.Count <> COL_COUNT_AK Then
            '            errFlag = False
            '            ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & "項目数が不正です。" & vbNewLine
            '        End If
            '    Case "HW"
            '        If fileData.Count <> COL_COUNT_HW Then
            '            errFlag = False
            '            ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & "項目数が不正です。" & vbNewLine
            '        End If
            '    Case Else
            '        If fileData.Count <> COL_COUNT_OTH Then
            '            errFlag = False
            '            ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & "項目数が不正です。" & vbNewLine
            '        End If
            '
            'Case "SM"
            '    If fileData.Count <> COL_COUNT_SM Then
            '        errFlag = False
            '        ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & "項目数が不正です。" & vbNewLine
            '    End If
            'Case "TN"
            '    If fileData.Count <> COL_COUNT_TN Then
            '        errFlag = False
            '        ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & "項目数が不正です。" & vbNewLine
            '    End If
            'End Select

            'If fileData(COL_NO.KAISHA_CD).Trim.Equals(String.Empty) Then
            '    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.KAISHA_CD & "がセットされていません。" & vbNewLine
            'End If

            'If fileData(COL_NO.TKT_NO).Trim.Equals(String.Empty) Then
            '    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.TKT_NO & "がセットされていません。" & vbNewLine
            'End If

            'If fileData(COL_NO.TKT_USED_DATE).Trim.Equals(String.Empty) Then
            '    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.TKT_USED_DATE & "がセットされていません。" & vbNewLine
            'End If

            If fileData(COL_NO.KOUENKAI_NO).Trim.Equals(String.Empty) Then
                errFlag = False
                ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.KOUENKAI_NO & "がセットされていません。" & vbNewLine
            End If

            If fileData(COL_NO.KOUENKAI_NO).Trim.Length > 14 Then
                errFlag = False
                ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.KOUENKAI_NO & "の桁数が14桁を超えています。" & vbNewLine
            End If

            If fileData(COL_NO.SANKASHA_ID).Trim.Length > 14 Then
                errFlag = False
                ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.SANKASHA_ID & "の桁数が14桁を超えています。" & vbNewLine
            End If

            'If fileData(COL_NO.SANKASHA_ID).Trim.Equals(String.Empty) Then
            '    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.SANKASHA_ID & "がセットされていません。" & vbNewLine
            'End If

            'If fileData(COL_NO.TKT_HAKKO_DATE).Trim.Equals(String.Empty) Then
            '    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.TKT_HAKKO_DATE & "がセットされていません。" & vbNewLine
            'End If

            'If fileData(COL_NO.TKT_LINE_NO).Trim.Equals(String.Empty) Then
            '    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.TKT_LINE_NO & "がセットされていません。" & vbNewLine
            'End If

            'If fileData(COL_NO.TKT_URIAGE).Trim.Equals(String.Empty) Then
            '    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.TKT_URIAGE & "がセットされていません。" & vbNewLine
            'End If

            'If fileData(COL_NO.TKT_JISSHA_DATE).Trim.Equals(String.Empty) Then
            '    ErrorMessage &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.TKT_JISSHA_DATE & "がセットされていません。" & vbNewLine
            'End If

        Catch ex As Exception
            Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
            'Dim strErrMsg As String = strfileName & "【" & strRowCnt & "行目】" & ex.Message
            'MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiJisseki, TBL_LOG, False, strErrMsg, MyBase.DbConnection)
            Return False
        End Try

        Return errFlag
    End Function

    'データ登録
    Private Function UpdateTable(ByVal fileData As String(), ByVal strFileName As String, ByVal rowCnt As Long, ByRef ErrorMessage As String) As Integer

        Dim strSQL As String = ""
        Dim insCnt As Integer = 0

        '実績CSVの内容をタクチケ発行テーブルの項目へセット
        Call SetItem(fileData)
        Try
            'タクチケ発行テーブル更新対象レコード取得
            If GetTaxiticketHakko(fileData(COL_NO.TKT_NO)) Then
                strSQL = SQL.TBL_TAXITICKET_HAKKO.Update_OTH(TBL_TAXITICKET_HAKKO)
            Else
                strSQL = SQL.TBL_TAXITICKET_HAKKO.Insert_OTH(TBL_TAXITICKET_HAKKO)
            End If
            insCnt = CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()
            Return True
        Catch ex As Exception
            MyBase.Rollback()
            Me.LabelErrorMessage.Text &= "[データ取込失敗]" & Session.Item(SessionDef.DbError) & " SQL:" & strSQL & vbNewLine
            Return False
        End Try

        Return insCnt
    End Function

    'タクチケ発行情報取得
    Private Function GetTaxiticketHakko(ByVal TKT_NO As String) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = Sql.TBL_TAXITICKET_HAKKO.byTKT_NO(TKT_NO)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wFlag = True
            TBL_TAXITICKET_HAKKO = AppModule.SetRsData(RsData, TBL_TAXITICKET_HAKKO)
        End If
        RsData.Close()

        Return wFlag
    End Function

    '参加者情報取得
    Private Function GetDrSanka(ByVal KOUENKAI_NO As String, ByVal SANKASHA_ID As String) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim TBL_SANKA As New AppLib.TableDef.TBL_SANKA.DataStruct

        strSQL = SQL.TBL_SANKA.byKOUENKAI_NO_SANKASHA_ID(KOUENKAI_NO, SANKASHA_ID)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            TBL_SANKA = AppModule.SetRsData(RsData, TBL_SANKA)
            If TBL_SANKA.DR_SANKA = AppConst.KOTSUHOTEL.DR_SANKA.Code.Yes Then
                wFlag = True
            End If
        End If
        RsData.Close()

        Return wFlag
    End Function

    '実績CSV→タクチケ発行テーブル項目セット
    Private Sub SetItem(ByVal filedata() As String)
        Dim wDate As Date = filedata(COL_NO.TKT_JISSHA_DATE)
        Dim wUsedDate As String = String.Empty

        If InStr(filedata(COL_NO.TKT_USED_DATE), "/") Then
            Dim wDate2 As Date = filedata(COL_NO.TKT_USED_DATE)
            wUsedDate = CmnModule.Format_DateToString(wDate2, CmnModule.DateFormatType.YYYYMMDD)
        Else
            wUsedDate = filedata(COL_NO.TKT_USED_DATE)
        End If

        TBL_TAXITICKET_HAKKO.TKT_KAISHA = filedata(COL_NO.KAISHA_CD)
        TBL_TAXITICKET_HAKKO.TKT_NO = filedata(COL_NO.TKT_NO)
        Select Case filedata(COL_NO.KAISHA_CD)
            Case "AK"
                TBL_TAXITICKET_HAKKO.TKT_KENSHU = "AK5000"
            Case "HW"
                TBL_TAXITICKET_HAKKO.TKT_KENSHU = "HW10000"
            Case "SM"
                TBL_TAXITICKET_HAKKO.TKT_KENSHU = "SM5000"
            Case "TN"
                TBL_TAXITICKET_HAKKO.TKT_KENSHU = "TN5000"
            Case "KN"
                TBL_TAXITICKET_HAKKO.TKT_KENSHU = "KN10000"
        End Select
        TBL_TAXITICKET_HAKKO.KOUENKAI_NO = filedata(COL_NO.KOUENKAI_NO)
        TBL_TAXITICKET_HAKKO.SANKASHA_ID = filedata(COL_NO.SANKASHA_ID)
        TBL_TAXITICKET_HAKKO.TKT_LINE_NO = filedata(COL_NO.TKT_LINE_NO)
        TBL_TAXITICKET_HAKKO.TKT_USED_DATE = CmnModule.Format_DateToString(wDate, CmnModule.DateFormatType.YYYYMMDD)
        TBL_TAXITICKET_HAKKO.TKT_URIAGE = filedata(COL_NO.TKT_URIAGE).Replace(",", "").ToString
        TBL_TAXITICKET_HAKKO.TKT_HAKKO_FEE = HAKKO_TESURYO
        TBL_TAXITICKET_HAKKO.TKT_SEISAN_FEE = SEISAN_TESURYO
        TBL_TAXITICKET_HAKKO.TKT_HATUTI = filedata(COL_NO.TKT_HATUTI)
        TBL_TAXITICKET_HAKKO.TKT_CHAKUTI = filedata(COL_NO.TKT_CHAKUTI)

        'CSVの利用日と実車日が異なる場合、エンタ="N"
        TBL_TAXITICKET_HAKKO.TKT_ENTA = String.Empty
        If wUsedDate <> TBL_TAXITICKET_HAKKO.TKT_USED_DATE Then
            TBL_TAXITICKET_HAKKO.TKT_ENTA = "N"
            'Else
            '    '参加情報無または欠席の場合、エンタ="E"
            '    If Not GetDrSanka(filedata(COL_NO.KOUENKAI_NO), filedata(COL_NO.SANKASHA_ID)) Then
            '        TBL_TAXITICKET_HAKKO.TKT_ENTA = "E"
            '    End If
        End If

        TBL_TAXITICKET_HAKKO.TKT_VOID = "0"
        TBL_TAXITICKET_HAKKO.TKT_MIKETSU = "0"
        TBL_TAXITICKET_HAKKO.TKT_IMPORT_DATE = Now.ToString("yyyyMMdd")
        TBL_TAXITICKET_HAKKO.TKT_SEIKYU_YM = String.Empty
        TBL_TAXITICKET_HAKKO.SEIKYU_NO_TOPTOUR = String.Empty
        TBL_TAXITICKET_HAKKO.INPUT_DATE = Now.ToString("yyyyMMddHHmmss")
        TBL_TAXITICKET_HAKKO.INPUT_USER = "adminkw"
        TBL_TAXITICKET_HAKKO.UPDATE_DATE = Now.ToString("yyyyMMddHHmmss")
        TBL_TAXITICKET_HAKKO.UPDATE_USER = "adminkw"

    End Sub
End Class
