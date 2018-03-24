Module Permisos
    Friend Const USUARIOGRUPO As String = "USUARIOGRUPO"
    Friend Const USUARIOGRUPO_AGREGAR As String = "USUARIOGRUPO_AGREGAR"
    Friend Const USUARIOGRUPO_EDITAR As String = "USUARIOGRUPO_EDITAR"
    Friend Const USUARIOGRUPO_ELIMINAR As String = "USUARIOGRUPO_ELIMINAR"

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

    Friend Const REPORTE As String = "REPORTE"

    Friend Const DESCRIPCION_AGREGAR As String = "Agregar"
    Friend Const DESCRIPCION_EDITAR As String = "Editar"
    Friend Const DESCRIPCION_ELIMINAR As String = "Eliminar"
    Friend Const DESCRIPCION_IMPRIMIR As String = "Imprimir"

    Friend Function VerificarPermiso(ByVal IDPermiso As String, Optional ByVal MostrarAviso As Boolean = True) As Boolean
        If pUsuario.IDUsuarioGrupo = 1 Then
            Return True
        Else
            If pPermisos.Find(Function(usrper) usrper.IDUsuarioGrupo = pUsuario.IDUsuarioGrupo And usrper.IDPermiso.TrimEnd = IDPermiso) Is Nothing Then
                If MostrarAviso Then
                    MsgBox(My.Resources.STRING_PERMISO_MENSAJE, MsgBoxStyle.Exclamation, My.Application.Info.Title)
                End If
                Return False
            Else
                Return True
            End If
        End If
    End Function

    Friend Sub CargarArbolDePermisos(ByRef Arbol As TreeView, ByVal IDUsuarioGrupo As Byte)
        Dim RootNode As TreeNode

        Arbol.SuspendLayout()

        Arbol.Nodes.Clear()

        RootNode = Arbol.Nodes.Add(UsuarioGrupo, "Grupos de Usuarios")
        With RootNode
            .Nodes.Add(USUARIOGRUPO_AGREGAR, DESCRIPCION_AGREGAR)
            .Nodes.Add(USUARIOGRUPO_EDITAR, DESCRIPCION_EDITAR)
            .Nodes.Add(USUARIOGRUPO_ELIMINAR, DESCRIPCION_ELIMINAR)
        End With

        RootNode = Arbol.Nodes.Add(ENTIDAD, "Entidades")
        With RootNode
            .Nodes.Add(ENTIDAD_AGREGAR, DESCRIPCION_AGREGAR)
            .Nodes.Add(ENTIDAD_EDITAR, DESCRIPCION_EDITAR)
            .Nodes.Add(ENTIDAD_ELIMINAR, DESCRIPCION_ELIMINAR)
            .Nodes.Add(ENTIDAD_IMPRIMIR, DESCRIPCION_IMPRIMIR)
        End With

        RootNode = Arbol.Nodes.Add(CAMION, "Camiones")
        With RootNode
            .Nodes.Add(CAMION_AGREGAR, DESCRIPCION_AGREGAR)
            .Nodes.Add(CAMION_EDITAR, DESCRIPCION_EDITAR)
            .Nodes.Add(CAMION_ELIMINAR, DESCRIPCION_ELIMINAR)
            .Nodes.Add(CAMION_IMPRIMIR, DESCRIPCION_IMPRIMIR)
        End With

        RootNode = Arbol.Nodes.Add(ORIGENDESTINO, "Orígenes-Destinos")
        With RootNode
            .Nodes.Add(ORIGENDESTINO_AGREGAR, DESCRIPCION_AGREGAR)
            .Nodes.Add(ORIGENDESTINO_EDITAR, DESCRIPCION_EDITAR)
            .Nodes.Add(ORIGENDESTINO_ELIMINAR, DESCRIPCION_ELIMINAR)
            .Nodes.Add(ORIGENDESTINO_IMPRIMIR, DESCRIPCION_IMPRIMIR)
        End With

        RootNode = Arbol.Nodes.Add(PESADA, "Pesadas")
        With RootNode
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

        RootNode = Arbol.Nodes.Add(REPORTE, "Reportes")

        Arbol.ExpandAll()

        Arbol.ResumeLayout()
    End Sub
End Module
