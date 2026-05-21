Imports System.Windows

Public Class SupplierManagement

    Private idTerpilih As String = ""

    Private Sub TampilData()
        dgvSupplier.DataSource = GetAllSupplier()
        dgvSupplier.Columns("id_supplier").Visible = True
    End Sub

    Private Sub SupplierManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSupplier.AutoGenerateColumns = True
        TampilData()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSearch.Text.Trim() = "" Then
            TampilData()
            Exit Sub
        End If
        dgvSupplier.DataSource = SearchSupplier(txtSearch.Text.Trim())
        dgvSupplier.Columns("id_supplier").Visible = False
        If dgvSupplier.RowCount = 0 Then
            MessageBox.Show("Data tidak ditemukan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
        End If
    End Sub

    Private Sub btnAddSupplier_Click(sender As Object, e As EventArgs) Handles btnAddSupplier.Click
        Dim f8 As New DialogSupplier()
        f8.Mode = "Tambah"
        If f8.ShowDialog() = DialogResult.OK Then
            TampilData()
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If idTerpilih = "" Then
            MessageBox.Show("Pilih data yang ingin diedit", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim f8 As New DialogSupplier()
        f8.Mode = "Edit"
        f8.IDTerpilih = idTerpilih
        If f8.ShowDialog() = DialogResult.OK Then
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
            If HapusSupplier(idTerpilih) Then
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                idTerpilih = ""
                TampilData()
            End If
        End If
    End Sub

    Private Sub dgvSupplier_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSupplier.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvSupplier.Rows(e.RowIndex)
            If row.Cells("id_supplier").Value IsNot Nothing Then
                idTerpilih = row.Cells("id_supplier").Value.ToString()
            End If
        End If
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim f As New ProductManagement()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Dim f As New StockSupplying()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Dim hasil As DialogResult = MessageBox.Show("Yakin ingin logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If hasil = DialogResult.Yes Then
            SessionInfo.ClearSession()
            Dim f As New FormLogin()
            f.Show()
            Me.Close()
        End If
    End Sub
End Class