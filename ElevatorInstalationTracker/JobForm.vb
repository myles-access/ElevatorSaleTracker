﻿Imports System.IO

Public Class JobForm
    Public FileWriter As StreamWriter
    Public AddressFolderLocation As String
    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        SaveForm()
    End Sub
    Public Sub JobForm_FormClosing(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosing
        SaveForm()
        FileWriter.Close()
        MainMenu.ShutdownProgram()
    End Sub

    Private Sub OpenFileButton_Click(sender As Object, e As EventArgs) Handles OpenFileButton1.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            FileLocationText1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub OpenFileButton2_Click(sender As Object, e As EventArgs) Handles OpenFileButton2.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            FileLocationText2.Text = OpenFileDialog1.FileName
        End If
    End Sub
    Private Sub OpenFileButton3_Click(sender As Object, e As EventArgs) Handles OpenFileButton3.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            FileLocationText3.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub SaveForm()
        FileWriter.WriteLine(AddressText.Name & "|" & AddressText.Text)

        FileWriter.WriteLine(CheckBox1.Name & "|" & CheckBox1.Checked.ToString())
        FileWriter.WriteLine(FileLocationText1.Name & "|" & FileLocationText1.Text)

        FileWriter.WriteLine(CheckBox2.Name & "|" & CheckBox2.Checked.ToString())
        FileWriter.WriteLine(FileLocationText2.Name & "|" & FileLocationText2.Text)

        FileWriter.WriteLine(CheckBox3.Name & "|" & CheckBox3.Checked.ToString())
        FileWriter.WriteLine(FileLocationText3.Name & "|" & FileLocationText3.Text)

        FileWriter.Flush()
    End Sub
End Class