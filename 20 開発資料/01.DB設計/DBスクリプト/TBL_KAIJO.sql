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
	[KOUENKAI_ID] [nvarchar](10) COLLATE Japanese_CI_AS  NOT NULL,
	[TIME_STAMP] [nvarchar](14) COLLATE Japanese_CI_AS  NOT NULL,
	[AREA] [nvarchar](50) COLLATE Japanese_CI_AS  NULL,
	[ADDRESS] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[EIGYOSHO] [nvarchar](50) COLLATE Japanese_CI_AS  NULL,
	[ZIP] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[TANTO_NO] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[TANTO_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[TANTO_KANA] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[INTERNAL_ORDER_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ACCOUNT_CODE_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[TEL] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[EMAIL] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[SEND_SAKI_FS] [nvarchar](50) COLLATE Japanese_CI_AS  NULL,
	[BU] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ACCOUNT_CODE] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[COST_CENTER] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[INTERNAL_ORDER] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[ZETIA_CD] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[STATUS_SHONIN] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[SHONIN_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[SHONIN_TIME] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[SHONIN_NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[CMSHONIN_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[CMSHONIN_TIME] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[CMSHONIN_NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[STATUS_TEHAI] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[ANS_STATUS_TEHAI] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[YOTEI_DATE] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[KAISAI_DATE_NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[MEETING_NAME] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[SEIHIN_NAME] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[SANKA_YOTEI_CNT_DR] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[SANKA_YOTEI_CNT_OTHER] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[MITSUMORI_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[MITSUMORI_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[MITSUMORI_TOTAL] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[MITSUMORI_URL] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[KAISAI_KIBOU_ADDRESS1] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[KAISAI_KIBOU_ADDRESS2] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[KAISAI_KIBOU_NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[KOUEN_KAIJO_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[KOUEN_TIME1] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[KOUEN_TIME2] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[KOUEN_KAIJO_LAYOUT] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[IKENKOUKAN_KAIJO_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[IKENKOUKAN_TIME1] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[IKENKOUKAN_TIME2] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[KOUSHI_ROOM_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[KOUSHI_ROOM_TIME1] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[KOUSHI_ROOM_TIME2] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[KOUSHI_ROOM_CNT] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[MANAGER_KAIJO_TEHAI] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[MANAGER_KAIJO_TIME1] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[MANAGER_KAIJO_TIME2] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[KAIJO_URL] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[OTHER_NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[FIX_KAISAI_SHISETSU] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[FIX_KAISAI_NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[FIX_SEISAN_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[FIX_SEISAN_GTAX] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[FIX_SEISAN_NTAX] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	 CONSTRAINT [PK_TBL_KAIJO] PRIMARY KEY CLUSTERED 
(
	[KOUENKAI_ID] ASC,
	[TIME_STAMP] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF