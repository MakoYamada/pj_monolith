Imports CommonLib
Imports AppLib
Partial Public Class DrRegist
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private TBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private DSP_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private SEQ As Integer
    Private Popup As Boolean = False

    Private Const IMG_CLOSE = "~/Images/button-cross-alt.png"
    Private Const IMG_OPEN = "~/Images/button-tick-alt.png"

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
        'Session.Item(SessionDef.TBL_DR) = TBL_DR
    End Sub

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load
        'QQQ
        Session.Item(SessionDef.LoginID) = "QQQ"

        '共通チェック
        If Not Session.Item(SessionDef.DrRireki) Then
            '呼び元が新着一覧・検索の場合
            MyModule.IsPageOK(True, Session.Item(SessionDef.LoginID), Me)
            Popup = False
        Else
            '呼び元が履歴一覧・手配画面の場合
            MyModule.IsPageOK(False, Session.Item(SessionDef.LoginID), Me)
            Popup = True
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

            '呼び元が新着一覧・検索以外の場合は登録・NOZOMIボタンは非表示
            If URL.NewDrList.IndexOf(Session.Item(SessionDef.BackURL2)) > 0 OrElse _
                URL.DrList.IndexOf(Session.Item(SessionDef.BackURL2)) > 0 Then
                BtnSubmit.Visible = True
                BtnNozomi.Visible = True
            Else
                BtnSubmit.Visible = False
                BtnNozomi.Visible = False
            End If

            '呼び元が履歴一覧の場合は履歴表示ボタンは非表示
            If Popup Then
                BtnRireki.Visible = False
                BtnSubmit.Visible = False
                BtnNozomi.Visible = False
            Else
                BtnRireki.Visible = True
                BtnSubmit.Visible = True
                BtnNozomi.Visible = True
            End If

            '表示対象より新しい交通・宿泊情報がある場合はNOZOMIボタンは使用不可
            If ChkNewData() Then
                BtnNozomi.Enabled = True
            Else
                BtnNozomi.Enabled = False
            End If

        Else
            Me.ANS_HOTEL_NAME.Text = Session.Item(SessionDef.HotelKensaku_SHISETSU_NAME)
            Me.ANS_HOTEL_ADDRESS.Text = Session.Item(SessionDef.HotelKensaku_ADDRESS2)
            Me.ANS_HOTEL_TEL.Text = Session.Item(SessionDef.HotelKensaku_TEL)
            Me.ANS_CHECKIN_TIME.Text = Session.Item(SessionDef.HotelKensaku_CHECKIN_TIME)
            Me.ANS_CHECKOUT_TIME.Text = Session.Item(SessionDef.HotelKensaku_CHECKOUT_TIME)
        End If

        'マスターページ設定
        With Me.Master
            .PageTitle = "宿泊・交通・タクシーチケット　手配依頼"
            .HideLogout = False
            .HideMenu = False
        End With
    End Sub

    'セッションを変数に格納
    Private Function SetSession() As Boolean
        Try
            If Popup Then
                TBL_KOTSUHOTEL = Session.Item(SessionDef.TBL_KOTSUHOTEL)
                DSP_KOTSUHOTEL = Session.Item(SessionDef.DrRireki_TBL_KOTSUHOTEL)
            Else
                TBL_KOTSUHOTEL = Session.Item(SessionDef.TBL_KOTSUHOTEL)
                DSP_KOTSUHOTEL = Session.Item(SessionDef.TBL_KOTSUHOTEL)
            End If
            If IsNothing(DSP_KOTSUHOTEL) Then Return False
        Catch ex As Exception
            Return False
        End Try
        If Not MyModule.IsValidSEQ(Session.Item(SessionDef.SEQ)) Then
            Return False
        Else
            If Popup Then
                SEQ = Session.Item(SessionDef.DrRireki_SEQ)
            Else
                SEQ = Session.Item(SessionDef.SEQ)
            End If
        End If
        Return True
    End Function

    '画面項目 初期化
    Private Sub InitControls()
        BtnKOTSU_O_1.ImageUrl = IMG_OPEN
        BtnKOTSU_O_2.ImageUrl = IMG_OPEN
        BtnKOTSU_O_3.ImageUrl = IMG_OPEN
        BtnKOTSU_O_4.ImageUrl = IMG_OPEN
        BtnKOTSU_O_5.ImageUrl = IMG_OPEN
        BtnKOTSU_F_1.ImageUrl = IMG_OPEN
        BtnKOTSU_F_2.ImageUrl = IMG_OPEN
        BtnKOTSU_F_3.ImageUrl = IMG_OPEN
        BtnKOTSU_F_4.ImageUrl = IMG_OPEN
        BtnKOTSU_F_5.ImageUrl = IMG_OPEN
        TB_KOTSU_O_1.Visible = False
        TB_KOTSU_O_2.Visible = False
        TB_KOTSU_O_3.Visible = False
        TB_KOTSU_O_4.Visible = False
        TB_KOTSU_O_5.Visible = False
        TB_KOTSU_F_1.Visible = False
        TB_KOTSU_F_2.Visible = False
        TB_KOTSU_F_3.Visible = False
        TB_KOTSU_F_4.Visible = False
        TB_KOTSU_F_5.Visible = False

        BtnTAXI_1.ImageUrl = IMG_OPEN
        TB_TAXI_1.Visible = False

        'プルダウン設定
        AppModule.SetDropDownList_ANS_STATUS_TEHAI(Me.ANS_STATUS_TEHAI)
        AppModule.SetDropDownList_ANS_STATUS_HOTEL(Me.ANS_STATUS_HOTEL)
        AppModule.SetDropDownList_ANS_ROOM_TYPE(Me.ANS_ROOM_TYPE)
        AppModule.SetDropDownList_ANS_O_STATUS_1(Me.ANS_O_STATUS_1)
        AppModule.SetDropDownList_ANS_O_STATUS_2(Me.ANS_O_STATUS_2)
        AppModule.SetDropDownList_ANS_O_STATUS_3(Me.ANS_O_STATUS_3)
        AppModule.SetDropDownList_ANS_O_STATUS_4(Me.ANS_O_STATUS_4)
        AppModule.SetDropDownList_ANS_O_STATUS_5(Me.ANS_O_STATUS_5)
        AppModule.SetDropDownList_ANS_F_STATUS_1(Me.ANS_F_STATUS_1)
        AppModule.SetDropDownList_ANS_F_STATUS_2(Me.ANS_F_STATUS_2)
        AppModule.SetDropDownList_ANS_F_STATUS_3(Me.ANS_F_STATUS_3)
        AppModule.SetDropDownList_ANS_F_STATUS_4(Me.ANS_F_STATUS_4)
        AppModule.SetDropDownList_ANS_F_STATUS_5(Me.ANS_F_STATUS_5)
        AppModule.SetDropDownList_ANS_O_KOTSUKIKAN_1(Me.ANS_O_KOTSUKIKAN_1)
        AppModule.SetDropDownList_ANS_O_KOTSUKIKAN_2(Me.ANS_O_KOTSUKIKAN_2)
        AppModule.SetDropDownList_ANS_O_KOTSUKIKAN_3(Me.ANS_O_KOTSUKIKAN_3)
        AppModule.SetDropDownList_ANS_O_KOTSUKIKAN_4(Me.ANS_O_KOTSUKIKAN_4)
        AppModule.SetDropDownList_ANS_O_KOTSUKIKAN_5(Me.ANS_O_KOTSUKIKAN_5)
        AppModule.SetDropDownList_ANS_F_KOTSUKIKAN_1(Me.ANS_F_KOTSUKIKAN_1)
        AppModule.SetDropDownList_ANS_F_KOTSUKIKAN_2(Me.ANS_F_KOTSUKIKAN_2)
        AppModule.SetDropDownList_ANS_F_KOTSUKIKAN_3(Me.ANS_F_KOTSUKIKAN_3)
        AppModule.SetDropDownList_ANS_F_KOTSUKIKAN_4(Me.ANS_F_KOTSUKIKAN_4)
        AppModule.SetDropDownList_ANS_F_KOTSUKIKAN_5(Me.ANS_F_KOTSUKIKAN_5)
        AppModule.SetDropDownList_ANS_O_SEAT_1(Me.ANS_O_SEAT_1)
        AppModule.SetDropDownList_ANS_O_SEAT_2(Me.ANS_O_SEAT_2)
        AppModule.SetDropDownList_ANS_O_SEAT_3(Me.ANS_O_SEAT_3)
        AppModule.SetDropDownList_ANS_O_SEAT_4(Me.ANS_O_SEAT_4)
        AppModule.SetDropDownList_ANS_O_SEAT_5(Me.ANS_O_SEAT_5)
        AppModule.SetDropDownList_ANS_F_SEAT_1(Me.ANS_F_SEAT_1)
        AppModule.SetDropDownList_ANS_F_SEAT_2(Me.ANS_F_SEAT_2)
        AppModule.SetDropDownList_ANS_F_SEAT_3(Me.ANS_F_SEAT_3)
        AppModule.SetDropDownList_ANS_F_SEAT_4(Me.ANS_F_SEAT_4)
        AppModule.SetDropDownList_ANS_F_SEAT_5(Me.ANS_F_SEAT_5)
        AppModule.SetDropDownList_ANS_F_SEAT_5(Me.ANS_F_SEAT_5)
        AppModule.SetDropDownList_ANS_O_SEAT_KIBOU_1(Me.ANS_O_SEAT_KIBOU1)
        AppModule.SetDropDownList_ANS_O_SEAT_KIBOU_2(Me.ANS_O_SEAT_KIBOU2)
        AppModule.SetDropDownList_ANS_O_SEAT_KIBOU_3(Me.ANS_O_SEAT_KIBOU3)
        AppModule.SetDropDownList_ANS_O_SEAT_KIBOU_4(Me.ANS_O_SEAT_KIBOU4)
        AppModule.SetDropDownList_ANS_O_SEAT_KIBOU_5(Me.ANS_O_SEAT_KIBOU5)
        AppModule.SetDropDownList_ANS_F_SEAT_KIBOU_1(Me.ANS_F_SEAT_KIBOU1)
        AppModule.SetDropDownList_ANS_F_SEAT_KIBOU_2(Me.ANS_F_SEAT_KIBOU2)
        AppModule.SetDropDownList_ANS_F_SEAT_KIBOU_3(Me.ANS_F_SEAT_KIBOU3)
        AppModule.SetDropDownList_ANS_F_SEAT_KIBOU_4(Me.ANS_F_SEAT_KIBOU4)
        AppModule.SetDropDownList_ANS_F_SEAT_KIBOU_5(Me.ANS_F_SEAT_KIBOU5)
        AppModule.SetDropDownList_ANS_MR_O_TEHAI(Me.ANS_MR_O_TEHAI)
        AppModule.SetDropDownList_ANS_MR_f_TEHAI(Me.ANS_MR_F_TEHAI)

        'IME設定        CmnModule.SetIme(Me.ANS_HOTEL_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_HOTEL_ADDRESS, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_HOTEL_TEL, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_HOTEL_DATE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_HAKUSU, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_CHECKIN_TIME, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_CHECKOUT_TIME, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_HOTEL_NOTE, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_O_DATE_1, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_O_DATE_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_O_DATE_3, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_O_DATE_4, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_O_DATE_5, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_F_DATE_1, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_F_DATE_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_F_DATE_3, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_F_DATE_4, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_F_DATE_5, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_O_AIRPORT1_1, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_O_AIRPORT1_2, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_O_AIRPORT1_3, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_O_AIRPORT1_4, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_O_AIRPORT1_5, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_F_AIRPORT1_1, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_F_AIRPORT1_2, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_F_AIRPORT1_3, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_F_AIRPORT1_4, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_F_AIRPORT1_5, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_O_AIRPORT2_1, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_O_AIRPORT2_2, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_O_AIRPORT2_3, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_O_AIRPORT2_4, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_O_AIRPORT2_5, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_F_AIRPORT2_1, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_F_AIRPORT2_2, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_F_AIRPORT2_3, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_F_AIRPORT2_4, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_F_AIRPORT2_5, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_O_TIME1_1, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_O_TIME1_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_O_TIME1_3, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_O_TIME1_4, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_O_TIME1_5, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_F_TIME1_1, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_F_TIME1_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_F_TIME1_3, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_F_TIME1_4, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_F_TIME1_5, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_O_TIME2_1, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_O_TIME2_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_O_TIME2_3, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_O_TIME2_4, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_O_TIME2_5, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_F_TIME2_1, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_F_TIME2_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_F_TIME2_3, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_F_TIME2_4, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_F_TIME2_5, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_O_BIN_1, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_O_BIN_2, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_O_BIN_3, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_O_BIN_4, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_O_BIN_5, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_F_BIN_1, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_F_BIN_2, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_F_BIN_3, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_F_BIN_4, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_F_BIN_5, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_KOTSU_BIKO, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.FIX_RAIL_FARE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.FIX_RAIL_CANCELLATION, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.FIX_OTHER_FARE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.FIX_AIR_FARE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.FIX_AIR_CANCELLATION, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NOTE, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_1, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_2, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_3, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_4, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_5, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_6, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_7, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_8, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_9, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_10, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_11, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_12, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_13, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_14, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_15, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_16, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_17, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_18, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_19, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_DATE_20, CmnModule.ImeType.InActive)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_1, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_2, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_3, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_4, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_5, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_6, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_7, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_8, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_9, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_10, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_11, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_12, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_13, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_14, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_15, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_16, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_17, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_18, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_19, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_KENSHU_20, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_NO_1, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_2, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_3, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_4, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_5, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_6, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_7, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_8, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_9, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_10, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_11, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_12, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_13, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_14, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_15, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_16, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_17, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_18, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_19, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_NO_20, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_MR_HOTEL_NAME, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_MR_HOTEL_ADDRESS, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_MR_HOTEL_TEL, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_MR_CHECKIN_TIME, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_MR_CHECKOUT_TIME, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_MR_HOTEL_NOTE, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_MR_KOTSUHI, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_MR_HOTELHI, CmnModule.ImeType.Disabled)

        'クリア
        CmnModule.ClearAllControl(Me)
    End Sub

    '画面項目 表示
    Private Sub SetForm()
        Dim DSP_SEQ As Integer = 0

        If Popup Then
            DSP_KOTSUHOTEL = Session.Item(SessionDef.DrRireki_TBL_KOTSUHOTEL)
            DSP_SEQ = Session.Item(SessionDef.DrRireki_SEQ)
        Else
            DSP_SEQ = SEQ
        End If

        '講演会最新情報取得
        If Not GetKouenkaiData() Then Exit Sub

        '画面項目表示
        '講演会情報
        Me.KOUENKAI_NO.Text = AppModule.GetName_KOUENKAI_NO(DSP_KOTSUHOTEL(DSP_SEQ).KOUENKAI_NO)
        Me.FROM_DATE.Text = AppModule.GetName_FROM_DATE(TBL_KOUENKAI(0).FROM_DATE)
        Me.TO_DATE.Text = AppModule.GetName_TO_DATE(TBL_KOUENKAI(0).TO_DATE)
        Me.TIME_STAMP.Text = AppModule.GetName_TIME_STAMP(TBL_KOUENKAI(0).TIME_STAMP)
        Me.KOUENKAI_NAME.Text = AppModule.GetName_KOUENKAI_NAME(TBL_KOUENKAI(0).KOUENKAI_NAME)
        Me.TAXI_PRT_NAME.Text = AppModule.GetName_SEIHIN_NAME(TBL_KOUENKAI(0).TAXI_PRT_NAME)

        'MR情報
        Me.MR_BU.Text = AppModule.GetName_MR_BU(DSP_KOTSUHOTEL(DSP_SEQ).MR_BU)
        Me.MR_AREA.Text = AppModule.GetName_MR_AREA(DSP_KOTSUHOTEL(DSP_SEQ).MR_AREA)
        Me.MR_EIGYOSHO.Text = AppModule.GetName_MR_EIGYOSHO(DSP_KOTSUHOTEL(DSP_SEQ).MR_EIGYOSHO)
        Me.ACCOUNT_CODE.Text = AppModule.GetName_ACCOUNT_CODE(DSP_KOTSUHOTEL(DSP_SEQ).ACCOUNT_CD)
        Me.COST_CENTER.Text = AppModule.GetName_COST_CENTER(DSP_KOTSUHOTEL(DSP_SEQ).COST_CENTER)
        Me.INTERNAL_ORDER.Text = AppModule.GetName_INTERNAL_ORDER(DSP_KOTSUHOTEL(DSP_SEQ).INTERNAL_ORDER)
        Me.ZETIA_CD.Text = AppModule.GetName_ZETIA_CD(DSP_KOTSUHOTEL(DSP_SEQ).ZETIA_CD)
        Me.MR_NAME.Text = AppModule.GetName_MR_NAME(DSP_KOTSUHOTEL(DSP_SEQ).MR_NAME)
        Me.MR_ROMA.Text = AppModule.GetName_mr_roma(DSP_KOTSUHOTEL(DSP_SEQ).MR_ROMA)
        Me.MR_KEITAI.Text = AppModule.GetName_MR_KEITAI(DSP_KOTSUHOTEL(DSP_SEQ).MR_KEITAI)
        Me.MR_TEL.Text = AppModule.GetName_MR_TEL(DSP_KOTSUHOTEL(DSP_SEQ).MR_TEL)
        Me.MR_EMAIL_KEITAI.Text = AppModule.GetName_MR_EMAIL_KEITAI(DSP_KOTSUHOTEL(DSP_SEQ).MR_EMAIL_KEITAI)
        Me.MR_EMAIL_PC.Text = AppModule.GetName_MR_EMAIL(DSP_KOTSUHOTEL(DSP_SEQ).MR_EMAIL_PC)
        Me.MR_SEND_SAKI_FS.Text = AppModule.GetName_MR_SEND_SAKI_FS(DSP_KOTSUHOTEL(DSP_SEQ).MR_SEND_SAKI_FS)
        Me.MR_SEND_SAKI_OTHER.Text = AppModule.GetName_MR_SEND_SAKI_OTHER(DSP_KOTSUHOTEL(DSP_SEQ).MR_SEND_SAKI_OTHER)

        'DR情報
        Me.REQ_STATUS_TEHAI.Text = AppModule.GetName_REQ_STATUS_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).REQ_STATUS_TEHAI)
        AppModule.SetForm_ANS_STATUS_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_STATUS_TEHAI, Me.ANS_STATUS_TEHAI)
        Me.SANKASHA_ID.Text = AppModule.GetName_REQ_STATUS_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).REQ_STATUS_TEHAI)
        Me.DR_CD.Text = AppModule.GetName_DR_CD(DSP_KOTSUHOTEL(DSP_SEQ).DR_CD)
        Me.TIME_STAMP_BYL.Text = AppModule.GetName_TIME_STAMP_BYL(DSP_KOTSUHOTEL(DSP_SEQ).TIME_STAMP_BYL)
        Me.TIME_STAMP_TOP.Text = AppModule.GetName_TIME_STAMP_TOP(DSP_KOTSUHOTEL(DSP_SEQ).TIME_STAMP_TOP)
        Me.DR_NAME.Text = AppModule.GetName_DR_NAME(DSP_KOTSUHOTEL(DSP_SEQ).DR_NAME)
        Me.DR_KANA.Text = AppModule.GetName_DR_KANA(DSP_KOTSUHOTEL(DSP_SEQ).DR_KANA)
        Me.DR_SEX.Text = AppModule.GetName_DR_SEX(DSP_KOTSUHOTEL(DSP_SEQ).DR_SEX)
        Me.DR_AGE.Text = AppModule.GetName_DR_AGE(DSP_KOTSUHOTEL(DSP_SEQ).DR_AGE)
        Me.DR_SANKA.Text = AppModule.GetName_DR_SANKA(DSP_KOTSUHOTEL(DSP_SEQ).DR_SANKA)
        Me.DR_YAKUWARI.Text = AppModule.GetName_DR_YAKUWARI(DSP_KOTSUHOTEL(DSP_SEQ).DR_YAKUWARI)
        Me.DR_SHISETSU_CD.Text = AppModule.GetName_DR_SHISETSU_CD(DSP_KOTSUHOTEL(DSP_SEQ).DR_SHISETSU_CD)
        Me.DR_SHISETSU_NAME.Text = AppModule.GetName_DR_SHISETSU_NAME(DSP_KOTSUHOTEL(DSP_SEQ).DR_SHISETSU_NAME)
        Me.DR_SHISETSU_ADDRESS.Text = AppModule.GetName_DR_SHISETSU_ADDRESS(DSP_KOTSUHOTEL(DSP_SEQ).DR_SHISETSU_ADDRESS)
        Me.SHITEIGAI_RIYU.Text = AppModule.GetName_SHITEIGAI_RIYU(DSP_KOTSUHOTEL(DSP_SEQ).SHITEIGAI_RIYU)

        '承認者情報
        Me.SHONIN_NAME.Text = AppModule.GetName_SHONIN_NAME(DSP_KOTSUHOTEL(DSP_SEQ).SHONIN_NAME)
        Me.SHONIN_DATE.Text = AppModule.GetName_SHONIN_DATE(DSP_KOTSUHOTEL(DSP_SEQ).SHONIN_DATE)

        '宿泊手配
        Me.TEHAI_HOTEL.Text = AppModule.GetName_TEHAI_HOTEL(DSP_KOTSUHOTEL(DSP_SEQ).TEHAI_HOTEL)
        Me.HOTEL_IRAINAIYOU.Text = AppModule.GetName_HOTEL_IRAINAIYOU(DSP_KOTSUHOTEL(DSP_SEQ).HOTEL_IRAINAIYOU)
        Me.REQ_HOTEL_DATE.Text = AppModule.GetName_REQ_HOTEL_DATE(DSP_KOTSUHOTEL(DSP_SEQ).REQ_HOTEL_DATE)
        Me.REQ_HAKUSU.Text = AppModule.GetName_REQ_HAKUSU(DSP_KOTSUHOTEL(DSP_SEQ).REQ_HAKUSU)
        Me.REQ_HOTEL_SMOKING.Text = AppModule.GetName_REQ_HOTEL_SMOKING(DSP_KOTSUHOTEL(DSP_SEQ).REQ_HOTEL_SMOKING)
        Me.REQ_HOTEL_NOTE.Text = AppModule.GetName_REQ_HOTEL_NOTE(DSP_KOTSUHOTEL(DSP_SEQ).REQ_HOTEL_NOTE)
        AppModule.SetForm_ANS_STATUS_HOTEL(DSP_KOTSUHOTEL(DSP_SEQ).ANS_STATUS_HOTEL, Me.ANS_STATUS_HOTEL)
        Me.ANS_HOTEL_NAME.Text = AppModule.GetName_ANS_HOTEL_NAME(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTEL_NAME)
        Me.ANS_HOTEL_ADDRESS.Text = AppModule.GetName_ANS_HOTEL_ADDRESS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTEL_ADDRESS)
        Me.ANS_HOTEL_TEL.Text = AppModule.GetName_ANS_HOTEL_TEL(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTEL_TEL)
        Me.ANS_HOTEL_DATE.Text = AppModule.GetName_ANS_HOTEL_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTEL_DATE)
        Me.ANS_HAKUSU.Text = AppModule.GetName_ANS_HAKUSU(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HAKUSU)
        Me.ANS_CHECKIN_TIME.Text = AppModule.GetName_ANS_CHECKIN_TIME(DSP_KOTSUHOTEL(DSP_SEQ).ANS_CHECKIN_TIME)
        Me.ANS_CHECKOUT_TIME.Text = AppModule.GetName_ANS_CHECKOUT_TIME(DSP_KOTSUHOTEL(DSP_SEQ).ANS_CHECKOUT_TIME)
        AppModule.SetForm_ANS_ROOM_TYPE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_ROOM_TYPE, Me.ANS_ROOM_TYPE)
        AppModule.SetForm_ANS_HOTEL_SMOKING(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTEL_SMOKING, Me.ANS_HOTEL_SMOKING)
        Me.ANS_HOTEL_NOTE.Text = AppModule.GetName_ANS_HOTEL_NOTE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTEL_NOTE)

        '交通（往路１）
        Me.REQ_O_TEHAI_1.Text = AppModule.GetName_REQ_O_TEHAI_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TEHAI_1)
        Me.REQ_O_IRAINAIYOU_1.Text = AppModule.GetName_REQ_O_IRAINAIYOU_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_IRAINAIYOU_1)
        Me.REQ_O_KOTSUKIKAN_1.Text = AppModule.GetName_REQ_O_KOTSUKIKAN_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_KOTSUKIKAN_1)
        Me.REQ_O_DATE_1.Text = AppModule.GetName_REQ_O_DATE_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_DATE_1)
        Me.REQ_O_AIRPORT1_1.Text = AppModule.GetName_REQ_O_AIRPORT1_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT1_1)
        Me.REQ_O_AIRPORT2_1.Text = AppModule.GetName_REQ_O_AIRPORT2_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT2_1)
        Me.REQ_O_TIME1_1.Text = AppModule.GetName_REQ_O_TIME1_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME1_1)
        Me.REQ_O_TIME2_1.Text = AppModule.GetName_REQ_O_TIME2_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME2_1)
        Me.REQ_O_BIN_1.Text = AppModule.GetName_REQ_O_BIN_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_BIN_1)
        Me.REQ_O_SEAT_1.Text = AppModule.GetName_REQ_O_SEAT_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_1)
        Me.REQ_O_SEAT_KIBOU1.Text = AppModule.GetName_REQ_O_SEAT_KIBOU_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_KIBOU1)
        AppModule.SetForm_ANS_O_STATUS_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_STATUS_1, Me.ANS_O_STATUS_1)
        AppModule.SetForm_ANS_O_KOTSUKIKAN_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_KOTSUKIKAN_1, Me.ANS_O_KOTSUKIKAN_1)
        Me.ANS_O_DATE_1.Text = AppModule.GetName_ANS_O_DATE_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_DATE_1)
        Me.ANS_O_AIRPORT1_1.Text = AppModule.GetName_ANS_O_AIRPORT1_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT1_1)
        Me.ANS_O_AIRPORT2_1.Text = AppModule.GetName_ANS_O_AIRPORT2_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT2_1)
        Me.ANS_O_TIME1_1.Text = AppModule.GetName_ANS_O_TIME1_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME1_1)
        Me.ANS_O_TIME2_1.Text = AppModule.GetName_ANS_O_TIME2_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME2_1)
        Me.ANS_O_BIN_1.Text = AppModule.GetName_ANS_O_BIN_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_BIN_1)
        AppModule.SetForm_ANS_O_SEAT_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_1, Me.ANS_O_SEAT_1)
        AppModule.SetForm_ANS_O_SEAT_KIBOU1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_KIBOU1, Me.ANS_O_SEAT_KIBOU1)

        '交通（往路２）
        Me.REQ_O_TEHAI_2.Text = AppModule.GetName_REQ_O_TEHAI_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TEHAI_2)
        Me.REQ_O_IRAINAIYOU_2.Text = AppModule.GetName_REQ_O_IRAINAIYOU_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_IRAINAIYOU_2)
        Me.REQ_O_KOTSUKIKAN_2.Text = AppModule.GetName_REQ_O_KOTSUKIKAN_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_KOTSUKIKAN_2)
        Me.REQ_O_DATE_2.Text = AppModule.GetName_REQ_O_DATE_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_DATE_2)
        Me.REQ_O_AIRPORT1_2.Text = AppModule.GetName_REQ_O_AIRPORT1_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT1_2)
        Me.REQ_O_AIRPORT2_2.Text = AppModule.GetName_REQ_O_AIRPORT2_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT2_2)
        Me.REQ_O_TIME1_2.Text = AppModule.GetName_REQ_O_TIME1_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME1_2)
        Me.REQ_O_TIME2_2.Text = AppModule.GetName_REQ_O_TIME2_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME2_2)
        Me.REQ_O_BIN_2.Text = AppModule.GetName_REQ_O_BIN_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_BIN_2)
        Me.REQ_O_SEAT_2.Text = AppModule.GetName_REQ_O_SEAT_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_2)
        Me.REQ_O_SEAT_KIBOU2.Text = AppModule.GetName_REQ_O_SEAT_KIBOU_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_KIBOU2)
        AppModule.SetForm_ANS_O_STATUS_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_STATUS_2, Me.ANS_O_STATUS_2)
        AppModule.SetForm_ANS_O_KOTSUKIKAN_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_KOTSUKIKAN_2, Me.ANS_O_KOTSUKIKAN_2)
        Me.ANS_O_DATE_2.Text = AppModule.GetName_ANS_O_DATE_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_DATE_2)
        Me.ANS_O_AIRPORT1_2.Text = AppModule.GetName_ANS_O_AIRPORT1_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT1_2)
        Me.ANS_O_AIRPORT2_2.Text = AppModule.GetName_ANS_O_AIRPORT2_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT2_2)
        Me.ANS_O_TIME1_2.Text = AppModule.GetName_ANS_O_TIME1_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME1_2)
        Me.ANS_O_TIME2_2.Text = AppModule.GetName_ANS_O_TIME2_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME2_2)
        Me.ANS_O_BIN_2.Text = AppModule.GetName_ANS_O_BIN_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_BIN_2)
        AppModule.SetForm_ANS_O_SEAT_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_2, Me.ANS_O_SEAT_2)
        AppModule.SetForm_ANS_O_SEAT_KIBOU2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_KIBOU2, Me.ANS_O_SEAT_KIBOU2)

        '交通（往路３）
        Me.REQ_O_TEHAI_3.Text = AppModule.GetName_REQ_O_TEHAI_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TEHAI_3)
        Me.REQ_O_IRAINAIYOU_3.Text = AppModule.GetName_REQ_O_IRAINAIYOU_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_IRAINAIYOU_3)
        Me.REQ_O_KOTSUKIKAN_3.Text = AppModule.GetName_REQ_O_KOTSUKIKAN_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_KOTSUKIKAN_3)
        Me.REQ_O_DATE_3.Text = AppModule.GetName_REQ_O_DATE_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_DATE_3)
        Me.REQ_O_AIRPORT1_3.Text = AppModule.GetName_REQ_O_AIRPORT1_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT1_3)
        Me.REQ_O_AIRPORT2_3.Text = AppModule.GetName_REQ_O_AIRPORT2_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT2_3)
        Me.REQ_O_TIME1_3.Text = AppModule.GetName_REQ_O_TIME1_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME1_3)
        Me.REQ_O_TIME2_3.Text = AppModule.GetName_REQ_O_TIME2_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME2_3)
        Me.REQ_O_BIN_3.Text = AppModule.GetName_REQ_O_BIN_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_BIN_3)
        Me.REQ_O_SEAT_3.Text = AppModule.GetName_REQ_O_SEAT_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_3)
        Me.REQ_O_SEAT_KIBOU3.Text = AppModule.GetName_REQ_O_SEAT_KIBOU_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_KIBOU3)
        AppModule.SetForm_ANS_O_STATUS_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_STATUS_3, Me.ANS_O_STATUS_3)
        AppModule.SetForm_ANS_O_KOTSUKIKAN_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_KOTSUKIKAN_3, Me.ANS_O_KOTSUKIKAN_3)
        Me.ANS_O_DATE_3.Text = AppModule.GetName_ANS_O_DATE_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_DATE_3)
        Me.ANS_O_AIRPORT1_3.Text = AppModule.GetName_ANS_O_AIRPORT1_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT1_3)
        Me.ANS_O_AIRPORT2_3.Text = AppModule.GetName_ANS_O_AIRPORT2_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT2_3)
        Me.ANS_O_TIME1_3.Text = AppModule.GetName_ANS_O_TIME1_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME1_3)
        Me.ANS_O_TIME2_3.Text = AppModule.GetName_ANS_O_TIME2_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME2_3)
        Me.ANS_O_BIN_3.Text = AppModule.GetName_ANS_O_BIN_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_BIN_3)
        AppModule.SetForm_ANS_O_SEAT_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_3, Me.ANS_O_SEAT_3)
        AppModule.SetForm_ANS_O_SEAT_KIBOU3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_KIBOU3, Me.ANS_O_SEAT_KIBOU3)

        '交通（往路４）
        Me.REQ_O_TEHAI_4.Text = AppModule.GetName_REQ_O_TEHAI_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TEHAI_4)
        Me.REQ_O_IRAINAIYOU_4.Text = AppModule.GetName_REQ_O_IRAINAIYOU_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_IRAINAIYOU_4)
        Me.REQ_O_KOTSUKIKAN_4.Text = AppModule.GetName_REQ_O_KOTSUKIKAN_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_KOTSUKIKAN_4)
        Me.REQ_O_DATE_4.Text = AppModule.GetName_REQ_O_DATE_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_DATE_4)
        Me.REQ_O_AIRPORT1_4.Text = AppModule.GetName_REQ_O_AIRPORT1_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT1_4)
        Me.REQ_O_AIRPORT2_4.Text = AppModule.GetName_REQ_O_AIRPORT2_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT2_4)
        Me.REQ_O_TIME1_4.Text = AppModule.GetName_REQ_O_TIME1_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME1_4)
        Me.REQ_O_TIME2_4.Text = AppModule.GetName_REQ_O_TIME2_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME2_4)
        Me.REQ_O_BIN_4.Text = AppModule.GetName_REQ_O_BIN_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_BIN_4)
        Me.REQ_O_SEAT_4.Text = AppModule.GetName_REQ_O_SEAT_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_4)
        Me.REQ_O_SEAT_KIBOU4.Text = AppModule.GetName_REQ_O_SEAT_KIBOU_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_KIBOU4)
        AppModule.SetForm_ANS_O_STATUS_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_STATUS_4, Me.ANS_O_STATUS_4)
        AppModule.SetForm_ANS_O_KOTSUKIKAN_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_KOTSUKIKAN_4, Me.ANS_O_KOTSUKIKAN_4)
        Me.ANS_O_DATE_4.Text = AppModule.GetName_ANS_O_DATE_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_DATE_4)
        Me.ANS_O_AIRPORT1_4.Text = AppModule.GetName_ANS_O_AIRPORT1_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT1_4)
        Me.ANS_O_AIRPORT2_4.Text = AppModule.GetName_ANS_O_AIRPORT2_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT2_4)
        Me.ANS_O_TIME1_4.Text = AppModule.GetName_ANS_O_TIME1_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME1_4)
        Me.ANS_O_TIME2_4.Text = AppModule.GetName_ANS_O_TIME2_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME2_4)
        Me.ANS_O_BIN_4.Text = AppModule.GetName_ANS_O_BIN_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_BIN_4)
        AppModule.SetForm_ANS_O_SEAT_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_4, Me.ANS_O_SEAT_4)
        AppModule.SetForm_ANS_O_SEAT_KIBOU4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_KIBOU4, Me.ANS_O_SEAT_KIBOU4)

        '交通（往路５）
        Me.REQ_O_TEHAI_5.Text = AppModule.GetName_REQ_O_TEHAI_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TEHAI_5)
        Me.REQ_O_IRAINAIYOU_5.Text = AppModule.GetName_REQ_O_IRAINAIYOU_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_IRAINAIYOU_5)
        Me.REQ_O_KOTSUKIKAN_5.Text = AppModule.GetName_REQ_O_KOTSUKIKAN_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_KOTSUKIKAN_5)
        Me.REQ_O_DATE_5.Text = AppModule.GetName_REQ_O_DATE_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_DATE_5)
        Me.REQ_O_AIRPORT1_5.Text = AppModule.GetName_REQ_O_AIRPORT1_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT1_5)
        Me.REQ_O_AIRPORT2_5.Text = AppModule.GetName_REQ_O_AIRPORT2_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT2_5)
        Me.REQ_O_TIME1_5.Text = AppModule.GetName_REQ_O_TIME1_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME1_5)
        Me.REQ_O_TIME2_5.Text = AppModule.GetName_REQ_O_TIME2_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME2_5)
        Me.REQ_O_BIN_5.Text = AppModule.GetName_REQ_O_BIN_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_BIN_5)
        Me.REQ_O_SEAT_5.Text = AppModule.GetName_REQ_O_SEAT_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_5)
        Me.REQ_O_SEAT_KIBOU5.Text = AppModule.GetName_REQ_O_SEAT_KIBOU_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_KIBOU5)
        AppModule.SetForm_ANS_O_STATUS_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_STATUS_5, Me.ANS_O_STATUS_5)
        AppModule.SetForm_ANS_O_KOTSUKIKAN_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_KOTSUKIKAN_5, Me.ANS_O_KOTSUKIKAN_5)
        Me.ANS_O_DATE_5.Text = AppModule.GetName_ANS_O_DATE_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_DATE_5)
        Me.ANS_O_AIRPORT1_5.Text = AppModule.GetName_ANS_O_AIRPORT1_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT1_5)
        Me.ANS_O_AIRPORT2_5.Text = AppModule.GetName_ANS_O_AIRPORT2_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT2_5)
        Me.ANS_O_TIME1_5.Text = AppModule.GetName_ANS_O_TIME1_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME1_5)
        Me.ANS_O_TIME2_5.Text = AppModule.GetName_ANS_O_TIME2_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME2_5)
        Me.ANS_O_BIN_5.Text = AppModule.GetName_ANS_O_BIN_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_BIN_5)
        AppModule.SetForm_ANS_O_SEAT_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_5, Me.ANS_O_SEAT_5)
        AppModule.SetForm_ANS_O_SEAT_KIBOU5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_KIBOU5, Me.ANS_O_SEAT_KIBOU5)

        '交通（復路１）
        Me.REQ_F_TEHAI_1.Text = AppModule.GetName_REQ_F_TEHAI_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TEHAI_1)
        Me.REQ_F_IRAINAIYOU_1.Text = AppModule.GetName_REQ_F_IRAINAIYOU_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_IRAINAIYOU_1)
        Me.REQ_F_KOTSUKIKAN_1.Text = AppModule.GetName_REQ_F_KOTSUKIKAN_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_KOTSUKIKAN_1)
        Me.REQ_F_DATE_1.Text = AppModule.GetName_REQ_F_DATE_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_DATE_1)
        Me.REQ_F_AIRPORT1_1.Text = AppModule.GetName_REQ_F_AIRPORT1_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT1_1)
        Me.REQ_F_AIRPORT2_1.Text = AppModule.GetName_REQ_F_AIRPORT2_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT2_1)
        Me.REQ_F_TIME1_1.Text = AppModule.GetName_REQ_F_TIME1_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME1_1)
        Me.REQ_F_TIME2_1.Text = AppModule.GetName_REQ_F_TIME2_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME2_1)
        Me.REQ_F_BIN_1.Text = AppModule.GetName_REQ_F_BIN_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_BIN_1)
        Me.REQ_F_SEAT_1.Text = AppModule.GetName_REQ_F_SEAT_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_1)
        Me.REQ_F_SEAT_KIBOU1.Text = AppModule.GetName_REQ_F_SEAT_KIBOU_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_KIBOU1)
        AppModule.SetForm_ANS_F_STATUS_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_STATUS_1, Me.ANS_F_STATUS_1)
        AppModule.SetForm_ANS_F_KOTSUKIKAN_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_KOTSUKIKAN_1, Me.ANS_F_KOTSUKIKAN_1)
        Me.ANS_F_DATE_1.Text = AppModule.GetName_ANS_F_DATE_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_DATE_1)
        Me.ANS_F_AIRPORT1_1.Text = AppModule.GetName_ANS_F_AIRPORT1_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT1_1)
        Me.ANS_F_AIRPORT2_1.Text = AppModule.GetName_ANS_F_AIRPORT2_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT2_1)
        Me.ANS_F_TIME1_1.Text = AppModule.GetName_ANS_F_TIME1_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME1_1)
        Me.ANS_F_TIME2_1.Text = AppModule.GetName_ANS_F_TIME2_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME2_1)
        Me.ANS_F_BIN_1.Text = AppModule.GetName_ANS_F_BIN_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_BIN_1)
        AppModule.SetForm_ANS_F_SEAT_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_1, Me.ANS_F_SEAT_1)
        AppModule.SetForm_ANS_f_SEAT_KIBOU1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_KIBOU1, Me.ANS_F_SEAT_KIBOU1)

        '交通（復路２）
        Me.REQ_F_TEHAI_2.Text = AppModule.GetName_REQ_F_TEHAI_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TEHAI_2)
        Me.REQ_F_IRAINAIYOU_2.Text = AppModule.GetName_REQ_F_IRAINAIYOU_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_IRAINAIYOU_2)
        Me.REQ_F_KOTSUKIKAN_2.Text = AppModule.GetName_REQ_F_KOTSUKIKAN_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_KOTSUKIKAN_2)
        Me.REQ_F_DATE_2.Text = AppModule.GetName_REQ_F_DATE_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_DATE_2)
        Me.REQ_F_AIRPORT1_2.Text = AppModule.GetName_REQ_F_AIRPORT1_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT1_2)
        Me.REQ_F_AIRPORT2_2.Text = AppModule.GetName_REQ_F_AIRPORT2_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT2_2)
        Me.REQ_F_TIME1_2.Text = AppModule.GetName_REQ_F_TIME1_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME1_2)
        Me.REQ_F_TIME2_2.Text = AppModule.GetName_REQ_F_TIME2_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME2_2)
        Me.REQ_F_BIN_2.Text = AppModule.GetName_REQ_F_BIN_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_BIN_2)
        Me.REQ_F_SEAT_2.Text = AppModule.GetName_REQ_F_SEAT_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_2)
        Me.REQ_f_SEAT_KIBOU2.Text = AppModule.GetName_REQ_F_SEAT_KIBOU_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_KIBOU2)
        AppModule.SetForm_ANS_F_STATUS_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_STATUS_2, Me.ANS_F_STATUS_2)
        AppModule.SetForm_ANS_F_KOTSUKIKAN_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_KOTSUKIKAN_2, Me.ANS_F_KOTSUKIKAN_2)
        Me.ANS_F_DATE_2.Text = AppModule.GetName_ANS_F_DATE_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_DATE_2)
        Me.ANS_F_AIRPORT1_2.Text = AppModule.GetName_ANS_F_AIRPORT1_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT1_2)
        Me.ANS_F_AIRPORT2_2.Text = AppModule.GetName_ANS_F_AIRPORT2_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT2_2)
        Me.ANS_F_TIME1_2.Text = AppModule.GetName_ANS_F_TIME1_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME1_2)
        Me.ANS_F_TIME2_2.Text = AppModule.GetName_ANS_F_TIME2_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME2_2)
        Me.ANS_F_BIN_2.Text = AppModule.GetName_ANS_F_BIN_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_BIN_2)
        AppModule.SetForm_ANS_F_SEAT_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_2, Me.ANS_F_SEAT_2)
        AppModule.SetForm_ANS_f_SEAT_KIBOU2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_KIBOU2, Me.ANS_F_SEAT_KIBOU2)

        '交通（復路３）
        Me.REQ_F_TEHAI_3.Text = AppModule.GetName_REQ_F_TEHAI_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TEHAI_3)
        Me.REQ_F_IRAINAIYOU_3.Text = AppModule.GetName_REQ_F_IRAINAIYOU_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_IRAINAIYOU_3)
        Me.REQ_F_KOTSUKIKAN_3.Text = AppModule.GetName_REQ_F_KOTSUKIKAN_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_KOTSUKIKAN_3)
        Me.REQ_F_DATE_3.Text = AppModule.GetName_REQ_F_DATE_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_DATE_3)
        Me.REQ_F_AIRPORT1_3.Text = AppModule.GetName_REQ_F_AIRPORT1_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT1_3)
        Me.REQ_F_AIRPORT2_3.Text = AppModule.GetName_REQ_F_AIRPORT2_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT2_3)
        Me.REQ_F_TIME1_3.Text = AppModule.GetName_REQ_F_TIME1_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME1_3)
        Me.REQ_F_TIME2_3.Text = AppModule.GetName_REQ_F_TIME2_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME2_3)
        Me.REQ_F_BIN_3.Text = AppModule.GetName_REQ_F_BIN_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_BIN_3)
        Me.REQ_F_SEAT_3.Text = AppModule.GetName_REQ_F_SEAT_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_3)
        Me.REQ_f_SEAT_KIBOU3.Text = AppModule.GetName_REQ_F_SEAT_KIBOU_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_KIBOU3)
        AppModule.SetForm_ANS_F_STATUS_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_STATUS_3, Me.ANS_F_STATUS_3)
        AppModule.SetForm_ANS_F_KOTSUKIKAN_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_KOTSUKIKAN_3, Me.ANS_F_KOTSUKIKAN_3)
        Me.ANS_F_DATE_3.Text = AppModule.GetName_ANS_F_DATE_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_DATE_3)
        Me.ANS_F_AIRPORT1_3.Text = AppModule.GetName_ANS_F_AIRPORT1_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT1_3)
        Me.ANS_F_AIRPORT2_3.Text = AppModule.GetName_ANS_F_AIRPORT2_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT2_3)
        Me.ANS_F_TIME1_3.Text = AppModule.GetName_ANS_F_TIME1_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME1_3)
        Me.ANS_F_TIME2_3.Text = AppModule.GetName_ANS_F_TIME2_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME2_3)
        Me.ANS_F_BIN_3.Text = AppModule.GetName_ANS_F_BIN_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_BIN_3)
        AppModule.SetForm_ANS_F_SEAT_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_3, Me.ANS_F_SEAT_3)
        AppModule.SetForm_ANS_f_SEAT_KIBOU3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_KIBOU3, Me.ANS_F_SEAT_KIBOU3)

        '交通（復路４）
        Me.REQ_F_TEHAI_4.Text = AppModule.GetName_REQ_F_TEHAI_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TEHAI_4)
        Me.REQ_F_IRAINAIYOU_4.Text = AppModule.GetName_REQ_F_IRAINAIYOU_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_IRAINAIYOU_4)
        Me.REQ_F_KOTSUKIKAN_4.Text = AppModule.GetName_REQ_F_KOTSUKIKAN_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_KOTSUKIKAN_4)
        Me.REQ_F_DATE_4.Text = AppModule.GetName_REQ_F_DATE_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_DATE_4)
        Me.REQ_F_AIRPORT1_4.Text = AppModule.GetName_REQ_F_AIRPORT1_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT1_4)
        Me.REQ_F_AIRPORT2_4.Text = AppModule.GetName_REQ_F_AIRPORT2_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT2_4)
        Me.REQ_F_TIME1_4.Text = AppModule.GetName_REQ_F_TIME1_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME1_4)
        Me.REQ_F_TIME2_4.Text = AppModule.GetName_REQ_F_TIME2_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME2_4)
        Me.REQ_F_BIN_4.Text = AppModule.GetName_REQ_F_BIN_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_BIN_4)
        Me.REQ_F_SEAT_4.Text = AppModule.GetName_REQ_F_SEAT_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_4)
        Me.REQ_f_SEAT_KIBOU4.Text = AppModule.GetName_REQ_F_SEAT_KIBOU_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_KIBOU4)
        AppModule.SetForm_ANS_F_STATUS_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_STATUS_4, Me.ANS_F_STATUS_4)
        AppModule.SetForm_ANS_F_KOTSUKIKAN_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_KOTSUKIKAN_4, Me.ANS_F_KOTSUKIKAN_4)
        Me.ANS_F_DATE_4.Text = AppModule.GetName_ANS_F_DATE_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_DATE_4)
        Me.ANS_F_AIRPORT1_4.Text = AppModule.GetName_ANS_F_AIRPORT1_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT1_4)
        Me.ANS_F_AIRPORT2_4.Text = AppModule.GetName_ANS_F_AIRPORT2_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT2_4)
        Me.ANS_F_TIME1_4.Text = AppModule.GetName_ANS_F_TIME1_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME1_4)
        Me.ANS_F_TIME2_4.Text = AppModule.GetName_ANS_F_TIME2_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME2_4)
        Me.ANS_F_BIN_4.Text = AppModule.GetName_ANS_F_BIN_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_BIN_4)
        AppModule.SetForm_ANS_F_SEAT_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_4, Me.ANS_F_SEAT_4)
        AppModule.SetForm_ANS_f_SEAT_KIBOU4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_KIBOU4, Me.ANS_F_SEAT_KIBOU4)

        '交通（復路５）
        Me.REQ_F_TEHAI_5.Text = AppModule.GetName_REQ_F_TEHAI_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TEHAI_5)
        Me.REQ_F_IRAINAIYOU_5.Text = AppModule.GetName_REQ_F_IRAINAIYOU_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_IRAINAIYOU_5)
        Me.REQ_F_KOTSUKIKAN_5.Text = AppModule.GetName_REQ_F_KOTSUKIKAN_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_KOTSUKIKAN_5)
        Me.REQ_F_DATE_5.Text = AppModule.GetName_REQ_F_DATE_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_DATE_5)
        Me.REQ_F_AIRPORT1_5.Text = AppModule.GetName_REQ_F_AIRPORT1_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT1_5)
        Me.REQ_F_AIRPORT2_5.Text = AppModule.GetName_REQ_F_AIRPORT2_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT2_5)
        Me.REQ_F_TIME1_5.Text = AppModule.GetName_REQ_F_TIME1_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME1_5)
        Me.REQ_F_TIME2_5.Text = AppModule.GetName_REQ_F_TIME2_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME2_5)
        Me.REQ_F_BIN_5.Text = AppModule.GetName_REQ_F_BIN_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_BIN_5)
        Me.REQ_F_SEAT_5.Text = AppModule.GetName_REQ_F_SEAT_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_5)
        Me.REQ_f_SEAT_KIBOU5.Text = AppModule.GetName_REQ_F_SEAT_KIBOU_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_KIBOU5)
        AppModule.SetForm_ANS_F_STATUS_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_STATUS_5, Me.ANS_F_STATUS_5)
        AppModule.SetForm_ANS_F_KOTSUKIKAN_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_KOTSUKIKAN_5, Me.ANS_F_KOTSUKIKAN_5)
        Me.ANS_F_DATE_5.Text = AppModule.GetName_ANS_F_DATE_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_DATE_5)
        Me.ANS_F_AIRPORT1_5.Text = AppModule.GetName_ANS_F_AIRPORT1_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT1_5)
        Me.ANS_F_AIRPORT2_5.Text = AppModule.GetName_ANS_F_AIRPORT2_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT2_5)
        Me.ANS_F_TIME1_5.Text = AppModule.GetName_ANS_F_TIME1_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME1_5)
        Me.ANS_F_TIME2_5.Text = AppModule.GetName_ANS_F_TIME2_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME2_5)
        Me.ANS_F_BIN_5.Text = AppModule.GetName_ANS_F_BIN_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_BIN_5)
        AppModule.SetForm_ANS_F_SEAT_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_5, Me.ANS_F_SEAT_5)
        AppModule.SetForm_ANS_f_SEAT_KIBOU5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_KIBOU5, Me.ANS_F_SEAT_KIBOU5)

        '交通備考
        Me.REQ_KOTSU_BIKO.Text = AppModule.GetName_REQ_KOTSU_BIKO(DSP_KOTSUHOTEL(DSP_SEQ).REQ_KOTSU_BIKO)
        Me.ANS_KOTSU_BIKO.Text = AppModule.GetName_ANS_KOTSU_BIKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_KOTSU_BIKO)
    End Sub

    '講演会最新情報取得
    Private Function GetKouenkaiData() As Boolean
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_KOUENKAI.byKOUENKAI_NO(DSP_KOTSUHOTEL(SEQ).KOUENKAI_NO)
        strSQL &= "ORDER BY " & TableDef.TBL_KOUENKAI.Column.TIME_STAMP & " DESC"

        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wFlag = True

            ReDim Preserve TBL_KOUENKAI(wCnt)
            TBL_KOUENKAI(0) = AppModule.SetRsData(RsData, TBL_KOUENKAI(0))
        End If
        RsData.Close()

        Return wFlag
    End Function

    '入力値を取得
    Private Sub GetValue(ByVal Cancel As Boolean)
        ''共通コントロール
        'TBL_DR(SEQ) = GetValue(TBL_DR(SEQ), Cancel)

        ''登録者
        'If MyModule.IsInsertMode() Then
        '    TBL_DR(SEQ).INS_TYPE = AppConst.INS_TYPE.Code.Dr
        'End If

        ''Drメールアドレス
        'MS_DR.DR_MAIL = TBL_DR(SEQ).DR_MAIL '変更があった場合、ログイン情報に反映

        ''変更前データ
        'Dim OldTBL_DR As TableDef.TBL_DR.DataStruct = Nothing

        ''データ区分
        'If Cancel = True Then
        '    TBL_DR(SEQ).NEW_RECORD_KUBUN = AppConst.RECORD_KUBUN.Code.Cancel
        '    OldTBL_DR = AppModule.GetOneRecord(AppModule.TableType.TBL_DR, SQL.TBL_DR.byDATA_NO(TBL_DR(SEQ).DATA_NO), MyBase.DbConnection)
        'Else
        '    If MyModule.IsInsertMode() Then
        '        TBL_DR(SEQ).NEW_RECORD_KUBUN = AppConst.RECORD_KUBUN.Code.Insert
        '    Else
        '        TBL_DR(SEQ).NEW_RECORD_KUBUN = AppConst.RECORD_KUBUN.Code.Update
        '        OldTBL_DR = AppModule.GetOneRecord(AppModule.TableType.TBL_DR, SQL.TBL_DR.byDATA_NO(TBL_DR(SEQ).DATA_NO), MyBase.DbConnection)
        '    End If
        'End If

        ''手配状況
        'TBL_DR(SEQ).NEW_STATUS_TEHAI = AppModule.GetValue_STATUS_TEHAI(TBL_DR(SEQ).NEW_RECORD_KUBUN, TBL_DR(SEQ), OldTBL_DR)
        ''支払状況
        'TBL_DR(SEQ).NEW_STATUS_PAYMENT = AppModule.GetValue_STATUS_PAYMENT(TBL_DR(SEQ).NEW_RECORD_KUBUN, TBL_DR(SEQ), OldTBL_DR)
    End Sub

    '[参加取消]
    Protected Sub BtnCancel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        '入力値を取得
        GetValue(True)

        'データ区分
        'Session.Item(SessionDef.RECORD_KUBUN) = AppConst.RECORD_KUBUN.Code.Cancel
        'TBL_DR(SEQ).NEW_RECORD_KUBUN = AppConst.RECORD_KUBUN.Code.Cancel

        '確認画面へ
        'Response.Redirect(URL.Admin.DrConfirm)
    End Sub

    '画面項目表示
    'Public Sub SetForm(ByVal TBL_DR As TableDef.TBL_DR.DataStruct)
    '    AppModule.SetForm_DR_NAME_FIRST(TBL_DR.DR_NAME_FIRST, Me.DR_NAME_FIRST)
    '    AppModule.SetForm_DR_NAME_LAST(TBL_DR.DR_NAME_LAST, Me.DR_NAME_LAST)
    '    AppModule.SetForm_DR_NAME_KANA_FIRST(TBL_DR.DR_NAME_KANA_FIRST, Me.DR_NAME_KANA_FIRST)
    '    AppModule.SetForm_DR_NAME_KANA_LAST(TBL_DR.DR_NAME_KANA_LAST, Me.DR_NAME_KANA_LAST)
    '    AppModule.SetForm_SEX_Male(TBL_DR.SEX, Me.SEX_Male)
    '    AppModule.SetForm_SEX_Female(TBL_DR.SEX, Me.SEX_Female)
    '    AppModule.SetForm_PREFECTURES_NO(TBL_DR.PREFECTURES_NO, Me.PREFECTURES_NO)
    '    AppModule.SetForm_SHISETSU_NAME(TBL_DR.SHISETSU_NAME, Me.SHISETSU_NAME)
    '    AppModule.SetForm_SHISETSU_NAME_KANA(TBL_DR.SHISETSU_NAME_KANA, Me.SHISETSU_NAME_KANA)
    '    AppModule.SetForm_KAMOKU(TBL_DR.KAMOKU, Me.KAMOKU)
    '    AppModule.SetForm_YAKUSHOKU(TBL_DR.YAKUSHOKU, Me.YAKUSHOKU)
    '    AppModule.SetForm_AGE(TBL_DR.AGE, Me.AGE)
    '    AppModule.SetForm_PUBLIC_SERVANT_Yes(TBL_DR.PUBLIC_SERVANT, Me.PUBLIC_SERVANT_Yes)
    '    AppModule.SetForm_PUBLIC_SERVANT_No(TBL_DR.PUBLIC_SERVANT, Me.PUBLIC_SERVANT_No)
    '    AppModule.SetForm_SECANDARY_USE_Yes(TBL_DR.SECANDARY_USE, Me.SECANDARY_USE_Yes)
    '    AppModule.SetForm_SECANDARY_USE_No(TBL_DR.SECANDARY_USE, Me.SECANDARY_USE_No)
    '    AppModule.SetForm_TEHAI_HOTEL_Yes(TBL_DR.TEHAI_HOTEL, Me.TEHAI_HOTEL_Yes)
    '    AppModule.SetForm_TEHAI_HOTEL_No(TBL_DR.TEHAI_HOTEL, Me.TEHAI_HOTEL_No)
    '    AppModule.SetForm_CHECK_IN(TBL_DR.CHECK_IN, Me.CHECK_IN)
    '    AppModule.SetForm_CHECK_OUT(TBL_DR.CHECK_OUT, Me.CHECK_OUT)
    '    AppModule.SetForm_HOTEL_SMOKING_No(TBL_DR.HOTEL_SMOKING, Me.HOTEL_SMOKING_No)
    '    AppModule.SetForm_HOTEL_SMOKING_Yes(TBL_DR.HOTEL_SMOKING, Me.HOTEL_SMOKING_Yes)
    '    AppModule.SetForm_ACCOMPANY_FLAG_Yes(TBL_DR.ACCOMPANY_FLAG, Me.ACCOMPANY_FLAG_Yes)
    '    AppModule.SetForm_ACCOMPANY_FLAG_No(TBL_DR.ACCOMPANY_FLAG, Me.ACCOMPANY_FLAG_No)
    '    AppModule.SetForm_ACCOMPANY_STAY_Yes(TBL_DR.ACCOMPANY_STAY, Me.ACCOMPANY_STAY_Yes)
    '    AppModule.SetForm_ACCOMPANY_STAY_No(TBL_DR.ACCOMPANY_STAY, Me.ACCOMPANY_STAY_No)
    '    AppModule.SetForm_ACCOMPANY_STAY_DATE(TBL_DR.ACCOMPANY_STAY_DATE, Me.ACCOMPANY_STAY_DATE)
    '    AppModule.SetForm_ACCOMPANY_SAME_ROOM(TBL_DR.ACCOMPANY_SAME_ROOM, Me.ACCOMPANY_SAME_ROOM)
    '    AppModule.SetForm_ACCOMPANY_ADULT_SU(TBL_DR.ACCOMPANY_ADULT_SU, Me.ACCOMPANY_ADULT_SU)
    '    AppModule.SetForm_ACCOMPANY_CHILD_SU(TBL_DR.ACCOMPANY_CHILD_SU, Me.ACCOMPANY_CHILD_SU)
    '    AppModule.SetForm_ACCOMPANY_CHILD_AGE_1(TBL_DR.ACCOMPANY_CHILD_AGE_1, Me.ACCOMPANY_CHILD_AGE_1)
    '    AppModule.SetForm_ACCOMPANY_CHILD_AGE_2(TBL_DR.ACCOMPANY_CHILD_AGE_2, Me.ACCOMPANY_CHILD_AGE_2)
    '    AppModule.SetForm_ACCOMPANY_CHILD_SEX_1_Male(TBL_DR.ACCOMPANY_CHILD_SEX_1, Me.ACCOMPANY_CHILD_SEX_1_Male)
    '    AppModule.SetForm_ACCOMPANY_CHILD_SEX_1_Female(TBL_DR.ACCOMPANY_CHILD_SEX_1, Me.ACCOMPANY_CHILD_SEX_1_Female)
    '    AppModule.SetForm_ACCOMPANY_CHILD_SEX_2_Male(TBL_DR.ACCOMPANY_CHILD_SEX_2, Me.ACCOMPANY_CHILD_SEX_2_Male)
    '    AppModule.SetForm_ACCOMPANY_CHILD_SEX_2_Female(TBL_DR.ACCOMPANY_CHILD_SEX_2, Me.ACCOMPANY_CHILD_SEX_2_Female)
    '    AppModule.SetForm_ACCOMPANY_CHILD_BED_1_Yes(TBL_DR.ACCOMPANY_CHILD_BED_1, Me.ACCOMPANY_CHILD_BED_1_Yes)
    '    AppModule.SetForm_ACCOMPANY_CHILD_BED_1_No(TBL_DR.ACCOMPANY_CHILD_BED_1, Me.ACCOMPANY_CHILD_BED_1_No)
    '    AppModule.SetForm_ACCOMPANY_CHILD_BED_2_Yes(TBL_DR.ACCOMPANY_CHILD_BED_2, Me.ACCOMPANY_CHILD_BED_2_Yes)
    '    AppModule.SetForm_ACCOMPANY_CHILD_BED_2_No(TBL_DR.ACCOMPANY_CHILD_BED_2, Me.ACCOMPANY_CHILD_BED_2_No)
    '    AppModule.SetForm_NOTE_ACCOMPANY(TBL_DR.NOTE_ACCOMPANY, Me.NOTE_ACCOMPANY)
    '    AppModule.SetForm_NOTE_HOTEL(TBL_DR.NOTE_HOTEL, Me.NOTE_HOTEL)
    '    AppModule.SetForm_PARTY_Yes(TBL_DR.PARTY, Me.PARTY_Yes)
    '    AppModule.SetForm_PARTY_No(TBL_DR.PARTY, Me.PARTY_No)
    '    'AppModule.SetForm_BYCAR_Yes(TBL_DR.BYCAR, Me.BYCAR_Yes)
    '    'AppModule.SetForm_BYCAR_No(TBL_DR.BYCAR, Me.BYCAR_No)
    '    AppModule.SetForm_TEHAI_KOTSU_Yes(TBL_DR.TEHAI_KOTSU, Me.TEHAI_KOTSU_Yes)
    '    AppModule.SetForm_TEHAI_KOTSU_No(TBL_DR.TEHAI_KOTSU, Me.TEHAI_KOTSU_No)
    '    AppModule.SetForm_O_KOTSU_KUBUN_1_AIR(TBL_DR.O_KOTSU_KUBUN_1, Me.O_KOTSU_KUBUN_1_AIR)
    '    AppModule.SetForm_O_KOTSU_KUBUN_1_JR(TBL_DR.O_KOTSU_KUBUN_1, Me.O_KOTSU_KUBUN_1_JR)
    '    AppModule.SetForm_O_KOTSU_KUBUN_1_None(TBL_DR.O_KOTSU_KUBUN_1, Me.O_KOTSU_KUBUN_1_None)
    '    AppModule.SetForm_O_DATE_1(TBL_DR.O_DATE_1, Me.O_DATE_1)
    '    AppModule.SetForm_O_BIN_1(TBL_DR.O_BIN_1, Me.O_BIN_1)
    '    AppModule.SetForm_O_AIRPORT1_1(TBL_DR.O_AIRPORT1_1, Me.O_AIRPORT1_1)
    '    AppModule.SetForm_O_AIRPORT2_1(TBL_DR.O_AIRPORT2_1, Me.O_AIRPORT2_1)
    '    AppModule.SetForm_O_EXPRESS1_1(TBL_DR.O_EXPRESS1_1, Me.O_EXPRESS1_1)
    '    AppModule.SetForm_O_EXPRESS2_1(TBL_DR.O_EXPRESS2_1, Me.O_EXPRESS2_1)
    '    AppModule.SetForm_O_LOCAL1_1(TBL_DR.O_LOCAL1_1, Me.O_LOCAL1_1)
    '    AppModule.SetForm_O_LOCAL2_1(TBL_DR.O_LOCAL2_1, Me.O_LOCAL2_1)
    '    AppModule.SetForm_O_TIME1_1(TBL_DR.O_TIME1_1, Me.O_TIME1_1)
    '    AppModule.SetForm_O_TIME2_1(TBL_DR.O_TIME2_1, Me.O_TIME2_1)
    '    AppModule.SetForm_O_SEAT_1(TBL_DR.O_SEAT_1, Me.O_SEAT_1)
    '    AppModule.SetForm_O_KOTSU_KUBUN_2_AIR(TBL_DR.O_KOTSU_KUBUN_2, Me.O_KOTSU_KUBUN_2_AIR)
    '    AppModule.SetForm_O_KOTSU_KUBUN_2_JR(TBL_DR.O_KOTSU_KUBUN_2, Me.O_KOTSU_KUBUN_2_JR)
    '    AppModule.SetForm_O_KOTSU_KUBUN_2_None(TBL_DR.O_KOTSU_KUBUN_2, Me.O_KOTSU_KUBUN_2_None)
    '    AppModule.SetForm_O_DATE_2(TBL_DR.O_DATE_2, Me.O_DATE_2)
    '    AppModule.SetForm_O_BIN_2(TBL_DR.O_BIN_2, Me.O_BIN_2)
    '    AppModule.SetForm_O_AIRPORT1_2(TBL_DR.O_AIRPORT1_2, Me.O_AIRPORT1_2)
    '    AppModule.SetForm_O_AIRPORT2_2(TBL_DR.O_AIRPORT2_2, Me.O_AIRPORT2_2)
    '    AppModule.SetForm_O_EXPRESS1_2(TBL_DR.O_EXPRESS1_2, Me.O_EXPRESS1_2)
    '    AppModule.SetForm_O_EXPRESS2_2(TBL_DR.O_EXPRESS2_2, Me.O_EXPRESS2_2)
    '    AppModule.SetForm_O_LOCAL1_2(TBL_DR.O_LOCAL1_2, Me.O_LOCAL1_2)
    '    AppModule.SetForm_O_LOCAL2_2(TBL_DR.O_LOCAL2_2, Me.O_LOCAL2_2)
    '    AppModule.SetForm_O_TIME1_2(TBL_DR.O_TIME1_2, Me.O_TIME1_2)
    '    AppModule.SetForm_O_TIME2_2(TBL_DR.O_TIME2_2, Me.O_TIME2_2)
    '    AppModule.SetForm_O_SEAT_2(TBL_DR.O_SEAT_2, Me.O_SEAT_2)
    '    AppModule.SetForm_O_KOTSU_KUBUN_3_AIR(TBL_DR.O_KOTSU_KUBUN_3, Me.O_KOTSU_KUBUN_3_AIR)
    '    AppModule.SetForm_O_KOTSU_KUBUN_3_JR(TBL_DR.O_KOTSU_KUBUN_3, Me.O_KOTSU_KUBUN_3_JR)
    '    AppModule.SetForm_O_KOTSU_KUBUN_3_None(TBL_DR.O_KOTSU_KUBUN_3, Me.O_KOTSU_KUBUN_3_None)
    '    AppModule.SetForm_O_DATE_3(TBL_DR.O_DATE_3, Me.O_DATE_3)
    '    AppModule.SetForm_O_BIN_3(TBL_DR.O_BIN_3, Me.O_BIN_3)
    '    AppModule.SetForm_O_AIRPORT1_3(TBL_DR.O_AIRPORT1_3, Me.O_AIRPORT1_3)
    '    AppModule.SetForm_O_AIRPORT2_3(TBL_DR.O_AIRPORT2_3, Me.O_AIRPORT2_3)
    '    AppModule.SetForm_O_EXPRESS1_3(TBL_DR.O_EXPRESS1_3, Me.O_EXPRESS1_3)
    '    AppModule.SetForm_O_EXPRESS2_3(TBL_DR.O_EXPRESS2_3, Me.O_EXPRESS2_3)
    '    AppModule.SetForm_O_LOCAL1_3(TBL_DR.O_LOCAL1_3, Me.O_LOCAL1_3)
    '    AppModule.SetForm_O_LOCAL2_3(TBL_DR.O_LOCAL2_3, Me.O_LOCAL2_3)
    '    AppModule.SetForm_O_TIME1_3(TBL_DR.O_TIME1_3, Me.O_TIME1_3)
    '    AppModule.SetForm_O_TIME2_3(TBL_DR.O_TIME2_3, Me.O_TIME2_3)
    '    AppModule.SetForm_O_SEAT_3(TBL_DR.O_SEAT_3, Me.O_SEAT_3)
    '    AppModule.SetForm_F_KOTSU_KUBUN_1_AIR(TBL_DR.F_KOTSU_KUBUN_1, Me.F_KOTSU_KUBUN_1_AIR)
    '    AppModule.SetForm_F_KOTSU_KUBUN_1_JR(TBL_DR.F_KOTSU_KUBUN_1, Me.F_KOTSU_KUBUN_1_JR)
    '    AppModule.SetForm_F_KOTSU_KUBUN_1_None(TBL_DR.F_KOTSU_KUBUN_1, Me.F_KOTSU_KUBUN_1_None)
    '    AppModule.SetForm_F_DATE_1(TBL_DR.F_DATE_1, Me.F_DATE_1)
    '    AppModule.SetForm_F_BIN_1(TBL_DR.F_BIN_1, Me.F_BIN_1)
    '    AppModule.SetForm_F_AIRPORT1_1(TBL_DR.F_AIRPORT1_1, Me.F_AIRPORT1_1)
    '    AppModule.SetForm_F_AIRPORT2_1(TBL_DR.F_AIRPORT2_1, Me.F_AIRPORT2_1)
    '    AppModule.SetForm_F_EXPRESS1_1(TBL_DR.F_EXPRESS1_1, Me.F_EXPRESS1_1)
    '    AppModule.SetForm_F_EXPRESS2_1(TBL_DR.F_EXPRESS2_1, Me.F_EXPRESS2_1)
    '    AppModule.SetForm_F_LOCAL1_1(TBL_DR.F_LOCAL1_1, Me.F_LOCAL1_1)
    '    AppModule.SetForm_F_LOCAL2_1(TBL_DR.F_LOCAL2_1, Me.F_LOCAL2_1)
    '    AppModule.SetForm_F_TIME1_1(TBL_DR.F_TIME1_1, Me.F_TIME1_1)
    '    AppModule.SetForm_F_TIME2_1(TBL_DR.F_TIME2_1, Me.F_TIME2_1)
    '    AppModule.SetForm_F_SEAT_1(TBL_DR.F_SEAT_1, Me.F_SEAT_1)
    '    AppModule.SetForm_F_KOTSU_KUBUN_2_AIR(TBL_DR.F_KOTSU_KUBUN_2, Me.F_KOTSU_KUBUN_2_AIR)
    '    AppModule.SetForm_F_KOTSU_KUBUN_2_JR(TBL_DR.F_KOTSU_KUBUN_2, Me.F_KOTSU_KUBUN_2_JR)
    '    AppModule.SetForm_F_KOTSU_KUBUN_2_None(TBL_DR.F_KOTSU_KUBUN_2, Me.F_KOTSU_KUBUN_2_None)
    '    AppModule.SetForm_F_DATE_2(TBL_DR.F_DATE_2, Me.F_DATE_2)
    '    AppModule.SetForm_F_BIN_2(TBL_DR.F_BIN_2, Me.F_BIN_2)
    '    AppModule.SetForm_F_AIRPORT1_2(TBL_DR.F_AIRPORT1_2, Me.F_AIRPORT1_2)
    '    AppModule.SetForm_F_AIRPORT2_2(TBL_DR.F_AIRPORT2_2, Me.F_AIRPORT2_2)
    '    AppModule.SetForm_F_EXPRESS1_2(TBL_DR.F_EXPRESS1_2, Me.F_EXPRESS1_2)
    '    AppModule.SetForm_F_EXPRESS2_2(TBL_DR.F_EXPRESS2_2, Me.F_EXPRESS2_2)
    '    AppModule.SetForm_F_LOCAL1_2(TBL_DR.F_LOCAL1_2, Me.F_LOCAL1_2)
    '    AppModule.SetForm_F_LOCAL2_2(TBL_DR.F_LOCAL2_2, Me.F_LOCAL2_2)
    '    AppModule.SetForm_F_TIME1_2(TBL_DR.F_TIME1_2, Me.F_TIME1_2)
    '    AppModule.SetForm_F_TIME2_2(TBL_DR.F_TIME2_2, Me.F_TIME2_2)
    '    AppModule.SetForm_F_SEAT_2(TBL_DR.F_SEAT_2, Me.F_SEAT_2)
    '    AppModule.SetForm_F_KOTSU_KUBUN_3_AIR(TBL_DR.F_KOTSU_KUBUN_3, Me.F_KOTSU_KUBUN_3_AIR)
    '    AppModule.SetForm_F_KOTSU_KUBUN_3_JR(TBL_DR.F_KOTSU_KUBUN_3, Me.F_KOTSU_KUBUN_3_JR)
    '    AppModule.SetForm_F_KOTSU_KUBUN_3_None(TBL_DR.F_KOTSU_KUBUN_3, Me.F_KOTSU_KUBUN_3_None)
    '    AppModule.SetForm_F_DATE_3(TBL_DR.F_DATE_3, Me.F_DATE_3)
    '    AppModule.SetForm_F_BIN_3(TBL_DR.F_BIN_3, Me.F_BIN_3)
    '    AppModule.SetForm_F_AIRPORT1_3(TBL_DR.F_AIRPORT1_3, Me.F_AIRPORT1_3)
    '    AppModule.SetForm_F_AIRPORT2_3(TBL_DR.F_AIRPORT2_3, Me.F_AIRPORT2_3)
    '    AppModule.SetForm_F_EXPRESS1_3(TBL_DR.F_EXPRESS1_3, Me.F_EXPRESS1_3)
    '    AppModule.SetForm_F_EXPRESS2_3(TBL_DR.F_EXPRESS2_3, Me.F_EXPRESS2_3)
    '    AppModule.SetForm_F_LOCAL1_3(TBL_DR.F_LOCAL1_3, Me.F_LOCAL1_3)
    '    AppModule.SetForm_F_LOCAL2_3(TBL_DR.F_LOCAL2_3, Me.F_LOCAL2_3)
    '    AppModule.SetForm_F_TIME1_3(TBL_DR.F_TIME1_3, Me.F_TIME1_3)
    '    AppModule.SetForm_F_TIME2_3(TBL_DR.F_TIME2_3, Me.F_TIME2_3)
    '    AppModule.SetForm_F_SEAT_3(TBL_DR.F_SEAT_3, Me.F_SEAT_3)
    '    AppModule.SetForm_AIRLINE_ANA(TBL_DR.AIRLINE, Me.AIRLINE_ANA)
    '    AppModule.SetForm_AIRLINE_JAL(TBL_DR.AIRLINE, Me.AIRLINE_JAL)
    '    AppModule.SetForm_MILAGE_NO(TBL_DR.MILAGE_NO, Me.MILAGE_NO)
    '    AppModule.SetForm_NOTE_KOTSU(TBL_DR.NOTE_KOTSU, Me.NOTE_KOTSU)
    '    AppModule.SetForm_PAYMENT_METHOD_Card(TBL_DR.PAYMENT_METHOD, Me.PAYMENT_METHOD_Card)
    '    AppModule.SetForm_PAYMENT_METHOD_Bank(TBL_DR.PAYMENT_METHOD, Me.PAYMENT_METHOD_Bank)
    '    AppModule.SetForm_NOTES(TBL_DR.NOTES, Me.NOTES)
    '    AppModule.SetForm_SEND_SAKI(TBL_DR.SEND_SAKI, Me.SEND_SAKI)
    '    AppModule.SetForm_SEND_ZIP(TBL_DR.SEND_ZIP, Me.SEND_ZIP_1, Me.SEND_ZIP_2)
    '    AppModule.SetForm_SEND_ADDRESS(TBL_DR.SEND_ADDRESS, Me.SEND_ADDRESS)
    '    AppModule.SetForm_SEND_NAME(TBL_DR.SEND_NAME, Me.SEND_NAME)
    '    AppModule.SetForm_SEND_TEL(TBL_DR.SEND_TEL, Me.SEND_TEL_1, Me.SEND_TEL_2, Me.SEND_TEL_3)
    '    'AppModule.SetForm_ROOM_TYPE(TBL_DR.ROOM_TYPE, Me.ROOM_TYPE)

    '    '表示/非表示
    '    SetHOTEL()
    '    SetACCOMPANY_CHILD_BED()
    '    SetKOTSU()
    '    SetMILAGE_NO()

    '    If Not CmnCheck.IsInput(Me.SEND_SAKI) Then
    '        Me.TrSEND_SAKI_1.Visible = False
    '        Me.TrSEND_SAKI_2.Visible = False
    '        Me.TrSEND_SAKI_3.Visible = False
    '    Else
    '        Me.TrSEND_SAKI_1.Visible = True
    '        Me.TrSEND_SAKI_2.Visible = True
    '        Me.TrSEND_SAKI_3.Visible = True
    '    End If

    '    'トップツアーのみ
    '    If Session.Item(SessionDef.UserType) = AppConst.UserType.Admin Then
    '        Me.TrSANKA_KUBUN.Visible = True
    '        AppModule.SetForm_SANKA_KUBUN_Listener(TBL_DR.SANKA_KUBUN, Me.SANKA_KUBUN_Listener)
    '        AppModule.SetForm_SANKA_KUBUN_Speaker(TBL_DR.SANKA_KUBUN, Me.SANKA_KUBUN_Speaker)

    '        Me.TrPAYMENT_METHOD.Visible = True
    '        AppModule.SetForm_PAYMENT_METHOD_Card(TBL_DR.PAYMENT_METHOD, Me.PAYMENT_METHOD_Card)
    '        AppModule.SetForm_PAYMENT_METHOD_Bank(TBL_DR.PAYMENT_METHOD, Me.PAYMENT_METHOD_Bank)
    '        If Trim(TBL_DR.PAYMENT_DATE_CARD) <> "" OrElse Trim(TBL_DR.PAYMENT_DATE_BANK) <> "" Then
    '            CmnModule.SetEnabled(Me.PAYMENT_METHOD_Card, False)
    '            CmnModule.SetEnabled(Me.PAYMENT_METHOD_Bank, False)
    '        Else
    '            CmnModule.SetEnabled(Me.PAYMENT_METHOD_Card, True)
    '            CmnModule.SetEnabled(Me.PAYMENT_METHOD_Bank, True)
    '        End If

    '        If Me.TEHAI_KOTSU_Yes.Checked = True Then
    '            Me.TblO_SEATCLASS_1.Visible = True
    '            Me.TblO_SEATCLASS_2.Visible = True
    '            Me.TblO_SEATCLASS_3.Visible = True
    '            Me.TblF_SEATCLASS_1.Visible = True
    '            Me.TblF_SEATCLASS_2.Visible = True
    '            Me.TblF_SEATCLASS_3.Visible = True
    '            AppModule.SetForm_O_SEATCLASS_1(TBL_DR.O_SEATCLASS_1, Me.O_SEATCLASS_1)
    '            AppModule.SetForm_O_SEATCLASS_2(TBL_DR.O_SEATCLASS_2, Me.O_SEATCLASS_2)
    '            AppModule.SetForm_O_SEATCLASS_3(TBL_DR.O_SEATCLASS_3, Me.O_SEATCLASS_3)
    '            AppModule.SetForm_F_SEATCLASS_1(TBL_DR.F_SEATCLASS_1, Me.F_SEATCLASS_1)
    '            AppModule.SetForm_F_SEATCLASS_2(TBL_DR.F_SEATCLASS_2, Me.F_SEATCLASS_2)
    '            AppModule.SetForm_F_SEATCLASS_3(TBL_DR.F_SEATCLASS_3, Me.F_SEATCLASS_3)
    '        Else
    '            Me.TblO_SEATCLASS_1.Visible = False
    '            Me.TblO_SEATCLASS_2.Visible = False
    '            Me.TblO_SEATCLASS_3.Visible = False
    '            Me.TblF_SEATCLASS_1.Visible = False
    '            Me.TblF_SEATCLASS_2.Visible = False
    '            Me.TblF_SEATCLASS_3.Visible = False
    '        End If
    '    Else
    '        Me.TrSANKA_KUBUN.Visible = False
    '        Me.TrPAYMENT_METHOD.Visible = False
    '        Me.TblO_SEATCLASS_1.Visible = False
    '        Me.TblO_SEATCLASS_2.Visible = False
    '        Me.TblO_SEATCLASS_3.Visible = False
    '        Me.TblF_SEATCLASS_1.Visible = False
    '        Me.TblF_SEATCLASS_2.Visible = False
    '        Me.TblF_SEATCLASS_3.Visible = False
    '    End If
    'End Sub

    '入力値チェック
    Public Function Check() As Boolean
        Dim wStr As String

        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If

        'If Not CmnCheck.IsInput(Me.DR_NAME_FIRST) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.DR_NAME_FIRST), Me.Parent.Page)
        '    Return False
        'End If

        'If Not CmnCheck.IsInput(Me.DR_NAME_LAST) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.DR_NAME_LAST), Me.Parent.Page)
        '    Return False
        'End If

        'If Not CmnCheck.IsInput(Me.DR_NAME_KANA_FIRST) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.DR_NAME_KANA_FIRST), Me.Parent.Page)
        '    Return False
        'End If
        'wStr = AppModule.GetValue_DR_NAME_KANA_FIRST(Me.DR_NAME_KANA_FIRST)
        ''全角カナのみ可
        'If Not CmnCheck.IsZenKatakana(wStr) Then
        '    CmnModule.AlertMessage(MessageDef.Error.KatakanaOnly(TableDef.TBL_DR.Name.DR_NAME_KANA_FIRST), Me.Parent.Page)
        '    Return False
        'End If

        'If Not CmnCheck.IsInput(Me.DR_NAME_KANA_LAST) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.DR_NAME_KANA_LAST), Me.Parent.Page)
        '    Return False
        'End If
        'wStr = AppModule.GetValue_DR_NAME_KANA_LAST(Me.DR_NAME_KANA_LAST)
        ''全角カナのみ可
        'If Not CmnCheck.IsZenKatakana(wStr) Then
        '    CmnModule.AlertMessage(MessageDef.Error.KatakanaOnly(TableDef.TBL_DR.Name.DR_NAME_KANA_LAST), Me.Parent.Page)
        '    Return False
        'End If

        'If Not CmnCheck.IsInput(Me.SEX_Male, Me.SEX_Female) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.SEX), Me.Parent.Page)
        '    Return False
        'End If

        'If Not CmnCheck.IsInput(Me.PREFECTURES_NO) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.PREFECTURES_NO), Me.Parent.Page)
        '    Return False
        'End If

        'If Not CmnCheck.IsInput(Me.SHISETSU_NAME) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.SHISETSU_NAME), Me.Parent.Page)
        '    Return False
        'End If

        'If Not CmnCheck.IsInput(Me.SHISETSU_NAME_KANA) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.SHISETSU_NAME_KANA), Me.Parent.Page)
        '    Return False
        'End If
        'wStr = AppModule.GetValue_SHISETSU_NAME_KANA(Me.SHISETSU_NAME_KANA)
        ''全角カナのみ可
        'If Not CmnCheck.IsZenKatakana(wStr) Then
        '    CmnModule.AlertMessage(MessageDef.Error.KatakanaOnly(TableDef.TBL_DR.Name.SHISETSU_NAME_KANA), Me.Parent.Page)
        '    Return False
        'End If

        'If Not CmnCheck.IsInput(Me.KAMOKU) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.KAMOKU), Me.Parent.Page)
        '    Return False
        'End If

        'If Not CmnCheck.IsInput(Me.AGE) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.AGE), Me.Parent.Page)
        '    Return False
        'Else
        '    If Not CmnCheck.IsNumberOnly(Me.AGE) Then
        '        CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_DR.Name.AGE), Me.Parent.Page)
        '        Return False
        '    End If
        'End If

        ''公務員
        'If Not CmnCheck.IsInput(Me.PUBLIC_SERVANT_Yes, Me.PUBLIC_SERVANT_No) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.PUBLIC_SERVANT), Me.Parent.Page)
        '    Return False
        'End If

        ''二次使用
        'If Not CmnCheck.IsInput(Me.SECANDARY_USE_Yes, Me.SECANDARY_USE_No) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.SECANDARY_USE), Me.Parent.Page)
        '    Return False
        'End If

        ''宿泊手配
        'If Not CmnCheck.IsInput(Me.TEHAI_HOTEL_Yes, Me.TEHAI_HOTEL_No) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.TEHAI_HOTEL), Me.Parent.Page)
        '    Return False
        'ElseIf CmnCheck.IsInput(Me.TEHAI_HOTEL_Yes) Then
        '    If Not CmnCheck.IsInput(Me.ACCOMPANY_FLAG_Yes, Me.ACCOMPANY_FLAG_No) Then
        '        CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.ACCOMPANY_FLAG), Me.Parent.Page)
        '        Return False
        '    ElseIf CmnCheck.IsInput(Me.ACCOMPANY_FLAG_Yes) Then
        '        If Not CmnCheck.IsInput(Me.ACCOMPANY_STAY_Yes, Me.ACCOMPANY_STAY_No) Then
        '            CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.ACCOMPANY_STAY), Me.Parent.Page)
        '            Return False
        '        ElseIf CmnCheck.IsInput(Me.ACCOMPANY_STAY_Yes) Then
        '            If Me.ACCOMPANY_SAME_ROOM.Checked = True Then
        '                Dim wSAME_ROOM As String = AppModule.GetValue_ACCOMPANY_SAME_ROOM(Me.ACCOMPANY_STAY_Yes, Me.ACCOMPANY_SAME_ROOM)

        '                '大人または小人必須
        '                If Not CmnCheck.IsInput(Me.ACCOMPANY_ADULT_SU) AndAlso Not CmnCheck.IsInput(Me.ACCOMPANY_CHILD_SU) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustSelect("同室者人数"), Me.Parent.Page)
        '                    Return False
        '                End If

        '                '小人の場合、年齢 ベッド必須
        '                If CmnModule.GetSelectedItemValue(Me.ACCOMPANY_CHILD_SU) = "1" OrElse CmnModule.GetSelectedItemValue(Me.ACCOMPANY_CHILD_SU) = "2" Then
        '                    If Not CmnCheck.IsInput(Me.ACCOMPANY_CHILD_BED_1_Yes, Me.ACCOMPANY_CHILD_BED_1_No) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.ACCOMPANY_CHILD_BED_1), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.ACCOMPANY_CHILD_AGE_1) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.ACCOMPANY_CHILD_AGE_1), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    wStr = AppModule.GetValue_ACCOMPANY_CHILD_AGE_1(wSAME_ROOM, "1", Me.ACCOMPANY_CHILD_AGE_1)
        '                    If Not CmnCheck.IsNumberOnly(wStr) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_DR.Name.ACCOMPANY_CHILD_AGE_1), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '                If CmnModule.GetSelectedItemValue(Me.ACCOMPANY_CHILD_SU) = "2" Then
        '                    If Not CmnCheck.IsInput(Me.ACCOMPANY_CHILD_BED_2_Yes, Me.ACCOMPANY_CHILD_BED_2_No) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.ACCOMPANY_CHILD_BED_2), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.ACCOMPANY_CHILD_AGE_2) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.ACCOMPANY_CHILD_AGE_2), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    wStr = AppModule.GetValue_ACCOMPANY_CHILD_AGE_2(wSAME_ROOM, "2", Me.ACCOMPANY_CHILD_AGE_2)
        '                    If Not CmnCheck.IsNumberOnly(wStr) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.NumberOnly(TableDef.TBL_DR.Name.ACCOMPANY_CHILD_AGE_2), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '            End If
        '        End If
        '        If Not CmnCheck.IsLengthLE(Me.NOTE_ACCOMPANY.Text, 500) Then
        '            CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_DR.Name.NOTE_ACCOMPANY, 500, True), Me.Parent.Page)
        '            Return False
        '        End If
        '    End If

        '    If Not CmnCheck.IsLengthLE(Me.NOTE_HOTEL.Text, 500) Then
        '        CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_DR.Name.NOTE_HOTEL, 500, True), Me.Parent.Page)
        '        Return False
        '    End If
        'End If

        'If Not CmnCheck.IsInput(Me.PARTY_Yes, Me.PARTY_No) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.PARTY), Me.Parent.Page)
        '    Return False
        'End If

        ''公共交通手配
        'If Not CmnCheck.IsInput(Me.TEHAI_KOTSU_Yes, Me.TEHAI_KOTSU_No) Then
        '    CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.TEHAI_KOTSU), Me.Parent.Page)
        '    Return False
        'ElseIf CmnCheck.IsInput(Me.TEHAI_KOTSU_Yes) Then
        '    If Not CmnCheck.IsInput(Me.O_KOTSU_KUBUN_1_AIR, Me.O_KOTSU_KUBUN_1_JR) AndAlso _
        '       Not CmnCheck.IsInput(Me.O_KOTSU_KUBUN_2_AIR, Me.O_KOTSU_KUBUN_2_JR) AndAlso _
        '       Not CmnCheck.IsInput(Me.O_KOTSU_KUBUN_3_AIR, Me.O_KOTSU_KUBUN_3_JR) AndAlso _
        '       Not CmnCheck.IsInput(Me.F_KOTSU_KUBUN_1_AIR, Me.F_KOTSU_KUBUN_1_JR) AndAlso _
        '       Not CmnCheck.IsInput(Me.F_KOTSU_KUBUN_2_AIR, Me.F_KOTSU_KUBUN_2_JR) AndAlso _
        '       Not CmnCheck.IsInput(Me.F_KOTSU_KUBUN_3_AIR, Me.F_KOTSU_KUBUN_3_JR) Then
        '        CmnModule.AlertMessage(MessageDef.Error.MustInput_Kotsu, Me.Parent.Page)
        '        Return False
        '    End If

        '    Dim wO_FLAG As Boolean = False  '往路あり→True
        '    Dim wF_FLAG As Boolean = False  '復路あり→True

        '    If CmnCheck.IsInput(Me.O_KOTSU_KUBUN_1_AIR) OrElse _
        '       CmnCheck.IsInput(Me.O_KOTSU_KUBUN_1_JR) OrElse _
        '       CmnCheck.IsInput(Me.O_DATE_1) OrElse _
        '       CmnCheck.IsInput(Me.O_AIRPORT1_1) OrElse _
        '       CmnCheck.IsInput(Me.O_AIRPORT2_1) OrElse _
        '       CmnCheck.IsInput(Me.O_EXPRESS1_1) OrElse _
        '       CmnCheck.IsInput(Me.O_EXPRESS2_1) OrElse _
        '       CmnCheck.IsInput(Me.O_LOCAL1_1) OrElse _
        '       CmnCheck.IsInput(Me.O_LOCAL2_1) OrElse _
        '       CmnCheck.IsInput(Me.O_TIME1_1) OrElse _
        '       CmnCheck.IsInput(Me.O_TIME2_1) OrElse _
        '       CmnCheck.IsInput(Me.O_BIN_1) OrElse _
        '       CmnCheck.IsInput(Me.O_SEAT_1) Then
        '        wO_FLAG = True
        '    End If

        '    If CmnCheck.IsInput(Me.F_KOTSU_KUBUN_1_AIR) OrElse _
        '       CmnCheck.IsInput(Me.F_KOTSU_KUBUN_1_JR) OrElse _
        '       CmnCheck.IsInput(Me.F_DATE_1) OrElse _
        '       CmnCheck.IsInput(Me.F_AIRPORT1_1) OrElse _
        '       CmnCheck.IsInput(Me.F_AIRPORT2_1) OrElse _
        '       CmnCheck.IsInput(Me.F_EXPRESS1_1) OrElse _
        '       CmnCheck.IsInput(Me.F_EXPRESS2_1) OrElse _
        '       CmnCheck.IsInput(Me.F_LOCAL1_1) OrElse _
        '       CmnCheck.IsInput(Me.F_LOCAL2_1) OrElse _
        '       CmnCheck.IsInput(Me.F_TIME1_1) OrElse _
        '       CmnCheck.IsInput(Me.F_TIME2_1) OrElse _
        '       CmnCheck.IsInput(Me.F_BIN_1) OrElse _
        '       CmnCheck.IsInput(Me.F_SEAT_1) Then
        '        wF_FLAG = True
        '    End If

        '    If wO_FLAG = False AndAlso wF_FLAG = False Then
        '        CmnModule.AlertMessage(MessageDef.Error.MustInput_Kotsu, Me.Parent.Page)
        '        Return False
        '    Else
        '        If CmnCheck.IsInput(Me.O_KOTSU_KUBUN_1_AIR) OrElse CmnCheck.IsInput(Me.O_KOTSU_KUBUN_1_JR) Then
        '            If Not CmnCheck.IsInput(Me.O_DATE_1) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.O_DATE_1), Me.Parent.Page)
        '                Return False
        '            End If
        '            If Not CmnCheck.IsInput(Me.O_BIN_1) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.O_BIN_1), Me.Parent.Page)
        '                Return False
        '            End If
        '            If Me.O_KOTSU_KUBUN_1_AIR.Checked = True Then
        '                If Not CmnCheck.IsInput(Me.O_AIRPORT1_1) AndAlso _
        '                   Not CmnCheck.IsInput(Me.O_AIRPORT2_1) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustInput("往路1:区間"), Me.Parent.Page)
        '                    Return False
        '                End If
        '                If CmnCheck.IsInput(Me.O_AIRPORT1_1) OrElse CmnCheck.IsInput(Me.O_AIRPORT2_1) Then
        '                    If Not CmnCheck.IsInput(Me.O_AIRPORT1_1) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路1:区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.O_AIRPORT2_1) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路1:区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '            End If
        '            If Me.O_KOTSU_KUBUN_1_JR.Checked = True Then
        '                If Not CmnCheck.IsInput(Me.O_EXPRESS1_1) AndAlso _
        '                   Not CmnCheck.IsInput(Me.O_EXPRESS2_1) AndAlso _
        '                   Not CmnCheck.IsInput(Me.O_LOCAL1_1) AndAlso _
        '                   Not CmnCheck.IsInput(Me.O_LOCAL2_1) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustInput("往路1:新幹線・特急区間または乗車券区間"), Me.Parent.Page)
        '                    Return False
        '                End If
        '                If CmnCheck.IsInput(Me.O_EXPRESS1_1) OrElse CmnCheck.IsInput(Me.O_EXPRESS2_1) Then
        '                    If Not CmnCheck.IsInput(Me.O_EXPRESS1_1) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路1:新幹線・特急区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.O_EXPRESS2_1) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路1:新幹線・特急区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '                If CmnCheck.IsInput(Me.O_LOCAL1_1) OrElse CmnCheck.IsInput(Me.O_LOCAL2_1) Then
        '                    If Not CmnCheck.IsInput(Me.O_LOCAL1_1) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路1:乗車券区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.O_LOCAL2_1) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路1:乗車券区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '                If Not CmnCheck.IsInput(Me.O_EXPRESS1_1, Me.O_EXPRESS2_1) AndAlso CmnCheck.IsInput(Me.O_LOCAL1_1, Me.O_LOCAL2_1) Then
        '                    If CmnCheck.IsInput(Me.O_SEAT_1) Then
        '                        CmnModule.AlertMessage("往路1:乗車券のみお申し込みの場合は、座席希望は選択できません。", Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '            End If
        '            If Not CmnCheck.IsInput(Me.O_TIME1_1) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.O_TIME1_1), Me.Parent.Page)
        '                Return False
        '            Else
        '                wStr = AppModule.GetValue_O_TIME1_1(Me.O_TIME1_1)
        '                If Not CmnCheck.IsNumberOnly(wStr) OrElse Not CmnCheck.IsLengthEQ(Me.O_TIME1_1, Me.O_TIME1_1.MaxLength) Then
        '                    CmnModule.AlertMessage("往路1:" & MessageDef.Error.InvalidTime, Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '            If Not CmnCheck.IsInput(Me.O_TIME2_1) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.O_TIME2_1), Me.Parent.Page)
        '                Return False
        '            Else
        '                wStr = AppModule.GetValue_O_TIME2_1(Me.O_TIME2_1)
        '                If Not CmnCheck.IsNumberOnly(wStr) OrElse Not CmnCheck.IsLengthEQ(Me.O_TIME2_1, Me.O_TIME2_1.MaxLength) Then
        '                    CmnModule.AlertMessage("往路1:" & MessageDef.Error.InvalidTime, Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '            If Me.O_SEAT_1.Enabled = True Then
        '                If Not CmnCheck.IsInput(Me.O_SEAT_1) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.O_SEAT_1), Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '        End If
        '        If CmnCheck.IsInput(Me.F_KOTSU_KUBUN_1_AIR) OrElse CmnCheck.IsInput(Me.F_KOTSU_KUBUN_1_JR) Then
        '            If Not CmnCheck.IsInput(Me.F_DATE_1) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.F_DATE_1), Me.Parent.Page)
        '                Return False
        '            End If
        '            If Not CmnCheck.IsInput(Me.F_BIN_1) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.F_BIN_1), Me.Parent.Page)
        '                Return False
        '            End If
        '            If Me.F_KOTSU_KUBUN_1_AIR.Checked = True Then
        '                If Not CmnCheck.IsInput(Me.F_AIRPORT1_1) AndAlso _
        '                   Not CmnCheck.IsInput(Me.F_AIRPORT2_1) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustInput("復路1:区間"), Me.Parent.Page)
        '                    Return False
        '                End If
        '                If CmnCheck.IsInput(Me.F_AIRPORT1_1) OrElse CmnCheck.IsInput(Me.F_AIRPORT2_1) Then
        '                    If Not CmnCheck.IsInput(Me.F_AIRPORT1_1) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路1:区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.F_AIRPORT2_1) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路1:区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '            End If
        '            If Me.F_KOTSU_KUBUN_1_JR.Checked = True Then
        '                If Not CmnCheck.IsInput(Me.F_EXPRESS1_1) AndAlso _
        '                   Not CmnCheck.IsInput(Me.F_EXPRESS2_1) AndAlso _
        '                   Not CmnCheck.IsInput(Me.F_LOCAL1_1) AndAlso _
        '                   Not CmnCheck.IsInput(Me.F_LOCAL2_1) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustInput("復路1:新幹線・特急区間または乗車券区間"), Me.Parent.Page)
        '                    Return False
        '                End If
        '                If CmnCheck.IsInput(Me.F_EXPRESS1_1) OrElse CmnCheck.IsInput(Me.F_EXPRESS2_1) Then
        '                    If Not CmnCheck.IsInput(Me.F_EXPRESS1_1) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路1:新幹線・特急区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.F_EXPRESS2_1) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路1:新幹線・特急区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '                If CmnCheck.IsInput(Me.F_LOCAL1_1) OrElse CmnCheck.IsInput(Me.F_LOCAL2_1) Then
        '                    If Not CmnCheck.IsInput(Me.F_LOCAL1_1) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路1:乗車券区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.F_LOCAL2_1) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路1:乗車券区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '                If Not CmnCheck.IsInput(Me.F_EXPRESS1_1, Me.F_EXPRESS2_1) AndAlso CmnCheck.IsInput(Me.F_LOCAL1_1, Me.F_LOCAL2_1) Then
        '                    If CmnCheck.IsInput(Me.F_SEAT_1) Then
        '                        CmnModule.AlertMessage("復路1:乗車券のみお申し込みの場合は、座席希望は選択できません。", Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '            End If
        '            If Not CmnCheck.IsInput(Me.F_TIME1_1) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.F_TIME1_1), Me.Parent.Page)
        '                Return False
        '            Else
        '                wStr = AppModule.GetValue_F_TIME1_1(Me.F_TIME1_1)
        '                If Not CmnCheck.IsNumberOnly(wStr) OrElse Not CmnCheck.IsLengthEQ(Me.F_TIME1_1, Me.F_TIME1_1.MaxLength) Then
        '                    CmnModule.AlertMessage("復路1:" & MessageDef.Error.InvalidTime, Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '            If Not CmnCheck.IsInput(Me.F_TIME2_1) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.F_TIME2_1), Me.Parent.Page)
        '                Return False
        '            Else
        '                wStr = AppModule.GetValue_F_TIME2_1(Me.F_TIME2_1)
        '                If Not CmnCheck.IsNumberOnly(wStr) OrElse Not CmnCheck.IsLengthEQ(Me.F_TIME2_1, Me.F_TIME2_1.MaxLength) Then
        '                    CmnModule.AlertMessage("復路1:" & MessageDef.Error.InvalidTime, Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '            If Me.F_SEAT_1.Enabled = True Then
        '                If Not CmnCheck.IsInput(Me.F_SEAT_1) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.F_SEAT_1), Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '        End If
        '    End If

        '    wO_FLAG = False
        '    wF_FLAG = False
        '    If CmnCheck.IsInput(Me.O_KOTSU_KUBUN_2_AIR) OrElse _
        '       CmnCheck.IsInput(Me.O_KOTSU_KUBUN_2_JR) OrElse _
        '       CmnCheck.IsInput(Me.O_DATE_2) OrElse _
        '       CmnCheck.IsInput(Me.O_AIRPORT1_2) OrElse _
        '       CmnCheck.IsInput(Me.O_AIRPORT2_2) OrElse _
        '       CmnCheck.IsInput(Me.O_EXPRESS1_2) OrElse _
        '       CmnCheck.IsInput(Me.O_EXPRESS2_2) OrElse _
        '       CmnCheck.IsInput(Me.O_LOCAL1_2) OrElse _
        '       CmnCheck.IsInput(Me.O_LOCAL2_2) OrElse _
        '       CmnCheck.IsInput(Me.O_TIME1_2) OrElse _
        '       CmnCheck.IsInput(Me.O_TIME2_2) OrElse _
        '       CmnCheck.IsInput(Me.O_BIN_2) OrElse _
        '       CmnCheck.IsInput(Me.O_SEAT_2) Then
        '        wO_FLAG = True
        '    End If

        '    If CmnCheck.IsInput(Me.F_KOTSU_KUBUN_2_AIR) OrElse _
        '       CmnCheck.IsInput(Me.F_KOTSU_KUBUN_2_JR) OrElse _
        '       CmnCheck.IsInput(Me.F_DATE_2) OrElse _
        '       CmnCheck.IsInput(Me.F_AIRPORT1_2) OrElse _
        '       CmnCheck.IsInput(Me.F_AIRPORT2_2) OrElse _
        '       CmnCheck.IsInput(Me.F_EXPRESS1_2) OrElse _
        '       CmnCheck.IsInput(Me.F_EXPRESS2_2) OrElse _
        '       CmnCheck.IsInput(Me.F_LOCAL1_2) OrElse _
        '       CmnCheck.IsInput(Me.F_LOCAL2_2) OrElse _
        '       CmnCheck.IsInput(Me.F_TIME1_2) OrElse _
        '       CmnCheck.IsInput(Me.F_TIME2_2) OrElse _
        '       CmnCheck.IsInput(Me.F_BIN_2) OrElse _
        '       CmnCheck.IsInput(Me.F_SEAT_2) Then
        '        wF_FLAG = True
        '    End If

        '    If wO_FLAG = True Then
        '        If CmnCheck.IsInput(Me.O_KOTSU_KUBUN_2_AIR) OrElse CmnCheck.IsInput(Me.O_KOTSU_KUBUN_2_JR) Then
        '            If Not CmnCheck.IsInput(Me.O_DATE_2) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.O_DATE_2), Me.Parent.Page)
        '                Return False
        '            End If
        '            If Not CmnCheck.IsInput(Me.O_BIN_2) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.O_BIN_2), Me.Parent.Page)
        '                Return False
        '            End If
        '            If Me.O_KOTSU_KUBUN_2_AIR.Checked = True Then
        '                If Not CmnCheck.IsInput(Me.O_AIRPORT1_2) AndAlso _
        '                   Not CmnCheck.IsInput(Me.O_AIRPORT2_2) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustInput("往路2:区間"), Me.Parent.Page)
        '                    Return False
        '                End If
        '                If CmnCheck.IsInput(Me.O_AIRPORT1_2) OrElse CmnCheck.IsInput(Me.O_AIRPORT2_2) Then
        '                    If Not CmnCheck.IsInput(Me.O_AIRPORT1_2) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路2:区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.O_AIRPORT2_2) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路2:区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '            End If
        '            If Me.O_KOTSU_KUBUN_2_JR.Checked = True Then
        '                If Not CmnCheck.IsInput(Me.O_EXPRESS1_2) AndAlso _
        '                   Not CmnCheck.IsInput(Me.O_EXPRESS2_2) AndAlso _
        '                   Not CmnCheck.IsInput(Me.O_LOCAL1_2) AndAlso _
        '                   Not CmnCheck.IsInput(Me.O_LOCAL2_2) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustInput("往路2:新幹線・特急区間または乗車券区間"), Me.Parent.Page)
        '                    Return False
        '                End If
        '                If CmnCheck.IsInput(Me.O_EXPRESS1_2) OrElse CmnCheck.IsInput(Me.O_EXPRESS2_2) Then
        '                    If Not CmnCheck.IsInput(Me.O_EXPRESS1_2) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路2:新幹線・特急区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.O_EXPRESS2_2) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路2:新幹線・特急区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '                If CmnCheck.IsInput(Me.O_LOCAL1_2) OrElse CmnCheck.IsInput(Me.O_LOCAL2_2) Then
        '                    If Not CmnCheck.IsInput(Me.O_LOCAL1_2) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路2:乗車券区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.O_LOCAL2_2) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路2:乗車券区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '                If Not CmnCheck.IsInput(Me.O_EXPRESS1_2, Me.O_EXPRESS2_2) AndAlso CmnCheck.IsInput(Me.O_LOCAL1_2, Me.O_LOCAL2_2) Then
        '                    If CmnCheck.IsInput(Me.O_SEAT_2) Then
        '                        CmnModule.AlertMessage("往路2:乗車券のみお申し込みの場合は、座席希望は選択できません。", Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '            End If
        '            If Not CmnCheck.IsInput(Me.O_TIME1_2) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.O_TIME1_2), Me.Parent.Page)
        '                Return False
        '            Else
        '                wStr = AppModule.GetValue_O_TIME1_2(Me.O_TIME1_2)
        '                If Not CmnCheck.IsNumberOnly(wStr) OrElse Not CmnCheck.IsLengthEQ(Me.O_TIME1_2, Me.O_TIME1_2.MaxLength) Then
        '                    CmnModule.AlertMessage("往路2:" & MessageDef.Error.InvalidTime, Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '            If Not CmnCheck.IsInput(Me.O_TIME2_2) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.O_TIME2_2), Me.Parent.Page)
        '                Return False
        '            Else
        '                wStr = AppModule.GetValue_O_TIME2_2(Me.O_TIME2_2)
        '                If Not CmnCheck.IsNumberOnly(wStr) OrElse Not CmnCheck.IsLengthEQ(Me.O_TIME2_2, Me.O_TIME2_2.MaxLength) Then
        '                    CmnModule.AlertMessage("往路2:" & MessageDef.Error.InvalidTime, Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '            If Me.O_SEAT_2.Enabled = True Then
        '                If Not CmnCheck.IsInput(Me.O_SEAT_2) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.O_SEAT_2), Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '        End If
        '    End If
        '    If wF_FLAG = True Then
        '        If CmnCheck.IsInput(Me.F_KOTSU_KUBUN_2_AIR) OrElse CmnCheck.IsInput(Me.F_KOTSU_KUBUN_2_JR) Then
        '            If Not CmnCheck.IsInput(Me.F_DATE_2) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.F_DATE_2), Me.Parent.Page)
        '                Return False
        '            End If
        '            If Not CmnCheck.IsInput(Me.F_BIN_2) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.F_BIN_2), Me.Parent.Page)
        '                Return False
        '            End If
        '            If Me.F_KOTSU_KUBUN_2_AIR.Checked = True Then
        '                If Not CmnCheck.IsInput(Me.F_AIRPORT1_2) AndAlso _
        '                   Not CmnCheck.IsInput(Me.F_AIRPORT2_2) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustInput("復路2:区間"), Me.Parent.Page)
        '                    Return False
        '                End If
        '                If CmnCheck.IsInput(Me.F_AIRPORT1_2) OrElse CmnCheck.IsInput(Me.F_AIRPORT2_2) Then
        '                    If Not CmnCheck.IsInput(Me.F_AIRPORT1_2) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路2:区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.F_AIRPORT2_2) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路2:区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '            End If
        '            If Me.F_KOTSU_KUBUN_2_JR.Checked = True Then
        '                If Not CmnCheck.IsInput(Me.F_EXPRESS1_2) AndAlso _
        '                   Not CmnCheck.IsInput(Me.F_EXPRESS2_2) AndAlso _
        '                   Not CmnCheck.IsInput(Me.F_LOCAL1_2) AndAlso _
        '                   Not CmnCheck.IsInput(Me.F_LOCAL2_2) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustInput("復路2:新幹線・特急区間または乗車券区間"), Me.Parent.Page)
        '                    Return False
        '                End If
        '                If CmnCheck.IsInput(Me.F_EXPRESS1_2) OrElse CmnCheck.IsInput(Me.F_EXPRESS2_2) Then
        '                    If Not CmnCheck.IsInput(Me.F_EXPRESS1_2) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路2:新幹線・特急区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.F_EXPRESS2_2) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路2:新幹線・特急区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '                If CmnCheck.IsInput(Me.F_LOCAL1_2) OrElse CmnCheck.IsInput(Me.F_LOCAL2_2) Then
        '                    If Not CmnCheck.IsInput(Me.F_LOCAL1_2) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路2:乗車券区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.F_LOCAL2_2) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路2:乗車券区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '                If Not CmnCheck.IsInput(Me.F_EXPRESS1_2, Me.F_EXPRESS2_2) AndAlso CmnCheck.IsInput(Me.F_LOCAL1_2, Me.F_LOCAL2_2) Then
        '                    If CmnCheck.IsInput(Me.F_SEAT_2) Then
        '                        CmnModule.AlertMessage("復路2:乗車券のみお申し込みの場合は、座席希望は選択できません。", Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '            End If
        '            If Not CmnCheck.IsInput(Me.F_TIME1_2) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.F_TIME1_2), Me.Parent.Page)
        '                Return False
        '            Else
        '                wStr = AppModule.GetValue_F_TIME1_2(Me.F_TIME1_2)
        '                If Not CmnCheck.IsNumberOnly(wStr) OrElse Not CmnCheck.IsLengthEQ(Me.F_TIME1_2, Me.F_TIME1_2.MaxLength) Then
        '                    CmnModule.AlertMessage("復路2:" & MessageDef.Error.InvalidTime, Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '            If Not CmnCheck.IsInput(Me.F_TIME2_2) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.F_TIME2_2), Me.Parent.Page)
        '                Return False
        '            Else
        '                wStr = AppModule.GetValue_F_TIME2_2(Me.F_TIME2_2)
        '                If Not CmnCheck.IsNumberOnly(wStr) OrElse Not CmnCheck.IsLengthEQ(Me.F_TIME2_2, Me.F_TIME2_2.MaxLength) Then
        '                    CmnModule.AlertMessage("復路2:" & MessageDef.Error.InvalidTime, Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '            If Me.F_SEAT_2.Enabled = True Then
        '                If Not CmnCheck.IsInput(Me.F_SEAT_2) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.F_SEAT_2), Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '        End If
        '    End If

        '    wO_FLAG = False
        '    wF_FLAG = False
        '    If CmnCheck.IsInput(Me.O_KOTSU_KUBUN_3_AIR) OrElse _
        '       CmnCheck.IsInput(Me.O_KOTSU_KUBUN_3_JR) OrElse _
        '       CmnCheck.IsInput(Me.O_DATE_3) OrElse _
        '       CmnCheck.IsInput(Me.O_AIRPORT1_3) OrElse _
        '       CmnCheck.IsInput(Me.O_AIRPORT2_3) OrElse _
        '       CmnCheck.IsInput(Me.O_EXPRESS1_3) OrElse _
        '       CmnCheck.IsInput(Me.O_EXPRESS2_3) OrElse _
        '       CmnCheck.IsInput(Me.O_LOCAL1_3) OrElse _
        '       CmnCheck.IsInput(Me.O_LOCAL2_3) OrElse _
        '       CmnCheck.IsInput(Me.O_TIME1_3) OrElse _
        '       CmnCheck.IsInput(Me.O_TIME2_3) OrElse _
        '   CmnCheck.IsInput(Me.O_BIN_3) OrElse _
        '   CmnCheck.IsInput(Me.O_SEAT_3) Then
        '        wO_FLAG = True
        '    End If

        '    If CmnCheck.IsInput(Me.F_KOTSU_KUBUN_3_AIR) OrElse _
        '       CmnCheck.IsInput(Me.F_KOTSU_KUBUN_3_JR) OrElse _
        '       CmnCheck.IsInput(Me.F_DATE_3) OrElse _
        '       CmnCheck.IsInput(Me.F_AIRPORT1_3) OrElse _
        '       CmnCheck.IsInput(Me.F_AIRPORT2_3) OrElse _
        '       CmnCheck.IsInput(Me.F_EXPRESS1_3) OrElse _
        '       CmnCheck.IsInput(Me.F_EXPRESS2_3) OrElse _
        '       CmnCheck.IsInput(Me.F_LOCAL1_3) OrElse _
        '       CmnCheck.IsInput(Me.F_LOCAL2_3) OrElse _
        '       CmnCheck.IsInput(Me.F_TIME1_3) OrElse _
        '       CmnCheck.IsInput(Me.F_TIME2_3) OrElse _
        '       CmnCheck.IsInput(Me.F_BIN_3) OrElse _
        '       CmnCheck.IsInput(Me.F_SEAT_3) Then
        '        wF_FLAG = True
        '    End If

        '    If wO_FLAG = True Then
        '        If CmnCheck.IsInput(Me.O_KOTSU_KUBUN_3_AIR) OrElse CmnCheck.IsInput(Me.O_KOTSU_KUBUN_3_JR) Then
        '            If Not CmnCheck.IsInput(Me.O_DATE_3) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.O_DATE_3), Me.Parent.Page)
        '                Return False
        '            End If
        '            If Not CmnCheck.IsInput(Me.O_BIN_3) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.O_BIN_3), Me.Parent.Page)
        '                Return False
        '            End If
        '            If Me.O_KOTSU_KUBUN_3_AIR.Checked = True Then
        '                If Not CmnCheck.IsInput(Me.O_AIRPORT1_3) AndAlso _
        '                   Not CmnCheck.IsInput(Me.O_AIRPORT2_3) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustInput("往路3:区間"), Me.Parent.Page)
        '                    Return False
        '                End If
        '                If CmnCheck.IsInput(Me.O_AIRPORT1_3) OrElse CmnCheck.IsInput(Me.O_AIRPORT2_3) Then
        '                    If Not CmnCheck.IsInput(Me.O_AIRPORT1_3) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路3:区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.O_AIRPORT2_3) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路3:区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '            End If
        '            If Me.O_KOTSU_KUBUN_3_JR.Checked = True Then
        '                If Not CmnCheck.IsInput(Me.O_EXPRESS1_3) AndAlso _
        '                   Not CmnCheck.IsInput(Me.O_EXPRESS2_3) AndAlso _
        '                   Not CmnCheck.IsInput(Me.O_LOCAL1_3) AndAlso _
        '                   Not CmnCheck.IsInput(Me.O_LOCAL2_3) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustInput("往路3:新幹線・特急区間または乗車券区間"), Me.Parent.Page)
        '                    Return False
        '                End If
        '                If CmnCheck.IsInput(Me.O_EXPRESS1_3) OrElse CmnCheck.IsInput(Me.O_EXPRESS2_3) Then
        '                    If Not CmnCheck.IsInput(Me.O_EXPRESS1_3) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路3:新幹線・特急区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.O_EXPRESS2_3) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路3:新幹線・特急区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '                If CmnCheck.IsInput(Me.O_LOCAL1_3) OrElse CmnCheck.IsInput(Me.O_LOCAL2_3) Then
        '                    If Not CmnCheck.IsInput(Me.O_LOCAL1_3) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路3:乗車券区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.O_LOCAL2_3) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("往路3:乗車券区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '                If Not CmnCheck.IsInput(Me.O_EXPRESS1_3, Me.O_EXPRESS2_3) AndAlso CmnCheck.IsInput(Me.O_LOCAL1_3, Me.O_LOCAL2_3) Then
        '                    If CmnCheck.IsInput(Me.O_SEAT_3) Then
        '                        CmnModule.AlertMessage("往路3:乗車券のみお申し込みの場合は、座席希望は選択できません。", Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '            End If
        '            If Not CmnCheck.IsInput(Me.O_TIME1_3) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.O_TIME1_3), Me.Parent.Page)
        '                Return False
        '            Else
        '                wStr = AppModule.GetValue_O_TIME1_3(Me.O_TIME1_3)
        '                If Not CmnCheck.IsNumberOnly(wStr) OrElse Not CmnCheck.IsLengthEQ(Me.O_TIME1_3, Me.O_TIME1_3.MaxLength) Then
        '                    CmnModule.AlertMessage("往路3:" & MessageDef.Error.InvalidTime, Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '            If Not CmnCheck.IsInput(Me.O_TIME2_3) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.O_TIME2_3), Me.Parent.Page)
        '                Return False
        '            Else
        '                wStr = AppModule.GetValue_O_TIME2_3(Me.O_TIME2_3)
        '                If Not CmnCheck.IsNumberOnly(wStr) OrElse Not CmnCheck.IsLengthEQ(Me.O_TIME2_3, Me.O_TIME2_3.MaxLength) Then
        '                    CmnModule.AlertMessage("往路3:" & MessageDef.Error.InvalidTime, Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '            If Me.O_SEAT_3.Enabled = True Then
        '                If Not CmnCheck.IsInput(Me.O_SEAT_3) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.O_SEAT_3), Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '        End If
        '    End If
        '    If wF_FLAG = True Then
        '        If CmnCheck.IsInput(Me.F_KOTSU_KUBUN_3_AIR) OrElse CmnCheck.IsInput(Me.F_KOTSU_KUBUN_3_JR) Then
        '            If Not CmnCheck.IsInput(Me.F_DATE_3) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.F_DATE_3), Me.Parent.Page)
        '                Return False
        '            End If
        '            If Not CmnCheck.IsInput(Me.F_BIN_3) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.F_BIN_3), Me.Parent.Page)
        '                Return False
        '            End If
        '            If Me.F_KOTSU_KUBUN_3_AIR.Checked = True Then
        '                If Not CmnCheck.IsInput(Me.F_AIRPORT1_3) AndAlso _
        '                   Not CmnCheck.IsInput(Me.F_AIRPORT2_3) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustInput("復路3:区間"), Me.Parent.Page)
        '                    Return False
        '                End If
        '                If CmnCheck.IsInput(Me.F_AIRPORT1_3) OrElse CmnCheck.IsInput(Me.F_AIRPORT2_3) Then
        '                    If Not CmnCheck.IsInput(Me.F_AIRPORT1_3) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路3:区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.F_AIRPORT2_3) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路3:区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '            End If
        '            If Me.F_KOTSU_KUBUN_3_JR.Checked = True Then
        '                If Not CmnCheck.IsInput(Me.F_EXPRESS1_3) AndAlso _
        '                   Not CmnCheck.IsInput(Me.F_EXPRESS2_3) AndAlso _
        '                   Not CmnCheck.IsInput(Me.F_LOCAL1_3) AndAlso _
        '                   Not CmnCheck.IsInput(Me.F_LOCAL2_3) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustInput("復路3:新幹線・特急区間または乗車券区間"), Me.Parent.Page)
        '                    Return False
        '                End If
        '                If CmnCheck.IsInput(Me.F_EXPRESS1_3) OrElse CmnCheck.IsInput(Me.F_EXPRESS2_3) Then
        '                    If Not CmnCheck.IsInput(Me.F_EXPRESS1_3) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路3:新幹線・特急区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.F_EXPRESS2_3) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路3:新幹線・特急区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '                If CmnCheck.IsInput(Me.F_LOCAL1_3) OrElse CmnCheck.IsInput(Me.F_LOCAL2_3) Then
        '                    If Not CmnCheck.IsInput(Me.F_LOCAL1_3) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路3:乗車券区間(発)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                    If Not CmnCheck.IsInput(Me.F_LOCAL2_3) Then
        '                        CmnModule.AlertMessage(MessageDef.Error.MustInput("復路3:乗車券区間(着)"), Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '                If Not CmnCheck.IsInput(Me.F_EXPRESS1_3, Me.F_EXPRESS2_3) AndAlso CmnCheck.IsInput(Me.F_LOCAL1_3, Me.F_LOCAL2_3) Then
        '                    If CmnCheck.IsInput(Me.F_SEAT_3) Then
        '                        CmnModule.AlertMessage("復路3:乗車券のみお申し込みの場合は、座席希望は選択できません。", Me.Parent.Page)
        '                        Return False
        '                    End If
        '                End If
        '            End If
        '            If Not CmnCheck.IsInput(Me.F_TIME1_3) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.F_TIME1_3), Me.Parent.Page)
        '                Return False
        '            Else
        '                wStr = AppModule.GetValue_F_TIME1_3(Me.F_TIME1_3)
        '                If Not CmnCheck.IsNumberOnly(wStr) OrElse Not CmnCheck.IsLengthEQ(Me.F_TIME1_3, Me.F_TIME1_3.MaxLength) Then
        '                    CmnModule.AlertMessage("復路3:" & MessageDef.Error.InvalidTime, Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '            If Not CmnCheck.IsInput(Me.F_TIME2_3) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.F_TIME2_3), Me.Parent.Page)
        '                Return False
        '            Else
        '                wStr = AppModule.GetValue_F_TIME2_3(Me.F_TIME2_3)
        '                If Not CmnCheck.IsNumberOnly(wStr) OrElse Not CmnCheck.IsLengthEQ(Me.F_TIME2_3, Me.F_TIME2_3.MaxLength) Then
        '                    CmnModule.AlertMessage("復路3:" & MessageDef.Error.InvalidTime, Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '            If Me.F_SEAT_3.Enabled = True Then
        '                If Not CmnCheck.IsInput(Me.F_SEAT_3) Then
        '                    CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.F_SEAT_3), Me.Parent.Page)
        '                    Return False
        '                End If
        '            End If
        '        End If
        '    End If

        '    If Me.TrTEHAI_KOTSU_4.Visible = True Then
        '        wStr = AppModule.GetValue_MILAGE_NO(Me.MILAGE_NO)
        '        If Not CmnCheck.IsAlphanumeric(Me.MILAGE_NO) Then
        '            CmnModule.AlertMessage(MessageDef.Error.AlphanumericOnly(TableDef.TBL_DR.Name.MILAGE_NO), Me.Parent.Page)
        '            Return False
        '        End If
        '        If Trim(wStr) <> "" Then
        '            If Not CmnCheck.IsInput(Me.AIRLINE_ANA, AIRLINE_JAL) Then
        '                CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.AIRLINE), Me.Parent.Page)
        '                Return False
        '            End If
        '        End If
        '    End If

        '    If Not CmnCheck.IsLengthLE(Me.NOTE_KOTSU.Text, 500) Then
        '        CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_DR.Name.NOTE_KOTSU, 500, True), Me.Parent.Page)
        '        Return False
        '    End If
        'End If

        'If Session.Item(SessionDef.UserType) = AppConst.UserType.Dr OrElse Session.Item(SessionDef.UserType) = AppConst.UserType.Member Then
        '    '宿泊日と交通日の比較でアラート
        '    Dim HOTEL_1 As String = ""
        '    Dim HOTEL_2 As String = ""
        '    Dim KOTSU_1 As String = ""
        '    Dim KOTSU_2 As String = ""
        '    If Me.TEHAI_HOTEL_Yes.Checked = True AndAlso Me.TEHAI_KOTSU_Yes.Checked = True Then
        '        '宿泊
        '        'HOTEL_1 = "2013/" & AppModule.GetValue_CHECK_IN(Me.CHECK_IN)
        '        'HOTEL_2 = "2013/" & AppModule.GetValue_CHECK_OUT(Me.CHECK_OUT)
        '        HOTEL_1 = "2013/" & AppConst.HOTEL.CHECK_IN
        '        HOTEL_2 = "2013/" & AppConst.HOTEL.CHECK_OUT

        '        '交通
        '        Dim temp As String
        '        temp = "01/01"
        '        If CmnCheck.IsInput(Me.O_DATE_1) Then
        '            temp = AppModule.GetValue_O_DATE_1(Me.O_DATE_1)
        '            If temp >= AppModule.GetValue_O_DATE_1(Me.O_DATE_1) Then
        '                KOTSU_1 = temp
        '            End If
        '        End If
        '        If CmnCheck.IsInput(Me.O_DATE_2) Then
        '            If temp > AppModule.GetValue_O_DATE_2(Me.O_DATE_2) Then
        '                KOTSU_1 = temp
        '            End If
        '        End If
        '        If CmnCheck.IsInput(Me.O_DATE_3) Then
        '            If temp > AppModule.GetValue_O_DATE_3(Me.O_DATE_3) Then
        '                KOTSU_1 = temp
        '            End If
        '        End If
        '        temp = "12/31"
        '        If CmnCheck.IsInput(Me.F_DATE_1) Then
        '            temp = AppModule.GetValue_F_DATE_1(Me.F_DATE_1)
        '            If temp >= AppModule.GetValue_F_DATE_1(Me.F_DATE_1) Then
        '                KOTSU_2 = temp
        '            End If
        '        End If
        '        If CmnCheck.IsInput(Me.F_DATE_2) Then
        '            If temp > AppModule.GetValue_F_DATE_2(Me.F_DATE_2) Then
        '                KOTSU_2 = temp
        '            End If
        '        End If
        '        If CmnCheck.IsInput(Me.F_DATE_3) Then
        '            If temp > AppModule.GetValue_F_DATE_3(Me.F_DATE_3) Then
        '                KOTSU_2 = temp
        '            End If
        '        End If
        '        KOTSU_1 = "2013/" & KOTSU_1
        '        KOTSU_2 = "2013/" & KOTSU_2

        '        '比較
        '        If KOTSU_1 <> "2013/" AndAlso KOTSU_2 <> "2013/" Then
        '            If HOTEL_1 <> KOTSU_1 OrElse HOTEL_2 <> KOTSU_2 Then
        '                Dim wURL As String = ""
        '                If Session.Item(SessionDef.UserType) = AppConst.UserType.Dr Then
        '                    'wURL = URL.Dr.DrRegist & "?" & RequestDef.wn & "=" & Right(CmnModule.GetSysDateTime(), 2) & "&" & RequestDef.ut & "=uD"
        '                ElseIf Session.Item(SessionDef.UserType) = AppConst.UserType.Member Then
        '                    'wURL = URL.Member.DrRegist & "?" & RequestDef.wn & "=" & Right(CmnModule.GetSysDateTime(), 2) & "&" & RequestDef.ut & "=uM"
        '                End If
        '                'マスターページを使っている場合、formタグのidがaspnetFormとなるので、
        '                '確実に取得するためには、Form.ClientIDプロパティからIDを取得する
        '                Dim formid As String = Me.Parent.Page.Form.ClientID
        '                '確認ダイアログを出力するスクリプト
        '                Dim sScript As String = "if(confirm('チェックイン／アウト日と乗車・搭乗日が異なります。このまま登録しますか？')){ " & _
        '                                           formid + ".method = 'post';" & _
        '                                           formid + ".action = '" & wURL & "';" & _
        '                                           formid + ".submit();" & _
        '                                       "}"
        '                'JavaScriptの埋め込み
        '                Page.ClientScript.RegisterStartupScript(Me.GetType(), "startup", sScript, True)

        '                'ClientScript.RegisterStartupScriptメソッドで登録した場合、ブラウザでの描画完了後に
        '                '登録したJavaScriptが実行される
        '                'ここでは、OKボタンが押されたことをGETパラメーターで通知する
        '                Return False
        '            End If
        '        End If
        '    End If
        'End If

        ''送付先
        'If Me.TEHAI_KOTSU_Yes.Checked = True Then
        '    If Not CmnCheck.IsInput(Me.SEND_SAKI) Then
        '        CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.SEND_SAKI), Me.Parent.Page)
        '        Return False
        '    End If

        '    If Not CmnCheck.IsInput(Me.SEND_ZIP_1, Me.SEND_ZIP_2) Then
        '        CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.SEND_ZIP), Me.Parent.Page)
        '        Return False
        '    Else
        '        wStr = AppModule.GetValue_SEND_ZIP(Me.SEND_ZIP_1, Me.SEND_ZIP_2)
        '        If Not CmnCheck.IsValidZip(wStr) Then
        '            CmnModule.AlertMessage(MessageDef.Error.Invalid(TableDef.TBL_DR.Name.SEND_ZIP), Me.Parent.Page)
        '            Return False
        '        End If
        '    End If

        '    If Not CmnCheck.IsInput(Me.SEND_ADDRESS) Then
        '        CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.SEND_ADDRESS), Me.Parent.Page)
        '        Return False
        '    End If

        '    If Not CmnCheck.IsInput(Me.SEND_NAME) Then
        '        CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.SEND_NAME), Me.Parent.Page)
        '        Return False
        '    End If

        '    If Not CmnCheck.IsInput(Me.SEND_TEL_1, Me.SEND_TEL_2, Me.SEND_TEL_3) Then
        '        CmnModule.AlertMessage(MessageDef.Error.MustInput(TableDef.TBL_DR.Name.SEND_TEL), Me.Parent.Page)
        '        Return False
        '    Else
        '        wStr = AppModule.GetValue_SEND_TEL(CmnModule.GetSelectedItemValue(Me.SEND_SAKI), Me.SEND_TEL_1, Me.SEND_TEL_2, Me.SEND_TEL_3)
        '        If Not CmnCheck.IsValidTel(wStr) Then
        '            CmnModule.AlertMessage(MessageDef.Error.Invalid(TableDef.TBL_DR.Name.SEND_TEL), Me.Parent.Page)
        '            Return False
        '        End If
        '    End If
        'End If

        ''支払方法
        ''If Me.TrPAYMENT_METHOD.Visible = True Then
        ''    if Not CmnCheck.IsInput(Me.PAYMENT_METHOD_Card, Me.PAYMENT_METHOD_Bank) Then
        ''        CmnModule.AlertMessage(MessageDef.Error.MustSelect(TableDef.TBL_DR.Name.PAYMENT_METHOD), Me.Parent.Page)
        ''        Return False
        ''    ENd if
        ''End if

        ''備考
        'If Not CmnCheck.IsLengthLE(Me.NOTES.Text, 500) Then
        '    CmnModule.AlertMessage(MessageDef.Error.LengthLE(TableDef.TBL_DR.Name.NOTES, 500, True), Me.Parent.Page)
        '    Return False
        'End If

        Return True
    End Function

    '入力値を取得
    'Public Function GetValue(ByVal TBL_DR As TableDef.TBL_DR.DataStruct, ByVal Cancel As Boolean) As TableDef.TBL_DR.DataStruct
    '    'キャンセル時→全手配クリア
    '    If Cancel = True Then
    '        Me.PARTY_Yes.Checked = False
    '        Me.PARTY_No.Checked = True
    '        Me.BYCAR_Yes.Checked = False
    '        Me.BYCAR_No.Checked = True
    '        Me.TEHAI_HOTEL_Yes.Checked = False
    '        Me.TEHAI_HOTEL_No.Checked = True
    '        Me.TEHAI_KOTSU_Yes.Checked = False
    '        Me.TEHAI_KOTSU_No.Checked = True
    '    End If

    '    '手配等設定
    '    TBL_DR = ClearForm(TBL_DR)

    '    TBL_DR.DR_NAME_FIRST = AppModule.GetValue_DR_NAME_FIRST(Me.DR_NAME_FIRST)
    '    TBL_DR.DR_NAME_LAST = AppModule.GetValue_DR_NAME_LAST(Me.DR_NAME_LAST)
    '    TBL_DR.DR_NAME_KANA_FIRST = AppModule.GetValue_DR_NAME_KANA_FIRST(Me.DR_NAME_KANA_FIRST)
    '    TBL_DR.DR_NAME_KANA_LAST = AppModule.GetValue_DR_NAME_KANA_LAST(Me.DR_NAME_KANA_LAST)
    '    TBL_DR.SEX = AppModule.GetValue_SEX(Me.SEX_Male, Me.SEX_Female)
    '    TBL_DR.PREFECTURES_NO = AppModule.GetValue_PREFECTURES_NO(Me.PREFECTURES_NO)
    '    TBL_DR.SHISETSU_NAME = AppModule.GetValue_SHISETSU_NAME(Me.SHISETSU_NAME)
    '    TBL_DR.SHISETSU_NAME_KANA = AppModule.GetValue_SHISETSU_NAME_KANA(Me.SHISETSU_NAME_KANA)
    '    TBL_DR.KAMOKU = AppModule.GetValue_KAMOKU(Me.KAMOKU)
    '    TBL_DR.YAKUSHOKU = AppModule.GetValue_YAKUSHOKU(Me.YAKUSHOKU)
    '    TBL_DR.AGE = AppModule.GetValue_AGE(Me.AGE)
    '    TBL_DR.PUBLIC_SERVANT = AppModule.GetValue_PUBLIC_SERVANT(Me.PUBLIC_SERVANT_Yes, Me.PUBLIC_SERVANT_No)
    '    TBL_DR.SECANDARY_USE = AppModule.GetValue_SECANDARY_USE(Me.SECANDARY_USE_Yes, Me.SECANDARY_USE_No)
    '    TBL_DR.TEHAI_HOTEL = AppModule.GetValue_TEHAI_HOTEL(Me.TEHAI_HOTEL_Yes, Me.TEHAI_HOTEL_No)
    '    'TBL_DR.CHECK_IN = AppModule.GetValue_CHECK_IN(Me.CHECK_IN)
    '    'TBL_DR.CHECK_OUT = AppModule.GetValue_CHECK_OUT(Me.CHECK_OUT)
    '    TBL_DR.CHECK_IN = AppModule.GetValue_CHECK_IN(Me.TEHAI_HOTEL_Yes)
    '    TBL_DR.CHECK_OUT = AppModule.GetValue_CHECK_OUT(Me.TEHAI_HOTEL_Yes)
    '    TBL_DR.HOTEL_SMOKING = AppModule.GetValue_HOTEL_SMOKING(Me.HOTEL_SMOKING_No, Me.HOTEL_SMOKING_Yes)
    '    TBL_DR.ACCOMPANY_FLAG = AppModule.GetValue_ACCOMPANY_FLAG(Me.ACCOMPANY_FLAG_Yes, Me.ACCOMPANY_FLAG_No)
    '    TBL_DR.ACCOMPANY_STAY = AppModule.GetValue_ACCOMPANY_STAY(Me.ACCOMPANY_STAY_Yes, Me.ACCOMPANY_STAY_No)
    '    TBL_DR.ACCOMPANY_STAY_DATE = AppModule.GetValue_ACCOMPANY_STAY_DATE(Me.ACCOMPANY_STAY_DATE)
    '    If TBL_DR.ACCOMPANY_STAY = AppConst.ACCOMPANY_STAY.Code.Yes Then
    '        'If Me.ACCOMPANY_STAY_DATE.Checked = True Then
    '        '    TBL_DR.ACCOMPANY_CHECK_IN = TBL_DR.CHECK_IN
    '        '    TBL_DR.ACCOMPANY_CHECK_OUT = TBL_DR.CHECK_OUT
    '        'Else
    '        '    TBL_DR.ACCOMPANY_CHECK_IN = ""
    '        '    TBL_DR.ACCOMPANY_CHECK_OUT = ""
    '        '    'TBL_DR.ACCOMPANY_CHECK_IN = AppModule.GetValue_ACCOMPANY_CHECK_IN(Me.ACCOMPANY_CHECK_IN)
    '        '    'TBL_DR.ACCOMPANY_CHECK_OUT = AppModule.GetValue_ACCOMPANY_CHECK_OUT(Me.ACCOMPANY_CHECK_OUT)
    '        'End If
    '        TBL_DR.ACCOMPANY_CHECK_IN = TBL_DR.CHECK_IN
    '        TBL_DR.ACCOMPANY_CHECK_OUT = TBL_DR.CHECK_OUT
    '    Else
    '        TBL_DR.ACCOMPANY_CHECK_IN = ""
    '        TBL_DR.ACCOMPANY_CHECK_OUT = ""
    '    End If
    '    TBL_DR.ACCOMPANY_SAME_ROOM = AppModule.GetValue_ACCOMPANY_SAME_ROOM(Me.ACCOMPANY_STAY_Yes, Me.ACCOMPANY_SAME_ROOM)
    '    TBL_DR.ACCOMPANY_ADULT_SU = AppModule.GetValue_ACCOMPANY_ADULT_SU(TBL_DR.ACCOMPANY_SAME_ROOM, Me.ACCOMPANY_ADULT_SU)
    '    TBL_DR.ACCOMPANY_CHILD_SU = AppModule.GetValue_ACCOMPANY_CHILD_SU(TBL_DR.ACCOMPANY_SAME_ROOM, Me.ACCOMPANY_CHILD_SU)
    '    TBL_DR.ACCOMPANY_CHILD_AGE_1 = AppModule.GetValue_ACCOMPANY_CHILD_AGE_1(TBL_DR.ACCOMPANY_SAME_ROOM, Me.ACCOMPANY_CHILD_SU, Me.ACCOMPANY_CHILD_AGE_1)
    '    TBL_DR.ACCOMPANY_CHILD_AGE_2 = AppModule.GetValue_ACCOMPANY_CHILD_AGE_2(TBL_DR.ACCOMPANY_SAME_ROOM, Me.ACCOMPANY_CHILD_SU, Me.ACCOMPANY_CHILD_AGE_2)
    '    TBL_DR.ACCOMPANY_CHILD_SEX_1 = AppModule.GetValue_ACCOMPANY_CHILD_SEX_1(TBL_DR.ACCOMPANY_SAME_ROOM, Me.ACCOMPANY_CHILD_SU, Me.ACCOMPANY_CHILD_SEX_1_Male, Me.ACCOMPANY_CHILD_SEX_1_Female)
    '    TBL_DR.ACCOMPANY_CHILD_SEX_2 = AppModule.GetValue_ACCOMPANY_CHILD_SEX_2(TBL_DR.ACCOMPANY_SAME_ROOM, Me.ACCOMPANY_CHILD_SU, Me.ACCOMPANY_CHILD_SEX_2_Male, Me.ACCOMPANY_CHILD_SEX_2_Female)
    '    TBL_DR.ACCOMPANY_CHILD_BED_1 = AppModule.GetValue_ACCOMPANY_CHILD_BED_1(TBL_DR.ACCOMPANY_SAME_ROOM, Me.ACCOMPANY_CHILD_SU, Me.ACCOMPANY_CHILD_BED_1_Yes, Me.ACCOMPANY_CHILD_BED_1_No)
    '    TBL_DR.ACCOMPANY_CHILD_BED_2 = AppModule.GetValue_ACCOMPANY_CHILD_BED_2(TBL_DR.ACCOMPANY_SAME_ROOM, Me.ACCOMPANY_CHILD_SU, Me.ACCOMPANY_CHILD_BED_2_Yes, Me.ACCOMPANY_CHILD_BED_2_No)
    '    'TBL_DR.ROOM_TYPE = AppModule.GetValue_ROOM_TYPE(Me.TEHAI_HOTEL_Yes, Me.ROOM_TYPE)
    '    TBL_DR.NOTE_ACCOMPANY = AppModule.GetValue_NOTE_ACCOMPANY(Me.NOTE_ACCOMPANY)
    '    TBL_DR.NOTE_HOTEL = AppModule.GetValue_NOTE_HOTEL(Me.NOTE_HOTEL)
    '    TBL_DR.PARTY = AppModule.GetValue_PARTY(Me.PARTY_Yes, Me.PARTY_No)
    '    'TBL_DR.BYCAR = AppModule.GetValue_BYCAR(Me.BYCAR_Yes, Me.BYCAR_No)
    '    TBL_DR.TEHAI_KOTSU = AppModule.GetValue_TEHAI_KOTSU(Me.TEHAI_KOTSU_Yes, Me.TEHAI_KOTSU_No)
    '    TBL_DR.O_KOTSU_KUBUN_1 = AppModule.GetValue_O_KOTSU_KUBUN_1(Me.O_KOTSU_KUBUN_1_AIR, Me.O_KOTSU_KUBUN_1_JR, Me.O_KOTSU_KUBUN_1_None)
    '    TBL_DR.O_DATE_1 = AppModule.GetValue_O_DATE_1(Me.O_DATE_1)
    '    TBL_DR.O_BIN_1 = AppModule.GetValue_O_BIN_1(Me.O_BIN_1)
    '    TBL_DR.O_AIRPORT1_1 = AppModule.GetValue_O_AIRPORT1_1(Me.O_AIRPORT1_1, Me.O_KOTSU_KUBUN_1_AIR)
    '    TBL_DR.O_AIRPORT2_1 = AppModule.GetValue_O_AIRPORT2_1(Me.O_AIRPORT2_1, Me.O_KOTSU_KUBUN_1_AIR)
    '    TBL_DR.O_EXPRESS1_1 = AppModule.GetValue_O_EXPRESS1_1(Me.O_EXPRESS1_1, Me.O_KOTSU_KUBUN_1_JR)
    '    TBL_DR.O_EXPRESS2_1 = AppModule.GetValue_O_EXPRESS2_1(Me.O_EXPRESS2_1, Me.O_KOTSU_KUBUN_1_JR)
    '    TBL_DR.O_LOCAL1_1 = AppModule.GetValue_O_LOCAL1_1(Me.O_LOCAL1_1, Me.O_KOTSU_KUBUN_1_JR)
    '    TBL_DR.O_LOCAL2_1 = AppModule.GetValue_O_LOCAL2_1(Me.O_LOCAL2_1, Me.O_KOTSU_KUBUN_1_JR)
    '    TBL_DR.O_TIME1_1 = AppModule.GetValue_O_TIME1_1(Me.O_TIME1_1)
    '    TBL_DR.O_TIME2_1 = AppModule.GetValue_O_TIME2_1(Me.O_TIME2_1)
    '    TBL_DR.O_SEAT_1 = AppModule.GetValue_O_SEAT_1(Me.O_SEAT_1)
    '    TBL_DR.O_KOTSU_KUBUN_2 = AppModule.GetValue_O_KOTSU_KUBUN_2(Me.O_KOTSU_KUBUN_2_AIR, Me.O_KOTSU_KUBUN_2_JR, Me.O_KOTSU_KUBUN_2_None)
    '    TBL_DR.O_DATE_2 = AppModule.GetValue_O_DATE_2(Me.O_DATE_2)
    '    TBL_DR.O_BIN_2 = AppModule.GetValue_O_BIN_2(Me.O_BIN_2)
    '    TBL_DR.O_AIRPORT1_2 = AppModule.GetValue_O_AIRPORT1_2(Me.O_AIRPORT1_2, Me.O_KOTSU_KUBUN_2_AIR)
    '    TBL_DR.O_AIRPORT2_2 = AppModule.GetValue_O_AIRPORT2_2(Me.O_AIRPORT2_2, Me.O_KOTSU_KUBUN_2_AIR)
    '    TBL_DR.O_EXPRESS1_2 = AppModule.GetValue_O_EXPRESS1_2(Me.O_EXPRESS1_2, Me.O_KOTSU_KUBUN_2_JR)
    '    TBL_DR.O_EXPRESS2_2 = AppModule.GetValue_O_EXPRESS2_2(Me.O_EXPRESS2_2, Me.O_KOTSU_KUBUN_2_JR)
    '    TBL_DR.O_LOCAL1_2 = AppModule.GetValue_O_LOCAL1_2(Me.O_LOCAL1_2, Me.O_KOTSU_KUBUN_2_JR)
    '    TBL_DR.O_LOCAL2_2 = AppModule.GetValue_O_LOCAL2_2(Me.O_LOCAL2_2, Me.O_KOTSU_KUBUN_2_JR)
    '    TBL_DR.O_TIME1_2 = AppModule.GetValue_O_TIME1_2(Me.O_TIME1_2)
    '    TBL_DR.O_TIME2_2 = AppModule.GetValue_O_TIME2_2(Me.O_TIME2_2)
    '    TBL_DR.O_SEAT_2 = AppModule.GetValue_O_SEAT_2(Me.O_SEAT_2)
    '    TBL_DR.O_KOTSU_KUBUN_3 = AppModule.GetValue_O_KOTSU_KUBUN_3(Me.O_KOTSU_KUBUN_3_AIR, Me.O_KOTSU_KUBUN_3_JR, Me.O_KOTSU_KUBUN_3_None)
    '    TBL_DR.O_DATE_3 = AppModule.GetValue_O_DATE_3(Me.O_DATE_3)
    '    TBL_DR.O_BIN_3 = AppModule.GetValue_O_BIN_3(Me.O_BIN_3)
    '    TBL_DR.O_AIRPORT1_3 = AppModule.GetValue_O_AIRPORT1_3(Me.O_AIRPORT1_3, Me.O_KOTSU_KUBUN_3_AIR)
    '    TBL_DR.O_AIRPORT2_3 = AppModule.GetValue_O_AIRPORT2_3(Me.O_AIRPORT2_3, Me.O_KOTSU_KUBUN_3_AIR)
    '    TBL_DR.O_EXPRESS1_3 = AppModule.GetValue_O_EXPRESS1_3(Me.O_EXPRESS1_3, Me.O_KOTSU_KUBUN_3_JR)
    '    TBL_DR.O_EXPRESS2_3 = AppModule.GetValue_O_EXPRESS2_3(Me.O_EXPRESS2_3, Me.O_KOTSU_KUBUN_3_JR)
    '    TBL_DR.O_LOCAL1_3 = AppModule.GetValue_O_LOCAL1_3(Me.O_LOCAL1_3, Me.O_KOTSU_KUBUN_3_JR)
    '    TBL_DR.O_LOCAL2_3 = AppModule.GetValue_O_LOCAL2_3(Me.O_LOCAL2_3, Me.O_KOTSU_KUBUN_3_JR)
    '    TBL_DR.O_TIME1_3 = AppModule.GetValue_O_TIME1_3(Me.O_TIME1_3)
    '    TBL_DR.O_TIME2_3 = AppModule.GetValue_O_TIME2_3(Me.O_TIME2_3)
    '    TBL_DR.O_SEAT_3 = AppModule.GetValue_O_SEAT_3(Me.O_SEAT_3)
    '    TBL_DR.F_KOTSU_KUBUN_1 = AppModule.GetValue_F_KOTSU_KUBUN_1(Me.F_KOTSU_KUBUN_1_AIR, Me.F_KOTSU_KUBUN_1_JR, Me.F_KOTSU_KUBUN_1_None)
    '    TBL_DR.F_DATE_1 = AppModule.GetValue_F_DATE_1(Me.F_DATE_1)
    '    TBL_DR.F_BIN_1 = AppModule.GetValue_F_BIN_1(Me.F_BIN_1)
    '    TBL_DR.F_AIRPORT1_1 = AppModule.GetValue_F_AIRPORT1_1(Me.F_AIRPORT1_1, Me.F_KOTSU_KUBUN_1_AIR)
    '    TBL_DR.F_AIRPORT2_1 = AppModule.GetValue_F_AIRPORT2_1(Me.F_AIRPORT2_1, Me.F_KOTSU_KUBUN_1_AIR)
    '    TBL_DR.F_EXPRESS1_1 = AppModule.GetValue_F_EXPRESS1_1(Me.F_EXPRESS1_1, Me.F_KOTSU_KUBUN_1_JR)
    '    TBL_DR.F_EXPRESS2_1 = AppModule.GetValue_F_EXPRESS2_1(Me.F_EXPRESS2_1, Me.F_KOTSU_KUBUN_1_JR)
    '    TBL_DR.F_LOCAL1_1 = AppModule.GetValue_F_LOCAL1_1(Me.F_LOCAL1_1, Me.F_KOTSU_KUBUN_1_JR)
    '    TBL_DR.F_LOCAL2_1 = AppModule.GetValue_F_LOCAL2_1(Me.F_LOCAL2_1, Me.F_KOTSU_KUBUN_1_JR)
    '    TBL_DR.F_TIME1_1 = AppModule.GetValue_F_TIME1_1(Me.F_TIME1_1)
    '    TBL_DR.F_TIME2_1 = AppModule.GetValue_F_TIME2_1(Me.F_TIME2_1)
    '    TBL_DR.F_SEAT_1 = AppModule.GetValue_F_SEAT_1(Me.F_SEAT_1)
    '    TBL_DR.F_KOTSU_KUBUN_2 = AppModule.GetValue_F_KOTSU_KUBUN_2(Me.F_KOTSU_KUBUN_2_AIR, Me.F_KOTSU_KUBUN_2_JR, Me.F_KOTSU_KUBUN_2_None)
    '    TBL_DR.F_DATE_2 = AppModule.GetValue_F_DATE_2(Me.F_DATE_2)
    '    TBL_DR.F_BIN_2 = AppModule.GetValue_F_BIN_2(Me.F_BIN_2)
    '    TBL_DR.F_AIRPORT1_2 = AppModule.GetValue_F_AIRPORT1_2(Me.F_AIRPORT1_2, Me.F_KOTSU_KUBUN_2_AIR)
    '    TBL_DR.F_AIRPORT2_2 = AppModule.GetValue_F_AIRPORT2_2(Me.F_AIRPORT2_2, Me.F_KOTSU_KUBUN_2_AIR)
    '    TBL_DR.F_EXPRESS1_2 = AppModule.GetValue_F_EXPRESS1_2(Me.F_EXPRESS1_2, Me.F_KOTSU_KUBUN_2_JR)
    '    TBL_DR.F_EXPRESS2_2 = AppModule.GetValue_F_EXPRESS2_2(Me.F_EXPRESS2_2, Me.F_KOTSU_KUBUN_2_JR)
    '    TBL_DR.F_LOCAL1_2 = AppModule.GetValue_F_LOCAL1_2(Me.F_LOCAL1_2, Me.F_KOTSU_KUBUN_2_JR)
    '    TBL_DR.F_LOCAL2_2 = AppModule.GetValue_F_LOCAL2_2(Me.F_LOCAL2_2, Me.F_KOTSU_KUBUN_2_JR)
    '    TBL_DR.F_TIME1_2 = AppModule.GetValue_F_TIME1_2(Me.F_TIME1_2)
    '    TBL_DR.F_TIME2_2 = AppModule.GetValue_F_TIME2_2(Me.F_TIME2_2)
    '    TBL_DR.F_SEAT_2 = AppModule.GetValue_F_SEAT_2(Me.F_SEAT_2)
    '    TBL_DR.F_KOTSU_KUBUN_3 = AppModule.GetValue_F_KOTSU_KUBUN_3(Me.F_KOTSU_KUBUN_3_AIR, Me.F_KOTSU_KUBUN_3_JR, Me.F_KOTSU_KUBUN_3_None)
    '    TBL_DR.F_DATE_3 = AppModule.GetValue_F_DATE_3(Me.F_DATE_3)
    '    TBL_DR.F_BIN_3 = AppModule.GetValue_F_BIN_3(Me.F_BIN_3)
    '    TBL_DR.F_AIRPORT1_3 = AppModule.GetValue_F_AIRPORT1_3(Me.F_AIRPORT1_3, Me.F_KOTSU_KUBUN_3_AIR)
    '    TBL_DR.F_AIRPORT2_3 = AppModule.GetValue_F_AIRPORT2_3(Me.F_AIRPORT2_3, Me.F_KOTSU_KUBUN_3_AIR)
    '    TBL_DR.F_EXPRESS1_3 = AppModule.GetValue_F_EXPRESS1_3(Me.F_EXPRESS1_3, Me.F_KOTSU_KUBUN_3_JR)
    '    TBL_DR.F_EXPRESS2_3 = AppModule.GetValue_F_EXPRESS2_3(Me.F_EXPRESS2_3, Me.F_KOTSU_KUBUN_3_JR)
    '    TBL_DR.F_LOCAL1_3 = AppModule.GetValue_F_LOCAL1_3(Me.F_LOCAL1_3, Me.F_KOTSU_KUBUN_3_JR)
    '    TBL_DR.F_LOCAL2_3 = AppModule.GetValue_F_LOCAL2_3(Me.F_LOCAL2_3, Me.F_KOTSU_KUBUN_3_JR)
    '    TBL_DR.F_TIME1_3 = AppModule.GetValue_F_TIME1_3(Me.F_TIME1_3)
    '    TBL_DR.F_TIME2_3 = AppModule.GetValue_F_TIME2_3(Me.F_TIME2_3)
    '    TBL_DR.F_SEAT_3 = AppModule.GetValue_F_SEAT_3(Me.F_SEAT_3)
    '    TBL_DR.AIRLINE = AppModule.GetValue_AIRLINE(Me.AIRLINE_ANA, Me.AIRLINE_JAL)
    '    TBL_DR.MILAGE_NO = AppModule.GetValue_MILAGE_NO(Me.MILAGE_NO)
    '    TBL_DR.NOTE_KOTSU = AppModule.GetValue_NOTE_KOTSU(Me.NOTE_KOTSU)
    '    TBL_DR.SEND_SAKI = AppModule.GetValue_SEND_SAKI(Me.SEND_SAKI)
    '    TBL_DR.SEND_ZIP = AppModule.GetValue_SEND_ZIP(TBL_DR.SEND_SAKI, Me.SEND_ZIP_1, Me.SEND_ZIP_2)
    '    TBL_DR.SEND_ADDRESS = AppModule.GetValue_SEND_ADDRESS(TBL_DR.SEND_SAKI, Me.SEND_ADDRESS)
    '    TBL_DR.SEND_NAME = AppModule.GetValue_SEND_NAME(TBL_DR.SEND_SAKI, Me.SEND_NAME)
    '    TBL_DR.SEND_TEL = AppModule.GetValue_SEND_TEL(TBL_DR.SEND_SAKI, Me.SEND_TEL_1, Me.SEND_TEL_2, Me.SEND_TEL_3)
    '    TBL_DR.NOTES = AppModule.GetValue_NOTES(Me.NOTES)

    '    TBL_DR.ROOM_RATE = AppModule.GetValue_ROOM_RATE(TBL_DR, MyBase.DbConnection)
    '    TBL_DR.ACCOMPANY_ROOM_RATE = AppModule.GetValue_ACCOMPANY_ROOM_RATE(TBL_DR, MyBase.DbConnection)
    '    TBL_DR.KOTSU_NO = AppModule.GetValue_KOTSU_NO(Me.TEHAI_KOTSU_Yes, Me.PREFECTURES_NO)
    '    TBL_DR.O_KOTSU_FARE = AppModule.GetValue_O_KOTSU_FARE(TBL_DR, MyBase.DbConnection)
    '    TBL_DR.F_KOTSU_FARE = AppModule.GetValue_F_KOTSU_FARE(TBL_DR, MyBase.DbConnection)
    '    TBL_DR.TOTAL_AMOUNT = AppModule.GetValue_TOTAL_AMOUNT(TBL_DR)

    '    'トップツアーのみ
    '    If Session.Item(SessionDef.UserType) = AppConst.UserType.Admin Then
    '        TBL_DR.SANKA_KUBUN = AppModule.GetValue_SANKA_KUBUN(Me.SANKA_KUBUN_Listener, Me.SANKA_KUBUN_Speaker)
    '        TBL_DR.PAYMENT_METHOD = AppModule.GetValue_PAYMENT_METHOD(Me.PAYMENT_METHOD_Card, Me.PAYMENT_METHOD_Bank)

    '        TBL_DR.O_SEATCLASS_1 = AppModule.GetValue_O_SEATCLASS_1(Me.O_SEATCLASS_1)
    '        TBL_DR.O_SEATCLASS_2 = AppModule.GetValue_O_SEATCLASS_2(Me.O_SEATCLASS_2)
    '        TBL_DR.O_SEATCLASS_3 = AppModule.GetValue_O_SEATCLASS_3(Me.O_SEATCLASS_3)
    '        TBL_DR.F_SEATCLASS_1 = AppModule.GetValue_F_SEATCLASS_1(Me.F_SEATCLASS_1)
    '        TBL_DR.F_SEATCLASS_2 = AppModule.GetValue_F_SEATCLASS_2(Me.F_SEATCLASS_2)
    '        TBL_DR.F_SEATCLASS_3 = AppModule.GetValue_F_SEATCLASS_3(Me.F_SEATCLASS_3)
    '    End If
    '    'If Trim(TBL_DR.SANKA_KUBUN) = "" Then TBL_DR.SANKA_KUBUN = AppConst.SANKA_KUBUN.Code.Listener '初期値:参加Dr

    '    'キャンセル時、手配・金額関係をクリア
    '    If Cancel = True Then
    '        TBL_DR.CHECK_IN = ""
    '        TBL_DR.CHECK_OUT = ""
    '        TBL_DR.HOTEL_SMOKING = ""
    '        TBL_DR.HOTEL_NAME = ""
    '        TBL_DR.HOTEL_ADDRESS = ""
    '        TBL_DR.HOTEL_TEL = ""
    '        TBL_DR.HOTEL_FAX = ""
    '        TBL_DR.ROOM_TYPE = ""
    '        TBL_DR.ROOM_SU = ""
    '        TBL_DR.HOTELPRINT_SHIHARAI = ""
    '        TBL_DR.HOTELPRINT_CHECKIN = ""
    '        TBL_DR.HOTELPRINT_RENRAKU = ""
    '        TBL_DR.HOTELPRINT_ACCOMPANY = ""
    '        TBL_DR.HOTELPRINT_BREAKFAST = ""
    '        TBL_DR.HOTEL_CHECKIN_DATE = ""
    '        TBL_DR.HOTEL_CHECKOUT_DATE = ""
    '        'TBL_DR.TEHAIMAIL_HOTEL = ""
    '        TBL_DR.ACCOMPANY_CHECK_IN = ""
    '        TBL_DR.ACCOMPANY_CHECK_OUT = ""
    '        'TBL_DR.TEHAIMAIL_KOTSU = ""
    '        TBL_DR.ROOM_RATE = ""
    '        TBL_DR.ACCOMPANY_ROOM_RATE = ""
    '        TBL_DR.O_KOTSU_FARE = ""
    '        TBL_DR.F_KOTSU_FARE = ""
    '        TBL_DR.TOTAL_AMOUNT = ""
    '        '    TBL_DR.SAGAKU_NAME_1 = ""
    '        '    TBL_DR.SAGAKU_1 = ""
    '        '    TBL_DR.SAGAKU_NAME_2 = ""
    '        '    TBL_DR.SAGAKU_2 = ""
    '        '    TBL_DR.SAGAKU_NAME_3 = ""
    '        '    TBL_DR.SAGAKU_3 = ""
    '        '    TBL_DR.SAGAKU_NAME_4 = ""
    '        '    TBL_DR.SAGAKU_4 = ""
    '        '    TBL_DR.SAGAKU_NAME_5 = ""
    '        '    TBL_DR.SAGAKU_5 = ""
    '    End If

    '    Return TBL_DR
    'End Function

    ''手配等 Web画面データの設定
    'Private Function ClearForm(ByVal TBL_DR As TableDef.TBL_DR.DataStruct) As TableDef.TBL_DR.DataStruct
    '    If Me.TEHAI_HOTEL_Yes.Checked = False Then
    '        CmnModule.ClearControl(Me.HOTEL_SMOKING_No)
    '        CmnModule.ClearControl(Me.HOTEL_SMOKING_Yes)
    '        CmnModule.ClearControl(Me.ACCOMPANY_FLAG_Yes)
    '        CmnModule.ClearControl(Me.ACCOMPANY_FLAG_No)
    '        CmnModule.ClearControl(Me.ACCOMPANY_STAY_Yes)
    '        CmnModule.ClearControl(Me.ACCOMPANY_STAY_No)
    '        CmnModule.ClearControl(Me.ACCOMPANY_STAY_DATE)
    '        CmnModule.ClearControl(Me.ACCOMPANY_ADULT_SU)
    '        CmnModule.ClearControl(Me.ACCOMPANY_CHILD_SU)
    '        CmnModule.ClearControl(Me.ACCOMPANY_CHILD_SEX_1_Male)
    '        CmnModule.ClearControl(Me.ACCOMPANY_CHILD_SEX_1_Female)
    '        CmnModule.ClearControl(Me.ACCOMPANY_CHILD_SEX_2_Male)
    '        CmnModule.ClearControl(Me.ACCOMPANY_CHILD_SEX_2_Female)
    '        CmnModule.ClearControl(Me.ACCOMPANY_CHILD_BED_1_Yes)
    '        CmnModule.ClearControl(Me.ACCOMPANY_CHILD_BED_1_No)
    '        CmnModule.ClearControl(Me.ACCOMPANY_CHILD_BED_2_Yes)
    '        CmnModule.ClearControl(Me.ACCOMPANY_CHILD_BED_2_No)
    '        CmnModule.ClearControl(Me.ACCOMPANY_CHILD_AGE_1)
    '        CmnModule.ClearControl(Me.ACCOMPANY_CHILD_AGE_2)
    '        CmnModule.ClearControl(Me.NOTE_ACCOMPANY)
    '        CmnModule.ClearControl(Me.NOTE_HOTEL)
    '        '手配キャンセル時
    '        TBL_DR.HOTEL_NAME = ""
    '        TBL_DR.HOTEL_ADDRESS = ""
    '        TBL_DR.HOTEL_TEL = ""
    '        TBL_DR.HOTEL_FAX = ""
    '        TBL_DR.ROOM_TYPE = ""
    '        TBL_DR.ROOM_SU = ""
    '        TBL_DR.HOTELPRINT_SHIHARAI = ""
    '        TBL_DR.HOTELPRINT_CHECKIN = ""
    '        TBL_DR.HOTELPRINT_RENRAKU = ""
    '        TBL_DR.HOTEL_CHECKIN_DATE = ""
    '        TBL_DR.HOTEL_CHECKOUT_DATE = ""
    '        TBL_DR.HOTELPRINT_SHIHARAI_IDX = ""
    '        TBL_DR.HOTELPRINT_CHECKIN_IDX = ""
    '        TBL_DR.HOTELPRINT_RENRAKU_IDX = ""
    '        'TBL_DR.TEHAIMAIL_HOTEL = ""
    '    End If
    '    If Me.TEHAI_KOTSU_Yes.Checked = False Then
    '        CmnModule.ClearControl(Me.O_KOTSU_KUBUN_1_AIR)
    '        CmnModule.ClearControl(Me.O_KOTSU_KUBUN_1_JR)
    '        CmnModule.ClearControl(Me.O_DATE_1)
    '        CmnModule.ClearControl(Me.O_AIRPORT1_1)
    '        CmnModule.ClearControl(Me.O_AIRPORT2_1)
    '        CmnModule.ClearControl(Me.O_EXPRESS1_1)
    '        CmnModule.ClearControl(Me.O_EXPRESS2_1)
    '        CmnModule.ClearControl(Me.O_LOCAL1_1)
    '        CmnModule.ClearControl(Me.O_LOCAL2_1)
    '        CmnModule.ClearControl(Me.O_TIME1_1)
    '        CmnModule.ClearControl(Me.O_TIME2_1)
    '        CmnModule.ClearControl(Me.O_BIN_1)
    '        CmnModule.ClearControl(Me.O_SEAT_1)
    '        CmnModule.ClearControl(Me.O_KOTSU_KUBUN_2_AIR)
    '        CmnModule.ClearControl(Me.O_KOTSU_KUBUN_2_JR)
    '        CmnModule.ClearControl(Me.O_DATE_2)
    '        CmnModule.ClearControl(Me.O_AIRPORT1_2)
    '        CmnModule.ClearControl(Me.O_AIRPORT2_2)
    '        CmnModule.ClearControl(Me.O_EXPRESS1_2)
    '        CmnModule.ClearControl(Me.O_EXPRESS2_2)
    '        CmnModule.ClearControl(Me.O_LOCAL1_2)
    '        CmnModule.ClearControl(Me.O_LOCAL2_2)
    '        CmnModule.ClearControl(Me.O_TIME1_2)
    '        CmnModule.ClearControl(Me.O_TIME2_2)
    '        CmnModule.ClearControl(Me.O_BIN_2)
    '        CmnModule.ClearControl(Me.O_SEAT_2)
    '        CmnModule.ClearControl(Me.O_KOTSU_KUBUN_3_AIR)
    '        CmnModule.ClearControl(Me.O_KOTSU_KUBUN_3_JR)
    '        CmnModule.ClearControl(Me.O_DATE_3)
    '        CmnModule.ClearControl(Me.O_AIRPORT1_3)
    '        CmnModule.ClearControl(Me.O_AIRPORT2_3)
    '        CmnModule.ClearControl(Me.O_EXPRESS1_3)
    '        CmnModule.ClearControl(Me.O_EXPRESS2_3)
    '        CmnModule.ClearControl(Me.O_LOCAL1_3)
    '        CmnModule.ClearControl(Me.O_LOCAL2_3)
    '        CmnModule.ClearControl(Me.O_TIME1_3)
    '        CmnModule.ClearControl(Me.O_TIME2_3)
    '        CmnModule.ClearControl(Me.O_BIN_3)
    '        CmnModule.ClearControl(Me.O_SEAT_3)
    '        CmnModule.ClearControl(Me.F_KOTSU_KUBUN_1_AIR)
    '        CmnModule.ClearControl(Me.F_KOTSU_KUBUN_1_JR)
    '        CmnModule.ClearControl(Me.F_DATE_1)
    '        CmnModule.ClearControl(Me.F_AIRPORT1_1)
    '        CmnModule.ClearControl(Me.F_AIRPORT2_1)
    '        CmnModule.ClearControl(Me.F_EXPRESS1_1)
    '        CmnModule.ClearControl(Me.F_EXPRESS2_1)
    '        CmnModule.ClearControl(Me.F_LOCAL1_1)
    '        CmnModule.ClearControl(Me.F_LOCAL2_1)
    '        CmnModule.ClearControl(Me.F_TIME1_1)
    '        CmnModule.ClearControl(Me.F_TIME2_1)
    '        CmnModule.ClearControl(Me.F_BIN_1)
    '        CmnModule.ClearControl(Me.F_SEAT_1)
    '        CmnModule.ClearControl(Me.F_KOTSU_KUBUN_2_AIR)
    '        CmnModule.ClearControl(Me.F_KOTSU_KUBUN_2_JR)
    '        CmnModule.ClearControl(Me.F_DATE_2)
    '        CmnModule.ClearControl(Me.F_AIRPORT1_2)
    '        CmnModule.ClearControl(Me.F_AIRPORT2_2)
    '        CmnModule.ClearControl(Me.F_EXPRESS1_2)
    '        CmnModule.ClearControl(Me.F_EXPRESS2_2)
    '        CmnModule.ClearControl(Me.F_LOCAL1_2)
    '        CmnModule.ClearControl(Me.F_LOCAL2_2)
    '        CmnModule.ClearControl(Me.F_TIME1_2)
    '        CmnModule.ClearControl(Me.F_TIME2_2)
    '        CmnModule.ClearControl(Me.F_BIN_2)
    '        CmnModule.ClearControl(Me.F_SEAT_2)
    '        CmnModule.ClearControl(Me.F_KOTSU_KUBUN_3_AIR)
    '        CmnModule.ClearControl(Me.F_KOTSU_KUBUN_3_JR)
    '        CmnModule.ClearControl(Me.F_DATE_3)
    '        CmnModule.ClearControl(Me.F_AIRPORT1_3)
    '        CmnModule.ClearControl(Me.F_AIRPORT2_3)
    '        CmnModule.ClearControl(Me.F_EXPRESS1_3)
    '        CmnModule.ClearControl(Me.F_EXPRESS2_3)
    '        CmnModule.ClearControl(Me.F_LOCAL1_3)
    '        CmnModule.ClearControl(Me.F_LOCAL2_3)
    '        CmnModule.ClearControl(Me.F_TIME1_3)
    '        CmnModule.ClearControl(Me.F_TIME2_3)
    '        CmnModule.ClearControl(Me.F_BIN_3)
    '        CmnModule.ClearControl(Me.F_SEAT_3)
    '        CmnModule.ClearControl(Me.AIRLINE_ANA)
    '        CmnModule.ClearControl(Me.AIRLINE_JAL)
    '        CmnModule.ClearControl(Me.MILAGE_NO)
    '        CmnModule.ClearControl(Me.NOTE_KOTSU)
    '        CmnModule.ClearControl(Me.O_SEATCLASS_1)
    '        CmnModule.ClearControl(Me.O_SEATCLASS_2)
    '        CmnModule.ClearControl(Me.O_SEATCLASS_3)
    '        CmnModule.ClearControl(Me.F_SEATCLASS_1)
    '        CmnModule.ClearControl(Me.F_SEATCLASS_2)
    '        CmnModule.ClearControl(Me.F_SEATCLASS_3)
    '        'TBL_DR.TEHAIMAIL_KOTSU = ""
    '    End If
    '    Return TBL_DR
    'End Function

    ''宿泊手配 変更時
    'Protected Sub TEHAI_HOTEL_Yes_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TEHAI_HOTEL_Yes.CheckedChanged
    '    SetHOTEL(True)
    '    Page.SetFocus(Me.TEHAI_HOTEL_Yes)
    'End Sub
    'Protected Sub TEHAI_HOTEL_No_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TEHAI_HOTEL_No.CheckedChanged
    '    SetHOTEL(False)
    '    Page.SetFocus(Me.TEHAI_HOTEL_No)
    'End Sub

    ''宿泊関連のコントロールの使用可/不可を設定
    'Private Sub SetHOTEL(ByVal flag As Boolean)
    '    CmnModule.SetEnabled(Me.HOTEL_SMOKING_No, flag)
    '    CmnModule.SetEnabled(Me.HOTEL_SMOKING_Yes, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_FLAG_Yes, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_FLAG_No, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_STAY_Yes, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_STAY_No, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_STAY_DATE, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_ADULT_SU, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_SU, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_AGE_1, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_AGE_2, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_SEX_1_Male, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_SEX_1_Female, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_SEX_2_Male, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_SEX_2_Female, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_1_Yes, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_1_No, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_2_Yes, flag)
    '    CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_2_No, flag)
    '    CmnModule.SetEnabled(Me.NOTE_ACCOMPANY, flag)
    '    CmnModule.SetEnabled(Me.NOTE_HOTEL, flag)

    '    If flag = True Then
    '        Me.TrTEHAI_HOTEL_1.Visible = True
    '        Me.TrTEHAI_HOTEL_2.Visible = True
    '        Me.TrTEHAI_HOTEL_3.Visible = True
    '        Me.TrTEHAI_HOTEL_4.Visible = True
    '        Me.TrTEHAI_HOTEL_5.Visible = True
    '        Me.DivACCOMPANY.Visible = False
    '        If Me.ACCOMPANY_FLAG_Yes.Checked = True Then
    '            Me.TrTEHAI_HOTEL_5.Visible = True
    '            If Me.ACCOMPANY_STAY_Yes.Checked = True Then
    '                Me.DivACCOMPANY.Visible = True
    '                If Me.ACCOMPANY_SAME_ROOM.Checked = True Then
    '                    Me.TblACCOMPANY.Visible = True
    '                    Me.TblACCOMPANY_CHILD.Visible = False
    '                    Me.TrACCOMPANY_CHILD_1.Visible = False
    '                    Me.TrACCOMPANY_CHILD_2.Visible = False
    '                    If CmnCheck.IsInput(Me.ACCOMPANY_CHILD_SU) Then
    '                        Me.TblACCOMPANY_CHILD.Visible = True
    '                        If CmnModule.GetSelectedItemValue(Me.ACCOMPANY_CHILD_SU) = "1" Then
    '                            Me.TrACCOMPANY_CHILD_1.Visible = True
    '                        End If
    '                        If CmnModule.GetSelectedItemValue(Me.ACCOMPANY_CHILD_SU) = "2" Then
    '                            Me.TrACCOMPANY_CHILD_1.Visible = True
    '                            Me.TrACCOMPANY_CHILD_2.Visible = True
    '                        End If
    '                    End If
    '                Else
    '                    Me.TblACCOMPANY.Visible = False
    '                End If
    '            End If
    '        Else
    '            Me.TrTEHAI_HOTEL_5.Visible = False
    '            Me.DivACCOMPANY.Visible = False
    '        End If
    '        'If Trim(Me.ROOM_TYPE.Value) = "" Then
    '        '    Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Single
    '        'End If
    '    Else
    '        Me.TrTEHAI_HOTEL_1.Visible = False
    '        Me.TrTEHAI_HOTEL_2.Visible = False
    '        Me.TrTEHAI_HOTEL_3.Visible = False
    '        Me.TrTEHAI_HOTEL_4.Visible = False
    '        Me.TrTEHAI_HOTEL_5.Visible = False
    '    End If

    '    If Me.TrTEHAI_HOTEL_1.Visible = True Then
    '        AppModule.SetForm_CHECK_IN(AppConst.HOTEL.CHECK_IN, Me.CHECK_IN)
    '        AppModule.SetForm_CHECK_OUT(AppConst.HOTEL.CHECK_OUT, Me.CHECK_OUT)
    '    End If
    'End Sub
    'Private Sub SetHOTEL()
    '    If Me.TEHAI_HOTEL_Yes.Checked = True Then
    '        SetHOTEL(True)
    '    Else
    '        SetHOTEL(False)
    '    End If
    'End Sub

    ''公共交通手配 変更時
    'Protected Sub TEHAI_KOTSU_Yes_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TEHAI_KOTSU_Yes.CheckedChanged
    '    SetKOTSU(True)
    '    Page.SetFocus(Me.TEHAI_KOTSU_Yes)
    'End Sub
    'Protected Sub TEHAI_KOTSU_No_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TEHAI_KOTSU_No.CheckedChanged
    '    SetKOTSU(False)
    '    Page.SetFocus(Me.TEHAI_KOTSU_No)
    'End Sub

    ''交通関連のコントロールの使用可/不可を設定
    'Private Sub SetKOTSU()
    '    If Me.TEHAI_KOTSU_Yes.Checked = True Then
    '        SetKOTSU(True)
    '    Else
    '        SetKOTSU(False)
    '    End If
    'End Sub
    'Private Sub SetKOTSU(ByVal flag As Boolean)
    '    If flag = True Then
    '        Me.TrTEHAI_KOTSU_01.Visible = True
    '        Me.TrTEHAI_KOTSU_02.Visible = True
    '        Me.TrTEHAI_KOTSU_1.Visible = True
    '        Me.TrTEHAI_KOTSU_2.Visible = True
    '        Me.TrTEHAI_KOTSU_3.Visible = True
    '        Me.TrTEHAI_KOTSU_4.Visible = True
    '        Me.TrTEHAI_KOTSU_5.Visible = True
    '        'トップツアーのみ
    '        If Session.Item(SessionDef.UserType) = AppConst.UserType.Admin Then
    '            Me.TblO_SEATCLASS_1.Visible = True
    '            Me.TblO_SEATCLASS_2.Visible = True
    '            Me.TblO_SEATCLASS_3.Visible = True
    '            Me.TblF_SEATCLASS_1.Visible = True
    '            Me.TblF_SEATCLASS_2.Visible = True
    '            Me.TblF_SEATCLASS_3.Visible = True
    '        End If
    '    Else
    '        Me.TrTEHAI_KOTSU_01.Visible = False
    '        Me.TrTEHAI_KOTSU_02.Visible = False
    '        Me.TrTEHAI_KOTSU_1.Visible = False
    '        Me.TrTEHAI_KOTSU_2.Visible = False
    '        Me.TrTEHAI_KOTSU_3.Visible = False
    '        Me.TrTEHAI_KOTSU_4.Visible = False
    '        Me.TrTEHAI_KOTSU_5.Visible = False
    '    End If

    '    If flag = True Then
    '        'AIR/JR切り替え    '        CmnModule.SetEnabled(Me.O_DATE_1, True)
    '        CmnModule.SetEnabled(Me.O_AIRPORT1_1, True)
    '        CmnModule.SetEnabled(Me.O_AIRPORT2_1, True)
    '        CmnModule.SetEnabled(Me.O_EXPRESS1_1, True)
    '        CmnModule.SetEnabled(Me.O_EXPRESS2_1, True)
    '        CmnModule.SetEnabled(Me.O_LOCAL1_1, True)
    '        CmnModule.SetEnabled(Me.O_LOCAL2_1, True)
    '        CmnModule.SetEnabled(Me.O_TIME1_1, True)
    '        CmnModule.SetEnabled(Me.O_TIME2_1, True)
    '        CmnModule.SetEnabled(Me.O_BIN_1, True)
    '        CmnModule.SetEnabled(Me.O_SEAT_1, True)
    '        CmnModule.SetEnabled(Me.O_DATE_2, True)
    '        CmnModule.SetEnabled(Me.O_AIRPORT1_2, True)
    '        CmnModule.SetEnabled(Me.O_AIRPORT2_2, True)
    '        CmnModule.SetEnabled(Me.O_EXPRESS1_2, True)
    '        CmnModule.SetEnabled(Me.O_EXPRESS2_2, True)
    '        CmnModule.SetEnabled(Me.O_LOCAL1_2, True)
    '        CmnModule.SetEnabled(Me.O_LOCAL2_2, True)
    '        CmnModule.SetEnabled(Me.O_TIME1_2, True)
    '        CmnModule.SetEnabled(Me.O_TIME2_2, True)
    '        CmnModule.SetEnabled(Me.O_BIN_2, True)
    '        CmnModule.SetEnabled(Me.O_SEAT_2, True)
    '        CmnModule.SetEnabled(Me.O_DATE_3, True)
    '        CmnModule.SetEnabled(Me.O_AIRPORT1_3, True)
    '        CmnModule.SetEnabled(Me.O_AIRPORT2_3, True)
    '        CmnModule.SetEnabled(Me.O_EXPRESS1_3, True)
    '        CmnModule.SetEnabled(Me.O_EXPRESS2_3, True)
    '        CmnModule.SetEnabled(Me.O_LOCAL1_3, True)
    '        CmnModule.SetEnabled(Me.O_LOCAL2_3, True)
    '        CmnModule.SetEnabled(Me.O_TIME1_3, True)
    '        CmnModule.SetEnabled(Me.O_TIME2_3, True)
    '        CmnModule.SetEnabled(Me.O_BIN_3, True)
    '        CmnModule.SetEnabled(Me.O_SEAT_3, True)
    '        CmnModule.SetEnabled(Me.F_DATE_1, True)
    '        CmnModule.SetEnabled(Me.F_AIRPORT1_1, True)
    '        CmnModule.SetEnabled(Me.F_AIRPORT2_1, True)
    '        CmnModule.SetEnabled(Me.F_EXPRESS1_1, True)
    '        CmnModule.SetEnabled(Me.F_EXPRESS2_1, True)
    '        CmnModule.SetEnabled(Me.F_LOCAL1_1, True)
    '        CmnModule.SetEnabled(Me.F_LOCAL2_1, True)
    '        CmnModule.SetEnabled(Me.F_TIME1_1, True)
    '        CmnModule.SetEnabled(Me.F_TIME2_1, True)
    '        CmnModule.SetEnabled(Me.F_BIN_1, True)
    '        CmnModule.SetEnabled(Me.F_SEAT_1, True)
    '        CmnModule.SetEnabled(Me.F_DATE_2, True)
    '        CmnModule.SetEnabled(Me.F_AIRPORT1_2, True)
    '        CmnModule.SetEnabled(Me.F_AIRPORT2_2, True)
    '        CmnModule.SetEnabled(Me.F_EXPRESS1_2, True)
    '        CmnModule.SetEnabled(Me.F_EXPRESS2_2, True)
    '        CmnModule.SetEnabled(Me.F_LOCAL1_2, True)
    '        CmnModule.SetEnabled(Me.F_LOCAL2_2, True)
    '        CmnModule.SetEnabled(Me.F_TIME1_2, True)
    '        CmnModule.SetEnabled(Me.F_TIME2_2, True)
    '        CmnModule.SetEnabled(Me.F_BIN_2, True)
    '        CmnModule.SetEnabled(Me.F_SEAT_2, True)
    '        CmnModule.SetEnabled(Me.F_DATE_3, True)
    '        CmnModule.SetEnabled(Me.F_AIRPORT1_3, True)
    '        CmnModule.SetEnabled(Me.F_AIRPORT2_3, True)
    '        CmnModule.SetEnabled(Me.F_EXPRESS1_3, True)
    '        CmnModule.SetEnabled(Me.F_EXPRESS2_3, True)
    '        CmnModule.SetEnabled(Me.F_LOCAL1_3, True)
    '        CmnModule.SetEnabled(Me.F_LOCAL2_3, True)
    '        CmnModule.SetEnabled(Me.F_TIME1_3, True)
    '        CmnModule.SetEnabled(Me.F_TIME2_3, True)
    '        CmnModule.SetEnabled(Me.F_BIN_3, True)
    '        CmnModule.SetEnabled(Me.F_SEAT_3, True)
    '        'トップツアーのみ
    '        If Session.Item(SessionDef.UserType) = AppConst.UserType.Admin Then
    '            CmnModule.SetEnabled(Me.O_SEATCLASS_1, True)
    '            CmnModule.SetEnabled(Me.O_SEATCLASS_2, True)
    '            CmnModule.SetEnabled(Me.O_SEATCLASS_3, True)
    '            CmnModule.SetEnabled(Me.F_SEATCLASS_1, True)
    '            CmnModule.SetEnabled(Me.F_SEATCLASS_2, True)
    '            CmnModule.SetEnabled(Me.F_SEATCLASS_3, True)
    '        End If

    '        If Me.O_KOTSU_KUBUN_1_AIR.Checked = True Then
    '            Me.TblO_AIRPORT_1.Visible = True
    '            Me.TblO_EXPRESS_1.Visible = False
    '            Me.TblO_LOCAL_1.Visible = False
    '        ElseIf Me.O_KOTSU_KUBUN_1_JR.Checked = True Then
    '            Me.TblO_AIRPORT_1.Visible = False
    '            Me.TblO_EXPRESS_1.Visible = True
    '            Me.TblO_LOCAL_1.Visible = True
    '        Else
    '            Me.TblO_AIRPORT_1.Visible = True
    '            Me.TblO_EXPRESS_1.Visible = False
    '            Me.TblO_LOCAL_1.Visible = False
    '            CmnModule.SetEnabled(Me.O_DATE_1, False)
    '            CmnModule.SetEnabled(Me.O_AIRPORT1_1, False)
    '            CmnModule.SetEnabled(Me.O_AIRPORT2_1, False)
    '            CmnModule.SetEnabled(Me.O_EXPRESS1_1, False)
    '            CmnModule.SetEnabled(Me.O_EXPRESS2_1, False)
    '            CmnModule.SetEnabled(Me.O_LOCAL1_1, False)
    '            CmnModule.SetEnabled(Me.O_LOCAL2_1, False)
    '            CmnModule.SetEnabled(Me.O_TIME1_1, False)
    '            CmnModule.SetEnabled(Me.O_TIME2_1, False)
    '            CmnModule.SetEnabled(Me.O_BIN_1, False)
    '            CmnModule.SetEnabled(Me.O_SEAT_1, False)
    '            'トップツアーのみ
    '            If Session.Item(SessionDef.UserType) = AppConst.UserType.Admin Then
    '                CmnModule.SetEnabled(Me.O_SEATCLASS_1, False)
    '            End If
    '        End If

    '        If Me.O_KOTSU_KUBUN_2_AIR.Checked = True Then
    '            Me.TblO_AIRPORT_2.Visible = True
    '            Me.TblO_EXPRESS_2.Visible = False
    '            Me.TblO_LOCAL_2.Visible = False
    '        ElseIf Me.O_KOTSU_KUBUN_2_JR.Checked = True Then
    '            Me.TblO_AIRPORT_2.Visible = False
    '            Me.TblO_EXPRESS_2.Visible = True
    '            Me.TblO_LOCAL_2.Visible = True
    '        Else
    '            Me.TblO_AIRPORT_2.Visible = True
    '            Me.TblO_EXPRESS_2.Visible = False
    '            Me.TblO_LOCAL_2.Visible = False
    '            CmnModule.SetEnabled(Me.O_DATE_2, False)
    '            CmnModule.SetEnabled(Me.O_AIRPORT1_2, False)
    '            CmnModule.SetEnabled(Me.O_AIRPORT2_2, False)
    '            CmnModule.SetEnabled(Me.O_EXPRESS1_2, False)
    '            CmnModule.SetEnabled(Me.O_EXPRESS2_2, False)
    '            CmnModule.SetEnabled(Me.O_LOCAL1_2, False)
    '            CmnModule.SetEnabled(Me.O_LOCAL2_2, False)
    '            CmnModule.SetEnabled(Me.O_TIME1_2, False)
    '            CmnModule.SetEnabled(Me.O_TIME2_2, False)
    '            CmnModule.SetEnabled(Me.O_BIN_2, False)
    '            CmnModule.SetEnabled(Me.O_SEAT_2, False)
    '            'トップツアーのみ
    '            If Session.Item(SessionDef.UserType) = AppConst.UserType.Admin Then
    '                CmnModule.SetEnabled(Me.O_SEATCLASS_2, False)
    '            End If
    '        End If

    '        If Me.O_KOTSU_KUBUN_3_AIR.Checked = True Then
    '            Me.TblO_AIRPORT_3.Visible = True
    '            Me.TblO_EXPRESS_3.Visible = False
    '            Me.TblO_LOCAL_3.Visible = False
    '        ElseIf Me.O_KOTSU_KUBUN_3_JR.Checked = True Then
    '            Me.TblO_AIRPORT_3.Visible = False
    '            Me.TblO_EXPRESS_3.Visible = True
    '            Me.TblO_LOCAL_3.Visible = True
    '        Else
    '            Me.TblO_AIRPORT_3.Visible = True
    '            Me.TblO_EXPRESS_3.Visible = False
    '            Me.TblO_LOCAL_3.Visible = False
    '            CmnModule.SetEnabled(Me.O_DATE_3, False)
    '            CmnModule.SetEnabled(Me.O_AIRPORT1_3, False)
    '            CmnModule.SetEnabled(Me.O_AIRPORT2_3, False)
    '            CmnModule.SetEnabled(Me.O_EXPRESS1_3, False)
    '            CmnModule.SetEnabled(Me.O_EXPRESS2_3, False)
    '            CmnModule.SetEnabled(Me.O_LOCAL1_3, False)
    '            CmnModule.SetEnabled(Me.O_LOCAL2_3, False)
    '            CmnModule.SetEnabled(Me.O_TIME1_3, False)
    '            CmnModule.SetEnabled(Me.O_TIME2_3, False)
    '            CmnModule.SetEnabled(Me.O_BIN_3, False)
    '            CmnModule.SetEnabled(Me.O_SEAT_3, False)
    '            'トップツアーのみ
    '            If Session.Item(SessionDef.UserType) = AppConst.UserType.Admin Then
    '                CmnModule.SetEnabled(Me.O_SEATCLASS_3, False)
    '            End If
    '        End If

    '        If Me.F_KOTSU_KUBUN_1_AIR.Checked = True Then
    '            Me.TblF_AIRPORT_1.Visible = True
    '            Me.TblF_EXPRESS_1.Visible = False
    '            Me.TblF_LOCAL_1.Visible = False
    '        ElseIf Me.F_KOTSU_KUBUN_1_JR.Checked = True Then
    '            Me.TblF_AIRPORT_1.Visible = False
    '            Me.TblF_EXPRESS_1.Visible = True
    '            Me.TblF_LOCAL_1.Visible = True
    '        Else
    '            Me.TblF_AIRPORT_1.Visible = True
    '            Me.TblF_EXPRESS_1.Visible = False
    '            Me.TblF_LOCAL_1.Visible = False
    '            CmnModule.SetEnabled(Me.F_DATE_1, False)
    '            CmnModule.SetEnabled(Me.F_AIRPORT1_1, False)
    '            CmnModule.SetEnabled(Me.F_AIRPORT2_1, False)
    '            CmnModule.SetEnabled(Me.F_EXPRESS1_1, False)
    '            CmnModule.SetEnabled(Me.F_EXPRESS2_1, False)
    '            CmnModule.SetEnabled(Me.F_LOCAL1_1, False)
    '            CmnModule.SetEnabled(Me.F_LOCAL2_1, False)
    '            CmnModule.SetEnabled(Me.F_TIME1_1, False)
    '            CmnModule.SetEnabled(Me.F_TIME2_1, False)
    '            CmnModule.SetEnabled(Me.F_BIN_1, False)
    '            CmnModule.SetEnabled(Me.F_SEAT_1, False)
    '            'トップツアーのみ
    '            If Session.Item(SessionDef.UserType) = AppConst.UserType.Admin Then
    '                CmnModule.SetEnabled(Me.F_SEATCLASS_1, False)
    '            End If
    '        End If

    '        If Me.F_KOTSU_KUBUN_2_AIR.Checked = True Then
    '            Me.TblF_AIRPORT_2.Visible = True
    '            Me.TblF_EXPRESS_2.Visible = False
    '            Me.TblF_LOCAL_2.Visible = False
    '        ElseIf Me.F_KOTSU_KUBUN_2_JR.Checked = True Then
    '            Me.TblF_AIRPORT_2.Visible = False
    '            Me.TblF_EXPRESS_2.Visible = True
    '            Me.TblF_LOCAL_2.Visible = True
    '        Else
    '            Me.TblF_AIRPORT_2.Visible = True
    '            Me.TblF_EXPRESS_2.Visible = False
    '            Me.TblF_LOCAL_2.Visible = False
    '            CmnModule.SetEnabled(Me.F_DATE_2, False)
    '            CmnModule.SetEnabled(Me.F_AIRPORT1_2, False)
    '            CmnModule.SetEnabled(Me.F_AIRPORT2_2, False)
    '            CmnModule.SetEnabled(Me.F_EXPRESS1_2, False)
    '            CmnModule.SetEnabled(Me.F_EXPRESS2_2, False)
    '            CmnModule.SetEnabled(Me.F_LOCAL1_2, False)
    '            CmnModule.SetEnabled(Me.F_LOCAL2_2, False)
    '            CmnModule.SetEnabled(Me.F_TIME1_2, False)
    '            CmnModule.SetEnabled(Me.F_TIME2_2, False)
    '            CmnModule.SetEnabled(Me.F_BIN_2, False)
    '            CmnModule.SetEnabled(Me.F_SEAT_2, False)
    '            'トップツアーのみ
    '            If Session.Item(SessionDef.UserType) = AppConst.UserType.Admin Then
    '                CmnModule.SetEnabled(Me.F_SEATCLASS_2, False)
    '            End If
    '        End If

    '        If Me.F_KOTSU_KUBUN_3_AIR.Checked = True Then
    '            Me.TblF_AIRPORT_3.Visible = True
    '            Me.TblF_EXPRESS_3.Visible = False
    '            Me.TblF_LOCAL_3.Visible = False
    '        ElseIf Me.F_KOTSU_KUBUN_3_JR.Checked = True Then
    '            Me.TblF_AIRPORT_3.Visible = False
    '            Me.TblF_EXPRESS_3.Visible = True
    '            Me.TblF_LOCAL_3.Visible = True
    '        Else
    '            Me.TblF_AIRPORT_3.Visible = True
    '            Me.TblF_EXPRESS_3.Visible = False
    '            Me.TblF_LOCAL_3.Visible = False
    '            CmnModule.SetEnabled(Me.F_DATE_3, False)
    '            CmnModule.SetEnabled(Me.F_AIRPORT1_3, False)
    '            CmnModule.SetEnabled(Me.F_AIRPORT2_3, False)
    '            CmnModule.SetEnabled(Me.F_EXPRESS1_3, False)
    '            CmnModule.SetEnabled(Me.F_EXPRESS2_3, False)
    '            CmnModule.SetEnabled(Me.F_LOCAL1_3, False)
    '            CmnModule.SetEnabled(Me.F_LOCAL2_3, False)
    '            CmnModule.SetEnabled(Me.F_TIME1_3, False)
    '            CmnModule.SetEnabled(Me.F_TIME2_3, False)
    '            CmnModule.SetEnabled(Me.F_BIN_3, False)
    '            CmnModule.SetEnabled(Me.F_SEAT_3, False)
    '            'トップツアーのみ
    '            If Session.Item(SessionDef.UserType) = AppConst.UserType.Admin Then
    '                CmnModule.SetEnabled(Me.F_SEATCLASS_3, False)
    '            End If
    '        End If

    '        '座席希望
    '        SetSEAT()
    '    End If
    'End Sub

    ''手配の値を呼び出し元の画面に返す
    'Public Function GetTEHAI_HOTEL_Yes() As RadioButton
    '    Return Me.TEHAI_HOTEL_Yes
    'End Function
    'Public Function GetTEHAI_HOTEL_No() As RadioButton
    '    Return Me.TEHAI_HOTEL_No
    'End Function

    'Public Function GetTEHAI_KOTSU_Yes() As RadioButton
    '    Return Me.TEHAI_KOTSU_Yes
    'End Function
    'Public Function GetTEHAI_KOTSU_No() As RadioButton
    '    Return Me.TEHAI_KOTSU_No
    'End Function

    ''同伴者有無 変更時
    'Protected Sub ACCOMPANY_FLAG_Yes_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ACCOMPANY_FLAG_Yes.CheckedChanged
    '    Me.TrTEHAI_HOTEL_5.Visible = True
    '    Me.DivACCOMPANY.Visible = True
    '    SetHOTEL()
    '    Page.SetFocus(Me.ACCOMPANY_FLAG_Yes)
    'End Sub
    'Protected Sub ACCOMPANY_FLAG_No_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ACCOMPANY_FLAG_No.CheckedChanged
    '    Me.TrTEHAI_HOTEL_5.Visible = False
    '    Me.DivACCOMPANY.Visible = False
    '    Page.SetFocus(Me.ACCOMPANY_FLAG_No)
    'End Sub

    ''同伴者宿泊 変更時
    'Protected Sub ACCOMPANY_STAY_Yes_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ACCOMPANY_STAY_Yes.CheckedChanged
    '    SetHOTEL(True)
    '    Page.SetFocus(Me.ACCOMPANY_STAY_Yes)
    'End Sub
    'Protected Sub ACCOMPANY_STAY_No_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ACCOMPANY_STAY_No.CheckedChanged
    '    Me.DivACCOMPANY.Visible = False
    '    Page.SetFocus(Me.ACCOMPANY_STAY_No)
    'End Sub

    ''チケット送付先 変更時
    'Private Sub SEND_SAKI_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SEND_SAKI.SelectedIndexChanged
    '    If Not CmnCheck.IsInput(Me.SEND_SAKI) Then
    '        Me.TrSEND_SAKI_1.Visible = False
    '        Me.TrSEND_SAKI_2.Visible = False
    '        Me.TrSEND_SAKI_3.Visible = False
    '    Else
    '        Me.TrSEND_SAKI_1.Visible = True
    '        Me.TrSEND_SAKI_2.Visible = True
    '        Me.TrSEND_SAKI_3.Visible = True

    '        Select Case SEND_SAKI.SelectedItem.Value
    '            Case AppConst.SEND_SAKI.Code.MemberOffice
    '                Dim MS_MEMBER As TableDef.MS_MEMBER.DataStruct
    '                MS_MEMBER = Session.Item(SessionDef.MS_MEMBER)
    '                If Trim(MS_MEMBER.MEMBER_ID) <> "" Then
    '                    AppModule.SetForm_SEND_ZIP(MS_MEMBER.ZIP, Me.SEND_ZIP_1, Me.SEND_ZIP_2)
    '                    AppModule.SetForm_SEND_ADDRESS(MS_MEMBER.ADDRESS, Me.SEND_ADDRESS)
    '                    AppModule.SetForm_SEND_NAME(MS_MEMBER.MEMBER_NAME, Me.SEND_NAME)
    '                    AppModule.SetForm_SEND_TEL(MS_MEMBER.TEL, Me.SEND_TEL_1, Me.SEND_TEL_2, Me.SEND_TEL_3)
    '                End If
    '            Case Else
    '                CmnModule.ClearControl(Me.SEND_ZIP_1)
    '                CmnModule.ClearControl(Me.SEND_ZIP_2)
    '                CmnModule.ClearControl(Me.SEND_ADDRESS)
    '                CmnModule.ClearControl(Me.SEND_NAME)
    '                CmnModule.ClearControl(Me.SEND_TEL_1)
    '                CmnModule.ClearControl(Me.SEND_TEL_2)
    '                CmnModule.ClearControl(Me.SEND_TEL_3)
    '        End Select
    '    End If
    '    Page.SetFocus(Me.SEND_SAKI)
    'End Sub

    ''航空便利用時
    'Private Sub O_KOTSU_KUBUN_AIR_1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_KOTSU_KUBUN_1_AIR.CheckedChanged
    '    SetKOTSU()
    '    SetMILAGE_NO()
    '    Page.SetFocus(Me.O_KOTSU_KUBUN_1_AIR)
    'End Sub
    'Private Sub O_KOTSU_KUBUN_AIR_2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_KOTSU_KUBUN_2_AIR.CheckedChanged
    '    SetKOTSU()
    '    SetMILAGE_NO()
    '    Page.SetFocus(Me.O_KOTSU_KUBUN_2_AIR)
    'End Sub
    'Private Sub O_KOTSU_KUBUN_AIR_3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_KOTSU_KUBUN_3_AIR.CheckedChanged
    '    SetKOTSU()
    '    SetMILAGE_NO()
    '    Page.SetFocus(Me.O_KOTSU_KUBUN_3_AIR)
    'End Sub
    'Private Sub F_KOTSU_KUBUN_AIR_1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_KOTSU_KUBUN_1_AIR.CheckedChanged
    '    SetKOTSU()
    '    SetMILAGE_NO()
    '    Page.SetFocus(Me.F_KOTSU_KUBUN_1_AIR)
    'End Sub
    'Private Sub F_KOTSU_KUBUN_AIR_2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_KOTSU_KUBUN_2_AIR.CheckedChanged
    '    SetKOTSU()
    '    SetMILAGE_NO()
    '    Page.SetFocus(Me.F_KOTSU_KUBUN_2_AIR)
    'End Sub
    'Private Sub F_KOTSU_KUBUN_AIR_3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_KOTSU_KUBUN_3_AIR.CheckedChanged
    '    SetKOTSU()
    '    SetMILAGE_NO()
    '    Page.SetFocus(Me.F_KOTSU_KUBUN_3_AIR)
    'End Sub

    ''JR利用時
    'Private Sub O_KOTSU_KUBUN_JR_1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_KOTSU_KUBUN_1_JR.CheckedChanged
    '    SetKOTSU()
    '    Page.SetFocus(Me.O_KOTSU_KUBUN_1_JR)
    'End Sub
    'Private Sub O_KOTSU_KUBUN_JR_2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_KOTSU_KUBUN_2_JR.CheckedChanged
    '    SetKOTSU()
    '    Page.SetFocus(Me.O_KOTSU_KUBUN_2_JR)
    'End Sub
    'Private Sub O_KOTSU_KUBUN_JR_3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_KOTSU_KUBUN_3_JR.CheckedChanged
    '    SetKOTSU()
    '    Page.SetFocus(Me.O_KOTSU_KUBUN_3_JR)
    'End Sub
    'Private Sub F_KOTSU_KUBUN_JR_1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_KOTSU_KUBUN_1_JR.CheckedChanged
    '    SetKOTSU()
    '    Page.SetFocus(Me.F_KOTSU_KUBUN_1_JR)
    'End Sub
    'Private Sub F_KOTSU_KUBUN_JR_2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_KOTSU_KUBUN_2_JR.CheckedChanged
    '    SetKOTSU()
    '    Page.SetFocus(Me.F_KOTSU_KUBUN_2_JR)
    'End Sub
    'Private Sub F_KOTSU_KUBUN_JR_3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_KOTSU_KUBUN_3_JR.CheckedChanged
    '    SetKOTSU()
    '    Page.SetFocus(Me.F_KOTSU_KUBUN_3_JR)
    'End Sub

    ''利用なし
    'Private Sub O_KOTSU_KUBUN_None_1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_KOTSU_KUBUN_1_None.CheckedChanged
    '    SetKOTSU()
    '    Page.SetFocus(Me.O_KOTSU_KUBUN_1_None)
    'End Sub
    'Private Sub O_KOTSU_KUBUN_None_2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_KOTSU_KUBUN_2_None.CheckedChanged
    '    SetKOTSU()
    '    Page.SetFocus(Me.O_KOTSU_KUBUN_2_None)
    'End Sub
    'Private Sub O_KOTSU_KUBUN_None_3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_KOTSU_KUBUN_3_None.CheckedChanged
    '    SetKOTSU()
    '    Page.SetFocus(Me.O_KOTSU_KUBUN_3_None)
    'End Sub
    'Private Sub F_KOTSU_KUBUN_None_1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_KOTSU_KUBUN_1_None.CheckedChanged
    '    SetKOTSU()
    '    Page.SetFocus(Me.F_KOTSU_KUBUN_1_None)
    'End Sub
    'Private Sub F_KOTSU_KUBUN_None_2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_KOTSU_KUBUN_2_None.CheckedChanged
    '    SetKOTSU()
    '    Page.SetFocus(Me.F_KOTSU_KUBUN_2_None)
    'End Sub
    'Private Sub F_KOTSU_KUBUN_None_3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_KOTSU_KUBUN_3_None.CheckedChanged
    '    SetKOTSU()
    '    Page.SetFocus(Me.F_KOTSU_KUBUN_3_None)
    'End Sub

    ''同室者人数 変更時
    'Protected Sub ACCOMPANY_ADULT_SU_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ACCOMPANY_ADULT_SU.SelectedIndexChanged
    '    SetACCOMPANY_CHILD_BED()
    '    Page.SetFocus(Me.ACCOMPANY_ADULT_SU)
    'End Sub
    'Protected Sub ACCOMPANY_CHILD_SU_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ACCOMPANY_CHILD_SU.SelectedIndexChanged
    '    If CmnCheck.IsInput(Me.ACCOMPANY_CHILD_SU) Then
    '        Me.TblACCOMPANY_CHILD.Visible = True
    '        Me.TrACCOMPANY_CHILD_1.Visible = False
    '        Me.TrACCOMPANY_CHILD_2.Visible = False
    '        Select Case CmnModule.GetSelectedItemValue(Me.ACCOMPANY_CHILD_SU)
    '            Case "1"
    '                Me.TrACCOMPANY_CHILD_1.Visible = True
    '            Case "2"
    '                Me.TrACCOMPANY_CHILD_1.Visible = True
    '                Me.TrACCOMPANY_CHILD_2.Visible = True
    '        End Select
    '        SetACCOMPANY_CHILD_BED()
    '    Else
    '        Me.TblACCOMPANY_CHILD.Visible = False
    '    End If
    '    Page.SetFocus(Me.ACCOMPANY_CHILD_SU)
    'End Sub

    ''マイレージ入力欄設定
    'Private Sub SetMILAGE_NO()
    '    '航空利用があれば、マイレージ入力欄 表示
    '    If Me.O_KOTSU_KUBUN_1_AIR.Checked = True OrElse Me.O_KOTSU_KUBUN_2_AIR.Checked = True OrElse Me.O_KOTSU_KUBUN_3_AIR.Checked = True OrElse _
    '       Me.F_KOTSU_KUBUN_1_AIR.Checked = True OrElse Me.F_KOTSU_KUBUN_2_AIR.Checked = True OrElse Me.F_KOTSU_KUBUN_3_AIR.Checked = True Then
    '        Me.TrTEHAI_KOTSU_4.Visible = True
    '    Else
    '        Me.TrTEHAI_KOTSU_4.Visible = False
    '    End If
    'End Sub

    ''同伴者宿泊時の設定
    'Private Sub SetACCOMPANY_CHILD_BED()
    '    'If Me.TEHAI_HOTEL_Yes.Checked = False Then
    '    '    '宿泊なし
    '    '    Me.ROOM_TYPE.Value = ""
    '    'Else
    '    '    '宿泊あり
    '    '    Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Single
    '    '    If Me.ACCOMPANY_FLAG_Yes.Checked = False Then
    '    '        '同伴者なし
    '    '        Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Single
    '    '    Else
    '    '        If Me.ACCOMPANY_STAY_Yes.Checked = False Then
    '    '            '同伴者宿泊なし
    '    '            Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Single
    '    '        Else
    '    '            '同伴者宿泊あり
    '    '            If Not CmnCheck.IsInput(Me.ACCOMPANY_CHILD_SU) Then
    '    '                '小人なし
    '    '                Select Case CmnModule.GetSelectedItemValue(Me.ACCOMPANY_ADULT_SU)
    '    '                    Case "1"
    '    '                        '大人1人
    '    '                        Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Twin
    '    '                    Case "2"
    '    '                        '大人2人
    '    '                        Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Triple
    '    '                    Case Else
    '    '                        '大人なし
    '    '                        Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Single
    '    '                End Select
    '    '            Else
    '    '                '小人あり
    '    '                Select Case CmnModule.GetSelectedItemValue(Me.ACCOMPANY_ADULT_SU)
    '    '                    Case "1"
    '    '                        '大人1人
    '    '                        CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_1_Yes, True)
    '    '                        CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_1_No, True)
    '    '                        CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_2_Yes, True)
    '    '                        CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_2_No, True)

    '    '                        Select Case CmnModule.GetSelectedItemValue(Me.ACCOMPANY_CHILD_SU)
    '    '                            Case "1"
    '    '                                '小人1人
    '    '                                If Me.ACCOMPANY_CHILD_BED_1_Yes.Checked = True Then
    '    '                                    'ベッド必要
    '    '                                    Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Triple
    '    '                                Else
    '    '                                    'ベッド不要
    '    '                                    Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Twin
    '    '                                End If
    '    '                            Case "2"
    '    '                                '小人2人
    '    '                                'ベッド必要は1人のみ
    '    '                                If Me.ACCOMPANY_CHILD_BED_1_Yes.Checked = True Then
    '    '                                    Me.ACCOMPANY_CHILD_BED_2_No.Checked = True
    '    '                                    CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_2_Yes, False)
    '    '                                ElseIf Me.ACCOMPANY_CHILD_BED_2_Yes.Checked = True Then
    '    '                                    Me.ACCOMPANY_CHILD_BED_1_No.Checked = True
    '    '                                    CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_1_Yes, False)
    '    '                                End If
    '    '                                If Me.ACCOMPANY_CHILD_BED_1_Yes.Checked = True OrElse Me.ACCOMPANY_CHILD_BED_2_Yes.Checked = True Then
    '    '                                    'ベッド必要
    '    '                                    Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Triple
    '    '                                Else
    '    '                                    'ベッド不要
    '    '                                    Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Twin
    '    '                                End If
    '    '                        End Select
    '    '                    Case "2"
    '    '                        '大人2人
    '    '                        CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_1_Yes, False)
    '    '                        CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_1_No, True)
    '    '                        CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_2_Yes, False)
    '    '                        CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_2_No, True)

    '    '                        '小人ベッド必要は不可
    '    '                        Select Case CmnModule.GetSelectedItemValue(Me.ACCOMPANY_CHILD_SU)
    '    '                            Case "1"
    '    '                                '小人1人
    '    '                                CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_1_Yes, False)
    '    '                                Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Triple
    '    '                            Case "2"
    '    '                                '小人2人
    '    '                                CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_1_Yes, False)
    '    '                                CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_2_Yes, False)
    '    '                                Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Triple
    '    '                        End Select
    '    '                    Case Else
    '    '                        '大人なしの場合
    '    '                        CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_1_Yes, True)
    '    '                        CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_1_No, True)
    '    '                        CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_2_Yes, True)
    '    '                        CmnModule.SetEnabled(Me.ACCOMPANY_CHILD_BED_2_No, True)

    '    '                        Select Case CmnModule.GetSelectedItemValue(Me.ACCOMPANY_CHILD_SU)
    '    '                            Case "1"
    '    '                                '小人1人
    '    '                                If Me.ACCOMPANY_CHILD_BED_1_Yes.Checked = True Then
    '    '                                    'ベッド必要
    '    '                                    Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Twin
    '    '                                Else
    '    '                                    'ベッド不要
    '    '                                    Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Single
    '    '                                End If
    '    '                            Case "2"
    '    '                                '小人2人
    '    '                                If Me.ACCOMPANY_CHILD_BED_1_Yes.Checked = True AndAlso Me.ACCOMPANY_CHILD_BED_2_Yes.Checked = True Then
    '    '                                    '2人ともベッド必要
    '    '                                    Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Triple
    '    '                                ElseIf Me.ACCOMPANY_CHILD_BED_1_Yes.Checked = False AndAlso Me.ACCOMPANY_CHILD_BED_2_Yes.Checked = False Then
    '    '                                    '2人ともベッド不要
    '    '                                    Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Single
    '    '                                Else
    '    '                                    '1人がベッド必要
    '    '                                    Me.ROOM_TYPE.Value = AppConst.ROOM_TYPE.Twin
    '    '                                End If
    '    '                        End Select
    '    '                End Select
    '    '            End If
    '    '        End If
    '    '    End If
    '    'End If
    'End Sub

    ''小人ベッド 変更時
    'Protected Sub ACCOMPANY_CHILD_BED_1_Yes_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ACCOMPANY_CHILD_BED_1_Yes.CheckedChanged
    '    SetACCOMPANY_CHILD_BED()
    '    Page.SetFocus(Me.ACCOMPANY_CHILD_BED_1_Yes)
    'End Sub
    'Protected Sub ACCOMPANY_CHILD_BED_1_No_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ACCOMPANY_CHILD_BED_1_No.CheckedChanged
    '    SetACCOMPANY_CHILD_BED()
    '    Page.SetFocus(Me.ACCOMPANY_CHILD_BED_1_No)
    'End Sub
    'Protected Sub ACCOMPANY_CHILD_BED_2_Yes_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ACCOMPANY_CHILD_BED_2_Yes.CheckedChanged
    '    SetACCOMPANY_CHILD_BED()
    '    Page.SetFocus(Me.ACCOMPANY_CHILD_BED_2_Yes)
    'End Sub
    'Protected Sub ACCOMPANY_CHILD_BED_2_No_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ACCOMPANY_CHILD_BED_2_No.CheckedChanged
    '    SetACCOMPANY_CHILD_BED()
    '    Page.SetFocus(Me.ACCOMPANY_CHILD_BED_2_No)
    'End Sub

    ''ドクターと同室 変更時
    'Protected Sub ACCOMPANY_SAME_ROOM_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ACCOMPANY_SAME_ROOM.CheckedChanged
    '    If Me.ACCOMPANY_SAME_ROOM.Checked = True Then
    '        Me.TblACCOMPANY.Visible = True
    '        SetHOTEL()
    '        SetACCOMPANY_CHILD_BED()
    '    Else
    '        Me.TblACCOMPANY.Visible = False
    '    End If
    '    Page.SetFocus(Me.ACCOMPANY_SAME_ROOM)
    'End Sub

    'Private Sub O_EXPRESS1_1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_EXPRESS1_1.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub O_EXPRESS2_1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_EXPRESS2_1.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub O_EXPRESS1_2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_EXPRESS1_2.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub O_EXPRESS2_2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_EXPRESS2_2.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub O_EXPRESS1_3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_EXPRESS1_3.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub O_EXPRESS2_3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_EXPRESS2_3.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub F_EXPRESS1_1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_EXPRESS1_1.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub F_EXPRESS2_1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_EXPRESS2_1.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub F_EXPRESS1_2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_EXPRESS1_2.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub F_EXPRESS2_2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_EXPRESS2_2.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub F_EXPRESS1_3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_EXPRESS1_3.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub F_EXPRESS2_3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_EXPRESS2_3.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub O_LOCAL1_1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_LOCAL1_1.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub O_LOCAL2_1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_LOCAL2_1.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub O_LOCAL1_2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_LOCAL1_2.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub O_LOCAL2_2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_LOCAL2_2.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub O_LOCAL1_3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_LOCAL1_3.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub O_LOCAL2_3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles O_LOCAL2_3.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub F_LOCAL1_1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_LOCAL1_1.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub F_LOCAL2_1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_LOCAL2_1.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub F_LOCAL1_2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_LOCAL1_2.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub F_LOCAL2_2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_LOCAL2_2.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub F_LOCAL1_3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_LOCAL1_3.TextChanged
    '    SetSEAT()
    'End Sub
    'Private Sub F_LOCAL2_3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles F_LOCAL2_3.TextChanged
    '    SetSEAT()
    'End Sub

    ''座席希望
    'Private Sub SetSEAT()
    '    'JR利用で乗車区間のみの時は、座席希望なし
    '    If Me.O_KOTSU_KUBUN_1_JR.Checked = True AndAlso Not CmnCheck.IsInput(Me.O_EXPRESS1_1, Me.O_EXPRESS2_1) AndAlso CmnCheck.IsInput(Me.O_LOCAL1_1, Me.O_LOCAL2_1) Then
    '        CmnModule.SetEnabled(Me.O_SEAT_1, False)
    '    Else
    '        If Me.O_KOTSU_KUBUN_1_AIR.Checked = True OrElse Me.O_KOTSU_KUBUN_1_JR.Checked = True Then
    '            CmnModule.SetEnabled(Me.O_SEAT_1, True)
    '        End If
    '    End If
    '    If Me.O_KOTSU_KUBUN_2_JR.Checked = True AndAlso Not CmnCheck.IsInput(Me.O_EXPRESS1_2, Me.O_EXPRESS2_2) AndAlso CmnCheck.IsInput(Me.O_LOCAL1_2, Me.O_LOCAL2_2) Then
    '        CmnModule.SetEnabled(Me.O_SEAT_2, False)
    '    Else
    '        If Me.O_KOTSU_KUBUN_2_AIR.Checked = True OrElse Me.O_KOTSU_KUBUN_2_JR.Checked = True Then
    '            CmnModule.SetEnabled(Me.O_SEAT_2, True)
    '        End If
    '    End If
    '    If Me.O_KOTSU_KUBUN_3_JR.Checked = True AndAlso Not CmnCheck.IsInput(Me.O_EXPRESS1_3, Me.O_EXPRESS2_3) AndAlso CmnCheck.IsInput(Me.O_LOCAL1_3, Me.O_LOCAL2_3) Then
    '        CmnModule.SetEnabled(Me.O_SEAT_3, False)
    '    Else
    '        If Me.O_KOTSU_KUBUN_3_AIR.Checked = True OrElse Me.O_KOTSU_KUBUN_3_JR.Checked = True Then
    '            CmnModule.SetEnabled(Me.O_SEAT_3, True)
    '        End If
    '    End If
    '    If Me.F_KOTSU_KUBUN_1_JR.Checked = True AndAlso Not CmnCheck.IsInput(Me.F_EXPRESS1_1, Me.F_EXPRESS2_1) AndAlso CmnCheck.IsInput(Me.F_LOCAL1_1, Me.F_LOCAL2_1) Then
    '        CmnModule.SetEnabled(Me.F_SEAT_1, False)
    '    Else
    '        If Me.F_KOTSU_KUBUN_1_AIR.Checked = True OrElse Me.F_KOTSU_KUBUN_1_JR.Checked = True Then
    '            CmnModule.SetEnabled(Me.F_SEAT_1, True)
    '        End If
    '    End If
    '    If Me.F_KOTSU_KUBUN_2_JR.Checked = True AndAlso Not CmnCheck.IsInput(Me.F_EXPRESS1_2, Me.F_EXPRESS2_2) AndAlso CmnCheck.IsInput(Me.F_LOCAL1_2, Me.F_LOCAL2_2) Then
    '        CmnModule.SetEnabled(Me.F_SEAT_2, False)
    '    Else
    '        If Me.F_KOTSU_KUBUN_2_AIR.Checked = True OrElse Me.F_KOTSU_KUBUN_2_JR.Checked = True Then
    '            CmnModule.SetEnabled(Me.F_SEAT_2, True)
    '        End If
    '    End If
    '    If Me.F_KOTSU_KUBUN_3_JR.Checked = True AndAlso Not CmnCheck.IsInput(Me.F_EXPRESS1_3, Me.F_EXPRESS2_3) AndAlso CmnCheck.IsInput(Me.F_LOCAL1_3, Me.F_LOCAL2_3) Then
    '        CmnModule.SetEnabled(Me.F_SEAT_3, False)
    '    Else
    '        If Me.F_KOTSU_KUBUN_3_AIR.Checked = True OrElse Me.F_KOTSU_KUBUN_3_JR.Checked = True Then
    '            CmnModule.SetEnabled(Me.F_SEAT_3, True)
    '        End If
    '    End If
    '    SetMILAGE_NO()
    'End Sub

    Private Sub BtnKOTSU_O_1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnKOTSU_O_1.Click
        If BtnKOTSU_O_1.ImageUrl = IMG_CLOSE Then
            BtnKOTSU_O_1.ImageUrl = IMG_OPEN
            TB_KOTSU_O_1.Visible = False
        Else
            BtnKOTSU_O_1.ImageUrl = IMG_CLOSE
            TB_KOTSU_O_1.Visible = True
        End If
    End Sub

    Private Sub BtnKOTSU_O_2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnKOTSU_O_2.Click
        If BtnKOTSU_O_2.ImageUrl = IMG_CLOSE Then
            BtnKOTSU_O_2.ImageUrl = IMG_OPEN
            TB_KOTSU_O_2.Visible = False
        Else
            BtnKOTSU_O_2.ImageUrl = IMG_CLOSE
            TB_KOTSU_O_2.Visible = True
        End If
    End Sub

    Private Sub BtnKOTSU_O_3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnKOTSU_O_3.Click
        If BtnKOTSU_O_3.ImageUrl = IMG_CLOSE Then
            BtnKOTSU_O_3.ImageUrl = IMG_OPEN
            TB_KOTSU_O_3.Visible = False
        Else
            BtnKOTSU_O_3.ImageUrl = IMG_CLOSE
            TB_KOTSU_O_3.Visible = True
        End If
    End Sub

    Private Sub BtnKOTSU_O_4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnKOTSU_O_4.Click
        If BtnKOTSU_O_4.ImageUrl = IMG_CLOSE Then
            BtnKOTSU_O_4.ImageUrl = IMG_OPEN
            TB_KOTSU_O_4.Visible = False
        Else
            BtnKOTSU_O_4.ImageUrl = IMG_CLOSE
            TB_KOTSU_O_4.Visible = True
        End If
    End Sub

    Private Sub BtnKOTSU_O_5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnKOTSU_O_5.Click
        If BtnKOTSU_O_5.ImageUrl = IMG_CLOSE Then
            BtnKOTSU_O_5.ImageUrl = IMG_OPEN
            TB_KOTSU_O_5.Visible = False
        Else
            BtnKOTSU_O_5.ImageUrl = IMG_CLOSE
            TB_KOTSU_O_5.Visible = True
        End If
    End Sub

    Private Sub BtnKOTSU_F_1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnKOTSU_F_1.Click
        If BtnKOTSU_F_1.ImageUrl = IMG_CLOSE Then
            BtnKOTSU_F_1.ImageUrl = IMG_OPEN
            TB_KOTSU_F_1.Visible = False
        Else
            BtnKOTSU_F_1.ImageUrl = IMG_CLOSE
            TB_KOTSU_F_1.Visible = True
        End If
    End Sub

    Private Sub BtnKOTSU_F_2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnKOTSU_F_2.Click
        If BtnKOTSU_F_2.ImageUrl = IMG_CLOSE Then
            BtnKOTSU_F_2.ImageUrl = IMG_OPEN
            TB_KOTSU_F_2.Visible = False
        Else
            BtnKOTSU_F_2.ImageUrl = IMG_CLOSE
            TB_KOTSU_F_2.Visible = True
        End If
    End Sub

    Private Sub BtnKOTSU_F_3_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnKOTSU_F_3.Click
        If BtnKOTSU_F_3.ImageUrl = IMG_CLOSE Then
            BtnKOTSU_F_3.ImageUrl = IMG_OPEN
            TB_KOTSU_F_3.Visible = False
        Else
            BtnKOTSU_F_3.ImageUrl = IMG_CLOSE
            TB_KOTSU_F_3.Visible = True
        End If
    End Sub

    Private Sub BtnKOTSU_F_4_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnKOTSU_F_4.Click
        If BtnKOTSU_F_4.ImageUrl = IMG_CLOSE Then
            BtnKOTSU_F_4.ImageUrl = IMG_OPEN
            TB_KOTSU_F_4.Visible = False
        Else
            BtnKOTSU_F_4.ImageUrl = IMG_CLOSE
            TB_KOTSU_F_4.Visible = True
        End If
    End Sub

    Private Sub BtnKOTSU_F_5_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnKOTSU_F_5.Click
        If BtnKOTSU_F_5.ImageUrl = IMG_CLOSE Then
            BtnKOTSU_F_5.ImageUrl = IMG_OPEN
            TB_KOTSU_F_5.Visible = False
        Else
            BtnKOTSU_F_5.ImageUrl = IMG_CLOSE
            TB_KOTSU_F_5.Visible = True
        End If
    End Sub

    Private Sub BtnTAXI_1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles BtnTAXI_1.Click
        If BtnTAXI_1.ImageUrl = IMG_CLOSE Then
            BtnTAXI_1.ImageUrl = IMG_OPEN
            TB_TAXI_1.Visible = False
        Else
            BtnTAXI_1.ImageUrl = IMG_CLOSE
            TB_TAXI_1.Visible = True
        End If
    End Sub

    ''' <summary>
    ''' 施設検索ボタン
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub BtnHotelKensaku_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnHotelKensaku.Click
        Dim scriptStr As String
        scriptStr = "<script type='text/javascript'>"
        scriptStr += "window.open('" & URL.HotelKensaku & "','_blank','width=1000,height=600');"
        scriptStr += "</script>"

        ClientScript.RegisterStartupScript(Me.GetType(), "施設検索", scriptStr)
    End Sub

    '最新版データ存在チェック
    Private Function ChkNewData() As Boolean
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim NewCnt(0) As String
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_KOTSUHOTEL.byNEW_TIME_STAMP(DSP_KOTSUHOTEL(SEQ).SALEFORCE_ID, DSP_KOTSUHOTEL(SEQ).TIME_STAMP_BYL)

        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            NewCnt(0) = CmnDb.DbData(RsData.GetName(0), RsData)
        End If
        RsData.Close()

        If NewCnt(0) = "0" Then
            Return True
        Else
            Return False
        End If
    End Function

    '講演会基本情報ボタン
    Private Sub BtnKihon_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnKihon.Click
        '選択レコード情報をセッション変数にセット
        Session.Item(SessionDef.SEQ) = 0
        Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
        'Session.Item(SessionDef.PageIndex) = Me.GrvList.PageIndex
        Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
        Session.Item(SessionDef.BackURL2) = Request.Url.AbsolutePath

        '履歴画面用セッション変数をクリア
        Session.Remove(SessionDef.KaijoRireki)
        Session.Remove(SessionDef.KouenkaiRireki_PageIndex)
        Session.Remove(SessionDef.KouenkaiRireki_SEQ)
        Session.Item(SessionDef.KouenkaiRireki_TBL_KOUENKAI) = False

        Response.Redirect(URL.KouenkaiRegist)
    End Sub
End Class
