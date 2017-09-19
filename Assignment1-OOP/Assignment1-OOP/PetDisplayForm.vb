Public Class PetDisplayForm

	Private APetClass As PetsClass

	Private Sub PetDisplayForm_Acvtivated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
		'Display the values from the input form
		APetClass = PetsForm.completedPet
		Colortextbox.text = APetClass.Color
		BreedTextBox.Text = APetClass.Breed
		TypeTextBox.Text = APetClass.Type
		NameTextBox.Text = APetClass.Name
	End Sub
	Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
		'Close the Form
		Me.Close()
	End Sub

	Private Sub PetDisplayForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class