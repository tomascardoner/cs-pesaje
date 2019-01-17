<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formTarifas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.toolstripButtons = New System.Windows.Forms.ToolStrip()
        Me.buttonAgregar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEditar = New System.Windows.Forms.ToolStripButton()
        Me.buttonEliminar = New System.Windows.Forms.ToolStripButton()
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.statuslabelMain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.bindingsourceMain = New System.Windows.Forms.BindingSource(Me.components)
        Me.panelToolbars = New System.Windows.Forms.FlowLayoutPanel()
        Me.toolstripCosecha = New System.Windows.Forms.ToolStrip()
        Me.labelCosecha = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxCosecha = New System.Windows.Forms.ToolStripComboBox()
        Me.toolstripProducto = New System.Windows.Forms.ToolStrip()
        Me.labelProducto = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxProducto = New System.Windows.Forms.ToolStripComboBox()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.columnCosecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnIndice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnPlanta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnOrigen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.toolstripButtons.SuspendLayout()
        Me.statusstripMain.SuspendLayout()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelToolbars.SuspendLayout()
        Me.toolstripCosecha.SuspendLayout()
        Me.toolstripProducto.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstripButtons
        '
        Me.toolstripButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripButtons.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripButtons.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.buttonAgregar, Me.buttonEditar, Me.buttonEliminar})
        Me.toolstripButtons.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.toolstripButtons.Location = New System.Drawing.Point(0, 0)
        Me.toolstripButtons.Name = "toolstripButtons"
        Me.toolstripButtons.Size = New System.Drawing.Size(247, 39)
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
        Me.panelToolbars.Controls.Add(Me.toolstripCosecha)
        Me.panelToolbars.Controls.Add(Me.toolstripProducto)
        Me.panelToolbars.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelToolbars.Location = New System.Drawing.Point(0, 0)
        Me.panelToolbars.Name = "panelToolbars"
        Me.panelToolbars.Size = New System.Drawing.Size(905, 39)
        Me.panelToolbars.TabIndex = 2
        '
        'toolstripCosecha
        '
        Me.toolstripCosecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripCosecha.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripCosecha.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelCosecha, Me.comboboxCosecha})
        Me.toolstripCosecha.Location = New System.Drawing.Point(247, 0)
        Me.toolstripCosecha.Name = "toolstripCosecha"
        Me.toolstripCosecha.Size = New System.Drawing.Size(193, 39)
        Me.toolstripCosecha.TabIndex = 3
        '
        'labelCosecha
        '
        Me.labelCosecha.Name = "labelCosecha"
        Me.labelCosecha.Size = New System.Drawing.Size(55, 36)
        Me.labelCosecha.Text = "Cosecha:"
        '
        'comboboxCosecha
        '
        Me.comboboxCosecha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxCosecha.Name = "comboboxCosecha"
        Me.comboboxCosecha.Size = New System.Drawing.Size(100, 39)
        '
        'toolstripProducto
        '
        Me.toolstripProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripProducto.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripProducto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelProducto, Me.comboboxProducto})
        Me.toolstripProducto.Location = New System.Drawing.Point(440, 0)
        Me.toolstripProducto.Name = "toolstripProducto"
        Me.toolstripProducto.Size = New System.Drawing.Size(184, 39)
        Me.toolstripProducto.TabIndex = 4
        '
        'labelProducto
        '
        Me.labelProducto.Name = "labelProducto"
        Me.labelProducto.Size = New System.Drawing.Size(59, 36)
        Me.labelProducto.Text = "Producto:"
        '
        'comboboxProducto
        '
        Me.comboboxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxProducto.Name = "comboboxProducto"
        Me.comboboxProducto.Size = New System.Drawing.Size(120, 39)
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
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnCosecha, Me.columnProducto, Me.columnIndice, Me.columnPlanta, Me.columnEntidad, Me.columnOrigen, Me.columnNombre})
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
        'columnCosecha
        '
        Me.columnCosecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnCosecha.DataPropertyName = "CosechaNombre"
        Me.columnCosecha.HeaderText = "Cosecha"
        Me.columnCosecha.Name = "columnCosecha"
        Me.columnCosecha.ReadOnly = True
        Me.columnCosecha.Width = 74
        '
        'columnProducto
        '
        Me.columnProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnProducto.DataPropertyName = "ProductoNombre"
        Me.columnProducto.HeaderText = "Producto"
        Me.columnProducto.Name = "columnProducto"
        Me.columnProducto.ReadOnly = True
        Me.columnProducto.Width = 75
        '
        'columnIndice
        '
        Me.columnIndice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnIndice.DataPropertyName = "Indice"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.columnIndice.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnIndice.HeaderText = "Indice"
        Me.columnIndice.Name = "columnIndice"
        Me.columnIndice.ReadOnly = True
        Me.columnIndice.Width = 61
        '
        'columnPlanta
        '
        Me.columnPlanta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnPlanta.DataPropertyName = "PlantaNombre"
        Me.columnPlanta.HeaderText = "Planta"
        Me.columnPlanta.Name = "columnPlanta"
        Me.columnPlanta.ReadOnly = True
        Me.columnPlanta.Width = 62
        '
        'columnEntidad
        '
        Me.columnEntidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnEntidad.DataPropertyName = "EntidadNombre"
        Me.columnEntidad.HeaderText = "Entidad"
        Me.columnEntidad.Name = "columnEntidad"
        Me.columnEntidad.ReadOnly = True
        Me.columnEntidad.Width = 68
        '
        'columnOrigen
        '
        Me.columnOrigen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnOrigen.DataPropertyName = "OrigenNombre"
        Me.columnOrigen.HeaderText = "Origen"
        Me.columnOrigen.Name = "columnOrigen"
        Me.columnOrigen.ReadOnly = True
        Me.columnOrigen.Width = 63
        '
        'columnNombre
        '
        Me.columnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnNombre.DataPropertyName = "Nombre"
        Me.columnNombre.HeaderText = "Nombre"
        Me.columnNombre.Name = "columnNombre"
        Me.columnNombre.ReadOnly = True
        Me.columnNombre.Width = 69
        '
        'formTarifas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 369)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.panelToolbars)
        Me.Controls.Add(Me.statusstripMain)
        Me.KeyPreview = True
        Me.Name = "formTarifas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Tarifas"
        Me.toolstripButtons.ResumeLayout(False)
        Me.toolstripButtons.PerformLayout()
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelToolbars.ResumeLayout(False)
        Me.panelToolbars.PerformLayout()
        Me.toolstripCosecha.ResumeLayout(False)
        Me.toolstripCosecha.PerformLayout()
        Me.toolstripProducto.ResumeLayout(False)
        Me.toolstripProducto.PerformLayout()
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
    Friend WithEvents toolstripCosecha As System.Windows.Forms.ToolStrip
    Friend WithEvents labelCosecha As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxCosecha As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents datagridviewMain As System.Windows.Forms.DataGridView
    Friend WithEvents toolstripProducto As ToolStrip
    Friend WithEvents labelProducto As ToolStripLabel
    Friend WithEvents comboboxProducto As ToolStripComboBox
    Friend WithEvents columnCosecha As DataGridViewTextBoxColumn
    Friend WithEvents columnProducto As DataGridViewTextBoxColumn
    Friend WithEvents columnIndice As DataGridViewTextBoxColumn
    Friend WithEvents columnPlanta As DataGridViewTextBoxColumn
    Friend WithEvents columnEntidad As DataGridViewTextBoxColumn
    Friend WithEvents columnOrigen As DataGridViewTextBoxColumn
    Friend WithEvents columnNombre As DataGridViewTextBoxColumn
End Class
