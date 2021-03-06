USE [ChineseStudy]
GO

/****** Object:  Table [dbo].[Test_3000]    Script Date: 7/24/2017 11:02:52 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Test_3000](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FEseq] [nvarchar](255) NOT NULL,
	[Zhuyin] [nvarchar](255) NULL,
	[Traditional] [nvarchar](255) NOT NULL,
	[English] [nvarchar](255) NULL,
	[Numpinyin] [nvarchar](255) NOT NULL,
	[CritPinyin] [nvarchar](255) NULL,
	[Simplified] [nvarchar](255) NULL,
	[Cji] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


