<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromstockopname
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
        cbBarang = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        cbGudang = New ComboBox()
        Label4 = New Label()
        txtStokSistem = New TextBox()
        Label5 = New Label()
        nudStokFisik = New NumericUpDown()
        Label6 = New Label()
        txtSelisih = New TextBox()
        dgStockOpname = New DataGridView()
        btnSimpan = New Button()
        btnKembali = New Button()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        CType(nudStokFisik, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgStockOpname, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(716, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(234, 38)
        Label1.TabIndex = 0
        Label1.Text = "STOCK OPNAME"
        ' 
        ' cbBarang
        ' 
        cbBarang.FormattingEnabled = True
        cbBarang.Location = New Point(381, 127)
        cbBarang.Name = "cbBarang"
        cbBarang.Size = New Size(151, 28)
        cbBarang.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(281, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 2
        Label2.Text = "Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(281, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 20)
        Label3.TabIndex = 3
        Label3.Text = "Gudang"
        ' 
        ' cbGudang
        ' 
        cbGudang.FormattingEnabled = True
        cbGudang.Location = New Point(381, 181)
        cbGudang.Name = "cbGudang"
        cbGudang.Size = New Size(151, 28)
        cbGudang.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(281, 238)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 5
        Label4.Text = "Stok Sistem"
        ' 
        ' txtStokSistem
        ' 
        txtStokSistem.Location = New Point(381, 238)
        txtStokSistem.Name = "txtStokSistem"
        txtStokSistem.Size = New Size(245, 27)
        txtStokSistem.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(812, 125)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 20)
        Label5.TabIndex = 7
        Label5.Text = "Stok Fisik"
        ' 
        ' nudStokFisik
        ' 
        nudStokFisik.Location = New Point(931, 125)
        nudStokFisik.Name = "nudStokFisik"
        nudStokFisik.Size = New Size(150, 27)
        nudStokFisik.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(812, 181)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 20)
        Label6.TabIndex = 9
        Label6.Text = "Selisih"
        ' 
        ' txtSelisih
        ' 
        txtSelisih.Location = New Point(931, 182)
        txtSelisih.Name = "txtSelisih"
        txtSelisih.Size = New Size(246, 27)
        txtSelisih.TabIndex = 10
        ' 
        ' dgStockOpname
        ' 
        dgStockOpname.BackgroundColor = Color.White
        dgStockOpname.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgStockOpname.Location = New Point(289, 336)
        dgStockOpname.Name = "dgStockOpname"
        dgStockOpname.RowHeadersWidth = 51
        dgStockOpname.Size = New Size(888, 351)
        dgStockOpname.TabIndex = 11
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Black
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = SystemColors.ButtonHighlight
        btnSimpan.Location = New Point(812, 258)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(146, 29)
        btnSimpan.TabIndex = 12
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.Silver
        btnKembali.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.Location = New Point(489, 671)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(0, 0)
        btnKembali.TabIndex = 13
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.logo_hitam_60x60
        PictureBox1.Location = New Point(650, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(60, 60)
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Silver
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(1015, 258)
        Button1.Name = "Button1"
        Button1.Size = New Size(146, 29)
        Button1.TabIndex = 15
        Button1.Text = "Kembali"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' fromstockopname
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        ClientSize = New Size(1539, 799)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(btnKembali)
        Controls.Add(btnSimpan)
        Controls.Add(dgStockOpname)
        Controls.Add(txtSelisih)
        Controls.Add(Label6)
        Controls.Add(nudStokFisik)
        Controls.Add(Label5)
        Controls.Add(txtStokSistem)
        Controls.Add(Label4)
        Controls.Add(cbGudang)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(cbBarang)
        Controls.Add(Label1)
        Name = "fromstockopname"
        StartPosition = FormStartPosition.CenterParent
        Text = "fromstockopname"
        WindowState = FormWindowState.Maximized
        CType(nudStokFisik, ComponentModel.ISupportInitialize).EndInit()
        CType(dgStockOpname, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbBarang As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbGudang As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStokSistem As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents nudStokFisik As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSelisih As TextBox
    Friend WithEvents dgStockOpname As DataGridView
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
