Imports CommonLib
Imports AppLib

Partial Public Class NewDrList
    Inherits WebBase

    Private TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private TBL_KOTSUHOTEL_KEY() As TableDef.TBL_KOTSUHOTEL_KEY.DataStruct
    Private Joken As TableDef.Joken.DataStruct
    Private grv_selected() As String

    'グリッド列    Private Enum CellIndex
        CHK_PRINT
        JISSHI_DATE
        KOUENKAI_NO
        KOUENKAI_NAME
        SANKASHA_ID
        DR_NAME
        MR_NAME
        TIME_STAMP
        INPUT_DATE
        USER_NAME
        KUBUN
        REQ_HOTEL
        REQ_KOTSU
        REQ_TAXI
        REQ_MR
        REQ_EMERGENCY
        Button1
        SALESFORCE_ID
        TIME_STAMP_BYL
        DR_MPID
        'TO_DATE
        'REQ_O_TEHAI_1
        'REQ_O_TEHAI_2
        'REQ_O_TEHAI_3
        'REQ_O_TEHAI_4
        'REQ_O_TEHAI_5
        'REQ_F_TEHAI_1
        'REQ_F_TEHAI_2
        'REQ_F_TEHAI_3
        'REQ_F_TEHAI_4
        'REQ_F_TEHAI_5
        'REQ_MR_O_TEHAI
        'REQ_MR_F_TEHAI
        'REQ_MR_HOTEL_NOTE
    End Enum

    Private Sub DrList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_KOTSUHOTEL) = TBL_KOTSUHOTEL
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

            '@@@ Phase2
            'If UBound(TBL_KOTSUHOTEL) = 0 And TBL_KOTSUHOTEL(0).SALEFORCE_ID Is Nothing Then
            If Session.Item(SessionDef.SALESFORCE_ID) Is Nothing Then
                SetForm()
            Else
                SetJoken()
                SetForm()
            End If
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "【新着】交通・宿泊手配依頼"
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

        'IME設定        CmnModule.SetIme(Me.JokenKOUENKAI_NO, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenKOUENKAI_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.JokenKIKAKU_TANTO_ROMA, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenTEHAI_TANTO_ROMA, CmnModule.ImeType.InActive)

        'クリア
        CmnModule.ClearAllControl(Me)
        AppModule.SetDropDownList_KUBUN(Me.JokenKUBUN, True)

        Me.LabelNoData.Visible = False
        Me.LabelCountTitle.Visible = True
        Me.LabelCount.Visible = True
        Me.BtnPrint1.Visible = False
        Me.BtnPrint2.Visible = False
        Me.BtnIchiranPrint1.Visible = False
        Me.BtnIchiranPrint2.Visible = False
        Me.BtnBack2.Visible = False
        Me.lnkCheck.Visible = False
        Me.lnkNoCheck.Visible = False
    End Sub

    '抽出条件セット
    Private Sub SetJoken()
        If Joken.BU <> "" AndAlso Joken.BU <> "指定なし" Then Me.JokenBU.Text = Joken.BU
        If Joken.KIKAKU_TANTO_ROMA <> "" AndAlso Joken.KIKAKU_TANTO_ROMA <> "指定なし" Then Me.JokenTEHAI_TANTO_AREA.Text = Joken.KIKAKU_TANTO_ROMA
        If Joken.KOUENKAI_NO <> "" AndAlso Joken.KOUENKAI_NO <> "指定なし" Then Me.JokenKOUENKAI_NO.Text = Joken.KOUENKAI_NO
        If Joken.KOUENKAI_NAME <> "" AndAlso Joken.KOUENKAI_NAME <> "指定なし" Then Me.JokenKOUENKAI_NAME.Text = Joken.KOUENKAI_NAME
        If Joken.TEHAI_TANTO_ROMA <> "" AndAlso Joken.TEHAI_TANTO_ROMA <> "指定なし" Then Me.JokenTEHAI_TANTO_ROMA.Text = Joken.KOUENKAI_NAME
        If Joken.KUBUN <> "" AndAlso Joken.KUBUN <> "指定なし" Then Me.JokenKUBUN.SelectedValue = Joken.KUBUN
        If Joken.TTANTO_ID <> "" AndAlso Joken.TTANTO_ID <> "指定なし" Then Me.JokenTTEHAI_TANTO.SelectedValue = Joken.TTANTO_ID
        If Joken.TTEHAI_MITOUROKU <> "0" AndAlso Joken.TTEHAI_MITOUROKU <> "指定なし" AndAlso Joken.TTEHAI_MITOUROKU <> Nothing Then Me.ChkTTEHAI_TANTO.Checked = True
    End Sub

    '画面項目 表示
    Private Sub SetForm()

        'データ取得
        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.LabelCountTitle.Visible = False
            Me.LabelCount.Visible = False
            Me.GrvList.Visible = False
            Me.BtnBack2.Visible = False
            Me.BtnPrint1.Visible = False
            Me.BtnPrint2.Visible = False
            Me.BtnIchiranPrint1.Visible = False
            Me.BtnIchiranPrint2.Visible = False
        Else
            Me.LabelNoData.Visible = False
            Me.LabelCountTitle.Visible = True
            Me.LabelCount.Visible = True
            Me.GrvList.Visible = True
            Me.BtnBack1.Visible = True
            Me.BtnBack2.Visible = True
            Me.BtnPrint1.Visible = True
            Me.BtnPrint2.Visible = True
            Me.BtnIchiranPrint1.Visible = True
            Me.BtnIchiranPrint2.Visible = True
            Me.lnkCheck.Visible = True
            Me.lnkNoCheck.Visible = True

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

        Joken = Nothing
        If Me.JokenBU.SelectedIndex <> 0 Then Joken.BU = Me.JokenBU.SelectedItem.ToString
        If Me.JokenTEHAI_TANTO_AREA.SelectedIndex <> 0 Then Joken.AREA = JokenTEHAI_TANTO_AREA.SelectedItem.ToString
        Joken.KOUENKAI_NO = Trim(Me.JokenKOUENKAI_NO.Text)
        Joken.KOUENKAI_NAME = Trim(Me.JokenKOUENKAI_NAME.Text)
        Joken.KIKAKU_TANTO_ROMA = Trim(Me.JokenKIKAKU_TANTO_ROMA.Text)
        Joken.TEHAI_TANTO_ROMA = Trim(Me.JokenTEHAI_TANTO_ROMA.Text)
        Joken.KUBUN = CmnModule.GetSelectedItemValue(Me.JokenKUBUN)
        If Me.JokenTTEHAI_TANTO.SelectedIndex <> 0 Then Joken.TTANTO_ID = Me.JokenTTEHAI_TANTO.SelectedValue
        If Me.ChkTTEHAI_TANTO.Checked Then
            Joken.TTEHAI_MITOUROKU = CmnConst.Flag.On
        Else
            Joken.TTEHAI_MITOUROKU = CmnConst.Flag.Off
        End If

        '@@@ Phase2
        ReDim TBL_KOTSUHOTEL_KEY(wCnt)
        strSQL = SQL.TBL_KOTSUHOTEL.Search_KeyItem(Joken, True)
        'ReDim TBL_KOTSUHOTEL(wCnt)
        'strSQL = SQL.TBL_KOTSUHOTEL.Search(Joken, False)
        '@@@ Phase2

        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)

        While RsData.Read()
            wFlag = True

            '@@@ Phase2
            ReDim Preserve TBL_KOTSUHOTEL_KEY(wCnt)
            TBL_KOTSUHOTEL_KEY(wCnt) = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL_KEY(wCnt))
            'ReDim Preserve TBL_KOTSUHOTEL(wCnt)
            'TBL_KOTSUHOTEL(wCnt) = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL(wCnt))
            '@@@ Phase2

            wCnt += 1
        End While
        RsData.Close()
        Me.LabelCount.Text = wCnt.ToString & " 件"
        ReDim Preserve grv_selected(wCnt - 1)

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

    'データソース設定
    Private Sub SetGridView()
        'データソース設定
        Dim strSQL As String = SQL.TBL_KOTSUHOTEL.Search_KeyItem(Joken, True)
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
            whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL, e.Row.Cells(CellIndex.TIME_STAMP).Text)
            whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.DR_MPID, e.Row.Cells(CellIndex.DR_MPID).Text)

            Dim GRID_KOTSUHOTEL As New TableDef.TBL_KOTSUHOTEL.DataStruct
            If Not GetGridData(whereData, GRID_KOTSUHOTEL) Then Exit Sub
            e.Row.Cells(CellIndex.JISSHI_DATE).Text = AppModule.GetName_KOUENKAI_DATE(GRID_KOTSUHOTEL.FROM_DATE, GRID_KOTSUHOTEL.TO_DATE, True)
            e.Row.Cells(CellIndex.KOUENKAI_NAME).Text = GRID_KOTSUHOTEL.KOUENKAI_NAME
            e.Row.Cells(CellIndex.DR_NAME).Text = GRID_KOTSUHOTEL.DR_NAME
            e.Row.Cells(CellIndex.MR_NAME).Text = GRID_KOTSUHOTEL.MR_NAME
            e.Row.Cells(CellIndex.TIME_STAMP).Text = CmnModule.Format_Date(GRID_KOTSUHOTEL.TIME_STAMP_BYL, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
            e.Row.Cells(CellIndex.INPUT_DATE).Text = CmnModule.Format_Date(GRID_KOTSUHOTEL.INPUT_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
            e.Row.Cells(CellIndex.USER_NAME).Text = CmnModule.Format_Date(GRID_KOTSUHOTEL.USER_NAME, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
            e.Row.Cells(CellIndex.KUBUN).Text = AppModule.GetName_ANS_STATUS_TEHAI(GRID_KOTSUHOTEL.ANS_STATUS_TEHAI)
            '宿泊
            e.Row.Cells(CellIndex.REQ_HOTEL).Text = AppModule.GetMark_TEHAI_HOTEL(GRID_KOTSUHOTEL.TEHAI_HOTEL)
            '交通
            If GRID_KOTSUHOTEL.REQ_O_TEHAI_1 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                GRID_KOTSUHOTEL.REQ_O_TEHAI_2 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                GRID_KOTSUHOTEL.REQ_O_TEHAI_3 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                GRID_KOTSUHOTEL.REQ_O_TEHAI_4 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                GRID_KOTSUHOTEL.REQ_O_TEHAI_5 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
                GRID_KOTSUHOTEL.REQ_F_TEHAI_1 = AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes OrElse _
                GRID_KOTSUHOTEL.REQ_F_TEHAI_2 = AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes OrElse _
                GRID_KOTSUHOTEL.REQ_F_TEHAI_3 = AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes OrElse _
                GRID_KOTSUHOTEL.REQ_F_TEHAI_4 = AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes OrElse _
                GRID_KOTSUHOTEL.REQ_F_TEHAI_5 = AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes Then

                e.Row.Cells(CellIndex.REQ_KOTSU).Text = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes)
            Else
                e.Row.Cells(CellIndex.REQ_KOTSU).Text = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No)
            End If
            'タクチケ
            e.Row.Cells(CellIndex.REQ_TAXI).Text = AppModule.GetMark_TEHAI_TAXI(GRID_KOTSUHOTEL.TEHAI_TAXI)
            'MR手配
            If GRID_KOTSUHOTEL.REQ_MR_O_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.RinSeki OrElse _
                GRID_KOTSUHOTEL.REQ_MR_O_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuSeki OrElse _
                GRID_KOTSUHOTEL.REQ_MR_O_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuBin OrElse _
                GRID_KOTSUHOTEL.REQ_MR_F_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.RinSeki OrElse _
                GRID_KOTSUHOTEL.REQ_MR_F_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuSeki OrElse _
                GRID_KOTSUHOTEL.REQ_MR_F_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuBin OrElse _
                GRID_KOTSUHOTEL.REQ_MR_HOTEL_NOTE <> "" OrElse _
                GRID_KOTSUHOTEL.ANS_MR_HOTEL_NOTE <> "" Then

                e.Row.Cells(CellIndex.REQ_MR).Text = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes)
            Else
                e.Row.Cells(CellIndex.REQ_MR).Text = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No)
            End If
            '緊急
            e.Row.Cells(CellIndex.REQ_EMERGENCY).Text = AppModule.GetMark_KINKYU_FLAG(GRID_KOTSUHOTEL.KINKYU_FLAG)
        End If
    End Sub

    'グリッドビュー項目セット(Phase2)
    Private Sub SetGridItem(ByVal pRow As GridViewRow, ByVal pIndex As Integer)
        Dim whereData As New StringDictionary
        whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID, DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.SALESFORCE_ID), DataControlFieldCell).Text())
        whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO, DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.KOUENKAI_NO), DataControlFieldCell).Text())
        whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID, DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.SANKASHA_ID), DataControlFieldCell).Text())
        whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL, DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.TIME_STAMP_BYL), DataControlFieldCell).Text())
        whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.DR_MPID, DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.DR_MPID), DataControlFieldCell).Text())

        Dim GRID_KOTSUHOTEL As New TableDef.TBL_KOTSUHOTEL.DataStruct
        If Not GetGridData(whereData, GRID_KOTSUHOTEL) Then Exit Sub
        DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.JISSHI_DATE), DataControlFieldCell).Text() = AppModule.GetName_KOUENKAI_DATE(GRID_KOTSUHOTEL.FROM_DATE, GRID_KOTSUHOTEL.TO_DATE, True)
        DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.KOUENKAI_NAME), DataControlFieldCell).Text() = GRID_KOTSUHOTEL.KOUENKAI_NAME
        DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.DR_NAME), DataControlFieldCell).Text() = GRID_KOTSUHOTEL.DR_NAME
        DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.MR_NAME), DataControlFieldCell).Text() = GRID_KOTSUHOTEL.MR_NAME
        DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.TIME_STAMP), DataControlFieldCell).Text() = CmnModule.Format_Date(GRID_KOTSUHOTEL.TIME_STAMP_BYL, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.INPUT_DATE), DataControlFieldCell).Text() = CmnModule.Format_Date(GRID_KOTSUHOTEL.INPUT_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.USER_NAME), DataControlFieldCell).Text() = CmnModule.Format_Date(GRID_KOTSUHOTEL.USER_NAME, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.KUBUN), DataControlFieldCell).Text() = AppModule.GetName_ANS_STATUS_TEHAI(GRID_KOTSUHOTEL.ANS_STATUS_TEHAI)
        '宿泊
        DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.REQ_HOTEL), DataControlFieldCell).Text() = AppModule.GetMark_TEHAI_HOTEL(GRID_KOTSUHOTEL.TEHAI_HOTEL)
        '交通
        If GRID_KOTSUHOTEL.REQ_O_TEHAI_1 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
            GRID_KOTSUHOTEL.REQ_O_TEHAI_2 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
            GRID_KOTSUHOTEL.REQ_O_TEHAI_3 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
            GRID_KOTSUHOTEL.REQ_O_TEHAI_4 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
            GRID_KOTSUHOTEL.REQ_O_TEHAI_5 = AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes OrElse _
            GRID_KOTSUHOTEL.REQ_F_TEHAI_1 = AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes OrElse _
            GRID_KOTSUHOTEL.REQ_F_TEHAI_2 = AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes OrElse _
            GRID_KOTSUHOTEL.REQ_F_TEHAI_3 = AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes OrElse _
            GRID_KOTSUHOTEL.REQ_F_TEHAI_4 = AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes OrElse _
            GRID_KOTSUHOTEL.REQ_F_TEHAI_5 = AppConst.KOTSUHOTEL.REQ_F_TEHAI.Code.Yes Then

            DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.REQ_KOTSU), DataControlFieldCell).Text() = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes)
        Else
            DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.REQ_KOTSU), DataControlFieldCell).Text() = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No)
        End If
        'タクチケ
        DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.REQ_TAXI), DataControlFieldCell).Text() = AppModule.GetMark_TEHAI_TAXI(GRID_KOTSUHOTEL.TEHAI_TAXI)
        'MR手配
        If GRID_KOTSUHOTEL.REQ_MR_O_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.RinSeki OrElse _
            GRID_KOTSUHOTEL.REQ_MR_O_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuSeki OrElse _
            GRID_KOTSUHOTEL.REQ_MR_O_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuBin OrElse _
            GRID_KOTSUHOTEL.REQ_MR_F_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.RinSeki OrElse _
            GRID_KOTSUHOTEL.REQ_MR_F_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuSeki OrElse _
            GRID_KOTSUHOTEL.REQ_MR_F_TEHAI = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuBin OrElse _
            GRID_KOTSUHOTEL.REQ_MR_HOTEL_NOTE <> "" OrElse _
            GRID_KOTSUHOTEL.ANS_MR_HOTEL_NOTE <> "" Then

            DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.REQ_MR), DataControlFieldCell).Text() = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes)
        Else
            DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.REQ_MR), DataControlFieldCell).Text() = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No)
        End If
        '緊急
        DirectCast(GrvList.Rows(pIndex).Controls(CellIndex.REQ_EMERGENCY), DataControlFieldCell).Text() = AppModule.GetMark_KINKYU_FLAG(GRID_KOTSUHOTEL.KINKYU_FLAG)
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.SALESFORCE_ID).Visible = False
            e.Row.Cells(CellIndex.DR_MPID).Visible = False
            e.Row.Cells(CellIndex.TIME_STAMP_BYL).Visible = False

            'e.Row.Cells(CellIndex.TO_DATE).Visible = False
            'e.Row.Cells(CellIndex.REQ_O_TEHAI_1).Visible = False
            'e.Row.Cells(CellIndex.REQ_O_TEHAI_2).Visible = False
            'e.Row.Cells(CellIndex.REQ_O_TEHAI_3).Visible = False
            'e.Row.Cells(CellIndex.REQ_O_TEHAI_4).Visible = False
            'e.Row.Cells(CellIndex.REQ_O_TEHAI_5).Visible = False
            'e.Row.Cells(CellIndex.REQ_F_TEHAI_1).Visible = False
            'e.Row.Cells(CellIndex.REQ_F_TEHAI_2).Visible = False
            'e.Row.Cells(CellIndex.REQ_F_TEHAI_3).Visible = False
            'e.Row.Cells(CellIndex.REQ_F_TEHAI_4).Visible = False
            'e.Row.Cells(CellIndex.REQ_F_TEHAI_5).Visible = False
            'e.Row.Cells(CellIndex.REQ_MR_O_TEHAI).Visible = False
            'e.Row.Cells(CellIndex.REQ_MR_F_TEHAI).Visible = False
            'e.Row.Cells(CellIndex.REQ_MR_HOTEL_NOTE).Visible = False
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

                '@@@ Phase2
                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                Dim row As GridViewRow = GrvList.Rows(index)
                Session.Item(SessionDef.SALESFORCE_ID) = DirectCast(GrvList.Rows(index).Controls(CellIndex.SALESFORCE_ID), DataControlFieldCell).Text()
                Session.Item(SessionDef.KOUENKAI_NO) = DirectCast(GrvList.Rows(index).Controls(CellIndex.KOUENKAI_NO), DataControlFieldCell).Text()
                Session.Item(SessionDef.SANKASHA_ID) = DirectCast(GrvList.Rows(index).Controls(CellIndex.SANKASHA_ID), DataControlFieldCell).Text()
                Session.Item(SessionDef.TIME_STAMP_BYL) = DirectCast(GrvList.Rows(index).Controls(CellIndex.TIME_STAMP_BYL), DataControlFieldCell).Text()
                Session.Item(SessionDef.DR_MPID) = DirectCast(GrvList.Rows(index).Controls(CellIndex.DR_MPID), DataControlFieldCell).Text()

                '履歴画面用セッション変数をクリア
                Session.Remove(SessionDef.KaijoRireki)
                Session.Remove(SessionDef.KouenkaiRireki_PageIndex)
                Session.Remove(SessionDef.KouenkaiRireki_SEQ)
                Session.Item(SessionDef.KouenkaiRireki_TBL_KOUENKAI) = False

                Response.Redirect(URL.DrRegist)
        End Select
    End Sub

    '[全てにチェック]
    Private Sub lnkCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkCheck.Click
        Dim i As Integer = 0
        For Each row As GridViewRow In Me.GrvList.Rows
            DirectCast(row.FindControl("chkPrint"), CheckBox).Checked = True
            '@@@ Phase2
            Call SetGridItem(row, i)
            i += 1
            '@@@ Phase2
        Next
    End Sub

    '[全てのチェックを解除]
    Private Sub lnkNoCheck_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lnkNoCheck.Click
        Dim i As Integer = 0
        For Each row As GridViewRow In Me.GrvList.Rows
            DirectCast(row.FindControl("chkPrint"), CheckBox).Checked = False
            '@@@ Phase2
            Call SetGridItem(row, i)
            i += 1
            '@@@ Phase2
        Next
    End Sub

    '[検索]
    Private Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        '入力チェック
        If Not Check() Then Exit Sub

        '一覧 表示
        SetForm()

    End Sub

    '[手配書一括印刷]
    Private Sub BtnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint1.Click, BtnPrint2.Click
        Dim UPD_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
        Dim seq As Integer = 0
        Dim nowrow As Integer = 0
        Dim PrintSeq As Integer = 0
        Dim TEHAISHO_JOKEN() As TableDef.TehaishoJoken.DataStruct

        '送信フラグ→送信対象
        For Each row As GridViewRow In Me.GrvList.Rows
            If DirectCast(row.FindControl("chkPrint"), CheckBox).Checked Then
                seq = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + nowrow
                '@@@ Phase2
                Dim whereData As New StringDictionary
                whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.SALEFORCE_ID, DirectCast(GrvList.Rows(nowrow).Controls(CellIndex.SALESFORCE_ID), DataControlFieldCell).Text())
                whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.KOUENKAI_NO, DirectCast(GrvList.Rows(nowrow).Controls(CellIndex.KOUENKAI_NO), DataControlFieldCell).Text())
                whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.SANKASHA_ID, DirectCast(GrvList.Rows(nowrow).Controls(CellIndex.SANKASHA_ID), DataControlFieldCell).Text())
                whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.TIME_STAMP_BYL, DirectCast(GrvList.Rows(nowrow).Controls(CellIndex.TIME_STAMP_BYL), DataControlFieldCell).Text())
                whereData.Add(TableDef.TBL_KOTSUHOTEL.Column.DR_MPID, DirectCast(GrvList.Rows(nowrow).Controls(CellIndex.DR_MPID), DataControlFieldCell).Text())
                '@@@ Phase2

                '回答ステータス・送信フラグON
                'If Not ExecuteTransaction(seq) Then
                If Not UpdateData(whereData) Then
                    Exit Sub
                End If
                ReDim Preserve TEHAISHO_JOKEN(PrintSeq)
                TEHAISHO_JOKEN(PrintSeq).KOUENKAI_NO = DirectCast(GrvList.Rows(nowrow).Controls(CellIndex.KOUENKAI_NO), DataControlFieldCell).Text()
                TEHAISHO_JOKEN(PrintSeq).SANKASHA_ID = DirectCast(GrvList.Rows(nowrow).Controls(CellIndex.SANKASHA_ID), DataControlFieldCell).Text()
                TEHAISHO_JOKEN(PrintSeq).SALEFORCE_ID = DirectCast(GrvList.Rows(nowrow).Controls(CellIndex.SALESFORCE_ID), DataControlFieldCell).Text()
                TEHAISHO_JOKEN(PrintSeq).TIME_STAMP_BYL = DirectCast(GrvList.Rows(nowrow).Controls(CellIndex.TIME_STAMP_BYL), DataControlFieldCell).Text()
                TEHAISHO_JOKEN(PrintSeq).DR_MPID = DirectCast(GrvList.Rows(nowrow).Controls(CellIndex.DR_MPID), DataControlFieldCell).Text()

                'TEHAISHO_JOKEN(PrintSeq).KOUENKAI_NO = TBL_KOTSUHOTEL(seq).KOUENKAI_NO
                'TEHAISHO_JOKEN(PrintSeq).SANKASHA_ID = TBL_KOTSUHOTEL(seq).SANKASHA_ID
                'TEHAISHO_JOKEN(PrintSeq).SALEFORCE_ID = TBL_KOTSUHOTEL(seq).SALEFORCE_ID
                'TEHAISHO_JOKEN(PrintSeq).TIME_STAMP_BYL = TBL_KOTSUHOTEL(seq).TIME_STAMP_BYL
                'TEHAISHO_JOKEN(PrintSeq).DR_MPID = TBL_KOTSUHOTEL(seq).DR_MPID

                PrintSeq += 1
            End If
            'seq += 1
            nowrow += 1
        Next

        Dim strSQL As String = ""

        Joken = Nothing
        If Me.JokenBU.SelectedIndex <> 0 Then
            Joken.BU = Me.JokenBU.SelectedItem.ToString
        Else
            Joken.BU = ""
        End If
        If Me.JokenTEHAI_TANTO_AREA.SelectedIndex <> 0 Then
            Joken.AREA = JokenTEHAI_TANTO_AREA.SelectedItem.ToString
        Else
            Joken.AREA = ""
        End If
        Joken.KUBUN = CmnModule.GetSelectedItemValue(Me.JokenKUBUN)
        Joken.KOUENKAI_NO = Trim(Me.JokenKOUENKAI_NO.Text)
        Joken.KOUENKAI_NAME = Trim(Me.JokenKOUENKAI_NAME.Text)
        Joken.KIKAKU_TANTO_ROMA = Trim(Me.JokenKIKAKU_TANTO_ROMA.Text)
        Joken.TEHAI_TANTO_ROMA = Trim(Me.JokenTEHAI_TANTO_ROMA.Text)
        If Me.JokenTTEHAI_TANTO.SelectedIndex <> 0 Then
            Joken.TTANTO_ID = JokenTTEHAI_TANTO.SelectedValue.ToString
        Else
            Joken.TTANTO_ID = ""
        End If
        If Me.ChkTTEHAI_TANTO.Checked Then
            Joken.TTEHAI_MITOUROKU = CmnConst.Flag.On
        Else
            Joken.TTEHAI_MITOUROKU = CmnConst.Flag.Off
        End If

        strSQL = SQL.TBL_KOTSUHOTEL.Search(Joken, False, TEHAISHO_JOKEN)

        '手配書印刷
        Session.Item(SessionDef.TehaishoPrint_SQL) = strSQL
        Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Session.Item(SessionDef.Joken) = Joken
        Session.Item(SessionDef.PrintPreview) = "TehaishoPrint"
        Response.Redirect(URL.Preview)
    End Sub

    '[戻る]
    Private Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click, BtnBack2.Click
        Response.Redirect(URL.Menu)
    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsAlphanumericHyphen(Me.JokenKOUENKAI_NO) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphanumericHyphenOnly("会合番号"), Me)
            Return False
        End If

        If Not CmnCheck.IsAlphabetOnly(Me.JokenTEHAI_TANTO_ROMA) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphabetOnly("BYL手配担当者(ローマ字)"), Me)
            Return False
        End If

        Return True
    End Function

    'データ更新
    Private Function ExecuteTransaction(ByVal seq As Integer) As Boolean

        '@@@ Phase2
        'TBL_KOTSUHOTEL(seq).ANS_STATUS_TEHAI = AppConst.KOTSUHOTEL.STATUS_TEHAI.Answer.Code.Uketsuke
        'TBL_KOTSUHOTEL(seq).SEND_FLAG = AppConst.SEND_FLAG.Code.Taisho
        'Return UpdateData(seq)
        '@@@ Phase2
    End Function

    'データ更新
    Private Function UpdateData(ByVal whereData As StringDictionary) As Boolean
        Dim strSQL As String

        MyBase.BeginTransaction()
        Try
            'データ更新
            '@@@ Phase2
            strSQL = SQL.TBL_KOTSUHOTEL.Update_IkkatsuTehai(whereData, Session.Item(SessionDef.LoginID))
            'strSQL = SQL.TBL_KOTSUHOTEL.Update(TBL_KOTSUHOTEL(seq))
            '@@@ Phase2
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            MyBase.Commit()
            Return True
        Catch ex As Exception
            MyBase.Rollback()

            Throw New Exception(Session.Item(SessionDef.DbError) & vbNewLine & Trim(strSQL))
            Return False
        End Try

        Return True
    End Function

    '[新着一覧印刷]
    Private Sub BtnIchiranPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnIchiranPrint1.Click, BtnIchiranPrint2.Click
        Dim strSQL As String = ""

        Joken = Nothing
        If Me.JokenBU.SelectedIndex <> 0 Then
            Joken.BU = Me.JokenBU.SelectedItem.ToString
        Else
            Joken.BU = ""
        End If
        If Me.JokenTEHAI_TANTO_AREA.SelectedIndex <> 0 Then
            Joken.AREA = JokenTEHAI_TANTO_AREA.SelectedItem.ToString
        Else
            Joken.AREA = ""
        End If
        Joken.KUBUN = CmnModule.GetSelectedItemValue(Me.JokenKUBUN)
        Joken.KOUENKAI_NO = Trim(Me.JokenKOUENKAI_NO.Text)
        Joken.KOUENKAI_NAME = Trim(Me.JokenKOUENKAI_NAME.Text)
        Joken.KIKAKU_TANTO_ROMA = Trim(Me.JokenKIKAKU_TANTO_ROMA.Text)
        Joken.TEHAI_TANTO_ROMA = Trim(Me.JokenTEHAI_TANTO_ROMA.Text)
        If Me.JokenTTEHAI_TANTO.SelectedIndex <> 0 Then
            Joken.TTANTO_ID = JokenTTEHAI_TANTO.SelectedValue.ToString
        Else
            Joken.TTANTO_ID = ""
        End If
        If Me.ChkTTEHAI_TANTO.Checked Then
            Joken.TTEHAI_MITOUROKU = CmnConst.Flag.On
        Else
            Joken.TTEHAI_MITOUROKU = CmnConst.Flag.Off
        End If

        strSQL = SQL.TBL_KOTSUHOTEL.Search(Joken, True)
        If Joken.BU.Trim = "" Then Joken.BU = "指定なし"
        If Joken.AREA.Trim = "" Then Joken.AREA = "指定なし"
        If Joken.KUBUN.Trim = "" Then Joken.KUBUN = "指定なし"
        If Joken.KOUENKAI_NO.Trim = "" Then Joken.KOUENKAI_NO = "指定なし"
        If Joken.KOUENKAI_NAME.Trim = "" Then Joken.KOUENKAI_NAME = "指定なし"
        If Joken.KIKAKU_TANTO_ROMA.Trim = "" Then Joken.KIKAKU_TANTO_ROMA = "指定なし"
        If Joken.TEHAI_TANTO_ROMA.Trim = "" Then Joken.TEHAI_TANTO_ROMA = "指定なし"
        If Joken.TTANTO_ID.Trim = "" Then Joken.TTANTO_ID = "指定なし"
        If Joken.TTEHAI_MITOUROKU = CmnConst.Flag.Off Then
            Joken.TTEHAI_MITOUROKU = "指定なし"
        Else
            Joken.TTEHAI_MITOUROKU = "未登録者のみ"
        End If

        Session.Item(SessionDef.NewDrPrint_SQL) = strSQL
        Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Session.Item(SessionDef.Joken) = Joken
        Session.Item(SessionDef.PrintPreview) = "NewDrPrint"
        Response.Redirect(URL.Preview)
    End Sub

    Protected Sub JokenTTEHAI_TANTO_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles JokenTTEHAI_TANTO.SelectedIndexChanged
        If Me.JokenTTEHAI_TANTO.SelectedIndex > 0 Then
            ChkTTEHAI_TANTO.Checked = False
        End If
    End Sub

    Private Sub ChkTTEHAI_TANTO_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkTTEHAI_TANTO.CheckedChanged
        If Me.ChkTTEHAI_TANTO.Checked Then
            Me.JokenTTEHAI_TANTO.SelectedIndex = 0
        End If
    End Sub
End Class