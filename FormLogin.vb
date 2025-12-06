Imports MySql.Data.MySqlClient

Public Class FormLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Call Koneksi()

        cmd = New MySqlCommand("SELECT * FROM users WHERE username=@u AND password=@p", conn)
        cmd.Parameters.AddWithValue("@u", txtUser.Text)
        cmd.Parameters.AddWithValue("@p", txtPass.Text)

        dr = cmd.ExecuteReader()

        If dr.HasRows Then
            MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Form1.BukaMenu()   ' 🔓 AKTIFKAN MENU
            Form1.Show()
            Me.Hide()

        Else
            MessageBox.Show("Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Form1.KunciMenu()  ' 🔒 MENU TETAP TERKUNCI

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BackgroundImageLayout = ImageLayout.Stretch
        PanelLogin.Left = (Me.ClientSize.Width - PanelLogin.Width) \ 2
        PanelLogin.Top = (Me.ClientSize.Height - PanelLogin.Height) \ 2
    End Sub
End Class
