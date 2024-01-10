<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTransaksi))
        Me.TxtDiscount = New System.Windows.Forms.TextBox()
        Me.LblTotalHargaBersih = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DGTransaksi = New System.Windows.Forms.DataGridView()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LblNmKasir = New System.Windows.Forms.Label()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnCetak = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.CmbPaket = New System.Windows.Forms.ComboBox()
        Me.CmbKasir = New System.Windows.Forms.ComboBox()
        Me.LblNamaPaket = New System.Windows.Forms.Label()
        Me.LblHarga = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblNamaKasir = New System.Windows.Forms.Label()
        Me.LblTotalHarga = New System.Windows.Forms.Label()
        Me.LblTransaksi = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtDiscount
        '
        Me.TxtDiscount.Location = New System.Drawing.Point(542, 446)
        Me.TxtDiscount.Name = "TxtDiscount"
        Me.TxtDiscount.Size = New System.Drawing.Size(100, 20)
        Me.TxtDiscount.TabIndex = 76
        '
        'LblTotalHargaBersih
        '
        Me.LblTotalHargaBersih.AutoSize = True
        Me.LblTotalHargaBersih.BackColor = System.Drawing.Color.White
        Me.LblTotalHargaBersih.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotalHargaBersih.ForeColor = System.Drawing.Color.Red
        Me.LblTotalHargaBersih.Location = New System.Drawing.Point(539, 473)
        Me.LblTotalHargaBersih.Name = "LblTotalHargaBersih"
        Me.LblTotalHargaBersih.Size = New System.Drawing.Size(26, 15)
        Me.LblTotalHargaBersih.TabIndex = 75
        Me.LblTotalHargaBersih.Text = "Rp,"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.BackColor = System.Drawing.Color.White
        Me.LblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTotal.Location = New System.Drawing.Point(539, 423)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(26, 15)
        Me.LblTotal.TabIndex = 74
        Me.LblTotal.Text = "Rp,"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(437, 473)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Harga Bersih :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(437, 446)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Disc :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(437, 423)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(69, 13)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "Total Harga :"
        '
        'DGTransaksi
        '
        Me.DGTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTransaksi.Location = New System.Drawing.Point(37, 215)
        Me.DGTransaksi.Name = "DGTransaksi"
        Me.DGTransaksi.Size = New System.Drawing.Size(644, 194)
        Me.DGTransaksi.TabIndex = 70
        '
        'TxtJumlah
        '
        Me.TxtJumlah.Location = New System.Drawing.Point(583, 174)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(100, 20)
        Me.TxtJumlah.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(514, 94)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "ID Transaksi"
        '
        'LblNmKasir
        '
        Me.LblNmKasir.AutoSize = True
        Me.LblNmKasir.BackColor = System.Drawing.Color.White
        Me.LblNmKasir.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNmKasir.Location = New System.Drawing.Point(137, 133)
        Me.LblNmKasir.Name = "LblNmKasir"
        Me.LblNmKasir.Size = New System.Drawing.Size(2, 15)
        Me.LblNmKasir.TabIndex = 65
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBatal.Location = New System.Drawing.Point(168, 437)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(57, 53)
        Me.BtnBatal.TabIndex = 64
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnCetak
        '
        Me.BtnCetak.Image = CType(resources.GetObject("BtnCetak.Image"), System.Drawing.Image)
        Me.BtnCetak.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCetak.Location = New System.Drawing.Point(111, 437)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(51, 53)
        Me.BtnCetak.TabIndex = 63
        Me.BtnCetak.Text = "Cetak"
        Me.BtnCetak.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCetak.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSimpan.Location = New System.Drawing.Point(46, 437)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(59, 53)
        Me.BtnSimpan.TabIndex = 62
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'CmbPaket
        '
        Me.CmbPaket.FormattingEnabled = True
        Me.CmbPaket.Location = New System.Drawing.Point(121, 171)
        Me.CmbPaket.Name = "CmbPaket"
        Me.CmbPaket.Size = New System.Drawing.Size(121, 21)
        Me.CmbPaket.TabIndex = 61
        '
        'CmbKasir
        '
        Me.CmbKasir.FormattingEnabled = True
        Me.CmbKasir.Location = New System.Drawing.Point(121, 94)
        Me.CmbKasir.Name = "CmbKasir"
        Me.CmbKasir.Size = New System.Drawing.Size(121, 21)
        Me.CmbKasir.TabIndex = 60
        '
        'LblNamaPaket
        '
        Me.LblNamaPaket.AutoSize = True
        Me.LblNamaPaket.BackColor = System.Drawing.Color.White
        Me.LblNamaPaket.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblNamaPaket.Location = New System.Drawing.Point(323, 174)
        Me.LblNamaPaket.Name = "LblNamaPaket"
        Me.LblNamaPaket.Size = New System.Drawing.Size(44, 15)
        Me.LblNamaPaket.TabIndex = 59
        Me.LblNamaPaket.Text = "Label 7"
        '
        'LblHarga
        '
        Me.LblHarga.AutoSize = True
        Me.LblHarga.BackColor = System.Drawing.Color.White
        Me.LblHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblHarga.Location = New System.Drawing.Point(469, 174)
        Me.LblHarga.Name = "LblHarga"
        Me.LblHarga.Size = New System.Drawing.Size(44, 15)
        Me.LblHarga.TabIndex = 58
        Me.LblHarga.Text = "Label 8"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "ID Paket"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Nama Kasir"
        '
        'LblNamaKasir
        '
        Me.LblNamaKasir.AutoSize = True
        Me.LblNamaKasir.Location = New System.Drawing.Point(36, 97)
        Me.LblNamaKasir.Name = "LblNamaKasir"
        Me.LblNamaKasir.Size = New System.Drawing.Size(44, 13)
        Me.LblNamaKasir.TabIndex = 54
        Me.LblNamaKasir.Text = "ID Kasir"
        '
        'LblTotalHarga
        '
        Me.LblTotalHarga.AutoSize = True
        Me.LblTotalHarga.BackColor = System.Drawing.Color.Black
        Me.LblTotalHarga.ForeColor = System.Drawing.Color.White
        Me.LblTotalHarga.Location = New System.Drawing.Point(627, 133)
        Me.LblTotalHarga.Name = "LblTotalHarga"
        Me.LblTotalHarga.Size = New System.Drawing.Size(48, 13)
        Me.LblTotalHarga.TabIndex = 68
        Me.LblTotalHarga.Text = "Label 15"
        '
        'LblTransaksi
        '
        Me.LblTransaksi.AutoSize = True
        Me.LblTransaksi.BackColor = System.Drawing.Color.Yellow
        Me.LblTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblTransaksi.Location = New System.Drawing.Point(630, 92)
        Me.LblTransaksi.Name = "LblTransaksi"
        Me.LblTransaksi.Size = New System.Drawing.Size(44, 15)
        Me.LblTransaksi.TabIndex = 77
        Me.LblTransaksi.Text = "Label 6"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(18, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 78
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(289, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 24)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "TRANSAKSI"
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(713, 521)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblTransaksi)
        Me.Controls.Add(Me.TxtDiscount)
        Me.Controls.Add(Me.LblTotalHargaBersih)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DGTransaksi)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.LblTotalHarga)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LblNmKasir)
        Me.Controls.Add(Me.BtnBatal)
        Me.Controls.Add(Me.BtnCetak)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.CmbPaket)
        Me.Controls.Add(Me.CmbKasir)
        Me.Controls.Add(Me.LblNamaPaket)
        Me.Controls.Add(Me.LblHarga)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblNamaKasir)
        Me.Name = "FormTransaksi"
        Me.Text = "FormTransaksi"
        CType(Me.DGTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtDiscount As TextBox
    Friend WithEvents LblTotalHargaBersih As Label
    Friend WithEvents LblTotal As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DGTransaksi As DataGridView
    Friend WithEvents TxtJumlah As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LblNmKasir As Label
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnCetak As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents CmbPaket As ComboBox
    Friend WithEvents CmbKasir As ComboBox
    Friend WithEvents LblNamaPaket As Label
    Friend WithEvents LblHarga As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblNamaKasir As Label
    Friend WithEvents LblTotalHarga As Label
    Friend WithEvents LblTransaksi As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
