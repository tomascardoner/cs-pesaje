﻿Public Class formLogin
    Private mIntentos As Integer = 0
    Private mdbContext As CSPesajeContext

    Private Sub Me_Load() Handles Me.Load
        mdbContext = New CSPesajeContext(True)

        If pGeneralConfig.ShowLastLoggedInUser AndAlso My.Settings.LastLoggedInUser <> String.Empty Then
            textboxNombre.Text = My.Settings.LastLoggedInUser
            labelPassword.TabIndex = 0
            textboxPassword.TabIndex = 1
            labelNombre.TabIndex = 2
            textboxNombre.TabIndex = 3
        End If
    End Sub

    Private Sub Me_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            Aceptar_Click()
        ElseIf e.KeyChar = ChrW(Keys.Escape) Then
            Cancelar_Click()
        End If
    End Sub

    Private Sub Me_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        mdbContext.Dispose()
    End Sub

    Private Sub Nombre_GotFocus() Handles textboxNombre.GotFocus
        textboxNombre.SelectAll()
    End Sub

    Private Sub Password_GotFocus() Handles textboxPassword.GotFocus
        textboxPassword.SelectAll()
    End Sub

    Private Sub Aceptar_Click() Handles buttonAceptar.Click
        Dim UsuarioCurrent As Usuario

        textboxNombre.Text.Trim()

        If textboxNombre.TextLength = 0 Then
            MsgBox("Debe ingresar el Nombre del Usuario.", vbInformation, My.Application.Info.Title)
            textboxNombre.Focus()
            Return
        End If

        If textboxNombre.TextLength < CS_Parameter_System.GetIntegerAsByte(Parametros.USER_USERNAME_MINIMUM_LENGHT, 4) Then
            MsgBox(String.Format("El Nombre del Usuario debe contener al menos {0} caracteres.", CS_Parameter_System.GetIntegerAsByte(Parametros.USER_USERNAME_MINIMUM_LENGHT, 4)), vbInformation, My.Application.Info.Title)
            textboxNombre.Focus()
            Return
        End If

        If textboxPassword.TextLength = 0 Then
            MsgBox("Debe ingresar la Contraseña.", vbInformation, My.Application.Info.Title)
            textboxPassword.Focus()
            Return
        End If
        If textboxPassword.TextLength < CS_Parameter_System.GetIntegerAsByte(Parametros.USER_PASSWORD_MINIMUM_LENGHT, 8) Then
            MsgBox(String.Format("La Contraseña debe contener al menos {0} caracteres.", CS_Parameter_System.GetIntegerAsByte(Parametros.USER_PASSWORD_MINIMUM_LENGHT, 8)), vbInformation, My.Application.Info.Title)
            textboxPassword.Focus()
            Return
        End If

        Me.Cursor = Cursors.WaitCursor

        UsuarioCurrent = mdbContext.Usuario.Where(Function(usr) usr.Nombre = textboxNombre.Text).FirstOrDefault
        If UsuarioCurrent Is Nothing Then
            My.Application.Log.WriteEntry(String.Format("Se intentó iniciar sesión con el Usuario '{0}', pero es inexistente.", textboxNombre.Text.Trim), TraceEventType.Warning)
            MsgBox("El Nombre de Usuario ingresado no existe.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            textboxNombre.SelectAll()
            textboxNombre.Focus()
            UsuarioCurrent = Nothing
            Me.Cursor = Cursors.Default
            mIntentos += 1
            If mIntentos > 3 Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
            Return
        End If
        If String.Compare(textboxPassword.Text, UsuarioCurrent.Password, False) <> 0 Then
            My.Application.Log.WriteEntry(String.Format("Se intentó iniciar sesión con el Usuario '{0}', pero la Contraseña es incorrecta.", textboxNombre.Text.Trim), TraceEventType.Warning)
            MsgBox("La Contraseña ingresada es incorrecta.", MsgBoxStyle.Exclamation, My.Application.Info.Title)
            textboxPassword.SelectAll()
            textboxPassword.Focus()
            UsuarioCurrent = Nothing
            Me.Cursor = Cursors.Default
            mIntentos += 1
            If mIntentos > 3 Then
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
            End If
            Return
        End If

        pUsuario = UsuarioCurrent
        UsuarioCurrent = Nothing

        ' Guardo el Nombre de Usuario para mostrarlo la próxima vez
        My.Settings.LastLoggedInUser = pUsuario.Nombre
        My.Settings.Save()

        Appearance.UserLoggedIn()

        Me.Cursor = Cursors.Default

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub Cancelar_Click() Handles buttonCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class