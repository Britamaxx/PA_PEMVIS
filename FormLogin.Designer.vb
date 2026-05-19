<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Panel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        picShowPass = New PictureBox()
        picHidePass = New PictureBox()
        btnLogin = New Button()
        txtPassword = New TextBox()
        txtUsername = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(picShowPass, ComponentModel.ISupportInitialize).BeginInit()
        CType(picHidePass, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(440, 560)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(83, 442)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(253, 20)
        Label1.TabIndex = 1
        Label1.Text = "© 2026 9-Eleven. All Rights Reserved"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(53, 42)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(314, 310)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(txtPassword)
        Panel2.Controls.Add(txtUsername)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(440, 0)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(440, 560)
        Panel2.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(picShowPass)
        Panel3.Controls.Add(picHidePass)
        Panel3.Location = New Point(359, 280)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(40, 38)
        Panel3.TabIndex = 2
        ' 
        ' picShowPass
        ' 
        picShowPass.Image = CType(resources.GetObject("picShowPass.Image"), Image)
        picShowPass.Location = New Point(2, 2)
        picShowPass.Margin = New Padding(2)
        picShowPass.Name = "picShowPass"
        picShowPass.Size = New Size(35, 31)
        picShowPass.SizeMode = PictureBoxSizeMode.StretchImage
        picShowPass.TabIndex = 0
        picShowPass.TabStop = False
        picShowPass.Visible = False
        ' 
        ' picHidePass
        ' 
        picHidePass.Image = CType(resources.GetObject("picHidePass.Image"), Image)
        picHidePass.Location = New Point(2, 2)
        picHidePass.Margin = New Padding(2)
        picHidePass.Name = "picHidePass"
        picHidePass.Size = New Size(35, 31)
        picHidePass.SizeMode = PictureBoxSizeMode.StretchImage
        picHidePass.TabIndex = 1
        picHidePass.TabStop = False
        ' 
        ' btnLogin
        ' 
        btnLogin.AutoSize = True
        btnLogin.BackColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        btnLogin.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(38, 341)
        btnLogin.Margin = New Padding(2)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(102, 39)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(38, 280)
        txtPassword.Margin = New Padding(2)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "•"c
        txtPassword.Size = New Size(309, 34)
        txtPassword.TabIndex = 4
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(38, 177)
        txtUsername.Margin = New Padding(2)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(309, 34)
        txtUsername.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(38, 244)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 28)
        Label4.TabIndex = 2
        Label4.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(38, 142)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(99, 28)
        Label3.TabIndex = 1
        Label3.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 28.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(3), CByte(118), CByte(87))
        Label2.Location = New Point(26, 42)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(246, 62)
        Label2.TabIndex = 0
        Label2.Text = "Welcome!"
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(862, 515)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Margin = New Padding(2)
        Name = "FormLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login - 9-Eleven"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        CType(picShowPass, ComponentModel.ISupportInitialize).EndInit()
        CType(picHidePass, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents picHidePass As PictureBox
    Friend WithEvents picShowPass As PictureBox

End Class
