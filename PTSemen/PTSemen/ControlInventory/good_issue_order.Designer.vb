<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class good_issue_order
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(good_issue_order))
        Me.tabel_good_issue = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id_sales_order = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.jumlah_barang = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_good_issue = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jenis_barang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.id_barang = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.status_bayar = New System.Windows.Forms.TextBox()
        CType(Me.tabel_good_issue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabel_good_issue
        '
        Me.tabel_good_issue.AllowUserToAddRows = False
        Me.tabel_good_issue.AllowUserToDeleteRows = False
        Me.tabel_good_issue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabel_good_issue.Location = New System.Drawing.Point(68, 73)
        Me.tabel_good_issue.Name = "tabel_good_issue"
        Me.tabel_good_issue.ReadOnly = True
        Me.tabel_good_issue.Size = New System.Drawing.Size(606, 159)
        Me.tabel_good_issue.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(2, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(763, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(277, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 18)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Good Issue Produk"
        '
        'id_sales_order
        '
        Me.id_sales_order.BackColor = System.Drawing.SystemColors.Control
        Me.id_sales_order.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_sales_order.Location = New System.Drawing.Point(21, 277)
        Me.id_sales_order.Name = "id_sales_order"
        Me.id_sales_order.Size = New System.Drawing.Size(282, 20)
        Me.id_sales_order.TabIndex = 99
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 15)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "ID Sales Order"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 15)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Tanggal Pemberitahuan"
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(23, 330)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(280, 20)
        Me.tanggal.TabIndex = 101
        '
        'jumlah_barang
        '
        Me.jumlah_barang.BackColor = System.Drawing.SystemColors.Control
        Me.jumlah_barang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlah_barang.Location = New System.Drawing.Point(356, 277)
        Me.jumlah_barang.Name = "jumlah_barang"
        Me.jumlah_barang.Size = New System.Drawing.Size(282, 20)
        Me.jumlah_barang.TabIndex = 102
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(353, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Jumlah"
        '
        'btn_good_issue
        '
        Me.btn_good_issue.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_good_issue.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_good_issue.Location = New System.Drawing.Point(599, 353)
        Me.btn_good_issue.Name = "btn_good_issue"
        Me.btn_good_issue.Size = New System.Drawing.Size(75, 23)
        Me.btn_good_issue.TabIndex = 104
        Me.btn_good_issue.Text = "CREATE"
        Me.btn_good_issue.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(353, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 15)
        Me.Label5.TabIndex = 105
        Me.Label5.Text = "Jenis Barang"
        '
        'jenis_barang
        '
        Me.jenis_barang.BackColor = System.Drawing.SystemColors.Control
        Me.jenis_barang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jenis_barang.Location = New System.Drawing.Point(356, 327)
        Me.jenis_barang.Name = "jenis_barang"
        Me.jenis_barang.Size = New System.Drawing.Size(282, 20)
        Me.jenis_barang.TabIndex = 106
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(669, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 15)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "ID Barang"
        '
        'id_barang
        '
        Me.id_barang.BackColor = System.Drawing.SystemColors.Control
        Me.id_barang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_barang.Location = New System.Drawing.Point(669, 277)
        Me.id_barang.Name = "id_barang"
        Me.id_barang.Size = New System.Drawing.Size(60, 20)
        Me.id_barang.TabIndex = 108
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(669, 312)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 15)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Status Barang"
        '
        'status_bayar
        '
        Me.status_bayar.BackColor = System.Drawing.SystemColors.Control
        Me.status_bayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_bayar.Location = New System.Drawing.Point(672, 327)
        Me.status_bayar.Name = "status_bayar"
        Me.status_bayar.Size = New System.Drawing.Size(70, 20)
        Me.status_bayar.TabIndex = 110
        '
        'good_issue_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.status_bayar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.id_barang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.jenis_barang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_good_issue)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.jumlah_barang)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.id_sales_order)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tabel_good_issue)
        Me.Name = "good_issue_order"
        Me.Size = New System.Drawing.Size(768, 379)
        CType(Me.tabel_good_issue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabel_good_issue As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents id_sales_order As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents jumlah_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_good_issue As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents jenis_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents id_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents status_bayar As System.Windows.Forms.TextBox

End Class
