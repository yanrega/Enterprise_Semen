Imports System.Data.SqlClient

Public Class financial_produk

    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_invoice.Click
        Dim insertquery As String = "insert into t_invoice_semen(tanggal,jumlah_semen,jenis_barang,id_good_issue,id_username_staff,id_role_tujuan,id_gudang,status_bayar) values(@tanggal,@jumlah,@jenis_barang ,@id_good_issue, @id_username_staff,@id_role,@id_gudang,@status_bayar)"
        addInvoice(insertquery)
        MessageBox.Show("Invoice berhasil dibuat")
        clear()
    End Sub

    Private Sub clear()
        id_good.Clear()
        jumlah_barang.Clear()
    End Sub

    Private Sub addInvoice(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@jumlah", jumlah_barang.Text)
        cmd.Parameters.AddWithValue("@jenis_barang", jenis_barang.Text)
        cmd.Parameters.AddWithValue("@id_good_issue", id_good.Text)
        cmd.Parameters.AddWithValue("@id_username_staff", login.txtUsername.Text)
        cmd.Parameters.AddWithValue("@id_gudang", id_barang.Text)
        cmd.Parameters.AddWithValue("@status_bayar", status_bayar.Text)
        cmd.Parameters.AddWithValue("@id_role", "SS")
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub financial_produk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_good_issue, tanggal, jenis_barang,jumlah_barang_keluar,id_gudang,status_bayar FROM t_good_issue where id_role_tujuan='SF'", cn)
        Dim table As New DataTable()
        adapter.Fill(table)
        tabel_invoice.DataSource = table
    End Sub

    Private Sub tabel_invoice_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_invoice.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tabel_invoice.Rows(index)
        id_good.Text = selectedRow.Cells(0).Value.ToString()
        jenis_barang.Text = selectedRow.Cells(2).Value.ToString()
        jumlah_barang.Text = selectedRow.Cells(3).Value.ToString()
        id_barang.Text = selectedRow.Cells(4).Value.ToString()
        status_bayar.Text = selectedRow.Cells(5).Value.ToString()
    End Sub
End Class
