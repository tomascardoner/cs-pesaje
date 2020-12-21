Partial Public Class Cosecha_Producto_Tarifa
    Friend Function Clone(ByVal includeChilds As Boolean, Optional ByVal includeKey As Boolean = True) As Cosecha_Producto_Tarifa
        Dim Cosecha_Producto_TarifaClonada As New Cosecha_Producto_Tarifa

        With Cosecha_Producto_TarifaClonada
            If includeKey Then
                .IDCosecha = IDCosecha
                .IDProducto = IDProducto
                .Indice = Indice
            End If
            .IDPlanta = IDPlanta
            .IDEntidad = IDEntidad
            .IDOrigen = IDOrigen
            .Nombre = Nombre
            .FechaDesde = FechaDesde
            .FechaHasta = FechaHasta
            .TarifaParitariaImporte = TarifaParitariaImporte
            .TarifaSecadoTipo = TarifaSecadoTipo
            .TarifaSecadoInicialPunto = TarifaSecadoInicialPunto
            .TarifaSecadoInicialImporte = TarifaSecadoInicialImporte
            .TarifaSecadoPuntoExcesoImporte = TarifaSecadoPuntoExcesoImporte
            .TarifaSecadoHumedadBase = TarifaSecadoHumedadBase
            .TarifaSecadoHumedadMargenLibre = TarifaSecadoHumedadMargenLibre
            .TarifaSecadoHumedadRedondeoPuntoTipo = TarifaSecadoHumedadRedondeoPuntoTipo
            .TarifaZarandeoImporte = TarifaZarandeoImporte
            .TarifaFumigadoImporte = TarifaFumigadoImporte
            .TarifaMezclaImporte = TarifaMezclaImporte
            .AlmacenajeTipo = AlmacenajeTipo
            .AlmacenajeDiaGracia = AlmacenajeDiaGracia
            .AlmacenajeInicio = AlmacenajeInicio
            .AlmacenajePorcentajeMensual = AlmacenajePorcentajeMensual

            If includeChilds Then
                For Each escala As Cosecha_Producto_TarifaEscala In Cosecha_Producto_TarifaEscala
                    .Cosecha_Producto_TarifaEscala.Add(escala.Clone(False))
                Next
            End If
        End With

        Return Cosecha_Producto_TarifaClonada
    End Function
End Class
