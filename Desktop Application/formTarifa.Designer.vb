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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.groupboxIndices = New System.Windows.Forms.GroupBox()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.comboboxCosecha = New System.Windows.Forms.ComboBox()
        Me.updownIndice = New System.Windows.Forms.NumericUpDown()
        Me.labelCosecha = New System.Windows.Forms.Label()
        Me.labelIndice = New System.Windows.Forms.Label()
        Me.comboboxProducto = New System.Windows.Forms.ComboBox()
        Me.labelProducto = New System.Windows.Forms.Label()
        Me.tabpageSecadoEscala = New System.Windows.Forms.TabPage()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.groupboxIndices.SuspendLayout()
        CType(Me.updownIndice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(651, 39)
        Me.toolstripMain.TabIndex = 2
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
        Me.tabcontrolMain.Controls.Add(Me.tabpageSecadoEscala)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(627, 311)
        Me.tabcontrolMain.TabIndex = 3
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabpageGeneral.Controls.Add(Me.GroupBox1)
        Me.tabpageGeneral.Controls.Add(Me.groupboxIndices)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(619, 282)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.datetimepickerFechaHasta)
        Me.GroupBox1.Controls.Add(Me.labelFechaHasta)
        Me.GroupBox1.Controls.Add(Me.datetimepickerFechaDesde)
        Me.GroupBox1.Controls.Add(Me.labelFechaDesde)
        Me.GroupBox1.Controls.Add(Me.labelOrigen)
        Me.GroupBox1.Controls.Add(Me.comboboxOrigen)
        Me.GroupBox1.Controls.Add(Me.comboboxEntidad)
        Me.GroupBox1.Controls.Add(Me.labelEntidad)
        Me.GroupBox1.Controls.Add(Me.comboboxPlanta)
        Me.GroupBox1.Controls.Add(Me.labelPlanta)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 88)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(601, 106)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opcionales:"
        '
        'datetimepickerFechaHasta
        '
        Me.datetimepickerFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaHasta.Location = New System.Drawing.Point(413, 43)
        Me.datetimepickerFechaHasta.Name = "datetimepickerFechaHasta"
        Me.datetimepickerFechaHasta.ShowCheckBox = True
        Me.datetimepickerFechaHasta.Size = New System.Drawing.Size(132, 20)
        Me.datetimepickerFechaHasta.TabIndex = 16
        '
        'labelFechaHasta
        '
        Me.labelFechaHasta.AutoSize = True
        Me.labelFechaHasta.Location = New System.Drawing.Point(327, 47)
        Me.labelFechaHasta.Name = "labelFechaHasta"
        Me.labelFechaHasta.Size = New System.Drawing.Size(69, 13)
        Me.labelFechaHasta.TabIndex = 15
        Me.labelFechaHasta.Text = "Fecha hasta:"
        '
        'datetimepickerFechaDesde
        '
        Me.datetimepickerFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaDesde.Location = New System.Drawing.Point(413, 18)
        Me.datetimepickerFechaDesde.Name = "datetimepickerFechaDesde"
        Me.datetimepickerFechaDesde.ShowCheckBox = True
        Me.datetimepickerFechaDesde.Size = New System.Drawing.Size(132, 20)
        Me.datetimepickerFechaDesde.TabIndex = 14
        '
        'labelFechaDesde
        '
        Me.labelFechaDesde.AutoSize = True
        Me.labelFechaDesde.Location = New System.Drawing.Point(327, 22)
        Me.labelFechaDesde.Name = "labelFechaDesde"
        Me.labelFechaDesde.Size = New System.Drawing.Size(72, 13)
        Me.labelFechaDesde.TabIndex = 13
        Me.labelFechaDesde.Text = "Fecha desde:"
        '
        'labelOrigen
        '
        Me.labelOrigen.AutoSize = True
        Me.labelOrigen.Location = New System.Drawing.Point(6, 76)
        Me.labelOrigen.Name = "labelOrigen"
        Me.labelOrigen.Size = New System.Drawing.Size(41, 13)
        Me.labelOrigen.TabIndex = 11
        Me.labelOrigen.Text = "Origen:"
        '
        'comboboxOrigen
        '
        Me.comboboxOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxOrigen.FormattingEnabled = True
        Me.comboboxOrigen.Location = New System.Drawing.Point(58, 73)
        Me.comboboxOrigen.Name = "comboboxOrigen"
        Me.comboboxOrigen.Size = New System.Drawing.Size(209, 21)
        Me.comboboxOrigen.TabIndex = 12
        '
        'comboboxEntidad
        '
        Me.comboboxEntidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxEntidad.FormattingEnabled = True
        Me.comboboxEntidad.Location = New System.Drawing.Point(58, 46)
        Me.comboboxEntidad.Name = "comboboxEntidad"
        Me.comboboxEntidad.Size = New System.Drawing.Size(233, 21)
        Me.comboboxEntidad.TabIndex = 10
        '
        'labelEntidad
        '
        Me.labelEntidad.AutoSize = True
        Me.labelEntidad.Location = New System.Drawing.Point(6, 49)
        Me.labelEntidad.Name = "labelEntidad"
        Me.labelEntidad.Size = New System.Drawing.Size(46, 13)
        Me.labelEntidad.TabIndex = 9
        Me.labelEntidad.Text = "Entidad:"
        '
        'comboboxPlanta
        '
        Me.comboboxPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxPlanta.FormattingEnabled = True
        Me.comboboxPlanta.Location = New System.Drawing.Point(58, 19)
        Me.comboboxPlanta.Name = "comboboxPlanta"
        Me.comboboxPlanta.Size = New System.Drawing.Size(233, 21)
        Me.comboboxPlanta.TabIndex = 8
        '
        'labelPlanta
        '
        Me.labelPlanta.AutoSize = True
        Me.labelPlanta.Location = New System.Drawing.Point(6, 22)
        Me.labelPlanta.Name = "labelPlanta"
        Me.labelPlanta.Size = New System.Drawing.Size(40, 13)
        Me.labelPlanta.TabIndex = 7
        Me.labelPlanta.Text = "Planta:"
        '
        'groupboxIndices
        '
        Me.groupboxIndices.Controls.Add(Me.textboxNombre)
        Me.groupboxIndices.Controls.Add(Me.labelNombre)
        Me.groupboxIndices.Controls.Add(Me.comboboxCosecha)
        Me.groupboxIndices.Controls.Add(Me.updownIndice)
        Me.groupboxIndices.Controls.Add(Me.labelCosecha)
        Me.groupboxIndices.Controls.Add(Me.labelIndice)
        Me.groupboxIndices.Controls.Add(Me.comboboxProducto)
        Me.groupboxIndices.Controls.Add(Me.labelProducto)
        Me.groupboxIndices.Location = New System.Drawing.Point(6, 6)
        Me.groupboxIndices.Name = "groupboxIndices"
        Me.groupboxIndices.Size = New System.Drawing.Size(601, 76)
        Me.groupboxIndices.TabIndex = 23
        Me.groupboxIndices.TabStop = False
        Me.groupboxIndices.Text = "Requeridos:"
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(67, 46)
        Me.textboxNombre.MaxLength = 50
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(257, 20)
        Me.textboxNombre.TabIndex = 24
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(6, 49)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(47, 13)
        Me.labelNombre.TabIndex = 23
        Me.labelNombre.Text = "Nombre:"
        '
        'comboboxCosecha
        '
        Me.comboboxCosecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCosecha.FormattingEnabled = True
        Me.comboboxCosecha.Location = New System.Drawing.Point(67, 19)
        Me.comboboxCosecha.Name = "comboboxCosecha"
        Me.comboboxCosecha.Size = New System.Drawing.Size(121, 21)
        Me.comboboxCosecha.TabIndex = 13
        '
        'updownIndice
        '
        Me.updownIndice.Location = New System.Drawing.Point(543, 20)
        Me.updownIndice.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.updownIndice.Name = "updownIndice"
        Me.updownIndice.Size = New System.Drawing.Size(42, 20)
        Me.updownIndice.TabIndex = 22
        Me.updownIndice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelCosecha
        '
        Me.labelCosecha.AutoSize = True
        Me.labelCosecha.Location = New System.Drawing.Point(6, 22)
        Me.labelCosecha.Name = "labelCosecha"
        Me.labelCosecha.Size = New System.Drawing.Size(52, 13)
        Me.labelCosecha.TabIndex = 12
        Me.labelCosecha.Text = "Cosecha:"
        '
        'labelIndice
        '
        Me.labelIndice.AutoSize = True
        Me.labelIndice.Location = New System.Drawing.Point(498, 22)
        Me.labelIndice.Name = "labelIndice"
        Me.labelIndice.Size = New System.Drawing.Size(39, 13)
        Me.labelIndice.TabIndex = 21
        Me.labelIndice.Text = "Índice:"
        '
        'comboboxProducto
        '
        Me.comboboxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxProducto.FormattingEnabled = True
        Me.comboboxProducto.Location = New System.Drawing.Point(270, 19)
        Me.comboboxProducto.Name = "comboboxProducto"
        Me.comboboxProducto.Size = New System.Drawing.Size(209, 21)
        Me.comboboxProducto.TabIndex = 15
        '
        'labelProducto
        '
        Me.labelProducto.AutoSize = True
        Me.labelProducto.Location = New System.Drawing.Point(211, 22)
        Me.labelProducto.Name = "labelProducto"
        Me.labelProducto.Size = New System.Drawing.Size(53, 13)
        Me.labelProducto.TabIndex = 14
        Me.labelProducto.Text = "Producto:"
        '
        'tabpageSecadoEscala
        '
        Me.tabpageSecadoEscala.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabpageSecadoEscala.Location = New System.Drawing.Point(4, 25)
        Me.tabpageSecadoEscala.Name = "tabpageSecadoEscala"
        Me.tabpageSecadoEscala.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageSecadoEscala.Size = New System.Drawing.Size(619, 282)
        Me.tabpageSecadoEscala.TabIndex = 1
        Me.tabpageSecadoEscala.Text = "Escalas de Secado"
        Me.tabpageSecadoEscala.UseVisualStyleBackColor = True
        '
        'formTarifa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 365)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.groupboxIndices.ResumeLayout(False)
        Me.groupboxIndices.PerformLayout()
        CType(Me.updownIndice, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents groupboxIndices As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
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
End Class
