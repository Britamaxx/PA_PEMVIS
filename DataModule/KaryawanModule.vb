Imports MySqlConnector

Module KaryawanModule

    Public Function GetAllKaryawan() As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT * FROM tbkaryawan ORDER BY id_karyawan ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data karyawan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function SearchKaryawan(keyword As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT * FROM tbkaryawan WHERE nama_karyawan LIKE @keyword OR jabatan LIKE @keyword OR username LIKE @keyword ORDER BY id_karyawan ASC"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mencari data karyawan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function GetKaryawanByID(id As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT * FROM tbkaryawan WHERE id_karyawan = @id"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@id", id)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data karyawan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function LoginKaryawan(username As String, password As String) As DataTable
        Dim dt As New DataTable()

        Try
            Dim query As String = "SELECT * FROM tbkaryawan WHERE username = @username AND password = @password"

            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@username", username)
                    da.SelectCommand.Parameters.AddWithValue("@password", password)
                    da.Fill(dt)
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return dt
    End Function

    Public Function SimpanKaryawan(id As String, nama As String, username As String, password As String, jabatan As String, telepon As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbkaryawan(id_karyawan, nama_karyawan, username, password, jabatan, telepon_karyawan)
                VALUES (@id, @nama, @username, @password, @jabatan, @telepon)"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.Parameters.AddWithValue("@jabatan", jabatan)
                    cmd.Parameters.AddWithValue("@telepon", telepon)

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            Return True

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data karyawan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahKaryawan(id As String, nama As String, username As String, password As String, jabatan As String, telepon As String) As Boolean
        Try
            Dim query As String = "UPDATE tbkaryawan SET nama_karyawan = @nama, username = @username, password = @password, jabatan = @jabatan, telepon_karyawan = @telepon WHERE id_karyawan = @id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    cmd.Parameters.AddWithValue("@jabatan", jabatan)
                    cmd.Parameters.AddWithValue("@telepon", telepon)

                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data karyawan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusKaryawan(id As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbkaryawan WHERE id_karyawan = @id"

            Using conn As MySqlConnection = GetConnection()
                conn.Open()

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", id)

                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data karyawan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module