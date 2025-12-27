Imports MySql.Data.MySqlClient

Public Class FormLogin

    ' Fungsi untuk men-center panel login
    Private Sub CenterPanel()
        PanelLogin.Left = (Me.ClientSize.Width - PanelLogin.Width) \ 2
        PanelLogin.Top = (Me.ClientSize.Height - PanelLogin.Height) \ 2
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.TabStop = False


        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MsgBox("Username dan Password tidak boleh kosong!", vbExclamation)
            Exit Sub
        End If

        Call Koneksi()

        Dim query As String = "SELECT * FROM users WHERE username=@user AND password=@pass"
        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@user", txtUsername.Text)
        cmd.Parameters.AddWithValue("@pass", txtPassword.Text)

        Dim rd As MySqlDataReader = cmd.ExecuteReader()

        If rd.Read() Then

            Dim role As String = rd("role").ToString()

            ' Kirim data ke Form1 sebelum ditampilkan
            Form1.loggedUser = rd("username").ToString()
            Form1.lblRole.Text = role

            MsgBox("Login berhasil sebagai: " & role, vbInformation)

            rd.Close()
            conn.Close()

            ' --- Pindah ke Form1 ---
            Me.Hide()                 ' Sembunyikan FormLogin dulu
            Form1.Show()              ' Tampilkan Form1
            Form1.BringToFront()      ' Pastikan muncul di depan

            ' Jalankan role setelah form tampil
            Form1.BukaMenuBerdasarkanRole()

        Else
            MsgBox("Username atau Password salah!", vbCritical)
            rd.Close()
            conn.Close()
        End If

    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        CenterPanel()
    End Sub

    Private Sub FormLogin_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        CenterPanel()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Form1.Show()
        Form1.BringToFront()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
