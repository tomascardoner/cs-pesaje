Module StartUp
    ' Config files
    Friend pAppearanceConfig As New AppearanceConfig
    Friend pDatabaseConfig As DatabaseConfig
    Friend pGeneralConfig As GeneralConfig

    ' Database stuff
    Friend pDatabase As CardonerSistemas.Database.ADO.SQLServer
    Friend pFillAndRefreshLists As FillAndRefreshLists

    Friend pFormMDIMain As formMDIMain
    Friend pPermisos As List(Of UsuarioGrupoPermiso)
    Friend pPermisosReportes As List(Of Reporte)
    Friend pParametros As List(Of Parametro)
    Friend pLicensedTo As String
    Friend pUsuario As Usuario
    Friend pBalanzaConeccionHabilitada As Boolean = False

    <STAThread> Friend Sub Main()
        Dim StartupTime As Date

        Cursor.Current = Cursors.AppStarting

        My.Application.Log.WriteEntry("La Aplicación se está iniciando.", TraceEventType.Information)

        ' Cargo los archivos de configuración de la aplicación
        If Not Configuration.LoadFiles() Then
            TerminateApplication()
            Return
        End If

        ' Realizo la inicialización de la Aplicación
        If pAppearanceConfig.EnableVisualStyles Then
            Application.EnableVisualStyles()
        End If

        ' Muestro el SplashScreen y cambio el puntero del mouse para indicar que la aplicación está iniciando.
        formSplashScreen.Show()
        formSplashScreen.Cursor = Cursors.AppStarting
        formSplashScreen.labelStatus.Text = "Leyendo la información de conexión a la base de datos..."
        Application.DoEvents()

        ' Obtengo el Connection String para las conexiones de ADO .NET
        pDatabase = New CardonerSistemas.Database.Ado.SqlServer()
        If Not pDatabase.SetProperties(pDatabaseConfig.Datasource, pDatabaseConfig.Database, String.Empty, False, pDatabaseConfig.UserId, pDatabaseConfig.Password, False, pDatabaseConfig.ConnectTimeout, pDatabaseConfig.ConnectRetryCount, pDatabaseConfig.ConnectRetryInterval) Then
            formSplashScreen.Close()
            formSplashScreen.Dispose()
            TerminateApplication()
            Return
        End If
        If Not pDatabase.PasswordUnencrypt() Then
            formSplashScreen.Close()
            formSplashScreen.Dispose()
            TerminateApplication()
            Return
        End If
        pDatabase.CreateConnectionString()

        ' Verifico que se pueda establecer la conexión a la base de datos
        Dim newLoginData As Boolean = False
        If Not pDatabase.Connect(pDatabaseConfig, newLoginData) Then
            formSplashScreen.Close()
            formSplashScreen.Dispose()
            TerminateApplication()
            Return
        End If
        If newLoginData Then
            Configuration.SaveFileDatabase()
        End If

        ' Obtengo el Connection String para las conexiones de Entity Framework
        CSPesajeContext.ConnectionString = CardonerSistemas.Database.EntityFramework.CreateConnectionString(pDatabaseConfig.Provider, pDatabase.ConnectionString, "CSPesaje")

        ' Cargos los Parámetros desde la Base de datos
        formSplashScreen.labelStatus.Text = "Cargando los parámetros de la aplicación..."
        Application.DoEvents()
        If Not Parametros.LoadParameters() Then
            formSplashScreen.Close()
            formSplashScreen.Dispose()
            TerminateApplication()
            Return
        End If

        formSplashScreen.labelStatus.Text = "Verificando los parámetros de la aplicación..."
        Application.DoEvents()
        ' Verifico que la Base de Datos corresponda a esta Aplicación a través del GUID guardado en los Parámetros
        If CS_Parameter_System.GetString(Parametros.APPLICATION_DATABASE_GUID) <> Constantes.ApplicationDatabaseGuid Then
            MsgBox("La Base de Datos especificada no corresponde a esta aplicación.", MsgBoxStyle.Critical, My.Application.Info.Title)
            formSplashScreen.Close()
            formSplashScreen.Dispose()
            TerminateApplication()
            Return
        End If

        ' Muestro el Nombre de la Compañía a la que está licenciada la Aplicación
        If Not CardonerSistemas.Encrypt.StringCipher.Decrypt(CS_Parameter_System.GetString(Parametros.LICENSE_COMPANY_NAME, "EMPTY"), Constantes.ApplicationLicensePassword, pLicensedTo) Then
            MsgBox("La Licencia especificada es incorrecta.", MsgBoxStyle.Critical, My.Application.Info.Title)
            formSplashScreen.Close()
            formSplashScreen.Dispose()
            TerminateApplication()
            Return
        End If
        formSplashScreen.labelLicensedTo.Text = pLicensedTo
        Application.DoEvents()

        ' Preparo instancia de clase para llenar los ComboBox
        formSplashScreen.labelStatus.Text = "Cargando las listas de la base de datos..."
        Application.DoEvents()
        pFillAndRefreshLists = New FillAndRefreshLists

        ' Tomo el tiempo de inicio para controlar los segundos mínimos que se debe mostrar el Splash Screen
        StartupTime = Now

        ' Muestro el form MDI principal
        pFormMDIMain = New formMDIMain
        pFormMDIMain.Show()
        formSplashScreen.Focus()

        pFormMDIMain.Cursor = Cursors.AppStarting
        pFormMDIMain.Enabled = False

        ' Si corresponde, abro la conexión con el puerto correspondiente para leer los valores de la balanza
        If pGeneralConfig.ScaleConnectionEnabled Then
            pBalanzaConeccionHabilitada = True
        End If

        ' Muestro el form de Pesadas
        formSplashScreen.labelStatus.Text = "Cargando y mostrando ventana de Pesadas..."
        formSplashScreen.Focus()
        Application.DoEvents()

        CardonerSistemas.Forms.MdiChildPositionAndSizeToFit(CType(pFormMDIMain, Form), CType(formPesadas, Form))

        formSplashScreen.labelStatus.Text = "Todo completado."
        Application.DoEvents()

        ' Espero el tiempo mínimo para mostrar el Splash Screen y después lo cierro
        If Not CS_Instance.IsRunningUnderIDE Then
            Do While Now.Subtract(StartupTime).Seconds < pAppearanceConfig.MinimumSplashScreenDisplaySeconds
                Application.DoEvents()
            Loop
        End If
        formSplashScreen.Close()
        formSplashScreen.Dispose()

        If CS_Instance.IsRunningUnderIDE Then
            ' Como se está ejecutando dentro del IDE de Visual Studio, en lugar de pedir Usuario y contraseña, asumo que es el Administrador
            Using dbcontext As New CSPesajeContext(True)
                pUsuario = dbcontext.Usuario.Find(1)
                Appearance.UserLoggedIn()
            End Using
        ElseIf pGeneralConfig.AutoLogonUsername <> String.Empty Then
            ' Se especifica un Usuario de Auto Logon, por lo tanto, se procederá a verificar la información de Logon
            Using dbcontext As New CSPesajeContext(True)
                pUsuario = dbcontext.Usuario.Where(Function(us) us.Nombre = pGeneralConfig.AutoLogonUsername).FirstOrDefault
                If pUsuario Is Nothing Then
                    Application.Exit()
                    My.Application.Log.WriteEntry("La Aplicación ha finalizado porque el Usuario especificado en Auto-Logon no existe.", TraceEventType.Warning)
                    Return
                End If
                Dim DecryptedPassword As String = String.Empty
                If Not CardonerSistemas.Encrypt.StringCipher.Decrypt(pGeneralConfig.AutoLogonPassword, CardonerSistemas.Constants.PublicEncryptionPassword, DecryptedPassword) Then
                    MsgBox("La contraseña especificada en Auto-Logon es incorrecta.", MsgBoxStyle.Critical, My.Application.Info.Title)
                    TerminateApplication()
                    Application.Exit()
                    My.Application.Log.WriteEntry("La Aplicación ha finalizado porque el Password especificado en el Auto-Logon es incorrecto.", TraceEventType.Warning)
                    Return
                End If
                If DecryptedPassword <> pUsuario.Password Then
                    MsgBox("La contraseña especificada en Auto-Logon es incorrecta.", MsgBoxStyle.Critical, My.Application.Info.Title)
                    TerminateApplication()
                    Application.Exit()
                    My.Application.Log.WriteEntry("La Aplicación ha finalizado porque el Password especificado en el Auto-Logon es incorrecto.", TraceEventType.Warning)
                    Return
                End If

                Appearance.UserLoggedIn()
            End Using
        Else
            ' El Usuario debe iniciar sesión a través del form correspondiente
            If formLogin.ShowDialog(formSplashScreen) <> DialogResult.OK Then
                Application.Exit()
                My.Application.Log.WriteEntry("La Aplicación ha finalizado porque el Usuario no ha iniciado sesión.", TraceEventType.Warning)
                Return
            End If
            formLogin.Close()
            formLogin.Dispose()
        End If

        pFormMDIMain.Cursor = Cursors.Default
        pFormMDIMain.Enabled = True

        formPesadas.Show()

        Cursor.Current = Cursors.Default

        ' Inicio el loop sobre el form MDI principal
        My.Application.Log.WriteEntry("La Aplicación se ha iniciado correctamente.", TraceEventType.Information)
        Application.Run(pFormMDIMain)
    End Sub

    Friend Sub TerminateApplication()
        If pFormMDIMain IsNot Nothing Then
            CardonerSistemas.Forms.MdiChildCloseAll(CType(pFormMDIMain, Form))
            CardonerSistemas.Forms.CloseAll("FormMDIMain")
        End If
        If pDatabase IsNot Nothing Then
            pDatabase.Close()
            pDatabase = Nothing
        End If

        pAppearanceConfig = Nothing
        pDatabaseConfig = Nothing
        pGeneralConfig = Nothing

        pDatabase = Nothing
        pFillAndRefreshLists = Nothing
        pPermisos = Nothing
        pPermisosReportes = Nothing
        pParametros = Nothing
        pLicensedTo = Nothing
        pUsuario = Nothing
    End Sub

End Module