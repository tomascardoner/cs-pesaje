Public Class formEntidadesSeleccionar

#Region "Declarations"

    Private mlistEntidadBase As List(Of Entidad)
    Private mlistEntidadFiltradaYOrdenada As List(Of Entidad)

    Private mSkipFilterData As Boolean = False
    Private mBusquedaAplicada As Boolean = False

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder

#End Region

#Region "Form stuff"

    Friend Sub SetAppearance()
        datagridviewMain.DefaultCellStyle.Font = pAppearanceConfig.ListsFont
        datagridviewMain.ColumnHeadersDefaultCellStyle.Font = pAppearanceConfig.ListsFont
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
        mlistEntidadBase = Nothing
        mlistEntidadFiltradaYOrdenada = Nothing
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub RefreshData(Optional ByVal PositionIDEntidad As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Me.Cursor = Cursors.WaitCursor

        Try
            Using dbContext As New CSPesajeContext(True)
                mlistEntidadBase = dbContext.Entidad.ToList
            End Using
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Entidades.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDEntidad = 0
            Else
                PositionIDEntidad = CType(datagridviewMain.CurrentRow.DataBoundItem, Entidad).IDEntidad
            End If
        End If

        FilterData()

        If PositionIDEntidad <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, Entidad).IDEntidad = PositionIDEntidad Then
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
                mlistEntidadFiltradaYOrdenada = mlistEntidadBase

                ' Filtro por Búsqueda en Nombre
                If mBusquedaAplicada Then
                    mlistEntidadFiltradaYOrdenada = mlistEntidadFiltradaYOrdenada.Where(Function(p) p.Nombre.ToLower.Contains(textboxBuscar.Text.ToLower.Trim)).ToList
                End If

                ' Filtro por Tipos de Entidad
                If Not (menuitemEntidadTipo_Titular.Checked And menuitemEntidadTipo_Transportista.Checked And menuitemEntidadTipo_Chofer.Checked) Then
                    mlistEntidadFiltradaYOrdenada = mlistEntidadFiltradaYOrdenada.Where(Function(ent) ((menuitemEntidadTipo_Titular.Checked And ent.EsTitular) Or (menuitemEntidadTipo_Transportista.Checked And ent.EsTransportista) Or (menuitemEntidadTipo_Chofer.Checked And ent.EsChofer))).ToList
                End If

                ' Filtro por Activo
                Select Case comboboxActivo.SelectedIndex
                    Case CardonerSistemas.Constants.COMBOBOX_ALLYESNO_ALL_LISTINDEX        ' Todos
                    Case CardonerSistemas.Constants.COMBOBOX_ALLYESNO_YES_LISTINDEX        ' Sí
                        mlistEntidadFiltradaYOrdenada = mlistEntidadFiltradaYOrdenada.Where(Function(a) a.EsActivo).ToList
                    Case CardonerSistemas.Constants.COMBOBOX_ALLYESNO_NO_LISTINDEX         ' No
                        mlistEntidadFiltradaYOrdenada = mlistEntidadFiltradaYOrdenada.Where(Function(a) Not a.EsActivo).ToList
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
                    mlistEntidadFiltradaYOrdenada = mlistEntidadFiltradaYOrdenada.OrderBy(Function(col) col.Nombre).ToList
                Else
                    mlistEntidadFiltradaYOrdenada = mlistEntidadFiltradaYOrdenada.OrderByDescending(Function(col) col.Nombre).ToList
                End If
        End Select
        bindingsourceMain.DataSource = mlistEntidadFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        mOrdenColumna.HeaderCell.SortGlyphDirection = mOrdenTipo
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub formEntidadesSeleccionar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
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

    Private Sub menuitemEntidadTipo_Click() Handles menuitemEntidadTipo_Titular.Click, menuitemEntidadTipo_Transportista.Click, menuitemEntidadTipo_Chofer.Click
        FilterData()
    End Sub

    Private Sub MarcarYDesmarcarTodo_Click(sender As Object, e As EventArgs) Handles menuitemMarcarTodos.Click, menuitemDesmarcarTodos.Click
        mSkipFilterData = True

        menuitemEntidadTipo_Titular.Checked = (CType(sender, ToolStripMenuItem) Is menuitemMarcarTodos)
        menuitemEntidadTipo_Transportista.Checked = (CType(sender, ToolStripMenuItem) Is menuitemMarcarTodos)
        menuitemEntidadTipo_Chofer.Checked = (CType(sender, ToolStripMenuItem) Is menuitemMarcarTodos)

        mSkipFilterData = False

        FilterData()
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

    Private Sub comboboxActivo_SelectedIndexChanged() Handles comboboxActivo.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewMain.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewMain.Columns(e.ColumnIndex), DataGridViewColumn)

        If ClickedColumn.Name = columnNombre.Name Then
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

    Private Sub Seleccionar() Handles datagridviewMain.DoubleClick, buttonSeleccionar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Entidad para seleccionar.", vbInformation, My.Application.Info.Title)
        Else
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub Cancelar() Handles buttonCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub datagridviewMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles datagridviewMain.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Seleccionar()
        ElseIf e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Cancelar()
        End If
    End Sub

#End Region

End Class