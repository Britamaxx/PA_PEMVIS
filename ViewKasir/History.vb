Imports MySqlConnector
Public Class History

	Public Function getHistory() As DataTable
		Dim dt As New DataTable()
		Try
			Dim query As String =
				"SELECT p.id_penjualan, p.tanggal_penjualan, k.nama_karyawan, " &
				"pr.nama_produk, d.jumlah_barang, d.harga_jual, d.subtotal_penjualan, p.total_harga_penjualan " &
				"FROM tbtransaksi_penjualan p JOIN tbkaryawan k ON p.id_karyawan = k.id_karyawan JOIN tbdetail_penjualan d " &
				"ON p.id_penjualan = d.id_penjualan JOIN tbproduk pr ON d.id_produk = pr.id_produk ORDER BY p.tanggal_penjualan DESC;"
			Using conn As MySqlConnection = GetConnection()
				Using da As New MySqlDataAdapter(query, conn)
					da.Fill(dt)
				End Using
			End Using
		Catch ex As Exception
			MessageBox.Show("Gagal menampilkan history penjualan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
		Return dt
	End Function
	Private Sub TampilHistory()
		DataGridView1.DataSource = getHistory()
	End Sub
	Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TampilHistory()
	End Sub
End Class