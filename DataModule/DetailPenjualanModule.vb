Imports MySqlConnector

Module DetailPenjualanModule
    Public Function GetDetailPenjualanByIDPenjualan(idPenjualan As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT dp.*, p.Nama_Produk FROM Detail_Penjualan dp " &
                                  "JOIN Produk p ON p.ID_Produk = dp.ID_Produk " &
                                  "WHERE dp.ID_Penjualan = @idPenjualan"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@idPenjualan", idPenjualan)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan detail penjualan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanDetailPenjualan(idDetail As String, idPenjualan As String, idProduk As String, jumlah As Integer, hargaJual As Long, subtotal As Long) As Boolean
        Try
            Dim query As String = "INSERT INTO Detail_Penjualan (ID_Detail_Penjualan, ID_Penjualan, ID_Produk, Jumlah_Barang, Harga_Jual, Subtotal_Penjualan) " &
                                  "VALUES (@idDetail, @idPenjualan, @idProduk, @jumlah, @hargaJual, @subtotal)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idDetail", idDetail)
                    cmd.Parameters.AddWithValue("@idPenjualan", idPenjualan)
                    cmd.Parameters.AddWithValue("@idProduk", idProduk)
                    cmd.Parameters.AddWithValue("@jumlah", jumlah)
                    cmd.Parameters.AddWithValue("@hargaJual", hargaJual)
                    cmd.Parameters.AddWithValue("@subtotal", subtotal)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan detail penjualan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusDetailPenjualan(idDetail As String) As Boolean
        Try
            Dim query As String = "DELETE FROM Detail_Penjualan WHERE ID_Detail_Penjualan = @idDetail"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idDetail", idDetail)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus detail penjualan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module
