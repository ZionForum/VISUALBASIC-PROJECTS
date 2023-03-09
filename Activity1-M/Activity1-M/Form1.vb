Public Class Form1
    Dim opposite, adjacent, hypotenuse, sine, cosine, tangent As Integer
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOpposite.Clear()
        txtAdjacent.Clear()
        txtHypotenuse.Clear()
        txtSine.Clear()
        txtCosine.Clear()
        txtTangent.Clear()
    End Sub
    Private Sub validateForm()
        If txtOpposite.Text = "" Then
            ErrorProvider1.SetError(txtOpposite, "Input cannot be empty")
        ElseIf Val(txtOpposite.Text) < 1 Or Val(txtOpposite.Text) > 100 Then
            ErrorProvider1.SetError(txtOpposite, "Input should be 1-100 only")
        Else
            ErrorProvider1.SetError(txtOpposite, "")
        End If
        If txtAdjacent.Text = "" Then
            ErrorProvider1.SetError(txtAdjacent, "Input cannot be empty")
        ElseIf Val(txtAdjacent.Text) < 1 Or Val(txtAdjacent.Text) > 100 Then
            ErrorProvider1.SetError(txtAdjacent, "Input should be 1-100 only")
        Else
            ErrorProvider1.SetError(txtAdjacent, "")
        End If
        If txtHypotenuse.Text = "" Then
            ErrorProvider1.SetError(txtHypotenuse, "Input cannot be empty")
        ElseIf Val(txtHypotenuse.Text) < 1 Or Val(txtHypotenuse.Text) > 100 Then
            ErrorProvider1.SetError(txtHypotenuse, "Input should be 1-100 only")
        Else
            ErrorProvider1.SetError(txtHypotenuse, "")
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
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        validateForm()
        countErrors()
        'process
        If errorCount = 0 Then
            sine = Val(txtOpposite.Text) / Val(txtHypotenuse.Text)
            txtSine.Text = sine.ToString()
            cosine = Val(txtAdjacent.Text) / Val(txtHypotenuse.Text)
            txtCosine.Text = cosine.ToString()
            tangent = Val(txtOpposite.Text) / Val(txtAdjacent.Text)
            txtTangent.Text = tangent.ToString()
        End If
        'input
        opposite = Val(txtOpposite.Text)
        adjacent = Val(txtAdjacent.Text)
        hypotenuse = Val(txtHypotenuse.Text)
        'output
        txtSine.Text = sine.ToString()
        txtCosine.Text = cosine.ToString()
        txtTangent.Text = tangent.ToString()
    End Sub

    Private Sub txtOpposite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOpposite.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> Keys.Back And Not e.KeyChar = "-" Then
            e.Handled = True
            ErrorProvider1.SetError(txtOpposite, "Input must be numeric")
            txtOpposite.Select()
        Else
            ErrorProvider1.SetError(txtOpposite, "")
        End If
    End Sub
    Private Sub txtAdjacent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAdjacent.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> Keys.Back And Not e.KeyChar = "-" Then
            e.Handled = True
            ErrorProvider1.SetError(txtAdjacent, "Input must be numeric")
            txtAdjacent.Select()
        Else
            ErrorProvider1.SetError(txtAdjacent, "")
        End If
    End Sub
    Private Sub txtHypotenuse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHypotenuse.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> Keys.Back And Not e.KeyChar = "-" Then
            e.Handled = True
            ErrorProvider1.SetError(txtHypotenuse, "Input must be numeric")
            txtHypotenuse.Select()
        Else
            ErrorProvider1.SetError(txtHypotenuse, "")
        End If
    End Sub
End Class
