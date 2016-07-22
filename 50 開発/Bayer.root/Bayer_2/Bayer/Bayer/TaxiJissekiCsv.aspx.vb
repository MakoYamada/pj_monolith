﻿Imports CommonLib
Imports AppLib
Imports System.Runtime.Remoting.Messaging.AsyncResult

Partial Public Class TaxiJissekiCsv
    Inherits WebBase

    Private Sub TaxiJissekiCsv_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload

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

    'タクチケ一覧表CSVボタン

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
            'Me.lblProgress.Text = TBL_DELIGATE2.CNT & "/" & TBL_DELIGATE2.MAXCNT
        End If
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
        Dim strSQL As String = SQL.MS_CODE.AllData()
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
        Dim CsvData() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
        Dim wCnt As Integer = 0
        Dim strSQL2 As String = ""
        Dim RsData2 As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim CsvData(wCnt)

        Dim fromDate As String = ""
        Dim toDate As String = ""
        MyModule.GetSeisanFromTo(Me.JokenSHOUNIN_Y.Text, Me.JokenSHOUNIN_M.Text, fromDate, toDate)

        strSQL2 = SQL.TBL_TAXITICKET_HAKKO.TaxiJissekiCsv(fromDate, toDate)
        Try
            RsData2 = CmnDb.ReadForDeligate(strSQL2, wDB)
            If Not RsData2.HasRows Then
                RsData2.Close()
                CmnDb.DbClose(wDB)
                wDB.Dispose()
                CmnModule.AlertMessage("対象データがありません。", Me)
                Return False
            End If
        Catch ex As Exception
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
        End Try

        'CSV出力内容生成
        Dim sb As New System.Text.StringBuilder
        Dim KEI_1 As Long = 0
        Dim KEI_2 As Long = 0
        Dim KEI_3 As Long = 0
        Dim KEI_4 As Long = 0
        Dim KEI_5 As Long = 0
        Dim KEI_6 As Long = 0
        Dim KEI_7 As Long = 0
        Dim KEI_8 As Long = 0
        Dim KEI_9 As Long = 0
        Dim KEI_10 As Long = 0
        Dim KEI_HAKKO_FEE As Long = 0
        Dim KEI_SEISAN_FEE As Long = 0
        Dim KEI_URIAGE As Long = 0
        Dim KEI_GOUKEI As Long = 0

        'ヘッダ列
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("開催開始日")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会場名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("SRM発注区分")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TT精算年月")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算番号")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("支払番号")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者ID")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DRコード")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("医師名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("医師名(カナ)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("施設名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者役割")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("指定外申請理由")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("出欠状況")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("利用者区分")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ発行手数料(込)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ精算手数料(込)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ実車料金")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ合計")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("エンタ")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者BU")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者エリア名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者営業所名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者氏名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("企画担当者氏名(ローマ字)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("基本情報Account Code(非課税)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("基本情報Account Code(課税)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("基本情報企画担当者のCost Center")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのBU")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのエリア名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの営業所名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの氏名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの氏名(カナ)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR携帯番号")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのAccount Code")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者情報のAccount Code")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのCost Center")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Internal order(非課税)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("WBS Element")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("zetia Code")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算実績Account Code")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算実績Cost Center")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算実績Internal order")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算実績WBS Element")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ番号")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("ステータス")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算月")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("利用予定日")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("利用日(実車)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ会社")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("発行券種(金額)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("発地(実車)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("着地(実車)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケTTT備考")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ備考(依頼)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ備考(回答)"), True))
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

        While RsData2.Read()
            wFlag = True
            ReDim Preserve CsvData(wCnt)
            CsvData(wCnt) = AppModule.SetRsData(RsData2, CsvData(wCnt))
            Dim drRyohiKei As Long = 0

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_DateJP(CsvData(wCnt).FROM_DATE, CmnModule.DateFormatType.MMDD))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIJO_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SRM_HACYU_KBN(CsvData(wCnt).SRM_HACYU_KBN))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_DateJP(CsvData(wCnt).SEISAN_YM, CmnModule.DateFormatType.YYYYMM))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEIKYU_NO_TOPTOUR)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHIHARAI_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_CD)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_KANA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SHISETSU_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_DR_YAKUWARI(CsvData(wCnt).DR_YAKUWARI))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHITEIGAI_RIYU)))
            If CsvData(wCnt).SANKA_FLAG = AppConst.KOTSUHOTEL.DR_SANKA.Code.Yes Then
                sb.Append(CmnCsv.SetData("出席"))
            ElseIf CsvData(wCnt).SANKA_FLAG = AppConst.KOTSUHOTEL.DR_SANKA.Code.No Then
                sb.Append(CmnCsv.SetData("欠席"))
            Else
                sb.Append(CmnCsv.SetData(""))
            End If
            sb.Append(CmnCsv.SetData("HCP"))
            sb.Append(CmnCsv.SetData(""))
            sb.Append(CmnCsv.SetData(""))
            sb.Append(CmnCsv.SetData(""))
            sb.Append(CmnCsv.SetData(""))
            sb.Append(CmnCsv.SetData(""))
            sb.Append(CmnCsv.SetData(""))
            sb.Append(CmnCsv.SetData(""))
            sb.Append(CmnCsv.SetData(""))
            sb.Append(CmnCsv.SetData(""))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_HAKKO_FEE))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_SEISAN_FEE))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_URIAGE))))

            Dim dtlUriage As Long = CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_HAKKO_FEE) + CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_SEISAN_FEE) + CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_URIAGE)
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(dtlUriage)))

            sb.Append(CmnCsv.SetData(""))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_ENTA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).BU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_AREA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_EIGYOSHO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIKAKU_TANTO_ROMA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_ACCOUNT_CD_TF)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_ACCOUNT_CD_T)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_COST_CENTER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_BU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_AREA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_EIGYOSHO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_KANA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_KEITAI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOTSU_ACCOUNT_CD)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOTSU_COST_CENTER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_INTERNAL_ORDER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).WBS_ELEMENT_KOUENKAI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_ZETIA_CD)))
            '精算実績
            If CsvData(wCnt).TKT_ENTA = "E" Then
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes("6833200")))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOTSU_COST_CENTER)))
                sb.Append(CmnCsv.SetData(""))
                sb.Append(CmnCsv.SetData(""))
            Else
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_ACCOUNT_CD_TF)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_COST_CENTER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KIHON_INTERNAL_ORDER)))
                sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).WBS_ELEMENT_KOUENKAI)))
            End If
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes("請求済")))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).SEISAN_YM, CmnModule.DateFormatType.YYYYMM))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_TAXI_DATE, CmnModule.DateFormatType.YYYYMMDD))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).TKT_USED_DATE, CmnModule.DateFormatType.YYYYMMDD))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_KAISHA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_KENSHU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_HATUTI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).TKT_CHAKUTI)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_RMKS)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_TAXI_NOTE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NOTE), True))
            sb.Append(vbNewLine)

            '合計　加算
            KEI_URIAGE += CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_URIAGE)
            KEI_SEISAN_FEE += CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_SEISAN_FEE)
            KEI_HAKKO_FEE += CmnModule.DbVal_Kingaku(CsvData(wCnt).TKT_HAKKO_FEE)
            KEI_GOUKEI += dtlUriage

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
                    CmnModule.AlertMessage("対象データ出力に失敗しました。LINE_NO=" & wCnt.ToString, Me)
                    Exit Function
                End If
                sb.Remove(0, sb.Length)
            End If

            wCnt += 1
        End While

        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("合計(込)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_1)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_2)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_3)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_4)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_5)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_6)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_7)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_8)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_9)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_HAKKO_FEE)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_SEISAN_FEE)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_URIAGE)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_GOUKEI)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_10)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
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
            Dim strSQL As String = SQL.MS_CODE.AllData()
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
        Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & HttpUtility.UrlEncode("タクチケ一覧_" & Me.JokenSHOUNIN_Y.Text & Me.JokenSHOUNIN_M.Text & "_" & Now.ToString("yyyyMMddHHmmss") & ".csv"))
        Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-jis")

        Response.Write(csvStr)
        Response.End()

        BtnDL.Visible = False
        BtnCsv.Visible = True
        BtnBack.Visible = True
    End Sub
End Class