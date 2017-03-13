Imports CommonLib
Imports AppLib

Partial Public Class NewKouenkaiList
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private TBL_KOUENKAI_KEY() As TableDef.TBL_KOUENKAI_KEY.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列    Private Enum CellIndex
        BU
        KIKAKU_TANTO_AREA
        KIKAKU_TANTO_EIGYOSHO
        KIKAKU_TANTO_NAME
        JISSHI_DATE
        KOUENKAI_NO
        KOUENKAI_NAME
        TIME_STAMP
        KUBUN
        Button1
        TO_DATE
        CNT
        KOUENKAI_TITLE
        TIME_STAMP2
    End Enum

    Private Sub DrList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
        Session.Item(SessionDef.Joken) = Joken
    End Sub

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

            '画面項目表示
            SetJoken()
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "【新着】基本情報"
        End With

    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            Joken = Session.Item(SessionDef.Joken)
        Catch ex As Exception
            Joken = Nothing
        End Try
        Try
            TBL_KOUENKAI = Session.Item(SessionDef.TBL_KOUENKAI)
            If TBL_KOUENKAI Is Nothing Then ReDim TBL_KOUENKAI(0)
        Catch ex As Exception
            ReDim TBL_KOUENKAI(0)
        End Try
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()
        AppModule.SetDropDownList_BU(Me.JOKEN_BU, DbConnection)
        AppModule.SetDropDownList_AREA(Me.JOKEN_AREA, DbConnection)
        AppModule.SetDropDownList_KUBUN(Me.KUBUN)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '抽出条件 表示
    Private Sub SetJoken()
        If Joken.BU <> "" AndAlso Joken.BU <> "指定なし" Then Me.JOKEN_BU.SelectedValue = Joken.BU
        If Joken.AREA <> "" AndAlso Joken.AREA <> "指定なし" Then Me.JOKEN_AREA.SelectedValue = Joken.AREA
        If Joken.KUBUN <> "" AndAlso Joken.KUBUN <> "指定なし" Then Me.KUBUN.SelectedValue = Joken.KUBUN
    End Sub

    '画面項目 表示
    Private Sub SetForm()

        'データ取得
        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.GrvList.Visible = False
            Me.BtnPrint1.Visible = False
            Me.BtnPrint2.Visible = False
            Me.BtnBack2.Visible = False
        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True
            Me.BtnPrint1.Visible = True
            Me.BtnPrint2.Visible = True
            Me.BtnBack2.Visible = True

            'グリッドビュー表示
            SetGridView()
        End If
    End Sub

    'データ取得
    Private Function GetData() As Boolean
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        Joken = Nothing
        Joken.KUBUN = CmnModule.GetSelectedItemValue(Me.KUBUN)
        If Me.JOKEN_BU.SelectedIndex <> 0 Then Joken.BU = Me.JOKEN_BU.SelectedItem.ToString
        If Me.JOKEN_AREA.SelectedIndex <> 0 Then Joken.AREA = Me.JOKEN_AREA.SelectedItem.ToString

        'ReDim TBL_KOUENKAI(wCnt)
        'strSQL = SQL.TBL_KOUENKAI.Search(Joken, True)

        ReDim TBL_KOUENKAI_KEY(wCnt)
        strSQL = SQL.TBL_KOUENKAI.Search_KeyItem(Joken, True)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve TBL_KOUENKAI_KEY(wCnt)
            TBL_KOUENKAI_KEY(wCnt) = AppModule.SetRsData(RsData, TBL_KOUENKAI_KEY(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag
    End Function

    'グリッドビュー表示項目取得

    Private Function GetGridData(ByVal whereData As StringDictionary, ByRef GRID_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim SearchKey As TableDef.Joken.DataStruct

        SearchKey = Nothing
        SearchKey.KOUENKAI_NO = whereData(TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO)
        SearchKey.TIME_STAMP = whereData(TableDef.TBL_KOUENKAI.Column.TIME_STAMP)
        SearchKey.KOUENKAI_TITLE = whereData(TableDef.TBL_KOUENKAI.Column.KOUENKAI_TITLE)

        strSQL = SQL.TBL_KOUENKAI.byKEY(SearchKey)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True
            GRID_KOUENKAI = AppModule.SetRsData(RsData, GRID_KOUENKAI)

            Exit While
        End While
        RsData.Close()

        Return wFlag
    End Function

    'データソース設定
    Private Sub SetGridView()
        'データソース設定
        Dim strSQL As String = SQL.TBL_KOUENKAI.Search_KeyItem(Joken, True)
        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL

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

    'グリッドビュー内書式設定
    Protected Sub GrvList_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowDataBound

        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim whereData As New StringDictionary
            whereData.Add(TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO, e.Row.Cells(CellIndex.KOUENKAI_NO).Text)
            whereData.Add(TableDef.TBL_KOUENKAI.Column.TIME_STAMP, e.Row.Cells(CellIndex.TIME_STAMP2).Text)
            whereData.Add(TableDef.TBL_KOUENKAI.Column.KOUENKAI_TITLE, CmnModule.ClearHtmlampersand(CmnModule.ClearHtmlSpace(e.Row.Cells(CellIndex.KOUENKAI_TITLE).Text)))

            Dim GRID_KOUENKAI As New TableDef.TBL_KOUENKAI.DataStruct
            If Not GetGridData(whereData, GRID_KOUENKAI) Then Exit Sub

            e.Row.Cells(CellIndex.BU).Text = GRID_KOUENKAI.BU
            e.Row.Cells(CellIndex.KIKAKU_TANTO_AREA).Text = GRID_KOUENKAI.KIKAKU_TANTO_AREA
            e.Row.Cells(CellIndex.KIKAKU_TANTO_EIGYOSHO).Text = GRID_KOUENKAI.KIKAKU_TANTO_EIGYOSHO
            e.Row.Cells(CellIndex.KIKAKU_TANTO_NAME).Text = GRID_KOUENKAI.KIKAKU_TANTO_NAME

            '開催日
            e.Row.Cells(CellIndex.JISSHI_DATE).Text = AppModule.GetName_KOUENKAI_DATE(GRID_KOUENKAI.FROM_DATE, GRID_KOUENKAI.TO_DATE, True)

            'TimeStamp
            e.Row.Cells(CellIndex.TIME_STAMP).Text = _
                CmnModule.Format_Date(e.Row.Cells(CellIndex.TIME_STAMP).Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)

            '区分
            If e.Row.Cells(CellIndex.CNT).Text > "1" Then
                e.Row.Cells(CellIndex.KUBUN).Text = "新着変更"
            Else
                e.Row.Cells(CellIndex.KUBUN).Text = "新規"
            End If
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.TO_DATE).Visible = False
            e.Row.Cells(CellIndex.CNT).Visible = False
            e.Row.Cells(CellIndex.KOUENKAI_TITLE).Visible = False
            e.Row.Cells(CellIndex.TIME_STAMP2).Visible = False
        ElseIf e.Row.RowType = DataControlRowType.Pager Then
            CType(e.Row.Controls(0), TableCell).ColumnSpan = CType(e.Row.Controls(0), TableCell).ColumnSpan - 0
            Me.GrvList.BorderStyle = BorderStyle.None
            Dim PagerTableCell As TableCell = e.Row.Cells(0)
            PagerTableCell.BorderStyle = BorderStyle.None
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
        Select Case e.CommandName
            Case "Detail"
                '選択レコード情報をセッション変数にセット
                Session.Item(SessionDef.SEQ) = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + CmnModule.DbVal(e.CommandArgument)
                Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
                Session.Item(SessionDef.PageIndex) = Me.GrvList.PageIndex
                Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
                Session.Item(SessionDef.BackURL2) = Request.Url.AbsolutePath

                '@@@ Phase2
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                Dim row As GridViewRow = GrvList.Rows(index)
                Session.Item(SessionDef.KOUENKAI_NO) = DirectCast(GrvList.Rows(index).Controls(CellIndex.KOUENKAI_NO), DataControlFieldCell).Text()
                Session.Item(SessionDef.TIME_STAMP) = DirectCast(GrvList.Rows(index).Controls(CellIndex.TIME_STAMP2), DataControlFieldCell).Text()
                Session.Item(SessionDef.KOUENKAI_TITLE) = CmnModule.ClearHtmlampersand(CmnModule.ClearHtmlSpace(DirectCast(GrvList.Rows(index).Controls(CellIndex.KOUENKAI_TITLE), DataControlFieldCell).Text()))
                Session.Item(SessionDef.KOUENKAI_NAME) = CmnModule.ClearHtmlampersand(CmnModule.ClearHtmlSpace(DirectCast(GrvList.Rows(index).Controls(CellIndex.KOUENKAI_NAME), DataControlFieldCell).Text()))

                '履歴画面用セッション変数をクリア
                Session.Remove(SessionDef.KaijoRireki)
                Session.Remove(SessionDef.KouenkaiRireki_PageIndex)
                Session.Remove(SessionDef.KouenkaiRireki_SEQ)
                Session.Item(SessionDef.KouenkaiRireki_TBL_KOUENKAI) = False

                Response.Redirect(URL.KouenkaiRegist)
        End Select
    End Sub

    '[検索]
    Private Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        '入力チェック
        If Not Check() Then
            Exit Sub
        End If

        '一覧 表示
        SetForm()

    End Sub

    '[印刷]
    Private Sub BtnPrint1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint1.Click
        Dim strSQL As String = ""

        Joken = Nothing
        Joken.KUBUN = CmnModule.GetSelectedItemValue(Me.KUBUN)
        If Me.JOKEN_BU.SelectedIndex <> 0 Then
            Joken.BU = Me.JOKEN_BU.SelectedItem.ToString
        Else
            Joken.BU = ""
        End If
        If Me.JOKEN_AREA.SelectedIndex <> 0 Then
            Joken.AREA = Me.JOKEN_AREA.SelectedItem.ToString
        Else
            Joken.AREA = ""
        End If

        strSQL = SQL.TBL_KOUENKAI.Search(Joken, True)
        If Joken.BU.Trim = "" Then Joken.BU = "指定なし"
        If Joken.AREA.Trim = "" Then Joken.AREA = "指定なし"

        Session.Item(SessionDef.NewKouenkaiPrint_SQL) = strSQL
        Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Session.Item(SessionDef.Joken) = Joken
        Response.Redirect(URL.Preview)
    End Sub

    '[印刷]
    Private Sub BtnPrint2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint2.Click
        BtnPrint1_Click(sender, e)
    End Sub

    '[戻る]
    Private Sub BtnBack1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click
        Response.Redirect(URL.Menu)
    End Sub

    '[戻る]
    Private Sub BtnBack2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack2.Click
        BtnBack1_Click(sender, e)
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
End Class