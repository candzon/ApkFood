Public Class FormPaketMakanan
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tblpaket_makanan As DataTable
    Sub Data_Record()
        tblpaket_makanan = Proses.ExecuteQuery("Select * From TblPaketMakanan order by id_paket asc")
        DGMakanan.DataSource = tblpaket_makanan
        DGMakanan.Columns(1).Width = 150
        DGMakanan.Columns(2).Width = 435
    End Sub
    Sub Bersih()
        Call Data_Record()
        btnInput.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        txtIdPaketMakanan.Enabled = False
        txtKeteranganPaketMakanan.Enabled = False
        txtHargaPaketMakanan.Enabled = False
        txtNamaPaketMakanan.Text = ""
        txtNamaPaketMakanan.Focus()
    End Sub
    Private Sub DGMakanan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMakanan.CellContentClick
        Dim i As Integer
        With DGMakanan
            If e.RowIndex >= 0 Then
                i = .CurrentRow.Index
                txtIdPaketMakanan.Text = .Rows(i).Cells("id_paket").Value.ToString
                txtNamaPaketMakanan.Text = .Rows(i).Cells("nama_paket").Value.ToString
                txtKeteranganPaketMakanan.Text = .Rows(i).Cells("keterangan").Value.ToString
                txtHargaPaketMakanan.Text = .Rows(i).Cells("harga").Value.ToString
                btnEdit.Enabled = True
                btnDelete.Enabled = True
                btnInput.Enabled = True
            End If
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FormLogin.Close()
    End Sub
    Private Sub FormPaketMakanan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
    End Sub
    Private Sub btnBuka_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuka.Click
        txtIdPaketMakanan.Enabled = True
        txtNamaPaketMakanan.Enabled = True
        txtKeteranganPaketMakanan.Enabled = True
        txtHargaPaketMakanan.Enabled = True
        btnInput.Enabled = True
        btnEdit.Enabled = True
        btnDelete.Enabled = True
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        If txtIdPaketMakanan.Text = "" Then
            txtIdPaketMakanan.Focus()
            Exit Sub
        End If
        If txtNamaPaketMakanan.Text = "" Then
            txtNamaPaketMakanan.Focus()
            Exit Sub
        End If
        If txtKeteranganPaketMakanan.Text = "" Then
            txtKeteranganPaketMakanan.Focus()
            Exit Sub
        End If
        If txtHargaPaketMakanan.Text = "" Then
            txtHargaPaketMakanan.Focus()
            Exit Sub
        End If
        SQL = "Insert Into TblPaketMakanan values ('" & txtIdPaketMakanan.Text & "','" & txtNamaPaketMakanan.Text & "','" & txtKeteranganPaketMakanan.Text & "','" & txtHargaPaketMakanan.Text & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If txtIdPaketMakanan.Text = "" Then
            txtIdPaketMakanan.Focus()
            Exit Sub
        End If
        If txtNamaPaketMakanan.Text = "" Then
            txtNamaPaketMakanan.Focus()
            Exit Sub
        End If
        If txtKeteranganPaketMakanan.Text = "" Then
            txtKeteranganPaketMakanan.Focus()
            Exit Sub
        End If
        If txtHargaPaketMakanan.Text = "" Then
            txtHargaPaketMakanan.Focus()
            Exit Sub
        End If
        SQL = "Update TblPaketMakanan set nama_paket = '" & txtNamaPaketMakanan.Text & "',keterangan = '" & txtKeteranganPaketMakanan.Text & "',harga = '" & txtHargaPaketMakanan.Text & "'
 Where id_paket = '" & txtIdPaketMakanan.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Berhasil dirubah..!!", "Perubahan Data Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        SQL = "Delete From paket_makanan Where id_paket = '" & txtIdPaketMakanan.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data telah dihapus..!!", "Penghapusan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class