Partial Public Class Producto_Humedad

    Public ReadOnly Property HumedadFormatted As String
        Get
            If Humedad = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_DECIMAL Then
                Return My.Resources.STRING_ITEM_EMPTY_FEMALE
            Else
                Return Humedad.ToString(CardonerSistemas.Constants.FormatStringToPercent)
            End If
        End Get
    End Property

End Class
