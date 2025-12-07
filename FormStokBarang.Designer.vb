<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStokBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtKode = New TextBox()
        txtNama = New TextBox()
        txtSize = New TextBox()
        dgvStokBarang = New DataGridView()
        Label4 = New Label()
        Label5 = New Label()
        txtkategori = New TextBox()
        txtLokasi = New TextBox()
        btnCari = New Button()
        btnKeluar = New Button()
        Panel1 = New Panel()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        Label7 = New Label()
        CType(dgvStokBarang, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 108)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 25)
        Label1.TabIndex = 0
        Label1.Text = "KODE BARANG"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 181)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 25)
        Label2.TabIndex = 1
        Label2.Text = "NAMA BARANG"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 244)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 25)
        Label3.TabIndex = 2
        Label3.Text = "SIZE"
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(240, 104)
        txtKode.Margin = New Padding(4, 4, 4, 4)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(340, 31)
        txtKode.TabIndex = 3
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(240, 172)
        txtNama.Margin = New Padding(4, 4, 4, 4)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(340, 31)
        txtNama.TabIndex = 4
        ' 
        ' txtSize
        ' 
        txtSize.Location = New Point(240, 240)
        txtSize.Margin = New Padding(4, 4, 4, 4)
        txtSize.Name = "txtSize"
        txtSize.Size = New Size(340, 31)
        txtSize.TabIndex = 5
        ' 
        ' dgvStokBarang
        ' 
        dgvStokBarang.AllowUserToAddRows = False
        dgvStokBarang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        dgvStokBarang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStokBarang.Location = New Point(899, 279)
        dgvStokBarang.Margin = New Padding(4, 4, 4, 4)
        dgvStokBarang.Name = "dgvStokBarang"
        dgvStokBarang.RowHeadersWidth = 51
        dgvStokBarang.Size = New Size(1125, 559)
        dgvStokBarang.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 322)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 25)
        Label4.TabIndex = 9
        Label4.Text = "KATEGORI"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(42, 398)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 25)
        Label5.TabIndex = 10
        Label5.Text = "LOKASI"
        ' 
        ' txtkategori
        ' 
        txtkategori.Location = New Point(240, 314)
        txtkategori.Margin = New Padding(4, 4, 4, 4)
        txtkategori.Name = "txtkategori"
        txtkategori.Size = New Size(340, 31)
        txtkategori.TabIndex = 11
        ' 
        ' txtLokasi
        ' 
        txtLokasi.Location = New Point(240, 394)
        txtLokasi.Margin = New Padding(4, 4, 4, 4)
        txtLokasi.Name = "txtLokasi"
        txtLokasi.Size = New Size(340, 31)
        txtLokasi.TabIndex = 12
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(240, 479)
        btnCari.Margin = New Padding(4, 4, 4, 4)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(118, 36)
        btnCari.TabIndex = 13
        btnCari.Text = "cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(382, 479)
        btnKeluar.Margin = New Padding(4, 4, 4, 4)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(118, 36)
        btnKeluar.TabIndex = 14
        btnKeluar.Text = "keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnKeluar)
        Panel1.Controls.Add(txtKode)
        Panel1.Controls.Add(btnCari)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtLokasi)
        Panel1.Controls.Add(txtNama)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtkategori)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtSize)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(76, 279)
        Panel1.Margin = New Padding(4, 4, 4, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(728, 559)
        Panel1.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(55, 455)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 25)
        Label6.TabIndex = 15
        Label6.Text = "Sampel"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.Logo_Kelompok_3_Sistem_Inventory
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Dock = DockStyle.Bottom
        PictureBox1.Location = New Point(0, 825)
        PictureBox1.Margin = New Padding(4, 4, 4, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1924, 159)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(8, 2, 0, 2)
        MenuStrip1.Size = New Size(1924, 24)
        MenuStrip1.TabIndex = 17
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(814, 95)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(240, 40)
        Label7.TabIndex = 18
        Label7.Text = "stok barang "
        ' 
        ' FormStokBarang
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.assd1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1924, 984)
        Controls.Add(Label7)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(dgvStokBarang)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(4, 4, 4, 4)
        Name = "FormStokBarang"
        Text = "FormStokBarang"
        CType(dgvStokBarang, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtSize As TextBox
    Friend WithEvents dgvStokBarang As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtkategori As TextBox
    Friend WithEvents txtLokasi As TextBox
    Friend WithEvents btnCari As Button
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label7 As Label
End Class
