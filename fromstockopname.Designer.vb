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
        CType(nudStokFisik, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgStockOpname, ComponentModel.ISupportInitialize).BeginInit()
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
        cbBarang.Location = New Point(458, 253)
        cbBarang.Name = "cbBarang"
        cbBarang.Size = New Size(151, 28)
        cbBarang.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(355, 253)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 2
        Label2.Text = "Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(355, 332)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 20)
        Label3.TabIndex = 3
        Label3.Text = "Gudang"
        ' 
        ' cbGudang
        ' 
        cbGudang.FormattingEnabled = True
        cbGudang.Location = New Point(458, 332)
        cbGudang.Name = "cbGudang"
        cbGudang.Size = New Size(151, 28)
        cbGudang.TabIndex = 4
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(355, 416)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 5
        Label4.Text = "Stok Sistem"
        ' 
        ' txtStokSistem
        ' 
        txtStokSistem.Location = New Point(459, 416)
        txtStokSistem.Name = "txtStokSistem"
        txtStokSistem.Size = New Size(245, 27)
        txtStokSistem.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(355, 499)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 20)
        Label5.TabIndex = 7
        Label5.Text = "Stok Fisik"
        ' 
        ' nudStokFisik
        ' 
        nudStokFisik.Location = New Point(459, 499)
        nudStokFisik.Name = "nudStokFisik"
        nudStokFisik.Size = New Size(150, 27)
        nudStokFisik.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(355, 580)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 20)
        Label6.TabIndex = 9
        Label6.Text = "Selisih"
        ' 
        ' txtSelisih
        ' 
        txtSelisih.Location = New Point(458, 577)
        txtSelisih.Name = "txtSelisih"
        txtSelisih.Size = New Size(246, 27)
        txtSelisih.TabIndex = 10
        ' 
        ' dgStockOpname
        ' 
        dgStockOpname.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgStockOpname.Location = New Point(787, 253)
        dgStockOpname.Name = "dgStockOpname"
        dgStockOpname.RowHeadersWidth = 51
        dgStockOpname.Size = New Size(593, 351)
        dgStockOpname.TabIndex = 11
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(355, 671)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 12
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnKembali
        ' 
        btnKembali.Location = New Point(489, 671)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(94, 29)
        btnKembali.TabIndex = 13
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = True
        ' 
        ' fromstockopname
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        ClientSize = New Size(1539, 799)
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
End Class
