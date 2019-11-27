<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCamiones
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.toolstripButtons = New System.Windows.Forms.ToolStrip()
        Me.buttonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.buttonImprimir = New System.Windows.Forms.ToolStripSplitButton()
        Me.menuitemImprimirListado = New System.Windows.Forms.ToolStripMenuItem()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bindingsourceMain = New System.Windows.Forms.BindingSource(Me.components)
        Me.panelToolbars = New System.Windows.Forms.FlowLayoutPanel()
        Me.toolstripTransportista = New System.Windows.Forms.ToolStrip()
        Me.labelTransportista = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxTransportista = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripActivo = New System.Windows.Forms.ToolStrip()
        Me.labelActivo = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxActivo = New System.Windows.Forms.ToolStripComboBox()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.columnTransportista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDominioChasis = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnDominioAcoplado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEsActivo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.toolstripButtons.SuspendLayout()
        Me.statusstripMain.SuspendLayout()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelToolbars.SuspendLayout()
        Me.toolstripTransportista.SuspendLayout()
        Me.toolstripActivo.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstripButtons
        '
        Me.toolstripButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripButtons.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAgregar, Me.buttonEditar, Me.buttonEliminar, Me.buttonImprimir})
        Me.toolstripButtons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.toolstripButtons.Location = New System.Drawing.Point(0, 0)
        Me.toolstripButtons.Name = "toolstripButtons"
        Me.toolstripButtons.Size = New System.Drawing.Size(348, 39)
        Me.toolstripButtons.TabIndex = 0
        '
        'buttonAgregar
        '
        Me.buttonAgregar.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAgregar.Name = "buttonAgregar"
        Me.buttonAgregar.Size = New System.Drawing.Size(85, 36)
        Me.buttonAgregar.Text = "Agregar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(86, 36)
        Me.buttonEliminar.Text = "Eliminar"
        '
        'buttonImprimir
        '
        Me.buttonImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemImprimirListado})
        Me.buttonImprimir.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_PRINT_32
        Me.buttonImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonImprimir.Name = "buttonImprimir"
        Me.buttonImprimir.Size = New System.Drawing.Size(101, 36)
        Me.buttonImprimir.Text = "Imprimir"
        '
        'menuitemImprimirListado
        '
        Me.menuitemImprimirListado.Name = "menuitemImprimirListado"
        Me.menuitemImprimirListado.Size = New System.Drawing.Size(112, 22)
        Me.menuitemImprimirListado.Text = "Listado"
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statuslabelMain})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 347)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(905, 22)
        Me.statusstripMain.TabIndex = 1
        '
        'statuslabelMain
        '
        Me.statuslabelMain.Name = "statuslabelMain"
        Me.statuslabelMain.Size = New System.Drawing.Size(890, 17)
        Me.statuslabelMain.Spring = True
        Me.statuslabelMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panelToolbars
        '
        Me.panelToolbars.AutoSize = True
        Me.panelToolbars.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panelToolbars.Controls.Add(Me.toolstripButtons)
        Me.panelToolbars.Controls.Add(Me.toolstripTransportista)
        Me.panelToolbars.Controls.Add(Me.toolstripActivo)
        Me.panelToolbars.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelToolbars.Location = New System.Drawing.Point(0, 0)
        Me.panelToolbars.Name = "panelToolbars"
        Me.panelToolbars.Size = New System.Drawing.Size(905, 39)
        Me.panelToolbars.TabIndex = 2
        '
        'toolstripTransportista
        '
        Me.toolstripTransportista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripTransportista.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripTransportista.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripTransportista.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelTransportista, Me.comboboxTransportista})
        Me.toolstripTransportista.Location = New System.Drawing.Point(348, 0)
        Me.toolstripTransportista.Name = "toolstripTransportista"
        Me.toolstripTransportista.Size = New System.Drawing.Size(283, 39)
        Me.toolstripTransportista.TabIndex = 4
        '
        'labelTransportista
        '
        Me.labelTransportista.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.labelTransportista.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.labelTransportista.Name = "labelTransportista"
        Me.labelTransportista.Size = New System.Drawing.Size(78, 36)
        Me.labelTransportista.Text = "Transportista:"
        '
        'comboboxTransportista
        '
        Me.comboboxTransportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxTransportista.Name = "comboboxTransportista"
        Me.comboboxTransportista.Size = New System.Drawing.Size(200, 39)
        '
        'toolstripActivo
        '
        Me.toolstripActivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripActivo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripActivo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelActivo, Me.comboboxActivo})
        Me.toolstripActivo.Location = New System.Drawing.Point(631, 0)
        Me.toolstripActivo.Name = "toolstripActivo"
        Me.toolstripActivo.Size = New System.Drawing.Size(124, 39)
        Me.toolstripActivo.TabIndex = 3
        '
        'labelActivo
        '
        Me.labelActivo.Name = "labelActivo"
        Me.labelActivo.Size = New System.Drawing.Size(44, 36)
        Me.labelActivo.Text = "Activo:"
        '
        'comboboxActivo
        '
        Me.comboboxActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxActivo.Name = "comboboxActivo"
        Me.comboboxActivo.Size = New System.Drawing.Size(75, 39)
        '
        'datagridviewMain
        '
        Me.datagridviewMain.AllowUserToAddRows = False
        Me.datagridviewMain.AllowUserToDeleteRows = False
        Me.datagridviewMain.AllowUserToOrderColumns = True
        Me.datagridviewMain.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText
        Me.datagridviewMain.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.datagridviewMain.AutoGenerateColumns = False
        Me.datagridviewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnTransportista, Me.columnNombre, Me.columnDominioChasis, Me.columnDominioAcoplado, Me.columnEsActivo})
        Me.datagridviewMain.DataSource = Me.bindingsourceMain
        Me.datagridviewMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewMain.Location = New System.Drawing.Point(0, 39)
        Me.datagridviewMain.MultiSelect = False
        Me.datagridviewMain.Name = "datagridviewMain"
        Me.datagridviewMain.ReadOnly = True
        Me.datagridviewMain.RowHeadersVisible = False
        Me.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMain.Size = New System.Drawing.Size(905, 308)
        Me.datagridviewMain.TabIndex = 3
        '
        'columnTransportista
        '
        Me.columnTransportista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnTransportista.DataPropertyName = "TransportistaNombre"
        Me.columnTransportista.HeaderText = "Transportista"
        Me.columnTransportista.Name = "columnTransportista"
        Me.columnTransportista.ReadOnly = True
        Me.columnTransportista.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.columnTransportista.Width = 93
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
        'columnDominioChasis
        '
        Me.columnDominioChasis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnDominioChasis.DataPropertyName = "DominioChasis"
        Me.columnDominioChasis.HeaderText = "Chasis"
        Me.columnDominioChasis.Name = "columnDominioChasis"
        Me.columnDominioChasis.ReadOnly = True
        Me.columnDominioChasis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.columnDominioChasis.Width = 63
        '
        'columnDominioAcoplado
        '
        Me.columnDominioAcoplado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnDominioAcoplado.DataPropertyName = "DominioAcoplado"
        Me.columnDominioAcoplado.HeaderText = "Acoplado"
        Me.columnDominioAcoplado.Name = "columnDominioAcoplado"
        Me.columnDominioAcoplado.ReadOnly = True
        Me.columnDominioAcoplado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.columnDominioAcoplado.Width = 77
        '
        'columnEsActivo
        '
        Me.columnEsActivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnEsActivo.DataPropertyName = "EsActivo"
        Me.columnEsActivo.HeaderText = "Activo"
        Me.columnEsActivo.Name = "columnEsActivo"
        Me.columnEsActivo.ReadOnly = True
        Me.columnEsActivo.Width = 43
        '
        'formCamiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 369)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.panelToolbars)
        Me.Controls.Add(Me.statusstripMain)
        Me.KeyPreview = True
        Me.Name = "formCamiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Camiones"
        Me.toolstripButtons.ResumeLayout(False)
        Me.toolstripButtons.PerformLayout()
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelToolbars.ResumeLayout(False)
        Me.panelToolbars.PerformLayout()
        Me.toolstripTransportista.ResumeLayout(False)
        Me.toolstripTransportista.PerformLayout()
        Me.toolstripActivo.ResumeLayout(False)
        Me.toolstripActivo.PerformLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripButtons As System.Windows.Forms.ToolStrip
    Friend WithEvents buttonAgregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents statusstripMain As System.Windows.Forms.StatusStrip
    Friend WithEvents statuslabelMain As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents bindingsourceMain As System.Windows.Forms.BindingSource
    Friend WithEvents panelToolbars As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents toolstripActivo As System.Windows.Forms.ToolStrip
    Friend WithEvents labelActivo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxActivo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents buttonImprimir As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents menuitemImprimirListado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstripTransportista As System.Windows.Forms.ToolStrip
    Friend WithEvents datagridviewMain As System.Windows.Forms.DataGridView
    Friend WithEvents labelTransportista As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxTransportista As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents columnTransportista As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnDominioChasis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnDominioAcoplado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnEsActivo As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
