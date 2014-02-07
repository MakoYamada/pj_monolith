Imports CommonLib
Imports AppLib
Partial Public Class TaxiMaintenanceRegist
    Inherits WebBase

    Private TBL_TAXITICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
    Private SEQ As Integer

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
        Session.Item(SessionDef.TBL_TAXITICKET_HAKKO) = TBL_TAXITICKET_HAKKO
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
            .PageTitle = "タクチケメンテナンス"
            .HideLogout = False
            .HideMenu = False
            .DispTaxiMenu = True
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
        AppModule.SetForm_TKT_USED_DATE(TBL_TAXITICKET_HAKKO(SEQ).TKT_USED_DATE, Me.TKT_USED_DATE)
        AppModule.SetForm_TKT_VOID(TBL_TAXITICKET_HAKKO(SEQ).TKT_VOID, TBL_TAXITICKET_HAKKO(SEQ).UPDATE_DATE, Me.VOID_DATE)
        AppModule.SetForm_TKT_VOID(TBL_TAXITICKET_HAKKO(SEQ).TKT_VOID, Me.TKT_VOID)

        '請求年月が設定されているデータはVOIDフラグ変更不可
        If Me.TKT_SEIKYU_YM.Text.Trim <> "" Then
            Me.TKT_VOID.Enabled = False
        Else
            Me.TKT_VOID.Enabled = True
        End If
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
            TBL_TAXITICKET_HAKKO(SEQ).SANKASHA_ID = Me.SANKASHA_ID.Text
            If Me.TKT_VOID.Checked Then
                TBL_TAXITICKET_HAKKO(SEQ).TKT_VOID = CmnConst.Flag.On
            Else
                TBL_TAXITICKET_HAKKO(SEQ).TKT_VOID = CmnConst.Flag.Off
            End If
            strSQL = Sql.TBL_TAXITICKET_HAKKO.Update(TBL_TAXITICKET_HAKKO(SEQ))
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
    Private Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click, BtnBack2.Click
        Session.Remove(SessionDef.KouenkaiRireki_PageIndex)
        Session.Remove(SessionDef.KouenkaiRireki_SEQ)
        Response.Redirect(Session.Item(SessionDef.BackURL2))
    End Sub

    '[登録]
    Private Sub BtnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click
        '入力チェック
        If Not Check() Then Exit Sub

        'データ更新
        If ExecuteTransaction() Then
        End If
    End Sub

    '[参加者再表示]
    Private Sub BtnSankasha_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSankasha.Click
        '入力チェック
        If Not Check() Then Exit Sub

        '交通宿泊情報取得
        Dim TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct = Nothing
        If Not GetData(TBL_KOTSUHOTEL) Then
            Me.DR_NAME.Text = ""
            Me.DR_KANA.Text = ""
            Me.DR_SEX.Text = ""
            Me.DR_AGE.Text = ""
            Me.DR_SANKA.Text = ""
            Me.DR_YAKUWARI.Text = ""
            Me.DR_SHISETSU_CD.Text = ""
            Me.DR_SHISETSU_NAME.Text = ""
            Me.DR_SHISETSU_ADDRESS.Text = ""
            Me.SHITEIGAI_RIYU.Text = ""

            CmnModule.AlertMessage(MessageDef.Error.IsNotRegistered("入力された参加者ID"), Me)
            Exit Sub
        Else
            AppModule.SetForm_DR_NAME(TBL_KOTSUHOTEL.DR_NAME, Me.DR_NAME)
            AppModule.SetForm_DR_KANA(TBL_KOTSUHOTEL.DR_KANA, Me.DR_KANA)
            AppModule.SetForm_DR_SEX(TBL_KOTSUHOTEL.DR_SEX, Me.DR_SEX)
            AppModule.SetForm_DR_AGE(TBL_KOTSUHOTEL.DR_AGE, Me.DR_AGE)
            AppModule.SetForm_DR_SANKA(TBL_KOTSUHOTEL.DR_SANKA, Me.DR_SANKA)
            AppModule.SetForm_DR_YAKUWARI(TBL_KOTSUHOTEL.DR_YAKUWARI, Me.DR_YAKUWARI)
            AppModule.SetForm_DR_SHISETSU_CD(TBL_KOTSUHOTEL.DR_SHISETSU_CD, Me.DR_SHISETSU_CD)
            AppModule.SetForm_DR_SHISETSU_NAME(TBL_KOTSUHOTEL.DR_SHISETSU_NAME, Me.DR_SHISETSU_NAME)
            AppModule.SetForm_DR_SHISETSU_ADDRESS(TBL_KOTSUHOTEL.DR_SHISETSU_ADDRESS, Me.DR_SHISETSU_ADDRESS)
            AppModule.SetForm_SHITEIGAI_RIYU(TBL_KOTSUHOTEL.SHITEIGAI_RIYU, Me.SHITEIGAI_RIYU)
        End If

    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.SANKASHA_ID) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("参加者ID"), Me)
            Return False
        End If

        If Not CmnCheck.IsAlphanumericHyphen(Me.SANKASHA_ID) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphanumericHyphenOnly("参加者ID"), Me)
            Return False
        End If

        Return True
    End Function

    'データ取得
    Private Function GetData(ByRef TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_KOTSUHOTEL.byKOUENKAI_NO_SANKASHA_ID(Me.KOUENKAI_NO.Text, Me.SANKASHA_ID.Text)
        strSQL &= " DESC"
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wFlag = True
            TBL_KOTSUHOTEL = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL)
        End If
        RsData.Close()

        Return wFlag
    End Function
End Class
