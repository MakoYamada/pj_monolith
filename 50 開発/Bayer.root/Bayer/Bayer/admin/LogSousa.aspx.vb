Imports CommonLib
Imports AppLib
Partial Public Class LogSousa
    Inherits WebBase

    Private TBL_LOG() As TableDef.TBL_LOG.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列
    Private Enum CellIndex
        INPUT_DATE
        INPUT_USER
        SYORI_NAME
        Template1
        USER_NAME
        STATUS
        NOTE
    End Enum

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_LOG) = TBL_LOG
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

        'マスターページ設定
        With Me.Master
            .PageTitle = "操作ログ照会"
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
            TBL_LOG = Session.Item(SessionDef.TBL_LOG)
            If TBL_LOG Is Nothing Then ReDim TBL_LOG(0)
        Catch ex As Exception
            ReDim TBL_LOG(0)
        End Try
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        'プルダウン設定
        AppModule.SetDropDownList_SYORI_NAME.LogSousa(Me.JokenSYORI_NAME)
        AppModule.SetDropDownList_STATUS.LogSousa(Me.JokenSTATUS)

        'IME設定
        CmnModule.SetIme(Me.JokenINPUT_USER, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenINPUT_DATE_YYYY, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenINPUT_DATE_MM, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenINPUT_DATE_DD, CmnModule.ImeType.Disabled)

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
            Session.Item(SessionDef.PageIndex) = 0
            SetGridView()
        End If
    End Sub

    'データ取得
    Private Function GetData() As Boolean
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        ReDim TBL_LOG(wCnt)
        strSQL = SQL.TBL_LOG.Search(Joken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve TBL_LOG(wCnt)
            TBL_LOG(wCnt) = AppModule.SetRsData(RsData, TBL_LOG(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag
    End Function

    'データソース設定
    Private Sub SetGridView()
        'データソース設定
        Dim strSQL As String = SQL.TBL_LOG.Search(Joken)
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
            e.Row.Cells(CellIndex.INPUT_DATE).Text = AppModule.GetName_INPUT_DATE(e.Row.Cells(CellIndex.INPUT_DATE).Text)
            e.Row.Cells(CellIndex.INPUT_USER).Text = AppModule.GetName_INPUT_USER(e.Row.Cells(CellIndex.INPUT_USER).Text, e.Row.Cells(CellIndex.USER_NAME).Text)

            CType(e.Row.Cells(CellIndex.Template1).FindControl("STATUS"), Label).Text = AppModule.GetName_STATUS(e.Row.Cells(CellIndex.STATUS).Text)
            CType(e.Row.Cells(CellIndex.Template1).FindControl("NOTE"), Label).Text = Trim(CmnModule.ClearHtmlSpace(e.Row.Cells(CellIndex.NOTE).Text))
            Select Case CmnModule.ClearHtmlSpace(e.Row.Cells(CellIndex.STATUS).Text)
                Case AppConst.TBL_LOG.STATUS.Code.OK
                    CType(e.Row.Cells(CellIndex.Template1).FindControl("NOTE"), Label).ForeColor = Drawing.Color.FromArgb(49, 81, 11)
                Case AppConst.TBL_LOG.STATUS.Code.NG
                    CType(e.Row.Cells(CellIndex.Template1).FindControl("NOTE"), Label).ForeColor = Drawing.Color.FromArgb(203, 26, 26)
            End Select
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.STATUS).Visible = False
            e.Row.Cells(CellIndex.USER_NAME).Visible = False
            e.Row.Cells(CellIndex.NOTE).Visible = False
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
            Session.Item(SessionDef.PageIndex) = .PageIndex

            'グリッドビュー表示
            SetGridView()
        End With
    End Sub

    '[検索]
    Protected Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        '入力チェック(条件)
        'If Not Check() Then Exit Sub

        Joken = Nothing
        Joken.SYORI_KBN = AppConst.TBL_LOG.SYORI_KBN.Code.GAMEN
        Joken.INPUT_USER = Trim(Me.JokenINPUT_USER.Text)
        Joken.SYORI_NAME = CmnModule.GetSelectedItemValue(Me.JokenSYORI_NAME)
        Joken.INPUT_DATE = CmnModule.Format_DateToString(Me.JokenINPUT_DATE_YYYY.Text, Me.JokenINPUT_DATE_MM.Text, Me.JokenINPUT_DATE_DD.Text)
        Joken.STATUS = CmnModule.GetSelectedItemValue(Me.JokenSTATUS)
        Session.Item(SessionDef.Joken) = Joken

        '画面項目表示
        SetForm()
    End Sub

    '入力チェック(条件)
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.JokenINPUT_USER) AndAlso _
           Not CmnCheck.IsInput(Me.JokenSYORI_NAME) AndAlso _
           Not CmnCheck.IsInput(Me.JokenINPUT_DATE_YYYY) AndAlso _
           Not CmnCheck.IsInput(Me.JokenINPUT_DATE_MM) AndAlso _
           Not CmnCheck.IsInput(Me.JokenINPUT_DATE_DD) AndAlso _
           Not CmnCheck.IsInput(Me.JokenSTATUS) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput_Joken, Me)
            Return False
        End If

        Return True
    End Function

End Class
