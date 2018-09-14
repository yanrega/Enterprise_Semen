Imports System.Data.SqlClient
Public Class production_table

    Private Sub btn_kirim_Click(sender As Object, e As EventArgs) Handles btn_kirim.Click
        Dim insertquery As String = "insert into t_good_receipt(tanggal,jenis_barang,jumlah_barang_masuk,id_gudang,id_username_staff,id_role_tujuan) values(@tanggal,@jenis_barang,@jumlah, @id_gudang,@id_username_staff,@id_role)"
        addGoodReceipt(insertquery)

        Dim dequery As String = "delete from t_good_issue where id_good_issue=@id"
        executeQuery(dequery, id_good.Text)
        Dim dequery1 As String = "delete from t_produksi where id_produksi=@id"
        executeQuery(dequery1, id_produksi.Text)

        MessageBox.Show("Good Receipt berhasil dibuat")
        clear()
    End Sub

    Private Sub production_table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_good_issue, tanggal,jenis_barang,jumlah_barang_keluar, id_produksi ,id_gudang FROM t_good_issue where id_role_tujuan='SI'", cn)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
    Private Sub executeQuery(ByVal query As String, ByVal id As String)
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@id", id)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub clear()
        id_good.Clear()
    End Sub
    Private Sub addGoodReceipt(ByVal query As String)
        Dim searchquery As String = "Select * from t_produksi where id_produksi=@id_produksi"
        Dim cmd1 As New SqlCommand(searchquery, cn)
        cmd1.Parameters.AddWithValue("@id_produksi", id_produksi.Text)

        Dim da As New SqlDataAdapter(cmd1)
        Dim table As New DataTable
        da.Fill(table)

        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@id_gudang", table.Rows(0)(5).ToString)
        cmd.Parameters.AddWithValue("@jenis_barang", table.Rows(0)(2).ToString)
        cmd.Parameters.AddWithValue("@jumlah", table.Rows(0)(3).ToString)
        cmd.Parameters.AddWithValue("@id_username_staff", login.txtUsername.Text)
        cmd.Parameters.AddWithValue("@id_role", "SI")
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        id_produksi.Text = selectedRow.Cells(4).Value.ToString()
        jumlah.Text = selectedRow.Cells(3).Value.ToString()
        jenis_barang.Text = selectedRow.Cells(2).Value.ToString()
        id_good.Text = selectedRow.Cells(0).Value.ToString()
        id_barang.Text = selectedRow.Cells(5).Value.ToString()
    End Sub
End Class
