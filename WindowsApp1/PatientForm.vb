Public Class AddPatientForm
    Private Sub PatientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PatientGroupBox_Enter(sender As Object, e As EventArgs) Handles PatientGroupBox.Enter

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles PatientIDTextBox.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles PatientFNTextBox.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles PatientLNTextBox.TextChanged

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles PatientDOBMaskedTextBox.MaskInputRejected

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles NotesTextBox.TextChanged

    End Sub

    Private Sub HomeButton_Click(sender As Object, e As EventArgs) Handles HomeButton.Click
        HomeForm.ShowDialog()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        PatientOption.ShowDialog()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class