Imports MySql.Data.MySqlClient

Public Class FormTransaksiMasuk
    Private Sub btnInput_Click(sender As Object, e As EventArgs)
        dgvInput.Rows.Add(
        txtKodeBarang.Text,
        txtNamaBarang.Text,
        txtQty.Text,
        dtTglMasuk.Value.ToString("yyyy-MM-dd"),
        cboKategori.Text,
        txtSize.Text,
        txtLokasi.Text
    )

        txtKodeBarang.Clear
        txtNamaBarang.Clear
        txtQty.Clear
        txtSize.Clear
        txtLokasi.Clear
        cboKategori.SelectedIndex = -1
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs)
        If dgvInput.CurrentRow IsNot Nothing Then
            dgvInput.Rows.Remove(dgvInput.CurrentRow)
        End If
    End Sub

    Private Sub btnKonfirmasi_Click(sender As Object, e As EventArgs)
        Koneksi

        For i = 0 To dgvInput.Rows.Count - 1

            Dim row = dgvInput.Rows(i)

            ' ➤ LEWATI BARIS KOSONG PALING BAWAH
            If row.IsNewRow Then Continue For

            Dim kode = row.Cells("kode_barang").Value?.ToString.Trim
            Dim nama = row.Cells("nama_barang").Value?.ToString.Trim
            Dim qtyValue = row.Cells("qty").Value
            Dim tgl = row.Cells("tgl_masuk").Value?.ToString.Trim
            Dim kategori = row.Cells("kategori").Value?.ToString.Trim
            Dim size = row.Cells("size").Value?.ToString.Trim
            Dim lokasi = row.Cells("lokasi").Value?.ToString.Trim

            ' ➤ VALIDASI WAJIB DIISI
            If String.IsNullOrEmpty(kode) Then
                MsgBox("Kode barang kosong di baris " & i + 1)
                Exit Sub
            End If

            If qtyValue Is Nothing Or qtyValue.ToString = "" Then
                MsgBox("Qty kosong di baris " & i + 1)
                Exit Sub
            End If

            Dim qty = Convert.ToInt32(qtyValue)


            ' ➤ CEK APAKAH BARANG SUDAH ADA DI DATABASE
            Dim cekCmd As New MySqlCommand("SELECT COUNT(*) FROM stok_barang WHERE kode_barang=@kode", conn)
            cekCmd.Parameters.AddWithValue("@kode", kode)
            Dim ada As Integer = cekCmd.ExecuteScalar


            ' ==========================================================
            '   UPDATE STOK JIKA BARANG SUDAH ADA
            ' ==========================================================
            If ada > 0 Then

                Dim updateStok As New MySqlCommand("
                UPDATE stok_barang 
                SET jumlah = jumlah + @qty,
                    tgl_update = CURDATE()
                WHERE kode_barang = @kode
            ", conn)

                updateStok.Parameters.AddWithValue("@qty", qty)
                updateStok.Parameters.AddWithValue("@kode", kode)
                updateStok.ExecuteNonQuery

            Else

                ' ==========================================================
                '   INSERT BARU JIKA BELUM ADA
                ' ==========================================================
                Dim insertStok As New MySqlCommand("
                INSERT INTO stok_barang 
                (kode_barang, nama_barang, kategori, size, lokasi, jumlah, tgl_update)
                VALUES (@kode, @nama, @kategori, @size, @lokasi, @qty, CURDATE())
            ", conn)

                insertStok.Parameters.AddWithValue("@kode", kode)
                insertStok.Parameters.AddWithValue("@nama", nama)
                insertStok.Parameters.AddWithValue("@kategori", kategori)
                insertStok.Parameters.AddWithValue("@size", size)
                insertStok.Parameters.AddWithValue("@lokasi", lokasi)
                insertStok.Parameters.AddWithValue("@qty", qty)

                insertStok.ExecuteNonQuery
            End If

        Next

        MsgBox("Data berhasil ditambahkan ke stok barang!", vbInformation)

        dgvInput.Rows.Clear
    End Sub


    Private Sub btnKembali_Click(sender As Object, e As EventArgs)
        Form1.Show
        Hide
    End Sub

    Private Sub FormTransaksiMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class