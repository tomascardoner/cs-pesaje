<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formProducto
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
        Dim labelEsActivo As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.tabcontrolMain = New System.Windows.Forms.TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.ComboBoxTicketPesada_IDReporte = New System.Windows.Forms.ComboBox()
        Me.LabelMermaHumedadManipuleo = New System.Windows.Forms.Label()
        Me.LabelMermaHumedadBase = New System.Windows.Forms.Label()
        Me.checkboxUsoFrecuente = New System.Windows.Forms.CheckBox()
        Me.checkboxUtilizaPlanta = New System.Windows.Forms.CheckBox()
        Me.checkboxUtilizaCosecha = New System.Windows.Forms.CheckBox()
        Me.labelOrden = New System.Windows.Forms.Label()
        Me.labelUsoFrecuente = New System.Windows.Forms.Label()
        Me.labelUtilizaCosecha = New System.Windows.Forms.Label()
        Me.labelUtilizaPlanta = New System.Windows.Forms.Label()
        Me.labelMermaVolátil = New System.Windows.Forms.Label()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.tabpageMermasHumedad = New System.Windows.Forms.TabPage()
        Me.datagridviewMermasHumedad = New System.Windows.Forms.DataGridView()
        Me.columnMermasHumedadHumedad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnMermasHumedadMerma = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripMermasHumedad = New System.Windows.Forms.ToolStrip()
        Me.buttonMermasHumedadAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonMermasHumedadEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonMermasHumedadBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tabpagePlantas = New System.Windows.Forms.TabPage()
        Me.datagridviewPlantas = New System.Windows.Forms.DataGridView()
        Me.columnPlantasPlanta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripPlantas = New System.Windows.Forms.ToolStrip()
        Me.buttonPlantasAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonPlantasEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonPlantasBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageCosechas = New System.Windows.Forms.TabPage()
        Me.datagridviewCosechas = New System.Windows.Forms.DataGridView()
        Me.columnCosechasCosecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCosechasInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCosechasFin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCosechasEsActivo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.toolstripCosechas = New System.Windows.Forms.ToolStrip()
        Me.buttonCosechasAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCosechasEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCosechasBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.labelID = New System.Windows.Forms.Label()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.textboxID = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.DoubleTextBoxMermaVolatil = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.DoubleTextBoxMermaHumedadBase = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.DoubleTextBoxMermaHumedadManipuleo = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        labelEsActivo = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageMermasHumedad.SuspendLayout()
        CType(Me.datagridviewMermasHumedad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripMermasHumedad.SuspendLayout()
        Me.tabpagePlantas.SuspendLayout()
        CType(Me.datagridviewPlantas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripPlantas.SuspendLayout()
        Me.tabpageCosechas.SuspendLayout()
        CType(Me.datagridviewCosechas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripCosechas.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        CType(Me.DoubleTextBoxMermaVolatil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoubleTextBoxMermaHumedadBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoubleTextBoxMermaHumedadManipuleo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelEsActivo
        '
        labelEsActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(10, 122)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 2
        labelEsActivo.Text = "Activo:"
        '
        'labelModificacion
        '
        labelModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 200)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 9
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(10, 174)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 6
        labelCreacion.Text = "Creación:"
        '
        'buttonGuardar
        '
        Me.buttonGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonGuardar.Image = My.Resources.Resources.ImageAceptar32
        Me.buttonGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonGuardar.Name = "buttonGuardar"
        Me.buttonGuardar.Size = New System.Drawing.Size(85, 36)
        Me.buttonGuardar.Text = "Guardar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCancelar.Image = My.Resources.Resources.ImageCancelar32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = My.Resources.Resources.ImageItemEditar32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = My.Resources.Resources.ImageClose32
        Me.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCerrar.Name = "buttonCerrar"
        Me.buttonCerrar.Size = New System.Drawing.Size(75, 36)
        Me.buttonCerrar.Text = "Cerrar"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(544, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageMermasHumedad)
        Me.tabcontrolMain.Controls.Add(Me.tabpagePlantas)
        Me.tabcontrolMain.Controls.Add(Me.tabpageCosechas)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(522, 252)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.DoubleTextBoxMermaHumedadManipuleo)
        Me.tabpageGeneral.Controls.Add(Me.DoubleTextBoxMermaHumedadBase)
        Me.tabpageGeneral.Controls.Add(Me.DoubleTextBoxMermaVolatil)
        Me.tabpageGeneral.Controls.Add(Me.ComboBoxTicketPesada_IDReporte)
        Me.tabpageGeneral.Controls.Add(Me.LabelMermaHumedadManipuleo)
        Me.tabpageGeneral.Controls.Add(Me.LabelMermaHumedadBase)
        Me.tabpageGeneral.Controls.Add(Me.checkboxUsoFrecuente)
        Me.tabpageGeneral.Controls.Add(Me.checkboxUtilizaPlanta)
        Me.tabpageGeneral.Controls.Add(Me.checkboxUtilizaCosecha)
        Me.tabpageGeneral.Controls.Add(Me.labelOrden)
        Me.tabpageGeneral.Controls.Add(Me.labelUsoFrecuente)
        Me.tabpageGeneral.Controls.Add(Me.labelUtilizaCosecha)
        Me.tabpageGeneral.Controls.Add(Me.labelUtilizaPlanta)
        Me.tabpageGeneral.Controls.Add(Me.labelMermaVolátil)
        Me.tabpageGeneral.Controls.Add(Me.textboxNombre)
        Me.tabpageGeneral.Controls.Add(Me.labelNombre)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(514, 223)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'ComboBoxTicketPesada_IDReporte
        '
        Me.ComboBoxTicketPesada_IDReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTicketPesada_IDReporte.FormattingEnabled = True
        Me.ComboBoxTicketPesada_IDReporte.Location = New System.Drawing.Point(152, 192)
        Me.ComboBoxTicketPesada_IDReporte.Name = "ComboBoxTicketPesada_IDReporte"
        Me.ComboBoxTicketPesada_IDReporte.Size = New System.Drawing.Size(353, 21)
        Me.ComboBoxTicketPesada_IDReporte.TabIndex = 15
        '
        'LabelMermaHumedadManipuleo
        '
        Me.LabelMermaHumedadManipuleo.AutoSize = True
        Me.LabelMermaHumedadManipuleo.Location = New System.Drawing.Point(6, 100)
        Me.LabelMermaHumedadManipuleo.Name = "LabelMermaHumedadManipuleo"
        Me.LabelMermaHumedadManipuleo.Size = New System.Drawing.Size(140, 13)
        Me.LabelMermaHumedadManipuleo.TabIndex = 6
        Me.LabelMermaHumedadManipuleo.Text = "Merma humedad manipuleo:"
        '
        'LabelMermaHumedadBase
        '
        Me.LabelMermaHumedadBase.AutoSize = True
        Me.LabelMermaHumedadBase.Location = New System.Drawing.Point(6, 74)
        Me.LabelMermaHumedadBase.Name = "LabelMermaHumedadBase"
        Me.LabelMermaHumedadBase.Size = New System.Drawing.Size(115, 13)
        Me.LabelMermaHumedadBase.TabIndex = 4
        Me.LabelMermaHumedadBase.Text = "Merma humedad base:"
        '
        'checkboxUsoFrecuente
        '
        Me.checkboxUsoFrecuente.AutoSize = True
        Me.checkboxUsoFrecuente.Location = New System.Drawing.Point(152, 172)
        Me.checkboxUsoFrecuente.Name = "checkboxUsoFrecuente"
        Me.checkboxUsoFrecuente.Size = New System.Drawing.Size(15, 14)
        Me.checkboxUsoFrecuente.TabIndex = 13
        Me.checkboxUsoFrecuente.UseVisualStyleBackColor = True
        '
        'checkboxUtilizaPlanta
        '
        Me.checkboxUtilizaPlanta.AutoSize = True
        Me.checkboxUtilizaPlanta.Location = New System.Drawing.Point(152, 126)
        Me.checkboxUtilizaPlanta.Name = "checkboxUtilizaPlanta"
        Me.checkboxUtilizaPlanta.Size = New System.Drawing.Size(15, 14)
        Me.checkboxUtilizaPlanta.TabIndex = 9
        Me.checkboxUtilizaPlanta.UseVisualStyleBackColor = True
        '
        'checkboxUtilizaCosecha
        '
        Me.checkboxUtilizaCosecha.AutoSize = True
        Me.checkboxUtilizaCosecha.Location = New System.Drawing.Point(152, 149)
        Me.checkboxUtilizaCosecha.Name = "checkboxUtilizaCosecha"
        Me.checkboxUtilizaCosecha.Size = New System.Drawing.Size(15, 14)
        Me.checkboxUtilizaCosecha.TabIndex = 11
        Me.checkboxUtilizaCosecha.UseVisualStyleBackColor = True
        '
        'labelOrden
        '
        Me.labelOrden.AutoSize = True
        Me.labelOrden.Location = New System.Drawing.Point(6, 195)
        Me.labelOrden.Name = "labelOrden"
        Me.labelOrden.Size = New System.Drawing.Size(130, 13)
        Me.labelOrden.TabIndex = 14
        Me.labelOrden.Text = "Reporte de ticket pesada:"
        '
        'labelUsoFrecuente
        '
        Me.labelUsoFrecuente.AutoSize = True
        Me.labelUsoFrecuente.Location = New System.Drawing.Point(6, 172)
        Me.labelUsoFrecuente.Name = "labelUsoFrecuente"
        Me.labelUsoFrecuente.Size = New System.Drawing.Size(77, 13)
        Me.labelUsoFrecuente.TabIndex = 12
        Me.labelUsoFrecuente.Text = "Uso frecuente:"
        '
        'labelUtilizaCosecha
        '
        Me.labelUtilizaCosecha.AutoSize = True
        Me.labelUtilizaCosecha.Location = New System.Drawing.Point(6, 149)
        Me.labelUtilizaCosecha.Name = "labelUtilizaCosecha"
        Me.labelUtilizaCosecha.Size = New System.Drawing.Size(82, 13)
        Me.labelUtilizaCosecha.TabIndex = 10
        Me.labelUtilizaCosecha.Text = "Utiliza cosecha:"
        '
        'labelUtilizaPlanta
        '
        Me.labelUtilizaPlanta.AutoSize = True
        Me.labelUtilizaPlanta.Location = New System.Drawing.Point(6, 126)
        Me.labelUtilizaPlanta.Name = "labelUtilizaPlanta"
        Me.labelUtilizaPlanta.Size = New System.Drawing.Size(70, 13)
        Me.labelUtilizaPlanta.TabIndex = 8
        Me.labelUtilizaPlanta.Text = "Utiliza planta:"
        '
        'labelMermaVolátil
        '
        Me.labelMermaVolátil.AutoSize = True
        Me.labelMermaVolátil.Location = New System.Drawing.Point(6, 48)
        Me.labelMermaVolátil.Name = "labelMermaVolátil"
        Me.labelMermaVolátil.Size = New System.Drawing.Size(72, 13)
        Me.labelMermaVolátil.TabIndex = 2
        Me.labelMermaVolátil.Text = "Merma volátil:"
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(152, 19)
        Me.textboxNombre.MaxLength = 50
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(353, 20)
        Me.textboxNombre.TabIndex = 1
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(6, 22)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(47, 13)
        Me.labelNombre.TabIndex = 0
        Me.labelNombre.Text = "Nombre:"
        '
        'tabpageMermasHumedad
        '
        Me.tabpageMermasHumedad.Controls.Add(Me.datagridviewMermasHumedad)
        Me.tabpageMermasHumedad.Controls.Add(Me.toolstripMermasHumedad)
        Me.tabpageMermasHumedad.Location = New System.Drawing.Point(4, 25)
        Me.tabpageMermasHumedad.Name = "tabpageMermasHumedad"
        Me.tabpageMermasHumedad.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageMermasHumedad.Size = New System.Drawing.Size(514, 223)
        Me.tabpageMermasHumedad.TabIndex = 2
        Me.tabpageMermasHumedad.Text = "Mermas por humedad"
        Me.tabpageMermasHumedad.UseVisualStyleBackColor = True
        '
        'datagridviewMermasHumedad
        '
        Me.datagridviewMermasHumedad.AllowUserToAddRows = False
        Me.datagridviewMermasHumedad.AllowUserToDeleteRows = False
        Me.datagridviewMermasHumedad.AllowUserToResizeRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewMermasHumedad.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.datagridviewMermasHumedad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagridviewMermasHumedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewMermasHumedad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnMermasHumedadHumedad, Me.columnMermasHumedadMerma})
        Me.datagridviewMermasHumedad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewMermasHumedad.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewMermasHumedad.Location = New System.Drawing.Point(89, 3)
        Me.datagridviewMermasHumedad.MultiSelect = False
        Me.datagridviewMermasHumedad.Name = "datagridviewMermasHumedad"
        Me.datagridviewMermasHumedad.ReadOnly = True
        Me.datagridviewMermasHumedad.RowHeadersVisible = False
        Me.datagridviewMermasHumedad.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMermasHumedad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMermasHumedad.Size = New System.Drawing.Size(422, 217)
        Me.datagridviewMermasHumedad.TabIndex = 1
        '
        'columnMermasHumedadHumedad
        '
        Me.columnMermasHumedadHumedad.DataPropertyName = "Humedad"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N1"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.columnMermasHumedadHumedad.DefaultCellStyle = DataGridViewCellStyle9
        Me.columnMermasHumedadHumedad.HeaderText = "Humedad"
        Me.columnMermasHumedadHumedad.Name = "columnMermasHumedadHumedad"
        Me.columnMermasHumedadHumedad.ReadOnly = True
        Me.columnMermasHumedadHumedad.Width = 78
        '
        'columnMermasHumedadMerma
        '
        Me.columnMermasHumedadMerma.DataPropertyName = "Merma"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.columnMermasHumedadMerma.DefaultCellStyle = DataGridViewCellStyle10
        Me.columnMermasHumedadMerma.HeaderText = "Merma"
        Me.columnMermasHumedadMerma.Name = "columnMermasHumedadMerma"
        Me.columnMermasHumedadMerma.ReadOnly = True
        Me.columnMermasHumedadMerma.Width = 64
        '
        'toolstripMermasHumedad
        '
        Me.toolstripMermasHumedad.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripMermasHumedad.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMermasHumedad.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMermasHumedad.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonMermasHumedadAgregar, Me.buttonMermasHumedadEditar, Me.buttonMermasHumedadBorrar})
        Me.toolstripMermasHumedad.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripMermasHumedad.Location = New System.Drawing.Point(3, 3)
        Me.toolstripMermasHumedad.Name = "toolstripMermasHumedad"
        Me.toolstripMermasHumedad.Size = New System.Drawing.Size(86, 217)
        Me.toolstripMermasHumedad.TabIndex = 0
        '
        'buttonMermasHumedadAgregar
        '
        Me.buttonMermasHumedadAgregar.Image = My.Resources.Resources.ImageItemAgregar32
        Me.buttonMermasHumedadAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonMermasHumedadAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonMermasHumedadAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonMermasHumedadAgregar.Name = "buttonMermasHumedadAgregar"
        Me.buttonMermasHumedadAgregar.Size = New System.Drawing.Size(83, 36)
        Me.buttonMermasHumedadAgregar.Text = "Agregar"
        '
        'buttonMermasHumedadEditar
        '
        Me.buttonMermasHumedadEditar.Image = My.Resources.Resources.ImageItemEditar32
        Me.buttonMermasHumedadEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonMermasHumedadEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonMermasHumedadEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonMermasHumedadEditar.Name = "buttonMermasHumedadEditar"
        Me.buttonMermasHumedadEditar.Size = New System.Drawing.Size(83, 36)
        Me.buttonMermasHumedadEditar.Text = "Editar"
        '
        'buttonMermasHumedadBorrar
        '
        Me.buttonMermasHumedadBorrar.Image = My.Resources.Resources.ImageItemBorrar32
        Me.buttonMermasHumedadBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonMermasHumedadBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonMermasHumedadBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonMermasHumedadBorrar.Name = "buttonMermasHumedadBorrar"
        Me.buttonMermasHumedadBorrar.Size = New System.Drawing.Size(83, 36)
        Me.buttonMermasHumedadBorrar.Text = "Borrar"
        '
        'tabpagePlantas
        '
        Me.tabpagePlantas.Controls.Add(Me.datagridviewPlantas)
        Me.tabpagePlantas.Controls.Add(Me.toolstripPlantas)
        Me.tabpagePlantas.Location = New System.Drawing.Point(4, 25)
        Me.tabpagePlantas.Name = "tabpagePlantas"
        Me.tabpagePlantas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpagePlantas.Size = New System.Drawing.Size(514, 223)
        Me.tabpagePlantas.TabIndex = 3
        Me.tabpagePlantas.Text = "Plantas"
        Me.tabpagePlantas.UseVisualStyleBackColor = True
        '
        'datagridviewPlantas
        '
        Me.datagridviewPlantas.AllowUserToAddRows = False
        Me.datagridviewPlantas.AllowUserToDeleteRows = False
        Me.datagridviewPlantas.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewPlantas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.datagridviewPlantas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagridviewPlantas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewPlantas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnPlantasPlanta})
        Me.datagridviewPlantas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewPlantas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewPlantas.Location = New System.Drawing.Point(89, 3)
        Me.datagridviewPlantas.MultiSelect = False
        Me.datagridviewPlantas.Name = "datagridviewPlantas"
        Me.datagridviewPlantas.ReadOnly = True
        Me.datagridviewPlantas.RowHeadersVisible = False
        Me.datagridviewPlantas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewPlantas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewPlantas.Size = New System.Drawing.Size(422, 217)
        Me.datagridviewPlantas.TabIndex = 1
        '
        'columnPlantasPlanta
        '
        Me.columnPlantasPlanta.DataPropertyName = "Nombre"
        Me.columnPlantasPlanta.HeaderText = "Planta"
        Me.columnPlantasPlanta.Name = "columnPlantasPlanta"
        Me.columnPlantasPlanta.ReadOnly = True
        Me.columnPlantasPlanta.Width = 62
        '
        'toolstripPlantas
        '
        Me.toolstripPlantas.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripPlantas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripPlantas.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripPlantas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonPlantasAgregar, Me.buttonPlantasEditar, Me.buttonPlantasBorrar})
        Me.toolstripPlantas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripPlantas.Location = New System.Drawing.Point(3, 3)
        Me.toolstripPlantas.Name = "toolstripPlantas"
        Me.toolstripPlantas.Size = New System.Drawing.Size(86, 217)
        Me.toolstripPlantas.TabIndex = 0
        '
        'buttonPlantasAgregar
        '
        Me.buttonPlantasAgregar.Image = My.Resources.Resources.ImageItemAgregar32
        Me.buttonPlantasAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPlantasAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonPlantasAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonPlantasAgregar.Name = "buttonPlantasAgregar"
        Me.buttonPlantasAgregar.Size = New System.Drawing.Size(83, 36)
        Me.buttonPlantasAgregar.Text = "Agregar"
        '
        'buttonPlantasEditar
        '
        Me.buttonPlantasEditar.Image = My.Resources.Resources.ImageItemEditar32
        Me.buttonPlantasEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPlantasEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonPlantasEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonPlantasEditar.Name = "buttonPlantasEditar"
        Me.buttonPlantasEditar.Size = New System.Drawing.Size(83, 36)
        Me.buttonPlantasEditar.Text = "Editar"
        '
        'buttonPlantasBorrar
        '
        Me.buttonPlantasBorrar.Image = My.Resources.Resources.ImageItemBorrar32
        Me.buttonPlantasBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPlantasBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonPlantasBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonPlantasBorrar.Name = "buttonPlantasBorrar"
        Me.buttonPlantasBorrar.Size = New System.Drawing.Size(83, 36)
        Me.buttonPlantasBorrar.Text = "Borrar"
        '
        'tabpageCosechas
        '
        Me.tabpageCosechas.Controls.Add(Me.datagridviewCosechas)
        Me.tabpageCosechas.Controls.Add(Me.toolstripCosechas)
        Me.tabpageCosechas.Location = New System.Drawing.Point(4, 25)
        Me.tabpageCosechas.Name = "tabpageCosechas"
        Me.tabpageCosechas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageCosechas.Size = New System.Drawing.Size(514, 223)
        Me.tabpageCosechas.TabIndex = 4
        Me.tabpageCosechas.Text = "Cosechas"
        Me.tabpageCosechas.UseVisualStyleBackColor = True
        '
        'datagridviewCosechas
        '
        Me.datagridviewCosechas.AllowUserToAddRows = False
        Me.datagridviewCosechas.AllowUserToDeleteRows = False
        Me.datagridviewCosechas.AllowUserToResizeRows = False
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewCosechas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle12
        Me.datagridviewCosechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagridviewCosechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewCosechas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnCosechasCosecha, Me.columnCosechasInicio, Me.columnCosechasFin, Me.columnCosechasEsActivo})
        Me.datagridviewCosechas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewCosechas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewCosechas.Location = New System.Drawing.Point(89, 3)
        Me.datagridviewCosechas.MultiSelect = False
        Me.datagridviewCosechas.Name = "datagridviewCosechas"
        Me.datagridviewCosechas.ReadOnly = True
        Me.datagridviewCosechas.RowHeadersVisible = False
        Me.datagridviewCosechas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewCosechas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewCosechas.Size = New System.Drawing.Size(422, 217)
        Me.datagridviewCosechas.TabIndex = 1
        '
        'columnCosechasCosecha
        '
        Me.columnCosechasCosecha.DataPropertyName = "Nombre"
        Me.columnCosechasCosecha.HeaderText = "Cosecha"
        Me.columnCosechasCosecha.Name = "columnCosechasCosecha"
        Me.columnCosechasCosecha.ReadOnly = True
        Me.columnCosechasCosecha.Width = 74
        '
        'columnCosechasInicio
        '
        Me.columnCosechasInicio.DataPropertyName = "Inicio"
        DataGridViewCellStyle13.Format = "d"
        Me.columnCosechasInicio.DefaultCellStyle = DataGridViewCellStyle13
        Me.columnCosechasInicio.HeaderText = "Fecha inicio"
        Me.columnCosechasInicio.Name = "columnCosechasInicio"
        Me.columnCosechasInicio.ReadOnly = True
        Me.columnCosechasInicio.Width = 89
        '
        'columnCosechasFin
        '
        Me.columnCosechasFin.DataPropertyName = "Fin"
        DataGridViewCellStyle14.Format = "d"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.columnCosechasFin.DefaultCellStyle = DataGridViewCellStyle14
        Me.columnCosechasFin.HeaderText = "Fecha fin"
        Me.columnCosechasFin.Name = "columnCosechasFin"
        Me.columnCosechasFin.ReadOnly = True
        Me.columnCosechasFin.Width = 76
        '
        'columnCosechasEsActivo
        '
        Me.columnCosechasEsActivo.DataPropertyName = "EsActivo"
        Me.columnCosechasEsActivo.HeaderText = "Activo"
        Me.columnCosechasEsActivo.Name = "columnCosechasEsActivo"
        Me.columnCosechasEsActivo.ReadOnly = True
        Me.columnCosechasEsActivo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.columnCosechasEsActivo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.columnCosechasEsActivo.Width = 62
        '
        'toolstripCosechas
        '
        Me.toolstripCosechas.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripCosechas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripCosechas.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripCosechas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCosechasAgregar, Me.buttonCosechasEditar, Me.buttonCosechasBorrar})
        Me.toolstripCosechas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripCosechas.Location = New System.Drawing.Point(3, 3)
        Me.toolstripCosechas.Name = "toolstripCosechas"
        Me.toolstripCosechas.Size = New System.Drawing.Size(86, 217)
        Me.toolstripCosechas.TabIndex = 0
        '
        'buttonCosechasAgregar
        '
        Me.buttonCosechasAgregar.Image = My.Resources.Resources.ImageItemAgregar32
        Me.buttonCosechasAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonCosechasAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCosechasAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCosechasAgregar.Name = "buttonCosechasAgregar"
        Me.buttonCosechasAgregar.Size = New System.Drawing.Size(83, 36)
        Me.buttonCosechasAgregar.Text = "Agregar"
        '
        'buttonCosechasEditar
        '
        Me.buttonCosechasEditar.Image = My.Resources.Resources.ImageItemEditar32
        Me.buttonCosechasEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonCosechasEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCosechasEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCosechasEditar.Name = "buttonCosechasEditar"
        Me.buttonCosechasEditar.Size = New System.Drawing.Size(83, 36)
        Me.buttonCosechasEditar.Text = "Editar"
        '
        'buttonCosechasBorrar
        '
        Me.buttonCosechasBorrar.Image = My.Resources.Resources.ImageItemBorrar32
        Me.buttonCosechasBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonCosechasBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCosechasBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCosechasBorrar.Name = "buttonCosechasBorrar"
        Me.buttonCosechasBorrar.Size = New System.Drawing.Size(83, 36)
        Me.buttonCosechasBorrar.Text = "Borrar"
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelID)
        Me.tabpageNotasAuditoria.Controls.Add(Me.checkboxEsActivo)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxID)
        Me.tabpageNotasAuditoria.Controls.Add(labelEsActivo)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxUsuarioCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxFechaHoraCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(labelModificacion)
        Me.tabpageNotasAuditoria.Controls.Add(labelCreacion)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxNotas)
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelNotas)
        Me.tabpageNotasAuditoria.Location = New System.Drawing.Point(4, 25)
        Me.tabpageNotasAuditoria.Name = "tabpageNotasAuditoria"
        Me.tabpageNotasAuditoria.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(514, 223)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'labelID
        '
        Me.labelID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelID.AutoSize = True
        Me.labelID.Location = New System.Drawing.Point(10, 148)
        Me.labelID.Name = "labelID"
        Me.labelID.Size = New System.Drawing.Size(21, 13)
        Me.labelID.TabIndex = 4
        Me.labelID.Text = "ID:"
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(114, 122)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 3
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'textboxID
        '
        Me.textboxID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxID.Location = New System.Drawing.Point(114, 145)
        Me.textboxID.MaxLength = 10
        Me.textboxID.Name = "textboxID"
        Me.textboxID.ReadOnly = True
        Me.textboxID.Size = New System.Drawing.Size(72, 20)
        Me.textboxID.TabIndex = 5
        Me.textboxID.TabStop = False
        Me.textboxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(246, 197)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 11
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(246, 171)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 8
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(114, 197)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(126, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 10
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(114, 171)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(126, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 7
        '
        'textboxNotas
        '
        Me.textboxNotas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxNotas.Location = New System.Drawing.Point(114, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(391, 110)
        Me.textboxNotas.TabIndex = 1
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(6, 9)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 0
        Me.labelNotas.Text = "Notas:"
        '
        'DoubleTextBoxMermaVolatil
        '
        Me.DoubleTextBoxMermaVolatil.AllowNull = True
        Me.DoubleTextBoxMermaVolatil.BeforeTouchSize = New System.Drawing.Size(33, 20)
        Me.DoubleTextBoxMermaVolatil.DoubleValue = 0R
        Me.DoubleTextBoxMermaVolatil.Location = New System.Drawing.Point(152, 45)
        Me.DoubleTextBoxMermaVolatil.MaxValue = 1.0R
        Me.DoubleTextBoxMermaVolatil.MinValue = 0R
        Me.DoubleTextBoxMermaVolatil.Name = "DoubleTextBoxMermaVolatil"
        Me.DoubleTextBoxMermaVolatil.Size = New System.Drawing.Size(33, 20)
        Me.DoubleTextBoxMermaVolatil.TabIndex = 3
        Me.DoubleTextBoxMermaVolatil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DoubleTextBoxMermaHumedadBase
        '
        Me.DoubleTextBoxMermaHumedadBase.AllowNull = True
        Me.DoubleTextBoxMermaHumedadBase.BeforeTouchSize = New System.Drawing.Size(33, 20)
        Me.DoubleTextBoxMermaHumedadBase.DoubleValue = 0R
        Me.DoubleTextBoxMermaHumedadBase.Location = New System.Drawing.Point(152, 71)
        Me.DoubleTextBoxMermaHumedadBase.MaxValue = 50.0R
        Me.DoubleTextBoxMermaHumedadBase.MinValue = 9.0R
        Me.DoubleTextBoxMermaHumedadBase.Name = "DoubleTextBoxMermaHumedadBase"
        Me.DoubleTextBoxMermaHumedadBase.NumberDecimalDigits = 1
        Me.DoubleTextBoxMermaHumedadBase.Size = New System.Drawing.Size(33, 20)
        Me.DoubleTextBoxMermaHumedadBase.TabIndex = 5
        Me.DoubleTextBoxMermaHumedadBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DoubleTextBoxMermaHumedadManipuleo
        '
        Me.DoubleTextBoxMermaHumedadManipuleo.AllowNull = True
        Me.DoubleTextBoxMermaHumedadManipuleo.BeforeTouchSize = New System.Drawing.Size(33, 20)
        Me.DoubleTextBoxMermaHumedadManipuleo.DoubleValue = 0R
        Me.DoubleTextBoxMermaHumedadManipuleo.Location = New System.Drawing.Point(152, 97)
        Me.DoubleTextBoxMermaHumedadManipuleo.MaxValue = 1.0R
        Me.DoubleTextBoxMermaHumedadManipuleo.MinValue = 0R
        Me.DoubleTextBoxMermaHumedadManipuleo.Name = "DoubleTextBoxMermaHumedadManipuleo"
        Me.DoubleTextBoxMermaHumedadManipuleo.Size = New System.Drawing.Size(33, 20)
        Me.DoubleTextBoxMermaHumedadManipuleo.TabIndex = 7
        Me.DoubleTextBoxMermaHumedadManipuleo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'formProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 306)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formProducto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Producto"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        Me.tabpageMermasHumedad.ResumeLayout(False)
        Me.tabpageMermasHumedad.PerformLayout()
        CType(Me.datagridviewMermasHumedad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripMermasHumedad.ResumeLayout(False)
        Me.toolstripMermasHumedad.PerformLayout()
        Me.tabpagePlantas.ResumeLayout(False)
        Me.tabpagePlantas.PerformLayout()
        CType(Me.datagridviewPlantas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripPlantas.ResumeLayout(False)
        Me.toolstripPlantas.PerformLayout()
        Me.tabpageCosechas.ResumeLayout(False)
        Me.tabpageCosechas.PerformLayout()
        CType(Me.datagridviewCosechas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripCosechas.ResumeLayout(False)
        Me.toolstripCosechas.PerformLayout()
        Me.tabpageNotasAuditoria.ResumeLayout(False)
        Me.tabpageNotasAuditoria.PerformLayout()
        CType(Me.DoubleTextBoxMermaVolatil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoubleTextBoxMermaHumedadBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoubleTextBoxMermaHumedadManipuleo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textboxNombre As System.Windows.Forms.TextBox
    Friend WithEvents labelNombre As System.Windows.Forms.Label
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents tabcontrolMain As System.Windows.Forms.TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents labelID As System.Windows.Forms.Label
    Friend WithEvents textboxID As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents labelUsoFrecuente As Label
    Friend WithEvents labelUtilizaCosecha As Label
    Friend WithEvents labelUtilizaPlanta As Label
    Friend WithEvents labelMermaVolátil As Label
    Friend WithEvents labelOrden As Label
    Friend WithEvents checkboxUtilizaCosecha As CheckBox
    Friend WithEvents checkboxUsoFrecuente As CheckBox
    Friend WithEvents checkboxUtilizaPlanta As CheckBox
    Friend WithEvents tabpageMermasHumedad As TabPage
    Friend WithEvents datagridviewMermasHumedad As DataGridView
    Friend WithEvents toolstripMermasHumedad As ToolStrip
    Friend WithEvents buttonMermasHumedadAgregar As ToolStripButton
    Friend WithEvents buttonMermasHumedadEditar As ToolStripButton
    Friend WithEvents buttonMermasHumedadBorrar As ToolStripButton
    Friend WithEvents LabelMermaHumedadManipuleo As Label
    Friend WithEvents LabelMermaHumedadBase As Label
    Friend WithEvents ComboBoxTicketPesada_IDReporte As ComboBox
    Friend WithEvents tabpagePlantas As TabPage
    Friend WithEvents tabpageCosechas As TabPage
    Friend WithEvents datagridviewPlantas As DataGridView
    Friend WithEvents toolstripPlantas As ToolStrip
    Friend WithEvents buttonPlantasAgregar As ToolStripButton
    Friend WithEvents buttonPlantasEditar As ToolStripButton
    Friend WithEvents buttonPlantasBorrar As ToolStripButton
    Friend WithEvents datagridviewCosechas As DataGridView
    Friend WithEvents toolstripCosechas As ToolStrip
    Friend WithEvents buttonCosechasAgregar As ToolStripButton
    Friend WithEvents buttonCosechasEditar As ToolStripButton
    Friend WithEvents buttonCosechasBorrar As ToolStripButton
    Friend WithEvents columnMermasHumedadHumedad As DataGridViewTextBoxColumn
    Friend WithEvents columnMermasHumedadMerma As DataGridViewTextBoxColumn
    Friend WithEvents columnPlantasPlanta As DataGridViewTextBoxColumn
    Friend WithEvents columnCosechasCosecha As DataGridViewTextBoxColumn
    Friend WithEvents columnCosechasInicio As DataGridViewTextBoxColumn
    Friend WithEvents columnCosechasFin As DataGridViewTextBoxColumn
    Friend WithEvents columnCosechasEsActivo As DataGridViewCheckBoxColumn
    Friend WithEvents DoubleTextBoxMermaHumedadManipuleo As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents DoubleTextBoxMermaHumedadBase As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents DoubleTextBoxMermaVolatil As Syncfusion.Windows.Forms.Tools.DoubleTextBox
End Class
