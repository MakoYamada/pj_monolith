USE [BAYER_DEMO]
GO
/****** オブジェクト:  Table [dbo].[TBL_KAIJO]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_KAIJO](
	[KOUENKAI_NO] [nvarchar](10) COLLATE Japanese_CI_AS  NOT NULL,
	[REQ_STATUS_TEHAI] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[ANS_STATUS_TEHAI] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[TIME_STAMP_BYL] [nvarchar](14) COLLATE Japanese_CI_AS  NOT NULL,
	[TIME_STAMP_TOP] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[ACCOUNT_CD] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[COST_CENTER] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[INTERNAL_ORDER] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ZETIA_CD] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[STATUS_SHONIN] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[SHONIN_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[SHONIN_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[JSHONIN_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[CMSHONIN_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[SHONIN_NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[YOTEI_DATE] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[KAISAI_DATE_NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[SANKA_YOTEI_CNT_DR] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[SANKA_YOTEI_CNT_OTHER] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KAISAI_KIBOU_ADDRESS1] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[KAISAI_KIBOU_ADDRESS2] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[KAISAI_KIBOU_NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[KOUEN_KAIJO_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[KOUEN_TIME1] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[KOUEN_TIME2] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[KOUEN_KAIJO_LAYOUT] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[IKENKOUKAN_KAIJO_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[IKENKOUKAN_TIME1] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[IKENKOUKAN_TIME2] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[IROUKAI_KAIJO_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[IROUKAI_SANKA_YOTEI_CNT] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KOUSHI_ROOM_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[KOUSHI_ROOM_TIME1] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[KOUSHI_ROOM_TIME2] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[KOUSHI_ROOM_CNT] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[SHAIN_ROOM_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[MANAGER_KAIJO_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[MANAGER_KAIJO_TIME1] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[MANAGER_KAIJO_TIME2] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[KAIJO_URL] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[OTHER_NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[KOUHOKAIJO_LIST_URL] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[MITSUMORI_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[MITSUMORI_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[MITSUMORI_T2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[MITSUMORI_TOTAL] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[MITSUMORI_URL] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[SHISETSU_NAME] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[SHISETSU_ADDRESS] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[SHISETSU_TEL] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[SHISETSU_URL] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[KOUEN_KAIJO_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[KOUEN_KAIJO_FLOOR] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[IKENKOUKAN_KAIJO_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[IROUKAI_KAIJO_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[KOUSHI_ROOM_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[SHAIN_ROOM_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[MANAGER_KAIJO_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[KAISAI_NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[SEISAN_TF] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[SEISAN_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[SEISAN_T2] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[SEISANSHO_URL] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[INPUT_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[INPUT_USER] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_USER] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	 CONSTRAINT [PK_TBL_KAIJO] PRIMARY KEY CLUSTERED 
(
	[KOUENKAI_NO] ASC,
	[TIME_STAMP_BYL] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF