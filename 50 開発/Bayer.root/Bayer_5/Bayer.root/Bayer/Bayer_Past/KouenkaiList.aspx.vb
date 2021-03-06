﻿Imports CommonLib
Imports AppLib

Partial Public Class KouenkaiList
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private TBL_KOUENKAI_KEY() As TableDef.TBL_KOUENKAI.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列    Private Enum CellIndex
        BU
        KIKAKU_TANTO_AREA
        KIKAKU_TANTO_EIGYOSHO
        KIKAKU_TANTO_NAME
        FROM_DATE
        KOUENKAI_NO
        KOUENKAI_NAME
        TIME_STAMP_BYL
        USER_NAME
        Button1
        TO_DATE
        TIME_STAMP2
        KOUENKAI_TITLE
    End Enum

    Private Sub KouenkaiList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
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
        MyModule.IsPageOK(False, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納
        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()

            If UBound(TBL_KOUENKAI) = 0 And TBL_KOUENKAI(0).KOUENKAI_NO Is Nothing Then
                '@@@ Phase2
                'SetForm()
                '@@@ Phase2
            Else
                SetJoken()
                'SetForm()
            End If
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = False
            Me.BtnPrint1.Visible = False
            Me.BtnPrint2.Visible = False
            Me.BtnBack2.Visible = False
        End If

        'マスターページ設定
        With Me.Master
            .HideLoginUser = True   'QQQ
            .PageTitle = "【検索】基本情報"
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
            TBL_KOUENKAI = Session.Item(SessionDef.TBL_KOUENKAI)
            If TBL_KOUENKAI Is Nothing Then ReDim TBL_KOUENKAI(0)
        Catch ex As Exception
            ReDim TBL_KOUENKAI(0)
        End Try
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()
        'ドロップダウンリスト設定
        AppModule.SetDropDownList_BU(Me.JokenBU, DbConnection)
        AppModule.SetDropDownList_AREA(Me.JokenKIKAKU_TANTO_AREA, DbConnection)
        AppModule.SetDropDownList_SEIHIN(Me.JokenSEIHIN_NAME, DbConnection)
        AppModule.SetDropDownList_USER_NAME(Me.JokenTTEHAI_TANTO, DbConnection)

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

    '抽出条件表示
    Private Sub SetJoken()

        If Joken.KIKAKU_TANTO_ROMA <> "" AndAlso Joken.KIKAKU_TANTO_ROMA <> "指定なし" Then Me.JokenKIKAKU_TANTO_ROMA.Text = Joken.KIKAKU_TANTO_ROMA
        If Joken.TEHAI_TANTO_ROMA <> "" AndAlso Joken.TEHAI_TANTO_ROMA <> "指定なし" Then Me.JokenTEHAI_TANTO_ROMA.Text = Joken.TEHAI_TANTO_ROMA
        If Joken.SEIHIN_NAME <> "" AndAlso Joken.SEIHIN_NAME <> "指定なし" Then Me.JokenSEIHIN_NAME.Text = Joken.SEIHIN_NAME
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
        If Joken.AREA <> "" AndAlso Joken.AREA <> "指定なし" Then Me.JokenKIKAKU_TANTO_AREA.SelectedValue = Joken.AREA
        If Joken.TTANTO_ID <> "" AndAlso Joken.TTANTO_ID <> "指定なし" Then Me.JokenTTEHAI_TANTO.SelectedValue = Joken.TTANTO_ID
    End Sub

    '画面項目 表示
    Private Sub SetForm()

        'データ取得
        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.GrvList.Visible = False
            Me.BtnPrint1.Visible = False
            Me.BtnPrint2.Visible = False
            Me.BtnBack2.Visible = False
        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True
            Me.BtnPrint1.Visible = True
            Me.BtnPrint2.Visible = True
            Me.BtnBack2.Visible = True

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
        Joken.KIKAKU_TANTO_ROMA = Trim(Me.JokenKIKAKU_TANTO_ROMA.Text)
        Joken.TEHAI_TANTO_ROMA = Trim(Me.JokenTEHAI_TANTO_ROMA.Text)
        If Me.JokenSEIHIN_NAME.SelectedIndex <> 0 Then Joken.SEIHIN_NAME = Me.JokenSEIHIN_NAME.SelectedItem.ToString
        Joken.KOUENKAI_NO = Trim(Me.JokenKOUENKAI_NO.Text)
        Joken.KOUENKAI_NAME = Trim(Me.JokenKOUENKAI_NAME.Text)
        If Me.JokenBU.SelectedIndex <> 0 Then Joken.BU = Me.JokenBU.SelectedItem.ToString
        Joken.FROM_DATE = CmnModule.Format_DateToString(Me.JokenFROM_DATE_YYYY.Text, Me.JokenFROM_DATE_MM.Text, Me.JokenFROM_DATE_DD.Text)
        Joken.TO_DATE = CmnModule.Format_DateToString(Me.JokenTO_DATE_YYYY.Text, Me.JokenTO_DATE_MM.Text, Me.JokenTO_DATE_DD.Text)
        If Me.JokenKIKAKU_TANTO_AREA.SelectedIndex <> 0 Then Joken.AREA = Me.JokenKIKAKU_TANTO_AREA.SelectedItem.ToString
        If Me.JokenTTEHAI_TANTO.SelectedIndex <> 0 Then Joken.TTANTO_ID = Me.JokenTTEHAI_TANTO.SelectedValue

        'ReDim TBL_KOUENKAI(wCnt)
        'strSQL = SQL.TBL_KOUENKAI.Search(Joken, False)

        ReDim TBL_KOUENKAI_KEY(wCnt)
        strSQL = SQL.TBL_KOUENKAI.Search_KeyItem(Joken, False)

        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve TBL_KOUENKAI_KEY(wCnt)
            TBL_KOUENKAI_KEY(wCnt) = AppModule.SetRsData(RsData, TBL_KOUENKAI_KEY(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag
    End Function

    'グリッドビュー表示項目取得

    Private Function GetGridData(ByVal whereData As StringDictionary, ByRef GRID_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim SearchKey As TableDef.Joken.DataStruct

        SearchKey = Nothing
        SearchKey.KOUENKAI_NO = whereData(TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO)
        SearchKey.TIME_STAMP = whereData(TableDef.TBL_KOUENKAI.Column.TIME_STAMP)
        SearchKey.KOUENKAI_TITLE = whereData(TableDef.TBL_KOUENKAI.Column.KOUENKAI_TITLE)

        strSQL = SQL.TBL_KOUENKAI.byKEY(SearchKey)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True
            GRID_KOUENKAI = AppModule.SetRsData(RsData, GRID_KOUENKAI)

            Exit While
        End While
        RsData.Close()

        Return wFlag
    End Function


    '一覧 表示
    Private Sub DispList()

        'データ取得        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.GrvList.Visible = False
            Me.BtnPrint1.Visible = False
            Me.BtnPrint2.Visible = False

        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True
            Me.BtnPrint1.Visible = True
            Me.BtnPrint2.Visible = True

            'グリッドビュー表示
            SetGridView()
        End If
    End Sub

    'データソース設定
    Private Sub SetGridView()
        'データソース設定
        Dim strSQL As String = SQL.TBL_KOUENKAI.Search(Joken, False)
        Me.SqlDataSource1.ConnectionString = WebConfig.Db.ConnectionString
        Me.SqlDataSource1.SelectCommand = strSQL

        With Me.GrvList
            '.Columns.Item(CellIndex.BU).HeaderText = "BYL" & vbNewLine & "企画担当" & vbNewLine & "BU"
            '.Columns.Item(CellIndex.KIKAKU_TANTO_AREA).HeaderText = "BYL" & vbNewLine & "企画担当" & vbNewLine & "エリア"
            '.Columns.Item(CellIndex.KIKAKU_TANTO_AREA).HeaderText = "BYL" & vbNewLine & "企画担当" & vbNewLine & "営業所"
            '.Columns.Item(CellIndex.KIKAKU_TANTO_NAME).HeaderText = "BYL" & vbNewLine & "企画担当"

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
            Dim whereData As New StringDictionary
            whereData.Add(TableDef.TBL_KOUENKAI.Column.KOUENKAI_NO, e.Row.Cells(CellIndex.KOUENKAI_NO).Text)
            whereData.Add(TableDef.TBL_KOUENKAI.Column.TIME_STAMP, e.Row.Cells(CellIndex.TIME_STAMP2).Text)
            whereData.Add(TableDef.TBL_KOUENKAI.Column.KOUENKAI_TITLE, e.Row.Cells(CellIndex.KOUENKAI_TITLE).Text)

            Dim GRID_KOUENKAI As New TableDef.TBL_KOUENKAI.DataStruct
            If Not GetGridData(whereData, GRID_KOUENKAI) Then Exit Sub

            e.Row.Cells(CellIndex.BU).Text = GRID_KOUENKAI.BU
            e.Row.Cells(CellIndex.KIKAKU_TANTO_AREA).Text = GRID_KOUENKAI.KIKAKU_TANTO_AREA
            e.Row.Cells(CellIndex.KIKAKU_TANTO_EIGYOSHO).Text = GRID_KOUENKAI.KIKAKU_TANTO_EIGYOSHO
            e.Row.Cells(CellIndex.KIKAKU_TANTO_NAME).Text = GRID_KOUENKAI.KIKAKU_TANTO_NAME
            'e.Row.Cells(CellIndex.USER_NAME).Text = GRID_KOUENKAI.TEHAI_TANTO_NAME

            e.Row.Cells(CellIndex.FROM_DATE).Text = AppModule.GetName_KOUENKAI_DATE(GRID_KOUENKAI.FROM_DATE, GRID_KOUENKAI.TO_DATE, True)
            e.Row.Cells(CellIndex.TIME_STAMP_BYL).Text = AppModule.GetName_TIME_STAMP_BYL(e.Row.Cells(CellIndex.TIME_STAMP_BYL).Text)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            Me.GrvList.BorderStyle = BorderStyle.NotSet
            e.Row.Cells(CellIndex.TO_DATE).Visible = False
            e.Row.Cells(CellIndex.TIME_STAMP2).Visible = False
            e.Row.Cells(CellIndex.KOUENKAI_TITLE).Visible = False
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
                Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
                Session.Item(SessionDef.PageIndex) = Me.GrvList.PageIndex
                Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
                Session.Item(SessionDef.BackURL2) = Request.Url.AbsolutePath

                '@@@ Phase2
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                Dim row As GridViewRow = GrvList.Rows(index)
                Session.Item(SessionDef.KOUENKAI_NO) = DirectCast(GrvList.Rows(index).Controls(CellIndex.KOUENKAI_NO), DataControlFieldCell).Text()
                Session.Item(SessionDef.TIME_STAMP) = DirectCast(GrvList.Rows(index).Controls(CellIndex.TIME_STAMP2), DataControlFieldCell).Text()
                Session.Item(SessionDef.KOUENKAI_TITLE) = DirectCast(GrvList.Rows(index).Controls(CellIndex.KOUENKAI_TITLE), DataControlFieldCell).Text()
                Session.Item(SessionDef.KOUENKAI_NAME) = DirectCast(GrvList.Rows(index).Controls(CellIndex.KOUENKAI_NAME), DataControlFieldCell).Text()

                '履歴画面用セッション変数をクリア
                Session.Remove(SessionDef.KaijoRireki)
                Session.Remove(SessionDef.KouenkaiRireki_PageIndex)
                Session.Remove(SessionDef.KouenkaiRireki_SEQ)
                Session.Item(SessionDef.KouenkaiRireki_TBL_KOUENKAI) = False

                Response.Redirect(URL.KouenkaiRegist)
        End Select
    End Sub

    '[検索]
    Private Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        '入力チェック
        If Not Check() Then Exit Sub

        '一覧 表示
        SetForm()

    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsAlphabetOnly(Me.JokenKIKAKU_TANTO_ROMA) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphabetOnly("BYL企画担当者(ローマ字)"), Me)
            Return False
        End If

        If Not CmnCheck.IsAlphabetOnly(Me.JokenTEHAI_TANTO_ROMA) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphabetOnly("BYL手配担当者(ローマ字)"), Me)
            Return False
        End If

        If Not CmnCheck.IsAlphanumericHyphen(Me.JokenKOUENKAI_NO) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphanumericHyphenOnly("会合番号"), Me)
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

        Joken = Nothing
        Joken.KIKAKU_TANTO_ROMA = Trim(Me.JokenKIKAKU_TANTO_ROMA.Text)
        Joken.TEHAI_TANTO_ROMA = Trim(Me.JokenTEHAI_TANTO_ROMA.Text)
        If Me.JokenSEIHIN_NAME.SelectedIndex <> 0 Then
            Joken.SEIHIN_NAME = Me.JokenSEIHIN_NAME.SelectedItem.ToString
        Else
            Joken.SEIHIN_NAME = ""
        End If
        Joken.KOUENKAI_NO = Trim(Me.JokenKOUENKAI_NO.Text)
        Joken.KOUENKAI_NAME = Trim(Me.JokenKOUENKAI_NAME.Text)
        If Me.JokenBU.SelectedIndex <> 0 Then
            Joken.BU = Me.JokenBU.SelectedItem.ToString
        Else
            Joken.BU = ""
        End If
        Joken.FROM_DATE = CmnModule.Format_DateToString(Me.JokenFROM_DATE_YYYY.Text, Me.JokenFROM_DATE_MM.Text, Me.JokenFROM_DATE_DD.Text)
        Joken.TO_DATE = CmnModule.Format_DateToString(Me.JokenTO_DATE_YYYY.Text, Me.JokenTO_DATE_MM.Text, Me.JokenTO_DATE_DD.Text)
        If Me.JokenKIKAKU_TANTO_AREA.SelectedIndex <> 0 Then
            Joken.AREA = Me.JokenKIKAKU_TANTO_AREA.SelectedItem.ToString
        Else
            Joken.AREA = ""
        End If
        If Me.JokenTTEHAI_TANTO.SelectedIndex <> 0 Then
            Joken.TTANTO_ID = Me.JokenTTEHAI_TANTO.SelectedValue
        Else
            Joken.TTANTO_ID = ""
        End If

        strSQL = SQL.TBL_KOUENKAI.Search(Joken, False)

        'ページヘッダに出力する抽出条件セット
        If Joken.KIKAKU_TANTO_ROMA.Trim = "" Then Joken.KIKAKU_TANTO_ROMA = "指定なし"
        If Joken.TEHAI_TANTO_ROMA.Trim = "" Then Joken.TEHAI_TANTO_ROMA = "指定なし"
        If Joken.SEIHIN_NAME.Trim = "" Then Joken.SEIHIN_NAME = "指定なし"
        If Joken.KOUENKAI_NO.Trim = "" Then Joken.KOUENKAI_NO = "指定なし"
        If Joken.KOUENKAI_NAME.Trim = "" Then Joken.KOUENKAI_NAME = "指定なし"
        If Joken.FROM_DATE.Trim = "" And Joken.TO_DATE.Trim = "" Then Joken.FROM_DATE = "指定なし"
        If Joken.BU.Trim = "" Then Joken.BU = "指定なし"
        If Joken.AREA.Trim = "" Then Joken.AREA = "指定なし"
        If Joken.TTANTO_ID.Trim = "" Then Joken.TTANTO_ID = "指定なし"

        Session.Item(SessionDef.KouenkaiPrint_SQL) = strSQL
        Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Session.Item(SessionDef.Joken) = Joken
        Response.Redirect(URL.Preview)
    End Sub

    '[印刷]
    Private Sub BtnPrint2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint2.Click
        BtnPrint1_Click(sender, e)
    End Sub
End Class