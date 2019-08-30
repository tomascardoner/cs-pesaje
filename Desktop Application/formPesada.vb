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
                .EsVerificado = False
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = DateAndTime.Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Pesada.Add(mPesadaActual)
        Else
            mPesadaActual = mdbContext.Pesada.Find(IDPesada)
        End If

        'Me.MdiParent = pFormMDIMain
        CS_Form.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()
        'If Me.WindowState = FormWindowState.Minimized Then
        '    Me.WindowState = FormWindowState.Normal
        'End If
        'Me.Focus()
        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(formPesadas)
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
        buttonFechaHoraInicioAhora.Visible = mEditMode
        datetimepickerFechaFin.Enabled = mEditMode
        datetimepickerHoraFin.Enabled = mEditMode
        buttonFechaHoraFinAhora.Visible = mEditMode
        maskedtextboxComprobanteNumero.ReadOnly = Not mEditMode
        maskedtextboxComprobanteNumeroTercero.ReadOnly = Not mEditMode

        ' Producto - Planta - Cosecha
        checkboxProductoOtro.Visible = mEditMode
        comboboxProducto.Enabled = mEditMode
        textboxProducto.ReadOnly = Not mEditMode
        checkboxProductoTodos.Visible = mEditMode
        comboboxPlanta.Enabled = mEditMode
        groupboxTipo.Enabled = mEditMode
        checkboxTipoTodos.Visible = mEditMode
        comboboxCosecha.Enabled = mEditMode
        checkboxCosechaTodos.Visible = mEditMode

        ' Titular
        checkboxTitularOtro.Visible = mEditMode
        comboboxTitular.Enabled = mEditMode
        textboxTitular.ReadOnly = Not mEditMode
        checkboxTitularTodos.Visible = mEditMode
        checkboxOrigenOtro.Visible = ((radiobuttonEntrada.Checked Or radiobuttonNinguno.Checked) And mEditMode)
        comboboxOrigen.Visible = (radiobuttonEntrada.Checked Or radiobuttonNinguno.Checked) And Not checkboxOrigenOtro.Checked
        comboboxOrigen.Enabled = mEditMode
        textboxOrigen.ReadOnly = Not mEditMode
        textboxOrigen.Visible = (radiobuttonEntrada.Checked Or radiobuttonNinguno.Checked) And checkboxOrigenOtro.Checked
        checkboxOrigenTodos.Visible = (mEditMode And (radiobuttonEntrada.Checked Or radiobuttonNinguno.Checked) And Not checkboxOrigenOtro.Checked)
        checkboxDestinoOtro.Visible = ((radiobuttonSalida.Checked Or radiobuttonNinguno.Checked) And mEditMode)
        comboboxDestino.Visible = (radiobuttonSalida.Checked Or radiobuttonNinguno.Checked) And Not checkboxDestinoOtro.Checked
        comboboxDestino.Enabled = mEditMode
        textboxDestino.ReadOnly = Not mEditMode
        textboxDestino.Visible = (radiobuttonSalida.Checked Or radiobuttonNinguno.Checked) And checkboxDestinoOtro.Checked
        checkboxDestinoTodos.Visible = (mEditMode And (radiobuttonSalida.Checked Or radiobuttonNinguno.Checked) And Not checkboxDestinoOtro.Checked)

        ' Transporte
        checkboxTransportistaOtro.Visible = mEditMode
        comboboxTransportista.Enabled = mEditMode
        textboxTransportista.ReadOnly = Not mEditMode
        checkboxTransportistaTodos.Visible = mEditMode
        maskedtextboxTransportistaCUIT.ReadOnly = Not (mEditMode And checkboxTransportistaOtro.Checked)
        checkboxChoferOtro.Visible = mEditMode
        comboboxChofer.Enabled = mEditMode
        textboxChofer.ReadOnly = Not mEditMode
        checkboxChoferTodos.Visible = mEditMode
        maskedtextboxChoferCUIT_CUIL.ReadOnly = Not (mEditMode And checkboxChoferOtro.Checked)
        checkboxCamionOtro.Visible = mEditMode
        comboboxCamion.Enabled = mEditMode
        textboxCamion_DominioChasis.ReadOnly = Not mEditMode
        textboxCamion_DominioChasisExtra.ReadOnly = Not mEditMode
        textboxCamion_DominioAcoplado.ReadOnly = Not mEditMode
        integertextboxKilometro.ReadOnly = Not mEditMode

        ' Kilogramos
        integertextboxKilogramoBruto.ReadOnly = Not mEditMode
        integertextboxKilogramoTara.ReadOnly = Not mEditMode

        ' Análisis
        doubletextboxHumedad.ReadOnly = Not mEditMode
        doubletextboxZaranda.ReadOnly = Not mEditMode
        checkboxFumigado.Enabled = mEditMode
        integertextboxGranoVerde.ReadOnly = Not mEditMode
        integertextboxGranoDaniado.ReadOnly = Not mEditMode
        checkboxMezclado.Enabled = mEditMode
        doubletextboxPesoHectolitrico.ReadOnly = Not mEditMode
        doubletextboxGluten.ReadOnly = Not mEditMode

        ' Notas
        textboxNotas.ReadOnly = Not mEditMode

        ' Extras
        checkboxEsVerificado.Enabled = mEditMode
        checkboxEsActivo.Enabled = mEditMode
        checkboxMermaVolatilAplica.Enabled = mEditMode
        checkboxMermaHumedadAplica.Enabled = mEditMode
        checkboxMermaZarandaAplica.Enabled = mEditMode
        checkboxParitariaAplica.Enabled = mEditMode
        checkboxSecadoAplica.Enabled = mEditMode
        checkboxZarandeoAplica.Enabled = mEditMode
        checkboxFumigadoAplica.Enabled = mEditMode
        checkboxMezclaAplica.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        ProductoOtro()
        TitularOtro()
        OrigenOtro()
        DestinoOtro()
        TransportistaOtro()
        ChoferOtro()
        CamionOtro()

        pFillAndRefreshLists.Producto(comboboxProducto, mPesadaActual.IDProducto, False, True, False, False)
        pFillAndRefreshLists.Entidad(comboboxTransportista, mPesadaActual.Transportista_IDEntidad, False, False, True, False, CS_Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER, True, False, False, True)

        If Permisos.VerificarPermiso(Permisos.PESADA_MOSTRAR_EXTRAS, False) Then
            tabcontrolNotasExtras.ShowTabPageByName(tabpageExtras.Name)
        Else
            tabcontrolNotasExtras.HideTabPageByName(tabpageExtras.Name)
        End If

        groupboxControl.Visible = (Permisos.VerificarPermiso(Permisos.PESADA_MOSTRAR_VERIFICADO, False) And Permisos.VerificarPermiso(Permisos.PESADA_MOSTRAR_ACTIVO, False))
        labelEsVerificado.Visible = Permisos.VerificarPermiso(Permisos.PESADA_MOSTRAR_VERIFICADO, False)
        checkboxEsVerificado.Visible = Permisos.VerificarPermiso(Permisos.PESADA_MOSTRAR_VERIFICADO, False)
        labelEsActivo.Visible = Permisos.VerificarPermiso(Permisos.PESADA_MOSTRAR_ACTIVO, False)
        checkboxEsActivo.Visible = Permisos.VerificarPermiso(Permisos.PESADA_MOSTRAR_ACTIVO, False)

        groupboxMermasAplica.Visible = Permisos.VerificarPermiso(Permisos.PESADA_MOSTRAR_MERMASAPLICA, False)

        groupboxTarifasAplica.Visible = Permisos.VerificarPermiso(Permisos.PESADA_MOSTRAR_TARIFASASAPLICA, False)

        buttonObtenerKilogramosBrutos.Visible = (pBalanzaConeccionHabilitada And mEditMode)
        buttonObtenerKilogramosTara.Visible = (pBalanzaConeccionHabilitada And mEditMode)
    End Sub

    Friend Sub SetAppearance()
        textboxProducto.Width = comboboxProducto.Width
        textboxTitular.Width = comboboxTitular.Width
        textboxOrigen.Width = comboboxOrigen.Width
        textboxDestino.Width = comboboxDestino.Width
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
                textboxIDPesada.Text = Microsoft.VisualBasic.Strings.Format(.IDPesada, "N0")
            End If
            datetimepickerFechaInicio.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaHoraInicio)
            datetimepickerHoraInicio.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaHoraInicio)
            datetimepickerFechaFin.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaHoraFin)
            datetimepickerHoraFin.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.FechaHoraFin)
            maskedtextboxComprobanteNumero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.ComprobanteNumero)
            maskedtextboxComprobanteNumeroTercero.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.ComprobanteNumeroTercero)

            ' Producto - Planta - Tipo - Cosecha
            If .IDProducto = CS_Constants.FIELD_VALUE_OTHER_BYTE Then
                checkboxProductoOtro.Checked = True
                If .Pesada_Otro Is Nothing Then
                    textboxProducto.Text = ""
                Else
                    textboxProducto.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Pesada_Otro.Producto_Nombre)
                End If
            Else
                CS_ComboBox.SetSelectedValue(comboboxProducto, SelectedItemOptions.Value, .IDProducto)
                textboxProducto.Text = ""
            End If
            CS_ComboBox.SetSelectedValue(comboboxPlanta, SelectedItemOptions.Value, .IDPlanta, CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            TipoTodos()
            Select Case .Tipo
                Case Constantes.PESADA_TIPO_ENTRADA
                    radiobuttonEntrada.Checked = True
                    radiobuttonEntrada.Visible = True
                Case Constantes.PESADA_TIPO_SALIDA
                    radiobuttonSalida.Checked = True
                    radiobuttonSalida.Visible = True
                Case Constantes.PESADA_TIPO_NINGUNA
                    radiobuttonNinguno.Checked = True
                    radiobuttonNinguno.Visible = True
            End Select
            CS_ComboBox.SetSelectedValue(comboboxCosecha, SelectedItemOptions.Value, .IDCosecha, CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)

            ' Titular - Origen - Destino
            If .Titular_IDEntidad = CS_Constants.FIELD_VALUE_OTHER_INTEGER Then
                checkboxTitularOtro.Checked = True
                If .Pesada_Otro Is Nothing Then
                    textboxTitular.Text = ""
                Else
                    textboxTitular.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Pesada_Otro.Titular_Nombre)
                End If
            Else
                CS_ComboBox.SetSelectedValue(comboboxTitular, SelectedItemOptions.Value, .Titular_IDEntidad)
                textboxTitular.Text = ""
            End If
            If .IDOrigen = CS_Constants.FIELD_VALUE_OTHER_INTEGER Then
                checkboxOrigenOtro.Checked = True
                If .Pesada_Otro Is Nothing Then
                    textboxOrigen.Text = ""
                Else
                    textboxOrigen.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Pesada_Otro.Origen_Nombre)
                End If
            Else
                CS_ComboBox.SetSelectedValue(comboboxOrigen, SelectedItemOptions.ValueOrFirst, .IDOrigen)
                textboxOrigen.Text = ""
            End If
            If .IDDestino = CS_Constants.FIELD_VALUE_OTHER_INTEGER Then
                checkboxDestinoOtro.Checked = True
                If .Pesada_Otro Is Nothing Then
                    textboxDestino.Text = ""
                Else
                    textboxDestino.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Pesada_Otro.Destino_Nombre)
                End If
            Else
                CS_ComboBox.SetSelectedValue(comboboxDestino, SelectedItemOptions.ValueOrFirst, .IDDestino)
                textboxDestino.Text = ""
            End If

            ' Transporte
            If .Transportista_IDEntidad = CS_Constants.FIELD_VALUE_OTHER_INTEGER Then
                checkboxTransportistaOtro.Checked = True
                If .Pesada_Otro Is Nothing Then
                    textboxTransportista.Text = ""
                    maskedtextboxTransportistaCUIT.Text = ""
                Else
                    textboxTransportista.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Pesada_Otro.Transportista_Nombre)
                    maskedtextboxTransportistaCUIT.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Pesada_Otro.Transportista_CUIT)
                End If
            Else
                textboxTransportista.Text = ""
                maskedtextboxTransportistaCUIT.Text = ""
                CS_ComboBox.SetSelectedValue(comboboxTransportista, SelectedItemOptions.ValueOrFirst, .Transportista_IDEntidad)
            End If
            If .Chofer_IDEntidad = CS_Constants.FIELD_VALUE_OTHER_INTEGER Then
                checkboxChoferOtro.Checked = True
                If .Pesada_Otro Is Nothing Then
                    textboxChofer.Text = ""
                    maskedtextboxChoferCUIT_CUIL.Text = ""
                Else
                    textboxChofer.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Pesada_Otro.Chofer_Nombre)
                    maskedtextboxChoferCUIT_CUIL.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Pesada_Otro.Chofer_CUIT_CUIL)
                End If
            Else
                textboxChofer.Text = ""
                maskedtextboxChoferCUIT_CUIL.Text = ""
                CS_ComboBox.SetSelectedValue(comboboxChofer, SelectedItemOptions.ValueOrFirst, .Chofer_IDEntidad)
            End If
            If .IDCamion = CS_Constants.FIELD_VALUE_OTHER_BYTE Then
                checkboxCamionOtro.Checked = True
                If .Pesada_Otro Is Nothing Then
                    textboxCamion_DominioChasis.Text = ""
                    textboxCamion_DominioChasisExtra.Text = ""
                    textboxCamion_DominioAcoplado.Text = ""
                Else
                    textboxCamion_DominioChasis.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Pesada_Otro.Camion_DominioChasis)
                    textboxCamion_DominioChasisExtra.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Pesada_Otro.Camion_DominioChasisExtra)
                    textboxCamion_DominioAcoplado.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Pesada_Otro.Camion_DominioAcoplado)
                End If
            Else
                textboxCamion_DominioChasis.Text = ""
                textboxCamion_DominioChasisExtra.Text = ""
                textboxCamion_DominioAcoplado.Text = ""
                CS_ComboBox.SetSelectedValue(comboboxCamion, SelectedItemOptions.ValueOrFirst, .IDCamion)
            End If
            integertextboxKilometro.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.Kilometro)

            ' Kilogramos
            integertextboxKilogramoBruto.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.KilogramoBruto)
            integertextboxKilogramoTara.Text = CS_ValueTranslation.FromObjectIntegerToControlTextBox(.KilogramoTara)

            ' Análisis
            If .Pesada_Analisis Is Nothing Then
                doubletextboxHumedad.Text = ""
                doubletextboxZaranda.Text = ""
                checkboxFumigado.CheckState = CheckState.Unchecked
                integertextboxGranoVerde.Text = ""
                integertextboxGranoDaniado.Text = ""
                checkboxMezclado.CheckState = CheckState.Unchecked
                doubletextboxPesoHectolitrico.Text = ""
                doubletextboxGluten.Text = ""

                checkboxMermaVolatilAplica.CheckState = CheckState.Checked
                checkboxMermaHumedadAplica.CheckState = CheckState.Checked
                checkboxMermaZarandaAplica.CheckState = CheckState.Checked
            Else
                doubletextboxHumedad.Text = CS_ValueTranslation.FromObjectDecimalToControlTextBox(.Pesada_Analisis.Humedad)
                doubletextboxZaranda.Text = CS_ValueTranslation.FromObjectDecimalToControlTextBox(.Pesada_Analisis.Zaranda)
                checkboxFumigado.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Pesada_Analisis.Fumigado)
                integertextboxGranoVerde.Text = CS_ValueTranslation.FromObjectDecimalToControlTextBox(.Pesada_Analisis.GranoVerde)
                integertextboxGranoDaniado.Text = CS_ValueTranslation.FromObjectDecimalToControlTextBox(.Pesada_Analisis.GranoDaniado)
                checkboxMezclado.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Pesada_Analisis.Mezclado)
                doubletextboxPesoHectolitrico.Text = CS_ValueTranslation.FromObjectDecimalToControlTextBox(.Pesada_Analisis.PesoHectolitrico)
                doubletextboxGluten.Text = CS_ValueTranslation.FromObjectDecimalToControlTextBox(.Pesada_Analisis.Gluten)

                checkboxMermaVolatilAplica.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Pesada_Analisis.MermaVolatilAplica)
                checkboxMermaHumedadAplica.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Pesada_Analisis.MermaHumedadAplica)
                checkboxMermaZarandaAplica.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Pesada_Analisis.MermaZarandaAplica)
            End If

            ' Tarifas
            If .Pesada_Acondicionamiento Is Nothing Then
                checkboxParitariaAplica.CheckState = CheckState.Checked
                checkboxSecadoAplica.CheckState = CheckState.Checked
                checkboxZarandeoAplica.CheckState = CheckState.Checked
                checkboxFumigadoAplica.CheckState = CheckState.Checked
                checkboxMezclaAplica.CheckState = CheckState.Checked
            Else
                checkboxParitariaAplica.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Pesada_Acondicionamiento.ParitariaAplica)
                checkboxSecadoAplica.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Pesada_Acondicionamiento.SecadoAplica)
                checkboxZarandeoAplica.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Pesada_Acondicionamiento.ZarandeoAplica)
                checkboxFumigadoAplica.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Pesada_Acondicionamiento.FumigadoAplica)
                checkboxMezclaAplica.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.Pesada_Acondicionamiento.MezcladoAplica)
            End If

            ' Notas
            textboxNotas.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Notas)

            ' EsVerificado y EsActivo
            checkboxEsVerificado.Checked = .EsVerificado
            checkboxEsActivo.Checked = .EsActivo
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mPesadaActual
            ' Si hay algún item Otro especificado, me aseguro que exista el objeto correspondiente
            If checkboxProductoOtro.Checked Or checkboxTitularOtro.Checked Or checkboxOrigenOtro.Checked Or checkboxDestinoOtro.Checked Or checkboxTransportistaOtro.Checked Or checkboxChoferOtro.Checked Or checkboxCamionOtro.Checked Then
                If .Pesada_Otro Is Nothing Then
                    .Pesada_Otro = New Pesada_Otro
                End If
            End If

            ' Encabezado
            .FechaHoraInicio = CS_ValueTranslation.FromControlTwoDateTimePickerToObjectDate(datetimepickerFechaInicio.Value, datetimepickerHoraInicio.Value).Value
            .FechaHoraFin = CS_ValueTranslation.FromControlTwoDateTimePickerToObjectDate(datetimepickerFechaFin.Value, datetimepickerHoraFin.Value).Value
            .ComprobanteNumero = CS_ValueTranslation.FromObjectStringToControlTextBox(maskedtextboxComprobanteNumero.Text)
            .ComprobanteNumeroTercero = CS_ValueTranslation.FromObjectStringToControlTextBox(maskedtextboxComprobanteNumeroTercero.Text)

            ' Producto - Planta - Cosecha
            If checkboxProductoOtro.Checked Then
                .IDProducto = CS_Constants.FIELD_VALUE_OTHER_BYTE
                .Pesada_Otro.Producto_Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxProducto.Text)
            Else
                .IDProducto = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxProducto.SelectedValue).Value
                If Not .Pesada_Otro Is Nothing Then
                    .Pesada_Otro.Producto_Nombre = ""
                End If
            End If
            .IDPlanta = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxPlanta.SelectedValue)
            If radiobuttonEntrada.Checked Then
                .Tipo = Constantes.PESADA_TIPO_ENTRADA
            ElseIf radiobuttonSalida.Checked Then
                .Tipo = Constantes.PESADA_TIPO_SALIDA
            ElseIf radiobuttonNinguno.Checked Then
                .Tipo = Constantes.PESADA_TIPO_NINGUNA
            End If
            .IDCosecha = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCosecha.SelectedValue)

            ' Titular - Origen - Destino
            If checkboxTitularOtro.Checked Then
                .Titular_IDEntidad = CS_Constants.FIELD_VALUE_OTHER_INTEGER
                .Pesada_Otro.Titular_Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxTitular.Text)
            Else
                .Titular_IDEntidad = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxTitular.SelectedValue).Value
                If Not .Pesada_Otro Is Nothing Then
                    .Pesada_Otro.Titular_Nombre = ""
                End If
            End If
            If labelOrigen.Visible Then
                If checkboxOrigenOtro.Checked Then
                    .IDOrigen = CS_Constants.FIELD_VALUE_OTHER_INTEGER
                    .Pesada_Otro.Origen_Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxOrigen.Text)
                Else
                    .IDOrigen = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxOrigen.SelectedValue)
                    If Not .Pesada_Otro Is Nothing Then
                        .Pesada_Otro.Origen_Nombre = ""
                    End If
                End If
            Else
                .IDOrigen = Nothing
                If checkboxOrigenOtro.Checked Then
                    If Not .Pesada_Otro Is Nothing Then
                        .Pesada_Otro.Origen_Nombre = ""
                    End If
                End If
            End If

            If labelDestino.Visible Then
                If checkboxDestinoOtro.Checked Then
                    .IDDestino = CS_Constants.FIELD_VALUE_OTHER_INTEGER
                    .Pesada_Otro.Destino_Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDestino.Text)
                Else
                    .IDDestino = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxDestino.SelectedValue)
                    If Not .Pesada_Otro Is Nothing Then
                        .Pesada_Otro.Destino_Nombre = ""
                    End If
                End If
            Else
                .IDDestino = Nothing
                If checkboxDestinoOtro.Checked Then
                    If Not .Pesada_Otro Is Nothing Then
                        .Pesada_Otro.Destino_Nombre = ""
                    End If
                End If
            End If

            ' Transporte
            If checkboxTransportistaOtro.Checked Then
                .Transportista_IDEntidad = CS_Constants.FIELD_VALUE_OTHER_INTEGER
                .Pesada_Otro.Transportista_Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxTransportista.Text)
                .Pesada_Otro.Transportista_CUIT = CS_ValueTranslation.FromControlTextBoxToObjectString(maskedtextboxTransportistaCUIT.Text)
            Else
                .Transportista_IDEntidad = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxTransportista.SelectedValue)
                If Not .Pesada_Otro Is Nothing Then
                    .Pesada_Otro.Transportista_Nombre = ""
                    .Pesada_Otro.Transportista_CUIT = ""
                End If
            End If
            If checkboxChoferOtro.Checked Then
                .Chofer_IDEntidad = CS_Constants.FIELD_VALUE_OTHER_INTEGER
                .Pesada_Otro.Chofer_Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxChofer.Text)
                .Pesada_Otro.Chofer_CUIT_CUIL = CS_ValueTranslation.FromControlTextBoxToObjectString(maskedtextboxChoferCUIT_CUIL.Text)
            Else
                .Chofer_IDEntidad = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxChofer.SelectedValue)
                If Not .Pesada_Otro Is Nothing Then
                    .Pesada_Otro.Chofer_Nombre = ""
                    .Pesada_Otro.Chofer_CUIT_CUIL = ""
                End If
            End If
            If checkboxCamionOtro.Checked Then
                .Camion_IDEntidad = CS_Constants.FIELD_VALUE_OTHER_INTEGER
                .IDCamion = CS_Constants.FIELD_VALUE_OTHER_BYTE
                .Pesada_Otro.Camion_DominioChasis = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCamion_DominioChasis.Text)
                .Pesada_Otro.Camion_DominioChasisExtra = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCamion_DominioChasisExtra.Text)
                .Pesada_Otro.Camion_DominioAcoplado = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxCamion_DominioAcoplado.Text)
            Else
                .Camion_IDEntidad = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxTransportista.SelectedValue)
                .IDCamion = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCamion.SelectedValue)
                If Not .Pesada_Otro Is Nothing Then
                    .Pesada_Otro.Camion_DominioChasis = ""
                    .Pesada_Otro.Camion_DominioChasisExtra = ""
                    .Pesada_Otro.Camion_DominioAcoplado = ""
                End If
            End If
            .Kilometro = CS_ValueTranslation.FromControlTextBoxToObjectShort(integertextboxKilometro.Text)

            ' Kilogramos
            .KilogramoBruto = CS_ValueTranslation.FromControlTextBoxToObjectInteger(integertextboxKilogramoBruto.Text)
            .KilogramoTara = CS_ValueTranslation.FromControlTextBoxToObjectInteger(integertextboxKilogramoTara.Text)
            If integertextboxKilogramoBruto.IsNull Or integertextboxKilogramoTara.IsNull Then
                .KilogramoNeto = Nothing
            Else
                .KilogramoNeto = CInt(integertextboxKilogramoBruto.IntegerValue - integertextboxKilogramoTara.IntegerValue)
            End If

            ' Análisis
            If doubletextboxHumedad.DoubleValue > 0 Or doubletextboxZaranda.DoubleValue > 0 Or checkboxFumigado.Checked Or integertextboxGranoVerde.IntegerValue > 0 Or integertextboxGranoDaniado.IntegerValue > 0 Or checkboxMezclado.Checked Or doubletextboxPesoHectolitrico.DoubleValue > 0 Or doubletextboxGluten.DoubleValue > 0 Then
                If .Pesada_Analisis Is Nothing Then
                    .Pesada_Analisis = New Pesada_Analisis
                End If
                .Pesada_Analisis.Humedad = CS_ValueTranslation.FromControlTextBoxToObjectDecimal(doubletextboxHumedad.Text)
                .Pesada_Analisis.Zaranda = CS_ValueTranslation.FromControlTextBoxToObjectDecimal(doubletextboxZaranda.Text)
                .Pesada_Analisis.Fumigado = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxFumigado.CheckState)
                .Pesada_Analisis.GranoVerde = CS_ValueTranslation.FromControlTextBoxToObjectByte(integertextboxGranoVerde.Text)
                .Pesada_Analisis.GranoDaniado = CS_ValueTranslation.FromControlTextBoxToObjectByte(integertextboxGranoDaniado.Text)
                .Pesada_Analisis.Mezclado = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxMezclado.CheckState)
                .Pesada_Analisis.PesoHectolitrico = CS_ValueTranslation.FromControlTextBoxToObjectDecimal(doubletextboxPesoHectolitrico.Text)
                .Pesada_Analisis.Gluten = CS_ValueTranslation.FromControlTextBoxToObjectDecimal(doubletextboxGluten.Text)

                .Pesada_Analisis.MermaVolatilAplica = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxMermaVolatilAplica.CheckState)
                .Pesada_Analisis.MermaHumedadAplica = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxMermaHumedadAplica.CheckState)
                .Pesada_Analisis.MermaZarandaAplica = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxMermaZarandaAplica.CheckState)
            Else
                If Not .Pesada_Analisis Is Nothing Then
                    mdbContext.Pesada_Analisis.Remove(.Pesada_Analisis)
                End If
            End If

            ' Tarifas
            If mPesadaActual.CorrespondeAcondicionamiento Then
                If .Pesada_Acondicionamiento Is Nothing Then
                    .Pesada_Acondicionamiento = New Pesada_Acondicionamiento
                End If
                .Pesada_Acondicionamiento.ParitariaAplica = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxParitariaAplica.CheckState)
                .Pesada_Acondicionamiento.SecadoAplica = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxSecadoAplica.CheckState)
                .Pesada_Acondicionamiento.ZarandeoAplica = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxZarandeoAplica.CheckState)
                .Pesada_Acondicionamiento.FumigadoAplica = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxFumigadoAplica.CheckState)
                .Pesada_Acondicionamiento.MezcladoAplica = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxMezclaAplica.CheckState)
            Else
                If Not .Pesada_Acondicionamiento Is Nothing Then
                    mdbContext.Pesada_Acondicionamiento.Remove(.Pesada_Acondicionamiento)
                End If
            End If

            ' Notas
            .Notas = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNotas.Text)

            ' EsVerificado y EsActivo
            .EsVerificado = checkboxEsVerificado.Checked
            .EsActivo = checkboxEsActivo.Checked

            ' Otros
            If Not (checkboxProductoOtro.Checked Or checkboxTitularOtro.Checked Or checkboxOrigenOtro.Checked Or checkboxDestinoOtro.Checked Or checkboxTransportistaOtro.Checked Or checkboxChoferOtro.Checked Or checkboxCamionOtro.Checked) Then
                If Not .Pesada_Otro Is Nothing Then
                    mdbContext.Pesada_Otro.Remove(.Pesada_Otro)
                End If
            End If
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

    Private Sub FechaInicioCambio() Handles datetimepickerFechaInicio.ValueChanged
        CosechaTodos()
    End Sub

    Private Sub HoraInicioCambio() Handles datetimepickerHoraInicio.ValueChanged
        datetimepickerFechaInicio.Value = New Date(datetimepickerFechaInicio.Value.Year, datetimepickerFechaInicio.Value.Month, datetimepickerFechaInicio.Value.Day, datetimepickerHoraInicio.Value.Hour, datetimepickerHoraInicio.Value.Minute, datetimepickerHoraInicio.Value.Second)
    End Sub

    Private Sub FechaHoraInicioAhora() Handles buttonFechaHoraInicioAhora.Click
        datetimepickerFechaInicio.Value = DateAndTime.Now
        datetimepickerHoraInicio.Value = datetimepickerFechaInicio.Value
    End Sub

    Private Sub HoraFinCambio() Handles datetimepickerHoraFin.ValueChanged
        datetimepickerFechaFin.Value = New Date(datetimepickerFechaFin.Value.Year, datetimepickerFechaFin.Value.Month, datetimepickerFechaFin.Value.Day, datetimepickerHoraFin.Value.Hour, datetimepickerHoraFin.Value.Minute, datetimepickerHoraFin.Value.Second)
    End Sub

    Private Sub FechaHoraFinAhora() Handles buttonFechaHoraFinAhora.Click
        datetimepickerFechaFin.Value = DateAndTime.Now
        datetimepickerHoraFin.Value = datetimepickerFechaFin.Value
    End Sub

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
        checkboxCosechaTodos.Visible = Not checkboxProductoOtro.Checked

        If checkboxProductoOtro.Checked Then
            textboxProducto.Focus()
        Else
            comboboxProducto.Focus()
        End If
    End Sub

    Private Sub ProductoCambio() Handles comboboxProducto.SelectedValueChanged
        If Not comboboxProducto.SelectedItem Is Nothing Then
            ' Planta
            pFillAndRefreshLists.Planta(comboboxPlanta, mPesadaActual.IDPlanta, CByte(comboboxProducto.SelectedValue), False, False)
            CS_ComboBox.SetSelectedValue(comboboxPlanta, SelectedItemOptions.NoneOrFirstIfUnique)

            ' Cosecha
            labelCosecha.Visible = CType(comboboxProducto.SelectedItem, Producto).UtilizaCosecha
            comboboxCosecha.Visible = CType(comboboxProducto.SelectedItem, Producto).UtilizaCosecha
            checkboxCosechaTodos.Visible = CType(comboboxProducto.SelectedItem, Producto).UtilizaCosecha
            CosechaTodos()

            TitularCargarLista()
        End If
    End Sub

    Private Sub ProductoTodos() Handles checkboxProductoTodos.CheckedChanged
        pFillAndRefreshLists.Producto(comboboxProducto, mPesadaActual.IDProducto, False, Not checkboxProductoTodos.Checked, False, False)
        comboboxProducto.Focus()
    End Sub

    Private Sub PlantaCambio() Handles comboboxPlanta.SelectedValueChanged
        TipoTodos()
        TitularCargarLista()
    End Sub

    Private Sub TipoCambio() Handles radiobuttonEntrada.CheckedChanged, radiobuttonSalida.CheckedChanged, radiobuttonNinguno.CheckedChanged
        Dim IDOrigenSave As Integer
        Dim IDDestinoSave As Integer

        IDOrigenSave = CInt(comboboxOrigen.SelectedValue)
        IDDestinoSave = CInt(comboboxDestino.SelectedValue)

        TitularCargarLista()

        OrigenOtro()
        DestinoOtro()

        CS_ComboBox.SetSelectedValue(comboboxOrigen, SelectedItemOptions.ValueOrFirst, IDOrigenSave)
        CS_ComboBox.SetSelectedValue(comboboxDestino, SelectedItemOptions.ValueOrFirst, IDDestinoSave)
    End Sub

    Private Sub TipoTodos() Handles checkboxTipoTodos.CheckedChanged
        Dim Producto_PlantaActual As Producto_Planta

        If comboboxProducto.SelectedValue Is Nothing Or comboboxPlanta.SelectedValue Is Nothing Then
            radiobuttonEntrada.Visible = False
            radiobuttonSalida.Visible = False
            radiobuttonNinguno.Visible = False
        Else
            Producto_PlantaActual = mdbContext.Producto_Planta.Find(CByte(comboboxProducto.SelectedValue), CByte(comboboxPlanta.SelectedValue))
            If checkboxTipoTodos.Checked Then
                radiobuttonEntrada.Visible = (Producto_PlantaActual.TipoEntrada <> Constantes.PESADA_TIPO_PERIODICIDAD_NUNCA)
                radiobuttonSalida.Visible = (Producto_PlantaActual.TipoSalida <> Constantes.PESADA_TIPO_PERIODICIDAD_NUNCA)
                radiobuttonNinguno.Visible = (Producto_PlantaActual.TipoNinguno <> Constantes.PESADA_TIPO_PERIODICIDAD_NUNCA)
            Else
                radiobuttonEntrada.Visible = (Producto_PlantaActual.TipoEntrada = Constantes.PESADA_TIPO_PERIODICIDAD_FRECUENTE)
                radiobuttonSalida.Visible = (Producto_PlantaActual.TipoSalida = Constantes.PESADA_TIPO_PERIODICIDAD_FRECUENTE)
                radiobuttonNinguno.Visible = (Producto_PlantaActual.TipoNinguno = Constantes.PESADA_TIPO_PERIODICIDAD_FRECUENTE)
            End If
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
            End If
        End If

        groupboxTipo.Focus()
    End Sub

    Private Sub CosechaTodos() Handles checkboxCosechaTodos.CheckedChanged
        If Not mPesadaActual Is Nothing Then
            If checkboxCosechaTodos.Checked Then
                pFillAndRefreshLists.Cosecha(comboboxCosecha, mPesadaActual.IDCosecha, CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, CS_Constants.FIELD_VALUE_NOTSPECIFIED_DATE, False, False, True)
            Else
                pFillAndRefreshLists.Cosecha(comboboxCosecha, mPesadaActual.IDCosecha, CByte(comboboxProducto.SelectedValue), datetimepickerFechaInicio.Value, False, False, True)
            End If
            CS_ComboBox.SetSelectedValue(comboboxCosecha, SelectedItemOptions.NoneOrFirstIfUnique)
        End If
    End Sub

    Private Sub TitularCargarLista()
        If checkboxTitularTodos.Checked Or Not comboboxPlanta.Visible Then
            pFillAndRefreshLists.Entidad(comboboxTitular, mPesadaActual.Titular_IDEntidad, False, True, False, False, CS_Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER, False, False, False, False)
        Else
            pFillAndRefreshLists.EntidadTitularPorProductoPlanta(comboboxTitular, mPesadaActual.Titular_IDEntidad, CByte(comboboxProducto.SelectedValue), CByte(comboboxPlanta.SelectedValue), CStr(Microsoft.VisualBasic.Switch(radiobuttonEntrada.Checked, Constantes.PESADA_TIPO_ENTRADA, radiobuttonSalida.Checked, Constantes.PESADA_TIPO_SALIDA, radiobuttonNinguno.Checked, Constantes.PESADA_TIPO_NINGUNA)), True, False, False)
        End If
    End Sub

    Private Sub TitularOtro() Handles checkboxTitularOtro.CheckedChanged
        comboboxTitular.Visible = Not checkboxTitularOtro.Checked
        textboxTitular.Visible = checkboxTitularOtro.Checked
        checkboxTitularTodos.Visible = Not checkboxTitularOtro.Checked

        If checkboxTitularOtro.Checked Then
            textboxTitular.Focus()
        Else
            comboboxTitular.Focus()
        End If
    End Sub

    Private Sub TitularCambio() Handles comboboxTitular.SelectedValueChanged
        If Not comboboxTitular.SelectedItem Is Nothing Then
            ' Origen - Destino
            pFillAndRefreshLists.OrigenDestino(comboboxOrigen, mPesadaActual.IDOrigen, False, CInt(comboboxTitular.SelectedValue), False, False, True)
            CS_ComboBox.SetSelectedValue(comboboxOrigen, SelectedItemOptions.First)
            pFillAndRefreshLists.OrigenDestino(comboboxDestino, mPesadaActual.IDDestino, False, CInt(comboboxTitular.SelectedValue), False, False, True)
            CS_ComboBox.SetSelectedValue(comboboxDestino, SelectedItemOptions.First)
        End If
    End Sub

    Private Sub TitularTodos() Handles checkboxTitularTodos.CheckedChanged
        TitularCargarLista()
        comboboxTitular.Focus()
    End Sub

    Private Sub OrigenOtro() Handles checkboxOrigenOtro.CheckedChanged
        labelOrigen.Visible = (radiobuttonEntrada.Checked Or radiobuttonNinguno.Checked)
        checkboxOrigenOtro.Visible = ((radiobuttonEntrada.Checked Or radiobuttonNinguno.Checked) And mEditMode)
        comboboxOrigen.Visible = (radiobuttonEntrada.Checked Or radiobuttonNinguno.Checked) And Not checkboxOrigenOtro.Checked
        textboxOrigen.Visible = (radiobuttonEntrada.Checked Or radiobuttonNinguno.Checked) And checkboxOrigenOtro.Checked
        checkboxOrigenTodos.Visible = (radiobuttonEntrada.Checked Or radiobuttonNinguno.Checked) And Not checkboxOrigenOtro.Checked

        If checkboxOrigenOtro.Checked Then
            textboxOrigen.Focus()
        Else
            comboboxOrigen.Focus()
        End If
    End Sub

    Private Sub OrigenCambio() Handles comboboxOrigen.SelectedValueChanged
        If Not comboboxOrigen.SelectedItem Is Nothing Then
        End If
    End Sub

    Private Sub DestinoOtro() Handles checkboxDestinoOtro.CheckedChanged
        labelDestino.Visible = (radiobuttonSalida.Checked Or radiobuttonNinguno.Checked)
        checkboxDestinoOtro.Visible = ((radiobuttonSalida.Checked Or radiobuttonNinguno.Checked) And mEditMode)
        comboboxDestino.Visible = (radiobuttonSalida.Checked Or radiobuttonNinguno.Checked) And Not checkboxDestinoOtro.Checked
        textboxDestino.Visible = (radiobuttonSalida.Checked Or radiobuttonNinguno.Checked) And checkboxDestinoOtro.Checked
        checkboxDestinoTodos.Visible = (radiobuttonSalida.Checked Or radiobuttonNinguno.Checked) And Not checkboxDestinoOtro.Checked

        If checkboxDestinoOtro.Checked Then
            textboxDestino.Focus()
        Else
            comboboxDestino.Focus()
        End If
    End Sub

    Private Sub DestinoCambio() Handles comboboxDestino.SelectedValueChanged
        If Not comboboxDestino.SelectedItem Is Nothing Then
        End If
    End Sub

    Private Sub TransportistaOtro() Handles checkboxTransportistaOtro.CheckedChanged
        comboboxTransportista.Visible = Not checkboxTransportistaOtro.Checked
        textboxTransportista.Visible = checkboxTransportistaOtro.Checked
        checkboxTransportistaTodos.Visible = Not checkboxTransportistaOtro.Checked
        maskedtextboxTransportistaCUIT.ReadOnly = Not (mEditMode And checkboxTransportistaOtro.Checked)

        If checkboxTransportistaOtro.Checked Then
            maskedtextboxTransportistaCUIT.Text = ""
        Else
            If Not comboboxTransportista.SelectedItem Is Nothing Then
                maskedtextboxTransportistaCUIT.Text = CType(comboboxTransportista.SelectedItem, Entidad).CUIT_CUIL
            Else
                maskedtextboxTransportistaCUIT.Text = ""
            End If
        End If

        If checkboxTransportistaOtro.Checked Then
            textboxTransportista.Focus()
        Else
            comboboxTransportista.Focus()
        End If
    End Sub

    Private Sub TransportistaCambio() Handles comboboxTransportista.SelectedValueChanged
        If Not comboboxTransportista.SelectedItem Is Nothing Then
            maskedtextboxTransportistaCUIT.Text = CType(comboboxTransportista.SelectedItem, Entidad).CUIT_CUIL
            pFillAndRefreshLists.Camion(comboboxCamion, mPesadaActual.IDCamion, False, CInt(comboboxTransportista.SelectedValue), True, True, False, True)
            ChoferTodos()

            If CInt(comboboxTransportista.SelectedValue) = CS_Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER Then
                CS_ComboBox.SetSelectedValue(comboboxCamion, SelectedItemOptions.First)
                CS_ComboBox.SetSelectedValue(comboboxChofer, SelectedItemOptions.First)
            Else
                CS_ComboBox.SetSelectedValue(comboboxCamion, SelectedItemOptions.First)
                CS_ComboBox.SetSelectedValue(comboboxChofer, SelectedItemOptions.First)
            End If
        End If
    End Sub

    Private Sub TransportistaTodos() Handles checkboxTransportistaTodos.CheckedChanged
        pFillAndRefreshLists.Entidad(comboboxTransportista, mPesadaActual.Transportista_IDEntidad, False, False, True, False, CS_Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER, checkboxTransportistaTodos.Checked, False, False, True)
        comboboxTransportista.Focus()
    End Sub

    Private Sub ChoferOtro() Handles checkboxChoferOtro.CheckedChanged
        comboboxChofer.Visible = Not checkboxChoferOtro.Checked
        textboxChofer.Visible = checkboxChoferOtro.Checked
        checkboxChoferTodos.Visible = Not checkboxChoferOtro.Checked
        maskedtextboxChoferCUIT_CUIL.ReadOnly = Not (mEditMode And checkboxChoferOtro.Checked)

        If checkboxChoferOtro.Checked Then
            maskedtextboxChoferCUIT_CUIL.Text = ""
            textboxChofer.Focus()
        Else
            If Not comboboxChofer.SelectedItem Is Nothing Then
                maskedtextboxChoferCUIT_CUIL.Text = CType(comboboxChofer.SelectedItem, Entidad).CUIT_CUIL
            Else
                maskedtextboxChoferCUIT_CUIL.Text = ""
            End If
            comboboxChofer.Focus()
        End If
    End Sub

    Private Sub ChoferCambio() Handles comboboxChofer.SelectedValueChanged
        If Not comboboxChofer.SelectedItem Is Nothing Then
            maskedtextboxChoferCUIT_CUIL.Text = CType(comboboxChofer.SelectedItem, Entidad).CUIT_CUIL
            If CType(comboboxChofer.SelectedItem, Entidad).IDCamion.HasValue Then
                CS_ComboBox.SetSelectedValue(comboboxCamion, SelectedItemOptions.ValueOrFirst, CType(comboboxChofer.SelectedItem, Entidad).IDCamion)
            End If
        End If
    End Sub

    Private Sub ChoferTodos() Handles checkboxChoferTodos.CheckedChanged
        If checkboxChoferTodos.Checked Then
            pFillAndRefreshLists.Entidad(comboboxChofer, mPesadaActual.Chofer_IDEntidad, False, False, False, True, CS_Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER, False, False, False, True)
        Else
            pFillAndRefreshLists.Entidad(comboboxChofer, mPesadaActual.Chofer_IDEntidad, False, False, False, True, CInt(comboboxTransportista.SelectedValue), False, False, False, True)
        End If
        comboboxChofer.Focus()
    End Sub

    Private Sub CamionOtro() Handles checkboxCamionOtro.CheckedChanged
        comboboxCamion.Visible = Not checkboxCamionOtro.Checked
        textboxCamion_DominioChasis.Visible = checkboxCamionOtro.Checked
        textboxCamion_DominioChasisExtra.Visible = checkboxCamionOtro.Checked
        labelCamion_DominioAcoplado.Visible = checkboxCamionOtro.Checked
        textboxCamion_DominioAcoplado.Visible = checkboxCamionOtro.Checked

        If checkboxCamionOtro.Checked Then
            labelCamion.Text = "Chasis:"
            textboxCamion_DominioChasis.Focus()
        Else
            labelCamion.Text = "Camión:"
            comboboxCamion.Focus()
        End If
    End Sub

    Private Sub KilogramoIngreso(sender As Object, e As KeyPressEventArgs) Handles integertextboxKilogramoBruto.KeyPress, integertextboxKilogramoTara.KeyPress
        If integertextboxKilogramoBruto.IsNull Or integertextboxKilogramoTara.IsNull Then
            FechaHoraInicioAhora()
            FechaHoraFinAhora()
        Else
            FechaHoraFinAhora()
        End If
    End Sub

    Private Sub KilogramoCambio(sender As Object, e As EventArgs) Handles integertextboxKilogramoBruto.TextChanged, integertextboxKilogramoTara.TextChanged
        If integertextboxKilogramoBruto.IsNull Or integertextboxKilogramoTara.IsNull Then
            integertextboxKilogramoNeto.Text = ""
        Else
            integertextboxKilogramoNeto.IntegerValue = integertextboxKilogramoBruto.IntegerValue - integertextboxKilogramoTara.IntegerValue
        End If
    End Sub

    Private Sub ObtenerKilogramosBrutos() Handles buttonObtenerKilogramosBrutos.Click
        'If pFormMDIMain.labelDisplay.text <> "" Then
        '    integertextboxKilogramoBruto.Text = pFormMDIMain.labelDisplay.text
        '    If integertextboxKilogramoBruto.IsNull Or integertextboxKilogramoTara.IsNull Then
        '        FechaHoraInicioAhora()
        '        FechaHoraFinAhora()
        '    Else
        '        FechaHoraFinAhora()
        '    End If
        'End If
    End Sub

    Private Sub ObtenerKilogramosTara() Handles buttonObtenerKilogramosTara.Click
        'If pFormMDIMain.labelDisplay.text <> "" Then
        '    integertextboxKilogramoBruto.Text = pFormMDIMain.labelDisplay.text
        '    If integertextboxKilogramoBruto.IsNull Or integertextboxKilogramoTara.IsNull Then
        '        FechaHoraInicioAhora()
        '        FechaHoraFinAhora()
        '    Else
        '        FechaHoraFinAhora()
        '    End If
        'End If
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxProducto.GotFocus, textboxTitular.GotFocus, textboxOrigen.GotFocus, textboxTransportista.GotFocus, textboxChofer.GotFocus, textboxCamion_DominioChasis.GotFocus, textboxCamion_DominioAcoplado.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PESADA_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrar_Click() Handles buttonCerrar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        ' Verificar que estén todos los campos con datos coherentes

        ' Fecha de inicio
        If DateDiff(DateInterval.Second, DateTime.Now, datetimepickerFechaInicio.Value) > 0 Then
            ' La fecha/hora de la pesada es posterior a la fecha/hora actual
            If Not Permisos.VerificarPermiso(Permisos.PESADA_AGREGAR_FECHA_POSTERIOR, False) Then
                MsgBox("La fecha/hora de inicio no debe ser mayor a la fecha/hora actual.", MsgBoxStyle.Information, My.Application.Info.Title)
                datetimepickerFechaInicio.Focus()
                Exit Sub
            End If
        ElseIf DateDiff(DateInterval.Day, DateTime.Now, datetimepickerFechaInicio.Value) = 0 Then
            ' La fecha de la pesada es igual a la actual
            If DateDiff(DateInterval.Minute, DateTime.Now, datetimepickerFechaInicio.Value) < -CS_Parameter_System.GetIntegerAsInteger(Parametros.PESADA_HORA_INICIOACTUAL_DIFERENCIAMAXIMA_MINUTOS) Then
                ' La hora de la pesada es anterior a la actual en más de X minutos
                If Not Permisos.VerificarPermiso(Permisos.PESADA_AGREGAR_HORA_ANTERIOR, False) Then
                    MsgBox("La hora de inicio no debe ser menor a la hora actual.", MsgBoxStyle.Information, My.Application.Info.Title)
                    datetimepickerHoraInicio.Focus()
                    Exit Sub
                End If
            End If
        ElseIf DateDiff(DateInterval.Day, DateTime.Now, datetimepickerFechaInicio.Value) >= -CS_Parameter_System.GetIntegerAsInteger(Parametros.PESADA_FECHA_INICIOACTUAL_ANTERIOR_DIFERENCIAMAXIMA_DIAS) Then
            ' La fecha de la pesada es menos de X días anterior a la fecha actual
            If Not (Permisos.VerificarPermiso(Permisos.PESADA_AGREGAR_FECHA_ANTERIOR_XDIAS, False) Or Permisos.VerificarPermiso(Permisos.PESADA_AGREGAR_FECHA_ANTERIOR, False)) Then
                MsgBox(String.Format("La fecha de inicio de la pesada no debe ser menor en {0} días a la fecha actual.", CS_Parameter_System.GetIntegerAsInteger(Parametros.PESADA_FECHA_INICIOACTUAL_ANTERIOR_DIFERENCIAMAXIMA_DIAS)), MsgBoxStyle.Information, My.Application.Info.Title)
                datetimepickerFechaInicio.Focus()
                Exit Sub
            End If
        Else
            ' La fecha de la pesada es más de X días anterior a la fecha actual
            If Not Permisos.VerificarPermiso(Permisos.PESADA_AGREGAR_FECHA_ANTERIOR, False) Then
                MsgBox("Le fecha de inicio no debe ser menor a la fecha actual.", MsgBoxStyle.Information, My.Application.Info.Title)
                datetimepickerFechaInicio.Focus()
                Exit Sub
            End If
        End If

        ' Fecha de fin
        If DateDiff(DateInterval.Second, datetimepickerFechaInicio.Value, datetimepickerFechaFin.Value) < 0 Then
            MsgBox("La fecha/hora de fin de la pesada no debe ser menor a la fecha/hora de inicio.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerFechaFin.Focus()
            Exit Sub
        ElseIf DateDiff(DateInterval.Day, datetimepickerFechaInicio.Value, datetimepickerFechaFin.Value) > CS_Parameter_System.GetIntegerAsInteger(Parametros.PESADA_FECHA_INICIOFIN_DIFERENCIAMAXIMA_DIAS) Then
            ' La fecha de fin de la pesada es posterior en más de x días a la fecha de inicio
            MsgBox(String.Format("La fecha de fin de la pesada no debe ser mayor en {0} días a la fecha de inicio.", CS_Parameter_System.GetIntegerAsInteger(Parametros.PESADA_FECHA_INICIOFIN_DIFERENCIAMAXIMA_DIAS)), MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerFechaFin.Focus()
            Exit Sub
        End If

        ' Número de Comprobante
        If maskedtextboxComprobanteNumero.Text.Length > 0 AndAlso maskedtextboxComprobanteNumero.Text.Length < 12 Then
            MsgBox("El Número de Comprobante debe contener 12 dígitos.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxComprobanteNumero.Focus()
            Exit Sub
        End If
        If maskedtextboxComprobanteNumeroTercero.Text.Length > 0 AndAlso maskedtextboxComprobanteNumeroTercero.Text.Length < 12 Then
            MsgBox("El Número de Comprobante del Tercero debe contener 12 dígitos.", MsgBoxStyle.Information, My.Application.Info.Title)
            maskedtextboxComprobanteNumeroTercero.Focus()
            Exit Sub
        End If

        ' Producto
        If checkboxProductoOtro.Checked Then
            If textboxProducto.Text.Trim.Length = 0 Then
                MsgBox("Debe especificar el Producto.", MsgBoxStyle.Information, My.Application.Info.Title)
                textboxProducto.Focus()
                Exit Sub
            End If
        Else
            If comboboxProducto.SelectedValue Is Nothing Then
                MsgBox("Debe especificar el Producto.", MsgBoxStyle.Information, My.Application.Info.Title)
                comboboxProducto.Focus()
                Exit Sub
            End If
        End If

        ' Planta
        ' If (Not checkboxProductoOtro.Checked) AndAlso (Not comboboxProducto.SelectedItem Is Nothing) AndAlso CType(comboboxProducto.SelectedItem, Producto).UtilizaPlanta AndAlso comboboxPlanta.SelectedItem Is Nothing Then
        If comboboxPlanta.Visible AndAlso comboboxPlanta.SelectedItem Is Nothing Then
            MsgBox("Debe especificar la Planta.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxPlanta.Focus()
            Exit Sub
        End If

        ' Tipo
        If groupboxTipo.Visible AndAlso (radiobuttonEntrada.Checked = False And radiobuttonSalida.Checked = False And radiobuttonNinguno.Checked = False) Then
            MsgBox("Debe especificar el Tipo de Pesada.", MsgBoxStyle.Information, My.Application.Info.Title)
            labelTipo.Focus()
            Exit Sub
        End If

        ' Cosecha
        ' If (Not checkboxProductoOtro.Checked) AndAlso (Not comboboxProducto.SelectedItem Is Nothing) AndAlso CType(comboboxProducto.SelectedItem, Producto).UtilizaCosecha AndAlso comboboxCosecha.SelectedItem Is Nothing Then
        If comboboxCosecha.Visible AndAlso comboboxCosecha.SelectedItem Is Nothing Then
            MsgBox("Debe especificar la Cosecha.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCosecha.Focus()
            Exit Sub
        End If

        ' Titular
        If checkboxTitularOtro.Checked Then
            If textboxTitular.Text.Trim.Length = 0 Then
                MsgBox("Debe especificar el Titular.", MsgBoxStyle.Information, My.Application.Info.Title)
                textboxTitular.Focus()
                Exit Sub
            End If
        Else
            If comboboxTitular.SelectedValue Is Nothing Then
                MsgBox("Debe especificar el Titular.", MsgBoxStyle.Information, My.Application.Info.Title)
                comboboxTitular.Focus()
                Exit Sub
            End If
        End If

        ' Origen/Destino
        If checkboxOrigenOtro.Checked Then
            If textboxOrigen.Text.Trim.Length = 0 Then
                MsgBox(String.Format("Debe especificar el {0}.", labelOrigen.Text.Substring(0, labelOrigen.Text.Length - 2)), MsgBoxStyle.Information, My.Application.Info.Title)
                textboxOrigen.Focus()
                Exit Sub
            End If
        Else
            If comboboxOrigen.SelectedValue Is Nothing Then
                MsgBox(String.Format("Debe especificar el {0}.", labelOrigen.Text.Substring(0, labelOrigen.Text.Length - 2)), MsgBoxStyle.Information, My.Application.Info.Title)
                comboboxOrigen.Focus()
                Exit Sub
            End If
        End If

        ' Transportista
        If checkboxTransportistaOtro.Checked Then
            If textboxTransportista.Text.Trim.Length = 0 Then
                MsgBox("Debe especificar el Transportista.", MsgBoxStyle.Information, My.Application.Info.Title)
                textboxTransportista.Focus()
                Exit Sub
            End If
            If maskedtextboxTransportistaCUIT.Text.Length > 0 And maskedtextboxTransportistaCUIT.Text.Length < 11 Then
                MsgBox("El CUIT del Transportista debe contener 11 dígitos.", MsgBoxStyle.Information, My.Application.Info.Title)
                maskedtextboxTransportistaCUIT.Focus()
                Exit Sub
            End If
        Else
            If comboboxTransportista.SelectedValue Is Nothing Then
                MsgBox("Debe especificar el Transportista.", MsgBoxStyle.Information, My.Application.Info.Title)
                comboboxTransportista.Focus()
                Exit Sub
            End If
        End If

        ' Chofer
        If checkboxChoferOtro.Checked Then
            If textboxChofer.Text.Trim.Length = 0 Then
                MsgBox("Debe especificar el Chofer.", MsgBoxStyle.Information, My.Application.Info.Title)
                textboxChofer.Focus()
                Exit Sub
            End If
            If maskedtextboxChoferCUIT_CUIL.Text.Length > 0 And maskedtextboxChoferCUIT_CUIL.Text.Length < 11 Then
                MsgBox("El CUIT / CUIL del Chofer debe contener 11 dígitos.", MsgBoxStyle.Information, My.Application.Info.Title)
                maskedtextboxChoferCUIT_CUIL.Focus()
                Exit Sub
            End If
        Else
            If comboboxChofer.SelectedValue Is Nothing Then
                MsgBox("Debe especificar el Chofer.", MsgBoxStyle.Information, My.Application.Info.Title)
                comboboxChofer.Focus()
                Exit Sub
            End If
        End If

        ' Camion
        If checkboxCamionOtro.Checked Then
            If textboxCamion_DominioChasis.Text.Trim.Length > 0 And textboxCamion_DominioChasis.Text.Trim.Length < 6 Then
                MsgBox("El Dominio del Chasis debe contener al menos 6 caracteres.", MsgBoxStyle.Information, My.Application.Info.Title)
                textboxCamion_DominioChasis.Focus()
                Exit Sub
            End If
            If textboxCamion_DominioAcoplado.Text.Trim.Length > 0 And textboxCamion_DominioAcoplado.Text.Trim.Length < 6 Then
                MsgBox("El Dominio del Acoplado debe contener al menos 6 caracteres.", MsgBoxStyle.Information, My.Application.Info.Title)
                textboxCamion_DominioAcoplado.Focus()
                Exit Sub
            End If
        Else
            If comboboxCamion.SelectedValue Is Nothing Then
                MsgBox("Debe especificar el Camion.", MsgBoxStyle.Information, My.Application.Info.Title)
                comboboxCamion.Focus()
                Exit Sub
            End If
        End If

        ' Kilogramos
        If integertextboxKilogramoBruto.IsNull And integertextboxKilogramoTara.IsNull Then
            If MsgBox("No ha especificado los Kilogramos." & vbCrLf & vbCrLf & "¿Desea ingresarlos?", CType(MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                integertextboxKilogramoBruto.Focus()
                Exit Sub
            End If
        End If

        ' Generar el ID de la Pesada nueva
        If mIsNew Then
            ' El nuevo ID se calcula tomando el valor de la función Now, al cual le restamos el valor
            ' correspondiente a los días transcurridos entre el 01/01/1899 y el 01/01/2017 porque no son relevantes
            ' y si no, la conversión a Long excede el límite dando error de Overflow.
            ' Además, multiplicamos por 100.000 para que los segundos formen parte del componente entero
            mPesadaActual.IDPesada = CInt(CDbl(DateAndTime.Now.ToOADate - DateAndTime.DateSerial(2017, 1, 1).ToOADate) * 100000)
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mPesadaActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mPesadaActual.FechaHoraModificacion = Now

            Try
                ' Calculo mermas si corresponde
                Select Case mPesadaActual.Tipo
                    Case PESADA_TIPO_ENTRADA, PESADA_TIPO_NINGUNA
                        If mPesadaActual.Pesada_Analisis Is Nothing Then
                            mPesadaActual.Pesada_Analisis = New Pesada_Analisis
                        End If
                        mPesadaActual.Pesada_Analisis.CalcularMermas(mPesadaActual)
                    Case PESADA_TIPO_SALIDA
                        mPesadaActual.KilogramoFinal = -mPesadaActual.KilogramoNeto
                End Select

                ' Calculo el acondicionamiento si corresponde
                If mPesadaActual.Tipo = Constantes.PESADA_TIPO_ENTRADA AndAlso mPesadaActual.IDCosecha.HasValue AndAlso mPesadaActual.KilogramoNeto.HasValue AndAlso mPesadaActual.KilogramoNeto > 0 Then
                    If mPesadaActual.Pesada_Acondicionamiento Is Nothing Then
                        mPesadaActual.Pesada_Acondicionamiento = New Pesada_Acondicionamiento
                    End If
                    If Not mPesadaActual.Pesada_Acondicionamiento.CalcularAcondicionamiento(mPesadaActual) Then
                        If Not mPesadaActual.Pesada_Acondicionamiento.TarifaManual Then
                            mdbContext.Pesada_Acondicionamiento.Remove(mPesadaActual.Pesada_Acondicionamiento)
                        End If
                    End If
                Else
                    If Not mPesadaActual.Pesada_Acondicionamiento Is Nothing Then
                        mdbContext.Pesada_Acondicionamiento.Remove(mPesadaActual.Pesada_Acondicionamiento)
                    End If
                End If

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista de Pesadas para mostrar los cambios
                If CS_Form.MDIChild_IsLoaded(CType(pFormMDIMain, Form), "formPesadas") Then
                    Dim formPesadas As formPesadas = CType(CS_Form.MDIChild_GetInstance(CType(pFormMDIMain, Form), "formPesadas"), formPesadas)
                    formPesadas.RefreshData(mPesadaActual.IDPesada)
                    formPesadas = Nothing
                End If
            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe una Pesada con el mismo Número.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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

End Class