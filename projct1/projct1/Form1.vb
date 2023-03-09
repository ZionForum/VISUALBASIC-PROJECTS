Public Class Form1
    Private Sub validateForm()
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
    End Sub
    Private errorCount As Integer
    Private Sub countErrors()
        errorCount = 0
        For Each c As Control In ErrorProvider1.ContainerControl.Controls
            If ErrorProvider1.GetError(c) <> "" Then
                errorCount += 1
            End If
        Next
    End Sub
    Dim num1, num2, result As Integer
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        validateForm()
        countErrors()
        If errorCount = 0 Then
            result = Val(txtnum1.Text) + Val(txtnum2.Text)
            txtresult.Text = result.ToString()
        End If
        'input
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)
        'process
        result = num1 + num2
        'output
        txtresult.Text = result.ToString()
    End Sub

    Private Sub btnsubtract_Click(sender As Object, e As EventArgs) Handles btnsubtract.Click
        validateForm()
        countErrors()
        If errorCount = 0 Then
            result = Val(txtnum1.Text) - Val(txtnum2.Text)
            txtresult.Text = result.ToString()
        End If
        'input
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)
        'process
        result = num1 - num2
        'output
        txtresult.Text = result.ToString()
    End Sub

    Private Sub btnmultiply_Click(sender As Object, e As EventArgs) Handles btnmultiply.Click
        validateForm()
        countErrors()
        If errorCount = 0 Then
            result = Val(txtnum1.Text) * Val(txtnum2.Text)
            txtresult.Text = result.ToString()
        End If
        'input
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)
        'process
        result = num1 * num2
        'output
        txtresult.Text = result.ToString()
    End Sub

    Private Sub btndivide_Click(sender As Object, e As EventArgs) Handles btndivide.Click
        validateForm()
        countErrors()
        If errorCount = 0 Then
            result = Val(txtnum1.Text) / Val(txtnum2.Text)
            txtresult.Text = result.ToString()
        End If
        'input
        num1 = Val(txtnum1.Text)
        num2 = Val(txtnum2.Text)
        'process
        result = num1 / num2
        'output
        txtresult.Text = result.ToString()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtnum1.Clear()
        txtnum2.Clear()
        txtresult.Clear()
    End Sub
End Class
