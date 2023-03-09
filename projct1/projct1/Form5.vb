Public Class Form5
    Private num As Integer
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        num = Val(txtnum.Text)
        Select Case num
            Case 1
                MessageBox.Show("Equivalent day is Monday", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 2
                MessageBox.Show("Equivalent day is Tuesday", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 3
                MessageBox.Show("Equivalent day is Wednesday", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 4
                MessageBox.Show("Equivalent day is Thursday", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 5
                MessageBox.Show("Equivalent day is Friday", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 6
                MessageBox.Show("Equivalent day is Saturday", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case 7
                MessageBox.Show("Equivalent day is Sunday", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Case Else
                MessageBox.Show("Input must be from 1 to 7 only", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtnum.Select()
        End Select
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtnum.Clear()
        txtnum.Select()
    End Sub
End Class