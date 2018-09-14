Imports System.Data.SqlClient
Public Class issue_production

    Private Sub issue_production_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_good_issue, tanggal, jumlah_barang_keluar, id_produksi FROM t_good_issue where id_role_tujuan='SP'", cn)
        Dim table As New DataTable()
        adapter.Fill(table)
        tabel_pengecekan_produk.DataSource = table
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Dim insertquery As String = "insert into t_good_receipt(tanggal,jumlah_barang_masuk,jenis_barang,id_username_staff,id_role_tujuan) values(@tanggal,@jumlah, @jenis_barang, @id_username_staff,@id_role)"
        addGoodReceipt(insertquery)

        Dim dequery As String = "delete from t_good_issue where id_good_issue=@id"
        executeQuery(dequery, id_good_issue_produksi.Text)
        Dim dequery1 As String = "delete from t_produksi where id_produksi=@id"
        executeQuery(dequery1, id_produksi.Text)

        MessageBox.Show("Good Receipt berhasil dibuat")
    End Sub
    Private Sub executeQuery(ByVal query As String, ByVal id As String)
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@id", id)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
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
        cmd.Parameters.AddWithValue("@jumlah", table.Rows(0)(2).ToString)
        cmd.Parameters.AddWithValue("@jenis_barang", "Raw Material")
        cmd.Parameters.AddWithValue("@id_username_staff", login.txtUsername.Text)
        cmd.Parameters.AddWithValue("@id_role", "SI")
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub tabel_pengecekan_produk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_pengecekan_produk.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tabel_pengecekan_produk.Rows(index)
        id_produksi.Text = selectedRow.Cells(4).Value.ToString()
        id_good_issue_produksi.Text = selectedRow.Cells(0).Value.ToString()
    End Sub
End Class
