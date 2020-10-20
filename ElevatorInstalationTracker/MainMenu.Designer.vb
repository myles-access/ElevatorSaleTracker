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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.LoadFileButton = New System.Windows.Forms.PictureBox()
        Me.NewJobButton = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.LoadFileButton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewJobButton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LoadFileButton
        '
        Me.LoadFileButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoadFileButton.Image = Global.ElevatorInstalationTracker.My.Resources.Resources.folder
        Me.LoadFileButton.Location = New System.Drawing.Point(344, 837)
        Me.LoadFileButton.Name = "LoadFileButton"
        Me.LoadFileButton.Size = New System.Drawing.Size(200, 200)
        Me.LoadFileButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.LoadFileButton.TabIndex = 1
        Me.LoadFileButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.LoadFileButton, "Load Existing Job")
        '
        'NewJobButton
        '
        Me.NewJobButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NewJobButton.Image = Global.ElevatorInstalationTracker.My.Resources.Resources.Add
        Me.NewJobButton.Location = New System.Drawing.Point(344, 584)
        Me.NewJobButton.Name = "NewJobButton"
        Me.NewJobButton.Size = New System.Drawing.Size(200, 200)
        Me.NewJobButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.NewJobButton.TabIndex = 0
        Me.NewJobButton.TabStop = False
        Me.ToolTip1.SetToolTip(Me.NewJobButton, "Create a New Job")
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(878, 1144)
        Me.Controls.Add(Me.LoadFileButton)
        Me.Controls.Add(Me.NewJobButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MainMenu"
        CType(Me.LoadFileButton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewJobButton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NewJobButton As PictureBox
    Friend WithEvents LoadFileButton As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
