<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromTransaksiKeluar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fromTransaksiKeluar))
        Panelhead = New Panel()
        PictureBox1 = New PictureBox()
        transaksikeluar = New Label()
        Panelright = New Panel()
        Panel6 = New Panel()
        btnSimpanTransaksi = New Button()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Label1 = New Label()
        dgvKeluar = New DataGridView()
        Panelleft = New Panel()
        btnKembali = New Button()
        Panel2 = New Panel()
        btnTambahKeList = New Button()
        Label5 = New Label()
        pilih = New Label()
        Panel3 = New Panel()
        input = New Label()
        nudQty = New NumericUpDown()
        cbBarang = New ComboBox()
        Pnldocument = New Panel()
        Panel1 = New Panel()
        txtKeterangan = New TextBox()
        txtTujuan = New TextBox()
        txtNoDokumen = New TextBox()
        cbGudangAsal = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        tggl = New Label()
        no = New Label()
        detaildokumen = New Label()
        dtTanggal = New DateTimePicker()
        Panelhead.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panelright.SuspendLayout()
        Panel6.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgvKeluar, ComponentModel.ISupportInitialize).BeginInit()
        Panelleft.SuspendLayout()
        Panel2.SuspendLayout()
        CType(nudQty, ComponentModel.ISupportInitialize).BeginInit()
        Pnldocument.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panelhead
        ' 
        Panelhead.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Panelhead.Controls.Add(PictureBox1)
        Panelhead.Controls.Add(transaksikeluar)
        Panelhead.Dock = DockStyle.Top
        Panelhead.Location = New Point(0, 0)
        Panelhead.Margin = New Padding(3, 4, 3, 4)
        Panelhead.Name = "Panelhead"
        Panelhead.Size = New Size(1419, 94)
        Panelhead.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(33, 16)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(69, 66)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' transaksikeluar
        ' 
        transaksikeluar.AutoSize = True
        transaksikeluar.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        transaksikeluar.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        transaksikeluar.Location = New Point(111, 30)
        transaksikeluar.Name = "transaksikeluar"
        transaksikeluar.Size = New Size(395, 37)
        transaksikeluar.TabIndex = 0
        transaksikeluar.Text = "TRANSAKSI BARANG KELUAR"
        ' 
        ' Panelright
        ' 
        Panelright.Controls.Add(Panel6)
        Panelright.Controls.Add(Panel4)
        Panelright.Controls.Add(Panelleft)
        Panelright.Dock = DockStyle.Fill
        Panelright.Location = New Point(0, 94)
        Panelright.Margin = New Padding(3, 4, 3, 4)
        Panelright.Name = "Panelright"
        Panelright.Size = New Size(1419, 750)
        Panelright.TabIndex = 1
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(btnSimpanTransaksi)
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(491, 666)
        Panel6.Margin = New Padding(3, 4, 3, 4)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(928, 84)
        Panel6.TabIndex = 2
        ' 
        ' btnSimpanTransaksi
        ' 
        btnSimpanTransaksi.BackColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        btnSimpanTransaksi.FlatAppearance.BorderSize = 0
        btnSimpanTransaksi.FlatStyle = FlatStyle.Flat
        btnSimpanTransaksi.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnSimpanTransaksi.Location = New Point(691, 22)
        btnSimpanTransaksi.Margin = New Padding(3, 4, 3, 4)
        btnSimpanTransaksi.Name = "btnSimpanTransaksi"
        btnSimpanTransaksi.Size = New Size(193, 46)
        btnSimpanTransaksi.TabIndex = 0
        btnSimpanTransaksi.Text = "Simpan Transaksi"
        btnSimpanTransaksi.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(dgvKeluar)
        Panel4.Location = New Point(491, 54)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(933, 670)
        Panel4.TabIndex = 1
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Panel5.Location = New Point(179, 32)
        Panel5.Margin = New Padding(3, 4, 3, 4)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(665, 2)
        Panel5.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        Label1.Location = New Point(17, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 25)
        Label1.TabIndex = 15
        Label1.Text = "Detail Dokumen"
        ' 
        ' dgvKeluar
        ' 
        dgvKeluar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvKeluar.BackgroundColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        dgvKeluar.BorderStyle = BorderStyle.None
        dgvKeluar.ColumnHeadersHeight = 29
        dgvKeluar.EnableHeadersVisualStyles = False
        dgvKeluar.GridColor = Color.FromArgb(CByte(167), CByte(163), CByte(156))
        dgvKeluar.Location = New Point(28, 70)
        dgvKeluar.Margin = New Padding(3, 4, 3, 4)
        dgvKeluar.MultiSelect = False
        dgvKeluar.Name = "dgvKeluar"
        dgvKeluar.ReadOnly = True
        dgvKeluar.RowHeadersWidth = 51
        dgvKeluar.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKeluar.Size = New Size(897, 582)
        dgvKeluar.TabIndex = 0
        ' 
        ' Panelleft
        ' 
        Panelleft.Controls.Add(btnKembali)
        Panelleft.Controls.Add(Panel2)
        Panelleft.Controls.Add(Pnldocument)
        Panelleft.Dock = DockStyle.Left
        Panelleft.Location = New Point(0, 0)
        Panelleft.Margin = New Padding(3, 4, 3, 4)
        Panelleft.Name = "Panelleft"
        Panelleft.Size = New Size(491, 750)
        Panelleft.TabIndex = 0
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        btnKembali.Location = New Point(16, 742)
        btnKembali.Margin = New Padding(3, 4, 3, 4)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(139, 46)
        btnKembali.TabIndex = 1
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnTambahKeList)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(pilih)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(input)
        Panel2.Controls.Add(nudQty)
        Panel2.Controls.Add(cbBarang)
        Panel2.Location = New Point(16, 430)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(457, 294)
        Panel2.TabIndex = 1
        ' 
        ' btnTambahKeList
        ' 
        btnTambahKeList.BackColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        btnTambahKeList.FlatAppearance.BorderSize = 0
        btnTambahKeList.FlatStyle = FlatStyle.Flat
        btnTambahKeList.Font = New Font("Segoe UI", 11F)
        btnTambahKeList.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnTambahKeList.Location = New Point(17, 194)
        btnTambahKeList.Margin = New Padding(3, 4, 3, 4)
        btnTambahKeList.Name = "btnTambahKeList"
        btnTambahKeList.Size = New Size(415, 48)
        btnTambahKeList.TabIndex = 18
        btnTambahKeList.Text = "Tambah Ke List"
        btnTambahKeList.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        Label5.Location = New Point(17, 134)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 20)
        Label5.TabIndex = 17
        Label5.Text = "Kuantitas"
        ' 
        ' pilih
        ' 
        pilih.AutoSize = True
        pilih.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pilih.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        pilih.Location = New Point(17, 82)
        pilih.Name = "pilih"
        pilih.Size = New Size(92, 20)
        pilih.TabIndex = 15
        pilih.Text = "Pilih Barang"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Panel3.Location = New Point(167, 38)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(265, 2)
        Panel3.TabIndex = 15
        ' 
        ' input
        ' 
        input.AutoSize = True
        input.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        input.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        input.Location = New Point(17, 26)
        input.Name = "input"
        input.Size = New Size(130, 25)
        input.TabIndex = 15
        input.Text = "Input Barang"
        ' 
        ' nudQty
        ' 
        nudQty.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        nudQty.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        nudQty.Location = New Point(167, 130)
        nudQty.Margin = New Padding(3, 4, 3, 4)
        nudQty.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        nudQty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        nudQty.Name = "nudQty"
        nudQty.Size = New Size(265, 27)
        nudQty.TabIndex = 16
        nudQty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' cbBarang
        ' 
        cbBarang.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cbBarang.DropDownStyle = ComboBoxStyle.DropDownList
        cbBarang.FormattingEnabled = True
        cbBarang.Location = New Point(167, 78)
        cbBarang.Margin = New Padding(3, 4, 3, 4)
        cbBarang.Name = "cbBarang"
        cbBarang.Size = New Size(265, 28)
        cbBarang.TabIndex = 15
        ' 
        ' Pnldocument
        ' 
        Pnldocument.Controls.Add(dtTanggal)
        Pnldocument.Controls.Add(Panel1)
        Pnldocument.Controls.Add(txtKeterangan)
        Pnldocument.Controls.Add(txtTujuan)
        Pnldocument.Controls.Add(txtNoDokumen)
        Pnldocument.Controls.Add(cbGudangAsal)
        Pnldocument.Controls.Add(Label4)
        Pnldocument.Controls.Add(Label3)
        Pnldocument.Controls.Add(Label2)
        Pnldocument.Controls.Add(tggl)
        Pnldocument.Controls.Add(no)
        Pnldocument.Controls.Add(detaildokumen)
        Pnldocument.Location = New Point(16, 54)
        Pnldocument.Margin = New Padding(3, 4, 3, 4)
        Pnldocument.Name = "Pnldocument"
        Pnldocument.Size = New Size(457, 346)
        Pnldocument.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Panel1.Location = New Point(181, 32)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(265, 2)
        Panel1.TabIndex = 14
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.Location = New Point(167, 280)
        txtKeterangan.Margin = New Padding(3, 4, 3, 4)
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.Size = New Size(265, 27)
        txtKeterangan.TabIndex = 13
        ' 
        ' txtTujuan
        ' 
        txtTujuan.Location = New Point(167, 226)
        txtTujuan.Margin = New Padding(3, 4, 3, 4)
        txtTujuan.Name = "txtTujuan"
        txtTujuan.Size = New Size(265, 27)
        txtTujuan.TabIndex = 12
        ' 
        ' txtNoDokumen
        ' 
        txtNoDokumen.Location = New Point(167, 66)
        txtNoDokumen.Margin = New Padding(3, 4, 3, 4)
        txtNoDokumen.Name = "txtNoDokumen"
        txtNoDokumen.Size = New Size(265, 27)
        txtNoDokumen.TabIndex = 10
        ' 
        ' cbGudangAsal
        ' 
        cbGudangAsal.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        cbGudangAsal.DropDownStyle = ComboBoxStyle.DropDownList
        cbGudangAsal.FormattingEnabled = True
        cbGudangAsal.Location = New Point(167, 174)
        cbGudangAsal.Margin = New Padding(3, 4, 3, 4)
        cbGudangAsal.Name = "cbGudangAsal"
        cbGudangAsal.Size = New Size(265, 28)
        cbGudangAsal.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        Label4.Location = New Point(17, 284)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 20)
        Label4.TabIndex = 5
        Label4.Text = "Keterangan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        Label3.Location = New Point(17, 230)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 20)
        Label3.TabIndex = 4
        Label3.Text = "Tujuan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        Label2.Location = New Point(17, 178)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 20)
        Label2.TabIndex = 3
        Label2.Text = "Gudang Asal"
        ' 
        ' tggl
        ' 
        tggl.AutoSize = True
        tggl.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        tggl.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        tggl.Location = New Point(17, 124)
        tggl.Name = "tggl"
        tggl.Size = New Size(63, 20)
        tggl.TabIndex = 2
        tggl.Text = "Tanggal"
        ' 
        ' no
        ' 
        no.AutoSize = True
        no.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        no.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        no.Location = New Point(17, 70)
        no.Name = "no"
        no.Size = New Size(105, 20)
        no.TabIndex = 1
        no.Text = "No. Dokumen"
        ' 
        ' detaildokumen
        ' 
        detaildokumen.AutoSize = True
        detaildokumen.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        detaildokumen.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        detaildokumen.Location = New Point(17, 18)
        detaildokumen.Name = "detaildokumen"
        detaildokumen.Size = New Size(156, 25)
        detaildokumen.TabIndex = 0
        detaildokumen.Text = "Detail Dokumen"
        ' 
        ' dtTanggal
        ' 
        dtTanggal.Location = New Point(167, 119)
        dtTanggal.Name = "dtTanggal"
        dtTanggal.Size = New Size(265, 27)
        dtTanggal.TabIndex = 15
        ' 
        ' fromTransaksiKeluar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        ClientSize = New Size(1419, 844)
        Controls.Add(Panelright)
        Controls.Add(Panelhead)
        Margin = New Padding(3, 2, 3, 2)
        Name = "fromTransaksiKeluar"
        Text = "fromTransaksiKeluar"
        Panelhead.ResumeLayout(False)
        Panelhead.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panelright.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(dgvKeluar, ComponentModel.ISupportInitialize).EndInit()
        Panelleft.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(nudQty, ComponentModel.ISupportInitialize).EndInit()
        Pnldocument.ResumeLayout(False)
        Pnldocument.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panelhead As Panel
    Friend WithEvents transaksikeluar As Label
    Friend WithEvents Panelright As Panel
    Friend WithEvents Panelleft As Panel
    Friend WithEvents Pnldocument As Panel
    Friend WithEvents txtNoDokumen As TextBox
    Friend WithEvents cbGudangAsal As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tggl As Label
    Friend WithEvents no As Label
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents txtTujuan As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTambahKeList As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents pilih As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents input As Label
    Friend WithEvents nudQty As NumericUpDown
    Friend WithEvents cbBarang As ComboBox
    Friend WithEvents dgvKeluar As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnSimpanTransaksi As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents detaildokumen As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnKembali As Button
    Friend WithEvents dtTanggal As DateTimePicker
End Class
