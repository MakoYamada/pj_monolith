Imports CommonLib
Imports AppLib
Partial Public Class TaxiMaintenanceRegist
    Inherits WebBase

    Private TBL_TAXITICKET_HAKKO() As TableDef.TBL_TAXITICKET_HAKKO.DataStruct
    Private SEQ As Integer

    Private DATA_MAINTENANCE As String
    Private InputError As Boolean

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
        Session.Item(SessionDef.TBL_TAXITICKET_HAKKO) = TBL_TAXITICKET_HAKKO
        Session.Item(SessionDef.DATA_MAINTENANCE) = DATA_MAINTENANCE
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
            If DATA_MAINTENANCE = CmnConst.Flag.Off Then
                .DispTaxiMenu = True
            Else
                .DispTaxiMenu = False
            End If
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

        If Not Session.Item(SessionDef.DATA_MAINTENANCE) Is Nothing Then
            DATA_MAINTENANCE = Session.Item(SessionDef.DATA_MAINTENANCE)
        Else
            DATA_MAINTENANCE = ""
        End If

        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        'IME設定        CmnModule.SetIme(Me.KOUENKAI_NO_FURIKAE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SANKASHA_ID, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TKT_LINE_NO_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TKT_USED_DATE_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TKT_URIAGE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TKT_SEIKYU_YM_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TKT_ENTA, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TKT_SEISAN_FEE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.TKT_HAKKO_FEE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.SEIKYU_NO_TOPTOUR, CmnModule.ImeType.Disabled)

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
        AppModule.SetForm_TKT_LINE_NO(TBL_TAXITICKET_HAKKO(SEQ).TKT_LINE_NO, Me.TKT_LINE_NO_2)
        AppModule.SetForm_TKT_NO(TBL_TAXITICKET_HAKKO(SEQ).TKT_NO, Me.TKT_NO)
        AppModule.SetForm_TKT_NO(TBL_TAXITICKET_HAKKO(SEQ).TKT_NO, Me.TKT_NO_2)
        AppModule.SetForm_TKT_KAISHA(TBL_TAXITICKET_HAKKO(SEQ).TKT_KAISHA, Me.TKT_KAISHA)
        AppModule.SetForm_TKT_KAISHA(TBL_TAXITICKET_HAKKO(SEQ).TKT_KAISHA, Me.TKT_KAISHA_2)
        AppModule.SetForm_TKT_KENSHU(TBL_TAXITICKET_HAKKO(SEQ).TKT_KENSHU, Me.TKT_KENSHU)
        AppModule.SetForm_TKT_KENSHU(TBL_TAXITICKET_HAKKO(SEQ).TKT_KENSHU, Me.TKT_KENSHU_2)
        AppModule.SetForm_TKT_USED_DATE(TBL_TAXITICKET_HAKKO(SEQ).TKT_USED_DATE, Me.TKT_USED_DATE)
        AppModule.SetForm_TKT_USED_DATE(TBL_TAXITICKET_HAKKO(SEQ).TKT_USED_DATE, Me.TKT_USED_DATE_2)
        AppModule.SetForm_TKT_SEIKYU_YM(TBL_TAXITICKET_HAKKO(SEQ).TKT_SEIKYU_YM, Me.TKT_SEIKYU_YM)
        AppModule.SetForm_TKT_SEIKYU_YM(TBL_TAXITICKET_HAKKO(SEQ).TKT_SEIKYU_YM, Me.TKT_SEIKYU_YM_2)
        AppModule.SetForm_TKT_VOID(TBL_TAXITICKET_HAKKO(SEQ).TKT_VOID, TBL_TAXITICKET_HAKKO(SEQ).UPDATE_DATE, Me.VOID_DATE)
        AppModule.SetForm_TKT_VOID(TBL_TAXITICKET_HAKKO(SEQ).TKT_VOID, TBL_TAXITICKET_HAKKO(SEQ).UPDATE_DATE, Me.VOID_DATE_2)
        AppModule.SetForm_TKT_VOID(TBL_TAXITICKET_HAKKO(SEQ).TKT_VOID, Me.TKT_VOID)
        AppModule.SetForm_TKT_VOID(TBL_TAXITICKET_HAKKO(SEQ).TKT_VOID, Me.TKT_VOID_2)
        AppModule.SetForm_TKT_URIAGE(TBL_TAXITICKET_HAKKO(SEQ).TKT_URIAGE, Me.TKT_URIAGE)
        AppModule.SetForm_TKT_SEISAN_FEE(TBL_TAXITICKET_HAKKO(SEQ).TKT_SEISAN_FEE, Me.TKT_SEISAN_FEE)
        AppModule.SetForm_TKT_HAKKO_FEE(TBL_TAXITICKET_HAKKO(SEQ).TKT_HAKKO_FEE, Me.TKT_HAKKO_FEE)
        AppModule.SetForm_TKT_ENTA(TBL_TAXITICKET_HAKKO(SEQ).TKT_ENTA, Me.TKT_ENTA)
        AppModule.SetForm_SEIKYU_NO_TOPTOUR(TBL_TAXITICKET_HAKKO(SEQ).SEIKYU_NO_TOPTOUR, Me.SEIKYU_NO_TOPTOUR)

        '請求年月が設定されているデータはVOIDフラグ変更不可
        If Me.TKT_SEIKYU_YM.Text.Trim <> "" Then
            Me.TKT_VOID.Enabled = False
        Else
            Me.TKT_VOID.Enabled = True
        End If

        'データメンテナンスモードの場合
        If DATA_MAINTENANCE = CmnConst.Flag.On Then
            Me.TbFurikae.Visible = True
            Me.TbTaxiMaintenance.Visible = True
            Me.TbTaxi.Visible = False
            AppModule.SetForm_KOUENKAI_NO(TBL_TAXITICKET_HAKKO(SEQ).KOUENKAI_NO, Me.KOUENKAI_NO_FURIKAE)
            AppModule.SetForm_KOUENKAI_NAME(TBL_TAXITICKET_HAKKO(SEQ).KOUENKAI_NAME, Me.KOUENKAI_NAME_FURIKAE)
            AppModule.SetForm_TAXI_PRT_NAME(TBL_TAXITICKET_HAKKO(SEQ).TAXI_PRT_NAME, Me.TAXI_PRT_NAME_FURIKAE)
            AppModule.SetForm_JISSI_DATE(TBL_TAXITICKET_HAKKO(SEQ).FROM_DATE, TBL_TAXITICKET_HAKKO(SEQ).TO_DATE, Me.KOUENKAI_DATE_FURIKAE)
            AppModule.SetForm_USER_NAME(TBL_TAXITICKET_HAKKO(SEQ).USER_NAME, Me.TTEHAI_TANTO_FURIKAE)
        Else
            Me.TbFurikae.Visible = False
            Me.TbTaxiMaintenance.Visible = False
            Me.TbTaxi.Visible = True
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

            'データメンテナンスモードの場合
            If TbTaxiMaintenance.Visible Then
                TBL_TAXITICKET_HAKKO(SEQ).KOUENKAI_NO = Me.KOUENKAI_NO_FURIKAE.Text
                TBL_TAXITICKET_HAKKO(SEQ).TKT_LINE_NO = Me.TKT_LINE_NO_2.Text
                TBL_TAXITICKET_HAKKO(SEQ).TKT_USED_DATE = Me.TKT_USED_DATE_2.Text
                TBL_TAXITICKET_HAKKO(SEQ).TKT_URIAGE = Me.TKT_URIAGE.Text
                TBL_TAXITICKET_HAKKO(SEQ).TKT_SEISAN_FEE = Me.TKT_SEISAN_FEE.Text
                TBL_TAXITICKET_HAKKO(SEQ).TKT_HAKKO_FEE = Me.TKT_HAKKO_FEE.Text
                TBL_TAXITICKET_HAKKO(SEQ).TKT_ENTA = Me.TKT_ENTA.Text
                If Me.TKT_VOID_2.Checked Then
                    TBL_TAXITICKET_HAKKO(SEQ).TKT_VOID = CmnConst.Flag.On
                Else
                    TBL_TAXITICKET_HAKKO(SEQ).TKT_VOID = CmnConst.Flag.Off
                End If
                TBL_TAXITICKET_HAKKO(SEQ).TKT_SEIKYU_YM = Me.TKT_SEIKYU_YM_2.Text
                TBL_TAXITICKET_HAKKO(SEQ).SEIKYU_NO_TOPTOUR = Me.SEIKYU_NO_TOPTOUR.Text
            End If
            TBL_TAXITICKET_HAKKO(SEQ).UPDATE_DATE = SQL.GetValue.DATE
            TBL_TAXITICKET_HAKKO(SEQ).UPDATE_USER = SQL.GetValue.USER
            strSQL = SQL.TBL_TAXITICKET_HAKKO.Update_OTH(TBL_TAXITICKET_HAKKO(SEQ))
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

        '会合存在チェック
        If TbTaxiMaintenance.Visible Then
            If Not CheckKaigouInput() Then Exit Sub
        End If

        '参加者存在チェック
        If Not Check() Then Exit Sub

        'データメンテナンスモードの場合
        If TbTaxiMaintenance.Visible Then
            If Not CheckTaxiInput() Then Exit Sub
        End If

        'データ更新
        If ExecuteTransaction() Then
        End If
    End Sub

    '[講演会情報再表示]
    Private Sub BtnKaigou_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnKaigou.Click
        Call CheckKaigouInput()
    End Sub

    '[参加者再表示]
    Private Sub BtnSankasha_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSankasha.Click

        If Not Check() Then
            Exit Sub
        End If

    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        'データメンテナンスモードの場合
        If TbFurikae.Visible Then
            If Not CmnCheck.IsInput(Me.KOUENKAI_NO_FURIKAE) Then
                CmnModule.AlertMessage(MessageDef.Error.MustInput("振替先会合番号"), Me)
                SetFocus(Me.KOUENKAI_NO_FURIKAE)
                Return False
            End If

            If Not CmnCheck.IsAlphanumericHyphen(Me.KOUENKAI_NO_FURIKAE) Then
                CmnModule.AlertMessage(MessageDef.Error.AlphanumericHyphenOnly("振替先会合番号"), Me)
                SetFocus(Me.KOUENKAI_NO_FURIKAE)
                Return False
            End If
        End If

        If Not CmnCheck.IsInput(Me.SANKASHA_ID) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("参加者ID"), Me)
            SetFocus(Me.SANKASHA_ID)
            Return False
        End If

        If Not CmnCheck.IsAlphanumericHyphen(Me.SANKASHA_ID) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphanumericHyphenOnly("参加者ID"), Me)
            SetFocus(Me.SANKASHA_ID)
            Return False
        End If

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
            Return False
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

        Return True
    End Function
    Private Function CheckKaigouInput() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.KOUENKAI_NO_FURIKAE) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("振替先会合番号"), Me)
            Return False
        End If

        If Not CmnCheck.IsAlphanumericHyphen(Me.KOUENKAI_NO_FURIKAE) Then
            CmnModule.AlertMessage(MessageDef.Error.AlphanumericHyphenOnly("振替先会合番号"), Me)
            Return False
        End If

        '会合情報取得
        Dim W_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct = Nothing
        If Not GetKaigouData(W_KOUENKAI) Then
            Me.KOUENKAI_NAME_FURIKAE.Text = ""
            Me.TAXI_PRT_NAME_FURIKAE.Text = ""
            Me.KOUENKAI_DATE_FURIKAE.Text = ""
            Me.TTEHAI_TANTO_FURIKAE.Text = ""
            CmnModule.AlertMessage(MessageDef.Error.IsNotRegistered("入力された振替先会合番号"), Me)
            Return False
        Else
            AppModule.SetForm_KOUENKAI_NAME(W_KOUENKAI.KOUENKAI_NAME, Me.KOUENKAI_NAME_FURIKAE)
            AppModule.SetForm_TAXI_PRT_NAME(W_KOUENKAI.TAXI_PRT_NAME, Me.TAXI_PRT_NAME_FURIKAE)
            AppModule.SetForm_JISSI_DATE(W_KOUENKAI.FROM_DATE, W_KOUENKAI.TO_DATE, Me.KOUENKAI_DATE_FURIKAE)
            AppModule.SetForm_USER_NAME(W_KOUENKAI.TTEHAI_TANTO, Me.TTEHAI_TANTO_FURIKAE)
        End If

        Return True
    End Function
    Private Function CheckTaxiInput() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        '行番号
        If Not CmnCheck.IsInput(Me.TKT_LINE_NO_2) Then
            CmnModule.AlertMessage(MessageDef.Error.MustInput("回答行番号"), Me)
            SetFocus(Me.TKT_LINE_NO_2)
            Return False
        End If
        If Not IsNumeric(Me.TKT_LINE_NO_2.Text) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("回答行番号"), Me)
            SetFocus(Me.TKT_LINE_NO_2)
            Return False
        End If
        If Integer.Parse(Me.TKT_LINE_NO_2.Text) < 1 OrElse Integer.Parse(Me.TKT_LINE_NO_2.Text) > 20 Then
            CmnModule.AlertMessage(MessageDef.Error.Range("回答行番号", 1, 20), Me)
            SetFocus(Me.TKT_LINE_NO_2)
            Return False
        End If

        '実車日
        If Not CmnCheck.IsNumberOnly(Me.TKT_USED_DATE_2) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実車日"), Me)
            SetFocus(Me.TKT_USED_DATE_2)
            Return False
        End If

        If CmnCheck.IsInput(Me.TKT_USED_DATE_2) Then
            If Me.TKT_USED_DATE_2.Text.Trim.Length < 8 Then
                CmnModule.AlertMessage(MessageDef.Error.LengthEQ("実車日", 8, False), Me)
                SetFocus(Me.TKT_USED_DATE_2)
                Return False
            End If

            Dim wStr As String = StrConv(Me.TKT_USED_DATE_2.Text.Substring(0, 4) & "/" & Me.TKT_USED_DATE_2.Text.Substring(4, 2) & "/" & Me.TKT_USED_DATE_2.Text.Substring(6, 2), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("実車日"), Me)
                SetFocus(Me.TKT_USED_DATE_2)
                Return False
            End If
        End If

        '請求年月
        If Not CmnCheck.IsNumberOnly(Me.TKT_SEIKYU_YM_2) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("請求年月"), Me)
            SetFocus(Me.TKT_SEIKYU_YM_2)
            Return False
        End If

        If CmnCheck.IsInput(Me.TKT_SEIKYU_YM_2) Then
            If Me.TKT_SEIKYU_YM_2.Text.Trim.Length < 6 Then
                CmnModule.AlertMessage(MessageDef.Error.LengthEQ("請求年月", 6, False), Me)
                SetFocus(Me.TKT_SEIKYU_YM_2)
                Return False
            End If

            Dim wStr As String = StrConv(Me.TKT_SEIKYU_YM_2.Text.Substring(0, 4) & "/" & Me.TKT_SEIKYU_YM_2.Text.Substring(4, 2) & "/01", VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("請求年月"), Me)
                SetFocus(Me.TKT_SEIKYU_YM_2)
                Return False
            End If
        End If

        '実車代金
        If Not CmnCheck.IsValidKingaku(Me.TKT_URIAGE) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("実車代金"), Me)
            SetFocus(Me.TKT_URIAGE)
            Return False
        End If

        '精算手数料
        If Not CmnCheck.IsValidKingaku(Me.TKT_SEISAN_FEE) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("精算手数料"), Me)
            SetFocus(Me.TKT_SEISAN_FEE)
            Return False
        End If

        '発行手数料
        If Not CmnCheck.IsValidKingaku(Me.TKT_HAKKO_FEE) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("発行手数料"), Me)
            SetFocus(Me.TKT_HAKKO_FEE)
            Return False
        End If

        'エンタ
        If Me.TKT_ENTA.Text.Trim <> "" AndAlso Me.TKT_ENTA.Text.Trim <> "N" AndAlso Me.TKT_ENTA.Text.Trim <> "E" Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("ENTAの入力内容"), Me)
            SetFocus(Me.TKT_ENTA)
            Return False
        End If

        '精算番号
        If Me.SEIKYU_NO_TOPTOUR.Text.Trim <> "" Then
            If Not CmnCheck.IsLengthEQ(Me.SEIKYU_NO_TOPTOUR, Me.SEIKYU_NO_TOPTOUR.MaxLength) Then
                CmnModule.AlertMessage(MessageDef.Error.LengthEQ(TableDef.TBL_KOTSUHOTEL.Name.SEIKYU_NO_TOPTOUR, Me.SEIKYU_NO_TOPTOUR.MaxLength), Me)
                SetFocus(Me.SEIKYU_NO_TOPTOUR)
                Return False
            End If

            Dim strSQL As String = "SELECT * FROM TBL_SEIKYU" _
                & " WHERE " _
                & TableDef.TBL_SEIKYU.Column.SEIKYU_NO_TOPTOUR & "='" & Me.SEIKYU_NO_TOPTOUR.Text & "'"
            Dim W_SEIKYU As TableDef.TBL_SEIKYU.DataStruct = AppModule.GetOneRecord(AppModule.TableType.TBL_SEIKYU, strSQL, DbConnection)
            If W_SEIKYU.SEIKYU_NO_TOPTOUR Is Nothing Then
                CmnModule.AlertMessage(MessageDef.Error.IsNotRegistered("入力された精算番号は"), Me)
                SetFocus(Me.SEIKYU_NO_TOPTOUR)
                Return False
            End If
        End If

        Return True
    End Function

    'データ取得
    Private Function GetData(ByRef TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_KOTSUHOTEL.byKOUENKAI_NO_SANKASHA_ID(Me.KOUENKAI_NO_FURIKAE.Text, Me.SANKASHA_ID.Text)
        strSQL &= " DESC"
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wFlag = True
            TBL_KOTSUHOTEL = AppModule.SetRsData(RsData, TBL_KOTSUHOTEL)
        End If
        RsData.Close()

        Return wFlag
    End Function
    Private Function GetKaigouData(ByRef P_KOUENKAI As TableDef.TBL_KOUENKAI.DataStruct) As Boolean
        Dim wFlag As Boolean = False
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_KOUENKAI.byKOUENKAI_NO(Me.KOUENKAI_NO_FURIKAE.Text)
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wFlag = True
            P_KOUENKAI = AppModule.SetRsData(RsData, P_KOUENKAI)
        End If
        RsData.Close()

        Return wFlag
    End Function
End Class
