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
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        ComboBox3 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        NumericUpDown1 = New NumericUpDown()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        Panel1 = New Panel()
        Label6 = New Label()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(490, 212)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(339, 28)
        ComboBox1.TabIndex = 0
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
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(490, 291)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(339, 28)
        ComboBox2.TabIndex = 2
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
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(490, 376)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(339, 28)
        ComboBox3.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DeepSkyBlue
        Button1.Location = New Point(1729, 751)
        Button1.Name = "Button1"
        Button1.Size = New Size(136, 29)
        Button1.TabIndex = 6
        Button1.Text = "Refresh"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaptionText
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(342, 552)
        Button2.Name = "Button2"
        Button2.Size = New Size(136, 29)
        Button2.TabIndex = 7
        Button2.Text = "Simpan"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.AppWorkspace
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.Location = New Point(510, 552)
        Button3.Name = "Button3"
        Button3.Size = New Size(136, 29)
        Button3.TabIndex = 8
        Button3.Text = "Tambah Item"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.OldLace
        Button4.ForeColor = SystemColors.ControlText
        Button4.Location = New Point(694, 552)
        Button4.Name = "Button4"
        Button4.Size = New Size(136, 29)
        Button4.TabIndex = 9
        Button4.Text = "Kembali"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(490, 458)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(142, 27)
        NumericUpDown1.TabIndex = 10
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
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonHighlight
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(898, 270)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(968, 453)
        DataGridView1.TabIndex = 12
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
        Controls.Add(DataGridView1)
        Controls.Add(Label4)
        Controls.Add(NumericUpDown1)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox3)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ComboBox2)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "FromTransferAntarGudang"
        Text = "FromTransferAntarGudang"
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
End Class
