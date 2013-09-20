Imports CommonLib
Imports AppLib

Partial Public Class KouenkaiList
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct

    'グリッド列    Private Enum CellIndex
        KIKAKU_TANTO_JIGYOBU
        KIKAKU_TANTO_AREA
        KIKAKU_TANTO_EIGYOSHO
        JISSHI_DATE
        MEETING_NAME
        TIMESTAMP
        TEHAI_TANTO_NAME
        Button1
        KOUENKAI_CD
    End Enum

    Private Sub KouenkaiList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        'Session.Item(SessionDef.TBL_DR) = TBL_DR
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ''共通チェック
        'MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), AppModule.UserType.Manage, Me)

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
            .PageTitle = "検索　講演会（基本情報）"
        End With

    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        'If Not MyModule.IsValidPLACE(Session.Item(SessionDef.PLACE)) Then
        '    Return False
        'Else
        '    PLACE = Session.Item(SessionDef.PLACE)
        'End If
        'Try
        '    Joken = Session.Item(SessionDef.Joken)
        'Catch ex As Exception
        '    Joken = Nothing
        'End Try
        'Try
        '    TBL_DR = Session.Item(SessionDef.TBL_DR)
        '    If TBL_DR Is Nothing Then ReDim TBL_DR(0)
        'Catch ex As Exception
        '    ReDim TBL_DR(0)
        'End Try
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()
        'クリア
        CmnModule.ClearAllControl(Me)

        Me.LabelNoData.Visible = False

    End Sub

    '画面項目 表示
    Private Sub SetForm()
        ''条件
        'If Session.Item(SessionDef.Search) = CmnConst.Flag.On Then
        '    Me.DivJoken.Visible = True
        '    Me.LabelTitle_CountALL.Text = "該当者数："
        '    Me.LabelTitle_CountPARTY.Visible = False
        '    Me.CountPARTY.Visible = False
        '    Me.LabelTitle_CountTEHAI_HOTEL.Visible = False
        '    Me.CountTEHAI_HOTEL.Visible = False
        '    Me.LabelTitle_CountTEHAI_KOTSU.Visible = False
        '    Me.CountTEHAI_KOTSU.Visible = False
        '    Dim wStr As String = ""
        '    If Trim(Joken.DR_NAME) <> "" Then
        '        If Trim(wStr) <> "" Then wStr &= "／"
        '        wStr &= "Dr.氏名＝" & Joken.DR_NAME
        '    End If
        '    If Trim(Joken.DATA_NO) <> "" Then
        '        If Trim(wStr) <> "" Then wStr &= "／"
        '        wStr &= "申込番号＝" & Joken.DATA_NO
        '    End If
        '    If Trim(Joken.SHISETSU_NAME) <> "" Then
        '        If Trim(wStr) <> "" Then wStr &= "／"
        '        wStr &= "施設・病院名＝" & Joken.SHISETSU_NAME
        '    End If
        '    If Trim(Joken.MR_NAME) <> "" Then
        '        If Trim(wStr) <> "" Then wStr &= "／"
        '        wStr &= "登録者氏名＝" & Joken.MR_NAME
        '    End If
        '    If Trim(Joken.SHITEN) <> "" Then
        '        If Trim(wStr) <> "" Then wStr &= "／"
        '        wStr &= "支店＝" & Joken.SHITEN
        '    End If
        '    If Trim(Joken.EIGYOSHO) <> "" Then
        '        If Trim(wStr) <> "" Then wStr &= "／"
        '        wStr &= "営業所＝" & Joken.EIGYOSHO
        '    End If
        '    Me.LabelJoken.Text = wStr
        'Else
        '    Me.DivJoken.Visible = False
        '    Me.LabelTitle_CountALL.Text = "登録者数："
        '    Me.LabelTitle_CountPARTY.Visible = True
        '    Me.CountPARTY.Visible = True
        '    Me.LabelTitle_CountTEHAI_HOTEL.Visible = True
        '    Me.CountTEHAI_HOTEL.Visible = True
        '    Me.LabelTitle_CountTEHAI_KOTSU.Visible = True
        '    Me.CountTEHAI_KOTSU.Visible = True
        'End If

        'DDL

    End Sub

    'データ取得
    Private Function GetData() As Boolean
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        'If Session.Item(SessionDef.Search) = CmnConst.Flag.On Then
        '    Joken.PLACE = PLACE
        '    strSQL = SQL.TBL_DR.Search(Joken)
        'Else
        'strSQL = SQL.TBL_KOTSUHOTEL
        'End If
        ReDim TBL_KOUENKAI(wCnt)

        '仮
        strSQL = "SELECT * FROM TBL_KOUENKAI"

        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve TBL_KOUENKAI(wCnt)
            TBL_KOUENKAI(wCnt) = AppModule.SetRsData(RsData, TBL_KOUENKAI(wCnt))

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
        Dim strSQL As String
        'If Session.Item(SessionDef.Search) = CmnConst.Flag.On Then
        '    Joken.PLACE = PLACE
        '    strSQL = SQL.TBL_DR.Search(Joken)
        'Else
        '    strSQL = SQL.TBL_DR.SankaData(PLACE)
        'End If

        '仮
        strSQL = "SELECT * FROM TBL_KOUENKAI"

        'TODO:最新の会場手配情報を持ってくる必要があるかも?

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
            e.Row.Cells(CellIndex.JISSHI_DATE).Text = CmnModule.Format_Date(e.Row.Cells(CellIndex.JISSHI_DATE).Text, CmnModule.DateFormatType.YYYYMMDD)
            '仮
            'e.Row.Cells(CellIndex.KUBUN).Text = GetKigou_TEHAI_HOTEL(e.Row.Cells(CellIndex.KUBUN).Text)
            'e.Row.Cells(CellIndex.TEHAI_HOTEL).Text = GetKigou_TEHAI_HOTEL(e.Row.Cells(CellIndex.TEHAI_HOTEL).Text)
            'e.Row.Cells(CellIndex.TEHAI_KOTSU).Text = GetKigou_TEHAI_HOTEL(e.Row.Cells(CellIndex.TEHAI_KOTSU).Text)
            'e.Row.Cells(CellIndex.TEHAI_TAXI).Text = GetKigou_TEHAI_HOTEL(e.Row.Cells(CellIndex.TEHAI_TAXI).Text)

            'e.Row.Cells(CellIndex.TEHAI_HOTEL).Text = AppModule.GetName_TEHAI_HOTEL(e.Row.Cells(CellIndex.TEHAI_HOTEL).Text, True)
            'e.Row.Cells(CellIndex.TEHAI_KOTSU).Text = AppModule.GetName_TEHAI_KOTSU(e.Row.Cells(CellIndex.TEHAI_KOTSU).Text, True)
            'e.Row.Cells(CellIndex.UPD_DATE).Text = AppModule.GetName_UPD_DATE(e.Row.Cells(CellIndex.UPD_DATE).Text, True)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
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
                'Session.Item(SessionDef.SEQ) = (Me.GrvList.PageIndex * Me.GrvList.PageSize) + CmnModule.DbVal(e.CommandArgument)
                'Session.Item(SessionDef.TBL_DR) = TBL_DR
                'Session.Item(SessionDef.PageIndex) = Me.GrvList.PageIndex
                'Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
                Response.Redirect(URL.DrRegist)
        End Select
    End Sub

    '[検索]
    Private Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click

        '一覧 表示
        DispList()

    End Sub

    '[戻る]
    Private Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack.Click

    End Sub
End Class