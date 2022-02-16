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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tabcontrolMain = New CardonerSistemas.TabControl()
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
        Me.buttonIndiceObtener = New System.Windows.Forms.Button()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.comboboxCosecha = New System.Windows.Forms.ComboBox()
        Me.updownIndice = New System.Windows.Forms.NumericUpDown()
        Me.labelCosecha = New System.Windows.Forms.Label()
        Me.labelIndice = New System.Windows.Forms.Label()
        Me.comboboxProducto = New System.Windows.Forms.ComboBox()
        Me.labelProducto = New System.Windows.Forms.Label()
        Me.tabpageTarifas = New System.Windows.Forms.TabPage()
        Me.groupboxTarifasSecado = New System.Windows.Forms.GroupBox()
        Me.currencytextboxTarifaSecadoPuntoExcesoImporte = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.groupboxTarifasSecadoRedondeoPuntoTipo = New System.Windows.Forms.GroupBox()
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior = New System.Windows.Forms.RadioButton()
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior = New System.Windows.Forms.RadioButton()
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero = New System.Windows.Forms.RadioButton()
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno = New System.Windows.Forms.RadioButton()
        Me.doubletextboxTarifaSecadoMargenLibre = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelTarifaSecadoMargenLibre = New System.Windows.Forms.Label()
        Me.doubletextboxTarifaSecadoHumedadBase = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelTarifaSecadoHumedadBase = New System.Windows.Forms.Label()
        Me.labelTarifaSecadoPuntoExcesoImporte = New System.Windows.Forms.Label()
        Me.groupboxTarifasSecadoInicial = New System.Windows.Forms.GroupBox()
        Me.currencytextboxTarifaSecadoInicialImporte = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.doubletextboxTarifaSecadoInicialPunto = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelTarifaSecadoInicialImporte = New System.Windows.Forms.Label()
        Me.labelTarifaSecadoInicialPunto = New System.Windows.Forms.Label()
        Me.groupboxTarifasSecadoSecadoTipo = New System.Windows.Forms.GroupBox()
        Me.radiobuttonSecadoTipoFijo = New System.Windows.Forms.RadioButton()
        Me.radiobuttonSecadoTipoEscala = New System.Windows.Forms.RadioButton()
        Me.groupboxTarifasVarias = New System.Windows.Forms.GroupBox()
        Me.currencytextboxTarifaMezcladoImporte = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.currencytextboxTarifaFumigadoImporte = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.currencytextboxTarifaZarandeo = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.currencytextboxTarifaParitariaImporte = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.labelTarifaMezcladoImporte = New System.Windows.Forms.Label()
        Me.labelTarifaFumigadoImporte = New System.Windows.Forms.Label()
        Me.labelTarifaZarandeoImporte = New System.Windows.Forms.Label()
        Me.labelTarifaParitariaImporte = New System.Windows.Forms.Label()
        Me.tabpageAlmacenaje = New System.Windows.Forms.TabPage()
        Me.percenttextboxAlmacenajePorcentajeMensual = New Syncfusion.Windows.Forms.Tools.PercentTextBox()
        Me.integertextboxAlmacenajeDiaGracia = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.datetimepickerAlmacenajeInicio = New System.Windows.Forms.DateTimePicker()
        Me.labelAlmacenajePorcentajeMensual = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelAlmacenajeDiaGracia = New System.Windows.Forms.Label()
        Me.groupboxAlmacenajeTipo = New System.Windows.Forms.GroupBox()
        Me.radiobuttonAlmacenajeTipoDiasGraciaFijo = New System.Windows.Forms.RadioButton()
        Me.radiobuttonAlmacenajeTipoFechaFija = New System.Windows.Forms.RadioButton()
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes = New System.Windows.Forms.RadioButton()
        Me.tabpageSecadoEscala = New System.Windows.Forms.TabPage()
        Me.datagridviewTarifaSecadoEscala = New System.Windows.Forms.DataGridView()
        Me.columnHumedadExcesoInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnTarifa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripEscala = New System.Windows.Forms.ToolStrip()
        Me.buttonEscala_Agregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEscala_Editar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEscala_Eliminar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.roupboxGeneralOpcionales.SuspendLayout()
        Me.groupboxGeneralRequeridos.SuspendLayout()
        CType(Me.updownIndice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageTarifas.SuspendLayout()
        Me.groupboxTarifasSecado.SuspendLayout()
        CType(Me.currencytextboxTarifaSecadoPuntoExcesoImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.SuspendLayout()
        CType(Me.doubletextboxTarifaSecadoMargenLibre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxTarifaSecadoHumedadBase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupboxTarifasSecadoInicial.SuspendLayout()
        CType(Me.currencytextboxTarifaSecadoInicialImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxTarifaSecadoInicialPunto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupboxTarifasSecadoSecadoTipo.SuspendLayout()
        Me.groupboxTarifasVarias.SuspendLayout()
        CType(Me.currencytextboxTarifaMezcladoImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currencytextboxTarifaFumigadoImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currencytextboxTarifaZarandeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currencytextboxTarifaParitariaImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageAlmacenaje.SuspendLayout()
        CType(Me.percenttextboxAlmacenajePorcentajeMensual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.integertextboxAlmacenajeDiaGracia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupboxAlmacenajeTipo.SuspendLayout()
        Me.tabpageSecadoEscala.SuspendLayout()
        CType(Me.datagridviewTarifaSecadoEscala, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripEscala.SuspendLayout()
        Me.SuspendLayout()
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(412, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.My.Resources.Resources.IMAGE_CLOSE_32
        Me.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCerrar.Name = "buttonCerrar"
        Me.buttonCerrar.Size = New System.Drawing.Size(75, 36)
        Me.buttonCerrar.Text = "Cerrar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = Global.My.Resources.Resources.ImageCancelar32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = Global.My.Resources.Resources.ImageAceptar32
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
        Me.tabcontrolMain.Controls.Add(Me.tabpageAlmacenaje)
        Me.tabcontrolMain.Controls.Add(Me.tabpageSecadoEscala)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(388, 338)
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
        Me.tabpageGeneral.Size = New System.Drawing.Size(380, 309)
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
        Me.roupboxGeneralOpcionales.Size = New System.Drawing.Size(366, 158)
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
        Me.groupboxGeneralRequeridos.Controls.Add(Me.buttonIndiceObtener)
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
        Me.groupboxGeneralRequeridos.Size = New System.Drawing.Size(366, 127)
        Me.groupboxGeneralRequeridos.TabIndex = 0
        Me.groupboxGeneralRequeridos.TabStop = False
        Me.groupboxGeneralRequeridos.Text = "Requeridos:"
        '
        'buttonIndiceObtener
        '
        Me.buttonIndiceObtener.Location = New System.Drawing.Point(144, 72)
        Me.buttonIndiceObtener.Name = "buttonIndiceObtener"
        Me.buttonIndiceObtener.Size = New System.Drawing.Size(64, 22)
        Me.buttonIndiceObtener.TabIndex = 6
        Me.buttonIndiceObtener.Text = "Obtener"
        Me.buttonIndiceObtener.UseVisualStyleBackColor = True
        '
        'textboxNombre
        '
        Me.textboxNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxNombre.Location = New System.Drawing.Point(84, 99)
        Me.textboxNombre.MaxLength = 50
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(276, 20)
        Me.textboxNombre.TabIndex = 8
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(6, 102)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(47, 13)
        Me.labelNombre.TabIndex = 7
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
        Me.updownIndice.ReadOnly = True
        Me.updownIndice.Size = New System.Drawing.Size(54, 20)
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
        'tabpageTarifas
        '
        Me.tabpageTarifas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabpageTarifas.Controls.Add(Me.groupboxTarifasSecado)
        Me.tabpageTarifas.Controls.Add(Me.groupboxTarifasVarias)
        Me.tabpageTarifas.Location = New System.Drawing.Point(4, 25)
        Me.tabpageTarifas.Name = "tabpageTarifas"
        Me.tabpageTarifas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageTarifas.Size = New System.Drawing.Size(380, 309)
        Me.tabpageTarifas.TabIndex = 2
        Me.tabpageTarifas.Text = "Tarifas"
        Me.tabpageTarifas.UseVisualStyleBackColor = True
        '
        'groupboxTarifasSecado
        '
        Me.groupboxTarifasSecado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupboxTarifasSecado.Controls.Add(Me.currencytextboxTarifaSecadoPuntoExcesoImporte)
        Me.groupboxTarifasSecado.Controls.Add(Me.groupboxTarifasSecadoRedondeoPuntoTipo)
        Me.groupboxTarifasSecado.Controls.Add(Me.doubletextboxTarifaSecadoMargenLibre)
        Me.groupboxTarifasSecado.Controls.Add(Me.labelTarifaSecadoMargenLibre)
        Me.groupboxTarifasSecado.Controls.Add(Me.doubletextboxTarifaSecadoHumedadBase)
        Me.groupboxTarifasSecado.Controls.Add(Me.labelTarifaSecadoHumedadBase)
        Me.groupboxTarifasSecado.Controls.Add(Me.labelTarifaSecadoPuntoExcesoImporte)
        Me.groupboxTarifasSecado.Controls.Add(Me.groupboxTarifasSecadoInicial)
        Me.groupboxTarifasSecado.Controls.Add(Me.groupboxTarifasSecadoSecadoTipo)
        Me.groupboxTarifasSecado.Location = New System.Drawing.Point(6, 87)
        Me.groupboxTarifasSecado.Name = "groupboxTarifasSecado"
        Me.groupboxTarifasSecado.Size = New System.Drawing.Size(366, 214)
        Me.groupboxTarifasSecado.TabIndex = 1
        Me.groupboxTarifasSecado.TabStop = False
        Me.groupboxTarifasSecado.Text = "Secado:"
        '
        'currencytextboxTarifaSecadoPuntoExcesoImporte
        '
        Me.currencytextboxTarifaSecadoPuntoExcesoImporte.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.currencytextboxTarifaSecadoPuntoExcesoImporte.CurrencyDecimalDigits = 3
        Me.currencytextboxTarifaSecadoPuntoExcesoImporte.CurrentCultureRefresh = True
        Me.currencytextboxTarifaSecadoPuntoExcesoImporte.DecimalValue = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.currencytextboxTarifaSecadoPuntoExcesoImporte.Location = New System.Drawing.Point(160, 71)
        Me.currencytextboxTarifaSecadoPuntoExcesoImporte.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 196608})
        Me.currencytextboxTarifaSecadoPuntoExcesoImporte.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxTarifaSecadoPuntoExcesoImporte.Name = "currencytextboxTarifaSecadoPuntoExcesoImporte"
        Me.currencytextboxTarifaSecadoPuntoExcesoImporte.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.KeepFocus
        Me.currencytextboxTarifaSecadoPuntoExcesoImporte.Size = New System.Drawing.Size(70, 20)
        Me.currencytextboxTarifaSecadoPuntoExcesoImporte.TabIndex = 3
        Me.currencytextboxTarifaSecadoPuntoExcesoImporte.Text = "$ 0,000"
        Me.currencytextboxTarifaSecadoPuntoExcesoImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.currencytextboxTarifaSecadoPuntoExcesoImporte.WordWrap = False
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
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.TabIndex = 8
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.TabStop = False
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.Text = "Tipo de redondeo por punto:"
        '
        'radiobuttonTarifasSecadoRedondeoPuntoTipoInferior
        '
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.AutoSize = True
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.Location = New System.Drawing.Point(212, 19)
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.Name = "radiobuttonTarifasSecadoRedondeoPuntoTipoInferior"
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.Size = New System.Drawing.Size(57, 17)
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.TabIndex = 3
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.TabStop = True
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.Text = "Inferior"
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoInferior.UseVisualStyleBackColor = True
        '
        'radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior
        '
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.AutoSize = True
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.Location = New System.Drawing.Point(142, 19)
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.Name = "radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior"
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.Size = New System.Drawing.Size(64, 17)
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.TabIndex = 2
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.TabStop = True
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.Text = "Superior"
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoSuperior.UseVisualStyleBackColor = True
        '
        'radiobuttonTarifasSecadoRedondeoPuntoTipoEntero
        '
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.AutoSize = True
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.Location = New System.Drawing.Point(80, 19)
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.Name = "radiobuttonTarifasSecadoRedondeoPuntoTipoEntero"
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.Size = New System.Drawing.Size(56, 17)
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.TabIndex = 1
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.TabStop = True
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.Text = "Entero"
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoEntero.UseVisualStyleBackColor = True
        '
        'radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno
        '
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.AutoSize = True
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.Location = New System.Drawing.Point(7, 19)
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.Name = "radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno"
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.Size = New System.Drawing.Size(65, 17)
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.TabIndex = 0
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.TabStop = True
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.Text = "Ninguno"
        Me.radiobuttonTarifasSecadoRedondeoPuntoTipoNinguno.UseVisualStyleBackColor = True
        '
        'doubletextboxTarifaSecadoMargenLibre
        '
        Me.doubletextboxTarifaSecadoMargenLibre.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.doubletextboxTarifaSecadoMargenLibre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxTarifaSecadoMargenLibre.DoubleValue = 0R
        Me.doubletextboxTarifaSecadoMargenLibre.Location = New System.Drawing.Point(160, 124)
        Me.doubletextboxTarifaSecadoMargenLibre.MaxValue = 0.9R
        Me.doubletextboxTarifaSecadoMargenLibre.MinValue = 0R
        Me.doubletextboxTarifaSecadoMargenLibre.Name = "doubletextboxTarifaSecadoMargenLibre"
        Me.doubletextboxTarifaSecadoMargenLibre.NumberDecimalDigits = 1
        Me.doubletextboxTarifaSecadoMargenLibre.NumberNegativePattern = 0
        Me.doubletextboxTarifaSecadoMargenLibre.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxTarifaSecadoMargenLibre.Size = New System.Drawing.Size(39, 20)
        Me.doubletextboxTarifaSecadoMargenLibre.TabIndex = 7
        Me.doubletextboxTarifaSecadoMargenLibre.Text = "0,0"
        Me.doubletextboxTarifaSecadoMargenLibre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxTarifaSecadoMargenLibre.WordWrap = False
        '
        'labelTarifaSecadoMargenLibre
        '
        Me.labelTarifaSecadoMargenLibre.AutoSize = True
        Me.labelTarifaSecadoMargenLibre.Location = New System.Drawing.Point(6, 128)
        Me.labelTarifaSecadoMargenLibre.Name = "labelTarifaSecadoMargenLibre"
        Me.labelTarifaSecadoMargenLibre.Size = New System.Drawing.Size(72, 13)
        Me.labelTarifaSecadoMargenLibre.TabIndex = 6
        Me.labelTarifaSecadoMargenLibre.Text = "Margen Libre:"
        '
        'doubletextboxTarifaSecadoHumedadBase
        '
        Me.doubletextboxTarifaSecadoHumedadBase.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.doubletextboxTarifaSecadoHumedadBase.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxTarifaSecadoHumedadBase.DoubleValue = 0R
        Me.doubletextboxTarifaSecadoHumedadBase.Location = New System.Drawing.Point(160, 98)
        Me.doubletextboxTarifaSecadoHumedadBase.MaxValue = 40.0R
        Me.doubletextboxTarifaSecadoHumedadBase.MinValue = 0R
        Me.doubletextboxTarifaSecadoHumedadBase.Name = "doubletextboxTarifaSecadoHumedadBase"
        Me.doubletextboxTarifaSecadoHumedadBase.NumberDecimalDigits = 1
        Me.doubletextboxTarifaSecadoHumedadBase.NumberNegativePattern = 0
        Me.doubletextboxTarifaSecadoHumedadBase.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxTarifaSecadoHumedadBase.Size = New System.Drawing.Size(39, 20)
        Me.doubletextboxTarifaSecadoHumedadBase.TabIndex = 5
        Me.doubletextboxTarifaSecadoHumedadBase.Text = "0,0"
        Me.doubletextboxTarifaSecadoHumedadBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxTarifaSecadoHumedadBase.WordWrap = False
        '
        'labelTarifaSecadoHumedadBase
        '
        Me.labelTarifaSecadoHumedadBase.AutoSize = True
        Me.labelTarifaSecadoHumedadBase.Location = New System.Drawing.Point(6, 102)
        Me.labelTarifaSecadoHumedadBase.Name = "labelTarifaSecadoHumedadBase"
        Me.labelTarifaSecadoHumedadBase.Size = New System.Drawing.Size(83, 13)
        Me.labelTarifaSecadoHumedadBase.TabIndex = 4
        Me.labelTarifaSecadoHumedadBase.Text = "Humedad Base:"
        '
        'labelTarifaSecadoPuntoExcesoImporte
        '
        Me.labelTarifaSecadoPuntoExcesoImporte.AutoSize = True
        Me.labelTarifaSecadoPuntoExcesoImporte.Location = New System.Drawing.Point(6, 74)
        Me.labelTarifaSecadoPuntoExcesoImporte.Name = "labelTarifaSecadoPuntoExcesoImporte"
        Me.labelTarifaSecadoPuntoExcesoImporte.Size = New System.Drawing.Size(145, 13)
        Me.labelTarifaSecadoPuntoExcesoImporte.TabIndex = 2
        Me.labelTarifaSecadoPuntoExcesoImporte.Text = "Importe por punto de exceso:"
        '
        'groupboxTarifasSecadoInicial
        '
        Me.groupboxTarifasSecadoInicial.Controls.Add(Me.currencytextboxTarifaSecadoInicialImporte)
        Me.groupboxTarifasSecadoInicial.Controls.Add(Me.doubletextboxTarifaSecadoInicialPunto)
        Me.groupboxTarifasSecadoInicial.Controls.Add(Me.labelTarifaSecadoInicialImporte)
        Me.groupboxTarifasSecadoInicial.Controls.Add(Me.labelTarifaSecadoInicialPunto)
        Me.groupboxTarifasSecadoInicial.Location = New System.Drawing.Point(131, 19)
        Me.groupboxTarifasSecadoInicial.Name = "groupboxTarifasSecadoInicial"
        Me.groupboxTarifasSecadoInicial.Size = New System.Drawing.Size(229, 46)
        Me.groupboxTarifasSecadoInicial.TabIndex = 1
        Me.groupboxTarifasSecadoInicial.TabStop = False
        Me.groupboxTarifasSecadoInicial.Text = "Inicial:"
        '
        'currencytextboxTarifaSecadoInicialImporte
        '
        Me.currencytextboxTarifaSecadoInicialImporte.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.currencytextboxTarifaSecadoInicialImporte.CurrencyDecimalDigits = 3
        Me.currencytextboxTarifaSecadoInicialImporte.CurrentCultureRefresh = True
        Me.currencytextboxTarifaSecadoInicialImporte.DecimalValue = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.currencytextboxTarifaSecadoInicialImporte.Location = New System.Drawing.Point(152, 19)
        Me.currencytextboxTarifaSecadoInicialImporte.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 196608})
        Me.currencytextboxTarifaSecadoInicialImporte.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxTarifaSecadoInicialImporte.Name = "currencytextboxTarifaSecadoInicialImporte"
        Me.currencytextboxTarifaSecadoInicialImporte.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.KeepFocus
        Me.currencytextboxTarifaSecadoInicialImporte.Size = New System.Drawing.Size(70, 20)
        Me.currencytextboxTarifaSecadoInicialImporte.TabIndex = 3
        Me.currencytextboxTarifaSecadoInicialImporte.Text = "$ 0,000"
        Me.currencytextboxTarifaSecadoInicialImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.currencytextboxTarifaSecadoInicialImporte.WordWrap = False
        '
        'doubletextboxTarifaSecadoInicialPunto
        '
        Me.doubletextboxTarifaSecadoInicialPunto.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.doubletextboxTarifaSecadoInicialPunto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxTarifaSecadoInicialPunto.DoubleValue = 0R
        Me.doubletextboxTarifaSecadoInicialPunto.Location = New System.Drawing.Point(50, 19)
        Me.doubletextboxTarifaSecadoInicialPunto.MaxValue = 99.9R
        Me.doubletextboxTarifaSecadoInicialPunto.MinValue = 0R
        Me.doubletextboxTarifaSecadoInicialPunto.Name = "doubletextboxTarifaSecadoInicialPunto"
        Me.doubletextboxTarifaSecadoInicialPunto.NumberDecimalDigits = 1
        Me.doubletextboxTarifaSecadoInicialPunto.NumberNegativePattern = 0
        Me.doubletextboxTarifaSecadoInicialPunto.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.KeepFocus
        Me.doubletextboxTarifaSecadoInicialPunto.Size = New System.Drawing.Size(39, 20)
        Me.doubletextboxTarifaSecadoInicialPunto.TabIndex = 1
        Me.doubletextboxTarifaSecadoInicialPunto.Text = "0,0"
        Me.doubletextboxTarifaSecadoInicialPunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxTarifaSecadoInicialPunto.WordWrap = False
        '
        'labelTarifaSecadoInicialImporte
        '
        Me.labelTarifaSecadoInicialImporte.AutoSize = True
        Me.labelTarifaSecadoInicialImporte.Location = New System.Drawing.Point(101, 22)
        Me.labelTarifaSecadoInicialImporte.Name = "labelTarifaSecadoInicialImporte"
        Me.labelTarifaSecadoInicialImporte.Size = New System.Drawing.Size(45, 13)
        Me.labelTarifaSecadoInicialImporte.TabIndex = 2
        Me.labelTarifaSecadoInicialImporte.Text = "Importe:"
        '
        'labelTarifaSecadoInicialPunto
        '
        Me.labelTarifaSecadoInicialPunto.AutoSize = True
        Me.labelTarifaSecadoInicialPunto.Location = New System.Drawing.Point(6, 22)
        Me.labelTarifaSecadoInicialPunto.Name = "labelTarifaSecadoInicialPunto"
        Me.labelTarifaSecadoInicialPunto.Size = New System.Drawing.Size(38, 13)
        Me.labelTarifaSecadoInicialPunto.TabIndex = 0
        Me.labelTarifaSecadoInicialPunto.Text = "Punto:"
        '
        'groupboxTarifasSecadoSecadoTipo
        '
        Me.groupboxTarifasSecadoSecadoTipo.Controls.Add(Me.radiobuttonSecadoTipoFijo)
        Me.groupboxTarifasSecadoSecadoTipo.Controls.Add(Me.radiobuttonSecadoTipoEscala)
        Me.groupboxTarifasSecadoSecadoTipo.Location = New System.Drawing.Point(6, 19)
        Me.groupboxTarifasSecadoSecadoTipo.Name = "groupboxTarifasSecadoSecadoTipo"
        Me.groupboxTarifasSecadoSecadoTipo.Size = New System.Drawing.Size(119, 46)
        Me.groupboxTarifasSecadoSecadoTipo.TabIndex = 0
        Me.groupboxTarifasSecadoSecadoTipo.TabStop = False
        Me.groupboxTarifasSecadoSecadoTipo.Text = "Tipo de Tarifa:"
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
        Me.radiobuttonSecadoTipoEscala.TabIndex = 1
        Me.radiobuttonSecadoTipoEscala.TabStop = True
        Me.radiobuttonSecadoTipoEscala.Text = "Escala"
        Me.radiobuttonSecadoTipoEscala.UseVisualStyleBackColor = True
        '
        'groupboxTarifasVarias
        '
        Me.groupboxTarifasVarias.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupboxTarifasVarias.Controls.Add(Me.currencytextboxTarifaMezcladoImporte)
        Me.groupboxTarifasVarias.Controls.Add(Me.currencytextboxTarifaFumigadoImporte)
        Me.groupboxTarifasVarias.Controls.Add(Me.currencytextboxTarifaZarandeo)
        Me.groupboxTarifasVarias.Controls.Add(Me.currencytextboxTarifaParitariaImporte)
        Me.groupboxTarifasVarias.Controls.Add(Me.labelTarifaMezcladoImporte)
        Me.groupboxTarifasVarias.Controls.Add(Me.labelTarifaFumigadoImporte)
        Me.groupboxTarifasVarias.Controls.Add(Me.labelTarifaZarandeoImporte)
        Me.groupboxTarifasVarias.Controls.Add(Me.labelTarifaParitariaImporte)
        Me.groupboxTarifasVarias.Location = New System.Drawing.Point(6, 6)
        Me.groupboxTarifasVarias.Name = "groupboxTarifasVarias"
        Me.groupboxTarifasVarias.Size = New System.Drawing.Size(366, 75)
        Me.groupboxTarifasVarias.TabIndex = 0
        Me.groupboxTarifasVarias.TabStop = False
        Me.groupboxTarifasVarias.Text = "Varias:"
        '
        'currencytextboxTarifaMezcladoImporte
        '
        Me.currencytextboxTarifaMezcladoImporte.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.currencytextboxTarifaMezcladoImporte.CurrencyDecimalDigits = 3
        Me.currencytextboxTarifaMezcladoImporte.CurrentCultureRefresh = True
        Me.currencytextboxTarifaMezcladoImporte.DecimalValue = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.currencytextboxTarifaMezcladoImporte.Location = New System.Drawing.Point(231, 45)
        Me.currencytextboxTarifaMezcladoImporte.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 196608})
        Me.currencytextboxTarifaMezcladoImporte.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxTarifaMezcladoImporte.Name = "currencytextboxTarifaMezcladoImporte"
        Me.currencytextboxTarifaMezcladoImporte.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.KeepFocus
        Me.currencytextboxTarifaMezcladoImporte.Size = New System.Drawing.Size(70, 20)
        Me.currencytextboxTarifaMezcladoImporte.TabIndex = 7
        Me.currencytextboxTarifaMezcladoImporte.Text = "$ 0,000"
        Me.currencytextboxTarifaMezcladoImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.currencytextboxTarifaMezcladoImporte.WordWrap = False
        '
        'currencytextboxTarifaFumigadoImporte
        '
        Me.currencytextboxTarifaFumigadoImporte.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.currencytextboxTarifaFumigadoImporte.CurrencyDecimalDigits = 3
        Me.currencytextboxTarifaFumigadoImporte.CurrentCultureRefresh = True
        Me.currencytextboxTarifaFumigadoImporte.DecimalValue = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.currencytextboxTarifaFumigadoImporte.Location = New System.Drawing.Point(231, 19)
        Me.currencytextboxTarifaFumigadoImporte.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 196608})
        Me.currencytextboxTarifaFumigadoImporte.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxTarifaFumigadoImporte.Name = "currencytextboxTarifaFumigadoImporte"
        Me.currencytextboxTarifaFumigadoImporte.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.KeepFocus
        Me.currencytextboxTarifaFumigadoImporte.Size = New System.Drawing.Size(70, 20)
        Me.currencytextboxTarifaFumigadoImporte.TabIndex = 5
        Me.currencytextboxTarifaFumigadoImporte.Text = "$ 0,000"
        Me.currencytextboxTarifaFumigadoImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.currencytextboxTarifaFumigadoImporte.WordWrap = False
        '
        'currencytextboxTarifaZarandeo
        '
        Me.currencytextboxTarifaZarandeo.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.currencytextboxTarifaZarandeo.CurrencyDecimalDigits = 3
        Me.currencytextboxTarifaZarandeo.CurrentCultureRefresh = True
        Me.currencytextboxTarifaZarandeo.DecimalValue = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.currencytextboxTarifaZarandeo.Location = New System.Drawing.Point(68, 45)
        Me.currencytextboxTarifaZarandeo.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 196608})
        Me.currencytextboxTarifaZarandeo.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxTarifaZarandeo.Name = "currencytextboxTarifaZarandeo"
        Me.currencytextboxTarifaZarandeo.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.KeepFocus
        Me.currencytextboxTarifaZarandeo.Size = New System.Drawing.Size(70, 20)
        Me.currencytextboxTarifaZarandeo.TabIndex = 3
        Me.currencytextboxTarifaZarandeo.Text = "$ 0,000"
        Me.currencytextboxTarifaZarandeo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.currencytextboxTarifaZarandeo.WordWrap = False
        '
        'currencytextboxTarifaParitariaImporte
        '
        Me.currencytextboxTarifaParitariaImporte.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.currencytextboxTarifaParitariaImporte.CurrencyDecimalDigits = 3
        Me.currencytextboxTarifaParitariaImporte.CurrentCultureRefresh = True
        Me.currencytextboxTarifaParitariaImporte.DecimalValue = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.currencytextboxTarifaParitariaImporte.Location = New System.Drawing.Point(68, 19)
        Me.currencytextboxTarifaParitariaImporte.MaxValue = New Decimal(New Integer() {9999999, 0, 0, 196608})
        Me.currencytextboxTarifaParitariaImporte.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxTarifaParitariaImporte.Name = "currencytextboxTarifaParitariaImporte"
        Me.currencytextboxTarifaParitariaImporte.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.KeepFocus
        Me.currencytextboxTarifaParitariaImporte.Size = New System.Drawing.Size(70, 20)
        Me.currencytextboxTarifaParitariaImporte.TabIndex = 1
        Me.currencytextboxTarifaParitariaImporte.Text = "$ 0,000"
        Me.currencytextboxTarifaParitariaImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.currencytextboxTarifaParitariaImporte.WordWrap = False
        '
        'labelTarifaMezcladoImporte
        '
        Me.labelTarifaMezcladoImporte.AutoSize = True
        Me.labelTarifaMezcladoImporte.Location = New System.Drawing.Point(169, 48)
        Me.labelTarifaMezcladoImporte.Name = "labelTarifaMezcladoImporte"
        Me.labelTarifaMezcladoImporte.Size = New System.Drawing.Size(56, 13)
        Me.labelTarifaMezcladoImporte.TabIndex = 6
        Me.labelTarifaMezcladoImporte.Text = "Mezclado:"
        '
        'labelTarifaFumigadoImporte
        '
        Me.labelTarifaFumigadoImporte.AutoSize = True
        Me.labelTarifaFumigadoImporte.Location = New System.Drawing.Point(169, 22)
        Me.labelTarifaFumigadoImporte.Name = "labelTarifaFumigadoImporte"
        Me.labelTarifaFumigadoImporte.Size = New System.Drawing.Size(56, 13)
        Me.labelTarifaFumigadoImporte.TabIndex = 4
        Me.labelTarifaFumigadoImporte.Text = "Fumigado:"
        '
        'labelTarifaZarandeoImporte
        '
        Me.labelTarifaZarandeoImporte.AutoSize = True
        Me.labelTarifaZarandeoImporte.Location = New System.Drawing.Point(6, 48)
        Me.labelTarifaZarandeoImporte.Name = "labelTarifaZarandeoImporte"
        Me.labelTarifaZarandeoImporte.Size = New System.Drawing.Size(56, 13)
        Me.labelTarifaZarandeoImporte.TabIndex = 2
        Me.labelTarifaZarandeoImporte.Text = "Zarandeo:"
        '
        'labelTarifaParitariaImporte
        '
        Me.labelTarifaParitariaImporte.AutoSize = True
        Me.labelTarifaParitariaImporte.Location = New System.Drawing.Point(6, 22)
        Me.labelTarifaParitariaImporte.Name = "labelTarifaParitariaImporte"
        Me.labelTarifaParitariaImporte.Size = New System.Drawing.Size(48, 13)
        Me.labelTarifaParitariaImporte.TabIndex = 0
        Me.labelTarifaParitariaImporte.Text = "Paritaria:"
        '
        'tabpageAlmacenaje
        '
        Me.tabpageAlmacenaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabpageAlmacenaje.Controls.Add(Me.percenttextboxAlmacenajePorcentajeMensual)
        Me.tabpageAlmacenaje.Controls.Add(Me.integertextboxAlmacenajeDiaGracia)
        Me.tabpageAlmacenaje.Controls.Add(Me.datetimepickerAlmacenajeInicio)
        Me.tabpageAlmacenaje.Controls.Add(Me.labelAlmacenajePorcentajeMensual)
        Me.tabpageAlmacenaje.Controls.Add(Me.Label2)
        Me.tabpageAlmacenaje.Controls.Add(Me.labelAlmacenajeDiaGracia)
        Me.tabpageAlmacenaje.Controls.Add(Me.groupboxAlmacenajeTipo)
        Me.tabpageAlmacenaje.Location = New System.Drawing.Point(4, 25)
        Me.tabpageAlmacenaje.Name = "tabpageAlmacenaje"
        Me.tabpageAlmacenaje.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageAlmacenaje.Size = New System.Drawing.Size(380, 309)
        Me.tabpageAlmacenaje.TabIndex = 3
        Me.tabpageAlmacenaje.Text = "Almacenaje"
        Me.tabpageAlmacenaje.UseVisualStyleBackColor = True
        '
        'percenttextboxAlmacenajePorcentajeMensual
        '
        Me.percenttextboxAlmacenajePorcentajeMensual.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.percenttextboxAlmacenajePorcentajeMensual.Location = New System.Drawing.Point(122, 133)
        Me.percenttextboxAlmacenajePorcentajeMensual.MaxValue = 5.0R
        Me.percenttextboxAlmacenajePorcentajeMensual.MinValue = 0R
        Me.percenttextboxAlmacenajePorcentajeMensual.Name = "percenttextboxAlmacenajePorcentajeMensual"
        Me.percenttextboxAlmacenajePorcentajeMensual.Size = New System.Drawing.Size(52, 20)
        Me.percenttextboxAlmacenajePorcentajeMensual.TabIndex = 6
        Me.percenttextboxAlmacenajePorcentajeMensual.Text = "0,00 %"
        Me.percenttextboxAlmacenajePorcentajeMensual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.percenttextboxAlmacenajePorcentajeMensual.WordWrap = False
        '
        'integertextboxAlmacenajeDiaGracia
        '
        Me.integertextboxAlmacenajeDiaGracia.AllowNull = True
        Me.integertextboxAlmacenajeDiaGracia.BeforeTouchSize = New System.Drawing.Size(39, 20)
        Me.integertextboxAlmacenajeDiaGracia.ForeColor = System.Drawing.SystemColors.WindowText
        Me.integertextboxAlmacenajeDiaGracia.IntegerValue = CType(0, Long)
        Me.integertextboxAlmacenajeDiaGracia.Location = New System.Drawing.Point(122, 81)
        Me.integertextboxAlmacenajeDiaGracia.MaxValue = CType(999, Long)
        Me.integertextboxAlmacenajeDiaGracia.MinValue = CType(0, Long)
        Me.integertextboxAlmacenajeDiaGracia.Name = "integertextboxAlmacenajeDiaGracia"
        Me.integertextboxAlmacenajeDiaGracia.Size = New System.Drawing.Size(39, 20)
        Me.integertextboxAlmacenajeDiaGracia.TabIndex = 2
        Me.integertextboxAlmacenajeDiaGracia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'datetimepickerAlmacenajeInicio
        '
        Me.datetimepickerAlmacenajeInicio.Checked = False
        Me.datetimepickerAlmacenajeInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerAlmacenajeInicio.Location = New System.Drawing.Point(122, 107)
        Me.datetimepickerAlmacenajeInicio.Name = "datetimepickerAlmacenajeInicio"
        Me.datetimepickerAlmacenajeInicio.ShowCheckBox = True
        Me.datetimepickerAlmacenajeInicio.Size = New System.Drawing.Size(123, 20)
        Me.datetimepickerAlmacenajeInicio.TabIndex = 4
        '
        'labelAlmacenajePorcentajeMensual
        '
        Me.labelAlmacenajePorcentajeMensual.AutoSize = True
        Me.labelAlmacenajePorcentajeMensual.Location = New System.Drawing.Point(6, 137)
        Me.labelAlmacenajePorcentajeMensual.Name = "labelAlmacenajePorcentajeMensual"
        Me.labelAlmacenajePorcentajeMensual.Size = New System.Drawing.Size(103, 13)
        Me.labelAlmacenajePorcentajeMensual.TabIndex = 5
        Me.labelAlmacenajePorcentajeMensual.Text = "Porcentaje mensual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Inicio:"
        '
        'labelAlmacenajeDiaGracia
        '
        Me.labelAlmacenajeDiaGracia.AutoSize = True
        Me.labelAlmacenajeDiaGracia.Location = New System.Drawing.Point(6, 85)
        Me.labelAlmacenajeDiaGracia.Name = "labelAlmacenajeDiaGracia"
        Me.labelAlmacenajeDiaGracia.Size = New System.Drawing.Size(80, 13)
        Me.labelAlmacenajeDiaGracia.TabIndex = 1
        Me.labelAlmacenajeDiaGracia.Text = "Días de gracia:"
        '
        'groupboxAlmacenajeTipo
        '
        Me.groupboxAlmacenajeTipo.Controls.Add(Me.radiobuttonAlmacenajeTipoDiasGraciaFijo)
        Me.groupboxAlmacenajeTipo.Controls.Add(Me.radiobuttonAlmacenajeTipoFechaFija)
        Me.groupboxAlmacenajeTipo.Controls.Add(Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes)
        Me.groupboxAlmacenajeTipo.Location = New System.Drawing.Point(6, 6)
        Me.groupboxAlmacenajeTipo.Name = "groupboxAlmacenajeTipo"
        Me.groupboxAlmacenajeTipo.Size = New System.Drawing.Size(352, 69)
        Me.groupboxAlmacenajeTipo.TabIndex = 0
        Me.groupboxAlmacenajeTipo.TabStop = False
        Me.groupboxAlmacenajeTipo.Text = "Tipo:"
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
        'radiobuttonAlmacenajeTipoFechaFija
        '
        Me.radiobuttonAlmacenajeTipoFechaFija.AutoSize = True
        Me.radiobuttonAlmacenajeTipoFechaFija.Location = New System.Drawing.Point(6, 42)
        Me.radiobuttonAlmacenajeTipoFechaFija.Name = "radiobuttonAlmacenajeTipoFechaFija"
        Me.radiobuttonAlmacenajeTipoFechaFija.Size = New System.Drawing.Size(71, 17)
        Me.radiobuttonAlmacenajeTipoFechaFija.TabIndex = 2
        Me.radiobuttonAlmacenajeTipoFechaFija.TabStop = True
        Me.radiobuttonAlmacenajeTipoFechaFija.Text = "Fecha fija"
        Me.radiobuttonAlmacenajeTipoFechaFija.UseVisualStyleBackColor = True
        '
        'radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes
        '
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.AutoSize = True
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.Location = New System.Drawing.Point(128, 19)
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.Name = "radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes"
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.Size = New System.Drawing.Size(160, 17)
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.TabIndex = 1
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.TabStop = True
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.Text = "Días de gracia si retira antes"
        Me.radiobuttonAlmacenajeTipoDiasGraciaSiRetiraAntes.UseVisualStyleBackColor = True
        '
        'tabpageSecadoEscala
        '
        Me.tabpageSecadoEscala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabpageSecadoEscala.Controls.Add(Me.datagridviewTarifaSecadoEscala)
        Me.tabpageSecadoEscala.Controls.Add(Me.toolstripEscala)
        Me.tabpageSecadoEscala.Location = New System.Drawing.Point(4, 25)
        Me.tabpageSecadoEscala.Name = "tabpageSecadoEscala"
        Me.tabpageSecadoEscala.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageSecadoEscala.Size = New System.Drawing.Size(380, 309)
        Me.tabpageSecadoEscala.TabIndex = 1
        Me.tabpageSecadoEscala.Text = "Escalas de Secado"
        Me.tabpageSecadoEscala.UseVisualStyleBackColor = True
        '
        'datagridviewTarifaSecadoEscala
        '
        Me.datagridviewTarifaSecadoEscala.AllowUserToAddRows = False
        Me.datagridviewTarifaSecadoEscala.AllowUserToDeleteRows = False
        Me.datagridviewTarifaSecadoEscala.AllowUserToResizeColumns = False
        Me.datagridviewTarifaSecadoEscala.AllowUserToResizeRows = False
        Me.datagridviewTarifaSecadoEscala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewTarifaSecadoEscala.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnHumedadExcesoInicio, Me.columnTipo, Me.columnTarifa})
        Me.datagridviewTarifaSecadoEscala.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewTarifaSecadoEscala.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewTarifaSecadoEscala.Location = New System.Drawing.Point(90, 3)
        Me.datagridviewTarifaSecadoEscala.Name = "datagridviewTarifaSecadoEscala"
        Me.datagridviewTarifaSecadoEscala.ReadOnly = True
        Me.datagridviewTarifaSecadoEscala.RowHeadersVisible = False
        Me.datagridviewTarifaSecadoEscala.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewTarifaSecadoEscala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewTarifaSecadoEscala.Size = New System.Drawing.Size(285, 301)
        Me.datagridviewTarifaSecadoEscala.TabIndex = 0
        '
        'columnHumedadExcesoInicio
        '
        Me.columnHumedadExcesoInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnHumedadExcesoInicio.DataPropertyName = "HumedadExcesoInicio"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.columnHumedadExcesoInicio.DefaultCellStyle = DataGridViewCellStyle3
        Me.columnHumedadExcesoInicio.HeaderText = "Exceso Inicio"
        Me.columnHumedadExcesoInicio.Name = "columnHumedadExcesoInicio"
        Me.columnHumedadExcesoInicio.ReadOnly = True
        Me.columnHumedadExcesoInicio.Width = 95
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
        'columnTarifa
        '
        Me.columnTarifa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnTarifa.DataPropertyName = "Tarifa"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.columnTarifa.DefaultCellStyle = DataGridViewCellStyle4
        Me.columnTarifa.HeaderText = "Tarifa"
        Me.columnTarifa.Name = "columnTarifa"
        Me.columnTarifa.ReadOnly = True
        Me.columnTarifa.Width = 59
        '
        'toolstripEscala
        '
        Me.toolstripEscala.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripEscala.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripEscala.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripEscala.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonEscala_Agregar, Me.buttonEscala_Editar, Me.buttonEscala_Eliminar})
        Me.toolstripEscala.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripEscala.Location = New System.Drawing.Point(3, 3)
        Me.toolstripEscala.Name = "toolstripEscala"
        Me.toolstripEscala.Size = New System.Drawing.Size(87, 301)
        Me.toolstripEscala.TabIndex = 6
        '
        'buttonEscala_Agregar
        '
        Me.buttonEscala_Agregar.Image = Global.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonEscala_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonEscala_Agregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEscala_Agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEscala_Agregar.Name = "buttonEscala_Agregar"
        Me.buttonEscala_Agregar.Size = New System.Drawing.Size(84, 36)
        Me.buttonEscala_Agregar.Text = "Agregar"
        '
        'buttonEscala_Editar
        '
        Me.buttonEscala_Editar.Image = Global.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEscala_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonEscala_Editar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEscala_Editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEscala_Editar.Name = "buttonEscala_Editar"
        Me.buttonEscala_Editar.Size = New System.Drawing.Size(84, 36)
        Me.buttonEscala_Editar.Text = "Editar"
        '
        'buttonEscala_Eliminar
        '
        Me.buttonEscala_Eliminar.Image = Global.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonEscala_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonEscala_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEscala_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEscala_Eliminar.Name = "buttonEscala_Eliminar"
        Me.buttonEscala_Eliminar.Size = New System.Drawing.Size(84, 36)
        Me.buttonEscala_Eliminar.Text = "Eliminar"
        '
        'formTarifa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 392)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "formTarifa"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
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
        Me.groupboxTarifasSecado.ResumeLayout(False)
        Me.groupboxTarifasSecado.PerformLayout()
        CType(Me.currencytextboxTarifaSecadoPuntoExcesoImporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.ResumeLayout(False)
        Me.groupboxTarifasSecadoRedondeoPuntoTipo.PerformLayout()
        CType(Me.doubletextboxTarifaSecadoMargenLibre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxTarifaSecadoHumedadBase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupboxTarifasSecadoInicial.ResumeLayout(False)
        Me.groupboxTarifasSecadoInicial.PerformLayout()
        CType(Me.currencytextboxTarifaSecadoInicialImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxTarifaSecadoInicialPunto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupboxTarifasSecadoSecadoTipo.ResumeLayout(False)
        Me.groupboxTarifasSecadoSecadoTipo.PerformLayout()
        Me.groupboxTarifasVarias.ResumeLayout(False)
        Me.groupboxTarifasVarias.PerformLayout()
        CType(Me.currencytextboxTarifaMezcladoImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currencytextboxTarifaFumigadoImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currencytextboxTarifaZarandeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currencytextboxTarifaParitariaImporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpageAlmacenaje.ResumeLayout(False)
        Me.tabpageAlmacenaje.PerformLayout()
        CType(Me.percenttextboxAlmacenajePorcentajeMensual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.integertextboxAlmacenajeDiaGracia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupboxAlmacenajeTipo.ResumeLayout(False)
        Me.groupboxAlmacenajeTipo.PerformLayout()
        Me.tabpageSecadoEscala.ResumeLayout(False)
        Me.tabpageSecadoEscala.PerformLayout()
        CType(Me.datagridviewTarifaSecadoEscala, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripEscala.ResumeLayout(False)
        Me.toolstripEscala.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents toolstripMain As ToolStrip
    Friend WithEvents buttonCerrar As ToolStripButton
    Friend WithEvents buttonEditar As ToolStripButton
    Friend WithEvents buttonCancelar As ToolStripButton
    Friend WithEvents buttonGuardar As ToolStripButton
    Friend WithEvents tabcontrolMain As CardonerSistemas.TabControl
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
    Friend WithEvents labelTarifaParitariaImporte As Label
    Friend WithEvents labelTarifaMezcladoImporte As Label
    Friend WithEvents labelTarifaFumigadoImporte As Label
    Friend WithEvents labelTarifaZarandeoImporte As Label
    Friend WithEvents groupboxTarifasSecado As GroupBox
    Friend WithEvents radiobuttonSecadoTipoEscala As RadioButton
    Friend WithEvents radiobuttonSecadoTipoFijo As RadioButton
    Friend WithEvents groupboxTarifasSecadoSecadoTipo As GroupBox
    Friend WithEvents doubletextboxTarifaSecadoInicialPunto As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelTarifaSecadoInicialPunto As Label
    Friend WithEvents labelTarifaSecadoInicialImporte As Label
    Friend WithEvents groupboxTarifasSecadoInicial As GroupBox
    Friend WithEvents doubletextboxTarifaSecadoHumedadBase As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelTarifaSecadoHumedadBase As Label
    Friend WithEvents labelTarifaSecadoPuntoExcesoImporte As Label
    Friend WithEvents doubletextboxTarifaSecadoMargenLibre As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelTarifaSecadoMargenLibre As Label
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
    Friend WithEvents labelAlmacenajePorcentajeMensual As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents labelAlmacenajeDiaGracia As Label
    Friend WithEvents datetimepickerAlmacenajeInicio As DateTimePicker
    Friend WithEvents integertextboxAlmacenajeDiaGracia As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents percenttextboxAlmacenajePorcentajeMensual As Syncfusion.Windows.Forms.Tools.PercentTextBox
    Friend WithEvents buttonIndiceObtener As Button
    Friend WithEvents currencytextboxTarifaParitariaImporte As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents currencytextboxTarifaMezcladoImporte As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents currencytextboxTarifaFumigadoImporte As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents currencytextboxTarifaZarandeo As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents currencytextboxTarifaSecadoInicialImporte As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents currencytextboxTarifaSecadoPuntoExcesoImporte As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
    Friend WithEvents datagridviewTarifaSecadoEscala As DataGridView
    Friend WithEvents toolstripEscala As ToolStrip
    Friend WithEvents buttonEscala_Agregar As ToolStripButton
    Friend WithEvents buttonEscala_Editar As ToolStripButton
    Friend WithEvents buttonEscala_Eliminar As ToolStripButton
    Friend WithEvents columnHumedadExcesoInicio As DataGridViewTextBoxColumn
    Friend WithEvents columnTipo As DataGridViewTextBoxColumn
    Friend WithEvents columnTarifa As DataGridViewTextBoxColumn
End Class
