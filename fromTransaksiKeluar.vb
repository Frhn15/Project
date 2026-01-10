Imports MySql.Data.MySqlClient
Imports System.Data

Public Class fromTransaksiKeluar

    ' =========================================================
    '  SET CONNECTION STRING (GANTI SESUAI PUNYA KAMU)
    ' =========================================================
    Private Const CONN_STR As String = "server=127.0.0.1;user id=root;password=;database=inventory;"

    Private Function GetConn() As MySqlConnection
        Return New MySqlConnection(CONN_STR)
    End Function

    ' =========================================================
    '  DATATABLE UNTUK GRID (JANGAN NAMANYA dtList!)
    ' =========================================================
    Private dtList As DataTable
    Private currentNoDokumen As String = ""

    ' ================= FORM LOAD =================
    Private Sub fromTransaksiKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            WindowState = FormWindowState.Maximized

            SetupGridList()
            LoadGudangAsal()
            LoadBarang()
            BuatNoDokumenKeluar()

            ' default
            dtTanggal.Value = Date.Today
            nudQty.Minimum = 1
            nudQty.Value = 1

        Catch ex As Exception
            MessageBox.Show("Gagal load form: " & ex.Message)
        End Try
    End Sub

    ' =========================================================
    '  SETUP GRID: TANGGAL + TUJUAN + KETERANGAN + BARANG + QTY
    ' =========================================================
    Private Sub SetupGridList()
        dtList = New DataTable()

        ' id_barang disimpan untuk proses simpan DB
        dtList.Columns.Add("id_barang", GetType(Integer))

        ' kolom yang kamu minta tampil
        dtList.Columns.Add("tanggal", GetType(Date))
        dtList.Columns.Add("tujuan", GetType(String))
        dtList.Columns.Add("keterangan", GetType(String))
        dtList.Columns.Add("barang", GetType(String))
        dtList.Columns.Add("qty", GetType(Integer))

        dgList.DataSource = dtList
        dgList.AllowUserToAddRows = False
        dgList.ReadOnly = True
        dgList.MultiSelect = False
        dgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgList.Columns("id_barang").Visible = False

        dgList.Columns("tanggal").HeaderText = "Tanggal"
        dgList.Columns("tujuan").HeaderText = "Tujuan"
        dgList.Columns("keterangan").HeaderText = "Keterangan"
        dgList.Columns("barang").HeaderText = "Barang"
        dgList.Columns("qty").HeaderText = "Qty"

        dgList.Columns("tanggal").DefaultCellStyle.Format = "yyyy-MM-dd"
    End Sub

    ' ================= LOAD BARANG =================
    Private Sub LoadBarang()
        Using conn As MySqlConnection = GetConn()
            Dim sql As String = "SELECT id, nama_barang FROM barang ORDER BY nama_barang"
            Using da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                cbBarang.DataSource = dt
                cbBarang.DisplayMember = "nama_barang"
                cbBarang.ValueMember = "id"
                cbBarang.SelectedIndex = -1
            End Using
        End Using
    End Sub

    ' ================= LOAD GUDANG ASAL =================
    Private Sub LoadGudangAsal()
        Using conn As MySqlConnection = GetConn()
            Dim sql As String = "SELECT id, nama_gudang FROM gudang ORDER BY nama_gudang"
            Using da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                cbGudangAsal.DataSource = dt
                cbGudangAsal.DisplayMember = "nama_gudang"
                cbGudangAsal.ValueMember = "id"
                cbGudangAsal.SelectedIndex = -1
            End Using
        End Using
    End Sub

    ' =========================================================
    '  GENERATE NO DOKUMEN: BK-YYYYMMDD-0001
    ' =========================================================
    Private Sub BuatNoDokumenKeluar()
        Dim todayPart As String = Date.Today.ToString("yyyyMMdd")
        Dim prefix As String = "BK-" & todayPart & "-"

        Using conn As MySqlConnection = GetConn()
            conn.Open()

            Dim sql As String =
                "SELECT no_dokumen FROM barang_keluar " &
                "WHERE no_dokumen LIKE @p " &
                "ORDER BY no_dokumen DESC LIMIT 1"

            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@p", prefix & "%")

                Dim lastDoc As Object = cmd.ExecuteScalar()
                Dim nextNo As Integer = 1

                If lastDoc IsNot Nothing Then
                    Dim s As String = lastDoc.ToString()
                    Dim lastPart As String = s.Substring(s.Length - 4)
                    Integer.TryParse(lastPart, nextNo)
                    nextNo += 1
                End If

                currentNoDokumen = prefix & nextNo.ToString("0000")
            End Using
        End Using

        txtNoDokumen.Text = currentNoDokumen
    End Sub

    ' =========================================================
    '  GET STOK DARI stok_gudang (safe)
    ' =========================================================
    Private Function GetStok(conn As MySqlConnection, tr As MySqlTransaction, idBarang As Integer, idGudang As Integer) As Integer
        Dim sql As String = "SELECT IFNULL(stok,0) FROM stok_gudang WHERE id_barang=@b AND id_gudang=@g"
        Using cmd As New MySqlCommand(sql, conn, tr)
            cmd.Parameters.AddWithValue("@b", idBarang)
            cmd.Parameters.AddWithValue("@g", idGudang)
            Dim o As Object = cmd.ExecuteScalar()
            If o Is Nothing OrElse o Is DBNull.Value Then Return 0
            Return Convert.ToInt32(o)
        End Using
    End Function

    ' =========================================================
    '  TAMBAH KE LIST (MASUK GRID)
    ' =========================================================
    Private Sub btnTambahKeList_Click(sender As Object, e As EventArgs) Handles btnTambahKeList.Click
        Try
            If cbGudangAsal.SelectedValue Is Nothing Then
                MessageBox.Show("Pilih Gudang Asal dulu.")
                Exit Sub
            End If

            If cbBarang.SelectedValue Is Nothing OrElse cbBarang.SelectedItem Is Nothing Then
                MessageBox.Show("Pilih barang dulu.")
                Exit Sub
            End If

            Dim idGudang As Integer = CInt(cbGudangAsal.SelectedValue)
            Dim idBarang As Integer = CInt(cbBarang.SelectedValue)
            Dim qty As Integer = CInt(nudQty.Value)

            If qty <= 0 Then
                MessageBox.Show("Qty harus > 0.")
                Exit Sub
            End If

            Dim tgl As Date = dtTanggal.Value.Date
            Dim tujuan As String = txtTujuan.Text.Trim()
            Dim ket As String = txtKeterangan.Text.Trim()

            Dim drv As DataRowView = DirectCast(cbBarang.SelectedItem, DataRowView)
            Dim namaBarang As String = drv("nama_barang").ToString()

            ' cek stok gudang asal
            Dim stokSistem As Integer = 0
            Using conn As MySqlConnection = GetConn()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT IFNULL(stok,0) FROM stok_gudang WHERE id_barang=@b AND id_gudang=@g", conn)
                    cmd.Parameters.AddWithValue("@b", idBarang)
                    cmd.Parameters.AddWithValue("@g", idGudang)
                    Dim o As Object = cmd.ExecuteScalar()
                    If o IsNot Nothing AndAlso o IsNot DBNull.Value Then stokSistem = CInt(o)
                End Using
            End Using

            ' qty yang sudah ada di list (kalau barang sama)
            Dim qtyDiList As Integer = 0
            For Each r As DataRow In dtList.Rows
                If CInt(r("id_barang")) = idBarang Then
                    qtyDiList = CInt(r("qty"))
                    Exit For
                End If
            Next

            If stokSistem < (qtyDiList + qty) Then
                MessageBox.Show("Stok tidak cukup. Stok: " & stokSistem & " | Di list: " & qtyDiList)
                Exit Sub
            End If

            ' kalau barang sudah ada, tambah qty
            For Each r As DataRow In dtList.Rows
                If CInt(r("id_barang")) = idBarang Then
                    r("qty") = CInt(r("qty")) + qty

                    ' update header agar ikut terbaru
                    r("tanggal") = tgl
                    r("tujuan") = tujuan
                    r("keterangan") = ket

                    nudQty.Value = 1
                    Exit Sub
                End If
            Next

            ' kalau belum ada, tambah row baru
            dtList.Rows.Add(idBarang, tgl, tujuan, ket, namaBarang, qty)
            nudQty.Value = 1

        Catch ex As Exception
            MessageBox.Show("Gagal tambah ke list: " & ex.Message)
        End Try
    End Sub

    ' =========================================================
    '  OPTIONAL: DOUBLE CLICK ROW → HAPUS DARI LIST
    ' =========================================================
    Private Sub dtList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgList.CellDoubleClick
        Try
            If e.RowIndex < 0 Then Exit Sub
            If MessageBox.Show("Hapus item ini dari list?", "Konfirmasi", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                dtList.Rows.RemoveAt(e.RowIndex)
            End If
        Catch
        End Try
    End Sub

    ' =========================================================
    '  SIMPAN TRANSAKSI KELUAR:
    '   barang_keluar: (id, no_dokumen, tanggal, tujuan, id_gudang, keterangan)
    '   barang_keluar_detail: (id, id_header, id_barang, qty)
    '  UPDATE stok_gudang: stok = stok - qty
    ' =========================================================
    Private Sub btnSimpanTransaksi_Click(sender As Object, e As EventArgs) Handles btnSimpanTransaksi.Click
        If cbGudangAsal.SelectedValue Is Nothing Then
            MessageBox.Show("Gudang Asal wajib dipilih.")
            Exit Sub
        End If

        If dtList.Rows.Count = 0 Then
            MessageBox.Show("List masih kosong. Klik 'Tambah Ke List' dulu.")
            Exit Sub
        End If

        Dim idGudang As Integer = CInt(cbGudangAsal.SelectedValue)
        Dim tgl As Date = dtTanggal.Value.Date
        Dim tujuan As String = txtTujuan.Text.Trim()
        Dim ket As String = txtKeterangan.Text.Trim()

        Using conn As MySqlConnection = GetConn()
            conn.Open()
            Dim tr As MySqlTransaction = conn.BeginTransaction()

            Try
                ' 1) INSERT HEADER
                Dim sqlH As String =
                    "INSERT INTO barang_keluar(no_dokumen, tanggal, tujuan, id_gudang, keterangan) " &
                    "VALUES(@no, @tgl, @tujuan, @gudang, @ket); SELECT LAST_INSERT_ID();"

                Dim idHeader As Integer
                Using cmdH As New MySqlCommand(sqlH, conn, tr)
                    cmdH.Parameters.AddWithValue("@no", currentNoDokumen)
                    cmdH.Parameters.AddWithValue("@tgl", tgl)
                    cmdH.Parameters.AddWithValue("@tujuan", If(tujuan = "", DBNull.Value, tujuan))
                    cmdH.Parameters.AddWithValue("@gudang", idGudang)
                    cmdH.Parameters.AddWithValue("@ket", If(ket = "", DBNull.Value, ket))
                    idHeader = Convert.ToInt32(cmdH.ExecuteScalar())
                End Using

                ' 2) DETAIL + UPDATE STOK
                For Each r As DataRow In dtList.Rows
                    Dim idBarang As Integer = CInt(r("id_barang"))
                    Dim qty As Integer = CInt(r("qty"))

                    ' cek stok asal aman
                    Dim stokAsal As Integer = GetStok(conn, tr, idBarang, idGudang)
                    If stokAsal < qty Then
                        Throw New Exception("Stok gudang tidak cukup untuk barang ID " & idBarang &
                                            ". Stok: " & stokAsal & ", Qty: " & qty)
                    End If

                    ' insert detail
                    Dim sqlD As String = "INSERT INTO barang_keluar_detail(id_header, id_barang, qty) VALUES(@h, @b, @q)"
                    Using cmdD As New MySqlCommand(sqlD, conn, tr)
                        cmdD.Parameters.AddWithValue("@h", idHeader)
                        cmdD.Parameters.AddWithValue("@b", idBarang)
                        cmdD.Parameters.AddWithValue("@q", qty)
                        cmdD.ExecuteNonQuery()
                    End Using

                    ' kurangi stok gudang
                    Dim sqlU As String = "UPDATE stok_gudang SET stok = stok - @q WHERE id_barang=@b AND id_gudang=@g"
                    Using cmdU As New MySqlCommand(sqlU, conn, tr)
                        cmdU.Parameters.AddWithValue("@q", qty)
                        cmdU.Parameters.AddWithValue("@b", idBarang)
                        cmdU.Parameters.AddWithValue("@g", idGudang)
                        Dim affected As Integer = cmdU.ExecuteNonQuery()
                        If affected = 0 Then
                            Throw New Exception("Data stok_gudang tidak ditemukan untuk barang ID " & idBarang & " (gudang " & idGudang & ")")
                        End If
                    End Using
                Next

                tr.Commit()

                MessageBox.Show("Transaksi barang keluar berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' reset
                dtList.Rows.Clear()
                cbBarang.SelectedIndex = -1
                nudQty.Value = 1

                BuatNoDokumenKeluar()

            Catch ex As Exception
                Try
                    tr.Rollback()
                Catch
                End Try
                MessageBox.Show("Gagal simpan transaksi: " & ex.Message)
            End Try
        End Using
    End Sub

    ' ================= KEMBALI =================
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form1.Show()
        Form1.BringToFront()
        Me.Hide()
    End Sub

End Class
