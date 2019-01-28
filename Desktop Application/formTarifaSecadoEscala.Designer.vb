<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTarifaSecadoEscala
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
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.buttonCerrar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.buttonGuardar = New System.Windows.Forms.ToolStripButton()
        Me.labelHumedadExcesoInicio = New System.Windows.Forms.Label()
        Me.doubletextboxHumedadExcesoInicio = New Syncfusion.Windows.Forms.Tools.DoubleTextBox()
        Me.groupboxTipo = New System.Windows.Forms.GroupBox()
        Me.radiobuttonTipoFijo = New System.Windows.Forms.RadioButton()
        Me.radiobuttonTipoSecadoZarandeo = New System.Windows.Forms.RadioButton()
        Me.radiobuttonTipoSecado = New System.Windows.Forms.RadioButton()
        Me.radiobuttonTipoCompleta = New System.Windows.Forms.RadioButton()
        Me.radiobuttonTipoPunto = New System.Windows.Forms.RadioButton()
        Me.labelTarifa = New System.Windows.Forms.Label()
        Me.currencytextboxTarifa = New Syncfusion.Windows.Forms.Tools.CurrencyTextBox()
        Me.toolstripMain.SuspendLayout()
        CType(Me.doubletextboxHumedadExcesoInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupboxTipo.SuspendLayout()
        CType(Me.currencytextboxTarifa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonCerrar, Me.buttonEditar, Me.buttonCancelar, Me.buttonGuardar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(226, 39)
        Me.toolstripMain.TabIndex = 5
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
        'labelHumedadExcesoInicio
        '
        Me.labelHumedadExcesoInicio.AutoSize = True
        Me.labelHumedadExcesoInicio.Location = New System.Drawing.Point(12, 58)
        Me.labelHumedadExcesoInicio.Name = "labelHumedadExcesoInicio"
        Me.labelHumedadExcesoInicio.Size = New System.Drawing.Size(136, 13)
        Me.labelHumedadExcesoInicio.TabIndex = 0
        Me.labelHumedadExcesoInicio.Text = "Exceso de humedad inicial:"
        '
        'doubletextboxHumedadExcesoInicio
        '
        Me.doubletextboxHumedadExcesoInicio.BeforeTouchSize = New System.Drawing.Size(55, 20)
        Me.doubletextboxHumedadExcesoInicio.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.doubletextboxHumedadExcesoInicio.DoubleValue = 0R
        Me.doubletextboxHumedadExcesoInicio.Location = New System.Drawing.Point(154, 54)
        Me.doubletextboxHumedadExcesoInicio.MaxValue = 99.9R
        Me.doubletextboxHumedadExcesoInicio.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.doubletextboxHumedadExcesoInicio.MinValue = 0R
        Me.doubletextboxHumedadExcesoInicio.Name = "doubletextboxHumedadExcesoInicio"
        Me.doubletextboxHumedadExcesoInicio.NullString = ""
        Me.doubletextboxHumedadExcesoInicio.NumberDecimalDigits = 1
        Me.doubletextboxHumedadExcesoInicio.NumberNegativePattern = 0
        Me.doubletextboxHumedadExcesoInicio.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.KeepFocus
        Me.doubletextboxHumedadExcesoInicio.Size = New System.Drawing.Size(39, 20)
        Me.doubletextboxHumedadExcesoInicio.TabIndex = 1
        Me.doubletextboxHumedadExcesoInicio.Text = "0,0"
        Me.doubletextboxHumedadExcesoInicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.doubletextboxHumedadExcesoInicio.WordWrap = False
        '
        'groupboxTipo
        '
        Me.groupboxTipo.Controls.Add(Me.radiobuttonTipoFijo)
        Me.groupboxTipo.Controls.Add(Me.radiobuttonTipoSecadoZarandeo)
        Me.groupboxTipo.Controls.Add(Me.radiobuttonTipoSecado)
        Me.groupboxTipo.Controls.Add(Me.radiobuttonTipoCompleta)
        Me.groupboxTipo.Controls.Add(Me.radiobuttonTipoPunto)
        Me.groupboxTipo.Location = New System.Drawing.Point(12, 81)
        Me.groupboxTipo.Name = "groupboxTipo"
        Me.groupboxTipo.Size = New System.Drawing.Size(199, 138)
        Me.groupboxTipo.TabIndex = 2
        Me.groupboxTipo.TabStop = False
        Me.groupboxTipo.Text = "Tipo de tarifa:"
        '
        'radiobuttonTipoFijo
        '
        Me.radiobuttonTipoFijo.AutoSize = True
        Me.radiobuttonTipoFijo.Location = New System.Drawing.Point(6, 111)
        Me.radiobuttonTipoFijo.Name = "radiobuttonTipoFijo"
        Me.radiobuttonTipoFijo.Size = New System.Drawing.Size(166, 17)
        Me.radiobuttonTipoFijo.TabIndex = 4
        Me.radiobuttonTipoFijo.TabStop = True
        Me.radiobuttonTipoFijo.Text = "Importe fijo por todo concepto"
        Me.radiobuttonTipoFijo.UseVisualStyleBackColor = True
        '
        'radiobuttonTipoSecadoZarandeo
        '
        Me.radiobuttonTipoSecadoZarandeo.AutoSize = True
        Me.radiobuttonTipoSecadoZarandeo.Location = New System.Drawing.Point(6, 88)
        Me.radiobuttonTipoSecadoZarandeo.Name = "radiobuttonTipoSecadoZarandeo"
        Me.radiobuttonTipoSecadoZarandeo.Size = New System.Drawing.Size(184, 17)
        Me.radiobuttonTipoSecadoZarandeo.TabIndex = 3
        Me.radiobuttonTipoSecadoZarandeo.TabStop = True
        Me.radiobuttonTipoSecadoZarandeo.Text = "Importe de secado y zarandeo fijo"
        Me.radiobuttonTipoSecadoZarandeo.UseVisualStyleBackColor = True
        '
        'radiobuttonTipoSecado
        '
        Me.radiobuttonTipoSecado.AutoSize = True
        Me.radiobuttonTipoSecado.Location = New System.Drawing.Point(6, 65)
        Me.radiobuttonTipoSecado.Name = "radiobuttonTipoSecado"
        Me.radiobuttonTipoSecado.Size = New System.Drawing.Size(129, 17)
        Me.radiobuttonTipoSecado.TabIndex = 2
        Me.radiobuttonTipoSecado.TabStop = True
        Me.radiobuttonTipoSecado.Text = "Importe de secado fijo"
        Me.radiobuttonTipoSecado.UseVisualStyleBackColor = True
        '
        'radiobuttonTipoCompleta
        '
        Me.radiobuttonTipoCompleta.AutoSize = True
        Me.radiobuttonTipoCompleta.Location = New System.Drawing.Point(6, 42)
        Me.radiobuttonTipoCompleta.Name = "radiobuttonTipoCompleta"
        Me.radiobuttonTipoCompleta.Size = New System.Drawing.Size(121, 17)
        Me.radiobuttonTipoCompleta.TabIndex = 1
        Me.radiobuttonTipoCompleta.TabStop = True
        Me.radiobuttonTipoCompleta.Text = "Por escala completa"
        Me.radiobuttonTipoCompleta.UseVisualStyleBackColor = True
        '
        'radiobuttonTipoPunto
        '
        Me.radiobuttonTipoPunto.AutoSize = True
        Me.radiobuttonTipoPunto.Location = New System.Drawing.Point(6, 19)
        Me.radiobuttonTipoPunto.Name = "radiobuttonTipoPunto"
        Me.radiobuttonTipoPunto.Size = New System.Drawing.Size(98, 17)
        Me.radiobuttonTipoPunto.TabIndex = 0
        Me.radiobuttonTipoPunto.TabStop = True
        Me.radiobuttonTipoPunto.Text = "Por cada punto"
        Me.radiobuttonTipoPunto.UseVisualStyleBackColor = True
        '
        'labelTarifa
        '
        Me.labelTarifa.AutoSize = True
        Me.labelTarifa.Location = New System.Drawing.Point(12, 231)
        Me.labelTarifa.Name = "labelTarifa"
        Me.labelTarifa.Size = New System.Drawing.Size(37, 13)
        Me.labelTarifa.TabIndex = 3
        Me.labelTarifa.Text = "Tarifa:"
        '
        'currencytextboxTarifa
        '
        Me.currencytextboxTarifa.BeforeTouchSize = New System.Drawing.Size(55, 20)
        Me.currencytextboxTarifa.CurrentCultureRefresh = True
        Me.currencytextboxTarifa.DecimalValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.currencytextboxTarifa.Location = New System.Drawing.Point(55, 227)
        Me.currencytextboxTarifa.MaxValue = New Decimal(New Integer() {99999, 0, 0, 131072})
        Me.currencytextboxTarifa.Metrocolor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.currencytextboxTarifa.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.currencytextboxTarifa.Name = "currencytextboxTarifa"
        Me.currencytextboxTarifa.NullString = ""
        Me.currencytextboxTarifa.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.KeepFocus
        Me.currencytextboxTarifa.Size = New System.Drawing.Size(55, 20)
        Me.currencytextboxTarifa.TabIndex = 4
        Me.currencytextboxTarifa.Text = "$ 0,00"
        Me.currencytextboxTarifa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.currencytextboxTarifa.WordWrap = False
        '
        'formTarifaSecadoEscala
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(226, 258)
        Me.Controls.Add(Me.currencytextboxTarifa)
        Me.Controls.Add(Me.labelTarifa)
        Me.Controls.Add(Me.groupboxTipo)
        Me.Controls.Add(Me.doubletextboxHumedadExcesoInicio)
        Me.Controls.Add(Me.labelHumedadExcesoInicio)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "formTarifaSecadoEscala"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Escala de Secado"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        CType(Me.doubletextboxHumedadExcesoInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupboxTipo.ResumeLayout(False)
        Me.groupboxTipo.PerformLayout()
        CType(Me.currencytextboxTarifa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents toolstripMain As ToolStrip
    Friend WithEvents buttonCerrar As ToolStripButton
    Friend WithEvents buttonEditar As ToolStripButton
    Friend WithEvents buttonCancelar As ToolStripButton
    Friend WithEvents buttonGuardar As ToolStripButton
    Friend WithEvents labelHumedadExcesoInicio As Label
    Friend WithEvents doubletextboxHumedadExcesoInicio As Syncfusion.Windows.Forms.Tools.DoubleTextBox
    Friend WithEvents groupboxTipo As GroupBox
    Friend WithEvents radiobuttonTipoPunto As RadioButton
    Friend WithEvents radiobuttonTipoCompleta As RadioButton
    Friend WithEvents radiobuttonTipoSecadoZarandeo As RadioButton
    Friend WithEvents radiobuttonTipoSecado As RadioButton
    Friend WithEvents radiobuttonTipoFijo As RadioButton
    Friend WithEvents labelTarifa As Label
    Friend WithEvents currencytextboxTarifa As Syncfusion.Windows.Forms.Tools.CurrencyTextBox
End Class
