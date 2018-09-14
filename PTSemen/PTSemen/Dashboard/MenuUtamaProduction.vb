Imports System.Windows.Forms
Imports System.Data.SqlClient

Public Class menu_utama_produksi

    Dim p_order As New production_order
    Dim p_table As New production_table



    Private Sub daftar_produksi_Click(sender As Object, e As EventArgs) Handles daftar_produksi.Click
        p_order.ForeColor = Color.SeaGreen
        p_table.ForeColor = Color.Black

        panel_form.Controls.Clear()
        panel_form.Controls.Add(p_order)
    End Sub

    Private Sub MenuUtamaProduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panel_form.Controls.Add(p_order)
    End Sub

    Private Sub update_produksi_Click(sender As Object, e As EventArgs) Handles update_produksi.Click
        p_order.ForeColor = Color.Black
        p_table.ForeColor = Color.SeaGreen
        panel_form.Controls.Clear()
        panel_form.Controls.Add(p_table)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Hide()
        login.Show()
    End Sub

    Private Sub Label39_Click(sender As Object, e As EventArgs) Handles Label39.Click
        Me.Hide()
        login.Show()
    End Sub

End Class