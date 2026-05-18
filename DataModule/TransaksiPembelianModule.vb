Imports MySqlConnector

Module TransaksiPembelianModule
    Public Function GetAllTransaksiPembelian() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM Transaksi_Pembelian ORDER BY ID_Pembelian ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data transaksi pembelian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetTransaksiPembelianByID(id As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM Transaksi_Pembelian WHERE ID_Pembelian = @id"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data transaksi pembelian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanTransaksiPembelian(id As String, tanggal As Date, idSupplier As String, idKaryawan As String, totalHarga As Long) As Boolean
        Try
            Dim query As String = "INSERT INTO Transaksi_Pembelian (ID_Pembelian, Tanggal_Pembelian, ID_Supplier, ID_Karyawan, Total_Harga_Pembelian) " &
                                  "VALUES (@id, @tanggal, @idSupplier, @idKaryawan, @totalHarga)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal)
                    cmd.Parameters.AddWithValue("@idSupplier", idSupplier)
                    cmd.Parameters.AddWithValue("@idKaryawan", idKaryawan)
                    cmd.Parameters.AddWithValue("@totalHarga", totalHarga)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan transaksi pembelian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusTransaksiPembelian(id As String) As Boolean
        Try
            Dim query As String = "DELETE FROM Transaksi_Pembelian WHERE ID_Pembelian = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus transaksi pembelian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module
