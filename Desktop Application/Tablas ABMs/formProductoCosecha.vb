Public Class formProductoCosecha

#Region "Declarations"

    Private mdbContext As New CSPesajeContext(True)
    Private mProducto_CosechaActual As Producto_Cosecha

    Private mIsNew As Boolean
    Private mIsLoading As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(EditMode As Boolean, ByRef ParentForm As Form, IDProducto As Byte, IDCosecha As Byte)
        mIsLoading = True
        mEditMode = EditMode

        mIsNew = (IDCosecha = 0)
        If mIsNew Then
            ' Es Nuevo
            mProducto_CosechaActual = New Producto_Cosecha With {
                .IDProducto = IDProducto,
                .Inicio = DateAndTime.Today,
                .Fin = DateAndTime.Today,
                .EsActivo = True
            }
            mdbContext.Producto_Cosecha.Add(mProducto_CosechaActual)
        Else
            mProducto_CosechaActual = mdbContext.Producto_Cosecha.Find(IDProducto, IDCosecha)
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
            Return
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = Not mEditMode
        buttonCerrar.Visible = Not mEditMode

        ComboBoxCosecha.Enabled = mIsNew

        DateTimePickerInicio.Enabled = mEditMode
        DateTimePickerFin.Enabled = mEditMode
        CheckBoxEsActivo.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Cosecha(ComboBoxCosecha, Nothing, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_DATE, False, True)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mProducto_CosechaActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mProducto_CosechaActual
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxCosecha, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDCosecha)
            DateTimePickerInicio.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.Inicio)
            DateTimePickerFin.Value = CS_ValueTranslation.FromObjectDateToControlDateTimePicker(.Fin)
            CheckBoxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mProducto_CosechaActual
            .IDCosecha = CS_ValueTranslation.FromControlComboBoxToObjectByte(ComboBoxCosecha.SelectedValue).Value
            .Inicio = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(DateTimePickerInicio.Value).Value
            .Fin = CS_ValueTranslation.FromControlDateTimePickerToObjectDate(DateTimePickerFin.Value).Value
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(CheckBoxEsActivo.CheckState)
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
                pFillAndRefreshLists.ProductosCosechasLoad()
                formProducto.CosechasRefreshData(mdbContext, mProducto_CosechaActual.IDCosecha)
                Me.Close()

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.PrimaryKeyViolation
                        MsgBox("No se pueden guardar los cambios porque ya existe la Cosecha en el Producto.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                End Select
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
            End Try
        Else
            Me.Close()
        End If
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        If ComboBoxCosecha.SelectedIndex = -1 Then
            MessageBox.Show("Debe especificar la Cosecha.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxCosecha.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class