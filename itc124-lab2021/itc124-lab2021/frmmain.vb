Imports itc124_lab2021.Class2
Public Class frmmain
    Private Sub frmmain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If logintype = "USER" Then
            AccountsToolStripMenuItem.Visible = False
            EquipmentsToolStripMenuItem.Visible = False
            TicketsToolStripMenuItem.Visible = True
        ElseIf logintype = "TECHNICAL" Then
            AccountsToolStripMenuItem.Visible = False
            EquipmentsToolStripMenuItem.Visible = True
            TicketsToolStripMenuItem.Visible = True
        Else
            AccountsToolStripMenuItem.Visible = True
            EquipmentsToolStripMenuItem.Visible = True
            TicketsToolStripMenuItem.Visible = True
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        Form1.txtusername.Clear()
        Form1.txtpassword.Clear()
        Form1.Show()
    End Sub
    Private Sub AccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountsToolStripMenuItem.Click
        frmaccounts.MdiParent = Me
        frmaccounts.Show()
    End Sub
    Private Sub EquipmentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquipmentsToolStripMenuItem.Click
        frmequipment.MdiParent = Me
        frmequipment.Show()
    End Sub
End Class