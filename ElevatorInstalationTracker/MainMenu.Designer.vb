<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NewJobButton = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewJobButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.ElevatorInstalationTracker.My.Resources.Resources.folder
        Me.PictureBox1.Location = New System.Drawing.Point(509, 293)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'NewJobButton
        '
        Me.NewJobButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NewJobButton.Image = Global.ElevatorInstalationTracker.My.Resources.Resources.Add
        Me.NewJobButton.Location = New System.Drawing.Point(174, 293)
        Me.NewJobButton.Name = "NewJobButton"
        Me.NewJobButton.Size = New System.Drawing.Size(200, 200)
        Me.NewJobButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.NewJobButton.TabIndex = 0
        Me.NewJobButton.TabStop = False
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 596)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.NewJobButton)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewJobButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NewJobButton As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
