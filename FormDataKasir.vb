Public Class FormDataKasir
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim kasir As DataTable
    Private Sub FormDataKasir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;User ID=heni;Password=root;Initial Catalog=DbKasir;Data Source=HENI-TI\SQLEXPRESS"

        Using conn As New OleDb.OleDbConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM Tblkasir"
                Dim da As New OleDb.OleDbDataAdapter(query, conn)
                Dim ds As New DataSet()

                da.Fill(ds, "Tblkasir")
                DataGridView1.DataSource = ds.Tables("Tblkasir")
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub

End Class