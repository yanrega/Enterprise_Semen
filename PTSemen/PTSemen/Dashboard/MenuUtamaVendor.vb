Public Class menu_utama_vendor

    Dim entry As New daftar_vendor
    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click
        Me.Hide()
        LoginVendor.Show()
    End Sub

    
    Private Sub daftar_order_Click(sender As Object, e As EventArgs) Handles daftar_order.Click
        daftar_order.ForeColor = Color.SeaGreen
        panel_form.Controls.Clear()
        panel_form.Controls.Add(entry)
    End Sub

    Private Sub menu_utama_vendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel_form.Controls.Add(entry)
    End Sub
End Class