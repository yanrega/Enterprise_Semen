<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invoice_purchase_order
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(invoice_purchase_order))
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tabel_invoice_PO = New System.Windows.Forms.DataGridView()
        Me.btn_confirm = New System.Windows.Forms.Button()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.id_purchase = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.id_invoice = New System.Windows.Forms.TextBox()
        Me.jenis_barang = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.id_barang = New System.Windows.Forms.TextBox()
        CType(Me.tabel_invoice_PO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'jumlah
        '
        Me.jumlah.BackColor = System.Drawing.SystemColors.Control
        Me.jumlah.Location = New System.Drawing.Point(384, 57)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(329, 20)
        Me.jumlah.TabIndex = 110
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(385, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "Jumlah"
        '
        'tabel_invoice_PO
        '
        Me.tabel_invoice_PO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabel_invoice_PO.Location = New System.Drawing.Point(29, 208)
        Me.tabel_invoice_PO.Name = "tabel_invoice_PO"
        Me.tabel_invoice_PO.Size = New System.Drawing.Size(684, 163)
        Me.tabel_invoice_PO.TabIndex = 108
        '
        'btn_confirm
        '
        Me.btn_confirm.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirm.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_confirm.Location = New System.Drawing.Point(616, 179)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(97, 23)
        Me.btn_confirm.TabIndex = 107
        Me.btn_confirm.Text = "CONFIRM"
        Me.btn_confirm.UseVisualStyleBackColor = True
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(29, 167)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(263, 20)
        Me.tanggal.TabIndex = 106
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Tanggal"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.Location = New System.Drawing.Point(26, 39)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(23, 15)
        Me.Label.TabIndex = 102
        Me.Label.Text = "ID"
        '
        'id_purchase
        '
        Me.id_purchase.BackColor = System.Drawing.SystemColors.Control
        Me.id_purchase.Location = New System.Drawing.Point(29, 57)
        Me.id_purchase.Name = "id_purchase"
        Me.id_purchase.Size = New System.Drawing.Size(263, 20)
        Me.id_purchase.TabIndex = 101
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(26, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 18)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Purchase Order"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(0, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(781, 13)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 111
        Me.Label5.Text = "ID Invoice"
        '
        'id_invoice
        '
        Me.id_invoice.BackColor = System.Drawing.SystemColors.Control
        Me.id_invoice.Location = New System.Drawing.Point(29, 109)
        Me.id_invoice.Name = "id_invoice"
        Me.id_invoice.Size = New System.Drawing.Size(263, 20)
        Me.id_invoice.TabIndex = 112
        '
        'jenis_barang
        '
        Me.jenis_barang.BackColor = System.Drawing.SystemColors.Control
        Me.jenis_barang.Location = New System.Drawing.Point(384, 109)
        Me.jenis_barang.Name = "jenis_barang"
        Me.jenis_barang.Size = New System.Drawing.Size(263, 20)
        Me.jenis_barang.TabIndex = 113
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(381, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 15)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Jenis Barang"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(385, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 15)
        Me.Label7.TabIndex = 115
        Me.Label7.Text = "ID Barang"
        '
        'id_barang
        '
        Me.id_barang.BackColor = System.Drawing.SystemColors.Control
        Me.id_barang.Location = New System.Drawing.Point(384, 147)
        Me.id_barang.Name = "id_barang"
        Me.id_barang.Size = New System.Drawing.Size(263, 20)
        Me.id_barang.TabIndex = 116
        '
        'invoice_purchase_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.id_barang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.jenis_barang)
        Me.Controls.Add(Me.id_invoice)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tabel_invoice_PO)
        Me.Controls.Add(Me.btn_confirm)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.id_purchase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "invoice_purchase_order"
        Me.Size = New System.Drawing.Size(780, 379)
        CType(Me.tabel_invoice_PO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tabel_invoice_PO As System.Windows.Forms.DataGridView
    Friend WithEvents btn_confirm As System.Windows.Forms.Button
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents id_purchase As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents id_invoice As System.Windows.Forms.TextBox
    Friend WithEvents jenis_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents id_barang As System.Windows.Forms.TextBox

End Class
