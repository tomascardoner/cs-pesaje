Imports System.Data.Entity
Imports System.Data.Entity.Core.EntityClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Partial Public Class CSPesajeContext
    Inherits DbContext

    Public Shared Property ConnectionString As String

    Public Sub New(ByVal UseCustomConnectionString As Boolean)
        MyBase.New(ConnectionString)
    End Sub

    Public Shared Sub CreateConnectionString(ByVal Provider As String, ByVal ProviderConnectionString As String)
        Dim ecb As EntityConnectionStringBuilder = New EntityConnectionStringBuilder()

        ecb.Metadata = String.Format("res://*/{0}.csdl|res://*/{0}.ssdl|res://*/{0}.msl", "CSPesaje")
        ecb.Provider = Provider
        ecb.ProviderConnectionString = ProviderConnectionString

        ConnectionString = ecb.ConnectionString
    End Sub
End Class

Partial Public Class OrigenDestino
    Public ReadOnly Property DomicilioCompleto() As String
        Get
            Dim ReturnValue As String

            ReturnValue = Domicilio

            Return ReturnValue
        End Get
    End Property
End Class

Partial Public Class Pesada_Analisis
    Public Sub CalcularMermas()
        Dim KilogramoNeto As Integer
        Dim KilogramoFinal As Integer

        If Me.Pesada.KilogramoNeto.HasValue Then
            KilogramoNeto = Me.Pesada.KilogramoNeto.Value
            Select Case Me.Pesada.Tipo
                Case Constantes.PESADA_TIPO_ENTRADA
                    KilogramoFinal = KilogramoNeto
                    With Me.Pesada.Producto
                        ' MERMA VOLÁTIL
                        If .MermaVolatil Is Nothing Then
                            ' El producto no especifica merma volátil
                            Me.MermaVolatilKilogramo = Nothing
                        Else
                            Me.MermaVolatilKilogramo = CInt(KilogramoNeto * .MermaVolatil.Value / 100)
                        End If
                        KilogramoFinal -= Me.MermaVolatilKilogramo.Value

                        ' HUMEDAD
                        If .MermaHumedadBase Is Nothing Then
                            ' El producto no especifica base de humedad
                            Me.MermaHumedadPorcentaje = Nothing
                            Me.MermaHumedadKilogramo = Nothing
                        Else
                            If Me.Humedad Is Nothing Then
                                ' La pesada no especifica humedad
                                Me.MermaHumedadPorcentaje = 0
                                Me.MermaHumedadKilogramo = 0
                            Else
                                If Me.Humedad <= .MermaHumedadBase Then
                                    ' La humedad especificada es menor o igual a la Base, por lo tanto, no hay mermas
                                    Me.MermaHumedadPorcentaje = 0
                                    Me.MermaHumedadKilogramo = 0
                                Else
                                    ' El producto está húmedo. Primero aplico la merma por manipuleo
                                    Me.MermaHumedadPorcentaje = .MermaHumedadManipuleo
                                    ' Busco la humedad correpondiente a la pesada en la tabla de mermas del producto
                                    Using dbContext As New CSPesajeContext(True)
                                        Dim Producto_HumedadActual As Producto_Humedad
                                        Producto_HumedadActual = dbContext.Producto_Humedad.Find(.IDProducto, Me.Humedad)
                                        If Producto_HumedadActual Is Nothing Then
                                            MsgBox(String.Format("No está especificada la merma para una humedad del {0} para el producto: {1}.", Microsoft.VisualBasic.FormatPercent(Me.Humedad), .Nombre), MsgBoxStyle.Exclamation, My.Application.Info.Title)
                                        Else
                                            Me.MermaHumedadPorcentaje += Producto_HumedadActual.Merma
                                        End If
                                    End Using
                                    Me.MermaHumedadKilogramo = CInt(KilogramoNeto * Me.MermaHumedadPorcentaje / 100)
                                    KilogramoFinal -= Me.MermaHumedadKilogramo.Value
                                End If
                            End If
                        End If

                        ' ZARANDA
                        If .MermaVolatil Is Nothing Then
                            ' El producto no especifica merma volátil, asumo que no es un cereal, y por eso no aplica zaranda
                            Me.MermaZarandaKilogramo = Nothing
                        Else
                            If Me.Zaranda Is Nothing Then
                                ' El producto no especifica zarandeo
                                Me.MermaZarandaKilogramo = 0
                            Else
                                Me.MermaZarandaKilogramo = CInt(KilogramoNeto * (Me.Zaranda / 100))
                                KilogramoFinal -= Me.MermaZarandaKilogramo.Value
                            End If
                        End If
                    End With
                Case Constantes.PESADA_TIPO_SALIDA
                    KilogramoFinal = -KilogramoNeto
            End Select
            Me.Pesada.KilogramoFinal = KilogramoFinal
        Else
            Me.MermaVolatilKilogramo = Nothing
            Me.MermaHumedadPorcentaje = Nothing
            Me.MermaHumedadKilogramo = Nothing
            Me.MermaZarandaKilogramo = Nothing
            Me.Pesada.KilogramoFinal = Nothing
        End If
    End Sub
End Class

Partial Public Class Pesada_Acondicionamiento
    Public Function CalcularAcondicionamiento() As Boolean
        Dim Cosecha_Producto_TarifaActual As New Cosecha_Producto_Tarifa

        ' Primero debo determinar que tarifa voy a aplicar
        If Me.TarifaManual Then
            ' Se especificó una tarifa manual, así que tomo esa para hacer el cálculo
            Using dbContext As New CSPesajeContext(True)
                Cosecha_Producto_TarifaActual = dbContext.Cosecha_Producto_Tarifa.Find(Me.Pesada.IDCosecha, Me.Pesada.IDProducto, Me.TarifaIndice)
            End Using
        Else
            ' Hay que buscar la tarifa que mejor aplique
            Dim listCosecha_Producto_Tarifa As List(Of Cosecha_Producto_Tarifa)
            Dim FechaPesada As Date

            FechaPesada = CS_ValueTranslation.FromDateTimeToDate(Me.Pesada.FechaHoraInicio)

            Using dbContext As New CSPesajeContext(True)
                listCosecha_Producto_Tarifa = dbContext.Cosecha_Producto_Tarifa.Where(Function(cpt) cpt.IDCosecha = Me.Pesada.IDCosecha.Value And cpt.IDProducto = Me.Pesada.IDProducto).ToList
            End Using

            ' Debo buscar en el siguiente orden
            ' - Filtrar las que coincida el rango de fechas con la fecha del movimiento o que no tengan un rango especificado
            listCosecha_Producto_Tarifa = listCosecha_Producto_Tarifa.Where(Function(cpt) (cpt.FechaDesde Is Nothing OrElse cpt.FechaDesde.Value <= FechaPesada) And (cpt.FechaHasta Is Nothing OrElse cpt.FechaHasta.Value >= FechaPesada)).ToList
            ' - Filtrar los que coincidan con la Planta
            listCosecha_Producto_Tarifa = listCosecha_Producto_Tarifa.Where(Function(cpt) cpt.IDPlanta.Value = Me.Pesada.IDPlanta.Value).ToList
            ' - Filtrar los que coincidan con la Entidad
            listCosecha_Producto_Tarifa = listCosecha_Producto_Tarifa.Where(Function(cpt) cpt.IDEntidad Is Nothing OrElse cpt.IDEntidad.Value = Me.Pesada.Titular_IDEntidad).ToList
            ' - Filtrar los que coincidan con el Origen/Destino
            listCosecha_Producto_Tarifa = listCosecha_Producto_Tarifa.Where(Function(cpt) cpt.IDOrigenDestino Is Nothing OrElse cpt.IDOrigenDestino.Value = Me.Pesada.IDOrigenDestino.Value).ToList
            ' - Ordenar por Entidad DESC (para darle prioridad a las que especifican Entidad), OrigenDestino DESC, Indice
            listCosecha_Producto_Tarifa = listCosecha_Producto_Tarifa.OrderByDescending(Function(cpt) cpt.IDEntidad).OrderByDescending(Function(cpt) cpt.IDOrigenDestino).OrderBy(Function(cpt) cpt.Indice).ToList
            ' Seleccionar la primer tarifa
            If listCosecha_Producto_Tarifa.Count > 0 Then
                Cosecha_Producto_TarifaActual = listCosecha_Producto_Tarifa.First
            End If
        End If

        If Cosecha_Producto_TarifaActual Is Nothing Then
            Return False
        Else
            Dim KilogramoNeto As Integer
            KilogramoNeto = Me.Pesada.KilogramoNeto.Value
            With Cosecha_Producto_TarifaActual
                Me.TarifaIndice = .Indice

                ' Paritaria
                Me.ParitariaTarifa = .TarifaParitariaImporte
                Me.ParitariaImporte = CS_ValueTranslation.FromDoubleToRoundedCurrency((KilogramoNeto / 100) * Me.ParitariaTarifa)

                ' Calculo el Zarandeo, Fumigado y Mezcla antes del Secado porque en las Escalas de Secado,
                ' según el caso, tengo que poner en cero alguna de estas tarifas

                ' Zarandeo
                If Me.Pesada.Pesada_Analisis.Zaranda.HasValue Then
                    Me.ZarandeoTarifa = .TarifaZarandeoImporte
                    Me.ZarandeoImporte = CS_ValueTranslation.FromDoubleToRoundedCurrency((KilogramoNeto / 100) * Me.ZarandeoTarifa)
                Else
                    Me.ZarandeoTarifa = 0
                    Me.ZarandeoImporte = 0
                End If

                ' Fumigado
                If Me.Pesada.Pesada_Analisis.Fumigado.HasValue AndAlso Me.Pesada.Pesada_Analisis.Fumigado Then
                    Me.FumigadoTarifa = .TarifaFumigadoImporte
                    Me.FumigadoImporte = CS_ValueTranslation.FromDoubleToRoundedCurrency((KilogramoNeto / 100) * Me.FumigadoTarifa)
                Else
                    Me.FumigadoTarifa = 0
                    Me.FumigadoImporte = 0
                End If

                ' Mezclado
                If Me.Pesada.Pesada_Analisis.Mezclado.HasValue AndAlso Me.Pesada.Pesada_Analisis.Mezclado Then
                    Me.MezclaTarifa = .TarifaMezclaImporte
                    Me.MezclaImporte = CS_ValueTranslation.FromDoubleToRoundedCurrency((KilogramoNeto / 100) * Me.MezclaTarifa)
                Else
                    Me.MezclaTarifa = 0
                    Me.MezclaImporte = 0
                End If

                ' Secado
                If Me.Pesada.Producto.MermaHumedadBase.HasValue AndAlso Me.Pesada.Pesada_Analisis.Humedad.HasValue AndAlso Me.Pesada.Pesada_Analisis.Humedad > Me.Pesada.Producto.MermaHumedadBase Then
                    ' Tarifa fija por Humedad
                    Me.SecadoTarifa = Cosecha_Producto_TarifaActual.TarifaSecadoInicialImporte
                    Me.SecadoImporte = CS_ValueTranslation.FromDoubleToRoundedCurrency((KilogramoNeto / 100) * Me.SecadoTarifa)

                    ' Calcular tarifa por punto de exceso de Humedad
                    If Me.Pesada.Pesada_Analisis.Humedad <= (Cosecha_Producto_TarifaActual.TarifaSecadoHumedadBase + Cosecha_Producto_TarifaActual.TarifaSecadoHumedadMargenLibre) Then
                        Me.HumedadExcesoReal = 0
                    Else
                        Me.HumedadExcesoReal = Math.Round(Me.Pesada.Pesada_Analisis.Humedad.Value - Me.Pesada.Producto.MermaHumedadBase.Value, 1)
                    End If
                    Me.HumedadExcesoCalculo = Me.HumedadExcesoReal

                    ' Redeondeo de punto
                    Select Case Cosecha_Producto_TarifaActual.TarifaSecadoHumedadRedondeoPuntoTipo
                        Case Constantes.PRODUCTO_TARIFA_SECADO_REDONDEOPUNTO_TIPO_NINGUNO

                        Case Constantes.PRODUCTO_TARIFA_SECADO_REDONDEOPUNTO_TIPO_ENTERO
                            Me.HumedadExcesoCalculo = Math.Round(Me.HumedadExcesoCalculo)

                        Case Constantes.PRODUCTO_TARIFA_SECADO_REDONDEOPUNTO_TIPO_SUPERIOR
                            If Me.HumedadExcesoCalculo > Fix(Me.HumedadExcesoCalculo) Then
                                Me.HumedadExcesoCalculo = Fix(Me.HumedadExcesoCalculo) + 1
                            End If

                        Case Constantes.PRODUCTO_TARIFA_SECADO_REDONDEOPUNTO_TIPO_INFERIOR
                            If Me.HumedadExcesoCalculo > Fix(Me.HumedadExcesoCalculo) Then
                                Me.HumedadExcesoCalculo = Fix(Me.HumedadExcesoCalculo)
                            End If
                    End Select

                    Select Case Cosecha_Producto_TarifaActual.TarifaSecadoTipo
                        Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_FIJA
                            Me.SecadoExcesoTarifa = Cosecha_Producto_TarifaActual.TarifaSecadoPuntoExcesoImporte
                            Me.SecadoExcesoImporte = CS_ValueTranslation.FromDoubleToRoundedCurrency((KilogramoNeto / 100) * CSng(Me.HumedadExcesoCalculo) * Me.SecadoExcesoTarifa)

                        Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA
                            If Me.Pesada.Pesada_Analisis.Humedad >= Cosecha_Producto_TarifaActual.TarifaSecadoHumedadBase + Cosecha_Producto_TarifaActual.TarifaSecadoHumedadMargenLibre Then
                                Dim Cosecha_Producto_TarifaEscalaActual As Cosecha_Producto_TarifaEscala

                                Using dbContext As New CSPesajeContext(True)
                                    Cosecha_Producto_TarifaEscalaActual = dbContext.Cosecha_Producto_TarifaEscala.Where(Function(cpte) cpte.IDCosecha = Me.Pesada.IDCosecha.Value And cpte.IDProducto = Me.Pesada.IDProducto And cpte.Indice = Me.TarifaIndice And cpte.HumedadExcesoInicio <= Me.HumedadExcesoReal).OrderByDescending(Function(cpte) cpte.HumedadExcesoInicio).First
                                End Using
                                If Cosecha_Producto_TarifaEscalaActual Is Nothing Then
                                    Me.SecadoExcesoTarifa = 0
                                    Me.SecadoExcesoImporte = 0
                                Else
                                    Select Case Cosecha_Producto_TarifaActual.TarifaSecadoTipo
                                        Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_PORPUNTO
                                        Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_COMPLETA
                                            Me.SecadoExcesoTarifa = Cosecha_Producto_TarifaEscalaActual.Tarifa
                                            Me.SecadoExcesoImporte = CS_ValueTranslation.FromDoubleToRoundedCurrency((KilogramoNeto / 100) * Me.HumedadExcesoCalculo * Me.SecadoExcesoTarifa)
                                        Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_FIJO_SECADO
                                            Me.SecadoExcesoTarifa = Cosecha_Producto_TarifaEscalaActual.Tarifa
                                            Me.SecadoExcesoImporte = CS_ValueTranslation.FromDoubleToRoundedCurrency((KilogramoNeto / 100) * Me.SecadoExcesoTarifa)
                                        Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_FIJO_SECADOYZARANDEO
                                            Me.ZarandeoTarifa = 0
                                            Me.ZarandeoImporte = 0
                                            Me.SecadoExcesoTarifa = Cosecha_Producto_TarifaEscalaActual.Tarifa
                                            Me.SecadoExcesoImporte = CS_ValueTranslation.FromDoubleToRoundedCurrency((KilogramoNeto / 100) * Me.SecadoExcesoTarifa)
                                        Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_FIJO_TODOCONCEPTO
                                            Me.ParitariaTarifa = 0
                                            Me.ParitariaImporte = 0
                                            Me.ZarandeoTarifa = 0
                                            Me.ZarandeoImporte = 0
                                            Me.FumigadoTarifa = 0
                                            Me.FumigadoImporte = 0
                                            Me.MezclaTarifa = 0
                                            Me.MezclaImporte = 0
                                            Me.SecadoExcesoTarifa = Cosecha_Producto_TarifaEscalaActual.Tarifa
                                            Me.SecadoExcesoImporte = CS_ValueTranslation.FromDoubleToRoundedCurrency((KilogramoNeto / 100) * Me.SecadoExcesoTarifa)
                                    End Select
                                End If
                            End If
                    End Select
                Else
                    Me.SecadoTarifa = 0
                    Me.SecadoImporte = 0
                    Me.HumedadExcesoReal = 0
                    Me.HumedadExcesoCalculo = 0
                    Me.SecadoExcesoTarifa = 0
                    Me.SecadoExcesoImporte = 0
                End If

                ' Importe Total
                Me.ImporteTotal = Me.ParitariaImporte + Me.SecadoImporte + Me.SecadoExcesoImporte + Me.ZarandeoImporte + Me.FumigadoImporte + Me.MezclaImporte
            End With
            Return True
        End If
    End Function
End Class

Partial Public Class Reporte
    Friend Property ReportObject As ReportDocument

    Private mRecordSelectionFormula As String

    Friend Property RecordSelectionFormula() As String
        Get
            Return mRecordSelectionFormula
        End Get
        Set(ByVal value As String)
            mRecordSelectionFormula = value
            ReportObject.RecordSelectionFormula = value
        End Set
    End Property

    Friend Function Open(ByVal PathAndFileName As String) As Boolean
        If Not My.Computer.FileSystem.FileExists(PathAndFileName) Then
            Return False
        End If

        Try
            ReportObject = New ReportDocument

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al crear el objeto del reporte." & vbCrLf & "Probablemente, esto se deba a que no estan correctamente instaladas las librerías de Crystal Reports.")
            Return False
        End Try

        Try
            ReportObject.Load(PathAndFileName)

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al cargar el reporte.")
            Return False
        End Try

        For Each ParametroActual As ReporteParametro In Me.ReporteParametros
            For Each ParameterFieldActual As ParameterField In ReportObject.ParameterFields
                With ParameterFieldActual
                    If CStr(IIf(.ParameterType = ParameterType.StoreProcedureParameter, "@", "")) & ParametroActual.IDParametro.TrimEnd = .ParameterFieldName Then
                        Select Case ParametroActual.Tipo
                            'Case REPORTE_PARAMETRO_TIPO_COMPANY
                            '    .AddCurrentValue pParametro.CompanyName
                            'Case REPORTE_PARAMETRO_TIPO_TITLE
                            '    .AddCurrentValue Titulo
                            'Case REPORTE_PARAMETRO_TIPO_CONDITION_TEXT
                            '    .AddCurrentValue GetConditionText()
                            Case Else
                                Select Case .ParameterValueType
                                    Case ParameterValueKind.CurrencyParameter, ParameterValueKind.NumberParameter
                                        If ParametroActual.Valor Is Nothing Then
                                            .CurrentValues.AddValue(Nothing)
                                        Else
                                            .CurrentValues.AddValue(CDec(ParametroActual.Valor))
                                        End If
                                    Case ParameterValueKind.DateTimeParameter, ParameterValueKind.DateParameter, ParameterValueKind.TimeParameter
                                        If ParametroActual.Valor Is Nothing Then
                                            Select Case .ParameterType
                                                Case ParameterType.ReportParameter
                                                    .CurrentValues.AddValue(New Date(9999, 1, 1))
                                                Case ParameterType.StoreProcedureParameter
                                                    .CurrentValues.AddValue(Nothing)
                                            End Select
                                        Else
                                            Select Case ParametroActual.Tipo
                                                Case Constantes.REPORTE_PARAMETRO_TIPO_DATETIME
                                                    .CurrentValues.AddValue(CDate(ParametroActual.Valor))
                                                Case Constantes.REPORTE_PARAMETRO_TIPO_DATE
                                                    .CurrentValues.AddValue(CDate(ParametroActual.Valor))
                                                Case Constantes.REPORTE_PARAMETRO_TIPO_TIME
                                                    .CurrentValues.AddValue(CDate("1900/01/01 " & CStr(ParametroActual.Valor)))
                                                Case Constantes.REPORTE_PARAMETRO_TIPO_YEAR_MONTH_FROM, Constantes.REPORTE_PARAMETRO_TIPO_YEAR_MONTH_TO
                                                    .CurrentValues.AddValue(CDate(ParametroActual.Valor))
                                            End Select
                                        End If
                                    Case ParameterValueKind.StringParameter
                                        .CurrentValues.AddValue(CStr(ParametroActual.Valor))
                                    Case ParameterValueKind.BooleanParameter
                                        .CurrentValues.AddValue(CBool(ParametroActual.Valor))
                                End Select
                        End Select
                        Exit For
                    End If
                End With
            Next
        Next

        'ReportObject.EnableParameterPrompting = False
        Return True

    End Function

    Friend Function SetDatabaseConnection(ByVal ServerName As String, ByVal DatabaseName As String, ByVal UserID As String, ByVal Password As String) As Boolean
        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table

        With crConnectionInfo
            .ServerName = ServerName
            .DatabaseName = DatabaseName
            .UserID = UserID
            .Password = Password
        End With

        Try
            CrTables = ReportObject.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next
            Return True

        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al establecer la conexión a la base de datos del Reporte.")
            Return False
        End Try
    End Function
End Class

Partial Public Class ReporteParametro
    Private mValor As Object = Nothing
    Private mValorParaMostrar As String

    Public Property Valor As Object
        Get
            If mValor Is Nothing Then
                ' El valor no está inicializado, sí que verifico que no haya un valor predeterminado
                Select Case Me.Tipo
                    Case Constantes.REPORTE_PARAMETRO_PERSONA
                    Case Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER
                        If Not Me.ValorPredeterminadoNumeroEntero Is Nothing Then
                            mValor = Me.ValorPredeterminadoNumeroEntero
                        End If
                    Case Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL
                        If Not Me.ValorPredeterminadoNumeroDecimal Is Nothing Then
                            mValor = Me.ValorPredeterminadoNumeroDecimal
                        End If
                    Case Constantes.REPORTE_PARAMETRO_TIPO_MONEY
                        If Not Me.ValorPredeterminadoMoneda Is Nothing Then
                            mValor = Me.ValorPredeterminadoMoneda
                        End If
                    Case Constantes.REPORTE_PARAMETRO_TIPO_DATETIME, Constantes.REPORTE_PARAMETRO_TIPO_DATE, Constantes.REPORTE_PARAMETRO_TIPO_TIME
                        If Not Me.ValorPredeterminadoFechaHora Is Nothing Then
                            mValor = Me.ValorPredeterminadoFechaHora
                        End If
                    Case Constantes.REPORTE_PARAMETRO_TIPO_YEAR_MONTH_FROM, Constantes.REPORTE_PARAMETRO_TIPO_YEAR_MONTH_TO
                    Case Constantes.REPORTE_PARAMETRO_TIPO_SINO
                        If Not Me.ValorPredeterminadoSiNo Is Nothing Then
                            mValor = Me.ValorPredeterminadoSiNo
                        End If
                    Case Else
                End Select
            End If
            Return mValor
        End Get
        Set(value As Object)
            mValor = value
        End Set
    End Property

    Public Property ValorParaMostrar As String
        Get
            If mValor Is Nothing Then
                Return ""
            Else
                Select Case Me.Tipo
                    Case Constantes.REPORTE_PARAMETRO_PERSONA
                        Return mValorParaMostrar
                    Case Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_INTEGER
                        Return FormatNumber(mValor, 0)
                    Case Constantes.REPORTE_PARAMETRO_TIPO_NUMBER_DECIMAL
                        Return FormatNumber(mValor)
                    Case Constantes.REPORTE_PARAMETRO_TIPO_MONEY
                        Return FormatCurrency(mValor)
                    Case Constantes.REPORTE_PARAMETRO_TIPO_DATETIME
                        Return FormatDateTime(CDate(mValor), DateFormat.ShortDate) & " " & FormatDateTime(CDate(mValor), DateFormat.ShortTime)
                    Case Constantes.REPORTE_PARAMETRO_TIPO_DATE
                        Return FormatDateTime(CDate(mValor), DateFormat.ShortDate)
                    Case Constantes.REPORTE_PARAMETRO_TIPO_TIME
                        Return FormatDateTime(CDate(mValor), DateFormat.ShortTime)
                    Case Constantes.REPORTE_PARAMETRO_TIPO_YEAR_MONTH_FROM
                        Return ""
                    Case Constantes.REPORTE_PARAMETRO_TIPO_YEAR_MONTH_TO
                        Return ""
                    Case Constantes.REPORTE_PARAMETRO_TIPO_SINO
                        If CBool(mValor) Then
                            Return My.Resources.STRING_YES
                        Else
                            Return My.Resources.STRING_NO
                        End If
                    Case Else
                        Return ""
                End Select
            End If
        End Get

        Set(value As String)
            mValorParaMostrar = value
        End Set
    End Property
End Class