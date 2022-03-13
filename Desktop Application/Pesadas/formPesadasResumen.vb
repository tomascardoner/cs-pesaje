Public Class formPesadasResumen
    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.IMAGE_RESUMEN_32)

        pFillAndRefreshLists.Producto(ComboBoxProducto, Nothing, True, False, False, False)
        pFillAndRefreshLists.Cosecha(ComboBoxCosecha, Nothing, Nothing, DateTime.MinValue, True, False, True)
        pFillAndRefreshLists.Planta(ComboBoxPlanta, Nothing, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, True, False)
        pFillAndRefreshLists.Entidad(ComboBoxTitular, Nothing, False, True, False, False, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_INTEGER, False, True, True, False)
    End Sub

    Private Sub ButtonCalcular_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        If ComboBoxProducto.SelectedIndex = -1 Then
            MessageBox.Show("Debe especificar el Producto.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxProducto.Focus()
            Return
        End If
        If ComboBoxCosecha.SelectedIndex = -1 Then
            MessageBox.Show("Debe especificar la Cosecha.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxCosecha.Focus()
            Return
        End If
        If ComboBoxPlanta.SelectedIndex = -1 Then
            MessageBox.Show("Debe especificar la Planta.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxPlanta.Focus()
            Return
        End If
        If ComboBoxTitular.SelectedIndex = -1 Then
            MessageBox.Show("Debe especificar el Titular.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxTitular.Focus()
            Return
        End If
        If CheckBoxTipoEntradas.Checked = False AndAlso CheckBoxTipoSalidas.Checked = False Then
            MessageBox.Show("Debe especificar si suma Entradas y/o Salidas.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Calcular()
    End Sub

    Private Sub Calcular()
        Try
            Using dbContext As New CSPesajeContext(True)
                Dim result As uspPesadaObtenerResumen_Result
                Dim idProducto As Byte = CType(ComboBoxProducto.SelectedItem, Producto).IDProducto
                Dim idCosecha As Byte? = CType(ComboBoxCosecha.SelectedItem, Cosecha).IDCosecha
                Dim idPlanta As Byte? = CType(ComboBoxPlanta.SelectedItem, Planta).IDPlanta
                Dim idEntidad As Integer? = CType(ComboBoxTitular.SelectedItem, Entidad).IDEntidad
                Dim fechaDesde As Date?
                Dim fechaHasta As Date?

                If idCosecha = CardonerSistemas.FIELD_VALUE_ALL_BYTE Then
                    idCosecha = Nothing
                End If
                If idPlanta = CardonerSistemas.FIELD_VALUE_ALL_BYTE Then
                    idPlanta = Nothing
                End If
                If idEntidad = CardonerSistemas.FIELD_VALUE_ALL_INTEGER Then
                    idEntidad = Nothing
                End If
                If DateTimePickerFechaDesde.Checked Then
                    fechaDesde = DateTimePickerFechaDesde.Value
                Else
                    fechaDesde = Nothing
                End If
                If DateTimePickerFechaHasta.Checked Then
                    fechaHasta = DateTimePickerFechaHasta.Value
                Else
                    fechaHasta = Nothing
                End If

                result = dbContext.uspPesadaObtenerResumen(idProducto, idCosecha, idPlanta, idEntidad, CheckBoxTipoEntradas.Checked, CheckBoxTipoSalidas.Checked, fechaDesde, fechaHasta).FirstOrDefault()

                If result IsNot Nothing Then
                    TextBoxKilogramosEntradasBrutas.Text = FormatNumber(result.KilogramosEntradasBrutos, 0)
                    TextBoxKilogramosEntradasNetas.Text = FormatNumber(result.KilogramosEntradasNetos, 0)
                    TextBoxKilogramosSalidas.Text = FormatNumber(result.KilogramosSalidas, 0)
                    TextBoxKilogramosTotal.Text = FormatNumber(result.KilogramosEntradasNetos - result.KilogramosSalidas, 0)

                    TextBoxCantidadEntradas.Text = FormatNumber(result.CantidadEntradas, 0)
                    TextBoxCantidadSalidas.Text = FormatNumber(result.CantidadSalidas, 0)
                    TextBoxCantidadTotal.Text = FormatNumber(result.CantidadEntradas + result.CantidadSalidas, 0)
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class