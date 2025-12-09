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
        MenuStrip1 = New MenuStrip()
        LOGINToolStripMenuItem = New ToolStripMenuItem()
        datamaster = New ToolStripMenuItem()
        MasterKategoriToolStripMenuItem = New ToolStripMenuItem()
        MasterSuplierToolStripMenuItem = New ToolStripMenuItem()
        MasterBarangToolStripMenuItem = New ToolStripMenuItem()
        StokBarangToolStripMenuItem = New ToolStripMenuItem()
        TransaksiMasukToolStripMenuItem = New ToolStripMenuItem()
        TransaksiKeluarToolStripMenuItem = New ToolStripMenuItem()
        EditStokBarangToolStripMenuItem = New ToolStripMenuItem()
        TransferAntarGudangToolStripMenuItem = New ToolStripMenuItem()
        LaporanMasukKeluarToolStripMenuItem = New ToolStripMenuItem()
        usermanagement = New ToolStripMenuItem()
        LogoutToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        lblUser = New Label()
        Timer1 = New Timer(components)
        lblJam = New Label()
        lblRole = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.Transparent
        MenuStrip1.BackgroundImageLayout = ImageLayout.Stretch
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {LOGINToolStripMenuItem, datamaster, StokBarangToolStripMenuItem, TransaksiMasukToolStripMenuItem, TransaksiKeluarToolStripMenuItem, EditStokBarangToolStripMenuItem, TransferAntarGudangToolStripMenuItem, LaporanMasukKeluarToolStripMenuItem, usermanagement, LogoutToolStripMenuItem1, ToolStripMenuItem1, ToolStripMenuItem2, ToolStripMenuItem3})
        MenuStrip1.Location = New Point(211, 126)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(15, 0, 8, 0)
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(2164, 34)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' LOGINToolStripMenuItem
        ' 
        LOGINToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        LOGINToolStripMenuItem.ForeColor = Color.RoyalBlue
        LOGINToolStripMenuItem.Margin = New Padding(5, 0, 5, 0)
        LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        LOGINToolStripMenuItem.Padding = New Padding(10, 0, 4, 0)
        LOGINToolStripMenuItem.Size = New Size(98, 34)
        LOGINToolStripMenuItem.Text = "LOGIN"
        ' 
        ' datamaster
        ' 
        datamaster.DropDownItems.AddRange(New ToolStripItem() {MasterKategoriToolStripMenuItem, MasterSuplierToolStripMenuItem, MasterBarangToolStripMenuItem})
        datamaster.Name = "datamaster"
        datamaster.Size = New Size(157, 34)
        datamaster.Text = "Data Master"
        ' 
        ' MasterKategoriToolStripMenuItem
        ' 
        MasterKategoriToolStripMenuItem.Name = "MasterKategoriToolStripMenuItem"
        MasterKategoriToolStripMenuItem.Size = New Size(284, 38)
        MasterKategoriToolStripMenuItem.Text = "Master Kategori"
        ' 
        ' MasterSuplierToolStripMenuItem
        ' 
        MasterSuplierToolStripMenuItem.Name = "MasterSuplierToolStripMenuItem"
        MasterSuplierToolStripMenuItem.Size = New Size(284, 38)
        MasterSuplierToolStripMenuItem.Text = "Master Suplier"
        ' 
        ' MasterBarangToolStripMenuItem
        ' 
        MasterBarangToolStripMenuItem.Name = "MasterBarangToolStripMenuItem"
        MasterBarangToolStripMenuItem.Size = New Size(284, 38)
        MasterBarangToolStripMenuItem.Text = "Master barang"
        ' 
        ' StokBarangToolStripMenuItem
        ' 
        StokBarangToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        StokBarangToolStripMenuItem.Name = "StokBarangToolStripMenuItem"
        StokBarangToolStripMenuItem.Size = New Size(154, 34)
        StokBarangToolStripMenuItem.Text = "Stok Barang"
        ' 
        ' TransaksiMasukToolStripMenuItem
        ' 
        TransaksiMasukToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        TransaksiMasukToolStripMenuItem.Name = "TransaksiMasukToolStripMenuItem"
        TransaksiMasukToolStripMenuItem.Size = New Size(198, 34)
        TransaksiMasukToolStripMenuItem.Text = "Transaksi Masuk"
        ' 
        ' TransaksiKeluarToolStripMenuItem
        ' 
        TransaksiKeluarToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        TransaksiKeluarToolStripMenuItem.Name = "TransaksiKeluarToolStripMenuItem"
        TransaksiKeluarToolStripMenuItem.Size = New Size(196, 34)
        TransaksiKeluarToolStripMenuItem.Text = "Transaksi Keluar"
        ' 
        ' EditStokBarangToolStripMenuItem
        ' 
        EditStokBarangToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        EditStokBarangToolStripMenuItem.Name = "EditStokBarangToolStripMenuItem"
        EditStokBarangToolStripMenuItem.Size = New Size(201, 34)
        EditStokBarangToolStripMenuItem.Text = "Edit Stok Barang"
        ' 
        ' TransferAntarGudangToolStripMenuItem
        ' 
        TransferAntarGudangToolStripMenuItem.Name = "TransferAntarGudangToolStripMenuItem"
        TransferAntarGudangToolStripMenuItem.Size = New Size(265, 34)
        TransferAntarGudangToolStripMenuItem.Text = "Transfer Antar Gudang"
        ' 
        ' LaporanMasukKeluarToolStripMenuItem
        ' 
        LaporanMasukKeluarToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        LaporanMasukKeluarToolStripMenuItem.Name = "LaporanMasukKeluarToolStripMenuItem"
        LaporanMasukKeluarToolStripMenuItem.Size = New Size(304, 34)
        LaporanMasukKeluarToolStripMenuItem.Text = "Laporan Masuk dan Keluar"
        ' 
        ' usermanagement
        ' 
        usermanagement.Name = "usermanagement"
        usermanagement.Size = New Size(220, 34)
        usermanagement.Text = "User Management"
        ' 
        ' LogoutToolStripMenuItem1
        ' 
        LogoutToolStripMenuItem1.BackgroundImageLayout = ImageLayout.Stretch
        LogoutToolStripMenuItem1.ForeColor = Color.Crimson
        LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        LogoutToolStripMenuItem1.RightToLeft = RightToLeft.No
        LogoutToolStripMenuItem1.Size = New Size(108, 34)
        LogoutToolStripMenuItem1.Text = "Log out"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(16, 34)
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(16, 34)
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(16, 34)
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Dock = DockStyle.Bottom
        PictureBox1.Image = My.Resources.Resources.Logo_Kelompok_3_Sistem_Inventory
        PictureBox1.Location = New Point(0, 254)
        PictureBox1.Margin = New Padding(4, 4, 4, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1924, 312)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Indigo
        Label1.Location = New Point(886, 22)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(359, 45)
        Label1.TabIndex = 3
        Label1.Text = "INVENTORY GUDANG"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(98, 62)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(210, 30)
        Label2.TabIndex = 4
        Label2.Text = "SELAMAT DATANG,"
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.ForeColor = Color.Black
        lblUser.Location = New Point(309, 62)
        lblUser.Margin = New Padding(4, 0, 4, 0)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(0, 25)
        lblUser.TabIndex = 5
        ' 
        ' Timer1
        ' 
        ' 
        ' lblJam
        ' 
        lblJam.AutoSize = True
        lblJam.ForeColor = Color.Black
        lblJam.Location = New Point(0, 0)
        lblJam.Margin = New Padding(4, 0, 4, 0)
        lblJam.Name = "lblJam"
        lblJam.Size = New Size(0, 25)
        lblJam.TabIndex = 6
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.ForeColor = Color.Black
        lblRole.Location = New Point(309, 61)
        lblRole.Margin = New Padding(4, 0, 4, 0)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(0, 25)
        lblRole.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = My.Resources.Resources.assd
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 566)
        Controls.Add(lblRole)
        Controls.Add(lblJam)
        Controls.Add(lblUser)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        ForeColor = Color.BurlyWood
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 4, 4, 4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents LOGINToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StokBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiMasukToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransaksiKeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanMasukKeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditStokBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents datamaster As ToolStripMenuItem
    Friend WithEvents MasterKategoriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterSuplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransferAntarGudangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents usermanagement As ToolStripMenuItem
    Friend WithEvents MasterBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblJam As Label
    Friend WithEvents lblRole As Label
    Public WithEvents Timer1 As Timer

End Class
