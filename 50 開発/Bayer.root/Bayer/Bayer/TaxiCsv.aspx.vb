Imports CommonLib
Imports AppLib
Partial Public Class TaxiCsv
    Inherits WebBase

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
        strSQL = SQL.TBL_KOUENKAI.TaxiCsv()
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

        '印刷データ
        Dim CsvPath_PrintData As String()
        ReDim CsvPath_PrintData(5)

        CsvPath_PrintData(0) = WebConfig.Path.TaxiPrintCsv & "DC3000_" & TAXI_HAKKO_DATE & ".csv"
        Dim sb3000_PrintData As New System.Text.StringBuilder
        Dim sw3000_PrintData As System.IO.StreamWriter
        sw3000_PrintData = New System.IO.StreamWriter(CsvPath_PrintData(0), False, System.Text.Encoding.GetEncoding("Shift-JIS"))

        CsvPath_PrintData(1) = WebConfig.Path.TaxiPrintCsv & "DC5000_" & TAXI_HAKKO_DATE & ".csv"
        Dim sb5000_PrintData As New System.Text.StringBuilder
        Dim sw5000_PrintData As System.IO.StreamWriter
        sw5000_PrintData = New System.IO.StreamWriter(CsvPath_PrintData(1), False, System.Text.Encoding.GetEncoding("Shift-JIS"))

        CsvPath_PrintData(2) = WebConfig.Path.TaxiPrintCsv & "DC10000_" & TAXI_HAKKO_DATE & ".csv"
        Dim sb10000_PrintData As New System.Text.StringBuilder
        Dim sw10000_PrintData As System.IO.StreamWriter
        sw10000_PrintData = New System.IO.StreamWriter(CsvPath_PrintData(2), False, System.Text.Encoding.GetEncoding("Shift-JIS"))

        CsvPath_PrintData(3) = WebConfig.Path.TaxiPrintCsv & "TK10000_" & TAXI_HAKKO_DATE & ".csv"
        Dim sbTK10000_PrintData As New System.Text.StringBuilder
        Dim swTK10000_PrintData As System.IO.StreamWriter
        swTK10000_PrintData = New System.IO.StreamWriter(CsvPath_PrintData(3), False, System.Text.Encoding.GetEncoding("Shift-JIS"))

        CsvPath_PrintData(4) = WebConfig.Path.TaxiPrintCsv & "NG5000_" & TAXI_HAKKO_DATE & ".csv"
        Dim sbNG5000_PrintData As New System.Text.StringBuilder
        Dim swNG5000_PrintData As System.IO.StreamWriter
        swNG5000_PrintData = New System.IO.StreamWriter(CsvPath_PrintData(4), False, System.Text.Encoding.GetEncoding("Shift-JIS"))

        'チェックリスト
        Dim CsvPath_CheckList As String()
        ReDim CsvPath_CheckList(5)

        CsvPath_CheckList(0) = WebConfig.Path.TaxiPrintCsv & "CheckList_DC3000_" & TAXI_HAKKO_DATE & ".csv"
        Dim sb3000_CheckList As New System.Text.StringBuilder
        Dim sw3000_CheckList As System.IO.StreamWriter
        sw3000_CheckList = New System.IO.StreamWriter(CsvPath_CheckList(0), False, System.Text.Encoding.GetEncoding("Shift-JIS"))

        CsvPath_CheckList(1) = WebConfig.Path.TaxiPrintCsv & "CheckList_DC5000_" & TAXI_HAKKO_DATE & ".csv"
        Dim sb5000_CheckList As New System.Text.StringBuilder
        Dim sw5000_CheckList As System.IO.StreamWriter
        sw5000_CheckList = New System.IO.StreamWriter(CsvPath_CheckList(1), False, System.Text.Encoding.GetEncoding("Shift-JIS"))

        CsvPath_CheckList(2) = WebConfig.Path.TaxiPrintCsv & "CheckList_DC10000_" & TAXI_HAKKO_DATE & ".csv"
        Dim sb10000_CheckList As New System.Text.StringBuilder
        Dim sw10000_CheckList As System.IO.StreamWriter
        sw10000_CheckList = New System.IO.StreamWriter(CsvPath_CheckList(2), False, System.Text.Encoding.GetEncoding("Shift-JIS"))

        CsvPath_CheckList(3) = WebConfig.Path.TaxiPrintCsv & "CheckList_TK10000_" & TAXI_HAKKO_DATE & ".csv"
        Dim sbTK10000_CheckList As New System.Text.StringBuilder
        Dim swTK10000_CheckList As System.IO.StreamWriter
        swTK10000_CheckList = New System.IO.StreamWriter(CsvPath_CheckList(3), False, System.Text.Encoding.GetEncoding("Shift-JIS"))

        CsvPath_CheckList(4) = WebConfig.Path.TaxiPrintCsv & "CheckList_NG5000_" & TAXI_HAKKO_DATE & ".csv"
        Dim sbNG5000_CheckList As New System.Text.StringBuilder
        Dim swNG5000_CheckList As System.IO.StreamWriter
        swNG5000_CheckList = New System.IO.StreamWriter(CsvPath_CheckList(4), False, System.Text.Encoding.GetEncoding("Shift-JIS"))

        '交通宿泊テーブル→Csv出力
        For wCnt = LBound(TBL_KOUENKAI) To UBound(TBL_KOUENKAI)
            TBL_KOTSUHOTEL = Nothing
            strSQL = SQL.TBL_KOTSUHOTEL.TaxiCsv(TBL_KOUENKAI(wCnt).KOUENKAI_NO)
            RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
            While RsData.Read()
                wFlag = True
                TBL_KOTSUHOTEL = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL)

                 Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_1
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(1, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(1, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(1, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(1, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(1, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(1, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(1, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(1, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(1, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(1, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_2
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(2, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(2, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(2, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(2, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(2, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(2, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(2, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(2, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(2, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(2, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_3
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(3, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(3, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(3, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(3, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(3, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(3, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(3, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(3, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(3, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(3, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_4
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(4, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(4, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(4, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(4, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(4, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(4, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(4, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(4, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(4, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(4, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_5
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(5, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(5, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(5, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(5, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(5, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(5, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(5, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(5, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(5, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(5, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_6
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(6, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(6, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(6, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(6, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(6, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(6, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(6, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(6, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(6, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(6, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_7
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(7, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(7, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(7, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(7, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(7, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(7, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(7, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(7, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(7, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(7, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_8
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(8, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(8, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(8, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(8, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(8, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(8, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(8, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(8, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(8, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(8, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_9
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(9, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(9, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(9, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(9, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(9, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(9, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(9, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(9, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(9, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(9, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_10
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(10, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(10, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(10, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(10, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(10, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(10, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(10, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(10, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(10, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(10, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_11
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(11, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(11, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(11, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(11, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(11, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(11, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(11, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(11, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(11, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(11, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_12
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(12, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(12, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(12, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(12, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(12, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(12, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(12, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(12, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(12, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(12, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_13
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(13, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(13, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(13, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(13, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(13, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(13, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(13, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(13, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(13, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(13, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_14
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(14, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(14, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(14, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(14, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(14, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(14, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(14, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(14, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(14, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(14, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_15
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(15, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(15, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(15, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(15, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(15, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(15, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(15, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(15, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(15, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(15, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_16
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(16, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(16, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(16, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(16, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(16, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(16, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(16, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(16, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(16, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(16, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_17
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(17, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(17, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(17, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(17, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(17, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(17, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(17, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(17, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(17, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(17, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_18
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(18, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(18, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(18, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(18, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(18, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(18, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(18, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(18, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(18, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(18, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_19
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(19, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(19, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(19, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(19, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(19, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(19, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(19, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(19, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(19, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(19, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
                Select Case TBL_KOTSUHOTEL.ANS_TAXI_KENSHU_20
                    Case "3000"
                        sb3000_PrintData.Append(CsvData_PrintData(20, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_PrintData.Append(vbNewLine)
                        sb3000_CheckList.Append(CsvData_CheckList(20, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb3000_CheckList.Append(vbNewLine)
                    Case "5000"
                        sb5000_PrintData.Append(CsvData_PrintData(20, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_PrintData.Append(vbNewLine)
                        sb5000_CheckList.Append(CsvData_CheckList(20, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb5000_CheckList.Append(vbNewLine)
                    Case "10000"
                        sb10000_PrintData.Append(CsvData_PrintData(20, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_PrintData.Append(vbNewLine)
                        sb10000_CheckList.Append(CsvData_CheckList(20, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sb10000_CheckList.Append(vbNewLine)
                    Case "TK10000"
                        sbTK10000_PrintData.Append(CsvData_PrintData(20, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_PrintData.Append(vbNewLine)
                        sbTK10000_CheckList.Append(CsvData_CheckList(20, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbTK10000_CheckList.Append(vbNewLine)
                    Case "NG5000"
                        sbNG5000_PrintData.Append(CsvData_PrintData(20, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_PrintData.Append(vbNewLine)
                        sbNG5000_CheckList.Append(CsvData_CheckList(20, TAXI_HAKKO_DATE, TBL_KOTSUHOTEL, TBL_KOUENKAI(wCnt)))
                        sbNG5000_CheckList.Append(vbNewLine)
                End Select
            End While
            RsData.Close()
        Next wCnt

        '印刷データ
        sw3000_PrintData.Write(sb3000_PrintData)
        sw3000_PrintData.Close()
        sw5000_PrintData.Write(sb5000_PrintData)
        sw5000_PrintData.Close()
        sw10000_PrintData.Write(sb10000_PrintData)
        sw10000_PrintData.Close()
        swTK10000_PrintData.Write(sbTK10000_PrintData)
        swTK10000_PrintData.Close()
        swNG5000_PrintData.Write(sbNG5000_PrintData)
        swNG5000_PrintData.Close()

        'チェックリスト
        sw3000_CheckList.Write(sb3000_CheckList)
        sw3000_CheckList.Close()
        sw5000_CheckList.Write(sb5000_CheckList)
        sw5000_CheckList.Close()
        sw10000_CheckList.Write(sb10000_CheckList)
        sw10000_CheckList.Close()
        swTK10000_CheckList.Write(sbTK10000_CheckList)
        swTK10000_CheckList.Close()
        swNG5000_CheckList.Write(sbNG5000_CheckList)
        swNG5000_CheckList.Close()

        'Zipファイル名
        Dim ZipFileName As String = "PrintData_" & TAXI_HAKKO_DATE & ".zip"
        Dim ZipPath As String = WebConfig.Path.TaxiPrintCsv & ZipFileName
        'Zip作成
        Using zip As New Ionic.Zip.ZipFile
            zip.AddFile(CsvPath_PrintData(0), "")
            zip.AddFile(CsvPath_PrintData(1), "")
            zip.AddFile(CsvPath_PrintData(2), "")
            zip.AddFile(CsvPath_PrintData(3), "")
            zip.AddFile(CsvPath_PrintData(4), "")
            zip.AddFile(CsvPath_CheckList(0), "")
            zip.AddFile(CsvPath_CheckList(1), "")
            zip.AddFile(CsvPath_CheckList(2), "")
            zip.AddFile(CsvPath_CheckList(3), "")
            zip.AddFile(CsvPath_CheckList(4), "")

            zip.Save(ZipPath)
        End Using

        'バックアップ作成
        System.IO.File.Copy(ZipPath, WebConfig.Path.TaxiPrintCsv_BackUp & ZipFileName)

        'Csv削除
        Try
            System.IO.File.Delete(CsvPath_PrintData(0))
            System.IO.File.Delete(CsvPath_PrintData(1))
            System.IO.File.Delete(CsvPath_PrintData(2))
            System.IO.File.Delete(CsvPath_PrintData(3))
            System.IO.File.Delete(CsvPath_PrintData(4))
            System.IO.File.Delete(CsvPath_CheckList(0))
            System.IO.File.Delete(CsvPath_CheckList(1))
            System.IO.File.Delete(CsvPath_CheckList(2))
            System.IO.File.Delete(CsvPath_CheckList(3))
            System.IO.File.Delete(CsvPath_CheckList(4))
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
    Private Function CsvData_PrintData(ByVal TKT_LINE_NO As Integer, ByVal TAXI_HAKKO_DATE As String, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct, ByVal TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct) As System.Text.StringBuilder
        Dim ANS_TAXI_DATE As String = GetTAXI_DATE(TKT_LINE_NO, TBL_KOTSUHOTEL)
        Dim ANS_TAXI_KENSHU As String = GetTAXI_KENSHU(TKT_LINE_NO, TBL_KOTSUHOTEL)
        Dim sb As New System.Text.StringBuilder

        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_TKT_KAISHA(ANS_TAXI_KENSHU))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_DATE(ANS_TAXI_DATE))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOUENKAI.TAXI_PRT_NAME)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_DATE_MM(ANS_TAXI_DATE))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_DATE_DD(ANS_TAXI_DATE))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_DATE_MM(ANS_TAXI_DATE))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_DATE_DD(ANS_TAXI_DATE))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOUENKAI.TAXI_PRT_NAME)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.SANKASHA_ID)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_TAXI_HAKKO_DATE(TAXI_HAKKO_DATE))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TKT_LINE_NO.ToString)))

        Return sb
    End Function

    'チェックリスト
    Private Function CsvData_CheckList(ByVal TKT_LINE_NO As Integer, ByVal TAXI_HAKKO_DATE As String, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct, ByVal TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct) As System.Text.StringBuilder
        Dim ANS_TAXI_DATE As String = GetTAXI_DATE(TKT_LINE_NO, TBL_KOTSUHOTEL)
        Dim ANS_TAXI_KENSHU As String = GetTAXI_KENSHU(TKT_LINE_NO, TBL_KOTSUHOTEL)
        Dim sb As New System.Text.StringBuilder

        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_TKT_KAISHA(ANS_TAXI_KENSHU))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_DATE(ANS_TAXI_DATE))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOUENKAI.TAXI_PRT_NAME)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_DATE_MM(ANS_TAXI_DATE))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_DATE_DD(ANS_TAXI_DATE))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_DATE_MM(ANS_TAXI_DATE))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_DATE_DD(ANS_TAXI_DATE))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOUENKAI.TAXI_PRT_NAME)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.SANKASHA_ID)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_TAXI_KENSHU(ANS_TAXI_KENSHU))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_TAXI_HAKKO_DATE(TAXI_HAKKO_DATE))))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TKT_LINE_NO.ToString)))
        Return sb
    End Function

    Private Function GetTAXI_DATE(ByVal TKT_LINE_NO As Integer, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
        Dim wStr As String = ""

        Select Case TKT_LINE_NO
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
    Private Function GetTAXI_KENSHU(ByVal TKT_LINE_NO As Integer, ByVal TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As String
        Dim wStr As String = ""

        Select Case TKT_LINE_NO
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

    Private Function GetName_TKT_KAISHA(ByVal ANS_ATXI_KENSHU As String) As String
        Dim wStr As String = ANS_ATXI_KENSHU.ToUpper
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
        wStr = Replace(wStr, "TK", "")
        wStr = Replace(wStr, "NG", "")
        If Not CmnCheck.IsNumberOnly(wStr) Then
            Return ""
        Else
            Return Val(wStr).ToString("#,#")
        End If
    End Function
    Private Function GetName_TAXI_HAKKO_DATE(ByVal TAXI_HAKKO_DATE As String) As String
        Return Mid(TAXI_HAKKO_DATE, 1, 4) & "/" & Mid(TAXI_HAKKO_DATE, 5, 2) & "/" & Mid(TAXI_HAKKO_DATE, 7, 2)
    End Function

End Class
