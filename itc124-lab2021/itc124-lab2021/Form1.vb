Imports itc124_lab2021.Class2
Public Class Form1
    Private Sub chkpassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkpassword.CheckedChanged
        If chkpassword.Checked Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "*"
        End If
    End Sub
    Private Sub txtpassword_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
        chkpassword_CheckedChanged(sender, e)
    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Try
            DSRec.Clear()
            DSRec = GetDataTable("SELECT * FROM tblaccounts WHERE username = '" + txtusername.Text + "'AND password = '" + txtpassword.Text + "'AND status = 'ACTIVE'")
            If DSRec.Rows.Count > 0 Then
                frmmain.lblusername.Text = "Username:" + txtusername.Text
                frmmain.lblusertype.Text = "Usertype:" + DSRec.Rows(0).Item("usertype").ToString()
                loginuser = txtusername.Text
                logintype = DSRec.Rows(0).Item("usertype").ToString()
                frmmain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Incorrect username or password or account is inactive", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on btnlogin_Click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtusername.Clear()
        txtpassword.Clear()
    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnlogin_Click(sender, e)
        End If
    End Sub
End Class
