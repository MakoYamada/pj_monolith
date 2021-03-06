USE [MONOLITH_DB]
GO
/****** オブジェクト:  Table [dbo].[MS_SAPKANRI]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MS_SAPKANRI](
	[DATA_ID] [nvarchar](2) COLLATE Japanese_CI_AS  NOT NULL,
	[CODE] [nvarchar](10) COLLATE Japanese_CI_AS  NOT NULL,
	[BIKO] [nvarchar](50) COLLATE Japanese_CI_AS  NULL,
CONSTRAINT [PK_MS_SAPKANRI] PRIMARY KEY CLUSTERED 
(
	[DATA_ID] ASC
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
