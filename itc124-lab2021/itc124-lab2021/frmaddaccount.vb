Imports itc124_lab2021.Class2
Public Class frmaddaccount
    Public Sub formRefresh()
        Try
            DSRec.Clear()
            frmaccounts.DataGridView1.DataSource = vbNull
            DSRec = GetDataTable("SELECT username, usertype, status, createdby FROM tblaccounts WHERE username <> '" + loginuser +
                                 "' ORDER BY username")
            frmaccounts.DataGridView1.DataSource = DSRec
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on frmaccounts refresh", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub validateForm()
        ErrorProvider1.Clear()
        If txtusername.Text = "" Then
            ErrorProvider1.SetError(txtusername, "Username is required")
        End If
        If txtpassword.TextLength < 6 Then
            ErrorProvider1.SetError(txtpassword, "Password should be 6 characters or more")
        End If
        If cmbusertype.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cmbusertype, "Usertype is required")
        End If
        If Action = "add" Then
            Try
                DSRec.Clear()
                DSRec = GetDataTable("SELECT * FROM tblaccounts WHERE username = '" + txtusername.Text + "'")
                If DSRec.Rows.Count > 0 Then
                    ErrorProvider1.SetError(txtusername, "Username is already in use")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error on validation", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Public errorCount As Integer
    Public Sub countErrors()
        errorCount = 0 'count the errors on the form
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
            If Action = "add" Then
                Try
                    executeSQL("INSERT INTO tblaccounts (username, password, usertype, status, createdby) VALUES ('" + txtusername.Text + "','" + txtpassword.Text + "','" + cmbusertype.Text + "','ACTIVE','" + loginuser + "')")
                    If rowAffected > 0 Then
                        MessageBox.Show("New Account Added!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                        frmaccounts.formRefresh()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error on btnsave_Click(add)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                Try
                    executeSQL("UPDATE tblaccounts SET password = '" + txtpassword.Text + "', usertype = '" + cmbusertype.Text + "' WHERE username = '" + txtusername.Text + "'")
                    If rowAffected > 0 Then
                        MessageBox.Show("Account Updated!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                        frmaccounts.formRefresh()
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error on btnsave_Click(edit)", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub
End Class