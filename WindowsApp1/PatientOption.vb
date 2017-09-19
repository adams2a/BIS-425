Public Class PatientOption
    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        AddPatientForm.ShowDialog()
    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        HomeForm.ShowDialog()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class