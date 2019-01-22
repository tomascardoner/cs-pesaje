Public Class formTarifa

#Region "Declarations"
    Private mdbContext As New CSPesajeContext(True)
    Private mCosecha_Producto_TarifaActual As Cosecha_Producto_Tarifa

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
    Private mIsNew As Boolean
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDCosecha As Byte, ByVal IDProducto As Byte, ByVal Indice As Short)
        mIsLoading = True
        mEditMode = EditMode
        mIsNew = Indice = 0

        If mIsNew Then
            mCosecha_Producto_TarifaActual = New Cosecha_Producto_Tarifa
            With mCosecha_Producto_TarifaActual
                .IDCosecha = IDCosecha
                .IDProducto = IDProducto
            End With
            mdbContext.Cosecha_Producto_Tarifa.Add(mCosecha_Producto_TarifaActual)
        Else
            mCosecha_Producto_TarifaActual = mdbContext.Cosecha_Producto_Tarifa.Find(IDCosecha, IDProducto, Indice)
        End If
        buttonIndiceObtener.Visible = mIsNew

        'Me.MdiParent = formMDIMain
        CS_Form.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()
        'If Me.WindowState = FormWindowState.Minimized Then
        '    Me.WindowState = FormWindowState.Normal
        'End If
        'Me.Focus()
        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(formTarifas)
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Exit Sub
        End If

        ' Toolbar
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = Not mEditMode
        buttonCerrar.Visible = Not mEditMode

        ' General - Requeridos
        comboboxCosecha.Enabled = mIsNew
        comboboxProducto.Enabled = mIsNew
        updownIndice.Enabled = mIsNew
        textboxNombre.ReadOnly = Not mEditMode

        ' General - Opcionales
        comboboxPlanta.Enabled = mEditMode
        comboboxEntidad.Enabled = mEditMode
        comboboxOrigen.Enabled = mEditMode
        datetimepickerFechaDesde.Enabled = mEditMode
        datetimepickerFechaHasta.Enabled = mEditMode

        ' Tarifas - Varias
        currencytextboxTarifaParitariaImporte.ReadOnly = Not mEditMode
        currencytextboxTarifaZarandeo.ReadOnly = Not mEditMode
        currencytextboxTarifaFumigadoImporte.ReadOnly = Not mEditMode
        currencytextboxTarifaMezcladoImporte.ReadOnly = Not mEditMode

        ' Tarifas - Secado
        radiobuttonSecadoTipoFijo.Enabled = mEditMode
        radiobuttonSecadoTipoEscala.Enabled = mEditMode
        doubletextboxTarifaSecadoInicialPunto.ReadOnly = Not mEditMode
        currencytextboxTarifaSecadoInicialImporte.ReadOnly = Not mEditMode
        currencytextboxTarifaSecadoPuntoExcesoImporte.ReadOnly = Not mEditMode
        doubletextboxTarifaSecadoHumedadBase.ReadOnly = Not mEditMode
        doubletextboxTarifaSecadoMargenLibre.ReadOnly = Not mEditMode
        radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.Enabled = mEditMode
        radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.Enabled = mEditMode
        radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.Enabled = mEditMode
        radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.Enabled = mEditMode

        ' Almacenaje
        radiobuttonAlmacenajeTipoDiasGraciaFijo.Enabled = mEditMode
        radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.Enabled = mEditMode
        radiobuttonAlmacenajeTipoFechaFija.Enabled = mEditMode
        integertextboxAlmacenajeDiaGracia.ReadOnly = Not mEditMode
        datetimepickerAlmacenajeInicio.Enabled = mEditMode
        percenttextboxAlmacenajePorcentajeMensual.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Cosecha(comboboxCosecha, mCosecha_Producto_TarifaActual.IDCosecha, CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, DateTime.MinValue, False, False, True)
        pFillAndRefreshLists.Producto(comboboxProducto, mCosecha_Producto_TarifaActual.IDProducto, False, True, False, False)

        pFillAndRefreshLists.Planta(comboboxPlanta, mCosecha_Producto_TarifaActual.IDPlanta, CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, False, True)
        pFillAndRefreshLists.Entidad(comboboxEntidad, mCosecha_Producto_TarifaActual.IDEntidad, False, False, True, False, CS_Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER, True, False, False, True)
        pFillAndRefreshLists.OrigenDestino(comboboxOrigen, mCosecha_Producto_TarifaActual.IDOrigen, False, CS_Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER, False, False, True)
    End Sub

    Friend Sub SetAppearance()
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mCosecha_Producto_TarifaActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mCosecha_Producto_TarifaActual
            ' General - Requeridos
            CS_ComboBox.SetSelectedValue(comboboxCosecha, SelectedItemOptions.Value, .IDCosecha, CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            CS_ComboBox.SetSelectedValue(comboboxProducto, SelectedItemOptions.Value, .IDProducto)
            updownIndice.Value = CS_ValueTranslation.FromObjectShortToControlUpDown(.Indice)
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)

            ' General - Opcionales
            CS_ComboBox.SetSelectedValue(comboboxPlanta, SelectedItemOptions.ValueOrFirst, .IDPlanta, CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            CS_ComboBox.SetSelectedValue(comboboxEntidad, SelectedItemOptions.ValueOrFirst, .IDEntidad)
            CS_ComboBox.SetSelectedValue(comboboxOrigen, SelectedItemOptions.ValueOrFirst, .IDOrigen)
            datetimepickerFechaDesde.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaDesde, datetimepickerFechaDesde)
            datetimepickerFechaHasta.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaHasta, datetimepickerFechaHasta)

            ' Tarifas - Varias
            currencytextboxTarifaParitariaImporte.DecimalValue = .TarifaParitariaImporte
            currencytextboxTarifaZarandeo.DecimalValue = .TarifaZarandeoImporte
            currencytextboxTarifaFumigadoImporte.DecimalValue = .TarifaFumigadoImporte
            currencytextboxTarifaMezcladoImporte.DecimalValue = .TarifaMezclaImporte

            ' Tarifas - Secado
            radiobuttonSecadoTipoFijo.Checked = (.TarifaSecadoTipo = Constantes.PRODUCTO_TARIFA_SECADO_TIPO_FIJA)
            radiobuttonSecadoTipoEscala.Checked = (.TarifaSecadoTipo = Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA)
            doubletextboxTarifaSecadoInicialPunto.DoubleValue = .TarifaSecadoInicialPunto
            currencytextboxTarifaSecadoInicialImporte.DecimalValue = .TarifaSecadoInicialImporte
            currencytextboxTarifaSecadoPuntoExcesoImporte.DecimalValue = .TarifaSecadoPuntoExcesoImporte
            doubletextboxTarifaSecadoHumedadBase.DoubleValue = .TarifaSecadoHumedadBase
            doubletextboxTarifaSecadoMargenLibre.DoubleValue = .TarifaSecadoHumedadMargenLibre
            radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.Checked = (.TarifaSecadoHumedadRedondeoPuntoTipo = Constantes.PRODUCTO_TARIFA_SECADO_REDONDEOPUNTO_TIPO_NINGUNO)
            radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.Checked = (.TarifaSecadoHumedadRedondeoPuntoTipo = Constantes.PRODUCTO_TARIFA_SECADO_REDONDEOPUNTO_TIPO_ENTERO)
            radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.Checked = (.TarifaSecadoHumedadRedondeoPuntoTipo = Constantes.PRODUCTO_TARIFA_SECADO_REDONDEOPUNTO_TIPO_SUPERIOR)
            radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.Checked = (.TarifaSecadoHumedadRedondeoPuntoTipo = Constantes.PRODUCTO_TARIFA_SECADO_REDONDEOPUNTO_TIPO_INFERIOR)

            ' Almacenaje
            radiobuttonAlmacenajeTipoDiasGraciaFijo.Checked = (.AlmacenajeTipo = Constantes.ALMACENAJE_TIPO_DIAS_GRACIA_FIJO)
            radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.Checked = (.AlmacenajeTipo = Constantes.ALMACENAJE_TIPO_DIAS_GRACIA_SI_RETIRA_ANTES)
            radiobuttonAlmacenajeTipoFechaFija.Checked = (.AlmacenajeTipo = Constantes.ALMACENAJE_TIPO_FECHA_FIJA)
            integertextboxAlmacenajeDiaGracia.BindableValue = .AlmacenajeDiaGracia
            datetimepickerAlmacenajeInicio.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.AlmacenajeInicio, datetimepickerAlmacenajeInicio)
            percenttextboxAlmacenajePorcentajeMensual.PercentValue = .AlmacenajePorcentajeMensual
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mCosecha_Producto_TarifaActual
            ' General - Requeridos
            .IDCosecha = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCosecha.SelectedValue).Value
            .IDProducto = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxProducto.SelectedValue).Value
            .Indice = CS_ValueTranslation.FromControlUpDownToObjectShort(updownIndice.Value).Value

            ' General - Opcionales
            .IDPlanta = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxPlanta.SelectedValue)
            .IDEntidad = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxEntidad.SelectedValue).Value
            .IDOrigen = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxOrigen.SelectedValue)
            .FechaDesde = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaDesde.Value, datetimepickerFechaDesde.Checked).Value
            .FechaHasta = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaHasta.Value, datetimepickerFechaHasta.Checked).Value
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNombre.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub


#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.TARIFA_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrar_Click() Handles buttonCerrar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        ' Verificar que estén todos los campos con datos coherentes

        ' Cosecha
        If comboboxCosecha.SelectedItem Is Nothing Then
            MsgBox("Debe especificar la Cosecha.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxCosecha.Focus()
            Exit Sub
        End If

        ' Producto
        If comboboxProducto.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Producto.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxProducto.Focus()
            Exit Sub
        End If

        ' Indice
        If updownIndice.Value < 1 Then
            MsgBox("El Índice debe ser mayor o igual a 1.", MsgBoxStyle.Information, My.Application.Info.Title)
            updownIndice.Focus()
            Exit Sub
        End If

        ' Nombre
        If textboxNombre.Text.Trim().Length = 0 Then
            MsgBox("Debe especificar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNombre.Focus()
            Exit Sub
        End If

        ' Fecha desde y hasta
        If DateDiff(DateInterval.Day, datetimepickerFechaDesde.Value, datetimepickerFechaHasta.Value) > 0 Then
            MsgBox("La fecha hasta debe ser posterior a la fecha desde.", MsgBoxStyle.Information, My.Application.Info.Title)
            datetimepickerFechaHasta.Focus()
            Exit Sub
        End If


        '    ' Generar el ID de la Cosecha_Producto_Tarifa nueva
        '    If mIsNew Then
        '        ' El nuevo ID se calcula tomando el valor de la función Now, al cual le restamos el valor
        '        ' correspondiente a los días transcurridos entre el 01/01/1899 y el 01/01/2017 porque no son relevantes
        '        ' y si no, la conversión a Long excede el límite dando error de Overflow.
        '        ' Además, multiplicamos por 100.000 para que los segundos formen parte del componente entero
        '        mCosecha_Producto_TarifaActual.IDCosecha_Producto_Tarifa = CInt(CDbl(DateAndTime.Now.ToOADate - DateAndTime.DateSerial(2017, 1, 1).ToOADate) * 100000)
        '    End If

        '    ' Paso los datos desde los controles al Objecto de EF
        '    SetDataFromControlsToObject()

        '    If mdbContext.ChangeTracker.HasChanges Then

        '        Me.Cursor = Cursors.WaitCursor

        '        mCosecha_Producto_TarifaActual.IDUsuarioModificacion = pUsuario.IDUsuario
        '        mCosecha_Producto_TarifaActual.FechaHoraModificacion = Now

        '        Try
        '            ' Calculo mermas si corresponde
        '            Select Case mCosecha_Producto_TarifaActual.Tipo
        '                Case Cosecha_Producto_Tarifa_TIPO_ENTRADA, Cosecha_Producto_Tarifa_TIPO_NINGUNA
        '                    If mCosecha_Producto_TarifaActual.Cosecha_Producto_Tarifa_Analisis Is Nothing Then
        '                        mCosecha_Producto_TarifaActual.Cosecha_Producto_Tarifa_Analisis = New Cosecha_Producto_Tarifa_Analisis
        '                    End If
        '                    mCosecha_Producto_TarifaActual.Cosecha_Producto_Tarifa_Analisis.CalcularMermas(mCosecha_Producto_TarifaActual)
        '                Case Cosecha_Producto_Tarifa_TIPO_SALIDA
        '                    mCosecha_Producto_TarifaActual.KilogramoFinal = -mCosecha_Producto_TarifaActual.KilogramoNeto
        '            End Select

        '            ' Calculo el acondicionamiento si corresponde
        '            If mCosecha_Producto_TarifaActual.Tipo = Constantes.Cosecha_Producto_Tarifa_TIPO_ENTRADA AndAlso mCosecha_Producto_TarifaActual.IDCosecha.HasValue AndAlso mCosecha_Producto_TarifaActual.KilogramoNeto.HasValue AndAlso mCosecha_Producto_TarifaActual.KilogramoNeto > 0 Then
        '                If mCosecha_Producto_TarifaActual.Cosecha_Producto_Tarifa_Acondicionamiento Is Nothing Then
        '                    mCosecha_Producto_TarifaActual.Cosecha_Producto_Tarifa_Acondicionamiento = New Cosecha_Producto_Tarifa_Acondicionamiento
        '                End If
        '                If Not mCosecha_Producto_TarifaActual.Cosecha_Producto_Tarifa_Acondicionamiento.CalcularAcondicionamiento(mCosecha_Producto_TarifaActual) Then
        '                    If Not mCosecha_Producto_TarifaActual.Cosecha_Producto_Tarifa_Acondicionamiento.TarifaManual Then
        '                        mdbContext.Cosecha_Producto_Tarifa_Acondicionamiento.Remove(mCosecha_Producto_TarifaActual.Cosecha_Producto_Tarifa_Acondicionamiento)
        '                    End If
        '                End If
        '            Else
        '                If Not mCosecha_Producto_TarifaActual.Cosecha_Producto_Tarifa_Acondicionamiento Is Nothing Then
        '                    mdbContext.Cosecha_Producto_Tarifa_Acondicionamiento.Remove(mCosecha_Producto_TarifaActual.Cosecha_Producto_Tarifa_Acondicionamiento)
        '                End If
        '            End If

        '            ' Guardo los cambios
        '            mdbContext.SaveChanges()

        '            ' Refresco la lista de Cosecha_Producto_Tarifas para mostrar los cambios
        '            If CS_Form.MDIChild_IsLoaded(CType(formMDIMain, Form), "formCosecha_Producto_Tarifas") Then
        '                Dim formCosecha_Producto_Tarifas As formCosecha_Producto_Tarifas = CType(CS_Form.MDIChild_GetInstance(CType(formMDIMain, Form), "formCosecha_Producto_Tarifas"), formCosecha_Producto_Tarifas)
        '                formCosecha_Producto_Tarifas.RefreshData(mCosecha_Producto_TarifaActual.IDCosecha_Producto_Tarifa)
        '                formCosecha_Producto_Tarifas = Nothing
        '            End If

        '        Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
        '            Me.Cursor = Cursors.Default
        '            Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
        '                Case Errors.DuplicatedEntity
        '                    MsgBox("No se pueden guardar los cambios porque ya existe una Cosecha_Producto_Tarifa con el mismo Número.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
        '                Case Errors.Unknown
        '                    CS_Error.ProcessError(CType(dbuex, Exception), My.Resources.STRING_ERROR_SAVING_CHANGES)
        '            End Select
        '            Exit Sub

        '        Catch ex As Exception
        '            Me.Cursor = Cursors.Default
        '            CS_Error.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
        '            Exit Sub
        '        End Try
        '    End If

        '    Me.Close()
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