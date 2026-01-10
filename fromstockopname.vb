Imports MySql.Data.MySqlClient
Imports System.Data

Public Class fromstockopname

    '================= CONFIG KONEKSI =================
    ' NOTE:
    ' - password kosong kalau pakai XAMPP default.
    ' - Jika password kamu ada, isi setelah password=
    Private Const ConnStr As String =
        "server=127.0.0.1;user id=root;password=;database=inventory;SslMode=Preferred;"

    Private Function NewConn() As MySqlConnection
        Return New MySqlConnection(ConnStr)
    End Function

    ' Flag supaya event SelectedIndexChanged tidak jalan saat load combo
    Private _isLoadingCombo As Boolean = False

    '================= FORM LOAD =================
    Private Sub fromstockopname_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized

        _isLoadingCombo = True
        LoadBarang()
        LoadGudang()
        _isLoadingCombo = False

        LoadGrid()
    End Sub

    '================= LOAD BARANG =================
    Private Sub LoadBarang()
        Try
            Using conn As MySqlConnection = NewConn()
                Dim sql As String = "SELECT id, nama_barang FROM barang ORDER BY nama_barang"
                Dim da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                cbBarang.DataSource = dt
                cbBarang.DisplayMember = "nama_barang"
                cbBarang.ValueMember = "id"
                cbBarang.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("LoadBarang error: " & ex.Message)
        End Try
    End Sub

    '================= LOAD GUDANG =================
    Private Sub LoadGudang()
        Try
            Using conn As MySqlConnection = NewConn()
                Dim sql As String = "SELECT id, nama_gudang FROM gudang ORDER BY nama_gudang"
                Dim da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                cbGudang.DataSource = dt
                cbGudang.DisplayMember = "nama_gudang"
                cbGudang.ValueMember = "id"
                cbGudang.SelectedIndex = -1
            End Using
        Catch ex As Exception
            MessageBox.Show("LoadGudang error: " & ex.Message)
        End Try
    End Sub

    '================= EVENT COMBO (AMBIL STOK SISTEM) =================
    Private Sub cbBarang_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles cbBarang.SelectedIndexChanged, cbGudang.SelectedIndexChanged

        If _isLoadingCombo Then Exit Sub
        If cbBarang.SelectedIndex < 0 Or cbGudang.SelectedIndex < 0 Then Exit Sub

        ' Pastikan SelectedValue benar-benar angka (kadang masih DataRowView saat binding)
        Dim idBarang As Integer
        Dim idGudang As Integer

        If Not Integer.TryParse(Convert.ToString(cbBarang.SelectedValue), idBarang) Then Exit Sub
        If Not Integer.TryParse(Convert.ToString(cbGudang.SelectedValue), idGudang) Then Exit Sub

        Try
            Using conn As MySqlConnection = NewConn()
                conn.Open()

                Dim sql As String =
                    "SELECT IFNULL(stok,0) " &
                    "FROM stok_gudang " &
                    "WHERE id_barang=@barang AND id_gudang=@gudang"

                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.Add("@barang", MySqlDbType.Int32).Value = idBarang
                    cmd.Parameters.Add("@gudang", MySqlDbType.Int32).Value = idGudang

                    Dim stokObj As Object = cmd.ExecuteScalar()
                    Dim stokSistem As Decimal = 0D
                    If stokObj IsNot Nothing AndAlso stokObj IsNot DBNull.Value Then
                        Decimal.TryParse(stokObj.ToString(), stokSistem)
                    End If

                    txtStokSistem.Text = stokSistem.ToString()
                End Using
            End Using

            HitungSelisih()

        Catch ex As Exception
            MessageBox.Show("Gagal ambil stok sistem: " & ex.Message)
        End Try
    End Sub

    '================= HITUNG SELISIH =================
    Private Sub HitungSelisih()
        Dim stokSistem As Decimal = 0D
        Decimal.TryParse(txtStokSistem.Text, stokSistem)

        Dim stokFisik As Decimal = nudStokFisik.Value
        txtSelisih.Text = (stokFisik - stokSistem).ToString()
    End Sub

    Private Sub nudStokFisik_ValueChanged(sender As Object, e As EventArgs) Handles nudStokFisik.ValueChanged
        HitungSelisih()
    End Sub

    '================= SIMPAN STOCK OPNAME =================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click

        If cbBarang.SelectedIndex < 0 Then
            MessageBox.Show("Pilih barang dulu.")
            Exit Sub
        End If

        If cbGudang.SelectedIndex < 0 Then
            MessageBox.Show("Pilih gudang dulu.")
            Exit Sub
        End If

        Dim idBarang As Integer
        Dim idGudang As Integer
        If Not Integer.TryParse(Convert.ToString(cbBarang.SelectedValue), idBarang) Then
            MessageBox.Show("ID Barang tidak valid.")
            Exit Sub
        End If
        If Not Integer.TryParse(Convert.ToString(cbGudang.SelectedValue), idGudang) Then
            MessageBox.Show("ID Gudang tidak valid.")
            Exit Sub
        End If

        Dim stokSistem As Decimal = 0D
        Decimal.TryParse(txtStokSistem.Text, stokSistem)

        Dim stokFisik As Decimal = nudStokFisik.Value
        Dim selisih As Decimal = stokFisik - stokSistem

        Try
            Using conn As MySqlConnection = NewConn()
                conn.Open()

                Using tr As MySqlTransaction = conn.BeginTransaction()

                    ' 1) insert ke stock_opname
                    Dim sqlInsert As String =
                        "INSERT INTO stock_opname " &
                        "(tanggal, id_barang, id_gudang, stok_sistem, stok_fisik, selisih) " &
                        "VALUES (CURDATE(), @barang, @gudang, @sistem, @fisik, @selisih)"

                    Using cmd As New MySqlCommand(sqlInsert, conn, tr)
                        cmd.Parameters.Add("@barang", MySqlDbType.Int32).Value = idBarang
                        cmd.Parameters.Add("@gudang", MySqlDbType.Int32).Value = idGudang
                        cmd.Parameters.Add("@sistem", MySqlDbType.Decimal).Value = stokSistem
                        cmd.Parameters.Add("@fisik", MySqlDbType.Decimal).Value = stokFisik
                        cmd.Parameters.Add("@selisih", MySqlDbType.Decimal).Value = selisih
                        cmd.ExecuteNonQuery()
                    End Using

                    ' 2) update stok_gudang (upsert)
                    Dim sqlUpsert As String =
                        "INSERT INTO stok_gudang (id_barang, id_gudang, stok) " &
                        "VALUES (@barang, @gudang, @stok) " &
                        "ON DUPLICATE KEY UPDATE stok=@stok"

                    Using cmd2 As New MySqlCommand(sqlUpsert, conn, tr)
                        cmd2.Parameters.Add("@barang", MySqlDbType.Int32).Value = idBarang
                        cmd2.Parameters.Add("@gudang", MySqlDbType.Int32).Value = idGudang
                        cmd2.Parameters.Add("@stok", MySqlDbType.Decimal).Value = stokFisik
                        cmd2.ExecuteNonQuery()
                    End Using

                    tr.Commit()
                End Using
            End Using

            MessageBox.Show("Stock opname berhasil disimpan.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadGrid()

        Catch ex As Exception
            MessageBox.Show("Gagal simpan: " & ex.Message)
        End Try
    End Sub

    '================= LOAD GRID =================
    Private Sub LoadGrid()
        Try
            Using conn As MySqlConnection = NewConn()
                Dim sql As String =
                    "SELECT " &
                    " b.nama_barang, " &
                    " g.nama_gudang, " &
                    " so.stok_sistem, " &
                    " so.stok_fisik, " &
                    " so.selisih, " &
                    " DATE_FORMAT(so.tanggal, '%Y-%m-%d') AS tanggal " &
                    "FROM stock_opname so " &
                    "JOIN barang b ON so.id_barang = b.id " &
                    "JOIN gudang g ON so.id_gudang = g.id " &
                    "ORDER BY so.tanggal DESC"

                Dim da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgStockOpname.DataSource = dt
            End Using

        Catch ex As Exception
            MessageBox.Show("Error LoadGrid: " & ex.Message)
        End Try
    End Sub

    '================= KEMBALI =================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Form1.BringToFront()
        Me.Hide()
    End Sub

End Class
