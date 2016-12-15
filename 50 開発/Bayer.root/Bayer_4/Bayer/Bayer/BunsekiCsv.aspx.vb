Imports CommonLib
Imports AppLib
Imports System.Runtime.Remoting.Messaging.AsyncResult

Partial Public Class BunsekiCsv
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列    Private Enum CellIndex
        BU
        KIKAKU_TANTO_AREA
        KIKAKU_TANTO_EIGYOSHO
        KIKAKU_TANTO_NAME
        JISSHI_DATE
        KOUENKAI_NO
        KOUENKAI_NAME
        TIME_STAMP
        KUBUN
        Button1
        TO_DATE
        CNT
    End Enum

    Private Sub DrList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
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
        MyModule.IsPageOK(False, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "分析用データ作成"
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

    '画面項目 初期化    Private Sub InitControls()

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '[戻る]
    Private Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        Response.Redirect(URL.Menu)
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

    '会合費用総合一覧表CSVボタン

    Protected Sub BtnKaigouCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnKaigouCsv.Click

        '入力チェック
        If Not Check() Then Exit Sub

        'Dim CsvData() As TableDef.TBL_SEIKYU.DataStruct
        'If GetEvidenceData(CsvData) Then
        '    'CSV出力
        '    Response.Clear()
        '    Response.ContentType = CmnConst.Csv.ContentType
        '    Response.Charset = CmnConst.Csv.Charset
        '    Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & HttpUtility.UrlEncode("会合費用総合一覧表_" & Now.ToString("yyyyMMddHHmmss") & ".csv"))
        '    Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-jis")

        '    Response.Write(MyModule.Csv.KaigouHiyouCsv(CsvData))
        '    Response.End()
        'End If

        Dim kaigou As KaigouDelegate = New KaigouDelegate(AddressOf KaigouMethod)
        Dim callBack As New AsyncCallback(AddressOf KaigouCallBackMethod)

        Dim air As IAsyncResult = kaigou.BeginInvoke(100, "yyyy/MM/dd hh:mm:ss", callBack, Nothing)

        '初期化
        'cnt = -1

        Me.lblStatus.Text = "処理開始"
        '進捗確認用のjavascriptタイマー開始
        Me.ScriptManager1.RegisterStartupScript(Page, Page.GetType(), "Normal", "<script language='JavaScript'>KaigouStartTimer();</script>", False)
    End Sub

    Private Sub BtnKaigouCsvRun_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnKaigouCsvRun.Click
        Dim cnt As Integer = cnt

        If cnt = -1 Then
            Me.lblStatus.Text = "処理完了"
            Me.lblProgress.Text = "-"
            '進捗確認用のjavascriptタイマー停止
            Me.ScriptManager1.RegisterStartupScript(Page, Page.GetType(), "Normal", "<script language='JavaScript'>StopTimer();alert('完了しました。');</script>", False)
        Else
            Me.lblProgress.Text = cnt & "/100"
        End If
    End Sub

    '会合費用総合一覧表CSV用データ取得

    Private Function GetEvidenceData(ByRef CsvData() As TableDef.TBL_SEIKYU.DataStruct) As Boolean
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim CsvData(wCnt)

        Dim fromDate As String = ""
        Dim toDate As String = ""
        MyModule.GetSeisanFromTo(Me.JokenSHOUNIN_Y.Text, Me.JokenSHOUNIN_M.Text, fromDate, toDate)

        strSQL = SQL.TBL_SEIKYU.KaigouEvidenceCsv(fromDate, toDate)
        RsData = CmnDb.ReadForDeligate(strSQL, MyBase.DbConnection)
        'RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
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

    '参加者旅費費用総合一覧CSVボタン

    Protected Sub BtnDrCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnDrCsv.Click

        '入力チェック
        If Not Check() Then Exit Sub

        Dim CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct
        If GetDrCsvData(CsvData) Then
            'CSV出力
            Response.Clear()
            Response.ContentType = CmnConst.Csv.ContentType
            Response.Charset = CmnConst.Csv.Charset
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & HttpUtility.UrlEncode("参加者旅費費用総合一覧表_" & Now.ToString("yyyyMMddHHmmss") & ".csv"))
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-jis")

            Response.Write(MyModule.Csv.DrHiyouCsv(CsvData, Me.DbConnection))
            Response.End()
        End If
    End Sub

    '参加者旅費費用総合一覧CSV用データ取得
    Private Function GetDrCsvData(ByRef CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct) As Boolean
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim CsvData(wCnt)

        Dim fromDate As String = ""
        Dim toDate As String = ""
        MyModule.GetSeisanFromTo(Me.JokenSHOUNIN_Y.Text, Me.JokenSHOUNIN_M.Text, fromDate, toDate)

        strSQL = SQL.TBL_KOTSUHOTEL.DrHiyouCsv(fromDate, toDate)
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

    'MR旅費費用総合一覧CSVボタン

    Private Sub BtnMrCsv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnMrCsv.Click

        '入力チェック
        If Not Check() Then Exit Sub

        Dim CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct
        If GetMrCsvData(CsvData) Then
            'CSV出力
            Response.Clear()
            Response.ContentType = CmnConst.Csv.ContentType
            Response.Charset = CmnConst.Csv.Charset
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & HttpUtility.UrlEncode("社員旅費費用総合一覧表_" & Now.ToString("yyyyMMddHHmmss") & ".csv"))
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-jis")

            Response.Write(MyModule.Csv.MrHiyouCsv(CsvData, MyBase.DbConnection))
            Response.End()
        End If
    End Sub

    'MR一覧CSV用データ取得
    Private Function GetMrCsvData(ByRef CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct) As Boolean
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim CsvData(wCnt)

        Dim fromDate As String = ""
        Dim toDate As String = ""
        MyModule.GetSeisanFromTo(Me.JokenSHOUNIN_Y.Text, Me.JokenSHOUNIN_M.Text, fromDate, toDate)

        strSQL = SQL.TBL_KOTSUHOTEL.MrHiyouCsv(fromDate, toDate)
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

#Region "デリゲート"

    Delegate Function KaigouDelegate(ByVal intLoop As Integer, ByVal format As String) As String

    ''' <summary>
    ''' 会合費用総合一覧CSV出力　非同期処理
    ''' </summary>
    ''' <param name="intLoop"></param>
    ''' <param name="format"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function KaigouMethod(ByVal intLoop As Integer, ByVal format As String) As String

        Dim CsvData() As TableDef.TBL_SEIKYU.DataStruct
        If GetEvidenceData(CsvData) Then

            'CSV出力内容生成

            Dim wCnt As Integer = 0
            Dim sb As New System.Text.StringBuilder

            'ヘッダ出力
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("開催開始日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会場名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("SRM発注区分")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("トップツアー精算年月")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("支払番号")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("承認区分")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算承認日")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("総合計金額")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会場費(非課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("飲食費(非課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("機材費(非課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("小計(非課税)991330401")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊費(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("入湯税・宿泊税(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("航空券代(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("JR代(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("その他交通費用(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("スタッフ費用(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("管理費(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配手数料(宿泊・交通)(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ発行手数料(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("その他(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ実車料金(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ精算手数料(非課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("小計(非課税)41120200")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("非課税金額合計")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会場費(課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("飲食費(課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("機材費(課税)991330401")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("小計(課税)991330401")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("スタッフ費用(課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("管理費(課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("その他(課税)41120200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("小計(課税)41120200")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("課税金額合計")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員宿泊費")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員入湯税・宿泊税")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員交通費")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ実車料金(エンタ)")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ精算手数料(エンタ)")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("製品名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Internal Order（非課税）")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Internal Order（課税）")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Account Code（非課税）")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Account Code（課税）")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Cost Center")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Zetia Code")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者BU")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者エリア")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者営業所")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者氏名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配担当者BU")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配担当者エリア")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配担当者営業所")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配担当者氏名")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TOP送信日")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("NZ送信"), True))

            sb.Append(vbNewLine)

            '集計行用
            Dim lngTotalSougouKei As Long = 0

            Dim lngTotalKAIJOHI_TF As Long = 0
            Dim lngTotalINSHOKUHI_TF As Long = 0
            Dim lngTotalKIZAIHI_TF As Long = 0
            Dim lngTotalKEI_991330401_TF As Long = 0

            Dim lngTotalHOTELHI_TF As Long = 0
            Dim lngTotalHOTELHI_TOZEI As Long = 0
            Dim lngTotalAIR_TF As Long = 0
            Dim lngTotalJR_TF As Long = 0
            Dim lngTotalOTHER_TRAFFIC_TF As Long = 0
            Dim lngTotalJINKENHI_TF As Long = 0
            Dim lngTotalKANRIHI_TF As Long = 0
            Dim lngTotalHOTEL_COMMISSION_TF As Long = 0
            Dim lngTotalTAXI_COMMISSION_TF As Long = 0
            Dim lngTotalOTHER_TF As Long = 0
            Dim lngTotalTAXI_TF As Long = 0
            Dim lngTotalTAXI_SEISAN_TF As Long = 0
            Dim lngTotalKEI_41120200_TF As Long = 0

            Dim lngTotalKEI_TF As Long = 0

            Dim lngTotalKAIJOUHI_T As Long = 0
            Dim lngTotalINSHOKUHI_T As Long = 0
            Dim lngTotalKIZAIHI_T As Long = 0
            Dim lngTotalKEI_991330401_T As Long = 0

            Dim lngTotalJINKENHI_T As Long = 0
            Dim lngTotalKANRIHI_T As Long = 0
            Dim lngTotalOTHER_T As Long = 0
            Dim lngTotalKEI_41120200_T As Long = 0

            Dim lngTotalKEI_T As Long = 0

            Dim lngTotalMR_HOTEL As Long = 0
            Dim lngTotalMR_HOTEL_TOZEI As Long = 0
            Dim lngTotalMR_JR As Long = 0

            Dim lngTotalTAXI_T As Long = 0
            Dim lngTotalTAXI_SEISAN_T As Long = 0

            '明細行出力
            For wCnt = 0 To UBound(CsvData)
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).FROM_DATE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIJO_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SRM_HACYU_KBN(CsvData(wCnt).SRM_HACYU_KBN))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEISAN_YM)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEIKYU_NO_TOPTOUR)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHIHARAI_NO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SHOUNIN_KUBUN(CsvData(wCnt).SHOUNIN_KUBUN))))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHOUNIN_DATE)))

                '総合計金額
                Dim lngSougouKei As Long = CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_TF) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_T) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_HOTEL) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_HOTEL_TOZEI) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_JR) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_T) + _
                                            CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_SEISAN_T)

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngSougouKei.ToString)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIJOHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INSHOKUHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIZAIHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_991330401_TF)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).HOTELHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).HOTELHI_TOZEI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).AIR_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).JR_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).OTHER_TRAFFIC_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).JINKENHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KANRIHI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).HOTEL_COMMISSION_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_COMMISSION_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).OTHER_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_SEISAN_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_41120200_TF)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_TF)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIJOUHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INSHOKUHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIZAIHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_991330401_T)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).JINKENHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KANRIHI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).OTHER_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_41120200_T)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KEI_T)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_HOTEL)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_HOTEL_TOZEI)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_JR)))

                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TAXI_SEISAN_T)))

                '@@@ Phase2
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEIHIN_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INTERNAL_ORDER_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).INTERNAL_ORDER_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ACCOUNT_CD_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ACCOUNT_CD_T)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).COST_CENTER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ZETIA_CD)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).BU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_AREA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_EIGYOSHO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TEHAI_TANTO_BU)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TEHAI_TANTO_AREA)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TEHAI_TANTO_EIGYOSHO)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TEHAI_TANTO_NAME)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).UPDATE_DATE)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SEND_FLAG(CsvData(wCnt).SEND_FLAG)), True))
                '@@@ Phase2

                sb.Append(vbNewLine)

                '集計行用に加算
                lngTotalSougouKei += lngSougouKei
                lngTotalKAIJOHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KAIJOHI_TF)
                lngTotalINSHOKUHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).INSHOKUHI_TF)
                lngTotalKIZAIHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KIZAIHI_TF)
                lngTotalKEI_991330401_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_991330401_TF)

                lngTotalHOTELHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).HOTELHI_TF)
                lngTotalHOTELHI_TOZEI += CmnModule.DbVal_Kingaku(CsvData(wCnt).HOTELHI_TOZEI)
                lngTotalAIR_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).AIR_TF)
                lngTotalJR_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).JR_TF)
                lngTotalOTHER_TRAFFIC_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).OTHER_TRAFFIC_TF)
                lngTotalJINKENHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).JINKENHI_TF)
                lngTotalKANRIHI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KANRIHI_TF)
                lngTotalHOTEL_COMMISSION_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).HOTEL_COMMISSION_TF)
                lngTotalTAXI_COMMISSION_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_COMMISSION_TF)
                lngTotalOTHER_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).OTHER_TF)
                lngTotalTAXI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_TF)
                lngTotalTAXI_SEISAN_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_SEISAN_TF)
                lngTotalKEI_41120200_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_41120200_TF)

                lngTotalKEI_TF += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_TF)
                lngTotalKAIJOUHI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KAIJOUHI_T)
                lngTotalINSHOKUHI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).INSHOKUHI_T)
                lngTotalKIZAIHI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KIZAIHI_T)
                lngTotalKEI_991330401_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_991330401_T)

                lngTotalJINKENHI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).JINKENHI_T)
                lngTotalKANRIHI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KANRIHI_T)
                lngTotalOTHER_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).OTHER_T)
                lngTotalKEI_41120200_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_41120200_T)

                lngTotalKEI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).KEI_T)

                lngTotalMR_HOTEL += CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_HOTEL)
                lngTotalMR_HOTEL_TOZEI += CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_HOTEL_TOZEI)
                lngTotalMR_JR += CmnModule.DbVal_Kingaku(CsvData(wCnt).MR_JR)

                lngTotalTAXI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_T)
                lngTotalTAXI_SEISAN_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).TAXI_SEISAN_T)
            Next

            '集計行出力
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("計")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalSougouKei.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKAIJOHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalINSHOKUHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKIZAIHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_991330401_TF.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalHOTELHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalHOTELHI_TOZEI.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalAIR_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalJR_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalOTHER_TRAFFIC_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalJINKENHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKANRIHI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalHOTEL_COMMISSION_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalTAXI_COMMISSION_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalOTHER_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalTAXI_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalTAXI_SEISAN_TF.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_41120200_TF.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_TF.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKAIJOUHI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalINSHOKUHI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKIZAIHI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_991330401_T.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalJINKENHI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKANRIHI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalOTHER_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_41120200_T.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalKEI_T.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalMR_HOTEL.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalMR_HOTEL_TOZEI.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalMR_JR.ToString)))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalTAXI_T.ToString)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalTAXI_SEISAN_T.ToString), True))

            sb.Append(vbNewLine)

            'CSV出力
            Response.Clear()
            Response.ContentType = CmnConst.Csv.ContentType
            Response.Charset = CmnConst.Csv.Charset
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & HttpUtility.UrlEncode("会合費用総合一覧表_" & Now.ToString("yyyyMMddHHmmss") & ".csv"))
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-jis")

            Response.Write(sb.ToString)
            Response.End()
        End If

        Return Now.ToString(format)
    End Function

    ''' <summary>
    ''' 実行完了時メソッド
    ''' </summary>
    ''' <param name="ar"></param>
    ''' <remarks></remarks>
    Private Sub KaigouCallBackMethod(ByVal ar As IAsyncResult)

        Dim asyncResult As System.Runtime.Remoting.Messaging.AsyncResult = CType(ar, System.Runtime.Remoting.Messaging.AsyncResult)
        Dim sample As KaigouDelegate = asyncResult.AsyncDelegate

        Dim result As String = sample.EndInvoke(ar)

        '処理進捗リセット
        'cnt = -1
    End Sub

    Delegate Function DrDelegate(ByVal intLoop As Integer, ByVal format As String) As String

    ''' <summary>
    ''' 参加者旅費費用総合一覧CSV出力　非同期処理
    ''' </summary>
    ''' <param name="intLoop"></param>
    ''' <param name="format"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DrMethod(ByVal intLoop As Integer, ByVal format As String) As String

        '時間のかかる処理を記述する。
        'CSVアップロードであれば、ファイルの保存やループでの取込み処理など。
        Dim i As Integer
        For i = 0 To intLoop
            System.Threading.Thread.Sleep(100)
            '進捗状況は、モジュールの共通変数でやるよりもDBに書いた方がいいかもしれません。
            'cnt = i
        Next

        Return Now.ToString(format)
    End Function

    ''' <summary>
    ''' 実行完了時メソッド
    ''' </summary>
    ''' <param name="ar"></param>
    ''' <remarks></remarks>
    Private Sub DrCallBackMethod(ByVal ar As IAsyncResult)

        Dim asyncResult As System.Runtime.Remoting.Messaging.AsyncResult = CType(ar, System.Runtime.Remoting.Messaging.AsyncResult)
        Dim sample As DrDelegate = asyncResult.AsyncDelegate

        Dim result As String = sample.EndInvoke(ar)

        '処理進捗リセット
        '        cnt = -1
    End Sub

    Delegate Function MrDelegate(ByVal intLoop As Integer, ByVal format As String) As String

    ''' <summary>
    ''' 社員旅費費用総合一覧CSV出力　非同期処理
    ''' </summary>
    ''' <param name="intLoop"></param>
    ''' <param name="format"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function MrMethod(ByVal intLoop As Integer, ByVal format As String) As String

        '時間のかかる処理を記述する。
        'CSVアップロードであれば、ファイルの保存やループでの取込み処理など。
        Dim i As Integer
        For i = 0 To intLoop
            System.Threading.Thread.Sleep(100)
            '進捗状況は、モジュールの共通変数でやるよりもDBに書いた方がいいかもしれません。
            'cnt = i
        Next

        Return Now.ToString(format)
    End Function

    ''' <summary>
    ''' 実行完了時メソッド
    ''' </summary>
    ''' <param name="ar"></param>
    ''' <remarks></remarks>
    Private Sub MrCallBackMethod(ByVal ar As IAsyncResult)

        Dim asyncResult As System.Runtime.Remoting.Messaging.AsyncResult = CType(ar, System.Runtime.Remoting.Messaging.AsyncResult)
        Dim sample As MrDelegate = asyncResult.AsyncDelegate

        Dim result As String = sample.EndInvoke(ar)

        '処理進捗リセット
        'cnt = -1
    End Sub
#End Region
End Class