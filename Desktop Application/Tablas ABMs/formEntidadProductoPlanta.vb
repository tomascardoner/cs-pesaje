Public Class formEntidadProductoPlanta

#Region "Declarations"

    Private mdbContext As New CSPesajeContext(True)
    Private mEntidad_Producto_PlantaActual As Entidad_Producto_Planta

    Private mIsNew As Boolean
    Private mIsLoading As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(EditMode As Boolean, ByRef ParentForm As Form, IDEntidad As Integer, IDProducto As Byte, IDPlanta As Byte)
        mIsLoading = True
        mEditMode = EditMode

        mIsNew = (IDProducto = 0)
        If mIsNew Then
            ' Es Nuevo
            mEntidad_Producto_PlantaActual = New Entidad_Producto_Planta With {.IDEntidad = IDEntidad}
            mdbContext.Entidad_Producto_Planta.Add(mEntidad_Producto_PlantaActual)
        Else
            mEntidad_Producto_PlantaActual = mdbContext.Entidad_Producto_Planta.Find(IDEntidad, IDProducto, IDPlanta)
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

        ComboBoxProducto.Enabled = mIsNew
        ComboBoxPlanta.Enabled = mIsNew

        CheckBoxTipoEntrada.Enabled = mEditMode
        CheckBoxTipoSalida.Enabled = mEditMode
        CheckBoxTipoNinguno.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Producto(ComboBoxProducto, Nothing, False, False, False, False)
        pFillAndRefreshLists.Planta(ComboBoxPlanta, Nothing, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, False, False)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mEntidad_Producto_PlantaActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mEntidad_Producto_PlantaActual
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxProducto, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDProducto)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxPlanta, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDPlanta)

            CheckBoxTipoEntrada.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.TipoEntrada)
            CheckBoxTipoSalida.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.TipoSalida)
            CheckBoxTipoNinguno.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.TipoNinguno)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mEntidad_Producto_PlantaActual
            .IDProducto = CS_ValueTranslation.FromControlComboBoxToObjectByte(ComboBoxProducto.SelectedValue).Value
            .IDPlanta = CS_ValueTranslation.FromControlComboBoxToObjectByte(ComboBoxPlanta.SelectedValue).Value

            .TipoEntrada = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(CheckBoxTipoEntrada.CheckState)
            .TipoSalida = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(CheckBoxTipoSalida.CheckState)
            .TipoNinguno = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(CheckBoxTipoNinguno.CheckState)
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
                pFillAndRefreshLists.EntidadesProductosPlantasLoad()
                formEntidad.ProductosPlantasRefreshData(mdbContext, mEntidad_Producto_PlantaActual.IDProducto, mEntidad_Producto_PlantaActual.IDPlanta)

            Catch dbuex As Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.PrimaryKeyViolation
                        MsgBox("No se pueden guardar los cambios porque ya existe el Producto y la Planta en la Entidad.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                End Select
                Return

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CardonerSistemas.ErrorHandler.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Return
            End Try
        End If

        Me.Close()
    End Sub

#End Region

#Region "Extra stuff"

    Private Function VerificarDatos() As Boolean
        If ComboBoxProducto.SelectedIndex = -1 Then
            MessageBox.Show("Debe especificar el Producto.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxProducto.Focus()
            Return False
        End If
        If ComboBoxPlanta.SelectedIndex = -1 Then
            MessageBox.Show("Debe especificar la Planta.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxPlanta.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class