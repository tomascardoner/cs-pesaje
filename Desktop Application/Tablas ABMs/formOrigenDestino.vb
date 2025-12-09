Public Class formOrigenDestino

#Region "Declarations"

    Private mdbContext As New CSPesajeContext(True)
    Private mOrigenDestinoActual As OrigenDestino

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
    Private mIsNew As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDOrigenDestino As Integer)
        mIsLoading = True
        mEditMode = EditMode
        mIsNew = IDOrigenDestino = 0

        If mIsNew Then
            mOrigenDestinoActual = New OrigenDestino
            With mOrigenDestinoActual
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.OrigenDestino.Add(mOrigenDestinoActual)
        Else
            mOrigenDestinoActual = mdbContext.OrigenDestino.Find(IDOrigenDestino)
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
            Return
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = Not mEditMode
        buttonCerrar.Visible = Not mEditMode

        textboxNombre.ReadOnly = Not mEditMode
        maskedtextboxCUIT_CUIL.ReadOnly = Not mEditMode
        textboxDomicilio.ReadOnly = Not mEditMode
        comboboxDomicilioProvincia.Enabled = mEditMode
        comboboxDomicilioLocalidad.Enabled = mEditMode
        textboxDomicilioCodigoPostal.ReadOnly = Not mEditMode
        doubletextboxLatitud.ReadOnly = Not mEditMode
        doubletextboxLongitud.ReadOnly = Not mEditMode

        textboxNotas.ReadOnly = Not mEditMode
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        pFillAndRefreshLists.Provincia(comboboxDomicilioProvincia, True)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mOrigenDestinoActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mOrigenDestinoActual
            If .IDOrigenDestino = 0 Then
                textboxIDOrigenDestino.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDOrigenDestino.Text = String.Format(.IDOrigenDestino.ToString, "G")
            End If
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            maskedtextboxCUIT_CUIL.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.CUIT_CUIL)
            textboxDomicilio.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Domicilio)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxDomicilioProvincia, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .IDProvincia, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxDomicilioLocalidad, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .IDLocalidad, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            textboxDomicilioCodigoPostal.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.CodigoPostal)
            doubletextboxLatitud.Text = CS_ValueTranslation.FromObjectDecimalToControlTextBox(.UbicacionLatitud)
            doubletextboxLongitud.Text = CS_ValueTranslation.FromObjectDecimalToControlTextBox(.UbicacionLongitud)

            ' Datos de la pestaña Notas y Auditoría
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            If .IDOrigenDestino = 0 Then
                textboxIDOrigenDestino.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDOrigenDestino.Text = String.Format(.IDOrigenDestino.ToString, "G")
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
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mOrigenDestinoActual
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .CUIT_CUIL = CS_ValueTranslation.FromControlTextBoxToObjectString(maskedtextboxCUIT_CUIL.Text)
            .Domicilio = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilio.Text)
            .IDProvincia = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxDomicilioProvincia.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            .IDLocalidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxDomicilioLocalidad.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)
            .CodigoPostal = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioCodigoPostal.Text)
            .UbicacionLatitud = CS_ValueTranslation.FromControlTextBoxToObjectDecimal(doubletextboxLatitud.Text)
            .UbicacionLongitud = CS_ValueTranslation.FromControlTextBoxToObjectDecimal(doubletextboxLongitud.Text)

            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
        End With
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

    Private Sub AbrirEnGoogleMaps_Click(sender As Object, e As EventArgs) Handles buttonAbrirEnGoogleMaps.Click
        Dim LinkString As String

        If doubletextboxLatitud.Text <> String.Empty AndAlso doubletextboxLongitud.Text <> String.Empty Then
            LinkString = CS_Parameter_System.GetString(Parametros.MAPS_GOOGLEMAPS_LOCATIONLINK)
            LinkString = LinkString.Replace(Constantes.MAPAS_LINK_PARAMETRO_ZOOM, CS_Parameter_System.GetIntegerAsByte(Parametros.MAPS_GOOGLEMAPS_ZOOMDEFAULT).ToString)
            LinkString = LinkString.Replace(Constantes.MAPAS_LINK_PARAMETRO_LATITUD, doubletextboxLatitud.DoubleValue.ToString.Replace(",", "."))
            LinkString = LinkString.Replace(Constantes.MAPAS_LINK_PARAMETRO_LONGITUD, doubletextboxLongitud.DoubleValue.ToString.Replace(",", "."))

            Process.Start(LinkString)
        End If
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub Editar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.ORIGENDESTINO_EDITAR) Then
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
            Return
        End If

        ' Verifico el Número de CUIT / CUIL
        If maskedtextboxCUIT_CUIL.Text.Trim.Length > 0 Then
            If maskedtextboxCUIT_CUIL.Text.Trim.Length < 11 Then
                MsgBox("El Número de CUIT / CUIL debe contener 11 dígitos (sin contar los guiones).", MsgBoxStyle.Information, My.Application.Info.Title)
                maskedtextboxCUIT_CUIL.Focus()
                Return
            End If
            If Not CardonerSistemas.AFIP.VerificarCUIT(maskedtextboxCUIT_CUIL.Text) Then
                MsgBox("El Número de CUIT / CUIL ingresado es incorrecto.", MsgBoxStyle.Information, My.Application.Info.Title)
                maskedtextboxCUIT_CUIL.Focus()
                Return
            End If
        End If

        ' Generar el ID del Origen-Destino nuevo
        If mIsNew Then
            Using dbcMaxID As New CSPesajeContext(True)
                If dbcMaxID.OrigenDestino.Where(Function(e) e.IDOrigenDestino <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER).Count = 0 Then
                    mOrigenDestinoActual.IDOrigenDestino = 1
                Else
                    mOrigenDestinoActual.IDOrigenDestino = dbcMaxID.OrigenDestino.Where(Function(e) e.IDOrigenDestino <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER).Max(Function(ent) ent.IDOrigenDestino) + 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mOrigenDestinoActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mOrigenDestinoActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista de OrigenesDestinos para mostrar los cambios
                pFillAndRefreshLists.OrigenesDestinosLoad()
                If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formOrigenesDestinos") Then
                    Dim formOrigenDestinos As formOrigenesDestinos = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formOrigenesDestinos"), formOrigenesDestinos)
                    formOrigenDestinos.RefreshData(mOrigenDestinoActual.IDOrigenDestino)
                    formOrigenDestinos = Nothing
                End If
            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Origen-Destino con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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

End Class