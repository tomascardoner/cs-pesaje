Partial Public Class Pesada_Analisis

    Public Sub New()
        Me.MermaVolatilAplica = True
        Me.MermaHumedadAplica = True
        Me.MermaZarandaAplica = True
    End Sub

    Public Sub CalcularMermas(ByRef PesadaActual As Pesada)
        Dim KilogramoNeto As Integer
        Dim KilogramoFinal As Integer
        Dim ProductoActual As Producto
        Dim PlantaActual As Planta

        If PesadaActual.KilogramoNeto.HasValue Then
            KilogramoNeto = PesadaActual.KilogramoNeto.Value
            Select Case PesadaActual.Tipo
                Case Constantes.PESADA_TIPO_ENTRADA, Constantes.PESADA_TIPO_NINGUNA
                    KilogramoFinal = KilogramoNeto

                    ' Obtengo los datos del Producto y de la Planta
                    Using dbContextDatos As New CSPesajeContext(True)
                        ProductoActual = dbContextDatos.Producto.Find(PesadaActual.IDProducto)
                        PlantaActual = dbContextDatos.Planta.Find(PesadaActual.IDPlanta)
                    End Using

                    With ProductoActual
                        ' MERMA VOLÁTIL
                        If .MermaVolatil.HasValue AndAlso Me.MermaVolatilAplica AndAlso PlantaActual.AplicaMermaVolatil Then
                            Me.MermaVolatilKilogramo = CInt(KilogramoNeto * .MermaVolatil.Value / 100)
                        Else
                            ' El producto no especifica merma volátil o la planta no la aplica
                            Me.MermaVolatilKilogramo = 0
                        End If
                        KilogramoFinal -= Me.MermaVolatilKilogramo.Value

                        ' HUMEDAD
                        If .MermaHumedadBase.HasValue AndAlso Me.Humedad.HasValue AndAlso Me.MermaHumedadAplica AndAlso Me.Humedad > .MermaHumedadBase Then
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
                        Else
                            Me.MermaHumedadPorcentaje = 0
                            Me.MermaHumedadKilogramo = 0
                        End If

                        ' ZARANDA
                        If .MermaVolatil.HasValue AndAlso Me.Zaranda.HasValue AndAlso Me.MermaZarandaAplica Then
                            Me.MermaZarandaKilogramo = CInt(KilogramoNeto * (Me.Zaranda / 100))
                            KilogramoFinal -= Me.MermaZarandaKilogramo.Value
                        Else
                            Me.MermaZarandaKilogramo = 0
                        End If
                    End With
                    ProductoActual = Nothing
                    PlantaActual = Nothing

                Case Constantes.PESADA_TIPO_SALIDA
                    KilogramoFinal = -KilogramoNeto
            End Select
            PesadaActual.KilogramoFinal = KilogramoFinal
        Else
            Me.MermaVolatilKilogramo = Nothing
            Me.MermaHumedadPorcentaje = Nothing
            Me.MermaHumedadKilogramo = Nothing
            Me.MermaZarandaKilogramo = Nothing
            PesadaActual.KilogramoFinal = Nothing
        End If
    End Sub

End Class