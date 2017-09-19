Imports System.Data.Odbc
Public Class LoginForm
    Private DB As New DBAccess

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click

        If ClientComboBox.Text = String.Empty Then
            MessageBox.Show("Client cannot be left empty!")
        End If
        If UserIDTextBox.Text = String.Empty Then
            MessageBox.Show("User ID cannot be left empty!")
            UserIDTextBox.Select()
            Exit Sub

        Else
            If PWTextBox.Text = String.Empty Then
                MessageBox.Show("Password cannot be left empty!")
                PWTextBox.Select()
                Exit Sub

            Else
                DB.AddParam("@UserClient", ClientComboBox.Text)
                DB.AddParam("@userID", UserIDTextBox.Text)
                DB.AddParam("@UserPassword", PWTextBox.Text)
                DB.ExecuteQuery("Select * from user where UserClient = ? and userid = ? and userpassword = ?")

                If DB.Exception <> String.Empty Then
                    MessageBox.Show(DB.Exception)
                    Exit Sub
                Else
                    If DB.RecordCount = 0 Then
                        MessageBox.Show("The user ID and password do not match.")
                        Exit Sub
                    Else
                        Dim obj As New HomeForm
                        obj.StringPass = UserIDTextBox.Text
                        obj.Show()
                        Me.Close()
                        'HomeForm.Show()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles ClientLabel.Click

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ClientComboBox.ResetText()
        UserIDTextBox.Clear()
        PWTextBox.Clear()
        ClientComboBox.Focus()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub UserIDLabel_Click(sender As Object, e As EventArgs) Handles UserIDLabel.Click

    End Sub

    Private Sub UserIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles UserIDTextBox.TextChanged

    End Sub

    Private Sub PWTextBox_TextChanged(sender As Object, e As EventArgs) Handles PWTextBox.TextChanged

    End Sub
End Class
