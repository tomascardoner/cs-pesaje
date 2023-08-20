<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formEntidad
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
        Me.components = New System.ComponentModel.Container()
        Dim labelTipo As System.Windows.Forms.Label
        Dim labelEsActivo As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim labelDomicilioCodigoPostal As System.Windows.Forms.Label
        Dim labelDomicilioProvincia As System.Windows.Forms.Label
        Dim labelDomicilioLocalidad As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tooltipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.labelCUIT_CUIL = New System.Windows.Forms.Label()
        Me.maskedtextboxCUIT_CUIL = New System.Windows.Forms.MaskedTextBox()
        Me.labelTipoChofer = New System.Windows.Forms.Label()
        Me.labelTipoTransportista = New System.Windows.Forms.Label()
        Me.labelTipoTitular = New System.Windows.Forms.Label()
        Me.checkboxTipoChofer = New System.Windows.Forms.CheckBox()
        Me.checkboxTipoTransportista = New System.Windows.Forms.CheckBox()
        Me.checkboxTipoTitular = New System.Windows.Forms.CheckBox()
        Me.comboboxCamion = New System.Windows.Forms.ComboBox()
        Me.labelTransportista = New System.Windows.Forms.Label()
        Me.labelCamion = New System.Windows.Forms.Label()
        Me.comboboxTransportista = New System.Windows.Forms.ComboBox()
        Me.tabcontrolMain = New CardonerSistemas.TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.comboboxDomicilioLocalidad = New System.Windows.Forms.ComboBox()
        Me.comboboxDomicilioProvincia = New System.Windows.Forms.ComboBox()
        Me.textboxDomicilio = New System.Windows.Forms.TextBox()
        Me.labelDomicilio = New System.Windows.Forms.Label()
        Me.textboxDomicilioCodigoPostal = New System.Windows.Forms.TextBox()
        Me.tabpageOrigenesDestinos = New System.Windows.Forms.TabPage()
        Me.datagridviewOrigenesDestinosIncluidos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bindingsourceOrigenesDestinosIncluidos = New System.Windows.Forms.BindingSource(Me.components)
        Me.datagridviewOrigenesDestinosNoIncluidos = New System.Windows.Forms.DataGridView()
        Me.columnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bindingsourceOrigenesDestinosNoIncluidos = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelOrigenesDestinosNoIncluidos = New System.Windows.Forms.Label()
        Me.panelOrigenesDestinosButtons = New System.Windows.Forms.Panel()
        Me.buttonOrigenesDestinosEliminar = New System.Windows.Forms.Button()
        Me.buttonOrigenesDestinosAgregar = New System.Windows.Forms.Button()
        Me.tabpageProductosPlantas = New System.Windows.Forms.TabPage()
        Me.datagridviewProductosPlantas = New System.Windows.Forms.DataGridView()
        Me.columnProductosPlantasProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnProductosPlantasPlanta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnProductosPlantasTipoEntrada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.columnProductosPlantasTipoSalida = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.columnProductosPlantasTipoNinguno = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.toolstripProductosPlantas = New System.Windows.Forms.ToolStrip()
        Me.buttonProductosPlantasAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonProductosPlantasEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonProductosPlantasBorrar = New System.Windows.Forms.ToolStripButton()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.labelIDEntidad = New System.Windows.Forms.Label()
        Me.textboxIDEntidad = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        labelTipo = New System.Windows.Forms.Label()
        labelEsActivo = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        labelDomicilioCodigoPostal = New System.Windows.Forms.Label()
        labelDomicilioProvincia = New System.Windows.Forms.Label()
        labelDomicilioLocalidad = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageOrigenesDestinos.SuspendLayout()
        CType(Me.datagridviewOrigenesDestinosIncluidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingsourceOrigenesDestinosIncluidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridviewOrigenesDestinosNoIncluidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingsourceOrigenesDestinosNoIncluidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOrigenesDestinosButtons.SuspendLayout()
        Me.tabpageProductosPlantas.SuspendLayout()
        CType(Me.datagridviewProductosPlantas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolstripProductosPlantas.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTipo
        '
        labelTipo.AutoSize = True
        labelTipo.Location = New System.Drawing.Point(6, 193)
        labelTipo.Name = "labelTipo"
        labelTipo.Size = New System.Drawing.Size(31, 13)
        labelTipo.TabIndex = 12
        labelTipo.Text = "Tipo:"
        '
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(8, 235)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 35
        labelEsActivo.Text = "Activo:"
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(8, 310)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 43
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(8, 284)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 40
        labelCreacion.Text = "Creación:"
        '
        'labelDomicilioCodigoPostal
        '
        labelDomicilioCodigoPostal.AutoSize = True
        labelDomicilioCodigoPostal.Location = New System.Drawing.Point(6, 141)
        labelDomicilioCodigoPostal.Name = "labelDomicilioCodigoPostal"
        labelDomicilioCodigoPostal.Size = New System.Drawing.Size(59, 13)
        labelDomicilioCodigoPostal.TabIndex = 10
        labelDomicilioCodigoPostal.Text = "Cód. Post.:"
        '
        'labelDomicilioProvincia
        '
        labelDomicilioProvincia.AutoSize = True
        labelDomicilioProvincia.Location = New System.Drawing.Point(6, 87)
        labelDomicilioProvincia.Name = "labelDomicilioProvincia"
        labelDomicilioProvincia.Size = New System.Drawing.Size(54, 13)
        labelDomicilioProvincia.TabIndex = 6
        labelDomicilioProvincia.Text = "Provincia:"
        '
        'labelDomicilioLocalidad
        '
        labelDomicilioLocalidad.AutoSize = True
        labelDomicilioLocalidad.Location = New System.Drawing.Point(6, 114)
        labelDomicilioLocalidad.Name = "labelDomicilioLocalidad"
        labelDomicilioLocalidad.Size = New System.Drawing.Size(56, 13)
        labelDomicilioLocalidad.TabIndex = 8
        labelDomicilioLocalidad.Text = "Localidad:"
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(6, 9)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(47, 13)
        Me.labelNombre.TabIndex = 0
        Me.labelNombre.Text = "Nombre:"
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(101, 6)
        Me.textboxNombre.MaxLength = 50
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(404, 20)
        Me.textboxNombre.TabIndex = 1
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(552, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'buttonCerrar
        '
        Me.buttonCerrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonCerrar.Image = Global.My.Resources.Resources.ImageClose32
        Me.buttonCerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCerrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCerrar.Name = "buttonCerrar"
        Me.buttonCerrar.Size = New System.Drawing.Size(75, 36)
        Me.buttonCerrar.Text = "Cerrar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.buttonEditar.Image = Global.My.Resources.Resources.ImageItemEditar32
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
        'labelCUIT_CUIL
        '
        Me.labelCUIT_CUIL.AutoSize = True
        Me.labelCUIT_CUIL.Location = New System.Drawing.Point(6, 35)
        Me.labelCUIT_CUIL.Name = "labelCUIT_CUIL"
        Me.labelCUIT_CUIL.Size = New System.Drawing.Size(70, 13)
        Me.labelCUIT_CUIL.TabIndex = 2
        Me.labelCUIT_CUIL.Text = "CUIT / CUIL:"
        Me.tooltipMain.SetToolTip(Me.labelCUIT_CUIL, "Ingrese el Número de Documento sin utilizar puntos.")
        '
        'maskedtextboxCUIT_CUIL
        '
        Me.maskedtextboxCUIT_CUIL.AllowPromptAsInput = False
        Me.maskedtextboxCUIT_CUIL.AsciiOnly = True
        Me.maskedtextboxCUIT_CUIL.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxCUIT_CUIL.HidePromptOnLeave = True
        Me.maskedtextboxCUIT_CUIL.Location = New System.Drawing.Point(101, 32)
        Me.maskedtextboxCUIT_CUIL.Mask = "00-00000000-0"
        Me.maskedtextboxCUIT_CUIL.Name = "maskedtextboxCUIT_CUIL"
        Me.maskedtextboxCUIT_CUIL.Size = New System.Drawing.Size(90, 20)
        Me.maskedtextboxCUIT_CUIL.TabIndex = 3
        Me.maskedtextboxCUIT_CUIL.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'labelTipoChofer
        '
        Me.labelTipoChofer.AutoSize = True
        Me.labelTipoChofer.Location = New System.Drawing.Point(320, 193)
        Me.labelTipoChofer.Name = "labelTipoChofer"
        Me.labelTipoChofer.Size = New System.Drawing.Size(38, 13)
        Me.labelTipoChofer.TabIndex = 18
        Me.labelTipoChofer.Text = "Chofer"
        '
        'labelTipoTransportista
        '
        Me.labelTipoTransportista.AutoSize = True
        Me.labelTipoTransportista.Location = New System.Drawing.Point(206, 193)
        Me.labelTipoTransportista.Name = "labelTipoTransportista"
        Me.labelTipoTransportista.Size = New System.Drawing.Size(68, 13)
        Me.labelTipoTransportista.TabIndex = 16
        Me.labelTipoTransportista.Text = "Transportista"
        '
        'labelTipoTitular
        '
        Me.labelTipoTitular.AutoSize = True
        Me.labelTipoTitular.Location = New System.Drawing.Point(122, 193)
        Me.labelTipoTitular.Name = "labelTipoTitular"
        Me.labelTipoTitular.Size = New System.Drawing.Size(36, 13)
        Me.labelTipoTitular.TabIndex = 14
        Me.labelTipoTitular.Text = "Titular"
        '
        'checkboxTipoChofer
        '
        Me.checkboxTipoChofer.AutoSize = True
        Me.checkboxTipoChofer.Location = New System.Drawing.Point(299, 193)
        Me.checkboxTipoChofer.Name = "checkboxTipoChofer"
        Me.checkboxTipoChofer.Size = New System.Drawing.Size(15, 14)
        Me.checkboxTipoChofer.TabIndex = 17
        Me.checkboxTipoChofer.UseVisualStyleBackColor = True
        '
        'checkboxTipoTransportista
        '
        Me.checkboxTipoTransportista.AutoSize = True
        Me.checkboxTipoTransportista.Location = New System.Drawing.Point(185, 193)
        Me.checkboxTipoTransportista.Name = "checkboxTipoTransportista"
        Me.checkboxTipoTransportista.Size = New System.Drawing.Size(15, 14)
        Me.checkboxTipoTransportista.TabIndex = 15
        Me.checkboxTipoTransportista.UseVisualStyleBackColor = True
        '
        'checkboxTipoTitular
        '
        Me.checkboxTipoTitular.AutoSize = True
        Me.checkboxTipoTitular.Location = New System.Drawing.Point(101, 193)
        Me.checkboxTipoTitular.Name = "checkboxTipoTitular"
        Me.checkboxTipoTitular.Size = New System.Drawing.Size(15, 14)
        Me.checkboxTipoTitular.TabIndex = 13
        Me.checkboxTipoTitular.UseVisualStyleBackColor = True
        '
        'comboboxCamion
        '
        Me.comboboxCamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCamion.FormattingEnabled = True
        Me.comboboxCamion.Location = New System.Drawing.Point(101, 271)
        Me.comboboxCamion.Name = "comboboxCamion"
        Me.comboboxCamion.Size = New System.Drawing.Size(404, 21)
        Me.comboboxCamion.TabIndex = 22
        '
        'labelTransportista
        '
        Me.labelTransportista.AutoSize = True
        Me.labelTransportista.Location = New System.Drawing.Point(6, 246)
        Me.labelTransportista.Name = "labelTransportista"
        Me.labelTransportista.Size = New System.Drawing.Size(71, 13)
        Me.labelTransportista.TabIndex = 19
        Me.labelTransportista.Text = "Transportista:"
        '
        'labelCamion
        '
        Me.labelCamion.AutoSize = True
        Me.labelCamion.Location = New System.Drawing.Point(6, 274)
        Me.labelCamion.Name = "labelCamion"
        Me.labelCamion.Size = New System.Drawing.Size(45, 13)
        Me.labelCamion.TabIndex = 21
        Me.labelCamion.Text = "Camión:"
        '
        'comboboxTransportista
        '
        Me.comboboxTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxTransportista.FormattingEnabled = True
        Me.comboboxTransportista.Location = New System.Drawing.Point(101, 243)
        Me.comboboxTransportista.Name = "comboboxTransportista"
        Me.comboboxTransportista.Size = New System.Drawing.Size(404, 21)
        Me.comboboxTransportista.TabIndex = 20
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageOrigenesDestinos)
        Me.tabcontrolMain.Controls.Add(Me.tabpageProductosPlantas)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(528, 362)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.comboboxDomicilioLocalidad)
        Me.tabpageGeneral.Controls.Add(Me.comboboxDomicilioProvincia)
        Me.tabpageGeneral.Controls.Add(Me.textboxDomicilio)
        Me.tabpageGeneral.Controls.Add(labelDomicilioCodigoPostal)
        Me.tabpageGeneral.Controls.Add(Me.labelDomicilio)
        Me.tabpageGeneral.Controls.Add(Me.textboxDomicilioCodigoPostal)
        Me.tabpageGeneral.Controls.Add(labelDomicilioProvincia)
        Me.tabpageGeneral.Controls.Add(labelDomicilioLocalidad)
        Me.tabpageGeneral.Controls.Add(Me.textboxNombre)
        Me.tabpageGeneral.Controls.Add(Me.labelTipoChofer)
        Me.tabpageGeneral.Controls.Add(Me.checkboxTipoChofer)
        Me.tabpageGeneral.Controls.Add(Me.comboboxTransportista)
        Me.tabpageGeneral.Controls.Add(Me.labelCamion)
        Me.tabpageGeneral.Controls.Add(Me.labelNombre)
        Me.tabpageGeneral.Controls.Add(Me.labelTransportista)
        Me.tabpageGeneral.Controls.Add(Me.labelCUIT_CUIL)
        Me.tabpageGeneral.Controls.Add(Me.comboboxCamion)
        Me.tabpageGeneral.Controls.Add(Me.maskedtextboxCUIT_CUIL)
        Me.tabpageGeneral.Controls.Add(labelTipo)
        Me.tabpageGeneral.Controls.Add(Me.labelTipoTransportista)
        Me.tabpageGeneral.Controls.Add(Me.checkboxTipoTitular)
        Me.tabpageGeneral.Controls.Add(Me.labelTipoTitular)
        Me.tabpageGeneral.Controls.Add(Me.checkboxTipoTransportista)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(520, 333)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'comboboxDomicilioLocalidad
        '
        Me.comboboxDomicilioLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDomicilioLocalidad.FormattingEnabled = True
        Me.comboboxDomicilioLocalidad.Location = New System.Drawing.Point(101, 111)
        Me.comboboxDomicilioLocalidad.Name = "comboboxDomicilioLocalidad"
        Me.comboboxDomicilioLocalidad.Size = New System.Drawing.Size(404, 21)
        Me.comboboxDomicilioLocalidad.TabIndex = 9
        '
        'comboboxDomicilioProvincia
        '
        Me.comboboxDomicilioProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDomicilioProvincia.FormattingEnabled = True
        Me.comboboxDomicilioProvincia.Location = New System.Drawing.Point(101, 84)
        Me.comboboxDomicilioProvincia.Name = "comboboxDomicilioProvincia"
        Me.comboboxDomicilioProvincia.Size = New System.Drawing.Size(404, 21)
        Me.comboboxDomicilioProvincia.TabIndex = 7
        '
        'textboxDomicilio
        '
        Me.textboxDomicilio.Location = New System.Drawing.Point(101, 58)
        Me.textboxDomicilio.MaxLength = 100
        Me.textboxDomicilio.Name = "textboxDomicilio"
        Me.textboxDomicilio.Size = New System.Drawing.Size(405, 20)
        Me.textboxDomicilio.TabIndex = 5
        '
        'labelDomicilio
        '
        Me.labelDomicilio.AutoSize = True
        Me.labelDomicilio.Location = New System.Drawing.Point(6, 61)
        Me.labelDomicilio.Name = "labelDomicilio"
        Me.labelDomicilio.Size = New System.Drawing.Size(52, 13)
        Me.labelDomicilio.TabIndex = 4
        Me.labelDomicilio.Text = "Domicilio:"
        '
        'textboxDomicilioCodigoPostal
        '
        Me.textboxDomicilioCodigoPostal.Location = New System.Drawing.Point(101, 138)
        Me.textboxDomicilioCodigoPostal.MaxLength = 8
        Me.textboxDomicilioCodigoPostal.Name = "textboxDomicilioCodigoPostal"
        Me.textboxDomicilioCodigoPostal.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioCodigoPostal.TabIndex = 11
        '
        'tabpageOrigenesDestinos
        '
        Me.tabpageOrigenesDestinos.Controls.Add(Me.datagridviewOrigenesDestinosIncluidos)
        Me.tabpageOrigenesDestinos.Controls.Add(Me.datagridviewOrigenesDestinosNoIncluidos)
        Me.tabpageOrigenesDestinos.Controls.Add(Me.Label1)
        Me.tabpageOrigenesDestinos.Controls.Add(Me.labelOrigenesDestinosNoIncluidos)
        Me.tabpageOrigenesDestinos.Controls.Add(Me.panelOrigenesDestinosButtons)
        Me.tabpageOrigenesDestinos.Location = New System.Drawing.Point(4, 25)
        Me.tabpageOrigenesDestinos.Name = "tabpageOrigenesDestinos"
        Me.tabpageOrigenesDestinos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageOrigenesDestinos.Size = New System.Drawing.Size(520, 333)
        Me.tabpageOrigenesDestinos.TabIndex = 2
        Me.tabpageOrigenesDestinos.Text = "Orígenes y destinos"
        Me.tabpageOrigenesDestinos.UseVisualStyleBackColor = True
        '
        'datagridviewOrigenesDestinosIncluidos
        '
        Me.datagridviewOrigenesDestinosIncluidos.AllowUserToAddRows = False
        Me.datagridviewOrigenesDestinosIncluidos.AllowUserToDeleteRows = False
        Me.datagridviewOrigenesDestinosIncluidos.AllowUserToOrderColumns = True
        Me.datagridviewOrigenesDestinosIncluidos.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewOrigenesDestinosIncluidos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewOrigenesDestinosIncluidos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.datagridviewOrigenesDestinosIncluidos.AutoGenerateColumns = False
        Me.datagridviewOrigenesDestinosIncluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewOrigenesDestinosIncluidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.datagridviewOrigenesDestinosIncluidos.DataSource = Me.bindingsourceOrigenesDestinosIncluidos
        Me.datagridviewOrigenesDestinosIncluidos.Location = New System.Drawing.Point(296, 34)
        Me.datagridviewOrigenesDestinosIncluidos.MultiSelect = False
        Me.datagridviewOrigenesDestinosIncluidos.Name = "datagridviewOrigenesDestinosIncluidos"
        Me.datagridviewOrigenesDestinosIncluidos.ReadOnly = True
        Me.datagridviewOrigenesDestinosIncluidos.RowHeadersVisible = False
        Me.datagridviewOrigenesDestinosIncluidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewOrigenesDestinosIncluidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewOrigenesDestinosIncluidos.Size = New System.Drawing.Size(225, 299)
        Me.datagridviewOrigenesDestinosIncluidos.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.DataGridViewTextBoxColumn1.Width = 69
        '
        'datagridviewOrigenesDestinosNoIncluidos
        '
        Me.datagridviewOrigenesDestinosNoIncluidos.AllowUserToAddRows = False
        Me.datagridviewOrigenesDestinosNoIncluidos.AllowUserToDeleteRows = False
        Me.datagridviewOrigenesDestinosNoIncluidos.AllowUserToOrderColumns = True
        Me.datagridviewOrigenesDestinosNoIncluidos.AllowUserToResizeRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewOrigenesDestinosNoIncluidos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridviewOrigenesDestinosNoIncluidos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.datagridviewOrigenesDestinosNoIncluidos.AutoGenerateColumns = False
        Me.datagridviewOrigenesDestinosNoIncluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewOrigenesDestinosNoIncluidos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnNombre})
        Me.datagridviewOrigenesDestinosNoIncluidos.DataSource = Me.bindingsourceOrigenesDestinosNoIncluidos
        Me.datagridviewOrigenesDestinosNoIncluidos.Location = New System.Drawing.Point(0, 34)
        Me.datagridviewOrigenesDestinosNoIncluidos.MultiSelect = False
        Me.datagridviewOrigenesDestinosNoIncluidos.Name = "datagridviewOrigenesDestinosNoIncluidos"
        Me.datagridviewOrigenesDestinosNoIncluidos.ReadOnly = True
        Me.datagridviewOrigenesDestinosNoIncluidos.RowHeadersVisible = False
        Me.datagridviewOrigenesDestinosNoIncluidos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewOrigenesDestinosNoIncluidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewOrigenesDestinosNoIncluidos.Size = New System.Drawing.Size(225, 299)
        Me.datagridviewOrigenesDestinosNoIncluidos.TabIndex = 5
        '
        'columnNombre
        '
        Me.columnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnNombre.DataPropertyName = "Nombre"
        Me.columnNombre.HeaderText = "Nombre"
        Me.columnNombre.Name = "columnNombre"
        Me.columnNombre.ReadOnly = True
        Me.columnNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.columnNombre.Width = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(380, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Incluídos:"
        '
        'labelOrigenesDestinosNoIncluidos
        '
        Me.labelOrigenesDestinosNoIncluidos.AutoSize = True
        Me.labelOrigenesDestinosNoIncluidos.Location = New System.Drawing.Point(81, 16)
        Me.labelOrigenesDestinosNoIncluidos.Name = "labelOrigenesDestinosNoIncluidos"
        Me.labelOrigenesDestinosNoIncluidos.Size = New System.Drawing.Size(70, 13)
        Me.labelOrigenesDestinosNoIncluidos.TabIndex = 3
        Me.labelOrigenesDestinosNoIncluidos.Text = "No incluídos:"
        '
        'panelOrigenesDestinosButtons
        '
        Me.panelOrigenesDestinosButtons.Controls.Add(Me.buttonOrigenesDestinosEliminar)
        Me.panelOrigenesDestinosButtons.Controls.Add(Me.buttonOrigenesDestinosAgregar)
        Me.panelOrigenesDestinosButtons.Location = New System.Drawing.Point(235, 153)
        Me.panelOrigenesDestinosButtons.Name = "panelOrigenesDestinosButtons"
        Me.panelOrigenesDestinosButtons.Size = New System.Drawing.Size(51, 56)
        Me.panelOrigenesDestinosButtons.TabIndex = 2
        '
        'buttonOrigenesDestinosEliminar
        '
        Me.buttonOrigenesDestinosEliminar.Location = New System.Drawing.Point(3, 31)
        Me.buttonOrigenesDestinosEliminar.Name = "buttonOrigenesDestinosEliminar"
        Me.buttonOrigenesDestinosEliminar.Size = New System.Drawing.Size(45, 22)
        Me.buttonOrigenesDestinosEliminar.TabIndex = 1
        Me.buttonOrigenesDestinosEliminar.Text = "<-"
        Me.buttonOrigenesDestinosEliminar.UseVisualStyleBackColor = True
        '
        'buttonOrigenesDestinosAgregar
        '
        Me.buttonOrigenesDestinosAgregar.Location = New System.Drawing.Point(3, 3)
        Me.buttonOrigenesDestinosAgregar.Name = "buttonOrigenesDestinosAgregar"
        Me.buttonOrigenesDestinosAgregar.Size = New System.Drawing.Size(45, 22)
        Me.buttonOrigenesDestinosAgregar.TabIndex = 0
        Me.buttonOrigenesDestinosAgregar.Text = "->"
        Me.buttonOrigenesDestinosAgregar.UseVisualStyleBackColor = True
        '
        'tabpageProductosPlantas
        '
        Me.tabpageProductosPlantas.Controls.Add(Me.datagridviewProductosPlantas)
        Me.tabpageProductosPlantas.Controls.Add(Me.toolstripProductosPlantas)
        Me.tabpageProductosPlantas.Location = New System.Drawing.Point(4, 25)
        Me.tabpageProductosPlantas.Name = "tabpageProductosPlantas"
        Me.tabpageProductosPlantas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageProductosPlantas.Size = New System.Drawing.Size(520, 333)
        Me.tabpageProductosPlantas.TabIndex = 3
        Me.tabpageProductosPlantas.Text = "Productos y plantas"
        Me.tabpageProductosPlantas.UseVisualStyleBackColor = True
        '
        'datagridviewProductosPlantas
        '
        Me.datagridviewProductosPlantas.AllowUserToAddRows = False
        Me.datagridviewProductosPlantas.AllowUserToDeleteRows = False
        Me.datagridviewProductosPlantas.AllowUserToResizeRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewProductosPlantas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridviewProductosPlantas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagridviewProductosPlantas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewProductosPlantas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnProductosPlantasProducto, Me.columnProductosPlantasPlanta, Me.columnProductosPlantasTipoEntrada, Me.columnProductosPlantasTipoSalida, Me.columnProductosPlantasTipoNinguno})
        Me.datagridviewProductosPlantas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewProductosPlantas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.datagridviewProductosPlantas.Location = New System.Drawing.Point(89, 3)
        Me.datagridviewProductosPlantas.MultiSelect = False
        Me.datagridviewProductosPlantas.Name = "datagridviewProductosPlantas"
        Me.datagridviewProductosPlantas.ReadOnly = True
        Me.datagridviewProductosPlantas.RowHeadersVisible = False
        Me.datagridviewProductosPlantas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewProductosPlantas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewProductosPlantas.Size = New System.Drawing.Size(428, 327)
        Me.datagridviewProductosPlantas.TabIndex = 3
        '
        'columnProductosPlantasProducto
        '
        Me.columnProductosPlantasProducto.DataPropertyName = "ProductoNombre"
        Me.columnProductosPlantasProducto.HeaderText = "Producto"
        Me.columnProductosPlantasProducto.Name = "columnProductosPlantasProducto"
        Me.columnProductosPlantasProducto.ReadOnly = True
        Me.columnProductosPlantasProducto.Width = 75
        '
        'columnProductosPlantasPlanta
        '
        Me.columnProductosPlantasPlanta.DataPropertyName = "PlantaNombre"
        Me.columnProductosPlantasPlanta.HeaderText = "Planta"
        Me.columnProductosPlantasPlanta.Name = "columnProductosPlantasPlanta"
        Me.columnProductosPlantasPlanta.ReadOnly = True
        Me.columnProductosPlantasPlanta.Width = 62
        '
        'columnProductosPlantasTipoEntrada
        '
        Me.columnProductosPlantasTipoEntrada.DataPropertyName = "TipoEntrada"
        Me.columnProductosPlantasTipoEntrada.HeaderText = "Entrada"
        Me.columnProductosPlantasTipoEntrada.Name = "columnProductosPlantasTipoEntrada"
        Me.columnProductosPlantasTipoEntrada.ReadOnly = True
        Me.columnProductosPlantasTipoEntrada.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.columnProductosPlantasTipoEntrada.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.columnProductosPlantasTipoEntrada.Width = 69
        '
        'columnProductosPlantasTipoSalida
        '
        Me.columnProductosPlantasTipoSalida.DataPropertyName = "TipoSalida"
        Me.columnProductosPlantasTipoSalida.HeaderText = "Salida"
        Me.columnProductosPlantasTipoSalida.Name = "columnProductosPlantasTipoSalida"
        Me.columnProductosPlantasTipoSalida.ReadOnly = True
        Me.columnProductosPlantasTipoSalida.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.columnProductosPlantasTipoSalida.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.columnProductosPlantasTipoSalida.Width = 61
        '
        'columnProductosPlantasTipoNinguno
        '
        Me.columnProductosPlantasTipoNinguno.DataPropertyName = "TipoNinguno"
        Me.columnProductosPlantasTipoNinguno.HeaderText = "Ninguno"
        Me.columnProductosPlantasTipoNinguno.Name = "columnProductosPlantasTipoNinguno"
        Me.columnProductosPlantasTipoNinguno.ReadOnly = True
        Me.columnProductosPlantasTipoNinguno.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.columnProductosPlantasTipoNinguno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.columnProductosPlantasTipoNinguno.Width = 72
        '
        'toolstripProductosPlantas
        '
        Me.toolstripProductosPlantas.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripProductosPlantas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripProductosPlantas.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripProductosPlantas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonProductosPlantasAgregar, Me.buttonProductosPlantasEditar, Me.buttonProductosPlantasBorrar})
        Me.toolstripProductosPlantas.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.toolstripProductosPlantas.Location = New System.Drawing.Point(3, 3)
        Me.toolstripProductosPlantas.Name = "toolstripProductosPlantas"
        Me.toolstripProductosPlantas.Size = New System.Drawing.Size(86, 327)
        Me.toolstripProductosPlantas.TabIndex = 2
        '
        'buttonProductosPlantasAgregar
        '
        Me.buttonProductosPlantasAgregar.Image = Global.My.Resources.Resources.ImageItemAgregar32
        Me.buttonProductosPlantasAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonProductosPlantasAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonProductosPlantasAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonProductosPlantasAgregar.Name = "buttonProductosPlantasAgregar"
        Me.buttonProductosPlantasAgregar.Size = New System.Drawing.Size(83, 36)
        Me.buttonProductosPlantasAgregar.Text = "Agregar"
        '
        'buttonProductosPlantasEditar
        '
        Me.buttonProductosPlantasEditar.Image = Global.My.Resources.Resources.ImageItemEditar32
        Me.buttonProductosPlantasEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonProductosPlantasEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonProductosPlantasEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonProductosPlantasEditar.Name = "buttonProductosPlantasEditar"
        Me.buttonProductosPlantasEditar.Size = New System.Drawing.Size(83, 36)
        Me.buttonProductosPlantasEditar.Text = "Editar"
        '
        'buttonProductosPlantasBorrar
        '
        Me.buttonProductosPlantasBorrar.Image = Global.My.Resources.Resources.ImageItemBorrar32
        Me.buttonProductosPlantasBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonProductosPlantasBorrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonProductosPlantasBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonProductosPlantasBorrar.Name = "buttonProductosPlantasBorrar"
        Me.buttonProductosPlantasBorrar.Size = New System.Drawing.Size(83, 36)
        Me.buttonProductosPlantasBorrar.Text = "Borrar"
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.checkboxEsActivo)
        Me.tabpageNotasAuditoria.Controls.Add(labelEsActivo)
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelIDEntidad)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxIDEntidad)
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(520, 333)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(124, 235)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 36
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'labelIDEntidad
        '
        Me.labelIDEntidad.AutoSize = True
        Me.labelIDEntidad.Location = New System.Drawing.Point(8, 258)
        Me.labelIDEntidad.Name = "labelIDEntidad"
        Me.labelIDEntidad.Size = New System.Drawing.Size(76, 13)
        Me.labelIDEntidad.TabIndex = 34
        Me.labelIDEntidad.Text = "N° de Entidad:"
        '
        'textboxIDEntidad
        '
        Me.textboxIDEntidad.Location = New System.Drawing.Point(124, 255)
        Me.textboxIDEntidad.MaxLength = 10
        Me.textboxIDEntidad.Name = "textboxIDEntidad"
        Me.textboxIDEntidad.ReadOnly = True
        Me.textboxIDEntidad.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDEntidad.TabIndex = 39
        Me.textboxIDEntidad.TabStop = False
        Me.textboxIDEntidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(251, 307)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 45
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(251, 281)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 42
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(124, 307)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 44
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(124, 281)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 41
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(124, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(386, 223)
        Me.textboxNotas.TabIndex = 38
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(8, 9)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 37
        Me.labelNotas.Text = "Notas:"
        '
        'formEntidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 416)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "formEntidad"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle de la Entidad"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        Me.tabpageOrigenesDestinos.ResumeLayout(False)
        Me.tabpageOrigenesDestinos.PerformLayout()
        CType(Me.datagridviewOrigenesDestinosIncluidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingsourceOrigenesDestinosIncluidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridviewOrigenesDestinosNoIncluidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingsourceOrigenesDestinosNoIncluidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOrigenesDestinosButtons.ResumeLayout(False)
        Me.tabpageProductosPlantas.ResumeLayout(False)
        Me.tabpageProductosPlantas.PerformLayout()
        CType(Me.datagridviewProductosPlantas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolstripProductosPlantas.ResumeLayout(False)
        Me.toolstripProductosPlantas.PerformLayout()
        Me.tabpageNotasAuditoria.ResumeLayout(False)
        Me.tabpageNotasAuditoria.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textboxNombre As System.Windows.Forms.TextBox
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tooltipMain As System.Windows.Forms.ToolTip
    Friend WithEvents labelNombre As System.Windows.Forms.Label
    Friend WithEvents labelCUIT_CUIL As System.Windows.Forms.Label
    Friend WithEvents maskedtextboxCUIT_CUIL As System.Windows.Forms.MaskedTextBox
    Friend WithEvents labelTipoChofer As System.Windows.Forms.Label
    Friend WithEvents labelTipoTransportista As System.Windows.Forms.Label
    Friend WithEvents labelTipoTitular As System.Windows.Forms.Label
    Friend WithEvents checkboxTipoChofer As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxTipoTransportista As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxTipoTitular As System.Windows.Forms.CheckBox
    Friend WithEvents comboboxCamion As System.Windows.Forms.ComboBox
    Friend WithEvents labelTransportista As System.Windows.Forms.Label
    Friend WithEvents labelCamion As System.Windows.Forms.Label
    Friend WithEvents comboboxTransportista As System.Windows.Forms.ComboBox
    Friend WithEvents tabcontrolMain As CardonerSistemas.TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents labelIDEntidad As System.Windows.Forms.Label
    Friend WithEvents textboxIDEntidad As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents tabpageOrigenesDestinos As System.Windows.Forms.TabPage
    Friend WithEvents labelOrigenesDestinosNoIncluidos As System.Windows.Forms.Label
    Friend WithEvents panelOrigenesDestinosButtons As System.Windows.Forms.Panel
    Friend WithEvents buttonOrigenesDestinosEliminar As System.Windows.Forms.Button
    Friend WithEvents buttonOrigenesDestinosAgregar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents bindingsourceOrigenesDestinosNoIncluidos As System.Windows.Forms.BindingSource
    Friend WithEvents bindingsourceOrigenesDestinosIncluidos As System.Windows.Forms.BindingSource
    Friend WithEvents datagridviewOrigenesDestinosIncluidos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datagridviewOrigenesDestinosNoIncluidos As System.Windows.Forms.DataGridView
    Friend WithEvents columnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comboboxDomicilioLocalidad As ComboBox
    Friend WithEvents comboboxDomicilioProvincia As ComboBox
    Friend WithEvents textboxDomicilio As TextBox
    Friend WithEvents labelDomicilio As Label
    Friend WithEvents textboxDomicilioCodigoPostal As TextBox
    Friend WithEvents tabpageProductosPlantas As TabPage
    Friend WithEvents datagridviewProductosPlantas As DataGridView
    Friend WithEvents columnProductosPlantasProducto As DataGridViewTextBoxColumn
    Friend WithEvents columnProductosPlantasPlanta As DataGridViewTextBoxColumn
    Friend WithEvents columnProductosPlantasTipoEntrada As DataGridViewCheckBoxColumn
    Friend WithEvents columnProductosPlantasTipoSalida As DataGridViewCheckBoxColumn
    Friend WithEvents columnProductosPlantasTipoNinguno As DataGridViewCheckBoxColumn
    Friend WithEvents toolstripProductosPlantas As ToolStrip
    Friend WithEvents buttonProductosPlantasAgregar As ToolStripButton
    Friend WithEvents buttonProductosPlantasEditar As ToolStripButton
    Friend WithEvents buttonProductosPlantasBorrar As ToolStripButton
End Class
