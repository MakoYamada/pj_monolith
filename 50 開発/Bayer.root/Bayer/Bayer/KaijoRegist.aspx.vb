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
        'QQQ
        Session.Item(SessionDef.LoginID) = "QQQ"

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
            .PageTitle = "講演会場　手配・見積依頼"
        End With

        '検索画面戻り
        Me.FIX_KAISAI_SHISETSU.Text = Session.Item(SessionDef.HotelKensaku_SHISETSU_NAME)
        Me.ADDRESS.Text = Session.Item(SessionDef.HotelKensaku_ADDRESS)
        Me.KAIJO_TEL.Text = Session.Item(SessionDef.HotelKensaku_TEL)
        Me.KAIJO_URL.Text = Session.Item(SessionDef.HotelKensaku_URL)
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
        CmnModule.SetIme(Me.FIX_KAISAI_SHISETSU, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.FIX_SEISAN_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.FIX_SEISAN_GTAX, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.FIX_SEISAN_NTAX, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.FIX_TOTAL, CmnModule.ImeType.Disabled)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        '依頼(表示)
        Me.KOUENKAI_NO.Text = AppModule.GetName_KOUENKAI_NO(TBL_KAIJO(SEQ).KOUENKAI_NO)
        Me.STATUS_TEHAI.Text = AppModule.GetName_STATUS_TEHAI(TBL_KAIJO(SEQ).STATUS_TEHAI)
        Me.YOTEI_DATE.Text = AppModule.GetName_YOTEI_DATE(TBL_KAIJO(SEQ).YOTEI_DATE)
        Me.KAISAI_DATE_NOTE.Text = AppModule.GetName_KAISAI_DATE_NOTE(TBL_KAIJO(SEQ).KAISAI_DATE_NOTE)
        Me.SHONIN_NAME.Text = AppModule.GetName_SHONIN_NAME(TBL_KAIJO(SEQ).SHONIN_NAME)
        Me.SHONIN_TIME.Text = AppModule.GetName_SHONIN_TIME(TBL_KAIJO(SEQ).SHONIN_TIME)
        Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NAME(TBL_KAIJO(SEQ).KOUENKAI_NAME)
        Me.TAXI_PRT_NAME.Text = AppModule.GetName_TAXI_PRT_NAME(TBL_KAIJO(SEQ).TAXI_PRT_NAME)
        Me.SEIHIN_NAME.Text = AppModule.GetName_SEIHIN_NAME(TBL_KAIJO(SEQ).SEIHIN_NAME)
        Me.KIKAKU_TANTO_JIGYOBU.Text = AppModule.GetName_KIKAKU_TANTO_JIGYOBU(TBL_KAIJO(SEQ).KIKAKU_TANTO_JIGYOBU)
        Me.KIKAKU_TANTO_AREA.Text = AppModule.GetName_KIKAKU_TANTO_AREA(TBL_KAIJO(SEQ).KIKAKU_TANTO_AREA)
        Me.KIKAKU_TANTO_EIGYOSHO.Text = AppModule.GetName_KIKAKU_TANTO_EIGYOSHO(TBL_KAIJO(SEQ).KIKAKU_TANTO_EIGYOSHO)
        Me.KIKAKU_TANTO_NO.Text = AppModule.GetName_KIKAKU_TANTO_NO(TBL_KAIJO(SEQ).KIKAKU_TANTO_NO)
        Me.KIKAKU_TANTO_NAME.Text = AppModule.GetName_KIKAKU_TANTO_NAME(TBL_KAIJO(SEQ).KIKAKU_TANTO_NAME)
        Me.KIKAKU_TANTO_KEITAI.Text = AppModule.GetName_KIKAKU_TANTO_KEITAI(TBL_KAIJO(SEQ).KIKAKU_TANTO_KEITAI)
        Me.KIKAKU_TANTO_EMAIL.Text = AppModule.GetName_KIKAKU_TANTO_EMAIL(TBL_KAIJO(SEQ).KIKAKU_TANTO_EMAIL)
        Me.TEHAI_TANTO_JIGYOBU.Text = AppModule.GetName_TEHAI_TANTO_JIGYOBU(TBL_KAIJO(SEQ).TEHAI_TANTO_JIGYOBU)
        Me.TEHAI_TANTO_AREA.Text = AppModule.GetName_TEHAI_TANTO_AREA(TBL_KAIJO(SEQ).TEHAI_TANTO_AREA)
        Me.TEHAI_TANTO_EIGYOSHO.Text = AppModule.GetName_TEHAI_TANTO_EIGYOSHO(TBL_KAIJO(SEQ).TEHAI_TANTO_EIGYOSHO)
        Me.TEHAI_TANTO_NO.Text = AppModule.GetName_TEHAI_TANTO_NO(TBL_KAIJO(SEQ).TEHAI_TANTO_NO)
        Me.TEHAI_TANTO_NAME.Text = AppModule.GetName_TEHAI_TANTO_NAME(TBL_KAIJO(SEQ).TEHAI_TANTO_NAME)
        Me.TEHAI_TANTO_KEITAI.Text = AppModule.GetName_TEHAI_TANTO_KEITAI(TBL_KAIJO(SEQ).TEHAI_TANTO_KEITAI)
        Me.TEHAI_TANTO_EMAIL.Text = AppModule.GetName_TEHAI_TANTO_EMAIL(TBL_KAIJO(SEQ).TEHAI_TANTO_EMAIL)
        Me.SANKA_YOTEI_CNT_DR.Text = AppModule.GetName_SANKA_YOTEI_CNT_DR(TBL_KAIJO(SEQ).SANKA_YOTEI_CNT_DR)
        Me.SANKA_YOTEI_CNT_OTHER.Text = AppModule.GetName_SANKA_YOTEI_CNT_OTHER(TBL_KAIJO(SEQ).SANKA_YOTEI_CNT_OTHER)
        Me.SANKA_YOTEI_CNT_TOTAL.Text = AppModule.GetName_SANKA_YOTEI_CNT_TOTAL(TBL_KAIJO(SEQ).SANKA_YOTEI_CNT_DR, TBL_KAIJO(SEQ).SANKA_YOTEI_CNT_OTHER)
        Me.MITSUMORI_TF.Text = AppModule.GetName_MITSUMORI_TF(TBL_KAIJO(SEQ).MITSUMORI_TF)
        'Me.予算額費用1.Text = AppModule.GetName_予算額費用1(TBL_KAIJO(SEQ).予算額費用1)
        'Me.予算額費用2.Text = AppModule.GetName_予算額費用2(TBL_KAIJO(SEQ).予算額費用2)
        'Me.実施費用計.Text = AppModule.GetName_実施費用計(TBL_KAIJO(SEQ).MITSUMORI_TF, TBL_KAIJO(SEQ).予算額費用1, TBL_KAIJO(SEQ).予算額費用2)
        Me.KAISAI_KIBOU_ADDRESS1.Text = AppModule.GetName_KAISAI_KIBOU_ADDRESS1(TBL_KAIJO(SEQ).KAISAI_KIBOU_ADDRESS1)
        Me.KAISAI_KIBOU_ADDRESS2.Text = AppModule.GetName_KAISAI_KIBOU_ADDRESS2(TBL_KAIJO(SEQ).KAISAI_KIBOU_ADDRESS2)
        Me.KAISAI_KIBOU_NOTE.Text = AppModule.GetName_KAISAI_KIBOU_NOTE(TBL_KAIJO(SEQ).KAISAI_KIBOU_NOTE)
        Me.KOUEN_KAIJO_TEHAI_Yes.Text = AppModule.GetName_KOUEN_KAIJO_TEHAI_Yes(TBL_KAIJO(SEQ).KOUEN_KAIJO_TEHAI)
        Me.KOUEN_KAIJO_TEHAI_No.Text = AppModule.GetName_KOUEN_KAIJO_TEHAI_No(TBL_KAIJO(SEQ).KOUEN_KAIJO_TEHAI)
        Me.KOUEN_TIME1.Text = AppModule.GetName_KOUEN_TIME1(TBL_KAIJO(SEQ).KOUEN_TIME1)
        Me.KOUEN_TIME2.Text = AppModule.GetName_KOUEN_TIME2(TBL_KAIJO(SEQ).KOUEN_TIME2)
        Me.KOUEN_KAIJO_LAYOUT.Text = AppModule.GetName_KOUEN_KAIJO_LAYOUT(TBL_KAIJO(SEQ).KOUEN_KAIJO_LAYOUT)
        Me.IKENKOUKAN_KAIJO_TEHAI_Yes.Text = AppModule.GetName_IKENKOUKAN_KAIJO_TEHAI_Yes(TBL_KAIJO(SEQ).IKENKOUKAN_KAIJO_TEHAI)
        Me.IKENKOUKAN_KAIJO_TEHAI_No.Text = AppModule.GetName_IKENKOUKAN_KAIJO_TEHAI_No(TBL_KAIJO(SEQ).IKENKOUKAN_KAIJO_TEHAI)
        Me.IKENKOUKAN_TIME1.Text = AppModule.GetName_IKENKOUKAN_TIME1(TBL_KAIJO(SEQ).IKENKOUKAN_TIME1)
        Me.IKENKOUKAN_TIME2.Text = AppModule.GetName_IKENKOUKAN_TIME2(TBL_KAIJO(SEQ).IKENKOUKAN_TIME2)
        Me.KOUSHI_ROOM_TEHAI_Yes.Text = AppModule.GetName_KOUSHI_ROOM_TEHAI_Yes(TBL_KAIJO(SEQ).KOUSHI_ROOM_TEHAI)
        Me.KOUSHI_ROOM_TEHAI_No.Text = AppModule.GetName_KOUSHI_ROOM_TEHAI_No(TBL_KAIJO(SEQ).KOUSHI_ROOM_TEHAI)
        Me.KOUSHI_ROOM_TIME1.Text = AppModule.GetName_KOUSHI_ROOM_TIME1(TBL_KAIJO(SEQ).KOUSHI_ROOM_TIME1)
        Me.KOUSHI_ROOM_TIME2.Text = AppModule.GetName_KOUSHI_ROOM_TIME2(TBL_KAIJO(SEQ).KOUSHI_ROOM_TIME2)
        Me.KOUSHI_ROOM_CNT.Text = AppModule.GetName_KOUSHI_ROOM_CNT(TBL_KAIJO(SEQ).KOUSHI_ROOM_CNT)
        Me.MANAGER_KAIJO_TEHAI_Yes.Text = AppModule.GetName_MANAGER_KAIJO_TEHAI_Yes(TBL_KAIJO(SEQ).MANAGER_KAIJO_TEHAI)
        Me.MANAGER_KAIJO_TEHAI_No.Text = AppModule.GetName_MANAGER_KAIJO_TEHAI_No(TBL_KAIJO(SEQ).MANAGER_KAIJO_TEHAI)
        Me.MANAGER_KAIJO_TIME1.Text = AppModule.GetName_MANAGER_KAIJO_TIME1(TBL_KAIJO(SEQ).MANAGER_KAIJO_TIME1)
        Me.MANAGER_KAIJO_TIME2.Text = AppModule.GetName_MANAGER_KAIJO_TIME2(TBL_KAIJO(SEQ).MANAGER_KAIJO_TIME2)

        '回答
        AppModule.SetForm_ANS_STATUS_TEHAI(TBL_KAIJO(SEQ).ANS_STATUS_TEHAI, Me.ANS_STATUS_TEHAI)
        AppModule.SetForm_ADDRESS1(Session.Item(SessionDef.HotelKensaku_ADDRESS1), Me.ADDRESS1)
        AppModule.SetForm_ADDRESS2(Session.Item(SessionDef.HotelKensaku_ADDRESS2), Me.ADDRESS2)
        AppModule.SetForm_FIX_KAISAI_SHISETSU(TBL_KAIJO(SEQ).FIX_KAISAI_SHISETSU, Me.FIX_KAISAI_SHISETSU)
        AppModule.SetForm_ADDRESS(TBL_KAIJO(SEQ).ADDRESS, Me.ADDRESS)
        AppModule.SetForm_TEL(TBL_KAIJO(SEQ).TEL, Me.KAIJO_TEL)
        AppModule.setform_KAIJO_URL(TBL_KAIJO(SEQ).KAIJO_URL, Me.KAIJO_URL)
        AppModule.SetForm_FIX_SEISAN_TF(TBL_KAIJO(SEQ).FIX_SEISAN_TF, Me.FIX_SEISAN_TF)
        AppModule.SetForm_FIX_SEISAN_GTAX(TBL_KAIJO(SEQ).FIX_SEISAN_GTAX, Me.FIX_SEISAN_GTAX)
        AppModule.SetForm_FIX_SEISAN_NTAX(TBL_KAIJO(SEQ).FIX_SEISAN_NTAX, Me.FIX_SEISAN_NTAX)
        AppModule.SetForm_FIX_TOTAL(TBL_KAIJO(SEQ).FIX_SEISAN_TF, TBL_KAIJO(SEQ).FIX_SEISAN_GTAX, TBL_KAIJO(SEQ).FIX_SEISAN_GTAX, Me.FIX_TOTAL)
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

        If Not CmnCheck.IsNumberOnly(Me.FIX_SEISAN_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.FIX_SEISAN_TF), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.FIX_SEISAN_GTAX) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.FIX_SEISAN_GTAX), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.FIX_SEISAN_NTAX) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.FIX_SEISAN_NTAX), Me)
            Return False
        End If

        Me.FIX_TOTAL.Text = AppModule.GetName_FIX_TOTAL(Trim(StrConv(Me.FIX_SEISAN_TF.Text, VbStrConv.Narrow)), Trim(StrConv(Me.FIX_SEISAN_GTAX.Text, VbStrConv.Narrow)), Trim(StrConv(Me.FIX_SEISAN_NTAX.Text, VbStrConv.Narrow)))

        Return True
    End Function

    '[検索]
    Protected Sub BtnHotelKensaku_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnHotelKensaku.Click
        Session.Item(SessionDef.HotelKensaku_ADDRESS1) = Trim(Me.ADDRESS1.Text)
        Session.Item(SessionDef.HotelKensaku_ADDRESS2) = Trim(Me.ADDRESS2.Text)
        Session.Item(SessionDef.HotelKensaku_SHISETSU_NAME) = Trim(Me.FIX_KAISAI_SHISETSU.Text)
        Session.Item(SessionDef.HotelKensaku_SHISETSU_NAME_KANA) = ""
        Session.Item(SessionDef.HotelKensaku_ADDRESS) = ""
        Session.Item(SessionDef.HotelKensaku_TEL) = ""
        Session.Item(SessionDef.HotelKensaku_URL) = ""

        Dim scriptStr As String
        scriptStr = "<script type='text/javascript'>"
        scriptStr &= "window.open('" & URL.HotelKensaku & "','_blank','width=300,height=300');"
        scriptStr &= "</script>"

        ClientScript.RegisterStartupScript(Me.GetType(), "HotelKensaku", scriptStr)
    End Sub

    '[NOZOMIへ]
    Protected Sub BtnNozomi_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNozomi.Click
        '入力チェック
        If Not Check() Then Exit Sub

        '入力値を取得
        GetValue()

        'データ更新
        If ExecuteTransaction() Then
            'QQQ ??????? Response.Redirect(URL.KaijoRegistEnd)
        End If
    End Sub

    '入力値を取得
    Private Sub GetValue()
        TBL_KAIJO(SEQ).ANS_STATUS_TEHAI = AppModule.GetValue_ANS_STATUS_TEHAI(Me.ANS_STATUS_TEHAI)
        TBL_KAIJO(SEQ).FIX_KAISAI_SHISETSU = AppModule.GetValue_FIX_KAISAI_SHISETSU(Me.fix_kaisai_shisetsu)
        TBL_KAIJO(SEQ).ADDRESS = AppModule.GetValue_ADDRESS(Me.ADDRESS)
        TBL_KAIJO(SEQ).TEL = AppModule.GetValue_KAIJO_TEL(Me.KAIJO_TEL)
        TBL_KAIJO(SEQ).KAIJO_URL = AppModule.GetValue_kaijo_url(Me.KAIJO_URL)
        TBL_KAIJO(SEQ).FIX_SEISAN_TF = AppModule.GetValue_FIX_SEISAN_TF(Me.FIX_SEISAN_TF)
        TBL_KAIJO(SEQ).FIX_SEISAN_GTAX = AppModule.GetValue_FIX_SEISAN_GTAX(Me.FIX_SEISAN_GTAX)
        TBL_KAIJO(SEQ).FIX_SEISAN_NTAX = AppModule.GetValue_FIX_SEISAN_NTAX(Me.FIX_SEISAN_NTAX)

        'QQQ ???? 送信対象のフラグ等
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

End Class
