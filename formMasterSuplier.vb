Imports MySql.Data.MySqlClient

Public Class formMasterSuplier

    Dim idEdit As Integer = 0

    '===============================
    ' FORM LOAD
    '===============================
    Private Sub formMasterSuplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BackgroundImageLayout = ImageLayout.Stretch

        Koneksi()
        LoadSupplier()
        ResetForm()
    End Sub

    '===============================
    ' LOAD DATA SUPPLIER
    '===============================
    Sub LoadSupplier()
        LoadGrid(dgSupplier, "
            SELECT 
                id,
                kode_supplier,
                nama_supplier,
                alamat,
                telepon
            FROM supplier
            ORDER BY nama_supplier
        ")
    End Sub

    '===============================
    ' RESET FORM
    '===============================
    Sub ResetForm()
        txtKodeSupplier.Text = ""
        txtNamaSupplier.Text = ""
        txtAlamat.Text = ""
        txtNoTelp.Text = ""

        idEdit = 0

        btnSimpan.Enabled = True
        btnSimpan.Enabled = False
        btnHapus.Enabled = False
    End Sub

    '===============================
    ' SIMPAN DATA
    '===============================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If txtKodeSupplier.Text = "" Or txtNamaSupplier.Text = "" Then
            MsgBox("Kode dan Nama Supplier wajib diisi!", vbExclamation)
            Exit Sub
        End If

        cmd = New MySqlCommand("
            INSERT INTO supplier 
            (kode_supplier, nama_supplier, alamat, telepon)
            VALUES 
            (@kode, @nama, @alamat, @telp)
        ", conn)

        cmd.Parameters.AddWithValue("@kode", txtKodeSupplier.Text)
        cmd.Parameters.AddWithValue("@nama", txtNamaSupplier.Text)
        cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
        cmd.Parameters.AddWithValue("@telp", txtNoTelp.Text)

        cmd.ExecuteNonQuery()

        MsgBox("Supplier berhasil disimpan", vbInformation)
        LoadSupplier()
        ResetForm()
    End Sub

    '===============================
    ' PILIH DATA DARI GRID
    '===============================
    Private Sub dgSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSupplier.CellClick
        If e.RowIndex < 0 Then Exit Sub

        idEdit = dgSupplier.Rows(e.RowIndex).Cells("id").Value
        txtKodeSupplier.Text = dgSupplier.Rows(e.RowIndex).Cells("kode_supplier").Value
        txtNamaSupplier.Text = dgSupplier.Rows(e.RowIndex).Cells("nama_supplier").Value
        txtAlamat.Text = dgSupplier.Rows(e.RowIndex).Cells("alamat").Value
        txtNoTelp.Text = dgSupplier.Rows(e.RowIndex).Cells("telepon").Value

        btnSimpan.Enabled = False
        btnSimpan.Enabled = True
        btnHapus.Enabled = True
    End Sub

    '===============================
    ' EDIT DATA
    '===============================
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If idEdit = 0 Then Exit Sub

        cmd = New MySqlCommand("
            UPDATE supplier SET
                kode_supplier=@kode,
                nama_supplier=@nama,
                alamat=@alamat,
                telepon=@telp
            WHERE id=@id
        ", conn)

        cmd.Parameters.AddWithValue("@kode", txtKodeSupplier.Text)
        cmd.Parameters.AddWithValue("@nama", txtNamaSupplier.Text)
        cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text)
        cmd.Parameters.AddWithValue("@telp", txtNoTelp.Text)
        cmd.Parameters.AddWithValue("@id", idEdit)

        cmd.ExecuteNonQuery()

        MsgBox("Supplier berhasil diupdate", vbInformation)
        LoadSupplier()
        ResetForm()
    End Sub

    '===============================
    ' HAPUS DATA
    '===============================
    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If idEdit = 0 Then Exit Sub

        If MsgBox("Yakin ingin menghapus supplier ini?", vbQuestion + vbYesNo) = vbNo Then Exit Sub

        cmd = New MySqlCommand("DELETE FROM supplier WHERE id=@id", conn)
        cmd.Parameters.AddWithValue("@id", idEdit)
        cmd.ExecuteNonQuery()

        MsgBox("Supplier berhasil dihapus", vbInformation)
        LoadSupplier()
        ResetForm()
    End Sub

    '===============================
    ' KEMBALI KE DASHBOARD
    '===============================
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class
