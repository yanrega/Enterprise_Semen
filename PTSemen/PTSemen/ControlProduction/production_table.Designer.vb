<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class production_table
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(production_table))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_produksi = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.id_good = New System.Windows.Forms.TextBox()
        Me.btn_kirim = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.jenis_barang = New System.Windows.Forms.TextBox()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.id_barang = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(22, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(196, 18)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Production Order Receipt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(-3, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(784, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 44)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(404, 211)
        Me.DataGridView1.TabIndex = 80
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(25, 328)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(263, 20)
        Me.tanggal.TabIndex = 90
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 310)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Tanggal"
        '
        'id_produksi
        '
        Me.id_produksi.BackColor = System.Drawing.SystemColors.Control
        Me.id_produksi.Location = New System.Drawing.Point(319, 276)
        Me.id_produksi.Name = "id_produksi"
        Me.id_produksi.Size = New System.Drawing.Size(329, 20)
        Me.id_produksi.TabIndex = 88
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(316, 258)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 15)
        Me.Label13.TabIndex = 87
        Me.Label13.Text = "ID Produksi"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(22, 258)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(23, 15)
        Me.Label.TabIndex = 86
        Me.Label.Text = "ID"
        '
        'id_good
        '
        Me.id_good.BackColor = System.Drawing.SystemColors.Control
        Me.id_good.Location = New System.Drawing.Point(25, 276)
        Me.id_good.Name = "id_good"
        Me.id_good.Size = New System.Drawing.Size(263, 20)
        Me.id_good.TabIndex = 85
        '
        'btn_kirim
        '
        Me.btn_kirim.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_kirim.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_kirim.Location = New System.Drawing.Point(674, 329)
        Me.btn_kirim.Name = "btn_kirim"
        Me.btn_kirim.Size = New System.Drawing.Size(75, 23)
        Me.btn_kirim.TabIndex = 91
        Me.btn_kirim.Text = "CREATE"
        Me.btn_kirim.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(316, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 15)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Jenis Barang"
        '
        'jenis_barang
        '
        Me.jenis_barang.BackColor = System.Drawing.SystemColors.Control
        Me.jenis_barang.Location = New System.Drawing.Point(319, 328)
        Me.jenis_barang.Name = "jenis_barang"
        Me.jenis_barang.Size = New System.Drawing.Size(329, 20)
        Me.jenis_barang.TabIndex = 93
        '
        'jumlah
        '
        Me.jumlah.BackColor = System.Drawing.SystemColors.Control
        Me.jumlah.Location = New System.Drawing.Point(435, 174)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(329, 20)
        Me.jumlah.TabIndex = 95
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(432, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 15)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Jumlah"
        '
        'id_barang
        '
        Me.id_barang.AutoSize = True
        Me.id_barang.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_barang.Location = New System.Drawing.Point(411, 310)
        Me.id_barang.Name = "id_barang"
        Me.id_barang.Size = New System.Drawing.Size(73, 15)
        Me.id_barang.TabIndex = 96
        Me.id_barang.Text = "ID Barang"
        '
        'production_table
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.id_barang)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.jenis_barang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_kirim)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.id_produksi)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.id_good)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Name = "production_table"
        Me.Size = New System.Drawing.Size(780, 379)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents id_produksi As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents id_good As System.Windows.Forms.TextBox
    Friend WithEvents btn_kirim As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents jenis_barang As System.Windows.Forms.TextBox
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents id_barang As System.Windows.Forms.Label

End Class
