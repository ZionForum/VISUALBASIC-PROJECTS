Public Class MDASDropdown
    Private result As Double
    Private errorCount As Integer
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
        If cmboperation.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cmboperation, "Select Operation")
        Else
            ErrorProvider1.SetError(cmboperation, "")
        End If
        errorCount = 0
        For Each c As Control In ErrorProvider1.ContainerControl.Controls
            If ErrorProvider1.GetError(c) <> "" Then
                errorCount += 1
            End If
        Next
        If errorCount = 0 Then
            If cmboperation.SelectedIndex = 0 Then
                result = Integer.Parse(txtnum1.Text) + Integer.Parse(txtnum2.Text)
            ElseIf cmboperation.SelectedIndex = 1 Then
                result = Integer.Parse(txtnum1.Text) - Integer.Parse(txtnum2.Text)
            ElseIf cmboperation.SelectedIndex = 2 Then
                result = Integer.Parse(txtnum1.Text) * Integer.Parse(txtnum2.Text)
            Else
                result = Integer.Parse(txtnum1.Text) / Integer.Parse(txtnum2.Text)
            End If
            MessageBox.Show("Result:" + result.ToString, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtnum1.Clear()
        txtnum2.Clear()
    End Sub
End Class