Imports System.Data.SqlClient
Public Class LoginVendor

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim searchquery As String = "Select * from t_vendor where id_username_vendor=@username"
        Dim cmd As New SqlCommand(searchquery, cn)
        cmd.Parameters.AddWithValue("@username", txtUsername.Text)

        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count > 0 Then
            If txtPassword.Text = table.Rows(0)(1).ToString Then
                menu_utama_vendor.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Login Unsuccessfull")
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Home.Show()
    End Sub
End Class