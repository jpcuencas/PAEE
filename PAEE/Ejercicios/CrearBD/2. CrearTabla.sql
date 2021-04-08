USE MSDNVideoDB;
GO

/****** Object:  Table [dbo].[Usuarios]    Script Date: 10/05/2010 20:00:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Usuarios](
	[UsuarioID] [int] IDENTITY(1,1) NOT NULL,
	[NIF] [nchar](9) NOT NULL,
	[Clave] [nvarchar](50) NULL,
	[Rol] [smallint] NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Ciudad] [nvarchar](50) NULL,
	[Provincia] [nvarchar](50) NULL,
	[CodigoPostal] [decimal](5, 0) NULL,
	[Saldo] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


