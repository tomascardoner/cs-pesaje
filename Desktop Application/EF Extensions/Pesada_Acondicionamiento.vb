Partial Public Class Pesada_Acondicionamiento

    Public Sub New()
        Me.ParitariaAplica = True
        Me.SecadoAplica = True
        Me.ZarandeoAplica = True
        Me.FumigadoAplica = True
        Me.MezcladoAplica = True
    End Sub

    Public Function CalcularAcondicionamiento(ByRef PesadaActual As Pesada) As Boolean
        Dim Cosecha_Producto_TarifaActual As New Cosecha_Producto_Tarifa
        Dim ProductoActual As Producto
        Dim PesadaActualLocal As Pesada

        PesadaActualLocal = PesadaActual
        If Not PesadaActual.KilogramoNeto.HasValue Then
            Return True
        End If

        ' Primero debo determinar que tarifa voy a aplicar
        If Me.TarifaManual Then
            ' Se especificó una tarifa manual, así que tomo esa para hacer el cálculo
            Using dbContextDatos As New CSPesajeContext(True)
                Cosecha_Producto_TarifaActual = dbContextDatos.Cosecha_Producto_Tarifa.Find(PesadaActual.IDCosecha, PesadaActual.IDProducto, Me.TarifaIndice)
                ProductoActual = dbContextDatos.Producto.Find(PesadaActual.IDProducto)
            End Using
        Else
            ' Hay que buscar la tarifa que mejor aplique
            Dim listCosecha_Producto_Tarifa As List(Of Cosecha_Producto_Tarifa)
            Dim FechaPesada As Date

            FechaPesada = CS_ValueTranslation.FromDateTimeToDate(PesadaActual.FechaHoraInicio)

            Using dbContextDatos As New CSPesajeContext(True)
                listCosecha_Producto_Tarifa = dbContextDatos.Cosecha_Producto_Tarifa.Where(Function(cpt) cpt.IDCosecha = PesadaActualLocal.IDCosecha.Value AndAlso cpt.IDProducto = PesadaActualLocal.IDProducto).ToList
                ProductoActual = dbContextDatos.Producto.Find(PesadaActual.IDProducto)
            End Using

            ' Debo buscar en el siguiente orden
            ' - Filtrar las que coincida el rango de fechas con la fecha del movimiento o que no tengan un rango especificado
            listCosecha_Producto_Tarifa = listCosecha_Producto_Tarifa.Where(Function(cpt) (cpt.FechaDesde Is Nothing OrElse cpt.FechaDesde.Value <= FechaPesada) AndAlso (cpt.FechaHasta Is Nothing OrElse cpt.FechaHasta.Value >= FechaPesada)).ToList
            ' - Filtrar los que coincidan con la Planta
            listCosecha_Producto_Tarifa = listCosecha_Producto_Tarifa.Where(Function(cpt) (Not cpt.IDPlanta.HasValue) OrElse cpt.IDPlanta.Value = PesadaActualLocal.IDPlanta.Value).ToList
            ' - Filtrar los que coincidan con la Entidad
            Dim idEntidad As Integer = CType(IIf(PesadaActualLocal.LiquidacionServicioIDEntidad.HasValue, PesadaActualLocal.LiquidacionServicioIDEntidad, PesadaActualLocal.Titular_IDEntidad), Integer)
            listCosecha_Producto_Tarifa = listCosecha_Producto_Tarifa.Where(Function(cpt) cpt.IDEntidad Is Nothing OrElse cpt.IDEntidad.Value = idEntidad).ToList
            ' - Filtrar los que coincidan con el Origen
            listCosecha_Producto_Tarifa = listCosecha_Producto_Tarifa.Where(Function(cpt) cpt.IDOrigen Is Nothing OrElse (PesadaActualLocal.IDOrigen.HasValue AndAlso cpt.IDOrigen.Value = PesadaActualLocal.IDOrigen.Value)).ToList
            ' - Ordenar por Entidad DESC (para darle prioridad a las que especifican Entidad), Origen DESC, Indice
            listCosecha_Producto_Tarifa = listCosecha_Producto_Tarifa.OrderByDescending(Function(cpt) cpt.IDEntidad).ThenByDescending(Function(cpt) cpt.IDOrigen).ThenBy(Function(cpt) cpt.Indice).ToList
            ' Seleccionar la primer tarifa
            If listCosecha_Producto_Tarifa.Count > 0 Then
                Cosecha_Producto_TarifaActual = listCosecha_Producto_Tarifa.First
            End If
        End If

        If Cosecha_Producto_TarifaActual Is Nothing Then
            Return False
        Else
            Dim KilogramoNeto As Integer
            KilogramoNeto = PesadaActual.KilogramoNeto.Value

            With Cosecha_Producto_TarifaActual
                Me.TarifaIndice = .Indice

                ' Paritaria
                If Me.ParitariaAplica Then
                    Me.ParitariaTarifa = .TarifaParitariaImporte
                    Me.ParitariaImporte = CS_ValueTranslation.FromDoubleToRoundedCurrency((KilogramoNeto / 100) * Me.ParitariaTarifa)
                Else
                    Me.ParitariaTarifa = 0
                    Me.ParitariaImporte = 0
                End If

                ' Si tiene análisis cargado, calculo los servicios:
                If PesadaActual.Pesada_Analisis IsNot Nothing Then

                    ' Calculo el Zarandeo, Fumigado y Mezcla antes del Secado porque en las Escalas de Secado,
                    ' según el caso, tengo que poner en cero alguna de estas tarifas

                    ' Zarandeo
                    If PesadaActual.Pesada_Analisis.Zaranda.HasValue AndAlso PesadaActual.Pesada_Analisis.Zaranda > 0 AndAlso Me.ZarandeoAplica Then
                        Me.ZarandeoTarifa = .TarifaZarandeoImporte
                        Me.ZarandeoImporte = CS_ValueTranslation.FromDoubleToRoundedCurrency((KilogramoNeto / 100) * Me.ZarandeoTarifa)
                    Else
                        Me.ZarandeoTarifa = 0
                        Me.ZarandeoImporte = 0
                    End If

                    ' Fumigado
                    If PesadaActual.Pesada_Analisis.Fumigado.HasValue AndAlso PesadaActual.Pesada_Analisis.Fumigado AndAlso Me.FumigadoAplica Then
                        Me.FumigadoTarifa = .TarifaFumigadoImporte
                        Me.FumigadoImporte = CS_ValueTranslation.FromDoubleToRoundedCurrency((KilogramoNeto / 100) * Me.FumigadoTarifa)
                    Else
                        Me.FumigadoTarifa = 0
                        Me.FumigadoImporte = 0
                    End If

                    ' Mezclado
                    If PesadaActual.Pesada_Analisis.Mezclado.HasValue AndAlso PesadaActual.Pesada_Analisis.Mezclado AndAlso Me.MezcladoAplica Then
                        Me.MezcladoTarifa = .TarifaMezclaImporte
                        Me.MezcladoImporte = CS_ValueTranslation.FromDoubleToRoundedCurrency((KilogramoNeto / 100) * Me.MezcladoTarifa)
                    Else
                        Me.MezcladoTarifa = 0
                        Me.MezcladoImporte = 0
                    End If

                    ' Secado
                    If ProductoActual.MermaHumedadBase.HasValue AndAlso PesadaActual.Pesada_Analisis.Humedad.HasValue AndAlso Me.SecadoAplica AndAlso PesadaActual.Pesada_Analisis.Humedad > ProductoActual.MermaHumedadBase Then
                        ' Tarifa fija por Humedad
                        Me.SecadoTarifa = Cosecha_Producto_TarifaActual.TarifaSecadoInicialImporte
                        Me.SecadoImporte = CS_ValueTranslation.FromDoubleToRoundedCurrency((KilogramoNeto / 100) * Me.SecadoTarifa)

                        ' Calcular tarifa por punto de exceso de Humedad
                        If PesadaActual.Pesada_Analisis.Humedad <= (Cosecha_Producto_TarifaActual.TarifaSecadoHumedadBase + Cosecha_Producto_TarifaActual.TarifaSecadoHumedadMargenLibre) Then
                            Me.HumedadExcesoReal = 0
                        Else
                            Me.HumedadExcesoReal = Math.Round(PesadaActual.Pesada_Analisis.Humedad.Value - ProductoActual.MermaHumedadBase.Value, 1)
                        End If
                        Me.HumedadExcesoCalculo = Me.HumedadExcesoReal

                        ' Redondeo de punto
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
                                If PesadaActual.Pesada_Analisis.Humedad >= Cosecha_Producto_TarifaActual.TarifaSecadoHumedadBase + Cosecha_Producto_TarifaActual.TarifaSecadoHumedadMargenLibre Then
                                    Dim listCosecha_Producto_TarifaEscala As List(Of Cosecha_Producto_TarifaEscala)
                                    Dim Cosecha_Producto_TarifaEscalaActual As Cosecha_Producto_TarifaEscala

                                    Using dbContext As New CSPesajeContext(True)
                                        listCosecha_Producto_TarifaEscala = dbContext.Cosecha_Producto_TarifaEscala.Where(Function(cpte) cpte.IDCosecha = PesadaActualLocal.IDCosecha.Value And cpte.IDProducto = PesadaActualLocal.IDProducto And cpte.Indice = Me.TarifaIndice And cpte.HumedadExcesoInicio <= Me.HumedadExcesoReal).OrderByDescending(Function(cpte) cpte.HumedadExcesoInicio).ToList
                                    End Using

                                    If listCosecha_Producto_TarifaEscala.Count = 0 Then
                                        Me.SecadoExcesoTarifa = 0
                                        Me.SecadoExcesoImporte = 0
                                    Else
                                        ' Selecciono la primer escala para comenzar y ver de que tipo es
                                        Cosecha_Producto_TarifaEscalaActual = listCosecha_Producto_TarifaEscala.First

                                        Select Case Cosecha_Producto_TarifaEscalaActual.Tipo
                                            Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_PORPUNTO
                                                Dim HumedadExcesoACalcular As Decimal
                                                Dim HumedadLimiteSuperior As Decimal
                                                Dim EscalaCount As Integer

                                                EscalaCount = 0
                                                HumedadLimiteSuperior = Me.HumedadExcesoCalculo
                                                Me.SecadoExcesoTarifa = 0
                                                Me.SecadoExcesoImporte = 0
                                                For Each Cosecha_Producto_TarifaEscalaActual In listCosecha_Producto_TarifaEscala
                                                    HumedadExcesoACalcular = HumedadLimiteSuperior - (Cosecha_Producto_TarifaEscalaActual.HumedadExcesoInicio - CDec(0.1))
                                                    If HumedadExcesoACalcular = 0 Then
                                                        Continue For
                                                    End If
                                                    EscalaCount += 1
                                                    Me.SecadoExcesoTarifa += Cosecha_Producto_TarifaEscalaActual.Tarifa
                                                    Me.SecadoExcesoImporte += CS_ValueTranslation.FromDoubleToRoundedCurrency((Me.Pesada.KilogramoNeto.Value / 100) * HumedadExcesoACalcular * Cosecha_Producto_TarifaEscalaActual.Tarifa)
                                                    HumedadLimiteSuperior = (Cosecha_Producto_TarifaEscalaActual.HumedadExcesoInicio - CDec(0.1))
                                                Next
                                                If Me.SecadoExcesoTarifa > 0 Then
                                                    Me.SecadoExcesoTarifa /= EscalaCount
                                                End If

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
                                                Me.MezcladoTarifa = 0
                                                Me.MezcladoImporte = 0
                                                Me.SecadoExcesoTarifa = Cosecha_Producto_TarifaEscalaActual.Tarifa
                                                Me.SecadoExcesoImporte = CS_ValueTranslation.FromDoubleToRoundedCurrency((KilogramoNeto / 100) * Me.SecadoExcesoTarifa)
                                        End Select
                                    End If
                                End If
                        End Select

                        ProductoActual = Nothing
                        PesadaActualLocal = Nothing
                    Else
                        Me.SecadoTarifa = 0
                        Me.SecadoImporte = 0
                        Me.HumedadExcesoReal = 0
                        Me.HumedadExcesoCalculo = 0
                        Me.SecadoExcesoTarifa = 0
                        Me.SecadoExcesoImporte = 0
                    End If
                End If

                ' Importe Total
                Me.ImporteTotal = Me.ParitariaImporte + Me.SecadoImporte + Me.SecadoExcesoImporte + Me.ZarandeoImporte + Me.FumigadoImporte + Me.MezcladoImporte
            End With
            Return True
        End If
    End Function

End Class