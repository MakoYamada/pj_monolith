USE [BAYER_DEMO]
GO
/****** オブジェクト:  Table [dbo].[TBL_BENTO]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TBL_BENTO](
	[ID] [nvarchar](10) COLLATE Japanese_CI_AS  NOT NULL,
	[KINKYU_FLG] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
	[RAIJO_FLG] [nvarchar](1) COLLATE Japanese_CI_AS  NULL,
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
	[DR_MPID] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[DR_NAME] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[DR_KANA] [nvarchar](100) COLLATE Japanese_CI_AS  NULL,
	[DR_SHISETSU_NAME] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[DR_CD] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[DR_SHISETSU_CD] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[DR_ADDRESS] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[DR_GOFFICIAL] [nvarchar](50) COLLATE Japanese_CI_AS  NULL,
	[DR_YAKUWARI] [nvarchar](50) COLLATE Japanese_CI_AS  NULL,
	[KOUENKAI_NAME] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[KOUENKAI_DATE] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[KOUENKAI_NO] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KAIJO] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
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
	[HAITATSU_DATE] [nvarchar](8) COLLATE Japanese_CI_AS  NULL,
	[HAITATSU_KIBOU_TIME] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[HAITATSU_ADDRESS] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[HAITATSU_SHISETSU] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[SURYO] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[TANKA] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[KIBOU_MAKER] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[KIBOU_MENU] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
	[ANS_STATUS_TEHAI] [nvarchar](2) COLLATE Japanese_CI_AS  NULL,
	[FIX_HAITATSU_TIME] [nvarchar](20) COLLATE Japanese_CI_AS  NULL,
	[FIX_HAITATSU_ADDRESS] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[FIX_HAITATSU_SHISETSU] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[FIX_SURYO] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[FIX_TANKA] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[FIX_KINGAKU_TOTAL] [nvarchar](10) COLLATE Japanese_CI_AS  NULL,
	[FIX_MAKER] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[FIX_MAKER_CONTACT] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[FIX_KIBOU_MAKER] [nvarchar](200) COLLATE Japanese_CI_AS  NULL,
	[FIX_NOTE] [nvarchar](1000) COLLATE Japanese_CI_AS  NULL,
 CONSTRAINT [PK_TBL_BENTO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF