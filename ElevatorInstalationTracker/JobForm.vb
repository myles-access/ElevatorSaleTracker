Public Class JobForm
    Public AddressFolderLocation As String
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub OpenFileButton_Click(sender As Object, e As EventArgs) Handles OpenFileButton.Click
        If OpenFileDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            FileLocationText.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Public Sub JobForm_FormClosing(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosing
        MainMenu.ShutdownProgram()
    End Sub

End Class