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
        Label1 = New Label()
        Txalamatgudang = New TextBox()
        Label4 = New Label()
        Txnamagudang = New TextBox()
        Label3 = New Label()
        Txkodegudang = New TextBox()
        Label2 = New Label()
        Btnhapus = New Button()
        Btnsimpan = New Button()
        Btnedit = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(490, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(299, 45)
        Label1.TabIndex = 19
        Label1.Text = "MASTER GUDANG"
        ' 
        ' Txalamatgudang
        ' 
        Txalamatgudang.BackColor = Color.LightGray
        Txalamatgudang.BorderStyle = BorderStyle.FixedSingle
        Txalamatgudang.Location = New Point(442, 339)
        Txalamatgudang.Margin = New Padding(4)
        Txalamatgudang.Name = "Txalamatgudang"
        Txalamatgudang.Size = New Size(570, 31)
        Txalamatgudang.TabIndex = 32
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(246, 338)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 25)
        Label4.TabIndex = 31
        Label4.Text = "Alamat"
        ' 
        ' Txnamagudang
        ' 
        Txnamagudang.BackColor = Color.LightGray
        Txnamagudang.BorderStyle = BorderStyle.FixedSingle
        Txnamagudang.Location = New Point(442, 259)
        Txnamagudang.Margin = New Padding(4)
        Txnamagudang.Name = "Txnamagudang"
        Txnamagudang.Size = New Size(570, 31)
        Txnamagudang.TabIndex = 30
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(246, 258)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 25)
        Label3.TabIndex = 29
        Label3.Text = "Nama Gudang"
        ' 
        ' Txkodegudang
        ' 
        Txkodegudang.BackColor = Color.LightGray
        Txkodegudang.BorderStyle = BorderStyle.FixedSingle
        Txkodegudang.Location = New Point(442, 178)
        Txkodegudang.Margin = New Padding(4)
        Txkodegudang.Name = "Txkodegudang"
        Txkodegudang.Size = New Size(570, 31)
        Txkodegudang.TabIndex = 28
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(246, 178)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 25)
        Label2.TabIndex = 27
        Label2.Text = "Kode Gudang"
        ' 
        ' Btnhapus
        ' 
        Btnhapus.BackColor = Color.DimGray
        Btnhapus.ForeColor = Color.White
        Btnhapus.Location = New Point(677, 427)
        Btnhapus.Margin = New Padding(4)
        Btnhapus.Name = "Btnhapus"
        Btnhapus.Size = New Size(112, 34)
        Btnhapus.TabIndex = 35
        Btnhapus.Text = "Hapus"
        Btnhapus.UseVisualStyleBackColor = False
        ' 
        ' Btnsimpan
        ' 
        Btnsimpan.BackColor = Color.DimGray
        Btnsimpan.ForeColor = Color.White
        Btnsimpan.Location = New Point(902, 427)
        Btnsimpan.Margin = New Padding(4)
        Btnsimpan.Name = "Btnsimpan"
        Btnsimpan.Size = New Size(112, 34)
        Btnsimpan.TabIndex = 34
        Btnsimpan.Text = "Simpan"
        Btnsimpan.UseVisualStyleBackColor = False
        ' 
        ' Btnedit
        ' 
        Btnedit.BackColor = Color.DimGray
        Btnedit.ForeColor = Color.White
        Btnedit.Location = New Point(444, 427)
        Btnedit.Margin = New Padding(4)
        Btnedit.Name = "Btnedit"
        Btnedit.Size = New Size(112, 34)
        Btnedit.TabIndex = 33
        Btnedit.Text = "Edit"
        Btnedit.UseVisualStyleBackColor = False
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
        PictureBox1.TabIndex = 36
        PictureBox1.TabStop = False
        ' 
        ' fromMastergudang
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1258, 664)
        Controls.Add(Btnhapus)
        Controls.Add(Btnsimpan)
        Controls.Add(Btnedit)
        Controls.Add(PictureBox1)
        Controls.Add(Txalamatgudang)
        Controls.Add(Label4)
        Controls.Add(Txnamagudang)
        Controls.Add(Label3)
        Controls.Add(Txkodegudang)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(4, 4, 4, 4)
        Name = "fromMastergudang"
        Text = "fromMastergudang"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txalamatgudang As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txnamagudang As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txkodegudang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Btnhapus As Button
    Friend WithEvents Btnsimpan As Button
    Friend WithEvents Btnedit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
