<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobForm
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
        Me.Card1 = New System.Windows.Forms.GroupBox()
        Me.FileLocationText = New System.Windows.Forms.Label()
        Me.OpenFileButton = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.AddressText = New System.Windows.Forms.Label()
        Me.Card1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Card1
        '
        Me.Card1.Controls.Add(Me.FileLocationText)
        Me.Card1.Controls.Add(Me.OpenFileButton)
        Me.Card1.Controls.Add(Me.CheckBox1)
        Me.Card1.Location = New System.Drawing.Point(13, 58)
        Me.Card1.Name = "Card1"
        Me.Card1.Size = New System.Drawing.Size(362, 100)
        Me.Card1.TabIndex = 0
        Me.Card1.TabStop = False
        Me.Card1.Text = "Sell Lift"
        '
        'FileLocationText
        '
        Me.FileLocationText.AutoSize = True
        Me.FileLocationText.Location = New System.Drawing.Point(6, 77)
        Me.FileLocationText.Name = "FileLocationText"
        Me.FileLocationText.Size = New System.Drawing.Size(284, 20)
        Me.FileLocationText.TabIndex = 2
        Me.FileLocationText.Text = "C:\Users\myles\Desktop\Tracker Folder"
        '
        'OpenFileButton
        '
        Me.OpenFileButton.Location = New System.Drawing.Point(6, 25)
        Me.OpenFileButton.Name = "OpenFileButton"
        Me.OpenFileButton.Size = New System.Drawing.Size(116, 39)
        Me.OpenFileButton.TabIndex = 1
        Me.OpenFileButton.Text = "Add File"
        Me.OpenFileButton.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(128, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(116, 24)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AddressText
        '
        Me.AddressText.AutoSize = True
        Me.AddressText.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressText.Location = New System.Drawing.Point(8, 9)
        Me.AddressText.Name = "AddressText"
        Me.AddressText.Size = New System.Drawing.Size(86, 29)
        Me.AddressText.TabIndex = 1
        Me.AddressText.Text = "Label1"
        '
        'JobForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 844)
        Me.Controls.Add(Me.AddressText)
        Me.Controls.Add(Me.Card1)
        Me.Name = "JobForm"
        Me.Text = "JobForm"
        Me.Card1.ResumeLayout(False)
        Me.Card1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Card1 As GroupBox
    Friend WithEvents FileLocationText As Label
    Friend WithEvents OpenFileButton As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents AddressText As Label
End Class
