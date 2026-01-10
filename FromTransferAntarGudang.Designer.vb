<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FromTransferAntarGudang
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
        cbGudangAsal = New ComboBox()
        Label1 = New Label()
        cbGudangTujuan = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        cbBarang = New ComboBox()
        btnRefresh = New Button()
        btnSimpan = New Button()
        btnTambahItem = New Button()
        btnKembali = New Button()
        nudQty = New NumericUpDown()
        Label4 = New Label()
        dgList = New DataGridView()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label6 = New Label()
        CType(nudQty, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgList, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' cbGudangAsal
        ' 
        cbGudangAsal.FormattingEnabled = True
        cbGudangAsal.Location = New Point(490, 212)
        cbGudangAsal.Name = "cbGudangAsal"
        cbGudangAsal.Size = New Size(339, 28)
        cbGudangAsal.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(342, 220)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 20)
        Label1.TabIndex = 1
        Label1.Text = "Gudang Asal"
        ' 
        ' cbGudangTujuan
        ' 
        cbGudangTujuan.FormattingEnabled = True
        cbGudangTujuan.Location = New Point(490, 291)
        cbGudangTujuan.Name = "cbGudangTujuan"
        cbGudangTujuan.Size = New Size(339, 28)
        cbGudangTujuan.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(342, 299)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 20)
        Label2.TabIndex = 3
        Label2.Text = "Gudang Tujuan"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(342, 384)
        Label3.Name = "Label3"
        Label3.Size = New Size(59, 20)
        Label3.TabIndex = 4
        Label3.Text = "Barang"
        ' 
        ' cbBarang
        ' 
        cbBarang.FormattingEnabled = True
        cbBarang.Location = New Point(490, 376)
        cbBarang.Name = "cbBarang"
        cbBarang.Size = New Size(339, 28)
        cbBarang.TabIndex = 5
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.DeepSkyBlue
        btnRefresh.Location = New Point(1729, 751)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(136, 29)
        btnRefresh.TabIndex = 6
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = SystemColors.ActiveCaptionText
        btnSimpan.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSimpan.ForeColor = SystemColors.ButtonHighlight
        btnSimpan.Location = New Point(342, 552)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(136, 29)
        btnSimpan.TabIndex = 7
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnTambahItem
        ' 
        btnTambahItem.BackColor = SystemColors.AppWorkspace
        btnTambahItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambahItem.ForeColor = SystemColors.ButtonHighlight
        btnTambahItem.Location = New Point(510, 552)
        btnTambahItem.Name = "btnTambahItem"
        btnTambahItem.Size = New Size(136, 29)
        btnTambahItem.TabIndex = 8
        btnTambahItem.Text = "Tambah Item"
        btnTambahItem.UseVisualStyleBackColor = False
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.OldLace
        btnKembali.ForeColor = SystemColors.ControlText
        btnKembali.Location = New Point(694, 552)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(136, 29)
        btnKembali.TabIndex = 9
        btnKembali.Text = "Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' nudQty
        ' 
        nudQty.Location = New Point(490, 458)
        nudQty.Name = "nudQty"
        nudQty.Size = New Size(142, 27)
        nudQty.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(342, 465)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 20)
        Label4.TabIndex = 11
        Label4.Text = "Qty"
        ' 
        ' dgList
        ' 
        dgList.BackgroundColor = SystemColors.ButtonHighlight
        dgList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgList.Location = New Point(898, 270)
        dgList.Name = "dgList"
        dgList.RowHeadersWidth = 51
        dgList.Size = New Size(968, 453)
        dgList.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F, FontStyle.Bold)
        Label5.Location = New Point(750, 44)
        Label5.Name = "Label5"
        Label5.Size = New Size(339, 41)
        Label5.TabIndex = 13
        Label5.Text = "Transfer Antar Gudang"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.logo_hitam_60x60
        PictureBox1.Location = New Point(680, 39)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 58)
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(898, 200)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(243, 59)
        Panel1.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 16F, FontStyle.Bold)
        Label6.Location = New Point(3, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(205, 37)
        Label6.TabIndex = 16
        Label6.Text = "Detail Transfer"
        ' 
        ' FromTransferAntarGudang
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 826)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(dgList)
        Controls.Add(Label4)
        Controls.Add(nudQty)
        Controls.Add(btnKembali)
        Controls.Add(btnTambahItem)
        Controls.Add(btnSimpan)
        Controls.Add(btnRefresh)
        Controls.Add(cbBarang)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(cbGudangTujuan)
        Controls.Add(Label1)
        Controls.Add(cbGudangAsal)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "FromTransferAntarGudang"
        Text = "FromTransferAntarGudang"
        CType(nudQty, ComponentModel.ISupportInitialize).EndInit()
        CType(dgList, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cbGudangAsal As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbGudangTujuan As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbBarang As ComboBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnTambahItem As Button
    Friend WithEvents btnKembali As Button
    Friend WithEvents nudQty As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents dgList As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
End Class
