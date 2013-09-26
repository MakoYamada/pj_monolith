Imports CommonLib
Imports AppLib
Partial Public Class KaijoRegist
    Inherits WebBase

    Private TBL_KAIJO() As TableDef.TBL_KAIJO.DataStruct
    Private SEQ As Integer

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
        Session.Item(SessionDef.TBL_KAIJO) = TBL_KAIJO
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

            '画面項目表示
            SetForm()
        End If

        'マスターページ設定
        With Me.Master
            .HideLoginUser = True   'QQQ
            .PageTitle = "講演会場　手配・見積依頼"
        End With

        ''QQQ ハーコピー用
        'Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME) = "日産スタジアム"
        'Session.Item(SessionDef.ShisetsuKensaku_ADDRESS) = "神奈川県横浜市港北区小机町3300"
        'Session.Item(SessionDef.ShisetsuKensaku_TEL) = "045-477-5000"
        'Session.Item(SessionDef.ShisetsuKensaku_URL) = "http://www.nissan-stadium.jp/"

        '検索画面戻り
        Me.ANS_SHISETSU_NAME.Text = Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME)
        Me.ANS_SHISETSU_ADDRESS.Text = Session.Item(SessionDef.ShisetsuKensaku_ADDRESS)
        Me.ANS_SHISETSU_TEL.Text = Session.Item(SessionDef.ShisetsuKensaku_TEL)
        Me.ANS_SHISETSU_URL.Text = Session.Item(SessionDef.ShisetsuKensaku_URL)
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            TBL_KAIJO = Session.Item(SessionDef.TBL_KAIJO)
            If IsNothing(TBL_KAIJO) Then Return False
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
        'プルダウン設定
        AppModule.SetDropDownList_ANS_STATUS_TEHAI(Me.ANS_STATUS_TEHAI)
        AppModule.SetDropDownList_ADDRESS1(Me.ADDRESS1)

        'IME設定
        CmnModule.SetIme(Me.ADDRESS2, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_SHISETSU_NAME, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_MITSUMORI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_MITSUMORI_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_MITSUMORI_URL, CmnModule.ImeType.Disabled)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        '依頼(表示)
        Me.KOUENKAI_NO.Text = AppModule.GetName_KOUENKAI_NO(TBL_KAIJO(SEQ).KOUENKAI_NO)
        Me.REQ_STATUS_TEHAI.Text = AppModule.GetName_REQ_STATUS_TEHAI(TBL_KAIJO(SEQ).REQ_STATUS_TEHAI, True)
        Me.TIME_STAMP_BYL.Text = AppModule.GetName_TIME_STAMP_BYL(TBL_KAIJO(SEQ).TIME_STAMP_BYL)
        Me.SHONIN_NAME.Text = AppModule.GetName_SHONIN_NAME(TBL_KAIJO(SEQ).SHONIN_NAME)
        Me.SHONIN_DATE.Text = AppModule.GetName_SHONIN_DATE(TBL_KAIJO(SEQ).SHONIN_DATE)
        Me.KOUENKAI_KUBUN.Text = AppModule.GetName_KOUENKAI_KUBUN(TBL_KAIJO(SEQ).KOUENKAI_KUBUN)
        Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NAME(TBL_KAIJO(SEQ).KOUENKAI_NAME)
        Me.FROM_DATE.Text = AppModule.GetName_FROM_DATE(TBL_KAIJO(SEQ).FROM_DATE)
        Me.TO_DATE.Text = AppModule.GetName_TO_DATE(TBL_KAIJO(SEQ).TO_DATE)
        Me.TAXI_PRT_NAME.Text = AppModule.GetName_TAXI_PRT_NAME(TBL_KAIJO(SEQ).TAXI_PRT_NAME)
        Me.SEIHIN_NAME.Text = AppModule.GetName_SEIHIN_NAME(TBL_KAIJO(SEQ).SEIHIN_NAME)
        Me.KAISAI_DATE_NOTE.Text = AppModule.GetName_KAISAI_DATE_NOTE(TBL_KAIJO(SEQ).KAISAI_DATE_NOTE)
        Me.INTERNAL_ORDER_T.Text = AppModule.GetName_INTERNAL_ORDER_T(TBL_KAIJO(SEQ).INTERNAL_ORDER_T)
        Me.INTERNAL_ORDER_TF.Text = AppModule.GetName_INTERNAL_ORDER_TF(TBL_KAIJO(SEQ).INTERNAL_ORDER_TF)
        Me.ACCOUNT_CD_T.Text = AppModule.GetName_ACCOUNT_CD_T(TBL_KAIJO(SEQ).ACCOUNT_CD_T)
        Me.ACCOUNT_CD_TF.Text = AppModule.GetName_ACCOUNT_CD_TF(TBL_KAIJO(SEQ).ACCOUNT_CD_TF)
        Me.ZETIA_CD.Text = AppModule.GetName_ZETIA_CD(TBL_KAIJO(SEQ).ZETIA_CD)
        Me.BU.Text = AppModule.GetName_BU(TBL_KAIJO(SEQ).BU)
        Me.KIKAKU_TANTO_AREA.Text = AppModule.GetName_KIKAKU_TANTO_AREA(TBL_KAIJO(SEQ).KIKAKU_TANTO_AREA)
        Me.KIKAKU_TANTO_EIGYOSHO.Text = AppModule.GetName_KIKAKU_TANTO_EIGYOSHO(TBL_KAIJO(SEQ).KIKAKU_TANTO_EIGYOSHO)
        Me.KIKAKU_TANTO_NAME.Text = AppModule.GetName_KIKAKU_TANTO_NAME(TBL_KAIJO(SEQ).KIKAKU_TANTO_NAME)
        Me.KIKAKU_TANTO_ROMA.Text = AppModule.GetName_KIKAKU_TANTO_ROMA(TBL_KAIJO(SEQ).KIKAKU_TANTO_ROMA)
        Me.KIKAKU_TANTO_KEITAI.Text = AppModule.GetName_KIKAKU_TANTO_KEITAI(TBL_KAIJO(SEQ).KIKAKU_TANTO_KEITAI)
        Me.KIKAKU_TANTO_TEL.Text = AppModule.GetName_KIKAKU_TANTO_TEL(TBL_KAIJO(SEQ).KIKAKU_TANTO_TEL)
        Me.KIKAKU_TANTO_EMAIL_PC.Text = AppModule.GetName_KIKAKU_TANTO_EMAIL_PC(TBL_KAIJO(SEQ).KIKAKU_TANTO_EMAIL_PC)
        Me.KIKAKU_TANTO_EMAIL_KEITAI.Text = AppModule.GetName_KIKAKU_TANTO_EMAIL_KEITAI(TBL_KAIJO(SEQ).KIKAKU_TANTO_EMAIL_KEITAI)
        Me.TEHAI_TANTO_BU.Text = AppModule.GetName_TEHAI_TANTO_BU(TBL_KAIJO(SEQ).TEHAI_TANTO_BU)
        Me.TEHAI_TANTO_AREA.Text = AppModule.GetName_TEHAI_TANTO_AREA(TBL_KAIJO(SEQ).TEHAI_TANTO_AREA)
        Me.TEHAI_TANTO_EIGYOSHO.Text = AppModule.GetName_TEHAI_TANTO_EIGYOSHO(TBL_KAIJO(SEQ).TEHAI_TANTO_EIGYOSHO)
        Me.TEHAI_TANTO_NAME.Text = AppModule.GetName_TEHAI_TANTO_NAME(TBL_KAIJO(SEQ).TEHAI_TANTO_NAME)
        Me.TEHAI_TANTO_ROMA.Text = AppModule.GetName_TEHAI_TANTO_ROMA(TBL_KAIJO(SEQ).TEHAI_TANTO_ROMA)
        Me.TEHAI_TANTO_KEITAI.Text = AppModule.GetName_TEHAI_TANTO_KEITAI(TBL_KAIJO(SEQ).TEHAI_TANTO_KEITAI)
        Me.TEHAI_TANTO_TEL.Text = AppModule.GetName_TEHAI_TANTO_TEL(TBL_KAIJO(SEQ).TEHAI_TANTO_TEL)
        Me.TEHAI_TANTO_EMAIL_PC.Text = AppModule.GetName_TEHAI_TANTO_EMAIL_PC(TBL_KAIJO(SEQ).TEHAI_TANTO_EMAIL_PC)
        Me.TEHAI_TANTO_EMAIL_KEITAI.Text = AppModule.GetName_TEHAI_TANTO_EMAIL_KEITAI(TBL_KAIJO(SEQ).TEHAI_TANTO_EMAIL_KEITAI)
        Me.SANKA_YOTEI_CNT.Text = AppModule.GetName_SANKA_YOTEI_CNT(TBL_KAIJO(SEQ).SANKA_YOTEI_CNT)
        Me.YOSAN_T.Text = AppModule.GetName_YOSAN_T(TBL_KAIJO(SEQ).YOSAN_T)
        Me.YOSAN_TF.Text = AppModule.GetName_YOSAN_TF(TBL_KAIJO(SEQ).YOSAN_TF)
        Me.YOSAN_TOTAL.Text = AppModule.GetName_YOSAN_TOTAL(TBL_KAIJO(SEQ).YOSAN_T, TBL_KAIJO(SEQ).YOSAN_TF)
        Me.KAISAI_KIBOU_ADDRESS1.Text = AppModule.GetName_KAISAI_KIBOU_ADDRESS1(TBL_KAIJO(SEQ).KAISAI_KIBOU_ADDRESS1)
        Me.KAISAI_KIBOU_ADDRESS2.Text = AppModule.GetName_KAISAI_KIBOU_ADDRESS2(TBL_KAIJO(SEQ).KAISAI_KIBOU_ADDRESS2)
        Me.KAISAI_KIBOU_NOTE.Text = AppModule.GetName_KAISAI_KIBOU_NOTE(TBL_KAIJO(SEQ).KAISAI_KIBOU_NOTE)
        Me.KOUEN_TIME1.Text = AppModule.GetName_KOUEN_TIME1(TBL_KAIJO(SEQ).KOUEN_TIME1)
        Me.KOUEN_TIME2.Text = AppModule.GetName_KOUEN_TIME2(TBL_KAIJO(SEQ).KOUEN_TIME2)
        Me.KOUEN_KAIJO_LAYOUT.Text = AppModule.GetName_KOUEN_KAIJO_LAYOUT(TBL_KAIJO(SEQ).KOUEN_KAIJO_LAYOUT)
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Text = AppModule.GetName_IKENKOUKAN_KAIJO_TEHAI_Yes(TBL_KAIJO(SEQ).IKENKOUKAN_KAIJO_TEHAI)
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Text = AppModule.GetName_IKENKOUKAN_KAIJO_TEHAI_No(TBL_KAIJO(SEQ).IKENKOUKAN_KAIJO_TEHAI)
        Me.IROUKAI_KAIJO_TEHAI_Yes.Text = AppModule.GetName_IROUKAI_KAIJO_TEHAI_Yes(TBL_KAIJO(SEQ).IROUKAI_KAIJO_TEHAI)
        Me.IROUKAI_KAIJO_TEHAI_No.Text = AppModule.GetName_IROUKAI_KAIJO_TEHAI_No(TBL_KAIJO(SEQ).IROUKAI_KAIJO_TEHAI)
        Me.IROUKAI_SANKA_YOTEI_CNT.Text = AppModule.GetName_IROUKAI_SANKA_YOTEI_CNT(TBL_KAIJO(SEQ).IROUKAI_SANKA_YOTEI_CNT)
        Me.KOUSHI_ROOM_TEHAI_Yes.Text = AppModule.GetName_KOUSHI_ROOM_TEHAI_Yes(TBL_KAIJO(SEQ).KOUSHI_ROOM_TEHAI)
        Me.KOUSHI_ROOM_TEHAI_No.Text = AppModule.GetName_KOUSHI_ROOM_TEHAI_No(TBL_KAIJO(SEQ).KOUSHI_ROOM_TEHAI)
        Me.MANAGER_KAIJO_TEHAI_Yes.Text = AppModule.GetName_MANAGER_KAIJO_TEHAI_Yes(TBL_KAIJO(SEQ).MANAGER_KAIJO_TEHAI)
        Me.MANAGER_KAIJO_TEHAI_No.Text = AppModule.GetName_MANAGER_KAIJO_TEHAI_No(TBL_KAIJO(SEQ).MANAGER_KAIJO_TEHAI)

        '回答
        AppModule.SetForm_ANS_STATUS_TEHAI(TBL_KAIJO(SEQ).ANS_STATUS_TEHAI, Me.ANS_STATUS_TEHAI)
        AppModule.SetForm_ADDRESS1(Session.Item(SessionDef.ShisetsuKensaku_ADDRESS1), Me.ADDRESS1)
        AppModule.SetForm_ADDRESS2(Session.Item(SessionDef.ShisetsuKensaku_ADDRESS2), Me.ADDRESS2)
        AppModule.SetForm_ANS_SHISETSU_NAME(Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME), Me.ANS_SHISETSU_NAME)
        AppModule.SetForm_ANS_SHISETSU_ADDRESS(Session.Item(SessionDef.ShisetsuKensaku_ADDRESS), Me.ANS_SHISETSU_ADDRESS)
        AppModule.SetForm_ANS_SHISETSU_TEL(Session.Item(SessionDef.ShisetsuKensaku_TEL), Me.ANS_SHISETSU_TEL)
        AppModule.SetForm_ANS_SHISETSU_URL(Session.Item(SessionDef.ShisetsuKensaku_URL), Me.ANS_SHISETSU_URL)
        AppModule.SetForm_ANS_MITSUMORI_TF(TBL_KAIJO(SEQ).ANS_MITSUMORI_TF, Me.ANS_MITSUMORI_TF)
        AppModule.SetForm_ANS_MITSUMORI_T(TBL_KAIJO(SEQ).ANS_MITSUMORI_T, Me.ANS_MITSUMORI_T)
        AppModule.SetForm_ANS_MITSUMORI_URL(TBL_KAIJO(SEQ).ANS_MITSUMORI_URL, Me.ANS_MITSUMORI_URL)
        AppModule.SetForm_ANS_MITSUMORI_TOTAL(TBL_KAIJO(SEQ).ANS_MITSUMORI_TOTAL, Me.ANS_MITSUMORI_TOTAL)
    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.ANS_STATUS_TEHAI) Then
            CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_KAIJO.Name.ANS_STATUS_TEHAI), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_MITSUMORI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_MITSUMORI_T), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_MITSUMORI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_MITSUMORI_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsValidTel(Me.ANS_SHISETSU_TEL) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid(TableDef.TBL_KAIJO.Name.ANS_SHISETSU_TEL), Me)
            Return False
        End If

        Return True
    End Function

    '[検索]
    Protected Sub BtnShisetsuKensaku_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnShisetsuKensaku.Click
        Session.Item(SessionDef.ShisetsuKensaku_ADDRESS1) = Trim(Me.ADDRESS1.Text)
        Session.Item(SessionDef.ShisetsuKensaku_ADDRESS2) = Trim(Me.ADDRESS2.Text)
        Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME) = Trim(Me.ANS_SHISETSU_NAME.Text)
        Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME_KANA) = ""
        Session.Item(SessionDef.ShisetsuKensaku_ADDRESS) = ""
        Session.Item(SessionDef.ShisetsuKensaku_TEL) = ""
        Session.Item(SessionDef.ShisetsuKensaku_URL) = ""

        Dim scriptStr As String
        scriptStr = "<script language='javascript' type='text/javascript'>"
        scriptStr &= "window.open('" & URL.ShisetsuKensaku & "','Shisetsu','width=980,height=750,scrollbars=yes,resizable=yes,statusbar=yes');"
        scriptStr &= "</script>"

        ClientScript.RegisterStartupScript(Me.GetType(), "ShisetsuKensaku", scriptStr)
    End Sub

    '[登録]
    Protected Sub BtnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSubmit.Click
        '入力チェック
        If Not Check() Then Exit Sub

        '入力値を取得
        GetValue()

        'データ更新
        If ExecuteTransaction() Then
            'QQQ ??????? Response.Redirect(URL.KaijoRegistEnd)
        End If
    End Sub

    '[NOZOMIへ]
    Protected Sub BtnNozomi_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNozomi.Click
        '入力チェック
        If Not Check() Then Exit Sub

        '入力値を取得
        GetValue()

        'QQQ ???? 送信対象のフラグ等

        'データ更新
        If ExecuteTransaction() Then
            'QQQ ??????? Response.Redirect(URL.KaijoRegistEnd)
        End If
    End Sub

    '入力値を取得
    Private Sub GetValue()
        TBL_KAIJO(SEQ).ANS_STATUS_TEHAI = AppModule.GetValue_ANS_STATUS_TEHAI(Me.ANS_STATUS_TEHAI)
        TBL_KAIJO(SEQ).ANS_SHISETSU_NAME = AppModule.GetValue_ANS_SHISETSU_NAME(Me.ANS_SHISETSU_NAME)
        TBL_KAIJO(SEQ).ANS_SHISETSU_ADDRESS = AppModule.GetValue_ANS_SHISETSU_ADDRESS(Me.ANS_SHISETSU_ADDRESS)
        TBL_KAIJO(SEQ).ANS_SHISETSU_TEL = AppModule.GetValue_ANS_SHISETSU_TEL(Me.ANS_SHISETSU_TEL)
        TBL_KAIJO(SEQ).ANS_SHISETSU_URL = AppModule.GetValue_ANS_SHISETSU_URL(Me.ANS_SHISETSU_URL)
        TBL_KAIJO(SEQ).ANS_MITSUMORI_TF = AppModule.GetValue_ANS_MITSUMORI_TF(Me.ANS_MITSUMORI_TF)
        TBL_KAIJO(SEQ).ANS_MITSUMORI_T = AppModule.GetValue_ANS_MITSUMORI_T(Me.ANS_MITSUMORI_T)
        TBL_KAIJO(SEQ).ANS_MITSUMORI_TOTAL = AppModule.GetValue_ANS_MITSUMORI_TOTAL(Me.ANS_MITSUMORI_T, Me.ANS_MITSUMORI_TF)
        TBL_KAIJO(SEQ).ANS_MITSUMORI_URL = AppModule.GetValue_ANS_MITSUMORI_URL(Me.ANS_MITSUMORI_URL)
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
            strSQL = SQL.TBL_KAIJO.Update(TBL_KAIJO(SEQ))
            CmnDb.Execute(strSQL, MyBase.DbConnection, MyBase.DbTransaction)

            MyBase.Commit()
            Return True
        Catch ex As Exception
            MyBase.Rollback()

            Throw New Exception(Session.Item(SessionDef.DbError) & vbNewLine & Trim(strSQL))
            Return False
        End Try

        Return True
    End Function

    '[再計算]
    Protected Sub BtnCalc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCalc.Click
        Dim wANS_MITSUMORI_T As String = Trim(StrConv(Me.ANS_MITSUMORI_T.Text, VbStrConv.Narrow))
        Dim wANS_MITSUMORI_TF As String = Trim(StrConv(Me.ANS_MITSUMORI_TF.Text, VbStrConv.Narrow))

        If CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_MITSUMORI_T)) AndAlso CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_MITSUMORI_TF)) Then
            Me.ANS_MITSUMORI_TOTAL.Text = AppModule.GetName_ANS_MITSUMORI_TOTAL(wANS_MITSUMORI_T, wANS_MITSUMORI_TF)
        End If
    End Sub

    '[キャンセル]
    Protected Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCancel.Click
        Response.Redirect(Session.Item(SessionDef.BackURL))
    End Sub

End Class
