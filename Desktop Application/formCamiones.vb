Public Class formCamiones

#Region "Declarations"
    Friend Class GridRowData
        Public Property IDEntidad As Integer
        Public Property TransportistaNombre As String
        Public Property IDCamion As Byte
        Public Property Nombre As String
        Public Property DominioChasis As String
        Public Property DominioAcoplado As String
        Public Property EsActivo As Boolean
    End Class

    Private mlistCamionBase As List(Of GridRowData)
    Private mlistCamionFiltradaYOrdenada As List(Of GridRowData)

    Private mSkipFilterData As Boolean = False
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

        pFillAndRefreshLists.Entidad(comboboxTransportista.ComboBox, Nothing, False, False, True, False, 0, False, True, False, False)

        comboboxActivo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxActivo.SelectedIndex = COMBOBOX_ALLYESNO_YES_LISTINDEX

        mSkipFilterData = False

        mOrdenColumna = columnTransportista
        mOrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub

    Private Sub Me_FormClosed() Handles Me.FormClosed
        mlistCamionBase = Nothing
        mlistCamionFiltradaYOrdenada = Nothing
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub RefreshData(Optional ByVal PositionIDCamion As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSPesajeContext(True)
                mlistCamionBase = (From c In dbContext.Camion
                                   Join e In dbContext.Entidad On c.IDEntidad Equals e.IDEntidad
                                   Where c.IDCamion <> CS_Constants.FIELD_VALUE_OTHER_BYTE
                                   Select New GridRowData With {.IDEntidad = c.IDEntidad, .TransportistaNombre = e.Nombre, .IDCamion = c.IDCamion, .Nombre = c.Nombre, .DominioChasis = c.DominioChasis, .DominioAcoplado = c.DominioAcoplado, .EsActivo = c.EsActivo}).ToList
            End Using

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al leer los Camiones.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDCamion = 0
            Else
                PositionIDCamion = CType(datagridviewMain.CurrentRow.DataBoundItem, Camion).IDCamion
            End If
        End If

        FilterData()

        If PositionIDCamion <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDCamion = PositionIDCamion Then
                    datagridviewMain.CurrentCell = CurrentRowChecked.Cells(columnNombre.Name)
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub FilterData()

        If Not mSkipFilterData Then

            Me.Cursor = Cursors.WaitCursor

            Try
                ' Inicializo las variables
                mReportSelectionFormula = ""
                mlistCamionFiltradaYOrdenada = mlistCamionBase

                ' Filtro por Transportista
                If CInt(comboboxTransportista.ComboBox.SelectedValue) <> FIELD_VALUE_ALL_INTEGER Then
                    mlistCamionFiltradaYOrdenada = mlistCamionFiltradaYOrdenada.Where(Function(cam) cam.IDEntidad = CInt(comboboxTransportista.ComboBox.SelectedValue)).ToList
                End If

                ' Filtro por Activo
                Select Case comboboxActivo.SelectedIndex
                    Case COMBOBOX_ALLYESNO_ALL_LISTINDEX        ' Todos
                    Case COMBOBOX_ALLYESNO_YES_LISTINDEX        ' Sí
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Camion.EsActivo} = 1"
                        mlistCamionFiltradaYOrdenada = mlistCamionFiltradaYOrdenada.Where(Function(a) a.EsActivo).ToList
                    Case COMBOBOX_ALLYESNO_NO_LISTINDEX         ' No
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Camion.EsActivo} = 0"
                        mlistCamionFiltradaYOrdenada = mlistCamionFiltradaYOrdenada.Where(Function(a) Not a.EsActivo).ToList
                End Select

                Select Case mlistCamionFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Camiones para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Camión.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Camiones.", mlistCamionFiltradaYOrdenada.Count)
                End Select

            Catch ex As Exception
                CS_Error.ProcessError(ex, "Error al filtrar los datos.")
                Me.Cursor = Cursors.Default
                Exit Sub
            End Try

            OrderData()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub OrderData()
        ' Realizo las rutinas de ordenamiento
        Select Case mOrdenColumna.Name
            Case columnTransportista.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistCamionFiltradaYOrdenada = mlistCamionFiltradaYOrdenada.OrderBy(Function(col) col.TransportistaNombre).ThenBy(Function(col) col.Nombre).ToList
                Else
                    mlistCamionFiltradaYOrdenada = mlistCamionFiltradaYOrdenada.OrderByDescending(Function(col) col.TransportistaNombre).ThenByDescending(Function(col) col.Nombre).ToList
                End If
            Case columnNombre.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistCamionFiltradaYOrdenada = mlistCamionFiltradaYOrdenada.OrderBy(Function(col) col.Nombre).ToList
                Else
                    mlistCamionFiltradaYOrdenada = mlistCamionFiltradaYOrdenada.OrderByDescending(Function(col) col.Nombre).ToList
                End If
            Case columnDominioChasis.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistCamionFiltradaYOrdenada = mlistCamionFiltradaYOrdenada.OrderBy(Function(col) col.DominioChasis).ToList
                Else
                    mlistCamionFiltradaYOrdenada = mlistCamionFiltradaYOrdenada.OrderByDescending(Function(col) col.DominioChasis).ToList
                End If
            Case columnDominioAcoplado.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistCamionFiltradaYOrdenada = mlistCamionFiltradaYOrdenada.OrderBy(Function(col) col.DominioAcoplado).ToList
                Else
                    mlistCamionFiltradaYOrdenada = mlistCamionFiltradaYOrdenada.OrderByDescending(Function(col) col.DominioAcoplado).ToList
                End If
        End Select
        bindingsourceMain.DataSource = mlistCamionFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        mOrdenColumna.HeaderCell.SortGlyphDirection = mOrdenTipo
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub TransportistaCambio() Handles comboboxTransportista.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub EsActivoCambio() Handles comboboxActivo.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewMain.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewMain.Columns(e.ColumnIndex), DataGridViewColumn)

        If ClickedColumn.Name = columnTransportista.Name Or ClickedColumn.Name = columnNombre.Name Or ClickedColumn.Name = columnDominioChasis.Name Or ClickedColumn.Name = columnDominioAcoplado.Name Then
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

#End Region

#Region "Main Toolbar"
    Private Sub Agregar_Click() Handles buttonAgregar.Click
        If Permisos.VerificarPermiso(Permisos.CAMION_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            Dim IDEntidadFiltro As Integer
            IDEntidadFiltro = CInt(comboboxTransportista.ComboBox.SelectedValue)
            If IDEntidadFiltro = CS_Constants.FIELD_VALUE_OTHER_INTEGER Then
                IDEntidadFiltro = 0
            End If
            formCamion.LoadAndShow(True, Me, IDEntidadFiltro, 0)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Camión para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.CAMION_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                Dim GridRowDataActual As GridRowData
                GridRowDataActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)
                formCamion.LoadAndShow(True, Me, GridRowDataActual.IDEntidad, GridRowDataActual.IDCamion)
                GridRowDataActual = Nothing

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Camión para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.CAMION_ELIMINAR) Then
                Dim GridRowDataActual As GridRowData
                GridRowDataActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)

                Dim Mensaje As String
                Mensaje = String.Format("Se eliminará el Camión seleccionado.{0}{0}Transportista: {1}{0}Camión: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.TransportistaNombre, GridRowDataActual.Nombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Try
                        Using dbContext = New CSPesajeContext(True)
                            Dim CamionActual As Camion
                            CamionActual = dbContext.Camion.Find(GridRowDataActual.IDEntidad, GridRowDataActual.IDCamion)

                            dbContext.Camion.Attach(CamionActual)
                            dbContext.Camion.Remove(CamionActual)
                            dbContext.SaveChanges()
                        End Using

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Me.Cursor = Cursors.Default
                        Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                            Case Errors.RelatedEntity
                                MsgBox("No se puede eliminar el Camión porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Exit Sub

                    Catch ex As Exception
                        CS_Error.ProcessError(ex, "Error al eliminar el Camión.")
                    End Try

                    RefreshData()

                    Me.Cursor = Cursors.Default
                End If

                GridRowDataActual = Nothing
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Camión para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            Dim GridRowDataActual As GridRowData
            GridRowDataActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)
            formCamion.LoadAndShow(False, Me, GridRowDataActual.IDEntidad, GridRowDataActual.IDCamion)
            GridRowDataActual = Nothing

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Imprimir_Listado() Handles menuitemImprimirListado.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Camión para imprimir el Listado.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.CAMION_IMPRIMIR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                Dim ReporteActual As New Reporte
                If ReporteActual.Open(My.Settings.ReportsPath & "\") Then
                    If ReporteActual.SetDatabaseConnection(pDatabase.DataSource, pDatabase.InitialCatalog, pDatabase.UserID, pDatabase.Password) Then
                        ReporteActual.RecordSelectionFormula = mReportSelectionFormula

                        MiscFunctions.PreviewCrystalReport(ReporteActual, "Listado de Camiones")
                    End If
                End If

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

#End Region

End Class