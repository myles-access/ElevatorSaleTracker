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
        Me.FileLocationText1 = New System.Windows.Forms.Label()
        Me.OpenFileButton1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.AddressText = New System.Windows.Forms.Label()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FileLocationText2 = New System.Windows.Forms.Label()
        Me.OpenFileButton2 = New System.Windows.Forms.Button()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.FileLocationText3 = New System.Windows.Forms.Label()
        Me.OpenFileButton3 = New System.Windows.Forms.Button()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Card1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Card1
        '
        Me.Card1.Controls.Add(Me.FileLocationText1)
        Me.Card1.Controls.Add(Me.OpenFileButton1)
        Me.Card1.Controls.Add(Me.CheckBox1)
        Me.Card1.Location = New System.Drawing.Point(13, 58)
        Me.Card1.Name = "Card1"
        Me.Card1.Size = New System.Drawing.Size(362, 100)
        Me.Card1.TabIndex = 0
        Me.Card1.TabStop = False
        Me.Card1.Text = "Sell Lift"
        '
        'FileLocationText1
        '
        Me.FileLocationText1.AutoSize = True
        Me.FileLocationText1.Location = New System.Drawing.Point(6, 77)
        Me.FileLocationText1.Name = "FileLocationText1"
        Me.FileLocationText1.Size = New System.Drawing.Size(125, 20)
        Me.FileLocationText1.TabIndex = 2
        Me.FileLocationText1.Text = "No File Selected"
        '
        'OpenFileButton1
        '
        Me.OpenFileButton1.Location = New System.Drawing.Point(6, 25)
        Me.OpenFileButton1.Name = "OpenFileButton1"
        Me.OpenFileButton1.Size = New System.Drawing.Size(116, 39)
        Me.OpenFileButton1.TabIndex = 1
        Me.OpenFileButton1.Text = "Add File"
        Me.OpenFileButton1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(178, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 24)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Completed"
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
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(383, 798)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(89, 34)
        Me.SaveButton.TabIndex = 2
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FileLocationText2)
        Me.GroupBox1.Controls.Add(Me.OpenFileButton2)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(504, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(362, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buy Lift"
        '
        'FileLocationText2
        '
        Me.FileLocationText2.AutoSize = True
        Me.FileLocationText2.Location = New System.Drawing.Point(6, 77)
        Me.FileLocationText2.Name = "FileLocationText2"
        Me.FileLocationText2.Size = New System.Drawing.Size(125, 20)
        Me.FileLocationText2.TabIndex = 2
        Me.FileLocationText2.Text = "No File Selected"
        '
        'OpenFileButton2
        '
        Me.OpenFileButton2.Location = New System.Drawing.Point(6, 25)
        Me.OpenFileButton2.Name = "OpenFileButton2"
        Me.OpenFileButton2.Size = New System.Drawing.Size(116, 39)
        Me.OpenFileButton2.TabIndex = 1
        Me.OpenFileButton2.Text = "Add File"
        Me.OpenFileButton2.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(178, 33)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(112, 24)
        Me.CheckBox2.TabIndex = 0
        Me.CheckBox2.Text = "Completed"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.FileLocationText3)
        Me.GroupBox2.Controls.Add(Me.OpenFileButton3)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(362, 100)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ride Lift"
        '
        'FileLocationText3
        '
        Me.FileLocationText3.AutoSize = True
        Me.FileLocationText3.Location = New System.Drawing.Point(6, 77)
        Me.FileLocationText3.Name = "FileLocationText3"
        Me.FileLocationText3.Size = New System.Drawing.Size(125, 20)
        Me.FileLocationText3.TabIndex = 2
        Me.FileLocationText3.Text = "No File Selected"
        '
        'OpenFileButton3
        '
        Me.OpenFileButton3.Location = New System.Drawing.Point(6, 25)
        Me.OpenFileButton3.Name = "OpenFileButton3"
        Me.OpenFileButton3.Size = New System.Drawing.Size(116, 39)
        Me.OpenFileButton3.TabIndex = 1
        Me.OpenFileButton3.Text = "Add File"
        Me.OpenFileButton3.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(178, 33)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(112, 24)
        Me.CheckBox3.TabIndex = 0
        Me.CheckBox3.Text = "Completed"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'JobForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 844)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.AddressText)
        Me.Controls.Add(Me.Card1)
        Me.Name = "JobForm"
        Me.Text = "JobForm"
        Me.Card1.ResumeLayout(False)
        Me.Card1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Card1 As GroupBox
    Friend WithEvents FileLocationText1 As Label
    Friend WithEvents OpenFileButton1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents AddressText As Label
    Friend WithEvents SaveButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FileLocationText2 As Label
    Friend WithEvents OpenFileButton2 As Button
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents FileLocationText3 As Label
    Friend WithEvents OpenFileButton3 As Button
    Friend WithEvents CheckBox3 As CheckBox
End Class
