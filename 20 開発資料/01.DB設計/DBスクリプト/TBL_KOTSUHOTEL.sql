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
	[SALEFORCE_ID] [nvarchar](18) COLLATE Japanese_CI_AS  NOT NULL,
	[SANKASHA_ID] [nvarchar](14) COLLATE Japanese_CI_AS  NOT NULL,
	[KOUENKAI_NO] [nvarchar](14) COLLATE Japanese_CI_AS  NOT NULL,
	[REQ_STATUS_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_STATUS_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[TIME_STAMP_BYL] [nvarchar](14) COLLATE Japanese_CI_AS  NOT NULL,
	[TIME_STAMP_TOP] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[DR_MPID] [nvarchar](16) COLLATE Japanese_CI_AS  NOT NULL,
	[DR_CD] [nvarchar](16) COLLATE Japanese_CI_AS  NULL,
	[DR_NAME] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[DR_KANA] [nvarchar](80) COLLATE Japanese_CI_AS  NULL,
	[DR_SHISETSU_CD] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[DR_SHISETSU_NAME] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[DR_SHISETSU_ADDRESS] [nvarchar](256) COLLATE Japanese_CI_AS  NULL,
	[DR_YAKUWARI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[DR_SEX] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[DR_AGE] [nvarchar](3) COLLATE Japanese_CI_AS  NULL,
	[SHITEIGAI_RIYU] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[DR_SANKA] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[MR_BU] [nvarchar](40) COLLATE Japanese_CI_AS  NULL,
	[MR_AREA] [nvarchar](80) COLLATE Japanese_CI_AS  NULL,
	[MR_EIGYOSHO] [nvarchar](80) COLLATE Japanese_CI_AS  NULL,
	[MR_NAME] [nvarchar](300) COLLATE Japanese_CI_AS  NULL,
	[MR_ROMA] [nvarchar](300) COLLATE Japanese_CI_AS  NULL,
	[MR_KANA] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[MR_EMAIL_PC] [nvarchar](128) COLLATE Japanese_CI_AS  NULL,
	[MR_EMAIL_KEITAI] [nvarchar](128) COLLATE Japanese_CI_AS  NULL,
	[MR_KEITAI] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[MR_TEL] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[MR_SEND_SAKI_FS] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[MR_SEND_SAKI_OTHER] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[ACCOUNT_CD] [nvarchar](7) COLLATE Japanese_CI_AS  NULL,
	[COST_CENTER] [nvarchar](12) COLLATE Japanese_CI_AS  NULL,
	[INTERNAL_ORDER] [nvarchar](12) COLLATE Japanese_CI_AS  NULL,
	[ZETIA_CD] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[SHONIN_NAME] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[SHONIN_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[TEHAI_HOTEL] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[HOTEL_IRAINAIYOU] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[REQ_HOTEL_DATE] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_HAKUSU] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_HOTEL_SMOKING] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_HOTEL_NOTE] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[ANS_STATUS_HOTEL] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_HOTEL_NAME] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_HOTEL_ADDRESS] [nvarchar](256) COLLATE Japanese_CI_AS  NULL,
	[ANS_HOTEL_TEL] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[ANS_HOTEL_DATE] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_HAKUSU] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_CHECKIN_TIME] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_CHECKOUT_TIME] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_ROOM_TYPE] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_HOTEL_SMOKING] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_HOTEL_NOTE] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[ANS_HOTELHI] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_HOTELHI_TOZEI] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_HOTELHI_CANCEL] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TEHAI_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_IRAINAIYOU_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_KOTSUKIKAN_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_DATE_1] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT1_1] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT2_1] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME1_1] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME2_1] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_BIN_1] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_SEAT_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_SEAT_KIBOU1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TEHAI_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_IRAINAIYOU_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_KOTSUKIKAN_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_DATE_2] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT1_2] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT2_2] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME1_2] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME2_2] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_BIN_2] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_SEAT_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_SEAT_KIBOU2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TEHAI_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_IRAINAIYOU_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_KOTSUKIKAN_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_DATE_3] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT1_3] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT2_3] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME1_3] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME2_3] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_BIN_3] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_SEAT_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_SEAT_KIBOU3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TEHAI_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_IRAINAIYOU_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_KOTSUKIKAN_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_DATE_4] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT1_4] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT2_4] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME1_4] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME2_4] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_BIN_4] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_SEAT_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_SEAT_KIBOU4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TEHAI_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_IRAINAIYOU_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_KOTSUKIKAN_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_DATE_5] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT1_5] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_AIRPORT2_5] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME1_5] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_TIME2_5] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_BIN_5] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_SEAT_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_O_SEAT_KIBOU5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TEHAI_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_IRAINAIYOU_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_KOTSUKIKAN_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_DATE_1] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT1_1] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT2_1] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME1_1] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME2_1] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_BIN_1] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_SEAT_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_SEAT_KIBOU1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TEHAI_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_IRAINAIYOU_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_KOTSUKIKAN_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_DATE_2] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT1_2] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT2_2] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME1_2] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME2_2] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_BIN_2] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_SEAT_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_SEAT_KIBOU2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TEHAI_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_IRAINAIYOU_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_KOTSUKIKAN_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_DATE_3] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT1_3] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT2_3] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME1_3] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME2_3] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_BIN_3] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_SEAT_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_SEAT_KIBOU3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TEHAI_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_IRAINAIYOU_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_KOTSUKIKAN_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_DATE_4] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT1_4] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT2_4] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME1_4] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME2_4] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_BIN_4] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_SEAT_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_SEAT_KIBOU4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TEHAI_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_IRAINAIYOU_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_KOTSUKIKAN_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_DATE_5] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT1_5] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_AIRPORT2_5] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME1_5] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_TIME2_5] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_BIN_5] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_SEAT_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_F_SEAT_KIBOU5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_KOTSU_BIKO] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_STATUS_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_KOTSUKIKAN_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_DATE_1] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT1_1] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT2_1] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME1_1] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME2_1] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_BIN_1] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_SEAT_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_SEAT_KIBOU1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_STATUS_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_KOTSUKIKAN_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_DATE_2] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT1_2] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT2_2] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME1_2] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME2_2] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_BIN_2] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_SEAT_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_SEAT_KIBOU2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_STATUS_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_KOTSUKIKAN_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_DATE_3] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT1_3] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT2_3] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME1_3] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME2_3] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_BIN_3] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_SEAT_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_SEAT_KIBOU3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_STATUS_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_KOTSUKIKAN_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_DATE_4] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT1_4] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT2_4] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME1_4] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME2_4] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_BIN_4] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_SEAT_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_SEAT_KIBOU4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_STATUS_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_KOTSUKIKAN_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_DATE_5] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT1_5] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_AIRPORT2_5] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME1_5] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_TIME2_5] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_BIN_5] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_SEAT_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_O_SEAT_KIBOU5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_STATUS_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_KOTSUKIKAN_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_DATE_1] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT1_1] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT2_1] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME1_1] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME2_1] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_BIN_1] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_SEAT_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_SEAT_KIBOU1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_STATUS_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_KOTSUKIKAN_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_DATE_2] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT1_2] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT2_2] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME1_2] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME2_2] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_BIN_2] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_SEAT_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_SEAT_KIBOU2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_STATUS_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_KOTSUKIKAN_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_DATE_3] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT1_3] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT2_3] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME1_3] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME2_3] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_BIN_3] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_SEAT_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_SEAT_KIBOU3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_STATUS_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_KOTSUKIKAN_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_DATE_4] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT1_4] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT2_4] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME1_4] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME2_4] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_BIN_4] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_SEAT_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_SEAT_KIBOU4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_STATUS_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_KOTSUKIKAN_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_DATE_5] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT1_5] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_AIRPORT2_5] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME1_5] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_TIME2_5] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_BIN_5] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_SEAT_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_F_SEAT_KIBOU5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_KOTSU_BIKO] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[ANS_RAIL_FARE] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_RAIL_CANCELLATION] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_OTHER_FARE] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_OTHER_CANCELLATION] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_AIR_FARE] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_AIR_CANCELLATION] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_KOTSUHOTEL_TESURYO] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_TESURYO] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TICKET_SEND_DAY] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[TEHAI_TAXI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_1] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_1] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_1] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_2] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_2] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_3] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_3] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_3] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_4] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_4] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_4] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_5] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_5] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_5] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_6] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_6] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_6] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_7] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_7] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_7] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_8] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_8] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_8] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_9] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_9] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_9] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_DATE_10] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_FROM_10] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[TAXI_YOTEIKINGAKU_10] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[REQ_TAXI_NOTE] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_1] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_1] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_1] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_1] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_1] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_1] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_2] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_2] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_2] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_2] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_3] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_3] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_3] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_3] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_3] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_3] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_4] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_4] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_4] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_4] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_4] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_4] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_5] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_5] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_5] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_5] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_5] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_5] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_6] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_6] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_6] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_6] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_6] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_6] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_7] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_7] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_7] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_7] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_7] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_7] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_8] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_8] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_8] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_8] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_8] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_8] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_9] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_9] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_9] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_9] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_9] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_9] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_10] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_10] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_10] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_10] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_10] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_10] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_11] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_11] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_11] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_11] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_11] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_11] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_12] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_12] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_12] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_12] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_12] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_12] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_13] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_13] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_13] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_13] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_13] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_13] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_14] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_14] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_14] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_14] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_14] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_14] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_15] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_15] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_15] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_15] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_15] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_15] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_16] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_16] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_16] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_16] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_16] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_16] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_17] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_17] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_17] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_17] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_17] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_17] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_18] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_18] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_18] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_18] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_18] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_18] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_19] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_19] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_19] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_19] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_19] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_19] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_DATE_20] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_KENSHU_20] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NO_20] [nvarchar](9) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_20] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_HAKKO_DATE_20] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_RMKS_20] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_TAXI_NOTE] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[REQ_MR_O_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[REQ_MR_F_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[MR_SEX] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[MR_AGE] [nvarchar](3) COLLATE Japanese_CI_AS  NULL,
	[REQ_MR_HOTEL_NOTE] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[ANS_MR_O_TEHAI] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[ANS_MR_F_TEHAI] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[ANS_MR_HOTEL_NOTE] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[ANS_MR_KOTSUHI] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_MR_HOTELHI] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_MR_HOTELHI_TOZEI] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[SEND_FLAG] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[TTANTO_ID] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[SEIKYU_NO_TOPTOUR] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[SCAN_IMPORT_DATE] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[KINKYU_FLAG] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[YOBI1] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[YOBI2] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[YOBI3] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[YOBI4] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[YOBI5] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[INPUT_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[INPUT_USER] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_USER] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[SEND_DATE] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[WBS_ELEMENT] [nvarchar](24) COLLATE Japanese_CI_AS  NULL,
 CONSTRAINT [PK_TBL_KOTSUHOTEL] PRIMARY KEY CLUSTERED 
(
	[SALEFORCE_ID] ASC,
	[SANKASHA_ID] ASC,
	[KOUENKAI_NO] ASC,
	[TIME_STAMP_BYL] ASC,
	[DR_MPID] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
