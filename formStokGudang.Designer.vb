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
        DataGridView1 = New DataGridView()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(172, 162)
        DataGridView1.Margin = New Padding(2, 2, 2, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(663, 227)
        DataGridView1.TabIndex = 24
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button4.Image = My.Resources.Resources.Kembali
        Button4.Location = New Point(685, 408)
        Button4.Name = "Button4"
        Button4.Size = New Size(150, 50)
        Button4.TabIndex = 41
        Button4.UseVisualStyleBackColor = False
        ' 
        ' formStokGudang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        ClientSize = New Size(1006, 531)
        Controls.Add(Button4)
        Controls.Add(DataGridView1)
        Controls.Add(Cbfiltergudang)
        Controls.Add(Label2)
        Controls.Add(Txpencarianbarang)
        Controls.Add(Label1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "formStokGudang"
        Text = "formStokGudang"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Txpencarianbarang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Cbfiltergudang As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button4 As Button
End Class
