Imports itc124_lab2021.Class2
Public Class frmequipment
    Dim data1, data2 As String
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        data1 = DataGridView2.Rows(e.RowIndex).Cells(0).Value.ToString
        data2 = DataGridView2.Rows(e.RowIndex).Cells(1).Value.ToString
    End Sub
    Public Sub formRefresh()
        Try
            DSRec.Clear()
            DSRec = GetDataTable("SELECT Asset, Serial, Type, Branch, Status FROM tbleequipments WHERE Asset <> '" + loginuser +
                                 "' ORDER BY Asset")
            DataGridView2.DataSource = DSRec
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on frmaccounts_Load", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmequipment_Load(sender As Object, e As EventArgs) Handles Me.Load
        formRefresh()
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        Try
            DSRec.Clear()
            DSRec = GetDataTable("SELECT Asset, Serial, Type, Branch, Status FROM tbleequipments WHERE Asset <> '" + loginuser +
                                     "' AND (Asset LIKE '%" + txtsearch.Text + "%' OR Serial LIKE '%" + txtsearch.Text +
                                     "%' OR Type LIKE '%" + txtsearch.Text + "%' OR Branch LIKE '%" + txtsearch.Text + "%') ORDER BY Asset")
            DataGridView2.DataSource = DSRec
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on txtsearch_TextChanged", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        addEquipments.Text = "Add equipment"
        addEquipments.txtasset.Clear()
        addEquipments.txtserial.Clear()
        addEquipments.cmbbranch.SelectedIndex = -1
        action = "add"
        addEquipments.ShowDialog()
    End Sub
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        addEquipments.Text = "Edit account"
        addEquipments.txtasset.Text = data1
        If data2 = "WORKING" Then
            addEquipments.cmbstatus.SelectedIndex = 0
        ElseIf data2 = "ON-REPAIR" Then
            addEquipments.cmbstatus.SelectedIndex = 1
        Else
            addEquipments.cmbstatus.SelectedIndex = 2
        End If
        addEquipments.txtasset.Enabled = False
        action = "edit"
        addEquipments.ShowDialog()
    End Sub



    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        Try
            Dim dr As DialogResult
            dr = MessageBox.Show("Are you sure you want to delete this equipment?", "Message", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
            If (dr = DialogResult.Yes) Then
                executeSQL("DELETE FROM tbleequipments WHERE Asset = '" + data1 + "'")
                If rowAffected > 0 Then
                    MessageBox.Show("Deleted Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    formRefresh()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on btndelete_Click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnworking_Click(sender As Object, e As EventArgs) Handles btnworking.Click
        Try
            Dim wk As DialogResult
            wk = MessageBox.Show("Are you sure you want to SET this to WORKING?", "Message", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
            If (wk = DialogResult.Yes) Then
                executeSQL("UPDATE tbleequipments SET status = 'WORKING' WHERE Asset = '" + data1 + "'")
                If rowAffected > 0 Then
                    MessageBox.Show("Status Changed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    formRefresh()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on btnactivate_Click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnrepair_Click(sender As Object, e As EventArgs) Handles btnrepair.Click
        Try
            Dim orpr As DialogResult
            orpr = MessageBox.Show("Are you sure you want to SET this to ON-REPAIR?", "Message", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
            If (orpr = DialogResult.Yes) Then
                executeSQL("UPDATE tbleequipments SET status = 'ON-REPAIR' WHERE Asset = '" + data1 + "'")
                If rowAffected > 0 Then
                    MessageBox.Show("Status Changed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    formRefresh()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on btnactivate_Click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnretire_Click(sender As Object, e As EventArgs) Handles btnretire.Click
        Try
            Dim rtr As DialogResult
            rtr = MessageBox.Show("Are you sure you want to SET this to ON-REPAIR?", "Message", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)
            If (rtr = DialogResult.Yes) Then
                executeSQL("UPDATE tbleequipments SET status = 'RETIRE' WHERE Asset = '" + data1 + "'")
                If rowAffected > 0 Then
                    MessageBox.Show("Status Changed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    formRefresh()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error on btnactivate_Click", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        formRefresh()
    End Sub

    Private Sub DataGridView2_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView2.CellFormatting
        For Each row As DataGridViewRow In DataGridView2.Rows
            If row.Cells(4).Value = "WORKING" Then
                row.DefaultCellStyle.ForeColor = Color.Black
                row.DefaultCellStyle.BackColor = Color.Orange
            ElseIf row.Cells(4).Value = "ON-REPAIR" Then
                row.DefaultCellStyle.ForeColor = Color.Black
                row.DefaultCellStyle.BackColor = Color.Red
            ElseIf row.Cells(4).Value = "RETIRE" Then
                row.DefaultCellStyle.ForeColor = Color.Black
                row.DefaultCellStyle.BackColor = Color.Gray
            Else
                row.DefaultCellStyle.BackColor = Color.White
            End If
        Next
    End Sub
End Class