Imports MySqlConnector

Public Class History

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilHistory()
    End Sub

    Private Sub TampilHistory()
        dgvHistory.DataSource = GetHistory()
    End Sub

    Public Function GetHistory() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT p.id_penjualan, p.tanggal_penjualan, k.nama_karyawan, " &
                "pr.nama_produk, d.jumlah_barang, d.harga_jual, d.subtotal_penjualan, p.total_harga_penjualan " &
                "FROM tbtransaksi_penjualan p " &
                "JOIN tbkaryawan k ON p.id_karyawan = k.id_karyawan " &
                "JOIN tbdetail_penjualan d ON p.id_penjualan = d.id_penjualan " &
                "JOIN tbproduk pr ON d.id_produk = pr.id_produk " &
                "ORDER BY p.tanggal_penjualan DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text.Trim() = "" Then
            TampilHistory()
            Exit Sub
        End If
        dgvHistory.DataSource = SearchHistory(txtSearch.Text.Trim())
        If dgvHistory.RowCount = 0 Then
            MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilHistory()
        End If
    End Sub

    Public Function SearchHistory(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT p.id_penjualan, p.tanggal_penjualan, k.nama_karyawan, " &
                "pr.nama_produk, d.jumlah_barang, d.harga_jual, d.subtotal_penjualan, p.total_harga_penjualan " &
                "FROM tbtransaksi_penjualan p " &
                "JOIN tbkaryawan k ON p.id_karyawan = k.id_karyawan " &
                "JOIN tbdetail_penjualan d ON p.id_penjualan = d.id_penjualan " &
                "JOIN tbproduk pr ON d.id_produk = pr.id_produk " &
                "WHERE p.id_penjualan LIKE @keyword OR k.nama_karyawan LIKE @keyword OR pr.nama_produk LIKE @keyword " &
                "ORDER BY p.tanggal_penjualan DESC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari history: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Private Sub btnSeeDetails_Click(sender As Object, e As EventArgs) Handles btnSeeDetails.Click
        If dgvHistory.CurrentRow Is Nothing Then
            MessageBox.Show("Pilih transaksi terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim idPenjualan As String = dgvHistory.CurrentRow.Cells("id_penjualan").Value.ToString()
        MessageBox.Show(
            "ID Penjualan : " & idPenjualan & Environment.NewLine &
            "Tanggal : " & dgvHistory.CurrentRow.Cells("tanggal_penjualan").Value.ToString() & Environment.NewLine &
            "Kasir : " & dgvHistory.CurrentRow.Cells("nama_karyawan").Value.ToString() & Environment.NewLine &
            "Total : Rp " & Convert.ToDecimal(dgvHistory.CurrentRow.Cells("total_harga_penjualan").Value).ToString("N0"),
            "Detail Transaksi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TransactionSidebar_Click(sender As Object, e As EventArgs) Handles TransactionSidebar.Click
        Dim f As New Transaction()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub HistorySidebar_Click(sender As Object, e As EventArgs) Handles HistorySidebar.Click

    End Sub

    Private Sub LogoutSidebar_Click(sender As Object, e As EventArgs) Handles LogoutSidebar.Click
        Dim hasil As DialogResult = MessageBox.Show("Yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            SessionInfo.ClearSession()
            Dim f As New FormLogin()
            f.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
        FormLogin.Show()
    End Sub
End Class