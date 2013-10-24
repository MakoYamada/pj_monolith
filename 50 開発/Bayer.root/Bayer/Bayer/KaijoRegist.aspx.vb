﻿Imports CommonLib
Imports AppLib
Partial Public Class KaijoRegist
    Inherits WebBase

    Private TBL_KAIJO() As TableDef.TBL_KAIJO.DataStruct
    Private SEQ As Integer

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        If Trim(Session.Item(SessionDef.KaijoRireki)) = Session.SessionID Then
        Else
            Session.Item(SessionDef.TBL_KAIJO) = TBL_KAIJO
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '共通チェック
        If Trim(Session.Item(SessionDef.KaijoRireki)) = Session.SessionID Then
            MyModule.IsPageOK(False, Session.Item(SessionDef.LoginID), Me)
        Else
            MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)
        End If

        'セッションを変数に格納
        If Not SetSession() Then
            Response.Redirect(URL.TimeOut)
        End If

        If Not Page.IsPostBack Then
            '画面項目 初期化
            InitControls()

            '画面項目表示
            SetForm()
        Else
            If Trim(Session.Item(SessionDef.KaijoRireki)) = Session.SessionID Then
            Else
                If Trim(Session.Item(SessionDef.ShisetsuKensaku_Back)) = CmnConst.Flag.On Then
                    '検索画面戻り
                    Me.ANS_SHISETSU_NAME.Text = Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME)
                    Me.ANS_SHISETSU_ZIP.Text = Session.Item(SessionDef.ShisetsuKensaku_ZIP)
                    Me.ANS_SHISETSU_ADDRESS.Text = Session.Item(SessionDef.ShisetsuKensaku_ADDRESS)
                    Me.ANS_SHISETSU_TEL.Text = Session.Item(SessionDef.ShisetsuKensaku_TEL)
                    Me.ANS_SHISETSU_URL.Text = Session.Item(SessionDef.ShisetsuKensaku_URL)
                End If
            End If
        End If
        Session.Remove(SessionDef.ShisetsuKensaku_Back)

        'マスターページ設定
        With Me.Master
            .HideLoginUser = True   'QQQ
            .PageTitle = "講演会場　手配・見積依頼"
            If Trim(Session.Item(SessionDef.KaijoRireki)) = Session.SessionID Then
                .PageTitle &= " ：履歴照会"
                .HideMenu = True
                .HideLogout = True
            End If
        End With
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        If Trim(Session.Item(SessionDef.KaijoRireki)) = Session.SessionID Then
            '履歴の場合
            Try
                TBL_KAIJO = Session.Item(SessionDef.KaijoRireki_TBL_KAIJO)
                If IsNothing(TBL_KAIJO) Then Return False
            Catch ex As Exception
                Return False
            End Try
            If Not MyModule.IsValidSEQ(Session.Item(SessionDef.KaijoRireki_SEQ)) Then
                Return False
            Else
                SEQ = Session.Item(SessionDef.KaijoRireki_SEQ)
            End If
        Else
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
        End If
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        'プルダウン設定
        AppModule.SetDropDownList_ANS_STATUS_TEHAI(Me.ANS_STATUS_TEHAI, True)
        AppModule.SetDropDownList_ADDRESS1(Me.ADDRESS1)

        'IME設定
        CmnModule.SetIme(Me.ADDRESS2, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_SENTEI_RIYU, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_SHISETSU_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_KOUEN_KAIJO_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_KOUEN_KAIJO_FLOOR, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_IKENKOUKAN_KAIJO_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_IROUKAI_KAIJO_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_KOUSHI_ROOM_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_SHAIN_ROOM_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_MANAGER_KAIJO_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_KAISAI_NOTE, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_MITSUMORI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_MITSUMORI_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_MITSUMORI_URL, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_KAIJOUHI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_KIZAIHI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_INSHOKUHI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_HOTELHI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_KOTSUHI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TEHAI_TESURYO_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_HAKKEN_TESURYO_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_SEISAN_TESURYO_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_JINKENHI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_OTHER_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_KANRIHI_TF, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_KAIJOUHI_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_KIZAIHI_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_INSHOKUHI_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_JINKENHI_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_OTHER_T, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_KANRIHI_T, CmnModule.ImeType.Disabled)

        'クリア
        CmnModule.ClearAllControl(Me)

        If Trim(Session.Item(SessionDef.KaijoRireki)) = Session.SessionID Then
            '履歴からの場合、キャンセル以外のボタンを非表示にする
            Me.BtnShisetsuKensaku.Visible = False
            Me.BtnCalc_ANS_MITSUMORI.Visible = False
            Me.BtnCalc_ANS_TOTAL_TF.Visible = False
            Me.BtnCalc_ANS_TOTAL_T.Visible = False
            Me.BtnRireki.Visible = False
            Me.BtnPrint.Visible = False
            Me.BtnNozomi.Visible = False
            Me.BtnSubmit.Visible = False
            Me.TrComment.Visible = False
        Else
            Me.BtnShisetsuKensaku.Visible = True
            Me.BtnCalc_ANS_MITSUMORI.Visible = True
            Me.BtnCalc_ANS_TOTAL_TF.Visible = True
            Me.BtnCalc_ANS_TOTAL_T.Visible = True
            Me.BtnRireki.Visible = True
            Me.BtnPrint.Visible = True
            Me.BtnNozomi.Visible = True
            Me.BtnSubmit.Visible = True
            Me.TrComment.Visible = True
            ''タイムスタンプが新しい物がある時は、登録/Nozomiへは不可
            'If IsExistLaterData() Then
            '    CmnModule.SetEnabled(Me.BtnSubmit, False)
            '    CmnModule.SetEnabled(Me.BtnNozomi, False)
            'End If
        End If
    End Sub

    '新しいタイムスタンプのデータをチェック
    Private Function IsExistLaterData() As Boolean
        Dim strSQL As String = SQL.TBL_KAIJO.byKOUENKAI_NO_TIME_STAMP_BYL(TBL_KAIJO(SEQ).KOUENKAI_NO, TBL_KAIJO(SEQ).TIME_STAMP_BYL)
        If CmnDb.IsExist(strSQL, MyBase.DbConnection) Then
            Return True
        Else
            Return False
        End If
    End Function

    '画面項目 表示
    Private Sub SetForm()
        '依頼(表示)
        Me.KOUENKAI_NO.Text = AppModule.GetName_KOUENKAI_NO(TBL_KAIJO(SEQ).KOUENKAI_NO)
        Me.REQ_STATUS_TEHAI.Text = AppModule.GetName_REQ_STATUS_TEHAI(TBL_KAIJO(SEQ).REQ_STATUS_TEHAI, True)
        Me.TIME_STAMP_BYL.Text = AppModule.GetName_TIME_STAMP_BYL(TBL_KAIJO(SEQ).TIME_STAMP_BYL)
        Me.SHONIN_NAME.Text = AppModule.GetName_SHONIN_NAME(TBL_KAIJO(SEQ).SHONIN_NAME)
        Me.SHONIN_DATE.Text = AppModule.GetName_SHONIN_DATE(TBL_KAIJO(SEQ).SHONIN_DATE)
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
        Me.SANKA_YOTEI_CNT_NMBR.Text = AppModule.GetName_SANKA_YOTEI_CNT_NMBR(TBL_KAIJO(SEQ).SANKA_YOTEI_CNT_NMBR)
        Me.SANKA_YOTEI_CNT_MBR.Text = AppModule.GetName_SANKA_YOTEI_CNT_MBR(TBL_KAIJO(SEQ).SANKA_YOTEI_CNT_MBR)
        Me.SRM_HACYU_KBN.Text = AppModule.GetName_SRM_HACYU_KBN(TBL_KAIJO(SEQ).SRM_HACYU_KBN)
        Me.YOSAN_T.Text = AppModule.GetName_YOSAN_T(TBL_KAIJO(SEQ).YOSAN_T)
        Me.YOSAN_TF.Text = AppModule.GetName_YOSAN_TF(TBL_KAIJO(SEQ).YOSAN_TF)
        Me.YOSAN_TOTAL.Text = AppModule.GetName_YOSAN_TOTAL(TBL_KAIJO(SEQ).YOSAN_T, TBL_KAIJO(SEQ).YOSAN_TF)
        Me.IROUKAI_YOSAN_T.Text = AppModule.GetName_IROUKAI_YOSAN_T(TBL_KAIJO(SEQ).IROUKAI_YOSAN_T)
        Me.IKENKOUKAN_YOSAN_T.Text = AppModule.GetName_IKENKOUKAN_YOSAN_T(TBL_KAIJO(SEQ).IKENKOUKAN_YOSAN_T)
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
        Me.KOUSHI_ROOM_FROM.Text = AppModule.GetName_KOUSHI_ROOM_FROM(TBL_KAIJO(SEQ).KOUSHI_ROOM_FROM)
        Me.KOUSHI_ROOM_CNT.Text = AppModule.GetName_KOUSHI_ROOM_CNT(TBL_KAIJO(SEQ).KOUSHI_ROOM_CNT)
        Me.SHAIN_ROOM_TEHAI_Yes.Text = AppModule.GetName_SHAIN_ROOM_TEHAI_Yes(TBL_KAIJO(SEQ).SHAIN_ROOM_TEHAI)
        Me.SHAIN_ROOM_TEHAI_No.Text = AppModule.GetName_SHAIN_ROOM_TEHAI_No(TBL_KAIJO(SEQ).SHAIN_ROOM_TEHAI)
        Me.SHAIN_ROOM_CNT.Text = AppModule.GetName_SHAIN_ROOM_CNT(TBL_KAIJO(SEQ).SHAIN_ROOM_CNT)
        Me.MANAGER_KAIJO_TEHAI_Yes.Text = AppModule.GetName_MANAGER_KAIJO_TEHAI_Yes(TBL_KAIJO(SEQ).MANAGER_KAIJO_TEHAI)
        Me.MANAGER_KAIJO_TEHAI_No.Text = AppModule.GetName_MANAGER_KAIJO_TEHAI_No(TBL_KAIJO(SEQ).MANAGER_KAIJO_TEHAI)
        Me.MANAGER_ROOM_FROM.Text = AppModule.GetName_MANAGER_ROOM_FROM(TBL_KAIJO(SEQ).MANAGER_ROOM_FROM)
        Me.MANAGER_ROOM_CNT.Text = AppModule.GetName_MANAGER_ROOM_CNT(TBL_KAIJO(SEQ).MANAGER_ROOM_CNT)
        Me.REQ_ROOM_CNT.Text = AppModule.GetName_REQ_ROOM_CNT(TBL_KAIJO(SEQ).REQ_ROOM_CNT)
        Me.REQ_STAY_DATE.Text = AppModule.GetName_REQ_STAY_DATE(TBL_KAIJO(SEQ).REQ_STAY_DATE)
        Me.REQ_KOTSU_CNT.Text = AppModule.GetName_REQ_KOTSU_CNT(TBL_KAIJO(SEQ).REQ_KOTSU_CNT)
        Me.REQ_TAXI_CNT.Text = AppModule.GetName_REQ_TAXI_CNT(TBL_KAIJO(SEQ).REQ_TAXI_CNT)

        '回答
        AppModule.SetForm_ANS_STATUS_TEHAI(TBL_KAIJO(SEQ).ANS_STATUS_TEHAI, Me.ANS_STATUS_TEHAI)
        AppModule.SetForm_ADDRESS1(Session.Item(SessionDef.ShisetsuKensaku_ADDRESS1), Me.ADDRESS1)
        AppModule.SetForm_ADDRESS2(Session.Item(SessionDef.ShisetsuKensaku_ADDRESS2), Me.ADDRESS2)
        AppModule.SetForm_ANS_SENTEI_RIYU(TBL_KAIJO(SEQ).ANS_SENTEI_RIYU, Me.ANS_SENTEI_RIYU)
        AppModule.SetForm_ANS_SHISETSU_NAME(Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME), Me.ANS_SHISETSU_NAME)
        AppModule.SetForm_ANS_SHISETSU_ZIP(Session.Item(SessionDef.ShisetsuKensaku_ZIP), Me.ANS_SHISETSU_ZIP)
        AppModule.SetForm_ANS_SHISETSU_ADDRESS(Session.Item(SessionDef.ShisetsuKensaku_ADDRESS), Me.ANS_SHISETSU_ADDRESS)
        AppModule.SetForm_ANS_SHISETSU_TEL(Session.Item(SessionDef.ShisetsuKensaku_TEL), Me.ANS_SHISETSU_TEL)
        AppModule.SetForm_ANS_SHISETSU_URL(Session.Item(SessionDef.ShisetsuKensaku_URL), Me.ANS_SHISETSU_URL)
        AppModule.SetForm_ANS_KOUEN_KAIJO_NAME(TBL_KAIJO(SEQ).ANS_KOUEN_KAIJO_NAME, Me.ANS_KOUEN_KAIJO_NAME)
        AppModule.SetForm_ANS_KOUEN_KAIJO_FLOOR(TBL_KAIJO(SEQ).ANS_KOUEN_KAIJO_FLOOR, Me.ANS_KOUEN_KAIJO_FLOOR)
        AppModule.SetForm_ANS_IKENKOUKAN_KAIJO_NAME(TBL_KAIJO(SEQ).ANS_IKENKOUKAN_KAIJO_NAME, Me.ANS_IKENKOUKAN_KAIJO_NAME)
        AppModule.SetForm_ANS_IROUKAI_KAIJO_NAME(TBL_KAIJO(SEQ).ANS_IROUKAI_KAIJO_NAME, Me.ANS_IROUKAI_KAIJO_NAME)
        AppModule.SetForm_ANS_KOUSHI_ROOM_NAME(TBL_KAIJO(SEQ).ANS_KOUSHI_ROOM_NAME, Me.ANS_KOUSHI_ROOM_NAME)
        AppModule.SetForm_ANS_SHAIN_ROOM_NAME(TBL_KAIJO(SEQ).ANS_SHAIN_ROOM_NAME, Me.ANS_SHAIN_ROOM_NAME)
        AppModule.SetForm_ANS_MANAGER_KAIJO_NAME(TBL_KAIJO(SEQ).ANS_MANAGER_KAIJO_NAME, Me.ANS_MANAGER_KAIJO_NAME)
        AppModule.SetForm_ANS_KAISAI_NOTE(TBL_KAIJO(SEQ).ANS_KAISAI_NOTE, Me.ANS_KAISAI_NOTE)
        AppModule.SetForm_ANS_MITSUMORI_TF(TBL_KAIJO(SEQ).ANS_MITSUMORI_TF, Me.ANS_MITSUMORI_TF)
        AppModule.SetForm_ANS_MITSUMORI_T(TBL_KAIJO(SEQ).ANS_MITSUMORI_T, Me.ANS_MITSUMORI_T)
        AppModule.SetForm_ANS_MITSUMORI_URL(TBL_KAIJO(SEQ).ANS_MITSUMORI_URL, Me.ANS_MITSUMORI_URL)
        AppModule.SetForm_ANS_KAIJOUHI_TF(TBL_KAIJO(SEQ).ANS_KAIJOUHI_TF, Me.ANS_KAIJOUHI_TF)
        AppModule.SetForm_ANS_KIZAIHI_TF(TBL_KAIJO(SEQ).ANS_KIZAIHI_TF, Me.ANS_KIZAIHI_TF)
        AppModule.SetForm_ANS_INSHOKUHI_TF(TBL_KAIJO(SEQ).ANS_INSHOKUHI_TF, Me.ANS_INSHOKUHI_TF)
        AppModule.SetForm_ANS_HOTELHI_TF(TBL_KAIJO(SEQ).ANS_HOTELHI_TF, Me.ANS_HOTELHI_TF)
        AppModule.SetForm_ANS_KOTSUHI_TF(TBL_KAIJO(SEQ).ANS_KOTSUHI_TF, Me.ANS_KOTSUHI_TF)
        AppModule.SetForm_ANS_TAXI_TF(TBL_KAIJO(SEQ).ANS_TAXI_TF, Me.ANS_TAXI_TF)
        AppModule.SetForm_ANS_TEHAI_TESURYO_TF(TBL_KAIJO(SEQ).ANS_TEHAI_TESURYO_TF, Me.ANS_TEHAI_TESURYO_TF)
        AppModule.SetForm_ANS_TAXI_HAKKEN_TESURYO_TF(TBL_KAIJO(SEQ).ANS_TAXI_HAKKEN_TESURYO_TF, Me.ANS_TAXI_HAKKEN_TESURYO_TF)
        AppModule.SetForm_ANS_TAXI_SEISAN_TESURYO_TF(TBL_KAIJO(SEQ).ANS_TAXI_SEISAN_TESURYO_TF, Me.ANS_TAXI_SEISAN_TESURYO_TF)
        AppModule.SetForm_ANS_JINKENHI_TF(TBL_KAIJO(SEQ).ANS_JINKENHI_TF, Me.ANS_JINKENHI_TF)
        AppModule.SetForm_ANS_OTHER_TF(TBL_KAIJO(SEQ).ANS_OTHER_TF, Me.ANS_OTHER_TF)
        AppModule.SetForm_ANS_KANRIHI_TF(TBL_KAIJO(SEQ).ANS_KANRIHI_TF, Me.ANS_KANRIHI_TF)
        AppModule.SetForm_ANS_KAIJOUHI_T(TBL_KAIJO(SEQ).ANS_KAIJOUHI_T, Me.ANS_KAIJOUHI_T)
        AppModule.SetForm_ANS_KIZAIHI_T(TBL_KAIJO(SEQ).ANS_KIZAIHI_T, Me.ANS_KIZAIHI_T)
        AppModule.SetForm_ANS_INSHOKUHI_T(TBL_KAIJO(SEQ).ANS_INSHOKUHI_T, Me.ANS_INSHOKUHI_T)
        AppModule.SetForm_ANS_JINKENHI_T(TBL_KAIJO(SEQ).ANS_JINKENHI_T, Me.ANS_JINKENHI_T)
        AppModule.SetForm_ANS_OTHER_T(TBL_KAIJO(SEQ).ANS_OTHER_T, Me.ANS_OTHER_T)
        AppModule.SetForm_ANS_KANRIHI_T(TBL_KAIJO(SEQ).ANS_KANRIHI_T, Me.ANS_KANRIHI_T)
        'AppModule.SetForm_ANS_991330401_TF(TBL_KAIJO(SEQ).ANS_991330401_TF, Me.ANS_991330401_TF)
        'AppModule.SetForm_ANS_41120200_TF(TBL_KAIJO(SEQ).ANS_41120200_TF, Me.ANS_41120200_TF)
        'AppModule.SetForm_ANS_TOTAL_TF(TBL_KAIJO(SEQ).ANS_TOTAL_TF, Me.ANS_TOTAL_TF)
        'AppModule.SetForm_ANS_991330401_T(TBL_KAIJO(SEQ).ANS_991330401_T, Me.ANS_991330401_T)
        'AppModule.SetForm_ANS_41120200_T(TBL_KAIJO(SEQ).ANS_41120200_T, Me.ANS_41120200_T)
        'AppModule.SetForm_ANS_TOTAL_T(TBL_KAIJO(SEQ).ANS_TOTAL_T, Me.ANS_TOTAL_T)
        Me.ANS_MITSUMORI_TOTAL.Text = AppModule.GetName_ANS_MITSUMORI_TOTAL(TBL_KAIJO(SEQ).ANS_MITSUMORI_TOTAL) & "円"
        Me.ANS_991330401_TF.Text = AppModule.GetName_ANS_991330401_TF(TBL_KAIJO(SEQ).ANS_991330401_TF) & "円"
        Me.ANS_41120200_TF.Text = AppModule.GetName_ANS_41120200_TF(TBL_KAIJO(SEQ).ANS_41120200_TF) & "円"
        Me.ANS_TOTAL_TF.Text = AppModule.GetName_ANS_TOTAL_TF(TBL_KAIJO(SEQ).ANS_TOTAL_TF) & "円"
        Me.ANS_991330401_T.Text = AppModule.GetName_ANS_991330401_T(TBL_KAIJO(SEQ).ANS_991330401_T) & "円"
        Me.ANS_41120200_T.Text = AppModule.GetName_ANS_41120200_T(TBL_KAIJO(SEQ).ANS_41120200_T) & "円"
        Me.ANS_TOTAL_T.Text = AppModule.GetName_ANS_TOTAL_T(TBL_KAIJO(SEQ).ANS_TOTAL_T) & "円"
    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        If Not CmnCheck.IsInput(Me.ANS_STATUS_TEHAI) Then
            CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_KAIJO.Name.ANS_STATUS_TEHAI), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.ANS_SHISETSU_NAME, Me.ANS_SHISETSU_NAME.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_SHISETSU_NAME, Me.ANS_SHISETSU_NAME.MaxLength, True), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.ANS_KOUEN_KAIJO_NAME, Me.ANS_KOUEN_KAIJO_NAME.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_KOUEN_KAIJO_NAME, Me.ANS_KOUEN_KAIJO_NAME.MaxLength, True), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.ANS_KOUEN_KAIJO_FLOOR, Me.ANS_KOUEN_KAIJO_FLOOR.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_KOUEN_KAIJO_FLOOR, Me.ANS_KOUEN_KAIJO_FLOOR.MaxLength, True), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.ANS_IKENKOUKAN_KAIJO_NAME, Me.ANS_IKENKOUKAN_KAIJO_NAME.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_IKENKOUKAN_KAIJO_NAME, Me.ANS_IKENKOUKAN_KAIJO_NAME.MaxLength, True), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.ANS_IROUKAI_KAIJO_NAME, Me.ANS_IROUKAI_KAIJO_NAME.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_IROUKAI_KAIJO_NAME, Me.ANS_IROUKAI_KAIJO_NAME.MaxLength, True), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.ANS_KOUSHI_ROOM_NAME, Me.ANS_KOUSHI_ROOM_NAME.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_KOUSHI_ROOM_NAME, Me.ANS_KOUSHI_ROOM_NAME.MaxLength, True), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.ANS_SHAIN_ROOM_NAME, Me.ANS_SHAIN_ROOM_NAME.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_SHAIN_ROOM_NAME, Me.ANS_SHAIN_ROOM_NAME.MaxLength, True), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.ANS_MANAGER_KAIJO_NAME, Me.ANS_MANAGER_KAIJO_NAME.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_MANAGER_KAIJO_NAME, Me.ANS_MANAGER_KAIJO_NAME.MaxLength, True), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.ANS_KAISAI_NOTE, Me.ANS_KAISAI_NOTE.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_KAISAI_NOTE, Me.ANS_KAISAI_NOTE.MaxLength, True), Me)
            Return False
        End If
        If Not CmnCheck.IsNumberOnly(Me.ANS_MITSUMORI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_MITSUMORI_T), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_MITSUMORI_T, Me.ANS_MITSUMORI_T.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_MITSUMORI_T, Me.ANS_MITSUMORI_T.MaxLength), Me)
            Return False
        End If
        If Not CmnCheck.IsNumberOnly(Me.ANS_MITSUMORI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_MITSUMORI_TF), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_MITSUMORI_TF, Me.ANS_MITSUMORI_TF.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_MITSUMORI_TF, Me.ANS_MITSUMORI_TF.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.ANS_SENTEI_RIYU, Me.ANS_SENTEI_RIYU.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_SENTEI_RIYU, Me.ANS_SENTEI_RIYU.MaxLength, True), Me)
            Return False
        End If

        If Not CmnCheck.IsValidTel(Me.ANS_SHISETSU_TEL) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid(TableDef.TBL_KAIJO.Name.ANS_SHISETSU_TEL), Me)
            Return False
        End If

        If Not CmnCheck.IsLengthLE(Me.ANS_MITSUMORI_URL, Me.ANS_MITSUMORI_URL.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_MITSUMORI_URL, Me.ANS_MITSUMORI_URL.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_KAIJOUHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_KAIJOUHI_TF), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_KAIJOUHI_TF, Me.ANS_KAIJOUHI_TF.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_KAIJOUHI_TF, Me.ANS_KAIJOUHI_TF.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_KIZAIHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_KIZAIHI_TF), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_KIZAIHI_TF, Me.ANS_KIZAIHI_TF.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_KIZAIHI_TF, Me.ANS_KIZAIHI_TF.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_INSHOKUHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_INSHOKUHI_TF), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_INSHOKUHI_TF, Me.ANS_INSHOKUHI_TF.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_INSHOKUHI_TF, Me.ANS_INSHOKUHI_TF.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_HOTELHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_HOTELHI_TF), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_HOTELHI_TF, Me.ANS_HOTELHI_TF.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_HOTELHI_TF, Me.ANS_HOTELHI_TF.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_KOTSUHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_KOTSUHI_TF), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_KOTSUHI_TF, Me.ANS_KOTSUHI_TF.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_KOTSUHI_TF, Me.ANS_KOTSUHI_TF.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_TAXI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_TAXI_TF), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_TAXI_TF, Me.ANS_TAXI_TF.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_TAXI_TF, Me.ANS_TAXI_TF.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_TEHAI_TESURYO_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_TEHAI_TESURYO_TF), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_TEHAI_TESURYO_TF, Me.ANS_TEHAI_TESURYO_TF.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_TEHAI_TESURYO_TF, Me.ANS_TEHAI_TESURYO_TF.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_TAXI_HAKKEN_TESURYO_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_TAXI_HAKKEN_TESURYO_TF), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_TAXI_HAKKEN_TESURYO_TF, Me.ANS_TAXI_HAKKEN_TESURYO_TF.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_TAXI_HAKKEN_TESURYO_TF, Me.ANS_TAXI_HAKKEN_TESURYO_TF.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_TAXI_SEISAN_TESURYO_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_TAXI_SEISAN_TESURYO_TF), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_TAXI_SEISAN_TESURYO_TF, Me.ANS_TAXI_SEISAN_TESURYO_TF.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_TAXI_SEISAN_TESURYO_TF, Me.ANS_TAXI_SEISAN_TESURYO_TF.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_JINKENHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_JINKENHI_TF), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_JINKENHI_TF, Me.ANS_JINKENHI_TF.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_JINKENHI_TF, Me.ANS_JINKENHI_TF.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_OTHER_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_OTHER_TF), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_OTHER_TF, Me.ANS_OTHER_TF.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_OTHER_TF, Me.ANS_OTHER_TF.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_KANRIHI_TF) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_KANRIHI_TF), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_KANRIHI_TF, Me.ANS_KANRIHI_TF.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_KANRIHI_TF, Me.ANS_KANRIHI_TF.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_KAIJOUHI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_KAIJOUHI_T), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_KAIJOUHI_T, Me.ANS_KAIJOUHI_T.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_KAIJOUHI_T, Me.ANS_KAIJOUHI_T.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_KIZAIHI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_KIZAIHI_T), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_KIZAIHI_T, Me.ANS_KIZAIHI_T.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_KIZAIHI_T, Me.ANS_KIZAIHI_T.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_INSHOKUHI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_INSHOKUHI_T), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_INSHOKUHI_T, Me.ANS_INSHOKUHI_T.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_INSHOKUHI_T, Me.ANS_INSHOKUHI_T.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_JINKENHI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_JINKENHI_T), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_JINKENHI_T, Me.ANS_JINKENHI_T.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_JINKENHI_T, Me.ANS_JINKENHI_T.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_OTHER_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_OTHER_T), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_OTHER_T, Me.ANS_OTHER_T.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_OTHER_T, Me.ANS_OTHER_T.MaxLength), Me)
            Return False
        End If

        If Not CmnCheck.IsNumberOnly(Me.ANS_KANRIHI_T) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_KAIJO.Name.ANS_KANRIHI_T), Me)
            Return False
        End If
        If Not CmnCheck.IsLengthLE(Me.ANS_KANRIHI_T, Me.ANS_KANRIHI_T.MaxLength) Then
            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_KAIJO.Name.ANS_KANRIHI_T, Me.ANS_KANRIHI_T.MaxLength), Me)
            Return False
        End If

        Return True
    End Function

    '[検索]
    Protected Sub BtnShisetsuKensaku_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnShisetsuKensaku.Click
        Session.Remove(SessionDef.ShisetsuKensaku_Back)
        Session.Item(SessionDef.ShisetsuKensaku_ADDRESS1) = Trim(Me.ADDRESS1.Text)
        Session.Item(SessionDef.ShisetsuKensaku_ADDRESS2) = Trim(Me.ADDRESS2.Text)
        Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_NAME) = Trim(Me.ANS_SHISETSU_NAME.Text)
        Session.Item(SessionDef.ShisetsuKensaku_SHISETSU_KANA) = ""
        Session.Item(SessionDef.ShisetsuKensaku_ZIP) = ""
        Session.Item(SessionDef.ShisetsuKensaku_ADDRESS) = ""
        Session.Item(SessionDef.ShisetsuKensaku_TEL) = ""
        Session.Item(SessionDef.ShisetsuKensaku_URL) = ""

        Dim scriptStr As String
        scriptStr = "<script language='javascript' type='text/javascript'>" & vbNewLine
        scriptStr &= "window.open('" & URL.ShisetsuKensaku & "','ShisetsuKensaku','width=980,height=700,scrollbars=yes,resizable=yes,statusbar=yes');" & vbNewLine
        scriptStr &= "</script>" & vbNewLine

        ClientScript.RegisterStartupScript(Me.GetType(), "ShisetsuKensaku", scriptStr)
    End Sub

    '[登録]
    Protected Sub BtnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSubmit.Click
        '入力チェック
        If Not Check() Then Exit Sub

        '入力値を取得
        GetValue()

        '送信対象 外
        TBL_KAIJO(SEQ).SEND_FLAG = AppConst.SEND_FLAG.Code.Mi

        'データ更新
        If ExecuteTransaction() Then
        End If
    End Sub

    '[NOZOMIへ]
    Protected Sub BtnNozomi_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNozomi.Click
        '入力チェック
        If Not Check() Then Exit Sub

        '入力値を取得
        GetValue()

        '送信対象
        TBL_KAIJO(SEQ).SEND_FLAG = AppConst.SEND_FLAG.Code.Taisho

        'データ更新
        If ExecuteTransaction() Then
        End If
    End Sub

    '入力値を取得
    Private Sub GetValue()
        TBL_KAIJO(SEQ).ANS_STATUS_TEHAI = AppModule.GetValue_ANS_STATUS_TEHAI(Me.ANS_STATUS_TEHAI)
        TBL_KAIJO(SEQ).ANS_SENTEI_RIYU = AppModule.GetValue_ANS_SENTEI_RIYU(Me.ANS_SENTEI_RIYU)
        TBL_KAIJO(SEQ).ANS_SHISETSU_NAME = AppModule.GetValue_ANS_SHISETSU_NAME(Me.ANS_SHISETSU_NAME)
        TBL_KAIJO(SEQ).ANS_SHISETSU_ZIP = AppModule.GetValue_ANS_SHISETSU_ZIP(Me.ANS_SHISETSU_ZIP)
        TBL_KAIJO(SEQ).ANS_SHISETSU_ADDRESS = AppModule.GetValue_ANS_SHISETSU_ADDRESS(Me.ANS_SHISETSU_ADDRESS)
        TBL_KAIJO(SEQ).ANS_SHISETSU_TEL = AppModule.GetValue_ANS_SHISETSU_TEL(Me.ANS_SHISETSU_TEL)
        TBL_KAIJO(SEQ).ANS_SHISETSU_URL = AppModule.GetValue_ANS_SHISETSU_URL(Me.ANS_SHISETSU_URL)
        TBL_KAIJO(SEQ).ANS_KOUEN_KAIJO_NAME = AppModule.GetValue_ANS_KOUEN_KAIJO_NAME(Me.ANS_KOUEN_KAIJO_NAME)
        TBL_KAIJO(SEQ).ANS_KOUEN_KAIJO_FLOOR = AppModule.GetValue_ANS_KOUEN_KAIJO_FLOOR(Me.ANS_KOUEN_KAIJO_FLOOR)
        TBL_KAIJO(SEQ).ANS_IKENKOUKAN_KAIJO_NAME = AppModule.GetValue_ANS_IKENKOUKAN_KAIJO_NAME(Me.ANS_IKENKOUKAN_KAIJO_NAME)
        TBL_KAIJO(SEQ).ANS_IROUKAI_KAIJO_NAME = AppModule.GetValue_ANS_IROUKAI_KAIJO_NAME(Me.ANS_IROUKAI_KAIJO_NAME)
        TBL_KAIJO(SEQ).ANS_KOUSHI_ROOM_NAME = AppModule.GetValue_ANS_KOUSHI_ROOM_NAME(Me.ANS_KOUSHI_ROOM_NAME)
        TBL_KAIJO(SEQ).ANS_SHAIN_ROOM_NAME = AppModule.GetValue_ANS_SHAIN_ROOM_NAME(Me.ANS_SHAIN_ROOM_NAME)
        TBL_KAIJO(SEQ).ANS_MANAGER_KAIJO_NAME = AppModule.GetValue_ANS_MANAGER_KAIJO_NAME(Me.ANS_MANAGER_KAIJO_NAME)
        TBL_KAIJO(SEQ).ANS_KAISAI_NOTE = AppModule.GetValue_ANS_KAISAI_NOTE(Me.ANS_KAISAI_NOTE)
        TBL_KAIJO(SEQ).ANS_MITSUMORI_TF = AppModule.GetValue_ANS_MITSUMORI_TF(Me.ANS_MITSUMORI_TF)
        TBL_KAIJO(SEQ).ANS_MITSUMORI_T = AppModule.GetValue_ANS_MITSUMORI_T(Me.ANS_MITSUMORI_T)
        TBL_KAIJO(SEQ).ANS_MITSUMORI_TOTAL = AppModule.GetValue_ANS_MITSUMORI_TOTAL(Me.ANS_MITSUMORI_T, Me.ANS_MITSUMORI_TF)
        TBL_KAIJO(SEQ).ANS_MITSUMORI_URL = AppModule.GetValue_ANS_MITSUMORI_URL(Me.ANS_MITSUMORI_URL)
        TBL_KAIJO(SEQ).ANS_KAIJOUHI_TF = AppModule.GetValue_ANS_KAIJOUHI_TF(Me.ANS_KAIJOUHI_TF)
        TBL_KAIJO(SEQ).ANS_KIZAIHI_TF = AppModule.GetValue_ANS_KIZAIHI_TF(Me.ANS_KIZAIHI_TF)
        TBL_KAIJO(SEQ).ANS_INSHOKUHI_TF = AppModule.GetValue_ANS_INSHOKUHI_TF(Me.ANS_INSHOKUHI_TF)
        TBL_KAIJO(SEQ).ANS_991330401_TF = AppModule.GetValue_ANS_991330401_TF(Me.ANS_KAIJOUHI_TF, Me.ANS_KIZAIHI_TF, Me.ANS_INSHOKUHI_TF)
        TBL_KAIJO(SEQ).ANS_HOTELHI_TF = AppModule.GetValue_ANS_HOTELHI_TF(Me.ANS_HOTELHI_TF)
        TBL_KAIJO(SEQ).ANS_KOTSUHI_TF = AppModule.GetValue_ANS_KOTSUHI_TF(Me.ANS_KOTSUHI_TF)
        TBL_KAIJO(SEQ).ANS_TAXI_TF = AppModule.GetValue_ANS_TAXI_TF(Me.ANS_TAXI_TF)
        TBL_KAIJO(SEQ).ANS_TEHAI_TESURYO_TF = AppModule.GetValue_ANS_TEHAI_TESURYO_TF(Me.ANS_TEHAI_TESURYO_TF)
        TBL_KAIJO(SEQ).ANS_TAXI_HAKKEN_TESURYO_TF = AppModule.GetValue_ANS_TAXI_HAKKEN_TESURYO_TF(Me.ANS_TAXI_HAKKEN_TESURYO_TF)
        TBL_KAIJO(SEQ).ANS_TAXI_SEISAN_TESURYO_TF = AppModule.GetValue_ANS_TAXI_SEISAN_TESURYO_TF(Me.ANS_TAXI_SEISAN_TESURYO_TF)
        TBL_KAIJO(SEQ).ANS_JINKENHI_TF = AppModule.GetValue_ANS_JINKENHI_TF(Me.ANS_JINKENHI_TF)
        TBL_KAIJO(SEQ).ANS_OTHER_TF = AppModule.GetValue_ANS_OTHER_TF(Me.ANS_OTHER_TF)
        TBL_KAIJO(SEQ).ANS_KANRIHI_TF = AppModule.GetValue_ANS_KANRIHI_TF(Me.ANS_KANRIHI_TF)
        TBL_KAIJO(SEQ).ANS_41120200_TF = AppModule.GetValue_ANS_41120200_TF(Me.ANS_HOTELHI_TF, Me.ANS_KOTSUHI_TF, Me.ANS_TAXI_TF, Me.ANS_TEHAI_TESURYO_TF, Me.ANS_TAXI_HAKKEN_TESURYO_TF, Me.ANS_TAXI_SEISAN_TESURYO_TF, Me.ANS_JINKENHI_TF, Me.ANS_OTHER_TF, Me.ANS_KANRIHI_TF)
        TBL_KAIJO(SEQ).ANS_KAIJOUHI_T = AppModule.GetValue_ANS_KAIJOUHI_T(Me.ANS_KAIJOUHI_T)
        TBL_KAIJO(SEQ).ANS_KIZAIHI_T = AppModule.GetValue_ANS_KIZAIHI_T(Me.ANS_KIZAIHI_T)
        TBL_KAIJO(SEQ).ANS_INSHOKUHI_T = AppModule.GetValue_ANS_INSHOKUHI_T(Me.ANS_INSHOKUHI_T)
        TBL_KAIJO(SEQ).ANS_991330401_T = AppModule.GetValue_ANS_991330401_T(Me.ANS_KAIJOUHI_T, Me.ANS_KIZAIHI_T, Me.ANS_INSHOKUHI_T)
        TBL_KAIJO(SEQ).ANS_JINKENHI_T = AppModule.GetValue_ANS_JINKENHI_T(Me.ANS_JINKENHI_T)
        TBL_KAIJO(SEQ).ANS_OTHER_T = AppModule.GetValue_ANS_OTHER_T(Me.ANS_OTHER_T)
        TBL_KAIJO(SEQ).ANS_KANRIHI_T = AppModule.GetValue_ANS_KANRIHI_T(Me.ANS_KANRIHI_T)
        TBL_KAIJO(SEQ).ANS_41120200_T = AppModule.GetValue_ANS_41120200_T(Me.ANS_JINKENHI_T, Me.ANS_OTHER_T, Me.ANS_KAIJOUHI_T)
        TBL_KAIJO(SEQ).TIME_STAMP_TOP = CmnModule.GetSysDateTime()
        TBL_KAIJO(SEQ).UPDATE_DATE = CmnModule.GetSysDateTime()
        TBL_KAIJO(SEQ).UPDATE_USER = Session.Item(SessionDef.LoginID)
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
    Protected Sub BtnCalc_ANS_MITSUMORI_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCalc_ANS_MITSUMORI.Click
        Dim wANS_MITSUMORI_T As String = Trim(StrConv(Me.ANS_MITSUMORI_T.Text, VbStrConv.Narrow))
        Dim wANS_MITSUMORI_TF As String = Trim(StrConv(Me.ANS_MITSUMORI_TF.Text, VbStrConv.Narrow))

        If CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_MITSUMORI_T)) AndAlso CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_MITSUMORI_TF)) Then
            Me.ANS_MITSUMORI_TOTAL.Text = AppModule.GetName_ANS_MITSUMORI_TOTAL(wANS_MITSUMORI_T, wANS_MITSUMORI_TF)
        End If
    End Sub
    Protected Sub BtnCalc_ANS_TOTAL_TF_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCalc_ANS_TOTAL_TF.Click
        Dim wANS_TOTAL_TF As Long = 0

        '991330401
        Dim wANS_KAIJOUHI_TF As String = Trim(Replace(StrConv(Me.ANS_KAIJOUHI_TF.Text, VbStrConv.Narrow), ",", ""))
        Dim wANS_KIZAIHI_TF As String = Trim(Replace(StrConv(Me.ANS_KIZAIHI_TF.Text, VbStrConv.Narrow), ",", ""))
        Dim wANS_INSHOKUHI_TF As String = Trim(Replace(StrConv(Me.ANS_INSHOKUHI_TF.Text, VbStrConv.Narrow), ",", ""))

        If CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_KAIJOUHI_TF)) AndAlso CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_KIZAIHI_TF)) AndAlso CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_INSHOKUHI_TF)) Then
            Me.ANS_991330401_TF.Text = AppModule.GetName_ANS_991330401_TF(wANS_KAIJOUHI_TF, wANS_KIZAIHI_TF, wANS_INSHOKUHI_TF)
            wANS_TOTAL_TF += CmnModule.DbVal(Replace(Me.ANS_991330401_TF.Text, ",", ""))
        End If

        '41120200
        Dim wANS_HOTELHI_TF As String = Trim(Replace(StrConv(Me.ANS_HOTELHI_TF.Text, VbStrConv.Narrow), ",", ""))
        Dim wANS_KOTSUHI_TF As String = Trim(Replace(StrConv(Me.ANS_KOTSUHI_TF.Text, VbStrConv.Narrow), ",", ""))
        Dim wANS_TAXI_TF As String = Trim(Replace(StrConv(Me.ANS_TAXI_TF.Text, VbStrConv.Narrow), ",", ""))
        Dim wANS_TEHAI_TESURYO_TF As String = Trim(Replace(StrConv(Me.ANS_TEHAI_TESURYO_TF.Text, VbStrConv.Narrow), ",", ""))
        Dim wANS_TAXI_HAKKEN_TESURYO_TF As String = Trim(Replace(StrConv(Me.ANS_TAXI_HAKKEN_TESURYO_TF.Text, VbStrConv.Narrow), ",", ""))
        Dim wANS_TAXI_SEISAN_TESURYO_TF As String = Trim(Replace(StrConv(Me.ANS_TAXI_SEISAN_TESURYO_TF.Text, VbStrConv.Narrow), ",", ""))
        Dim wANS_JINKENHI_TF As String = Trim(Replace(StrConv(Me.ANS_JINKENHI_TF.Text, VbStrConv.Narrow), ",", ""))
        Dim wANS_OTHER_TF As String = Trim(Replace(StrConv(Me.ANS_OTHER_TF.Text, VbStrConv.Narrow), ",", ""))
        Dim wANS_KANRIHI_TF As String = Trim(Replace(StrConv(Me.ANS_KANRIHI_TF.Text, VbStrConv.Narrow), ",", ""))

        If CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_HOTELHI_TF)) AndAlso _
           CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_KOTSUHI_TF)) AndAlso _
           CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_TAXI_TF)) AndAlso _
           CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_TEHAI_TESURYO_TF)) AndAlso _
           CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_TAXI_HAKKEN_TESURYO_TF)) AndAlso _
           CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_TAXI_SEISAN_TESURYO_TF)) AndAlso _
           CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_JINKENHI_TF)) AndAlso _
           CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_OTHER_TF)) AndAlso _
           CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_KANRIHI_TF)) Then
            Me.ANS_41120200_TF.Text = AppModule.GetName_ANS_41120200_TF(wANS_HOTELHI_TF, wANS_KOTSUHI_TF, wANS_TAXI_TF, wANS_TEHAI_TESURYO_TF, wANS_TAXI_HAKKEN_TESURYO_TF, wANS_TAXI_SEISAN_TESURYO_TF, wANS_JINKENHI_TF, wANS_OTHER_TF, wANS_KANRIHI_TF)
            wANS_TOTAL_TF += CmnModule.DbVal(Replace(Me.ANS_41120200_TF.Text, ",", ""))
        End If

        Me.ANS_TOTAL_TF.Text = AppModule.GetName_ANS_TOTAL_TF(wANS_TOTAL_TF)
    End Sub
    Protected Sub BtnCalc_ANS_TOTAL_T_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCalc_ANS_TOTAL_T.Click
        Dim wANS_TOTAL_T As Long = 0

        '991330401
        Dim wANS_KAIJOUHI_T As String = Trim(Replace(StrConv(Me.ANS_KAIJOUHI_T.Text, VbStrConv.Narrow), ",", ""))
        Dim wANS_KIZAIHI_T As String = Trim(Replace(StrConv(Me.ANS_KIZAIHI_T.Text, VbStrConv.Narrow), ",", ""))
        Dim wANS_INSHOKUHI_T As String = Trim(Replace(StrConv(Me.ANS_INSHOKUHI_T.Text, VbStrConv.Narrow), ",", ""))

        If CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_KAIJOUHI_T)) AndAlso CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_KIZAIHI_T)) AndAlso CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_INSHOKUHI_T)) Then
            Me.ANS_991330401_T.Text = AppModule.GetName_ANS_991330401_T(wANS_KAIJOUHI_T, wANS_KIZAIHI_T, wANS_INSHOKUHI_T)
            wANS_TOTAL_T += CmnModule.DbVal(Replace(Me.ANS_991330401_T.Text, ",", ""))
        End If

        '41120200
        Dim wANS_JINKENHI_T As String = Trim(Replace(StrConv(Me.ANS_JINKENHI_T.Text, VbStrConv.Narrow), ",", ""))
        Dim wANS_OTHER_T As String = Trim(Replace(StrConv(Me.ANS_OTHER_T.Text, VbStrConv.Narrow), ",", ""))
        Dim wANS_KANRIHI_T As String = Trim(Replace(StrConv(Me.ANS_KANRIHI_T.Text, VbStrConv.Narrow), ",", ""))

        If CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_JINKENHI_T)) AndAlso _
           CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_OTHER_T)) AndAlso _
           CmnCheck.IsNumberOnly(CmnModule.DbVal(wANS_KANRIHI_T)) Then
            Me.ANS_41120200_T.Text = AppModule.GetName_ANS_41120200_T(wANS_JINKENHI_T, wANS_OTHER_T, wANS_KANRIHI_T)
            wANS_TOTAL_T += CmnModule.DbVal(Replace(Me.ANS_41120200_T.Text, ",", ""))
        End If

        Me.ANS_TOTAL_T.Text = AppModule.GetName_ANS_TOTAL_T(wANS_TOTAL_T)
    End Sub

    '[キャンセル]
    Protected Sub BtnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCancel.Click
        If Trim(Session.Item(SessionDef.KaijoRireki)) = Session.SessionID Then
            Dim scriptStr As String
            scriptStr = "<script language='javascript' type='text/javascript'>" & vbNewLine
            scriptStr &= "window.close();" & vbNewLine
            scriptStr &= "</script>" & vbNewLine
            ClientScript.RegisterStartupScript(Me.GetType(), "RirekiClose", scriptStr)
        Else
            Response.Redirect(Session.Item(SessionDef.BackURL))
        End If
    End Sub

    '[履歴表示]
    Protected Sub BtnRireki_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnRireki.Click
        Dim KaijoRireki_Joken As TableDef.Joken.DataStruct = Nothing
        KaijoRireki_Joken.KOUENKAI_NO = TBL_KAIJO(SEQ).KOUENKAI_NO
        Session.Item(SessionDef.KaijoRireki_Joken) = KaijoRireki_Joken

        Session.Remove(SessionDef.KaijoRireki_TBL_KAIJO)
        Session.Remove(SessionDef.KaijoRireki_SEQ)
        Session.Remove(SessionDef.KaijoRireki_PageIndex)
        Session.Remove(SessionDef.KaijoRireki)

        Response.Redirect(URL.KaijoRireki)
    End Sub

    '[手配書印刷]
    Protected Sub BtnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnPrint.Click
        'QQQ 印刷用の何かを行う
        'QQQ 印刷プレビューへ
    End Sub

End Class
