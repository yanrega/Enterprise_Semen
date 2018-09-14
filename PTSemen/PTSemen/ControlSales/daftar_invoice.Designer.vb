<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daftar_invoice_financial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(daftar_invoice_financial))
        Me.tabel_invoice = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.tanggal = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.jenis_barang = New System.Windows.Forms.TextBox()
        Me.btn_konfirmasi = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.id_invoice = New System.Windows.Forms.Label()
        Me.id_good_issue = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.status_bayar = New System.Windows.Forms.TextBox()
        CType(Me.tabel_invoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabel_invoice
        '
        Me.tabel_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabel_invoice.Location = New System.Drawing.Point(3, 176)
        Me.tabel_invoice.Name = "tabel_invoice"
        Me.tabel_invoice.Size = New System.Drawing.Size(762, 200)
        Me.tabel_invoice.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Tanggal"
        '
        'jumlah
        '
        Me.jumlah.BackColor = System.Drawing.SystemColors.Control
        Me.jumlah.Location = New System.Drawing.Point(368, 118)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(329, 20)
        Me.jumlah.TabIndex = 77
        '
        'tanggal
        '
        Me.tanggal.BackColor = System.Drawing.SystemColors.Control
        Me.tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal.Location = New System.Drawing.Point(22, 115)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(280, 20)
        Me.tanggal.TabIndex = 75
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(366, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 15)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Jenis"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(365, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 15)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Jumlah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 15)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "ID Invoice"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(17, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 18)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Konfirmasi Invoice"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(0, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(766, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'jenis_barang
        '
        Me.jenis_barang.BackColor = System.Drawing.SystemColors.Control
        Me.jenis_barang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jenis_barang.Location = New System.Drawing.Point(369, 62)
        Me.jenis_barang.Name = "jenis_barang"
        Me.jenis_barang.Size = New System.Drawing.Size(328, 20)
        Me.jenis_barang.TabIndex = 84
        '
        'btn_konfirmasi
        '
        Me.btn_konfirmasi.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_konfirmasi.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_konfirmasi.Location = New System.Drawing.Point(560, 143)
        Me.btn_konfirmasi.Name = "btn_konfirmasi"
        Me.btn_konfirmasi.Size = New System.Drawing.Size(102, 23)
        Me.btn_konfirmasi.TabIndex = 88
        Me.btn_konfirmasi.Text = "CONFIRM"
        Me.btn_konfirmasi.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 15)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "ID Good Issue"
        '
        'id_invoice
        '
        Me.id_invoice.AutoSize = True
        Me.id_invoice.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_invoice.Location = New System.Drawing.Point(162, 44)
        Me.id_invoice.Name = "id_invoice"
        Me.id_invoice.Size = New System.Drawing.Size(27, 15)
        Me.id_invoice.TabIndex = 90
        Me.id_invoice.Text = "----"
        '
        'id_good_issue
        '
        Me.id_good_issue.AutoSize = True
        Me.id_good_issue.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_good_issue.Location = New System.Drawing.Point(162, 67)
        Me.id_good_issue.Name = "id_good_issue"
        Me.id_good_issue.Size = New System.Drawing.Size(27, 15)
        Me.id_good_issue.TabIndex = 91
        Me.id_good_issue.Text = "----"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(194, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 15)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Status Bayar"
        '
        'status_bayar
        '
        Me.status_bayar.BackColor = System.Drawing.SystemColors.Control
        Me.status_bayar.Location = New System.Drawing.Point(288, 146)
        Me.status_bayar.Name = "status_bayar"
        Me.status_bayar.Size = New System.Drawing.Size(164, 20)
        Me.status_bayar.TabIndex = 93
        '
        'daftar_invoice_financial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.status_bayar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.id_good_issue)
        Me.Controls.Add(Me.id_invoice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_konfirmasi)
        Me.Controls.Add(Me.jenis_barang)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tabel_invoice)
        Me.Name = "daftar_invoice_financial"
        Me.Size = New System.Drawing.Size(768, 379)
        CType(Me.tabel_invoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabel_invoice As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents tanggal As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents jenis_barang As System.Windows.Forms.TextBox
    Friend WithEvents btn_konfirmasi As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents id_invoice As System.Windows.Forms.Label
    Friend WithEvents id_good_issue As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents status_bayar As System.Windows.Forms.TextBox

End Class
