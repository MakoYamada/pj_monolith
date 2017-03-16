Imports CommonLib
Imports AppLib
Partial Public Class TaxiMenu
    Inherits WebBase

    Private MS_USER As TableDef.MS_USER.DataStruct

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
    End Sub

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        '共通チェック
        MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納
        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '不要なセッションを破棄
            MyModule.ClearSession()

            '画面項目 初期化
            InitControls()

            '画面項目表示
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "タクシーチケット管理メニュー"
        End With
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            MS_USER = Session.Item(SessionDef.MS_USER)
            If IsNothing(MS_USER) Then Return False
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        'クリア
        'CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
    End Sub
 
    '[タクチケ印刷データ作成]
    Protected Sub BtnTaxiPrintCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiPrintCsv.Click
        Response.Redirect(URL.TaxiPrintCsv)
    End Sub

    '[タクチケ納品データ取込]
    Private Sub BtnTaxiNouhinTorikomi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTaxiNouhinTorikomi.Click
        Response.Redirect(URL.TaxiNouhinTorikomi)
    End Sub

    '[タクチケ未決処理]
    Protected Sub BtnTaxiMiketsu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiMiketsu.Click
        Response.Redirect(URL.TaxiMiketsu)
    End Sub

    '[タクチケ実績未精算CSV出力]
    Protected Sub BtnTaxiMiseisanCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiMiseisanCsv.Click
        ' ''Response.Redirect(URL.TaxiJissekiMiseisanCsv)

        '出力対象データ読込み
        Dim CsvData() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim CsvData(wCnt)

        Dim fromDate As String = ""
        Dim toDate As String = ""

        strSQL = SQL.TBL_TAXITICKET_HAKKO.TaxiJissekiMiseisanCsv()
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True
            ReDim Preserve CsvData(wCnt)
            CsvData(wCnt) = AppModule.SetRsData(RsData, CsvData(wCnt))
            wCnt += 1
        End While
        RsData.Close()

        'ファイル名
        Dim wFileName As String = "タクチケ実績未精算_" & Now.ToString("yyyyMMddHHmmss") & ".csv"

        Response.Clear()
        Response.ContentType = CmnConst.Csv.ContentType
        Response.ContentEncoding = Encoding.GetEncoding("Shift_JIS")
        Response.Charset = CmnConst.Csv.Charset
        Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & HttpUtility.UrlEncode(wFileName))
        Response.Write(CreateCsv(CsvData))
        Response.End()

    End Sub

    '[タクチケスキャンデータ取込]
    Protected Sub BtnTaxiScan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiScan.Click
        Response.Redirect(URL.TaxiScan)
    End Sub

    '[タクチケメンテナンス]
    Protected Sub BtnTaxiMaintenance_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiMaintenance.Click
        Session.Item(SessionDef.DATA_MAINTENANCE) = CmnConst.Flag.Off
        Response.Redirect(URL.TaxiMaintenance)
    End Sub

    '[実績データ取込]
    Protected Sub BtnTaxiJisseki_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiJisseki.Click
        Response.Redirect(URL.TaxiJisseki)
    End Sub

    '[タクチケ管理台帳]
    Protected Sub BtnTaxiMeisaiCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiMeisaiCsv.Click
        Response.Redirect(URL.TaxiMeisaiCsv)
    End Sub

    '[精算未完了リスト]
    Protected Sub BtnTaxiMiseisan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiMiseisan.Click
        Response.Redirect(URL.TaxiMikanryou)
    End Sub

    '[送付状・確認票一括印刷]
    Protected Sub BtnTaxiSoufujoIkkatsu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiSoufujoIkkatsu.Click
        Response.Redirect(URL.TaxiSoufujoIkkatsu)
    End Sub

    '[その他実績データ取込]
    Protected Sub BtnTaxiJissekiOTH_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiJissekiOTH.Click
        Response.Redirect(URL.TaxiJissekiOTH)
    End Sub

    '@@@ 20170317 Add Start
    '[タクチケ精算用CSV取込]
    Protected Sub BtnTaxiSeisanImport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiSeisanImport.Click
        Response.Redirect(URL.TaxiSeisanImport)
    End Sub

    '[タクチケ自動精算指示]
    Protected Sub TaxiSeisanAuto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiSeisanAuto.Click
        Response.Redirect(URL.TaxiSeisanAuto)
    End Sub

    '[自動精算済タクチケCSV DL]
    Protected Sub BtnTaxiSeisanAutoCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiSeisanAutoCsv.Click
        Response.Redirect(URL.TaxiSeisanAutoCsv)
    End Sub

    '[総合精算書PDF DL]
    Protected Sub BtnSeisanshoAuto_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSeisanshoAuto.Click
        Response.Redirect(URL.SeisanshoAuto)
    End Sub

    '[Nozomi送信対象精算データ取込]
    Protected Sub BtnTaxiSeisanToNozomi_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTaxiSeisanToNozomi.Click
        Response.Redirect(URL.TaxiSeisanToNozomi)
    End Sub
    '@@@ 20170317 Add End

    'タクチケ未精算csv出力
    Private Function CreateCsv(ByVal CsvData() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct) As String
        Dim wCnt As Integer = 0
        Dim sb As New System.Text.StringBuilder

        '表題        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシー会社")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクシーチケット番号")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("券種")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者ID")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("交通手配タクチケ行番号")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("利用日")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実車発地")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("実車着地")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("売上金額")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算手数料")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("発行手数料")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("エンタ")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("VOID")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("未決フラグ")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("取込日")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("請求年月")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算番号")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("登録日時")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("登録者")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("更新日時")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("更新者"), True))
        sb.Append(vbNewLine)

        '明細
        For wCnt = LBound(CsvData) To UBound(CsvData)
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_KAISHA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_KENSHU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_LINE_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_DateJP(CsvData(wCnt).TKT_USED_DATE, CmnModule.DateFormatType.YYYYMMDD))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_HATUTI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_CHAKUTI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_URIAGE))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_SEISAN_FEE))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_HAKKO_FEE))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_ENTA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_VOID)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_MIKETSU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_DateJP(CsvData(wCnt).TKT_IMPORT_DATE, CmnModule.DateFormatType.YYYYMMDD))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_DateJP(CsvData(wCnt).TKT_SEIKYU_YM, CmnModule.DateFormatType.YYYYMM))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEIKYU_NO_TOPTOUR)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INPUT_DATE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INPUT_USER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).UPDATE_DATE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).UPDATE_USER), True))
            sb.Append(vbNewLine)
        Next wCnt

        Return sb.ToString
    End Function
End Class
