Imports CommonLib
Imports AppLib
Partial Public Class TaxiPrintCsv
    Inherits WebBase

    <Serializable()> Private Structure AnsTaxiStructure
        Implements IComparable
        Dim TAXI_DATE As String
        Dim TAXI_KENSHU As String
        Dim TAXI_HAKKO_DATE As String
        Dim TAXI_HAKKO As String
        Dim TKT_LINE_NO As Integer
        Public Function CompareTo(ByVal obj As Object) As Integer Implements IComparable.CompareTo
            Return Me.TAXI_DATE.CompareTo(DirectCast(obj, AnsTaxiStructure).TAXI_DATE)
        End Function
    End Structure

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
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

            '画面項目表示
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .DispTaxiMenu = True
            .PageTitle = "タクシーチケット印刷データ作成"
        End With
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        'クリア
        CmnModule.ClearAllControl(Me)

        'ボタン設定
        If CmnDb.IsExist(SQL.TBL_KOUENKAI.TaxiPrintCsv(), MyBase.DbConnection) Then
            CmnModule.SetEnabled(Me.BtnCsv, True)
            Me.TrNoData.Visible = False
        Else
            CmnModule.SetEnabled(Me.BtnCsv, False)
            Me.TrNoData.Visible = True
        End If
    End Sub

    '画面項目 表示
    Private Sub SetForm()
    End Sub

    '[Csvファイル作成]ボタン
    Protected Sub BtnCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCsv.Click
        '入力チェック
        If Not Check() Then Exit Sub

        'CSV作成処理
        CreateCsvData()
    End Sub

    '入力チェック
    Private Function Check() As Boolean
        Return True
    End Function

    'CSV作成処理
    Private Sub CreateCsvData()
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0

        '会合
        Dim TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
        wCnt = 0
        wFlag = False
        ReDim TBL_KOUENKAI(wCnt)
        strSQL = SQL.TBL_KOUENKAI.TaxiPrintCsv()
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True
            ReDim Preserve TBL_KOUENKAI(wCnt)
            TBL_KOUENKAI(wCnt) = AppModule.SetRsData(RsData, TBL_KOUENKAI(wCnt))
            wCnt += 1
        End While
        RsData.Close()
        If wFlag = False Then
            CmnModule.AlertMessage("対象データがありません。", Me)
            Exit Sub
        End If

        '交通宿泊テーブル
        Dim TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct

        '券種毎にCsv作成
        Dim TAXI_HAKKO_DATE As String = Now.ToString("yyMMddHHmm")
        Dim KENSHU() As String
        Dim wKenshuCnt As Integer

        wCnt = 0
        wFlag = False
        ReDim KENSHU(wCnt)
        strSQL = SQL.MS_CODE.byCODE(AppConst.MS_CODE.TAXI_KENSHU)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            If Trim(CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)) <> "" Then    '未指定を除く
                wFlag = True
                ReDim Preserve KENSHU(wCnt)
                KENSHU(wCnt) = CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)
                wCnt += 1
            End If
        End While
        RsData.Close()

        'コードマスタ無はエラー
        If wFlag = False Then
            CmnModule.AlertMessage("券種の設定が正しくありません。コードマスタを再確認してください。", Me)
            Exit Sub
        End If

        'ファイル作成
        Dim CsvPath() As String
        Dim sb() As System.Text.StringBuilder
        Dim sw() As System.IO.StreamWriter
        Dim DataFlag() As Boolean
        Dim wPrintFlag As Boolean
        ReDim CsvPath(UBound(KENSHU))
        ReDim sb(UBound(KENSHU))
        ReDim sw(UBound(KENSHU))
        ReDim DataFlag(UBound(KENSHU))

        For wKenshuCnt = LBound(KENSHU) To UBound(KENSHU)
            CsvPath(wKenshuCnt) = WebConfig.Path.TaxiPrintCsv & GetName_TKT_KENSHU(KENSHU(wKenshuCnt)) & "_" & TAXI_HAKKO_DATE & ".csv"
            sb(wKenshuCnt) = New System.Text.StringBuilder
            sw(wKenshuCnt) = New System.IO.StreamWriter(CsvPath(wKenshuCnt), False, System.Text.Encoding.GetEncoding("Shift-JIS"))
            DataFlag(wKenshuCnt) = False

            'ヘッダ
            sb(wKenshuCnt).Append("利用日,")
            sb(wKenshuCnt).Append("講演会名,")
            sb(wKenshuCnt).Append("利用日(月),")
            sb(wKenshuCnt).Append("利用日(日),")
            sb(wKenshuCnt).Append("参加者ID,")
            sb(wKenshuCnt).Append("金額,")
            sb(wKenshuCnt).Append("発行日,")
            sb(wKenshuCnt).Append("行番号,")
            sb(wKenshuCnt).Append("タクシー会社,")
            sb(wKenshuCnt).Append("講演会番号,")
            sb(wKenshuCnt).Append("セールスフォースID,")
            sb(wKenshuCnt).Append("タイムスタンプBYL,")
            sb(wKenshuCnt).Append("DR名,")
            sb(wKenshuCnt).Append("QR")
            sb(wKenshuCnt).Append(vbNewLine)
        Next wKenshuCnt

        '交通宿泊テーブル→Csv出力
        For wCnt = LBound(TBL_KOUENKAI) To UBound(TBL_KOUENKAI)

            TBL_KOTSUHOTEL = Nothing
            strSQL = SQL.TBL_KOTSUHOTEL.TaxiPrintCsv(TBL_KOUENKAI(wCnt).KOUENKAI_NO)
            RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
            While RsData.Read()
                wFlag = True
                TBL_KOTSUHOTEL = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL)

                '発行フラグ＝ON＋発行日空欄＋利用日あり＋券種あり
                wPrintFlag = False
                If (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_1 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_1 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_1 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_2 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_2 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_2 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_3 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_3 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_3 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_4 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_4 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_4 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_5 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_5 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_5 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_6 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_6 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_6 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_7 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_7 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_7 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_8 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_8 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_8 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_9 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_9 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_9 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_10 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_10 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_10 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_11 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_11 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_11 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_12 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_12 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_12 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_13 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_13 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_13 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_14 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_14 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_14 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_15 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_15 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_15 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_16 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_16 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_16 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_17 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_17 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_17 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_18 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_18 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_18 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_19 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_19 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_19 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19 <> "") OrElse _
                   (TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_20 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_20 = "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_20 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20 <> "") Then
                    wPrintFlag = True
                End If
 
                If wPrintFlag = True Then
                    '利用日1～20の降順にソートして再設定                    TBL_KOTSUHOTEL = SortAnsTaxi(TBL_KOTSUHOTEL)
                    For wKenshuCnt = LBound(KENSHU) To UBound(KENSHU)
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_1 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_1 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_1 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 1, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_2 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_2 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_2 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 2, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_3 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_3 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_3 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 3, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_4 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_4 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_4 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 4, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_5 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_5 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_5 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 5, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_6 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_6 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_6 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 6, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_7 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_7 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_7 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 7, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_8 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_8 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_8 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 8, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_9 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_9 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_9 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 9, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_10 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_10 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_10 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 10, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_11 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_11 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_11 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 11, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_12 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_12 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_12 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 12, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_13 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_13 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_13 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 13, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_14 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_14 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_14 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 14, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_15 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_15 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_15 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 15, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_16 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_16 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_16 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 16, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_17 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_17 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_17 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 17, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_18 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_18 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_18 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 18, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_19 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_19 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_19 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 19, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                        If TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20.ToUpper = KENSHU(wKenshuCnt).ToUpper AndAlso TBL_KOTSUHOTEL.ANS_TAXI_DATE_20 <> "" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_20 = "1" AndAlso TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_20 = "" Then
                            sb(wKenshuCnt).Append(CsvData(KENSHU(wKenshuCnt), 20, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                            sb(wKenshuCnt).Append(vbNewLine)
                            DataFlag(wKenshuCnt) = True
                        End If
                    Next
                End If
            End While
            RsData.Close()
        Next wCnt

        '書き込み
        For wKenshuCnt = LBound(KENSHU) To UBound(KENSHU)
            sw(wKenshuCnt).Write(sb(wKenshuCnt))
            sw(wKenshuCnt).Close()
        Next wKenshuCnt

        '読込み＋DB更新
        Dim wCsvDataCnt() As Integer
        ReDim wCsvDataCnt(UBound(KENSHU))

        MyBase.BeginTransaction()
        Try
            For wKenshuCnt = LBound(KENSHU) To UBound(KENSHU)
                Dim cReader As New System.IO.StreamReader(CsvPath(wKenshuCnt), System.Text.Encoding.Default)
                Dim stResult As String = String.Empty
                Dim wSplit() As String
                While (cReader.Peek() >= 0)
                    Dim stBuffer As String = cReader.ReadLine()
                    If InStr(stBuffer, ",") > 0 Then
                        'wSplit = Split(stBuffer, ",")
                        wSplit = Split(stBuffer, """,""")
                        If UBound(wSplit) < MyModule.Csv.TaxiPrintCsv.CsvIndex.BARCODE Then
                            'ログ登録
                            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiPrintCsv, False, CsvPath(wKenshuCnt) & " 項目数が正しくありません。", MyBase.DbConnection)
                        Else
                            '発行日
                            Dim wTAXI_HAKKO_DATE As String = "20" & Mid(TAXI_HAKKO_DATE, 1, 6)

                            'バーコード部分読込み
                            Dim wBarcode As String = Replace(wSplit(MyModule.Csv.TaxiPrintCsv.CsvIndex.BARCODE), CmnConst.Csv.Delimiter, "")
                            Dim CsvData As MyModule.Csv.TaxiPrintCsv.Barcode.DataStruct
                            Dim wLength As Integer = 1

                            CsvData.SALEFORCE_ID = Trim(Mid(wBarcode, wLength, MyModule.Csv.TaxiPrintCsv.Barcode.Length.SALEFORCE_ID))
                            wLength += MyModule.Csv.TaxiPrintCsv.Barcode.Length.SALEFORCE_ID

                            CsvData.SANKASHA_ID = Trim(Mid(wBarcode, wLength, MyModule.Csv.TaxiPrintCsv.Barcode.Length.SANKASHA_ID))
                            wLength += MyModule.Csv.TaxiPrintCsv.Barcode.Length.SANKASHA_ID

                            CsvData.KOUENKAI_NO = Trim(Mid(wBarcode, wLength, MyModule.Csv.TaxiPrintCsv.Barcode.Length.KOUENKAI_NO))
                            wLength += MyModule.Csv.TaxiPrintCsv.Barcode.Length.KOUENKAI_NO

                            CsvData.TIME_STAMP_BYL = Trim(Mid(wBarcode, wLength, MyModule.Csv.TaxiPrintCsv.Barcode.Length.TIME_STAMP_BYL))
                            wLength += MyModule.Csv.TaxiPrintCsv.Barcode.Length.TIME_STAMP_BYL

                            CsvData.DR_MPID = Trim(Mid(wBarcode, wLength, MyModule.Csv.TaxiPrintCsv.Barcode.Length.DR_MPID))
                            wLength += MyModule.Csv.TaxiPrintCsv.Barcode.Length.DR_MPID

                            CsvData.TKT_LINE_NO = Trim(Mid(wBarcode, wLength, MyModule.Csv.TaxiPrintCsv.Barcode.Length.TKT_LINE_NO))
                            wLength += MyModule.Csv.TaxiPrintCsv.Barcode.Length.TKT_LINE_NO

                            'DB更新
                            Dim wTBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct = Nothing
                            wTBL_KOTSUHOTEL.SALEFORCE_ID = CsvData.SALEFORCE_ID
                            wTBL_KOTSUHOTEL.SANKASHA_ID = CsvData.SANKASHA_ID
                            wTBL_KOTSUHOTEL.KOUENKAI_NO = CsvData.KOUENKAI_NO
                            wTBL_KOTSUHOTEL.TIME_STAMP_BYL = CsvData.TIME_STAMP_BYL
                            wTBL_KOTSUHOTEL.DR_MPID = CsvData.DR_MPID
                            wTBL_KOTSUHOTEL.UPDATE_USER = Session.Item(SessionDef.LoginID)

                            strSQL = SQL.TBL_KOTSUHOTEL.Update_TaxiPrint(CsvData.TKT_LINE_NO, wTAXI_HAKKO_DATE, wTBL_KOTSUHOTEL)
                            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

                            'ログ登録
                            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiPrintCsv, _
                                                   GetName_TKT_KENSHU(KENSHU(wKenshuCnt)), _
                                                   CsvData.KOUENKAI_NO, _
                                                   CsvData.SANKASHA_ID, _
                                                   CsvData.TKT_LINE_NO, _
                                                   CsvData.SALEFORCE_ID, _
                                                   CsvData.TIME_STAMP_BYL, _
                                                   CsvData.DR_MPID, _
                                                   True, _
                                                   "", _
                                                   MyBase.DbConnection)
                        End If
                    End If
                    wCsvDataCnt(wKenshuCnt) += 1
                End While
                cReader.Close()

                'ログ登録
                MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiPrintCsv, True, GetName_TKT_KENSHU(KENSHU(wKenshuCnt)) & "：" & wCsvDataCnt(wKenshuCnt) & "件の参加者データを出力しました。", MyBase.DbConnection)
            Next wKenshuCnt

            MyBase.Commit()
        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiPrintCsv, False, Session.Item(SessionDef.DbError) & vbNewLine & strSQL, MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))

            'Csv削除
            Try
                For wKenshuCnt = LBound(KENSHU) To UBound(KENSHU)
                    System.IO.File.Delete(CsvPath(wKenshuCnt))
                Next wKenshuCnt
            Catch ex2 As Exception
            End Try

            Exit Sub
        End Try

        'Zipファイル名
        Dim ZipFileName As String = "PrintData_" & TAXI_HAKKO_DATE & ".zip"
        Dim ZipPath As String = WebConfig.Path.TaxiPrintCsv & ZipFileName
        'Zip作成
        Using zip As New Ionic.Zip.ZipFile
            For wKenshuCnt = LBound(KENSHU) To UBound(KENSHU)
                If DataFlag(wKenshuCnt) = True Then    '対象データがある券種のみ
                    zip.AddFile(CsvPath(wKenshuCnt), "")
                End If
            Next wKenshuCnt
            zip.Save(ZipPath)
        End Using

        'ログ登録
        MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiPrintCsv, True, "ZIPファイル作成(" & ZipFileName & ")", MyBase.DbConnection)

        'バックアップ作成
        System.IO.File.Copy(ZipPath, WebConfig.Path.TaxiPrintCsv_BackUp & ZipFileName)

        'Csv削除
        Try
            For wKenshuCnt = LBound(KENSHU) To UBound(KENSHU)
                System.IO.File.Delete(CsvPath(wKenshuCnt))
            Next wKenshuCnt
        Catch ex As Exception
        End Try

        'ダウンロード
        Response.Clear()
        Response.ContentType = "application/x-zip"
        Response.Charset = ""
        Response.AddHeader("content-disposition", "attachment; filename=" & _
            HttpUtility.UrlEncode(CStr(ZipFileName)))
        Response.WriteFile(CStr(ZipPath))
        Response.Flush()

        'Zipファイル削除
        Try
            System.IO.File.Delete(ZipPath)
        Catch ex As Exception
        End Try
    End Sub

    'Csv出力用に編集
    '印刷データ
    Private Function CsvData(ByVal KENSHU As String, ByVal LineNo As Integer, ByVal TAXI_HAKKO_DATE As String, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct, ByVal TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct) As System.Text.StringBuilder
        Dim ANS_TAXI_DATE As String = GetANS_TAXI_DATE(LineNo, TBL_KOTSUHOTEL)
        Dim ANS_TAXI_KENSHU As String = GetANS_TAXI_KENSHU(LineNo, TBL_KOTSUHOTEL)
        Dim TKT_LINE_NO As String = GetTKT_LINE_NO(LineNo, TBL_KOTSUHOTEL)
        Dim sb As New System.Text.StringBuilder

        Try
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_DATE(ANS_TAXI_DATE))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOUENKAI.TAXI_PRT_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_DATE_MM(ANS_TAXI_DATE))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_DATE_DD(ANS_TAXI_DATE))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.SANKASHA_ID)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_TAXI_HAKKO_DATE(TAXI_HAKKO_DATE))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TKT_LINE_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_TKT_KAISHA(ANS_TAXI_KENSHU))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.KOUENKAI_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.SALEFORCE_ID)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.TIME_STAMP_BYL)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.DR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_BARCODE(TBL_KOTSUHOTEL.SALEFORCE_ID, _
                                                                   TBL_KOTSUHOTEL.SANKASHA_ID, _
                                                                   TBL_KOTSUHOTEL.KOUENKAI_NO, _
                                                                   TBL_KOTSUHOTEL.TIME_STAMP_BYL, _
                                                                   TBL_KOTSUHOTEL.DR_MPID, _
                                                                   TKT_LINE_NO, _
                                                                   TAXI_HAKKO_DATE, _
                                                                   ANS_TAXI_KENSHU)), True))
            Return sb
        Catch ex As Exception
            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiPrintCsv, _
                                   GetName_TKT_KENSHU(KENSHU), _
                                   TBL_KOTSUHOTEL.KOUENKAI_NO, _
                                   TBL_KOTSUHOTEL.SANKASHA_ID, _
                                   TKT_LINE_NO, _
                                   TBL_KOTSUHOTEL.SALEFORCE_ID, _
                                   TBL_KOTSUHOTEL.TIME_STAMP_BYL, _
                                   TBL_KOTSUHOTEL.DR_MPID, _
                                   False, _
                                   "", _
                                   MyBase.DbConnection)

            Throw New Exception(ex.ToString)
        End Try
    End Function

    Private Function GetANS_TAXI_DATE(ByVal LineNo As Integer, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
        Dim wStr As String = ""

        Select Case LineNo
            Case 1 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_1
            Case 2 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_2
            Case 3 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_3
            Case 4 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_4
            Case 5 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_5
            Case 6 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_6
            Case 7 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_7
            Case 8 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_8
            Case 9 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_9
            Case 10 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_10
            Case 11 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_11
            Case 12 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_12
            Case 13 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_13
            Case 14 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_14
            Case 15 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_15
            Case 16 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_16
            Case 17 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_17
            Case 18 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_18
            Case 19 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_19
            Case 20 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_DATE_20
        End Select

        Return wStr
    End Function
    Private Function GetANS_TAXI_KENSHU(ByVal LineNo As Integer, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
        Dim wStr As String = ""

        Select Case LineNo
            Case 1 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1
            Case 2 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2
            Case 3 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3
            Case 4 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4
            Case 5 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5
            Case 6 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6
            Case 7 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7
            Case 8 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8
            Case 9 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9
            Case 10 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10
            Case 11 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11
            Case 12 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12
            Case 13 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13
            Case 14 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14
            Case 15 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15
            Case 16 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16
            Case 17 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17
            Case 18 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18
            Case 19 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19
            Case 20 : wStr = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20
        End Select

        Return wStr
    End Function
    Private Function GetTKT_LINE_NO(ByVal LineNo As Integer, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
        Dim wStr As String = ""

        Select Case LineNo
            Case 1 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_1
            Case 2 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_2
            Case 3 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_3
            Case 4 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_4
            Case 5 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_5
            Case 6 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_6
            Case 7 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_7
            Case 8 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_8
            Case 9 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_9
            Case 10 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_10
            Case 11 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_11
            Case 12 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_12
            Case 13 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_13
            Case 14 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_14
            Case 15 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_15
            Case 16 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_16
            Case 17 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_17
            Case 18 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_18
            Case 19 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_19
            Case 20 : wStr = TBL_KOTSUHOTEL.TKT_LINE_NO_20
        End Select

        Return wStr
    End Function

    Private Function GetName_TKT_KAISHA(ByVal ANS_TAXI_KENSHU As String) As String
        Dim wStr As String = ANS_TAXI_KENSHU.ToUpper
        If Not CmnCheck.IsNumberOnly(ANS_TAXI_KENSHU) Then
            Return Left(ANS_TAXI_KENSHU, 2)
        Else
            Return "DC"
        End If
    End Function
    Private Function GetName_TKT_KENSHU(ByVal TKT_KENSHU As String) As String
        Dim wStr As String = TKT_KENSHU.ToUpper
        If Not CmnCheck.IsNumberOnly(TKT_KENSHU) Then
            Return TKT_KENSHU
        Else
            Return "DC" & TKT_KENSHU
        End If
    End Function
    Private Function GetName_ANS_TAXI_DATE(ByVal ANS_TAXI_DATE As String) As String
        If Not IsDate(CmnModule.Format_Date(ANS_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDD)) Then
            Return ""
        Else
            Return Mid(ANS_TAXI_DATE, 1, 4) & "年" & Mid(ANS_TAXI_DATE, 5, 2) & "月" & Mid(ANS_TAXI_DATE, 7, 2) & "日"
        End If
    End Function
    Private Function GetName_ANS_TAXI_DATE_MM(ByVal ANS_TAXI_DATE As String) As String
        If Not IsDate(CmnModule.Format_Date(ANS_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDD)) Then
            Return ""
        Else
            Return Mid(ANS_TAXI_DATE, 5, 2)
        End If
    End Function
    Private Function GetName_ANS_TAXI_DATE_DD(ByVal ANS_TAXI_DATE As String) As String
        If Not IsDate(CmnModule.Format_Date(ANS_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDD)) Then
            Return ""
        Else
            Return Mid(ANS_TAXI_DATE, 7, 2)
        End If
    End Function
    Private Function GetName_ANS_TAXI_KENSHU(ByVal ANS_TAXI_KENSHU As String) As String
        Dim wStr As String = ANS_TAXI_KENSHU.ToUpper
        wStr = Replace(wStr, "DC", "")
        wStr = Replace(wStr, "TK", "")
        wStr = Replace(wStr, "NG", "")
        If Not CmnCheck.IsNumberOnly(wStr) Then
            Return ""
        Else
            Return Val(wStr).ToString("#,#")
        End If
    End Function
    Private Function GetName_TAXI_HAKKO_DATE(ByVal TAXI_HAKKO_DATE As String) As String
        Return "20" & Mid(TAXI_HAKKO_DATE, 1, 2) & "/" & CInt(Mid(TAXI_HAKKO_DATE, 3, 2)).ToString & "/" & CInt(Mid(TAXI_HAKKO_DATE, 5, 2)).ToString
    End Function

    Private Function GetName_BARCODE(ByVal SALEFORCE_ID As String, ByVal SANKASHA_ID As String, ByVal KOUENKAI_NO As String, ByVal TIME_STAMP_BYL As String, ByVal DR_MPID As String, ByVal TKT_LINE_NO As String, ByVal TAXI_HAKKO_DATE As String, ByVal TAXI_KENSHU As String) As String
        Dim wBARCODE As String = ""
        Dim wStr As String = ""

        '固定長、右スペース埋め

        'SalesForceID
        wBARCODE &= Trim(SALEFORCE_ID).PadRight(MyModule.Csv.TaxiPrintCsv.Barcode.Length.SALEFORCE_ID, " ")
        '参加者ID
        wBARCODE &= Trim(SANKASHA_ID).PadRight(MyModule.Csv.TaxiPrintCsv.Barcode.Length.SANKASHA_ID, " ")
        '会合番号
        wBARCODE &= Trim(KOUENKAI_NO).PadRight(MyModule.Csv.TaxiPrintCsv.Barcode.Length.KOUENKAI_NO, " ")
        'タイムスタンプBYL
        wBARCODE &= Trim(TIME_STAMP_BYL).PadRight(MyModule.Csv.TaxiPrintCsv.Barcode.Length.TIME_STAMP_BYL, " ")
        'DR_MPID
        wBARCODE &= Trim(DR_MPID).PadRight(MyModule.Csv.TaxiPrintCsv.Barcode.Length.DR_MPID, " ")
        '行番号
        wBARCODE &= Trim(TKT_LINE_NO).PadRight(MyModule.Csv.TaxiPrintCsv.Barcode.Length.TKT_LINE_NO, " ")

        Return wBARCODE
    End Function

    Private Function GetName_TKT_LINE_NO(ByVal TKT_LINE_NO As Integer, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
        Select Case TKT_LINE_NO
            Case 1 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_1
            Case 2 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_2
            Case 3 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_3
            Case 4 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_4
            Case 5 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_5
            Case 6 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_6
            Case 7 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_7
            Case 8 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_8
            Case 9 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_9
            Case 10 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_10
            Case 11 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_11
            Case 12 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_12
            Case 13 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_13
            Case 14 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_14
            Case 15 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_15
            Case 16 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_16
            Case 17 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_17
            Case 18 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_18
            Case 19 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_19
            Case 20 : Return TBL_KOTSUHOTEL.TKT_LINE_NO_20
            Case Else : Return ""
        End Select
    End Function

    '利用日1～20の降順にソートして再設定
    Private Function SortAnsTaxi(ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As TableDef.TBL_KOTSUHOTEL.DataStruct
        Dim AnsTaxiData(19) As AnsTaxiStructure
        AnsTaxiData(0).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_1
        AnsTaxiData(1).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_2
        AnsTaxiData(2).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_3
        AnsTaxiData(3).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_4
        AnsTaxiData(4).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_5
        AnsTaxiData(5).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_6
        AnsTaxiData(6).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_7
        AnsTaxiData(7).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_8
        AnsTaxiData(8).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_9
        AnsTaxiData(9).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_10
        AnsTaxiData(10).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_11
        AnsTaxiData(11).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_12
        AnsTaxiData(12).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_13
        AnsTaxiData(13).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_14
        AnsTaxiData(14).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_15
        AnsTaxiData(15).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_16
        AnsTaxiData(16).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_17
        AnsTaxiData(17).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_18
        AnsTaxiData(18).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_19
        AnsTaxiData(19).TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_20
        AnsTaxiData(0).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1
        AnsTaxiData(1).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2
        AnsTaxiData(2).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3
        AnsTaxiData(3).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4
        AnsTaxiData(4).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5
        AnsTaxiData(5).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6
        AnsTaxiData(6).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7
        AnsTaxiData(7).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8
        AnsTaxiData(8).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9
        AnsTaxiData(9).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10
        AnsTaxiData(10).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11
        AnsTaxiData(11).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12
        AnsTaxiData(12).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13
        AnsTaxiData(13).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14
        AnsTaxiData(14).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15
        AnsTaxiData(15).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16
        AnsTaxiData(16).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17
        AnsTaxiData(17).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18
        AnsTaxiData(18).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19
        AnsTaxiData(19).TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20
        AnsTaxiData(0).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_1
        AnsTaxiData(1).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_2
        AnsTaxiData(2).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_3
        AnsTaxiData(3).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_4
        AnsTaxiData(4).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_5
        AnsTaxiData(5).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_6
        AnsTaxiData(6).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_7
        AnsTaxiData(7).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_8
        AnsTaxiData(8).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_9
        AnsTaxiData(9).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_10
        AnsTaxiData(10).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_11
        AnsTaxiData(11).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_12
        AnsTaxiData(12).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_13
        AnsTaxiData(13).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_14
        AnsTaxiData(14).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_15
        AnsTaxiData(15).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_16
        AnsTaxiData(16).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_17
        AnsTaxiData(17).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_18
        AnsTaxiData(18).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_19
        AnsTaxiData(19).TAXI_HAKKO_DATE = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_20
        AnsTaxiData(0).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_1
        AnsTaxiData(1).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_2
        AnsTaxiData(2).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_3
        AnsTaxiData(3).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_4
        AnsTaxiData(4).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_5
        AnsTaxiData(5).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_6
        AnsTaxiData(6).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_7
        AnsTaxiData(7).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_8
        AnsTaxiData(8).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_9
        AnsTaxiData(9).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_10
        AnsTaxiData(10).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_11
        AnsTaxiData(11).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_12
        AnsTaxiData(12).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_13
        AnsTaxiData(13).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_14
        AnsTaxiData(14).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_15
        AnsTaxiData(15).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_16
        AnsTaxiData(16).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_17
        AnsTaxiData(17).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_18
        AnsTaxiData(18).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_19
        AnsTaxiData(19).TAXI_HAKKO = TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_20
        AnsTaxiData(0).TKT_LINE_NO = 1
        AnsTaxiData(1).TKT_LINE_NO = 2
        AnsTaxiData(2).TKT_LINE_NO = 3
        AnsTaxiData(3).TKT_LINE_NO = 4
        AnsTaxiData(4).TKT_LINE_NO = 5
        AnsTaxiData(5).TKT_LINE_NO = 6
        AnsTaxiData(6).TKT_LINE_NO = 7
        AnsTaxiData(7).TKT_LINE_NO = 8
        AnsTaxiData(8).TKT_LINE_NO = 9
        AnsTaxiData(9).TKT_LINE_NO = 10
        AnsTaxiData(10).TKT_LINE_NO = 11
        AnsTaxiData(11).TKT_LINE_NO = 12
        AnsTaxiData(12).TKT_LINE_NO = 13
        AnsTaxiData(13).TKT_LINE_NO = 14
        AnsTaxiData(14).TKT_LINE_NO = 15
        AnsTaxiData(15).TKT_LINE_NO = 16
        AnsTaxiData(16).TKT_LINE_NO = 17
        AnsTaxiData(17).TKT_LINE_NO = 18
        AnsTaxiData(18).TKT_LINE_NO = 19
        AnsTaxiData(19).TKT_LINE_NO = 20

        '降順ソート
        Array.Reverse(AnsTaxiData)

        '構造体に戻す
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_1 = AnsTaxiData(0).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_2 = AnsTaxiData(1).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_3 = AnsTaxiData(2).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_4 = AnsTaxiData(3).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_5 = AnsTaxiData(4).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_6 = AnsTaxiData(5).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_7 = AnsTaxiData(6).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_8 = AnsTaxiData(7).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_9 = AnsTaxiData(8).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_10 = AnsTaxiData(9).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_11 = AnsTaxiData(10).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_12 = AnsTaxiData(11).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_13 = AnsTaxiData(12).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_14 = AnsTaxiData(13).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_15 = AnsTaxiData(14).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_16 = AnsTaxiData(15).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_17 = AnsTaxiData(16).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_18 = AnsTaxiData(17).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_19 = AnsTaxiData(18).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_20 = AnsTaxiData(19).TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1 = AnsTaxiData(0).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2 = AnsTaxiData(1).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3 = AnsTaxiData(2).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4 = AnsTaxiData(3).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5 = AnsTaxiData(4).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6 = AnsTaxiData(5).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7 = AnsTaxiData(6).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8 = AnsTaxiData(7).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9 = AnsTaxiData(8).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10 = AnsTaxiData(9).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11 = AnsTaxiData(10).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12 = AnsTaxiData(11).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13 = AnsTaxiData(12).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14 = AnsTaxiData(13).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15 = AnsTaxiData(14).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16 = AnsTaxiData(15).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17 = AnsTaxiData(16).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18 = AnsTaxiData(17).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19 = AnsTaxiData(18).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20 = AnsTaxiData(19).TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_1 = AnsTaxiData(0).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_2 = AnsTaxiData(1).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_3 = AnsTaxiData(2).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_4 = AnsTaxiData(3).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_5 = AnsTaxiData(4).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_6 = AnsTaxiData(5).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_7 = AnsTaxiData(6).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_8 = AnsTaxiData(7).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_9 = AnsTaxiData(8).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_10 = AnsTaxiData(9).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_11 = AnsTaxiData(10).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_12 = AnsTaxiData(11).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_13 = AnsTaxiData(12).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_14 = AnsTaxiData(13).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_15 = AnsTaxiData(14).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_16 = AnsTaxiData(15).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_17 = AnsTaxiData(16).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_18 = AnsTaxiData(17).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_19 = AnsTaxiData(18).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_DATE_20 = AnsTaxiData(19).TAXI_HAKKO_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_1 = AnsTaxiData(0).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_2 = AnsTaxiData(1).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_3 = AnsTaxiData(2).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_4 = AnsTaxiData(3).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_5 = AnsTaxiData(4).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_6 = AnsTaxiData(5).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_7 = AnsTaxiData(6).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_8 = AnsTaxiData(7).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_9 = AnsTaxiData(8).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_10 = AnsTaxiData(9).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_11 = AnsTaxiData(10).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_12 = AnsTaxiData(11).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_13 = AnsTaxiData(12).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_14 = AnsTaxiData(13).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_15 = AnsTaxiData(14).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_16 = AnsTaxiData(15).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_17 = AnsTaxiData(16).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_18 = AnsTaxiData(17).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_19 = AnsTaxiData(18).TAXI_HAKKO
        TBL_KOTSUHOTEL.ANS_TAXI_HAKKO_20 = AnsTaxiData(19).TAXI_HAKKO
        TBL_KOTSUHOTEL.TKT_LINE_NO_1 = AnsTaxiData(0).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_2 = AnsTaxiData(1).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_3 = AnsTaxiData(2).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_4 = AnsTaxiData(3).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_5 = AnsTaxiData(4).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_6 = AnsTaxiData(5).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_7 = AnsTaxiData(6).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_8 = AnsTaxiData(7).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_9 = AnsTaxiData(8).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_10 = AnsTaxiData(9).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_11 = AnsTaxiData(10).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_12 = AnsTaxiData(11).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_13 = AnsTaxiData(12).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_14 = AnsTaxiData(13).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_15 = AnsTaxiData(14).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_16 = AnsTaxiData(15).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_17 = AnsTaxiData(16).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_18 = AnsTaxiData(17).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_19 = AnsTaxiData(18).TKT_LINE_NO
        TBL_KOTSUHOTEL.TKT_LINE_NO_20 = AnsTaxiData(19).TKT_LINE_NO

        Return TBL_KOTSUHOTEL
    End Function

End Class
