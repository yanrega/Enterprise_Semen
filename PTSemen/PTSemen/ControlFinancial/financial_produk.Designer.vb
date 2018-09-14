<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class financial_produk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(financial_produk))
        Me.jumlah_barang = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.id_good = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.btn_invoice = New System.Windows.Forms.Button()
        Me.tabel_invoice = New System.Windows.Forms.DataGridView()
        Me.jenis_barang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.id_barang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.status_bayar = New System.Windows.Forms.TextBox()
        CType(Me.tabel_invoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'jumlah_barang
        '
        Me.jumlah_barang.BackColor = System.Drawing.SystemColors.Control
        Me.jumlah_barang.Location = New System.Drawing.Point(381, 142)
        Me.jumlah_barang.Name = "jumlah_barang"
        Me.jumlah_barang.Size = New System.Drawing.Size(329, 20)
        Me.jumlah_barang.TabIndex = 82
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(382, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 15)
        Me.Label13.TabIndex = 80
        Me.Label13.Text = "Jumlah"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(23, 44)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(23, 15)
        Me.Label.TabIndex = 78
        Me.Label.Text = "ID"
        '
        'id_good
        '
        Me.id_good.BackColor = System.Drawing.SystemColors.Control
        Me.id_good.Location = New System.Drawing.Point(26, 73)
        Me.id_good.Name = "id_good"
        Me.id_good.Size = New System.Drawing.Size(263, 20)
        Me.id_good.TabIndex = 77
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(23, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 18)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Create Invoice Produk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(-3, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(781, 13)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Tanggal"
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(26, 142)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(263, 20)
        Me.tanggal.TabIndex = 84
        '
        'btn_invoice
        '
        Me.btn_invoice.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_invoice.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_invoice.Location = New System.Drawing.Point(613, 184)
        Me.btn_invoice.Name = "btn_invoice"
        Me.btn_invoice.Size = New System.Drawing.Size(75, 23)
        Me.btn_invoice.TabIndex = 85
        Me.btn_invoice.Text = "CREATE"
        Me.btn_invoice.UseVisualStyleBackColor = True
        '
        'tabel_invoice
        '
        Me.tabel_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabel_invoice.Location = New System.Drawing.Point(26, 213)
        Me.tabel_invoice.Name = "tabel_invoice"
        Me.tabel_invoice.Size = New System.Drawing.Size(684, 163)
        Me.tabel_invoice.TabIndex = 86
        '
        'jenis_barang
        '
        Me.jenis_barang.BackColor = System.Drawing.SystemColors.Control
        Me.jenis_barang.Location = New System.Drawing.Point(381, 73)
        Me.jenis_barang.Name = "jenis_barang"
        Me.jenis_barang.Size = New System.Drawing.Size(329, 20)
        Me.jenis_barang.TabIndex = 88
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(382, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Jenis"
        '
        'id_barang
        '
        Me.id_barang.BackColor = System.Drawing.SystemColors.Control
        Me.id_barang.Location = New System.Drawing.Point(545, 42)
        Me.id_barang.Name = "id_barang"
        Me.id_barang.Size = New System.Drawing.Size(165, 20)
        Me.id_barang.TabIndex = 90
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(451, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "ID Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(184, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 15)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Status Bayar"
        '
        'status_bayar
        '
        Me.status_bayar.BackColor = System.Drawing.SystemColors.Control
        Me.status_bayar.Location = New System.Drawing.Point(278, 179)
        Me.status_bayar.Name = "status_bayar"
        Me.status_bayar.Size = New System.Drawing.Size(119, 20)
        Me.status_bayar.TabIndex = 92
        '
        'financial_produk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.status_bayar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.id_barang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.jenis_barang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tabel_invoice)
        Me.Controls.Add(Me.btn_invoice)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.jumlah_barang)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.id_good)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "financial_produk"
        Me.Size = New System.Drawing.Size(780, 379)
        CType(Me.tabel_invoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents jumlah_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents id_good As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_invoice As System.Windows.Forms.Button
    Friend WithEvents tabel_invoice As System.Windows.Forms.DataGridView
    Friend WithEvents jenis_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents id_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents status_bayar As System.Windows.Forms.TextBox

End Class
