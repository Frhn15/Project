Imports MySql.Data.MySqlClient

Public Class FormStokBarang

    Sub TampilSemua()
        Call Koneksi()

        da = New MySqlDataAdapter("SELECT * FROM stok_barang", conn)
        ds = New DataSet
        da.Fill(ds, "stok_barang")
        dgvStokBarang.DataSource = ds.Tables("stok_barang")
    End Sub
    Private Sub FormStokBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BackgroundImageLayout = ImageLayout.Stretch
        TampilSemua()
        dgvStokBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvStokBarang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvStokBarang.RowTemplate.Height = 30

        dgvStokBarang.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvStokBarang.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvStokBarang.AllowUserToAddRows = False


    End Sub


    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click

        Call Koneksi()

        Dim sql As String = "SELECT * FROM stok_barang 
                         WHERE (kode_barang LIKE @kode OR @kode = '') 
                         AND (nama_barang LIKE @nama OR @nama = '') 
                         AND (size LIKE @size OR @size = '') 
                         AND (lokasi LIKE @lokasi OR @lokasi = '')"

        da = New MySqlDataAdapter(sql, conn)

        da.SelectCommand.Parameters.AddWithValue("@kode", "%" & txtKode.Text & "%")
        da.SelectCommand.Parameters.AddWithValue("@nama", "%" & txtNama.Text & "%")
        da.SelectCommand.Parameters.AddWithValue("@size", "%" & txtSize.Text & "%")
        da.SelectCommand.Parameters.AddWithValue("@lokasi", "%" & txtLokasi.Text & "%")

        ds = New DataSet
        da.Fill(ds, "stok_barang")

        dgvStokBarang.DataSource = ds.Tables("stok_barang")

    End Sub
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class
