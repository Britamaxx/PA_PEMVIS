Imports MySqlConnector

Module DashboardModule
    Public Function GetTotalPenjualanHariIni() As Long
        Dim total As Long = 0
        Try
            Dim query As String = "SELECT IFNULL(SUM(Total_Harga_Penjualan), 0) FROM Transaksi_Penjualan WHERE DATE(Tanggal_Penjualan) = CURDATE()"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    total = Convert.ToInt64(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil total penjualan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return total
    End Function

    Public Function GetJumlahTransaksiHariIni() As Integer
        Dim jumlah As Integer = 0
        Try
            Dim query As String = "SELECT COUNT(*) FROM Transaksi_Penjualan WHERE DATE(Tanggal_Penjualan) = CURDATE()"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    jumlah = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil jumlah transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return jumlah
    End Function

    Public Function GetNetProfitHariIni() As Long
        Dim profit As Long = 0
        Try
            Dim query As String = "SELECT IFNULL(SUM(dp.Subtotal_Penjualan - (dp.Jumlah_Barang * p.Harga_Beli)), 0) " &
                                  "FROM Detail_Penjualan dp " &
                                  "JOIN Produk p ON p.ID_Produk = dp.ID_Produk " &
                                  "JOIN Transaksi_Penjualan tp ON tp.ID_Penjualan = dp.ID_Penjualan " &
                                  "WHERE DATE(tp.Tanggal_Penjualan) = CURDATE()"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    profit = Convert.ToInt64(cmd.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil net profit: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return profit
    End Function

    Public Function GetTopSellingProducts() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT p.Nama_Produk, SUM(dp.Jumlah_Barang) AS Total_Terjual " &
                                  "FROM Detail_Penjualan dp " &
                                  "JOIN Produk p ON p.ID_Produk = dp.ID_Produk " &
                                  "GROUP BY dp.ID_Produk, p.Nama_Produk " &
                                  "ORDER BY Total_Terjual DESC LIMIT 5"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil top produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetLowStockProducts() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT ID_Produk, Nama_Produk, Stok, Stok_Minimum FROM Produk WHERE Stok <= Stok_Minimum ORDER BY Stok ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil produk stok rendah: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function
End Module
