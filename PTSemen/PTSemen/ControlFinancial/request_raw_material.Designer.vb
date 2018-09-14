<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class request_raw_material
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(request_raw_material))
        Me.tabel_raw_material = New System.Windows.Forms.DataGridView()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.id_purchase = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.id_barang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.jenis_barang = New System.Windows.Forms.TextBox()
        CType(Me.tabel_raw_material, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabel_raw_material
        '
        Me.tabel_raw_material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabel_raw_material.Location = New System.Drawing.Point(29, 208)
        Me.tabel_raw_material.Name = "tabel_raw_material"
        Me.tabel_raw_material.Size = New System.Drawing.Size(684, 163)
        Me.tabel_raw_material.TabIndex = 96
        '
        'btn_confirm
        '
        Me.btn_confirm.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.ForeColor = System.Drawing.Color.Black
        Me.btn_confirm.Location = New System.Drawing.Point(616, 179)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(75, 23)
        Me.btn_confirm.TabIndex = 95
        Me.btn_confirm.Text = "Confirm"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(29, 137)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(263, 20)
        Me.tanggal.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Tanggal"
        '
        'total
        '
        Me.total.BackColor = System.Drawing.SystemColors.Window
        Me.total.Location = New System.Drawing.Point(384, 137)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(329, 20)
        Me.total.TabIndex = 92
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(385, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 15)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "Harga"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(26, 39)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(23, 15)
        Me.Label.TabIndex = 90
        Me.Label.Text = "ID"
        '
        'id_purchase
        '
        Me.id_purchase.BackColor = System.Drawing.SystemColors.Control
        Me.id_purchase.Location = New System.Drawing.Point(64, 37)
        Me.id_purchase.Name = "id_purchase"
        Me.id_purchase.Size = New System.Drawing.Size(263, 20)
        Me.id_purchase.TabIndex = 89
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(26, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Purchase Order"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(0, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(781, 13)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(385, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Jumlah"
        '
        'jumlah
        '
        Me.jumlah.BackColor = System.Drawing.SystemColors.Control
        Me.jumlah.Location = New System.Drawing.Point(384, 68)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(329, 20)
        Me.jumlah.TabIndex = 98
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "ID Barang"
        '
        'id_barang
        '
        Me.id_barang.BackColor = System.Drawing.SystemColors.Control
        Me.id_barang.Location = New System.Drawing.Point(115, 68)
        Me.id_barang.Name = "id_barang"
        Me.id_barang.Size = New System.Drawing.Size(212, 20)
        Me.id_barang.TabIndex = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 15)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Jenis"
        '
        'jenis_barang
        '
        Me.jenis_barang.BackColor = System.Drawing.SystemColors.Control
        Me.jenis_barang.Location = New System.Drawing.Point(29, 178)
        Me.jenis_barang.Name = "jenis_barang"
        Me.jenis_barang.Size = New System.Drawing.Size(329, 20)
        Me.jenis_barang.TabIndex = 102
        '
        'request_raw_material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.jenis_barang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.id_barang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tabel_raw_material)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.id_purchase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "request_raw_material"
        Me.Size = New System.Drawing.Size(780, 379)
        CType(Me.tabel_raw_material, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabel_raw_material As System.Windows.Forms.DataGridView
    Friend WithEvents btn_confirm As System.Windows.Forms.Button
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents id_purchase As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents id_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents jenis_barang As System.Windows.Forms.TextBox

End Class
