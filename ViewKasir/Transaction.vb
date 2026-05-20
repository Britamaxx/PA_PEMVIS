Imports System.Runtime.CompilerServices
Imports MySqlConnector



Public Class Transaction

    Dim conn As New MySqlConnection(
        "server=localhost;user id=root;password=;database=dbminipemvis")
    Private Sub Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView1.Columns.Add("id_produk", "ID Produk")
        DataGridView1.Columns.Add("nama_produk", "Nama Produk")
        DataGridView1.Columns.Add("qty", "Qty")
        DataGridView1.Columns.Add("harga", "Harga")
        DataGridView1.Columns.Add("subtotal", "Subtotal")

        LoadProduk()

    End Sub

    Private Sub LoadProduk()

        Try

            conn.Open()

            Dim cmd As New MySqlCommand(
            "SELECT nama_produk FROM tbproduk",
            conn)

            Dim rd As MySqlDataReader =
            cmd.ExecuteReader()

            ComboBox1.Items.Clear()

            While rd.Read()

                ComboBox1.Items.Add(
                rd("nama_produk").ToString()
            )

            End While

            rd.Close()
            conn.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            conn.Close()

        End Try

    End Sub
    Private Sub HitungTotal()

        Dim total As Decimal = 0

        For Each row As DataGridViewRow In DataGridView1.Rows

            If row.IsNewRow Then Continue For

            total += Convert.ToDecimal(row.Cells(4).Value)

        Next

        Label8.Text = "Transaction | Total : Rp " &
        total.ToString("N0")

    End Sub

    Private Function GenerateIDPenjualan(transaksi As MySqlTransaction) As String

        Dim idBaru As String = "PNJ001"

        Try

            Dim cmd As New MySqlCommand("SELECT MAX(id_penjualan) FROM tbtransaksi_penjualan", conn, transaksi)

            Dim result = cmd.ExecuteScalar()

            If result IsNot DBNull.Value Then

                Dim angka As Integer =
                CInt(result.ToString().Substring(3))

                angka += 1

                idBaru = "PNJ" & angka.ToString("000")

            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        Return idBaru

    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            If ComboBox1.Text = "" Or TextBox2.Text = "" Then

                MessageBox.Show("Produk dan qty wajib diisi")
                Exit Sub

            End If

            If Not IsNumeric(TextBox2.Text) Then

                MessageBox.Show("Qty harus angka")
                Exit Sub

            End If

            conn.Open()

            Dim cmd As New MySqlCommand(
            "SELECT * FROM tbproduk WHERE nama_produk=@nama", conn)

            cmd.Parameters.AddWithValue("@nama", ComboBox1.Text)

            Dim rd As MySqlDataReader = cmd.ExecuteReader()

            If rd.Read() Then

                Dim idProduk As String = rd("id_produk").ToString()
                Dim namaProduk As String = rd("nama_produk").ToString()
                Dim harga As Decimal = Convert.ToDecimal(rd("harga_jual"))
                Dim qty As Integer = Convert.ToInt32(TextBox2.Text)

                Dim subtotal As Decimal = harga * qty

                Dim stok As Integer =
                    Convert.ToInt32(rd("stok"))

                If qty > stok Then

                    MessageBox.Show("Stok tidak cukup")

                    rd.Close()
                    conn.Close()

                    Exit Sub

                End If

                For Each row As DataGridViewRow In DataGridView1.Rows

                    If row.IsNewRow Then Continue For

                    If row.Cells(0).Value.ToString() = idProduk Then

                        Dim qtyLama As Integer =
            Convert.ToInt32(row.Cells(2).Value)

                        Dim qtyBaru As Integer = qtyLama + qty

                        row.Cells(2).Value = qtyBaru
                        row.Cells(4).Value = qtyBaru * harga

                        HitungTotal()

                        rd.Close()
                        conn.Close()

                        Exit Sub

                    End If

                Next

                DataGridView1.Rows.Add(
                idProduk,
                namaProduk,
                qty,
                harga,
                subtotal
            )
                HitungTotal()

            Else
                MessageBox.Show("Produk tidak ditemukan")
            End If

            rd.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If DataGridView1.CurrentRow IsNot Nothing Then
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)

            HitungTotal()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If DataGridView1.CurrentRow IsNot Nothing Then

            Dim qty As Integer = Convert.ToInt32(TextBox2.Text)
            Dim harga As Decimal =
            Convert.ToDecimal(DataGridView1.CurrentRow.Cells(3).Value)

            DataGridView1.CurrentRow.Cells(2).Value = qty
            DataGridView1.CurrentRow.Cells(4).Value = qty * harga


            HitungTotal()
        End If



    End Sub

    Private Sub DataGridView1_CellClick(
    sender As Object,
    e As DataGridViewCellEventArgs
) Handles DataGridView1.CellClick

        If e.RowIndex >= 0 Then

            ComboBox1.Text =
            DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()

            TextBox2.Text =
            DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()

        End If

    End Sub




    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
        FormLogin.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        History.Show()
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If DataGridView1.Rows.Count <= 1 Then

            MessageBox.Show("Keranjang kosong")
            Exit Sub

        End If

        Try

            conn.Open()

            Dim transaksi As MySqlTransaction =
                conn.BeginTransaction()

            Try

                Dim idPenjualan As String = GenerateIDPenjualan(transaksi)

                Dim total As Decimal = 0

                For Each row As DataGridViewRow In DataGridView1.Rows

                    If row.IsNewRow Then Continue For

                    total += Convert.ToDecimal(row.Cells(4).Value)

                Next
                Dim cmdPenjualan As New MySqlCommand("INSERT INTO tbtransaksi_penjualan VALUES (@id,@tanggal,@karyawan, @total,@bayar,@kembalian)",
                    conn, transaksi)

                cmdPenjualan.Parameters.AddWithValue("@id", idPenjualan)

                cmdPenjualan.Parameters.AddWithValue("@tanggal", Date.Now)

                cmdPenjualan.Parameters.AddWithValue("@karyawan", "KAR001")

                cmdPenjualan.Parameters.AddWithValue("@total", total)

                cmdPenjualan.Parameters.AddWithValue("@bayar", total)

                cmdPenjualan.Parameters.AddWithValue("@kembalian", 0)

                cmdPenjualan.ExecuteNonQuery()

                Dim nomor As Integer = 1

                For Each row As DataGridViewRow In DataGridView1.Rows

                    If row.IsNewRow Then Continue For

                    Dim idDetail As String =
                        "DTJ" &
                        DateTime.Now.ToString("HHmmss") &
                        nomor.ToString()

                    Dim idProduk As String =
                        row.Cells(0).Value.ToString()

                    Dim qty As Integer =
                        Convert.ToInt32(row.Cells(2).Value)

                    Dim harga As Decimal =
                        Convert.ToDecimal(row.Cells(3).Value)

                    Dim subtotal As Decimal =
                        Convert.ToDecimal(row.Cells(4).Value)

                    Dim cmdDetail As New MySqlCommand("INSERT INTO tbdetail_penjualan VALUES (@iddetail,@idpenjualan, @idproduk,@qty,@harga,@subtotal)",
                        conn, transaksi)

                    cmdDetail.Parameters.AddWithValue("@iddetail", idDetail)

                    cmdDetail.Parameters.AddWithValue("@idpenjualan", idPenjualan)

                    cmdDetail.Parameters.AddWithValue("@idproduk", idProduk)

                    cmdDetail.Parameters.AddWithValue("@qty", qty)

                    cmdDetail.Parameters.AddWithValue("@harga", harga)

                    cmdDetail.Parameters.AddWithValue("@subtotal", subtotal)

                    cmdDetail.ExecuteNonQuery()

                    Dim cmdUpdate As New MySqlCommand("UPDATE tbproduk SET stok = stok - @qty WHERE id_produk=@idproduk",
                        conn, transaksi)

                    cmdUpdate.Parameters.AddWithValue("@qty", qty)

                    cmdUpdate.Parameters.AddWithValue("@idproduk", idProduk)

                    cmdUpdate.ExecuteNonQuery()

                    nomor += 1

                Next

                transaksi.Commit()

                MessageBox.Show("Transaksi berhasil disimpan")

                DataGridView1.Rows.Clear()
                ComboBox1.SelectedIndex = -1
                TextBox2.Clear()

                HitungTotal()

            Catch ex As Exception

                transaksi.Rollback()

                MessageBox.Show(ex.Message)

            End Try

            conn.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

            conn.Close()

        End Try

    End Sub
End Class