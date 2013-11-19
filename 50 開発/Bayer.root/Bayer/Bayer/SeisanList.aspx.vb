Imports CommonLib
Imports AppLib

Partial Public Class SeisanList
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private TBL_SEIKYU() As TableDef.TBL_SEIKYU.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列    Private Enum CellIndex
        BU
        AREA
        EIGYOSHO
        TANTO_NAME
        FROM_DATE
        KOUENKAI_NO
        KOUENKAI_NAME
        SEIKYU_NO_TOPTOUR
        SEISAN_YM
        SHOUNIN_KUBUN
        SEND_FLAG
        Button1
        TO_DATE
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

            SetJoken()
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .HideLoginUser = True
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
        Try
            TBL_KOUENKAI = Session.Item(SessionDef.TBL_KOUENKAI)
            If TBL_KOUENKAI Is Nothing Then ReDim TBL_KOUENKAI(0)
        Catch ex As Exception
            ReDim TBL_KOUENKAI(0)
        End Try
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()
        'ドロップダウンリスト設定
        AppModule.SetDropDownList_SHOUNIN_KUBUN(Me.JokenSHOUNIN_KUBUN)
        AppModule.SetDropDownList_BU(Me.JokenBU, DbConnection)
        AppModule.SetDropDownList_AREA(Me.JokenKIKAKU_TANTO_AREA, DbConnection)

        'IME設定        CmnModule.SetIme(Me.JokenKOUENKAI_NO, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenSEIKYU_NO_TOPTOUR, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenSEISAN_Y, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenSEISAN_M, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenFROM_DATE_YYYY, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenFROM_DATE_MM, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenFROM_DATE_DD, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenTO_DATE_YYYY, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenTO_DATE_MM, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenTO_DATE_DD, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenKIKAKU_TANTO_ROMA, CmnModule.ImeType.Disabled)

        If URL.SeisanKensaku.IndexOf(Session.Item(SessionDef.BackURL)) > 0 Then
            Joken.KOUENKAI_NO = TBL_KOUENKAI(Session.Item(SessionDef.SeisanKensaku_SEQ)).KOUENKAI_NO
        End If

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '抽出条件表示
    Private Sub SetJoken()
        If Joken.KOUENKAI_NO <> "" Then Me.JokenKOUENKAI_NO.Text = Joken.KOUENKAI_NO
        If Joken.SEIKYU_NO_TOPTOUR <> "" Then Me.JokenSEIKYU_NO_TOPTOUR.Text = Joken.SEIKYU_NO_TOPTOUR
        If Joken.SEISAN_YM <> "" Then
            Me.JokenSEISAN_Y.Text = Mid(Joken.SEISAN_YM, 1, 4)
            Me.JokenSEISAN_M.Text = Mid(Joken.SEISAN_YM, 5, 2)
        End If

        If Joken.SHOUNIN_KUBUN <> "" Then Me.JokenSHOUNIN_KUBUN.SelectedItem.Value = Joken.SHOUNIN_KUBUN

        If Joken.FROM_DATE <> "" AndAlso Joken.FROM_DATE <> "指定なし" Then
            Me.JokenFROM_DATE_YYYY.Text = Joken.FROM_DATE.Substring(0, 4)
            Me.JokenFROM_DATE_MM.Text = Joken.FROM_DATE.Substring(4, 2)
            Me.JokenFROM_DATE_DD.Text = Joken.FROM_DATE.Substring(6, 2)
        End If
        If Joken.TO_DATE <> "" AndAlso Joken.TO_DATE <> "指定なし" Then
            Me.JokenTO_DATE_YYYY.Text = Joken.TO_DATE.Substring(0, 4)
            Me.JokenTO_DATE_MM.Text = Joken.TO_DATE.Substring(4, 2)
            Me.JokenTO_DATE_DD.Text = Joken.TO_DATE.Substring(6, 2)
        End If
        If Joken.BU <> "" AndAlso Joken.BU <> "指定なし" Then Me.JokenBU.SelectedValue = Joken.BU
        If Joken.AREA <> "" AndAlso Joken.AREA <> "指定なし" Then Me.JokenKIKAKU_TANTO_AREA.SelectedValue = Joken.AREA
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
        Joken.KOUENKAI_NO = Me.JokenKOUENKAI_NO.Text.Trim
        Joken.SEIKYU_NO_TOPTOUR = Me.JokenSEIKYU_NO_TOPTOUR.Text.Trim
        If Me.JokenSHOUNIN_KUBUN.SelectedIndex <> 0 Then Joken.SHOUNIN_KUBUN = Me.JokenSHOUNIN_KUBUN.SelectedItem.Value
        Joken.FROM_DATE = CmnModule.Format_DateToString(Me.JokenFROM_DATE_YYYY.Text, Me.JokenFROM_DATE_MM.Text, Me.JokenFROM_DATE_DD.Text)
        Joken.TO_DATE = CmnModule.Format_DateToString(Me.JokenTO_DATE_YYYY.Text, Me.JokenTO_DATE_MM.Text, Me.JokenTO_DATE_DD.Text)
        Joken.SEISAN_YM = CmnModule.Format_DateToString(Me.JokenSEISAN_Y.Text, Me.JokenSEISAN_M.Text)
        Joken.KIKAKU_TANTO_ROMA = Me.JokenKIKAKU_TANTO_ROMA.Text.Trim
        If Me.JokenBU.SelectedIndex <> 0 Then Joken.BU = Me.JokenBU.SelectedItem.Value
        If Me.JokenKIKAKU_TANTO_AREA.SelectedIndex <> 0 Then Joken.AREA = Me.JokenKIKAKU_TANTO_AREA.SelectedItem.Value

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
            e.Row.Cells(CellIndex.FROM_DATE).Text = AppModule.GetName_KOUENKAI_DATE(e.Row.Cells(CellIndex.FROM_DATE).Text, e.Row.Cells(CellIndex.TO_DATE).Text, True)
            e.Row.Cells(CellIndex.SEISAN_YM).Text = Mid(CmnModule.Format_DateJP(e.Row.Cells(CellIndex.SEISAN_YM).Text & "01", CmnModule.DateFormatType.YYYYMMDD), 1, 8)
            e.Row.Cells(CellIndex.SHOUNIN_KUBUN).Text = AppModule.GetName_SHOUNIN_KUBUN(e.Row.Cells(CellIndex.SHOUNIN_KUBUN).Text)
            e.Row.Cells(CellIndex.SEND_FLAG).Text = AppModule.GetName_SEND_FLAG(e.Row.Cells(CellIndex.SEND_FLAG).Text, True)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Private Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.TO_DATE).Visible = False
        End If
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
                Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath

                Response.Redirect(URL.SeisanRegist)
        End Select
    End Sub

    '[検索]
    Private Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
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

        If Not CmnCheck.IsAlphanumericHyphen(Me.JokenKOUENKAI_NO) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphanumericHyphenOnly("講演会番号"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenSEISAN_Y) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.SEISAN_YM & "(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenSEISAN_M) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_SEIKYU.Name.SEISAN_YM & "(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日From(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日From(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_DD) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日From(日)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.JokenFROM_DATE_YYYY) OrElse CmnCheck.IsInput(Me.JokenFROM_DATE_MM) OrElse CmnCheck.IsInput(Me.JokenFROM_DATE_DD) Then
            Dim wStr As String = StrConv(Trim(Me.JokenFROM_DATE_YYYY.Text) & "/" & Trim(Me.JokenFROM_DATE_MM.Text) & "/" & Trim(Me.JokenFROM_DATE_DD.Text), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("実施日From"), Me)
                Return False
            End If
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日To(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日To(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_DD) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日To(日)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.JokenTO_DATE_YYYY) OrElse CmnCheck.IsInput(Me.JokenTO_DATE_MM) OrElse CmnCheck.IsInput(Me.JokenTO_DATE_DD) Then
            Dim wStr As String = StrConv(Trim(Me.JokenTO_DATE_YYYY.Text) & "/" & Trim(Me.JokenTO_DATE_MM.Text) & "/" & Trim(Me.JokenTO_DATE_DD.Text), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("実施日To"), Me)
                Return False
            End If
        End If

        Return True
    End Function

    '[戻る]
    Private Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click, BtnBack2.Click
        Joken = Nothing
        Response.Redirect(URL.SeisanKensaku)
    End Sub

    '[新規登録]
    Private Sub BtnInsert_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnInsert.Click
        TBL_SEIKYU = Nothing
        Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Insert
        Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
        Response.Redirect(URL.SeisanRegist)
    End Sub
End Class