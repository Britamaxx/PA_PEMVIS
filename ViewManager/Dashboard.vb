Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilDashboard()
    End Sub

    Private Sub TampilDashboard()
        Dim totalSales As Long = GetTotalPenjualanHariIni()
        lblTodaySales.Text = "Rp " & totalSales.ToString("N0")

        Dim totalTransaksi As Integer = GetJumlahTransaksiHariIni()
        lblTransactionCount.Text = totalTransaksi.ToString()

        Dim netProfit As Long = GetNetProfitHariIni()
        lblNetProfit.Text = "Rp " & netProfit.ToString("N0")

        dgvTopSelling.AutoGenerateColumns = True
        dgvTopSelling.DataSource = GetTopSellingProducts()

        dgvLowStock.AutoGenerateColumns = True
        dgvLowStock.DataSource = GetLowStockProducts()
    End Sub

    Private Sub DashboardSidebar_Click(sender As Object, e As EventArgs) Handles DashboardSidebar.Click

    End Sub

    Private Sub ProductSidebar_Click(sender As Object, e As EventArgs) Handles ProductSidebar.Click
        Dim f As New ProductManagement()
        f.Show()
        Me.Hide()
    End Sub

    Private Sub StaffSidebar_Click(sender As Object, e As EventArgs) Handles StaffSidebar.Click, Label2.Click
        Dim f As New StaffManagement
        f.Show()
        Hide()
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
            Dim f As New FormLogin()
            f.Show()
            Me.Close()
        End If
    End Sub
End Class