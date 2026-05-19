<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DialogStaff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtStaffID = New TextBox()
        Label2 = New Label()
        txtStaffName = New TextBox()
        txtStaffPhone = New MaskedTextBox()
        txtNetSalary = New TextBox()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        rbMorning = New RadioButton()
        rbAfternoon = New RadioButton()
        rbNight = New RadioButton()
        btnKonfirmasi = New Button()
        btnBatal = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 15)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 28)
        Label1.TabIndex = 1
        Label1.Text = "Staff ID"
        ' 
        ' txtStaffID
        ' 
        txtStaffID.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStaffID.Location = New Point(196, 12)
        txtStaffID.Margin = New Padding(2)
        txtStaffID.Name = "txtStaffID"
        txtStaffID.Size = New Size(320, 34)
        txtStaffID.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 55)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 28)
        Label2.TabIndex = 3
        Label2.Text = "Staff Name"
        ' 
        ' txtStaffName
        ' 
        txtStaffName.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStaffName.Location = New Point(196, 52)
        txtStaffName.Margin = New Padding(2)
        txtStaffName.Name = "txtStaffName"
        txtStaffName.Size = New Size(320, 34)
        txtStaffName.TabIndex = 4
        ' 
        ' txtStaffPhone
        ' 
        txtStaffPhone.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtStaffPhone.Location = New Point(196, 92)
        txtStaffPhone.Margin = New Padding(2)
        txtStaffPhone.Mask = "____-____-____"
        txtStaffPhone.Name = "txtStaffPhone"
        txtStaffPhone.Size = New Size(320, 34)
        txtStaffPhone.TabIndex = 7
        ' 
        ' txtNetSalary
        ' 
        txtNetSalary.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNetSalary.Location = New Point(196, 135)
        txtNetSalary.Margin = New Padding(2)
        txtNetSalary.Name = "txtNetSalary"
        txtNetSalary.Size = New Size(320, 34)
        txtNetSalary.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 95)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 28)
        Label3.TabIndex = 12
        Label3.Text = "Staff Phone"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 139)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 28)
        Label5.TabIndex = 14
        Label5.Text = "Net Salary"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 179)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 28)
        Label6.TabIndex = 15
        Label6.Text = "Shift"
        ' 
        ' rbMorning
        ' 
        rbMorning.AutoSize = True
        rbMorning.Location = New Point(196, 179)
        rbMorning.Margin = New Padding(2)
        rbMorning.Name = "rbMorning"
        rbMorning.Size = New Size(105, 29)
        rbMorning.TabIndex = 16
        rbMorning.TabStop = True
        rbMorning.Text = "Morning"
        rbMorning.UseVisualStyleBackColor = True
        ' 
        ' rbAfternoon
        ' 
        rbAfternoon.AutoSize = True
        rbAfternoon.Location = New Point(308, 179)
        rbAfternoon.Margin = New Padding(2)
        rbAfternoon.Name = "rbAfternoon"
        rbAfternoon.Size = New Size(118, 29)
        rbAfternoon.TabIndex = 17
        rbAfternoon.TabStop = True
        rbAfternoon.Text = "Afternoon"
        rbAfternoon.UseVisualStyleBackColor = True
        ' 
        ' rbNight
        ' 
        rbNight.AutoSize = True
        rbNight.Location = New Point(435, 179)
        rbNight.Margin = New Padding(2)
        rbNight.Name = "rbNight"
        rbNight.Size = New Size(81, 29)
        rbNight.TabIndex = 18
        rbNight.TabStop = True
        rbNight.Text = "Night"
        rbNight.UseVisualStyleBackColor = True
        ' 
        ' btnKonfirmasi
        ' 
        btnKonfirmasi.BackColor = Color.LimeGreen
        btnKonfirmasi.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKonfirmasi.ForeColor = Color.White
        btnKonfirmasi.Location = New Point(362, 225)
        btnKonfirmasi.Margin = New Padding(2)
        btnKonfirmasi.Name = "btnKonfirmasi"
        btnKonfirmasi.Size = New Size(155, 34)
        btnKonfirmasi.TabIndex = 20
        btnKonfirmasi.Text = "Konfirmasi"
        btnKonfirmasi.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Red
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(196, 225)
        btnBatal.Margin = New Padding(2)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(155, 34)
        btnBatal.TabIndex = 21
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' DialogStaff
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(528, 271)
        Controls.Add(btnBatal)
        Controls.Add(btnKonfirmasi)
        Controls.Add(rbNight)
        Controls.Add(rbAfternoon)
        Controls.Add(rbMorning)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(txtNetSalary)
        Controls.Add(txtStaffPhone)
        Controls.Add(txtStaffName)
        Controls.Add(Label2)
        Controls.Add(txtStaffID)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "DialogStaff"
        Text = "DialogStaff"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents txtStaffPhone As MaskedTextBox
    Friend WithEvents txtNetSalary As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rbMorning As RadioButton
    Friend WithEvents rbAfternoon As RadioButton
    Friend WithEvents rbNight As RadioButton
    Friend WithEvents btnKonfirmasi As Button
    Friend WithEvents btnBatal As Button
End Class
