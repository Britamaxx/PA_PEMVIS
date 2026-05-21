<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StaffManagement))
        Panel1 = New Panel()
        Panel7 = New Panel()
        PictureBox7 = New PictureBox()
        LogoutSidebar = New Label()
        StockSidebar = New Panel()
        PictureBox6 = New PictureBox()
        Label5 = New Label()
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
        dgvStaff = New DataGridView()
        colIDKaryawan = New DataGridViewTextBoxColumn()
        btnAddStaff = New Button()
        btnEdit = New Button()
        btnDelete = New Button()
        btnSearch = New Button()
        txtSearch = New TextBox()
        PictureBox11 = New PictureBox()
        Label7 = New Label()
        Label8 = New Label()
        Panel1.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        StockSidebar.SuspendLayout()
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
        CType(dgvStaff, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(StockSidebar)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(StaffSidebar)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 850)
        Panel1.TabIndex = 3
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
        LogoutSidebar.Location = New Point(3, 6)
        LogoutSidebar.Name = "LogoutSidebar"
        LogoutSidebar.Padding = New Padding(90, 0, 0, 0)
        LogoutSidebar.Size = New Size(294, 38)
        LogoutSidebar.TabIndex = 1
        LogoutSidebar.Text = "Logout"
        ' 
        ' StockSidebar
        ' 
        StockSidebar.Controls.Add(PictureBox6)
        StockSidebar.Controls.Add(Label5)
        StockSidebar.Location = New Point(0, 447)
        StockSidebar.Name = "StockSidebar"
        StockSidebar.Size = New Size(300, 50)
        StockSidebar.TabIndex = 3
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
        ' Label5
        ' 
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(3, 6)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(90, 0, 0, 0)
        Label5.Size = New Size(294, 38)
        Label5.TabIndex = 1
        Label5.Text = "Stock"
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
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
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
        ' dgvStaff
        ' 
        dgvStaff.BackgroundColor = Color.White
        dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvStaff.Columns.AddRange(New DataGridViewColumn() {colIDKaryawan})
        dgvStaff.Location = New Point(317, 154)
        dgvStaff.Name = "dgvStaff"
        dgvStaff.RowHeadersWidth = 62
        dgvStaff.Size = New Size(1049, 678)
        dgvStaff.TabIndex = 5
        ' 
        ' colIDKaryawan
        ' 
        colIDKaryawan.DataPropertyName = "id_karyawan"
        colIDKaryawan.HeaderText = ""
        colIDKaryawan.MinimumWidth = 8
        colIDKaryawan.Name = "colIDKaryawan"
        colIDKaryawan.Width = 150
        ' 
        ' btnAddStaff
        ' 
        btnAddStaff.BackColor = Color.LimeGreen
        btnAddStaff.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddStaff.ForeColor = Color.White
        btnAddStaff.Location = New Point(1220, 91)
        btnAddStaff.Name = "btnAddStaff"
        btnAddStaff.Size = New Size(146, 40)
        btnAddStaff.TabIndex = 8
        btnAddStaff.Text = "+ Add Staff"
        btnAddStaff.UseVisualStyleBackColor = False
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = Color.CornflowerBlue
        btnEdit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEdit.ForeColor = Color.White
        btnEdit.Location = New Point(1129, 91)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(85, 40)
        btnEdit.TabIndex = 9
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.Red
        btnDelete.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDelete.ForeColor = Color.White
        btnDelete.Location = New Point(1038, 91)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(85, 40)
        btnDelete.TabIndex = 11
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(947, 91)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(85, 40)
        btnSearch.TabIndex = 12
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = SystemColors.ControlDark
        txtSearch.Location = New Point(357, 92)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(584, 39)
        txtSearch.TabIndex = 13
        txtSearch.Text = "Search..."
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), Image)
        PictureBox11.Location = New Point(317, 96)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(35, 35)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 14
        PictureBox11.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.ControlDark
        Label7.Location = New Point(317, 12)
        Label7.Name = "Label7"
        Label7.Size = New Size(116, 25)
        Label7.TabIndex = 15
        Label7.Text = "17 May 2026"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        Label8.Location = New Point(317, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(224, 32)
        Label8.TabIndex = 16
        Label8.Text = "Staff Management"
        ' 
        ' StaffManagement
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1378, 844)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(PictureBox11)
        Controls.Add(txtSearch)
        Controls.Add(btnSearch)
        Controls.Add(btnDelete)
        Controls.Add(btnEdit)
        Controls.Add(btnAddStaff)
        Controls.Add(dgvStaff)
        Controls.Add(Panel1)
        Name = "StaffManagement"
        Text = "Form5"
        Panel1.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        StockSidebar.ResumeLayout(False)
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
        CType(dgvStaff, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents LogoutSidebar As Label
    Friend WithEvents StockSidebar As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label5 As Label
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
    Friend WithEvents dgvStaff As DataGridView
    Friend WithEvents btnAddStaff As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents colIDKaryawan As DataGridViewTextBoxColumn
End Class
