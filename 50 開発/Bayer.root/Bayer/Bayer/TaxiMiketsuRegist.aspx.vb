Imports CommonLib
Imports AppLib
Partial Public Class TaxiMiketsuRegist
    Inherits WebBase

    Private TBL_TAXITICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
    Private SEQ As Integer

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
        Session.Item(SessionDef.TBL_TAXITICKET_HAKKO) = TBL_TAXITICKET_HAKKO
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '共通チェック
        MyModule.IsPageOK(False, Session.Item(SessionDef.LoginID), Me)

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
            .PageTitle = "未決登録"
            .HideLogout = False
            .HideMenu = False
        End With
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            TBL_TAXITICKET_HAKKO = Session.Item(SessionDef.TBL_TAXITICKET_HAKKO)
            If IsNothing(TBL_TAXITICKET_HAKKO) Then Return False
        Catch ex As Exception
            Return False
        End Try
        If Not MyModule.IsValidSEQ(Session.Item(SessionDef.SEQ)) Then
            Return False
        Else
            SEQ = Session.Item(SessionDef.SEQ)
        End If
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        AppModule.SetForm_KOUENKAI_NO(TBL_TAXITICKET_HAKKO(SEQ).KOUENKAI_NO, Me.KOUENKAI_NO)
        AppModule.SetForm_KOUENKAI_NAME(TBL_TAXITICKET_HAKKO(SEQ).KOUENKAI_NAME, Me.KOUENKAI_NAME)
        AppModule.SetForm_TAXI_PRT_NAME(TBL_TAXITICKET_HAKKO(SEQ).TAXI_PRT_NAME, Me.TAXI_PRT_NAME)
        AppModule.SetForm_JISSI_DATE(TBL_TAXITICKET_HAKKO(SEQ).FROM_DATE, TBL_TAXITICKET_HAKKO(SEQ).TO_DATE, Me.KOUENKAI_DATE)
        AppModule.SetForm_USER_NAME(TBL_TAXITICKET_HAKKO(SEQ).USER_NAME, Me.TTEHAI_TANTO)
        AppModule.SetForm_SANKASHA_ID(TBL_TAXITICKET_HAKKO(SEQ).SANKASHA_ID, Me.SANKASHA_ID)
        AppModule.SetForm_DR_NAME(TBL_TAXITICKET_HAKKO(SEQ).DR_NAME, Me.DR_NAME)
        AppModule.SetForm_DR_KANA(TBL_TAXITICKET_HAKKO(SEQ).DR_KANA, Me.DR_KANA)
        AppModule.SetForm_DR_SEX(TBL_TAXITICKET_HAKKO(SEQ).DR_SEX, Me.DR_SEX)
        AppModule.SetForm_DR_AGE(TBL_TAXITICKET_HAKKO(SEQ).DR_AGE, Me.DR_AGE)
        AppModule.SetForm_DR_SANKA(TBL_TAXITICKET_HAKKO(SEQ).DR_SANKA, Me.DR_SANKA)
        AppModule.SetForm_DR_YAKUWARI(TBL_TAXITICKET_HAKKO(SEQ).DR_YAKUWARI, Me.DR_YAKUWARI)
        AppModule.SetForm_DR_SHISETSU_CD(TBL_TAXITICKET_HAKKO(SEQ).DR_SHISETSU_CD, Me.DR_SHISETSU_CD)
        AppModule.SetForm_DR_SHISETSU_NAME(TBL_TAXITICKET_HAKKO(SEQ).DR_SHISETSU_NAME, Me.DR_SHISETSU_NAME)
        AppModule.SetForm_DR_SHISETSU_ADDRESS(TBL_TAXITICKET_HAKKO(SEQ).DR_SHISETSU_ADDRESS, Me.DR_SHISETSU_ADDRESS)
        AppModule.SetForm_SHITEIGAI_RIYU(TBL_TAXITICKET_HAKKO(SEQ).SHITEIGAI_RIYU, Me.SHITEIGAI_RIYU)
        AppModule.Setform_TKT_LINE_NO(TBL_TAXITICKET_HAKKO(SEQ).TKT_LINE_NO, Me.TKT_LINE_NO)
        AppModule.SetForm_TKT_NO(TBL_TAXITICKET_HAKKO(SEQ).TKT_NO, Me.TKT_NO)
        AppModule.SetForm_TKT_KAISHA(TBL_TAXITICKET_HAKKO(SEQ).TKT_KAISHA, Me.TKT_KAISHA)
        AppModule.SetForm_TKT_KENSHU(TBL_TAXITICKET_HAKKO(SEQ).TKT_KENSHU, Me.TKT_KENSHU)

        Select Case Val(TBL_TAXITICKET_HAKKO(SEQ).TKT_LINE_NO)
            Case 1
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_1, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_1, Me.ANS_TAXI_HAKKO_DATE)
            Case 2
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_2, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_2, Me.ANS_TAXI_HAKKO_DATE)
            Case 3
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_3, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_3, Me.ANS_TAXI_HAKKO_DATE)
            Case 4
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_4, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_4, Me.ANS_TAXI_HAKKO_DATE)
            Case 5
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_5, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_5, Me.ANS_TAXI_HAKKO_DATE)
            Case 6
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_6, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_6, Me.ANS_TAXI_HAKKO_DATE)
            Case 7
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_7, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_7, Me.ANS_TAXI_HAKKO_DATE)
            Case 8
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_8, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_8, Me.ANS_TAXI_HAKKO_DATE)
            Case 9
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_9, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_9, Me.ANS_TAXI_HAKKO_DATE)
            Case 10
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_10, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_10, Me.ANS_TAXI_HAKKO_DATE)
            Case 11
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_11, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_11, Me.ANS_TAXI_HAKKO_DATE)
            Case 12
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_12, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_12, Me.ANS_TAXI_HAKKO_DATE)
            Case 13
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_13, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_13, Me.ANS_TAXI_HAKKO_DATE)
            Case 14
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_14, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_14, Me.ANS_TAXI_HAKKO_DATE)
            Case 15
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_15, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_15, Me.ANS_TAXI_HAKKO_DATE)
            Case 16
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_16, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_16, Me.ANS_TAXI_HAKKO_DATE)
            Case 17
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_17, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_17, Me.ANS_TAXI_HAKKO_DATE)
            Case 18
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_18, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_18, Me.ANS_TAXI_HAKKO_DATE)
            Case 19
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_19, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_19, Me.ANS_TAXI_HAKKO_DATE)
            Case 20
                AppModule.SetForm_ANS_TAXI_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_DATE_20, Me.ANS_TAXI_DATE)
                AppModule.SetForm_ANS_TAXI_HAKKO_DATE(TBL_TAXITICKET_HAKKO(SEQ).ANS_TAXI_HAKKO_DATE_20, Me.ANS_TAXI_HAKKO_DATE)
        End Select
        AppModule.SetForm_TKT_USED_DATE(TBL_TAXITICKET_HAKKO(SEQ).TKT_USED_DATE, Me.TKT_USED_DATE)
        AppModule.SetForm_TKT_VOID(TBL_TAXITICKET_HAKKO(SEQ).TKT_VOID, TBL_TAXITICKET_HAKKO(SEQ).UPDATE_DATE, Me.TKT_VOID)
    End Sub

    'データ更新
    Private Function ExecuteTransaction() As Boolean
        Return UpdateData()
    End Function

    'データ更新
    Private Function UpdateData() As Boolean
        Dim strSQL As String

        MyBase.BeginTransaction()
        Try
            'データ更新
            TBL_TAXITICKET_HAKKO(SEQ).TKT_MIKETSU = CmnConst.Flag.On
            strSQL = SQL.TBL_TAXITICKET_HAKKO.Update(TBL_TAXITICKET_HAKKO(SEQ))
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)
            MyBase.Commit()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiMiketsu, TBL_TAXITICKET_HAKKO(SEQ), True, "", MyBase.DbConnection)

            Return True
        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.TaxiMiketsu, TBL_TAXITICKET_HAKKO(SEQ), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))

            Return False
        End Try
    End Function

    '[戻る]
    Private Sub BtnBack1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click
        Session.Remove(SessionDef.KouenkaiRireki_PageIndex)
        Session.Remove(SessionDef.KouenkaiRireki_SEQ)
        Response.Redirect(Session.Item(SessionDef.BackURL2))
    End Sub

    '[戻る]
    Private Sub BtnBack2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack2.Click
        BtnBack1_Click(sender, e)
    End Sub

    '[登録]
    Private Sub BtnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click

        'データ更新
        If ExecuteTransaction() Then
        End If
    End Sub
End Class
