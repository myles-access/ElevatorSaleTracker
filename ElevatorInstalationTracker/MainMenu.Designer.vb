<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainMenu
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
        Me.LoadFileButton = New System.Windows.Forms.PictureBox()
        Me.NewJobButton = New System.Windows.Forms.PictureBox()
        CType(Me.LoadFileButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewJobButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadFileButton
        '
        Me.LoadFileButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoadFileButton.Image = Global.ElevatorInstalationTracker.My.Resources.Resources.folder
        Me.LoadFileButton.Location = New System.Drawing.Point(488, 657)
        Me.LoadFileButton.Name = "LoadFileButton"
        Me.LoadFileButton.Size = New System.Drawing.Size(200, 200)
        Me.LoadFileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LoadFileButton.TabIndex = 1
        Me.LoadFileButton.TabStop = False
        '
        'NewJobButton
        '
        Me.NewJobButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NewJobButton.Image = Global.ElevatorInstalationTracker.My.Resources.Resources.Add
        Me.NewJobButton.Location = New System.Drawing.Point(184, 657)
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
        Me.ClientSize = New System.Drawing.Size(891, 1081)
        Me.Controls.Add(Me.LoadFileButton)
        Me.Controls.Add(Me.NewJobButton)
        Me.IsMdiContainer = True
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        CType(Me.LoadFileButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewJobButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NewJobButton As PictureBox
    Friend WithEvents LoadFileButton As PictureBox
End Class
