Imports itc124_lab2021.Class2
Public Class addEquipments
    Public Sub validateForm()
        ErrorProvider1.Clear()
        If txtasset.Text = "" Then
            ErrorProvider1.SetError(txtasset, "Asset number is required!")
        End If
        If txtserial.Text = "" Then
            ErrorProvider1.SetError(txtserial, "Serial number is required!")
        End If
        If txtmanufacturer.Text = "" Then
            ErrorProvider1.SetError(txtmanufacturer, "Manufacturer of equipment is required!")
        End If
        If txtyrmodel.Text = "" Then
            ErrorProvider1.SetError(txtyrmodel, "Year Model of equipment is required!")
        ElseIf Val(txtyrmodel.Text) > 9999 Then
            ErrorProvider1.SetError(txtyrmodel, "Year should contain 4 characters only!")
        Else
            ErrorProvider1.SetError(txtyrmodel, "")
        End If
        If cmbbranch.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cmbbranch, "Branch is required!")
        End If
        If cmbdept.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cmbdept, "Department is required!")
        End If
        If cmbtype.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cmbtype, "Type of equipment is required!")
        End If
        If action = "add" Then
            Try
                DSRec.Clear()
                DSRec = GetDataTable("SELECT * FROM tbleequipments WHERE Asset = '" + txtasset.Text + "'")
                If DSRec.Rows.Count > 0 Then
                    ErrorProvider1.SetError(txtasset, "Asset number is already in use!")
                    ErrorProvider1.SetError(txtserial, "Serial number is already in use!")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error on validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Public errorCount As Integer
    Public Sub countErrors()
        errorCount = 0
        For Each obj As Control In ErrorProvider1.ContainerControl.Controls
            If ErrorProvider1.GetError(obj) <> "" Then
                errorCount += 1
            End If
        Next
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        validateForm()
        countErrors()
        If errorCount = 0 Then
            If action = "add" Then
                Try
                    executeSQL("INSERT INTO tbleequipments (Asset, Serial, Type, Branch, Status, Manufacturer, Model, Department, Description) VALUES ('" + txtasset.Text +
                               "','" + txtserial.Text + "','" + cmbtype.Text + "','" + cmbbranch.Text + "','WORKING','" + txtmanufacturer.Text +
                               "','" + txtyrmodel.Text + "','" + cmbdept.Text + "','" + txtdescription.Text + "')")
                    If rowAffected > 0 Then
                        MessageBox.Show("New EQUIPMENT Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                        frmequipment.formRefresh()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error on btnsave_Click(add)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                Try
                    executeSQL("UPDATE tbleequipments SET Serial = '" + txtserial.Text + "', Type = '" + cmbtype.Text + "', Branch = '" + cmbbranch.Text + "', Status = '" + cmbstatus.Text +
                                "', Manufacturer = '" + txtmanufacturer.Text + "', Model = '" + txtyrmodel.Text + "', Department = '" + cmbdept.Text + "', Description = '" + txtdescription.Text +
                                "' WHERE Asset = '" + txtasset.Text + "'")
                    If rowAffected > 0 Then
                        MessageBox.Show("Equipment updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                        frmequipment.formRefresh()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error on btnsave_Click(edit)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        Me.Close()
        frmequipment.formRefresh()
    End Sub

    Private Sub txtyrmodel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtyrmodel.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Convert.ToInt32(e.KeyChar) <> Keys.Back Then
            e.Handled = True
            ErrorProvider1.SetError(txtyrmodel, "Input should be numeric!")
            txtyrmodel.Select()
        Else
            ErrorProvider1.SetError(txtyrmodel, "")
        End If
    End Sub
End Class