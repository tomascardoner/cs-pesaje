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
                    MsgBox("No tiene autorización para realizar esta acción.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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


        RootNode = Arbol.Nodes.Add(REPORTE, "Reportes")

        Arbol.ExpandAll()

        Arbol.ResumeLayout()
    End Sub
End Module
