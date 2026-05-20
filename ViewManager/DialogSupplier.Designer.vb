<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogSupplier
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
        txtSupplierID = New TextBox()
        Label1 = New Label()
        txtSupplierName = New TextBox()
        txtSupplierPhone = New MaskedTextBox()
        txtSupplierAddress = New TextBox()
        btnKonfirmasi = New Button()
        btnBatal = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtSupplierID
        ' 
        txtSupplierID.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSupplierID.Location = New Point(196, 12)
        txtSupplierID.Margin = New Padding(2)
        txtSupplierID.Name = "txtSupplierID"
        txtSupplierID.Size = New Size(270, 34)
        txtSupplierID.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 15)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 28)
        Label1.TabIndex = 4
        Label1.Text = "Supplier ID"
        ' 
        ' txtSupplierName
        ' 
        txtSupplierName.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSupplierName.Location = New Point(196, 52)
        txtSupplierName.Margin = New Padding(2)
        txtSupplierName.Name = "txtSupplierName"
        txtSupplierName.Size = New Size(270, 34)
        txtSupplierName.TabIndex = 5
        ' 
        ' txtSupplierPhone
        ' 
        txtSupplierPhone.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSupplierPhone.Location = New Point(196, 92)
        txtSupplierPhone.Margin = New Padding(2)
        txtSupplierPhone.Mask = "____-____-____"
        txtSupplierPhone.Name = "txtSupplierPhone"
        txtSupplierPhone.Size = New Size(270, 34)
        txtSupplierPhone.TabIndex = 8
        ' 
        ' txtSupplierAddress
        ' 
        txtSupplierAddress.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSupplierAddress.Location = New Point(196, 135)
        txtSupplierAddress.Margin = New Padding(2)
        txtSupplierAddress.Multiline = True
        txtSupplierAddress.Name = "txtSupplierAddress"
        txtSupplierAddress.Size = New Size(270, 120)
        txtSupplierAddress.TabIndex = 10
        ' 
        ' btnKonfirmasi
        ' 
        btnKonfirmasi.BackColor = Color.LimeGreen
        btnKonfirmasi.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKonfirmasi.ForeColor = Color.White
        btnKonfirmasi.Location = New Point(338, 261)
        btnKonfirmasi.Margin = New Padding(2)
        btnKonfirmasi.Name = "btnKonfirmasi"
        btnKonfirmasi.Size = New Size(130, 34)
        btnKonfirmasi.TabIndex = 21
        btnKonfirmasi.Text = "Konfirmasi"
        btnKonfirmasi.UseVisualStyleBackColor = False
        ' 
        ' btnBatal
        ' 
        btnBatal.BackColor = Color.Red
        btnBatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBatal.ForeColor = Color.White
        btnBatal.Location = New Point(198, 261)
        btnBatal.Margin = New Padding(2)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(130, 34)
        btnBatal.TabIndex = 22
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 55)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(142, 28)
        Label2.TabIndex = 23
        Label2.Text = "Supplier Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 95)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 28)
        Label3.TabIndex = 24
        Label3.Text = "Supplier Phone"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 138)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(160, 28)
        Label5.TabIndex = 26
        Label5.Text = "Supplier Address"
        ' 
        ' DialogSupplier
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(478, 306)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnBatal)
        Controls.Add(btnKonfirmasi)
        Controls.Add(txtSupplierAddress)
        Controls.Add(txtSupplierPhone)
        Controls.Add(txtSupplierName)
        Controls.Add(Label1)
        Controls.Add(txtSupplierID)
        Margin = New Padding(2)
        Name = "DialogSupplier"
        Text = "Form8"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSupplierID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSupplierName As TextBox
    Friend WithEvents txtSupplierPhone As MaskedTextBox
    Friend WithEvents txtSupplierAddress As TextBox
    Friend WithEvents btnKonfirmasi As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
End Class
