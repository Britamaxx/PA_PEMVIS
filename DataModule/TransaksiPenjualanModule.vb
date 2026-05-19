Imports MySqlConnector

Module TransaksiPenjualanModule

    Public Function GetAllTransaksiPenjualan() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT * FROM tbtransaksi_penjualan ORDER BY id_penjualan ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data transaksi penjualan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function GetTransaksiPenjualanByID(id As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT * FROM tbtransaksi_penjualan WHERE id_penjualan = @id"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data transaksi penjualan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function GetTransaksiPenjualanHariIni() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT * FROM tbtransaksi_penjualan WHERE DATE(tanggal_penjualan) = CURDATE() ORDER BY id_penjualan ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data penjualan hari ini: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function SimpanTransaksiPenjualan(id As String, tanggal As Date, idKaryawan As String, totalHarga As Decimal, bayar As Decimal, kembalian As Decimal) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbtransaksi_penjualan(id_penjualan, tanggal_penjualan, id_karyawan, total_harga_penjualan, bayar, kembalian)
                VALUES (@id, @tanggal, @idKaryawan, @totalHarga, @bayar, @kembalian)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal)
                    cmd.Parameters.AddWithValue("@idKaryawan", idKaryawan)
                    cmd.Parameters.AddWithValue("@totalHarga", totalHarga)
                    cmd.Parameters.AddWithValue("@bayar", bayar)
                    cmd.Parameters.AddWithValue("@kembalian", kembalian)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan transaksi penjualan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusTransaksiPenjualan(id As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbtransaksi_penjualan WHERE id_penjualan = @id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)

                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus transaksi penjualan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module