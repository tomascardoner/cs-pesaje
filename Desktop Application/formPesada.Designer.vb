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
        Me.checkboxProductoTodos = New System.Windows.Forms.CheckBox()
        Me.checkboxTipoTodos = New System.Windows.Forms.CheckBox()
        Me.checkboxTitularTodos = New System.Windows.Forms.CheckBox()
        Me.labelChoferCUIT_CUIL = New System.Windows.Forms.Label()
        Me.checkboxTransportistaTodos = New System.Windows.Forms.CheckBox()
        Me.checkboxChoferTodos = New System.Windows.Forms.CheckBox()
        Me.checkboxCamionTodos = New System.Windows.Forms.CheckBox()
        Me.groupboxTransporte = New System.Windows.Forms.GroupBox()
        Me.labelCamion_DominioAcoplado = New System.Windows.Forms.Label()
        Me.textboxCamion_DominioAcoplado = New System.Windows.Forms.TextBox()
        Me.textboxCamion_DominioChasis = New System.Windows.Forms.TextBox()
        Me.textboxChofer = New System.Windows.Forms.TextBox()
        Me.maskedtextboxChoferCUIT_CUIL = New System.Windows.Forms.MaskedTextBox()
        Me.maskedtextboxTransportistaCUIT = New System.Windows.Forms.MaskedTextBox()
        Me.labelTransportistaCUIT = New System.Windows.Forms.Label()
        Me.textboxTransportista = New System.Windows.Forms.TextBox()
        Me.labelChofer = New System.Windows.Forms.Label()
        Me.comboboxChofer = New System.Windows.Forms.ComboBox()
        Me.comboboxTransportista = New System.Windows.Forms.ComboBox()
        Me.labelCamion = New System.Windows.Forms.Label()
        Me.labelTransportista = New System.Windows.Forms.Label()
        Me.comboboxCamion = New System.Windows.Forms.ComboBox()
        Me.groupboxTitular = New System.Windows.Forms.GroupBox()
        Me.textboxOrigenDestino = New System.Windows.Forms.TextBox()
        Me.textboxTitular = New System.Windows.Forms.TextBox()
        Me.comboboxOrigenDestino = New System.Windows.Forms.ComboBox()
        Me.comboboxTitular = New System.Windows.Forms.ComboBox()
        Me.groupboxProductoPlantaCosecha = New System.Windows.Forms.GroupBox()
        Me.textboxProducto = New System.Windows.Forms.TextBox()
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
        Me.labelComprobanteNumero = New System.Windows.Forms.Label()
        Me.maskedtextboxComprobanteNumero = New System.Windows.Forms.MaskedTextBox()
        Me.datetimepickerHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.labelFin = New System.Windows.Forms.Label()
        Me.datetimepickerHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.datetimepickerFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.labelIDPesada = New System.Windows.Forms.Label()
        Me.textboxIDPesada = New System.Windows.Forms.TextBox()
        Me.labelInicio = New System.Windows.Forms.Label()
        Me.groupboxKilogramo = New System.Windows.Forms.GroupBox()
        Me.labelKilogramoNeto = New System.Windows.Forms.Label()
        Me.integertextboxKilogramoNeto = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.labelKilogramoTara = New System.Windows.Forms.Label()
        Me.integertextboxKilogramoTara = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.labelKilogramoBruto = New System.Windows.Forms.Label()
        Me.integertextboxKilogramoBruto = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.groupboxNotas = New System.Windows.Forms.GroupBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        Me.groupboxAnalisis = New System.Windows.Forms.GroupBox()
        Me.labelMezclado = New System.Windows.Forms.Label()
        Me.checkboxMezclado = New System.Windows.Forms.CheckBox()
        Me.labelFumigado = New System.Windows.Forms.Label()
        Me.checkboxFumigado = New System.Windows.Forms.CheckBox()
        Me.doubletextboxGluten = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelGluten = New System.Windows.Forms.Label()
        Me.doubletextboxPesoHectolitrico = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelPesoHectolitrico = New System.Windows.Forms.Label()
        Me.doubletextboxGranoDaniado = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelGranoDaniado = New System.Windows.Forms.Label()
        Me.doubletextboxGranoVerde = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelGranoVerde = New System.Windows.Forms.Label()
        Me.doubletextboxZaranda = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelZaranda = New System.Windows.Forms.Label()
        Me.doubletextboxHumedad = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelHumedad = New System.Windows.Forms.Label()
        labelTipo = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.groupboxTransporte.SuspendLayout()
        Me.groupboxTitular.SuspendLayout()
        Me.groupboxProductoPlantaCosecha.SuspendLayout()
        Me.groupboxTipo.SuspendLayout()
        Me.groupboxEncabezado.SuspendLayout()
        Me.groupboxKilogramo.SuspendLayout()
        CType(Me.integertextboxKilogramoNeto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.integertextboxKilogramoTara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.integertextboxKilogramoBruto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupboxNotas.SuspendLayout()
        Me.groupboxAnalisis.SuspendLayout()
        CType(Me.doubletextboxGluten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxPesoHectolitrico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxGranoDaniado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxGranoVerde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxZaranda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxHumedad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelTipo
        '
        labelTipo.AutoSize = True
        labelTipo.Location = New System.Drawing.Point(6, 74)
        labelTipo.Name = "labelTipo"
        labelTipo.Size = New System.Drawing.Size(31, 13)
        labelTipo.TabIndex = 6
        labelTipo.Text = "Tipo:"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(742, 39)
        Me.toolstripMain.TabIndex = 7
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
        Me.labelOrigenDestino.Size = New System.Drawing.Size(82, 13)
        Me.labelOrigenDestino.TabIndex = 6
        Me.labelOrigenDestino.Text = "Origen/Destino:"
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
        'checkboxProductoTodos
        '
        Me.checkboxProductoTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxProductoTodos.Location = New System.Drawing.Point(326, 13)
        Me.checkboxProductoTodos.Name = "checkboxProductoTodos"
        Me.checkboxProductoTodos.Size = New System.Drawing.Size(21, 21)
        Me.checkboxProductoTodos.TabIndex = 3
        Me.checkboxProductoTodos.TabStop = False
        Me.checkboxProductoTodos.Text = "+"
        Me.checkboxProductoTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxProductoTodos, "Ver todos")
        Me.checkboxProductoTodos.UseVisualStyleBackColor = True
        '
        'checkboxTipoTodos
        '
        Me.checkboxTipoTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxTipoTodos.Location = New System.Drawing.Point(234, 9)
        Me.checkboxTipoTodos.Name = "checkboxTipoTodos"
        Me.checkboxTipoTodos.Size = New System.Drawing.Size(21, 21)
        Me.checkboxTipoTodos.TabIndex = 3
        Me.checkboxTipoTodos.TabStop = False
        Me.checkboxTipoTodos.Text = "+"
        Me.checkboxTipoTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxTipoTodos, "Ver todos")
        Me.checkboxTipoTodos.UseVisualStyleBackColor = True
        '
        'checkboxTitularTodos
        '
        Me.checkboxTitularTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxTitularTodos.Location = New System.Drawing.Point(326, 12)
        Me.checkboxTitularTodos.Name = "checkboxTitularTodos"
        Me.checkboxTitularTodos.Size = New System.Drawing.Size(21, 21)
        Me.checkboxTitularTodos.TabIndex = 5
        Me.checkboxTitularTodos.TabStop = False
        Me.checkboxTitularTodos.Text = "+"
        Me.checkboxTitularTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxTitularTodos, "Ver todos")
        Me.checkboxTitularTodos.UseVisualStyleBackColor = True
        '
        'labelChoferCUIT_CUIL
        '
        Me.labelChoferCUIT_CUIL.AutoSize = True
        Me.labelChoferCUIT_CUIL.Location = New System.Drawing.Point(6, 96)
        Me.labelChoferCUIT_CUIL.Name = "labelChoferCUIT_CUIL"
        Me.labelChoferCUIT_CUIL.Size = New System.Drawing.Size(70, 13)
        Me.labelChoferCUIT_CUIL.TabIndex = 10
        Me.labelChoferCUIT_CUIL.Text = "CUIT / CUIL:"
        Me.tooltipMain.SetToolTip(Me.labelChoferCUIT_CUIL, "Ingrese el Número de Documento sin utilizar puntos.")
        '
        'checkboxTransportistaTodos
        '
        Me.checkboxTransportistaTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxTransportistaTodos.Location = New System.Drawing.Point(326, 12)
        Me.checkboxTransportistaTodos.Name = "checkboxTransportistaTodos"
        Me.checkboxTransportistaTodos.Size = New System.Drawing.Size(21, 21)
        Me.checkboxTransportistaTodos.TabIndex = 3
        Me.checkboxTransportistaTodos.TabStop = False
        Me.checkboxTransportistaTodos.Text = "+"
        Me.checkboxTransportistaTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxTransportistaTodos, "Ver todos")
        Me.checkboxTransportistaTodos.UseVisualStyleBackColor = True
        '
        'checkboxChoferTodos
        '
        Me.checkboxChoferTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxChoferTodos.Location = New System.Drawing.Point(326, 66)
        Me.checkboxChoferTodos.Name = "checkboxChoferTodos"
        Me.checkboxChoferTodos.Size = New System.Drawing.Size(21, 21)
        Me.checkboxChoferTodos.TabIndex = 9
        Me.checkboxChoferTodos.TabStop = False
        Me.checkboxChoferTodos.Text = "+"
        Me.checkboxChoferTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxChoferTodos, "Ver todos")
        Me.checkboxChoferTodos.UseVisualStyleBackColor = True
        '
        'checkboxCamionTodos
        '
        Me.checkboxCamionTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxCamionTodos.Location = New System.Drawing.Point(326, 119)
        Me.checkboxCamionTodos.Name = "checkboxCamionTodos"
        Me.checkboxCamionTodos.Size = New System.Drawing.Size(21, 21)
        Me.checkboxCamionTodos.TabIndex = 17
        Me.checkboxCamionTodos.TabStop = False
        Me.checkboxCamionTodos.Text = "+"
        Me.checkboxCamionTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxCamionTodos, "Ver todos")
        Me.checkboxCamionTodos.UseVisualStyleBackColor = True
        '
        'groupboxTransporte
        '
        Me.groupboxTransporte.Controls.Add(Me.checkboxCamionTodos)
        Me.groupboxTransporte.Controls.Add(Me.checkboxChoferTodos)
        Me.groupboxTransporte.Controls.Add(Me.checkboxTransportistaTodos)
        Me.groupboxTransporte.Controls.Add(Me.labelCamion_DominioAcoplado)
        Me.groupboxTransporte.Controls.Add(Me.textboxCamion_DominioAcoplado)
        Me.groupboxTransporte.Controls.Add(Me.textboxCamion_DominioChasis)
        Me.groupboxTransporte.Controls.Add(Me.textboxChofer)
        Me.groupboxTransporte.Controls.Add(Me.maskedtextboxChoferCUIT_CUIL)
        Me.groupboxTransporte.Controls.Add(Me.labelChoferCUIT_CUIL)
        Me.groupboxTransporte.Controls.Add(Me.maskedtextboxTransportistaCUIT)
        Me.groupboxTransporte.Controls.Add(Me.labelTransportistaCUIT)
        Me.groupboxTransporte.Controls.Add(Me.textboxTransportista)
        Me.groupboxTransporte.Controls.Add(Me.labelChofer)
        Me.groupboxTransporte.Controls.Add(Me.comboboxChofer)
        Me.groupboxTransporte.Controls.Add(Me.comboboxTransportista)
        Me.groupboxTransporte.Controls.Add(Me.labelCamion)
        Me.groupboxTransporte.Controls.Add(Me.labelTransportista)
        Me.groupboxTransporte.Controls.Add(Me.comboboxCamion)
        Me.groupboxTransporte.Location = New System.Drawing.Point(381, 42)
        Me.groupboxTransporte.Name = "groupboxTransporte"
        Me.groupboxTransporte.Size = New System.Drawing.Size(353, 149)
        Me.groupboxTransporte.TabIndex = 3
        Me.groupboxTransporte.TabStop = False
        '
        'labelCamion_DominioAcoplado
        '
        Me.labelCamion_DominioAcoplado.AutoSize = True
        Me.labelCamion_DominioAcoplado.Location = New System.Drawing.Point(193, 123)
        Me.labelCamion_DominioAcoplado.Name = "labelCamion_DominioAcoplado"
        Me.labelCamion_DominioAcoplado.Size = New System.Drawing.Size(55, 13)
        Me.labelCamion_DominioAcoplado.TabIndex = 15
        Me.labelCamion_DominioAcoplado.Text = "Acoplado:"
        '
        'textboxCamion_DominioAcoplado
        '
        Me.textboxCamion_DominioAcoplado.Location = New System.Drawing.Point(254, 119)
        Me.textboxCamion_DominioAcoplado.MaxLength = 7
        Me.textboxCamion_DominioAcoplado.Name = "textboxCamion_DominioAcoplado"
        Me.textboxCamion_DominioAcoplado.Size = New System.Drawing.Size(68, 20)
        Me.textboxCamion_DominioAcoplado.TabIndex = 16
        '
        'textboxCamion_DominioChasis
        '
        Me.textboxCamion_DominioChasis.Location = New System.Drawing.Point(92, 119)
        Me.textboxCamion_DominioChasis.MaxLength = 7
        Me.textboxCamion_DominioChasis.Name = "textboxCamion_DominioChasis"
        Me.textboxCamion_DominioChasis.Size = New System.Drawing.Size(68, 20)
        Me.textboxCamion_DominioChasis.TabIndex = 14
        '
        'textboxChofer
        '
        Me.textboxChofer.Location = New System.Drawing.Point(176, 66)
        Me.textboxChofer.MaxLength = 50
        Me.textboxChofer.Name = "textboxChofer"
        Me.textboxChofer.Size = New System.Drawing.Size(146, 20)
        Me.textboxChofer.TabIndex = 8
        '
        'maskedtextboxChoferCUIT_CUIL
        '
        Me.maskedtextboxChoferCUIT_CUIL.AllowPromptAsInput = False
        Me.maskedtextboxChoferCUIT_CUIL.AsciiOnly = True
        Me.maskedtextboxChoferCUIT_CUIL.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxChoferCUIT_CUIL.HidePromptOnLeave = True
        Me.maskedtextboxChoferCUIT_CUIL.Location = New System.Drawing.Point(92, 93)
        Me.maskedtextboxChoferCUIT_CUIL.Mask = "00-00000000-0"
        Me.maskedtextboxChoferCUIT_CUIL.Name = "maskedtextboxChoferCUIT_CUIL"
        Me.maskedtextboxChoferCUIT_CUIL.Size = New System.Drawing.Size(90, 20)
        Me.maskedtextboxChoferCUIT_CUIL.TabIndex = 11
        Me.maskedtextboxChoferCUIT_CUIL.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'maskedtextboxTransportistaCUIT
        '
        Me.maskedtextboxTransportistaCUIT.AllowPromptAsInput = False
        Me.maskedtextboxTransportistaCUIT.AsciiOnly = True
        Me.maskedtextboxTransportistaCUIT.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxTransportistaCUIT.HidePromptOnLeave = True
        Me.maskedtextboxTransportistaCUIT.Location = New System.Drawing.Point(92, 40)
        Me.maskedtextboxTransportistaCUIT.Mask = "00-00000000-0"
        Me.maskedtextboxTransportistaCUIT.Name = "maskedtextboxTransportistaCUIT"
        Me.maskedtextboxTransportistaCUIT.Size = New System.Drawing.Size(90, 20)
        Me.maskedtextboxTransportistaCUIT.TabIndex = 5
        Me.maskedtextboxTransportistaCUIT.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'labelTransportistaCUIT
        '
        Me.labelTransportistaCUIT.AutoSize = True
        Me.labelTransportistaCUIT.Location = New System.Drawing.Point(6, 43)
        Me.labelTransportistaCUIT.Name = "labelTransportistaCUIT"
        Me.labelTransportistaCUIT.Size = New System.Drawing.Size(35, 13)
        Me.labelTransportistaCUIT.TabIndex = 4
        Me.labelTransportistaCUIT.Text = "CUIT:"
        '
        'textboxTransportista
        '
        Me.textboxTransportista.Location = New System.Drawing.Point(176, 13)
        Me.textboxTransportista.MaxLength = 50
        Me.textboxTransportista.Name = "textboxTransportista"
        Me.textboxTransportista.Size = New System.Drawing.Size(146, 20)
        Me.textboxTransportista.TabIndex = 2
        '
        'labelChofer
        '
        Me.labelChofer.AutoSize = True
        Me.labelChofer.Location = New System.Drawing.Point(6, 69)
        Me.labelChofer.Name = "labelChofer"
        Me.labelChofer.Size = New System.Drawing.Size(41, 13)
        Me.labelChofer.TabIndex = 6
        Me.labelChofer.Text = "Chofer:"
        '
        'comboboxChofer
        '
        Me.comboboxChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxChofer.FormattingEnabled = True
        Me.comboboxChofer.Location = New System.Drawing.Point(92, 66)
        Me.comboboxChofer.Name = "comboboxChofer"
        Me.comboboxChofer.Size = New System.Drawing.Size(230, 21)
        Me.comboboxChofer.TabIndex = 7
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
        Me.labelCamion.Location = New System.Drawing.Point(6, 122)
        Me.labelCamion.Name = "labelCamion"
        Me.labelCamion.Size = New System.Drawing.Size(45, 13)
        Me.labelCamion.TabIndex = 12
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
        Me.comboboxCamion.Location = New System.Drawing.Point(92, 119)
        Me.comboboxCamion.Name = "comboboxCamion"
        Me.comboboxCamion.Size = New System.Drawing.Size(230, 21)
        Me.comboboxCamion.TabIndex = 13
        '
        'groupboxTitular
        '
        Me.groupboxTitular.Controls.Add(Me.textboxOrigenDestino)
        Me.groupboxTitular.Controls.Add(Me.textboxTitular)
        Me.groupboxTitular.Controls.Add(Me.checkboxTitularTodos)
        Me.groupboxTitular.Controls.Add(Me.comboboxOrigenDestino)
        Me.groupboxTitular.Controls.Add(Me.labelOrigenDestino)
        Me.groupboxTitular.Controls.Add(Me.comboboxTitular)
        Me.groupboxTitular.Controls.Add(Me.labelTitular)
        Me.groupboxTitular.Location = New System.Drawing.Point(12, 308)
        Me.groupboxTitular.Name = "groupboxTitular"
        Me.groupboxTitular.Size = New System.Drawing.Size(353, 71)
        Me.groupboxTitular.TabIndex = 2
        Me.groupboxTitular.TabStop = False
        '
        'textboxOrigenDestino
        '
        Me.textboxOrigenDestino.Location = New System.Drawing.Point(176, 40)
        Me.textboxOrigenDestino.MaxLength = 50
        Me.textboxOrigenDestino.Name = "textboxOrigenDestino"
        Me.textboxOrigenDestino.Size = New System.Drawing.Size(146, 20)
        Me.textboxOrigenDestino.TabIndex = 1
        '
        'textboxTitular
        '
        Me.textboxTitular.Location = New System.Drawing.Point(176, 13)
        Me.textboxTitular.MaxLength = 50
        Me.textboxTitular.Name = "textboxTitular"
        Me.textboxTitular.Size = New System.Drawing.Size(146, 20)
        Me.textboxTitular.TabIndex = 4
        '
        'comboboxOrigenDestino
        '
        Me.comboboxOrigenDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxOrigenDestino.FormattingEnabled = True
        Me.comboboxOrigenDestino.Location = New System.Drawing.Point(92, 40)
        Me.comboboxOrigenDestino.Name = "comboboxOrigenDestino"
        Me.comboboxOrigenDestino.Size = New System.Drawing.Size(230, 21)
        Me.comboboxOrigenDestino.TabIndex = 0
        '
        'comboboxTitular
        '
        Me.comboboxTitular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxTitular.FormattingEnabled = True
        Me.comboboxTitular.Location = New System.Drawing.Point(92, 13)
        Me.comboboxTitular.Name = "comboboxTitular"
        Me.comboboxTitular.Size = New System.Drawing.Size(230, 21)
        Me.comboboxTitular.TabIndex = 3
        '
        'groupboxProductoPlantaCosecha
        '
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.textboxProducto)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.checkboxProductoTodos)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.comboboxCosecha)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.labelCosecha)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.groupboxTipo)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.comboboxPlanta)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.labelPlanta)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.comboboxProducto)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.labelProducto)
        Me.groupboxProductoPlantaCosecha.Controls.Add(labelTipo)
        Me.groupboxProductoPlantaCosecha.Location = New System.Drawing.Point(12, 170)
        Me.groupboxProductoPlantaCosecha.Name = "groupboxProductoPlantaCosecha"
        Me.groupboxProductoPlantaCosecha.Size = New System.Drawing.Size(353, 132)
        Me.groupboxProductoPlantaCosecha.TabIndex = 1
        Me.groupboxProductoPlantaCosecha.TabStop = False
        '
        'textboxProducto
        '
        Me.textboxProducto.Location = New System.Drawing.Point(176, 13)
        Me.textboxProducto.MaxLength = 50
        Me.textboxProducto.Name = "textboxProducto"
        Me.textboxProducto.Size = New System.Drawing.Size(146, 20)
        Me.textboxProducto.TabIndex = 2
        '
        'comboboxCosecha
        '
        Me.comboboxCosecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCosecha.FormattingEnabled = True
        Me.comboboxCosecha.Location = New System.Drawing.Point(92, 101)
        Me.comboboxCosecha.Name = "comboboxCosecha"
        Me.comboboxCosecha.Size = New System.Drawing.Size(121, 21)
        Me.comboboxCosecha.TabIndex = 9
        '
        'labelCosecha
        '
        Me.labelCosecha.AutoSize = True
        Me.labelCosecha.Location = New System.Drawing.Point(6, 104)
        Me.labelCosecha.Name = "labelCosecha"
        Me.labelCosecha.Size = New System.Drawing.Size(52, 13)
        Me.labelCosecha.TabIndex = 8
        Me.labelCosecha.Text = "Cosecha:"
        '
        'groupboxTipo
        '
        Me.groupboxTipo.Controls.Add(Me.checkboxTipoTodos)
        Me.groupboxTipo.Controls.Add(Me.radiobuttonNinguno)
        Me.groupboxTipo.Controls.Add(Me.radiobuttonSalida)
        Me.groupboxTipo.Controls.Add(Me.radiobuttonEntrada)
        Me.groupboxTipo.Location = New System.Drawing.Point(92, 62)
        Me.groupboxTipo.Name = "groupboxTipo"
        Me.groupboxTipo.Size = New System.Drawing.Size(255, 33)
        Me.groupboxTipo.TabIndex = 7
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
        Me.comboboxPlanta.TabIndex = 5
        '
        'labelPlanta
        '
        Me.labelPlanta.AutoSize = True
        Me.labelPlanta.Location = New System.Drawing.Point(6, 43)
        Me.labelPlanta.Name = "labelPlanta"
        Me.labelPlanta.Size = New System.Drawing.Size(40, 13)
        Me.labelPlanta.TabIndex = 4
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
        Me.groupboxEncabezado.Controls.Add(Me.labelComprobanteNumero)
        Me.groupboxEncabezado.Controls.Add(Me.maskedtextboxComprobanteNumero)
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
        Me.groupboxEncabezado.Size = New System.Drawing.Size(353, 122)
        Me.groupboxEncabezado.TabIndex = 0
        Me.groupboxEncabezado.TabStop = False
        '
        'labelComprobanteNumero
        '
        Me.labelComprobanteNumero.AutoSize = True
        Me.labelComprobanteNumero.Location = New System.Drawing.Point(6, 96)
        Me.labelComprobanteNumero.Name = "labelComprobanteNumero"
        Me.labelComprobanteNumero.Size = New System.Drawing.Size(70, 13)
        Me.labelComprobanteNumero.TabIndex = 8
        Me.labelComprobanteNumero.Text = "Nº Comprob.:"
        '
        'maskedtextboxComprobanteNumero
        '
        Me.maskedtextboxComprobanteNumero.AllowPromptAsInput = False
        Me.maskedtextboxComprobanteNumero.AsciiOnly = True
        Me.maskedtextboxComprobanteNumero.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxComprobanteNumero.HidePromptOnLeave = True
        Me.maskedtextboxComprobanteNumero.Location = New System.Drawing.Point(92, 91)
        Me.maskedtextboxComprobanteNumero.Mask = "0000-00000000"
        Me.maskedtextboxComprobanteNumero.Name = "maskedtextboxComprobanteNumero"
        Me.maskedtextboxComprobanteNumero.Size = New System.Drawing.Size(90, 20)
        Me.maskedtextboxComprobanteNumero.TabIndex = 9
        Me.maskedtextboxComprobanteNumero.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'datetimepickerHoraFin
        '
        Me.datetimepickerHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.datetimepickerHoraFin.Location = New System.Drawing.Point(212, 65)
        Me.datetimepickerHoraFin.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerHoraFin.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
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
        Me.labelFin.Location = New System.Drawing.Point(6, 69)
        Me.labelFin.Name = "labelFin"
        Me.labelFin.Size = New System.Drawing.Size(24, 13)
        Me.labelFin.TabIndex = 5
        Me.labelFin.Text = "Fin:"
        '
        'datetimepickerHoraInicio
        '
        Me.datetimepickerHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.datetimepickerHoraInicio.Location = New System.Drawing.Point(212, 39)
        Me.datetimepickerHoraInicio.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerHoraInicio.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
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
        Me.labelInicio.Location = New System.Drawing.Point(6, 43)
        Me.labelInicio.Name = "labelInicio"
        Me.labelInicio.Size = New System.Drawing.Size(35, 13)
        Me.labelInicio.TabIndex = 2
        Me.labelInicio.Text = "Inicio:"
        '
        'groupboxKilogramo
        '
        Me.groupboxKilogramo.Controls.Add(Me.labelKilogramoNeto)
        Me.groupboxKilogramo.Controls.Add(Me.integertextboxKilogramoNeto)
        Me.groupboxKilogramo.Controls.Add(Me.labelKilogramoTara)
        Me.groupboxKilogramo.Controls.Add(Me.integertextboxKilogramoTara)
        Me.groupboxKilogramo.Controls.Add(Me.labelKilogramoBruto)
        Me.groupboxKilogramo.Controls.Add(Me.integertextboxKilogramoBruto)
        Me.groupboxKilogramo.Location = New System.Drawing.Point(381, 197)
        Me.groupboxKilogramo.Name = "groupboxKilogramo"
        Me.groupboxKilogramo.Size = New System.Drawing.Size(153, 93)
        Me.groupboxKilogramo.TabIndex = 4
        Me.groupboxKilogramo.TabStop = False
        '
        'labelKilogramoNeto
        '
        Me.labelKilogramoNeto.AutoSize = True
        Me.labelKilogramoNeto.Location = New System.Drawing.Point(6, 68)
        Me.labelKilogramoNeto.Name = "labelKilogramoNeto"
        Me.labelKilogramoNeto.Size = New System.Drawing.Size(57, 13)
        Me.labelKilogramoNeto.TabIndex = 4
        Me.labelKilogramoNeto.Text = "Kgs. Neto:"
        '
        'integertextboxKilogramoNeto
        '
        Me.integertextboxKilogramoNeto.BackGroundColor = System.Drawing.SystemColors.Window
        Me.integertextboxKilogramoNeto.BeforeTouchSize = New System.Drawing.Size(38, 20)
        Me.integertextboxKilogramoNeto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.integertextboxKilogramoNeto.IntegerValue = CType(0, Long)
        Me.integertextboxKilogramoNeto.Location = New System.Drawing.Point(92, 65)
        Me.integertextboxKilogramoNeto.MaxValue = CType(99999, Long)
        Me.integertextboxKilogramoNeto.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.integertextboxKilogramoNeto.MinValue = CType(0, Long)
        Me.integertextboxKilogramoNeto.Name = "integertextboxKilogramoNeto"
        Me.integertextboxKilogramoNeto.NullString = ""
        Me.integertextboxKilogramoNeto.NumberNegativePattern = 0
        Me.integertextboxKilogramoNeto.ReadOnly = True
        Me.integertextboxKilogramoNeto.Size = New System.Drawing.Size(53, 20)
        Me.integertextboxKilogramoNeto.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.integertextboxKilogramoNeto.TabIndex = 5
        Me.integertextboxKilogramoNeto.Text = "0"
        Me.integertextboxKilogramoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.integertextboxKilogramoNeto.WordWrap = False
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
        'integertextboxKilogramoTara
        '
        Me.integertextboxKilogramoTara.BackGroundColor = System.Drawing.SystemColors.Window
        Me.integertextboxKilogramoTara.BeforeTouchSize = New System.Drawing.Size(38, 20)
        Me.integertextboxKilogramoTara.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.integertextboxKilogramoTara.IntegerValue = CType(0, Long)
        Me.integertextboxKilogramoTara.Location = New System.Drawing.Point(92, 39)
        Me.integertextboxKilogramoTara.MaxValue = CType(99999, Long)
        Me.integertextboxKilogramoTara.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.integertextboxKilogramoTara.MinValue = CType(0, Long)
        Me.integertextboxKilogramoTara.Name = "integertextboxKilogramoTara"
        Me.integertextboxKilogramoTara.NullString = ""
        Me.integertextboxKilogramoTara.NumberNegativePattern = 0
        Me.integertextboxKilogramoTara.Size = New System.Drawing.Size(53, 20)
        Me.integertextboxKilogramoTara.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.integertextboxKilogramoTara.TabIndex = 3
        Me.integertextboxKilogramoTara.Text = "0"
        Me.integertextboxKilogramoTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.integertextboxKilogramoTara.WordWrap = False
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
        'integertextboxKilogramoBruto
        '
        Me.integertextboxKilogramoBruto.BackGroundColor = System.Drawing.SystemColors.Window
        Me.integertextboxKilogramoBruto.BeforeTouchSize = New System.Drawing.Size(38, 20)
        Me.integertextboxKilogramoBruto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.integertextboxKilogramoBruto.IntegerValue = CType(0, Long)
        Me.integertextboxKilogramoBruto.Location = New System.Drawing.Point(92, 13)
        Me.integertextboxKilogramoBruto.MaxValue = CType(99999, Long)
        Me.integertextboxKilogramoBruto.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.integertextboxKilogramoBruto.MinValue = CType(0, Long)
        Me.integertextboxKilogramoBruto.Name = "integertextboxKilogramoBruto"
        Me.integertextboxKilogramoBruto.NullString = ""
        Me.integertextboxKilogramoBruto.NumberNegativePattern = 0
        Me.integertextboxKilogramoBruto.Size = New System.Drawing.Size(53, 20)
        Me.integertextboxKilogramoBruto.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.integertextboxKilogramoBruto.TabIndex = 1
        Me.integertextboxKilogramoBruto.Text = "0"
        Me.integertextboxKilogramoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.integertextboxKilogramoBruto.WordWrap = False
        '
        'groupboxNotas
        '
        Me.groupboxNotas.Controls.Add(Me.textboxNotas)
        Me.groupboxNotas.Controls.Add(Me.labelNotas)
        Me.groupboxNotas.Location = New System.Drawing.Point(12, 385)
        Me.groupboxNotas.Name = "groupboxNotas"
        Me.groupboxNotas.Size = New System.Drawing.Size(722, 75)
        Me.groupboxNotas.TabIndex = 6
        Me.groupboxNotas.TabStop = False
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(92, 17)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(624, 48)
        Me.textboxNotas.TabIndex = 1
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(6, 20)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 0
        Me.labelNotas.Text = "Notas:"
        '
        'groupboxAnalisis
        '
        Me.groupboxAnalisis.Controls.Add(Me.labelMezclado)
        Me.groupboxAnalisis.Controls.Add(Me.checkboxMezclado)
        Me.groupboxAnalisis.Controls.Add(Me.labelFumigado)
        Me.groupboxAnalisis.Controls.Add(Me.checkboxFumigado)
        Me.groupboxAnalisis.Controls.Add(Me.doubletextboxGluten)
        Me.groupboxAnalisis.Controls.Add(Me.labelGluten)
        Me.groupboxAnalisis.Controls.Add(Me.doubletextboxPesoHectolitrico)
        Me.groupboxAnalisis.Controls.Add(Me.labelPesoHectolitrico)
        Me.groupboxAnalisis.Controls.Add(Me.doubletextboxGranoDaniado)
        Me.groupboxAnalisis.Controls.Add(Me.labelGranoDaniado)
        Me.groupboxAnalisis.Controls.Add(Me.doubletextboxGranoVerde)
        Me.groupboxAnalisis.Controls.Add(Me.labelGranoVerde)
        Me.groupboxAnalisis.Controls.Add(Me.doubletextboxZaranda)
        Me.groupboxAnalisis.Controls.Add(Me.labelZaranda)
        Me.groupboxAnalisis.Controls.Add(Me.doubletextboxHumedad)
        Me.groupboxAnalisis.Controls.Add(Me.labelHumedad)
        Me.groupboxAnalisis.Location = New System.Drawing.Point(381, 296)
        Me.groupboxAnalisis.Name = "groupboxAnalisis"
        Me.groupboxAnalisis.Size = New System.Drawing.Size(353, 88)
        Me.groupboxAnalisis.TabIndex = 5
        Me.groupboxAnalisis.TabStop = False
        '
        'labelMezclado
        '
        Me.labelMezclado.AutoSize = True
        Me.labelMezclado.Location = New System.Drawing.Point(112, 65)
        Me.labelMezclado.Name = "labelMezclado"
        Me.labelMezclado.Size = New System.Drawing.Size(56, 13)
        Me.labelMezclado.TabIndex = 11
        Me.labelMezclado.Text = "Mezclado:"
        '
        'checkboxMezclado
        '
        Me.checkboxMezclado.AutoSize = True
        Me.checkboxMezclado.Location = New System.Drawing.Point(206, 66)
        Me.checkboxMezclado.Name = "checkboxMezclado"
        Me.checkboxMezclado.Size = New System.Drawing.Size(15, 14)
        Me.checkboxMezclado.TabIndex = 12
        Me.checkboxMezclado.UseVisualStyleBackColor = True
        '
        'labelFumigado
        '
        Me.labelFumigado.AutoSize = True
        Me.labelFumigado.Location = New System.Drawing.Point(6, 65)
        Me.labelFumigado.Name = "labelFumigado"
        Me.labelFumigado.Size = New System.Drawing.Size(56, 13)
        Me.labelFumigado.TabIndex = 4
        Me.labelFumigado.Text = "Fumigado:"
        '
        'checkboxFumigado
        '
        Me.checkboxFumigado.AutoSize = True
        Me.checkboxFumigado.Location = New System.Drawing.Point(68, 66)
        Me.checkboxFumigado.Name = "checkboxFumigado"
        Me.checkboxFumigado.Size = New System.Drawing.Size(15, 14)
        Me.checkboxFumigado.TabIndex = 5
        Me.checkboxFumigado.UseVisualStyleBackColor = True
        '
        'doubletextboxGluten
        '
        Me.doubletextboxGluten.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxGluten.BeforeTouchSize = New System.Drawing.Size(38, 20)
        Me.doubletextboxGluten.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxGluten.DoubleValue = 0.0R
        Me.doubletextboxGluten.Location = New System.Drawing.Point(309, 38)
        Me.doubletextboxGluten.MaxValue = 40.0R
        Me.doubletextboxGluten.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxGluten.MinValue = 0.0R
        Me.doubletextboxGluten.Name = "doubletextboxGluten"
        Me.doubletextboxGluten.NullString = ""
        Me.doubletextboxGluten.NumberDecimalDigits = 1
        Me.doubletextboxGluten.NumberNegativePattern = 0
        Me.doubletextboxGluten.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxGluten.Size = New System.Drawing.Size(38, 20)
        Me.doubletextboxGluten.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxGluten.TabIndex = 0
        Me.doubletextboxGluten.Text = "0,0"
        Me.doubletextboxGluten.WordWrap = False
        '
        'labelGluten
        '
        Me.labelGluten.AutoSize = True
        Me.labelGluten.Location = New System.Drawing.Point(247, 41)
        Me.labelGluten.Name = "labelGluten"
        Me.labelGluten.Size = New System.Drawing.Size(41, 13)
        Me.labelGluten.TabIndex = 15
        Me.labelGluten.Text = "Gluten:"
        '
        'doubletextboxPesoHectolitrico
        '
        Me.doubletextboxPesoHectolitrico.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxPesoHectolitrico.BeforeTouchSize = New System.Drawing.Size(38, 20)
        Me.doubletextboxPesoHectolitrico.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxPesoHectolitrico.DoubleValue = 0.0R
        Me.doubletextboxPesoHectolitrico.Location = New System.Drawing.Point(309, 12)
        Me.doubletextboxPesoHectolitrico.MaxValue = 40.0R
        Me.doubletextboxPesoHectolitrico.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxPesoHectolitrico.MinValue = 0.0R
        Me.doubletextboxPesoHectolitrico.Name = "doubletextboxPesoHectolitrico"
        Me.doubletextboxPesoHectolitrico.NullString = ""
        Me.doubletextboxPesoHectolitrico.NumberDecimalDigits = 1
        Me.doubletextboxPesoHectolitrico.NumberNegativePattern = 0
        Me.doubletextboxPesoHectolitrico.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxPesoHectolitrico.Size = New System.Drawing.Size(38, 20)
        Me.doubletextboxPesoHectolitrico.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxPesoHectolitrico.TabIndex = 14
        Me.doubletextboxPesoHectolitrico.Text = "0,0"
        Me.doubletextboxPesoHectolitrico.WordWrap = False
        '
        'labelPesoHectolitrico
        '
        Me.labelPesoHectolitrico.AutoSize = True
        Me.labelPesoHectolitrico.Location = New System.Drawing.Point(247, 15)
        Me.labelPesoHectolitrico.Name = "labelPesoHectolitrico"
        Me.labelPesoHectolitrico.Size = New System.Drawing.Size(63, 13)
        Me.labelPesoHectolitrico.TabIndex = 13
        Me.labelPesoHectolitrico.Text = "Peso Hect.:"
        '
        'doubletextboxGranoDaniado
        '
        Me.doubletextboxGranoDaniado.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxGranoDaniado.BeforeTouchSize = New System.Drawing.Size(38, 20)
        Me.doubletextboxGranoDaniado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxGranoDaniado.DoubleValue = 0.0R
        Me.doubletextboxGranoDaniado.Location = New System.Drawing.Point(206, 38)
        Me.doubletextboxGranoDaniado.MaxValue = 40.0R
        Me.doubletextboxGranoDaniado.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxGranoDaniado.MinValue = 0.0R
        Me.doubletextboxGranoDaniado.Name = "doubletextboxGranoDaniado"
        Me.doubletextboxGranoDaniado.NullString = ""
        Me.doubletextboxGranoDaniado.NumberDecimalDigits = 1
        Me.doubletextboxGranoDaniado.NumberNegativePattern = 0
        Me.doubletextboxGranoDaniado.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxGranoDaniado.Size = New System.Drawing.Size(38, 20)
        Me.doubletextboxGranoDaniado.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxGranoDaniado.TabIndex = 10
        Me.doubletextboxGranoDaniado.Text = "0,0"
        Me.doubletextboxGranoDaniado.WordWrap = False
        '
        'labelGranoDaniado
        '
        Me.labelGranoDaniado.AutoSize = True
        Me.labelGranoDaniado.Location = New System.Drawing.Point(112, 41)
        Me.labelGranoDaniado.Name = "labelGranoDaniado"
        Me.labelGranoDaniado.Size = New System.Drawing.Size(88, 13)
        Me.labelGranoDaniado.TabIndex = 9
        Me.labelGranoDaniado.Text = "Granos dañados:"
        '
        'doubletextboxGranoVerde
        '
        Me.doubletextboxGranoVerde.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxGranoVerde.BeforeTouchSize = New System.Drawing.Size(38, 20)
        Me.doubletextboxGranoVerde.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxGranoVerde.DoubleValue = 0.0R
        Me.doubletextboxGranoVerde.Location = New System.Drawing.Point(206, 12)
        Me.doubletextboxGranoVerde.MaxValue = 40.0R
        Me.doubletextboxGranoVerde.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxGranoVerde.MinValue = 0.0R
        Me.doubletextboxGranoVerde.Name = "doubletextboxGranoVerde"
        Me.doubletextboxGranoVerde.NullString = ""
        Me.doubletextboxGranoVerde.NumberDecimalDigits = 1
        Me.doubletextboxGranoVerde.NumberNegativePattern = 0
        Me.doubletextboxGranoVerde.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxGranoVerde.Size = New System.Drawing.Size(38, 20)
        Me.doubletextboxGranoVerde.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxGranoVerde.TabIndex = 8
        Me.doubletextboxGranoVerde.Text = "0,0"
        Me.doubletextboxGranoVerde.WordWrap = False
        '
        'labelGranoVerde
        '
        Me.labelGranoVerde.AutoSize = True
        Me.labelGranoVerde.Location = New System.Drawing.Point(112, 15)
        Me.labelGranoVerde.Name = "labelGranoVerde"
        Me.labelGranoVerde.Size = New System.Drawing.Size(79, 13)
        Me.labelGranoVerde.TabIndex = 7
        Me.labelGranoVerde.Text = "Granos verdes:"
        '
        'doubletextboxZaranda
        '
        Me.doubletextboxZaranda.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxZaranda.BeforeTouchSize = New System.Drawing.Size(38, 20)
        Me.doubletextboxZaranda.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxZaranda.DoubleValue = 0.0R
        Me.doubletextboxZaranda.Location = New System.Drawing.Point(68, 38)
        Me.doubletextboxZaranda.MaxValue = 50.0R
        Me.doubletextboxZaranda.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxZaranda.MinValue = 0.0R
        Me.doubletextboxZaranda.Name = "doubletextboxZaranda"
        Me.doubletextboxZaranda.NullString = ""
        Me.doubletextboxZaranda.NumberDecimalDigits = 1
        Me.doubletextboxZaranda.NumberNegativePattern = 0
        Me.doubletextboxZaranda.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxZaranda.Size = New System.Drawing.Size(38, 20)
        Me.doubletextboxZaranda.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxZaranda.TabIndex = 3
        Me.doubletextboxZaranda.Text = "0,0"
        Me.doubletextboxZaranda.WordWrap = False
        '
        'labelZaranda
        '
        Me.labelZaranda.AutoSize = True
        Me.labelZaranda.Location = New System.Drawing.Point(6, 41)
        Me.labelZaranda.Name = "labelZaranda"
        Me.labelZaranda.Size = New System.Drawing.Size(50, 13)
        Me.labelZaranda.TabIndex = 2
        Me.labelZaranda.Text = "Zaranda:"
        '
        'doubletextboxHumedad
        '
        Me.doubletextboxHumedad.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxHumedad.BeforeTouchSize = New System.Drawing.Size(38, 20)
        Me.doubletextboxHumedad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxHumedad.DoubleValue = 0.0R
        Me.doubletextboxHumedad.Location = New System.Drawing.Point(68, 12)
        Me.doubletextboxHumedad.MaxValue = 40.0R
        Me.doubletextboxHumedad.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxHumedad.MinValue = 0.0R
        Me.doubletextboxHumedad.Name = "doubletextboxHumedad"
        Me.doubletextboxHumedad.NullString = ""
        Me.doubletextboxHumedad.NumberDecimalDigits = 1
        Me.doubletextboxHumedad.NumberNegativePattern = 0
        Me.doubletextboxHumedad.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxHumedad.Size = New System.Drawing.Size(38, 20)
        Me.doubletextboxHumedad.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxHumedad.TabIndex = 1
        Me.doubletextboxHumedad.Text = "0,0"
        Me.doubletextboxHumedad.WordWrap = False
        '
        'labelHumedad
        '
        Me.labelHumedad.AutoSize = True
        Me.labelHumedad.Location = New System.Drawing.Point(6, 15)
        Me.labelHumedad.Name = "labelHumedad"
        Me.labelHumedad.Size = New System.Drawing.Size(56, 13)
        Me.labelHumedad.TabIndex = 0
        Me.labelHumedad.Text = "Humedad:"
        '
        'formPesada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 469)
        Me.Controls.Add(Me.groupboxAnalisis)
        Me.Controls.Add(Me.groupboxNotas)
        Me.Controls.Add(Me.groupboxKilogramo)
        Me.Controls.Add(Me.groupboxEncabezado)
        Me.Controls.Add(Me.groupboxProductoPlantaCosecha)
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
        Me.groupboxProductoPlantaCosecha.ResumeLayout(False)
        Me.groupboxProductoPlantaCosecha.PerformLayout()
        Me.groupboxTipo.ResumeLayout(False)
        Me.groupboxTipo.PerformLayout()
        Me.groupboxEncabezado.ResumeLayout(False)
        Me.groupboxEncabezado.PerformLayout()
        Me.groupboxKilogramo.ResumeLayout(False)
        Me.groupboxKilogramo.PerformLayout()
        CType(Me.integertextboxKilogramoNeto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.integertextboxKilogramoTara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.integertextboxKilogramoBruto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupboxNotas.ResumeLayout(False)
        Me.groupboxNotas.PerformLayout()
        Me.groupboxAnalisis.ResumeLayout(False)
        Me.groupboxAnalisis.PerformLayout()
        CType(Me.doubletextboxGluten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxPesoHectolitrico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxGranoDaniado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxGranoVerde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxZaranda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxHumedad, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents groupboxProductoPlantaCosecha As System.Windows.Forms.GroupBox
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
    Friend WithEvents integertextboxKilogramoBruto As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents labelKilogramoNeto As System.Windows.Forms.Label
    Friend WithEvents integertextboxKilogramoNeto As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents labelKilogramoTara As System.Windows.Forms.Label
    Friend WithEvents integertextboxKilogramoTara As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents checkboxProductoTodos As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxTipoTodos As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxTitularTodos As System.Windows.Forms.CheckBox
    Friend WithEvents textboxProducto As System.Windows.Forms.TextBox
    Friend WithEvents labelTransportistaCUIT As System.Windows.Forms.Label
    Friend WithEvents textboxTransportista As System.Windows.Forms.TextBox
    Friend WithEvents textboxOrigenDestino As System.Windows.Forms.TextBox
    Friend WithEvents textboxTitular As System.Windows.Forms.TextBox
    Friend WithEvents maskedtextboxTransportistaCUIT As System.Windows.Forms.MaskedTextBox
    Friend WithEvents maskedtextboxChoferCUIT_CUIL As System.Windows.Forms.MaskedTextBox
    Friend WithEvents labelChoferCUIT_CUIL As System.Windows.Forms.Label
    Friend WithEvents textboxChofer As System.Windows.Forms.TextBox
    Friend WithEvents textboxCamion_DominioAcoplado As System.Windows.Forms.TextBox
    Friend WithEvents textboxCamion_DominioChasis As System.Windows.Forms.TextBox
    Friend WithEvents labelCamion_DominioAcoplado As System.Windows.Forms.Label
    Friend WithEvents maskedtextboxComprobanteNumero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents labelComprobanteNumero As System.Windows.Forms.Label
    Friend WithEvents groupboxNotas As System.Windows.Forms.GroupBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents checkboxChoferTodos As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxTransportistaTodos As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxCamionTodos As System.Windows.Forms.CheckBox
    Friend WithEvents groupboxAnalisis As System.Windows.Forms.GroupBox
    Friend WithEvents labelHumedad As System.Windows.Forms.Label
    Friend WithEvents doubletextboxHumedad As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents doubletextboxZaranda As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelZaranda As System.Windows.Forms.Label
    Friend WithEvents doubletextboxGluten As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelGluten As System.Windows.Forms.Label
    Friend WithEvents doubletextboxPesoHectolitrico As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelPesoHectolitrico As System.Windows.Forms.Label
    Friend WithEvents doubletextboxGranoDaniado As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelGranoDaniado As System.Windows.Forms.Label
    Friend WithEvents doubletextboxGranoVerde As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelGranoVerde As System.Windows.Forms.Label
    Friend WithEvents labelFumigado As System.Windows.Forms.Label
    Friend WithEvents checkboxFumigado As System.Windows.Forms.CheckBox
    Friend WithEvents labelMezclado As System.Windows.Forms.Label
    Friend WithEvents checkboxMezclado As System.Windows.Forms.CheckBox
End Class
