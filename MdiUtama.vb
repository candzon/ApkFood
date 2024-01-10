Public Class MdiUtama
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tb_role As DataTable
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        FormLogin.txtUsernameLogin.Text = ""
        FormLogin.txtPasswordLogin.Text = ""
        FormDataKasir.Close()
        FormDataTransaksi.Close()
        FormLogin.Close()
        FormPaketMakanan.Close()
        FormTransaksi.Close()
        LoginToolStripMenuItem.Visible = True
        MasterToolStripMenuItem.Visible = False
        TransaksiToolStripMenuItem1.Visible = False
        MakananToolStripMenuItem1.Visible = False
        LogoutToolStripMenuItem.Visible = False
        LaporanToolStripMenuItem.Visible = False
    End Sub
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub MakananToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MakananToolStripMenuItem1.Click
        ' Pastikan form ini adalah form yang telah diatur sebagai IsMdiContainer
        Me.IsMdiContainer = True

        FormPaketMakanan.MdiParent = Me ' Atur FormDataKasir sebagai child dari form induk (container MDI)
        FormPaketMakanan.Show()
        'Me.Hide()
    End Sub
    Private Sub TransaksiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem1.Click
        ' Pastikan form ini adalah form yang telah diatur sebagai IsMdiContainer
        Me.IsMdiContainer = True

        FormTransaksi.MdiParent = Me ' Atur FormDataKasir sebagai child dari form induk (container MDI)
        FormTransaksi.Show()
    End Sub
    Private Sub KasirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KasirToolStripMenuItem.Click
        ' Pastikan form ini adalah form yang telah diatur sebagai IsMdiContainer
        Me.IsMdiContainer = True

        FormDataKasir.MdiParent = Me ' Atur FormDataKasir sebagai child dari form induk (container MDI)
        FormDataKasir.Show()
    End Sub
    Private Sub TransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransaksiToolStripMenuItem.Click
        Me.IsMdiContainer = True

        FormDataTransaksi.MdiParent = Me ' Atur FormDataKasir sebagai child dari form induk (container MDI)
        FormDataTransaksi.Show()
    End Sub
    Private Sub LoginToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.Focus()
        FormLogin.Show()
    End Sub
    Private Sub MdiUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MasterToolStripMenuItem.Visible = False
        TransaksiToolStripMenuItem1.Visible = False
        MakananToolStripMenuItem1.Visible = False
        LogoutToolStripMenuItem.Visible = False
        LaporanToolStripMenuItem.Visible = False
        TsTanggal.Text = Format(Now, "dddd, dd/MM/yyyy")

    End Sub
    Private Sub DataTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FrmLprTransaksi.Show()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormDataTransaksi.MdiParent = Me
        FormDataTransaksi.Show()
        FormDataTransaksi.Focus()
    End Sub

    Private Sub DataPaketMakananToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataPaketMakananToolStripMenuItem.Click
        Me.IsMdiContainer = True

        FrmPaketMakanan.MdiParent = Me ' Atur FormDataKasir sebagai child dari form induk (container MDI)
        FrmPaketMakanan.Show()
    End Sub

    Private Sub DataTransaksiToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DataTransaksiToolStripMenuItem.Click
        Me.IsMdiContainer = True

        FrmLprTransaksi.MdiParent = Me ' Atur FormDataKasir sebagai child dari form induk (container MDI)
        FrmLprTransaksi.Show()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TsJam.Text = Format(Now, "hh:mm:ss")
    End Sub


End Class
