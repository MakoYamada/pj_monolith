USE [BAYER_DEMO]
GO
/****** オブジェクト:  Table [dbo].[MS_SHISETSU]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MS_SHISETSU](
	[SYSTEM_ID] [nvarchar](10) COLLATE Japanese_CI_AS  NOT NULL,
	[ZIP] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[ADDRESS1] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[ADDRESS2] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[SHISETSU_NAME] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[SHISETSU_KANA] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[TEL] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[CHECKIN_TIME] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[CHECKOUT_TIME] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[URL] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[STOP_FLG] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[INPUT_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[INPUT_USER] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[UPDATE_USER] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
 CONSTRAINT [PK_MS_SHISETSU] PRIMARY KEY CLUSTERED 
(
	[SYSTEM_ID] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF