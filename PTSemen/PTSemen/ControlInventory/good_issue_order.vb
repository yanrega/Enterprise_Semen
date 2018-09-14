Imports System.Data.SqlClient


Public Class good_issue_order


    Private Sub good_issue_order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select * FROM t_sales_order", cn)
        Dim table As New DataTable()
        adapter.Fill(table)
        tabel_good_issue.DataSource = table
    End Sub
    Private Sub execQuery(ByVal query As String)
        Dim searchquery As String = "Select * from t_gudang where status_barang=@status_barang"
        Dim cmd1 As New SqlCommand(searchquery, cn)
        cmd1.Parameters.AddWithValue("@status_barang", "Produk")

        Dim da As New SqlDataAdapter(cmd1)
        Dim table As New DataTable
        da.Fill(table)
        Dim cmd As New SqlCommand(query, cn)
        Dim barangSekarang = Convert.ToInt32(table.Rows(0)(2).ToString) - Convert.ToInt32(jumlah_barang.Text)
        cmd.Parameters.AddWithValue("@status", table.Rows(0)(3).ToString)
        cmd.Parameters.AddWithValue("@total", Convert.ToString(barangSekarang))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub btn_good_issue_Click(sender As Object, e As EventArgs) Handles btn_good_issue.Click
        Dim minusGudang As String = "update t_gudang set total_barang=@total WHERE status_barang=@status"
        execQuery(minusGudang)
        Dim insertquery As String = "insert into t_good_issue(tanggal,jenis_barang,jumlah_barang_keluar,id_username_staff,id_sales_order,id_role_tujuan,id_gudang,status_bayar) values(@tanggal,@jenis_barang,@jumlah, @id_username_staff, @id_sales_order,@id_role,@id_gudang,@status_bayar)"
        addGoodIssue(insertquery)
        
        MessageBox.Show("Good Issue berhasil dibuat")
        clear()
    End Sub
    Private Sub hapus(ByVal id As String)
        Dim dequery As String = "delete from t_sales_order where id_sales_order=@id"
        executeQuery(dequery, id)
    End Sub
    Private Sub executeQuery(ByVal query As String, ByVal id As String)
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@id", id)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
    Sub clear()
        id_sales_order.Clear()
        jumlah_barang.Clear()
        id_barang.Clear()
        jenis_barang.Clear()
        status_bayar.Clear()

    End Sub
    Private Sub addGoodIssue(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@jumlah", jumlah_barang.Text)
        cmd.Parameters.AddWithValue("@jenis_barang", jenis_barang.Text)
        cmd.Parameters.AddWithValue("@id_gudang", id_barang.Text)
        cmd.Parameters.AddWithValue("@status_bayar", status_bayar.Text)
        cmd.Parameters.AddWithValue("@id_username_staff", login.txtUsername.Text)
        cmd.Parameters.AddWithValue("@id_sales_order", id_sales_order.Text)
        cmd.Parameters.AddWithValue("@id_role", "SF")
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub tabel_good_issue_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_good_issue.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tabel_good_issue.Rows(index)
        id_sales_order.Text = selectedRow.Cells(0).Value.ToString()
        jenis_barang.Text = selectedRow.Cells(6).Value.ToString()
        jumlah_barang.Text = selectedRow.Cells(5).Value.ToString()
        id_barang.Text = selectedRow.Cells(10).Value.ToString()
        status_bayar.Text = selectedRow.Cells(8).Value.ToString()
    End Sub
End Class
