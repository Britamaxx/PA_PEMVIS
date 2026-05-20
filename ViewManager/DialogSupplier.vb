Public Class DialogSupplier

    Public Mode As String = "Tambah"
    Public IDTerpilih As String = ""

    Private Sub DialogSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Mode = "Edit" Then
            TampilDataEdit()
        Else
            txtSupplierID.Enabled = True
        End If
    End Sub

    Private Sub TampilDataEdit()
        Dim dt As DataTable = GetSupplierByID(IDTerpilih)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Data tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Exit Sub
        End If

        Dim row As DataRow = dt.Rows(0)
        txtSupplierID.Text = row("id_supplier").ToString()
        txtSupplierID.Enabled = False
        txtSupplierName.Text = row("nama_supplier").ToString()
        txtSupplierPhone.Text = row("telepon_supplier").ToString()
        txtSupplierAddress.Text = row("alamat").ToString()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnKonfirmasi_Click(sender As Object, e As EventArgs) Handles btnKonfirmasi.Click
        If txtSupplierID.Text.Trim() = "" OrElse txtSupplierName.Text.Trim() = "" OrElse
           txtSupplierPhone.Text.Trim() = "" OrElse txtSupplierAddress.Text.Trim() = "" Then
            MessageBox.Show("Semua field harus diisi", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim id As String = txtSupplierID.Text.Trim()
        Dim nama As String = txtSupplierName.Text.Trim()
        Dim telepon As String = txtSupplierPhone.Text.Trim()
        Dim alamat As String = txtSupplierAddress.Text.Trim()

        If Mode = "Tambah" Then
            If SimpanSupplier(id, nama, alamat, telepon) Then
                MessageBox.Show("Data supplier berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Else
            If UbahSupplier(id, nama, alamat, telepon) Then
                MessageBox.Show("Data supplier berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub txtSupplierPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSupplierPhone.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class