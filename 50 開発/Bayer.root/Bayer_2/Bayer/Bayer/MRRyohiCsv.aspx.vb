Imports CommonLib
Imports AppLib
Imports System.Runtime.Remoting.Messaging.AsyncResult

Partial Public Class MRRyohiCsv
    Inherits WebBase

    Private Sub MRRyohiCsv_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload

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

        'Me.BtnCsv.Visible = True
        'Me.BtnDL.Visible = False
    End Sub

    '画面項目 初期化    Private Sub InitControls()

        'クリア
        CmnModule.ClearAllControl(Me)

        Me.LabelPageTitle.Text = "社員旅費一覧表"
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

    '社員旅費一覧表CSVボタン

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
            'Me.lblProgress.Text = TBL_DELIGATE.CNT & "/" & TBL_DELIGATE.MAXCNT
        End If
    End Sub

    ''社員旅費一覧表CSV用データ取得

    'Private Function GetEvidenceData(ByRef CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct) As Boolean
    '    Dim wCnt As Integer = 0
    '    Dim strSQL As String = ""
    '    Dim RsData As System.Data.SqlClient.SqlDataReader
    '    Dim wFlag As Boolean = False

    '    ReDim CsvData(wCnt)

    '    Dim fromDate As String = ""
    '    Dim toDate As String = ""
    '    MyModule.GetSeisanFromTo(Me.JokenSHOUNIN_Y.Text, Me.JokenSHOUNIN_M.Text, fromDate, toDate)

    '    strSQL = SQL.TBL_KOTSUHOTEL.DrHiyouCsv(fromDate, toDate)
    '    RsData = CmnDb.ReadForDeligate(strSQL, MyBase.DbConnection)
    '    While RsData.Read()
    '        wFlag = True
    '        ReDim Preserve CsvData(wCnt)
    '        CsvData(wCnt) = AppModule.SetRsData(RsData, CsvData(wCnt))

    '        wCnt += 1

    '        '' ''デリゲートテーブル書込み
    '        ' ''Dim TBL_DELIGATE As TableDef.TBL_DELIGATE.DataStruct = Nothing
    '        ' ''TBL_DELIGATE.LOGIN_ID = Session.Item(SessionDef.LoginID)
    '        ' ''TBL_DELIGATE.CNT = "0"
    '        ' ''TBL_DELIGATE.MAXCNT = wCnt.ToString

    '        '' ''ログインID存在チェック
    '        ' ''Dim RsDeligate As System.Data.SqlClient.SqlDataReader
    '        ' ''strSQL = SQL.TBL_DELIGATE.byLOGIN_ID(Session.Item(SessionDef.LoginID))
    '        ' ''RsDeligate = CmnDb.ReadForDeligate(strSQL, MyBase.DbConnection)
    '        ' ''If RsDeligate.Read() Then
    '        ' ''    strSQL = SQL.TBL_DELIGATE.Update(TBL_DELIGATE)
    '        ' ''Else
    '        ' ''    strSQL = SQL.TBL_DELIGATE.Insert(TBL_DELIGATE)
    '        ' ''End If
    '        ' ''RsDeligate.Close()
    '        ' ''Try
    '        ' ''    CmnDb.ExecuteForDeligate(strSQL, MyBase.DbConnection)
    '        ' ''Catch ex As Exception
    '        ' ''    Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
    '        ' ''End Try
    '    End While
    '    RsData.Close()

    '    If wFlag = False Then
    '        CmnModule.AlertMessage("対象データがありません。", Me)
    '        Return False
    '    End If

    '    'デリゲートテーブル書込み
    '    Dim TBL_DELIGATE As TableDef.TBL_DELIGATE.DataStruct = Nothing
    '    TBL_DELIGATE.LOGIN_ID = Session.Item(SessionDef.LoginID)
    '    TBL_DELIGATE.CNT = "0"
    '    TBL_DELIGATE.MAXCNT = wCnt.ToString

    '    'ログインID存在チェック
    '    Dim RsDeligate As System.Data.SqlClient.SqlDataReader
    '    strSQL = SQL.TBL_DELIGATE.byLOGIN_ID(Session.Item(SessionDef.LoginID))
    '    RsDeligate = CmnDb.ReadForDeligate(strSQL, MyBase.DbConnection)
    '    If RsDeligate.Read() Then
    '        strSQL = SQL.TBL_DELIGATE.Update(TBL_DELIGATE)
    '    Else
    '        strSQL = SQL.TBL_DELIGATE.Insert(TBL_DELIGATE)
    '    End If
    '    RsDeligate.Close()
    '    Try
    '        CmnDb.ExecuteForDeligate(strSQL, MyBase.DbConnection)
    '    Catch ex As Exception
    '        Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))
    '    End Try

    '    Return True
    'End Function

#Region "デリゲート"

    Delegate Function CsvDelegate(ByVal intLoop As Integer, ByRef format As String) As String

    ''' <summary>
    ''' 社員旅費一覧CSV出力　非同期処理
    ''' </summary>
    ''' <param name="intLoop"></param>
    ''' <param name="format"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function CsvMethod(ByVal intLoop As Integer, ByRef format As String) As String

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
        Dim CsvData() As TableDef.TBL_KOTSUHOTEL.DataStruct
        Dim wCnt As Integer = 0
        Dim strSQL2 As String = ""
        Dim RsData2 As System.Data.SqlClient.SqlDataReader
        Dim wFlag As Boolean = False

        ReDim CsvData(wCnt)

        Dim fromDate As String = ""
        Dim toDate As String = ""
        MyModule.GetSeisanFromTo(Me.JokenSHOUNIN_Y.Text, Me.JokenSHOUNIN_M.Text, fromDate, toDate)

        strSQL2 = SQL.TBL_KOTSUHOTEL.MrHiyouCsv(fromDate, toDate)
        'strSQL2 = SQL.TBL_KOTSUHOTEL.DrHiyouCsv(fromDate, toDate)
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
        Dim KEI_HOTELHI As Long = 0
        Dim KEI_HOTELHI_TOZEI As Long = 0
        Dim KEI_KOTSUHI As Long = 0
        Dim KEI_GOUKEI As Long = 0
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

        'ヘッダ列
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("開催開始日")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会場名")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("SRM発注区分")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TT精算年月")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算番号")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("支払番号")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者ID")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("DRコード")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("医師名")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("医師名(カナ)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("施設名")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者役割")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("指定外申請理由")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("出欠状況")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("利用者区分")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員宿泊費都税(込)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員宿泊費都税(-)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員交通費(非課税)(込)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員旅費合計")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("承認者")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのBU")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのエリア名")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの営業所名")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの氏名")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの氏名(カナ)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MR携帯番号")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのCost Center")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Internal order")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("WBS Element")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("zetia Code")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("精算実績WBS Element")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("チケット送付先FS")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("チケット送付先(その他)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配ステータス(依頼)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Timestamp(BYL)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊手配(依頼)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊依頼内容(依頼)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊日(依頼)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("泊数(依頼)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊ホテル喫煙(依頼)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("BYL宿泊備考(依頼)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("Timestamp(TOP)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("手配ステータス(回答)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊ステータス(回答)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊日(回答)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("泊数(回答)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊施設名(回答)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊部屋タイプ(回答)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊ホテル喫煙(回答)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TOP宿泊備考(回答)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("宿泊先電話番号(回答)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("BYL社員用備考(依頼)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ備考(依頼)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TOP交通備考(回答)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("タクチケ備考(回答)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員用往路隣席希望(依頼)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員用復路隣席希望(依頼)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員用往路隣席希望(回答)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員用復路隣席希望(回答)")))
        'sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TOP社員用備考(回答)"), True))

        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合番号")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("開催開始日")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("会合名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのCost Center")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのBU")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRのエリア名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの営業所名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの氏名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("担当MRの氏名(カナ)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("BYL社員用備考(依頼)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員用往路隣席希望(回答)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員用復路隣席希望(回答)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("TOP社員用備考(回答)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員宿泊費(非課税)(込)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員宿泊費都税(-)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("社員交通費(非課税)(込)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("参加者ID")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("医師名")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("医師名(カナ)")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("施設名"), True))

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

            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_DateJP(CsvData(wCnt).FROM_DATE, CmnModule.DateFormatType.MMDD))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KAIJO_NAME)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_SRM_HACYU_KBN(CsvData(wCnt).SRM_HACYU_KBN))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_DateJP(CsvData(wCnt).SEISAN_YM, CmnModule.DateFormatType.YYYYMM))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SEIKYU_NO_TOPTOUR)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHIHARAI_NO)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_CD)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_KANA)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SHISETSU_NAME)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_DR_YAKUWARI(CsvData(wCnt).DR_YAKUWARI))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHITEIGAI_RIYU)))
            'If CsvData(wCnt).DR_SANKA = AppConst.KOTSUHOTEL.DR_SANKA.Code.Yes Then
            '    sb.Append(CmnCsv.SetData("出席"))
            'Else
            '    sb.Append(CmnCsv.SetData("欠席"))
            'End If
            'sb.Append(CmnCsv.SetData("社員"))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI))))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI_TOZEI))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_KOTSUHI))))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(""))
            'Dim dtlUriage As Long = CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI) + CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI_TOZEI) + CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_KOTSUHI)
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(dtlUriage)))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SHONIN_NAME)))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_BU)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_AREA)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_EIGYOSHO)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_NAME)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_KANA)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_KEITAI)))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOTSU_COST_CENTER)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOTSU_INTERNAL_ORDER)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).WBS_ELEMENT_KOUENKAI)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOTSU_ZETIA_CD)))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(""))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).WBS_ELEMENT_KOUENKAI)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_SEND_SAKI_FS)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_SEND_SAKI_OTHER)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_REQ_STATUS_TEHAI(CsvData(wCnt).REQ_STATUS_TEHAI))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).TIME_STAMP_BYL, CmnModule.DateFormatType.YYYYMMDDHHMMSS))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_TEHAI_HOTEL(CsvData(wCnt).TEHAI_HOTEL))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_HOTEL_IRAINAIYOU(CsvData(wCnt).HOTEL_IRAINAIYOU))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).REQ_HOTEL_DATE, CmnModule.DateFormatType.YYYYMMDD))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_REQ_HAKUSU(CsvData(wCnt).REQ_HAKUSU))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_REQ_HOTEL_SMOKING(CsvData(wCnt).REQ_HOTEL_SMOKING))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_HOTEL_NOTE)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).UPDATE_DATE, CmnModule.DateFormatType.YYYYMMDDHHMMSS))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_STATUS_TEHAI(CsvData(wCnt).ANS_STATUS_TEHAI))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_ANS_STATUS_HOTEL(CsvData(wCnt).ANS_STATUS_HOTEL))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_Date(CsvData(wCnt).ANS_HOTEL_DATE, CmnModule.DateFormatType.YYYYMMDD))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(AppModule.GetName_REQ_HAKUSU(CsvData(wCnt).ANS_HAKUSU))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_HOTEL_NAME)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_ROOM_TYPE(CsvData(wCnt).ANS_ROOM_TYPE))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_HOTEL_SMOKING(CsvData(wCnt).ANS_HOTEL_SMOKING))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_HOTEL_NOTE)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_HOTEL_TEL)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_MR_HOTEL_NOTE)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_TAXI_NOTE)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_KOTSU_BIKO)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_TAXI_NOTE)))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_REQ_MR_O_TEHAI(CsvData(wCnt).REQ_MR_O_TEHAI))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_REQ_MR_F_TEHAI(CsvData(wCnt).REQ_MR_F_TEHAI))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_MR_O_TEHAI(CsvData(wCnt).ANS_MR_O_TEHAI))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_ANS_MR_F_TEHAI(CsvData(wCnt).ANS_MR_F_TEHAI))))
            'sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_MR_HOTEL_NOTE), True))

            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.Format_DateJP(CsvData(wCnt).FROM_DATE, CmnModule.DateFormatType.MMDD))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOUENKAI_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).KOTSU_COST_CENTER)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_BU)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_AREA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_EIGYOSHO)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).MR_KANA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).REQ_MR_HOTEL_NOTE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_REQ_MR_O_TEHAI(CsvData(wCnt).REQ_MR_O_TEHAI))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(GetName_REQ_MR_F_TEHAI(CsvData(wCnt).REQ_MR_F_TEHAI))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).ANS_MR_HOTEL_NOTE)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI_TOZEI))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_KOTSUHI))))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).SANKASHA_ID)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_NAME)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_KANA)))
            sb.Append(CmnCsv.SetData(CmnCsv.Quotes(CsvData(wCnt).DR_SHISETSU_NAME), True))
            sb.Append(vbNewLine)

            '合計　加算
            Dim dtlUriage As Long = CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI) + CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI_TOZEI) + CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_KOTSUHI)
            KEI_HOTELHI += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI)
            KEI_HOTELHI_TOZEI += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_HOTELHI_TOZEI)
            KEI_KOTSUHI += CmnModule.DbVal_Kingaku(CsvData(wCnt).ANS_MR_KOTSUHI)
            KEI_GOUKEI += dtlUriage

            'デリゲートテーブル書込み
            Dim TBL_DELIGATE2 As TableDef.TBL_DELIGATE2.DataStruct = Nothing
            TBL_DELIGATE2.LOGIN_ID = Session.Item(SessionDef.LoginID)
            TBL_DELIGATE2.CNT = wCnt.ToString
            strSQL = SQL.TBL_DELIGATE2.Update(TBL_DELIGATE2)
            Try

                CmnDb.ExecuteForDeligate(strSQL, MyBase.DbConnection)
            Catch ex As Exception
                CmnDb.DbClose(wDB)
                wDB.Dispose()
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
        RsData2.Close()

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
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_HOTELHI)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_HOTELHI_TOZEI)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_KOTSUHI)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(KEI_GOUKEI)))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes("")))
        sb.Append(CmnCsv.SetData(CmnCsv.Quotes(""), True))
        sb.Append(vbNewLine)
        rtnStr = sb.ToString

        If Not Write_TBL_BUNSEKICSV(sb.ToString, wCnt) Then
            CmnDb.DbClose(wDB)
            wDB.Dispose()
            CmnModule.AlertMessage("対象データ出力に失敗しました。LINE_NO=" & wCnt.ToString, Me)
            Exit Function
        End If
        sb.Remove(0, sb.Length)
        wCnt += 1

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
        Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & HttpUtility.UrlEncode("社員旅費一覧表_" & Me.JokenSHOUNIN_Y.Text & Me.JokenSHOUNIN_M.Text & "_" & Now.ToString("yyyyMMddHHmmss") & ".csv"))
        Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-jis")

        Response.Write(csvStr)
        Response.End()

        BtnDL.Visible = False
        BtnCsv.Visible = True
        BtnBack.Visible = True
    End Sub
End Class