Friend Class FillAndRefreshLists

#Region "Declarations..."
    Friend mdbContext As CSPesajeContext

    Public Sub New()
        mdbContext = New CSPesajeContext(True)
    End Sub

    Protected Overrides Sub Finalize()
        mdbContext.Dispose()
        MyBase.Finalize()
    End Sub

    Public Class Camion_ListItem
        Public Property IDCamion As Byte
        Public Property Descripcion As String
    End Class

#End Region

    Friend Sub Provincia(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_NoEspecifica As Boolean)
        ComboBoxControl.ValueMember = "IDProvincia"
        ComboBoxControl.DisplayMember = "Nombre"

        Dim qryList = From tbl In mdbContext.Provincia
                          Order By tbl.Nombre

        Dim localList = qryList.ToList
        If AgregarItem_NoEspecifica Then
            Dim UnspecifiedItem As New Provincia
            UnspecifiedItem.IDProvincia = FIELD_VALUE_NOTSPECIFIED_BYTE
            UnspecifiedItem.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
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
            Dim UnspecifiedItem As New Localidad
            UnspecifiedItem.IDLocalidad = FIELD_VALUE_NOTSPECIFIED_SHORT
            UnspecifiedItem.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
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

    Friend Sub UsuarioGrupo(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of UsuarioGrupo)

        ComboBoxControl.ValueMember = "IDUsuarioGrupo"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.UsuarioGrupo.OrderBy(Function(cl) cl.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New UsuarioGrupo
            Item_Todos.IDUsuarioGrupo = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New UsuarioGrupo
            Item_NoEspecifica.IDUsuarioGrupo = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Transportista(ByRef ComboBoxControl As ComboBox, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Entidad)

        ComboBoxControl.ValueMember = "IDEntidad"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.Entidad.Where(Function(ent) ent.EsActivo And ent.EsTransportista).OrderBy(Function(ent) ent.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New Entidad
            Item_Todos.IDEntidad = FIELD_VALUE_ALL_INTEGER
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Entidad
            Item_NoEspecifica.IDEntidad = FIELD_VALUE_NOTSPECIFIED_INTEGER
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Chofer(ByRef ComboBoxControl As ComboBox, ByVal IDTransportista As Integer, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Entidad)

        ComboBoxControl.ValueMember = "IDEntidad"
        ComboBoxControl.DisplayMember = "Nombre"

        listItems = mdbContext.Entidad.Where(Function(ent) ent.EsActivo And ent.EsChofer AndAlso ent.Transportista_IDEntidad.Value = IDTransportista).OrderBy(Function(ent) ent.Nombre).ToList

        If AgregarItem_Todos Then
            Dim Item_Todos As New Entidad
            Item_Todos.IDEntidad = FIELD_VALUE_ALL_INTEGER
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Entidad
            Item_NoEspecifica.IDEntidad = FIELD_VALUE_NOTSPECIFIED_INTEGER
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Camion(ByRef ComboBoxControl As ComboBox, ByVal IDTransportista As Integer, ByVal MostrarNombre As Boolean, ByVal MostrarPatentes As Boolean, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Camion_ListItem)

        ComboBoxControl.ValueMember = "IDCamion"
        ComboBoxControl.DisplayMember = "Descripcion"

        If MostrarNombre And MostrarPatentes Then
            listItems = (From c In mdbContext.Camion
                         Where c.IDEntidad = IDTransportista
                         Order By c.DominioChasis, c.DominioAcoplado
                         Select New Camion_ListItem With {.IDCamion = c.IDCamion, .Descripcion = c.Nombre & CStr(If(c.DominioChasis Is Nothing, "", " - " & c.DominioChasis)) & CStr(If(c.DominioAcoplado Is Nothing, "", " - " & c.DominioAcoplado))}).ToList
        ElseIf MostrarNombre Then
            listItems = (From c In mdbContext.Camion
                         Where c.IDEntidad = IDTransportista
                         Order By c.Nombre
                         Select New Camion_ListItem With {.IDCamion = c.IDCamion, .Descripcion = c.Nombre}).ToList
        ElseIf MostrarPatentes Then
            listItems = (From c In mdbContext.Camion
                         Where c.IDEntidad = IDTransportista
                         Order By c.DominioChasis, c.DominioAcoplado
                         Select New Camion_ListItem With {.IDCamion = c.IDCamion, .Descripcion = CStr(If(c.DominioChasis Is Nothing, "", c.DominioChasis)) & CStr(If(c.DominioAcoplado Is Nothing, "", " - " & c.DominioAcoplado))}).ToList
        Else
            listItems = New List(Of Camion_ListItem)
        End If


        If AgregarItem_Todos Then
            Dim Item_Todos As New Camion_ListItem
            Item_Todos.IDCamion = FIELD_VALUE_ALL_BYTE
            Item_Todos.Descripcion = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Camion_ListItem
            Item_NoEspecifica.IDCamion = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Descripcion = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Producto(ByRef ComboBoxControl As ComboBox, ByVal UsoFrecuente As Boolean, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Producto)

        ComboBoxControl.ValueMember = "IDProducto"
        ComboBoxControl.DisplayMember = "Nombre"

        If UsoFrecuente Then
            listItems = mdbContext.Producto.Where(Function(pr) pr.UsoFrecuente And pr.EsActivo).OrderBy(Function(cl) cl.Nombre).ToList
        Else
            listItems = mdbContext.Producto.Where(Function(pr) pr.EsActivo).OrderBy(Function(cl) cl.Nombre).ToList
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New Producto
            Item_Todos.IDProducto = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_MALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Producto
            Item_NoEspecifica.IDProducto = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Planta(ByRef ComboBoxControl As ComboBox, ByVal IDProducto As Byte, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Planta)

        ComboBoxControl.ValueMember = "IDPlanta"
        ComboBoxControl.DisplayMember = "Nombre"

        If IDProducto = CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = mdbContext.Planta.Where(Function(pl) pl.EsActivo).OrderBy(Function(pl) pl.Nombre).ToList
        Else
            listItems = (From pl In mdbContext.Planta
                         Join pp In mdbContext.Producto_Planta On pl.IDPlanta Equals pp.IDPlanta
                         Where pp.IDProducto = IDProducto And pl.EsActivo
                         Order By pl.Nombre
                         Select pl).ToList
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New Planta
            Item_Todos.IDPlanta = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Planta
            Item_NoEspecifica.IDPlanta = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub

    Friend Sub Cosecha(ByRef ComboBoxControl As ComboBox, ByVal IDProducto As Byte, ByVal Fecha As Date, ByVal AgregarItem_Todos As Boolean, ByVal AgregarItem_NoEspecifica As Boolean)
        Dim listItems As List(Of Cosecha)

        ComboBoxControl.ValueMember = "IDCosecha"
        ComboBoxControl.DisplayMember = "Nombre"

        If IDProducto = CS_Constants.FIELD_VALUE_NOTSPECIFIED_BYTE Then
            listItems = mdbContext.Cosecha.Where(Function(co) co.EsActivo).OrderBy(Function(co) co.Nombre).ToList
        Else
            listItems = (From co In mdbContext.Cosecha
                         Join pc In mdbContext.Producto_Cosecha On co.IDCosecha Equals pc.IDCosecha
                         Where pc.IDProducto = IDProducto And pc.EsActivo And pc.Inicio <= Fecha And pc.Fin >= Fecha
                         Order By co.Nombre
                         Select co).ToList
        End If

        If AgregarItem_Todos Then
            Dim Item_Todos As New Cosecha
            Item_Todos.IDCosecha = FIELD_VALUE_ALL_BYTE
            Item_Todos.Nombre = My.Resources.STRING_ITEM_ALL_FEMALE
            listItems.Insert(0, Item_Todos)
        End If

        If AgregarItem_NoEspecifica Then
            Dim Item_NoEspecifica As New Cosecha
            Item_NoEspecifica.IDCosecha = FIELD_VALUE_NOTSPECIFIED_BYTE
            Item_NoEspecifica.Nombre = My.Resources.STRING_ITEM_NOT_SPECIFIED
            listItems.Insert(0, Item_NoEspecifica)
        End If

        ComboBoxControl.DataSource = listItems
    End Sub
End Class
