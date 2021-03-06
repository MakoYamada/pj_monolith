﻿Imports CommonLib
Imports AppLib

Partial Public Class DrRireki
    Inherits WebBase

    Private TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private RRK_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private SEQ As Integer

    '@@@ Phase2
    Private KEY_SALESFORCE_ID As String
    Private KEY_KOUENKAI_NO As String
    Private KEY_SANKASHA_ID As String
    Private KEY_TIME_STAMP_BYL As String
    Private KEY_DR_MPID As String
    '@@@ Phase2
    'グリッド列    Private Enum CellIndex
        FROM_DATE
        SANKASHA_ID
        DR_NAME
        MR_NAME
        TIME_STAMP
        UPDATE_DATE
        USER_NAME
        ANS_STATUS_TEHAI
        TEHAI_HOTEL
        TEHAI_KOTSU
        TEHAI_TAXI
        TEHAI_MR
        TEHAI_EMERGENCY
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
        REQ_MR_O_TEHAI
        REQ_MR_F_TEHAI
        REQ_MR_HOTEL_NOTE
        TIME_STAMP_BYL
        DR_MPID
    End Enum

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_KOTSUHOTEL) = TBL_KOTSUHOTEL
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

            '画面項目表示
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "交通・宿泊手配履歴"
        End With

    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            TBL_KOTSUHOTEL = Session.Item(SessionDef.TBL_KOTSUHOTEL)
            KEY_SALESFORCE_ID = Session.Item(SessionDef.SALESFORCE_ID)
            KEY_KOUENKAI_NO = Session.Item(SessionDef.KOUENKAI_NO)
            KEY_SANKASHA_ID = Session.Item(SessionDef.SANKASHA_ID)
            KEY_TIME_STAMP_BYL = Session.Item(SessionDef.TIME_STAMP_BYL)
            KEY_DR_MPID = Session.Item(SessionDef.DR_MPID)

            If IsNothing(TBL_KOTSUHOTEL) Then Return False
            If IsNothing(KEY_SALESFORCE_ID) Then Return False
            If IsNothing(KEY_KOUENKAI_NO) Then Return False
            If IsNothing(KEY_SANKASHA_ID) Then Return False
            If IsNothing(KEY_TIME_STAMP_BYL) Then Return False
            If IsNothing(KEY_DR_MPID) Then Return False
        Catch ex As Exception
            Return False
        End Try
        'If Not MyModule.IsValidSEQ(Session.Item(SessionDef.SEQ)) Then
        '    Return False
        'Else
        '    SEQ = Session.Item(SessionDef.SEQ)
        'End If

        Session.Item(SessionDef.DrRireki) = True
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()
        'クリア
        CmnModule.ClearAllControl(Me)

    End Sub

    '画面項目 表示
    Private Sub SetForm()
        'データ取得
        If Not GetData() Then
            Me.LabelNoData.Visible = True
            Me.GrvList.Visible = False
            Me.TrKOUENKAI_NAME.Visible = False
        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True
            Me.TrKOUENKAI_NAME.Visible = True

            '@@@ Phase2
            Me.KOUENKAI_NO.Text = AppModule.GetName_KOUENKAI_NO(KEY_KOUENKAI_NO)
            Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NAME(RRK_KOTSUHOTEL(0).KOUENKAI_NAME)
            'Me.KOUENKAI_NO.Text = AppModule.GetName_KOUENKAI_NO(TBL_KOTSUHOTEL(SEQ).KOUENKAI_NO)
            'Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NAME(TBL_KOTSUHOTEL(SEQ).KOUENKAI_NAME)
            '@@@ Phase2

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

        '@@@ Phase2
        strSQL = SQL.TBL_KOTSUHOTEL.DrRireki(KEY_KOUENKAI_NO, KEY_SANKASHA_ID)
        'strSQL = SQL.TBL_KOTSUHOTEL.DrRireki(TBL_KOTSUHOTEL(SEQ).KOUENKAI_NO, TBL_KOTSUHOTEL(SEQ).SANKASHA_ID)
        '@@@ Phase2

        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        ReDim RRK_KOTSUHOTEL(wCnt)
        While RsData.Read()
            wFlag = True

            ReDim Preserve RRK_KOTSUHOTEL(wCnt)
            RRK_KOTSUHOTEL(wCnt) = AppModule.SetRsData(RsData, RRK_KOTSUHOTEL(wCnt))

            wCnt += 1
        End While
        RsData.Close()
        Session.Item(SessionDef.DrRireki_TBL_KOTSUHOTEL) = RRK_KOTSUHOTEL

        Return wFlag
    End Function

    'データソース設定
    Private Sub SetGridView()
        'データソース設定        '@@@ Phase2
        Dim strSQL As String = SQL.TBL_KOTSUHOTEL.DrRireki(KEY_KOUENKAI_NO, KEY_SANKASHA_ID)
        'Dim strSQL As String = SQL.TBL_KOTSUHOTEL.DrRireki(TBL_KOTSUHOTEL(SEQ).KOUENKAI_NO, TBL_KOTSUHOTEL(SEQ).SANKASHA_ID)
        '@@@ Phase2
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

            '開催日
            e.Row.Cells(CellIndex.FROM_DATE).Text = AppModule.GetName_KOUENKAI_DATE(e.Row.Cells(CellIndex.FROM_DATE).Text, e.Row.Cells(CellIndex.TO_DATE).Text, True)
            'TimeStamp
            e.Row.Cells(CellIndex.TIME_STAMP).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.TIME_STAMP).Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
            '更新日
            e.Row.Cells(CellIndex.UPDATE_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.UPDATE_DATE).Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
            'TOPステータス
            e.Row.Cells(CellIndex.ANS_STATUS_TEHAI).Text = AppModule.GetName_ANS_STATUS_TEHAI(e.Row.Cells(CellIndex.ANS_STATUS_TEHAI).Text)
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
            'MR手配
            If e.Row.Cells(CellIndex.REQ_MR_O_TEHAI).Text = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.RinSeki OrElse _
                e.Row.Cells(CellIndex.REQ_MR_O_TEHAI).Text = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuSeki OrElse _
                e.Row.Cells(CellIndex.REQ_MR_O_TEHAI).Text = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuBin OrElse _
                e.Row.Cells(CellIndex.REQ_MR_F_TEHAI).Text = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.RinSeki OrElse _
                e.Row.Cells(CellIndex.REQ_MR_F_TEHAI).Text = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuSeki OrElse _
                e.Row.Cells(CellIndex.REQ_MR_F_TEHAI).Text = AppConst.KOTSUHOTEL.REQ_MR_TEHAI.Code.BetsuBin OrElse _
                e.Row.Cells(CellIndex.REQ_MR_HOTEL_NOTE).Text.Trim <> "&nbsp;" Then

                e.Row.Cells(CellIndex.TEHAI_MR).Text = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.Yes)
            Else
                e.Row.Cells(CellIndex.TEHAI_MR).Text = AppModule.GetMark_REQ_O_TEHAI(AppConst.KOTSUHOTEL.REQ_O_TEHAI.Code.No)
            End If
            '緊急
            e.Row.Cells(CellIndex.TEHAI_EMERGENCY).Text = AppModule.GetMark_KINKYU_FLAG(e.Row.Cells(CellIndex.TEHAI_EMERGENCY).Text)
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
            e.Row.Cells(CellIndex.REQ_MR_O_TEHAI).Visible = False
            e.Row.Cells(CellIndex.REQ_MR_F_TEHAI).Visible = False
            e.Row.Cells(CellIndex.REQ_MR_HOTEL_NOTE).Visible = False
            e.Row.Cells(CellIndex.TIME_STAMP_BYL).Visible = False
            e.Row.Cells(CellIndex.DR_MPID).Visible = False
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
                Session.Item(SessionDef.DrRireki_SEQ) = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + CmnModule.DbVal(e.CommandArgument)
                Session.Item(SessionDef.DrRireki_PageIndex) = Me.GrvList.PageIndex

                Dim index As Integer = Convert.ToInt32(e.CommandArgument)
                Dim row As GridViewRow = GrvList.Rows(index)
                Session.Item(SessionDef.POPUP_SALESFORCE_ID) = DirectCast(GrvList.Rows(index).Controls(CellIndex.SALESFORCE_ID), DataControlFieldCell).Text()
                Session.Item(SessionDef.POPUP_KOUENKAI_NO) = DirectCast(GrvList.Rows(index).Controls(CellIndex.KOUENKAI_NO), DataControlFieldCell).Text()
                Session.Item(SessionDef.POPUP_SANKASHA_ID) = DirectCast(GrvList.Rows(index).Controls(CellIndex.SANKASHA_ID), DataControlFieldCell).Text()
                Session.Item(SessionDef.POPUP_TIME_STAMP_BYL) = DirectCast(GrvList.Rows(index).Controls(CellIndex.TIME_STAMP_BYL), DataControlFieldCell).Text()
                Session.Item(SessionDef.POPUP_DR_MPID) = DirectCast(GrvList.Rows(index).Controls(CellIndex.DR_MPID), DataControlFieldCell).Text()

                Dim scriptStr As String
                scriptStr = "<script type='text/javascript'>"
                scriptStr += "window.open('" & URL.DrRegist & "','_blank','width=1200,height=800,resizable=yes,scrollbars=yes,menubar=no,toolbar=no,location=no,status=no');"
                scriptStr += "</script>"
                ClientScript.RegisterStartupScript(Me.GetType(), "Detail", scriptStr)
        End Select
    End Sub

    '[戻る]
    Private Sub BtnBack1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click
        Session.Item(SessionDef.DrRireki) = False
        Response.Redirect(Session.Item(SessionDef.BackURL))
    End Sub

    '[戻る]
    Private Sub BtnBack2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack2.Click
        BtnBack1_Click(sender, e)
    End Sub

    '[印刷]
    Private Sub BtnPrint1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint1.Click
        Dim strSQL As String = ""

        'strSQL = SQL.TBL_KOTSUHOTEL.DrRireki(TBL_KOTSUHOTEL(SEQ).KOUENKAI_NO, TBL_KOTSUHOTEL(SEQ).SANKASHA_ID)
        strSQL = SQL.TBL_KOTSUHOTEL.DrRireki(TBL_KOTSUHOTEL.KOUENKAI_NO, TBL_KOTSUHOTEL.SANKASHA_ID)

        Session.Item(SessionDef.DrRirekiPrint_SQL) = strSQL
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Response.Redirect(URL.Preview)
    End Sub

    '[印刷]
    Private Sub BtnPrint2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint2.Click
        BtnPrint1_Click(sender, e)
    End Sub
End Class