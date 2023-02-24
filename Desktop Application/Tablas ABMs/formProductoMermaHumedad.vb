Public Class formProductoMermaHumedad

#Region "Declarations"

    Private mdbContext As New CSPesajeContext(True)
    Private mProducto_HumedadActual As Producto_Humedad

    Private mIsNew As Boolean
    Private mIsLoading As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(EditMode As Boolean, ByRef ParentForm As Form, IDProducto As Byte, Humedad As Decimal)
        mIsLoading = True
        mEditMode = EditMode

        mIsNew = (Humedad = 0)
        If mIsNew Then
            ' Es Nuevo
            mProducto_HumedadActual = New Producto_Humedad With {.IDProducto = IDProducto}
            mdbContext.Producto_Humedad.Add(mProducto_HumedadActual)
        Else
            mProducto_HumedadActual = mdbContext.Producto_Humedad.Find(IDProducto, Humedad)
        End If

        CardonerSistemas.Forms.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()

        mIsLoading = False

        ChangeMode()

        Me.ShowDialog(ParentForm)
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Exit Sub
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        DoubleTextBoxHumedad.ReadOnly = Not mIsNew
        DoubleTextBoxMerma.ReadOnly = Not mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mProducto_HumedadActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mProducto_HumedadActual
            CS_ValueTranslation_Syncfusion.FromValueToControl(.Humedad, DoubleTextBoxHumedad)
            CS_ValueTranslation_Syncfusion.FromValueToControl(.Merma, DoubleTextBoxMerma)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mProducto_HumedadActual
            .Humedad = CS_ValueTranslation_Syncfusion.FromControlToDecimal(DoubleTextBoxHumedad).Value
            .Merma = CS_ValueTranslation_Syncfusion.FromControlToDecimal(DoubleTextBoxMerma).Value
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs)
        CType(sender, TextBox).SelectAll()
    End Sub

#End Region

#Region "Main Toolbar"

    Private Sub Editar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.USUARIOGRUPO_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub CerrarOCancelar_Click() Handles buttonCerrar.Click, buttonCancelar.Click
        Me.Close()
    End Sub

    Private Sub Guardar_Click() Handles buttonGuardar.Click
        If Not VerificarDatos() Then
            Return
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            Try
                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista para mostrar los cambios
                formProducto.MermasHumedadRefreshData(mdbContext, mProducto_HumedadActual.Humedad)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.PrimaryKeyViolation
                        MsgBox("No se pueden guardar los cambios porque ya existe una Merma de Humedad con el mismo valor.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                End Select
                Exit Sub

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Exit Sub
            End Try
        End If

        Me.Close()
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        If DoubleTextBoxHumedad.DoubleValue < 9 Then
            MessageBox.Show("La Humedad debe ser mayor a 9.0", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            DoubleTextBoxHumedad.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class