<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formProductoCosecha
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
        Me.ComboBoxCosecha = New System.Windows.Forms.ComboBox()
        Me.LabelCosecha = New System.Windows.Forms.Label()
        Me.LabelInicio = New System.Windows.Forms.Label()
        Me.DateTimePickerInicio = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFin = New System.Windows.Forms.DateTimePicker()
        Me.LabelFin = New System.Windows.Forms.Label()
        Me.LabelEsActivo = New System.Windows.Forms.Label()
        Me.CheckBoxEsActivo = New System.Windows.Forms.CheckBox()
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
        Me.toolstripMain.Size = New System.Drawing.Size(242, 39)
        Me.toolstripMain.TabIndex = 8
        '
        'ComboBoxCosecha
        '
        Me.ComboBoxCosecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCosecha.FormattingEnabled = True
        Me.ComboBoxCosecha.Location = New System.Drawing.Point(70, 52)
        Me.ComboBoxCosecha.Name = "ComboBoxCosecha"
        Me.ComboBoxCosecha.Size = New System.Drawing.Size(158, 21)
        Me.ComboBoxCosecha.TabIndex = 1
        '
        'LabelCosecha
        '
        Me.LabelCosecha.AutoSize = True
        Me.LabelCosecha.Location = New System.Drawing.Point(12, 55)
        Me.LabelCosecha.Name = "LabelCosecha"
        Me.LabelCosecha.Size = New System.Drawing.Size(52, 13)
        Me.LabelCosecha.TabIndex = 0
        Me.LabelCosecha.Text = "Cosecha:"
        '
        'LabelInicio
        '
        Me.LabelInicio.AutoSize = True
        Me.LabelInicio.Location = New System.Drawing.Point(12, 97)
        Me.LabelInicio.Name = "LabelInicio"
        Me.LabelInicio.Size = New System.Drawing.Size(35, 13)
        Me.LabelInicio.TabIndex = 2
        Me.LabelInicio.Text = "Inicio:"
        '
        'DateTimePickerInicio
        '
        Me.DateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerInicio.Location = New System.Drawing.Point(70, 94)
        Me.DateTimePickerInicio.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerInicio.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerInicio.Name = "DateTimePickerInicio"
        Me.DateTimePickerInicio.Size = New System.Drawing.Size(110, 20)
        Me.DateTimePickerInicio.TabIndex = 3
        '
        'DateTimePickerFin
        '
        Me.DateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFin.Location = New System.Drawing.Point(70, 120)
        Me.DateTimePickerFin.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DateTimePickerFin.MinDate = New Date(2010, 1, 1, 0, 0, 0, 0)
        Me.DateTimePickerFin.Name = "DateTimePickerFin"
        Me.DateTimePickerFin.Size = New System.Drawing.Size(110, 20)
        Me.DateTimePickerFin.TabIndex = 5
        '
        'LabelFin
        '
        Me.LabelFin.AutoSize = True
        Me.LabelFin.Location = New System.Drawing.Point(12, 123)
        Me.LabelFin.Name = "LabelFin"
        Me.LabelFin.Size = New System.Drawing.Size(24, 13)
        Me.LabelFin.TabIndex = 4
        Me.LabelFin.Text = "Fin:"
        '
        'LabelEsActivo
        '
        Me.LabelEsActivo.AutoSize = True
        Me.LabelEsActivo.Location = New System.Drawing.Point(12, 149)
        Me.LabelEsActivo.Name = "LabelEsActivo"
        Me.LabelEsActivo.Size = New System.Drawing.Size(40, 13)
        Me.LabelEsActivo.TabIndex = 6
        Me.LabelEsActivo.Text = "Activo:"
        '
        'CheckBoxEsActivo
        '
        Me.CheckBoxEsActivo.AutoSize = True
        Me.CheckBoxEsActivo.Location = New System.Drawing.Point(70, 149)
        Me.CheckBoxEsActivo.Name = "CheckBoxEsActivo"
        Me.CheckBoxEsActivo.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxEsActivo.TabIndex = 7
        Me.CheckBoxEsActivo.UseVisualStyleBackColor = True
        '
        'formProductoCosecha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(242, 173)
        Me.Controls.Add(Me.CheckBoxEsActivo)
        Me.Controls.Add(Me.LabelEsActivo)
        Me.Controls.Add(Me.DateTimePickerFin)
        Me.Controls.Add(Me.LabelFin)
        Me.Controls.Add(Me.DateTimePickerInicio)
        Me.Controls.Add(Me.LabelInicio)
        Me.Controls.Add(Me.ComboBoxCosecha)
        Me.Controls.Add(Me.LabelCosecha)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formProductoCosecha"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cosecha del Producto"
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
    Friend WithEvents ComboBoxCosecha As ComboBox
    Friend WithEvents LabelCosecha As Label
    Friend WithEvents LabelInicio As Label
    Friend WithEvents DateTimePickerInicio As DateTimePicker
    Friend WithEvents DateTimePickerFin As DateTimePicker
    Friend WithEvents LabelFin As Label
    Friend WithEvents LabelEsActivo As Label
    Friend WithEvents CheckBoxEsActivo As CheckBox
End Class
