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
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.WhiteSmoke
        MenuStrip1.BackgroundImageLayout = ImageLayout.Stretch
        MenuStrip1.Dock = DockStyle.None
        MenuStrip1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {LOGINToolStripMenuItem, datamaster, StokBarangToolStripMenuItem, TransaksiMasukToolStripMenuItem, TransaksiKeluarToolStripMenuItem, EditStokBarangToolStripMenuItem, TransferAntarGudangToolStripMenuItem, LaporanMasukKeluarToolStripMenuItem, usermanagement, LogoutToolStripMenuItem1, ToolStripMenuItem1, ToolStripMenuItem2, ToolStripMenuItem3})
        MenuStrip1.Location = New Point(133, 9)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(12, 0, 6, 0)
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(1664, 29)
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
        LOGINToolStripMenuItem.Size = New Size(86, 29)
        LOGINToolStripMenuItem.Text = "LOGIN"
        ' 
        ' datamaster
        ' 
        datamaster.DropDownItems.AddRange(New ToolStripItem() {MasterKategoriToolStripMenuItem, MasterSuplierToolStripMenuItem, MasterBarangToolStripMenuItem})
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
        ' StokBarangToolStripMenuItem
        ' 
        StokBarangToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        StokBarangToolStripMenuItem.Name = "StokBarangToolStripMenuItem"
        StokBarangToolStripMenuItem.Size = New Size(130, 29)
        StokBarangToolStripMenuItem.Text = "Stok Barang"
        ' 
        ' TransaksiMasukToolStripMenuItem
        ' 
        TransaksiMasukToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        TransaksiMasukToolStripMenuItem.Name = "TransaksiMasukToolStripMenuItem"
        TransaksiMasukToolStripMenuItem.Size = New Size(166, 29)
        TransaksiMasukToolStripMenuItem.Text = "Transaksi Masuk"
        ' 
        ' TransaksiKeluarToolStripMenuItem
        ' 
        TransaksiKeluarToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        TransaksiKeluarToolStripMenuItem.Name = "TransaksiKeluarToolStripMenuItem"
        TransaksiKeluarToolStripMenuItem.Size = New Size(165, 29)
        TransaksiKeluarToolStripMenuItem.Text = "Transaksi Keluar"
        ' 
        ' EditStokBarangToolStripMenuItem
        ' 
        EditStokBarangToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        EditStokBarangToolStripMenuItem.Name = "EditStokBarangToolStripMenuItem"
        EditStokBarangToolStripMenuItem.Size = New Size(168, 29)
        EditStokBarangToolStripMenuItem.Text = "Edit Stok Barang"
        ' 
        ' TransferAntarGudangToolStripMenuItem
        ' 
        TransferAntarGudangToolStripMenuItem.Name = "TransferAntarGudangToolStripMenuItem"
        TransferAntarGudangToolStripMenuItem.Size = New Size(221, 29)
        TransferAntarGudangToolStripMenuItem.Text = "Transfer Antar Gudang"
        ' 
        ' LaporanMasukKeluarToolStripMenuItem
        ' 
        LaporanMasukKeluarToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        LaporanMasukKeluarToolStripMenuItem.Name = "LaporanMasukKeluarToolStripMenuItem"
        LaporanMasukKeluarToolStripMenuItem.Size = New Size(253, 29)
        LaporanMasukKeluarToolStripMenuItem.Text = "Laporan Masuk dan Keluar"
        ' 
        ' usermanagement
        ' 
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
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(14, 29)
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(14, 29)
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Dock = DockStyle.Bottom
        PictureBox1.Image = My.Resources.Resources.Logo_Kelompok_3_Sistem_Inventory
        PictureBox1.Location = New Point(0, 203)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1806, 250)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = My.Resources.Resources.assd
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1806, 453)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        ForeColor = Color.BurlyWood
        MainMenuStrip = MenuStrip1
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

End Class
