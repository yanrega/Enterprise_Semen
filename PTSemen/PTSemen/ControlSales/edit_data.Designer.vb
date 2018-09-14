<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_data
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_data))
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.jenis_produk = New System.Windows.Forms.ComboBox()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.nomor_telepon = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.nama_pelanggan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_hapus = New System.Windows.Forms.Button()
        Me.tabel_order = New System.Windows.Forms.DataGridView()
        Me.lblid_pelanggan = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.tabel_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(340, 115)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(329, 20)
        Me.jumlah.TabIndex = 72
        '
        'jenis_produk
        '
        Me.jenis_produk.FormattingEnabled = True
        Me.jenis_produk.Location = New System.Drawing.Point(340, 63)
        Me.jenis_produk.Name = "jenis_produk"
        Me.jenis_produk.Size = New System.Drawing.Size(329, 21)
        Me.jenis_produk.TabIndex = 71
        '
        'alamat
        '
        Me.alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alamat.Location = New System.Drawing.Point(18, 166)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(263, 20)
        Me.alamat.TabIndex = 70
        '
        'nomor_telepon
        '
        Me.nomor_telepon.Location = New System.Drawing.Point(18, 115)
        Me.nomor_telepon.Name = "nomor_telepon"
        Me.nomor_telepon.Size = New System.Drawing.Size(263, 20)
        Me.nomor_telepon.TabIndex = 69
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 148)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 15)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Alamat"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(337, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 15)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "Jumlah"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(337, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 15)
        Me.Label15.TabIndex = 66
        Me.Label15.Text = "Jenis Produk"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 15)
        Me.Label9.TabIndex = 65
        Me.Label9.Text = "Nomor Telepon"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 15)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Nama Pelanggan"
        '
        'nama_pelanggan
        '
        Me.nama_pelanggan.Location = New System.Drawing.Point(18, 63)
        Me.nama_pelanggan.Name = "nama_pelanggan"
        Me.nama_pelanggan.Size = New System.Drawing.Size(263, 20)
        Me.nama_pelanggan.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(15, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 18)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Edit Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(-3, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(763, 13)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(340, 159)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(103, 27)
        Me.btn_update.TabIndex = 76
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_hapus
        '
        Me.btn_hapus.Location = New System.Drawing.Point(460, 159)
        Me.btn_hapus.Name = "btn_hapus"
        Me.btn_hapus.Size = New System.Drawing.Size(103, 27)
        Me.btn_hapus.TabIndex = 77
        Me.btn_hapus.Text = "Hapus"
        Me.btn_hapus.UseVisualStyleBackColor = True
        '
        'tabel_order
        '
        Me.tabel_order.AllowUserToAddRows = False
        Me.tabel_order.AllowUserToDeleteRows = False
        Me.tabel_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabel_order.Location = New System.Drawing.Point(18, 192)
        Me.tabel_order.Name = "tabel_order"
        Me.tabel_order.ReadOnly = True
        Me.tabel_order.Size = New System.Drawing.Size(651, 163)
        Me.tabel_order.TabIndex = 79
        '
        'lblid_pelanggan
        '
        Me.lblid_pelanggan.AutoSize = True
        Me.lblid_pelanggan.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid_pelanggan.Location = New System.Drawing.Point(155, 43)
        Me.lblid_pelanggan.Name = "lblid_pelanggan"
        Me.lblid_pelanggan.Size = New System.Drawing.Size(92, 15)
        Me.lblid_pelanggan.TabIndex = 80
        Me.lblid_pelanggan.Text = "ID Pelanggan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(137, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 18)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "/"
        '
        'edit_data
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblid_pelanggan)
        Me.Controls.Add(Me.tabel_order)
        Me.Controls.Add(Me.btn_hapus)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.jenis_produk)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.nomor_telepon)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nama_pelanggan)
        Me.Name = "edit_data"
        Me.Size = New System.Drawing.Size(768, 379)
        CType(Me.tabel_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents jenis_produk As System.Windows.Forms.ComboBox
    Friend WithEvents alamat As System.Windows.Forms.TextBox
    Friend WithEvents nomor_telepon As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nama_pelanggan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_hapus As System.Windows.Forms.Button
    Friend WithEvents tabel_order As System.Windows.Forms.DataGridView
    Friend WithEvents lblid_pelanggan As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
