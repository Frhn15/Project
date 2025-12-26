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
        Panel8 = New Panel()
        Panel9 = New Panel()
        Panel2 = New Panel()
        Panel13 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Panel11 = New Panel()
        Panel14 = New Panel()
        PanelTransaksiTerakhir = New Panel()
        DataGridView2 = New DataGridView()
        PanelStokMenipis = New Panel()
        DataGridView1 = New DataGridView()
        Panel10 = New Panel()
        Panel12 = New Panel()
        PictureBox2 = New PictureBox()
        TotalBarang = New Label()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel7.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel4.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        Panel2.SuspendLayout()
        Panel13.SuspendLayout()
        Panel11.SuspendLayout()
        PanelTransaksiTerakhir.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        PanelStokMenipis.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(225), CByte(216), CByte(203))
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
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
        Panel1.BackColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        Panel1.Location = New Point(0, 74)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1952, 65)
        Panel1.TabIndex = 2
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
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
        PictureBox1.BackColor = Color.FromArgb(CByte(225), CByte(216), CByte(203))
        PictureBox1.ErrorImage = Nothing
        PictureBox1.Image = My.Resources.Resources.logo_hitam_60x60
        PictureBox1.Location = New Point(29, 8)
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
        Panel7.BackColor = Color.FromArgb(CByte(225), CByte(216), CByte(203))
        Panel7.Controls.Add(PictureBox4)
        Panel7.ForeColor = Color.White
        Panel7.Location = New Point(1384, 10)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(420, 120)
        Panel7.TabIndex = 3
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        Panel6.Controls.Add(PictureBox6)
        Panel6.Location = New Point(944, 10)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(420, 120)
        Panel6.TabIndex = 2
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(225), CByte(216), CByte(203))
        Panel5.Controls.Add(PictureBox3)
        Panel5.Location = New Point(504, 10)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(420, 120)
        Panel5.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(225), CByte(216), CByte(203))
        Panel4.Controls.Add(TotalBarang)
        Panel4.Controls.Add(PictureBox2)
        Panel4.ForeColor = Color.Black
        Panel4.Location = New Point(64, 10)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(420, 120)
        Panel4.TabIndex = 0
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(225), CByte(216), CByte(203))
        Panel8.Controls.Add(PictureBox5)
        Panel8.ForeColor = Color.White
        Panel8.Location = New Point(1396, 292)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(420, 120)
        Panel8.TabIndex = 4
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(225), CByte(216), CByte(203))
        Panel9.Controls.Add(PictureBox7)
        Panel9.ForeColor = Color.White
        Panel9.Location = New Point(1396, 432)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(420, 120)
        Panel9.TabIndex = 5
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Panel2.Controls.Add(Panel13)
        Panel2.Controls.Add(Panel11)
        Panel2.Controls.Add(PanelTransaksiTerakhir)
        Panel2.Controls.Add(PanelStokMenipis)
        Panel2.Controls.Add(Panel10)
        Panel2.Controls.Add(Panel9)
        Panel2.Controls.Add(Panel8)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(MenuStrip1)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Panel12)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1902, 1033)
        Panel2.TabIndex = 10
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.FromArgb(CByte(225), CByte(216), CByte(203))
        Panel13.Controls.Add(Button4)
        Panel13.Controls.Add(Button3)
        Panel13.Controls.Add(Button2)
        Panel13.Controls.Add(Button1)
        Panel13.Location = New Point(1396, 938)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(421, 74)
        Panel13.TabIndex = 10
        ' 
        ' Button4
        ' 
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Location = New Point(312, 9)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 56)
        Button4.TabIndex = 3
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Location = New Point(210, 9)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 56)
        Button3.TabIndex = 2
        Button3.Text = "Button3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Location = New Point(110, 9)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 56)
        Button2.TabIndex = 1
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(10, 9)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 56)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.FromArgb(CByte(225), CByte(216), CByte(203))
        Panel11.Controls.Add(Panel14)
        Panel11.Location = New Point(1396, 710)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(421, 205)
        Panel11.TabIndex = 9
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Panel14.Location = New Point(15, 64)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(391, 125)
        Panel14.TabIndex = 0
        ' 
        ' PanelTransaksiTerakhir
        ' 
        PanelTransaksiTerakhir.BackColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        PanelTransaksiTerakhir.Controls.Add(DataGridView2)
        PanelTransaksiTerakhir.Location = New Point(741, 750)
        PanelTransaksiTerakhir.Name = "PanelTransaksiTerakhir"
        PanelTransaksiTerakhir.Size = New Size(635, 262)
        PanelTransaksiTerakhir.TabIndex = 8
        ' 
        ' DataGridView2
        ' 
        DataGridView2.BackgroundColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.EnableHeadersVisualStyles = False
        DataGridView2.GridColor = Color.FromArgb(CByte(167), CByte(165), CByte(156))
        DataGridView2.Location = New Point(0, 59)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(635, 203)
        DataGridView2.TabIndex = 0
        ' 
        ' PanelStokMenipis
        ' 
        PanelStokMenipis.BackColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        PanelStokMenipis.Controls.Add(DataGridView1)
        PanelStokMenipis.Location = New Point(85, 750)
        PanelStokMenipis.Name = "PanelStokMenipis"
        PanelStokMenipis.Size = New Size(635, 262)
        PanelStokMenipis.TabIndex = 7
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.GridColor = Color.FromArgb(CByte(167), CByte(163), CByte(156))
        DataGridView1.Location = New Point(0, 59)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(635, 203)
        DataGridView1.TabIndex = 0
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.FromArgb(CByte(225), CByte(216), CByte(203))
        Panel10.ForeColor = Color.White
        Panel10.Location = New Point(1396, 572)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(420, 120)
        Panel10.TabIndex = 6
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.FromArgb(CByte(225), CByte(216), CByte(203))
        Panel12.Location = New Point(0, 0)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(1952, 75)
        Panel12.TabIndex = 10
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Total_Barang1
        PictureBox2.Location = New Point(18, 20)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(80, 80)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' TotalBarang
        ' 
        TotalBarang.AutoSize = True
        TotalBarang.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TotalBarang.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        TotalBarang.Location = New Point(109, 20)
        TotalBarang.Name = "TotalBarang"
        TotalBarang.Size = New Size(118, 31)
        TotalBarang.TabIndex = 1
        TotalBarang.Text = "Total Item"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Stok_Aman
        PictureBox3.Location = New Point(19, 20)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(80, 80)
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.Barang_Masuk
        PictureBox4.Location = New Point(17, 19)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(80, 80)
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.Barang_Keluar
        PictureBox5.Location = New Point(17, 20)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(80, 80)
        PictureBox5.TabIndex = 4
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.warning
        PictureBox6.Location = New Point(18, 19)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(80, 80)
        PictureBox6.TabIndex = 3
        PictureBox6.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.Transfer_antar_gudang
        PictureBox7.Location = New Point(17, 20)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(80, 80)
        PictureBox7.TabIndex = 5
        PictureBox7.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(lblRole)
        Controls.Add(Label1)
        Controls.Add(lblJam)
        Controls.Add(lblUser)
        Controls.Add(Panel2)
        ForeColor = Color.Blue
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel9.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel13.ResumeLayout(False)
        Panel11.ResumeLayout(False)
        PanelTransaksiTerakhir.ResumeLayout(False)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        PanelStokMenipis.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents PanelTransaksiTerakhir As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents PanelStokMenipis As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TotalBarang As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox

End Class
