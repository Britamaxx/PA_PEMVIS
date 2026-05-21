Public Class DialogStaff

    Public Mode As String = "Tambah"
    Public IDTerpilih As String = ""

    Private Sub DialogStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbMorning.Checked = True
        If Mode = "Edit" Then
            TampilDataEdit()
        End If
    End Sub

    Private Sub TampilDataEdit()
        Dim dt As DataTable = GetKaryawanByID(IDTerpilih)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Data tidak ditemukan", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.Close()
            Exit Sub
        End If

        Dim row As DataRow = dt.Rows(0)
        txtStaffID.Text = row("id_karyawan").ToString()
        txtStaffID.Enabled = False
        txtStaffName.Text = row("nama_karyawan").ToString()
        txtUsername.Text = row("username").ToString()
        txtPassword.Text = row("password").ToString()
        txtStaffPhone.Text = row("telepon_karyawan").ToString()
        txtNetSalary.Text = row("gaji_bersih").ToString()

        Select Case row("shift").ToString()
            Case "Morning"
                rbMorning.Checked = True
            Case "Afternoon"
                rbAfternoon.Checked = True
            Case "Night"
                rbNight.Checked = True
            Case Else
                rbMorning.Checked = False
                rbAfternoon.Checked = False
                rbNight.Checked = False
        End Select
    End Sub

    Private Function GetShiftTerpilih() As String
        If rbMorning.Checked Then Return "Morning"
        If rbAfternoon.Checked Then Return "Afternoon"
        If rbNight.Checked Then Return "Night"
        Return ""
    End Function

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnKonfirmasi_Click(sender As Object, e As EventArgs) Handles btnKonfirmasi.Click
        If Not ValidasiStaff(txtStaffID, txtStaffName, txtStaffPhone, txtNetSalary, GetShiftTerpilih()) Then Exit Sub
        Dim id As String = txtStaffID.Text.Trim()
        Dim nama As String = txtStaffName.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim telepon As String = txtStaffPhone.Text.Trim()
        Dim gaji As Long = Convert.ToInt64(txtNetSalary.Text.Trim())
        Dim shift As String = GetShiftTerpilih()

        If Mode = "Tambah" Then
            If SimpanKaryawan(id, nama, "Kasir", username, password, telepon, gaji, shift) Then
                MessageBox.Show("Data staff berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        Else
            If UbahKaryawan(id, nama, "Kasir", username, password, telepon, gaji, shift) Then
                MessageBox.Show("Data staff berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Sub txtNetSalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNetSalary.KeyPress
        BatinHanyaDigit(e)
    End Sub

End Class