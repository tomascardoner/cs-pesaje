Public Class formMDIMain

#Region "Declarations"
    Friend Form_ClientSize As Size
    Private AFIP_TicketAcceso_Homo As String
#End Region

#Region "Form stuff"
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cambio el puntero del mouse para indicar que la aplicación está iniciando
        Me.Cursor = Cursors.AppStarting

        ' Deshabilito el Form principal hasta que se cierre el SplashScreen
        Me.Enabled = False

        Me.Text = My.Application.Info.Title

        menuitemAyuda_AcercaDe.Text = String.Format("&Acerca de {0}...", My.Application.Info.Title)

        textboxKilogramo.Visible = pBalanzaConeccionHabilitada
    End Sub

    Private Sub formMDIMain_Resize() Handles Me.Resize
        If Not Me.WindowState = FormWindowState.Minimized Then

            'OBTENGO LAS MEDIDAS DEL CLIENT AREA DEL FORM MDI
            Form_ClientSize = New Size(Me.ClientSize.Width - toolstripMain.Width - My.Settings.MDIFormMargin, Me.ClientSize.Height - menustripMain.Height - statusstripMain.Height - My.Settings.MDIFormMargin)

            'HAGO UN RESIZE DE TODOS LOS CHILDS QUE ESTÉN ABIERTOS
            For Each FormCurrent As Form In Me.MdiChildren
                If FormCurrent.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable Then
                    If FormCurrent.Name = "formComprobante" Then
                        CS_Form.MDIChild_CenterToClientArea(Me, FormCurrent, Form_ClientSize)
                    Else
                        CS_Form.MDIChild_PositionAndSizeToFit(Me, FormCurrent)
                    End If
                Else
                    CS_Form.MDIChild_CenterToClientArea(Me, FormCurrent, Form_ClientSize)
                End If
            Next
        End If
    End Sub

    Private Sub MDIMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not (e.CloseReason = CloseReason.ApplicationExitCall Or e.CloseReason = CloseReason.TaskManagerClosing Or e.CloseReason = CloseReason.WindowsShutDown) Then
            If MsgBox("¿Desea salir de la aplicación?", CType(MsgBoxStyle.Information + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.No Then
                e.Cancel = True
                Exit Sub
            End If
        End If
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

#Region "Menu Debug"
    Private Sub Debug_ShowTestForm() Handles menuitemDebug_ShowTestForm.Click
        formTest.ShowDialog()
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
            Me.ActiveMdiChild.Size = Form_ClientSize
        End If
    End Sub

    Private Sub menuitemVentana_CerrarTodas_Click() Handles menuitemVentana_CerrarTodas.Click
        CS_Form.MDIChild_CloseAll(Me)
    End Sub
#End Region

#Region "Menu Ayuda"
    Private Sub menuitemAyuda_AcercaDe_Click(sender As Object, e As EventArgs) Handles menuitemAyuda_AcercaDe.Click
        formAboutBox.ShowDialog(Me)
    End Sub

#End Region

#Region "Left Toolbar - Tablas"
    Private Sub Entidades() Handles menuitemTablas_Entidades.Click
        If Permisos.VerificarPermiso(Permisos.ENTIDAD) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formEntidades, Form))
            formEntidades.Show()
            If formEntidades.WindowState = FormWindowState.Minimized Then
                formEntidades.WindowState = FormWindowState.Normal
            End If
            formEntidades.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Camiones() Handles menuitemTablas_Camiones.Click
        If Permisos.VerificarPermiso(Permisos.CAMION) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formCamiones, Form))
            formCamiones.Show()
            If formCamiones.WindowState = FormWindowState.Minimized Then
                formCamiones.WindowState = FormWindowState.Normal
            End If
            formCamiones.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub UsuarioGrupoPermisos() Handles menuitemTablas_Permisos.Click
        If Permisos.VerificarPermiso(Permisos.USUARIOGRUPO) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formUsuarioGrupoPermisos, Form))
            formUsuarioGrupoPermisos.Show()
            If formUsuarioGrupoPermisos.WindowState = FormWindowState.Minimized Then
                formUsuarioGrupoPermisos.WindowState = FormWindowState.Normal
            End If
            formUsuarioGrupoPermisos.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region

#Region "Left Toolbar - Pesadas"
    Private Sub Pesadas() Handles buttonPesadas.Click
        If Permisos.VerificarPermiso(Permisos.PESADA) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formPesadas, Form))
            formPesadas.Show()
            If formPesadas.WindowState = FormWindowState.Minimized Then
                formPesadas.WindowState = FormWindowState.Normal
            End If
            formPesadas.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Left Toolbar - Reportes"
    Private Sub buttonReportes_Click(sender As Object, e As EventArgs)
        If Permisos.VerificarPermiso(Permisos.REPORTE) Then
            Me.Cursor = Cursors.WaitCursor

            CS_Form.MDIChild_PositionAndSizeToFit(Me, CType(formReportes, Form))
            formReportes.Show()
            If formReportes.WindowState = FormWindowState.Minimized Then
                formReportes.WindowState = FormWindowState.Normal
            End If
            formReportes.Focus()

            Me.Cursor = Cursors.Default
        End If
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub labelUsuarioNombre_DoubleClick() Handles labelUsuarioNombre.MouseDown
        CerrarSesionUsuario()
    End Sub
#End Region

#Region "Extra stuff"
    Private Sub CerrarSesionUsuario()
        If MsgBox("¿Desea cerrar la sesión del Usuario actual?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
            CS_Form.MDIChild_CloseAll(Me)
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