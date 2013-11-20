Imports CommonLib
Imports AppLib

Partial Public Class DrRireki
    Inherits WebBase

    Private TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private RRK_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private SEQ As Integer

    'グリッド列    Private Enum CellIndex
        FROM_DATE
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

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_KOTSUHOTEL) = TBL_KOTSUHOTEL
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
            If IsNothing(TBL_KOTSUHOTEL) Then Return False
        Catch ex As Exception
            Return False
        End Try
        If Not MyModule.IsValidSEQ(Session.Item(SessionDef.SEQ)) Then
            Return False
        Else
            SEQ = Session.Item(SessionDef.SEQ)
        End If

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

        strSQL = SQL.TBL_KOTSUHOTEL.DrRireki(TBL_KOTSUHOTEL(SEQ).KOUENKAI_NO, TBL_KOTSUHOTEL(SEQ).SANKASHA_ID)

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
        'データソース設定        Dim strSQL As String = SQL.TBL_KOTSUHOTEL.DrRireki(TBL_KOTSUHOTEL(SEQ).KOUENKAI_NO, TBL_KOTSUHOTEL(SEQ).SANKASHA_ID)
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
                Session.Item(SessionDef.KouenkaiRireki_SEQ) = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + CmnModule.DbVal(e.CommandArgument)
                Session.Item(SessionDef.KouenkaiRireki_PageIndex) = Me.GrvList.PageIndex

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
End Class