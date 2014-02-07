Imports CommonLib
Imports AppLib

Partial Public Class KaijoRireki
    Inherits WebBase

    Private TBL_KAIJO() As TableDef.TBL_KAIJO.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列    Private Enum CellIndex
        TIME_STAMP_BYL
        UPDATE_DATE
        BU
        KIKAKU_TANTO_AREA
        KIKAKU_TANTO_EIGYOSHO
        FROM_DATE
        SEND_FLAG
        USER_NAME
        Button1
        KOUENKAI_NO
        TEHAI_ID
        TO_DATE
    End Enum
 
    Private Sub KaijoRireki_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.KaijoRireki_TBL_KAIJO) = TBL_KAIJO
        Session.Item(SessionDef.KaijoRireki_Joken) = Joken
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
            '画面項目 初期化            InitControls()

            '画面項目表示
            SetForm()
        End If

        Session.Remove(SessionDef.KaijoPrint_SQL)
        Session.Remove(SessionDef.BackURL_Print)
        Session.Remove(SessionDef.PrintPreview)
        'マスターページ設定        With Me.Master
            .PageTitle = "会場手配履歴"
        End With
    End Sub

    'セッションを変数に格納    Private Function SetSession() As Boolean
        Try
            Joken = Session.Item(SessionDef.KaijoRireki_Joken)
        Catch ex As Exception
            Joken = Nothing
        End Try
        Try
            TBL_KAIJO = Session.Item(SessionDef.KaijoRireki_TBL_KAIJO)
            If TBL_KAIJO Is Nothing Then ReDim TBL_KAIJO(0)
        Catch ex As Exception
            ReDim TBL_KAIJO(0)
        End Try
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        'データ取得        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.GrvList.Visible = False
            Me.TrKOUENKAI_NAME.Visible = False
            Me.TblButton1.Visible = False
            CmnModule.SetEnabled(Me.BtnKaijoRirekiPrint1, False)
            CmnModule.SetEnabled(Me.BtnKaijoRirekiPrint2, False)
        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True
            Me.TrKOUENKAI_NAME.Visible = True
            Me.TblButton1.Visible = True
            CmnModule.SetEnabled(Me.BtnKaijoRirekiPrint1, True)
            CmnModule.SetEnabled(Me.BtnKaijoRirekiPrint2, True)

            Me.KOUENKAI_NO.Text = AppModule.GetName_KOUENKAI_NO(TBL_KAIJO(0).KOUENKAI_NO)
            Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NAME(TBL_KAIJO(0).KOUENKAI_NAME)

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

        ReDim TBL_KAIJO(wCnt)
        strSQL = SQL.TBL_KAIJO.Rireki(Joken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve TBL_KAIJO(wCnt)
            TBL_KAIJO(wCnt) = AppModule.SetRsData(RsData, TBL_KAIJO(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag
    End Function

    'データソース設定
    Private Sub SetGridView()
        'データソース設定        Dim strSQL As String = SQL.TBL_KAIJO.Rireki(Joken)
        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL

        With Me.GrvList
            Try
                .PageIndex = CmnModule.DbVal(Session.Item(SessionDef.KaijoRireki_PageIndex))
                .DataBind()
            Catch ex As Exception
                Session.Item(SessionDef.KaijoRireki_PageIndex) = 0
                .PageIndex = CmnModule.DbVal(Session.Item(SessionDef.KaijoRireki_PageIndex))
                .DataBind()
            End Try
            .Attributes(CmnConst.Html.Attributes.BorderColor) = CmnConst.Html.Color.Border
        End With
    End Sub

    'グリッドビュー内書式設定
    Protected Sub GrvList_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.TIME_STAMP_BYL).Text = AppModule.GetName_TIME_STAMP_BYL(e.Row.Cells(CellIndex.TIME_STAMP_BYL).Text)
            e.Row.Cells(CellIndex.UPDATE_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.UPDATE_DATE).Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
            e.Row.Cells(CellIndex.FROM_DATE).Text = AppModule.GetName_DATE_FROM_TO(e.Row.Cells(CellIndex.FROM_DATE).Text, e.Row.Cells(CellIndex.TO_DATE).Text)
            e.Row.Cells(CellIndex.SEND_FLAG).Text = AppModule.GetName_SEND_FLAG(e.Row.Cells(CellIndex.SEND_FLAG).Text, True)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.KOUENKAI_NO).Visible = False
            e.Row.Cells(CellIndex.TEHAI_ID).Visible = False
            e.Row.Cells(CellIndex.TO_DATE).Visible = False
        ElseIf e.Row.RowType = DataControlRowType.Pager Then
            CType(e.Row.Controls(0), TableCell).ColumnSpan = CType(e.Row.Controls(0), TableCell).ColumnSpan - 3
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
            Session.Item(SessionDef.KaijoRireki_PageIndex) = .PageIndex

            'グリッドビュー表示
            SetGridView()
        End With
    End Sub

    'グリッドビュー コマンドボタン押下時
    Protected Sub GrvList_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GrvList.RowCommand
        Select Case e.CommandName
            Case "Regist"
                Session.Item(SessionDef.KaijoRireki_SEQ) = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + CmnModule.DbVal(e.CommandArgument)
                Session.Item(SessionDef.KaijoRireki_TBL_KAIJO) = TBL_KAIJO
                Session.Item(SessionDef.KaijoRireki_PageIndex) = Me.GrvList.PageIndex
                Session.Item(SessionDef.KaijoRireki) = Session.SessionID

                Dim scriptStr As String
                scriptStr = "<script language='javascript' type='text/javascript'>" & vbNewLine
                scriptStr &= "window.open('" & URL.KaijoRegist & "','Rireki','width=980,height=700,scrollbars=yes,resizable=yes,statusbar=yes');" & vbNewLine
                scriptStr &= "</script>" & vbNewLine
                ClientScript.RegisterStartupScript(Me.GetType(), "Rireki", scriptStr)
        End Select
    End Sub

    '[履歴一覧印刷]
    Protected Sub BtnKaijoRirekiPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnKaijoRirekiPrint1.Click, BtnKaijoRirekiPrint2.Click
        Dim strSQL As String = SQL.TBL_KAIJO.Rireki(Joken)
        Session.Item(SessionDef.KaijoPrint_SQL) = strSQL
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Session.Item(SessionDef.PrintPreview) = "KaijoRireki"
        Response.Redirect(URL.Preview)
    End Sub

    '[戻る]
    Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click, BtnBack2.Click
        Session.Remove(SessionDef.KaijoRireki_TBL_KAIJO)
        Session.Remove(SessionDef.KaijoRireki_Joken)
        Session.Remove(SessionDef.KaijoRireki_SEQ)
        Session.Remove(SessionDef.KaijoRireki_PageIndex)
        Session.Remove(SessionDef.KaijoRireki)
        Session.Remove(SessionDef.KaijoPrint_SQL)
        Session.Remove(SessionDef.BackURL_Print)
        Session.Remove(SessionDef.PrintPreview)

        Response.Redirect(URL.KaijoRegist)
    End Sub
     
End Class
