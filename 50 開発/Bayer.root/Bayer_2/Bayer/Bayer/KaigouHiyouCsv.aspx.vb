Imports CommonLib
Imports AppLib
Imports System.Runtime.Remoting.Messaging.AsyncResult

Partial Public Class KaigouHiyouCsv
    Inherits WebBase

    Private Sub KaigouHiyouCsv_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload

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
        IsPageOK(False, Session.Item(SessionDef.LoginID), Me)

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()

        End If

        Me.BtnCsv.Visible = True
        Me.BtnDL.Visible = False
    End Sub

    '画面項目 初期化    Private Sub InitControls()

        'クリア
        CmnModule.ClearAllControl(Me)

        Me.LabelPageTitle.Text = "会合費用総合一覧表"
        Dim MS_USER As TableDef.MS_USER.DataStruct
        Try
            MS_USER = Session.Item(SessionDef.MS_USER)
        Catch ex As Exception
            Response.Redirect(URL.TimeOut)
        End Try

        Me.TblLoginUser.Visible = True
        Me.LabelLoginUser.Text = MS_USER.LOGIN_ID & "：" & MS_USER.USER_NAME & " 様"

        'CSVダウンロードボタン非表示(データ生成終了時に表示)
        Me.BtnDL.Visible = False
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

    Protected Sub BtnCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCsv.Click

        '入力チェック
        If Not Check() Then Exit Sub

        BtnCsv.Visible = False
        BtnBack.Visible = False

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
            CmnDb.ExecuteForDeligate(strSQL, MyBase.DbConnection)
        Catch ex As Exception
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try
        RsData.Close()

        Dim Jisseki As CsvDelegate = New CsvDelegate(AddressOf CsvMethod)
        Dim callBack As New AsyncCallback(AddressOf CallBackMethod)

        Dim air As IAsyncResult = Jisseki.BeginInvoke(100, "yyyy/MM/dd hh:mm:ss", callBack, Nothing)

        Me.lblStatus.Text = "処理開始"
        '進捗確認用のjavascriptタイマー開始
        Me.ScriptManager1.RegisterStartupScript(Page, Page.GetType(), "Normal", "<script language='JavaScript'>StartTimer();</script>", False)
    End Sub

    Protected Sub BtnCsvRun_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCsvRun.Click
        Dim UpdateFlag As Boolean = False
        Dim csvStr As String = String.Empty

        '処理中件数取得
        Dim strSQL As String = String.Empty
        Dim RsDeligate As System.Data.SqlClient.SqlDataReader
        Dim TBL_DELIGATE2 As New TableDef.TBL_DELIGATE2.DataStruct
        strSQL = SQL.TBL_DELIGATE2.byLOGIN_ID(Session.Item(SessionDef.LoginID))
        RsDeligate = CmnDb.ReadForDeligate(strSQL, MyBase.DbConnection)
        If RsDeligate.Read() Then
            UpdateFlag = True
            TBL_DELIGATE2 = AppModule.SetRsData(RsDeligate, TBL_DELIGATE2)
        End If
        RsDeligate.Close()

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

#Region "デリゲート"

    Delegate Function CsvDelegate(ByVal intLoop As Integer, ByRef format As String) As String

    ''' <summary>
    ''' 会合費用総合一覧CSV出力　非同期処理
    ''' </summary>
    ''' <param name="intLoop"></param>
    ''' <param name="format"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CsvMethod(ByVal intLoop As Integer, ByRef format As String) As String

        '' ''コードマスタ読込み
        ' ''MS_CODE = New List(Of TableDef.MS_CODE.DataStruct)
        Dim rtnStr As String = String.Empty
        Dim strSQL As String = String.Empty
        Dim RsData As System.Data.SqlClient.SqlDataReader
        ' ''CmnDb.DbOpen(MyBase.DbConnection)
        ' ''RsData = CmnDb.ReadForDeligate(strSQL, MyBase.DbConnection)
        ' ''While RsData.Read()
        ' ''    Dim MS_CODE_Item As New TableDef.MS_CODE.DataStruct
        ' ''    With MS_CODE_Item
        ' ''        .CODE = CmnDb.DbData(TableDef.MS_CODE.Column.CODE, RsData)
        ' ''        .DATA_ID = CmnDb.DbData(TableDef.MS_CODE.Column.DATA_ID, RsData)
        ' ''        .DISP_VALUE = CmnDb.DbData(TableDef.MS_CODE.Column.DISP_VALUE, RsData)
        ' ''        .DISP_TEXT = CmnDb.DbData(TableDef.MS_CODE.Column.DISP_TEXT, RsData)
        ' ''    End With
        ' ''    MS_CODE.Add(MS_CODE_Item)
        ' ''End While
        ' ''RsData.Close()

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
            CmnModule.AlertMessage("データ削除に失敗しました。", Me)
            Return False
        End Try

        '出力対象データ読込み
        Dim CsvData() As TableDef.TBL_SEIKYU.DataStruct
        Dim wCnt As Integer = 0
        Dim strSQL2 As String = ""
        Dim RsData2 As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim CsvData(wCnt)

        Dim fromDate As String = ""
        Dim toDate As String = ""
        MyModule.GetSeisanFromTo(Me.JokenSHOUNIN_Y.Text, Me.JokenSHOUNIN_M.Text, fromDate, toDate)

        strSQL2 = SQL.TBL_SEIKYU.KaigouEvidenceCsv(fromDate, toDate)
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
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("慰労会費用")))
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
        If Not Write_TBL_BUNSEKICSV(sb.ToString, wCnt) Then
            RsData2.Close()
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            CmnModule.AlertMessage("対象データ出力に失敗しました。LINE_NO=" & wCnt.ToString, Me)
            Exit Function
        End If
        sb.Remove(0, sb.Length)
        wCnt += 1
        Dim i As Integer = 0


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
        Dim lngTotalIROUKAIHI_T As Long = 0
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

        While RsData2.Read()
            wFlag = True
            ReDim Preserve CsvData(wCnt)
            CsvData(wCnt) = AppModule.SetRsData(RsData2, CsvData(wCnt))

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
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).IROUKAIHI_T)))
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
            lngTotalIROUKAIHI_T += CmnModule.DbVal_Kingaku(CsvData(wCnt).IROUKAIHI_T)
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

            If i = 1000 Then
                i = 0
                '分析CSV出力用テーブル書込み
                If Not Write_TBL_BUNSEKICSV(sb.ToString, wCnt) Then
                    RsData2.Close()
                    CmnDb.DbClose(wDB)
                    wDB.Dispose()
                    CmnModule.AlertMessage("対象データ出力に失敗しました。LINE_NO=" & wCnt.ToString, Me)
                    Exit Function
                End If
                sb.Remove(0, sb.Length)
            End If
            wCnt += 1
        End While

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
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(lngTotalIROUKAIHI_T.ToString)))
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
        rtnStr = sb.ToString

        '分析CSV出力用テーブル書込み
        If Not Write_TBL_BUNSEKICSV(sb.ToString, wCnt) Then
            RsData2.Close()
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            CmnModule.AlertMessage("対象データ出力に失敗しました。LINE_NO=" & wCnt.ToString, Me)
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

        Try
            CmnDb.ExecuteForDeligate(strSQL, MyBase.DbConnection)
        Catch ex As Exception
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
            Return False
        End Try

        Return True
    End Function

    '参加者役割
    Private Function GetName_DR_YAKUWARI(ByVal DR_YAKUWARI As String) As String
        Dim WK_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        WK_CODE = MS_CODE
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If WK_CODE(wCnt).CODE = AppConst.MS_CODE.DR_YAKUWARI AndAlso WK_CODE(wCnt).DISP_VALUE = DR_YAKUWARI Then
                wStr = WK_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    '宿泊部屋タイプ（回答）
    Private Function GetName_ANS_ROOM_TYPE(ByVal ANS_ROOM_TYPE As String) As String
        Dim WK_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        WK_CODE = MS_CODE
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If WK_CODE(wCnt).CODE = AppConst.MS_CODE.ROOM_TYPE AndAlso WK_CODE(wCnt).DISP_VALUE = ANS_ROOM_TYPE Then
                wStr = WK_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    '宿泊ホテル喫煙（依頼）
    Private Function GetName_REQ_HOTEL_SMOKING(ByVal REQ_HOTEL_SMOKING As String) As String
        Dim WK_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        WK_CODE = MS_CODE
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If WK_CODE(wCnt).CODE = AppConst.MS_CODE.REQ_HOTEL_SMOKING AndAlso WK_CODE(wCnt).DISP_VALUE = REQ_HOTEL_SMOKING Then
                wStr = WK_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    '宿泊ホテル喫煙（回答）
    Private Function GetName_ANS_HOTEL_SMOKING(ByVal ANS_HOTEL_SMOKING As String) As String
        Dim WK_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        WK_CODE = MS_CODE
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If WK_CODE(wCnt).CODE = AppConst.MS_CODE.ANS_HOTEL_SMOKING AndAlso WK_CODE(wCnt).DISP_VALUE = ANS_HOTEL_SMOKING Then
                wStr = WK_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    '社員用往路臨席希望（依頼）
    Private Function GetName_REQ_MR_O_TEHAI(ByVal REQ_MR_O_TEHAI As String) As String
        Dim WK_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        WK_CODE = MS_CODE
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If WK_CODE(wCnt).CODE = AppConst.MS_CODE.REQ_MR_TEHAI AndAlso WK_CODE(wCnt).DISP_VALUE = REQ_MR_O_TEHAI Then
                wStr = WK_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    '社員用復路臨席希望（依頼）
    Private Function GetName_REQ_MR_F_TEHAI(ByVal REQ_MR_F_TEHAI As String) As String
        Dim WK_CODE As New List(Of TableDef.MS_CODE.DataStruct)
        Dim wStr As String = ""
        WK_CODE = MS_CODE
        For wCnt As Integer = 0 To MS_CODE.Count - 1
            If WK_CODE(wCnt).CODE = AppConst.MS_CODE.REQ_MR_TEHAI AndAlso WK_CODE(wCnt).DISP_VALUE = REQ_MR_F_TEHAI Then
                wStr = WK_CODE(wCnt).DISP_TEXT
                Exit For
            End If
        Next
        Return wStr
    End Function

    '社員用往路臨席希望（回答）
    Private Function GetName_ANS_MR_O_TEHAI(ByVal ANS_MR_O_TEHAI As String) As String
        Select Case ANS_MR_O_TEHAI
            Case AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.Prepare, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Prepare
                Return AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Prepare
            Case AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.OK, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.OK
                Return AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.OK
            Case AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.Daian, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Daian
                Return AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Daian
            Case AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.Canceled, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Canceled
                Return AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Canceled
            Case AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Code.Fuka, AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Fuka
                Return AppConst.KOTSUHOTEL.ANS_MR_O_TEHAI.Name.Fuka

            Case Else
                Return ""
        End Select
    End Function

    '社員用復路臨席希望（回答）
    Private Function GetName_ANS_MR_F_TEHAI(ByVal ANS_MR_F_TEHAI As String) As String
        Select Case ANS_MR_F_TEHAI
            Case AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.Prepare, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Prepare
                Return AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Prepare
            Case AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.OK, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.OK
                Return AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.OK
            Case AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.Daian, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Daian
                Return AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Daian
            Case AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.Canceled, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Canceled
                Return AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Canceled
            Case AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Code.Fuka, AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Fuka
                Return AppConst.KOTSUHOTEL.ANS_MR_F_TEHAI.Name.Fuka

            Case Else
                Return ""
        End Select
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
        Dim RsDeligate As System.Data.SqlClient.SqlDataReader
        strSQL = SQL.TBL_DELIGATE2.byLOGIN_ID(Session.Item(SessionDef.LoginID))
        RsDeligate = CmnDb.ReadForDeligate(strSQL, MyBase.DbConnection)
        If RsDeligate.Read() Then
            strSQL = SQL.TBL_DELIGATE2.Update(TBL_DELIGATE2)
        Else
            strSQL = SQL.TBL_DELIGATE2.Insert(TBL_DELIGATE2)
        End If
        RsDeligate.Close()
        Try
            CmnDb.ExecuteForDeligate(strSQL, MyBase.DbConnection)
        Catch ex As Exception
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try
        RsDeligate.Close()
    End Sub

#End Region

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
            Dim strSQL As String = Sql.MS_CODE.AllData()
            Dim RsData As System.Data.SqlClient.SqlDataReader
            RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
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
        End If

        Return True
    End Function

    Private Sub BtnDL_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnDL.Click
        Dim UpdateFlag As Boolean = False
        Dim csvStr As String = String.Empty

        'CSV出力用データ取得
        Dim strSQL As String = String.Empty
        Dim RsCsv As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_BUNSEKICSV.byLOGIN_ID(Session.Item(SessionDef.LoginID))
        RsCsv = CmnDb.ReadForDeligate(strSQL, MyBase.DbConnection)
        While RsCsv.Read()
            Dim TBL_BUNSEKICSV As New TableDef.TBL_BUNSEKICSV.DataStruct
            TBL_BUNSEKICSV = AppModule.SetRsData(RsCsv, TBL_BUNSEKICSV)
            csvStr &= TBL_BUNSEKICSV.LINE_DATA
        End While
        RsCsv.Close()

        Dim RsDeligate As System.Data.SqlClient.SqlDataReader
        Dim TBL_DELIGATE2 As New TableDef.TBL_DELIGATE2.DataStruct

        strSQL = SQL.TBL_DELIGATE2.byLOGIN_ID(Session.Item(SessionDef.LoginID))
        RsDeligate = CmnDb.ReadForDeligate(strSQL, MyBase.DbConnection)
        If RsDeligate.Read() Then
            UpdateFlag = True
            TBL_DELIGATE2 = AppModule.SetRsData(RsDeligate, TBL_DELIGATE2)
        End If
        RsDeligate.Close()

        TBL_DELIGATE2.LOGIN_ID = Session.Item(SessionDef.LoginID)
        TBL_DELIGATE2.CNT = "0"
        TBL_DELIGATE2.MAXCNT = "0"

        If UpdateFlag Then
            strSQL = SQL.TBL_DELIGATE2.Update(TBL_DELIGATE2)
        Else
            strSQL = SQL.TBL_DELIGATE2.Insert(TBL_DELIGATE2)
        End If
        Try
            CmnDb.ExecuteForDeligate(strSQL, MyBase.DbConnection)
        Catch ex As Exception
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        'CSV出力
        Response.Clear()
        Response.ContentType = CmnConst.Csv.ContentType
        Response.Charset = CmnConst.Csv.Charset
        Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & HttpUtility.UrlEncode("会合費用総合一覧表_" & Me.JokenSHOUNIN_Y.Text & Me.JokenSHOUNIN_M.Text & "_" & Now.ToString("yyyyMMddHHmmss") & ".csv"))
        Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-jis")

        Response.Write(csvStr)
        Response.End()

        BtnDL.Visible = False
        BtnCsv.Visible = True
        BtnBack.Visible = True
    End Sub
End Class