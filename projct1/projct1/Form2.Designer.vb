<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnclear
        '
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclear.Location = New System.Drawing.Point(165, 83)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 8
        Me.btnclear.Text = "&Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnsubmit
        '
        Me.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubmit.Location = New System.Drawing.Point(72, 83)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit.TabIndex = 7
        Me.btnsubmit.Text = "&Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(109, 32)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(173, 20)
        Me.txtnum.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter Number:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(308, 138)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "If Statement"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnclear As Button
    Friend WithEvents btnsubmit As Button
    Friend WithEvents txtnum As TextBox
    Friend WithEvents Label1 As Label
End Class
