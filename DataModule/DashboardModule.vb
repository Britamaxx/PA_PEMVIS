Imports MySqlConnector

Module DashboardModule

    Public Function GetTotalPenjualanHariIni() As Decimal
        Dim total As Decimal = 0

        Try
            Dim query As String = "SELECT IFNULL(SUM(total_harga_penjualan), 0) FROM tbtransaksi_penjualan WHERE DATE(tanggal_penjualan) = CURDATE()"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    total = Convert.ToDecimal(cmd.ExecuteScalar())
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
            Dim query As String = "SELECT COUNT(*) FROM tbtransaksi_penjualan WHERE DATE(tanggal_penjualan) = CURDATE()"

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

    Public Function GetNetProfitHariIni() As Decimal
        Dim profit As Decimal = 0

        Try
            Dim query As String =
                "SELECT IFNULL(SUM(dp.subtotal_penjualan - (dp.jumlah_barang * p.harga_beli)), 0)
                FROM tbdetail_penjualan dp
                JOIN tbproduk p ON p.id_produk = dp.id_produk
                JOIN tbtransaksi_penjualan tp ON tp.id_penjualan = dp.id_penjualan
                WHERE DATE(tp.tanggal_penjualan) = CURDATE()"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    profit = Convert.ToDecimal(cmd.ExecuteScalar())
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
            Dim query As String =
                "SELECT p.nama_produk, SUM(dp.jumlah_barang) AS total_terjual
                FROM tbdetail_penjualan dp
                JOIN tbproduk p ON p.id_produk = dp.id_produk
                GROUP BY dp.id_produk, p.nama_produk
                ORDER BY total_terjual DESC
                LIMIT 5"

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
            Dim query As String = "SELECT id_produk, nama_produk, stok, stok_minimum FROM tbproduk WHERE stok <= stok_minimum ORDER BY stok ASC"

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