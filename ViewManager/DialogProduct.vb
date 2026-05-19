Public Class DialogProduct

    Public Mode As String = "Tambah"
    Public IDTerpilih As String = ""

    Private Sub DialogProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Mode = "Edit" Then
            TampilDataEdit()
        Else
            txtProductID.Clear()
            txtProductID.Enabled = True
        End If
    End Sub

    Private Sub TampilDataEdit()
        Dim dt As DataTable = GetProdukByID(IDTerpilih)

        If dt.Rows.Count = 0 Then
            MessageBox.Show("Data tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Exit Sub
        End If

        Dim row As DataRow = dt.Rows(0)

        txtProductID.Text = row("id_produk").ToString()
        txtProductID.Enabled = False
        txtProductName.Text = row("nama_produk").ToString()
        txtCategory.Text = row("kategori").ToString()
        txtBuyingPrice.Text = row("harga_beli").ToString()
        txtSellingPrice.Text = row("harga_jual").ToString()
        txtMinimumStock.Text = row("stok_minimum").ToString()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If txtProductID.Text.Trim() = "" OrElse
           txtProductName.Text.Trim() = "" OrElse
           txtBuyingPrice.Text.Trim() = "" OrElse
           txtSellingPrice.Text.Trim() = "" OrElse
           txtMinimumStock.Text.Trim() = "" Then

            MessageBox.Show("Semua field harus diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim id As String = txtProductID.Text.Trim()
        Dim nama As String = txtProductName.Text.Trim()
        Dim kategori As String = txtCategory.Text.Trim()
        Dim hargaBeli As Long = Convert.ToInt64(txtBuyingPrice.Text.Trim())
        Dim hargaJual As Long = Convert.ToInt64(txtSellingPrice.Text.Trim())
        Dim stokMin As Integer = Convert.ToInt32(txtMinimumStock.Text.Trim())

        If Mode = "Tambah" Then

            If SimpanProduk(id, "", nama, stokMin, hargaBeli, hargaJual, kategori) Then
                MessageBox.Show("Data produk berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If

        Else

            If UbahProduk(id, "", nama, stokMin, hargaBeli, hargaJual, kategori) Then
                MessageBox.Show("Data produk berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If

        End If
    End Sub

    Private Sub txtBuyingPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuyingPrice.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSellingPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSellingPrice.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMinimumStock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinimumStock.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class