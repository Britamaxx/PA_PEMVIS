Imports MySqlConnector

Public Class FormLogin

    Private isPasswordVisible As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picShowPass.Visible = False
        picHidePass.Visible = True

        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If Not ValidasiLogin(txtUsername, txtPassword) Then Return

        Dim dt As DataTable = LoginKaryawan(txtUsername.Text.Trim(), txtPassword.Text.Trim())

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Dim jabatan As String = dt.Rows(0)("jabatan").ToString()
            Dim namaKaryawan As String = dt.Rows(0)("nama_Karyawan").ToString()
            Dim idKaryawan As String = dt.Rows(0)("id_Karyawan").ToString()

            SessionInfo.NamaKaryawan = namaKaryawan
            SessionInfo.Jabatan = jabatan
            SessionInfo.IDKaryawan = idKaryawan

            If jabatan.ToLower() = "manager" Then
                Dim dashboard As New Dashboard()
                dashboard.Show()
            Else
                Dim transaction As New Transaction()
                transaction.Show()
            End If

            Me.Hide()
        Else
            MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub
    Private Sub picHidePass_Click(sender As Object, e As EventArgs) Handles picHidePass.Click
        txtPassword.PasswordChar = Chr(0)
        picHidePass.Visible = False
        picShowPass.Visible = True
        isPasswordVisible = True
    End Sub

    Private Sub picShowPass_Click(sender As Object, e As EventArgs) Handles picShowPass.Click
        txtPassword.PasswordChar = "•"c
        picShowPass.Visible = False
        picHidePass.Visible = True
        isPasswordVisible = False
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub
End Class