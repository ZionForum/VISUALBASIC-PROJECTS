Public Class Form6
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtnum.Clear()
        txtnum.Select()
    End Sub
    Private num As Integer
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        num = Val(txtnum.Text)
        If num >= 1 And num <= 5 Then
            MessageBox.Show("Input falls on weekday", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf num = 6 Or num = 7 Then
            MessageBox.Show("Input falls on weekend", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Input must be from 1 to 7 only", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtnum.Select()
        End If
    End Sub

    Private Sub txtnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnum.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> Keys.Back And Not e.KeyChar = "-" Then
            e.Handled = True
            ErrorProvider1.SetError(txtnum, "Input must be numeric")
            txtnum.Select()
        Else
            ErrorProvider1.SetError(txtnum, "")
        End If
    End Sub
End Class