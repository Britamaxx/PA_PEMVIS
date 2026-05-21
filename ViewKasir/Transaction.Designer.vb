<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaction))
        Panel1 = New Panel()
        LogoutSidebar = New Panel()
        PictureBox7 = New PictureBox()
        Label6 = New Label()
        Panel3 = New Panel()
        PictureBox3 = New PictureBox()
        HistorySidebar = New Label()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        TransactionSidebar = New Label()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Label8 = New Label()
        dgvTransaction = New DataGridView()
        Label3 = New Label()
        txtQty = New TextBox()
        Label4 = New Label()
        btnAddItem = New Button()
        btnEditItem = New Button()
        btnDeleteItem = New Button()
        btnConfirm = New Button()
        cboProduct = New ComboBox()
        lblTotal = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel1.SuspendLayout()
        LogoutSidebar.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvTransaction, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        Panel1.Controls.Add(LogoutSidebar)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 850)
        Panel1.TabIndex = 6
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
        Label6.Location = New Point(0, 6)
        Label6.Name = "Label6"
        Label6.Size = New Size(297, 38)
        Label6.TabIndex = 1
        Label6.Text = "Logout"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(PictureBox3)
        Panel3.Controls.Add(HistorySidebar)
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
        ' HistorySidebar
        ' 
        HistorySidebar.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        HistorySidebar.ForeColor = Color.White
        HistorySidebar.Location = New Point(3, 6)
        HistorySidebar.Name = "HistorySidebar"
        HistorySidebar.Size = New Size(297, 38)
        HistorySidebar.TabIndex = 1
        HistorySidebar.Text = "History"
        HistorySidebar.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(TransactionSidebar)
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
        ' TransactionSidebar
        ' 
        TransactionSidebar.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TransactionSidebar.ForeColor = Color.White
        TransactionSidebar.Location = New Point(3, 6)
        TransactionSidebar.Name = "TransactionSidebar"
        TransactionSidebar.Size = New Size(294, 38)
        TransactionSidebar.TabIndex = 1
        TransactionSidebar.Text = "Transaction"
        TransactionSidebar.TextAlign = ContentAlignment.TopCenter
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
        Label7.Location = New Point(315, 12)
        Label7.Name = "Label7"
        Label7.Size = New Size(116, 25)
        Label7.TabIndex = 18
        Label7.Text = "17 May 2026"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        Label8.Location = New Point(315, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(146, 32)
        Label8.TabIndex = 19
        Label8.Text = "Transaction"
        ' 
        ' dgvTransaction
        ' 
        dgvTransaction.BackgroundColor = Color.White
        dgvTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvTransaction.Location = New Point(315, 91)
        dgvTransaction.Name = "dgvTransaction"
        dgvTransaction.RowHeadersWidth = 62
        dgvTransaction.Size = New Size(1051, 550)
        dgvTransaction.TabIndex = 27
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(315, 669)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 28)
        Label3.TabIndex = 28
        Label3.Text = "Product"
        ' 
        ' txtQty
        ' 
        txtQty.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtQty.Location = New Point(448, 706)
        txtQty.Name = "txtQty"
        txtQty.Size = New Size(918, 34)
        txtQty.TabIndex = 30
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(315, 709)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 28)
        Label4.TabIndex = 31
        Label4.Text = "Item Amount"
        ' 
        ' btnAddItem
        ' 
        btnAddItem.BackColor = Color.LimeGreen
        btnAddItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddItem.ForeColor = Color.White
        btnAddItem.Location = New Point(1220, 746)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(146, 40)
        btnAddItem.TabIndex = 32
        btnAddItem.Text = "+ Add Item"
        btnAddItem.UseVisualStyleBackColor = False
        ' 
        ' btnEditItem
        ' 
        btnEditItem.BackColor = Color.CornflowerBlue
        btnEditItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEditItem.ForeColor = Color.White
        btnEditItem.Location = New Point(1129, 746)
        btnEditItem.Name = "btnEditItem"
        btnEditItem.Size = New Size(85, 40)
        btnEditItem.TabIndex = 33
        btnEditItem.Text = "Edit"
        btnEditItem.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteItem
        ' 
        btnDeleteItem.BackColor = Color.Red
        btnDeleteItem.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnDeleteItem.ForeColor = Color.White
        btnDeleteItem.Location = New Point(1038, 746)
        btnDeleteItem.Name = "btnDeleteItem"
        btnDeleteItem.Size = New Size(85, 40)
        btnDeleteItem.TabIndex = 34
        btnDeleteItem.Text = "Delete"
        btnDeleteItem.UseVisualStyleBackColor = False
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        btnConfirm.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfirm.ForeColor = Color.White
        btnConfirm.Location = New Point(315, 792)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(1051, 40)
        btnConfirm.TabIndex = 35
        btnConfirm.Text = "Confirm Transaction"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' cboProduct
        ' 
        cboProduct.FormattingEnabled = True
        cboProduct.Location = New Point(448, 664)
        cboProduct.Name = "cboProduct"
        cboProduct.Size = New Size(918, 33)
        cboProduct.TabIndex = 36
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(315, 751)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(63, 28)
        lblTotal.TabIndex = 37
        lblTotal.Text = "Total :"
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Transaction
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1378, 844)
        Controls.Add(lblTotal)
        Controls.Add(cboProduct)
        Controls.Add(btnConfirm)
        Controls.Add(btnDeleteItem)
        Controls.Add(btnEditItem)
        Controls.Add(btnAddItem)
        Controls.Add(Label4)
        Controls.Add(txtQty)
        Controls.Add(Label3)
        Controls.Add(dgvTransaction)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        Name = "Transaction"
        Text = "Form10"
        Panel1.ResumeLayout(False)
        LogoutSidebar.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvTransaction, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LogoutSidebar As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents HistorySidebar As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TransactionSidebar As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvTransaction As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnEditItem As Button
    Friend WithEvents btnDeleteItem As Button
    Friend WithEvents btnConfirm As Button
    Friend WithEvents cboProduct As ComboBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
