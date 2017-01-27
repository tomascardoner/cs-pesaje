<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.labelIDEntidad = New System.Windows.Forms.Label()
        Me.textboxIDEntidad = New System.Windows.Forms.TextBox()
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
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.panelEntidadTransportista = New System.Windows.Forms.Panel()
        Me.buttonEntidadTransportistaBorrar = New System.Windows.Forms.Button()
        Me.buttonEntidadTransportista = New System.Windows.Forms.Button()
        Me.textboxEntidadTransportista = New System.Windows.Forms.TextBox()
        Me.pictureboxMain = New System.Windows.Forms.PictureBox()
        Me.comboboxCamion = New System.Windows.Forms.ComboBox()
        Me.labelEntidadTransportista = New System.Windows.Forms.Label()
        Me.labelCamion = New System.Windows.Forms.Label()
        labelTipo = New System.Windows.Forms.Label()
        labelEsActivo = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.panelEntidadTransportista.SuspendLayout()
        CType(Me.pictureboxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labelTipo
        '
        labelTipo.AutoSize = True
        labelTipo.Location = New System.Drawing.Point(12, 146)
        labelTipo.Name = "labelTipo"
        labelTipo.Size = New System.Drawing.Size(31, 13)
        labelTipo.TabIndex = 95
        labelTipo.Text = "Tipo:"
        '
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(286, 52)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 102
        labelEsActivo.Text = "Activo:"
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(73, 80)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(47, 13)
        Me.labelNombre.TabIndex = 7
        Me.labelNombre.Text = "Nombre:"
        '
        'labelIDEntidad
        '
        Me.labelIDEntidad.AutoSize = True
        Me.labelIDEntidad.Location = New System.Drawing.Point(73, 52)
        Me.labelIDEntidad.Name = "labelIDEntidad"
        Me.labelIDEntidad.Size = New System.Drawing.Size(76, 13)
        Me.labelIDEntidad.TabIndex = 1
        Me.labelIDEntidad.Text = "N° de Entidad:"
        '
        'textboxIDEntidad
        '
        Me.textboxIDEntidad.Location = New System.Drawing.Point(155, 49)
        Me.textboxIDEntidad.MaxLength = 10
        Me.textboxIDEntidad.Name = "textboxIDEntidad"
        Me.textboxIDEntidad.ReadOnly = True
        Me.textboxIDEntidad.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDEntidad.TabIndex = 2
        Me.textboxIDEntidad.TabStop = False
        Me.textboxIDEntidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(155, 77)
        Me.textboxNombre.MaxLength = 50
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(404, 20)
        Me.textboxNombre.TabIndex = 8
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(571, 39)
        Me.toolstripMain.TabIndex = 0
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
        Me.labelCUIT_CUIL.Location = New System.Drawing.Point(12, 118)
        Me.labelCUIT_CUIL.Name = "labelCUIT_CUIL"
        Me.labelCUIT_CUIL.Size = New System.Drawing.Size(70, 13)
        Me.labelCUIT_CUIL.TabIndex = 24
        Me.labelCUIT_CUIL.Text = "CUIT / CUIL:"
        Me.tooltipMain.SetToolTip(Me.labelCUIT_CUIL, "Ingrese el Número de Documento sin utilizar puntos.")
        '
        'maskedtextboxCUIT_CUIL
        '
        Me.maskedtextboxCUIT_CUIL.AllowPromptAsInput = False
        Me.maskedtextboxCUIT_CUIL.AsciiOnly = True
        Me.maskedtextboxCUIT_CUIL.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.maskedtextboxCUIT_CUIL.HidePromptOnLeave = True
        Me.maskedtextboxCUIT_CUIL.Location = New System.Drawing.Point(155, 115)
        Me.maskedtextboxCUIT_CUIL.Mask = "00-00000000-0"
        Me.maskedtextboxCUIT_CUIL.Name = "maskedtextboxCUIT_CUIL"
        Me.maskedtextboxCUIT_CUIL.Size = New System.Drawing.Size(90, 20)
        Me.maskedtextboxCUIT_CUIL.TabIndex = 94
        Me.maskedtextboxCUIT_CUIL.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'labelTipoChofer
        '
        Me.labelTipoChofer.AutoSize = True
        Me.labelTipoChofer.Location = New System.Drawing.Point(371, 146)
        Me.labelTipoChofer.Name = "labelTipoChofer"
        Me.labelTipoChofer.Size = New System.Drawing.Size(38, 13)
        Me.labelTipoChofer.TabIndex = 101
        Me.labelTipoChofer.Text = "Chofer"
        '
        'labelTipoTransportista
        '
        Me.labelTipoTransportista.AutoSize = True
        Me.labelTipoTransportista.Location = New System.Drawing.Point(260, 146)
        Me.labelTipoTransportista.Name = "labelTipoTransportista"
        Me.labelTipoTransportista.Size = New System.Drawing.Size(68, 13)
        Me.labelTipoTransportista.TabIndex = 99
        Me.labelTipoTransportista.Text = "Transportista"
        '
        'labelTipoTitular
        '
        Me.labelTipoTitular.AutoSize = True
        Me.labelTipoTitular.Location = New System.Drawing.Point(176, 146)
        Me.labelTipoTitular.Name = "labelTipoTitular"
        Me.labelTipoTitular.Size = New System.Drawing.Size(36, 13)
        Me.labelTipoTitular.TabIndex = 97
        Me.labelTipoTitular.Text = "Titular"
        '
        'checkboxTipoChofer
        '
        Me.checkboxTipoChofer.AutoSize = True
        Me.checkboxTipoChofer.Location = New System.Drawing.Point(350, 146)
        Me.checkboxTipoChofer.Name = "checkboxTipoChofer"
        Me.checkboxTipoChofer.Size = New System.Drawing.Size(15, 14)
        Me.checkboxTipoChofer.TabIndex = 100
        Me.checkboxTipoChofer.UseVisualStyleBackColor = True
        '
        'checkboxTipoTransportista
        '
        Me.checkboxTipoTransportista.AutoSize = True
        Me.checkboxTipoTransportista.Location = New System.Drawing.Point(239, 146)
        Me.checkboxTipoTransportista.Name = "checkboxTipoTransportista"
        Me.checkboxTipoTransportista.Size = New System.Drawing.Size(15, 14)
        Me.checkboxTipoTransportista.TabIndex = 98
        Me.checkboxTipoTransportista.UseVisualStyleBackColor = True
        '
        'checkboxTipoTitular
        '
        Me.checkboxTipoTitular.AutoSize = True
        Me.checkboxTipoTitular.Location = New System.Drawing.Point(155, 146)
        Me.checkboxTipoTitular.Name = "checkboxTipoTitular"
        Me.checkboxTipoTitular.Size = New System.Drawing.Size(15, 14)
        Me.checkboxTipoTitular.TabIndex = 96
        Me.checkboxTipoTitular.UseVisualStyleBackColor = True
        '
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(332, 52)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 103
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'panelEntidadTransportista
        '
        Me.panelEntidadTransportista.Controls.Add(Me.buttonEntidadTransportistaBorrar)
        Me.panelEntidadTransportista.Controls.Add(Me.buttonEntidadTransportista)
        Me.panelEntidadTransportista.Controls.Add(Me.textboxEntidadTransportista)
        Me.panelEntidadTransportista.Location = New System.Drawing.Point(155, 169)
        Me.panelEntidadTransportista.Name = "panelEntidadTransportista"
        Me.panelEntidadTransportista.Size = New System.Drawing.Size(405, 22)
        Me.panelEntidadTransportista.TabIndex = 105
        '
        'buttonEntidadTransportistaBorrar
        '
        Me.buttonEntidadTransportistaBorrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonEntidadTransportistaBorrar.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_CLOSE_16
        Me.buttonEntidadTransportistaBorrar.Location = New System.Drawing.Point(383, 0)
        Me.buttonEntidadTransportistaBorrar.Name = "buttonEntidadTransportistaBorrar"
        Me.buttonEntidadTransportistaBorrar.Size = New System.Drawing.Size(22, 22)
        Me.buttonEntidadTransportistaBorrar.TabIndex = 2
        Me.buttonEntidadTransportistaBorrar.Text = "…"
        Me.buttonEntidadTransportistaBorrar.UseVisualStyleBackColor = True
        '
        'buttonEntidadTransportista
        '
        Me.buttonEntidadTransportista.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonEntidadTransportista.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_SEARCH_16
        Me.buttonEntidadTransportista.Location = New System.Drawing.Point(362, 0)
        Me.buttonEntidadTransportista.Name = "buttonEntidadTransportista"
        Me.buttonEntidadTransportista.Size = New System.Drawing.Size(22, 22)
        Me.buttonEntidadTransportista.TabIndex = 1
        Me.buttonEntidadTransportista.Text = "…"
        Me.buttonEntidadTransportista.UseVisualStyleBackColor = True
        '
        'textboxEntidadTransportista
        '
        Me.textboxEntidadTransportista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textboxEntidadTransportista.Location = New System.Drawing.Point(0, 1)
        Me.textboxEntidadTransportista.MaxLength = 150
        Me.textboxEntidadTransportista.Name = "textboxEntidadTransportista"
        Me.textboxEntidadTransportista.ReadOnly = True
        Me.textboxEntidadTransportista.Size = New System.Drawing.Size(362, 20)
        Me.textboxEntidadTransportista.TabIndex = 0
        Me.textboxEntidadTransportista.TabStop = False
        '
        'pictureboxMain
        '
        Me.pictureboxMain.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_PERSONA_48
        Me.pictureboxMain.Location = New System.Drawing.Point(12, 49)
        Me.pictureboxMain.Name = "pictureboxMain"
        Me.pictureboxMain.Size = New System.Drawing.Size(48, 48)
        Me.pictureboxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pictureboxMain.TabIndex = 93
        Me.pictureboxMain.TabStop = False
        '
        'comboboxCamion
        '
        Me.comboboxCamion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCamion.FormattingEnabled = True
        Me.comboboxCamion.Location = New System.Drawing.Point(155, 199)
        Me.comboboxCamion.Name = "comboboxCamion"
        Me.comboboxCamion.Size = New System.Drawing.Size(404, 21)
        Me.comboboxCamion.TabIndex = 107
        '
        'labelEntidadTransportista
        '
        Me.labelEntidadTransportista.AutoSize = True
        Me.labelEntidadTransportista.Location = New System.Drawing.Point(12, 174)
        Me.labelEntidadTransportista.Name = "labelEntidadTransportista"
        Me.labelEntidadTransportista.Size = New System.Drawing.Size(71, 13)
        Me.labelEntidadTransportista.TabIndex = 108
        Me.labelEntidadTransportista.Text = "Transportista:"
        '
        'labelCamion
        '
        Me.labelCamion.AutoSize = True
        Me.labelCamion.Location = New System.Drawing.Point(12, 202)
        Me.labelCamion.Name = "labelCamion"
        Me.labelCamion.Size = New System.Drawing.Size(45, 13)
        Me.labelCamion.TabIndex = 109
        Me.labelCamion.Text = "Camión:"
        '
        'formEntidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 234)
        Me.Controls.Add(Me.labelCamion)
        Me.Controls.Add(Me.labelEntidadTransportista)
        Me.Controls.Add(Me.comboboxCamion)
        Me.Controls.Add(Me.panelEntidadTransportista)
        Me.Controls.Add(Me.checkboxEsActivo)
        Me.Controls.Add(labelEsActivo)
        Me.Controls.Add(Me.labelTipoChofer)
        Me.Controls.Add(Me.labelTipoTransportista)
        Me.Controls.Add(Me.labelTipoTitular)
        Me.Controls.Add(Me.checkboxTipoChofer)
        Me.Controls.Add(Me.checkboxTipoTransportista)
        Me.Controls.Add(Me.checkboxTipoTitular)
        Me.Controls.Add(labelTipo)
        Me.Controls.Add(Me.maskedtextboxCUIT_CUIL)
        Me.Controls.Add(Me.labelCUIT_CUIL)
        Me.Controls.Add(Me.toolstripMain)
        Me.Controls.Add(Me.pictureboxMain)
        Me.Controls.Add(Me.labelIDEntidad)
        Me.Controls.Add(Me.textboxIDEntidad)
        Me.Controls.Add(Me.labelNombre)
        Me.Controls.Add(Me.textboxNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "formEntidad"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle de la Entidad"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.panelEntidadTransportista.ResumeLayout(False)
        Me.panelEntidadTransportista.PerformLayout()
        CType(Me.pictureboxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textboxIDEntidad As System.Windows.Forms.TextBox
    Friend WithEvents textboxNombre As System.Windows.Forms.TextBox
    Friend WithEvents pictureboxMain As System.Windows.Forms.PictureBox
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tooltipMain As System.Windows.Forms.ToolTip
    Friend WithEvents labelIDEntidad As System.Windows.Forms.Label
    Friend WithEvents labelNombre As System.Windows.Forms.Label
    Friend WithEvents labelCUIT_CUIL As System.Windows.Forms.Label
    Friend WithEvents maskedtextboxCUIT_CUIL As System.Windows.Forms.MaskedTextBox
    Friend WithEvents labelTipoChofer As System.Windows.Forms.Label
    Friend WithEvents labelTipoTransportista As System.Windows.Forms.Label
    Friend WithEvents labelTipoTitular As System.Windows.Forms.Label
    Friend WithEvents checkboxTipoChofer As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxTipoTransportista As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxTipoTitular As System.Windows.Forms.CheckBox
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents panelEntidadTransportista As System.Windows.Forms.Panel
    Friend WithEvents buttonEntidadTransportistaBorrar As System.Windows.Forms.Button
    Friend WithEvents buttonEntidadTransportista As System.Windows.Forms.Button
    Friend WithEvents textboxEntidadTransportista As System.Windows.Forms.TextBox
    Friend WithEvents comboboxCamion As System.Windows.Forms.ComboBox
    Friend WithEvents labelEntidadTransportista As System.Windows.Forms.Label
    Friend WithEvents labelCamion As System.Windows.Forms.Label
End Class
