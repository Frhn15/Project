<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMasterSuplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMasterSuplier))
        Label2 = New Label()
        txtKodeSupplier = New TextBox()
        txtNoTelp = New MaskedTextBox()
        txtNamaSupplier = New TextBox()
        Label3 = New Label()
        txtAlamat = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        btnKembali = New Button()
        btnHapus = New Button()
        btnEdit = New Button()
        btnSimpan = New Button()
        dgSupplier = New DataGridView()
        Panel1 = New Panel()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel5 = New Panel()
        CType(dgSupplier, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(142, 66)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 20)
        Label2.TabIndex = 19
        Label2.Text = "Kode Supplier"
        ' 
        ' txtKodeSupplier
        ' 
        txtKodeSupplier.Anchor = AnchorStyles.None
        txtKodeSupplier.BackColor = Color.White
        txtKodeSupplier.Location = New Point(272, 66)
        txtKodeSupplier.Name = "txtKodeSupplier"
        txtKodeSupplier.Size = New Size(276, 27)
        txtKodeSupplier.TabIndex = 20
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.Anchor = AnchorStyles.None
        txtNoTelp.BackColor = Color.White
        txtNoTelp.Location = New Point(705, 134)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(276, 27)
        txtNoTelp.TabIndex = 22
        ' 
        ' txtNamaSupplier
        ' 
        txtNamaSupplier.Anchor = AnchorStyles.None
        txtNamaSupplier.BackColor = Color.White
        txtNamaSupplier.Location = New Point(272, 131)
        txtNamaSupplier.Name = "txtNamaSupplier"
        txtNamaSupplier.Size = New Size(276, 27)
        txtNamaSupplier.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(141, 130)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 20)
        Label3.TabIndex = 23
        Label3.Text = "Nama Supplier"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.Anchor = AnchorStyles.None
        txtAlamat.BackColor = Color.White
        txtAlamat.Location = New Point(705, 63)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(276, 27)
        txtAlamat.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(609, 67)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 25
        Label4.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.None
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(609, 138)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 20)
        Label5.TabIndex = 27
        Label5.Text = "No Telepon"
        ' 
        ' btnKembali
        ' 
        btnKembali.Anchor = AnchorStyles.None
        btnKembali.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnKembali.Image = My.Resources.Resources.Kembali
        btnKembali.Location = New Point(831, 196)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(150, 50)
        btnKembali.TabIndex = 31
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
        btnHapus.Location = New Point(609, 196)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(150, 50)
        btnHapus.TabIndex = 30
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
        btnEdit.Location = New Point(381, 196)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(150, 50)
        btnEdit.TabIndex = 29
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
        btnSimpan.Location = New Point(141, 196)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(150, 50)
        btnSimpan.TabIndex = 28
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' dgSupplier
        ' 
        dgSupplier.Anchor = AnchorStyles.None
        dgSupplier.BackgroundColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        dgSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgSupplier.Location = New Point(141, 334)
        dgSupplier.Name = "dgSupplier"
        dgSupplier.RowHeadersWidth = 51
        dgSupplier.Size = New Size(839, 266)
        dgSupplier.TabIndex = 32
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(2, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1132, 90)
        Panel1.TabIndex = 34
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.None
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        Label6.Location = New Point(129, 24)
        Label6.Name = "Label6"
        Label6.Size = New Size(283, 41)
        Label6.TabIndex = 1
        Label6.Text = "MASTER SUPPLIER"
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
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(dgSupplier)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(btnSimpan)
        Panel2.Controls.Add(btnEdit)
        Panel2.Controls.Add(btnHapus)
        Panel2.Controls.Add(btnKembali)
        Panel2.Controls.Add(txtKodeSupplier)
        Panel2.Controls.Add(txtNoTelp)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(txtNamaSupplier)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(txtAlamat)
        Panel2.Location = New Point(2, 92)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1132, 624)
        Panel2.TabIndex = 35
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        Label1.Location = New Point(152, 291)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 25)
        Label1.TabIndex = 43
        Label1.Text = "Daftar Supplier"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Panel5.Location = New Point(297, 306)
        Panel5.Margin = New Padding(3, 4, 3, 4)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(665, 2)
        Panel5.TabIndex = 33
        ' 
        ' formMasterSuplier
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1134, 719)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "formMasterSuplier"
        StartPosition = FormStartPosition.CenterParent
        Text = "formMasterSuplier"
        WindowState = FormWindowState.Maximized
        CType(dgSupplier, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKodeSupplier As TextBox
    Friend WithEvents txtNoTelp As MaskedTextBox
    Friend WithEvents txtNamaSupplier As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents dgSupplier As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
End Class
