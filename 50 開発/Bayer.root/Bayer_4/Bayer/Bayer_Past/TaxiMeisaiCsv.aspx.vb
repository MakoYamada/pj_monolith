Imports CommonLib
Imports AppLib
Partial Public Class TaxiMeisaiCsv
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列
    Private Enum CellIndex
        BU
        KIKAKU_TANTO_AREA
        KIKAKU_TANTO_EIGYOSHO
        FROM_DATE
        KOUENKAI_NAME
        TIME_STAMP
        UPDATE_DATE
        USER_NAME
        Button1
        KOUENKAI_NO
        TO_DATE
    End Enum

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
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
        MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納
        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()
        End If

        'マスターページ設定
        With Me.Master
            .DispTaxiMenu = True
            .PageTitle = "タクチケ管理台帳"
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

    '画面項目 初期化
    Private Sub InitControls()
        'プルダウン設定
        AppModule.SetDropDownList_BU(Me.JoKenBU, MyBase.DbConnection)
        AppModule.SetDropDownList_AREA(Me.JoKenKIKAKU_TANTO_AREA, MyBase.DbConnection)
        AppModule.SetDropDownList_SEIHIN(Me.JokenSEIHIN, MyBase.DbConnection)
        AppModule.SetDropDownList_USER_NAME(Me.JoKenTTANTO_ID, MyBase.DbConnection)

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

        Me.LabelNoData.Visible = False
        Me.GrvList.Visible = False
        Me.JokenTKT_ENTA_ALL.Checked = True
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        '条件表示
        Me.JokenKIKAKU_TANTO_ROMA.Text = Trim(Joken.KIKAKU_TANTO_ROMA)
        Me.JokenTEHAI_TANTO_ROMA.Text = Trim(Joken.TEHAI_TANTO_ROMA)
        Me.JokenKOUENKAI_NO.Text = Trim(Joken.KOUENKAI_NO)
        Me.JokenKOUENKAI_NAME.Text = Trim(Joken.KOUENKAI_NAME)
        If Trim(Joken.FROM_DATE) <> "" Then
            Me.JokenFROM_DATE_YYYY.Text = Mid(Joken.FROM_DATE, 1, 4)
            Me.JokenFROM_DATE_MM.Text = Mid(Joken.FROM_DATE, 5, 2)
            Me.JokenFROM_DATE_DD.Text = Mid(Joken.FROM_DATE, 7, 2)
        End If
        If Trim(Joken.TO_DATE) <> "" Then
            Me.JokenTO_DATE_YYYY.Text = Mid(Joken.TO_DATE, 1, 4)
            Me.JokenTO_DATE_MM.Text = Mid(Joken.TO_DATE, 5, 2)
            Me.JokenTO_DATE_DD.Text = Mid(Joken.TO_DATE, 7, 2)
        End If
        Me.JokenSEIHIN.SelectedIndex = CmnModule.GetSelectedIndex(Joken.SEIHIN_NAME, Me.JokenSEIHIN)
        Me.JoKenBU.SelectedIndex = CmnModule.GetSelectedIndex(Joken.BU, Me.JoKenBU)
        Me.JoKenKIKAKU_TANTO_AREA.SelectedIndex = CmnModule.GetSelectedIndex(Joken.AREA, Me.JoKenKIKAKU_TANTO_AREA)
        Me.JoKenTTANTO_ID.SelectedIndex = CmnModule.GetSelectedIndex(Joken.TTANTO_ID, Me.JoKenTTANTO_ID)

        Select Case Trim(Joken.TKT_ENTA)
            Case AppConst.TAXITICKET_HAKKO.TKT_ENTA.Joken_MeisaiCsv.ALL
                Me.JokenTKT_ENTA_ALL.Checked = True
                Me.JokenTKT_ENTA_N_Igai.Checked = False
                Me.JokenTKT_ENTA_N_Only.Checked = False
            Case AppConst.TAXITICKET_HAKKO.TKT_ENTA.Joken_MeisaiCsv.N_Igai
                Me.JokenTKT_ENTA_ALL.Checked = False
                Me.JokenTKT_ENTA_N_Igai.Checked = True
                Me.JokenTKT_ENTA_N_Only.Checked = False
            Case AppConst.TAXITICKET_HAKKO.TKT_ENTA.Joken_MeisaiCsv.N_Only
                Me.JokenTKT_ENTA_ALL.Checked = False
                Me.JokenTKT_ENTA_N_Igai.Checked = False
                Me.JokenTKT_ENTA_N_Only.Checked = True
            Case Else
                Me.JokenTKT_ENTA_ALL.Checked = False
                Me.JokenTKT_ENTA_N_Igai.Checked = False
                Me.JokenTKT_ENTA_N_Only.Checked = False
        End Select

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
        'End If
    End Sub

    '[検索]
    Protected Sub BtnSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        '入力チェック
        If Not Check() Then Exit Sub

        Joken = Nothing
        Joken.KIKAKU_TANTO_ROMA = Trim(Me.JokenKIKAKU_TANTO_ROMA.Text)
        Joken.TEHAI_TANTO_ROMA = Trim(Me.JokenTEHAI_TANTO_ROMA.Text)
        Joken.SEIHIN_NAME = CmnModule.GetSelectedItemValue(Me.JokenSEIHIN)
        Joken.KOUENKAI_NO = Trim(Me.JokenKOUENKAI_NO.Text)
        Joken.KOUENKAI_NAME = Trim(Me.JokenKOUENKAI_NAME.Text)
        Joken.FROM_DATE = CmnModule.Format_DateToString(Me.JokenFROM_DATE_YYYY.Text, Me.JokenFROM_DATE_MM.Text, Me.JokenFROM_DATE_DD.Text)
        Joken.TO_DATE = CmnModule.Format_DateToString(Me.JokenTO_DATE_YYYY.Text, Me.JokenTO_DATE_MM.Text, Me.JokenTO_DATE_DD.Text)
        Joken.BU = CmnModule.GetSelectedItemValue(Me.JoKenBU)
        Joken.AREA = CmnModule.GetSelectedItemValue(Me.JoKenKIKAKU_TANTO_AREA)
        Joken.TTANTO_ID = CmnModule.GetSelectedItemValue(Me.JoKenTTANTO_ID)
        Joken.USER_NAME = CmnModule.GetSelectedItemText(Me.JoKenTTANTO_ID)
        If Me.JokenTKT_ENTA_ALL.Checked = True Then
            Joken.TKT_ENTA = AppConst.TAXITICKET_HAKKO.TKT_ENTA.Joken_MeisaiCsv.ALL
        ElseIf Me.JokenTKT_ENTA_N_Igai.Checked = True Then
            Joken.TKT_ENTA = AppConst.TAXITICKET_HAKKO.TKT_ENTA.Joken_MeisaiCsv.N_Igai
        ElseIf Me.JokenTKT_ENTA_N_Only.Checked = True Then
            Joken.TKT_ENTA = AppConst.TAXITICKET_HAKKO.TKT_ENTA.Joken_MeisaiCsv.N_Only
        End If

        Session.Item(SessionDef.Joken) = Joken

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

        If Not CmnCheck.IsInput(Me.JokenTKT_ENTA_ALL, Me.JokenTKT_ENTA_N_Igai, Me.JokenTKT_ENTA_N_Only) Then
            CmnModule.AlertMessage(MessageDef.Error.MustSelect("抽出条件"), Me)
            Return False
        End If

        Return True
    End Function

    'データ取得
    Private Function GetData() As Boolean
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        ReDim TBL_KOUENKAI(wCnt)
        strSQL = SQL.TBL_KOUENKAI.TaxiMeisaiCsv_1(Joken)
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

    'データソース設定
    Private Sub SetGridView()
        'データソース設定
        Dim strSQL As String = SQL.TBL_KOUENKAI.TaxiMeisaiCsv(Joken)
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
            CType(e.Row.Cells(CellIndex.Button1).Controls(0), Button).CommandArgument = e.Row.Cells(CellIndex.KOUENKAI_NO).Text

            e.Row.Cells(CellIndex.FROM_DATE).Text = AppModule.GetName_KOUENKAI_DATE(e.Row.Cells(CellIndex.FROM_DATE).Text, e.Row.Cells(CellIndex.TO_DATE).Text, True)
            e.Row.Cells(CellIndex.TIME_STAMP).Text = AppModule.GetName_TIME_STAMP(e.Row.Cells(CellIndex.TIME_STAMP).Text)
            e.Row.Cells(CellIndex.UPDATE_DATE).Text = AppModule.GetName_UPDATE_DATE(e.Row.Cells(CellIndex.UPDATE_DATE).Text)
        End If
    End Sub

    'グリッドビュー列の表示設定
    Protected Sub GrvList_RowCreated(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles GrvList.RowCreated
        If e.Row.RowType = DataControlRowType.Header OrElse e.Row.RowType = DataControlRowType.Footer OrElse e.Row.RowType = DataControlRowType.DataRow Then
            e.Row.Cells(CellIndex.UPDATE_DATE).Visible = False
            e.Row.Cells(CellIndex.KOUENKAI_NO).Visible = False
            e.Row.Cells(CellIndex.TO_DATE).Visible = False
        ElseIf e.Row.RowType = DataControlRowType.Pager Then
            CType(e.Row.Controls(0), TableCell).ColumnSpan = CType(e.Row.Controls(0), TableCell).ColumnSpan - 3
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
            Case "Csv"
                '' ''データ取得                ' ''Joken.KOUENKAI_NO = e.CommandArgument
                ' ''Session.Item(SessionDef.Joken) = Joken
                ' ''Response.Redirect(URL.TaxiMeisaiCsv2)

                Dim CsvData() As TableDef.TaxiMeisaiCsv.DataStruct
                CsvData = GetCsvData(e.CommandArgument, Joken.TKT_ENTA, Joken.TKT_SEIKYU_YM, Joken.FROM_DATE)

                'ファイル名
                Dim wFileName As String = ""
                wFileName = e.CommandArgument
                If Me.JokenTKT_ENTA_N_Only.Checked = True Then
                    wFileName &= "_SeikyuFuka"
                Else
                End If
                wFileName &= "(過去データ).csv"

                Response.Clear()
                Response.ContentType = CmnConst.Csv.ContentType
                Response.ContentEncoding = Encoding.GetEncoding("Shift_JIS")
                Response.Charset = CmnConst.Csv.Charset
                Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & wFileName)
                Response.Write(CreateCsv(CsvData))
                Response.End()
        End Select
    End Sub

    'データ取得
    Private Function GetCsvData(ByVal KOUENKAI_NO As String, ByVal TKT_ENTA As String, ByVal TKT_SEIKYU_YM As String, ByVal FROM_DATE As String) As TableDef.TaxiMeisaiCsv.DataStruct()
        Dim CsvData() As TableDef.TaxiMeisaiCsv.DataStruct
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct
        Dim TBL_TAXITICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
        Dim TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = False

        '会合情報
        strSQL = SQL.TBL_KOUENKAI.byKOUENKAI_NO(KOUENKAI_NO)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.HasRows = False Then
            Response.Redirect(URL.TaxiMenu)
        Else
            RsData.Read()
            TBL_KOUENKAI = AppModule.SetRsData(RsData, TBL_KOUENKAI)
        End If
        RsData.Close()

        'タクチケ情報
        Joken.KOUENKAI_NO = KOUENKAI_NO
        Session.Item(SessionDef.Joken) = Joken
        strSQL = SQL.TBL_TAXITICKET_HAKKO.TaxiMeisaiCsv(Joken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        ReDim TBL_TAXITICKET_HAKKO(wCnt)
        While RsData.Read()
            wFlag = True
            ReDim Preserve TBL_TAXITICKET_HAKKO(wCnt)
            TBL_TAXITICKET_HAKKO(wCnt) = AppModule.SetRsData(RsData, TBL_TAXITICKET_HAKKO(wCnt))
            wCnt += 1
        End While
        RsData.Close()

        'csv用データにセット
        wCnt = 0
        ReDim CsvData(wCnt)
        If wFlag = False Then
            CsvData(wCnt).KOUENKAI_NO = ""
        Else
            For wCnt = LBound(TBL_TAXITICKET_HAKKO) To UBound(TBL_TAXITICKET_HAKKO)
                ReDim Preserve CsvData(wCnt)
                CsvData(wCnt).KOUENKAI_NAME = TBL_KOUENKAI.KOUENKAI_NAME
                CsvData(wCnt).WBS_ELEMENT_KOUENKAI = TBL_KOUENKAI.WBS_ELEMENT
                CsvData(wCnt).KIKAKU_TANTO_JIGYOUBU = TBL_KOUENKAI.KIKAKU_TANTO_JIGYOUBU
                CsvData(wCnt).KIKAKU_TANTO_AREA = TBL_KOUENKAI.KIKAKU_TANTO_AREA
                CsvData(wCnt).KIKAKU_TANTO_EIGYOSHO = TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO
                CsvData(wCnt).KIKAKU_TANTO_NAME = TBL_KOUENKAI.KIKAKU_TANTO_NAME
                CsvData(wCnt).KOUENKAI_NO = TBL_TAXITICKET_HAKKO(wCnt).KOUENKAI_NO
                CsvData(wCnt).STATUS = GetName_STATUS(TBL_TAXITICKET_HAKKO(wCnt).TKT_SEIKYU_YM, TBL_TAXITICKET_HAKKO(wCnt).TKT_VOID)
                CsvData(wCnt).TKT_KENSHU = GetNameTKT_KENSHU(TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU)
                CsvData(wCnt).TKT_NO = TBL_TAXITICKET_HAKKO(wCnt).TKT_NO
                CsvData(wCnt).TKT_LINE_NO = TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO
                CsvData(wCnt).TKT_URIAGE = TBL_TAXITICKET_HAKKO(wCnt).TKT_URIAGE
                CsvData(wCnt).TKT_ENTA = TBL_TAXITICKET_HAKKO(wCnt).TKT_ENTA
                CsvData(wCnt).TKT_HAKKO_FEE = TBL_TAXITICKET_HAKKO(wCnt).TKT_HAKKO_FEE
                CsvData(wCnt).TKT_SEISAN_FEE = TBL_TAXITICKET_HAKKO(wCnt).TKT_SEISAN_FEE
                CsvData(wCnt).TOTAL_KINGAKU = CmnModule.DbVal(TBL_TAXITICKET_HAKKO(wCnt).TKT_URIAGE) + CmnModule.DbVal(TBL_TAXITICKET_HAKKO(wCnt).TKT_SEISAN_FEE) + CmnModule.DbVal(TBL_TAXITICKET_HAKKO(wCnt).TKT_HAKKO_FEE).ToString
                CsvData(wCnt).TKT_SEIKYU_YM = CmnModule.Format_Date(TBL_TAXITICKET_HAKKO(wCnt).TKT_SEIKYU_YM, CmnModule.DateFormatType.YYYYMM)
                CsvData(wCnt).TKT_VOID = GetName_VOID(TBL_TAXITICKET_HAKKO(wCnt).TKT_VOID)
                CsvData(wCnt).TKT_MIKETSU = GetName_TKT_MIKETSU(TBL_TAXITICKET_HAKKO(wCnt).TKT_SEIKYU_YM, TBL_TAXITICKET_HAKKO(wCnt).TKT_MIKETSU)
                CsvData(wCnt).SANKASHA_ID = TBL_TAXITICKET_HAKKO(wCnt).SANKASHA_ID
                CsvData(wCnt).FROM_DATE = CmnModule.Format_Date(TBL_TAXITICKET_HAKKO(wCnt).FROM_DATE, CmnModule.DateFormatType.YYYYMMDD)
                CsvData(wCnt).TKT_USED_DATE = CmnModule.Format_Date(TBL_TAXITICKET_HAKKO(wCnt).TKT_USED_DATE, CmnModule.DateFormatType.YYYYMMDD)
                CsvData(wCnt).TKT_HATUTI = TBL_TAXITICKET_HAKKO(wCnt).TKT_HATUTI
                CsvData(wCnt).TKT_CHAKUTI = TBL_TAXITICKET_HAKKO(wCnt).TKT_CHAKUTI
                CsvData(wCnt).TKT_KAISHA = TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA
            Next wCnt
        End If

        '手配情報
        For wCnt = LBound(TBL_TAXITICKET_HAKKO) To UBound(TBL_TAXITICKET_HAKKO)
            If Trim(TBL_TAXITICKET_HAKKO(wCnt).SANKASHA_ID) <> "" AndAlso Val(TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO) <> 0 Then
                strSQL = SQL.TBL_KOTSUHOTEL.byTKT_NO_TKT_LINE_NO(TBL_TAXITICKET_HAKKO(wCnt).SANKASHA_ID, TBL_TAXITICKET_HAKKO(wCnt).TKT_NO, TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO)
                RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
                If RsData.HasRows Then
                    RsData.Read()
                    TBL_KOTSUHOTEL = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL)

                    Select Case CInt(CsvData(wCnt).TKT_LINE_NO).ToString
                        Case "1"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_1
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_1
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_1
                        Case "2"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_2
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_2
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_2
                        Case "3"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_3
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_3
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_3
                        Case "4"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_4
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_4
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_4
                        Case "5"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_5
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_5
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_5
                        Case "6"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_6
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_6
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_6
                        Case "7"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_7
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_7
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_7
                        Case "8"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_8
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_8
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_8
                        Case "9"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_9
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_9
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_9
                        Case "10"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_10
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_10
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_10
                        Case "11"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_11
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_11
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_11
                        Case "12"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_12
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_12
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_12
                        Case "13"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_13
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_13
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_13
                        Case "14"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_14
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_14
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_14
                        Case "15"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_15
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_15
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_15
                        Case "16"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_16
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_16
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_16
                        Case "17"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_17
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_17
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_17
                        Case "18"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_18
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_18
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_18
                        Case "19"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_19
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_19
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_19
                        Case "20"
                            CsvData(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_20
                            CsvData(wCnt).ANS_TAXI_RMKS = TBL_KOTSUHOTEL.ANS_TAXI_RMKS_20
                            CsvData(wCnt).ANS_TAXI_SRMKS = TBL_KOTSUHOTEL.ANS_TAXI_SRMKS_20
                    End Select
                    CsvData(wCnt).ANS_TAXI_DATE = CmnModule.Format_Date(CsvData(wCnt).ANS_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDD)
                    CsvData(wCnt).DR_SHISETSU_NAME = TBL_KOTSUHOTEL.DR_SHISETSU_NAME
                    CsvData(wCnt).DR_NAME = TBL_KOTSUHOTEL.DR_NAME
                    CsvData(wCnt).DR_SANKA = GetName_DR_SANKA(TBL_KOTSUHOTEL.DR_SANKA)
                    CsvData(wCnt).DR_CD = TBL_KOTSUHOTEL.DR_CD
                    'CsvData(wCnt).ACCOUNT_CD = TBL_KOTSUHOTEL.ACCOUNT_CD
                    CsvData(wCnt).KIHON_COST_CENTER = TBL_KOUENKAI.COST_CENTER
                    CsvData(wCnt).ACCOUNT_CD = TBL_KOUENKAI.ACCOUNT_CD_TF
                    CsvData(wCnt).KOTSU_COST_CENTER = TBL_KOTSUHOTEL.COST_CENTER
                    CsvData(wCnt).INTERNAL_ORDER = TBL_KOUENKAI.INTERNAL_ORDER_TF
                    CsvData(wCnt).ZETIA_CD = TBL_KOUENKAI.ZETIA_CD
                    CsvData(wCnt).MR_BU = TBL_KOTSUHOTEL.MR_BU
                    CsvData(wCnt).MR_AREA = TBL_KOTSUHOTEL.MR_AREA
                    CsvData(wCnt).MR_EIGYOSHO = TBL_KOTSUHOTEL.MR_EIGYOSHO
                    CsvData(wCnt).MR_NAME = TBL_KOTSUHOTEL.MR_NAME
                    CsvData(wCnt).DR_YAKUWARI = appmodule.GetName_DR_YAKUWARI(TBL_KOTSUHOTEL.DR_YAKUWARI)
                    CsvData(wCnt).WBS_ELEMENT = AppModule.GetName_WBS_ELEMENT(TBL_KOTSUHOTEL.WBS_ELEMENT)
                    CsvData(wCnt).REQ_TAXI_NOTE = AppModule.GetName_REQ_TAXI_NOTE(TBL_KOTSUHOTEL.REQ_TAXI_NOTE)
                    CsvData(wCnt).ANS_TAXI_NOTE = AppModule.GetName_ANS_TAXI_NOTE(TBL_KOTSUHOTEL.ANS_TAXI_NOTE)
                End If
                RsData.Close()
            End If
        Next wCnt

        Return CsvData
    End Function

    'csv出力
    Private Function CreateCsv(ByVal CsvData() As TableDef.TaxiMeisaiCsv.DataStruct) As String
        Dim wCnt As Integer = 0
        Dim sb As New System.Text.StringBuilder

        '表題
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("MTG No")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合 WBS Element")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("施設名")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR氏名")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR WBS Element")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("出欠")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("ステータス")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("券種(金額)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ番号")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("売上金額")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("エンタ")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("発行手数料")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算手数料")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("請求額")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算月")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("VOID")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者役割")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合参加者Id")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DRコード")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者BU")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者エリア")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者営業所")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合開始日")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("利用日(依頼)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("利用年月日")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実車発地")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実車着地")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("AccountCode(非課税)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当のCost Center")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Internal Order(非課税)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合のZetia Code")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR BU")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRエリア名")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR営業所")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR氏名")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Account Code(課税)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのCost Center")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ会社")))

        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("MTG No")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("施設名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DR氏名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("出欠")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("ステータス")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("券種(金額)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ番号")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("売上金額")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("エンタ")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("発行手数料")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算手数料")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("請求額")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算月")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("VOID")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者役割")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合参加者Id")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DRコード")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者BU")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者エリア")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者営業所")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合開始日")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("利用日(依頼)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("利用年月日")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("AccountCode(非課税)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当のCost Center")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Internal Order(非課税)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("WBS Element(非課税)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合のZetia Code")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR BU")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRエリア名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR営業所")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR氏名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Account Code(課税)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのCost Center")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ会社")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実績発地")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実績着地")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算コメント")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケTTT備考")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ備考(依頼)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ備考(回答)"), True))
        sb.Append(vbNewLine)

        '明細
        For wCnt = LBound(CsvData) To UBound(CsvData)
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SHISETSU_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SANKA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).STATUS)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_KENSHU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_NO)))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_URIAGE))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_ENTA)))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_HAKKO_FEE))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_SEISAN_FEE))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).TOTAL_KINGAKU))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_SEIKYU_YM))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_VOID))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_YAKUWARI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_CD)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_JIGYOUBU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_AREA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_EIGYOSHO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_NAME)))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).FROM_DATE))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).ANS_TAXI_DATE))
            sb.Append(CmnCsv.SetData(CsvData(wCnt).TKT_USED_DATE))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ACCOUNT_CD)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_COST_CENTER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INTERNAL_ORDER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).WBS_ELEMENT_KOUENKAI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZETIA_CD)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_BU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_AREA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_EIGYOSHO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("6833200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOTSU_COST_CENTER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_KAISHA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_HATUTI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_CHAKUTI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_SRMKS)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_TAXI_NOTE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NOTE)))
            sb.Append(vbNewLine)
        Next wCnt

        Return sb.ToString
    End Function

    Private Function GetNameTKT_KENSHU(ByVal TKT_KENSHU As String) As String
        If Not CmnCheck.IsNumberOnly(TKT_KENSHU) Then
            Return Mid(Trim(TKT_KENSHU), 3, 10)
        Else
            Return Trim(TKT_KENSHU)
        End If
    End Function
    Private Function GetName_DR_SANKA(ByVal DR_SANKA As String) As String
        If Trim(DR_SANKA) = AppConst.KOTSUHOTEL.DR_SANKA.Code.Yes Then
            Return "出席"
        ElseIf Trim(DR_SANKA) = AppConst.KOTSUHOTEL.DR_SANKA.Code.No Then
            Return "欠席"
        Else
            Return "出欠未照合"
        End If
    End Function
    Private Function GetName_TKT_MIKETSU(ByVal TKT_SEIKYU_YM As String, ByVal TKT_MIKETSU As String) As String
        If Trim(TKT_SEIKYU_YM) = "" AndAlso Trim(TKT_MIKETSU) = AppConst.TAXITICKET_HAKKO.TKT_MIKETSU.Code.Kanou Then
            Return "○"
        Else
            Return ""
        End If
    End Function
    Private Function GetName_STATUS(ByVal TKT_SEIKYU_YM As String, ByVal TKT_VOID As String) As String
        If Trim(TKT_SEIKYU_YM) <> "" Then
            Return "請求済"
        ElseIf Trim(TKT_VOID) <> CmnConst.Flag.Off Then
            Return "破棄済"
        Else
            Return "未請求"
        End If
    End Function
    Private Function GetName_XXX(ByVal ANS_TAXI_DATE As String, ByVal TKT_USERD_DATE As String) As String
        If Trim(ANS_TAXI_DATE) = "" OrElse Trim(TKT_USERD_DATE) = "" Then
            Return ""
        Else
            If Trim(ANS_TAXI_DATE) <> Trim(TKT_USERD_DATE) Then
                Return "請求対象外"
            Else
                Return "請求対象"
            End If
        End If
    End Function
    Private Function GetName_VOID(ByVal TKT_VOID As String) As String
        If Trim(TKT_VOID) = CmnConst.Flag.On Then
            Return "VOID"
        Else
            Return ""
        End If
    End Function

    Protected Sub GrvList_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles GrvList.SelectedIndexChanged

    End Sub
End Class
