﻿Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 
Imports AppLib
Imports CommonLib

Public Class DrReport

    Private pOldTBL_KOTSUHOTEL As TableDef.TBL_KOTSUHOTEL.DataStruct
    Public Property OldTBL_KOTSUHOTEL() As TableDef.TBL_KOTSUHOTEL.DataStruct
        Get
            Return pOldTBL_KOTSUHOTEL
        End Get
        Set(ByVal value As TableDef.TBL_KOTSUHOTEL.DataStruct)
            pOldTBL_KOTSUHOTEL = value
        End Set
    End Property

    Private pRireki As Boolean
    Public Property Rireki() As Boolean
        Get
            Return pRireki
        End Get
        Set(ByVal value As Boolean)
            pRireki = value
        End Set
    End Property

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        '差異のある項目の背景色を変更
        If pRireki = False AndAlso Trim(pOldTBL_KOTSUHOTEL.KOUENKAI_NO) <> "" Then
            '履歴、新規登録時は除外            SetChangedColor(Me.ANS_TICKET_SEND_DAY, pOldTBL_KOTSUHOTEL.ANS_TICKET_SEND_DAY, Me.ANS_TICKET_SEND_DAY.Text)
            SetChangedColor(Me.ANS_TICKET_SEND_DAY2, pOldTBL_KOTSUHOTEL.ANS_TICKET_SEND_DAY, Me.ANS_TICKET_SEND_DAY.Text)
            'SetChangedColor(Me.FROM_DATE1, pOldTBL_KOTSUHOTEL.FROM_DATE, Me.FROM_DATE.Text)
            'SetChangedColor(Me.FROM_DATE2, pOldTBL_KOTSUHOTEL.FROM_DATE, Me.FROM_DATE.Text)
            'SetChangedColor(Me.FROM_DATE1, pOldTBL_KOTSUHOTEL.TO_DATE, Me.TO_DATE.Text)
            'SetChangedColor(Me.FROM_DATE2, pOldTBL_KOTSUHOTEL.TO_DATE, Me.TO_DATE.Text)
            'SetChangedColor(Me.KOUENKAI_NO, pOldTBL_KOTSUHOTEL.KOUENKAI_NO, Me.KOUENKAI_NO.Text)
            'SetChangedColor(Me.KOUENKAI_NO2, pOldTBL_KOTSUHOTEL.KOUENKAI_NO, Me.KOUENKAI_NO2.Text)
            SetChangedColor(Me.REQ_STATUS_TEHAI1, pOldTBL_KOTSUHOTEL.REQ_STATUS_TEHAI, Me.REQ_STATUS_TEHAI.Text)
            SetChangedColor(Me.REQ_STATUS_TEHAI2, pOldTBL_KOTSUHOTEL.REQ_STATUS_TEHAI, Me.REQ_STATUS_TEHAI.Text)
            SetChangedColor(Me.TIME_STAMP_BYL1, pOldTBL_KOTSUHOTEL.TIME_STAMP_BYL, Me.TIME_STAMP_BYL.Text)
            SetChangedColor(Me.TIME_STAMP_BYL2, pOldTBL_KOTSUHOTEL.TIME_STAMP_BYL, Me.TIME_STAMP_BYL.Text)
            SetChangedColor(Me.SANKASHA_ID, pOldTBL_KOTSUHOTEL.SANKASHA_ID, Me.SANKASHA_ID.Text)
            SetChangedColor(Me.SANKASHA_ID2, pOldTBL_KOTSUHOTEL.SANKASHA_ID, Me.SANKASHA_ID.Text)
            SetChangedColor(Me.DR_CD, pOldTBL_KOTSUHOTEL.DR_CD, Me.DR_CD.Text)
            SetChangedColor(Me.DR_CD2, pOldTBL_KOTSUHOTEL.DR_CD, Me.DR_CD2.Text)            SetChangedColor(Me.DR_NAME1, pOldTBL_KOTSUHOTEL.DR_NAME, Me.DR_NAME1.Text)
            SetChangedColor(Me.DR_NAME2, pOldTBL_KOTSUHOTEL.DR_NAME, Me.DR_NAME2.Text)
            SetChangedColor(Me.DR_KANA, pOldTBL_KOTSUHOTEL.DR_KANA, Me.DR_KANA.Text)
            SetChangedColor(Me.DR_KANA2, pOldTBL_KOTSUHOTEL.DR_KANA, Me.DR_KANA2.Text)
            SetChangedColor(Me.DR_SHISETSU_NAME, pOldTBL_KOTSUHOTEL.DR_SHISETSU_NAME, Me.DR_SHISETSU_NAME.Text)
            SetChangedColor(Me.DR_SHISETSU_NAME2, pOldTBL_KOTSUHOTEL.DR_SHISETSU_NAME, Me.DR_SHISETSU_NAME2.Text)
            SetChangedColor(Me.DR_SHISETSU_ADDRESS, pOldTBL_KOTSUHOTEL.DR_SHISETSU_ADDRESS, Me.DR_SHISETSU_ADDRESS.Text)
            SetChangedColor(Me.DR_SHISETSU_ADDRESS2, pOldTBL_KOTSUHOTEL.DR_SHISETSU_ADDRESS, Me.DR_SHISETSU_ADDRESS2.Text)
            SetChangedColor(Me.DR_AGE, pOldTBL_KOTSUHOTEL.DR_AGE, Me.DR_AGE.Text)
            SetChangedColor(Me.DR_AGE2, pOldTBL_KOTSUHOTEL.DR_AGE, Me.DR_AGE2.Text)
            SetChangedColor(Me.DR_SEX, pOldTBL_KOTSUHOTEL.DR_SEX, Me.DR_SEX.Text)
            SetChangedColor(Me.DR_SEX2, pOldTBL_KOTSUHOTEL.DR_SEX, Me.DR_SEX2.Text)
            SetChangedColor(Me.DR_YAKUWARI, pOldTBL_KOTSUHOTEL.DR_YAKUWARI, Me.DR_YAKUWARI.Text)
            SetChangedColor(Me.SHONIN_NAME, pOldTBL_KOTSUHOTEL.SHONIN_NAME, Me.SHONIN_NAME.Text)
            SetChangedColor(Me.SHONIN_DATE, pOldTBL_KOTSUHOTEL.SHONIN_DATE, Me.SHONIN_DATE.Text)
            SetChangedColor(Me.SHITEIGAI_RIYU, pOldTBL_KOTSUHOTEL.SHITEIGAI_RIYU, Me.SHITEIGAI_RIYU.Text)
            SetChangedColor(Me.MR_NAME, pOldTBL_KOTSUHOTEL.MR_NAME, Me.MR_NAME.Text)
            SetChangedColor(Me.MR_BU, pOldTBL_KOTSUHOTEL.MR_BU, Me.MR_BU.Text)
            SetChangedColor(Me.MR_AREA, pOldTBL_KOTSUHOTEL.MR_AREA, Me.MR_AREA.Text)
            SetChangedColor(Me.MR_EIGYOSHO, pOldTBL_KOTSUHOTEL.MR_EIGYOSHO, Me.MR_EIGYOSHO.Text)
            SetChangedColor(Me.MR_ROMA, pOldTBL_KOTSUHOTEL.MR_ROMA, Me.MR_ROMA.Text)
            SetChangedColor(Me.MR_KANA, pOldTBL_KOTSUHOTEL.MR_KANA, Me.MR_KANA.Text)
            SetChangedColor(Me.COST_CENTER, pOldTBL_KOTSUHOTEL.COST_CENTER, Me.COST_CENTER.Text)
            SetChangedColor(Me.MR_SEX, pOldTBL_KOTSUHOTEL.MR_SEX, Me.MR_SEX.Text)
            SetChangedColor(Me.MR_AGE, pOldTBL_KOTSUHOTEL.MR_AGE, Me.MR_AGE.Text)
            SetChangedColor(Me.MR_KEITAI, pOldTBL_KOTSUHOTEL.MR_KEITAI, Me.MR_KEITAI.Text)
            SetChangedColor(Me.MR_EMAIL_KEITAI, pOldTBL_KOTSUHOTEL.MR_EMAIL_KEITAI, Me.MR_EMAIL_KEITAI.Text)
            SetChangedColor(Me.MR_TEL, pOldTBL_KOTSUHOTEL.MR_TEL, Me.MR_TEL.Text)
            SetChangedColor(Me.MR_EMAIL_PC, pOldTBL_KOTSUHOTEL.MR_EMAIL_PC, Me.MR_EMAIL_PC.Text)
            SetChangedColor(Me.REQ_MR_O_TEHAI, pOldTBL_KOTSUHOTEL.REQ_MR_O_TEHAI, Me.REQ_MR_O_TEHAI.Text)
            SetChangedColor(Me.REQ_MR_F_TEHAI, pOldTBL_KOTSUHOTEL.REQ_MR_F_TEHAI, Me.REQ_MR_F_TEHAI.Text)
            SetChangedColor(Me.REQ_MR_HOTEL_NOTE, pOldTBL_KOTSUHOTEL.REQ_MR_HOTEL_NOTE, Me.REQ_MR_HOTEL_NOTE.Text)
            SetChangedColor(Me.MR_SEND_SAKI_FS, pOldTBL_KOTSUHOTEL.MR_SEND_SAKI_FS, Me.MR_SEND_SAKI_FS.Text)
            SetChangedColor(Me.MR_SEND_SAKI_OTHER, pOldTBL_KOTSUHOTEL.MR_SEND_SAKI_OTHER, Me.MR_SEND_SAKI_OTHER.Text)
            SetChangedColor(Me.TEHAI_HOTEL, pOldTBL_KOTSUHOTEL.TEHAI_HOTEL, Me.TEHAI_HOTEL.Text)
            SetChangedColor(Me.HOTEL_IRAINAIYOU, pOldTBL_KOTSUHOTEL.HOTEL_IRAINAIYOU, Me.HOTEL_IRAINAIYOU.Text)
            SetChangedColor(Me.REQ_HOTEL_DATE, pOldTBL_KOTSUHOTEL.REQ_HOTEL_DATE, Me.REQ_HOTEL_DATE.Text)
            SetChangedColor(Me.REQ_HAKUSU, pOldTBL_KOTSUHOTEL.REQ_HAKUSU, Me.REQ_HAKUSU.Text)
            SetChangedColor(Me.REQ_HOTEL_SMOKING, pOldTBL_KOTSUHOTEL.REQ_HOTEL_SMOKING, Me.REQ_HOTEL_SMOKING.Text)
            SetChangedColor(Me.ANS_HOTEL_NAME, pOldTBL_KOTSUHOTEL.ANS_HOTEL_NAME, Me.ANS_HOTEL_NAME.Text)
            SetChangedColor(Me.ANS_ROOM_TYPE, pOldTBL_KOTSUHOTEL.ANS_ROOM_TYPE, Me.ANS_ROOM_TYPE.Text)
            SetChangedColor(Me.ANS_HOTELHI, pOldTBL_KOTSUHOTEL.ANS_HOTELHI, Me.ANS_HOTELHI.Text)
            SetChangedColor(Me.ANS_HOTELHI_TOZEI, pOldTBL_KOTSUHOTEL.ANS_HOTELHI_TOZEI, Me.ANS_HOTELHI_TOZEI.Text)
            SetChangedColor(Me.ANS_HOTELHI_CANCEL, pOldTBL_KOTSUHOTEL.ANS_HOTELHI_CANCEL, Me.ANS_HOTELHI_CANCEL.Text)
            SetChangedColor(Me.REQ_HOTEL_NOTE, pOldTBL_KOTSUHOTEL.REQ_HOTEL_NOTE, Me.REQ_HOTEL_NOTE.Text)
            SetChangedColor(Me.TEHAI_TAXI, pOldTBL_KOTSUHOTEL.TEHAI_TAXI, Me.TEHAI_TAXI.Text)
            SetChangedColor(Me.REQ_TAXI_DATE_1, pOldTBL_KOTSUHOTEL.REQ_TAXI_DATE_1, Me.REQ_TAXI_DATE_1.Text)
            SetChangedColor(Me.REQ_TAXI_FROM_1, pOldTBL_KOTSUHOTEL.REQ_TAXI_FROM_1, Me.REQ_TAXI_FROM_1.Text)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_1, pOldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_1, Me.TAXI_YOTEIKINGAKU_1.Text)
            SetChangedColor(Me.REQ_TAXI_DATE_2, pOldTBL_KOTSUHOTEL.REQ_TAXI_DATE_2, Me.REQ_TAXI_DATE_2.Text)
            SetChangedColor(Me.REQ_TAXI_FROM_2, pOldTBL_KOTSUHOTEL.REQ_TAXI_FROM_2, Me.REQ_TAXI_FROM_2.Text)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_2, pOldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_2, Me.TAXI_YOTEIKINGAKU_2.Text)
            SetChangedColor(Me.REQ_TAXI_DATE_3, pOldTBL_KOTSUHOTEL.REQ_TAXI_DATE_3, Me.REQ_TAXI_DATE_3.Text)
            SetChangedColor(Me.REQ_TAXI_FROM_3, pOldTBL_KOTSUHOTEL.REQ_TAXI_FROM_3, Me.REQ_TAXI_FROM_3.Text)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_3, pOldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_3, Me.TAXI_YOTEIKINGAKU_3.Text)
            SetChangedColor(Me.REQ_TAXI_DATE_4, pOldTBL_KOTSUHOTEL.REQ_TAXI_DATE_4, Me.REQ_TAXI_DATE_4.Text)
            SetChangedColor(Me.REQ_TAXI_FROM_4, pOldTBL_KOTSUHOTEL.REQ_TAXI_FROM_4, Me.REQ_TAXI_FROM_4.Text)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_4, pOldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_4, Me.TAXI_YOTEIKINGAKU_4.Text)
            SetChangedColor(Me.REQ_TAXI_DATE_5, pOldTBL_KOTSUHOTEL.REQ_TAXI_DATE_5, Me.REQ_TAXI_DATE_5.Text)
            SetChangedColor(Me.REQ_TAXI_FROM_5, pOldTBL_KOTSUHOTEL.REQ_TAXI_FROM_5, Me.REQ_TAXI_FROM_5.Text)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_5, pOldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_5, Me.TAXI_YOTEIKINGAKU_5.Text)
            SetChangedColor(Me.REQ_TAXI_DATE_6, pOldTBL_KOTSUHOTEL.REQ_TAXI_DATE_6, Me.REQ_TAXI_DATE_6.Text)
            SetChangedColor(Me.REQ_TAXI_FROM_6, pOldTBL_KOTSUHOTEL.REQ_TAXI_FROM_6, Me.REQ_TAXI_FROM_6.Text)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_6, pOldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_6, Me.TAXI_YOTEIKINGAKU_6.Text)
            SetChangedColor(Me.REQ_TAXI_DATE_7, pOldTBL_KOTSUHOTEL.REQ_TAXI_DATE_7, Me.REQ_TAXI_DATE_7.Text)
            SetChangedColor(Me.REQ_TAXI_FROM_7, pOldTBL_KOTSUHOTEL.REQ_TAXI_FROM_7, Me.REQ_TAXI_FROM_7.Text)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_7, pOldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_7, Me.TAXI_YOTEIKINGAKU_7.Text)
            SetChangedColor(Me.REQ_TAXI_DATE_8, pOldTBL_KOTSUHOTEL.REQ_TAXI_DATE_8, Me.REQ_TAXI_DATE_8.Text)
            SetChangedColor(Me.REQ_TAXI_FROM_8, pOldTBL_KOTSUHOTEL.REQ_TAXI_FROM_8, Me.REQ_TAXI_FROM_8.Text)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_8, pOldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_8, Me.TAXI_YOTEIKINGAKU_8.Text)
            SetChangedColor(Me.REQ_TAXI_DATE_9, pOldTBL_KOTSUHOTEL.REQ_TAXI_DATE_9, Me.REQ_TAXI_DATE_9.Text)
            SetChangedColor(Me.REQ_TAXI_FROM_9, pOldTBL_KOTSUHOTEL.REQ_TAXI_FROM_9, Me.REQ_TAXI_FROM_9.Text)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_9, pOldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_9, Me.TAXI_YOTEIKINGAKU_9.Text)
            SetChangedColor(Me.REQ_TAXI_DATE_10, pOldTBL_KOTSUHOTEL.REQ_TAXI_DATE_10, Me.REQ_TAXI_DATE_10.Text)
            SetChangedColor(Me.REQ_TAXI_FROM_10, pOldTBL_KOTSUHOTEL.REQ_TAXI_FROM_10, Me.REQ_TAXI_FROM_10.Text)
            SetChangedColor(Me.TAXI_YOTEIKINGAKU_10, pOldTBL_KOTSUHOTEL.TAXI_YOTEIKINGAKU_10, Me.TAXI_YOTEIKINGAKU_10.Text)
            SetChangedColor(Me.REQ_O_TEHAI_1, pOldTBL_KOTSUHOTEL.REQ_O_TEHAI_1, Me.REQ_O_TEHAI_1.Text)
            SetChangedColor(Me.REQ_O_IRAINAIYOU_1, pOldTBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_1, Me.REQ_O_IRAINAIYOU_1.Text)
            SetChangedColor(Me.REQ_O_DATE_1, pOldTBL_KOTSUHOTEL.REQ_O_DATE_1, Me.REQ_O_DATE_1.Text)
            SetChangedColor(Me.REQ_O_KOTSUKIKAN_1, pOldTBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_1, Me.REQ_O_KOTSUKIKAN_1.Text)
            SetChangedColor(Me.REQ_O_BIN_1, pOldTBL_KOTSUHOTEL.REQ_O_BIN_1, Me.REQ_O_BIN_1.Text)
            SetChangedColor(Me.REQ_O_AIRPORT1_1, pOldTBL_KOTSUHOTEL.REQ_O_AIRPORT1_1, Me.REQ_O_AIRPORT1_1.Text)
            SetChangedColor(Me.REQ_O_AIRPORT2_1, pOldTBL_KOTSUHOTEL.REQ_O_AIRPORT2_1, Me.REQ_O_AIRPORT2_1.Text)
            SetChangedColor(Me.REQ_O_TIME1_1, pOldTBL_KOTSUHOTEL.REQ_O_TIME1_1, Me.REQ_O_TIME1_1.Text)
            SetChangedColor(Me.REQ_O_TIME2_1, pOldTBL_KOTSUHOTEL.REQ_O_TIME2_1, Me.REQ_O_TIME2_1.Text)
            SetChangedColor(Me.REQ_O_SEAT_1, pOldTBL_KOTSUHOTEL.REQ_O_SEAT_1, Me.REQ_O_SEAT_1.Text)
            SetChangedColor(Me.REQ_O_SEAT_KIBOU1, pOldTBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU1, Me.REQ_O_SEAT_KIBOU1.Text)
            SetChangedColor(Me.REQ_O_TEHAI_2, pOldTBL_KOTSUHOTEL.REQ_O_TEHAI_2, Me.REQ_O_TEHAI_2.Text)
            SetChangedColor(Me.REQ_O_IRAINAIYOU_2, pOldTBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_2, Me.REQ_O_IRAINAIYOU_2.Text)
            SetChangedColor(Me.REQ_O_DATE_2, pOldTBL_KOTSUHOTEL.REQ_O_DATE_2, Me.REQ_O_DATE_2.Text)
            SetChangedColor(Me.REQ_O_KOTSUKIKAN_2, pOldTBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_2, Me.REQ_O_KOTSUKIKAN_2.Text)
            SetChangedColor(Me.REQ_O_BIN_2, pOldTBL_KOTSUHOTEL.REQ_O_BIN_2, Me.REQ_O_BIN_2.Text)
            SetChangedColor(Me.REQ_O_AIRPORT1_2, pOldTBL_KOTSUHOTEL.REQ_O_AIRPORT1_2, Me.REQ_O_AIRPORT1_2.Text)
            SetChangedColor(Me.REQ_O_AIRPORT2_2, pOldTBL_KOTSUHOTEL.REQ_O_AIRPORT2_2, Me.REQ_O_AIRPORT2_2.Text)
            SetChangedColor(Me.REQ_O_TIME1_2, pOldTBL_KOTSUHOTEL.REQ_O_TIME1_2, Me.REQ_O_TIME1_2.Text)
            SetChangedColor(Me.REQ_O_TIME2_2, pOldTBL_KOTSUHOTEL.REQ_O_TIME2_2, Me.REQ_O_TIME2_2.Text)
            SetChangedColor(Me.REQ_O_SEAT_2, pOldTBL_KOTSUHOTEL.REQ_O_SEAT_2, Me.REQ_O_SEAT_2.Text)
            SetChangedColor(Me.REQ_O_SEAT_KIBOU2, pOldTBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU2, Me.REQ_O_SEAT_KIBOU2.Text)
            SetChangedColor(Me.REQ_O_TEHAI_3, pOldTBL_KOTSUHOTEL.REQ_O_TEHAI_3, Me.REQ_O_TEHAI_3.Text)
            SetChangedColor(Me.REQ_O_IRAINAIYOU_3, pOldTBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_3, Me.REQ_O_IRAINAIYOU_3.Text)
            SetChangedColor(Me.REQ_O_DATE_3, pOldTBL_KOTSUHOTEL.REQ_O_DATE_3, Me.REQ_O_DATE_3.Text)
            SetChangedColor(Me.REQ_O_KOTSUKIKAN_3, pOldTBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_3, Me.REQ_O_KOTSUKIKAN_3.Text)
            SetChangedColor(Me.REQ_O_BIN_3, pOldTBL_KOTSUHOTEL.REQ_O_BIN_3, Me.REQ_O_BIN_3.Text)
            SetChangedColor(Me.REQ_O_AIRPORT1_3, pOldTBL_KOTSUHOTEL.REQ_O_AIRPORT1_3, Me.REQ_O_AIRPORT1_3.Text)
            SetChangedColor(Me.REQ_O_AIRPORT2_3, pOldTBL_KOTSUHOTEL.REQ_O_AIRPORT2_3, Me.REQ_O_AIRPORT2_3.Text)
            SetChangedColor(Me.REQ_O_TIME1_3, pOldTBL_KOTSUHOTEL.REQ_O_TIME1_3, Me.REQ_O_TIME1_3.Text)
            SetChangedColor(Me.REQ_O_TIME2_3, pOldTBL_KOTSUHOTEL.REQ_O_TIME2_3, Me.REQ_O_TIME2_3.Text)
            SetChangedColor(Me.REQ_O_SEAT_3, pOldTBL_KOTSUHOTEL.REQ_O_SEAT_3, Me.REQ_O_SEAT_3.Text)
            SetChangedColor(Me.REQ_O_SEAT_KIBOU3, pOldTBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU3, Me.REQ_O_SEAT_KIBOU3.Text)
            SetChangedColor(Me.REQ_O_TEHAI_4, pOldTBL_KOTSUHOTEL.REQ_O_TEHAI_4, Me.REQ_O_TEHAI_4.Text)
            SetChangedColor(Me.REQ_O_IRAINAIYOU_4, pOldTBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_4, Me.REQ_O_IRAINAIYOU_4.Text)
            SetChangedColor(Me.REQ_O_DATE_4, pOldTBL_KOTSUHOTEL.REQ_O_DATE_4, Me.REQ_O_DATE_4.Text)
            SetChangedColor(Me.REQ_O_KOTSUKIKAN_4, pOldTBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_4, Me.REQ_O_KOTSUKIKAN_4.Text)
            SetChangedColor(Me.REQ_O_BIN_4, pOldTBL_KOTSUHOTEL.REQ_O_BIN_4, Me.REQ_O_BIN_4.Text)
            SetChangedColor(Me.REQ_O_AIRPORT1_4, pOldTBL_KOTSUHOTEL.REQ_O_AIRPORT1_4, Me.REQ_O_AIRPORT1_4.Text)
            SetChangedColor(Me.REQ_O_AIRPORT2_4, pOldTBL_KOTSUHOTEL.REQ_O_AIRPORT2_4, Me.REQ_O_AIRPORT2_4.Text)
            SetChangedColor(Me.REQ_O_TIME1_4, pOldTBL_KOTSUHOTEL.REQ_O_TIME1_4, Me.REQ_O_TIME1_4.Text)
            SetChangedColor(Me.REQ_O_TIME2_4, pOldTBL_KOTSUHOTEL.REQ_O_TIME2_4, Me.REQ_O_TIME2_4.Text)
            SetChangedColor(Me.REQ_O_SEAT_4, pOldTBL_KOTSUHOTEL.REQ_O_SEAT_4, Me.REQ_O_SEAT_4.Text)
            SetChangedColor(Me.REQ_O_SEAT_KIBOU4, pOldTBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU4, Me.REQ_O_SEAT_KIBOU4.Text)
            SetChangedColor(Me.REQ_O_TEHAI_5, pOldTBL_KOTSUHOTEL.REQ_O_TEHAI_5, Me.REQ_O_TEHAI_5.Text)
            SetChangedColor(Me.REQ_O_IRAINAIYOU_5, pOldTBL_KOTSUHOTEL.REQ_O_IRAINAIYOU_5, Me.REQ_O_IRAINAIYOU_5.Text)
            SetChangedColor(Me.REQ_O_DATE_5, pOldTBL_KOTSUHOTEL.REQ_O_DATE_5, Me.REQ_O_DATE_5.Text)
            SetChangedColor(Me.REQ_O_KOTSUKIKAN_5, pOldTBL_KOTSUHOTEL.REQ_O_KOTSUKIKAN_5, Me.REQ_O_KOTSUKIKAN_5.Text)
            SetChangedColor(Me.REQ_O_BIN_5, pOldTBL_KOTSUHOTEL.REQ_O_BIN_5, Me.REQ_O_BIN_5.Text)
            SetChangedColor(Me.REQ_O_AIRPORT1_5, pOldTBL_KOTSUHOTEL.REQ_O_AIRPORT1_5, Me.REQ_O_AIRPORT1_5.Text)
            SetChangedColor(Me.REQ_O_AIRPORT2_5, pOldTBL_KOTSUHOTEL.REQ_O_AIRPORT2_5, Me.REQ_O_AIRPORT2_5.Text)
            SetChangedColor(Me.REQ_O_TIME1_5, pOldTBL_KOTSUHOTEL.REQ_O_TIME1_5, Me.REQ_O_TIME1_5.Text)
            SetChangedColor(Me.REQ_O_TIME2_5, pOldTBL_KOTSUHOTEL.REQ_O_TIME2_5, Me.REQ_O_TIME2_5.Text)
            SetChangedColor(Me.REQ_O_SEAT_5, pOldTBL_KOTSUHOTEL.REQ_O_SEAT_5, Me.REQ_O_SEAT_5.Text)
            SetChangedColor(Me.REQ_O_SEAT_KIBOU5, pOldTBL_KOTSUHOTEL.REQ_O_SEAT_KIBOU5, Me.REQ_O_SEAT_KIBOU5.Text)
            SetChangedColor(Me.REQ_F_TEHAI_1, pOldTBL_KOTSUHOTEL.REQ_F_TEHAI_1, Me.REQ_F_TEHAI_1.Text)
            SetChangedColor(Me.REQ_F_IRAINAIYOU_1, pOldTBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_1, Me.REQ_F_IRAINAIYOU_1.Text)
            SetChangedColor(Me.REQ_F_DATE_1, pOldTBL_KOTSUHOTEL.REQ_F_DATE_1, Me.REQ_F_DATE_1.Text)
            SetChangedColor(Me.REQ_F_KOTSUKIKAN_1, pOldTBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_1, Me.REQ_F_KOTSUKIKAN_1.Text)
            SetChangedColor(Me.REQ_F_BIN_1, pOldTBL_KOTSUHOTEL.REQ_F_BIN_1, Me.REQ_F_BIN_1.Text)
            SetChangedColor(Me.REQ_F_AIRPORT1_1, pOldTBL_KOTSUHOTEL.REQ_F_AIRPORT1_1, Me.REQ_F_AIRPORT1_1.Text)
            SetChangedColor(Me.REQ_F_AIRPORT2_1, pOldTBL_KOTSUHOTEL.REQ_F_AIRPORT2_1, Me.REQ_F_AIRPORT2_1.Text)
            SetChangedColor(Me.REQ_F_TIME1_1, pOldTBL_KOTSUHOTEL.REQ_F_TIME1_1, Me.REQ_F_TIME1_1.Text)
            SetChangedColor(Me.REQ_F_TIME2_1, pOldTBL_KOTSUHOTEL.REQ_F_TIME2_1, Me.REQ_F_TIME2_1.Text)
            SetChangedColor(Me.REQ_F_SEAT_1, pOldTBL_KOTSUHOTEL.REQ_F_SEAT_1, Me.REQ_F_SEAT_1.Text)
            SetChangedColor(Me.REQ_F_SEAT_KIBOU1, pOldTBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU1, Me.REQ_F_SEAT_KIBOU1.Text)
            SetChangedColor(Me.REQ_F_TEHAI_2, pOldTBL_KOTSUHOTEL.REQ_F_TEHAI_2, Me.REQ_F_TEHAI_2.Text)
            SetChangedColor(Me.REQ_F_IRAINAIYOU_2, pOldTBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_2, Me.REQ_F_IRAINAIYOU_2.Text)
            SetChangedColor(Me.REQ_F_DATE_2, pOldTBL_KOTSUHOTEL.REQ_F_DATE_2, Me.REQ_F_DATE_2.Text)
            SetChangedColor(Me.REQ_F_KOTSUKIKAN_2, pOldTBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_2, Me.REQ_F_KOTSUKIKAN_2.Text)
            SetChangedColor(Me.REQ_F_BIN_2, pOldTBL_KOTSUHOTEL.REQ_F_BIN_2, Me.REQ_F_BIN_2.Text)
            SetChangedColor(Me.REQ_F_AIRPORT1_2, pOldTBL_KOTSUHOTEL.REQ_F_AIRPORT1_2, Me.REQ_F_AIRPORT1_2.Text)
            SetChangedColor(Me.REQ_F_AIRPORT2_2, pOldTBL_KOTSUHOTEL.REQ_F_AIRPORT2_2, Me.REQ_F_AIRPORT2_2.Text)
            SetChangedColor(Me.REQ_F_TIME1_2, pOldTBL_KOTSUHOTEL.REQ_F_TIME1_2, Me.REQ_F_TIME1_2.Text)
            SetChangedColor(Me.REQ_F_TIME2_2, pOldTBL_KOTSUHOTEL.REQ_F_TIME2_2, Me.REQ_F_TIME2_2.Text)
            SetChangedColor(Me.REQ_F_SEAT_2, pOldTBL_KOTSUHOTEL.REQ_F_SEAT_2, Me.REQ_F_SEAT_2.Text)
            SetChangedColor(Me.REQ_F_SEAT_KIBOU2, pOldTBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU2, Me.REQ_F_SEAT_KIBOU2.Text)
            SetChangedColor(Me.REQ_F_TEHAI_3, pOldTBL_KOTSUHOTEL.REQ_F_TEHAI_3, Me.REQ_F_TEHAI_3.Text)
            SetChangedColor(Me.REQ_F_IRAINAIYOU_3, pOldTBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_3, Me.REQ_F_IRAINAIYOU_3.Text)
            SetChangedColor(Me.REQ_F_DATE_3, pOldTBL_KOTSUHOTEL.REQ_F_DATE_3, Me.REQ_F_DATE_3.Text)
            SetChangedColor(Me.REQ_F_KOTSUKIKAN_3, pOldTBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_3, Me.REQ_F_KOTSUKIKAN_3.Text)
            SetChangedColor(Me.REQ_F_BIN_3, pOldTBL_KOTSUHOTEL.REQ_F_BIN_3, Me.REQ_F_BIN_3.Text)
            SetChangedColor(Me.REQ_F_AIRPORT1_3, pOldTBL_KOTSUHOTEL.REQ_F_AIRPORT1_3, Me.REQ_F_AIRPORT1_3.Text)
            SetChangedColor(Me.REQ_F_AIRPORT2_3, pOldTBL_KOTSUHOTEL.REQ_F_AIRPORT2_3, Me.REQ_F_AIRPORT2_3.Text)
            SetChangedColor(Me.REQ_F_TIME1_3, pOldTBL_KOTSUHOTEL.REQ_F_TIME1_3, Me.REQ_F_TIME1_3.Text)
            SetChangedColor(Me.REQ_F_TIME2_3, pOldTBL_KOTSUHOTEL.REQ_F_TIME2_3, Me.REQ_F_TIME2_3.Text)
            SetChangedColor(Me.REQ_F_SEAT_3, pOldTBL_KOTSUHOTEL.REQ_F_SEAT_3, Me.REQ_F_SEAT_3.Text)
            SetChangedColor(Me.REQ_F_SEAT_KIBOU3, pOldTBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU3, Me.REQ_F_SEAT_KIBOU3.Text)
            SetChangedColor(Me.REQ_F_TEHAI_4, pOldTBL_KOTSUHOTEL.REQ_F_TEHAI_4, Me.REQ_F_TEHAI_4.Text)
            SetChangedColor(Me.REQ_F_IRAINAIYOU_4, pOldTBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_4, Me.REQ_F_IRAINAIYOU_4.Text)
            SetChangedColor(Me.REQ_F_DATE_4, pOldTBL_KOTSUHOTEL.REQ_F_DATE_4, Me.REQ_F_DATE_4.Text)
            SetChangedColor(Me.REQ_F_KOTSUKIKAN_4, pOldTBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_4, Me.REQ_F_KOTSUKIKAN_4.Text)
            SetChangedColor(Me.REQ_F_BIN_4, pOldTBL_KOTSUHOTEL.REQ_F_BIN_4, Me.REQ_F_BIN_4.Text)
            SetChangedColor(Me.REQ_F_AIRPORT1_4, pOldTBL_KOTSUHOTEL.REQ_F_AIRPORT1_4, Me.REQ_F_AIRPORT1_4.Text)
            SetChangedColor(Me.REQ_F_AIRPORT2_4, pOldTBL_KOTSUHOTEL.REQ_F_AIRPORT2_4, Me.REQ_F_AIRPORT2_4.Text)
            SetChangedColor(Me.REQ_F_TIME1_4, pOldTBL_KOTSUHOTEL.REQ_F_TIME1_4, Me.REQ_F_TIME1_4.Text)
            SetChangedColor(Me.REQ_F_TIME2_4, pOldTBL_KOTSUHOTEL.REQ_F_TIME2_4, Me.REQ_F_TIME2_4.Text)
            SetChangedColor(Me.REQ_F_SEAT_4, pOldTBL_KOTSUHOTEL.REQ_F_SEAT_4, Me.REQ_F_SEAT_4.Text)
            SetChangedColor(Me.REQ_F_SEAT_KIBOU4, pOldTBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU4, Me.REQ_F_SEAT_KIBOU4.Text)
            SetChangedColor(Me.REQ_F_TEHAI_5, pOldTBL_KOTSUHOTEL.REQ_F_TEHAI_5, Me.REQ_F_TEHAI_5.Text)
            SetChangedColor(Me.REQ_F_IRAINAIYOU_5, pOldTBL_KOTSUHOTEL.REQ_F_IRAINAIYOU_5, Me.REQ_F_IRAINAIYOU_5.Text)
            SetChangedColor(Me.REQ_F_DATE_5, pOldTBL_KOTSUHOTEL.REQ_F_DATE_5, Me.REQ_F_DATE_5.Text)
            SetChangedColor(Me.REQ_F_KOTSUKIKAN_5, pOldTBL_KOTSUHOTEL.REQ_F_KOTSUKIKAN_5, Me.REQ_F_KOTSUKIKAN_5.Text)
            SetChangedColor(Me.REQ_F_BIN_5, pOldTBL_KOTSUHOTEL.REQ_F_BIN_5, Me.REQ_F_BIN_5.Text)
            SetChangedColor(Me.REQ_F_AIRPORT1_5, pOldTBL_KOTSUHOTEL.REQ_F_AIRPORT1_5, Me.REQ_F_AIRPORT1_5.Text)
            SetChangedColor(Me.REQ_F_AIRPORT2_5, pOldTBL_KOTSUHOTEL.REQ_F_AIRPORT2_5, Me.REQ_F_AIRPORT2_5.Text)
            SetChangedColor(Me.REQ_F_TIME1_5, pOldTBL_KOTSUHOTEL.REQ_F_TIME1_5, Me.REQ_F_TIME1_5.Text)
            SetChangedColor(Me.REQ_F_TIME2_5, pOldTBL_KOTSUHOTEL.REQ_F_TIME2_5, Me.REQ_F_TIME2_5.Text)
            SetChangedColor(Me.REQ_F_SEAT_5, pOldTBL_KOTSUHOTEL.REQ_F_SEAT_5, Me.REQ_F_SEAT_5.Text)
            SetChangedColor(Me.REQ_F_SEAT_KIBOU5, pOldTBL_KOTSUHOTEL.REQ_F_SEAT_KIBOU5, Me.REQ_F_SEAT_KIBOU5.Text)
            SetChangedColor(Me.REQ_KOTSU_BIKO, pOldTBL_KOTSUHOTEL.REQ_KOTSU_BIKO, Me.REQ_KOTSU_BIKO.Text)        End If        '項目の編集
        ANS_TICKET_SEND_DAY.Text = AppModule.GetName_ANS_TICKET_SEND_DAY(Me.ANS_TICKET_SEND_DAY.Text, False)
        ANS_TICKET_SEND_DAY2.Text = AppModule.GetName_ANS_TICKET_SEND_DAY(Me.ANS_TICKET_SEND_DAY2.Text, False)
        PRINT_DATE.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
        FROM_DATE1.Text = AppModule.GetName_KOUENKAI_DATE(FROM_DATE.Text, TO_DATE.Text)
        FROM_DATE2.Text = AppModule.GetName_KOUENKAI_DATE(FROM_DATE.Text, TO_DATE.Text)
        REQ_STATUS_TEHAI1.Text = AppModule.GetName_STATUS_TEHAI(REQ_STATUS_TEHAI1.Text, False, True)
        REQ_STATUS_TEHAI2.Text = AppModule.GetName_STATUS_TEHAI(REQ_STATUS_TEHAI2.Text, False, True)
        TIME_STAMP_BYL1.Text = CmnModule.Format_Date(TIME_STAMP_BYL.Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        TIME_STAMP_BYL2.Text = CmnModule.Format_Date(TIME_STAMP_BYL.Text, CmnModule.DateFormatType.YYYYMMDDHHMMSS)
        If DR_NAME1.Text.Length > 19 Then DR_NAME1.Text = Left(DR_NAME1.Text, 19)
        If DR_NAME2.Text.Length > 19 Then DR_NAME2.Text = Left(DR_NAME2.Text, 19)
        If DR_KANA.Text.Length > 25 Then DR_KANA.Text = Left(DR_KANA.Text, 25)
        If DR_KANA2.Text.Length > 25 Then DR_KANA2.Text = Left(DR_KANA2.Text, 25)
        If DR_SHISETSU_NAME.Text.Length > 25 Then DR_SHISETSU_NAME.Text = Left(DR_SHISETSU_NAME.Text, 25)
        If DR_SHISETSU_NAME2.Text.Length > 25 Then DR_SHISETSU_NAME2.Text = Left(DR_SHISETSU_NAME2.Text, 25)
        If DR_SHISETSU_ADDRESS.Text.Length > 18 Then DR_SHISETSU_ADDRESS.Text = Left(DR_SHISETSU_ADDRESS.Text, 18)
        If DR_SHISETSU_ADDRESS2.Text.Length > 18 Then DR_SHISETSU_ADDRESS2.Text = Left(DR_SHISETSU_ADDRESS2.Text, 18)
        DR_SEX.Text = AppModule.GetName_DR_SEX(DR_SEX.Text)
        DR_SEX2.Text = AppModule.GetName_DR_SEX(DR_SEX2.Text)
        DR_YAKUWARI.Text = AppModule.GetName_DR_YAKUWARI(DR_YAKUWARI.Text)
        If SHONIN_NAME.Text.Length > 19 Then SHONIN_NAME.Text = Left(SHONIN_NAME.Text, 19)
        SHONIN_DATE.Text = CmnModule.Format_Date(SHONIN_DATE.Text, CmnModule.DateFormatType.YYYYMD)
        If MR_NAME.Text.Length > 15 Then MR_NAME.Text = Left(MR_NAME.Text, 15)
        If MR_BU.Text.Length > 5 Then MR_BU.Text = Left(MR_BU.Text, 5)
        If MR_AREA.Text.Length > 25 Then MR_AREA.Text = Left(MR_AREA.Text, 25)
        If MR_EIGYOSHO.Text.Length > 25 Then MR_EIGYOSHO.Text = Left(MR_EIGYOSHO.Text, 25)
        If MR_ROMA.Text.Length > 17 Then MR_ROMA.Text = Left(MR_ROMA.Text, 17)
        If MR_KANA.Text.Length > 15 Then MR_KANA.Text = Left(MR_KANA.Text, 15)
        MR_AGE.Text = AppModule.GetName_MR_AGE(MR_AGE.Text)
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

        ANS_AIR_FARE.Text = CmnModule.EditComma(Me.ANS_AIR_FARE.Text) & " 円"
        ANS_AIR_CANCELLATION.Text = CmnModule.EditComma(Me.ANS_AIR_CANCELLATION.Text) & " 円"
        ANS_RAIL_FARE.Text = CmnModule.EditComma(Me.ANS_RAIL_FARE.Text) & " 円"
        ANS_RAIL_CANCELLATION.Text = CmnModule.EditComma(Me.ANS_RAIL_CANCELLATION.Text) & " 円"
        ANS_OTHER_FARE.Text = CmnModule.EditComma(Me.ANS_OTHER_FARE.Text) & " 円"
        ANS_OTHER_CANCELLATION.Text = CmnModule.EditComma(Me.ANS_OTHER_CANCELLATION.Text) & " 円"
        ANS_MR_HOTELHI.Text = CmnModule.EditComma(Me.ANS_MR_HOTELHI.Text) & " 円"
        ANS_MR_HOTELHI_TOZEI.Text = CmnModule.EditComma(Me.ANS_MR_HOTELHI_TOZEI.Text) & " 円"
        ANS_MR_KOTSUHI.Text = CmnModule.EditComma(Me.ANS_MR_KOTSUHI.Text) & " 円"
        If REQ_KOTSU_BIKO.Text.Length > 346 Then REQ_KOTSU_BIKO.Text = Left(REQ_KOTSU_BIKO.Text, 346)

    End Sub

    '差異
    Private Sub SetChangedColor(ByRef control As TextBox, ByVal Data1 As String, ByVal Data2 As String)
        With control
            If CmnModule.IsChanged(Data1, Data2) Then
                .BackColor = Drawing.Color.FromArgb(220, 220, 220)
            Else
                .BackColor = Drawing.Color.White
            End If
        End With
    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        PRINT_DATE.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
    End Sub

    Private Sub DrReport_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart

    End Sub

    Private Sub PageHeader_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        If Me.KINKYU_FLAG.Text = AppConst.KOTSUHOTEL.KINKYU_FLAG.Code.Yes Then
            Me.LBL_KINKYU.Visible = True
            Me.SHP_KINKYU.Visible = True
        Else
            Me.LBL_KINKYU.Visible = False
            Me.SHP_KINKYU.Visible = False
        End If
    End Sub
End Class
