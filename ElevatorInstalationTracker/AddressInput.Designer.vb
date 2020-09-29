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
        Me.AddressInputText = New System.Windows.Forms.TextBox()
        Me.SubmitAddress = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddressInputText
        '
        Me.AddressInputText.Location = New System.Drawing.Point(23, 73)
        Me.AddressInputText.Name = "AddressInputText"
        Me.AddressInputText.Size = New System.Drawing.Size(701, 26)
        Me.AddressInputText.TabIndex = 0
        '
        'SubmitAddress
        '
        Me.SubmitAddress.Location = New System.Drawing.Point(730, 67)
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
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(887, 200)
        Me.Controls.Add(Me.SubmitAddress)
        Me.Controls.Add(Me.AddressInputText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AddressInput"
        Me.Text = "AddressInput"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddressInputText As TextBox
    Friend WithEvents SubmitAddress As Button
End Class
