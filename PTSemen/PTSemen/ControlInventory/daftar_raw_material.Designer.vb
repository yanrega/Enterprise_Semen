<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daftar_raw_material
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(daftar_raw_material))
        Me.btn_tambah = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.jumlah = New System.Windows.Forms.TextBox()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tabel_raw_material = New System.Windows.Forms.DataGridView()
        Me.jenis_raw_material = New System.Windows.Forms.TextBox()
        Me.id_raw_material = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.tabel_raw_material, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_tambah
        '
        Me.btn_tambah.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_tambah.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_tambah.Location = New System.Drawing.Point(529, 331)
        Me.btn_tambah.Name = "btn_tambah"
        Me.btn_tambah.Size = New System.Drawing.Size(75, 23)
        Me.btn_tambah.TabIndex = 122
        Me.btn_tambah.Text = "ADD"
        Me.btn_tambah.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Tanggal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(390, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Jumlah"
        '
        'jumlah
        '
        Me.jumlah.BackColor = System.Drawing.SystemColors.Window
        Me.jumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jumlah.Location = New System.Drawing.Point(393, 284)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(282, 20)
        Me.jumlah.TabIndex = 119
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(41, 284)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(280, 20)
        Me.tanggal.TabIndex = 118
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(278, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 18)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Data Raw Material"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(3, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(763, 13)
        Me.Label3.TabIndex = 116
        Me.Label3.Text = resources.GetString("Label3.Text")
        '
        'tabel_raw_material
        '
        Me.tabel_raw_material.AllowUserToAddRows = False
        Me.tabel_raw_material.AllowUserToDeleteRows = False
        Me.tabel_raw_material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabel_raw_material.Location = New System.Drawing.Point(69, 80)
        Me.tabel_raw_material.Name = "tabel_raw_material"
        Me.tabel_raw_material.ReadOnly = True
        Me.tabel_raw_material.Size = New System.Drawing.Size(606, 159)
        Me.tabel_raw_material.TabIndex = 115
        '
        'jenis_raw_material
        '
        Me.jenis_raw_material.BackColor = System.Drawing.SystemColors.Control
        Me.jenis_raw_material.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jenis_raw_material.Location = New System.Drawing.Point(41, 344)
        Me.jenis_raw_material.Name = "jenis_raw_material"
        Me.jenis_raw_material.Size = New System.Drawing.Size(282, 20)
        Me.jenis_raw_material.TabIndex = 125
        '
        'id_raw_material
        '
        Me.id_raw_material.AutoSize = True
        Me.id_raw_material.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id_raw_material.Location = New System.Drawing.Point(83, 326)
        Me.id_raw_material.Name = "id_raw_material"
        Me.id_raw_material.Size = New System.Drawing.Size(23, 15)
        Me.id_raw_material.TabIndex = 124
        Me.id_raw_material.Text = "ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 326)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 15)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "Jenis"
        '
        'daftar_raw_material
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.jenis_raw_material)
        Me.Controls.Add(Me.id_raw_material)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_tambah)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.jumlah)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tabel_raw_material)
        Me.Name = "daftar_raw_material"
        Me.Size = New System.Drawing.Size(768, 379)
        CType(Me.tabel_raw_material, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_tambah As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents jumlah As System.Windows.Forms.TextBox
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tabel_raw_material As System.Windows.Forms.DataGridView
    Friend WithEvents jenis_raw_material As System.Windows.Forms.TextBox
    Friend WithEvents id_raw_material As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
