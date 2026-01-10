Imports MySql.Data.MySqlClient
Imports System.Data

Public Class fromTransaksiKeluar

    '===== GANTI SESUAI MYSQL KAMU =====
    Private ReadOnly ConnStr As String =
        "Server=127.0.0.1;Database=inventory;Uid=root;Pwd=;SslMode=Disabled;"

    ' DataTable untuk isi detail (barang & qty) - JANGAN NAMAI dtList
    Private dtList As DataTable

    Private Function OpenConn() As MySqlConnection
        Dim conn As New MySqlConnection(ConnStr)
        conn.Open()
        Return conn
    End Function

    Private Sub fromTransaksiKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadGudangAsal()
            LoadBarang()
            SetupGridList()
            BuatNoDokumenKeluar()
        Catch ex As Exception
            MessageBox.Show("Gagal load form: " & ex.Message)
        End Try
    End Sub

    '==================== LOAD COMBO ====================
    Private Sub LoadGudangAsal()
        Using conn = OpenConn()
            Using da As New MySqlDataAdapter(
                "SELECT id, CONCAT(kode_gudang,' - ',nama_gudang) AS tampil FROM gudang ORDER BY nama_gudang", conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                cbGudangAsal.DataSource = dt
                cbGudangAsal.DisplayMember = "tampil"
                cbGudangAsal.ValueMember = "id"
                cbGudangAsal.SelectedIndex = -1
            End Using
        End Using
    End Sub

    Private Sub LoadBarang()
        Using conn = OpenConn()
            Using da As New MySqlDataAdapter(
                "SELECT id, CONCAT(kode_barang,' - ',nama_barang) AS tampil FROM barang ORDER BY nama_barang", conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                cbBarang.DataSource = dt
                cbBarang.DisplayMember = "tampil"
                cbBarang.ValueMember = "id"   ' <-- ini harus ID (INT), bukan tampil
                cbBarang.SelectedIndex = -1
            End Using
        End Using
    End Sub

    '==================== SETUP GRID ====================
    Private Sub SetupGridList()
        dtList = New DataTable()

        dtList.Columns.Add("id_barang", GetType(Integer))
        dtList.Columns.Add("barang", GetType(String))
        dtList.Columns.Add("qty", GetType(Integer))

        ' dtList = DataGridView dari Designer
        dgList.DataSource = dtList

        dgList.AllowUserToAddRows = False
        dgList.ReadOnly = True
        dgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgList.MultiSelect = False

        dgList.Columns("id_barang").Visible = False
        dgList.Columns("barang").HeaderText = "Barang"
        dgList.Columns("qty").HeaderText = "Qty"
    End Sub

    '==================== GENERATE NO DOKUMEN ====================
    Private Sub BuatNoDokumenKeluar()
        Dim prefix As String = "BK-" & DateTime.Now.ToString("yyyyMMdd") & "-"

        Using conn = OpenConn()
            Dim lastNo As Object
            Using cmd As New MySqlCommand(
                "SELECT MAX(no_dokumen) FROM barang_keluar WHERE no_dokumen LIKE @pfx", conn)
                cmd.Parameters.AddWithValue("@pfx", prefix & "%")
                lastNo = cmd.ExecuteScalar()
            End Using

            Dim urut As Integer = 1
            If lastNo IsNot Nothing AndAlso lastNo IsNot DBNull.Value Then
                Dim s As String = CStr(lastNo)
                Dim part As String = s.Substring(prefix.Length) ' ambil angka belakang
                Integer.TryParse(part, urut)
                urut += 1
            End If

            txtNoDokumen.Text = prefix & urut.ToString("0001")
        End Using
    End Sub

    '==================== TOMBOL TAMBAH KE LIST ====================
    Private Sub btnTambahKeList_Click(sender As Object, e As EventArgs) Handles btnTambahKeList.Click
        Try
            If cbBarang.SelectedIndex = -1 Then
                MessageBox.Show("Pilih barang dulu.")
                Return
            End If

            If cbGudangAsal.SelectedIndex = -1 Then
                MessageBox.Show("Pilih Gudang Asal dulu.")
                Return
            End If

            Dim idBarang As Integer = CInt(cbBarang.SelectedValue) ' INT
            Dim namaBarang As String = cbBarang.Text              ' "011 - Susu UHT"
            Dim qty As Integer = CInt(nudQty.Value)

            ' (Opsional) cek stok gudang cukup
            Dim idGudang As Integer = CInt(cbGudangAsal.SelectedValue)
            Dim stok As Integer = GetStokGudang(idGudang, idBarang)
            Dim qtyDiList As Integer = GetQtyDiList(idBarang)

            If stok < (qtyDiList + qty) Then
                MessageBox.Show("Stok tidak cukup. Stok saat ini: " & stok &
                                ". Di list: " & qtyDiList)
                Return
            End If

            ' kalau barang sudah ada, tambah qty
            For Each r As DataRow In dtList.Rows
                If CInt(r("id_barang")) = idBarang Then
                    r("qty") = CInt(r("qty")) + qty
                    nudQty.Value = 1
                    cbBarang.SelectedIndex = -1
                    Return
                End If
            Next

            ' kalau belum ada, add row baru
            dtList.Rows.Add(idBarang, namaBarang, qty)

            nudQty.Value = 1
            cbBarang.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show("Gagal tambah: " & ex.Message)
        End Try
    End Sub

    Private Function GetQtyDiList(idBarang As Integer) As Integer
        Dim total As Integer = 0
        For Each r As DataRow In dtList.Rows
            If CInt(r("id_barang")) = idBarang Then
                total += CInt(r("qty"))
            End If
        Next
        Return total
    End Function

    Private Function GetStokGudang(idGudang As Integer, idBarang As Integer) As Integer
        Using conn = OpenConn()
            Using cmd As New MySqlCommand(
                "SELECT stok FROM stok_gudang WHERE id_gudang=@g AND id_barang=@b", conn)
                cmd.Parameters.AddWithValue("@g", idGudang)
                cmd.Parameters.AddWithValue("@b", idBarang)

                Dim o = cmd.ExecuteScalar()
                If o Is Nothing OrElse o Is DBNull.Value Then Return 0
                Return CInt(o)
            End Using
        End Using
    End Function

    '==================== SIMPAN TRANSAKSI ====================
    Private Sub btnSimpanTransaksi_Click(sender As Object, e As EventArgs) Handles btnSimpanTransaksi.Click
        Try
            If dtList.Rows.Count = 0 Then
                MessageBox.Show("List barang masih kosong.")
                Return
            End If

            If cbGudangAsal.SelectedIndex = -1 Then
                MessageBox.Show("Gudang asal belum dipilih.")
                Return
            End If

            Dim noDok As String = txtNoDokumen.Text.Trim()
            Dim tgl As Date = dtTanggal.Value.Date
            Dim tujuan As String = txtTujuan.Text.Trim()
            Dim ket As String = txtKeterangan.Text.Trim()
            Dim idGudang As Integer = CInt(cbGudangAsal.SelectedValue)

            Using conn = OpenConn()
                Using trx = conn.BeginTransaction()

                    ' insert header
                    Dim idHeader As Integer
                    Using cmd As New MySqlCommand(
                        "INSERT INTO barang_keluar(no_dokumen,tanggal,tujuan,id_gudang,keterangan)
                         VALUES(@no,@tgl,@tjn,@g,@ket);
                         SELECT LAST_INSERT_ID();", conn, trx)

                        cmd.Parameters.AddWithValue("@no", noDok)
                        cmd.Parameters.AddWithValue("@tgl", tgl)
                        cmd.Parameters.AddWithValue("@tjn", tujuan)
                        cmd.Parameters.AddWithValue("@g", idGudang)
                        cmd.Parameters.AddWithValue("@ket", ket)

                        idHeader = CInt(cmd.ExecuteScalar())
                    End Using

                    ' insert detail + update stok
                    For Each r As DataRow In dtList.Rows
                        Dim idBarang As Integer = CInt(r("id_barang"))
                        Dim qty As Integer = CInt(r("qty"))

                        Using cmdD As New MySqlCommand(
                            "INSERT INTO barang_keluar_detail(id_header,id_barang,qty)
                             VALUES(@h,@b,@q)", conn, trx)
                            cmdD.Parameters.AddWithValue("@h", idHeader)
                            cmdD.Parameters.AddWithValue("@b", idBarang)
                            cmdD.Parameters.AddWithValue("@q", qty)
                            cmdD.ExecuteNonQuery()
                        End Using

                        Using cmdS As New MySqlCommand(
                            "UPDATE stok_gudang SET stok = stok - @q
                             WHERE id_gudang=@g AND id_barang=@b", conn, trx)
                            cmdS.Parameters.AddWithValue("@q", qty)
                            cmdS.Parameters.AddWithValue("@g", idGudang)
                            cmdS.Parameters.AddWithValue("@b", idBarang)
                            cmdS.ExecuteNonQuery()
                        End Using
                    Next

                    trx.Commit()
                End Using
            End Using

            MessageBox.Show("Transaksi keluar berhasil disimpan.")

            ' reset
            dtList.Rows.Clear()
            txtTujuan.Clear()
            txtKeterangan.Clear()
            cbBarang.SelectedIndex = -1
            nudQty.Value = 1
            BuatNoDokumenKeluar()

        Catch ex As Exception
            MessageBox.Show("Gagal simpan transaksi: " & ex.Message)
        End Try
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form1.Show()
        Me.Hide()
    End Sub

End Class
