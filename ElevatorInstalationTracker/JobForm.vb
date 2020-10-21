Imports System.IO

Public Class JobForm
    Public FileWriter As StreamWriter
    Public AddressFolderLocation As String
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        SaveForm()
    End Sub
    Private Sub JobForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MainMenu
        'Me.Size = JobForm.Size
        Me.WindowState = FormWindowState.Maximized
        Me.Top = 0
        Me.Left = 0
    End Sub

    Public Sub JobForm_FormClosing(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosing
        '    FileWriter.Close()
        SaveForm()
        'MainMenu.ShutdownProgram()
        MainMenu.NewJobButton.Visible = True
        MainMenu.LoadFileButton.Visible = True
    End Sub

    Private Sub AddFile(cardStr As Label)
        Dim path As String
        Dim file As String

        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then

            path = OpenFileDialog1.FileName
            file = Dir(path)

            If Directory.Exists(cardStr.Text = (My.Settings.FolderLocation & AddressText.Text & "\" & file)) Then
                Exit Sub
            Else
                If cardStr.Text <> "No File Selected" Then
                    My.Computer.FileSystem.DeleteFile(cardStr.Text)
                End If

                cardStr.Text = (My.Settings.FolderLocation & AddressText.Text & "\" & file)
                My.Computer.FileSystem.CopyFile(path, My.Settings.FolderLocation & AddressText.Text & "\" & file)
            End If
        End If

        RefreshForm()
    End Sub

    Private Sub SaveForm()
        'Need to fix by checking if the filewriter is null and closing if not. but check isnt working so needs revisiting
        'FileWriter.Close()

        FileWriter = New StreamWriter(My.Settings.FolderLocation & AddressText.Text & "\#tracker.txt", False)

        FileWriter.WriteLine(AddressText.Name & "|" & AddressText.Text)

        FileWriter.WriteLine(CheckBox1.Name & "|" & CheckBox1.Checked.ToString())
        FileWriter.WriteLine(FileLocationText1.Name & "|" & FileLocationText1.Text)

        FileWriter.WriteLine(CheckBox2.Name & "|" & CheckBox2.Checked.ToString())
        FileWriter.WriteLine(FileLocationText2.Name & "|" & FileLocationText2.Text)

        FileWriter.WriteLine(CheckBox3.Name & "|" & CheckBox3.Checked.ToString())
        FileWriter.WriteLine(FileLocationText3.Name & "|" & FileLocationText3.Text)

        FileWriter.WriteLine(CheckBox4.Name & "|" & CheckBox4.Checked.ToString())
        FileWriter.WriteLine(FileLocationText4.Name & "|" & FileLocationText4.Text)

        FileWriter.WriteLine(CheckBox5.Name & "|" & CheckBox5.Checked.ToString())
        FileWriter.WriteLine(FileLocationText5.Name & "|" & FileLocationText5.Text)

        FileWriter.WriteLine(CheckBox6.Name & "|" & CheckBox6.Checked.ToString())
        FileWriter.WriteLine(FileLocationText6.Name & "|" & FileLocationText6.Text)

        FileWriter.WriteLine(CheckBox7.Name & "|" & CheckBox7.Checked.ToString())
        FileWriter.WriteLine(FileLocationText7.Name & "|" & FileLocationText7.Text)

        FileWriter.WriteLine(CheckBox8.Name & "|" & CheckBox8.Checked.ToString())
        FileWriter.WriteLine(FileLocationText8.Name & "|" & FileLocationText8.Text)

        FileWriter.WriteLine(CheckBox9.Name & "|" & CheckBox9.Checked.ToString())
        FileWriter.WriteLine(FileLocationText9.Name & "|" & FileLocationText9.Text)

        FileWriter.WriteLine(CheckBox10.Name & "|" & CheckBox10.Checked.ToString())
        FileWriter.WriteLine(FileLocationText10.Name & "|" & FileLocationText10.Text)

        FileWriter.WriteLine(CheckBox11.Name & "|" & CheckBox11.Checked.ToString())
        FileWriter.WriteLine(FileLocationText11.Name & "|" & FileLocationText11.Text)

        FileWriter.WriteLine(CheckBox12.Name & "|" & CheckBox12.Checked.ToString())
        FileWriter.WriteLine(FileLocationText12.Name & "|" & FileLocationText12.Text)

        FileWriter.WriteLine(CheckBox13.Name & "|" & CheckBox13.Checked.ToString())
        FileWriter.WriteLine(FileLocationText13.Name & "|" & FileLocationText13.Text)

        FileWriter.WriteLine(CheckBox14.Name & "|" & CheckBox14.Checked.ToString())
        FileWriter.WriteLine(FileLocationText14.Name & "|" & FileLocationText14.Text)

        FileWriter.WriteLine(CheckBox15.Name & "|" & CheckBox15.Checked.ToString())
        FileWriter.WriteLine(FileLocationText15.Name & "|" & FileLocationText15.Text)

        FileWriter.WriteLine(CheckBox16.Name & "|" & CheckBox16.Checked.ToString())
        FileWriter.WriteLine(FileLocationText16.Name & "|" & FileLocationText16.Text)

        FileWriter.Flush()
        FileWriter.Close()

        'REFRESH-SAVE-LOOP
        'this refresh form method call is part of an infinite loop, do not have it enabled if the SaveForm() call is also enabled within the RefreshForm() method
        'RefreshForm()
    End Sub

    Public Sub RefreshForm()

        If FileLocationText1.Text = "No File Selected" Then
            open1.Enabled = False
        Else
            open1.Enabled = True
        End If

        If FileLocationText2.Text = "No File Selected" Then
            open2.Enabled = False
        Else
            open2.Enabled = True
        End If

        If FileLocationText3.Text = "No File Selected" Then
            open3.Enabled = False
        Else
            open3.Enabled = True
        End If

        If FileLocationText4.Text = "No File Selected" Then
            open4.Enabled = False
        Else
            open4.Enabled = True
        End If

        If FileLocationText5.Text = "No File Selected" Then
            open5.Enabled = False
        Else
            open5.Enabled = True
        End If

        If FileLocationText6.Text = "No File Selected" Then
            open6.Enabled = False
        Else
            open6.Enabled = True
        End If

        If FileLocationText7.Text = "No File Selected" Then
            open7.Enabled = False
        Else
            open7.Enabled = True
        End If

        If FileLocationText8.Text = "No File Selected" Then
            open8.Enabled = False
        Else
            open8.Enabled = True
        End If

        If FileLocationText9.Text = "No File Selected" Then
            open9.Enabled = False
        Else
            open9.Enabled = True
        End If

        If FileLocationText10.Text = "No File Selected" Then
            open10.Enabled = False
        Else
            open10.Enabled = True
        End If

        If FileLocationText11.Text = "No File Selected" Then
            open11.Enabled = False
        Else
            open11.Enabled = True
        End If

        If FileLocationText12.Text = "No File Selected" Then
            open12.Enabled = False
        Else
            open12.Enabled = True
        End If

        If FileLocationText13.Text = "No File Selected" Then
            open13.Enabled = False
        Else
            open13.Enabled = True
        End If

        If FileLocationText14.Text = "No File Selected" Then
            open14.Enabled = False
        Else
            open14.Enabled = True
        End If

        If FileLocationText15.Text = "No File Selected" Then
            open15.Enabled = False
        Else
            open15.Enabled = True
        End If

        If FileLocationText16.Text = "No File Selected" Then
            open16.Enabled = False
        Else
            open16.Enabled = True
        End If

        'REFRESH-SAVE-LOOP 
        'this save form method call is part of an infinite loop, do not have it enabled if the RefreshForm() call is also enabled within the SaveForm() method
        SaveForm()
    End Sub

    Private Sub OpenFileButton_Click(sender As Object, e As EventArgs) Handles OpenFileButton1.Click
        AddFile(FileLocationText1)
    End Sub

    Private Sub OpenFileButton2_Click(sender As Object, e As EventArgs) Handles OpenFileButton2.Click
        AddFile(FileLocationText2)
    End Sub

    Private Sub OpenFileButton3_Click(sender As Object, e As EventArgs) Handles OpenFileButton3.Click
        AddFile(FileLocationText3)
    End Sub

    Private Sub OpenFileButton4_Click(sender As Object, e As EventArgs) Handles OpenFileButton4.Click
        AddFile(FileLocationText4)
    End Sub

    Private Sub OpenFileButton5_Click(sender As Object, e As EventArgs) Handles OpenFileButton5.Click
        AddFile(FileLocationText5)
    End Sub

    Private Sub OpenFileButton6_Click(sender As Object, e As EventArgs) Handles OpenFileButton6.Click
        AddFile(FileLocationText6)
    End Sub

    Private Sub OpenFileButton7_Click(sender As Object, e As EventArgs) Handles OpenFileButton7.Click
        AddFile(FileLocationText7)
    End Sub

    Private Sub OpenFileButton8_Click(sender As Object, e As EventArgs) Handles OpenFileButton8.Click
        AddFile(FileLocationText8)
    End Sub

    Private Sub OpenFileButton9_Click(sender As Object, e As EventArgs) Handles OpenFileButton9.Click
        AddFile(FileLocationText9)
    End Sub

    Private Sub OpenFileButton10_Click(sender As Object, e As EventArgs) Handles OpenFileButton10.Click
        AddFile(FileLocationText10)
    End Sub

    Private Sub OpenFileButton11_Click(sender As Object, e As EventArgs) Handles OpenFileButton11.Click
        AddFile(FileLocationText11)
    End Sub

    Private Sub OpenFileButton12_Click(sender As Object, e As EventArgs) Handles OpenFileButton12.Click
        AddFile(FileLocationText12)
    End Sub

    Private Sub OpenFileButton13_Click(sender As Object, e As EventArgs) Handles OpenFileButton13.Click
        AddFile(FileLocationText13)
    End Sub

    Private Sub OpenFileButton14_Click(sender As Object, e As EventArgs) Handles OpenFileButton14.Click
        AddFile(FileLocationText14)
    End Sub

    Private Sub OpenFileButton15_Click(sender As Object, e As EventArgs) Handles OpenFileButton15.Click
        AddFile(FileLocationText15)
    End Sub

    Private Sub OpenFileButton16_Click(sender As Object, e As EventArgs) Handles OpenFileButton16.Click
        AddFile(FileLocationText16)
    End Sub

    Private Sub open1_Click(sender As Object, e As EventArgs) Handles open1.Click
        Process.Start(FileLocationText1.Text)
    End Sub

    Private Sub open2_Click(sender As Object, e As EventArgs) Handles open2.Click
        Process.Start(FileLocationText2.Text)
    End Sub

    Private Sub open3_Click(sender As Object, e As EventArgs) Handles open3.Click
        Process.Start(FileLocationText3.Text)
    End Sub

    Private Sub open4_Click(sender As Object, e As EventArgs) Handles open4.Click
        Process.Start(FileLocationText4.Text)
    End Sub

    Private Sub open5_Click(sender As Object, e As EventArgs) Handles open5.Click
        Process.Start(FileLocationText5.Text)
    End Sub

    Private Sub open6_Click(sender As Object, e As EventArgs) Handles open6.Click
        Process.Start(FileLocationText6.Text)
    End Sub

    Private Sub open7_Click(sender As Object, e As EventArgs) Handles open7.Click
        Process.Start(FileLocationText7.Text)
    End Sub

    Private Sub open8_Click(sender As Object, e As EventArgs) Handles open8.Click
        Process.Start(FileLocationText8.Text)
    End Sub

    Private Sub open9_Click(sender As Object, e As EventArgs) Handles open9.Click
        Process.Start(FileLocationText9.Text)
    End Sub

    Private Sub open10_Click(sender As Object, e As EventArgs) Handles open10.Click
        Process.Start(FileLocationText10.Text)
    End Sub

    Private Sub open11_Click(sender As Object, e As EventArgs) Handles open11.Click
        Process.Start(FileLocationText11.Text)
    End Sub

    Private Sub open12_Click(sender As Object, e As EventArgs) Handles open12.Click
        Process.Start(FileLocationText12.Text)
    End Sub

    Private Sub open13_Click(sender As Object, e As EventArgs) Handles open13.Click
        Process.Start(FileLocationText13.Text)
    End Sub

    Private Sub open14_Click(sender As Object, e As EventArgs) Handles open14.Click
        Process.Start(FileLocationText14.Text)
    End Sub

    Private Sub open15_Click(sender As Object, e As EventArgs) Handles open15.Click
        Process.Start(FileLocationText15.Text)
    End Sub

    Private Sub open16_Click(sender As Object, e As EventArgs) Handles open16.Click
        Process.Start(FileLocationText16.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Card1.BackColor = Color.Green
        ElseIf Not CheckBox1.Checked Then
            Card1.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            GroupBox1.BackColor = Color.Green
        ElseIf Not CheckBox5.Checked Then
            GroupBox1.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            card2.BackColor = Color.Green
        ElseIf Not CheckBox2.Checked Then
            card2.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then
            GroupBox5.BackColor = Color.Green
        ElseIf Not CheckBox6.Checked Then
            GroupBox5.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            GroupBox3.BackColor = Color.Green
        ElseIf Not CheckBox3.Checked Then
            GroupBox3.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked Then
            GroupBox6.BackColor = Color.Green
        ElseIf Not CheckBox7.Checked Then
            GroupBox6.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            GroupBox4.BackColor = Color.Green
        ElseIf Not CheckBox4.Checked Then
            GroupBox4.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked Then
            GroupBox7.BackColor = Color.Green
        ElseIf Not CheckBox8.Checked Then
            GroupBox7.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked Then
            GroupBox2.BackColor = Color.Green
        ElseIf Not CheckBox2.Checked Then
            GroupBox7.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked Then
            GroupBox8.BackColor = Color.Green
        ElseIf Not CheckBox10.Checked Then
            GroupBox8.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked Then
            GroupBox9.BackColor = Color.Green
        ElseIf Not CheckBox11.Checked Then
            GroupBox9.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked Then
            GroupBox10.BackColor = Color.Green
        ElseIf Not CheckBox12.Checked Then
            GroupBox10.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked Then
            GroupBox11.BackColor = Color.Green
        ElseIf Not CheckBox13.Checked Then
            GroupBox11.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked Then
            GroupBox12.BackColor = Color.Green
        ElseIf Not CheckBox14.Checked Then
            GroupBox12.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked Then
            GroupBox13.BackColor = Color.Green
        ElseIf Not CheckBox15.Checked Then
            GroupBox13.BackColor = Color.White
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked Then
            GroupBox14.BackColor = Color.Green
        ElseIf Not CheckBox16.Checked Then
            GroupBox14.BackColor = Color.White
        End If
    End Sub

End Class