Imports CommonLib
Imports AppLib
Imports System.IO

Partial Public Class TaxiMaintenance
    Inherits WebBase

    Private TBL_TAXITICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
    Private Joken As TableDef.Joken.DataStruct
    Private DATA_MAINTENANCE As String

    'グリッド列    Private Enum CellIndex
        JISSHI_DATE
        KOUENKAI_NAME
        SANKASHA_ID
        DR_NAME
        USER_NAME
        TKT_NO
        TKT_KENSHU
        TKT_USED_DATE
        TKT_HATUTI
        TKT_CHAKUTI
        TKT_SEIKYU_YM
        VOID_DATE
        button
        TKT_LINE_NO
        TKT_VOID
        KOUENKAI_NO
        FROM_DATE
        TO_DATE
        UPDATE_DATE
    End Enum

    Private Sub DrList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_TAXITICKET_HAKKO) = TBL_TAXITICKET_HAKKO
        Session.Item(SessionDef.Joken) = Joken
        Session.Item(SessionDef.DATA_MAINTENANCE) = DATA_MAINTENANCE
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

            '画面項目表示 2014/06/06 Delete
            'SetForm()
        End If

        'マスターページ設定
        With Me.Master
            If DATA_MAINTENANCE = CmnConst.Flag.Off Then
                .DispTaxiMenu = True
            Else
                .DispTaxiMenu = False
            End If
            .PageTitle = "タクチケメンテナンス一覧"
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

        If Not Session.Item(SessionDef.DATA_MAINTENANCE) Is Nothing Then
            DATA_MAINTENANCE = Session.Item(SessionDef.DATA_MAINTENANCE)
        Else
            DATA_MAINTENANCE = ""
        End If
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
        CmnModule.SetIme(Me.JokenTKT_NO, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenSANKASHA_ID, CmnModule.ImeType.InActive)
        Me.BtnCsv1.Visible = False
        Me.BtnCsv2.Visible = False
        Me.BtnBack2.Visible = False
        Me.LabelNoData.Visible = False


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
            Me.BtnCsv1.Visible = False
            Me.BtnCsv2.Visible = False
            Me.BtnBack2.Visible = False
        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True
            Me.BtnCsv1.Visible = True
            Me.BtnCsv2.Visible = True
            Me.BtnBack1.Visible = True
            Me.BtnBack2.Visible = True
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
        Joken.SANKASHA_ID = Trim(Me.JokenSANKASHA_ID.Text)
        Joken.TKT_NO = Trim(Me.JokenTKT_NO.Text)
        If Me.JokenTTEHAI_TANTO.SelectedIndex <> 0 Then Joken.TTANTO_ID = Me.JokenTTEHAI_TANTO.SelectedValue

        ReDim TBL_TAXITICKET_HAKKO(wCnt)

        strSQL = SQL.TBL_TAXITICKET_HAKKO.Search(Joken, False)
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
            Me.BtnBack2.Visible = False

        Else
            Me.LabelNoData.Visible = False
            Me.GrvList.Visible = True
            Me.BtnCsv1.Visible = True
            Me.BtnCsv2.Visible = True
            Me.BtnBack1.Visible = True
            Me.BtnBack2.Visible = True
            CmnModule.SetEnabled(Me.BtnCsv1, True)
            CmnModule.SetEnabled(Me.BtnCsv2, True)

            'グリッドビュー表示
            SetGridView()
        End If
    End Sub

    'データソース設定
    Private Sub SetGridView()
        'データソース設定
        Dim strSQL As String = SQL.TBL_TAXITICKET_HAKKO.Search(Joken, False)
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
            e.Row.Cells(CellIndex.TKT_LINE_NO).Visible = False
            e.Row.Cells(CellIndex.TKT_VOID).Visible = False
            e.Row.Cells(CellIndex.KOUENKAI_NO).Visible = False
            e.Row.Cells(CellIndex.FROM_DATE).Visible = False
            e.Row.Cells(CellIndex.TO_DATE).Visible = False
            e.Row.Cells(CellIndex.UPDATE_DATE).Visible = False
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

                Response.Redirect(URL.TaxiMaintenanceRegist)
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

        If Not CmnCheck.IsAlphanumericHyphen(Me.JokenSANKASHA_ID) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphanumericHyphenOnly("参加者ID"), Me)
            Return False
        End If

        If Not CmnCheck.IsAlphanumericHyphen(Me.JokenTKT_NO) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphanumericHyphenOnly("タクチケ番号"), Me)
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
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & "PastTaxiMaintenance.csv")
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-JIS")

            Response.Write(MyModule.Csv.TaxiMaintenance(TBL_TAXITICKET_HAKKO))
            Response.End()
        End If
    End Sub
End Class