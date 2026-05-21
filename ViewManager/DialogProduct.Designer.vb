<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DialogProduct
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
        Label1 = New Label()
        txtProductID = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        txtProductName = New TextBox()
        txtCategory = New TextBox()
        txtBuyingPrice = New TextBox()
        txtSellingPrice = New TextBox()
        txtMinimumStock = New TextBox()
        btnConfirm = New Button()
        btnCancel = New Button()
        cbSupplierID = New ComboBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 15)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 28)
        Label1.TabIndex = 0
        Label1.Text = "Product ID"
        ' 
        ' txtProductID
        ' 
        txtProductID.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtProductID.Location = New Point(170, 11)
        txtProductID.Margin = New Padding(2)
        txtProductID.Name = "txtProductID"
        txtProductID.Size = New Size(270, 34)
        txtProductID.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 91)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 28)
        Label2.TabIndex = 2
        Label2.Text = "Product Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 129)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 28)
        Label3.TabIndex = 3
        Label3.Text = "Category"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 167)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(119, 28)
        Label4.TabIndex = 4
        Label4.Text = "Buying Price"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 205)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(118, 28)
        Label5.TabIndex = 5
        Label5.Text = "Selling Price"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(12, 243)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(149, 28)
        Label7.TabIndex = 7
        Label7.Text = "Minimum Stock"
        ' 
        ' txtProductName
        ' 
        txtProductName.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtProductName.Location = New Point(170, 91)
        txtProductName.Margin = New Padding(2)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(270, 34)
        txtProductName.TabIndex = 8
        ' 
        ' txtCategory
        ' 
        txtCategory.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCategory.Location = New Point(170, 129)
        txtCategory.Margin = New Padding(2)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(270, 34)
        txtCategory.TabIndex = 9
        ' 
        ' txtBuyingPrice
        ' 
        txtBuyingPrice.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtBuyingPrice.Location = New Point(170, 167)
        txtBuyingPrice.Margin = New Padding(2)
        txtBuyingPrice.Name = "txtBuyingPrice"
        txtBuyingPrice.Size = New Size(270, 34)
        txtBuyingPrice.TabIndex = 10
        ' 
        ' txtSellingPrice
        ' 
        txtSellingPrice.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSellingPrice.Location = New Point(170, 205)
        txtSellingPrice.Margin = New Padding(2)
        txtSellingPrice.Name = "txtSellingPrice"
        txtSellingPrice.Size = New Size(270, 34)
        txtSellingPrice.TabIndex = 11
        ' 
        ' txtMinimumStock
        ' 
        txtMinimumStock.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtMinimumStock.Location = New Point(170, 243)
        txtMinimumStock.Margin = New Padding(2)
        txtMinimumStock.Name = "txtMinimumStock"
        txtMinimumStock.Size = New Size(270, 34)
        txtMinimumStock.TabIndex = 13
        ' 
        ' btnConfirm
        ' 
        btnConfirm.BackColor = Color.LimeGreen
        btnConfirm.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnConfirm.ForeColor = Color.White
        btnConfirm.Location = New Point(310, 281)
        btnConfirm.Margin = New Padding(2)
        btnConfirm.Name = "btnConfirm"
        btnConfirm.Size = New Size(130, 34)
        btnConfirm.TabIndex = 14
        btnConfirm.Text = "Confirm"
        btnConfirm.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Red
        btnCancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(170, 281)
        btnCancel.Margin = New Padding(2)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(130, 34)
        btnCancel.TabIndex = 15
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' cbSupplierID
        ' 
        cbSupplierID.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbSupplierID.FormattingEnabled = True
        cbSupplierID.Location = New Point(170, 50)
        cbSupplierID.Name = "cbSupplierID"
        cbSupplierID.Size = New Size(270, 36)
        cbSupplierID.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 50)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(109, 28)
        Label6.TabIndex = 17
        Label6.Text = "Supplier ID"
        ' 
        ' DialogProduct
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(478, 324)
        Controls.Add(Label6)
        Controls.Add(cbSupplierID)
        Controls.Add(btnCancel)
        Controls.Add(btnConfirm)
        Controls.Add(txtMinimumStock)
        Controls.Add(txtSellingPrice)
        Controls.Add(txtBuyingPrice)
        Controls.Add(txtCategory)
        Controls.Add(txtProductName)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtProductID)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "DialogProduct"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtBuyingPrice As TextBox
    Friend WithEvents txtSellingPrice As TextBox
    Friend WithEvents txtMinimumStock As TextBox
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents cbSupplierID As ComboBox
    Friend WithEvents Label6 As Label
End Class
