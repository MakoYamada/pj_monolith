Imports CommonLib
Imports AppLib
Partial Public Class SapCsv
    Inherits WebBase

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '共通チェック
        MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

        If Not Page.IsPostBack Then

            '画面項目 初期化
            InitControls()
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "SAP用CSVデータ作成"
        End With
    End Sub

    '画面項目 初期化
    Private Sub InitControls()

        'IME設定
        CmnModule.SetIme(Me.JokenSHOUNIN_Y, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.JokenSHOUNIN_M, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SEIKYUSHO_NO, CmnModule.ImeType.Disabled)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '[CSV出力]
    Protected Sub BtnCSV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCSV.Click

        '入力チェック
        If Not Check() Then Exit Sub

        Dim SeikyuData() As TableDef.TBL_SEIKYU.DataStruct
        If GetData(SeikyuData) Then

            Dim CsvData() As TableDef.SAP_CSV.DataStruct = CreateCSVData(SeikyuData)

            'CSV出力            Response.Clear()
            Response.ContentType = CmnConst.Csv.ContentType
            Response.Charset = CmnConst.Csv.Charset
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & "Sap.csv")
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("utf-8")

            Response.Write(MyModule.Csv.SapCsv(CsvData)) 
            Response.End()
        End If

    End Sub

    '入力チェック
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

        If Not CmnCheck.IsInput(Me.SEIKYUSHO_NO) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("請求書番号"), Me)
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

        '日付妥当性
        If CmnCheck.IsInput(Me.JokenSHOUNIN_Y) OrElse CmnCheck.IsInput(Me.JokenSHOUNIN_M) Then
            Dim wStr As String = StrConv(Trim(Me.JokenSHOUNIN_Y.Text) & "/" & Trim(Me.JokenSHOUNIN_M.Text) & "/01", VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("承認年月"), Me)
                Return False
            End If
        End If

        Return True
    End Function

    'CSV用データ取得
    Private Function GetData(ByRef CsvData() As TableDef.TBL_SEIKYU.DataStruct) As Boolean
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim CsvData(wCnt)

        Dim Joken As TableDef.Joken.DataStruct
        Joken.SHOUNIN_YM = Me.JokenSHOUNIN_Y.Text & Me.JokenSHOUNIN_M.Text.PadLeft(2, "0"c)

        strSQL = SQL.TBL_SEIKYU.SapCsvMain(Joken)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True
            ReDim Preserve CsvData(wCnt)
            CsvData(wCnt) = AppModule.SetRsData(RsData, CsvData(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        If wFlag = False Then
            CmnModule.AlertMessage("対象データがありません。", Me)
            Return False
        End If

        Return True
    End Function

    'CSV出力用データの組立
    Private Function CreateCSVData(ByVal SeikyuData() As TableDef.TBL_SEIKYU.DataStruct) As TableDef.SAP_CSV.DataStruct()

        Dim csvData As TableDef.SAP_CSV.DataStruct()

        Dim lngTotalKingaku As Long = 0

        'タイトル行
        Dim rowCnt As Integer = 0
        ReDim csvData(rowCnt)
        csvData(rowCnt).KUBUN = "BKZ"
        csvData(rowCnt).KAISHA_CD = "BUKRS"
        csvData(rowCnt).SEIKYU_YMD = "BLDAT"
        csvData(rowCnt).DENPYO_TYPE = "BLART"
        csvData(rowCnt).SEIKYUSHO_NO = "XBLNR"
        csvData(rowCnt).DOC_HTEXT = "BKTXT"
        csvData(rowCnt).ACCOUNT = "NEWKO"
        csvData(rowCnt).KINGAKU = "WRBTR"
        csvData(rowCnt).ZEI_CD = "MWSKZ"
        csvData(rowCnt).COST_CENTER = "KOSTL"
        csvData(rowCnt).INTERNAL_ORDER = "AUFNR"
        csvData(rowCnt).KAIGOU_MEI = "SGTXT"
        csvData(rowCnt).PAYMENT_BLOCK = "ZLSPR"
        csvData(rowCnt).ZETIA_CD = "ZJP1"
        csvData(rowCnt).BARCODE = "BARCD"

        rowCnt += 1
        ReDim Preserve csvData(rowCnt)
        'csvData(1)には、2行目以降の金額を集計後、最後にデータをセットする。

        '2行目以降のデータを先に作成
        For wCnt As Integer = 0 To UBound(SeikyuData)

            '消費税コード取得
            Dim strSapZeiCd As String = AppModule.GetSapZeiCd(SeikyuData(wCnt).FROM_DATE, MyBase.DbConnection)

            If SeikyuData(wCnt).ROW_NO = 1 Then
                '講演会1回目の請求のとき
                If SeikyuData(wCnt).SRM_HACYU_KBN = AppConst.KAIJO.SRM_HACYU_KBN.Code.No Then
                    'SAP精算のとき
                    SetKaijoKotsuRecord(SeikyuData(wCnt), csvData, rowCnt, lngTotalKingaku, strSapZeiCd)
                End If

                'MR旅費
                SetMrRecord(SeikyuData(wCnt), csvData, rowCnt, lngTotalKingaku, strSapZeiCd, MyBase.DbConnection)
            End If

            'タクチケ
            '講演会に紐づくタクチケ料金を取得して、コストセンター分レコードを作成する
            SetTaxiRecord(SeikyuData(wCnt), csvData, rowCnt, lngTotalKingaku, strSapZeiCd, MyBase.DbConnection)
        Next

        '1行目
        csvData(1).KUBUN = "X"
        csvData(1).KAISHA_CD = "0094"
        csvData(1).SEIKYU_YMD = AppModule.GetName_SAP_SEIKYU_YMD(CmnModule.GetLastDateOfMonth(Me.JokenSHOUNIN_Y.Text, Me.JokenSHOUNIN_M.Text))
        csvData(1).DENPYO_TYPE = "KR"
        csvData(1).SEIKYUSHO_NO = Me.SEIKYUSHO_NO.Text
        csvData(1).DOC_HTEXT = "Top tour"
        csvData(1).ACCOUNT = "7007466"
        csvData(1).KINGAKU = lngTotalKingaku.ToString
        csvData(1).ZEI_CD = "**"
        csvData(1).COST_CENTER = ""
        csvData(1).INTERNAL_ORDER = ""
        csvData(1).KAIGOU_MEI = "Nozomi 一括請求" & Me.JokenSHOUNIN_M.Text & "月分"
        csvData(1).PAYMENT_BLOCK = "E"
        csvData(1).ZETIA_CD = ""
        csvData(1).BARCODE = ""

        Return csvData
    End Function

    '会場・機材と宿泊・交通のレコードを作成
    Private Sub SetKaijoKotsuRecord(ByVal SeikyuData As TableDef.TBL_SEIKYU.DataStruct, _
                                    ByRef csvData() As TableDef.SAP_CSV.DataStruct, _
                                    ByRef rowCnt As Integer, _
                                    ByRef lngTotalKingaku As Long, _
                                    ByVal strSapZeiCd As String)


        Dim Kingaku As Long = 0

        '会場・機材(非課税)レコード
        Kingaku = CLng(AppModule.GetName_ANS_991330401_TF(SeikyuData.KAIJOHI_TF, SeikyuData.KIZAIHI_TF, "0", True))
        lngTotalKingaku += Kingaku '金額加算

        rowCnt += 1
        ReDim Preserve csvData(rowCnt)
        csvData(rowCnt).KUBUN = ""
        csvData(rowCnt).KAISHA_CD = ""
        csvData(rowCnt).SEIKYU_YMD = ""
        csvData(rowCnt).DENPYO_TYPE = ""
        csvData(rowCnt).SEIKYUSHO_NO = ""
        csvData(rowCnt).DOC_HTEXT = ""
        csvData(rowCnt).ACCOUNT = SeikyuData.ACCOUNT_CD_TF
        csvData(rowCnt).KINGAKU = Kingaku.ToString
        csvData(rowCnt).ZEI_CD = strSapZeiCd
        csvData(rowCnt).COST_CENTER = SeikyuData.COST_CENTER
        csvData(rowCnt).INTERNAL_ORDER = SeikyuData.INTERNAL_ORDER_TF
        csvData(rowCnt).KAIGOU_MEI = SeikyuData.SHIHARAI_NO
        csvData(rowCnt).PAYMENT_BLOCK = ""
        csvData(rowCnt).ZETIA_CD = SeikyuData.ZETIA_CD
        csvData(rowCnt).BARCODE = ""


        '会場・機材(課税)レコード
        Kingaku = CLng(AppModule.GetName_ANS_991330401_T(SeikyuData.KAIJOUHI_T, SeikyuData.KIZAIHI_T, "0", True))
        lngTotalKingaku += Kingaku '金額加算

        rowCnt += 1
        ReDim Preserve csvData(rowCnt)
        csvData(rowCnt).KUBUN = ""
        csvData(rowCnt).KAISHA_CD = ""
        csvData(rowCnt).SEIKYU_YMD = ""
        csvData(rowCnt).DENPYO_TYPE = ""
        csvData(rowCnt).SEIKYUSHO_NO = ""
        csvData(rowCnt).DOC_HTEXT = ""
        csvData(rowCnt).ACCOUNT = SeikyuData.ACCOUNT_CD_T
        csvData(rowCnt).KINGAKU = Kingaku.ToString
        csvData(rowCnt).ZEI_CD = strSapZeiCd
        csvData(rowCnt).COST_CENTER = SeikyuData.COST_CENTER
        csvData(rowCnt).INTERNAL_ORDER = SeikyuData.INTERNAL_ORDER_T
        csvData(rowCnt).KAIGOU_MEI = SeikyuData.SHIHARAI_NO
        csvData(rowCnt).PAYMENT_BLOCK = ""
        csvData(rowCnt).ZETIA_CD = SeikyuData.ZETIA_CD
        csvData(rowCnt).BARCODE = ""


        '宿泊・交通・タクチケ(非課税)レコード
        Kingaku = CmnModule.DbVal(SeikyuData.KEI_41120200_TF)
        lngTotalKingaku += Kingaku '金額加算

        rowCnt += 1
        ReDim Preserve csvData(rowCnt)
        csvData(rowCnt).KUBUN = ""
        csvData(rowCnt).KAISHA_CD = ""
        csvData(rowCnt).SEIKYU_YMD = ""
        csvData(rowCnt).DENPYO_TYPE = ""
        csvData(rowCnt).SEIKYUSHO_NO = ""
        csvData(rowCnt).DOC_HTEXT = ""
        csvData(rowCnt).ACCOUNT = SeikyuData.ACCOUNT_CD_TF
        csvData(rowCnt).KINGAKU = Kingaku.ToString
        csvData(rowCnt).ZEI_CD = strSapZeiCd
        csvData(rowCnt).COST_CENTER = SeikyuData.COST_CENTER
        csvData(rowCnt).INTERNAL_ORDER = SeikyuData.INTERNAL_ORDER_TF
        csvData(rowCnt).KAIGOU_MEI = SeikyuData.SHIHARAI_NO
        csvData(rowCnt).PAYMENT_BLOCK = ""
        csvData(rowCnt).ZETIA_CD = SeikyuData.ZETIA_CD
        csvData(rowCnt).BARCODE = ""

    End Sub

    '講演会に紐づくMR旅費(課税)を取得して、コストセンター分レコードを作成する
    Private Sub SetMrRecord(ByVal SeikyuData As TableDef.TBL_SEIKYU.DataStruct, _
                                          ByRef csvData() As TableDef.SAP_CSV.DataStruct, _
                                          ByRef rowCnt As Integer, _
                                          ByRef lngTotalKingaku As Long, _
                                          ByVal strSapZeiCd As String, _
                                          ByVal DbConn As System.Data.SqlClient.SqlConnection)

        Dim MrData() As TableDef.TBL_KOTSUHOTEL.DataStruct
        If GetMrRyohiData(SeikyuData.KOUENKAI_NO, MrData, DbConn) Then

            For wCnt As Integer = 0 To UBound(MrData)

                Dim Kingaku As Long = CmnModule.DbVal(MrData(wCnt).ANS_MR_HOTELHI)
                lngTotalKingaku += Kingaku

                rowCnt += 1
                ReDim Preserve csvData(rowCnt)
                csvData(rowCnt).KUBUN = ""
                csvData(rowCnt).KAISHA_CD = ""
                csvData(rowCnt).SEIKYU_YMD = ""
                csvData(rowCnt).DENPYO_TYPE = ""
                csvData(rowCnt).SEIKYUSHO_NO = ""
                csvData(rowCnt).DOC_HTEXT = ""
                csvData(rowCnt).ACCOUNT = SeikyuData.ACCOUNT_CD_T
                csvData(rowCnt).KINGAKU = Kingaku.ToString
                csvData(rowCnt).ZEI_CD = strSapZeiCd
                csvData(rowCnt).COST_CENTER = MrData(wCnt).COST_CENTER
                csvData(rowCnt).INTERNAL_ORDER = SeikyuData.INTERNAL_ORDER_T
                csvData(rowCnt).KAIGOU_MEI = SeikyuData.SHIHARAI_NO
                csvData(rowCnt).PAYMENT_BLOCK = ""
                csvData(rowCnt).ZETIA_CD = SeikyuData.ZETIA_CD
                csvData(rowCnt).BARCODE = ""
            Next
        End If

    End Sub

    'MR旅費用データ取得
    Private Function GetMrRyohiData(ByVal strKouenkaiCd As String, _
                                    ByRef MrRyohiData() As TableDef.TBL_KOTSUHOTEL.DataStruct, _
                                    ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim MrRyohiData(wCnt)

        Dim Joken As TableDef.Joken.DataStruct
        Joken.KOUENKAI_NO = strKouenkaiCd

        strSQL = SQL.TBL_SEIKYU.SapCsvMrRyohi(Joken)
        RsData = CmnDb.Read(strSQL, DbConn)
        While RsData.Read()
            wFlag = True
            ReDim Preserve MrRyohiData(wCnt)
            MrRyohiData(wCnt) = AppModule.SetRsData(RsData, MrRyohiData(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag
    End Function

    'TODO:
    'タクチケシステムで使用するテーブルからコストセンターごとのSEIKYU_KINGAKU(仮)を取得しCSV出力する。
    'SetMrRecord()と同様の処理
    Private Sub SetTaxiRecord(ByVal SeikyuData As TableDef.TBL_SEIKYU.DataStruct, _
                                          ByRef csvData() As TableDef.SAP_CSV.DataStruct, _
                                          ByRef rowCnt As Integer, _
                                          ByRef lngTotalKingaku As Long, _
                                          ByVal strSapZeiCd As String, _
                                          ByVal DbConn As System.Data.SqlClient.SqlConnection)

        ''講演会番号と請求月をキーに課税対象(エンタ)のデータを抽出

        ''SeikyuDataのタクチケ(課税)金額と一致する必要があるが、チェックは必要？

        'Dim TaxiData() As TableDef.TBL_TAXI.DataStruct
        'If GetTaxiData(csvData.KOUENKAI_NO, TaxiData, DbConn) Then

        '    For wCnt As Integer = 0 To UBound(TaxiData)

        '        Dim Kingaku As Long = CmnModule.DbVal(TaxiData(wCnt).SEIKYU_KINGAKU)
        '        lngTotalKingaku += Kingaku

        '        rowCnt += 1
        '        ReDim Preserve csvData(rowCnt)
        '        csvData(rowCnt).KUBUN = ""
        '        csvData(rowCnt).KAISHA_CD = ""
        '        csvData(rowCnt).SEIKYU_YMD = ""
        '        csvData(rowCnt).DENPYO_TYPE = ""
        '        csvData(rowCnt).SEIKYUSHO_NO = ""
        '        csvData(rowCnt).DOC_HTEXT = ""
        '        csvData(rowCnt).ACCOUNT = SeikyuData.ACCOUNT_CD_T
        '        csvData(rowCnt).KINGAKU = Kingaku.ToString
        '        csvData(rowCnt).ZEI_CD = strSapZeiCd
        '        csvData(rowCnt).COST_CENTER = TaxiData(wCnt).COST_CENTER
        '        csvData(rowCnt).INTERNAL_ORDER = SeikyuData.INTERNAL_ORDER_T
        '        csvData(rowCnt).KAIGOU_MEI = SeikyuData.SHIHARAI_NO
        '        csvData(rowCnt).PAYMENT_BLOCK = ""
        '        csvData(rowCnt).ZETIA_CD = SeikyuData.ZETIA_CD
        '        csvData(rowCnt).BARCODE = ""
        '    Next

        'End If
    End Sub
    
End Class