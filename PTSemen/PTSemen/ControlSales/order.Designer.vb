<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class order
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(order))
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nama_pelanggan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.no_telepon = New System.Windows.Forms.TextBox()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.total_harga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tabel_produk = New System.Windows.Forms.DataGridView()
        Me.id_barang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.jenis_barang_order = New System.Windows.Forms.TextBox()
        CType(Me.tabel_produk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 15)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Alamat"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(383, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 15)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Jumlah"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 15)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Nomor Telepon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 15)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Nama Pelanggan"
        '
        'nama_pelanggan
        '
        Me.nama_pelanggan.Location = New System.Drawing.Point(29, 75)
        Me.nama_pelanggan.Name = "nama_pelanggan"
        Me.nama_pelanggan.Size = New System.Drawing.Size(263, 20)
        Me.nama_pelanggan.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(16, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 18)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Entry Sales Order"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(-1, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(766, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'no_telepon
        '
        Me.no_telepon.Location = New System.Drawing.Point(29, 143)
        Me.no_telepon.Name = "no_telepon"
        Me.no_telepon.Size = New System.Drawing.Size(263, 20)
        Me.no_telepon.TabIndex = 58
        '
        'alamat
        '
        Me.alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alamat.Location = New System.Drawing.Point(29, 211)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(263, 20)
        Me.alamat.TabIndex = 59
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(386, 143)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(329, 20)
        Me.jumlah.TabIndex = 61
        '
        'btn_simpan
        '
        Me.btn_simpan.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_simpan.Location = New System.Drawing.Point(590, 329)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(125, 33)
        Me.btn_simpan.TabIndex = 62
        Me.btn_simpan.Text = "CREATE"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'total_harga
        '
        Me.total_harga.BackColor = System.Drawing.SystemColors.Control
        Me.total_harga.Location = New System.Drawing.Point(29, 342)
        Me.total_harga.Name = "total_harga"
        Me.total_harga.Size = New System.Drawing.Size(263, 20)
        Me.total_harga.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 324)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Total Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Tanggal"
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(29, 288)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(263, 20)
        Me.tanggal.TabIndex = 67
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(383, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Jenis Barang"
        '
        'tabel_produk
        '
        Me.tabel_produk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabel_produk.Location = New System.Drawing.Point(386, 248)
        Me.tabel_produk.Name = "tabel_produk"
        Me.tabel_produk.Size = New System.Drawing.Size(329, 75)
        Me.tabel_produk.TabIndex = 75
        '
        'id_barang
        '
        Me.id_barang.BackColor = System.Drawing.SystemColors.Control
        Me.id_barang.Location = New System.Drawing.Point(386, 211)
        Me.id_barang.Name = "id_barang"
        Me.id_barang.Size = New System.Drawing.Size(329, 20)
        Me.id_barang.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(383, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 15)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "ID Barang"
        '
        'jenis_barang_order
        '
        Me.jenis_barang_order.BackColor = System.Drawing.SystemColors.Control
        Me.jenis_barang_order.Location = New System.Drawing.Point(386, 75)
        Me.jenis_barang_order.Name = "jenis_barang_order"
        Me.jenis_barang_order.Size = New System.Drawing.Size(329, 20)
        Me.jenis_barang_order.TabIndex = 74
        '
        'order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.id_barang)
        Me.Controls.Add(Me.tabel_produk)
        Me.Controls.Add(Me.jenis_barang_order)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.total_harga)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.no_telepon)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nama_pelanggan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "order"
        Me.Size = New System.Drawing.Size(768, 379)
        CType(Me.tabel_produk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nama_pelanggan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents no_telepon As System.Windows.Forms.TextBox
    Friend WithEvents alamat As System.Windows.Forms.TextBox
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents total_harga As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tabel_produk As System.Windows.Forms.DataGridView
    Friend WithEvents id_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents jenis_barang_order As System.Windows.Forms.TextBox

End Class
