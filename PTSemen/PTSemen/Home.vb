Public Class Home

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        LoginVendor.Show()
    End Sub

    Private Sub lbl_exit_Click(sender As Object, e As EventArgs) Handles lbl_exit.Click
        Application.Exit()
    End Sub
End Class