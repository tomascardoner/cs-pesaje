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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formPesada))
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tooltipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.labelOrigenDestino = New System.Windows.Forms.Label()
        Me.labelTitular = New System.Windows.Forms.Label()
        Me.checkboxProductoTodos = New System.Windows.Forms.CheckBox()
        Me.labelChoferCUIT_CUIL = New System.Windows.Forms.Label()
        Me.checkboxProductoOtro = New System.Windows.Forms.CheckBox()
        Me.checkboxOrigenDestinoOtro = New System.Windows.Forms.CheckBox()
        Me.checkboxOrigenDestinoTodos = New System.Windows.Forms.CheckBox()
        Me.checkboxTitularOtro = New System.Windows.Forms.CheckBox()
        Me.checkboxTitularTodos = New System.Windows.Forms.CheckBox()
        Me.checkboxTransportistaOtro = New System.Windows.Forms.CheckBox()
        Me.checkboxTransportistaTodos = New System.Windows.Forms.CheckBox()
        Me.checkboxChoferOtro = New System.Windows.Forms.CheckBox()
        Me.checkboxChoferTodos = New System.Windows.Forms.CheckBox()
        Me.checkboxCamionOtro = New System.Windows.Forms.CheckBox()
        Me.checkboxTipoTodos = New System.Windows.Forms.CheckBox()
        Me.checkboxCosechaTodos = New System.Windows.Forms.CheckBox()
        Me.groupboxTransporte = New System.Windows.Forms.GroupBox()
        Me.labelKilometro = New System.Windows.Forms.Label()
        Me.integertextboxKilometro = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
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
        Me.textboxTitular = New System.Windows.Forms.TextBox()
        Me.comboboxTitular = New System.Windows.Forms.ComboBox()
        Me.textboxOrigenDestino = New System.Windows.Forms.TextBox()
        Me.comboboxOrigenDestino = New System.Windows.Forms.ComboBox()
        Me.groupboxProductoPlantaCosecha = New System.Windows.Forms.GroupBox()
        Me.labelTipo = New System.Windows.Forms.Label()
        Me.comboboxCosecha = New System.Windows.Forms.ComboBox()
        Me.labelCosecha = New System.Windows.Forms.Label()
        Me.groupboxTipo = New System.Windows.Forms.GroupBox()
        Me.radiobuttonNinguno = New System.Windows.Forms.RadioButton()
        Me.radiobuttonSalida = New System.Windows.Forms.RadioButton()
        Me.radiobuttonEntrada = New System.Windows.Forms.RadioButton()
        Me.comboboxPlanta = New System.Windows.Forms.ComboBox()
        Me.labelPlanta = New System.Windows.Forms.Label()
        Me.labelProducto = New System.Windows.Forms.Label()
        Me.textboxProducto = New System.Windows.Forms.TextBox()
        Me.comboboxProducto = New System.Windows.Forms.ComboBox()
        Me.groupboxEncabezado = New System.Windows.Forms.GroupBox()
        Me.labelComprobanteNumeroTercero = New System.Windows.Forms.Label()
        Me.maskedtextboxComprobanteNumeroTercero = New System.Windows.Forms.MaskedTextBox()
        Me.buttonFechaHoraFinAhora = New System.Windows.Forms.Button()
        Me.buttonFechaHoraInicioAhora = New System.Windows.Forms.Button()
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
        Me.buttonObtenerKilogramosTara = New System.Windows.Forms.Button()
        Me.buttonObtenerKilogramosBrutos = New System.Windows.Forms.Button()
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
        Me.integertextboxGranoDaniado = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.integertextboxGranoVerde = New Syncfusion.Windows.Forms.Tools.IntegerTextBox()
        Me.labelMezclado = New System.Windows.Forms.Label()
        Me.checkboxMezclado = New System.Windows.Forms.CheckBox()
        Me.labelFumigado = New System.Windows.Forms.Label()
        Me.checkboxFumigado = New System.Windows.Forms.CheckBox()
        Me.doubletextboxGluten = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelGluten = New System.Windows.Forms.Label()
        Me.doubletextboxPesoHectolitrico = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelPesoHectolitrico = New System.Windows.Forms.Label()
        Me.labelGranoDaniado = New System.Windows.Forms.Label()
        Me.labelGranoVerde = New System.Windows.Forms.Label()
        Me.doubletextboxZaranda = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelZaranda = New System.Windows.Forms.Label()
        Me.doubletextboxHumedad = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.labelHumedad = New System.Windows.Forms.Label()
        Me.buttonEsActivo = New System.Windows.Forms.ToolStripButton()
        Me.buttonEsSincronizado = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain.SuspendLayout()
        Me.groupboxTransporte.SuspendLayout()
        CType(Me.integertextboxKilometro, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.integertextboxGranoDaniado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.integertextboxGranoVerde, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxGluten, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxPesoHectolitrico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxZaranda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxHumedad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar, Me.buttonEsActivo, Me.buttonEsSincronizado})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(743, 39)
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
        Me.labelOrigenDestino.TabIndex = 5
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
        Me.checkboxProductoTodos.Location = New System.Drawing.Point(326, 12)
        Me.checkboxProductoTodos.Name = "checkboxProductoTodos"
        Me.checkboxProductoTodos.Size = New System.Drawing.Size(23, 23)
        Me.checkboxProductoTodos.TabIndex = 4
        Me.checkboxProductoTodos.TabStop = False
        Me.checkboxProductoTodos.Text = "T"
        Me.checkboxProductoTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxProductoTodos, "Ver todos")
        Me.checkboxProductoTodos.UseVisualStyleBackColor = True
        '
        'labelChoferCUIT_CUIL
        '
        Me.labelChoferCUIT_CUIL.AutoSize = True
        Me.labelChoferCUIT_CUIL.Location = New System.Drawing.Point(6, 96)
        Me.labelChoferCUIT_CUIL.Name = "labelChoferCUIT_CUIL"
        Me.labelChoferCUIT_CUIL.Size = New System.Drawing.Size(70, 13)
        Me.labelChoferCUIT_CUIL.TabIndex = 12
        Me.labelChoferCUIT_CUIL.Text = "CUIT / CUIL:"
        Me.tooltipMain.SetToolTip(Me.labelChoferCUIT_CUIL, "Ingrese el Número de Documento sin utilizar puntos.")
        '
        'checkboxProductoOtro
        '
        Me.checkboxProductoOtro.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxProductoOtro.Location = New System.Drawing.Point(92, 12)
        Me.checkboxProductoOtro.Name = "checkboxProductoOtro"
        Me.checkboxProductoOtro.Size = New System.Drawing.Size(23, 23)
        Me.checkboxProductoOtro.TabIndex = 1
        Me.checkboxProductoOtro.Text = "O"
        Me.checkboxProductoOtro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxProductoOtro, "Otro")
        Me.checkboxProductoOtro.UseVisualStyleBackColor = True
        '
        'checkboxOrigenDestinoOtro
        '
        Me.checkboxOrigenDestinoOtro.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxOrigenDestinoOtro.Location = New System.Drawing.Point(92, 39)
        Me.checkboxOrigenDestinoOtro.Name = "checkboxOrigenDestinoOtro"
        Me.checkboxOrigenDestinoOtro.Size = New System.Drawing.Size(23, 23)
        Me.checkboxOrigenDestinoOtro.TabIndex = 6
        Me.checkboxOrigenDestinoOtro.Text = "O"
        Me.checkboxOrigenDestinoOtro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxOrigenDestinoOtro, "Otro")
        Me.checkboxOrigenDestinoOtro.UseVisualStyleBackColor = True
        '
        'checkboxOrigenDestinoTodos
        '
        Me.checkboxOrigenDestinoTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxOrigenDestinoTodos.Location = New System.Drawing.Point(326, 39)
        Me.checkboxOrigenDestinoTodos.Name = "checkboxOrigenDestinoTodos"
        Me.checkboxOrigenDestinoTodos.Size = New System.Drawing.Size(23, 23)
        Me.checkboxOrigenDestinoTodos.TabIndex = 9
        Me.checkboxOrigenDestinoTodos.TabStop = False
        Me.checkboxOrigenDestinoTodos.Text = "T"
        Me.checkboxOrigenDestinoTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxOrigenDestinoTodos, "Ver todos")
        Me.checkboxOrigenDestinoTodos.UseVisualStyleBackColor = True
        '
        'checkboxTitularOtro
        '
        Me.checkboxTitularOtro.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxTitularOtro.Location = New System.Drawing.Point(92, 12)
        Me.checkboxTitularOtro.Name = "checkboxTitularOtro"
        Me.checkboxTitularOtro.Size = New System.Drawing.Size(23, 23)
        Me.checkboxTitularOtro.TabIndex = 1
        Me.checkboxTitularOtro.Text = "O"
        Me.checkboxTitularOtro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxTitularOtro, "Otro")
        Me.checkboxTitularOtro.UseVisualStyleBackColor = True
        '
        'checkboxTitularTodos
        '
        Me.checkboxTitularTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxTitularTodos.Location = New System.Drawing.Point(326, 12)
        Me.checkboxTitularTodos.Name = "checkboxTitularTodos"
        Me.checkboxTitularTodos.Size = New System.Drawing.Size(23, 23)
        Me.checkboxTitularTodos.TabIndex = 4
        Me.checkboxTitularTodos.TabStop = False
        Me.checkboxTitularTodos.Text = "T"
        Me.checkboxTitularTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxTitularTodos, "Ver todos")
        Me.checkboxTitularTodos.UseVisualStyleBackColor = True
        '
        'checkboxTransportistaOtro
        '
        Me.checkboxTransportistaOtro.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxTransportistaOtro.Location = New System.Drawing.Point(92, 12)
        Me.checkboxTransportistaOtro.Name = "checkboxTransportistaOtro"
        Me.checkboxTransportistaOtro.Size = New System.Drawing.Size(23, 23)
        Me.checkboxTransportistaOtro.TabIndex = 1
        Me.checkboxTransportistaOtro.Text = "O"
        Me.checkboxTransportistaOtro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxTransportistaOtro, "Otro")
        Me.checkboxTransportistaOtro.UseVisualStyleBackColor = True
        '
        'checkboxTransportistaTodos
        '
        Me.checkboxTransportistaTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxTransportistaTodos.Location = New System.Drawing.Point(326, 12)
        Me.checkboxTransportistaTodos.Name = "checkboxTransportistaTodos"
        Me.checkboxTransportistaTodos.Size = New System.Drawing.Size(23, 23)
        Me.checkboxTransportistaTodos.TabIndex = 4
        Me.checkboxTransportistaTodos.TabStop = False
        Me.checkboxTransportistaTodos.Text = "T"
        Me.checkboxTransportistaTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxTransportistaTodos, "Ver todos")
        Me.checkboxTransportistaTodos.UseVisualStyleBackColor = True
        '
        'checkboxChoferOtro
        '
        Me.checkboxChoferOtro.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxChoferOtro.Location = New System.Drawing.Point(92, 65)
        Me.checkboxChoferOtro.Name = "checkboxChoferOtro"
        Me.checkboxChoferOtro.Size = New System.Drawing.Size(23, 23)
        Me.checkboxChoferOtro.TabIndex = 8
        Me.checkboxChoferOtro.Text = "O"
        Me.checkboxChoferOtro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxChoferOtro, "Otro")
        Me.checkboxChoferOtro.UseVisualStyleBackColor = True
        '
        'checkboxChoferTodos
        '
        Me.checkboxChoferTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxChoferTodos.Location = New System.Drawing.Point(326, 65)
        Me.checkboxChoferTodos.Name = "checkboxChoferTodos"
        Me.checkboxChoferTodos.Size = New System.Drawing.Size(23, 23)
        Me.checkboxChoferTodos.TabIndex = 11
        Me.checkboxChoferTodos.TabStop = False
        Me.checkboxChoferTodos.Text = "T"
        Me.checkboxChoferTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxChoferTodos, "Ver todos")
        Me.checkboxChoferTodos.UseVisualStyleBackColor = True
        '
        'checkboxCamionOtro
        '
        Me.checkboxCamionOtro.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxCamionOtro.Location = New System.Drawing.Point(92, 118)
        Me.checkboxCamionOtro.Name = "checkboxCamionOtro"
        Me.checkboxCamionOtro.Size = New System.Drawing.Size(23, 23)
        Me.checkboxCamionOtro.TabIndex = 15
        Me.checkboxCamionOtro.Text = "O"
        Me.checkboxCamionOtro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxCamionOtro, "Otro")
        Me.checkboxCamionOtro.UseVisualStyleBackColor = True
        '
        'checkboxTipoTodos
        '
        Me.checkboxTipoTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxTipoTodos.Location = New System.Drawing.Point(326, 69)
        Me.checkboxTipoTodos.Name = "checkboxTipoTodos"
        Me.checkboxTipoTodos.Size = New System.Drawing.Size(23, 23)
        Me.checkboxTipoTodos.TabIndex = 9
        Me.checkboxTipoTodos.TabStop = False
        Me.checkboxTipoTodos.Text = "T"
        Me.checkboxTipoTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxTipoTodos, "Ver todos")
        Me.checkboxTipoTodos.UseVisualStyleBackColor = True
        '
        'checkboxCosechaTodos
        '
        Me.checkboxCosechaTodos.Appearance = System.Windows.Forms.Appearance.Button
        Me.checkboxCosechaTodos.Location = New System.Drawing.Point(214, 100)
        Me.checkboxCosechaTodos.Name = "checkboxCosechaTodos"
        Me.checkboxCosechaTodos.Size = New System.Drawing.Size(23, 23)
        Me.checkboxCosechaTodos.TabIndex = 12
        Me.checkboxCosechaTodos.TabStop = False
        Me.checkboxCosechaTodos.Text = "T"
        Me.checkboxCosechaTodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.tooltipMain.SetToolTip(Me.checkboxCosechaTodos, "Ver todos")
        Me.checkboxCosechaTodos.UseVisualStyleBackColor = True
        '
        'groupboxTransporte
        '
        Me.groupboxTransporte.Controls.Add(Me.labelKilometro)
        Me.groupboxTransporte.Controls.Add(Me.integertextboxKilometro)
        Me.groupboxTransporte.Controls.Add(Me.checkboxCamionOtro)
        Me.groupboxTransporte.Controls.Add(Me.checkboxChoferOtro)
        Me.groupboxTransporte.Controls.Add(Me.checkboxChoferTodos)
        Me.groupboxTransporte.Controls.Add(Me.checkboxTransportistaOtro)
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
        Me.groupboxTransporte.Size = New System.Drawing.Size(353, 175)
        Me.groupboxTransporte.TabIndex = 3
        Me.groupboxTransporte.TabStop = False
        '
        'labelKilometro
        '
        Me.labelKilometro.AutoSize = True
        Me.labelKilometro.Location = New System.Drawing.Point(6, 148)
        Me.labelKilometro.Name = "labelKilometro"
        Me.labelKilometro.Size = New System.Drawing.Size(58, 13)
        Me.labelKilometro.TabIndex = 19
        Me.labelKilometro.Text = "Kilómetros:"
        '
        'integertextboxKilometro
        '
        Me.integertextboxKilometro.AllowNull = True
        Me.integertextboxKilometro.BackGroundColor = System.Drawing.SystemColors.Window
        Me.integertextboxKilometro.BeforeTouchSize = New System.Drawing.Size(38, 20)
        Me.integertextboxKilometro.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.integertextboxKilometro.IntegerValue = CType(0, Long)
        Me.integertextboxKilometro.Location = New System.Drawing.Point(92, 145)
        Me.integertextboxKilometro.MaxValue = CType(3000, Long)
        Me.integertextboxKilometro.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.integertextboxKilometro.MinValue = CType(0, Long)
        Me.integertextboxKilometro.Name = "integertextboxKilometro"
        Me.integertextboxKilometro.NullString = ""
        Me.integertextboxKilometro.NumberNegativePattern = 0
        Me.integertextboxKilometro.Size = New System.Drawing.Size(53, 20)
        Me.integertextboxKilometro.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.integertextboxKilometro.TabIndex = 20
        Me.integertextboxKilometro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.integertextboxKilometro.WordWrap = False
        '
        'labelCamion_DominioAcoplado
        '
        Me.labelCamion_DominioAcoplado.AutoSize = True
        Me.labelCamion_DominioAcoplado.Location = New System.Drawing.Point(193, 123)
        Me.labelCamion_DominioAcoplado.Name = "labelCamion_DominioAcoplado"
        Me.labelCamion_DominioAcoplado.Size = New System.Drawing.Size(55, 13)
        Me.labelCamion_DominioAcoplado.TabIndex = 17
        Me.labelCamion_DominioAcoplado.Text = "Acoplado:"
        '
        'textboxCamion_DominioAcoplado
        '
        Me.textboxCamion_DominioAcoplado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textboxCamion_DominioAcoplado.Location = New System.Drawing.Point(254, 119)
        Me.textboxCamion_DominioAcoplado.MaxLength = 7
        Me.textboxCamion_DominioAcoplado.Name = "textboxCamion_DominioAcoplado"
        Me.textboxCamion_DominioAcoplado.Size = New System.Drawing.Size(68, 20)
        Me.textboxCamion_DominioAcoplado.TabIndex = 18
        '
        'textboxCamion_DominioChasis
        '
        Me.textboxCamion_DominioChasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textboxCamion_DominioChasis.Location = New System.Drawing.Point(116, 119)
        Me.textboxCamion_DominioChasis.MaxLength = 7
        Me.textboxCamion_DominioChasis.Name = "textboxCamion_DominioChasis"
        Me.textboxCamion_DominioChasis.Size = New System.Drawing.Size(68, 20)
        Me.textboxCamion_DominioChasis.TabIndex = 16
        '
        'textboxChofer
        '
        Me.textboxChofer.Location = New System.Drawing.Point(116, 66)
        Me.textboxChofer.MaxLength = 50
        Me.textboxChofer.Name = "textboxChofer"
        Me.textboxChofer.Size = New System.Drawing.Size(158, 20)
        Me.textboxChofer.TabIndex = 9
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
        Me.maskedtextboxChoferCUIT_CUIL.TabIndex = 13
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
        Me.maskedtextboxTransportistaCUIT.TabIndex = 6
        Me.maskedtextboxTransportistaCUIT.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'labelTransportistaCUIT
        '
        Me.labelTransportistaCUIT.AutoSize = True
        Me.labelTransportistaCUIT.Location = New System.Drawing.Point(6, 43)
        Me.labelTransportistaCUIT.Name = "labelTransportistaCUIT"
        Me.labelTransportistaCUIT.Size = New System.Drawing.Size(35, 13)
        Me.labelTransportistaCUIT.TabIndex = 5
        Me.labelTransportistaCUIT.Text = "CUIT:"
        '
        'textboxTransportista
        '
        Me.textboxTransportista.Location = New System.Drawing.Point(116, 13)
        Me.textboxTransportista.MaxLength = 50
        Me.textboxTransportista.Name = "textboxTransportista"
        Me.textboxTransportista.Size = New System.Drawing.Size(158, 20)
        Me.textboxTransportista.TabIndex = 2
        '
        'labelChofer
        '
        Me.labelChofer.AutoSize = True
        Me.labelChofer.Location = New System.Drawing.Point(6, 69)
        Me.labelChofer.Name = "labelChofer"
        Me.labelChofer.Size = New System.Drawing.Size(41, 13)
        Me.labelChofer.TabIndex = 7
        Me.labelChofer.Text = "Chofer:"
        '
        'comboboxChofer
        '
        Me.comboboxChofer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxChofer.FormattingEnabled = True
        Me.comboboxChofer.Location = New System.Drawing.Point(116, 66)
        Me.comboboxChofer.Name = "comboboxChofer"
        Me.comboboxChofer.Size = New System.Drawing.Size(209, 21)
        Me.comboboxChofer.TabIndex = 10
        '
        'comboboxTransportista
        '
        Me.comboboxTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxTransportista.FormattingEnabled = True
        Me.comboboxTransportista.Location = New System.Drawing.Point(116, 13)
        Me.comboboxTransportista.Name = "comboboxTransportista"
        Me.comboboxTransportista.Size = New System.Drawing.Size(209, 21)
        Me.comboboxTransportista.TabIndex = 3
        '
        'labelCamion
        '
        Me.labelCamion.AutoSize = True
        Me.labelCamion.Location = New System.Drawing.Point(6, 122)
        Me.labelCamion.Name = "labelCamion"
        Me.labelCamion.Size = New System.Drawing.Size(45, 13)
        Me.labelCamion.TabIndex = 14
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
        Me.comboboxCamion.Location = New System.Drawing.Point(116, 119)
        Me.comboboxCamion.Name = "comboboxCamion"
        Me.comboboxCamion.Size = New System.Drawing.Size(209, 21)
        Me.comboboxCamion.TabIndex = 19
        '
        'groupboxTitular
        '
        Me.groupboxTitular.Controls.Add(Me.checkboxTitularTodos)
        Me.groupboxTitular.Controls.Add(Me.checkboxTitularOtro)
        Me.groupboxTitular.Controls.Add(Me.checkboxOrigenDestinoTodos)
        Me.groupboxTitular.Controls.Add(Me.checkboxOrigenDestinoOtro)
        Me.groupboxTitular.Controls.Add(Me.textboxTitular)
        Me.groupboxTitular.Controls.Add(Me.labelOrigenDestino)
        Me.groupboxTitular.Controls.Add(Me.comboboxTitular)
        Me.groupboxTitular.Controls.Add(Me.labelTitular)
        Me.groupboxTitular.Controls.Add(Me.textboxOrigenDestino)
        Me.groupboxTitular.Controls.Add(Me.comboboxOrigenDestino)
        Me.groupboxTitular.Location = New System.Drawing.Point(12, 308)
        Me.groupboxTitular.Name = "groupboxTitular"
        Me.groupboxTitular.Size = New System.Drawing.Size(353, 71)
        Me.groupboxTitular.TabIndex = 2
        Me.groupboxTitular.TabStop = False
        '
        'textboxTitular
        '
        Me.textboxTitular.Location = New System.Drawing.Point(116, 13)
        Me.textboxTitular.MaxLength = 50
        Me.textboxTitular.Name = "textboxTitular"
        Me.textboxTitular.Size = New System.Drawing.Size(158, 20)
        Me.textboxTitular.TabIndex = 2
        '
        'comboboxTitular
        '
        Me.comboboxTitular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxTitular.FormattingEnabled = True
        Me.comboboxTitular.Location = New System.Drawing.Point(116, 13)
        Me.comboboxTitular.Name = "comboboxTitular"
        Me.comboboxTitular.Size = New System.Drawing.Size(209, 21)
        Me.comboboxTitular.TabIndex = 3
        '
        'textboxOrigenDestino
        '
        Me.textboxOrigenDestino.Location = New System.Drawing.Point(116, 40)
        Me.textboxOrigenDestino.MaxLength = 50
        Me.textboxOrigenDestino.Name = "textboxOrigenDestino"
        Me.textboxOrigenDestino.Size = New System.Drawing.Size(158, 20)
        Me.textboxOrigenDestino.TabIndex = 7
        '
        'comboboxOrigenDestino
        '
        Me.comboboxOrigenDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxOrigenDestino.FormattingEnabled = True
        Me.comboboxOrigenDestino.Location = New System.Drawing.Point(116, 40)
        Me.comboboxOrigenDestino.Name = "comboboxOrigenDestino"
        Me.comboboxOrigenDestino.Size = New System.Drawing.Size(209, 21)
        Me.comboboxOrigenDestino.TabIndex = 8
        '
        'groupboxProductoPlantaCosecha
        '
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.checkboxCosechaTodos)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.checkboxTipoTodos)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.labelTipo)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.checkboxProductoOtro)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.checkboxProductoTodos)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.comboboxCosecha)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.labelCosecha)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.groupboxTipo)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.comboboxPlanta)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.labelPlanta)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.labelProducto)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.textboxProducto)
        Me.groupboxProductoPlantaCosecha.Controls.Add(Me.comboboxProducto)
        Me.groupboxProductoPlantaCosecha.Location = New System.Drawing.Point(12, 170)
        Me.groupboxProductoPlantaCosecha.Name = "groupboxProductoPlantaCosecha"
        Me.groupboxProductoPlantaCosecha.Size = New System.Drawing.Size(353, 132)
        Me.groupboxProductoPlantaCosecha.TabIndex = 1
        Me.groupboxProductoPlantaCosecha.TabStop = False
        '
        'labelTipo
        '
        Me.labelTipo.AutoSize = True
        Me.labelTipo.Location = New System.Drawing.Point(6, 74)
        Me.labelTipo.Name = "labelTipo"
        Me.labelTipo.Size = New System.Drawing.Size(31, 13)
        Me.labelTipo.TabIndex = 7
        Me.labelTipo.Text = "Tipo:"
        '
        'comboboxCosecha
        '
        Me.comboboxCosecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCosecha.FormattingEnabled = True
        Me.comboboxCosecha.Location = New System.Drawing.Point(92, 101)
        Me.comboboxCosecha.Name = "comboboxCosecha"
        Me.comboboxCosecha.Size = New System.Drawing.Size(121, 21)
        Me.comboboxCosecha.TabIndex = 11
        '
        'labelCosecha
        '
        Me.labelCosecha.AutoSize = True
        Me.labelCosecha.Location = New System.Drawing.Point(6, 104)
        Me.labelCosecha.Name = "labelCosecha"
        Me.labelCosecha.Size = New System.Drawing.Size(52, 13)
        Me.labelCosecha.TabIndex = 10
        Me.labelCosecha.Text = "Cosecha:"
        '
        'groupboxTipo
        '
        Me.groupboxTipo.Controls.Add(Me.radiobuttonNinguno)
        Me.groupboxTipo.Controls.Add(Me.radiobuttonSalida)
        Me.groupboxTipo.Controls.Add(Me.radiobuttonEntrada)
        Me.groupboxTipo.Location = New System.Drawing.Point(92, 62)
        Me.groupboxTipo.Name = "groupboxTipo"
        Me.groupboxTipo.Size = New System.Drawing.Size(233, 33)
        Me.groupboxTipo.TabIndex = 8
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
        Me.comboboxPlanta.Size = New System.Drawing.Size(233, 21)
        Me.comboboxPlanta.TabIndex = 6
        '
        'labelPlanta
        '
        Me.labelPlanta.AutoSize = True
        Me.labelPlanta.Location = New System.Drawing.Point(6, 43)
        Me.labelPlanta.Name = "labelPlanta"
        Me.labelPlanta.Size = New System.Drawing.Size(40, 13)
        Me.labelPlanta.TabIndex = 5
        Me.labelPlanta.Text = "Planta:"
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
        'textboxProducto
        '
        Me.textboxProducto.Location = New System.Drawing.Point(116, 13)
        Me.textboxProducto.MaxLength = 50
        Me.textboxProducto.Name = "textboxProducto"
        Me.textboxProducto.Size = New System.Drawing.Size(158, 20)
        Me.textboxProducto.TabIndex = 2
        '
        'comboboxProducto
        '
        Me.comboboxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxProducto.FormattingEnabled = True
        Me.comboboxProducto.Location = New System.Drawing.Point(116, 13)
        Me.comboboxProducto.Name = "comboboxProducto"
        Me.comboboxProducto.Size = New System.Drawing.Size(209, 21)
        Me.comboboxProducto.TabIndex = 3
        '
        'groupboxEncabezado
        '
        Me.groupboxEncabezado.Controls.Add(Me.labelComprobanteNumeroTercero)
        Me.groupboxEncabezado.Controls.Add(Me.maskedtextboxComprobanteNumeroTercero)
        Me.groupboxEncabezado.Controls.Add(Me.buttonFechaHoraFinAhora)
        Me.groupboxEncabezado.Controls.Add(Me.buttonFechaHoraInicioAhora)
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
        'labelComprobanteNumeroTercero
        '
        Me.labelComprobanteNumeroTercero.AutoSize = True
        Me.labelComprobanteNumeroTercero.Location = New System.Drawing.Point(204, 96)
        Me.labelComprobanteNumeroTercero.Name = "labelComprobanteNumeroTercero"
        Me.labelComprobanteNumeroTercero.Size = New System.Drawing.Size(47, 13)
        Me.labelComprobanteNumeroTercero.TabIndex = 12
        Me.labelComprobanteNumeroTercero.Text = "Tercero:"
        '
        'maskedtextboxComprobanteNumeroTercero
        '
        Me.maskedtextboxComprobanteNumeroTercero.AllowPromptAsInput = False
        Me.maskedtextboxComprobanteNumeroTercero.AsciiOnly = True
        Me.maskedtextboxComprobanteNumeroTercero.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxComprobanteNumeroTercero.HidePromptOnLeave = True
        Me.maskedtextboxComprobanteNumeroTercero.Location = New System.Drawing.Point(257, 91)
        Me.maskedtextboxComprobanteNumeroTercero.Mask = "0000-00000000"
        Me.maskedtextboxComprobanteNumeroTercero.Name = "maskedtextboxComprobanteNumeroTercero"
        Me.maskedtextboxComprobanteNumeroTercero.Size = New System.Drawing.Size(90, 20)
        Me.maskedtextboxComprobanteNumeroTercero.TabIndex = 13
        Me.maskedtextboxComprobanteNumeroTercero.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'buttonFechaHoraFinAhora
        '
        Me.buttonFechaHoraFinAhora.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_CALENDAR_TODAY_16
        Me.buttonFechaHoraFinAhora.Location = New System.Drawing.Point(303, 64)
        Me.buttonFechaHoraFinAhora.Name = "buttonFechaHoraFinAhora"
        Me.buttonFechaHoraFinAhora.Size = New System.Drawing.Size(22, 22)
        Me.buttonFechaHoraFinAhora.TabIndex = 9
        Me.buttonFechaHoraFinAhora.TabStop = False
        Me.buttonFechaHoraFinAhora.Text = "Ahora"
        Me.buttonFechaHoraFinAhora.UseVisualStyleBackColor = True
        '
        'buttonFechaHoraInicioAhora
        '
        Me.buttonFechaHoraInicioAhora.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_CALENDAR_TODAY_16
        Me.buttonFechaHoraInicioAhora.Location = New System.Drawing.Point(303, 38)
        Me.buttonFechaHoraInicioAhora.Name = "buttonFechaHoraInicioAhora"
        Me.buttonFechaHoraInicioAhora.Size = New System.Drawing.Size(22, 22)
        Me.buttonFechaHoraInicioAhora.TabIndex = 5
        Me.buttonFechaHoraInicioAhora.TabStop = False
        Me.buttonFechaHoraInicioAhora.Text = "Ahora"
        Me.buttonFechaHoraInicioAhora.UseVisualStyleBackColor = True
        '
        'labelComprobanteNumero
        '
        Me.labelComprobanteNumero.AutoSize = True
        Me.labelComprobanteNumero.Location = New System.Drawing.Point(6, 96)
        Me.labelComprobanteNumero.Name = "labelComprobanteNumero"
        Me.labelComprobanteNumero.Size = New System.Drawing.Size(70, 13)
        Me.labelComprobanteNumero.TabIndex = 10
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
        Me.maskedtextboxComprobanteNumero.TabIndex = 11
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
        Me.datetimepickerHoraFin.TabIndex = 8
        '
        'datetimepickerFechaFin
        '
        Me.datetimepickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datetimepickerFechaFin.Location = New System.Drawing.Point(92, 65)
        Me.datetimepickerFechaFin.MaxDate = New Date(2099, 12, 31, 0, 0, 0, 0)
        Me.datetimepickerFechaFin.MinDate = New Date(2017, 1, 1, 0, 0, 0, 0)
        Me.datetimepickerFechaFin.Name = "datetimepickerFechaFin"
        Me.datetimepickerFechaFin.Size = New System.Drawing.Size(114, 20)
        Me.datetimepickerFechaFin.TabIndex = 7
        '
        'labelFin
        '
        Me.labelFin.AutoSize = True
        Me.labelFin.Location = New System.Drawing.Point(6, 69)
        Me.labelFin.Name = "labelFin"
        Me.labelFin.Size = New System.Drawing.Size(24, 13)
        Me.labelFin.TabIndex = 6
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
        Me.groupboxKilogramo.Controls.Add(Me.buttonObtenerKilogramosTara)
        Me.groupboxKilogramo.Controls.Add(Me.buttonObtenerKilogramosBrutos)
        Me.groupboxKilogramo.Controls.Add(Me.labelKilogramoNeto)
        Me.groupboxKilogramo.Controls.Add(Me.integertextboxKilogramoNeto)
        Me.groupboxKilogramo.Controls.Add(Me.labelKilogramoTara)
        Me.groupboxKilogramo.Controls.Add(Me.integertextboxKilogramoTara)
        Me.groupboxKilogramo.Controls.Add(Me.labelKilogramoBruto)
        Me.groupboxKilogramo.Controls.Add(Me.integertextboxKilogramoBruto)
        Me.groupboxKilogramo.Location = New System.Drawing.Point(381, 223)
        Me.groupboxKilogramo.Name = "groupboxKilogramo"
        Me.groupboxKilogramo.Size = New System.Drawing.Size(353, 70)
        Me.groupboxKilogramo.TabIndex = 4
        Me.groupboxKilogramo.TabStop = False
        '
        'buttonObtenerKilogramosTara
        '
        Me.buttonObtenerKilogramosTara.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_SCALE_16
        Me.buttonObtenerKilogramosTara.Location = New System.Drawing.Point(151, 38)
        Me.buttonObtenerKilogramosTara.Name = "buttonObtenerKilogramosTara"
        Me.buttonObtenerKilogramosTara.Size = New System.Drawing.Size(22, 22)
        Me.buttonObtenerKilogramosTara.TabIndex = 5
        Me.buttonObtenerKilogramosTara.Text = "Ahora"
        Me.buttonObtenerKilogramosTara.UseVisualStyleBackColor = True
        '
        'buttonObtenerKilogramosBrutos
        '
        Me.buttonObtenerKilogramosBrutos.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_SCALE_16
        Me.buttonObtenerKilogramosBrutos.Location = New System.Drawing.Point(151, 12)
        Me.buttonObtenerKilogramosBrutos.Name = "buttonObtenerKilogramosBrutos"
        Me.buttonObtenerKilogramosBrutos.Size = New System.Drawing.Size(22, 22)
        Me.buttonObtenerKilogramosBrutos.TabIndex = 2
        Me.buttonObtenerKilogramosBrutos.Text = "Ahora"
        Me.buttonObtenerKilogramosBrutos.UseVisualStyleBackColor = True
        '
        'labelKilogramoNeto
        '
        Me.labelKilogramoNeto.AutoSize = True
        Me.labelKilogramoNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelKilogramoNeto.Location = New System.Drawing.Point(193, 29)
        Me.labelKilogramoNeto.Name = "labelKilogramoNeto"
        Me.labelKilogramoNeto.Size = New System.Drawing.Size(69, 16)
        Me.labelKilogramoNeto.TabIndex = 6
        Me.labelKilogramoNeto.Text = "Kgs. Neto:"
        '
        'integertextboxKilogramoNeto
        '
        Me.integertextboxKilogramoNeto.AllowNull = True
        Me.integertextboxKilogramoNeto.BackGroundColor = System.Drawing.SystemColors.Window
        Me.integertextboxKilogramoNeto.BeforeTouchSize = New System.Drawing.Size(38, 20)
        Me.integertextboxKilogramoNeto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.integertextboxKilogramoNeto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.integertextboxKilogramoNeto.IntegerValue = CType(0, Long)
        Me.integertextboxKilogramoNeto.Location = New System.Drawing.Point(268, 26)
        Me.integertextboxKilogramoNeto.MaxValue = CType(99999, Long)
        Me.integertextboxKilogramoNeto.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.integertextboxKilogramoNeto.MinValue = CType(-99999, Long)
        Me.integertextboxKilogramoNeto.Name = "integertextboxKilogramoNeto"
        Me.integertextboxKilogramoNeto.NullString = ""
        Me.integertextboxKilogramoNeto.NumberNegativePattern = 0
        Me.integertextboxKilogramoNeto.ReadOnly = True
        Me.integertextboxKilogramoNeto.Size = New System.Drawing.Size(79, 22)
        Me.integertextboxKilogramoNeto.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.integertextboxKilogramoNeto.TabIndex = 7
        Me.integertextboxKilogramoNeto.TabStop = False
        Me.integertextboxKilogramoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.integertextboxKilogramoNeto.WordWrap = False
        '
        'labelKilogramoTara
        '
        Me.labelKilogramoTara.AutoSize = True
        Me.labelKilogramoTara.Location = New System.Drawing.Point(6, 42)
        Me.labelKilogramoTara.Name = "labelKilogramoTara"
        Me.labelKilogramoTara.Size = New System.Drawing.Size(56, 13)
        Me.labelKilogramoTara.TabIndex = 3
        Me.labelKilogramoTara.Text = "Kgs. Tara:"
        '
        'integertextboxKilogramoTara
        '
        Me.integertextboxKilogramoTara.AllowNull = True
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
        Me.integertextboxKilogramoTara.TabIndex = 4
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
        Me.integertextboxKilogramoBruto.AllowNull = True
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
        Me.groupboxAnalisis.Controls.Add(Me.integertextboxGranoDaniado)
        Me.groupboxAnalisis.Controls.Add(Me.integertextboxGranoVerde)
        Me.groupboxAnalisis.Controls.Add(Me.labelMezclado)
        Me.groupboxAnalisis.Controls.Add(Me.checkboxMezclado)
        Me.groupboxAnalisis.Controls.Add(Me.labelFumigado)
        Me.groupboxAnalisis.Controls.Add(Me.checkboxFumigado)
        Me.groupboxAnalisis.Controls.Add(Me.doubletextboxGluten)
        Me.groupboxAnalisis.Controls.Add(Me.labelGluten)
        Me.groupboxAnalisis.Controls.Add(Me.doubletextboxPesoHectolitrico)
        Me.groupboxAnalisis.Controls.Add(Me.labelPesoHectolitrico)
        Me.groupboxAnalisis.Controls.Add(Me.labelGranoDaniado)
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
        'integertextboxGranoDaniado
        '
        Me.integertextboxGranoDaniado.AllowNull = True
        Me.integertextboxGranoDaniado.BackGroundColor = System.Drawing.SystemColors.Window
        Me.integertextboxGranoDaniado.BeforeTouchSize = New System.Drawing.Size(38, 20)
        Me.integertextboxGranoDaniado.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.integertextboxGranoDaniado.IntegerValue = CType(0, Long)
        Me.integertextboxGranoDaniado.Location = New System.Drawing.Point(206, 38)
        Me.integertextboxGranoDaniado.MaxValue = CType(99, Long)
        Me.integertextboxGranoDaniado.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.integertextboxGranoDaniado.MinValue = CType(0, Long)
        Me.integertextboxGranoDaniado.Name = "integertextboxGranoDaniado"
        Me.integertextboxGranoDaniado.NullString = ""
        Me.integertextboxGranoDaniado.NumberNegativePattern = 0
        Me.integertextboxGranoDaniado.Size = New System.Drawing.Size(38, 20)
        Me.integertextboxGranoDaniado.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.integertextboxGranoDaniado.TabIndex = 9
        Me.integertextboxGranoDaniado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.integertextboxGranoDaniado.WordWrap = False
        '
        'integertextboxGranoVerde
        '
        Me.integertextboxGranoVerde.AllowNull = True
        Me.integertextboxGranoVerde.BackGroundColor = System.Drawing.SystemColors.Window
        Me.integertextboxGranoVerde.BeforeTouchSize = New System.Drawing.Size(38, 20)
        Me.integertextboxGranoVerde.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.integertextboxGranoVerde.IntegerValue = CType(0, Long)
        Me.integertextboxGranoVerde.Location = New System.Drawing.Point(206, 12)
        Me.integertextboxGranoVerde.MaxValue = CType(99, Long)
        Me.integertextboxGranoVerde.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.integertextboxGranoVerde.MinValue = CType(0, Long)
        Me.integertextboxGranoVerde.Name = "integertextboxGranoVerde"
        Me.integertextboxGranoVerde.NullString = ""
        Me.integertextboxGranoVerde.NumberNegativePattern = 0
        Me.integertextboxGranoVerde.Size = New System.Drawing.Size(38, 20)
        Me.integertextboxGranoVerde.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.integertextboxGranoVerde.TabIndex = 7
        Me.integertextboxGranoVerde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.integertextboxGranoVerde.WordWrap = False
        '
        'labelMezclado
        '
        Me.labelMezclado.AutoSize = True
        Me.labelMezclado.Location = New System.Drawing.Point(112, 65)
        Me.labelMezclado.Name = "labelMezclado"
        Me.labelMezclado.Size = New System.Drawing.Size(56, 13)
        Me.labelMezclado.TabIndex = 10
        Me.labelMezclado.Text = "Mezclado:"
        '
        'checkboxMezclado
        '
        Me.checkboxMezclado.AutoSize = True
        Me.checkboxMezclado.Location = New System.Drawing.Point(206, 66)
        Me.checkboxMezclado.Name = "checkboxMezclado"
        Me.checkboxMezclado.Size = New System.Drawing.Size(15, 14)
        Me.checkboxMezclado.TabIndex = 11
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
        Me.doubletextboxGluten.AllowNull = True
        Me.doubletextboxGluten.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxGluten.BeforeTouchSize = New System.Drawing.Size(38, 20)
        Me.doubletextboxGluten.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxGluten.DoubleValue = 0.0R
        Me.doubletextboxGluten.Location = New System.Drawing.Point(309, 38)
        Me.doubletextboxGluten.MaxValue = 80.0R
        Me.doubletextboxGluten.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxGluten.MinValue = 0.0R
        Me.doubletextboxGluten.Name = "doubletextboxGluten"
        Me.doubletextboxGluten.NullString = ""
        Me.doubletextboxGluten.NumberDecimalDigits = 1
        Me.doubletextboxGluten.NumberNegativePattern = 0
        Me.doubletextboxGluten.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxGluten.Size = New System.Drawing.Size(38, 20)
        Me.doubletextboxGluten.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxGluten.TabIndex = 15
        Me.doubletextboxGluten.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxGluten.WordWrap = False
        '
        'labelGluten
        '
        Me.labelGluten.AutoSize = True
        Me.labelGluten.Location = New System.Drawing.Point(247, 41)
        Me.labelGluten.Name = "labelGluten"
        Me.labelGluten.Size = New System.Drawing.Size(41, 13)
        Me.labelGluten.TabIndex = 14
        Me.labelGluten.Text = "Gluten:"
        '
        'doubletextboxPesoHectolitrico
        '
        Me.doubletextboxPesoHectolitrico.AllowNull = True
        Me.doubletextboxPesoHectolitrico.BackGroundColor = System.Drawing.SystemColors.Window
        Me.doubletextboxPesoHectolitrico.BeforeTouchSize = New System.Drawing.Size(38, 20)
        Me.doubletextboxPesoHectolitrico.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxPesoHectolitrico.DoubleValue = 0.0R
        Me.doubletextboxPesoHectolitrico.Location = New System.Drawing.Point(309, 12)
        Me.doubletextboxPesoHectolitrico.MaxValue = 100.0R
        Me.doubletextboxPesoHectolitrico.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxPesoHectolitrico.MinValue = 0.0R
        Me.doubletextboxPesoHectolitrico.Name = "doubletextboxPesoHectolitrico"
        Me.doubletextboxPesoHectolitrico.NullString = ""
        Me.doubletextboxPesoHectolitrico.NumberDecimalDigits = 1
        Me.doubletextboxPesoHectolitrico.NumberNegativePattern = 0
        Me.doubletextboxPesoHectolitrico.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxPesoHectolitrico.Size = New System.Drawing.Size(38, 20)
        Me.doubletextboxPesoHectolitrico.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.[Default]
        Me.doubletextboxPesoHectolitrico.TabIndex = 13
        Me.doubletextboxPesoHectolitrico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxPesoHectolitrico.WordWrap = False
        '
        'labelPesoHectolitrico
        '
        Me.labelPesoHectolitrico.AutoSize = True
        Me.labelPesoHectolitrico.Location = New System.Drawing.Point(247, 15)
        Me.labelPesoHectolitrico.Name = "labelPesoHectolitrico"
        Me.labelPesoHectolitrico.Size = New System.Drawing.Size(63, 13)
        Me.labelPesoHectolitrico.TabIndex = 12
        Me.labelPesoHectolitrico.Text = "Peso Hect.:"
        '
        'labelGranoDaniado
        '
        Me.labelGranoDaniado.AutoSize = True
        Me.labelGranoDaniado.Location = New System.Drawing.Point(112, 41)
        Me.labelGranoDaniado.Name = "labelGranoDaniado"
        Me.labelGranoDaniado.Size = New System.Drawing.Size(88, 13)
        Me.labelGranoDaniado.TabIndex = 8
        Me.labelGranoDaniado.Text = "Granos dañados:"
        '
        'labelGranoVerde
        '
        Me.labelGranoVerde.AutoSize = True
        Me.labelGranoVerde.Location = New System.Drawing.Point(112, 15)
        Me.labelGranoVerde.Name = "labelGranoVerde"
        Me.labelGranoVerde.Size = New System.Drawing.Size(79, 13)
        Me.labelGranoVerde.TabIndex = 6
        Me.labelGranoVerde.Text = "Granos verdes:"
        '
        'doubletextboxZaranda
        '
        Me.doubletextboxZaranda.AllowNull = True
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
        Me.doubletextboxZaranda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.doubletextboxHumedad.AllowNull = True
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
        Me.doubletextboxHumedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'buttonEsActivo
        '
        Me.buttonEsActivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.buttonEsActivo.Image = CType(resources.GetObject("buttonEsActivo.Image"), System.Drawing.Image)
        Me.buttonEsActivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEsActivo.Name = "buttonEsActivo"
        Me.buttonEsActivo.Size = New System.Drawing.Size(45, 36)
        Me.buttonEsActivo.Text = "Activo"
        '
        'buttonEsSincronizado
        '
        Me.buttonEsSincronizado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.buttonEsSincronizado.Image = CType(resources.GetObject("buttonEsSincronizado.Image"), System.Drawing.Image)
        Me.buttonEsSincronizado.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEsSincronizado.Name = "buttonEsSincronizado"
        Me.buttonEsSincronizado.Size = New System.Drawing.Size(79, 36)
        Me.buttonEsSincronizado.Text = "Sincronizado"
        '
        'formPesada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 469)
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
        Me.MinimizeBox = False
        Me.Name = "formPesada"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle de la Entidad"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.groupboxTransporte.ResumeLayout(False)
        Me.groupboxTransporte.PerformLayout()
        CType(Me.integertextboxKilometro, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.integertextboxGranoDaniado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.integertextboxGranoVerde, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxGluten, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxPesoHectolitrico, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents groupboxAnalisis As System.Windows.Forms.GroupBox
    Friend WithEvents labelHumedad As System.Windows.Forms.Label
    Friend WithEvents doubletextboxHumedad As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents doubletextboxZaranda As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelZaranda As System.Windows.Forms.Label
    Friend WithEvents doubletextboxGluten As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelGluten As System.Windows.Forms.Label
    Friend WithEvents doubletextboxPesoHectolitrico As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents labelPesoHectolitrico As System.Windows.Forms.Label
    Friend WithEvents labelGranoDaniado As System.Windows.Forms.Label
    Friend WithEvents labelGranoVerde As System.Windows.Forms.Label
    Friend WithEvents labelFumigado As System.Windows.Forms.Label
    Friend WithEvents checkboxFumigado As System.Windows.Forms.CheckBox
    Friend WithEvents labelMezclado As System.Windows.Forms.Label
    Friend WithEvents checkboxMezclado As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxProductoOtro As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxOrigenDestinoTodos As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxOrigenDestinoOtro As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxTitularOtro As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxTitularTodos As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxTransportistaOtro As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxTransportistaTodos As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxChoferOtro As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxChoferTodos As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxCamionOtro As System.Windows.Forms.CheckBox
    Friend WithEvents labelTipo As System.Windows.Forms.Label
    Friend WithEvents checkboxTipoTodos As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxCosechaTodos As System.Windows.Forms.CheckBox
    Friend WithEvents buttonFechaHoraInicioAhora As System.Windows.Forms.Button
    Friend WithEvents buttonFechaHoraFinAhora As System.Windows.Forms.Button
    Friend WithEvents buttonObtenerKilogramosBrutos As System.Windows.Forms.Button
    Friend WithEvents buttonObtenerKilogramosTara As System.Windows.Forms.Button
    Friend WithEvents labelKilometro As System.Windows.Forms.Label
    Friend WithEvents integertextboxKilometro As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents labelComprobanteNumeroTercero As System.Windows.Forms.Label
    Friend WithEvents maskedtextboxComprobanteNumeroTercero As System.Windows.Forms.MaskedTextBox
    Friend WithEvents integertextboxGranoDaniado As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents integertextboxGranoVerde As Syncfusion.Windows.Forms.Tools.IntegerTextBox
    Friend WithEvents buttonEsActivo As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEsSincronizado As System.Windows.Forms.ToolStripButton
End Class
