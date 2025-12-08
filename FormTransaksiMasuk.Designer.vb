<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksiMasuk
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
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtKodeBarang = New TextBox()
        txtNamaBarang = New TextBox()
        txtQty = New TextBox()
        txtLokasi = New TextBox()
        dtTglMasuk = New DateTimePicker()
        cboKategori = New ComboBox()
        Label7 = New Label()
        txtSize = New TextBox()
        btnInput = New Button()
        btnHapus = New Button()
        btnKembali = New Button()
        dgvInput = New DataGridView()
        Panel1 = New Panel()
        btnKonfirmasi = New Button()
        Label8 = New Label()
        PictureBox1 = New PictureBox()
        kode_barang = New DataGridViewTextBoxColumn()
        nama_barang = New DataGridViewTextBoxColumn()
        qty = New DataGridViewTextBoxColumn()
        tgl_masuk = New DataGridViewTextBoxColumn()
        kategori = New DataGridViewTextBoxColumn()
        UkuranBarang = New DataGridViewTextBoxColumn()
        lokasi = New DataGridViewTextBoxColumn()
        CType(dgvInput, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(96, 20)
        Label1.TabIndex = 0
        Label1.Text = "kode barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(22, 163)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nama Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(302, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 20)
        Label3.TabIndex = 2
        Label3.Text = "Qty"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(302, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 20)
        Label4.TabIndex = 3
        Label4.Text = "Lokasi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(22, 217)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 20)
        Label5.TabIndex = 4
        Label5.Text = "Kategori"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(158, 267)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 20)
        Label6.TabIndex = 5
        Label6.Text = "Tgl Masuk"
        ' 
        ' txtKodeBarang
        ' 
        txtKodeBarang.Location = New Point(128, 104)
        txtKodeBarang.Name = "txtKodeBarang"
        txtKodeBarang.Size = New Size(125, 27)
        txtKodeBarang.TabIndex = 6
        ' 
        ' txtNamaBarang
        ' 
        txtNamaBarang.Location = New Point(128, 164)
        txtNamaBarang.Name = "txtNamaBarang"
        txtNamaBarang.Size = New Size(160, 27)
        txtNamaBarang.TabIndex = 7
        ' 
        ' txtQty
        ' 
        txtQty.Location = New Point(352, 104)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(74, 27)
        txtQty.TabIndex = 8
        ' 
        ' txtLokasi
        ' 
        txtLokasi.Location = New Point(352, 163)
        txtLokasi.Name = "txtLokasi"
        txtLokasi.Size = New Size(74, 27)
        txtLokasi.TabIndex = 9
        ' 
        ' dtTglMasuk
        ' 
        dtTglMasuk.Format = DateTimePickerFormat.Short
        dtTglMasuk.Location = New Point(239, 262)
        dtTglMasuk.Name = "dtTglMasuk"
        dtTglMasuk.Size = New Size(120, 27)
        dtTglMasuk.TabIndex = 10
        ' 
        ' cboKategori
        ' 
        cboKategori.FormattingEnabled = True
        cboKategori.Items.AddRange(New Object() {"apparel", "", "footwear", "", "hardware"})
        cboKategori.Location = New Point(128, 214)
        cboKategori.Name = "cboKategori"
        cboKategori.Size = New Size(151, 28)
        cboKategori.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(302, 217)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 20)
        Label7.TabIndex = 12
        Label7.Text = "Size"
        ' 
        ' txtSize
        ' 
        txtSize.Location = New Point(352, 210)
        txtSize.Name = "txtSize"
        txtSize.Size = New Size(70, 27)
        txtSize.TabIndex = 13
        ' 
        ' btnInput
        ' 
        btnInput.BackColor = Color.White
        btnInput.Location = New Point(40, 337)
        btnInput.Name = "btnInput"
        btnInput.Size = New Size(94, 29)
        btnInput.TabIndex = 14
        btnInput.Text = "INPUT DATA"
        btnInput.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.White
        btnHapus.Location = New Point(140, 337)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 15
        btnHapus.Text = "HAPUS"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(356, 337)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(111, 29)
        btnKembali.TabIndex = 17
        btnKembali.Text = "KEMBALI"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' dgvInput
        ' 
        dgvInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInput.Columns.AddRange(New DataGridViewColumn() {kode_barang, nama_barang, qty, tgl_masuk, kategori, UkuranBarang, lokasi})
        dgvInput.Location = New Point(809, 165)
        dgvInput.Name = "dgvInput"
        dgvInput.RowHeadersWidth = 51
        dgvInput.Size = New Size(933, 468)
        dgvInput.TabIndex = 18
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtKodeBarang)
        Panel1.Controls.Add(btnKembali)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnKonfirmasi)
        Panel1.Controls.Add(txtNamaBarang)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(btnInput)
        Panel1.Controls.Add(cboKategori)
        Panel1.Controls.Add(dtTglMasuk)
        Panel1.Controls.Add(txtSize)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(txtQty)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtLokasi)
        Panel1.Location = New Point(109, 165)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(529, 468)
        Panel1.TabIndex = 19
        ' 
        ' btnKonfirmasi
        ' 
        btnKonfirmasi.BackColor = Color.White
        btnKonfirmasi.Location = New Point(239, 337)
        btnKonfirmasi.Name = "btnKonfirmasi"
        btnKonfirmasi.Size = New Size(111, 29)
        btnKonfirmasi.TabIndex = 16
        btnKonfirmasi.Text = "KONFIRMASI"
        btnKonfirmasi.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Impact", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(719, 27)
        Label8.Name = "Label8"
        Label8.Size = New Size(552, 48)
        Label8.TabIndex = 20
        Label8.Text = "INPUT TRANSAKSI BARANG MASUK"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.Logo_Kelompok_3_Sistem_Inventory
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Dock = DockStyle.Bottom
        PictureBox1.Location = New Point(0, 548)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1603, 250)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 21
        PictureBox1.TabStop = False
        ' 
        ' kode_barang
        ' 
        kode_barang.HeaderText = "Kode Barang"
        kode_barang.MinimumWidth = 6
        kode_barang.Name = "kode_barang"
        kode_barang.Width = 125
        ' 
        ' nama_barang
        ' 
        nama_barang.HeaderText = "Nama Barang"
        nama_barang.MinimumWidth = 6
        nama_barang.Name = "nama_barang"
        nama_barang.Width = 125
        ' 
        ' qty
        ' 
        qty.HeaderText = "Qty"
        qty.MinimumWidth = 6
        qty.Name = "qty"
        qty.Width = 125
        ' 
        ' tgl_masuk
        ' 
        tgl_masuk.HeaderText = "Tgl Masuk"
        tgl_masuk.MinimumWidth = 6
        tgl_masuk.Name = "tgl_masuk"
        tgl_masuk.Width = 125
        ' 
        ' kategori
        ' 
        kategori.HeaderText = "Kategori"
        kategori.MinimumWidth = 6
        kategori.Name = "kategori"
        kategori.Width = 125
        ' 
        ' UkuranBarang
        ' 
        UkuranBarang.HeaderText = "Size"
        UkuranBarang.MinimumWidth = 6
        UkuranBarang.Name = "UkuranBarang"
        UkuranBarang.Width = 125
        ' 
        ' lokasi
        ' 
        lokasi.HeaderText = "Lokasi"
        lokasi.MinimumWidth = 6
        lokasi.Name = "lokasi"
        lokasi.Width = 125
        ' 
        ' FormTransaksiMasuk
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.assd1
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1603, 798)
        Controls.Add(PictureBox1)
        Controls.Add(Label8)
        Controls.Add(Panel1)
        Controls.Add(dgvInput)
        Name = "FormTransaksiMasuk"
        Text = "FormTransaksiMasuk"
        CType(dgvInput, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtKodeBarang As TextBox
    Friend WithEvents txtNamaBarang As TextBox
    Friend WithEvents txtQty As TextBox
    Friend WithEvents txtLokasi As TextBox
    Friend WithEvents dtTglMasuk As DateTimePicker
    Friend WithEvents cboKategori As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents dgvInput As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnKonfirmasi As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents kode_barang As DataGridViewTextBoxColumn
    Friend WithEvents nama_barang As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents tgl_masuk As DataGridViewTextBoxColumn
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents UkuranBarang As DataGridViewTextBoxColumn
    Friend WithEvents lokasi As DataGridViewTextBoxColumn
End Class
