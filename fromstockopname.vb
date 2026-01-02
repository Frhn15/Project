Imports MySql.Data.MySqlClient

Public Class fromstockopname

    ' ================= FORM LOAD =================
    Private Sub fromstockopname_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        LoadBarang()
        LoadGudang()
        LoadGrid()
    End Sub

    ' ================= LOAD BARANG =================
    Sub LoadBarang()
        Dim da As New MySqlDataAdapter("SELECT id, nama_barang FROM barang", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cbBarang.DataSource = dt
        cbBarang.DisplayMember = "nama_barang"
        cbBarang.ValueMember = "id"
        cbBarang.SelectedIndex = -1
    End Sub

    ' ================= LOAD GUDANG =================
    Sub LoadGudang()
        Dim da As New MySqlDataAdapter("SELECT id, nama_gudang FROM gudang", conn)
        Dim dt As New DataTable
        da.Fill(dt)

        cbGudang.DataSource = dt
        cbGudang.DisplayMember = "nama_gudang"
        cbGudang.ValueMember = "id"
        cbGudang.SelectedIndex = -1
    End Sub

    ' ================= AMBIL STOK SISTEM =================
    Private Sub cbBarang_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cbBarang.SelectedIndexChanged, cbGudang.SelectedIndexChanged

        If cbBarang.SelectedValue Is Nothing Or cbGudang.SelectedValue Is Nothing Then Exit Sub

        Dim cmd As New MySqlCommand("
            SELECT IFNULL(stok,0)
            FROM stok_gudang
            WHERE id_barang=@barang AND id_gudang=@gudang", conn)

        cmd.Parameters.AddWithValue("@barang", cbBarang.SelectedValue)
        cmd.Parameters.AddWithValue("@gudang", cbGudang.SelectedValue)

        conn.Open()
        Dim stok As Object = cmd.ExecuteScalar()
        conn.Close()

        txtStokSistem.Text = stok.ToString()
        HitungSelisih()
    End Sub

    ' ================= HITUNG SELISIH =================
    Sub HitungSelisih()
        txtSelisih.Text = Val(nudStokFisik.Value) - Val(txtStokSistem.Text)
    End Sub

    Private Sub nudStokFisik_ValueChanged(sender As Object, e As EventArgs) Handles nudStokFisik.ValueChanged
        HitungSelisih()
    End Sub

    ' ================= SIMPAN STOCK OPNAME =================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        ' SIMPAN KE stock_opname
        Dim cmd As New MySqlCommand("
            INSERT INTO stock_opname
            (tanggal, id_barang, id_gudang, stok_sistem, stok_fisik, selisih)
            VALUES
            (CURDATE(), @barang, @gudang, @sistem, @fisik, @selisih)", conn)

        cmd.Parameters.AddWithValue("@barang", cbBarang.SelectedValue)
        cmd.Parameters.AddWithValue("@gudang", cbGudang.SelectedValue)
        cmd.Parameters.AddWithValue("@sistem", txtStokSistem.Text)
        cmd.Parameters.AddWithValue("@fisik", nudStokFisik.Value)
        cmd.Parameters.AddWithValue("@selisih", txtSelisih.Text)

        conn.Open()
        cmd.ExecuteNonQuery()
        conn.Close()

        ' UPDATE stok_gudang
        Dim cmdUpdate As New MySqlCommand("
            INSERT INTO stok_gudang (id_barang, id_gudang, stok)
            VALUES (@barang, @gudang, @stok)
            ON DUPLICATE KEY UPDATE stok=@stok", conn)

        cmdUpdate.Parameters.AddWithValue("@barang", cbBarang.SelectedValue)
        cmdUpdate.Parameters.AddWithValue("@gudang", cbGudang.SelectedValue)
        cmdUpdate.Parameters.AddWithValue("@stok", nudStokFisik.Value)

        conn.Open()
        cmdUpdate.ExecuteNonQuery()
        conn.Close()

        MsgBox("Stock opname berhasil disimpan", vbInformation)
        LoadGrid()
    End Sub

    ' ================= LOAD GRID =================
    Sub LoadGrid()
        Try
            Dim sql As String = "
            SELECT 
                b.nama_barang,
                g.nama_gudang,
                so.stok_sistem,
                so.stok_fisik,
                so.selisih,
                DATE_FORMAT(so.tanggal, '%Y-%m-%d') AS tanggal
            FROM stock_opname so
            JOIN barang b ON so.id_barang = b.id
            JOIN gudang g ON so.id_gudang = g.id
            ORDER BY so.tanggal DESC
        "

            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As New DataTable
            da.Fill(dt)

            dgStockOpname.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Error LoadGrid: " & ex.Message)
        End Try
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form1.Show()
        Form1.BringToFront()
        Me.Hide()
    End Sub
End Class
