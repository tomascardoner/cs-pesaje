﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEntidad
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
        Dim labelEsActivo As System.Windows.Forms.Label
        Dim labelModificacion As System.Windows.Forms.Label
        Dim labelCreacion As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.tabcontrolMain = New CSPesaje.DesktopApplication.CS_Control_TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
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
        Me.tabpageOrigenesDestinos = New System.Windows.Forms.TabPage()
        Me.datagridviewOrigenesDestinosIncluidos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bindingsourceOrigenesDestinosInlcuidos = New System.Windows.Forms.BindingSource(Me.components)
        Me.datagridviewOrigenesDestinosNoIncluidos = New System.Windows.Forms.DataGridView()
        Me.columnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bindingsourceOrigenesDestinosNoInlcuidos = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelOrigenesDestinosNoIncluidos = New System.Windows.Forms.Label()
        Me.panelOrigenesDestinosButtons = New System.Windows.Forms.Panel()
        Me.buttonOrigenesDestinosEliminar = New System.Windows.Forms.Button()
        Me.buttonOrigenesDestinosAgregar = New System.Windows.Forms.Button()
        labelTipo = New System.Windows.Forms.Label()
        labelEsActivo = New System.Windows.Forms.Label()
        labelModificacion = New System.Windows.Forms.Label()
        labelCreacion = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.tabcontrolMain.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageNotasAuditoria.SuspendLayout()
        Me.tabpageOrigenesDestinos.SuspendLayout()
        CType(Me.datagridviewOrigenesDestinosIncluidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingsourceOrigenesDestinosInlcuidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datagridviewOrigenesDestinosNoIncluidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingsourceOrigenesDestinosNoInlcuidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelOrigenesDestinosButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelTipo
        '
        labelTipo.AutoSize = True
        labelTipo.Location = New System.Drawing.Point(6, 63)
        labelTipo.Name = "labelTipo"
        labelTipo.Size = New System.Drawing.Size(31, 13)
        labelTipo.TabIndex = 4
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
        Me.labelTipoChofer.Location = New System.Drawing.Point(320, 63)
        Me.labelTipoChofer.Name = "labelTipoChofer"
        Me.labelTipoChofer.Size = New System.Drawing.Size(38, 13)
        Me.labelTipoChofer.TabIndex = 10
        Me.labelTipoChofer.Text = "Chofer"
        '
        'labelTipoTransportista
        '
        Me.labelTipoTransportista.AutoSize = True
        Me.labelTipoTransportista.Location = New System.Drawing.Point(206, 63)
        Me.labelTipoTransportista.Name = "labelTipoTransportista"
        Me.labelTipoTransportista.Size = New System.Drawing.Size(68, 13)
        Me.labelTipoTransportista.TabIndex = 8
        Me.labelTipoTransportista.Text = "Transportista"
        '
        'labelTipoTitular
        '
        Me.labelTipoTitular.AutoSize = True
        Me.labelTipoTitular.Location = New System.Drawing.Point(122, 63)
        Me.labelTipoTitular.Name = "labelTipoTitular"
        Me.labelTipoTitular.Size = New System.Drawing.Size(36, 13)
        Me.labelTipoTitular.TabIndex = 6
        Me.labelTipoTitular.Text = "Titular"
        '
        'checkboxTipoChofer
        '
        Me.checkboxTipoChofer.AutoSize = True
        Me.checkboxTipoChofer.Location = New System.Drawing.Point(299, 63)
        Me.checkboxTipoChofer.Name = "checkboxTipoChofer"
        Me.checkboxTipoChofer.Size = New System.Drawing.Size(15, 14)
        Me.checkboxTipoChofer.TabIndex = 9
        Me.checkboxTipoChofer.UseVisualStyleBackColor = True
        '
        'checkboxTipoTransportista
        '
        Me.checkboxTipoTransportista.AutoSize = True
        Me.checkboxTipoTransportista.Location = New System.Drawing.Point(185, 63)
        Me.checkboxTipoTransportista.Name = "checkboxTipoTransportista"
        Me.checkboxTipoTransportista.Size = New System.Drawing.Size(15, 14)
        Me.checkboxTipoTransportista.TabIndex = 7
        Me.checkboxTipoTransportista.UseVisualStyleBackColor = True
        '
        'checkboxTipoTitular
        '
        Me.checkboxTipoTitular.AutoSize = True
        Me.checkboxTipoTitular.Location = New System.Drawing.Point(101, 63)
        Me.checkboxTipoTitular.Name = "checkboxTipoTitular"
        Me.checkboxTipoTitular.Size = New System.Drawing.Size(15, 14)
        Me.checkboxTipoTitular.TabIndex = 5
        Me.checkboxTipoTitular.UseVisualStyleBackColor = True
        '
        'comboboxCamion
        '
        Me.comboboxCamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCamion.FormattingEnabled = True
        Me.comboboxCamion.Location = New System.Drawing.Point(101, 141)
        Me.comboboxCamion.Name = "comboboxCamion"
        Me.comboboxCamion.Size = New System.Drawing.Size(404, 21)
        Me.comboboxCamion.TabIndex = 14
        '
        'labelTransportista
        '
        Me.labelTransportista.AutoSize = True
        Me.labelTransportista.Location = New System.Drawing.Point(6, 116)
        Me.labelTransportista.Name = "labelTransportista"
        Me.labelTransportista.Size = New System.Drawing.Size(71, 13)
        Me.labelTransportista.TabIndex = 11
        Me.labelTransportista.Text = "Transportista:"
        '
        'labelCamion
        '
        Me.labelCamion.AutoSize = True
        Me.labelCamion.Location = New System.Drawing.Point(6, 144)
        Me.labelCamion.Name = "labelCamion"
        Me.labelCamion.Size = New System.Drawing.Size(45, 13)
        Me.labelCamion.TabIndex = 13
        Me.labelCamion.Text = "Camión:"
        '
        'comboboxTransportista
        '
        Me.comboboxTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxTransportista.FormattingEnabled = True
        Me.comboboxTransportista.Location = New System.Drawing.Point(101, 113)
        Me.comboboxTransportista.Name = "comboboxTransportista"
        Me.comboboxTransportista.Size = New System.Drawing.Size(404, 21)
        Me.comboboxTransportista.TabIndex = 12
        '
        'tabcontrolMain
        '
        Me.tabcontrolMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabcontrolMain.Controls.Add(Me.tabpageGeneral)
        Me.tabcontrolMain.Controls.Add(Me.tabpageNotasAuditoria)
        Me.tabcontrolMain.Controls.Add(Me.tabpageOrigenesDestinos)
        Me.tabcontrolMain.Location = New System.Drawing.Point(12, 42)
        Me.tabcontrolMain.Name = "tabcontrolMain"
        Me.tabcontrolMain.SelectedIndex = 0
        Me.tabcontrolMain.Size = New System.Drawing.Size(528, 362)
        Me.tabcontrolMain.TabIndex = 0
        '
        'tabpageGeneral
        '
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
        Me.tabpageOrigenesDestinos.Text = "Orígenes-Destinos"
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
        Me.datagridviewOrigenesDestinosIncluidos.DataSource = Me.bindingsourceOrigenesDestinosInlcuidos
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
        Me.datagridviewOrigenesDestinosNoIncluidos.DataSource = Me.bindingsourceOrigenesDestinosNoInlcuidos
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle de la Entidad"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.tabcontrolMain.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        Me.tabpageGeneral.PerformLayout()
        Me.tabpageNotasAuditoria.ResumeLayout(False)
        Me.tabpageNotasAuditoria.PerformLayout()
        Me.tabpageOrigenesDestinos.ResumeLayout(False)
        Me.tabpageOrigenesDestinos.PerformLayout()
        CType(Me.datagridviewOrigenesDestinosIncluidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingsourceOrigenesDestinosInlcuidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datagridviewOrigenesDestinosNoIncluidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingsourceOrigenesDestinosNoInlcuidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelOrigenesDestinosButtons.ResumeLayout(False)
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
    Friend WithEvents tabcontrolMain As CSPesaje.DesktopApplication.CS_Control_TabControl
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
    Friend WithEvents bindingsourceOrigenesDestinosNoInlcuidos As System.Windows.Forms.BindingSource
    Friend WithEvents bindingsourceOrigenesDestinosInlcuidos As System.Windows.Forms.BindingSource
    Friend WithEvents datagridviewOrigenesDestinosIncluidos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents datagridviewOrigenesDestinosNoIncluidos As System.Windows.Forms.DataGridView
    Friend WithEvents columnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
