USE [oads7_GestionBodegas]
GO

/****** Object:  Table [dbo].[Products]    Script Date: 30/09/2022 12:15:14 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](32) NOT NULL,
	[ProductDescription] [varchar](128) NOT NULL,
	[WarehouseId] [int] NOT NULL,
	[State] [varchar](16) NOT NULL,
	[ManufacturingDate] [date] NOT NULL,
	[ExpirationDate] [date] NOT NULL,
	[EntryDate] [date] NOT NULL,
	[ReleaseDate] [date] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

