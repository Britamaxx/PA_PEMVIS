<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockSupplying
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StockSupplying))
        Panel1 = New Panel()
        Panel7 = New Panel()
        PictureBox7 = New PictureBox()
        LogoutSidebar = New Label()
        Panel6 = New Panel()
        PictureBox6 = New PictureBox()
        StockSidebar = New Label()
        Panel5 = New Panel()
        PictureBox5 = New PictureBox()
        SupplierSidebar = New Label()
        Panel4 = New Panel()
        PictureBox4 = New PictureBox()
        StaffSidebar = New Label()
        Panel3 = New Panel()
        PictureBox3 = New PictureBox()
        ProductSidebar = New Label()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        DashboardSidebar = New Label()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Label8 = New Label()
        dgvProduk = New DataGridView()
        cboSupplier = New ComboBox()
        txtSearch = New TextBox()
        PictureBox11 = New PictureBox()
        btnSearch = New Button()
        Panel8 = New Panel()
        Label9 = New Label()
        dgvCart = New DataGridView()
        btnAddToCart = New Button()
        Label10 = New Label()
        txtItemAmount = New TextBox()
        btnDelete = New Button()
        PictureBox8 = New PictureBox()
        btnConfirmTransaction = New Button()
        Panel1.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvProduk, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvCart, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 850)
        Panel1.TabIndex = 5
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(PictureBox7)
        Panel7.Controls.Add(LogoutSidebar)
        Panel7.Location = New Point(0, 782)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(300, 50)
        Panel7.TabIndex = 3
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
        ' LogoutSidebar
        ' 
        LogoutSidebar.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LogoutSidebar.ForeColor = Color.Red
        LogoutSidebar.Location = New Point(0, 6)
        LogoutSidebar.Name = "LogoutSidebar"
        LogoutSidebar.Padding = New Padding(90, 0, 0, 0)
        LogoutSidebar.Size = New Size(297, 38)
        LogoutSidebar.TabIndex = 1
        LogoutSidebar.Text = "Logout"
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
        StockSidebar.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        ' Panel4
        ' 
        Panel4.Controls.Add(PictureBox4)
        Panel4.Controls.Add(StaffSidebar)
        Panel4.Location = New Point(0, 303)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(300, 50)
        Panel4.TabIndex = 3
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
        ' StaffSidebar
        ' 
        StaffSidebar.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        StaffSidebar.ForeColor = Color.White
        StaffSidebar.Location = New Point(3, 6)
        StaffSidebar.Name = "StaffSidebar"
        StaffSidebar.Padding = New Padding(90, 0, 0, 0)
        StaffSidebar.Size = New Size(294, 38)
        StaffSidebar.TabIndex = 1
        StaffSidebar.Text = "Staff"
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
        ProductSidebar.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
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
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.ControlDark
        Label7.Location = New Point(319, 12)
        Label7.Name = "Label7"
        Label7.Size = New Size(116, 25)
        Label7.TabIndex = 17
        Label7.Text = "17 May 2026"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        Label8.Location = New Point(319, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(197, 32)
        Label8.TabIndex = 18
        Label8.Text = "Stock Supplying"
        ' 
        ' dgvProduk
        ' 
        dgvProduk.BackgroundColor = Color.White
        dgvProduk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProduk.Location = New Point(319, 206)
        dgvProduk.Name = "dgvProduk"
        dgvProduk.RowHeadersWidth = 62
        dgvProduk.Size = New Size(450, 568)
        dgvProduk.TabIndex = 19
        ' 
        ' cboSupplier
        ' 
        cboSupplier.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cboSupplier.FormattingEnabled = True
        cboSupplier.Location = New Point(319, 104)
        cboSupplier.Name = "cboSupplier"
        cboSupplier.Size = New Size(450, 36)
        cboSupplier.TabIndex = 20
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = SystemColors.ControlDark
        txtSearch.Location = New Point(360, 146)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(318, 39)
        txtSearch.TabIndex = 21
        txtSearch.Text = "Search..."
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), Image)
        PictureBox11.Location = New Point(319, 150)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(35, 35)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 22
        PictureBox11.TabStop = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(684, 147)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(85, 40)
        btnSearch.TabIndex = 23
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        Panel8.Location = New Point(810, 104)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(3, 722)
        Panel8.TabIndex = 24
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        Label9.Location = New Point(873, 109)
        Label9.Name = "Label9"
        Label9.Size = New Size(62, 32)
        Label9.TabIndex = 25
        Label9.Text = "Cart"
        ' 
        ' dgvCart
        ' 
        dgvCart.BackgroundColor = Color.White
        dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvCart.Location = New Point(832, 147)
        dgvCart.Name = "dgvCart"
        dgvCart.RowHeadersWidth = 62
        dgvCart.Size = New Size(534, 247)
        dgvCart.TabIndex = 26
        ' 
        ' btnAddToCart
        ' 
        btnAddToCart.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        btnAddToCart.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddToCart.ForeColor = Color.White
        btnAddToCart.Location = New Point(319, 786)
        btnAddToCart.Name = "btnAddToCart"
        btnAddToCart.Size = New Size(450, 40)
        btnAddToCart.TabIndex = 27
        btnAddToCart.Text = "Add To Cart"
        btnAddToCart.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(832, 409)
        Label10.Name = "Label10"
        Label10.Size = New Size(127, 28)
        Label10.TabIndex = 28
        Label10.Text = "Item Amount"
        ' 
        ' txtItemAmount
        ' 
        txtItemAmount.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtItemAmount.Location = New Point(965, 409)
        txtItemAmount.Name = "txtItemAmount"
        txtItemAmount.Size = New Size(401, 34)
        txtItemAmount.TabIndex = 29
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(1281, 457)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(85, 40)
        btnDelete.TabIndex = 31
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(832, 106)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(35, 35)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 32
        PictureBox8.TabStop = False
        ' 
        ' btnConfirmTransaction
        ' 
        btnConfirmTransaction.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        btnConfirmTransaction.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfirmTransaction.ForeColor = Color.White
        btnConfirmTransaction.Location = New Point(832, 786)
        btnConfirmTransaction.Name = "btnConfirmTransaction"
        btnConfirmTransaction.Size = New Size(534, 40)
        btnConfirmTransaction.TabIndex = 33
        btnConfirmTransaction.Text = "Confirm Transaction"
        btnConfirmTransaction.UseVisualStyleBackColor = False
        ' 
        ' StockSupplying
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1378, 844)
        Controls.Add(btnConfirmTransaction)
        Controls.Add(PictureBox8)
        Controls.Add(btnDelete)
        Controls.Add(txtItemAmount)
        Controls.Add(Label10)
        Controls.Add(btnAddToCart)
        Controls.Add(dgvCart)
        Controls.Add(Label9)
        Controls.Add(Panel8)
        Controls.Add(btnSearch)
        Controls.Add(PictureBox11)
        Controls.Add(txtSearch)
        Controls.Add(cboSupplier)
        Controls.Add(dgvProduk)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        Name = "StockSupplying"
        Text = "Form9"
        Panel1.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvProduk, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvCart, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents LogoutSidebar As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents StockSidebar As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents SupplierSidebar As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents StaffSidebar As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ProductSidebar As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DashboardSidebar As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvProduk As DataGridView
    Friend WithEvents cboSupplier As ComboBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvCart As DataGridView
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtItemAmount As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents btnConfirmTransaction As Button
End Class
