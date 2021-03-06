USE [BAYER_DEMO]
GO
/****** オブジェクト:  Table [dbo].[TBL_TAXITICKET_HAKKO]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_TAXITICKET_HAKKO](
	[TKT_KAISHA] [nvarchar](2) COLLATE Japanese_CI_AS  NOT NULL,
	[TKT_NO] [nvarchar](9) COLLATE Japanese_CI_AS  NOT NULL,
	[TKT_KENSHU] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KOUENKAI_NO] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[SANKASHA_ID] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[TKT_LINE_NO] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[TKT_USED_DATE] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[TKT_URIAGE] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[TKT_SEISAN_FEE] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[TKT_HAKKO_FEE] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[TKT_ENTA] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[TKT_VOID] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[TKT_MIKETSU] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[TKT_IMPORT_DATE] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[TKT_SEIKYU_YM] [nvarchar](6) COLLATE Japanese_CI_AS  NULL,
	[SEIKYU_NO_TOPTOUR] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[INPUT_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[INPUT_USER] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_USER] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[TKT_HATUTI] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[TKT_CHAKUTI] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
CONSTRAINT [PK_TBL_TAXITICKET_HAKKO] PRIMARY KEY CLUSTERED 
(
	[TKT_KAISHA] ASC,
	[TKT_NO] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
