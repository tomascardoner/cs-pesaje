﻿Imports System.Reflection

Public NotInheritable Class formAboutBox

    Private Sub formAboutBox_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = String.Format("Acerca de {0}", My.Application.Info.Title)

        labelApplicationTitle.Text = My.Application.Info.Title
        labelVersion.Text = String.Format("Version {0} - ({1})", My.Application.Info.Version.ToString, IO.File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location))
        labelCopyright.Text = My.Application.Info.Copyright
        labelLicensedTo.Text = pLicensedTo

        ' Propiedades
        Dim NewItem As ListViewItem

        NewItem = New ListViewItem
        NewItem.Text = "DB - DataSource"
        NewItem.SubItems.Add(pDatabase.DataSource)
        listviewPropiedades.Items.Add(NewItem)

        NewItem = New ListViewItem
        NewItem.Text = "DB - Database"
        NewItem.SubItems.Add(pDatabase.InitialCatalog)
        listviewPropiedades.Items.Add(NewItem)

        NewItem = New ListViewItem
        NewItem.Text = "Reports Path"
        NewItem.SubItems.Add(pGeneralConfig.ReportsPath)
        listviewPropiedades.Items.Add(NewItem)
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class