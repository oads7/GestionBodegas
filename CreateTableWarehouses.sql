USE [oads7_GestionBodegas]
GO

/****** Object:  Table [dbo].[Warehouses]    Script Date: 30/09/2022 12:16:32 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Warehouses](
	[WarehouseId] [int] IDENTITY(1,1) NOT NULL,
	[WarehouseName] [varchar](32) NOT NULL,
	[WarehouseDescription] [varchar](128) NOT NULL,
	[Capacity] [varchar](32) NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_Warehouses] PRIMARY KEY CLUSTERED 
(
	[WarehouseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

