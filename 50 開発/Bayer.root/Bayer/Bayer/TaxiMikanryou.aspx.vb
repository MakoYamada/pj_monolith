Imports CommonLib
Imports AppLib
Imports System.IO

Partial Public Class TaxiMikanryou
    Inherits WebBase

    Private TBL_TAXITICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
    Private Joken As TableDef.Joken.DataStruct

    'グリッド列    Private Enum CellIndex
        JISSHI_DATE
        KOUENKAI_NAME
        DR_NAME
        USER_NAME
        TKT_NO
        TKT_KENSHU
        ANS_TAXI_DATE
        ANS_TAXI_HAKKO_DATE
        ANS_TAXI_RMKS
        TKT_USED_DATE
        TKT_SEIKYU_YM
        VOID_DATE
        TKT_LINE_NO
        BUTTON
        KOUENKAI_NO
        SANKASHA_ID
        FROM_DATE
        TO_DATE
        TKT_VOID
        UPDATE_DATE
        ANS_TAXI_DATE_1
        ANS_TAXI_KENSHU_1
        ANS_TAXI_NO_1
        ANS_TAXI_HAKKO_1
        ANS_TAXI_HAKKO_DATE_1
        ANS_TAXI_RMKS_1
        ANS_TAXI_DATE_2
        ANS_TAXI_KENSHU_2
        ANS_TAXI_NO_2
        ANS_TAXI_HAKKO_2
        ANS_TAXI_HAKKO_DATE_2
        ANS_TAXI_RMKS_2
        ANS_TAXI_DATE_3
        ANS_TAXI_KENSHU_3
        ANS_TAXI_NO_3
        ANS_TAXI_HAKKO_3
        ANS_TAXI_HAKKO_DATE_3
        ANS_TAXI_RMKS_3
        ANS_TAXI_DATE_4
        ANS_TAXI_KENSHU_4
        ANS_TAXI_NO_4
        ANS_TAXI_HAKKO_4
        ANS_TAXI_HAKKO_DATE_4
        ANS_TAXI_RMKS_4
        ANS_TAXI_DATE_5
        ANS_TAXI_KENSHU_5
        ANS_TAXI_NO_5
        ANS_TAXI_HAKKO_5
        ANS_TAXI_HAKKO_DATE_5
        ANS_TAXI_RMKS_5
        ANS_TAXI_DATE_6
        ANS_TAXI_KENSHU_6
        ANS_TAXI_NO_6
        ANS_TAXI_HAKKO_6
        ANS_TAXI_HAKKO_DATE_6
        ANS_TAXI_RMKS_6
        ANS_TAXI_DATE_7
        ANS_TAXI_KENSHU_7
        ANS_TAXI_NO_7
        ANS_TAXI_HAKKO_7
        ANS_TAXI_HAKKO_DATE_7
        ANS_TAXI_RMKS_7
        ANS_TAXI_DATE_8
        ANS_TAXI_KENSHU_8
        ANS_TAXI_NO_8
        ANS_TAXI_HAKKO_8
        ANS_TAXI_HAKKO_DATE_8
        ANS_TAXI_RMKS_8
        ANS_TAXI_DATE_9
        ANS_TAXI_KENSHU_9
        ANS_TAXI_NO_9
        ANS_TAXI_HAKKO_9
        ANS_TAXI_HAKKO_DATE_9
        ANS_TAXI_RMKS_9
        ANS_TAXI_DATE_10
        ANS_TAXI_KENSHU_10
        ANS_TAXI_NO_10
        ANS_TAXI_HAKKO_10
        ANS_TAXI_HAKKO_DATE_10
        ANS_TAXI_RMKS_10
        ANS_TAXI_DATE_11
        ANS_TAXI_KENSHU_11
        ANS_TAXI_NO_11
        ANS_TAXI_HAKKO_11
        ANS_TAXI_HAKKO_DATE_11
        ANS_TAXI_RMKS_11
        ANS_TAXI_DATE_12
        ANS_TAXI_KENSHU_12
        ANS_TAXI_NO_12
        ANS_TAXI_HAKKO_12
        ANS_TAXI_HAKKO_DATE_12
        ANS_TAXI_RMKS_12
        ANS_TAXI_DATE_13
        ANS_TAXI_KENSHU_13
        ANS_TAXI_NO_13
        ANS_TAXI_HAKKO_13
        ANS_TAXI_HAKKO_DATE_13
        ANS_TAXI_RMKS_13
        ANS_TAXI_DATE_14
        ANS_TAXI_KENSHU_14
        ANS_TAXI_NO_14
        ANS_TAXI_HAKKO_14
        ANS_TAXI_HAKKO_DATE_14
        ANS_TAXI_RMKS_14
        ANS_TAXI_DATE_15
        ANS_TAXI_KENSHU_15
        ANS_TAXI_NO_15
        ANS_TAXI_HAKKO_15
        ANS_TAXI_HAKKO_DATE_15
        ANS_TAXI_RMKS_15
        ANS_TAXI_DATE_16
        ANS_TAXI_KENSHU_16
        ANS_TAXI_NO_16
        ANS_TAXI_HAKKO_16
        ANS_TAXI_HAKKO_DATE_16
        ANS_TAXI_RMKS_16
        ANS_TAXI_DATE_17
        ANS_TAXI_KENSHU_17
        ANS_TAXI_NO_17
        ANS_TAXI_HAKKO_17
        ANS_TAXI_HAKKO_DATE_17
        ANS_TAXI_RMKS_17
        ANS_TAXI_DATE_18
        ANS_TAXI_KENSHU_18
        ANS_TAXI_NO_18
        ANS_TAXI_HAKKO_18
        ANS_TAXI_HAKKO_DATE_18
        ANS_TAXI_RMKS_18
        ANS_TAXI_DATE_19
        ANS_TAXI_KENSHU_19
        ANS_TAXI_NO_19
        ANS_TAXI_HAKKO_19
        ANS_TAXI_HAKKO_DATE_19
        ANS_TAXI_RMKS_19
        ANS_TAXI_DATE_20
        ANS_TAXI_KENSHU_20
        ANS_TAXI_NO_20
        ANS_TAXI_HAKKO_20
        ANS_TAXI_HAKKO_DATE_20
        ANS_TAXI_RMKS_20
    End Enum

    Private Sub DrList_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        Session.Item(SessionDef.TBL_TAXITICKET_HAKKO) = TBL_TAXITICKET_HAKKO
        Session.Item(SessionDef.Joken) = Joken
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '共通チェック
        MyModule.IsPageOK(False, Session.Item(SessionDef.LoginID), Me)

        'セッションを変数に格納        If Not SetSession() Then
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
            .PageTitle = "未決一覧"
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
            TBL_TAXITICKET_HAKKO = Session.Item(SessionDef.TBL_TAXITICKET_HAKKO)
            If TBL_TAXITICKET_HAKKO Is Nothing Then ReDim TBL_TAXITICKET_HAKKO(0)
        Catch ex As Exception
            ReDim TBL_TAXITICKET_HAKKO(0)
        End Try
        Return True
    End Function

    '画面項目 初期化    Private Sub InitControls()

        'IME設定        CmnModule.SetIme(Me.JokenFROM_DATE_YYYY, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenFROM_DATE_MM, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenFROM_DATE_DD, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenTO_DATE_YYYY, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenTO_DATE_MM, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.JokenTO_DATE_DD, CmnModule.ImeType.InActive)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()

        'データ取得
        If Not GetData() Then
            Me.LabelNoData.Visible = True
        Else
            Me.LabelNoData.Visible = False
        End If
    End Sub

    'データ取得
    Private Function GetData() As Boolean
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        Joken = Nothing
        Joken.FROM_DATE = CmnModule.Format_DateToString(Me.JokenFROM_DATE_YYYY.Text, Me.JokenFROM_DATE_MM.Text, Me.JokenFROM_DATE_DD.Text)
        Joken.TO_DATE = CmnModule.Format_DateToString(Me.JokenTO_DATE_YYYY.Text, Me.JokenTO_DATE_MM.Text, Me.JokenTO_DATE_DD.Text)

        ReDim TBL_TAXITICKET_HAKKO(wCnt)

        strSQL = Sql.TBL_TAXITICKET_HAKKO.Search(Joken, True)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        While RsData.Read()
            wFlag = True

            ReDim Preserve TBL_TAXITICKET_HAKKO(wCnt)
            TBL_TAXITICKET_HAKKO(wCnt) = AppModule.SetRsData(RsData, TBL_TAXITICKET_HAKKO(wCnt))

            wCnt += 1
        End While
        RsData.Close()

        Return wFlag
    End Function

    '一覧 表示
    Private Sub DispList()

        'データ取得        If Not GetData() Then
            Me.LabelNoData.Visible = True

        Else
            Me.LabelNoData.Visible = False
        End If
    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日From(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日From(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenFROM_DATE_DD) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日From(日)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.JokenFROM_DATE_YYYY) OrElse CmnCheck.IsInput(Me.JokenFROM_DATE_MM) OrElse CmnCheck.IsInput(Me.JokenFROM_DATE_DD) Then
            Dim wStr As String = StrConv(Trim(Me.JokenFROM_DATE_YYYY.Text) & "/" & Trim(Me.JokenFROM_DATE_MM.Text) & "/" & Trim(Me.JokenFROM_DATE_DD.Text), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("実施日From"), Me)
                Return False
            End If
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_YYYY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日To(年)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_MM) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日To(月)"), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.JokenTO_DATE_DD) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実施日To(日)"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.JokenTO_DATE_YYYY) OrElse CmnCheck.IsInput(Me.JokenTO_DATE_MM) OrElse CmnCheck.IsInput(Me.JokenTO_DATE_DD) Then
            Dim wStr As String = StrConv(Trim(Me.JokenTO_DATE_YYYY.Text) & "/" & Trim(Me.JokenTO_DATE_MM.Text) & "/" & Trim(Me.JokenTO_DATE_DD.Text), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("実施日To"), Me)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub BtnCsv_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCsv.Click
        '入力チェック
        If Not Check() Then Exit Sub

        If GetData() Then
            'CSV出力
            Response.Clear()
            Response.ContentType = CmnConst.Csv.ContentType
            Response.Charset = CmnConst.Csv.Charset
            Response.AppendHeader(CmnConst.Csv.AppendHeader1, CmnConst.Csv.AppendHeader2 & "TaxiMiketsu.csv")
            Response.ContentEncoding = System.Text.Encoding.GetEncoding("Shift-JIS")

            Response.Write(MyModule.Csv.TaxiMiketsu(TBL_TAXITICKET_HAKKO))
            Response.End()
        End If
    End Sub
End Class