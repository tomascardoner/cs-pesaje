Public Class formTarifas

#Region "Declarations"

    Friend Class GridRowData
        Public Property IDCosecha As Byte
        Public Property CosechaNombre As String
        Public Property IDProducto As Byte
        Public Property ProductoNombre As String
        Public Property Indice As Short
        Public Property IDPlanta As Byte?
        Public Property PlantaNombre As String
        Public Property IDEntidad As Integer?
        Public Property EntidadNombre As String
        Public Property IDOrigen As Integer?
        Public Property OrigenNombre As String
        Public Property Nombre As String
    End Class

    Private mlistTarifaBase As List(Of GridRowData)
    Private mlistTarifaFiltradaYOrdenada As List(Of GridRowData)

    Private mSkipFilterData As Boolean = False
    Private mBusquedaAplicada As Boolean = False
    Private mReportSelectionFormula As String

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance()
        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        InitializeFormAndControls()

        mSkipFilterData = False

        mOrdenColumna = columnNombre
        mOrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub

    Friend Sub InitializeFormAndControls()
        pFillAndRefreshLists.Cosecha(comboboxCosecha.ComboBox, Nothing, Nothing, DateTime.MinValue, True, False, True)
        pFillAndRefreshLists.Producto(comboboxProducto.ComboBox, Nothing, True, False, True, False)
        comboboxProducto.ComboBox.SelectedIndex = 0
    End Sub

    Private Sub Me_FormClosed() Handles Me.FormClosed
        mlistTarifaBase = Nothing
        mlistTarifaFiltradaYOrdenada = Nothing
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub RefreshData(Optional ByVal PositionIDCosecha As Byte = 0, Optional ByVal PositionIDProducto As Byte = 0, Optional ByVal PositionIndice As Short = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSPesajeContext(True)
                mlistTarifaBase = (From cpt In dbContext.Cosecha_Producto_Tarifa
                                   Join c In dbContext.Cosecha On cpt.IDCosecha Equals c.IDCosecha
                                   Join pr In dbContext.Producto On cpt.IDProducto Equals pr.IDProducto
                                   Group Join pl In dbContext.Planta On cpt.IDPlanta Equals pl.IDPlanta Into Planta_Group = Group
                                   From plg In Planta_Group.DefaultIfEmpty
                                   Group Join e In dbContext.Entidad On cpt.IDEntidad Equals e.IDEntidad Into Entidad_Group = Group
                                   From eg In Entidad_Group.DefaultIfEmpty
                                   Group Join o In dbContext.OrigenDestino On cpt.IDOrigen Equals o.IDOrigenDestino Into Origen_Group = Group
                                   From og In Origen_Group.DefaultIfEmpty
                                   Order By c.Nombre Descending, pr.Nombre, cpt.Indice
                                   Select New GridRowData With {.IDCosecha = c.IDCosecha, .CosechaNombre = c.Nombre, .IDProducto = pr.IDProducto, .ProductoNombre = pr.Nombre, .Indice = cpt.Indice, .IDPlanta = cpt.IDPlanta, .PlantaNombre = If(plg Is Nothing, "", plg.Nombre), .IDEntidad = cpt.IDEntidad, .EntidadNombre = If(eg Is Nothing, "", eg.Nombre), .IDOrigen = cpt.IDOrigen, .OrigenNombre = If(og Is Nothing, "", og.Nombre), .Nombre = cpt.Nombre}).ToList
            End Using
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Tarifas.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        Dim CurrentGridRowData As GridRowData

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDCosecha = 0
                PositionIDProducto = 0
                PositionIndice = 0
            Else
                CurrentGridRowData = CType(datagridviewMain.CurrentRow.DataBoundItem, GridRowData)
                PositionIDCosecha = CurrentGridRowData.IDCosecha
                PositionIDProducto = CurrentGridRowData.IDProducto
                PositionIndice = CurrentGridRowData.Indice
            End If
        End If

        FilterData()

        If PositionIDCosecha <> 0 AndAlso PositionIDProducto <> 0 AndAlso PositionIndice <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                CurrentGridRowData = CType(CurrentRowChecked.DataBoundItem, GridRowData)
                If CurrentGridRowData.IDCosecha = PositionIDCosecha AndAlso CurrentGridRowData.IDProducto = PositionIDProducto AndAlso CurrentGridRowData.Indice = PositionIndice Then
                    datagridviewMain.CurrentCell = CurrentRowChecked.Cells(columnNombre.Name)
                    Exit For
                End If
            Next
        End If

        CurrentGridRowData = Nothing
    End Sub

    Private Sub FilterData()

        If Not mSkipFilterData Then

            Me.Cursor = Cursors.WaitCursor

            Try
                ' Inicializo las variables
                mReportSelectionFormula = ""
                mlistTarifaFiltradaYOrdenada = mlistTarifaBase

                ' Filtro por Cosecha
                If CInt(comboboxCosecha.ComboBox.SelectedValue) <> CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE Then
                    mlistTarifaFiltradaYOrdenada = mlistTarifaFiltradaYOrdenada.Where(Function(t) t.IDCosecha = CByte(comboboxCosecha.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Producto
                If CInt(comboboxProducto.ComboBox.SelectedValue) <> CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE Then
                    mlistTarifaFiltradaYOrdenada = mlistTarifaFiltradaYOrdenada.Where(Function(t) t.IDProducto = CByte(comboboxProducto.ComboBox.SelectedValue)).ToList
                End If

                Select Case mlistTarifaFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Tarifas para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Tarifa.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Tarifas.", mlistTarifaFiltradaYOrdenada.Count)
                End Select
            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al filtrar los datos.")
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try

            OrderData()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub OrderData()
        ' Realizo las rutinas de ordenamiento
        bindingsourceMain.DataSource = mlistTarifaFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        mOrdenColumna.HeaderCell.SortGlyphDirection = mOrdenTipo
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewMain.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewMain.Columns(e.ColumnIndex), DataGridViewColumn)

        If ClickedColumn.Name = "" Then
            If ClickedColumn Is mOrdenColumna Then
                ' La columna clickeada es la misma por la que ya estaba ordenado, así que cambio la dirección del orden
                If mOrdenTipo = SortOrder.Ascending Then
                    mOrdenTipo = SortOrder.Descending
                Else
                    mOrdenTipo = SortOrder.Ascending
                End If
            Else
                ' La columna clickeada es diferencte a la que ya estaba ordenada.
                ' En primer lugar saco el ícono de orden de la columna vieja
                If Not mOrdenColumna Is Nothing Then
                    mOrdenColumna.HeaderCell.SortGlyphDirection = SortOrder.None
                End If

                ' Ahora preparo todo para la nueva columna
                mOrdenTipo = SortOrder.Ascending
                mOrdenColumna = ClickedColumn
            End If
        End If

        OrderData()
    End Sub

    Private Sub CambiarFiltros(sender As Object, e As EventArgs) Handles comboboxCosecha.SelectedIndexChanged, comboboxProducto.SelectedIndexChanged
        FilterData()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub Agregar_Click() Handles buttonAgregar.Click
        If Permisos.VerificarPermiso(Permisos.TARIFA_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formTarifa.LoadAndShow(True, Me, CType(comboboxCosecha.SelectedItem, Cosecha).IDCosecha, CType(comboboxProducto.SelectedItem, Producto).IDProducto, 0, False)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Copiar_Click() Handles buttonCopiar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Tarifa para copiar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.TARIFA_AGREGAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                Dim GridRowDataActual As GridRowData
                GridRowDataActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)

                formTarifa.LoadAndShow(True, Me, GridRowDataActual.IDCosecha, GridRowDataActual.IDProducto, GridRowDataActual.Indice, True)

                GridRowDataActual = Nothing

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Tarifa para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.TARIFA_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                Dim GridRowDataActual As GridRowData
                GridRowDataActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)

                formTarifa.LoadAndShow(True, Me, GridRowDataActual.IDCosecha, GridRowDataActual.IDProducto, GridRowDataActual.Indice, False)

                GridRowDataActual = Nothing

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Tarifa para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.TARIFA_ELIMINAR) Then
                Dim Mensaje As String
                Dim GridRowDataActual As GridRowData

                GridRowDataActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)
                Mensaje = String.Format("Se eliminará la Tarifa seleccionada.{0}{0}Cosecha: {1}{0}Producto: {2}{0}Índice: {3}{0}Nombre: {4}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.CosechaNombre, GridRowDataActual.ProductoNombre, GridRowDataActual.Indice, GridRowDataActual.Nombre)

                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Try
                        Using dbContext = New CSPesajeContext(True)
                            Dim TarifaActual As Cosecha_Producto_Tarifa
                            TarifaActual = dbContext.Cosecha_Producto_Tarifa.Find(GridRowDataActual.IDCosecha, GridRowDataActual.IDProducto, GridRowDataActual.Indice)

                            dbContext.Cosecha_Producto_Tarifa.Attach(TarifaActual)
                            dbContext.Cosecha_Producto_Tarifa.Remove(TarifaActual)
                            dbContext.SaveChanges()
                        End Using
                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Me.Cursor = Cursors.Default
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar la Tarifa porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Exit Sub
                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar la Tarifa.")
                    End Try

                    RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Tarifa para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            Dim GridRowDataActual As GridRowData
            GridRowDataActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)

            formTarifa.LoadAndShow(False, Me, GridRowDataActual.IDCosecha, GridRowDataActual.IDProducto, GridRowDataActual.Indice, False)

            GridRowDataActual = Nothing

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class