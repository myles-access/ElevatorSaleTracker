Imports System.IO

Public Class MainMenu
    Dim FileWriter As StreamWriter
    Dim FileReader As StreamReader

    'Public Sub ShutdownProgram()

    '    Me.Close()
    'End Sub

    Private Sub NewJobButton_Click(sender As Object, e As EventArgs) Handles NewJobButton.Click
        LoadAddress.Close()
        AddressInput.Show()
        AddressInput.MdiParent = Me
        AddressInput.Left = 0
        AddressInput.Top = 0

        AddressInput.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles LoadFileButton.Click
        AddressInput.Close()
        LoadAddress.Show()
        LoadAddress.MdiParent = Me
        LoadAddress.Left = 0
        LoadAddress.Top = 0

        LoadAddress.WindowState = FormWindowState.Maximized
    End Sub

    Public Sub SetupJobForm()
        JobForm.MdiParent = Me
        'Me.Size = JobForm.Size
        JobForm.WindowState = FormWindowState.Maximized
        NewJobButton.Visible = False
        LoadFileButton.Visible = False

        JobForm.Top = 0
        JobForm.Left = 0
        JobForm.RefreshForm()
    End Sub

    Public Sub CreateNewJob(address As String)
        Dim prop(2) As String
        JobForm.Show()

        JobForm.AddressText.Text = address

        If System.IO.Directory.Exists(My.Settings.FolderLocation & "\" & address) = False Then
            FileWriter = New StreamWriter(My.Settings.FolderLocation & "#JobAddressTracker.txt", True)
            FileWriter.WriteLine(address)
            FileWriter.Flush()
            FileWriter.Close()
            ' SortAddressList()

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
            LoadJob(address)
        End If

        FileWriter.Flush()
        FileWriter.Close()
        SetupJobForm()
    End Sub

    Public Sub LoadJob(address As String)
        Dim prop(2) As String

        JobForm.AddressText.Text = address
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
        SetupJobForm()

        'FileWriter = New StreamWriter(My.Settings.FolderLocation & address & "\#tracker.txt", False)
        'JobForm.FileWriter = FileWriter
        'Me.Hide()
    End Sub

    'Public Sub SortAddressList()
    '    Dim addlines() As String
    '    Dim i As Integer
    '    FileReader = New StreamReader(My.Settings.FolderLocation & "#JobAddressTracker.txt", False)
    '    Do Until FileReader.EndOfStream
    '        i += 1
    '        addlines(i) = FileReader.ReadLine
    '    Loop
    '    FileReader.Close()
    '    Array.Sort(addlines)
    '    FileWriter = New StreamWriter(My.Settings.FolderLocation & "#JobAddressTracker.txt", True)
    '    For j = 0 To i
    '        FileWriter.WriteLine(addlines(j))
    '    Next
    '    FileWriter.Flush()
    '    FileWriter.Close()
    'End Sub

End Class
