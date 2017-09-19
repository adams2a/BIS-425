<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Me.UserIDLabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.InventoryButton = New System.Windows.Forms.Button()
        Me.EmployeeButton = New System.Windows.Forms.Button()
        Me.ReportButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PatientsButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UserIDLabel
        '
        Me.UserIDLabel.AutoSize = True
        Me.UserIDLabel.Location = New System.Drawing.Point(497, 83)
        Me.UserIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UserIDLabel.Name = "UserIDLabel"
        Me.UserIDLabel.Size = New System.Drawing.Size(0, 32)
        Me.UserIDLabel.TabIndex = 0
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Window
        Me.Button2.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(301, 507)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 53)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "&ADMIN "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'InventoryButton
        '
        Me.InventoryButton.BackColor = System.Drawing.SystemColors.Window
        Me.InventoryButton.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InventoryButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.InventoryButton.Location = New System.Drawing.Point(72, 507)
        Me.InventoryButton.Margin = New System.Windows.Forms.Padding(4)
        Me.InventoryButton.Name = "InventoryButton"
        Me.InventoryButton.Size = New System.Drawing.Size(206, 53)
        Me.InventoryButton.TabIndex = 4
        Me.InventoryButton.Text = "&INVENTORY"
        Me.InventoryButton.UseVisualStyleBackColor = False
        '
        'EmployeeButton
        '
        Me.EmployeeButton.BackColor = System.Drawing.SystemColors.Window
        Me.EmployeeButton.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.EmployeeButton.Location = New System.Drawing.Point(301, 435)
        Me.EmployeeButton.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployeeButton.Name = "EmployeeButton"
        Me.EmployeeButton.Size = New System.Drawing.Size(206, 53)
        Me.EmployeeButton.TabIndex = 3
        Me.EmployeeButton.Text = "&EMPLOYEES"
        Me.EmployeeButton.UseVisualStyleBackColor = False
        '
        'ReportButton
        '
        Me.ReportButton.BackColor = System.Drawing.SystemColors.Window
        Me.ReportButton.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ReportButton.Location = New System.Drawing.Point(72, 587)
        Me.ReportButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportButton.Name = "ReportButton"
        Me.ReportButton.Size = New System.Drawing.Size(206, 53)
        Me.ReportButton.TabIndex = 2
        Me.ReportButton.Text = "&REPORTS"
        Me.ReportButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Window
        Me.ExitButton.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ExitButton.Location = New System.Drawing.Point(301, 587)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(206, 53)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "E&XIT"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'PatientsButton
        '
        Me.PatientsButton.BackColor = System.Drawing.SystemColors.Window
        Me.PatientsButton.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientsButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PatientsButton.Location = New System.Drawing.Point(72, 435)
        Me.PatientsButton.Margin = New System.Windows.Forms.Padding(4)
        Me.PatientsButton.Name = "PatientsButton"
        Me.PatientsButton.Size = New System.Drawing.Size(206, 53)
        Me.PatientsButton.TabIndex = 0
        Me.PatientsButton.Text = "&PATIENTS"
        Me.PatientsButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(220, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 32)
        Me.Label1.TabIndex = 6
        '
        'HomeForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(558, 663)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.EmployeeButton)
        Me.Controls.Add(Me.InventoryButton)
        Me.Controls.Add(Me.ReportButton)
        Me.Controls.Add(Me.UserIDLabel)
        Me.Controls.Add(Me.PatientsButton)
        Me.Font = New System.Drawing.Font("Book Antiqua", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HomeForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ABUNDANT LIFE HOMES"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UserIDLabel As Label
    Friend WithEvents EmployeeButton As Button
    Friend WithEvents ReportButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents PatientsButton As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents InventoryButton As Button
    Friend WithEvents Label1 As Label
End Class
