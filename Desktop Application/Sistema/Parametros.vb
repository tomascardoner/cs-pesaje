Module Parametros

#Region "Constantes"

    ' APLICACIÓN
    Friend Const APPLICATION_DATABASE_GUID As String = "APPLICATION_DATABASE_GUID"

    Friend Const LICENSE_COMPANY_NAME As String = "LICENSE_COMPANY_NAME"

    Friend Const USER_USERNAME_MINIMUM_LENGHT As String = "USER_USERNAME_MINIMUM_LENGHT"
    Friend Const USER_PASSWORD_MINIMUM_LENGHT As String = "USER_PASSWORD_MINIMUM_LENGHT"
    Friend Const USER_PASSWORD_SECURE_REQUIRED As String = "USER_PASSWORD_SECURE_REQUIRED"

    ' VALORES PREDETERMINADOS
    Friend Const DEFAULT_PROVINCIA_ID As String = "DEFAULT_PROVINCIA_ID"

    Friend Const DEFAULT_LOCALIDAD_ID As String = "DEFAULT_LOCALIDAD_ID"
    Friend Const DEFAULT_CODIGOPOSTAL As String = "DEFAULT_CODIGOPOSTAL"

    ' PESADAS
    Friend Const PESADA_FECHA_INICIOACTUAL_ANTERIOR_DIFERENCIAMAXIMA_DIAS As String = "PESADA_FECHA_INICIOACTUAL_ANTERIOR_DIFERENCIAMAXIMA_DIAS"

    Friend Const PESADA_FECHA_INICIOFIN_DIFERENCIAMAXIMA_DIAS As String = "PESADA_FECHA_INICIOFIN_DIFERENCIAMAXIMA_DIAS"
    Friend Const PESADA_HORA_INICIOACTUAL_DIFERENCIAMAXIMA_MINUTOS As String = "PESADA_HORA_INICIOACTUAL_DIFERENCIAMAXIMA_MINUTOS"
    Friend Const PESADA_ENTRADA_HUMEDAD_VACIA_MOSTRARERROR As String = "PESADA_ENTRADA_HUMEDAD_VACIA_MOSTRARERROR"
    Friend Const PESADA_ENTRADA_ZARANDEO_VACIO_MOSTRARERROR As String = "PESADA_ENTRADA_ZARANDEO_VACIO_MOSTRARERROR"

    ' REPORTES
    Friend Const REPORTEGRUPO_PESADAS_TICKETS_ID As String = "REPORTEGRUPO_PESADAS_TICKETS_ID"

    Friend Const REPORTEGRUPO_PESADAS_REPORTES_ID As String = "REPORTEGRUPO_PESADAS_REPORTES_ID"

    ' MAPAS
    Friend Const MAPS_GOOGLEMAPS_LOCATIONLINK As String = "MAPS_GOOGLEMAPS_LOCATIONLINK"

    Friend Const MAPS_GOOGLEMAPS_ZOOMDEFAULT As String = "MAPS_GOOGLEMAPS_ZOOMDEFAULT"

#End Region

    Friend Function LoadParameters() As Boolean
        Try
            Using dbContext As New CSPesajeContext(True)
                pParametros = dbContext.Parametro.ToList
            End Using
            Return True
        Catch ex As Exception
            If ex.Source = "mscorlib" Then
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al inicializar los componentes.")
            Else
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al conectarse a la base de datos.")
            End If
            Return False
        End Try
    End Function

    Friend Function SaveParameter(parametro As Parametro) As Boolean
        Try
            Using dbcontext As New CSPesajeContext(True)
                Dim parametroExistente As Parametro
                parametroExistente = dbcontext.Parametro.Find(parametro.IDParametro)
                If parametroExistente Is Nothing Then
                    dbcontext.Parametro.Append(parametro)
                Else
                    parametroExistente.Texto = parametro.Texto
                    parametroExistente.NumeroEntero = parametro.NumeroEntero
                    parametroExistente.NumeroDecimal = parametro.NumeroDecimal
                    parametroExistente.Moneda = parametro.Moneda
                    parametroExistente.FechaHora = parametro.FechaHora
                    parametroExistente.SiNo = parametro.SiNo
                    parametroExistente.Notas = parametro.Notas
                End If
                If dbcontext.ChangeTracker.HasChanges() Then
                    dbcontext.SaveChanges()
                End If
            End Using
            Return True
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al conectarse a la base de datos.")
            Return False
        End Try
    End Function

End Module