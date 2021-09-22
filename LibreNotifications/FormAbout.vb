Public NotInheritable Class FormAbout

    Private Sub FormAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub LinkConnor_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkConnor.LinkClicked
        Dim webAddress As String = "https://connorlorente.com"
        Process.Start(webAddress)
    End Sub

    Private Sub LinkGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkGithub.LinkClicked
        Dim webAddress As String = "https://github.com/manor7777/GlucoseNotifications"
        Process.Start(webAddress)
    End Sub

    Private Sub LinkNorman_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkNorman.LinkClicked
        Dim webAddress As String = "https://twitter.com/MLGMelon"
        Process.Start(webAddress)
    End Sub
End Class
