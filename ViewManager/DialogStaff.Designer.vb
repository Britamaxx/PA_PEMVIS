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
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        MaskedTextBox1 = New MaskedTextBox()
        ComboBox1 = New ComboBox()
        TextBox3 = New TextBox()
        TextBox5 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        Label7 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(75, 28)
        Label1.TabIndex = 1
        Label1.Text = "Staff ID"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(196, 12)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(320, 34)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(12, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 28)
        Label2.TabIndex = 3
        Label2.Text = "Staff Name"
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(196, 52)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(320, 34)
        TextBox2.TabIndex = 4
        ' 
        ' MaskedTextBox1
        ' 
        MaskedTextBox1.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MaskedTextBox1.Location = New Point(196, 92)
        MaskedTextBox1.Mask = "____-____-____"
        MaskedTextBox1.Name = "MaskedTextBox1"
        MaskedTextBox1.Size = New Size(320, 34)
        MaskedTextBox1.TabIndex = 7
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(196, 132)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(320, 36)
        ComboBox1.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(196, 174)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(320, 34)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(196, 254)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(320, 34)
        TextBox5.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(111, 28)
        Label3.TabIndex = 12
        Label3.Text = "Staff Phone"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(12, 135)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 28)
        Label4.TabIndex = 13
        Label4.Text = "Position"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 177)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 28)
        Label5.TabIndex = 14
        Label5.Text = "Net Salary"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 217)
        Label6.Name = "Label6"
        Label6.Size = New Size(52, 28)
        Label6.TabIndex = 15
        Label6.Text = "Shift"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(196, 218)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(105, 29)
        RadioButton1.TabIndex = 16
        RadioButton1.TabStop = True
        RadioButton1.Text = "Morning"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(307, 218)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(118, 29)
        RadioButton2.TabIndex = 17
        RadioButton2.TabStop = True
        RadioButton2.Text = "Afternoon"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(435, 218)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(81, 29)
        RadioButton3.TabIndex = 18
        RadioButton3.TabStop = True
        RadioButton3.Text = "Night"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(12, 257)
        Label7.Name = "Label7"
        Label7.Size = New Size(65, 28)
        Label7.TabIndex = 19
        Label7.Text = "Bonus"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LimeGreen
        Button1.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.White
        Button1.Location = New Point(361, 294)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 34)
        Button1.TabIndex = 20
        Button1.Text = "Konfirmasi"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.White
        Button2.Location = New Point(196, 294)
        Button2.Name = "Button2"
        Button2.Size = New Size(155, 34)
        Button2.TabIndex = 21
        Button2.Text = "Batal"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' DialogStaff
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(528, 344)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextBox5)
        Controls.Add(TextBox3)
        Controls.Add(ComboBox1)
        Controls.Add(MaskedTextBox1)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "DialogStaff"
        Text = "DialogStaff"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
