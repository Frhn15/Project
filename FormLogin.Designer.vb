<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        txtUser = New TextBox()
        txtPass = New TextBox()
        btnLogin = New Button()
        btnBack = New Button()
        PanelLogin = New Panel()
        Label3 = New Label()
        Panel1 = New Panel()
        Label4 = New Label()
        PanelLogin.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(74, 224)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 20)
        Label1.TabIndex = 0
        Label1.Text = "USERNAME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(74, 301)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 20)
        Label2.TabIndex = 1
        Label2.Text = "PASSWORD"
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("Palatino Linotype", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtUser.Location = New Point(200, 216)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(217, 28)
        txtUser.TabIndex = 2
        ' 
        ' txtPass
        ' 
        txtPass.Location = New Point(200, 294)
        txtPass.Name = "txtPass"
        txtPass.PasswordChar = "*"c
        txtPass.Size = New Size(217, 27)
        txtPass.TabIndex = 3
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(200, 355)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 29)
        btnLogin.TabIndex = 4
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(323, 355)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(94, 29)
        btnBack.TabIndex = 5
        btnBack.Text = "KEMBALI"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' PanelLogin
        ' 
        PanelLogin.Anchor = AnchorStyles.Top
        PanelLogin.BackColor = SystemColors.ScrollBar
        PanelLogin.Controls.Add(Label4)
        PanelLogin.Controls.Add(Label3)
        PanelLogin.Controls.Add(btnBack)
        PanelLogin.Controls.Add(btnLogin)
        PanelLogin.Controls.Add(txtPass)
        PanelLogin.Controls.Add(txtUser)
        PanelLogin.Controls.Add(Label2)
        PanelLogin.Controls.Add(Label1)
        PanelLogin.Location = New Point(598, 12)
        PanelLogin.Name = "PanelLogin"
        PanelLogin.Size = New Size(550, 488)
        PanelLogin.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Impact", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(223, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 54)
        Label3.TabIndex = 6
        Label3.Text = "LOGIN."
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.BackgroundImage = My.Resources.Resources.Logo_Kelompok_3_Sistem_Inventory
        Panel1.BackgroundImageLayout = ImageLayout.Zoom
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 484)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1651, 137)
        Panel1.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(263, 167)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 20)
        Label4.TabIndex = 7
        Label4.Text = "User Login"
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.assd
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1651, 621)
        Controls.Add(Panel1)
        Controls.Add(PanelLogin)
        Name = "FormLogin"
        Text = "FormLogin"
        PanelLogin.ResumeLayout(False)
        PanelLogin.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents PanelLogin As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
End Class
