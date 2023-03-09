Public Class Form1
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtnum1.Clear()
        txtnum2.Clear()
        txtnum1.Select()
        txtnum2.Select()
    End Sub
    Private num1, num2 As Integer
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        'input
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)
        'process and output
        If num1 > num2 Then
            MessageBox.Show("First number is larger than the Second number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf num2 > num1 Then
            MessageBox.Show("Second number is larger than the First number", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Both Inputted Numbers are equal", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        txtnum1.Select()
        txtnum2.Select()
    End Sub
End Class
