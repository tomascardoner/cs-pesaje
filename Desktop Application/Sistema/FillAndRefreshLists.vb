Friend Class FillAndRefreshLists

#Region "Declarations..."

    Friend mdbContext As CSPesajeContext
    Private listProductos As List(Of Producto)
    Private listProductosPlantas As List(Of Producto_Planta)
    Private listPlantas As List(Of Planta)
    Private listPlantasDepositos As List(Of PlantaDeposito)
    Private listCosechas As List(Of Cosecha)
    Private listProductosCosechas As List(Of Producto_Cosecha)
    Private listEntidades As List(Of Entidad)
    Private listEntidadsProductosPlantas As List(Of Entidad_Producto_Planta)
    Private listOrigenesDestinos As List(Of OrigenDestino)
    Private listEntidadesOrigenesDestinos As List(Of Entidad_OrigenDestino)
    Private listCamiones As List(Of Camion)

    Public Sub New()
        mdbContext = New CSPesajeContext(True)
        ProductosLoad()
        ProductosPlantasLoad()
        PlantasLoad()
        PlantasDepositosLoad()
        CosechasLoad()
        ProductosCosechasLoad()
        EntidadesLoad()
        EntidadesProductosPlantasLoad()
        OrigenesDestinosLoad()
        EntidadesOrigenesDestinosLoad()
        CamionesLoad()
    End Sub

    Protected Overrides Sub Finalize()
        mdbContext.Dispose()
        listProductos.Clear()
        listProductos = Nothing
        listProductosPlantas.Clear()
        listProductosPlantas = Nothing
        listPlantas.Clear()
        listPlantas = Nothing
        listPlantasDepositos.Clear()
        listPlantasDepositos = Nothing
        listCosechas.Clear()
        listCosechas = Nothing
        listProductosCosechas.Clear()
        listProductosCosechas = Nothing
        listEntidades.Clear()
        listEntidades = Nothing
        listEntidadsProductosPlantas.Clear()
        listEntidadsProductosPlantas = Nothing
        listOrigenesDestinos.Clear()
        listOrigenesDestinos = Nothing
        listEntidadesOrigenesDestinos.Clear()
        listEntidadesOrigenesDestinos = Nothing
        listCamiones.Clear()
        listCamiones = Nothing
        MyBase.Finalize()
    End Sub

    Friend Class Camion_ListItem
        Public Property IDCamion As Byte
        Public Property Descripcion As String
    End Class

#End Region

#Region "Lectura de listas desde la base de datos"

    Friend Sub ProductosLoad()
        listProductos = mdbContext.Producto.OrderBy(Function(p) p.Nombre).ToList
    End Sub

    Friend Sub ProductosPlantasLoad()
        listProductosPlantas = mdbContext.Producto_Planta.ToList
    End Sub

    Friend Sub PlantasLoad()
        listPlantas = mdbContext.Planta.OrderBy(Function(p) p.Nombre).ToList
    End Sub

    Friend Sub PlantasDepositosLoad()
        listPlantasDepositos = mdbContext.PlantaDeposito.OrderBy(Function(pd) pd.Nombre).ToList
    End Sub

    Friend Sub CosechasLoad()
        listCosechas = mdbContext.Cosecha.OrderBy(Function(c) c.Nombre).ToList
    End Sub

    Friend Sub ProductosCosechasLoad()
        listProductosCosechas = mdbContext.Producto_Cosecha.ToList
    End Sub

    Friend Sub EntidadesLoad()
        listEntidades = mdbContext.Entidad.OrderBy(Function(e) e.Nombre).ToList
    End Sub

    Friend Sub EntidadesProductosPlantasLoad()
        listEntidadsProductosPlantas = mdbContext.Entidad_Producto_Planta.ToList
    End Sub

    Friend Sub OrigenesDestinosLoad()
        listOrigenesDestinos = mdbContext.OrigenDestino.OrderBy(Function(od) od.Nombre).ToList
    End Sub

    Friend Sub EntidadesOrigenesDestinosLoad()
        listEntidadesOrigenesDestinos = mdbContext.Entidad_OrigenDestino.ToList
    End Sub

    Friend Sub CamionesLoad()
        listCamiones = mdbContext.Camion.OrderBy(Function(c) c.Nombre).ToList
    End Sub

#End Region


    Friend Sub Provincia(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_NoEspecifica As Boolean)
        ComboBoxControl.ValueMember = "IDProvincia"
        ComboBoxControl.DisplayMember = "Nombre"

        Dim qryList = From tbl In mdbContext.Provincia
                      Order By tbl.Nombre

        Dim localList = qryList.ToList
        If AgregarItem_NoEspecifica Then
            Dim UnspecifiedItem As New Provincia With {
                .IDProvincia = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            localList.Insert(0, UnspecifiedItem)
        End If

        ComboBoxControl.DataSource = localList
    End Sub

    Friend Sub Localidad(ByRef ComboBoxControl As ComboBox, ByVal IDProvincia As Byte, ByVal AgregarItem_NoEspecifica As Boolean)
        ComboBoxControl.ValueMember = "IDLocalidad"
        ComboBoxControl.DisplayMember = "Nombre"

        Dim qryList = From tbl In mdbContext.Localidad
                      Where tbl.IDProvincia = IDProvincia
                      Order By tbl.Nombre

        Dim localList = qryList.ToList
        If AgregarItem_NoEspecifica Then
            Dim UnspecifiedItem As New Localidad With {
                .IDLocalidad = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            localList.Insert(0, UnspecifiedItem)
        End If

        ComboBoxControl.DataSource = localList
    End Sub

    Friend Sub Genero(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim datatableGeneros As New DataTable("Generos")
        Dim datarowRow As DataRow

        ComboBoxControl.ValueMember = "IDGenero"
        ComboBoxControl.DisplayMember = "Nombre"

        With datatableGeneros
            .Columns.Add("IDGenero", System.Type.GetType("System.String"))
            .Columns.Add("Nombre", System.Type.GetType("System.String"))

            If AgregarItem_NoEspecifica Then
                datarowRow = .NewRow
                datarowRow("IDGenero") = Constantes.PERSONA_GENERO_NOESPECIFICA
                datarowRow("Nombre") = My.Resources.STRING_ITEM_NOT_SPECIFIED
                .Rows.Add(datarowRow)
            End If

            datarowRow = .NewRow
            datarowRow("IDGenero") = Constantes.PERSONA_GENERO_MASCULINO
            datarowRow("Nombre") = My.Resources.STRING_GENERO_MASCULINO
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDGenero") = Constantes.PERSONA_GENERO_FEMENINO
            datarowRow("Nombre") = My.Resources.STRING_GENERO_FEMENINO
            .Rows.Add(datarowRow)
        End With

        ComboBoxControl.DataSource = datatableGeneros
        If AgregarItem_NoEspecifica Then
            ComboBoxControl.SelectedIndex = 0
        Else
            ComboBoxControl.SelectedIndex = -1
        End If
    End Sub

    Friend Sub UsuarioGrupo(ByRef ComboBoxControl As ComboBox, ByVal MostrarGrupoAdministradores As Boolean, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of UsuarioGrupo)

        ComboBoxControl.ValueMember = "IDUsuarioGrupo"
        ComboBoxControl.DisplayMember = "Nombre"

        If MostrarGrupoAdministradores Then
            listItems = mdbContext.UsuarioGrupo.Where(Function(ug) ug.EsActivo).OrderBy(Function(ug) ug.Nombre).ToList
        Else
            listItems = mdbContext.UsuarioGrupo.Where(Function(ug) ug.EsActivo AndAlso ug.IDUsuarioGrupo <> Constantes.UsurioGrupoAdministradoresId).OrderBy(Function(ug) ug.Nombre).ToList
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New UsuarioGrupo With {
                .IDUsuarioGrupo = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New UsuarioGrupo With {
                .IDUsuarioGrupo = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Entidad(ByRef ComboBoxControl As ComboBox, ByVal IDEntidadActual As Integer?, ByVal MostrarItemOtro As Boolean, ByVal EsTitular As Boolean, ByVal EsTransportista As Boolean, ByVal EsChofer As Boolean, ByVal IDTransportista As Integer, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_Otro As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Entidad)

        ComboBoxControl.ValueMember = "IDEntidad"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = (From ent In listEntidades
                     Where (ent.IDEntidad <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER OrElse MostrarItemOtro) AndAlso ((IDEntidadActual.HasValue AndAlso ent.IDEntidad = IDEntidadActual.Value) Or (ent.EsActivo AndAlso ((EsTitular AndAlso ent.EsTitular) Or (EsTransportista AndAlso ent.EsTransportista) Or (EsChofer AndAlso ent.EsChofer)) AndAlso (ent.Transportista_IDEntidad = IDTransportista Or IDTransportista = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER Or IDTransportista = CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER)))
                     Select ent).Distinct().ToList

        If AgregarItem_Otro Then
            Dim Item_Otro As New Entidad With {
                .IDEntidad = CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER,
                .Nombre = My.Resources.STRING_ITEM_OTHER_MALE
            }
            listItems.Insert(0, Item_Otro)
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New Entidad With {
                .IDEntidad = CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Entidad With {
                .IDEntidad = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub EntidadTitularPorProductoPlanta(ByRef ComboBoxControl As ComboBox, IDEntidadActual As Integer, IDProducto As Byte, IDPlanta As Byte, TipoEntrada As Boolean, TipoSalida As Boolean, TipoNinguno As Boolean, UsoFrecuente As Boolean, AgregarItem_Todos As Boolean, AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Entidad)

        ComboBoxControl.ValueMember = "IDEntidad"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = (From ent In listEntidades
                     Join ent_pro_pla In listEntidadsProductosPlantas On ent.IDEntidad Equals ent_pro_pla.IDEntidad
                     Where ent.IDEntidad <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER AndAlso (ent.IDEntidad = IDEntidadActual Or (ent.EsActivo AndAlso ent.EsTitular AndAlso ent_pro_pla.IDProducto = IDProducto AndAlso ent_pro_pla.IDPlanta = IDPlanta AndAlso ((TipoEntrada AndAlso ent_pro_pla.TipoEntrada) Or (TipoSalida AndAlso ent_pro_pla.TipoSalida) Or (TipoNinguno AndAlso ent_pro_pla.TipoNinguno))))
                     Select ent).Distinct().OrderBy(Function(ent) ent.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New Entidad With {
                .IDEntidad = CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Entidad With {
                .IDEntidad = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub EntidadLiquidacionServicio(ByRef ComboBoxControl As ComboBox, IDEntidadActual As Integer?, mostrarTitulares As Boolean, agregarItemTodos As Boolean, agregarItemNoEspecifica As Boolean)
        Dim listItems As List(Of Entidad)

        ComboBoxControl.ValueMember = "IDEntidad"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = (From ent In listEntidades
                     Where ent.IDEntidad <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER AndAlso ((IDEntidadActual.HasValue AndAlso ent.IDEntidad = IDEntidadActual.Value) OrElse (ent.EsActivo AndAlso ((mostrarTitulares AndAlso ent.EsTitular) OrElse ent.EsTitularLiquidacionServicio)))
                     Select ent).ToList

        If agregarItemNoEspecifica Then
            Dim Item_NoEspecifica As New Entidad With {
                .IDEntidad = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If
        If agregarItemTodos Then
            Dim Item_Todos As New Entidad With {
                .IDEntidad = CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Camion(ByRef ComboBoxControl As ComboBox, ByVal IDCamionActual As Byte?, ByVal MostrarItemOtro As Boolean, ByVal IDEntidad As Integer?, ByVal MostrarNombre As Boolean, ByVal MostrarPatentes As Boolean, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Camion_ListItem)

        ComboBoxControl.ValueMember = "IDCamion"
        ComboBoxControl.DisplayMember = "Descripcion"

        If MostrarNombre AndAlso MostrarPatentes Then
            listItems = (From c In listCamiones
                         Where c.IDEntidad = IDEntidad AndAlso (c.IDEntidad <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER OrElse MostrarItemOtro) AndAlso (c.EsActivo OrElse c.IDCamion = IDCamionActual)
                         Order By c.DominioChasis, c.DominioAcoplado
                         Select New Camion_ListItem With {.IDCamion = c.IDCamion, .Descripcion = c.Nombre & CStr(If(c.DominioChasis Is Nothing, String.Empty, " - " & c.DominioChasis)) & CStr(If(c.DominioAcoplado Is Nothing, String.Empty, " - " & c.DominioAcoplado))}).ToList
        ElseIf MostrarNombre Then
            listItems = (From c In listCamiones
                         Where c.IDEntidad = IDEntidad AndAlso (c.IDEntidad <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER OrElse MostrarItemOtro) AndAlso (c.EsActivo OrElse c.IDCamion = IDCamionActual)
                         Order By c.Nombre
                         Select New Camion_ListItem With {.IDCamion = c.IDCamion, .Descripcion = c.Nombre}).ToList
        ElseIf MostrarPatentes Then
            listItems = (From c In listCamiones
                         Where c.IDEntidad = IDEntidad AndAlso (c.IDEntidad <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER OrElse MostrarItemOtro) AndAlso (c.EsActivo OrElse c.IDCamion = IDCamionActual)
                         Order By c.DominioChasis, c.DominioAcoplado
                         Select New Camion_ListItem With {.IDCamion = c.IDCamion, .Descripcion = CStr(If(c.DominioChasis, String.Empty)) & CStr(If(c.DominioAcoplado Is Nothing, String.Empty, " - " & c.DominioAcoplado))}).ToList
        Else
            listItems = New List(Of Camion_ListItem)
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New Camion_ListItem With {
                .IDCamion = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Descripcion = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Camion_ListItem With {
                .IDCamion = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Descripcion = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Producto(ByRef ComboBoxControl As ComboBox, ByVal IDProductoActual As Byte?, ByVal MostrarItemOtro As Boolean, ByVal UsoFrecuente As Boolean, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Producto)
        Dim IDProductoSeleccionadoActualmente As Byte?

        ComboBoxControl.ValueMember = "IDProducto"
        ComboBoxControl.DisplayMember = "Nombre"
        IDProductoSeleccionadoActualmente = CByte(ComboBoxControl.SelectedValue)

        listItems = listProductos.Where(Function(pr) (pr.IDProducto <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_BYTE OrElse MostrarItemOtro) AndAlso (IDProductoActual.HasValue AndAlso pr.IDProducto = IDProductoActual.Value OrElse pr.EsActivo)).OrderBy(Function(cl) cl.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New Producto With {
                .IDProducto = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Producto With {
                .IDProducto = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
        ComboBoxControl.SelectedValue = IDProductoSeleccionadoActualmente
    End Sub

    Friend Sub Planta(ByRef ComboBoxControl As ComboBox, ByVal IDPlantaActual As Byte?, ByVal IDProducto As Byte, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Planta)

        ComboBoxControl.ValueMember = "IDPlanta"
        ComboBoxControl.DisplayMember = "Nombre"

        If IDProducto = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = listPlantas.Where(Function(pl) (IDPlantaActual.HasValue AndAlso pl.IDPlanta = IDPlantaActual.Value) OrElse pl.EsActivo).OrderBy(Function(pl) pl.Nombre).ToList
        Else
            listItems = (From pl In listPlantas
                         Join pp In listProductosPlantas On pl.IDPlanta Equals pp.IDPlanta
                         Where pp.IDProducto = IDProducto AndAlso ((IDPlantaActual.HasValue AndAlso pl.IDPlanta = IDPlantaActual.Value) OrElse (pl.EsActivo))
                         Order By pl.Nombre
                         Select pl).ToList
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New Planta With {
                .IDPlanta = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Planta With {
                .IDPlanta = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub PlantaDeposito(theControl As ComboBox, idPlantaActual As Byte, agregarItemTodos As Boolean, agregarItemNoEspecifica As Boolean)
        Dim listItems As List(Of PlantaDeposito)

        theControl.ValueMember = "IDDeposito"
        theControl.DisplayMember = "Nombre"

        listItems = (From pd In listPlantasDepositos
                     Where pd.IDPlanta = idPlantaActual AndAlso pd.EsActivo
                     Order By pd.Nombre
                     Select pd).ToList

        If agregarItemTodos Then
            listItems.Insert(0, New PlantaDeposito With {
                .IDDeposito = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            })
        End If

        If agregarItemNoEspecifica Then
            listItems.Insert(0, New PlantaDeposito With {
                .IDDeposito = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            })
        End If

        theControl.DataSource = listItems
    End Sub

    Friend Sub Cosecha(ByRef ComboBoxControl As ComboBox, ByVal IDCosecha As Byte?, ByVal IDProducto As Byte, ByVal Fecha As Date, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean, Optional InvertirOrden As Boolean = False)
        Dim listItems As List(Of Cosecha)

        ComboBoxControl.ValueMember = "IDCosecha"
        ComboBoxControl.DisplayMember = "Nombre"

        If IDProducto = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = listCosechas.Where(Function(co) (IDCosecha.HasValue AndAlso co.IDCosecha = IDCosecha.Value) OrElse co.EsActivo).ToList
        Else
            listItems = (From co In listCosechas
                         Join pc In listProductosCosechas On co.IDCosecha Equals pc.IDCosecha
                         Where pc.IDProducto = IDProducto AndAlso ((IDCosecha.HasValue AndAlso co.IDCosecha = IDCosecha.Value) OrElse (pc.EsActivo AndAlso pc.Inicio <= Fecha AndAlso pc.Fin >= Fecha))
                         Select co).ToList
        End If
        If InvertirOrden Then
            listItems = listItems.OrderByDescending(Function(co) co.Nombre).ToList
        Else
            listItems = listItems.OrderBy(Function(co) co.Nombre).ToList
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New Cosecha With {
                .IDCosecha = CardonerSistemas.Constants.FIELD_VALUE_ALL_BYTE,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Cosecha With {
                .IDCosecha = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub OrigenDestino(ByRef ComboBoxControl As ComboBox, ByVal IDOrigenDestino As Integer?, ByVal MostrarItemOtro As Boolean, ByVal IDEntidad As Integer, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_Otro As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of OrigenDestino)

        ComboBoxControl.ValueMember = "IDOrigenDestino"
        ComboBoxControl.DisplayMember = "Nombre"

        If IDEntidad = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER OrElse IDEntidad = CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER Then
            listItems = mdbContext.OrigenDestino.Where(Function(od) (od.IDOrigenDestino <> CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER Or MostrarItemOtro) AndAlso (IDOrigenDestino.HasValue AndAlso od.IDOrigenDestino = IDOrigenDestino.Value) OrElse od.EsActivo).OrderBy(Function(od) od.Nombre).ToList
        Else
            listItems = (From ori In listOrigenesDestinos
                         Join ent_ori In listEntidadesOrigenesDestinos On ori.IDOrigenDestino Equals ent_ori.IDOrigenDestino
                         Where (IDOrigenDestino.HasValue AndAlso ori.IDOrigenDestino = IDOrigenDestino.Value) OrElse (ent_ori.IDEntidad = IDEntidad AndAlso ori.EsActivo)
                         Select ori).Distinct().OrderBy(Function(ori) ori.Nombre).ToList
        End If

        If AgregarItem_Otro Then
            Dim Item_Otro As New OrigenDestino With {
                .IDOrigenDestino = CardonerSistemas.Constants.FIELD_VALUE_OTHER_INTEGER,
                .Nombre = My.Resources.STRING_ITEM_OTHER_MALE
            }
            listItems.Insert(0, Item_Otro)
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New OrigenDestino With {
                .IDOrigenDestino = CardonerSistemas.Constants.FIELD_VALUE_ALL_INTEGER,
                .Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New OrigenDestino With {
                .IDOrigenDestino = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Reporte(ByRef ComboBoxControl As ComboBox, ByVal IDReporteActual As Short?, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Reporte)
        Dim IDReporteSeleccionadoActualmente As Short?

        ComboBoxControl.ValueMember = "IDReporte"
        ComboBoxControl.DisplayMember = "Nombre"
        IDReporteSeleccionadoActualmente = CShort(ComboBoxControl.SelectedValue)

        listItems = mdbContext.Reporte.OrderBy(Function(cl) cl.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New Reporte With {
                .IDReporte = CardonerSistemas.Constants.FIELD_VALUE_ALL_SHORT,
                .Nombre = My.Resources.STRING_ITEM_ALL_MALE
            }
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Reporte With {
                .IDReporte = CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_SHORT,
                .Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            }
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
        ComboBoxControl.SelectedValue = IDReporteSeleccionadoActualmente
    End Sub

    Friend Sub Periodicidad(ByRef ComboBoxControl As ComboBox)
        Dim datatablePeriodicidades As New DataTable("Periodicidades")
        Dim datarowRow As DataRow

        ComboBoxControl.ValueMember = "IDPeriodicidad"
        ComboBoxControl.DisplayMember = "Nombre"

        With datatablePeriodicidades
            .Columns.Add("IDPeriodicidad", System.Type.GetType("System.String"))
            .Columns.Add("Nombre", System.Type.GetType("System.String"))

            datarowRow = .NewRow
            datarowRow("IDPeriodicidad") = Constantes.PESADA_TIPO_PERIODICIDAD_NUNCA
            datarowRow("Nombre") = "Nunca"
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDPeriodicidad") = Constantes.PESADA_TIPO_PERIODICIDAD_ESPORADICAMENTE
            datarowRow("Nombre") = "Esporadicamente"
            .Rows.Add(datarowRow)

            datarowRow = .NewRow
            datarowRow("IDPeriodicidad") = Constantes.PESADA_TIPO_PERIODICIDAD_FRECUENTEMENTE
            datarowRow("Nombre") = "Frecuentemente"
            .Rows.Add(datarowRow)
        End With

        ComboBoxControl.DataSource = datatablePeriodicidades
        ComboBoxControl.SelectedIndex = -1
    End Sub

End Class