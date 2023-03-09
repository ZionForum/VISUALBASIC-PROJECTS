Imports itc124_lab2021.Class2
Public Class frmaccounts
    Public Sub formRefresh()
        Try
            DSRec.Clear()
            DSRec = GetDataTable("SELECT username, usertype, status, createdby FROM tblaccounts WHERE username <> '" + loginuser +
                                 "' ORDER BY username")
            DataGridView1.DataSource = DSRec
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on frmaccounts_Load", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        formRefresh()
    End Sub

    Private Sub btndeactivate_Click(sender As Object, e As EventArgs) Handles btndeactivate.Click
        Try
            Dim dr As DialogResult
            dr = MessageBox.Show("Are you sure you want to deactivate this account?", "Message", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
            If (dr = DialogResult.Yes) Then
                executeSQL("UPDATE tblaccounts SET status = 'INACTIVE' WHERE username = '" + selectedUser + "'")
                If rowAffected > 0 Then
                    MessageBox.Show("User Deactivated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    formRefresh()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on btndeactivate_Click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnactivate_Click(sender As Object, e As EventArgs) Handles btnactivate.Click
        Try
            Dim dr As DialogResult
            dr = MessageBox.Show("Are you sure you want to activate this account?", "Message", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
            If (dr = DialogResult.Yes) Then
                executeSQL("UPDATE tblaccounts SET status = 'ACTIVE' WHERE username = '" + selectedUser + "'")
                If rowAffected > 0 Then
                    MessageBox.Show("User Activated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    formRefresh()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on btnactivate_Click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Dim dr As DialogResult
            dr = MessageBox.Show("Are you sure you want to delete this account?", "Message", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
            If (dr = DialogResult.Yes) Then
                executeSQL("DELETE FROM tblaccounts WHERE username = '" + selectedUser + "'")
                If rowAffected > 0 Then
                    MessageBox.Show("User Deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    formRefresh()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on btndelete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            DSRec.Clear()
            DSRec = GetDataTable("SELECT username, usertype, status, createdby FROM tblaccounts WHERE username <> '" + loginuser + "' AND (username LIKE '%" + txtsearch.Text + "%' OR usertype LIKE '%" + txtsearch.Text + "%') ORDER BY username")
            DataGridView1.DataSource = DSRec
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on txtsearch_TextChanged", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        frmaddaccount.Text = "Add new account"
        frmaddaccount.txtusername.Clear()
        frmaddaccount.txtpassword.Clear()
        frmaddaccount.cmbusertype.SelectedIndex = -1
        Action = "add"
        frmaddaccount.ShowDialog()
    End Sub
    Dim selectedUser, selectedType As String
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        selectedUser = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        selectedType = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        frmaddaccount.Text = "Edit account"
        frmaddaccount.txtusername.Text = selectedUser
        If selectedType = "ADMINISTRATOR" Then
            frmaddaccount.cmbusertype.SelectedIndex = 0
        ElseIf selectedType = "TECHNICAL" Then
            frmaddaccount.cmbusertype.SelectedIndex = 1
        Else
            frmaddaccount.cmbusertype.SelectedIndex = 2
        End If
        frmaddaccount.txtusername.Enabled = False
        Action = "edit"
        frmaddaccount.ShowDialog()
    End Sub
    Private Sub frmaccounts_Load(sender As Object, e As EventArgs) Handles Me.Load
        formRefresh()
    End Sub
    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.Cells(2).Value = "ACTIVE" Then
                row.DefaultCellStyle.ForeColor = Color.Black
                row.DefaultCellStyle.BackColor = Color.Orange
            ElseIf row.Cells(2).Value = "INACTIVE" Then
                row.DefaultCellStyle.ForeColor = Color.Black
                row.DefaultCellStyle.BackColor = Color.Red
            Else
                row.DefaultCellStyle.BackColor = Color.White
            End If
        Next
    End Sub
End Class