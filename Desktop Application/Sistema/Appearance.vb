﻿Module Appearance

    Friend Sub DataGridSetAppearance(ByRef DataGridViewObject As DataGridView)
        DataGridViewObject.DefaultCellStyle.Font = pAppearanceConfig.ListsFont
        DataGridViewObject.ColumnHeadersDefaultCellStyle.Font = pAppearanceConfig.ListsFont

        DataGridViewObject.DefaultCellStyle.BackColor = SystemColors.Window
        DataGridViewObject.DefaultCellStyle.ForeColor = SystemColors.ControlText
        DataGridViewObject.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight
        DataGridViewObject.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText

        DataGridViewObject.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.GradientActiveCaption
        DataGridViewObject.AlternatingRowsDefaultCellStyle.ForeColor = SystemColors.ControlText
        DataGridViewObject.AlternatingRowsDefaultCellStyle.SelectionBackColor = SystemColors.Highlight
        DataGridViewObject.AlternatingRowsDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText
    End Sub

    Friend Sub UserLoggedIn()
        LoadPermisos()

        pFormMDIMain.menuitemDebug.Visible = (pUsuario.IDUsuario = 1)

        Select Case pUsuario.Genero
            Case Constantes.PERSONA_GENERO_MASCULINO
                pFormMDIMain.labelUsuarioNombre.Image = My.Resources.Resources.IMAGE_USUARIO_HOMBRE_16
            Case Constantes.PERSONA_GENERO_FEMENINO
                pFormMDIMain.labelUsuarioNombre.Image = My.Resources.Resources.IMAGE_USUARIO_MUJER_16
            Case Else
                pFormMDIMain.labelUsuarioNombre.Image = Nothing
        End Select
        pFormMDIMain.labelUsuarioNombre.Text = pUsuario.Descripcion

        My.Application.Log.WriteEntry(String.Format("El Usuario '{0}' ha iniciado sesión.", pUsuario.Nombre), TraceEventType.Information)
    End Sub

End Module
