USE [BAYER_DEMO]
GO
/****** オブジェクト:  Table [dbo].[TBL_LOG]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_LOG](
	[INPUT_DATE] [nvarchar](14) COLLATE Japanese_CI_AS  NULL,
	[INPUT_USER] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[SYORI_KBN] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[SYORI_NAME] [nvarchar](50) COLLATE Japanese_CI_AS  NULL,
	[TABLE_NAME] [nvarchar](50) COLLATE Japanese_CI_AS  NULL,
	[STATUS] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF