Public NotInheritable Class AboutBox

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
        Me.LabelProductName.Text = "The LifeLine"
        Me.Label3.Text = "EST. 2017"
        Me.Label2.Text = "Abundant Life Homes"
        Me.TextBoxDescription.Text = "OUR HISTORY:
            
                Abundant Life Homes provides quality community living services to those in need of assisted living or respite care. Abundant Life Homes was founded in 2009 by Tedaro and Tanya France. In the eight years of providing hospitality services, the company has experienced tremendous growth. Abundant Life Homes has 30 active patients and has had over 150 patients. Living services are provided in three locations across Michigan: Clinton Township, New Haven, and Fort Gratiot. The company is currently at capacity with a total of 25 rooms and 30 beds. The house in Clinton Township is the biggest while 12 rooms, the home in New Haven has 7 and Fort Gratiot has 6. The majority of the rooms are single person living spaces, but 5 rooms are set up to accommodate two patients."
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub


End Class
