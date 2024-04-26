USE [PrintPaymentService]
GO

/****** Object:  Table [dbo].[SAP]    Script Date: 26.04.2024 16:02:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SAP](
	[Username] [nchar](100) NULL,
	[CardId] [nchar](100) NULL,
	[Quota] [int] NOT NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SAP] ADD  CONSTRAINT [DF_SAP_Quota]  DEFAULT ((0)) FOR [Quota]
GO


