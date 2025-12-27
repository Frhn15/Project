<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnBack = New Button()
        PanelLogin = New Panel()
        Label4 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Label8 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        PanelLogin.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        Label1.Location = New Point(99, 195)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 20)
        Label1.TabIndex = 10
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        Label2.Location = New Point(99, 265)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 20)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Palatino Linotype", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(99, 218)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(300, 28)
        txtUsername.TabIndex = 2
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(99, 288)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(300, 27)
        txtPassword.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = SystemColors.ButtonHighlight
        btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), Image)
        btnLogin.Location = New Point(87, 321)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(332, 75)
        btnLogin.TabIndex = 4
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.ForeColor = Color.Transparent
        btnBack.Image = CType(resources.GetObject("btnBack.Image"), Image)
        btnBack.Location = New Point(428, 23)
        btnBack.Margin = New Padding(2)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(50, 50)
        btnBack.TabIndex = 5
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' PanelLogin
        ' 
        PanelLogin.BackColor = Color.FromArgb(CByte(37), CByte(37), CByte(37))
        PanelLogin.Controls.Add(Label4)
        PanelLogin.Controls.Add(Label7)
        PanelLogin.Controls.Add(Label6)
        PanelLogin.Controls.Add(PictureBox1)
        PanelLogin.Controls.Add(Panel2)
        PanelLogin.Location = New Point(163, 77)
        PanelLogin.Name = "PanelLogin"
        PanelLogin.Size = New Size(900, 520)
        PanelLogin.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(167), CByte(163), CByte(156))
        Label4.Location = New Point(55, 482)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(294, 17)
        Label4.TabIndex = 11
        Label4.Text = "© 2025 Kelompok 3 - Sistem Inventori Gudang."
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(167), CByte(163), CByte(156))
        Label7.Location = New Point(67, 252)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(291, 20)
        Label7.TabIndex = 10
        Label7.Text = "Step into smarter inventory management"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Label6.Location = New Point(100, 214)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(208, 38)
        Label6.TabIndex = 9
        Label6.Text = "Welcome Back"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(109, 32)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(180, 180)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(txtUsername)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(btnBack)
        Panel2.Controls.Add(txtPassword)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(400, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(500, 520)
        Panel2.TabIndex = 7
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 13F, FontStyle.Bold)
        Label8.ForeColor = Color.FromArgb(CByte(69), CByte(69), CByte(69))
        Label8.Location = New Point(99, 131)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(290, 30)
        Label8.TabIndex = 9
        Label8.Text = "INVENTORY SYSTEM LOGIN"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(123, 399)
        Label5.Name = "Label5"
        Label5.Size = New Size(254, 17)
        Label5.TabIndex = 8
        Label5.Text = "*Pastikan data yang anda masukkan benar"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(190, 111)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 41)
        Label3.TabIndex = 6
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(230), CByte(230), CByte(230))
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1262, 673)
        Controls.Add(PanelLogin)
        Margin = New Padding(2)
        Name = "FormLogin"
        Text = "FormLogin"
        PanelLogin.ResumeLayout(False)
        PanelLogin.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
