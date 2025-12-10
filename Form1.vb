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
        Me.WindowState = FormWindowState.Maximized
        Me.AutoScaleMode = AutoScaleMode.Dpi
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.AutoScaleDimensions = New SizeF(96.0F, 96.0F)


        lblUser.Text = " " & loggedUser
        Me.BackgroundImageLayout = ImageLayout.Stretch

        Timer1.Start()
    End Sub

    '===============================
    ' Sub untuk membuka menu sesuai role
    '===============================
    Public Sub BukaMenuBerdasarkanRole()

        Dim role As String = lblRole.Text.Trim.ToLower()

        If role = "" Then Exit Sub 'Belum login

        If role = "petugas" Then

            StokBarangToolStripMenuItem.Enabled = True
            TransaksiMasukToolStripMenuItem.Enabled = True
            TransaksiKeluarToolStripMenuItem.Enabled = True
            LogoutToolStripMenuItem1.Enabled = True

            'Petugas tidak boleh akses:
            EditStokBarangToolStripMenuItem.Enabled = False
            LaporanMasukKeluarToolStripMenuItem.Enabled = False
            datamaster.Enabled = False
            MasterKategoriToolStripMenuItem.Enabled = False
            MasterSuplierToolStripMenuItem.Enabled = False
            TransferAntarGudangToolStripMenuItem.Enabled = False
            usermanagement.Enabled = False
            StockOpnameToolStripMenuItem.Enabled = False
            MasterGudangToolStripMenuItem.Enabled = False

        ElseIf role = "admin" Then

            'Admin boleh semua
            EditStokBarangToolStripMenuItem.Enabled = True
            StokBarangToolStripMenuItem.Enabled = True
            TransaksiMasukToolStripMenuItem.Enabled = True
            TransaksiKeluarToolStripMenuItem.Enabled = True
            LaporanMasukKeluarToolStripMenuItem.Enabled = True
            LogoutToolStripMenuItem1.Enabled = True
            datamaster.Enabled = True
            MasterKategoriToolStripMenuItem.Enabled = True
            MasterSuplierToolStripMenuItem.Enabled = True
            TransferAntarGudangToolStripMenuItem.Enabled = True
            usermanagement.Enabled = True
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblJam.Text = Format(Now, "HH:mm:ss")
    End Sub

    Private Sub StockOpnameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockOpnameToolStripMenuItem.Click
        fromstockopname.Show() : Hide()
    End Sub

    Private Sub MasterGudangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterGudangToolStripMenuItem.Click
        fromstockopname.Show() : Hide()
    End Sub
End Class
