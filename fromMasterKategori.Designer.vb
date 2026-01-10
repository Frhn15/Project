<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromMasterKategori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fromMasterKategori))
        Panel1 = New Panel()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        btnkembali = New Button()
        Panel5 = New Panel()
        dgKategori = New DataGridView()
        Panel6 = New Panel()
        Label6 = New Label()
        Panel3 = New Panel()
        btnClear = New Button()
        btnEdit = New Button()
        Label2 = New Label()
        btnSimpan = New Button()
        Panel4 = New Panel()
        Label4 = New Label()
        txtNamaKategori = New TextBox()
        Label1 = New Label()
        txtKodeKategori = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel5.SuspendLayout()
        CType(dgKategori, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1262, 90)
        Panel1.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        Label3.Location = New Point(129, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(293, 41)
        Label3.TabIndex = 1
        Label3.Text = "MASTER KATEGORI"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(43, 6)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(80, 80)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnkembali)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 90)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1262, 583)
        Panel2.TabIndex = 8
        ' 
        ' btnkembali
        ' 
        btnkembali.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnkembali.FlatStyle = FlatStyle.Flat
        btnkembali.ForeColor = Color.FromArgb(CByte(67), CByte(67), CByte(67))
        btnkembali.Location = New Point(1093, 373)
        btnkembali.Margin = New Padding(3, 4, 3, 4)
        btnkembali.Name = "btnkembali"
        btnkembali.Size = New Size(139, 36)
        btnkembali.TabIndex = 16
        btnkembali.Text = "Kembali"
        btnkembali.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(dgKategori)
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(Label6)
        Panel5.Location = New Point(523, 70)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(712, 280)
        Panel5.TabIndex = 15
        ' 
        ' dgKategori
        ' 
        dgKategori.AllowUserToAddRows = False
        dgKategori.AllowUserToDeleteRows = False
        dgKategori.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgKategori.BackgroundColor = Color.FromArgb(CByte(225), CByte(225), CByte(225))
        dgKategori.BorderStyle = BorderStyle.None
        dgKategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgKategori.EnableHeadersVisualStyles = False
        dgKategori.GridColor = Color.FromArgb(CByte(167), CByte(163), CByte(156))
        dgKategori.Location = New Point(3, 54)
        dgKategori.MultiSelect = False
        dgKategori.Name = "dgKategori"
        dgKategori.ReadOnly = True
        dgKategori.RowHeadersVisible = False
        dgKategori.RowHeadersWidth = 51
        dgKategori.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgKategori.Size = New Size(706, 223)
        dgKategori.TabIndex = 18
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Panel6.Location = New Point(171, 29)
        Panel6.Margin = New Padding(3, 4, 3, 4)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(500, 1)
        Panel6.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        Label6.Location = New Point(4, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(160, 28)
        Label6.TabIndex = 16
        Label6.Text = "Daftar Kategori"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(225), CByte(216), CByte(202))
        Panel3.Controls.Add(btnClear)
        Panel3.Controls.Add(btnEdit)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(btnSimpan)
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(txtNamaKategori)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(txtKodeKategori)
        Panel3.Location = New Point(44, 70)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(20)
        Panel3.Size = New Size(460, 280)
        Panel3.TabIndex = 14
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.FromArgb(CByte(225), CByte(216), CByte(203))
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        btnClear.Location = New Point(304, 206)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(128, 36)
        btnClear.TabIndex = 21
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnEdit.Location = New Point(165, 206)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(128, 36)
        btnEdit.TabIndex = 19
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(23, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 20)
        Label2.TabIndex = 16
        Label2.Text = "Nama kategori"
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        btnSimpan.FlatAppearance.BorderSize = 0
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnSimpan.Location = New Point(23, 206)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(128, 36)
        btnSimpan.TabIndex = 11
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Panel4.Location = New Point(167, 29)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(265, 1)
        Panel4.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        Label4.Location = New Point(12, 12)
        Label4.Name = "Label4"
        Label4.Size = New Size(149, 28)
        Label4.TabIndex = 0
        Label4.Text = "Input Kategori"
        ' 
        ' txtNamaKategori
        ' 
        txtNamaKategori.Location = New Point(167, 135)
        txtNamaKategori.Name = "txtNamaKategori"
        txtNamaKategori.Size = New Size(265, 27)
        txtNamaKategori.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(23, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 20)
        Label1.TabIndex = 7
        Label1.Text = "Kode kategori"
        ' 
        ' txtKodeKategori
        ' 
        txtKodeKategori.Location = New Point(167, 69)
        txtKodeKategori.Name = "txtKodeKategori"
        txtKodeKategori.Size = New Size(265, 27)
        txtKodeKategori.TabIndex = 9
        ' 
        ' fromMasterKategori
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        ClientSize = New Size(1262, 673)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "fromMasterKategori"
        StartPosition = FormStartPosition.CenterScreen
        Text = "fromMasterKategori"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(dgKategori, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents txtNamaKategori As TextBox
    Friend WithEvents txtKodeKategori As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents dgKategori As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btnkembali As Button
End Class
