﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEntidadesSeleccionar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEntidadesSeleccionar))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.labelBuscar = New System.Windows.Forms.ToolStripLabel()
        Me.textboxBuscar = New System.Windows.Forms.ToolStripTextBox()
        Me.buttonBuscarBorrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.dropdownbuttonEntidadTipos = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menuitemEntidadTipo_Titular = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemEntidadTipo_Transportista = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemEntidadTipo_Chofer = New System.Windows.Forms.ToolStripMenuItem()
        Me.separatorMarcarTodos = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemMarcarTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemDesmarcarTodos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.labelActivo = New System.Windows.Forms.ToolStripLabel()
        Me.comboboxActivo = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.buttonSeleccionar = New System.Windows.Forms.ToolStripButton()
        Me.buttonCancelar = New System.Windows.Forms.ToolStripButton()
        Me.datagridviewMain = New System.Windows.Forms.DataGridView()
        Me.bindingsourceMain = New System.Windows.Forms.BindingSource(Me.components)
        Me.columnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columnEsTitular = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.columnEsTransportista = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.columnChofer = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.toolstripMain.SuspendLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolstripMain
        '
        Me.toolstripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.toolstripMain.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelBuscar, Me.textboxBuscar, Me.buttonBuscarBorrar, Me.ToolStripSeparator3, Me.dropdownbuttonEntidadTipos, Me.ToolStripSeparator4, Me.labelActivo, Me.comboboxActivo, Me.ToolStripSeparator1, Me.buttonSeleccionar, Me.buttonCancelar})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 0)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(655, 39)
        Me.toolstripMain.TabIndex = 1
        '
        'labelBuscar
        '
        Me.labelBuscar.Name = "labelBuscar"
        Me.labelBuscar.Size = New System.Drawing.Size(45, 36)
        Me.labelBuscar.Text = "Buscar:"
        '
        'textboxBuscar
        '
        Me.textboxBuscar.MaxLength = 100
        Me.textboxBuscar.Name = "textboxBuscar"
        Me.textboxBuscar.Size = New System.Drawing.Size(120, 39)
        '
        'buttonBuscarBorrar
        '
        Me.buttonBuscarBorrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.buttonBuscarBorrar.Image = My.Resources.Resources.IMAGE_CLOSE_16
        Me.buttonBuscarBorrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonBuscarBorrar.Name = "buttonBuscarBorrar"
        Me.buttonBuscarBorrar.Size = New System.Drawing.Size(24, 36)
        Me.buttonBuscarBorrar.ToolTipText = "Limpiar búsqueda"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'dropdownbuttonEntidadTipos
        '
        Me.dropdownbuttonEntidadTipos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.dropdownbuttonEntidadTipos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemEntidadTipo_Titular, Me.menuitemEntidadTipo_Transportista, Me.menuitemEntidadTipo_Chofer, Me.separatorMarcarTodos, Me.menuitemMarcarTodos, Me.menuitemDesmarcarTodos})
        Me.dropdownbuttonEntidadTipos.Image = CType(resources.GetObject("dropdownbuttonEntidadTipos.Image"), System.Drawing.Image)
        Me.dropdownbuttonEntidadTipos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.dropdownbuttonEntidadTipos.Name = "dropdownbuttonEntidadTipos"
        Me.dropdownbuttonEntidadTipos.Size = New System.Drawing.Size(108, 36)
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'labelActivo
        '
        Me.labelActivo.Name = "labelActivo"
        Me.labelActivo.Size = New System.Drawing.Size(41, 36)
        Me.labelActivo.Text = "Activo"
        '
        'comboboxActivo
        '
        Me.comboboxActivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboboxActivo.Name = "comboboxActivo"
        Me.comboboxActivo.Size = New System.Drawing.Size(75, 39)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'buttonSeleccionar
        '
        Me.buttonSeleccionar.Image = My.Resources.Resources.IMAGE_OK_32
        Me.buttonSeleccionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonSeleccionar.Name = "buttonSeleccionar"
        Me.buttonSeleccionar.Size = New System.Drawing.Size(103, 36)
        Me.buttonSeleccionar.Text = "Seleccionar"
        '
        'buttonCancelar
        '
        Me.buttonCancelar.Image = My.Resources.Resources.IMAGE_CANCEL_32
        Me.buttonCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonCancelar.Name = "buttonCancelar"
        Me.buttonCancelar.Size = New System.Drawing.Size(89, 36)
        Me.buttonCancelar.Text = "Cancelar"
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
        Me.datagridviewMain.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.columnNombre, Me.columnEsTitular, Me.columnEsTransportista, Me.columnChofer})
        Me.datagridviewMain.DataSource = Me.bindingsourceMain
        Me.datagridviewMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewMain.Location = New System.Drawing.Point(0, 39)
        Me.datagridviewMain.MultiSelect = False
        Me.datagridviewMain.Name = "datagridviewMain"
        Me.datagridviewMain.ReadOnly = True
        Me.datagridviewMain.RowHeadersVisible = False
        Me.datagridviewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.datagridviewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewMain.Size = New System.Drawing.Size(655, 482)
        Me.datagridviewMain.TabIndex = 0
        '
        'columnNombre
        '
        Me.columnNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnNombre.DataPropertyName = "Nombre"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.columnNombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.columnNombre.HeaderText = "Nombre"
        Me.columnNombre.Name = "columnNombre"
        Me.columnNombre.ReadOnly = True
        Me.columnNombre.Width = 69
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
        'columnChofer
        '
        Me.columnChofer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.columnChofer.DataPropertyName = "EsChofer"
        Me.columnChofer.HeaderText = "Chofer"
        Me.columnChofer.Name = "columnChofer"
        Me.columnChofer.ReadOnly = True
        Me.columnChofer.Width = 44
        '
        'formEntidadesSeleccionar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.datagridviewMain)
        Me.Controls.Add(Me.toolstripMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.Name = "formEntidadesSeleccionar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seleccione una Entidad"
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        CType(Me.datagridviewMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingsourceMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents dropdownbuttonEntidadTipos As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menuitemEntidadTipo_Titular As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemEntidadTipo_Transportista As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemEntidadTipo_Chofer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents separatorMarcarTodos As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemMarcarTodos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemDesmarcarTodos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents labelBuscar As System.Windows.Forms.ToolStripLabel
    Friend WithEvents textboxBuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents buttonBuscarBorrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents labelActivo As System.Windows.Forms.ToolStripLabel
    Friend WithEvents comboboxActivo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents datagridviewMain As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents buttonCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonSeleccionar As System.Windows.Forms.ToolStripButton
    Friend WithEvents bindingsourceMain As System.Windows.Forms.BindingSource
    Friend WithEvents columnNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columnEsTitular As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents columnEsTransportista As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents columnChofer As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
