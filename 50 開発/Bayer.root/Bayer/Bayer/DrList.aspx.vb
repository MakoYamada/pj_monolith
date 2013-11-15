Imports CommonLib
Imports AppLib

Partial Public Class DrList
    Inherits WebBase

    Private TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列    Private Enum CellIndex
        FROM_DATE
        KOUENKAI_NAME
        DR_NAME
        TIME_STAMP
        UPDATE_DATE
        USER_NAME
        TEHAI_HOTEL
        TEHAI_KOTSU
        TEHAI_TAXI
        SEND_FLAG
        Button1
        KOUENKAI_NO
        SALESFORCE_ID
        TO_DATE
        REQ_O_TEHAI_1
        REQ_O_TEHAI_2
        REQ_O_TEHAI_3
        REQ_O_TEHAI_4
        REQ_O_TEHAI_5
        REQ_F_TEHAI_1
        REQ_F_TEHAI_2
        REQ_F_TEHAI_3
        REQ_F_TEHAI_4
        REQ_F_TEHAI_5
    End Enum

    Private Sub DrList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_KOTSUHOTEL) = TBL_KOTSUHOTEL
        Session.Item(SessionDef.Joken) = Joken
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '共通チェック
        MyModule.IsPageOK(False, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()

            If UBound(TBL_KOTSUHOTEL) = 0 And TBL_KOTSUHOTEL(0).SALEFORCE_ID Is Nothing Then
            Else
                SetJoken()
                SetForm()
            End If
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "検索　宿泊・交通・タクシーチケット手配依頼"
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
            TBL_KOTSUHOTEL = Session.Item(SessionDef.TBL_KOTSUHOTEL)
            If TBL_KOTSUHOTEL Is Nothing Then ReDim TBL_KOTSUHOTEL(0)
        Catch ex As Exception
            ReDim TBL_KOTSUHOTEL(0)
        End Try
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()
        'ドロップダウンリスト設定
        AppModule.SetDropDownList_BU(Me.JokenBU, DbConnection)
        AppModule.SetDropDownList_AREA(Me.JokenTEHAI_TANTO_AREA, DbConnection)
        AppModule.SetDropDownList_USER_NAME(Me.JokenTTEHAI_TANTO, DbConnection)
        AppModule.SetDropDownList_DR_SANKA(Me.JokenDR_SANKA)

        'IME設定            CmnModule.SetIme(Me.JokenMR_ROMA, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenDR_KANA, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.JokenKOUENKAI_NO, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenKOUENKAI_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.JokenFROM_DATE_YYYY, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenFROM_DATE_MM, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenFROM_DATE_DD, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenTO_DATE_YYYY, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenTO_DATE_MM, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenTO_DATE_DD, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenUPDATE_DATE_YYYY, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenUPDATE_DATE_MM, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenUPDATE_DATE_DD, CmnModule.ImeType.InActive)

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

    '抽出条件表示
    Private Sub SetJoken()
        If Joken.MR_ROMA <> "" AndAlso Joken.MR_ROMA <> "指定なし" Then Me.JokenMR_ROMA.Text = Joken.MR_ROMA
        If Joken.DR_KANA <> "" AndAlso Joken.DR_KANA <> "指定なし" Then Me.JokenDR_KANA.Text = Joken.DR_KANA
        If Joken.DR_SANKA <> "" AndAlso Joken.DR_SANKA <> "指定なし" Then Me.JokenDR_SANKA.SelectedValue = Joken.DR_SANKA
        If Joken.KOUENKAI_NO <> "" AndAlso Joken.KOUENKAI_NO <> "指定なし" Then Me.JokenKOUENKAI_NO.Text = Joken.KOUENKAI_NO
        If Joken.KOUENKAI_NAME <> "" AndAlso Joken.KOUENKAI_NAME <> "指定なし" Then Me.JokenKOUENKAI_NAME.Text = Joken.KOUENKAI_NAME
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
        If Joken.AREA <> "" AndAlso Joken.AREA <> "指定なし" Then Me.JokenTEHAI_TANTO_AREA.SelectedValue = Joken.AREA
        If Joken.TTANTO_ID <> "" AndAlso Joken.TTANTO_ID <> "指定なし" Then Me.JokenTTEHAI_TANTO.SelectedValue = Joken.TTANTO_ID
        If Joken.UPDATE_DATE <> "" AndAlso Joken.UPDATE_DATE <> "指定なし" Then
            Me.JokenUPDATE_DATE_YYYY.Text = Joken.UPDATE_DATE.Substring(0, 4)
            Me.JokenUPDATE_DATE_MM.Text = Joken.UPDATE_DATE.Substring(4, 2)
            Me.JokenUPDATE_DATE_DD.Text = Joken.UPDATE_DATE.Substring(6, 2)
        End If
    End Sub

    'データ取得
    Private Function GetData() As Boolean
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        Joken = Nothing
        Joken.MR_ROMA = Me.JokenMR_ROMA.Text.Trim
        Joken.DR_KANA = Me.JokenDR_KANA.Text.Trim
        Joken.DR_SANKA = Me.JokenDR_SANKA.SelectedValue
        Joken.KOUENKAI_NO = Me.JokenKOUENKAI_NO.Text.Trim
        Joken.KOUENKAI_NAME = Me.JokenKOUENKAI_NAME.Text.Trim
        Joken.FROM_DATE = CmnModule.Format_DateToString(Me.JokenFROM_DATE_YYYY.Text, Me.JokenFROM_DATE_MM.Text, Me.JokenFROM_DATE_DD.Text)
        Joken.TO_DATE = CmnModule.Format_DateToString(Me.JokenTO_DATE_YYYY.Text, Me.JokenTO_DATE_MM.Text, Me.JokenTO_DATE_DD.Text)
        If Me.JokenBU.SelectedIndex <> 0 Then Joken.BU = Me.JokenBU.SelectedItem.ToString
        If Me.JokenTEHAI_TANTO_AREA.SelectedIndex <> 0 Then Joken.AREA = Me.JokenTEHAI_TANTO_AREA.SelectedItem.ToString
        If Me.JokenTTEHAI_TANTO.SelectedIndex <> 0 Then Joken.TTANTO_ID = Me.JokenTTEHAI_TANTO.SelectedValue
        Joken.UPDATE_DATE = CmnModule.Format_DateToString(Me.JokenUPDATE_DATE_YYYY.Text, Me.JokenUPDATE_DATE_MM.Text, Me.JokenUPDATE_DATE_DD.Text)

        ReDim TBL_KOTSUHOTEL(wCnt)

        strSQL = SQL.TBL_KOTSUHOTEL.Search(Joken, False)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve TBL_KOTSUHOTEL(wCnt)
            TBL_KOTSUHOTEL(wCnt) = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL(wCnt))

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
        Dim strSQL As String = SQL.TBL_KOTSUHOTEL.Search(Joken, False)
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

            '実施日
            e.Row.Cells(CellIndex.FROM_DATE).Text = AppModule.GetName_KOUENKAI_DATE(e.Row.Cells(CellIndex.FROM_DATE).Text, e.Row.Cells(CellIndex.TO_DATE).Text, True)
            'TimeStamp
            e.Row.Cells(CellIndex.TIME_STAMP).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.TIME_STAMP).Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
            '更新日
            e.Row.Cells(CellIndex.UPDATE_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.UPDATE_DATE).Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
            '宿泊
            e.Row.Cells(CellIndex.TEHAI_HOTEL).Text = AppModule.GetMark_TEHAI_HOTEL(e.Row.Cells(CellIndex.TEHAI_HOTEL).Text)
            '交通
            If e.Row.Cells(CellIndex.REQ_O_TEHAI_1).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_O_TEHAI_2).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_O_TEHAI_3).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_O_TEHAI_4).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_O_TEHAI_5).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_F_TEHAI_1).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_F_TEHAI_2).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_F_TEHAI_3).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_F_TEHAI_4).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                e.Row.Cells(CellIndex.REQ_F_TEHAI_5).Text = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes Then

                e.Row.Cells(CellIndex.TEHAI_KOTSU).Text = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes)
            Else
                e.Row.Cells(CellIndex.TEHAI_KOTSU).Text = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No)
            End If
            'タクチケ
            e.Row.Cells(CellIndex.TEHAI_TAXI).Text = AppModule.GetMark_TEHAI_TAXI(e.Row.Cells(CellIndex.TEHAI_TAXI).Text)
            'NOZOMI送信ステータス
            e.Row.Cells(CellIndex.SEND_FLAG).Text = AppModule.GetName_SEND_FLAG(e.Row.Cells(CellIndex.SEND_FLAG).Text, True)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.KOUENKAI_NO).Visible = False
            e.Row.Cells(CellIndex.SALESFORCE_ID).Visible = False
            e.Row.Cells(CellIndex.TO_DATE).Visible = False
            e.Row.Cells(CellIndex.REQ_O_TEHAI_1).Visible = False
            e.Row.Cells(CellIndex.REQ_O_TEHAI_2).Visible = False
            e.Row.Cells(CellIndex.REQ_O_TEHAI_3).Visible = False
            e.Row.Cells(CellIndex.REQ_O_TEHAI_4).Visible = False
            e.Row.Cells(CellIndex.REQ_O_TEHAI_5).Visible = False
            e.Row.Cells(CellIndex.REQ_F_TEHAI_1).Visible = False
            e.Row.Cells(CellIndex.REQ_F_TEHAI_2).Visible = False
            e.Row.Cells(CellIndex.REQ_F_TEHAI_3).Visible = False
            e.Row.Cells(CellIndex.REQ_F_TEHAI_4).Visible = False
            e.Row.Cells(CellIndex.REQ_F_TEHAI_5).Visible = False
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
                '選択レコード情報をセッション変数にセット
                Session.Item(SessionDef.SEQ) = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + CmnModule.DbVal(e.CommandArgument)
                Session.Item(SessionDef.TBL_KOTSUHOTEL) = TBL_KOTSUHOTEL
                Session.Item(SessionDef.PageIndex) = Me.GrvList.PageIndex
                Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
                Session.Item(SessionDef.BackURL2) = Request.Url.AbsolutePath

                '履歴画面用セッション変数をクリア
                Session.Remove(SessionDef.KaijoRireki)
                Session.Remove(SessionDef.KouenkaiRireki_PageIndex)
                Session.Remove(SessionDef.KouenkaiRireki_SEQ)
                Session.Item(SessionDef.KouenkaiRireki_TBL_KOUENKAI) = False

                Response.Redirect(URL.DrRegist)
        End Select
    End Sub

    '[検索]
    Private Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        '入力チェック
        If Not Check() Then Exit Sub

        '一覧 表示
        DispList()

    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsAlphabetOnly(Me.JokenMR_ROMA) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphabetOnly("Dr担当MR名(ローマ字)"), Me)
            Return False
        End If

        'If Not CmnCheck.IsHanKatakana(Me.JokenDR_KANA) Then
        '    CmnModule.AlertMessage(MessageDef.Error.HanKatakanaOnly("DR名(カナ)"), Me)
        '    Return False
        'End If

        If Not CmnCheck.IsAlphanumericHyphen(Me.JokenKOUENKAI_NO) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphanumericHyphenOnly("講演会番号"), Me)
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

        If Not CmnCheck.IsNumberOnly(Me.JokenUPDATE_DATE_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("更新日(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenUPDATE_DATE_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("更新日(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenUPDATE_DATE_DD) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("更新日(日)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.JokenUPDATE_DATE_YYYY) OrElse CmnCheck.IsInput(Me.JokenUPDATE_DATE_MM) OrElse CmnCheck.IsInput(Me.JokenUPDATE_DATE_DD) Then
            Dim wStr As String = StrConv(Trim(Me.JokenUPDATE_DATE_YYYY.Text) & "/" & Trim(Me.JokenUPDATE_DATE_MM.Text) & "/" & Trim(Me.JokenUPDATE_DATE_DD.Text), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("更新日"), Me)
                Return False
            End If
        End If

        Return True
    End Function

    '[戻る]
    Private Sub BtnBack1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click
        Response.Redirect(URL.Menu)
    End Sub

    '[戻る]
    Private Sub BtnBack2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack2.Click
        BtnBack1_Click(sender, e)
    End Sub

    '[印刷]
    Private Sub BtnPrint1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint1.Click
        Dim strSQL As String = ""

        Joken.MR_ROMA = Me.JokenMR_ROMA.Text.Trim
        Joken.DR_KANA = Me.JokenDR_KANA.Text.Trim
        Joken.DR_SANKA = Me.JokenDR_SANKA.SelectedValue
        Joken.KOUENKAI_NO = Me.JokenKOUENKAI_NO.Text.Trim
        Joken.KOUENKAI_NAME = Me.JokenKOUENKAI_NAME.Text.Trim
        Joken.FROM_DATE = CmnModule.Format_DateToString(Me.JokenFROM_DATE_YYYY.Text, Me.JokenFROM_DATE_MM.Text, Me.JokenFROM_DATE_DD.Text)
        Joken.TO_DATE = CmnModule.Format_DateToString(Me.JokenTO_DATE_YYYY.Text, Me.JokenTO_DATE_MM.Text, Me.JokenTO_DATE_DD.Text)
        If Me.JokenBU.SelectedIndex <> 0 Then Joken.BU = Me.JokenBU.SelectedItem.ToString
        If Me.JokenTEHAI_TANTO_AREA.SelectedIndex <> 0 Then Joken.AREA = Me.JokenTEHAI_TANTO_AREA.SelectedItem.ToString
        If Me.JokenTTEHAI_TANTO.SelectedIndex <> 0 Then Joken.TTANTO_ID = Me.JokenTTEHAI_TANTO.SelectedValue
        Joken.UPDATE_DATE = CmnModule.Format_DateToString(Me.JokenUPDATE_DATE_YYYY.Text, Me.JokenUPDATE_DATE_MM.Text, Me.JokenUPDATE_DATE_DD.Text)

        strSQL = SQL.TBL_KOTSUHOTEL.Search(Joken, False)
        If Joken.MR_ROMA.Trim = "" Then Joken.MR_ROMA = "指定なし"
        If Joken.DR_KANA.Trim = "" Then Joken.DR_KANA = "指定なし"
        If Joken.DR_SANKA.Trim = "" Then Joken.DR_SANKA = "指定なし"
        If Joken.KOUENKAI_NO.Trim = "" Then Joken.KOUENKAI_NO = "指定なし"
        If Joken.KOUENKAI_NAME.Trim = "" Then Joken.KOUENKAI_NAME = "指定なし"
        If Joken.FROM_DATE.Trim = "" Then Joken.FROM_DATE = "指定なし"
        If Joken.TO_DATE.Trim = "" Then Joken.TO_DATE = "指定なし"
        If Joken.BU.Trim = "" Then Joken.BU = "指定なし"
        If Joken.AREA.Trim = "" Then Joken.AREA = "指定なし"
        If Joken.TTANTO_ID.Trim = "" Then Joken.TTANTO_ID = "指定なし"
        If Joken.UPDATE_DATE.Trim = "" Then Joken.UPDATE_DATE = "指定なし"

        Session.Item(SessionDef.DrPrint_SQL) = strSQL
        Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Session.Item(SessionDef.Joken) = Joken
        Response.Redirect(URL.Preview)
    End Sub
End Class