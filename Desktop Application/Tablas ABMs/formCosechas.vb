Public Class formCosechas

#Region "Declarations"

    Private mlistCosechasBase As List(Of Cosecha)
    Private mlistCosechasFiltradaYOrdenada As List(Of Cosecha)

    Private mSkipFilterData As Boolean
    Private mReportSelectionFormula As String

    Private mOrdenTipo As SortOrder = SortOrder.Ascending

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)

        DataGridSetAppearance(datagridviewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        comboboxActivo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxActivo.SelectedIndex = 1

        mSkipFilterData = False

        RefreshData()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub RefreshData(Optional ByVal PositionIDCosecha As Byte = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)

        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSPesajeContext(True)
                mlistCosechasBase = dbContext.Cosecha.Where(Function(p) p.IDCosecha <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE).ToList
            End Using

        Catch ex As Exception

            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer lAs Cosechas.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDCosecha = 0
            Else
                PositionIDCosecha = CType(datagridviewMain.CurrentRow.DataBoundItem, Cosecha).IDCosecha
            End If
        End If

        FilterData()

        If PositionIDCosecha <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, Cosecha).IDCosecha = PositionIDCosecha Then
                    datagridviewMain.CurrentCell = CurrentRowChecked.Cells(0)
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
                mlistCosechasFiltradaYOrdenada = mlistCosechasBase.ToList

                'Filtro por Activo
                Select Case comboboxActivo.SelectedIndex
                    Case 0      ' Todos
                    Case 1      ' Sí
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Cosecha.EsActivo} = 1"
                        mlistCosechasFiltradaYOrdenada = mlistCosechasFiltradaYOrdenada.Where(Function(a) a.EsActivo).ToList
                    Case 2      ' No
                        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Cosecha.EsActivo} = 0"
                        mlistCosechasFiltradaYOrdenada = mlistCosechasFiltradaYOrdenada.Where(Function(a) Not a.EsActivo).ToList
                End Select

                Select Case mlistCosechasFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Cosechas para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Cosecha.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Cosechas.", mlistCosechasFiltradaYOrdenada.Count)
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
        If mOrdenTipo = SortOrder.Ascending Then
            mlistCosechasFiltradaYOrdenada = mlistCosechasFiltradaYOrdenada.OrderBy(Function(dgrd) dgrd.Nombre).ToList
        Else
            mlistCosechasFiltradaYOrdenada = mlistCosechasFiltradaYOrdenada.OrderByDescending(Function(dgrd) dgrd.Nombre).ToList
        End If

        datagridviewMain.AutoGenerateColumns = False
        datagridviewMain.DataSource = mlistCosechasFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        columnNombre.HeaderCell.SortGlyphDirection = mOrdenTipo
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            For Each RowCurrent As DataGridViewRow In datagridviewMain.Rows
                If RowCurrent.Cells(columnNombre.Name).Value.ToString.StartsWith(e.KeyChar, StringComparison.CurrentCultureIgnoreCase) Then
                    RowCurrent.Cells(columnNombre.Name).Selected = True
                    datagridviewMain.Focus()
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub CambioFiltros() Handles comboboxActivo.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewMain.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewMain.Columns(e.ColumnIndex), DataGridViewColumn)

        If ClickedColumn Is columnNombre Then
            ' La columna clickeada es la misma por la que ya estaba ordenado, así que cambio la dirección del orden
            If mOrdenTipo = SortOrder.Ascending Then
                mOrdenTipo = SortOrder.Descending
            Else
                mOrdenTipo = SortOrder.Ascending
            End If
        Else
            ' La columna clickeada es diferencte a la que ya estaba ordenada.
            ' En primer lugar saco el ícono de orden de la columna vieja
            If columnNombre IsNot Nothing Then
                columnNombre.HeaderCell.SortGlyphDirection = SortOrder.None
            End If

            ' Ahora preparo todo para la nueva columna
            mOrdenTipo = SortOrder.Ascending
        End If

        OrderData()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub Agregar_Click() Handles buttonAgregar.Click
        If Permisos.VerificarPermiso(Permisos.COSECHA_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            formCosecha.LoadAndShow(True, Me, 0)

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Cosecha para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.COSECHA_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                formCosecha.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, Cosecha).IDCosecha)

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Cosecha para borrar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.COSECHA_ELIMINAR) Then
                Me.Cursor = Cursors.WaitCursor


                Dim Mensaje As String

                Mensaje = String.Format("Se borrará la Cosecha seleccionada.{0}{0}Nombre: {1}{0}{0}¿Confirma el borrado definitivo?", vbCrLf, CType(datagridviewMain.SelectedRows(0).DataBoundItem, Cosecha).Nombre)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

                    Try
                        Using dbContext = New CSPesajeContext(True)
                            Dim CosechaEliminar As Cosecha

                            CosechaEliminar = dbContext.Cosecha.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, Cosecha).IDCosecha)
                            dbContext.Cosecha.Remove(CosechaEliminar)
                            dbContext.SaveChanges()
                            CosechaEliminar = Nothing
                        End Using

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar la Cosecha porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Me.Cursor = Cursors.Default
                        Exit Sub

                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar la Cosecha.")
                    End Try

                    RefreshData()

                End If

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Cosecha para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            formCosecha.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, Cosecha).IDCosecha)

            Me.Cursor = Cursors.Default
        End If
    End Sub

#End Region

End Class