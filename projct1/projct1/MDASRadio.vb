Public Class MDASRadio
    Private errorCount As Integer
    Private result As Double
    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        If txtnum1.Text = "" Then
            ErrorProvider1.SetError(txtnum1, "Input cannot be empty")
        ElseIf Val(txtnum1.Text) > 1000 Then
            ErrorProvider1.SetError(txtnum1, "Input should be less than 1000")
        Else
            ErrorProvider1.SetError(txtnum1, "")
        End If
        If txtnum2.Text = "" Then
            ErrorProvider1.SetError(txtnum2, "Input cannot be empty")
        ElseIf Val(txtnum2.Text) > 1000 Then
            ErrorProvider1.SetError(txtnum2, "Input should be less than 1000")
        Else
            ErrorProvider1.SetError(txtnum2, "")
        End If
        errorCount = 0
        For Each c As Control In ErrorProvider1.ContainerControl.Controls
            If ErrorProvider1.GetError(c) <> "" Then
                errorCount += 1
            End If
        Next
        If errorCount = 0 Then
            If rbadd.Checked Then
                result = Integer.Parse(txtnum1.Text) + Integer.Parse(txtnum2.Text)
            ElseIf rbsubtract.Checked Then
                result = Integer.Parse(txtnum1.Text) - Integer.Parse(txtnum2.Text)
            ElseIf rbmultiply.Checked Then
                result = Integer.Parse(txtnum1.Text) * Integer.Parse(txtnum2.Text)
            Else
                result = Integer.Parse(txtnum1.Text) / Integer.Parse(txtnum2.Text)
            End If
            MessageBox.Show("Result:" + result.ToString, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub txtnum1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnum1.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> Keys.Back Then
            e.Handled = True
            ErrorProvider1.SetError(txtnum1, "Input must be numeric")
            txtnum1.Select()
        Else
            ErrorProvider1.SetError(txtnum1, "")
        End If
    End Sub
    Private Sub txtnum2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnum2.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> Keys.Back Then
            e.Handled = True
            ErrorProvider1.SetError(txtnum2, "Input must be numeric")
            txtnum2.Select()
        Else
            ErrorProvider1.SetError(txtnum2, "")
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtnum1.Clear()
        txtnum2.Clear()
    End Sub
End Class