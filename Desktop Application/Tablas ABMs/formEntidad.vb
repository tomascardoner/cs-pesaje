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
                .UsoFrecuente = True
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

        Me.MdiParent = pFormMDIMain
        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()
        Me.Show()
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Focus()
        textboxNombre.Focus()

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
        textboxDomicilio.ReadOnly = (mEditMode = False)
        comboboxDomicilioProvincia.Enabled = mEditMode
        comboboxDomicilioLocalidad.Enabled = mEditMode
        textboxDomicilioCodigoPostal.ReadOnly = (mEditMode = False)
        checkboxTipoTitular.Enabled = mEditMode
        checkboxTipoTransportista.Enabled = mEditMode
        checkboxTipoChofer.Enabled = mEditMode

        labelTransportista.Visible = checkboxTipoChofer.Checked
        comboboxTransportista.Visible = checkboxTipoChofer.Checked
        comboboxTransportista.Enabled = (checkboxTipoChofer.Checked And mEditMode)
        labelCamion.Visible = checkboxTipoChofer.Checked
        comboboxCamion.Visible = checkboxTipoChofer.Checked
        comboboxCamion.Enabled = (checkboxTipoChofer.Checked And mEditMode)

        textboxNotas.ReadOnly = (mEditMode = False)
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Provincia(comboboxDomicilioProvincia, True)
        pFillAndRefreshLists.Entidad(comboboxTransportista, mEntidadActual.Transportista_IDEntidad, False, False, True, False, 0, False, False, False, True)
        CargarCamiones()
    End Sub

    Friend Sub SetAppearance()
        If (Not mEntidadActual.EsTitular) Or mEditMode Then
            tabcontrolMain.HideTabPageByName(tabpageOrigenesDestinos.Name)
        Else
            tabcontrolMain.ShowTabPageByName(tabpageOrigenesDestinos.Name)
        End If
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
            maskedtextboxCUIT_CUIL.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.CUIT_CUIL)
            textboxDomicilio.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Domicilio)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxDomicilioProvincia, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .IDProvincia, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxDomicilioLocalidad, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .IDLocalidad, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            textboxDomicilioCodigoPostal.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.CodigoPostal)

            checkboxTipoTitular.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsTitular)
            checkboxTipoTransportista.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsTransportista)
            checkboxTipoChofer.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsChofer)

            If .EsChofer Then
                CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxTransportista, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .Transportista_IDEntidad)
                CargarCamiones()
                CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxCamion, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IDCamion)
            Else
                comboboxTransportista.SelectedIndex = 0
                CargarCamiones()
            End If

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            If .IDEntidad = 0 Then
                textboxIDEntidad.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDEntidad.Text = String.Format(.IDEntidad.ToString, "G")
            End If
            textboxFechaHoraCreacion.Text = .FechaHoraCreacion.ToShortDateString & " " & .FechaHoraCreacion.ToShortTimeString
            If .UsuarioCreacion Is Nothing Then
                textboxUsuarioCreacion.Text = ""
            Else
                textboxUsuarioCreacion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.UsuarioCreacion.Descripcion)
            End If
            textboxFechaHoraModificacion.Text = .FechaHoraModificacion.ToShortDateString & " " & .FechaHoraModificacion.ToShortTimeString
            If .UsuarioModificacion Is Nothing Then
                textboxUsuarioModificacion.Text = ""
            Else
                textboxUsuarioModificacion.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.UsuarioModificacion.Descripcion)
            End If

            If mEditMode Then
                datagridviewOrigenesDestinosNoIncluidos.DataSource = Nothing
                datagridviewOrigenesDestinosIncluidos.DataSource = Nothing
            Else
                Refresh_OrigenesDestinos()
            End If
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mEntidadActual
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .CUIT_CUIL = CS_ValueTranslation.FromControlTextBoxToObjectString(maskedtextboxCUIT_CUIL.Text)
            .Domicilio = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilio.Text)
            .IDProvincia = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxDomicilioProvincia.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            .IDLocalidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxDomicilioLocalidad.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            .CodigoPostal = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioCodigoPostal.Text)

            .EsTitular = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxTipoTitular.CheckState)
            .EsTransportista = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxTipoTransportista.CheckState)
            .EsChofer = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxTipoChofer.CheckState)

            If .EsChofer Then
                .Transportista_IDEntidad = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxTransportista.SelectedValue)
                .IDCamion = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCamion.SelectedValue)
            Else
                .Transportista_IDEntidad = Nothing
                .IDCamion = Nothing
            End If

            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
        End With
    End Sub

    Friend Sub Refresh_OrigenesDestinos()
        Dim listOrigenesDestinosNoIncluidos As List(Of OrigenDestino)
        Dim listOrigenesDestinosTodos As List(Of OrigenDestino)
        Dim listOrigenesDestinosIncluidos As List(Of OrigenDestino)

        Me.Cursor = Cursors.WaitCursor

        Using dbContext As New CSPesajeContext(True)
            listOrigenesDestinosIncluidos = (From od In dbContext.OrigenDestino
                                             Join e_od In dbContext.Entidad_OrigenDestino On od.IDOrigenDestino Equals e_od.IDOrigenDestino
                                             Where e_od.IDEntidad = mEntidadActual.IDEntidad And od.EsActivo And od.IDOrigenDestino <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER
                                             Order By od.Nombre
                                             Select od).ToList

            listOrigenesDestinosTodos = (From od In dbContext.OrigenDestino
                                         Where od.EsActivo And od.IDOrigenDestino <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER
                                         Order By od.Nombre
                                         Select od).ToList

            listOrigenesDestinosNoIncluidos = (From odt In listOrigenesDestinosTodos
                                               Where Not listOrigenesDestinosIncluidos.Any(Function(od) od.IDOrigenDestino = odt.IDOrigenDestino)).ToList

        End Using

        bindingsourceOrigenesDestinosInlcuidos.DataSource = listOrigenesDestinosIncluidos
        bindingsourceOrigenesDestinosNoInlcuidos.DataSource = listOrigenesDestinosNoIncluidos

        Me.Cursor = Cursors.Default
    End Sub

    Friend Sub CargarCamiones()
        pFillAndRefreshLists.Camion(comboboxCamion, mEntidadActual.IDCamion, False, CInt(comboboxTransportista.SelectedValue), True, True, False, True)
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                If mEditMode Then
                    If Me.ActiveControl IsNot textboxNotas Then
                        buttonGuardar.PerformClick()
                    End If
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNombre.GotFocus, textboxDomicilio.GotFocus, textboxDomicilioCodigoPostal.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub MaskedTextBoxs_GotFocus(sender As Object, e As EventArgs) Handles maskedtextboxCUIT_CUIL.GotFocus
        CType(sender, MaskedTextBox).SelectAll()
    End Sub

    Private Sub DomicilioProvincia_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboboxDomicilioProvincia.SelectedValueChanged
        If comboboxDomicilioProvincia.SelectedValue Is Nothing Then
            pFillAndRefreshLists.Localidad(comboboxDomicilioLocalidad, 0, True)
            comboboxDomicilioLocalidad.SelectedIndex = 0
        Else
            pFillAndRefreshLists.Localidad(comboboxDomicilioLocalidad, CByte(comboboxDomicilioProvincia.SelectedValue), True)
            If CByte(comboboxDomicilioProvincia.SelectedValue) = CS_Parameter_System.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID) Then
                CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxDomicilioLocalidad, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, CS_Parameter_System.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID))
            End If
        End If
    End Sub

    Private Sub DomicilioLocalidad_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboboxDomicilioLocalidad.SelectedValueChanged
        If comboboxDomicilioLocalidad.SelectedValue IsNot Nothing Then
            textboxDomicilioCodigoPostal.Text = CType(comboboxDomicilioLocalidad.SelectedItem, Localidad).CodigoPostal
        End If
    End Sub

    Private Sub Chofer_Click() Handles checkboxTipoChofer.CheckedChanged
        ChangeMode()
    End Sub

    Private Sub Transportista_Cambiar(sender As Object, e As EventArgs) Handles comboboxTransportista.SelectedValueChanged
        CargarCamiones()
        comboboxCamion.Focus()
    End Sub

    Private Sub OrigenDestinoAgregar() Handles buttonOrigenesDestinosAgregar.Click
        If mEntidadActual.EsTitular And Not mEditMode Then
            If datagridviewOrigenesDestinosNoIncluidos.CurrentRow Is Nothing Then
                MsgBox("No hay ningún Origen-Destino no incluído para agregar.", vbInformation, My.Application.Info.Title)
            Else
                Using dbContext As New CSPesajeContext(True)
                    Dim Entidad_OrigenDestino_Nueva As New Entidad_OrigenDestino
                    With Entidad_OrigenDestino_Nueva
                        .IDOrigenDestino = CType(datagridviewOrigenesDestinosNoIncluidos.CurrentRow.DataBoundItem, OrigenDestino).IDOrigenDestino
                        .IDUsuarioCreacion = pUsuario.IDUsuario
                        .FechaHoraCreacion = Now
                        .IDUsuarioModificacion = pUsuario.IDUsuario
                        .FechaHoraModificacion = Entidad_OrigenDestino_Nueva.FechaHoraCreacion
                        .EsActivo = True
                    End With

                    Dim EntidadActual As Entidad
                    EntidadActual = dbContext.Entidad.Find(mEntidadActual.IDEntidad)
                    EntidadActual.Entidades_OrigenesDestinos.Add(Entidad_OrigenDestino_Nueva)

                    dbContext.SaveChanges()
                End Using

                Refresh_OrigenesDestinos()
            End If
        End If
    End Sub

    Private Sub OrigenDestinoEliminar() Handles buttonOrigenesDestinosEliminar.Click
        If mEntidadActual.EsTitular And Not mEditMode Then
            If datagridviewOrigenesDestinosIncluidos.CurrentRow Is Nothing Then
                MsgBox("No hay ningún Origen-Destino incluído para eliminar.", vbInformation, My.Application.Info.Title)
            Else
                Using dbContext As New CSPesajeContext(True)
                    Dim Entidad_OrigenDestino_Eliminar As New Entidad_OrigenDestino
                    Entidad_OrigenDestino_Eliminar = dbContext.Entidad_OrigenDestino.Find(mEntidadActual.IDEntidad, CType(datagridviewOrigenesDestinosIncluidos.CurrentRow.DataBoundItem, OrigenDestino).IDOrigenDestino)
                    dbContext.Entidad_OrigenDestino.Remove(Entidad_OrigenDestino_Eliminar)
                    dbContext.SaveChanges()
                End Using

                Refresh_OrigenesDestinos()
            End If
        End If
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub Editar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.ENTIDAD_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub Cerrar_Click() Handles buttonCerrar.Click
        Me.Close()
    End Sub

    Private Sub Guardar_Click() Handles buttonGuardar.Click
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
            If Not CardonerSistemas.AFIP.VerificarCUIT(maskedtextboxCUIT_CUIL.Text) Then
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
                If dbcMaxID.Entidad.Where(Function(e) e.IDEntidad <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER).Count = 0 Then
                    mEntidadActual.IDEntidad = 1
                Else
                    mEntidadActual.IDEntidad = dbcMaxID.Entidad.Where(Function(e) e.IDEntidad <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER).Max(Function(ent) ent.IDEntidad) + 1
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
                If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formEntidades") Then
                    Dim formEntidads As formEntidades = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formEntidades"), formEntidades)
                    formEntidads.RefreshData(mEntidadActual.IDEntidad)
                    formEntidads = Nothing
                End If
            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Entidad con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case CardonerSistemas.Database.EntityFramework.Errors.Unknown
                        CardonerSistemas.ErrorHandler.ProcessError(CType(dbuex, Exception), My.Resources.STRING_ERROR_SAVING_CHANGES)
                End Select
                Exit Sub
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Exit Sub
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

End Class