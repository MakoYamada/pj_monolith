USE [BAYER_DEMO]
GO
/****** オブジェクト:  Table [dbo].[TBL_SEIKYU]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_SEIKYU](
	[KOUENKAI_NO] [nvarchar](14) COLLATE Japanese_CI_AS  NOT NULL,
	[SHIHARAI_NO] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[SEISAN_YM] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[SHOUNIN_KUBUN] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[SHOUNIN_DATE] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[KAIJOHI_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KIZAIHI_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[INSHOKUHI_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KEI_991330401_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[HOTELHI_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[HOTELHI_TOZEI] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[JR_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[AIR_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[OTHER_TRAFFIC_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[TAXI_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[HOTEL_COMMISSION_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[TAXI_COMMISSION_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[TAXI_SEISAN_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[JINKENHI_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[OTHER_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KANRIHI_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KEI_41120200_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KEI_TF] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KAIJOUHI_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KIZAIHI_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[INSHOKUHI_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KEI_991330401_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[JINKENHI_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[OTHER_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KANRIHI_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KEI_41120200_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KEI_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[SEIKYU_NO_TOPTOUR] [nvarchar](14) COLLATE Japanese_CI_AS  NOT NULL,
	[TAXI_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[TAXI_SEISAN_T] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[SEISANSHO_URL] [nvarchar](255) COLLATE Japanese_CI_AS  NULL,
	[TAXI_TICKET_URL] [nvarchar](255) COLLATE Japanese_CI_AS  NULL,
	[SEISAN_KANRYO] [nvarchar](510) COLLATE Japanese_CI_AS  NULL,
	[MR_JR] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[MR_HOTEL] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[MR_HOTEL_TOZEI] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[SEND_FLAG] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[TTANTO_ID] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[INPUT_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[INPUT_USER] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_USER] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
 CONSTRAINT [PK_TBL_SEIKYU] PRIMARY KEY CLUSTERED 
(
	[KOUENKAI_NO] ASC,
	[SEIKYU_NO_TOPTOUR] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
