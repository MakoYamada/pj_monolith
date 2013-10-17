USE [BAYER_DEMO]
GO
/****** オブジェクト:  Table [dbo].[TBL_KOUENKAI]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_KOUENKAI](
	[KOUENKAI_NO] [nvarchar](14) COLLATE Japanese_CI_AS  NOT NULL,
	[TIME_STAMP] [nvarchar](14) COLLATE Japanese_CI_AS  NOT NULL,
	[TORIKESHI_FLG] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[KIDOKU_FLG] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[KOUENKAI_TITLE] [nvarchar](160) COLLATE Japanese_CI_AS  NOT NULL,
	[KOUENKAI_NAME] [nvarchar](160) COLLATE Japanese_CI_AS  NULL,
	[TAXI_PRT_NAME] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[FROM_DATE] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[TO_DATE] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[KAIJO_NAME] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[SEIHIN_NAME] [nvarchar](80) COLLATE Japanese_CI_AS  NULL,
	[INTERNAL_ORDER_T] [nvarchar](12) COLLATE Japanese_CI_AS  NULL,
	[INTERNAL_ORDER_TF] [nvarchar](12) COLLATE Japanese_CI_AS  NULL,
	[ACCOUNT_CD_T] [nvarchar](7) COLLATE Japanese_CI_AS  NULL,
	[ACCOUNT_CD_TF] [nvarchar](7) COLLATE Japanese_CI_AS  NULL,
	[ZETIA_CD] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[SANKA_YOTEI_CNT_NMBR] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[SANKA_YOTEI_CNT_MBR] [nvarchar](5) COLLATE Japanese_CI_AS  NULL,
	[SRM_HACYU_KBN] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[BU] [nvarchar](40) COLLATE Japanese_CI_AS  NULL,
	[KIKAKU_TANTO_JIGYOUBU] [nvarchar](80) COLLATE Japanese_CI_AS  NULL,
	[KIKAKU_TANTO_AREA] [nvarchar](80) COLLATE Japanese_CI_AS  NULL,
	[KIKAKU_TANTO_EIGYOSHO] [nvarchar](80) COLLATE Japanese_CI_AS  NULL,
	[KIKAKU_TANTO_NAME] [nvarchar](300) COLLATE Japanese_CI_AS  NULL,
	[KIKAKU_TANTO_ROMA] [nvarchar](300) COLLATE Japanese_CI_AS  NULL,
	[KIKAKU_TANTO_EMAIL_PC] [nvarchar](128) COLLATE Japanese_CI_AS  NULL,
	[KIKAKU_TANTO_EMAIL_KEITAI] [nvarchar](128) COLLATE Japanese_CI_AS  NULL,
	[KIKAKU_TANTO_KEITAI] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[KIKAKU_TANTO_TEL] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[COST_CENTER] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[TEHAI_TANTO_BU] [nvarchar](40) COLLATE Japanese_CI_AS  NULL,
	[TEHAI_TANTO_AREA] [nvarchar](80) COLLATE Japanese_CI_AS  NULL,
	[TEHAI_TANTO_EIGYOSHO] [nvarchar](80) COLLATE Japanese_CI_AS  NULL,
	[TEHAI_TANTO_NAME] [nvarchar](300) COLLATE Japanese_CI_AS  NULL,
	[TEHAI_TANTO_ROMA] [nvarchar](300) COLLATE Japanese_CI_AS  NULL,
	[TEHAI_TANTO_EMAIL_PC] [nvarchar](128) COLLATE Japanese_CI_AS  NULL,
	[TEHAI_TANTO_EMAIL_KEITAI] [nvarchar](128) COLLATE Japanese_CI_AS  NULL,
	[TEHAI_TANTO_KEITAI] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[TEHAI_TANTO_TEL] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[YOSAN_TF] [nvarchar](18) COLLATE Japanese_CI_AS  NULL,
	[YOSAN_T] [nvarchar](18) COLLATE Japanese_CI_AS  NULL,
	[IROUKAI_YOSAN_T] [nvarchar](18) COLLATE Japanese_CI_AS  NULL,
	[IKENKOUKAN_YOSAN_T] [nvarchar](18) COLLATE Japanese_CI_AS  NULL,
	[SEND_FLAG] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[TTANTO_ID] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[INPUT_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[INPUT_USER] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_USER] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
 CONSTRAINT [PK_TBL_KOUENKAI] PRIMARY KEY CLUSTERED 
(
	[KOUENKAI_NO] ASC,
	[TIME_STAMP] ASC,
	[KOUENKAI_TITLE] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
