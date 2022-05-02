Imports System.Reflection

Public NotInheritable Class formAboutBox

    Private Sub Me_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = String.Format("Acerca de {0}", My.Application.Info.Title)

        labelApplicationTitle.Text = My.Application.Info.Title
        labelVersion.Text = String.Format("Version {0} - ({1})", My.Application.Info.Version.ToString, IO.File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location))
        labelCopyright.Text = My.Application.Info.Copyright
        labelLicensedTo.Text = pLicensedTo

        ' Propiedades
        Dim newItem As ListViewItem

        newItem = New ListViewItem With {
            .Text = "DB - DataSource"
        }
        newItem.SubItems.Add(pDatabase.Datasource)
        listviewPropiedades.Items.Add(newItem)

        newItem = New ListViewItem With {
            .Text = "DB - Database"
        }
        newItem.SubItems.Add(pDatabase.InitialCatalog)
        listviewPropiedades.Items.Add(newItem)

        newItem = New ListViewItem With {
            .Text = "Reports Path"
        }
        newItem.SubItems.Add(pGeneralConfig.ReportsPath)
        listviewPropiedades.Items.Add(newItem)
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class