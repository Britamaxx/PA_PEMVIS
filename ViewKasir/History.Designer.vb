<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History))
        Panel1 = New Panel()
        LogoutSidebar = New Panel()
        PictureBox7 = New PictureBox()
        Label6 = New Label()
        HistorySidebar = New Panel()
        PictureBox3 = New PictureBox()
        Label2 = New Label()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        TransactionSidebar = New Label()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Label8 = New Label()
        dgvHistory = New DataGridView()
        PictureBox11 = New PictureBox()
        txtSearch = New TextBox()
        btnSearch = New Button()
        btnSeeDetails = New Button()
        Panel1.SuspendLayout()
        LogoutSidebar.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        HistorySidebar.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvHistory, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        Panel1.Controls.Add(LogoutSidebar)
        Panel1.Controls.Add(HistorySidebar)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 850)
        Panel1.TabIndex = 7
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
        Label6.Location = New Point(3, 0)
        Label6.Name = "Label6"
        Label6.Padding = New Padding(90, 0, 0, 0)
        Label6.Size = New Size(294, 44)
        Label6.TabIndex = 1
        Label6.Text = "Logout"
        ' 
        ' HistorySidebar
        ' 
        HistorySidebar.Controls.Add(PictureBox3)
        HistorySidebar.Controls.Add(Label2)
        HistorySidebar.Location = New Point(0, 232)
        HistorySidebar.Name = "HistorySidebar"
        HistorySidebar.Size = New Size(300, 50)
        HistorySidebar.TabIndex = 3
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
        ' Label2
        ' 
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(3, 6)
        Label2.Name = "Label2"
        Label2.Padding = New Padding(90, 0, 0, 0)
        Label2.Size = New Size(294, 38)
        Label2.TabIndex = 1
        Label2.Text = "History"
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
        TransactionSidebar.Padding = New Padding(90, 0, 0, 0)
        TransactionSidebar.Size = New Size(294, 38)
        TransactionSidebar.TabIndex = 1
        TransactionSidebar.Text = "Transaction"
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
        Label7.TabIndex = 19
        Label7.Text = "17 May 2026"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        Label8.Location = New Point(315, 37)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 32)
        Label8.TabIndex = 20
        Label8.Text = "History"
        ' 
        ' dgvHistory
        ' 
        dgvHistory.BackgroundColor = Color.White
        dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvHistory.Location = New Point(317, 153)
        dgvHistory.Name = "dgvHistory"
        dgvHistory.RowHeadersWidth = 62
        dgvHistory.Size = New Size(1049, 679)
        dgvHistory.TabIndex = 21
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), Image)
        PictureBox11.Location = New Point(317, 96)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(35, 35)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 22
        PictureBox11.TabStop = False
        ' 
        ' txtSearch
        ' 
        txtSearch.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = SystemColors.ControlDark
        txtSearch.Location = New Point(358, 92)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(584, 39)
        txtSearch.TabIndex = 23
        txtSearch.Text = "Search..."
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        btnSearch.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(948, 91)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(85, 40)
        btnSearch.TabIndex = 24
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnSeeDetails
        ' 
        btnSeeDetails.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        btnSeeDetails.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSeeDetails.ForeColor = Color.White
        btnSeeDetails.Location = New Point(1039, 91)
        btnSeeDetails.Name = "btnSeeDetails"
        btnSeeDetails.Size = New Size(327, 40)
        btnSeeDetails.TabIndex = 25
        btnSeeDetails.Text = "See Details"
        btnSeeDetails.UseVisualStyleBackColor = False
        ' 
        ' History
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1378, 844)
        Controls.Add(btnSeeDetails)
        Controls.Add(btnSearch)
        Controls.Add(txtSearch)
        Controls.Add(PictureBox11)
        Controls.Add(dgvHistory)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        Name = "History"
        Text = "Form11"
        Panel1.ResumeLayout(False)
        LogoutSidebar.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        HistorySidebar.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvHistory, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LogoutSidebar As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents HistorySidebar As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TransactionSidebar As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnSeeDetails As Button
End Class
