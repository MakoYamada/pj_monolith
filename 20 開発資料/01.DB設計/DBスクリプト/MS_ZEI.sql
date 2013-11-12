USE [BAYER_DEMO]
GO
/****** オブジェクト:  Table [dbo].[MS_ZEI]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MS_ZEI](
	[ZEI_CD] [nvarchar](1) COLLATE Japanese_CI_AS  NOT NULL,
	[ZEI_NAME] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[ZEI_RATE] [nvarchar](4) COLLATE Japanese_CI_AS  NULL,
	[START_DATE] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[END_DATE] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[STOP_FLG] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[INPUT_DATE] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[INPUT_USER] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_DATE] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_USER] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
 CONSTRAINT [PK_MS_ZEI] PRIMARY KEY CLUSTERED 
(
	[ZEI_CD] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
