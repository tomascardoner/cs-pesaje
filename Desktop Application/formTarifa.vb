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
            End With
            mdbContext.Cosecha_Producto_Tarifa.Add(mCosecha_Producto_TarifaActual)
        Else
            mCosecha_Producto_TarifaActual = mdbContext.Cosecha_Producto_Tarifa.Find(IDCosecha, IDProducto, Indice)
        End If

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

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = Not mEditMode
        buttonCerrar.Visible = Not mEditMode

        ' Requeridos
        comboboxCosecha.Enabled = mEditMode
        comboboxProducto.Enabled = mEditMode
        updownIndice.Enabled = mEditMode
        textboxNombre.ReadOnly = Not mEditMode

        ' Opcionales
        comboboxPlanta.Enabled = mEditMode
        comboboxEntidad.Enabled = mEditMode
        comboboxOrigen.Enabled = mEditMode
        datetimepickerFechaDesde.Enabled = mEditMode
        datetimepickerFechaHasta.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Cosecha(comboboxCosecha, mCosecha_Producto_TarifaActual.IDCosecha, CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, DateTime.MinValue, False, False, True)
        pFillAndRefreshLists.Producto(comboboxProducto, mCosecha_Producto_TarifaActual.IDProducto, False, True, False, False)
        'pFillAndRefreshLists.Entidad(comboboxTransportista, mCosecha_Producto_TarifaActual.Transportista_IDEntidad, False, False, True, False, CS_Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER, True, False, False, True)
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
            ' Requeridos
            CS_ComboBox.SetSelectedValue(comboboxCosecha, SelectedItemOptions.Value, .IDCosecha, CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            CS_ComboBox.SetSelectedValue(comboboxProducto, SelectedItemOptions.Value, .IDProducto)
            updownIndice.Value = CS_ValueTranslation.FromObjectShortToControlUpDown(.Indice)
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)

            ' Opcionales
            CS_ComboBox.SetSelectedValue(comboboxPlanta, SelectedItemOptions.Value, .IDPlanta, CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            CS_ComboBox.SetSelectedValue(comboboxEntidad, SelectedItemOptions.Value, .IDEntidad)
            CS_ComboBox.SetSelectedValue(comboboxOrigen, SelectedItemOptions.ValueOrFirst, .IDOrigen)
            datetimepickerFechaDesde.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaDesde, datetimepickerFechaDesde)
            datetimepickerFechaHasta.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker_OnlyDate(.FechaHasta, datetimepickerFechaHasta)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mCosecha_Producto_TarifaActual
            ' Requeridos
            .IDCosecha = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCosecha.SelectedValue).Value
            .IDProducto = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxProducto.SelectedValue).Value
            .Indice = CS_ValueTranslation.FromControlUpDownToObjectShort(updownIndice.Value).Value

            ' Opcionales
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

    'Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
    '    ' Verificar que estén todos los campos con datos coherentes

    '    ' Fecha de inicio
    '    If DateDiff(DateInterval.Second, DateTime.Now, datetimepickerFechaInicio.Value) > 0 Then
    '        ' La fecha/hora de la Cosecha_Producto_Tarifa es posterior a la fecha/hora actual
    '        If Not Permisos.VerificarPermiso(Permisos.Cosecha_Producto_Tarifa_AGREGAR_FECHA_POSTERIOR, False) Then
    '            MsgBox("La fecha/hora de inicio no debe ser mayor a la fecha/hora actual.", MsgBoxStyle.Information, My.Application.Info.Title)
    '            datetimepickerFechaInicio.Focus()
    '            Exit Sub
    '        End If
    '    ElseIf DateDiff(DateInterval.Day, DateTime.Now, datetimepickerFechaInicio.Value) = 0 Then
    '        ' La fecha de la Cosecha_Producto_Tarifa es igual a la actual
    '        If DateDiff(DateInterval.Minute, DateTime.Now, datetimepickerFechaInicio.Value) < -CS_Parameter_System.GetIntegerAsInteger(Parametros.Cosecha_Producto_Tarifa_HORA_INICIOACTUAL_DIFERENCIAMAXIMA_MINUTOS) Then
    '            ' La hora de la Cosecha_Producto_Tarifa es anterior a la actual en más de X minutos
    '            If Not Permisos.VerificarPermiso(Permisos.Cosecha_Producto_Tarifa_AGREGAR_HORA_ANTERIOR, False) Then
    '                MsgBox("La hora de inicio no debe ser menor a la hora actual.", MsgBoxStyle.Information, My.Application.Info.Title)
    '                datetimepickerHoraInicio.Focus()
    '                Exit Sub
    '            End If
    '        End If
    '    ElseIf DateDiff(DateInterval.Day, DateTime.Now, datetimepickerFechaInicio.Value) >= -CS_Parameter_System.GetIntegerAsInteger(Parametros.Cosecha_Producto_Tarifa_FECHA_INICIOACTUAL_ANTERIOR_DIFERENCIAMAXIMA_DIAS) Then
    '        ' La fecha de la Cosecha_Producto_Tarifa es menos de X días anterior a la fecha actual
    '        If Not (Permisos.VerificarPermiso(Permisos.Cosecha_Producto_Tarifa_AGREGAR_FECHA_ANTERIOR_XDIAS, False) Or Permisos.VerificarPermiso(Permisos.Cosecha_Producto_Tarifa_AGREGAR_FECHA_ANTERIOR, False)) Then
    '            MsgBox(String.Format("La fecha de inicio de la Cosecha_Producto_Tarifa no debe ser menor en {0} días a la fecha actual.", CS_Parameter_System.GetIntegerAsInteger(Parametros.Cosecha_Producto_Tarifa_FECHA_INICIOACTUAL_ANTERIOR_DIFERENCIAMAXIMA_DIAS)), MsgBoxStyle.Information, My.Application.Info.Title)
    '            datetimepickerFechaInicio.Focus()
    '            Exit Sub
    '        End If
    '    Else
    '        ' La fecha de la Cosecha_Producto_Tarifa es más de X días anterior a la fecha actual
    '        If Not Permisos.VerificarPermiso(Permisos.Cosecha_Producto_Tarifa_AGREGAR_FECHA_ANTERIOR, False) Then
    '            MsgBox("Le fecha de inicio no debe ser menor a la fecha actual.", MsgBoxStyle.Information, My.Application.Info.Title)
    '            datetimepickerFechaInicio.Focus()
    '            Exit Sub
    '        End If
    '    End If

    '    ' Fecha de fin
    '    If DateDiff(DateInterval.Second, datetimepickerFechaInicio.Value, datetimepickerFechaFin.Value) < 0 Then
    '        MsgBox("La fecha/hora de fin de la Cosecha_Producto_Tarifa no debe ser menor a la fecha/hora de inicio.", MsgBoxStyle.Information, My.Application.Info.Title)
    '        datetimepickerFechaFin.Focus()
    '        Exit Sub
    '    ElseIf DateDiff(DateInterval.Day, datetimepickerFechaInicio.Value, datetimepickerFechaFin.Value) > CS_Parameter_System.GetIntegerAsInteger(Parametros.Cosecha_Producto_Tarifa_FECHA_INICIOFIN_DIFERENCIAMAXIMA_DIAS) Then
    '        ' La fecha de fin de la Cosecha_Producto_Tarifa es posterior en más de x días a la fecha de inicio
    '        MsgBox(String.Format("La fecha de fin de la Cosecha_Producto_Tarifa no debe ser mayor en {0} días a la fecha de inicio.", CS_Parameter_System.GetIntegerAsInteger(Parametros.Cosecha_Producto_Tarifa_FECHA_INICIOFIN_DIFERENCIAMAXIMA_DIAS)), MsgBoxStyle.Information, My.Application.Info.Title)
    '        datetimepickerFechaFin.Focus()
    '        Exit Sub
    '    End If

    '    ' Número de Comprobante
    '    If maskedtextboxComprobanteNumero.Text.Length > 0 AndAlso maskedtextboxComprobanteNumero.Text.Length < 12 Then
    '        MsgBox("El Número de Comprobante debe contener 12 dígitos.", MsgBoxStyle.Information, My.Application.Info.Title)
    '        maskedtextboxComprobanteNumero.Focus()
    '        Exit Sub
    '    End If
    '    If maskedtextboxComprobanteNumeroTercero.Text.Length > 0 AndAlso maskedtextboxComprobanteNumeroTercero.Text.Length < 12 Then
    '        MsgBox("El Número de Comprobante del Tercero debe contener 12 dígitos.", MsgBoxStyle.Information, My.Application.Info.Title)
    '        maskedtextboxComprobanteNumeroTercero.Focus()
    '        Exit Sub
    '    End If

    '    ' Producto
    '    If checkboxProductoOtro.Checked Then
    '        If textboxProducto.Text.Trim.Length = 0 Then
    '            MsgBox("Debe especificar el Producto.", MsgBoxStyle.Information, My.Application.Info.Title)
    '            textboxProducto.Focus()
    '            Exit Sub
    '        End If
    '    Else
    '        If comboboxProducto.SelectedValue Is Nothing Then
    '            MsgBox("Debe especificar el Producto.", MsgBoxStyle.Information, My.Application.Info.Title)
    '            comboboxProducto.Focus()
    '            Exit Sub
    '        End If
    '    End If

    '    ' Planta
    '    ' If (Not checkboxProductoOtro.Checked) AndAlso (Not comboboxProducto.SelectedItem Is Nothing) AndAlso CType(comboboxProducto.SelectedItem, Producto).UtilizaPlanta AndAlso comboboxPlanta.SelectedItem Is Nothing Then
    '    If comboboxPlanta.Visible AndAlso comboboxPlanta.SelectedItem Is Nothing Then
    '        MsgBox("Debe especificar la Planta.", MsgBoxStyle.Information, My.Application.Info.Title)
    '        comboboxPlanta.Focus()
    '        Exit Sub
    '    End If

    '    ' Tipo
    '    If groupboxTipo.Visible AndAlso (radiobuttonEntrada.Checked = False And radiobuttonSalida.Checked = False And radiobuttonNinguno.Checked = False) Then
    '        MsgBox("Debe especificar el Tipo de Cosecha_Producto_Tarifa.", MsgBoxStyle.Information, My.Application.Info.Title)
    '        labelTipo.Focus()
    '        Exit Sub
    '    End If

    '    ' Cosecha
    '    ' If (Not checkboxProductoOtro.Checked) AndAlso (Not comboboxProducto.SelectedItem Is Nothing) AndAlso CType(comboboxProducto.SelectedItem, Producto).UtilizaCosecha AndAlso comboboxCosecha.SelectedItem Is Nothing Then
    '    If comboboxCosecha.Visible AndAlso comboboxCosecha.SelectedItem Is Nothing Then
    '        MsgBox("Debe especificar la Cosecha.", MsgBoxStyle.Information, My.Application.Info.Title)
    '        comboboxCosecha.Focus()
    '        Exit Sub
    '    End If

    '    ' Titular
    '    If checkboxTitularOtro.Checked Then
    '        If textboxTitular.Text.Trim.Length = 0 Then
    '            MsgBox("Debe especificar el Titular.", MsgBoxStyle.Information, My.Application.Info.Title)
    '            textboxTitular.Focus()
    '            Exit Sub
    '        End If
    '    Else
    '        If comboboxTitular.SelectedValue Is Nothing Then
    '            MsgBox("Debe especificar el Titular.", MsgBoxStyle.Information, My.Application.Info.Title)
    '            comboboxTitular.Focus()
    '            Exit Sub
    '        End If
    '    End If

    '    ' Origen/Destino
    '    If checkboxOrigenOtro.Checked Then
    '        If textboxOrigen.Text.Trim.Length = 0 Then
    '            MsgBox(String.Format("Debe especificar el {0}.", labelOrigen.Text.Substring(0, labelOrigen.Text.Length - 2)), MsgBoxStyle.Information, My.Application.Info.Title)
    '            textboxOrigen.Focus()
    '            Exit Sub
    '        End If
    '    Else
    '        If comboboxOrigen.SelectedValue Is Nothing Then
    '            MsgBox(String.Format("Debe especificar el {0}.", labelOrigen.Text.Substring(0, labelOrigen.Text.Length - 2)), MsgBoxStyle.Information, My.Application.Info.Title)
    '            comboboxOrigen.Focus()
    '            Exit Sub
    '        End If
    '    End If

    '    ' Transportista
    '    If checkboxTransportistaOtro.Checked Then
    '        If textboxTransportista.Text.Trim.Length = 0 Then
    '            MsgBox("Debe especificar el Transportista.", MsgBoxStyle.Information, My.Application.Info.Title)
    '            textboxTransportista.Focus()
    '            Exit Sub
    '        End If
    '        If maskedtextboxTransportistaCUIT.Text.Length > 0 And maskedtextboxTransportistaCUIT.Text.Length < 11 Then
    '            MsgBox("El CUIT del Transportista debe contener 11 dígitos.", MsgBoxStyle.Information, My.Application.Info.Title)
    '            maskedtextboxTransportistaCUIT.Focus()
    '            Exit Sub
    '        End If
    '    Else
    '        If comboboxTransportista.SelectedValue Is Nothing Then
    '            MsgBox("Debe especificar el Transportista.", MsgBoxStyle.Information, My.Application.Info.Title)
    '            comboboxTransportista.Focus()
    '            Exit Sub
    '        End If
    '    End If

    '    ' Chofer
    '    If checkboxChoferOtro.Checked Then
    '        If textboxChofer.Text.Trim.Length = 0 Then
    '            MsgBox("Debe especificar el Chofer.", MsgBoxStyle.Information, My.Application.Info.Title)
    '            textboxChofer.Focus()
    '            Exit Sub
    '        End If
    '        If maskedtextboxChoferCUIT_CUIL.Text.Length > 0 And maskedtextboxChoferCUIT_CUIL.Text.Length < 11 Then
    '            MsgBox("El CUIT / CUIL del Chofer debe contener 11 dígitos.", MsgBoxStyle.Information, My.Application.Info.Title)
    '            maskedtextboxChoferCUIT_CUIL.Focus()
    '            Exit Sub
    '        End If
    '    Else
    '        If comboboxChofer.SelectedValue Is Nothing Then
    '            MsgBox("Debe especificar el Chofer.", MsgBoxStyle.Information, My.Application.Info.Title)
    '            comboboxChofer.Focus()
    '            Exit Sub
    '        End If
    '    End If

    '    ' Camion
    '    If checkboxCamionOtro.Checked Then
    '        If textboxCamion_DominioChasis.Text.Trim.Length > 0 And textboxCamion_DominioChasis.Text.Trim.Length < 6 Then
    '            MsgBox("El Dominio del Chasis debe contener al menos 6 caracteres.", MsgBoxStyle.Information, My.Application.Info.Title)
    '            textboxCamion_DominioChasis.Focus()
    '            Exit Sub
    '        End If
    '        If textboxCamion_DominioAcoplado.Text.Trim.Length > 0 And textboxCamion_DominioAcoplado.Text.Trim.Length < 6 Then
    '            MsgBox("El Dominio del Acoplado debe contener al menos 6 caracteres.", MsgBoxStyle.Information, My.Application.Info.Title)
    '            textboxCamion_DominioAcoplado.Focus()
    '            Exit Sub
    '        End If
    '    Else
    '        If comboboxCamion.SelectedValue Is Nothing Then
    '            MsgBox("Debe especificar el Camion.", MsgBoxStyle.Information, My.Application.Info.Title)
    '            comboboxCamion.Focus()
    '            Exit Sub
    '        End If
    '    End If

    '    ' Kilogramos
    '    If integertextboxKilogramoBruto.IsNull And integertextboxKilogramoTara.IsNull Then
    '        If MsgBox("No ha especificado los Kilogramos." & vbCrLf & vbCrLf & "¿Desea ingresarlos?", CType(MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
    '            integertextboxKilogramoBruto.Focus()
    '            Exit Sub
    '        End If
    '    End If

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
    'End Sub

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