Imports MySql.Data.MySqlClient

Public Class fromMastergudang

    Dim idEdit As Integer = 0

    '================================
    ' FORM LOAD
    '================================
    Private Sub fromMastergudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Call Koneksi()
        LoadGudang()
        ResetForm()
    End Sub

    '================================
    ' LOAD DATA GUDANG KE GRID
    '================================
    Sub LoadGudang()
        LoadGrid(dgGudang, "
            SELECT id, kode_gudang, nama_gudang, lokasi
            FROM gudang
            ORDER BY nama_gudang
        ")
    End Sub

    '================================
    ' RESET FORM
    '================================
    Sub ResetForm()
        txtKodeGudang.Text = ""
        txtNamaGudang.Text = ""
        txtAlamat.Text = ""

        idEdit = 0
        btnSimpan.Enabled = True
        btnEdit.Enabled = False
        btnHapus.Enabled = False
    End Sub

    '================================
    ' SIMPAN DATA
    '================================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKodeGudang.Text = "" Or txtNamaGudang.Text = "" Then
            MsgBox("Kode dan Nama Gudang wajib diisi!", vbExclamation)
            Exit Sub
        End If

        cmd = New MySqlCommand("
            INSERT INTO gudang (kode_gudang, nama_gudang, lokasi)
            VALUES (@kode, @nama, @lokasi)
        ", conn)

        cmd.Parameters.AddWithValue("@kode", txtKodeGudang.Text)
        cmd.Parameters.AddWithValue("@nama", txtNamaGudang.Text)
        cmd.Parameters.AddWithValue("@lokasi", txtAlamat.Text)

        cmd.ExecuteNonQuery()

        MsgBox("Gudang berhasil disimpan", vbInformation)
        LoadGudang()
        ResetForm()
    End Sub

    '================================
    ' KLIK DATA GRID
    '================================
    Private Sub dgGudang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgGudang.CellClick
        If e.RowIndex < 0 Then Exit Sub

        idEdit = dgGudang.Rows(e.RowIndex).Cells("id").Value
        txtKodeGudang.Text = dgGudang.Rows(e.RowIndex).Cells("kode_gudang").Value
        txtNamaGudang.Text = dgGudang.Rows(e.RowIndex).Cells("nama_gudang").Value
        txtAlamat.Text = dgGudang.Rows(e.RowIndex).Cells("lokasi").Value

        btnSimpan.Enabled = False
        btnEdit.Enabled = True
        btnHapus.Enabled = True
    End Sub

    '================================
    ' EDIT DATA
    '================================
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If idEdit = 0 Then Exit Sub

        cmd = New MySqlCommand("
            UPDATE gudang SET
                kode_gudang=@kode,
                nama_gudang=@nama,
                lokasi=@lokasi
            WHERE id=@id
        ", conn)

        cmd.Parameters.AddWithValue("@kode", txtKodeGudang.Text)
        cmd.Parameters.AddWithValue("@nama", txtNamaGudang.Text)
        cmd.Parameters.AddWithValue("@lokasi", txtAlamat.Text)
        cmd.Parameters.AddWithValue("@id", idEdit)

        cmd.ExecuteNonQuery()

        MsgBox("Gudang berhasil diperbarui", vbInformation)
        LoadGudang()
        ResetForm()
    End Sub

    '================================
    ' HAPUS DATA
    '================================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idEdit = 0 Then Exit Sub

        If MsgBox("Yakin ingin menghapus gudang ini?", vbYesNo + vbQuestion) = vbNo Then Exit Sub

        cmd = New MySqlCommand("DELETE FROM gudang WHERE id=@id", conn)
        cmd.Parameters.AddWithValue("@id", idEdit)
        cmd.ExecuteNonQuery()

        MsgBox("Gudang berhasil dihapus", vbInformation)
        LoadGudang()
        ResetForm()
    End Sub

    '================================
    ' KEMBALI KE DASHBOARD
    '================================
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class
