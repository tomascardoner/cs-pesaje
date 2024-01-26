Public Class formPesadas

#Region "Declaraciones"

    Private mFiltroPeriodoExpandido As Boolean = False
    Private tabControlExtensionToolbar As CardonerSistemas.TabControlExtension

    ' Filtro de fechas
    Private WithEvents ToolStripControlHostFechaDesde As ToolStripControlHost
    Private WithEvents ToolStripControlHostFechaHasta As ToolStripControlHost

    Friend Class GridRowData
        Public Property IDPesada As Integer
        Public Property FechaHoraInicio As Date
        Public Property FechaHoraFin As Date?
        Public Property Ctg As Long?
        Public Property ComprobanteNumero As String
        Public Property IDTitular As Integer
        Public Property TitularNombre As String
        Public Property IDProducto As Byte
        Public Property ProductoNombre As String
        Public Property Producto_TicketPesada_IDReporte As Short?
        Public Property IDPlanta As Byte?
        Public Property PlantaNombre As String
        Public Property PlantaDepositoNombre As String
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

    Private mSkipFilterData As Boolean = False
    Private mRecordSelectionFormula_Refresh As String
    Private mRecordSelectionFormula_Filter As String

    Private mOrdenColumna As DataGridViewColumn
    Private mOrdenTipo As SortOrder

    Private mEntradaHumedadVaciaMostrarError As Boolean
    Private mEntradaZarandeoVacioMostrarError As Boolean

#End Region

#Region "Declaraciones de columnas para mostrar"

    Private WithEvents ToolStripControlHostCheckBoxColumnaNumero As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaInicio As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaFin As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaCtg As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaComprobante As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaPlanta As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaDeposito As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaTitular As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaProducto As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaTipo As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaCosecha As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaOrigen As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaDestino As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaKilosBruto As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaKilosTara As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaKilosNeto As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaHumedad As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaZarandeo As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaKilosFinal As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaTransportista As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaChofer As ToolStripControlHost
    Private WithEvents ToolStripControlHostCheckBoxColumnaCamión As ToolStripControlHost

#End Region

#Region "Cosas del form"

    Friend Sub SetAppearance()
        DataGridSetAppearance(DataGridViewMain)
    End Sub

    Private Sub Me_Load() Handles Me.Load
        SetAppearance()

        mSkipFilterData = True

        InitializeFormAndControls()

        mEntradaHumedadVaciaMostrarError = CS_Parameter_System.GetBoolean(Parametros.PESADA_ENTRADA_HUMEDAD_VACIA_MOSTRARERROR, True).Value
        mEntradaZarandeoVacioMostrarError = CS_Parameter_System.GetBoolean(Parametros.PESADA_ENTRADA_ZARANDEO_VACIO_MOSTRARERROR, True).Value

        mSkipFilterData = False

        mOrdenColumna = columnFechaHoraInicio
        mOrdenTipo = SortOrder.Ascending

        RefreshData()
    End Sub

    Friend Sub InitializeFormAndControls()
        tabControlExtensionToolbar = New CardonerSistemas.TabControlExtension(TabControlToolbar)

        ' Filtro de Fechas
        InicializarDateTimePickersParaFiltroDeFechas()
        CardonerSistemas.DateTime.FillPeriodTypesComboBox(ToolStripComboBoxPeriodoTipo.ComboBox, CardonerSistemas.DateTime.PeriodTypes.Month)
        FiltroPeriodoMostrar()
        ToolStripComboBoxPeriodoValor.Visible = False
        ToolStripLabelFechaDesdeDiaSemana.Text = CType(ToolStripControlHostFechaDesde.Control, DateTimePicker).Value.ToString("dddd")

        ' Reportes
        Using dbContext As New CSPesajeContext(True)
            Dim listReportes As List(Of Reporte)
            Dim ReporteGrupoID As Byte = CS_Parameter_System.GetIntegerAsByte(Parametros.REPORTEGRUPO_PESADAS_REPORTES_ID)

            listReportes = dbContext.Reporte.Where(Function(r) r.IDReporteGrupo = ReporteGrupoID).OrderBy(Function(r) r.Nombre).ToList

            For Each ReporteActual As Reporte In listReportes
                ToolStripButtonImprimir.DropDownItems.Add(
                    New ToolStripMenuItem(
                        ReporteActual.Nombre, Nothing, New EventHandler(AddressOf ImprimirReportes), "ToolStripMenuItemImprimir_" & ReporteActual.Archivo.Replace(" ", "_")) With {.Tag = ReporteActual.IDReporte}
                    )
            Next
        End Using

        ' Filtros Básicos
        pFillAndRefreshLists.Entidad(ToolStripComboBoxTitular.ComboBox, Nothing, False, True, False, False, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER, False, True, True, False)
        pFillAndRefreshLists.Producto(ToolStripComboBoxProducto.ComboBox, Nothing, True, False, True, False)
        ToolStripComboBoxProducto.ComboBox.SelectedIndex = 0
        pFillAndRefreshLists.Planta(ToolStripComboBoxPlanta.ComboBox, Nothing, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, True, False)
        pFillAndRefreshLists.Cosecha(ToolStripComboBoxCosecha.ComboBox, Nothing, Nothing, DateTime.MinValue, True, False, True)
        pFillAndRefreshLists.Entidad(ToolStripComboBoxTransportista.ComboBox, Nothing, False, False, True, False, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER, False, True, True, False)

        ' Filtros Avanzados
        ToolStripComboBoxVerificado.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        ToolStripComboBoxVerificado.SelectedIndex = CardonerSistemas.Constants.ComboBoxAllYesNo_AllListindex
        ToolStripComboBoxActivo.Items.AddRange({My.Resources.STRING_ITEM_ALL_MALE, My.Resources.STRING_YES, My.Resources.STRING_NO})
        ToolStripComboBoxActivo.SelectedIndex = CardonerSistemas.Constants.ComboBoxAllYesNo_YesListindex

        tabControlExtensionToolbar.PageVisible(TabPageToolbarAvanzados, Permisos.VerificarPermiso(Permisos.PESADA_MOSTRAR_VERIFICADO, False) OrElse Permisos.VerificarPermiso(Permisos.PESADA_MOSTRAR_ACTIVO, False))

        ' Columnas
        InicializarCheckBoxsParaSeleccionDeColumnas()
    End Sub

    Private Sub Me_FormClosed() Handles Me.FormClosed
        mlistPesadaBase = Nothing
        mlistPesadaFiltradaYOrdenada = Nothing
    End Sub

    Private Sub InicializarDateTimePickersParaFiltroDeFechas()
        ' Create a new ToolStripControlHost, passing in a control.
        ToolStripControlHostFechaDesde = New ToolStripControlHost(New DateTimePicker())
        ToolStripControlHostFechaHasta = New ToolStripControlHost(New DateTimePicker())

        ' Set the font on the ToolStripControlHost, this will affect the hosted control.
        'dateTimePickerHost.Font = New Font("Arial", 7.0F, FontStyle.Italic)

        ' Set the Width property, this will also affect the hosted control.
        ToolStripControlHostFechaDesde.Width = 100
        ToolStripControlHostFechaDesde.DisplayStyle = ToolStripItemDisplayStyle.Text
        ToolStripControlHostFechaHasta.Width = 100
        ToolStripControlHostFechaHasta.DisplayStyle = ToolStripItemDisplayStyle.Text

        ' Setting the Text property requires a string that converts to a
        ' DateTime type since that is what the hosted control requires.
        ToolStripControlHostFechaDesde.Text = DateTime.Today.ToShortDateString
        ToolStripControlHostFechaHasta.Text = DateTime.Today.ToShortDateString

        ' Cast the Control property back to the original type to set a
        ' type-specific property.
        CType(ToolStripControlHostFechaDesde.Control, DateTimePicker).Format = DateTimePickerFormat.Short
        CType(ToolStripControlHostFechaHasta.Control, DateTimePicker).Format = DateTimePickerFormat.Short

        ' Add the control host to the ToolStrip.
        ToolStripPeriodo.Items.Insert(ToolStripPeriodo.Items.IndexOf(ToolStripButtonFechaDesdeSiguiente), ToolStripControlHostFechaDesde)
        ToolStripPeriodo.Items.Insert(ToolStripPeriodo.Items.IndexOf(ToolStripButtonFechaHastaSiguiente), ToolStripControlHostFechaHasta)

        ToolStripControlHostFechaDesde.Visible = False
        ToolStripControlHostFechaHasta.Visible = False
    End Sub

    Private Function CrearHostControlConCheckBox(nombre As String, texto As String, chequeado As Boolean) As ToolStripControlHost
        Dim hostControl As ToolStripControlHost
        Dim checkBox As CheckBox

        checkBox = New CheckBox() With {
            .Name = $"CheckBoxColumna{nombre}",
            .Text = texto,
            .Checked = chequeado
        }
        hostControl = New ToolStripControlHost(checkBox) With {
            .Name = $"ToolStripControlHostCheckBox{nombre}",
            .Width = 100
        }
        Return hostControl
    End Function

    Private Sub InicializarCheckBoxsParaSeleccionDeColumnas()
        Dim clb As New CheckedListBox With {
            .CheckOnClick = True,
            .MultiColumn = True,
            .HorizontalScrollbar = False,
            .Width = 700
        }
        clb.Items.AddRange({"Número", "Inicio", "Fin", "C.T.G.", "Comprobante", "Planta", "Depósito", "Titular", "Producto", "Tipo", "Cosecha", "Origen", "Destino", "Kgs. Bruto", "Kgs. Tara", "Kgs. Neto", "Hum.", "Zar.", "Kgs. Final", "Transportista", "Chofer", "Camión"})
        'ToolStripControlHostCheckedListBoxColumnas = New ToolStripControlHost(clb) With {.Width = 700}
        'ToolStripExColumnas.Items.Add(ToolStripControlHostCheckedListBoxColumnas)
        'ToolStripExColumnas.Width = 700
    End Sub

#End Region

#Region "Leer y mostrar datos"

    Friend Sub RefreshData(Optional ByVal PositionIDPesada As Integer = 0, Optional ByVal RestoreCurrentPosition As Boolean = False)
        Dim FechaDesde As Date
        Dim FechaHasta As Date

        If mSkipFilterData Then
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        CardonerSistemas.DateTime.GetDatesFromPeriodTypeAndValue(CType(ToolStripComboBoxPeriodoTipo.SelectedIndex, CardonerSistemas.DateTime.PeriodTypes), CByte(ToolStripComboBoxPeriodoValor.SelectedIndex), FechaDesde, FechaHasta, CType(ToolStripControlHostFechaDesde.Control, DateTimePicker).Value, CType(ToolStripControlHostFechaHasta.Control, DateTimePicker).Value)

        ' Preparo el filtro para los Reportes
        mRecordSelectionFormula_Refresh = String.Format("{{Pesada.FechaHoraInicio}} >= DateTime({0}, {1}, {2}, {3}, {4}, {5}) AND {{Pesada.FechaHoraInicio}} <= DateTime({6}, {7}, {8}, {9}, {10}, {11})", FechaDesde.Year, FechaDesde.Month, FechaDesde.Day, FechaDesde.Hour, FechaDesde.Minute, FechaDesde.Second, FechaHasta.Year, FechaHasta.Month, FechaHasta.Day, FechaHasta.Hour, FechaHasta.Minute, FechaHasta.Second)

        Try
            Using dbContext As New CSPesajeContext(True)
#Disable Warning S3358 ' If operators should not be nested
                mlistPesadaBase = (From pe In dbContext.Pesada
                                   Join ent In dbContext.Entidad On pe.Titular_IDEntidad Equals ent.IDEntidad
                                   Join pr In dbContext.Producto On pe.IDProducto Equals pr.IDProducto
                                   Group Join co In dbContext.Cosecha On pe.IDCosecha Equals co.IDCosecha Into Cosecha_Group = Group
                                   From cog In Cosecha_Group.DefaultIfEmpty
                                   Group Join pl In dbContext.Planta On pe.IDPlanta Equals pl.IDPlanta Into Planta_Group = Group
                                   From plg In Planta_Group.DefaultIfEmpty
                                   Group Join pld In dbContext.PlantaDeposito On pe.IDPlanta Equals pld.IDPlanta And pe.IDDeposito Equals pld.IDDeposito Into PlantaDeposito_Group = Group
                                   From pldg In PlantaDeposito_Group.DefaultIfEmpty
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
                                   Where pe.FechaHoraInicio >= FechaDesde AndAlso pe.FechaHoraInicio <= FechaHasta
                                   Let titularNombre = If(pe.Titular_IDEntidad = CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER, pe_otg.Titular_Nombre, ent.Nombre)
                                   Let productoNombre = If(pe.IDProducto = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE, pe_otg.Producto_Nombre, pr.Nombre)
                                   Let cosechaNombre = If(cog Is Nothing, String.Empty, cog.Nombre)
                                   Let plantaNombre = If(plg Is Nothing, String.Empty, plg.Nombre)
                                   Let plantaDepositoNombre = If(pldg Is Nothing, String.Empty, pldg.Nombre)
                                   Let origenNombre = If(pe.IDOrigen = CardonerSistemas.FIELD_VALUE_OTHER_INTEGER, pe_otg.Origen_Nombre, If(og Is Nothing, String.Empty, og.Nombre))
                                   Let destinoNombre = If(pe.IDDestino = CardonerSistemas.FIELD_VALUE_OTHER_INTEGER, pe_otg.Destino_Nombre, If(dg Is Nothing, String.Empty, dg.Nombre))
                                   Let humedad = If(pe_ang Is Nothing, Nothing, pe_ang.Humedad)
                                   Let zaranda = If(pe_ang Is Nothing, Nothing, pe_ang.Zaranda)
                                   Let transportistaNombre = If(pe.Transportista_IDEntidad = CardonerSistemas.FIELD_VALUE_OTHER_INTEGER, pe_otg.Transportista_Nombre, If(trg Is Nothing, String.Empty, trg.Nombre))
                                   Let choferNombre = If(pe.Chofer_IDEntidad = CardonerSistemas.FIELD_VALUE_OTHER_INTEGER, pe_otg.Chofer_Nombre, If(chg Is Nothing, String.Empty, chg.Nombre))
                                   Let CamionNombreDominios = If(pe.IDCamion = CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE, pe_otg.Camion_DominioChasis & If(pe_otg.Camion_DominioAcoplado Is Nothing, String.Empty, " - " & pe_otg.Camion_DominioAcoplado), If(cag Is Nothing, String.Empty, cag.NombreDominios))
                                   Select New GridRowData With {.IDPesada = pe.IDPesada, .FechaHoraInicio = pe.FechaHoraInicio, .FechaHoraFin = pe.FechaHoraFin, .Ctg = pe.Ctg, .ComprobanteNumero = pe.ComprobanteNumeroConFormato, .IDTitular = pe.Titular_IDEntidad, .TitularNombre = titularNombre, .IDProducto = pe.IDProducto, .ProductoNombre = productoNombre, .Producto_TicketPesada_IDReporte = pr.TicketPesada_IDReporte, .IDPlanta = pe.IDPlanta, .PlantaNombre = plantaNombre, .PlantaDepositoNombre = plantaDepositoNombre, .Tipo = pe.Tipo, .TipoNombre = pe.TipoNombre, .IDCosecha = pe.IDCosecha, .CosechaNombre = cosechaNombre, .IDOrigen = pe.IDOrigen, .OrigenNombre = origenNombre, .IDDestino = pe.IDDestino, .DestinoNombre = destinoNombre, .KilogramoBruto = pe.KilogramoBruto, .KilogramoTara = pe.KilogramoTara, .KilogramoNeto = pe.KilogramoNeto, .Humedad = humedad, .Zaranda = zaranda, .KilogramoFinal = pe.KilogramoFinal, .IDTransportista = pe.Transportista_IDEntidad, .TransportistaNombre = transportistaNombre, .IDChofer = pe.Chofer_IDEntidad, .ChoferNombre = choferNombre, .CamionNombreDominios = CamionNombreDominios, .EsVerificado = pe.EsVerificado, .EsActivo = pe.EsActivo}).ToList
#Enable Warning S3358 ' If operators should not be nested
            End Using
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer las Pesadas.")
            Me.Cursor = Cursors.Default
            Return
        End Try

        Me.Cursor = Cursors.Default

        If RestoreCurrentPosition Then
            If DataGridViewMain.CurrentRow Is Nothing Then
                PositionIDPesada = 0
            Else
                PositionIDPesada = CType(DataGridViewMain.CurrentRow.DataBoundItem, Pesada).IDPesada
            End If
        End If

        FilterData()

        If PositionIDPesada <> 0 Then
            For Each CurrentRowChecked As DataGridViewRow In DataGridViewMain.Rows
                If CType(CurrentRowChecked.DataBoundItem, GridRowData).IDPesada = PositionIDPesada Then
                    DataGridViewMain.CurrentCell = CurrentRowChecked.Cells(columnIDPesada.Name)
                    Return
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
                mRecordSelectionFormula_Filter = String.Empty

                '///////////////////////////////
                '//    FILTROS BÁSICOS        //
                '///////////////////////////////

                ' Filtro por Titular
                If CInt(ToolStripComboBoxTitular.ComboBox.SelectedValue) <> CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.IDTitular = CInt(ToolStripComboBoxTitular.ComboBox.SelectedValue)).ToList
                    mRecordSelectionFormula_Filter &= $" AND {{Pesada.Titular_IDEntidad}} = {ToolStripComboBoxTitular.ComboBox.SelectedValue}"
                End If

                ' Filtro por Producto
                If CInt(ToolStripComboBoxProducto.ComboBox.SelectedValue) <> CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.IDProducto = CByte(ToolStripComboBoxProducto.ComboBox.SelectedValue)).ToList
                    mRecordSelectionFormula_Filter &= $" AND {{Pesada.IDProducto}} = {ToolStripComboBoxProducto.ComboBox.SelectedValue}"
                End If

                ' Filtro por Planta
                If CInt(ToolStripComboBoxPlanta.ComboBox.SelectedValue) <> CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.IDPlanta.HasValue AndAlso p.IDPlanta.Value = CByte(ToolStripComboBoxPlanta.ComboBox.SelectedValue)).ToList
                    mRecordSelectionFormula_Filter &= $" AND {{Pesada.IDPlanta}} = {ToolStripComboBoxPlanta.ComboBox.SelectedValue}"
                End If

                ' Filtro por Tipos de Pesada
                If Not (ToolStripMenuItemTiposPesadaEntrada.Checked AndAlso ToolStripMenuItemTiposPesadaSalida.Checked AndAlso ToolStripMenuItemTiposPesadaNinguna.Checked) Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) ((ToolStripMenuItemTiposPesadaEntrada.Checked AndAlso p.Tipo = PESADA_TIPO_ENTRADA) OrElse (ToolStripMenuItemTiposPesadaSalida.Checked AndAlso p.Tipo = PESADA_TIPO_SALIDA) OrElse (ToolStripMenuItemTiposPesadaNinguna.Checked AndAlso p.Tipo = PESADA_TIPO_NINGUNA))).ToList
                    mRecordSelectionFormula_Filter &= $" AND (({ToolStripMenuItemTiposPesadaEntrada.Checked} AND {{Pesada.Tipo}} = '{PESADA_TIPO_ENTRADA}') OR ({ToolStripMenuItemTiposPesadaSalida.Checked} AND {{Pesada.Tipo}} = '{PESADA_TIPO_SALIDA}') OR ({ToolStripMenuItemTiposPesadaNinguna.Checked} AND {{Pesada.Tipo}} = '{PESADA_TIPO_NINGUNA}'))"
                End If

                ' Filtro por Cosecha
                If CInt(ToolStripComboBoxCosecha.ComboBox.SelectedValue) <> CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.IDCosecha.HasValue AndAlso p.IDCosecha.Value = CByte(ToolStripComboBoxCosecha.ComboBox.SelectedValue)).ToList
                    mRecordSelectionFormula_Filter &= $" AND {{Pesada.IDCosecha}} = {ToolStripComboBoxCosecha.ComboBox.SelectedValue}"
                End If

                ' Filtro por Origen
                If CInt(ToolStripComboBoxOrigen.ComboBox.SelectedValue) <> CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.IDOrigen.HasValue AndAlso p.IDOrigen.Value = CInt(ToolStripComboBoxOrigen.ComboBox.SelectedValue)).ToList
                    mRecordSelectionFormula_Filter &= $" AND {{Pesada.IDOrigen}} = {ToolStripComboBoxOrigen.ComboBox.SelectedValue}"
                End If

                ' Filtro por Destino
                If CInt(ToolStripComboBoxDestino.ComboBox.SelectedValue) <> CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.IDDestino.HasValue AndAlso p.IDDestino.Value = CInt(ToolStripComboBoxDestino.ComboBox.SelectedValue)).ToList
                    mRecordSelectionFormula_Filter &= $" AND {{Pesada.IDDestino}} = {ToolStripComboBoxDestino.ComboBox.SelectedValue}"
                End If

                ' Filtro por Transportista
                If CInt(ToolStripComboBoxTransportista.ComboBox.SelectedValue) <> CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.IDTransportista.HasValue AndAlso p.IDTransportista.Value = CInt(ToolStripComboBoxTransportista.ComboBox.SelectedValue)).ToList
                    mRecordSelectionFormula_Filter &= $" AND {{Pesada.Transportista_IDEntidad}} = {ToolStripComboBoxTransportista.ComboBox.SelectedValue}"
                End If

                ' Filtro por Chofer
                If CInt(ToolStripComboBoxChofer.ComboBox.SelectedValue) <> CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.IDChofer.HasValue AndAlso p.IDChofer.Value = CInt(ToolStripComboBoxChofer.ComboBox.SelectedValue)).ToList
                    mRecordSelectionFormula_Filter &= $" AND {{Pesada.Chofer_IDEntidad}} = {ToolStripComboBoxChofer.ComboBox.SelectedValue}"
                End If

                '///////////////////////////////
                '//    FILTROS AVANZADOS      //
                '///////////////////////////////

                ' Filtro por Verificado
                Select Case ToolStripComboBoxVerificado.SelectedIndex
                    Case CardonerSistemas.Constants.ComboBoxAllYesNo_AllListindex       ' Todos
                    Case CardonerSistemas.Constants.ComboBoxAllYesNo_YesListindex       ' Sí
                        mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.EsVerificado).ToList
                        mRecordSelectionFormula_Filter &= " AND {Pesada.EsVerificado}"
                    Case CardonerSistemas.Constants.ComboBoxAllYesNo_NoListindex        ' No
                        mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) Not p.EsVerificado).ToList
                        mRecordSelectionFormula_Filter &= " AND (NOT {Pesada.EsVerificado})"
                End Select

                ' Filtro por Activo
                Select Case ToolStripComboBoxActivo.SelectedIndex
                    Case CardonerSistemas.Constants.ComboBoxAllYesNo_AllListindex       ' Todos
                    Case CardonerSistemas.Constants.ComboBoxAllYesNo_YesListindex       ' Sí
                        mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) p.EsActivo).ToList
                        mRecordSelectionFormula_Filter &= " AND {Pesada.EsActivo}"
                    Case CardonerSistemas.Constants.ComboBoxAllYesNo_NoListindex        ' No
                        mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.Where(Function(p) Not p.EsActivo).ToList
                        mRecordSelectionFormula_Filter &= " AND (NOT {Pesada.EsActivo})"
                End Select

                'Select Case mlistPesadaFiltradaYOrdenada.Count
                '    Case 0
                '        statuslabelMain.Text = "No hay Pesadas para mostrar."
                '    Case 1
                '        statuslabelMain.Text = "Se muestra 1 Pesada."
                '    Case Else
                '        statuslabelMain.Text = $"Se muestran {mlistPesadaFiltradaYOrdenada.Count} Pesadas."
                'End Select
            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al filtrar los datos.")
                Me.Cursor = Cursors.Default
                Return
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
            Case columnCtg.Name
                If mOrdenTipo = SortOrder.Ascending Then
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.OrderBy(Function(col) col.Ctg).ThenBy(Function(col) col.IDPesada).ToList
                Else
                    mlistPesadaFiltradaYOrdenada = mlistPesadaFiltradaYOrdenada.OrderByDescending(Function(col) col.Ctg).ThenByDescending(Function(col) col.IDPesada).ToList
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

#Region "Eventos de los controles"

    Private Sub Periodo_LauncherClick(sender As Object, e As EventArgs) Handles ToolStripButtonExpandir.Click
        mFiltroPeriodoExpandido = Not mFiltroPeriodoExpandido
        If mFiltroPeriodoExpandido Then
            ToolStripButtonExpandir.Text = "Contraer"
        Else
            ToolStripButtonExpandir.Text = "Expandir"
        End If
        FiltroPeriodoMostrar()
    End Sub

    Private Sub PeriodoTipoSeleccionar(sender As Object, e As EventArgs) Handles ToolStripComboBoxPeriodoTipo.SelectedIndexChanged
        CardonerSistemas.DateTime.FillPeriodValuesComboBox(ToolStripComboBoxPeriodoValor.ComboBox, CType(ToolStripComboBoxPeriodoTipo.SelectedIndex, CardonerSistemas.DateTime.PeriodTypes))
    End Sub

    Private Sub PeriodoValorSeleccionar(sender As Object, e As EventArgs) Handles ToolStripComboBoxPeriodoValor.SelectedIndexChanged
        ' Fecha Desde
        ToolStripLabelFechaDesdeDiaSemana.Visible = (ToolStripComboBoxPeriodoTipo.SelectedIndex = CInt(CardonerSistemas.DateTime.PeriodTypes.Range))
        ToolStripButtonFechaDesdeAnterior.Visible = ToolStripLabelFechaDesdeDiaSemana.Visible
        ToolStripControlHostFechaDesde.Visible = ToolStripLabelFechaDesdeDiaSemana.Visible
        ToolStripButtonFechaDesdeSiguiente.Visible = ToolStripLabelFechaDesdeDiaSemana.Visible
        ToolStripButtonFechaDesdeHoy.Visible = ToolStripLabelFechaDesdeDiaSemana.Visible

        ' Fecha Hasta
        ToolStripLabelFechaY.Visible = (ToolStripComboBoxPeriodoTipo.SelectedIndex = CInt(CardonerSistemas.DateTime.PeriodTypes.Range) AndAlso ToolStripComboBoxPeriodoValor.SelectedIndex = CInt(CardonerSistemas.DateTime.PeriodRangeValues.DateBetween))
        ToolStripButtonFechaHastaAnterior.Visible = ToolStripLabelFechaY.Visible
        ToolStripControlHostFechaHasta.Visible = ToolStripLabelFechaY.Visible
        ToolStripButtonFechaHastaSiguiente.Visible = ToolStripLabelFechaY.Visible
        ToolStripButtonFechaHastaHoy.Visible = ToolStripLabelFechaY.Visible

        RefreshData()
    End Sub

    ' ///// Fecha Desde /////
    Private Sub FechaDesdeAnterior(sender As Object, e As EventArgs) Handles ToolStripButtonFechaDesdeAnterior.Click
        CType(ToolStripControlHostFechaDesde.Control, DateTimePicker).Value = CType(ToolStripControlHostFechaDesde.Control, DateTimePicker).Value.AddDays(-1)
    End Sub

    Private Sub FechaDesdeSiguiente(sender As Object, e As EventArgs) Handles ToolStripButtonFechaDesdeSiguiente.Click
        CType(ToolStripControlHostFechaDesde.Control, DateTimePicker).Value = CType(ToolStripControlHostFechaDesde.Control, DateTimePicker).Value.AddDays(1)
    End Sub

    Private Sub FechaDesdeHoy(sender As Object, e As EventArgs) Handles ToolStripButtonFechaDesdeHoy.Click
        CType(ToolStripControlHostFechaDesde.Control, DateTimePicker).Value = DateAndTime.Today
    End Sub

    ' ///// Fecha Hasta /////
    Private Sub FechaHastaAnterior(sender As Object, e As EventArgs) Handles ToolStripButtonFechaHastaAnterior.Click
        CType(ToolStripControlHostFechaHasta.Control, DateTimePicker).Value = CType(ToolStripControlHostFechaHasta.Control, DateTimePicker).Value.AddDays(-1)
    End Sub

    Private Sub FechaHastaSiguiente(sender As Object, e As EventArgs) Handles ToolStripButtonFechaHastaSiguiente.Click
        CType(ToolStripControlHostFechaHasta.Control, DateTimePicker).Value = CType(ToolStripControlHostFechaHasta.Control, DateTimePicker).Value.AddDays(1)
    End Sub

    Private Sub FechaHastaHoy(sender As Object, e As EventArgs) Handles ToolStripButtonFechaHastaHoy.Click
        CType(ToolStripControlHostFechaHasta.Control, DateTimePicker).Value = DateAndTime.Today
    End Sub

    Private Sub FechaCambiar(sender As Object, e As EventArgs) Handles ToolStripControlHostFechaDesde.TextChanged, ToolStripControlHostFechaHasta.TextChanged
        ToolStripLabelFechaDesdeDiaSemana.Text = CType(ToolStripControlHostFechaDesde.Control, DateTimePicker).Value.ToString("dddd")
        RefreshData()
    End Sub

    Private Sub PesadaTipo_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemTiposPesadaEntrada.Click, ToolStripMenuItemTiposPesadaSalida.Click, ToolStripMenuItemTiposPesadaNinguna.Click
        FilterData()
    End Sub

    Private Sub FiltrosBasicos_Click(sender As Object, e As EventArgs) Handles ToolStripComboBoxProducto.SelectedIndexChanged, ToolStripComboBoxPlanta.SelectedIndexChanged, ToolStripComboBoxCosecha.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub FiltrosOtros_Click(sender As Object, e As EventArgs) Handles ToolStripComboBoxOrigen.SelectedIndexChanged, ToolStripComboBoxDestino.SelectedIndexChanged, ToolStripComboBoxChofer.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub FiltrosAvanzados_Click(sender As Object, e As EventArgs) Handles ToolStripComboBoxVerificado.SelectedIndexChanged, ToolStripComboBoxActivo.SelectedIndexChanged
        FilterData()
    End Sub

    Private Sub Columnas_Click(sender As Object, e As EventArgs) Handles ToolStripControlHostCheckBoxColumnaNumero.Click, ToolStripControlHostCheckBoxColumnaInicio.Click, ToolStripControlHostCheckBoxColumnaFin.Click, ToolStripControlHostCheckBoxColumnaCtg.Click
        MostrarColumnas(CType(sender, ToolStripControlHost))
    End Sub

    Private Sub MarcarYDesmarcarTodo_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemTiposPesadaMarcarTodos.Click, ToolStripMenuItemTiposPesadaDesmarcarTodos.Click
        mSkipFilterData = True

        ToolStripMenuItemTiposPesadaEntrada.Checked = (CType(sender, ToolStripMenuItem) Is ToolStripMenuItemTiposPesadaMarcarTodos)
        ToolStripMenuItemTiposPesadaSalida.Checked = (CType(sender, ToolStripMenuItem) Is ToolStripMenuItemTiposPesadaMarcarTodos)
        ToolStripMenuItemTiposPesadaNinguna.Checked = (CType(sender, ToolStripMenuItem) Is ToolStripMenuItemTiposPesadaMarcarTodos)

        mSkipFilterData = False

        FilterData()
    End Sub

    Private Sub Titular_Change(sender As Object, e As EventArgs) Handles ToolStripComboBoxTitular.SelectedIndexChanged
        Dim SaveSkipFilterData As Boolean

        SaveSkipFilterData = mSkipFilterData
        mSkipFilterData = True

        pFillAndRefreshLists.OrigenDestino(ToolStripComboBoxOrigen.ComboBox, Nothing, True, CInt(ToolStripComboBoxTitular.ComboBox.SelectedValue), True, True, False)
        pFillAndRefreshLists.OrigenDestino(ToolStripComboBoxDestino.ComboBox, Nothing, True, CInt(ToolStripComboBoxTitular.ComboBox.SelectedValue), True, True, False)

        mSkipFilterData = SaveSkipFilterData

        FilterData()
    End Sub

    Private Sub Transportista_Change(sender As Object, e As EventArgs) Handles ToolStripComboBoxTransportista.SelectedIndexChanged
        Dim SaveSkipFilterData As Boolean

        SaveSkipFilterData = mSkipFilterData
        mSkipFilterData = True
        pFillAndRefreshLists.Entidad(ToolStripComboBoxChofer.ComboBox, Nothing, False, False, False, True, CInt(ToolStripComboBoxTransportista.ComboBox.SelectedValue), False, True, True, False)
        mSkipFilterData = SaveSkipFilterData
        FilterData()
    End Sub

    Private Sub GridCellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridViewMain.CellFormatting
        Dim gridRowData As GridRowData

        If Not (mEntradaHumedadVaciaMostrarError OrElse mEntradaZarandeoVacioMostrarError) Then
            Return
        End If

        gridRowData = CType(DataGridViewMain.Rows(e.RowIndex).DataBoundItem, GridRowData)
        If gridRowData.Tipo = Constantes.PESADA_TIPO_ENTRADA AndAlso ((mEntradaHumedadVaciaMostrarError AndAlso Not gridRowData.Humedad.HasValue) OrElse (mEntradaZarandeoVacioMostrarError AndAlso Not gridRowData.Zaranda.HasValue)) Then
            If e.ColumnIndex = columnIDPesada.Index OrElse e.ColumnIndex = columnFechaHoraInicio.Index OrElse e.ColumnIndex = columnTipo.Index OrElse e.ColumnIndex = columnHumedad.Index OrElse e.ColumnIndex = columnZaranda.Index Then
                Appearance.DataGridSetCellStyleError(CType(DataGridViewMain.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewTextBoxCell))
            Else
                Appearance.DataGridSetCellStyleStandard(CType(DataGridViewMain.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewTextBoxCell), e.RowIndex)
            End If
        Else
            Appearance.DataGridSetCellStyleStandard(CType(DataGridViewMain.Rows(e.RowIndex).Cells(e.ColumnIndex), DataGridViewTextBoxCell), e.RowIndex)
        End If
    End Sub

    Private Sub GridChangeOrder(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewMain.ColumnHeaderMouseClick
        Dim ClickedColumn As DataGridViewColumn

        ClickedColumn = CType(DataGridViewMain.Columns(e.ColumnIndex), DataGridViewColumn)

        If ClickedColumn.Name = columnIDPesada.Name OrElse ClickedColumn.Name = columnCtg.Name OrElse ClickedColumn.Name = columnFechaHoraInicio.Name OrElse ClickedColumn.Name = columnKilogramoNeto.Name Then
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
                If mOrdenColumna IsNot Nothing Then
                    mOrdenColumna.HeaderCell.SortGlyphDirection = SortOrder.None
                End If

                ' Guardo la info de la nueva columna
                mOrdenTipo = SortOrder.Ascending
                mOrdenColumna = ClickedColumn
            End If
        End If

        OrderData()
    End Sub

#End Region

#Region "Toolbar principal"

    Private Sub Agregar_Click() Handles ToolStripButtonAgregar.Click
        If Not Permisos.VerificarPermiso(Permisos.PESADA_AGREGAR) Then
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        DataGridViewMain.Enabled = False
        formPesada.LoadAndShow(True, Me, 0)
        DataGridViewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Editar_Click() Handles ToolStripButtonEditar.Click
        If DataGridViewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Pesada para editar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        If Not Permisos.VerificarPermiso(Permisos.PESADA_EDITAR) Then
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        DataGridViewMain.Enabled = False
        formPesada.LoadAndShow(True, Me, CType(DataGridViewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPesada)
        DataGridViewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Eliminar_Click() Handles ToolStripButtonBorrar.Click
        If DataGridViewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Pesada para eliminar.", vbInformation, My.Application.Info.Title)
            Return
        End If
        If Not Permisos.VerificarPermiso(Permisos.PESADA_ELIMINAR) Then
            Return
        End If
        Dim Mensaje As String = $"Se eliminará la Pesada seleccionada.{vbCrLf}{vbCrLf}Número: {FormatNumber(CType(DataGridViewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPesada, 0)}{vbCrLf}{vbCrLf}Fecha/hora de inicio: {FormatDateTime(CType(DataGridViewMain.SelectedRows(0).DataBoundItem, GridRowData).FechaHoraInicio, DateFormat.GeneralDate)}{vbCrLf}{vbCrLf}¿Confirma la eliminación definitiva?"
        If MessageBox.Show(Mensaje, My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        Try
            Using dbContext = New CSPesajeContext(True)
                Dim PesadaActual As Pesada
                PesadaActual = dbContext.Pesada.Find(CType(DataGridViewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPesada)

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
            Return
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al eliminar la Pesada.")
        End Try
        RefreshData()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Ver() Handles DataGridViewMain.DoubleClick
        If DataGridViewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Pesada para ver.", vbInformation, My.Application.Info.Title)
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        DataGridViewMain.Enabled = False
        formPesada.LoadAndShow(False, Me, CType(DataGridViewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPesada)
        DataGridViewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ImprimirTicketPesada(sender As Object, e As EventArgs) Handles ToolStripButtonImprimir.ButtonClick
        Dim CurrentRow As GridRowData

        If DataGridViewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Pesada para imprimir.", vbInformation, My.Application.Info.Title)
            Return
        End If
        If Not Permisos.VerificarPermiso(Permisos.PESADA_IMPRIMIR) Then
            Return
        End If
        'If sender.Equals(buttonImprimir) Then
        '    If MsgBox("Se va a imprimir directamente el Comprobante seleccionado." & vbCrLf & vbCrLf & "¿Desea continuar?", CType(MsgBoxStyle.Question + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.No Then
        '        Exit Sub
        '    End If
        'End If

        CurrentRow = CType(DataGridViewMain.SelectedRows(0).DataBoundItem, GridRowData)
        If Not CurrentRow.Producto_TicketPesada_IDReporte.HasValue Then
            MsgBox("No hay ningún Reporte especificado para este Producto.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        DataGridViewMain.Enabled = False
        Using dbContext As New CSPesajeContext(True)
            Dim ReporteActual As New Reporte

            ReporteActual = dbContext.Reporte.Find(CurrentRow.Producto_TicketPesada_IDReporte.Value)
            If ReporteActual IsNot Nothing Then
                ReporteActual.ReporteParametros.Single(Function(rp) rp.Nombre = "IDPesada").Valor = CurrentRow.IDPesada
                ReporteActual.ReporteParametros.Single(Function(rp) rp.Nombre = "EsReducido").Valor = sender.Equals(ToolStripMenuItemImprimirTicketReducido)
                If ReporteActual.Open($"{pGeneralConfig.ReportsPath}\{ReporteActual.Archivo}") Then
#Disable Warning S1066 ' Mergeable "if" statements should be combined
                    If ReporteActual.SetDatabaseConnection(pDatabase.Datasource, pDatabase.InitialCatalog, pDatabase.UserId, pDatabase.Password) Then
#Enable Warning S1066 ' Mergeable "if" statements should be combined
                        If pGeneralConfig.ReportePesadaPrevisualizar Then
                            Reportes.PreviewCrystalReport(ReporteActual, "Ticket Pesada Nº " & Microsoft.VisualBasic.Strings.Format(CurrentRow.IDPesada, "N0"))
                        Else
                            ReporteActual.ReportObject.PrintToPrinter(1, False, 1, 100)
                        End If
                    End If
                End If
            End If
        End Using
        DataGridViewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ImprimirReportes(sender As Object, e As EventArgs)
        If DataGridViewMain.CurrentRow Is Nothing Then
            MsgBox("No hay ninguna Pesada para imprimir.", vbInformation, My.Application.Info.Title)
            Return
        End If
        If Not Permisos.VerificarPermiso(Permisos.REPORTE) Then
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        DataGridViewMain.Enabled = False
        Using dbContext As New CSPesajeContext(True)
            Dim reporteActual As Reporte = dbContext.Reporte.Find(CInt(CType(sender, ToolStripDropDownItem).Tag))
            Dim reporteParametro As ReporteParametro

            If reporteActual Is Nothing Then
                Return
            End If

            ' Título
            reporteParametro = reporteActual.ReporteParametros.SingleOrDefault(Function(rp) rp.Nombre = "Titulo")
            If reporteParametro IsNot Nothing Then
                reporteParametro.Valor = reporteActual.Titulo
            End If

            ' Día
            reporteParametro = reporteActual.ReporteParametros.SingleOrDefault(Function(rp) rp.Nombre = "Dia")
            If reporteParametro IsNot Nothing Then
                reporteParametro.Valor = CType(ToolStripControlHostFechaDesde.Control, DateTimePicker).Value
            End If
            reporteParametro = Nothing

            If reporteActual.Open($"{pGeneralConfig.ReportsPath}\{reporteActual.Archivo}") Then
                If reporteActual.RecordSelectionFormula <> String.Empty Then
                    reporteActual.RecordSelectionFormula &= " AND " & mRecordSelectionFormula_Refresh & mRecordSelectionFormula_Filter
                Else
                    reporteActual.RecordSelectionFormula = mRecordSelectionFormula_Refresh & mRecordSelectionFormula_Filter
                End If
                If reporteActual.SetDatabaseConnection(pDatabase.Datasource, pDatabase.InitialCatalog, pDatabase.UserId, pDatabase.Password) Then
                    Reportes.PreviewCrystalReport(reporteActual, reporteActual.Titulo)
                End If
            End If
        End Using
        DataGridViewMain.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Tareas_CalcularMermas() Handles ToolStripMenuItemTareasCalcularMermas.Click
        If DataGridViewMain.Rows.Count = 0 Then
            MsgBox("No hay Pesadas para calcular mermas.", vbInformation, My.Application.Info.Title)
            Return
        End If

        If MessageBox.Show($"Se calcularán las mermas de todas las entradas mostradas.{vbCrLf}{vbCrLf}¿Desea continuar?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.No Then
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        DataGridViewMain.Enabled = False
        Try
            Using dbContext = New CSPesajeContext(True)
                Dim pesadaActual As Pesada

                For Each dataRowActual As DataGridViewRow In DataGridViewMain.Rows
                    ' Muestro la fila de la grilla que voy a recalcular
                    DataGridViewMain.CurrentCell = dataRowActual.Cells(0)
                    Application.DoEvents()

                    ' Leo la Pesada actual de la base de datos
                    pesadaActual = dbContext.Pesada.Find(CType(DataGridViewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPesada)
                    If pesadaActual.Tipo = PESADA_TIPO_ENTRADA OrElse pesadaActual.Tipo = PESADA_TIPO_SALIDA Then
                        ' Recalculo mermas
                        If pesadaActual.Pesada_Analisis Is Nothing Then
                            pesadaActual.Pesada_Analisis = New Pesada_Analisis
                        End If
                        pesadaActual.Pesada_Analisis.CalcularMermas(pesadaActual)
                    End If
                Next
                dbContext.SaveChanges()
                RefreshData()
            End Using
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al calcular mermas de la Pesada.")
            Return
        Finally
            DataGridViewMain.Enabled = True
            Me.Cursor = Cursors.Default
        End Try

        If DataGridViewMain.Rows.Count > 0 Then
            DataGridViewMain.CurrentCell = DataGridViewMain.Rows(0).Cells(0)
        End If
    End Sub

    Private Sub Tareas_CalcularAcondicionamiento() Handles ToolStripMenuItemTareasCalcularAcondicionamiento.Click
        If DataGridViewMain.Rows.Count = 0 Then
            MsgBox("No hay Pesadas para calcular el acondicionamiento.", vbInformation, My.Application.Info.Title)
            Return
        End If

        If MessageBox.Show($"Se calculará el acondicionamiento de todas las entradas mostradas.{vbCrLf}{vbCrLf}¿Desea continuar?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.No Then
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        DataGridViewMain.Enabled = False

        Try
            Using dbContext = New CSPesajeContext(True)
                Dim pesadaActual As Pesada

                For Each dataRowActual As DataGridViewRow In DataGridViewMain.Rows
                    ' Muestro la fila de la grilla que voy a recalcular
                    DataGridViewMain.CurrentCell = dataRowActual.Cells(0)
                    Application.DoEvents()

                    ' Leo la Pesada actual de la base de datos
                    pesadaActual = dbContext.Pesada.Find(CType(DataGridViewMain.SelectedRows(0).DataBoundItem, GridRowData).IDPesada)

                    If pesadaActual.Tipo = PESADA_TIPO_ENTRADA Then
                        ' Recalculo acondicionamiento
                        If pesadaActual.Pesada_Acondicionamiento Is Nothing Then
                            pesadaActual.Pesada_Acondicionamiento = New Pesada_Acondicionamiento
                        End If
                        pesadaActual.Pesada_Acondicionamiento.CalcularAcondicionamiento(pesadaActual)
                    End If
                Next
                dbContext.SaveChanges()
                RefreshData()
            End Using
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al calcular el acondicionamiento de la Pesada.")
        Finally
            DataGridViewMain.Enabled = True
            Me.Cursor = Cursors.Default
        End Try

        If DataGridViewMain.Rows.Count > 0 Then
            DataGridViewMain.CurrentCell = DataGridViewMain.Rows(0).Cells(0)
        End If
    End Sub

#End Region

#Region "Cosas extra"

    Private Sub FiltroPeriodoMostrar()
        ToolStripPeriodo.SuspendLayout()
        If Not mFiltroPeriodoExpandido Then
            ToolStripComboBoxPeriodoTipo.SelectedIndex = CardonerSistemas.DateTime.PeriodTypes.Range
            ToolStripComboBoxPeriodoValor.SelectedIndex = CardonerSistemas.DateTime.PeriodRangeValues.DateEqual
        End If
        ToolStripComboBoxPeriodoTipo.Visible = mFiltroPeriodoExpandido
        ToolStripComboBoxPeriodoValor.Visible = mFiltroPeriodoExpandido
        ToolStripLabelFecha.Visible = Not mFiltroPeriodoExpandido
        ToolStripPeriodo.ResumeLayout()
    End Sub

    Private Sub MostrarColumnas(sender As ToolStripControlHost)
        Dim value As Boolean = CType(sender.Control, CheckBox).Checked

        Select Case sender.Control.Name
            Case ToolStripControlHostCheckBoxColumnaNumero.Control.Name
                columnIDPesada.Visible = value
            Case ToolStripControlHostCheckBoxColumnaInicio.Control.Name
                columnFechaHoraInicio.Visible = value
            Case ToolStripControlHostCheckBoxColumnaFin.Control.Name
                columnFechaHoraFin.Visible = value
            Case ToolStripControlHostCheckBoxColumnaCtg.Control.Name
                columnCtg.Visible = value
        End Select
    End Sub

#End Region

End Class