Imports MySql.Data.MySqlClient

Public Class fromMasterBarang
    Private Sub fromMasterBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.BackColor = Color.FromArgb(248, 244, 238)
        Koneksi()
        TampilKategori()
        TampilDataBarang()
        Bersihkan()
    End Sub

    '==========================================
    ' MEMUAT KATEGORI KE COMBOBOX
    '==========================================
    Private Sub TampilKategori()
        Try
            ComboBox1.Items.Clear()

            cmd = New MySqlCommand("SELECT id, nama_kategori FROM kategori ORDER BY nama_kategori", conn)
            dr = cmd.ExecuteReader()

            While dr.Read()
                ComboBox1.Items.Add(dr("id") & " - " & dr("nama_kategori"))
            End While

            dr.Close()
        Catch ex As Exception
            MsgBox("Gagal memuat kategori: " & ex.Message)
        End Try
    End Sub


    '==========================================
    ' MENAMPILKAN DATA BARANG KE DATAGRID
    '==========================================
    Private Sub TampilDataBarang()
        Try
            da = New MySqlDataAdapter(
                "SELECT b.id, b.kode_barang, b.nama_barang, k.nama_kategori, b.satuan, b.lokasi, b.stok_min 
                 FROM barang b 
                 LEFT JOIN kategori k ON b.id_kategori = k.id", conn)

            ds = New DataSet()
            da.Fill(ds)

            DataGridView1.DataSource = ds.Tables(0)
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Catch ex As Exception
            MsgBox("Gagal memuat data barang: " & ex.Message)
        End Try
    End Sub



    '==========================================
    ' BUTTON SIMPAN (INSERT)
    '==========================================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Semua field wajib diisi!", vbExclamation)
            Exit Sub
        End If

        Dim idKategori As Integer = Val(Split(ComboBox1.Text, " - ")(0))

        Try
            cmd = New MySqlCommand("INSERT INTO barang (kode_barang, nama_barang, id_kategori, satuan, lokasi, stok_min) 
                                    VALUES (@kode, @nama, @kat, @sat, @lok, @stok)", conn)

            cmd.Parameters.AddWithValue("@kode", TextBox1.Text)
            cmd.Parameters.AddWithValue("@nama", TextBox2.Text)
            cmd.Parameters.AddWithValue("@kat", idKategori)
            cmd.Parameters.AddWithValue("@sat", TextBox3.Text)
            cmd.Parameters.AddWithValue("@lok", TextBox4.Text)
            cmd.Parameters.AddWithValue("@stok", NumericUpDown1.Value)

            cmd.ExecuteNonQuery()
            MsgBox("Data barang berhasil disimpan!", vbInformation)

            TampilDataBarang()
            Bersihkan()

        Catch ex As Exception
            MsgBox("Gagal menyimpan: " & ex.Message)
        End Try
    End Sub


    '==========================================
    ' BUTTON EDIT (UPDATE)
    '==========================================
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        Dim idKategori As Integer = Val(Split(ComboBox1.Text, " - ")(0))

        Try
            cmd = New MySqlCommand("UPDATE barang SET 
                                    kode_barang=@kode, 
                                    nama_barang=@nama, 
                                    id_kategori=@kat, 
                                    satuan=@sat, 
                                    lokasi=@lok, 
                                    stok_min=@stok
                                    WHERE id=@id", conn)

            cmd.Parameters.AddWithValue("@kode", TextBox1.Text)
            cmd.Parameters.AddWithValue("@nama", TextBox2.Text)
            cmd.Parameters.AddWithValue("@kat", idKategori)
            cmd.Parameters.AddWithValue("@sat", TextBox3.Text)
            cmd.Parameters.AddWithValue("@lok", TextBox4.Text)
            cmd.Parameters.AddWithValue("@stok", NumericUpDown1.Value)


            cmd.ExecuteNonQuery()
            MsgBox("Data berhasil diperbarui!", vbInformation)

            TampilDataBarang()
            Bersihkan()

        Catch ex As Exception
            MsgBox("Gagal update: " & ex.Message)
        End Try
    End Sub


    '==========================================
    ' BUTTON HAPUS (DELETE)
    '==========================================
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click



        If MsgBox("Yakin ingin menghapus?", vbYesNo + vbQuestion) = vbNo Then Exit Sub

        Try
            cmd = New MySqlCommand("DELETE FROM barang WHERE id=@id", conn)
            cmd.Parameters.AddWithValue("@id", txtID.Text)
            cmd.ExecuteNonQuery()

            MsgBox("Data berhasil dihapus!", vbInformation)

            TampilDataBarang()
            Bersihkan()

        Catch ex As Exception
            MsgBox("Gagal menghapus: " & ex.Message)
        End Try
    End Sub


    '==========================================
    ' KLIK DATAGRID → ISI FIELD
    '==========================================
    Private Sub Data_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Try
            Dim row = DataGridView1.Rows(e.RowIndex)


            TextBox1.Text = row.Cells(1).Value.ToString
            TextBox2.Text = row.Cells(2).Value.ToString
            ComboBox1.Text = row.Cells(3).Value.ToString
            TextBox3.Text = row.Cells(4).Value.ToString
            TextBox4.Text = row.Cells(5).Value.ToString
            NumericUpDown1.Value = row.Cells(6).Value

        Catch ex As Exception
        End Try
    End Sub


    '==========================================
    ' CLEAR FIELD
    '==========================================
    Private Sub Bersihkan()

        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        NumericUpDown1.Value = 0
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
