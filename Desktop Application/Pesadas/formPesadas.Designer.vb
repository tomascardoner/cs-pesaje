<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formPesadas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPesadas))
        Me.DataGridViewMain = New System.Windows.Forms.DataGridView()
        Me.columnIDPesada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFechaHoraInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFechaHoraFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCtg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPlanta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPlantaDeposito = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.TabControlToolbar = New System.Windows.Forms.TabControl()
        Me.TabPageToolbarPrincipal = New System.Windows.Forms.TabPage()
        Me.ToolStripPeriodo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripComboBoxPeriodoTipo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripComboBoxPeriodoValor = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabelFecha = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButtonFechaDesdeAnterior = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabelFechaDesdeDiaSemana = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButtonFechaDesdeSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonFechaDesdeHoy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabelFechaY = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButtonFechaHastaAnterior = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonFechaHastaHoy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonFechaHastaSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonExpandir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripAcciones = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonImprimir = New System.Windows.Forms.ToolStripSplitButton()
        Me.ToolStripMenuItemImprimirTicketReducido = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPageToolbarBasicos = New System.Windows.Forms.TabPage()
        Me.ToolStripTiposPesada = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButtonTiposPesada = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItemTiposPesadaEntrada = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemTiposPesadaSalida = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemTiposPesadaNinguna = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparatorTiposPesada = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItemTiposPesadaMarcarTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemTiposPesadaDesmarcarTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripCosecha = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabelCosecha = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBoxCosecha = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripPlanta = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabelPlanta = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBoxPlanta = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripProducto = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabelProducto = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBoxProducto = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripTitular = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabelTitular = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBoxTitular = New System.Windows.Forms.ToolStripComboBox()
        Me.TabPageToolbarOtros = New System.Windows.Forms.TabPage()
        Me.ToolStripChofer = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabelChofer = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBoxChofer = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripTransportista = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabelTransportista = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBoxTransportista = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripDestino = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabelDestino = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBoxDestino = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripOrigen = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabelOrigen = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBoxOrigen = New System.Windows.Forms.ToolStripComboBox()
        Me.TabPageToolbarAvanzados = New System.Windows.Forms.TabPage()
        Me.ToolStripTareas = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButtonTareas = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItemTareasCalcularMermas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemTareasCalcularAcondicionamiento = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripActivo = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabelActivo = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBoxActivo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripVerificado = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabelVerificado = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBoxVerificado = New System.Windows.Forms.ToolStripComboBox()
        CType(Me.DataGridViewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlToolbar.SuspendLayout()
        Me.TabPageToolbarPrincipal.SuspendLayout()
        Me.ToolStripPeriodo.SuspendLayout()
        Me.ToolStripAcciones.SuspendLayout()
        Me.TabPageToolbarBasicos.SuspendLayout()
        Me.ToolStripTiposPesada.SuspendLayout()
        Me.ToolStripCosecha.SuspendLayout()
        Me.ToolStripPlanta.SuspendLayout()
        Me.ToolStripProducto.SuspendLayout()
        Me.ToolStripTitular.SuspendLayout()
        Me.TabPageToolbarOtros.SuspendLayout()
        Me.ToolStripChofer.SuspendLayout()
        Me.ToolStripTransportista.SuspendLayout()
        Me.ToolStripDestino.SuspendLayout()
        Me.ToolStripOrigen.SuspendLayout()
        Me.TabPageToolbarAvanzados.SuspendLayout()
        Me.ToolStripTareas.SuspendLayout()
        Me.ToolStripActivo.SuspendLayout()
        Me.ToolStripVerificado.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewMain
        '
        Me.DataGridViewMain.AllowUserToAddRows = False
        Me.DataGridViewMain.AllowUserToDeleteRows = False
        Me.DataGridViewMain.AllowUserToResizeColumns = False
        Me.DataGridViewMain.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.DataGridViewMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewMain.AutoGenerateColumns = False
        Me.DataGridViewMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnIDPesada, Me.columnFechaHoraInicio, Me.columnFechaHoraFin, Me.columnCtg, Me.ColumnComprobante, Me.ColumnPlanta, Me.ColumnPlantaDeposito, Me.columnEntidadTitular, Me.columnProducto, Me.columnTipo, Me.columnCosecha, Me.columnOrigen, Me.columnDestino, Me.columnKilogramoBruto, Me.columnKilogramoTara, Me.columnKilogramoNeto, Me.columnHumedad, Me.columnZaranda, Me.columnKilogramoFinal, Me.columnEntidadTransportista, Me.columnChofer, Me.columnCamion})
        Me.DataGridViewMain.DataSource = Me.bindingsourceMain
        Me.DataGridViewMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewMain.Location = New System.Drawing.Point(0, 100)
        Me.DataGridViewMain.MultiSelect = False
        Me.DataGridViewMain.Name = "DataGridViewMain"
        Me.DataGridViewMain.ReadOnly = True
        Me.DataGridViewMain.RowHeadersVisible = False
        Me.DataGridViewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewMain.Size = New System.Drawing.Size(1197, 269)
        Me.DataGridViewMain.TabIndex = 3
        '
        'columnIDPesada
        '
        Me.columnIDPesada.DataPropertyName = "IDPesada"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Format = "N0"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.columnIDPesada.DefaultCellStyle = DataGridViewCellStyle12
        Me.columnIDPesada.HeaderText = "Número"
        Me.columnIDPesada.Name = "columnIDPesada"
        Me.columnIDPesada.ReadOnly = True
        Me.columnIDPesada.Width = 69
        '
        'columnFechaHoraInicio
        '
        Me.columnFechaHoraInicio.DataPropertyName = "FechaHoraInicio"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.Format = "g"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.columnFechaHoraInicio.DefaultCellStyle = DataGridViewCellStyle13
        Me.columnFechaHoraInicio.HeaderText = "Inicio"
        Me.columnFechaHoraInicio.Name = "columnFechaHoraInicio"
        Me.columnFechaHoraInicio.ReadOnly = True
        Me.columnFechaHoraInicio.Width = 57
        '
        'columnFechaHoraFin
        '
        Me.columnFechaHoraFin.DataPropertyName = "FechaHoraFin"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.Format = "g"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.columnFechaHoraFin.DefaultCellStyle = DataGridViewCellStyle14
        Me.columnFechaHoraFin.HeaderText = "Fin"
        Me.columnFechaHoraFin.Name = "columnFechaHoraFin"
        Me.columnFechaHoraFin.ReadOnly = True
        Me.columnFechaHoraFin.Width = 46
        '
        'columnCtg
        '
        Me.columnCtg.DataPropertyName = "Ctg"
        Me.columnCtg.HeaderText = "C.T.G."
        Me.columnCtg.Name = "columnCtg"
        Me.columnCtg.ReadOnly = True
        Me.columnCtg.Width = 63
        '
        'ColumnComprobante
        '
        Me.ColumnComprobante.DataPropertyName = "ComprobanteNumero"
        Me.ColumnComprobante.HeaderText = "Comprobante"
        Me.ColumnComprobante.Name = "ColumnComprobante"
        Me.ColumnComprobante.ReadOnly = True
        Me.ColumnComprobante.Width = 95
        '
        'ColumnPlanta
        '
        Me.ColumnPlanta.DataPropertyName = "PlantaNombre"
        Me.ColumnPlanta.HeaderText = "Planta"
        Me.ColumnPlanta.Name = "ColumnPlanta"
        Me.ColumnPlanta.ReadOnly = True
        Me.ColumnPlanta.Width = 62
        '
        'ColumnPlantaDeposito
        '
        Me.ColumnPlantaDeposito.DataPropertyName = "PlantaDepositoNombre"
        Me.ColumnPlantaDeposito.HeaderText = "Depósito"
        Me.ColumnPlantaDeposito.Name = "ColumnPlantaDeposito"
        Me.ColumnPlantaDeposito.ReadOnly = True
        Me.ColumnPlantaDeposito.Width = 74
        '
        'columnEntidadTitular
        '
        Me.columnEntidadTitular.DataPropertyName = "TitularNombre"
        Me.columnEntidadTitular.HeaderText = "Titular"
        Me.columnEntidadTitular.Name = "columnEntidadTitular"
        Me.columnEntidadTitular.ReadOnly = True
        Me.columnEntidadTitular.Width = 61
        '
        'columnProducto
        '
        Me.columnProducto.DataPropertyName = "ProductoNombre"
        Me.columnProducto.HeaderText = "Producto"
        Me.columnProducto.Name = "columnProducto"
        Me.columnProducto.ReadOnly = True
        Me.columnProducto.Width = 75
        '
        'columnTipo
        '
        Me.columnTipo.DataPropertyName = "TipoNombre"
        Me.columnTipo.HeaderText = "Tipo"
        Me.columnTipo.Name = "columnTipo"
        Me.columnTipo.ReadOnly = True
        Me.columnTipo.Width = 53
        '
        'columnCosecha
        '
        Me.columnCosecha.DataPropertyName = "CosechaNombre"
        Me.columnCosecha.HeaderText = "Cosecha"
        Me.columnCosecha.Name = "columnCosecha"
        Me.columnCosecha.ReadOnly = True
        Me.columnCosecha.Width = 74
        '
        'columnOrigen
        '
        Me.columnOrigen.DataPropertyName = "OrigenNombre"
        Me.columnOrigen.HeaderText = "Origen"
        Me.columnOrigen.Name = "columnOrigen"
        Me.columnOrigen.ReadOnly = True
        Me.columnOrigen.Width = 63
        '
        'columnDestino
        '
        Me.columnDestino.DataPropertyName = "DestinoNombre"
        Me.columnDestino.HeaderText = "Destino"
        Me.columnDestino.Name = "columnDestino"
        Me.columnDestino.ReadOnly = True
        Me.columnDestino.Width = 68
        '
        'columnKilogramoBruto
        '
        Me.columnKilogramoBruto.DataPropertyName = "KilogramoBruto"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N0"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.columnKilogramoBruto.DefaultCellStyle = DataGridViewCellStyle15
        Me.columnKilogramoBruto.HeaderText = "Kgs. Bruto"
        Me.columnKilogramoBruto.Name = "columnKilogramoBruto"
        Me.columnKilogramoBruto.ReadOnly = True
        Me.columnKilogramoBruto.Width = 81
        '
        'columnKilogramoTara
        '
        Me.columnKilogramoTara.DataPropertyName = "KilogramoTara"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N0"
        Me.columnKilogramoTara.DefaultCellStyle = DataGridViewCellStyle16
        Me.columnKilogramoTara.HeaderText = "Kgs. Tara"
        Me.columnKilogramoTara.Name = "columnKilogramoTara"
        Me.columnKilogramoTara.ReadOnly = True
        Me.columnKilogramoTara.Width = 78
        '
        'columnKilogramoNeto
        '
        Me.columnKilogramoNeto.DataPropertyName = "KilogramoNeto"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "N0"
        Me.columnKilogramoNeto.DefaultCellStyle = DataGridViewCellStyle17
        Me.columnKilogramoNeto.HeaderText = "Kgs. Neto"
        Me.columnKilogramoNeto.Name = "columnKilogramoNeto"
        Me.columnKilogramoNeto.ReadOnly = True
        Me.columnKilogramoNeto.Width = 79
        '
        'columnHumedad
        '
        Me.columnHumedad.DataPropertyName = "Humedad"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "N1"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.columnHumedad.DefaultCellStyle = DataGridViewCellStyle18
        Me.columnHumedad.HeaderText = "Hum."
        Me.columnHumedad.Name = "columnHumedad"
        Me.columnHumedad.ReadOnly = True
        Me.columnHumedad.Width = 57
        '
        'columnZaranda
        '
        Me.columnZaranda.DataPropertyName = "Zaranda"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "N1"
        Me.columnZaranda.DefaultCellStyle = DataGridViewCellStyle19
        Me.columnZaranda.HeaderText = "Zar."
        Me.columnZaranda.Name = "columnZaranda"
        Me.columnZaranda.ReadOnly = True
        Me.columnZaranda.Width = 51
        '
        'columnKilogramoFinal
        '
        Me.columnKilogramoFinal.DataPropertyName = "KilogramoFinal"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "N0"
        Me.columnKilogramoFinal.DefaultCellStyle = DataGridViewCellStyle20
        Me.columnKilogramoFinal.HeaderText = "Kgs. Final"
        Me.columnKilogramoFinal.Name = "columnKilogramoFinal"
        Me.columnKilogramoFinal.ReadOnly = True
        Me.columnKilogramoFinal.Width = 78
        '
        'columnEntidadTransportista
        '
        Me.columnEntidadTransportista.DataPropertyName = "TransportistaNombre"
        Me.columnEntidadTransportista.HeaderText = "Transportista"
        Me.columnEntidadTransportista.Name = "columnEntidadTransportista"
        Me.columnEntidadTransportista.ReadOnly = True
        Me.columnEntidadTransportista.Width = 93
        '
        'columnChofer
        '
        Me.columnChofer.DataPropertyName = "ChoferNombre"
        Me.columnChofer.HeaderText = "Chofer"
        Me.columnChofer.Name = "columnChofer"
        Me.columnChofer.ReadOnly = True
        Me.columnChofer.Width = 63
        '
        'columnCamion
        '
        Me.columnCamion.DataPropertyName = "CamionNombreDominios"
        Me.columnCamion.HeaderText = "Camión"
        Me.columnCamion.Name = "columnCamion"
        Me.columnCamion.ReadOnly = True
        Me.columnCamion.Width = 67
        '
        'TabControlToolbar
        '
        Me.TabControlToolbar.Controls.Add(Me.TabPageToolbarPrincipal)
        Me.TabControlToolbar.Controls.Add(Me.TabPageToolbarBasicos)
        Me.TabControlToolbar.Controls.Add(Me.TabPageToolbarOtros)
        Me.TabControlToolbar.Controls.Add(Me.TabPageToolbarAvanzados)
        Me.TabControlToolbar.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControlToolbar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TabControlToolbar.Location = New System.Drawing.Point(0, 0)
        Me.TabControlToolbar.Name = "TabControlToolbar"
        Me.TabControlToolbar.SelectedIndex = 0
        Me.TabControlToolbar.Size = New System.Drawing.Size(1197, 100)
        Me.TabControlToolbar.TabIndex = 5
        '
        'TabPageToolbarPrincipal
        '
        Me.TabPageToolbarPrincipal.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TabPageToolbarPrincipal.Controls.Add(Me.ToolStripPeriodo)
        Me.TabPageToolbarPrincipal.Controls.Add(Me.ToolStripAcciones)
        Me.TabPageToolbarPrincipal.Location = New System.Drawing.Point(4, 22)
        Me.TabPageToolbarPrincipal.Name = "TabPageToolbarPrincipal"
        Me.TabPageToolbarPrincipal.Size = New System.Drawing.Size(1189, 74)
        Me.TabPageToolbarPrincipal.TabIndex = 0
        Me.TabPageToolbarPrincipal.Text = "Principal"
        '
        'ToolStripPeriodo
        '
        Me.ToolStripPeriodo.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStripPeriodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ToolStripPeriodo.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripPeriodo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripPeriodo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBoxPeriodoTipo, Me.ToolStripComboBoxPeriodoValor, Me.ToolStripLabelFecha, Me.ToolStripButtonFechaDesdeAnterior, Me.ToolStripLabelFechaDesdeDiaSemana, Me.ToolStripButtonFechaDesdeSiguiente, Me.ToolStripButtonFechaDesdeHoy, Me.ToolStripLabelFechaY, Me.ToolStripButtonFechaHastaAnterior, Me.ToolStripButtonFechaHastaHoy, Me.ToolStripButtonFechaHastaSiguiente, Me.ToolStripButtonExpandir})
        Me.ToolStripPeriodo.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStripPeriodo.Location = New System.Drawing.Point(212, 0)
        Me.ToolStripPeriodo.Name = "ToolStripPeriodo"
        Me.ToolStripPeriodo.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ToolStripPeriodo.Size = New System.Drawing.Size(524, 74)
        Me.ToolStripPeriodo.TabIndex = 1
        Me.ToolStripPeriodo.Text = "Período"
        '
        'ToolStripComboBoxPeriodoTipo
        '
        Me.ToolStripComboBoxPeriodoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxPeriodoTipo.Name = "ToolStripComboBoxPeriodoTipo"
        Me.ToolStripComboBoxPeriodoTipo.Size = New System.Drawing.Size(75, 74)
        '
        'ToolStripComboBoxPeriodoValor
        '
        Me.ToolStripComboBoxPeriodoValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxPeriodoValor.Name = "ToolStripComboBoxPeriodoValor"
        Me.ToolStripComboBoxPeriodoValor.Size = New System.Drawing.Size(121, 74)
        '
        'ToolStripLabelFecha
        '
        Me.ToolStripLabelFecha.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabelFecha.Name = "ToolStripLabelFecha"
        Me.ToolStripLabelFecha.Size = New System.Drawing.Size(41, 71)
        Me.ToolStripLabelFecha.Text = "Fecha:"
        '
        'ToolStripButtonFechaDesdeAnterior
        '
        Me.ToolStripButtonFechaDesdeAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonFechaDesdeAnterior.Image = Global.CSPesaje.My.Resources.Resources.ImageCalendarPrevious16
        Me.ToolStripButtonFechaDesdeAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonFechaDesdeAnterior.Name = "ToolStripButtonFechaDesdeAnterior"
        Me.ToolStripButtonFechaDesdeAnterior.Size = New System.Drawing.Size(23, 71)
        Me.ToolStripButtonFechaDesdeAnterior.ToolTipText = "Día anterior"
        '
        'ToolStripLabelFechaDesdeDiaSemana
        '
        Me.ToolStripLabelFechaDesdeDiaSemana.AutoSize = False
        Me.ToolStripLabelFechaDesdeDiaSemana.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabelFechaDesdeDiaSemana.Name = "ToolStripLabelFechaDesdeDiaSemana"
        Me.ToolStripLabelFechaDesdeDiaSemana.Size = New System.Drawing.Size(60, 43)
        Me.ToolStripLabelFechaDesdeDiaSemana.Text = "Día"
        '
        'ToolStripButtonFechaDesdeSiguiente
        '
        Me.ToolStripButtonFechaDesdeSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonFechaDesdeSiguiente.Image = Global.CSPesaje.My.Resources.Resources.ImageCalendarNext16
        Me.ToolStripButtonFechaDesdeSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonFechaDesdeSiguiente.Name = "ToolStripButtonFechaDesdeSiguiente"
        Me.ToolStripButtonFechaDesdeSiguiente.Size = New System.Drawing.Size(23, 71)
        Me.ToolStripButtonFechaDesdeSiguiente.ToolTipText = "Día siguiente"
        '
        'ToolStripButtonFechaDesdeHoy
        '
        Me.ToolStripButtonFechaDesdeHoy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonFechaDesdeHoy.Image = Global.CSPesaje.My.Resources.Resources.ImageCalendarToday16
        Me.ToolStripButtonFechaDesdeHoy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonFechaDesdeHoy.Name = "ToolStripButtonFechaDesdeHoy"
        Me.ToolStripButtonFechaDesdeHoy.Size = New System.Drawing.Size(23, 71)
        Me.ToolStripButtonFechaDesdeHoy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripButtonFechaDesdeHoy.ToolTipText = "Hoy"
        '
        'ToolStripLabelFechaY
        '
        Me.ToolStripLabelFechaY.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripLabelFechaY.Name = "ToolStripLabelFechaY"
        Me.ToolStripLabelFechaY.Size = New System.Drawing.Size(25, 71)
        Me.ToolStripLabelFechaY.Text = "  y  "
        '
        'ToolStripButtonFechaHastaAnterior
        '
        Me.ToolStripButtonFechaHastaAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonFechaHastaAnterior.Image = Global.CSPesaje.My.Resources.Resources.ImageCalendarPrevious16
        Me.ToolStripButtonFechaHastaAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonFechaHastaAnterior.Name = "ToolStripButtonFechaHastaAnterior"
        Me.ToolStripButtonFechaHastaAnterior.Size = New System.Drawing.Size(23, 71)
        Me.ToolStripButtonFechaHastaAnterior.ToolTipText = "Día anterior"
        '
        'ToolStripButtonFechaHastaHoy
        '
        Me.ToolStripButtonFechaHastaHoy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonFechaHastaHoy.Image = Global.CSPesaje.My.Resources.Resources.ImageCalendarToday16
        Me.ToolStripButtonFechaHastaHoy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonFechaHastaHoy.Name = "ToolStripButtonFechaHastaHoy"
        Me.ToolStripButtonFechaHastaHoy.Size = New System.Drawing.Size(23, 71)
        Me.ToolStripButtonFechaHastaHoy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripButtonFechaHastaHoy.ToolTipText = "Hoy"
        '
        'ToolStripButtonFechaHastaSiguiente
        '
        Me.ToolStripButtonFechaHastaSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonFechaHastaSiguiente.Image = Global.CSPesaje.My.Resources.Resources.ImageCalendarNext16
        Me.ToolStripButtonFechaHastaSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonFechaHastaSiguiente.Name = "ToolStripButtonFechaHastaSiguiente"
        Me.ToolStripButtonFechaHastaSiguiente.Size = New System.Drawing.Size(23, 71)
        Me.ToolStripButtonFechaHastaSiguiente.ToolTipText = "Día siguiente"
        '
        'ToolStripButtonExpandir
        '
        Me.ToolStripButtonExpandir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonExpandir.Image = Global.CSPesaje.My.Resources.Resources.ImageToolbarExpandir16
        Me.ToolStripButtonExpandir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripButtonExpandir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonExpandir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonExpandir.Name = "ToolStripButtonExpandir"
        Me.ToolStripButtonExpandir.Size = New System.Drawing.Size(23, 71)
        Me.ToolStripButtonExpandir.Text = "Expandir"
        '
        'ToolStripAcciones
        '
        Me.ToolStripAcciones.AllowMerge = False
        Me.ToolStripAcciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStripAcciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripAcciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripAcciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonAgregar, Me.ToolStripButtonEditar, Me.ToolStripButtonBorrar, Me.ToolStripButtonImprimir})
        Me.ToolStripAcciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStripAcciones.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripAcciones.Name = "ToolStripAcciones"
        Me.ToolStripAcciones.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ToolStripAcciones.Size = New System.Drawing.Size(212, 74)
        Me.ToolStripAcciones.TabIndex = 0
        Me.ToolStripAcciones.Text = "Acciones"
        '
        'ToolStripButtonAgregar
        '
        Me.ToolStripButtonAgregar.Image = Global.CSPesaje.My.Resources.Resources.ImageItemAgregar32
        Me.ToolStripButtonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAgregar.Name = "ToolStripButtonAgregar"
        Me.ToolStripButtonAgregar.Size = New System.Drawing.Size(53, 71)
        Me.ToolStripButtonAgregar.Text = "Agregar"
        Me.ToolStripButtonAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButtonEditar
        '
        Me.ToolStripButtonEditar.Image = Global.CSPesaje.My.Resources.Resources.ImageItemEditar32
        Me.ToolStripButtonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonEditar.Name = "ToolStripButtonEditar"
        Me.ToolStripButtonEditar.Size = New System.Drawing.Size(41, 71)
        Me.ToolStripButtonEditar.Text = "Editar"
        Me.ToolStripButtonEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButtonBorrar
        '
        Me.ToolStripButtonBorrar.Image = Global.CSPesaje.My.Resources.Resources.ImageItemBorrar32
        Me.ToolStripButtonBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonBorrar.Name = "ToolStripButtonBorrar"
        Me.ToolStripButtonBorrar.Size = New System.Drawing.Size(43, 71)
        Me.ToolStripButtonBorrar.Text = "Borrar"
        Me.ToolStripButtonBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButtonImprimir
        '
        Me.ToolStripButtonImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemImprimirTicketReducido})
        Me.ToolStripButtonImprimir.Image = Global.CSPesaje.My.Resources.Resources.ImageImprimir32
        Me.ToolStripButtonImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButtonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonImprimir.Name = "ToolStripButtonImprimir"
        Me.ToolStripButtonImprimir.Size = New System.Drawing.Size(69, 71)
        Me.ToolStripButtonImprimir.Text = "Imprimir"
        Me.ToolStripButtonImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItemImprimirTicketReducido
        '
        Me.ToolStripMenuItemImprimirTicketReducido.Name = "ToolStripMenuItemImprimirTicketReducido"
        Me.ToolStripMenuItemImprimirTicketReducido.Size = New System.Drawing.Size(155, 22)
        Me.ToolStripMenuItemImprimirTicketReducido.Text = "Ticket reducido"
        '
        'TabPageToolbarBasicos
        '
        Me.TabPageToolbarBasicos.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TabPageToolbarBasicos.Controls.Add(Me.ToolStripTiposPesada)
        Me.TabPageToolbarBasicos.Controls.Add(Me.ToolStripCosecha)
        Me.TabPageToolbarBasicos.Controls.Add(Me.ToolStripPlanta)
        Me.TabPageToolbarBasicos.Controls.Add(Me.ToolStripProducto)
        Me.TabPageToolbarBasicos.Controls.Add(Me.ToolStripTitular)
        Me.TabPageToolbarBasicos.Location = New System.Drawing.Point(4, 22)
        Me.TabPageToolbarBasicos.Name = "TabPageToolbarBasicos"
        Me.TabPageToolbarBasicos.Size = New System.Drawing.Size(1189, 74)
        Me.TabPageToolbarBasicos.TabIndex = 1
        Me.TabPageToolbarBasicos.Text = "Básicos"
        '
        'ToolStripTiposPesada
        '
        Me.ToolStripTiposPesada.AllowMerge = False
        Me.ToolStripTiposPesada.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStripTiposPesada.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripTiposPesada.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripTiposPesada.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButtonTiposPesada})
        Me.ToolStripTiposPesada.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStripTiposPesada.Location = New System.Drawing.Point(484, 0)
        Me.ToolStripTiposPesada.Name = "ToolStripTiposPesada"
        Me.ToolStripTiposPesada.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ToolStripTiposPesada.Size = New System.Drawing.Size(115, 74)
        Me.ToolStripTiposPesada.TabIndex = 4
        Me.ToolStripTiposPesada.Text = "Tipos"
        '
        'ToolStripDropDownButtonTiposPesada
        '
        Me.ToolStripDropDownButtonTiposPesada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButtonTiposPesada.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemTiposPesadaEntrada, Me.ToolStripMenuItemTiposPesadaSalida, Me.ToolStripMenuItemTiposPesadaNinguna, Me.ToolStripSeparatorTiposPesada, Me.ToolStripMenuItemTiposPesadaMarcarTodos, Me.ToolStripMenuItemTiposPesadaDesmarcarTodos})
        Me.ToolStripDropDownButtonTiposPesada.Image = CType(resources.GetObject("ToolStripDropDownButtonTiposPesada.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButtonTiposPesada.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButtonTiposPesada.Name = "ToolStripDropDownButtonTiposPesada"
        Me.ToolStripDropDownButtonTiposPesada.Size = New System.Drawing.Size(109, 71)
        Me.ToolStripDropDownButtonTiposPesada.Text = "Tipos de Pesadas"
        '
        'ToolStripMenuItemTiposPesadaEntrada
        '
        Me.ToolStripMenuItemTiposPesadaEntrada.Checked = True
        Me.ToolStripMenuItemTiposPesadaEntrada.CheckOnClick = True
        Me.ToolStripMenuItemTiposPesadaEntrada.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItemTiposPesadaEntrada.Name = "ToolStripMenuItemTiposPesadaEntrada"
        Me.ToolStripMenuItemTiposPesadaEntrada.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItemTiposPesadaEntrada.Text = "Entrada"
        '
        'ToolStripMenuItemTiposPesadaSalida
        '
        Me.ToolStripMenuItemTiposPesadaSalida.Checked = True
        Me.ToolStripMenuItemTiposPesadaSalida.CheckOnClick = True
        Me.ToolStripMenuItemTiposPesadaSalida.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItemTiposPesadaSalida.Name = "ToolStripMenuItemTiposPesadaSalida"
        Me.ToolStripMenuItemTiposPesadaSalida.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItemTiposPesadaSalida.Text = "Salida"
        '
        'ToolStripMenuItemTiposPesadaNinguna
        '
        Me.ToolStripMenuItemTiposPesadaNinguna.Checked = True
        Me.ToolStripMenuItemTiposPesadaNinguna.CheckOnClick = True
        Me.ToolStripMenuItemTiposPesadaNinguna.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolStripMenuItemTiposPesadaNinguna.Name = "ToolStripMenuItemTiposPesadaNinguna"
        Me.ToolStripMenuItemTiposPesadaNinguna.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItemTiposPesadaNinguna.Text = "Ninguna"
        '
        'ToolStripSeparatorTiposPesada
        '
        Me.ToolStripSeparatorTiposPesada.Name = "ToolStripSeparatorTiposPesada"
        Me.ToolStripSeparatorTiposPesada.Size = New System.Drawing.Size(160, 6)
        '
        'ToolStripMenuItemTiposPesadaMarcarTodos
        '
        Me.ToolStripMenuItemTiposPesadaMarcarTodos.Name = "ToolStripMenuItemTiposPesadaMarcarTodos"
        Me.ToolStripMenuItemTiposPesadaMarcarTodos.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItemTiposPesadaMarcarTodos.Text = "Marcar todos"
        '
        'ToolStripMenuItemTiposPesadaDesmarcarTodos
        '
        Me.ToolStripMenuItemTiposPesadaDesmarcarTodos.Name = "ToolStripMenuItemTiposPesadaDesmarcarTodos"
        Me.ToolStripMenuItemTiposPesadaDesmarcarTodos.Size = New System.Drawing.Size(163, 22)
        Me.ToolStripMenuItemTiposPesadaDesmarcarTodos.Text = "Desmarcar todos"
        '
        'ToolStripCosecha
        '
        Me.ToolStripCosecha.AllowMerge = False
        Me.ToolStripCosecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStripCosecha.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripCosecha.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripCosecha.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelCosecha, Me.ToolStripComboBoxCosecha})
        Me.ToolStripCosecha.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStripCosecha.Location = New System.Drawing.Point(398, 0)
        Me.ToolStripCosecha.Name = "ToolStripCosecha"
        Me.ToolStripCosecha.Padding = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.ToolStripCosecha.Size = New System.Drawing.Size(86, 74)
        Me.ToolStripCosecha.TabIndex = 3
        Me.ToolStripCosecha.Text = "Cosecha"
        '
        'ToolStripLabelCosecha
        '
        Me.ToolStripLabelCosecha.Name = "ToolStripLabelCosecha"
        Me.ToolStripLabelCosecha.Size = New System.Drawing.Size(77, 15)
        Me.ToolStripLabelCosecha.Text = "Cosecha"
        '
        'ToolStripComboBoxCosecha
        '
        Me.ToolStripComboBoxCosecha.AutoSize = False
        Me.ToolStripComboBoxCosecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxCosecha.Name = "ToolStripComboBoxCosecha"
        Me.ToolStripComboBoxCosecha.Size = New System.Drawing.Size(80, 23)
        '
        'ToolStripPlanta
        '
        Me.ToolStripPlanta.AllowMerge = False
        Me.ToolStripPlanta.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStripPlanta.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripPlanta.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripPlanta.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelPlanta, Me.ToolStripComboBoxPlanta})
        Me.ToolStripPlanta.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStripPlanta.Location = New System.Drawing.Point(302, 0)
        Me.ToolStripPlanta.Name = "ToolStripPlanta"
        Me.ToolStripPlanta.Padding = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.ToolStripPlanta.Size = New System.Drawing.Size(96, 74)
        Me.ToolStripPlanta.TabIndex = 2
        Me.ToolStripPlanta.Text = "Planta"
        '
        'ToolStripLabelPlanta
        '
        Me.ToolStripLabelPlanta.Name = "ToolStripLabelPlanta"
        Me.ToolStripLabelPlanta.Size = New System.Drawing.Size(87, 15)
        Me.ToolStripLabelPlanta.Text = "Planta"
        '
        'ToolStripComboBoxPlanta
        '
        Me.ToolStripComboBoxPlanta.AutoSize = False
        Me.ToolStripComboBoxPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxPlanta.Name = "ToolStripComboBoxPlanta"
        Me.ToolStripComboBoxPlanta.Size = New System.Drawing.Size(90, 23)
        '
        'ToolStripProducto
        '
        Me.ToolStripProducto.AllowMerge = False
        Me.ToolStripProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStripProducto.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripProducto.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripProducto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelProducto, Me.ToolStripComboBoxProducto})
        Me.ToolStripProducto.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStripProducto.Location = New System.Drawing.Point(186, 0)
        Me.ToolStripProducto.Name = "ToolStripProducto"
        Me.ToolStripProducto.Padding = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.ToolStripProducto.Size = New System.Drawing.Size(116, 74)
        Me.ToolStripProducto.TabIndex = 1
        Me.ToolStripProducto.Text = "Producto"
        '
        'ToolStripLabelProducto
        '
        Me.ToolStripLabelProducto.Name = "ToolStripLabelProducto"
        Me.ToolStripLabelProducto.Size = New System.Drawing.Size(107, 15)
        Me.ToolStripLabelProducto.Text = "Producto"
        '
        'ToolStripComboBoxProducto
        '
        Me.ToolStripComboBoxProducto.AutoSize = False
        Me.ToolStripComboBoxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxProducto.Name = "ToolStripComboBoxProducto"
        Me.ToolStripComboBoxProducto.Size = New System.Drawing.Size(110, 23)
        '
        'ToolStripTitular
        '
        Me.ToolStripTitular.AllowMerge = False
        Me.ToolStripTitular.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStripTitular.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripTitular.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripTitular.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelTitular, Me.ToolStripComboBoxTitular})
        Me.ToolStripTitular.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStripTitular.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripTitular.Name = "ToolStripTitular"
        Me.ToolStripTitular.Padding = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.ToolStripTitular.Size = New System.Drawing.Size(186, 74)
        Me.ToolStripTitular.TabIndex = 0
        Me.ToolStripTitular.Text = "Titular"
        '
        'ToolStripLabelTitular
        '
        Me.ToolStripLabelTitular.Name = "ToolStripLabelTitular"
        Me.ToolStripLabelTitular.Size = New System.Drawing.Size(177, 15)
        Me.ToolStripLabelTitular.Text = "Titular"
        '
        'ToolStripComboBoxTitular
        '
        Me.ToolStripComboBoxTitular.AutoSize = False
        Me.ToolStripComboBoxTitular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxTitular.Name = "ToolStripComboBoxTitular"
        Me.ToolStripComboBoxTitular.Size = New System.Drawing.Size(180, 23)
        '
        'TabPageToolbarOtros
        '
        Me.TabPageToolbarOtros.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TabPageToolbarOtros.Controls.Add(Me.ToolStripChofer)
        Me.TabPageToolbarOtros.Controls.Add(Me.ToolStripTransportista)
        Me.TabPageToolbarOtros.Controls.Add(Me.ToolStripDestino)
        Me.TabPageToolbarOtros.Controls.Add(Me.ToolStripOrigen)
        Me.TabPageToolbarOtros.Location = New System.Drawing.Point(4, 22)
        Me.TabPageToolbarOtros.Name = "TabPageToolbarOtros"
        Me.TabPageToolbarOtros.Size = New System.Drawing.Size(1189, 74)
        Me.TabPageToolbarOtros.TabIndex = 2
        Me.TabPageToolbarOtros.Text = "Otros"
        '
        'ToolStripChofer
        '
        Me.ToolStripChofer.AllowMerge = False
        Me.ToolStripChofer.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStripChofer.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripChofer.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripChofer.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelChofer, Me.ToolStripComboBoxChofer})
        Me.ToolStripChofer.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStripChofer.Location = New System.Drawing.Point(718, 0)
        Me.ToolStripChofer.Name = "ToolStripChofer"
        Me.ToolStripChofer.Padding = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.ToolStripChofer.Size = New System.Drawing.Size(216, 74)
        Me.ToolStripChofer.TabIndex = 4
        Me.ToolStripChofer.Text = "Chofer"
        '
        'ToolStripLabelChofer
        '
        Me.ToolStripLabelChofer.Name = "ToolStripLabelChofer"
        Me.ToolStripLabelChofer.Size = New System.Drawing.Size(207, 15)
        Me.ToolStripLabelChofer.Text = "Chofer"
        '
        'ToolStripComboBoxChofer
        '
        Me.ToolStripComboBoxChofer.AutoSize = False
        Me.ToolStripComboBoxChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxChofer.Name = "ToolStripComboBoxChofer"
        Me.ToolStripComboBoxChofer.Size = New System.Drawing.Size(210, 23)
        '
        'ToolStripTransportista
        '
        Me.ToolStripTransportista.AllowMerge = False
        Me.ToolStripTransportista.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStripTransportista.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripTransportista.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripTransportista.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelTransportista, Me.ToolStripComboBoxTransportista})
        Me.ToolStripTransportista.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStripTransportista.Location = New System.Drawing.Point(492, 0)
        Me.ToolStripTransportista.Name = "ToolStripTransportista"
        Me.ToolStripTransportista.Padding = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.ToolStripTransportista.Size = New System.Drawing.Size(226, 74)
        Me.ToolStripTransportista.TabIndex = 3
        Me.ToolStripTransportista.Text = "Transportista"
        '
        'ToolStripLabelTransportista
        '
        Me.ToolStripLabelTransportista.Name = "ToolStripLabelTransportista"
        Me.ToolStripLabelTransportista.Size = New System.Drawing.Size(217, 15)
        Me.ToolStripLabelTransportista.Text = "Transportista"
        '
        'ToolStripComboBoxTransportista
        '
        Me.ToolStripComboBoxTransportista.AutoSize = False
        Me.ToolStripComboBoxTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxTransportista.Name = "ToolStripComboBoxTransportista"
        Me.ToolStripComboBoxTransportista.Size = New System.Drawing.Size(220, 23)
        '
        'ToolStripDestino
        '
        Me.ToolStripDestino.AllowMerge = False
        Me.ToolStripDestino.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStripDestino.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripDestino.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripDestino.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelDestino, Me.ToolStripComboBoxDestino})
        Me.ToolStripDestino.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStripDestino.Location = New System.Drawing.Point(246, 0)
        Me.ToolStripDestino.Name = "ToolStripDestino"
        Me.ToolStripDestino.Padding = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.ToolStripDestino.Size = New System.Drawing.Size(246, 74)
        Me.ToolStripDestino.TabIndex = 2
        Me.ToolStripDestino.Text = "Destino"
        '
        'ToolStripLabelDestino
        '
        Me.ToolStripLabelDestino.Name = "ToolStripLabelDestino"
        Me.ToolStripLabelDestino.Size = New System.Drawing.Size(237, 15)
        Me.ToolStripLabelDestino.Text = "Destino"
        '
        'ToolStripComboBoxDestino
        '
        Me.ToolStripComboBoxDestino.AutoSize = False
        Me.ToolStripComboBoxDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxDestino.Name = "ToolStripComboBoxDestino"
        Me.ToolStripComboBoxDestino.Size = New System.Drawing.Size(240, 23)
        '
        'ToolStripOrigen
        '
        Me.ToolStripOrigen.AllowMerge = False
        Me.ToolStripOrigen.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStripOrigen.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripOrigen.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripOrigen.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelOrigen, Me.ToolStripComboBoxOrigen})
        Me.ToolStripOrigen.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStripOrigen.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripOrigen.Name = "ToolStripOrigen"
        Me.ToolStripOrigen.Padding = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.ToolStripOrigen.Size = New System.Drawing.Size(246, 74)
        Me.ToolStripOrigen.TabIndex = 1
        Me.ToolStripOrigen.Text = "Origen"
        '
        'ToolStripLabelOrigen
        '
        Me.ToolStripLabelOrigen.Name = "ToolStripLabelOrigen"
        Me.ToolStripLabelOrigen.Size = New System.Drawing.Size(237, 15)
        Me.ToolStripLabelOrigen.Text = "Origen"
        '
        'ToolStripComboBoxOrigen
        '
        Me.ToolStripComboBoxOrigen.AutoSize = False
        Me.ToolStripComboBoxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxOrigen.Name = "ToolStripComboBoxOrigen"
        Me.ToolStripComboBoxOrigen.Size = New System.Drawing.Size(240, 23)
        '
        'TabPageToolbarAvanzados
        '
        Me.TabPageToolbarAvanzados.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.TabPageToolbarAvanzados.Controls.Add(Me.ToolStripTareas)
        Me.TabPageToolbarAvanzados.Controls.Add(Me.ToolStripActivo)
        Me.TabPageToolbarAvanzados.Controls.Add(Me.ToolStripVerificado)
        Me.TabPageToolbarAvanzados.Location = New System.Drawing.Point(4, 22)
        Me.TabPageToolbarAvanzados.Name = "TabPageToolbarAvanzados"
        Me.TabPageToolbarAvanzados.Size = New System.Drawing.Size(1189, 74)
        Me.TabPageToolbarAvanzados.TabIndex = 3
        Me.TabPageToolbarAvanzados.Text = "Avanzados"
        '
        'ToolStripTareas
        '
        Me.ToolStripTareas.AllowMerge = False
        Me.ToolStripTareas.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStripTareas.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripTareas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripTareas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButtonTareas})
        Me.ToolStripTareas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStripTareas.Location = New System.Drawing.Point(152, 0)
        Me.ToolStripTareas.Name = "ToolStripTareas"
        Me.ToolStripTareas.Padding = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ToolStripTareas.Size = New System.Drawing.Size(58, 74)
        Me.ToolStripTareas.TabIndex = 6
        Me.ToolStripTareas.Text = "Tareas"
        '
        'ToolStripDropDownButtonTareas
        '
        Me.ToolStripDropDownButtonTareas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButtonTareas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemTareasCalcularMermas, Me.ToolStripMenuItemTareasCalcularAcondicionamiento})
        Me.ToolStripDropDownButtonTareas.Image = CType(resources.GetObject("ToolStripDropDownButtonTareas.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButtonTareas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButtonTareas.Name = "ToolStripDropDownButtonTareas"
        Me.ToolStripDropDownButtonTareas.Size = New System.Drawing.Size(52, 71)
        Me.ToolStripDropDownButtonTareas.Text = "Tareas"
        '
        'ToolStripMenuItemTareasCalcularMermas
        '
        Me.ToolStripMenuItemTareasCalcularMermas.Name = "ToolStripMenuItemTareasCalcularMermas"
        Me.ToolStripMenuItemTareasCalcularMermas.Size = New System.Drawing.Size(223, 22)
        Me.ToolStripMenuItemTareasCalcularMermas.Text = "Calcular mermas"
        '
        'ToolStripMenuItemTareasCalcularAcondicionamiento
        '
        Me.ToolStripMenuItemTareasCalcularAcondicionamiento.Name = "ToolStripMenuItemTareasCalcularAcondicionamiento"
        Me.ToolStripMenuItemTareasCalcularAcondicionamiento.Size = New System.Drawing.Size(223, 22)
        Me.ToolStripMenuItemTareasCalcularAcondicionamiento.Text = "Calcular acondicionamiento"
        '
        'ToolStripActivo
        '
        Me.ToolStripActivo.AllowMerge = False
        Me.ToolStripActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStripActivo.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripActivo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripActivo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelActivo, Me.ToolStripComboBoxActivo})
        Me.ToolStripActivo.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStripActivo.Location = New System.Drawing.Point(76, 0)
        Me.ToolStripActivo.Name = "ToolStripActivo"
        Me.ToolStripActivo.Padding = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.ToolStripActivo.Size = New System.Drawing.Size(76, 74)
        Me.ToolStripActivo.TabIndex = 5
        Me.ToolStripActivo.Text = "Activo"
        '
        'ToolStripLabelActivo
        '
        Me.ToolStripLabelActivo.Name = "ToolStripLabelActivo"
        Me.ToolStripLabelActivo.Size = New System.Drawing.Size(67, 15)
        Me.ToolStripLabelActivo.Text = "Activo"
        '
        'ToolStripComboBoxActivo
        '
        Me.ToolStripComboBoxActivo.AutoSize = False
        Me.ToolStripComboBoxActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxActivo.Name = "ToolStripComboBoxActivo"
        Me.ToolStripComboBoxActivo.Size = New System.Drawing.Size(70, 23)
        '
        'ToolStripVerificado
        '
        Me.ToolStripVerificado.AllowMerge = False
        Me.ToolStripVerificado.BackColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ToolStripVerificado.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStripVerificado.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripVerificado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabelVerificado, Me.ToolStripComboBoxVerificado})
        Me.ToolStripVerificado.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStripVerificado.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripVerificado.Name = "ToolStripVerificado"
        Me.ToolStripVerificado.Padding = New System.Windows.Forms.Padding(2, 8, 2, 0)
        Me.ToolStripVerificado.Size = New System.Drawing.Size(76, 74)
        Me.ToolStripVerificado.TabIndex = 4
        Me.ToolStripVerificado.Text = "Verificado"
        '
        'ToolStripLabelVerificado
        '
        Me.ToolStripLabelVerificado.Name = "ToolStripLabelVerificado"
        Me.ToolStripLabelVerificado.Size = New System.Drawing.Size(67, 15)
        Me.ToolStripLabelVerificado.Text = "Verificado"
        '
        'ToolStripComboBoxVerificado
        '
        Me.ToolStripComboBoxVerificado.AutoSize = False
        Me.ToolStripComboBoxVerificado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToolStripComboBoxVerificado.Name = "ToolStripComboBoxVerificado"
        Me.ToolStripComboBoxVerificado.Size = New System.Drawing.Size(70, 23)
        '
        'formPesadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1197, 369)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridViewMain)
        Me.Controls.Add(Me.TabControlToolbar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "formPesadas"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pesadas"
        CType(Me.DataGridViewMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlToolbar.ResumeLayout(False)
        Me.TabPageToolbarPrincipal.ResumeLayout(False)
        Me.TabPageToolbarPrincipal.PerformLayout()
        Me.ToolStripPeriodo.ResumeLayout(False)
        Me.ToolStripPeriodo.PerformLayout()
        Me.ToolStripAcciones.ResumeLayout(False)
        Me.ToolStripAcciones.PerformLayout()
        Me.TabPageToolbarBasicos.ResumeLayout(False)
        Me.TabPageToolbarBasicos.PerformLayout()
        Me.ToolStripTiposPesada.ResumeLayout(False)
        Me.ToolStripTiposPesada.PerformLayout()
        Me.ToolStripCosecha.ResumeLayout(False)
        Me.ToolStripCosecha.PerformLayout()
        Me.ToolStripPlanta.ResumeLayout(False)
        Me.ToolStripPlanta.PerformLayout()
        Me.ToolStripProducto.ResumeLayout(False)
        Me.ToolStripProducto.PerformLayout()
        Me.ToolStripTitular.ResumeLayout(False)
        Me.ToolStripTitular.PerformLayout()
        Me.TabPageToolbarOtros.ResumeLayout(False)
        Me.TabPageToolbarOtros.PerformLayout()
        Me.ToolStripChofer.ResumeLayout(False)
        Me.ToolStripChofer.PerformLayout()
        Me.ToolStripTransportista.ResumeLayout(False)
        Me.ToolStripTransportista.PerformLayout()
        Me.ToolStripDestino.ResumeLayout(False)
        Me.ToolStripDestino.PerformLayout()
        Me.ToolStripOrigen.ResumeLayout(False)
        Me.ToolStripOrigen.PerformLayout()
        Me.TabPageToolbarAvanzados.ResumeLayout(False)
        Me.TabPageToolbarAvanzados.PerformLayout()
        Me.ToolStripTareas.ResumeLayout(False)
        Me.ToolStripTareas.PerformLayout()
        Me.ToolStripActivo.ResumeLayout(False)
        Me.ToolStripActivo.PerformLayout()
        Me.ToolStripVerificado.ResumeLayout(False)
        Me.ToolStripVerificado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents DataGridViewMain As System.Windows.Forms.DataGridView
    Private WithEvents bindingsourceMain As System.Windows.Forms.BindingSource
    Private WithEvents columnIDPesada As DataGridViewTextBoxColumn
    Private WithEvents columnFechaHoraInicio As DataGridViewTextBoxColumn
    Private WithEvents columnFechaHoraFin As DataGridViewTextBoxColumn
    Private WithEvents columnCtg As DataGridViewTextBoxColumn
    Private WithEvents ColumnComprobante As DataGridViewTextBoxColumn
    Private WithEvents ColumnPlanta As DataGridViewTextBoxColumn
    Private WithEvents ColumnPlantaDeposito As DataGridViewTextBoxColumn
    Private WithEvents columnEntidadTitular As DataGridViewTextBoxColumn
    Private WithEvents columnProducto As DataGridViewTextBoxColumn
    Private WithEvents columnTipo As DataGridViewTextBoxColumn
    Private WithEvents columnCosecha As DataGridViewTextBoxColumn
    Private WithEvents columnOrigen As DataGridViewTextBoxColumn
    Private WithEvents columnDestino As DataGridViewTextBoxColumn
    Private WithEvents columnKilogramoBruto As DataGridViewTextBoxColumn
    Private WithEvents columnKilogramoTara As DataGridViewTextBoxColumn
    Private WithEvents columnKilogramoNeto As DataGridViewTextBoxColumn
    Private WithEvents columnHumedad As DataGridViewTextBoxColumn
    Private WithEvents columnZaranda As DataGridViewTextBoxColumn
    Private WithEvents columnKilogramoFinal As DataGridViewTextBoxColumn
    Private WithEvents columnEntidadTransportista As DataGridViewTextBoxColumn
    Private WithEvents columnChofer As DataGridViewTextBoxColumn
    Private WithEvents columnCamion As DataGridViewTextBoxColumn
    Friend WithEvents TabControlToolbar As TabControl
    Friend WithEvents TabPageToolbarPrincipal As TabPage
    Friend WithEvents TabPageToolbarBasicos As TabPage
    Friend WithEvents TabPageToolbarOtros As TabPage
    Friend WithEvents TabPageToolbarAvanzados As TabPage
    Friend WithEvents ToolStripAcciones As ToolStrip
    Friend WithEvents ToolStripButtonAgregar As ToolStripButton
    Friend WithEvents ToolStripButtonEditar As ToolStripButton
    Friend WithEvents ToolStripButtonBorrar As ToolStripButton
    Friend WithEvents ToolStripButtonImprimir As ToolStripSplitButton
    Friend WithEvents ToolStripPeriodo As ToolStrip
    Friend WithEvents ToolStripComboBoxPeriodoTipo As ToolStripComboBox
    Friend WithEvents ToolStripComboBoxPeriodoValor As ToolStripComboBox
    Private WithEvents ToolStripLabelFecha As ToolStripLabel
    Private WithEvents ToolStripLabelFechaDesdeDiaSemana As ToolStripLabel
    Friend WithEvents ToolStripButtonFechaDesdeSiguiente As ToolStripButton
    Friend WithEvents ToolStripButtonFechaDesdeAnterior As ToolStripButton
    Friend WithEvents ToolStripButtonFechaDesdeHoy As ToolStripButton
    Friend WithEvents ToolStripMenuItemImprimirTicketReducido As ToolStripMenuItem
    Private WithEvents ToolStripLabelFechaY As ToolStripLabel
    Friend WithEvents ToolStripButtonFechaHastaAnterior As ToolStripButton
    Friend WithEvents ToolStripButtonFechaHastaHoy As ToolStripButton
    Friend WithEvents ToolStripButtonFechaHastaSiguiente As ToolStripButton
    Friend WithEvents ToolStripTitular As ToolStrip
    Friend WithEvents ToolStripLabelTitular As ToolStripLabel
    Friend WithEvents ToolStripComboBoxTitular As ToolStripComboBox
    Friend WithEvents ToolStripProducto As ToolStrip
    Friend WithEvents ToolStripLabelProducto As ToolStripLabel
    Friend WithEvents ToolStripComboBoxProducto As ToolStripComboBox
    Friend WithEvents ToolStripPlanta As ToolStrip
    Friend WithEvents ToolStripLabelPlanta As ToolStripLabel
    Friend WithEvents ToolStripComboBoxPlanta As ToolStripComboBox
    Friend WithEvents ToolStripCosecha As ToolStrip
    Friend WithEvents ToolStripLabelCosecha As ToolStripLabel
    Friend WithEvents ToolStripComboBoxCosecha As ToolStripComboBox
    Friend WithEvents ToolStripTiposPesada As ToolStrip
    Friend WithEvents ToolStripDropDownButtonTiposPesada As ToolStripDropDownButton
    Private WithEvents ToolStripMenuItemTiposPesadaEntrada As ToolStripMenuItem
    Private WithEvents ToolStripMenuItemTiposPesadaSalida As ToolStripMenuItem
    Private WithEvents ToolStripMenuItemTiposPesadaNinguna As ToolStripMenuItem
    Private WithEvents ToolStripSeparatorTiposPesada As ToolStripSeparator
    Private WithEvents ToolStripMenuItemTiposPesadaMarcarTodos As ToolStripMenuItem
    Private WithEvents ToolStripMenuItemTiposPesadaDesmarcarTodos As ToolStripMenuItem
    Friend WithEvents ToolStripChofer As ToolStrip
    Friend WithEvents ToolStripLabelChofer As ToolStripLabel
    Friend WithEvents ToolStripComboBoxChofer As ToolStripComboBox
    Friend WithEvents ToolStripTransportista As ToolStrip
    Friend WithEvents ToolStripLabelTransportista As ToolStripLabel
    Friend WithEvents ToolStripComboBoxTransportista As ToolStripComboBox
    Friend WithEvents ToolStripDestino As ToolStrip
    Friend WithEvents ToolStripLabelDestino As ToolStripLabel
    Friend WithEvents ToolStripComboBoxDestino As ToolStripComboBox
    Friend WithEvents ToolStripOrigen As ToolStrip
    Friend WithEvents ToolStripLabelOrigen As ToolStripLabel
    Friend WithEvents ToolStripComboBoxOrigen As ToolStripComboBox
    Friend WithEvents ToolStripTareas As ToolStrip
    Friend WithEvents ToolStripDropDownButtonTareas As ToolStripDropDownButton
    Private WithEvents ToolStripMenuItemTareasCalcularMermas As ToolStripMenuItem
    Private WithEvents ToolStripMenuItemTareasCalcularAcondicionamiento As ToolStripMenuItem
    Friend WithEvents ToolStripActivo As ToolStrip
    Friend WithEvents ToolStripLabelActivo As ToolStripLabel
    Friend WithEvents ToolStripComboBoxActivo As ToolStripComboBox
    Friend WithEvents ToolStripVerificado As ToolStrip
    Friend WithEvents ToolStripLabelVerificado As ToolStripLabel
    Friend WithEvents ToolStripComboBoxVerificado As ToolStripComboBox
    Friend WithEvents ToolStripButtonExpandir As ToolStripButton
End Class
