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
        Panel1 = New Panel()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        CType(dgGudang, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Anchor = AnchorStyles.None
        txtAlamat.BackColor = Color.White
        txtAlamat.Location = New Point(287, 216)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(265, 27)
        txtAlamat.TabIndex = 32
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(130, 215)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 20)
        Label4.TabIndex = 31
        Label4.Text = "Lokasi"
        ' 
        ' txtNamaGudang
        ' 
        txtNamaGudang.Anchor = AnchorStyles.None
        txtNamaGudang.BackColor = Color.White
        txtNamaGudang.Location = New Point(740, 157)
        txtNamaGudang.Name = "txtNamaGudang"
        txtNamaGudang.Size = New Size(265, 27)
        txtNamaGudang.TabIndex = 30
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(583, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 20)
        Label3.TabIndex = 29
        Label3.Text = "Nama Gudang"
        ' 
        ' txtKodeGudang
        ' 
        txtKodeGudang.Anchor = AnchorStyles.None
        txtKodeGudang.BackColor = Color.White
        txtKodeGudang.Location = New Point(287, 153)
        txtKodeGudang.Name = "txtKodeGudang"
        txtKodeGudang.Size = New Size(265, 27)
        txtKodeGudang.TabIndex = 28
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(130, 153)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 27
        Label2.Text = "Kode Gudang"
        ' 
        ' btnKembali
        ' 
        btnKembali.Anchor = AnchorStyles.None
        btnKembali.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnKembali.Image = My.Resources.Resources.Kembali
        btnKembali.Location = New Point(855, 281)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(150, 50)
        btnKembali.TabIndex = 40
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.Anchor = AnchorStyles.None
        btnHapus.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnHapus.Image = My.Resources.Resources.hapus
        btnHapus.Location = New Point(619, 281)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(150, 50)
        btnHapus.TabIndex = 39
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.Anchor = AnchorStyles.None
        btnEdit.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), Image)
        btnEdit.Location = New Point(379, 281)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(150, 50)
        btnEdit.TabIndex = 38
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Anchor = AnchorStyles.None
        btnSimpan.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), Image)
        btnSimpan.Location = New Point(130, 281)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(150, 50)
        btnSimpan.TabIndex = 37
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' dgGudang
        ' 
        dgGudang.Anchor = AnchorStyles.None
        dgGudang.BackgroundColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        dgGudang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgGudang.Location = New Point(130, 365)
        dgGudang.Name = "dgGudang"
        dgGudang.RowHeadersWidth = 51
        dgGudang.Size = New Size(875, 300)
        dgGudang.TabIndex = 41
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(1, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1133, 90)
        Panel1.TabIndex = 43
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        Label6.Location = New Point(129, 24)
        Label6.Name = "Label6"
        Label6.Size = New Size(278, 41)
        Label6.TabIndex = 1
        Label6.Text = "MASTER GUDANG"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(43, 6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(80, 80)
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Anchor = AnchorStyles.None
        Panel2.Location = New Point(1, 94)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1133, 626)
        Panel2.TabIndex = 44
        ' 
        ' fromMastergudang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1134, 719)
        Controls.Add(Panel1)
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
        Controls.Add(Panel2)
        Name = "fromMastergudang"
        StartPosition = FormStartPosition.CenterScreen
        Text = "fromMastergudang"
        WindowState = FormWindowState.Maximized
        CType(dgGudang, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
End Class
