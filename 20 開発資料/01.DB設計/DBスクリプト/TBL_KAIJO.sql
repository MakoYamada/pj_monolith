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
	[SALEFORCE_ID] [nvarchar](18) COLLATE Japanese_CI_AS  NOT NULL,
	[TEHAI_ID] [nvarchar](14) COLLATE Japanese_CI_AS  NOT NULL,
	[KOUENKAI_NO] [nvarchar](14) COLLATE Japanese_CI_AS  NOT NULL,
	[REQ_STATUS_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[ANS_STATUS_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[TIME_STAMP_BYL] [nvarchar](14) COLLATE Japanese_CI_AS  NOT NULL,
	[TIME_STAMP_TOP] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[SHONIN_NAME] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[SHONIN_DATE] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[KAISAI_DATE_NOTE] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[KAISAI_KIBOU_ADDRESS1] [nvarchar](40) COLLATE Japanese_CI_AS  NULL,
	[KAISAI_KIBOU_ADDRESS2] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[KAISAI_KIBOU_NOTE] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[KOUEN_TIME1] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[KOUEN_TIME2] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[KOUEN_KAIJO_LAYOUT] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[IKENKOUKAN_KAIJO_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[IROUKAI_KAIJO_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[IROUKAI_SANKA_YOTEI_CNT] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KOUSHI_ROOM_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[SHAIN_ROOM_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[MANAGER_KAIJO_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[KAIJO_URL] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[OTHER_NOTE] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[ANS_SENTEI_RIYU] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[ANS_MITSUMORI_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_MITSUMORI_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_MITSUMORI_TOTAL] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_MITSUMORI_URL] [nvarchar](255) COLLATE Japanese_CI_AS  NULL,
	[ANS_SHISETSU_NAME] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_SHISETSU_ZIP] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ANS_SHISETSU_ADDRESS] [nvarchar](256) COLLATE Japanese_CI_AS  NULL,
	[ANS_SHISETSU_TEL] [nvarchar](40) COLLATE Japanese_CI_AS  NULL,
	[ANS_SHISETSU_URL] [nvarchar](255) COLLATE Japanese_CI_AS  NULL,
	[ANS_KOUEN_KAIJO_NAME] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_KOUEN_KAIJO_FLOOR] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_IKENKOUKAN_KAIJO_NAME] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_IROUKAI_KAIJO_NAME] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_KOUSHI_ROOM_NAME] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_SHAIN_ROOM_NAME] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_MANAGER_KAIJO_NAME] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[ANS_KAISAI_NOTE] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[ANS_SEISAN_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_SEISAN_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ANS_SEISANSHO_URL] [nvarchar](255) COLLATE Japanese_CI_AS  NULL,
	[SEND_FLAG] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[INPUT_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[INPUT_USER] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_USER] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	 CONSTRAINT [PK_TBL_KAIJO] PRIMARY KEY CLUSTERED 
(
	[SALEFORCE_ID] ASC,
	[TEHAI_ID] ASC,
	[KOUENKAI_NO] ASC,
	[TIME_STAMP_BYL] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF