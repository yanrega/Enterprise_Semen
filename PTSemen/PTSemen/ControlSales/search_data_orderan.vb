Imports System.Globalization.DateTimeFormatInfo
Imports System.Data.SqlClient

Public Class search_data_orderan

    'Dim database As database = New database
    'Dim cmd As SqlCommand

    'Private Sub search_data_orderan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    load_auto_comp()
    'End Sub
    'Public Sub load_auto_comp()
    '    cari_pesan.AutoCompleteCustomSource.Clear()
    '    hide_label()
    '    Dim date_str As String

    '    Dim query As String = "select * from t_sales_order"
    '    database.cn.Open()
    '    cmd = New SqlCommand(query, database.cn)
    '    Dim data_reader As SqlDataReader = cmd.ExecuteReader()
    '    While data_reader.Read()
    '        date_str = data_reader("tgl_pesanan").ToString()
    '        cari_pesan.AutoCompleteCustomSource.Add(data_reader("nama_pelanggan").ToString() + " - P" + convert_to_date_MMddyyy(date_str) + data_reader("id_sales_order").ToString())
    '    End While
    '    database.cn.Close()
    'End Sub

    'Private Sub cari_pesan_KeyDown(sender As Object, e As KeyEventArgs) Handles cari_pesan.KeyDown
    '    If (e.KeyCode = Keys.Enter) Then
    '        show_label()
    '        Dim d As Date
    '        Dim f As Date
    '        Dim query As String = "select * from t_sales_order where id_sales_order=@id_sales_order"
    '        database.cn.Open()
    '        cmd = New SqlCommand(query, database.cn)
    '        cmd.Parameters.AddWithValue("@id_sales_order", get_id(cari_pesan.Text))
    '        Dim data_reader As SqlDataReader = cmd.ExecuteReader(CommandBehavior.SingleResult)
    '        While data_reader.Read()
    '            Dim date_str As String = data_reader("tgl_pesanan").ToString()
    '            id_sales_order.Text = "P" + convert_to_date_MMddyyy(date_str) + data_reader("id_sales_order").ToString()
    '            nama_pelanggan.Text = data_reader("nama_pelanggan").ToString()
    '            nomor_telepon.Text = data_reader("no_telepon")
    '            alamat.Text = data_reader("alamat")
    '            d = data_reader("tgl_pesanan")
    '            tanggal_pesanan.Text = d
    '            status.Text = IIf(IsDBNull(data_reader("tgl_selesai")), "dalam proses", "sudah diorder")
    '            If (IsDBNull(data_reader("tgl_selesai"))) Then
    '                tanggal_selesai.Text = "------"
    '            Else
    '                d = data_reader("tgl_selesai")
    '                tanggal_selesai.Text = d
    '            End If
    '            f = data_reader("tgl_pesanan")
    '            status_barang.Text = f
    '            status_barang.Text = IIf(IsDate(data_reader("tgl_status_barang")), "Waiting", "Ready")
    '            If (IsDBNull(data_reader("tgl_status_barang"))) Then
    '                tanggal_selesai.Text = "------"
    '            Else
    '                f = data_reader("tgl_status_barang")
    '                tanggal_selesai.Text = f
    '            End If
    '            jenis_produk.Text = data_reader("nomor_produk")
    '        End While
    '        database.cn.Close()
    '    End If

    'End Sub
    'Function get_id(ByVal str As String) As Integer
    '    Dim id As String = ""
    '    Dim max, np, i As Integer
    '    str = StrReverse(str)
    '    np = str.IndexOf("P")
    '    max = np - 6
    '    For i = 0 To max - 1 Step 1
    '        id += GetChar(str, i + 1).ToString()
    '    Next
    '    id = StrReverse(id)
    '    Return Integer.Parse(id)
    'End Function
    'Function convert_to_date_MMddyyy(ByVal date_str As String) As String
    '    Dim expenddt As Date
    '    expenddt = Date.ParseExact(date_str, "MM/dd/yyyy hh:mm:ss tt", InvariantInfo)
    '    Dim Y As String
    '    Dim M As String
    '    Dim D As String
    '    Y = (expenddt.Year.ToString).Substring(2)
    '    M = expenddt.Month.ToString()
    '    M = IIf(M.Length > 1, M, "0" + M)
    '    D = expenddt.Day.ToString()
    '    D = IIf(D.Length > 1, D, "0" + D)
    '    Return D + M + Y
    'End Function
    'Sub hide_label()
    '    Label4.Hide()
    '    Label7.Hide()
    '    Label9.Hide()
    '    Label11.Hide()
    '    Label15.Hide()
    '    Label13.Hide()
    '    Label17.Hide()
    '    Label19.Hide()
    '    Label5.Hide()
    '    Label6.Hide()
    '    status_barang.Hide()
    '    alamat.Hide()
    '    tanggal_pesanan.Hide()
    '    id_sales_order.Hide()
    '    nama_pelanggan.Hide()
    '    nomor_telepon.Hide()
    '    jenis_produk.Hide()
    '    jumlah.Hide()
    '    status.Hide()
    '    tanggal_selesai.Hide()
    'End Sub
    'Sub show_label()
    '    Label4.Show()
    '    Label7.Show()
    '    Label9.Show()
    '    Label11.Show()
    '    Label15.Show()
    '    Label13.Show()
    '    Label17.Show()
    '    Label19.Show()
    '    Label5.Show()
    '    alamat.Show()
    '    Label6.Show()
    '    status_barang.Show()
    '    tanggal_pesanan.Show()
    '    id_sales_order.Show()
    '    nama_pelanggan.Show()
    '    nomor_telepon.Show()
    '    jenis_produk.Show()
    '    jumlah.Show()
    '    status.Show()
    '    tanggal_selesai.Show()
    'End Sub

    Private Sub tabel_pengecekan_produk_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabel_pengecekan_produk.CellContentClick
        Dim adapter As New SqlDataAdapter("Select * FROM t_sales_order", cn)
        Dim table As New DataTable()
        adapter.Fill(table)
        tabel_pengecekan_produk.DataSource = table
    End Sub
End Class
