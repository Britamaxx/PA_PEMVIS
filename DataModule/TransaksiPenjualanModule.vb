Imports MySqlConnector

Module TransaksiPenjualanModule
    Public Function GetAllTransaksiPenjualan() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM Transaksi_Penjualan ORDER BY ID_Penjualan ASC"
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
            Dim query As String = "SELECT * FROM Transaksi_Penjualan WHERE ID_Penjualan = @id"
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
            Dim query As String = "SELECT * FROM Transaksi_Penjualan WHERE DATE(Tanggal_Penjualan) = CURDATE() ORDER BY ID_Penjualan ASC"
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

    Public Function SimpanTransaksiPenjualan(id As String, tanggal As Date, idKaryawan As String, totalHarga As Long, bayar As Long, kembalian As Long) As Boolean
        Try
            Dim query As String = "INSERT INTO Transaksi_Penjualan (ID_Penjualan, Tanggal_Penjualan, ID_Karyawan, Total_Harga_Penjualan, Bayar, Kembalian) " &
                                  "VALUES (@id, @tanggal, @idKaryawan, @totalHarga, @bayar, @kembalian)"
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
            Dim query As String = "DELETE FROM Transaksi_Penjualan WHERE ID_Penjualan = @id"
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
