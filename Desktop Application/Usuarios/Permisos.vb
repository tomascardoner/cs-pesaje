Module Permisos

#Region "Definición de constantes"

    Friend Const USUARIOGRUPO As String = "USUARIOGRUPO"
    Friend Const USUARIOGRUPO_AGREGAR As String = "USUARIOGRUPO_AGREGAR"
    Friend Const USUARIOGRUPO_EDITAR As String = "USUARIOGRUPO_EDITAR"
    Friend Const USUARIOGRUPO_ELIMINAR As String = "USUARIOGRUPO_ELIMINAR"
    Friend Const USUARIOGRUPO_PERMISOS As String = "USUARIOGRUPO_PERMISOS"

    Friend Const USUARIO As String = "USUARIO"
    Friend Const USUARIO_AGREGAR As String = "USUARIO_AGREGAR"
    Friend Const USUARIO_EDITAR As String = "USUARIO_EDITAR"
    Friend Const USUARIO_ELIMINAR As String = "USUARIO_ELIMINAR"

    Friend Const ENTIDAD As String = "ENTIDAD"
    Friend Const ENTIDAD_AGREGAR As String = "ENTIDAD_AGREGAR"
    Friend Const ENTIDAD_EDITAR As String = "ENTIDAD_EDITAR"
    Friend Const ENTIDAD_ELIMINAR As String = "ENTIDAD_ELIMINAR"
    Friend Const ENTIDAD_IMPRIMIR As String = "ENTIDAD_IMPRIMIR"

    Friend Const CAMION As String = "CAMION"
    Friend Const CAMION_AGREGAR As String = "CAMION_AGREGAR"
    Friend Const CAMION_EDITAR As String = "CAMION_EDITAR"
    Friend Const CAMION_ELIMINAR As String = "CAMION_ELIMINAR"
    Friend Const CAMION_IMPRIMIR As String = "CAMION_IMPRIMIR"

    Friend Const ORIGENDESTINO As String = "ORIGENDESTINO"
    Friend Const ORIGENDESTINO_AGREGAR As String = "ORIGENDESTINO_AGREGAR"
    Friend Const ORIGENDESTINO_EDITAR As String = "ORIGENDESTINO_EDITAR"
    Friend Const ORIGENDESTINO_ELIMINAR As String = "ORIGENDESTINO_ELIMINAR"
    Friend Const ORIGENDESTINO_IMPRIMIR As String = "ORIGENDESTINO_IMPRIMIR"

    Friend Const PRODUCTO As String = "PRODUCTO"
    Friend Const PRODUCTO_AGREGAR As String = "PRODUCTO_AGREGAR"
    Friend Const PRODUCTO_EDITAR As String = "PRODUCTO_EDITAR"
    Friend Const PRODUCTO_ELIMINAR As String = "PRODUCTO_ELIMINAR"

    Friend Const PRODUCTOMERMAHUMEDAD As String = "PRODUCTOMERMAHUMEDAD"
    Friend Const PRODUCTOMERMAHUMEDAD_AGREGAR As String = "PRODUCTOMERMAHUMEDAD_AGREGAR"
    Friend Const PRODUCTOMERMAHUMEDAD_EDITAR As String = "PRODUCTOMERMAHUMEDAD_EDITAR"
    Friend Const PRODUCTOMERMAHUMEDAD_ELIMINAR As String = "PRODUCTOMERMAHUMEDAD_ELIMINAR"

    Friend Const PRODUCTOPLANTA As String = "PRODUCTOPLANTA"
    Friend Const PRODUCTOPLANTA_AGREGAR As String = "PRODUCTOPLANTA_AGREGAR"
    Friend Const PRODUCTOPLANTA_EDITAR As String = "PRODUCTOPLANTA_EDITAR"
    Friend Const PRODUCTOPLANTA_ELIMINAR As String = "PRODUCTOPLANTA_ELIMINAR"

    Friend Const PRODUCTOCOSECHA As String = "PRODUCTOCOSECHA"
    Friend Const PRODUCTOCOSECHA_AGREGAR As String = "PRODUCTOCOSECHA_AGREGAR"
    Friend Const PRODUCTOCOSECHA_EDITAR As String = "PRODUCTOCOSECHA_EDITAR"
    Friend Const PRODUCTOCOSECHA_ELIMINAR As String = "PRODUCTOCOSECHA_ELIMINAR"

    Friend Const COSECHA As String = "COSECHA"
    Friend Const COSECHA_AGREGAR As String = "COSECHA_AGREGAR"
    Friend Const COSECHA_EDITAR As String = "COSECHA_EDITAR"
    Friend Const COSECHA_ELIMINAR As String = "COSECHA_ELIMINAR"

    Friend Const TARIFA As String = "TARIFA"
    Friend Const TARIFA_AGREGAR As String = "TARIFA_AGREGAR"
    Friend Const TARIFA_EDITAR As String = "TARIFA_EDITAR"
    Friend Const TARIFA_ELIMINAR As String = "TARIFA_ELIMINAR"
    Friend Const TARIFA_IMPRIMIR As String = "TARIFA_IMPRIMIR"

    Friend Const PESADA As String = "PESADA"
    Friend Const PESADA_AGREGAR As String = "PESADA_AGREGAR"
    Friend Const PESADA_AGREGAR_HORA_ANTERIOR As String = "PESADA_AGREGAR_HORA_ANTERIOR"
    Friend Const PESADA_AGREGAR_FECHA_ANTERIOR_XDIAS As String = "PESADA_AGREGAR_FECHA_ANTERIOR_XDIAS"
    Friend Const PESADA_AGREGAR_FECHA_ANTERIOR As String = "PESADA_AGREGAR_FECHA_ANTERIOR"
    Friend Const PESADA_AGREGAR_FECHA_POSTERIOR As String = "PESADA_AGREGAR_FECHA_POSTERIOR"
    Friend Const PESADA_EDITAR As String = "PESADA_EDITAR"
    Friend Const PESADA_ELIMINAR As String = "PESADA_ELIMINAR"
    Friend Const PESADA_IMPRIMIR As String = "PESADA_IMPRIMIR"
    Friend Const PESADA_MOSTRAR_VERIFICADO As String = "PESADA_MOSTRAR_VERIFICADO"
    Friend Const PESADA_MOSTRAR_ACTIVO As String = "PESADA_MOSTRAR_ACTIVO"
    Friend Const PESADA_MOSTRAR_EXTRAS As String = "PESADA_MOSTRAR_EXTRAS"
    Friend Const PESADA_MOSTRAR_MERMASAPLICA As String = "PESADA_MOSTRAR_MERMASAPLICA"
    Friend Const PESADA_MOSTRAR_TARIFASASAPLICA As String = "PESADA_MOSTRAR_TARIFASASAPLICA"

    Friend Const RESUMENPESADA As String = "RESUMENPESADA"

    Friend Const REPORTE As String = "REPORTE"

    Friend Const DESCRIPCION_AGREGAR As String = "Agregar"
    Friend Const DESCRIPCION_EDITAR As String = "Editar"
    Friend Const DESCRIPCION_ELIMINAR As String = "Eliminar"
    Friend Const DESCRIPCION_IMPRIMIR As String = "Imprimir"

#End Region

#Region "Verificación de permisos"

    Friend Function LoadPermisos() As Boolean
        Try
            Using dbcontext As New CSPesajeContext(True)
                pPermisos = dbcontext.UsuarioGrupoPermiso.ToList
            End Using
            Return True
        Catch ex As Exception
            CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al cargar los Permisos del Usuario.")
            Return False
        End Try
    End Function

    Friend Function VerificarPermiso(ByVal IDPermiso As String, Optional ByVal MostrarAviso As Boolean = True) As Boolean
        If pUsuario.IDUsuarioGrupo = Constantes.UsurioGrupoAdministradoresId Then
            Return True
        Else
            If pPermisos.Find(Function(usrper) usrper.IDUsuarioGrupo = pUsuario.IDUsuarioGrupo AndAlso usrper.IDPermiso.TrimEnd = IDPermiso) Is Nothing Then
                If MostrarAviso Then
                    MsgBox(My.Resources.STRING_PERMISO_MENSAJE, MsgBoxStyle.Exclamation, My.Application.Info.Title)
                End If
                Return False
            Else
                Return True
            End If
        End If
    End Function

#End Region

#Region "Asignación de permisos comunes"

    Friend Function AgregarNodos(ByRef parent As TreeNode, ByVal permissionKey As String, ByVal permissionDisplay As String, ByVal permissionAddKey As String, ByVal permissionAddDisplay As String, ByVal permissionEditKey As String, ByVal permissionEditDisplay As String, ByVal permissionDeleteKey As String, ByVal permissionDeleteDisplay As String) As TreeNode
        Dim newNode = parent.Nodes.Add(permissionKey, permissionDisplay)

        With newNode
            .Nodes.Add(permissionAddKey, permissionAddDisplay)
            .Nodes.Add(permissionEditKey, permissionEditDisplay)
            .Nodes.Add(permissionDeleteKey, permissionDeleteDisplay)
        End With
        Return newNode
    End Function

    Friend Sub CargarArbolDePermisos(ByRef Arbol As TreeView, ByVal IDUsuarioGrupo As Byte)
        Dim nodeRoot As TreeNode
        Dim nodeParent As TreeNode

        Arbol.SuspendLayout()
        Application.DoEvents()

        Arbol.Nodes.Clear()

        ' TABLAS
        nodeRoot = Arbol.Nodes.Add("TABLAS", "Tablas")
        AgregarNodos(nodeRoot, ENTIDAD, "Entidades", ENTIDAD_AGREGAR, DESCRIPCION_AGREGAR, ENTIDAD_EDITAR, DESCRIPCION_EDITAR, ENTIDAD_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeRoot, CAMION, "Camiones", CAMION_AGREGAR, DESCRIPCION_AGREGAR, CAMION_EDITAR, DESCRIPCION_EDITAR, CAMION_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeRoot, ORIGENDESTINO, "Orígenes-Destinos", ORIGENDESTINO_AGREGAR, DESCRIPCION_AGREGAR, ORIGENDESTINO_EDITAR, DESCRIPCION_EDITAR, ORIGENDESTINO_ELIMINAR, DESCRIPCION_ELIMINAR)
        nodeParent = AgregarNodos(nodeRoot, PRODUCTO, "Productos", PRODUCTO_AGREGAR, DESCRIPCION_AGREGAR, PRODUCTO_EDITAR, DESCRIPCION_EDITAR, PRODUCTO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, PRODUCTOMERMAHUMEDAD, "Mermas por humedad", PRODUCTOMERMAHUMEDAD_AGREGAR, DESCRIPCION_AGREGAR, PRODUCTOMERMAHUMEDAD_EDITAR, DESCRIPCION_EDITAR, PRODUCTOMERMAHUMEDAD_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, PRODUCTOPLANTA, "Plantas", PRODUCTOPLANTA_AGREGAR, DESCRIPCION_AGREGAR, PRODUCTOPLANTA_EDITAR, DESCRIPCION_EDITAR, PRODUCTOPLANTA_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeParent, PRODUCTOCOSECHA, "Cosechas", PRODUCTOCOSECHA_AGREGAR, DESCRIPCION_AGREGAR, PRODUCTOCOSECHA_EDITAR, DESCRIPCION_EDITAR, PRODUCTOCOSECHA_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeRoot, COSECHA, "Cosechas", COSECHA_AGREGAR, DESCRIPCION_AGREGAR, COSECHA_EDITAR, DESCRIPCION_EDITAR, COSECHA_ELIMINAR, DESCRIPCION_ELIMINAR)
        nodeParent = AgregarNodos(nodeRoot, USUARIOGRUPO, "Grupos de Usuarios", USUARIOGRUPO_AGREGAR, DESCRIPCION_AGREGAR, USUARIOGRUPO_EDITAR, DESCRIPCION_EDITAR, USUARIOGRUPO_ELIMINAR, DESCRIPCION_ELIMINAR)
        nodeParent.Nodes.Add(USUARIOGRUPO_PERMISOS, "Asignar permisos")
        AgregarNodos(nodeRoot, USUARIO, "Usuarios", USUARIO_AGREGAR, DESCRIPCION_AGREGAR, USUARIO_EDITAR, DESCRIPCION_EDITAR, USUARIO_ELIMINAR, DESCRIPCION_ELIMINAR)
        AgregarNodos(nodeRoot, TARIFA, "Tarifas", TARIFA_AGREGAR, DESCRIPCION_AGREGAR, TARIFA_EDITAR, DESCRIPCION_EDITAR, TARIFA_ELIMINAR, DESCRIPCION_ELIMINAR)

        ' PESADAS
        nodeRoot = Arbol.Nodes.Add(PESADA, "Pesadas")
        With nodeRoot
            .Nodes.Add(PESADA_AGREGAR, DESCRIPCION_AGREGAR)
            .Nodes.Add(PESADA_AGREGAR_HORA_ANTERIOR, "Agregar con hora anterior de la hora actual")
            .Nodes.Add(PESADA_AGREGAR_FECHA_ANTERIOR_XDIAS, "Agregar con fecha anterior (hasta X días especificados en los parámetros de la aplicación)")
            .Nodes.Add(PESADA_AGREGAR_FECHA_ANTERIOR, "Agregar con fecha anterior (sin límite)")
            .Nodes.Add(PESADA_AGREGAR_FECHA_POSTERIOR, "Agregar con fecha posterior")
            .Nodes.Add(PESADA_EDITAR, DESCRIPCION_EDITAR)
            .Nodes.Add(PESADA_ELIMINAR, DESCRIPCION_ELIMINAR)
            .Nodes.Add(PESADA_IMPRIMIR, DESCRIPCION_IMPRIMIR)
            .Nodes.Add(PESADA_MOSTRAR_VERIFICADO, "Mostrar opciones de pesadas Verificadas.")
            .Nodes.Add(PESADA_MOSTRAR_ACTIVO, "Mostrar opciones de pesadas Activas.")
            .Nodes.Add(PESADA_MOSTRAR_EXTRAS, "Mostrar opciones de Extras.")
            .Nodes.Add(PESADA_MOSTRAR_MERMASAPLICA, "Mostrar opciones de aplicación de mermas.")
            .Nodes.Add(PESADA_MOSTRAR_TARIFASASAPLICA, "Mostrar opciones de aplicación de tarifas.")
        End With

        nodeRoot = Arbol.Nodes.Add(RESUMENPESADA, "Resumen de pesadas")

        nodeRoot = Arbol.Nodes.Add(REPORTE, "Reportes")

        Arbol.TopNode = Arbol.Nodes(0)

        ' Muestro los permisos asignados
        MostrarPermisosEstablecidos(Arbol, IDUsuarioGrupo)

        Arbol.ResumeLayout()
    End Sub

    Private Sub MostrarPermisosEstablecidos(ByRef Arbol As TreeView, ByVal IDUsuarioGrupo As Byte)
        Dim listPermisos As List(Of UsuarioGrupoPermiso)

        ' Obtengo la lista de permisos para el Grupo de Usuarios
        Using dbcontext As New CSPesajeContext(True)
            Try
                listPermisos = dbcontext.UsuarioGrupoPermiso.Where(Function(ugp) ugp.IDUsuarioGrupo = IDUsuarioGrupo).OrderBy(Function(ugp) ugp.IDPermiso).ToList()
            Catch ex As Exception
                CardonerSistemas.ErrorHandler.ProcessError(ex, "Error al leer la lista de permisos efectivos.")
                Return
            End Try
        End Using

        ' Marco los items del Tree View que tienen asignado el permiso
        For Each permiso As UsuarioGrupoPermiso In listPermisos
            ' Arbol.Nodes.Item(permiso.IDPermiso.Trim()).Checked = True
            Arbol.Nodes.Find(permiso.IDPermiso.Trim(), True).First.Checked = True
        Next

        listPermisos = Nothing
    End Sub

#End Region

End Module