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
        Me.LoadCombo = New System.Windows.Forms.ComboBox()
        Me.ComboLoadButton = New System.Windows.Forms.Button()
        Me.FIleLoadButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'LoadCombo
        '
        Me.LoadCombo.FormattingEnabled = True
        Me.LoadCombo.Location = New System.Drawing.Point(10, 26)
        Me.LoadCombo.Name = "LoadCombo"
        Me.LoadCombo.Size = New System.Drawing.Size(415, 28)
        Me.LoadCombo.TabIndex = 0
        '
        'ComboLoadButton
        '
        Me.ComboLoadButton.Location = New System.Drawing.Point(431, 21)
        Me.ComboLoadButton.Name = "ComboLoadButton"
        Me.ComboLoadButton.Size = New System.Drawing.Size(211, 37)
        Me.ComboLoadButton.TabIndex = 1
        Me.ComboLoadButton.Text = "Load Job"
        Me.ComboLoadButton.UseVisualStyleBackColor = True
        '
        'FIleLoadButton
        '
        Me.FIleLoadButton.Location = New System.Drawing.Point(217, 60)
        Me.FIleLoadButton.Name = "FIleLoadButton"
        Me.FIleLoadButton.Size = New System.Drawing.Size(171, 74)
        Me.FIleLoadButton.TabIndex = 2
        Me.FIleLoadButton.Text = "Load Job From File"
        Me.FIleLoadButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LoadAddress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(654, 151)
        Me.Controls.Add(Me.FIleLoadButton)
        Me.Controls.Add(Me.ComboLoadButton)
        Me.Controls.Add(Me.LoadCombo)
        Me.Name = "LoadAddress"
        Me.Text = "Load Address"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoadCombo As ComboBox
    Friend WithEvents ComboLoadButton As Button
    Friend WithEvents FIleLoadButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
