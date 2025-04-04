Public Class formUsuarioGrupo

#Region "Declarations"
    Private mdbContext As New CSPesajeContext(True)
    Private mUsuarioGrupoActual As UsuarioGrupo

    Private mIsLoading As Boolean
    Private mEditMode As Boolean
#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDUsuarioGrupo As Byte)
        mIsLoading = True
        mEditMode = EditMode

        If IDUsuarioGrupo = 0 Then
            ' Es Nuevo
            mUsuarioGrupoActual = New UsuarioGrupo
            With mUsuarioGrupoActual
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.UsuarioGrupo.Add(mUsuarioGrupoActual)
        Else
            mUsuarioGrupoActual = mdbContext.UsuarioGrupo.Find(IDUsuarioGrupo)
        End If

        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(ParentForm)
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Return
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = Not mEditMode
        buttonCerrar.Visible = Not mEditMode

        textboxNombre.ReadOnly = Not mEditMode

        textboxNotas.ReadOnly = Not mEditMode
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mUsuarioGrupoActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mUsuarioGrupoActual
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)

            ' Datos de la pestaña Notas y Auditoría
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            textboxID.Text = .IDUsuarioFormatted
            textboxFechaHoraCreacion.Text = .FechaHoraCreacionFormatted
            textboxUsuarioCreacion.Text = .UsuarioCreacionFormatted
            textboxFechaHoraModificacion.Text = .FechaHoraModificacionFormatted
            textboxUsuarioModificacion.Text = .UsuarioModificacionFormatted
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mUsuarioGrupoActual
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)

            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
        End With
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                If mEditMode Then
                    buttonGuardar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                If mEditMode Then
                    buttonCancelar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
        End Select
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNombre.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub
#End Region

#Region "Main Toolbar"

    Private Sub Editar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.USUARIOGRUPO_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub CerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub Guardar_Click() Handles buttonGuardar.Click
        If textboxNombre.Text.Trim.Length = 0 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe ingresar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNombre.Focus()
            Return
        End If

        ' Generar el ID nuevo
        If mUsuarioGrupoActual.IDUsuarioGrupo = 0 Then
            Using dbcMaxID As New CSPesajeContext(True)
                If dbcMaxID.UsuarioGrupo.Any() Then
                    mUsuarioGrupoActual.IDUsuarioGrupo = dbcMaxID.UsuarioGrupo.Max(Function(a) a.IDUsuarioGrupo) + CByte(1)
                Else
                    mUsuarioGrupoActual.IDUsuarioGrupo = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mUsuarioGrupoActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mUsuarioGrupoActual.FechaHoraModificacion = Now

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formUsuarioGrupos.RefreshData(mUsuarioGrupoActual.IDUsuarioGrupo)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Grupo de Usuarios con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                End Select
                Return

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Return
            End Try
        End If

        Me.Close()
    End Sub

#End Region

End Class