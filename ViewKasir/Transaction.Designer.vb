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
        Panel7 = New Panel()
        PictureBox7 = New PictureBox()
        Label6 = New Label()
        Panel3 = New Panel()
        PictureBox3 = New PictureBox()
        Label2 = New Label()
        Panel2 = New Panel()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label7 = New Label()
        Label8 = New Label()
        DataGridView1 = New DataGridView()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button5 = New Button()
        Panel1.SuspendLayout()
        Panel7.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        Panel1.Controls.Add(Panel7)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 850)
        Panel1.TabIndex = 6
        ' 
        ' Panel7
        ' 
        Panel7.Controls.Add(PictureBox7)
        Panel7.Controls.Add(Label6)
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
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(87, 6)
        Label6.Name = "Label6"
        Label6.Size = New Size(103, 38)
        Label6.TabIndex = 1
        Label6.Text = "Logout"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(PictureBox3)
        Panel3.Controls.Add(Label2)
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(87, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(105, 38)
        Label2.TabIndex = 1
        Label2.Text = "History"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox2)
        Panel2.Controls.Add(Label1)
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(87, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 38)
        Label1.TabIndex = 1
        Label1.Text = "Transaction"
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
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(315, 91)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1051, 550)
        DataGridView1.TabIndex = 27
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(315, 669)
        Label3.Name = "Label3"
        Label3.Size = New Size(105, 28)
        Label3.TabIndex = 28
        Label3.Text = "Product ID"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(448, 666)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(918, 34)
        TextBox1.TabIndex = 29
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(448, 706)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(918, 34)
        TextBox2.TabIndex = 30
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
        ' Button1
        ' 
        Button1.BackColor = Color.LimeGreen
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1220, 746)
        Button1.Name = "Button1"
        Button1.Size = New Size(146, 40)
        Button1.TabIndex = 32
        Button1.Text = "+ Add Item"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.CornflowerBlue
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(1129, 746)
        Button2.Name = "Button2"
        Button2.Size = New Size(85, 40)
        Button2.TabIndex = 33
        Button2.Text = "Edit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Location = New Point(1038, 746)
        Button3.Name = "Button3"
        Button3.Size = New Size(85, 40)
        Button3.TabIndex = 34
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        Button5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.White
        Button5.Location = New Point(315, 792)
        Button5.Name = "Button5"
        Button5.Size = New Size(1051, 40)
        Button5.TabIndex = 35
        Button5.Text = "Confirm Transaction"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1378, 844)
        Controls.Add(Button5)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Panel1)
        Name = "Form10"
        Text = "Form10"
        Panel1.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
End Class
