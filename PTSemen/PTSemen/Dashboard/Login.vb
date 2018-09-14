Imports System.Data.SqlClient

Public Class login

    Private Sub login_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim searchquery As String = "Select * from t_staff where id_username_staff=@username"
        Dim cmd As New SqlCommand(searchquery, cn)
        cmd.Parameters.AddWithValue("@username", txtUsername.Text)

        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)
        If table.Rows.Count > 0 Then
            If txtPassword.Text = table.Rows(0)(1).ToString Then
                Dim role As String = table.Rows(0)(4)
                checkRole(role)
                Me.Hide()
            End If
        Else
            MessageBox.Show("Login Unsuccessfull")
        End If
    End Sub

    Private Sub checkRole(role As String)
        If (role = "SS") Then
            menu_utama_sales.Show()
        ElseIf (role = "SI") Then
            menu_utama_inventory.Show()
        ElseIf (role = "SF") Then
            menu_utama_financial.Show()
        ElseIf (role = "SP") Then
            menu_utama_produksi.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Home.Show()
    End Sub
End Class
