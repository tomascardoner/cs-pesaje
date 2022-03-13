Public Class formMDIMain

#Region "Declarations"

    Private AFIP_TicketAcceso_Homo As String

#End Region

#Region "Form stuff"

    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cambio el puntero del mouse para indicar que la aplicación está iniciando
        Me.Cursor = Cursors.AppStarting

        ' Deshabilito el Form principal hasta que se cierre el SplashScreen
        Me.Enabled = False

        Me.Text = My.Application.Info.Title

        menuitemAyuda_AcercaDe.Text = String.Format("&Acerca de {0}...", My.Application.Info.Title)

        textboxKilogramo.Visible = pBalanzaConeccionHabilitada
    End Sub

    Private Sub Me_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not (e.CloseReason = CloseReason.ApplicationExitCall Or e.CloseReason = CloseReason.TaskManagerClosing Or e.CloseReason = CloseReason.WindowsShutDown) Then
            If MsgBox("¿Desea salir de la aplicación?", CType(MsgBoxStyle.Information + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        TerminateApplication()
    End Sub

#End Region

#Region "Menu Archivo"

    Private Sub menuitemArchivo_Salir_Click() Handles menuitemArchivo_Salir.Click
        Me.Close()
    End Sub

    Private Sub UsuarioCerrarSesion() Handles menuitemArchivo_CerrarSesion.Click
        CerrarSesionUsuario()
    End Sub

#End Region

#Region "Menu Ventana"

    Private Sub menuitemVentana_MosaicoHorizontal_Click() Handles menuitemVentana_MosaicoHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub menuitemVentana_MosaicoVertical_Click() Handles menuitemVentana_MosaicoVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub menuitemVentana_Cascada_Click() Handles menuitemVentana_Cascada.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub menuitemVentana_OrganizarIconos_Click() Handles menuitemVentana_OrganizarIconos.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub menuitemVentana_EncajarEnVentana_Click() Handles menuitemVentana_EncajarEnVentana.Click
        If Not Me.ActiveMdiChild Is Nothing Then
            Me.ActiveMdiChild.Left = 0
            Me.ActiveMdiChild.Top = 0
            Me.ActiveMdiChild.Size = Me.ClientSize
        End If
    End Sub

    Private Sub menuitemVentana_CerrarTodas_Click() Handles menuitemVentana_CerrarTodas.Click
        CardonerSistemas.Forms.MdiChildCloseAll(Me)
    End Sub

#End Region

#Region "Menu Ayuda"

    Private Sub menuitemAyuda_AcercaDe_Click(sender As Object, e As EventArgs) Handles menuitemAyuda_AcercaDe.Click
        formAboutBox.ShowDialog(Me)
        formAboutBox.Dispose()
    End Sub

#End Region

#Region "Left Toolbar - Tablas"

    Private Sub Entidades() Handles menuitemTablas_Entidades.Click
        ShowForm(Permisos.ENTIDAD, CType(formEntidades, Form))
    End Sub

    Private Sub Camiones() Handles menuitemTablas_Camiones.Click
        ShowForm(Permisos.CAMION, CType(formCamiones, Form))
    End Sub

    Private Sub OrigenesDestinos() Handles menuitemTablas_OrigenesDestinos.Click
        ShowForm(Permisos.ORIGENDESTINO, CType(formOrigenesDestinos, Form))
    End Sub

    Private Sub UsuarioGrupoPermisos() Handles menuitemTablas_Permisos.Click
        ShowForm(Permisos.USUARIOGRUPO, CType(formUsuarioGrupoPermisos, Form))
    End Sub

    Private Sub Tarifas() Handles menuitemTablas_Tarifas.Click
        ShowForm(Permisos.TARIFA, CType(formTarifas, Form))
    End Sub

#End Region

#Region "Left Toolbar - Resto"

    Private Sub Pesadas() Handles buttonPesadas.Click
        ShowForm(Permisos.PESADA, CType(formPesadas, Form))
    End Sub

    Private Sub ResumenPesadas() Handles buttonResumenPesadas.Click
        ShowForm(Permisos.RESUMENPESADA, CType(formPesadasResumen, Form))
    End Sub

    Private Sub buttonReportes_Click(sender As Object, e As EventArgs)
        ShowForm(Permisos.REPORTE, CType(formReportes, Form))
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub labelUsuarioNombre_DoubleClick() Handles labelUsuarioNombre.MouseDown
        CerrarSesionUsuario()
    End Sub

#End Region

#Region "Extra stuff"

    Private Sub ShowForm(ByVal idPermiso As String, ByRef form As Form)
        If Permisos.VerificarPermiso(idPermiso) Then
            Me.Cursor = Cursors.WaitCursor

            CardonerSistemas.Forms.MdiChildPositionAndSizeToFit(Me, form)
            form.Show()
            If form.WindowState = FormWindowState.Minimized Then
                form.WindowState = FormWindowState.Normal
            End If
            form.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CerrarSesionUsuario()
        If MsgBox("¿Desea cerrar la sesión del Usuario actual?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
            CardonerSistemas.Forms.MdiChildCloseAll(Me)
            labelUsuarioNombre.Image = Nothing
            labelUsuarioNombre.Text = ""
            pUsuario = Nothing
            If Not formLogin.ShowDialog(Me) = DialogResult.OK Then
                Application.Exit()
                My.Application.Log.WriteEntry("La Aplicación ha finalizado porque el Usuario no ha iniciado sesión.", TraceEventType.Warning)
                Exit Sub
            End If
            formLogin.Close()
            formLogin.Dispose()
        End If
    End Sub

#End Region

End Class