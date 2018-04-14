Public Class formCamion

#Region "Declarations"
    Private mdbContext As New CSPesajeContext(True)
    Private mCamionActual As Camion

    Private mIsLoading As Boolean = False
    Private mEditMode As Boolean = False
    Private mIsNew As Boolean
#End Region

#Region "Form stuff"
    Friend Sub LoadAndShow(ByVal EditMode As Boolean, ByRef ParentForm As Form, ByVal IDEntidad As Integer, ByVal IDCamion As Byte)
        mIsLoading = True
        mEditMode = EditMode
        mIsNew = IDCamion = 0

        If mIsNew Then
            mCamionActual = New Camion
            With mCamionActual
                .EsActivo = True
                .IDUsuarioCreacion = pUsuario.IDUsuario
                .FechaHoraCreacion = Now
                .IDUsuarioModificacion = pUsuario.IDUsuario
                .FechaHoraModificacion = .FechaHoraCreacion
            End With
            mdbContext.Camion.Add(mCamionActual)
        Else
            mCamionActual = mdbContext.Camion.Find(IDEntidad, IDCamion)
        End If

        Me.MdiParent = formMDIMain
        CS_Form.CenterToParent(ParentForm, Me)
        InitializeFormAndControls()
        SetDataFromObjectToControls()
        Me.Show()
        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Normal
        End If
        Me.Focus()

        mIsLoading = False

        ChangeMode()
    End Sub

    Private Sub ChangeMode()
        If mIsLoading Then
            Exit Sub
        End If

        buttonGuardar.Visible = mEditMode
        buttonCancelar.Visible = mEditMode
        buttonEditar.Visible = (mEditMode = False)
        buttonCerrar.Visible = (mEditMode = False)

        checkboxEsActivo.Enabled = mEditMode
        comboboxTransportista.Enabled = mEditMode
        textboxNombre.ReadOnly = (mEditMode = False)
        textboxDominioChasis.ReadOnly = (mEditMode = False)
        textboxDominioAcoplado.ReadOnly = (mEditMode = False)
    End Sub

    Friend Sub InitializeFormAndControls()
        SetAppearance()

        pFillAndRefreshLists.Entidad(comboboxTransportista, mCamionActual.IDEntidad, False, False, True, False, 0, False, False, False, False)
    End Sub

    Friend Sub SetAppearance()
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
        mdbContext = Nothing
        mCamionActual = Nothing
        Me.Dispose()
    End Sub
#End Region

#Region "Load and Set Data"
    Friend Sub SetDataFromObjectToControls()
        With mCamionActual
            If .IDCamion = 0 Then
                textboxIDCamion.Text = My.Resources.STRING_ITEM_NEW_MALE
            Else
                textboxIDCamion.Text = String.Format(.IDCamion.ToString, "G")
            End If
            checkboxEsActivo.CheckState = CS_ValueTranslation.FromObjectBooleanToControlCheckBox(.EsActivo)
            CS_ComboBox.SetSelectedValue(comboboxTransportista, SelectedItemOptions.ValueOrFirstIfUnique, .IDEntidad)
            textboxNombre.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.Nombre)
            textboxDominioChasis.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DominioChasis)
            textboxDominioAcoplado.Text = CS_ValueTranslation.FromObjectStringToControlTextBox(.DominioAcoplado)
        End With
    End Sub

    Friend Sub SetDataFromControlsToObject()
        With mCamionActual
            .EsActivo = CS_ValueTranslation.FromControlCheckBoxToObjectBoolean(checkboxEsActivo.CheckState)
            .IDEntidad = CS_ValueTranslation.FromControlComboBoxToObjectInteger(comboboxTransportista.SelectedValue).Value
            .Nombre = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxNombre.Text)
            .DominioChasis = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDominioChasis.Text)
            .DominioAcoplado = CS_ValueTranslation.FromControlTextBoxToObjectString(textboxDominioAcoplado.Text)
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

    Private Sub TextBoxs_GotFocus(sender As Object, e As EventArgs) Handles textboxIDCamion.GotFocus, textboxNombre.GotFocus
        CType(sender, TextBox).SelectAll()
    End Sub
#End Region

#Region "Main Toolbar"
    Private Sub buttonEditar_Click() Handles buttonEditar.Click
        If Permisos.VerificarPermiso(Permisos.CAMION_EDITAR) Then
            mEditMode = True
            ChangeMode()
        End If
    End Sub

    Private Sub buttonCerrar_Click() Handles buttonCerrar.Click
        Me.Close()
    End Sub

    Private Sub buttonGuardar_Click() Handles buttonGuardar.Click
        ' Verificar que estén todos los campos con datos coherentes
        If comboboxTransportista.SelectedValue Is Nothing Then
            MsgBox("Debe especificar el Transportista al cual pertenece el Camión.", MsgBoxStyle.Information, My.Application.Info.Title)
            comboboxTransportista.Focus()
            Exit Sub
        End If
        If textboxNombre.Text.Trim.Length = 0 Then
            MsgBox("Debe ingresar el Nombre.", MsgBoxStyle.Information, My.Application.Info.Title)
            textboxNombre.Focus()
            Exit Sub
        End If

        ' Generar el ID del Camión nuevo
        If mIsNew Then
            Using dbcMaxID As New CSPesajeContext(True)
                If dbcMaxID.Camion.Where(Function(e) e.IDCamion <> CS_Constants.FIELD_VALUE_OTHER_INTEGER).Count = 0 Then
                    mCamionActual.IDCamion = 1
                Else
                    mCamionActual.IDCamion = CByte(dbcMaxID.Camion.Where(Function(e) e.IDCamion <> CS_Constants.FIELD_VALUE_OTHER_BYTE).Max(Function(ent) ent.IDCamion) + 1)
                End If
            End Using
        End If

        ' Paso los datos desde los controles al Objecto de EF
        SetDataFromControlsToObject()

        If mdbContext.ChangeTracker.HasChanges Then

            Me.Cursor = Cursors.WaitCursor

            mCamionActual.IDUsuarioModificacion = pUsuario.IDUsuario
            mCamionActual.FechaHoraModificacion = Now

            Try

                ' Guardo los cambios
                mdbContext.SaveChanges()

                ' Refresco la lista de Camiones para mostrar los cambios
                If CS_Form.MDIChild_IsLoaded(CType(formMDIMain, Form), "formCamiones") Then
                    Dim formCamions As formCamiones = CType(CS_Form.MDIChild_GetInstance(CType(formMDIMain, Form), "formCamiones"), formCamiones)
                    formCamions.RefreshData(mCamionActual.IDCamion)
                    formCamions = Nothing
                End If

            Catch dbuex As System.Data.Entity.Infrastructure.DbUpdateException
                Me.Cursor = Cursors.Default
                Select Case CS_Database_EF_SQL.TryDecodeDbUpdateException(dbuex)
                    Case Errors.DuplicatedEntity
                        MsgBox("No se pueden guardar los cambios porque ya existe un Camión con el mismo Nombre.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
                    Case Errors.Unknown
                        CS_Error.ProcessError(CType(dbuex, Exception), My.Resources.STRING_ERROR_SAVING_CHANGES)
                End Select
                Exit Sub

            Catch ex As Exception
                Me.Cursor = Cursors.Default
                CS_Error.ProcessError(ex, My.Resources.STRING_ERROR_SAVING_CHANGES)
                Exit Sub
            End Try
        End If

        Me.Close()
    End Sub

    Private Sub buttonCancelar_Click() Handles buttonCancelar.Click
        If mdbContext.ChangeTracker.HasChanges Then
            If MsgBox("Ha realizado cambios en los datos y seleccionó cancelar, los cambios se perderán." & vbCr & vbCr & "¿Confirma la pérdida de los cambios?", CType(MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, MsgBoxStyle), My.Application.Info.Title) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
#End Region

#Region "Extra stuff"

#End Region

End Class