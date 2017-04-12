Imports CommonLib
Imports AppLib
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO

Partial Public Class TaxiDaichoDLUL
    Inherits WebBase

    Private Const COL_COUNT As Integer = 3 'ファイルの項目数
    Private TBL_FILE() As TableDef.TBL_FILE.DataStruct
    Private TBL_TAXIDAICHO As TableDef.TBL_TAXIDAICHO.DataStruct
    Private Joken As TableDef.Joken.DataStruct
    Private grv_selected() As String
    Private Const pDelimiter As String = ","

    Private Enum COL_NO
        KOUENKAI_NO = 0
        KOUENKAI_NAME
        FROM_DATE
    End Enum

    Private Class COL_NAME
        Public Const KOUENKAI_NO As String = "会合番号"
        Public Const KOUENKAI_NAME As String = "会合名"
        Public Const FROM_DATE As String = "開催開始日"
    End Class
    'グリッド列    Private Enum CellIndex
        ROW_NO
        DATA_CHK
        FILE_NAME
        INS_DATE
        FILE_TYPE
        BUTTON1
    End Enum

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '遷移元チェック
        If Not Page.IsPostBack Then
            If Not MyModule.IsReferer(Request) Then
                Session.Abandon()
                Response.Redirect(URL.SorryPage)
            End If
        End If

        '共通チェック
        MyModule.IsPageOK(False, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()
            Me.TrButton1.Visible = False
            Me.TrButton2.Visible = False
            Me.LabelCount.Visible = False
            Me.LabelNoData.Visible = False
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .DispTaxiMenu = True
            .PageTitle = "タクチケ台帳出力対象データ ダウンロード・アップロード"
        End With

    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()
        Me.TrError.Visible = False
        Me.TrEnd.Visible = False

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        Return True
    End Function

    '画面項目 表示
    Private Sub SetForm()

        'データ取得
        TBL_FILE = Nothing
        Joken = Nothing

        If Not GetData(Joken, TBL_FILE) Then
            Me.LabelNoData.Visible = True
            Me.GrvList.Visible = False
        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True

            'グリッドビュー表示
            Session.Item(SessionDef.PageIndex) = 0
            SetGridView()
        End If
    End Sub

    'データ取得
    Private Function GetData(ByVal Joken As TableDef.Joken.DataStruct, ByRef pFILE() As TableDef.TBL_FILE.DataStruct) As Boolean
        Dim strSQL As String = ""
        Dim i As Integer = 0
        Dim wFlag As Boolean = False
        Dim wKouenkaiFlag As Boolean = False
        Dim wSeikyuFlag As Boolean = False

        Erase pFILE

        strSQL &= "SELECT *"
        strSQL &= " FROM TBL_FILE"
        strSQL &= " WHERE"
        strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.FILE_KBN & "=@" & TableDef.TBL_FILE.Column.FILE_KBN

        If Trim(Joken.FILE_NAME) <> "" Then
            strSQL &= " AND"
            strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.FILE_NAME & "=@" & TableDef.TBL_FILE.Column.FILE_NAME
        End If

        If Trim(Joken.KOUENKAI_NO) <> "" Then
            strSQL &= " AND"
            strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.FILE_NAME & " LIKE @" & TableDef.TBL_FILE.Column.FILE_NAME
            wKouenkaiFlag = True
        End If

        If Trim(Joken.SEIKYU_NO_TOPTOUR) <> "" Then
            If Not wKouenkaiFlag Then
                strSQL &= " AND"
                strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.FILE_NAME & " LIKE @" & TableDef.TBL_FILE.Column.FILE_NAME
            End If
            wSeikyuFlag = True
        End If

        strSQL &= " ORDER BY"
        strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.INS_DATE & " DESC"

        Dim objCom As New SqlCommand(strSQL, Me.DbConnection)
        objCom.Parameters.AddWithValue("@" & TableDef.TBL_FILE.Column.FILE_KBN, AppConst.FILE_KBN.Code.TaxiMeisaiTaisho)
        If Trim(Joken.FILE_NAME) <> "" Then
            objCom.Parameters.AddWithValue("@" & TableDef.TBL_FILE.Column.FILE_NAME, Joken.FILE_NAME)
        End If
        If Trim(Joken.KOUENKAI_NO) <> "" Then
            If Not wSeikyuFlag Then
                objCom.Parameters.Add(New SqlClient.SqlParameter(TableDef.TBL_FILE.Column.FILE_NAME, Joken.KOUENKAI_NO & "%"))
            Else
                Dim strLen As Integer = 29 - Len(Trim(Joken.KOUENKAI_NO)) - Len(Trim(Joken.SEIKYU_NO_TOPTOUR))
                objCom.Parameters.Add(New SqlClient.SqlParameter(TableDef.TBL_FILE.Column.FILE_NAME, Joken.KOUENKAI_NO & StrDup(strLen, "_"c) & Joken.SEIKYU_NO_TOPTOUR & "%"))
            End If
        End If
        If Trim(Joken.SEIKYU_NO_TOPTOUR) <> "" Then
            If Not wKouenkaiFlag Then
                objCom.Parameters.Add(New SqlClient.SqlParameter(TableDef.TBL_FILE.Column.FILE_NAME, "%" & Joken.SEIKYU_NO_TOPTOUR & "%"))
            End If
        End If

        Dim objRs As Object = objCom.ExecuteReader()
        Try
            While objRs.read()
                ReDim Preserve pFILE(i)
                pFILE(i).FILE_NAME = objRs.item(TableDef.TBL_FILE.ColumnNo.FILE_NAME)
                pFILE(i).FILE_TYPE = objRs.item(TableDef.TBL_FILE.ColumnNo.FILE_TYPE)
                pFILE(i).DATUME = CType(objRs.item(TableDef.TBL_FILE.ColumnNo.DATUME), Byte())
                i += 1
                wFlag = True
            End While
        Catch ex As Exception
            objRs.close()
            objCom.Cancel()
            Return False
        End Try
        objRs.close()
        objCom.Cancel()

        If i = 0 Then
            Me.TrButton1.Visible = False
            Me.TrButton2.Visible = False
            Me.LabelCount.Visible = False
            Me.LabelNoData.Visible = True
        Else
            Me.TrButton1.Visible = True
            Me.TrButton2.Visible = True
            Me.LabelCount.Visible = True
            Me.LabelNoData.Visible = False
            Me.LabelCount.Text = i.ToString & "件"
        End If
        Return wFlag
    End Function

    'グリッドビュー表示項目取得

    Private Function GetGridData() As Boolean
        Dim strSQL As String = ""
        Dim i As Integer = 0
        Dim wFlag As Boolean = False

        strSQL &= "SELECT *"
        strSQL &= " FROM TBL_FILE"

        strSQL &= " ORDER BY"
        strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.INS_DATE & " DESC"

        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL
        Me.SqlDataSource1.SelectParameters.Clear()

        With Me.GrvList
            Try
                .PageIndex = CmnModule.DbVal(Session.Item(SessionDef.PageIndex))
                .DataBind()
            Catch ex As Exception
                Session.Item(SessionDef.PageIndex) = 0
                .PageIndex = CmnModule.DbVal(Session.Item(SessionDef.PageIndex))
                .DataBind()
            End Try
            .Attributes(CmnConst.Html.Attributes.BorderColor) = CmnConst.Html.Color.Border
        End With
    End Function

    'データソース設定
    Private Sub SetGridView()
        Dim strSQL As String = ""
        Dim wKouenkaiFlag As Boolean = False
        Dim wSeikyuFlag As Boolean = False

        'データソース設定
        strSQL &= "SELECT *"
        strSQL &= " FROM TBL_FILE"
        strSQL &= " WHERE"
        strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.FILE_KBN & "='" & AppConst.FILE_KBN.Code.TaxiMeisaiTaisho & "'"

        If Trim(Joken.FILE_NAME) <> "" Then
            strSQL &= " AND"
            strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.FILE_NAME & "=@" & TableDef.TBL_FILE.Column.FILE_NAME
        End If

        If Trim(Joken.KOUENKAI_NO) <> "" Then
            strSQL &= " AND"
            strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.FILE_NAME & " LIKE @" & TableDef.TBL_FILE.Column.FILE_NAME
            wKouenkaiFlag = True
        End If

        If Trim(Joken.SEIKYU_NO_TOPTOUR) <> "" Then
            If Not wKouenkaiFlag Then
                strSQL &= " AND"
                strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.FILE_NAME & " LIKE @" & TableDef.TBL_FILE.Column.FILE_NAME
            End If
            wSeikyuFlag = True
        End If

        strSQL &= " ORDER BY"
        strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.INS_DATE & " DESC"

        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL
        Me.SqlDataSource1.SelectParameters.Clear()

        If Trim(Joken.KOUENKAI_NO) <> "" Then
            If Not wSeikyuFlag Then
                Me.SqlDataSource1.SelectParameters.Add(TableDef.TBL_FILE.Column.FILE_NAME, Joken.KOUENKAI_NO & "%")
            Else
                Dim strLen As Integer = 29 - Len(Trim(Joken.KOUENKAI_NO)) - Len(Trim(Joken.SEIKYU_NO_TOPTOUR))
                Me.SqlDataSource1.SelectParameters.Add(TableDef.TBL_FILE.Column.FILE_NAME, Joken.KOUENKAI_NO & StrDup(strLen, "_"c) & Joken.SEIKYU_NO_TOPTOUR & "%")
            End If
        End If
        If Trim(Joken.SEIKYU_NO_TOPTOUR) <> "" Then
            If Not wKouenkaiFlag Then
                Me.SqlDataSource1.SelectParameters.Add(TableDef.TBL_FILE.Column.FILE_NAME, "%" & Joken.SEIKYU_NO_TOPTOUR & "%")
            End If
        End If

        With Me.GrvList
            Try
                .PageIndex = CmnModule.DbVal(Session.Item(SessionDef.PageIndex))
                .DataBind()
            Catch ex As Exception
                Session.Item(SessionDef.PageIndex) = 0
                .PageIndex = CmnModule.DbVal(Session.Item(SessionDef.PageIndex))
                .DataBind()
            End Try
            .Attributes(CmnConst.Html.Attributes.BorderColor) = CmnConst.Html.Color.Border
        End With
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.FILE_TYPE).Visible = False
        ElseIf e.Row.RowType = DataControlRowType.Pager Then
            CType(e.Row.Controls(0), TableCell).ColumnSpan = CType(e.Row.Controls(0), TableCell).ColumnSpan - 0
            Me.GrvList.BorderStyle = BorderStyle.None
            Dim PagerTableCell As TableCell = e.Row.Cells(0)
            PagerTableCell.BorderStyle = BorderStyle.None
        End If
    End Sub

    'グリッドビュー内書式設定
    Private Sub GrvList_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            'CSV作成日
            e.Row.Cells(CellIndex.INS_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.INS_DATE).Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        End If
    End Sub

    'グリッドビュー ページ移動時
    Protected Sub GrvList_PageIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrvList.PageIndexChanged
        With Me.GrvList

            '選択行をキャンセル
            .SelectedIndex = -1
            'カレントページを変更
            Session.Item(SessionDef.PageIndex) = .PageIndex

            'グリッドビュー表示
            SetGridView()
        End With
    End Sub

    'グリッドビュー コマンドボタン押下時
    Protected Sub GrvList_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GrvList.RowCommand
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim row As GridViewRow = GrvList.Rows(index)

        Select Case e.CommandName
            Case "Download"
                '精算番号表CSVダウンロード
                Joken.FILE_NAME = DirectCast(GrvList.Rows(index).Controls(CellIndex.FILE_NAME), DataControlFieldCell).Text()
                Call DLCsvFile(Joken)
        End Select
    End Sub

    '[総合精算書PDFファイルダウンロード]
    Protected Sub DLCsvFile(ByVal Joken As TableDef.Joken.DataStruct)
        Dim wFILE(0) As TableDef.TBL_FILE.DataStruct

        '書類テーブルデータ取得
        If Not GetData(Joken, wFILE) Then Exit Sub

        Response.HeaderEncoding = System.Text.Encoding.GetEncoding("shift_jis")
        Response.AddHeader("Content-Disposition", "attachment;filename=" & wFILE(0).FILE_NAME)
        Response.ContentType = wFILE(0).FILE_TYPE
        Response.BinaryWrite(wFILE(0).DATUME)
        Response.End()
    End Sub

    '[総合精算書PDFファイル削除]
    Private Function DeleteTBL_FILE(ByVal Joken As TableDef.Joken.DataStruct) As Boolean
        Dim strSQL As String = ""

        'データソース設定
        strSQL = "DELETE FROM TBL_FILE WHERE FILE_NAME='" & Joken.FILE_NAME & "'"

        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.DeleteCommand = strSQL
        Me.SqlDataSource1.DeleteParameters.Clear()
        Me.SqlDataSource1.DeleteParameters.Add("FILE_NAME", Joken.FILE_NAME)

        With Me.GrvList
            Try
                .PageIndex = CmnModule.DbVal(Session.Item(SessionDef.PageIndex))
                .DataBind()
            Catch ex As Exception
                Session.Item(SessionDef.PageIndex) = 0
                .PageIndex = CmnModule.DbVal(Session.Item(SessionDef.PageIndex))
                .DataBind()
            End Try
            .Attributes(CmnConst.Html.Attributes.BorderColor) = CmnConst.Html.Color.Border
        End With

        Return True
    End Function

    '[削除]
    Private Sub BtnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelete1.Click, BtnDelete2.Click
        Dim i As Integer = 0

        For Each row As GridViewRow In Me.GrvList.Rows
            If DirectCast(row.FindControl("chkDelete"), CheckBox).Checked Then
                '精算番号表CSV削除
                Joken.FILE_NAME = DirectCast(GrvList.Rows(i).Controls(CellIndex.FILE_NAME), DataControlFieldCell).Text()
                Call DeleteTBL_FILE(Joken)
            End If
            i += 1
        Next

        '精算番号表CSV再表示
        Call SetForm()
    End Sub

    '[全選択]
    Protected Sub BtnAllSelect_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAllSelect1.Click, BtnAllSelect2.Click

        For i As Integer = 0 To GrvList.Rows.Count - 1
            Dim cell As TableCell = GrvList.Rows(i).Cells(CellIndex.DATA_CHK)
            Dim c As CheckBox = cell.FindControl("chkDelete")
            c.Checked = True
        Next

    End Sub

    '[全解除]
    Private Sub BtnAllClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnAllClear1.Click, BtnAllClear2.Click

        For i As Integer = 0 To GrvList.Rows.Count - 1
            Dim cell As TableCell = GrvList.Rows(i).Cells(CellIndex.DATA_CHK)
            Dim c As CheckBox = cell.FindControl("chkDelete")
            c.Checked = False
        Next

    End Sub

    '[戻る]
    Private Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click, BtnBack2.Click
        Response.Redirect(URL.TaxiMenu)
    End Sub

    '[取込開始]
    Protected Sub BtnTorikomi_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTorikomi.Click
        Me.LabelErrorMessage.Text = ""
        Me.TrError.Visible = False
        Me.TrEnd.Visible = False

        '入力チェック
        If Not Check() Then Exit Sub

        'フォルダが存在しないとエラーになるので念のためフォルダの存在チェック
        If Not Directory.Exists(Server.MapPath(WebConfig.Site.TAXI_DAICHO_CSV)) Then Directory.CreateDirectory(Server.MapPath(WebConfig.Site.TAXI_DAICHO_CSV))
        If Not Directory.Exists(Server.MapPath(WebConfig.Site.TAXI_DAICHO_CSV_BK)) Then Directory.CreateDirectory(Server.MapPath(WebConfig.Site.TAXI_DAICHO_CSV))

        '指定されたファイルをサーバに保存
        Try
            FileUpload1.PostedFile.SaveAs(Server.MapPath(WebConfig.Site.TAXI_DAICHO_CSV) & FileUpload1.FileName)
        Catch ex As Exception
            CmnModule.AlertMessage("タクチケ台帳出力対象CSVファイルをアップロードできませんでした。", Me)
            Exit Sub
        End Try

        'タクチケ台帳出力対象テーブルへImport
        Dim workFiles() As String = Directory.GetFiles(Server.MapPath(WebConfig.Site.TAXI_DAICHO_CSV))
        workFiles = Directory.GetFiles(Server.MapPath(WebConfig.Site.TAXI_DAICHO_CSV))
        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
        If workFiles.Length = 0 Then
            'ログ登録
            CmnModule.AlertMessage("取込対象CSVファイルが存在しません。", Me)
            Exit Sub
        End If

        Dim insCnt As Integer = 0  '取込み件数カウント        Dim filePath As String = Server.MapPath(WebConfig.Site.TAXI_DAICHO_CSV) & FileUpload1.FileName
        ImportData(filePath, insCnt)

        '作業フォルダ→バックアップフォルダへコピー
        '作業フォルダからファイルを削除
        Try
            File.Copy(filePath, Server.MapPath(WebConfig.Site.TAXI_DAICHO_CSV) & Path.GetFileName(filePath))
        Catch ex As Exception
            File.Copy(filePath, Server.MapPath(WebConfig.Site.TAXI_DAICHO_CSV) & Path.GetFileNameWithoutExtension(filePath) _
                                                                    & "_" & Now.ToString("yyyyMMddHHmmss") & Path.GetExtension(filePath))
        End Try
        File.Delete(filePath)
    End Sub

    'ファイル読み込み→テーブル保存
    Private Function ImportData(ByVal strFilePath As String, ByRef insCnt As Integer) As Boolean

        Dim parser As FileIO.TextFieldParser
        Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing

        'ファイルの有無チェック
        If File.Exists(strFilePath) Then
            'CSVファイルをTextFieldParserクラスを使用して読み込む
            parser = New FileIO.TextFieldParser(strFilePath, System.Text.Encoding.GetEncoding("SHIFT-JIS"))
        Else
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

                    Dim updCnt As Integer = 0
                    'タクチケ台帳出力対象テーブルデータ項目セット()
                    TBL_TAXIDAICHO = SetDaichoItem(fileData)
                    'タクチケ台帳出力対象データ存在チェック
                    If GetDaichoData(fileData(COL_NO.KOUENKAI_NO)) Then
                        updCnt = UpdateTaxiDaicho(ErrorMessage)
                    Else
                        'タクチケ台帳出力対象登録件数チェック
                        If GetDaichoCount() > Integer.Parse(WebConfig.Site.DAICHO_MAX_COUNT) Then
                            Me.LabelErrorMessage.Text &= strFilePath & "【会合番号" & TBL_TAXIDAICHO.KOUENKAI_NO & "】タクチケ台帳出力の予約数が200を超えたので処理を中断します。" & vbNewLine
                            Exit Function
                        Else
                            updCnt = InsertTaxiDaicho(ErrorMessage)
                        End If
                    End If

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

    'CSVデータ内容チェック
    Private Function CheckInput(ByVal fileData As String(), ByVal strfileName As String, ByVal strRowCnt As String, ByRef ErrorMessage As String) As Boolean
        Dim ErrStr As String = ""

        Try
            '項目数チェック
            If fileData.Count <> COL_COUNT Then
                ErrStr &= strfileName & "【" & strRowCnt & "行目】" & "項目数が不正です。" & vbNewLine
            End If

            If fileData(COL_NO.KOUENKAI_NO).Trim.Equals(String.Empty) Then
                ErrStr &= strfileName & "【" & strRowCnt & "行目】" & COL_NAME.KOUENKAI_NO & "がセットされていません。" & vbNewLine
            End If

        Catch ex As Exception
            Dim TBL_LOG As TableDef.TBL_LOG.DataStruct = Nothing
            Return False
        End Try

        If Trim(ErrStr) <> "" Then
            ErrorMessage &= ErrStr
            Me.TrError.Visible = True
            Me.TrEnd.Visible = False
            Me.LabelErrorMessage.Text = ErrorMessage
            Return False
        Else
            Return True
        End If

    End Function

    'タクチケ台帳出力対象テーブルデータ登録済チェック
    Private Function GetDaichoData(ByVal KouenkaiNo As String) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_TAXIDAICHO.byKOUENKAI_NO(KouenkaiNo)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wFlag = True
            TBL_TAXIDAICHO = AppModule.SetRsData(RsData, TBL_TAXIDAICHO)
        End If
        RsData.Close()

        Return wFlag
    End Function

    'タクチケ台帳出力対象テーブル件数チェック
    Private Function GetDaichoCount() As Integer
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wCnt As Integer = 0

        strSQL = SQL.TBL_TAXIDAICHO.GetCount()
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wCnt = RsData(TableDef.TBL_TAXIDAICHO.Column.W_CNT)
        End If
        RsData.Close()

        Return wCnt
    End Function

    'CSV→タクチケ台帳出力対象テーブル項目セット
    Private Function SetDaichoItem(ByVal filedata() As String) As TableDef.TBL_TAXIDAICHO.DataStruct

        TBL_TAXIDAICHO.KOUENKAI_NO = filedata(COL_NO.KOUENKAI_NO)
        TBL_TAXIDAICHO.FROM_DATE = filedata(COL_NO.FROM_DATE)
        TBL_TAXIDAICHO.OUTPUT_FLAG = CmnConst.Flag.Off
        TBL_TAXIDAICHO.INPUT_USER = Session.Item(SessionDef.LoginID)
        TBL_TAXIDAICHO.UPDATE_USER = Session.Item(SessionDef.LoginID)

        Return TBL_TAXIDAICHO
    End Function

    Private Function InsertTaxiDaicho(ByRef ErrorMessage As String) As Integer

        Dim strSQL As String = ""
        Dim insCnt As Integer = 0

        Try
            strSQL = SQL.TBL_TAXIDAICHO.Insert(TBL_TAXIDAICHO)
            insCnt = CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()
            Return True

        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            ErrorMessage &= "[タクチケ台帳出力対象テーブル追加失敗]" & Session.Item(SessionDef.DbError) & " SQL:" & strSQL & vbNewLine
            Return False
        End Try

        '登録成功件数を返す
        Return insCnt

    End Function

    Private Function UpdateTaxiDaicho(ByRef ErrorMessage As String) As Integer

        Dim strSQL As String = ""
        Dim insCnt As Integer = 0

        Try
            strSQL = SQL.TBL_TAXIDAICHO.Update(TBL_TAXIDAICHO)
            insCnt = CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()
            Return True

        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            ErrorMessage &= "[タクチケ台帳出力対象テーブル更新失敗]" & Session.Item(SessionDef.DbError) & " SQL:" & strSQL & vbNewLine
            Return False
        End Try

        '登録成功件数を返す
        Return insCnt

    End Function
End Class