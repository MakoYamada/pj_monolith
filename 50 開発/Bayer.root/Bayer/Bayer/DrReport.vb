Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports AppLib
Imports CommonLib

Public Class DrReport

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        '項目の編集
        PRINT_DATE.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
        REQ_STATUS_TEHAI.Text = AppModule.GetName_STATUS_TEHAI(REQ_STATUS_TEHAI.Text, False, True)
        REQ_STATUS_TEHAI2.Text = AppModule.GetName_STATUS_TEHAI(REQ_STATUS_TEHAI2.Text, False, True)
        TIME_STAMP_BYL.Text = CmnModule.Format_Date(TIME_STAMP_BYL.Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        TIME_STAMP_BYL2.Text = CmnModule.Format_Date(TIME_STAMP_BYL2.Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        If DR_NAME.Text.Length > 19 Then DR_NAME.Text = Left(DR_NAME.Text, 19)
        If DR_NAME2.Text.Length > 19 Then DR_NAME2.Text = Left(DR_NAME2.Text, 19)
        If DR_KANA.Text.Length > 25 Then DR_KANA.Text = Left(DR_KANA.Text, 25)
        If DR_KANA2.Text.Length > 25 Then DR_KANA2.Text = Left(DR_KANA2.Text, 25)
        If DR_SHISETSU_NAME.Text.Length > 23 Then DR_SHISETSU_NAME.Text = Left(DR_SHISETSU_NAME.Text, 23)
        If DR_SHISETSU_NAME2.Text.Length > 23 Then DR_SHISETSU_NAME2.Text = Left(DR_SHISETSU_NAME2.Text, 23)
        If DR_SHISETSU_ADDRESS.Text.Length > 23 Then DR_SHISETSU_ADDRESS.Text = Left(DR_SHISETSU_ADDRESS.Text, 23)
        If DR_SHISETSU_ADDRESS2.Text.Length > 23 Then DR_SHISETSU_ADDRESS2.Text = Left(DR_SHISETSU_ADDRESS2.Text, 23)
        DR_SEX.Text = AppModule.GetName_DR_SEX(DR_SEX.Text)
        DR_SEX2.Text = AppModule.GetName_DR_SEX(DR_SEX2.Text)
        DR_YAKUWARI.Text = AppModule.GetName_DR_YAKUWARI(DR_YAKUWARI.Text)
        If SHONIN_NAME.Text.Length > 19 Then SHONIN_NAME.Text = Left(SHONIN_NAME.Text, 19)
        SHONIN_DATE.Text = CmnModule.Format_Date(SHONIN_DATE.Text, CmnModule.DateFormatType.YYYYMD)
        If MR_NAME.Text.Length > 15 Then MR_NAME.Text = Left(MR_NAME.Text, 15)
        If MR_AREA.Text.Length > 5 Then MR_AREA.Text = Left(MR_AREA.Text, 5)
        If MR_EIGYOSHO.Text.Length > 9 Then MR_EIGYOSHO.Text = Left(MR_EIGYOSHO.Text, 9)
        If MR_ROMA.Text.Length > 36 Then MR_ROMA.Text = Left(MR_ROMA.Text, 36)
        If MR_KANA.Text.Length > 52 Then MR_KANA.Text = Left(MR_KANA.Text, 52)
        MR_SEX.Text = AppModule.GetName_MR_SEX(MR_SEX.Text)
        If MR_EMAIL_KEITAI.Text.Length > 34 Then MR_EMAIL_KEITAI.Text = Left(MR_EMAIL_KEITAI.Text, 34)
        If MR_EMAIL_PC.Text.Length > 34 Then MR_EMAIL_PC.Text = Left(MR_EMAIL_PC.Text, 34)
        REQ_MR_O_TEHAI.Text = AppModule.GetName_REQ_MR_O_TEHAI(REQ_MR_O_TEHAI.Text)
        REQ_MR_F_TEHAI.Text = AppModule.GetName_REQ_MR_F_TEHAI(REQ_MR_F_TEHAI.Text)
        If MR_SEND_SAKI_FS.Text.Length > 48 Then MR_SEND_SAKI_FS.Text = Left(MR_SEND_SAKI_FS.Text, 48)
        TEHAI_HOTEL.Text = AppModule.GetName_TEHAI_HOTEL(TEHAI_HOTEL.Text)
        HOTEL_IRAINAIYOU.Text = AppModule.GetName_HOTEL_IRAINAIYOU(HOTEL_IRAINAIYOU.Text)
        REQ_HOTEL_DATE.Text = CmnModule.Format_Date(REQ_HOTEL_DATE.Text, CmnModule.DateFormatType.YYYYMD)
        REQ_HOTEL_SMOKING.Text = AppModule.GetName_REQ_HOTEL_SMOKING(REQ_HOTEL_SMOKING.Text)
        If ANS_HOTEL_NAME.Text.Length > 23 Then ANS_HOTEL_NAME.Text = Left(ANS_HOTEL_NAME.Text, 23)
        If AppModule.GetName_ANS_ROOM_TYPE(ANS_ROOM_TYPE.Text).Length > 23 Then
            ANS_ROOM_TYPE.Text = Left(AppModule.GetName_ANS_ROOM_TYPE(ANS_ROOM_TYPE.Text), 23)
        Else
            ANS_ROOM_TYPE.Text = AppModule.GetName_ANS_ROOM_TYPE(ANS_ROOM_TYPE.Text)
        End If
        ANS_HOTELHI.Text = CmnModule.EditComma(ANS_HOTELHI.Text) & "円"
        ANS_HOTELHI_TOZEI.Text = CmnModule.EditComma(ANS_HOTELHI_TOZEI.Text) & "円"
        ANS_HOTELHI_CANCEL.Text = CmnModule.EditComma(ANS_HOTELHI_CANCEL.Text) & "円"
        TEHAI_TAXI.Text = AppModule.GetName_TEHAI_TAXI(TEHAI_TAXI.Text)
        REQ_TAXI_DATE_1.Text = AppModule.GetName_REQ_TAXI_DATE_1(REQ_TAXI_DATE_1.Text)
        REQ_TAXI_DATE_2.Text = AppModule.GetName_REQ_TAXI_DATE_2(REQ_TAXI_DATE_2.Text)
        REQ_TAXI_DATE_3.Text = AppModule.GetName_REQ_TAXI_DATE_3(REQ_TAXI_DATE_3.Text)
        REQ_TAXI_DATE_4.Text = AppModule.GetName_REQ_TAXI_DATE_4(REQ_TAXI_DATE_4.Text)
        REQ_TAXI_DATE_5.Text = AppModule.GetName_REQ_TAXI_DATE_5(REQ_TAXI_DATE_5.Text)
        REQ_TAXI_DATE_6.Text = AppModule.GetName_REQ_TAXI_DATE_6(REQ_TAXI_DATE_6.Text)
        REQ_TAXI_DATE_7.Text = AppModule.GetName_REQ_TAXI_DATE_7(REQ_TAXI_DATE_7.Text)
        REQ_TAXI_DATE_8.Text = AppModule.GetName_REQ_TAXI_DATE_8(REQ_TAXI_DATE_8.Text)
        REQ_TAXI_DATE_9.Text = AppModule.GetName_REQ_TAXI_DATE_9(REQ_TAXI_DATE_9.Text)
        REQ_TAXI_DATE_10.Text = AppModule.GetName_REQ_TAXI_DATE_10(REQ_TAXI_DATE_10.Text)
        TAXI_YOTEIKINGAKU_1.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_1.Text) & "円"
        TAXI_YOTEIKINGAKU_2.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_2.Text) & "円"
        TAXI_YOTEIKINGAKU_3.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_3.Text) & "円"
        TAXI_YOTEIKINGAKU_4.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_4.Text) & "円"
        TAXI_YOTEIKINGAKU_5.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_5.Text) & "円"
        TAXI_YOTEIKINGAKU_6.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_6.Text) & "円"
        TAXI_YOTEIKINGAKU_7.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_7.Text) & "円"
        TAXI_YOTEIKINGAKU_8.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_8.Text) & "円"
        TAXI_YOTEIKINGAKU_9.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_9.Text) & "円"
        TAXI_YOTEIKINGAKU_10.Text = CmnModule.EditComma(TAXI_YOTEIKINGAKU_10.Text) & "円"
        If REQ_TAXI_FROM_1.Text.Length > 11 Then REQ_TAXI_FROM_1.Text = Left(REQ_TAXI_FROM_1.Text, 11)
        If REQ_TAXI_FROM_2.Text.Length > 11 Then REQ_TAXI_FROM_2.Text = Left(REQ_TAXI_FROM_2.Text, 11)
        If REQ_TAXI_FROM_3.Text.Length > 11 Then REQ_TAXI_FROM_3.Text = Left(REQ_TAXI_FROM_3.Text, 11)
        If REQ_TAXI_FROM_4.Text.Length > 11 Then REQ_TAXI_FROM_4.Text = Left(REQ_TAXI_FROM_4.Text, 11)
        If REQ_TAXI_FROM_5.Text.Length > 11 Then REQ_TAXI_FROM_5.Text = Left(REQ_TAXI_FROM_5.Text, 11)
        If REQ_TAXI_FROM_6.Text.Length > 11 Then REQ_TAXI_FROM_6.Text = Left(REQ_TAXI_FROM_6.Text, 11)
        If REQ_TAXI_FROM_7.Text.Length > 11 Then REQ_TAXI_FROM_7.Text = Left(REQ_TAXI_FROM_7.Text, 11)
        If REQ_TAXI_FROM_8.Text.Length > 11 Then REQ_TAXI_FROM_8.Text = Left(REQ_TAXI_FROM_8.Text, 11)
        If REQ_TAXI_FROM_9.Text.Length > 11 Then REQ_TAXI_FROM_9.Text = Left(REQ_TAXI_FROM_9.Text, 11)
        If REQ_TAXI_FROM_10.Text.Length > 11 Then REQ_TAXI_FROM_10.Text = Left(REQ_TAXI_FROM_10.Text, 11)

        OURO1.Text = "往" & "路" & "１"
        OURO2.Text = "往" & "路" & "２"
        OURO3.Text = "往" & "路" & "３"
        OURO4.Text = "往" & "路" & "４"
        OURO5.Text = "往" & "路" & "５"
        FUKURO1.Text = "復" & "路" & "１"
        FUKURO2.Text = "復" & "路" & "２"
        FUKURO3.Text = "復" & "路" & "３"
        FUKURO4.Text = "復" & "路" & "４"
        FUKURO5.Text = "復" & "路" & "５"

        REQ_O_TEHAI_1.Text = AppModule.GetName_REQ_O_TEHAI_1(REQ_O_TEHAI_1.Text)
        REQ_O_TEHAI_2.Text = AppModule.GetName_REQ_O_TEHAI_2(REQ_O_TEHAI_2.Text)
        REQ_O_TEHAI_3.Text = AppModule.GetName_REQ_O_TEHAI_3(REQ_O_TEHAI_3.Text)
        REQ_O_TEHAI_4.Text = AppModule.GetName_REQ_O_TEHAI_4(REQ_O_TEHAI_4.Text)
        REQ_O_TEHAI_5.Text = AppModule.GetName_REQ_O_TEHAI_5(REQ_O_TEHAI_5.Text)
        REQ_F_TEHAI_1.Text = AppModule.GetName_REQ_F_TEHAI_1(REQ_F_TEHAI_1.Text)
        REQ_F_TEHAI_2.Text = AppModule.GetName_REQ_F_TEHAI_2(REQ_F_TEHAI_2.Text)
        REQ_F_TEHAI_3.Text = AppModule.GetName_REQ_F_TEHAI_3(REQ_F_TEHAI_3.Text)
        REQ_F_TEHAI_4.Text = AppModule.GetName_REQ_F_TEHAI_4(REQ_F_TEHAI_4.Text)
        REQ_F_TEHAI_5.Text = AppModule.GetName_REQ_F_TEHAI_5(REQ_F_TEHAI_5.Text)
        REQ_O_IRAINAIYOU_1.Text = AppModule.GetName_REQ_O_IRAINAIYOU_1(REQ_O_IRAINAIYOU_1.Text)
        REQ_O_IRAINAIYOU_2.Text = AppModule.GetName_REQ_O_IRAINAIYOU_2(REQ_O_IRAINAIYOU_2.Text)
        REQ_O_IRAINAIYOU_3.Text = AppModule.GetName_REQ_O_IRAINAIYOU_3(REQ_O_IRAINAIYOU_3.Text)
        REQ_O_IRAINAIYOU_4.Text = AppModule.GetName_REQ_O_IRAINAIYOU_4(REQ_O_IRAINAIYOU_4.Text)
        REQ_O_IRAINAIYOU_5.Text = AppModule.GetName_REQ_O_IRAINAIYOU_5(REQ_O_IRAINAIYOU_5.Text)
        REQ_F_IRAINAIYOU_1.Text = AppModule.GetName_REQ_F_IRAINAIYOU_1(REQ_F_IRAINAIYOU_1.Text)
        REQ_F_IRAINAIYOU_2.Text = AppModule.GetName_REQ_F_IRAINAIYOU_2(REQ_F_IRAINAIYOU_2.Text)
        REQ_F_IRAINAIYOU_3.Text = AppModule.GetName_REQ_F_IRAINAIYOU_3(REQ_F_IRAINAIYOU_3.Text)
        REQ_F_IRAINAIYOU_4.Text = AppModule.GetName_REQ_F_IRAINAIYOU_4(REQ_F_IRAINAIYOU_4.Text)
        REQ_F_IRAINAIYOU_5.Text = AppModule.GetName_REQ_F_IRAINAIYOU_5(REQ_F_IRAINAIYOU_5.Text)
        REQ_O_KOTSUKIKAN_1.Text = AppModule.GetName_REQ_O_KOTSUKIKAN_1(REQ_O_KOTSUKIKAN_1.Text)
        REQ_O_KOTSUKIKAN_2.Text = AppModule.GetName_REQ_O_KOTSUKIKAN_2(REQ_O_KOTSUKIKAN_2.Text)
        REQ_O_KOTSUKIKAN_3.Text = AppModule.GetName_REQ_O_KOTSUKIKAN_3(REQ_O_KOTSUKIKAN_3.Text)
        REQ_O_KOTSUKIKAN_4.Text = AppModule.GetName_REQ_O_KOTSUKIKAN_4(REQ_O_KOTSUKIKAN_4.Text)
        REQ_O_KOTSUKIKAN_5.Text = AppModule.GetName_REQ_O_KOTSUKIKAN_5(REQ_O_KOTSUKIKAN_5.Text)
        REQ_F_KOTSUKIKAN_1.Text = AppModule.GetName_REQ_F_KOTSUKIKAN_1(REQ_F_KOTSUKIKAN_1.Text)
        REQ_F_KOTSUKIKAN_2.Text = AppModule.GetName_REQ_F_KOTSUKIKAN_2(REQ_F_KOTSUKIKAN_2.Text)
        REQ_F_KOTSUKIKAN_3.Text = AppModule.GetName_REQ_F_KOTSUKIKAN_3(REQ_F_KOTSUKIKAN_3.Text)
        REQ_F_KOTSUKIKAN_4.Text = AppModule.GetName_REQ_F_KOTSUKIKAN_4(REQ_F_KOTSUKIKAN_4.Text)
        REQ_F_KOTSUKIKAN_5.Text = AppModule.GetName_REQ_F_KOTSUKIKAN_5(REQ_F_KOTSUKIKAN_5.Text)
        REQ_O_DATE_1.Text = CmnModule.Format_Date(REQ_O_DATE_1.Text, CmnModule.DateFormatType.YYYYMD)
        REQ_O_DATE_2.Text = CmnModule.Format_Date(REQ_O_DATE_2.Text, CmnModule.DateFormatType.YYYYMD)
        REQ_O_DATE_3.Text = CmnModule.Format_Date(REQ_O_DATE_3.Text, CmnModule.DateFormatType.YYYYMD)
        REQ_O_DATE_4.Text = CmnModule.Format_Date(REQ_O_DATE_4.Text, CmnModule.DateFormatType.YYYYMD)
        REQ_O_DATE_5.Text = CmnModule.Format_Date(REQ_O_DATE_5.Text, CmnModule.DateFormatType.YYYYMD)
        REQ_F_DATE_1.Text = CmnModule.Format_Date(REQ_F_DATE_1.Text, CmnModule.DateFormatType.YYYYMD)
        REQ_F_DATE_2.Text = CmnModule.Format_Date(REQ_F_DATE_2.Text, CmnModule.DateFormatType.YYYYMD)
        REQ_F_DATE_3.Text = CmnModule.Format_Date(REQ_F_DATE_3.Text, CmnModule.DateFormatType.YYYYMD)
        REQ_F_DATE_4.Text = CmnModule.Format_Date(REQ_F_DATE_4.Text, CmnModule.DateFormatType.YYYYMD)
        REQ_F_DATE_5.Text = CmnModule.Format_Date(REQ_F_DATE_5.Text, CmnModule.DateFormatType.YYYYMD)
        If REQ_O_AIRPORT1_1.Text.Length > 7 Then REQ_O_AIRPORT1_1.Text = Left(REQ_O_AIRPORT1_1.Text, 7)
        If REQ_O_AIRPORT2_1.Text.Length > 7 Then REQ_O_AIRPORT2_1.Text = Left(REQ_O_AIRPORT2_1.Text, 7)
        If REQ_O_AIRPORT1_2.Text.Length > 7 Then REQ_O_AIRPORT1_2.Text = Left(REQ_O_AIRPORT1_2.Text, 7)
        If REQ_O_AIRPORT2_2.Text.Length > 7 Then REQ_O_AIRPORT2_2.Text = Left(REQ_O_AIRPORT2_2.Text, 7)
        If REQ_O_AIRPORT1_3.Text.Length > 7 Then REQ_O_AIRPORT1_3.Text = Left(REQ_O_AIRPORT1_3.Text, 7)
        If REQ_O_AIRPORT2_3.Text.Length > 7 Then REQ_O_AIRPORT2_3.Text = Left(REQ_O_AIRPORT2_3.Text, 7)
        If REQ_O_AIRPORT1_4.Text.Length > 7 Then REQ_O_AIRPORT1_4.Text = Left(REQ_O_AIRPORT1_4.Text, 7)
        If REQ_O_AIRPORT2_4.Text.Length > 7 Then REQ_O_AIRPORT2_4.Text = Left(REQ_O_AIRPORT2_4.Text, 7)
        If REQ_O_AIRPORT1_5.Text.Length > 7 Then REQ_O_AIRPORT1_5.Text = Left(REQ_O_AIRPORT1_5.Text, 7)
        If REQ_O_AIRPORT2_5.Text.Length > 7 Then REQ_O_AIRPORT2_5.Text = Left(REQ_O_AIRPORT2_5.Text, 7)
        If REQ_F_AIRPORT1_1.Text.Length > 7 Then REQ_F_AIRPORT1_1.Text = Left(REQ_F_AIRPORT1_1.Text, 7)
        If REQ_F_AIRPORT2_1.Text.Length > 7 Then REQ_F_AIRPORT2_1.Text = Left(REQ_F_AIRPORT2_1.Text, 7)
        If REQ_F_AIRPORT1_2.Text.Length > 7 Then REQ_F_AIRPORT1_2.Text = Left(REQ_F_AIRPORT1_2.Text, 7)
        If REQ_F_AIRPORT2_2.Text.Length > 7 Then REQ_F_AIRPORT2_2.Text = Left(REQ_F_AIRPORT2_2.Text, 7)
        If REQ_F_AIRPORT1_3.Text.Length > 7 Then REQ_F_AIRPORT1_3.Text = Left(REQ_F_AIRPORT1_3.Text, 7)
        If REQ_F_AIRPORT2_3.Text.Length > 7 Then REQ_F_AIRPORT2_3.Text = Left(REQ_F_AIRPORT2_3.Text, 7)
        If REQ_F_AIRPORT1_4.Text.Length > 7 Then REQ_F_AIRPORT1_4.Text = Left(REQ_F_AIRPORT1_4.Text, 7)
        If REQ_F_AIRPORT2_4.Text.Length > 7 Then REQ_F_AIRPORT2_4.Text = Left(REQ_F_AIRPORT2_4.Text, 7)
        If REQ_F_AIRPORT1_5.Text.Length > 7 Then REQ_F_AIRPORT1_5.Text = Left(REQ_F_AIRPORT1_5.Text, 7)
        If REQ_F_AIRPORT2_5.Text.Length > 7 Then REQ_F_AIRPORT2_5.Text = Left(REQ_F_AIRPORT2_5.Text, 7)
        REQ_O_TIME1_1.Text = CmnModule.Format_Date(REQ_O_TIME1_1.Text, CmnModule.DateFormatType.HHMM)
        REQ_O_TIME2_1.Text = CmnModule.Format_Date(REQ_O_TIME2_1.Text, CmnModule.DateFormatType.HHMM)
        REQ_O_TIME1_2.Text = CmnModule.Format_Date(REQ_O_TIME1_2.Text, CmnModule.DateFormatType.HHMM)
        REQ_O_TIME2_2.Text = CmnModule.Format_Date(REQ_O_TIME2_2.Text, CmnModule.DateFormatType.HHMM)
        REQ_O_TIME1_3.Text = CmnModule.Format_Date(REQ_O_TIME1_3.Text, CmnModule.DateFormatType.HHMM)
        REQ_O_TIME2_3.Text = CmnModule.Format_Date(REQ_O_TIME2_3.Text, CmnModule.DateFormatType.HHMM)
        REQ_O_TIME1_4.Text = CmnModule.Format_Date(REQ_O_TIME1_4.Text, CmnModule.DateFormatType.HHMM)
        REQ_O_TIME2_4.Text = CmnModule.Format_Date(REQ_O_TIME2_4.Text, CmnModule.DateFormatType.HHMM)
        REQ_O_TIME1_5.Text = CmnModule.Format_Date(REQ_O_TIME1_5.Text, CmnModule.DateFormatType.HHMM)
        REQ_O_TIME2_5.Text = CmnModule.Format_Date(REQ_O_TIME2_5.Text, CmnModule.DateFormatType.HHMM)
        REQ_O_SEAT_1.Text = AppModule.GetName_REQ_O_SEAT_1(REQ_O_SEAT_1.Text)
        REQ_O_SEAT_2.Text = AppModule.GetName_REQ_O_SEAT_2(REQ_O_SEAT_2.Text)
        REQ_O_SEAT_3.Text = AppModule.GetName_REQ_O_SEAT_3(REQ_O_SEAT_3.Text)
        REQ_O_SEAT_4.Text = AppModule.GetName_REQ_O_SEAT_4(REQ_O_SEAT_4.Text)
        REQ_O_SEAT_5.Text = AppModule.GetName_REQ_O_SEAT_5(REQ_O_SEAT_5.Text)
        REQ_F_SEAT_1.Text = AppModule.GetName_REQ_F_SEAT_1(REQ_F_SEAT_1.Text)
        REQ_F_SEAT_2.Text = AppModule.GetName_REQ_F_SEAT_2(REQ_F_SEAT_2.Text)
        REQ_F_SEAT_3.Text = AppModule.GetName_REQ_F_SEAT_3(REQ_F_SEAT_3.Text)
        REQ_F_SEAT_4.Text = AppModule.GetName_REQ_F_SEAT_4(REQ_F_SEAT_4.Text)
        REQ_F_SEAT_5.Text = AppModule.GetName_REQ_F_SEAT_5(REQ_F_SEAT_5.Text)
        REQ_O_SEAT_KIBOU1.Text = AppModule.GetName_REQ_O_SEAT_KIBOU_1(REQ_O_SEAT_KIBOU1.Text)
        REQ_O_SEAT_KIBOU2.Text = AppModule.GetName_REQ_O_SEAT_KIBOU_2(REQ_O_SEAT_KIBOU2.Text)
        REQ_O_SEAT_KIBOU3.Text = AppModule.GetName_REQ_O_SEAT_KIBOU_3(REQ_O_SEAT_KIBOU3.Text)
        REQ_O_SEAT_KIBOU4.Text = AppModule.GetName_REQ_O_SEAT_KIBOU_4(REQ_O_SEAT_KIBOU4.Text)
        REQ_O_SEAT_KIBOU5.Text = AppModule.GetName_REQ_O_SEAT_KIBOU_5(REQ_O_SEAT_KIBOU5.Text)
        REQ_F_SEAT_KIBOU1.Text = AppModule.GetName_REQ_F_SEAT_KIBOU_1(REQ_F_SEAT_KIBOU1.Text)
        REQ_F_SEAT_KIBOU2.Text = AppModule.GetName_REQ_F_SEAT_KIBOU_2(REQ_F_SEAT_KIBOU2.Text)
        REQ_F_SEAT_KIBOU3.Text = AppModule.GetName_REQ_F_SEAT_KIBOU_3(REQ_F_SEAT_KIBOU3.Text)
        REQ_F_SEAT_KIBOU4.Text = AppModule.GetName_REQ_F_SEAT_KIBOU_4(REQ_F_SEAT_KIBOU4.Text)
        REQ_F_SEAT_KIBOU5.Text = AppModule.GetName_REQ_F_SEAT_KIBOU_5(REQ_F_SEAT_KIBOU5.Text)
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        PRINT_DATE.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
    End Sub
End Class
