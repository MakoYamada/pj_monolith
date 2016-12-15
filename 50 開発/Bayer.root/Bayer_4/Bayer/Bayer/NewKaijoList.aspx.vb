Imports CommonLib
Imports AppLib
Partial Public Class NewKaijoList
    Inherits WebBase

    Private TBL_KAIJO() As TableDef.TBL_KAIJO.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列
    Private Enum CellIndex
        Template1
        BU
        KIKAKU_TANTO_AREA
        KIKAKU_TANTO_EIGYOSHO
        KIKAKU_TANTO_NAME
        FROM_DATE
        KOUENKAI_NO
        KOUENKAI_NAME
        TEHAI_ID
        TIME_STAMP_BYL
        REQ_STATUS_TEHAI
        USER_NAME
        Button1
        SALEFORCE_ID
        TO_DATE
    End Enum

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_KAIJO) = TBL_KAIJO
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

        Session.Remove(SessionDef.KaijoPrint_SQL)
        Session.Remove(SessionDef.BackURL_Print)
        Session.Remove(SessionDef.PrintPreview)

        'マスターページ設定
        With Me.Master
            .PageTitle = "【新着】会場手配"
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
            TBL_KAIJO = Session.Item(SessionDef.TBL_KAIJO)
            If TBL_KAIJO Is Nothing Then ReDim TBL_KAIJO(0)
        Catch ex As Exception
            ReDim TBL_KAIJO(0)
        End Try
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        'プルダウン設定
        AppModule.SetDropDownList_BU(Me.JokenBU, MyBase.DbConnection)
        AppModule.SetDropDownList_AREA(Me.JokenKIKAKU_TANTO_AREA, MyBase.DbConnection)
        AppModule.SetDropDownList_REQ_STATUS_TEHAI(Me.JokenREQ_STATUS_TEHAI, True)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        '条件表示
        Me.JokenBU.SelectedIndex = CmnModule.GetSelectedIndex(Joken.BU, Me.JokenBU)
        Me.JokenKIKAKU_TANTO_AREA.SelectedIndex = CmnModule.GetSelectedIndex(Joken.AREA, Me.JokenKIKAKU_TANTO_AREA)
        Me.JokenREQ_STATUS_TEHAI.SelectedIndex = CmnModule.GetSelectedIndex(Joken.REQ_STATUS_TEHAI, Me.JokenREQ_STATUS_TEHAI)

        'データ取得
        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.SpnCheckPrint.Visible = False
            Me.GrvList.Visible = False
            Me.TblButton1.Visible = False
            CmnModule.SetEnabled(Me.BtnKaijoPrint1, False)
            CmnModule.SetEnabled(Me.BtnKaijoPrint2, False)
            CmnModule.SetEnabled(Me.BtnNewKaijoListPrint1, False)
            CmnModule.SetEnabled(Me.BtnNewKaijoListPrint2, False)
        Else
            Me.LabelNoData.Visible = False
            Me.SpnCheckPrint.Visible = True
            Me.GrvList.Visible = True
            Me.TblButton1.Visible = True
            CmnModule.SetEnabled(Me.BtnKaijoPrint1, True)
            CmnModule.SetEnabled(Me.BtnKaijoPrint2, True)
            CmnModule.SetEnabled(Me.BtnNewKaijoListPrint1, True)
            CmnModule.SetEnabled(Me.BtnNewKaijoListPrint2, True)

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
        strSQL = SQL.TBL_KAIJO.Search(Joken, True)
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
            e.Row.Cells(CellIndex.FROM_DATE).Text = AppModule.GetName_KOUENKAI_DATE(e.Row.Cells(CellIndex.FROM_DATE).Text, e.Row.Cells(CellIndex.TO_DATE).Text, True)
            e.Row.Cells(CellIndex.REQ_STATUS_TEHAI).Text = AppModule.GetName_REQ_STATUS_TEHAI(e.Row.Cells(CellIndex.REQ_STATUS_TEHAI).Text, True)
            e.Row.Cells(CellIndex.TIME_STAMP_BYL).Text = AppModule.GetName_TIME_STAMP_BYL(e.Row.Cells(CellIndex.TIME_STAMP_BYL).Text)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.SALEFORCE_ID).Visible = False
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
            Case "Regist"
                Session.Remove(SessionDef.KaijoRireki_TBL_KAIJO)
                Session.Remove(SessionDef.KaijoRireki_Joken)
                Session.Remove(SessionDef.KaijoRireki_SEQ)
                Session.Remove(SessionDef.KaijoRireki_PageIndex)
                Session.Remove(SessionDef.KaijoRireki)
                Session.Remove(SessionDef.ShisetsuKensaku_Back)

                Session.Item(SessionDef.SEQ) = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + CmnModule.DbVal(e.CommandArgument)
                Session.Item(SessionDef.TBL_KAIJO) = TBL_KAIJO
                Session.Item(SessionDef.PageIndex) = Me.GrvList.PageIndex
                Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
                Response.Redirect(URL.KaijoRegist)
        End Select
    End Sub

    '[検索]
    Protected Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        '入力チェック
        If Not Check() Then Exit Sub

        Joken = Nothing
        Joken.BU = CmnModule.GetSelectedItemValue(Me.JokenBU)
        Joken.AREA = CmnModule.GetSelectedItemValue(Me.JokenKIKAKU_TANTO_AREA)
        Joken.REQ_STATUS_TEHAI = CmnModule.GetSelectedItemValue(Me.JokenREQ_STATUS_TEHAI)

        '画面項目表示
        SetForm()
    End Sub

    '入力チェック
    Private Function Check() As Boolean
        Return True
    End Function

    '[手配書印刷]
    Protected Sub BtnKaijoPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnKaijoPrint1.Click, BtnKaijoPrint2.Click
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim KOUENKAI_NO() As String
        Dim TEHAI_ID() As String

        'チェック
        ReDim KOUENKAI_NO(wCnt)
        ReDim TEHAI_ID(wCnt)
        For Each wRow As GridViewRow In Me.GrvList.Rows
            If CType(wRow.Cells(CellIndex.Template1).FindControl("ChkPrint"), CheckBox).Checked = True Then
                wFlag = True
                ReDim Preserve KOUENKAI_NO(wCnt)
                ReDim Preserve TEHAI_ID(wCnt)
                KOUENKAI_NO(wCnt) = wRow.Cells(CellIndex.KOUENKAI_NO).Text
                TEHAI_ID(wCnt) = wRow.Cells(CellIndex.TEHAI_ID).Text
                wCnt += 1
            End If
        Next

        If wFlag = True Then
            strSQL = SQL.TBL_KAIJO.NewListPrint(KOUENKAI_NO, TEHAI_ID)
            Session.Item(SessionDef.KaijoPrint_SQL) = strSQL
            Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
            Session.Item(SessionDef.PrintPreview) = "KaijoRegist"
            Response.Redirect(URL.Preview)
        Else
            CmnModule.AlertMessage("印刷対象がありません。1件以上チェックしてください。", Me)
            Exit Sub
        End If
    End Sub

    '[手配依頼一覧印刷]
    Protected Sub BtnNewKaijoListPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNewKaijoListPrint1.Click, BtnNewKaijoListPrint2.Click
        Dim strSQL As String = SQL.TBL_KAIJO.Search(Joken, True)
        Session.Item(SessionDef.KaijoPrint_SQL) = strSQL
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Session.Item(SessionDef.PrintPreview) = "NewKaijoList"
        Response.Redirect(URL.Preview)
    End Sub

    '[全てにチェック]
    Protected Sub LnkCheckALL_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LnkCheckALL.Click
        For Each wRow As GridViewRow In Me.GrvList.Rows
            CType(wRow.Cells(CellIndex.Template1).FindControl("ChkPrint"), CheckBox).Checked = True
        Next
        SetFocus(Me.LnkCheckALL)
    End Sub

    '[全てのチェックを解除]
    Protected Sub LnkCheckClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LnkCheckClear.Click
        For Each wRow As GridViewRow In Me.GrvList.Rows
            CType(wRow.Cells(CellIndex.Template1).FindControl("ChkPrint"), CheckBox).Checked = False
        Next
        SetFocus(Me.LnkCheckClear)
    End Sub

    '[戻る]
    Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click, BtnBack2.Click
        Session.Remove(SessionDef.TBL_KAIJO)
        Session.Remove(SessionDef.KaijoPrint_SQL)
        Session.Remove(SessionDef.BackURL_Print)
        Session.Remove(SessionDef.PrintPreview)

        Response.Redirect(URL.Menu)
    End Sub

End Class
