<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPesadasResumen
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
        Me.ComboBoxCosecha = New System.Windows.Forms.ComboBox()
        Me.labelCosecha = New System.Windows.Forms.Label()
        Me.ComboBoxPlanta = New System.Windows.Forms.ComboBox()
        Me.labelPlanta = New System.Windows.Forms.Label()
        Me.labelProducto = New System.Windows.Forms.Label()
        Me.ComboBoxProducto = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTitular = New System.Windows.Forms.ComboBox()
        Me.labelTitular = New System.Windows.Forms.Label()
        Me.LabelTipo = New System.Windows.Forms.Label()
        Me.CheckBoxTipoEntradas = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTipoSalidas = New System.Windows.Forms.CheckBox()
        Me.GroupBoxResumen = New System.Windows.Forms.GroupBox()
        Me.LabelTotales = New System.Windows.Forms.Label()
        Me.TextBoxKilogramosTotal = New System.Windows.Forms.TextBox()
        Me.LabelSalidas = New System.Windows.Forms.Label()
        Me.TextBoxKilogramosSalidas = New System.Windows.Forms.TextBox()
        Me.LabelEntradasNetas = New System.Windows.Forms.Label()
        Me.TextBoxKilogramosEntradasNetas = New System.Windows.Forms.TextBox()
        Me.LabelEntradasBrutas = New System.Windows.Forms.Label()
        Me.TextBoxKilogramosEntradasBrutas = New System.Windows.Forms.TextBox()
        Me.LabelFechaDesde = New System.Windows.Forms.Label()
        Me.DateTimePickerFechaDesde = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFechaHasta = New System.Windows.Forms.DateTimePicker()
        Me.LabelFechaHasta = New System.Windows.Forms.Label()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.LabelKilogramos = New System.Windows.Forms.Label()
        Me.LabelCantidad = New System.Windows.Forms.Label()
        Me.TextBoxCantidadEntradas = New System.Windows.Forms.TextBox()
        Me.TextBoxCantidadSalidas = New System.Windows.Forms.TextBox()
        Me.TextBoxCantidadTotal = New System.Windows.Forms.TextBox()
        Me.GroupBoxResumen.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComboBoxCosecha
        '
        Me.ComboBoxCosecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCosecha.FormattingEnabled = True
        Me.ComboBoxCosecha.Location = New System.Drawing.Point(90, 39)
        Me.ComboBoxCosecha.Name = "ComboBoxCosecha"
        Me.ComboBoxCosecha.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCosecha.TabIndex = 3
        '
        'labelCosecha
        '
        Me.labelCosecha.AutoSize = True
        Me.labelCosecha.Location = New System.Drawing.Point(12, 42)
        Me.labelCosecha.Name = "labelCosecha"
        Me.labelCosecha.Size = New System.Drawing.Size(52, 13)
        Me.labelCosecha.TabIndex = 2
        Me.labelCosecha.Text = "Cosecha:"
        '
        'ComboBoxPlanta
        '
        Me.ComboBoxPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPlanta.FormattingEnabled = True
        Me.ComboBoxPlanta.Location = New System.Drawing.Point(90, 66)
        Me.ComboBoxPlanta.Name = "ComboBoxPlanta"
        Me.ComboBoxPlanta.Size = New System.Drawing.Size(255, 21)
        Me.ComboBoxPlanta.TabIndex = 5
        '
        'labelPlanta
        '
        Me.labelPlanta.AutoSize = True
        Me.labelPlanta.Location = New System.Drawing.Point(12, 69)
        Me.labelPlanta.Name = "labelPlanta"
        Me.labelPlanta.Size = New System.Drawing.Size(40, 13)
        Me.labelPlanta.TabIndex = 4
        Me.labelPlanta.Text = "Planta:"
        '
        'labelProducto
        '
        Me.labelProducto.AutoSize = True
        Me.labelProducto.Location = New System.Drawing.Point(12, 15)
        Me.labelProducto.Name = "labelProducto"
        Me.labelProducto.Size = New System.Drawing.Size(53, 13)
        Me.labelProducto.TabIndex = 0
        Me.labelProducto.Text = "Producto:"
        '
        'ComboBoxProducto
        '
        Me.ComboBoxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProducto.FormattingEnabled = True
        Me.ComboBoxProducto.Location = New System.Drawing.Point(90, 12)
        Me.ComboBoxProducto.Name = "ComboBoxProducto"
        Me.ComboBoxProducto.Size = New System.Drawing.Size(255, 21)
        Me.ComboBoxProducto.TabIndex = 1
        '
        'ComboBoxTitular
        '
        Me.ComboBoxTitular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTitular.FormattingEnabled = True
        Me.ComboBoxTitular.Location = New System.Drawing.Point(90, 93)
        Me.ComboBoxTitular.Name = "ComboBoxTitular"
        Me.ComboBoxTitular.Size = New System.Drawing.Size(255, 21)
        Me.ComboBoxTitular.TabIndex = 7
        '
        'labelTitular
        '
        Me.labelTitular.AutoSize = True
        Me.labelTitular.Location = New System.Drawing.Point(12, 96)
        Me.labelTitular.Name = "labelTitular"
        Me.labelTitular.Size = New System.Drawing.Size(39, 13)
        Me.labelTitular.TabIndex = 6
        Me.labelTitular.Text = "Titular:"
        '
        'LabelTipo
        '
        Me.LabelTipo.AutoSize = True
        Me.LabelTipo.Location = New System.Drawing.Point(12, 123)
        Me.LabelTipo.Name = "LabelTipo"
        Me.LabelTipo.Size = New System.Drawing.Size(31, 13)
        Me.LabelTipo.TabIndex = 8
        Me.LabelTipo.Text = "Tipo:"
        '
        'CheckBoxTipoEntradas
        '
        Me.CheckBoxTipoEntradas.AutoSize = True
        Me.CheckBoxTipoEntradas.Checked = True
        Me.CheckBoxTipoEntradas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxTipoEntradas.Location = New System.Drawing.Point(90, 122)
        Me.CheckBoxTipoEntradas.Name = "CheckBoxTipoEntradas"
        Me.CheckBoxTipoEntradas.Size = New System.Drawing.Size(68, 17)
        Me.CheckBoxTipoEntradas.TabIndex = 9
        Me.CheckBoxTipoEntradas.Text = "Entradas"
        Me.CheckBoxTipoEntradas.UseVisualStyleBackColor = True
        '
        'CheckBoxTipoSalidas
        '
        Me.CheckBoxTipoSalidas.AutoSize = True
        Me.CheckBoxTipoSalidas.Checked = True
        Me.CheckBoxTipoSalidas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxTipoSalidas.Location = New System.Drawing.Point(164, 122)
        Me.CheckBoxTipoSalidas.Name = "CheckBoxTipoSalidas"
        Me.CheckBoxTipoSalidas.Size = New System.Drawing.Size(60, 17)
        Me.CheckBoxTipoSalidas.TabIndex = 10
        Me.CheckBoxTipoSalidas.Text = "Salidas"
        Me.CheckBoxTipoSalidas.UseVisualStyleBackColor = True
        '
        'GroupBoxResumen
        '
        Me.GroupBoxResumen.Controls.Add(Me.TextBoxCantidadTotal)
        Me.GroupBoxResumen.Controls.Add(Me.TextBoxCantidadSalidas)
        Me.GroupBoxResumen.Controls.Add(Me.TextBoxCantidadEntradas)
        Me.GroupBoxResumen.Controls.Add(Me.LabelCantidad)
        Me.GroupBoxResumen.Controls.Add(Me.LabelKilogramos)
        Me.GroupBoxResumen.Controls.Add(Me.LabelTotales)
        Me.GroupBoxResumen.Controls.Add(Me.TextBoxKilogramosTotal)
        Me.GroupBoxResumen.Controls.Add(Me.LabelSalidas)
        Me.GroupBoxResumen.Controls.Add(Me.TextBoxKilogramosSalidas)
        Me.GroupBoxResumen.Controls.Add(Me.LabelEntradasNetas)
        Me.GroupBoxResumen.Controls.Add(Me.TextBoxKilogramosEntradasNetas)
        Me.GroupBoxResumen.Controls.Add(Me.LabelEntradasBrutas)
        Me.GroupBoxResumen.Controls.Add(Me.TextBoxKilogramosEntradasBrutas)
        Me.GroupBoxResumen.Location = New System.Drawing.Point(49, 231)
        Me.GroupBoxResumen.Name = "GroupBoxResumen"
        Me.GroupBoxResumen.Size = New System.Drawing.Size(262, 146)
        Me.GroupBoxResumen.TabIndex = 16
        Me.GroupBoxResumen.TabStop = False
        '
        'LabelTotales
        '
        Me.LabelTotales.AutoSize = True
        Me.LabelTotales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotales.Location = New System.Drawing.Point(6, 115)
        Me.LabelTotales.Name = "LabelTotales"
        Me.LabelTotales.Size = New System.Drawing.Size(53, 13)
        Me.LabelTotales.TabIndex = 6
        Me.LabelTotales.Text = "Totales:"
        '
        'TextBoxKilogramosTotal
        '
        Me.TextBoxKilogramosTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxKilogramosTotal.Location = New System.Drawing.Point(96, 112)
        Me.TextBoxKilogramosTotal.Name = "TextBoxKilogramosTotal"
        Me.TextBoxKilogramosTotal.ReadOnly = True
        Me.TextBoxKilogramosTotal.Size = New System.Drawing.Size(82, 20)
        Me.TextBoxKilogramosTotal.TabIndex = 7
        Me.TextBoxKilogramosTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelSalidas
        '
        Me.LabelSalidas.AutoSize = True
        Me.LabelSalidas.Location = New System.Drawing.Point(6, 89)
        Me.LabelSalidas.Name = "LabelSalidas"
        Me.LabelSalidas.Size = New System.Drawing.Size(44, 13)
        Me.LabelSalidas.TabIndex = 4
        Me.LabelSalidas.Text = "Salidas:"
        '
        'TextBoxKilogramosSalidas
        '
        Me.TextBoxKilogramosSalidas.Location = New System.Drawing.Point(96, 86)
        Me.TextBoxKilogramosSalidas.Name = "TextBoxKilogramosSalidas"
        Me.TextBoxKilogramosSalidas.ReadOnly = True
        Me.TextBoxKilogramosSalidas.Size = New System.Drawing.Size(82, 20)
        Me.TextBoxKilogramosSalidas.TabIndex = 5
        Me.TextBoxKilogramosSalidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelEntradasNetas
        '
        Me.LabelEntradasNetas.AutoSize = True
        Me.LabelEntradasNetas.Location = New System.Drawing.Point(6, 63)
        Me.LabelEntradasNetas.Name = "LabelEntradasNetas"
        Me.LabelEntradasNetas.Size = New System.Drawing.Size(81, 13)
        Me.LabelEntradasNetas.TabIndex = 2
        Me.LabelEntradasNetas.Text = "Entradas netas:"
        '
        'TextBoxKilogramosEntradasNetas
        '
        Me.TextBoxKilogramosEntradasNetas.Location = New System.Drawing.Point(96, 60)
        Me.TextBoxKilogramosEntradasNetas.Name = "TextBoxKilogramosEntradasNetas"
        Me.TextBoxKilogramosEntradasNetas.ReadOnly = True
        Me.TextBoxKilogramosEntradasNetas.Size = New System.Drawing.Size(82, 20)
        Me.TextBoxKilogramosEntradasNetas.TabIndex = 3
        Me.TextBoxKilogramosEntradasNetas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelEntradasBrutas
        '
        Me.LabelEntradasBrutas.AutoSize = True
        Me.LabelEntradasBrutas.Location = New System.Drawing.Point(6, 37)
        Me.LabelEntradasBrutas.Name = "LabelEntradasBrutas"
        Me.LabelEntradasBrutas.Size = New System.Drawing.Size(84, 13)
        Me.LabelEntradasBrutas.TabIndex = 0
        Me.LabelEntradasBrutas.Text = "Entradas brutas:"
        '
        'TextBoxKilogramosEntradasBrutas
        '
        Me.TextBoxKilogramosEntradasBrutas.Location = New System.Drawing.Point(96, 34)
        Me.TextBoxKilogramosEntradasBrutas.Name = "TextBoxKilogramosEntradasBrutas"
        Me.TextBoxKilogramosEntradasBrutas.ReadOnly = True
        Me.TextBoxKilogramosEntradasBrutas.Size = New System.Drawing.Size(82, 20)
        Me.TextBoxKilogramosEntradasBrutas.TabIndex = 1
        Me.TextBoxKilogramosEntradasBrutas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelFechaDesde
        '
        Me.LabelFechaDesde.AutoSize = True
        Me.LabelFechaDesde.Location = New System.Drawing.Point(12, 150)
        Me.LabelFechaDesde.Name = "LabelFechaDesde"
        Me.LabelFechaDesde.Size = New System.Drawing.Size(72, 13)
        Me.LabelFechaDesde.TabIndex = 11
        Me.LabelFechaDesde.Text = "Fecha desde:"
        '
        'DateTimePickerFechaDesde
        '
        Me.DateTimePickerFechaDesde.Checked = False
        Me.DateTimePickerFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFechaDesde.Location = New System.Drawing.Point(90, 147)
        Me.DateTimePickerFechaDesde.MaxDate = New Date(2200, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerFechaDesde.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerFechaDesde.Name = "DateTimePickerFechaDesde"
        Me.DateTimePickerFechaDesde.ShowCheckBox = True
        Me.DateTimePickerFechaDesde.Size = New System.Drawing.Size(132, 20)
        Me.DateTimePickerFechaDesde.TabIndex = 12
        '
        'DateTimePickerFechaHasta
        '
        Me.DateTimePickerFechaHasta.Checked = False
        Me.DateTimePickerFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFechaHasta.Location = New System.Drawing.Point(90, 173)
        Me.DateTimePickerFechaHasta.MaxDate = New Date(2200, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerFechaHasta.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerFechaHasta.Name = "DateTimePickerFechaHasta"
        Me.DateTimePickerFechaHasta.ShowCheckBox = True
        Me.DateTimePickerFechaHasta.Size = New System.Drawing.Size(132, 20)
        Me.DateTimePickerFechaHasta.TabIndex = 14
        '
        'LabelFechaHasta
        '
        Me.LabelFechaHasta.AutoSize = True
        Me.LabelFechaHasta.Location = New System.Drawing.Point(12, 176)
        Me.LabelFechaHasta.Name = "LabelFechaHasta"
        Me.LabelFechaHasta.Size = New System.Drawing.Size(69, 13)
        Me.LabelFechaHasta.TabIndex = 13
        Me.LabelFechaHasta.Text = "Fecha hasta:"
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.Location = New System.Drawing.Point(90, 199)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(134, 26)
        Me.ButtonCalcular.TabIndex = 15
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        '
        'LabelKilogramos
        '
        Me.LabelKilogramos.AutoSize = True
        Me.LabelKilogramos.Location = New System.Drawing.Point(109, 16)
        Me.LabelKilogramos.Name = "LabelKilogramos"
        Me.LabelKilogramos.Size = New System.Drawing.Size(58, 13)
        Me.LabelKilogramos.TabIndex = 8
        Me.LabelKilogramos.Text = "Kilogramos"
        '
        'LabelCantidad
        '
        Me.LabelCantidad.AutoSize = True
        Me.LabelCantidad.Location = New System.Drawing.Point(199, 16)
        Me.LabelCantidad.Name = "LabelCantidad"
        Me.LabelCantidad.Size = New System.Drawing.Size(49, 13)
        Me.LabelCantidad.TabIndex = 9
        Me.LabelCantidad.Text = "Cantidad"
        '
        'TextBoxCantidadEntradas
        '
        Me.TextBoxCantidadEntradas.Location = New System.Drawing.Point(196, 47)
        Me.TextBoxCantidadEntradas.Name = "TextBoxCantidadEntradas"
        Me.TextBoxCantidadEntradas.ReadOnly = True
        Me.TextBoxCantidadEntradas.Size = New System.Drawing.Size(55, 20)
        Me.TextBoxCantidadEntradas.TabIndex = 10
        Me.TextBoxCantidadEntradas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxCantidadSalidas
        '
        Me.TextBoxCantidadSalidas.Location = New System.Drawing.Point(196, 86)
        Me.TextBoxCantidadSalidas.Name = "TextBoxCantidadSalidas"
        Me.TextBoxCantidadSalidas.ReadOnly = True
        Me.TextBoxCantidadSalidas.Size = New System.Drawing.Size(55, 20)
        Me.TextBoxCantidadSalidas.TabIndex = 11
        Me.TextBoxCantidadSalidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxCantidadTotal
        '
        Me.TextBoxCantidadTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCantidadTotal.Location = New System.Drawing.Point(196, 112)
        Me.TextBoxCantidadTotal.Name = "TextBoxCantidadTotal"
        Me.TextBoxCantidadTotal.ReadOnly = True
        Me.TextBoxCantidadTotal.Size = New System.Drawing.Size(55, 20)
        Me.TextBoxCantidadTotal.TabIndex = 12
        Me.TextBoxCantidadTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'formPesadasResumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 390)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.DateTimePickerFechaHasta)
        Me.Controls.Add(Me.LabelFechaHasta)
        Me.Controls.Add(Me.DateTimePickerFechaDesde)
        Me.Controls.Add(Me.LabelFechaDesde)
        Me.Controls.Add(Me.GroupBoxResumen)
        Me.Controls.Add(Me.CheckBoxTipoSalidas)
        Me.Controls.Add(Me.CheckBoxTipoEntradas)
        Me.Controls.Add(Me.LabelTipo)
        Me.Controls.Add(Me.ComboBoxTitular)
        Me.Controls.Add(Me.labelTitular)
        Me.Controls.Add(Me.ComboBoxCosecha)
        Me.Controls.Add(Me.labelCosecha)
        Me.Controls.Add(Me.ComboBoxPlanta)
        Me.Controls.Add(Me.labelPlanta)
        Me.Controls.Add(Me.labelProducto)
        Me.Controls.Add(Me.ComboBoxProducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPesadasResumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Resumen de pesadas"
        Me.GroupBoxResumen.ResumeLayout(False)
        Me.GroupBoxResumen.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBoxCosecha As ComboBox
    Friend WithEvents labelCosecha As Label
    Friend WithEvents ComboBoxPlanta As ComboBox
    Friend WithEvents labelPlanta As Label
    Friend WithEvents labelProducto As Label
    Friend WithEvents ComboBoxProducto As ComboBox
    Friend WithEvents ComboBoxTitular As ComboBox
    Friend WithEvents labelTitular As Label
    Friend WithEvents LabelTipo As Label
    Friend WithEvents CheckBoxTipoEntradas As CheckBox
    Friend WithEvents CheckBoxTipoSalidas As CheckBox
    Friend WithEvents GroupBoxResumen As GroupBox
    Friend WithEvents LabelTotales As Label
    Friend WithEvents TextBoxKilogramosTotal As TextBox
    Friend WithEvents LabelSalidas As Label
    Friend WithEvents TextBoxKilogramosSalidas As TextBox
    Friend WithEvents LabelEntradasNetas As Label
    Friend WithEvents TextBoxKilogramosEntradasNetas As TextBox
    Friend WithEvents LabelEntradasBrutas As Label
    Friend WithEvents TextBoxKilogramosEntradasBrutas As TextBox
    Friend WithEvents LabelFechaDesde As Label
    Friend WithEvents DateTimePickerFechaDesde As DateTimePicker
    Friend WithEvents DateTimePickerFechaHasta As DateTimePicker
    Friend WithEvents LabelFechaHasta As Label
    Friend WithEvents ButtonCalcular As Button
    Friend WithEvents TextBoxCantidadTotal As TextBox
    Friend WithEvents TextBoxCantidadSalidas As TextBox
    Friend WithEvents TextBoxCantidadEntradas As TextBox
    Friend WithEvents LabelCantidad As Label
    Friend WithEvents LabelKilogramos As Label
End Class
