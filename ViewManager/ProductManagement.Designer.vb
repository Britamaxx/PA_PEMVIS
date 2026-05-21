<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductManagement))
        Panel1 = New Panel()
        LogoutSidebar = New Panel()
        PictureBox7 = New PictureBox()
        Label6 = New Label()
        Panel6 = New Panel()
        PictureBox6 = New PictureBox()
        StockSidebar = New Label()
        Panel5 = New Panel()
        PictureBox5 = New PictureBox()
        SupplierSidebar = New Label()
        StaffSidebar = New Panel()
        PictureBox4 = New PictureBox()
        Label3 = New Label()
        Panel3 = New Panel()
        PictureBox3 = New PictureBox()
        ProductSidebar = New Label()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        DashboardSidebar = New Label()
        PictureBox1 = New PictureBox()
        dgvProduk = New DataGridView()
        Label7 = New Label()
        Label8 = New Label()
        txtSearch = New TextBox()
        btnAddProduct = New Button()
        btnEdit = New Button()
        PictureBox11 = New PictureBox()
        btnDelete = New Button()
        btnSearch = New Button()
        Panel1.SuspendLayout()
        LogoutSidebar.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        StaffSidebar.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvProduk, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        Panel1.Controls.Add(LogoutSidebar)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(StaffSidebar)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 850)
        Panel1.TabIndex = 2
        ' 
        ' LogoutSidebar
        ' 
        LogoutSidebar.Controls.Add(PictureBox7)
        LogoutSidebar.Controls.Add(Label6)
        LogoutSidebar.Location = New Point(0, 782)
        LogoutSidebar.Name = "LogoutSidebar"
        LogoutSidebar.Size = New Size(300, 50)
        LogoutSidebar.TabIndex = 3
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(28, 6)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(41, 38)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 3
        PictureBox7.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(3, 6)
        Label6.Name = "Label6"
        Label6.Padding = New Padding(90, 0, 0, 0)
        Label6.Size = New Size(294, 38)
        Label6.TabIndex = 1
        Label6.Text = "Logout"
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(PictureBox6)
        Panel6.Controls.Add(StockSidebar)
        Panel6.Location = New Point(0, 447)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(300, 50)
        Panel6.TabIndex = 3
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(28, 6)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(41, 38)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 3
        PictureBox6.TabStop = False
        ' 
        ' StockSidebar
        ' 
        StockSidebar.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StockSidebar.ForeColor = Color.White
        StockSidebar.Location = New Point(3, 6)
        StockSidebar.Name = "StockSidebar"
        StockSidebar.Padding = New Padding(90, 0, 0, 0)
        StockSidebar.Size = New Size(294, 38)
        StockSidebar.TabIndex = 1
        StockSidebar.Text = "Stock"
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(PictureBox5)
        Panel5.Controls.Add(SupplierSidebar)
        Panel5.Location = New Point(0, 374)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(300, 50)
        Panel5.TabIndex = 3
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(28, 6)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(41, 38)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 3
        PictureBox5.TabStop = False
        ' 
        ' SupplierSidebar
        ' 
        SupplierSidebar.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SupplierSidebar.ForeColor = Color.White
        SupplierSidebar.Location = New Point(3, 6)
        SupplierSidebar.Name = "SupplierSidebar"
        SupplierSidebar.Padding = New Padding(90, 0, 0, 0)
        SupplierSidebar.Size = New Size(294, 38)
        SupplierSidebar.TabIndex = 1
        SupplierSidebar.Text = "Supplier"
        ' 
        ' StaffSidebar
        ' 
        StaffSidebar.Controls.Add(PictureBox4)
        StaffSidebar.Controls.Add(Label3)
        StaffSidebar.Location = New Point(0, 303)
        StaffSidebar.Name = "StaffSidebar"
        StaffSidebar.Size = New Size(300, 50)
        StaffSidebar.TabIndex = 3
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(28, 6)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(41, 38)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 3
        PictureBox4.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(3, 6)
        Label3.Name = "Label3"
        Label3.Padding = New Padding(90, 0, 0, 0)
        Label3.Size = New Size(294, 38)
        Label3.TabIndex = 1
        Label3.Text = "Staff"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(PictureBox3)
        Panel3.Controls.Add(ProductSidebar)
        Panel3.Location = New Point(0, 232)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(300, 50)
        Panel3.TabIndex = 3
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(28, 6)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(41, 38)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 3
        PictureBox3.TabStop = False
        ' 
        ' ProductSidebar
        ' 
        ProductSidebar.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ProductSidebar.ForeColor = Color.White
        ProductSidebar.Location = New Point(3, 6)
        ProductSidebar.Name = "ProductSidebar"
        ProductSidebar.Padding = New Padding(90, 0, 0, 0)
        ProductSidebar.Size = New Size(294, 38)
        ProductSidebar.TabIndex = 1
        ProductSidebar.Text = "Product"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(DashboardSidebar)
        Panel2.Location = New Point(0, 164)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(300, 50)
        Panel2.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(28, 6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(41, 38)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' DashboardSidebar
        ' 
        DashboardSidebar.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DashboardSidebar.ForeColor = Color.White
        DashboardSidebar.Location = New Point(3, 6)
        DashboardSidebar.Name = "DashboardSidebar"
        DashboardSidebar.Padding = New Padding(90, 0, 0, 0)
        DashboardSidebar.Size = New Size(294, 38)
        DashboardSidebar.TabIndex = 1
        DashboardSidebar.Text = "Dashboard"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(73, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(147, 128)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' dgvProduk
        ' 
        dgvProduk.BackgroundColor = Color.White
        dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProduk.Location = New Point(317, 152)
        dgvProduk.Name = "dgvProduk"
        dgvProduk.RowHeadersWidth = 62
        dgvProduk.Size = New Size(1049, 680)
        dgvProduk.TabIndex = 3
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.ControlDark
        Label7.Location = New Point(317, 12)
        Label7.Name = "Label7"
        Label7.Size = New Size(116, 25)
        Label7.TabIndex = 4
        Label7.Text = "17 May 2026"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        Label8.Location = New Point(317, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(263, 32)
        Label8.TabIndex = 5
        Label8.Text = "Product Management"
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = SystemColors.ControlDark
        txtSearch.Location = New Point(358, 92)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(584, 39)
        txtSearch.TabIndex = 6
        txtSearch.Text = "Search..."
        ' 
        ' btnAddProduct
        ' 
        btnAddProduct.BackColor = Color.LimeGreen
        btnAddProduct.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddProduct.ForeColor = Color.White
        btnAddProduct.Location = New Point(1221, 91)
        btnAddProduct.Name = "btnAddProduct"
        btnAddProduct.Size = New Size(146, 40)
        btnAddProduct.TabIndex = 7
        btnAddProduct.Text = "+ Add Product"
        btnAddProduct.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.CornflowerBlue
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(1130, 91)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(85, 40)
        btnEdit.TabIndex = 8
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), Image)
        PictureBox11.Location = New Point(317, 96)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(35, 35)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 9
        PictureBox11.TabStop = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(1039, 91)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(85, 40)
        btnDelete.TabIndex = 10
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(948, 91)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(85, 40)
        btnSearch.TabIndex = 11
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' ProductManagement
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1378, 844)
        Controls.Add(btnSearch)
        Controls.Add(btnDelete)
        Controls.Add(PictureBox11)
        Controls.Add(btnEdit)
        Controls.Add(btnAddProduct)
        Controls.Add(txtSearch)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(dgvProduk)
        Controls.Add(Panel1)
        Name = "ProductManagement"
        Text = "Form3"
        Panel1.ResumeLayout(False)
        LogoutSidebar.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        StaffSidebar.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvProduk, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LogoutSidebar As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents StockSidebar As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents SupplierSidebar As Label
    Friend WithEvents StaffSidebar As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ProductSidebar As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DashboardSidebar As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvProduk As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAddProduct As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
End Class
