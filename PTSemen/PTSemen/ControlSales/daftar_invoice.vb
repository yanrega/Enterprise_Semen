Imports System.Data.SqlClient

Public Class daftar_invoice_financial

    Private Sub daftar_invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_invoice_semen,id_good_issue,tanggal,jenis_barang,jumlah_semen,status_bayar FROM t_invoice_semen where id_role_tujuan='SS'", cn)
        Dim table As New DataTable()
        adapter.Fill(table)
        tabel_invoice.DataSource = table
    End Sub

    Private Sub tabel_invoice_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_invoice.CellContentClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tabel_invoice.Rows(index)
        id_invoice.Text = selectedRow.Cells(0).Value.ToString()
        tanggal.Text = selectedRow.Cells(2).Value.ToString()
        'deskripsi.Text = selectedRow.Cells(2).Value.ToString()
        jenis_barang.Text = selectedRow.Cells(3).Value.ToString()
        jumlah.Text = selectedRow.Cells(4).Value.ToString()
        id_good_issue.Text = selectedRow.Cells(1).Value.ToString()
        status_bayar.Text = selectedRow.Cells(5).Value.ToString()
    End Sub

    Private Sub btn_konfirmasi_Click(sender As Object, e As EventArgs) Handles btn_konfirmasi.Click
        Dim dequery As String = "delete from t_invoice_semen where id_invoice_semen=@id"
        executeQuery(dequery)
        MessageBox.Show("berhasil dikonfirmasi")
        clear()
        daftar_invoice_Load(sender, e)
    End Sub
    Private Sub clear()
        tanggal.Clear()
        jumlah.Clear()
    End Sub
    Private Sub executeQuery(ByVal query As String)
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@id", id_invoice.Text)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
