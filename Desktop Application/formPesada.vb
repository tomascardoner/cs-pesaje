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

        ' Producto - Planta
        comboboxProducto.Enabled = mEditMode
        comboboxPlanta.Enabled = mEditMode
        groupboxTipo.Enabled = mEditMode
        comboboxCosecha.Enabled = mEditMode

        ' Titular
        comboboxTitular.Enabled = mEditMode
        comboboxOrigenDestino.Enabled = mEditMode

        ' Transporte
        comboboxTransportista.Enabled = mEditMode
        comboboxChofer.Enabled = mEditMode
        comboboxCamion.Enabled = mEditMode

        ' Kilogramos
        textboxKilogramoBruto.Enabled = mEditMode
        textboxKilogramoTara.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Producto(comboboxProducto, True, False, False)
        pFillAndRefreshLists.Transportista(comboboxTransportista, False, True)
    End Sub

    Friend Sub SetAppearance()

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
            If .IDPesada = 0 Then
                textboxIDPesada.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDPesada.Text = String.Format(.IDPesada.ToString, "G")
            End If

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
    Private Sub CambioProducto() Handles comboboxProducto.SelectedValueChanged
        pFillAndRefreshLists.Planta(comboboxPlanta, CByte(comboboxProducto.SelectedValue), False, False)
        CS_Control_ComboBox.SetSelectedValue(comboboxPlanta, SelectedItemOptions.NoneOrFirstIfUnique)
        pFillAndRefreshLists.Cosecha(comboboxCosecha, CByte(comboboxProducto.SelectedValue), datetimepickerFechaInicio.Value, False, False)
        CS_Control_ComboBox.SetSelectedValue(comboboxCosecha, SelectedItemOptions.NoneOrFirstIfUnique)
    End Sub

    Private Sub CambioPlanta() Handles comboboxPlanta.SelectedValueChanged
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
            End If
        End If
    End Sub

    Private Sub CambioTransportista() Handles comboboxTransportista.SelectedValueChanged
        pFillAndRefreshLists.Camion(comboboxCamion, CInt(comboboxTransportista.SelectedValue), True, True, False, True)
        pFillAndRefreshLists.Chofer(comboboxChofer, CInt(comboboxTransportista.SelectedValue), False, True)
    End Sub

    Private Sub CambioChofer() Handles comboboxChofer.SelectedValueChanged
        If comboboxChofer.SelectedIndex > 0 Then
            If CType(comboboxChofer.SelectedItem, Entidad).IDCamion.HasValue Then
                CS_Control_ComboBox.SetSelectedValue(comboboxCamion, SelectedItemOptions.ValueOrFirst, CType(comboboxChofer.SelectedItem, Entidad).IDCamion)
            End If
        End If
    End Sub

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxKilogramoBruto.GotFocus, textboxKilogramoTara.GotFocus, textboxKilogramoNeto.GotFocus
        CType(sender, Syncfusion.Windows.Forms.Tools.IntegerTextBox).SelectAll()
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

End Class