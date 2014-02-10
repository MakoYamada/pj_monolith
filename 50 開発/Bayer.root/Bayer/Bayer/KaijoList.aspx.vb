Imports CommonLib
Imports AppLib
Partial Public Class KaijoList
    Inherits WebBase

    Private TBL_KAIJO() As TableDef.TBL_KAIJO.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列
    Private Enum CellIndex
        BU
        KIKAKU_TANTO_AREA
        KIKAKU_TANTO_EIGYOSHO
        KIKAKU_TANTO_NAME
        FROM_DATE
        KOUENKAI_NO
        KOUENKAI_NAME
        TEHAI_ID
        TIME_STAMP_BYL
        SEND_FLAG
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
            .PageTitle = "【検索】会場手配"
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
        AppModule.SetDropDownList_SEIHIN(Me.JokenSEIHIN, MyBase.DbConnection)
        AppModule.SetDropDownList_USER_NAME(Me.JoKenTTANTO_ID, MyBase.DbConnection)

        'IME設定
        CmnModule.SetIme(Me.JokenKIKAKU_TANTO_ROMA, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenTEHAI_TANTO_ROMA, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenKOUENKAI_NO, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenKOUENKAI_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.JokenFROM_DATE_YYYY, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenFROM_DATE_MM, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenFROM_DATE_DD, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenTO_DATE_YYYY, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenTO_DATE_MM, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenTO_DATE_DD, CmnModule.ImeType.Disabled)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        'If InStr(Request.UrlReferrer.AbsolutePath.ToLower, "/menu.aspx") > 0 Then
        '    'メニューからの遷移時
        '    Me.LabelNoData.Visible = False
        '    Me.GrvList.Visible = False
        '    Me.TblButton1.Visible = False
        '    Me.SpnBtnKaijoListPrint2.Visible = False
        'Else
        '条件表示
        Me.JokenKIKAKU_TANTO_ROMA.Text = Trim(Joken.KIKAKU_TANTO_ROMA)
        Me.JokenTEHAI_TANTO_ROMA.Text = Trim(Joken.TEHAI_TANTO_ROMA)
        Me.JokenKOUENKAI_NO.Text = Trim(Joken.KOUENKAI_NO)
        Me.JokenKOUENKAI_NAME.Text = Trim(Joken.KOUENKAI_NAME)
        If Trim(Joken.FROM_DATE) <> "" Then
            Me.JokenFROM_DATE_YYYY.Text = Mid(Joken.FROM_DATE, 1, 4)
            Me.JokenFROM_DATE_MM.Text = Mid(Joken.FROM_DATE, 5, 2)
            Me.JokenFROM_DATE_DD.Text = Mid(Joken.FROM_DATE, 7, 2)
        End If
        If Trim(Joken.TO_DATE) <> "" Then
            Me.JokenTO_DATE_YYYY.Text = Mid(Joken.TO_DATE, 1, 4)
            Me.JokenTO_DATE_MM.Text = Mid(Joken.TO_DATE, 5, 2)
            Me.JokenTO_DATE_DD.Text = Mid(Joken.TO_DATE, 7, 2)
        End If
        Me.JokenSEIHIN.SelectedIndex = CmnModule.GetSelectedIndex(Joken.SEIHIN_NAME, Me.JokenSEIHIN)
        Me.JokenBU.SelectedIndex = CmnModule.GetSelectedIndex(Joken.BU, Me.JokenBU)
        Me.JokenKIKAKU_TANTO_AREA.SelectedIndex = CmnModule.GetSelectedIndex(Joken.AREA, Me.JokenKIKAKU_TANTO_AREA)
        Me.JoKenTTANTO_ID.SelectedIndex = CmnModule.GetSelectedIndex(Joken.TTANTO_ID, Me.JoKenTTANTO_ID)

        'データ取得
        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.GrvList.Visible = False
            Me.TblButton1.Visible = False
            Me.SpnBtnKaijoListPrint2.Visible = True
            CmnModule.SetEnabled(Me.BtnKaijoListPrint1, False)
            CmnModule.SetEnabled(Me.BtnKaijoListPrint2, False)
        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True
            Me.TblButton1.Visible = True
            Me.SpnBtnKaijoListPrint2.Visible = True
            CmnModule.SetEnabled(Me.BtnKaijoListPrint1, True)
            CmnModule.SetEnabled(Me.BtnKaijoListPrint2, True)

            'グリッドビュー表示
            SetGridView()
        End If
        'End If
    End Sub

    'データ取得
    Private Function GetData() As Boolean
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

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
            e.Row.Cells(CellIndex.FROM_DATE).Text = AppModule.GetName_KOUENKAI_DATE(e.Row.Cells(CellIndex.FROM_DATE).Text, e.Row.Cells(CellIndex.TO_DATE).Text, True)
            e.Row.Cells(CellIndex.TIME_STAMP_BYL).Text = AppModule.GetName_TIME_STAMP_BYL(e.Row.Cells(CellIndex.TIME_STAMP_BYL).Text)
            e.Row.Cells(CellIndex.SEND_FLAG).Text = AppModule.GetName_SEND_FLAG(e.Row.Cells(CellIndex.SEND_FLAG).Text, True)
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
        Joken.KIKAKU_TANTO_ROMA = Trim(Me.JokenKIKAKU_TANTO_ROMA.Text)
        Joken.TEHAI_TANTO_ROMA = Trim(Me.JokenTEHAI_TANTO_ROMA.Text)
        Joken.SEIHIN_NAME = CmnModule.GetSelectedItemValue(Me.JokenSEIHIN)
        Joken.KOUENKAI_NO = Trim(Me.JokenKOUENKAI_NO.Text)
        Joken.KOUENKAI_NAME = Trim(Me.JokenKOUENKAI_NAME.Text)
        Joken.BU = CmnModule.GetSelectedItemValue(Me.JokenBU)
        Joken.AREA = CmnModule.GetSelectedItemValue(Me.JokenKIKAKU_TANTO_AREA)
        Joken.FROM_DATE = CmnModule.Format_DateToString(Me.JokenFROM_DATE_YYYY.Text, Me.JokenFROM_DATE_MM.Text, Me.JokenFROM_DATE_DD.Text)
        Joken.TO_DATE = CmnModule.Format_DateToString(Me.JokenTO_DATE_YYYY.Text, Me.JokenTO_DATE_MM.Text, Me.JokenTO_DATE_DD.Text)
        Joken.TTANTO_ID = CmnModule.GetSelectedItemValue(Me.JoKenTTANTO_ID)
        Joken.USER_NAME = CmnModule.GetSelectedItemText(Me.JoKenTTANTO_ID)

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

    '[手配依頼一覧印刷]
    Protected Sub BtnKaijoListPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnKaijoListPrint1.Click, BtnKaijoListPrint2.Click
        Dim strSQL As String = SQL.TBL_KAIJO.Search(Joken, False)
        Session.Item(SessionDef.KaijoPrint_SQL) = strSQL
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Session.Item(SessionDef.PrintPreview) = "KaijoList"
        Response.Redirect(URL.Preview)
    End Sub

    '[戻る]
    Protected Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click, BtnBack2.Click
        Session.Remove(SessionDef.TBL_KAIJO)
        Session.Remove(SessionDef.KaijoRireki_TBL_KAIJO)
        Session.Remove(SessionDef.KaijoRireki_Joken)
        Session.Remove(SessionDef.KaijoPrint_SQL)
        Session.Remove(SessionDef.BackURL_Print)
        Session.Remove(SessionDef.PrintPreview)
        Response.Redirect(URL.Menu)
    End Sub

End Class
