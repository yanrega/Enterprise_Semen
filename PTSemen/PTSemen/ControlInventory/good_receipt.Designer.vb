<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class good_receipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(good_receipt))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id_gudang = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.id_good_receipt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.tanggal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.tabel_good_receipt = New System.Windows.Forms.DataGridView()
        Me.jenis_barang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.tabel_good_receipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(3, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(763, 13)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(192, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(303, 18)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Good Receipt Produk dan Raw Material"
        '
        'id_gudang
        '
        Me.id_gudang.BackColor = System.Drawing.SystemColors.Control
        Me.id_gudang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_gudang.Location = New System.Drawing.Point(392, 74)
        Me.id_gudang.Name = "id_gudang"
        Me.id_gudang.Size = New System.Drawing.Size(329, 20)
        Me.id_gudang.TabIndex = 114
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(391, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "ID Gudang"
        '
        'id_good_receipt
        '
        Me.id_good_receipt.BackColor = System.Drawing.SystemColors.Control
        Me.id_good_receipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_good_receipt.Location = New System.Drawing.Point(44, 74)
        Me.id_good_receipt.Name = "id_good_receipt"
        Me.id_good_receipt.Size = New System.Drawing.Size(282, 20)
        Me.id_good_receipt.TabIndex = 112
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Tanggal"
        '
        'jumlah
        '
        Me.jumlah.BackColor = System.Drawing.SystemColors.Control
        Me.jumlah.Location = New System.Drawing.Point(392, 130)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(329, 20)
        Me.jumlah.TabIndex = 110
        '
        'tanggal
        '
        Me.tanggal.BackColor = System.Drawing.SystemColors.Control
        Me.tanggal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tanggal.Location = New System.Drawing.Point(46, 127)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(280, 20)
        Me.tanggal.TabIndex = 109
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(389, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 15)
        Me.Label13.TabIndex = 108
        Me.Label13.Text = "Jumlah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(43, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 15)
        Me.Label7.TabIndex = 107
        Me.Label7.Text = "ID"
        '
        'btn_confirm
        '
        Me.btn_confirm.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_confirm.Location = New System.Drawing.Point(646, 183)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(91, 23)
        Me.btn_confirm.TabIndex = 115
        Me.btn_confirm.Text = "CONFIRM"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'tabel_good_receipt
        '
        Me.tabel_good_receipt.AllowUserToAddRows = False
        Me.tabel_good_receipt.AllowUserToDeleteRows = False
        Me.tabel_good_receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabel_good_receipt.Location = New System.Drawing.Point(118, 207)
        Me.tabel_good_receipt.Name = "tabel_good_receipt"
        Me.tabel_good_receipt.ReadOnly = True
        Me.tabel_good_receipt.Size = New System.Drawing.Size(481, 148)
        Me.tabel_good_receipt.TabIndex = 116
        '
        'jenis_barang
        '
        Me.jenis_barang.BackColor = System.Drawing.SystemColors.Control
        Me.jenis_barang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jenis_barang.Location = New System.Drawing.Point(46, 168)
        Me.jenis_barang.Name = "jenis_barang"
        Me.jenis_barang.Size = New System.Drawing.Size(329, 20)
        Me.jenis_barang.TabIndex = 118
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Jenis Barang"
        '
        'good_receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.jenis_barang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tabel_good_receipt)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.id_gudang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.id_good_receipt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "good_receipt"
        Me.Size = New System.Drawing.Size(780, 379)
        CType(Me.tabel_good_receipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents id_gudang As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents id_good_receipt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents tanggal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_confirm As System.Windows.Forms.Button
    Friend WithEvents tabel_good_receipt As System.Windows.Forms.DataGridView
    Friend WithEvents jenis_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
