<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daftar_semen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(daftar_semen))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabel_produk = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_good_issue = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.id_semen = New System.Windows.Forms.Label()
        Me.jenis_semen = New System.Windows.Forms.TextBox()
        CType(Me.tabel_produk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(390, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Jumlah"
        '
        'jumlah
        '
        Me.jumlah.BackColor = System.Drawing.SystemColors.Window
        Me.jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlah.Location = New System.Drawing.Point(393, 283)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(282, 20)
        Me.jumlah.TabIndex = 111
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(41, 283)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(280, 20)
        Me.tanggal.TabIndex = 110
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(278, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 18)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Data Produk"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(3, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(763, 13)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'tabel_produk
        '
        Me.tabel_produk.AllowUserToAddRows = False
        Me.tabel_produk.AllowUserToDeleteRows = False
        Me.tabel_produk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabel_produk.Location = New System.Drawing.Point(69, 79)
        Me.tabel_produk.Name = "tabel_produk"
        Me.tabel_produk.ReadOnly = True
        Me.tabel_produk.Size = New System.Drawing.Size(606, 159)
        Me.tabel_produk.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 265)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 113
        Me.Label1.Text = "Tanggal"
        '
        'btn_good_issue
        '
        Me.btn_good_issue.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_good_issue.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_good_issue.Location = New System.Drawing.Point(529, 330)
        Me.btn_good_issue.Name = "btn_good_issue"
        Me.btn_good_issue.Size = New System.Drawing.Size(75, 23)
        Me.btn_good_issue.TabIndex = 114
        Me.btn_good_issue.Text = "ADD"
        Me.btn_good_issue.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 115
        Me.Label5.Text = "Jenis"
        '
        'id_semen
        '
        Me.id_semen.AutoSize = True
        Me.id_semen.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_semen.Location = New System.Drawing.Point(83, 315)
        Me.id_semen.Name = "id_semen"
        Me.id_semen.Size = New System.Drawing.Size(23, 15)
        Me.id_semen.TabIndex = 117
        Me.id_semen.Text = "ID"
        '
        'jenis_semen
        '
        Me.jenis_semen.BackColor = System.Drawing.SystemColors.Control
        Me.jenis_semen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jenis_semen.Location = New System.Drawing.Point(41, 333)
        Me.jenis_semen.Name = "jenis_semen"
        Me.jenis_semen.Size = New System.Drawing.Size(282, 20)
        Me.jenis_semen.TabIndex = 118
        '
        'daftar_semen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.jenis_semen)
        Me.Controls.Add(Me.id_semen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_good_issue)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tabel_produk)
        Me.Name = "daftar_semen"
        Me.Size = New System.Drawing.Size(768, 379)
        CType(Me.tabel_produk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tabel_produk As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_good_issue As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents id_semen As System.Windows.Forms.Label
    Friend WithEvents jenis_semen As System.Windows.Forms.TextBox

End Class
