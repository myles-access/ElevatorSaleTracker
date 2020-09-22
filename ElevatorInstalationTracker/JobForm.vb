Imports System.IO

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


    Private Sub AddFile(cardStr As Label)
        Dim path As String
        Dim file As String
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            path = OpenFileDialog1.FileName
            cardStr.Text = path
            file = Dir(path)
            My.Computer.FileSystem.CopyFile(path, My.Settings.FolderLocation & AddressText.Text & "\" & file)
        End If
    End Sub

    Private Sub SaveForm()
        FileWriter.Close()
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
End Class