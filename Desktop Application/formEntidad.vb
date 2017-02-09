Public Class formEntidad

#Region "Declarations"
    Private mdbContext As New CSPesajeContext(True)
    Private mEntidadActual As Entidad

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
    Private mIsNew As Boolean
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDEntidad As Integer)
        mIsLoading = True
        mEditMode = EditMode
        mIsNew = IDEntidad = 0

        If mIsNew Then
            mEntidadActual = New Entidad
            With mEntidadActual
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Entidad.Add(mEntidadActual)
        Else
            mEntidadActual = mdbContext.Entidad.Find(IDEntidad)
        End If

        Me.MdiParent = formMDIMain
        CS_Form.CenterToParent(ParentForm, Me)
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
            Exit Sub
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        checkboxEsActivo.Enabled = mEditMode
        textboxNombre.ReadOnly = (mEditMode = False)
        maskedtextboxCUIT_CUIL.ReadOnly = (mEditMode = False)
        checkboxTipoTitular.Enabled = mEditMode
        checkboxTipoTransportista.Enabled = mEditMode
        checkboxTipoChofer.Enabled = mEditMode

        labelTransportista.Visible = checkboxTipoChofer.Checked
        comboboxTransportista.Visible = checkboxTipoChofer.Checked
        comboboxTransportista.Enabled = (checkboxTipoChofer.Checked And mEditMode)
        labelCamion.Visible = checkboxTipoChofer.Checked
        comboboxCamion.Visible = checkboxTipoChofer.Checked
        comboboxCamion.Enabled = (checkboxTipoChofer.Checked And mEditMode)
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Entidad(comboboxTransportista, False, True, False, False, False, True)
        CargarCamiones()
    End Sub

    Friend Sub SetAppearance()
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mEntidadActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mEntidadActual
            If .IDEntidad = 0 Then
                textboxIDEntidad.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDEntidad.Text = String.Format(.IDEntidad.ToString, "G")
            End If
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            checkboxTipoTitular.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsTitular)
            checkboxTipoTransportista.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsTransportista)
            checkboxTipoChofer.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsChofer)
            maskedtextboxCUIT_CUIL.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.CUIT_CUIL)

            If .EsChofer Then
                If .EntidadTransportista Is Nothing Then
                    comboboxTransportista.SelectedItem = Nothing
                Else
                    CS_Control_ComboBox.SetSelectedValue(comboboxTransportista, SelectedItemOptions.ValueOrFirst, .Transportista_IDEntidad)
                End If
                CargarCamiones()
                CS_Control_ComboBox.SetSelectedValue(comboboxCamion, SelectedItemOptions.ValueOrFirst, .IDCamion)
            Else
                comboboxTransportista.SelectedIndex = 0
                CargarCamiones()
            End If
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mEntidadActual
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .EsTitular = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxTipoTitular.CheckState)
            .EsTransportista = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxTipoTransportista.CheckState)
            .EsChofer = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxTipoChofer.CheckState)
            .CUIT_CUIL = CS_ValueTranslation.FromControlTextBoxToObjectString(maskedtextboxCUIT_CUIL.Text)

            If .EsChofer Then
                .Transportista_IDEntidad = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxTransportista.SelectedValue)
                .IDCamion = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCamion.SelectedValue)
            Else
                .Transportista_IDEntidad = Nothing
                .IDCamion = Nothing
            End If
        End With
    End Sub

    Friend Sub CargarCamiones()
        pFillAndRefreshLists.Camion(comboboxCamion, CInt(comboboxTransportista.SelectedValue), True, True, False, True)
    End Sub

#End Region

#Region "Controls behavior"
    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxIDEntidad.GotFocus, textboxNombre.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub MaskedTextBoxs_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxCUIT_CUIL.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

    Private Sub Chofer_Click() Handles checkboxTipoChofer.CheckedChanged
        ChangeMode()
    End Sub

    Private Sub Transportista_Cambiar(sender As Object, e As EventArgs) Handles comboboxTransportista.SelectedValueChanged
        CargarCamiones()
        comboboxCamion.Focus()
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.Entidad_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrar_Click() Handles buttonCerrar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        ' Verificar que estén todos los campos con datos coherentes
        If textboxNombre.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNombre.Focus()
            Exit Sub
        End If

        ' Verifico el Número de CUIT / CUIL
        If maskedtextboxCUIT_CUIL.Text.Trim.Length > 0 Then
            If maskedtextboxCUIT_CUIL.Text.Trim.Length < 11 Then
                MsgBox("El Número de CUIT / CUIL debe contener 11 dígitos (sin contar los guiones).", MsgBoxStyle.Information, My.Application.Info.Title)
                maskedtextboxCUIT_CUIL.Focus()
                Exit Sub
            End If
            If Not CS_AFIP.VerificarCUIT(maskedtextboxCUIT_CUIL.Text) Then
                MsgBox("El Número de CUIT / CUIL ingresado es incorrecto.", MsgBoxStyle.Information, My.Application.Info.Title)
                maskedtextboxCUIT_CUIL.Focus()
                Exit Sub
            End If
        End If

        'If checkboxTipoChofer.Checked Then
        '    If textboxEntidadTransportista.Tag Is Nothing Then
        '        MsgBox("Debe especificar el Transportista al cual pertenece el Chofer.", MsgBoxStyle.Information, My.Application.Info.Title)
        '    End If

        '    ' Ccamión
        '    If comboboxCamion.SelectedValue Is Nothing Then
        '        MsgBox("Debe especificar el Camión que utiliza el Chofer.", MsgBoxStyle.Information, My.Application.Info.Title)
        '        comboboxCamion.Focus()
        '        Exit Sub
        '    End If
        'End If

        ' Generar el ID de la Entidad nueva
        If mIsNew Then
            Using dbcMaxID As New CSPesajeContext(True)
                If dbcMaxID.Entidad.Count = 0 Then
                    mEntidadActual.IDEntidad = 1
                Else
                    mEntidadActual.IDEntidad = dbcMaxID.Entidad.Max(Function(ent) ent.IDEntidad) + 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mEntidadActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mEntidadActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista de Entidades para mostrar los cambios
                If CS_Form.MDIChild_IsLoaded(CType(formMDIMain, Form), "formEntidades") Then
                    Dim formEntidads As formEntidades = CType(CS_Form.MDIChild_GetInstance(CType(formMDIMain, Form), "formEntidades"), formEntidades)
                    formEntidads.RefreshData(mEntidadActual.IDEntidad)
                    formEntidads = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Entidad con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case Errors.Unknown
                        CS_Error.ProcessError(CType(dbuex, Exception), My.Resources.STRING_ERROR_SAVING_CHANGES)
                End Select
                Exit Sub

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CS_Error.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Exit Sub
            End Try
        End If

        Me.Close()
    End Sub

    Private Sub buttonCancelar_Click() Handles buttonCancelar.Click
        If mdbContext.ChangeTracker.HasChanges Then
            If MsgBox("Ha realizado cambios en los datos y seleccionó cancelar, los cambios se perderán." & vbCr & vbCr & "¿Confirma la pérdida de los cambios?", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
#End Region

#Region "Extra stuff"

#End Region

End Class