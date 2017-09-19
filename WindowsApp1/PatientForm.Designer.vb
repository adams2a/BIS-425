<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPatientForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPatientForm))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PatientGroupBox = New System.Windows.Forms.GroupBox()
        Me.LocationTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.MedicationTextBox = New System.Windows.Forms.TextBox()
        Me.PatientAgeTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RelationshipTextBox = New System.Windows.Forms.TextBox()
        Me.ContactFNTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ContactLNTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PatientDOBMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PatientLNTextBox = New System.Windows.Forms.TextBox()
        Me.PatientFNTextBox = New System.Windows.Forms.TextBox()
        Me.PatientIDTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.BackButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PatientGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.Location = New System.Drawing.Point(77, 834)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(2108, 324)
        Me.DataGridView1.TabIndex = 0
        '
        'PatientGroupBox
        '
        Me.PatientGroupBox.Controls.Add(Me.LocationTextBox)
        Me.PatientGroupBox.Controls.Add(Me.Label12)
        Me.PatientGroupBox.Controls.Add(Me.NotesTextBox)
        Me.PatientGroupBox.Controls.Add(Me.MedicationTextBox)
        Me.PatientGroupBox.Controls.Add(Me.PatientAgeTextBox)
        Me.PatientGroupBox.Controls.Add(Me.GroupBox1)
        Me.PatientGroupBox.Controls.Add(Me.Label7)
        Me.PatientGroupBox.Controls.Add(Me.PatientDOBMaskedTextBox)
        Me.PatientGroupBox.Controls.Add(Me.Label5)
        Me.PatientGroupBox.Controls.Add(Me.Label6)
        Me.PatientGroupBox.Controls.Add(Me.PatientLNTextBox)
        Me.PatientGroupBox.Controls.Add(Me.PatientFNTextBox)
        Me.PatientGroupBox.Controls.Add(Me.PatientIDTextBox)
        Me.PatientGroupBox.Controls.Add(Me.Label4)
        Me.PatientGroupBox.Controls.Add(Me.Label3)
        Me.PatientGroupBox.Controls.Add(Me.Label2)
        Me.PatientGroupBox.Controls.Add(Me.Label1)
        Me.PatientGroupBox.Font = New System.Drawing.Font("Book Antiqua", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientGroupBox.Location = New System.Drawing.Point(82, 69)
        Me.PatientGroupBox.Name = "PatientGroupBox"
        Me.PatientGroupBox.Size = New System.Drawing.Size(1223, 646)
        Me.PatientGroupBox.TabIndex = 1
        Me.PatientGroupBox.TabStop = False
        Me.PatientGroupBox.Text = "Patient Info:"
        '
        'LocationTextBox
        '
        Me.LocationTextBox.AllowDrop = True
        Me.LocationTextBox.AutoCompleteCustomSource.AddRange(New String() {"Location 1", "Location 2", "Location 3"})
        Me.LocationTextBox.Location = New System.Drawing.Point(194, 369)
        Me.LocationTextBox.Name = "LocationTextBox"
        Me.LocationTextBox.ReadOnly = True
        Me.LocationTextBox.Size = New System.Drawing.Size(220, 41)
        Me.LocationTextBox.TabIndex = 19
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 418)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 32)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Notes:"
        '
        'NotesTextBox
        '
        Me.NotesTextBox.Location = New System.Drawing.Point(170, 435)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(289, 178)
        Me.NotesTextBox.TabIndex = 17
        '
        'MedicationTextBox
        '
        Me.MedicationTextBox.Location = New System.Drawing.Point(194, 320)
        Me.MedicationTextBox.Name = "MedicationTextBox"
        Me.MedicationTextBox.Size = New System.Drawing.Size(102, 41)
        Me.MedicationTextBox.TabIndex = 16
        '
        'PatientAgeTextBox
        '
        Me.PatientAgeTextBox.Location = New System.Drawing.Point(194, 272)
        Me.PatientAgeTextBox.Name = "PatientAgeTextBox"
        Me.PatientAgeTextBox.Size = New System.Drawing.Size(102, 41)
        Me.PatientAgeTextBox.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.RelationshipTextBox)
        Me.GroupBox1.Controls.Add(Me.ContactFNTextBox)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.ContactLNTextBox)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(489, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 337)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Emergency Contact Information:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(12, 171)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(220, 41)
        Me.TextBox4.TabIndex = 14
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(199, 32)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Phone Number"
        '
        'RelationshipTextBox
        '
        Me.RelationshipTextBox.Location = New System.Drawing.Point(493, 72)
        Me.RelationshipTextBox.Name = "RelationshipTextBox"
        Me.RelationshipTextBox.Size = New System.Drawing.Size(220, 41)
        Me.RelationshipTextBox.TabIndex = 15
        '
        'ContactFNTextBox
        '
        Me.ContactFNTextBox.Location = New System.Drawing.Point(256, 72)
        Me.ContactFNTextBox.Name = "ContactFNTextBox"
        Me.ContactFNTextBox.Size = New System.Drawing.Size(220, 41)
        Me.ContactFNTextBox.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(492, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(174, 32)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Relationship:"
        '
        'ContactLNTextBox
        '
        Me.ContactLNTextBox.Location = New System.Drawing.Point(12, 72)
        Me.ContactLNTextBox.Name = "ContactLNTextBox"
        Me.ContactLNTextBox.Size = New System.Drawing.Size(220, 41)
        Me.ContactLNTextBox.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(260, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 32)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "First Name:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(153, 32)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Last Name:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(35, 369)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 32)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Location:"
        '
        'PatientDOBMaskedTextBox
        '
        Me.PatientDOBMaskedTextBox.Location = New System.Drawing.Point(194, 216)
        Me.PatientDOBMaskedTextBox.Mask = "00/00/0000"
        Me.PatientDOBMaskedTextBox.Name = "PatientDOBMaskedTextBox"
        Me.PatientDOBMaskedTextBox.Size = New System.Drawing.Size(166, 41)
        Me.PatientDOBMaskedTextBox.TabIndex = 8
        Me.PatientDOBMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(171, 32)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Medications:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(106, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 32)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Age"
        '
        'PatientLNTextBox
        '
        Me.PatientLNTextBox.Location = New System.Drawing.Point(194, 160)
        Me.PatientLNTextBox.Name = "PatientLNTextBox"
        Me.PatientLNTextBox.Size = New System.Drawing.Size(265, 41)
        Me.PatientLNTextBox.TabIndex = 7
        '
        'PatientFNTextBox
        '
        Me.PatientFNTextBox.Location = New System.Drawing.Point(194, 104)
        Me.PatientFNTextBox.Name = "PatientFNTextBox"
        Me.PatientFNTextBox.Size = New System.Drawing.Size(265, 41)
        Me.PatientFNTextBox.TabIndex = 5
        '
        'PatientIDTextBox
        '
        Me.PatientIDTextBox.Location = New System.Drawing.Point(194, 48)
        Me.PatientIDTextBox.Name = "PatientIDTextBox"
        Me.PatientIDTextBox.Size = New System.Drawing.Size(220, 41)
        Me.PatientIDTextBox.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "D.O.B"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient ID:"
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.SystemColors.Window
        Me.HomeButton.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeButton.Location = New System.Drawing.Point(876, 752)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(124, 44)
        Me.HomeButton.TabIndex = 2
        Me.HomeButton.Text = "&Home"
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Window
        Me.ExitButton.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(1196, 752)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(124, 44)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.SystemColors.Window
        Me.BackButton.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(1036, 752)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(124, 44)
        Me.BackButton.TabIndex = 4
        Me.BackButton.Text = "&Back"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'AddPatientForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1401, 808)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.PatientGroupBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AddPatientForm"
        Me.Text = "ADD NEW PATIENT "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PatientGroupBox.ResumeLayout(False)
        Me.PatientGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PatientGroupBox As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PatientDOBMaskedTextBox As MaskedTextBox
    Friend WithEvents PatientLNTextBox As TextBox
    Friend WithEvents PatientFNTextBox As TextBox
    Friend WithEvents PatientIDTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents NotesTextBox As TextBox
    Friend WithEvents MedicationTextBox As TextBox
    Friend WithEvents PatientAgeTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents RelationshipTextBox As TextBox
    Friend WithEvents ContactFNTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ContactLNTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LocationTextBox As TextBox
    Friend WithEvents HomeButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents BackButton As Button
End Class
