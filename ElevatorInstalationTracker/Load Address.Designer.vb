<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadAddress
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadAddress))
        Me.LoadCombo = New System.Windows.Forms.ComboBox()
        Me.ComboLoadButton = New System.Windows.Forms.Button()
        Me.FIleLoadButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'LoadCombo
        '
        Me.LoadCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadCombo.FormattingEnabled = True
        Me.LoadCombo.Location = New System.Drawing.Point(12, 73)
        Me.LoadCombo.Name = "LoadCombo"
        Me.LoadCombo.Size = New System.Drawing.Size(606, 45)
        Me.LoadCombo.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.LoadCombo, "List of Existing Jobs")
        '
        'ComboLoadButton
        '
        Me.ComboLoadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboLoadButton.Location = New System.Drawing.Point(633, 73)
        Me.ComboLoadButton.Name = "ComboLoadButton"
        Me.ComboLoadButton.Size = New System.Drawing.Size(211, 70)
        Me.ComboLoadButton.TabIndex = 1
        Me.ComboLoadButton.Text = "Load Job"
        Me.ToolTip1.SetToolTip(Me.ComboLoadButton, "Load Job From Selection")
        Me.ComboLoadButton.UseVisualStyleBackColor = True
        '
        'FIleLoadButton
        '
        Me.FIleLoadButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIleLoadButton.Location = New System.Drawing.Point(12, 133)
        Me.FIleLoadButton.Name = "FIleLoadButton"
        Me.FIleLoadButton.Size = New System.Drawing.Size(211, 74)
        Me.FIleLoadButton.TabIndex = 2
        Me.FIleLoadButton.Text = "Pick Job From File"
        Me.ToolTip1.SetToolTip(Me.FIleLoadButton, "Load Job From a File")
        Me.FIleLoadButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(633, 166)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(211, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Sort Jobs"
        Me.ToolTip1.SetToolTip(Me.Button1, "Re-Sort List of Jobs")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LoadAddress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(887, 378)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FIleLoadButton)
        Me.Controls.Add(Me.ComboLoadButton)
        Me.Controls.Add(Me.LoadCombo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoadAddress"
        Me.Text = "Load Address"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoadCombo As ComboBox
    Friend WithEvents ComboLoadButton As Button
    Friend WithEvents FIleLoadButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
