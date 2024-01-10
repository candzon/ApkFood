<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPaketMakanan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPaketMakanan))
        Me.txtHargaPaketMakanan = New System.Windows.Forms.TextBox()
        Me.txtNamaPaketMakanan = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnBuka = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.txtKeteranganPaketMakanan = New System.Windows.Forms.RichTextBox()
        Me.txtIdPaketMakanan = New System.Windows.Forms.TextBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.lblHarga = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblIdPaket = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGMakanan = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DGMakanan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtHargaPaketMakanan
        '
        Me.txtHargaPaketMakanan.Location = New System.Drawing.Point(168, 236)
        Me.txtHargaPaketMakanan.Name = "txtHargaPaketMakanan"
        Me.txtHargaPaketMakanan.Size = New System.Drawing.Size(198, 20)
        Me.txtHargaPaketMakanan.TabIndex = 25
        '
        'txtNamaPaketMakanan
        '
        Me.txtNamaPaketMakanan.Location = New System.Drawing.Point(167, 125)
        Me.txtNamaPaketMakanan.Name = "txtNamaPaketMakanan"
        Me.txtNamaPaketMakanan.Size = New System.Drawing.Size(199, 20)
        Me.txtNamaPaketMakanan.TabIndex = 24
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(211, 272)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 20
        Me.btnDelete.Text = "Hapus"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(130, 272)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 21
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnBuka
        '
        Me.btnBuka.Location = New System.Drawing.Point(292, 272)
        Me.btnBuka.Name = "btnBuka"
        Me.btnBuka.Size = New System.Drawing.Size(75, 23)
        Me.btnBuka.TabIndex = 22
        Me.btnBuka.Text = "Buka"
        Me.btnBuka.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(49, 272)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 23
        Me.btnInput.Text = "Simpan"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'txtKeteranganPaketMakanan
        '
        Me.txtKeteranganPaketMakanan.Location = New System.Drawing.Point(167, 154)
        Me.txtKeteranganPaketMakanan.Name = "txtKeteranganPaketMakanan"
        Me.txtKeteranganPaketMakanan.Size = New System.Drawing.Size(199, 60)
        Me.txtKeteranganPaketMakanan.TabIndex = 18
        Me.txtKeteranganPaketMakanan.Text = ""
        '
        'txtIdPaketMakanan
        '
        Me.txtIdPaketMakanan.Location = New System.Drawing.Point(166, 91)
        Me.txtIdPaketMakanan.Name = "txtIdPaketMakanan"
        Me.txtIdPaketMakanan.Size = New System.Drawing.Size(199, 20)
        Me.txtIdPaketMakanan.TabIndex = 17
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Location = New System.Drawing.Point(48, 154)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(62, 13)
        Me.lblKeterangan.TabIndex = 13
        Me.lblKeterangan.Text = "Keterangan"
        '
        'lblHarga
        '
        Me.lblHarga.AutoSize = True
        Me.lblHarga.Location = New System.Drawing.Point(49, 239)
        Me.lblHarga.Name = "lblHarga"
        Me.lblHarga.Size = New System.Drawing.Size(36, 13)
        Me.lblHarga.TabIndex = 14
        Me.lblHarga.Text = "Harga"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(47, 128)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(66, 13)
        Me.lblNama.TabIndex = 15
        Me.lblNama.Text = "Nama Paket"
        '
        'lblIdPaket
        '
        Me.lblIdPaket.AutoSize = True
        Me.lblIdPaket.Location = New System.Drawing.Point(49, 98)
        Me.lblIdPaket.Name = "lblIdPaket"
        Me.lblIdPaket.Size = New System.Drawing.Size(49, 13)
        Me.lblIdPaket.TabIndex = 16
        Me.lblIdPaket.Text = "ID Paket"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Form Paket Makanan"
        '
        'DGMakanan
        '
        Me.DGMakanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGMakanan.Location = New System.Drawing.Point(49, 318)
        Me.DGMakanan.Name = "DGMakanan"
        Me.DGMakanan.Size = New System.Drawing.Size(365, 134)
        Me.DGMakanan.TabIndex = 26
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(62, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'FormPaketMakanan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(443, 502)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DGMakanan)
        Me.Controls.Add(Me.txtHargaPaketMakanan)
        Me.Controls.Add(Me.txtNamaPaketMakanan)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnBuka)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.txtKeteranganPaketMakanan)
        Me.Controls.Add(Me.txtIdPaketMakanan)
        Me.Controls.Add(Me.lblKeterangan)
        Me.Controls.Add(Me.lblHarga)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblIdPaket)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormPaketMakanan"
        Me.Text = "FormPaketMakanan"
        CType(Me.DGMakanan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtHargaPaketMakanan As TextBox
    Friend WithEvents txtNamaPaketMakanan As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnBuka As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents txtKeteranganPaketMakanan As RichTextBox
    Friend WithEvents txtIdPaketMakanan As TextBox
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblIdPaket As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGMakanan As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
