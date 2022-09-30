USE [oads7_GestionBodegas]
GO

/****** Object:  Table [dbo].[ProductStates]    Script Date: 30/09/2022 12:16:10 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ProductStates](
	[ProductStateId] [int] IDENTITY(1,1) NOT NULL,
	[State] [varchar](16) NOT NULL,
 CONSTRAINT [PK_ProductStates] PRIMARY KEY CLUSTERED 
(
	[ProductStateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

