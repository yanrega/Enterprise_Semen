Imports System.Data.SqlClient
Public Class request_raw_material

    Private Sub btn_invoice_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Dim insertquery As String = "insert into t_purchase_order(tanggal,jumlah_bahan_baku,jenis_barang,total_harga,id_purchase_requisition,id_username_staff,id_vendor,id_gudang) values(@tanggal,@jumlah,@jenis_barang ,@total, @id_pr,@id_username_staff,@id_vendor,@id_gudang)"
        addPO(insertquery)
        MessageBox.Show("Berhasil dikirim")
    End Sub

    Private Sub request_raw_material_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_purchase_requisition, tanggal,jenis_barang, jumlah_bahan_baku,id_gudang FROM t_purchase_requisition", cn)
        Dim table As New DataTable()
        adapter.Fill(table)
        tabel_raw_material.DataSource = table
    End Sub

    Private Sub tabel_raw_material_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_raw_material.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tabel_raw_material.Rows(index)
        id_purchase.Text = selectedRow.Cells(0).Value.ToString()
        jumlah.Text = selectedRow.Cells(3).Value.ToString()
        jenis_barang.Text = selectedRow.Cells(2).Value.ToString()
        id_barang.Text = selectedRow.Cells(4).Value.ToString()
    End Sub

    Private Sub addPO(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@jumlah", jumlah.Text)
        cmd.Parameters.AddWithValue("@jenis_barang", jenis_barang.Text)
        cmd.Parameters.AddWithValue("@total", total.Text)
        cmd.Parameters.AddWithValue("@id_pr", id_purchase.Text)
        cmd.Parameters.AddWithValue("@id_username_staff", login.txtUsername.Text)
        cmd.Parameters.AddWithValue("@id_vendor", "yan")
        cmd.Parameters.AddWithValue("@id_gudang", id_barang.Text)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
