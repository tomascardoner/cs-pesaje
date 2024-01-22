Public Class formProducto

#Region "Declarations"

    Private mdbContext As New CSPesajeContext(True)
    Private mProductoActual As Producto

    Private mIsLoading As Boolean
    Private mEditMode As Boolean

    Private tabControlExtension As CardonerSistemas.TabControlExtension

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
            Return
        End If

        ' Toolbar
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = Not mEditMode
        buttonCerrar.Visible = Not mEditMode

        ' General
        textboxNombre.ReadOnly = Not mEditMode
        DoubleTextBoxMermaVolatil.ReadOnly = Not mEditMode
        DoubleTextBoxMermaHumedadBase.ReadOnly = Not mEditMode
        DoubleTextBoxMermaHumedadManipuleo.ReadOnly = Not mEditMode
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

        MermasHumedadRefreshData(mdbContext)
        PlantasRefreshData(mdbContext)
        CosechasRefreshData(mdbContext)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)

        tabControlExtension = New CardonerSistemas.TabControlExtension(tabcontrolMain)
        If Not Permisos.VerificarPermiso(Permisos.PRODUCTOMERMAHUMEDAD, False) Then
            tabControlExtension.HidePage(tabpageMermasHumedad)
        End If
        If Not Permisos.VerificarPermiso(Permisos.PRODUCTOPLANTA, False) Then
            tabControlExtension.HidePage(tabpagePlantas)
        End If
        If Not Permisos.VerificarPermiso(Permisos.PRODUCTOCOSECHA, False) Then
            tabControlExtension.HidePage(tabpageCosechas)
        End If
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mProductoActual = Nothing
        tabControlExtension = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mProductoActual
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            CS_ValueTranslation_Syncfusion.FromValueToControl(.MermaVolatil, DoubleTextBoxMermaVolatil)
            CS_ValueTranslation_Syncfusion.FromValueToControl(.MermaHumedadBase, DoubleTextBoxMermaHumedadBase)
            CS_ValueTranslation_Syncfusion.FromValueToControl(.MermaHumedadManipuleo, DoubleTextBoxMermaHumedadManipuleo)
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
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mProductoActual
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .MermaVolatil = CS_ValueTranslation_Syncfusion.FromControlToDecimal(DoubleTextBoxMermaVolatil)
            .MermaHumedadBase = CS_ValueTranslation_Syncfusion.FromControlToDecimal(DoubleTextBoxMermaHumedadBase)
            .MermaHumedadManipuleo = CS_ValueTranslation_Syncfusion.FromControlToDecimal(DoubleTextBoxMermaHumedadManipuleo)
            .UtilizaPlanta = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxUtilizaPlanta.CheckState)
            .UtilizaCosecha = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxUtilizaCosecha.CheckState)
            .UsoFrecuente = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxUsoFrecuente.CheckState)
            .TicketPesada_IDReporte = CS_ValueTranslation.FromControlComboBoxToObjectShort(ComboBoxTicketPesada_IDReporte.SelectedValue, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT)

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
            Return
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
                Return

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Return
            End Try
        End If

        Me.Close()
    End Sub

#End Region

#Region "Mermas humedad"

    Friend Sub MermasHumedadRefreshData(ByRef dbContext As CSPesajeContext, Optional ByVal PositionHumedad As Decimal = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_DECIMAL, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listHumedades As List(Of Producto_Humedad)

        If RestoreCurrentPosition Then
            If datagridviewMermasHumedad.CurrentRow Is Nothing Then
                PositionHumedad = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_DECIMAL
            Else
                PositionHumedad = CType(datagridviewMermasHumedad.CurrentRow.DataBoundItem, Producto_Humedad).Humedad
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listHumedades = dbContext.Producto_Humedad.Where(Function(ph) ph.IDProducto = mProductoActual.IDProducto).OrderBy(Function(ph) ph.Humedad).ToList()

            datagridviewMermasHumedad.AutoGenerateColumns = False
            datagridviewMermasHumedad.DataSource = listHumedades

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Mermas de Humedad del Producto.")
            Me.Cursor = Cursors.Default
            Return
        End Try

        Me.Cursor = Cursors.Default

        If PositionHumedad <> CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_DECIMAL Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMermasHumedad.Rows
                If CType(CurrentRowChecked.DataBoundItem, Producto_Humedad).Humedad = PositionHumedad Then
                    datagridviewMermasHumedad.CurrentCell = CurrentRowChecked.Cells(0)
                    Return
                End If
            Next
        End If
    End Sub

    Private Sub MermasHumedadAgregar(sender As Object, e As EventArgs) Handles buttonMermasHumedadAgregar.Click
        Me.Cursor = Cursors.WaitCursor

        formProductoMermaHumedad.LoadAndShow(True, Me, mProductoActual.IDProducto, 0)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub MermasHumedadEditar(sender As Object, e As EventArgs) Handles buttonMermasHumedadEditar.Click
        If datagridviewMermasHumedad.CurrentRow Is Nothing Then
            MessageBox.Show("No hay ninguna Merma de Humedad para editar.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Cursor = Cursors.WaitCursor

            formProductoMermaHumedad.LoadAndShow(True, Me, mProductoActual.IDProducto, CType(datagridviewMermasHumedad.SelectedRows(0).DataBoundItem, Producto_Humedad).Humedad)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub MermasHumedadBorrar(sender As Object, e As EventArgs) Handles buttonMermasHumedadBorrar.Click
        If datagridviewMermasHumedad.CurrentRow Is Nothing Then
            MessageBox.Show("No hay ninguna Merma de Humedad para borrar.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim Mensaje As String

            Mensaje = String.Format("Se borrará la Merma de Humedad.{0}{0}Humedad: {1}{0}{0}¿Confirma el borrado definitivo?", vbCrLf, CType(datagridviewMermasHumedad.SelectedRows(0).DataBoundItem, Producto_Humedad).HumedadFormatted())
            If MessageBox.Show(Mensaje, My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                Try
                    Dim ph As Producto_Humedad

                    ph = mdbContext.Producto_Humedad.Find(mProductoActual.IDProducto, CType(datagridviewMermasHumedad.SelectedRows(0).DataBoundItem, Producto_Humedad).Humedad)
                    mdbContext.Producto_Humedad.Remove(ph)
                    mdbContext.SaveChanges()
                Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                    Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                        Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                            MessageBox.Show("No se puede borrar la Merma de Humedad porque tiene datos relacionados.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Select
                Catch ex As Exception
                    CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al borrar la Merma de Humedad.")
                End Try

                MermasHumedadRefreshData(mdbContext)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub MermasHumedadVer(sender As Object, e As EventArgs) Handles datagridviewMermasHumedad.DoubleClick
        If mEditMode Then
            Return
        End If
        If datagridviewMermasHumedad.CurrentRow Is Nothing Then
            MessageBox.Show("No hay ninguna Merma de Humedad para ver.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Cursor = Cursors.WaitCursor

            formProductoMermaHumedad.LoadAndShow(False, Me, mProductoActual.IDProducto, CType(datagridviewMermasHumedad.SelectedRows(0).DataBoundItem, Producto_Humedad).Humedad)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Plantas"

    Friend Sub PlantasRefreshData(ByRef dbContext As CSPesajeContext, Optional ByVal PositionIDPlanta As Byte = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listPlantas As List(Of Planta)

        If RestoreCurrentPosition Then
            If datagridviewPlantas.CurrentRow Is Nothing Then
                PositionIDPlanta = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE
            Else
                PositionIDPlanta = CType(datagridviewPlantas.CurrentRow.DataBoundItem, Producto_Planta).IDPlanta
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listPlantas = (From p In dbContext.Planta
                           Join pp In dbContext.Producto_Planta On p.IDPlanta Equals pp.IDPlanta
                           Where pp.IDProducto = mProductoActual.IDProducto
                           Order By p.Nombre
                           Select p).ToList()

            datagridviewPlantas.AutoGenerateColumns = False
            datagridviewPlantas.DataSource = listPlantas

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Plantas del Producto.")
            Me.Cursor = Cursors.Default
            Return
        End Try

        Me.Cursor = Cursors.Default

        If PositionIDPlanta <> CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewPlantas.Rows
                If CType(CurrentRowChecked.DataBoundItem, Planta).IDPlanta = PositionIDPlanta Then
                    datagridviewPlantas.CurrentCell = CurrentRowChecked.Cells(0)
                    Return
                End If
            Next
        End If
    End Sub

    Private Sub PlantasAgregar(sender As Object, e As EventArgs) Handles buttonPlantasAgregar.Click
        Me.Cursor = Cursors.WaitCursor

        formProductoPlanta.LoadAndShow(True, Me, mProductoActual.IDProducto, 0)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub PlantasEditar(sender As Object, e As EventArgs) Handles buttonPlantasEditar.Click
        If datagridviewPlantas.CurrentRow Is Nothing Then
            MessageBox.Show("No hay ninguna Planta para editar.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Cursor = Cursors.WaitCursor

            formProductoPlanta.LoadAndShow(True, Me, mProductoActual.IDProducto, CType(datagridviewPlantas.SelectedRows(0).DataBoundItem, Planta).IDPlanta)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub PlantasBorrar(sender As Object, e As EventArgs) Handles buttonPlantasBorrar.Click
        If datagridviewPlantas.CurrentRow Is Nothing Then
            MessageBox.Show("No hay ninguna Planta para borrar.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim Mensaje As String

            Mensaje = String.Format("Se borrará la Planta.{0}{0}Planta: {1}{0}{0}¿Confirma el borrado definitivo?", vbCrLf, CType(datagridviewPlantas.SelectedRows(0).DataBoundItem, Planta).Nombre)
            If MessageBox.Show(Mensaje, My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                Try
                    Dim pp As Producto_Planta

                    pp = mdbContext.Producto_Planta.Find(mProductoActual.IDProducto, CType(datagridviewPlantas.SelectedRows(0).DataBoundItem, Planta).IDPlanta)
                    mdbContext.Producto_Planta.Remove(pp)
                    mdbContext.SaveChanges()
                Catch dbuex As Entity.Infrastructure.DbUpdateException
                    Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                        Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                            MessageBox.Show("No se puede borrar la Planta porque tiene datos relacionados.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Select
                Catch ex As Exception
                    CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al borrar la Planta.")
                End Try

                PlantasRefreshData(mdbContext)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub PlantasVer(sender As Object, e As EventArgs) Handles datagridviewPlantas.DoubleClick
        If mEditMode Then
            Return
        End If
        If datagridviewPlantas.CurrentRow Is Nothing Then
            MessageBox.Show("No hay ninguna Planta para ver.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Cursor = Cursors.WaitCursor

            formProductoPlanta.LoadAndShow(False, Me, mProductoActual.IDProducto, CType(datagridviewPlantas.SelectedRows(0).DataBoundItem, Planta).IDPlanta)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Cosechas"

    Public Class CosechasRowData
        Public Property IDCosecha As Byte
        Public Property Nombre As String
        Public Property Inicio As Date
        Public Property Fin As Date
        Public Property EsActivo As Boolean
    End Class

    Friend Sub CosechasRefreshData(ByRef dbContext As CSPesajeContext, Optional ByVal PositionIDCosecha As Byte = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim listCosechas As List(Of CosechasRowData)

        If RestoreCurrentPosition Then
            If datagridviewCosechas.CurrentRow Is Nothing Then
                PositionIDCosecha = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE
            Else
                PositionIDCosecha = CType(datagridviewCosechas.CurrentRow.DataBoundItem, CosechasRowData).IDCosecha
            End If
        End If

        Me.Cursor = Cursors.WaitCursor

        Try
            listCosechas = (From c In dbContext.Cosecha
                            Join pc In dbContext.Producto_Cosecha On c.IDCosecha Equals pc.IDCosecha
                            Where pc.IDProducto = mProductoActual.IDProducto
                            Order By c.Nombre
                            Select New CosechasRowData With {.IDCosecha = pc.IDCosecha, .Nombre = c.Nombre, .Inicio = pc.Inicio, .Fin = pc.Fin, .EsActivo = pc.EsActivo}).ToList()

            datagridviewCosechas.AutoGenerateColumns = False
            datagridviewCosechas.DataSource = listCosechas

        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Cosechas del Producto.")
            Me.Cursor = Cursors.Default
            Return
        End Try

        Me.Cursor = Cursors.Default

        If PositionIDCosecha <> CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewCosechas.Rows
                If CType(CurrentRowChecked.DataBoundItem, CosechasRowData).IDCosecha = PositionIDCosecha Then
                    datagridviewCosechas.CurrentCell = CurrentRowChecked.Cells(0)
                    Return
                End If
            Next
        End If
    End Sub

    Private Sub CosechasAgregar(sender As Object, e As EventArgs) Handles buttonCosechasAgregar.Click
        Me.Cursor = Cursors.WaitCursor

        formProductoCosecha.LoadAndShow(True, Me, mProductoActual.IDProducto, 0)

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub CosechasEditar(sender As Object, e As EventArgs) Handles buttonCosechasEditar.Click
        If datagridviewCosechas.CurrentRow Is Nothing Then
            MessageBox.Show("No hay ninguna Cosecha para editar.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Cursor = Cursors.WaitCursor

            formProductoCosecha.LoadAndShow(True, Me, mProductoActual.IDProducto, CType(datagridviewCosechas.SelectedRows(0).DataBoundItem, CosechasRowData).IDCosecha)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub CosechasBorrar(sender As Object, e As EventArgs) Handles buttonCosechasBorrar.Click
        If datagridviewCosechas.CurrentRow Is Nothing Then
            MessageBox.Show("No hay ninguna Cosecha para borrar.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim Mensaje As String

            Mensaje = String.Format("Se borrará la Cosecha.{0}{0}Cosecha: {1}{0}{0}¿Confirma el borrado definitivo?", vbCrLf, CType(datagridviewCosechas.SelectedRows(0).DataBoundItem, CosechasRowData).Nombre)
            If MessageBox.Show(Mensaje, My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Me.Cursor = Cursors.WaitCursor

                Try
                    Dim pc As Producto_Cosecha

                    pc = mdbContext.Producto_Cosecha.Find(mProductoActual.IDProducto, CType(datagridviewCosechas.SelectedRows(0).DataBoundItem, CosechasRowData).IDCosecha)
                    mdbContext.Producto_Cosecha.Remove(pc)
                    mdbContext.SaveChanges()
                Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                    Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                        Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                            MessageBox.Show("No se puede borrar la Cosecha porque tiene datos relacionados.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End Select
                Catch ex As Exception
                    CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al borrar la Cosecha.")
                End Try

                CosechasRefreshData(mdbContext)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub CosechasVer(sender As Object, e As EventArgs) Handles datagridviewCosechas.DoubleClick
        If mEditMode Then
            Return
        End If
        If datagridviewCosechas.CurrentRow Is Nothing Then
            MessageBox.Show("No hay ninguna Cosecha para ver.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Me.Cursor = Cursors.WaitCursor

            formProductoCosecha.LoadAndShow(False, Me, mProductoActual.IDProducto, CType(datagridviewCosechas.SelectedRows(0).DataBoundItem, CosechasRowData).IDCosecha)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class