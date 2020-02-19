Public Class formSplashScreen

    Private Sub SplashScreen_Load() Handles MyBase.Load
        Me.Text = My.Application.Info.Title
        Me.Icon = CS_Icon.GetIconFromEmbeddedResource("ApplicationIcon", New Size(48, 48))
        labelCompanyName.Text = My.Application.Info.CompanyName
        labelAppTitle.Text = My.Application.Info.Title
        labelLicensedTo.Text = ""
        labelStatus.Text = "Iniciando..."
        labelCopyright.Text = My.Application.Info.Copyright
    End Sub

End Class