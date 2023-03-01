<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEntidadProductoPlanta
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
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.LabelProducto = New System.Windows.Forms.Label()
        Me.ComboBoxProducto = New System.Windows.Forms.ComboBox()
        Me.LabelTipoEntrada = New System.Windows.Forms.Label()
        Me.LabelTipoSalida = New System.Windows.Forms.Label()
        Me.LabelTipoNinguno = New System.Windows.Forms.Label()
        Me.ComboBoxPlanta = New System.Windows.Forms.ComboBox()
        Me.LabelPlanta = New System.Windows.Forms.Label()
        Me.CheckBoxTipoEntrada = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTipoSalida = New System.Windows.Forms.CheckBox()
        Me.CheckBoxTipoNinguno = New System.Windows.Forms.CheckBox()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
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
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(356, 39)
        Me.toolstripMain.TabIndex = 10
        '
        'LabelProducto
        '
        Me.LabelProducto.AutoSize = True
        Me.LabelProducto.Location = New System.Drawing.Point(12, 55)
        Me.LabelProducto.Name = "LabelProducto"
        Me.LabelProducto.Size = New System.Drawing.Size(53, 13)
        Me.LabelProducto.TabIndex = 0
        Me.LabelProducto.Text = "Producto:"
        '
        'ComboBoxProducto
        '
        Me.ComboBoxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProducto.FormattingEnabled = True
        Me.ComboBoxProducto.Location = New System.Drawing.Point(92, 52)
        Me.ComboBoxProducto.Name = "ComboBoxProducto"
        Me.ComboBoxProducto.Size = New System.Drawing.Size(249, 21)
        Me.ComboBoxProducto.TabIndex = 1
        '
        'LabelTipoEntrada
        '
        Me.LabelTipoEntrada.AutoSize = True
        Me.LabelTipoEntrada.Location = New System.Drawing.Point(12, 134)
        Me.LabelTipoEntrada.Name = "LabelTipoEntrada"
        Me.LabelTipoEntrada.Size = New System.Drawing.Size(71, 13)
        Me.LabelTipoEntrada.TabIndex = 4
        Me.LabelTipoEntrada.Text = "Tipo Entrada:"
        '
        'LabelTipoSalida
        '
        Me.LabelTipoSalida.AutoSize = True
        Me.LabelTipoSalida.Location = New System.Drawing.Point(12, 161)
        Me.LabelTipoSalida.Name = "LabelTipoSalida"
        Me.LabelTipoSalida.Size = New System.Drawing.Size(63, 13)
        Me.LabelTipoSalida.TabIndex = 6
        Me.LabelTipoSalida.Text = "Tipo Salida:"
        '
        'LabelTipoNinguno
        '
        Me.LabelTipoNinguno.AutoSize = True
        Me.LabelTipoNinguno.Location = New System.Drawing.Point(12, 188)
        Me.LabelTipoNinguno.Name = "LabelTipoNinguno"
        Me.LabelTipoNinguno.Size = New System.Drawing.Size(74, 13)
        Me.LabelTipoNinguno.TabIndex = 8
        Me.LabelTipoNinguno.Text = "Tipo Ninguno:"
        '
        'ComboBoxPlanta
        '
        Me.ComboBoxPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPlanta.FormattingEnabled = True
        Me.ComboBoxPlanta.Location = New System.Drawing.Point(92, 79)
        Me.ComboBoxPlanta.Name = "ComboBoxPlanta"
        Me.ComboBoxPlanta.Size = New System.Drawing.Size(249, 21)
        Me.ComboBoxPlanta.TabIndex = 3
        '
        'LabelPlanta
        '
        Me.LabelPlanta.AutoSize = True
        Me.LabelPlanta.Location = New System.Drawing.Point(12, 82)
        Me.LabelPlanta.Name = "LabelPlanta"
        Me.LabelPlanta.Size = New System.Drawing.Size(40, 13)
        Me.LabelPlanta.TabIndex = 2
        Me.LabelPlanta.Text = "Planta:"
        '
        'CheckBoxTipoEntrada
        '
        Me.CheckBoxTipoEntrada.AutoSize = True
        Me.CheckBoxTipoEntrada.Location = New System.Drawing.Point(92, 134)
        Me.CheckBoxTipoEntrada.Name = "CheckBoxTipoEntrada"
        Me.CheckBoxTipoEntrada.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxTipoEntrada.TabIndex = 5
        Me.CheckBoxTipoEntrada.UseVisualStyleBackColor = True
        '
        'CheckBoxTipoSalida
        '
        Me.CheckBoxTipoSalida.AutoSize = True
        Me.CheckBoxTipoSalida.Location = New System.Drawing.Point(92, 161)
        Me.CheckBoxTipoSalida.Name = "CheckBoxTipoSalida"
        Me.CheckBoxTipoSalida.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxTipoSalida.TabIndex = 7
        Me.CheckBoxTipoSalida.UseVisualStyleBackColor = True
        '
        'CheckBoxTipoNinguno
        '
        Me.CheckBoxTipoNinguno.AutoSize = True
        Me.CheckBoxTipoNinguno.Location = New System.Drawing.Point(92, 188)
        Me.CheckBoxTipoNinguno.Name = "CheckBoxTipoNinguno"
        Me.CheckBoxTipoNinguno.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxTipoNinguno.TabIndex = 9
        Me.CheckBoxTipoNinguno.UseVisualStyleBackColor = True
        '
        'formEntidadProductoPlanta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 218)
        Me.Controls.Add(Me.CheckBoxTipoNinguno)
        Me.Controls.Add(Me.CheckBoxTipoSalida)
        Me.Controls.Add(Me.CheckBoxTipoEntrada)
        Me.Controls.Add(Me.ComboBoxPlanta)
        Me.Controls.Add(Me.LabelPlanta)
        Me.Controls.Add(Me.LabelTipoNinguno)
        Me.Controls.Add(Me.LabelTipoSalida)
        Me.Controls.Add(Me.LabelTipoEntrada)
        Me.Controls.Add(Me.ComboBoxProducto)
        Me.Controls.Add(Me.LabelProducto)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formEntidadProductoPlanta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Planta y Producto de la Entidad"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents LabelProducto As Label
    Friend WithEvents ComboBoxProducto As ComboBox
    Friend WithEvents LabelTipoEntrada As Label
    Friend WithEvents LabelTipoSalida As Label
    Friend WithEvents LabelTipoNinguno As Label
    Friend WithEvents ComboBoxPlanta As ComboBox
    Friend WithEvents LabelPlanta As Label
    Friend WithEvents CheckBoxTipoEntrada As CheckBox
    Friend WithEvents CheckBoxTipoSalida As CheckBox
    Friend WithEvents CheckBoxTipoNinguno As CheckBox
End Class
