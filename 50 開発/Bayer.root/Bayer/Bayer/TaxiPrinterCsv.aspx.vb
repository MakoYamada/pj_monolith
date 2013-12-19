Imports CommonLib
Imports AppLib
Partial Public Class TaxiPrinterCsv
    Inherits WebBase

    <Serializable()> Private Structure AnsTaxiStructure
        Implements IComparable
        Dim ANS_TAXI_DATE As String
        Dim ANS_TAXI_KENSHU As String
        Dim ANS_TKT_NO As Integer
        Public Function CompareTo(ByVal obj As Object) As Integer Implements IComparable.CompareTo
            Return Me.ANS_TAXI_DATE.CompareTo(DirectCast(obj, AnsTaxiStructure).ANS_TAXI_DATE)
        End Function
    End Structure

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

        'マステーページ設定
        With Me.Master
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
    End Sub

    '[Csvファイル作成]ボタン
    Protected Sub BtnCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCsv.Click
        '入力チェック
        If Not Check() Then Exit Sub

        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0

        '講演会
        Dim TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
        wCnt = 0
        wFlag = False
        ReDim TBL_KOUENKAI(wCnt)
        strSQL = SQL.TBL_KOUENKAI.TaxiPrinterCsv()
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
        Dim TAXI_HAKKO_DATE As String = Now.ToString("yyyyMMddHHmm")

        'ファイル作成
        Dim CsvPath() As String
        ReDim CsvPath(5)

        CsvPath(0) = WebConfig.Path.TaxiPrintCsv & "DC3000_" & TAXI_HAKKO_DATE & ".csv"
        Dim sb3000 As New System.Text.StringBuilder
        Dim sw3000 As System.IO.StreamWriter
        sw3000 = New System.IO.StreamWriter(CsvPath(0), False, System.Text.Encoding.GetEncoding("Shift-JIS"))

        CsvPath(1) = WebConfig.Path.TaxiPrintCsv & "DC5000_" & TAXI_HAKKO_DATE & ".csv"
        Dim sb5000 As New System.Text.StringBuilder
        Dim sw5000 As System.IO.StreamWriter
        sw5000 = New System.IO.StreamWriter(CsvPath(1), False, System.Text.Encoding.GetEncoding("Shift-JIS"))

        CsvPath(2) = WebConfig.Path.TaxiPrintCsv & "DC10000_" & TAXI_HAKKO_DATE & ".csv"
        Dim sb10000 As New System.Text.StringBuilder
        Dim sw10000 As System.IO.StreamWriter
        sw10000 = New System.IO.StreamWriter(CsvPath(2), False, System.Text.Encoding.GetEncoding("Shift-JIS"))

        CsvPath(3) = WebConfig.Path.TaxiPrintCsv & "TK10000_" & TAXI_HAKKO_DATE & ".csv"
        Dim sbTK10000 As New System.Text.StringBuilder
        Dim swTK10000 As System.IO.StreamWriter
        swTK10000 = New System.IO.StreamWriter(CsvPath(3), False, System.Text.Encoding.GetEncoding("Shift-JIS"))

        CsvPath(4) = WebConfig.Path.TaxiPrintCsv & "NG5000_" & TAXI_HAKKO_DATE & ".csv"
        Dim sbNG5000 As New System.Text.StringBuilder
        Dim swNG5000 As System.IO.StreamWriter
        swNG5000 = New System.IO.StreamWriter(CsvPath(4), False, System.Text.Encoding.GetEncoding("Shift-JIS"))

        '交通宿泊テーブル→Csv出力
        For wCnt = LBound(TBL_KOUENKAI) To UBound(TBL_KOUENKAI)
            TBL_KOTSUHOTEL = Nothing
            strSQL = SQL.TBL_KOTSUHOTEL.TaxiPrinterCsv(TBL_KOUENKAI(wCnt).KOUENKAI_NO)
            RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
            While RsData.Read()
                wFlag = True
                TBL_KOTSUHOTEL = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL)

                '利用日1～20の降順にソートして再設定
                TBL_KOTSUHOTEL = SortAnsTaxi(TBL_KOTSUHOTEL)

                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1
                    Case "3000"
                        sb3000.Append(CsvData(1, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(1, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(1, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(1, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(1, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2
                    Case "3000"
                        sb3000.Append(CsvData(2, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(2, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(2, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(2, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(2, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3
                    Case "3000"
                        sb3000.Append(CsvData(3, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(3, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(3, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(3, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(3, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4
                    Case "3000"
                        sb3000.Append(CsvData(4, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(4, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(4, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(4, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(4, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5
                    Case "3000"
                        sb3000.Append(CsvData(5, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(5, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(5, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(5, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(5, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6
                    Case "3000"
                        sb3000.Append(CsvData(6, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(6, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(6, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(6, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(6, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7
                    Case "3000"
                        sb3000.Append(CsvData(7, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(7, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(7, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(7, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(7, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8
                    Case "3000"
                        sb3000.Append(CsvData(8, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(8, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(8, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(8, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(8, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9
                    Case "3000"
                        sb3000.Append(CsvData(9, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(9, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(9, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(9, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(9, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10
                    Case "3000"
                        sb3000.Append(CsvData(10, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(10, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(10, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(10, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(10, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11
                    Case "3000"
                        sb3000.Append(CsvData(11, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(11, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(11, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(11, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(11, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12
                    Case "3000"
                        sb3000.Append(CsvData(12, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(12, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(12, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(12, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(12, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13
                    Case "3000"
                        sb3000.Append(CsvData(13, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(13, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(13, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(13, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(13, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14
                    Case "3000"
                        sb3000.Append(CsvData(14, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(14, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(14, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(14, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(14, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15
                    Case "3000"
                        sb3000.Append(CsvData(15, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(15, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(15, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(15, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(15, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16
                    Case "3000"
                        sb3000.Append(CsvData(16, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(16, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(16, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(16, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(16, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17
                    Case "3000"
                        sb3000.Append(CsvData(17, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(17, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(17, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(17, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(17, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18
                    Case "3000"
                        sb3000.Append(CsvData(18, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(18, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(18, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(18, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(18, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19
                    Case "3000"
                        sb3000.Append(CsvData(19, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(19, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(19, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(19, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(19, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20
                    Case "3000"
                        sb3000.Append(CsvData(20, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000.Append(vbNewLine)
                    Case "5000"
                        sb5000.Append(CsvData(20, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000.Append(vbNewLine)
                    Case "10000"
                        sb10000.Append(CsvData(20, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000.Append(CsvData(20, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000.Append(CsvData(20, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000.Append(vbNewLine)
                End Select
            End While
            RsData.Close()
        Next wCnt

        '書き込み
        sw3000.Write(sb3000)
        sw3000.Close()
        sw5000.Write(sb5000)
        sw5000.Close()
        sw10000.Write(sb10000)
        sw10000.Close()
        swTK10000.Write(sbTK10000)
        swTK10000.Close()
        swNG5000.Write(sbNG5000)
        swNG5000.Close()

        'Zipファイル名
        Dim ZipFileName As String = "PrintData_" & TAXI_HAKKO_DATE & ".zip"
        Dim ZipPath As String = WebConfig.Path.TaxiPrintCsv & ZipFileName
        'Zip作成
        Using zip As New Ionic.Zip.ZipFile
            zip.AddFile(CsvPath(0), "")
            zip.AddFile(CsvPath(1), "")
            zip.AddFile(CsvPath(2), "")
            zip.AddFile(CsvPath(3), "")
            zip.AddFile(CsvPath(4), "")

            zip.Save(ZipPath)
        End Using

        'バックアップ作成
        System.IO.File.Copy(ZipPath, WebConfig.Path.TaxiPrintCsv_BackUp & ZipFileName)

        'Csv削除
        Try
            System.IO.File.Delete(CsvPath(0))
            System.IO.File.Delete(CsvPath(1))
            System.IO.File.Delete(CsvPath(2))
            System.IO.File.Delete(CsvPath(3))
            System.IO.File.Delete(CsvPath(4))
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

    '入力チェック
    Private Function Check() As Boolean
        Return True
    End Function

    'Csv出力用に編集
    '印刷データ
    Private Function CsvData(ByVal LineNo As Integer, ByVal TAXI_HAKKO_DATE As String, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct, ByVal TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct) As System.Text.StringBuilder
        Dim ANS_TAXI_DATE As String = GetANS_TAXI_DATE(LineNo, TBL_KOTSUHOTEL)
        Dim ANS_TAXI_KENSHU As String = GetANS_TAXI_KENSHU(LineNo, TBL_KOTSUHOTEL)
        Dim ANS_TKT_NO As String = GetANS_TKT_NO(LineNo, TBL_KOTSUHOTEL)
        Dim sb As New System.Text.StringBuilder

        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_DATE(ANS_TAXI_DATE))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOUENKAI.TAXI_PRT_NAME)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_DATE_MM(ANS_TAXI_DATE))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_DATE_DD(ANS_TAXI_DATE))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.SANKASHA_ID)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_TAXI_HAKKO_DATE(TAXI_HAKKO_DATE))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_BARCODE(TBL_KOTSUHOTEL.SALEFORCE_ID, _
                                               TBL_KOTSUHOTEL.SANKASHA_ID, _
                                               TBL_KOTSUHOTEL.KOUENKAI_NO, _
                                               TBL_KOTSUHOTEL.TIME_STAMP_BYL, _
                                               TBL_KOTSUHOTEL.DR_MPID, _
                                               ANS_TKT_NO, _
                                               TAXI_HAKKO_DATE, _
                                               ANS_TAXI_KENSHU)), True))

        Return sb
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
    Private Function GetANS_TKT_NO(ByVal LineNo As Integer, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
        Dim wStr As String = ""

        Select Case LineNo
            Case 1 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_1
            Case 2 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_2
            Case 3 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_3
            Case 4 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_4
            Case 5 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_5
            Case 6 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_6
            Case 7 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_7
            Case 8 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_8
            Case 9 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_9
            Case 10 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_10
            Case 11 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_11
            Case 12 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_12
            Case 13 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_13
            Case 14 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_14
            Case 15 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_15
            Case 16 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_16
            Case 17 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_17
            Case 18 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_18
            Case 19 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_19
            Case 20 : wStr = TBL_KOTSUHOTEL.ANS_TKT_NO_20
        End Select

        Return wStr
    End Function

    Private Function GetName_TKT_KAISHA(ByVal ANS_TAXI_KENSHU As String) As String
        Dim wStr As String = ANS_TAXI_KENSHU.ToUpper
        If InStr(wStr, "TK") > 0 Then
            Return "TK"
        ElseIf InStr(wStr, "NG") > 0 Then
            Return "NG"
        Else
            Return "DC"
        End If
    End Function
    Private Function GetName_ANS_TAXI_DATE(ByVal ANS_TAXI_DATE As String) As String
        If Not IsDate(CmnModule.Format_Date(ANS_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDD)) Then
            Return ""
        Else
            Return Mid(ANS_TAXI_DATE, 1, 4) & "年" & CInt(Mid(ANS_TAXI_DATE, 5, 2)).ToString & "月" & CInt(Mid(ANS_TAXI_DATE, 7, 2)).ToString & "日"
        End If
    End Function
    Private Function GetName_ANS_TAXI_DATE_MM(ByVal ANS_TAXI_DATE As String) As String
        If Not IsDate(CmnModule.Format_Date(ANS_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDD)) Then
            Return ""
        Else
            Return CInt(Mid(ANS_TAXI_DATE, 5, 2)).ToString
        End If
    End Function
    Private Function GetName_ANS_TAXI_DATE_DD(ByVal ANS_TAXI_DATE As String) As String
        If Not IsDate(CmnModule.Format_Date(ANS_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDD)) Then
            Return ""
        Else
            Return CInt(Mid(ANS_TAXI_DATE, 7, 2)).ToString
        End If
    End Function
    Private Function GetName_ANS_TAXI_KENSHU(ByVal ANS_TAXI_KENSHU As String) As String
        Dim wStr As String = ANS_TAXI_KENSHU.ToUpper
        wStr = Replace(wStr, "TK", "")
        wStr = Replace(wStr, "NG", "")
        If Not CmnCheck.IsNumberOnly(wStr) Then
            Return ""
        Else
            Return Val(wStr).ToString("#,#")
        End If
    End Function
    Private Function GetName_TAXI_HAKKO_DATE(ByVal TAXI_HAKKO_DATE As String) As String
        Return Mid(TAXI_HAKKO_DATE, 1, 4) & "/" & CInt(Mid(TAXI_HAKKO_DATE, 5, 2)).ToString & "/" & CInt(Mid(TAXI_HAKKO_DATE, 7, 2)).ToString
    End Function

    Private Function GetName_BARCODE(ByVal SALEFORCE_ID As String, ByVal SANKASHA_ID As String, ByVal KOUENKAI_NO As String, ByVal TIME_STAMP_BYL As String, ByVal DR_MPID As String, ByVal ANS_TKT_NO As String, ByVal ANS_TAXI_HAKKO_DATE As String, ByVal ANS_TAXI_KENSHU As String) As String
        Dim wBARCODE As String = ""
        Dim wStr As String = ""

        '固定長、右スペース埋め

        'セールスフォースID
        wBARCODE &= Trim(SALEFORCE_ID).PadRight(MyModule.Csv.TaxiBarcode.Length.SALEFORCE_ID, "*")
        '参加者ID
        wBARCODE &= Trim(SANKASHA_ID).PadRight(MyModule.Csv.TaxiBarcode.Length.SANKASHA_ID, "*")
        '講演会番号
        wBARCODE &= Trim(KOUENKAI_NO).PadRight(MyModule.Csv.TaxiBarcode.Length.KOUENKAI_NO, "*")
        'タイムスタンプBYL
        wBARCODE &= Trim(TIME_STAMP_BYL).PadRight(MyModule.Csv.TaxiBarcode.Length.TIME_STAMP_BYL, "*")
        'DR_MPID
        wBARCODE &= Trim(DR_MPID).PadRight(MyModule.Csv.TaxiBarcode.Length.DR_MPID, "*")
        '行番号
        wBARCODE &= Trim(ANS_TKT_NO).PadRight(MyModule.Csv.TaxiBarcode.Length.ANS_TKT_NO, "*")
        '発行日
        wBARCODE &= Trim(Mid(ANS_TAXI_HAKKO_DATE, 1, MyModule.Csv.TaxiBarcode.Length.ANS_TAXI_HAKKO_DATE)).PadRight(MyModule.Csv.TaxiBarcode.Length.ANS_TAXI_HAKKO_DATE, "*")
        'タクシー会社
        If Mid(ANS_TAXI_KENSHU, 1, 2).ToUpper = "TK" Then
            wStr = "TK"
        ElseIf Mid(ANS_TAXI_KENSHU, 1, 2).ToUpper = "NG" Then
            wStr = "NG"
        Else
            wStr = "DC"
        End If
        wBARCODE &= wStr.PadRight(MyModule.Csv.TaxiBarcode.Length.TKT_KAISHA, "*")
        '券種
        wBARCODE &= Trim(ANS_TAXI_KENSHU).PadRight(MyModule.Csv.TaxiBarcode.Length.ANS_TAXI_KENSHU, "*")

        Return wBARCODE
    End Function

    Private Function GetName_ANS_TKT_NO(ByVal ANS_TKT_NO As Integer, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
        Select Case ANS_TKT_NO
            Case 1 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_1
            Case 2 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_2
            Case 3 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_3
            Case 4 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_4
            Case 5 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_5
            Case 6 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_6
            Case 7 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_7
            Case 8 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_8
            Case 9 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_9
            Case 10 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_10
            Case 11 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_11
            Case 12 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_12
            Case 13 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_13
            Case 14 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_14
            Case 15 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_15
            Case 16 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_16
            Case 17 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_17
            Case 18 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_18
            Case 19 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_19
            Case 20 : Return TBL_KOTSUHOTEL.ANS_TKT_NO_20
            Case Else : Return ""
        End Select
    End Function

    '利用日1～20の降順にソートして再設定
    Private Function SortAnsTaxi(ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As TableDef.TBL_KOTSUHOTEL.DataStruct
        Dim AnsTaxiData(19) As AnsTaxiStructure
        AnsTaxiData(0).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_1
        AnsTaxiData(1).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_2
        AnsTaxiData(2).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_3
        AnsTaxiData(3).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_4
        AnsTaxiData(4).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_5
        AnsTaxiData(5).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_6
        AnsTaxiData(6).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_7
        AnsTaxiData(7).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_8
        AnsTaxiData(8).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_9
        AnsTaxiData(9).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_10
        AnsTaxiData(10).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_11
        AnsTaxiData(11).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_12
        AnsTaxiData(12).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_13
        AnsTaxiData(13).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_14
        AnsTaxiData(14).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_15
        AnsTaxiData(15).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_16
        AnsTaxiData(16).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_17
        AnsTaxiData(17).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_18
        AnsTaxiData(18).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_19
        AnsTaxiData(19).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_20
        AnsTaxiData(0).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1
        AnsTaxiData(1).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2
        AnsTaxiData(2).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3
        AnsTaxiData(3).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4
        AnsTaxiData(4).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5
        AnsTaxiData(5).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6
        AnsTaxiData(6).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7
        AnsTaxiData(7).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8
        AnsTaxiData(8).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9
        AnsTaxiData(9).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10
        AnsTaxiData(10).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11
        AnsTaxiData(11).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12
        AnsTaxiData(12).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13
        AnsTaxiData(13).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14
        AnsTaxiData(14).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15
        AnsTaxiData(15).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16
        AnsTaxiData(16).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17
        AnsTaxiData(17).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18
        AnsTaxiData(18).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19
        AnsTaxiData(19).ANS_TAXI_KENSHU = TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20
        AnsTaxiData(0).ANS_TKT_NO = 1
        AnsTaxiData(1).ANS_TKT_NO = 2
        AnsTaxiData(2).ANS_TKT_NO = 3
        AnsTaxiData(3).ANS_TKT_NO = 4
        AnsTaxiData(4).ANS_TKT_NO = 5
        AnsTaxiData(5).ANS_TKT_NO = 6
        AnsTaxiData(6).ANS_TKT_NO = 7
        AnsTaxiData(7).ANS_TKT_NO = 8
        AnsTaxiData(8).ANS_TKT_NO = 9
        AnsTaxiData(9).ANS_TKT_NO = 10
        AnsTaxiData(10).ANS_TKT_NO = 11
        AnsTaxiData(11).ANS_TKT_NO = 12
        AnsTaxiData(12).ANS_TKT_NO = 13
        AnsTaxiData(13).ANS_TKT_NO = 14
        AnsTaxiData(14).ANS_TKT_NO = 15
        AnsTaxiData(15).ANS_TKT_NO = 16
        AnsTaxiData(16).ANS_TKT_NO = 17
        AnsTaxiData(17).ANS_TKT_NO = 18
        AnsTaxiData(18).ANS_TKT_NO = 19
        AnsTaxiData(19).ANS_TKT_NO = 20

        '降順ソート
        Array.Reverse(AnsTaxiData)

        '構造体に戻す
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_1 = AnsTaxiData(0).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_2 = AnsTaxiData(1).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_3 = AnsTaxiData(2).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_4 = AnsTaxiData(3).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_5 = AnsTaxiData(4).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_6 = AnsTaxiData(5).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_7 = AnsTaxiData(6).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_8 = AnsTaxiData(7).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_9 = AnsTaxiData(8).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_10 = AnsTaxiData(9).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_11 = AnsTaxiData(10).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_12 = AnsTaxiData(11).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_13 = AnsTaxiData(12).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_14 = AnsTaxiData(13).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_15 = AnsTaxiData(14).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_16 = AnsTaxiData(15).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_17 = AnsTaxiData(16).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_18 = AnsTaxiData(17).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_19 = AnsTaxiData(18).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_DATE_20 = AnsTaxiData(19).ANS_TAXI_DATE
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1 = AnsTaxiData(0).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2 = AnsTaxiData(1).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3 = AnsTaxiData(2).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4 = AnsTaxiData(3).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5 = AnsTaxiData(4).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6 = AnsTaxiData(5).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7 = AnsTaxiData(6).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8 = AnsTaxiData(7).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9 = AnsTaxiData(8).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10 = AnsTaxiData(9).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11 = AnsTaxiData(10).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12 = AnsTaxiData(11).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13 = AnsTaxiData(12).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14 = AnsTaxiData(13).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15 = AnsTaxiData(14).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16 = AnsTaxiData(15).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17 = AnsTaxiData(16).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18 = AnsTaxiData(17).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19 = AnsTaxiData(18).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20 = AnsTaxiData(19).ANS_TAXI_KENSHU
        TBL_KOTSUHOTEL.ANS_TKT_NO_1 = AnsTaxiData(0).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_2 = AnsTaxiData(1).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_3 = AnsTaxiData(2).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_4 = AnsTaxiData(3).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_5 = AnsTaxiData(4).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_6 = AnsTaxiData(5).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_7 = AnsTaxiData(6).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_8 = AnsTaxiData(7).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_9 = AnsTaxiData(8).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_10 = AnsTaxiData(9).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_11 = AnsTaxiData(10).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_12 = AnsTaxiData(11).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_13 = AnsTaxiData(12).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_14 = AnsTaxiData(13).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_15 = AnsTaxiData(14).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_16 = AnsTaxiData(15).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_17 = AnsTaxiData(16).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_18 = AnsTaxiData(17).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_19 = AnsTaxiData(18).ANS_TKT_NO
        TBL_KOTSUHOTEL.ANS_TKT_NO_20 = AnsTaxiData(19).ANS_TKT_NO

        Return TBL_KOTSUHOTEL
    End Function

End Class
