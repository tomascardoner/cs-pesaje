<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formProductoMermaHumedad
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
        Me.DoubleTextBoxMerma = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.DoubleTextBoxHumedad = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.LabelMerma = New System.Windows.Forms.Label()
        Me.LabelHumedad = New System.Windows.Forms.Label()
        Me.toolstripMain.SuspendLayout()
        CType(Me.DoubleTextBoxMerma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoubleTextBoxHumedad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(212, 39)
        Me.toolstripMain.TabIndex = 4
        '
        'DoubleTextBoxMerma
        '
        Me.DoubleTextBoxMerma.BeforeTouchSize = New System.Drawing.Size(33, 20)
        Me.DoubleTextBoxMerma.DoubleValue = 0R
        Me.DoubleTextBoxMerma.Location = New System.Drawing.Point(74, 78)
        Me.DoubleTextBoxMerma.MaxValue = 50.0R
        Me.DoubleTextBoxMerma.MinValue = 0R
        Me.DoubleTextBoxMerma.Name = "DoubleTextBoxMerma"
        Me.DoubleTextBoxMerma.Size = New System.Drawing.Size(39, 20)
        Me.DoubleTextBoxMerma.TabIndex = 3
        Me.DoubleTextBoxMerma.Text = "0,00"
        Me.DoubleTextBoxMerma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DoubleTextBoxHumedad
        '
        Me.DoubleTextBoxHumedad.BeforeTouchSize = New System.Drawing.Size(33, 20)
        Me.DoubleTextBoxHumedad.DoubleValue = 0R
        Me.DoubleTextBoxHumedad.Location = New System.Drawing.Point(74, 52)
        Me.DoubleTextBoxHumedad.MaxValue = 50.0R
        Me.DoubleTextBoxHumedad.MinValue = 0R
        Me.DoubleTextBoxHumedad.Name = "DoubleTextBoxHumedad"
        Me.DoubleTextBoxHumedad.NumberDecimalDigits = 1
        Me.DoubleTextBoxHumedad.Size = New System.Drawing.Size(33, 20)
        Me.DoubleTextBoxHumedad.TabIndex = 1
        Me.DoubleTextBoxHumedad.Text = "0,0"
        Me.DoubleTextBoxHumedad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelMerma
        '
        Me.LabelMerma.AutoSize = True
        Me.LabelMerma.Location = New System.Drawing.Point(12, 81)
        Me.LabelMerma.Name = "LabelMerma"
        Me.LabelMerma.Size = New System.Drawing.Size(42, 13)
        Me.LabelMerma.TabIndex = 2
        Me.LabelMerma.Text = "Merma:"
        '
        'LabelHumedad
        '
        Me.LabelHumedad.AutoSize = True
        Me.LabelHumedad.Location = New System.Drawing.Point(12, 55)
        Me.LabelHumedad.Name = "LabelHumedad"
        Me.LabelHumedad.Size = New System.Drawing.Size(56, 13)
        Me.LabelHumedad.TabIndex = 0
        Me.LabelHumedad.Text = "Humedad:"
        '
        'formProductoMermaHumedad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(212, 113)
        Me.Controls.Add(Me.DoubleTextBoxMerma)
        Me.Controls.Add(Me.DoubleTextBoxHumedad)
        Me.Controls.Add(Me.LabelMerma)
        Me.Controls.Add(Me.LabelHumedad)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formProductoMermaHumedad"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Merma de humedad"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        CType(Me.DoubleTextBoxMerma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoubleTextBoxHumedad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonCerrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents DoubleTextBoxMerma As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents DoubleTextBoxHumedad As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents LabelMerma As Label
    Friend WithEvents LabelHumedad As Label
End Class
