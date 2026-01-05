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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formStokGudang))
        Txpencarianbarang = New TextBox()
        Label2 = New Label()
        Cbfiltergudang = New ComboBox()
        dgStokGudang = New DataGridView()
        btnKembali = New Button()
        Panel1 = New Panel()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        Panel5 = New Panel()
        Label1 = New Label()
        CType(dgStokGudang, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Txpencarianbarang
        ' 
        Txpencarianbarang.BackColor = Color.White
        Txpencarianbarang.ForeColor = Color.DimGray
        Txpencarianbarang.Location = New Point(88, 63)
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
        Cbfiltergudang.Location = New Point(767, 63)
        Cbfiltergudang.Name = "Cbfiltergudang"
        Cbfiltergudang.Size = New Size(252, 28)
        Cbfiltergudang.TabIndex = 23
        Cbfiltergudang.Text = "FIlter Gudang"
        ' 
        ' dgStokGudang
        ' 
        dgStokGudang.BackgroundColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        dgStokGudang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgStokGudang.Location = New Point(88, 183)
        dgStokGudang.Margin = New Padding(2)
        dgStokGudang.Name = "dgStokGudang"
        dgStokGudang.RowHeadersWidth = 62
        dgStokGudang.Size = New Size(931, 301)
        dgStokGudang.TabIndex = 24
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnKembali.FlatStyle = FlatStyle.Flat
        btnKembali.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKembali.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnKembali.Image = My.Resources.Resources.Kembali
        btnKembali.Location = New Point(869, 489)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(150, 50)
        btnKembali.TabIndex = 41
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(2, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1133, 90)
        Panel1.TabIndex = 43
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        Label6.Location = New Point(129, 24)
        Label6.Name = "Label6"
        Label6.Size = New Size(233, 41)
        Label6.TabIndex = 1
        Label6.Text = "STOK GUDANG"
        ' 
        ' PictureBox2
        ' 
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
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(dgStokGudang)
        Panel2.Controls.Add(btnKembali)
        Panel2.Controls.Add(Txpencarianbarang)
        Panel2.Controls.Add(Cbfiltergudang)
        Panel2.Location = New Point(2, 94)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1133, 622)
        Panel2.TabIndex = 44
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(150), CByte(150), CByte(150))
        Panel5.Location = New Point(214, 130)
        Panel5.Margin = New Padding(3, 4, 3, 4)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(805, 2)
        Panel5.TabIndex = 43
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        Label1.Location = New Point(88, 119)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 25)
        Label1.TabIndex = 42
        Label1.Text = "Daftar Stok"
        ' 
        ' formStokGudang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        ClientSize = New Size(1132, 718)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(Panel2)
        Margin = New Padding(2)
        Name = "formStokGudang"
        Text = "formStokGudang"
        CType(dgStokGudang, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Txpencarianbarang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Cbfiltergudang As ComboBox
    Friend WithEvents dgStokGudang As DataGridView
    Friend WithEvents btnKembali As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
End Class
