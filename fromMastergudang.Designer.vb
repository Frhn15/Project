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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fromMastergudang))
        Label1 = New Label()
        Txalamatgudang = New TextBox()
        Label4 = New Label()
        Txnamagudang = New TextBox()
        Label3 = New Label()
        Txkodegudang = New TextBox()
        Label2 = New Label()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(392, 48)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 37)
        Label1.TabIndex = 19
        Label1.Text = "MASTER GUDANG"
        ' 
        ' Txalamatgudang
        ' 
        Txalamatgudang.BackColor = Color.White
        Txalamatgudang.Location = New Point(354, 271)
        Txalamatgudang.Name = "Txalamatgudang"
        Txalamatgudang.Size = New Size(456, 27)
        Txalamatgudang.TabIndex = 32
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(197, 270)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 31
        Label4.Text = "Alamat"
        ' 
        ' Txnamagudang
        ' 
        Txnamagudang.BackColor = Color.White
        Txnamagudang.Location = New Point(354, 207)
        Txnamagudang.Name = "Txnamagudang"
        Txnamagudang.Size = New Size(456, 27)
        Txnamagudang.TabIndex = 30
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(197, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 20)
        Label3.TabIndex = 29
        Label3.Text = "Nama Gudang"
        ' 
        ' Txkodegudang
        ' 
        Txkodegudang.BackColor = Color.White
        Txkodegudang.Location = New Point(354, 142)
        Txkodegudang.Name = "Txkodegudang"
        Txkodegudang.Size = New Size(456, 27)
        Txkodegudang.TabIndex = 28
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(197, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 20)
        Label2.TabIndex = 27
        Label2.Text = "Kode Gudang"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button4.Image = My.Resources.Resources.Kembali
        Button4.Location = New Point(668, 330)
        Button4.Name = "Button4"
        Button4.Size = New Size(150, 50)
        Button4.TabIndex = 40
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button3.Image = My.Resources.Resources.hapus
        Button3.Location = New Point(506, 330)
        Button3.Name = "Button3"
        Button3.Size = New Size(150, 50)
        Button3.TabIndex = 39
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(346, 330)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 50)
        Button2.TabIndex = 38
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(189, 331)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 50)
        Button1.TabIndex = 37
        Button1.UseVisualStyleBackColor = False
        ' 
        ' fromMastergudang
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1006, 531)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Txalamatgudang)
        Controls.Add(Label4)
        Controls.Add(Txnamagudang)
        Controls.Add(Label3)
        Controls.Add(Txkodegudang)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "fromMastergudang"
        Text = "fromMastergudang"
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
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
