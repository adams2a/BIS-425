Imports System.Data.Odbc
Public Class Passwordform
    Private DB As New DBAccess
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub UserIDLabel_Click(sender As Object, e As EventArgs) Handles UserIDLabel.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged

    End Sub

    Private Sub PasswordForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        If PasswordTextBox.Text = String.Empty Then
            MessageBox.Show("Password cannot be left empty!")
            PasswordTextBox.Select()
            Exit Sub

        Else
            DB.AddParam("@UserPassword", PasswordTextBox.Text)
            DB.ExecuteQuery("Select * from user where UserClient = ? and userid = ? and userpassword = ?")

            If DB.Exception <> String.Empty Then
                MessageBox.Show(DB.Exception)
                Exit Sub
            Else
                If DB.RecordCount = 0 Then
                    MessageBox.Show("The user ID and password do not match.")
                    Exit Sub
                Else
                    Dim obj As New PatientOption
                    obj.Show()
                    Me.Close()
                    'PatientOption.Show()
                End If
            End If
        End If

    End Sub
End Class