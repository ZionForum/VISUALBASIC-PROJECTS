Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtopposite.Clear()
        txtadjacent.Clear()
        txthypotenuse.Clear()
    End Sub
    Dim opposite, adjacent, hypotenuse, sine, cosine, tangent As Integer

    Private Sub txthypotenuse_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txthypotenuse.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> Keys.Back And Not e.KeyChar = "-" Then
            e.Handled = True
            ErrorProvider1.SetError(txthypotenuse, "Input must be numeric")
            txthypotenuse.Select()
        Else
            ErrorProvider1.SetError(txthypotenuse, "")
        End If
    End Sub

    Private Sub txtadjacent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtadjacent.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> Keys.Back And Not e.KeyChar = "-" Then
            e.Handled = True
            ErrorProvider1.SetError(txtadjacent, "Input must be numeric")
            txtadjacent.Select()
        Else
            ErrorProvider1.SetError(txtadjacent, "")
        End If
    End Sub

    Private Sub txtopposite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtopposite.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> Keys.Back And Not e.KeyChar = "-" Then
            e.Handled = True
            ErrorProvider1.SetError(txtopposite, "Input must be numeric")
            txtopposite.Select()
        Else
            ErrorProvider1.SetError(txtopposite, "")
        End If
    End Sub

    Private Sub btnSine_Click(sender As Object, e As EventArgs) Handles btnSine.Click
        opposite = Val(txtopposite.Text)
        hypotenuse = Val(txthypotenuse.Text)
        If opposite And hypotenuse Then
            sine = opposite / hypotenuse
            MessageBox.Show("Sine = ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf opposite Then
            MessageBox.Show("Hypotemuse must be Included!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf hypotenuse Then
            MessageBox.Show("Opposite must be Included!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Opposite and Hypotemuse must be Included!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCosine_Click(sender As Object, e As EventArgs) Handles btnCosine.Click
        adjacent = Val(txtadjacent.Text)
        hypotenuse = Val(txthypotenuse.Text)
        If adjacent And hypotenuse Then
            cosine = adjacent / hypotenuse
            MessageBox.Show("Cosine = ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf adjacent Then
            MessageBox.Show("Hypotemuse must be Included!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf hypotenuse Then
            MessageBox.Show("Adjacent must be Included!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Adjacent and Hypotemuse must be Included!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnTangent_Click(sender As Object, e As EventArgs) Handles btnTangent.Click
        opposite = Val(txtopposite.Text)
        adjacent = Val(txtadjacent.Text)
        If opposite And adjacent Then
            tangent = opposite / adjacent
            MessageBox.Show("Tangent = ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf opposite Then
            MessageBox.Show("Adjacent must be Included!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf adjacent Then
            MessageBox.Show("Opposite must be Included!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Opposite and Adjacent must be Included!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
