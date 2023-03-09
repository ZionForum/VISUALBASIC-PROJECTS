Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'To Delete the inputted value and outputs
        txtNoOfSeats.Clear()
        txtTrip.Clear()
        txtClassification.Clear()
        txtSeatFare.Clear()
        txtGrossFare.Clear()
        txtTax.Clear()
        txtTotal.Clear()
    End Sub
    'Declaration of data types into variables using string and integer
    Private errorCount As Integer
    Private selClass, trip As String
    Dim sFare, gFare, tax, total As Integer
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'Showing the dialog error provider when there is no input and unacceptable input
        'Radio button using tabstop to stop showing in textbox while clicking the radio buttons
        'Inputs
        If rbOneWay.TabStop And rbTwoWay.TabStop Then
            ErrorProvider1.SetError(rbOneWay, "Choose your way")
            ErrorProvider1.SetError(rbTwoWay, "Choose your way")
            ErrorProvider1.SetError(txtTrip, "Selection in trip option is vital")
        Else
            ErrorProvider1.SetError(rbOneWay, "")
            ErrorProvider1.SetError(rbTwoWay, "")
            ErrorProvider1.SetError(txtTrip, "")
        End If
        'Combo box to appear the error dialog when there is no selection and to show the selected code
        If cmbClassCode.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cmbClassCode, "Select your class code")
        Else
            ErrorProvider1.SetError(cmbClassCode, "")
        End If
        'Textbox for No. of seats showing when there is no inputted value/s and to show the error dialog if there is no inputted value/s
        If txtNoOfSeats.Text = "" Then
            ErrorProvider1.SetError(txtNoOfSeats, "No. of seats cannot be empty!")
        ElseIf Val(txtNoOfSeats.Text) < 1 Or Val(txtNoOfSeats.Text) > 500 Then
            ErrorProvider1.SetError(txtNoOfSeats, "Input should be 1 to 500 only")
        Else
            ErrorProvider1.SetError(txtNoOfSeats, "")
        End If
        errorCount = 0
        For Each c As Control In ErrorProvider1.ContainerControl.Controls
            If ErrorProvider1.GetError(c) <> "" Then
                errorCount += 1
            End If
        Next
        If errorCount = 0 Then
            'Connecting the radio button to the textbox "kind of trip" to print
            If rbOneWay.TabStop Then
                trip = "One Way Trip"

            Else
                trip = "Two Way Trip"
            End If
            'Process and Outputs
            If cmbClassCode.SelectedIndex = 0 Then
                selClass = "Special"
                sFare = 5000
                gFare = 5000 * Integer.Parse(txtNoOfSeats.Text)
            ElseIf cmbClassCode.SelectedIndex = 1 Then
                selClass = "Economy"
                sFare = 7000
                gFare = 7000 * Integer.Parse(txtNoOfSeats.Text)
            ElseIf cmbClassCode.SelectedIndex = 2 Then
                selClass = "First Class"
                sFare = 9000
                gFare = 9000 * Integer.Parse(txtNoOfSeats.Text)
            Else
                selClass = "Executive"
                sFare = 15000
                gFare = 15000 * Integer.Parse(txtNoOfSeats.Text)
            End If
            tax = gFare * 0.12
            total = gFare + tax
            txtTrip.Text = trip.ToString()
            txtClassification.Text = selClass.ToString()
            txtSeatFare.Text = sFare.ToString()
            txtGrossFare.Text = gFare.ToString()
            txtTax.Text = tax.ToString()
            txtTotal.Text = total.ToString()
        End If
    End Sub
    'Handling the required inputs
    Private Sub txtNoOfSeats_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNoOfSeats.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> Keys.Back And Not e.KeyChar = "-" Then
            e.Handled = True
            ErrorProvider1.SetError(txtNoOfSeats, "Input must be numeric")
            txtNoOfSeats.Select()
        Else
            ErrorProvider1.SetError(txtNoOfSeats, "")
        End If
    End Sub
End Class
