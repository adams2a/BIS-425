Public Class HomeForm
    Public Property StringPass As String
    Private Sub HomeForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        UserIDLabel.Text = StringPass
    End Sub
    Private Sub PatientsButton_Click(sender As Object, e As EventArgs) Handles PatientsButton.Click
        PasswordForm.ShowDialog()
        Dim obj As New AddPatientForm
        StringPass = UserIDLabel.Text
        obj.Show()
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub EmployeesButton_Click(sender As Object, e As EventArgs)
        Dim obj As New EmployeesForm
        StringPass = UserIDLabel.Text
        obj.Show()
    End Sub
    Private Sub ReportButton_Click(sender As Object, e As EventArgs) Handles ReportButton.Click
        Dim obj As New ReportsForm
        StringPass = UserIDLabel.Text
        obj.Show()
    End Sub

    Private Sub InventoryButton_Click(sender As Object, e As EventArgs) Handles InventoryButton.Click
        Dim obj As New InventoryForm
        StringPass = UserIDLabel.Text
        obj.Show()
    End Sub

    Private Sub EmployeeButton_Click(sender As Object, e As EventArgs) Handles EmployeeButton.Click

    End Sub
End Class