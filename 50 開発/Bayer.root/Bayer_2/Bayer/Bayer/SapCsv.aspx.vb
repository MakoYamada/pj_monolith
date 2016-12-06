Imports CommonLib
Imports AppLib
Imports System.Runtime.Remoting.Messaging.AsyncResult
Partial Public Class SapCsv
    Inherits WebBase

    Private Const ZEI_CD_HIKAZEI As String = "98" '消費税コード(非課税)

    Private Const LEN_DocumentHeader As Integer = 6
    Private Const LEN_AccountCode As Integer = 2
    Private Const LEN_CostCenter As Integer = 7

    Dim SAP_DocumentHeader As String
    Dim SAP_AccountCode As String
    Dim SAP_CostCenter As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '遷移元チェック
        If Not Page.IsPostBack Then
            If Not MyModule.IsReferer(Request) Then
                Session.Abandon()
                Response.Redirect(URL.SorryPage)
            End If
        End If

        '共通チェック
        IsPageOK(False, Session.Item(SessionDef.LoginID), Me)

        'SAP管理マスタ取得 Phase3 Add
        Call GetSapKanri()

        If Not Page.IsPostBack Then

            '画面項目 初期化
            InitControls()
        End If

        Me.BtnDL.Visible = False
    End Sub

    '画面項目 初期化
    Private Sub InitControls()

        'IME設定
        CmnModule.SetIme(Me.JokenSHOUNIN_Y, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenSHOUNIN_M, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SEIKYU_Y, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SEIKYU_M, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SEIKYU_D, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.DOCUMENT_HEADER, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ACCOUNT_CODE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.COST_CENTER, CmnModule.ImeType.Disabled)

        'クリア
        CmnModule.ClearAllControl(Me)

        Me.LabelPageTitle.Text = "WPA用CSVデータ出力"
        Dim MS_USER As TableDef.MS_USER.DataStruct
        Try
            MS_USER = Session.Item(SessionDef.MS_USER)
        Catch ex As Exception
            Response.Redirect(URL.TimeOut)
        End Try

        Me.TblLoginUser.Visible = True
        Me.LabelLoginUser.Text = MS_USER.LOGIN_ID & "：" & MS_USER.USER_NAME & " 様"

        'SAP管理マスタ登録内容表示
        Me.DOCUMENT_HEADER.Text = SAP_DocumentHeader
        Me.ACCOUNT_CODE.Text = SAP_AccountCode
        Me.COST_CENTER.Text = SAP_CostCenter

        'CSVダウンロードボタン非表示(データ生成終了時に表示)
        Me.BtnDL.Visible = False
        BtnSapCSV.Visible = True
    End Sub

    '[SAP用CSV出力]
    Protected Sub BtnSapCSV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSapCSV.Click

        '入力チェック
        If Not Check() Then Exit Sub

        'SAP管理マスタ更新
        Dim MS_SAPKANRI As TableDef.MS_SAPKANRI.DataStruct
        MS_SAPKANRI.DATA_ID = AppConst.MS_SAPKANRI.DATA_ID.DocumentHeader
        MS_SAPKANRI.CODE = Me.DOCUMENT_HEADER.Text
        MS_SAPKANRI.UPDATE_USER = Session.Item(SessionDef.LoginID)
        Call UpdateSapKanri(MS_SAPKANRI)

        MS_SAPKANRI.DATA_ID = AppConst.MS_SAPKANRI.DATA_ID.AccountCode
        MS_SAPKANRI.CODE = Me.ACCOUNT_CODE.Text
        Call UpdateSapKanri(MS_SAPKANRI)

        MS_SAPKANRI.DATA_ID = AppConst.MS_SAPKANRI.DATA_ID.CostCenter
        MS_SAPKANRI.CODE = Me.COST_CENTER.Text
        Call UpdateSapKanri(MS_SAPKANRI)

        BtnSapCSV.Visible = False

        'デリゲートテーブル書込み
        Dim strSQL As String
        Dim TBL_DELIGATE2 As TableDef.TBL_DELIGATE2.DataStruct = Nothing
        TBL_DELIGATE2.LOGIN_ID = Session.Item(SessionDef.LoginID)
        TBL_DELIGATE2.CNT = "0"
        TBL_DELIGATE2.MAXCNT = "0"

        'ログインID存在チェック
        Dim RsData As System.Data.SqlClient.SqlDataReader
        strSQL = SQL.TBL_DELIGATE2.byLOGIN_ID(Session.Item(SessionDef.LoginID))
        RsData = CmnDb.ReadForDeligate(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            strSQL = SQL.TBL_DELIGATE2.Update(TBL_DELIGATE2)
        Else
            strSQL = SQL.TBL_DELIGATE2.Insert(TBL_DELIGATE2)
        End If
        RsData.Close()
        Try
            CmnDb.DbOpen(MyBase.DbConnection)
            CmnDb.ExecuteForDeligate(strSQL, MyBase.DbConnection)
        Catch ex As Exception
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        Dim Jisseki As CsvDelegate = New CsvDelegate(AddressOf CsvMethod)
        Dim callBack As New AsyncCallback(AddressOf CallBackMethod)

        Dim air As IAsyncResult = Jisseki.BeginInvoke(100, "yyyy/MM/dd hh:mm:ss", callBack, Nothing)

        Me.lblStatus.Text = "処理開始"
        '進捗確認用のjavascriptタイマー開始
        Me.ScriptManager1.RegisterStartupScript(Page, Page.GetType(), "Normal", "<script language='JavaScript'>StartTimer();</script>", False)
    End Sub

    Protected Sub BtnCsvRun_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCsvRun.Click
        Dim csvStr As String = String.Empty
        Dim wDB As SqlClient.SqlConnection
        wDB = New SqlClient.SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))
        Try
            CmnDb.DbOpen(wDB)
        Catch ex As Exception
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
            Exit Sub
        End Try

        '処理中件数取得
        Dim strSQL As String = String.Empty
        Dim RsDeligate As System.Data.SqlClient.SqlDataReader
        Dim TBL_DELIGATE2 As New TableDef.TBL_DELIGATE2.DataStruct

        Try
            strSQL = SQL.TBL_DELIGATE2.byLOGIN_ID(Session.Item(SessionDef.LoginID))
            RsDeligate = CmnDb.ReadForDeligate(strSQL, wDB)
            If RsDeligate.Read() Then
                TBL_DELIGATE2 = AppModule.SetRsData(RsDeligate, TBL_DELIGATE2)
            End If
            RsDeligate.Close()
        Catch ex As Exception
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        CmnDb.DbClose(wDB)
        wDB.Dispose()

        If Integer.Parse(TBL_DELIGATE2.CNT) = -1 Then

            Me.lblStatus.Text = "処理完了"
            Me.lblProgress.Text = "-"
            Me.BtnDL.Visible = True

            '進捗確認用のjavascriptタイマー停止
            Me.ScriptManager1.RegisterStartupScript(Page, Page.GetType(), "Normal", "<script language='JavaScript'>StopTimer();alert('完了しました。');</script>", False)

        Else
            Me.lblStatus.Text = "処理中・・・"
            Me.lblProgress.Text = TBL_DELIGATE2.CNT
        End If
    End Sub

#Region "入力チェック"

    'SAP用CSV出力入力時のチェック
    Private Function Check() As Boolean

        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        '必須入力
        If Not CmnCheck.IsInput(Me.JokenSHOUNIN_Y) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("承認年月(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.JokenSHOUNIN_M) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("承認年月(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.SEIKYU_Y) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("請求書発行日(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.SEIKYU_M) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("請求書発行日(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.SEIKYU_D) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("請求書発行日(日)"), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.DOCUMENT_HEADER) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("注文番号"), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.ACCOUNT_CODE) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("Account Code"), Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.COST_CENTER) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("Cost Center"), Me)
            Return False
        End If

        '桁数
        If Not CmnCheck.IsLengthEQ(Me.DOCUMENT_HEADER, 10) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthEQ("注文番号", 10), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthEQ(Me.ACCOUNT_CODE, 7) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthEQ("Account Code", 7), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthEQ(Me.COST_CENTER, 10) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthEQ("Cost Center", 10), Me)
            Return False
        End If

        '数値
        If Not CmnCheck.IsNumberOnly(Me.JokenSHOUNIN_Y) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("承認年月(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenSHOUNIN_M) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("承認年月(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.SEIKYU_Y) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("請求書発行日(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.SEIKYU_M) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("請求書発行日(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.SEIKYU_D) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("請求書発行日(日)"), Me)
            Return False
        End If

        '日付妥当性
        If CmnCheck.IsInput(Me.JokenSHOUNIN_Y) OrElse CmnCheck.IsInput(Me.JokenSHOUNIN_M) Then
            Dim wStr As String = StrConv(Trim(Me.JokenSHOUNIN_Y.Text) & "/" & Trim(Me.JokenSHOUNIN_M.Text) & "/01", VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("承認年月"), Me)
                Return False
            End If
        End If

        If CmnCheck.IsInput(Me.SEIKYU_Y) OrElse CmnCheck.IsInput(Me.SEIKYU_M) OrElse CmnCheck.IsInput(Me.SEIKYU_D) Then
            Dim wStr As String = StrConv(Trim(Me.SEIKYU_Y.Text) & "/" & Trim(Me.SEIKYU_M.Text) & "/" & Trim(Me.SEIKYU_D.Text), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("請求書発行日"), Me)
                Return False
            End If
        End If

        '内容
        If Left(Me.DOCUMENT_HEADER.Text, Me.LEN_DocumentHeader) <> Left(SAP_DocumentHeader, Me.LEN_DocumentHeader) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("注文番号の形式"), Me)
            Return False
        End If
        If Left(Me.ACCOUNT_CODE.Text, Me.LEN_AccountCode) <> Left(SAP_AccountCode, Me.LEN_AccountCode) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("Account Codeの形式"), Me)
            Return False
        End If
        If Left(Me.COST_CENTER.Text, Me.LEN_CostCenter) <> Left(SAP_CostCenter, Me.LEN_CostCenter) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("Cost Centerの形式"), Me)
            Return False
        End If

        Return True
    End Function
#End Region

#Region "SAP用CSV　処理"

    '非課税金額、課税金額のレコードを作成
    Private Sub SetKaijoKotsuRecord(ByVal SeikyuData As TableDef.TBL_SEIKYU.DataStruct, _
                                    ByRef csvData() As TableDef.SAP_CSV.DataStruct, _
                                    ByRef rowCnt As Integer, _
                                    ByRef lngTotalKingaku As Long, _
                                    ByVal strSapZeiCd As String, _
                                    ByVal isTopTour As Boolean, _
                                    ByVal sb As System.Text.StringBuilder)

        Dim Kingaku As Long = 0

        '非課税金額レコード(都税以外)
        'Kingaku = CmnModule.DbVal_Kingaku(SeikyuData.KAIJOHI_TF) + _
        '          CmnModule.DbVal_Kingaku(SeikyuData.INSHOKUHI_TF) + _
        '          CmnModule.DbVal_Kingaku(SeikyuData.KIZAIHI_TF) + _
        '          CmnModule.DbVal_Kingaku(SeikyuData.HOTELHI_TF) + _
        '          CmnModule.DbVal_Kingaku(SeikyuData.AIR_TF) + _
        '          CmnModule.DbVal_Kingaku(SeikyuData.JR_TF) + _
        '          CmnModule.DbVal_Kingaku(SeikyuData.OTHER_TRAFFIC_TF) + _
        '          CmnModule.DbVal_Kingaku(SeikyuData.JINKENHI_TF) + _
        '          CmnModule.DbVal_Kingaku(SeikyuData.KANRIHI_TF) + _
        '          CmnModule.DbVal_Kingaku(SeikyuData.HOTEL_COMMISSION_TF) + _
        '          CmnModule.DbVal_Kingaku(SeikyuData.TAXI_COMMISSION_TF) + _
        '          CmnModule.DbVal_Kingaku(SeikyuData.OTHER_TF) + _
        '          CmnModule.DbVal_Kingaku(SeikyuData.TAXI_TF) + _
        '          CmnModule.DbVal_Kingaku(SeikyuData.TAXI_SEISAN_TF)

        Kingaku = CmnModule.DbVal_Kingaku(SeikyuData.KEI_TF) - _
                CmnModule.DbVal_Kingaku(SeikyuData.HOTELHI_TOZEI)

        If Kingaku <> 0 Then
            lngTotalKingaku += Kingaku '金額加算

            Dim wPostingKey As String = AppConst.POSTING_KEY.Plus
            If Kingaku < 0 Then
                wPostingKey = AppConst.POSTING_KEY.Minus
                Kingaku = Kingaku * -1  '20161125 ADD(+/-はPostingKeyでのみ判断する)
            End If

            rowCnt += 1
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("L")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(wPostingKey)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.ACCOUNT_CD_TF)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(Kingaku.ToString & ".00")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.COST_CENTER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.SHIHARAI_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strSapZeiCd)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.INTERNAL_ORDER_TF)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.WBS_ELEMENT), True))
            sb.Append(vbNewLine)
        End If

        '非課税金額レコード(都税のみ)
        Kingaku = CmnModule.DbVal_Kingaku(SeikyuData.HOTELHI_TOZEI)
        If Kingaku <> 0 Then
            lngTotalKingaku += Kingaku '金額加算

            Dim wPostingKey As String = AppConst.POSTING_KEY.Plus
            If Kingaku < 0 Then
                wPostingKey = AppConst.POSTING_KEY.Minus
                Kingaku = Kingaku * -1
            End If

            rowCnt += 1
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("L")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(wPostingKey)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.ACCOUNT_CD_TF)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(Kingaku.ToString & ".00")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.COST_CENTER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.SHIHARAI_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(ZEI_CD_HIKAZEI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.INTERNAL_ORDER_TF)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.WBS_ELEMENT), True))
            sb.Append(vbNewLine)
        End If

        '課税金額(慰労会)レコード
        Kingaku = CmnModule.DbVal_Kingaku(SeikyuData.IROUKAIHI_T)
        If Kingaku <> 0 Then
            lngTotalKingaku += Kingaku '金額加算

            Dim wPostingKey As String = AppConst.POSTING_KEY.Plus
            If Kingaku < 0 Then
                wPostingKey = AppConst.POSTING_KEY.Minus
                Kingaku = Kingaku * -1
            End If

            rowCnt += 1
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("L")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(wPostingKey)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.ACCOUNT_CD_T)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(Kingaku.ToString & ".00")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("ENT")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.COST_CENTER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.SHIHARAI_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strSapZeiCd)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.INTERNAL_ORDER_T)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.WBS_ELEMENT), True))
            sb.Append(vbNewLine)
        End If

        '課税金額(慰労会以外)レコード
        'Kingaku = CmnModule.DbVal_Kingaku(SeikyuData.KEI_T)
        Kingaku = CmnModule.DbVal_Kingaku(SeikyuData.KEI_T) - CmnModule.DbVal_Kingaku(SeikyuData.IROUKAIHI_T)
        If Kingaku <> 0 Then
            lngTotalKingaku += Kingaku '金額加算

            Dim wPostingKey As String = AppConst.POSTING_KEY.Plus
            If Kingaku < 0 Then
                wPostingKey = AppConst.POSTING_KEY.Minus
                Kingaku = Kingaku * -1
            End If

            rowCnt += 1
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("L")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(wPostingKey)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.ACCOUNT_CD_T)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(Kingaku.ToString & ".00")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.COST_CENTER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.SHIHARAI_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strSapZeiCd)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.INTERNAL_ORDER_T)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.WBS_ELEMENT), True))
            sb.Append(vbNewLine)
        End If

    End Sub

    '会合に紐づくMR交通費(非課税)を取得して、コストセンター分レコードを作成する
    Private Sub SetMrRecord(ByVal SeikyuData As TableDef.TBL_SEIKYU.DataStruct, _
                                          ByRef csvData() As TableDef.SAP_CSV.DataStruct, _
                                          ByRef rowCnt As Integer, _
                                          ByRef lngTotalKingaku As Long, _
                                          ByVal strSapZeiCd As String, _
                                          ByVal DbConn As System.Data.SqlClient.SqlConnection, _
                                          ByVal isTopTour As Boolean, _
                                          ByVal sb As System.Text.StringBuilder)

        Dim MrData() As TableDef.TBL_KOTSUHOTEL.DataStruct
        If GetMrRyohiData(SeikyuData.KOUENKAI_NO, SeikyuData.SEIKYU_NO_TOPTOUR, MrData) Then

            For wCnt As Integer = 0 To UBound(MrData)

                Dim Kingaku As Long = 0

                '社員宿泊費+社員交通費
                'Kingaku = CmnModule.DbVal_Kingaku(MrData(wCnt).ANS_MR_HOTELHI)
                Kingaku = CmnModule.DbVal_Kingaku(MrData(wCnt).ANS_MR_KOTSUHI) '2014/12/11 UPDATE
                If Kingaku <> 0 Then
                    lngTotalKingaku += Kingaku

                    'rowCnt += 1
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("40")))
                    ''sb.Append(CmnCsv.SetData(CmnCsv.Quotes("6821200")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("6829000"))) '2015/1/6 UPDATE
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(Kingaku.ToString)))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strSapZeiCd)))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MrData(wCnt).COST_CENTER)))
                    'sb.Append(CmnCsv.SetData(""))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.SHIHARAI_NO)))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MrData(wCnt).ZETIA_CD)))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))

                    Dim wPostingKey As String = AppConst.POSTING_KEY.Plus
                    If Kingaku < 0 Then
                        wPostingKey = AppConst.POSTING_KEY.Minus
                        Kingaku = Kingaku * -1
                    End If

                    rowCnt += 1
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("L")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(wPostingKey)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("6829000")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(Kingaku.ToString & ".00")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MrData(wCnt).COST_CENTER)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.SHIHARAI_NO)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strSapZeiCd)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MrData(wCnt).INTERNAL_ORDER)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MrData(wCnt).WBS_ELEMENT), True))
                    sb.Append(vbNewLine)
                End If

                ''社員宿泊費都税のみ 2014/12/11 DELETE
                'Kingaku = CmnModule.DbVal_Kingaku(MrData(wCnt).ANS_MR_HOTELHI_TOZEI)
                'If Kingaku <> 0 Then
                '    '都税が0円以外のときのみレコード作成
                '    lngTotalKingaku += Kingaku

                '    rowCnt += 1
                '    ReDim Preserve csvData(rowCnt)
                '    csvData(rowCnt).KUBUN = ""
                '    csvData(rowCnt).KAISHA_CD = ""
                '    csvData(rowCnt).SEIKYU_YMD = ""
                '    csvData(rowCnt).DENPYO_TYPE = ""
                '    csvData(rowCnt).SEIKYUSHO_NO = ""
                '    csvData(rowCnt).DOC_HTEXT = ""
                '    csvData(rowCnt).WAERS = ""
                '    csvData(rowCnt).ZFBDT = ""
                '    csvData(rowCnt).ZTERM = ""
                '    csvData(rowCnt).XMWST = ""
                '    csvData(rowCnt).NEWBS = "40"
                '    csvData(rowCnt).ACCOUNT = "6821200"
                '    csvData(rowCnt).KINGAKU = Kingaku.ToString
                '    csvData(rowCnt).ZEI_CD = ZEI_CD_HIKAZEI
                '    csvData(rowCnt).COST_CENTER = MrData(wCnt).COST_CENTER
                '    csvData(rowCnt).INTERNAL_ORDER = MrData(wCnt).INTERNAL_ORDER
                '    csvData(rowCnt).KAIGOU_MEI = SeikyuData.SHIHARAI_NO
                '    csvData(rowCnt).PAYMENT_BLOCK = ""
                '    csvData(rowCnt).ZETIA_CD = MrData(wCnt).ZETIA_CD
                '    csvData(rowCnt).BARCODE = ""

                '    If isTopTour Then
                '        csvData(rowCnt).DANTAI_CODE = SeikyuData.DANTAI_CODE
                '        csvData(rowCnt).FROM_DATE = AppModule.GetName_KOUENKAI_DATE(SeikyuData.FROM_DATE, SeikyuData.TO_DATE, True)
                '        csvData(rowCnt).KOUENKAI_NO = SeikyuData.KOUENKAI_NO
                '        csvData(rowCnt).KOUENKAI_NAME = SeikyuData.KOUENKAI_NAME
                '        csvData(rowCnt).KIKAKU_TANTO_NAME = SeikyuData.KIKAKU_TANTO_NAME
                '    End If
                'End If
            Next
        End If

    End Sub

    '会合に紐づくMR宿泊費(非課税)を取得して、コストセンター分レコードを作成する 2014/12/11 ADD
    Private Sub SetMrHotelRecord(ByVal SeikyuData As TableDef.TBL_SEIKYU.DataStruct, _
                                          ByRef csvData() As TableDef.SAP_CSV.DataStruct, _
                                          ByRef rowCnt As Integer, _
                                          ByRef lngTotalKingaku As Long, _
                                          ByVal strSapZeiCd As String, _
                                          ByVal DbConn As System.Data.SqlClient.SqlConnection, _
                                          ByVal isTopTour As Boolean, _
                                          ByVal sb As System.Text.StringBuilder)

        Dim MrData() As TableDef.TBL_KOTSUHOTEL.DataStruct
        If GetMrHotelData(SeikyuData.KOUENKAI_NO, SeikyuData.SEIKYU_NO_TOPTOUR, MrData) Then

            For wCnt As Integer = 0 To UBound(MrData)

                Dim Kingaku As Long = 0

                '社員宿泊費
                Kingaku = CmnModule.DbVal_Kingaku(MrData(wCnt).ANS_MR_HOTELHI)
                If Kingaku <> 0 Then
                    lngTotalKingaku += Kingaku

                    'rowCnt += 1
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("40")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("6821400")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(Kingaku.ToString)))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strSapZeiCd)))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MrData(wCnt).COST_CENTER)))
                    'sb.Append(CmnCsv.SetData(""))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.SHIHARAI_NO)))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MrData(wCnt).ZETIA_CD)))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))

                    Dim wPostingKey As String = AppConst.POSTING_KEY.Plus
                    If Kingaku < 0 Then
                        wPostingKey = AppConst.POSTING_KEY.Minus
                        Kingaku = Kingaku * -1
                    End If

                    rowCnt += 1
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("L")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(wPostingKey)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("6821400")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(Kingaku.ToString & ".00")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MrData(wCnt).COST_CENTER)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.SHIHARAI_NO)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strSapZeiCd)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MrData(wCnt).INTERNAL_ORDER)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MrData(wCnt).WBS_ELEMENT), True))
                    sb.Append(vbNewLine)
                End If

                '社員宿泊費都税のみ
                Kingaku = CmnModule.DbVal_Kingaku(MrData(wCnt).ANS_MR_HOTELHI_TOZEI)
                If Kingaku <> 0 Then
                    '都税が0円以外のときのみレコード作成
                    lngTotalKingaku += Kingaku

                    'rowCnt += 1
                    'ReDim Preserve csvData(rowCnt)
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("40")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("6821400")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(Kingaku.ToString)))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(ZEI_CD_HIKAZEI)))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MrData(wCnt).COST_CENTER)))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.SHIHARAI_NO)))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MrData(wCnt).ZETIA_CD)))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                    'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))

                    Dim wPostingKey As String = AppConst.POSTING_KEY.Plus
                    If Kingaku < 0 Then
                        wPostingKey = AppConst.POSTING_KEY.Minus
                        Kingaku = Kingaku * -1
                    End If

                    rowCnt += 1
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("L")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(wPostingKey)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes("6821400")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(Kingaku.ToString & ".00")))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MrData(wCnt).COST_CENTER)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.SHIHARAI_NO)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(ZEI_CD_HIKAZEI)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MrData(wCnt).INTERNAL_ORDER)))
                    sb.Append(CmnCsv.SetData(CmnCsv.Quotes(MrData(wCnt).WBS_ELEMENT), True))
                    sb.Append(vbNewLine)
                End If
            Next
        End If

    End Sub

    'MR旅費用データ取得
    Private Function GetMrRyohiData(ByVal strKouenkaiNo As String, _
                                    ByVal strSeisanNo As String, _
                                    ByRef MrRyohiData() As TableDef.TBL_KOTSUHOTEL.DataStruct) As Boolean

        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        Dim wDB As SqlClient.SqlConnection
        wDB = New SqlClient.SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))
        Try
            CmnDb.DbOpen(wDB)
        Catch ex As Exception
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
            Exit Function
        End Try

        ReDim MrRyohiData(wCnt)
        Try
            strSQL = SQL.TBL_SEIKYU.SapCsvMrRyohi(strKouenkaiNo, strSeisanNo)
            RsData = CmnDb.ReadForDeligate(strSQL, wDB)
            While RsData.Read()
                wFlag = True
                ReDim Preserve MrRyohiData(wCnt)
                MrRyohiData(wCnt) = AppModule.SetRsData(RsData, MrRyohiData(wCnt))

                wCnt += 1
            End While
            RsData.Close()
            CmnDb.DbClose(wDB)
            wDB.Dispose()

        Catch ex As Exception
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        Return wFlag
    End Function

    'MR宿泊費用データ取得 2014/12/11 ADD
    Private Function GetMrHotelData(ByVal strKouenkaiNo As String, _
                                    ByVal strSeisanNo As String, _
                                    ByRef MrRyohiData() As TableDef.TBL_KOTSUHOTEL.DataStruct) As Boolean

        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False
        Dim wDB As SqlClient.SqlConnection
        wDB = New SqlClient.SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))
        Try
            CmnDb.DbOpen(wDB)
        Catch ex As Exception
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
            Exit Function
        End Try

        ReDim MrRyohiData(wCnt)
        Try
            strSQL = SQL.TBL_SEIKYU.SapCsvMrHotelhi(strKouenkaiNo, strSeisanNo)
            RsData = CmnDb.ReadForDeligate(strSQL, wDB)
            While RsData.Read()
                wFlag = True
                ReDim Preserve MrRyohiData(wCnt)
                MrRyohiData(wCnt) = AppModule.SetRsData(RsData, MrRyohiData(wCnt))

                wCnt += 1
            End While
            RsData.Close()
            CmnDb.DbClose(wDB)
            wDB.Dispose()
        Catch ex As Exception
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        Return wFlag
    End Function

    'タクチケ発行テーブルからコストセンターごとの金額を取得しCSV出力する。
    Private Sub SetTaxiRecord(ByVal SeikyuData As TableDef.TBL_SEIKYU.DataStruct, _
                                          ByRef csvData() As TableDef.SAP_CSV.DataStruct, _
                                          ByRef rowCnt As Integer, _
                                          ByRef lngTotalKingaku As Long, _
                                          ByVal strSapZeiCd As String, _
                                          ByVal DbConn As System.Data.SqlClient.SqlConnection, _
                                          ByVal isTopTour As Boolean, _
                                          ByVal sb As System.Text.StringBuilder)

        Dim TaxiData() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct

        If SeikyuData.KOUENKAI_NO.Trim = String.Empty OrElse _
            SeikyuData.SEIKYU_NO_TOPTOUR.Trim = String.Empty Then Exit Sub

        If GetTaxiData(SeikyuData.KOUENKAI_NO, SeikyuData.SEIKYU_NO_TOPTOUR, TaxiData) Then

            For wCnt As Integer = 0 To UBound(TaxiData)

                Dim Kingaku As Long = CmnModule.DbVal_Kingaku(TaxiData(wCnt).TKT_URIAGE)
                lngTotalKingaku += Kingaku

                'rowCnt += 1
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("40")))
                ''2015/2/10 UPDATE
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("6833200")))
                ''sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.ACCOUNT_CD_T)))
                ''2015/2/10 UPDATE END
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(Kingaku.ToString)))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strSapZeiCd)))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TaxiData(wCnt).COST_CENTER)))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.SHIHARAI_NO)))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.ZETIA_CD)))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
                'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))

                Dim wPostingKey As String = AppConst.POSTING_KEY.Plus
                If Kingaku < 0 Then
                    wPostingKey = AppConst.POSTING_KEY.Minus
                    Kingaku = Kingaku * -1
                End If

                rowCnt += 1
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes("L")))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(wPostingKey)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes("6833200")))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(Kingaku.ToString & ".00")))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TaxiData(wCnt).COST_CENTER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SeikyuData.SHIHARAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(strSapZeiCd)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty), True))
                sb.Append(vbNewLine)
            Next

        End If
    End Sub

    'タクチケ実車・精算料金(課税)のデータを抽出
    Private Function GetTaxiData(ByVal strKouenkaiNo As String, _
                                    ByVal strSeisanNo As String, _
                                    ByRef TaxiData() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct) As Boolean

        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False
        Dim wDB As SqlClient.SqlConnection
        wDB = New SqlClient.SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))
        Try
            CmnDb.DbOpen(wDB)
        Catch ex As Exception
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
            Exit Function
        End Try

        ReDim TaxiData(wCnt)
        Try
            strSQL = SQL.TBL_TAXITICKET_HAKKO.SapCsvTaxi(strKouenkaiNo, strSeisanNo)
            RsData = CmnDb.ReadForDeligate(strSQL, wDB)
            While RsData.Read()
                wFlag = True
                ReDim Preserve TaxiData(wCnt)
                TaxiData(wCnt) = AppModule.SetRsData(RsData, TaxiData(wCnt))

                wCnt += 1
            End While
            RsData.Close()
            CmnDb.DbClose(wDB)
            wDB.Dispose()

        Catch ex As Exception
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        Return wFlag

    End Function

#End Region


#Region "デリゲート"

    Delegate Function CsvDelegate(ByVal intLoop As Integer, ByRef format As String) As String

    ''' <summary>
    ''' SAP用CSV出力　非同期処理
    ''' </summary>
    ''' <param name="intLoop"></param>
    ''' <param name="format"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CsvMethod(ByVal intLoop As Integer, ByRef format As String) As String

        Dim rtnStr As String = String.Empty
        Dim strSQL As String = SQL.MS_CODE.AllData()
        Dim wDB As SqlClient.SqlConnection
        wDB = New SqlClient.SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))
        Try
            CmnDb.DbOpen(wDB)
        Catch ex As Exception
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
            Return False
        End Try

        '前回出力結果削除
        Dim TBL_BUNSEKICSV As TableDef.TBL_BUNSEKICSV.DataStruct = Nothing
        TBL_BUNSEKICSV.LOGIN_ID = Session.Item(SessionDef.LoginID)
        Dim strSQL3 As String = SQL.TBL_BUNSEKICSV.Delete(TBL_BUNSEKICSV)
        Try
            CmnDb.ExecuteForDeligate(strSQL3, wDB)
        Catch ex As Exception
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            CmnModule.AlertMessage("データ削除に失敗しました。", Me)
            Return False
        End Try

        '出力対象データ読込み
        Dim wCnt As Integer = 0
        Dim strSQL2 As String = ""
        Dim RsData2 As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False
        Dim lngTotalKingaku As Long = 0

        Dim fromDate As String = ""
        Dim toDate As String = ""
        Dim JokenSeikyuNo As String = ""
        MyModule.GetSeisanFromTo(Me.JokenSHOUNIN_Y.Text, Me.JokenSHOUNIN_M.Text, fromDate, toDate)

        strSQL2 = SQL.TBL_SEIKYU.SapCsvMain(fromDate, toDate)
        Try
            RsData2 = CmnDb.ReadForDeligate(strSQL2, wDB)

            If Not RsData2.HasRows Then
                RsData2.Close()
                CmnModule.AlertMessage("対象データがありません。", Me)
                Return False
            End If
        Catch ex As Exception
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
            Return False
        End Try

        'CSV出力内容生成
        Dim sb As New System.Text.StringBuilder

        'タイトル行1行目
        Dim rowCnt As Integer = 0
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("R")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Nozomi_" & Me.JokenSHOUNIN_M.Text.PadLeft(2, "0") & "_" & Me.JokenSHOUNIN_Y.Text.PadLeft(4, "0"))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Nozomi_一括請求" & Me.JokenSHOUNIN_M.Text.PadLeft(2, "0") & "月分")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty), True))
        sb.Append(vbNewLine)

        If Not Write_TBL_BUNSEKICSV(sb.ToString, rowCnt) Then
            RsData2.Close()
            CmnModule.AlertMessage("対象データ出力に失敗しました。LINE_NO=" & wCnt.ToString, Me)
            Exit Function
        End If
        sb.Remove(0, sb.Length)

        'タイトル行2行目
        rowCnt += 1
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("H")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(Me.SEIKYU_D.Text.PadLeft(2, "0") & "." & Me.SEIKYU_M.Text.PadLeft(2, "0") & "." & Me.SEIKYU_Y.Text.PadLeft(4, "0"))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(Me.SEIKYU_D.Text.PadLeft(2, "0") & "." & Me.SEIKYU_M.Text.PadLeft(2, "0") & "." & Me.SEIKYU_Y.Text.PadLeft(4, "0"))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("SA")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("JPY")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(Me.DOCUMENT_HEADER.Text)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("X")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty), True))
        sb.Append(vbNewLine)

        If Not Write_TBL_BUNSEKICSV(sb.ToString, rowCnt) Then
            RsData2.Close()
            CmnModule.AlertMessage("対象データ出力に失敗しました。LINE_NO=" & wCnt.ToString, Me)
            Exit Function
        End If
        sb.Remove(0, sb.Length)

        Dim i As Integer = 0
        Dim SeikyuData() As TableDef.TBL_SEIKYU.DataStruct
        Dim csvData() As TableDef.SAP_CSV.DataStruct
        rowCnt = 2

        '明細行2行目以降のデータを先に作成
        While RsData2.Read()
            'If wCnt = 20 Then
            '    Dim x As Integer = 0
            'End If

            ReDim Preserve SeikyuData(wCnt)
            SeikyuData(wCnt) = AppModule.SetRsData(RsData2, SeikyuData(wCnt))

            '消費税コード取得
            Dim strSapZeiCd As String = GetSapZeiCd(SeikyuData(wCnt).FROM_DATE)

            If SeikyuData(wCnt).SRM_HACYU_KBN = AppConst.KAIJO.SRM_HACYU_KBN.Code.No Then
                'SAP精算のとき
                SetKaijoKotsuRecord(SeikyuData(wCnt), csvData, rowCnt, lngTotalKingaku, strSapZeiCd, False, sb)
            End If

            'MR旅費
            SetMrRecord(SeikyuData(wCnt), csvData, rowCnt, lngTotalKingaku, strSapZeiCd, wDB, False, sb)
            'MR宿泊費(2014/12/11 ADD)
            SetMrHotelRecord(SeikyuData(wCnt), csvData, rowCnt, lngTotalKingaku, strSapZeiCd, wDB, False, sb)
            'タクチケ(課税)
            SetTaxiRecord(SeikyuData(wCnt), csvData, rowCnt, lngTotalKingaku, strSapZeiCd, wDB, False, sb)

            wCnt += 1
            'If wCnt = 21 Then
            '    wCnt = wCnt
            'End If

            'デリゲートテーブル書込み
            Dim TBL_DELIGATE2 As TableDef.TBL_DELIGATE2.DataStruct = Nothing
            TBL_DELIGATE2.LOGIN_ID = Session.Item(SessionDef.LoginID)
            TBL_DELIGATE2.CNT = wCnt.ToString
            strSQL = SQL.TBL_DELIGATE2.Update(TBL_DELIGATE2)
            Try
                CmnDb.ExecuteForDeligate(strSQL, MyBase.DbConnection)
            Catch ex As Exception
                Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
            End Try
            i += 1

            If i >= 1000 Then
                i = 0
                If Not Write_TBL_BUNSEKICSV(sb.ToString, rowCnt) Then
                    RsData2.Close()
                    CmnModule.AlertMessage("対象データ出力に失敗しました。LINE_NO=" & rowCnt.ToString, Me)
                    Exit Function
                End If
                sb.Remove(0, sb.Length)
            End If
        End While
        RsData2.Close()

        If Not Write_TBL_BUNSEKICSV(sb.ToString, rowCnt) Then
            RsData2.Close()
            CmnModule.AlertMessage("対象データ出力に失敗しました。LINE_NO=" & rowCnt.ToString, Me)
            Exit Function
        End If
        sb.Remove(0, sb.Length)

        MyModule.GetSeisanFromTo(Me.JokenSHOUNIN_Y.Text, Me.JokenSHOUNIN_M.Text, "", toDate)

        '明細行1行目
        rowCnt = 2
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("L")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("50")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SAP_AccountCode)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKingaku.ToString & ".00")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(SAP_CostCenter)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Nozomi 一括請求" & Me.JokenSHOUNIN_M.Text.PadLeft(2, "0") & "月分")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("98")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("V2")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(String.Empty), True))
        sb.Append(vbNewLine)

        rtnStr = sb.ToString

        '分析CSV出力用テーブル書込み
        If Not Write_TBL_BUNSEKICSV(sb.ToString, rowCnt) Then
            RsData2.Close()
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            CmnModule.AlertMessage("対象データ出力に失敗しました。LINE_NO=" & rowCnt.ToString, Me)
            Exit Function
        End If
        sb.Remove(0, sb.Length)
        CmnDb.DbClose(wDB)
        wDB.Dispose()

        Return rtnStr
    End Function

    ''' <summary>
    ''' 分析CSV出力用レコード書込み
    ''' </summary>
    ''' <param name="pStr"></param>
    ''' <param name="pCnt"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function Write_TBL_BUNSEKICSV(ByVal pStr As String, ByVal pCnt As Integer) As Boolean

        Dim TBL_BUNSEKICSV As TableDef.TBL_BUNSEKICSV.DataStruct = Nothing
        TBL_BUNSEKICSV.LOGIN_ID = Session.Item(SessionDef.LoginID)
        TBL_BUNSEKICSV.LINE_NO = pCnt.ToString
        TBL_BUNSEKICSV.LINE_DATA = pStr
        Dim strSQL As String = SQL.TBL_BUNSEKICSV.Insert(TBL_BUNSEKICSV)
        Dim wDB As SqlClient.SqlConnection
        wDB = New SqlClient.SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))

        Try
            CmnDb.DbOpen(wDB)
            CmnDb.ExecuteForDeligate(strSQL, wDB)
        Catch ex As Exception
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
            Return False
        End Try
        CmnDb.DbClose(wDB)
        wDB.Dispose()

        Return True
    End Function

    ''' <summary>
    ''' 実行完了時メソッド
    ''' </summary>
    ''' <param name="ar"></param>
    ''' <remarks></remarks>
    Private Sub CallBackMethod(ByVal ar As IAsyncResult)

        Dim asyncResult As System.Runtime.Remoting.Messaging.AsyncResult = CType(ar, System.Runtime.Remoting.Messaging.AsyncResult)
        Dim sample As CsvDelegate = asyncResult.AsyncDelegate
        Dim rtnStr As String = String.Empty

        Dim result As String = sample.EndInvoke(rtnStr, ar)

        '処理進捗リセット
        'デリゲートテーブル書込み
        Dim strSQL As String = ""
        Dim TBL_DELIGATE2 As TableDef.TBL_DELIGATE2.DataStruct = Nothing
        TBL_DELIGATE2.LOGIN_ID = Session.Item(SessionDef.LoginID)
        TBL_DELIGATE2.CNT = "-1"
        TBL_DELIGATE2.MAXCNT = "0"

        'ログインID存在チェック
        Dim wDB As SqlClient.SqlConnection
        wDB = New SqlClient.SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))
        Dim RsDeligate As System.Data.SqlClient.SqlDataReader
        strSQL = SQL.TBL_DELIGATE2.byLOGIN_ID(Session.Item(SessionDef.LoginID))
        Try
            CmnDb.DbOpen(wDB)
            RsDeligate = CmnDb.ReadForDeligate(strSQL, wDB)
            If RsDeligate.Read() Then
                strSQL = SQL.TBL_DELIGATE2.Update(TBL_DELIGATE2)
            Else
                strSQL = SQL.TBL_DELIGATE2.Insert(TBL_DELIGATE2)
            End If
            RsDeligate.Close()
            CmnDb.ExecuteForDeligate(strSQL, wDB)

        Catch ex As Exception
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try
        CmnDb.DbClose(wDB)
        wDB.Dispose()
    End Sub
#End Region

    '税率取得
    Private Function GetZeiRate(ByVal KIJUN_DATE As String, ByVal DbConn As System.Data.SqlClient.SqlConnection, Optional ByVal DbTrans As SqlClient.SqlTransaction = Nothing) As String

        Dim strZeiRate As String = "0"
        Dim MS_ZEI() As TableDef.MS_ZEI.DataStruct = GetZeiData(KIJUN_DATE)

        If Not MS_ZEI Is Nothing Then
            For Each record As TableDef.MS_ZEI.DataStruct In MS_ZEI
                If record.START_DATE <= KIJUN_DATE AndAlso KIJUN_DATE <= record.END_DATE Then
                    strZeiRate = record.ZEI_RATE
                    Exit For
                End If
            Next
        End If

        Return strZeiRate

    End Function

    'SAP用税コード取得
    Private Function GetSapZeiCd(ByVal KIJUN_DATE As String) As String

        Dim strSapZeiCd As String = ""
        Dim MS_ZEI() As TableDef.MS_ZEI.DataStruct = GetZeiData(KIJUN_DATE)

        If Not MS_ZEI Is Nothing Then
            For Each record As TableDef.MS_ZEI.DataStruct In MS_ZEI
                If record.START_DATE <= KIJUN_DATE AndAlso KIJUN_DATE <= record.END_DATE Then
                    strSapZeiCd = record.SAP_ZEI_CD
                    Exit For
                End If
            Next
        End If

        Return strSapZeiCd

    End Function

    '消費税データ取得
    Private Function GetZeiData(ByVal KIJUN_DATE As String, Optional ByVal DbTrans As SqlClient.SqlTransaction = Nothing) As TableDef.MS_ZEI.DataStruct()

        Dim wCnt As Integer = 0
        Dim MS_ZEI(wCnt) As TableDef.MS_ZEI.DataStruct
        Dim wFlag As Boolean = False

        Dim wDB As SqlClient.SqlConnection
        wDB = New SqlClient.SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))

        Dim strSQL As String = SQL.MS_ZEI.AllData
        Dim RsZei As System.Data.SqlClient.SqlDataReader

        Try
            CmnDb.DbOpen(wDB)
            If DbTrans Is Nothing Then
                RsZei = CmnDb.ReadForDeligate(strSQL, wDB)
            Else
                RsZei = CmnDbBatch.Read(strSQL, wDB, DbTrans)
            End If

            While RsZei.Read()
                wFlag = True
                ReDim Preserve MS_ZEI(wCnt)

                MS_ZEI(wCnt) = AppModule.SetRsData(RsZei, MS_ZEI(wCnt))
                wCnt += 1
            End While
            RsZei.Close()

        Catch ex As Exception
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        CmnDb.DbClose(wDB)
        wDB.Dispose()

        If wFlag Then
            Return MS_ZEI
        Else
            Return Nothing
        End If

    End Function

    'ページアクセス時のチェック
    Private Function IsPageOK(ByVal CheckUrlReferror As Boolean, ByVal LoginID As String, ByVal WebForm As Web.UI.Page, Optional ByVal AdminOnly As Boolean = True) As Boolean
        'URL直打ちチェック
        If CheckUrlReferror = True Then
            If System.Web.HttpContext.Current.Request.UrlReferrer Is Nothing Then
                System.Web.HttpContext.Current.Response.Redirect(URL.Login)
                Return False
            End If
        End If

        'セッションチェック
        If IsNothing(LoginID) = True OrElse Trim(LoginID) = "" Then
            System.Web.HttpContext.Current.Response.Redirect(URL.TimeOut)
            Return False
        End If

        'コードマスタ
        Dim MS_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wFlag As Boolean = False
        Try
            MS_CODE = System.Web.HttpContext.Current.Session(SessionDef.MS_CODE)
            If MS_CODE Is Nothing Then wFlag = True
        Catch ex As Exception
            wFlag = False
        End Try
        If wFlag = True Then
            'Nothingの場合、コードマスタ再取得
            MS_CODE = New List(Of TableDef.MS_CODE.DataStruct)

            Dim wDB As SqlClient.SqlConnection
            wDB = New SqlClient.SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))

            Dim strSQL As String = SQL.MS_CODE.AllData()
            Dim RsData As System.Data.SqlClient.SqlDataReader

            Try
                CmnDb.DbOpen(wDB)
                RsData = CmnDb.Read(strSQL, wDB)
                While RsData.Read()
                    Dim MS_CODE_Item As New TableDef.MS_CODE.DataStruct
                    With MS_CODE_Item
                        .CODE = CmnDb.DbData(TableDef.MS_CODE.Column.CODE, RsData)
                        .DATA_ID = CmnDb.DbData(TableDef.MS_CODE.Column.DATA_ID, RsData)
                        .DISP_VALUE = CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)
                        .DISP_TEXT = CmnDb.DbData(TableDef.MS_CODE.Column.DISP_TEXT, RsData)
                    End With
                    MS_CODE.Add(MS_CODE_Item)
                End While
                RsData.Close()
                System.Web.HttpContext.Current.Session.Item(SessionDef.MS_CODE) = MS_CODE
            Catch ex As Exception
                CmnDb.DbClose(wDB)
                wDB.Dispose()
                Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
            End Try
            CmnDb.DbClose(wDB)
            wDB.Dispose()
        End If

        Return True
    End Function

    Private Sub BtnDL_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDL.Click
        Dim UpdateFlag As Boolean = False
        Dim csvStr As String = String.Empty

        'CSV出力用データ取得
        Dim wDB As SqlClient.SqlConnection
        wDB = New SqlClient.SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))

        Dim strSQL As String = String.Empty
        Dim RsCsv As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_BUNSEKICSV.byLOGIN_ID(Session.Item(SessionDef.LoginID))
        Try
            CmnDb.DbOpen(wDB)
            RsCsv = CmnDb.ReadForDeligate(strSQL, wDB)
            While RsCsv.Read()
                Dim TBL_BUNSEKICSV As New TableDef.TBL_BUNSEKICSV.DataStruct
                TBL_BUNSEKICSV = AppModule.SetRsData(RsCsv, TBL_BUNSEKICSV)
                csvStr &= TBL_BUNSEKICSV.LINE_DATA
            End While
            RsCsv.Close()
        Catch ex As Exception
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        Dim RsDeligate As System.Data.SqlClient.SqlDataReader
        Dim TBL_DELIGATE2 As New TableDef.TBL_DELIGATE2.DataStruct

        strSQL = SQL.TBL_DELIGATE2.byLOGIN_ID(Session.Item(SessionDef.LoginID))
        Try
            CmnDb.DbOpen(wDB)
            RsDeligate = CmnDb.ReadForDeligate(strSQL, wDB)
            If RsDeligate.Read() Then
                UpdateFlag = True
                TBL_DELIGATE2 = AppModule.SetRsData(RsDeligate, TBL_DELIGATE2)
            End If
            RsDeligate.Close()
        Catch ex As Exception
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        TBL_DELIGATE2.LOGIN_ID = Session.Item(SessionDef.LoginID)
        TBL_DELIGATE2.CNT = "0"
        TBL_DELIGATE2.MAXCNT = "0"

        If UpdateFlag Then
            strSQL = SQL.TBL_DELIGATE2.Update(TBL_DELIGATE2)
        Else
            strSQL = SQL.TBL_DELIGATE2.Insert(TBL_DELIGATE2)
        End If
        Try
            CmnDb.DbOpen(wDB)
            CmnDb.ExecuteForDeligate(strSQL, wDB)
        Catch ex As Exception
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try
        CmnDb.DbClose(wDB)
        wDB.Dispose()

        'CSV出力
        Response.Clear()
        Response.ContentType = CmnConst.Csv.ContentType
        Response.Charset = CmnConst.Csv.Charset
        Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & HttpUtility.UrlEncode("WPA用CSV_" & Me.JokenSHOUNIN_Y.Text & Me.JokenSHOUNIN_M.Text & "_" & Now.ToString("yyyyMMddHHmmss") & ".csv"))
        Response.ContentEncoding = System.Text.Encoding.GetEncoding("utf-8")

        Response.Write(csvStr)
        Response.End()

        BtnDL.Visible = False
        BtnSapCSV.Visible = True
    End Sub

    ''' <summary>
    ''' SAP管理マスタデータ取得
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Sub GetSapKanri()
        Dim MS_SAPKANRI As TableDef.MS_SAPKANRI.DataStruct
        Dim wFlag As Boolean = False

        Dim wDB As SqlClient.SqlConnection
        wDB = New SqlClient.SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))

        Dim strSQL As String = SQL.MS_SAPKANRI.AllData
        Dim RsData As System.Data.SqlClient.SqlDataReader

        SAP_DocumentHeader = String.Empty
        SAP_AccountCode = String.Empty
        SAP_CostCenter = String.Empty

        Try
            CmnDb.DbOpen(wDB)
            RsData = CmnDb.ReadForDeligate(strSQL, wDB)

            While RsData.Read()
                wFlag = True
                MS_SAPKANRI = Nothing
                MS_SAPKANRI = AppModule.SetRsData(RsData, MS_SAPKANRI)
                Select Case MS_SAPKANRI.DATA_ID
                    Case AppConst.MS_SAPKANRI.DATA_ID.DocumentHeader
                        SAP_DocumentHeader = MS_SAPKANRI.CODE
                    Case AppConst.MS_SAPKANRI.DATA_ID.AccountCode
                        SAP_AccountCode = MS_SAPKANRI.CODE
                    Case AppConst.MS_SAPKANRI.DATA_ID.CostCenter
                        SAP_CostCenter = MS_SAPKANRI.CODE
                    Case Else
                End Select
            End While
            RsData.Close()

        Catch ex As Exception
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        CmnDb.DbClose(wDB)
        wDB.Dispose()
    End Sub

    Private Sub UpdateSapKanri(ByVal MS_SAPKANRI As TableDef.MS_SAPKANRI.DataStruct)

        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim strSQL As String = SQL.MS_SAPKANRI.byDATA_ID(AppConst.MS_SAPKANRI.DATA_ID.DocumentHeader)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            strSQL = SQL.MS_SAPKANRI.Update(MS_SAPKANRI)
        Else
            strSQL = SQL.MS_SAPKANRI.Insert(MS_SAPKANRI)
        End If
        RsData.Close()
        Try
            CmnDb.DbOpen(MyBase.DbConnection)
            CmnDb.Execute(strSQL, MyBase.DbConnection)
        Catch ex As Exception
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try
    End Sub
End Class