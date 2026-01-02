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
        Label1 = New Label()
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
        CType(dgSupplier, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(737, 35)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 37)
        Label1.TabIndex = 18
        Label1.Text = "MASTER SUPPLIER"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(117, 350)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 20)
        Label2.TabIndex = 19
        Label2.Text = "Kode Supplier"
        ' 
        ' txtKodeSupplier
        ' 
        txtKodeSupplier.BackColor = Color.White
        txtKodeSupplier.Location = New Point(275, 350)
        txtKodeSupplier.Name = "txtKodeSupplier"
        txtKodeSupplier.Size = New Size(456, 27)
        txtKodeSupplier.TabIndex = 20
        ' 
        ' txtNoTelp
        ' 
        txtNoTelp.BackColor = Color.White
        txtNoTelp.Location = New Point(273, 550)
        txtNoTelp.Name = "txtNoTelp"
        txtNoTelp.Size = New Size(456, 27)
        txtNoTelp.TabIndex = 22
        ' 
        ' txtNamaSupplier
        ' 
        txtNamaSupplier.BackColor = Color.White
        txtNamaSupplier.Location = New Point(275, 415)
        txtNamaSupplier.Name = "txtNamaSupplier"
        txtNamaSupplier.Size = New Size(456, 27)
        txtNamaSupplier.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(116, 414)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 20)
        Label3.TabIndex = 23
        Label3.Text = "Nama Supplier"
        ' 
        ' txtAlamat
        ' 
        txtAlamat.BackColor = Color.White
        txtAlamat.Location = New Point(273, 479)
        txtAlamat.Name = "txtAlamat"
        txtAlamat.Size = New Size(456, 27)
        txtAlamat.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(116, 478)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 25
        Label4.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(116, 549)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 20)
        Label5.TabIndex = 27
        Label5.Text = "No Telepon"
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnKembali.Image = My.Resources.Resources.Kembali
        btnKembali.Location = New Point(582, 615)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(150, 50)
        btnKembali.TabIndex = 31
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnHapus.FlatStyle = FlatStyle.Flat
        btnHapus.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHapus.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnHapus.Image = My.Resources.Resources.hapus
        btnHapus.Location = New Point(420, 615)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(150, 50)
        btnHapus.TabIndex = 30
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), Image)
        btnEdit.Location = New Point(260, 615)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(150, 50)
        btnEdit.TabIndex = 29
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnSimpan.FlatStyle = FlatStyle.Flat
        btnSimpan.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), Image)
        btnSimpan.Location = New Point(103, 616)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(150, 50)
        btnSimpan.TabIndex = 28
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' dgSupplier
        ' 
        dgSupplier.BackgroundColor = SystemColors.ButtonHighlight
        dgSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgSupplier.Location = New Point(826, 208)
        dgSupplier.Name = "dgSupplier"
        dgSupplier.RowHeadersWidth = 51
        dgSupplier.Size = New Size(795, 670)
        dgSupplier.TabIndex = 32
        ' 
        ' formMasterSuplier
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1902, 1033)
        Controls.Add(dgSupplier)
        Controls.Add(btnKembali)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(btnSimpan)
        Controls.Add(Label5)
        Controls.Add(txtAlamat)
        Controls.Add(Label4)
        Controls.Add(txtNamaSupplier)
        Controls.Add(Label3)
        Controls.Add(txtNoTelp)
        Controls.Add(txtKodeSupplier)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "formMasterSuplier"
        StartPosition = FormStartPosition.CenterParent
        Text = "formMasterSuplier"
        WindowState = FormWindowState.Maximized
        CType(dgSupplier, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
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
End Class
