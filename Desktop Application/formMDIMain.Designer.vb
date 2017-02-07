<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMDIMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMDIMain))
        Me.statusstripMain = New System.Windows.Forms.StatusStrip()
        Me.labelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelUsuarioNombre = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menustripMain = New System.Windows.Forms.MenuStrip()
        Me.menuitemArchivo = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemArchivo_Opciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemArchivo_Separador_CerrarSesion = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemArchivo_CerrarSesion = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemArchivo_Separador_Salir = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemArchivo_Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemDebug = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemDebug_ShowTestForm = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentana = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentana_MosaicoHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentana_MosaicoVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentana_Cascada = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentana_OrganizarIconos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentana_SeparadorCerrarTodas = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemVentana_CerrarTodas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentana_EncajarEnVentana = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemVentana_SeparadorListaVentanas = New System.Windows.Forms.ToolStripSeparator()
        Me.menuitemAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemAyuda_AcercaDe = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolstripMain = New System.Windows.Forms.ToolStrip()
        Me.dropdownbuttonTablas = New System.Windows.Forms.ToolStripDropDownButton()
        Me.menutitemTablas_Entidades = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_Productos = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_Cosechas = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_GruposUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_Usuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuitemTablas_Permisos = New System.Windows.Forms.ToolStripMenuItem()
        Me.buttonPesadas = New System.Windows.Forms.ToolStripButton()
        Me.buttonReportes = New System.Windows.Forms.ToolStripButton()
        Me.statusstripMain.SuspendLayout()
        Me.menustripMain.SuspendLayout()
        Me.toolstripMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'statusstripMain
        '
        Me.statusstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.labelStatus, Me.labelUsuarioNombre})
        Me.statusstripMain.Location = New System.Drawing.Point(0, 513)
        Me.statusstripMain.Name = "statusstripMain"
        Me.statusstripMain.Size = New System.Drawing.Size(928, 22)
        Me.statusstripMain.TabIndex = 2
        '
        'labelStatus
        '
        Me.labelStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right
        Me.labelStatus.Name = "labelStatus"
        Me.labelStatus.Size = New System.Drawing.Size(913, 17)
        Me.labelStatus.Spring = True
        '
        'labelUsuarioNombre
        '
        Me.labelUsuarioNombre.Name = "labelUsuarioNombre"
        Me.labelUsuarioNombre.Size = New System.Drawing.Size(0, 17)
        '
        'menustripMain
        '
        Me.menustripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemArchivo, Me.menuitemVentana, Me.menuitemDebug, Me.menuitemAyuda})
        Me.menustripMain.Location = New System.Drawing.Point(0, 0)
        Me.menustripMain.MdiWindowListItem = Me.menuitemVentana
        Me.menustripMain.Name = "menustripMain"
        Me.menustripMain.Size = New System.Drawing.Size(928, 24)
        Me.menustripMain.TabIndex = 0
        '
        'menuitemArchivo
        '
        Me.menuitemArchivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemArchivo_Opciones, Me.menuitemArchivo_Separador_CerrarSesion, Me.menuitemArchivo_CerrarSesion, Me.menuitemArchivo_Separador_Salir, Me.menuitemArchivo_Salir})
        Me.menuitemArchivo.Name = "menuitemArchivo"
        Me.menuitemArchivo.Size = New System.Drawing.Size(60, 20)
        Me.menuitemArchivo.Text = "&Archivo"
        '
        'menuitemArchivo_Opciones
        '
        Me.menuitemArchivo_Opciones.Name = "menuitemArchivo_Opciones"
        Me.menuitemArchivo_Opciones.Size = New System.Drawing.Size(204, 22)
        Me.menuitemArchivo_Opciones.Text = "Opciones"
        '
        'menuitemArchivo_Separador_CerrarSesion
        '
        Me.menuitemArchivo_Separador_CerrarSesion.Name = "menuitemArchivo_Separador_CerrarSesion"
        Me.menuitemArchivo_Separador_CerrarSesion.Size = New System.Drawing.Size(201, 6)
        '
        'menuitemArchivo_CerrarSesion
        '
        Me.menuitemArchivo_CerrarSesion.Name = "menuitemArchivo_CerrarSesion"
        Me.menuitemArchivo_CerrarSesion.Size = New System.Drawing.Size(204, 22)
        Me.menuitemArchivo_CerrarSesion.Text = "Cerrar sesión del Usuario"
        '
        'menuitemArchivo_Separador_Salir
        '
        Me.menuitemArchivo_Separador_Salir.Name = "menuitemArchivo_Separador_Salir"
        Me.menuitemArchivo_Separador_Salir.Size = New System.Drawing.Size(201, 6)
        '
        'menuitemArchivo_Salir
        '
        Me.menuitemArchivo_Salir.Name = "menuitemArchivo_Salir"
        Me.menuitemArchivo_Salir.Size = New System.Drawing.Size(204, 22)
        Me.menuitemArchivo_Salir.Text = "&Salir"
        '
        'menuitemDebug
        '
        Me.menuitemDebug.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemDebug_ShowTestForm})
        Me.menuitemDebug.Name = "menuitemDebug"
        Me.menuitemDebug.Size = New System.Drawing.Size(54, 20)
        Me.menuitemDebug.Text = "Debug"
        Me.menuitemDebug.Visible = False
        '
        'menuitemDebug_ShowTestForm
        '
        Me.menuitemDebug_ShowTestForm.Name = "menuitemDebug_ShowTestForm"
        Me.menuitemDebug_ShowTestForm.Size = New System.Drawing.Size(217, 22)
        Me.menuitemDebug_ShowTestForm.Text = "Mostrar ventana de Testing"
        '
        'menuitemVentana
        '
        Me.menuitemVentana.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemVentana_MosaicoHorizontal, Me.menuitemVentana_MosaicoVertical, Me.menuitemVentana_Cascada, Me.menuitemVentana_OrganizarIconos, Me.menuitemVentana_SeparadorCerrarTodas, Me.menuitemVentana_CerrarTodas, Me.menuitemVentana_EncajarEnVentana, Me.menuitemVentana_SeparadorListaVentanas})
        Me.menuitemVentana.Name = "menuitemVentana"
        Me.menuitemVentana.Size = New System.Drawing.Size(61, 20)
        Me.menuitemVentana.Text = "&Ventana"
        '
        'menuitemVentana_MosaicoHorizontal
        '
        Me.menuitemVentana_MosaicoHorizontal.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_MENU_WINDOW_TILE_HORIZONTALLY
        Me.menuitemVentana_MosaicoHorizontal.Name = "menuitemVentana_MosaicoHorizontal"
        Me.menuitemVentana_MosaicoHorizontal.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentana_MosaicoHorizontal.Text = "Mosaico &Horizontal"
        '
        'menuitemVentana_MosaicoVertical
        '
        Me.menuitemVentana_MosaicoVertical.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_MENU_WINDOW_TILE_VERTICALLY
        Me.menuitemVentana_MosaicoVertical.Name = "menuitemVentana_MosaicoVertical"
        Me.menuitemVentana_MosaicoVertical.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentana_MosaicoVertical.Text = "Mosaico &Vertical"
        '
        'menuitemVentana_Cascada
        '
        Me.menuitemVentana_Cascada.Name = "menuitemVentana_Cascada"
        Me.menuitemVentana_Cascada.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentana_Cascada.Text = "&Cascada"
        '
        'menuitemVentana_OrganizarIconos
        '
        Me.menuitemVentana_OrganizarIconos.Name = "menuitemVentana_OrganizarIconos"
        Me.menuitemVentana_OrganizarIconos.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentana_OrganizarIconos.Text = "&Organizar Iconos"
        '
        'menuitemVentana_SeparadorCerrarTodas
        '
        Me.menuitemVentana_SeparadorCerrarTodas.Name = "menuitemVentana_SeparadorCerrarTodas"
        Me.menuitemVentana_SeparadorCerrarTodas.Size = New System.Drawing.Size(174, 6)
        '
        'menuitemVentana_CerrarTodas
        '
        Me.menuitemVentana_CerrarTodas.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_MENU_WINDOW_CLOSE_ALL
        Me.menuitemVentana_CerrarTodas.Name = "menuitemVentana_CerrarTodas"
        Me.menuitemVentana_CerrarTodas.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentana_CerrarTodas.Text = "Cerrar todas"
        '
        'menuitemVentana_EncajarEnVentana
        '
        Me.menuitemVentana_EncajarEnVentana.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_MENU_WINDOW_FIT_SIZE
        Me.menuitemVentana_EncajarEnVentana.Name = "menuitemVentana_EncajarEnVentana"
        Me.menuitemVentana_EncajarEnVentana.Size = New System.Drawing.Size(177, 22)
        Me.menuitemVentana_EncajarEnVentana.Text = "Encajar en ventana"
        '
        'menuitemVentana_SeparadorListaVentanas
        '
        Me.menuitemVentana_SeparadorListaVentanas.Name = "menuitemVentana_SeparadorListaVentanas"
        Me.menuitemVentana_SeparadorListaVentanas.Size = New System.Drawing.Size(174, 6)
        '
        'menuitemAyuda
        '
        Me.menuitemAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuitemAyuda_AcercaDe})
        Me.menuitemAyuda.Name = "menuitemAyuda"
        Me.menuitemAyuda.Size = New System.Drawing.Size(53, 20)
        Me.menuitemAyuda.Text = "A&yuda"
        '
        'menuitemAyuda_AcercaDe
        '
        Me.menuitemAyuda_AcercaDe.Name = "menuitemAyuda_AcercaDe"
        Me.menuitemAyuda_AcercaDe.Size = New System.Drawing.Size(135, 22)
        Me.menuitemAyuda_AcercaDe.Text = "&Acerca de..."
        '
        'toolstripMain
        '
        Me.toolstripMain.AllowMerge = False
        Me.toolstripMain.Dock = System.Windows.Forms.DockStyle.Left
        Me.toolstripMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dropdownbuttonTablas, Me.buttonPesadas, Me.buttonReportes})
        Me.toolstripMain.Location = New System.Drawing.Point(0, 24)
        Me.toolstripMain.Name = "toolstripMain"
        Me.toolstripMain.Size = New System.Drawing.Size(90, 489)
        Me.toolstripMain.TabIndex = 1
        Me.toolstripMain.Text = "Principal"
        '
        'dropdownbuttonTablas
        '
        Me.dropdownbuttonTablas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menutitemTablas_Entidades, Me.menuitemTablas_Productos, Me.menuitemTablas_Cosechas, Me.menuitemTablas_GruposUsuarios, Me.menuitemTablas_Usuarios, Me.menuitemTablas_Permisos})
        Me.dropdownbuttonTablas.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_TABLAS_32
        Me.dropdownbuttonTablas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dropdownbuttonTablas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.dropdownbuttonTablas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.dropdownbuttonTablas.Name = "dropdownbuttonTablas"
        Me.dropdownbuttonTablas.Size = New System.Drawing.Size(87, 36)
        Me.dropdownbuttonTablas.Text = "Tablas"
        '
        'menutitemTablas_Entidades
        '
        Me.menutitemTablas_Entidades.Name = "menutitemTablas_Entidades"
        Me.menutitemTablas_Entidades.Size = New System.Drawing.Size(176, 22)
        Me.menutitemTablas_Entidades.Text = "Entidades"
        '
        'menuitemTablas_Productos
        '
        Me.menuitemTablas_Productos.Name = "menuitemTablas_Productos"
        Me.menuitemTablas_Productos.Size = New System.Drawing.Size(176, 22)
        Me.menuitemTablas_Productos.Text = "Productos"
        '
        'menuitemTablas_Cosechas
        '
        Me.menuitemTablas_Cosechas.Name = "menuitemTablas_Cosechas"
        Me.menuitemTablas_Cosechas.Size = New System.Drawing.Size(176, 22)
        Me.menuitemTablas_Cosechas.Text = "Cosechas"
        '
        'menuitemTablas_GruposUsuarios
        '
        Me.menuitemTablas_GruposUsuarios.Name = "menuitemTablas_GruposUsuarios"
        Me.menuitemTablas_GruposUsuarios.Size = New System.Drawing.Size(176, 22)
        Me.menuitemTablas_GruposUsuarios.Text = "Grupos de Usuarios"
        '
        'menuitemTablas_Usuarios
        '
        Me.menuitemTablas_Usuarios.Name = "menuitemTablas_Usuarios"
        Me.menuitemTablas_Usuarios.Size = New System.Drawing.Size(176, 22)
        Me.menuitemTablas_Usuarios.Text = "Usuarios"
        '
        'menuitemTablas_Permisos
        '
        Me.menuitemTablas_Permisos.Name = "menuitemTablas_Permisos"
        Me.menuitemTablas_Permisos.Size = New System.Drawing.Size(176, 22)
        Me.menuitemTablas_Permisos.Text = "Permisos"
        '
        'buttonPesadas
        '
        Me.buttonPesadas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonPesadas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonPesadas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonPesadas.Name = "buttonPesadas"
        Me.buttonPesadas.Size = New System.Drawing.Size(87, 19)
        Me.buttonPesadas.Text = "Pesadas"
        '
        'buttonReportes
        '
        Me.buttonReportes.Image = Global.CSPesaje.DesktopApplication.My.Resources.Resources.IMAGE_REPORTES_32
        Me.buttonReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.buttonReportes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.buttonReportes.Name = "buttonReportes"
        Me.buttonReportes.Size = New System.Drawing.Size(87, 36)
        Me.buttonReportes.Text = "Reportes"
        '
        'formMDIMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(928, 535)
        Me.Controls.Add(Me.toolstripMain)
        Me.Controls.Add(Me.statusstripMain)
        Me.Controls.Add(Me.menustripMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.menustripMain
        Me.Name = "formMDIMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Title"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.statusstripMain.ResumeLayout(False)
        Me.statusstripMain.PerformLayout()
        Me.menustripMain.ResumeLayout(False)
        Me.menustripMain.PerformLayout()
        Me.toolstripMain.ResumeLayout(False)
        Me.toolstripMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents statusstripMain As System.Windows.Forms.StatusStrip
    Friend WithEvents labelUsuarioNombre As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents labelStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents menustripMain As System.Windows.Forms.MenuStrip
    Friend WithEvents menuitemArchivo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemArchivo_Opciones As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemArchivo_Separador_CerrarSesion As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemArchivo_CerrarSesion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemArchivo_Separador_Salir As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemArchivo_Salir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentana As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentana_MosaicoHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentana_MosaicoVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentana_Cascada As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentana_OrganizarIconos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentana_SeparadorCerrarTodas As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemVentana_CerrarTodas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentana_EncajarEnVentana As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemAyuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemAyuda_AcercaDe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolstripMain As System.Windows.Forms.ToolStrip
    Friend WithEvents dropdownbuttonTablas As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents menuitemTablas_Productos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemVentana_SeparadorListaVentanas As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuitemDebug As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents buttonReportes As System.Windows.Forms.ToolStripButton
    Friend WithEvents buttonPesadas As System.Windows.Forms.ToolStripButton
    Friend WithEvents menuitemTablas_Cosechas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_Permisos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_GruposUsuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemTablas_Usuarios As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menutitemTablas_Entidades As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuitemDebug_ShowTestForm As System.Windows.Forms.ToolStripMenuItem
End Class
