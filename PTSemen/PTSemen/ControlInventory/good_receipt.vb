Imports System.Data.SqlClient
Public Class good_receipt

    Private Sub good_receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New SqlDataAdapter("Select id_good_receipt, tanggal, jumlah_barang_masuk,jenis_barang,id_gudang FROM t_good_receipt where id_role_tujuan='SI'", cn)
        Dim table As New DataTable()
        adapter.Fill(table)
        tabel_good_receipt.DataSource = table
    End Sub

    Private Sub tabel_good_receipt_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_good_receipt.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tabel_good_receipt.Rows(index)
        id_good_receipt.Text = selectedRow.Cells(0).Value.ToString()
        tanggal.Text = selectedRow.Cells(1).Value.ToString()
        jumlah.Text = selectedRow.Cells(2).Value.ToString()
        jenis_barang.Text = selectedRow.Cells(3).Value.ToString()
        id_gudang.Text = selectedRow.Cells(4).Value.ToString()
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Dim searchquery As String = "Select * from t_gudang where id_gudang=@id_gudang "
        Dim cmd As New SqlCommand(searchquery, cn)

        If (id_gudang.Text = "1P") Then
            cmd.Parameters.AddWithValue("@id_gudang", "1P")
        ElseIf (id_gudang.Text = "2P") Then
            cmd.Parameters.AddWithValue("@id_gudang", "2P")
        ElseIf (id_gudang.Text = "3P") Then
            cmd.Parameters.AddWithValue("@id_gudang", "3P")
        ElseIf (id_gudang.Text = "1RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "1RM")
        ElseIf (id_gudang.Text = "2RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "2RM")
        ElseIf (id_gudang.Text = "3RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "3RM")
        ElseIf (id_gudang.Text = "4RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "4RM")
        ElseIf (id_gudang.Text = "5RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "5RM")
        ElseIf (id_gudang.Text = "6RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "6RM")
        ElseIf (id_gudang.Text = "7RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "7RM")
        ElseIf (id_gudang.Text = "8RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "8RM")
        ElseIf (id_gudang.Text = "9RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "9RM")
        ElseIf (id_gudang.Text = "10RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "10RM")
        ElseIf (id_gudang.Text = "11RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "11RM")
        ElseIf (id_gudang.Text = "12RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "12RM")
        Else

        End If

        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        da.Fill(table)

        Dim updatequery As String = "update t_gudang set total_barang=@total where id_gudang=@id_gudang"
        updateGudang(updatequery, table)

        Dim dequery As String = "delete from t_good_receipt where id_good_receipt=@id_good_receipt"
        executeQuery(dequery)
        good_receipt_Load(sender, e)
        MessageBox.Show("Permintaan Barang Dimasukkan")
    End Sub
    Private Sub executeQuery(ByVal query As String)
        Dim cmd As New SqlCommand(query, cn)
        cmd.Parameters.AddWithValue("@id_good_receipt", id_good_receipt.Text)
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub

    Private Sub updateGudang(ByVal query As String, ByVal table As DataTable)
        Dim cmd As New SqlCommand(query, cn)
        If (id_gudang.Text = "1P") Then
            cmd.Parameters.AddWithValue("@id_gudang", "1P")
        ElseIf (id_gudang.Text = "2P") Then
            cmd.Parameters.AddWithValue("@id_gudang", "2P")
        ElseIf (id_gudang.Text = "3P") Then
            cmd.Parameters.AddWithValue("@id_gudang", "3P")
        ElseIf (id_gudang.Text = "1RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "1RM")
        ElseIf (id_gudang.Text = "2RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "2RM")
        ElseIf (id_gudang.Text = "3RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "3RM")
        ElseIf (id_gudang.Text = "4RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "4RM")
        ElseIf (id_gudang.Text = "5RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "5RM")
        ElseIf (id_gudang.Text = "6RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "6RM")
        ElseIf (id_gudang.Text = "7RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "7RM")
        ElseIf (id_gudang.Text = "8RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "8RM")
        ElseIf (id_gudang.Text = "9RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "9RM")
        ElseIf (id_gudang.Text = "10RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "10RM")
        ElseIf (id_gudang.Text = "11RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "11RM")
        ElseIf (id_gudang.Text = "12RM") Then
            cmd.Parameters.AddWithValue("@id_gudang", "12RM")
        Else

        End If
        cmd.Parameters.AddWithValue("@total", Convert.ToInt32(table.Rows(0)(2).ToString) + Convert.ToInt32(jumlah.Text))
        cn.Open()
        cmd.ExecuteNonQuery()
        cn.Close()
    End Sub
End Class
