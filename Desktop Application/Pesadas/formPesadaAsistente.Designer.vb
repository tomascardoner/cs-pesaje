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
        Me.checkboxCosechaTodos = New System.Windows.Forms.CheckBox()
        Me.comboboxCosecha = New System.Windows.Forms.ComboBox()
        Me.checkboxTipoTodos = New System.Windows.Forms.CheckBox()
        Me.groupboxTipo = New System.Windows.Forms.GroupBox()
        Me.radiobuttonNinguno = New System.Windows.Forms.RadioButton()
        Me.radiobuttonSalida = New System.Windows.Forms.RadioButton()
        Me.radiobuttonEntrada = New System.Windows.Forms.RadioButton()
        Me.checkboxProductoOtro = New System.Windows.Forms.CheckBox()
        Me.checkboxProductoTodos = New System.Windows.Forms.CheckBox()
        Me.textboxProducto = New System.Windows.Forms.TextBox()
        Me.comboboxProducto = New System.Windows.Forms.ComboBox()
        Me.buttonFechaHoraInicioAhora = New System.Windows.Forms.Button()
        Me.datetimepickerHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.labelCosecha = New System.Windows.Forms.Label()
        Me.comboboxPlanta = New System.Windows.Forms.ComboBox()
        Me.labelPlanta = New System.Windows.Forms.Label()
        Me.labelProducto = New System.Windows.Forms.Label()
        Me.labelInicio = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.buttonAnterior = New System.Windows.Forms.Button()
        Me.buttonSiguiente = New System.Windows.Forms.Button()
        labelTipo = New System.Windows.Forms.Label()
        Me.groupboxUno.SuspendLayout()
        Me.groupboxTipo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTipo
        '
        labelTipo.AutoSize = True
        labelTipo.Location = New System.Drawing.Point(5, 125)
        labelTipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        labelTipo.Name = "labelTipo"
        labelTipo.Size = New System.Drawing.Size(31, 13)
        labelTipo.TabIndex = 18
        labelTipo.Text = "Tipo:"
        '
        'groupboxUno
        '
        Me.groupboxUno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupboxUno.Controls.Add(Me.checkboxCosechaTodos)
        Me.groupboxUno.Controls.Add(Me.comboboxCosecha)
        Me.groupboxUno.Controls.Add(Me.checkboxTipoTodos)
        Me.groupboxUno.Controls.Add(Me.groupboxTipo)
        Me.groupboxUno.Controls.Add(Me.checkboxProductoOtro)
        Me.groupboxUno.Controls.Add(Me.checkboxProductoTodos)
        Me.groupboxUno.Controls.Add(Me.textboxProducto)
        Me.groupboxUno.Controls.Add(Me.comboboxProducto)
        Me.groupboxUno.Controls.Add(Me.buttonFechaHoraInicioAhora)
        Me.groupboxUno.Controls.Add(Me.datetimepickerHoraInicio)
        Me.groupboxUno.Controls.Add(Me.datetimepickerFechaInicio)
        Me.groupboxUno.Controls.Add(Me.labelCosecha)
        Me.groupboxUno.Controls.Add(Me.comboboxPlanta)
        Me.groupboxUno.Controls.Add(Me.labelPlanta)
        Me.groupboxUno.Controls.Add(Me.labelProducto)
        Me.groupboxUno.Controls.Add(labelTipo)
        Me.groupboxUno.Controls.Add(Me.labelInicio)
        Me.groupboxUno.Location = New System.Drawing.Point(12, 12)
        Me.groupboxUno.Name = "groupboxUno"
        Me.groupboxUno.Size = New System.Drawing.Size(487, 324)
        Me.groupboxUno.TabIndex = 8
        Me.groupboxUno.TabStop = False
        Me.groupboxUno.Text = "Paso 1"
        '
        'checkboxCosechaTodos
        '
        Me.checkboxCosechaTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxCosechaTodos.Location = New System.Drawing.Point(185, 155)
        Me.checkboxCosechaTodos.Name = "checkboxCosechaTodos"
        Me.checkboxCosechaTodos.Size = New System.Drawing.Size(23, 23)
        Me.checkboxCosechaTodos.TabIndex = 32
        Me.checkboxCosechaTodos.TabStop = False
        Me.checkboxCosechaTodos.Text = "T"
        Me.checkboxCosechaTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.checkboxCosechaTodos.UseVisualStyleBackColor = True
        '
        'comboboxCosecha
        '
        Me.comboboxCosecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCosecha.FormattingEnabled = True
        Me.comboboxCosecha.Location = New System.Drawing.Point(63, 156)
        Me.comboboxCosecha.Name = "comboboxCosecha"
        Me.comboboxCosecha.Size = New System.Drawing.Size(121, 21)
        Me.comboboxCosecha.TabIndex = 31
        '
        'checkboxTipoTodos
        '
        Me.checkboxTipoTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxTipoTodos.Location = New System.Drawing.Point(297, 120)
        Me.checkboxTipoTodos.Name = "checkboxTipoTodos"
        Me.checkboxTipoTodos.Size = New System.Drawing.Size(23, 23)
        Me.checkboxTipoTodos.TabIndex = 30
        Me.checkboxTipoTodos.TabStop = False
        Me.checkboxTipoTodos.Text = "T"
        Me.checkboxTipoTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.checkboxTipoTodos.UseVisualStyleBackColor = True
        '
        'groupboxTipo
        '
        Me.groupboxTipo.Controls.Add(Me.radiobuttonNinguno)
        Me.groupboxTipo.Controls.Add(Me.radiobuttonSalida)
        Me.groupboxTipo.Controls.Add(Me.radiobuttonEntrada)
        Me.groupboxTipo.Location = New System.Drawing.Point(63, 113)
        Me.groupboxTipo.Name = "groupboxTipo"
        Me.groupboxTipo.Size = New System.Drawing.Size(233, 33)
        Me.groupboxTipo.TabIndex = 29
        Me.groupboxTipo.TabStop = False
        '
        'radiobuttonNinguno
        '
        Me.radiobuttonNinguno.AutoSize = True
        Me.radiobuttonNinguno.Location = New System.Drawing.Point(154, 10)
        Me.radiobuttonNinguno.Name = "radiobuttonNinguno"
        Me.radiobuttonNinguno.Size = New System.Drawing.Size(65, 17)
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
        Me.radiobuttonSalida.Size = New System.Drawing.Size(54, 17)
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
        Me.radiobuttonEntrada.Size = New System.Drawing.Size(62, 17)
        Me.radiobuttonEntrada.TabIndex = 0
        Me.radiobuttonEntrada.TabStop = True
        Me.radiobuttonEntrada.Text = "Entrada"
        Me.radiobuttonEntrada.UseVisualStyleBackColor = True
        '
        'checkboxProductoOtro
        '
        Me.checkboxProductoOtro.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxProductoOtro.Location = New System.Drawing.Point(63, 50)
        Me.checkboxProductoOtro.Name = "checkboxProductoOtro"
        Me.checkboxProductoOtro.Size = New System.Drawing.Size(23, 23)
        Me.checkboxProductoOtro.TabIndex = 25
        Me.checkboxProductoOtro.Text = "O"
        Me.checkboxProductoOtro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.checkboxProductoOtro.UseVisualStyleBackColor = True
        '
        'checkboxProductoTodos
        '
        Me.checkboxProductoTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxProductoTodos.Location = New System.Drawing.Point(297, 50)
        Me.checkboxProductoTodos.Name = "checkboxProductoTodos"
        Me.checkboxProductoTodos.Size = New System.Drawing.Size(23, 23)
        Me.checkboxProductoTodos.TabIndex = 28
        Me.checkboxProductoTodos.TabStop = False
        Me.checkboxProductoTodos.Text = "T"
        Me.checkboxProductoTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.checkboxProductoTodos.UseVisualStyleBackColor = True
        '
        'textboxProducto
        '
        Me.textboxProducto.Location = New System.Drawing.Point(87, 51)
        Me.textboxProducto.MaxLength = 50
        Me.textboxProducto.Name = "textboxProducto"
        Me.textboxProducto.Size = New System.Drawing.Size(158, 20)
        Me.textboxProducto.TabIndex = 26
        '
        'comboboxProducto
        '
        Me.comboboxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxProducto.FormattingEnabled = True
        Me.comboboxProducto.Location = New System.Drawing.Point(87, 51)
        Me.comboboxProducto.Name = "comboboxProducto"
        Me.comboboxProducto.Size = New System.Drawing.Size(209, 21)
        Me.comboboxProducto.TabIndex = 27
        '
        'buttonFechaHoraInicioAhora
        '
        Me.buttonFechaHoraInicioAhora.Image = My.Resources.Resources.ImageCalendarToday16
        Me.buttonFechaHoraInicioAhora.Location = New System.Drawing.Point(274, 24)
        Me.buttonFechaHoraInicioAhora.Name = "buttonFechaHoraInicioAhora"
        Me.buttonFechaHoraInicioAhora.Size = New System.Drawing.Size(22, 22)
        Me.buttonFechaHoraInicioAhora.TabIndex = 24
        Me.buttonFechaHoraInicioAhora.Text = "Ahora"
        Me.buttonFechaHoraInicioAhora.UseVisualStyleBackColor = True
        '
        'datetimepickerHoraInicio
        '
        Me.datetimepickerHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.datetimepickerHoraInicio.Location = New System.Drawing.Point(183, 25)
        Me.datetimepickerHoraInicio.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerHoraInicio.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerHoraInicio.Name = "datetimepickerHoraInicio"
        Me.datetimepickerHoraInicio.ShowUpDown = True
        Me.datetimepickerHoraInicio.Size = New System.Drawing.Size(85, 20)
        Me.datetimepickerHoraInicio.TabIndex = 23
        '
        'datetimepickerFechaInicio
        '
        Me.datetimepickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaInicio.Location = New System.Drawing.Point(63, 25)
        Me.datetimepickerFechaInicio.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaInicio.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaInicio.Name = "datetimepickerFechaInicio"
        Me.datetimepickerFechaInicio.Size = New System.Drawing.Size(114, 20)
        Me.datetimepickerFechaInicio.TabIndex = 22
        '
        'labelCosecha
        '
        Me.labelCosecha.AutoSize = True
        Me.labelCosecha.Location = New System.Drawing.Point(5, 159)
        Me.labelCosecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelCosecha.Name = "labelCosecha"
        Me.labelCosecha.Size = New System.Drawing.Size(52, 13)
        Me.labelCosecha.TabIndex = 20
        Me.labelCosecha.Text = "Cosecha:"
        '
        'comboboxPlanta
        '
        Me.comboboxPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxPlanta.FormattingEnabled = True
        Me.comboboxPlanta.Location = New System.Drawing.Point(63, 84)
        Me.comboboxPlanta.Margin = New System.Windows.Forms.Padding(2)
        Me.comboboxPlanta.Name = "comboboxPlanta"
        Me.comboboxPlanta.Size = New System.Drawing.Size(155, 21)
        Me.comboboxPlanta.TabIndex = 17
        '
        'labelPlanta
        '
        Me.labelPlanta.AutoSize = True
        Me.labelPlanta.Location = New System.Drawing.Point(5, 87)
        Me.labelPlanta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelPlanta.Name = "labelPlanta"
        Me.labelPlanta.Size = New System.Drawing.Size(40, 13)
        Me.labelPlanta.TabIndex = 16
        Me.labelPlanta.Text = "Planta:"
        '
        'labelProducto
        '
        Me.labelProducto.AutoSize = True
        Me.labelProducto.Location = New System.Drawing.Point(5, 55)
        Me.labelProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelProducto.Name = "labelProducto"
        Me.labelProducto.Size = New System.Drawing.Size(53, 13)
        Me.labelProducto.TabIndex = 12
        Me.labelProducto.Text = "Producto:"
        '
        'labelInicio
        '
        Me.labelInicio.AutoSize = True
        Me.labelInicio.Location = New System.Drawing.Point(5, 27)
        Me.labelInicio.Name = "labelInicio"
        Me.labelInicio.Size = New System.Drawing.Size(35, 13)
        Me.labelInicio.TabIndex = 8
        Me.labelInicio.Text = "Inicio:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.buttonAnterior)
        Me.Panel1.Controls.Add(Me.buttonSiguiente)
        Me.Panel1.Location = New System.Drawing.Point(12, 342)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(487, 32)
        Me.Panel1.TabIndex = 11
        '
        'buttonAnterior
        '
        Me.buttonAnterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonAnterior.Image = My.Resources.Resources.ImageMovePrevious24
        Me.buttonAnterior.Location = New System.Drawing.Point(289, 0)
        Me.buttonAnterior.Name = "buttonAnterior"
        Me.buttonAnterior.Size = New System.Drawing.Size(96, 32)
        Me.buttonAnterior.TabIndex = 12
        Me.buttonAnterior.Text = "Anterior"
        Me.buttonAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.buttonAnterior.UseVisualStyleBackColor = True
        '
        'buttonSiguiente
        '
        Me.buttonSiguiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonSiguiente.Image = My.Resources.Resources.ImageMoveNext24
        Me.buttonSiguiente.Location = New System.Drawing.Point(391, 0)
        Me.buttonSiguiente.Name = "buttonSiguiente"
        Me.buttonSiguiente.Size = New System.Drawing.Size(96, 32)
        Me.buttonSiguiente.TabIndex = 11
        Me.buttonSiguiente.Text = "Siguiente"
        Me.buttonSiguiente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.buttonSiguiente.UseVisualStyleBackColor = True
        '
        'formPesadaAsistente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 386)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.groupboxUno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formPesadaAsistente"
        Me.ShowInTaskbar = False
        Me.Text = "Asistente de Pesada"
        Me.groupboxUno.ResumeLayout(False)
        Me.groupboxUno.PerformLayout()
        Me.groupboxTipo.ResumeLayout(False)
        Me.groupboxTipo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents groupboxUno As System.Windows.Forms.GroupBox
    Friend WithEvents labelInicio As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents buttonAnterior As System.Windows.Forms.Button
    Friend WithEvents buttonSiguiente As System.Windows.Forms.Button
    Friend WithEvents labelCosecha As System.Windows.Forms.Label
    Friend WithEvents comboboxPlanta As System.Windows.Forms.ComboBox
    Friend WithEvents labelPlanta As System.Windows.Forms.Label
    Friend WithEvents labelProducto As System.Windows.Forms.Label
    Friend WithEvents buttonFechaHoraInicioAhora As System.Windows.Forms.Button
    Friend WithEvents datetimepickerHoraInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents datetimepickerFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents checkboxProductoOtro As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxProductoTodos As System.Windows.Forms.CheckBox
    Friend WithEvents textboxProducto As System.Windows.Forms.TextBox
    Friend WithEvents comboboxProducto As System.Windows.Forms.ComboBox
    Friend WithEvents checkboxTipoTodos As System.Windows.Forms.CheckBox
    Friend WithEvents groupboxTipo As System.Windows.Forms.GroupBox
    Friend WithEvents radiobuttonNinguno As System.Windows.Forms.RadioButton
    Friend WithEvents radiobuttonSalida As System.Windows.Forms.RadioButton
    Friend WithEvents radiobuttonEntrada As System.Windows.Forms.RadioButton
    Friend WithEvents checkboxCosechaTodos As System.Windows.Forms.CheckBox
    Friend WithEvents comboboxCosecha As System.Windows.Forms.ComboBox
End Class
