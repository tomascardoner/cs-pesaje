<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEntidades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEntidades))
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
        Me.toolstripBuscar = New System.Windows.Forms.ToolStrip()
        Me.labelBuscar = New System.Windows.Forms.ToolStripLabel()
        Me.textboxBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.buttonBuscarBorrar = New System.Windows.Forms.ToolStripButton()
        Me.toolstripEntidadTipo = New System.Windows.Forms.ToolStrip()
        Me.dropdownbuttonEntidadTipos = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menuitemEntidadTipo_Titular = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemEntidadTipo_Transportista = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemEntidadTipo_Chofer = New System.Windows.Forms.ToolStripMenuItem()
        Me.separatorMarcarTodos = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemMarcarTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemDesmarcarTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstripActivo = New System.Windows.Forms.ToolStrip()
        Me.labelActivo = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxActivo = New System.Windows.Forms.ToolStripComboBox()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.columnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnCUIT_CUIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEsTitular = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.columnEsTransportista = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.columnEsChofer = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.toolstripButtons.SuspendLayout()
        Me.statusstripMain.SuspendLayout()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelToolbars.SuspendLayout()
        Me.toolstripBuscar.SuspendLayout()
        Me.toolstripEntidadTipo.SuspendLayout()
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
        Me.buttonAgregar.Image = Global.My.Resources.Resources.IMAGE_ITEM_ADD_32
        Me.buttonAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonAgregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonAgregar.Name = "buttonAgregar"
        Me.buttonAgregar.Size = New System.Drawing.Size(85, 36)
        Me.buttonAgregar.Text = "Agregar"
        '
        'buttonEditar
        '
        Me.buttonEditar.Image = Global.My.Resources.Resources.IMAGE_ITEM_EDIT_32
        Me.buttonEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEditar.Name = "buttonEditar"
        Me.buttonEditar.Size = New System.Drawing.Size(73, 36)
        Me.buttonEditar.Text = "Editar"
        '
        'buttonEliminar
        '
        Me.buttonEliminar.Image = Global.My.Resources.Resources.IMAGE_ITEM_DELETE_32
        Me.buttonEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonEliminar.Name = "buttonEliminar"
        Me.buttonEliminar.Size = New System.Drawing.Size(86, 36)
        Me.buttonEliminar.Text = "Eliminar"
        '
        'buttonImprimir
        '
        Me.buttonImprimir.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemImprimirListado})
        Me.buttonImprimir.Image = Global.My.Resources.Resources.IMAGE_PRINT_32
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
        Me.panelToolbars.Controls.Add(Me.toolstripBuscar)
        Me.panelToolbars.Controls.Add(Me.toolstripEntidadTipo)
        Me.panelToolbars.Controls.Add(Me.toolstripActivo)
        Me.panelToolbars.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelToolbars.Location = New System.Drawing.Point(0, 0)
        Me.panelToolbars.Name = "panelToolbars"
        Me.panelToolbars.Size = New System.Drawing.Size(905, 39)
        Me.panelToolbars.TabIndex = 2
        '
        'toolstripBuscar
        '
        Me.toolstripBuscar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripBuscar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripBuscar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelBuscar, Me.textboxBuscar, Me.buttonBuscarBorrar})
        Me.toolstripBuscar.Location = New System.Drawing.Point(348, 0)
        Me.toolstripBuscar.Name = "toolstripBuscar"
        Me.toolstripBuscar.Size = New System.Drawing.Size(193, 39)
        Me.toolstripBuscar.TabIndex = 2
        '
        'labelBuscar
        '
        Me.labelBuscar.Name = "labelBuscar"
        Me.labelBuscar.Size = New System.Drawing.Size(45, 36)
        Me.labelBuscar.Text = "Buscar:"
        '
        'textboxBuscar
        '
        Me.textboxBuscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.textboxBuscar.MaxLength = 100
        Me.textboxBuscar.Name = "textboxBuscar"
        Me.textboxBuscar.Size = New System.Drawing.Size(120, 39)
        '
        'buttonBuscarBorrar
        '
        Me.buttonBuscarBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonBuscarBorrar.Image = Global.My.Resources.Resources.IMAGE_CLOSE_16
        Me.buttonBuscarBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonBuscarBorrar.Name = "buttonBuscarBorrar"
        Me.buttonBuscarBorrar.Size = New System.Drawing.Size(23, 36)
        Me.buttonBuscarBorrar.ToolTipText = "Limpiar búsqueda"
        '
        'toolstripEntidadTipo
        '
        Me.toolstripEntidadTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripEntidadTipo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripEntidadTipo.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripEntidadTipo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dropdownbuttonEntidadTipos})
        Me.toolstripEntidadTipo.Location = New System.Drawing.Point(541, 0)
        Me.toolstripEntidadTipo.Name = "toolstripEntidadTipo"
        Me.toolstripEntidadTipo.Size = New System.Drawing.Size(110, 39)
        Me.toolstripEntidadTipo.TabIndex = 4
        '
        'dropdownbuttonEntidadTipos
        '
        Me.dropdownbuttonEntidadTipos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.dropdownbuttonEntidadTipos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemEntidadTipo_Titular, Me.menuitemEntidadTipo_Transportista, Me.menuitemEntidadTipo_Chofer, Me.separatorMarcarTodos, Me.menuitemMarcarTodos, Me.menuitemDesmarcarTodos})
        Me.dropdownbuttonEntidadTipos.Image = CType(resources.GetObject("dropdownbuttonEntidadTipos.Image"), System.Drawing.Image)
        Me.dropdownbuttonEntidadTipos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.dropdownbuttonEntidadTipos.Name = "dropdownbuttonEntidadTipos"
        Me.dropdownbuttonEntidadTipos.Size = New System.Drawing.Size(107, 36)
        Me.dropdownbuttonEntidadTipos.Text = "Tipos de Entidad"
        '
        'menuitemEntidadTipo_Titular
        '
        Me.menuitemEntidadTipo_Titular.Checked = True
        Me.menuitemEntidadTipo_Titular.CheckOnClick = True
        Me.menuitemEntidadTipo_Titular.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuitemEntidadTipo_Titular.Name = "menuitemEntidadTipo_Titular"
        Me.menuitemEntidadTipo_Titular.Size = New System.Drawing.Size(163, 22)
        Me.menuitemEntidadTipo_Titular.Text = "Titular"
        '
        'menuitemEntidadTipo_Transportista
        '
        Me.menuitemEntidadTipo_Transportista.Checked = True
        Me.menuitemEntidadTipo_Transportista.CheckOnClick = True
        Me.menuitemEntidadTipo_Transportista.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuitemEntidadTipo_Transportista.Name = "menuitemEntidadTipo_Transportista"
        Me.menuitemEntidadTipo_Transportista.Size = New System.Drawing.Size(163, 22)
        Me.menuitemEntidadTipo_Transportista.Text = "Transportista"
        '
        'menuitemEntidadTipo_Chofer
        '
        Me.menuitemEntidadTipo_Chofer.Checked = True
        Me.menuitemEntidadTipo_Chofer.CheckOnClick = True
        Me.menuitemEntidadTipo_Chofer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.menuitemEntidadTipo_Chofer.Name = "menuitemEntidadTipo_Chofer"
        Me.menuitemEntidadTipo_Chofer.Size = New System.Drawing.Size(163, 22)
        Me.menuitemEntidadTipo_Chofer.Text = "Chofer"
        '
        'separatorMarcarTodos
        '
        Me.separatorMarcarTodos.Name = "separatorMarcarTodos"
        Me.separatorMarcarTodos.Size = New System.Drawing.Size(160, 6)
        '
        'menuitemMarcarTodos
        '
        Me.menuitemMarcarTodos.Name = "menuitemMarcarTodos"
        Me.menuitemMarcarTodos.Size = New System.Drawing.Size(163, 22)
        Me.menuitemMarcarTodos.Text = "Marcar todos"
        '
        'menuitemDesmarcarTodos
        '
        Me.menuitemDesmarcarTodos.Name = "menuitemDesmarcarTodos"
        Me.menuitemDesmarcarTodos.Size = New System.Drawing.Size(163, 22)
        Me.menuitemDesmarcarTodos.Text = "Desmarcar todos"
        '
        'toolstripActivo
        '
        Me.toolstripActivo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.toolstripActivo.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripActivo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelActivo, Me.comboboxActivo})
        Me.toolstripActivo.Location = New System.Drawing.Point(651, 0)
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
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnNombre, Me.columnCUIT_CUIL, Me.columnEsTitular, Me.columnEsTransportista, Me.columnEsChofer})
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
        'columnCUIT_CUIL
        '
        Me.columnCUIT_CUIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnCUIT_CUIL.DataPropertyName = "CUIT_CUIL"
        Me.columnCUIT_CUIL.HeaderText = "CUIT / CUIL"
        Me.columnCUIT_CUIL.Name = "columnCUIT_CUIL"
        Me.columnCUIT_CUIL.ReadOnly = True
        Me.columnCUIT_CUIL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.columnCUIT_CUIL.Width = 92
        '
        'columnEsTitular
        '
        Me.columnEsTitular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnEsTitular.DataPropertyName = "EsTitular"
        Me.columnEsTitular.HeaderText = "Titular"
        Me.columnEsTitular.Name = "columnEsTitular"
        Me.columnEsTitular.ReadOnly = True
        Me.columnEsTitular.Width = 42
        '
        'columnEsTransportista
        '
        Me.columnEsTransportista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnEsTransportista.DataPropertyName = "EsTransportista"
        Me.columnEsTransportista.HeaderText = "Transportista"
        Me.columnEsTransportista.Name = "columnEsTransportista"
        Me.columnEsTransportista.ReadOnly = True
        Me.columnEsTransportista.Width = 74
        '
        'columnEsChofer
        '
        Me.columnEsChofer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnEsChofer.DataPropertyName = "EsChofer"
        Me.columnEsChofer.HeaderText = "Chofer"
        Me.columnEsChofer.Name = "columnEsChofer"
        Me.columnEsChofer.ReadOnly = True
        Me.columnEsChofer.Width = 44
        '
        'formEntidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 369)
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.panelToolbars)
        Me.Controls.Add(Me.statusstripMain)
        Me.KeyPreview = True
        Me.Name = "formEntidades"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Entidades"
        Me.toolstripButtons.ResumeLayout(False)
        Me.toolstripButtons.PerformLayout()
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelToolbars.ResumeLayout(False)
        Me.panelToolbars.PerformLayout()
        Me.toolstripBuscar.ResumeLayout(False)
        Me.toolstripBuscar.PerformLayout()
        Me.toolstripEntidadTipo.ResumeLayout(False)
        Me.toolstripEntidadTipo.PerformLayout()
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
    Friend WithEvents toolstripBuscar As System.Windows.Forms.ToolStrip
    Friend WithEvents toolstripActivo As System.Windows.Forms.ToolStrip
    Friend WithEvents labelBuscar As System.Windows.Forms.ToolStripLabel
    Friend WithEvents textboxBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents buttonBuscarBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents labelActivo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxActivo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents buttonImprimir As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents menuitemImprimirListado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstripEntidadTipo As System.Windows.Forms.ToolStrip
    Friend WithEvents dropdownbuttonEntidadTipos As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menuitemEntidadTipo_Titular As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemEntidadTipo_Transportista As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemEntidadTipo_Chofer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents separatorMarcarTodos As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemMarcarTodos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemDesmarcarTodos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents datagridviewMain As System.Windows.Forms.DataGridView
    Friend WithEvents columnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnCUIT_CUIL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnEsTitular As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents columnEsTransportista As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents columnEsChofer As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
