Public Class Form2
    Private num As Integer
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        'input
        num = Val(txtnum.Text)
        'process and output
        If num > 0 Then
            MessageBox.Show("You have inputted the positive number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtnum.Clear()
        txtnum.Select()
    End Sub
End Class