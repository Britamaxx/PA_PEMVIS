Public Class Dashboard
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Click
        Dim DialogProduct As New DialogProduct()
        DialogProduct.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim DialogProduct As New DialogProduct()
        DialogProduct.Show()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Dim DialogSupplier As New DialogSupplier()
        DialogSupplier.Show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim DialogStaff As New DialogStaff()
        DialogStaff.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        DialogSupplier.Show()
    End Sub

	Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
		Me.Close()
		FormLogin.Show()
	End Sub
End Class