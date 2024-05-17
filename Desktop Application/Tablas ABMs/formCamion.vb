Public Class formCamion

#Region "Declarations"

    Private mdbContext As New CSPesajeContext(True)
    Private mCamionActual As Camion

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
    Private mIsNew As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDEntidad As Integer, ByVal IDCamion As Byte)
        mIsLoading = True
        mEditMode = EditMode
        mIsNew = IDCamion = 0

        If mIsNew Then
            mCamionActual = New Camion
            With mCamionActual
                ' Si está abierto el form de Camiones, y tiene un Transportista seleccionado, lo uso como predeterminado
                If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formCamiones") Then
                    Dim formCamions As formCamiones = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formCamiones"), formCamiones)
                    If CInt(formCamions.comboboxTransportista.ComboBox.SelectedValue) <> CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER Then
                        .IDEntidad = CInt(formCamions.comboboxTransportista.ComboBox.SelectedValue)
                    End If
                    formCamions = Nothing
                End If

                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Camion.Add(mCamionActual)
        Else
            mCamionActual = mdbContext.Camion.Find(IDEntidad, IDCamion)
        End If

        Me.MdiParent = pFormMDIMain
        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()
        Me.Show()
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Focus()

        mIsLoading = False

        ChangeMode()
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Return
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = Not mEditMode
        buttonCerrar.Visible = Not mEditMode

        checkboxEsActivo.Enabled = mEditMode
        comboboxTransportista.Enabled = mEditMode AndAlso mIsNew
        textboxNombre.ReadOnly = Not mEditMode
        textboxDominioChasis.ReadOnly = Not mEditMode
        textboxDominioChasisExtra.ReadOnly = Not mEditMode
        textboxDominioAcoplado.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        pFillAndRefreshLists.Entidad(comboboxTransportista, mCamionActual.IDEntidad, False, False, True, False, 0, False, False, False)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mCamionActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mCamionActual
            If .IDCamion = 0 Then
                textboxIDCamion.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDCamion.Text = String.Format(.IDCamion.ToString, "G")
            End If
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxTransportista, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDEntidad)
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            textboxDominioChasis.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DominioChasis)
            textboxDominioChasisExtra.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DominioChasisExtra)
            textboxDominioAcoplado.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DominioAcoplado)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mCamionActual
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
            .IDEntidad = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxTransportista.SelectedValue).Value
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .DominioChasis = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDominioChasis.Text)
            .DominioChasisExtra = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDominioChasisExtra.Text)
            .DominioAcoplado = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDominioAcoplado.Text)
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxIDCamion.GotFocus, textboxNombre.GotFocus, textboxDominioChasis.GotFocus, textboxDominioChasisExtra.GotFocus, textboxDominioAcoplado.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub Editar_Click() Handles buttonEditar.Click
        If Not Permisos.VerificarPermiso(Permisos.CAMION_EDITAR) Then
            Return
        End If
        mEditMode = True
        ChangeMode()
    End Sub

    Private Sub Cerrar_Click() Handles buttonCerrar.Click
        Me.Close()
    End Sub

    Private Sub Guardar_Click() Handles buttonGuardar.Click
        If Not VerificarDatos() Then
            Return
        End If

        ' Generar el ID del Camión nuevo
        If mIsNew Then
            Using dbcMaxID As New CSPesajeContext(True)
                If dbcMaxID.Camion.Where(Function(e) e.IDCamion <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER).Count = 0 Then
                    mCamionActual.IDCamion = 1
                Else
                    mCamionActual.IDCamion = CByte(dbcMaxID.Camion.Where(Function(e) e.IDCamion <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE).Max(Function(ent) ent.IDCamion) + 1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mCamionActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mCamionActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista de Camiones para mostrar los cambios
                If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formCamiones") Then
                    Dim formCamions As formCamiones = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formCamiones"), formCamiones)
                    formCamions.RefreshData(mCamionActual.IDEntidad, mCamionActual.IDCamion)
                    formCamions = Nothing
                End If
            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Camión con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case CardonerSistemas.Database.EntityFramework.Errors.Unknown
                        CardonerSistemas.ErrorHandler.ProcessError(CType(dbuex, Exception), My.Resources.STRING_ERROR_SAVING_CHANGES)
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

    Private Sub Cancelar_Click() Handles buttonCancelar.Click
        If mdbContext.ChangeTracker.HasChanges Then
            If MsgBox("Ha realizado cambios en los datos y seleccionó cancelar, los cambios se perderán." & vbCr & vbCr & "¿Confirma la pérdida de los cambios?", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub

#End Region

#Region "Cosas extra"

    Private Function VerificarDatos() As Boolean
        ' Verificar que estén todos los campos con datos coherentes
        If comboboxTransportista.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Transportista al cual pertenece el Camión.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxTransportista.Focus()
            Return False
        End If
        If textboxNombre.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNombre.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class