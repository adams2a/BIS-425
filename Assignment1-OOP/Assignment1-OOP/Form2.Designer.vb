<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PetNameLabel = New System.Windows.Forms.Label()
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.ColorLabel = New System.Windows.Forms.Label()
        Me.BreedLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.BreedTextBox = New System.Windows.Forms.TextBox()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PetNameLabel
        '
        Me.PetNameLabel.AutoSize = True
        Me.PetNameLabel.Location = New System.Drawing.Point(222, 9)
        Me.PetNameLabel.Name = "PetNameLabel"
        Me.PetNameLabel.Size = New System.Drawing.Size(62, 13)
        Me.PetNameLabel.TabIndex = 0
        Me.PetNameLabel.Text = "Pets Name:"
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Location = New System.Drawing.Point(39, 90)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(68, 13)
        Me.TypeLabel.TabIndex = 1
        Me.TypeLabel.Text = "Animal Type:"
        '
        'ColorLabel
        '
        Me.ColorLabel.AutoSize = True
        Me.ColorLabel.Location = New System.Drawing.Point(406, 90)
        Me.ColorLabel.Name = "ColorLabel"
        Me.ColorLabel.Size = New System.Drawing.Size(34, 13)
        Me.ColorLabel.TabIndex = 2
        Me.ColorLabel.Text = "Color:"
        '
        'BreedLabel
        '
        Me.BreedLabel.AutoSize = True
        Me.BreedLabel.Location = New System.Drawing.Point(231, 90)
        Me.BreedLabel.Name = "BreedLabel"
        Me.BreedLabel.Size = New System.Drawing.Size(38, 13)
        Me.BreedLabel.TabIndex = 3
        Me.BreedLabel.Text = "Breed:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(193, 25)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.ReadOnly = True
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'ColorTextBox
        '
        Me.ColorTextBox.Location = New System.Drawing.Point(370, 106)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.ReadOnly = True
        Me.ColorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ColorTextBox.TabIndex = 5
        '
        'BreedTextBox
        '
        Me.BreedTextBox.Location = New System.Drawing.Point(193, 106)
        Me.BreedTextBox.Name = "BreedTextBox"
        Me.BreedTextBox.ReadOnly = True
        Me.BreedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BreedTextBox.TabIndex = 6
        '
        'TypeTextBox
        '
        Me.TypeTextBox.Location = New System.Drawing.Point(28, 106)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.ReadOnly = True
        Me.TypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TypeTextBox.TabIndex = 7
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(209, 169)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 8
        Me.OKButton.Text = "&OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 217)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.TypeTextBox)
        Me.Controls.Add(Me.BreedTextBox)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.BreedLabel)
        Me.Controls.Add(Me.ColorLabel)
        Me.Controls.Add(Me.TypeLabel)
        Me.Controls.Add(Me.PetNameLabel)
        Me.Name = "Form2"
        Me.Text = "Display Pet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PetNameLabel As Label
    Friend WithEvents TypeLabel As Label
    Friend WithEvents ColorLabel As Label
    Friend WithEvents BreedLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents ColorTextBox As TextBox
    Friend WithEvents BreedTextBox As TextBox
    Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents OKButton As Button
End Class
