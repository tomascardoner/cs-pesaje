Public Class formTarifa

#Region "Declarations"

    Private mdbContext As New CSPesajeContext(True)
    Private mCosecha_Producto_TarifaActual As Cosecha_Producto_Tarifa

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
    Private mIsNew As Boolean

    Private tabControlExtension As CardonerSistemas.TabControlExtension

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDCosecha As Byte, ByVal IDProducto As Byte, ByVal Indice As Short, ByVal copiar As Boolean)
        mIsLoading = True
        mEditMode = EditMode
        mIsNew = (Indice = 0 OrElse copiar)

        If mIsNew Then
            mCosecha_Producto_TarifaActual = New Cosecha_Producto_Tarifa
            With mCosecha_Producto_TarifaActual
                .IDCosecha = IDCosecha
                .IDProducto = IDProducto
            End With
            mdbContext.Cosecha_Producto_Tarifa.Add(mCosecha_Producto_TarifaActual)

            If copiar Then
                mCosecha_Producto_TarifaActual.CopyFrom(mdbContext.Cosecha_Producto_Tarifa.Find(IDCosecha, IDProducto, Indice), True, True)
                mCosecha_Producto_TarifaActual.Indice = 0
            End If
        Else
            mCosecha_Producto_TarifaActual = mdbContext.Cosecha_Producto_Tarifa.Find(IDCosecha, IDProducto, Indice)
        End If
        buttonIndiceObtener.Visible = mIsNew

        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()
        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(formTarifas)
    End Sub

    Friend Sub LoadAndShowCopy(ByRef ParentForm As Form, ByRef tarifaOriginal As Cosecha_Producto_Tarifa, ByRef tarifaClonada As Cosecha_Producto_Tarifa)
        mIsLoading = True
        mEditMode = True
        mIsNew = True

        mCosecha_Producto_TarifaActual = tarifaClonada
        mdbContext.Cosecha_Producto_Tarifa.Add(mCosecha_Producto_TarifaActual)

        ' Copio las escalas porque de otra manera no anda
        If tarifaOriginal.TarifaSecadoTipo <> Constantes.PRODUCTO_TARIFA_SECADO_TIPO_FIJA Then
            For Each escala As Cosecha_Producto_TarifaEscala In tarifaOriginal.Cosecha_Producto_TarifaEscala
                tarifaClonada.Cosecha_Producto_TarifaEscala.Add(escala.Clone(False))
            Next
        End If

        buttonIndiceObtener.Visible = mIsNew

        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()
        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(formTarifas)
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Return
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

        ' Escalas de Secado
        toolstripEscala.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        pFillAndRefreshLists.Cosecha(comboboxCosecha, mCosecha_Producto_TarifaActual.IDCosecha, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, DateTime.MinValue, False, False, True)
        pFillAndRefreshLists.Producto(comboboxProducto, mCosecha_Producto_TarifaActual.IDProducto, False, True, False, False)

        pFillAndRefreshLists.Planta(comboboxPlanta, mCosecha_Producto_TarifaActual.IDPlanta, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, False, True)
        pFillAndRefreshLists.EntidadLiquidacionServicio(comboboxEntidad, mCosecha_Producto_TarifaActual.IDEntidad, True, False, True)
        pFillAndRefreshLists.OrigenDestino(comboboxOrigen, mCosecha_Producto_TarifaActual.IDOrigen, False, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER, False, False, True)

        tabControlExtension = New CardonerSistemas.TabControlExtension(tabcontrolMain)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mCosecha_Producto_TarifaActual = Nothing
        tabControlExtension = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mCosecha_Producto_TarifaActual
            ' General - Requeridos
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxCosecha, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .IDCosecha, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxProducto, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .IDProducto)
            updownIndice.Value = CS_ValueTranslation.FromObjectShortToControlUpDown(.Indice)
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)

            ' General - Opcionales
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxPlanta, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IDPlanta, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxEntidad, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IDEntidad)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(comboboxOrigen, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirst, .IDOrigen)
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
            SecadoTipoEscala_CheckedChanged(Nothing, New EventArgs())
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

        RefreshData_SecadoEscalas()
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mCosecha_Producto_TarifaActual
            ' General - Requeridos
            .IDCosecha = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxCosecha.SelectedValue).Value
            .IDProducto = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxProducto.SelectedValue).Value
            .Indice = CS_ValueTranslation.FromControlUpDownToObjectShort(updownIndice.Value).Value
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)

            ' General - Opcionales
            .IDPlanta = CS_ValueTranslation.FromControlComboBoxToObjectByte(comboboxPlanta.SelectedValue)
            .IDEntidad = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxEntidad.SelectedValue)
            .IDOrigen = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxOrigen.SelectedValue)
            .FechaDesde = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaDesde.Value, datetimepickerFechaDesde.Checked)
            .FechaHasta = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerFechaHasta.Value, datetimepickerFechaHasta.Checked)

            ' Tarifas - Varias
            .TarifaParitariaImporte = currencytextboxTarifaParitariaImporte.DecimalValue
            .TarifaZarandeoImporte = currencytextboxTarifaZarandeo.DecimalValue
            .TarifaFumigadoImporte = currencytextboxTarifaFumigadoImporte.DecimalValue
            .TarifaMezclaImporte = currencytextboxTarifaMezcladoImporte.DecimalValue

            ' Tarifas - Secado
            If radiobuttonSecadoTipoFijo.Checked Then
                .TarifaSecadoTipo = Constantes.PRODUCTO_TARIFA_SECADO_TIPO_FIJA
            ElseIf radiobuttonSecadoTipoEscala.Checked Then
                .TarifaSecadoTipo = Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA
            End If
            .TarifaSecadoInicialPunto = Convert.ToDecimal(doubletextboxTarifaSecadoInicialPunto.DoubleValue)
            .TarifaSecadoInicialImporte = currencytextboxTarifaSecadoInicialImporte.DecimalValue
            .TarifaSecadoPuntoExcesoImporte = currencytextboxTarifaSecadoPuntoExcesoImporte.DecimalValue
            .TarifaSecadoHumedadBase = Convert.ToDecimal(doubletextboxTarifaSecadoHumedadBase.DoubleValue)
            .TarifaSecadoHumedadMargenLibre = Convert.ToDecimal(doubletextboxTarifaSecadoMargenLibre.DoubleValue)
            If radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.Checked Then
                .TarifaSecadoHumedadRedondeoPuntoTipo = Constantes.PRODUCTO_TARIFA_SECADO_REDONDEOPUNTO_TIPO_NINGUNO
            ElseIf radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.Checked Then
                .TarifaSecadoHumedadRedondeoPuntoTipo = Constantes.PRODUCTO_TARIFA_SECADO_REDONDEOPUNTO_TIPO_ENTERO
            ElseIf radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.Checked Then
                .TarifaSecadoHumedadRedondeoPuntoTipo = Constantes.PRODUCTO_TARIFA_SECADO_REDONDEOPUNTO_TIPO_SUPERIOR
            ElseIf radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.Checked Then
                .TarifaSecadoHumedadRedondeoPuntoTipo = Constantes.PRODUCTO_TARIFA_SECADO_REDONDEOPUNTO_TIPO_INFERIOR
            End If

            ' Almacenaje
            If radiobuttonAlmacenajeTipoDiasGraciaFijo.Checked Then
                .AlmacenajeTipo = Constantes.ALMACENAJE_TIPO_DIAS_GRACIA_FIJO
            ElseIf radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.Checked Then
                .AlmacenajeTipo = Constantes.ALMACENAJE_TIPO_DIAS_GRACIA_SI_RETIRA_ANTES
            ElseIf radiobuttonAlmacenajeTipoFechaFija.Checked Then
                .AlmacenajeTipo = Constantes.ALMACENAJE_TIPO_FECHA_FIJA
            End If
            .AlmacenajeDiaGracia = CS_ValueTranslation_Syncfusion.FromControlToShort(integertextboxAlmacenajeDiaGracia)
            .AlmacenajeInicio = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(datetimepickerAlmacenajeInicio.Value, datetimepickerAlmacenajeInicio.Checked)
            .AlmacenajePorcentajeMensual = Convert.ToDecimal(percenttextboxAlmacenajePorcentajeMensual.PercentValue)
        End With
    End Sub

    Friend Sub RefreshData_SecadoEscalas(Optional PositionHumedadExcesoInicio As Decimal = 0, Optional RestoreCurrentPosition As Boolean = False)
        Dim listSecadoEscalas As List(Of Cosecha_Producto_TarifaEscala)

        If RestoreCurrentPosition Then
            If datagridviewTarifaSecadoEscala.CurrentRow Is Nothing Then
                PositionHumedadExcesoInicio = 0
            Else
                PositionHumedadExcesoInicio = CType(datagridviewTarifaSecadoEscala.CurrentRow.DataBoundItem, Cosecha_Producto_TarifaEscala).HumedadExcesoInicio
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listSecadoEscalas = mCosecha_Producto_TarifaActual.Cosecha_Producto_TarifaEscala.ToList()

            datagridviewTarifaSecadoEscala.AutoGenerateColumns = False
            datagridviewTarifaSecadoEscala.DataSource = listSecadoEscalas
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Escalas de Tarifas de Secado.")
            Me.Cursor = Cursors.Default
            Return
        End Try

        Me.Cursor = Cursors.Default

        If PositionHumedadExcesoInicio > 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewTarifaSecadoEscala.Rows
                If CType(CurrentRowChecked.DataBoundItem, Cosecha_Producto_TarifaEscala).HumedadExcesoInicio = PositionHumedadExcesoInicio Then
                    datagridviewTarifaSecadoEscala.CurrentCell = CurrentRowChecked.Cells(0)
                    Return
                End If
            Next
        End If
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

    Private Sub IndiceObtener(sender As Object, e As EventArgs) Handles buttonIndiceObtener.Click
        If Not (comboboxCosecha.SelectedValue Is Nothing OrElse comboboxProducto.SelectedValue Is Nothing) Then
            Dim IDCosecha As Byte = Convert.ToByte(comboboxCosecha.SelectedValue)
            Dim IDProducto As Byte = Convert.ToByte(comboboxProducto.SelectedValue)

            If mdbContext.Cosecha_Producto_Tarifa.Where(Function(cpt) cpt.IDCosecha = IDCosecha AndAlso cpt.IDProducto = IDProducto).Count = 0 Then
                updownIndice.Value = 1
            Else
                updownIndice.Value = mdbContext.Cosecha_Producto_Tarifa.Where(Function(cpt) cpt.IDCosecha = IDCosecha AndAlso cpt.IDProducto = IDProducto).Max(Function(cpt) cpt.Indice) + Convert.ToInt16(1)
            End If
        End If
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNombre.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

    Private Sub SecadoTipoEscala_CheckedChanged(sender As Object, e As EventArgs) Handles radiobuttonSecadoTipoEscala.CheckedChanged
        If radiobuttonSecadoTipoEscala.Checked Then
            tabControlExtension.ShowPage(tabpageSecadoEscala)
        Else
            tabControlExtension.HidePage(tabpageSecadoEscala)
        End If
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub Editar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.TARIFA_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub Cerrar_Click() Handles buttonCerrar.Click
        Me.Close()
    End Sub

    Private Sub Guardar_Click() Handles buttonGuardar.Click

        ' Verificar que estén todos los campos con datos coherentes
        If Not VerifyData() Then
            Return
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista de Cosecha_Producto_Tarifas para mostrar los cambios
                If CardonerSistemas.Forms.MdiChildIsLoaded(CType(pFormMDIMain, Form), "formTarifas") Then
                    Dim formTarifas As formTarifas = CType(CardonerSistemas.Forms.MdiChildGetInstance(CType(pFormMDIMain, Form), "formTarifas"), formTarifas)
                    formTarifas.RefreshData(mCosecha_Producto_TarifaActual.IDCosecha, mCosecha_Producto_TarifaActual.IDProducto, mCosecha_Producto_TarifaActual.Indice)
                    formTarifas = Nothing
                End If
            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity, CardonerSistemas.Database.EntityFramework.Errors.PrimaryKeyViolation
                        MsgBox("No se pueden guardar los cambios porque ya existe una Tarifa para la misma Cosecha y Producto con el mismo Índice.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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

#Region "Escalas Toolbar"

    Private Sub Escala_Agregar(sender As Object, e As EventArgs) Handles buttonEscala_Agregar.Click
        Me.Cursor = Cursors.WaitCursor

        datagridviewTarifaSecadoEscala.Enabled = False

        Dim Cosecha_Producto_TarifaEscalaNuevo As New Cosecha_Producto_TarifaEscala
        formTarifaSecadoEscala.LoadAndShow(True, True, Me, mCosecha_Producto_TarifaActual, Cosecha_Producto_TarifaEscalaNuevo)

        datagridviewTarifaSecadoEscala.Enabled = True

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MedioPago_Editar(sender As Object, e As EventArgs) Handles buttonEscala_Editar.Click
        If datagridviewTarifaSecadoEscala.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Escala de Tarifa para editar.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewTarifaSecadoEscala.Enabled = False

            Dim Cosecha_Producto_TarifaEscala_Actual As Cosecha_Producto_TarifaEscala

            Cosecha_Producto_TarifaEscala_Actual = CType(datagridviewTarifaSecadoEscala.SelectedRows(0).DataBoundItem, Cosecha_Producto_TarifaEscala)
            formTarifaSecadoEscala.LoadAndShow(True, True, Me, mCosecha_Producto_TarifaActual, Cosecha_Producto_TarifaEscala_Actual)

            datagridviewTarifaSecadoEscala.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub MedioPago_Eliminar(sender As Object, e As EventArgs) Handles buttonEscala_Eliminar.Click
        If datagridviewTarifaSecadoEscala.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Escala de Tarifa para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            Dim Cosecha_Producto_TarifaEscala_Eliminar As Cosecha_Producto_TarifaEscala
            Cosecha_Producto_TarifaEscala_Eliminar = CType(datagridviewTarifaSecadoEscala.SelectedRows(0).DataBoundItem, Cosecha_Producto_TarifaEscala)

            Dim Mensaje As String
            Mensaje = String.Format("Se eliminará la Escala de Tarifa seleccionada.{0}{0}Exceso de humedad inicial: {1}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, Cosecha_Producto_TarifaEscala_Eliminar.HumedadExcesoInicio)
            If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                mCosecha_Producto_TarifaActual.Cosecha_Producto_TarifaEscala.Remove(Cosecha_Producto_TarifaEscala_Eliminar)

                RefreshData_SecadoEscalas()

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub MedioPago_Ver(sender As Object, e As EventArgs) Handles datagridviewTarifaSecadoEscala.DoubleClick
        If datagridviewTarifaSecadoEscala.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Escala de Tarifa para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewTarifaSecadoEscala.Enabled = False

            Dim Cosecha_Producto_TarifaEscala_Actual As Cosecha_Producto_TarifaEscala

            Cosecha_Producto_TarifaEscala_Actual = CType(datagridviewTarifaSecadoEscala.SelectedRows(0).DataBoundItem, Cosecha_Producto_TarifaEscala)
            formTarifaSecadoEscala.LoadAndShow(mEditMode, False, Me, mCosecha_Producto_TarifaActual, Cosecha_Producto_TarifaEscala_Actual)

            datagridviewTarifaSecadoEscala.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Indice_Enter(sender As Object, e As EventArgs) Handles updownIndice.Enter
        updownIndice.Select(0, 5)
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerifyData() As Boolean
        ' Cosecha
        If comboboxCosecha.SelectedItem Is Nothing Then
            MsgBox("Debe especificar la Cosecha.", MsgBoxStyle.Information, My.Application.Info.Title)
            tabcontrolMain.SelectedTab = tabpageGeneral
            comboboxCosecha.Focus()
            Return False
        End If

        ' Producto
        If comboboxProducto.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Producto.", MsgBoxStyle.Information, My.Application.Info.Title)
            tabcontrolMain.SelectedTab = tabpageGeneral
            comboboxProducto.Focus()
            Return False
        End If

        ' Indice
        If updownIndice.Value < 1 Then
            MsgBox("El Índice debe ser mayor o igual a 1.", MsgBoxStyle.Information, My.Application.Info.Title)
            tabcontrolMain.SelectedTab = tabpageGeneral
            updownIndice.Focus()
            Return False
        End If

        ' Nombre
        If textboxNombre.Text.Trim().Length = 0 Then
            MsgBox("Debe especificar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            tabcontrolMain.SelectedTab = tabpageGeneral
            textboxNombre.Focus()
            Return False
        End If

        ' Fecha desde y hasta
        If datetimepickerFechaDesde.Checked AndAlso datetimepickerFechaHasta.Checked AndAlso DateDiff(DateInterval.Day, datetimepickerFechaHasta.Value, datetimepickerFechaDesde.Value) > 0 Then
            MsgBox("La fecha hasta debe ser posterior a la fecha desde.", MsgBoxStyle.Information, My.Application.Info.Title)
            tabcontrolMain.SelectedTab = tabpageGeneral
            datetimepickerFechaHasta.Focus()
            Return False
        End If

        ' Tipo de Tarifa de Secado
        If Not (radiobuttonSecadoTipoFijo.Checked OrElse radiobuttonSecadoTipoEscala.Checked) Then
            MsgBox("Deber especificar el Tipo de Tarifa de Secado.", MsgBoxStyle.Information, My.Application.Info.Title)
            tabcontrolMain.SelectedTab = tabpageTarifas
            Return False
        End If

        ' Tipo de Redondeo de Punto de Secado
        If Not (radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.Checked OrElse radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.Checked OrElse radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.Checked OrElse radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.Checked) Then
            MsgBox("Deber especificar el Tipo de Redondeo por Punto de Secado.", MsgBoxStyle.Information, My.Application.Info.Title)
            tabcontrolMain.SelectedTab = tabpageTarifas
            Return False
        End If

        ' Tipo de Almacenaje
        If Not (radiobuttonAlmacenajeTipoDiasGraciaFijo.Checked OrElse radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.Checked OrElse radiobuttonAlmacenajeTipoFechaFija.Checked) Then
            MsgBox("Deber especificar el Tipo de Almacenaje.", MsgBoxStyle.Information, My.Application.Info.Title)
            tabcontrolMain.SelectedTab = tabpageAlmacenaje
            Return False
        End If

        Return True
    End Function

#End Region

End Class