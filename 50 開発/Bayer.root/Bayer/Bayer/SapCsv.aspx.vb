Imports CommonLib
Imports AppLib
Partial Public Class SapCsv
    Inherits WebBase

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

    '[SAP用CSV出力]
    Protected Sub BtnSapCSV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSapCSV.Click

        '入力チェック
        If Not Check() Then Exit Sub

        '請求書番号必須入力
        If Not CmnCheck.IsInput(Me.SEIKYUSHO_NO) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("請求書番号"), Me)
            Exit Sub
        End If

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

    '[Toptour用CSV出力]
    Protected Sub BtnTopCSV_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTopCSV.Click

        '入力チェック
        If Not Check() Then Exit Sub

        Dim SeikyuData() As TableDef.TBL_SEIKYU.DataStruct
        If GetData(SeikyuData) Then

            Dim CsvData() As TableDef.SAP_CSV.DataStruct = CreateCSVData(SeikyuData, True)

            'CSV出力            Response.Clear()
            Response.ContentType = CmnConst.Csv.ContentType
            Response.Charset = CmnConst.Csv.Charset
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & HttpUtility.UrlEncode("Sap_TopTour用.csv"))
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-jis")

            Response.Write(MyModule.Csv.SapTopTourCsv(CsvData))
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

        Dim fromDate As String = ""
        Dim toDate As String = ""
        MyModule.GetSeisanFromTo(Me.JokenSHOUNIN_Y.Text, Me.JokenSHOUNIN_M.Text, fromDate, toDate)

        strSQL = SQL.TBL_SEIKYU.SapCsvMain(fromDate, toDate)
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
    Private Function CreateCSVData(ByVal SeikyuData() As TableDef.TBL_SEIKYU.DataStruct, Optional ByVal isTopTour As Boolean = False) As TableDef.SAP_CSV.DataStruct()

        Dim csvData As TableDef.SAP_CSV.DataStruct()

        Dim lngTotalKingaku As Long = 0

        'タイトル行1行目
        Dim rowCnt As Integer = 0
        ReDim csvData(rowCnt)
        csvData(rowCnt).KUBUN = TableDef.SAP_CSV.Name.KUBUN
        csvData(rowCnt).KAISHA_CD = TableDef.SAP_CSV.Name.KAISHA_CD
        csvData(rowCnt).SEIKYU_YMD = TableDef.SAP_CSV.Name.SEIKYU_YMD
        csvData(rowCnt).DENPYO_TYPE = TableDef.SAP_CSV.Name.DENPYO_TYPE
        csvData(rowCnt).SEIKYUSHO_NO = TableDef.SAP_CSV.Name.SEIKYUSHO_NO
        csvData(rowCnt).DOC_HTEXT = TableDef.SAP_CSV.Name.DOC_HTEXT
        csvData(rowCnt).ACCOUNT = TableDef.SAP_CSV.Name.ACCOUNT
        csvData(rowCnt).KINGAKU = TableDef.SAP_CSV.Name.KINGAKU
        csvData(rowCnt).ZEI_CD = TableDef.SAP_CSV.Name.ZEI_CD
        csvData(rowCnt).COST_CENTER = TableDef.SAP_CSV.Name.COST_CENTER
        csvData(rowCnt).INTERNAL_ORDER = TableDef.SAP_CSV.Name.INTERNAL_ORDER
        csvData(rowCnt).KAIGOU_MEI = TableDef.SAP_CSV.Name.KAIGOU_MEI
        csvData(rowCnt).PAYMENT_BLOCK = TableDef.SAP_CSV.Name.PAYMENT_BLOCK
        csvData(rowCnt).ZETIA_CD = TableDef.SAP_CSV.Name.ZETIA_CD
        csvData(rowCnt).BARCODE = TableDef.SAP_CSV.Name.BARCODE
        If isTopTour Then
            csvData(rowCnt).DANTAI_CODE = TableDef.SAP_CSV.Name.DANTAI_CODE
            csvData(rowCnt).FROM_DATE = TableDef.SAP_CSV.Name.FROM_DATE
            csvData(rowCnt).KOUENKAI_NO = TableDef.SAP_CSV.Name.KOUENKAI_NO
            csvData(rowCnt).KOUENKAI_NAME = TableDef.SAP_CSV.Name.KOUENKAI_NAME
            csvData(rowCnt).KIKAKU_TANTO_NAME = TableDef.SAP_CSV.Name.KIKAKU_TANTO_NAME
        End If

        'タイトル行2行目
        rowCnt += 1
        ReDim Preserve csvData(rowCnt)
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
        'このレコードには、明細行2行目以降の金額を集計後、最後にデータをセットする。

        '明細行2行目以降のデータを先に作成
        For wCnt As Integer = 0 To UBound(SeikyuData)

            '消費税コード取得
            Dim strSapZeiCd As String = AppModule.GetSapZeiCd(SeikyuData(wCnt).FROM_DATE, MyBase.DbConnection)

            If SeikyuData(wCnt).SRM_HACYU_KBN = AppConst.KAIJO.SRM_HACYU_KBN.Code.No Then
                'SAP精算のとき
                SetKaijoKotsuRecord(SeikyuData(wCnt), csvData, rowCnt, lngTotalKingaku, strSapZeiCd, isTopTour)
            End If

            'MR旅費
            SetMrRecord(SeikyuData(wCnt), csvData, rowCnt, lngTotalKingaku, strSapZeiCd, MyBase.DbConnection, isTopTour)
            'タクチケ(課税)
            SetTaxiRecord(SeikyuData(wCnt), csvData, rowCnt, lngTotalKingaku, strSapZeiCd, MyBase.DbConnection, isTopTour)
        Next

        Dim toDate As String = ""
        MyModule.GetSeisanFromTo(Me.JokenSHOUNIN_Y.Text, Me.JokenSHOUNIN_M.Text, "", toDate)

        '明細行1行目
        rowCnt = 2
        csvData(rowCnt).KUBUN = "X"
        csvData(rowCnt).KAISHA_CD = "0094"
        csvData(rowCnt).SEIKYU_YMD = AppModule.GetName_SAP_SEIKYU_YMD(toDate)
        csvData(rowCnt).DENPYO_TYPE = "KR"
        csvData(rowCnt).SEIKYUSHO_NO = Me.SEIKYUSHO_NO.Text
        csvData(rowCnt).DOC_HTEXT = "Top tour"
        csvData(rowCnt).ACCOUNT = "7007466"
        csvData(rowCnt).KINGAKU = lngTotalKingaku.ToString
        csvData(rowCnt).ZEI_CD = "**"
        csvData(rowCnt).COST_CENTER = ""
        csvData(rowCnt).INTERNAL_ORDER = ""
        csvData(rowCnt).KAIGOU_MEI = "Nozomi 一括請求" & Me.JokenSHOUNIN_M.Text & "月分"
        csvData(rowCnt).PAYMENT_BLOCK = "E"
        csvData(rowCnt).ZETIA_CD = ""
        csvData(rowCnt).BARCODE = ""

        Return csvData
    End Function

    '非課税金額、課税金額のレコードを作成
    Private Sub SetKaijoKotsuRecord(ByVal SeikyuData As TableDef.TBL_SEIKYU.DataStruct, _
                                    ByRef csvData() As TableDef.SAP_CSV.DataStruct, _
                                    ByRef rowCnt As Integer, _
                                    ByRef lngTotalKingaku As Long, _
                                    ByVal strSapZeiCd As String, _
                                    ByVal isTopTour As Boolean)

        Dim Kingaku As Long = 0

        '非課税金額レコード
        Kingaku = CmnModule.DbVal_Kingaku(SeikyuData.KEI_TF)
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
        If isTopTour Then
            csvData(rowCnt).DANTAI_CODE = SeikyuData.DANTAI_CODE
            csvData(rowCnt).FROM_DATE = AppModule.GetName_KOUENKAI_DATE(SeikyuData.FROM_DATE, SeikyuData.TO_DATE, True)
            csvData(rowCnt).KOUENKAI_NO = SeikyuData.KOUENKAI_NO
            csvData(rowCnt).KOUENKAI_NAME = SeikyuData.KOUENKAI_NAME
            csvData(rowCnt).KIKAKU_TANTO_NAME = SeikyuData.KIKAKU_TANTO_NAME
        End If


        '課税金額レコード
        Kingaku = CmnModule.DbVal_Kingaku(SeikyuData.KEI_T)
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
        If isTopTour Then
            csvData(rowCnt).DANTAI_CODE = SeikyuData.DANTAI_CODE
            csvData(rowCnt).FROM_DATE = AppModule.GetName_KOUENKAI_DATE(SeikyuData.FROM_DATE, SeikyuData.TO_DATE, True)
            csvData(rowCnt).KOUENKAI_NO = SeikyuData.KOUENKAI_NO
            csvData(rowCnt).KOUENKAI_NAME = SeikyuData.KOUENKAI_NAME
            csvData(rowCnt).KIKAKU_TANTO_NAME = SeikyuData.KIKAKU_TANTO_NAME
        End If

    End Sub

    '会合に紐づくMR旅費(課税)を取得して、コストセンター分レコードを作成する
    Private Sub SetMrRecord(ByVal SeikyuData As TableDef.TBL_SEIKYU.DataStruct, _
                                          ByRef csvData() As TableDef.SAP_CSV.DataStruct, _
                                          ByRef rowCnt As Integer, _
                                          ByRef lngTotalKingaku As Long, _
                                          ByVal strSapZeiCd As String, _
                                          ByVal DbConn As System.Data.SqlClient.SqlConnection, _
                                          ByVal isTopTour As Boolean)

        Dim MrData() As TableDef.TBL_KOTSUHOTEL.DataStruct
        If GetMrRyohiData(SeikyuData.KOUENKAI_NO, SeikyuData.SEIKYU_NO_TOPTOUR, MrData, DbConn) Then

            For wCnt As Integer = 0 To UBound(MrData)

                Dim Kingaku As Long = CmnModule.DbVal_Kingaku(MrData(wCnt).ANS_MR_HOTELHI)
                lngTotalKingaku += Kingaku

                rowCnt += 1
                ReDim Preserve csvData(rowCnt)
                csvData(rowCnt).KUBUN = ""
                csvData(rowCnt).KAISHA_CD = ""
                csvData(rowCnt).SEIKYU_YMD = ""
                csvData(rowCnt).DENPYO_TYPE = ""
                csvData(rowCnt).SEIKYUSHO_NO = ""
                csvData(rowCnt).DOC_HTEXT = ""
                csvData(rowCnt).ACCOUNT = "6821200"
                csvData(rowCnt).KINGAKU = Kingaku.ToString
                csvData(rowCnt).ZEI_CD = strSapZeiCd
                csvData(rowCnt).COST_CENTER = MrData(wCnt).COST_CENTER
                csvData(rowCnt).INTERNAL_ORDER = MrData(wCnt).INTERNAL_ORDER
                csvData(rowCnt).KAIGOU_MEI = SeikyuData.SHIHARAI_NO
                csvData(rowCnt).PAYMENT_BLOCK = ""
                csvData(rowCnt).ZETIA_CD = MrData(wCnt).ZETIA_CD
                csvData(rowCnt).BARCODE = ""

                If isTopTour Then
                    csvData(rowCnt).DANTAI_CODE = SeikyuData.DANTAI_CODE
                    csvData(rowCnt).FROM_DATE = AppModule.GetName_KOUENKAI_DATE(SeikyuData.FROM_DATE, SeikyuData.TO_DATE, True)
                    csvData(rowCnt).KOUENKAI_NO = SeikyuData.KOUENKAI_NO
                    csvData(rowCnt).KOUENKAI_NAME = SeikyuData.KOUENKAI_NAME
                    csvData(rowCnt).KIKAKU_TANTO_NAME = SeikyuData.KIKAKU_TANTO_NAME
                End If
            Next
        End If

    End Sub

    'MR旅費用データ取得
    Private Function GetMrRyohiData(ByVal strKouenkaiNo As String, _
                                    ByVal strSeisanNo As String, _
                                    ByRef MrRyohiData() As TableDef.TBL_KOTSUHOTEL.DataStruct, _
                                    ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim MrRyohiData(wCnt)

        strSQL = SQL.TBL_SEIKYU.SapCsvMrRyohi(strKouenkaiNo, strSeisanNo)
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

    'タクチケ発行テーブルからコストセンターごとの金額を取得しCSV出力する。
    Private Sub SetTaxiRecord(ByVal SeikyuData As TableDef.TBL_SEIKYU.DataStruct, _
                                          ByRef csvData() As TableDef.SAP_CSV.DataStruct, _
                                          ByRef rowCnt As Integer, _
                                          ByRef lngTotalKingaku As Long, _
                                          ByVal strSapZeiCd As String, _
                                          ByVal DbConn As System.Data.SqlClient.SqlConnection, _
                                          ByVal isTopTour As Boolean)

        Dim TaxiData() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
        If GetTaxiData(SeikyuData.KOUENKAI_NO, SeikyuData.SEIKYU_NO_TOPTOUR, TaxiData, DbConn) Then

            For wCnt As Integer = 0 To UBound(TaxiData)

                Dim Kingaku As Long = CmnModule.DbVal_Kingaku(TaxiData(wCnt).TKT_URIAGE)
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
                csvData(rowCnt).COST_CENTER = TaxiData(wCnt).COST_CENTER
                csvData(rowCnt).INTERNAL_ORDER = ""
                csvData(rowCnt).KAIGOU_MEI = SeikyuData.SHIHARAI_NO
                csvData(rowCnt).PAYMENT_BLOCK = ""
                csvData(rowCnt).ZETIA_CD = SeikyuData.ZETIA_CD
                csvData(rowCnt).BARCODE = ""

                If isTopTour Then
                    csvData(rowCnt).DANTAI_CODE = SeikyuData.DANTAI_CODE
                    csvData(rowCnt).FROM_DATE = AppModule.GetName_KOUENKAI_DATE(SeikyuData.FROM_DATE, SeikyuData.TO_DATE, True)
                    csvData(rowCnt).KOUENKAI_NO = SeikyuData.KOUENKAI_NO
                    csvData(rowCnt).KOUENKAI_NAME = SeikyuData.KOUENKAI_NAME
                    csvData(rowCnt).KIKAKU_TANTO_NAME = SeikyuData.KIKAKU_TANTO_NAME
                End If

            Next

        End If
    End Sub

    'タクチケ実車・精算料金(課税)のデータを抽出
    Private Function GetTaxiData(ByVal strKouenkaiNo As String, _
                                    ByVal strSeisanNo As String, _
                                    ByRef TaxiData() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct, _
                                    ByVal DbConn As System.Data.SqlClient.SqlConnection) As Boolean

        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim TaxiData(wCnt)

        strSQL = SQL.TBL_TAXITICKET_HAKKO.SapCsvTaxi(strKouenkaiNo, strSeisanNo)
        RsData = CmnDb.Read(strSQL, DbConn)
        While RsData.Read()
            wFlag = True
            ReDim Preserve TaxiData(wCnt)
            TaxiData(wCnt) = AppModule.SetRsData(RsData, TaxiData(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag

    End Function

End Class