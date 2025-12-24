<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Timer1 = New Timer(components)
        lblJam = New Label()
        lblUser = New Label()
        lblRole = New Label()
        Panel1 = New Panel()
        MenuStrip1 = New MenuStrip()
        LOGINToolStripMenuItem = New ToolStripMenuItem()
        datamaster = New ToolStripMenuItem()
        MasterKategoriToolStripMenuItem = New ToolStripMenuItem()
        MasterSuplierToolStripMenuItem = New ToolStripMenuItem()
        MasterBarangToolStripMenuItem = New ToolStripMenuItem()
        MasterGudangToolStripMenuItem = New ToolStripMenuItem()
        StockOpnameToolStripMenuItem = New ToolStripMenuItem()
        StokBarangToolStripMenuItem = New ToolStripMenuItem()
        TransaksiMasukToolStripMenuItem = New ToolStripMenuItem()
        TransaksiKeluarToolStripMenuItem = New ToolStripMenuItem()
        EditStokBarangToolStripMenuItem = New ToolStripMenuItem()
        TransferAntarGudangToolStripMenuItem = New ToolStripMenuItem()
        LaporanMasukKeluarToolStripMenuItem = New ToolStripMenuItem()
        usermanagement = New ToolStripMenuItem()
        LogoutToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Panel7 = New Panel()
        Panel6 = New Panel()
        Panel5 = New Panel()
        Panel4 = New Panel()
        PanelGrafik = New Panel()
        Panel8 = New Panel()
        Panel9 = New Panel()
        Panel2 = New Panel()
        Panel11 = New Panel()
        PanelTransaksiTerakhir = New Panel()
        PanelStokMenipis = New Panel()
        Panel10 = New Panel()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(103, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(329, 41)
        Label1.TabIndex = 3
        Label1.Text = "INVENTORY GUDANG"
        ' 
        ' Timer1
        ' 
        ' 
        ' lblJam
        ' 
        lblJam.AutoSize = True
        lblJam.ForeColor = Color.Black
        lblJam.Location = New Point(0, 0)
        lblJam.Name = "lblJam"
        lblJam.Size = New Size(0, 20)
        lblJam.TabIndex = 6
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.ForeColor = Color.Black
        lblUser.Location = New Point(251, 60)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(0, 20)
        lblUser.TabIndex = 5
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.ForeColor = Color.Black
        lblRole.Location = New Point(251, 59)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(0, 20)
        lblRole.TabIndex = 7
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Location = New Point(0, 74)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1952, 65)
        Panel1.TabIndex = 2
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Black
        MenuStrip1.BackgroundImageLayout = ImageLayout.Stretch
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {LOGINToolStripMenuItem, datamaster, StokBarangToolStripMenuItem, TransaksiMasukToolStripMenuItem, TransaksiKeluarToolStripMenuItem, EditStokBarangToolStripMenuItem, TransferAntarGudangToolStripMenuItem, LaporanMasukKeluarToolStripMenuItem, usermanagement, LogoutToolStripMenuItem1, ToolStripMenuItem1})
        MenuStrip1.Location = New Point(110, 90)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(12, 0, 6, 0)
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(1627, 29)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' LOGINToolStripMenuItem
        ' 
        LOGINToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        LOGINToolStripMenuItem.ForeColor = Color.White
        LOGINToolStripMenuItem.Margin = New Padding(5, 0, 5, 0)
        LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        LOGINToolStripMenuItem.Padding = New Padding(10, 0, 4, 0)
        LOGINToolStripMenuItem.Size = New Size(77, 29)
        LOGINToolStripMenuItem.Text = "Login"
        ' 
        ' datamaster
        ' 
        datamaster.DropDownItems.AddRange(New ToolStripItem() {MasterKategoriToolStripMenuItem, MasterSuplierToolStripMenuItem, MasterBarangToolStripMenuItem, MasterGudangToolStripMenuItem, StockOpnameToolStripMenuItem})
        datamaster.ForeColor = Color.White
        datamaster.Name = "datamaster"
        datamaster.Size = New Size(130, 29)
        datamaster.Text = "Data Master"
        ' 
        ' MasterKategoriToolStripMenuItem
        ' 
        MasterKategoriToolStripMenuItem.Name = "MasterKategoriToolStripMenuItem"
        MasterKategoriToolStripMenuItem.Size = New Size(235, 30)
        MasterKategoriToolStripMenuItem.Text = "Master Kategori"
        ' 
        ' MasterSuplierToolStripMenuItem
        ' 
        MasterSuplierToolStripMenuItem.Name = "MasterSuplierToolStripMenuItem"
        MasterSuplierToolStripMenuItem.Size = New Size(235, 30)
        MasterSuplierToolStripMenuItem.Text = "Master Suplier"
        ' 
        ' MasterBarangToolStripMenuItem
        ' 
        MasterBarangToolStripMenuItem.Name = "MasterBarangToolStripMenuItem"
        MasterBarangToolStripMenuItem.Size = New Size(235, 30)
        MasterBarangToolStripMenuItem.Text = "Master barang"
        ' 
        ' MasterGudangToolStripMenuItem
        ' 
        MasterGudangToolStripMenuItem.Name = "MasterGudangToolStripMenuItem"
        MasterGudangToolStripMenuItem.Size = New Size(235, 30)
        MasterGudangToolStripMenuItem.Text = "Master Gudang"
        ' 
        ' StockOpnameToolStripMenuItem
        ' 
        StockOpnameToolStripMenuItem.Name = "StockOpnameToolStripMenuItem"
        StockOpnameToolStripMenuItem.Size = New Size(235, 30)
        StockOpnameToolStripMenuItem.Text = "Stock Opname"
        ' 
        ' StokBarangToolStripMenuItem
        ' 
        StokBarangToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        StokBarangToolStripMenuItem.ForeColor = Color.White
        StokBarangToolStripMenuItem.Name = "StokBarangToolStripMenuItem"
        StokBarangToolStripMenuItem.Size = New Size(130, 29)
        StokBarangToolStripMenuItem.Text = "Stok Barang"
        ' 
        ' TransaksiMasukToolStripMenuItem
        ' 
        TransaksiMasukToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        TransaksiMasukToolStripMenuItem.ForeColor = Color.White
        TransaksiMasukToolStripMenuItem.Name = "TransaksiMasukToolStripMenuItem"
        TransaksiMasukToolStripMenuItem.Size = New Size(166, 29)
        TransaksiMasukToolStripMenuItem.Text = "Transaksi Masuk"
        ' 
        ' TransaksiKeluarToolStripMenuItem
        ' 
        TransaksiKeluarToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        TransaksiKeluarToolStripMenuItem.ForeColor = Color.White
        TransaksiKeluarToolStripMenuItem.Name = "TransaksiKeluarToolStripMenuItem"
        TransaksiKeluarToolStripMenuItem.Size = New Size(165, 29)
        TransaksiKeluarToolStripMenuItem.Text = "Transaksi Keluar"
        ' 
        ' EditStokBarangToolStripMenuItem
        ' 
        EditStokBarangToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        EditStokBarangToolStripMenuItem.ForeColor = Color.White
        EditStokBarangToolStripMenuItem.Name = "EditStokBarangToolStripMenuItem"
        EditStokBarangToolStripMenuItem.Size = New Size(168, 29)
        EditStokBarangToolStripMenuItem.Text = "Edit Stok Barang"
        ' 
        ' TransferAntarGudangToolStripMenuItem
        ' 
        TransferAntarGudangToolStripMenuItem.ForeColor = Color.White
        TransferAntarGudangToolStripMenuItem.Name = "TransferAntarGudangToolStripMenuItem"
        TransferAntarGudangToolStripMenuItem.Size = New Size(221, 29)
        TransferAntarGudangToolStripMenuItem.Text = "Transfer Antar Gudang"
        ' 
        ' LaporanMasukKeluarToolStripMenuItem
        ' 
        LaporanMasukKeluarToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        LaporanMasukKeluarToolStripMenuItem.ForeColor = Color.White
        LaporanMasukKeluarToolStripMenuItem.Name = "LaporanMasukKeluarToolStripMenuItem"
        LaporanMasukKeluarToolStripMenuItem.Size = New Size(253, 29)
        LaporanMasukKeluarToolStripMenuItem.Text = "Laporan Masuk dan Keluar"
        ' 
        ' usermanagement
        ' 
        usermanagement.ForeColor = Color.White
        usermanagement.Name = "usermanagement"
        usermanagement.Size = New Size(182, 29)
        usermanagement.Text = "User Management"
        ' 
        ' LogoutToolStripMenuItem1
        ' 
        LogoutToolStripMenuItem1.BackgroundImageLayout = ImageLayout.Stretch
        LogoutToolStripMenuItem1.ForeColor = Color.Crimson
        LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        LogoutToolStripMenuItem1.RightToLeft = RightToLeft.No
        LogoutToolStripMenuItem1.Size = New Size(91, 29)
        LogoutToolStripMenuItem1.Text = "Log out"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(14, 29)
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = My.Resources.Resources.logo_hitam_60x60
        PictureBox1.Location = New Point(40, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(60, 60)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Panel7)
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Panel5)
        Panel3.Controls.Add(Panel4)
        Panel3.Location = New Point(12, 141)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1880, 140)
        Panel3.TabIndex = 0
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.SteelBlue
        Panel7.ForeColor = Color.White
        Panel7.Location = New Point(1376, 10)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(420, 120)
        Panel7.TabIndex = 3
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.IndianRed
        Panel6.Location = New Point(936, 10)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(420, 120)
        Panel6.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.SeaGreen
        Panel5.Location = New Point(496, 10)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(420, 120)
        Panel5.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.SeaGreen
        Panel4.Location = New Point(56, 10)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(420, 120)
        Panel4.TabIndex = 0
        ' 
        ' PanelGrafik
        ' 
        PanelGrafik.Location = New Point(12, 271)
        PanelGrafik.Name = "PanelGrafik"
        PanelGrafik.Size = New Size(1356, 420)
        PanelGrafik.TabIndex = 4
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.DarkOrange
        Panel8.ForeColor = Color.White
        Panel8.Location = New Point(1388, 291)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(420, 120)
        Panel8.TabIndex = 4
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.SteelBlue
        Panel9.ForeColor = Color.White
        Panel9.Location = New Point(1388, 431)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(420, 120)
        Panel9.TabIndex = 5
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel11)
        Panel2.Controls.Add(PanelTransaksiTerakhir)
        Panel2.Controls.Add(PanelStokMenipis)
        Panel2.Controls.Add(Panel10)
        Panel2.Controls.Add(Panel9)
        Panel2.Controls.Add(Panel8)
        Panel2.Controls.Add(PanelGrafik)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(MenuStrip1)
        Panel2.Controls.Add(Panel1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1902, 1033)
        Panel2.TabIndex = 10
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.Gainsboro
        Panel11.Location = New Point(1248, 713)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(560, 260)
        Panel11.TabIndex = 9
        ' 
        ' PanelTransaksiTerakhir
        ' 
        PanelTransaksiTerakhir.BackColor = Color.Gainsboro
        PanelTransaksiTerakhir.Location = New Point(657, 713)
        PanelTransaksiTerakhir.Name = "PanelTransaksiTerakhir"
        PanelTransaksiTerakhir.Size = New Size(560, 260)
        PanelTransaksiTerakhir.TabIndex = 8
        ' 
        ' PanelStokMenipis
        ' 
        PanelStokMenipis.BackColor = Color.Gainsboro
        PanelStokMenipis.Location = New Point(68, 713)
        PanelStokMenipis.Name = "PanelStokMenipis"
        PanelStokMenipis.Size = New Size(560, 260)
        PanelStokMenipis.TabIndex = 7
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.MidnightBlue
        Panel10.ForeColor = Color.White
        Panel10.Location = New Point(1388, 571)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(420, 120)
        Panel10.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(lblRole)
        Controls.Add(Label1)
        Controls.Add(lblJam)
        Controls.Add(lblUser)
        Controls.Add(Panel2)
        ForeColor = Color.BurlyWood
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents UserManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Public WithEvents Timer1 As Timer
    Friend WithEvents lblJam As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LOGINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents datamaster As ToolStripMenuItem
    Friend WithEvents MasterKategoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterSuplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterGudangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockOpnameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StokBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiKeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditStokBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransferAntarGudangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanMasukKeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents usermanagement As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PanelGrafik As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents PanelTransaksiTerakhir As Panel
    Friend WithEvents PanelStokMenipis As Panel

End Class
