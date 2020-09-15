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
        Me.SuspendLayout()
        '
        'Card1
        '
        Me.Card1.Location = New System.Drawing.Point(72, 311)
        Me.Card1.Name = "Card1"
        Me.Card1.Size = New System.Drawing.Size(200, 100)
        Me.Card1.TabIndex = 0
        Me.Card1.TabStop = False
        Me.Card1.Text = "Sell Lift"
        '
        'JobForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 844)
        Me.Controls.Add(Me.Card1)
        Me.Name = "JobForm"
        Me.Text = "JobForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Card1 As GroupBox
End Class
