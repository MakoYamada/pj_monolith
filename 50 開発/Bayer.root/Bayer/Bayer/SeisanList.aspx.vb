Imports CommonLib
Imports AppLib

Partial Public Class SeisanList
    Inherits WebBase

    Private TBL_SEIKYU() As TableDef.TBL_SEIKYU.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列    Private Enum CellIndex
        KOUENKAI_NO
        KOUENKAI_NAME
        SEIKYU_NO_TOPTOUR
        SEISAN_YM
        KEI_TF
        KEI_T
        Button1
    End Enum

    Private Sub SeisanList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_SEIKYU) = TBL_SEIKYU
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

            SetForm()

        End If

        'マスターページ設定
        With Me.Master
            .HideLoginUser = True   'QQQ
            .PageTitle = "【検索】精算データ"
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
            TBL_SEIKYU = Session.Item(SessionDef.TBL_SEIKYU)
            If TBL_SEIKYU Is Nothing Then ReDim TBL_SEIKYU(0)
        Catch ex As Exception
            ReDim TBL_SEIKYU(0)
        End Try
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        'IME設定        CmnModule.SetIme(Me.JokenKOUENKAI_NO, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenSEIKYU_NO_TOPTOUR, CmnModule.ImeType.Disabled)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '抽出条件表示
    Private Sub SetJoken()
        If Joken.KOUENKAI_NO <> "" Then Me.JokenKOUENKAI_NO.Text = Joken.KOUENKAI_NO
        If Joken.SEIKYU_NO_TOPTOUR <> "" Then Me.JokenSEIKYU_NO_TOPTOUR.Text = Joken.SEIKYU_NO_TOPTOUR
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        Call SetJoken()

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
        Joken.KOUENKAI_NO = Trim(Me.JokenKOUENKAI_NO.Text)
        Joken.SEIKYU_NO_TOPTOUR = Trim(Me.JokenSEIKYU_NO_TOPTOUR.Text)

        ReDim TBL_SEIKYU(wCnt)
        strSQL = SQL.TBL_SEIKYU.Search(Joken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)

        While RsData.Read()
            wFlag = True

            ReDim Preserve TBL_SEIKYU(wCnt)
            TBL_SEIKYU(wCnt) = AppModule.SetRsData(RsData, TBL_SEIKYU(wCnt))

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
        Dim strSQL As String = SQL.TBL_SEIKYU.Search(Joken)
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
    Private Sub GrvList_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.SEISAN_YM).Text = Mid(CmnModule.Format_DateJP(e.Row.Cells(CellIndex.SEISAN_YM).Text & "01", CmnModule.DateFormatType.YYYYMMDD), 1, 8)
            e.Row.Cells(CellIndex.KEI_TF).Text = CmnModule.EditComma(e.Row.Cells(CellIndex.KEI_TF).Text)
            e.Row.Cells(CellIndex.KEI_T).Text = CmnModule.EditComma(e.Row.Cells(CellIndex.KEI_T).Text)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Private Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated

    End Sub

    'グリッドビュー ページ移動時
    Private Sub GrvList_PageIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrvList.PageIndexChanged
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
    Private Sub GrvList_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GrvList.RowCommand
        Select Case e.CommandName
            Case "Detail"
                '選択レコード情報をセッション変数にセット
                Session.Item(SessionDef.SEQ) = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + CmnModule.DbVal(e.CommandArgument)
                Session.Item(SessionDef.TBL_SEIKYU) = TBL_SEIKYU
                Session.Item(SessionDef.PageIndex) = Me.GrvList.PageIndex
                Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Update

                Response.Redirect(URL.SeisanRegist)
        End Select
    End Sub

    '[検索]
    Private Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        '入力チェック
        If Not Check() Then Exit Sub

        Joken = Nothing
        Joken.KOUENKAI_NO = Trim(Me.JokenKOUENKAI_NO.Text)
        Joken.SEIKYU_NO_TOPTOUR = Trim(Me.JokenSEIKYU_NO_TOPTOUR.Text)

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

        Return True
    End Function

    '[戻る]
    Private Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        Response.Redirect(URL.Menu)
    End Sub

    '[新規登録]
    Private Sub BtnInsert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnInsert.Click
        Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Insert
        Response.Redirect(URL.SeisanRegist)
    End Sub
End Class