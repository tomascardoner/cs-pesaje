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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPesadas))
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
        Me.toolstripButtons = New System.Windows.Forms.ToolStrip()
        Me.buttonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.buttonImprimir = New System.Windows.Forms.ToolStripSplitButton()
        Me.menuitemImprimirListado = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.panelToolbars = New System.Windows.Forms.FlowLayoutPanel()
        Me.toolstripEntidadTipo = New System.Windows.Forms.ToolStrip()
        Me.dropdownbuttonEntidadTipos = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menuitemTipo_Entrada = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTipo_Salida = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTipo_Ninguna = New System.Windows.Forms.ToolStripMenuItem()
        Me.separatorMarcarTodos = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemMarcarTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemDesmarcarTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.columnIDPesada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFechaHoraInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnFechaHoraFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnComprobanteNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEntidadTitular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCosecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnOrigenDestino = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.toolstripButtons.SuspendLayout()
        Me.statusstripMain.SuspendLayout()
        Me.panelToolbars.SuspendLayout()
        Me.toolstripEntidadTipo.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstripButtons
        '
        Me.toolstripButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripButtons.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAgregar, Me.buttonEditar, Me.buttonEliminar, Me.buttonImprimir})
        Me.toolstripButtons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.toolstripButtons.Location = New System.Drawing.Point(0, 0)
        Me.toolstripButtons.Name = "toolstripButtons"
        Me.toolstripButtons.Size = New System.Drawing.Size(348, 39)
        Me.toolstripButtons.TabIndex = 0
        '
        'buttonAgregar
        '
        Me.buttonAgregar.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAgregar.Name = "buttonAgregar"
        Me.buttonAgregar.Size = New System.Drawing.Size(85, 36)
        Me.buttonAgregar.Text = "Agregar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(86, 36)
        Me.buttonEliminar.Text = "Eliminar"
        '
        'buttonImprimir
        '
        Me.buttonImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemImprimirListado})
        Me.buttonImprimir.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_PRINT_32
        Me.buttonImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonImprimir.Name = "buttonImprimir"
        Me.buttonImprimir.Size = New System.Drawing.Size(101, 36)
        Me.buttonImprimir.Text = "Imprimir"
        '
        'menuitemImprimirListado
        '
        Me.menuitemImprimirListado.Name = "menuitemImprimirListado"
        Me.menuitemImprimirListado.Size = New System.Drawing.Size(112, 22)
        Me.menuitemImprimirListado.Text = "Listado"
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelMain})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 347)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(905, 22)
        Me.statusstripMain.TabIndex = 1
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(890, 17)
        Me.statuslabelMain.Spring = True
        Me.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelToolbars
        '
        Me.panelToolbars.AutoSize = True
        Me.panelToolbars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelToolbars.Controls.Add(Me.toolstripButtons)
        Me.panelToolbars.Controls.Add(Me.toolstripEntidadTipo)
        Me.panelToolbars.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelToolbars.Location = New System.Drawing.Point(0, 0)
        Me.panelToolbars.Name = "panelToolbars"
        Me.panelToolbars.Size = New System.Drawing.Size(905, 39)
        Me.panelToolbars.TabIndex = 2
        '
        'toolstripEntidadTipo
        '
        Me.toolstripEntidadTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripEntidadTipo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripEntidadTipo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripEntidadTipo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dropdownbuttonEntidadTipos})
        Me.toolstripEntidadTipo.Location = New System.Drawing.Point(348, 0)
        Me.toolstripEntidadTipo.Name = "toolstripEntidadTipo"
        Me.toolstripEntidadTipo.Size = New System.Drawing.Size(108, 39)
        Me.toolstripEntidadTipo.TabIndex = 4
        '
        'dropdownbuttonEntidadTipos
        '
        Me.dropdownbuttonEntidadTipos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.dropdownbuttonEntidadTipos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemTipo_Entrada, Me.menuitemTipo_Salida, Me.menuitemTipo_Ninguna, Me.separatorMarcarTodos, Me.menuitemMarcarTodos, Me.menuitemDesmarcarTodos})
        Me.dropdownbuttonEntidadTipos.Image = CType(resources.GetObject("dropdownbuttonEntidadTipos.Image"), System.Drawing.Image)
        Me.dropdownbuttonEntidadTipos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.dropdownbuttonEntidadTipos.Name = "dropdownbuttonEntidadTipos"
        Me.dropdownbuttonEntidadTipos.Size = New System.Drawing.Size(105, 36)
        Me.dropdownbuttonEntidadTipos.Text = "Tipos de Pesada"
        '
        'menuitemTipo_Entrada
        '
        Me.menuitemTipo_Entrada.Checked = True
        Me.menuitemTipo_Entrada.CheckOnClick = True
        Me.menuitemTipo_Entrada.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuitemTipo_Entrada.Name = "menuitemTipo_Entrada"
        Me.menuitemTipo_Entrada.Size = New System.Drawing.Size(163, 22)
        Me.menuitemTipo_Entrada.Text = "Entrada"
        '
        'menuitemTipo_Salida
        '
        Me.menuitemTipo_Salida.Checked = True
        Me.menuitemTipo_Salida.CheckOnClick = True
        Me.menuitemTipo_Salida.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuitemTipo_Salida.Name = "menuitemTipo_Salida"
        Me.menuitemTipo_Salida.Size = New System.Drawing.Size(163, 22)
        Me.menuitemTipo_Salida.Text = "Salida"
        '
        'menuitemTipo_Ninguna
        '
        Me.menuitemTipo_Ninguna.Checked = True
        Me.menuitemTipo_Ninguna.CheckOnClick = True
        Me.menuitemTipo_Ninguna.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuitemTipo_Ninguna.Name = "menuitemTipo_Ninguna"
        Me.menuitemTipo_Ninguna.Size = New System.Drawing.Size(163, 22)
        Me.menuitemTipo_Ninguna.Text = "Ninguna"
        '
        'separatorMarcarTodos
        '
        Me.separatorMarcarTodos.Name = "separatorMarcarTodos"
        Me.separatorMarcarTodos.Size = New System.Drawing.Size(160, 6)
        '
        'menuitemMarcarTodos
        '
        Me.menuitemMarcarTodos.Name = "menuitemMarcarTodos"
        Me.menuitemMarcarTodos.Size = New System.Drawing.Size(163, 22)
        Me.menuitemMarcarTodos.Text = "Marcar todos"
        '
        'menuitemDesmarcarTodos
        '
        Me.menuitemDesmarcarTodos.Name = "menuitemDesmarcarTodos"
        Me.menuitemDesmarcarTodos.Size = New System.Drawing.Size(163, 22)
        Me.menuitemDesmarcarTodos.Text = "Desmarcar todos"
        '
        'datagridviewMain
        '
        Me.datagridviewMain.AllowUserToAddRows = False
        Me.datagridviewMain.AllowUserToDeleteRows = False
        Me.datagridviewMain.AllowUserToOrderColumns = True
        Me.datagridviewMain.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.datagridviewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnIDPesada, Me.columnFechaHoraInicio, Me.columnFechaHoraFin, Me.columnComprobanteNumero, Me.columnEntidadTitular, Me.columnProducto, Me.columnTipo, Me.columnCosecha, Me.columnOrigenDestino, Me.columnKilogramoBruto, Me.columnKilogramoTara, Me.columnKilogramoNeto, Me.columnHumedad, Me.columnZaranda, Me.columnKilogramoFinal, Me.columnEntidadTransportista, Me.columnChofer, Me.columnCamion})
        Me.datagridviewMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewMain.Location = New System.Drawing.Point(0, 39)
        Me.datagridviewMain.MultiSelect = False
        Me.datagridviewMain.Name = "datagridviewMain"
        Me.datagridviewMain.ReadOnly = True
        Me.datagridviewMain.RowHeadersVisible = False
        Me.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMain.Size = New System.Drawing.Size(905, 308)
        Me.datagridviewMain.TabIndex = 3
        '
        'columnIDPesada
        '
        Me.columnIDPesada.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
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
        Me.columnFechaHoraInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
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
        Me.columnFechaHoraFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
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
        Me.columnTipo.DataPropertyName = "Tipo"
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
        'columnOrigenDestino
        '
        Me.columnOrigenDestino.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnOrigenDestino.DataPropertyName = "OrigenDestinoNombre"
        Me.columnOrigenDestino.HeaderText = "Origen / Destino"
        Me.columnOrigenDestino.Name = "columnOrigenDestino"
        Me.columnOrigenDestino.ReadOnly = True
        Me.columnOrigenDestino.Width = 101
        '
        'columnKilogramoBruto
        '
        Me.columnKilogramoBruto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnKilogramoBruto.DataPropertyName = "KilogramoBruto"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N0"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.columnKilogramoBruto.DefaultCellStyle = DataGridViewCellStyle15
        Me.columnKilogramoBruto.HeaderText = "Kgs. Bruto"
        Me.columnKilogramoBruto.Name = "columnKilogramoBruto"
        Me.columnKilogramoBruto.ReadOnly = True
        Me.columnKilogramoBruto.Width = 75
        '
        'columnKilogramoTara
        '
        Me.columnKilogramoTara.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnKilogramoTara.DataPropertyName = "KilogramoTara"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N0"
        Me.columnKilogramoTara.DefaultCellStyle = DataGridViewCellStyle16
        Me.columnKilogramoTara.HeaderText = "Kgs. Tara"
        Me.columnKilogramoTara.Name = "columnKilogramoTara"
        Me.columnKilogramoTara.ReadOnly = True
        Me.columnKilogramoTara.Width = 72
        '
        'columnKilogramoNeto
        '
        Me.columnKilogramoNeto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnKilogramoNeto.DataPropertyName = "KilogramoNeto"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "N0"
        Me.columnKilogramoNeto.DefaultCellStyle = DataGridViewCellStyle17
        Me.columnKilogramoNeto.HeaderText = "Kgs. Neto"
        Me.columnKilogramoNeto.Name = "columnKilogramoNeto"
        Me.columnKilogramoNeto.ReadOnly = True
        Me.columnKilogramoNeto.Width = 73
        '
        'columnHumedad
        '
        Me.columnHumedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
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
        Me.columnZaranda.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
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
        Me.columnKilogramoFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnKilogramoFinal.DataPropertyName = "KilogramoFinal"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "N0"
        Me.columnKilogramoFinal.DefaultCellStyle = DataGridViewCellStyle20
        Me.columnKilogramoFinal.HeaderText = "Kgs. Final"
        Me.columnKilogramoFinal.Name = "columnKilogramoFinal"
        Me.columnKilogramoFinal.ReadOnly = True
        Me.columnKilogramoFinal.Width = 72
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
        'formPesadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 369)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.panelToolbars)
        Me.Controls.Add(Me.statusstripMain)
        Me.KeyPreview = True
        Me.Name = "formPesadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Pesadas"
        Me.toolstripButtons.ResumeLayout(False)
        Me.toolstripButtons.PerformLayout()
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        Me.panelToolbars.ResumeLayout(False)
        Me.panelToolbars.PerformLayout()
        Me.toolstripEntidadTipo.ResumeLayout(False)
        Me.toolstripEntidadTipo.PerformLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripButtons As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents statusstripMain As System.Windows.Forms.StatusStrip
    Friend WithEvents statuslabelMain As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents panelToolbars As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents buttonImprimir As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents menuitemImprimirListado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstripEntidadTipo As System.Windows.Forms.ToolStrip
    Friend WithEvents dropdownbuttonEntidadTipos As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menuitemTipo_Entrada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTipo_Salida As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTipo_Ninguna As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents separatorMarcarTodos As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemMarcarTodos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemDesmarcarTodos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents datagridviewMain As System.Windows.Forms.DataGridView
    Friend WithEvents bindingsourceMain As System.Windows.Forms.BindingSource
    Friend WithEvents columnIDPesada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnFechaHoraInicio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnFechaHoraFin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnComprobanteNumero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnEntidadTitular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnTipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnCosecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnOrigenDestino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnKilogramoBruto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnKilogramoTara As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnKilogramoNeto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnHumedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnZaranda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnKilogramoFinal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnEntidadTransportista As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnChofer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnCamion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
