<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupportPageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserIDLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PWTextBox = New System.Windows.Forms.TextBox()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.ClientLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.ClientComboBox = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.SystemColors.Window
        Me.LoginButton.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.Location = New System.Drawing.Point(29, 601)
        Me.LoginButton.Margin = New System.Windows.Forms.Padding(4)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(141, 43)
        Me.LoginButton.TabIndex = 4
        Me.LoginButton.Text = "&Log &In"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'CancelButton
        '
        Me.CancelButton.BackColor = System.Drawing.SystemColors.Window
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelButton.Location = New System.Drawing.Point(377, 601)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(141, 43)
        Me.CancelButton.TabIndex = 6
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 13.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(12, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(552, 52)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Community Living Services"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.SystemColors.Window
        Me.ClearButton.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(203, 601)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(141, 43)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "&Clear Text"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Highlight
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(554, 40)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUsToolStripMenuItem, Me.ContactToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 36)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(212, 38)
        Me.AboutUsToolStripMenuItem.Text = "&About Us"
        Me.AboutUsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(212, 38)
        Me.ContactToolStripMenuItem.Text = "&Contact"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(212, 38)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupportPageToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(77, 36)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'SupportPageToolStripMenuItem
        '
        Me.SupportPageToolStripMenuItem.Name = "SupportPageToolStripMenuItem"
        Me.SupportPageToolStripMenuItem.Size = New System.Drawing.Size(257, 38)
        Me.SupportPageToolStripMenuItem.Text = "&Support Page"
        '
        'UserIDLabel
        '
        Me.UserIDLabel.BackColor = System.Drawing.Color.Transparent
        Me.UserIDLabel.Font = New System.Drawing.Font("Book Antiqua", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserIDLabel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.UserIDLabel.Location = New System.Drawing.Point(12, 480)
        Me.UserIDLabel.Name = "UserIDLabel"
        Me.UserIDLabel.Size = New System.Drawing.Size(185, 32)
        Me.UserIDLabel.TabIndex = 15
        Me.UserIDLabel.Text = "USER ID:"
        Me.UserIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(40, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(475, 98)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Abundant Life Homes"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PWTextBox
        '
        Me.PWTextBox.BackColor = System.Drawing.Color.White
        Me.PWTextBox.Font = New System.Drawing.Font("Book Antiqua", 10.125!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PWTextBox.ForeColor = System.Drawing.SystemColors.Desktop
        Me.PWTextBox.Location = New System.Drawing.Point(217, 522)
        Me.PWTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PWTextBox.Name = "PWTextBox"
        Me.PWTextBox.Size = New System.Drawing.Size(249, 40)
        Me.PWTextBox.TabIndex = 3
        Me.PWTextBox.UseSystemPasswordChar = True
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.BackColor = System.Drawing.Color.White
        Me.UserIDTextBox.ForeColor = System.Drawing.SystemColors.Desktop
        Me.UserIDTextBox.Location = New System.Drawing.Point(217, 476)
        Me.UserIDTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(249, 41)
        Me.UserIDTextBox.TabIndex = 2
        '
        'ClientLabel
        '
        Me.ClientLabel.BackColor = System.Drawing.Color.Transparent
        Me.ClientLabel.Font = New System.Drawing.Font("Book Antiqua", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientLabel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ClientLabel.Location = New System.Drawing.Point(14, 435)
        Me.ClientLabel.Name = "ClientLabel"
        Me.ClientLabel.Size = New System.Drawing.Size(185, 32)
        Me.ClientLabel.TabIndex = 12
        Me.ClientLabel.Text = "CLIENT:"
        Me.ClientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.PasswordLabel.Font = New System.Drawing.Font("Book Antiqua", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.PasswordLabel.Location = New System.Drawing.Point(14, 526)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(185, 32)
        Me.PasswordLabel.TabIndex = 17
        Me.PasswordLabel.Text = "PASSWORD:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ClientComboBox
        '
        Me.ClientComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClientComboBox.FormattingEnabled = True
        Me.ClientComboBox.Items.AddRange(New Object() {"901", "902", "903"})
        Me.ClientComboBox.Location = New System.Drawing.Point(217, 431)
        Me.ClientComboBox.Name = "ClientComboBox"
        Me.ClientComboBox.Size = New System.Drawing.Size(121, 40)
        Me.ClientComboBox.TabIndex = 1
        '
        'LoginForm
        '
        Me.AcceptButton = Me.LoginButton
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(554, 659)
        Me.Controls.Add(Me.PWTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UserIDLabel)
        Me.Controls.Add(Me.UserIDTextBox)
        Me.Controls.Add(Me.ClientComboBox)
        Me.Controls.Add(Me.ClientLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.LoginButton)
        Me.Font = New System.Drawing.Font("Book Antiqua", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LoginForm"
        Me.Text = "WELCOME TO THE LIFELINE"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LoginButton As Button
    Friend WithEvents CancelButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupportPageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserIDLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PWTextBox As TextBox
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents ClientLabel As Label
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents ClientComboBox As ComboBox
End Class
