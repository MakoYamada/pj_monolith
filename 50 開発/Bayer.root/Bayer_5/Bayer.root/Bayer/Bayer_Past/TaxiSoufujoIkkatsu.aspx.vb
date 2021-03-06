﻿Imports CommonLib
Imports AppLib
Imports System.IO

Partial Public Class TaxiSoufujoIkkatsu
    Inherits WebBase

    Private TBL_TAXITICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
    Private TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列    Private Enum CellIndex
        KOUENKAI_NO
        KOUENKAI_NAME
        JISSHI_DATE
        SANKASHA_ID
        DR_NAME
        IMPORT_DATE
        SALESFORCE_ID
        TIME_STAMP_BYL
        DR_MPID
    End Enum

    Private Sub DrList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_TAXITICKET_HAKKO) = TBL_TAXITICKET_HAKKO
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

        'セッションを変数に格納        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()

            Me.LabelNoData.Visible = False
            Me.LabelCountTitle.Visible = False
            Me.LabelCount.Visible = False
            Me.GrvList.Visible = False
            Me.BtnSoufujo1.Visible = False
            Me.BtnSoufujo2.Visible = False
            Me.BtnKakuninhyo1.Visible = False
            Me.BtnKakuninhyo2.Visible = False
            Me.BtnBack2.Visible = False

            SetJoken()
            If Me.JokenFROM_DATE_YYYY.Text.Trim <> "" OrElse Me.JokenTO_DATE_YYYY.Text.Trim <> "" Then
                DispList()
            End If
        End If

        'マスターページ設定
        With Me.Master
            .DispTaxiMenu = True
            .PageTitle = "手配書・確認票一括印刷"
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
            TBL_TAXITICKET_HAKKO = Session.Item(SessionDef.TBL_TAXITICKET_HAKKO)
            If TBL_TAXITICKET_HAKKO Is Nothing Then ReDim TBL_TAXITICKET_HAKKO(0)
        Catch ex As Exception
            ReDim TBL_TAXITICKET_HAKKO(0)
        End Try
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()

        'IME設定        CmnModule.SetIme(Me.JokenFROM_DATE_YYYY, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenFROM_DATE_MM, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenFROM_DATE_DD, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenTO_DATE_YYYY, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenTO_DATE_MM, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenTO_DATE_DD, CmnModule.ImeType.InActive)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    'データ取得
    Private Function GetData() As Boolean
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        Joken = Nothing
        Joken.FROM_DATE = CmnModule.Format_DateToString(Me.JokenFROM_DATE_YYYY.Text, Me.JokenFROM_DATE_MM.Text, Me.JokenFROM_DATE_DD.Text)
        Joken.TO_DATE = CmnModule.Format_DateToString(Me.JokenTO_DATE_YYYY.Text, Me.JokenTO_DATE_MM.Text, Me.JokenTO_DATE_DD.Text)
        Joken.KOUENKAI_NO = Me.JokenKOUENKAI_NO.Text.Trim

        ReDim TBL_KOTSUHOTEL(wCnt)

        strSQL = SQL.TBL_KOTSUHOTEL.Soufujo_Disp(Joken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve TBL_KOTSUHOTEL(wCnt)
            TBL_KOTSUHOTEL(wCnt) = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL(wCnt))

            wCnt += 1
        End While
        RsData.Close()
        Me.LabelCount.Text = wCnt.ToString & " 件"
        Return wFlag
    End Function

    'グリッドビュー表示項目取得

    Private Function GetGridData(ByVal whereData As StringDictionary, ByRef GRID_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim SearchKey As TableDef.Joken.DataStruct

        SearchKey = Nothing
        SearchKey.SALESFORCE_ID = whereData(TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID)
        SearchKey.KOUENKAI_NO = whereData(TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO)
        SearchKey.SANKASHA_ID = whereData(TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID)
        SearchKey.TIME_STAMP_BYL = whereData(TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL)
        SearchKey.DR_MPID = whereData(TableDef.TBL_KOTSUHOTEL.Column.DR_MPID)

        strSQL = SQL.TBL_KOTSUHOTEL.byKEY(SearchKey)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True
            GRID_KOTSUHOTEL = AppModule.SetRsData(RsData, GRID_KOTSUHOTEL)

            Exit While
        End While
        RsData.Close()

        Return wFlag
    End Function

    '一覧 表示
    Private Sub DispList()

        'データ取得        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.LabelCountTitle.Visible = False
            Me.LabelCount.Visible = False
            Me.GrvList.Visible = False
            Me.BtnSoufujo1.Visible = False
            Me.BtnSoufujo2.Visible = False
            Me.BtnKakuninhyo1.Visible = False
            Me.BtnKakuninhyo2.Visible = False

        Else
            Me.LabelNoData.Visible = False
            Me.LabelCountTitle.Visible = True
            Me.LabelCount.Visible = True
            Me.GrvList.Visible = True
            Me.BtnSoufujo1.Visible = True
            Me.BtnSoufujo2.Visible = True
            Me.BtnKakuninhyo1.Visible = True
            Me.BtnKakuninhyo2.Visible = True
            Me.BtnBack2.Visible = True

            'グリッドビュー表示
            SetGridView()
        End If
    End Sub

    'データソース設定
    Private Sub SetGridView()
        'データソース設定
        Dim strSQL As String = SQL.TBL_KOTSUHOTEL.Soufujo(Joken)
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
            Dim whereData As New StringDictionary
            whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID, e.Row.Cells(CellIndex.SALESFORCE_ID).Text)
            whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO, e.Row.Cells(CellIndex.KOUENKAI_NO).Text)
            whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID, e.Row.Cells(CellIndex.SANKASHA_ID).Text)
            whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL, e.Row.Cells(CellIndex.TIME_STAMP_BYL).Text)
            whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.DR_MPID, e.Row.Cells(CellIndex.DR_MPID).Text)

            Dim GRID_KOTSUHOTEL As New TableDef.TBL_KOTSUHOTEL.DataStruct
            If Not GetGridData(whereData, GRID_KOTSUHOTEL) Then Exit Sub
            e.Row.Cells(CellIndex.JISSHI_DATE).Text = AppModule.GetName_KOUENKAI_DATE(GRID_KOTSUHOTEL.FROM_DATE, GRID_KOTSUHOTEL.TO_DATE, True)
            e.Row.Cells(CellIndex.KOUENKAI_NAME).Text = GRID_KOTSUHOTEL.KOUENKAI_NAME
            e.Row.Cells(CellIndex.DR_NAME).Text = GRID_KOTSUHOTEL.DR_NAME
            e.Row.Cells(CellIndex.IMPORT_DATE).Text = CmnModule.Format_Date(GRID_KOTSUHOTEL.SCAN_IMPORT_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            Me.GrvList.BorderStyle = BorderStyle.NotSet
            '@@@ Phase2
            e.Row.Cells(CellIndex.SALESFORCE_ID).Visible = False
            e.Row.Cells(CellIndex.TIME_STAMP_BYL).Visible = False
            e.Row.Cells(CellIndex.DR_MPID).Visible = False
            e.Row.Cells(CellIndex.IMPORT_DATE).Visible = False
            'e.Row.Cells(CellIndex.FROM_DATE).Visible = False
            'e.Row.Cells(CellIndex.TO_DATE).Visible = False
            '@@@ Phase2
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

    '[検索]
    Private Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Me.GrvList.Visible = False

        '入力チェック
        If Not Check() Then Exit Sub

        '一覧 表示
        DispList()

    End Sub

    '[戻る]
    Private Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click, BtnBack2.Click
        Response.Redirect(URL.TaxiMenu)
    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("スキャンデータ取込日From(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("スキャンデータ取込日From(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_DD) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("スキャンデータ取込日From(日)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.JokenFROM_DATE_YYYY) OrElse CmnCheck.IsInput(Me.JokenFROM_DATE_MM) OrElse CmnCheck.IsInput(Me.JokenFROM_DATE_DD) Then
            Dim wStr As String = StrConv(Trim(Me.JokenFROM_DATE_YYYY.Text) & "/" & Trim(Me.JokenFROM_DATE_MM.Text) & "/" & Trim(Me.JokenFROM_DATE_DD.Text), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("スキャンデータ取込日From"), Me)
                Return False
            End If
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("スキャンデータ取込日To(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("スキャンデータ取込日To(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_DD) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("スキャンデータ取込日To(日)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.JokenTO_DATE_YYYY) OrElse CmnCheck.IsInput(Me.JokenTO_DATE_MM) OrElse CmnCheck.IsInput(Me.JokenTO_DATE_DD) Then
            Dim wStr As String = StrConv(Trim(Me.JokenTO_DATE_YYYY.Text) & "/" & Trim(Me.JokenTO_DATE_MM.Text) & "/" & Trim(Me.JokenTO_DATE_DD.Text), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("スキャンデータ取込日To"), Me)
                Return False
            End If
        End If

        If Not CmnCheck.IsInput(Me.JokenFROM_DATE_YYYY) AndAlso Not CmnCheck.IsInput(Me.JokenTO_DATE_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("スキャンデータ取込日From・Toの何れか"), Me)
            Return False
        End If

        Return True
    End Function

    '[送付状印刷]
    Private Sub BtnSoufujo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSoufujo1.Click, BtnSoufujo2.Click
        Dim strSQL As String = ""

        Joken = Nothing
        Joken.FROM_DATE = CmnModule.Format_DateToString(Me.JokenFROM_DATE_YYYY.Text, Me.JokenFROM_DATE_MM.Text, Me.JokenFROM_DATE_DD.Text)
        Joken.TO_DATE = CmnModule.Format_DateToString(Me.JokenTO_DATE_YYYY.Text, Me.JokenTO_DATE_MM.Text, Me.JokenTO_DATE_DD.Text)
        Joken.KOUENKAI_NO = Me.JokenKOUENKAI_NO.Text.Trim
        strSQL = SQL.TBL_KOTSUHOTEL.Soufujo(Joken)

        Session.Item(SessionDef.TehaishoPrint_SQL) = strSQL
        Session.Item(SessionDef.PrintPreview) = "Soufujo"
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Response.Redirect(URL.Preview)
    End Sub

    '[タクチケ手配確認票印刷]
    Private Sub BtnKakuninhyo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnKakuninhyo1.Click, BtnKakuninhyo2.Click
        Dim strSQL As String = ""

        Joken = Nothing
        Joken.FROM_DATE = CmnModule.Format_DateToString(Me.JokenFROM_DATE_YYYY.Text, Me.JokenFROM_DATE_MM.Text, Me.JokenFROM_DATE_DD.Text)
        Joken.TO_DATE = CmnModule.Format_DateToString(Me.JokenTO_DATE_YYYY.Text, Me.JokenTO_DATE_MM.Text, Me.JokenTO_DATE_DD.Text)
        Joken.KOUENKAI_NO = Me.JokenKOUENKAI_NO.Text.Trim
        strSQL = SQL.TBL_KOTSUHOTEL.Soufujo(Joken)

        Session.Item(SessionDef.TehaishoPrint_SQL) = strSQL
        Session.Item(SessionDef.PrintPreview) = "TaxiKakuninhyo"
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Response.Redirect(URL.Preview)
    End Sub

    Private Sub SetJoken()
        If Joken.FROM_DATE <> Nothing AndAlso Joken.FROM_DATE.Trim <> "" Then
            Me.JokenFROM_DATE_YYYY.Text = Joken.FROM_DATE.Substring(0, 4)
            Me.JokenFROM_DATE_MM.Text = Joken.FROM_DATE.Substring(4, 2)
            Me.JokenFROM_DATE_DD.Text = Joken.FROM_DATE.Substring(6, 2)
        End If
        If Joken.TO_DATE <> Nothing AndAlso Joken.TO_DATE.Trim <> "" Then
            Me.JokenTO_DATE_YYYY.Text = Joken.TO_DATE.Substring(0, 4)
            Me.JokenTO_DATE_MM.Text = Joken.TO_DATE.Substring(4, 2)
            Me.JokenTO_DATE_DD.Text = Joken.TO_DATE.Substring(6, 2)
        End If
        If Joken.KOUENKAI_NO <> Nothing AndAlso Joken.KOUENKAI_NO.Trim <> "" Then
            Me.JokenKOUENKAI_NO.Text = Joken.KOUENKAI_NO
        End If
    End Sub
End Class