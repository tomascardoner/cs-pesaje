Public Class formProducto

#Region "Declarations"

    Private mdbContext As New CSPesajeContext(True)
    Private mProductoActual As Producto

    Private mIsLoading As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDProducto As Byte)
        mIsLoading = True
        mEditMode = EditMode

        If IDProducto = 0 Then
            ' Es Nuevo
            mProductoActual = New Producto
            With mProductoActual
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Producto.Add(mProductoActual)
        Else
            mProductoActual = mdbContext.Producto.Find(IDProducto)
        End If

        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(ParentForm)
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Exit Sub
        End If

        ' Toolbar
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        ' General
        textboxNombre.ReadOnly = Not mEditMode
        PercentTextBoxMermaVolatil.ReadOnly = Not mEditMode
        PercentTextBoxMermaHumedadBase.ReadOnly = Not mEditMode
        PercentTextBoxMermaHumedadManipuleo.ReadOnly = Not mEditMode
        checkboxUtilizaPlanta.Enabled = mEditMode
        checkboxUtilizaCosecha.Enabled = mEditMode
        checkboxUsoFrecuente.Enabled = mEditMode
        ComboBoxTicketPesada_IDReporte.Enabled = mEditMode

        ' Toolbars de Grillas
        toolstripMermasHumedad.Enabled = Not mEditMode
        toolstripPlantas.Enabled = Not mEditMode
        toolstripCosechas.Enabled = Not mEditMode

        ' Notas y auditoría
        textboxNotas.ReadOnly = Not mEditMode
        checkboxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Reporte(ComboBoxTicketPesada_IDReporte, Nothing, False, True)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)

        If Not Permisos.VerificarPermiso(Permisos.PRODUCTOMERMAHUMEDAD, False) Then
            tabcontrolMain.HideTabPageByName(tabpageMermasHumedad.Name)
        End If
        If Not Permisos.VerificarPermiso(Permisos.PRODUCTOPLANTA, False) Then
            tabcontrolMain.HideTabPageByName(tabpagePlantas.Name)
        End If
        If Not Permisos.VerificarPermiso(Permisos.PRODUCTOCOSECHA, False) Then
            tabcontrolMain.HideTabPageByName(tabpageCosechas.Name)
        End If
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mProductoActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mProductoActual
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            CS_ValueTranslation_Syncfusion.FromValueDecimalToControlPercentTextBox(.MermaVolatil, PercentTextBoxMermaVolatil)
            CS_ValueTranslation_Syncfusion.FromValueDecimalToControlPercentTextBox(.MermaHumedadBase, PercentTextBoxMermaHumedadBase)
            CS_ValueTranslation_Syncfusion.FromValueDecimalToControlPercentTextBox(.MermaHumedadManipuleo, PercentTextBoxMermaHumedadManipuleo)
            checkboxUtilizaPlanta.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.UtilizaPlanta)
            checkboxUtilizaCosecha.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.UtilizaCosecha)
            checkboxUsoFrecuente.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.UsoFrecuente)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxTicketPesada_IDReporte, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .TicketPesada_IDReporte)

            ' Datos de la pestaña Notas y Auditoría
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            textboxID.Text = .IDProductoFormatted
            textboxFechaHoraCreacion.Text = .FechaHoraCreacionFormatted
            textboxUsuarioCreacion.Text = .UsuarioCreacionFormatted
            textboxFechaHoraModificacion.Text = .FechaHoraModificacionFormatted
            textboxUsuarioModificacion.Text = .UsuarioModificacionFormatted
        End With

        'MermasHumedadRefreshData()
        'PlantasRefreshData()
        'CosechasRefreshData()
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mProductoActual
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .MermaVolatil = CS_ValueTranslation_Syncfusion.FromControlPercentTextBoxToObjectDecimal(PercentTextBoxMermaVolatil)
            .MermaHumedadBase = CS_ValueTranslation_Syncfusion.FromControlPercentTextBoxToObjectDecimal(PercentTextBoxMermaHumedadBase)
            .MermaHumedadManipuleo = CS_ValueTranslation_Syncfusion.FromControlPercentTextBoxToObjectDecimal(PercentTextBoxMermaHumedadManipuleo)
            .UtilizaPlanta = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxUtilizaPlanta.CheckState)
            .UtilizaCosecha = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxUtilizaCosecha.CheckState)
            .UsoFrecuente = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxUsoFrecuente.CheckState)
            .TicketPesada_IDReporte = CS_ValueTranslation.FromControlComboBoxToObjectShort(ComboBoxTicketPesada_IDReporte, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)

            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxNombre.GotFocus, textboxNotas.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub Editar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.PRODUCTO_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub CerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub Guardar_Click() Handles buttonGuardar.Click
        If textboxNombre.Text.Trim.Length = 0 Then
            tabcontrolMain.SelectedTab = tabpageGeneral
            MsgBox("Debe ingresar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNombre.Focus()
            Exit Sub
        End If

        ' Generar el ID nuevo
        If mProductoActual.IDProducto = 0 Then
            Using dbcMaxID As New CSPesajeContext(True)
                If dbcMaxID.Producto.Any() Then
                    mProductoActual.IDProducto = dbcMaxID.Producto.Max(Function(a) a.IDProducto) + CByte(1)
                Else
                    mProductoActual.IDProducto = 1
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mProductoActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mProductoActual.FechaHoraModificacion = Now

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formProductos.RefreshData(mProductoActual.IDProducto)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Producto con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case Else
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

#End Region

    '#Region "Mermas humedad"

    '    Friend Sub PuntajesRefreshData(Optional ByVal PositionFechaInicio As Date = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_DATE, Optional ByVal RestoreCurrentPosition As Boolean = False)
    '        Dim listPuntajes As List(Of ProductoPuntaje)

    '        If RestoreCurrentPosition Then
    '            If datagridviewMermasHumedad.CurrentRow Is Nothing Then
    '                PositionFechaInicio = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_DATE
    '            Else
    '                PositionFechaInicio = CType(datagridviewMermasHumedad.CurrentRow.DataBoundItem, ProductoPuntaje).FechaInicio
    '            End If
    '        End If

    '        Me.Cursor = Cursors.WaitCursor

    '        Try
    '            listPuntajes = mProductoActual.SiniestrosAsistenciasTipoPuntajes.OrderBy(Function(satp) satp.FechaInicio).ToList()

    '            datagridviewMermasHumedad.AutoGenerateColumns = False
    '            datagridviewMermasHumedad.DataSource = listPuntajes

    '        Catch ex As Exception
    '            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Puntajes del Tipo de Asistencia a Siniestros.")
    '            Me.Cursor = Cursors.Default
    '            Exit Sub
    '        End Try

    '        Me.Cursor = Cursors.Default

    '        If PositionFechaInicio <> CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_DATE Then
    '            For Each CurrentRowChecked As DataGridViewRow In datagridviewMermasHumedad.Rows
    '                If CType(CurrentRowChecked.DataBoundItem, ProductoPuntaje).FechaInicio = PositionFechaInicio Then
    '                    datagridviewMermasHumedad.CurrentCell = CurrentRowChecked.Cells(0)
    '                    Exit For
    '                End If
    '            Next
    '        End If
    '    End Sub

    '    Private Sub DetallesAgregar(sender As Object, e As EventArgs) Handles buttonMermasHumedadAgregar.Click
    '        Me.Cursor = Cursors.WaitCursor

    '        formProductoPuntaje.LoadAndShow(True, True, Me, mProductoActual, 0)

    '        Me.Cursor = Cursors.Default
    '    End Sub

    '    Private Sub DetallesEditar(sender As Object, e As EventArgs) Handles buttonMermasHumedadEditar.Click
    '        If datagridviewMermasHumedad.CurrentRow Is Nothing Then
    '            MsgBox("No hay ningún Puntaje del Tipo de Asistencia a Siniestros para editar.", vbInformation, My.Application.Info.Title)
    '        Else
    '            Me.Cursor = Cursors.WaitCursor

    '            formProductoPuntaje.LoadAndShow(True, True, Me, mProductoActual, CType(datagridviewMermasHumedad.SelectedRows(0).DataBoundItem, ProductoPuntaje).IDProductoPuntaje)

    '            Me.Cursor = Cursors.Default
    '        End If
    '    End Sub

    '    Private Sub DetallesEliminar(sender As Object, e As EventArgs) Handles buttonMermasHumedadBorrar.Click
    '        If datagridviewMermasHumedad.CurrentRow Is Nothing Then
    '            MsgBox("No hay ningún Puntaje del Tipo de Asistencia a Siniestros para eliminar.", vbInformation, My.Application.Info.Title)
    '        Else
    '            Dim Mensaje As String

    '            Mensaje = String.Format("Se eliminará el Puntaje.{0}{0}Fecha de inicio: {1}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, CType(datagridviewMermasHumedad.SelectedRows(0).DataBoundItem, ProductoPuntaje).FechaInicio.ToShortDateString())
    '            If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
    '                Me.Cursor = Cursors.WaitCursor

    '                mProductoActual.SiniestrosAsistenciasTipoPuntajes.Remove(mProductoActual.SiniestrosAsistenciasTipoPuntajes.First(Function(satp) satp.FechaInicio = CType(datagridviewMermasHumedad.SelectedRows(0).DataBoundItem, ProductoPuntaje).FechaInicio))

    '                PuntajesRefreshData()

    '                Me.Cursor = Cursors.Default
    '            End If
    '        End If
    '    End Sub

    '    Private Sub DetallesVer(sender As Object, e As EventArgs) Handles datagridviewMermasHumedad.DoubleClick
    '        If datagridviewMermasHumedad.CurrentRow Is Nothing Then
    '            MsgBox("No hay ningún Puntaje del Tipo de Asistencia a Siniestros para ver.", vbInformation, My.Application.Info.Title)
    '        Else
    '            Me.Cursor = Cursors.WaitCursor

    '            formProductoPuntaje.LoadAndShow(mEditMode, False, Me, mProductoActual, CType(datagridviewMermasHumedad.SelectedRows(0).DataBoundItem, ProductoPuntaje).IDProductoPuntaje)

    '            Me.Cursor = Cursors.Default
    '        End If
    '    End Sub

    '#End Region

End Class