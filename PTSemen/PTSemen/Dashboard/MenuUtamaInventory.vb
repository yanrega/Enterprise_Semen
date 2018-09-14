Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class menu_utama_inventory
    Dim entry As New good_issue_order
    Dim checking As New good_issue_
    Dim daftar As New daftar_semen
    Dim raw As New daftar_raw_material
    Dim good As New good_receipt
    Dim good_issue As New issue_production
    Dim purchase As New request_raw_material


    Private Sub menu_utama_inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel_form.Controls.Add(daftar)
    End Sub

    Private Sub produk_Click(sender As Object, e As EventArgs) Handles produk.Click
        produk.ForeColor = Color.SeaGreen

        daftar.ForeColor = Color.Black
        lihat_raw_material.ForeColor = Color.Black
        sampai_order.ForeColor = Color.Black
        purchase_order.ForeColor = Color.Black
        panel_form.Controls.Clear()
        panel_form.Controls.Add(daftar)
    End Sub

    Private Sub check_produksi_Click(sender As Object, e As EventArgs) Handles check_produksi.Click
        produk.ForeColor = Color.Black
        check_produksi.ForeColor = Color.SeaGreen
        lihat_raw_material.ForeColor = Color.Black
        sampai_order.ForeColor = Color.Black
        purchase_order.ForeColor = Color.Black
        panel_form.Controls.Clear()
        panel_form.Controls.Add(entry)
    End Sub

    Private Sub lihat_raw_material_Click(sender As Object, e As EventArgs) Handles lihat_raw_material.Click
        produk.ForeColor = Color.Black
        check_produksi.ForeColor = Color.Black
        lihat_raw_material.ForeColor = Color.SeaGreen
        sampai_order.ForeColor = Color.Black
        purchase_order.ForeColor = Color.Black
        panel_form.Controls.Clear()
        panel_form.Controls.Add(raw)
    End Sub

    Private Sub Label40_Click(sender As Object, e As EventArgs) Handles Label40.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub sampai_order_Click(sender As Object, e As EventArgs) Handles sampai_order.Click
        produk.ForeColor = Color.Black
        check_produksi.ForeColor = Color.Black
        lihat_raw_material.ForeColor = Color.Black
        sampai_order.ForeColor = Color.SeaGreen
        purchase_order.ForeColor = Color.Black
        panel_form.Controls.Clear()
        panel_form.Controls.Add(good)
    End Sub

    Private Sub good_issue_production_Click(sender As Object, e As EventArgs)
        produk.ForeColor = Color.Black
        check_produksi.ForeColor = Color.Black
        lihat_raw_material.ForeColor = Color.Black
        sampai_order.ForeColor = Color.Black
        purchase_order.ForeColor = Color.Black
        panel_form.Controls.Clear()
        panel_form.Controls.Add(good_issue)
    End Sub

    

    

    Private Sub purchase_order_Click(sender As Object, e As EventArgs) Handles purchase_order.Click
        produk.ForeColor = Color.Black
        check_produksi.ForeColor = Color.Black
        lihat_raw_material.ForeColor = Color.Black
        sampai_order.ForeColor = Color.Black
        purchase_order.ForeColor = Color.SeaGreen
        panel_form.Controls.Clear()
        panel_form.Controls.Add(purchase)
    End Sub
End Class