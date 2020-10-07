﻿Imports System.IO

Public Class JobForm
    Public FileWriter As StreamWriter
    Public AddressFolderLocation As String
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        SaveForm()
    End Sub
    Private Sub JobForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'RefreshForm()
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
            If cardStr.Text <> "No File Selected" Then
                My.Computer.FileSystem.DeleteFile(cardStr.Text)
                path = OpenFileDialog1.FileName
                file = Dir(path)
                My.Computer.FileSystem.CopyFile(path, My.Settings.FolderLocation & AddressText.Text & "\" & file)
                cardStr.Text = (My.Settings.FolderLocation & AddressText.Text & "\" & file)
            Else
                path = OpenFileDialog1.FileName
                file = Dir(path)
                My.Computer.FileSystem.CopyFile(path, My.Settings.FolderLocation & AddressText.Text & "\" & file)
                cardStr.Text = (My.Settings.FolderLocation & AddressText.Text & "\" & file)
            End If
        End If

        RefreshForm()
    End Sub

    Private Sub SaveForm()

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

        FileWriter.Flush()
        FileWriter.Close()
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
End Class