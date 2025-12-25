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
        Label1 = New Label()
        Label2 = New Label()
        Txkodesupplier = New TextBox()
        Btnedit = New Button()
        Mtnotelepon = New MaskedTextBox()
        Txnamasupplier = New TextBox()
        Label3 = New Label()
        Txalamatsupplier = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Btnsimpan = New Button()
        Btnhapus = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(493, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(303, 45)
        Label1.TabIndex = 18
        Label1.Text = "MASTER SUPPLIER"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(275, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(123, 25)
        Label2.TabIndex = 19
        Label2.Text = "Kode Supplier"
        ' 
        ' Txkodesupplier
        ' 
        Txkodesupplier.BackColor = Color.LightGray
        Txkodesupplier.BorderStyle = BorderStyle.FixedSingle
        Txkodesupplier.Location = New Point(471, 148)
        Txkodesupplier.Margin = New Padding(4)
        Txkodesupplier.Name = "Txkodesupplier"
        Txkodesupplier.Size = New Size(570, 31)
        Txkodesupplier.TabIndex = 20
        ' 
        ' Btnedit
        ' 
        Btnedit.BackColor = Color.DimGray
        Btnedit.ForeColor = Color.White
        Btnedit.Location = New Point(471, 482)
        Btnedit.Margin = New Padding(4)
        Btnedit.Name = "Btnedit"
        Btnedit.Size = New Size(112, 34)
        Btnedit.TabIndex = 21
        Btnedit.Text = "Edit"
        Btnedit.UseVisualStyleBackColor = False
        ' 
        ' Mtnotelepon
        ' 
        Mtnotelepon.BackColor = Color.LightGray
        Mtnotelepon.BorderStyle = BorderStyle.FixedSingle
        Mtnotelepon.Location = New Point(471, 397)
        Mtnotelepon.Margin = New Padding(4)
        Mtnotelepon.Name = "Mtnotelepon"
        Mtnotelepon.Size = New Size(570, 31)
        Mtnotelepon.TabIndex = 22
        ' 
        ' Txnamasupplier
        ' 
        Txnamasupplier.BackColor = Color.LightGray
        Txnamasupplier.BorderStyle = BorderStyle.FixedSingle
        Txnamasupplier.Location = New Point(471, 229)
        Txnamasupplier.Margin = New Padding(4)
        Txnamasupplier.Name = "Txnamasupplier"
        Txnamasupplier.Size = New Size(570, 31)
        Txnamasupplier.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(275, 228)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 25)
        Label3.TabIndex = 23
        Label3.Text = "Nama Supplier"
        ' 
        ' Txalamatsupplier
        ' 
        Txalamatsupplier.BackColor = Color.LightGray
        Txalamatsupplier.BorderStyle = BorderStyle.FixedSingle
        Txalamatsupplier.Location = New Point(471, 309)
        Txalamatsupplier.Margin = New Padding(4)
        Txalamatsupplier.Name = "Txalamatsupplier"
        Txalamatsupplier.Size = New Size(570, 31)
        Txalamatsupplier.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(275, 308)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 25)
        Label4.TabIndex = 25
        Label4.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(275, 396)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 25)
        Label5.TabIndex = 27
        Label5.Text = "No Telepon"
        ' 
        ' Btnsimpan
        ' 
        Btnsimpan.BackColor = Color.DimGray
        Btnsimpan.ForeColor = Color.White
        Btnsimpan.Location = New Point(929, 482)
        Btnsimpan.Margin = New Padding(4)
        Btnsimpan.Name = "Btnsimpan"
        Btnsimpan.Size = New Size(112, 34)
        Btnsimpan.TabIndex = 28
        Btnsimpan.Text = "Simpan"
        Btnsimpan.UseVisualStyleBackColor = False
        ' 
        ' Btnhapus
        ' 
        Btnhapus.BackColor = Color.DimGray
        Btnhapus.ForeColor = Color.White
        Btnhapus.Location = New Point(704, 482)
        Btnhapus.Margin = New Padding(4)
        Btnhapus.Name = "Btnhapus"
        Btnhapus.Size = New Size(112, 34)
        Btnhapus.TabIndex = 29
        Btnhapus.Text = "Hapus"
        Btnhapus.UseVisualStyleBackColor = False
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
        PictureBox1.TabIndex = 30
        PictureBox1.TabStop = False
        ' 
        ' formMasterSuplier
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1258, 664)
        Controls.Add(Btnhapus)
        Controls.Add(Btnsimpan)
        Controls.Add(Label5)
        Controls.Add(Txalamatsupplier)
        Controls.Add(Label4)
        Controls.Add(Txnamasupplier)
        Controls.Add(Label3)
        Controls.Add(Mtnotelepon)
        Controls.Add(Btnedit)
        Controls.Add(Txkodesupplier)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Margin = New Padding(4)
        Name = "formMasterSuplier"
        Text = "formMasterSuplier"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txkodesupplier As TextBox
    Friend WithEvents Btnedit As Button
    Friend WithEvents Mtnotelepon As MaskedTextBox
    Friend WithEvents Txnamasupplier As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txalamatsupplier As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Btnsimpan As Button
    Friend WithEvents Btnhapus As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
