Imports CommonLib
Imports AppLib
Imports System.Runtime.Remoting.Messaging.AsyncResult

Partial Public Class TaxiMeisaiCsv2
    Inherits WebBase

    Private Joken As TableDef.Joken.DataStruct

    Private Sub TaxiJissekiCsv_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
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
        IsPageOK(False, Session.Item(SessionDef.LoginID), Me)
        'セッションを変数に格納
        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

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

        Me.LabelPageTitle.Text = "タクチケ一覧表"
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

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            Joken = Session.Item(SessionDef.Joken)
        Catch ex As Exception
            Joken = Nothing
        End Try
        Return True
    End Function

    '[戻る]
    Private Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        Response.Redirect(URL.Menu)
    End Sub

    'タクチケ一覧表CSVボタン

    Protected Sub BtnCsv_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCsv.Click

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
        strSQL = Sql.TBL_DELIGATE2.byLOGIN_ID(Session.Item(SessionDef.LoginID))
        RsData = CmnDb.ReadForDeligate(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            strSQL = Sql.TBL_DELIGATE2.Update(TBL_DELIGATE2)
        Else
            strSQL = Sql.TBL_DELIGATE2.Insert(TBL_DELIGATE2)
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
        strSQL = Sql.TBL_DELIGATE2.byLOGIN_ID(Session.Item(SessionDef.LoginID))
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
            'Me.lblProgress.Text = TBL_DELIGATE2.CNT & "/" & TBL_DELIGATE2.MAXCNT
        End If
    End Sub

    '[タクシーチケット管理メニューへ]
    Protected Sub LnkBTaxiMenu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LnkBTaxiMenu.Click
        '不要なセッションを破棄
        MyModule.ClearSession()

        Response.Redirect(URL.TaxiMenu)
    End Sub

#Region "デリゲート"

    Delegate Function CsvDelegate(ByVal intLoop As Integer, ByRef format As String) As String

    ''' <summary>
    ''' タクチケ一覧CSV出力　非同期処理
    ''' </summary>
    ''' <param name="intLoop"></param>
    ''' <param name="format"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CsvMethod(ByVal intLoop As Integer, ByRef format As String) As String

        'コードマスタ読込み
        MS_CODE = New List(Of TableDef.MS_CODE.DataStruct)
        Dim rtnStr As String = String.Empty
        Dim strSQL As String = Sql.MS_CODE.AllData()
        Dim RsData As System.Data.SqlClient.SqlDataReader
        CmnDb.DbOpen(MyBase.DbConnection)
        RsData = CmnDb.ReadForDeligate(strSQL, MyBase.DbConnection)
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

        Dim wDB As SqlClient.SqlConnection
        wDB = New SqlClient.SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))
        Try
            CmnDb.DbOpen(wDB)
        Catch ex As Exception
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
            Return String.Empty
        End Try

        '前回出力結果削除
        Dim TBL_BUNSEKICSV As TableDef.TBL_BUNSEKICSV.DataStruct = Nothing
        TBL_BUNSEKICSV.LOGIN_ID = Session.Item(SessionDef.LoginID)
        Dim strSQL3 As String = Sql.TBL_BUNSEKICSV.Delete(TBL_BUNSEKICSV)
        Try
            CmnDb.ExecuteForDeligate(strSQL3, wDB)
        Catch ex As Exception
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            CmnModule.AlertMessage("データ削除に失敗しました。", Me)
            Return String.Empty
        End Try

        '出力対象データ読込み
        Dim wCnt As Integer = 0
        Dim wFlag As Boolean = False

        Dim CsvData() As TableDef.TaxiMeisaiCsv.DataStruct
        Dim strSQL2 As String = ""
        Dim strSQL4 As String = ""
        Dim RsData2 As System.Data.SqlClient.SqlDataReader
        Dim RsData4 As System.Data.SqlClient.SqlDataReader
        Dim TBL_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct
        Dim TBL_TAXITICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
        Dim TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct

        ReDim CsvData(wCnt)

        '会合情報
        strSQL2 = Sql.TBL_KOUENKAI.byKOUENKAI_NO(Joken.KOUENKAI_NO)
        Try
            RsData2 = CmnDb.ReadForDeligate(strSQL2, wDB)
            If Not RsData2.HasRows Then
                RsData2.Close()
                CmnDb.DbClose(wDB)
                wDB.Dispose()
                CmnModule.AlertMessage("対象データがありません。", Me)
                Return String.Empty
            Else
                RsData2.Read()
                TBL_KOUENKAI = AppModule.SetRsData(RsData2, TBL_KOUENKAI)
            End If
            RsData2.Close()
        Catch ex As Exception
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        'タクチケ情報
        strSQL4 = Sql.TBL_TAXITICKET_HAKKO.TaxiMeisaiCsv(Joken)
        RsData4 = CmnDb.ReadForDeligate(strSQL4, wDB)


        'CSV出力内容生成
        Dim sb As New System.Text.StringBuilder

        'ヘッダ列
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
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合のZetia Code")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR BU")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRエリア名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR営業所")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR氏名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Account Code(課税)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのCost Center")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ会社"), True))
        sb.Append(vbNewLine)

        If Not Write_TBL_BUNSEKICSV(sb.ToString, wCnt) Then
            RsData4.Close()
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            CmnModule.AlertMessage("対象データ出力に失敗しました。LINE_NO=" & wCnt.ToString, Me)
            Return String.Empty
        End If
        sb.Remove(0, sb.Length)
        wCnt += 1
        Dim i As Integer = 0

        While RsData4.Read()
            wFlag = True
            ReDim Preserve TBL_TAXITICKET_HAKKO(wCnt)
            TBL_TAXITICKET_HAKKO(wCnt) = AppModule.SetRsData(RsData4, TBL_TAXITICKET_HAKKO(wCnt))
            If Trim(TBL_TAXITICKET_HAKKO(wCnt).SANKASHA_ID) <> "" AndAlso Val(TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO) <> 0 Then

                Dim wDB2 As SqlClient.SqlConnection
                wDB2 = New SqlClient.SqlConnection(ConfigurationManager.AppSettings("ConnectionString"))
                Try
                    CmnDb.DbOpen(wDB2)
                Catch ex As Exception
                    Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
                    Return String.Empty
                End Try

                Dim strSQL5 As String = SQL.TBL_KOTSUHOTEL.byTKT_NO_TKT_LINE_NO(TBL_TAXITICKET_HAKKO(wCnt).SANKASHA_ID, TBL_TAXITICKET_HAKKO(wCnt).TKT_NO, TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO)
                Dim RsData5 As System.Data.SqlClient.SqlDataReader
                RsData5 = CmnDb.ReadForDeligate(strSQL5, wDB2)
                If RsData5.HasRows Then
                    RsData5.Read()
                    TBL_KOTSUHOTEL = AppModule.SetRsData(RsData5, TBL_KOTSUHOTEL)

                    Select Case CInt(TBL_TAXITICKET_HAKKO(wCnt).TKT_LINE_NO).ToString
                        Case "1"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_1
                        Case "2"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_2
                        Case "3"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_3
                        Case "4"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_4
                        Case "5"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_5
                        Case "6"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_6
                        Case "7"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_7
                        Case "8"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_8
                        Case "9"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_9
                        Case "10"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_10
                        Case "11"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_11
                        Case "12"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_12
                        Case "13"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_13
                        Case "14"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_14
                        Case "15"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_15
                        Case "16"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_16
                        Case "17"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_17
                        Case "18"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_18
                        Case "19"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_19
                        Case "20"
                            TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = TBL_KOTSUHOTEL.ANS_TAXI_DATE_20
                    End Select
                    TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE = CmnModule.Format_Date(TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDD)
                    TBL_TAXITICKET_HAKKO(wCnt).DR_SHISETSU_NAME = TBL_KOTSUHOTEL.DR_SHISETSU_NAME
                    TBL_TAXITICKET_HAKKO(wCnt).DR_NAME = TBL_KOTSUHOTEL.DR_NAME
                    TBL_TAXITICKET_HAKKO(wCnt).DR_SANKA = GetName_DR_SANKA(TBL_KOTSUHOTEL.DR_SANKA)
                    TBL_TAXITICKET_HAKKO(wCnt).DR_CD = TBL_KOTSUHOTEL.DR_CD
                    TBL_TAXITICKET_HAKKO(wCnt).KOTSU_COST_CENTER = TBL_KOTSUHOTEL.COST_CENTER
                    TBL_TAXITICKET_HAKKO(wCnt).MR_BU = TBL_KOTSUHOTEL.MR_BU
                    TBL_TAXITICKET_HAKKO(wCnt).MR_AREA = TBL_KOTSUHOTEL.MR_AREA
                    TBL_TAXITICKET_HAKKO(wCnt).MR_EIGYOSHO = TBL_KOTSUHOTEL.MR_EIGYOSHO
                    TBL_TAXITICKET_HAKKO(wCnt).MR_NAME = TBL_KOTSUHOTEL.MR_NAME
                    'TBL_TAXITICKET_HAKKO(wCnt).DR_YAKUWARI = AppModule.GetName_DR_YAKUWARI(TBL_KOTSUHOTEL.DR_YAKUWARI)

                End If
                RsData5.Close()
                CmnDb.DbClose(wDB2)
            End If

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOUENKAI.KOUENKAI_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOUENKAI.KOUENKAI_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_TAXITICKET_HAKKO(wCnt).DR_SHISETSU_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_TAXITICKET_HAKKO(wCnt).DR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_TAXITICKET_HAKKO(wCnt).DR_SANKA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_STATUS(TBL_TAXITICKET_HAKKO(wCnt).TKT_SEIKYU_YM, TBL_TAXITICKET_HAKKO(wCnt).TKT_VOID))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetNameTKT_KENSHU(TBL_TAXITICKET_HAKKO(wCnt).TKT_KENSHU))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_TAXITICKET_HAKKO(wCnt).TKT_NO)))
            sb.Append(CmnCsv.SetData(TBL_TAXITICKET_HAKKO(wCnt).TKT_URIAGE))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_TAXITICKET_HAKKO(wCnt).TKT_ENTA)))
            sb.Append(CmnCsv.SetData(TBL_TAXITICKET_HAKKO(wCnt).TKT_HAKKO_FEE))
            sb.Append(CmnCsv.SetData(TBL_TAXITICKET_HAKKO(wCnt).TKT_SEISAN_FEE))
            sb.Append(CmnCsv.SetData(CmnModule.DbVal(TBL_TAXITICKET_HAKKO(wCnt).TKT_URIAGE) + CmnModule.DbVal(TBL_TAXITICKET_HAKKO(wCnt).TKT_SEISAN_FEE) + CmnModule.DbVal(TBL_TAXITICKET_HAKKO(wCnt).TKT_HAKKO_FEE).ToString))
            sb.Append(CmnCsv.SetData(CmnModule.Format_Date(TBL_TAXITICKET_HAKKO(wCnt).TKT_SEIKYU_YM, CmnModule.DateFormatType.YYYYMM)))
            sb.Append(CmnCsv.SetData(GetName_VOID(TBL_TAXITICKET_HAKKO(wCnt).TKT_VOID)))
            sb.Append(CmnCsv.SetData(GetName_DR_YAKUWARI(TBL_KOTSUHOTEL.DR_YAKUWARI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_TAXITICKET_HAKKO(wCnt).SANKASHA_ID)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_TAXITICKET_HAKKO(wCnt).DR_CD)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOUENKAI.KIKAKU_TANTO_JIGYOUBU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOUENKAI.KIKAKU_TANTO_AREA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOUENKAI.KIKAKU_TANTO_EIGYOSHO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOUENKAI.KIKAKU_TANTO_NAME)))
            sb.Append(CmnCsv.SetData(CmnModule.Format_Date(TBL_TAXITICKET_HAKKO(wCnt).FROM_DATE, CmnModule.DateFormatType.YYYYMMDD)))
            sb.Append(CmnCsv.SetData(TBL_TAXITICKET_HAKKO(wCnt).ANS_TAXI_DATE))
            sb.Append(CmnCsv.SetData(TBL_TAXITICKET_HAKKO(wCnt).TKT_USED_DATE))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOUENKAI.ACCOUNT_CD_TF)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOUENKAI.COST_CENTER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOUENKAI.INTERNAL_ORDER_TF)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOUENKAI.ZETIA_CD)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.MR_BU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.MR_AREA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.MR_EIGYOSHO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.MR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("6833200")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_KOTSUHOTEL.KOTSU_COST_CENTER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(TBL_TAXITICKET_HAKKO(wCnt).TKT_KAISHA)))
            sb.Append(vbNewLine)

            'デリゲートテーブル書込み
            Dim TBL_DELIGATE2 As TableDef.TBL_DELIGATE2.DataStruct = Nothing
            TBL_DELIGATE2.LOGIN_ID = Session.Item(SessionDef.LoginID)
            TBL_DELIGATE2.CNT = wCnt.ToString
            strSQL = Sql.TBL_DELIGATE2.Update(TBL_DELIGATE2)
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
                    RsData4.Close()
                    CmnModule.AlertMessage("対象データ出力に失敗しました。LINE_NO=" & wCnt.ToString, Me)
                    Return String.Empty
                End If
                sb.Remove(0, sb.Length)
            End If

            wCnt += 1
        End While

        '分析CSV出力用テーブル書込み
        If Not Write_TBL_BUNSEKICSV(sb.ToString, wCnt) Then
            RsData4.Close()
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            CmnModule.AlertMessage("対象データ出力に失敗しました。LINE_NO=" & wCnt.ToString, Me)
            Return String.Empty
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
        Dim strSQL As String = Sql.TBL_BUNSEKICSV.Insert(TBL_BUNSEKICSV)

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
        strSQL = Sql.TBL_DELIGATE2.byLOGIN_ID(Session.Item(SessionDef.LoginID))
        RsDeligate = CmnDb.ReadForDeligate(strSQL, MyBase.DbConnection)
        If RsDeligate.Read() Then
            strSQL = Sql.TBL_DELIGATE2.Update(TBL_DELIGATE2)
        Else
            strSQL = Sql.TBL_DELIGATE2.Insert(TBL_DELIGATE2)
        End If
        RsDeligate.Close()
        'MyBase.BeginTransaction()
        Try
            CmnDb.ExecuteForDeligate(strSQL, MyBase.DbConnection)
            'MyBase.Commit()
        Catch ex As Exception
            'MyBase.Rollback()
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
            CmnDb.DbOpen(MyBase.DbConnection)
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

        strSQL = Sql.TBL_BUNSEKICSV.byLOGIN_ID(Session.Item(SessionDef.LoginID))
        RsCsv = CmnDb.ReadForDeligate(strSQL, MyBase.DbConnection)
        While RsCsv.Read()
            Dim TBL_BUNSEKICSV As New TableDef.TBL_BUNSEKICSV.DataStruct
            TBL_BUNSEKICSV = AppModule.SetRsData(RsCsv, TBL_BUNSEKICSV)
            csvStr &= TBL_BUNSEKICSV.LINE_DATA
        End While
        RsCsv.Close()

        Dim RsDeligate As System.Data.SqlClient.SqlDataReader
        Dim TBL_DELIGATE2 As New TableDef.TBL_DELIGATE2.DataStruct

        strSQL = Sql.TBL_DELIGATE2.byLOGIN_ID(Session.Item(SessionDef.LoginID))
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
            strSQL = Sql.TBL_DELIGATE2.Update(TBL_DELIGATE2)
        Else
            strSQL = Sql.TBL_DELIGATE2.Insert(TBL_DELIGATE2)
        End If
        Try
            CmnDb.ExecuteForDeligate(strSQL, MyBase.DbConnection)
        Catch ex As Exception
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        Dim wFileName As String = ""
        wFileName = Joken.KOUENKAI_NO
        If Joken.TKT_ENTA = AppConst.TAXITICKET_HAKKO.TKT_ENTA.Joken_MeisaiCsv.N_Only Then
            wFileName &= "_SeikyuFuka"
        Else
        End If
        wFileName &= ".csv"

        'CSV出力
        Response.Clear()
        Response.ContentType = CmnConst.Csv.ContentType
        Response.Charset = CmnConst.Csv.Charset
        Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & HttpUtility.UrlEncode(Joken.KOUENKAI_NO & ".csv"))
        Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-jis")

        Response.Write(csvStr)
        Response.End()

        BtnDL.Visible = False
        BtnCsv.Visible = True
        BtnBack.Visible = True
    End Sub

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
End Class