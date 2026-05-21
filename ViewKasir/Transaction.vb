Imports System.Data.Common
Imports MySqlConnector

Public Class Transaction

    Private Sub Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvTransaction.Columns.Add("id_produk", "ID Produk")
        dgvTransaction.Columns.Add("nama_produk", "Nama Produk")
        dgvTransaction.Columns.Add("qty", "Qty")
        dgvTransaction.Columns.Add("harga", "Harga")
        dgvTransaction.Columns.Add("subtotal", "Subtotal")

        LoadProduk()
    End Sub

    Private Sub LoadProduk()
        Try
            Dim dt As DataTable = GetAllProduk()
            cboProduct.Items.Clear()
            For Each row As DataRow In dt.Rows
                cboProduct.Items.Add(row("nama_produk").ToString())
            Next
        Catch ex As Exception
            MessageBox.Show("Gagal memuat produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HitungTotal()
        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvTransaction.Rows
            If row.IsNewRow Then Continue For
            total += Convert.ToDecimal(row.Cells("subtotal").Value)
        Next
        lblTotal.Text = "Total : Rp " & total.ToString("N0")
    End Sub

    Private Function GenerateIDPenjualan() As String
        Dim idBaru As String = "PNJ001"
        Try
            Dim query As String = "SELECT MAX(id_penjualan) FROM tbtransaksi_penjualan"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        Dim angka As Integer = CInt(result.ToString().Substring(3))
                        angka += 1
                        idBaru = "PNJ" & angka.ToString("000")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal generate ID: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return idBaru
    End Function

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If cboProduct.Text = "" OrElse txtQty.Text.Trim() = "" Then
            MessageBox.Show("Pilih produk dan isi jumlah terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim dt As DataTable = GetAllProduk()
            Dim produkRow As DataRow = Nothing

            For Each row As DataRow In dt.Rows
                If row("nama_produk").ToString() = cboProduct.Text Then
                    produkRow = row
                    Exit For
                End If
            Next

            If produkRow Is Nothing Then
                MessageBox.Show("Produk tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim idProduk As String = produkRow("id_produk").ToString()
            Dim namaProduk As String = produkRow("nama_produk").ToString()
            Dim harga As Decimal = Convert.ToDecimal(produkRow("harga_jual"))
            Dim stok As Integer = Convert.ToInt32(produkRow("stok"))
            Dim qty As Integer = Convert.ToInt32(txtQty.Text.Trim())

            If Not CekStokCukup(idProduk, qty) Then
                MessageBox.Show("Stok tidak mencukupi. Stok tersedia: " & stok, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            For Each row As DataGridViewRow In dgvTransaction.Rows
                If row.IsNewRow Then Continue For
                If row.Cells("id_produk").Value.ToString() = idProduk Then
                    Dim qtyLama As Integer = Convert.ToInt32(row.Cells("qty").Value)
                    Dim qtyBaru As Integer = qtyLama + qty
                    If Not CekStokCukup(idProduk, qtyBaru) Then
                        MessageBox.Show("Stok tidak mencukupi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    row.Cells("qty").Value = qtyBaru
                    row.Cells("subtotal").Value = qtyBaru * harga
                    HitungTotal()
                    Exit Sub
                End If
            Next

            dgvTransaction.Rows.Add(idProduk, namaProduk, qty, harga, qty * harga)
            HitungTotal()

        Catch ex As Exception
            MessageBox.Show("Gagal menambah item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEditItem_Click(sender As Object, e As EventArgs) Handles btnEditItem.Click
        If dgvTransaction.CurrentRow Is Nothing Then Exit Sub

        Try
            Dim idProduk As String = dgvTransaction.CurrentRow.Cells("id_produk").Value.ToString()
            Dim stok As Integer = 0
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand("SELECT stok FROM tbproduk WHERE id_produk=@id", conn)
                    cmd.Parameters.AddWithValue("@id", idProduk)
                    stok = Convert.ToInt32(cmd.ExecuteScalar())
                End Using
            End Using

            If txtQty.Text.Trim() = "" Then
                MessageBox.Show("Isi jumlah terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim qty As Integer = CInt(txtQty.Text.Trim())

            If qty <= 0 Then
                MessageBox.Show("Jumlah harus lebih dari 0", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If qty > stok Then
                MessageBox.Show("Stok tidak mencukupi. Stok tersedia: " & stok, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim harga As Decimal = Convert.ToDecimal(dgvTransaction.CurrentRow.Cells("harga").Value)
            dgvTransaction.CurrentRow.Cells("qty").Value = qty
            dgvTransaction.CurrentRow.Cells("subtotal").Value = qty * harga
            HitungTotal()

        Catch ex As Exception
            MessageBox.Show("Gagal mengubah item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If dgvTransaction.CurrentRow IsNot Nothing Then
            dgvTransaction.Rows.Remove(dgvTransaction.CurrentRow)
            HitungTotal()
        Else
            MessageBox.Show("Pilih item yang ingin dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvTransaction_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransaction.CellClick
        If e.RowIndex >= 0 Then
            cboProduct.Text = dgvTransaction.Rows(e.RowIndex).Cells("nama_produk").Value.ToString()
            txtQty.Text = dgvTransaction.Rows(e.RowIndex).Cells("qty").Value.ToString()
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If dgvTransaction.Rows.Count = 0 Then
            MessageBox.Show("Tambahkan item terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim total As Decimal = 0
        For Each row As DataGridViewRow In dgvTransaction.Rows
            If row.IsNewRow Then Continue For
            total += Convert.ToDecimal(row.Cells("subtotal").Value)
        Next

        Dim hasil As DialogResult = MessageBox.Show("Konfirmasi transaksi senilai Rp " & total.ToString("N0") & "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.No Then Exit Sub

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Dim transaksi As MySqlTransaction = conn.BeginTransaction()

                Try
                    Dim idPenjualan As String = GenerateIDPenjualan()
                    Dim cmdPenjualan As New MySqlCommand("INSERT INTO tbtransaksi_penjualan VALUES (@id, @tanggal, @karyawan, @total, @bayar, @kembalian)", conn, transaksi)
                    cmdPenjualan.Parameters.AddWithValue("@id", idPenjualan)
                    cmdPenjualan.Parameters.AddWithValue("@tanggal", Date.Now)
                    cmdPenjualan.Parameters.AddWithValue("@karyawan", SessionInfo.IDKaryawan)
                    cmdPenjualan.Parameters.AddWithValue("@total", total)
                    cmdPenjualan.Parameters.AddWithValue("@bayar", total)
                    cmdPenjualan.Parameters.AddWithValue("@kembalian", 0)
                    cmdPenjualan.ExecuteNonQuery()

                    Dim nomor As Integer = 1
                    For Each row As DataGridViewRow In dgvTransaction.Rows
                        If row.IsNewRow Then Continue For

                        Dim idDetail As String = "DTJ" & DateTime.Now.ToString("yyyyMMddHHmmss") & nomor.ToString()
                        Dim idProduk As String = row.Cells("id_produk").Value.ToString()
                        Dim qty As Integer = Convert.ToInt32(row.Cells("qty").Value)
                        Dim harga As Decimal = Convert.ToDecimal(row.Cells("harga").Value)
                        Dim subtotal As Decimal = Convert.ToDecimal(row.Cells("subtotal").Value)

                        Dim cmdDetail As New MySqlCommand(
                            "INSERT INTO tbdetail_penjualan VALUES (@iddetail, @idpenjualan, @idproduk, @qty, @harga, @subtotal)",
                            conn, transaksi)
                        cmdDetail.Parameters.AddWithValue("@iddetail", idDetail)
                        cmdDetail.Parameters.AddWithValue("@idpenjualan", idPenjualan)
                        cmdDetail.Parameters.AddWithValue("@idproduk", idProduk)
                        cmdDetail.Parameters.AddWithValue("@qty", qty)
                        cmdDetail.Parameters.AddWithValue("@harga", harga)
                        cmdDetail.Parameters.AddWithValue("@subtotal", subtotal)
                        cmdDetail.ExecuteNonQuery()

                        Dim cmdUpdate As New MySqlCommand(
                            "UPDATE tbproduk SET stok = stok - @qty WHERE id_produk = @idproduk",
                            conn, transaksi)
                        cmdUpdate.Parameters.AddWithValue("@qty", qty)
                        cmdUpdate.Parameters.AddWithValue("@idproduk", idProduk)
                        cmdUpdate.ExecuteNonQuery()

                        nomor += 1
                    Next

                    transaksi.Commit()
                    MessageBox.Show("Transaksi berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    dgvTransaction.Rows.Clear()
                    cboProduct.SelectedIndex = -1
                    txtQty.Clear()
                    HitungTotal()

                Catch ex As Exception
                    transaksi.Rollback()
                    MessageBox.Show("Transaksi gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using

        Catch ex As Exception
            MessageBox.Show("Gagal koneksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub HistorySidebar_Click(sender As Object, e As EventArgs) Handles HistorySidebar.Click
        Dim f As New History()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub LogoutSidebar_Click(sender As Object, e As EventArgs) Handles LogoutSidebar.Click
        Dim hasil As DialogResult = MessageBox.Show("Yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            SessionInfo.ClearSession()
            Dim f As New FormLogin()
            f.Show()
            Me.Close()
        End If
    End Sub

    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class