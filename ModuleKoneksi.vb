Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Windows.Forms

Module ModuleKoneksi

    Public conn As MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader

    '===============================
    ' KONEKSI DATABASE
    '===============================
    Public Sub Koneksi()
        Try
            If conn Is Nothing Then
                conn = New MySqlConnection(
                    "server=localhost;user id=root;password=;database=inventory;"
                )
            End If

            If conn.State <> ConnectionState.Open Then
                conn.Open()
            End If

        Catch ex As Exception
            MessageBox.Show(
                "Koneksi gagal: " & ex.Message,
                "ERROR",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

    '===============================
    ' EXEC SCALAR (UNTUK LABEL ANGKA)
    '===============================
    Public Function ExecScalar(ByVal query As String) As Integer
        Try
            cmd = New MySqlCommand(query, conn)
            Dim hasil As Object = cmd.ExecuteScalar()

            If hasil Is Nothing OrElse IsDBNull(hasil) Then
                Return 0
            End If

            Return Convert.ToInt32(hasil)

        Catch ex As Exception
            MessageBox.Show(
                "Query error: " & ex.Message,
                "ERROR",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
            Return 0
        End Try
    End Function

    '===============================
    ' LOAD DATA KE DATAGRIDVIEW
    '===============================
    Public Sub LoadGrid(ByVal dg As DataGridView, ByVal query As String)
        Try
            da = New MySqlDataAdapter(query, conn)
            ds = New DataSet
            da.Fill(ds)
            dg.DataSource = ds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(
                "Load data gagal: " & ex.Message,
                "ERROR",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try
    End Sub

End Module
