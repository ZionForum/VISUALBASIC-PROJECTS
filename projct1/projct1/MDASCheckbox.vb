Public Class MDASCheckbox
    Private errorCount, items As Integer
    Private result As Double
    Private msg As String

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtnum1.Clear()
        txtnum2.Clear()
    End Sub

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
            items = 0
            msg = ""
            If chkadd.Checked Then
                items += 1
                result = Integer.Parse(txtnum1.Text) + Integer.Parse(txtnum2.Text)
                msg += "Sum:" + result.ToString + Environment.NewLine
            End If
            If chksubtract.Checked Then
                items += 1
                result = Integer.Parse(txtnum1.Text) - Integer.Parse(txtnum2.Text)
                msg += "Difference:" + result.ToString + Environment.NewLine
            End If
            If chkmultiply.Checked Then
                items += 1
                result = Integer.Parse(txtnum1.Text) * Integer.Parse(txtnum2.Text)
                msg += "Product:" + result.ToString + Environment.NewLine
            End If
            If chkdivide.Checked Then
                items += 1
                result = Integer.Parse(txtnum1.Text) / Integer.Parse(txtnum2.Text)
                msg += "Quotient:" + result.ToString + Environment.NewLine
            End If
            If items = 0 Then
                MessageBox.Show("No operation/s was selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub
End Class