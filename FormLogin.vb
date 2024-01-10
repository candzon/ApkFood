Public Class FormLogin
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim role As DataTable
    Private Sub cbShowPass_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbShowPassLogin.CheckedChanged
        If cbShowPassLogin.CheckState = CheckState.Checked Then
            txtPasswordLogin.UseSystemPasswordChar = False
        Else
            txtPasswordLogin.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub txtPasswordLogin_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPasswordLogin.TextChanged
        txtPasswordLogin.UseSystemPasswordChar = True
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try
            Dim connectionString As String = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;User ID=heni;Password=root;Initial Catalog=DbKasir;Data Source=HENI-TI\SQLEXPRESS"

            Using conn As New OleDb.OleDbConnection(connectionString)
                conn.Open()
                Dim query As String = "SELECT * FROM TblKasir WHERE username=? AND password=?"
                Dim cmd As New OleDb.OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txtUsernameLogin.Text)
                cmd.Parameters.AddWithValue("@password", txtPasswordLogin.Text)

                Dim reader As OleDb.OleDbDataReader = cmd.ExecuteReader()

                If reader.Read() Then
                    ' Mendapatkan nilai id_role dari hasil query
                    Dim idRole As Integer = Convert.ToInt32(reader("role"))

                    ' Cek id_role untuk menentukan hak akses
                    If idRole = 1 Then
                        ' Kasir
                        Call FormLoginVisible()
                        Me.Hide()
                        MdiUtama.MasterToolStripMenuItem.Visible = True
                        MdiUtama.TransaksiToolStripMenuItem1.Visible = True
                        MdiUtama.MakananToolStripMenuItem1.Visible = True
                        MdiUtama.LogoutToolStripMenuItem.Visible = True
                        MdiUtama.LaporanToolStripMenuItem.Visible = True
                        MdiUtama.LoginToolStripMenuItem.Visible = False
                    ElseIf idRole = 2 Then
                        ' HRD
                        MessageBox.Show("Maaf, Anda bukan kasir. Hak akses terbatas untuk kasir.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                Else
                    reader.Close()
                    MessageBox.Show("Login gagal, Username dan Password salah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPasswordLogin.Text = ""
                    txtUsernameLogin.Text = ""
                    txtUsernameLogin.Focus()
                End If
            End Using
        Catch ex As Exception
            ' Handle exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub FormLoginVisible()
        ' Logika untuk menampilkan form FormLogin
        Dim loginForm As New FormLogin()

    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
