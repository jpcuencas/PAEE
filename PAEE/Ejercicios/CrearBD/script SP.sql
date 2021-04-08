USE [MSDNVideoDB]
GO

/****** Object:  StoredProcedure [dbo].[ObtenerClaveUsuario]    Script Date: 11/02/2010 20:17:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ObtenerClaveUsuario]
(
	@nif nchar(9)
)
AS
	SET NOCOUNT ON;
SELECT Clave FROM Usuarios WHERE NIF = @nif
GO


