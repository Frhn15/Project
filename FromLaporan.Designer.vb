<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromLaporan
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
        cbPilih = New ComboBox()
        dtDari = New DateTimePicker()
        dtSampai = New DateTimePicker()
        txtCari = New TextBox()
        btnTampilkan = New Button()
        btnExport = New Button()
        btnKembali = New Button()
        dgLaporan = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        CType(dgLaporan, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' cbPilih
        ' 
        cbPilih.FormattingEnabled = True
        cbPilih.Items.AddRange(New Object() {"Barang Masuk", "Barang Keluar", "Transfer Gudang", "Stock Opname", "Stok Gudang"})
        cbPilih.Location = New Point(742, 186)
        cbPilih.Name = "cbPilih"
        cbPilih.Size = New Size(571, 28)
        cbPilih.TabIndex = 0
        ' 
        ' dtDari
        ' 
        dtDari.Location = New Point(343, 123)
        dtDari.Name = "dtDari"
        dtDari.Size = New Size(250, 27)
        dtDari.TabIndex = 1
        ' 
        ' dtSampai
        ' 
        dtSampai.Location = New Point(343, 180)
        dtSampai.Name = "dtSampai"
        dtSampai.Size = New Size(250, 27)
        dtSampai.TabIndex = 2
        ' 
        ' txtCari
        ' 
        txtCari.Location = New Point(742, 123)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(571, 27)
        txtCari.TabIndex = 3
        ' 
        ' btnTampilkan
        ' 
        btnTampilkan.BackColor = SystemColors.ActiveCaptionText
        btnTampilkan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTampilkan.ForeColor = SystemColors.ButtonHighlight
        btnTampilkan.Location = New Point(742, 256)
        btnTampilkan.Name = "btnTampilkan"
        btnTampilkan.Size = New Size(146, 29)
        btnTampilkan.TabIndex = 5
        btnTampilkan.Text = "Tampilkan"
        btnTampilkan.UseVisualStyleBackColor = False
        ' 
        ' btnExport
        ' 
        btnExport.BackColor = SystemColors.AppWorkspace
        btnExport.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExport.ForeColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        btnExport.Location = New Point(957, 256)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(146, 29)
        btnExport.TabIndex = 6
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = False
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.Transparent
        btnKembali.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.Location = New Point(1167, 256)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(146, 29)
        btnKembali.TabIndex = 7
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' dgLaporan
        ' 
        dgLaporan.BackgroundColor = SystemColors.ButtonFace
        dgLaporan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgLaporan.Location = New Point(184, 312)
        dgLaporan.Name = "dgLaporan"
        dgLaporan.RowHeadersWidth = 51
        dgLaporan.Size = New Size(1129, 526)
        dgLaporan.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(665, 126)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 20)
        Label1.TabIndex = 9
        Label1.Text = "Cari Data"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(184, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 20)
        Label2.TabIndex = 10
        Label2.Text = "Dari Tanggal"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(183, 187)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 20)
        Label3.TabIndex = 11
        Label3.Text = "Sampai Tanggal"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label4.Location = New Point(642, 39)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 37)
        Label4.TabIndex = 12
        Label4.Text = "Laporan"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(665, 187)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 20)
        Label5.TabIndex = 13
        Label5.Text = "Pilih"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo_hitam_60x60
        PictureBox1.Location = New Point(577, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(59, 60)
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' FromLaporan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        ClientSize = New Size(1501, 901)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgLaporan)
        Controls.Add(btnKembali)
        Controls.Add(btnExport)
        Controls.Add(btnTampilkan)
        Controls.Add(txtCari)
        Controls.Add(dtSampai)
        Controls.Add(dtDari)
        Controls.Add(cbPilih)
        Name = "FromLaporan"
        Text = "FromLaporan"
        CType(dgLaporan, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbPilih As ComboBox
    Friend WithEvents dtDari As DateTimePicker
    Friend WithEvents dtSampai As DateTimePicker
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnTampilkan As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents dgLaporan As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
