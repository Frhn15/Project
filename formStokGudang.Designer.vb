<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formStokGudang
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
        Txpencarianbarang = New TextBox()
        Label2 = New Label()
        Cbfiltergudang = New ComboBox()
        dgStokGudang = New DataGridView()
        btnKembali = New Button()
        PictureBox1 = New PictureBox()
        CType(dgStokGudang, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(400, 40)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(210, 37)
        Label1.TabIndex = 19
        Label1.Text = "STOK GUDANG"
        ' 
        ' Txpencarianbarang
        ' 
        Txpencarianbarang.BackColor = Color.White
        Txpencarianbarang.BorderStyle = BorderStyle.FixedSingle
        Txpencarianbarang.ForeColor = Color.DimGray
        Txpencarianbarang.Location = New Point(172, 112)
        Txpencarianbarang.Name = "Txpencarianbarang"
        Txpencarianbarang.Size = New Size(334, 27)
        Txpencarianbarang.TabIndex = 20
        Txpencarianbarang.Text = "Pencarian Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(172, 134)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 21
        ' 
        ' Cbfiltergudang
        ' 
        Cbfiltergudang.BackColor = Color.White
        Cbfiltergudang.ForeColor = Color.DimGray
        Cbfiltergudang.FormattingEnabled = True
        Cbfiltergudang.Location = New Point(690, 112)
        Cbfiltergudang.Name = "Cbfiltergudang"
        Cbfiltergudang.Size = New Size(146, 28)
        Cbfiltergudang.TabIndex = 23
        Cbfiltergudang.Text = "FIlter Gudang"
        ' 
        ' dgStokGudang
        ' 
        dgStokGudang.BackgroundColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        dgStokGudang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgStokGudang.Location = New Point(172, 162)
        dgStokGudang.Margin = New Padding(2)
        dgStokGudang.Name = "dgStokGudang"
        dgStokGudang.RowHeadersWidth = 62
        dgStokGudang.Size = New Size(663, 227)
        dgStokGudang.TabIndex = 24
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnKembali.Image = My.Resources.Resources.Kembali
        btnKembali.Location = New Point(685, 408)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(150, 50)
        btnKembali.TabIndex = 41
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo_hitam_60x60
        PictureBox1.Location = New Point(337, 29)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(58, 59)
        PictureBox1.TabIndex = 42
        PictureBox1.TabStop = False
        ' 
        ' formStokGudang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        ClientSize = New Size(1006, 531)
        Controls.Add(PictureBox1)
        Controls.Add(btnKembali)
        Controls.Add(dgStokGudang)
        Controls.Add(Cbfiltergudang)
        Controls.Add(Label2)
        Controls.Add(Txpencarianbarang)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "formStokGudang"
        Text = "formStokGudang"
        CType(dgStokGudang, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txpencarianbarang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Cbfiltergudang As ComboBox
    Friend WithEvents dgStokGudang As DataGridView
    Friend WithEvents btnKembali As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
