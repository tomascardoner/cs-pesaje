<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPesadas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPesadas))
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.columnIDPesada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFechaHoraInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFechaHoraFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnComprobanteNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEntidadTitular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCosecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnOrigen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnKilogramoBruto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnKilogramoTara = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnKilogramoNeto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnHumedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnZaranda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnKilogramoFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEntidadTransportista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnChofer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCamion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bindingsourceMain = New System.Windows.Forms.BindingSource(Me.components)
        Me.ribbonMain = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv()
        Me.toolstriptabPrincipal = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.toolstripgroupAcciones = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.buttonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCopiar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.buttonImprimir = New System.Windows.Forms.ToolStripSplitButton()
        Me.menuitemImprimir_TicketPesadaReducido = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripgroupPeriodo = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.comboboxPeriodoTipo = New System.Windows.Forms.ToolStripComboBox()
        Me.comboboxPeriodoValor = New System.Windows.Forms.ToolStripComboBox()
        Me.labelFecha = New System.Windows.Forms.ToolStripLabel()
        Me.buttonFechaDesdeAnterior = New System.Windows.Forms.ToolStripButton()
        Me.labelFechaDesdeDiaSemana = New System.Windows.Forms.ToolStripLabel()
        Me.buttonFechaDesdeSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.buttonFechaDesdeHoy = New System.Windows.Forms.ToolStripButton()
        Me.labelFechaY = New System.Windows.Forms.ToolStripLabel()
        Me.buttonFechaHastaAnterior = New System.Windows.Forms.ToolStripButton()
        Me.buttonFechaHastaSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.buttonFechaHastaHoy = New System.Windows.Forms.ToolStripButton()
        Me.toolstriptabFiltrosBasicos = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.toolstripgroupTitular = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.comboboxTitular = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripgroupProducto = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.comboboxProducto = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripgroupPlanta = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.comboboxPlanta = New System.Windows.Forms.ToolStripComboBox()
        Me.tooltripgroupPesadaTipo = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.dropdownbuttonPesadaTipo = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menuitemPesadaTipo_Entrada = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemPesadaTipo_Salida = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemPesadaTipo_Ninguno = New System.Windows.Forms.ToolStripMenuItem()
        Me.separatorMarcarTodos = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemPesadaTipo_MarcarTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemPesadaTipo_DesmarcarTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstripgroupCosecha = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.comboboxCosecha = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripgroupOrigen = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.comboboxOrigen = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripgroupDestino = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.comboboxDestino = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripgroupTransportista = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.comboboxTransportista = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripgroupChofer = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.comboboxChofer = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstriptabFiltrosAvanzados = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.toolstripgroupEsVerificado = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.comboboxEsVerificado = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripgroupEsActivo = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.comboboxEsActivo = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripgroupMenu = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.dropdownbuttonTareas = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menuitemCalcularMermas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemCalcularAcondicionamiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusstripMain.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ribbonMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ribbonMain.SuspendLayout()
        Me.toolstriptabPrincipal.Panel.SuspendLayout()
        Me.toolstripgroupAcciones.SuspendLayout()
        Me.toolstripgroupPeriodo.SuspendLayout()
        Me.toolstriptabFiltrosBasicos.Panel.SuspendLayout()
        Me.toolstripgroupTitular.SuspendLayout()
        Me.toolstripgroupProducto.SuspendLayout()
        Me.toolstripgroupPlanta.SuspendLayout()
        Me.tooltripgroupPesadaTipo.SuspendLayout()
        Me.toolstripgroupCosecha.SuspendLayout()
        Me.toolstripgroupOrigen.SuspendLayout()
        Me.toolstripgroupDestino.SuspendLayout()
        Me.toolstripgroupTransportista.SuspendLayout()
        Me.toolstripgroupChofer.SuspendLayout()
        Me.toolstriptabFiltrosAvanzados.Panel.SuspendLayout()
        Me.toolstripgroupEsVerificado.SuspendLayout()
        Me.toolstripgroupEsActivo.SuspendLayout()
        Me.toolstripgroupMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelMain})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 347)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(1197, 22)
        Me.statusstripMain.TabIndex = 1
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(1182, 17)
        Me.statuslabelMain.Spring = True
        Me.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'datagridviewMain
        '
        Me.datagridviewMain.AllowUserToAddRows = False
        Me.datagridviewMain.AllowUserToDeleteRows = False
        Me.datagridviewMain.AllowUserToOrderColumns = True
        Me.datagridviewMain.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewMain.AutoGenerateColumns = False
        Me.datagridviewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnIDPesada, Me.columnFechaHoraInicio, Me.columnFechaHoraFin, Me.columnComprobanteNumero, Me.columnEntidadTitular, Me.columnProducto, Me.columnTipo, Me.columnCosecha, Me.columnOrigen, Me.columnDestino, Me.columnKilogramoBruto, Me.columnKilogramoTara, Me.columnKilogramoNeto, Me.columnHumedad, Me.columnZaranda, Me.columnKilogramoFinal, Me.columnEntidadTransportista, Me.columnChofer, Me.columnCamion})
        Me.datagridviewMain.DataSource = Me.bindingsourceMain
        Me.datagridviewMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewMain.Location = New System.Drawing.Point(0, 125)
        Me.datagridviewMain.MultiSelect = False
        Me.datagridviewMain.Name = "datagridviewMain"
        Me.datagridviewMain.ReadOnly = True
        Me.datagridviewMain.RowHeadersVisible = False
        Me.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMain.Size = New System.Drawing.Size(1197, 222)
        Me.datagridviewMain.TabIndex = 3
        '
        'columnIDPesada
        '
        Me.columnIDPesada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnIDPesada.DataPropertyName = "IDPesada"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.columnIDPesada.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnIDPesada.HeaderText = "Número"
        Me.columnIDPesada.Name = "columnIDPesada"
        Me.columnIDPesada.ReadOnly = True
        Me.columnIDPesada.Width = 69
        '
        'columnFechaHoraInicio
        '
        Me.columnFechaHoraInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnFechaHoraInicio.DataPropertyName = "FechaHoraInicio"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "g"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.columnFechaHoraInicio.DefaultCellStyle = DataGridViewCellStyle3
        Me.columnFechaHoraInicio.HeaderText = "Inicio"
        Me.columnFechaHoraInicio.Name = "columnFechaHoraInicio"
        Me.columnFechaHoraInicio.ReadOnly = True
        Me.columnFechaHoraInicio.Width = 57
        '
        'columnFechaHoraFin
        '
        Me.columnFechaHoraFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnFechaHoraFin.DataPropertyName = "FechaHoraFin"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "g"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.columnFechaHoraFin.DefaultCellStyle = DataGridViewCellStyle4
        Me.columnFechaHoraFin.HeaderText = "Fin"
        Me.columnFechaHoraFin.Name = "columnFechaHoraFin"
        Me.columnFechaHoraFin.ReadOnly = True
        Me.columnFechaHoraFin.Visible = False
        '
        'columnComprobanteNumero
        '
        Me.columnComprobanteNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnComprobanteNumero.DataPropertyName = "ComprobanteNumero"
        Me.columnComprobanteNumero.HeaderText = "Comprobante"
        Me.columnComprobanteNumero.Name = "columnComprobanteNumero"
        Me.columnComprobanteNumero.ReadOnly = True
        Me.columnComprobanteNumero.Width = 95
        '
        'columnEntidadTitular
        '
        Me.columnEntidadTitular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnEntidadTitular.DataPropertyName = "TitularNombre"
        Me.columnEntidadTitular.HeaderText = "Titular"
        Me.columnEntidadTitular.Name = "columnEntidadTitular"
        Me.columnEntidadTitular.ReadOnly = True
        Me.columnEntidadTitular.Width = 61
        '
        'columnProducto
        '
        Me.columnProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnProducto.DataPropertyName = "ProductoNombre"
        Me.columnProducto.HeaderText = "Producto"
        Me.columnProducto.Name = "columnProducto"
        Me.columnProducto.ReadOnly = True
        Me.columnProducto.Width = 75
        '
        'columnTipo
        '
        Me.columnTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnTipo.DataPropertyName = "TipoNombre"
        Me.columnTipo.HeaderText = "Tipo"
        Me.columnTipo.Name = "columnTipo"
        Me.columnTipo.ReadOnly = True
        Me.columnTipo.Width = 53
        '
        'columnCosecha
        '
        Me.columnCosecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnCosecha.DataPropertyName = "CosechaNombre"
        Me.columnCosecha.HeaderText = "Cosecha"
        Me.columnCosecha.Name = "columnCosecha"
        Me.columnCosecha.ReadOnly = True
        Me.columnCosecha.Width = 74
        '
        'columnOrigen
        '
        Me.columnOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnOrigen.DataPropertyName = "OrigenNombre"
        Me.columnOrigen.HeaderText = "Origen"
        Me.columnOrigen.Name = "columnOrigen"
        Me.columnOrigen.ReadOnly = True
        Me.columnOrigen.Width = 63
        '
        'columnDestino
        '
        Me.columnDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnDestino.DataPropertyName = "DestinoNombre"
        Me.columnDestino.HeaderText = "Destino"
        Me.columnDestino.Name = "columnDestino"
        Me.columnDestino.ReadOnly = True
        Me.columnDestino.Width = 68
        '
        'columnKilogramoBruto
        '
        Me.columnKilogramoBruto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnKilogramoBruto.DataPropertyName = "KilogramoBruto"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.columnKilogramoBruto.DefaultCellStyle = DataGridViewCellStyle5
        Me.columnKilogramoBruto.HeaderText = "Kgs. Bruto"
        Me.columnKilogramoBruto.Name = "columnKilogramoBruto"
        Me.columnKilogramoBruto.ReadOnly = True
        Me.columnKilogramoBruto.Width = 81
        '
        'columnKilogramoTara
        '
        Me.columnKilogramoTara.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnKilogramoTara.DataPropertyName = "KilogramoTara"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N0"
        Me.columnKilogramoTara.DefaultCellStyle = DataGridViewCellStyle6
        Me.columnKilogramoTara.HeaderText = "Kgs. Tara"
        Me.columnKilogramoTara.Name = "columnKilogramoTara"
        Me.columnKilogramoTara.ReadOnly = True
        Me.columnKilogramoTara.Width = 78
        '
        'columnKilogramoNeto
        '
        Me.columnKilogramoNeto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnKilogramoNeto.DataPropertyName = "KilogramoNeto"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N0"
        Me.columnKilogramoNeto.DefaultCellStyle = DataGridViewCellStyle7
        Me.columnKilogramoNeto.HeaderText = "Kgs. Neto"
        Me.columnKilogramoNeto.Name = "columnKilogramoNeto"
        Me.columnKilogramoNeto.ReadOnly = True
        Me.columnKilogramoNeto.Width = 79
        '
        'columnHumedad
        '
        Me.columnHumedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnHumedad.DataPropertyName = "Humedad"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N1"
        DataGridViewCellStyle8.NullValue = Nothing
        Me.columnHumedad.DefaultCellStyle = DataGridViewCellStyle8
        Me.columnHumedad.HeaderText = "Hum."
        Me.columnHumedad.Name = "columnHumedad"
        Me.columnHumedad.ReadOnly = True
        Me.columnHumedad.Width = 57
        '
        'columnZaranda
        '
        Me.columnZaranda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnZaranda.DataPropertyName = "Zaranda"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N1"
        Me.columnZaranda.DefaultCellStyle = DataGridViewCellStyle9
        Me.columnZaranda.HeaderText = "Zar."
        Me.columnZaranda.Name = "columnZaranda"
        Me.columnZaranda.ReadOnly = True
        Me.columnZaranda.Width = 51
        '
        'columnKilogramoFinal
        '
        Me.columnKilogramoFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnKilogramoFinal.DataPropertyName = "KilogramoFinal"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N0"
        Me.columnKilogramoFinal.DefaultCellStyle = DataGridViewCellStyle10
        Me.columnKilogramoFinal.HeaderText = "Kgs. Final"
        Me.columnKilogramoFinal.Name = "columnKilogramoFinal"
        Me.columnKilogramoFinal.ReadOnly = True
        Me.columnKilogramoFinal.Width = 78
        '
        'columnEntidadTransportista
        '
        Me.columnEntidadTransportista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnEntidadTransportista.DataPropertyName = "TransportistaNombre"
        Me.columnEntidadTransportista.HeaderText = "Transportista"
        Me.columnEntidadTransportista.Name = "columnEntidadTransportista"
        Me.columnEntidadTransportista.ReadOnly = True
        Me.columnEntidadTransportista.Width = 93
        '
        'columnChofer
        '
        Me.columnChofer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnChofer.DataPropertyName = "ChoferNombre"
        Me.columnChofer.HeaderText = "Chofer"
        Me.columnChofer.Name = "columnChofer"
        Me.columnChofer.ReadOnly = True
        Me.columnChofer.Width = 63
        '
        'columnCamion
        '
        Me.columnCamion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnCamion.DataPropertyName = "CamionNombreDominios"
        Me.columnCamion.HeaderText = "Camión"
        Me.columnCamion.Name = "columnCamion"
        Me.columnCamion.ReadOnly = True
        Me.columnCamion.Width = 67
        '
        'ribbonMain
        '
        Me.ribbonMain.AllowCollapse = False
        Me.ribbonMain.CaptionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ribbonMain.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top
        Me.ribbonMain.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ribbonMain.Header.AddMainItem(toolstriptabPrincipal)
        Me.ribbonMain.Header.AddMainItem(toolstriptabFiltrosBasicos)
        Me.ribbonMain.Header.AddMainItem(toolstriptabFiltrosAvanzados)
        Me.ribbonMain.Location = New System.Drawing.Point(0, 0)
        Me.ribbonMain.MenuButtonFont = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ribbonMain.MenuButtonText = ""
        Me.ribbonMain.MenuButtonVisible = False
        Me.ribbonMain.MenuColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ribbonMain.Name = "ribbonMain"
        Me.ribbonMain.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed
        '
        'ribbonMain.OfficeMenu
        '
        Me.ribbonMain.OfficeMenu.Name = "OfficeMenu"
        Me.ribbonMain.OfficeMenu.ShowItemToolTips = True
        Me.ribbonMain.OfficeMenu.Size = New System.Drawing.Size(12, 65)
        Me.ribbonMain.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ribbonMain.QuickPanelVisible = False
        Me.ribbonMain.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None
        Me.ribbonMain.SelectedTab = Me.toolstriptabPrincipal
        Me.ribbonMain.ShowRibbonDisplayOptionButton = True
        Me.ribbonMain.Size = New System.Drawing.Size(1197, 125)
        Me.ribbonMain.SystemText.QuickAccessDialogDropDownName = "Start menu"
        Me.ribbonMain.SystemText.RenameDisplayLabelText = "&Display Name:"
        Me.ribbonMain.TabIndex = 4
        '
        'toolstriptabPrincipal
        '
        Me.toolstriptabPrincipal.Name = "toolstriptabPrincipal"
        '
        'ribbonMain.RibbonPanel1
        '
        Me.toolstriptabPrincipal.Panel.Controls.Add(Me.toolstripgroupAcciones)
        Me.toolstriptabPrincipal.Panel.Controls.Add(Me.toolstripgroupPeriodo)
        Me.toolstriptabPrincipal.Panel.Name = "RibbonPanel1"
        Me.toolstriptabPrincipal.Panel.ScrollPosition = 0
        Me.toolstriptabPrincipal.Panel.ShowLauncher = False
        Me.toolstriptabPrincipal.Panel.TabIndex = 2
        Me.toolstriptabPrincipal.Panel.Text = "Principal"
        Me.toolstriptabPrincipal.Position = 0
        Me.toolstriptabPrincipal.Size = New System.Drawing.Size(57, 19)
        Me.toolstriptabPrincipal.Tag = "1"
        Me.toolstriptabPrincipal.Text = "Principal"
        '
        'toolstripgroupAcciones
        '
        Me.toolstripgroupAcciones.Dock = System.Windows.Forms.DockStyle.None
        Me.toolstripgroupAcciones.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.toolstripgroupAcciones.ForeColor = System.Drawing.Color.MidnightBlue
        Me.toolstripgroupAcciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripgroupAcciones.Image = Nothing
        Me.toolstripgroupAcciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAgregar, Me.buttonEditar, Me.buttonCopiar, Me.buttonEliminar, Me.buttonImprimir})
        Me.toolstripgroupAcciones.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office2007
        Me.toolstripgroupAcciones.Location = New System.Drawing.Point(0, 1)
        Me.toolstripgroupAcciones.Name = "toolstripgroupAcciones"
        Me.toolstripgroupAcciones.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.toolstripgroupAcciones.Size = New System.Drawing.Size(261, 69)
        Me.toolstripgroupAcciones.TabIndex = 1
        Me.toolstripgroupAcciones.Text = "Acciones"
        '
        'buttonAgregar
        '
        Me.buttonAgregar.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAgregar.Name = "buttonAgregar"
        Me.buttonAgregar.Size = New System.Drawing.Size(52, 44)
        Me.buttonAgregar.Text = "Agregar"
        Me.buttonAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'buttonEditar
        '
        Me.buttonEditar.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(41, 44)
        Me.buttonEditar.Text = "Editar"
        Me.buttonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'buttonCopiar
        '
        Me.buttonCopiar.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_COPY_32
        Me.buttonCopiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCopiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCopiar.Name = "buttonCopiar"
        Me.buttonCopiar.Size = New System.Drawing.Size(45, 44)
        Me.buttonCopiar.Text = "Copiar"
        Me.buttonCopiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(52, 44)
        Me.buttonEliminar.Text = "Eliminar"
        Me.buttonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'buttonImprimir
        '
        Me.buttonImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemImprimir_TicketPesadaReducido, Me.menuitemSeparator1})
        Me.buttonImprimir.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_PRINT_32
        Me.buttonImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonImprimir.Name = "buttonImprimir"
        Me.buttonImprimir.Size = New System.Drawing.Size(65, 44)
        Me.buttonImprimir.Text = "Imprimir"
        Me.buttonImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'menuitemImprimir_TicketPesadaReducido
        '
        Me.menuitemImprimir_TicketPesadaReducido.Name = "menuitemImprimir_TicketPesadaReducido"
        Me.menuitemImprimir_TicketPesadaReducido.Size = New System.Drawing.Size(152, 22)
        Me.menuitemImprimir_TicketPesadaReducido.Text = "Ticket reducido"
        '
        'menuitemSeparator1
        '
        Me.menuitemSeparator1.Name = "menuitemSeparator1"
        Me.menuitemSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'toolstripgroupPeriodo
        '
        Me.toolstripgroupPeriodo.Dock = System.Windows.Forms.DockStyle.None
        Me.toolstripgroupPeriodo.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.toolstripgroupPeriodo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.toolstripgroupPeriodo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripgroupPeriodo.Image = Nothing
        Me.toolstripgroupPeriodo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.comboboxPeriodoTipo, Me.comboboxPeriodoValor, Me.labelFecha, Me.buttonFechaDesdeAnterior, Me.labelFechaDesdeDiaSemana, Me.buttonFechaDesdeSiguiente, Me.buttonFechaDesdeHoy, Me.labelFechaY, Me.buttonFechaHastaAnterior, Me.buttonFechaHastaSiguiente, Me.buttonFechaHastaHoy})
        Me.toolstripgroupPeriodo.Location = New System.Drawing.Point(263, 1)
        Me.toolstripgroupPeriodo.Name = "toolstripgroupPeriodo"
        Me.toolstripgroupPeriodo.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.toolstripgroupPeriodo.ShowLauncher = True
        Me.toolstripgroupPeriodo.Size = New System.Drawing.Size(468, 69)
        Me.toolstripgroupPeriodo.TabIndex = 2
        Me.toolstripgroupPeriodo.Text = "Período"
        '
        'comboboxPeriodoTipo
        '
        Me.comboboxPeriodoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxPeriodoTipo.Name = "comboboxPeriodoTipo"
        Me.comboboxPeriodoTipo.Size = New System.Drawing.Size(75, 46)
        '
        'comboboxPeriodoValor
        '
        Me.comboboxPeriodoValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxPeriodoValor.Name = "comboboxPeriodoValor"
        Me.comboboxPeriodoValor.Size = New System.Drawing.Size(121, 46)
        '
        'labelFecha
        '
        Me.labelFecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.labelFecha.Name = "labelFecha"
        Me.labelFecha.Size = New System.Drawing.Size(40, 43)
        Me.labelFecha.Text = "Fecha:"
        '
        'buttonFechaDesdeAnterior
        '
        Me.buttonFechaDesdeAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonFechaDesdeAnterior.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_CALENDAR_PREVIOUS_16
        Me.buttonFechaDesdeAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFechaDesdeAnterior.Name = "buttonFechaDesdeAnterior"
        Me.buttonFechaDesdeAnterior.Size = New System.Drawing.Size(23, 43)
        Me.buttonFechaDesdeAnterior.ToolTipText = "Día anterior"
        '
        'labelFechaDesdeDiaSemana
        '
        Me.labelFechaDesdeDiaSemana.AutoSize = False
        Me.labelFechaDesdeDiaSemana.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.labelFechaDesdeDiaSemana.Name = "labelFechaDesdeDiaSemana"
        Me.labelFechaDesdeDiaSemana.Size = New System.Drawing.Size(60, 43)
        Me.labelFechaDesdeDiaSemana.Text = "Día"
        '
        'buttonFechaDesdeSiguiente
        '
        Me.buttonFechaDesdeSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonFechaDesdeSiguiente.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_CALENDAR_NEXT_16
        Me.buttonFechaDesdeSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFechaDesdeSiguiente.Name = "buttonFechaDesdeSiguiente"
        Me.buttonFechaDesdeSiguiente.Size = New System.Drawing.Size(23, 43)
        Me.buttonFechaDesdeSiguiente.ToolTipText = "Día siguiente"
        '
        'buttonFechaDesdeHoy
        '
        Me.buttonFechaDesdeHoy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonFechaDesdeHoy.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_CALENDAR_TODAY_16
        Me.buttonFechaDesdeHoy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFechaDesdeHoy.Name = "buttonFechaDesdeHoy"
        Me.buttonFechaDesdeHoy.Size = New System.Drawing.Size(23, 43)
        Me.buttonFechaDesdeHoy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.buttonFechaDesdeHoy.ToolTipText = "Hoy"
        '
        'labelFechaY
        '
        Me.labelFechaY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.labelFechaY.Name = "labelFechaY"
        Me.labelFechaY.Size = New System.Drawing.Size(24, 43)
        Me.labelFechaY.Text = "  y  "
        '
        'buttonFechaHastaAnterior
        '
        Me.buttonFechaHastaAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonFechaHastaAnterior.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_CALENDAR_PREVIOUS_16
        Me.buttonFechaHastaAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFechaHastaAnterior.Name = "buttonFechaHastaAnterior"
        Me.buttonFechaHastaAnterior.Size = New System.Drawing.Size(23, 43)
        Me.buttonFechaHastaAnterior.ToolTipText = "Día anterior"
        '
        'buttonFechaHastaSiguiente
        '
        Me.buttonFechaHastaSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonFechaHastaSiguiente.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_CALENDAR_NEXT_16
        Me.buttonFechaHastaSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFechaHastaSiguiente.Name = "buttonFechaHastaSiguiente"
        Me.buttonFechaHastaSiguiente.Size = New System.Drawing.Size(23, 43)
        Me.buttonFechaHastaSiguiente.ToolTipText = "Día siguiente"
        '
        'buttonFechaHastaHoy
        '
        Me.buttonFechaHastaHoy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonFechaHastaHoy.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_CALENDAR_TODAY_16
        Me.buttonFechaHastaHoy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFechaHastaHoy.Name = "buttonFechaHastaHoy"
        Me.buttonFechaHastaHoy.Size = New System.Drawing.Size(23, 43)
        Me.buttonFechaHastaHoy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.buttonFechaHastaHoy.ToolTipText = "Hoy"
        '
        'toolstriptabFiltrosBasicos
        '
        Me.toolstriptabFiltrosBasicos.Name = "toolstriptabFiltrosBasicos"
        '
        'ribbonMain.RibbonPanel2
        '
        Me.toolstriptabFiltrosBasicos.Panel.Controls.Add(Me.toolstripgroupTitular)
        Me.toolstriptabFiltrosBasicos.Panel.Controls.Add(Me.toolstripgroupProducto)
        Me.toolstriptabFiltrosBasicos.Panel.Controls.Add(Me.toolstripgroupPlanta)
        Me.toolstriptabFiltrosBasicos.Panel.Controls.Add(Me.tooltripgroupPesadaTipo)
        Me.toolstriptabFiltrosBasicos.Panel.Controls.Add(Me.toolstripgroupCosecha)
        Me.toolstriptabFiltrosBasicos.Panel.Controls.Add(Me.toolstripgroupOrigen)
        Me.toolstriptabFiltrosBasicos.Panel.Controls.Add(Me.toolstripgroupDestino)
        Me.toolstriptabFiltrosBasicos.Panel.Controls.Add(Me.toolstripgroupTransportista)
        Me.toolstriptabFiltrosBasicos.Panel.Controls.Add(Me.toolstripgroupChofer)
        Me.toolstriptabFiltrosBasicos.Panel.Name = "RibbonPanel2"
        Me.toolstriptabFiltrosBasicos.Panel.ScrollPosition = 0
        Me.toolstriptabFiltrosBasicos.Panel.ShowLauncher = False
        Me.toolstriptabFiltrosBasicos.Panel.TabIndex = 3
        Me.toolstriptabFiltrosBasicos.Panel.Text = "Básicos"
        Me.toolstriptabFiltrosBasicos.Position = 1
        Me.toolstriptabFiltrosBasicos.Size = New System.Drawing.Size(51, 19)
        Me.toolstriptabFiltrosBasicos.Tag = "1"
        Me.toolstriptabFiltrosBasicos.Text = "Básicos"
        '
        'toolstripgroupTitular
        '
        Me.toolstripgroupTitular.Dock = System.Windows.Forms.DockStyle.None
        Me.toolstripgroupTitular.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.toolstripgroupTitular.ForeColor = System.Drawing.Color.MidnightBlue
        Me.toolstripgroupTitular.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripgroupTitular.Image = Nothing
        Me.toolstripgroupTitular.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.comboboxTitular})
        Me.toolstripgroupTitular.Location = New System.Drawing.Point(0, 1)
        Me.toolstripgroupTitular.Name = "toolstripgroupTitular"
        Me.toolstripgroupTitular.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.toolstripgroupTitular.Size = New System.Drawing.Size(208, 69)
        Me.toolstripgroupTitular.TabIndex = 1
        Me.toolstripgroupTitular.Text = "Titular"
        '
        'comboboxTitular
        '
        Me.comboboxTitular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxTitular.Name = "comboboxTitular"
        Me.comboboxTitular.Size = New System.Drawing.Size(200, 47)
        '
        'toolstripgroupProducto
        '
        Me.toolstripgroupProducto.Dock = System.Windows.Forms.DockStyle.None
        Me.toolstripgroupProducto.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.toolstripgroupProducto.ForeColor = System.Drawing.Color.MidnightBlue
        Me.toolstripgroupProducto.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripgroupProducto.Image = Nothing
        Me.toolstripgroupProducto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.comboboxProducto})
        Me.toolstripgroupProducto.Location = New System.Drawing.Point(210, 1)
        Me.toolstripgroupProducto.Name = "toolstripgroupProducto"
        Me.toolstripgroupProducto.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.toolstripgroupProducto.Size = New System.Drawing.Size(128, 69)
        Me.toolstripgroupProducto.TabIndex = 2
        Me.toolstripgroupProducto.Text = "Producto"
        '
        'comboboxProducto
        '
        Me.comboboxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxProducto.Name = "comboboxProducto"
        Me.comboboxProducto.Size = New System.Drawing.Size(120, 47)
        '
        'toolstripgroupPlanta
        '
        Me.toolstripgroupPlanta.Dock = System.Windows.Forms.DockStyle.None
        Me.toolstripgroupPlanta.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.toolstripgroupPlanta.ForeColor = System.Drawing.Color.MidnightBlue
        Me.toolstripgroupPlanta.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripgroupPlanta.Image = Nothing
        Me.toolstripgroupPlanta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.comboboxPlanta})
        Me.toolstripgroupPlanta.Location = New System.Drawing.Point(340, 1)
        Me.toolstripgroupPlanta.Name = "toolstripgroupPlanta"
        Me.toolstripgroupPlanta.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.toolstripgroupPlanta.Size = New System.Drawing.Size(138, 69)
        Me.toolstripgroupPlanta.TabIndex = 7
        Me.toolstripgroupPlanta.Text = "Planta"
        '
        'comboboxPlanta
        '
        Me.comboboxPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxPlanta.Name = "comboboxPlanta"
        Me.comboboxPlanta.Size = New System.Drawing.Size(130, 47)
        '
        'tooltripgroupPesadaTipo
        '
        Me.tooltripgroupPesadaTipo.Dock = System.Windows.Forms.DockStyle.None
        Me.tooltripgroupPesadaTipo.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.tooltripgroupPesadaTipo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.tooltripgroupPesadaTipo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tooltripgroupPesadaTipo.Image = Nothing
        Me.tooltripgroupPesadaTipo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dropdownbuttonPesadaTipo})
        Me.tooltripgroupPesadaTipo.Location = New System.Drawing.Point(480, 1)
        Me.tooltripgroupPesadaTipo.Name = "tooltripgroupPesadaTipo"
        Me.tooltripgroupPesadaTipo.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.tooltripgroupPesadaTipo.Size = New System.Drawing.Size(113, 69)
        Me.tooltripgroupPesadaTipo.TabIndex = 0
        '
        'dropdownbuttonPesadaTipo
        '
        Me.dropdownbuttonPesadaTipo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.dropdownbuttonPesadaTipo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemPesadaTipo_Entrada, Me.menuitemPesadaTipo_Salida, Me.menuitemPesadaTipo_Ninguno, Me.separatorMarcarTodos, Me.menuitemPesadaTipo_MarcarTodos, Me.menuitemPesadaTipo_DesmarcarTodos})
        Me.dropdownbuttonPesadaTipo.Image = CType(resources.GetObject("dropdownbuttonPesadaTipo.Image"), System.Drawing.Image)
        Me.dropdownbuttonPesadaTipo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.dropdownbuttonPesadaTipo.Name = "dropdownbuttonPesadaTipo"
        Me.dropdownbuttonPesadaTipo.Size = New System.Drawing.Size(107, 44)
        Me.dropdownbuttonPesadaTipo.Text = "Tipos de Pesadas"
        '
        'menuitemPesadaTipo_Entrada
        '
        Me.menuitemPesadaTipo_Entrada.Checked = True
        Me.menuitemPesadaTipo_Entrada.CheckOnClick = True
        Me.menuitemPesadaTipo_Entrada.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuitemPesadaTipo_Entrada.Name = "menuitemPesadaTipo_Entrada"
        Me.menuitemPesadaTipo_Entrada.Size = New System.Drawing.Size(160, 22)
        Me.menuitemPesadaTipo_Entrada.Text = "Entrada"
        '
        'menuitemPesadaTipo_Salida
        '
        Me.menuitemPesadaTipo_Salida.Checked = True
        Me.menuitemPesadaTipo_Salida.CheckOnClick = True
        Me.menuitemPesadaTipo_Salida.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuitemPesadaTipo_Salida.Name = "menuitemPesadaTipo_Salida"
        Me.menuitemPesadaTipo_Salida.Size = New System.Drawing.Size(160, 22)
        Me.menuitemPesadaTipo_Salida.Text = "Salida"
        '
        'menuitemPesadaTipo_Ninguno
        '
        Me.menuitemPesadaTipo_Ninguno.Checked = True
        Me.menuitemPesadaTipo_Ninguno.CheckOnClick = True
        Me.menuitemPesadaTipo_Ninguno.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuitemPesadaTipo_Ninguno.Name = "menuitemPesadaTipo_Ninguno"
        Me.menuitemPesadaTipo_Ninguno.Size = New System.Drawing.Size(160, 22)
        Me.menuitemPesadaTipo_Ninguno.Text = "Ninguna"
        '
        'separatorMarcarTodos
        '
        Me.separatorMarcarTodos.Name = "separatorMarcarTodos"
        Me.separatorMarcarTodos.Size = New System.Drawing.Size(157, 6)
        '
        'menuitemPesadaTipo_MarcarTodos
        '
        Me.menuitemPesadaTipo_MarcarTodos.Name = "menuitemPesadaTipo_MarcarTodos"
        Me.menuitemPesadaTipo_MarcarTodos.Size = New System.Drawing.Size(160, 22)
        Me.menuitemPesadaTipo_MarcarTodos.Text = "Marcar todos"
        '
        'menuitemPesadaTipo_DesmarcarTodos
        '
        Me.menuitemPesadaTipo_DesmarcarTodos.Name = "menuitemPesadaTipo_DesmarcarTodos"
        Me.menuitemPesadaTipo_DesmarcarTodos.Size = New System.Drawing.Size(160, 22)
        Me.menuitemPesadaTipo_DesmarcarTodos.Text = "Desmarcar todos"
        '
        'toolstripgroupCosecha
        '
        Me.toolstripgroupCosecha.Dock = System.Windows.Forms.DockStyle.None
        Me.toolstripgroupCosecha.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.toolstripgroupCosecha.ForeColor = System.Drawing.Color.MidnightBlue
        Me.toolstripgroupCosecha.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripgroupCosecha.Image = Nothing
        Me.toolstripgroupCosecha.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.comboboxCosecha})
        Me.toolstripgroupCosecha.Location = New System.Drawing.Point(595, 1)
        Me.toolstripgroupCosecha.Name = "toolstripgroupCosecha"
        Me.toolstripgroupCosecha.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.toolstripgroupCosecha.Size = New System.Drawing.Size(108, 69)
        Me.toolstripgroupCosecha.TabIndex = 3
        Me.toolstripgroupCosecha.Text = "Cosecha"
        '
        'comboboxCosecha
        '
        Me.comboboxCosecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCosecha.Name = "comboboxCosecha"
        Me.comboboxCosecha.Size = New System.Drawing.Size(100, 47)
        '
        'toolstripgroupOrigen
        '
        Me.toolstripgroupOrigen.Dock = System.Windows.Forms.DockStyle.None
        Me.toolstripgroupOrigen.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.toolstripgroupOrigen.ForeColor = System.Drawing.Color.MidnightBlue
        Me.toolstripgroupOrigen.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripgroupOrigen.Image = Nothing
        Me.toolstripgroupOrigen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.comboboxOrigen})
        Me.toolstripgroupOrigen.Location = New System.Drawing.Point(705, 1)
        Me.toolstripgroupOrigen.Name = "toolstripgroupOrigen"
        Me.toolstripgroupOrigen.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.toolstripgroupOrigen.Size = New System.Drawing.Size(178, 69)
        Me.toolstripgroupOrigen.TabIndex = 4
        Me.toolstripgroupOrigen.Text = "Orígen"
        '
        'comboboxOrigen
        '
        Me.comboboxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxOrigen.Name = "comboboxOrigen"
        Me.comboboxOrigen.Size = New System.Drawing.Size(170, 47)
        '
        'toolstripgroupDestino
        '
        Me.toolstripgroupDestino.Dock = System.Windows.Forms.DockStyle.None
        Me.toolstripgroupDestino.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.toolstripgroupDestino.ForeColor = System.Drawing.Color.MidnightBlue
        Me.toolstripgroupDestino.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripgroupDestino.Image = Nothing
        Me.toolstripgroupDestino.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.comboboxDestino})
        Me.toolstripgroupDestino.Location = New System.Drawing.Point(885, 1)
        Me.toolstripgroupDestino.Name = "toolstripgroupDestino"
        Me.toolstripgroupDestino.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.toolstripgroupDestino.Size = New System.Drawing.Size(178, 69)
        Me.toolstripgroupDestino.TabIndex = 8
        Me.toolstripgroupDestino.Text = "Destino"
        '
        'comboboxDestino
        '
        Me.comboboxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDestino.Name = "comboboxDestino"
        Me.comboboxDestino.Size = New System.Drawing.Size(170, 47)
        '
        'toolstripgroupTransportista
        '
        Me.toolstripgroupTransportista.Dock = System.Windows.Forms.DockStyle.None
        Me.toolstripgroupTransportista.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.toolstripgroupTransportista.ForeColor = System.Drawing.Color.MidnightBlue
        Me.toolstripgroupTransportista.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripgroupTransportista.Image = Nothing
        Me.toolstripgroupTransportista.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.comboboxTransportista})
        Me.toolstripgroupTransportista.Location = New System.Drawing.Point(1065, 1)
        Me.toolstripgroupTransportista.Name = "toolstripgroupTransportista"
        Me.toolstripgroupTransportista.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.toolstripgroupTransportista.Size = New System.Drawing.Size(208, 69)
        Me.toolstripgroupTransportista.TabIndex = 5
        Me.toolstripgroupTransportista.Text = "Transportista"
        '
        'comboboxTransportista
        '
        Me.comboboxTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxTransportista.Name = "comboboxTransportista"
        Me.comboboxTransportista.Size = New System.Drawing.Size(200, 47)
        '
        'toolstripgroupChofer
        '
        Me.toolstripgroupChofer.Dock = System.Windows.Forms.DockStyle.None
        Me.toolstripgroupChofer.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.toolstripgroupChofer.ForeColor = System.Drawing.Color.MidnightBlue
        Me.toolstripgroupChofer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripgroupChofer.Image = Nothing
        Me.toolstripgroupChofer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.comboboxChofer})
        Me.toolstripgroupChofer.Location = New System.Drawing.Point(1275, 1)
        Me.toolstripgroupChofer.Name = "toolstripgroupChofer"
        Me.toolstripgroupChofer.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.toolstripgroupChofer.Size = New System.Drawing.Size(129, 69)
        Me.toolstripgroupChofer.TabIndex = 6
        Me.toolstripgroupChofer.Text = "Chofer"
        '
        'comboboxChofer
        '
        Me.comboboxChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxChofer.Name = "comboboxChofer"
        Me.comboboxChofer.Size = New System.Drawing.Size(121, 47)
        '
        'toolstriptabFiltrosAvanzados
        '
        Me.toolstriptabFiltrosAvanzados.Name = "toolstriptabFiltrosAvanzados"
        '
        'ribbonMain.RibbonPanel3
        '
        Me.toolstriptabFiltrosAvanzados.Panel.Controls.Add(Me.toolstripgroupEsVerificado)
        Me.toolstriptabFiltrosAvanzados.Panel.Controls.Add(Me.toolstripgroupEsActivo)
        Me.toolstriptabFiltrosAvanzados.Panel.Controls.Add(Me.toolstripgroupMenu)
        Me.toolstriptabFiltrosAvanzados.Panel.Name = "RibbonPanel3"
        Me.toolstriptabFiltrosAvanzados.Panel.ScrollPosition = 0
        Me.toolstriptabFiltrosAvanzados.Panel.TabIndex = 4
        Me.toolstriptabFiltrosAvanzados.Panel.Text = "Avanzados"
        Me.toolstriptabFiltrosAvanzados.Position = 2
        Me.toolstriptabFiltrosAvanzados.Size = New System.Drawing.Size(68, 19)
        Me.toolstriptabFiltrosAvanzados.Tag = "1"
        Me.toolstriptabFiltrosAvanzados.Text = "Avanzados"
        '
        'toolstripgroupEsVerificado
        '
        Me.toolstripgroupEsVerificado.Dock = System.Windows.Forms.DockStyle.None
        Me.toolstripgroupEsVerificado.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.toolstripgroupEsVerificado.ForeColor = System.Drawing.Color.MidnightBlue
        Me.toolstripgroupEsVerificado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripgroupEsVerificado.Image = Nothing
        Me.toolstripgroupEsVerificado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.comboboxEsVerificado})
        Me.toolstripgroupEsVerificado.Location = New System.Drawing.Point(0, 1)
        Me.toolstripgroupEsVerificado.Name = "toolstripgroupEsVerificado"
        Me.toolstripgroupEsVerificado.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.toolstripgroupEsVerificado.ShowLauncher = False
        Me.toolstripgroupEsVerificado.Size = New System.Drawing.Size(88, 69)
        Me.toolstripgroupEsVerificado.TabIndex = 6
        Me.toolstripgroupEsVerificado.Text = "Verificado"
        '
        'comboboxEsVerificado
        '
        Me.comboboxEsVerificado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxEsVerificado.Name = "comboboxEsVerificado"
        Me.comboboxEsVerificado.Size = New System.Drawing.Size(80, 47)
        '
        'toolstripgroupEsActivo
        '
        Me.toolstripgroupEsActivo.Dock = System.Windows.Forms.DockStyle.None
        Me.toolstripgroupEsActivo.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.toolstripgroupEsActivo.ForeColor = System.Drawing.Color.MidnightBlue
        Me.toolstripgroupEsActivo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripgroupEsActivo.Image = Nothing
        Me.toolstripgroupEsActivo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.comboboxEsActivo})
        Me.toolstripgroupEsActivo.Location = New System.Drawing.Point(90, 1)
        Me.toolstripgroupEsActivo.Name = "toolstripgroupEsActivo"
        Me.toolstripgroupEsActivo.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.toolstripgroupEsActivo.ShowLauncher = False
        Me.toolstripgroupEsActivo.Size = New System.Drawing.Size(88, 69)
        Me.toolstripgroupEsActivo.TabIndex = 5
        Me.toolstripgroupEsActivo.Text = "Activo"
        '
        'comboboxEsActivo
        '
        Me.comboboxEsActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxEsActivo.Name = "comboboxEsActivo"
        Me.comboboxEsActivo.Size = New System.Drawing.Size(80, 47)
        '
        'toolstripgroupMenu
        '
        Me.toolstripgroupMenu.AutoSize = False
        Me.toolstripgroupMenu.Dock = System.Windows.Forms.DockStyle.None
        Me.toolstripgroupMenu.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.toolstripgroupMenu.ForeColor = System.Drawing.Color.MidnightBlue
        Me.toolstripgroupMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripgroupMenu.Image = Nothing
        Me.toolstripgroupMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dropdownbuttonTareas})
        Me.toolstripgroupMenu.Location = New System.Drawing.Point(180, 1)
        Me.toolstripgroupMenu.Name = "toolstripgroupMenu"
        Me.toolstripgroupMenu.ShowLauncher = False
        Me.toolstripgroupMenu.Size = New System.Drawing.Size(70, 69)
        Me.toolstripgroupMenu.TabIndex = 7
        '
        'dropdownbuttonTareas
        '
        Me.dropdownbuttonTareas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.dropdownbuttonTareas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemCalcularMermas, Me.menuitemCalcularAcondicionamiento})
        Me.dropdownbuttonTareas.Image = CType(resources.GetObject("dropdownbuttonTareas.Image"), System.Drawing.Image)
        Me.dropdownbuttonTareas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.dropdownbuttonTareas.Name = "dropdownbuttonTareas"
        Me.dropdownbuttonTareas.Size = New System.Drawing.Size(51, 49)
        Me.dropdownbuttonTareas.Text = "Tareas"
        '
        'menuitemCalcularMermas
        '
        Me.menuitemCalcularMermas.Name = "menuitemCalcularMermas"
        Me.menuitemCalcularMermas.Size = New System.Drawing.Size(217, 22)
        Me.menuitemCalcularMermas.Text = "Calcular mermas"
        '
        'menuitemCalcularAcondicionamiento
        '
        Me.menuitemCalcularAcondicionamiento.Name = "menuitemCalcularAcondicionamiento"
        Me.menuitemCalcularAcondicionamiento.Size = New System.Drawing.Size(217, 22)
        Me.menuitemCalcularAcondicionamiento.Text = "Calcular acondicionamiento"
        '
        'formPesadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 369)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.statusstripMain)
        Me.Controls.Add(Me.ribbonMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "formPesadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pesadas"
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ribbonMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ribbonMain.ResumeLayout(False)
        Me.ribbonMain.PerformLayout()
        Me.toolstriptabPrincipal.Panel.ResumeLayout(False)
        Me.toolstriptabPrincipal.Panel.PerformLayout()
        Me.toolstripgroupAcciones.ResumeLayout(False)
        Me.toolstripgroupAcciones.PerformLayout()
        Me.toolstripgroupPeriodo.ResumeLayout(False)
        Me.toolstripgroupPeriodo.PerformLayout()
        Me.toolstriptabFiltrosBasicos.Panel.ResumeLayout(False)
        Me.toolstriptabFiltrosBasicos.Panel.PerformLayout()
        Me.toolstripgroupTitular.ResumeLayout(False)
        Me.toolstripgroupTitular.PerformLayout()
        Me.toolstripgroupProducto.ResumeLayout(False)
        Me.toolstripgroupProducto.PerformLayout()
        Me.toolstripgroupPlanta.ResumeLayout(False)
        Me.toolstripgroupPlanta.PerformLayout()
        Me.tooltripgroupPesadaTipo.ResumeLayout(False)
        Me.tooltripgroupPesadaTipo.PerformLayout()
        Me.toolstripgroupCosecha.ResumeLayout(False)
        Me.toolstripgroupCosecha.PerformLayout()
        Me.toolstripgroupOrigen.ResumeLayout(False)
        Me.toolstripgroupOrigen.PerformLayout()
        Me.toolstripgroupDestino.ResumeLayout(False)
        Me.toolstripgroupDestino.PerformLayout()
        Me.toolstripgroupTransportista.ResumeLayout(False)
        Me.toolstripgroupTransportista.PerformLayout()
        Me.toolstripgroupChofer.ResumeLayout(False)
        Me.toolstripgroupChofer.PerformLayout()
        Me.toolstriptabFiltrosAvanzados.Panel.ResumeLayout(False)
        Me.toolstriptabFiltrosAvanzados.Panel.PerformLayout()
        Me.toolstripgroupEsVerificado.ResumeLayout(False)
        Me.toolstripgroupEsVerificado.PerformLayout()
        Me.toolstripgroupEsActivo.ResumeLayout(False)
        Me.toolstripgroupEsActivo.PerformLayout()
        Me.toolstripgroupMenu.ResumeLayout(False)
        Me.toolstripgroupMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents statusstripMain As System.Windows.Forms.StatusStrip
    Private WithEvents statuslabelMain As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents datagridviewMain As System.Windows.Forms.DataGridView
    Private WithEvents bindingsourceMain As System.Windows.Forms.BindingSource
    Friend WithEvents ribbonMain As Syncfusion.Windows.Forms.Tools.RibbonControlAdv
    Friend WithEvents toolstriptabPrincipal As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Friend WithEvents toolstripgroupAcciones As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents buttonAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCopiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonImprimir As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents toolstripgroupPeriodo As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents comboboxPeriodoTipo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents buttonFechaDesdeAnterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonFechaDesdeSiguiente As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonFechaDesdeHoy As System.Windows.Forms.ToolStripButton
    Friend WithEvents labelFechaY As System.Windows.Forms.ToolStripLabel
    Friend WithEvents toolstriptabFiltrosBasicos As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Friend WithEvents tooltripgroupPesadaTipo As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents buttonFechaHastaAnterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonFechaHastaSiguiente As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonFechaHastaHoy As System.Windows.Forms.ToolStripButton
    Friend WithEvents dropdownbuttonPesadaTipo As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menuitemPesadaTipo_Entrada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemPesadaTipo_Salida As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemPesadaTipo_Ninguno As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents separatorMarcarTodos As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemPesadaTipo_MarcarTodos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemPesadaTipo_DesmarcarTodos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents comboboxPeriodoValor As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents labelFecha As System.Windows.Forms.ToolStripLabel
    Friend WithEvents toolstripgroupTitular As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents comboboxTitular As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripgroupProducto As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents comboboxProducto As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripgroupCosecha As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents comboboxCosecha As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripgroupOrigen As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents comboboxOrigen As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripgroupTransportista As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents comboboxTransportista As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripgroupChofer As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents comboboxChofer As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstriptabFiltrosAvanzados As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Friend WithEvents menuitemImprimir_TicketPesadaReducido As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstripgroupPlanta As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents comboboxPlanta As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripgroupEsVerificado As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents comboboxEsVerificado As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripgroupEsActivo As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents comboboxEsActivo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents toolstripgroupMenu As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents dropdownbuttonTareas As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menuitemCalcularMermas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemCalcularAcondicionamiento As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents columnIDPesada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnFechaHoraInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnFechaHoraFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnComprobanteNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnEntidadTitular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnCosecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnOrigen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnKilogramoBruto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnKilogramoTara As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnKilogramoNeto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnHumedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnZaranda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnKilogramoFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnEntidadTransportista As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnChofer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnCamion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents toolstripgroupDestino As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents comboboxDestino As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents labelFechaDesdeDiaSemana As System.Windows.Forms.ToolStripLabel
End Class
