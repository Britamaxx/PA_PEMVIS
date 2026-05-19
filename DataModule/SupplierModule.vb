Imports MySqlConnector

Module SupplierModule

    Public Function GetAllSupplier() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT * FROM tbsupplier ORDER BY id_supplier ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data supplier: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function SearchSupplier(keyword As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT * FROM tbsupplier WHERE nama_supplier LIKE @keyword OR alamat LIKE @keyword ORDER BY id_supplier ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mencari data supplier: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function GetSupplierByID(id As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT * FROM tbsupplier WHERE id_supplier = @id"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data supplier: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function SimpanSupplier(id As String, nama As String, alamat As String, telepon As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbsupplier(id_supplier, nama_supplier, alamat, telepon_supplier)
                VALUES (@id, @nama, @alamat, @telepon)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    cmd.Parameters.AddWithValue("@telepon", telepon)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data supplier: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahSupplier(id As String, nama As String, alamat As String, telepon As String) As Boolean
        Try
            Dim query As String = "UPDATE tbsupplier SET nama_supplier = @nama, alamat = @alamat, telepon_supplier = @telepon WHERE id_supplier = @id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@alamat", alamat)
                    cmd.Parameters.AddWithValue("@telepon", telepon)

                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data supplier: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusSupplier(id As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbsupplier WHERE id_supplier = @id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)

                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data supplier: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module