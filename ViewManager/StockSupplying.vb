Public Class StockSupplying

    Private idProdukTerpilih As String = ""
    Private idCartTerpilih As String = ""
    Private dtCart As New DataTable()

    Private Sub StockSupplying_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtCart.Columns.Add("id_produk")
        dtCart.Columns.Add("nama_produk")
        dtCart.Columns.Add("jumlah_barang")
        dtCart.Columns.Add("harga_pembelian")
        dtCart.Columns.Add("subtotal")

        Dim dtSupplier As DataTable = GetAllSupplier()
        cboSupplier.DataSource = dtSupplier
        cboSupplier.DisplayMember = "nama_supplier"
        cboSupplier.ValueMember = "id_supplier"
        cboSupplier.SelectedIndex = -1

        dgvCart.DataSource = dtCart
        dgvCart.AutoGenerateColumns = True

        dgvProduk.AutoGenerateColumns = True
    End Sub

    Private Sub cboSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSupplier.SelectedIndexChanged
        If cboSupplier.SelectedIndex = -1 Then Exit Sub
        TampilProdukBySupplier()
    End Sub

    Private Sub TampilProdukBySupplier()
        Dim idSupplier As String = cboSupplier.SelectedValue.ToString()
        dgvProduk.DataSource = GetProdukBySupplier(idSupplier)
        dgvProduk.Columns("id_produk").Visible = False
        dgvProduk.Columns("id_supplier").Visible = False
        idProdukTerpilih = ""
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If cboSupplier.SelectedIndex = -1 Then
            MessageBox.Show("Pilih supplier terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtSearch.Text.Trim() = "" Then
            TampilProdukBySupplier()
            Exit Sub
        End If
        dgvProduk.DataSource = SearchProdukBySupplier(cboSupplier.SelectedValue.ToString(), txtSearch.Text.Trim())
        dgvProduk.Columns("id_produk").Visible = False
        dgvProduk.Columns("id_supplier").Visible = False
    End Sub

    Private Sub dgvProduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProduk.Rows(e.RowIndex)
            If row.Cells("id_produk").Value IsNot Nothing Then
                idProdukTerpilih = row.Cells("id_produk").Value.ToString()
            End If
        End If
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        If idProdukTerpilih = "" Then
            MessageBox.Show("Pilih produk terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each row As DataRow In dtCart.Rows
            If row("id_produk").ToString() = idProdukTerpilih Then
                MessageBox.Show("Produk sudah ada di cart", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        Next

        Dim dt As DataTable = GetProdukByID(idProdukTerpilih)
        If dt.Rows.Count = 0 Then Exit Sub

        Dim produkRow As DataRow = dt.Rows(0)
        Dim newRow As DataRow = dtCart.NewRow()
        newRow("id_produk") = produkRow("id_produk")
        newRow("nama_produk") = produkRow("nama_produk")
        newRow("jumlah_barang") = 1
        newRow("harga_pembelian") = produkRow("harga_beli")
        newRow("subtotal") = produkRow("harga_beli")
        dtCart.Rows.Add(newRow)

        dgvCart.Refresh()
    End Sub

    Private Sub dgvCart_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvCart.Rows(e.RowIndex)
            If row.Cells("id_produk").Value IsNot Nothing Then
                idCartTerpilih = row.Cells("id_produk").Value.ToString()
                txtItemAmount.Text = row.Cells("jumlah_barang").Value.ToString()
            End If
        End If
    End Sub

    Private Sub txtItemAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemAmount.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtItemAmount_Leave(sender As Object, e As EventArgs) Handles txtItemAmount.Leave
        If idCartTerpilih = "" OrElse txtItemAmount.Text.Trim() = "" Then Exit Sub

        Dim jumlah As Integer = Convert.ToInt32(txtItemAmount.Text.Trim())
        If jumlah <= 0 Then
            MessageBox.Show("Jumlah harus lebih dari 0", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each row As DataRow In dtCart.Rows
            If row("id_produk").ToString() = idCartTerpilih Then
                row("jumlah_barang") = jumlah
                row("subtotal") = jumlah * Convert.ToDecimal(row("harga_pembelian"))
                Exit For
            End If
        Next
        dgvCart.Refresh()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If idCartTerpilih = "" Then
            MessageBox.Show("Pilih item di cart yang ingin dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each row As DataRow In dtCart.Rows
            If row("id_produk").ToString() = idCartTerpilih Then
                dtCart.Rows.Remove(row)
                Exit For
            End If
        Next

        idCartTerpilih = ""
        txtItemAmount.Clear()
        dgvCart.Refresh()
    End Sub

    Private Sub btnConfirmTransaction_Click(sender As Object, e As EventArgs) Handles btnConfirmTransaction.Click
        If dtCart.Rows.Count = 0 Then
            MessageBox.Show("Cart masih kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If cboSupplier.SelectedIndex = -1 Then
            MessageBox.Show("Pilih supplier terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim totalHarga As Decimal = 0
        For Each row As DataRow In dtCart.Rows
            totalHarga += Convert.ToDecimal(row("subtotal"))
        Next

        Dim hasil As DialogResult = MessageBox.Show("Konfirmasi transaksi pembelian senilai Rp " & totalHarga.ToString("N0") & "?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.No Then Exit Sub

        Dim idPembelian As String = "PMB" & Format(Now, "yyyyMMddHHmmss")
        Dim idSupplier As String = cboSupplier.SelectedValue.ToString()
        Dim idKaryawan As String = SessionInfo.IDKaryawan
        Dim tanggal As Date = Now.Date

        If Not SimpanTransaksiPembelian(idPembelian, tanggal, idSupplier, idKaryawan, totalHarga) Then Exit Sub

        Dim counter As Integer = 1
        For Each row As DataRow In dtCart.Rows
            Dim idDetail As String = "DTP" & Format(Now, "yyyyMMddHHmmss") & counter.ToString()
            Dim idProduk As String = row("id_produk").ToString()
            Dim jumlah As Integer = Convert.ToInt32(row("jumlah_barang"))
            Dim harga As Decimal = Convert.ToDecimal(row("harga_pembelian"))
            Dim subtotal As Decimal = Convert.ToDecimal(row("subtotal"))

            SimpanDetailPembelian(idDetail, idPembelian, idProduk, jumlah, harga, subtotal)
            TambahStok(idProduk, jumlah)
            counter += 1
        Next

        MessageBox.Show("Transaksi pembelian berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        dtCart.Rows.Clear()
        dgvCart.Refresh()
        cboSupplier.SelectedIndex = -1
        dgvProduk.DataSource = Nothing
        txtItemAmount.Clear()
        idProdukTerpilih = ""
        idCartTerpilih = ""
    End Sub

    Private Sub DashboardSidebar_Click(sender As Object, e As EventArgs) Handles DashboardSidebar.Click
        Dim f As New Dashboard()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub ProductSidebar_Click(sender As Object, e As EventArgs) Handles ProductSidebar.Click
        Dim f As New ProductManagement()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub StaffSidebar_Click(sender As Object, e As EventArgs) Handles StaffSidebar.Click
        Dim f As New StaffManagement()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub SupplierSidebar_Click(sender As Object, e As EventArgs) Handles SupplierSidebar.Click
        Dim f As New SupplierManagement()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub StockSidebar_Click(sender As Object, e As EventArgs) Handles StockSidebar.Click

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

    Private Sub dgvProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellContentClick

    End Sub
End Class