<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressInput
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SubmitAddress = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(509, 26)
        Me.TextBox1.TabIndex = 0
        '
        'SubmitAddress
        '
        Me.SubmitAddress.Location = New System.Drawing.Point(200, 44)
        Me.SubmitAddress.Name = "SubmitAddress"
        Me.SubmitAddress.Size = New System.Drawing.Size(134, 38)
        Me.SubmitAddress.TabIndex = 1
        Me.SubmitAddress.Text = "Submit Address"
        Me.SubmitAddress.UseVisualStyleBackColor = True
        '
        'AddressInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 97)
        Me.Controls.Add(Me.SubmitAddress)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "AddressInput"
        Me.Text = "AddressInput"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SubmitAddress As Button
End Class
