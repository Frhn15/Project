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
        StokBarangToolStripMenuItem = New ToolStripMenuItem()
        TransaksiMasukToolStripMenuItem = New ToolStripMenuItem()
        TransaksiKeluarToolStripMenuItem = New ToolStripMenuItem()
        LaporanMasukKeluarToolStripMenuItem = New ToolStripMenuItem()
        EditStokBarangToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem1 = New ToolStripMenuItem()
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
        MenuStrip1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {LOGINToolStripMenuItem, StokBarangToolStripMenuItem, TransaksiMasukToolStripMenuItem, TransaksiKeluarToolStripMenuItem, LaporanMasukKeluarToolStripMenuItem, EditStokBarangToolStripMenuItem, LogoutToolStripMenuItem1})
        MenuStrip1.Location = New Point(229, 9)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(15, 0, 8, 0)
        MenuStrip1.RenderMode = ToolStripRenderMode.Professional
        MenuStrip1.Size = New Size(1553, 42)
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
        LOGINToolStripMenuItem.Size = New Size(120, 42)
        LOGINToolStripMenuItem.Text = "LOGIN"
        ' 
        ' StokBarangToolStripMenuItem
        ' 
        StokBarangToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        StokBarangToolStripMenuItem.Name = "StokBarangToolStripMenuItem"
        StokBarangToolStripMenuItem.Size = New Size(193, 42)
        StokBarangToolStripMenuItem.Text = "Stok Barang"
        ' 
        ' TransaksiMasukToolStripMenuItem
        ' 
        TransaksiMasukToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        TransaksiMasukToolStripMenuItem.Name = "TransaksiMasukToolStripMenuItem"
        TransaksiMasukToolStripMenuItem.Size = New Size(248, 42)
        TransaksiMasukToolStripMenuItem.Text = "Transaksi Masuk"
        ' 
        ' TransaksiKeluarToolStripMenuItem
        ' 
        TransaksiKeluarToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        TransaksiKeluarToolStripMenuItem.Name = "TransaksiKeluarToolStripMenuItem"
        TransaksiKeluarToolStripMenuItem.Size = New Size(245, 42)
        TransaksiKeluarToolStripMenuItem.Text = "Transaksi Keluar"
        ' 
        ' LaporanMasukKeluarToolStripMenuItem
        ' 
        LaporanMasukKeluarToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        LaporanMasukKeluarToolStripMenuItem.Name = "LaporanMasukKeluarToolStripMenuItem"
        LaporanMasukKeluarToolStripMenuItem.Size = New Size(334, 42)
        LaporanMasukKeluarToolStripMenuItem.Text = "Laporan Masuk & Keluar"
        ' 
        ' EditStokBarangToolStripMenuItem
        ' 
        EditStokBarangToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch
        EditStokBarangToolStripMenuItem.Name = "EditStokBarangToolStripMenuItem"
        EditStokBarangToolStripMenuItem.Size = New Size(252, 42)
        EditStokBarangToolStripMenuItem.Text = "Edit Stok Barang"
        ' 
        ' LogoutToolStripMenuItem1
        ' 
        LogoutToolStripMenuItem1.BackgroundImageLayout = ImageLayout.Stretch
        LogoutToolStripMenuItem1.ForeColor = Color.Crimson
        LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        LogoutToolStripMenuItem1.RightToLeft = RightToLeft.No
        LogoutToolStripMenuItem1.Size = New Size(126, 42)
        LogoutToolStripMenuItem1.Text = "Logout"
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        BackgroundImage = My.Resources.Resources.assd
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 566)
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

End Class
