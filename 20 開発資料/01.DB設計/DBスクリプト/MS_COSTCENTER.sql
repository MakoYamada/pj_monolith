USE [BAYER_DEMO]
GO
/****** オブジェクト:  Table [dbo].[MS_COSTCENTER]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MS_COSTCENTER](
	[COSTCENTER_CD] [nvarchar](10) COLLATE Japanese_CI_AS  NOT NULL,
	[COSTCENTER_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[STOP_FLG] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[INPUT_DATE] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[INPUT_USER] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_DATE] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_USER] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
 CONSTRAINT [PK_MS_COSTCENTER] PRIMARY KEY CLUSTERED 
(
	[COSTCENTER_CD] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
