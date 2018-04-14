<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCamion
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
        Dim labelEsActivo As System.Windows.Forms.Label
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.labelIDCamion = New System.Windows.Forms.Label()
        Me.textboxIDCamion = New System.Windows.Forms.TextBox()
        Me.textboxNombre = New System.Windows.Forms.TextBox()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tooltipMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.checkboxEsActivo = New System.Windows.Forms.CheckBox()
        Me.labelTransportista = New System.Windows.Forms.Label()
        Me.comboboxTransportista = New System.Windows.Forms.ComboBox()
        Me.labelDominioAcoplado = New System.Windows.Forms.Label()
        Me.textboxDominioAcoplado = New System.Windows.Forms.TextBox()
        Me.textboxDominioChasis = New System.Windows.Forms.TextBox()
        Me.labelDominioChasis = New System.Windows.Forms.Label()
        labelEsActivo = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'labelEsActivo
        '
        labelEsActivo.AutoSize = True
        labelEsActivo.Location = New System.Drawing.Point(222, 52)
        labelEsActivo.Name = "labelEsActivo"
        labelEsActivo.Size = New System.Drawing.Size(40, 13)
        labelEsActivo.TabIndex = 10
        labelEsActivo.Text = "Activo:"
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.Location = New System.Drawing.Point(12, 105)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(47, 13)
        Me.labelNombre.TabIndex = 4
        Me.labelNombre.Text = "Nombre:"
        '
        'labelIDCamion
        '
        Me.labelIDCamion.AutoSize = True
        Me.labelIDCamion.Location = New System.Drawing.Point(12, 52)
        Me.labelIDCamion.Name = "labelIDCamion"
        Me.labelIDCamion.Size = New System.Drawing.Size(75, 13)
        Me.labelIDCamion.TabIndex = 0
        Me.labelIDCamion.Text = "N° de Camion:"
        '
        'textboxIDCamion
        '
        Me.textboxIDCamion.Location = New System.Drawing.Point(114, 49)
        Me.textboxIDCamion.MaxLength = 10
        Me.textboxIDCamion.Name = "textboxIDCamion"
        Me.textboxIDCamion.ReadOnly = True
        Me.textboxIDCamion.Size = New System.Drawing.Size(72, 20)
        Me.textboxIDCamion.TabIndex = 1
        Me.textboxIDCamion.TabStop = False
        Me.textboxIDCamion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textboxNombre
        '
        Me.textboxNombre.Location = New System.Drawing.Point(114, 102)
        Me.textboxNombre.MaxLength = 50
        Me.textboxNombre.Name = "textboxNombre"
        Me.textboxNombre.Size = New System.Drawing.Size(404, 20)
        Me.textboxNombre.TabIndex = 5
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(534, 39)
        Me.toolstripMain.TabIndex = 12
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
        'checkboxEsActivo
        '
        Me.checkboxEsActivo.AutoSize = True
        Me.checkboxEsActivo.Location = New System.Drawing.Point(268, 52)
        Me.checkboxEsActivo.Name = "checkboxEsActivo"
        Me.checkboxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.checkboxEsActivo.TabIndex = 11
        Me.checkboxEsActivo.UseVisualStyleBackColor = True
        '
        'labelTransportista
        '
        Me.labelTransportista.AutoSize = True
        Me.labelTransportista.Location = New System.Drawing.Point(12, 78)
        Me.labelTransportista.Name = "labelTransportista"
        Me.labelTransportista.Size = New System.Drawing.Size(71, 13)
        Me.labelTransportista.TabIndex = 2
        Me.labelTransportista.Text = "Transportista:"
        '
        'comboboxTransportista
        '
        Me.comboboxTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxTransportista.FormattingEnabled = True
        Me.comboboxTransportista.Location = New System.Drawing.Point(114, 75)
        Me.comboboxTransportista.Name = "comboboxTransportista"
        Me.comboboxTransportista.Size = New System.Drawing.Size(404, 21)
        Me.comboboxTransportista.TabIndex = 3
        '
        'labelDominioAcoplado
        '
        Me.labelDominioAcoplado.AutoSize = True
        Me.labelDominioAcoplado.Location = New System.Drawing.Point(12, 157)
        Me.labelDominioAcoplado.Name = "labelDominioAcoplado"
        Me.labelDominioAcoplado.Size = New System.Drawing.Size(96, 13)
        Me.labelDominioAcoplado.TabIndex = 8
        Me.labelDominioAcoplado.Text = "Dominio Acoplado:"
        '
        'textboxDominioAcoplado
        '
        Me.textboxDominioAcoplado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textboxDominioAcoplado.Location = New System.Drawing.Point(114, 154)
        Me.textboxDominioAcoplado.MaxLength = 7
        Me.textboxDominioAcoplado.Name = "textboxDominioAcoplado"
        Me.textboxDominioAcoplado.Size = New System.Drawing.Size(68, 20)
        Me.textboxDominioAcoplado.TabIndex = 9
        '
        'textboxDominioChasis
        '
        Me.textboxDominioChasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textboxDominioChasis.Location = New System.Drawing.Point(114, 128)
        Me.textboxDominioChasis.MaxLength = 7
        Me.textboxDominioChasis.Name = "textboxDominioChasis"
        Me.textboxDominioChasis.Size = New System.Drawing.Size(68, 20)
        Me.textboxDominioChasis.TabIndex = 7
        '
        'labelDominioChasis
        '
        Me.labelDominioChasis.AutoSize = True
        Me.labelDominioChasis.Location = New System.Drawing.Point(12, 131)
        Me.labelDominioChasis.Name = "labelDominioChasis"
        Me.labelDominioChasis.Size = New System.Drawing.Size(82, 13)
        Me.labelDominioChasis.TabIndex = 6
        Me.labelDominioChasis.Text = "Dominio Chasis:"
        '
        'formCamion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 192)
        Me.Controls.Add(Me.labelDominioAcoplado)
        Me.Controls.Add(Me.textboxDominioAcoplado)
        Me.Controls.Add(Me.textboxDominioChasis)
        Me.Controls.Add(Me.labelDominioChasis)
        Me.Controls.Add(Me.comboboxTransportista)
        Me.Controls.Add(Me.labelTransportista)
        Me.Controls.Add(Me.checkboxEsActivo)
        Me.Controls.Add(labelEsActivo)
        Me.Controls.Add(Me.toolstripMain)
        Me.Controls.Add(Me.labelIDCamion)
        Me.Controls.Add(Me.textboxIDCamion)
        Me.Controls.Add(Me.labelNombre)
        Me.Controls.Add(Me.textboxNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "formCamion"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Detalle de la Camion"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents textboxIDCamion As System.Windows.Forms.TextBox
    Friend WithEvents textboxNombre As System.Windows.Forms.TextBox
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tooltipMain As System.Windows.Forms.ToolTip
    Friend WithEvents labelIDCamion As System.Windows.Forms.Label
    Friend WithEvents labelNombre As System.Windows.Forms.Label
    Friend WithEvents checkboxEsActivo As System.Windows.Forms.CheckBox
    Friend WithEvents labelTransportista As System.Windows.Forms.Label
    Friend WithEvents comboboxTransportista As System.Windows.Forms.ComboBox
    Friend WithEvents labelDominioAcoplado As System.Windows.Forms.Label
    Friend WithEvents textboxDominioAcoplado As System.Windows.Forms.TextBox
    Friend WithEvents textboxDominioChasis As System.Windows.Forms.TextBox
    Friend WithEvents labelDominioChasis As System.Windows.Forms.Label
End Class
