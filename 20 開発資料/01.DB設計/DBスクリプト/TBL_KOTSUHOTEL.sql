USE [BAYER_DEMO]
GO
/****** オブジェクト:  Table [dbo].[TBL_KOTSUHOTEL]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_KOTSUHOTEL](
	[KOUENKAI_NO] [nvarchar](10) COLLATE Japanese_CI_AS  NOT NULL,
	[STATUS_TEHAI] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[DR_MPID] [nvarchar](10) COLLATE Japanese_CI_AS  NOT NULL,
	[DR_CD] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[DR_EDABAN] [nvarchar](3) COLLATE Japanese_CI_AS  NULL,
	[DR_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[DR_KANA] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[DR_SEX] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[DR_SHISETSU_CD] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[DR_SHISETSU_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[DR_SHISETSU_ADDRESS] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[DR_YAKUWARI] [nvarchar](50) COLLATE Japanese_CI_AS  NULL,
	[DR_SANKA] [nvarchar](50) COLLATE Japanese_CI_AS  NULL,
	[MR_JIGYOBU] [nvarchar](50) COLLATE Japanese_CI_AS  NULL,
	[MR_AREA] [nvarchar](50) COLLATE Japanese_CI_AS  NULL,
	[MR_EIGYOSHO] [nvarchar](50) COLLATE Japanese_CI_AS  NULL,
	[MR_NO] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[MR_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[MR_KANA] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[MR_EMAIL] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[MR_KEITAI] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[MR_SEND_SAKI_FS] [nvarchar](50) COLLATE Japanese_CI_AS  NULL,
	[MR_SEND_SAKI_OTHER] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[ACCOUNT_CODE] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[COST_CENTER] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[INTERNAL_ORDER] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[SHONIN_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[SHONIN_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[CMSHONIN_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[CMSHONIN_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[CMSHONIN_NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[TEHAI_HOTEL] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[HOTEL_IRAINAIYOU] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_HOTEL_DATE] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_HAKUSU] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_HOTEL_SMOKING] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_HOTEL_NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[ANS_STATUS_HOTEL] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[ANS_HOTEL_NAME] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[ANS_HOTEL_ADDRESS] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[ANS_HOTEL_TEL] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[ANS_HOTEL_DATE] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_HAKUSU] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[ANS_CHECKIN_TIME] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_CHECKOUT_TIME] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_ROOM_TYPE] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[ANS_HOTEL_SMOKING] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_HOTEL_NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TEHAI_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_IRAINAIYOU_1] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_KOTSUKIKAN_1] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_DATE_1] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT1_1] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT2_1] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME1_1] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME2_1] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_BIN_1] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_SEAT_1] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AGE_1] [nvarchar](3) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_STATUS_1] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_KOTSUKIKAN_1] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_DATE_1] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT1_1] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT2_1] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME1_1] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME2_1] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_BIN_1] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_SEAT_1] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TEHAI_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_IRAINAIYOU_2] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_KOTSUKIKAN_2] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_DATE_2] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT1_2] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT2_2] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME1_2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME2_2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_BIN_2] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_SEAT_2] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AGE_2] [nvarchar](3) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_STATUS_2] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_KOTSUKIKAN_2] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_DATE_2] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT1_2] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT2_2] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME1_2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME2_2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_BIN_2] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_SEAT_2] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TEHAI_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_IRAINAIYOU_3] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_KOTSUKIKAN_3] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_DATE_3] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT1_3] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT2_3] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME1_3] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME2_3] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_BIN_3] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_SEAT_3] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AGE_3] [nvarchar](3) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_STATUS_3] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_KOTSUKIKAN_3] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_DATE_3] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT1_3] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT2_3] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME1_3] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME2_3] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_BIN_3] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_SEAT_3] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TEHAI_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_IRAINAIYOU_4] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_KOTSUKIKAN_4] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_DATE_4] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT1_4] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT2_4] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME1_4] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME2_4] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_BIN_4] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_SEAT_4] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AGE_4] [nvarchar](3) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_STATUS_4] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_KOTSUKIKAN_4] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_DATE_4] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT1_4] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT2_4] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME1_4] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME2_4] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_BIN_4] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_SEAT_4] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TEHAI_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_IRAINAIYOU_5] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_KOTSUKIKAN_5] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_DATE_5] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT1_5] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT2_5] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME1_5] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME2_5] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_BIN_5] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_SEAT_5] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AGE_5] [nvarchar](3) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_STATUS_5] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_KOTSUKIKAN_5] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_DATE_5] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT1_5] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT2_5] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME1_5] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME2_5] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_BIN_5] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_SEAT_5] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TEHAI_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_IRAINAIYOU_1] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_KOTSUKIKAN_1] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_DATE_1] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT1_1] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT2_1] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME1_1] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME2_1] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_BIN_1] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_SEAT_1] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AGE_1] [nvarchar](3) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_STATUS_1] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_KOTSUKIKAN_1] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_DATE_1] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT1_1] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT2_1] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME1_1] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME2_1] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_BIN_1] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_SEAT_1] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TEHAI_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_IRAINAIYOU_2] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_KOTSUKIKAN_2] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_DATE_2] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT1_2] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT2_2] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME1_2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME2_2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_BIN_2] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_SEAT_2] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AGE_2] [nvarchar](3) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_STATUS_2] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_KOTSUKIKAN_2] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_DATE_2] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT1_2] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT2_2] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME1_2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME2_2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_BIN_2] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_SEAT_2] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TEHAI_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_IRAINAIYOU_3] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_KOTSUKIKAN_3] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_DATE_3] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT1_3] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT2_3] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME1_3] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME2_3] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_BIN_3] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_SEAT_3] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AGE_3] [nvarchar](3) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_STATUS_3] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_KOTSUKIKAN_3] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_DATE_3] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT1_3] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT2_3] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME1_3] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME2_3] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_BIN_3] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_SEAT_3] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TEHAI_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_IRAINAIYOU_4] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_KOTSUKIKAN_4] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_DATE_4] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT1_4] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT2_4] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME1_4] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME2_4] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_BIN_4] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_SEAT_4] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AGE_4] [nvarchar](3) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_STATUS_4] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_KOTSUKIKAN_4] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_DATE_4] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT1_4] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT2_4] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME1_4] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME2_4] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_BIN_4] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_SEAT_4] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TEHAI_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_IRAINAIYOU_5] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_KOTSUKIKAN_5] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_DATE_5] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT1_5] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT2_5] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME1_5] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME2_5] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_BIN_5] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_SEAT_5] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AGE_5] [nvarchar](3) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_STATUS_5] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_KOTSUKIKAN_5] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_DATE_5] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT1_5] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT2_5] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME1_5] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME2_5] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_BIN_5] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_SEAT_5] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_NOTE_1] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_NOTE_1] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_NOTE_1] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_NOTE_1] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[FIX_RAIL_FARE] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[FIX_RAIL_CANCELLATION] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[FIX_AIR_FARE] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[FIX_AIR_CANCELLATION] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[FIX_OTHER_FARE] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[FIX_OTHER_CANCELLATION] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[TOUROKUKANRI_FEE] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[TAXI_HAKKEN_FEE] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[TAXI_SEISAN_FEE] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[TEHAI_TAXI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[TAXI_MOUSHIKOMI_SAKI] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_1] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_1] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_TO_1] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_1] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_1] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_FROM_1] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_TO_1] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_1] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_1] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KINGAKU_1] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_MEISAI_NO_1] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_VOID_1] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_PRINTDATE_1] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_SEIKYUDATE_1] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_2] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_2] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_TO_2] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_2] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_FROM_2] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_TO_2] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_2] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KINGAKU_2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_MEISAI_NO_2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_VOID_2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_PRINTDATE_2] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_SEIKYUDATE_2] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_3] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_3] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_TO_3] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_3] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_3] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_FROM_3] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_TO_3] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_3] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_3] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KINGAKU_3] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_MEISAI_NO_3] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_VOID_3] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_PRINTDATE_3] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_SEIKYUDATE_3] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_4] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_4] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_TO_4] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_4] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_4] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_FROM_4] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_TO_4] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_4] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_4] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KINGAKU_4] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_MEISAI_NO_4] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_VOID_4] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_PRINTDATE_4] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_SEIKYUDATE_4] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_5] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_5] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_TO_5] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_5] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_5] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_FROM_5] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_TO_5] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_5] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_5] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KINGAKU_5] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_MEISAI_NO_5] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_VOID_5] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_PRINTDATE_5] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_SEIKYUDATE_5] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_6] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_6] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_TO_6] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_6] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_6] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_FROM_6] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_TO_6] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_6] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_6] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KINGAKU_6] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_MEISAI_NO_6] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_VOID_6] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_PRINTDATE_6] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_SEIKYUDATE_6] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_7] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_7] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_TO_7] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_7] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_7] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_FROM_7] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_TO_7] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_7] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_7] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KINGAKU_7] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_MEISAI_NO_7] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_VOID_7] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_PRINTDATE_7] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_SEIKYUDATE_7] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_8] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_8] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_TO_8] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_8] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_8] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_FROM_8] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_TO_8] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_8] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_8] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KINGAKU_8] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_MEISAI_NO_8] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_VOID_8] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_PRINTDATE_8] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_SEIKYUDATE_8] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_9] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_9] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_TO_9] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_9] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_9] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_FROM_9] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_TO_9] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_9] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_9] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KINGAKU_9] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_MEISAI_NO_9] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_VOID_9] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_PRINTDATE_9] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_SEIKYUDATE_9] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_10] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_10] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_TO_10] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_10] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_10] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_FROM_10] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_TO_10] [nvarchar](60) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_10] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_10] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KINGAKU_10] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_MEISAI_NO_10] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_VOID_10] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_PRINTDATE_10] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_SEIKYUDATE_10] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[TAXI_NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[TEHAI_MR] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[MR_SEAT] [nvarchar](50) COLLATE Japanese_CI_AS  NULL,
	[MR_SEX] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[MR_AGE] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[INPUT_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[SEND_DATE] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
 CONSTRAINT [PK_TBL_KOTSUHOTEL] PRIMARY KEY CLUSTERED 
(
	[KOUENKAI_NO] ASC,
	[DR_MPID] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF