Imports CommonLib
Imports AppLib
Partial Public Class KaijoList
    Inherits WebBase

    Private TBL_KAIJO() As TableDef.TBL_KAIJO.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列
    Private Enum CellIndex
        KIKAKU_TANTO_BU
        KIKAKU_TANTO_AREA
        KIKAKU_TANTO_EIGYOSHO
        FROM_DATE
        KOUENKAI_NAME
        USER_NAME
        Button1
        Button2
        KOUENKAI_NO
        TO_DATE
    End Enum

    Private Sub DrList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_KAIJO) = TBL_KAIJO
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
            .PageTitle = "【検索】会場見積依頼"
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
        'AppModule.SetDropDownList_BU(Me.BU, MyBase.DbConnection)
        'AppModule.SetDropDownList_AREA(Me.KIKAKU_TANTO_AREA, MyBase.DbConnection)

        'IME設定
        CmnModule.SetIme(Me.KIKAKU_TANTO_ROMA, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TEHAI_TANTO_ROMA, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SEIHIN_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.KOUENKAI_NO, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.KOUENKAI_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.FROM_DATE_YYYY, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.FROM_DATE_MM, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.FROM_DATE_DD, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TO_DATE_YYYY, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TO_DATE_MM, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TO_DATE_DD, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TTANTO_ID, CmnModule.ImeType.Disabled)

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
        Joken.KIKAKU_TANTO_ROMA = Trim(Me.KIKAKU_TANTO_ROMA.Text)
        Joken.TEHAI_TANTO_ROMA = Trim(Me.TEHAI_TANTO_ROMA.Text)
        Joken.SEIHIN_NAME = Trim(Me.SEIHIN_NAME.Text)
        Joken.KOUENKAI_NO = Trim(Me.KOUENKAI_NO.Text)
        Joken.KOUENKAI_NAME = Trim(Me.KOUENKAI_NAME.Text)
        Joken.BU = CmnModule.GetSelectedItemValue(Me.KIKAKU_TANTO_BU)
        Joken.FROM_DATE = CmnModule.Format_DateToString(Me.FROM_DATE_YYYY.Text, Me.FROM_DATE_MM.Text, Me.FROM_DATE_DD.Text)
        Joken.TO_DATE = CmnModule.Format_DateToString(Me.TO_DATE_YYYY.Text, Me.TO_DATE_MM.Text, Me.TO_DATE_DD.Text)
        Joken.AREA = CmnModule.GetSelectedItemValue(Me.KIKAKU_TANTO_AREA)
        Joken.TTANTO_ID = Trim(Me.TTANTO_ID.Text)
        
        ReDim TBL_KAIJO(wCnt)
        strSQL = SQL.TBL_KAIJO.Search(Joken, False)
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
        Dim strSQL As String = SQL.TBL_KAIJO.Search(Joken, False)
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

        If Not CmnCheck.IsInput(KIKAKU_TANTO_ROMA) AndAlso _
           Not CmnCheck.IsInput(TEHAI_TANTO_ROMA) AndAlso _
           Not CmnCheck.IsInput(SEIHIN_NAME) AndAlso _
           Not CmnCheck.IsInput(KOUENKAI_NO) AndAlso _
           Not CmnCheck.IsInput(KOUENKAI_NAME) AndAlso _
           Not CmnCheck.IsInput(FROM_DATE_YYYY) AndAlso _
           Not CmnCheck.IsInput(FROM_DATE_MM) AndAlso _
           Not CmnCheck.IsInput(FROM_DATE_DD) AndAlso _
           Not CmnCheck.IsInput(TO_DATE_YYYY) AndAlso _
           Not CmnCheck.IsInput(TO_DATE_MM) AndAlso _
           Not CmnCheck.IsInput(TO_DATE_DD) AndAlso _
           Not CmnCheck.IsInput(KIKAKU_TANTO_BU) AndAlso _
           Not CmnCheck.IsInput(KIKAKU_TANTO_AREA) AndAlso _
           Not CmnCheck.IsInput(TTANTO_ID) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput_Joken, Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.FROM_DATE_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日From(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.FROM_DATE_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日From(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.FROM_DATE_DD) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日From(日)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.FROM_DATE_YYYY) OrElse CmnCheck.IsInput(Me.FROM_DATE_MM) OrElse CmnCheck.IsInput(Me.FROM_DATE_DD) Then
            Dim wStr As String = StrConv(Trim(Me.FROM_DATE_YYYY.Text) & "/" & Trim(Me.FROM_DATE_MM.Text) & "/" & Trim(Me.FROM_DATE_DD.Text), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("実施日From"), Me)
                Return False
            End If
        End If

        If Not CmnCheck.IsNumberOnly(Me.TO_DATE_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日To(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.TO_DATE_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日To(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.TO_DATE_DD) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日To(日)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.TO_DATE_YYYY) OrElse CmnCheck.IsInput(Me.TO_DATE_MM) OrElse CmnCheck.IsInput(Me.TO_DATE_DD) Then
            Dim wStr As String = StrConv(Trim(Me.TO_DATE_YYYY.Text) & "/" & Trim(Me.TO_DATE_MM.Text) & "/" & Trim(Me.TO_DATE_DD.Text), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("実施日To"), Me)
                Return False
            End If
        End If

        Return True
    End Function

    '[戻る]
    Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        Response.Redirect(URL.Menu)
    End Sub

End Class
