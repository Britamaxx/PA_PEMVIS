Imports MySqlConnector

Module DetailPembelianModule

    Public Function GetDetailPembelianByIDPembelian(idPembelian As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String =
                "SELECT dp.*, p.nama_produk
                FROM tbdetail_pembelian dp
                JOIN tbproduk p ON p.id_produk = dp.id_produk
                WHERE dp.id_pembelian = @idPembelian"

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

    Public Function SimpanDetailPembelian(idDetail As String, idPembelian As String, idProduk As String, jumlah As Integer, hargaPembelian As Decimal, subtotal As Decimal) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbdetail_pembelian(id_detail_pembelian, id_pembelian, id_produk, jumlah_barang, harga_pembelian, subtotal_pembelian)
                VALUES (@idDetail, @idPembelian, @idProduk, @jumlah, @hargaPembelian, @subtotal)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idDetail", idDetail)
                    cmd.Parameters.AddWithValue("@idPembelian", idPembelian)
                    cmd.Parameters.AddWithValue("@idProduk", idProduk)
                    cmd.Parameters.AddWithValue("@jumlah", jumlah)
                    cmd.Parameters.AddWithValue("@hargaPembelian", hargaPembelian)
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
            Dim query As String = "DELETE FROM tbdetail_pembelian WHERE id_detail_pembelian = @idDetail"

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