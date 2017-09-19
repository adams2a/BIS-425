'Project: PetCharacteristics
'Programmer: Austin Adams
'Date: September 3, 2017 
'Class: Pet Class
'Description: this class contain all the properties of your Pet.  
Public Class PetsForm
	Private ThePet As PetsClass
	ReadOnly Property completedPet() As PetsClass
		Get
			Return ThePet
		End Get
	End Property
	Private Sub AddButton_Click(sender As System.Object, e As System.EventArgs) Handles AddButton.Click
		'Set the properties for pet
		Try
			ThePet = New PetsClass(PetNameTextBox.Text, TypeTextBox.Text, BreedTextBox.Text, ColorTextBox.Text)
			clear()
			DisplayButton.Enabled = True
			AddButton.Enabled = False

		Catch ex As Exception
			Select Case ex.Source
				Case "Name"
					ErrorProvider1.SetError(PetNameTextBox, ex.Message)
					With PetNameTextBox
						.SelectAll()
						.Focus()
					End With

			End Select

		End Try
	End Sub
	Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
		'Display the properties of the pet object in the display form

		PetDisplayForm.ShowDialog()
		AddButton.Enabled = True
		DisplayButton.Enabled = False
	End Sub
	Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
		Me.Close()
	End Sub
	Sub clear()
		PetNameTextBox.Clear()
		TypeTextBox.Clear()
		BreedTextBox.Clear()
		ColorTextBox.Clear()
	End Sub
End Class