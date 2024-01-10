Public Class FormTransaksi
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim transaksi As DataTable
    Sub Data_Record()
        transaksi = Proses.ExecuteQuery("Select TblTransaksi_Detail.no, TblTransaksi_Detail.id_paket,TblPaketMakanan.nama_paket,
TblTransaksi_Detail.harga_jual,TblTransaksi_Detail.jumlah, TblTransaksi_Detail.sub_total From TblTransaksi_Detail Inner Join TblPaketMakanan on
TblTransaksi_Detail.id_paket = TblPaketMakanan.id_paket Where TblTransaksi_Detail.id_transaksi = '" & LblTransaksi.Text & "' order by TblTransaksi_Detail.no
asc")
        DGTransaksi.DataSource = transaksi
        DGTransaksi.Columns(0).Width = 50
        DGTransaksi.Columns(1).Width = 98
        DGTransaksi.Columns(2).Width = 150
        DGTransaksi.Columns(4).Width = 50
    End Sub
    Sub Kasir()
        transaksi = Proses.ExecuteQuery("Select * From TblKasir order by id_kasir asc")
        If transaksi.Rows.Count = 0 Then
        Else
            CmbKasir.Items.Clear()
            With transaksi.Columns(1)
                For a = 0 To transaksi.Rows.Count - 1
                    CmbKasir.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub
    Sub Paket()
        transaksi = Proses.ExecuteQuery("Select * From TblPaketMakanan order by id_paket asc")
        If transaksi.Rows.Count = 0 Then
        Else
            CmbPaket.Items.Clear()
            With transaksi.Columns(1)
                For a = 0 To transaksi.Rows.Count - 1
                    CmbPaket.Items.Add("" & .Table.Rows(a).Item(0) & " - " & .Table.Rows(a).Item(1) & "")
                Next a
            End With
        End If
    End Sub
    Sub Faktur_Otomatis()
        transaksi = Proses.ExecuteQuery("Select * From TblTransaksi order by id_transaksi desc")
        If transaksi.Rows.Count = 0 Then
            LblTransaksi.Text = "0001"
        Else
            With transaksi.Rows(0)
                LblTransaksi.Text = .Item("id_transaksi")
            End With
            LblTransaksi.Text = Val(LblTransaksi.Text) + 1
            If Len(LblTransaksi.Text) = 1 Then
                LblTransaksi.Text = "000" & LblTransaksi.Text & ""
            ElseIf Len(LblTransaksi.Text) = 2 Then
                LblTransaksi.Text = "00" & LblTransaksi.Text & ""
            ElseIf Len(LblTransaksi.Text) = 3 Then
                LblTransaksi.Text = "0" & LblTransaksi.Text & ""
            ElseIf Len(LblTransaksi.Text) = 4 Then
                LblTransaksi.Text = "" & LblTransaksi.Text & ""
            End If
        End If
    End Sub
    Sub Bersih()
        CmbPaket.Text = ""
        LblNamaPaket.Text = ""
        LblHarga.Text = ""
        TxtJumlah.Text = ""
        TxtDiscount.Text = ""
        LblTotalHargaBersih.Text = ""
        LblTotalHarga.Text = ""
        CmbKasir.Enabled = True
        CmbPaket.Enabled = True
        CmbPaket.Focus()
        Call Kasir()
        Call Paket()
        Call Faktur_Otomatis()
        Call Data_Record()
        On Error Resume Next
        Dim Total_Seluruh As Single
        Dim i As Integer
        If DGTransaksi.RowCount > 1 Then
            i = DGTransaksi.CurrentRow.Index
            For i = 0 To DGTransaksi.Rows.Count - 1
                Total_Seluruh = Val(Total_Seluruh) + Val(DGTransaksi.Item(5, i).Value)
            Next
            LblTotal.Text = Total_Seluruh.ToString("#,#")
            LblTotalHarga.Text = LblTotal.Text
        End If
    End Sub

    Private Sub FormTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Bersih()
        BtnSimpan.Enabled = True
    End Sub
    Private Sub CmbKasir_TextChanged(sender As Object, e As EventArgs) Handles CmbKasir.TextChanged
        transaksi = Proses.ExecuteQuery("Select * From TblKasir where id_kasir ='" & Mid(CmbKasir.Text, 1, 6) & "'")
        If transaksi.Rows.Count = 0 Then
        Else
            LblNmKasir.Text = transaksi.Rows(0).Item("nama_kasir")
        End If
    End Sub
    Private Sub CmbKasir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbKasir.KeyPress
        e.KeyChar = Chr(0)
    End Sub
    Private Sub CmbPaket_TextChanged(sender As Object, e As EventArgs) Handles CmbPaket.TextChanged
        transaksi = Proses.ExecuteQuery("Select * From TblPaketMakanan where id_paket ='" & Mid(CmbPaket.Text, 1, 6) & "'")
        If transaksi.Rows.Count = 0 Then
        Else
            LblNamaPaket.Text = transaksi.Rows(0).Item("nama_paket")
            LblHarga.Text = transaksi.Rows(0).Item("harga")

            TxtJumlah.Focus()
        End If
    End Sub
    Private Sub CmbPaket_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbPaket.KeyPress
        e.KeyChar = Chr(0)
    End Sub
    Private Sub TxtJumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtJumlah.KeyPress
        Select Case e.KeyChar
            Case Chr(47) To Chr(57)
                TxtJumlah.Focus()
            Case Chr(8)
                e.KeyChar = Chr(8)
            Case Chr(13)
                transaksi = Proses.ExecuteQuery("Select * From TblTransaksi_Detail where id_transaksi ='" & LblTransaksi.Text & "' and id_paket ='" &
                Mid(CmbPaket.Text, 1, 6) & "'")
                If transaksi.Rows.Count = 0 Then
                    Dim Total = Val(LblHarga.Text) * Val(TxtJumlah.Text)
                    SQL = "Insert Into TblTransaksi_Detail values ('" & LblTransaksi.Text & "','" & DGTransaksi.RowCount & "','" & Mid(CmbPaket.Text, 1, 6) & "','" &
                    Val(LblHarga.Text) & "','" & TxtJumlah.Text & "','" & Total & "')"
                    Proses.ExecuteNonQuery(SQL)
                    BtnSimpan.Enabled = True
                Else
                    MsgBox("Proses Penjualan tidak dapat dilakukan !")
                End If
                Call Bersih()
                Dim Total_Seluruh As Single
                Dim i As Integer
                i = DGTransaksi.CurrentRow.Index
                For i = 0 To DGTransaksi.Rows.Count - 1
                    Total_Seluruh = Val(Total_Seluruh) + Val(DGTransaksi.Item(5, i).Value)
                Next
                LblTotal.Text = Total_Seluruh.ToString("#,#")
                LblTotalHarga.Text = LblTotal.Text
            Case Else
                e.KeyChar = Chr(0)
        End Select
    End Sub
    Private Sub TxtDiscount_TextChanged(sender As Object, e As EventArgs) Handles TxtDiscount.TextChanged
        If TxtDiscount.Text = "" Then
            TxtDiscount.Text = "0"
        End If
        Dim Disc As Single
        Disc = (Val(Replace(LblTotal.Text, ".", "")) * Val(TxtDiscount.Text)) / 100
        LblTotalHargaBersih.Text = (Val(Replace(LblTotal.Text, ".", "")) - Val(Disc)).ToString("#,#")
    End Sub
    Private Sub LblTotalHargaBersih_Click(sender As Object, e As EventArgs) Handles LblTotalHargaBersih.Click
        If LblTotalHargaBersih.Text = "" Then
            LblTotalHargaBersih.Text = "0"
        End If
    End Sub
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If LblTotal.Text = "" Then
            Exit Sub
        End If
        If TxtDiscount.Text = "" Then
            TxtDiscount.Text = "0"
        End If
        SQL = "Insert Into TblTransaksi values ('" & LblTransaksi.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" &
Microsoft.VisualBasic.Left(CmbKasir.Text, 6) & "','" & TxtDiscount.Text & "','" & Replace(LblTotalHargaBersih.Text, ".", "") & "')"
        Proses.ExecuteNonQuery(SQL)
        MessageBox.Show("Data Baru telah disimpan..!!", "Penyimpanan Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call Bersih()
        CmbKasir.Text = ""
        LblNmKasir.Text = ""
        LblTotal.Text = ""
        CmbKasir.Focus()
    End Sub
    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        On Error GoTo Keluar
        Dim i As Integer
        i = DGTransaksi.CurrentRow.Index
        For i = 0 To DGTransaksi.Rows.Count - 1
            transaksi = Proses.ExecuteQuery("Select * From TblPaketMakanan where id_paket ='" & DGTransaksi.Item(2, i).Value & "'")
            If transaksi.Rows.Count = 0 Then
            Else
                Dim Jumlah = Val(transaksi.Rows(0).Item("Stock")) - Val(DGTransaksi.Item(4, i).Value)
                SQL = "Update TblPaketMakanan set Stock ='" & CInt(Jumlah) & "' where id_paket ='" & DGTransaksi.Item(2, i).Value & "'"
                Proses.ExecuteNonQuery(SQL)
            End If
        Next
        SQL = "Delete From TblTransaksi_Detail where id_transaksi ='" & LblTransaksi.Text & "'"
        Proses.ExecuteNonQuery(SQL)
        LblTotal.Text = "Rp,"
        Call Bersih()
Keluar:
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub BtnCetak_Click(sender As Object, e As EventArgs) Handles BtnCetak.Click
        Dim No = InputBox("Masukkan no id_transaksi")
        If No = "" Then
            Exit Sub
        Else
            FrmPenjualan.CrystalReportViewer1.SelectionFormula = "{VwTransaksi.id_transaksi} Like '" + No + "'"
            FrmPenjualan.CrystalReportViewer1.RefreshReport()
            FrmPenjualan.Show()
        End If
    End Sub
End Class