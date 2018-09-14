Public Class menu_utama_financial
    Dim invoice As New financial_produk
    Dim request As New request_raw_material
    Dim i_vendor As New invoice_purchase_order
    

    Private Sub menu_utama_financial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel_form.Controls.Add(invoice)
    End Sub

    Private Sub validasi_invoice_Click(sender As Object, e As EventArgs) Handles validasi_invoice.Click
        validasi_invoice.ForeColor = Color.SeaGreen
        request_raw_material.ForeColor = Color.Black
        invoice_vendor.ForeColor = Color.Black
        panel_form.Controls.Clear()
        panel_form.Controls.Add(invoice)
    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub request_raw_material_Click(sender As Object, e As EventArgs) Handles request_raw_material.Click
        validasi_invoice.ForeColor = Color.Black
        request_raw_material.ForeColor = Color.SeaGreen
        invoice_vendor.ForeColor = Color.Black
        panel_form.Controls.Clear()
        panel_form.Controls.Add(request)
    End Sub

    Private Sub invoice_vendor_Click(sender As Object, e As EventArgs) Handles invoice_vendor.Click
        validasi_invoice.ForeColor = Color.Black
        request_raw_material.ForeColor = Color.Black
        invoice_vendor.ForeColor = Color.SeaGreen
        panel_form.Controls.Clear()
        panel_form.Controls.Add(i_vendor)
    End Sub
End Class