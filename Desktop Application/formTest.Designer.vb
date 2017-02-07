<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTest
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
        Me.ribbonMain = New Syncfusion.Windows.Forms.Tools.RibbonControlAdv()
        Me.toolstriptabMain = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.toolstripgroupMain = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.buttonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.toolstripgroupFecha = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.buttonFechaDesdeAnterior = New System.Windows.Forms.ToolStripButton()
        Me.buttonFechaDesdeSiguiente = New System.Windows.Forms.ToolStripButton()
        Me.buttonFechaDesdeHoy = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTabItem2 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.ToolStripTabItem3 = New Syncfusion.Windows.Forms.Tools.ToolStripTabItem()
        Me.ToolStripEx1 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.ToolStripEx2 = New Syncfusion.Windows.Forms.Tools.ToolStripEx()
        Me.comboboxPeriodoTipo = New System.Windows.Forms.ToolStripComboBox()
        Me.labelFechaY = New System.Windows.Forms.ToolStripLabel()
        CType(Me.ribbonMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ribbonMain.SuspendLayout()
        Me.toolstriptabMain.Panel.SuspendLayout()
        Me.toolstripgroupMain.SuspendLayout()
        Me.toolstripgroupFecha.SuspendLayout()
        Me.SuspendLayout()
        '
        'ribbonMain
        '
        Me.ribbonMain.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top
        Me.ribbonMain.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ribbonMain.Header.AddMainItem(toolstriptabMain)
        Me.ribbonMain.Header.AddMainItem(ToolStripTabItem2)
        Me.ribbonMain.Header.AddMainItem(ToolStripTabItem3)
        Me.ribbonMain.Location = New System.Drawing.Point(0, 0)
        Me.ribbonMain.MenuButtonFont = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ribbonMain.MenuButtonText = ""
        Me.ribbonMain.MenuButtonVisible = False
        Me.ribbonMain.MenuColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.ribbonMain.Name = "ribbonMain"
        Me.ribbonMain.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed
        '
        'ribbonMain.OfficeMenu
        '
        Me.ribbonMain.OfficeMenu.Name = "OfficeMenu"
        Me.ribbonMain.OfficeMenu.ShowItemToolTips = True
        Me.ribbonMain.OfficeMenu.Size = New System.Drawing.Size(12, 65)
        Me.ribbonMain.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ribbonMain.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None
        Me.ribbonMain.SelectedTab = Me.toolstriptabMain
        Me.ribbonMain.ShowRibbonDisplayOptionButton = True
        Me.ribbonMain.Size = New System.Drawing.Size(778, 126)
        Me.ribbonMain.SortTabItems = True
        Me.ribbonMain.SystemText.QuickAccessDialogDropDownName = "Start menu"
        Me.ribbonMain.SystemText.RenameDisplayLabelText = "&Display Name:"
        Me.ribbonMain.TabIndex = 3
        '
        'toolstriptabMain
        '
        Me.toolstriptabMain.Name = "toolstriptabMain"
        '
        'ribbonMain.RibbonPanel1
        '
        Me.toolstriptabMain.Panel.Controls.Add(Me.toolstripgroupMain)
        Me.toolstriptabMain.Panel.Controls.Add(Me.toolstripgroupFecha)
        Me.toolstriptabMain.Panel.Name = "RibbonPanel1"
        Me.toolstriptabMain.Panel.ScrollPosition = 0
        Me.toolstriptabMain.Panel.TabIndex = 2
        Me.toolstriptabMain.Panel.Text = "Principal"
        Me.toolstriptabMain.Position = 0
        Me.toolstriptabMain.Size = New System.Drawing.Size(57, 19)
        Me.toolstriptabMain.Tag = "1"
        Me.toolstriptabMain.Text = "Principal"
        '
        'toolstripgroupMain
        '
        Me.toolstripgroupMain.Dock = System.Windows.Forms.DockStyle.None
        Me.toolstripgroupMain.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.toolstripgroupMain.ForeColor = System.Drawing.Color.MidnightBlue
        Me.toolstripgroupMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripgroupMain.Image = Nothing
        Me.toolstripgroupMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.buttonEliminar, Me.ToolStripSplitButton1})
        Me.toolstripgroupMain.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office2007
        Me.toolstripgroupMain.Location = New System.Drawing.Point(0, 1)
        Me.toolstripgroupMain.Name = "toolstripgroupMain"
        Me.toolstripgroupMain.ShowCaption = True
        Me.toolstripgroupMain.ShowLauncher = False
        Me.toolstripgroupMain.Size = New System.Drawing.Size(262, 70)
        Me.toolstripgroupMain.TabIndex = 0
        Me.toolstripgroupMain.Text = "Acciones"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 50)
        Me.ToolStripButton1.Text = "Agregar"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(41, 50)
        Me.ToolStripButton2.Text = "Editar"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_COPY_32
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(45, 50)
        Me.ToolStripButton3.Text = "Copiar"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(52, 50)
        Me.buttonEliminar.Text = "Eliminar"
        Me.buttonEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_PRINT_32
        Me.ToolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(65, 50)
        Me.ToolStripSplitButton1.Text = "Imprimir"
        Me.ToolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolstripgroupFecha
        '
        Me.toolstripgroupFecha.Dock = System.Windows.Forms.DockStyle.None
        Me.toolstripgroupFecha.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.toolstripgroupFecha.ForeColor = System.Drawing.Color.MidnightBlue
        Me.toolstripgroupFecha.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripgroupFecha.Image = Nothing
        Me.toolstripgroupFecha.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.comboboxPeriodoTipo, Me.buttonFechaDesdeAnterior, Me.buttonFechaDesdeSiguiente, Me.buttonFechaDesdeHoy, Me.labelFechaY})
        Me.toolstripgroupFecha.Location = New System.Drawing.Point(264, 1)
        Me.toolstripgroupFecha.Name = "toolstripgroupFecha"
        Me.toolstripgroupFecha.ShowLauncher = False
        Me.toolstripgroupFecha.Size = New System.Drawing.Size(165, 70)
        Me.toolstripgroupFecha.TabIndex = 1
        Me.toolstripgroupFecha.Text = "Período"
        '
        'buttonFechaDesdeAnterior
        '
        Me.buttonFechaDesdeAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonFechaDesdeAnterior.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_CALENDAR_PREVIOUS_16
        Me.buttonFechaDesdeAnterior.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFechaDesdeAnterior.Name = "buttonFechaDesdeAnterior"
        Me.buttonFechaDesdeAnterior.Size = New System.Drawing.Size(23, 50)
        Me.buttonFechaDesdeAnterior.ToolTipText = "Día anterior"
        '
        'buttonFechaDesdeSiguiente
        '
        Me.buttonFechaDesdeSiguiente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonFechaDesdeSiguiente.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_CALENDAR_NEXT_16
        Me.buttonFechaDesdeSiguiente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFechaDesdeSiguiente.Name = "buttonFechaDesdeSiguiente"
        Me.buttonFechaDesdeSiguiente.Size = New System.Drawing.Size(23, 50)
        Me.buttonFechaDesdeSiguiente.ToolTipText = "Día siguiente"
        '
        'buttonFechaDesdeHoy
        '
        Me.buttonFechaDesdeHoy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonFechaDesdeHoy.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_CALENDAR_TODAY_16
        Me.buttonFechaDesdeHoy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonFechaDesdeHoy.Name = "buttonFechaDesdeHoy"
        Me.buttonFechaDesdeHoy.Size = New System.Drawing.Size(23, 50)
        Me.buttonFechaDesdeHoy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.buttonFechaDesdeHoy.ToolTipText = "Hoy"
        '
        'ToolStripTabItem2
        '
        Me.ToolStripTabItem2.Name = "ToolStripTabItem2"
        '
        'ribbonMain.RibbonPanel2
        '
        Me.ToolStripTabItem2.Panel.Name = "RibbonPanel2"
        Me.ToolStripTabItem2.Panel.ScrollPosition = 0
        Me.ToolStripTabItem2.Panel.TabIndex = 3
        Me.ToolStripTabItem2.Panel.Text = "ToolStripTabItem2"
        Me.ToolStripTabItem2.Position = 1
        Me.ToolStripTabItem2.Size = New System.Drawing.Size(103, 19)
        Me.ToolStripTabItem2.Tag = "2"
        Me.ToolStripTabItem2.Text = "ToolStripTabItem2"
        '
        'ToolStripTabItem3
        '
        Me.ToolStripTabItem3.Name = "ToolStripTabItem3"
        '
        'ribbonMain.RibbonPanel3
        '
        Me.ToolStripTabItem3.Panel.Name = "RibbonPanel3"
        Me.ToolStripTabItem3.Panel.ScrollPosition = 0
        Me.ToolStripTabItem3.Panel.TabIndex = 4
        Me.ToolStripTabItem3.Panel.Text = "ToolStripTabItem3"
        Me.ToolStripTabItem3.Position = 2
        Me.ToolStripTabItem3.Size = New System.Drawing.Size(103, 19)
        Me.ToolStripTabItem3.Text = "ToolStripTabItem3"
        '
        'ToolStripEx1
        '
        Me.ToolStripEx1.AutoSize = False
        Me.ToolStripEx1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripEx1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx1.Image = Nothing
        Me.ToolStripEx1.Location = New System.Drawing.Point(0, 1)
        Me.ToolStripEx1.Name = "ToolStripEx1"
        Me.ToolStripEx1.Size = New System.Drawing.Size(100, 70)
        Me.ToolStripEx1.TabIndex = 0
        '
        'ToolStripEx2
        '
        Me.ToolStripEx2.AutoSize = False
        Me.ToolStripEx2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStripEx2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ToolStripEx2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.ToolStripEx2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStripEx2.Image = Nothing
        Me.ToolStripEx2.Location = New System.Drawing.Point(102, 1)
        Me.ToolStripEx2.Name = "ToolStripEx2"
        Me.ToolStripEx2.Size = New System.Drawing.Size(100, 70)
        Me.ToolStripEx2.TabIndex = 1
        '
        'comboboxPeriodoTipo
        '
        Me.comboboxPeriodoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxPeriodoTipo.Name = "comboboxPeriodoTipo"
        Me.comboboxPeriodoTipo.Size = New System.Drawing.Size(75, 53)
        '
        'labelFechaY
        '
        Me.labelFechaY.Name = "labelFechaY"
        Me.labelFechaY.Size = New System.Drawing.Size(12, 50)
        Me.labelFechaY.Text = "y"
        '
        'formTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(778, 469)
        Me.Controls.Add(Me.ribbonMain)
        Me.Name = "formTest"
        Me.Text = "Test Form"
        CType(Me.ribbonMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ribbonMain.ResumeLayout(False)
        Me.ribbonMain.PerformLayout()
        Me.toolstriptabMain.Panel.ResumeLayout(False)
        Me.toolstriptabMain.Panel.PerformLayout()
        Me.toolstripgroupMain.ResumeLayout(False)
        Me.toolstripgroupMain.PerformLayout()
        Me.toolstripgroupFecha.ResumeLayout(False)
        Me.toolstripgroupFecha.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ribbonMain As Syncfusion.Windows.Forms.Tools.RibbonControlAdv
    Friend WithEvents toolstriptabMain As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Friend WithEvents toolstripgroupMain As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripTabItem2 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Friend WithEvents ToolStripTabItem3 As Syncfusion.Windows.Forms.Tools.ToolStripTabItem
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripEx1 As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents ToolStripEx2 As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents buttonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents toolstripgroupFecha As Syncfusion.Windows.Forms.Tools.ToolStripEx
    Friend WithEvents buttonFechaDesdeAnterior As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonFechaDesdeSiguiente As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonFechaDesdeHoy As System.Windows.Forms.ToolStripButton
    Friend WithEvents comboboxPeriodoTipo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents labelFechaY As System.Windows.Forms.ToolStripLabel
End Class
