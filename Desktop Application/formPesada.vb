Public Class formPesada

#Region "Declarations"
    Private mdbContext As New CSPesajeContext(True)
    Private mPesadaActual As Pesada

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
    Private mIsNew As Boolean
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDPesada As Integer)
        mIsLoading = True
        mEditMode = EditMode
        mIsNew = IDPesada = 0

        If mIsNew Then
            mPesadaActual = New Pesada
            With mPesadaActual
                .FechaHoraInicio = DateAndTime.Now
                .FechaHoraFin = .FechaHoraInicio
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = DateAndTime.Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Pesada.Add(mPesadaActual)
        Else
            mPesadaActual = mdbContext.Pesada.Find(IDPesada)
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
        buttonEditar.Visible = Not mEditMode
        buttonCerrar.Visible = Not mEditMode

        ' Encabezado
        datetimepickerFechaInicio.Enabled = mEditMode
        datetimepickerHoraInicio.Enabled = mEditMode
        datetimepickerFechaFin.Enabled = mEditMode
        datetimepickerHoraFin.Enabled = mEditMode
        maskedtextboxComprobanteNumero.ReadOnly = Not mEditMode

        ' Producto - Planta - Cosecha
        checkboxProductoOtro.Visible = mEditMode
        comboboxProducto.Enabled = mEditMode
        textboxProducto.ReadOnly = Not mEditMode
        checkboxProductoTodos.Visible = mEditMode
        comboboxPlanta.Enabled = mEditMode
        groupboxTipo.Enabled = mEditMode
        checkboxTipoTodos.Visible = mEditMode
        comboboxCosecha.Enabled = mEditMode

        ' Titular
        checkboxTitularOtro.Visible = mEditMode
        comboboxTitular.Enabled = mEditMode
        textboxTitular.ReadOnly = Not mEditMode
        checkboxTipoTodos.Visible = mEditMode
        checkboxOrigenDestinoOtro.Visible = mEditMode
        comboboxOrigenDestino.Enabled = mEditMode
        textboxOrigenDestino.ReadOnly = Not mEditMode
        checkboxOrigenDestinoTodos.Visible = mEditMode

        ' Transporte
        checkboxTransportistaOtro.Visible = mEditMode
        comboboxTransportista.Enabled = mEditMode
        textboxTransportista.ReadOnly = Not mEditMode
        checkboxTransportistaTodos.Visible = mEditMode
        maskedtextboxTransportistaCUIT.ReadOnly = Not mEditMode
        checkboxChoferOtro.Visible = mEditMode
        comboboxChofer.Enabled = mEditMode
        textboxChofer.ReadOnly = Not mEditMode
        checkboxChoferTodos.Visible = mEditMode
        checkboxCamionOtro.Visible = mEditMode
        comboboxCamion.Enabled = mEditMode
        textboxCamion_DominioChasis.ReadOnly = Not mEditMode
        textboxCamion_DominioAcoplado.ReadOnly = Not mEditMode
        checkboxCamionTodos.Visible = mEditMode

        ' Kilogramos
        integertextboxKilogramoBruto.ReadOnly = Not mEditMode
        integertextboxKilogramoTara.ReadOnly = Not mEditMode

        ' Análisis
        doubletextboxHumedad.ReadOnly = Not mEditMode
        doubletextboxZaranda.ReadOnly = Not mEditMode
        checkboxFumigado.Enabled = mEditMode
        doubletextboxGranoVerde.ReadOnly = Not mEditMode
        doubletextboxGranoDaniado.ReadOnly = Not mEditMode
        checkboxMezclado.Enabled = mEditMode
        doubletextboxPesoHectolitrico.ReadOnly = Not mEditMode
        doubletextboxGluten.ReadOnly = Not mEditMode

        ' Notas
        textboxNotas.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        ProductoOtro()
        TitularOtro()
        OrigenDestinoOtro()
        TransportistaOtro()
        ChoferOtro()
        CamionOtro()

        pFillAndRefreshLists.Producto(comboboxProducto, mPesadaActual.IDProducto, True, False, False)
        pFillAndRefreshLists.Entidad(comboboxTransportista, mPesadaActual.Transportista_IDEntidad, False, True, False, CS_Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER, True, False, True)
    End Sub

    Friend Sub SetAppearance()
        textboxProducto.Width = comboboxProducto.Width
        textboxTitular.Width = comboboxTitular.Width
        textboxOrigenDestino.Width = comboboxOrigenDestino.Width
        textboxTransportista.Width = comboboxTransportista.Width
        textboxChofer.Width = comboboxChofer.Width
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mPesadaActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mPesadaActual
            ' Encabezado
            If mIsNew Then
                textboxIDPesada.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDPesada.Text = String.Format(.IDPesada.ToString, "G")
            End If
            datetimepickerFechaInicio.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaHoraInicio)
            datetimepickerHoraInicio.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaHoraInicio)
            datetimepickerFechaFin.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaHoraFin)
            datetimepickerHoraFin.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaHoraFin)
            maskedtextboxComprobanteNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.ComprobanteNumero)

            ' Producto - Planta - Cosecha
            CS_Control_ComboBox.SetSelectedValue(comboboxProducto, SelectedItemOptions.Value, .IDProducto)
            If .IDProducto = CS_Constants.FIELD_VALUE_OTHER_BYTE Then
                textboxProducto.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Pesada_Otro.Producto_Nombre)
            Else
                textboxProducto.Text = ""
            End If
            CS_Control_ComboBox.SetSelectedValue(comboboxPlanta, SelectedItemOptions.Value, .IDPlanta, CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)

            'checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            'textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            'checkboxTipoTitular.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsTitular)
            'checkboxTipoTransportista.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsTransportista)
            'checkboxTipoChofer.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsChofer)
            'maskedtextboxCUIT_CUIL.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.CUIT_CUIL)

            'If .EsChofer Then
            '    If .PesadaTransportista Is Nothing Then
            '        textboxPesadaTransportista.Text = ""
            '        textboxPesadaTransportista.Tag = Nothing
            '    Else
            '        textboxPesadaTransportista.Text = .PesadaTransportista.Nombre
            '        textboxPesadaTransportista.Tag = .PesadaTransportista.IDPesada
            '    End If
            '    CargarCamiones()
            '    CS_Control_ComboBox.SetSelectedValue(comboboxCamion, SelectedItemOptions.ValueOrFirst, .IDCamion)
            'Else
            '    textboxPesadaTransportista.Text = ""
            '    textboxPesadaTransportista.Tag = Nothing
            '    CargarCamiones()
            'End If
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mPesadaActual
            '.EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
            '.Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            '.EsTitular = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxTipoTitular.CheckState)
            '.EsTransportista = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxTipoTransportista.CheckState)
            '.EsChofer = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxTipoChofer.CheckState)
            '.CUIT_CUIL = CS_ValueTranslation.FromControlTextBoxToObjectString(maskedtextboxCUIT_CUIL.Text)

            'If .EsChofer Then
            '    .Transportista_IDPesada = CS_ValueTranslation.FromControlTagToObjectInteger(textboxPesadaTransportista.Tag)
            '    .IDCamion = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCamion.SelectedValue)
            'Else
            '    .Transportista_IDPesada = Nothing
            '    .IDCamion = Nothing
            'End If
        End With
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub ProductoOtro() Handles checkboxProductoOtro.CheckedChanged
        comboboxProducto.Visible = Not checkboxProductoOtro.Checked
        textboxProducto.Visible = checkboxProductoOtro.Checked
        checkboxProductoTodos.Visible = Not checkboxProductoOtro.Checked

        labelPlanta.Visible = Not checkboxProductoOtro.Checked
        comboboxPlanta.Visible = Not checkboxProductoOtro.Checked
        labelTipo.Visible = Not checkboxProductoOtro.Checked
        groupboxTipo.Visible = Not checkboxProductoOtro.Checked
        checkboxTipoTodos.Visible = Not checkboxProductoOtro.Checked
        labelCosecha.Visible = Not checkboxProductoOtro.Checked
        comboboxCosecha.Visible = Not checkboxProductoOtro.Checked
    End Sub

    Private Sub ProductoCambio() Handles comboboxProducto.SelectedValueChanged
        If Not comboboxProducto.SelectedItem Is Nothing Then
            ' Planta
            pFillAndRefreshLists.Planta(comboboxPlanta, mPesadaActual.IDPlanta, CByte(comboboxProducto.SelectedValue), False, False)
            CS_Control_ComboBox.SetSelectedValue(comboboxPlanta, SelectedItemOptions.NoneOrFirstIfUnique)

            ' Cosecha
            labelCosecha.Visible = CType(comboboxProducto.SelectedItem, Producto).UtilizaCosecha
            comboboxCosecha.Visible = CType(comboboxProducto.SelectedItem, Producto).UtilizaCosecha
            'pFillAndRefreshLists.Cosecha(comboboxCosecha, CByte(comboboxProducto.SelectedValue), mPesadaActual.IDCosecha, datetimepickerFechaInicio.Value, False, False)
            CS_Control_ComboBox.SetSelectedValue(comboboxCosecha, SelectedItemOptions.NoneOrFirstIfUnique)

            TitularCargarLista()
        End If
    End Sub

    Private Sub ProductoTodos() Handles checkboxProductoTodos.CheckedChanged
        pFillAndRefreshLists.Producto(comboboxProducto, mPesadaActual.IDProducto, Not checkboxProductoTodos.Checked, False, False)
    End Sub

    Private Sub PlantaCambio() Handles comboboxPlanta.SelectedValueChanged
        Dim Producto_PlantaActual As Producto_Planta

        If comboboxProducto.SelectedValue Is Nothing Or comboboxPlanta.SelectedValue Is Nothing Then
            radiobuttonEntrada.Visible = False
            radiobuttonSalida.Visible = False
            radiobuttonNinguno.Visible = False
        Else
            Producto_PlantaActual = mdbContext.Producto_Planta.Find(CByte(comboboxProducto.SelectedValue), CByte(comboboxPlanta.SelectedValue))
            radiobuttonEntrada.Visible = (Producto_PlantaActual.TipoEntrada = Constantes.PESADA_TIPO_PERIODICIDAD_FRECUENTE)
            radiobuttonSalida.Visible = (Producto_PlantaActual.TipoSalida = Constantes.PESADA_TIPO_PERIODICIDAD_FRECUENTE)
            radiobuttonNinguno.Visible = (Producto_PlantaActual.TipoNinguno = Constantes.PESADA_TIPO_PERIODICIDAD_FRECUENTE)
            Producto_PlantaActual = Nothing

            If radiobuttonEntrada.Visible And radiobuttonSalida.Visible = False And radiobuttonNinguno.Visible = False Then
                radiobuttonEntrada.Checked = True
            ElseIf radiobuttonEntrada.Visible = False And radiobuttonSalida.Visible And radiobuttonNinguno.Visible = False Then
                radiobuttonSalida.Checked = True
            ElseIf radiobuttonEntrada.Visible = False And radiobuttonSalida.Visible = False And radiobuttonNinguno.Visible Then
                radiobuttonNinguno.Checked = True
            Else
                radiobuttonEntrada.Checked = False
                radiobuttonSalida.Checked = False
                radiobuttonNinguno.Checked = False

                TitularCargarLista()
            End If
        End If
    End Sub

    Private Sub TipoCambio() Handles radiobuttonEntrada.CheckedChanged, radiobuttonSalida.CheckedChanged, radiobuttonNinguno.CheckedChanged
        If radiobuttonEntrada.Checked Then
            labelOrigenDestino.Text = "Origen:"
        ElseIf radiobuttonSalida.Checked Then
            labelOrigenDestino.Text = "Destino:"
        ElseIf radiobuttonNinguno.Checked Then
            labelOrigenDestino.Text = "Origen/Destino:"
        Else
            labelOrigenDestino.Text = "Origen/Destino:"
        End If
    End Sub

    Private Sub TitularCargarLista()
        If checkboxTitularTodos.Checked Or Not comboboxPlanta.Visible Then
            'pFillAndRefreshLists.Entidad(comboboxTitular, True, False, False, CS_Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER, False, False, False)
        Else
            'pFillAndRefreshLists.EntidadTitularPorPlanta(comboboxTitular, CByte(comboboxPlanta.SelectedValue), True, False, False)
        End If
    End Sub

    Private Sub TitularOtro() Handles checkboxTitularOtro.CheckedChanged
        comboboxTitular.Visible = Not checkboxTitularOtro.Checked
        textboxTitular.Visible = checkboxTitularOtro.Checked
        checkboxTitularTodos.Visible = Not checkboxTitularOtro.Checked
    End Sub

    Private Sub TitularCambio() Handles comboboxTitular.SelectedValueChanged
        If Not comboboxTitular.SelectedItem Is Nothing Then
            ' Origen / Destino
            '            pFillAndRefreshLists.OrigenDestino(comboboxOrigenDestino, CInt(comboboxTitular.SelectedValue), mPesadaActual.IDOrigenDestino, False, True)
            CS_Control_ComboBox.SetSelectedValue(comboboxOrigenDestino, SelectedItemOptions.First)
        End If
    End Sub

    Private Sub TitularTodos() Handles checkboxTitularTodos.CheckedChanged
        TitularCargarLista()
    End Sub

    Private Sub OrigenDestinoOtro() Handles checkboxOrigenDestinoOtro.CheckedChanged
        comboboxOrigenDestino.Visible = Not checkboxOrigenDestinoOtro.Checked
        textboxOrigenDestino.Visible = checkboxOrigenDestinoOtro.Checked
        checkboxOrigenDestinoTodos.Visible = Not checkboxOrigenDestinoOtro.Checked
    End Sub

    Private Sub OrigenDestinoCambio() Handles comboboxOrigenDestino.SelectedValueChanged
        If Not comboboxOrigenDestino.SelectedItem Is Nothing Then
        End If
    End Sub

    Private Sub TransportistaOtro() Handles checkboxTransportistaOtro.CheckedChanged
        comboboxTransportista.Visible = Not checkboxTransportistaOtro.Checked
        textboxTransportista.Visible = checkboxTransportistaOtro.Checked
        checkboxTransportistaTodos.Visible = Not checkboxTransportistaOtro.Checked
    End Sub

    Private Sub TransportistaCambio() Handles comboboxTransportista.SelectedValueChanged
        If Not comboboxTransportista.SelectedItem Is Nothing Then
            'pFillAndRefreshLists.Camion(comboboxCamion, CInt(comboboxTransportista.SelectedValue), True, True, False, True)
            'pFillAndRefreshLists.Entidad(comboboxChofer, False, False, True, CInt(comboboxTransportista.SelectedValue), checkboxChoferTodos.Checked, False, True)

            If CInt(comboboxTransportista.SelectedValue) = CS_Constants.FIELD_VALUE_OTHER_INTEGER Then
                CS_Control_ComboBox.SetSelectedValue(comboboxCamion, SelectedItemOptions.ValueOrFirst, CS_Constants.FIELD_VALUE_OTHER_BYTE)
                CS_Control_ComboBox.SetSelectedValue(comboboxChofer, SelectedItemOptions.ValueOrFirst, CS_Constants.FIELD_VALUE_OTHER_INTEGER)
            Else
                CS_Control_ComboBox.SetSelectedValue(comboboxCamion, SelectedItemOptions.First)
                CS_Control_ComboBox.SetSelectedValue(comboboxChofer, SelectedItemOptions.First)
            End If
        End If
    End Sub

    Private Sub TransportistaTodos() Handles checkboxTransportistaTodos.CheckedChanged
        'pFillAndRefreshLists.Entidad(comboboxProducto, False, True, False, CS_Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER, checkboxTransportistaTodos.Checked, False, True)
    End Sub

    Private Sub ChoferOtro() Handles checkboxChoferOtro.CheckedChanged
        comboboxChofer.Visible = Not checkboxChoferOtro.Checked
        textboxChofer.Visible = checkboxChoferOtro.Checked
        checkboxChoferTodos.Visible = Not checkboxChoferOtro.Checked
    End Sub

    Private Sub ChoferCambio() Handles comboboxChofer.SelectedValueChanged
        If comboboxChofer.SelectedIndex > 0 Then
            If CType(comboboxChofer.SelectedItem, Entidad).IDCamion.HasValue Then
                CS_Control_ComboBox.SetSelectedValue(comboboxCamion, SelectedItemOptions.ValueOrFirst, CType(comboboxChofer.SelectedItem, Entidad).IDCamion)
            End If
        End If
    End Sub

    Private Sub ChoferTodos() Handles checkboxChoferTodos.CheckedChanged
        If checkboxChoferTodos.Checked Then
            '    pFillAndRefreshLists.Entidad(comboboxChofer, False, False, True, CS_Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER, False, False, True)
            'Else
            '    pFillAndRefreshLists.Entidad(comboboxChofer, False, False, True, CInt(comboboxTransportista.SelectedValue), True, False, True)
        End If
    End Sub

    Private Sub CamionOtro() Handles checkboxCamionOtro.CheckedChanged
        comboboxCamion.Visible = Not checkboxCamionOtro.Checked
        textboxCamion_DominioChasis.Visible = checkboxCamionOtro.Checked
        labelCamion_DominioAcoplado.Visible = checkboxCamionOtro.Checked
        textboxCamion_DominioAcoplado.Visible = checkboxCamionOtro.Checked
        checkboxCamionTodos.Visible = Not checkboxCamionOtro.Checked
    End Sub

    Private Sub CamionCambio() Handles comboboxCamion.SelectedValueChanged
        'If CByte(comboboxCamion.SelectedValue) = CS_Constants.FIELD_VALUE_OTHER_BYTE Then
        '    comboboxCamion.Width = textboxCamion.Left - comboboxCamion.Left - TEXTBOX_OTRO_SEPARACION
        '    textboxCamion.Visible = True
        'Else
        '    comboboxCamion.Width = COMBOBOX_WIDTH
        '    textboxCamion.Visible = False
        'End If
    End Sub

    Private Sub CamionTodos() Handles checkboxCamionTodos.CheckedChanged
        'pFillAndRefreshLists.Camion(comboboxCamion, CInt(comboboxTransportista.SelectedValue), True, True, False, True)
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxProducto.GotFocus, textboxTitular.GotFocus, textboxOrigenDestino.GotFocus, textboxTransportista.GotFocus, textboxChofer.GotFocus, textboxCamion_DominioChasis.GotFocus, textboxCamion_DominioAcoplado.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.Pesada_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrar_Click() Handles buttonCerrar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        ' Verificar que estén todos los campos con datos coherentes

        ' Generar el ID de la Pesada nueva
        If mIsNew Then
            Using dbcMaxID As New CSPesajeContext(True)
                If dbcMaxID.Pesada.Count = 0 Then
                    mPesadaActual.IDPesada = 1
                Else
                    mPesadaActual.IDPesada = dbcMaxID.Pesada.Max(Function(ent) ent.IDPesada) + 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mPesadaActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPesadaActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista de Pesadaes para mostrar los cambios
                If CS_Form.MDIChild_IsLoaded(CType(formMDIMain, Form), "formPesadas") Then
                    Dim formPesadas As formPesadas = CType(CS_Form.MDIChild_GetInstance(CType(formMDIMain, Form), "formPesadas"), formPesadas)
                    formPesadas.RefreshData(mPesadaActual.IDPesada)
                    formPesadas = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Pesada con el mismo Número.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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

    Private Sub ProductoTodos(sender As Object, e As EventArgs) Handles checkboxProductoTodos.CheckedChanged

    End Sub
End Class