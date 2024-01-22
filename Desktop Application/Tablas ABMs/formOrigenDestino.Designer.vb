<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formOrigenDestino
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
        Dim labelUbicacionLongitud As System.Windows.Forms.Label
        Dim labelUbicacionLatitud As System.Windows.Forms.Label
        Dim labelDomicilioCodigoPostal As System.Windows.Forms.Label
        Dim labelDomicilioProvincia As System.Windows.Forms.Label
        Dim labelDomicilioLocalidad As System.Windows.Forms.Label
        Dim labelEsActivo As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tooltipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.labelCUIT_CUIL = New System.Windows.Forms.Label()
        Me.tabcontrolMain = New System.Windows.Forms.TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.maskedtextboxCUIT_CUIL = New System.Windows.Forms.MaskedTextBox()
        Me.buttonAbrirEnGoogleEarth = New System.Windows.Forms.Button()
        Me.buttonAbrirEnGoogleMaps = New System.Windows.Forms.Button()
        Me.doubletextboxLongitud = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.doubletextboxLatitud = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.comboboxDomicilioLocalidad = New System.Windows.Forms.ComboBox()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.comboboxDomicilioProvincia = New System.Windows.Forms.ComboBox()
        Me.textboxDomicilio = New System.Windows.Forms.TextBox()
        Me.labelDomicilio = New System.Windows.Forms.Label()
        Me.textboxDomicilioCodigoPostal = New System.Windows.Forms.TextBox()
        Me.tabpageNotasAuditoria = New System.Windows.Forms.TabPage()
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.labelIDOrigenDestino = New System.Windows.Forms.Label()
        Me.textboxIDOrigenDestino = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioModificacion = New System.Windows.Forms.TextBox()
        Me.textboxUsuarioCreacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraModificacion = New System.Windows.Forms.TextBox()
        Me.textboxFechaHoraCreacion = New System.Windows.Forms.TextBox()
        Me.textboxNotas = New System.Windows.Forms.TextBox()
        Me.labelNotas = New System.Windows.Forms.Label()
        labelUbicacionLongitud = New System.Windows.Forms.Label()
        labelUbicacionLatitud = New System.Windows.Forms.Label()
        labelDomicilioCodigoPostal = New System.Windows.Forms.Label()
        labelDomicilioProvincia = New System.Windows.Forms.Label()
        labelDomicilioLocalidad = New System.Windows.Forms.Label()
        labelEsActivo = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        CType(Me.doubletextboxLongitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.doubletextboxLatitud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelUbicacionLongitud
        '
        labelUbicacionLongitud.AutoSize = True
        labelUbicacionLongitud.Location = New System.Drawing.Point(6, 193)
        labelUbicacionLongitud.Name = "labelUbicacionLongitud"
        labelUbicacionLongitud.Size = New System.Drawing.Size(51, 13)
        labelUbicacionLongitud.TabIndex = 14
        labelUbicacionLongitud.Text = "Longitud:"
        '
        'labelUbicacionLatitud
        '
        labelUbicacionLatitud.AutoSize = True
        labelUbicacionLatitud.Location = New System.Drawing.Point(6, 167)
        labelUbicacionLatitud.Name = "labelUbicacionLatitud"
        labelUbicacionLatitud.Size = New System.Drawing.Size(42, 13)
        labelUbicacionLatitud.TabIndex = 12
        labelUbicacionLatitud.Text = "Latitud:"
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
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(6, 122)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 10
        labelEsActivo.Text = "Activo:"
        '
        'labelModificacion
        '
        labelModificacion.AutoSize = True
        labelModificacion.Location = New System.Drawing.Point(6, 197)
        labelModificacion.Name = "labelModificacion"
        labelModificacion.Size = New System.Drawing.Size(102, 13)
        labelModificacion.TabIndex = 31
        labelModificacion.Text = "Ultima Modificación:"
        '
        'labelCreacion
        '
        labelCreacion.AutoSize = True
        labelCreacion.Location = New System.Drawing.Point(6, 171)
        labelCreacion.Name = "labelCreacion"
        labelCreacion.Size = New System.Drawing.Size(52, 13)
        labelCreacion.TabIndex = 28
        labelCreacion.Text = "Creación:"
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(549, 39)
        Me.toolstripMain.TabIndex = 1
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
        'labelCUIT_CUIL
        '
        Me.labelCUIT_CUIL.AutoSize = True
        Me.labelCUIT_CUIL.Location = New System.Drawing.Point(6, 9)
        Me.labelCUIT_CUIL.Name = "labelCUIT_CUIL"
        Me.labelCUIT_CUIL.Size = New System.Drawing.Size(70, 13)
        Me.labelCUIT_CUIL.TabIndex = 0
        Me.labelCUIT_CUIL.Text = "CUIT / CUIL:"
        Me.tooltipMain.SetToolTip(Me.labelCUIT_CUIL, "Ingrese el Número de Documento sin utilizar puntos.")
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(525, 249)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.labelCUIT_CUIL)
        Me.tabpageGeneral.Controls.Add(Me.maskedtextboxCUIT_CUIL)
        Me.tabpageGeneral.Controls.Add(Me.buttonAbrirEnGoogleEarth)
        Me.tabpageGeneral.Controls.Add(Me.buttonAbrirEnGoogleMaps)
        Me.tabpageGeneral.Controls.Add(Me.doubletextboxLongitud)
        Me.tabpageGeneral.Controls.Add(Me.doubletextboxLatitud)
        Me.tabpageGeneral.Controls.Add(labelUbicacionLongitud)
        Me.tabpageGeneral.Controls.Add(labelUbicacionLatitud)
        Me.tabpageGeneral.Controls.Add(Me.textboxNombre)
        Me.tabpageGeneral.Controls.Add(Me.comboboxDomicilioLocalidad)
        Me.tabpageGeneral.Controls.Add(Me.labelNombre)
        Me.tabpageGeneral.Controls.Add(Me.comboboxDomicilioProvincia)
        Me.tabpageGeneral.Controls.Add(Me.textboxDomicilio)
        Me.tabpageGeneral.Controls.Add(labelDomicilioCodigoPostal)
        Me.tabpageGeneral.Controls.Add(Me.labelDomicilio)
        Me.tabpageGeneral.Controls.Add(Me.textboxDomicilioCodigoPostal)
        Me.tabpageGeneral.Controls.Add(labelDomicilioProvincia)
        Me.tabpageGeneral.Controls.Add(labelDomicilioLocalidad)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 25)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpageGeneral.Size = New System.Drawing.Size(517, 220)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'maskedtextboxCUIT_CUIL
        '
        Me.maskedtextboxCUIT_CUIL.AllowPromptAsInput = False
        Me.maskedtextboxCUIT_CUIL.AsciiOnly = True
        Me.maskedtextboxCUIT_CUIL.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxCUIT_CUIL.HidePromptOnLeave = True
        Me.maskedtextboxCUIT_CUIL.Location = New System.Drawing.Point(87, 6)
        Me.maskedtextboxCUIT_CUIL.Mask = "00-00000000-0"
        Me.maskedtextboxCUIT_CUIL.Name = "maskedtextboxCUIT_CUIL"
        Me.maskedtextboxCUIT_CUIL.Size = New System.Drawing.Size(90, 20)
        Me.maskedtextboxCUIT_CUIL.TabIndex = 1
        Me.maskedtextboxCUIT_CUIL.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'buttonAbrirEnGoogleEarth
        '
        Me.buttonAbrirEnGoogleEarth.Location = New System.Drawing.Point(308, 164)
        Me.buttonAbrirEnGoogleEarth.Name = "buttonAbrirEnGoogleEarth"
        Me.buttonAbrirEnGoogleEarth.Size = New System.Drawing.Size(131, 46)
        Me.buttonAbrirEnGoogleEarth.TabIndex = 17
        Me.buttonAbrirEnGoogleEarth.Text = "Abrir en Google Earth"
        Me.buttonAbrirEnGoogleEarth.UseVisualStyleBackColor = True
        Me.buttonAbrirEnGoogleEarth.Visible = False
        '
        'buttonAbrirEnGoogleMaps
        '
        Me.buttonAbrirEnGoogleMaps.Location = New System.Drawing.Point(171, 164)
        Me.buttonAbrirEnGoogleMaps.Name = "buttonAbrirEnGoogleMaps"
        Me.buttonAbrirEnGoogleMaps.Size = New System.Drawing.Size(131, 46)
        Me.buttonAbrirEnGoogleMaps.TabIndex = 16
        Me.buttonAbrirEnGoogleMaps.Text = "Abrir en Google Maps"
        Me.buttonAbrirEnGoogleMaps.UseVisualStyleBackColor = True
        '
        'doubletextboxLongitud
        '
        Me.doubletextboxLongitud.AllowNull = True
        Me.doubletextboxLongitud.BeforeTouchSize = New System.Drawing.Size(78, 20)
        Me.doubletextboxLongitud.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxLongitud.DoubleValue = 0R
        Me.doubletextboxLongitud.ForeColor = System.Drawing.SystemColors.WindowText
        Me.doubletextboxLongitud.Location = New System.Drawing.Point(87, 190)
        Me.doubletextboxLongitud.MaxValue = 180.0R
        Me.doubletextboxLongitud.MinValue = -180.0R
        Me.doubletextboxLongitud.Name = "doubletextboxLongitud"
        Me.doubletextboxLongitud.NumberDecimalDigits = 6
        Me.doubletextboxLongitud.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxLongitud.Size = New System.Drawing.Size(78, 20)
        Me.doubletextboxLongitud.TabIndex = 15
        Me.doubletextboxLongitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxLongitud.WordWrap = False
        '
        'doubletextboxLatitud
        '
        Me.doubletextboxLatitud.AllowNull = True
        Me.doubletextboxLatitud.BeforeTouchSize = New System.Drawing.Size(78, 20)
        Me.doubletextboxLatitud.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxLatitud.DoubleValue = 0R
        Me.doubletextboxLatitud.ForeColor = System.Drawing.SystemColors.WindowText
        Me.doubletextboxLatitud.Location = New System.Drawing.Point(87, 164)
        Me.doubletextboxLatitud.MaxValue = 90.0R
        Me.doubletextboxLatitud.MinValue = -90.0R
        Me.doubletextboxLatitud.Name = "doubletextboxLatitud"
        Me.doubletextboxLatitud.NumberDecimalDigits = 6
        Me.doubletextboxLatitud.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString
        Me.doubletextboxLatitud.Size = New System.Drawing.Size(78, 20)
        Me.doubletextboxLatitud.TabIndex = 13
        Me.doubletextboxLatitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxLatitud.WordWrap = False
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(87, 32)
        Me.textboxNombre.MaxLength = 50
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(283, 20)
        Me.textboxNombre.TabIndex = 3
        '
        'comboboxDomicilioLocalidad
        '
        Me.comboboxDomicilioLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDomicilioLocalidad.FormattingEnabled = True
        Me.comboboxDomicilioLocalidad.Location = New System.Drawing.Point(87, 111)
        Me.comboboxDomicilioLocalidad.Name = "comboboxDomicilioLocalidad"
        Me.comboboxDomicilioLocalidad.Size = New System.Drawing.Size(424, 21)
        Me.comboboxDomicilioLocalidad.TabIndex = 9
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(6, 35)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(47, 13)
        Me.labelNombre.TabIndex = 2
        Me.labelNombre.Text = "Nombre:"
        '
        'comboboxDomicilioProvincia
        '
        Me.comboboxDomicilioProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxDomicilioProvincia.FormattingEnabled = True
        Me.comboboxDomicilioProvincia.Location = New System.Drawing.Point(87, 84)
        Me.comboboxDomicilioProvincia.Name = "comboboxDomicilioProvincia"
        Me.comboboxDomicilioProvincia.Size = New System.Drawing.Size(424, 21)
        Me.comboboxDomicilioProvincia.TabIndex = 7
        '
        'textboxDomicilio
        '
        Me.textboxDomicilio.Location = New System.Drawing.Point(87, 58)
        Me.textboxDomicilio.MaxLength = 100
        Me.textboxDomicilio.Name = "textboxDomicilio"
        Me.textboxDomicilio.Size = New System.Drawing.Size(425, 20)
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
        Me.textboxDomicilioCodigoPostal.Location = New System.Drawing.Point(87, 138)
        Me.textboxDomicilioCodigoPostal.MaxLength = 8
        Me.textboxDomicilioCodigoPostal.Name = "textboxDomicilioCodigoPostal"
        Me.textboxDomicilioCodigoPostal.Size = New System.Drawing.Size(50, 20)
        Me.textboxDomicilioCodigoPostal.TabIndex = 11
        '
        'tabpageNotasAuditoria
        '
        Me.tabpageNotasAuditoria.Controls.Add(Me.checkboxEsActivo)
        Me.tabpageNotasAuditoria.Controls.Add(labelEsActivo)
        Me.tabpageNotasAuditoria.Controls.Add(Me.labelIDOrigenDestino)
        Me.tabpageNotasAuditoria.Controls.Add(Me.textboxIDOrigenDestino)
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
        Me.tabpageNotasAuditoria.Size = New System.Drawing.Size(517, 220)
        Me.tabpageNotasAuditoria.TabIndex = 1
        Me.tabpageNotasAuditoria.Text = "Notas y Auditoría"
        Me.tabpageNotasAuditoria.UseVisualStyleBackColor = True
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(122, 122)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 11
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'labelIDOrigenDestino
        '
        Me.labelIDOrigenDestino.AutoSize = True
        Me.labelIDOrigenDestino.Location = New System.Drawing.Point(6, 145)
        Me.labelIDOrigenDestino.Name = "labelIDOrigenDestino"
        Me.labelIDOrigenDestino.Size = New System.Drawing.Size(110, 13)
        Me.labelIDOrigenDestino.TabIndex = 0
        Me.labelIDOrigenDestino.Text = "N° de Origen-Destino:"
        '
        'textboxIDOrigenDestino
        '
        Me.textboxIDOrigenDestino.Location = New System.Drawing.Point(122, 142)
        Me.textboxIDOrigenDestino.MaxLength = 10
        Me.textboxIDOrigenDestino.Name = "textboxIDOrigenDestino"
        Me.textboxIDOrigenDestino.ReadOnly = True
        Me.textboxIDOrigenDestino.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDOrigenDestino.TabIndex = 27
        Me.textboxIDOrigenDestino.TabStop = False
        Me.textboxIDOrigenDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxUsuarioModificacion
        '
        Me.textboxUsuarioModificacion.Location = New System.Drawing.Point(249, 194)
        Me.textboxUsuarioModificacion.MaxLength = 50
        Me.textboxUsuarioModificacion.Name = "textboxUsuarioModificacion"
        Me.textboxUsuarioModificacion.ReadOnly = True
        Me.textboxUsuarioModificacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioModificacion.TabIndex = 33
        '
        'textboxUsuarioCreacion
        '
        Me.textboxUsuarioCreacion.Location = New System.Drawing.Point(249, 168)
        Me.textboxUsuarioCreacion.MaxLength = 50
        Me.textboxUsuarioCreacion.Name = "textboxUsuarioCreacion"
        Me.textboxUsuarioCreacion.ReadOnly = True
        Me.textboxUsuarioCreacion.Size = New System.Drawing.Size(259, 20)
        Me.textboxUsuarioCreacion.TabIndex = 30
        '
        'textboxFechaHoraModificacion
        '
        Me.textboxFechaHoraModificacion.Location = New System.Drawing.Point(122, 194)
        Me.textboxFechaHoraModificacion.MaxLength = 0
        Me.textboxFechaHoraModificacion.Name = "textboxFechaHoraModificacion"
        Me.textboxFechaHoraModificacion.ReadOnly = True
        Me.textboxFechaHoraModificacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraModificacion.TabIndex = 32
        '
        'textboxFechaHoraCreacion
        '
        Me.textboxFechaHoraCreacion.Location = New System.Drawing.Point(122, 168)
        Me.textboxFechaHoraCreacion.MaxLength = 0
        Me.textboxFechaHoraCreacion.Name = "textboxFechaHoraCreacion"
        Me.textboxFechaHoraCreacion.ReadOnly = True
        Me.textboxFechaHoraCreacion.Size = New System.Drawing.Size(121, 20)
        Me.textboxFechaHoraCreacion.TabIndex = 29
        '
        'textboxNotas
        '
        Me.textboxNotas.Location = New System.Drawing.Point(122, 6)
        Me.textboxNotas.MaxLength = 0
        Me.textboxNotas.Multiline = True
        Me.textboxNotas.Name = "textboxNotas"
        Me.textboxNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxNotas.Size = New System.Drawing.Size(386, 110)
        Me.textboxNotas.TabIndex = 25
        '
        'labelNotas
        '
        Me.labelNotas.AutoSize = True
        Me.labelNotas.Location = New System.Drawing.Point(6, 9)
        Me.labelNotas.Name = "labelNotas"
        Me.labelNotas.Size = New System.Drawing.Size(38, 13)
        Me.labelNotas.TabIndex = 24
        Me.labelNotas.Text = "Notas:"
        '
        'formOrigenDestino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 300)
        Me.Controls.Add(Me.tabcontrolMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "formOrigenDestino"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle del Origen-Destino"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        CType(Me.doubletextboxLongitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.doubletextboxLatitud, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents labelIDOrigenDestino As System.Windows.Forms.Label
    Friend WithEvents labelNombre As System.Windows.Forms.Label
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents labelDomicilio As System.Windows.Forms.Label
    Friend WithEvents textboxDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents comboboxDomicilioLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents comboboxDomicilioProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents textboxDomicilioCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents tabcontrolMain As System.Windows.Forms.TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageNotasAuditoria As System.Windows.Forms.TabPage
    Friend WithEvents textboxIDOrigenDestino As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxUsuarioCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraModificacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxFechaHoraCreacion As System.Windows.Forms.TextBox
    Friend WithEvents textboxNotas As System.Windows.Forms.TextBox
    Friend WithEvents labelNotas As System.Windows.Forms.Label
    Friend WithEvents doubletextboxLongitud As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents doubletextboxLatitud As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents buttonAbrirEnGoogleMaps As System.Windows.Forms.Button
    Friend WithEvents buttonAbrirEnGoogleEarth As System.Windows.Forms.Button
    Friend WithEvents labelCUIT_CUIL As Label
    Friend WithEvents maskedtextboxCUIT_CUIL As MaskedTextBox
End Class
