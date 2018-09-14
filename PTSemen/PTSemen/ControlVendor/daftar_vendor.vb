Imports System.Data.SqlClient
Public Class daftar_vendor

    Private Sub daftar_vendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_purchase_order, tanggal, jenis_barang,jumlah_bahan_baku, total_harga,id_gudang FROM t_purchase_order", cn)
        Dim table As New DataTable()
        adapter.Fill(table)
        tabel_purchase.DataSource = table
    End Sub

    Private Sub tabel_purchase_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_purchase.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tabel_purchase.Rows(index)
        id_po.Text = selectedRow.Cells(0).Value.ToString()
        jumlah.Text = selectedRow.Cells(3).Value.ToString()
        jenis_barang.Text = selectedRow.Cells(2).Value.ToString()
        id_barang.Text = selectedRow.Cells(5).Value.ToString()
    End Sub

    Private Sub btn_simpan_Click(sender As Object, e As EventArgs) Handles btn_simpan.Click
        Dim insertquery As String = "insert into t_invoice_bahan_baku(tanggal,jenis_barang,jumlah_bahan_baku,id_purchase_order,id_username_vendor,id_role_tujuan,id_gudang) values(@tanggal,@jenis_barang,@jumlah, @id_po,@id_username_vendor,@id_role_tujuan,@id_gudang)"
        TambahInvoiceBahanBaku(insertquery)
        Dim updatequery As String = "update t_barang set stock_barang=@stock where id_username_vendor=@id"
        updateBarang(updatequery)
        MessageBox.Show("Berhasil dikirimkan")
    End Sub
    Private Sub TambahInvoiceBahanBaku(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@jumlah", jumlah.Text)
        cmd.Parameters.AddWithValue("@jenis_barang", jenis_barang.Text)
        cmd.Parameters.AddWithValue("@id_gudang", id_barang.Text)
        cmd.Parameters.AddWithValue("@id_po", id_po.Text)
        cmd.Parameters.AddWithValue("@id_username_vendor", LoginVendor.txtUsername.Text)
        cmd.Parameters.AddWithValue("@id_role_tujuan", "SF")
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
    Private Sub clear()
        jumlah.Clear()
        id_po.Clear()
    End Sub
    Private Sub updateBarang(ByVal query As String)
        Dim searchQuery As String = "Select * from t_barang where id_username_vendor=@username"
        Dim cmd1 As New SqlCommand(searchQuery, cn)
        cmd1.Parameters.AddWithValue("@username", LoginVendor.txtUsername.Text)
        Dim adapter As New SqlDataAdapter(cmd1)
        Dim table As New DataTable()
        adapter.Fill(table)


        Dim cmd As New SqlCommand(query, cn)
        
        cmd.Parameters.AddWithValue("@id", LoginVendor.txtUsername.Text)
        cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(table.Rows(0)(3).ToString) - Convert.ToInt32(jumlah.Text))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
