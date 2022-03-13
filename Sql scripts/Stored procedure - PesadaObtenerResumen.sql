USE CSPesaje
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:   Tomás A. Cardoner
-- Creation: 2022-03-12
-- Description:	Obtiene los totales de pesadas
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'uspPesadaObtenerResumen') AND type in (N'P', N'PC'))
	 DROP PROCEDURE uspPesadaObtenerResumen
GO
CREATE PROCEDURE dbo.uspPesadaObtenerResumen 
    @IDProducto tinyint,
	@IDCosecha tinyint,
	@IDPlanta tinyint,
	@IDEntidad int,
	@Entradas bit,
	@Salidas bit,
	@FechaDesde date,
	@FechaHasta date
AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT ISNULL(SUM(CASE p.Tipo WHEN 'E' THEN p.KilogramoNeto END), 0) AS KilogramosEntradasBrutos, ISNULL(SUM(CASE p.Tipo WHEN 'E' THEN p.KilogramoFinal END), 0) AS KilogramosEntradasNetos, ISNULL(SUM(CASE p.Tipo WHEN 'S' THEN p.KilogramoNeto END), 0) AS KilogramosSalidas, COUNT(CASE p.Tipo WHEN 'E' THEN p.IDPesada END) AS CantidadEntradas, COUNT(CASE p.Tipo WHEN 'S' THEN p.IDPesada END) AS CantidadSalidas
			FROM Pesada AS p
			WHERE p.IDProducto = @IDProducto
				AND (@IDCosecha IS NULL OR p.IDCosecha = @IDCosecha)
				AND (@IDPlanta IS NULL OR p.IDPlanta = @IDPlanta)
				AND (@IDEntidad IS NULL OR p.Titular_IDEntidad = @IDEntidad)
				AND ((@Entradas = 1 AND p.Tipo = 'E') OR (@Salidas = 1 AND p.Tipo = 'S'))
				AND (@FechaDesde IS NULL OR p.FechaHoraInicio >= @FechaDesde)
				AND (@FechaHasta IS NULL OR p.FechaHoraInicio <= DATETIMEFROMPARTS(YEAR(@FechaHasta), MONTH(@FechaHasta), DAY(@FechaHasta), 23, 59, 59, 99))
	END
GO