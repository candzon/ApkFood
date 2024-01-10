Public Class FormDataTransaksi
    Dim SQL As String
    Dim Proses As New ClsKoneksi
    Dim tbldetail As DataTable

    Private Sub FormDataTransaksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;User ID=heni;Password=root;Initial Catalog=DbKasir;Data Source=HENI-TI\SQLEXPRESS"

        Using conn As New OleDb.OleDbConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM TblTransaksi"
                Dim da As New OleDb.OleDbDataAdapter(query, conn)
                Dim ds As New DataSet()

                da.Fill(ds, "Tblkasir")
                DGDataT.DataSource = ds.Tables("Tblkasir")
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Dim connectionString As String = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;User ID=heni;Password=root;Initial Catalog=DbKasir;Data Source=HENI-TI\SQLEXPRESS"

        Using conn As New OleDb.OleDbConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM TblTransaksi"
                Dim da As New OleDb.OleDbDataAdapter(query, conn)
                Dim ds As New DataSet()

                da.Fill(ds, "TblTransaksi")
                DGDataT.DataSource = ds.Tables("TblTransaksi")
            Catch ex As Exception
                MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDataT.CellContentClick

    End Sub
End Class