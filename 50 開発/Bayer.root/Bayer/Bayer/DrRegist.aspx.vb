Imports CommonLib
Imports AppLib
Partial Public Class DrRegist
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private DSP_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private SEQ As Integer
    Private Popup As Boolean = False

    Private Const IMG_CLOSE = "~/Images/button-cross-alt.png"
    Private Const IMG_OPEN = "~/Images/button-tick-alt.png"

    Private Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Unload
        Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
        Session.Item(SessionDef.TBL_KOTSUHOTEL) = TBL_KOTSUHOTEL
        Session.Item(SessionDef.KouenkaiRireki_TBL_KOUENKAI) = TBL_KOUENKAI
    End Sub

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load, Me.Load

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

                '表示対象より新しい交通・宿泊情報がある場合はNOZOMIボタンは使用不可
                If Not ChkNewData() Then
                    BtnNozomi.Visible = False
                    BtnSubmit.Visible = False
                End If
            End If

        Else
            If Trim(Session.Item(SessionDef.DrRireki)) = Session.SessionID Then
            Else
                If Trim(Session.Item(SessionDef.HotelKensaku_Back)) = CmnConst.Flag.On Then
                    '検索画面戻り
                    Me.ANS_HOTEL_NAME.Text = Session.Item(SessionDef.HotelKensaku_SHISETSU_NAME)
                    Me.ANS_HOTEL_ADDRESS.Text = Session.Item(SessionDef.HotelKensaku_ADDRESS2)
                    Me.ANS_HOTEL_TEL.Text = Session.Item(SessionDef.HotelKensaku_TEL)
                    Me.ANS_CHECKIN_TIME.Text = Session.Item(SessionDef.HotelKensaku_CHECKIN_TIME)
                    Me.ANS_CHECKOUT_TIME.Text = Session.Item(SessionDef.HotelKensaku_CHECKOUT_TIME)
                    SetFocus(Me.BtnHotelKensaku)
                End If
            End If

        End If
        Session.Remove(SessionDef.HotelKensaku_Back)
        Session.Remove(SessionDef.KaijoPrint_SQL)
        Session.Remove(SessionDef.BackURL_Print)
        Session.Remove(SessionDef.PrintPreview)

        'マスターページ設定
        With Me.Master
            .PageTitle = "交通・宿泊手配回答登録"
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

        'クリア
        CmnModule.ClearAllControl(Me)

        'プルダウン設定
        AppModule.SetDropDownList_ANS_STATUS_TEHAI(Me.ANS_STATUS_TEHAI)
        AppModule.SetDropDownList_ANS_STATUS_HOTEL(Me.ANS_STATUS_HOTEL)
        AppModule.SetDropDownList_ANS_ROOM_TYPE(Me.ANS_ROOM_TYPE)
        AppModule.SetDropDownList_ANS_HOTEL_SMOKING(Me.ANS_HOTEL_SMOKING)
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
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_1)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_2)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_3)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_4)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_5)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_6)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_7)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_8)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_9)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_10)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_11)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_12)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_13)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_14)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_15)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_16)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_17)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_18)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_19)
        AppModule.SetDropDownList_ANS_TAXI_KENSHU(Me.ANS_TAXI_KENSHU_20)

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
        CmnModule.SetIme(Me.ANS_MR_HOTEL_NOTE, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_HOTELHI, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_HOTELHI_TOZEI, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_RAIL_FARE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_RAIL_CANCELLATION, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_OTHER_FARE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_OTHER_CANCELLATION, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_AIR_FARE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_AIR_CANCELLATION, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_KOTSUHOTEL_TESURYO, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_TESURYO, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_MR_HOTELHI, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_MR_HOTELHI_TOZEI, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_MR_KOTSUHI, CmnModule.ImeType.Disabled)
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
        AppModule.SetForm_KOUENKAI_NO(TBL_KOUENKAI(0).KOUENKAI_NO, Me.KOUENKAI_NO)
        AppModule.SetForm_FROM_DATE(TBL_KOUENKAI(0).FROM_DATE, Me.FROM_DATE)
        AppModule.SetForm_TO_DATE(TBL_KOUENKAI(0).TO_DATE, Me.TO_DATE)
        AppModule.SetForm_KOUENKAI_TIME_STAMP(TBL_KOUENKAI(0).TIME_STAMP, Me.TIME_STAMP)
        AppModule.SetForm_KOUENKAI_NAME(TBL_KOUENKAI(0).KOUENKAI_NAME, Me.KOUENKAI_NAME)
        AppModule.SetForm_TAXI_PRT_NAME(TBL_KOUENKAI(0).TAXI_PRT_NAME, Me.TAXI_PRT_NAME)

        'MR情報
        AppModule.SetForm_MR_BU(DSP_KOTSUHOTEL(DSP_SEQ).MR_BU, Me.MR_BU)
        AppModule.SetForm_MR_AREA(DSP_KOTSUHOTEL(DSP_SEQ).MR_AREA, Me.MR_AREA)
        AppModule.SetForm_MR_EIGYOSHO(DSP_KOTSUHOTEL(DSP_SEQ).MR_EIGYOSHO, Me.MR_EIGYOSHO)
        AppModule.SetForm_ACCOUNT_CODE(DSP_KOTSUHOTEL(DSP_SEQ).ACCOUNT_CD, Me.ACCOUNT_CODE)
        AppModule.SetForm_COST_CENTER(DSP_KOTSUHOTEL(DSP_SEQ).COST_CENTER, Me.COST_CENTER)
        AppModule.SetForm_INTERNAL_ORDER(DSP_KOTSUHOTEL(DSP_SEQ).INTERNAL_ORDER, Me.INTERNAL_ORDER)
        AppModule.SetForm_ZETIA_CODE(DSP_KOTSUHOTEL(DSP_SEQ).ZETIA_CD, Me.ZETIA_CD)
        AppModule.SetForm_MR_NAME(DSP_KOTSUHOTEL(DSP_SEQ).MR_NAME, Me.MR_NAME)
        AppModule.SetForm_MR_ROMA(DSP_KOTSUHOTEL(DSP_SEQ).MR_ROMA, Me.MR_ROMA)
        AppModule.SetForm_MR_KEITAI(DSP_KOTSUHOTEL(DSP_SEQ).MR_KEITAI, Me.MR_KEITAI)
        AppModule.SetForm_MR_TEL(DSP_KOTSUHOTEL(DSP_SEQ).MR_TEL, Me.MR_TEL)
        AppModule.SetForm_MR_EMAIL_KEITAI(DSP_KOTSUHOTEL(DSP_SEQ).MR_EMAIL_KEITAI, Me.MR_EMAIL_KEITAI)
        AppModule.SetForm_MR_EMAIL_PC(DSP_KOTSUHOTEL(DSP_SEQ).MR_EMAIL_PC, Me.MR_EMAIL_PC)
        AppModule.SetForm_MR_SEND_SAKI_FS(DSP_KOTSUHOTEL(DSP_SEQ).MR_SEND_SAKI_FS, Me.MR_SEND_SAKI_FS)
        AppModule.SetForm_MR_SEND_SAKI_OTHER(DSP_KOTSUHOTEL(DSP_SEQ).MR_SEND_SAKI_OTHER, Me.MR_SEND_SAKI_OTHER)

        'DR情報
        AppModule.SetForm_REQ_STATUS_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).REQ_STATUS_TEHAI, Me.REQ_STATUS_TEHAI)
        AppModule.SetForm_ANS_STATUS_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_STATUS_TEHAI, Me.ANS_STATUS_TEHAI)
        AppModule.SetForm_ANS_TICKET_SEND_DAY(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TICKET_SEND_DAY, Me.ANS_TICKET_SEND_DAY)
        AppModule.SetForm_SEND_FLAG(DSP_KOTSUHOTEL(DSP_SEQ).SEND_FLAG, Me.SEND_FLAG)
        AppModule.SetForm_SANKASHA_ID(DSP_KOTSUHOTEL(DSP_SEQ).SANKASHA_ID, Me.SANKASHA_ID)
        AppModule.SetForm_DR_CD(DSP_KOTSUHOTEL(DSP_SEQ).DR_CD, Me.DR_CD)
        AppModule.SetForm_TIME_STAMP_BYL(DSP_KOTSUHOTEL(DSP_SEQ).TIME_STAMP_BYL, Me.TIME_STAMP_BYL)
        AppModule.SetForm_TIME_STAMP_TOP(DSP_KOTSUHOTEL(DSP_SEQ).TIME_STAMP_TOP, Me.TIME_STAMP_TOP)
        AppModule.SetForm_DR_NAME(DSP_KOTSUHOTEL(DSP_SEQ).DR_NAME, Me.DR_NAME)
        AppModule.SetForm_DR_KANA(DSP_KOTSUHOTEL(DSP_SEQ).DR_KANA, Me.DR_KANA)
        AppModule.SetForm_DR_SEX(DSP_KOTSUHOTEL(DSP_SEQ).DR_SEX, Me.DR_SEX)
        AppModule.SetForm_DR_AGE(DSP_KOTSUHOTEL(DSP_SEQ).DR_AGE, Me.DR_AGE)
        AppModule.SetForm_DR_SANKA(DSP_KOTSUHOTEL(DSP_SEQ).DR_SANKA, Me.DR_SANKA)
        AppModule.SetForm_DR_YAKUWARI(DSP_KOTSUHOTEL(DSP_SEQ).DR_YAKUWARI, Me.DR_YAKUWARI)
        AppModule.SetForm_DR_SHISETSU_CD(DSP_KOTSUHOTEL(DSP_SEQ).DR_SHISETSU_CD, Me.DR_SHISETSU_CD)
        AppModule.setform_DR_SHISETSU_NAME(DSP_KOTSUHOTEL(DSP_SEQ).DR_SHISETSU_NAME, Me.DR_SHISETSU_NAME)
        AppModule.SetForm_DR_SHISETSU_ADDRESS(DSP_KOTSUHOTEL(DSP_SEQ).DR_SHISETSU_ADDRESS, Me.DR_SHISETSU_ADDRESS)
        AppModule.SetForm_SHITEIGAI_RIYU(DSP_KOTSUHOTEL(DSP_SEQ).SHITEIGAI_RIYU, Me.SHITEIGAI_RIYU)

        '承認者情報
        AppModule.SetForm_SHONIN_NAME(DSP_KOTSUHOTEL(DSP_SEQ).SHONIN_NAME, Me.SHONIN_NAME)
        AppModule.SetForm_SHONIN_DATE(DSP_KOTSUHOTEL(DSP_SEQ).SHONIN_DATE, Me.SHONIN_DATE)

        '宿泊手配
        AppModule.SetForm_TEHAI_HOTEL(DSP_KOTSUHOTEL(DSP_SEQ).TEHAI_HOTEL, Me.TEHAI_HOTEL)
        AppModule.SetForm_HOTEL_IRAINAIYOU(DSP_KOTSUHOTEL(DSP_SEQ).HOTEL_IRAINAIYOU, Me.HOTEL_IRAINAIYOU)
        AppModule.SetForm_REQ_HOTEL_DATE(DSP_KOTSUHOTEL(DSP_SEQ).REQ_HOTEL_DATE, Me.REQ_HOTEL_DATE)
        AppModule.SetForm_REQ_HAKUSU(DSP_KOTSUHOTEL(DSP_SEQ).REQ_HAKUSU, Me.REQ_HAKUSU)
        AppModule.SetForm_REQ_HOTEL_SMOKING(DSP_KOTSUHOTEL(DSP_SEQ).REQ_HOTEL_SMOKING, Me.REQ_HOTEL_SMOKING)
        AppModule.SetForm_REQ_HOTEL_NOTE(DSP_KOTSUHOTEL(DSP_SEQ).REQ_HOTEL_NOTE, Me.REQ_HOTEL_NOTE)
        AppModule.SetForm_ANS_STATUS_HOTEL(DSP_KOTSUHOTEL(DSP_SEQ).ANS_STATUS_HOTEL, Me.ANS_STATUS_HOTEL)
        AppModule.SetForm_ANS_HOTEL_NAME(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTEL_NAME, Me.ANS_HOTEL_NAME)
        AppModule.SetForm_ANS_HOTEL_ADDRESS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTEL_ADDRESS, Me.ANS_HOTEL_ADDRESS)
        AppModule.SetForm_ANS_HOTEL_TEL(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTEL_TEL, Me.ANS_HOTEL_TEL)
        AppModule.SetForm_ANS_HOTEL_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTEL_DATE, Me.ANS_HOTEL_DATE)
        AppModule.SetForm_ANS_HAKUSU(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HAKUSU, Me.ANS_HAKUSU)
        AppModule.SetForm_ANS_CHECKIN_TIME(DSP_KOTSUHOTEL(DSP_SEQ).ANS_CHECKIN_TIME, Me.ANS_CHECKIN_TIME)
        AppModule.SetForm_ANS_CHECKOUT_TIME(DSP_KOTSUHOTEL(DSP_SEQ).ANS_CHECKOUT_TIME, Me.ANS_CHECKOUT_TIME)
        AppModule.SetForm_ANS_ROOM_TYPE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_ROOM_TYPE, Me.ANS_ROOM_TYPE)
        AppModule.SetForm_ANS_HOTEL_SMOKING(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTEL_SMOKING, Me.ANS_HOTEL_SMOKING)
        AppModule.SetForm_ANS_HOTEL_NOTE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTEL_NOTE, Me.ANS_HOTEL_NOTE)

        '交通（往路１）
        AppModule.SetForm_REQ_O_TEHAI_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TEHAI_1, Me.REQ_O_TEHAI_1)
        AppModule.SetForm_REQ_O_IRAINAIYOU_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_IRAINAIYOU_1, Me.REQ_O_IRAINAIYOU_1)
        AppModule.SetForm_REQ_O_KOTSUKIKAN_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_KOTSUKIKAN_1, Me.REQ_O_KOTSUKIKAN_1)
        AppModule.SetForm_REQ_O_DATE_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_DATE_1, Me.REQ_O_DATE_1)
        AppModule.SetForm_REQ_O_AIRPORT1_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT1_1, Me.REQ_O_AIRPORT1_1)
        AppModule.SetForm_REQ_O_AIRPORT2_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT2_1, Me.REQ_O_AIRPORT2_1)
        AppModule.SetForm_REQ_O_TIME1_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME1_1, Me.REQ_O_TIME1_1)
        AppModule.SetForm_REQ_O_TIME2_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME2_1, Me.REQ_O_TIME2_1)
        AppModule.SetForm_REQ_O_BIN_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_BIN_1, Me.REQ_O_BIN_1)
        AppModule.SetForm_REQ_O_SEAT_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_1, Me.REQ_O_SEAT_1)
        AppModule.SetForm_REQ_O_SEAT_KIBOU1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_KIBOU1, Me.REQ_O_SEAT_KIBOU1)
        AppModule.SetForm_ANS_O_STATUS_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_STATUS_1, Me.ANS_O_STATUS_1)
        AppModule.SetForm_ANS_O_KOTSUKIKAN_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_KOTSUKIKAN_1, Me.ANS_O_KOTSUKIKAN_1)
        AppModule.SetForm_ANS_O_DATE_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_DATE_1, Me.ANS_O_DATE_1)
        AppModule.SetForm_ANS_O_AIRPORT1_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT1_1, Me.ANS_O_AIRPORT1_1)
        AppModule.SetForm_ANS_O_AIRPORT2_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT2_1, Me.ANS_O_AIRPORT2_1)
        AppModule.SetForm_ANS_O_TIME1_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME1_1, Me.ANS_O_TIME1_1)
        AppModule.SetForm_ANS_O_TIME2_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME2_1, Me.ANS_O_TIME2_1)
        AppModule.SetForm_ANS_O_BIN_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_BIN_1, Me.ANS_O_BIN_1)
        AppModule.SetForm_ANS_O_SEAT_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_1, Me.ANS_O_SEAT_1)
        AppModule.SetForm_ANS_O_SEAT_KIBOU1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_KIBOU1, Me.ANS_O_SEAT_KIBOU1)

        '交通（往路２）
        AppModule.SetForm_REQ_O_TEHAI_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TEHAI_2, Me.REQ_O_TEHAI_2)
        AppModule.SetForm_REQ_O_IRAINAIYOU_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_IRAINAIYOU_2, Me.REQ_O_IRAINAIYOU_2)
        AppModule.SetForm_REQ_O_KOTSUKIKAN_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_KOTSUKIKAN_2, Me.REQ_O_KOTSUKIKAN_2)
        AppModule.SetForm_REQ_O_DATE_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_DATE_2, Me.REQ_O_DATE_2)
        AppModule.SetForm_REQ_O_AIRPORT1_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT1_2, Me.REQ_O_AIRPORT1_2)
        AppModule.SetForm_REQ_O_AIRPORT2_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT2_2, Me.REQ_O_AIRPORT2_2)
        AppModule.SetForm_REQ_O_TIME1_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME1_2, Me.REQ_O_TIME1_2)
        AppModule.SetForm_REQ_O_TIME2_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME2_2, Me.REQ_O_TIME2_2)
        AppModule.SetForm_REQ_O_BIN_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_BIN_2, Me.REQ_O_BIN_2)
        AppModule.SetForm_REQ_O_SEAT_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_2, Me.REQ_O_SEAT_2)
        AppModule.SetForm_REQ_O_SEAT_KIBOU2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_KIBOU2, Me.REQ_O_SEAT_KIBOU2)
        AppModule.SetForm_ANS_O_STATUS_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_STATUS_2, Me.ANS_O_STATUS_2)
        AppModule.SetForm_ANS_O_KOTSUKIKAN_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_KOTSUKIKAN_2, Me.ANS_O_KOTSUKIKAN_2)
        AppModule.SetForm_ANS_O_DATE_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_DATE_2, Me.ANS_O_DATE_2)
        AppModule.SetForm_ANS_O_AIRPORT1_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT1_2, Me.ANS_O_AIRPORT1_2)
        AppModule.SetForm_ANS_O_AIRPORT2_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT2_2, Me.ANS_O_AIRPORT2_2)
        AppModule.SetForm_ANS_O_TIME1_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME1_2, Me.ANS_O_TIME1_2)
        AppModule.SetForm_ANS_O_TIME2_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME2_2, Me.ANS_O_TIME2_2)
        AppModule.SetForm_ANS_O_BIN_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_BIN_2, Me.ANS_O_BIN_2)
        AppModule.SetForm_ANS_O_SEAT_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_2, Me.ANS_O_SEAT_2)
        AppModule.SetForm_ANS_O_SEAT_KIBOU2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_KIBOU2, Me.ANS_O_SEAT_KIBOU2)

        '交通（往路３）
        AppModule.SetForm_REQ_O_TEHAI_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TEHAI_3, Me.REQ_O_TEHAI_3)
        AppModule.SetForm_REQ_O_IRAINAIYOU_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_IRAINAIYOU_3, Me.REQ_O_IRAINAIYOU_3)
        AppModule.SetForm_REQ_O_KOTSUKIKAN_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_KOTSUKIKAN_3, Me.REQ_O_KOTSUKIKAN_3)
        AppModule.SetForm_REQ_O_DATE_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_DATE_3, Me.REQ_O_DATE_3)
        AppModule.SetForm_REQ_O_AIRPORT1_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT1_3, Me.REQ_O_AIRPORT1_3)
        AppModule.SetForm_REQ_O_AIRPORT2_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT2_3, Me.REQ_O_AIRPORT2_3)
        AppModule.SetForm_REQ_O_TIME1_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME1_3, Me.REQ_O_TIME1_3)
        AppModule.SetForm_REQ_O_TIME2_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME2_3, Me.REQ_O_TIME2_3)
        AppModule.SetForm_REQ_O_BIN_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_BIN_3, Me.REQ_O_BIN_3)
        AppModule.SetForm_REQ_O_SEAT_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_3, Me.REQ_O_SEAT_3)
        AppModule.SetForm_REQ_O_SEAT_KIBOU3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_KIBOU3, Me.REQ_O_SEAT_KIBOU3)
        AppModule.SetForm_ANS_O_STATUS_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_STATUS_3, Me.ANS_O_STATUS_3)
        AppModule.SetForm_ANS_O_KOTSUKIKAN_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_KOTSUKIKAN_3, Me.ANS_O_KOTSUKIKAN_3)
        AppModule.SetForm_ANS_O_DATE_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_DATE_3, Me.ANS_O_DATE_3)
        AppModule.SetForm_ANS_O_AIRPORT1_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT1_3, Me.ANS_O_AIRPORT1_3)
        AppModule.SetForm_ANS_O_AIRPORT2_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT2_3, Me.ANS_O_AIRPORT2_3)
        AppModule.SetForm_ANS_O_TIME1_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME1_3, Me.ANS_O_TIME1_3)
        AppModule.SetForm_ANS_O_TIME2_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME2_3, Me.ANS_O_TIME2_3)
        AppModule.SetForm_ANS_O_BIN_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_BIN_3, Me.ANS_O_BIN_3)
        AppModule.SetForm_ANS_O_SEAT_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_3, Me.ANS_O_SEAT_3)
        AppModule.SetForm_ANS_O_SEAT_KIBOU3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_KIBOU3, Me.ANS_O_SEAT_KIBOU3)

        '交通（往路４）
        AppModule.SetForm_REQ_O_TEHAI_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TEHAI_4, Me.REQ_O_TEHAI_4)
        AppModule.SetForm_REQ_O_IRAINAIYOU_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_IRAINAIYOU_4, Me.REQ_O_IRAINAIYOU_4)
        AppModule.SetForm_REQ_O_KOTSUKIKAN_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_KOTSUKIKAN_4, Me.REQ_O_KOTSUKIKAN_4)
        AppModule.SetForm_REQ_O_DATE_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_DATE_4, Me.REQ_O_DATE_4)
        AppModule.SetForm_REQ_O_AIRPORT1_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT1_4, Me.REQ_O_AIRPORT1_4)
        AppModule.SetForm_REQ_O_AIRPORT2_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT2_4, Me.REQ_O_AIRPORT2_4)
        AppModule.SetForm_REQ_O_TIME1_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME1_4, Me.REQ_O_TIME1_4)
        AppModule.SetForm_REQ_O_TIME2_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME2_4, Me.REQ_O_TIME2_4)
        AppModule.SetForm_REQ_O_BIN_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_BIN_4, Me.REQ_O_BIN_4)
        AppModule.SetForm_REQ_O_SEAT_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_4, Me.REQ_O_SEAT_4)
        AppModule.SetForm_REQ_O_SEAT_KIBOU4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_KIBOU4, Me.REQ_O_SEAT_KIBOU4)
        AppModule.SetForm_ANS_O_STATUS_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_STATUS_4, Me.ANS_O_STATUS_4)
        AppModule.SetForm_ANS_O_KOTSUKIKAN_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_KOTSUKIKAN_4, Me.ANS_O_KOTSUKIKAN_4)
        AppModule.SetForm_ANS_O_DATE_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_DATE_4, Me.ANS_O_DATE_4)
        AppModule.SetForm_ANS_O_AIRPORT1_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT1_4, Me.ANS_O_AIRPORT1_4)
        AppModule.SetForm_ANS_O_AIRPORT2_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT2_4, Me.ANS_O_AIRPORT2_4)
        AppModule.SetForm_ANS_O_TIME1_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME1_4, Me.ANS_O_TIME1_4)
        AppModule.SetForm_ANS_O_TIME2_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME2_4, Me.ANS_O_TIME2_4)
        AppModule.SetForm_ANS_O_BIN_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_BIN_4, Me.ANS_O_BIN_4)
        AppModule.SetForm_ANS_O_SEAT_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_4, Me.ANS_O_SEAT_4)
        AppModule.SetForm_ANS_O_SEAT_KIBOU4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_KIBOU4, Me.ANS_O_SEAT_KIBOU4)

        '交通（往路５）
        AppModule.SetForm_REQ_O_TEHAI_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TEHAI_5, Me.REQ_O_TEHAI_5)
        AppModule.SetForm_REQ_O_IRAINAIYOU_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_IRAINAIYOU_5, Me.REQ_O_IRAINAIYOU_5)
        AppModule.SetForm_REQ_O_KOTSUKIKAN_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_KOTSUKIKAN_5, Me.REQ_O_KOTSUKIKAN_5)
        AppModule.SetForm_REQ_O_DATE_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_DATE_5, Me.REQ_O_DATE_5)
        AppModule.SetForm_REQ_O_AIRPORT1_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT1_5, Me.REQ_O_AIRPORT1_5)
        AppModule.SetForm_REQ_O_AIRPORT2_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT2_5, Me.REQ_O_AIRPORT2_5)
        AppModule.SetForm_REQ_O_TIME1_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME1_5, Me.REQ_O_TIME1_5)
        AppModule.SetForm_REQ_O_TIME2_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME2_5, Me.REQ_O_TIME2_5)
        AppModule.SetForm_REQ_O_BIN_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_BIN_5, Me.REQ_O_BIN_5)
        AppModule.SetForm_REQ_O_SEAT_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_5, Me.REQ_O_SEAT_5)
        AppModule.SetForm_REQ_O_SEAT_KIBOU5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_KIBOU5, Me.REQ_O_SEAT_KIBOU5)
        AppModule.SetForm_ANS_O_STATUS_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_STATUS_5, Me.ANS_O_STATUS_5)
        AppModule.SetForm_ANS_O_KOTSUKIKAN_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_KOTSUKIKAN_5, Me.ANS_O_KOTSUKIKAN_5)
        AppModule.SetForm_ANS_O_DATE_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_DATE_5, Me.ANS_O_DATE_5)
        AppModule.SetForm_ANS_O_AIRPORT1_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT1_5, Me.ANS_O_AIRPORT1_5)
        AppModule.SetForm_ANS_O_AIRPORT2_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_AIRPORT2_5, Me.ANS_O_AIRPORT2_5)
        AppModule.SetForm_ANS_O_TIME1_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME1_5, Me.ANS_O_TIME1_5)
        AppModule.SetForm_ANS_O_TIME2_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_TIME2_5, Me.ANS_O_TIME2_5)
        AppModule.SetForm_ANS_O_BIN_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_BIN_5, Me.ANS_O_BIN_5)
        AppModule.SetForm_ANS_O_SEAT_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_5, Me.ANS_O_SEAT_5)
        AppModule.SetForm_ANS_O_SEAT_KIBOU5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_O_SEAT_KIBOU5, Me.ANS_O_SEAT_KIBOU5)

        '交通（復路１）
        AppModule.SetForm_REQ_F_TEHAI_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TEHAI_1, Me.REQ_F_TEHAI_1)
        AppModule.SetForm_REQ_F_IRAINAIYOU_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_IRAINAIYOU_1, Me.REQ_F_IRAINAIYOU_1)
        AppModule.SetForm_REQ_F_KOTSUKIKAN_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_KOTSUKIKAN_1, Me.REQ_F_KOTSUKIKAN_1)
        AppModule.SetForm_REQ_F_DATE_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_DATE_1, Me.REQ_F_DATE_1)
        AppModule.SetForm_REQ_F_AIRPORT1_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT1_1, Me.REQ_F_AIRPORT1_1)
        AppModule.SetForm_REQ_F_AIRPORT2_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT2_1, Me.REQ_F_AIRPORT2_1)
        AppModule.SetForm_REQ_F_TIME1_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME1_1, Me.REQ_F_TIME1_1)
        AppModule.SetForm_REQ_F_TIME2_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME2_1, Me.REQ_F_TIME2_1)
        AppModule.SetForm_REQ_F_BIN_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_BIN_1, Me.REQ_F_BIN_1)
        AppModule.SetForm_REQ_F_SEAT_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_1, Me.REQ_F_SEAT_1)
        AppModule.SetForm_REQ_F_SEAT_KIBOU1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_KIBOU1, Me.REQ_F_SEAT_KIBOU1)
        AppModule.SetForm_ANS_F_STATUS_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_STATUS_1, Me.ANS_F_STATUS_1)
        AppModule.SetForm_ANS_F_KOTSUKIKAN_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_KOTSUKIKAN_1, Me.ANS_F_KOTSUKIKAN_1)
        AppModule.SetForm_ANS_F_DATE_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_DATE_1, Me.ANS_F_DATE_1)
        AppModule.SetForm_ANS_F_AIRPORT1_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT1_1, Me.ANS_F_AIRPORT1_1)
        AppModule.SetForm_ANS_F_AIRPORT2_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT2_1, Me.ANS_F_AIRPORT2_1)
        AppModule.SetForm_ANS_F_TIME1_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME1_1, Me.ANS_F_TIME1_1)
        AppModule.SetForm_ANS_F_TIME2_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME2_1, Me.ANS_F_TIME2_1)
        AppModule.SetForm_ANS_F_BIN_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_BIN_1, Me.ANS_F_BIN_1)
        AppModule.SetForm_ANS_F_SEAT_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_1, Me.ANS_F_SEAT_1)
        AppModule.SetForm_ANS_F_SEAT_KIBOU1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_KIBOU1, Me.ANS_F_SEAT_KIBOU1)

        '交通（復路２）
        AppModule.SetForm_REQ_F_TEHAI_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TEHAI_2, Me.REQ_F_TEHAI_2)
        AppModule.SetForm_REQ_F_IRAINAIYOU_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_IRAINAIYOU_2, Me.REQ_F_IRAINAIYOU_2)
        AppModule.SetForm_REQ_F_KOTSUKIKAN_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_KOTSUKIKAN_2, Me.REQ_F_KOTSUKIKAN_2)
        AppModule.SetForm_REQ_F_DATE_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_DATE_2, Me.REQ_F_DATE_2)
        AppModule.SetForm_REQ_F_AIRPORT1_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT1_2, Me.REQ_F_AIRPORT1_2)
        AppModule.SetForm_REQ_F_AIRPORT2_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT2_2, Me.REQ_F_AIRPORT2_2)
        AppModule.SetForm_REQ_F_TIME1_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME1_2, Me.REQ_F_TIME1_2)
        AppModule.SetForm_REQ_F_TIME2_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME2_2, Me.REQ_F_TIME2_2)
        AppModule.SetForm_REQ_F_BIN_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_BIN_2, Me.REQ_F_BIN_2)
        AppModule.SetForm_REQ_F_SEAT_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_2, Me.REQ_F_SEAT_2)
        AppModule.SetForm_REQ_F_SEAT_KIBOU2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_KIBOU2, Me.REQ_F_SEAT_KIBOU2)
        AppModule.SetForm_ANS_F_STATUS_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_STATUS_2, Me.ANS_F_STATUS_2)
        AppModule.SetForm_ANS_F_KOTSUKIKAN_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_KOTSUKIKAN_2, Me.ANS_F_KOTSUKIKAN_2)
        AppModule.SetForm_ANS_F_DATE_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_DATE_2, Me.ANS_F_DATE_2)
        AppModule.SetForm_ANS_F_AIRPORT1_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT1_2, Me.ANS_F_AIRPORT1_2)
        AppModule.SetForm_ANS_F_AIRPORT2_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT2_2, Me.ANS_F_AIRPORT2_2)
        AppModule.SetForm_ANS_F_TIME1_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME1_2, Me.ANS_F_TIME1_2)
        AppModule.SetForm_ANS_F_TIME2_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME2_2, Me.ANS_F_TIME2_2)
        AppModule.SetForm_ANS_F_BIN_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_BIN_2, Me.ANS_F_BIN_2)
        AppModule.SetForm_ANS_F_SEAT_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_2, Me.ANS_F_SEAT_2)
        AppModule.SetForm_ANS_F_SEAT_KIBOU2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_KIBOU2, Me.ANS_F_SEAT_KIBOU2)

        '交通（復路３）
        AppModule.SetForm_REQ_F_TEHAI_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TEHAI_3, Me.REQ_F_TEHAI_3)
        AppModule.SetForm_REQ_F_IRAINAIYOU_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_IRAINAIYOU_3, Me.REQ_F_IRAINAIYOU_3)
        AppModule.SetForm_REQ_F_KOTSUKIKAN_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_KOTSUKIKAN_3, Me.REQ_F_KOTSUKIKAN_3)
        AppModule.SetForm_REQ_F_DATE_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_DATE_3, Me.REQ_F_DATE_3)
        AppModule.SetForm_REQ_F_AIRPORT1_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT1_3, Me.REQ_F_AIRPORT1_3)
        AppModule.SetForm_REQ_F_AIRPORT2_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT2_3, Me.REQ_F_AIRPORT2_3)
        AppModule.SetForm_REQ_F_TIME1_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME1_3, Me.REQ_F_TIME1_3)
        AppModule.SetForm_REQ_F_TIME2_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME2_3, Me.REQ_F_TIME2_3)
        AppModule.SetForm_REQ_F_BIN_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_BIN_3, Me.REQ_F_BIN_3)
        AppModule.SetForm_REQ_F_SEAT_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_3, Me.REQ_F_SEAT_3)
        AppModule.SetForm_REQ_F_SEAT_KIBOU3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_KIBOU3, Me.REQ_F_SEAT_KIBOU3)
        AppModule.SetForm_ANS_F_STATUS_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_STATUS_3, Me.ANS_F_STATUS_3)
        AppModule.SetForm_ANS_F_KOTSUKIKAN_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_KOTSUKIKAN_3, Me.ANS_F_KOTSUKIKAN_3)
        AppModule.SetForm_ANS_F_DATE_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_DATE_3, Me.ANS_F_DATE_3)
        AppModule.SetForm_ANS_F_AIRPORT1_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT1_3, Me.ANS_F_AIRPORT1_3)
        AppModule.SetForm_ANS_F_AIRPORT2_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT2_3, Me.ANS_F_AIRPORT2_3)
        AppModule.SetForm_ANS_F_TIME1_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME1_3, Me.ANS_F_TIME1_3)
        AppModule.SetForm_ANS_F_TIME2_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME2_3, Me.ANS_F_TIME2_3)
        AppModule.SetForm_ANS_F_BIN_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_BIN_3, Me.ANS_F_BIN_3)
        AppModule.SetForm_ANS_F_SEAT_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_3, Me.ANS_F_SEAT_3)
        AppModule.SetForm_ANS_F_SEAT_KIBOU3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_KIBOU3, Me.ANS_F_SEAT_KIBOU3)

        '交通（復路４）
        AppModule.SetForm_REQ_F_TEHAI_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TEHAI_4, Me.REQ_F_TEHAI_4)
        AppModule.SetForm_REQ_F_IRAINAIYOU_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_IRAINAIYOU_4, Me.REQ_F_IRAINAIYOU_4)
        AppModule.SetForm_REQ_F_KOTSUKIKAN_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_KOTSUKIKAN_4, Me.REQ_F_KOTSUKIKAN_4)
        AppModule.SetForm_REQ_F_DATE_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_DATE_4, Me.REQ_F_DATE_4)
        AppModule.SetForm_REQ_F_AIRPORT1_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT1_4, Me.REQ_F_AIRPORT1_4)
        AppModule.SetForm_REQ_F_AIRPORT2_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT2_4, Me.REQ_F_AIRPORT2_4)
        AppModule.SetForm_REQ_F_TIME1_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME1_4, Me.REQ_F_TIME1_4)
        AppModule.SetForm_REQ_F_TIME2_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME2_4, Me.REQ_F_TIME2_4)
        AppModule.SetForm_REQ_F_BIN_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_BIN_4, Me.REQ_F_BIN_4)
        AppModule.SetForm_REQ_F_SEAT_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_4, Me.REQ_F_SEAT_4)
        AppModule.SetForm_REQ_F_SEAT_KIBOU4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_KIBOU4, Me.REQ_F_SEAT_KIBOU4)
        AppModule.SetForm_ANS_F_STATUS_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_STATUS_4, Me.ANS_F_STATUS_4)
        AppModule.SetForm_ANS_F_KOTSUKIKAN_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_KOTSUKIKAN_4, Me.ANS_F_KOTSUKIKAN_4)
        AppModule.SetForm_ANS_F_DATE_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_DATE_4, Me.ANS_F_DATE_4)
        AppModule.SetForm_ANS_F_AIRPORT1_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT1_4, Me.ANS_F_AIRPORT1_4)
        AppModule.SetForm_ANS_F_AIRPORT2_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT2_4, Me.ANS_F_AIRPORT2_4)
        AppModule.SetForm_ANS_F_TIME1_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME1_4, Me.ANS_F_TIME1_4)
        AppModule.SetForm_ANS_F_TIME2_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME2_4, Me.ANS_F_TIME2_4)
        AppModule.SetForm_ANS_F_BIN_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_BIN_4, Me.ANS_F_BIN_4)
        AppModule.SetForm_ANS_F_SEAT_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_4, Me.ANS_F_SEAT_4)
        AppModule.SetForm_ANS_F_SEAT_KIBOU4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_KIBOU4, Me.ANS_F_SEAT_KIBOU4)

        '交通（復路５）
        AppModule.SetForm_REQ_F_TEHAI_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TEHAI_5, Me.REQ_F_TEHAI_5)
        AppModule.SetForm_REQ_F_IRAINAIYOU_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_IRAINAIYOU_5, Me.REQ_F_IRAINAIYOU_5)
        AppModule.SetForm_REQ_F_KOTSUKIKAN_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_KOTSUKIKAN_5, Me.REQ_F_KOTSUKIKAN_5)
        AppModule.SetForm_REQ_F_DATE_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_DATE_5, Me.REQ_F_DATE_5)
        AppModule.SetForm_REQ_F_AIRPORT1_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT1_5, Me.REQ_F_AIRPORT1_5)
        AppModule.SetForm_REQ_F_AIRPORT2_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT2_5, Me.REQ_F_AIRPORT2_5)
        AppModule.SetForm_REQ_F_TIME1_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME1_5, Me.REQ_F_TIME1_5)
        AppModule.SetForm_REQ_F_TIME2_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME2_5, Me.REQ_F_TIME2_5)
        AppModule.SetForm_REQ_F_BIN_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_BIN_5, Me.REQ_F_BIN_5)
        AppModule.SetForm_REQ_F_SEAT_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_5, Me.REQ_F_SEAT_5)
        AppModule.SetForm_REQ_F_SEAT_KIBOU5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_KIBOU5, Me.REQ_F_SEAT_KIBOU5)
        AppModule.SetForm_ANS_F_STATUS_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_STATUS_5, Me.ANS_F_STATUS_5)
        AppModule.SetForm_ANS_F_KOTSUKIKAN_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_KOTSUKIKAN_5, Me.ANS_F_KOTSUKIKAN_5)
        AppModule.SetForm_ANS_F_DATE_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_DATE_5, Me.ANS_F_DATE_5)
        AppModule.SetForm_ANS_F_AIRPORT1_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT1_5, Me.ANS_F_AIRPORT1_5)
        AppModule.SetForm_ANS_F_AIRPORT2_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_AIRPORT2_5, Me.ANS_F_AIRPORT2_5)
        AppModule.SetForm_ANS_F_TIME1_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME1_5, Me.ANS_F_TIME1_5)
        AppModule.SetForm_ANS_F_TIME2_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_TIME2_5, Me.ANS_F_TIME2_5)
        AppModule.SetForm_ANS_F_BIN_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_BIN_5, Me.ANS_F_BIN_5)
        AppModule.SetForm_ANS_F_SEAT_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_5, Me.ANS_F_SEAT_5)
        AppModule.SetForm_ANS_F_SEAT_KIBOU5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_F_SEAT_KIBOU5, Me.ANS_F_SEAT_KIBOU5)

        '交通備考
        AppModule.SetForm_REQ_KOTSU_BIKO(DSP_KOTSUHOTEL(DSP_SEQ).REQ_KOTSU_BIKO, Me.REQ_KOTSU_BIKO)
        AppModule.SetForm_ANS_KOTSU_BIKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_KOTSU_BIKO, Me.ANS_KOTSU_BIKO)

        'タクチケ手配
        AppModule.SetForm_TEHAI_TAXI(DSP_KOTSUHOTEL(DSP_SEQ).TEHAI_TAXI, Me.TEHAI_TAXI)
        AppModule.SetForm_REQ_TAXI_NOTE(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_NOTE, Me.REQ_TAXI_NOTE)
        AppModule.SetForm_ANS_TAXI_NOTE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NOTE, Me.ANS_TAXI_NOTE)

        'タクチケ（依頼）
        '行程１
        AppModule.SetForm_REQ_TAXI_DATE_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_1, Me.REQ_TAXI_DATE_1)
        AppModule.SetForm_REQ_TAXI_FROM_1(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_1, Me.REQ_TAXI_FROM_1)
        AppModule.SetForm_TAXI_YOTEIKINGAKU_1(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_1, Me.TAXI_YOTEIKINGAKU_1)
        '行程２
        AppModule.SetForm_REQ_TAXI_DATE_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_2, Me.REQ_TAXI_DATE_2)
        AppModule.SetForm_REQ_TAXI_FROM_2(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_2, Me.REQ_TAXI_FROM_2)
        AppModule.SetForm_TAXI_YOTEIKINGAKU_2(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_2, Me.TAXI_YOTEIKINGAKU_2)
        '行程３
        AppModule.SetForm_REQ_TAXI_DATE_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_3, Me.REQ_TAXI_DATE_3)
        AppModule.SetForm_REQ_TAXI_FROM_3(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_3, Me.REQ_TAXI_FROM_3)
        AppModule.SetForm_TAXI_YOTEIKINGAKU_3(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_3, Me.TAXI_YOTEIKINGAKU_3)
        '行程４
        AppModule.SetForm_REQ_TAXI_DATE_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_4, Me.REQ_TAXI_DATE_4)
        AppModule.SetForm_REQ_TAXI_FROM_4(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_4, Me.REQ_TAXI_FROM_4)
        AppModule.SetForm_TAXI_YOTEIKINGAKU_4(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_4, Me.TAXI_YOTEIKINGAKU_4)
        '行程５
        AppModule.SetForm_REQ_TAXI_DATE_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_5, Me.REQ_TAXI_DATE_5)
        AppModule.SetForm_REQ_TAXI_FROM_5(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_5, Me.REQ_TAXI_FROM_5)
        AppModule.SetForm_TAXI_YOTEIKINGAKU_5(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_5, Me.TAXI_YOTEIKINGAKU_5)
        '行程６
        AppModule.SetForm_REQ_TAXI_DATE_6(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_6, Me.REQ_TAXI_DATE_6)
        AppModule.SetForm_REQ_TAXI_FROM_6(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_6, Me.REQ_TAXI_FROM_6)
        AppModule.SetForm_TAXI_YOTEIKINGAKU_6(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_6, Me.TAXI_YOTEIKINGAKU_6)
        '行程７
        AppModule.SetForm_REQ_TAXI_DATE_7(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_7, Me.REQ_TAXI_DATE_7)
        AppModule.SetForm_REQ_TAXI_FROM_7(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_7, Me.REQ_TAXI_FROM_7)
        AppModule.SetForm_TAXI_YOTEIKINGAKU_7(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_7, Me.TAXI_YOTEIKINGAKU_7)
        '行程８
        AppModule.SetForm_REQ_TAXI_DATE_8(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_8, Me.REQ_TAXI_DATE_8)
        AppModule.SetForm_REQ_TAXI_FROM_8(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_8, Me.REQ_TAXI_FROM_8)
        AppModule.SetForm_TAXI_YOTEIKINGAKU_8(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_8, Me.TAXI_YOTEIKINGAKU_8)
        '行程９
        AppModule.SetForm_REQ_TAXI_DATE_9(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_9, Me.REQ_TAXI_DATE_9)
        AppModule.SetForm_REQ_TAXI_FROM_9(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_9, Me.REQ_TAXI_FROM_9)
        AppModule.SetForm_TAXI_YOTEIKINGAKU_9(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_9, Me.TAXI_YOTEIKINGAKU_9)
        '行程１０
        AppModule.SetForm_REQ_TAXI_DATE_10(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_10, Me.REQ_TAXI_DATE_10)
        AppModule.SetForm_REQ_TAXI_FROM_10(DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_10, Me.REQ_TAXI_FROM_10)
        AppModule.SetForm_TAXI_YOTEIKINGAKU_10(DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_10, Me.TAXI_YOTEIKINGAKU_10)

        'タクチケ１
        AppModule.SetForm_ANS_TAXI_DATE_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_1, Me.ANS_TAXI_DATE_1)
        AppModule.SetForm_ANS_TAXI_KENSHU_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_1, Me.ANS_TAXI_KENSHU_1)
        AppModule.SetForm_ANS_TAXI_NO_1(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_1, Me.ANS_TAXI_NO_1)
        'タクチケ２
        AppModule.SetForm_ANS_TAXI_DATE_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_2, Me.ANS_TAXI_DATE_2)
        AppModule.SetForm_ANS_TAXI_KENSHU_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_2, Me.ANS_TAXI_KENSHU_2)
        AppModule.SetForm_ANS_TAXI_NO_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_2, Me.ANS_TAXI_NO_2)
        'タクチケ３
        AppModule.SetForm_ANS_TAXI_DATE_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_3, Me.ANS_TAXI_DATE_3)
        AppModule.SetForm_ANS_TAXI_KENSHU_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_3, Me.ANS_TAXI_KENSHU_3)
        AppModule.SetForm_ANS_TAXI_NO_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_3, Me.ANS_TAXI_NO_3)
        'タクチケ４
        AppModule.SetForm_ANS_TAXI_DATE_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_4, Me.ANS_TAXI_DATE_4)
        AppModule.SetForm_ANS_TAXI_KENSHU_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_4, Me.ANS_TAXI_KENSHU_4)
        AppModule.SetForm_ANS_TAXI_NO_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_4, Me.ANS_TAXI_NO_4)
        'タクチケ５
        AppModule.SetForm_ANS_TAXI_DATE_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_5, Me.ANS_TAXI_DATE_5)
        AppModule.SetForm_ANS_TAXI_KENSHU_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_5, Me.ANS_TAXI_KENSHU_5)
        AppModule.SetForm_ANS_TAXI_NO_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_5, Me.ANS_TAXI_NO_5)
        'タクチケ６
        AppModule.SetForm_ANS_TAXI_DATE_6(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_6, Me.ANS_TAXI_DATE_6)
        AppModule.SetForm_ANS_TAXI_KENSHU_6(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_6, Me.ANS_TAXI_KENSHU_6)
        AppModule.SetForm_ANS_TAXI_NO_6(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_6, Me.ANS_TAXI_NO_6)
        'タクチケ７
        AppModule.SetForm_ANS_TAXI_DATE_7(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_7, Me.ANS_TAXI_DATE_7)
        AppModule.SetForm_ANS_TAXI_KENSHU_7(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_7, Me.ANS_TAXI_KENSHU_7)
        AppModule.SetForm_ANS_TAXI_NO_7(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_7, Me.ANS_TAXI_NO_7)
        'タクチケ８
        AppModule.SetForm_ANS_TAXI_DATE_8(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_8, Me.ANS_TAXI_DATE_8)
        AppModule.SetForm_ANS_TAXI_KENSHU_8(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_8, Me.ANS_TAXI_KENSHU_8)
        AppModule.SetForm_ANS_TAXI_NO_8(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_8, Me.ANS_TAXI_NO_8)
        'タクチケ９
        AppModule.SetForm_ANS_TAXI_DATE_9(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_9, Me.ANS_TAXI_DATE_9)
        AppModule.SetForm_ANS_TAXI_KENSHU_9(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_9, Me.ANS_TAXI_KENSHU_9)
        AppModule.SetForm_ANS_TAXI_NO_9(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_9, Me.ANS_TAXI_NO_9)
        'タクチケ１０
        AppModule.SetForm_ANS_TAXI_DATE_10(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_10, Me.ANS_TAXI_DATE_10)
        AppModule.SetForm_ANS_TAXI_KENSHU_10(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_10, Me.ANS_TAXI_KENSHU_10)
        AppModule.SetForm_ANS_TAXI_NO_10(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_10, Me.ANS_TAXI_NO_10)
        'タクチケ１１
        AppModule.SetForm_ANS_TAXI_DATE_11(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_11, Me.ANS_TAXI_DATE_11)
        AppModule.SetForm_ANS_TAXI_KENSHU_11(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_11, Me.ANS_TAXI_KENSHU_11)
        AppModule.SetForm_ANS_TAXI_NO_11(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_11, Me.ANS_TAXI_NO_11)
        'タクチケ１２
        AppModule.SetForm_ANS_TAXI_DATE_12(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_12, Me.ANS_TAXI_DATE_12)
        AppModule.SetForm_ANS_TAXI_KENSHU_12(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_12, Me.ANS_TAXI_KENSHU_12)
        AppModule.SetForm_ANS_TAXI_NO_12(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_12, Me.ANS_TAXI_NO_12)
        'タクチケ１３
        AppModule.SetForm_ANS_TAXI_DATE_13(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_13, Me.ANS_TAXI_DATE_13)
        AppModule.SetForm_ANS_TAXI_KENSHU_13(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_13, Me.ANS_TAXI_KENSHU_13)
        AppModule.SetForm_ANS_TAXI_NO_13(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_13, Me.ANS_TAXI_NO_13)
        'タクチケ１４
        AppModule.SetForm_ANS_TAXI_DATE_14(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_14, Me.ANS_TAXI_DATE_14)
        AppModule.SetForm_ANS_TAXI_KENSHU_14(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_14, Me.ANS_TAXI_KENSHU_14)
        AppModule.SetForm_ANS_TAXI_NO_14(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_14, Me.ANS_TAXI_NO_14)
        'タクチケ１５
        AppModule.SetForm_ANS_TAXI_DATE_15(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_15, Me.ANS_TAXI_DATE_15)
        AppModule.SetForm_ANS_TAXI_KENSHU_15(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_15, Me.ANS_TAXI_KENSHU_15)
        AppModule.SetForm_ANS_TAXI_NO_15(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_15, Me.ANS_TAXI_NO_15)
        'タクチケ１６
        AppModule.SetForm_ANS_TAXI_DATE_16(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_16, Me.ANS_TAXI_DATE_16)
        AppModule.SetForm_ANS_TAXI_KENSHU_16(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_16, Me.ANS_TAXI_KENSHU_16)
        AppModule.SetForm_ANS_TAXI_NO_16(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_16, Me.ANS_TAXI_NO_16)
        'タクチケ１７
        AppModule.SetForm_ANS_TAXI_DATE_17(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_17, Me.ANS_TAXI_DATE_17)
        AppModule.SetForm_ANS_TAXI_KENSHU_17(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_17, Me.ANS_TAXI_KENSHU_17)
        AppModule.SetForm_ANS_TAXI_NO_17(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_17, Me.ANS_TAXI_NO_17)
        'タクチケ１８
        AppModule.SetForm_ANS_TAXI_DATE_18(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_18, Me.ANS_TAXI_DATE_18)
        AppModule.SetForm_ANS_TAXI_KENSHU_18(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_18, Me.ANS_TAXI_KENSHU_18)
        AppModule.SetForm_ANS_TAXI_NO_18(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_18, Me.ANS_TAXI_NO_18)
        'タクチケ１９
        AppModule.SetForm_ANS_TAXI_DATE_19(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_19, Me.ANS_TAXI_DATE_19)
        AppModule.SetForm_ANS_TAXI_KENSHU_19(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_19, Me.ANS_TAXI_KENSHU_19)
        AppModule.SetForm_ANS_TAXI_NO_19(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_19, Me.ANS_TAXI_NO_19)
        'タクチケ２０
        AppModule.SetForm_ANS_TAXI_DATE_20(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_20, Me.ANS_TAXI_DATE_20)
        AppModule.SetForm_ANS_TAXI_KENSHU_20(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_20, Me.ANS_TAXI_KENSHU_20)
        AppModule.SetForm_ANS_TAXI_NO_20(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_20, Me.ANS_TAXI_NO_20)

        'MR手配情報
        AppModule.SetForm_REQ_MR_O_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).REQ_MR_O_TEHAI, Me.REQ_MR_O_TEHAI)
        AppModule.SetForm_REQ_MR_F_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).REQ_MR_F_TEHAI, Me.REQ_MR_F_TEHAI)
        AppModule.SetForm_MR_SEX(DSP_KOTSUHOTEL(DSP_SEQ).MR_SEX, Me.MR_SEX)
        AppModule.SetForm_MR_AGE(DSP_KOTSUHOTEL(DSP_SEQ).MR_AGE, Me.MR_AGE)
        AppModule.SetForm_ANS_STATUS_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_O_TEHAI, Me.ANS_MR_O_TEHAI)
        AppModule.SetForm_ANS_STATUS_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_F_TEHAI, Me.ANS_MR_F_TEHAI)
        AppModule.setform_REQ_MR_HOTEL_NOTE(DSP_KOTSUHOTEL(DSP_SEQ).REQ_MR_HOTEL_NOTE, Me.REQ_MR_HOTEL_NOTE)
        AppModule.SetForm_ANS_MR_HOTEL_NOTE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_HOTEL_NOTE, Me.ANS_MR_HOTEL_NOTE)

        '各種代金
        AppModule.SetForm_ANS_HOTELHI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTELHI, Me.ANS_HOTELHI)
        AppModule.SetForm_ANS_HOTELHI_TOZEI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTELHI_TOZEI, Me.ANS_HOTELHI_TOZEI)
        AppModule.SetForm_ANS_RAIL_FARE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_RAIL_FARE, Me.ANS_RAIL_FARE)
        AppModule.SetForm_ANS_RAIL_CANCELLATION(DSP_KOTSUHOTEL(DSP_SEQ).ANS_RAIL_CANCELLATION, Me.ANS_RAIL_CANCELLATION)
        AppModule.SetForm_ANS_OTHER_FARE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_OTHER_FARE, Me.ANS_OTHER_FARE)
        AppModule.SetForm_ANS_OTHER_CANCELLATION(DSP_KOTSUHOTEL(DSP_SEQ).ANS_OTHER_CANCELLATION, Me.ANS_OTHER_CANCELLATION)
        AppModule.setform_ANS_AIR_FARE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_AIR_FARE, Me.ANS_AIR_FARE)
        AppModule.SetForm_ANS_AIR_CANCELLATION(DSP_KOTSUHOTEL(DSP_SEQ).ANS_AIR_CANCELLATION, Me.ANS_AIR_CANCELLATION)
        AppModule.SetForm_ANS_MR_HOTELHI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_HOTELHI, Me.ANS_MR_HOTELHI)
        AppModule.SetForm_ANS_MR_HOTELHI_TOZEI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_HOTELHI_TOZEI, Me.ANS_MR_HOTELHI_TOZEI)
        AppModule.SetForm_ANS_MR_KOTSUHI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_KOTSUHI, Me.ANS_MR_KOTSUHI)
        AppModule.SetForm_ANS_TAXI_TESURYO(DSP_KOTSUHOTEL(SEQ).ANS_TAXI_TESURYO, Me.ANS_TAXI_TESURYO)
        AppModule.SetForm_ANS_KOTSUHOTEL_TESURYO(DSP_KOTSUHOTEL(SEQ).ANS_KOTSUHOTEL_TESURYO, Me.ANS_KOTSUHOTEL_TESURYO)

        '宿泊費税抜金額表示
        Dim strZeiRate As String = AppModule.GetZeiRate(DSP_KOTSUHOTEL(DSP_SEQ).FROM_DATE, MyBase.DbConnection)
        Dim strZeikomiGaku As String = CStr(CLng(Val(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTELHI)) - CLng(Val(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTELHI_TOZEI)))
        Me.ANS_HOTELHI_TF.Text = CmnModule.EditComma(AppModule.GetZeinukiGaku(strZeikomiGaku, strZeiRate))
        Dim strMrZeikomiGaku As String = CStr(CLng(Val(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_HOTELHI)) - CLng(Val(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_HOTELHI_TOZEI)))
        Me.ANS_MR_HOTELHI_TF.Text = CmnModule.EditComma(AppModule.GetZeinukiGaku(strMrZeikomiGaku, strZeiRate))
    End Sub

    '講演会最新情報取得
    Private Function GetKouenkaiData() As Boolean
        Dim wFlag As Boolean = False
        Dim wCnt As Integer = 0
        Dim strSQL As String = ""
        Dim RsData As System.Data.SqlClient.SqlDataReader

        strSQL = SQL.TBL_KOUENKAI.byKOUENKAI_NO(DSP_KOTSUHOTEL(SEQ).KOUENKAI_NO)
        strSQL &= " DESC"

        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wFlag = True

            ReDim Preserve TBL_KOUENKAI(wCnt)
            TBL_KOUENKAI(0) = AppModule.SetRsData(RsData, TBL_KOUENKAI(0))
        End If
        RsData.Close()

        Return wFlag
    End Function

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

        strSQL = SQL.TBL_KOTSUHOTEL.byNEW_TIME_STAMP(DSP_KOTSUHOTEL(SEQ).SALEFORCE_ID, DSP_KOTSUHOTEL(SEQ).TIME_STAMP_BYL, DSP_KOTSUHOTEL(SEQ).KOUENKAI_NO)

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
        TBL_KOUENKAI = Session.Item(SessionDef.TBL_KOUENKAI)
        'Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
        Session.Item(SessionDef.BackURL) = Request.Url.AbsolutePath
        'Session.Item(SessionDef.BackURL2) = Request.Url.AbsolutePath

        '履歴画面用セッション変数をクリア
        Session.Item(SessionDef.KouenkaiRireki) = True
        Session.Remove(SessionDef.KouenkaiRireki_PageIndex)
        Session.Item(SessionDef.KouenkaiRireki_SEQ) = 0
        'Session.Item(SessionDef.KouenkaiRireki_TBL_KOUENKAI) = TBL_KOUENKAI

        Dim scriptStr As String
        scriptStr = "<script type='text/javascript'>"
        scriptStr += "window.open('" & URL.KouenkaiRegist & "','_blank','width=1200,height=800,resizable=yes,scrollbars=yes,menubar=no,toolbar=no,location=no,status=no');"
        scriptStr += "</script>"
        ClientScript.RegisterStartupScript(Me.GetType(), "Detail", scriptStr)
    End Sub

    '[登録]
    Private Sub BtnSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnSubmit.Click
        '入力チェック
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

        'チケット類発送日
        If Not CmnCheck.IsNumberOnly(Me.ANS_TICKET_SEND_DAY) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("チケット類発送日（最新）"), Me)
            Return False
        End If

        If CmnCheck.IsInput(Me.ANS_TICKET_SEND_DAY) Then
            If Me.ANS_TICKET_SEND_DAY.Text.Trim.Length < 8 Then
                CmnModule.AlertMessage(MessageDef.Error.LengthEQ("チケット類発送日（最新）", 8, False), Me)
                Return False
            End If

            Dim wStr As String = StrConv(Me.ANS_TICKET_SEND_DAY.Text.Substring(0, 4) & "/" & Me.ANS_TICKET_SEND_DAY.Text.Substring(4, 2) & "/" & Me.ANS_TICKET_SEND_DAY.Text.Substring(6, 2), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("チケット類発送日（最新）"), Me)
                Return False
            End If
        End If

        '宿泊施設TEL
        If Me.ANS_HOTEL_TEL.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidTel(Me.ANS_HOTEL_TEL) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("宿泊施設TELの入力形式"), Me)
            Return False
        End If

        '宿泊日
        If Me.ANS_HOTEL_DATE.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_HOTEL_DATE) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("宿泊日"), Me)
            Return False
        End If

        '泊数
        If Me.ANS_HAKUSU.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.isnumberonly(Me.ANS_HAKUSU) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("泊数"), Me)
            Return False
        End If

        'チェックイン
        If Me.ANS_CHECKIN_TIME.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_CHECKIN_TIME) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("チェックイン"), Me)
                Return False
            Else
                Me.ANS_CHECKIN_TIME.Text = Replace(Replace(Me.ANS_CHECKIN_TIME.Text, ":", ""), "：", "")
                Me.ANS_CHECKIN_TIME.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_CHECKIN_TIME.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        'チェックアウト
        If Me.ANS_CHECKOUT_TIME.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_CHECKOUT_TIME) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("チェックアウト"), Me)
                Return False
            Else
                Me.ANS_CHECKOUT_TIME.Text = Replace(Replace(Me.ANS_CHECKOUT_TIME.Text, ":", ""), "：", "")
                Me.ANS_CHECKOUT_TIME.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_CHECKOUT_TIME.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '往路
        '利用日1
        If Me.ANS_O_DATE_1.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_O_DATE_1) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '出発時刻1
        If Me.ANS_O_TIME1_1.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME1_1) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("出発時刻"), Me)
                Return False
            Else
                Me.ANS_O_TIME1_1.Text = Replace(Replace(Me.ANS_O_TIME1_1.Text, ":", ""), "：", "")
                Me.ANS_O_TIME1_1.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME1_1.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻1
        If Me.ANS_O_TIME2_1.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME2_1) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("到着時刻"), Me)
                Return False
            Else
                Me.ANS_O_TIME2_1.Text = Replace(Replace(Me.ANS_O_TIME2_1.Text, ":", ""), "：", "")
                Me.ANS_O_TIME2_1.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME2_1.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '利用日2
        If Me.ANS_O_DATE_2.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_O_DATE_2) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '出発時刻2
        If Me.ANS_O_TIME2_1.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME2_1) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("出発時刻"), Me)
                Return False
            Else
                Me.ANS_O_TIME2_1.Text = Replace(Replace(Me.ANS_O_TIME2_1.Text, ":", ""), "：", "")
                Me.ANS_O_TIME2_1.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME2_1.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻2
        If Me.ANS_O_TIME2_2.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME2_2) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("到着時刻"), Me)
                Return False
            Else
                Me.ANS_O_TIME2_2.Text = Replace(Replace(Me.ANS_O_TIME2_2.Text, ":", ""), "：", "")
                Me.ANS_O_TIME2_2.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME2_2.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '利用日3
        If Me.ANS_O_DATE_3.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_O_DATE_3) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '出発時刻3
        If Me.ANS_O_TIME1_3.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME1_3) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("出発時刻"), Me)
                Return False
            Else
                Me.ANS_O_TIME1_3.Text = Replace(Replace(Me.ANS_O_TIME1_3.Text, ":", ""), "：", "")
                Me.ANS_O_TIME1_3.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME1_3.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻3
        If Me.ANS_O_TIME2_3.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME2_3) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("到着時刻"), Me)
                Return False
            Else
                Me.ANS_O_TIME2_3.Text = Replace(Replace(Me.ANS_O_TIME2_3.Text, ":", ""), "：", "")
                Me.ANS_O_TIME2_3.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME2_3.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '利用日4
        If Me.ANS_O_DATE_4.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_O_DATE_4) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '出発時刻4
        If Me.ANS_O_TIME1_4.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME1_4) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("出発時刻"), Me)
                Return False
            Else
                Me.ANS_O_TIME1_4.Text = Replace(Replace(Me.ANS_O_TIME1_4.Text, ":", ""), "：", "")
                Me.ANS_O_TIME1_4.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME1_4.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻4
        If Me.ANS_O_TIME2_4.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME2_4) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("到着時刻"), Me)
                Return False
            Else
                Me.ANS_O_TIME2_4.Text = Replace(Replace(Me.ANS_O_TIME2_4.Text, ":", ""), "：", "")
                Me.ANS_O_TIME2_4.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME2_4.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '利用日5
        If Me.ANS_O_DATE_5.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_O_DATE_5) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '出発時刻5
        If Me.ANS_O_TIME1_5.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME1_5) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("出発時刻"), Me)
                Return False
            Else
                Me.ANS_O_TIME1_5.Text = Replace(Replace(Me.ANS_O_TIME1_5.Text, ":", ""), "：", "")
                Me.ANS_O_TIME1_5.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME1_5.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻5
        If Me.ANS_O_TIME2_5.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME2_5) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("到着時刻"), Me)
                Return False
            Else
                Me.ANS_O_TIME2_5.Text = Replace(Replace(Me.ANS_O_TIME2_5.Text, ":", ""), "：", "")
                Me.ANS_O_TIME2_5.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME2_5.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '復路
        '利用日1
        If Me.ANS_F_DATE_1.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_F_DATE_1) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '出発時刻1
        If Me.ANS_F_TIME1_1.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME1_1) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("出発時刻"), Me)
                Return False
            Else
                Me.ANS_F_TIME1_1.Text = Replace(Replace(Me.ANS_F_TIME1_1.Text, ":", ""), "：", "")
                Me.ANS_F_TIME1_1.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME1_1.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻1
        If Me.ANS_F_TIME1_2.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME1_2) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("到着時刻"), Me)
                Return False
            Else
                Me.ANS_F_TIME1_2.Text = Replace(Replace(Me.ANS_F_TIME1_2.Text, ":", ""), "：", "")
                Me.ANS_F_TIME1_2.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME1_2.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '利用日2
        If Me.ANS_F_DATE_2.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_F_DATE_2) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '出発時刻2
        If Me.ANS_F_TIME1_2.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME1_2) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("出発時刻"), Me)
                Return False
            Else
                Me.ANS_F_TIME1_2.Text = Replace(Replace(Me.ANS_F_TIME1_2.Text, ":", ""), "：", "")
                Me.ANS_F_TIME1_2.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME1_2.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻2
        If Me.ANS_F_TIME2_2.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME2_2) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("到着時刻"), Me)
                Return False
            Else
                Me.ANS_F_TIME2_2.Text = Replace(Replace(Me.ANS_F_TIME2_2.Text, ":", ""), "：", "")
                Me.ANS_F_TIME2_2.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME2_2.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '利用日3
        If Me.ANS_F_DATE_3.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_F_DATE_3) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '出発時刻3
        If Me.ANS_F_TIME1_3.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME1_3) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("出発時刻"), Me)
                Return False
            Else
                Me.ANS_F_TIME1_3.Text = Replace(Replace(Me.ANS_F_TIME1_3.Text, ":", ""), "：", "")
                Me.ANS_F_TIME1_3.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME1_3.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻3
        If Me.ANS_F_TIME2_3.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME2_3) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("到着時刻"), Me)
                Return False
            Else
                Me.ANS_F_TIME2_3.Text = Replace(Replace(Me.ANS_F_TIME2_3.Text, ":", ""), "：", "")
                Me.ANS_F_TIME2_3.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME2_3.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '利用日4
        If Me.ANS_F_DATE_4.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_F_DATE_4) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '出発時刻4
        If Me.ANS_F_TIME1_4.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME1_4) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("出発時刻"), Me)
                Return False
            Else
                Me.ANS_F_TIME1_4.Text = Replace(Replace(Me.ANS_F_TIME1_4.Text, ":", ""), "：", "")
                Me.ANS_F_TIME1_4.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME1_4.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻4
        If Me.ANS_F_TIME2_4.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME2_4) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("到着時刻"), Me)
                Return False
            Else
                Me.ANS_F_TIME2_4.Text = Replace(Replace(Me.ANS_F_TIME2_4.Text, ":", ""), "：", "")
                Me.ANS_F_TIME2_4.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME2_4.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '利用日5
        If Me.ANS_F_DATE_5.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_F_DATE_5) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '出発時刻5
        If Me.ANS_F_TIME1_5.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME1_5) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("出発時刻"), Me)
                Return False
            Else
                Me.ANS_F_TIME1_5.Text = Replace(Replace(Me.ANS_F_TIME1_5.Text, ":", ""), "：", "")
                Me.ANS_F_TIME1_5.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME1_5.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻5
        If Me.ANS_F_TIME2_5.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME2_5) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("到着時刻"), Me)
                Return False
            Else
                Me.ANS_F_TIME2_5.Text = Replace(Replace(Me.ANS_F_TIME2_5.Text, ":", ""), "：", "")
                Me.ANS_F_TIME2_5.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME2_5.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        'タクチケ
        '利用日1
        If Me.ANS_TAXI_DATE_1.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_1) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号1
        If Me.ANS_TAXI_NO_1.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_1) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日2
        If Me.ANS_TAXI_DATE_2.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_2) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号2
        If Me.ANS_TAXI_NO_2.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_2) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日3
        If Me.ANS_TAXI_DATE_3.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_3) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号3
        If Me.ANS_TAXI_NO_3.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_3) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日4
        If Me.ANS_TAXI_DATE_4.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_4) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号4
        If Me.ANS_TAXI_NO_4.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_4) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日5
        If Me.ANS_TAXI_DATE_5.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_5) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号5
        If Me.ANS_TAXI_NO_5.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_5) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日6
        If Me.ANS_TAXI_DATE_6.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_6) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号6
        If Me.ANS_TAXI_NO_6.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_6) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日7
        If Me.ANS_TAXI_DATE_7.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_7) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号7
        If Me.ANS_TAXI_NO_7.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_7) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日8
        If Me.ANS_TAXI_DATE_8.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_8) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号8
        If Me.ANS_TAXI_NO_8.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_8) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日9
        If Me.ANS_TAXI_DATE_9.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_9) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号9
        If Me.ANS_TAXI_NO_9.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_9) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日10
        If Me.ANS_TAXI_DATE_10.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_10) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号10
        If Me.ANS_TAXI_NO_10.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_10) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日11
        If Me.ANS_TAXI_DATE_11.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_11) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号11
        If Me.ANS_TAXI_NO_11.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_11) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日12
        If Me.ANS_TAXI_DATE_12.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_12) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号12
        If Me.ANS_TAXI_NO_12.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_12) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日13
        If Me.ANS_TAXI_DATE_13.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_13) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号13
        If Me.ANS_TAXI_NO_13.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_13) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日14
        If Me.ANS_TAXI_DATE_14.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_14) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号14
        If Me.ANS_TAXI_NO_14.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_14) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日15
        If Me.ANS_TAXI_DATE_15.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_15) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号15
        If Me.ANS_TAXI_NO_15.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_15) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日16
        If Me.ANS_TAXI_DATE_16.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_16) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号16
        If Me.ANS_TAXI_NO_16.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_16) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日17
        If Me.ANS_TAXI_DATE_17.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_17) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号17
        If Me.ANS_TAXI_NO_17.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_17) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日18
        If Me.ANS_TAXI_DATE_18.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_18) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号18
        If Me.ANS_TAXI_NO_18.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_18) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日19
        If Me.ANS_TAXI_DATE_19.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_19) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号19
        If Me.ANS_TAXI_NO_19.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_19) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '利用日20
        If Me.ANS_TAXI_DATE_20.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_20) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("利用日"), Me)
            Return False
        End If

        '番号20
        If Me.ANS_TAXI_NO_20.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_20) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号"), Me)
            Return False
        End If

        '宿泊費（税込)
        If Me.ANS_HOTELHI.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_HOTELHI) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("宿泊費"), Me)
            Return False
        End If

        '宿泊費都税
        If Me.ANS_HOTELHI_TOZEI.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_HOTELHI_TOZEI) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("宿泊費都税"), Me)
            Return False
        End If

        'JR券代
        If Me.ANS_RAIL_FARE.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_RAIL_FARE) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("JR券代"), Me)
            Return False
        End If

        'JR券取消料
        If Me.ANS_RAIL_CANCELLATION.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_RAIL_CANCELLATION) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("JR券取消料"), Me)
            Return False
        End If

        'その他鉄道等代金
        If Me.ANS_OTHER_FARE.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_OTHER_FARE) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("その他鉄道等代金"), Me)
            Return False
        End If

        'その他鉄道等取消料
        If Me.ANS_OTHER_CANCELLATION.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_OTHER_CANCELLATION) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("その他鉄道等取消料"), Me)
            Return False
        End If

        '航空券代
        If Me.ANS_AIR_FARE.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_AIR_FARE) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("航空券代"), Me)
            Return False
        End If

        '航空券取消料
        If Me.ANS_AIR_CANCELLATION.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_AIR_CANCELLATION) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("航空券取消料"), Me)
            Return False
        End If

        '手数料（交通・宿泊）
        If Me.ANS_KOTSUHOTEL_TESURYO.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_KOTSUHOTEL_TESURYO) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("手数料（交通・宿泊）"), Me)
            Return False
        End If

        'タクチケ発券手数料
        If Me.ANS_TAXI_TESURYO.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_TAXI_TESURYO) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ発券手数料"), Me)
            Return False
        End If

        'MR交通費
        If Me.ANS_MR_KOTSUHI.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_MR_KOTSUHI) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("MR交通費"), Me)
            Return False
        End If

        'MR宿泊費（税込)
        If Me.ANS_MR_HOTELHI.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_MR_HOTELHI) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("MR宿泊費"), Me)
            Return False
        End If

        'MR宿泊費都税
        If Me.ANS_MR_HOTELHI_TOZEI.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_MR_HOTELHI_TOZEI) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("MR宿泊費都税"), Me)
            Return False
        End If

        Return True
    End Function

    '入力値を取得
    Private Sub GetValue(ByVal SEND_FLAG As String)
        'DR手配
        DSP_KOTSUHOTEL(SEQ).ANS_STATUS_TEHAI = AppModule.GetValue_ANS_STATUS_TEHAI(Me.ANS_STATUS_TEHAI)

        'TIMESTAMP(TOP)
        'DSP_KOTSUHOTEL(SEQ).TIME_STAMP_TOP = AppModule.GetValue_ANS_STATUS_TEHAI(Me.ANS_STATUS_TEHAI)

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
        DSP_KOTSUHOTEL(SEQ).ANS_O_KOTSUKIKAN_1 = AppModule.GetValue_ANS_O_KOTSUKIKAN_1(Me.ANS_O_KOTSUKIKAN_1)
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
        DSP_KOTSUHOTEL(SEQ).ANS_O_KOTSUKIKAN_2 = AppModule.GetValue_ANS_O_KOTSUKIKAN_2(Me.ANS_O_KOTSUKIKAN_2)
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
        DSP_KOTSUHOTEL(SEQ).ANS_O_KOTSUKIKAN_3 = AppModule.GetValue_ANS_O_KOTSUKIKAN_3(Me.ANS_O_KOTSUKIKAN_3)
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
        DSP_KOTSUHOTEL(SEQ).ANS_O_KOTSUKIKAN_4 = AppModule.GetValue_ANS_O_KOTSUKIKAN_4(Me.ANS_O_KOTSUKIKAN_4)
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
        DSP_KOTSUHOTEL(SEQ).ANS_O_KOTSUKIKAN_5 = AppModule.GetValue_ANS_O_KOTSUKIKAN_5(Me.ANS_O_KOTSUKIKAN_5)
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
        DSP_KOTSUHOTEL(SEQ).ANS_F_KOTSUKIKAN_1 = AppModule.GetValue_ANS_F_KOTSUKIKAN_1(Me.ANS_F_KOTSUKIKAN_1)
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
        DSP_KOTSUHOTEL(SEQ).ANS_F_KOTSUKIKAN_2 = AppModule.GetValue_ANS_F_KOTSUKIKAN_2(Me.ANS_F_KOTSUKIKAN_2)
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
        DSP_KOTSUHOTEL(SEQ).ANS_F_KOTSUKIKAN_3 = AppModule.GetValue_ANS_F_KOTSUKIKAN_3(Me.ANS_F_KOTSUKIKAN_3)
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
        DSP_KOTSUHOTEL(SEQ).ANS_F_KOTSUKIKAN_4 = AppModule.GetValue_ANS_F_KOTSUKIKAN_4(Me.ANS_F_KOTSUKIKAN_4)
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
        DSP_KOTSUHOTEL(SEQ).ANS_F_KOTSUKIKAN_5 = AppModule.GetValue_ANS_F_KOTSUKIKAN_5(Me.ANS_F_KOTSUKIKAN_5)
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
        DSP_KOTSUHOTEL(SEQ).ANS_MR_HOTEL_NOTE = AppModule.GetValue_ANS_MR_HOTEL_NOTE(Me.ANS_MR_HOTEL_NOTE)

        '各種代金
        DSP_KOTSUHOTEL(SEQ).ANS_HOTELHI = AppModule.GetValue_ANS_HOTELHI(Me.ANS_HOTELHI)
        DSP_KOTSUHOTEL(SEQ).ANS_HOTELHI_TOZEI = AppModule.GetValue_ANS_HOTELHI_TOZEI(Me.ANS_HOTELHI_TOZEI)
        DSP_KOTSUHOTEL(SEQ).ANS_RAIL_FARE = AppModule.GetValue_ANS_RAIL_FARE(Me.ANS_RAIL_FARE)
        DSP_KOTSUHOTEL(SEQ).ANS_RAIL_CANCELLATION = AppModule.GetValue_ANS_RAIL_CANCELLATION(Me.ANS_RAIL_CANCELLATION)
        DSP_KOTSUHOTEL(SEQ).ANS_OTHER_FARE = AppModule.GetValue_ANS_OTHER_FARE(Me.ANS_OTHER_FARE)
        DSP_KOTSUHOTEL(SEQ).ANS_OTHER_CANCELLATION = AppModule.GetValue_ANS_OTHER_CANCELLATION(Me.ANS_OTHER_CANCELLATION)
        DSP_KOTSUHOTEL(SEQ).ANS_AIR_FARE = AppModule.GetValue_ANS_AIR_FARE(Me.ANS_AIR_FARE)
        DSP_KOTSUHOTEL(SEQ).ANS_AIR_CANCELLATION = AppModule.GetValue_ANS_AIR_CANCELLATION(Me.ANS_AIR_CANCELLATION)
        DSP_KOTSUHOTEL(SEQ).ANS_KOTSUHOTEL_TESURYO = AppModule.GetValue_ANS_KOTSUHOTEL_TESURYO(Me.ANS_KOTSUHOTEL_TESURYO)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_TESURYO = AppModule.GetValue_ANS_TAXI_TESURYO(Me.ANS_TAXI_TESURYO)
        DSP_KOTSUHOTEL(SEQ).ANS_MR_KOTSUHI = AppModule.GetValue_ANS_MR_KOTSUHI(Me.ANS_MR_KOTSUHI)
        DSP_KOTSUHOTEL(SEQ).ANS_MR_HOTELHI = AppModule.GetValue_ANS_MR_HOTELHI(Me.ANS_MR_HOTELHI)
        DSP_KOTSUHOTEL(SEQ).ANS_MR_HOTELHI_TOZEI = AppModule.GetValue_ANS_MR_HOTELHI_TOZEI(Me.ANS_MR_HOTELHI_TOZEI)

        DSP_KOTSUHOTEL(SEQ).SEND_FLAG = SEND_FLAG
        DSP_KOTSUHOTEL(SEQ).UPDATE_DATE = DSP_KOTSUHOTEL(SEQ).TIME_STAMP_TOP
        DSP_KOTSUHOTEL(SEQ).UPDATE_USER = Session.Item(SessionDef.LoginID)

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

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.DrRegist, DSP_KOTSUHOTEL(SEQ), True, "", MyBase.DbConnection)

            MyBase.Commit()
            Return True
        Catch ex As Exception
            MyBase.Rollback()

            'ログ登録
            MyModule.InsertTBL_LOG(AppConst.TBL_LOG.SYORI_NAME.GAMEN.GamenType.DrRegist, DSP_KOTSUHOTEL(SEQ), False, Session.Item(SessionDef.DbError), MyBase.DbConnection)
            Throw New Exception(ex.ToString & Session.Item(SessionDef.DbError))

            Throw New Exception(Session.Item(SessionDef.DbError) & vbNewLine & Trim(strSQL))
            Return False
        End Try

        Return True
    End Function

    '交通往路１コピーボタン
    Protected Sub BtnCopy_O_TEHAI_1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCopy_O_TEHAI_1.Click
        '何れかの項目が入力済みの場合、確認メッセージ表示
        If ANS_O_KOTSUKIKAN_1.SelectedIndex >= 1 OrElse _
            ANS_O_DATE_1.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT1_1.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT2_1.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME1_1.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME2_1.Text.Trim <> String.Empty OrElse _
            ANS_O_BIN_1.Text.Trim <> String.Empty OrElse _
            ANS_O_SEAT_1.SelectedIndex >= 1 OrElse _
            ANS_O_SEAT_KIBOU1.SelectedIndex >= 1 Then

            CmnModule.AlertMessage(MessageDef.Error.Copy, Me)
            Exit Sub
        End If

        '交通機関
        For i As Integer = 0 To ANS_O_KOTSUKIKAN_1.Items.Count - 1
            If REQ_O_KOTSUKIKAN_1.Text = ANS_O_KOTSUKIKAN_1.Items(i).Text Then
                ANS_O_KOTSUKIKAN_1.SelectedIndex = i
                Exit For
            End If
        Next

        '利用日
        ANS_O_DATE_1.Text = Trim(Replace(REQ_O_DATE_1.Text, "/", ""))
        '出発地
        ANS_O_AIRPORT1_1.Text = Trim(REQ_O_AIRPORT1_1.Text)
        '到着地
        ANS_O_AIRPORT2_1.Text = Trim(REQ_O_AIRPORT2_1.Text)
        '出発時刻
        ANS_O_TIME1_1.Text = Trim(Replace(Replace(REQ_O_TIME1_1.Text, ":", ""), "：", ""))
        '到着時刻
        ANS_O_TIME2_1.Text = Trim(Replace(Replace(REQ_O_TIME2_1.Text, ":", ""), "：", ""))
        '列車・便名
        ANS_O_BIN_1.Text = Trim(REQ_O_BIN_1.Text)

        '座席区分
        For i As Integer = 0 To ANS_O_SEAT_1.Items.Count - 1
            If REQ_O_SEAT_1.Text = ANS_O_SEAT_1.Items(i).Text Then
                ANS_O_SEAT_1.SelectedIndex = i
                Exit For
            End If
        Next

        '座席希望
        For i As Integer = 0 To ANS_O_SEAT_KIBOU1.Items.Count - 1
            If REQ_O_SEAT_KIBOU1.Text = ANS_O_SEAT_KIBOU1.Items(i).Text Then
                ANS_O_SEAT_KIBOU1.SelectedIndex = i
                Exit For
            End If
        Next

        SetFocus(Me.ANS_O_KOTSUKIKAN_1)
    End Sub

    '交通往路２コピーボタン
    Protected Sub BtnCopy_O_TEHAI_2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCopy_O_TEHAI_2.Click
        '何れかの項目が入力済みの場合、確認メッセージ表示
        If ANS_O_KOTSUKIKAN_2.SelectedIndex >= 1 OrElse _
            ANS_O_DATE_2.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT1_2.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT2_2.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME1_2.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME2_2.Text.Trim <> String.Empty OrElse _
            ANS_O_BIN_2.Text.Trim <> String.Empty OrElse _
            ANS_O_SEAT_2.SelectedIndex >= 1 OrElse _
            ANS_O_SEAT_kibou2.SelectedIndex >= 1 Then

            CmnModule.AlertMessage(MessageDef.Error.Copy, Me)
            Exit Sub
        End If

        '交通機関
        For i As Integer = 0 To ANS_O_KOTSUKIKAN_2.Items.Count - 1
            If REQ_O_KOTSUKIKAN_2.Text = ANS_O_KOTSUKIKAN_2.Items(i).Text Then
                ANS_O_KOTSUKIKAN_2.SelectedIndex = i
                Exit For
            End If
        Next

        '利用日
        ANS_O_DATE_2.Text = Trim(Replace(REQ_O_DATE_2.Text, "/", ""))
        '出発地
        ANS_O_AIRPORT1_2.Text = Trim(REQ_O_AIRPORT1_2.Text)
        '到着地
        ANS_O_AIRPORT2_2.Text = Trim(REQ_O_AIRPORT2_2.Text)
        '出発時刻
        ANS_O_TIME1_2.Text = Trim(Replace(Replace(REQ_O_TIME1_2.Text, ":", ""), "：", ""))
        '到着時刻
        ANS_O_TIME2_2.Text = Trim(Replace(Replace(REQ_O_TIME2_2.Text, ":", ""), "：", ""))
        '列車・便名
        ANS_O_BIN_2.Text = Trim(REQ_O_BIN_2.Text)

        '座席区分
        For i As Integer = 0 To ANS_O_SEAT_2.Items.Count - 1
            If REQ_O_SEAT_2.Text = ANS_O_SEAT_2.Items(i).Text Then
                ANS_O_SEAT_2.SelectedIndex = i
                Exit For
            End If
        Next

        '座席希望
        For i As Integer = 0 To ANS_O_SEAT_kibou2.Items.Count - 1
            If REQ_O_SEAT_kibou2.Text = ANS_O_SEAT_kibou2.Items(i).Text Then
                ANS_O_SEAT_kibou2.SelectedIndex = i
                Exit For
            End If
        Next

        SetFocus(Me.ANS_O_KOTSUKIKAN_2)
    End Sub

    '交通往路３コピーボタン
    Protected Sub BtnCopy_O_TEHAI_3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCopy_O_TEHAI_3.Click
        '何れかの項目が入力済みの場合、確認メッセージ表示
        If ANS_O_KOTSUKIKAN_3.SelectedIndex >= 1 OrElse _
            ANS_O_DATE_3.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT1_3.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT2_3.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME1_3.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME2_3.Text.Trim <> String.Empty OrElse _
            ANS_O_BIN_3.Text.Trim <> String.Empty OrElse _
            ANS_O_SEAT_3.SelectedIndex >= 1 OrElse _
            ANS_O_SEAT_kibou3.SelectedIndex >= 1 Then

            CmnModule.AlertMessage(MessageDef.Error.Copy, Me)
            Exit Sub
        End If

        '交通機関
        For i As Integer = 0 To ANS_O_KOTSUKIKAN_3.Items.Count - 1
            If REQ_O_KOTSUKIKAN_3.Text = ANS_O_KOTSUKIKAN_3.Items(i).Text Then
                ANS_O_KOTSUKIKAN_3.SelectedIndex = i
                Exit For
            End If
        Next

        '利用日
        ANS_O_DATE_3.Text = Trim(Replace(REQ_O_DATE_3.Text, "/", ""))
        '出発地
        ANS_O_AIRPORT1_3.Text = Trim(REQ_O_AIRPORT1_3.Text)
        '到着地
        ANS_O_AIRPORT2_3.Text = Trim(REQ_O_AIRPORT2_3.Text)
        '出発時刻
        ANS_O_TIME1_3.Text = Trim(Replace(Replace(REQ_O_TIME1_3.Text, ":", ""), "：", ""))
        '到着時刻
        ANS_O_TIME2_3.Text = Trim(Replace(Replace(REQ_O_TIME2_3.Text, ":", ""), "：", ""))
        '列車・便名
        ANS_O_BIN_3.Text = Trim(REQ_O_BIN_3.Text)

        '座席区分
        For i As Integer = 0 To ANS_O_SEAT_3.Items.Count - 1
            If REQ_O_SEAT_3.Text = ANS_O_SEAT_3.Items(i).Text Then
                ANS_O_SEAT_3.SelectedIndex = i
                Exit For
            End If
        Next

        '座席希望
        For i As Integer = 0 To ANS_O_SEAT_kibou3.Items.Count - 1
            If REQ_O_SEAT_kibou3.Text = ANS_O_SEAT_kibou3.Items(i).Text Then
                ANS_O_SEAT_kibou3.SelectedIndex = i
                Exit For
            End If
        Next

        SetFocus(Me.ANS_O_KOTSUKIKAN_3)
    End Sub

    '交通往路４コピーボタン
    Protected Sub BtnCopy_O_TEHAI_4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCopy_O_TEHAI_4.Click
        '何れかの項目が入力済みの場合、確認メッセージ表示
        If ANS_O_KOTSUKIKAN_4.SelectedIndex >= 1 OrElse _
            ANS_O_DATE_4.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT1_4.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT2_4.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME1_4.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME2_4.Text.Trim <> String.Empty OrElse _
            ANS_O_BIN_4.Text.Trim <> String.Empty OrElse _
            ANS_O_SEAT_4.SelectedIndex >= 1 OrElse _
            ANS_O_SEAT_kibou4.SelectedIndex >= 1 Then

            CmnModule.AlertMessage(MessageDef.Error.Copy, Me)
            Exit Sub
        End If

        '交通機関
        For i As Integer = 0 To ANS_O_KOTSUKIKAN_4.Items.Count - 1
            If REQ_O_KOTSUKIKAN_4.Text = ANS_O_KOTSUKIKAN_4.Items(i).Text Then
                ANS_O_KOTSUKIKAN_4.SelectedIndex = i
                Exit For
            End If
        Next

        '利用日
        ANS_O_DATE_4.Text = Trim(Replace(REQ_O_DATE_4.Text, "/", ""))
        '出発地
        ANS_O_AIRPORT1_4.Text = Trim(REQ_O_AIRPORT1_4.Text)
        '到着地
        ANS_O_AIRPORT2_4.Text = Trim(REQ_O_AIRPORT2_4.Text)
        '出発時刻
        ANS_O_TIME1_4.Text = Trim(Replace(Replace(REQ_O_TIME1_4.Text, ":", ""), "：", ""))
        '到着時刻
        ANS_O_TIME2_4.Text = Trim(Replace(Replace(REQ_O_TIME2_4.Text, ":", ""), "：", ""))
        '列車・便名
        ANS_O_BIN_4.Text = Trim(REQ_O_BIN_4.Text)

        '座席区分
        For i As Integer = 0 To ANS_O_SEAT_4.Items.Count - 1
            If REQ_O_SEAT_4.Text = ANS_O_SEAT_4.Items(i).Text Then
                ANS_O_SEAT_4.SelectedIndex = i
                Exit For
            End If
        Next

        '座席希望
        For i As Integer = 0 To ANS_O_SEAT_kibou4.Items.Count - 1
            If REQ_O_SEAT_KIBOU4.Text = ANS_O_SEAT_KIBOU4.Items(i).Text Then
                ANS_O_SEAT_KIBOU4.SelectedIndex = i
                Exit For
            End If
        Next

        SetFocus(Me.ANS_O_KOTSUKIKAN_4)
    End Sub

    '交通往路５コピーボタン
    Protected Sub BtnCopy_O_TEHAI_5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCopy_O_TEHAI_5.Click
        '何れかの項目が入力済みの場合、確認メッセージ表示
        If ANS_O_KOTSUKIKAN_5.SelectedIndex >= 1 OrElse _
            ANS_O_DATE_5.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT1_5.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT2_5.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME1_5.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME2_5.Text.Trim <> String.Empty OrElse _
            ANS_O_BIN_5.Text.Trim <> String.Empty OrElse _
            ANS_O_SEAT_5.SelectedIndex >= 1 OrElse _
            ANS_O_SEAT_kibou4.SelectedIndex >= 1 Then

            CmnModule.AlertMessage(MessageDef.Error.Copy, Me)
            Exit Sub
        End If

        '交通機関
        For i As Integer = 0 To ANS_O_KOTSUKIKAN_5.Items.Count - 1
            If REQ_O_KOTSUKIKAN_5.Text = ANS_O_KOTSUKIKAN_5.Items(i).Text Then
                ANS_O_KOTSUKIKAN_5.SelectedIndex = i
                Exit For
            End If
        Next

        '利用日
        ANS_O_DATE_5.Text = Trim(Replace(REQ_O_DATE_5.Text, "/", ""))
        '出発地
        ANS_O_AIRPORT1_5.Text = Trim(REQ_O_AIRPORT1_5.Text)
        '到着地
        ANS_O_AIRPORT2_5.Text = Trim(REQ_O_AIRPORT2_5.Text)
        '出発時刻
        ANS_O_TIME1_5.Text = Trim(Replace(Replace(REQ_O_TIME1_5.Text, ":", ""), "：", ""))
        '到着時刻
        ANS_O_TIME2_5.Text = Trim(Replace(Replace(REQ_O_TIME2_5.Text, ":", ""), "：", ""))
        '列車・便名
        ANS_O_BIN_5.Text = Trim(REQ_O_BIN_5.Text)

        '座席区分
        For i As Integer = 0 To ANS_O_SEAT_5.Items.Count - 1
            If REQ_O_SEAT_5.Text = ANS_O_SEAT_5.Items(i).Text Then
                ANS_O_SEAT_5.SelectedIndex = i
                Exit For
            End If
        Next

        '座席希望
        For i As Integer = 0 To ANS_O_SEAT_KIBOU5.Items.Count - 1
            If REQ_O_SEAT_KIBOU5.Text = ANS_O_SEAT_KIBOU5.Items(i).Text Then
                ANS_O_SEAT_KIBOU5.SelectedIndex = i
                Exit For
            End If
        Next

        SetFocus(Me.ANS_O_KOTSUKIKAN_5)
    End Sub
    '交通往路１コピーボタン
    Protected Sub BtnCopy_F_TEHAI_1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCopy_F_TEHAI_1.Click
        Dim wStr As String

        '何れかの項目が入力済みの場合、確認メッセージ表示
        If ANS_F_KOTSUKIKAN_1.SelectedIndex >= 1 OrElse _
            ANS_F_DATE_1.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT1_1.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT2_1.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME1_1.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME2_1.Text.Trim <> String.Empty OrElse _
            ANS_F_BIN_1.Text.Trim <> String.Empty OrElse _
            ANS_F_SEAT_1.SelectedIndex >= 1 OrElse _
            ANS_F_SEAT_KIBOU1.SelectedIndex >= 1 Then

            CmnModule.AlertMessage(MessageDef.Error.Copy, Me)
            Exit Sub
        End If

        '交通機関
        For i As Integer = 0 To ANS_F_KOTSUKIKAN_1.Items.Count - 1
            If REQ_F_KOTSUKIKAN_1.Text = ANS_F_KOTSUKIKAN_1.Items(i).Text Then
                ANS_F_KOTSUKIKAN_1.SelectedIndex = i
                Exit For
            End If
        Next

        '利用日
        ANS_F_DATE_1.Text = Trim(Replace(REQ_F_DATE_1.Text, "/", ""))
        '出発地
        ANS_F_AIRPORT1_1.Text = Trim(REQ_F_AIRPORT1_1.Text)
        '到着地
        ANS_F_AIRPORT2_1.Text = Trim(REQ_F_AIRPORT2_1.Text)
        '出発時刻
        ANS_F_TIME1_1.Text = Trim(Replace(Replace(REQ_F_TIME1_1.Text, ":", ""), "：", ""))
        '到着時刻
        ANS_F_TIME2_1.Text = Trim(Replace(Replace(REQ_F_TIME2_1.Text, ":", ""), "：", ""))
        '列車・便名
        ANS_F_BIN_1.Text = Trim(REQ_F_BIN_1.Text)

        '座席区分
        For i As Integer = 0 To ANS_F_SEAT_1.Items.Count - 1
            If REQ_F_SEAT_1.Text = ANS_F_SEAT_1.Items(i).Text Then
                ANS_F_SEAT_1.SelectedIndex = i
                Exit For
            End If
        Next

        '座席希望
        For i As Integer = 0 To ANS_F_SEAT_KIBOU1.Items.Count - 1
            If REQ_F_SEAT_KIBOU1.Text = ANS_F_SEAT_KIBOU1.Items(i).Text Then
                ANS_F_SEAT_KIBOU1.SelectedIndex = i
                Exit For
            End If
        Next

        SetFocus(Me.ANS_F_KOTSUKIKAN_1)
    End Sub

    '交通往路２コピーボタン
    Protected Sub BtnCopy_F_TEHAI_2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCopy_F_TEHAI_2.Click
        '何れかの項目が入力済みの場合、確認メッセージ表示
        If ANS_F_KOTSUKIKAN_2.SelectedIndex >= 1 OrElse _
            ANS_F_DATE_2.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT1_2.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT2_2.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME1_2.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME2_2.Text.Trim <> String.Empty OrElse _
            ANS_F_BIN_2.Text.Trim <> String.Empty OrElse _
            ANS_F_SEAT_2.SelectedIndex >= 1 OrElse _
            ANS_F_SEAT_kibou2.SelectedIndex >= 1 Then

            CmnModule.AlertMessage(MessageDef.Error.Copy, Me)
            Exit Sub
        End If

        '交通機関
        For i As Integer = 0 To ANS_F_KOTSUKIKAN_2.Items.Count - 1
            If REQ_F_KOTSUKIKAN_2.Text = ANS_F_KOTSUKIKAN_2.Items(i).Text Then
                ANS_F_KOTSUKIKAN_2.SelectedIndex = i
                Exit For
            End If
        Next

        '利用日
        ANS_F_DATE_2.Text = Trim(Replace(REQ_F_DATE_2.Text, "/", ""))
        '出発地
        ANS_F_AIRPORT1_2.Text = Trim(REQ_F_AIRPORT1_2.Text)
        '到着地
        ANS_F_AIRPORT2_2.Text = Trim(REQ_F_AIRPORT2_2.Text)
        '出発時刻
        ANS_F_TIME1_2.Text = Trim(Replace(Replace(REQ_F_TIME1_2.Text, ":", ""), "：", ""))
        '到着時刻
        ANS_F_TIME2_2.Text = Trim(Replace(Replace(REQ_F_TIME2_2.Text, ":", ""), "：", ""))
        '列車・便名
        ANS_F_BIN_2.Text = Trim(REQ_F_BIN_2.Text)

        '座席区分
        For i As Integer = 0 To ANS_F_SEAT_2.Items.Count - 1
            If REQ_F_SEAT_2.Text = ANS_F_SEAT_2.Items(i).Text Then
                ANS_F_SEAT_2.SelectedIndex = i
                Exit For
            End If
        Next

        '座席希望
        For i As Integer = 0 To ANS_F_SEAT_kibou2.Items.Count - 1
            If REQ_F_SEAT_kibou2.Text = ANS_F_SEAT_kibou2.Items(i).Text Then
                ANS_F_SEAT_kibou2.SelectedIndex = i
                Exit For
            End If
        Next
        SetFocus(Me.ANS_F_KOTSUKIKAN_2)
    End Sub

    '交通往路３コピーボタン
    Protected Sub BtnCopy_F_TEHAI_3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCopy_F_TEHAI_3.Click
        '何れかの項目が入力済みの場合、確認メッセージ表示
        If ANS_F_KOTSUKIKAN_3.SelectedIndex >= 1 OrElse _
            ANS_F_DATE_3.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT1_3.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT2_3.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME1_3.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME2_3.Text.Trim <> String.Empty OrElse _
            ANS_F_BIN_3.Text.Trim <> String.Empty OrElse _
            ANS_F_SEAT_3.SelectedIndex >= 1 OrElse _
            ANS_F_SEAT_kibou3.SelectedIndex >= 1 Then

            CmnModule.AlertMessage(MessageDef.Error.Copy, Me)
            Exit Sub
        End If

        '交通機関
        For i As Integer = 0 To ANS_F_KOTSUKIKAN_3.Items.Count - 1
            If REQ_F_KOTSUKIKAN_3.Text = ANS_F_KOTSUKIKAN_3.Items(i).Text Then
                ANS_F_KOTSUKIKAN_3.SelectedIndex = i
                Exit For
            End If
        Next

        '利用日
        ANS_F_DATE_3.Text = Trim(Replace(REQ_F_DATE_3.Text, "/", ""))
        '出発地
        ANS_F_AIRPORT1_3.Text = Trim(REQ_F_AIRPORT1_3.Text)
        '到着地
        ANS_F_AIRPORT2_3.Text = Trim(REQ_F_AIRPORT2_3.Text)
        '出発時刻
        ANS_F_TIME1_3.Text = Trim(Replace(Replace(REQ_F_TIME1_3.Text, ":", ""), "：", ""))
        '到着時刻
        ANS_F_TIME2_3.Text = Trim(Replace(Replace(REQ_F_TIME2_3.Text, ":", ""), "：", ""))
        '列車・便名
        ANS_F_BIN_3.Text = Trim(REQ_F_BIN_3.Text)

        '座席区分
        For i As Integer = 0 To ANS_F_SEAT_3.Items.Count - 1
            If REQ_F_SEAT_3.Text = ANS_F_SEAT_3.Items(i).Text Then
                ANS_F_SEAT_3.SelectedIndex = i
                Exit For
            End If
        Next

        '座席希望
        For i As Integer = 0 To ANS_F_SEAT_kibou3.Items.Count - 1
            If REQ_F_SEAT_kibou3.Text = ANS_F_SEAT_kibou3.Items(i).Text Then
                ANS_F_SEAT_kibou3.SelectedIndex = i
                Exit For
            End If
        Next
        SetFocus(Me.ANS_F_KOTSUKIKAN_3)
    End Sub

    '交通往路４コピーボタン
    Protected Sub BtnCopy_F_TEHAI_4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCopy_F_TEHAI_4.Click
        '何れかの項目が入力済みの場合、確認メッセージ表示
        If ANS_F_KOTSUKIKAN_4.SelectedIndex >= 1 OrElse _
            ANS_F_DATE_4.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT1_4.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT2_4.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME1_4.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME2_4.Text.Trim <> String.Empty OrElse _
            ANS_F_BIN_4.Text.Trim <> String.Empty OrElse _
            ANS_F_SEAT_4.SelectedIndex >= 1 OrElse _
            ANS_F_SEAT_kibou4.SelectedIndex >= 1 Then

            CmnModule.AlertMessage(MessageDef.Error.Copy, Me)
            Exit Sub
        End If

        '交通機関
        For i As Integer = 0 To ANS_F_KOTSUKIKAN_4.Items.Count - 1
            If REQ_F_KOTSUKIKAN_4.Text = ANS_F_KOTSUKIKAN_4.Items(i).Text Then
                ANS_F_KOTSUKIKAN_4.SelectedIndex = i
                Exit For
            End If
        Next

        '利用日
        ANS_F_DATE_4.Text = Trim(Replace(REQ_F_DATE_4.Text, "/", ""))
        '出発地
        ANS_F_AIRPORT1_4.Text = Trim(REQ_F_AIRPORT1_4.Text)
        '到着地
        ANS_F_AIRPORT2_4.Text = Trim(REQ_F_AIRPORT2_4.Text)
        '出発時刻
        ANS_F_TIME1_4.Text = Trim(Replace(Replace(REQ_F_TIME1_4.Text, ":", ""), "：", ""))
        '到着時刻
        ANS_F_TIME2_4.Text = Trim(Replace(Replace(REQ_F_TIME2_4.Text, ":", ""), "：", ""))
        '列車・便名
        ANS_F_BIN_4.Text = Trim(REQ_F_BIN_4.Text)

        '座席区分
        For i As Integer = 0 To ANS_F_SEAT_4.Items.Count - 1
            If REQ_F_SEAT_4.Text = ANS_F_SEAT_4.Items(i).Text Then
                ANS_F_SEAT_4.SelectedIndex = i
                Exit For
            End If
        Next

        '座席希望
        For i As Integer = 0 To ANS_F_SEAT_kibou4.Items.Count - 1
            If REQ_F_SEAT_kibou4.Text = ANS_F_SEAT_kibou4.Items(i).Text Then
                ANS_F_SEAT_kibou4.SelectedIndex = i
                Exit For
            End If
        Next
        SetFocus(Me.ANS_F_KOTSUKIKAN_4)
    End Sub

    '交通往路５コピーボタン
    Protected Sub BtnCopy_F_TEHAI_5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnCopy_F_TEHAI_5.Click
        '何れかの項目が入力済みの場合、確認メッセージ表示
        If ANS_F_KOTSUKIKAN_5.SelectedIndex >= 1 OrElse _
            ANS_F_DATE_5.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT1_5.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT2_5.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME1_5.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME2_5.Text.Trim <> String.Empty OrElse _
            ANS_F_BIN_5.Text.Trim <> String.Empty OrElse _
            ANS_F_SEAT_5.SelectedIndex >= 1 OrElse _
            ANS_F_SEAT_KIBOU5.SelectedIndex >= 1 Then

            CmnModule.AlertMessage(MessageDef.Error.Copy, Me)
            Exit Sub
        End If

        '交通機関
        For i As Integer = 0 To ANS_F_KOTSUKIKAN_5.Items.Count - 1
            If REQ_F_KOTSUKIKAN_5.Text = ANS_F_KOTSUKIKAN_5.Items(i).Text Then
                ANS_F_KOTSUKIKAN_5.SelectedIndex = i
                Exit For
            End If
        Next

        '利用日
        ANS_F_DATE_5.Text = Trim(Replace(REQ_F_DATE_5.Text, "/", ""))
        '出発地
        ANS_F_AIRPORT1_5.Text = Trim(REQ_F_AIRPORT1_5.Text)
        '到着地
        ANS_F_AIRPORT2_5.Text = Trim(REQ_F_AIRPORT2_5.Text)
        '出発時刻
        ANS_F_TIME1_5.Text = Trim(Replace(Replace(REQ_F_TIME1_5.Text, ":", ""), "：", ""))
        '到着時刻
        ANS_F_TIME2_5.Text = Trim(Replace(Replace(REQ_F_TIME2_5.Text, ":", ""), "：", ""))
        '列車・便名
        ANS_F_BIN_5.Text = Trim(REQ_F_BIN_5.Text)

        '座席区分
        For i As Integer = 0 To ANS_F_SEAT_5.Items.Count - 1
            If REQ_F_SEAT_5.Text = ANS_F_SEAT_5.Items(i).Text Then
                ANS_F_SEAT_5.SelectedIndex = i
                Exit For
            End If
        Next

        '座席希望
        For i As Integer = 0 To ANS_F_SEAT_kibou4.Items.Count - 1
            If REQ_F_SEAT_kibou4.Text = ANS_F_SEAT_kibou4.Items(i).Text Then
                ANS_F_SEAT_kibou4.SelectedIndex = i
                Exit For
            End If
        Next
        SetFocus(Me.ANS_F_KOTSUKIKAN_5)
    End Sub

    '[戻る]
    Private Sub BtnBack1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click
        Session.Remove(SessionDef.DrRireki_PageIndex)
        Session.Remove(SessionDef.DrRireki_SEQ)

        If Popup Then
            Dim scriptStr As String = ""
            scriptStr &= "<script language='javascript' type='text/javascript'>"
            scriptStr &= "window.opener.aspnetForm.submit();"
            scriptStr &= "window.close();"
            scriptStr &= "</script>"

            ClientScript.RegisterStartupScript(Me.GetType(), "Detail", scriptStr)
        Else
            Response.Redirect(Session.Item(SessionDef.BackURL2))
        End If
    End Sub

    '[戻る]
    Private Sub BtnBack2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack2.Click
        BtnBack1_Click(sender, e)
    End Sub

    '[手配書印刷]
    Private Sub BtnPrint1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint1.Click
        Dim strSQL As String = ""
        strSQL = SQL.TBL_KOTSUHOTEL.DrReport(DSP_KOTSUHOTEL(SEQ).KOUENKAI_NO, DSP_KOTSUHOTEL(SEQ).SANKASHA_ID)
        Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
        Session.Item(SessionDef.TBL_KOTSUHOTEL) = TBL_KOTSUHOTEL
        Session.Item(SessionDef.TehaishoPrint_SQL) = strSQL
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Response.Redirect(URL.Preview)
    End Sub

    '[手配書印刷]
    Private Sub BtnPrint2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint2.Click
        BtnPrint1_Click(sender, e)
    End Sub

    '宿泊費消費税抜金額表示
    Private Sub ANS_HOTELHI_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ANS_HOTELHI.TextChanged

        '宿泊費（税込)
        If Me.ANS_HOTELHI.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_HOTELHI) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("宿泊費"), Me)
            Exit Sub
        End If

        '宿泊費都税
        If Me.ANS_HOTELHI_TOZEI.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_HOTELHI_TOZEI) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("宿泊費都税"), Me)
            Exit Sub
        End If

        Dim strZeiRate As String = AppModule.GetZeiRate(DSP_KOTSUHOTEL(SEQ).FROM_DATE, MyBase.DbConnection)
        Dim strZeikomiGaku As String = CStr(CLng(Val(Me.ANS_HOTELHI.Text.Trim)) - CLng(Val(Me.ANS_HOTELHI_TOZEI.Text.Trim)))
        Me.ANS_HOTELHI_TF.Text = CmnModule.EditComma(AppModule.GetZeinukiGaku(strZeikomiGaku, strZeiRate))
        SetFocus(ANS_HOTELHI_TOZEI)
    End Sub

    Private Sub ANS_HOTELHI_TOZEI_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ANS_HOTELHI_TOZEI.TextChanged
        ANS_HOTELHI_TextChanged(sender, e)
    End Sub

    'MR宿泊費消費税抜金額表示
    Private Sub ANS_MR_HOTELHI_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ANS_MR_HOTELHI.TextChanged

        'MR宿泊費（税込)
        If Me.ANS_MR_HOTELHI.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_MR_HOTELHI) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("MR宿泊費"), Me)
            Exit Sub
        End If

        'MR宿泊費都税
        If Me.ANS_MR_HOTELHI_TOZEI.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_MR_HOTELHI_TOZEI) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("MR宿泊費都税"), Me)
            Exit Sub
        End If

        Dim strZeiRate As String = AppModule.GetZeiRate(DSP_KOTSUHOTEL(SEQ).FROM_DATE, MyBase.DbConnection)
        Dim strZeikomiGaku As String = CStr(CLng(Val(Me.ANS_MR_HOTELHI.Text.Trim)) - CLng(Val(Me.ANS_MR_HOTELHI_TOZEI.Text.Trim)))
        Me.ANS_MR_HOTELHI_TF.Text = CmnModule.EditComma(AppModule.GetZeinukiGaku(strZeikomiGaku, strZeiRate))
        SetFocus(ANS_MR_HOTELHI_TOZEI)
    End Sub

    Private Sub ANS_MR_HOTELHI_TOZEI_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ANS_MR_HOTELHI_TOZEI.TextChanged
        ANS_MR_HOTELHI_TextChanged(sender, e)
    End Sub

    '交通(往路)手配1クリアボタン
    Protected Sub BtnClear_O_TEHAI_1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_O_TEHAI_1.Click
        Me.ANS_O_KOTSUKIKAN_1.SelectedIndex = 0
        Me.ANS_O_DATE_1.Text = ""
        Me.ANS_O_AIRPORT1_1.Text = ""
        Me.ANS_O_AIRPORT2_1.Text = ""
        Me.ANS_O_TIME1_1.Text = ""
        Me.ANS_O_TIME2_1.Text = ""
        Me.ANS_O_BIN_1.Text = ""
        Me.ANS_O_SEAT_1.SelectedIndex = 0
        Me.ANS_O_SEAT_KIBOU1.SelectedIndex = 0
        SetFocus(Me.ANS_O_KOTSUKIKAN_1)
    End Sub

    '交通(往路)手配2クリアボタン
    Protected Sub BtnClear_O_TEHAI_2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_O_TEHAI_2.Click
        Me.ANS_O_KOTSUKIKAN_2.SelectedIndex = 0
        Me.ANS_O_DATE_2.Text = ""
        Me.ANS_O_AIRPORT1_2.Text = ""
        Me.ANS_O_AIRPORT2_2.Text = ""
        Me.ANS_O_TIME1_2.Text = ""
        Me.ANS_O_TIME2_2.Text = ""
        Me.ANS_O_BIN_2.Text = ""
        Me.ANS_O_SEAT_2.SelectedIndex = 0
        Me.ANS_O_SEAT_KIBOU2.SelectedIndex = 0
        SetFocus(Me.ANS_O_KOTSUKIKAN_2)
    End Sub

    '交通(往路)手配3クリアボタン
    Protected Sub BtnClear_O_TEHAI_3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_O_TEHAI_3.Click
        Me.ANS_O_KOTSUKIKAN_3.SelectedIndex = 0
        Me.ANS_O_DATE_3.Text = ""
        Me.ANS_O_AIRPORT1_3.Text = ""
        Me.ANS_O_AIRPORT2_3.Text = ""
        Me.ANS_O_TIME1_3.Text = ""
        Me.ANS_O_TIME2_3.Text = ""
        Me.ANS_O_BIN_3.Text = ""
        Me.ANS_O_SEAT_3.SelectedIndex = 0
        Me.ANS_O_SEAT_KIBOU3.SelectedIndex = 0
        SetFocus(Me.ANS_O_KOTSUKIKAN_3)
    End Sub

    '交通(往路)手配4クリアボタン
    Protected Sub BtnClear_O_TEHAI_4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_O_TEHAI_4.Click
        Me.ANS_O_KOTSUKIKAN_4.SelectedIndex = 0
        Me.ANS_O_DATE_4.Text = ""
        Me.ANS_O_AIRPORT1_4.Text = ""
        Me.ANS_O_AIRPORT2_4.Text = ""
        Me.ANS_O_TIME1_4.Text = ""
        Me.ANS_O_TIME2_4.Text = ""
        Me.ANS_O_BIN_4.Text = ""
        Me.ANS_O_SEAT_4.SelectedIndex = 0
        Me.ANS_O_SEAT_KIBOU4.SelectedIndex = 0
        SetFocus(Me.ANS_O_KOTSUKIKAN_4)
    End Sub

    '交通(往路)手配5クリアボタン
    Protected Sub BtnClear_O_TEHAI_5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_O_TEHAI_5.Click
        Me.ANS_O_KOTSUKIKAN_5.SelectedIndex = 0
        Me.ANS_O_DATE_5.Text = ""
        Me.ANS_O_AIRPORT1_5.Text = ""
        Me.ANS_O_AIRPORT2_5.Text = ""
        Me.ANS_O_TIME1_5.Text = ""
        Me.ANS_O_TIME2_5.Text = ""
        Me.ANS_O_BIN_5.Text = ""
        Me.ANS_O_SEAT_5.SelectedIndex = 0
        Me.ANS_O_SEAT_KIBOU5.SelectedIndex = 0
        SetFocus(Me.ANS_O_KOTSUKIKAN_5)
    End Sub

    '交通(復路)手配1クリアボタン
    Protected Sub BtnClear_F_TEHAI_1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_F_TEHAI_1.Click
        Me.ANS_F_KOTSUKIKAN_1.SelectedIndex = 0
        Me.ANS_F_DATE_1.Text = ""
        Me.ANS_F_AIRPORT1_1.Text = ""
        Me.ANS_F_AIRPORT2_1.Text = ""
        Me.ANS_F_TIME1_1.Text = ""
        Me.ANS_F_TIME2_1.Text = ""
        Me.ANS_F_BIN_1.Text = ""
        Me.ANS_F_SEAT_1.SelectedIndex = 0
        Me.ANS_F_SEAT_KIBOU1.SelectedIndex = 0
        SetFocus(Me.ANS_F_KOTSUKIKAN_1)
    End Sub

    '交通(復路)手配2クリアボタン
    Protected Sub BtnClear_F_TEHAI_2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_F_TEHAI_2.Click
        Me.ANS_F_KOTSUKIKAN_2.SelectedIndex = 0
        Me.ANS_F_DATE_2.Text = ""
        Me.ANS_F_AIRPORT1_2.Text = ""
        Me.ANS_F_AIRPORT2_2.Text = ""
        Me.ANS_F_TIME1_2.Text = ""
        Me.ANS_F_TIME2_2.Text = ""
        Me.ANS_F_BIN_2.Text = ""
        Me.ANS_F_SEAT_2.SelectedIndex = 0
        Me.ANS_F_SEAT_KIBOU2.SelectedIndex = 0
        SetFocus(Me.ANS_F_KOTSUKIKAN_2)
    End Sub

    '交通(復路)手配3クリアボタン
    Protected Sub BtnClear_F_TEHAI_3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_F_TEHAI_3.Click
        Me.ANS_F_KOTSUKIKAN_3.SelectedIndex = 0
        Me.ANS_F_DATE_3.Text = ""
        Me.ANS_F_AIRPORT1_3.Text = ""
        Me.ANS_F_AIRPORT2_3.Text = ""
        Me.ANS_F_TIME1_3.Text = ""
        Me.ANS_F_TIME2_3.Text = ""
        Me.ANS_F_BIN_3.Text = ""
        Me.ANS_F_SEAT_3.SelectedIndex = 0
        Me.ANS_F_SEAT_KIBOU3.SelectedIndex = 0
        SetFocus(Me.ANS_F_KOTSUKIKAN_3)
    End Sub

    '交通(復路)手配4クリアボタン
    Protected Sub BtnClear_F_TEHAI_4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_F_TEHAI_4.Click
        Me.ANS_F_KOTSUKIKAN_4.SelectedIndex = 0
        Me.ANS_F_DATE_4.Text = ""
        Me.ANS_F_AIRPORT1_4.Text = ""
        Me.ANS_F_AIRPORT2_4.Text = ""
        Me.ANS_F_TIME1_4.Text = ""
        Me.ANS_F_TIME2_4.Text = ""
        Me.ANS_F_BIN_4.Text = ""
        Me.ANS_F_SEAT_4.SelectedIndex = 0
        Me.ANS_F_SEAT_KIBOU4.SelectedIndex = 0
        SetFocus(Me.ANS_F_KOTSUKIKAN_4)
    End Sub

    '交通(復路)手配5クリアボタン
    Protected Sub BtnClear_F_TEHAI_5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_F_TEHAI_5.Click
        Me.ANS_F_KOTSUKIKAN_5.SelectedIndex = 0
        Me.ANS_F_DATE_5.Text = ""
        Me.ANS_F_AIRPORT1_5.Text = ""
        Me.ANS_F_AIRPORT2_5.Text = ""
        Me.ANS_F_TIME1_5.Text = ""
        Me.ANS_F_TIME2_5.Text = ""
        Me.ANS_F_BIN_5.Text = ""
        Me.ANS_F_SEAT_5.SelectedIndex = 0
        Me.ANS_F_SEAT_KIBOU5.SelectedIndex = 0
        SetFocus(Me.ANS_F_KOTSUKIKAN_5)
    End Sub

End Class
