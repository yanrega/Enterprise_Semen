Imports System.Data.SqlClient

Public Class production_order

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Dim insertquery As String = "insert into t_good_issue(tanggal,jumlah_barang_keluar,jenis_barang,id_gudang,id_username_staff,id_produksi,id_role_tujuan) values(@tanggal,@jumlah, @jenis_barang, @id_gudang,@id_username_staff, @id_produksi,@id_role)"
        executeQuery(insertquery)
        MessageBox.Show("Berhasil direquest")
        clear()
    End Sub

    Private Sub production_order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_produksi, tanggal, jenis_barang,jumlah_semen ,id_gudang FROM t_produksi", cn)
        Dim table As New DataTable()
        adapter.Fill(table)
        tabel_pengecekan_produk.DataSource = table
    End Sub
    Private Sub clear()
        id_produksi.Clear()
        jumlah.Clear()
        jenis_barang.Clear()
    End Sub

    Private Sub tabel_pengecekan_produk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_pengecekan_produk.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tabel_pengecekan_produk.Rows(index)
        id_produksi.Text = selectedRow.Cells(0).Value.ToString()
        jenis_barang.Text = selectedRow.Cells(2).Value.ToString()
        id_barang.Text = selectedRow.Cells(4).Value.ToString()
        jumlah.Text = selectedRow.Cells(3).Value.ToString()
    End Sub

    Private Sub executeQuery(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@jumlah", jumlah.Text)
        cmd.Parameters.AddWithValue("@jenis_barang", jenis_barang.Text)
        cmd.Parameters.AddWithValue("@id_gudang", id_barang.Text)
        cmd.Parameters.AddWithValue("@id_username_staff", login.txtUsername.Text)
        cmd.Parameters.AddWithValue("@id_produksi", id_produksi.Text)
        cmd.Parameters.AddWithValue("@id_role", "SI")
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
