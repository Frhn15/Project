Imports MySql.Data.MySqlClient
Imports System.Data

Public Class formStokGudang

    ' Flag supaya event tidak jalan saat combobox masih loading
    Private isLoading As Boolean = True

    Private Sub formStokGudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.BackgroundImageLayout = ImageLayout.Stretch

        Koneksi()

        ' Setting grid
        dgStokGudang.AllowUserToAddRows = False
        dgStokGudang.ReadOnly = True
        dgStokGudang.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgStokGudang.MultiSelect = False
        dgStokGudang.AutoGenerateColumns = True
        dgStokGudang.RowHeadersVisible = False
        dgStokGudang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        isLoading = True
        LoadFilterGudang()
        isLoading = False

        LoadStokGudang()
    End Sub

    ' =========================
    ' AMBIL ID GUDANG DENGAN AMAN
    ' =========================
    Private Function GetSelectedGudangId() As Integer
        If Cbfiltergudang.DataSource Is Nothing Then Return 0
        If Cbfiltergudang.SelectedValue Is Nothing Then Return 0
        If TypeOf Cbfiltergudang.SelectedValue Is DataRowView Then Return 0

        Dim id As Integer
        If Integer.TryParse(Cbfiltergudang.SelectedValue.ToString(), id) Then
            Return id
        End If

        Return 0
    End Function

    ' =========================
    ' LOAD COMBO FILTER GUDANG
    ' =========================
    Private Sub LoadFilterGudang()
        Dim dt As New DataTable()

        Using da As New MySqlDataAdapter("
            SELECT id, CONCAT(kode_gudang,' - ',nama_gudang) AS nama
            FROM gudang
            ORDER BY nama_gudang
        ", conn)
            da.Fill(dt)
        End Using

        ' Tambahkan pilihan "Semua Gudang"
        Dim r As DataRow = dt.NewRow()
        r("id") = 0
        r("nama") = "Semua Gudang"
        dt.Rows.InsertAt(r, 0)

        Cbfiltergudang.DataSource = dt
        Cbfiltergudang.DisplayMember = "nama"
        Cbfiltergudang.ValueMember = "id"
        Cbfiltergudang.SelectedIndex = 0
    End Sub

    ' =========================
    ' LOAD GRID STOK GUDANG
    ' =========================
    Private Sub LoadStokGudang()
        Dim dt As New DataTable()

        Dim keyword As String = "%" & Txpencarianbarang.Text.Trim() & "%"
        Dim idGudang As Integer = GetSelectedGudangId()

        Using cmd As New MySqlCommand("
            SELECT
                sg.id,
                b.kode_barang,
                b.nama_barang,
                g.kode_gudang,
                g.nama_gudang,
                sg.stok
            FROM stok_gudang sg
            INNER JOIN barang b ON b.id = sg.id_barang
            INNER JOIN gudang g ON g.id = sg.id_gudang
            WHERE
                (b.kode_barang LIKE @cari OR b.nama_barang LIKE @cari)
                AND (@gid = 0 OR sg.id_gudang = @gid)
            ORDER BY g.nama_gudang, b.nama_barang
        ", conn)

            cmd.Parameters.AddWithValue("@cari", keyword)
            cmd.Parameters.AddWithValue("@gid", idGudang)

            Using da As New MySqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        dgStokGudang.DataSource = dt
    End Sub

    ' =========================
    ' EVENT SEARCH & FILTER
    ' =========================
    Private Sub Txpencarianbarang_TextChanged(sender As Object, e As EventArgs) Handles Txpencarianbarang.TextChanged
        If isLoading Then Exit Sub
        LoadStokGudang()
    End Sub

    Private Sub Cbfiltergudang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbfiltergudang.SelectedIndexChanged
        If isLoading Then Exit Sub
        If Cbfiltergudang.DataSource Is Nothing Then Exit Sub
        If Cbfiltergudang.SelectedValue Is Nothing Then Exit Sub
        If TypeOf Cbfiltergudang.SelectedValue Is DataRowView Then Exit Sub

        LoadStokGudang()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub dgStokGudang_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgStokGudang.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
