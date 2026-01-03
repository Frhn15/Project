Imports MySql.Data.MySqlClient

Public Class FormStokBarang

    Dim da As MySqlDataAdapter
    Dim dt As DataTable

    ' ================= TAMPIL SEMUA DATA =================
    Sub TampilSemua()
        Try
            Call Koneksi()

            Dim sql As String = "
                SELECT 
                    b.kode_barang,
                    b.nama_barang,
                    b.satuan,
                    k.nama_kategori,
                    b.lokasi,
                    b.stok_min AS stok
                FROM barang b
                JOIN kategori k ON b.id_kategori = k.id
                ORDER BY b.nama_barang
            "

            da = New MySqlDataAdapter(sql, conn)
            dt = New DataTable
            da.Fill(dt)

            dgvStokBarang.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Tampil Data",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ================= FORM LOAD =================
    Private Sub FormStokBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        TampilSemua()

        With dgvStokBarang
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AllowUserToAddRows = False
            .ReadOnly = True
        End With
    End Sub

    ' ================= CARI DATA =================
    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Try
            Call Koneksi()

            Dim sql As String = "
                SELECT 
                    b.kode_barang,
                    b.nama_barang,
                    b.satuan,
                    k.nama_kategori,
                    b.lokasi,
                    b.stok_min AS stok
                FROM barang b
                JOIN kategori k ON b.id_kategori = k.id
                WHERE 
                    b.kode_barang LIKE @kode
                    AND b.nama_barang LIKE @nama
                    AND b.satuan LIKE @satuan
                    AND b.lokasi LIKE @lokasi
                ORDER BY b.nama_barang
            "

            da = New MySqlDataAdapter(sql, conn)
            da.SelectCommand.Parameters.AddWithValue("@kode", "%" & txtKode.Text & "%")
            da.SelectCommand.Parameters.AddWithValue("@nama", "%" & txtNama.Text & "%")
            da.SelectCommand.Parameters.AddWithValue("@satuan", "%" & txtSize.Text & "%")
            da.SelectCommand.Parameters.AddWithValue("@lokasi", "%" & txtLokasi.Text & "%")

            dt = New DataTable
            da.Fill(dt)

            dgvStokBarang.DataSource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Cari Data",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ================= KELUAR =================
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class
