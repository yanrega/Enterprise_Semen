﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class good_issue_
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(good_issue_))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_tersedia = New System.Windows.Forms.Button()
        Me.tabel_pengecekan_produk = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_good_issue = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.id_produksi = New System.Windows.Forms.TextBox()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        CType(Me.tabel_pengecekan_produk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(244, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 18)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Good Issue Raw Material"
        '
        'btn_tersedia
        '
        Me.btn_tersedia.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tersedia.ForeColor = System.Drawing.Color.Black
        Me.btn_tersedia.Location = New System.Drawing.Point(578, 179)
        Me.btn_tersedia.Name = "btn_tersedia"
        Me.btn_tersedia.Size = New System.Drawing.Size(75, 23)
        Me.btn_tersedia.TabIndex = 82
        Me.btn_tersedia.Text = "Tersedia"
        Me.btn_tersedia.UseVisualStyleBackColor = True
        '
        'tabel_pengecekan_produk
        '
        Me.tabel_pengecekan_produk.AllowUserToAddRows = False
        Me.tabel_pengecekan_produk.AllowUserToDeleteRows = False
        Me.tabel_pengecekan_produk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabel_pengecekan_produk.Location = New System.Drawing.Point(128, 217)
        Me.tabel_pengecekan_produk.Name = "tabel_pengecekan_produk"
        Me.tabel_pengecekan_produk.ReadOnly = True
        Me.tabel_pengecekan_produk.Size = New System.Drawing.Size(481, 148)
        Me.tabel_pengecekan_produk.TabIndex = 86
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(5, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(763, 13)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'id_good_issue
        '
        Me.id_good_issue.BackColor = System.Drawing.SystemColors.Control
        Me.id_good_issue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_good_issue.Location = New System.Drawing.Point(20, 74)
        Me.id_good_issue.Name = "id_good_issue"
        Me.id_good_issue.Size = New System.Drawing.Size(282, 20)
        Me.id_good_issue.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "Tanggal"
        '
        'jumlah
        '
        Me.jumlah.BackColor = System.Drawing.SystemColors.Control
        Me.jumlah.Location = New System.Drawing.Point(368, 130)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(329, 20)
        Me.jumlah.TabIndex = 94
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(365, 109)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 15)
        Me.Label13.TabIndex = 91
        Me.Label13.Text = "Jumlah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 15)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "ID Good Issue"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(310, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Tabel Produk"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(365, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 15)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "ID Produk"
        '
        'id_produksi
        '
        Me.id_produksi.BackColor = System.Drawing.SystemColors.Control
        Me.id_produksi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_produksi.Location = New System.Drawing.Point(371, 74)
        Me.id_produksi.Name = "id_produksi"
        Me.id_produksi.Size = New System.Drawing.Size(326, 20)
        Me.id_produksi.TabIndex = 100
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(22, 130)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(280, 20)
        Me.tanggal.TabIndex = 101
        '
        'good_issue_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.id_produksi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.id_good_issue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tabel_pengecekan_produk)
        Me.Controls.Add(Me.btn_tersedia)
        Me.Controls.Add(Me.Label2)
        Me.Name = "good_issue_"
        Me.Size = New System.Drawing.Size(768, 379)
        CType(Me.tabel_pengecekan_produk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_tersedia As System.Windows.Forms.Button
    Friend WithEvents tabel_pengecekan_produk As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents id_good_issue As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents id_produksi As System.Windows.Forms.TextBox
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker

End Class
