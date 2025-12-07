<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromTransaksiKeluar
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
        Label7 = New Label()
        Label4 = New Label()
        txtSize = New TextBox()
        Label3 = New Label()
        txtkategori = New TextBox()
        Label5 = New Label()
        txtNama = New TextBox()
        txtLokasi = New TextBox()
        Label2 = New Label()
        btnCari = New Button()
        txtKode = New TextBox()
        btnKeluar = New Button()
        Label1 = New Label()
        Label6 = New Label()
        Panel1 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("MS Reference Sans Serif", 16.2F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(68, 73)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(268, 40)
        Label7.TabIndex = 19
        Label7.Text = "Barang Keluar"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(42, 322)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 25)
        Label4.TabIndex = 9
        Label4.Text = "KATEGORI"
        ' 
        ' txtSize
        ' 
        txtSize.Location = New Point(240, 240)
        txtSize.Margin = New Padding(4)
        txtSize.Name = "txtSize"
        txtSize.Size = New Size(340, 31)
        txtSize.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(42, 244)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 25)
        Label3.TabIndex = 2
        Label3.Text = "SIZE"
        ' 
        ' txtkategori
        ' 
        txtkategori.Location = New Point(240, 314)
        txtkategori.Margin = New Padding(4)
        txtkategori.Name = "txtkategori"
        txtkategori.Size = New Size(340, 31)
        txtkategori.TabIndex = 11
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(42, 398)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(70, 25)
        Label5.TabIndex = 10
        Label5.Text = "LOKASI"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(240, 172)
        txtNama.Margin = New Padding(4)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(340, 31)
        txtNama.TabIndex = 4
        ' 
        ' txtLokasi
        ' 
        txtLokasi.Location = New Point(240, 394)
        txtLokasi.Margin = New Padding(4)
        txtLokasi.Name = "txtLokasi"
        txtLokasi.Size = New Size(340, 31)
        txtLokasi.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(42, 181)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 25)
        Label2.TabIndex = 1
        Label2.Text = "NAMA BARANG"
        ' 
        ' btnCari
        ' 
        btnCari.Location = New Point(240, 479)
        btnCari.Margin = New Padding(4)
        btnCari.Name = "btnCari"
        btnCari.Size = New Size(118, 36)
        btnCari.TabIndex = 13
        btnCari.Text = "cari"
        btnCari.UseVisualStyleBackColor = True
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(240, 104)
        txtKode.Margin = New Padding(4)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(340, 31)
        txtKode.TabIndex = 3
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(382, 479)
        btnKeluar.Margin = New Padding(4)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(118, 36)
        btnKeluar.TabIndex = 14
        btnKeluar.Text = "keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(42, 108)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 25)
        Label1.TabIndex = 0
        Label1.Text = "KODE BARANG"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(55, 455)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 25)
        Label6.TabIndex = 15
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(btnKeluar)
        Panel1.Controls.Add(txtKode)
        Panel1.Controls.Add(btnCari)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtLokasi)
        Panel1.Controls.Add(txtNama)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtkategori)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtSize)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(68, 174)
        Panel1.Margin = New Padding(4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(728, 559)
        Panel1.TabIndex = 16
        ' 
        ' fromTransaksiKeluar
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.assd1
        ClientSize = New Size(1233, 857)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        Margin = New Padding(4, 4, 4, 4)
        Name = "fromTransaksiKeluar"
        Text = "fromTransaksiKeluar"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSize As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtkategori As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtLokasi As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCari As Button
    Friend WithEvents txtKode As TextBox
    Friend WithEvents btnKeluar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
End Class
