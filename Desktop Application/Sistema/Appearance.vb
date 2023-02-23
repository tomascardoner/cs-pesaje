Module Appearance
    Friend Sub DataGridSetAppearance(ByRef grid As DataGridView)
        With grid
            ' Fuentes
            .DefaultCellStyle.Font = pAppearanceConfig.ListsFont
            .ColumnHeadersDefaultCellStyle.Font = pAppearanceConfig.ListsFont

            ' Colores filas pares
            .DefaultCellStyle.BackColor = pAppearanceConfig.GridRowBackColorObject
            .DefaultCellStyle.ForeColor = pAppearanceConfig.GridRowForeColorObject
            .DefaultCellStyle.SelectionBackColor = pAppearanceConfig.GridRowSelectionBackColorObject
            .DefaultCellStyle.SelectionForeColor = pAppearanceConfig.GridRowSelectionForeColorObject

            ' colores filas impares
            .AlternatingRowsDefaultCellStyle.BackColor = pAppearanceConfig.GridAlternateRowBackColorObject
            .AlternatingRowsDefaultCellStyle.ForeColor = pAppearanceConfig.GridAlternateRowForeColorObject
            .AlternatingRowsDefaultCellStyle.SelectionBackColor = pAppearanceConfig.GridAlternateRowSelectionBackColorObject
            .AlternatingRowsDefaultCellStyle.SelectionForeColor = pAppearanceConfig.GridAlternateRowSelectionForeColorObject
        End With
    End Sub

    Friend Sub DataGridSetCellStyleStandard(ByRef cell As DataGridViewTextBoxCell, ByVal rowIndex As Integer)
        If rowIndex Mod 2 = 0 Then
            ' Filas pares
            cell.Style.BackColor = pAppearanceConfig.GridRowBackColorObject
            cell.Style.ForeColor = pAppearanceConfig.GridRowForeColorObject
            cell.Style.SelectionBackColor = pAppearanceConfig.GridRowSelectionBackColorObject
            cell.Style.SelectionForeColor = pAppearanceConfig.GridRowSelectionForeColorObject
        Else
            ' Filas impares
            cell.Style.BackColor = pAppearanceConfig.GridAlternateRowBackColorObject
            cell.Style.ForeColor = pAppearanceConfig.GridAlternateRowForeColorObject
            cell.Style.SelectionBackColor = pAppearanceConfig.GridAlternateRowSelectionBackColorObject
            cell.Style.SelectionForeColor = pAppearanceConfig.GridAlternateRowSelectionForeColorObject
        End If
    End Sub

    Friend Sub DataGridSetCellStyleError(ByRef cell As DataGridViewTextBoxCell)
        cell.Style.BackColor = pAppearanceConfig.GridRowErrorBackColorObject
        cell.Style.ForeColor = pAppearanceConfig.GridRowErrorForeColorObject
        cell.Style.SelectionBackColor = pAppearanceConfig.GridRowErrorSelectionBackColorObject
        cell.Style.SelectionForeColor = pAppearanceConfig.GridRowErrorSelectionForeColorObject
    End Sub

    Friend Sub UserLoggedIn()
        LoadPermisos()

        pFormMDIMain.menuitemDebug.Visible = (pUsuario.IDUsuario = 1)

        Select Case pUsuario.Genero
            Case Constantes.PERSONA_GENERO_MASCULINO
                pFormMDIMain.labelUsuarioNombre.Image = My.Resources.Resources.ImageUsuarioHombre16
            Case Constantes.PERSONA_GENERO_FEMENINO
                pFormMDIMain.labelUsuarioNombre.Image = My.Resources.Resources.ImageUsuarioMujer16
            Case Else
                pFormMDIMain.labelUsuarioNombre.Image = Nothing
        End Select
        pFormMDIMain.labelUsuarioNombre.Text = pUsuario.Descripcion

        My.Application.Log.WriteEntry(String.Format("El Usuario '{0}' ha iniciado sesión.", pUsuario.Nombre), TraceEventType.Information)
    End Sub

End Module
