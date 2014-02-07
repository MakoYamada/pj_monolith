Imports CommonLib
Imports AppLib

Partial Public Class KouenkaiRireki
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private RRK_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private SEQ As Integer

    'グリッド列
    Private Enum CellIndex
        Button1
        TIME_STAMP
        UPDATE_DATE
        BU
        KIKAKU_TANTO_AREA
        KIKAKU_TANTO_EIGYOSHO
        KIKAKU_TANTO_NAME
        FROM_DATE
        USER_NAME
        KOUENKAI_NO
        TO_DATE
    End Enum

    Private Sub KouenkaiRireki_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
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

        'マスターページ設定
        With Me.Master
            .PageTitle = "会合基本情報履歴"
        End With

    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            TBL_KOUENKAI = Session.Item(SessionDef.TBL_KOUENKAI)
            If IsNothing(TBL_KOUENKAI) Then Return False
        Catch ex As Exception
            Return False
        End Try
        If Not MyModule.IsValidSEQ(Session.Item(SessionDef.SEQ)) Then
            Return False
        Else
            SEQ = Session.Item(SessionDef.SEQ)
        End If

        Session.Item(SessionDef.KouenkaiRireki) = True
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub


    '画面項目 表示
    Private Sub SetForm()
        'データ取得
        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.GrvList.Visible = False
            Me.TrKOUENKAI_NAME.Visible = False
        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True
            Me.TrKOUENKAI_NAME.Visible = True
            Me.KOUENKAI_NO.Text = AppModule.GetName_KOUENKAI_NO(TBL_KOUENKAI(SEQ).KOUENKAI_NO)
            Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NAME(TBL_KOUENKAI(SEQ).KOUENKAI_NAME)

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

        strSQL = SQL.TBL_KOUENKAI.Rireki(TBL_KOUENKAI(SEQ).KOUENKAI_NO)

        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        ReDim RRK_KOUENKAI(wCnt)
        While RsData.Read()
            wFlag = True

            ReDim Preserve RRK_KOUENKAI(wCnt)
            RRK_KOUENKAI(wCnt) = AppModule.SetRsData(RsData, RRK_KOUENKAI(wCnt))

            wCnt += 1
        End While
        RsData.Close()
        Session.Item(SessionDef.KouenkaiRireki_TBL_KOUENKAI) = RRK_KOUENKAI

        Return wFlag
    End Function

    'データソース設定
    Private Sub SetGridView()
        'データソース設定        Dim strSQL As String = SQL.TBL_KOUENKAI.Rireki(TBL_KOUENKAI(SEQ).KOUENKAI_NO)
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
            e.Row.Cells(CellIndex.FROM_DATE).Text = AppModule.GetName_DATE_FROM_TO(e.Row.Cells(CellIndex.FROM_DATE).Text, e.Row.Cells(CellIndex.TO_DATE).Text)
            e.Row.Cells(CellIndex.UPDATE_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.UPDATE_DATE).Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
            e.Row.Cells(CellIndex.TIME_STAMP).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.TIME_STAMP).Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.KOUENKAI_NO).Visible = False
            e.Row.Cells(CellIndex.TO_DATE).Visible = False
        ElseIf e.Row.RowType = DataControlRowType.Pager Then
            CType(e.Row.Controls(0), TableCell).ColumnSpan = CType(e.Row.Controls(0), TableCell).ColumnSpan - 2
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
                Session.Item(SessionDef.KouenkaiRireki_SEQ) = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + CmnModule.DbVal(e.CommandArgument)
                Session.Item(SessionDef.KouenkaiRireki_PageIndex) = Me.GrvList.PageIndex

                Dim scriptStr As String
                scriptStr = "<script type='text/javascript'>"
                scriptStr += "window.open('" & URL.KouenkaiRegist & "','_blank','width=1200,height=800,resizable=yes,scrollbars=yes,menubar=no,toolbar=no,location=no,status=no');"
                scriptStr += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "Detail", scriptStr)
        End Select
    End Sub

    '[戻る]
    Protected Sub BtnBack1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click
        Session.Item(SessionDef.KouenkaiRireki) = False
        Response.Redirect(Session.Item(SessionDef.BackURL))
    End Sub

    '[戻る]
    Private Sub BtnBack2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack2.Click
        BtnBack1_Click(sender, e)
    End Sub

    '[印刷]
    Private Sub BtnPrint1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint1.Click
        Dim strSQL As String = ""

        strSQL = SQL.TBL_KOUENKAI.Rireki(TBL_KOUENKAI(SEQ).KOUENKAI_NO)
        Session.Item(SessionDef.KouenkaiRirekiPrint_SQL) = strSQL
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Response.Redirect(URL.Preview)
    End Sub

    '[印刷]
    Private Sub BtnPrint2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint2.Click
        BtnPrint1_Click(sender, e)
    End Sub
End Class