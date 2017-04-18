Imports CommonLib
Imports AppLib
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.IO

Partial Public Class TaxiMeisaiDL
    Inherits WebBase

    Private TBL_FILE() As TableDef.TBL_FILE.DataStruct
    Private Joken As TableDef.Joken.DataStruct
    Private grv_selected() As String

    'グリッド列    Private Enum CellIndex
        ROW_NO
        DATA_CHK
        FILE_NAME
        INS_DATE
        FILE_TYPE
        'BUTTON1
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
            'SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .DispTaxiMenu = True
            .PageTitle = "タクチケ台帳CSVダウンロード"
        End With

    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()

        'クリア
        CmnModule.ClearAllControl(Me)

        '確認メッセージ
        Me.BtnDelete1.Attributes(CmnConst.Html.Attributes.OnClick) = CmnModule.GetJavaConfirm("選択されている全てのタクチケ台帳CSVを削除します。よろしいですか？")
        Me.BtnDelete2.Attributes(CmnConst.Html.Attributes.OnClick) = CmnModule.GetJavaConfirm("選択されている全てのタクチケ台帳CSVを削除します。よろしいですか？")
    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsAlphanumericHyphen(Me.JokenKOUENKAI_NO) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphanumericHyphenOnly("会合番号"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("開催日From(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("開催日From(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_DD) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("開催日From(日)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.JokenFROM_DATE_YYYY) OrElse CmnCheck.IsInput(Me.JokenFROM_DATE_MM) OrElse CmnCheck.IsInput(Me.JokenFROM_DATE_DD) Then
            Dim wStr As String = StrConv(Trim(Me.JokenFROM_DATE_YYYY.Text) & "/" & Trim(Me.JokenFROM_DATE_MM.Text) & "/" & Trim(Me.JokenFROM_DATE_DD.Text), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("開催日From"), Me)
                Return False
            End If
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("開催日To(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("開催日To(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_DD) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("開催日To(日)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.JokenTO_DATE_YYYY) OrElse CmnCheck.IsInput(Me.JokenTO_DATE_MM) OrElse CmnCheck.IsInput(Me.JokenTO_DATE_DD) Then
            Dim wStr As String = StrConv(Trim(Me.JokenTO_DATE_YYYY.Text) & "/" & Trim(Me.JokenTO_DATE_MM.Text) & "/" & Trim(Me.JokenTO_DATE_DD.Text), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("開催日To"), Me)
                Return False
            End If
        End If

        Return True
    End Function

    '画面項目 表示
    Private Sub SetForm()

        'データ取得
        TBL_FILE = Nothing
        Joken = Nothing
        Joken.KOUENKAI_NO = Trim(Me.JokenKOUENKAI_NO.Text)
        Joken.KOUENKAI_NO = Me.JokenKOUENKAI_NO.Text.Trim
        Joken.FROM_DATE = CmnModule.Format_DateToString(Me.JokenFROM_DATE_YYYY.Text, Me.JokenFROM_DATE_MM.Text, Me.JokenFROM_DATE_DD.Text)
        Joken.TO_DATE = CmnModule.Format_DateToString(Me.JokenTO_DATE_YYYY.Text, Me.JokenTO_DATE_MM.Text, Me.JokenTO_DATE_DD.Text)

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

        strSQL &= "SELECT TBL_FILE.*, TBL_TAXIDAICHO.*"
        strSQL &= " FROM TBL_FILE"
        strSQL &= " INNER JOIN TBL_TAXIDAICHO"
        strSQL &= " ON"
        strSQL &= " TBL_FILE.FILE_NAME = TBL_TAXIDAICHO.FILE_NAME"
        strSQL &= " WHERE"
        strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.FILE_KBN & "=@" & TableDef.TBL_FILE.Column.FILE_KBN
        strSQL &= " AND"
        strSQL &= " TBL_TAXIDAICHO." & TableDef.TBL_TAXIDAICHO.Column.OUTPUT_FLAG & "=@OUTPUT_FLAG"

        If Trim(Joken.KOUENKAI_NO) <> "" Then
            strSQL &= " AND"
            strSQL &= " TBL_TAXIDAICHO." & TableDef.TBL_TAXIDAICHO.Column.KOUENKAI_NO & " = @" & TableDef.TBL_TAXIDAICHO.Column.KOUENKAI_NO
            wKouenkaiFlag = True
        End If

        If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
            strSQL &= " AND TBL_TAXIDAICHO."
            strSQL &= TableDef.TBL_TAXIDAICHO.Column.FROM_DATE
            strSQL &= " BETWEEN @FROM_DATE AND @TO_DATE"
        ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
            strSQL &= " AND TBL_TAXIDAICHO."
            strSQL &= TableDef.TBL_TAXIDAICHO.Column.FROM_DATE
            strSQL &= " = @FROM_DATE"
        ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
            strSQL &= " AND TBL_TAXIDAICHO."
            strSQL &= TableDef.TBL_TAXIDAICHO.Column.FROM_DATE
            strSQL &= " = @TO_DATE"
        End If

        strSQL &= " ORDER BY"
        strSQL &= " TBL_TAXIDAICHO." & TableDef.TBL_TAXIDAICHO.Column.KOUENKAI_NO

        Dim objCom As New SqlCommand(strSQL, Me.DbConnection)
        objCom.Parameters.AddWithValue("@" & TableDef.TBL_FILE.Column.FILE_KBN, AppConst.FILE_KBN.Code.TaxiMeisai)
        objCom.Parameters.AddWithValue("@" & TableDef.TBL_TAXIDAICHO.Column.OUTPUT_FLAG, CmnConst.Flag.On)
        If Trim(Joken.KOUENKAI_NO) <> "" Then
            objCom.Parameters.Add(New SqlClient.SqlParameter(TableDef.TBL_TAXIDAICHO.Column.KOUENKAI_NO, Joken.KOUENKAI_NO))
        End If
        If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
            objCom.Parameters.AddWithValue("@" & TableDef.TBL_TAXIDAICHO.Column.FROM_DATE, Joken.FROM_DATE)
            objCom.Parameters.AddWithValue("@TO_DATE", Joken.TO_DATE)
        ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
            objCom.Parameters.AddWithValue("@" & TableDef.TBL_TAXIDAICHO.Column.FROM_DATE, Joken.FROM_DATE)
        ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
            objCom.Parameters.AddWithValue("@" & TableDef.TBL_TAXIDAICHO.Column.FROM_DATE, Joken.TO_DATE)
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
    Private Function GetData(ByVal FILE_NAME As String, ByRef pFILE() As TableDef.TBL_FILE.DataStruct) As Boolean
        Dim strSQL As String = ""
        Dim i As Integer = 0
        Dim wFlag As Boolean = False
        Dim wKouenkaiFlag As Boolean = False
        Dim wSeikyuFlag As Boolean = False

        Erase pFILE

        strSQL &= "SELECT TBL_FILE.*, TBL_TAXIDAICHO.*"
        strSQL &= " FROM TBL_FILE"
        strSQL &= " INNER JOIN TBL_TAXIDAICHO"
        strSQL &= " ON"
        strSQL &= " TBL_FILE.FILE_NAME = TBL_TAXIDAICHO.FILE_NAME"
        strSQL &= " WHERE"
        strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.FILE_KBN & "=@" & TableDef.TBL_FILE.Column.FILE_KBN
        strSQL &= " AND"
        strSQL &= " TBL_TAXIDAICHO." & TableDef.TBL_TAXIDAICHO.Column.OUTPUT_FLAG & "=@OUTPUT_FLAG"

        If Trim(FILE_NAME) <> "" Then
            strSQL &= " AND"
            strSQL &= " TBL_TAXIDAICHO." & TableDef.TBL_TAXIDAICHO.Column.FILE_NAME & " = @" & TableDef.TBL_TAXIDAICHO.Column.FILE_NAME
            wKouenkaiFlag = True
        End If

        strSQL &= " ORDER BY"
        strSQL &= " TBL_TAXIDAICHO." & TableDef.TBL_TAXIDAICHO.Column.KOUENKAI_NO

        Dim objCom As New SqlCommand(strSQL, Me.DbConnection)
        objCom.Parameters.AddWithValue("@" & TableDef.TBL_FILE.Column.FILE_KBN, AppConst.FILE_KBN.Code.TaxiMeisai)
        objCom.Parameters.AddWithValue("@" & TableDef.TBL_TAXIDAICHO.Column.OUTPUT_FLAG, CmnConst.Flag.On)
        If Trim(FILE_NAME) <> "" Then
            objCom.Parameters.Add(New SqlClient.SqlParameter(TableDef.TBL_TAXIDAICHO.Column.FILE_NAME, FILE_NAME))
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

        Return wFlag
    End Function

    'データソース設定
    Private Sub SetGridView()
        Dim strSQL As String = ""
        Dim wKouenkaiFlag As Boolean = False
        Dim wSeikyuFlag As Boolean = False

        'データソース設定

        strSQL &= "SELECT TBL_FILE.*, TBL_TAXIDAICHO.*"
        strSQL &= " FROM TBL_FILE"
        strSQL &= " INNER JOIN TBL_TAXIDAICHO"
        strSQL &= " ON"
        strSQL &= " TBL_FILE.FILE_NAME = TBL_TAXIDAICHO.FILE_NAME"
        strSQL &= " WHERE"
        strSQL &= " TBL_FILE." & TableDef.TBL_FILE.Column.FILE_KBN & "=@" & TableDef.TBL_FILE.Column.FILE_KBN
        strSQL &= " AND"
        strSQL &= " TBL_TAXIDAICHO." & TableDef.TBL_TAXIDAICHO.Column.OUTPUT_FLAG & "=@" & TableDef.TBL_TAXIDAICHO.Column.OUTPUT_FLAG

        If Trim(Joken.KOUENKAI_NO) <> "" Then
            strSQL &= " AND"
            strSQL &= " TBL_TAXIDAICHO." & TableDef.TBL_TAXIDAICHO.Column.KOUENKAI_NO & " = @" & TableDef.TBL_TAXIDAICHO.Column.KOUENKAI_NO
            wKouenkaiFlag = True
        End If

        If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
            strSQL &= " AND TBL_TAXIDAICHO."
            strSQL &= TableDef.TBL_TAXIDAICHO.Column.FROM_DATE
            strSQL &= " BETWEEN @FROM_DATE AND @TO_DATE"
        ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
            strSQL &= " AND TBL_TAXIDAICHO."
            strSQL &= TableDef.TBL_TAXIDAICHO.Column.FROM_DATE
            strSQL &= " = @FROM_DATE"
        ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
            strSQL &= " AND TBL_TAXIDAICHO."
            strSQL &= TableDef.TBL_TAXIDAICHO.Column.FROM_DATE
            strSQL &= " = @TO_DATE"
        End If

        strSQL &= " ORDER BY"
        strSQL &= " TBL_TAXIDAICHO." & TableDef.TBL_TAXIDAICHO.Column.KOUENKAI_NO

        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL
        Me.SqlDataSource1.SelectParameters.Clear()


        Dim objCom As New SqlCommand(strSQL, Me.DbConnection)
        Me.SqlDataSource1.SelectParameters.Add(TableDef.TBL_FILE.Column.FILE_KBN, AppConst.FILE_KBN.Code.TaxiMeisai)
        Me.SqlDataSource1.SelectParameters.Add(TableDef.TBL_TAXIDAICHO.Column.OUTPUT_FLAG, CmnConst.Flag.On)
        If Trim(Joken.KOUENKAI_NO) <> "" Then
            Me.SqlDataSource1.SelectParameters.Add(TableDef.TBL_TAXIDAICHO.Column.KOUENKAI_NO, Joken.KOUENKAI_NO)
        End If
        If Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) <> "" Then
            Me.SqlDataSource1.SelectParameters.Add(TableDef.TBL_TAXIDAICHO.Column.FROM_DATE, Joken.FROM_DATE)
            Me.SqlDataSource1.SelectParameters.Add("TO_DATE", Joken.TO_DATE)
        ElseIf Trim(Joken.FROM_DATE) <> "" AndAlso Trim(Joken.TO_DATE) = "" Then
            Me.SqlDataSource1.SelectParameters.Add(TableDef.TBL_TAXIDAICHO.Column.FROM_DATE, Joken.FROM_DATE)
        ElseIf Trim(Joken.FROM_DATE) = "" AndAlso Trim(Joken.TO_DATE) <> "" Then
            Me.SqlDataSource1.SelectParameters.Add(TableDef.TBL_TAXIDAICHO.Column.FROM_DATE, Joken.TO_DATE)
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

    '[検索]
    Private Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        '入力チェック
        If Not Check() Then Exit Sub

        '画面項目表示
        SetForm()
    End Sub

    '[タクチケ台帳CSVファイルダウンロード]
    Protected Sub DLCsvFile(ByVal Joken As TableDef.Joken.DataStruct, ByRef CsvPath() As String)
        Dim wFILE(0) As TableDef.TBL_FILE.DataStruct

        '書類テーブルデータ取得
        If Not GetData(Joken.FILE_NAME, wFILE) Then Exit Sub

        Dim i As Integer = UBound(CsvPath)
        CsvPath(i) = WebConfig.Path.TaxiMeisaiCsv & wFILE(0).FILE_NAME
        Dim sb As New System.Text.StringBuilder
        Dim sw As New System.IO.StreamWriter(CsvPath(i), False, System.Text.Encoding.GetEncoding("Shift-JIS"))

        sb.Append(System.Text.Encoding.GetEncoding("shift_jis").GetString(wFILE(0).DATUME))
        sw.Write(sb)
        sw.Close()
    End Sub

    '[タクチケ台帳CSVファイル削除]
    Private Function DeleteTBL_FILE(ByVal Joken As TableDef.Joken.DataStruct) As Boolean
        Dim strSQL As String = ""

        Try
            strSQL = "DELETE FROM TBL_FILE WHERE FILE_NAME='" & Joken.FILE_NAME & "'"

            CmnDbBatch.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    '[ダウンロード]
    Private Sub BtnDownload_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDownload1.Click, BtnDownload2.Click
        Dim i As Integer = 0

        For Each row As GridViewRow In Me.GrvList.Rows
            If DirectCast(row.FindControl("chkDelete"), CheckBox).Checked Then i += 1
        Next

        If i = 0 Then
            CmnModule.AlertMessage(MessageDef.Error.MustSelect("ダウンロードするタクチケ台帳CSV"), Me)
            Exit Sub
        End If

        'Zipファイル名
        Dim ZipFileName As String = "TaxiMeisai_" & Now.ToString("yyyyMMddHHmmss") & ".zip"
        Dim ZipPath As String = WebConfig.Path.TaxiMeisaiCsv & ZipFileName
        Dim CsvPath() As String

        'Zip作成
        i = 0
        Using zip As New Ionic.Zip.ZipFile
            For Each row As GridViewRow In Me.GrvList.Rows
                If DirectCast(row.FindControl("chkDelete"), CheckBox).Checked Then
                    'タクチケ台帳CSVダウンロード
                    Joken.FILE_NAME = DirectCast(GrvList.Rows(i).Controls(CellIndex.FILE_NAME), DataControlFieldCell).Text()
                    ReDim Preserve CsvPath(i)
                    Call DLCsvFile(Joken, CsvPath)
                    zip.AddFile(CsvPath(i), "")
                End If
                i += 1
            Next
            zip.Save(ZipPath)
        End Using

        'バックアップ作成
        System.IO.File.Copy(ZipPath, WebConfig.Path.TaxiMeisaiCsv_Backup & ZipFileName)

        'Csv削除
        Try
            For k As Integer = LBound(CsvPath) To UBound(CsvPath)
                System.IO.File.Delete(CsvPath(k))
            Next k
        Catch ex As Exception
        End Try

        'ダウンロード
        Response.Clear()
        Response.ContentType = "application/x-zip"
        Response.Charset = ""
        Response.AddHeader("content-disposition", "attachment; filename=" & _
            HttpUtility.UrlEncode(CStr(ZipFileName)))
        Response.WriteFile(CStr(ZipPath))
        Response.Flush()

        'Zipファイル削除
        Try
            System.IO.File.Delete(ZipPath)
        Catch ex As Exception
        End Try
    End Sub

    '[削除]
    Private Sub BtnDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDelete1.Click, BtnDelete2.Click
        Dim i As Integer = 0

        For Each row As GridViewRow In Me.GrvList.Rows
            If DirectCast(row.FindControl("chkDelete"), CheckBox).Checked Then
                'タクチケ台帳CSV削除
                Joken.FILE_NAME = DirectCast(GrvList.Rows(i).Controls(CellIndex.FILE_NAME), DataControlFieldCell).Text()
                Call DeleteTBL_FILE(Joken)
            End If
            i += 1
        Next

        If i = 0 Then
            CmnModule.AlertMessage(MessageDef.Error.MustSelect("削除するタクチケ台帳CSV"), Me)
            Exit Sub
        End If

        'タクチケ台帳CSV再表示
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
End Class