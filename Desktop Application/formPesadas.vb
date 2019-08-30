Public Class formPesadas

#Region "Declarations"

    Private WithEvents datetimepickerFechaDesdeHost As ToolStripControlHost
    Private WithEvents datetimepickerFechaHastaHost As ToolStripControlHost

    Friend Class GridRowData
        Public Property IDPesada As Integer
        Public Property FechaHoraInicio As Date
        Public Property FechaHoraFin As Date?
        Public Property ComprobanteNumero As String
        Public Property IDTitular As Integer
        Public Property TitularNombre As String
        Public Property IDProducto As Byte
        Public Property ProductoNombre As String
        Public Property Producto_TicketPesada_IDReporte As Short?
        Public Property IDPlanta As Byte?
        Public Property Tipo As String
        Public Property TipoNombre As String
        Public Property IDCosecha As Byte?
        Public Property CosechaNombre As String
        Public Property IDOrigen As Integer?
        Public Property OrigenNombre As String
        Public Property IDDestino As Integer?
        Public Property DestinoNombre As String
        Public Property KilogramoBruto As Integer?
        Public Property KilogramoTara As Integer?
        Public Property KilogramoNeto As Integer?
        Public Property Humedad As Decimal?
        Public Property Zaranda As Decimal?
        Public Property KilogramoFinal As Integer?
        Public Property IDTransportista As Integer?
        Public Property TransportistaNombre As String
        Public Property IDChofer As Integer?
        Public Property ChoferNombre As String
        Public Property CamionNombreDominios As String
        Public Property EsVerificado As Boolean
        Public Property EsActivo As Boolean
    End Class

    Private mlistPesadaBase As List(Of GridRowData)
    Private mlistPesadaFiltradaYOrdenada As List(Of GridRowData)

    Private mFiltroPeriodoExpandido As Boolean = False
    Private mSkipFilterData As Boolean = False
    Private mRecordSelectionFormula_Refresh As String
    Private mRecordSelectionFormula_Filter As String

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

        mOrdenColumna = columnFechaHoraInicio
        mOrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub

    Friend Sub InitializeFormAndControls()
        ' Filtro de Fechas
        InicializarFiltroDeFechas()
        comboboxPeriodoTipo.Items.AddRange({"Día:", "Semana:", "Mes:", "Fecha"})
        FiltroPeriodoMostrar()
        labelFechaDesdeDiaSemana.Text = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value.ToString("dddd")

        ' Reportes
        Using dbContext As New CSPesajeContext(True)
            Dim listReportes As List(Of Reporte)
            Dim ReporteGrupoID As Byte = CS_Parameter_System.GetIntegerAsByte(Parametros.REPORTEGRUPO_PESADAS_REPORTES_ID)

            listReportes = dbContext.Reporte.Where(Function(r) r.IDReporteGrupo = ReporteGrupoID).OrderBy(Function(r) r.Nombre).ToList

            For Each ReporteActual As Reporte In listReportes
                Dim menuitemNew As New ToolStripMenuItem(ReporteActual.Nombre, Nothing, New EventHandler(AddressOf ImprimirReportes), "menuitemImprimir_" & ReporteActual.Archivo.Replace(" ", "_"))
                menuitemNew.Tag = ReporteActual.IDReporte

                buttonImprimir.DropDownItems.Add(menuitemNew)
            Next
        End Using

        ' Filtros Básicos
        pFillAndRefreshLists.Entidad(comboboxTitular.ComboBox, Nothing, False, True, False, False, FIELD_VALUE_NOTSPECIFIED_INTEGER, False, True, True, False)
        pFillAndRefreshLists.Producto(comboboxProducto.ComboBox, Nothing, True, False, True, False)
        comboboxProducto.ComboBox.SelectedIndex = 0
        pFillAndRefreshLists.Planta(comboboxPlanta.ComboBox, Nothing, FIELD_VALUE_NOTSPECIFIED_BYTE, True, False)
        pFillAndRefreshLists.Cosecha(comboboxCosecha.ComboBox, Nothing, Nothing, DateTime.MinValue, True, False, True)
        pFillAndRefreshLists.Entidad(comboboxTransportista.ComboBox, Nothing, False, False, True, False, FIELD_VALUE_NOTSPECIFIED_INTEGER, False, True, True, False)

        ' Filtros Avanzados
        comboboxEsVerificado.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxEsVerificado.SelectedIndex = COMBOBOX_ALLYESNO_ALL_LISTINDEX
        comboboxEsActivo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        comboboxEsActivo.SelectedIndex = COMBOBOX_ALLYESNO_YES_LISTINDEX

        toolstriptabFiltrosAvanzados.Visible = (Permisos.VerificarPermiso(Permisos.PESADA_MOSTRAR_VERIFICADO, False) Or Permisos.VerificarPermiso(Permisos.PESADA_MOSTRAR_ACTIVO, False))
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

        ' Leo la información desde la base de datos, filtrando por las fechas especificadas
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
                        ' A la Fecha Hasta, la asigno al valor máximo que puede existir, pero le resto un día y le sumo un segundo para contrarrestar la línea al final del Case,
                        ' adónde a la Fecha Hasta se le suma un día y se le resta un segundo, con lo cual produciría un error porque al sumarle un día, se excedería del rango
                        FechaHasta = Date.MaxValue.AddDays(-1).AddSeconds(1)
                    Case 2  ' anterior
                        FechaDesde = Date.MinValue
                        FechaHasta = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value
                    Case 3  ' entre
                        FechaDesde = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value
                        FechaHasta = CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Value
                End Select
        End Select
        ' A la fecha hasta, le sumo un día y le resto un segundo, para que quede conformado por la fecha original y la hora 23:59:59
        FechaHasta = FechaHasta.AddSeconds(-1).AddDays(1)

        ' Preparo el filtro para los Reportes
        mRecordSelectionFormula_Refresh = String.Format("{{Pesada.FechaHoraInicio}} >= DateTime({0}, {1}, {2}, {3}, {4}, {5}) AND {{Pesada.FechaHoraInicio}} <= DateTime({6}, {7}, {8}, {9}, {10}, {11})", FechaDesde.Year, FechaDesde.Month, FechaDesde.Day, FechaDesde.Hour, FechaDesde.Minute, FechaDesde.Second, FechaHasta.Year, FechaHasta.Month, FechaHasta.Day, FechaHasta.Hour, FechaHasta.Minute, FechaHasta.Second)

        Try
            Using dbContext As New CSPesajeContext(True)
                mlistPesadaBase = (From pe In dbContext.Pesada
                                   Join ent In dbContext.Entidad On pe.Titular_IDEntidad Equals ent.IDEntidad
                                   Join pr In dbContext.Producto On pe.IDProducto Equals pr.IDProducto
                                   Group Join co In dbContext.Cosecha On pe.IDCosecha Equals co.IDCosecha Into Cosecha_Group = Group
                                   From cog In Cosecha_Group.DefaultIfEmpty
                                   Group Join od In dbContext.OrigenDestino On pe.IDOrigen Equals od.IDOrigenDestino Into Origen_Group = Group
                                   From og In Origen_Group.DefaultIfEmpty
                                   Group Join od In dbContext.OrigenDestino On pe.IDDestino Equals od.IDOrigenDestino Into Destino_Group = Group
                                   From dg In Destino_Group.DefaultIfEmpty
                                   Group Join pe_ot In dbContext.Pesada_Otro On pe.IDPesada Equals pe_ot.IDPesada Into Pesada_Otro_Group = Group
                                   From pe_otg In Pesada_Otro_Group.DefaultIfEmpty
                                   Group Join pe_an In dbContext.Pesada_Analisis On pe.IDPesada Equals pe_an.IDPesada Into Pesada_Analisis_Group = Group
                                   From pe_ang In Pesada_Analisis_Group.DefaultIfEmpty
                                   Group Join etr In dbContext.Entidad On pe.Transportista_IDEntidad Equals etr.IDEntidad Into Transportista_Group = Group
                                   From trg In Transportista_Group.DefaultIfEmpty
                                   Group Join ech In dbContext.Entidad On pe.Chofer_IDEntidad Equals ech.IDEntidad Into Chofer_Group = Group
                                   From chg In Chofer_Group.DefaultIfEmpty
                                   Group Join ca In dbContext.Camion On pe.Transportista_IDEntidad Equals ca.IDEntidad And pe.IDCamion Equals ca.IDCamion Into Camion_Group = Group
                                   From cag In Camion_Group.DefaultIfEmpty
                                   Where pe.FechaHoraInicio >= FechaDesde And pe.FechaHoraInicio <= FechaHasta
                                   Select New GridRowData With {.IDPesada = pe.IDPesada, .FechaHoraInicio = pe.FechaHoraInicio, .FechaHoraFin = pe.FechaHoraFin, .ComprobanteNumero = pe.ComprobanteNumero, .IDTitular = pe.Titular_IDEntidad, .TitularNombre = If(pe.Titular_IDEntidad = CS_Constants.FIELD_VALUE_OTHER_INTEGER, pe_otg.Titular_Nombre, ent.Nombre), .IDProducto = pe.IDProducto, .ProductoNombre = If(pe.IDProducto = CS_Constants.FIELD_VALUE_OTHER_BYTE, pe_otg.Producto_Nombre, pr.Nombre), .Producto_TicketPesada_IDReporte = pr.TicketPesada_IDReporte, .IDPlanta = pe.IDPlanta, .Tipo = pe.Tipo, .TipoNombre = pe.TipoNombre, .IDCosecha = pe.IDCosecha, .CosechaNombre = If(cog Is Nothing, "", cog.Nombre), .IDOrigen = pe.IDOrigen, .OrigenNombre = If(pe.IDOrigen = CS_Constants.FIELD_VALUE_OTHER_INTEGER, pe_otg.Origen_Nombre, If(og Is Nothing, "", og.Nombre)), .IDDestino = pe.IDDestino, .DestinoNombre = If(pe.IDDestino = CS_Constants.FIELD_VALUE_OTHER_INTEGER, pe_otg.Destino_Nombre, If(dg Is Nothing, "", dg.Nombre)), .KilogramoBruto = pe.KilogramoBruto, .KilogramoTara = pe.KilogramoTara, .KilogramoNeto = pe.KilogramoNeto, .Humedad = If(pe_ang Is Nothing, Nothing, pe_ang.Humedad), .Zaranda = If(pe_ang Is Nothing, Nothing, pe_ang.Zaranda), .KilogramoFinal = pe.KilogramoFinal, .IDTransportista = pe.Transportista_IDEntidad, .TransportistaNombre = If(pe.Transportista_IDEntidad = CS_Constants.FIELD_VALUE_OTHER_INTEGER, pe_otg.Transportista_Nombre, If(trg Is Nothing, "", trg.Nombre)), .IDChofer = pe.Chofer_IDEntidad, .ChoferNombre = If(pe.Chofer_IDEntidad = CS_Constants.FIELD_VALUE_OTHER_INTEGER, pe_otg.Chofer_Nombre, If(chg Is Nothing, "", chg.Nombre)), .CamionNombreDominios = If(pe.IDCamion = CS_Constants.FIELD_VALUE_OTHER_BYTE, pe_otg.Camion_DominioChasis & If(pe_otg.Camion_DominioAcoplado Is Nothing, "", " - " & pe_otg.Camion_DominioAcoplado), If(cag Is Nothing, "", cag.NombreDominios)), .EsVerificado = pe.EsVerificado, .EsActivo = pe.EsActivo}).ToList
            End Using
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Pesadas.")
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
                mlistPesadaFiltradaYOrdenada = mlistPesadaBase

                ' FILTROS BÁSICOS
                ' ===============
                mRecordSelectionFormula_Filter = ""

                ' Filtro por Titular
                If CInt(comboboxTitular.ComboBox.SelectedValue) <> FIELD_VALUE_ALL_INTEGER Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.IDTitular = CInt(comboboxTitular.ComboBox.SelectedValue)).ToList
                    mRecordSelectionFormula_Filter &= String.Format(" AND {{Pesada.Titular_IDEntidad}} = {0}", comboboxTitular.ComboBox.SelectedValue)
                End If

                ' Filtro por Producto
                If CInt(comboboxProducto.ComboBox.SelectedValue) <> FIELD_VALUE_ALL_BYTE Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.IDProducto = CByte(comboboxProducto.ComboBox.SelectedValue)).ToList
                    mRecordSelectionFormula_Filter &= String.Format(" AND {{Pesada.IDProducto}} = {0}", comboboxProducto.ComboBox.SelectedValue)
                End If

                ' Filtro por Planta
                If CInt(comboboxPlanta.ComboBox.SelectedValue) <> FIELD_VALUE_ALL_BYTE Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.IDPlanta.HasValue AndAlso p.IDPlanta.Value = CByte(comboboxPlanta.ComboBox.SelectedValue)).ToList
                    mRecordSelectionFormula_Filter &= String.Format(" AND {{Pesada.IDPlanta}} = {0}", comboboxPlanta.ComboBox.SelectedValue)
                End If

                ' Filtro por Tipos de Pesada
                If Not (menuitemPesadaTipo_Entrada.Checked And menuitemPesadaTipo_Salida.Checked And menuitemPesadaTipo_Ninguno.Checked) Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) ((menuitemPesadaTipo_Entrada.Checked And p.Tipo = PESADA_TIPO_ENTRADA) Or (menuitemPesadaTipo_Salida.Checked And p.Tipo = PESADA_TIPO_SALIDA) Or (menuitemPesadaTipo_Ninguno.Checked And p.Tipo = PESADA_TIPO_NINGUNA))).ToList
                    mRecordSelectionFormula_Filter &= String.Format(" AND (({0} AND {{Pesada.Tipo}} = '{1}') OR ({2} AND {{Pesada.Tipo}} = '{3}') OR ({4} AND {{Pesada.Tipo}} = '{5}'))", menuitemPesadaTipo_Entrada.Checked, PESADA_TIPO_ENTRADA, menuitemPesadaTipo_Salida.Checked, PESADA_TIPO_SALIDA, menuitemPesadaTipo_Ninguno.Checked, PESADA_TIPO_NINGUNA)
                End If

                ' Filtro por Cosecha
                If CInt(comboboxCosecha.ComboBox.SelectedValue) <> FIELD_VALUE_ALL_BYTE Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.IDCosecha.HasValue AndAlso p.IDCosecha.Value = CByte(comboboxCosecha.ComboBox.SelectedValue)).ToList
                    mRecordSelectionFormula_Filter &= String.Format(" AND {{Pesada.IDCosecha}} = {0}", comboboxCosecha.ComboBox.SelectedValue)
                End If

                ' Filtro por Origen
                If CInt(comboboxOrigen.ComboBox.SelectedValue) <> FIELD_VALUE_ALL_INTEGER Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.IDOrigen.HasValue AndAlso p.IDOrigen.Value = CInt(comboboxOrigen.ComboBox.SelectedValue)).ToList
                    mRecordSelectionFormula_Filter &= String.Format(" AND {{Pesada.IDOrigen}} = {0}", comboboxOrigen.ComboBox.SelectedValue)
                End If

                ' Filtro por Destino
                If CInt(comboboxDestino.ComboBox.SelectedValue) <> FIELD_VALUE_ALL_INTEGER Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.IDDestino.HasValue AndAlso p.IDDestino.Value = CInt(comboboxDestino.ComboBox.SelectedValue)).ToList
                    mRecordSelectionFormula_Filter &= String.Format(" AND {{Pesada.IDDestino}} = {0}", comboboxDestino.ComboBox.SelectedValue)
                End If

                ' Filtro por Transportista
                If CInt(comboboxTransportista.ComboBox.SelectedValue) <> FIELD_VALUE_ALL_INTEGER Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.IDTransportista.HasValue AndAlso p.IDTransportista.Value = CInt(comboboxTransportista.ComboBox.SelectedValue)).ToList
                    mRecordSelectionFormula_Filter &= String.Format(" AND {{Pesada.Transportista_IDEntidad}} = {0}", comboboxTransportista.ComboBox.SelectedValue)
                End If

                ' Filtro por Chofer
                ' TODO: BUG: Cuando el combobox de Chofer está oculto porque no entra en la ventana, no refresca los items al cambiar el Transportista
                If CInt(comboboxChofer.ComboBox.SelectedValue) <> FIELD_VALUE_ALL_INTEGER Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.IDChofer.HasValue AndAlso p.IDChofer.Value = CInt(comboboxChofer.ComboBox.SelectedValue)).ToList
                    mRecordSelectionFormula_Filter &= String.Format(" AND {{Pesada.Chofer_IDEntidad}} = {0}", comboboxChofer.ComboBox.SelectedValue)
                End If

                ' FILTROS AVANZADOS
                ' =================

                ' Filtro por Verificado
                Select Case comboboxEsVerificado.SelectedIndex
                    Case COMBOBOX_ALLYESNO_ALL_LISTINDEX       ' Todos
                    Case COMBOBOX_ALLYESNO_YES_LISTINDEX       ' Sí
                        mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.EsVerificado).ToList
                        mRecordSelectionFormula_Filter &= " AND {Pesada.EsVerificado}"
                    Case COMBOBOX_ALLYESNO_NO_LISTINDEX        ' No
                        mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) Not p.EsVerificado).ToList
                        mRecordSelectionFormula_Filter &= " AND (NOT {Pesada.EsVerificado})"
                End Select

                ' Filtro por Activo
                Select Case comboboxEsActivo.SelectedIndex
                    Case COMBOBOX_ALLYESNO_ALL_LISTINDEX       ' Todos
                    Case COMBOBOX_ALLYESNO_YES_LISTINDEX       ' Sí
                        mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.EsActivo).ToList
                        mRecordSelectionFormula_Filter &= " AND {Pesada.EsActivo}"
                    Case COMBOBOX_ALLYESNO_NO_LISTINDEX        ' No
                        mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) Not p.EsActivo).ToList
                        mRecordSelectionFormula_Filter &= " AND (NOT {Pesada.EsActivo})"
                End Select

                Select Case mlistPesadaFiltradaYOrdenada.Count
                    Case 0
                        statuslabelMain.Text = String.Format("No hay Pesadas para mostrar.")
                    Case 1
                        statuslabelMain.Text = String.Format("Se muestra 1 Pesada.")
                    Case Else
                        statuslabelMain.Text = String.Format("Se muestran {0} Pesadas.", mlistPesadaFiltradaYOrdenada.Count)
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
            Case columnIDPesada.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.OrderBy(Function(col) col.IDPesada).ToList
                Else
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.OrderByDescending(Function(col) col.IDPesada).ToList
                End If
            Case columnComprobanteNumero.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.OrderBy(Function(col) col.ComprobanteNumero).ThenBy(Function(col) col.IDPesada).ToList
                Else
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.OrderByDescending(Function(col) col.ComprobanteNumero).ThenByDescending(Function(col) col.IDPesada).ToList
                End If
            Case columnFechaHoraInicio.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.OrderBy(Function(col) col.FechaHoraInicio).ToList
                Else
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.OrderByDescending(Function(col) col.FechaHoraInicio).ToList
                End If
            Case columnKilogramoNeto.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.OrderBy(Function(col) col.KilogramoNeto).ThenBy(Function(col) col.FechaHoraInicio).ToList
                Else
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.OrderByDescending(Function(col) col.KilogramoNeto).ThenByDescending(Function(col) col.FechaHoraInicio).ToList
                End If

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
        labelFechaDesdeDiaSemana.Visible = (comboboxPeriodoTipo.SelectedIndex = 3)
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
    End Sub

    Private Sub FechaDesdeSiguiente() Handles buttonFechaDesdeSiguiente.Click
        CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value.AddDays(1)
    End Sub

    Private Sub FechaDesdeHoy() Handles buttonFechaDesdeHoy.Click
        CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value = DateAndTime.Today
    End Sub

    ' ///// Fecha Hasta /////
    Private Sub FechaHastaAnterior() Handles buttonFechaHastaAnterior.Click
        CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Value = CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Value.AddDays(-1)
    End Sub

    Private Sub FechaHastaSiguiente() Handles buttonFechaHastaSiguiente.Click
        CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Value = CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Value.AddDays(1)
    End Sub

    Private Sub FechaHastaHoy() Handles buttonFechaHastaHoy.Click
        CType(datetimepickerFechaHastaHost.Control, DateTimePicker).Value = DateAndTime.Today
    End Sub

    Private Sub FechaCambiar() Handles datetimepickerFechaDesdeHost.TextChanged, datetimepickerFechaHastaHost.TextChanged
        labelFechaDesdeDiaSemana.Text = CType(datetimepickerFechaDesdeHost.Control, DateTimePicker).Value.ToString("dddd")
        RefreshData()
    End Sub

    Private Sub PesadaTipo_Click() Handles menuitemPesadaTipo_Entrada.Click, menuitemPesadaTipo_Salida.Click, menuitemPesadaTipo_Ninguno.Click
        FilterData()
    End Sub

    Private Sub FiltrosBasicos_Click() Handles comboboxProducto.SelectedIndexChanged, comboboxPlanta.SelectedIndexChanged, comboboxCosecha.SelectedIndexChanged, comboboxOrigen.SelectedIndexChanged, comboboxDestino.SelectedIndexChanged, comboboxChofer.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub FiltrosAvanzados_Click() Handles comboboxEsVerificado.SelectedIndexChanged, comboboxEsActivo.SelectedIndexChanged
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

    Private Sub Titular_Change() Handles comboboxTitular.SelectedIndexChanged
        Dim SaveSkipFilterData As Boolean

        SaveSkipFilterData = mSkipFilterData
        mSkipFilterData = True

        pFillAndRefreshLists.OrigenDestino(comboboxOrigen.ComboBox, Nothing, True, CInt(comboboxTitular.ComboBox.SelectedValue), True, True, False)
        pFillAndRefreshLists.OrigenDestino(comboboxDestino.ComboBox, Nothing, True, CInt(comboboxTitular.ComboBox.SelectedValue), True, True, False)

        mSkipFilterData = SaveSkipFilterData

        FilterData()
    End Sub

    Private Sub Transportista_Change() Handles comboboxTransportista.SelectedIndexChanged
        Dim SaveSkipFilterData As Boolean

        SaveSkipFilterData = mSkipFilterData
        mSkipFilterData = True

        pFillAndRefreshLists.Entidad(comboboxChofer.ComboBox, Nothing, False, False, False, True, CInt(comboboxTransportista.ComboBox.SelectedValue), False, True, True, False)

        mSkipFilterData = SaveSkipFilterData

        FilterData()
    End Sub

    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles datagridviewMain.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(datagridviewMain.Columns(e.ColumnIndex), DataGridViewColumn)

        If ClickedColumn.Name = columnIDPesada.Name Or ClickedColumn.Name = columnComprobanteNumero.Name Or ClickedColumn.Name = columnFechaHoraInicio.Name Or ClickedColumn.Name = columnKilogramoNeto.Name Then
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
                Mensaje = String.Format("Se eliminará la Pesada seleccionada.{0}{0}Número: {1}{0}{0}Fecha/hora de inicio: {2}{0}{0}¿Confirma la eliminación definitiva?", vbCrLf, FormatNumber(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPesada, 0), FormatDateTime(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).FechaHoraInicio, DateFormat.GeneralDate))
                If MsgBox(Mensaje, CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                    Me.Cursor = Cursors.WaitCursor

                    Try
                        Using dbContext = New CSPesajeContext(True)
                            Dim PesadaActual As Pesada
                            PesadaActual = dbContext.Pesada.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPesada)

                            dbContext.Pesada.Attach(PesadaActual)
                            dbContext.Pesada.Remove(PesadaActual)
                            dbContext.SaveChanges()
                        End Using
                    Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                        Me.Cursor = Cursors.Default
                        Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                            Case CardonerSistemas.Database.EntityFramework.Errors.RelatedEntity
                                MsgBox("No se puede eliminar la Pesada porque tiene datos relacionados.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                        End Select
                        Exit Sub
                    Catch ex As Exception
                        CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar la Pesada.")
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

    Private Sub ImprimirTicketPesada(sender As Object, e As EventArgs) Handles buttonImprimir.ButtonClick, menuitemImprimir_TicketPesadaReducido.Click
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
                If Not CurrentRow.Producto_TicketPesada_IDReporte.HasValue Then
                    MsgBox("No hay ningún Reporte especificado para este Producto.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Exit Sub
                End If

                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                Using dbContext As New CSPesajeContext(True)
                    Dim ReporteActual As New Reporte

                    ReporteActual = dbContext.Reporte.Find(CurrentRow.Producto_TicketPesada_IDReporte.Value)
                    If Not ReporteActual Is Nothing Then
                        ReporteActual.ReporteParametros.Single(Function(rp) rp.Nombre = "IDPesada").Valor = CurrentRow.IDPesada
                        ReporteActual.ReporteParametros.Single(Function(rp) rp.Nombre = "EsReducido").Valor = sender.Equals(menuitemImprimir_TicketPesadaReducido)
                        If ReporteActual.Open(My.Settings.ReportsPath & "\" & ReporteActual.Archivo) Then
                            If ReporteActual.SetDatabaseConnection(pDatabase.DataSource, pDatabase.InitialCatalog, pDatabase.UserID, pDatabase.Password) Then
                                If My.Settings.Reporte_Pesada_Previsualizar = False Then
                                    ReporteActual.ReportObject.PrintToPrinter(1, False, 1, 100)
                                Else
                                    MiscFunctions.PreviewCrystalReport(ReporteActual, "Ticket Pesada N° " & Microsoft.VisualBasic.Strings.Format(CurrentRow.IDPesada, "N0"))
                                End If
                            End If
                        End If
                    End If
                End Using

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub ImprimirReportes(sender As Object, e As EventArgs)
        If datagridviewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Pesada para imprimir.", vbInformation, My.Application.Info.Title)
        Else
            If Permisos.VerificarPermiso(Permisos.REPORTE) Then

                Me.Cursor = Cursors.WaitCursor

                datagridviewMain.Enabled = False

                Using dbContext As New CSPesajeContext(True)
                    Dim ReporteActual As New Reporte

                    ReporteActual = dbContext.Reporte.Find(CInt(CType(sender, ToolStripMenuItem).Tag))
                    If Not ReporteActual Is Nothing Then
                        ReporteActual.ReporteParametros.Single(Function(rp) rp.Nombre = "Titulo").Valor = ReporteActual.Titulo
                        If ReporteActual.Open(My.Settings.ReportsPath & "\" & ReporteActual.Archivo) Then
                            If ReporteActual.RecordSelectionFormula <> "" Then
                                ReporteActual.RecordSelectionFormula &= " AND " & mRecordSelectionFormula_Refresh & mRecordSelectionFormula_Filter
                            Else
                                ReporteActual.RecordSelectionFormula = mRecordSelectionFormula_Refresh & mRecordSelectionFormula_Filter
                            End If
                            If ReporteActual.SetDatabaseConnection(pDatabase.DataSource, pDatabase.InitialCatalog, pDatabase.UserID, pDatabase.Password) Then
                                MiscFunctions.PreviewCrystalReport(ReporteActual, ReporteActual.Titulo)
                            End If
                        End If
                    End If
                End Using

                datagridviewMain.Enabled = True

                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub Tareas_CalcularMermas() Handles menuitemCalcularMermas.Click
        If datagridviewMain.Rows.Count = 0 Then
            MsgBox("No hay ninguna Pesada para calcular mermas.", vbInformation, My.Application.Info.Title)
            Exit Sub
        End If

        If MsgBox(String.Format("Se calcularán las mermas para todas las entradas mostradas.{0}{0}¿Desea continuar?", vbCrLf), CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            Try
                Using dbContext = New CSPesajeContext(True)
                    Dim PesadaActual As Pesada

                    For Each DataRowActual As DataGridViewRow In datagridviewMain.Rows
                        ' Muestro la fila de la grilla que voy a recalcular
                        datagridviewMain.CurrentCell = DataRowActual.Cells(0)
                        Application.DoEvents()

                        ' Leo la Pesada actual de la base de datos
                        PesadaActual = dbContext.Pesada.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPesada)

                        If PesadaActual.Tipo = PESADA_TIPO_ENTRADA Or PesadaActual.Tipo = PESADA_TIPO_SALIDA Then
                            ' Recalculo mermas
                            If PesadaActual.Pesada_Analisis Is Nothing Then
                                PesadaActual.Pesada_Analisis = New Pesada_Analisis
                            End If
                            PesadaActual.Pesada_Analisis.CalcularMermas(PesadaActual)
                        End If
                    Next

                    dbContext.SaveChanges()

                    RefreshData()
                End Using
            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                End Select
                datagridviewMain.Enabled = True
                Me.Cursor = Cursors.Default
                Exit Sub
            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al calcular mermas de la Pesada.")
            End Try

            If datagridviewMain.Rows.Count > 0 Then
                datagridviewMain.CurrentCell = datagridviewMain.Rows(0).Cells(0)
            End If

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Tareas_CalcularAcondicionamiento() Handles menuitemCalcularAcondicionamiento.Click
        If datagridviewMain.Rows.Count = 0 Then
            MsgBox("No hay ninguna Pesada para calcular el acondicionamiento.", vbInformation, My.Application.Info.Title)
            Exit Sub
        End If

        If MsgBox(String.Format("Se calculará el acondicionamiento para todas las entradas mostradas.{0}{0}¿Desea continuar?", vbCrLf), CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then

            Me.Cursor = Cursors.WaitCursor

            datagridviewMain.Enabled = False

            Try
                Using dbContext = New CSPesajeContext(True)
                    Dim PesadaActual As Pesada

                    For Each DataRowActual As DataGridViewRow In datagridviewMain.Rows
                        ' Muestro la fila de la grilla que voy a recalcular
                        datagridviewMain.CurrentCell = DataRowActual.Cells(0)
                        Application.DoEvents()

                        ' Leo la Pesada actual de la base de datos
                        PesadaActual = dbContext.Pesada.Find(CType(datagridviewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPesada)

                        If PesadaActual.Tipo = PESADA_TIPO_ENTRADA Then
                            ' Recalculo acondicionamiento
                            If PesadaActual.Pesada_Acondicionamiento Is Nothing Then
                                PesadaActual.Pesada_Acondicionamiento = New Pesada_Acondicionamiento
                            End If
                            PesadaActual.Pesada_Acondicionamiento.CalcularAcondicionamiento(PesadaActual)
                        End If
                    Next

                    dbContext.SaveChanges()

                    RefreshData()
                End Using
            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                End Select
                datagridviewMain.Enabled = True
                Me.Cursor = Cursors.Default
                Exit Sub
            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al calcular el acondicionamiento de la Pesada.")
            End Try

            If datagridviewMain.Rows.Count > 0 Then
                datagridviewMain.CurrentCell = datagridviewMain.Rows(0).Cells(0)
            End If

            datagridviewMain.Enabled = True

            Me.Cursor = Cursors.Default
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