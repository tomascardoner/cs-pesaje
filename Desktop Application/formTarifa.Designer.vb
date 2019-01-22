<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTarifa
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
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tabcontrolMain = New CSPesaje.DesktopApplication.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.roupboxGeneralOpcionales = New System.Windows.Forms.GroupBox()
        Me.datetimepickerFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.labelFechaHasta = New System.Windows.Forms.Label()
        Me.datetimepickerFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.labelFechaDesde = New System.Windows.Forms.Label()
        Me.labelOrigen = New System.Windows.Forms.Label()
        Me.comboboxOrigen = New System.Windows.Forms.ComboBox()
        Me.comboboxEntidad = New System.Windows.Forms.ComboBox()
        Me.labelEntidad = New System.Windows.Forms.Label()
        Me.comboboxPlanta = New System.Windows.Forms.ComboBox()
        Me.labelPlanta = New System.Windows.Forms.Label()
        Me.groupboxGeneralRequeridos = New System.Windows.Forms.GroupBox()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.comboboxCosecha = New System.Windows.Forms.ComboBox()
        Me.updownIndice = New System.Windows.Forms.NumericUpDown()
        Me.labelCosecha = New System.Windows.Forms.Label()
        Me.labelIndice = New System.Windows.Forms.Label()
        Me.comboboxProducto = New System.Windows.Forms.ComboBox()
        Me.labelProducto = New System.Windows.Forms.Label()
        Me.tabpageSecadoEscala = New System.Windows.Forms.TabPage()
        Me.tabpageTarifas = New System.Windows.Forms.TabPage()
        Me.groupboxTarifasVarias = New System.Windows.Forms.GroupBox()
        Me.labelParitariaImporte = New System.Windows.Forms.Label()
        Me.doubletextboxParitariaImporte = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.doubletextboxZarandeoImporte = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelZarandeoImporte = New System.Windows.Forms.Label()
        Me.doubletextboxFumigadoImporte = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelFumigadoImporte = New System.Windows.Forms.Label()
        Me.doubletextboxMezcladoImporte = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelMezcladoImporte = New System.Windows.Forms.Label()
        Me.groupboxTarifasSecado = New System.Windows.Forms.GroupBox()
        Me.radiobuttonSecadoTipoFijo = New System.Windows.Forms.RadioButton()
        Me.radiobuttonSecadoTipoEscala = New System.Windows.Forms.RadioButton()
        Me.groupboxTarifasSecadoSecadoTipo = New System.Windows.Forms.GroupBox()
        Me.doubletextboxSecadoInicialPunto = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelSecadoInicialPunto = New System.Windows.Forms.Label()
        Me.doubletextboxSecadoInicialImporte = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelSecadoInicialImporte = New System.Windows.Forms.Label()
        Me.groupboxTarifasSecadoInicial = New System.Windows.Forms.GroupBox()
        Me.labelTarifasSecadoExcesoImporte = New System.Windows.Forms.Label()
        Me.doubletextboxTarifasSecadoExcesoImporte = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.doubletextboxTarifasSecadoHumedadBase = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelSecadoHumedadBase = New System.Windows.Forms.Label()
        Me.doubletextboxTarifasSecadoMargenLibre = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelTarifasSecadoMargenLibre = New System.Windows.Forms.Label()
        Me.groupboxTarifasSecadoRedondeoPuntoTipo = New System.Windows.Forms.GroupBox()
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno = New System.Windows.Forms.RadioButton()
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero = New System.Windows.Forms.RadioButton()
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior = New System.Windows.Forms.RadioButton()
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior = New System.Windows.Forms.RadioButton()
        Me.tabpageAlmacenaje = New System.Windows.Forms.TabPage()
        Me.radiobuttonAlmacenajeTipoDiasGraciaFijo = New System.Windows.Forms.RadioButton()
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes = New System.Windows.Forms.RadioButton()
        Me.radiobuttonAlmacenajeTipoFechaFija = New System.Windows.Forms.RadioButton()
        Me.groupboxAlmacenajeTipo = New System.Windows.Forms.GroupBox()
        Me.labelAlmacenajeDiaGracia = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.doubletextboxAlmacenajePorcentajeMensual = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelAlmacenajePorcentajeMensual = New System.Windows.Forms.Label()
        Me.datetimepickerAlmacenajeInicio = New System.Windows.Forms.DateTimePicker()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.roupboxGeneralOpcionales.SuspendLayout()
        Me.groupboxGeneralRequeridos.SuspendLayout()
        CType(Me.updownIndice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageTarifas.SuspendLayout()
        Me.groupboxTarifasVarias.SuspendLayout()
        CType(Me.doubletextboxParitariaImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxZarandeoImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxFumigadoImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxMezcladoImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupboxTarifasSecado.SuspendLayout()
        Me.groupboxTarifasSecadoSecadoTipo.SuspendLayout()
        CType(Me.doubletextboxSecadoInicialPunto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxSecadoInicialImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupboxTarifasSecadoInicial.SuspendLayout()
        CType(Me.doubletextboxTarifasSecadoExcesoImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxTarifasSecadoHumedadBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxTarifasSecadoMargenLibre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.SuspendLayout()
        Me.tabpageAlmacenaje.SuspendLayout()
        Me.groupboxAlmacenajeTipo.SuspendLayout()
        CType(Me.doubletextboxAlmacenajePorcentajeMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(396, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_CLOSE_32
        Me.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCerrar.Name = "buttonCerrar"
        Me.buttonCerrar.Size = New System.Drawing.Size(75, 36)
        Me.buttonCerrar.Text = "Cerrar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_CANCEL_32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_OK_32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(85, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageTarifas)
        Me.tabcontrolMain.Controls.Add(Me.tabpageSecadoEscala)
        Me.tabcontrolMain.Controls.Add(Me.tabpageAlmacenaje)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(372, 338)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabpageGeneral.Controls.Add(Me.roupboxGeneralOpcionales)
        Me.tabpageGeneral.Controls.Add(Me.groupboxGeneralRequeridos)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(364, 309)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'roupboxGeneralOpcionales
        '
        Me.roupboxGeneralOpcionales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.roupboxGeneralOpcionales.Controls.Add(Me.datetimepickerFechaHasta)
        Me.roupboxGeneralOpcionales.Controls.Add(Me.labelFechaHasta)
        Me.roupboxGeneralOpcionales.Controls.Add(Me.datetimepickerFechaDesde)
        Me.roupboxGeneralOpcionales.Controls.Add(Me.labelFechaDesde)
        Me.roupboxGeneralOpcionales.Controls.Add(Me.labelOrigen)
        Me.roupboxGeneralOpcionales.Controls.Add(Me.comboboxOrigen)
        Me.roupboxGeneralOpcionales.Controls.Add(Me.comboboxEntidad)
        Me.roupboxGeneralOpcionales.Controls.Add(Me.labelEntidad)
        Me.roupboxGeneralOpcionales.Controls.Add(Me.comboboxPlanta)
        Me.roupboxGeneralOpcionales.Controls.Add(Me.labelPlanta)
        Me.roupboxGeneralOpcionales.Location = New System.Drawing.Point(6, 139)
        Me.roupboxGeneralOpcionales.Name = "roupboxGeneralOpcionales"
        Me.roupboxGeneralOpcionales.Size = New System.Drawing.Size(350, 158)
        Me.roupboxGeneralOpcionales.TabIndex = 1
        Me.roupboxGeneralOpcionales.TabStop = False
        Me.roupboxGeneralOpcionales.Text = "Opcionales:"
        '
        'datetimepickerFechaHasta
        '
        Me.datetimepickerFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaHasta.Location = New System.Drawing.Point(84, 126)
        Me.datetimepickerFechaHasta.Name = "datetimepickerFechaHasta"
        Me.datetimepickerFechaHasta.ShowCheckBox = True
        Me.datetimepickerFechaHasta.Size = New System.Drawing.Size(132, 20)
        Me.datetimepickerFechaHasta.TabIndex = 9
        '
        'labelFechaHasta
        '
        Me.labelFechaHasta.AutoSize = True
        Me.labelFechaHasta.Location = New System.Drawing.Point(6, 130)
        Me.labelFechaHasta.Name = "labelFechaHasta"
        Me.labelFechaHasta.Size = New System.Drawing.Size(69, 13)
        Me.labelFechaHasta.TabIndex = 8
        Me.labelFechaHasta.Text = "Fecha hasta:"
        '
        'datetimepickerFechaDesde
        '
        Me.datetimepickerFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaDesde.Location = New System.Drawing.Point(84, 100)
        Me.datetimepickerFechaDesde.Name = "datetimepickerFechaDesde"
        Me.datetimepickerFechaDesde.ShowCheckBox = True
        Me.datetimepickerFechaDesde.Size = New System.Drawing.Size(132, 20)
        Me.datetimepickerFechaDesde.TabIndex = 7
        '
        'labelFechaDesde
        '
        Me.labelFechaDesde.AutoSize = True
        Me.labelFechaDesde.Location = New System.Drawing.Point(6, 104)
        Me.labelFechaDesde.Name = "labelFechaDesde"
        Me.labelFechaDesde.Size = New System.Drawing.Size(72, 13)
        Me.labelFechaDesde.TabIndex = 6
        Me.labelFechaDesde.Text = "Fecha desde:"
        '
        'labelOrigen
        '
        Me.labelOrigen.AutoSize = True
        Me.labelOrigen.Location = New System.Drawing.Point(6, 76)
        Me.labelOrigen.Name = "labelOrigen"
        Me.labelOrigen.Size = New System.Drawing.Size(41, 13)
        Me.labelOrigen.TabIndex = 4
        Me.labelOrigen.Text = "Origen:"
        '
        'comboboxOrigen
        '
        Me.comboboxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxOrigen.FormattingEnabled = True
        Me.comboboxOrigen.Location = New System.Drawing.Point(84, 73)
        Me.comboboxOrigen.Name = "comboboxOrigen"
        Me.comboboxOrigen.Size = New System.Drawing.Size(209, 21)
        Me.comboboxOrigen.TabIndex = 5
        '
        'comboboxEntidad
        '
        Me.comboboxEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxEntidad.FormattingEnabled = True
        Me.comboboxEntidad.Location = New System.Drawing.Point(84, 46)
        Me.comboboxEntidad.Name = "comboboxEntidad"
        Me.comboboxEntidad.Size = New System.Drawing.Size(233, 21)
        Me.comboboxEntidad.TabIndex = 3
        '
        'labelEntidad
        '
        Me.labelEntidad.AutoSize = True
        Me.labelEntidad.Location = New System.Drawing.Point(6, 49)
        Me.labelEntidad.Name = "labelEntidad"
        Me.labelEntidad.Size = New System.Drawing.Size(46, 13)
        Me.labelEntidad.TabIndex = 2
        Me.labelEntidad.Text = "Entidad:"
        '
        'comboboxPlanta
        '
        Me.comboboxPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxPlanta.FormattingEnabled = True
        Me.comboboxPlanta.Location = New System.Drawing.Point(84, 19)
        Me.comboboxPlanta.Name = "comboboxPlanta"
        Me.comboboxPlanta.Size = New System.Drawing.Size(233, 21)
        Me.comboboxPlanta.TabIndex = 1
        '
        'labelPlanta
        '
        Me.labelPlanta.AutoSize = True
        Me.labelPlanta.Location = New System.Drawing.Point(6, 22)
        Me.labelPlanta.Name = "labelPlanta"
        Me.labelPlanta.Size = New System.Drawing.Size(40, 13)
        Me.labelPlanta.TabIndex = 0
        Me.labelPlanta.Text = "Planta:"
        '
        'groupboxGeneralRequeridos
        '
        Me.groupboxGeneralRequeridos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupboxGeneralRequeridos.Controls.Add(Me.textboxNombre)
        Me.groupboxGeneralRequeridos.Controls.Add(Me.labelNombre)
        Me.groupboxGeneralRequeridos.Controls.Add(Me.comboboxCosecha)
        Me.groupboxGeneralRequeridos.Controls.Add(Me.updownIndice)
        Me.groupboxGeneralRequeridos.Controls.Add(Me.labelCosecha)
        Me.groupboxGeneralRequeridos.Controls.Add(Me.labelIndice)
        Me.groupboxGeneralRequeridos.Controls.Add(Me.comboboxProducto)
        Me.groupboxGeneralRequeridos.Controls.Add(Me.labelProducto)
        Me.groupboxGeneralRequeridos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupboxGeneralRequeridos.Location = New System.Drawing.Point(6, 6)
        Me.groupboxGeneralRequeridos.Name = "groupboxGeneralRequeridos"
        Me.groupboxGeneralRequeridos.Size = New System.Drawing.Size(350, 127)
        Me.groupboxGeneralRequeridos.TabIndex = 0
        Me.groupboxGeneralRequeridos.TabStop = False
        Me.groupboxGeneralRequeridos.Text = "Requeridos:"
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(84, 99)
        Me.textboxNombre.MaxLength = 50
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(257, 20)
        Me.textboxNombre.TabIndex = 7
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(6, 102)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(47, 13)
        Me.labelNombre.TabIndex = 6
        Me.labelNombre.Text = "Nombre:"
        '
        'comboboxCosecha
        '
        Me.comboboxCosecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCosecha.FormattingEnabled = True
        Me.comboboxCosecha.Location = New System.Drawing.Point(84, 19)
        Me.comboboxCosecha.Name = "comboboxCosecha"
        Me.comboboxCosecha.Size = New System.Drawing.Size(121, 21)
        Me.comboboxCosecha.TabIndex = 1
        '
        'updownIndice
        '
        Me.updownIndice.Location = New System.Drawing.Point(84, 73)
        Me.updownIndice.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updownIndice.Name = "updownIndice"
        Me.updownIndice.Size = New System.Drawing.Size(42, 20)
        Me.updownIndice.TabIndex = 5
        Me.updownIndice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelCosecha
        '
        Me.labelCosecha.AutoSize = True
        Me.labelCosecha.Location = New System.Drawing.Point(6, 22)
        Me.labelCosecha.Name = "labelCosecha"
        Me.labelCosecha.Size = New System.Drawing.Size(52, 13)
        Me.labelCosecha.TabIndex = 0
        Me.labelCosecha.Text = "Cosecha:"
        '
        'labelIndice
        '
        Me.labelIndice.AutoSize = True
        Me.labelIndice.Location = New System.Drawing.Point(6, 75)
        Me.labelIndice.Name = "labelIndice"
        Me.labelIndice.Size = New System.Drawing.Size(39, 13)
        Me.labelIndice.TabIndex = 4
        Me.labelIndice.Text = "Índice:"
        '
        'comboboxProducto
        '
        Me.comboboxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxProducto.FormattingEnabled = True
        Me.comboboxProducto.Location = New System.Drawing.Point(84, 46)
        Me.comboboxProducto.Name = "comboboxProducto"
        Me.comboboxProducto.Size = New System.Drawing.Size(209, 21)
        Me.comboboxProducto.TabIndex = 3
        '
        'labelProducto
        '
        Me.labelProducto.AutoSize = True
        Me.labelProducto.Location = New System.Drawing.Point(6, 49)
        Me.labelProducto.Name = "labelProducto"
        Me.labelProducto.Size = New System.Drawing.Size(53, 13)
        Me.labelProducto.TabIndex = 2
        Me.labelProducto.Text = "Producto:"
        '
        'tabpageSecadoEscala
        '
        Me.tabpageSecadoEscala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabpageSecadoEscala.Location = New System.Drawing.Point(4, 25)
        Me.tabpageSecadoEscala.Name = "tabpageSecadoEscala"
        Me.tabpageSecadoEscala.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageSecadoEscala.Size = New System.Drawing.Size(364, 309)
        Me.tabpageSecadoEscala.TabIndex = 1
        Me.tabpageSecadoEscala.Text = "Escalas de Secado"
        Me.tabpageSecadoEscala.UseVisualStyleBackColor = True
        '
        'tabpageTarifas
        '
        Me.tabpageTarifas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabpageTarifas.Controls.Add(Me.groupboxTarifasSecado)
        Me.tabpageTarifas.Controls.Add(Me.groupboxTarifasVarias)
        Me.tabpageTarifas.Location = New System.Drawing.Point(4, 25)
        Me.tabpageTarifas.Name = "tabpageTarifas"
        Me.tabpageTarifas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageTarifas.Size = New System.Drawing.Size(364, 309)
        Me.tabpageTarifas.TabIndex = 2
        Me.tabpageTarifas.Text = "Tarifas"
        Me.tabpageTarifas.UseVisualStyleBackColor = True
        '
        'groupboxTarifasVarias
        '
        Me.groupboxTarifasVarias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupboxTarifasVarias.Controls.Add(Me.doubletextboxMezcladoImporte)
        Me.groupboxTarifasVarias.Controls.Add(Me.labelMezcladoImporte)
        Me.groupboxTarifasVarias.Controls.Add(Me.doubletextboxFumigadoImporte)
        Me.groupboxTarifasVarias.Controls.Add(Me.labelFumigadoImporte)
        Me.groupboxTarifasVarias.Controls.Add(Me.doubletextboxZarandeoImporte)
        Me.groupboxTarifasVarias.Controls.Add(Me.labelZarandeoImporte)
        Me.groupboxTarifasVarias.Controls.Add(Me.doubletextboxParitariaImporte)
        Me.groupboxTarifasVarias.Controls.Add(Me.labelParitariaImporte)
        Me.groupboxTarifasVarias.Location = New System.Drawing.Point(6, 6)
        Me.groupboxTarifasVarias.Name = "groupboxTarifasVarias"
        Me.groupboxTarifasVarias.Size = New System.Drawing.Size(350, 75)
        Me.groupboxTarifasVarias.TabIndex = 0
        Me.groupboxTarifasVarias.TabStop = False
        Me.groupboxTarifasVarias.Text = "Varias:"
        '
        'labelParitariaImporte
        '
        Me.labelParitariaImporte.AutoSize = True
        Me.labelParitariaImporte.Location = New System.Drawing.Point(6, 22)
        Me.labelParitariaImporte.Name = "labelParitariaImporte"
        Me.labelParitariaImporte.Size = New System.Drawing.Size(86, 13)
        Me.labelParitariaImporte.TabIndex = 0
        Me.labelParitariaImporte.Text = "Importe Paritaria:"
        '
        'doubletextboxParitariaImporte
        '
        Me.doubletextboxParitariaImporte.AllowNull = True
        Me.doubletextboxParitariaImporte.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxParitariaImporte.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.doubletextboxParitariaImporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxParitariaImporte.DoubleValue = 0R
        Me.doubletextboxParitariaImporte.Location = New System.Drawing.Point(106, 19)
        Me.doubletextboxParitariaImporte.MaxValue = 100.0R
        Me.doubletextboxParitariaImporte.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxParitariaImporte.MinValue = 0R
        Me.doubletextboxParitariaImporte.Name = "doubletextboxParitariaImporte"
        Me.doubletextboxParitariaImporte.NullString = ""
        Me.doubletextboxParitariaImporte.NumberDecimalDigits = 1
        Me.doubletextboxParitariaImporte.NumberNegativePattern = 0
        Me.doubletextboxParitariaImporte.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxParitariaImporte.Size = New System.Drawing.Size(39, 20)
        Me.doubletextboxParitariaImporte.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxParitariaImporte.TabIndex = 2
        Me.doubletextboxParitariaImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxParitariaImporte.WordWrap = False
        '
        'doubletextboxZarandeoImporte
        '
        Me.doubletextboxZarandeoImporte.AllowNull = True
        Me.doubletextboxZarandeoImporte.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxZarandeoImporte.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.doubletextboxZarandeoImporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxZarandeoImporte.DoubleValue = 0R
        Me.doubletextboxZarandeoImporte.Location = New System.Drawing.Point(106, 45)
        Me.doubletextboxZarandeoImporte.MaxValue = 40.0R
        Me.doubletextboxZarandeoImporte.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxZarandeoImporte.MinValue = 0R
        Me.doubletextboxZarandeoImporte.Name = "doubletextboxZarandeoImporte"
        Me.doubletextboxZarandeoImporte.NullString = ""
        Me.doubletextboxZarandeoImporte.NumberDecimalDigits = 1
        Me.doubletextboxZarandeoImporte.NumberNegativePattern = 0
        Me.doubletextboxZarandeoImporte.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxZarandeoImporte.Size = New System.Drawing.Size(39, 20)
        Me.doubletextboxZarandeoImporte.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxZarandeoImporte.TabIndex = 4
        Me.doubletextboxZarandeoImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxZarandeoImporte.WordWrap = False
        '
        'labelZarandeoImporte
        '
        Me.labelZarandeoImporte.AutoSize = True
        Me.labelZarandeoImporte.Location = New System.Drawing.Point(6, 48)
        Me.labelZarandeoImporte.Name = "labelZarandeoImporte"
        Me.labelZarandeoImporte.Size = New System.Drawing.Size(94, 13)
        Me.labelZarandeoImporte.TabIndex = 3
        Me.labelZarandeoImporte.Text = "Importe Zarandeo:"
        '
        'doubletextboxFumigadoImporte
        '
        Me.doubletextboxFumigadoImporte.AllowNull = True
        Me.doubletextboxFumigadoImporte.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxFumigadoImporte.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.doubletextboxFumigadoImporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxFumigadoImporte.DoubleValue = 0R
        Me.doubletextboxFumigadoImporte.Location = New System.Drawing.Point(269, 19)
        Me.doubletextboxFumigadoImporte.MaxValue = 40.0R
        Me.doubletextboxFumigadoImporte.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxFumigadoImporte.MinValue = 0R
        Me.doubletextboxFumigadoImporte.Name = "doubletextboxFumigadoImporte"
        Me.doubletextboxFumigadoImporte.NullString = ""
        Me.doubletextboxFumigadoImporte.NumberDecimalDigits = 1
        Me.doubletextboxFumigadoImporte.NumberNegativePattern = 0
        Me.doubletextboxFumigadoImporte.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxFumigadoImporte.Size = New System.Drawing.Size(39, 20)
        Me.doubletextboxFumigadoImporte.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxFumigadoImporte.TabIndex = 6
        Me.doubletextboxFumigadoImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxFumigadoImporte.WordWrap = False
        '
        'labelFumigadoImporte
        '
        Me.labelFumigadoImporte.AutoSize = True
        Me.labelFumigadoImporte.Location = New System.Drawing.Point(169, 22)
        Me.labelFumigadoImporte.Name = "labelFumigadoImporte"
        Me.labelFumigadoImporte.Size = New System.Drawing.Size(94, 13)
        Me.labelFumigadoImporte.TabIndex = 5
        Me.labelFumigadoImporte.Text = "Importe Fumigado:"
        '
        'doubletextboxMezcladoImporte
        '
        Me.doubletextboxMezcladoImporte.AllowNull = True
        Me.doubletextboxMezcladoImporte.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxMezcladoImporte.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.doubletextboxMezcladoImporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxMezcladoImporte.DoubleValue = 0R
        Me.doubletextboxMezcladoImporte.Location = New System.Drawing.Point(269, 45)
        Me.doubletextboxMezcladoImporte.MaxValue = 40.0R
        Me.doubletextboxMezcladoImporte.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxMezcladoImporte.MinValue = 0R
        Me.doubletextboxMezcladoImporte.Name = "doubletextboxMezcladoImporte"
        Me.doubletextboxMezcladoImporte.NullString = ""
        Me.doubletextboxMezcladoImporte.NumberDecimalDigits = 1
        Me.doubletextboxMezcladoImporte.NumberNegativePattern = 0
        Me.doubletextboxMezcladoImporte.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxMezcladoImporte.Size = New System.Drawing.Size(39, 20)
        Me.doubletextboxMezcladoImporte.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxMezcladoImporte.TabIndex = 8
        Me.doubletextboxMezcladoImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxMezcladoImporte.WordWrap = False
        '
        'labelMezcladoImporte
        '
        Me.labelMezcladoImporte.AutoSize = True
        Me.labelMezcladoImporte.Location = New System.Drawing.Point(169, 48)
        Me.labelMezcladoImporte.Name = "labelMezcladoImporte"
        Me.labelMezcladoImporte.Size = New System.Drawing.Size(94, 13)
        Me.labelMezcladoImporte.TabIndex = 7
        Me.labelMezcladoImporte.Text = "Importe Mezclado:"
        '
        'groupboxTarifasSecado
        '
        Me.groupboxTarifasSecado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupboxTarifasSecado.Controls.Add(Me.groupboxTarifasSecadoRedondeoPuntoTipo)
        Me.groupboxTarifasSecado.Controls.Add(Me.doubletextboxTarifasSecadoMargenLibre)
        Me.groupboxTarifasSecado.Controls.Add(Me.labelTarifasSecadoMargenLibre)
        Me.groupboxTarifasSecado.Controls.Add(Me.doubletextboxTarifasSecadoHumedadBase)
        Me.groupboxTarifasSecado.Controls.Add(Me.labelSecadoHumedadBase)
        Me.groupboxTarifasSecado.Controls.Add(Me.labelTarifasSecadoExcesoImporte)
        Me.groupboxTarifasSecado.Controls.Add(Me.doubletextboxTarifasSecadoExcesoImporte)
        Me.groupboxTarifasSecado.Controls.Add(Me.groupboxTarifasSecadoInicial)
        Me.groupboxTarifasSecado.Controls.Add(Me.groupboxTarifasSecadoSecadoTipo)
        Me.groupboxTarifasSecado.Location = New System.Drawing.Point(6, 87)
        Me.groupboxTarifasSecado.Name = "groupboxTarifasSecado"
        Me.groupboxTarifasSecado.Size = New System.Drawing.Size(350, 214)
        Me.groupboxTarifasSecado.TabIndex = 1
        Me.groupboxTarifasSecado.TabStop = False
        Me.groupboxTarifasSecado.Text = "Secado:"
        '
        'radiobuttonSecadoTipoFijo
        '
        Me.radiobuttonSecadoTipoFijo.AutoSize = True
        Me.radiobuttonSecadoTipoFijo.Location = New System.Drawing.Point(7, 20)
        Me.radiobuttonSecadoTipoFijo.Name = "radiobuttonSecadoTipoFijo"
        Me.radiobuttonSecadoTipoFijo.Size = New System.Drawing.Size(41, 17)
        Me.radiobuttonSecadoTipoFijo.TabIndex = 0
        Me.radiobuttonSecadoTipoFijo.TabStop = True
        Me.radiobuttonSecadoTipoFijo.Text = "Fija"
        Me.radiobuttonSecadoTipoFijo.UseVisualStyleBackColor = True
        '
        'radiobuttonSecadoTipoEscala
        '
        Me.radiobuttonSecadoTipoEscala.AutoSize = True
        Me.radiobuttonSecadoTipoEscala.Location = New System.Drawing.Point(54, 20)
        Me.radiobuttonSecadoTipoEscala.Name = "radiobuttonSecadoTipoEscala"
        Me.radiobuttonSecadoTipoEscala.Size = New System.Drawing.Size(57, 17)
        Me.radiobuttonSecadoTipoEscala.TabIndex = 2
        Me.radiobuttonSecadoTipoEscala.TabStop = True
        Me.radiobuttonSecadoTipoEscala.Text = "Escala"
        Me.radiobuttonSecadoTipoEscala.UseVisualStyleBackColor = True
        '
        'groupboxTarifasSecadoSecadoTipo
        '
        Me.groupboxTarifasSecadoSecadoTipo.Controls.Add(Me.radiobuttonSecadoTipoFijo)
        Me.groupboxTarifasSecadoSecadoTipo.Controls.Add(Me.radiobuttonSecadoTipoEscala)
        Me.groupboxTarifasSecadoSecadoTipo.Location = New System.Drawing.Point(6, 19)
        Me.groupboxTarifasSecadoSecadoTipo.Name = "groupboxTarifasSecadoSecadoTipo"
        Me.groupboxTarifasSecadoSecadoTipo.Size = New System.Drawing.Size(119, 46)
        Me.groupboxTarifasSecadoSecadoTipo.TabIndex = 4
        Me.groupboxTarifasSecadoSecadoTipo.TabStop = False
        Me.groupboxTarifasSecadoSecadoTipo.Text = "Tipo de Tarifa:"
        '
        'doubletextboxSecadoInicialPunto
        '
        Me.doubletextboxSecadoInicialPunto.AllowNull = True
        Me.doubletextboxSecadoInicialPunto.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxSecadoInicialPunto.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.doubletextboxSecadoInicialPunto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxSecadoInicialPunto.DoubleValue = 0R
        Me.doubletextboxSecadoInicialPunto.Location = New System.Drawing.Point(50, 19)
        Me.doubletextboxSecadoInicialPunto.MaxValue = 100.0R
        Me.doubletextboxSecadoInicialPunto.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxSecadoInicialPunto.MinValue = 0R
        Me.doubletextboxSecadoInicialPunto.Name = "doubletextboxSecadoInicialPunto"
        Me.doubletextboxSecadoInicialPunto.NullString = ""
        Me.doubletextboxSecadoInicialPunto.NumberDecimalDigits = 1
        Me.doubletextboxSecadoInicialPunto.NumberNegativePattern = 0
        Me.doubletextboxSecadoInicialPunto.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxSecadoInicialPunto.Size = New System.Drawing.Size(39, 20)
        Me.doubletextboxSecadoInicialPunto.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxSecadoInicialPunto.TabIndex = 6
        Me.doubletextboxSecadoInicialPunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxSecadoInicialPunto.WordWrap = False
        '
        'labelSecadoInicialPunto
        '
        Me.labelSecadoInicialPunto.AutoSize = True
        Me.labelSecadoInicialPunto.Location = New System.Drawing.Point(6, 22)
        Me.labelSecadoInicialPunto.Name = "labelSecadoInicialPunto"
        Me.labelSecadoInicialPunto.Size = New System.Drawing.Size(38, 13)
        Me.labelSecadoInicialPunto.TabIndex = 5
        Me.labelSecadoInicialPunto.Text = "Punto:"
        '
        'doubletextboxSecadoInicialImporte
        '
        Me.doubletextboxSecadoInicialImporte.AllowNull = True
        Me.doubletextboxSecadoInicialImporte.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxSecadoInicialImporte.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.doubletextboxSecadoInicialImporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxSecadoInicialImporte.DoubleValue = 0R
        Me.doubletextboxSecadoInicialImporte.Location = New System.Drawing.Point(168, 19)
        Me.doubletextboxSecadoInicialImporte.MaxValue = 100.0R
        Me.doubletextboxSecadoInicialImporte.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxSecadoInicialImporte.MinValue = 0R
        Me.doubletextboxSecadoInicialImporte.Name = "doubletextboxSecadoInicialImporte"
        Me.doubletextboxSecadoInicialImporte.NullString = ""
        Me.doubletextboxSecadoInicialImporte.NumberDecimalDigits = 1
        Me.doubletextboxSecadoInicialImporte.NumberNegativePattern = 0
        Me.doubletextboxSecadoInicialImporte.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxSecadoInicialImporte.Size = New System.Drawing.Size(39, 20)
        Me.doubletextboxSecadoInicialImporte.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxSecadoInicialImporte.TabIndex = 8
        Me.doubletextboxSecadoInicialImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxSecadoInicialImporte.WordWrap = False
        '
        'labelSecadoInicialImporte
        '
        Me.labelSecadoInicialImporte.AutoSize = True
        Me.labelSecadoInicialImporte.Location = New System.Drawing.Point(109, 22)
        Me.labelSecadoInicialImporte.Name = "labelSecadoInicialImporte"
        Me.labelSecadoInicialImporte.Size = New System.Drawing.Size(45, 13)
        Me.labelSecadoInicialImporte.TabIndex = 7
        Me.labelSecadoInicialImporte.Text = "Importe:"
        '
        'groupboxTarifasSecadoInicial
        '
        Me.groupboxTarifasSecadoInicial.Controls.Add(Me.doubletextboxSecadoInicialPunto)
        Me.groupboxTarifasSecadoInicial.Controls.Add(Me.labelSecadoInicialImporte)
        Me.groupboxTarifasSecadoInicial.Controls.Add(Me.doubletextboxSecadoInicialImporte)
        Me.groupboxTarifasSecadoInicial.Controls.Add(Me.labelSecadoInicialPunto)
        Me.groupboxTarifasSecadoInicial.Location = New System.Drawing.Point(131, 19)
        Me.groupboxTarifasSecadoInicial.Name = "groupboxTarifasSecadoInicial"
        Me.groupboxTarifasSecadoInicial.Size = New System.Drawing.Size(213, 46)
        Me.groupboxTarifasSecadoInicial.TabIndex = 9
        Me.groupboxTarifasSecadoInicial.TabStop = False
        Me.groupboxTarifasSecadoInicial.Text = "Inicial:"
        '
        'labelTarifasSecadoExcesoImporte
        '
        Me.labelTarifasSecadoExcesoImporte.AutoSize = True
        Me.labelTarifasSecadoExcesoImporte.Location = New System.Drawing.Point(6, 76)
        Me.labelTarifasSecadoExcesoImporte.Name = "labelTarifasSecadoExcesoImporte"
        Me.labelTarifasSecadoExcesoImporte.Size = New System.Drawing.Size(145, 13)
        Me.labelTarifasSecadoExcesoImporte.TabIndex = 10
        Me.labelTarifasSecadoExcesoImporte.Text = "Importe por punto de exceso:"
        '
        'doubletextboxTarifasSecadoExcesoImporte
        '
        Me.doubletextboxTarifasSecadoExcesoImporte.AllowNull = True
        Me.doubletextboxTarifasSecadoExcesoImporte.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxTarifasSecadoExcesoImporte.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.doubletextboxTarifasSecadoExcesoImporte.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxTarifasSecadoExcesoImporte.DoubleValue = 0R
        Me.doubletextboxTarifasSecadoExcesoImporte.Location = New System.Drawing.Point(160, 72)
        Me.doubletextboxTarifasSecadoExcesoImporte.MaxValue = 100.0R
        Me.doubletextboxTarifasSecadoExcesoImporte.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxTarifasSecadoExcesoImporte.MinValue = 0R
        Me.doubletextboxTarifasSecadoExcesoImporte.Name = "doubletextboxTarifasSecadoExcesoImporte"
        Me.doubletextboxTarifasSecadoExcesoImporte.NullString = ""
        Me.doubletextboxTarifasSecadoExcesoImporte.NumberDecimalDigits = 1
        Me.doubletextboxTarifasSecadoExcesoImporte.NumberNegativePattern = 0
        Me.doubletextboxTarifasSecadoExcesoImporte.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxTarifasSecadoExcesoImporte.Size = New System.Drawing.Size(39, 20)
        Me.doubletextboxTarifasSecadoExcesoImporte.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxTarifasSecadoExcesoImporte.TabIndex = 11
        Me.doubletextboxTarifasSecadoExcesoImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxTarifasSecadoExcesoImporte.WordWrap = False
        '
        'doubletextboxTarifasSecadoHumedadBase
        '
        Me.doubletextboxTarifasSecadoHumedadBase.AllowNull = True
        Me.doubletextboxTarifasSecadoHumedadBase.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxTarifasSecadoHumedadBase.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.doubletextboxTarifasSecadoHumedadBase.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxTarifasSecadoHumedadBase.DoubleValue = 0R
        Me.doubletextboxTarifasSecadoHumedadBase.Location = New System.Drawing.Point(160, 98)
        Me.doubletextboxTarifasSecadoHumedadBase.MaxValue = 40.0R
        Me.doubletextboxTarifasSecadoHumedadBase.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxTarifasSecadoHumedadBase.MinValue = 0R
        Me.doubletextboxTarifasSecadoHumedadBase.Name = "doubletextboxTarifasSecadoHumedadBase"
        Me.doubletextboxTarifasSecadoHumedadBase.NullString = ""
        Me.doubletextboxTarifasSecadoHumedadBase.NumberDecimalDigits = 1
        Me.doubletextboxTarifasSecadoHumedadBase.NumberNegativePattern = 0
        Me.doubletextboxTarifasSecadoHumedadBase.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxTarifasSecadoHumedadBase.Size = New System.Drawing.Size(39, 20)
        Me.doubletextboxTarifasSecadoHumedadBase.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxTarifasSecadoHumedadBase.TabIndex = 13
        Me.doubletextboxTarifasSecadoHumedadBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxTarifasSecadoHumedadBase.WordWrap = False
        '
        'labelSecadoHumedadBase
        '
        Me.labelSecadoHumedadBase.AutoSize = True
        Me.labelSecadoHumedadBase.Location = New System.Drawing.Point(6, 102)
        Me.labelSecadoHumedadBase.Name = "labelSecadoHumedadBase"
        Me.labelSecadoHumedadBase.Size = New System.Drawing.Size(83, 13)
        Me.labelSecadoHumedadBase.TabIndex = 12
        Me.labelSecadoHumedadBase.Text = "Humedad Base:"
        '
        'doubletextboxTarifasSecadoMargenLibre
        '
        Me.doubletextboxTarifasSecadoMargenLibre.AllowNull = True
        Me.doubletextboxTarifasSecadoMargenLibre.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxTarifasSecadoMargenLibre.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.doubletextboxTarifasSecadoMargenLibre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxTarifasSecadoMargenLibre.DoubleValue = 0R
        Me.doubletextboxTarifasSecadoMargenLibre.Location = New System.Drawing.Point(160, 124)
        Me.doubletextboxTarifasSecadoMargenLibre.MaxValue = 40.0R
        Me.doubletextboxTarifasSecadoMargenLibre.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxTarifasSecadoMargenLibre.MinValue = 0R
        Me.doubletextboxTarifasSecadoMargenLibre.Name = "doubletextboxTarifasSecadoMargenLibre"
        Me.doubletextboxTarifasSecadoMargenLibre.NullString = ""
        Me.doubletextboxTarifasSecadoMargenLibre.NumberDecimalDigits = 1
        Me.doubletextboxTarifasSecadoMargenLibre.NumberNegativePattern = 0
        Me.doubletextboxTarifasSecadoMargenLibre.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxTarifasSecadoMargenLibre.Size = New System.Drawing.Size(39, 20)
        Me.doubletextboxTarifasSecadoMargenLibre.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxTarifasSecadoMargenLibre.TabIndex = 15
        Me.doubletextboxTarifasSecadoMargenLibre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxTarifasSecadoMargenLibre.WordWrap = False
        '
        'labelTarifasSecadoMargenLibre
        '
        Me.labelTarifasSecadoMargenLibre.AutoSize = True
        Me.labelTarifasSecadoMargenLibre.Location = New System.Drawing.Point(6, 128)
        Me.labelTarifasSecadoMargenLibre.Name = "labelTarifasSecadoMargenLibre"
        Me.labelTarifasSecadoMargenLibre.Size = New System.Drawing.Size(72, 13)
        Me.labelTarifasSecadoMargenLibre.TabIndex = 14
        Me.labelTarifasSecadoMargenLibre.Text = "Margen Libre:"
        '
        'groupboxTarifasSecadoRedondeoPuntoTipo
        '
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.Controls.Add(Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior)
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.Controls.Add(Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior)
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.Controls.Add(Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero)
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.Controls.Add(Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno)
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.Location = New System.Drawing.Point(6, 150)
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.Name = "groupboxTarifasSecadoRedondeoPuntoTipo"
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.Size = New System.Drawing.Size(332, 44)
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.TabIndex = 17
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.TabStop = False
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.Text = "Tipo de redondeo por punto:"
        '
        'radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno
        '
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.AutoSize = True
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.Location = New System.Drawing.Point(7, 19)
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.Name = "radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno"
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.Size = New System.Drawing.Size(65, 17)
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.TabIndex = 1
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.TabStop = True
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.Text = "Ninguno"
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.UseVisualStyleBackColor = True
        '
        'radiobuttonTarifasSecadoRedondeoPuntoTipoEntero
        '
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.AutoSize = True
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.Location = New System.Drawing.Point(80, 19)
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.Name = "radiobuttonTarifasSecadoRedondeoPuntoTipoEntero"
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.Size = New System.Drawing.Size(56, 17)
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.TabIndex = 2
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.TabStop = True
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.Text = "Entero"
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.UseVisualStyleBackColor = True
        '
        'radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior
        '
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.AutoSize = True
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.Location = New System.Drawing.Point(142, 19)
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.Name = "radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior"
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.Size = New System.Drawing.Size(64, 17)
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.TabIndex = 3
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.TabStop = True
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.Text = "Superior"
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.UseVisualStyleBackColor = True
        '
        'radiobuttonTarifasSecadoRedondeoPuntoTipoInferior
        '
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.AutoSize = True
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.Location = New System.Drawing.Point(212, 19)
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.Name = "radiobuttonTarifasSecadoRedondeoPuntoTipoInferior"
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.Size = New System.Drawing.Size(57, 17)
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.TabIndex = 4
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.TabStop = True
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.Text = "Inferior"
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.UseVisualStyleBackColor = True
        '
        'tabpageAlmacenaje
        '
        Me.tabpageAlmacenaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabpageAlmacenaje.Controls.Add(Me.datetimepickerAlmacenajeInicio)
        Me.tabpageAlmacenaje.Controls.Add(Me.doubletextboxAlmacenajePorcentajeMensual)
        Me.tabpageAlmacenaje.Controls.Add(Me.labelAlmacenajePorcentajeMensual)
        Me.tabpageAlmacenaje.Controls.Add(Me.Label2)
        Me.tabpageAlmacenaje.Controls.Add(Me.labelAlmacenajeDiaGracia)
        Me.tabpageAlmacenaje.Controls.Add(Me.groupboxAlmacenajeTipo)
        Me.tabpageAlmacenaje.Location = New System.Drawing.Point(4, 25)
        Me.tabpageAlmacenaje.Name = "tabpageAlmacenaje"
        Me.tabpageAlmacenaje.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAlmacenaje.Size = New System.Drawing.Size(364, 309)
        Me.tabpageAlmacenaje.TabIndex = 3
        Me.tabpageAlmacenaje.Text = "Almacenaje"
        Me.tabpageAlmacenaje.UseVisualStyleBackColor = True
        '
        'radiobuttonAlmacenajeTipoDiasGraciaFijo
        '
        Me.radiobuttonAlmacenajeTipoDiasGraciaFijo.AutoSize = True
        Me.radiobuttonAlmacenajeTipoDiasGraciaFijo.Location = New System.Drawing.Point(6, 19)
        Me.radiobuttonAlmacenajeTipoDiasGraciaFijo.Name = "radiobuttonAlmacenajeTipoDiasGraciaFijo"
        Me.radiobuttonAlmacenajeTipoDiasGraciaFijo.Size = New System.Drawing.Size(116, 17)
        Me.radiobuttonAlmacenajeTipoDiasGraciaFijo.TabIndex = 0
        Me.radiobuttonAlmacenajeTipoDiasGraciaFijo.TabStop = True
        Me.radiobuttonAlmacenajeTipoDiasGraciaFijo.Text = "Días de gracia fijos"
        Me.radiobuttonAlmacenajeTipoDiasGraciaFijo.UseVisualStyleBackColor = True
        '
        'radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes
        '
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.AutoSize = True
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.Location = New System.Drawing.Point(128, 19)
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.Name = "radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes"
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.Size = New System.Drawing.Size(160, 17)
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.TabIndex = 2
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.TabStop = True
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.Text = "Días de gracia si retira antes"
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.UseVisualStyleBackColor = True
        '
        'radiobuttonAlmacenajeTipoFechaFija
        '
        Me.radiobuttonAlmacenajeTipoFechaFija.AutoSize = True
        Me.radiobuttonAlmacenajeTipoFechaFija.Location = New System.Drawing.Point(6, 42)
        Me.radiobuttonAlmacenajeTipoFechaFija.Name = "radiobuttonAlmacenajeTipoFechaFija"
        Me.radiobuttonAlmacenajeTipoFechaFija.Size = New System.Drawing.Size(71, 17)
        Me.radiobuttonAlmacenajeTipoFechaFija.TabIndex = 3
        Me.radiobuttonAlmacenajeTipoFechaFija.TabStop = True
        Me.radiobuttonAlmacenajeTipoFechaFija.Text = "Fecha fija"
        Me.radiobuttonAlmacenajeTipoFechaFija.UseVisualStyleBackColor = True
        '
        'groupboxAlmacenajeTipo
        '
        Me.groupboxAlmacenajeTipo.Controls.Add(Me.radiobuttonAlmacenajeTipoDiasGraciaFijo)
        Me.groupboxAlmacenajeTipo.Controls.Add(Me.radiobuttonAlmacenajeTipoFechaFija)
        Me.groupboxAlmacenajeTipo.Controls.Add(Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes)
        Me.groupboxAlmacenajeTipo.Location = New System.Drawing.Point(6, 6)
        Me.groupboxAlmacenajeTipo.Name = "groupboxAlmacenajeTipo"
        Me.groupboxAlmacenajeTipo.Size = New System.Drawing.Size(352, 69)
        Me.groupboxAlmacenajeTipo.TabIndex = 4
        Me.groupboxAlmacenajeTipo.TabStop = False
        Me.groupboxAlmacenajeTipo.Text = "Tipo:"
        '
        'labelAlmacenajeDiaGracia
        '
        Me.labelAlmacenajeDiaGracia.AutoSize = True
        Me.labelAlmacenajeDiaGracia.Location = New System.Drawing.Point(13, 84)
        Me.labelAlmacenajeDiaGracia.Name = "labelAlmacenajeDiaGracia"
        Me.labelAlmacenajeDiaGracia.Size = New System.Drawing.Size(80, 13)
        Me.labelAlmacenajeDiaGracia.TabIndex = 5
        Me.labelAlmacenajeDiaGracia.Text = "Días de gracia:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Inicio:"
        '
        'doubletextboxAlmacenajePorcentajeMensual
        '
        Me.doubletextboxAlmacenajePorcentajeMensual.AllowNull = True
        Me.doubletextboxAlmacenajePorcentajeMensual.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxAlmacenajePorcentajeMensual.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.doubletextboxAlmacenajePorcentajeMensual.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxAlmacenajePorcentajeMensual.DoubleValue = 0R
        Me.doubletextboxAlmacenajePorcentajeMensual.Location = New System.Drawing.Point(122, 155)
        Me.doubletextboxAlmacenajePorcentajeMensual.MaxValue = 100.0R
        Me.doubletextboxAlmacenajePorcentajeMensual.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxAlmacenajePorcentajeMensual.MinValue = 0R
        Me.doubletextboxAlmacenajePorcentajeMensual.Name = "doubletextboxAlmacenajePorcentajeMensual"
        Me.doubletextboxAlmacenajePorcentajeMensual.NullString = ""
        Me.doubletextboxAlmacenajePorcentajeMensual.NumberDecimalDigits = 1
        Me.doubletextboxAlmacenajePorcentajeMensual.NumberNegativePattern = 0
        Me.doubletextboxAlmacenajePorcentajeMensual.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxAlmacenajePorcentajeMensual.Size = New System.Drawing.Size(39, 20)
        Me.doubletextboxAlmacenajePorcentajeMensual.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxAlmacenajePorcentajeMensual.TabIndex = 9
        Me.doubletextboxAlmacenajePorcentajeMensual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxAlmacenajePorcentajeMensual.WordWrap = False
        '
        'labelAlmacenajePorcentajeMensual
        '
        Me.labelAlmacenajePorcentajeMensual.AutoSize = True
        Me.labelAlmacenajePorcentajeMensual.Location = New System.Drawing.Point(13, 160)
        Me.labelAlmacenajePorcentajeMensual.Name = "labelAlmacenajePorcentajeMensual"
        Me.labelAlmacenajePorcentajeMensual.Size = New System.Drawing.Size(103, 13)
        Me.labelAlmacenajePorcentajeMensual.TabIndex = 8
        Me.labelAlmacenajePorcentajeMensual.Text = "Porcentaje mensual:"
        '
        'datetimepickerAlmacenajeInicio
        '
        Me.datetimepickerAlmacenajeInicio.Checked = False
        Me.datetimepickerAlmacenajeInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerAlmacenajeInicio.Location = New System.Drawing.Point(122, 123)
        Me.datetimepickerAlmacenajeInicio.Name = "datetimepickerAlmacenajeInicio"
        Me.datetimepickerAlmacenajeInicio.ShowCheckBox = True
        Me.datetimepickerAlmacenajeInicio.Size = New System.Drawing.Size(123, 20)
        Me.datetimepickerAlmacenajeInicio.TabIndex = 10
        '
        'formTarifa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 392)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "formTarifa"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle de la Tarifa"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.roupboxGeneralOpcionales.ResumeLayout(False)
        Me.roupboxGeneralOpcionales.PerformLayout()
        Me.groupboxGeneralRequeridos.ResumeLayout(False)
        Me.groupboxGeneralRequeridos.PerformLayout()
        CType(Me.updownIndice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpageTarifas.ResumeLayout(False)
        Me.groupboxTarifasVarias.ResumeLayout(False)
        Me.groupboxTarifasVarias.PerformLayout()
        CType(Me.doubletextboxParitariaImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxZarandeoImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxFumigadoImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxMezcladoImporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupboxTarifasSecado.ResumeLayout(False)
        Me.groupboxTarifasSecado.PerformLayout()
        Me.groupboxTarifasSecadoSecadoTipo.ResumeLayout(False)
        Me.groupboxTarifasSecadoSecadoTipo.PerformLayout()
        CType(Me.doubletextboxSecadoInicialPunto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxSecadoInicialImporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupboxTarifasSecadoInicial.ResumeLayout(False)
        Me.groupboxTarifasSecadoInicial.PerformLayout()
        CType(Me.doubletextboxTarifasSecadoExcesoImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxTarifasSecadoHumedadBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxTarifasSecadoMargenLibre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.ResumeLayout(False)
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.PerformLayout()
        Me.tabpageAlmacenaje.ResumeLayout(False)
        Me.tabpageAlmacenaje.PerformLayout()
        Me.groupboxAlmacenajeTipo.ResumeLayout(False)
        Me.groupboxAlmacenajeTipo.PerformLayout()
        CType(Me.doubletextboxAlmacenajePorcentajeMensual, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents toolstripMain As ToolStrip
    Friend WithEvents buttonCerrar As ToolStripButton
    Friend WithEvents buttonEditar As ToolStripButton
    Friend WithEvents buttonCancelar As ToolStripButton
    Friend WithEvents buttonGuardar As ToolStripButton
    Friend WithEvents tabcontrolMain As CS_Control_TabControl
    Friend WithEvents tabpageGeneral As TabPage
    Friend WithEvents tabpageSecadoEscala As TabPage
    Friend WithEvents comboboxCosecha As ComboBox
    Friend WithEvents labelCosecha As Label
    Friend WithEvents labelProducto As Label
    Friend WithEvents comboboxProducto As ComboBox
    Friend WithEvents labelIndice As Label
    Friend WithEvents updownIndice As NumericUpDown
    Friend WithEvents groupboxGeneralRequeridos As GroupBox
    Friend WithEvents roupboxGeneralOpcionales As GroupBox
    Friend WithEvents comboboxPlanta As ComboBox
    Friend WithEvents labelPlanta As Label
    Friend WithEvents comboboxEntidad As ComboBox
    Friend WithEvents labelEntidad As Label
    Friend WithEvents labelOrigen As Label
    Friend WithEvents comboboxOrigen As ComboBox
    Friend WithEvents textboxNombre As TextBox
    Friend WithEvents labelNombre As Label
    Friend WithEvents datetimepickerFechaDesde As DateTimePicker
    Friend WithEvents labelFechaDesde As Label
    Friend WithEvents datetimepickerFechaHasta As DateTimePicker
    Friend WithEvents labelFechaHasta As Label
    Friend WithEvents tabpageTarifas As TabPage
    Friend WithEvents groupboxTarifasVarias As GroupBox
    Friend WithEvents labelParitariaImporte As Label
    Friend WithEvents doubletextboxParitariaImporte As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents doubletextboxMezcladoImporte As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelMezcladoImporte As Label
    Friend WithEvents doubletextboxFumigadoImporte As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelFumigadoImporte As Label
    Friend WithEvents doubletextboxZarandeoImporte As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelZarandeoImporte As Label
    Friend WithEvents groupboxTarifasSecado As GroupBox
    Friend WithEvents radiobuttonSecadoTipoEscala As RadioButton
    Friend WithEvents radiobuttonSecadoTipoFijo As RadioButton
    Friend WithEvents groupboxTarifasSecadoSecadoTipo As GroupBox
    Friend WithEvents doubletextboxSecadoInicialPunto As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelSecadoInicialPunto As Label
    Friend WithEvents doubletextboxSecadoInicialImporte As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelSecadoInicialImporte As Label
    Friend WithEvents groupboxTarifasSecadoInicial As GroupBox
    Friend WithEvents doubletextboxTarifasSecadoHumedadBase As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelSecadoHumedadBase As Label
    Friend WithEvents labelTarifasSecadoExcesoImporte As Label
    Friend WithEvents doubletextboxTarifasSecadoExcesoImporte As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents doubletextboxTarifasSecadoMargenLibre As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelTarifasSecadoMargenLibre As Label
    Friend WithEvents groupboxTarifasSecadoRedondeoPuntoTipo As GroupBox
    Friend WithEvents radiobuttonTarifasSecadoRedondeoPuntoTipoInferior As RadioButton
    Friend WithEvents radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior As RadioButton
    Friend WithEvents radiobuttonTarifasSecadoRedondeoPuntoTipoEntero As RadioButton
    Friend WithEvents radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno As RadioButton
    Friend WithEvents tabpageAlmacenaje As TabPage
    Friend WithEvents radiobuttonAlmacenajeTipoDiasGraciaFijo As RadioButton
    Friend WithEvents radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes As RadioButton
    Friend WithEvents radiobuttonAlmacenajeTipoFechaFija As RadioButton
    Friend WithEvents groupboxAlmacenajeTipo As GroupBox
    Friend WithEvents doubletextboxAlmacenajePorcentajeMensual As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelAlmacenajePorcentajeMensual As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents labelAlmacenajeDiaGracia As Label
    Friend WithEvents datetimepickerAlmacenajeInicio As DateTimePicker
End Class
