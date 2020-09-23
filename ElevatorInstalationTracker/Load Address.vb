Imports System.IO
Public Class LoadAddress
    Dim FileReader As StreamReader

    Private Sub LoadAddress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombo.Items.AddRange(File.ReadAllLines(My.Settings.FolderLocation & "#JobAddressTracker.txt"))
    End Sub

    Private Sub ComboLoadButton_Click(sender As Object, e As EventArgs) Handles ComboLoadButton.Click
        JobForm.Show()
        MainMenu.LoadJob(LoadCombo.Text)
        Me.Close()
    End Sub

    Private Sub FIleLoadButton_Click(sender As Object, e As EventArgs) Handles FIleLoadButton.Click
        Dim prop(2) As String
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            FileReader = New StreamReader(OpenFileDialog1.FileName)
            prop = FileReader.ReadLine().Split("|")
            If String.Equals(prop(0), "AddressText") Then
                FileReader.Close()
                MainMenu.LoadJob(prop(1))

            End If

            JobForm.Show()
            Me.Close()
        End If
    End Sub
End Class