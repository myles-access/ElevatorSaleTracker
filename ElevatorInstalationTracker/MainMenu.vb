Public Class MainMenu
    Private Sub NewJobButton_Click(sender As Object, e As EventArgs) Handles NewJobButton.Click
        AddressInput.Show()
    End Sub

    Public Sub CreateNewJob(address As String)
        JobForm.Show()
        JobForm.AddressText.Text = address

        If System.IO.Directory.Exists(My.Settings.FolderLocation & "\" & address) = False Then
            System.IO.Directory.CreateDirectory(My.Settings.FolderLocation & "\" & address)
        End If
        JobForm.AddressFolderLocation = My.Settings.FolderLocation & "\" & address
        Me.Hide()
    End Sub

    Public Sub ShutdownProgram()
        Me.Close()
    End Sub
End Class
