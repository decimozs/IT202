Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles userId.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If userId.Text = "neil" And password.Text = "delarama" Then
            Form2.Show()
        End If
    End Sub

    Private Sub password_TextChanged(sender As Object, e As EventArgs) Handles password.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles userId.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
