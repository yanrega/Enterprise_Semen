Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class menu_utama_sales
    Dim order As Control = New order
    Dim search As Control = New search_data_orderan
    Dim edit As Control = New edit_data
    Dim daftar As Control = New daftar_invoice_financial
    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel_form.Controls.Add(order)
    End Sub
    Private Sub order_barang_Click(sender As Object, e As EventArgs) Handles order_barang.Click
        order_barang.ForeColor = Color.SeaGreen
        daftar_invoice.ForeColor = Color.Black
        panel_form.Controls.Clear()
        panel_form.Controls.Add(order)
    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub daftar_invoice_Click(sender As Object, e As EventArgs) Handles daftar_invoice.Click
        order_barang.ForeColor = Color.Black
        daftar_invoice.ForeColor = Color.SeaGreen
        panel_form.Controls.Clear()
        panel_form.Controls.Add(daftar)
    End Sub

    Private Sub lihat_order_Click(sender As Object, e As EventArgs)
        order_barang.ForeColor = Color.Black
        daftar_invoice.ForeColor = Color.SeaGreen
        panel_form.Controls.Clear()
        panel_form.Controls.Add(search)
    End Sub
End Class