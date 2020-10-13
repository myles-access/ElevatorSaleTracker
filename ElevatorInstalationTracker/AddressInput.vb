Public Class AddressInput
    Private Sub SubmitAddress_Click(sender As Object, e As EventArgs) Handles SubmitAddress.Click
        MainMenu.CreateNewJob(AddressInputText.Text)
        Me.Close()
    End Sub

    Private Sub AddressInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MainMenu
        Me.Left = 0
        Me.Top = 0
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class