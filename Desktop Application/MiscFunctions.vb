﻿Imports System.Net.Mail

Module MiscFunctions
    Friend Sub DataGridSetAppearance(ByRef DataGridViewObject As DataGridView)
        DataGridViewObject.DefaultCellStyle.Font = My.Settings.GridsAndListsFont
        DataGridViewObject.ColumnHeadersDefaultCellStyle.Font = My.Settings.GridsAndListsFont

        DataGridViewObject.DefaultCellStyle.BackColor = SystemColors.Window
        DataGridViewObject.DefaultCellStyle.ForeColor = SystemColors.ControlText
        DataGridViewObject.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight
        DataGridViewObject.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText

        DataGridViewObject.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.GradientActiveCaption
        DataGridViewObject.AlternatingRowsDefaultCellStyle.ForeColor = SystemColors.ControlText
        DataGridViewObject.AlternatingRowsDefaultCellStyle.SelectionBackColor = SystemColors.Highlight
        DataGridViewObject.AlternatingRowsDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText
    End Sub

    Friend Sub PreviewCrystalReport(ByRef ReporteActual As Reporte, ByVal WindowText As String)
        Dim VisorReporte As New formReportesVisor

        formMDIMain.Cursor = Cursors.WaitCursor

        CS_Form.MDIChild_PositionAndSizeToFit(CType(formMDIMain, Form), CType(VisorReporte, Form))
        With VisorReporte
            .Text = WindowText
            .CRViewerMain.ReportSource = ReporteActual.ReportObject
            .Show()
            If .WindowState = FormWindowState.Minimized Then
                .WindowState = FormWindowState.Normal
            End If
            .Focus()
        End With

        formMDIMain.Cursor = Cursors.Default
    End Sub

    Friend Sub UserLoggedIn()
        LoadPermisos()

        formMDIMain.menuitemDebug.Visible = (pUsuario.IDUsuario = 1)

        Select Case pUsuario.Genero
            Case Constantes.PERSONA_GENERO_MASCULINO
                formMDIMain.labelUsuarioNombre.Image = My.Resources.Resources.IMAGE_USUARIO_HOMBRE_16
            Case Constantes.PERSONA_GENERO_FEMENINO
                formMDIMain.labelUsuarioNombre.Image = My.Resources.Resources.IMAGE_USUARIO_MUJER_16
            Case Else
                formMDIMain.labelUsuarioNombre.Image = Nothing
        End Select
        formMDIMain.labelUsuarioNombre.Text = pUsuario.Descripcion

        My.Application.Log.WriteEntry(String.Format("El Usuario '{0}' ha iniciado sesión.", pUsuario.Nombre), TraceEventType.Information)
    End Sub

    Friend Function LoadParameters() As Boolean
        Try
            Using dbContext As New CSPesajeContext(True)
                pParametros = dbContext.Parametro.ToList
            End Using
            Return True
        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al cargar los Parámetros desde la base de datos.")
            Return False
        End Try
    End Function

    Friend Function LoadPermisos() As Boolean
        Try
            Using dbcontext As New CSPesajeContext(True)
                pPermisos = dbcontext.UsuarioGrupoPermiso.ToList
            End Using
            Return True
        Catch ex As Exception
            CS_Error.ProcessError(ex, "Error al cargar los Permisos del Usuario.")
            Return False
        End Try
    End Function
End Module
