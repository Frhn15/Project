Imports MySql.Data.MySqlClient

Module ModuleKoneksi

    Public conn As MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader

    Public Sub Koneksi()
        Try
            conn = New MySqlConnection("server=localhost;user id=root;password=;database=inventory;")
            conn.Open() ' <-- WAJIB!
        Catch ex As Exception
            MsgBox("Koneksi gagal: " & ex.Message, vbCritical)
        End Try
    End Sub

End Module
