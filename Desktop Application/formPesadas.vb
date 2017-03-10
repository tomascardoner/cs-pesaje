Public Class formPesadas

#Region "Declarations"
    Private WithEvents datetimepickerFechaDesdeHost As ToolStripControlHost
    Private WithEvents datetimepickerFechaHastaHost As ToolStripControlHost

    Friend Class GridRowData
        Public Property IDPesada As Integer
        Public Property FechaHoraInicio As Date
        Public Property FechaHoraFin As Date?
        Public Property ComprobanteNumero As String
        Public Property TitularNombre As String
        Public Property ProductoNombre As String
        Public Property TipoNombre As String
        Public Property CosechaNombre As String
        Public Property OrigenDestinoNombre As String
        Public Property KilogramoBruto As Integer?
        Public Property KilogramoTara As Integer?
        Public Property KilogramoNeto As Integer?
        Public Property Humedad As Decimal?
        Public Property Zaranda As Decimal?
        Public Property KilogramoFinal As Integer?
        Public Property TransportistaNombre As String
        Public Property ChoferNombre As String
        Public Property CamionNombreDominios As String
    End Class

    Private mlistPesadaBase As List(Of GridRowData)
    Private mlistPesadaFiltradaYOrdenada As List(Of GridRowData)

    Private mFiltroPeriodoExpandido As Boolean = False
    Private mSkipFilterData As Boolean = False
    Private mReportSelectionFormula As String

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder
#End Region

#Region "Form stuff"
    Friend Sub SetAppearance()
        datagridviewMain.DefaultCellStyle.Font = My.Settings.GridsAndListsFont
        datagridviewMain.ColumnHeadersDefaultCellStyle.Font = My.Settings.GridsAndListsFont
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        InicializarFiltroDeFechas()

        comboboxPeriodoTipo.Items.AddRange({"Día:", "Semana:", "Mes:", "Fecha"})
        FiltroPeriodoMostrar()

        mSkipFilterData = False

        mOrdenColumna = columnFechaHoraInicio
        mOrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub

    Private Sub Me_FormClosed() Handles Me.FormClosed
        mlistPesadaBase = Nothing
        mlistPesadaFiltradaYOrdenada = Nothing
    End Sub

    Private Sub InicializarFiltroDeFechas()
        ' Create a new ToolStripControlHost, passing in a control.
        datetimepickerFechaDesdeHost = New ToolStripControlHost(New DateTimePicker())
        datetimepickerFechaHastaHost = New ToolStripControlHost(New DateTimePicker())

        ' Set the font on the ToolStripControlHost, this will affect the hosted control.
        'dateTimePickerHost.Font = New Font("Arial", 7.0F, FontStyle.Italic)

        ' Set the Width property, this will also affect the hosted control.
        datetimepickerFechaDesdeHost.Width = 100
        datetimepickerFechaDesdeHost.DisplayStyle = ToolStripItemDisplayStyle.Text
        datetimepickerFechaHastaHost.Width = 100
        datetimepickerFechaHastaHost.DisplayStyle = ToolStripItemDisplayStyle.Text

        ' Setting the Text property requires a string that converts to a  
        ' DateTime type since that is what the hosted control requires.
        datetimepickerFechaDesdeHost.Text = DateTime.Today.ToShortDateString
        datetimepickerFechaHastaHost.Text = DateTime.Today.ToShortDateString

        ' Cast the Control property back to the original type to set a  
        ' type-specific property. 
        CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Format = DateTimePickerFormat.Short
        CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Format = DateTimePickerFormat.Short

        ' Add the control host to the ToolStrip.
        toolstripgroupPeriodo.Items.Insert(toolstripgroupPeriodo.Items.IndexOf(buttonFechaDesdeSiguiente), datetimepickerFechaDesdeHost)
        toolstripgroupPeriodo.Items.Insert(toolstripgroupPeriodo.Items.IndexOf(buttonFechaHastaSiguiente), datetimepickerFechaHastaHost)

        datetimepickerFechaDesdeHost.Visible = False
        datetimepickerFechaHastaHost.Visible = False
    End Sub

#End Region

#Region "Load and Set Data"
    Friend Sub RefreshData(Optional ByVal PositionIDPesada As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim FechaDesde As Date
        Dim FechaHasta As Date

        If mSkipFilterData Then
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Select Case comboboxPeriodoTipo.SelectedIndex
            Case 0  ' Día
                Select Case comboboxPeriodoValor.SelectedIndex
                    Case 0  ' Hoy
                        FechaDesde = System.DateTime.Today
                        FechaHasta = System.DateTime.Today
                    Case 1  ' Ayer
                        FechaDesde = System.DateTime.Today.AddDays(-1)
                        FechaHasta = System.DateTime.Today.AddDays(-1)
                    Case 2  ' Anteayer
                        FechaDesde = System.DateTime.Today.AddDays(-2)
                        FechaHasta = System.DateTime.Today.AddDays(-2)
                    Case 3  ' Últimos 2
                        FechaDesde = System.DateTime.Today.AddDays(-1)
                        FechaHasta = System.DateTime.Today
                    Case 4  ' Últimos 3
                        FechaDesde = System.DateTime.Today.AddDays(-2)
                        FechaHasta = System.DateTime.Today
                End Select
            Case 1  ' Semana
                Select Case comboboxPeriodoValor.SelectedIndex
                    Case 0  ' Actual
                        FechaDesde = System.DateTime.Today.AddDays(-System.DateTime.Today.DayOfWeek)
                        FechaHasta = System.DateTime.Today
                    Case 1  ' Anterior
                        FechaDesde = System.DateTime.Today.AddDays(-System.DateTime.Today.DayOfWeek - 7)
                        FechaHasta = System.DateTime.Today.AddDays(-System.DateTime.Today.DayOfWeek - 1)
                    Case 2  ' Últimas 2
                        FechaDesde = System.DateTime.Today.AddDays(-System.DateTime.Today.DayOfWeek - 7)
                        FechaHasta = System.DateTime.Today
                End Select
            Case 2  ' Mes
                Select Case comboboxPeriodoValor.SelectedIndex
                    Case 0  ' Actual
                        FechaDesde = New Date(System.DateTime.Today.Year, System.DateTime.Today.Month, 1)
                        FechaHasta = System.DateTime.Today
                    Case 1  ' Anterior
                        FechaDesde = New Date(System.DateTime.Today.Year, System.DateTime.Today.AddMonths(-1).Month, 1)
                        FechaHasta = New Date(System.DateTime.Today.Year, System.DateTime.Today.AddMonths(-1).Month, New System.Globalization.GregorianCalendar().GetDaysInMonth(System.DateTime.Today.Year, System.DateTime.Today.AddMonths(-1).Month))
                    Case 2  ' Últimos 2
                        FechaDesde = New Date(System.DateTime.Today.Year, System.DateTime.Today.AddMonths(-1).Month, 1)
                        FechaHasta = System.DateTime.Today
                End Select
            Case 3  ' Fecha
                Select Case comboboxPeriodoValor.SelectedIndex
                    Case 0  ' igual
                        FechaDesde = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value
                        FechaHasta = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value
                    Case 1  ' posterior
                        FechaDesde = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value
                        FechaHasta = Date.MaxValue
                    Case 2  ' anterior
                        FechaDesde = Date.MinValue
                        FechaHasta = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value
                    Case 3  ' entre
                        FechaDesde = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value
                        FechaHasta = CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Value
                End Select
        End Select
        ' A la fecha desde, le sumo un día y le resto un segundo, para que quede conformado por la fecha original y la hora 23:59:59
        FechaHasta = FechaHasta.AddDays(1).AddSeconds(-1)

        Try
            Using dbContext As New CSPesajeContext(True)
                mlistPesadaBase = (From pe In dbContext.Pesada
                                   Join ent In dbContext.Entidad On pe.Titular_IDEntidad Equals ent.IDEntidad
                                   Join pr In dbContext.Producto On pe.IDProducto Equals pr.IDProducto
                                   Group Join co In dbContext.Cosecha On pe.IDCosecha Equals co.IDCosecha Into Cosecha_Group = Group
                                   From cog In Cosecha_Group.DefaultIfEmpty
                                   Group Join od In dbContext.OrigenDestino On pe.IDOrigenDestino Equals od.IDOrigenDestino Into OrigenDestino_Group = Group
                                   From odg In OrigenDestino_Group.DefaultIfEmpty
                                   Group Join pe_ot In dbContext.Pesada_Otro On pe.IDPesada Equals pe_ot.IDPesada Into Pesada_Otro_Group = Group
                                   From pe_otg In Pesada_Otro_Group.DefaultIfEmpty
                                   Group Join pe_an In dbContext.Pesada_Analisis On pe.IDPesada Equals pe_an.IDPesada Into Pesada_Analisis_Group = Group
                                   From pe_ang In Pesada_Analisis_Group.DefaultIfEmpty
                                   Group Join etr In dbContext.Entidad On pe.Transportista_IDEntidad Equals etr.IDEntidad Into Transportista_Group = Group
                                   From trg In Transportista_Group.DefaultIfEmpty
                                   Group Join ech In dbContext.Entidad On pe.Chofer_IDEntidad Equals ech.IDEntidad Into Chofer_Group = Group
                                   From chg In Chofer_Group.DefaultIfEmpty
                                   Group Join ca In dbContext.Camion On pe.IDCamion Equals ca.IDCamion Into Camion_Group = Group
                                   From cag In Camion_Group.DefaultIfEmpty
                                   Where pe.FechaHoraInicio >= FechaDesde And pe.FechaHoraInicio <= FechaHasta
                                   Select New GridRowData With {.IDPesada = pe.IDPesada, .FechaHoraInicio = pe.FechaHoraInicio, .FechaHoraFin = pe.FechaHoraFin, .ComprobanteNumero = pe.ComprobanteNumero, .TitularNombre = If(pe.Titular_IDEntidad = CS_Constants.FIELD_VALUE_OTHER_INTEGER, pe_otg.Titular_Nombre, ent.Nombre), .ProductoNombre = If(pe.IDProducto = CS_Constants.FIELD_VALUE_OTHER_BYTE, pe_otg.Producto_Nombre, pr.Nombre), .TipoNombre = pe.TipoNombre, .CosechaNombre = If(cog Is Nothing, "", cog.Nombre), .OrigenDestinoNombre = If(pe.IDOrigenDestino = CS_Constants.FIELD_VALUE_OTHER_INTEGER, pe_otg.OrigenDestino_Nombre, If(odg Is Nothing, "", odg.Nombre)), .KilogramoBruto = pe.KilogramoBruto, .KilogramoTara = pe.KilogramoTara, .KilogramoNeto = pe.KilogramoNeto, .Humedad = If(pe_ang Is Nothing, Nothing, pe_ang.Humedad), .Zaranda = If(pe_ang Is Nothing, Nothing, pe_ang.Zaranda), .TransportistaNombre = If(pe.Transportista_IDEntidad = CS_Constants.FIELD_VALUE_OTHER_INTEGER, pe_otg.Transportista_Nombre, If(trg Is Nothing, "", trg.Nombre)), .ChoferNombre = If(pe.Chofer_IDEntidad = CS_Constants.FIELD_VALUE_OTHER_INTEGER, pe_otg.Chofer_Nombre, If(chg Is Nothing, "", chg.Nombre)), .CamionNombreDominios = If(pe.IDCamion = CS_Constants.FIELD_VALUE_OTHER_BYTE, pe_otg.Camion_DominioChasis & If(pe_otg.Camion_DominioAcoplado Is Nothing, "", " - " & pe_otg.Camion_DominioAcoplado), If(cag Is Nothing, "", cag.NombreDominios))}).ToList
            End Using

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al leer las Pesadas.")
            Me.Cursor = Cursors.Default
            Exit Sub
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If datagridviewMain.CurrentRow Is Nothing Then
                PositionIDPesada = 0
            Else
                PositionIDPesada = CType(datagridviewMain.CurrentRow.DataBoundItem, Pesada).IDPesada
            End If
        End If

        FilterData()

        If PositionIDPesada <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In datagridviewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDPesada = PositionIDPesada Then
                    datagridviewMain.CurrentCell = CurrentRowChecked.Cells(columnIDPesada.Name)
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
                mlistPesadaFiltradaYOrdenada = mlistPesadaBase

                ' Filtro por Tipos de Entidad
                'If Not (menuitemEntidadTipo_Titular.Checked And menuitemEntidadTipo_Transportista.Checked And menuitemEntidadTipo_Chofer.Checked) Then
                '    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(ent) ((menuitemEntidadTipo_Titular.Checked And ent.EsTitular) Or (menuitemEntidadTipo_Transportista.Checked And ent.EsTransportista) Or (menuitemEntidadTipo_Chofer.Checked And ent.EsChofer))).ToList
                'End If

                '' Filtro por Activo
                'Select Case comboboxActivo.SelectedIndex
                '    Case 0      ' Todos
                '    Case FILTER_ACTIVO_YES_LISTINDEX       ' Sí
                '        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Entidad.EsActivo} = 1"
                '        mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(a) a.EsActivo).ToList
                '    Case FILTER_ACTIVO_NO_LISTINDEX       ' No
                '        mReportSelectionFormula &= IIf(mReportSelectionFormula.Length = 0, "", " AND ").ToString & "{Entidad.EsActivo} = 0"
                '        mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(a) Not a.EsActivo).ToList
                'End Select

                Select Case mlistPesadaFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Pesadas para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Pesada.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Pesadas.", mlistPesadaFiltradaYOrdenada.Count)
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
            'Case columnNombre.Name
            '    If mOrdenTipo = SortOrder.Ascending Then
            '        mlistEntidadFiltradaYOrdenada = mlistEntidadFiltradaYOrdenada.OrderBy(Function(col) col.Nombre).ToList
            '    Else
            '        mlistEntidadFiltradaYOrdenada = mlistEntidadFiltradaYOrdenada.OrderByDescending(Function(col) col.Nombre).ToList
            '    End If
        End Select
        bindingsourceMain.DataSource = mlistPesadaFiltradaYOrdenada

        ' Muestro el ícono de orden en la columna correspondiente
        mOrdenColumna.HeaderCell.SortGlyphDirection = mOrdenTipo
    End Sub
#End Region

#Region "Controls behavior"
    Private Sub Periodo_LauncherClick() Handles toolstripgroupPeriodo.LauncherClick
        mFiltroPeriodoExpandido = Not mFiltroPeriodoExpandido
        FiltroPeriodoMostrar()
    End Sub

    Private Sub PeriodoTipoSeleccionar() Handles comboboxPeriodoTipo.SelectedIndexChanged
        comboboxPeriodoValor.Items.Clear()
        Select Case comboboxPeriodoTipo.SelectedIndex
            Case 0  ' Día
                comboboxPeriodoValor.Items.AddRange({"Hoy", "Ayer", "Anteayer", "Últimos 2", "Últimos 3"})
            Case 1  ' Semana
                comboboxPeriodoValor.Items.AddRange({"Actual", "Anterior", "Últimas 2"})
            Case 2  ' Mes
                comboboxPeriodoValor.Items.AddRange({"Actual", "Anterior", "Últimos 2"})
            Case 3  ' Fecha
                comboboxPeriodoValor.Items.AddRange({"es igual a:", "es posterior a:", "es anterior a:", "está entre:"})
        End Select
        comboboxPeriodoValor.SelectedIndex = 0
    End Sub

    Private Sub PeriodoValorSeleccionar() Handles comboboxPeriodoValor.SelectedIndexChanged
        ' Fecha Desde
        buttonFechaDesdeAnterior.Visible = (comboboxPeriodoTipo.SelectedIndex = 3)
        datetimepickerFechaDesdeHost.Visible = (comboboxPeriodoTipo.SelectedIndex = 3)
        buttonFechaDesdeSiguiente.Visible = (comboboxPeriodoTipo.SelectedIndex = 3)
        buttonFechaDesdeHoy.Visible = (comboboxPeriodoTipo.SelectedIndex = 3)

        ' Fecha Hasta
        labelFechaY.Visible = (comboboxPeriodoTipo.SelectedIndex = 3 And comboboxPeriodoValor.SelectedIndex = 3)
        buttonFechaHastaAnterior.Visible = (comboboxPeriodoTipo.SelectedIndex = 3 And comboboxPeriodoValor.SelectedIndex = 3)
        datetimepickerFechaHastaHost.Visible = (comboboxPeriodoTipo.SelectedIndex = 3 And comboboxPeriodoValor.SelectedIndex = 3)
        buttonFechaHastaSiguiente.Visible = (comboboxPeriodoTipo.SelectedIndex = 3 And comboboxPeriodoValor.SelectedIndex = 3)
        buttonFechaHastaHoy.Visible = (comboboxPeriodoTipo.SelectedIndex = 3 And comboboxPeriodoValor.SelectedIndex = 3)

        RefreshData()
    End Sub

    ' ///// Fecha Desde /////
    Private Sub FechaDesdeAnterior() Handles buttonFechaDesdeAnterior.Click
        CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value.AddDays(-1)
        RefreshData()
    End Sub

    Private Sub FechaDesdeSiguiente() Handles buttonFechaDesdeSiguiente.Click
        CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value.AddDays(1)
        RefreshData()
    End Sub

    Private Sub FechaDesdeHoy() Handles buttonFechaDesdeHoy.Click
        CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value = DateAndTime.Today
        RefreshData()
    End Sub

    ' ///// Fecha Hasta /////
    Private Sub FechaHastaAnterior() Handles buttonFechaHastaAnterior.Click
        CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Value = CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Value.AddDays(-1)
        RefreshData()
    End Sub

    Private Sub FechaHastaSiguiente() Handles buttonFechaHastaSiguiente.Click
        CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Value = CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Value.AddDays(1)
        RefreshData()
    End Sub

    Private Sub FechaHastaHoy() Handles buttonFechaHastaHoy.Click
        CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Value = DateAndTime.Today
        RefreshData()
    End Sub

    Private Sub FechaCambiar() Handles datetimepickerFechaHastaHost.TextChanged, datetimepickerFechaHastaHost.TextChanged
        RefreshData()
    End Sub

    Private Sub PesadaTipo_Click() Handles menuitemPesadaTipo_Entrada.Click, menuitemPesadaTipo_Salida.Click, menuitemPesadaTipo_Ninguno.Click
        FilterData()
    End Sub

    Private Sub MarcarYDesmarcarTodo_Click(sender As Object, e As EventArgs) Handles menuitemPesadaTipo_MarcarTodos.Click, menuitemPesadaTipo_DesmarcarTodos.Click
        mSkipFilterData = True

        menuitemPesadaTipo_Entrada.Checked = (CType(sender, ToolStripMenuItem) Is menuitemPesadaTipo_MarcarTodos)
        menuitemPesadaTipo_Salida.Checked = (CType(sender, ToolStripMenuItem) Is menuitemPesadaTipo_MarcarTodos)
        menuitemPesadaTipo_Ninguno.Checked = (CType(sender, ToolStripMenuItem) Is menuitemPesadaTipo_MarcarTodos)

        mSkipFilterData = False

        FilterData()
    End Sub

    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewMain.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewMain.Columns(e.ColumnIndex), DataGridViewColumn)

        'If ClickedColumn.Name = columnNombre.Name Then
        '    If ClickedColumn Is mOrdenColumna Then
        '        ' La columna clickeada es la misma por la que ya estaba ordenado, así que cambio la dirección del orden
        '        If mOrdenTipo = SortOrder.Ascending Then
        '            mOrdenTipo = SortOrder.Descending
        '        Else
        '            mOrdenTipo = SortOrder.Ascending
        '        End If
        '    Else
        '        ' La columna clickeada es diferencte a la que ya estaba ordenada.
        '        ' En primer lugar saco el ícono de orden de la columna vieja
        '        If Not mOrdenColumna Is Nothing Then
        '            mOrdenColumna.HeaderCell.SortGlyphDirection = SortOrder.None
        '        End If

        '        ' Ahora preparo todo para la nueva columna
        '        mOrdenTipo = SortOrder.Ascending
        '        mOrdenColumna = ClickedColumn
        '    End If
        'End If

        OrderData()
    End Sub

#End Region

#Region "Main Toolbar"
    Private Sub Agregar_Click() Handles buttonAgregar.Click
        If Permisos.VerificarPermiso(Permisos.PESADA_AGREGAR) Then
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formPesada.LoadAndShow(True, Me, 0)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Editar_Click() Handles buttonEditar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Pesada para editar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PESADA_EDITAR) Then
                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                formPesada.LoadAndShow(True, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPesada)

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Eliminar_Click() Handles buttonEliminar.Click
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Pesada para eliminar.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PESADA_ELIMINAR) Then
                Dim Mensaje As String
                Mensaje = String.Format("Se eliminará la Pesada seleccionada.{0}{0}Número: {1}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, CType(datagridviewMain.SelectedRows(0).DataBoundItem, Pesada).IDPesada)
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Try
                        Using dbContext = New CSPesajeContext(True)
                            Dim PesadaActual As Pesada
                            PesadaActual = dbContext.Pesada.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, Pesada).IDPesada)

                            dbContext.Pesada.Attach(PesadaActual)
                            dbContext.Pesada.Remove(PesadaActual)
                            dbContext.SaveChanges()
                        End Using

                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Me.Cursor = Cursors.Default
                        Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                            Case Errors.RelatedEntity
                                MsgBox("No se puede eliminar la Pesada porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Exit Sub

                    Catch ex As Exception
                        CS_Error.ProcessError(ex, "Error al eliminar la Pesada.")
                    End Try

                    RefreshData()

                    Me.Cursor = Cursors.Default
                End If
            End If
        End If
    End Sub

    Private Sub Ver() Handles datagridviewMain.DoubleClick
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Pesada para ver.", vbInformation, My.Application.Info.Title)
        Else
            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            formPesada.LoadAndShow(False, Me, CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPesada)

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Imprimir(sender As Object, e As EventArgs) Handles buttonImprimir.ButtonClick, menuitemImprimir_TicketPesada.Click
        Dim CurrentRow As GridRowData

        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Pesada para imprimir.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.PESADA_IMPRIMIR) Then
                'If sender.Equals(buttonImprimir) Then
                '    If MsgBox("Se va a imprimir directamente el Comprobante seleccionado." & vbCrLf & vbCrLf & "¿Desea continuar?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.No Then
                '        Exit Sub
                '    End If
                'End If

                CurrentRow = CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData)

                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                Dim ReporteActual As New Reporte
                If ReporteActual.Open(My.Settings.ReportsPath & "\" & Constantes.REPORTE_TICKETPESADA) Then
                    If ReporteActual.SetDatabaseConnection(pDatabase.DataSource, pDatabase.InitialCatalog, pDatabase.UserID, pDatabase.Password) Then
                        ReporteActual.RecordSelectionFormula = "{Pesada.IDPesada} = " & CurrentRow.IDPesada

                        If sender.Equals(buttonImprimir) Then
                            ReporteActual.ReportObject.PrintToPrinter(1, False, 1, 100)
                        Else
                            MiscFunctions.PreviewCrystalReport(ReporteActual, "Ticket Pesada N° " & Microsoft.VisualBasic.Strings.Format(CurrentRow.IDPesada, "N0"))
                        End If
                    End If
                End If

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub
#End Region

#Region "Extra stuff"
    Private Sub FiltroPeriodoMostrar()
        comboboxPeriodoTipo.Visible = mFiltroPeriodoExpandido
        comboboxPeriodoValor.Visible = mFiltroPeriodoExpandido
        labelFecha.Visible = Not mFiltroPeriodoExpandido
        If Not mFiltroPeriodoExpandido Then
            comboboxPeriodoTipo.SelectedIndex = 3
            comboboxPeriodoValor.SelectedIndex = 0
        End If
    End Sub
#End Region

End Class