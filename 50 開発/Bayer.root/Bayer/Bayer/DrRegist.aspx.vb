Imports CommonLib
Imports AppLib
Partial Public Class DrRegist
    Inherits WebBase

    Private TBL_KOUENKAI() As TableDef.TBL_KOUENKAI.DataStruct
    Private TBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private DSP_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
    Private OldTBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct
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

            '旧データ取得
            GetData_Old()

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

            '発行済のタクチケがある場合は、タクチケコピー・クリアボタンは使用不可
            If Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" OrElse _
                Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> "" Then

                BtnTicketCopy.Visible = False
                BtnTicketClear.Visible = False
            Else
                BtnTicketCopy.Visible = True
                BtnTicketClear.Visible = True
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

        'IME設定        CmnModule.SetIme(Me.ANS_TICKET_SEND_DAY, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_HOTEL_NAME, CmnModule.ImeType.Active)
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
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_1, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_2, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_3, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_4, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_5, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_6, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_7, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_8, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_9, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_10, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_11, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_12, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_13, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_14, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_15, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_16, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_17, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_18, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_19, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_TAXI_RMKS_20, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_MR_HOTEL_NOTE, CmnModule.ImeType.Active)
        CmnModule.SetIme(Me.ANS_HOTELHI, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_HOTELHI_TOZEI, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_HOTELHI_CANCEL, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_RAIL_FARE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_RAIL_CANCELLATION, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_OTHER_FARE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_OTHER_CANCELLATION, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_AIR_FARE, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_AIR_CANCELLATION, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_MR_HOTELHI, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_MR_HOTELHI_TOZEI, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_MR_KOTSUHI, CmnModule.ImeType.Disabled)
        CmnModule.SetIme(Me.ANS_TAXI_MAISUU, CmnModule.ImeType.Disabled)
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
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_1, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_1, Me.ANS_TAXI_HAKKO_1, Me.CHK_ANS_TAXI_HAKKO_1)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_1, Me.ANS_TAXI_HAKKO_DATE_1)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_1, Me.ANS_TAXI_RMKS_1)
        'タクチケ２
        AppModule.SetForm_ANS_TAXI_DATE_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_2, Me.ANS_TAXI_DATE_2)
        AppModule.SetForm_ANS_TAXI_KENSHU_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_2, Me.ANS_TAXI_KENSHU_2)
        AppModule.SetForm_ANS_TAXI_NO_2(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_2, Me.ANS_TAXI_NO_2)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_2, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_2, Me.ANS_TAXI_HAKKO_2, Me.CHK_ANS_TAXI_HAKKO_2)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_2, Me.ANS_TAXI_HAKKO_DATE_2)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_2, Me.ANS_TAXI_RMKS_2)
        'タクチケ３
        AppModule.SetForm_ANS_TAXI_DATE_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_3, Me.ANS_TAXI_DATE_3)
        AppModule.SetForm_ANS_TAXI_KENSHU_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_3, Me.ANS_TAXI_KENSHU_3)
        AppModule.SetForm_ANS_TAXI_NO_3(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_3, Me.ANS_TAXI_NO_3)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_3, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_3, Me.ANS_TAXI_HAKKO_3, Me.CHK_ANS_TAXI_HAKKO_3)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_3, Me.ANS_TAXI_HAKKO_DATE_3)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_3, Me.ANS_TAXI_RMKS_3)
        'タクチケ４
        AppModule.SetForm_ANS_TAXI_DATE_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_4, Me.ANS_TAXI_DATE_4)
        AppModule.SetForm_ANS_TAXI_KENSHU_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_4, Me.ANS_TAXI_KENSHU_4)
        AppModule.SetForm_ANS_TAXI_NO_4(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_4, Me.ANS_TAXI_NO_4)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_4, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_4, Me.ANS_TAXI_HAKKO_4, Me.CHK_ANS_TAXI_HAKKO_4)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_4, Me.ANS_TAXI_HAKKO_DATE_4)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_4, Me.ANS_TAXI_RMKS_4)
        'タクチケ５
        AppModule.SetForm_ANS_TAXI_DATE_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_5, Me.ANS_TAXI_DATE_5)
        AppModule.SetForm_ANS_TAXI_KENSHU_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_5, Me.ANS_TAXI_KENSHU_5)
        AppModule.SetForm_ANS_TAXI_NO_5(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_5, Me.ANS_TAXI_NO_5)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_5, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_5, Me.ANS_TAXI_HAKKO_5, Me.CHK_ANS_TAXI_HAKKO_5)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_5, Me.ANS_TAXI_HAKKO_DATE_5)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_5, Me.ANS_TAXI_RMKS_5)
        'タクチケ６
        AppModule.SetForm_ANS_TAXI_DATE_6(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_6, Me.ANS_TAXI_DATE_6)
        AppModule.SetForm_ANS_TAXI_KENSHU_6(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_6, Me.ANS_TAXI_KENSHU_6)
        AppModule.SetForm_ANS_TAXI_NO_6(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_6, Me.ANS_TAXI_NO_6)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_6, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_6, Me.ANS_TAXI_HAKKO_6, Me.CHK_ANS_TAXI_HAKKO_6)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_6, Me.ANS_TAXI_HAKKO_DATE_6)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_6, Me.ANS_TAXI_RMKS_6)
        'タクチケ７
        AppModule.SetForm_ANS_TAXI_DATE_7(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_7, Me.ANS_TAXI_DATE_7)
        AppModule.SetForm_ANS_TAXI_KENSHU_7(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_7, Me.ANS_TAXI_KENSHU_7)
        AppModule.SetForm_ANS_TAXI_NO_7(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_7, Me.ANS_TAXI_NO_7)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_7, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_7, Me.ANS_TAXI_HAKKO_7, Me.CHK_ANS_TAXI_HAKKO_7)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_7, Me.ANS_TAXI_HAKKO_DATE_7)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_7, Me.ANS_TAXI_RMKS_7)
        'タクチケ８
        AppModule.SetForm_ANS_TAXI_DATE_8(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_8, Me.ANS_TAXI_DATE_8)
        AppModule.SetForm_ANS_TAXI_KENSHU_8(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_8, Me.ANS_TAXI_KENSHU_8)
        AppModule.SetForm_ANS_TAXI_NO_8(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_8, Me.ANS_TAXI_NO_8)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_8, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_8, Me.ANS_TAXI_HAKKO_8, Me.CHK_ANS_TAXI_HAKKO_8)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_8, Me.ANS_TAXI_HAKKO_DATE_8)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_8, Me.ANS_TAXI_RMKS_8)
        'タクチケ９
        AppModule.SetForm_ANS_TAXI_DATE_9(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_9, Me.ANS_TAXI_DATE_9)
        AppModule.SetForm_ANS_TAXI_KENSHU_9(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_9, Me.ANS_TAXI_KENSHU_9)
        AppModule.SetForm_ANS_TAXI_NO_9(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_9, Me.ANS_TAXI_NO_9)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_9, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_9, Me.ANS_TAXI_HAKKO_9, Me.CHK_ANS_TAXI_HAKKO_9)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_9, Me.ANS_TAXI_HAKKO_DATE_9)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_9, Me.ANS_TAXI_RMKS_9)
        'タクチケ１０
        AppModule.SetForm_ANS_TAXI_DATE_10(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_10, Me.ANS_TAXI_DATE_10)
        AppModule.SetForm_ANS_TAXI_KENSHU_10(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_10, Me.ANS_TAXI_KENSHU_10)
        AppModule.SetForm_ANS_TAXI_NO_10(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_10, Me.ANS_TAXI_NO_10)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_10, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_10, Me.ANS_TAXI_HAKKO_10, Me.CHK_ANS_TAXI_HAKKO_10)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_10, Me.ANS_TAXI_HAKKO_DATE_10)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_10, Me.ANS_TAXI_RMKS_10)
        'タクチケ１１
        AppModule.SetForm_ANS_TAXI_DATE_11(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_11, Me.ANS_TAXI_DATE_11)
        AppModule.SetForm_ANS_TAXI_KENSHU_11(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_11, Me.ANS_TAXI_KENSHU_11)
        AppModule.SetForm_ANS_TAXI_NO_11(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_11, Me.ANS_TAXI_NO_11)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_11, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_11, Me.ANS_TAXI_HAKKO_11, Me.CHK_ANS_TAXI_HAKKO_11)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_11, Me.ANS_TAXI_HAKKO_DATE_11)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_11, Me.ANS_TAXI_RMKS_11)
        'タクチケ１２
        AppModule.SetForm_ANS_TAXI_DATE_12(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_12, Me.ANS_TAXI_DATE_12)
        AppModule.SetForm_ANS_TAXI_KENSHU_12(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_12, Me.ANS_TAXI_KENSHU_12)
        AppModule.SetForm_ANS_TAXI_NO_12(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_12, Me.ANS_TAXI_NO_12)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_12, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_12, Me.ANS_TAXI_HAKKO_12, Me.CHK_ANS_TAXI_HAKKO_12)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_12, Me.ANS_TAXI_HAKKO_DATE_12)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_12, Me.ANS_TAXI_RMKS_12)
        'タクチケ１３
        AppModule.SetForm_ANS_TAXI_DATE_13(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_13, Me.ANS_TAXI_DATE_13)
        AppModule.SetForm_ANS_TAXI_KENSHU_13(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_13, Me.ANS_TAXI_KENSHU_13)
        AppModule.SetForm_ANS_TAXI_NO_13(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_13, Me.ANS_TAXI_NO_13)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_13, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_13, Me.ANS_TAXI_HAKKO_13, Me.CHK_ANS_TAXI_HAKKO_13)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_13, Me.ANS_TAXI_HAKKO_DATE_13)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_13, Me.ANS_TAXI_RMKS_13)
        'タクチケ１４
        AppModule.SetForm_ANS_TAXI_DATE_14(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_14, Me.ANS_TAXI_DATE_14)
        AppModule.SetForm_ANS_TAXI_KENSHU_14(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_14, Me.ANS_TAXI_KENSHU_14)
        AppModule.SetForm_ANS_TAXI_NO_14(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_14, Me.ANS_TAXI_NO_14)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_14, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_14, Me.ANS_TAXI_HAKKO_14, Me.CHK_ANS_TAXI_HAKKO_14)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_14, Me.ANS_TAXI_HAKKO_DATE_14)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_14, Me.ANS_TAXI_RMKS_14)
        'タクチケ１５
        AppModule.SetForm_ANS_TAXI_DATE_15(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_15, Me.ANS_TAXI_DATE_15)
        AppModule.SetForm_ANS_TAXI_KENSHU_15(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_15, Me.ANS_TAXI_KENSHU_15)
        AppModule.SetForm_ANS_TAXI_NO_15(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_15, Me.ANS_TAXI_NO_15)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_15, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_15, Me.ANS_TAXI_HAKKO_15, Me.CHK_ANS_TAXI_HAKKO_15)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_15, Me.ANS_TAXI_HAKKO_DATE_15)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_15, Me.ANS_TAXI_RMKS_15)
        'タクチケ１６
        AppModule.SetForm_ANS_TAXI_DATE_16(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_16, Me.ANS_TAXI_DATE_16)
        AppModule.SetForm_ANS_TAXI_KENSHU_16(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_16, Me.ANS_TAXI_KENSHU_16)
        AppModule.SetForm_ANS_TAXI_NO_16(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_16, Me.ANS_TAXI_NO_16)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_16, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_16, Me.ANS_TAXI_HAKKO_16, Me.CHK_ANS_TAXI_HAKKO_16)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_16, Me.ANS_TAXI_HAKKO_DATE_16)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_16, Me.ANS_TAXI_RMKS_16)
        'タクチケ１７
        AppModule.SetForm_ANS_TAXI_DATE_17(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_17, Me.ANS_TAXI_DATE_17)
        AppModule.SetForm_ANS_TAXI_KENSHU_17(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_17, Me.ANS_TAXI_KENSHU_17)
        AppModule.SetForm_ANS_TAXI_NO_17(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_17, Me.ANS_TAXI_NO_17)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_17, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_17, Me.ANS_TAXI_HAKKO_17, Me.CHK_ANS_TAXI_HAKKO_17)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_17, Me.ANS_TAXI_HAKKO_DATE_17)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_17, Me.ANS_TAXI_RMKS_17)
        'タクチケ１８
        AppModule.SetForm_ANS_TAXI_DATE_18(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_18, Me.ANS_TAXI_DATE_18)
        AppModule.SetForm_ANS_TAXI_KENSHU_18(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_18, Me.ANS_TAXI_KENSHU_18)
        AppModule.SetForm_ANS_TAXI_NO_18(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_18, Me.ANS_TAXI_NO_18)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_18, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_18, Me.ANS_TAXI_HAKKO_18, Me.CHK_ANS_TAXI_HAKKO_18)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_18, Me.ANS_TAXI_HAKKO_DATE_18)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_18, Me.ANS_TAXI_RMKS_18)
        'タクチケ１９
        AppModule.SetForm_ANS_TAXI_DATE_19(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_19, Me.ANS_TAXI_DATE_19)
        AppModule.SetForm_ANS_TAXI_KENSHU_19(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_19, Me.ANS_TAXI_KENSHU_19)
        AppModule.SetForm_ANS_TAXI_NO_19(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_19, Me.ANS_TAXI_NO_19)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_19, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_19, Me.ANS_TAXI_HAKKO_19, Me.CHK_ANS_TAXI_HAKKO_19)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_19, Me.ANS_TAXI_HAKKO_DATE_19)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_19, Me.ANS_TAXI_RMKS_19)
        'タクチケ２０
        AppModule.SetForm_ANS_TAXI_DATE_20(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_DATE_20, Me.ANS_TAXI_DATE_20)
        AppModule.SetForm_ANS_TAXI_KENSHU_20(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_KENSHU_20, Me.ANS_TAXI_KENSHU_20)
        AppModule.SetForm_ANS_TAXI_NO_20(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_NO_20, Me.ANS_TAXI_NO_20)
        AppModule.SetForm_ANS_TAXI_HAKKO(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_20, DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_20, Me.ANS_TAXI_HAKKO_20, Me.CHK_ANS_TAXI_HAKKO_20)
        AppModule.SetForm_ANS_TAXI_HAKKO_DATE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_HAKKO_DATE_20, Me.ANS_TAXI_HAKKO_DATE_20)
        AppModule.SetForm_ANS_TAXI_RMKS(DSP_KOTSUHOTEL(DSP_SEQ).ANS_TAXI_RMKS_20, Me.ANS_TAXI_RMKS_20)

        'MR手配情報
        AppModule.SetForm_REQ_MR_O_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).REQ_MR_O_TEHAI, Me.REQ_MR_O_TEHAI)
        AppModule.SetForm_REQ_MR_F_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).REQ_MR_F_TEHAI, Me.REQ_MR_F_TEHAI)
        AppModule.SetForm_MR_SEX(DSP_KOTSUHOTEL(DSP_SEQ).MR_SEX, Me.MR_SEX)
        AppModule.SetForm_MR_AGE(DSP_KOTSUHOTEL(DSP_SEQ).MR_AGE, Me.MR_AGE)
        AppModule.SetForm_ANS_MR_O_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_O_TEHAI, Me.ANS_MR_O_TEHAI)
        AppModule.SetForm_ANS_MR_F_TEHAI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_F_TEHAI, Me.ANS_MR_F_TEHAI)
        AppModule.setform_REQ_MR_HOTEL_NOTE(DSP_KOTSUHOTEL(DSP_SEQ).REQ_MR_HOTEL_NOTE, Me.REQ_MR_HOTEL_NOTE)
        AppModule.SetForm_ANS_MR_HOTEL_NOTE(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_HOTEL_NOTE, Me.ANS_MR_HOTEL_NOTE)

        '各種代金
        AppModule.SetForm_ANS_HOTELHI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTELHI, Me.ANS_HOTELHI)
        AppModule.SetForm_ANS_HOTELHI_TOZEI(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTELHI_TOZEI, Me.ANS_HOTELHI_TOZEI)
        AppModule.SetForm_ANS_HOTELHI_CANCEL(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTELHI_CANCEL, Me.ANS_HOTELHI_CANCEL)
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
        AppModule.SetForm_ANS_TAXI_MAISUU(DSP_KOTSUHOTEL(SEQ).ANS_TAXI_TESURYO, Me.ANS_TAXI_MAISUU)
        AppModule.SetForm_ANS_KOTSUHOTEL_TESURYO(DSP_KOTSUHOTEL(SEQ).ANS_KOTSUHOTEL_TESURYO, Me.ANS_KOTSUHOTEL_TESURYO)

        If Not Popup Then
            SetChangedColor(Me.MR_BU, DSP_KOTSUHOTEL(DSP_SEQ).MR_BU, OldTBL_KOTSUHOTEL.MR_BU)
            SetChangedColor(Me.MR_AREA, DSP_KOTSUHOTEL(DSP_SEQ).MR_AREA, OldTBL_KOTSUHOTEL.MR_AREA)
            SetChangedColor(Me.MR_EIGYOSHO, DSP_KOTSUHOTEL(DSP_SEQ).MR_EIGYOSHO, OldTBL_KOTSUHOTEL.MR_EIGYOSHO)
            SetChangedColor(Me.ACCOUNT_CODE, DSP_KOTSUHOTEL(DSP_SEQ).ACCOUNT_CD, OldTBL_KOTSUHOTEL.ACCOUNT_CD)
            SetChangedColor(Me.COST_CENTER, DSP_KOTSUHOTEL(DSP_SEQ).COST_CENTER, OldTBL_KOTSUHOTEL.COST_CENTER)
            SetChangedColor(Me.INTERNAL_ORDER, DSP_KOTSUHOTEL(DSP_SEQ).INTERNAL_ORDER, OldTBL_KOTSUHOTEL.INTERNAL_ORDER)
            SetChangedColor(Me.ZETIA_CD, DSP_KOTSUHOTEL(DSP_SEQ).ZETIA_CD, OldTBL_KOTSUHOTEL.ZETIA_CD)
            SetChangedColor(Me.MR_NAME, DSP_KOTSUHOTEL(DSP_SEQ).MR_NAME, OldTBL_KOTSUHOTEL.MR_NAME)
            SetChangedColor(Me.MR_ROMA, DSP_KOTSUHOTEL(DSP_SEQ).MR_ROMA, OldTBL_KOTSUHOTEL.MR_ROMA)
            SetChangedColor(Me.MR_KEITAI, DSP_KOTSUHOTEL(DSP_SEQ).MR_KEITAI, OldTBL_KOTSUHOTEL.MR_KEITAI)
            SetChangedColor(Me.MR_TEL, DSP_KOTSUHOTEL(DSP_SEQ).MR_TEL, OldTBL_KOTSUHOTEL.MR_TEL)
            SetChangedColor(Me.MR_EMAIL_KEITAI, DSP_KOTSUHOTEL(DSP_SEQ).MR_EMAIL_KEITAI, OldTBL_KOTSUHOTEL.MR_EMAIL_KEITAI)
            SetChangedColor(Me.MR_EMAIL_PC, DSP_KOTSUHOTEL(DSP_SEQ).MR_EMAIL_PC, OldTBL_KOTSUHOTEL.MR_EMAIL_PC)
            SetChangedColor(Me.MR_SEND_SAKI_FS, DSP_KOTSUHOTEL(DSP_SEQ).MR_SEND_SAKI_FS, OldTBL_KOTSUHOTEL.MR_SEND_SAKI_FS)
            SetChangedColor(Me.MR_SEND_SAKI_OTHER, DSP_KOTSUHOTEL(DSP_SEQ).MR_SEND_SAKI_OTHER, OldTBL_KOTSUHOTEL.MR_SEND_SAKI_OTHER)
            SetChangedColor(Me.REQ_STATUS_TEHAI, DSP_KOTSUHOTEL(DSP_SEQ).REQ_STATUS_TEHAI, OldTBL_KOTSUHOTEL.REQ_STATUS_TEHAI)
            SetChangedColor(Me.SEND_FLAG, DSP_KOTSUHOTEL(DSP_SEQ).SEND_FLAG, OldTBL_KOTSUHOTEL.SEND_FLAG)
            SetChangedColor(Me.TIME_STAMP_BYL, DSP_KOTSUHOTEL(DSP_SEQ).TIME_STAMP_BYL, OldTBL_KOTSUHOTEL.TIME_STAMP_BYL)
            SetChangedColor(Me.TIME_STAMP_TOP, DSP_KOTSUHOTEL(DSP_SEQ).TIME_STAMP_TOP, OldTBL_KOTSUHOTEL.TIME_STAMP_TOP)
            SetChangedColor(Me.DR_NAME, DSP_KOTSUHOTEL(DSP_SEQ).DR_NAME, OldTBL_KOTSUHOTEL.DR_NAME)
            SetChangedColor(Me.DR_KANA, DSP_KOTSUHOTEL(DSP_SEQ).DR_KANA, OldTBL_KOTSUHOTEL.DR_KANA)
            SetChangedColor(Me.DR_SEX, DSP_KOTSUHOTEL(DSP_SEQ).DR_SEX, OldTBL_KOTSUHOTEL.DR_SEX)
            SetChangedColor(Me.DR_AGE, DSP_KOTSUHOTEL(DSP_SEQ).DR_AGE, OldTBL_KOTSUHOTEL.DR_AGE)
            SetChangedColor(Me.DR_SANKA, DSP_KOTSUHOTEL(DSP_SEQ).DR_SANKA, OldTBL_KOTSUHOTEL.DR_SANKA)
            SetChangedColor(Me.DR_YAKUWARI, DSP_KOTSUHOTEL(DSP_SEQ).DR_YAKUWARI, OldTBL_KOTSUHOTEL.DR_YAKUWARI)
            SetChangedColor(Me.DR_SHISETSU_CD, DSP_KOTSUHOTEL(DSP_SEQ).DR_SHISETSU_CD, OldTBL_KOTSUHOTEL.DR_SHISETSU_CD)
            SetChangedColor(Me.DR_SHISETSU_NAME, DSP_KOTSUHOTEL(DSP_SEQ).DR_SHISETSU_NAME, OldTBL_KOTSUHOTEL.DR_SHISETSU_NAME)
            SetChangedColor(Me.DR_SHISETSU_ADDRESS, DSP_KOTSUHOTEL(DSP_SEQ).DR_SHISETSU_ADDRESS, OldTBL_KOTSUHOTEL.DR_SHISETSU_ADDRESS)
            SetChangedColor(Me.SHITEIGAI_RIYU, DSP_KOTSUHOTEL(DSP_SEQ).SHITEIGAI_RIYU, OldTBL_KOTSUHOTEL.SHITEIGAI_RIYU)
            SetChangedColor(Me.SHONIN_NAME, DSP_KOTSUHOTEL(DSP_SEQ).SHONIN_NAME, OldTBL_KOTSUHOTEL.SHONIN_NAME)
            SetChangedColor(Me.SHONIN_DATE, DSP_KOTSUHOTEL(DSP_SEQ).SHONIN_DATE, OldTBL_KOTSUHOTEL.SHONIN_DATE)
            SetChangedColor(Me.TEHAI_HOTEL, DSP_KOTSUHOTEL(DSP_SEQ).TEHAI_HOTEL, OldTBL_KOTSUHOTEL.TEHAI_HOTEL)
            SetChangedColor(Me.HOTEL_IRAINAIYOU, DSP_KOTSUHOTEL(DSP_SEQ).HOTEL_IRAINAIYOU, OldTBL_KOTSUHOTEL.HOTEL_IRAINAIYOU)
            SetChangedColor(Me.REQ_HOTEL_DATE, DSP_KOTSUHOTEL(DSP_SEQ).REQ_HOTEL_DATE, OldTBL_KOTSUHOTEL.REQ_HOTEL_DATE)
            SetChangedColor(Me.REQ_HAKUSU, DSP_KOTSUHOTEL(DSP_SEQ).REQ_HAKUSU, OldTBL_KOTSUHOTEL.REQ_HAKUSU)
            SetChangedColor(Me.REQ_HOTEL_SMOKING, DSP_KOTSUHOTEL(DSP_SEQ).REQ_HOTEL_SMOKING, OldTBL_KOTSUHOTEL.REQ_HOTEL_SMOKING)
            SetChangedColor(Me.REQ_HOTEL_NOTE, DSP_KOTSUHOTEL(DSP_SEQ).REQ_HOTEL_NOTE, OldTBL_KOTSUHOTEL.REQ_HOTEL_NOTE)
            SetChangedColor(Me.REQ_O_TEHAI_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TEHAI_1, OldTBL_KOTSUHOTEL.REQ_O_TEHAI_1)
            SetChangedColor(Me.REQ_O_IRAINAIYOU_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_IRAINAIYOU_1, OldTBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_1)
            SetChangedColor(Me.REQ_O_KOTSUKIKAN_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_KOTSUKIKAN_1, OldTBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_1)
            SetChangedColor(Me.REQ_O_DATE_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_DATE_1, OldTBL_KOTSUHOTEL.REQ_O_DATE_1)
            SetChangedColor(Me.REQ_O_AIRPORT1_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT1_1, OldTBL_KOTSUHOTEL.REQ_O_AIRPORT1_1)
            SetChangedColor(Me.REQ_O_AIRPORT2_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT2_1, OldTBL_KOTSUHOTEL.REQ_O_AIRPORT2_1)
            SetChangedColor(Me.REQ_O_TIME1_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME1_1, OldTBL_KOTSUHOTEL.REQ_O_TIME1_1)
            SetChangedColor(Me.REQ_O_TIME2_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME2_1, OldTBL_KOTSUHOTEL.REQ_O_TIME2_1)
            SetChangedColor(Me.REQ_O_BIN_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_BIN_1, OldTBL_KOTSUHOTEL.REQ_O_BIN_1)
            SetChangedColor(Me.REQ_O_SEAT_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_1, OldTBL_KOTSUHOTEL.REQ_O_SEAT_1)
            SetChangedColor(Me.REQ_O_SEAT_KIBOU1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_KIBOU1, OldTBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU1)
            SetChangedColor(Me.REQ_O_TEHAI_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TEHAI_2, OldTBL_KOTSUHOTEL.REQ_O_TEHAI_2)
            SetChangedColor(Me.REQ_O_IRAINAIYOU_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_IRAINAIYOU_2, OldTBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_2)
            SetChangedColor(Me.REQ_O_KOTSUKIKAN_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_KOTSUKIKAN_2, OldTBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_2)
            SetChangedColor(Me.REQ_O_DATE_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_DATE_2, OldTBL_KOTSUHOTEL.REQ_O_DATE_2)
            SetChangedColor(Me.REQ_O_AIRPORT1_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT1_2, OldTBL_KOTSUHOTEL.REQ_O_AIRPORT1_2)
            SetChangedColor(Me.REQ_O_AIRPORT2_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT2_2, OldTBL_KOTSUHOTEL.REQ_O_AIRPORT2_2)
            SetChangedColor(Me.REQ_O_TIME1_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME1_2, OldTBL_KOTSUHOTEL.REQ_O_TIME1_2)
            SetChangedColor(Me.REQ_O_TIME2_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME2_2, OldTBL_KOTSUHOTEL.REQ_O_TIME2_2)
            SetChangedColor(Me.REQ_O_BIN_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_BIN_2, OldTBL_KOTSUHOTEL.REQ_O_BIN_2)
            SetChangedColor(Me.REQ_O_SEAT_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_2, OldTBL_KOTSUHOTEL.REQ_O_SEAT_2)
            SetChangedColor(Me.REQ_O_SEAT_KIBOU2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_KIBOU2, OldTBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU2)
            SetChangedColor(Me.REQ_O_TEHAI_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TEHAI_3, OldTBL_KOTSUHOTEL.REQ_O_TEHAI_3)
            SetChangedColor(Me.REQ_O_IRAINAIYOU_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_IRAINAIYOU_3, OldTBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_3)
            SetChangedColor(Me.REQ_O_KOTSUKIKAN_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_KOTSUKIKAN_3, OldTBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_3)
            SetChangedColor(Me.REQ_O_DATE_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_DATE_3, OldTBL_KOTSUHOTEL.REQ_O_DATE_3)
            SetChangedColor(Me.REQ_O_AIRPORT1_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT1_3, OldTBL_KOTSUHOTEL.REQ_O_AIRPORT1_3)
            SetChangedColor(Me.REQ_O_AIRPORT2_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT2_3, OldTBL_KOTSUHOTEL.REQ_O_AIRPORT2_3)
            SetChangedColor(Me.REQ_O_TIME1_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME1_3, OldTBL_KOTSUHOTEL.REQ_O_TIME1_3)
            SetChangedColor(Me.REQ_O_TIME2_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME2_3, OldTBL_KOTSUHOTEL.REQ_O_TIME2_3)
            SetChangedColor(Me.REQ_O_BIN_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_BIN_3, OldTBL_KOTSUHOTEL.REQ_O_BIN_3)
            SetChangedColor(Me.REQ_O_SEAT_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_3, OldTBL_KOTSUHOTEL.REQ_O_SEAT_3)
            SetChangedColor(Me.REQ_O_SEAT_KIBOU3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_KIBOU3, OldTBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU3)
            SetChangedColor(Me.REQ_O_TEHAI_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TEHAI_4, OldTBL_KOTSUHOTEL.REQ_O_TEHAI_4)
            SetChangedColor(Me.REQ_O_IRAINAIYOU_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_IRAINAIYOU_4, OldTBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_4)
            SetChangedColor(Me.REQ_O_KOTSUKIKAN_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_KOTSUKIKAN_4, OldTBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_4)
            SetChangedColor(Me.REQ_O_DATE_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_DATE_4, OldTBL_KOTSUHOTEL.REQ_O_DATE_4)
            SetChangedColor(Me.REQ_O_AIRPORT1_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT1_4, OldTBL_KOTSUHOTEL.REQ_O_AIRPORT1_4)
            SetChangedColor(Me.REQ_O_AIRPORT2_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT2_4, OldTBL_KOTSUHOTEL.REQ_O_AIRPORT2_4)
            SetChangedColor(Me.REQ_O_TIME1_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME1_4, OldTBL_KOTSUHOTEL.REQ_O_TIME1_4)
            SetChangedColor(Me.REQ_O_TIME2_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME2_4, OldTBL_KOTSUHOTEL.REQ_O_TIME2_4)
            SetChangedColor(Me.REQ_O_BIN_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_BIN_4, OldTBL_KOTSUHOTEL.REQ_O_BIN_4)
            SetChangedColor(Me.REQ_O_SEAT_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_4, OldTBL_KOTSUHOTEL.REQ_O_SEAT_4)
            SetChangedColor(Me.REQ_O_SEAT_KIBOU4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_KIBOU4, OldTBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU4)
            SetChangedColor(Me.REQ_O_TEHAI_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TEHAI_5, OldTBL_KOTSUHOTEL.REQ_O_TEHAI_5)
            SetChangedColor(Me.REQ_O_IRAINAIYOU_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_IRAINAIYOU_5, OldTBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_5)
            SetChangedColor(Me.REQ_O_KOTSUKIKAN_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_KOTSUKIKAN_5, OldTBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_5)
            SetChangedColor(Me.REQ_O_DATE_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_DATE_5, OldTBL_KOTSUHOTEL.REQ_O_DATE_5)
            SetChangedColor(Me.REQ_O_AIRPORT1_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT1_5, OldTBL_KOTSUHOTEL.REQ_O_AIRPORT1_5)
            SetChangedColor(Me.REQ_O_AIRPORT2_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_AIRPORT2_5, OldTBL_KOTSUHOTEL.REQ_O_AIRPORT2_5)
            SetChangedColor(Me.REQ_O_TIME1_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME1_5, OldTBL_KOTSUHOTEL.REQ_O_TIME1_5)
            SetChangedColor(Me.REQ_O_TIME2_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_TIME2_5, OldTBL_KOTSUHOTEL.REQ_O_TIME2_5)
            SetChangedColor(Me.REQ_O_BIN_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_BIN_5, OldTBL_KOTSUHOTEL.REQ_O_BIN_5)
            SetChangedColor(Me.REQ_O_SEAT_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_5, OldTBL_KOTSUHOTEL.REQ_O_SEAT_5)
            SetChangedColor(Me.REQ_O_SEAT_KIBOU5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_O_SEAT_KIBOU5, OldTBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU5)
            SetChangedColor(Me.REQ_F_TEHAI_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TEHAI_1, OldTBL_KOTSUHOTEL.REQ_F_TEHAI_1)
            SetChangedColor(Me.REQ_F_IRAINAIYOU_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_IRAINAIYOU_1, OldTBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_1)
            SetChangedColor(Me.REQ_F_KOTSUKIKAN_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_KOTSUKIKAN_1, OldTBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_1)
            SetChangedColor(Me.REQ_F_DATE_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_DATE_1, OldTBL_KOTSUHOTEL.REQ_F_DATE_1)
            SetChangedColor(Me.REQ_F_AIRPORT1_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT1_1, OldTBL_KOTSUHOTEL.REQ_F_AIRPORT1_1)
            SetChangedColor(Me.REQ_F_AIRPORT2_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT2_1, OldTBL_KOTSUHOTEL.REQ_F_AIRPORT2_1)
            SetChangedColor(Me.REQ_F_TIME1_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME1_1, OldTBL_KOTSUHOTEL.REQ_F_TIME1_1)
            SetChangedColor(Me.REQ_F_TIME2_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME2_1, OldTBL_KOTSUHOTEL.REQ_F_TIME2_1)
            SetChangedColor(Me.REQ_F_BIN_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_BIN_1, OldTBL_KOTSUHOTEL.REQ_F_BIN_1)
            SetChangedColor(Me.REQ_F_SEAT_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_1, OldTBL_KOTSUHOTEL.REQ_F_SEAT_1)
            SetChangedColor(Me.REQ_F_SEAT_KIBOU1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_KIBOU1, OldTBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU1)
            SetChangedColor(Me.REQ_F_TEHAI_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TEHAI_2, OldTBL_KOTSUHOTEL.REQ_F_TEHAI_2)
            SetChangedColor(Me.REQ_F_IRAINAIYOU_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_IRAINAIYOU_2, OldTBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_2)
            SetChangedColor(Me.REQ_F_KOTSUKIKAN_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_KOTSUKIKAN_2, OldTBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_2)
            SetChangedColor(Me.REQ_F_DATE_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_DATE_2, OldTBL_KOTSUHOTEL.REQ_F_DATE_2)
            SetChangedColor(Me.REQ_F_AIRPORT1_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT1_2, OldTBL_KOTSUHOTEL.REQ_F_AIRPORT1_2)
            SetChangedColor(Me.REQ_F_AIRPORT2_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT2_2, OldTBL_KOTSUHOTEL.REQ_F_AIRPORT2_2)
            SetChangedColor(Me.REQ_F_TIME1_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME1_2, OldTBL_KOTSUHOTEL.REQ_F_TIME1_2)
            SetChangedColor(Me.REQ_F_TIME2_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME2_2, OldTBL_KOTSUHOTEL.REQ_F_TIME2_2)
            SetChangedColor(Me.REQ_F_BIN_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_BIN_2, OldTBL_KOTSUHOTEL.REQ_F_BIN_2)
            SetChangedColor(Me.REQ_F_SEAT_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_2, OldTBL_KOTSUHOTEL.REQ_F_SEAT_2)
            SetChangedColor(Me.REQ_F_SEAT_KIBOU2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_KIBOU2, OldTBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU2)
            SetChangedColor(Me.REQ_F_TEHAI_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TEHAI_3, OldTBL_KOTSUHOTEL.REQ_F_TEHAI_3)
            SetChangedColor(Me.REQ_F_IRAINAIYOU_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_IRAINAIYOU_3, OldTBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_3)
            SetChangedColor(Me.REQ_F_KOTSUKIKAN_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_KOTSUKIKAN_3, OldTBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_3)
            SetChangedColor(Me.REQ_F_DATE_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_DATE_3, OldTBL_KOTSUHOTEL.REQ_F_DATE_3)
            SetChangedColor(Me.REQ_F_AIRPORT1_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT1_3, OldTBL_KOTSUHOTEL.REQ_F_AIRPORT1_3)
            SetChangedColor(Me.REQ_F_AIRPORT2_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT2_3, OldTBL_KOTSUHOTEL.REQ_F_AIRPORT2_3)
            SetChangedColor(Me.REQ_F_TIME1_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME1_3, OldTBL_KOTSUHOTEL.REQ_F_TIME1_3)
            SetChangedColor(Me.REQ_F_TIME2_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME2_3, OldTBL_KOTSUHOTEL.REQ_F_TIME2_3)
            SetChangedColor(Me.REQ_F_BIN_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_BIN_3, OldTBL_KOTSUHOTEL.REQ_F_BIN_3)
            SetChangedColor(Me.REQ_F_SEAT_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_3, OldTBL_KOTSUHOTEL.REQ_F_SEAT_3)
            SetChangedColor(Me.REQ_F_SEAT_KIBOU3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_KIBOU3, OldTBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU3)
            SetChangedColor(Me.REQ_F_TEHAI_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TEHAI_4, OldTBL_KOTSUHOTEL.REQ_F_TEHAI_4)
            SetChangedColor(Me.REQ_F_IRAINAIYOU_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_IRAINAIYOU_4, OldTBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_4)
            SetChangedColor(Me.REQ_F_KOTSUKIKAN_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_KOTSUKIKAN_4, OldTBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_4)
            SetChangedColor(Me.REQ_F_DATE_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_DATE_4, OldTBL_KOTSUHOTEL.REQ_F_DATE_4)
            SetChangedColor(Me.REQ_F_AIRPORT1_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT1_4, OldTBL_KOTSUHOTEL.REQ_F_AIRPORT1_4)
            SetChangedColor(Me.REQ_F_AIRPORT2_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT2_4, OldTBL_KOTSUHOTEL.REQ_F_AIRPORT2_4)
            SetChangedColor(Me.REQ_F_TIME1_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME1_4, OldTBL_KOTSUHOTEL.REQ_F_TIME1_4)
            SetChangedColor(Me.REQ_F_TIME2_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME2_4, OldTBL_KOTSUHOTEL.REQ_F_TIME2_4)
            SetChangedColor(Me.REQ_F_BIN_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_BIN_4, OldTBL_KOTSUHOTEL.REQ_F_BIN_4)
            SetChangedColor(Me.REQ_F_SEAT_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_4, OldTBL_KOTSUHOTEL.REQ_F_SEAT_4)
            SetChangedColor(Me.REQ_F_SEAT_KIBOU4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_KIBOU4, OldTBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU4)
            SetChangedColor(Me.REQ_F_TEHAI_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TEHAI_5, OldTBL_KOTSUHOTEL.REQ_F_TEHAI_5)
            SetChangedColor(Me.REQ_F_IRAINAIYOU_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_IRAINAIYOU_5, OldTBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_5)
            SetChangedColor(Me.REQ_F_KOTSUKIKAN_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_KOTSUKIKAN_5, OldTBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_5)
            SetChangedColor(Me.REQ_F_DATE_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_DATE_5, OldTBL_KOTSUHOTEL.REQ_F_DATE_5)
            SetChangedColor(Me.REQ_F_AIRPORT1_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT1_5, OldTBL_KOTSUHOTEL.REQ_F_AIRPORT1_5)
            SetChangedColor(Me.REQ_F_AIRPORT2_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_AIRPORT2_5, OldTBL_KOTSUHOTEL.REQ_F_AIRPORT2_5)
            SetChangedColor(Me.REQ_F_TIME1_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME1_5, OldTBL_KOTSUHOTEL.REQ_F_TIME1_5)
            SetChangedColor(Me.REQ_F_TIME2_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_TIME2_5, OldTBL_KOTSUHOTEL.REQ_F_TIME2_5)
            SetChangedColor(Me.REQ_F_BIN_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_BIN_5, OldTBL_KOTSUHOTEL.REQ_F_BIN_5)
            SetChangedColor(Me.REQ_F_SEAT_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_5, OldTBL_KOTSUHOTEL.REQ_F_SEAT_5)
            SetChangedColor(Me.REQ_F_SEAT_KIBOU5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_F_SEAT_KIBOU5, OldTBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU5)
            SetChangedColor(Me.REQ_KOTSU_BIKO, DSP_KOTSUHOTEL(DSP_SEQ).REQ_KOTSU_BIKO, OldTBL_KOTSUHOTEL.REQ_KOTSU_BIKO)
            SetChangedColor(Me.TEHAI_TAXI, DSP_KOTSUHOTEL(DSP_SEQ).TEHAI_TAXI, OldTBL_KOTSUHOTEL.TEHAI_TAXI)
            SetChangedColor(Me.REQ_TAXI_NOTE, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_NOTE, OldTBL_KOTSUHOTEL.REQ_TAXI_NOTE)
            SetChangedColor(Me.REQ_TAXI_DATE_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_1, OldTBL_KOTSUHOTEL.REQ_TAXI_DATE_1)
            SetChangedColor(Me.REQ_TAXI_FROM_1, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_1, OldTBL_KOTSUHOTEL.REQ_TAXI_FROM_1)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_1, DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_1, OldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_1)
            SetChangedColor(Me.REQ_TAXI_DATE_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_2, OldTBL_KOTSUHOTEL.REQ_TAXI_DATE_2)
            SetChangedColor(Me.REQ_TAXI_FROM_2, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_2, OldTBL_KOTSUHOTEL.REQ_TAXI_FROM_2)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_2, DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_2, OldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_2)
            SetChangedColor(Me.REQ_TAXI_DATE_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_3, OldTBL_KOTSUHOTEL.REQ_TAXI_DATE_3)
            SetChangedColor(Me.REQ_TAXI_FROM_3, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_3, OldTBL_KOTSUHOTEL.REQ_TAXI_FROM_3)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_3, DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_3, OldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_3)
            SetChangedColor(Me.REQ_TAXI_DATE_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_4, OldTBL_KOTSUHOTEL.REQ_TAXI_DATE_4)
            SetChangedColor(Me.REQ_TAXI_FROM_4, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_4, OldTBL_KOTSUHOTEL.REQ_TAXI_FROM_4)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_4, DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_4, OldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_4)
            SetChangedColor(Me.REQ_TAXI_DATE_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_5, OldTBL_KOTSUHOTEL.REQ_TAXI_DATE_5)
            SetChangedColor(Me.REQ_TAXI_FROM_5, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_5, OldTBL_KOTSUHOTEL.REQ_TAXI_FROM_5)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_5, DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_5, OldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_5)
            SetChangedColor(Me.REQ_TAXI_DATE_6, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_6, OldTBL_KOTSUHOTEL.REQ_TAXI_DATE_6)
            SetChangedColor(Me.REQ_TAXI_FROM_6, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_6, OldTBL_KOTSUHOTEL.REQ_TAXI_FROM_6)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_6, DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_6, OldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_6)
            SetChangedColor(Me.REQ_TAXI_DATE_7, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_7, OldTBL_KOTSUHOTEL.REQ_TAXI_DATE_7)
            SetChangedColor(Me.REQ_TAXI_FROM_7, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_7, OldTBL_KOTSUHOTEL.REQ_TAXI_FROM_7)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_7, DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_7, OldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_7)
            SetChangedColor(Me.REQ_TAXI_DATE_8, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_8, OldTBL_KOTSUHOTEL.REQ_TAXI_DATE_8)
            SetChangedColor(Me.REQ_TAXI_FROM_8, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_8, OldTBL_KOTSUHOTEL.REQ_TAXI_FROM_8)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_8, DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_8, OldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_8)
            SetChangedColor(Me.REQ_TAXI_DATE_9, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_9, OldTBL_KOTSUHOTEL.REQ_TAXI_DATE_9)
            SetChangedColor(Me.REQ_TAXI_FROM_9, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_9, OldTBL_KOTSUHOTEL.REQ_TAXI_FROM_9)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_9, DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_9, OldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_9)
            SetChangedColor(Me.REQ_TAXI_DATE_10, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_DATE_10, OldTBL_KOTSUHOTEL.REQ_TAXI_DATE_10)
            SetChangedColor(Me.REQ_TAXI_FROM_10, DSP_KOTSUHOTEL(DSP_SEQ).REQ_TAXI_FROM_10, OldTBL_KOTSUHOTEL.REQ_TAXI_FROM_10)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_10, DSP_KOTSUHOTEL(DSP_SEQ).TAXI_YOTEIKINGAKU_10, OldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_10)
            SetChangedColor(Me.REQ_MR_O_TEHAI, DSP_KOTSUHOTEL(DSP_SEQ).REQ_MR_O_TEHAI, OldTBL_KOTSUHOTEL.REQ_MR_O_TEHAI)
            SetChangedColor(Me.REQ_MR_F_TEHAI, DSP_KOTSUHOTEL(DSP_SEQ).REQ_MR_F_TEHAI, OldTBL_KOTSUHOTEL.REQ_MR_F_TEHAI)
            SetChangedColor(Me.MR_SEX, DSP_KOTSUHOTEL(DSP_SEQ).MR_SEX, OldTBL_KOTSUHOTEL.MR_SEX)
            SetChangedColor(Me.MR_AGE, DSP_KOTSUHOTEL(DSP_SEQ).MR_AGE, OldTBL_KOTSUHOTEL.MR_AGE)
            SetChangedColor(Me.REQ_MR_HOTEL_NOTE, DSP_KOTSUHOTEL(DSP_SEQ).REQ_MR_HOTEL_NOTE, OldTBL_KOTSUHOTEL.REQ_MR_HOTEL_NOTE)
        End If

        '宿泊費税抜金額表示
        Dim strZeiRate As String = AppModule.GetZeiRate(DSP_KOTSUHOTEL(DSP_SEQ).FROM_DATE, MyBase.DbConnection)
        Dim strZeikomiGaku As String = CStr(CLng(Val(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTELHI)) - CLng(Val(DSP_KOTSUHOTEL(DSP_SEQ).ANS_HOTELHI_TOZEI)))
        Me.ANS_HOTELHI_TF.Text = CmnModule.EditComma(AppModule.GetZeinukiGaku(strZeikomiGaku, strZeiRate))
        Dim strMrZeikomiGaku As String = CStr(CLng(Val(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_HOTELHI)) - CLng(Val(DSP_KOTSUHOTEL(DSP_SEQ).ANS_MR_HOTELHI_TOZEI)))
        Me.ANS_MR_HOTELHI_TF.Text = CmnModule.EditComma(AppModule.GetZeinukiGaku(strMrZeikomiGaku, strZeiRate))
    End Sub

    '差異
    Private Function SetChangedColor(ByVal Data1 As String, ByVal Data2 As String) As System.Drawing.Color
        If Trim(OldTBL_KOTSUHOTEL.KOUENKAI_NO) <> "" AndAlso CmnModule.IsChanged(Data1, Data2) Then
            Return Drawing.Color.OrangeRed
        Else
            Return Drawing.Color.FromArgb(10, 10, 10)
        End If
    End Function
    Private Sub SetChangedColor(ByRef control As Label, ByVal Data1 As String, ByVal Data2 As String)
        With control
            If Trim(OldTBL_KOTSUHOTEL.KOUENKAI_NO) <> "" AndAlso CmnModule.IsChanged(Data1, Data2) Then
                .BackColor = Drawing.Color.FromArgb(255, 204, 255)
            Else
                .BackColor = Drawing.Color.White
            End If
        End With
    End Sub
    Private Sub SetChangedColor(ByRef control As TextBox, ByVal Data1 As String, ByVal Data2 As String)
        With control
            If Trim(OldTBL_KOTSUHOTEL.KOUENKAI_NO) <> "" AndAlso CmnModule.IsChanged(Data1, Data2) Then
                .BackColor = Drawing.Color.FromArgb(255, 204, 255)
            Else
                .BackColor = Drawing.Color.White
            End If
        End With
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

    '旧データ取得
    Private Sub GetData_Old()
        Dim strSQL As String = SQL.TBL_KOTSUHOTEL.byKOUENKAI_NO_UPDATE_DATE_DESC(DSP_KOTSUHOTEL(SEQ).KOUENKAI_NO, DSP_KOTSUHOTEL(SEQ).SANKASHA_ID, DSP_KOTSUHOTEL(SEQ).UPDATE_DATE)
        Dim RsData As System.Data.SqlClient.SqlDataReader
        Dim wFlAG As Boolean = False

        OldTBL_KOTSUHOTEL = Nothing
        RsData = CmnDb.Read(strSQL, MyBase.DbConnection)
        If RsData.Read() Then
            wFlAG = True
            OldTBL_KOTSUHOTEL = AppModule.SetRsData(RsData, OldTBL_KOTSUHOTEL)
        Else
            OldTBL_KOTSUHOTEL = DSP_KOTSUHOTEL(SEQ)
        End If
        RsData.Close()
    End Sub

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
            SetFocus(Me.ANS_TICKET_SEND_DAY)
            Return False
        End If

        If CmnCheck.IsInput(Me.ANS_TICKET_SEND_DAY) Then
            If Me.ANS_TICKET_SEND_DAY.Text.Trim.Length < 8 Then
                CmnModule.AlertMessage(MessageDef.Error.LengthEQ("チケット類発送日（最新）", 8, False), Me)
                SetFocus(Me.ANS_TICKET_SEND_DAY)
                Return False
            End If

            Dim wStr As String = StrConv(Me.ANS_TICKET_SEND_DAY.Text.Substring(0, 4) & "/" & Me.ANS_TICKET_SEND_DAY.Text.Substring(4, 2) & "/" & Me.ANS_TICKET_SEND_DAY.Text.Substring(6, 2), VbStrConv.Narrow)
            If Not IsDate(wStr) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("チケット類発送日（最新）"), Me)
                SetFocus(Me.ANS_TICKET_SEND_DAY)
                Return False
            End If
        End If

        '宿泊施設TEL
        If Me.ANS_HOTEL_TEL.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidTel(Me.ANS_HOTEL_TEL) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("宿泊施設TELの入力形式"), Me)
            SetFocus(Me.ANS_HOTEL_TEL)
            Return False
        End If

        '宿泊日
        If Me.ANS_HOTEL_DATE.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_HOTEL_DATE) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("宿泊日"), Me)
            SetFocus(Me.ANS_HOTEL_DATE)
            Return False
        End If

        '泊数
        If Me.ANS_HAKUSU.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.isnumberonly(Me.ANS_HAKUSU) Then
            CmnModule.AlertMessage(MessageDef.Error.NumberOnly("泊数"), Me)
            SetFocus(Me.ANS_HAKUSU)
            Return False
        End If

        'チェックイン
        If Me.ANS_CHECKIN_TIME.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_CHECKIN_TIME) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("チェックイン"), Me)
                SetFocus(Me.ANS_CHECKIN_TIME)
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
                SetFocus(Me.ANS_CHECKOUT_TIME)
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
            CmnModule.AlertMessage(MessageDef.Error.Invalid("往路-利用日1"), Me)
            SetFocus(Me.ANS_O_DATE_1)
            Return False
        End If

        '出発時刻1
        If Me.ANS_O_TIME1_1.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME1_1) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("往路-出発時刻1"), Me)
                SetFocus(Me.ANS_O_TIME1_1)
                Return False
            Else
                Me.ANS_O_TIME1_1.Text = Replace(Replace(Me.ANS_O_TIME1_1.Text, ":", ""), "：", "")
                Me.ANS_O_TIME1_1.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME1_1.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻1
        If Me.ANS_O_TIME2_1.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME2_1) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("往路-到着時刻1"), Me)
                SetFocus(Me.ANS_O_TIME2_1)
                Return False
            Else
                Me.ANS_O_TIME2_1.Text = Replace(Replace(Me.ANS_O_TIME2_1.Text, ":", ""), "：", "")
                Me.ANS_O_TIME2_1.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME2_1.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '利用日2
        If Me.ANS_O_DATE_2.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_O_DATE_2) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("往路-利用日2"), Me)
            SetFocus(Me.ANS_O_DATE_2)
            Return False
        End If

        '出発時刻2
        If Me.ANS_O_TIME1_2.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME1_2) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("往路-出発時刻2"), Me)
                SetFocus(Me.ANS_O_TIME1_2)
                Return False
            Else
                Me.ANS_O_TIME1_2.Text = Replace(Replace(Me.ANS_O_TIME1_2.Text, ":", ""), "：", "")
                Me.ANS_O_TIME1_2.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME1_2.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻2
        If Me.ANS_O_TIME2_2.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME2_2) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("往路-到着時刻2"), Me)
                SetFocus(Me.ANS_O_TIME2_2)
                Return False
            Else
                Me.ANS_O_TIME2_2.Text = Replace(Replace(Me.ANS_O_TIME2_2.Text, ":", ""), "：", "")
                Me.ANS_O_TIME2_2.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME2_2.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '利用日3
        If Me.ANS_O_DATE_3.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_O_DATE_3) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("往路-利用日3"), Me)
            SetFocus(Me.ANS_O_DATE_3)
            Return False
        End If

        '出発時刻3
        If Me.ANS_O_TIME1_3.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME1_3) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("往路-出発時刻3"), Me)
                SetFocus(Me.ANS_O_TIME1_3)
                Return False
            Else
                Me.ANS_O_TIME1_3.Text = Replace(Replace(Me.ANS_O_TIME1_3.Text, ":", ""), "：", "")
                Me.ANS_O_TIME1_3.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME1_3.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻3
        If Me.ANS_O_TIME2_3.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME2_3) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("往路-到着時刻3"), Me)
                SetFocus(Me.ANS_O_TIME2_3)
                Return False
            Else
                Me.ANS_O_TIME2_3.Text = Replace(Replace(Me.ANS_O_TIME2_3.Text, ":", ""), "：", "")
                Me.ANS_O_TIME2_3.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME2_3.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '利用日4
        If Me.ANS_O_DATE_4.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_O_DATE_4) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("往路-利用日4"), Me)
            SetFocus(Me.ANS_O_DATE_4)
            Return False
        End If

        '出発時刻4
        If Me.ANS_O_TIME1_4.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME1_4) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("往路-出発時刻4"), Me)
                SetFocus(Me.ANS_O_TIME1_4)
                Return False
            Else
                Me.ANS_O_TIME1_4.Text = Replace(Replace(Me.ANS_O_TIME1_4.Text, ":", ""), "：", "")
                Me.ANS_O_TIME1_4.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME1_4.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻4
        If Me.ANS_O_TIME2_4.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME2_4) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("往路-到着時刻4"), Me)
                SetFocus(Me.ANS_O_TIME2_4)
                Return False
            Else
                Me.ANS_O_TIME2_4.Text = Replace(Replace(Me.ANS_O_TIME2_4.Text, ":", ""), "：", "")
                Me.ANS_O_TIME2_4.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME2_4.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '利用日5
        If Me.ANS_O_DATE_5.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_O_DATE_5) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("往路-利用日5"), Me)
            SetFocus(Me.ANS_O_DATE_5)
            Return False
        End If

        '出発時刻5
        If Me.ANS_O_TIME1_5.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME1_5) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("往路-出発時刻5"), Me)
                SetFocus(Me.ANS_O_TIME1_5)
                Return False
            Else
                Me.ANS_O_TIME1_5.Text = Replace(Replace(Me.ANS_O_TIME1_5.Text, ":", ""), "：", "")
                Me.ANS_O_TIME1_5.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_O_TIME1_5.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻5
        If Me.ANS_O_TIME2_5.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_O_TIME2_5) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("往路-到着時刻5"), Me)
                SetFocus(Me.ANS_O_TIME2_5)
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
            CmnModule.AlertMessage(MessageDef.Error.Invalid("復路-利用日1"), Me)
            SetFocus(Me.ANS_F_DATE_1)
            Return False
        End If

        '出発時刻1
        If Me.ANS_F_TIME1_1.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME1_1) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("復路-出発時刻1"), Me)
                SetFocus(Me.ANS_F_TIME1_1)
                Return False
            Else
                Me.ANS_F_TIME1_1.Text = Replace(Replace(Me.ANS_F_TIME1_1.Text, ":", ""), "：", "")
                Me.ANS_F_TIME1_1.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME1_1.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻1
        If Me.ANS_F_TIME1_2.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME1_2) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("復路-到着時刻1"), Me)
                SetFocus(Me.ANS_F_TIME1_2)
                Return False
            Else
                Me.ANS_F_TIME1_2.Text = Replace(Replace(Me.ANS_F_TIME1_2.Text, ":", ""), "：", "")
                Me.ANS_F_TIME1_2.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME1_2.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '利用日2
        If Me.ANS_F_DATE_2.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_F_DATE_2) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("復路-利用日2"), Me)
            SetFocus(Me.ANS_F_DATE_2)
            Return False
        End If

        '出発時刻2
        If Me.ANS_F_TIME1_2.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME1_2) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("復路-出発時刻2"), Me)
                SetFocus(Me.ANS_F_TIME1_2)
                Return False
            Else
                Me.ANS_F_TIME1_2.Text = Replace(Replace(Me.ANS_F_TIME1_2.Text, ":", ""), "：", "")
                Me.ANS_F_TIME1_2.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME1_2.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻2
        If Me.ANS_F_TIME2_2.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME2_2) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("復路-到着時刻2"), Me)
                SetFocus(Me.ANS_F_TIME2_2)
                Return False
            Else
                Me.ANS_F_TIME2_2.Text = Replace(Replace(Me.ANS_F_TIME2_2.Text, ":", ""), "：", "")
                Me.ANS_F_TIME2_2.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME2_2.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '利用日3
        If Me.ANS_F_DATE_3.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_F_DATE_3) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("復路-利用日3"), Me)
            SetFocus(Me.ANS_F_DATE_3)
            Return False
        End If

        '出発時刻3
        If Me.ANS_F_TIME1_3.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME1_3) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("復路-出発時刻3"), Me)
                SetFocus(Me.ANS_F_TIME1_3)
                Return False
            Else
                Me.ANS_F_TIME1_3.Text = Replace(Replace(Me.ANS_F_TIME1_3.Text, ":", ""), "：", "")
                Me.ANS_F_TIME1_3.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME1_3.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻3
        If Me.ANS_F_TIME2_3.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME2_3) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("復路-到着時刻3"), Me)
                SetFocus(Me.ANS_F_TIME2_3)
                Return False
            Else
                Me.ANS_F_TIME2_3.Text = Replace(Replace(Me.ANS_F_TIME2_3.Text, ":", ""), "：", "")
                Me.ANS_F_TIME2_3.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME2_3.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '利用日4
        If Me.ANS_F_DATE_4.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_F_DATE_4) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("復路-利用日4"), Me)
            SetFocus(Me.ANS_F_DATE_4)
            Return False
        End If

        '出発時刻4
        If Me.ANS_F_TIME1_4.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME1_4) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("復路-出発時刻4"), Me)
                SetFocus(Me.ANS_F_TIME1_4)
                Return False
            Else
                Me.ANS_F_TIME1_4.Text = Replace(Replace(Me.ANS_F_TIME1_4.Text, ":", ""), "：", "")
                Me.ANS_F_TIME1_4.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME1_4.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻4
        If Me.ANS_F_TIME2_4.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME2_4) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("復路-到着時刻4"), Me)
                SetFocus(Me.ANS_F_TIME2_4)
                Return False
            Else
                Me.ANS_F_TIME2_4.Text = Replace(Replace(Me.ANS_F_TIME2_4.Text, ":", ""), "：", "")
                Me.ANS_F_TIME2_4.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME2_4.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '利用日5
        If Me.ANS_F_DATE_5.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_F_DATE_5) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("復路-利用日5"), Me)
            SetFocus(Me.ANS_F_DATE_5)
            Return False
        End If

        '出発時刻5
        If Me.ANS_F_TIME1_5.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME1_5) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("復路-出発時刻5"), Me)
                SetFocus(Me.ANS_F_TIME1_5)
                Return False
            Else
                Me.ANS_F_TIME1_5.Text = Replace(Replace(Me.ANS_F_TIME1_5.Text, ":", ""), "：", "")
                Me.ANS_F_TIME1_5.Text = CmnModule.Format_Date(Now.ToString("yyyyMMdd") & Me.ANS_F_TIME1_5.Text & "00", CmnModule.DateFormatType.HHMM)
            End If
        End If

        '到着時刻5
        If Me.ANS_F_TIME2_5.Text.Trim <> String.Empty Then
            If Not CmnCheck.IsValidTime(Me.ANS_F_TIME2_5) Then
                CmnModule.AlertMessage(MessageDef.Error.Invalid("復路-到着時刻5"), Me)
                SetFocus(Me.ANS_F_TIME2_5)
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
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日1"), Me)
            SetFocus(Me.ANS_TAXI_DATE_1)
            Return False
        ElseIf Me.ANS_TAXI_DATE_2.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_1.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日1"), Me)
                SetFocus(Me.ANS_TAXI_DATE_1)
                Return False
            End If
        End If

        '券種1
        If Me.ANS_TAXI_KENSHU_1.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_1.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種1"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_1)
            Return False
        End If

        '番号1
        If Me.ANS_TAXI_NO_1.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_1) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("番号1"), Me)
            SetFocus(Me.ANS_TAXI_NO_1)
            Return False
        End If

        '利用日2
        If Me.ANS_TAXI_DATE_2.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_2) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日2"), Me)
            SetFocus(Me.ANS_TAXI_DATE_2)
            Return False
        ElseIf Me.ANS_TAXI_DATE_2.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_2.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日2"), Me)
                SetFocus(Me.ANS_TAXI_DATE_2)
                Return False
            End If
        End If

        '券種2
        If Me.ANS_TAXI_KENSHU_2.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_2.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種2"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_2)
            Return False
        End If

        '番号2
        If Me.ANS_TAXI_NO_2.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_2) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号2"), Me)
            SetFocus(Me.ANS_TAXI_NO_2)
            Return False
        End If

        '利用日3
        If Me.ANS_TAXI_DATE_3.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_3) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日3"), Me)
            SetFocus(Me.ANS_TAXI_DATE_3)
            Return False
        ElseIf Me.ANS_TAXI_DATE_3.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_3.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日3"), Me)
                SetFocus(Me.ANS_TAXI_DATE_3)
                Return False
            End If
        End If

        '券種3
        If Me.ANS_TAXI_KENSHU_3.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_3.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種3"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_3)
            Return False
        End If

        '番号3
        If Me.ANS_TAXI_NO_3.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_3) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号3"), Me)
            SetFocus(Me.ANS_TAXI_NO_3)
            Return False
        End If

        '利用日4
        If Me.ANS_TAXI_DATE_4.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_4) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日4"), Me)
            SetFocus(Me.ANS_TAXI_DATE_4)
            Return False
        ElseIf Me.ANS_TAXI_DATE_4.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_4.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日4"), Me)
                SetFocus(Me.ANS_TAXI_DATE_4)
                Return False
            End If
        End If

        '券種4
        If Me.ANS_TAXI_KENSHU_4.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_4.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種4"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_4)
            Return False
        End If

        '番号4
        If Me.ANS_TAXI_NO_4.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_4) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号4"), Me)
            SetFocus(Me.ANS_TAXI_NO_4)
            Return False
        End If

        '利用日5
        If Me.ANS_TAXI_DATE_5.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_5) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日5"), Me)
            SetFocus(Me.ANS_TAXI_DATE_5)
            Return False
        ElseIf Me.ANS_TAXI_DATE_5.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_5.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日5"), Me)
                SetFocus(Me.ANS_TAXI_DATE_5)
                Return False
            End If
        End If

        '券種5
        If Me.ANS_TAXI_KENSHU_5.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_5.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種5"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_5)
            Return False
        End If

        '番号5
        If Me.ANS_TAXI_NO_5.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_5) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号5"), Me)
            SetFocus(Me.ANS_TAXI_NO_5)
            Return False
        End If

        '利用日6
        If Me.ANS_TAXI_DATE_6.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_6) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日6"), Me)
            SetFocus(Me.ANS_TAXI_DATE_6)
            Return False
        ElseIf Me.ANS_TAXI_DATE_6.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_6.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日6"), Me)
                SetFocus(Me.ANS_TAXI_DATE_6)
                Return False
            End If
        End If

        '券種6
        If Me.ANS_TAXI_KENSHU_6.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_6.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種6"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_6)
            Return False
        End If

        '番号6
        If Me.ANS_TAXI_NO_6.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_6) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号6"), Me)
            SetFocus(Me.ANS_TAXI_NO_6)
            Return False
        End If

        '利用日7
        If Me.ANS_TAXI_DATE_7.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_7) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日7"), Me)
            SetFocus(Me.ANS_TAXI_DATE_7)
            Return False
        ElseIf Me.ANS_TAXI_DATE_7.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_7.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日7"), Me)
                SetFocus(Me.ANS_TAXI_DATE_7)
                Return False
            End If
        End If

        '券種7
        If Me.ANS_TAXI_KENSHU_7.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_7.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種7"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_7)
            Return False
        End If

        '番号7
        If Me.ANS_TAXI_NO_7.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_7) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号7"), Me)
            SetFocus(Me.ANS_TAXI_NO_7)
            Return False
        End If

        '利用日8
        If Me.ANS_TAXI_DATE_8.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_8) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日8"), Me)
            SetFocus(Me.ANS_TAXI_DATE_8)
            Return False
        ElseIf Me.ANS_TAXI_DATE_8.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_8.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日8"), Me)
                SetFocus(Me.ANS_TAXI_DATE_8)
                Return False
            End If
        End If

        '券種8
        If Me.ANS_TAXI_KENSHU_8.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_8.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種8"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_8)
            Return False
        End If

        '番号8
        If Me.ANS_TAXI_NO_8.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_8) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号8"), Me)
            SetFocus(Me.ANS_TAXI_NO_8)
            Return False
        End If

        '利用日9
        If Me.ANS_TAXI_DATE_9.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_9) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日9"), Me)
            SetFocus(Me.ANS_TAXI_DATE_9)
            Return False
        ElseIf Me.ANS_TAXI_DATE_9.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_9.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日9"), Me)
                SetFocus(Me.ANS_TAXI_DATE_9)
                Return False
            End If
        End If

        '券種9
        If Me.ANS_TAXI_KENSHU_9.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_9.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種9"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_9)
            Return False
        End If

        '番号9
        If Me.ANS_TAXI_NO_9.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_9) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号9"), Me)
            SetFocus(Me.ANS_TAXI_NO_9)
            Return False
        End If

        '利用日10
        If Me.ANS_TAXI_DATE_10.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_10) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日10"), Me)
            SetFocus(Me.ANS_TAXI_DATE_10)
            Return False
        ElseIf Me.ANS_TAXI_DATE_10.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_10.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日10"), Me)
                SetFocus(Me.ANS_TAXI_DATE_10)
                Return False
            End If
        End If

        '券種10
        If Me.ANS_TAXI_KENSHU_10.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_10.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種10"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_10)
            Return False
        End If

        '番号10
        If Me.ANS_TAXI_NO_10.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_10) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号10"), Me)
            SetFocus(Me.ANS_TAXI_NO_10)
            Return False
        End If

        '利用日11
        If Me.ANS_TAXI_DATE_11.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_11) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日11"), Me)
            SetFocus(Me.ANS_TAXI_DATE_11)
            Return False
        ElseIf Me.ANS_TAXI_DATE_11.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_11.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日11"), Me)
                SetFocus(Me.ANS_TAXI_DATE_11)
                Return False
            End If
        End If

        '券種11
        If Me.ANS_TAXI_KENSHU_11.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_11.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種11"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_11)
            Return False
        End If

        '番号11
        If Me.ANS_TAXI_NO_11.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_11) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号11"), Me)
            SetFocus(Me.ANS_TAXI_NO_11)
            Return False
        End If

        '利用日12
        If Me.ANS_TAXI_DATE_12.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_12) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日12"), Me)
            SetFocus(Me.ANS_TAXI_DATE_12)
            Return False
        ElseIf Me.ANS_TAXI_DATE_12.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_12.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日12"), Me)
                SetFocus(Me.ANS_TAXI_DATE_12)
                Return False
            End If
        End If

        '券種12
        If Me.ANS_TAXI_KENSHU_12.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_12.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種12"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_12)
            Return False
        End If

        '番号12
        If Me.ANS_TAXI_NO_12.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_12) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号12"), Me)
            SetFocus(Me.ANS_TAXI_NO_12)
            Return False
        End If

        '利用日13
        If Me.ANS_TAXI_DATE_13.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_13) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日13"), Me)
            SetFocus(Me.ANS_TAXI_DATE_13)
            Return False
        ElseIf Me.ANS_TAXI_DATE_13.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_13.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日13"), Me)
                SetFocus(Me.ANS_TAXI_DATE_13)
                Return False
            End If
        End If

        '券種13
        If Me.ANS_TAXI_KENSHU_13.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_13.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種13"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_13)
            Return False
        End If

        '番号13
        If Me.ANS_TAXI_NO_13.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_13) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号13"), Me)
            SetFocus(Me.ANS_TAXI_NO_13)
            Return False
        End If

        '利用日14
        If Me.ANS_TAXI_DATE_14.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_14) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日14"), Me)
            SetFocus(Me.ANS_TAXI_DATE_14)
            Return False
        ElseIf Me.ANS_TAXI_DATE_14.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_1.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日1"), Me)
                SetFocus(Me.ANS_TAXI_DATE_14)
                Return False
            End If
        End If

        '券種14
        If Me.ANS_TAXI_KENSHU_14.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_14.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種14"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_14)
            Return False
        End If

        '番号14
        If Me.ANS_TAXI_NO_14.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_14) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号14"), Me)
            SetFocus(Me.ANS_TAXI_NO_14)
            Return False
        End If

        '利用日15
        If Me.ANS_TAXI_DATE_15.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_15) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日15"), Me)
            SetFocus(Me.ANS_TAXI_DATE_15)
            Return False
        ElseIf Me.ANS_TAXI_DATE_15.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_15.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日15"), Me)
                SetFocus(Me.ANS_TAXI_DATE_15)
                Return False
            End If
        End If

        '券種15
        If Me.ANS_TAXI_KENSHU_15.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_15.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種15"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_15)
            Return False
        End If

        '番号15
        If Me.ANS_TAXI_NO_15.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_15) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号15"), Me)
            SetFocus(Me.ANS_TAXI_NO_15)
            Return False
        End If

        '利用日16
        If Me.ANS_TAXI_DATE_16.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_16) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日16"), Me)
            SetFocus(Me.ANS_TAXI_DATE_16)
            Return False
        ElseIf Me.ANS_TAXI_DATE_16.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_16.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日16"), Me)
                SetFocus(Me.ANS_TAXI_DATE_16)
                Return False
            End If
        End If

        '券種16
        If Me.ANS_TAXI_KENSHU_16.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_16.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種16"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_16)
            Return False
        End If

        '番号16
        If Me.ANS_TAXI_NO_16.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_16) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号16"), Me)
            SetFocus(Me.ANS_TAXI_NO_16)
            Return False
        End If

        '利用日17
        If Me.ANS_TAXI_DATE_17.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_17) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日17"), Me)
            SetFocus(Me.ANS_TAXI_DATE_17)
            Return False
        ElseIf Me.ANS_TAXI_DATE_17.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_17.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日17"), Me)
                SetFocus(Me.ANS_TAXI_DATE_17)
                Return False
            End If
        End If

        '券種17
        If Me.ANS_TAXI_KENSHU_17.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_17.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種17"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_17)
            Return False
        End If

        '番号17
        If Me.ANS_TAXI_NO_17.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_17) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号17"), Me)
            SetFocus(Me.ANS_TAXI_NO_17)
            Return False
        End If

        '利用日18
        If Me.ANS_TAXI_DATE_18.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_18) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日18"), Me)
            SetFocus(Me.ANS_TAXI_DATE_18)
            Return False
        ElseIf Me.ANS_TAXI_DATE_18.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_18.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日18"), Me)
                SetFocus(Me.ANS_TAXI_DATE_18)
                Return False
            End If
        End If

        '券種18
        If Me.ANS_TAXI_KENSHU_18.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_18.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種18"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_18)
            Return False
        End If

        '番号18
        If Me.ANS_TAXI_NO_18.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_18) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号18"), Me)
            SetFocus(Me.ANS_TAXI_NO_18)
            Return False
        End If

        '利用日19
        If Me.ANS_TAXI_DATE_19.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_19) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日19"), Me)
            SetFocus(Me.ANS_TAXI_DATE_19)
            Return False
        ElseIf Me.ANS_TAXI_DATE_19.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_19.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日19"), Me)
                SetFocus(Me.ANS_TAXI_DATE_19)
                Return False
            End If
        End If

        '券種19
        If Me.ANS_TAXI_KENSHU_19.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_19.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種19"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_19)
            Return False
        End If

        '番号19
        If Me.ANS_TAXI_NO_19.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_19) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号19"), Me)
            SetFocus(Me.ANS_TAXI_NO_19)
            Return False
        End If

        '利用日20
        If Me.ANS_TAXI_DATE_20.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidDateYMD(Me.ANS_TAXI_DATE_20) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ-利用日20"), Me)
            SetFocus(Me.ANS_TAXI_DATE_20)
            Return False
        ElseIf Me.ANS_TAXI_DATE_20.Text.Trim = String.Empty Then
            If Me.CHK_ANS_TAXI_HAKKO_20.Checked Then
                CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-利用日20"), Me)
                SetFocus(Me.ANS_TAXI_DATE_20)
                Return False
            End If
        End If

        '券種20
        If Me.ANS_TAXI_KENSHU_20.SelectedValue = "" AndAlso Me.CHK_ANS_TAXI_HAKKO_20.Checked Then
            CmnModule.AlertMessage(MessageDef.Error.SelectError("タクチケ-券種20"), Me)
            SetFocus(Me.ANS_TAXI_KENSHU_20)
            Return False
        End If

        '番号20
        If Me.ANS_TAXI_NO_20.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsHankaku(Me.ANS_TAXI_NO_20) Then
            CmnModule.AlertMessage(MessageDef.Error.HankakuOnly("タクチケ-番号20"), Me)
            SetFocus(Me.ANS_TAXI_NO_20)
            Return False
        End If

        '宿泊費（税込)
        If Me.ANS_HOTELHI.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_HOTELHI) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("宿泊費"), Me)
            SetFocus(Me.ANS_HOTELHI)
            Return False
        End If

        '宿泊費都税
        If Me.ANS_HOTELHI_TOZEI.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_HOTELHI_TOZEI) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("宿泊費都税"), Me)
            SetFocus(Me.ANS_HOTELHI_TOZEI)
            Return False
        End If

        '宿泊取消料
        If Me.ANS_HOTELHI_CANCEL.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_HOTELHI_CANCEL) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("宿泊取消料"), Me)
            SetFocus(Me.ANS_HOTELHI_CANCEL)
            Return False
        End If

        'JR券代
        If Me.ANS_RAIL_FARE.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_RAIL_FARE) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("JR券代"), Me)
            SetFocus(Me.ANS_RAIL_FARE)
            Return False
        End If

        'JR券取消料
        If Me.ANS_RAIL_CANCELLATION.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_RAIL_CANCELLATION) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("JR券取消料"), Me)
            SetFocus(Me.ANS_RAIL_CANCELLATION)
            Return False
        End If

        'その他鉄道等代金
        If Me.ANS_OTHER_FARE.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_OTHER_FARE) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("その他鉄道等代金"), Me)
            SetFocus(Me.ANS_OTHER_FARE)
            Return False
        End If

        'その他鉄道等取消料
        If Me.ANS_OTHER_CANCELLATION.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_OTHER_CANCELLATION) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("その他鉄道等取消料"), Me)
            SetFocus(Me.ANS_OTHER_CANCELLATION)
            Return False
        End If

        '航空券代
        If Me.ANS_AIR_FARE.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_AIR_FARE) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("航空券代"), Me)
            SetFocus(Me.ANS_AIR_FARE)
            Return False
        End If

        '航空券取消料
        If Me.ANS_AIR_CANCELLATION.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_AIR_CANCELLATION) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("航空券取消料"), Me)
            SetFocus(Me.ANS_AIR_CANCELLATION)
            Return False
        End If

        'タクチケ発行枚数
        If Me.ANS_TAXI_MAISUU.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsNumberOnly(Me.ANS_TAXI_MAISUU) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ発行枚数"), Me)
            SetFocus(Me.ANS_TAXI_MAISUU)
            Return False
        End If

        'MR交通費
        If Me.ANS_MR_KOTSUHI.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_MR_KOTSUHI) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("MR交通費"), Me)
            SetFocus(Me.ANS_MR_KOTSUHI)
            Return False
        End If

        'MR宿泊費（税込)
        If Me.ANS_MR_HOTELHI.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_MR_HOTELHI) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("MR宿泊費"), Me)
            SetFocus(Me.ANS_MR_HOTELHI)
            Return False
        End If

        'MR宿泊費都税
        If Me.ANS_MR_HOTELHI_TOZEI.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_MR_HOTELHI_TOZEI) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("MR宿泊費都税"), Me)
            SetFocus(Me.ANS_MR_HOTELHI_TOZEI)
            Return False
        End If

        Return True
    End Function

    '入力値を取得
    Private Sub GetValue(ByVal SEND_FLAG As String)
        'DR手配
        DSP_KOTSUHOTEL(SEQ).ANS_STATUS_TEHAI = AppModule.GetValue_ANS_STATUS_TEHAI(Me.ANS_STATUS_TEHAI)
        DSP_KOTSUHOTEL(SEQ).ANS_TICKET_SEND_DAY = AppModule.GetValue_ANS_TICKET_SEND_DAY(Me.ANS_TICKET_SEND_DAY)

        '宿泊手配
        DSP_KOTSUHOTEL(SEQ).ANS_STATUS_HOTEL = AppModule.GetValue_ANS_STATUS_HOTEL(Me.ANS_STATUS_HOTEL)
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
        If Me.CHK_ANS_TAXI_HAKKO_1.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_1 = AppModule.GetValue_ANS_TAXI_HAKKO_1(Me.CHK_ANS_TAXI_HAKKO_1)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_1 = AppModule.GetValue_ANS_TAXI_RMKS_1(Me.ANS_TAXI_RMKS_1)
        'タクチケ２
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_2 = AppModule.GetValue_ANS_TAXI_DATE_2(Me.ANS_TAXI_DATE_2)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_2 = AppModule.GetValue_ANS_TAXI_KENSHU_2(Me.ANS_TAXI_KENSHU_2)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_2 = AppModule.GetValue_ANS_TAXI_NO_2(Me.ANS_TAXI_NO_2)
        If Me.CHK_ANS_TAXI_HAKKO_2.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_2 = AppModule.GetValue_ANS_TAXI_HAKKO_2(Me.CHK_ANS_TAXI_HAKKO_2)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_2 = AppModule.GetValue_ANS_TAXI_RMKS_2(Me.ANS_TAXI_RMKS_2)
        'タクチケ３
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_3 = AppModule.GetValue_ANS_TAXI_DATE_3(Me.ANS_TAXI_DATE_3)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_3 = AppModule.GetValue_ANS_TAXI_KENSHU_3(Me.ANS_TAXI_KENSHU_3)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_3 = AppModule.GetValue_ANS_TAXI_NO_3(Me.ANS_TAXI_NO_3)
        If Me.CHK_ANS_TAXI_HAKKO_3.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_3 = AppModule.GetValue_ANS_TAXI_HAKKO_3(Me.CHK_ANS_TAXI_HAKKO_3)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_3 = AppModule.GetValue_ANS_TAXI_RMKS_3(Me.ANS_TAXI_RMKS_3)
        'タクチケ４
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_4 = AppModule.GetValue_ANS_TAXI_DATE_4(Me.ANS_TAXI_DATE_4)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_4 = AppModule.GetValue_ANS_TAXI_KENSHU_4(Me.ANS_TAXI_KENSHU_4)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_4 = AppModule.GetValue_ANS_TAXI_NO_4(Me.ANS_TAXI_NO_4)
        If Me.CHK_ANS_TAXI_HAKKO_4.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_4 = AppModule.GetValue_ANS_TAXI_HAKKO_4(Me.CHK_ANS_TAXI_HAKKO_4)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_4 = AppModule.GetValue_ANS_TAXI_RMKS_4(Me.ANS_TAXI_RMKS_4)
        'タクチケ５
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_5 = AppModule.GetValue_ANS_TAXI_DATE_5(Me.ANS_TAXI_DATE_5)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_5 = AppModule.GetValue_ANS_TAXI_KENSHU_5(Me.ANS_TAXI_KENSHU_5)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_5 = AppModule.GetValue_ANS_TAXI_NO_5(Me.ANS_TAXI_NO_5)
        If Me.CHK_ANS_TAXI_HAKKO_5.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_5 = AppModule.GetValue_ANS_TAXI_HAKKO_5(Me.CHK_ANS_TAXI_HAKKO_5)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_5 = AppModule.GetValue_ANS_TAXI_RMKS_5(Me.ANS_TAXI_RMKS_5)
        'タクチケ６
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_6 = AppModule.GetValue_ANS_TAXI_DATE_6(Me.ANS_TAXI_DATE_6)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_6 = AppModule.GetValue_ANS_TAXI_KENSHU_6(Me.ANS_TAXI_KENSHU_6)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_6 = AppModule.GetValue_ANS_TAXI_NO_6(Me.ANS_TAXI_NO_6)
        If Me.CHK_ANS_TAXI_HAKKO_6.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_6 = AppModule.GetValue_ANS_TAXI_HAKKO_6(Me.CHK_ANS_TAXI_HAKKO_6)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_6 = AppModule.GetValue_ANS_TAXI_RMKS_6(Me.ANS_TAXI_RMKS_6)
        'タクチケ７
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_7 = AppModule.GetValue_ANS_TAXI_DATE_7(Me.ANS_TAXI_DATE_7)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_7 = AppModule.GetValue_ANS_TAXI_KENSHU_7(Me.ANS_TAXI_KENSHU_7)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_7 = AppModule.GetValue_ANS_TAXI_NO_7(Me.ANS_TAXI_NO_7)
        If Me.CHK_ANS_TAXI_HAKKO_7.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_7 = AppModule.GetValue_ANS_TAXI_HAKKO_7(Me.CHK_ANS_TAXI_HAKKO_7)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_7 = AppModule.GetValue_ANS_TAXI_RMKS_7(Me.ANS_TAXI_RMKS_7)
        'タクチケ８
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_8 = AppModule.GetValue_ANS_TAXI_DATE_8(Me.ANS_TAXI_DATE_8)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_8 = AppModule.GetValue_ANS_TAXI_KENSHU_8(Me.ANS_TAXI_KENSHU_8)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_8 = AppModule.GetValue_ANS_TAXI_NO_8(Me.ANS_TAXI_NO_8)
        If Me.CHK_ANS_TAXI_HAKKO_8.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_8 = AppModule.GetValue_ANS_TAXI_HAKKO_8(Me.CHK_ANS_TAXI_HAKKO_8)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_8 = AppModule.GetValue_ANS_TAXI_RMKS_8(Me.ANS_TAXI_RMKS_8)
        'タクチケ９
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_9 = AppModule.GetValue_ANS_TAXI_DATE_9(Me.ANS_TAXI_DATE_9)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_9 = AppModule.GetValue_ANS_TAXI_KENSHU_9(Me.ANS_TAXI_KENSHU_9)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_9 = AppModule.GetValue_ANS_TAXI_NO_9(Me.ANS_TAXI_NO_9)
        If Me.CHK_ANS_TAXI_HAKKO_9.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_9 = AppModule.GetValue_ANS_TAXI_HAKKO_9(Me.CHK_ANS_TAXI_HAKKO_9)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_9 = AppModule.GetValue_ANS_TAXI_RMKS_9(Me.ANS_TAXI_RMKS_9)
        'タクチケ１０
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_10 = AppModule.GetValue_ANS_TAXI_DATE_10(Me.ANS_TAXI_DATE_10)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_10 = AppModule.GetValue_ANS_TAXI_KENSHU_10(Me.ANS_TAXI_KENSHU_10)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_10 = AppModule.GetValue_ANS_TAXI_NO_10(Me.ANS_TAXI_NO_10)
        If Me.CHK_ANS_TAXI_HAKKO_10.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_10 = AppModule.GetValue_ANS_TAXI_HAKKO_10(Me.CHK_ANS_TAXI_HAKKO_10)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_10 = AppModule.GetValue_ANS_TAXI_RMKS_10(Me.ANS_TAXI_RMKS_10)
        'タクチケ１１
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_11 = AppModule.GetValue_ANS_TAXI_DATE_11(Me.ANS_TAXI_DATE_11)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_11 = AppModule.GetValue_ANS_TAXI_KENSHU_11(Me.ANS_TAXI_KENSHU_11)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_11 = AppModule.GetValue_ANS_TAXI_NO_11(Me.ANS_TAXI_NO_11)
        If Me.CHK_ANS_TAXI_HAKKO_11.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_11 = AppModule.GetValue_ANS_TAXI_HAKKO_11(Me.CHK_ANS_TAXI_HAKKO_11)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_11 = AppModule.GetValue_ANS_TAXI_RMKS_11(Me.ANS_TAXI_RMKS_11)
        'タクチケ１２
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_12 = AppModule.GetValue_ANS_TAXI_DATE_12(Me.ANS_TAXI_DATE_12)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_12 = AppModule.GetValue_ANS_TAXI_KENSHU_12(Me.ANS_TAXI_KENSHU_12)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_12 = AppModule.GetValue_ANS_TAXI_NO_12(Me.ANS_TAXI_NO_12)
        If Me.CHK_ANS_TAXI_HAKKO_12.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_12 = AppModule.GetValue_ANS_TAXI_HAKKO_12(Me.CHK_ANS_TAXI_HAKKO_12)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_12 = AppModule.GetValue_ANS_TAXI_RMKS_12(Me.ANS_TAXI_RMKS_12)
        'タクチケ１３
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_13 = AppModule.GetValue_ANS_TAXI_DATE_13(Me.ANS_TAXI_DATE_13)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_13 = AppModule.GetValue_ANS_TAXI_KENSHU_13(Me.ANS_TAXI_KENSHU_13)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_13 = AppModule.GetValue_ANS_TAXI_NO_13(Me.ANS_TAXI_NO_13)
        If Me.CHK_ANS_TAXI_HAKKO_13.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_13 = AppModule.GetValue_ANS_TAXI_HAKKO_13(Me.CHK_ANS_TAXI_HAKKO_13)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_13 = AppModule.GetValue_ANS_TAXI_RMKS_13(Me.ANS_TAXI_RMKS_13)
        'タクチケ１４
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_14 = AppModule.GetValue_ANS_TAXI_DATE_14(Me.ANS_TAXI_DATE_14)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_14 = AppModule.GetValue_ANS_TAXI_KENSHU_14(Me.ANS_TAXI_KENSHU_14)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_14 = AppModule.GetValue_ANS_TAXI_NO_14(Me.ANS_TAXI_NO_14)
        If Me.CHK_ANS_TAXI_HAKKO_14.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_14 = AppModule.GetValue_ANS_TAXI_HAKKO_14(Me.CHK_ANS_TAXI_HAKKO_14)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_14 = AppModule.GetValue_ANS_TAXI_RMKS_14(Me.ANS_TAXI_RMKS_14)
        'タクチケ１５
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_15 = AppModule.GetValue_ANS_TAXI_DATE_15(Me.ANS_TAXI_DATE_15)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_15 = AppModule.GetValue_ANS_TAXI_KENSHU_15(Me.ANS_TAXI_KENSHU_15)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_15 = AppModule.GetValue_ANS_TAXI_NO_15(Me.ANS_TAXI_NO_15)
        If Me.CHK_ANS_TAXI_HAKKO_15.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_15 = AppModule.GetValue_ANS_TAXI_HAKKO_15(Me.CHK_ANS_TAXI_HAKKO_15)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_15 = AppModule.GetValue_ANS_TAXI_RMKS_15(Me.ANS_TAXI_RMKS_15)
        'タクチケ１６
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_16 = AppModule.GetValue_ANS_TAXI_DATE_16(Me.ANS_TAXI_DATE_16)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_16 = AppModule.GetValue_ANS_TAXI_KENSHU_16(Me.ANS_TAXI_KENSHU_16)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_16 = AppModule.GetValue_ANS_TAXI_NO_16(Me.ANS_TAXI_NO_16)
        If Me.CHK_ANS_TAXI_HAKKO_16.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_16 = AppModule.GetValue_ANS_TAXI_HAKKO_16(Me.CHK_ANS_TAXI_HAKKO_16)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_16 = AppModule.GetValue_ANS_TAXI_RMKS_16(Me.ANS_TAXI_RMKS_16)
        'タクチケ１７
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_17 = AppModule.GetValue_ANS_TAXI_DATE_17(Me.ANS_TAXI_DATE_17)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_17 = AppModule.GetValue_ANS_TAXI_KENSHU_17(Me.ANS_TAXI_KENSHU_17)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_17 = AppModule.GetValue_ANS_TAXI_NO_17(Me.ANS_TAXI_NO_17)
        If Me.CHK_ANS_TAXI_HAKKO_17.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_17 = AppModule.GetValue_ANS_TAXI_HAKKO_17(Me.CHK_ANS_TAXI_HAKKO_17)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_17 = AppModule.GetValue_ANS_TAXI_RMKS_17(Me.ANS_TAXI_RMKS_17)
        'タクチケ１８
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_18 = AppModule.GetValue_ANS_TAXI_DATE_18(Me.ANS_TAXI_DATE_18)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_18 = AppModule.GetValue_ANS_TAXI_KENSHU_18(Me.ANS_TAXI_KENSHU_18)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_18 = AppModule.GetValue_ANS_TAXI_NO_18(Me.ANS_TAXI_NO_18)
        If Me.CHK_ANS_TAXI_HAKKO_18.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_18 = AppModule.GetValue_ANS_TAXI_HAKKO_18(Me.CHK_ANS_TAXI_HAKKO_18)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_18 = AppModule.GetValue_ANS_TAXI_RMKS_18(Me.ANS_TAXI_RMKS_18)
        'タクチケ１９
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_19 = AppModule.GetValue_ANS_TAXI_DATE_19(Me.ANS_TAXI_DATE_19)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_19 = AppModule.GetValue_ANS_TAXI_KENSHU_19(Me.ANS_TAXI_KENSHU_19)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_19 = AppModule.GetValue_ANS_TAXI_NO_19(Me.ANS_TAXI_NO_19)
        If Me.CHK_ANS_TAXI_HAKKO_19.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_19 = AppModule.GetValue_ANS_TAXI_HAKKO_19(Me.CHK_ANS_TAXI_HAKKO_19)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_19 = AppModule.GetValue_ANS_TAXI_RMKS_19(Me.ANS_TAXI_RMKS_19)
        'タクチケ２０
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_DATE_20 = AppModule.GetValue_ANS_TAXI_DATE_20(Me.ANS_TAXI_DATE_20)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_KENSHU_20 = AppModule.GetValue_ANS_TAXI_KENSHU_20(Me.ANS_TAXI_KENSHU_20)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_NO_20 = AppModule.GetValue_ANS_TAXI_NO_20(Me.ANS_TAXI_NO_20)
        If Me.CHK_ANS_TAXI_HAKKO_20.Visible Then _
            DSP_KOTSUHOTEL(SEQ).ANS_TAXI_HAKKO_20 = AppModule.GetValue_ANS_TAXI_HAKKO_20(Me.CHK_ANS_TAXI_HAKKO_20)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_RMKS_20 = AppModule.GetValue_ANS_TAXI_RMKS_20(Me.ANS_TAXI_RMKS_20)

        'MR手配
        DSP_KOTSUHOTEL(SEQ).ANS_MR_O_TEHAI = AppModule.getvalue_ANS_MR_O_TEHAI(Me.ANS_MR_O_TEHAI)
        DSP_KOTSUHOTEL(SEQ).ANS_MR_F_TEHAI = AppModule.GetValue_ANS_MR_O_TEHAI(Me.ANS_MR_O_TEHAI)
        DSP_KOTSUHOTEL(SEQ).ANS_MR_HOTEL_NOTE = AppModule.GetValue_ANS_MR_HOTEL_NOTE(Me.ANS_MR_HOTEL_NOTE)

        '各種代金
        DSP_KOTSUHOTEL(SEQ).ANS_HOTELHI = AppModule.GetValue_ANS_HOTELHI(Me.ANS_HOTELHI)
        DSP_KOTSUHOTEL(SEQ).ANS_HOTELHI_TOZEI = AppModule.GetValue_ANS_HOTELHI_TOZEI(Me.ANS_HOTELHI_TOZEI)
        DSP_KOTSUHOTEL(SEQ).ANS_HOTELHI_CANCEL = AppModule.GetValue_ANS_HOTELHI_CANCEL(Me.ANS_HOTELHI_CANCEL)
        DSP_KOTSUHOTEL(SEQ).ANS_RAIL_FARE = AppModule.GetValue_ANS_RAIL_FARE(Me.ANS_RAIL_FARE)
        DSP_KOTSUHOTEL(SEQ).ANS_RAIL_CANCELLATION = AppModule.GetValue_ANS_RAIL_CANCELLATION(Me.ANS_RAIL_CANCELLATION)
        DSP_KOTSUHOTEL(SEQ).ANS_OTHER_FARE = AppModule.GetValue_ANS_OTHER_FARE(Me.ANS_OTHER_FARE)
        DSP_KOTSUHOTEL(SEQ).ANS_OTHER_CANCELLATION = AppModule.GetValue_ANS_OTHER_CANCELLATION(Me.ANS_OTHER_CANCELLATION)
        DSP_KOTSUHOTEL(SEQ).ANS_AIR_FARE = AppModule.GetValue_ANS_AIR_FARE(Me.ANS_AIR_FARE)
        DSP_KOTSUHOTEL(SEQ).ANS_AIR_CANCELLATION = AppModule.GetValue_ANS_AIR_CANCELLATION(Me.ANS_AIR_CANCELLATION)
        DSP_KOTSUHOTEL(SEQ).ANS_KOTSUHOTEL_TESURYO = AppModule.GetValue_ANS_KOTSUHOTEL_TESURYO(Me.ANS_KOTSUHOTEL_TESURYO)
        DSP_KOTSUHOTEL(SEQ).ANS_TAXI_TESURYO = AppModule.GetValue_ANS_TAXI_TESURYO(Me.ANS_TAXI_MAISUU)
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
        If ANS_O_KOTSUKIKAN_1.SelectedValue <> "" OrElse _
            ANS_O_DATE_1.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT1_1.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT2_1.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME1_1.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME2_1.Text.Trim <> String.Empty OrElse _
            ANS_O_BIN_1.Text.Trim <> String.Empty OrElse _
            ANS_O_SEAT_1.SelectedValue <> "" OrElse _
            ANS_O_SEAT_KIBOU1.SelectedValue <> "" Then

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
        If ANS_O_KOTSUKIKAN_2.SelectedValue <> "" OrElse _
            ANS_O_DATE_2.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT1_2.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT2_2.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME1_2.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME2_2.Text.Trim <> String.Empty OrElse _
            ANS_O_BIN_2.Text.Trim <> String.Empty OrElse _
            ANS_O_SEAT_2.SelectedValue <> "" OrElse _
            ANS_O_SEAT_KIBOU2.SelectedValue <> "" Then

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
        If ANS_O_KOTSUKIKAN_3.SelectedValue <> "" OrElse _
            ANS_O_DATE_3.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT1_3.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT2_3.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME1_3.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME2_3.Text.Trim <> String.Empty OrElse _
            ANS_O_BIN_3.Text.Trim <> String.Empty OrElse _
            ANS_O_SEAT_3.SelectedValue <> "" OrElse _
            ANS_O_SEAT_KIBOU3.SelectedValue <> "" Then

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
        If ANS_O_KOTSUKIKAN_4.SelectedValue <> "" OrElse _
            ANS_O_DATE_4.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT1_4.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT2_4.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME1_4.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME2_4.Text.Trim <> String.Empty OrElse _
            ANS_O_BIN_4.Text.Trim <> String.Empty OrElse _
            ANS_O_SEAT_4.SelectedValue <> "" OrElse _
            ANS_O_SEAT_KIBOU4.SelectedValue <> "" Then

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
        If ANS_O_KOTSUKIKAN_5.SelectedValue <> "" OrElse _
            ANS_O_DATE_5.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT1_5.Text.Trim <> String.Empty OrElse _
            ANS_O_AIRPORT2_5.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME1_5.Text.Trim <> String.Empty OrElse _
            ANS_O_TIME2_5.Text.Trim <> String.Empty OrElse _
            ANS_O_BIN_5.Text.Trim <> String.Empty OrElse _
            ANS_O_SEAT_5.SelectedValue <> "" OrElse _
            ANS_O_SEAT_KIBOU5.SelectedValue <> "" Then

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
        If ANS_F_KOTSUKIKAN_1.SelectedValue <> "" OrElse _
            ANS_F_DATE_1.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT1_1.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT2_1.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME1_1.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME2_1.Text.Trim <> String.Empty OrElse _
            ANS_F_BIN_1.Text.Trim <> String.Empty OrElse _
            ANS_F_SEAT_1.SelectedValue <> "" OrElse _
            ANS_F_SEAT_KIBOU1.SelectedValue <> "" Then

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
        If ANS_F_KOTSUKIKAN_2.SelectedValue <> "" OrElse _
            ANS_F_DATE_2.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT1_2.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT2_2.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME1_2.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME2_2.Text.Trim <> String.Empty OrElse _
            ANS_F_BIN_2.Text.Trim <> String.Empty OrElse _
            ANS_F_SEAT_2.SelectedValue <> "" OrElse _
            ANS_F_SEAT_KIBOU2.SelectedValue <> "" Then

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
        If ANS_F_KOTSUKIKAN_3.SelectedValue <> "" OrElse _
            ANS_F_DATE_3.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT1_3.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT2_3.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME1_3.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME2_3.Text.Trim <> String.Empty OrElse _
            ANS_F_BIN_3.Text.Trim <> String.Empty OrElse _
            ANS_F_SEAT_3.SelectedValue <> "" OrElse _
            ANS_F_SEAT_KIBOU3.SelectedValue <> "" Then

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
        If ANS_F_KOTSUKIKAN_4.SelectedValue <> "" OrElse _
            ANS_F_DATE_4.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT1_4.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT2_4.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME1_4.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME2_4.Text.Trim <> String.Empty OrElse _
            ANS_F_BIN_4.Text.Trim <> String.Empty OrElse _
            ANS_F_SEAT_4.SelectedValue <> "" OrElse _
            ANS_F_SEAT_KIBOU4.SelectedValue <> "" Then

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
        If ANS_F_KOTSUKIKAN_5.SelectedValue <> "" OrElse _
            ANS_F_DATE_5.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT1_5.Text.Trim <> String.Empty OrElse _
            ANS_F_AIRPORT2_5.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME1_5.Text.Trim <> String.Empty OrElse _
            ANS_F_TIME2_5.Text.Trim <> String.Empty OrElse _
            ANS_F_BIN_5.Text.Trim <> String.Empty OrElse _
            ANS_F_SEAT_5.SelectedValue <> "" OrElse _
            ANS_F_SEAT_KIBOU5.SelectedValue <> "" Then

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
    Private Sub BtnBack_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnBack1.Click, BtnBack2.Click
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

    '[手配書印刷]
    Private Sub BtnPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnPrint1.Click, BtnPrint2.Click
        Dim strSQL As String = ""
        strSQL = SQL.TBL_KOTSUHOTEL.DrReport(DSP_KOTSUHOTEL(SEQ).KOUENKAI_NO, DSP_KOTSUHOTEL(SEQ).SANKASHA_ID)
        Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
        Session.Item(SessionDef.TBL_KOTSUHOTEL) = TBL_KOTSUHOTEL
        Session.Item(SessionDef.TehaishoPrint_SQL) = strSQL
        Session.Item(SessionDef.PrintPreview) = "Tehaisho"
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Response.Redirect(URL.Preview)
    End Sub

    '宿泊費消費税抜金額表示
    Private Sub ANS_HOTELHI_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ANS_HOTELHI.TextChanged

        '宿泊費（税込)
        If Me.ANS_HOTELHI.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_HOTELHI) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("宿泊費"), Me)
            SetFocus(Me.ANS_HOTELHI)
            Exit Sub
        End If

        Dim strZeiRate As String = AppModule.GetZeiRate(DSP_KOTSUHOTEL(SEQ).FROM_DATE, MyBase.DbConnection)
        Me.ANS_HOTELHI_TF.Text = CmnModule.EditComma(AppModule.GetZeinukiGaku(Me.ANS_HOTELHI.Text.Trim.ToString, strZeiRate))
        SetFocus(Me.ANS_HOTELHI_TOZEI)
    End Sub

    'MR宿泊費消費税抜金額表示
    Private Sub ANS_MR_HOTELHI_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ANS_MR_HOTELHI.TextChanged

        'MR宿泊費（税込)
        If Me.ANS_MR_HOTELHI.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsValidKingaku(Me.ANS_MR_HOTELHI) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("MR宿泊費"), Me)
            SetFocus(Me.ANS_MR_HOTELHI)
            Exit Sub
        End If

        Dim strZeiRate As String = AppModule.GetZeiRate(DSP_KOTSUHOTEL(SEQ).FROM_DATE, MyBase.DbConnection)
        Me.ANS_MR_HOTELHI_TF.Text = CmnModule.EditComma(AppModule.GetZeinukiGaku(Me.ANS_MR_HOTELHI.Text.Trim.ToString, strZeiRate))
        SetFocus(Me.ANS_MR_HOTELHI_TOZEI)
    End Sub

    '交通(往路)手配1クリアボタン
    Protected Sub BtnClear_O_TEHAI_1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_O_TEHAI_1.Click
        Me.ANS_O_KOTSUKIKAN_1.SelectedValue = ""
        Me.ANS_O_DATE_1.Text = ""
        Me.ANS_O_AIRPORT1_1.Text = ""
        Me.ANS_O_AIRPORT2_1.Text = ""
        Me.ANS_O_TIME1_1.Text = ""
        Me.ANS_O_TIME2_1.Text = ""
        Me.ANS_O_BIN_1.Text = ""
        Me.ANS_O_SEAT_1.SelectedValue = ""
        Me.ANS_O_SEAT_KIBOU1.SelectedValue = ""
        SetFocus(Me.ANS_O_KOTSUKIKAN_1)
    End Sub

    '交通(往路)手配2クリアボタン
    Protected Sub BtnClear_O_TEHAI_2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_O_TEHAI_2.Click
        Me.ANS_O_KOTSUKIKAN_2.SelectedValue = ""
        Me.ANS_O_DATE_2.Text = ""
        Me.ANS_O_AIRPORT1_2.Text = ""
        Me.ANS_O_AIRPORT2_2.Text = ""
        Me.ANS_O_TIME1_2.Text = ""
        Me.ANS_O_TIME2_2.Text = ""
        Me.ANS_O_BIN_2.Text = ""
        Me.ANS_O_SEAT_2.SelectedValue = ""
        Me.ANS_O_SEAT_KIBOU2.SelectedValue = ""
        SetFocus(Me.ANS_O_KOTSUKIKAN_2)
    End Sub

    '交通(往路)手配3クリアボタン
    Protected Sub BtnClear_O_TEHAI_3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_O_TEHAI_3.Click
        Me.ANS_O_KOTSUKIKAN_3.SelectedValue = ""
        Me.ANS_O_DATE_3.Text = ""
        Me.ANS_O_AIRPORT1_3.Text = ""
        Me.ANS_O_AIRPORT2_3.Text = ""
        Me.ANS_O_TIME1_3.Text = ""
        Me.ANS_O_TIME2_3.Text = ""
        Me.ANS_O_BIN_3.Text = ""
        Me.ANS_O_SEAT_3.SelectedValue = ""
        Me.ANS_O_SEAT_KIBOU3.SelectedValue = ""
        SetFocus(Me.ANS_O_KOTSUKIKAN_3)
    End Sub

    '交通(往路)手配4クリアボタン
    Protected Sub BtnClear_O_TEHAI_4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_O_TEHAI_4.Click
        Me.ANS_O_KOTSUKIKAN_4.SelectedValue = ""
        Me.ANS_O_DATE_4.Text = ""
        Me.ANS_O_AIRPORT1_4.Text = ""
        Me.ANS_O_AIRPORT2_4.Text = ""
        Me.ANS_O_TIME1_4.Text = ""
        Me.ANS_O_TIME2_4.Text = ""
        Me.ANS_O_BIN_4.Text = ""
        Me.ANS_O_SEAT_4.SelectedValue = ""
        Me.ANS_O_SEAT_KIBOU4.SelectedValue = ""
        SetFocus(Me.ANS_O_KOTSUKIKAN_4)
    End Sub

    '交通(往路)手配5クリアボタン
    Protected Sub BtnClear_O_TEHAI_5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_O_TEHAI_5.Click
        Me.ANS_O_KOTSUKIKAN_5.SelectedValue = ""
        Me.ANS_O_DATE_5.Text = ""
        Me.ANS_O_AIRPORT1_5.Text = ""
        Me.ANS_O_AIRPORT2_5.Text = ""
        Me.ANS_O_TIME1_5.Text = ""
        Me.ANS_O_TIME2_5.Text = ""
        Me.ANS_O_BIN_5.Text = ""
        Me.ANS_O_SEAT_5.SelectedValue = ""
        Me.ANS_O_SEAT_KIBOU5.SelectedValue = ""
        SetFocus(Me.ANS_O_KOTSUKIKAN_5)
    End Sub

    '交通(復路)手配1クリアボタン
    Protected Sub BtnClear_F_TEHAI_1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_F_TEHAI_1.Click
        Me.ANS_F_KOTSUKIKAN_1.SelectedValue = ""
        Me.ANS_F_DATE_1.Text = ""
        Me.ANS_F_AIRPORT1_1.Text = ""
        Me.ANS_F_AIRPORT2_1.Text = ""
        Me.ANS_F_TIME1_1.Text = ""
        Me.ANS_F_TIME2_1.Text = ""
        Me.ANS_F_BIN_1.Text = ""
        Me.ANS_F_SEAT_1.SelectedValue = ""
        Me.ANS_F_SEAT_KIBOU1.SelectedValue = ""
        SetFocus(Me.ANS_F_KOTSUKIKAN_1)
    End Sub

    '交通(復路)手配2クリアボタン
    Protected Sub BtnClear_F_TEHAI_2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_F_TEHAI_2.Click
        Me.ANS_F_KOTSUKIKAN_2.SelectedValue = ""
        Me.ANS_F_DATE_2.Text = ""
        Me.ANS_F_AIRPORT1_2.Text = ""
        Me.ANS_F_AIRPORT2_2.Text = ""
        Me.ANS_F_TIME1_2.Text = ""
        Me.ANS_F_TIME2_2.Text = ""
        Me.ANS_F_BIN_2.Text = ""
        Me.ANS_F_SEAT_2.SelectedValue = ""
        Me.ANS_F_SEAT_KIBOU2.SelectedValue = ""
        SetFocus(Me.ANS_F_KOTSUKIKAN_2)
    End Sub

    '交通(復路)手配3クリアボタン
    Protected Sub BtnClear_F_TEHAI_3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_F_TEHAI_3.Click
        Me.ANS_F_KOTSUKIKAN_3.SelectedValue = ""
        Me.ANS_F_DATE_3.Text = ""
        Me.ANS_F_AIRPORT1_3.Text = ""
        Me.ANS_F_AIRPORT2_3.Text = ""
        Me.ANS_F_TIME1_3.Text = ""
        Me.ANS_F_TIME2_3.Text = ""
        Me.ANS_F_BIN_3.Text = ""
        Me.ANS_F_SEAT_3.SelectedValue = ""
        Me.ANS_F_SEAT_KIBOU3.SelectedValue = ""
        SetFocus(Me.ANS_F_KOTSUKIKAN_3)
    End Sub

    '交通(復路)手配4クリアボタン
    Protected Sub BtnClear_F_TEHAI_4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_F_TEHAI_4.Click
        Me.ANS_F_KOTSUKIKAN_4.SelectedValue = ""
        Me.ANS_F_DATE_4.Text = ""
        Me.ANS_F_AIRPORT1_4.Text = ""
        Me.ANS_F_AIRPORT2_4.Text = ""
        Me.ANS_F_TIME1_4.Text = ""
        Me.ANS_F_TIME2_4.Text = ""
        Me.ANS_F_BIN_4.Text = ""
        Me.ANS_F_SEAT_4.SelectedValue = ""
        Me.ANS_F_SEAT_KIBOU4.SelectedValue = ""
        SetFocus(Me.ANS_F_KOTSUKIKAN_4)
    End Sub

    '交通(復路)手配5クリアボタン
    Protected Sub BtnClear_F_TEHAI_5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnClear_F_TEHAI_5.Click
        Me.ANS_F_KOTSUKIKAN_5.SelectedValue = ""
        Me.ANS_F_DATE_5.Text = ""
        Me.ANS_F_AIRPORT1_5.Text = ""
        Me.ANS_F_AIRPORT2_5.Text = ""
        Me.ANS_F_TIME1_5.Text = ""
        Me.ANS_F_TIME2_5.Text = ""
        Me.ANS_F_BIN_5.Text = ""
        Me.ANS_F_SEAT_5.SelectedValue = ""
        Me.ANS_F_SEAT_KIBOU5.SelectedValue = ""
        SetFocus(Me.ANS_F_KOTSUKIKAN_5)
    End Sub

    'タクチケクリアボタン
    Protected Sub BtnTicketClear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTicketClear.Click
        Me.CHK_ANS_TAXI_HAKKO_1.Checked = False
        Me.ANS_TAXI_DATE_1.Text = ""
        Me.ANS_TAXI_KENSHU_1.SelectedValue = ""
        Me.ANS_TAXI_NO_1.Text = ""
        Me.ANS_TAXI_RMKS_1.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_2.Checked = False
        Me.ANS_TAXI_DATE_2.Text = ""
        Me.ANS_TAXI_KENSHU_2.SelectedValue = ""
        Me.ANS_TAXI_NO_2.Text = ""
        Me.ANS_TAXI_RMKS_2.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_3.Checked = False
        Me.ANS_TAXI_DATE_3.Text = ""
        Me.ANS_TAXI_KENSHU_3.SelectedValue = ""
        Me.ANS_TAXI_NO_3.Text = ""
        Me.ANS_TAXI_RMKS_3.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_4.Checked = False
        Me.ANS_TAXI_DATE_4.Text = ""
        Me.ANS_TAXI_KENSHU_4.SelectedValue = ""
        Me.ANS_TAXI_NO_4.Text = ""
        Me.ANS_TAXI_RMKS_4.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_5.Checked = False
        Me.ANS_TAXI_DATE_5.Text = ""
        Me.ANS_TAXI_KENSHU_5.SelectedValue = ""
        Me.ANS_TAXI_NO_5.Text = ""
        Me.ANS_TAXI_RMKS_5.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_6.Checked = False
        Me.ANS_TAXI_DATE_6.Text = ""
        Me.ANS_TAXI_KENSHU_6.SelectedValue = ""
        Me.ANS_TAXI_NO_6.Text = ""
        Me.ANS_TAXI_RMKS_6.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_7.Checked = False
        Me.ANS_TAXI_DATE_7.Text = ""
        Me.ANS_TAXI_KENSHU_7.SelectedValue = ""
        Me.ANS_TAXI_NO_7.Text = ""
        Me.ANS_TAXI_RMKS_7.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_8.Checked = False
        Me.ANS_TAXI_DATE_8.Text = ""
        Me.ANS_TAXI_KENSHU_8.SelectedValue = ""
        Me.ANS_TAXI_NO_8.Text = ""
        Me.ANS_TAXI_RMKS_8.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_9.Checked = False
        Me.ANS_TAXI_DATE_9.Text = ""
        Me.ANS_TAXI_KENSHU_9.SelectedValue = ""
        Me.ANS_TAXI_NO_9.Text = ""
        Me.ANS_TAXI_RMKS_9.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_10.Checked = False
        Me.ANS_TAXI_DATE_10.Text = ""
        Me.ANS_TAXI_KENSHU_10.SelectedValue = ""
        Me.ANS_TAXI_NO_10.Text = ""
        Me.ANS_TAXI_RMKS_10.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_11.Checked = False
        Me.ANS_TAXI_DATE_11.Text = ""
        Me.ANS_TAXI_KENSHU_11.SelectedValue = ""
        Me.ANS_TAXI_NO_11.Text = ""
        Me.ANS_TAXI_RMKS_11.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_12.Checked = False
        Me.ANS_TAXI_DATE_12.Text = ""
        Me.ANS_TAXI_KENSHU_12.SelectedValue = ""
        Me.ANS_TAXI_NO_12.Text = ""
        Me.ANS_TAXI_RMKS_12.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_13.Checked = False
        Me.ANS_TAXI_DATE_13.Text = ""
        Me.ANS_TAXI_KENSHU_13.SelectedValue = ""
        Me.ANS_TAXI_NO_13.Text = ""
        Me.ANS_TAXI_RMKS_13.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_14.Checked = False
        Me.ANS_TAXI_DATE_14.Text = ""
        Me.ANS_TAXI_KENSHU_14.SelectedValue = ""
        Me.ANS_TAXI_NO_14.Text = ""
        Me.ANS_TAXI_RMKS_14.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_15.Checked = False
        Me.ANS_TAXI_DATE_15.Text = ""
        Me.ANS_TAXI_KENSHU_15.SelectedValue = ""
        Me.ANS_TAXI_NO_15.Text = ""
        Me.ANS_TAXI_RMKS_15.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_16.Checked = False
        Me.ANS_TAXI_DATE_16.Text = ""
        Me.ANS_TAXI_KENSHU_16.SelectedValue = ""
        Me.ANS_TAXI_NO_16.Text = ""
        Me.ANS_TAXI_RMKS_16.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_17.Checked = False
        Me.ANS_TAXI_DATE_17.Text = ""
        Me.ANS_TAXI_KENSHU_17.SelectedValue = ""
        Me.ANS_TAXI_NO_17.Text = ""
        Me.ANS_TAXI_RMKS_17.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_18.Checked = False
        Me.ANS_TAXI_DATE_18.Text = ""
        Me.ANS_TAXI_KENSHU_18.SelectedValue = ""
        Me.ANS_TAXI_NO_18.Text = ""
        Me.ANS_TAXI_RMKS_18.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_19.Checked = False
        Me.ANS_TAXI_DATE_19.Text = ""
        Me.ANS_TAXI_KENSHU_19.SelectedValue = ""
        Me.ANS_TAXI_NO_19.Text = ""
        Me.ANS_TAXI_RMKS_19.Text = ""
        Me.CHK_ANS_TAXI_HAKKO_20.Checked = False
        Me.ANS_TAXI_DATE_20.Text = ""
        Me.ANS_TAXI_KENSHU_20.SelectedValue = ""
        Me.ANS_TAXI_NO_20.Text = ""
        Me.ANS_TAXI_RMKS_20.Text = ""
        SetFocus(Me.ANS_TAXI_DATE_1)
    End Sub

    'タクチケコピーボタン
    Protected Sub BtnTicketCopy_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnTicketCopy.Click
        '何れかの項目が入力済みの場合、確認メッセージ表示
        If Me.ANS_TAXI_DATE_1.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_1.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_1.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_1.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_1.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_2.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_2.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_2.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_2.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_2.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_3.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_3.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_3.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_3.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_3.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_4.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_4.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_4.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_4.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_4.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_5.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_5.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_5.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_5.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_5.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_6.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_6.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_6.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_6.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_6.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_7.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_7.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_7.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_7.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_7.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_8.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_8.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_8.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_8.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_8.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_9.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_9.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_9.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_9.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_9.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_10.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_10.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_10.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_10.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_10.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_11.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_11.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_11.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_11.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_11.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_12.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_12.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_12.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_12.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_12.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_13.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_13.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_13.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_13.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_13.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_14.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_14.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_14.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_15.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_15.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_15.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_15.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_15.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_16.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_16.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_16.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_16.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_16.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_17.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_17.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_17.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_17.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_17.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_18.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_18.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_18.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_18.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_18.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_19.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_19.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_19.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_19.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_19.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_DATE_20.Text.Trim <> String.Empty OrElse _
            Me.ANS_TAXI_KENSHU_20.SelectedValue <> "" OrElse _
            Me.ANS_TAXI_NO_20.Text.Trim <> String.Empty OrElse _
            Me.CHK_ANS_TAXI_HAKKO_20.Checked = True OrElse _
            Me.ANS_TAXI_HAKKO_DATE_20.Text.Trim <> String.Empty Then

            CmnModule.AlertMessage(MessageDef.Error.Copy, Me)
            Exit Sub
        End If

        '利用日
        Me.ANS_TAXI_DATE_1.Text = Trim(Replace(Me.REQ_TAXI_DATE_1.Text, "/", ""))
        Me.ANS_TAXI_DATE_2.Text = Trim(Replace(Me.REQ_TAXI_DATE_2.Text, "/", ""))
        Me.ANS_TAXI_DATE_3.Text = Trim(Replace(Me.REQ_TAXI_DATE_3.Text, "/", ""))
        Me.ANS_TAXI_DATE_4.Text = Trim(Replace(Me.REQ_TAXI_DATE_4.Text, "/", ""))
        Me.ANS_TAXI_DATE_5.Text = Trim(Replace(Me.REQ_TAXI_DATE_5.Text, "/", ""))
        Me.ANS_TAXI_DATE_6.Text = Trim(Replace(Me.REQ_TAXI_DATE_6.Text, "/", ""))
        Me.ANS_TAXI_DATE_7.Text = Trim(Replace(Me.REQ_TAXI_DATE_7.Text, "/", ""))
        Me.ANS_TAXI_DATE_8.Text = Trim(Replace(Me.REQ_TAXI_DATE_8.Text, "/", ""))
        Me.ANS_TAXI_DATE_9.Text = Trim(Replace(Me.REQ_TAXI_DATE_9.Text, "/", ""))
        Me.ANS_TAXI_DATE_10.Text = Trim(Replace(Me.REQ_TAXI_DATE_10.Text, "/", ""))
        SetFocus(Me.ANS_TAXI_DATE_1)
    End Sub

    '[送付状印刷]
    Protected Sub BtnSoufujo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnSoufujo1.Click, BtnSoufujo2.Click
        Dim strSQL As String = ""
        strSQL = SQL.TBL_KOTSUHOTEL.DrReport(DSP_KOTSUHOTEL(SEQ).KOUENKAI_NO, DSP_KOTSUHOTEL(SEQ).SANKASHA_ID)
        Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
        Session.Item(SessionDef.TBL_KOTSUHOTEL) = TBL_KOTSUHOTEL
        Session.Item(SessionDef.TehaishoPrint_SQL) = strSQL
        Session.Item(SessionDef.PrintPreview) = "Soufujo"
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Response.Redirect(URL.Preview)
    End Sub

    '[タクチケ手配確認票印刷]
    Private Sub BtnTaxiKakunin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BtnTaxiKakunin1.Click, BtnTaxiKakunin2.Click
        Dim strSQL As String = ""
        strSQL = SQL.TBL_KOTSUHOTEL.DrReport(DSP_KOTSUHOTEL(SEQ).KOUENKAI_NO, DSP_KOTSUHOTEL(SEQ).SANKASHA_ID)
        Session.Item(SessionDef.TBL_KOUENKAI) = TBL_KOUENKAI
        Session.Item(SessionDef.TBL_KOTSUHOTEL) = TBL_KOTSUHOTEL
        Session.Item(SessionDef.TehaishoPrint_SQL) = strSQL
        Session.Item(SessionDef.PrintPreview) = "TaxiKakuninhyo"
        Session.Item(SessionDef.BackURL_Print) = Request.Url.AbsolutePath
        Response.Redirect(URL.Preview)
    End Sub

    'タクチケ発券手数料自動表示
    Private Sub ANS_TAXI_MAISUU_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ANS_TAXI_MAISUU.TextChanged

        'タクチケ発行枚数
        If Me.ANS_TAXI_MAISUU.Text.Trim <> String.Empty AndAlso _
            Not CmnCheck.IsNumberOnly(Me.ANS_TAXI_MAISUU) Then
            CmnModule.AlertMessage(MessageDef.Error.Invalid("タクチケ発行枚数"), Me)
            Me.ANS_TAXI_TESURYO.Text = "0"
            SetFocus(Me.ANS_TAXI_MAISUU)
            Exit Sub
        End If

        If Me.ANS_TAXI_MAISUU.Text.Trim = String.Empty OrElse Me.ANS_TAXI_MAISUU.Text.Trim = "0" Then
            Me.ANS_TAXI_TESURYO.Text = "0"
            Exit Sub
        End If

        Me.ANS_TAXI_TESURYO.Text = (Double.Parse(Me.ANS_TAXI_MAISUU.Text) * Double.Parse(AppModule.GetName_TAXI_TESURYO())).ToString
        SetFocus(Me.ANS_MR_HOTELHI)
    End Sub
End Class
