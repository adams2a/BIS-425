<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatientOption
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatientOption))
        Me.AddButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.HomeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.SystemColors.Window
        Me.AddButton.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(69, 109)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(141, 43)
        Me.AddButton.TabIndex = 0
        Me.AddButton.Text = "&Add &Patient"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.SystemColors.Window
        Me.EditButton.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.Location = New System.Drawing.Point(498, 109)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(141, 43)
        Me.EditButton.TabIndex = 3
        Me.EditButton.Text = "&Edit &Patient"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Window
        Me.Button1.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(291, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 43)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Search "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Window
        Me.ExitButton.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(394, 236)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(141, 43)
        Me.ExitButton.TabIndex = 5
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'HomeButton
        '
        Me.HomeButton.BackColor = System.Drawing.SystemColors.Window
        Me.HomeButton.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeButton.Location = New System.Drawing.Point(174, 236)
        Me.HomeButton.Name = "HomeButton"
        Me.HomeButton.Size = New System.Drawing.Size(141, 43)
        Me.HomeButton.TabIndex = 6
        Me.HomeButton.Text = "&Home"
        Me.HomeButton.UseVisualStyleBackColor = False
        '
        'PatientOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(709, 312)
        Me.Controls.Add(Me.HomeButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.EditButton)
        Me.Controls.Add(Me.AddButton)
        Me.Name = "PatientOption"
        Me.Text = "PAIENT OPTIONS"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents HomeButton As Button
End Class
