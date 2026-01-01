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
        transaksikeluar = New Label()
        Panelright = New Panel()
        dgvKeluar = New DataGridView()
        Panelleft = New Panel()
        Panel2 = New Panel()
        btnTambah = New Button()
        Label5 = New Label()
        pilih = New Label()
        Panel3 = New Panel()
        input = New Label()
        qty = New NumericUpDown()
        ComboBox1 = New ComboBox()
        Pnldocument = New Panel()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        ComboBox3 = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        tggl = New Label()
        no = New Label()
        Panel4 = New Panel()
        Panel1 = New Panel()
        detaildokumen = New Label()
        Label1 = New Label()
        Panel5 = New Panel()
        Panel6 = New Panel()
        btnSimtrans = New Button()
        btnkembali = New Button()
        PictureBox1 = New PictureBox()
        Panelhead.SuspendLayout()
        Panelright.SuspendLayout()
        CType(dgvKeluar, ComponentModel.ISupportInitialize).BeginInit()
        Panelleft.SuspendLayout()
        Panel2.SuspendLayout()
        CType(qty, ComponentModel.ISupportInitialize).BeginInit()
        Pnldocument.SuspendLayout()
        Panel4.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panelhead
        ' 
        Panelhead.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Panelhead.Controls.Add(PictureBox1)
        Panelhead.Controls.Add(transaksikeluar)
        Panelhead.Dock = DockStyle.Top
        Panelhead.Location = New Point(0, 0)
        Panelhead.Name = "Panelhead"
        Panelhead.Size = New Size(1264, 70)
        Panelhead.TabIndex = 0
        ' 
        ' transaksikeluar
        ' 
        transaksikeluar.AutoSize = True
        transaksikeluar.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        transaksikeluar.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        transaksikeluar.Location = New Point(97, 22)
        transaksikeluar.Name = "transaksikeluar"
        transaksikeluar.Size = New Size(312, 30)
        transaksikeluar.TabIndex = 0
        transaksikeluar.Text = "TRANSAKSI BARANG KELUAR"
        ' 
        ' Panelright
        ' 
        Panelright.Controls.Add(Panel6)
        Panelright.Controls.Add(Panel4)
        Panelright.Controls.Add(Panelleft)
        Panelright.Dock = DockStyle.Fill
        Panelright.Location = New Point(0, 70)
        Panelright.Name = "Panelright"
        Panelright.Size = New Size(1264, 611)
        Panelright.TabIndex = 1
        ' 
        ' dgvKeluar
        ' 
        dgvKeluar.BackgroundColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        dgvKeluar.BorderStyle = BorderStyle.None
        dgvKeluar.EnableHeadersVisualStyles = False
        dgvKeluar.GridColor = Color.FromArgb(CByte(167), CByte(163), CByte(156))
        dgvKeluar.Location = New Point(17, 53)
        dgvKeluar.MultiSelect = False
        dgvKeluar.Name = "dgvKeluar"
        dgvKeluar.ReadOnly = True
        dgvKeluar.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvKeluar.Size = New Size(786, 437)
        dgvKeluar.TabIndex = 0
        ' 
        ' Panelleft
        ' 
        Panelleft.Controls.Add(btnkembali)
        Panelleft.Controls.Add(Panel2)
        Panelleft.Controls.Add(Pnldocument)
        Panelleft.Dock = DockStyle.Left
        Panelleft.Location = New Point(0, 0)
        Panelleft.Name = "Panelleft"
        Panelleft.Size = New Size(430, 611)
        Panelleft.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnTambah)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(pilih)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(input)
        Panel2.Controls.Add(qty)
        Panel2.Controls.Add(ComboBox1)
        Panel2.Location = New Point(14, 322)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(400, 220)
        Panel2.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        btnTambah.FlatAppearance.BorderSize = 0
        btnTambah.FlatStyle = FlatStyle.Flat
        btnTambah.Font = New Font("Segoe UI", 11F)
        btnTambah.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnTambah.Location = New Point(16, 145)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(362, 36)
        btnTambah.TabIndex = 18
        btnTambah.Text = "Tambah Ke List"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        Label5.Location = New Point(16, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 15)
        Label5.TabIndex = 17
        Label5.Text = "Kuantitas"
        ' 
        ' pilih
        ' 
        pilih.AutoSize = True
        pilih.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        pilih.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        pilih.Location = New Point(16, 61)
        pilih.Name = "pilih"
        pilih.Size = New Size(70, 15)
        pilih.TabIndex = 15
        pilih.Text = "Pilih Barang"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Panel3.Location = New Point(146, 29)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(232, 1)
        Panel3.TabIndex = 15
        ' 
        ' input
        ' 
        input.AutoSize = True
        input.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        input.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        input.Location = New Point(16, 19)
        input.Name = "input"
        input.Size = New Size(101, 20)
        input.TabIndex = 15
        input.Text = "Input Barang"
        ' 
        ' qty
        ' 
        qty.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        qty.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        qty.Location = New Point(146, 98)
        qty.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        qty.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        qty.Name = "qty"
        qty.Size = New Size(118, 23)
        qty.TabIndex = 16
        qty.Value = New Decimal(New Integer() {1, 0, 0, 0})
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(146, 58)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(232, 23)
        ComboBox1.TabIndex = 15
        ' 
        ' Pnldocument
        ' 
        Pnldocument.Controls.Add(Panel1)
        Pnldocument.Controls.Add(TextBox4)
        Pnldocument.Controls.Add(TextBox3)
        Pnldocument.Controls.Add(TextBox2)
        Pnldocument.Controls.Add(TextBox1)
        Pnldocument.Controls.Add(ComboBox3)
        Pnldocument.Controls.Add(Label4)
        Pnldocument.Controls.Add(Label3)
        Pnldocument.Controls.Add(Label2)
        Pnldocument.Controls.Add(tggl)
        Pnldocument.Controls.Add(no)
        Pnldocument.Controls.Add(detaildokumen)
        Pnldocument.Location = New Point(14, 40)
        Pnldocument.Name = "Pnldocument"
        Pnldocument.Size = New Size(400, 260)
        Pnldocument.TabIndex = 0
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(146, 210)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(232, 23)
        TextBox4.TabIndex = 13
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(146, 170)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(232, 23)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(146, 90)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(232, 23)
        TextBox2.TabIndex = 11
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(146, 50)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(232, 23)
        TextBox1.TabIndex = 10
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        ComboBox3.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(146, 130)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(232, 23)
        ComboBox3.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        Label4.Location = New Point(16, 213)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 15)
        Label4.TabIndex = 5
        Label4.Text = "Keterangan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        Label3.Location = New Point(16, 173)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 4
        Label3.Text = "Tujuan"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        Label2.Location = New Point(16, 133)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 15)
        Label2.TabIndex = 3
        Label2.Text = "Gudang Asal"
        ' 
        ' tggl
        ' 
        tggl.AutoSize = True
        tggl.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        tggl.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        tggl.Location = New Point(16, 93)
        tggl.Name = "tggl"
        tggl.Size = New Size(49, 15)
        tggl.TabIndex = 2
        tggl.Text = "Tanggal"
        ' 
        ' no
        ' 
        no.AutoSize = True
        no.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        no.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        no.Location = New Point(16, 53)
        no.Name = "no"
        no.Size = New Size(82, 15)
        no.TabIndex = 1
        no.Text = "No. Dokumen"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(Label1)
        Panel4.Controls.Add(dgvKeluar)
        Panel4.Location = New Point(430, 40)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(816, 502)
        Panel4.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Panel1.Location = New Point(146, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(232, 1)
        Panel1.TabIndex = 14
        ' 
        ' detaildokumen
        ' 
        detaildokumen.AutoSize = True
        detaildokumen.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        detaildokumen.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        detaildokumen.Location = New Point(16, 13)
        detaildokumen.Name = "detaildokumen"
        detaildokumen.Size = New Size(122, 20)
        detaildokumen.TabIndex = 0
        detaildokumen.Text = "Detail Dokumen"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        Label1.Location = New Point(15, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 20)
        Label1.TabIndex = 15
        Label1.Text = "Detail Dokumen"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Panel5.Location = New Point(143, 24)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(582, 1)
        Panel5.TabIndex = 15
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(btnSimtrans)
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(430, 548)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(834, 63)
        Panel6.TabIndex = 2
        ' 
        ' btnSimtrans
        ' 
        btnSimtrans.BackColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        btnSimtrans.FlatAppearance.BorderSize = 0
        btnSimtrans.FlatStyle = FlatStyle.Flat
        btnSimtrans.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnSimtrans.Location = New Point(605, 16)
        btnSimtrans.Name = "btnSimtrans"
        btnSimtrans.Size = New Size(170, 35)
        btnSimtrans.TabIndex = 0
        btnSimtrans.Text = "Simpan Transaksi"
        btnSimtrans.UseVisualStyleBackColor = False
        ' 
        ' btnkembali
        ' 
        btnkembali.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnkembali.FlatStyle = FlatStyle.Flat
        btnkembali.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        btnkembali.Location = New Point(30, 564)
        btnkembali.Name = "btnkembali"
        btnkembali.Size = New Size(122, 35)
        btnkembali.TabIndex = 1
        btnkembali.Text = "Kembali"
        btnkembali.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(30, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(60, 50)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' fromTransaksiKeluar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        ClientSize = New Size(1264, 681)
        Controls.Add(Panelright)
        Controls.Add(Panelhead)
        Margin = New Padding(3, 2, 3, 2)
        Name = "fromTransaksiKeluar"
        Text = "fromTransaksiKeluar"
        Panelhead.ResumeLayout(False)
        Panelhead.PerformLayout()
        Panelright.ResumeLayout(False)
        CType(dgvKeluar, ComponentModel.ISupportInitialize).EndInit()
        Panelleft.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(qty, ComponentModel.ISupportInitialize).EndInit()
        Pnldocument.ResumeLayout(False)
        Pnldocument.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel6.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panelhead As Panel
    Friend WithEvents transaksikeluar As Label
    Friend WithEvents Panelright As Panel
    Friend WithEvents Panelleft As Panel
    Friend WithEvents Pnldocument As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tggl As Label
    Friend WithEvents no As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnTambah As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents pilih As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents input As Label
    Friend WithEvents qty As NumericUpDown
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents dgvKeluar As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnSimtrans As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents detaildokumen As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnkembali As Button
End Class
