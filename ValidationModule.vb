Public Module ValidationModule

    Public Const MAX_QTY As Integer = 9999
    Public Const MIN_QTY As Integer = 1
    Public Const MAX_HARGA As Long = 999_999_999
    Public Const MIN_HARGA As Long = 0
    Public Const MAX_GAJI As Long = 999_999_999
    Public Const MIN_GAJI As Long = 0
    Public Const MAX_PANJANG_NAMA As Integer = 100
    Public Const MAX_PANJANG_ID As Integer = 20
    Public Const MAX_PANJANG_TELEPON As Integer = 15
    Public Const MIN_PANJANG_TELEPON As Integer = 7

    Public Sub TampilkanPeringatan(pesan As String, Optional kontrol As Control = Nothing, Optional judul As String = "Peringatan")
        MessageBox.Show(pesan, judul, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        If kontrol IsNot Nothing Then kontrol.Focus()
    End Sub

    Public Function TidakKosong(teks As String) As Boolean
        Return Not String.IsNullOrWhiteSpace(teks)
    End Function

    Public Function AdalaAngkaPositif(teks As String) As Boolean
        Dim nilai As Integer
        Return Integer.TryParse(teks.Trim(), nilai) AndAlso nilai >= 1
    End Function

    Public Function AdalaAngkaNonNegatif(teks As String) As Boolean
        Dim nilai As Long
        Return Long.TryParse(teks.Trim(), nilai) AndAlso nilai >= 0
    End Function

    Public Function HanyaDigit(teks As String) As Boolean
        If String.IsNullOrEmpty(teks) Then Return False
        Return teks.All(Function(c) Char.IsDigit(c))
    End Function

    Public Sub BatinHanyaDigit(e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    ''' <param name="txtUsername">TextBox username</param>
    ''' <param name="txtPassword">TextBox password</param>
    Public Function ValidasiLogin(txtUsername As TextBox,
                                  txtPassword As TextBox) As Boolean
        If Not TidakKosong(txtUsername.Text) Then
            TampilkanPeringatan("Username tidak boleh kosong!", txtUsername)
            Return False
        End If

        If txtUsername.Text.Trim().Length > MAX_PANJANG_ID Then
            TampilkanPeringatan($"Username maksimal {MAX_PANJANG_ID} karakter.", txtUsername)
            Return False
        End If

        If Not TidakKosong(txtPassword.Text) Then
            TampilkanPeringatan("Password tidak boleh kosong!", txtPassword)
            Return False
        End If

        Return True
    End Function

    ''' <param name="cboNamaProduk">ComboBox nama produk</param>
    ''' <param name="txtQty">TextBox qty</param>
    ''' <param name="stokTersedia">Stok yang ada di database</param>
    Public Function ValidasiTambahItem(cboNamaProduk As ComboBox, txtQty As TextBox, stokTersedia As Integer) As Boolean
        If Not TidakKosong(cboNamaProduk.Text) Then
            TampilkanPeringatan("Pilih produk terlebih dahulu.", cboNamaProduk)
            Return False
        End If

        If Not TidakKosong(txtQty.Text) Then
            TampilkanPeringatan("Qty tidak boleh kosong.", txtQty)
            Return False
        End If

        If Not AdalaAngkaPositif(txtQty.Text) Then
            TampilkanPeringatan("Qty harus berupa angka bulat minimal 1.", txtQty)
            txtQty.Clear()
            Return False
        End If

        Dim qty As Integer = CInt(txtQty.Text.Trim())

        If qty > MAX_QTY Then
            TampilkanPeringatan($"Qty tidak boleh melebihi {MAX_QTY}.", txtQty)
            Return False
        End If

        If qty > stokTersedia Then
            TampilkanPeringatan($"Stok tidak cukup. Stok tersedia: {stokTersedia}.")
            Return False
        End If

        Return True
    End Function

    Public Function ValidasiUpdateItem(txtQty As TextBox, stokTersedia As Integer) As Boolean
        If Not TidakKosong(txtQty.Text) Then
            TampilkanPeringatan("Qty tidak boleh kosong.", txtQty)
            Return False
        End If

        If Not AdalaAngkaPositif(txtQty.Text) Then
            TampilkanPeringatan("Qty harus berupa angka bulat minimal 1.", txtQty)
            txtQty.Clear()
            Return False
        End If

        Dim qty As Integer = CInt(txtQty.Text.Trim())

        If qty > MAX_QTY Then
            TampilkanPeringatan($"Qty tidak boleh melebihi {MAX_QTY}.", txtQty)
            Return False
        End If

        If qty > stokTersedia Then
            TampilkanPeringatan($"Stok tidak cukup. Stok tersedia: {stokTersedia}.")
            Return False
        End If

        Return True
    End Function

    ''' <param name="jumlahBaris">Jumlah baris DataGridView (termasuk baris kosong bawaan)</param>
    Public Function ValidasiCheckout(jumlahBaris As Integer) As Boolean
        If jumlahBaris <= 1 Then
            TampilkanPeringatan("Keranjang masih kosong. Tambahkan produk terlebih dahulu.",
                                judul:="Transaksi Gagal")
            Return False
        End If
        Return True
    End Function

    Public Function ValidasiProduk(txtID As TextBox, txtNama As TextBox, txtHargaBeli As TextBox, txtHargaJual As TextBox, txtStokMin As TextBox) As Boolean
        If Not TidakKosong(txtID.Text) Then
            TampilkanPeringatan("ID Produk tidak boleh kosong.", txtID)
            Return False
        End If

        If txtID.Text.Trim().Length > MAX_PANJANG_ID Then
            TampilkanPeringatan($"ID Produk maksimal {MAX_PANJANG_ID} karakter.", txtID)
            Return False
        End If

        If Not TidakKosong(txtNama.Text) Then
            TampilkanPeringatan("Nama Produk tidak boleh kosong.", txtNama)
            Return False
        End If

        If txtNama.Text.Trim().Length > MAX_PANJANG_NAMA Then
            TampilkanPeringatan($"Nama Produk maksimal {MAX_PANJANG_NAMA} karakter.", txtNama)
            Return False
        End If

        If Not TidakKosong(txtHargaBeli.Text) Then
            TampilkanPeringatan("Harga Beli tidak boleh kosong.", txtHargaBeli)
            Return False
        End If

        If Not AdalaAngkaNonNegatif(txtHargaBeli.Text) Then
            TampilkanPeringatan("Harga Beli harus berupa angka (>= 0).", txtHargaBeli)
            txtHargaBeli.Clear()
            Return False
        End If

        If CLng(txtHargaBeli.Text.Trim()) > MAX_HARGA Then
            TampilkanPeringatan($"Harga Beli terlalu besar (maks Rp {MAX_HARGA:N0}).", txtHargaBeli)
            Return False
        End If

        If Not TidakKosong(txtHargaJual.Text) Then
            TampilkanPeringatan("Harga Jual tidak boleh kosong.", txtHargaJual)
            Return False
        End If

        If Not AdalaAngkaNonNegatif(txtHargaJual.Text) Then
            TampilkanPeringatan("Harga Jual harus berupa angka (>= 0).", txtHargaJual)
            txtHargaJual.Clear()
            Return False
        End If

        If CLng(txtHargaJual.Text.Trim()) > MAX_HARGA Then
            TampilkanPeringatan($"Harga Jual terlalu besar (maks Rp {MAX_HARGA:N0}).", txtHargaJual)
            Return False
        End If

        If CLng(txtHargaJual.Text.Trim()) < CLng(txtHargaBeli.Text.Trim()) Then
            TampilkanPeringatan("Harga Jual tidak boleh lebih kecil dari Harga Beli.", txtHargaJual)
            Return False
        End If

        If Not TidakKosong(txtStokMin.Text) Then
            TampilkanPeringatan("Stok Minimum tidak boleh kosong.", txtStokMin)
            Return False
        End If

        If Not AdalaAngkaNonNegatif(txtStokMin.Text) Then
            TampilkanPeringatan("Stok Minimum harus berupa angka (>= 0).", txtStokMin)
            txtStokMin.Clear()
            Return False
        End If

        Return True
    End Function

    Public Function ValidasiStaff(txtID As TextBox, txtNama As TextBox, txtTelepon As MaskedTextBox, txtGaji As TextBox, shiftTerpilih As String) As Boolean
        If Not TidakKosong(txtID.Text) Then
            TampilkanPeringatan("ID Staff tidak boleh kosong.", txtID)
            Return False
        End If

        If txtID.Text.Trim().Length > MAX_PANJANG_ID Then
            TampilkanPeringatan($"ID Staff maksimal {MAX_PANJANG_ID} karakter.", txtID)
            Return False
        End If

        If Not TidakKosong(txtNama.Text) Then
            TampilkanPeringatan("Nama Staff tidak boleh kosong.", txtNama)
            Return False
        End If

        If txtNama.Text.Trim().Length > MAX_PANJANG_NAMA Then
            TampilkanPeringatan($"Nama Staff maksimal {MAX_PANJANG_NAMA} karakter.", txtNama)
            Return False
        End If

        If Not TidakKosong(txtTelepon.Text) Then
            TampilkanPeringatan("Nomor Telepon tidak boleh kosong.", txtTelepon)
            Return False
        End If

        If Not HanyaDigit(txtTelepon.Text.Trim()) Then
            TampilkanPeringatan("Nomor Telepon hanya boleh berisi angka.", txtTelepon)
            txtTelepon.Clear()
            Return False
        End If

        If txtTelepon.Text.Trim().Length < MIN_PANJANG_TELEPON OrElse
           txtTelepon.Text.Trim().Length > MAX_PANJANG_TELEPON Then
            TampilkanPeringatan($"Nomor Telepon harus {MIN_PANJANG_TELEPON}–{MAX_PANJANG_TELEPON} digit.", txtTelepon)
            Return False
        End If

        If Not TidakKosong(txtGaji.Text) Then
            TampilkanPeringatan("Gaji Bersih tidak boleh kosong.", txtGaji)
            Return False
        End If

        If Not AdalaAngkaNonNegatif(txtGaji.Text) Then
            TampilkanPeringatan("Gaji Bersih harus berupa angka (>= 0).", txtGaji)
            txtGaji.Clear()
            Return False
        End If

        If CLng(txtGaji.Text.Trim()) > MAX_GAJI Then
            TampilkanPeringatan($"Gaji Bersih terlalu besar (maks Rp {MAX_GAJI:N0}).", txtGaji)
            Return False
        End If

        If String.IsNullOrEmpty(shiftTerpilih) Then
            TampilkanPeringatan("Pilih shift terlebih dahulu.")
            Return False
        End If

        Return True
    End Function

    Public Function ValidasiSupplier(txtID As TextBox, txtNama As TextBox, txtTelepon As MaskedTextBox, txtAlamat As TextBox) As Boolean
        If Not TidakKosong(txtID.Text) Then
            TampilkanPeringatan("ID Supplier tidak boleh kosong.", txtID)
            Return False
        End If

        If txtID.Text.Trim().Length > MAX_PANJANG_ID Then
            TampilkanPeringatan($"ID Supplier maksimal {MAX_PANJANG_ID} karakter.", txtID)
            Return False
        End If

        If Not TidakKosong(txtNama.Text) Then
            TampilkanPeringatan("Nama Supplier tidak boleh kosong.", txtNama)
            Return False
        End If

        If txtNama.Text.Trim().Length > MAX_PANJANG_NAMA Then
            TampilkanPeringatan($"Nama Supplier maksimal {MAX_PANJANG_NAMA} karakter.", txtNama)
            Return False
        End If

        If Not TidakKosong(txtTelepon.Text) Then
            TampilkanPeringatan("Nomor Telepon tidak boleh kosong.", txtTelepon)
            Return False
        End If

        If Not HanyaDigit(txtTelepon.Text.Trim()) Then
            TampilkanPeringatan("Nomor Telepon hanya boleh berisi angka.", txtTelepon)
            txtTelepon.Clear()
            Return False
        End If

        If txtTelepon.Text.Trim().Length < MIN_PANJANG_TELEPON OrElse
           txtTelepon.Text.Trim().Length > MAX_PANJANG_TELEPON Then
            TampilkanPeringatan($"Nomor Telepon harus {MIN_PANJANG_TELEPON}–{MAX_PANJANG_TELEPON} digit.", txtTelepon)
            Return False
        End If

        If Not TidakKosong(txtAlamat.Text) Then
            TampilkanPeringatan("Alamat Supplier tidak boleh kosong.", txtAlamat)
            Return False
        End If

        Return True
    End Function
End Module