Imports CommonLib
Imports AppLib

Partial Public Class NewKouenkaiList
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列    Private Enum CellIndex
        BU
        KIKAKU_TANTO_AREA
        KIKAKU_TANTO_EIGYOSHO
        JISSHI_DATE
        KOUENKAI_NAME
        TIME_STAMP
        KUBUN
        Button1
        KOUENKAI_NO
    End Enum

    Private Sub DrList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
        Session.Item(SessionDef.Joken) = Joken
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '共通チェック
        MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()

            '画面項目表示
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "新着　講演会（基本情報）"
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
            TBL_KOUENKAI = Session.Item(SessionDef.TBL_KAIJO)
            If TBL_KOUENKAI Is Nothing Then ReDim TBL_KOUENKAI(0)
        Catch ex As Exception
            ReDim TBL_KOUENKAI(0)
        End Try
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()
        AppModule.SetDropDownList_KUBUN(Me.KUBUN)

        'IME設定        CmnModule.SetIme(Me.BU, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.KIKAKU_TANTO_AREA, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.KOUENKAI_NAME, CmnModule.ImeType.Active)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        'データ取得
        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.GrvList.Visible = False
        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True

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
        Joken.BU = Trim(Me.BU.Text)
        Joken.AREA = Trim(Me.KIKAKU_TANTO_AREA.Text)
        Joken.KOUENKAI_NAME = Trim(Me.KOUENKAI_NAME.Text)
        Joken.KUBUN = CmnModule.GetSelectedItemValue(Me.KUBUN)

        ReDim TBL_KOUENKAI(wCnt)

        strSQL = SQL.TBL_KOUENKAI.Search(Joken, True)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve TBL_KOUENKAI(wCnt)
            TBL_KOUENKAI(wCnt) = AppModule.SetRsData(RsData, TBL_KOUENKAI(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag
    End Function

    '一覧 表示
    Private Sub DispList()

        'データ取得        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.GrvList.Visible = False

        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True

            'グリッドビュー表示
            SetGridView()
        End If
    End Sub

    'データソース設定
    Private Sub SetGridView()
        'データソース設定
        Dim strSQL As String = SQL.TBL_KAIJO.Search(Joken, True)
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
            e.Row.Cells(CellIndex.JISSHI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.JISSHI_DATE).Text, CmnModule.DateFormatType.YYYYMMDD)
            '仮
            'e.Row.Cells(CellIndex.KUBUN).Text = GetKigou_TEHAI_HOTEL(e.Row.Cells(CellIndex.KUBUN).Text)
            'e.Row.Cells(CellIndex.TEHAI_HOTEL).Text = GetKigou_TEHAI_HOTEL(e.Row.Cells(CellIndex.TEHAI_HOTEL).Text)
            'e.Row.Cells(CellIndex.TEHAI_KOTSU).Text = GetKigou_TEHAI_HOTEL(e.Row.Cells(CellIndex.TEHAI_KOTSU).Text)
            'e.Row.Cells(CellIndex.TEHAI_TAXI).Text = GetKigou_TEHAI_HOTEL(e.Row.Cells(CellIndex.TEHAI_TAXI).Text)

            'e.Row.Cells(CellIndex.TEHAI_HOTEL).Text = AppModule.GetName_TEHAI_HOTEL(e.Row.Cells(CellIndex.TEHAI_HOTEL).Text, True)
            'e.Row.Cells(CellIndex.TEHAI_KOTSU).Text = AppModule.GetName_TEHAI_KOTSU(e.Row.Cells(CellIndex.TEHAI_KOTSU).Text, True)
            'e.Row.Cells(CellIndex.UPD_DATE).Text = AppModule.GetName_UPD_DATE(e.Row.Cells(CellIndex.UPD_DATE).Text, True)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
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
                'Session.Item(SessionDef.SEQ) = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + CmnModule.DbVal(e.CommandArgument)
                'Session.Item(SessionDef.TBL_DR) = TBL_DR
                'Session.Item(SessionDef.PageIndex) = Me.GrvList.PageIndex
                'Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
                Response.Redirect(URL.DrRegist)
        End Select
    End Sub

    '[検索]
    Private Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click

        '一覧 表示
        DispList()

    End Sub

    '[戻る]
    Private Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack.Click

    End Sub
End Class