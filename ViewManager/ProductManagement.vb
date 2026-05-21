Imports System.Windows

Public Class ProductManagement
    Private idTerpilih As String = ""

    Private Sub TampilData()
        dgvProduk.DataSource = GetAllProduk()
        dgvProduk.Columns("id_produk").Visible = False
    End Sub

    Private Sub ProductManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProduk.AutoGenerateColumns = True
        TampilData()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text.Trim() = "" Then
            TampilData()
            Exit Sub
        End If
        dgvProduk.DataSource = SearchProduk(txtSearch.Text.Trim())
        dgvProduk.Columns("id_produk").Visible = False
        If dgvProduk.RowCount = 0 Then
            MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
        End If
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim f4 As New DialogProduct()
        f4.Mode = "Tambah"
        If f4.ShowDialog() = DialogResult.OK Then
            TampilData()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If idTerpilih = "" Then
            MessageBox.Show("Pilih data yang ingin diedit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim f4 As New DialogProduct()
        f4.Mode = "Edit"
        f4.IDTerpilih = idTerpilih
        If f4.ShowDialog() = DialogResult.OK Then
            TampilData()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If idTerpilih = "" Then
            MessageBox.Show("Pilih data yang ingin dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim hasil As DialogResult = MessageBox.Show("Apakah data ini ingin dihapus?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            If HapusProduk(idTerpilih) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                idTerpilih = ""
                TampilData()
            End If
        End If
    End Sub

    Private Sub dgvProduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProduk.Rows(e.RowIndex)
            If row.Cells("id_produk").Value IsNot Nothing Then
                idTerpilih = row.Cells("id_produk").Value.ToString()
            End If
        End If
    End Sub

    Private Sub DashboardSidebar_Click(sender As Object, e As EventArgs) Handles DashboardSidebar.Click
        Dim f As New Dashboard()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub ProductSidebar_Click(sender As Object, e As EventArgs) Handles ProductSidebar.Click

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
        Dim f As New StockSupplying()
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
End Class