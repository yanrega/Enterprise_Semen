Imports System.Data.SqlClient
Public Class daftar_raw_material


    Private Sub btn_tambah_Click(sender As Object, e As EventArgs) Handles btn_tambah.Click
        Dim insertquery As String = "insert into t_purchase_requisition(tanggal,jumlah_bahan_baku,jenis_barang,id_username_staff,id_gudang) values(@tanggal, @jumlah_bahan_baku, @jenis_barang,@id_username_staff,@id_gudang)"
        executeQuery(insertquery)
        MessageBox.Show("Permintaan Raw Material Sukses")
    End Sub
    Private Sub executeQuery(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@id_gudang", id_raw_material.Text)
        cmd.Parameters.AddWithValue("@jenis_barang", jenis_raw_material.Text)
        cmd.Parameters.AddWithValue("@jumlah_bahan_baku", Convert.ToInt32(jumlah.Text))
        cmd.Parameters.AddWithValue("@id_username_staff", login.txtUsername.Text)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub daftar_raw_material_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select * FROM t_gudang where status_barang = 'Raw Material' ", cn)
        Dim table As New DataTable()
        adapter.Fill(table)
        tabel_raw_material.DataSource = table
    End Sub

    Private Sub tabel_raw_material_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_raw_material.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tabel_raw_material.Rows(index)
        id_raw_material.Text = selectedRow.Cells(0).Value.ToString()
        jenis_raw_material.Text = selectedRow.Cells(1).Value.ToString()
    End Sub
    Sub clear()
        id_raw_material.Text = ""
        jenis_raw_material.Clear()
        jumlah.Clear()

    End Sub
End Class
