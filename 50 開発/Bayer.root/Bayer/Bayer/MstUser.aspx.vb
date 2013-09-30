Imports CommonLib
Imports AppLib
Partial Public Class MstUser
    Inherits WebBase

    Private MS_USER() As TableDef.MS_USER.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列
    Private Enum CellIndex
        Button1
        LOGIN_ID
        KENGEN
        USER_NAME
        STOP_FLG
        SYSTEM_ID
    End Enum

    Private Sub DrList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.MS_USER) = MS_USER
        Session.Item(SessionDef.Joken) = Joken
    End Sub

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

        'マスターページ設定
        With Me.Master
            .HideLoginUser = True   'QQQ
            .PageTitle = "ユーザマスタメンテナンス"
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
            MS_USER = Session.Item(SessionDef.MS_USER)
            If MS_USER Is Nothing Then ReDim MS_USER(0)
        Catch ex As Exception
            ReDim MS_USER(0)
        End Try
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        'IME設定
        CmnModule.SetIme(Me.JokenLOGIN_ID, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenUSER_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.LOGIN_ID, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.PASSWORD, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.USER_NAME, CmnModule.ImeType.Active)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        'データ取得
        If Not GetData() Then
            Me.GrvList.Visible = False
        Else
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

        ReDim MS_USER(wCnt)
        strSQL = SQL.MS_USER.Search(Joken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve MS_USER(wCnt)
            MS_USER(wCnt) = AppModule.SetRsData(RsData, MS_USER(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag
    End Function

    'データソース設定
    Private Sub SetGridView()
        'データソース設定
        Dim strSQL As String = SQL.MS_USER.Search(Joken)
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
            'e.Row.Cells(CellIndex.FROM_DATE).Text = AppModule.GetName_KOUENKAI_DATE(e.Row.Cells(CellIndex.FROM_DATE).Text)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.SYSTEM_ID).Visible = False
        ElseIf e.Row.RowType = DataControlRowType.Pager Then
            CType(e.Row.Controls(0), TableCell).ColumnSpan = CType(e.Row.Controls(0), TableCell).ColumnSpan - 1
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
            Case "Update"
                Session.Item(SessionDef.SEQ) = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + CmnModule.DbVal(e.CommandArgument)
                Session.Item(SessionDef.MS_USER) = MS_USER
                Session.Item(SessionDef.PageIndex) = Me.GrvList.PageIndex
                Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
                Response.Redirect(URL.KaijoRegist)
        End Select
    End Sub

    '[検索]
    Protected Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        '入力チェック
        If Not Check() Then Exit Sub

        '画面項目表示
        SetForm()
    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        'If Not CmnCheck.IsInput(Me.KIKAKU_TANTO_ROMA) AndAlso _
        '   Not CmnCheck.IsInput(Me.TEHAI_TANTO_ROMA) AndAlso _
        '   Not CmnCheck.IsInput(Me.SEIHIN_NAME) AndAlso _
        '   Not CmnCheck.IsInput(Me.KOUENKAI_NO) AndAlso _
        '   Not CmnCheck.IsInput(Me.KOUENKAI_NAME) AndAlso _
        '   Not CmnCheck.IsInput(Me.FROM_DATE_YYYY) AndAlso _
        '   Not CmnCheck.IsInput(Me.FROM_DATE_MM) AndAlso _
        '   Not CmnCheck.IsInput(Me.FROM_DATE_DD) AndAlso _
        '   Not CmnCheck.IsInput(Me.TO_DATE_YYYY) AndAlso _
        '   Not CmnCheck.IsInput(Me.TO_DATE_MM) AndAlso _
        '   Not CmnCheck.IsInput(Me.TO_DATE_DD) AndAlso _
        '   Not CmnCheck.IsInput(Me.BU) AndAlso _
        '   Not CmnCheck.IsInput(Me.KIKAKU_TANTO_AREA) AndAlso _
        '   Not CmnCheck.IsInput(Me.TTANTO_ID) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustInput_Joken, Me)
        '    Return False
        'End If

        If Not CmnCheck.IsInput(Me.PASSWORD) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.MS_USER.Name.PASSWORD), Me)
            Return False
        End If

        Return True
    End Function

    ''[戻る]
    'Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack.Click
    '    Response.Redirect(URL.Menu)
    'End Sub

End Class
