<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PetDisplayForm
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
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.ColorTextBox = New System.Windows.Forms.TextBox()
		Me.BreedTextBox = New System.Windows.Forms.TextBox()
		Me.TypeTextBox = New System.Windows.Forms.TextBox()
		Me.NameTextBox = New System.Windows.Forms.TextBox()
		Me.OKButton = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(342, 194)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(75, 25)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Breed:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(70, 194)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(104, 25)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Pet Type:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(339, 36)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(209, 44)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Pet Name:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(673, 194)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(69, 25)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Color:"
		'
		'ColorTextBox
		'
		Me.ColorTextBox.Location = New System.Drawing.Point(631, 235)
		Me.ColorTextBox.Name = "ColorTextBox"
		Me.ColorTextBox.ReadOnly = True
		Me.ColorTextBox.Size = New System.Drawing.Size(195, 31)
		Me.ColorTextBox.TabIndex = 4
		'
		'BreedTextBox
		'
		Me.BreedTextBox.Location = New System.Drawing.Point(347, 235)
		Me.BreedTextBox.Name = "BreedTextBox"
		Me.BreedTextBox.ReadOnly = True
		Me.BreedTextBox.Size = New System.Drawing.Size(195, 31)
		Me.BreedTextBox.TabIndex = 5
		'
		'TypeTextBox
		'
		Me.TypeTextBox.Location = New System.Drawing.Point(66, 235)
		Me.TypeTextBox.Name = "TypeTextBox"
		Me.TypeTextBox.ReadOnly = True
		Me.TypeTextBox.Size = New System.Drawing.Size(195, 31)
		Me.TypeTextBox.TabIndex = 6
		'
		'NameTextBox
		'
		Me.NameTextBox.Location = New System.Drawing.Point(341, 110)
		Me.NameTextBox.Name = "NameTextBox"
		Me.NameTextBox.ReadOnly = True
		Me.NameTextBox.Size = New System.Drawing.Size(201, 31)
		Me.NameTextBox.TabIndex = 7
		'
		'OKButton
		'
		Me.OKButton.Location = New System.Drawing.Point(371, 328)
		Me.OKButton.Name = "OKButton"
		Me.OKButton.Size = New System.Drawing.Size(140, 44)
		Me.OKButton.TabIndex = 8
		Me.OKButton.Text = "&OK"
		Me.OKButton.UseVisualStyleBackColor = True
		'
		'PetDisplayForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(921, 449)
		Me.Controls.Add(Me.OKButton)
		Me.Controls.Add(Me.NameTextBox)
		Me.Controls.Add(Me.TypeTextBox)
		Me.Controls.Add(Me.BreedTextBox)
		Me.Controls.Add(Me.ColorTextBox)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Name = "PetDisplayForm"
		Me.Text = "PetDisplayForm"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents ColorTextBox As TextBox
	Friend WithEvents BreedTextBox As TextBox
	Friend WithEvents TypeTextBox As TextBox
	Friend WithEvents NameTextBox As TextBox
	Friend WithEvents OKButton As Button
End Class
