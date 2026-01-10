Imports MySql.Data.MySqlClient

Public Class FormTransaksiMasuk

    ' ===== DB =====
    Private Conn As MySqlConnection
    Private ReadOnly ConnStr As String =
        "server=127.0.0.1;user id=root;password=;database=inventory;"

    ' ===== untuk simpan id header transaksi yang sedang berjalan =====
    Private currentHeaderId As Long = 0

    ' ===== list untuk grid kanan (tampilan saja) =====
    Private dtList As DataTable

    Private Sub FormTransaksiMasuk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            OpenConn()
            LoadCombo()
            SetupGridList()

            dtTanggal.Value = DateTime.Now
            nudQty.Value = 0
            BuatNoDokumen()
        Catch ex As Exception
            MessageBox.Show("Gagal load form: " & ex.Message)
        End Try
    End Sub

    ' =========================
    ' OPEN CONNECTION
    ' =========================
    Private Sub OpenConn()
        If Conn Is Nothing Then Conn = New MySqlConnection(ConnStr)
        If Conn.State <> ConnectionState.Open Then Conn.Open()
    End Sub

    ' =========================
    ' GET DATATABLE
    ' =========================
    Private Function GetDataTable(sql As String) As DataTable
        OpenConn()
        Using da As New MySqlDataAdapter(sql, Conn)
            Dim dt As New DataTable()
            da.Fill(dt)
            Return dt
        End Using
    End Function

    ' =========================
    ' EXEC SCALAR
    ' =========================
    Private Function ExecScalar(sql As String) As Object
        OpenConn()
        Using cmd As New MySqlCommand(sql, Conn)
            Return cmd.ExecuteScalar()
        End Using
    End Function

    ' =========================
    ' LOAD COMBO (sesuai struktur tabel kamu)
    ' =========================
    Private Sub LoadCombo()
        ' supplier: id, nama_supplier
        Dim dtSup = GetDataTable("SELECT id, nama_supplier FROM supplier ORDER BY nama_supplier")
        cbSupplier.DataSource = dtSup
        cbSupplier.DisplayMember = "nama_supplier"
        cbSupplier.ValueMember = "id"
        cbSupplier.SelectedIndex = -1

        ' gudang: id, nama_gudang
        Dim dtGud = GetDataTable("SELECT id, nama_gudang FROM gudang ORDER BY nama_gudang")
        cbGudang.DataSource = dtGud
        cbGudang.DisplayMember = "nama_gudang"
        cbGudang.ValueMember = "id"
        cbGudang.SelectedIndex = -1

        ' barang: id, kode_barang, nama_barang
        Dim dtBrg = GetDataTable("
            SELECT id, CONCAT(kode_barang,' - ',nama_barang) AS tampil
            FROM barang
            ORDER BY nama_barang
        ")
        cbBarang.DataSource = dtBrg
        cbBarang.DisplayMember = "tampil"
        cbBarang.ValueMember = "id"
        cbBarang.SelectedIndex = -1
    End Sub

    ' =========================
    ' SETUP GRID LIST (tampilan)
    ' =========================
    Private Sub SetupGridList()
        dtList = New DataTable()
        dtList.Columns.Add("no_dokumen", GetType(String))
        dtList.Columns.Add("tanggal", GetType(Date))
        dtList.Columns.Add("supplier", GetType(String))
        dtList.Columns.Add("gudang", GetType(String))
        dtList.Columns.Add("keterangan", GetType(String))
        dtList.Columns.Add("id_barang", GetType(Integer))
        dtList.Columns.Add("barang", GetType(String))
        dtList.Columns.Add("qty", GetType(Integer))

        dgList.DataSource = dtList
        dgList.AllowUserToAddRows = False
        dgList.ReadOnly = True
        dgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        dgList.Columns("id_barang").Visible = False

        dgList.Columns("no_dokumen").HeaderText = "No Dokumen"
        dgList.Columns("tanggal").HeaderText = "Tanggal"
        dgList.Columns("supplier").HeaderText = "Supplier"
        dgList.Columns("gudang").HeaderText = "Gudang"
        dgList.Columns("keterangan").HeaderText = "Keterangan"
        dgList.Columns("barang").HeaderText = "Barang"
        dgList.Columns("qty").HeaderText = "Qty"
    End Sub


    ' =========================
    ' GENERATE NO DOKUMEN: BM-YYYYMMDD-0001
    ' =========================
    Private Sub BuatNoDokumen()
        Dim today As String = DateTime.Now.ToString("yyyyMMdd")

        Dim terakhirObj = ExecScalar("
            SELECT IFNULL(MAX(RIGHT(no_dokumen,4)),0)
            FROM barang_masuk
            WHERE no_dokumen LIKE '" & today & "-%';
        ")

        Dim urut As Integer = CInt(terakhirObj) + 1
        txtNoDokumen.Text = "" & today & "" & urut.ToString("")
    End Sub

    ' =========================
    ' BUAT HEADER SEKALI (saat klik tambah pertama)
    ' =========================
    Private Sub PastikanHeaderAda()
        If currentHeaderId <> 0 Then Exit Sub

        ' validasi header
        If txtNoDokumen.Text.Trim() = "" Then Throw New Exception("Nomor dokumen wajib diisi.")
        If cbSupplier.SelectedIndex = -1 OrElse cbSupplier.SelectedValue Is Nothing Then Throw New Exception("Supplier wajib dipilih.")
        If cbGudang.SelectedIndex = -1 OrElse cbGudang.SelectedValue Is Nothing Then Throw New Exception("Gudang wajib dipilih.")

        ' insert header
        Using cmd As New MySqlCommand("
            INSERT INTO barang_masuk(no_dokumen, tanggal, id_supplier, id_gudang, keterangan)
            VALUES(@no, @tgl, @sup, @gud, @ket);", Conn)

            cmd.Parameters.AddWithValue("@no", txtNoDokumen.Text.Trim())
            cmd.Parameters.AddWithValue("@tgl", dtTanggal.Value.Date)
            cmd.Parameters.AddWithValue("@sup", CInt(cbSupplier.SelectedValue))
            cmd.Parameters.AddWithValue("@gud", CInt(cbGudang.SelectedValue))
            cmd.Parameters.AddWithValue("@ket", txtKeterangan.Text.Trim())

            cmd.ExecuteNonQuery()
            currentHeaderId = cmd.LastInsertedId
        End Using

        ' setelah header tersimpan, kunci input header biar tidak berubah
        txtNoDokumen.Enabled = False
        dtTanggal.Enabled = False
        cbSupplier.Enabled = False
        cbGudang.Enabled = False
        txtKeterangan.Enabled = False
    End Sub

    ' =========================
    ' TAMBAH KE LIST (AUTO SIMPAN KE DB)
    ' =========================
    Private Sub btnTambahKeList_Click(sender As Object, e As EventArgs) Handles btnTambahKeList.Click
        Try
            OpenConn()

            If cbBarang.SelectedIndex = -1 OrElse cbBarang.SelectedValue Is Nothing Then
                MessageBox.Show("Pilih barang dulu.")
                Exit Sub
            End If

            Dim qty As Integer = CInt(nudQty.Value)
            If qty <= 0 Then
                MessageBox.Show("Qty harus lebih dari 0.")
                Exit Sub
            End If

            ' 1) pastikan header sudah ada (kalau belum, insert dulu)
            PastikanHeaderAda()

            Dim idBarang As Integer = CInt(cbBarang.SelectedValue)
            Dim namaBarang As String = cbBarang.Text

            ' 2) simpan detail ke DB (kalau sudah ada, UPDATE qty; kalau belum, INSERT)
            Dim ada As Integer
            Using cek As New MySqlCommand("
                SELECT COUNT(*) FROM barang_masuk_detail
                WHERE id_header=@h AND id_barang=@b;", Conn)
                cek.Parameters.AddWithValue("@h", currentHeaderId)
                cek.Parameters.AddWithValue("@b", idBarang)
                ada = CInt(cek.ExecuteScalar())
            End Using

            If ada > 0 Then
                Using upd As New MySqlCommand("
                    UPDATE barang_masuk_detail
                    SET qty = qty + @qty
                    WHERE id_header=@h AND id_barang=@b;", Conn)
                    upd.Parameters.AddWithValue("@qty", qty)
                    upd.Parameters.AddWithValue("@h", currentHeaderId)
                    upd.Parameters.AddWithValue("@b", idBarang)
                    upd.ExecuteNonQuery()
                End Using
            Else
                Using ins As New MySqlCommand("
                    INSERT INTO barang_masuk_detail(id_header, id_barang, qty)
                    VALUES(@h, @b, @qty);", Conn)
                    ins.Parameters.AddWithValue("@h", currentHeaderId)
                    ins.Parameters.AddWithValue("@b", idBarang)
                    ins.Parameters.AddWithValue("@qty", qty)
                    ins.ExecuteNonQuery()
                End Using
            End If

            ' 3) update grid tampilan (dtList)
            Dim ketemu As Boolean = False
            For Each r As DataRow In dtList.Rows
                If CInt(r("id_barang")) = idBarang Then
                    r("qty") = CInt(r("qty")) + qty
                    ketemu = True
                    Exit For
                End If
            Next
            If Not ketemu Then
                dtList.Rows.Add(idBarang, namaBarang, qty)
            End If

            nudQty.Value = 0
            MessageBox.Show("Barang berhasil ditambahkan & tersimpan ke database.")

        Catch ex As Exception
            MessageBox.Show("Gagal tambah: " & ex.Message)
        End Try
    End Sub

    ' =========================
    ' KEMBALI
    ' =========================
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        ' data sudah auto-simpan per klik Tambah ke list
        Form1.Show()
        Me.Hide()
    End Sub

End Class
