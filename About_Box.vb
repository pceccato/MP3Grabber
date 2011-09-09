Public NotInheritable Class About_Box

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
            temp_string = My.Application.Deployment.CurrentVersion.ToString
        Else
            temp_string = My.Application.Info.Version.ToString
        End If
        Me.LabelVersion.Text = String.Format("Version {0}", temp_string)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName

        temp_string = "Author: Matt Lazell." & vbLf & vbLf
        temp_string = temp_string & "Symmetry IT: www.symmetry-it.net" & vbLf & vbLf
        temp_string = temp_string & "mp3 Grabber uses the 'UltraIDLib: MP3 ID3 Tag Editor'" & vbLf
        temp_string = temp_string & "UltraIDLib: MP3 ID3 Tag Editor and MPEG Info Reader Library" & vbLf
        temp_string = temp_string & "Hundred Miles Software (www.HundredMilesSoftware.com)" & vbLf
        temp_string = temp_string & "Copyright(2002)" & vbLf
        temp_string = temp_string & "Author: Mitchell(S.Honnert)" & vbLf
        temp_string = temp_string & "Home(Page) : www.UltraID3Lib.com()" & vbLf

        'Debug.Print(temp_string)

        Me.memo_ctl.Text = temp_string 'My.Application.Info.Description

    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click

        Me.Close()

    End Sub

End Class
