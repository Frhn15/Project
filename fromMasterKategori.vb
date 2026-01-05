Imports MySql.Data.MySqlClient

Public Class fromMasterKategori

    Private idEdit As Integer = 0

    '=================================
    ' FORM LOAD
    '=================================
    Private Sub fromMasterKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BackgroundImageLayout = ImageLayout.Stretch

        Koneksi()
        LoadKategori()
        ResetForm()
    End Sub

    '=================================
    ' LOAD DATA KATEGORI KE GRID
    '=================================
    Sub LoadKategori()
        Try
            LoadGrid(dgKategori, "
                SELECT 
                    id,
                    kode_kategori AS 'Kode Kategori',
                    nama_kategori AS 'Nama Kategori'
                FROM kategori
                ORDER BY nama_kategori
            ")
        Catch ex As Exception
            MsgBox("Load data kategori gagal: " & ex.Message, vbCritical)
        End Try
    End Sub

    '=================================
    ' RESET FORM
    '=================================
    Sub ResetForm()
        txtKodeKategori.Clear()
        txtNamaKategori.Clear()

        idEdit = 0
        btnSimpan.Enabled = True
        btnEdit.Enabled = False
        txtKodeKategori.Focus()
    End Sub

    '=================================
    ' SIMPAN DATA BARU
    '=================================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtKodeKategori.Text.Trim = "" Or txtNamaKategori.Text.Trim = "" Then
            MsgBox("Kode dan Nama kategori wajib diisi!", vbExclamation)
            Exit Sub
        End If

        Try
            cmd = New MySqlCommand("
                INSERT INTO kategori (kode_kategori, nama_kategori)
                VALUES (@kode, @nama)
            ", conn)

            cmd.Parameters.AddWithValue("@kode", txtKodeKategori.Text.Trim)
            cmd.Parameters.AddWithValue("@nama", txtNamaKategori.Text.Trim)
            cmd.ExecuteNonQuery()

            MsgBox("Kategori berhasil disimpan", vbInformation)
            LoadKategori()
            ResetForm()

        Catch ex As Exception
            MsgBox("Gagal menyimpan kategori: " & ex.Message, vbCritical)
        End Try

    End Sub

    '=================================
    ' KLIK DATA GRID (UNTUK EDIT)
    '=================================
    Private Sub dgKategori_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgKategori.CellClick
        If e.RowIndex < 0 Then Exit Sub

        idEdit = Convert.ToInt32(dgKategori.Rows(e.RowIndex).Cells(0).Value)
        txtKodeKategori.Text = dgKategori.Rows(e.RowIndex).Cells(1).Value.ToString()
        txtNamaKategori.Text = dgKategori.Rows(e.RowIndex).Cells(2).Value.ToString()

        btnSimpan.Enabled = False
        btnEdit.Enabled = True
    End Sub

    '=================================
    ' EDIT DATA
    '=================================
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If idEdit = 0 Then Exit Sub

        If txtKodeKategori.Text.Trim = "" Or txtNamaKategori.Text.Trim = "" Then
            MsgBox("Data tidak boleh kosong!", vbExclamation)
            Exit Sub
        End If

        Try
            cmd = New MySqlCommand("
                UPDATE kategori SET
                    kode_kategori = @kode,
                    nama_kategori = @nama
                WHERE id = @id
            ", conn)

            cmd.Parameters.AddWithValue("@kode", txtKodeKategori.Text.Trim)
            cmd.Parameters.AddWithValue("@nama", txtNamaKategori.Text.Trim)
            cmd.Parameters.AddWithValue("@id", idEdit)
            cmd.ExecuteNonQuery()

            MsgBox("Kategori berhasil diupdate", vbInformation)
            LoadKategori()
            ResetForm()

        Catch ex As Exception
            MsgBox("Gagal update kategori: " & ex.Message, vbCritical)
        End Try
    End Sub

    '=================================
    ' CLEAR FORM
    '=================================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ResetForm()
    End Sub

    '=================================
    ' KEMBALI KE DASHBOARD
    '=================================
    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub
End Class
