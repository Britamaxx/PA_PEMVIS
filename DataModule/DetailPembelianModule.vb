Imports MySqlConnector

Module DetailPembelianModule
    Public Function GetDetailPembelianByIDPembelian(idPembelian As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT dp.*, p.Nama_Produk FROM Detail_Pembelian dp " &
                                  "JOIN Produk p ON p.ID_Produk = dp.ID_Produk " &
                                  "WHERE dp.ID_Pembelian = @idPembelian"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@idPembelian", idPembelian)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan detail pembelian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanDetailPembelian(idDetail As String, idPembelian As String, idProduk As String, jumlah As Integer, hargaBeli As Long, subtotal As Long) As Boolean
        Try
            Dim query As String = "INSERT INTO Detail_Pembelian (ID_Detail_Pembelian, ID_Pembelian, ID_Produk, Jumlah_Barang, Harga_Beli, Subtotal_Pembelian) " &
                                  "VALUES (@idDetail, @idPembelian, @idProduk, @jumlah, @hargaBeli, @subtotal)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idDetail", idDetail)
                    cmd.Parameters.AddWithValue("@idPembelian", idPembelian)
                    cmd.Parameters.AddWithValue("@idProduk", idProduk)
                    cmd.Parameters.AddWithValue("@jumlah", jumlah)
                    cmd.Parameters.AddWithValue("@hargaBeli", hargaBeli)
                    cmd.Parameters.AddWithValue("@subtotal", subtotal)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan detail pembelian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusDetailPembelian(idDetail As String) As Boolean
        Try
            Dim query As String = "DELETE FROM Detail_Pembelian WHERE ID_Detail_Pembelian = @idDetail"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idDetail", idDetail)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus detail pembelian: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module
