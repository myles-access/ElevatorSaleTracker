Imports System.IO

Public Class MainMenu
    Dim FileWriter As StreamWriter
    Dim FileReader As StreamReader
    Private Sub NewJobButton_Click(sender As Object, e As EventArgs) Handles NewJobButton.Click
        AddressInput.Show()
    End Sub

    Public Sub CreateNewJob(address As String)
        Dim prop(2) As String
        JobForm.Show()
        JobForm.AddressText.Text = address

        If System.IO.Directory.Exists(My.Settings.FolderLocation & "\" & address) = False Then
            System.IO.Directory.CreateDirectory(My.Settings.FolderLocation & "\" & address)
            JobForm.AddressFolderLocation = My.Settings.FolderLocation & "\" & address

            If File.Exists(My.Settings.FolderLocation & address & "\#tracker.txt") Then
                FileWriter = New StreamWriter(My.Settings.FolderLocation & address & "\#tracker.txt", False)
            Else
                File.Create(My.Settings.FolderLocation & address & "\#tracker.txt").Dispose()
                FileWriter = New StreamWriter(My.Settings.FolderLocation & address & "\#tracker.txt", False)
            End If
            JobForm.FileWriter = FileWriter
        ElseIf System.IO.Directory.Exists(My.Settings.FolderLocation & "\" & address) = True Then
            JobForm.AddressFolderLocation = My.Settings.FolderLocation & "\" & address
            FileReader = New StreamReader(My.Settings.FolderLocation & address & "\#tracker.txt", False)

            Do Until FileReader.EndOfStream
                prop = FileReader.ReadLine().Split("|")
                'ADDRESS
                If String.Equals(prop(0), JobForm.AddressText.Name) Then
                    JobForm.AddressText.Text = prop(1)
                    'FILE LOCATION TEXTS
                ElseIf String.Equals(prop(0), JobForm.FileLocationText1.Name) Then
                    JobForm.FileLocationText1.Text = prop(1)
                ElseIf String.Equals(prop(0), JobForm.card2.Name) Then
                    JobForm.card2.Text = prop(1)
                ElseIf String.Equals(prop(0), JobForm.FileLocationText3.Name) Then
                    JobForm.FileLocationText3.Text = prop(1)
                ElseIf String.Equals(prop(0), JobForm.FileLocationText4.Name) Then
                    JobForm.FileLocationText4.Text = prop(1)
                ElseIf String.Equals(prop(0), JobForm.FileLocationText5.Name) Then
                    JobForm.FileLocationText5.Text = prop(1)
                ElseIf String.Equals(prop(0), JobForm.FileLocationText6.Name) Then
                    JobForm.FileLocationText6.Text = prop(1)
                ElseIf String.Equals(prop(0), JobForm.FileLocationText7.Name) Then
                    JobForm.FileLocationText7.Text = prop(1)
                ElseIf String.Equals(prop(0), JobForm.FileLocationText8.Name) Then
                    JobForm.FileLocationText8.Text = prop(1)
                    'CHECK BOXES
                ElseIf String.Equals(prop(0), JobForm.CheckBox1.Name) Then
                    JobForm.CheckBox1.Checked = Boolean.Parse(prop(1))
                ElseIf String.Equals(prop(0), JobForm.CheckBox5.Name) Then
                    JobForm.CheckBox5.Checked = Boolean.Parse(prop(1))
                ElseIf String.Equals(prop(0), JobForm.CheckBox2.Name) Then
                    JobForm.CheckBox2.Checked = Boolean.Parse(prop(1))
                ElseIf String.Equals(prop(0), JobForm.CheckBox3.Name) Then
                    JobForm.CheckBox3.Checked = Boolean.Parse(prop(1))
                ElseIf String.Equals(prop(0), JobForm.CheckBox4.Name) Then
                    JobForm.CheckBox4.Checked = Boolean.Parse(prop(1))
                ElseIf String.Equals(prop(0), JobForm.CheckBox6.Name) Then
                    JobForm.CheckBox6.Checked = Boolean.Parse(prop(1))
                ElseIf String.Equals(prop(0), JobForm.CheckBox7.Name) Then
                    JobForm.CheckBox7.Checked = Boolean.Parse(prop(1))
                ElseIf String.Equals(prop(0), JobForm.CheckBox8.Name) Then
                    JobForm.CheckBox8.Checked = Boolean.Parse(prop(1))
                End If
            Loop

            FileReader.Close()
            FileWriter = New StreamWriter(My.Settings.FolderLocation & address & "\#tracker.txt", False)
            JobForm.FileWriter = FileWriter
        End If

        Me.Hide()
    End Sub

    Public Sub ShutdownProgram()
        Me.Close()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
