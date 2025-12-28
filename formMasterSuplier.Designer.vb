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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMasterSuplier))
        Label1 = New Label()
        Label2 = New Label()
        Txkodesupplier = New TextBox()
        Mtnotelepon = New MaskedTextBox()
        Txnamasupplier = New TextBox()
        Label3 = New Label()
        Txalamatsupplier = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
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
        Label1.Location = New Point(394, 34)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 37)
        Label1.TabIndex = 18
        Label1.Text = "MASTER SUPPLIER"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Location = New Point(220, 118)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 20)
        Label2.TabIndex = 19
        Label2.Text = "Kode Supplier"
        ' 
        ' Txkodesupplier
        ' 
        Txkodesupplier.BackColor = Color.White
        Txkodesupplier.Location = New Point(377, 118)
        Txkodesupplier.Name = "Txkodesupplier"
        Txkodesupplier.Size = New Size(456, 27)
        Txkodesupplier.TabIndex = 20
        ' 
        ' Mtnotelepon
        ' 
        Mtnotelepon.BackColor = Color.White
        Mtnotelepon.Location = New Point(377, 318)
        Mtnotelepon.Name = "Mtnotelepon"
        Mtnotelepon.Size = New Size(456, 27)
        Mtnotelepon.TabIndex = 22
        ' 
        ' Txnamasupplier
        ' 
        Txnamasupplier.BackColor = Color.White
        Txnamasupplier.Location = New Point(377, 183)
        Txnamasupplier.Name = "Txnamasupplier"
        Txnamasupplier.Size = New Size(456, 27)
        Txnamasupplier.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Location = New Point(220, 182)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 20)
        Label3.TabIndex = 23
        Label3.Text = "Nama Supplier"
        ' 
        ' Txalamatsupplier
        ' 
        Txalamatsupplier.BackColor = Color.White
        Txalamatsupplier.Location = New Point(377, 247)
        Txalamatsupplier.Name = "Txalamatsupplier"
        Txalamatsupplier.Size = New Size(456, 27)
        Txalamatsupplier.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Location = New Point(220, 246)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 25
        Label4.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Location = New Point(220, 317)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 20)
        Label5.TabIndex = 27
        Label5.Text = "No Telepon"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button4.Image = My.Resources.Resources.Kembali
        Button4.Location = New Point(686, 383)
        Button4.Name = "Button4"
        Button4.Size = New Size(150, 50)
        Button4.TabIndex = 31
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button3.Image = My.Resources.Resources.hapus
        Button3.Location = New Point(524, 383)
        Button3.Name = "Button3"
        Button3.Size = New Size(150, 50)
        Button3.TabIndex = 30
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.Location = New Point(364, 383)
        Button2.Name = "Button2"
        Button2.Size = New Size(150, 50)
        Button2.TabIndex = 29
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(207, 384)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 50)
        Button1.TabIndex = 28
        Button1.UseVisualStyleBackColor = False
        ' 
        ' formMasterSuplier
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
        Controls.Add(Label5)
        Controls.Add(Txalamatsupplier)
        Controls.Add(Label4)
        Controls.Add(Txnamasupplier)
        Controls.Add(Label3)
        Controls.Add(Mtnotelepon)
        Controls.Add(Txkodesupplier)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "formMasterSuplier"
        Text = "formMasterSuplier"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Txkodesupplier As TextBox
    Friend WithEvents Mtnotelepon As MaskedTextBox
    Friend WithEvents Txnamasupplier As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txalamatsupplier As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
