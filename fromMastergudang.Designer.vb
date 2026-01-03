<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromMastergudang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fromMastergudang))
        Label1 = New Label()
        txtAlamat = New TextBox()
        Label4 = New Label()
        txtNamaGudang = New TextBox()
        Label3 = New Label()
        txtKodeGudang = New TextBox()
        Label2 = New Label()
        btnKembali = New Button()
        btnHapus = New Button()
        btnEdit = New Button()
        btnSimpan = New Button()
        dgGudang = New DataGridView()
        PictureBox1 = New PictureBox()
        CType(dgGudang, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(788, 55)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 37)
        Label1.TabIndex = 19
        Label1.Text = "MASTER GUDANG"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.White
        txtAlamat.Location = New Point(353, 455)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(456, 27)
        txtAlamat.TabIndex = 32
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(196, 454)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 20)
        Label4.TabIndex = 31
        Label4.Text = "Lokasi"
        ' 
        ' txtNamaGudang
        ' 
        txtNamaGudang.BackColor = Color.White
        txtNamaGudang.Location = New Point(353, 391)
        txtNamaGudang.Name = "txtNamaGudang"
        txtNamaGudang.Size = New Size(456, 27)
        txtNamaGudang.TabIndex = 30
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(196, 390)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 20)
        Label3.TabIndex = 29
        Label3.Text = "Nama Gudang"
        ' 
        ' txtKodeGudang
        ' 
        txtKodeGudang.BackColor = Color.White
        txtKodeGudang.Location = New Point(353, 326)
        txtKodeGudang.Name = "txtKodeGudang"
        txtKodeGudang.Size = New Size(456, 27)
        txtKodeGudang.TabIndex = 28
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(196, 326)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 27
        Label2.Text = "Kode Gudang"
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnKembali.Image = My.Resources.Resources.Kembali
        btnKembali.Location = New Point(667, 514)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(150, 50)
        btnKembali.TabIndex = 40
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnHapus.Image = My.Resources.Resources.hapus
        btnHapus.Location = New Point(505, 514)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(150, 50)
        btnHapus.TabIndex = 39
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), Image)
        btnEdit.Location = New Point(345, 514)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(150, 50)
        btnEdit.TabIndex = 38
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), Image)
        btnSimpan.Location = New Point(188, 515)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(150, 50)
        btnSimpan.TabIndex = 37
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' dgGudang
        ' 
        dgGudang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgGudang.Location = New Point(870, 204)
        dgGudang.Name = "dgGudang"
        dgGudang.RowHeadersWidth = 51
        dgGudang.Size = New Size(802, 488)
        dgGudang.TabIndex = 41
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.logo_hitam_60x60
        PictureBox1.Location = New Point(723, 44)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(60, 61)
        PictureBox1.TabIndex = 42
        PictureBox1.TabStop = False
        ' 
        ' fromMastergudang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1740, 840)
        Controls.Add(PictureBox1)
        Controls.Add(dgGudang)
        Controls.Add(btnKembali)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(btnSimpan)
        Controls.Add(txtAlamat)
        Controls.Add(Label4)
        Controls.Add(txtNamaGudang)
        Controls.Add(Label3)
        Controls.Add(txtKodeGudang)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "fromMastergudang"
        StartPosition = FormStartPosition.CenterScreen
        Text = "fromMastergudang"
        WindowState = FormWindowState.Maximized
        CType(dgGudang, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNamaGudang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKodeGudang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents dgGudang As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
