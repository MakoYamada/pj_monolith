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
        CmnModule.SetIme(Me.ANS_RAIL_FARE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_RAIL_CANCELLATION, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_OTHER_FARE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_AIR_FARE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_AIR_CANCELLATION, CmnModule.ImeType.Disabled)
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
        Me.ANS_RAIL_FARE.Text = AppModule.GetName_ANS_RAIL_FARE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_RAIL_FARE)
        Me.ANS_RAIL_CANCELLATION.Text = AppModule.GetName_ANS_RAIL_CANCELLATION(DSP_KOTSUHOTEL(DSP_SEQ).ANS_RAIL_CANCELLATION)
        Me.ANS_OTHER_FARE.Text = AppModule.GetName_ANS_OTHER_FARE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_OTHER_FARE)
        Me.ANS_OTHER_CANCELLATION.Text = AppModule.GetName_ANS_OTHER_CANCELLATION(DSP_KOTSUHOTEL(DSP_SEQ).ANS_OTHER_CANCELLATION)
        Me.ANS_AIR_FARE.Text = AppModule.GetName_ANS_AIR_FARE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_AIR_FARE)
        Me.ANS_AIR_CANCELLATION.Text = AppModule.GetName_ANS_AIR_CANCELLATION(DSP_KOTSUHOTEL(DSP_SEQ).ANS_AIR_CANCELLATION)

        'タクチケ手配
        Me.TEHAI_TAXI.Text = AppModule.GetName_TEHAI_TAXI(DSP_KOTSUHOTEL(DSP_SEQ).TEHAI_TAXI)
        Me.REQ_TAXI_NOTE.Text = AppModule.GetName_REQ_TAXI_NOTE(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_NOTE)
        Me.ANS_TAXI_NOTE.Text = AppModule.GetName_ANS_TAXI_NOTE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NOTE)

        'タクチケ（依頼）
        '行程１
        Me.REQ_TAXI_DATE_1.Text = AppModule.GetName_REQ_TAXI_DATE_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_1)
        Me.REQ_TAXI_FROM_1.Text = AppModule.GetName_REQ_TAXI_FROM_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_1)
        Me.TAXI_YOTEIKINGAKU_1.Text = AppModule.GetName_TAXI_YOTEIKINGAKU_1(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_1)
        '行程２
        Me.REQ_TAXI_DATE_2.Text = AppModule.GetName_REQ_TAXI_DATE_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_2)
        Me.REQ_TAXI_FROM_2.Text = AppModule.GetName_REQ_TAXI_FROM_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_2)
        Me.TAXI_YOTEIKINGAKU_2.Text = AppModule.GetName_TAXI_YOTEIKINGAKU_2(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_2)
        '行程３
        Me.REQ_TAXI_DATE_3.Text = AppModule.GetName_REQ_TAXI_DATE_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_3)
        Me.REQ_TAXI_FROM_3.Text = AppModule.GetName_REQ_TAXI_FROM_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_3)
        Me.TAXI_YOTEIKINGAKU_3.Text = AppModule.GetName_TAXI_YOTEIKINGAKU_3(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_3)
        '行程４
        Me.REQ_TAXI_DATE_4.Text = AppModule.GetName_REQ_TAXI_DATE_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_4)
        Me.REQ_TAXI_FROM_4.Text = AppModule.GetName_REQ_TAXI_FROM_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_4)
        Me.TAXI_YOTEIKINGAKU_4.Text = AppModule.GetName_TAXI_YOTEIKINGAKU_4(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_4)
        '行程５
        Me.REQ_TAXI_DATE_5.Text = AppModule.GetName_REQ_TAXI_DATE_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_5)
        Me.REQ_TAXI_FROM_5.Text = AppModule.GetName_REQ_TAXI_FROM_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_5)
        Me.TAXI_YOTEIKINGAKU_5.Text = AppModule.GetName_TAXI_YOTEIKINGAKU_5(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_5)
        '行程６
        Me.REQ_TAXI_DATE_6.Text = AppModule.GetName_REQ_TAXI_DATE_6(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_6)
        Me.REQ_TAXI_FROM_6.Text = AppModule.GetName_REQ_TAXI_FROM_6(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_6)
        Me.TAXI_YOTEIKINGAKU_6.Text = AppModule.GetName_TAXI_YOTEIKINGAKU_6(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_6)
        '行程７
        Me.REQ_TAXI_DATE_7.Text = AppModule.GetName_REQ_TAXI_DATE_7(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_7)
        Me.REQ_TAXI_FROM_7.Text = AppModule.GetName_REQ_TAXI_FROM_7(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_7)
        Me.TAXI_YOTEIKINGAKU_7.Text = AppModule.GetName_TAXI_YOTEIKINGAKU_7(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_7)
        '行程８
        Me.REQ_TAXI_DATE_8.Text = AppModule.GetName_REQ_TAXI_DATE_8(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_8)
        Me.REQ_TAXI_FROM_8.Text = AppModule.GetName_REQ_TAXI_FROM_8(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_8)
        Me.TAXI_YOTEIKINGAKU_8.Text = AppModule.GetName_TAXI_YOTEIKINGAKU_8(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_8)
        '行程９
        Me.REQ_TAXI_DATE_9.Text = AppModule.GetName_REQ_TAXI_DATE_9(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_9)
        Me.REQ_TAXI_FROM_9.Text = AppModule.GetName_REQ_TAXI_FROM_9(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_9)
        Me.TAXI_YOTEIKINGAKU_9.Text = AppModule.GetName_TAXI_YOTEIKINGAKU_9(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_9)
        '行程１０
        Me.REQ_TAXI_DATE_10.Text = AppModule.GetName_REQ_TAXI_DATE_10(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_10)
        Me.REQ_TAXI_FROM_10.Text = AppModule.GetName_REQ_TAXI_FROM_10(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_10)
        Me.TAXI_YOTEIKINGAKU_10.Text = AppModule.GetName_TAXI_YOTEIKINGAKU_10(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_10)

        'タクチケ１
        Me.ANS_TAXI_DATE_1.Text = AppModule.GetName_ANS_TAXI_DATE_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_1)
        Me.ANS_TAXI_KENSHU_1.Text = AppModule.GetName_ANS_TAXI_KENSHU_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_1)
        Me.ANS_TAXI_NO_1.Text = AppModule.GetName_ANS_TAXI_NO_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_1)
        'タクチケ２
        Me.ANS_TAXI_DATE_2.Text = AppModule.GetName_ANS_TAXI_DATE_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_2)
        Me.ANS_TAXI_KENSHU_2.Text = AppModule.GetName_ANS_TAXI_KENSHU_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_2)
        Me.ANS_TAXI_NO_2.Text = AppModule.GetName_ANS_TAXI_NO_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_2)
        'タクチケ３
        Me.ANS_TAXI_DATE_3.Text = AppModule.GetName_ANS_TAXI_DATE_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_3)
        Me.ANS_TAXI_KENSHU_3.Text = AppModule.GetName_ANS_TAXI_KENSHU_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_3)
        Me.ANS_TAXI_NO_3.Text = AppModule.GetName_ANS_TAXI_NO_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_3)
        'タクチケ４
        Me.ANS_TAXI_DATE_4.Text = AppModule.GetName_ANS_TAXI_DATE_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_4)
        Me.ANS_TAXI_KENSHU_4.Text = AppModule.GetName_ANS_TAXI_KENSHU_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_4)
        Me.ANS_TAXI_NO_4.Text = AppModule.GetName_ANS_TAXI_NO_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_4)
        'タクチケ５
        Me.ANS_TAXI_DATE_5.Text = AppModule.GetName_ANS_TAXI_DATE_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_5)
        Me.ANS_TAXI_KENSHU_5.Text = AppModule.GetName_ANS_TAXI_KENSHU_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_5)
        Me.ANS_TAXI_NO_5.Text = AppModule.GetName_ANS_TAXI_NO_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_5)
        'タクチケ６
        Me.ANS_TAXI_DATE_6.Text = AppModule.GetName_ANS_TAXI_DATE_6(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_6)
        Me.ANS_TAXI_KENSHU_6.Text = AppModule.GetName_ANS_TAXI_KENSHU_6(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_6)
        Me.ANS_TAXI_NO_6.Text = AppModule.GetName_ANS_TAXI_NO_6(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_6)
        'タクチケ７
        Me.ANS_TAXI_DATE_7.Text = AppModule.GetName_ANS_TAXI_DATE_7(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_7)
        Me.ANS_TAXI_KENSHU_7.Text = AppModule.GetName_ANS_TAXI_KENSHU_7(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_7)
        Me.ANS_TAXI_NO_7.Text = AppModule.GetName_ANS_TAXI_NO_7(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_7)
        'タクチケ８
        Me.ANS_TAXI_DATE_8.Text = AppModule.GetName_ANS_TAXI_DATE_8(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_8)
        Me.ANS_TAXI_KENSHU_8.Text = AppModule.GetName_ANS_TAXI_KENSHU_8(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_8)
        Me.ANS_TAXI_NO_8.Text = AppModule.GetName_ANS_TAXI_NO_8(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_8)
        'タクチケ９
        Me.ANS_TAXI_DATE_9.Text = AppModule.GetName_ANS_TAXI_DATE_9(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_9)
        Me.ANS_TAXI_KENSHU_9.Text = AppModule.GetName_ANS_TAXI_KENSHU_9(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_9)
        Me.ANS_TAXI_NO_9.Text = AppModule.GetName_ANS_TAXI_NO_9(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_9)
        'タクチケ１０
        Me.ANS_TAXI_DATE_10.Text = AppModule.GetName_ANS_TAXI_DATE_10(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_10)
        Me.ANS_TAXI_KENSHU_10.Text = AppModule.GetName_ANS_TAXI_KENSHU_10(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_10)
        Me.ANS_TAXI_NO_10.Text = AppModule.GetName_ANS_TAXI_NO_10(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_10)
        'タクチケ１１
        Me.ANS_TAXI_DATE_11.Text = AppModule.GetName_ANS_TAXI_DATE_11(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_11)
        Me.ANS_TAXI_KENSHU_11.Text = AppModule.GetName_ANS_TAXI_KENSHU_11(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_11)
        Me.ANS_TAXI_NO_11.Text = AppModule.GetName_ANS_TAXI_NO_11(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_11)
        'タクチケ１２
        Me.ANS_TAXI_DATE_12.Text = AppModule.GetName_ANS_TAXI_DATE_12(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_12)
        Me.ANS_TAXI_KENSHU_12.Text = AppModule.GetName_ANS_TAXI_KENSHU_12(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_12)
        Me.ANS_TAXI_NO_12.Text = AppModule.GetName_ANS_TAXI_NO_12(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_12)
        'タクチケ１３
        Me.ANS_TAXI_DATE_13.Text = AppModule.GetName_ANS_TAXI_DATE_13(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_13)
        Me.ANS_TAXI_KENSHU_13.Text = AppModule.GetName_ANS_TAXI_KENSHU_13(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_13)
        Me.ANS_TAXI_NO_13.Text = AppModule.GetName_ANS_TAXI_NO_13(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_13)
        'タクチケ１４
        Me.ANS_TAXI_DATE_14.Text = AppModule.GetName_ANS_TAXI_DATE_14(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_14)
        Me.ANS_TAXI_KENSHU_14.Text = AppModule.GetName_ANS_TAXI_KENSHU_14(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_14)
        Me.ANS_TAXI_NO_14.Text = AppModule.GetName_ANS_TAXI_NO_14(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_14)
        'タクチケ１５
        Me.ANS_TAXI_DATE_15.Text = AppModule.GetName_ANS_TAXI_DATE_15(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_15)
        Me.ANS_TAXI_KENSHU_15.Text = AppModule.GetName_ANS_TAXI_KENSHU_15(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_15)
        Me.ANS_TAXI_NO_15.Text = AppModule.GetName_ANS_TAXI_NO_15(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_15)
        'タクチケ１６
        Me.ANS_TAXI_DATE_16.Text = AppModule.GetName_ANS_TAXI_DATE_16(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_16)
        Me.ANS_TAXI_KENSHU_16.Text = AppModule.GetName_ANS_TAXI_KENSHU_16(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_16)
        Me.ANS_TAXI_NO_16.Text = AppModule.GetName_ANS_TAXI_NO_16(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_16)
        'タクチケ１７
        Me.ANS_TAXI_DATE_17.Text = AppModule.GetName_ANS_TAXI_DATE_17(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_17)
        Me.ANS_TAXI_KENSHU_17.Text = AppModule.GetName_ANS_TAXI_KENSHU_17(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_17)
        Me.ANS_TAXI_NO_17.Text = AppModule.GetName_ANS_TAXI_NO_17(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_17)
        'タクチケ１８
        Me.ANS_TAXI_DATE_18.Text = AppModule.GetName_ANS_TAXI_DATE_18(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_18)
        Me.ANS_TAXI_KENSHU_18.Text = AppModule.GetName_ANS_TAXI_KENSHU_18(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_18)
        Me.ANS_TAXI_NO_18.Text = AppModule.GetName_ANS_TAXI_NO_18(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_18)
        'タクチケ１９
        Me.ANS_TAXI_DATE_19.Text = AppModule.GetName_ANS_TAXI_DATE_19(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_19)
        Me.ANS_TAXI_KENSHU_19.Text = AppModule.GetName_ANS_TAXI_KENSHU_19(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_19)
        Me.ANS_TAXI_NO_19.Text = AppModule.GetName_ANS_TAXI_NO_19(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_19)
        'タクチケ２０
        Me.ANS_TAXI_DATE_20.Text = AppModule.GetName_ANS_TAXI_DATE_20(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_20)
        Me.ANS_TAXI_KENSHU_20.Text = AppModule.GetName_ANS_TAXI_KENSHU_20(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_20)
        Me.ANS_TAXI_NO_20.Text = AppModule.GetName_ANS_TAXI_NO_20(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_20)

        'MR手配情報
        Me.REQ_MR_O_TEHAI.Text = AppModule.GetName_REQ_MR_O_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).REQ_MR_O_TEHAI)
        Me.REQ_MR_F_TEHAI.Text = AppModule.GetName_REQ_MR_F_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).REQ_MR_F_TEHAI)
        Me.MR_SEX.Text = AppModule.GetName_MR_SEX(DSP_KOTSUHOTEL(DSP_SEQ).MR_SEX)
        Me.MR_AGE.Text = AppModule.GetName_MR_AGE(DSP_KOTSUHOTEL(DSP_SEQ).MR_AGE)
        Me.REQ_MR_TEHAI_HOTEL.Text = AppModule.GetName_REQ_MR_TEHAI_HOTEL(DSP_KOTSUHOTEL(DSP_SEQ).REQ_MR_HOTEL_SMOKING)
        Me.REQ_MR_HOTEL_SMOKING.Text = AppModule.GetName_REQ_MR_HOTEL_SMOKING(DSP_KOTSUHOTEL(DSP_SEQ).REQ_MR_TEHAI_HOTEL)
        Me.REQ_MR_HOTEL_NOTE.Text = AppModule.GetName_REQ_MR_HOTEL_NOTE(DSP_KOTSUHOTEL(DSP_SEQ).REQ_MR_HOTEL_NOTE)
        AppModule.SetForm_ANS_STATUS_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_O_TEHAI, Me.ANS_MR_O_TEHAI)
        AppModule.SetForm_ANS_STATUS_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_F_TEHAI, Me.ANS_MR_F_TEHAI)
        Me.ANS_MR_HOTEL_NAME.Text = AppModule.GetName_ANS_MR_HOTEL_NAME(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_HOTEL_NAME)
        Me.ANS_MR_HOTEL_ADDRESS.Text = AppModule.GetName_ANS_MR_HOTEL_ADDRESS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_HOTEL_ADDRESS)
        Me.ANS_MR_HOTEL_TEL.Text = AppModule.GetName_ANS_MR_HOTEL_TEL(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_HOTEL_TEL)
        Me.ANS_MR_CHECKIN_TIME.Text = AppModule.GetName_ANS_MR_CHECKIN_TIME(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_CHECKIN_TIME)
        Me.ANS_MR_CHECKOUT_TIME.Text = AppModule.GetName_ANS_MR_CHECKOUT_TIME(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_CHECKOUT_TIME)
        AppModule.SetForm_ANS_HOTEL_SMOKING(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_HOTEL_SMOKING, Me.ANS_MR_HOTEL_SMOKING)
        Me.ANS_MR_HOTEL_NOTE.Text = AppModule.GetName_ANS_MR_HOTEL_NOTE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_HOTEL_NOTE)
        Me.ANS_MR_KOTSUHI.Text = AppModule.GetName_ANS_MR_KOTSUHI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_KOTSUHI)
        Me.ANS_MR_HOTELHI.Text = AppModule.GetName_ANS_MR_HOTELHI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_HOTELHI)
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

    '[登録]
    Private Sub BtnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click
        If Not Check() Then Exit Sub

        '入力値を取得
        GetValue(AppConst.SEND_FLAG.Code.Mi)

        'データ更新
        If ExecuteTransaction() Then
        End If
    End Sub

    '[NOZOMIへ]
    Protected Sub BtnNozomi_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnNozomi.Click
        If Not Check() Then Exit Sub

        '入力値を取得
        GetValue(AppConst.SEND_FLAG.Code.Taisho)

        'データ更新
        If ExecuteTransaction() Then
        End If
    End Sub

    '[履歴表示]
    Private Sub BtnRireki_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnRireki.Click
        Session.Item(SessionDef.SEQ) = SEQ
        Session.Item(SessionDef.TBL_KOTSUHOTEL) = DSP_KOTSUHOTEL
        Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
        Response.Redirect(URL.DrRireki)
    End Sub

    '入力チェック
    Private Function Check() As Boolean
        'セキュリティチェック
        If Not CmnCheck.IsSecurityOK(Me) Then
            CmnModule.AlertMessage(MessageDef.Error.SecurityCheck, Me)
            Return False
        End If
        Return True
    End Function

    '入力値を取得
    Private Sub GetValue(ByVal SEND_FLAG As String)
        'DR手配
        DSP_KOTSUHOTEL(SEQ).ANS_STATUS_TEHAI = AppModule.GetValue_ANS_STATUS_TEHAI(Me.ANS_STATUS_TEHAI)

        '宿泊手配
        DSP_KOTSUHOTEL(SEQ).ANS_STATUS_HOTEL = AppModule.GetValue_ANS_STATUS_TEHAI(Me.ANS_STATUS_HOTEL)
        DSP_KOTSUHOTEL(SEQ).ANS_HOTEL_NAME = AppModule.GetValue_ANS_HOTEL_NAME(Me.ANS_HOTEL_NAME)
        DSP_KOTSUHOTEL(SEQ).ANS_HOTEL_ADDRESS = AppModule.GetValue_ANS_HOTEL_ADDRESS(Me.ANS_HOTEL_ADDRESS)
        DSP_KOTSUHOTEL(SEQ).ANS_HOTEL_TEL = AppModule.GetValue_ANS_HOTEL_TEL(Me.ANS_HOTEL_TEL)
        DSP_KOTSUHOTEL(SEQ).ANS_HOTEL_DATE = AppModule.GetValue_ANS_HOTEL_DATE(Me.ANS_HOTEL_DATE)
        DSP_KOTSUHOTEL(SEQ).ANS_HAKUSU = AppModule.GetValue_ANS_HAKUSU(Me.ANS_HAKUSU)
        DSP_KOTSUHOTEL(SEQ).ANS_CHECKIN_TIME = AppModule.GetValue_ANS_CHECKIN_TIME(Me.ANS_CHECKIN_TIME)
        DSP_KOTSUHOTEL(SEQ).ANS_CHECKOUT_TIME = AppModule.GetValue_ANS_CHECKOUT_TIME(Me.ANS_CHECKOUT_TIME)
        DSP_KOTSUHOTEL(SEQ).ANS_ROOM_TYPE = AppModule.GetValue_ANS_ROOM_TYPE(Me.ANS_ROOM_TYPE)
        DSP_KOTSUHOTEL(SEQ).ANS_HOTEL_SMOKING = AppModule.GetValue_ANS_HOTEL_SMOKING(Me.ANS_HOTEL_SMOKING)
        DSP_KOTSUHOTEL(SEQ).ANS_HOTEL_NOTE = AppModule.GetValue_ANS_HOTEL_NOTE(Me.ANS_HOTEL_NOTE)

        '交通（往路１）
        DSP_KOTSUHOTEL(SEQ).ANS_O_STATUS_1 = AppModule.GetValue_ANS_O_STATUS_1(Me.ANS_O_STATUS_1)
        DSP_KOTSUHOTEL(SEQ).ANS_O_DATE_1 = AppModule.GetValue_ANS_O_DATE_1(Me.ANS_O_DATE_1)
        DSP_KOTSUHOTEL(SEQ).ANS_O_AIRPORT1_1 = AppModule.GetValue_ANS_O_AIRPORT1_1(Me.ANS_O_AIRPORT1_1)
        DSP_KOTSUHOTEL(SEQ).ANS_O_AIRPORT2_1 = AppModule.GetValue_ANS_O_AIRPORT2_1(Me.ANS_O_AIRPORT2_1)
        DSP_KOTSUHOTEL(SEQ).ANS_O_TIME1_1 = AppModule.GetValue_ANS_O_TIME1_1(Me.ANS_O_TIME1_1)
        DSP_KOTSUHOTEL(SEQ).ANS_O_TIME2_1 = AppModule.GetValue_ANS_O_TIME2_1(Me.ANS_O_TIME2_1)
        DSP_KOTSUHOTEL(SEQ).ANS_O_BIN_1 = AppModule.GetValue_ANS_O_BIN_1(Me.ANS_O_BIN_1)
        DSP_KOTSUHOTEL(SEQ).ANS_O_SEAT_1 = AppModule.GetValue_ANS_O_SEAT_1(Me.ANS_O_SEAT_1)
        DSP_KOTSUHOTEL(SEQ).ANS_O_SEAT_KIBOU1 = AppModule.GetValue_ANS_O_SEAT_KIBOU1(Me.ANS_O_SEAT_KIBOU1)
        '交通（往路２）
        DSP_KOTSUHOTEL(SEQ).ANS_O_STATUS_2 = AppModule.GetValue_ANS_O_STATUS_2(Me.ANS_O_STATUS_2)
        DSP_KOTSUHOTEL(SEQ).ANS_O_DATE_2 = AppModule.GetValue_ANS_O_DATE_2(Me.ANS_O_DATE_2)
        DSP_KOTSUHOTEL(SEQ).ANS_O_AIRPORT1_2 = AppModule.GetValue_ANS_O_AIRPORT1_2(Me.ANS_O_AIRPORT1_2)
        DSP_KOTSUHOTEL(SEQ).ANS_O_AIRPORT2_2 = AppModule.GetValue_ANS_O_AIRPORT2_2(Me.ANS_O_AIRPORT2_2)
        DSP_KOTSUHOTEL(SEQ).ANS_O_TIME1_2 = AppModule.GetValue_ANS_O_TIME1_2(Me.ANS_O_TIME1_2)
        DSP_KOTSUHOTEL(SEQ).ANS_O_TIME2_2 = AppModule.GetValue_ANS_O_TIME2_2(Me.ANS_O_TIME2_2)
        DSP_KOTSUHOTEL(SEQ).ANS_O_BIN_2 = AppModule.GetValue_ANS_O_BIN_2(Me.ANS_O_BIN_2)
        DSP_KOTSUHOTEL(SEQ).ANS_O_SEAT_2 = AppModule.GetValue_ANS_O_SEAT_2(Me.ANS_O_SEAT_2)
        DSP_KOTSUHOTEL(SEQ).ANS_O_SEAT_KIBOU2 = AppModule.GetValue_ANS_O_SEAT_KIBOU2(Me.ANS_O_SEAT_KIBOU2)
        '交通（往路３）
        DSP_KOTSUHOTEL(SEQ).ANS_O_STATUS_3 = AppModule.GetValue_ANS_O_STATUS_3(Me.ANS_O_STATUS_3)
        DSP_KOTSUHOTEL(SEQ).ANS_O_DATE_3 = AppModule.GetValue_ANS_O_DATE_3(Me.ANS_O_DATE_3)
        DSP_KOTSUHOTEL(SEQ).ANS_O_AIRPORT1_3 = AppModule.GetValue_ANS_O_AIRPORT1_3(Me.ANS_O_AIRPORT1_3)
        DSP_KOTSUHOTEL(SEQ).ANS_O_AIRPORT2_3 = AppModule.GetValue_ANS_O_AIRPORT2_3(Me.ANS_O_AIRPORT2_3)
        DSP_KOTSUHOTEL(SEQ).ANS_O_TIME1_3 = AppModule.GetValue_ANS_O_TIME1_3(Me.ANS_O_TIME1_3)
        DSP_KOTSUHOTEL(SEQ).ANS_O_TIME2_3 = AppModule.GetValue_ANS_O_TIME2_3(Me.ANS_O_TIME2_3)
        DSP_KOTSUHOTEL(SEQ).ANS_O_BIN_3 = AppModule.GetValue_ANS_O_BIN_3(Me.ANS_O_BIN_3)
        DSP_KOTSUHOTEL(SEQ).ANS_O_SEAT_3 = AppModule.GetValue_ANS_O_SEAT_3(Me.ANS_O_SEAT_3)
        DSP_KOTSUHOTEL(SEQ).ANS_O_SEAT_KIBOU3 = AppModule.GetValue_ANS_O_SEAT_KIBOU3(Me.ANS_O_SEAT_KIBOU3)
        '交通（往路４）
        DSP_KOTSUHOTEL(SEQ).ANS_O_STATUS_4 = AppModule.GetValue_ANS_O_STATUS_4(Me.ANS_O_STATUS_4)
        DSP_KOTSUHOTEL(SEQ).ANS_O_DATE_4 = AppModule.GetValue_ANS_O_DATE_4(Me.ANS_O_DATE_4)
        DSP_KOTSUHOTEL(SEQ).ANS_O_AIRPORT1_4 = AppModule.GetValue_ANS_O_AIRPORT1_4(Me.ANS_O_AIRPORT1_4)
        DSP_KOTSUHOTEL(SEQ).ANS_O_AIRPORT2_4 = AppModule.GetValue_ANS_O_AIRPORT2_4(Me.ANS_O_AIRPORT2_4)
        DSP_KOTSUHOTEL(SEQ).ANS_O_TIME1_4 = AppModule.GetValue_ANS_O_TIME1_4(Me.ANS_O_TIME1_4)
        DSP_KOTSUHOTEL(SEQ).ANS_O_TIME2_4 = AppModule.GetValue_ANS_O_TIME2_4(Me.ANS_O_TIME2_4)
        DSP_KOTSUHOTEL(SEQ).ANS_O_BIN_4 = AppModule.GetValue_ANS_O_BIN_4(Me.ANS_O_BIN_4)
        DSP_KOTSUHOTEL(SEQ).ANS_O_SEAT_4 = AppModule.GetValue_ANS_O_SEAT_4(Me.ANS_O_SEAT_4)
        DSP_KOTSUHOTEL(SEQ).ANS_O_SEAT_KIBOU4 = AppModule.GetValue_ANS_O_SEAT_KIBOU4(Me.ANS_O_SEAT_KIBOU4)
        '交通（往路５）
        DSP_KOTSUHOTEL(SEQ).ANS_O_STATUS_5 = AppModule.GetValue_ANS_O_STATUS_5(Me.ANS_O_STATUS_5)
        DSP_KOTSUHOTEL(SEQ).ANS_O_DATE_5 = AppModule.GetValue_ANS_O_DATE_5(Me.ANS_O_DATE_5)
        DSP_KOTSUHOTEL(SEQ).ANS_O_AIRPORT1_5 = AppModule.GetValue_ANS_O_AIRPORT1_5(Me.ANS_O_AIRPORT1_5)
        DSP_KOTSUHOTEL(SEQ).ANS_O_AIRPORT2_5 = AppModule.GetValue_ANS_O_AIRPORT2_5(Me.ANS_O_AIRPORT2_5)
        DSP_KOTSUHOTEL(SEQ).ANS_O_TIME1_5 = AppModule.GetValue_ANS_O_TIME1_5(Me.ANS_O_TIME1_5)
        DSP_KOTSUHOTEL(SEQ).ANS_O_TIME2_5 = AppModule.GetValue_ANS_O_TIME2_5(Me.ANS_O_TIME2_5)
        DSP_KOTSUHOTEL(SEQ).ANS_O_BIN_5 = AppModule.GetValue_ANS_O_BIN_5(Me.ANS_O_BIN_5)
        DSP_KOTSUHOTEL(SEQ).ANS_O_SEAT_5 = AppModule.GetValue_ANS_O_SEAT_5(Me.ANS_O_SEAT_5)
        DSP_KOTSUHOTEL(SEQ).ANS_O_SEAT_KIBOU5 = AppModule.GetValue_ANS_O_SEAT_KIBOU5(Me.ANS_O_SEAT_KIBOU5)
        '交通（復路１）
        DSP_KOTSUHOTEL(SEQ).ANS_F_STATUS_1 = AppModule.GetValue_ANS_F_STATUS_1(Me.ANS_F_STATUS_1)
        DSP_KOTSUHOTEL(SEQ).ANS_F_DATE_1 = AppModule.GetValue_ANS_F_DATE_1(Me.ANS_F_DATE_1)
        DSP_KOTSUHOTEL(SEQ).ANS_F_AIRPORT1_1 = AppModule.GetValue_ANS_F_AIRPORT1_1(Me.ANS_F_AIRPORT1_1)
        DSP_KOTSUHOTEL(SEQ).ANS_F_AIRPORT2_1 = AppModule.GetValue_ANS_F_AIRPORT2_1(Me.ANS_F_AIRPORT2_1)
        DSP_KOTSUHOTEL(SEQ).ANS_F_TIME1_1 = AppModule.GetValue_ANS_F_TIME1_1(Me.ANS_F_TIME1_1)
        DSP_KOTSUHOTEL(SEQ).ANS_F_TIME2_1 = AppModule.GetValue_ANS_F_TIME2_1(Me.ANS_F_TIME2_1)
        DSP_KOTSUHOTEL(SEQ).ANS_F_BIN_1 = AppModule.GetValue_ANS_F_BIN_1(Me.ANS_F_BIN_1)
        DSP_KOTSUHOTEL(SEQ).ANS_F_SEAT_1 = AppModule.GetValue_ANS_F_SEAT_1(Me.ANS_F_SEAT_1)
        DSP_KOTSUHOTEL(SEQ).ANS_F_SEAT_KIBOU1 = AppModule.GetValue_ANS_F_SEAT_KIBOU1(Me.ANS_F_SEAT_KIBOU1)
        '交通（復路２）
        DSP_KOTSUHOTEL(SEQ).ANS_F_STATUS_2 = AppModule.GetValue_ANS_F_STATUS_2(Me.ANS_F_STATUS_2)
        DSP_KOTSUHOTEL(SEQ).ANS_F_DATE_2 = AppModule.GetValue_ANS_F_DATE_2(Me.ANS_F_DATE_2)
        DSP_KOTSUHOTEL(SEQ).ANS_F_AIRPORT1_2 = AppModule.GetValue_ANS_F_AIRPORT1_2(Me.ANS_F_AIRPORT1_2)
        DSP_KOTSUHOTEL(SEQ).ANS_F_AIRPORT2_2 = AppModule.GetValue_ANS_F_AIRPORT2_2(Me.ANS_F_AIRPORT2_2)
        DSP_KOTSUHOTEL(SEQ).ANS_F_TIME1_2 = AppModule.GetValue_ANS_F_TIME1_2(Me.ANS_F_TIME1_2)
        DSP_KOTSUHOTEL(SEQ).ANS_F_TIME2_2 = AppModule.GetValue_ANS_F_TIME2_2(Me.ANS_F_TIME2_2)
        DSP_KOTSUHOTEL(SEQ).ANS_F_BIN_2 = AppModule.GetValue_ANS_F_BIN_2(Me.ANS_F_BIN_2)
        DSP_KOTSUHOTEL(SEQ).ANS_F_SEAT_2 = AppModule.GetValue_ANS_F_SEAT_2(Me.ANS_F_SEAT_2)
        DSP_KOTSUHOTEL(SEQ).ANS_F_SEAT_KIBOU2 = AppModule.GetValue_ANS_F_SEAT_KIBOU2(Me.ANS_F_SEAT_KIBOU2)
        '交通（復路３）
        DSP_KOTSUHOTEL(SEQ).ANS_F_STATUS_3 = AppModule.GetValue_ANS_F_STATUS_3(Me.ANS_F_STATUS_3)
        DSP_KOTSUHOTEL(SEQ).ANS_F_DATE_3 = AppModule.GetValue_ANS_F_DATE_3(Me.ANS_F_DATE_3)
        DSP_KOTSUHOTEL(SEQ).ANS_F_AIRPORT1_3 = AppModule.GetValue_ANS_F_AIRPORT1_3(Me.ANS_F_AIRPORT1_3)
        DSP_KOTSUHOTEL(SEQ).ANS_F_AIRPORT2_3 = AppModule.GetValue_ANS_F_AIRPORT2_3(Me.ANS_F_AIRPORT2_3)
        DSP_KOTSUHOTEL(SEQ).ANS_F_TIME1_3 = AppModule.GetValue_ANS_F_TIME1_3(Me.ANS_F_TIME1_3)
        DSP_KOTSUHOTEL(SEQ).ANS_F_TIME2_3 = AppModule.GetValue_ANS_F_TIME2_3(Me.ANS_F_TIME2_3)
        DSP_KOTSUHOTEL(SEQ).ANS_F_BIN_3 = AppModule.GetValue_ANS_F_BIN_3(Me.ANS_F_BIN_3)
        DSP_KOTSUHOTEL(SEQ).ANS_F_SEAT_3 = AppModule.GetValue_ANS_F_SEAT_3(Me.ANS_F_SEAT_3)
        DSP_KOTSUHOTEL(SEQ).ANS_F_SEAT_KIBOU3 = AppModule.GetValue_ANS_F_SEAT_KIBOU3(Me.ANS_F_SEAT_KIBOU3)
        '交通（復路４）
        DSP_KOTSUHOTEL(SEQ).ANS_F_STATUS_4 = AppModule.GetValue_ANS_F_STATUS_4(Me.ANS_F_STATUS_4)
        DSP_KOTSUHOTEL(SEQ).ANS_F_DATE_4 = AppModule.GetValue_ANS_F_DATE_4(Me.ANS_F_DATE_4)
        DSP_KOTSUHOTEL(SEQ).ANS_F_AIRPORT1_4 = AppModule.GetValue_ANS_F_AIRPORT1_4(Me.ANS_F_AIRPORT1_4)
        DSP_KOTSUHOTEL(SEQ).ANS_F_AIRPORT2_4 = AppModule.GetValue_ANS_F_AIRPORT2_4(Me.ANS_F_AIRPORT2_4)
        DSP_KOTSUHOTEL(SEQ).ANS_F_TIME1_4 = AppModule.GetValue_ANS_F_TIME1_4(Me.ANS_F_TIME1_4)
        DSP_KOTSUHOTEL(SEQ).ANS_F_TIME2_4 = AppModule.GetValue_ANS_F_TIME2_4(Me.ANS_F_TIME2_4)
        DSP_KOTSUHOTEL(SEQ).ANS_F_BIN_4 = AppModule.GetValue_ANS_F_BIN_4(Me.ANS_F_BIN_4)
        DSP_KOTSUHOTEL(SEQ).ANS_F_SEAT_4 = AppModule.GetValue_ANS_F_SEAT_4(Me.ANS_F_SEAT_4)
        DSP_KOTSUHOTEL(SEQ).ANS_F_SEAT_KIBOU4 = AppModule.GetValue_ANS_F_SEAT_KIBOU4(Me.ANS_F_SEAT_KIBOU4)
        '交通（復路５）
        DSP_KOTSUHOTEL(SEQ).ANS_F_STATUS_5 = AppModule.GetValue_ANS_F_STATUS_5(Me.ANS_F_STATUS_5)
        DSP_KOTSUHOTEL(SEQ).ANS_F_DATE_5 = AppModule.GetValue_ANS_F_DATE_5(Me.ANS_F_DATE_5)
        DSP_KOTSUHOTEL(SEQ).ANS_F_AIRPORT1_5 = AppModule.GetValue_ANS_F_AIRPORT1_5(Me.ANS_F_AIRPORT1_5)
        DSP_KOTSUHOTEL(SEQ).ANS_F_AIRPORT2_5 = AppModule.GetValue_ANS_F_AIRPORT2_5(Me.ANS_F_AIRPORT2_5)
        DSP_KOTSUHOTEL(SEQ).ANS_F_TIME1_5 = AppModule.GetValue_ANS_F_TIME1_5(Me.ANS_F_TIME1_5)
        DSP_KOTSUHOTEL(SEQ).ANS_F_TIME2_5 = AppModule.GetValue_ANS_F_TIME2_5(Me.ANS_F_TIME2_5)
        DSP_KOTSUHOTEL(SEQ).ANS_F_BIN_5 = AppModule.GetValue_ANS_F_BIN_5(Me.ANS_F_BIN_5)
        DSP_KOTSUHOTEL(SEQ).ANS_F_SEAT_5 = AppModule.GetValue_ANS_F_SEAT_5(Me.ANS_F_SEAT_5)
        DSP_KOTSUHOTEL(SEQ).ANS_F_SEAT_KIBOU5 = AppModule.GetValue_ANS_F_SEAT_KIBOU5(Me.ANS_F_SEAT_KIBOU5)
        '交通備考
        DSP_KOTSUHOTEL(SEQ).ANS_KOTSU_BIKO = AppModule.GetValue_ANS_KOTSU_BIKO(Me.ANS_KOTSU_BIKO)
        DSP_KOTSUHOTEL(SEQ).ANS_RAIL_FARE = AppModule.GetValue_ANS_RAIL_FARE(Me.ANS_RAIL_FARE)
        DSP_KOTSUHOTEL(SEQ).ANS_RAIL_CANCELLATION = AppModule.GetValue_ANS_RAIL_CANCELLATION(Me.ANS_RAIL_CANCELLATION)
        DSP_KOTSUHOTEL(SEQ).ANS_AIR_FARE = AppModule.GetValue_ANS_AIR_FARE(Me.ANS_AIR_FARE)
        DSP_KOTSUHOTEL(SEQ).ANS_AIR_CANCELLATION = AppModule.GetValue_ANS_AIR_CANCELLATION(Me.ANS_AIR_CANCELLATION)
        DSP_KOTSUHOTEL(SEQ).ANS_OTHER_FARE = AppModule.GetValue_ANS_OTHER_FARE(Me.ANS_OTHER_FARE)
        DSP_KOTSUHOTEL(SEQ).ANS_OTHER_CANCELLATION = AppModule.GetValue_ANS_OTHER_CANCELLATION(Me.ANS_OTHER_CANCELLATION)

        'タクチケ備考
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NOTE = AppModule.GetValue_ANS_TAXI_NOTE(Me.ANS_TAXI_NOTE)
        'タクチケ１
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_1 = AppModule.GetValue_ANS_TAXI_DATE_1(Me.ANS_TAXI_DATE_1)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_1 = AppModule.GetValue_ANS_TAXI_KENSHU_1(Me.ANS_TAXI_KENSHU_1)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_1 = AppModule.GetValue_ANS_TAXI_NO_1(Me.ANS_TAXI_NO_1)
        'タクチケ２
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_2 = AppModule.GetValue_ANS_TAXI_DATE_2(Me.ANS_TAXI_DATE_2)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_2 = AppModule.GetValue_ANS_TAXI_KENSHU_2(Me.ANS_TAXI_KENSHU_2)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_2 = AppModule.GetValue_ANS_TAXI_NO_2(Me.ANS_TAXI_NO_2)
        'タクチケ３
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_3 = AppModule.GetValue_ANS_TAXI_DATE_3(Me.ANS_TAXI_DATE_3)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_3 = AppModule.GetValue_ANS_TAXI_KENSHU_3(Me.ANS_TAXI_KENSHU_3)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_3 = AppModule.GetValue_ANS_TAXI_NO_3(Me.ANS_TAXI_NO_3)
        'タクチケ４
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_4 = AppModule.GetValue_ANS_TAXI_DATE_4(Me.ANS_TAXI_DATE_4)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_4 = AppModule.GetValue_ANS_TAXI_KENSHU_4(Me.ANS_TAXI_KENSHU_4)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_4 = AppModule.GetValue_ANS_TAXI_NO_4(Me.ANS_TAXI_NO_4)
        'タクチケ５
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_5 = AppModule.GetValue_ANS_TAXI_DATE_5(Me.ANS_TAXI_DATE_5)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_5 = AppModule.GetValue_ANS_TAXI_KENSHU_5(Me.ANS_TAXI_KENSHU_5)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_5 = AppModule.GetValue_ANS_TAXI_NO_5(Me.ANS_TAXI_NO_5)
        'タクチケ６
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_6 = AppModule.GetValue_ANS_TAXI_DATE_6(Me.ANS_TAXI_DATE_6)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_6 = AppModule.GetValue_ANS_TAXI_KENSHU_6(Me.ANS_TAXI_KENSHU_6)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_6 = AppModule.GetValue_ANS_TAXI_NO_6(Me.ANS_TAXI_NO_6)
        'タクチケ７
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_7 = AppModule.GetValue_ANS_TAXI_DATE_7(Me.ANS_TAXI_DATE_7)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_7 = AppModule.GetValue_ANS_TAXI_KENSHU_7(Me.ANS_TAXI_KENSHU_7)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_7 = AppModule.GetValue_ANS_TAXI_NO_7(Me.ANS_TAXI_NO_7)
        'タクチケ８
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_8 = AppModule.GetValue_ANS_TAXI_DATE_8(Me.ANS_TAXI_DATE_8)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_8 = AppModule.GetValue_ANS_TAXI_KENSHU_8(Me.ANS_TAXI_KENSHU_8)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_8 = AppModule.GetValue_ANS_TAXI_NO_8(Me.ANS_TAXI_NO_8)
        'タクチケ９
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_9 = AppModule.GetValue_ANS_TAXI_DATE_9(Me.ANS_TAXI_DATE_9)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_9 = AppModule.GetValue_ANS_TAXI_KENSHU_9(Me.ANS_TAXI_KENSHU_9)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_9 = AppModule.GetValue_ANS_TAXI_NO_9(Me.ANS_TAXI_NO_9)
        'タクチケ１０
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_10 = AppModule.GetValue_ANS_TAXI_DATE_10(Me.ANS_TAXI_DATE_10)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_10 = AppModule.GetValue_ANS_TAXI_KENSHU_10(Me.ANS_TAXI_KENSHU_10)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_10 = AppModule.GetValue_ANS_TAXI_NO_10(Me.ANS_TAXI_NO_10)
        'タクチケ１１
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_11 = AppModule.GetValue_ANS_TAXI_DATE_11(Me.ANS_TAXI_DATE_11)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_11 = AppModule.GetValue_ANS_TAXI_KENSHU_11(Me.ANS_TAXI_KENSHU_11)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_11 = AppModule.GetValue_ANS_TAXI_NO_11(Me.ANS_TAXI_NO_11)
        'タクチケ１２
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_12 = AppModule.GetValue_ANS_TAXI_DATE_12(Me.ANS_TAXI_DATE_12)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_12 = AppModule.GetValue_ANS_TAXI_KENSHU_12(Me.ANS_TAXI_KENSHU_12)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_12 = AppModule.GetValue_ANS_TAXI_NO_12(Me.ANS_TAXI_NO_12)
        'タクチケ１３
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_13 = AppModule.GetValue_ANS_TAXI_DATE_13(Me.ANS_TAXI_DATE_13)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_13 = AppModule.GetValue_ANS_TAXI_KENSHU_13(Me.ANS_TAXI_KENSHU_13)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_13 = AppModule.GetValue_ANS_TAXI_NO_13(Me.ANS_TAXI_NO_13)
        'タクチケ１４
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_14 = AppModule.GetValue_ANS_TAXI_DATE_14(Me.ANS_TAXI_DATE_14)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_14 = AppModule.GetValue_ANS_TAXI_KENSHU_14(Me.ANS_TAXI_KENSHU_14)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_14 = AppModule.GetValue_ANS_TAXI_NO_14(Me.ANS_TAXI_NO_14)
        'タクチケ１５
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_15 = AppModule.GetValue_ANS_TAXI_DATE_15(Me.ANS_TAXI_DATE_15)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_15 = AppModule.GetValue_ANS_TAXI_KENSHU_15(Me.ANS_TAXI_KENSHU_15)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_15 = AppModule.GetValue_ANS_TAXI_NO_15(Me.ANS_TAXI_NO_15)
        'タクチケ１６
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_16 = AppModule.GetValue_ANS_TAXI_DATE_16(Me.ANS_TAXI_DATE_16)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_16 = AppModule.GetValue_ANS_TAXI_KENSHU_16(Me.ANS_TAXI_KENSHU_16)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_16 = AppModule.GetValue_ANS_TAXI_NO_16(Me.ANS_TAXI_NO_16)
        'タクチケ１７
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_17 = AppModule.GetValue_ANS_TAXI_DATE_17(Me.ANS_TAXI_DATE_17)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_17 = AppModule.GetValue_ANS_TAXI_KENSHU_17(Me.ANS_TAXI_KENSHU_17)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_17 = AppModule.GetValue_ANS_TAXI_NO_17(Me.ANS_TAXI_NO_17)
        'タクチケ１８
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_18 = AppModule.GetValue_ANS_TAXI_DATE_18(Me.ANS_TAXI_DATE_18)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_18 = AppModule.GetValue_ANS_TAXI_KENSHU_18(Me.ANS_TAXI_KENSHU_18)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_18 = AppModule.GetValue_ANS_TAXI_NO_18(Me.ANS_TAXI_NO_18)
        'タクチケ１９
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_19 = AppModule.GetValue_ANS_TAXI_DATE_19(Me.ANS_TAXI_DATE_19)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_19 = AppModule.GetValue_ANS_TAXI_KENSHU_19(Me.ANS_TAXI_KENSHU_19)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_19 = AppModule.GetValue_ANS_TAXI_NO_19(Me.ANS_TAXI_NO_19)
        'タクチケ２０
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_20 = AppModule.GetValue_ANS_TAXI_DATE_20(Me.ANS_TAXI_DATE_20)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_20 = AppModule.GetValue_ANS_TAXI_KENSHU_20(Me.ANS_TAXI_KENSHU_20)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_20 = AppModule.GetValue_ANS_TAXI_NO_20(Me.ANS_TAXI_NO_20)

        'MR手配
        DSP_KOTSUHOTEL(SEQ).ANS_MR_O_TEHAI = AppModule.getvalue_ANS_MR_O_TEHAI(Me.ANS_MR_O_TEHAI)
        DSP_KOTSUHOTEL(SEQ).ANS_MR_F_TEHAI = AppModule.GetValue_ANS_MR_O_TEHAI(Me.ANS_MR_O_TEHAI)

        DSP_KOTSUHOTEL(SEQ).SEND_FLAG = SEND_FLAG

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
            strSQL = SQL.TBL_KOTSUHOTEL.Update(DSP_KOTSUHOTEL(SEQ))
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
