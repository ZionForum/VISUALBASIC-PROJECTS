<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDASDropdown
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
        Me.components = New System.ComponentModel.Container()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmboperation = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnclear
        '
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclear.Location = New System.Drawing.Point(128, 115)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 14
        Me.btnclear.Text = "&Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnsubmit
        '
        Me.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubmit.Location = New System.Drawing.Point(31, 115)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit.TabIndex = 13
        Me.btnsubmit.Text = "&Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(117, 40)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(105, 20)
        Me.txtnum2.TabIndex = 11
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(117, 15)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(105, 20)
        Me.txtnum1.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Enter number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Enter number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Select Operation:"
        '
        'cmboperation
        '
        Me.cmboperation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmboperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboperation.FormattingEnabled = True
        Me.cmboperation.Items.AddRange(New Object() {"Add", "Subtract", "Multiply", "Divide"})
        Me.cmboperation.Location = New System.Drawing.Point(101, 82)
        Me.cmboperation.Name = "cmboperation"
        Me.cmboperation.Size = New System.Drawing.Size(121, 21)
        Me.cmboperation.TabIndex = 16
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'MDASDropdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 157)
        Me.Controls.Add(Me.cmboperation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MDASDropdown"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDASDropdown"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnclear As Button
    Friend WithEvents btnsubmit As Button
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmboperation As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
