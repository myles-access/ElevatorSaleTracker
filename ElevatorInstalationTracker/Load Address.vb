Imports System.IO

Public Class LoadAddress
    Dim FileReader As StreamReader
    Dim FileWriter As StreamWriter

    'Do when form is loaded
    Private Sub LoadAddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SortAddress()
        LoadCombo.Items.AddRange(File.ReadAllLines(My.Settings.FolderLocation & "#JobAddressTracker.txt"))
    End Sub

    'Load the address selected in the combo box
    Private Sub ComboLoadButton_Click(sender As Object, e As EventArgs) Handles ComboLoadButton.Click
        If LoadCombo.Text <> "" Then
            JobForm.Show()
            JobForm.MdiParent = MainMenu
            MainMenu.LoadJob(LoadCombo.Text)
            Me.Close()
        End If
    End Sub

    'Open the windows file picker and load a jpb from the selected tracker file
    Private Sub FIleLoadButton_Click(sender As Object, e As EventArgs) Handles FIleLoadButton.Click
        Dim prop(2) As String

        'if the file picker doesnt return a negative result
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            FileReader = New StreamReader(OpenFileDialog1.FileName)
            prop = FileReader.ReadLine().Split("|")

            'If the loaded tracker file has an address line tha atches an existing job
            If String.Equals(prop(0), "AddressText") Then
                FileReader.Close()
                MainMenu.LoadJob(prop(1))
            End If

            JobForm.Show()
            JobForm.MdiParent = MainMenu
            Me.Close()
        End If
    End Sub

    'Sort the addresses in the job tracker list
    Public Sub SortAddress()
        Dim lineArray As New List(Of String)

        Using Reader As New StreamReader(My.Settings.FolderLocation & "#JobAddressTracker.txt")

            While Reader.EndOfStream = False
                lineArray.Add(Reader.ReadLine())
            End While

            Reader.Close()
        End Using

        lineArray.Sort()
        FileWriter = New StreamWriter(My.Settings.FolderLocation & "#JobAddressTracker.txt", False)

        For Each line As String In lineArray
            FileWriter.WriteLine(line)
        Next

        FileWriter.Flush()
        FileWriter.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SortAddress()
    End Sub
End Class