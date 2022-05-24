﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class CSPesajeContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=CSPesajeContext")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Camion() As DbSet(Of Camion)
    Public Overridable Property Cosecha() As DbSet(Of Cosecha)
    Public Overridable Property Cosecha_Producto_Tarifa() As DbSet(Of Cosecha_Producto_Tarifa)
    Public Overridable Property Cosecha_Producto_TarifaEscala() As DbSet(Of Cosecha_Producto_TarifaEscala)
    Public Overridable Property Entidad() As DbSet(Of Entidad)
    Public Overridable Property Entidad_OrigenDestino() As DbSet(Of Entidad_OrigenDestino)
    Public Overridable Property Localidad() As DbSet(Of Localidad)
    Public Overridable Property OrigenDestino() As DbSet(Of OrigenDestino)
    Public Overridable Property Parametro() As DbSet(Of Parametro)
    Public Overridable Property Pesada() As DbSet(Of Pesada)
    Public Overridable Property Pesada_Acondicionamiento() As DbSet(Of Pesada_Acondicionamiento)
    Public Overridable Property Pesada_Analisis() As DbSet(Of Pesada_Analisis)
    Public Overridable Property Pesada_Otro() As DbSet(Of Pesada_Otro)
    Public Overridable Property Planta() As DbSet(Of Planta)
    Public Overridable Property Producto() As DbSet(Of Producto)
    Public Overridable Property Producto_Cosecha() As DbSet(Of Producto_Cosecha)
    Public Overridable Property Producto_Planta() As DbSet(Of Producto_Planta)
    Public Overridable Property Provincia() As DbSet(Of Provincia)
    Public Overridable Property Reporte() As DbSet(Of Reporte)
    Public Overridable Property ReporteGrupo() As DbSet(Of ReporteGrupo)
    Public Overridable Property ReporteParametro() As DbSet(Of ReporteParametro)
    Public Overridable Property Usuario() As DbSet(Of Usuario)
    Public Overridable Property UsuarioGrupo() As DbSet(Of UsuarioGrupo)
    Public Overridable Property UsuarioGrupoPermiso() As DbSet(Of UsuarioGrupoPermiso)
    Public Overridable Property Producto_Humedad() As DbSet(Of Producto_Humedad)
    Public Overridable Property Entidad_Producto_Planta() As DbSet(Of Entidad_Producto_Planta)
    Public Overridable Property PlantaDeposito() As DbSet(Of PlantaDeposito)

    Public Overridable Function ObtenerResumenPesadas(iDProducto As Nullable(Of Byte), iDCosecha As Nullable(Of Byte), iDPlanta As Nullable(Of Byte), iDEntidad As Nullable(Of Integer), entradas As Nullable(Of Boolean), salidas As Nullable(Of Boolean), activas As Nullable(Of Boolean), fechaDesde As Nullable(Of Date), fechaHasta As Nullable(Of Date)) As ObjectResult(Of ObtenerResumenPesadas_Result)
        Dim iDProductoParameter As ObjectParameter = If(iDProducto.HasValue, New ObjectParameter("IDProducto", iDProducto), New ObjectParameter("IDProducto", GetType(Byte)))

        Dim iDCosechaParameter As ObjectParameter = If(iDCosecha.HasValue, New ObjectParameter("IDCosecha", iDCosecha), New ObjectParameter("IDCosecha", GetType(Byte)))

        Dim iDPlantaParameter As ObjectParameter = If(iDPlanta.HasValue, New ObjectParameter("IDPlanta", iDPlanta), New ObjectParameter("IDPlanta", GetType(Byte)))

        Dim iDEntidadParameter As ObjectParameter = If(iDEntidad.HasValue, New ObjectParameter("IDEntidad", iDEntidad), New ObjectParameter("IDEntidad", GetType(Integer)))

        Dim entradasParameter As ObjectParameter = If(entradas.HasValue, New ObjectParameter("Entradas", entradas), New ObjectParameter("Entradas", GetType(Boolean)))

        Dim salidasParameter As ObjectParameter = If(salidas.HasValue, New ObjectParameter("Salidas", salidas), New ObjectParameter("Salidas", GetType(Boolean)))

        Dim activasParameter As ObjectParameter = If(activas.HasValue, New ObjectParameter("Activas", activas), New ObjectParameter("Activas", GetType(Boolean)))

        Dim fechaDesdeParameter As ObjectParameter = If(fechaDesde.HasValue, New ObjectParameter("FechaDesde", fechaDesde), New ObjectParameter("FechaDesde", GetType(Date)))

        Dim fechaHastaParameter As ObjectParameter = If(fechaHasta.HasValue, New ObjectParameter("FechaHasta", fechaHasta), New ObjectParameter("FechaHasta", GetType(Date)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of ObtenerResumenPesadas_Result)("ObtenerResumenPesadas", iDProductoParameter, iDCosechaParameter, iDPlantaParameter, iDEntidadParameter, entradasParameter, salidasParameter, activasParameter, fechaDesdeParameter, fechaHastaParameter)
    End Function

End Class
