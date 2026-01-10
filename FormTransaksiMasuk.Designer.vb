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
        Panel1 = New Panel()
        btnKembali = New Button()
        btnTambahKeList = New Button()
        nudQty = New NumericUpDown()
        cbBarang = New ComboBox()
        txtKeterangan = New TextBox()
        cbGudang = New ComboBox()
        cbSupplier = New ComboBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        dtTanggal = New DateTimePicker()
        txtNoDokumen = New TextBox()
        Label1 = New Label()
        Label8 = New Label()
        dgList = New DataGridView()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(nudQty, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgList, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(btnKembali)
        Panel1.Controls.Add(btnTambahKeList)
        Panel1.Controls.Add(nudQty)
        Panel1.Controls.Add(cbBarang)
        Panel1.Controls.Add(txtKeterangan)
        Panel1.Controls.Add(cbGudang)
        Panel1.Controls.Add(cbSupplier)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(dtTanggal)
        Panel1.Controls.Add(txtNoDokumen)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(93, 166)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(529, 468)
        Panel1.TabIndex = 19
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        btnKembali.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnKembali.ForeColor = Color.White
        btnKembali.Location = New Point(274, 378)
        btnKembali.Margin = New Padding(1, 2, 1, 2)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(172, 39)
        btnKembali.TabIndex = 15
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnTambahKeList
        ' 
        btnTambahKeList.BackColor = Color.Black
        btnTambahKeList.FlatStyle = FlatStyle.Flat
        btnTambahKeList.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnTambahKeList.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnTambahKeList.Location = New Point(39, 378)
        btnTambahKeList.Margin = New Padding(1, 2, 1, 2)
        btnTambahKeList.Name = "btnTambahKeList"
        btnTambahKeList.Size = New Size(169, 34)
        btnTambahKeList.TabIndex = 14
        btnTambahKeList.Text = "Tambah ke list"
        btnTambahKeList.UseVisualStyleBackColor = False
        ' 
        ' nudQty
        ' 
        nudQty.Location = New Point(199, 312)
        nudQty.Margin = New Padding(1, 2, 1, 2)
        nudQty.Name = "nudQty"
        nudQty.Size = New Size(239, 27)
        nudQty.TabIndex = 13
        ' 
        ' cbBarang
        ' 
        cbBarang.FormattingEnabled = True
        cbBarang.Location = New Point(197, 266)
        cbBarang.Margin = New Padding(1, 2, 1, 2)
        cbBarang.Name = "cbBarang"
        cbBarang.Size = New Size(241, 28)
        cbBarang.TabIndex = 12
        ' 
        ' txtKeterangan
        ' 
        txtKeterangan.Location = New Point(197, 218)
        txtKeterangan.Margin = New Padding(1, 2, 1, 2)
        txtKeterangan.Name = "txtKeterangan"
        txtKeterangan.Size = New Size(241, 27)
        txtKeterangan.TabIndex = 11
        ' 
        ' cbGudang
        ' 
        cbGudang.FormattingEnabled = True
        cbGudang.Location = New Point(197, 172)
        cbGudang.Margin = New Padding(1, 2, 1, 2)
        cbGudang.Name = "cbGudang"
        cbGudang.Size = New Size(241, 28)
        cbGudang.TabIndex = 10
        ' 
        ' cbSupplier
        ' 
        cbSupplier.FormattingEnabled = True
        cbSupplier.Location = New Point(197, 130)
        cbSupplier.Margin = New Padding(1, 2, 1, 2)
        cbSupplier.Name = "cbSupplier"
        cbSupplier.Size = New Size(241, 28)
        cbSupplier.TabIndex = 9
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label7.Location = New Point(39, 318)
        Label7.Margin = New Padding(1, 0, 1, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(34, 20)
        Label7.TabIndex = 8
        Label7.Text = "Qty"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label6.Location = New Point(39, 270)
        Label6.Margin = New Padding(1, 0, 1, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 20)
        Label6.TabIndex = 7
        Label6.Text = "Pilih Barang"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label5.Location = New Point(39, 222)
        Label5.Margin = New Padding(1, 0, 1, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 20)
        Label5.TabIndex = 6
        Label5.Text = "Keterangan"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(39, 178)
        Label4.Margin = New Padding(1, 0, 1, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 20)
        Label4.TabIndex = 5
        Label4.Text = "Gudang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label3.Location = New Point(39, 134)
        Label3.Margin = New Padding(1, 0, 1, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(66, 20)
        Label3.TabIndex = 4
        Label3.Text = "Supplier"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label2.Location = New Point(39, 88)
        Label2.Margin = New Padding(1, 0, 1, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 3
        Label2.Text = "Tanggal"
        ' 
        ' dtTanggal
        ' 
        dtTanggal.Location = New Point(197, 82)
        dtTanggal.Margin = New Padding(1, 2, 1, 2)
        dtTanggal.Name = "dtTanggal"
        dtTanggal.Size = New Size(241, 27)
        dtTanggal.TabIndex = 2
        ' 
        ' txtNoDokumen
        ' 
        txtNoDokumen.Location = New Point(197, 42)
        txtNoDokumen.Margin = New Padding(1, 2, 1, 2)
        txtNoDokumen.Name = "txtNoDokumen"
        txtNoDokumen.Size = New Size(241, 27)
        txtNoDokumen.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(39, 44)
        Label1.Margin = New Padding(1, 0, 1, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(131, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nomor Dokumen"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(687, 59)
        Label8.Name = "Label8"
        Label8.Size = New Size(405, 46)
        Label8.TabIndex = 20
        Label8.Text = "Transaksi Barang Masuk"
        ' 
        ' dgList
        ' 
        dgList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgList.BackgroundColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgList.Location = New Point(687, 166)
        dgList.Margin = New Padding(1, 2, 1, 2)
        dgList.Name = "dgList"
        dgList.RowHeadersWidth = 62
        dgList.Size = New Size(787, 468)
        dgList.TabIndex = 22
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo_hitam_60x60
        PictureBox1.Location = New Point(617, 52)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(62, 62)
        PictureBox1.TabIndex = 23
        PictureBox1.TabStop = False
        ' 
        ' FormTransaksiMasuk
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        ClientSize = New Size(1539, 798)
        Controls.Add(PictureBox1)
        Controls.Add(dgList)
        Controls.Add(Label8)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FormTransaksiMasuk"
        Text = "FormTransaksiMasuk"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(nudQty, ComponentModel.ISupportInitialize).EndInit()
        CType(dgList, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtTanggal As DateTimePicker
    Friend WithEvents txtNoDokumen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nudQty As NumericUpDown
    Friend WithEvents cbBarang As ComboBox
    Friend WithEvents txtKeterangan As TextBox
    Friend WithEvents cbGudang As ComboBox
    Friend WithEvents cbSupplier As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTambahKeList As Button
    Friend WithEvents dgList As DataGridView
    Friend WithEvents btnKembali As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
