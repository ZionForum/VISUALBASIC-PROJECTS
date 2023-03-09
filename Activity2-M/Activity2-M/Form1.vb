Public Class Triangle
    Dim adjacent, opposite, hypotenuse, sine, cosine, tangent As Integer
    Private errorCount, items As Integer
    Private msg As String
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAdjacent.Clear()
        txtOpposite.Clear()
        txtHypotenuse.Clear()
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        If txtAdjacent.Text = "" Then
            ErrorProvider1.SetError(txtAdjacent, "Input is required")
        Else
            ErrorProvider1.SetError(txtAdjacent, "")
        End If
        If txtOpposite.Text = "" Then
            ErrorProvider1.SetError(txtOpposite, "Input is required")
        Else
            ErrorProvider1.SetError(txtOpposite, "")
        End If
        If txtHypotenuse.Text = "" Then
            ErrorProvider1.SetError(txtHypotenuse, "Input is required")
        Else
            ErrorProvider1.SetError(txtHypotenuse, "")
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
            If chckboxSine.Checked Then
                items += 1
                sine = Integer.Parse(txtOpposite.Text) / Integer.Parse(txtHypotenuse.Text)
                msg += "Sine:" + sine.ToString + Environment.NewLine
            End If
            If chckboxCosine.Checked Then
                items += 1
                cosine = Integer.Parse(txtAdjacent.Text) / Integer.Parse(txtHypotenuse.Text)
                msg += "Cosine:" + cosine.ToString + Environment.NewLine
            End If
            If chckboxTangent.Checked Then
                items += 1
                tangent = Integer.Parse(txtOpposite.Text) / Integer.Parse(txtAdjacent.Text)
                msg += "Tangent:" + tangent.ToString + Environment.NewLine
            End If
            If items = 0 Then
                MessageBox.Show("Selection is requierd", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
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
    Private Sub txtOpposite_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOpposite.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> Keys.Back And Not e.KeyChar = "-" Then
            e.Handled = True
            ErrorProvider1.SetError(txtOpposite, "Input must be numeric")
            txtOpposite.Select()
        Else
            ErrorProvider1.SetError(txtOpposite, "")
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
