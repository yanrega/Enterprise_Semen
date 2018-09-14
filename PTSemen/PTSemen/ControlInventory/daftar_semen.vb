Imports System.Data.SqlClient
Public Class daftar_semen

    Private Sub btn_good_issue_Click(sender As Object, e As EventArgs) Handles btn_good_issue.Click
        Dim insertquery As String = "insert into t_produksi(tanggal,jenis_barang,jumlah_semen,id_gudang,id_username_staff) values(@tanggal,@jenis_barang, @jumlah_semen,@id_gudang,@id_username_staff)"
        execQuery(insertquery)
        MessageBox.Show("Permintaan Produk Sukses")
    End Sub

    Private Sub daftar_semen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select * FROM t_gudang where status_barang ='Produk'", cn)
        Dim table As New DataTable()
        adapter.Fill(table)
        tabel_produk.DataSource = table
    End Sub

    Private Sub execQuery(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@id_gudang", id_semen.Text)
        cmd.Parameters.AddWithValue("@jenis_barang", jenis_semen.Text)
        cmd.Parameters.AddWithValue("@jumlah_semen", Convert.ToInt32(jumlah.Text))
        cmd.Parameters.AddWithValue("@id_username_staff", login.txtUsername.Text)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub tabel_produk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_produk.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tabel_produk.Rows(index)
        id_semen.Text = selectedRow.Cells(0).Value.ToString()
        jenis_semen.Text = selectedRow.Cells(1).Value.ToString()
    End Sub
End Class
