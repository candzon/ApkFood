<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MdiUtama
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdiUtama))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MakananToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaksiToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPaketMakananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TsPengguna = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsLevel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TsJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.MasterToolStripMenuItem, Me.MakananToolStripMenuItem1, Me.TransaksiToolStripMenuItem1, Me.LaporanToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KasirToolStripMenuItem, Me.TransaksiToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'KasirToolStripMenuItem
        '
        Me.KasirToolStripMenuItem.Name = "KasirToolStripMenuItem"
        Me.KasirToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.KasirToolStripMenuItem.Text = "Kasir"
        '
        'TransaksiToolStripMenuItem
        '
        Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(121, 22)
        Me.TransaksiToolStripMenuItem.Text = "Transaksi"
        '
        'MakananToolStripMenuItem1
        '
        Me.MakananToolStripMenuItem1.Name = "MakananToolStripMenuItem1"
        Me.MakananToolStripMenuItem1.Size = New System.Drawing.Size(68, 20)
        Me.MakananToolStripMenuItem1.Text = "Makanan"
        '
        'TransaksiToolStripMenuItem1
        '
        Me.TransaksiToolStripMenuItem1.Name = "TransaksiToolStripMenuItem1"
        Me.TransaksiToolStripMenuItem1.Size = New System.Drawing.Size(66, 20)
        Me.TransaksiToolStripMenuItem1.Text = "Transaksi"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPaketMakananToolStripMenuItem, Me.DataTransaksiToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'DataPaketMakananToolStripMenuItem
        '
        Me.DataPaketMakananToolStripMenuItem.Name = "DataPaketMakananToolStripMenuItem"
        Me.DataPaketMakananToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.DataPaketMakananToolStripMenuItem.Text = "Data Paket Makanan"
        '
        'DataTransaksiToolStripMenuItem
        '
        Me.DataTransaksiToolStripMenuItem.Name = "DataTransaksiToolStripMenuItem"
        Me.DataTransaksiToolStripMenuItem.Size = New System.Drawing.Size(182, 22)
        Me.DataTransaksiToolStripMenuItem.Text = "Data Transaksi"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsPengguna, Me.TsLevel, Me.TsTanggal, Me.TsJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TsPengguna
        '
        Me.TsPengguna.Name = "TsPengguna"
        Me.TsPengguna.Size = New System.Drawing.Size(61, 17)
        Me.TsPengguna.Text = "Pengguna"
        '
        'TsLevel
        '
        Me.TsLevel.Name = "TsLevel"
        Me.TsLevel.Size = New System.Drawing.Size(34, 17)
        Me.TsLevel.Text = "Level"
        '
        'TsTanggal
        '
        Me.TsTanggal.Name = "TsTanggal"
        Me.TsTanggal.Size = New System.Drawing.Size(48, 17)
        Me.TsTanggal.Text = "Tanggal"
        '
        'TsJam
        '
        Me.TsJam.Name = "TsJam"
        Me.TsJam.Size = New System.Drawing.Size(28, 17)
        Me.TsJam.Text = "Jam"
        '
        'MdiUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MdiUtama"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KasirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MakananToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TsPengguna As ToolStripStatusLabel
    Friend WithEvents TsLevel As ToolStripStatusLabel
    Friend WithEvents TsTanggal As ToolStripStatusLabel
    Friend WithEvents TsJam As ToolStripStatusLabel
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataPaketMakananToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataTransaksiToolStripMenuItem As ToolStripMenuItem
End Class
