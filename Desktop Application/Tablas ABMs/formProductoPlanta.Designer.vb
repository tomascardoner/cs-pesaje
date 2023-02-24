<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formProductoPlanta
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
        Me.LabelPlanta = New System.Windows.Forms.Label()
        Me.ComboBoxPlanta = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTipoEntrada = New System.Windows.Forms.ComboBox()
        Me.LabelTipoEntrada = New System.Windows.Forms.Label()
        Me.ComboBoxTipoSalida = New System.Windows.Forms.ComboBox()
        Me.LabelTipoSalida = New System.Windows.Forms.Label()
        Me.ComboBoxTipoNinguno = New System.Windows.Forms.ComboBox()
        Me.LabelTipoNinguno = New System.Windows.Forms.Label()
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
        Me.toolstripMain.TabIndex = 8
        '
        'LabelPlanta
        '
        Me.LabelPlanta.AutoSize = True
        Me.LabelPlanta.Location = New System.Drawing.Point(12, 55)
        Me.LabelPlanta.Name = "LabelPlanta"
        Me.LabelPlanta.Size = New System.Drawing.Size(40, 13)
        Me.LabelPlanta.TabIndex = 0
        Me.LabelPlanta.Text = "Planta:"
        '
        'ComboBoxPlanta
        '
        Me.ComboBoxPlanta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPlanta.FormattingEnabled = True
        Me.ComboBoxPlanta.Location = New System.Drawing.Point(92, 52)
        Me.ComboBoxPlanta.Name = "ComboBoxPlanta"
        Me.ComboBoxPlanta.Size = New System.Drawing.Size(249, 21)
        Me.ComboBoxPlanta.TabIndex = 1
        '
        'ComboBoxTipoEntrada
        '
        Me.ComboBoxTipoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipoEntrada.FormattingEnabled = True
        Me.ComboBoxTipoEntrada.Location = New System.Drawing.Point(92, 94)
        Me.ComboBoxTipoEntrada.Name = "ComboBoxTipoEntrada"
        Me.ComboBoxTipoEntrada.Size = New System.Drawing.Size(128, 21)
        Me.ComboBoxTipoEntrada.TabIndex = 3
        '
        'LabelTipoEntrada
        '
        Me.LabelTipoEntrada.AutoSize = True
        Me.LabelTipoEntrada.Location = New System.Drawing.Point(12, 97)
        Me.LabelTipoEntrada.Name = "LabelTipoEntrada"
        Me.LabelTipoEntrada.Size = New System.Drawing.Size(71, 13)
        Me.LabelTipoEntrada.TabIndex = 2
        Me.LabelTipoEntrada.Text = "Tipo Entrada:"
        '
        'ComboBoxTipoSalida
        '
        Me.ComboBoxTipoSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipoSalida.FormattingEnabled = True
        Me.ComboBoxTipoSalida.Location = New System.Drawing.Point(92, 121)
        Me.ComboBoxTipoSalida.Name = "ComboBoxTipoSalida"
        Me.ComboBoxTipoSalida.Size = New System.Drawing.Size(128, 21)
        Me.ComboBoxTipoSalida.TabIndex = 5
        '
        'LabelTipoSalida
        '
        Me.LabelTipoSalida.AutoSize = True
        Me.LabelTipoSalida.Location = New System.Drawing.Point(12, 124)
        Me.LabelTipoSalida.Name = "LabelTipoSalida"
        Me.LabelTipoSalida.Size = New System.Drawing.Size(63, 13)
        Me.LabelTipoSalida.TabIndex = 4
        Me.LabelTipoSalida.Text = "Tipo Salida:"
        '
        'ComboBoxTipoNinguno
        '
        Me.ComboBoxTipoNinguno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTipoNinguno.FormattingEnabled = True
        Me.ComboBoxTipoNinguno.Location = New System.Drawing.Point(92, 148)
        Me.ComboBoxTipoNinguno.Name = "ComboBoxTipoNinguno"
        Me.ComboBoxTipoNinguno.Size = New System.Drawing.Size(128, 21)
        Me.ComboBoxTipoNinguno.TabIndex = 7
        '
        'LabelTipoNinguno
        '
        Me.LabelTipoNinguno.AutoSize = True
        Me.LabelTipoNinguno.Location = New System.Drawing.Point(12, 151)
        Me.LabelTipoNinguno.Name = "LabelTipoNinguno"
        Me.LabelTipoNinguno.Size = New System.Drawing.Size(74, 13)
        Me.LabelTipoNinguno.TabIndex = 6
        Me.LabelTipoNinguno.Text = "Tipo Ninguno:"
        '
        'formProductoPlanta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 180)
        Me.Controls.Add(Me.ComboBoxTipoNinguno)
        Me.Controls.Add(Me.LabelTipoNinguno)
        Me.Controls.Add(Me.ComboBoxTipoSalida)
        Me.Controls.Add(Me.LabelTipoSalida)
        Me.Controls.Add(Me.ComboBoxTipoEntrada)
        Me.Controls.Add(Me.LabelTipoEntrada)
        Me.Controls.Add(Me.ComboBoxPlanta)
        Me.Controls.Add(Me.LabelPlanta)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formProductoPlanta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Planta del Producto"
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
    Friend WithEvents LabelPlanta As Label
    Friend WithEvents ComboBoxPlanta As ComboBox
    Friend WithEvents ComboBoxTipoEntrada As ComboBox
    Friend WithEvents LabelTipoEntrada As Label
    Friend WithEvents ComboBoxTipoSalida As ComboBox
    Friend WithEvents LabelTipoSalida As Label
    Friend WithEvents ComboBoxTipoNinguno As ComboBox
    Friend WithEvents LabelTipoNinguno As Label
End Class
