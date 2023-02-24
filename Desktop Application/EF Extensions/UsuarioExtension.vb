Partial Public Class Usuario

    Public ReadOnly Property IDUsuarioFormatted As String
        Get
            If IDUsuario = 0 Then
                Return My.Resources.STRING_ITEM_EMPTY_MALE
            Else
                Return IDUsuario.ToString(CardonerSistemas.Constants.FormatStringToNumberInteger)
            End If
        End Get
    End Property

    Public ReadOnly Property FechaHoraCreacionFormatted As String
        Get
            Return String.Format("{0} {1}", FechaHoraCreacion.ToShortDateString(), FechaHoraCreacion.ToShortTimeString())
        End Get
    End Property

    Public ReadOnly Property UsuarioCreacionFormatted As String
        Get
            If UsuarioCreacion Is Nothing Then
                Return String.Empty
            Else
                Return UsuarioCreacion.Descripcion
            End If
        End Get
    End Property

    Public ReadOnly Property FechaHoraModificacionFormatted As String
        Get
            Return String.Format("{0} {1}", FechaHoraModificacion.ToShortDateString(), FechaHoraModificacion.ToShortTimeString())
        End Get
    End Property

    Public ReadOnly Property UsuarioModificacionFormatted As String
        Get
            If UsuarioModificacion Is Nothing Then
                Return String.Empty
            Else
                Return UsuarioModificacion.Descripcion
            End If
        End Get
    End Property

End Class
