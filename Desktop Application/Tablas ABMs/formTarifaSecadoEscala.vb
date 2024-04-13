Public Class formTarifaSecadoEscala

#Region "Declarations"

    Private mCosecha_Producto_TarifaActual As Cosecha_Producto_Tarifa
    Private mCosecha_Producto_TarifaEscalaActual As Cosecha_Producto_TarifaEscala

    Private mParentEditMode As Boolean = False
    Private mEditMode As Boolean = False
    Private mIsNew As Boolean = False

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(ByVal ParentEditMode As Boolean, ByVal EditMode As Boolean, ByRef ParentForm As Form, ByRef Cosecha_Producto_TarifaActual As Cosecha_Producto_Tarifa, ByRef Cosecha_Producto_TarifaEscalaActual As Cosecha_Producto_TarifaEscala)
        mParentEditMode = ParentEditMode
        mEditMode = EditMode
        mIsNew = (Cosecha_Producto_TarifaEscalaActual.HumedadExcesoInicio = 0)

        mCosecha_Producto_TarifaActual = Cosecha_Producto_TarifaActual
        mCosecha_Producto_TarifaEscalaActual = Cosecha_Producto_TarifaEscalaActual

        'Me.MdiParent = pFormMDIMain
        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        SetDataFromObjectToControls()

        ChangeMode()
        Me.ShowDialog(ParentForm)
        'If Me.WindowState = FormWindowState.Minimized Then
        '    Me.WindowState = FormWindowState.Normal
        'End If
        'Me.Focus()
    End Sub

    Private Sub ChangeMode()
        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mParentEditMode AndAlso Not mEditMode)
        buttonCerrar.Visible = Not mEditMode

        doubletextboxHumedadExcesoInicio.ReadOnly = Not (mIsNew AndAlso mEditMode)
        radiobuttonTipoPunto.Enabled = mEditMode
        radiobuttonTipoCompleta.Enabled = mEditMode
        radiobuttonTipoSecado.Enabled = mEditMode
        radiobuttonTipoSecadoZarandeo.Enabled = mEditMode
        radiobuttonTipoFijo.Enabled = mEditMode
        currencytextboxTarifa.ReadOnly = Not mEditMode
    End Sub

    Private Sub FormEnd(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mCosecha_Producto_TarifaActual = Nothing
        mCosecha_Producto_TarifaEscalaActual = Nothing

        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mCosecha_Producto_TarifaEscalaActual
            doubletextboxHumedadExcesoInicio.DoubleValue = .HumedadExcesoInicio
            Select Case .Tipo
                Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_PORPUNTO
                    radiobuttonTipoPunto.Checked = True
                Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_COMPLETA
                    radiobuttonTipoCompleta.Checked = True
                Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_FIJO_SECADO
                    radiobuttonTipoSecado.Checked = True
                Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_FIJO_SECADOYZARANDEO
                    radiobuttonTipoSecadoZarandeo.Checked = True
                Case Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_FIJO_TODOCONCEPTO
                    radiobuttonTipoFijo.Checked = True
            End Select
            currencytextboxTarifa.DecimalValue = .Tarifa
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mCosecha_Producto_TarifaEscalaActual
            If mIsNew Then
                .HumedadExcesoInicio = Convert.ToDecimal(doubletextboxHumedadExcesoInicio.DoubleValue)
            End If
            If radiobuttonTipoPunto.Checked Then
                .Tipo = Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_PORPUNTO
            ElseIf radiobuttonTipoCompleta.Checked Then
                .Tipo = Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_COMPLETA
            ElseIf radiobuttonTipoSecado.Checked Then
                .Tipo = Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_FIJO_SECADO
            ElseIf radiobuttonTipoSecadoZarandeo.Checked Then
                .Tipo = Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_FIJO_SECADOYZARANDEO
            ElseIf radiobuttonTipoFijo.Checked Then
                .Tipo = Constantes.PRODUCTO_TARIFA_SECADO_TIPO_ESCALA_FIJO_TODOCONCEPTO
            End If
            .Tarifa = currencytextboxTarifa.DecimalValue
        End With
    End Sub

#End Region

#Region "Controls behavior"

    Private Sub FormKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        Select Case e.KeyChar
            Case Microsoft.VisualBasic.ChrW(Keys.Return)
                If mEditMode Then
                    buttonGuardar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
            Case Microsoft.VisualBasic.ChrW(Keys.Escape)
                If mEditMode Then
                    buttonCancelar.PerformClick()
                Else
                    buttonCerrar.PerformClick()
                End If
        End Select
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        mEditMode = True
        ChangeMode()
    End Sub

    Private Sub buttonCerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        If mIsNew AndAlso doubletextboxHumedadExcesoInicio.DoubleValue = 0 Then
            MsgBox("Debe especificar el Exceso de Humedad Inicial.", MsgBoxStyle.Information, My.Application.Info.Title)
            doubletextboxHumedadExcesoInicio.Focus()
            Return
        End If
        If Not (radiobuttonTipoPunto.Checked OrElse radiobuttonTipoCompleta.Checked OrElse radiobuttonTipoSecado.Checked OrElse radiobuttonTipoSecadoZarandeo.Checked OrElse radiobuttonTipoFijo.Checked) Then
            MsgBox("Debe especificar el Tipo de Tarifa.", MsgBoxStyle.Information, My.Application.Info.Title)
            Return
        End If
        If currencytextboxTarifa.DecimalValue = 0 Then
            MsgBox("Debe especificar una Tarifa mayor que cero.", MsgBoxStyle.Information, My.Application.Info.Title)
            currencytextboxTarifa.Focus()
            Return
        End If

        ' Si es un nuevo item agrego el objeto nuevo a la colección del parent
        mCosecha_Producto_TarifaActual.Cosecha_Producto_TarifaEscala.Add(mCosecha_Producto_TarifaEscalaActual)

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        ' Refresco la lista para mostrar los cambios
        If CardonerSistemas.Forms.IsLoaded("formTarifa") Then
            Dim formTarifa As formTarifa = CType(CardonerSistemas.Forms.GetInstance("formTarifa"), formTarifa)
            formTarifa.RefreshData_SecadoEscalas(mCosecha_Producto_TarifaEscalaActual.HumedadExcesoInicio)
            formTarifa = Nothing
        End If

        Me.Close()
    End Sub

#End Region

End Class