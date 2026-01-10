Imports MySql.Data.MySqlClient
Imports System.Data

Public Class FromTransferAntarGudang

    ' =========================================================
    '  SET CONNECTION STRING DI SINI (GANTI SESUAI DATABASE KAMU)
    ' =========================================================
    Private Const CONN_STR As String = "server=127.0.0.1;user id=root;password=;database=inventory;"

    Private Function GetConn() As MySqlConnection
        Return New MySqlConnection(CONN_STR)
    End Function

    ' =========================================================
    '  LIST ITEM TRANSFER (DITAMPILKAN DI GRID)
    ' =========================================================
    Private dtList As DataTable
    Private currentNoTransfer As String = ""

    ' ================= FORM LOAD =================
    Private Sub FromTransferAntarGudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            WindowState = FormWindowState.Maximized

            SetupGridList()
            LoadGudang()
            LoadBarang()
            BuatNoTransfer()

            nudQty.Minimum = 1
            nudQty.Value = 1

        Catch ex As Exception
            MessageBox.Show("Gagal load form: " & ex.Message)
        End Try
    End Sub

    ' =========================================================
    '  AMBIL TANGGAL (kalau ada DateTimePicker bernama dtTanggal → pakai itu)
    '  kalau tidak ada → pakai Date.Today
    ' =========================================================
    Private Function GetTanggalHeader() As Date
        Dim c = Me.Controls.Find("dtTanggal", True)
        If c.Length > 0 AndAlso TypeOf c(0) Is DateTimePicker Then
            Return DirectCast(c(0), DateTimePicker).Value.Date
        End If
        Return Date.Today
    End Function

    ' =========================================================
    '  AMBIL KETERANGAN (kalau ada TextBox bernama txtKeterangan)
    '  kalau tidak ada → kosong
    ' =========================================================
    Private Function GetKeteranganHeader() As String
        Dim c = Me.Controls.Find("txtKeterangan", True)
        If c.Length > 0 AndAlso TypeOf c(0) Is TextBox Then
            Return DirectCast(c(0), TextBox).Text.Trim()
        End If
        Return ""
    End Function

    ' =========================================================
    '  SETUP GRID: TANGGAL + TUJUAN + KETERANGAN + BARANG + QTY
    ' =========================================================
    Private Sub SetupGridList()
        dtList = New DataTable()

        ' simpan id untuk proses simpan ke DB
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

        ' format tanggal
        dgList.Columns("tanggal").DefaultCellStyle.Format = "yyyy-MM-dd"
    End Sub

    ' =========================================================
    '  LOAD GUDANG (ASAL & TUJUAN)
    ' =========================================================
    Private Sub LoadGudang()
        Using conn As MySqlConnection = GetConn()
            Dim sql As String = "SELECT id, nama_gudang FROM gudang ORDER BY nama_gudang"
            Using da As New MySqlDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                cbGudangAsal.DataSource = dt.Copy()
                cbGudangAsal.DisplayMember = "nama_gudang"
                cbGudangAsal.ValueMember = "id"
                cbGudangAsal.SelectedIndex = -1

                cbGudangTujuan.DataSource = dt
                cbGudangTujuan.DisplayMember = "nama_gudang"
                cbGudangTujuan.ValueMember = "id"
                cbGudangTujuan.SelectedIndex = -1
            End Using
        End Using
    End Sub

    ' =========================================================
    '  LOAD BARANG (id + nama_barang)
    ' =========================================================
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

    ' =========================================================
    '  GENERATE NO TRANSFER: TR-YYYYMMDD-0001
    ' =========================================================
    Private Sub BuatNoTransfer()
        Dim todayPart As String = Date.Today.ToString("yyyyMMdd")
        Dim prefix As String = "TR-" & todayPart & "-"

        Using conn As MySqlConnection = GetConn()
            conn.Open()

            Dim sql As String =
                "SELECT no_transfer FROM transfer_gudang " &
                "WHERE no_transfer LIKE @p " &
                "ORDER BY no_transfer DESC LIMIT 1"

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

                currentNoTransfer = prefix & nextNo.ToString("0000")
            End Using
        End Using
    End Sub

    ' =========================================================
    '  AMBIL STOK DARI stok_gudang
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
    '  TOMBOL TAMBAH ITEM (MASUK KE GRID)
    ' =========================================================
    Private Sub btnTambahItem_Click(sender As Object, e As EventArgs) Handles btnTambahItem.Click
        Try
            If cbGudangAsal.SelectedValue Is Nothing Then
                MessageBox.Show("Pilih Gudang Asal dulu.")
                Exit Sub
            End If

            If cbGudangTujuan.SelectedValue Is Nothing Then
                MessageBox.Show("Pilih Gudang Tujuan dulu.")
                Exit Sub
            End If

            Dim idAsal As Integer = CInt(cbGudangAsal.SelectedValue)
            Dim idTujuan As Integer = CInt(cbGudangTujuan.SelectedValue)

            If idAsal = idTujuan Then
                MessageBox.Show("Gudang Asal dan Gudang Tujuan tidak boleh sama.")
                Exit Sub
            End If

            If cbBarang.SelectedValue Is Nothing OrElse cbBarang.SelectedItem Is Nothing Then
                MessageBox.Show("Pilih barang dulu.")
                Exit Sub
            End If

            Dim idBarang As Integer = CInt(cbBarang.SelectedValue)
            Dim qty As Integer = CInt(nudQty.Value)
            If qty <= 0 Then
                MessageBox.Show("Qty harus > 0.")
                Exit Sub
            End If

            Dim drv As DataRowView = DirectCast(cbBarang.SelectedItem, DataRowView)
            Dim namaBarang As String = drv("nama_barang").ToString()

            Dim tanggalHeader As Date = GetTanggalHeader()
            Dim tujuanHeader As String = cbGudangTujuan.Text.Trim()
            Dim ketHeader As String = GetKeteranganHeader()

            ' cek stok gudang asal
            Dim stokSistem As Integer = 0
            Using conn As MySqlConnection = GetConn()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT IFNULL(stok,0) FROM stok_gudang WHERE id_barang=@b AND id_gudang=@g", conn)
                    cmd.Parameters.AddWithValue("@b", idBarang)
                    cmd.Parameters.AddWithValue("@g", idAsal)
                    Dim o As Object = cmd.ExecuteScalar()
                    If o IsNot Nothing AndAlso o IsNot DBNull.Value Then stokSistem = CInt(o)
                End Using
            End Using

            ' qty yang sudah ada di list
            Dim qtyDiList As Integer = 0
            For Each r As DataRow In dtList.Rows
                If CInt(r("id_barang")) = idBarang Then
                    qtyDiList = CInt(r("qty"))
                    Exit For
                End If
            Next

            If stokSistem < (qtyDiList + qty) Then
                MessageBox.Show("Stok gudang asal tidak cukup. Stok: " & stokSistem & " | Di list: " & qtyDiList)
                Exit Sub
            End If

            ' kalau barang sudah ada → tambah qty
            For Each r As DataRow In dtList.Rows
                If CInt(r("id_barang")) = idBarang Then
                    r("qty") = CInt(r("qty")) + qty

                    ' update kolom header supaya selalu ikut terbaru
                    r("tanggal") = tanggalHeader
                    r("tujuan") = tujuanHeader
                    r("keterangan") = ketHeader

                    nudQty.Value = 1
                    Exit Sub
                End If
            Next

            ' kalau belum ada → tambah row
            dtList.Rows.Add(idBarang, tanggalHeader, tujuanHeader, ketHeader, namaBarang, qty)
            nudQty.Value = 1

        Catch ex As Exception
            MessageBox.Show("Gagal tambah item: " & ex.Message)
        End Try
    End Sub

    ' =========================================================
    '  OPTIONAL: DOUBLE CLICK ROW HAPUS DARI LIST
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
    '  SIMPAN TRANSFER:
    '   transfer_gudang: (id, no_transfer, tanggal, id_asal, id_tujuan, keterangan)
    '   transfer_gudang_detail: (id, id_header, id_barang, qty)
    '  UPDATE stok_gudang: asal -qty, tujuan +qty
    ' =========================================================
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If cbGudangAsal.SelectedValue Is Nothing OrElse cbGudangTujuan.SelectedValue Is Nothing Then
            MessageBox.Show("Gudang asal & tujuan wajib dipilih.")
            Exit Sub
        End If

        Dim idAsal As Integer = CInt(cbGudangAsal.SelectedValue)
        Dim idTujuan As Integer = CInt(cbGudangTujuan.SelectedValue)

        If idAsal = idTujuan Then
            MessageBox.Show("Gudang Asal dan Gudang Tujuan tidak boleh sama.")
            Exit Sub
        End If

        If dtList.Rows.Count = 0 Then
            MessageBox.Show("List transfer masih kosong. Klik 'Tambah Item' dulu.")
            Exit Sub
        End If

        Dim tglHeader As Date = GetTanggalHeader()
        Dim ketHeader As String = GetKeteranganHeader()

        Using conn As MySqlConnection = GetConn()
            conn.Open()
            Dim tr As MySqlTransaction = conn.BeginTransaction()

            Try
                ' 1) INSERT HEADER
                Dim sqlHeader As String =
                    "INSERT INTO transfer_gudang(no_transfer, tanggal, id_asal, id_tujuan, keterangan) " &
                    "VALUES(@no, @tgl, @asal, @tujuan, @ket); SELECT LAST_INSERT_ID();"

                Dim idHeader As Integer
                Using cmdH As New MySqlCommand(sqlHeader, conn, tr)
                    cmdH.Parameters.AddWithValue("@no", currentNoTransfer)
                    cmdH.Parameters.AddWithValue("@tgl", tglHeader)
                    cmdH.Parameters.AddWithValue("@asal", idAsal)
                    cmdH.Parameters.AddWithValue("@tujuan", idTujuan)
                    cmdH.Parameters.AddWithValue("@ket", If(ketHeader = "", DBNull.Value, ketHeader))
                    idHeader = Convert.ToInt32(cmdH.ExecuteScalar())
                End Using

                ' 2) DETAIL + UPDATE STOK
                For Each r As DataRow In dtList.Rows
                    Dim idBarang As Integer = CInt(r("id_barang"))
                    Dim qty As Integer = CInt(r("qty"))

                    ' cek stok asal (biar aman)
                    Dim stokAsal As Integer = GetStok(conn, tr, idBarang, idAsal)
                    If stokAsal < qty Then
                        Throw New Exception("Stok gudang asal tidak cukup untuk barang ID " & idBarang &
                                            ". Stok: " & stokAsal & ", Qty: " & qty)
                    End If

                    ' insert detail
                    Dim sqlD As String = "INSERT INTO transfer_gudang_detail(id_header, id_barang, qty) VALUES(@h, @b, @q)"
                    Using cmdD As New MySqlCommand(sqlD, conn, tr)
                        cmdD.Parameters.AddWithValue("@h", idHeader)
                        cmdD.Parameters.AddWithValue("@b", idBarang)
                        cmdD.Parameters.AddWithValue("@q", qty)
                        cmdD.ExecuteNonQuery()
                    End Using

                    ' kurangi stok asal
                    Dim sqlKurang As String = "UPDATE stok_gudang SET stok = stok - @q WHERE id_barang=@b AND id_gudang=@g"
                    Using cmdK As New MySqlCommand(sqlKurang, conn, tr)
                        cmdK.Parameters.AddWithValue("@q", qty)
                        cmdK.Parameters.AddWithValue("@b", idBarang)
                        cmdK.Parameters.AddWithValue("@g", idAsal)
                        cmdK.ExecuteNonQuery()
                    End Using

                    ' tambah stok tujuan (kalau belum ada row, insert baru)
                    Dim sqlTambah As String =
                        "INSERT INTO stok_gudang(id_barang, id_gudang, stok) VALUES(@b, @g, @q) " &
                        "ON DUPLICATE KEY UPDATE stok = stok + @q"
                    Using cmdT As New MySqlCommand(sqlTambah, conn, tr)
                        cmdT.Parameters.AddWithValue("@b", idBarang)
                        cmdT.Parameters.AddWithValue("@g", idTujuan)
                        cmdT.Parameters.AddWithValue("@q", qty)
                        cmdT.ExecuteNonQuery()
                    End Using
                Next

                tr.Commit()

                MessageBox.Show("Transfer antar gudang berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' reset untuk transaksi berikutnya
                dtList.Rows.Clear()
                cbBarang.SelectedIndex = -1
                nudQty.Value = 1
                BuatNoTransfer()

            Catch ex As Exception
                Try
                    tr.Rollback()
                Catch
                End Try
                MessageBox.Show("Gagal simpan transfer: " & ex.Message)
            End Try
        End Using
    End Sub

    ' =========================================================
    '  REFRESH
    ' =========================================================
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            dtList.Rows.Clear()
            LoadGudang()
            LoadBarang()
            BuatNoTransfer()
            nudQty.Value = 1
            MessageBox.Show("Data berhasil di-refresh.")
        Catch ex As Exception
            MessageBox.Show("Gagal refresh: " & ex.Message)
        End Try
    End Sub

    ' ================= KEMBALI =================
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form1.Show()
        Form1.BringToFront()
        Me.Hide()
    End Sub

End Class
