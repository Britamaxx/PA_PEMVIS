Imports MySqlConnector

Module ProductModule

    Public Function GetAllProduk() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM Produk ORDER BY ID_Produk ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchProduk(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM Produk WHERE Nama_Produk LIKE @keyword OR Kategori LIKE @keyword ORDER BY ID_Produk ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetProdukByID(id As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String = "SELECT * FROM Produk WHERE ID_Produk = @id"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SimpanProduk(id As String, idSupplier As String, nama As String, stok As Integer, stokMin As Integer, hargaBeli As Long, hargaJual As Long, kategori As String) As Boolean
        Try
            Dim query As String = "INSERT INTO Produk (ID_Produk, ID_Supplier, Nama_Produk, Stok, Stok_Minimum, Harga_Beli, Harga_Jual, Kategori) " &
                                  "VALUES (@id, @idSupplier, @nama, @stok, @stokMin, @hargaBeli, @hargaJual, @kategori)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@idSupplier", idSupplier)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.Parameters.AddWithValue("@stokMin", stokMin)
                    cmd.Parameters.AddWithValue("@hargaBeli", hargaBeli)
                    cmd.Parameters.AddWithValue("@hargaJual", hargaJual)
                    cmd.Parameters.AddWithValue("@kategori", kategori)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahProduk(id As String, idSupplier As String, nama As String, stok As Integer, stokMin As Integer, hargaBeli As Long, hargaJual As Long, kategori As String) As Boolean
        Try
            Dim query As String = "UPDATE Produk SET ID_Supplier=@idSupplier, Nama_Produk=@nama, Stok=@stok, " &
                                  "Stok_Minimum=@stokMin, Harga_Beli=@hargaBeli, Harga_Jual=@hargaJual, Kategori=@kategori " &
                                  "WHERE ID_Produk=@id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@idSupplier", idSupplier)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@stok", stok)
                    cmd.Parameters.AddWithValue("@stokMin", stokMin)
                    cmd.Parameters.AddWithValue("@hargaBeli", hargaBeli)
                    cmd.Parameters.AddWithValue("@hargaJual", hargaJual)
                    cmd.Parameters.AddWithValue("@kategori", kategori)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusProduk(id As String) As Boolean
        Try
            Dim query As String = "DELETE FROM Produk WHERE ID_Produk = @id"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
End Module