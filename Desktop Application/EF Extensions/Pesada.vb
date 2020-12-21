Partial Public Class Pesada

    Public ReadOnly Property CorrespondeAcondicionamiento() As Boolean
        Get
            Return (Tipo = Constantes.PESADA_TIPO_ENTRADA AndAlso IDCosecha.HasValue AndAlso KilogramoNeto.HasValue AndAlso KilogramoNeto.Value > 0)
        End Get
    End Property

End Class