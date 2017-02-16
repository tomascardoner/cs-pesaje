<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPesadaAsistente
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
        Dim labelTipo As System.Windows.Forms.Label
        Me.groupboxUno = New System.Windows.Forms.GroupBox()
        Me.datetimepickerHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.labelInicio = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.buttonAnterior = New System.Windows.Forms.Button()
        Me.buttonSiguiente = New System.Windows.Forms.Button()
        Me.textboxProducto = New System.Windows.Forms.TextBox()
        Me.checkboxProductoTodos = New System.Windows.Forms.CheckBox()
        Me.comboboxCosecha = New System.Windows.Forms.ComboBox()
        Me.labelCosecha = New System.Windows.Forms.Label()
        Me.groupboxTipo = New System.Windows.Forms.GroupBox()
        Me.checkboxTipoTodos = New System.Windows.Forms.CheckBox()
        Me.radiobuttonNinguno = New System.Windows.Forms.RadioButton()
        Me.radiobuttonSalida = New System.Windows.Forms.RadioButton()
        Me.radiobuttonEntrada = New System.Windows.Forms.RadioButton()
        Me.comboboxPlanta = New System.Windows.Forms.ComboBox()
        Me.labelPlanta = New System.Windows.Forms.Label()
        Me.comboboxProducto = New System.Windows.Forms.ComboBox()
        Me.labelProducto = New System.Windows.Forms.Label()
        labelTipo = New System.Windows.Forms.Label()
        Me.groupboxUno.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.groupboxTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'groupboxUno
        '
        Me.groupboxUno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupboxUno.Controls.Add(Me.textboxProducto)
        Me.groupboxUno.Controls.Add(Me.checkboxProductoTodos)
        Me.groupboxUno.Controls.Add(Me.comboboxCosecha)
        Me.groupboxUno.Controls.Add(Me.labelCosecha)
        Me.groupboxUno.Controls.Add(Me.groupboxTipo)
        Me.groupboxUno.Controls.Add(Me.comboboxPlanta)
        Me.groupboxUno.Controls.Add(Me.labelPlanta)
        Me.groupboxUno.Controls.Add(Me.comboboxProducto)
        Me.groupboxUno.Controls.Add(Me.labelProducto)
        Me.groupboxUno.Controls.Add(labelTipo)
        Me.groupboxUno.Controls.Add(Me.datetimepickerHoraInicio)
        Me.groupboxUno.Controls.Add(Me.datetimepickerFechaInicio)
        Me.groupboxUno.Controls.Add(Me.labelInicio)
        Me.groupboxUno.Location = New System.Drawing.Point(18, 17)
        Me.groupboxUno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxUno.Name = "groupboxUno"
        Me.groupboxUno.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.groupboxUno.Size = New System.Drawing.Size(730, 449)
        Me.groupboxUno.TabIndex = 8
        Me.groupboxUno.TabStop = False
        Me.groupboxUno.Text = "Paso 1"
        '
        'datetimepickerHoraInicio
        '
        Me.datetimepickerHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.datetimepickerHoraInicio.Location = New System.Drawing.Point(252, 33)
        Me.datetimepickerHoraInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datetimepickerHoraInicio.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerHoraInicio.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerHoraInicio.Name = "datetimepickerHoraInicio"
        Me.datetimepickerHoraInicio.ShowUpDown = True
        Me.datetimepickerHoraInicio.Size = New System.Drawing.Size(126, 24)
        Me.datetimepickerHoraInicio.TabIndex = 10
        '
        'datetimepickerFechaInicio
        '
        Me.datetimepickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaInicio.Location = New System.Drawing.Point(94, 33)
        Me.datetimepickerFechaInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datetimepickerFechaInicio.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaInicio.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaInicio.Name = "datetimepickerFechaInicio"
        Me.datetimepickerFechaInicio.Size = New System.Drawing.Size(150, 24)
        Me.datetimepickerFechaInicio.TabIndex = 9
        '
        'labelInicio
        '
        Me.labelInicio.AutoSize = True
        Me.labelInicio.Location = New System.Drawing.Point(8, 38)
        Me.labelInicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelInicio.Name = "labelInicio"
        Me.labelInicio.Size = New System.Drawing.Size(46, 18)
        Me.labelInicio.TabIndex = 8
        Me.labelInicio.Text = "Inicio:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.buttonAnterior)
        Me.Panel1.Controls.Add(Me.buttonSiguiente)
        Me.Panel1.Location = New System.Drawing.Point(18, 474)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(730, 44)
        Me.Panel1.TabIndex = 11
        '
        'buttonAnterior
        '
        Me.buttonAnterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAnterior.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_MOVE_PREVIOUS_24
        Me.buttonAnterior.Location = New System.Drawing.Point(434, 0)
        Me.buttonAnterior.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonAnterior.Name = "buttonAnterior"
        Me.buttonAnterior.Size = New System.Drawing.Size(144, 44)
        Me.buttonAnterior.TabIndex = 12
        Me.buttonAnterior.Text = "Anterior"
        Me.buttonAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.buttonAnterior.UseVisualStyleBackColor = True
        '
        'buttonSiguiente
        '
        Me.buttonSiguiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonSiguiente.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_MOVE_NEXT_24
        Me.buttonSiguiente.Location = New System.Drawing.Point(586, 0)
        Me.buttonSiguiente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.buttonSiguiente.Name = "buttonSiguiente"
        Me.buttonSiguiente.Size = New System.Drawing.Size(144, 44)
        Me.buttonSiguiente.TabIndex = 11
        Me.buttonSiguiente.Text = "Siguiente"
        Me.buttonSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.buttonSiguiente.UseVisualStyleBackColor = True
        '
        'textboxProducto
        '
        Me.textboxProducto.Location = New System.Drawing.Point(149, 73)
        Me.textboxProducto.MaxLength = 50
        Me.textboxProducto.Name = "textboxProducto"
        Me.textboxProducto.Size = New System.Drawing.Size(175, 24)
        Me.textboxProducto.TabIndex = 14
        '
        'checkboxProductoTodos
        '
        Me.checkboxProductoTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxProductoTodos.Location = New System.Drawing.Point(328, 73)
        Me.checkboxProductoTodos.Name = "checkboxProductoTodos"
        Me.checkboxProductoTodos.Size = New System.Drawing.Size(26, 26)
        Me.checkboxProductoTodos.TabIndex = 15
        Me.checkboxProductoTodos.TabStop = False
        Me.checkboxProductoTodos.Text = "+"
        Me.checkboxProductoTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.checkboxProductoTodos.UseVisualStyleBackColor = True
        '
        'comboboxCosecha
        '
        Me.comboboxCosecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCosecha.FormattingEnabled = True
        Me.comboboxCosecha.Location = New System.Drawing.Point(94, 217)
        Me.comboboxCosecha.Name = "comboboxCosecha"
        Me.comboboxCosecha.Size = New System.Drawing.Size(121, 26)
        Me.comboboxCosecha.TabIndex = 21
        '
        'labelCosecha
        '
        Me.labelCosecha.AutoSize = True
        Me.labelCosecha.Location = New System.Drawing.Point(8, 220)
        Me.labelCosecha.Name = "labelCosecha"
        Me.labelCosecha.Size = New System.Drawing.Size(72, 18)
        Me.labelCosecha.TabIndex = 20
        Me.labelCosecha.Text = "Cosecha:"
        '
        'groupboxTipo
        '
        Me.groupboxTipo.Controls.Add(Me.checkboxTipoTodos)
        Me.groupboxTipo.Controls.Add(Me.radiobuttonNinguno)
        Me.groupboxTipo.Controls.Add(Me.radiobuttonSalida)
        Me.groupboxTipo.Controls.Add(Me.radiobuttonEntrada)
        Me.groupboxTipo.Location = New System.Drawing.Point(94, 161)
        Me.groupboxTipo.Name = "groupboxTipo"
        Me.groupboxTipo.Size = New System.Drawing.Size(265, 38)
        Me.groupboxTipo.TabIndex = 19
        Me.groupboxTipo.TabStop = False
        '
        'checkboxTipoTodos
        '
        Me.checkboxTipoTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxTipoTodos.Location = New System.Drawing.Point(234, 9)
        Me.checkboxTipoTodos.Name = "checkboxTipoTodos"
        Me.checkboxTipoTodos.Size = New System.Drawing.Size(26, 26)
        Me.checkboxTipoTodos.TabIndex = 3
        Me.checkboxTipoTodos.TabStop = False
        Me.checkboxTipoTodos.Text = "+"
        Me.checkboxTipoTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.checkboxTipoTodos.UseVisualStyleBackColor = True
        '
        'radiobuttonNinguno
        '
        Me.radiobuttonNinguno.AutoSize = True
        Me.radiobuttonNinguno.Location = New System.Drawing.Point(154, 10)
        Me.radiobuttonNinguno.Name = "radiobuttonNinguno"
        Me.radiobuttonNinguno.Size = New System.Drawing.Size(81, 22)
        Me.radiobuttonNinguno.TabIndex = 2
        Me.radiobuttonNinguno.TabStop = True
        Me.radiobuttonNinguno.Text = "Ninguno"
        Me.radiobuttonNinguno.UseVisualStyleBackColor = True
        '
        'radiobuttonSalida
        '
        Me.radiobuttonSalida.AutoSize = True
        Me.radiobuttonSalida.Location = New System.Drawing.Point(84, 10)
        Me.radiobuttonSalida.Name = "radiobuttonSalida"
        Me.radiobuttonSalida.Size = New System.Drawing.Size(66, 22)
        Me.radiobuttonSalida.TabIndex = 1
        Me.radiobuttonSalida.TabStop = True
        Me.radiobuttonSalida.Text = "Salida"
        Me.radiobuttonSalida.UseVisualStyleBackColor = True
        '
        'radiobuttonEntrada
        '
        Me.radiobuttonEntrada.AutoSize = True
        Me.radiobuttonEntrada.Location = New System.Drawing.Point(6, 10)
        Me.radiobuttonEntrada.Name = "radiobuttonEntrada"
        Me.radiobuttonEntrada.Size = New System.Drawing.Size(77, 22)
        Me.radiobuttonEntrada.TabIndex = 0
        Me.radiobuttonEntrada.TabStop = True
        Me.radiobuttonEntrada.Text = "Entrada"
        Me.radiobuttonEntrada.UseVisualStyleBackColor = True
        '
        'comboboxPlanta
        '
        Me.comboboxPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxPlanta.FormattingEnabled = True
        Me.comboboxPlanta.Location = New System.Drawing.Point(94, 117)
        Me.comboboxPlanta.Name = "comboboxPlanta"
        Me.comboboxPlanta.Size = New System.Drawing.Size(230, 26)
        Me.comboboxPlanta.TabIndex = 17
        '
        'labelPlanta
        '
        Me.labelPlanta.AutoSize = True
        Me.labelPlanta.Location = New System.Drawing.Point(8, 120)
        Me.labelPlanta.Name = "labelPlanta"
        Me.labelPlanta.Size = New System.Drawing.Size(53, 18)
        Me.labelPlanta.TabIndex = 16
        Me.labelPlanta.Text = "Planta:"
        '
        'comboboxProducto
        '
        Me.comboboxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxProducto.FormattingEnabled = True
        Me.comboboxProducto.Location = New System.Drawing.Point(94, 73)
        Me.comboboxProducto.Name = "comboboxProducto"
        Me.comboboxProducto.Size = New System.Drawing.Size(230, 26)
        Me.comboboxProducto.TabIndex = 13
        '
        'labelProducto
        '
        Me.labelProducto.AutoSize = True
        Me.labelProducto.Location = New System.Drawing.Point(8, 76)
        Me.labelProducto.Name = "labelProducto"
        Me.labelProducto.Size = New System.Drawing.Size(73, 18)
        Me.labelProducto.TabIndex = 12
        Me.labelProducto.Text = "Producto:"
        '
        'labelTipo
        '
        labelTipo.AutoSize = True
        labelTipo.Location = New System.Drawing.Point(8, 173)
        labelTipo.Name = "labelTipo"
        labelTipo.Size = New System.Drawing.Size(41, 18)
        labelTipo.TabIndex = 18
        labelTipo.Text = "Tipo:"
        '
        'formPesadaAsistente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 534)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.groupboxUno)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPesadaAsistente"
        Me.Text = "Asistente de Pesada"
        Me.groupboxUno.ResumeLayout(False)
        Me.groupboxUno.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.groupboxTipo.ResumeLayout(False)
        Me.groupboxTipo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groupboxUno As System.Windows.Forms.GroupBox
    Friend WithEvents datetimepickerHoraInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents datetimepickerFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelInicio As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents buttonAnterior As System.Windows.Forms.Button
    Friend WithEvents buttonSiguiente As System.Windows.Forms.Button
    Friend WithEvents textboxProducto As System.Windows.Forms.TextBox
    Friend WithEvents checkboxProductoTodos As System.Windows.Forms.CheckBox
    Friend WithEvents comboboxCosecha As System.Windows.Forms.ComboBox
    Friend WithEvents labelCosecha As System.Windows.Forms.Label
    Friend WithEvents groupboxTipo As System.Windows.Forms.GroupBox
    Friend WithEvents checkboxTipoTodos As System.Windows.Forms.CheckBox
    Friend WithEvents radiobuttonNinguno As System.Windows.Forms.RadioButton
    Friend WithEvents radiobuttonSalida As System.Windows.Forms.RadioButton
    Friend WithEvents radiobuttonEntrada As System.Windows.Forms.RadioButton
    Friend WithEvents comboboxPlanta As System.Windows.Forms.ComboBox
    Friend WithEvents labelPlanta As System.Windows.Forms.Label
    Friend WithEvents comboboxProducto As System.Windows.Forms.ComboBox
    Friend WithEvents labelProducto As System.Windows.Forms.Label
End Class
