Public Class formProductoPlanta

#Region "Declarations"

    Private mdbContext As New CSPesajeContext(True)
    Private mProducto_PlantaActual As Producto_Planta

    Private mIsNew As Boolean
    Private mIsLoading As Boolean
    Private mEditMode As Boolean

#End Region

#Region "Form stuff"

    Friend Sub LoadAndShow(EditMode As Boolean, ByRef ParentForm As Form, IDProducto As Byte, IDPlanta As Byte)
        mIsLoading = True
        mEditMode = EditMode

        mIsNew = (IDPlanta = 0)
        If mIsNew Then
            ' Es Nuevo
            mProducto_PlantaActual = New Producto_Planta With {.IDProducto = IDProducto}
            mdbContext.Producto_Planta.Add(mProducto_PlantaActual)
        Else
            mProducto_PlantaActual = mdbContext.Producto_Planta.Find(IDProducto, IDPlanta)
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

        ComboBoxPlanta.Enabled = mIsNew

        ComboBoxTipoEntrada.Enabled = mEditMode
        ComboBoxTipoSalida.Enabled = mEditMode
        ComboBoxTipoNinguno.Enabled = mEditMode
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Planta(ComboBoxPlanta, Nothing, CardonerSistemas.Constants.FIELD_VALUE_NOTSPECIFIED_BYTE, False, False)

        pFillAndRefreshLists.Periodicidad(ComboBoxTipoEntrada)
        pFillAndRefreshLists.Periodicidad(ComboBoxTipoSalida)
        pFillAndRefreshLists.Periodicidad(ComboBoxTipoNinguno)
    End Sub

    Friend Sub SetAppearance()
        Me.Icon = CardonerSistemas.Graphics.GetIconFromBitmap(My.Resources.ImageTablas32)
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If mdbContext IsNot Nothing Then
            mdbContext.Dispose()
            mdbContext = Nothing
        End If
        mProducto_PlantaActual = Nothing
        Me.Dispose()
    End Sub

#End Region

#Region "Load and Set Data"

    Friend Sub SetDataFromObjectToControls()
        With mProducto_PlantaActual
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxPlanta, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.ValueOrFirstIfUnique, .IDPlanta)

            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxTipoEntrada, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .TipoEntrada)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxTipoSalida, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .TipoSalida)
            CardonerSistemas.Controls.ComboBox.SetSelectedValue(ComboBoxTipoNinguno, CardonerSistemas.Controls.ComboBox.SelectedItemOptions.Value, .TipoNinguno)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mProducto_PlantaActual
            .IDPlanta = CS_ValueTranslation.FromControlComboBoxToObjectByte(ComboBoxPlanta.SelectedValue).Value

            .TipoEntrada = CS_ValueTranslation.FromControlComboBoxToObjectString(ComboBoxTipoEntrada.SelectedValue)
            .TipoSalida = CS_ValueTranslation.FromControlComboBoxToObjectString(ComboBoxTipoSalida.SelectedValue)
            .TipoNinguno = CS_ValueTranslation.FromControlComboBoxToObjectString(ComboBoxTipoNinguno.SelectedValue)
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
                formProducto.PlantasRefreshData(mdbContext, mProducto_PlantaActual.IDPlanta)

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CardonerSistemas.Database.EntityFramework.TryDecodeDbUpdateException(dbuex)
                    Case CardonerSistemas.Database.EntityFramework.Errors.PrimaryKeyViolation
                        MsgBox("No se pueden guardar los cambios porque ya existe la Planta en el Producto.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
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
        If ComboBoxPlanta.SelectedIndex = -1 Then
            MessageBox.Show("Debe especificar la Planta.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxPlanta.Focus()
            Return False
        End If

        If ComboBoxTipoEntrada.SelectedIndex = -1 Then
            MessageBox.Show("Debe especificar la periodicidad de las pesadas de Tipo Entrada.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxTipoEntrada.Focus()
            Return False
        End If
        If ComboBoxTipoSalida.SelectedIndex = -1 Then
            MessageBox.Show("Debe especificar la periodicidad de las pesadas de Tipo Salida.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxTipoSalida.Focus()
            Return False
        End If
        If ComboBoxTipoNinguno.SelectedIndex = -1 Then
            MessageBox.Show("Debe especificar la periodicidad de las pesadas de Tipo Ninguno.", My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ComboBoxTipoNinguno.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

End Class