Public Class formOrigenesDestinos

#Region "Declarations"

    Friend Class GridRowData
        Public Property IDOrigenDestino As Integer
        Public Property Nombre As String
        Public Property Domicilio As String
        Public Property LocalidadNombre As String
        Public Property EsActivo As Boolean
    End Class

    Private mlistOrigenDestinoBase As List(Of GridRowData)
    Private mlistOrigenDestinoFiltradaYOrdenada As List(Of GridRowData)

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

        comboboxActivo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxActivo.SelectedIndex = CardonerSistemas.Constants.COMBOBOX_ALLYESNO_YES_LISTINDEX

        mSkipFilterData = False

        mOrdenColumna = columnNombre
        mOrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub

    Private Sub Me_FormClosed() Handles Me.FormClosed
        mlistOrigenDestinoBase = Nothing
        mlistOrigenDestinoFiltradaYOrdenada = Nothing
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub RefreshData(Optional ByVal PositionIDOrigenDestino As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSPesajeContext(True)
                mlistOrigenDestinoBase = (From od In dbContext.OrigenDestino
                                          Group Join l In dbContext.Localidad On od.IDProvincia Equals l.IDProvincia And od.IDLocalidad Equals l.IDLocalidad Into Localidad_Group = Group
                                          From lg In Localidad_Group.DefaultIfEmpty
                                          Where od.IDOrigenDestino <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER
                                          Select New GridRowData With {.IDOrigenDestino = od.IDOrigenDestino, .Nombre = od.Nombre, .Domicilio = od.Domicilio, .LocalidadNombre = If(od.IDProvincia Is Nothing, "", lg.Nombre), .EsActivo = od.EsActivo}).ToList
            End Using
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer los Orígenes-Destinos.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDOrigenDestino = 0
            Else
                PositionIDOrigenDestino = CType(datagridviewMain.CurrentRow.DataBoundItem, OrigenDestino).IDOrigenDestino
            End If
        End If

        FilterData()

        If PositionIDOrigenDestino <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDOrigenDestino = PositionIDOrigenDestino Then
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
                mlistOrigenDestinoFiltradaYOrdenada = mlistOrigenDestinoBase

                ' Filtro por Búsqueda en Nombre
                If mBusquedaAplicada Then
                    mlistOrigenDestinoFiltradaYOrdenada = mlistOrigenDestinoFiltradaYOrdenada.Where(Function(p) p.Nombre.ToLower.Contains(textboxBuscar.Text.ToLower.Trim)).ToList
                End If

                ' Filtro por Activo
                Select Case comboboxActivo.SelectedIndex
                    Case CardonerSistemas.Constants.COMBOBOX_ALLYESNO_ALL_LISTINDEX        ' Todos
                    Case CardonerSistemas.Constants.COMBOBOX_ALLYESNO_YES_LISTINDEX        ' Sí
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{OrigenDestino.EsActivo} = 1"
                        mlistOrigenDestinoFiltradaYOrdenada = mlistOrigenDestinoFiltradaYOrdenada.Where(Function(a) a.EsActivo).ToList
                    Case CardonerSistemas.Constants.COMBOBOX_ALLYESNO_NO_LISTINDEX         ' No
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{OrigenDestino.EsActivo} = 0"
                        mlistOrigenDestinoFiltradaYOrdenada = mlistOrigenDestinoFiltradaYOrdenada.Where(Function(a) Not a.EsActivo).ToList
                End Select

                Select Case mlistOrigenDestinoFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Orígenes-Destinos para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Origen-Destino.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Orígenes-Destinos.", mlistOrigenDestinoFiltradaYOrdenada.Count)
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
        Select Case mOrdenColumna.Name
            Case columnNombre.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistOrigenDestinoFiltradaYOrdenada = mlistOrigenDestinoFiltradaYOrdenada.OrderBy(Function(col) col.Nombre).ToList
                Else
                    mlistOrigenDestinoFiltradaYOrdenada = mlistOrigenDestinoFiltradaYOrdenada.OrderByDescending(Function(col) col.Nombre).ToList
                End If
            Case columnDomicilio.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistOrigenDestinoFiltradaYOrdenada = mlistOrigenDestinoFiltradaYOrdenada.OrderBy(Function(col) col.Domicilio).ThenBy(Function(col) col.Nombre).ToList
                Else
                    mlistOrigenDestinoFiltradaYOrdenada = mlistOrigenDestinoFiltradaYOrdenada.OrderByDescending(Function(col) col.Domicilio).ThenByDescending(Function(col) col.Nombre).ToList
                End If
            Case columnLocalidad.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistOrigenDestinoFiltradaYOrdenada = mlistOrigenDestinoFiltradaYOrdenada.OrderBy(Function(col) col.LocalidadNombre).ThenBy(Function(col) col.Nombre).ToList
                Else
                    mlistOrigenDestinoFiltradaYOrdenada = mlistOrigenDestinoFiltradaYOrdenada.OrderByDescending(Function(col) col.LocalidadNombre).ThenByDescending(Function(col) col.Nombre).ToList
                End If
        End Select
        bindingsourceMain.DataSource = mlistOrigenDestinoFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        mOrdenColumna.HeaderCell.SortGlyphDirection = mOrdenTipo
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Not textboxBuscar.Focused Then
            If Char.IsLetter(e.KeyChar) Then
                For Each RowCurrent As DataGridViewRow In datagridviewMain.Rows
                    If RowCurrent.Cells(columnNombre.Name).Value.ToString.StartsWith(e.KeyChar, StringComparison.CurrentCultureIgnoreCase) Then
                        RowCurrent.Cells(columnNombre.Name).Selected = True
                        datagridviewMain.Focus()
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub textboxBuscar_GotFocus() Handles textboxBuscar.GotFocus
        textboxBuscar.SelectAll()
    End Sub

    Private Sub textboxBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textboxBuscar.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            If textboxBuscar.Text.Trim.Length < 3 Then
                MsgBox("Se deben especificar al menos 3 letras para buscar.", MsgBoxStyle.Information, My.Application.Info.Title)
                textboxBuscar.Focus()
            Else
                mBusquedaAplicada = True
                FilterData()
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub buttonBuscarBorrar_Click() Handles buttonBuscarBorrar.Click
        If mBusquedaAplicada Then
            textboxBuscar.Clear()
            mBusquedaAplicada = False
            FilterData()
        End If
    End Sub

    Private Sub EsActivoCambio() Handles comboboxActivo.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewMain.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewMain.Columns(e.ColumnIndex), DataGridViewColumn)

        If ClickedColumn.Name = columnNombre.Name Or ClickedColumn.Name = columnDomicilio.Name Or ClickedColumn.Name = columnLocalidad.Name Then
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
        If Permisos.VerificarPermiso(Permisos.ORIGENDESTINO_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formOrigenDestino.LoadAndShow(True, Me, 0)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Origen-Destino para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.ORIGENDESTINO_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                Dim GridRowDataActual As GridRowData
                GridRowDataActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)
                formOrigenDestino.LoadAndShow(True, Me, GridRowDataActual.IDOrigenDestino)
                GridRowDataActual = Nothing

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Origen-Destino para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.ORIGENDESTINO_ELIMINAR) Then
                Dim GridRowDataActual As GridRowData
                GridRowDataActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)

                Dim Mensaje As String
                Mensaje = String.Format("Se eliminará el Origen-Destino seleccionado.{0}{0}Nombre: {1}{0}Domicilio: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, GridRowDataActual.Nombre, GridRowDataActual.Domicilio)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Try
                        Using dbContext = New CSPesajeContext(True)
                            Dim OrigenDestinoActual As OrigenDestino
                            OrigenDestinoActual = dbContext.OrigenDestino.Find(GridRowDataActual.IDOrigenDestino)

                            dbContext.OrigenDestino.Attach(OrigenDestinoActual)
                            dbContext.OrigenDestino.Remove(OrigenDestinoActual)
                            dbContext.SaveChanges()
                        End Using
                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Me.Cursor = Cursors.Default
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar el Origen-Destino porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Exit Sub
                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar el Origen-Destino.")
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
            MsgBox("No hay ningún Origen-Destino para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            Dim GridRowDataActual As GridRowData
            GridRowDataActual = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)
            formOrigenDestino.LoadAndShow(False, Me, GridRowDataActual.IDOrigenDestino)
            GridRowDataActual = Nothing

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Imprimir_Listado() Handles menuitemImprimirListado.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ningún Origen-Destino para imprimir el Listado.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.ORIGENDESTINO_IMPRIMIR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                Dim ReporteActual As New Reporte
                If ReporteActual.Open(My.Settings.ReportsPath & "\") Then
                    If ReporteActual.SetDatabaseConnection(pDatabase.DataSource, pDatabase.InitialCatalog, pDatabase.UserID, pDatabase.Password) Then
                        ReporteActual.RecordSelectionFormula = mReportSelectionFormula

                        MiscFunctions.PreviewCrystalReport(ReporteActual, "Listado de Orígenes-Destinos")
                    End If
                End If

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

#End Region

End Class