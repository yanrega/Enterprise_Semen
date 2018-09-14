Imports System.Data.SqlClient

Public Class order

    Private Sub clearAll()
        nama_pelanggan.Clear()
        alamat.Clear()
        no_telepon.Clear()
        jumlah.Clear()
        total_harga.Clear()
        jenis_barang_order.Text = ""
        id_barang.Clear()

    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim query As String = "insert into t_sales_order(tanggal,nama_pelanggan,alamat_pelanggan,telepon_pelanggan,jumlah_barang,jenis_barang,total_harga,status_bayar,id_username_staff,id_gudang) values(@tanggal, @nama_pelanggan,@alamat_pelanggan, @telepon_pelanggan, @jumlah_barang, @jenis_barang,@total_harga,@status_bayar,@id_username_staff,@id_gudang)"
        addSalesOder(query)
        MessageBox.Show("Order Ditambahkan")
        clearAll()
    End Sub
    Private Sub addSalesOder(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@nama_pelanggan", nama_pelanggan.Text)
        cmd.Parameters.AddWithValue("@alamat_pelanggan", alamat.Text)
        cmd.Parameters.AddWithValue("@telepon_pelanggan", no_telepon.Text)
        cmd.Parameters.AddWithValue("@jumlah_barang", jumlah.Text)
        cmd.Parameters.AddWithValue("@jenis_barang", jenis_barang_order.Text)
        cmd.Parameters.AddWithValue("@total_harga", total_harga.Text)
        cmd.Parameters.AddWithValue("@status_bayar", "Belum Lunas")
        cmd.Parameters.AddWithValue("@id_username_staff", login.txtUsername.Text)
        cmd.Parameters.AddWithValue("@id_gudang", id_barang.Text)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub jumlah_TextChanged(sender As Object, e As EventArgs) Handles jumlah.TextChanged
        Try
            Dim total As Integer = Convert.ToInt32(jumlah.Text)
            Dim jenis As String = jenis_barang_order.Text()
            If (jenis = "Semen Portland") Then
                total_harga.Text = Convert.ToString(total * 3000)
            ElseIf (jenis = "Semen Super Mansory") Then
                total_harga.Text = Convert.ToString(total * 4000)
            Else
                total_harga.Text = Convert.ToString(total * 2000)
            End If

        Catch ex As Exception
            total_harga.Clear()
        End Try
    End Sub

    Private Sub order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_gudang, deskripsi FROM t_gudang where status_barang = 'Produk'", cn)
        Dim table As New DataTable()
        adapter.Fill(table)
        tabel_produk.DataSource = table
    End Sub

    Private Sub tabel_produk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_produk.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tabel_produk.Rows(index)
        id_barang.Text = selectedRow.Cells(0).Value.ToString()
        jenis_barang_order.Text = selectedRow.Cells(1).Value.ToString()

    End Sub
End Class
