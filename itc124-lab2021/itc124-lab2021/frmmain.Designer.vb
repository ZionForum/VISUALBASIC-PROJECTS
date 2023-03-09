<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmmain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquipmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblusername = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblusertype = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Orange
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManagementToolStripMenuItem, Me.LogsToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ManagementToolStripMenuItem
        '
        Me.ManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountsToolStripMenuItem, Me.EquipmentsToolStripMenuItem, Me.TicketsToolStripMenuItem})
        Me.ManagementToolStripMenuItem.Image = CType(resources.GetObject("ManagementToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ManagementToolStripMenuItem.Name = "ManagementToolStripMenuItem"
        Me.ManagementToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.ManagementToolStripMenuItem.Text = "&Management"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.Image = Global.itc124_lab2021.My.Resources.Resources.account
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AccountsToolStripMenuItem.Text = "&Accounts"
        '
        'EquipmentsToolStripMenuItem
        '
        Me.EquipmentsToolStripMenuItem.Image = Global.itc124_lab2021.My.Resources.Resources.equipment__2_
        Me.EquipmentsToolStripMenuItem.Name = "EquipmentsToolStripMenuItem"
        Me.EquipmentsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EquipmentsToolStripMenuItem.Text = "&Equipments"
        '
        'TicketsToolStripMenuItem
        '
        Me.TicketsToolStripMenuItem.Image = Global.itc124_lab2021.My.Resources.Resources.tickets
        Me.TicketsToolStripMenuItem.Name = "TicketsToolStripMenuItem"
        Me.TicketsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TicketsToolStripMenuItem.Text = "&Tickets"
        '
        'LogsToolStripMenuItem
        '
        Me.LogsToolStripMenuItem.Name = "LogsToolStripMenuItem"
        Me.LogsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.LogsToolStripMenuItem.Text = "L&ogs"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.ChangePasswordToolStripMenuItem.Text = "&Change Password"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.LogoutToolStripMenuItem.Text = "&Logout"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Gray
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblusername, Me.lblusertype})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblusername
        '
        Me.lblusername.ForeColor = System.Drawing.SystemColors.Control
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(119, 17)
        Me.lblusername.Text = "ToolStripStatusLabel1"
        '
        'lblusertype
        '
        Me.lblusertype.ForeColor = System.Drawing.SystemColors.Control
        Me.lblusertype.Name = "lblusertype"
        Me.lblusertype.Size = New System.Drawing.Size(119, 17)
        Me.lblusertype.Text = "ToolStripStatusLabel2"
        '
        'frmmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main-Ticket Management Sytstem"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EquipmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TicketsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblusername As ToolStripStatusLabel
    Friend WithEvents lblusertype As ToolStripStatusLabel
End Class
