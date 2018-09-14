Imports System.Data.SqlClient

Public Class edit_data

    Private Sub edit_data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabel_order.Rows.Add()

    End Sub
    Sub load_tabel()
        tabel_order.Rows.Clear()
        Dim query As String = "select * from t_sales_order"
        database.cn.Open()
        Dim cmd = New SqlCommand(query, cn)
        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            Dim nama As String = data_reader("nama_pelanggan")
            Dim no_telp As String = data_reader("telepon_pelanggan")
            Dim alamat As String = data_reader("alamat_pelanggan")
            Dim jenis As String = data_reader("jenis_barang")
            Dim jumlah As String = data_reader("jumlah_barang")
        End While
        database.cn.Close()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim id As Integer = lblid_pelanggan.Text()
        Dim query As String = "update t_sales_order set nama_pelanggan=@nama_pelanggan, telepon_pelanggan=@nomor_telepon, alamat_pelanggan=@alamat, jenis_barang=@jenis_produk where id_sales_order=@id"
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@nama_pelanggan", nama_pelanggan.Text)
        cmd.Parameters.AddWithValue("@nomor_telepon", nomor_telepon.Text)
        cmd.Parameters.AddWithValue("@alamat", alamat.Text)
        cmd.Parameters.AddWithValue("@jenis_produk", jenis_produk.Text)
        cmd.Parameters.AddWithValue("@jumlah", jumlah.Text)
        cn.Open()
        load_tabel()
        MessageBox.Show("Data Order Berhasil Diupdate")
    End Sub

    Private Sub tabel_order_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_order.CellClick
        Dim i As Integer = tabel_order.CurrentRow.Index
        lblid_pelanggan.Text = tabel_order.Item(0, i).Value()
        nama_pelanggan.Text = tabel_order.Item(1, i).Value()
        nomor_telepon.Text = tabel_order.Item(2, i).Value()
        alamat.Text = tabel_order.Item(3, i).Value()
        jenis_produk.Text = tabel_order.Item(4, i).Value()
        jumlah.Text = tabel_order.Item(5, i).Value()
    End Sub
End Class
