Imports System.Data.SqlClient

Public Class good_issue_

    Private Sub good_issue__Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_good_issue, tanggal,jumlah_barang_keluar, id_produksi FROM t_good_issue where id_role_tujuan='SP'", cn)
        Dim table As New DataTable()
        adapter.Fill(table)
        tabel_pengecekan_produk.DataSource = table
    End Sub

    Private Sub tabel_pengecekan_produk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_pengecekan_produk.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tabel_pengecekan_produk.Rows(index)
        id_good_issue.Text = selectedRow.Cells(4).Value.ToString()
        'id.Text = selectedRow.Cells(0).Value.ToString()
    End Sub

    Private Sub executeQuery(ByVal query As String, ByVal id As String)
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@id", id)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub clear()
        id_good_issue.Clear()
        id_produksi.Clear()
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
        cmd.Parameters.AddWithValue("@jenis_barang", "Produk")
        cmd.Parameters.AddWithValue("@id_username_staff", login.txtUsername.Text)
        cmd.Parameters.AddWithValue("@id_role", "SI")
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
