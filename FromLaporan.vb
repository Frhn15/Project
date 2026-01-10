' ====== Untuk Export Excel ======
Imports ClosedXML.Excel
' ====== Untuk Export PDF ======
Imports MigraDocCore.DocumentObjectModel
Imports MigraDocCore.DocumentObjectModel.Tables
Imports MigraDocCore.Rendering
Imports MySql.Data.MySqlClient
Imports OpenTK
Imports PdfSharpCore.Pdf

' =========================================================
' 1 FILE: MODULE DB + FORM LAPORAN (tidak dipisah)
' =========================================================
Module Db
    ' >>> GANTI sesuai MySQL kamu <<<
    Public Const CONN_STR As String =
        "server=localhost;port=3306;database=inventory;user id=root;password=;"

    Public Function GetConn() As MySqlConnection
        Return New MySqlConnection(CONN_STR)
    End Function
End Module

Public Class FromLaporan

    Private currentDt As DataTable = Nothing

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized

        ' Default range tanggal (misal 30 hari terakhir)
        dtSampai.Value = Date.Today
        dtDari.Value = Date.Today.AddDays(-30)

        LoadJenisLaporan()

        btnExport.Enabled = False
    End Sub

    Private Sub LoadJenisLaporan()
        cbPilih.Items.Clear()
        cbPilih.Items.Add("Barang Masuk")
        cbPilih.Items.Add("Barang Keluar")
        cbPilih.Items.Add("Transfer Antar Gudang")
        cbPilih.Items.Add("Stock Opname")
        cbPilih.Items.Add("Stok Gudang")

        cbPilih.SelectedIndex = 0
    End Sub

    ' ================== TAMPILKAN ==================
    Private Sub btnTampilkan_Click(sender As Object, e As EventArgs) Handles btnTampilkan.Click
        Try
            currentDt = AmbilDataLaporan()
            dgLaporan.DataSource = currentDt

            StyleGrid()

            btnExport.Enabled = (currentDt IsNot Nothing AndAlso currentDt.Rows.Count > 0)

        Catch ex As Exception
            MessageBox.Show("Gagal tampilkan laporan: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function AmbilDataLaporan() As DataTable
        Dim jenis As String = cbPilih.Text.Trim()
        Dim cari As String = txtCari.Text.Trim()
        If cari = "" Then
            cari = "%"
        Else
            cari = "%" & cari & "%"
        End If

        Dim sql As String = ""
        Dim pakaiFilterTanggal As Boolean = True

        Select Case jenis
            Case "Barang Masuk"
                pakaiFilterTanggal = True
                sql =
"SELECT 
    bm.no_dokumen AS no_dokumen,
    bm.tanggal AS tanggal,
    s.nama_supplier AS supplier,
    g.nama_gudang AS gudang,
    bm.keterangan AS keterangan,
    b.kode_barang AS kode_barang,
    b.nama_barang AS nama_barang,
    d.qty AS qty
FROM barang_masuk bm
JOIN barang_masuk_detail d ON d.id_header = bm.id
JOIN barang b ON b.id = d.id_barang
LEFT JOIN supplier s ON s.id = bm.id_supplier
LEFT JOIN gudang g ON g.id = bm.id_gudang
WHERE bm.tanggal BETWEEN @dari AND @sampai
  AND (
        bm.no_dokumen LIKE @cari OR
        bm.keterangan LIKE @cari OR
        b.nama_barang LIKE @cari OR
        b.kode_barang LIKE @cari OR
        s.nama_supplier LIKE @cari OR
        g.nama_gudang LIKE @cari
      )
ORDER BY bm.tanggal DESC, bm.no_dokumen DESC;"

            Case "Barang Keluar"
                pakaiFilterTanggal = True
                sql =
"SELECT
    bk.no_dokumen AS no_dokumen,
    bk.tanggal AS tanggal,
    g.nama_gudang AS gudang_asal,
    bk.tujuan AS tujuan,
    bk.keterangan AS keterangan,
    b.kode_barang AS kode_barang,
    b.nama_barang AS nama_barang,
    d.qty AS qty
FROM barang_keluar bk
JOIN barang_keluar_detail d ON d.id_header = bk.id
JOIN barang b ON b.id = d.id_barang
LEFT JOIN gudang g ON g.id = bk.id_gudang
WHERE bk.tanggal BETWEEN @dari AND @sampai
  AND (
        bk.no_dokumen LIKE @cari OR
        bk.tujuan LIKE @cari OR
        bk.keterangan LIKE @cari OR
        b.nama_barang LIKE @cari OR
        b.kode_barang LIKE @cari OR
        g.nama_gudang LIKE @cari
      )
ORDER BY bk.tanggal DESC, bk.no_dokumen DESC;"

            Case "Transfer Antar Gudang"
                pakaiFilterTanggal = True
                sql =
"SELECT
    tg.no_transfer AS no_transfer,
    tg.tanggal AS tanggal,
    ga.nama_gudang AS gudang_asal,
    gt.nama_gudang AS gudang_tujuan,
    tg.keterangan AS keterangan,
    b.kode_barang AS kode_barang,
    b.nama_barang AS nama_barang,
    d.qty AS qty
FROM transfer_gudang tg
JOIN transfer_gudang_detail d ON d.id_header = tg.id
JOIN barang b ON b.id = d.id_barang
LEFT JOIN gudang ga ON ga.id = tg.id_asal
LEFT JOIN gudang gt ON gt.id = tg.id_tujuan
WHERE tg.tanggal BETWEEN @dari AND @sampai
  AND (
        tg.no_transfer LIKE @cari OR
        tg.keterangan LIKE @cari OR
        b.nama_barang LIKE @cari OR
        b.kode_barang LIKE @cari OR
        ga.nama_gudang LIKE @cari OR
        gt.nama_gudang LIKE @cari
      )
ORDER BY tg.tanggal DESC, tg.no_transfer DESC;"

            Case "Stock Opname"
                pakaiFilterTanggal = True
                sql =
"SELECT
    DATE_FORMAT(so.tanggal, '%Y-%m-%d') AS tanggal,
    b.kode_barang AS kode_barang,
    b.nama_barang AS nama_barang,
    g.nama_gudang AS gudang,
    so.stok_sistem AS stok_sistem,
    so.stok_fisik AS stok_fisik,
    so.selisih AS selisih
FROM stock_opname so
JOIN barang b ON b.id = so.id_barang
JOIN gudang g ON g.id = so.id_gudang
WHERE so.tanggal BETWEEN @dari AND @sampai
  AND (
        b.nama_barang LIKE @cari OR
        b.kode_barang LIKE @cari OR
        g.nama_gudang LIKE @cari
      )
ORDER BY so.tanggal DESC;"

            Case "Stok Gudang"
                pakaiFilterTanggal = False
                sql =
"SELECT
    b.kode_barang AS kode_barang,
    b.nama_barang AS nama_barang,
    g.nama_gudang AS gudang,
    sg.stok AS stok
FROM stok_gudang sg
JOIN barang b ON b.id = sg.id_barang
JOIN gudang g ON g.id = sg.id_gudang
WHERE
    b.nama_barang LIKE @cari OR
    b.kode_barang LIKE @cari OR
    g.nama_gudang LIKE @cari
ORDER BY b.nama_barang ASC, g.nama_gudang ASC;"

            Case Else
                Throw New Exception("Jenis laporan tidak dikenali.")
        End Select

        Dim dt As New DataTable()

        Using conn As MySqlConnection = GetConn()
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@cari", cari)

                If pakaiFilterTanggal Then
                    cmd.Parameters.AddWithValue("@dari", dtDari.Value.Date)
                    cmd.Parameters.AddWithValue("@sampai", dtSampai.Value.Date)
                End If

                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using
            End Using
        End Using

        Return dt
    End Function

    Private Sub StyleGrid()
        dgLaporan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgLaporan.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgLaporan.MultiSelect = False
        dgLaporan.ReadOnly = True
        dgLaporan.AllowUserToAddRows = False
    End Sub

    ' ================== EXPORT ==================
    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If currentDt Is Nothing OrElse currentDt.Rows.Count = 0 Then
            MessageBox.Show("Data masih kosong. Klik Tampilkan dulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim sfd As New SaveFileDialog()
        sfd.Title = "Export Laporan"
        sfd.Filter = "Excel (*.xlsx)|*.xlsx|PDF (*.pdf)|*.pdf"
        sfd.FileName = "Laporan_" & cbPilih.Text.Replace(" ", "_") & "_" & DateTime.Now.ToString("yyyyMMdd_HHmm")

        If sfd.ShowDialog() <> DialogResult.OK Then Return

        Try
            If sfd.FilterIndex = 1 Then
                ExportToExcel(sfd.FileName, currentDt)
                MessageBox.Show("Berhasil export Excel.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ExportToPdf(sfd.FileName, currentDt, "Laporan - " & cbPilih.Text)
                MessageBox.Show("Berhasil export PDF.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Gagal export: " & ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ExportToExcel(path As String, dt As DataTable)
        Using wb As New XLWorkbook()
            Dim ws = wb.Worksheets.Add(dt, "Laporan")
            ws.Columns().AdjustToContents()
            wb.SaveAs(path)
        End Using
    End Sub

    Private Sub ExportToPdf(path As String, dt As DataTable, title As String)
        Dim doc As New Document()
        doc.Info.Title = title

        Dim sec = doc.AddSection()

        Dim pTitle = sec.AddParagraph(title)
        pTitle.Format.Font.Bold = True
        pTitle.Format.Font.Size = 14
        pTitle.Format.SpaceAfter = "0.3cm"

        Dim pInfo = sec.AddParagraph("Tanggal cetak: " & DateTime.Now.ToString("yyyy-MM-dd HH:mm"))
        pInfo.Format.Font.Size = 9
        pInfo.Format.SpaceAfter = "0.3cm"

        Dim table As Table = sec.AddTable()
        table.Borders.Width = 0.25

        ' Lebar kolom otomatis sederhana
        Dim colCount As Integer = dt.Columns.Count
        Dim totalWidthCm As Double = 25.0
        Dim w As Double = Math.Max(2.2, totalWidthCm / Math.Max(1, colCount))

        For i As Integer = 0 To colCount - 1
            Dim c = table.AddColumn(Unit.FromCentimeter(w))
            c.Format.Alignment = ParagraphAlignment.Left
        Next

        ' Header
        Dim header = table.AddRow()
        header.Shading.Color = Colors.LightGray
        header.Format.Font.Bold = True
        header.Format.Font.Size = 9

        For i As Integer = 0 To colCount - 1
            header.Cells(i).AddParagraph(dt.Columns(i).ColumnName)
        Next

        ' Data
        For Each dr As DataRow In dt.Rows
            Dim row = table.AddRow()
            row.Format.Font.Size = 9

            For i As Integer = 0 To colCount - 1
                row.Cells(i).AddParagraph(Convert.ToString(dr(i)))
            Next
        Next

        Dim renderer As New PdfDocumentRenderer(True)
        renderer.Document = doc
        renderer.RenderDocument()
        renderer.PdfDocument.Save(path)
    End Sub

    ' ================== KEMBALI ==================
    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        ' Sesuaikan ke form menu kamu
        Form1.Show()
        Form1.BringToFront()
        Me.Hide()
    End Sub

End Class
