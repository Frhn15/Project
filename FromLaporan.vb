Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FromLaporan

    Private Sub FromLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()

        ' isi jenis laporan
        cmbJenisLaporan.Items.Clear()
        cmbJenisLaporan.Items.AddRange(New Object() {
            "Barang Masuk",
            "Barang Keluar",
            "Transfer Gudang",
            "Stock Opname",
            "Stok Gudang"
        })
        cmbJenisLaporan.SelectedIndex = 0

        ' setting grid
        dgLaporan.AllowUserToAddRows = False
        dgLaporan.ReadOnly = True
        dgLaporan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgLaporan.MultiSelect = False
        dgLaporan.AutoGenerateColumns = True

        LoadFilterGudang() ' kalau memang butuh filter gudang
    End Sub

    Private Sub LoadFilterGudang()
        Dim dt As New DataTable()
        Using da As New MySqlDataAdapter("SELECT id, CONCAT(kode_gudang,' - ',nama_gudang) AS nama FROM gudang ORDER BY nama_gudang", conn)
            da.Fill(dt)
        End Using

        Dim r As DataRow = dt.NewRow()
        r("id") = 0
        r("nama") = "Semua Gudang"
        dt.Rows.InsertAt(r, 0)

    End Sub

    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        Dim jenis = cmbJenisLaporan.Text
        Select Case jenis
            Case "Barang Masuk"
                TampilBarangMasuk()
            Case "Barang Keluar"
                TampilBarangKeluar()
            Case "Transfer Gudang"
                TampilTransferGudang()
            Case "Stock Opname"
                TampilStockOpname()
            Case "Stok Gudang"
                TampilStokGudang()
        End Select
    End Sub

    ' =========================
    ' LAPORAN: BARANG MASUK + DETAIL
    ' =========================
    Private Sub TampilBarangMasuk()
        Dim dt As New DataTable()
        Dim keyword As String = "%" & txtCari.Text.Trim() & "%"

        ' GANTI nama kolom tanggal sesuai tabelmu (mis: bm.tanggal)
        Using cmd As New MySqlCommand("
            SELECT
                bm.id,
                bm.no_dokumen,
                bm.tanggal,
                g.nama_gudang,
                b.kode_barang,
                b.nama_barang,
                d.qty
            FROM barang_masuk bm
            INNER JOIN barang_masuk_detail d ON d.id_barang_masuk = bm.id
            INNER JOIN barang b ON b.id = d.id_barang
            LEFT JOIN gudang g ON g.id = bm.id_gudang
            WHERE
                bm.tanggal BETWEEN @dari AND @sampai
                AND (@gid = 0 OR bm.id_gudang = @gid)
                AND (bm.no_dokumen LIKE @cari OR b.kode_barang LIKE @cari OR b.nama_barang LIKE @cari)
            ORDER BY bm.tanggal DESC, bm.no_dokumen
        ", conn)

            cmd.Parameters.AddWithValue("@dari", dtDari.Value.Date)
            cmd.Parameters.AddWithValue("@sampai", dtSampai.Value.Date)
            cmd.Parameters.AddWithValue("@cari", keyword)

            Using da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        dgLaporan.DataSource = dt
    End Sub

    ' =========================
    ' LAPORAN: BARANG KELUAR + DETAIL
    ' =========================
    Private Sub TampilBarangKeluar()
        Dim dt As New DataTable()
        ' isi query join barang_keluar + detail + barang (mirip barang_masuk)
        dgLaporan.DataSource = dt
    End Sub

    ' =========================
    ' LAPORAN: TRANSFER GUDANG
    ' =========================
    Private Sub TampilTransferGudang()
        Dim dt As New DataTable()
        dgLaporan.DataSource = dt
    End Sub

    ' =========================
    ' LAPORAN: STOCK OPNAME
    ' =========================
    Private Sub TampilStockOpname()
        Dim dt As New DataTable()
        dgLaporan.DataSource = dt
    End Sub

    ' =========================
    ' LAPORAN: STOK GUDANG
    ' =========================
    Private Sub TampilStokGudang()
        Dim dt As New DataTable()
        dgLaporan.DataSource = dt
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class
