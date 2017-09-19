<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PetsForm
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
		Me.components = New System.ComponentModel.Container()
		Me.PetNameTextBox = New System.Windows.Forms.TextBox()
		Me.TypeTextBox = New System.Windows.Forms.TextBox()
		Me.ColorTextBox = New System.Windows.Forms.TextBox()
		Me.BreedTextBox = New System.Windows.Forms.TextBox()
		Me.NameLabel = New System.Windows.Forms.Label()
		Me.BreedLabel = New System.Windows.Forms.Label()
		Me.TypeLabel = New System.Windows.Forms.Label()
		Me.ColorLabel = New System.Windows.Forms.Label()
		Me.ExitButton = New System.Windows.Forms.Button()
		Me.DisplayButton = New System.Windows.Forms.Button()
		Me.AddButton = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PetNameTextBox
		'
		Me.PetNameTextBox.Location = New System.Drawing.Point(77, 264)
		Me.PetNameTextBox.Margin = New System.Windows.Forms.Padding(6)
		Me.PetNameTextBox.Name = "PetNameTextBox"
		Me.PetNameTextBox.Size = New System.Drawing.Size(196, 31)
		Me.PetNameTextBox.TabIndex = 1
		'
		'TypeTextBox
		'
		Me.TypeTextBox.Location = New System.Drawing.Point(332, 264)
		Me.TypeTextBox.Margin = New System.Windows.Forms.Padding(6)
		Me.TypeTextBox.Name = "TypeTextBox"
		Me.TypeTextBox.Size = New System.Drawing.Size(196, 31)
		Me.TypeTextBox.TabIndex = 2
		'
		'ColorTextBox
		'
		Me.ColorTextBox.Location = New System.Drawing.Point(821, 264)
		Me.ColorTextBox.Margin = New System.Windows.Forms.Padding(6)
		Me.ColorTextBox.Name = "ColorTextBox"
		Me.ColorTextBox.Size = New System.Drawing.Size(196, 31)
		Me.ColorTextBox.TabIndex = 4
		'
		'BreedTextBox
		'
		Me.BreedTextBox.Location = New System.Drawing.Point(592, 264)
		Me.BreedTextBox.Margin = New System.Windows.Forms.Padding(6)
		Me.BreedTextBox.Name = "BreedTextBox"
		Me.BreedTextBox.Size = New System.Drawing.Size(196, 31)
		Me.BreedTextBox.TabIndex = 3
		'
		'NameLabel
		'
		Me.NameLabel.AutoSize = True
		Me.NameLabel.Location = New System.Drawing.Point(72, 233)
		Me.NameLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
		Me.NameLabel.Name = "NameLabel"
		Me.NameLabel.Size = New System.Drawing.Size(112, 25)
		Me.NameLabel.TabIndex = 8
		Me.NameLabel.Text = "Pet Name:"
		'
		'BreedLabel
		'
		Me.BreedLabel.AutoSize = True
		Me.BreedLabel.Location = New System.Drawing.Point(587, 233)
		Me.BreedLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
		Me.BreedLabel.Name = "BreedLabel"
		Me.BreedLabel.Size = New System.Drawing.Size(75, 25)
		Me.BreedLabel.TabIndex = 9
		Me.BreedLabel.Text = "Breed:"
		'
		'TypeLabel
		'
		Me.TypeLabel.AutoSize = True
		Me.TypeLabel.Location = New System.Drawing.Point(327, 233)
		Me.TypeLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
		Me.TypeLabel.Name = "TypeLabel"
		Me.TypeLabel.Size = New System.Drawing.Size(137, 25)
		Me.TypeLabel.TabIndex = 10
		Me.TypeLabel.Text = "Animal Type:"
		'
		'ColorLabel
		'
		Me.ColorLabel.AutoSize = True
		Me.ColorLabel.Location = New System.Drawing.Point(831, 233)
		Me.ColorLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
		Me.ColorLabel.Name = "ColorLabel"
		Me.ColorLabel.Size = New System.Drawing.Size(69, 25)
		Me.ColorLabel.TabIndex = 11
		Me.ColorLabel.Text = "Color:"
		'
		'ExitButton
		'
		Me.ExitButton.Location = New System.Drawing.Point(727, 418)
		Me.ExitButton.Margin = New System.Windows.Forms.Padding(6)
		Me.ExitButton.Name = "ExitButton"
		Me.ExitButton.Size = New System.Drawing.Size(150, 44)
		Me.ExitButton.TabIndex = 7
		Me.ExitButton.Text = "E&xit"
		Me.ExitButton.UseVisualStyleBackColor = True
		'
		'DisplayButton
		'
		Me.DisplayButton.Location = New System.Drawing.Point(472, 418)
		Me.DisplayButton.Margin = New System.Windows.Forms.Padding(6)
		Me.DisplayButton.Name = "DisplayButton"
		Me.DisplayButton.Size = New System.Drawing.Size(150, 44)
		Me.DisplayButton.TabIndex = 6
		Me.DisplayButton.Text = "&Display"
		Me.DisplayButton.UseVisualStyleBackColor = True
		'
		'AddButton
		'
		Me.AddButton.Location = New System.Drawing.Point(214, 418)
		Me.AddButton.Margin = New System.Windows.Forms.Padding(6)
		Me.AddButton.Name = "AddButton"
		Me.AddButton.Size = New System.Drawing.Size(150, 44)
		Me.AddButton.TabIndex = 5
		Me.AddButton.Text = "&Add"
		Me.AddButton.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(305, 80)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(459, 44)
		Me.Label1.TabIndex = 15
		Me.Label1.Text = "Input Pet Characteristics"
		'
		'ErrorProvider1
		'
		Me.ErrorProvider1.ContainerControl = Me
		'
		'PetsForm
		'
		Me.AcceptButton = Me.AddButton
		Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1144, 514)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.AddButton)
		Me.Controls.Add(Me.DisplayButton)
		Me.Controls.Add(Me.ExitButton)
		Me.Controls.Add(Me.ColorLabel)
		Me.Controls.Add(Me.TypeLabel)
		Me.Controls.Add(Me.BreedLabel)
		Me.Controls.Add(Me.NameLabel)
		Me.Controls.Add(Me.BreedTextBox)
		Me.Controls.Add(Me.ColorTextBox)
		Me.Controls.Add(Me.TypeTextBox)
		Me.Controls.Add(Me.PetNameTextBox)
		Me.Margin = New System.Windows.Forms.Padding(6)
		Me.Name = "PetsForm"
		Me.Text = "Input Pet Characteristics"
		CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents PetNameTextBox As TextBox
	Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents ColorTextBox As TextBox
    Friend WithEvents BreedTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents BreedLabel As Label
    Friend WithEvents TypeLabel As Label
    Friend WithEvents ColorLabel As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents DisplayButton As Button
    Friend WithEvents AddButton As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
