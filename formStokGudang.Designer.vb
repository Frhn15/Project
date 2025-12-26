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
        Btnrefresh = New Button()
        Cbfiltergudang = New ComboBox()
        DataGridView1 = New DataGridView()
        PictureBox1 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(500, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(251, 45)
        Label1.TabIndex = 19
        Label1.Text = "STOK GUDANG"
        ' 
        ' Txpencarianbarang
        ' 
        Txpencarianbarang.BackColor = Color.LightGray
        Txpencarianbarang.BorderStyle = BorderStyle.FixedSingle
        Txpencarianbarang.ForeColor = Color.DimGray
        Txpencarianbarang.Location = New Point(215, 140)
        Txpencarianbarang.Margin = New Padding(4)
        Txpencarianbarang.Name = "Txpencarianbarang"
        Txpencarianbarang.Size = New Size(417, 31)
        Txpencarianbarang.TabIndex = 20
        Txpencarianbarang.Text = "Pencarian Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(215, 167)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 25)
        Label2.TabIndex = 21
        ' 
        ' Btnrefresh
        ' 
        Btnrefresh.BackColor = Color.DimGray
        Btnrefresh.ForeColor = Color.White
        Btnrefresh.Location = New Point(932, 511)
        Btnrefresh.Name = "Btnrefresh"
        Btnrefresh.Size = New Size(112, 34)
        Btnrefresh.TabIndex = 22
        Btnrefresh.Text = "Refresh"
        Btnrefresh.UseVisualStyleBackColor = False
        ' 
        ' Cbfiltergudang
        ' 
        Cbfiltergudang.BackColor = Color.LightGray
        Cbfiltergudang.ForeColor = Color.DimGray
        Cbfiltergudang.FormattingEnabled = True
        Cbfiltergudang.Location = New Point(862, 140)
        Cbfiltergudang.Margin = New Padding(4)
        Cbfiltergudang.Name = "Cbfiltergudang"
        Cbfiltergudang.Size = New Size(182, 33)
        Cbfiltergudang.TabIndex = 23
        Cbfiltergudang.Text = "FIlter Gudang"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.DarkGray
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(215, 202)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(829, 284)
        DataGridView1.TabIndex = 24
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = My.Resources.Resources.Logo_Kelompok_3_Sistem_Inventory
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Dock = DockStyle.Bottom
        PictureBox1.Location = New Point(0, 510)
        PictureBox1.Margin = New Padding(4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1258, 154)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 37
        PictureBox1.TabStop = False
        ' 
        ' formStokGudang
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1258, 664)
        Controls.Add(DataGridView1)
        Controls.Add(Cbfiltergudang)
        Controls.Add(Btnrefresh)
        Controls.Add(Label2)
        Controls.Add(Txpencarianbarang)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "formStokGudang"
        Text = "formStokGudang"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txpencarianbarang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btnrefresh As Button
    Friend WithEvents Cbfiltergudang As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
