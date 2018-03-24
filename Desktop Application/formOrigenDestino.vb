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

        textboxNombre.ReadOnly = (mEditMode = False)
        textboxDomicilio.ReadOnly = (mEditMode = False)
        comboboxDomicilioProvincia.Enabled = mEditMode
        comboboxDomicilioLocalidad.Enabled = mEditMode
        textboxDomicilioCodigoPostal.ReadOnly = (mEditMode = False)
        doubletextboxLatitud.ReadOnly = (mEditMode = False)
        doubletextboxLongitud.ReadOnly = (mEditMode = False)
        textboxNotas.ReadOnly = (mEditMode = False)
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Provincia(comboboxDomicilioProvincia, True)
    End Sub

    Friend Sub SetAppearance()
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
            textboxDomicilio.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Domicilio)
            CS_Control_ComboBox.SetSelectedValue(comboboxDomicilioProvincia, SelectedItemOptions.Value, .IDProvincia, FIELD_VALUE_NOTSPECIFIED_BYTE)
            CS_Control_ComboBox.SetSelectedValue(comboboxDomicilioLocalidad, SelectedItemOptions.Value, .IDLocalidad, FIELD_VALUE_NOTSPECIFIED_SHORT)
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
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .Domicilio = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilio.Text)
            .IDProvincia = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxDomicilioProvincia.SelectedValue, FIELD_VALUE_NOTSPECIFIED_BYTE)
            .IDLocalidad = CS_ValueTranslation.FromControlComboBoxToObjectShort(comboboxDomicilioLocalidad.SelectedValue, FIELD_VALUE_NOTSPECIFIED_SHORT)
            .CodigoPostal = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDomicilioCodigoPostal.Text)
            .UbicacionLatitud = CS_ValueTranslation.FromControlTextBoxToObjectDecimal(doubletextboxLatitud.Text)
            .UbicacionLongitud = CS_ValueTranslation.FromControlTextBoxToObjectDecimal(doubletextboxLongitud.Text)
        End With
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNombre.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub DomicilioProvincia_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboboxDomicilioProvincia.SelectedValueChanged
        If comboboxDomicilioProvincia.SelectedValue Is Nothing Then
            pFillAndRefreshLists.Localidad(comboboxDomicilioLocalidad, 0, True)
            comboboxDomicilioLocalidad.SelectedIndex = 0
        Else
            pFillAndRefreshLists.Localidad(comboboxDomicilioLocalidad, CByte(comboboxDomicilioProvincia.SelectedValue), True)
            If CByte(comboboxDomicilioProvincia.SelectedValue) = CS_Parameter.GetIntegerAsByte(Parametros.DEFAULT_PROVINCIA_ID) Then
                CS_Control_ComboBox.SetSelectedValue(comboboxDomicilioLocalidad, SelectedItemOptions.ValueOrFirst, CS_Parameter.GetIntegerAsShort(Parametros.DEFAULT_LOCALIDAD_ID))
            End If
        End If
    End Sub

    Private Sub DomicilioLocalidad_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboboxDomicilioLocalidad.SelectedValueChanged
        If Not comboboxDomicilioLocalidad.SelectedValue Is Nothing Then
            textboxDomicilioCodigoPostal.Text = CType(comboboxDomicilioLocalidad.SelectedItem, Localidad).CodigoPostal
        End If
    End Sub

    Private Sub buttonAbrirEnGoogleMaps_Click(sender As Object, e As EventArgs) Handles buttonAbrirEnGoogleMaps.Click
        Dim LinkString As String

        If doubletextboxLatitud.Text <> "" And doubletextboxLongitud.Text <> "" Then
            LinkString = CS_Parameter.GetString(Parametros.MAPS_GOOGLEMAPS_LOCATIONLINK)
            LinkString = LinkString.Replace(Constantes.MAPAS_LINK_PARAMETRO_ZOOM, CS_Parameter.GetIntegerAsByte(Parametros.MAPS_GOOGLEMAPS_ZOOMDEFAULT).ToString)
            LinkString = LinkString.Replace(Constantes.MAPAS_LINK_PARAMETRO_LATITUD, doubletextboxLatitud.DoubleValue.ToString.Replace(",", "."))
            LinkString = LinkString.Replace(Constantes.MAPAS_LINK_PARAMETRO_LONGITUD, doubletextboxLongitud.DoubleValue.ToString.Replace(",", "."))

            Process.Start(LinkString)
        End If
    End Sub

    Private Sub buttonAbrirEnGoogleEarth_Click(sender As Object, e As EventArgs) Handles buttonAbrirEnGoogleEarth.Click
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.OrigenDestino_EDITAR) Then
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

        ' Generar el ID del Origen-Destino nuevo
        If mIsNew Then
            Using dbcMaxID As New CSPesajeContext(True)
                If dbcMaxID.OrigenDestino.Where(Function(e) e.IDOrigenDestino <> CS_Constants.FIELD_VALUE_OTHER_INTEGER).Count = 0 Then
                    mOrigenDestinoActual.IDOrigenDestino = 1
                Else
                    mOrigenDestinoActual.IDOrigenDestino = CByte(dbcMaxID.OrigenDestino.Where(Function(e) e.IDOrigenDestino <> CS_Constants.FIELD_VALUE_OTHER_INTEGER).Max(Function(ent) ent.IDOrigenDestino) + 1)
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
                If CS_Form.MDIChild_IsLoaded(CType(formMDIMain, Form), "formOrigenesDestinos") Then
                    Dim formOrigenDestinos As formOrigenesDestinos = CType(CS_Form.MDIChild_GetInstance(CType(formMDIMain, Form), "formOrigenesDestinos"), formOrigenesDestinos)
                    formOrigenDestinos.RefreshData(mOrigenDestinoActual.IDOrigenDestino)
                    formOrigenDestinos = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Origen-Destino con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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