Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.Username AndAlso TextBox2.Text = My.Settings.Password Then
            MsgBox("Successfuly Loged In")
            Me.Hide()
            Form3.Show()
        Else
            MsgBox("Username or Password is Invalid")

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form2.Show()
    End Sub
End Class
