Imports System.Data.SqlClient
Public Class invoice_purchase_order

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Dim insertquery As String = "insert into t_good_receipt(tanggal,jenis_barang,jumlah_barang_masuk,id_gudang,id_username_staff,id_role_tujuan) values(@tanggal,@jenis_barang,@jumlah, @id_gudang, @id_username_staff,@id_role)"
        addGoodReceipt(insertquery)
        hapusInvoice()
        hapusPO()
        MessageBox.Show("Berhasil dikirimkan")
        clear()
        invoice_purchase_order_Load(sender, e)
    End Sub

    Private Sub invoice_purchase_order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_invoice_bahan_baku, tanggal,jenis_barang,jumlah_bahan_baku, id_purchase_order,id_gudang FROM t_invoice_bahan_baku", cn)
        Dim table As New DataTable()
        adapter.Fill(table)
        tabel_invoice_PO.DataSource = table
    End Sub

    Private Sub hapusInvoice()
        Dim dequery As String = "delete from t_invoice_bahan_baku where id_invoice_bahan_baku=@id"
        executeQuery(dequery, id_invoice.Text)
    End Sub

    Private Sub hapusPO()
        Dim searchquery As String = "Select id_purchase_requisition from t_purchase_order where id_purchase_order=@username"
        Dim cmd As New SqlCommand(searchquery, cn)
        cmd.Parameters.AddWithValue("@username", id_purchase.Text)

        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)

        Dim dequery As String = "delete from t_purchase_order where id_purchase_order=@id"
        executeQuery(dequery, id_purchase.Text)
        hapusPR(table.Rows(0)(0).ToString)
    End Sub
    Private Sub hapusPR(ByVal id As String)
        Dim dequery As String = "delete from t_purchase_requisition where id_purchase_requisition=@id"
        executeQuery(dequery, id)
    End Sub
    Private Sub executeQuery(ByVal query As String, ByVal id As String)
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@id", id)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub clear()
        jumlah.Clear()
        id_invoice.Clear()
    End Sub

    Private Sub addGoodReceipt(ByVal query As String)
        Dim datee As Date = Format(tanggal.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@jumlah", jumlah.Text)
        cmd.Parameters.AddWithValue("@jenis_barang", jenis_barang.Text)
        cmd.Parameters.AddWithValue("@id_gudang", id_barang.Text)
        cmd.Parameters.AddWithValue("@id_username_staff", login.txtUsername.Text)
        cmd.Parameters.AddWithValue("@id_role", "SI")
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub tabel_invoice_PO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_invoice_PO.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tabel_invoice_PO.Rows(index)
        id_invoice.Text = selectedRow.Cells(0).Value.ToString()
        jumlah.Text = selectedRow.Cells(3).Value.ToString()
        id_barang.Text = selectedRow.Cells(5).Value.ToString()
        jenis_barang.Text = selectedRow.Cells(2).Value.ToString()
        id_purchase.Text = selectedRow.Cells(4).Value.ToString()
    End Sub
End Class
