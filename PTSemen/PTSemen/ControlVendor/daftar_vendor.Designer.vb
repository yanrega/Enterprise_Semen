<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daftar_vendor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(daftar_vendor))
        Me.btn_simpan = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.id_po = New System.Windows.Forms.TextBox()
        Me.tabel_purchase = New System.Windows.Forms.DataGridView()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.id_barang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jenis_barang = New System.Windows.Forms.TextBox()
        CType(Me.tabel_purchase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_simpan
        '
        Me.btn_simpan.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_simpan.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_simpan.Location = New System.Drawing.Point(537, 170)
        Me.btn_simpan.Name = "btn_simpan"
        Me.btn_simpan.Size = New System.Drawing.Size(103, 27)
        Me.btn_simpan.TabIndex = 89
        Me.btn_simpan.Text = "CREATE"
        Me.btn_simpan.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(18, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 18)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Create Invoice Receipt"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(-1, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(781, 13)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 15)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Tanggal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 15)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "ID"
        '
        'id_po
        '
        Me.id_po.BackColor = System.Drawing.SystemColors.Control
        Me.id_po.Location = New System.Drawing.Point(21, 75)
        Me.id_po.Name = "id_po"
        Me.id_po.Size = New System.Drawing.Size(263, 20)
        Me.id_po.TabIndex = 77
        '
        'tabel_purchase
        '
        Me.tabel_purchase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabel_purchase.Location = New System.Drawing.Point(125, 203)
        Me.tabel_purchase.Name = "tabel_purchase"
        Me.tabel_purchase.Size = New System.Drawing.Size(515, 150)
        Me.tabel_purchase.TabIndex = 91
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(21, 132)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(263, 20)
        Me.tanggal.TabIndex = 92
        '
        'jumlah
        '
        Me.jumlah.BackColor = System.Drawing.SystemColors.Control
        Me.jumlah.Location = New System.Drawing.Point(349, 75)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(263, 20)
        Me.jumlah.TabIndex = 93
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(346, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 15)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(346, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 96
        Me.Label4.Text = "ID Barang"
        '
        'id_barang
        '
        Me.id_barang.BackColor = System.Drawing.SystemColors.Control
        Me.id_barang.Location = New System.Drawing.Point(349, 129)
        Me.id_barang.Name = "id_barang"
        Me.id_barang.Size = New System.Drawing.Size(263, 20)
        Me.id_barang.TabIndex = 95
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "Jenis Barang"
        '
        'jenis_barang
        '
        Me.jenis_barang.BackColor = System.Drawing.SystemColors.Control
        Me.jenis_barang.Location = New System.Drawing.Point(21, 177)
        Me.jenis_barang.Name = "jenis_barang"
        Me.jenis_barang.Size = New System.Drawing.Size(263, 20)
        Me.jenis_barang.TabIndex = 97
        '
        'daftar_vendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.jenis_barang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.id_barang)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.tabel_purchase)
        Me.Controls.Add(Me.btn_simpan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.id_po)
        Me.Name = "daftar_vendor"
        Me.Size = New System.Drawing.Size(780, 379)
        CType(Me.tabel_purchase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_simpan As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents id_po As System.Windows.Forms.TextBox
    Friend WithEvents tabel_purchase As System.Windows.Forms.DataGridView
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents id_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents jenis_barang As System.Windows.Forms.TextBox

End Class
