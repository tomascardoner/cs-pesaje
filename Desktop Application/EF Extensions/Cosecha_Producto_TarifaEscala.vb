Partial Public Class Cosecha_Producto_TarifaEscala

    Public ReadOnly Property TipoNombre() As String
        Get
            Select Case Tipo
                Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_PORPUNTO
                    Return "Por punto"
                Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_COMPLETA
                    Return "Completa"
                Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_FIJO_SECADO
                    Return "Importe de Secado fijo"
                Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_FIJO_SECADOYZARANDEO
                    Return "Importe de Secado y Zarandeo fijo"
                Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_FIJO_TODOCONCEPTO
                    Return "Importe fijo por todo concepto"
                Case Else
                    Return ""
            End Select
        End Get
    End Property

    Friend Function Clone(Optional ByVal includeKey As Boolean = True) As Cosecha_Producto_TarifaEscala
        Dim Cosecha_Producto_TarifaEscalaClonada As New Cosecha_Producto_TarifaEscala

        With Cosecha_Producto_TarifaEscalaClonada
            If includeKey Then
                .IDCosecha = IDCosecha
                .IDProducto = IDProducto
                .Indice = Indice
            End If
            .HumedadExcesoInicio = HumedadExcesoInicio
            .Tipo = Tipo
            .Tarifa = Tarifa
        End With

        Return Cosecha_Producto_TarifaEscalaClonada
    End Function

End Class