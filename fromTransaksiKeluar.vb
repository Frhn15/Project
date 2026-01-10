Public Class fromTransaksiKeluar
    Private Sub fromTransaksiKeluar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Pnldocument_Paint(sender As Object, e As PaintEventArgs) Handles Pnldocument.Paint

    End Sub

    Private Sub no_Click(sender As Object, e As EventArgs) Handles no.Click

    End Sub

    Private Sub Panelhead_Paint(sender As Object, e As PaintEventArgs) Handles Panelhead.Paint

    End Sub

    Private Sub dgvKeluar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvKeluar.CellContentClick

    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class