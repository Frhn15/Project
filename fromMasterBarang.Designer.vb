<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fromMasterBarang
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
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        ComboBox1 = New ComboBox()
        NumericUpDown1 = New NumericUpDown()
        txtID = New TextBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(96, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 20)
        Label1.TabIndex = 0
        Label1.Text = "Input Kode Barang"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(96, 101)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 1
        Label2.Text = "Nama Barang"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(96, 152)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 20)
        Label3.TabIndex = 2
        Label3.Text = "Pilih Kategori"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(102, 227)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 20)
        Label4.TabIndex = 3
        Label4.Text = "Lokasi"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(98, 192)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 20)
        Label5.TabIndex = 4
        Label5.Text = "Satuan"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(98, 273)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 20)
        Label6.TabIndex = 5
        Label6.Text = "Stok Minimal"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(215, 348)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 6
        Button1.Text = "simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(351, 348)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 7
        Button2.Text = "edit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(467, 348)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 8
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(451, 51)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(631, 188)
        DataGridView1.TabIndex = 9
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(271, 48)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(271, 101)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 11
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(271, 185)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 12
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(271, 240)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 13
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(271, 152)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 14
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(271, 283)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(150, 27)
        NumericUpDown1.TabIndex = 15
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(271, 12)
        txtID.Name = "txtID"
        txtID.Size = New Size(125, 27)
        txtID.TabIndex = 16
        ' 
        ' fromMasterBarang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1136, 450)
        Controls.Add(txtID)
        Controls.Add(NumericUpDown1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "fromMasterBarang"
        Text = "fromMasterBarang"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents txtID As TextBox
End Class
