Imports System.Data.Entity

Partial Public Class CSPesajeContext
    Inherits DbContext

    Public Shared Property ConnectionString As String

    Public Sub New(useCustomConnectionString As Boolean)
        MyBase.New(ConnectionString)
    End Sub
End Class