<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.SearchGroupBox = New System.Windows.Forms.GroupBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LNLabel = New System.Windows.Forms.Label()
        Me.FNLabel = New System.Windows.Forms.Label()
        Me.DBDataGridView = New System.Windows.Forms.DataGridView()
        Me.SearchGroupBox.SuspendLayout()
        CType(Me.DBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchGroupBox
        '
        Me.SearchGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.SearchGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.SearchGroupBox.Controls.Add(Me.LNLabel)
        Me.SearchGroupBox.Controls.Add(Me.FNLabel)
        Me.SearchGroupBox.Location = New System.Drawing.Point(52, 43)
        Me.SearchGroupBox.Name = "SearchGroupBox"
        Me.SearchGroupBox.Size = New System.Drawing.Size(901, 100)
        Me.SearchGroupBox.TabIndex = 0
        Me.SearchGroupBox.TabStop = False
        Me.SearchGroupBox.Text = "Search"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(534, 41)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(176, 31)
        Me.LastNameTextBox.TabIndex = 1
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(134, 41)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(176, 31)
        Me.FirstNameTextBox.TabIndex = 2
        '
        'LNLabel
        '
        Me.LNLabel.AutoSize = True
        Me.LNLabel.Location = New System.Drawing.Point(407, 44)
        Me.LNLabel.Name = "LNLabel"
        Me.LNLabel.Size = New System.Drawing.Size(121, 25)
        Me.LNLabel.TabIndex = 1
        Me.LNLabel.Text = "Last Name:"
        '
        'FNLabel
        '
        Me.FNLabel.AutoSize = True
        Me.FNLabel.Location = New System.Drawing.Point(6, 41)
        Me.FNLabel.Name = "FNLabel"
        Me.FNLabel.Size = New System.Drawing.Size(122, 25)
        Me.FNLabel.TabIndex = 0
        Me.FNLabel.Text = "First Name:"
        '
        'DBDataGridView
        '
        Me.DBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DBDataGridView.Location = New System.Drawing.Point(52, 169)
        Me.DBDataGridView.Name = "DBDataGridView"
        Me.DBDataGridView.RowTemplate.Height = 33
        Me.DBDataGridView.Size = New System.Drawing.Size(901, 263)
        Me.DBDataGridView.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 584)
        Me.Controls.Add(Me.DBDataGridView)
        Me.Controls.Add(Me.SearchGroupBox)
        Me.Name = "Form1"
        Me.Text = "Customer Search"
        Me.SearchGroupBox.ResumeLayout(False)
        Me.SearchGroupBox.PerformLayout()
        CType(Me.DBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SearchGroupBox As GroupBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LNLabel As Label
    Friend WithEvents FNLabel As Label
    Friend WithEvents DBDataGridView As DataGridView
End Class
