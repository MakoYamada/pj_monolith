Imports CommonLib
Imports AppLib
Imports System.IO

Partial Public Class TaxiMiketsu
    Inherits WebBase

    Private TBL_TAXITICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列    Private Enum CellIndex
        JISSHI_DATE
        KOUENKAI_NAME
        DR_NAME
        USER_NAME
        TKT_NO
        TKT_KENSHU
        ANS_TAXI_DATE
        ANS_TAXI_HAKKO_DATE
        ANS_TAXI_RMKS
        TKT_USED_DATE
        TKT_SEIKYU_YM
        VOID_DATE
        TKT_LINE_NO
        BUTTON
        KOUENKAI_NO
        SANKASHA_ID
        FROM_DATE
        TO_DATE
        TKT_VOID
        UPDATE_DATE
        ANS_TAXI_DATE_1
        ANS_TAXI_KENSHU_1
        ANS_TAXI_NO_1
        ANS_TAXI_HAKKO_1
        ANS_TAXI_HAKKO_DATE_1
        ANS_TAXI_RMKS_1
        ANS_TAXI_DATE_2
        ANS_TAXI_KENSHU_2
        ANS_TAXI_NO_2
        ANS_TAXI_HAKKO_2
        ANS_TAXI_HAKKO_DATE_2
        ANS_TAXI_RMKS_2
        ANS_TAXI_DATE_3
        ANS_TAXI_KENSHU_3
        ANS_TAXI_NO_3
        ANS_TAXI_HAKKO_3
        ANS_TAXI_HAKKO_DATE_3
        ANS_TAXI_RMKS_3
        ANS_TAXI_DATE_4
        ANS_TAXI_KENSHU_4
        ANS_TAXI_NO_4
        ANS_TAXI_HAKKO_4
        ANS_TAXI_HAKKO_DATE_4
        ANS_TAXI_RMKS_4
        ANS_TAXI_DATE_5
        ANS_TAXI_KENSHU_5
        ANS_TAXI_NO_5
        ANS_TAXI_HAKKO_5
        ANS_TAXI_HAKKO_DATE_5
        ANS_TAXI_RMKS_5
        ANS_TAXI_DATE_6
        ANS_TAXI_KENSHU_6
        ANS_TAXI_NO_6
        ANS_TAXI_HAKKO_6
        ANS_TAXI_HAKKO_DATE_6
        ANS_TAXI_RMKS_6
        ANS_TAXI_DATE_7
        ANS_TAXI_KENSHU_7
        ANS_TAXI_NO_7
        ANS_TAXI_HAKKO_7
        ANS_TAXI_HAKKO_DATE_7
        ANS_TAXI_RMKS_7
        ANS_TAXI_DATE_8
        ANS_TAXI_KENSHU_8
        ANS_TAXI_NO_8
        ANS_TAXI_HAKKO_8
        ANS_TAXI_HAKKO_DATE_8
        ANS_TAXI_RMKS_8
        ANS_TAXI_DATE_9
        ANS_TAXI_KENSHU_9
        ANS_TAXI_NO_9
        ANS_TAXI_HAKKO_9
        ANS_TAXI_HAKKO_DATE_9
        ANS_TAXI_RMKS_9
        ANS_TAXI_DATE_10
        ANS_TAXI_KENSHU_10
        ANS_TAXI_NO_10
        ANS_TAXI_HAKKO_10
        ANS_TAXI_HAKKO_DATE_10
        ANS_TAXI_RMKS_10
        ANS_TAXI_DATE_11
        ANS_TAXI_KENSHU_11
        ANS_TAXI_NO_11
        ANS_TAXI_HAKKO_11
        ANS_TAXI_HAKKO_DATE_11
        ANS_TAXI_RMKS_11
        ANS_TAXI_DATE_12
        ANS_TAXI_KENSHU_12
        ANS_TAXI_NO_12
        ANS_TAXI_HAKKO_12
        ANS_TAXI_HAKKO_DATE_12
        ANS_TAXI_RMKS_12
        ANS_TAXI_DATE_13
        ANS_TAXI_KENSHU_13
        ANS_TAXI_NO_13
        ANS_TAXI_HAKKO_13
        ANS_TAXI_HAKKO_DATE_13
        ANS_TAXI_RMKS_13
        ANS_TAXI_DATE_14
        ANS_TAXI_KENSHU_14
        ANS_TAXI_NO_14
        ANS_TAXI_HAKKO_14
        ANS_TAXI_HAKKO_DATE_14
        ANS_TAXI_RMKS_14
        ANS_TAXI_DATE_15
        ANS_TAXI_KENSHU_15
        ANS_TAXI_NO_15
        ANS_TAXI_HAKKO_15
        ANS_TAXI_HAKKO_DATE_15
        ANS_TAXI_RMKS_15
        ANS_TAXI_DATE_16
        ANS_TAXI_KENSHU_16
        ANS_TAXI_NO_16
        ANS_TAXI_HAKKO_16
        ANS_TAXI_HAKKO_DATE_16
        ANS_TAXI_RMKS_16
        ANS_TAXI_DATE_17
        ANS_TAXI_KENSHU_17
        ANS_TAXI_NO_17
        ANS_TAXI_HAKKO_17
        ANS_TAXI_HAKKO_DATE_17
        ANS_TAXI_RMKS_17
        ANS_TAXI_DATE_18
        ANS_TAXI_KENSHU_18
        ANS_TAXI_NO_18
        ANS_TAXI_HAKKO_18
        ANS_TAXI_HAKKO_DATE_18
        ANS_TAXI_RMKS_18
        ANS_TAXI_DATE_19
        ANS_TAXI_KENSHU_19
        ANS_TAXI_NO_19
        ANS_TAXI_HAKKO_19
        ANS_TAXI_HAKKO_DATE_19
        ANS_TAXI_RMKS_19
        ANS_TAXI_DATE_20
        ANS_TAXI_KENSHU_20
        ANS_TAXI_NO_20
        ANS_TAXI_HAKKO_20
        ANS_TAXI_HAKKO_DATE_20
        ANS_TAXI_RMKS_20
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

            '画面項目表示
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .DispTaxiMenu = True
            .PageTitle = "未決一覧"
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

        'IME設定        CmnModule.SetIme(Me.JokenKOUENKAI_NO, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenKOUENKAI_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.JokenFROM_DATE_YYYY, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenFROM_DATE_MM, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenFROM_DATE_DD, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenTO_DATE_YYYY, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenTO_DATE_MM, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenTO_DATE_DD, CmnModule.ImeType.InActive)

        'クリア
        CmnModule.ClearAllControl(Me)

        'ドロップダウンリスト設定
        AppModule.SetDropDownList_USER_NAME(Me.JokenTTEHAI_TANTO, DbConnection)
    End Sub

    '画面項目 表示
    Private Sub SetForm()

        'データ取得
        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.GrvList.Visible = False
            CmnModule.SetEnabled(Me.BtnCsv1, False)
            CmnModule.SetEnabled(Me.BtnCsv2, False)
        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True
            CmnModule.SetEnabled(Me.BtnCsv1, True)
            CmnModule.SetEnabled(Me.BtnCsv2, True)

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
        Joken.KOUENKAI_NAME = Trim(Me.JokenKOUENKAI_NAME.Text)
        Joken.FROM_DATE = CmnModule.Format_DateToString(Me.JokenFROM_DATE_YYYY.Text, Me.JokenFROM_DATE_MM.Text, Me.JokenFROM_DATE_DD.Text)
        Joken.TO_DATE = CmnModule.Format_DateToString(Me.JokenTO_DATE_YYYY.Text, Me.JokenTO_DATE_MM.Text, Me.JokenTO_DATE_DD.Text)
        If Me.JokenTTEHAI_TANTO.SelectedIndex <> 0 Then Joken.TTANTO_ID = Me.JokenTTEHAI_TANTO.SelectedValue

        ReDim TBL_TAXITICKET_HAKKO(wCnt)

        strSQL = SQL.TBL_TAXITICKET_HAKKO.Search(Joken, True)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve TBL_TAXITICKET_HAKKO(wCnt)
            TBL_TAXITICKET_HAKKO(wCnt) = AppModule.SetRsData(RsData, TBL_TAXITICKET_HAKKO(wCnt))

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
            Me.BtnCsv1.Visible = False
            Me.BtnCsv2.Visible = False

        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True
            Me.BtnCsv1.Visible = True
            Me.BtnCsv2.Visible = True

            'グリッドビュー表示
            SetGridView()
        End If
    End Sub

    'データソース設定
    Private Sub SetGridView()
        'データソース設定
        Dim strSQL As String = SQL.TBL_TAXITICKET_HAKKO.Search(Joken, True)
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

            e.Row.Cells(CellIndex.JISSHI_DATE).Text = AppModule.GetName_KOUENKAI_DATE(e.Row.Cells(CellIndex.FROM_DATE).Text, e.Row.Cells(CellIndex.TO_DATE).Text, True)
            Select Case Val(e.Row.Cells(CellIndex.TKT_LINE_NO).Text)
                Case 1
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_1).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_1).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_1).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 2
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_2).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_2).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_2).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 3
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_3).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_3).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_3).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 4
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_4).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_4).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_4).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 5
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_5).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_5).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_5).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 6
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_6).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_6).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_6).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 7
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_7).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_7).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_7).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 8
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_8).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_8).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_8).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 9
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_9).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_9).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_9).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 10
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_10).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_10).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_10).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 11
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_11).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_11).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_11).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 12
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_12).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_12).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_12).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 13
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_13).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_13).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_13).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 14
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_14).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_14).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_14).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 15
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_15).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_15).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_15).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 16
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_16).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_16).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_16).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 17
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_17).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_17).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_17).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 18
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_18).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_18).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_18).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 19
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_19).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_19).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_19).Text, CmnModule.DateFormatType.YYYYMMDD)
                Case 20
                    e.Row.Cells(CellIndex.ANS_TAXI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_DATE_20).Text, CmnModule.DateFormatType.YYYYMMDD)
                    e.Row.Cells(CellIndex.ANS_TAXI_RMKS).Text = e.Row.Cells(CellIndex.ANS_TAXI_RMKS_20).Text
                    e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_20).Text, CmnModule.DateFormatType.YYYYMMDD)
            End Select
            e.Row.Cells(CellIndex.TKT_USED_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.TKT_USED_DATE).Text, CmnModule.DateFormatType.YYYYMMDD)
            If e.Row.Cells(CellIndex.TKT_SEIKYU_YM).Text.Trim <> "" AndAlso e.Row.Cells(CellIndex.TKT_SEIKYU_YM).Text.Trim <> "&nbsp;" Then
                e.Row.Cells(CellIndex.TKT_SEIKYU_YM).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.TKT_SEIKYU_YM).Text & "01", CmnModule.DateFormatType.YYYYMMDD).Substring(0, 7)
            End If
            If e.Row.Cells(CellIndex.TKT_VOID).Text = CmnConst.Flag.On Then
                e.Row.Cells(CellIndex.VOID_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.UPDATE_DATE).Text.Substring(0, 8), CmnModule.DateFormatType.YYYYMMDD)
            Else
                e.Row.Cells(CellIndex.VOID_DATE).Text = ""
            End If
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.KOUENKAI_NO).Visible = False
            e.Row.Cells(CellIndex.SANKASHA_ID).Visible = False
            e.Row.Cells(CellIndex.FROM_DATE).Visible = False
            e.Row.Cells(CellIndex.TO_DATE).Visible = False
            e.Row.Cells(CellIndex.TKT_VOID).Visible = False
            e.Row.Cells(CellIndex.UPDATE_DATE).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_1).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_1).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_1).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_1).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_1).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_1).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_2).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_2).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_2).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_2).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_2).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_2).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_3).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_3).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_3).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_3).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_3).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_3).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_4).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_4).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_4).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_4).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_4).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_4).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_5).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_5).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_5).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_5).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_5).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_5).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_6).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_6).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_6).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_6).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_6).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_6).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_7).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_7).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_7).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_7).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_7).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_7).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_8).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_8).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_8).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_8).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_8).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_8).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_9).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_9).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_9).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_9).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_9).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_9).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_10).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_10).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_10).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_10).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_10).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_10).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_11).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_11).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_11).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_11).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_11).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_11).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_12).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_12).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_12).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_12).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_12).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_12).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_13).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_13).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_13).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_13).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_13).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_13).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_14).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_14).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_14).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_14).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_14).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_14).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_15).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_15).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_15).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_15).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_15).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_15).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_16).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_16).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_16).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_16).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_16).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_16).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_17).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_17).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_17).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_17).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_17).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_17).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_18).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_18).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_18).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_18).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_18).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_18).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_19).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_19).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_19).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_19).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_19).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_19).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_DATE_20).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_KENSHU_20).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_NO_20).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_20).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_HAKKO_DATE_20).Visible = False
            e.Row.Cells(CellIndex.ANS_TAXI_RMKS_20).Visible = False
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
                Session.Item(SessionDef.TBL_TAXITICKET_HAKKO) = TBL_TAXITICKET_HAKKO
                Session.Item(SessionDef.PageIndex) = Me.GrvList.PageIndex
                Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
                Session.Item(SessionDef.BackURL2) = Request.Url.AbsolutePath

                Response.Redirect(URL.TaxiMiketsuRegist)
        End Select
    End Sub

    '[検索]
    Private Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
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

        If Not CmnCheck.IsAlphanumericHyphen(Me.JokenKOUENKAI_NO) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphanumericHyphenOnly("会合番号"), Me)
            Return False
        End If

        Return True
    End Function

    Private Sub BtnCsv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCsv1.Click, BtnCsv2.Click
        '入力チェック
        If Not Check() Then Exit Sub

        If GetData() Then
            'CSV出力
            Response.Clear()
            Response.ContentType = CmnConst.Csv.ContentType
            Response.Charset = CmnConst.Csv.Charset
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & "TaxiMiketsu.csv")
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-JIS")

            Response.Write(MyModule.Csv.TaxiMiketsu(TBL_TAXITICKET_HAKKO))
            Response.End()
        End If
    End Sub
End Class