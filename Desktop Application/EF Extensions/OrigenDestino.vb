Partial Public Class OrigenDestino

    Public ReadOnly Property DomicilioCompleto() As String
        Get
            Dim ReturnValue As String

            ReturnValue = Domicilio

            Return ReturnValue
        End Get
    End Property

End Class