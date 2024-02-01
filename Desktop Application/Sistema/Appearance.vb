Module Appearance

#Region "Grillas"

    Friend Sub DataGridSetAppearance(grid As DataGridView)
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

    Friend Sub DataGridSetCellStyleStandard(cell As DataGridViewTextBoxCell, rowIndex As Integer)
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

    Friend Sub DataGridSetCellStyleError(cell As DataGridViewTextBoxCell)
        cell.Style.BackColor = pAppearanceConfig.GridRowErrorBackColorObject
        cell.Style.ForeColor = pAppearanceConfig.GridRowErrorForeColorObject
        cell.Style.SelectionBackColor = pAppearanceConfig.GridRowErrorSelectionBackColorObject
        cell.Style.SelectionForeColor = pAppearanceConfig.GridRowErrorSelectionForeColorObject
    End Sub

#End Region

#Region "Toolbars"

    Friend Sub TabToolBarSetColors(sourceTabControl As TabControl)
        For Each tabPageCurrent As TabPage In sourceTabControl.TabPages
            tabPageCurrent.BackColor = pAppearanceConfig.ToolbarContainerBackColorObject
            ToolStripSetColors(tabPageCurrent)
        Next
    End Sub

    Friend Sub ToolStripSetColors(sourceTabPage As TabPage)
        For Each controlCurrent As Control In sourceTabPage.Controls
            If TypeOf (controlCurrent) Is ToolStrip Then
                controlCurrent.BackColor = pAppearanceConfig.ToolbarBackColorObject
            End If
        Next
    End Sub

#End Region

    Friend Sub UserLoggedIn()
        LoadPermisos()

        pFormMDIMain.menuitemDebug.Visible = (pUsuario.IDUsuario = 1)

        Select Case pUsuario.Genero
            Case Constantes.PERSONA_GENERO_MASCULINO
                pFormMDIMain.PictureBoxUsuarioAvatar.Image = My.Resources.Resources.ImageUsuarioHombre16
            Case Constantes.PERSONA_GENERO_FEMENINO
                pFormMDIMain.PictureBoxUsuarioAvatar.Image = My.Resources.Resources.ImageUsuarioMujer16
            Case Else
                pFormMDIMain.PictureBoxUsuarioAvatar.Image = Nothing
        End Select
        pFormMDIMain.LabelUsuarioDescripcion.Text = pUsuario.Descripcion

        My.Application.Log.WriteEntry($"El Usuario '{pUsuario.Nombre}' ha iniciado sesión.", TraceEventType.Information)
    End Sub

End Module
