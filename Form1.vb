Imports System.DirectoryServices.ActiveDirectory

Public Class Form1
    Public loggedUser As String

    Private Sub LOGINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGINToolStripMenuItem.Click
        FormLogin.Show()
        Hide()
    End Sub

    '===============================
    ' Kunci Semua Menu
    '===============================
    Public Sub KunciMenu()
        EditStokBarangToolStripMenuItem.Enabled = False
        StokBarangToolStripMenuItem.Enabled = False
        TransaksiMasukToolStripMenuItem.Enabled = False
        TransaksiKeluarToolStripMenuItem.Enabled = False
        LaporanMasukKeluarToolStripMenuItem.Enabled = False
        LogoutToolStripMenuItem1.Enabled = False
        datamaster.Enabled = False
        MasterKategoriToolStripMenuItem.Enabled = False
        MasterSuplierToolStripMenuItem.Enabled = False
        TransferAntarGudangToolStripMenuItem.Enabled = False
        usermanagement.Enabled = False
        StockOpnameToolStripMenuItem.Enabled = False
        MasterGudangToolStripMenuItem.Enabled = False
    End Sub

    '===============================
    ' Form Load
    '===============================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KunciMenu()
        Me.AutoScaleMode = AutoScaleMode.None
        Me.WindowState = FormWindowState.Maximized
        'Me.AutoScaleMode = AutoScaleMode.Dpi
        Me.AutoSizeMode = AutoSizeMode.GrowOnly

        'Me.AutoScaleDimensions = New SizeF(96.0F, 96.0F)


        Call Koneksi()
        LoadDashboard()

        lblUser.Text = " " & loggedUser
        Me.BackgroundImageLayout = ImageLayout.Stretch


    End Sub

    '===============================
    ' Sub untuk membuka menu sesuai role
    '===============================
    Sub LoadDashboard()

        ' TOTAL ITEM
        lblTotalItem.Text = ExecScalar("SELECT IFNULL(SUM(stok_min),0) FROM barang")


        ' ===============================
        ' STOK AMAN (stok > stok_min)
        ' ===============================
        lblStokAman.Text = ExecScalar("
    SELECT COUNT(*) 
FROM barang b
WHERE
(
   (SELECT IFNULL(SUM(qty),0) FROM barang_masuk_detail WHERE id_barang=b.id)
 -
   (SELECT IFNULL(SUM(qty),0) FROM barang_keluar_detail WHERE id_barang=b.id)
) >= b.stok_min

")


        ' ===============================
        ' STOK MENIPIS (stok <= stok_min)
        ' ===============================
        lblStokMenipis.Text = ExecScalar("
   SELECT COUNT(*) 
FROM barang b
WHERE
(
   (SELECT IFNULL(SUM(qty),0) FROM barang_masuk_detail WHERE id_barang=b.id)
 -
   (SELECT IFNULL(SUM(qty),0) FROM barang_keluar_detail WHERE id_barang=b.id)
) < b.stok_min

")




        ' BARANG MASUK HARI INI
        lblMasukHariIni.Text = ExecScalar("
            SELECT COUNT(*) FROM barang_masuk WHERE tanggal = CURDATE()
        ")

        ' BARANG KELUAR HARI INI
        lblKeluarHariIni.Text = ExecScalar("
            SELECT COUNT(*) FROM barang_keluar WHERE tanggal = CURDATE()
        ")

        ' TRANSFER ANTAR GUDANG HARI INI
        lblTransferHariIni.Text = ExecScalar("
            SELECT COUNT(*) FROM transfer_gudang WHERE tanggal = CURDATE()
        ")

        LoadGrid(dgStokMenipis, "
    SELECT 
        b.kode_barang,
        b.nama_barang,
        b.stok_min
    FROM barang b
    WHERE b.stok_min > 0
    ORDER BY b.stok_min ASC
")




        ' GRID TRANSAKSI TERAKHIR
        LoadGrid(dgTransaksiTerakhir, "
            SELECT 'Masuk' AS jenis, tanggal, no_dokumen FROM barang_masuk
            UNION ALL
            SELECT 'Keluar', tanggal, no_dokumen FROM barang_keluar
            ORDER BY tanggal DESC
            LIMIT 10
        ")

    End Sub

    Public Sub BukaMenuBerdasarkanRole()

        Dim role As String = lblRole.Text.Trim.ToLower()

        If role = "" Then Exit Sub 'Belum login

        If role = "petugas" Then

            StokBarangToolStripMenuItem.Enabled = True
            TransaksiMasukToolStripMenuItem.Enabled = True
            TransaksiKeluarToolStripMenuItem.Enabled = True
            LogoutToolStripMenuItem1.Enabled = True

            'Petugas tidak boleh akses:
            EditStokBarangToolStripMenuItem.Visible = False
            LaporanMasukKeluarToolStripMenuItem.Enabled = False
            datamaster.Enabled = False
            MasterKategoriToolStripMenuItem.Enabled = False
            MasterSuplierToolStripMenuItem.Enabled = False
            TransferAntarGudangToolStripMenuItem.Enabled = False
            usermanagement.Visible = False
            StockOpnameToolStripMenuItem.Enabled = False
            MasterGudangToolStripMenuItem.Enabled = False

        ElseIf role = "admin" Then

            'Admin boleh semua
            EditStokBarangToolStripMenuItem.Visible = True
            StokBarangToolStripMenuItem.Enabled = True
            TransaksiMasukToolStripMenuItem.Enabled = True
            TransaksiKeluarToolStripMenuItem.Enabled = True
            LaporanMasukKeluarToolStripMenuItem.Enabled = True
            LogoutToolStripMenuItem1.Enabled = True
            datamaster.Enabled = True
            MasterKategoriToolStripMenuItem.Enabled = True
            MasterSuplierToolStripMenuItem.Enabled = True
            TransferAntarGudangToolStripMenuItem.Enabled = True
            usermanagement.Visible = True
            StockOpnameToolStripMenuItem.Enabled = True
            MasterGudangToolStripMenuItem.Enabled = True
        End If

    End Sub

    '===============================
    ' Menu Navigation
    '===============================
    Private Sub StokBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokBarangToolStripMenuItem.Click
        FormStokBarang.Show() : Hide()
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem1.Click
        KunciMenu()
        FormLogin.Show()
        Hide()
    End Sub

    Private Sub TransaksiMasukToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiMasukToolStripMenuItem.Click
        FormTransaksiMasuk.Show() : Hide()
    End Sub

    Private Sub TransaksiKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransaksiKeluarToolStripMenuItem.Click
        fromTransaksiKeluar.Show() : Hide()
    End Sub

    Private Sub LaporanMasukKeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanMasukKeluarToolStripMenuItem.Click
        FromLaporan.Show() : Hide()
    End Sub

    Private Sub EditStokBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditStokBarangToolStripMenuItem.Click
        FromEditStok.Show() : Hide()
    End Sub

    Private Sub MasterKategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterKategoriToolStripMenuItem.Click
        fromMasterKategori.Show() : Hide()
    End Sub

    Private Sub MasterSuplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterSuplierToolStripMenuItem.Click
        formMasterSuplier.Show() : Hide()
    End Sub

    Private Sub MasterBarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterBarangToolStripMenuItem.Click
        fromMasterBarang.Show() : Hide()
    End Sub

    Private Sub TransferAntarGudangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransferAntarGudangToolStripMenuItem.Click
        FromTransferAntarGudang.Show() : Hide()
    End Sub

    Private Sub usermanagement_Click(sender As Object, e As EventArgs) Handles usermanagement.Click
        fromusermanagemen.Show() : Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        lblJam.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub StockOpnameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockOpnameToolStripMenuItem.Click
        fromstockopname.Show() : Hide()
    End Sub

    Private Sub MasterGudangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterGudangToolStripMenuItem.Click
        fromMastergudang.Show() : Hide()
    End Sub

    Private Sub TimerDashboard_Tick(sender As Object, e As EventArgs) Handles TimerDashboard.Tick
        LoadDashboard()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormTransaksiMasuk.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        fromTransaksiKeluar.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormStokBarang.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FromLaporan.Show()
        Me.Hide()
    End Sub

    Private Sub StokGudangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StokGudangToolStripMenuItem.Click
        formStokGudang.Show() : Hide()
    End Sub

    Private Sub datamaster_Click(sender As Object, e As EventArgs) Handles datamaster.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
