<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formPesada
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
        Dim labelTipo As System.Windows.Forms.Label
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tooltipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.labelOrigenDestino = New System.Windows.Forms.Label()
        Me.labelTitular = New System.Windows.Forms.Label()
        Me.groupboxTransporte = New System.Windows.Forms.GroupBox()
        Me.labelChofer = New System.Windows.Forms.Label()
        Me.comboboxChofer = New System.Windows.Forms.ComboBox()
        Me.comboboxTransportista = New System.Windows.Forms.ComboBox()
        Me.labelCamion = New System.Windows.Forms.Label()
        Me.labelTransportista = New System.Windows.Forms.Label()
        Me.comboboxCamion = New System.Windows.Forms.ComboBox()
        Me.groupboxTitular = New System.Windows.Forms.GroupBox()
        Me.comboboxOrigenDestino = New System.Windows.Forms.ComboBox()
        Me.comboboxTitular = New System.Windows.Forms.ComboBox()
        Me.groupboxProductoPlanta = New System.Windows.Forms.GroupBox()
        Me.comboboxCosecha = New System.Windows.Forms.ComboBox()
        Me.labelCosecha = New System.Windows.Forms.Label()
        Me.groupboxTipo = New System.Windows.Forms.GroupBox()
        Me.radiobuttonNinguno = New System.Windows.Forms.RadioButton()
        Me.radiobuttonSalida = New System.Windows.Forms.RadioButton()
        Me.radiobuttonEntrada = New System.Windows.Forms.RadioButton()
        Me.comboboxPlanta = New System.Windows.Forms.ComboBox()
        Me.labelPlanta = New System.Windows.Forms.Label()
        Me.comboboxProducto = New System.Windows.Forms.ComboBox()
        Me.labelProducto = New System.Windows.Forms.Label()
        Me.groupboxEncabezado = New System.Windows.Forms.GroupBox()
        Me.datetimepickerHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.labelFin = New System.Windows.Forms.Label()
        Me.datetimepickerHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.labelIDPesada = New System.Windows.Forms.Label()
        Me.textboxIDPesada = New System.Windows.Forms.TextBox()
        Me.labelInicio = New System.Windows.Forms.Label()
        Me.groupboxKilogramo = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.textboxKilogramoNeto = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.labelKilogramoTara = New System.Windows.Forms.Label()
        Me.textboxKilogramoTara = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.labelKilogramoBruto = New System.Windows.Forms.Label()
        Me.textboxKilogramoBruto = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        labelTipo = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.groupboxTransporte.SuspendLayout()
        Me.groupboxTitular.SuspendLayout()
        Me.groupboxProductoPlanta.SuspendLayout()
        Me.groupboxTipo.SuspendLayout()
        Me.groupboxEncabezado.SuspendLayout()
        Me.groupboxKilogramo.SuspendLayout()
        CType(Me.textboxKilogramoNeto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textboxKilogramoTara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textboxKilogramoBruto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelTipo
        '
        labelTipo.AutoSize = True
        labelTipo.Location = New System.Drawing.Point(6, 74)
        labelTipo.Name = "labelTipo"
        labelTipo.Size = New System.Drawing.Size(31, 13)
        labelTipo.TabIndex = 4
        labelTipo.Text = "Tipo:"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(352, 39)
        Me.toolstripMain.TabIndex = 5
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
        'labelOrigenDestino
        '
        Me.labelOrigenDestino.AutoSize = True
        Me.labelOrigenDestino.Location = New System.Drawing.Point(6, 43)
        Me.labelOrigenDestino.Name = "labelOrigenDestino"
        Me.labelOrigenDestino.Size = New System.Drawing.Size(88, 13)
        Me.labelOrigenDestino.TabIndex = 2
        Me.labelOrigenDestino.Text = "Origen / Destino:"
        Me.tooltipMain.SetToolTip(Me.labelOrigenDestino, "Ingrese el Número de Documento sin utilizar puntos.")
        '
        'labelTitular
        '
        Me.labelTitular.AutoSize = True
        Me.labelTitular.Location = New System.Drawing.Point(6, 16)
        Me.labelTitular.Name = "labelTitular"
        Me.labelTitular.Size = New System.Drawing.Size(39, 13)
        Me.labelTitular.TabIndex = 0
        Me.labelTitular.Text = "Titular:"
        Me.tooltipMain.SetToolTip(Me.labelTitular, "Ingrese el Número de Documento sin utilizar puntos.")
        '
        'groupboxTransporte
        '
        Me.groupboxTransporte.Controls.Add(Me.labelChofer)
        Me.groupboxTransporte.Controls.Add(Me.comboboxChofer)
        Me.groupboxTransporte.Controls.Add(Me.comboboxTransportista)
        Me.groupboxTransporte.Controls.Add(Me.labelCamion)
        Me.groupboxTransporte.Controls.Add(Me.labelTransportista)
        Me.groupboxTransporte.Controls.Add(Me.comboboxCamion)
        Me.groupboxTransporte.Location = New System.Drawing.Point(12, 358)
        Me.groupboxTransporte.Name = "groupboxTransporte"
        Me.groupboxTransporte.Size = New System.Drawing.Size(328, 97)
        Me.groupboxTransporte.TabIndex = 3
        Me.groupboxTransporte.TabStop = False
        '
        'labelChofer
        '
        Me.labelChofer.AutoSize = True
        Me.labelChofer.Location = New System.Drawing.Point(6, 43)
        Me.labelChofer.Name = "labelChofer"
        Me.labelChofer.Size = New System.Drawing.Size(41, 13)
        Me.labelChofer.TabIndex = 2
        Me.labelChofer.Text = "Chofer:"
        '
        'comboboxChofer
        '
        Me.comboboxChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxChofer.FormattingEnabled = True
        Me.comboboxChofer.Location = New System.Drawing.Point(92, 40)
        Me.comboboxChofer.Name = "comboboxChofer"
        Me.comboboxChofer.Size = New System.Drawing.Size(230, 21)
        Me.comboboxChofer.TabIndex = 3
        '
        'comboboxTransportista
        '
        Me.comboboxTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxTransportista.FormattingEnabled = True
        Me.comboboxTransportista.Location = New System.Drawing.Point(92, 13)
        Me.comboboxTransportista.Name = "comboboxTransportista"
        Me.comboboxTransportista.Size = New System.Drawing.Size(230, 21)
        Me.comboboxTransportista.TabIndex = 1
        '
        'labelCamion
        '
        Me.labelCamion.AutoSize = True
        Me.labelCamion.Location = New System.Drawing.Point(6, 70)
        Me.labelCamion.Name = "labelCamion"
        Me.labelCamion.Size = New System.Drawing.Size(45, 13)
        Me.labelCamion.TabIndex = 4
        Me.labelCamion.Text = "Camión:"
        '
        'labelTransportista
        '
        Me.labelTransportista.AutoSize = True
        Me.labelTransportista.Location = New System.Drawing.Point(6, 16)
        Me.labelTransportista.Name = "labelTransportista"
        Me.labelTransportista.Size = New System.Drawing.Size(71, 13)
        Me.labelTransportista.TabIndex = 0
        Me.labelTransportista.Text = "Transportista:"
        '
        'comboboxCamion
        '
        Me.comboboxCamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCamion.FormattingEnabled = True
        Me.comboboxCamion.Location = New System.Drawing.Point(92, 67)
        Me.comboboxCamion.Name = "comboboxCamion"
        Me.comboboxCamion.Size = New System.Drawing.Size(230, 21)
        Me.comboboxCamion.TabIndex = 5
        '
        'groupboxTitular
        '
        Me.groupboxTitular.Controls.Add(Me.comboboxOrigenDestino)
        Me.groupboxTitular.Controls.Add(Me.labelOrigenDestino)
        Me.groupboxTitular.Controls.Add(Me.comboboxTitular)
        Me.groupboxTitular.Controls.Add(Me.labelTitular)
        Me.groupboxTitular.Location = New System.Drawing.Point(12, 281)
        Me.groupboxTitular.Name = "groupboxTitular"
        Me.groupboxTitular.Size = New System.Drawing.Size(328, 71)
        Me.groupboxTitular.TabIndex = 2
        Me.groupboxTitular.TabStop = False
        '
        'comboboxOrigenDestino
        '
        Me.comboboxOrigenDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxOrigenDestino.FormattingEnabled = True
        Me.comboboxOrigenDestino.Location = New System.Drawing.Point(92, 40)
        Me.comboboxOrigenDestino.Name = "comboboxOrigenDestino"
        Me.comboboxOrigenDestino.Size = New System.Drawing.Size(230, 21)
        Me.comboboxOrigenDestino.TabIndex = 3
        '
        'comboboxTitular
        '
        Me.comboboxTitular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxTitular.FormattingEnabled = True
        Me.comboboxTitular.Location = New System.Drawing.Point(92, 13)
        Me.comboboxTitular.Name = "comboboxTitular"
        Me.comboboxTitular.Size = New System.Drawing.Size(230, 21)
        Me.comboboxTitular.TabIndex = 1
        '
        'groupboxProductoPlanta
        '
        Me.groupboxProductoPlanta.Controls.Add(Me.comboboxCosecha)
        Me.groupboxProductoPlanta.Controls.Add(Me.labelCosecha)
        Me.groupboxProductoPlanta.Controls.Add(Me.groupboxTipo)
        Me.groupboxProductoPlanta.Controls.Add(Me.comboboxPlanta)
        Me.groupboxProductoPlanta.Controls.Add(Me.labelPlanta)
        Me.groupboxProductoPlanta.Controls.Add(Me.comboboxProducto)
        Me.groupboxProductoPlanta.Controls.Add(Me.labelProducto)
        Me.groupboxProductoPlanta.Controls.Add(labelTipo)
        Me.groupboxProductoPlanta.Location = New System.Drawing.Point(12, 143)
        Me.groupboxProductoPlanta.Name = "groupboxProductoPlanta"
        Me.groupboxProductoPlanta.Size = New System.Drawing.Size(328, 132)
        Me.groupboxProductoPlanta.TabIndex = 1
        Me.groupboxProductoPlanta.TabStop = False
        '
        'comboboxCosecha
        '
        Me.comboboxCosecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCosecha.FormattingEnabled = True
        Me.comboboxCosecha.Location = New System.Drawing.Point(92, 101)
        Me.comboboxCosecha.Name = "comboboxCosecha"
        Me.comboboxCosecha.Size = New System.Drawing.Size(121, 21)
        Me.comboboxCosecha.TabIndex = 7
        '
        'labelCosecha
        '
        Me.labelCosecha.AutoSize = True
        Me.labelCosecha.Location = New System.Drawing.Point(6, 104)
        Me.labelCosecha.Name = "labelCosecha"
        Me.labelCosecha.Size = New System.Drawing.Size(52, 13)
        Me.labelCosecha.TabIndex = 6
        Me.labelCosecha.Text = "Cosecha:"
        '
        'groupboxTipo
        '
        Me.groupboxTipo.Controls.Add(Me.radiobuttonNinguno)
        Me.groupboxTipo.Controls.Add(Me.radiobuttonSalida)
        Me.groupboxTipo.Controls.Add(Me.radiobuttonEntrada)
        Me.groupboxTipo.Location = New System.Drawing.Point(92, 62)
        Me.groupboxTipo.Name = "groupboxTipo"
        Me.groupboxTipo.Size = New System.Drawing.Size(225, 33)
        Me.groupboxTipo.TabIndex = 5
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
        'comboboxPlanta
        '
        Me.comboboxPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxPlanta.FormattingEnabled = True
        Me.comboboxPlanta.Location = New System.Drawing.Point(92, 40)
        Me.comboboxPlanta.Name = "comboboxPlanta"
        Me.comboboxPlanta.Size = New System.Drawing.Size(230, 21)
        Me.comboboxPlanta.TabIndex = 3
        '
        'labelPlanta
        '
        Me.labelPlanta.AutoSize = True
        Me.labelPlanta.Location = New System.Drawing.Point(6, 43)
        Me.labelPlanta.Name = "labelPlanta"
        Me.labelPlanta.Size = New System.Drawing.Size(40, 13)
        Me.labelPlanta.TabIndex = 2
        Me.labelPlanta.Text = "Planta:"
        '
        'comboboxProducto
        '
        Me.comboboxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxProducto.FormattingEnabled = True
        Me.comboboxProducto.Location = New System.Drawing.Point(92, 13)
        Me.comboboxProducto.Name = "comboboxProducto"
        Me.comboboxProducto.Size = New System.Drawing.Size(230, 21)
        Me.comboboxProducto.TabIndex = 1
        '
        'labelProducto
        '
        Me.labelProducto.AutoSize = True
        Me.labelProducto.Location = New System.Drawing.Point(6, 16)
        Me.labelProducto.Name = "labelProducto"
        Me.labelProducto.Size = New System.Drawing.Size(53, 13)
        Me.labelProducto.TabIndex = 0
        Me.labelProducto.Text = "Producto:"
        '
        'groupboxEncabezado
        '
        Me.groupboxEncabezado.Controls.Add(Me.datetimepickerHoraFin)
        Me.groupboxEncabezado.Controls.Add(Me.datetimepickerFechaFin)
        Me.groupboxEncabezado.Controls.Add(Me.labelFin)
        Me.groupboxEncabezado.Controls.Add(Me.datetimepickerHoraInicio)
        Me.groupboxEncabezado.Controls.Add(Me.datetimepickerFechaInicio)
        Me.groupboxEncabezado.Controls.Add(Me.labelIDPesada)
        Me.groupboxEncabezado.Controls.Add(Me.textboxIDPesada)
        Me.groupboxEncabezado.Controls.Add(Me.labelInicio)
        Me.groupboxEncabezado.Location = New System.Drawing.Point(12, 42)
        Me.groupboxEncabezado.Name = "groupboxEncabezado"
        Me.groupboxEncabezado.Size = New System.Drawing.Size(328, 95)
        Me.groupboxEncabezado.TabIndex = 0
        Me.groupboxEncabezado.TabStop = False
        '
        'datetimepickerHoraFin
        '
        Me.datetimepickerHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.datetimepickerHoraFin.Location = New System.Drawing.Point(212, 65)
        Me.datetimepickerHoraFin.Name = "datetimepickerHoraFin"
        Me.datetimepickerHoraFin.ShowUpDown = True
        Me.datetimepickerHoraFin.Size = New System.Drawing.Size(85, 20)
        Me.datetimepickerHoraFin.TabIndex = 7
        '
        'datetimepickerFechaFin
        '
        Me.datetimepickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaFin.Location = New System.Drawing.Point(92, 65)
        Me.datetimepickerFechaFin.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaFin.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaFin.Name = "datetimepickerFechaFin"
        Me.datetimepickerFechaFin.Size = New System.Drawing.Size(114, 20)
        Me.datetimepickerFechaFin.TabIndex = 6
        '
        'labelFin
        '
        Me.labelFin.AutoSize = True
        Me.labelFin.Location = New System.Drawing.Point(6, 71)
        Me.labelFin.Name = "labelFin"
        Me.labelFin.Size = New System.Drawing.Size(24, 13)
        Me.labelFin.TabIndex = 5
        Me.labelFin.Text = "Fin:"
        '
        'datetimepickerHoraInicio
        '
        Me.datetimepickerHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.datetimepickerHoraInicio.Location = New System.Drawing.Point(212, 39)
        Me.datetimepickerHoraInicio.Name = "datetimepickerHoraInicio"
        Me.datetimepickerHoraInicio.ShowUpDown = True
        Me.datetimepickerHoraInicio.Size = New System.Drawing.Size(85, 20)
        Me.datetimepickerHoraInicio.TabIndex = 4
        '
        'datetimepickerFechaInicio
        '
        Me.datetimepickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaInicio.Location = New System.Drawing.Point(92, 39)
        Me.datetimepickerFechaInicio.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaInicio.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaInicio.Name = "datetimepickerFechaInicio"
        Me.datetimepickerFechaInicio.Size = New System.Drawing.Size(114, 20)
        Me.datetimepickerFechaInicio.TabIndex = 3
        '
        'labelIDPesada
        '
        Me.labelIDPesada.AutoSize = True
        Me.labelIDPesada.Location = New System.Drawing.Point(6, 16)
        Me.labelIDPesada.Name = "labelIDPesada"
        Me.labelIDPesada.Size = New System.Drawing.Size(76, 13)
        Me.labelIDPesada.TabIndex = 0
        Me.labelIDPesada.Text = "N° de Pesada:"
        '
        'textboxIDPesada
        '
        Me.textboxIDPesada.Location = New System.Drawing.Point(92, 13)
        Me.textboxIDPesada.MaxLength = 10
        Me.textboxIDPesada.Name = "textboxIDPesada"
        Me.textboxIDPesada.ReadOnly = True
        Me.textboxIDPesada.Size = New System.Drawing.Size(114, 20)
        Me.textboxIDPesada.TabIndex = 1
        Me.textboxIDPesada.TabStop = False
        Me.textboxIDPesada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'labelInicio
        '
        Me.labelInicio.AutoSize = True
        Me.labelInicio.Location = New System.Drawing.Point(6, 45)
        Me.labelInicio.Name = "labelInicio"
        Me.labelInicio.Size = New System.Drawing.Size(35, 13)
        Me.labelInicio.TabIndex = 2
        Me.labelInicio.Text = "Inicio:"
        '
        'groupboxKilogramo
        '
        Me.groupboxKilogramo.Controls.Add(Me.Label2)
        Me.groupboxKilogramo.Controls.Add(Me.textboxKilogramoNeto)
        Me.groupboxKilogramo.Controls.Add(Me.labelKilogramoTara)
        Me.groupboxKilogramo.Controls.Add(Me.textboxKilogramoTara)
        Me.groupboxKilogramo.Controls.Add(Me.labelKilogramoBruto)
        Me.groupboxKilogramo.Controls.Add(Me.textboxKilogramoBruto)
        Me.groupboxKilogramo.Location = New System.Drawing.Point(12, 461)
        Me.groupboxKilogramo.Name = "groupboxKilogramo"
        Me.groupboxKilogramo.Size = New System.Drawing.Size(328, 93)
        Me.groupboxKilogramo.TabIndex = 4
        Me.groupboxKilogramo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Kgs. Neto:"
        '
        'textboxKilogramoNeto
        '
        Me.textboxKilogramoNeto.BackGroundColor = System.Drawing.SystemColors.Window
        Me.textboxKilogramoNeto.BeforeTouchSize = New System.Drawing.Size(53, 20)
        Me.textboxKilogramoNeto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textboxKilogramoNeto.IntegerValue = CType(0, Long)
        Me.textboxKilogramoNeto.Location = New System.Drawing.Point(92, 65)
        Me.textboxKilogramoNeto.MaxValue = CType(99999, Long)
        Me.textboxKilogramoNeto.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.textboxKilogramoNeto.MinValue = CType(0, Long)
        Me.textboxKilogramoNeto.Name = "textboxKilogramoNeto"
        Me.textboxKilogramoNeto.NullString = ""
        Me.textboxKilogramoNeto.NumberNegativePattern = 0
        Me.textboxKilogramoNeto.ReadOnly = True
        Me.textboxKilogramoNeto.Size = New System.Drawing.Size(53, 20)
        Me.textboxKilogramoNeto.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.textboxKilogramoNeto.TabIndex = 5
        Me.textboxKilogramoNeto.Text = "0"
        Me.textboxKilogramoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.textboxKilogramoNeto.WordWrap = False
        '
        'labelKilogramoTara
        '
        Me.labelKilogramoTara.AutoSize = True
        Me.labelKilogramoTara.Location = New System.Drawing.Point(6, 42)
        Me.labelKilogramoTara.Name = "labelKilogramoTara"
        Me.labelKilogramoTara.Size = New System.Drawing.Size(56, 13)
        Me.labelKilogramoTara.TabIndex = 2
        Me.labelKilogramoTara.Text = "Kgs. Tara:"
        '
        'textboxKilogramoTara
        '
        Me.textboxKilogramoTara.BackGroundColor = System.Drawing.SystemColors.Window
        Me.textboxKilogramoTara.BeforeTouchSize = New System.Drawing.Size(53, 20)
        Me.textboxKilogramoTara.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textboxKilogramoTara.IntegerValue = CType(0, Long)
        Me.textboxKilogramoTara.Location = New System.Drawing.Point(92, 39)
        Me.textboxKilogramoTara.MaxValue = CType(99999, Long)
        Me.textboxKilogramoTara.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.textboxKilogramoTara.MinValue = CType(0, Long)
        Me.textboxKilogramoTara.Name = "textboxKilogramoTara"
        Me.textboxKilogramoTara.NullString = ""
        Me.textboxKilogramoTara.NumberNegativePattern = 0
        Me.textboxKilogramoTara.Size = New System.Drawing.Size(53, 20)
        Me.textboxKilogramoTara.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.textboxKilogramoTara.TabIndex = 3
        Me.textboxKilogramoTara.Text = "0"
        Me.textboxKilogramoTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.textboxKilogramoTara.WordWrap = False
        '
        'labelKilogramoBruto
        '
        Me.labelKilogramoBruto.AutoSize = True
        Me.labelKilogramoBruto.Location = New System.Drawing.Point(6, 16)
        Me.labelKilogramoBruto.Name = "labelKilogramoBruto"
        Me.labelKilogramoBruto.Size = New System.Drawing.Size(59, 13)
        Me.labelKilogramoBruto.TabIndex = 0
        Me.labelKilogramoBruto.Text = "Kgs. Bruto:"
        '
        'textboxKilogramoBruto
        '
        Me.textboxKilogramoBruto.BackGroundColor = System.Drawing.SystemColors.Window
        Me.textboxKilogramoBruto.BeforeTouchSize = New System.Drawing.Size(53, 20)
        Me.textboxKilogramoBruto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textboxKilogramoBruto.IntegerValue = CType(0, Long)
        Me.textboxKilogramoBruto.Location = New System.Drawing.Point(92, 13)
        Me.textboxKilogramoBruto.MaxValue = CType(99999, Long)
        Me.textboxKilogramoBruto.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.textboxKilogramoBruto.MinValue = CType(0, Long)
        Me.textboxKilogramoBruto.Name = "textboxKilogramoBruto"
        Me.textboxKilogramoBruto.NullString = ""
        Me.textboxKilogramoBruto.NumberNegativePattern = 0
        Me.textboxKilogramoBruto.Size = New System.Drawing.Size(53, 20)
        Me.textboxKilogramoBruto.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.textboxKilogramoBruto.TabIndex = 1
        Me.textboxKilogramoBruto.Text = "0"
        Me.textboxKilogramoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.textboxKilogramoBruto.WordWrap = False
        '
        'formPesada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 564)
        Me.Controls.Add(Me.groupboxKilogramo)
        Me.Controls.Add(Me.groupboxEncabezado)
        Me.Controls.Add(Me.groupboxProductoPlanta)
        Me.Controls.Add(Me.groupboxTitular)
        Me.Controls.Add(Me.groupboxTransporte)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "formPesada"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle de la Entidad"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.groupboxTransporte.ResumeLayout(False)
        Me.groupboxTransporte.PerformLayout()
        Me.groupboxTitular.ResumeLayout(False)
        Me.groupboxTitular.PerformLayout()
        Me.groupboxProductoPlanta.ResumeLayout(False)
        Me.groupboxProductoPlanta.PerformLayout()
        Me.groupboxTipo.ResumeLayout(False)
        Me.groupboxTipo.PerformLayout()
        Me.groupboxEncabezado.ResumeLayout(False)
        Me.groupboxEncabezado.PerformLayout()
        Me.groupboxKilogramo.ResumeLayout(False)
        Me.groupboxKilogramo.PerformLayout()
        CType(Me.textboxKilogramoNeto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textboxKilogramoTara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textboxKilogramoBruto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tooltipMain As System.Windows.Forms.ToolTip
    Friend WithEvents groupboxTransporte As System.Windows.Forms.GroupBox
    Friend WithEvents labelChofer As System.Windows.Forms.Label
    Friend WithEvents comboboxChofer As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxTransportista As System.Windows.Forms.ComboBox
    Friend WithEvents labelCamion As System.Windows.Forms.Label
    Friend WithEvents labelTransportista As System.Windows.Forms.Label
    Friend WithEvents comboboxCamion As System.Windows.Forms.ComboBox
    Friend WithEvents groupboxTitular As System.Windows.Forms.GroupBox
    Friend WithEvents comboboxOrigenDestino As System.Windows.Forms.ComboBox
    Friend WithEvents labelOrigenDestino As System.Windows.Forms.Label
    Friend WithEvents comboboxTitular As System.Windows.Forms.ComboBox
    Friend WithEvents labelTitular As System.Windows.Forms.Label
    Friend WithEvents groupboxProductoPlanta As System.Windows.Forms.GroupBox
    Friend WithEvents comboboxCosecha As System.Windows.Forms.ComboBox
    Friend WithEvents labelCosecha As System.Windows.Forms.Label
    Friend WithEvents groupboxTipo As System.Windows.Forms.GroupBox
    Friend WithEvents radiobuttonNinguno As System.Windows.Forms.RadioButton
    Friend WithEvents radiobuttonSalida As System.Windows.Forms.RadioButton
    Friend WithEvents radiobuttonEntrada As System.Windows.Forms.RadioButton
    Friend WithEvents comboboxPlanta As System.Windows.Forms.ComboBox
    Friend WithEvents labelPlanta As System.Windows.Forms.Label
    Friend WithEvents comboboxProducto As System.Windows.Forms.ComboBox
    Friend WithEvents labelProducto As System.Windows.Forms.Label
    Friend WithEvents groupboxEncabezado As System.Windows.Forms.GroupBox
    Friend WithEvents datetimepickerHoraFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents datetimepickerFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelFin As System.Windows.Forms.Label
    Friend WithEvents datetimepickerHoraInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents datetimepickerFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents labelIDPesada As System.Windows.Forms.Label
    Friend WithEvents textboxIDPesada As System.Windows.Forms.TextBox
    Friend WithEvents labelInicio As System.Windows.Forms.Label
    Friend WithEvents groupboxKilogramo As System.Windows.Forms.GroupBox
    Friend WithEvents labelKilogramoBruto As System.Windows.Forms.Label
    Friend WithEvents textboxKilogramoBruto As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents textboxKilogramoNeto As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents labelKilogramoTara As System.Windows.Forms.Label
    Friend WithEvents textboxKilogramoTara As Syncfusion.Windows.Forms.Tools.IntegerTextBox
End Class
