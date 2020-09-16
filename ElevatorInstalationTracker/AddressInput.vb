Public Class AddressInput
    Private Sub SubmitAddress_Click(sender As Object, e As EventArgs) Handles SubmitAddress.Click
        MainMenu.CreateNewJob(AddressInputText.Text)
        Me.Close()
    End Sub
End Class