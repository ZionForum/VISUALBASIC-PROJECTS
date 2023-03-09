<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDASRadio
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbdivide = New System.Windows.Forms.RadioButton()
        Me.rbmultiply = New System.Windows.Forms.RadioButton()
        Me.rbsubtract = New System.Windows.Forms.RadioButton()
        Me.rbadd = New System.Windows.Forms.RadioButton()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter number:"
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(112, 15)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(105, 20)
        Me.txtnum1.TabIndex = 3
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(112, 40)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(105, 20)
        Me.txtnum2.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbdivide)
        Me.GroupBox1.Controls.Add(Me.rbmultiply)
        Me.GroupBox1.Controls.Add(Me.rbsubtract)
        Me.GroupBox1.Controls.Add(Me.rbadd)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(106, 110)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Operations"
        '
        'rbdivide
        '
        Me.rbdivide.AutoSize = True
        Me.rbdivide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbdivide.Location = New System.Drawing.Point(6, 88)
        Me.rbdivide.Name = "rbdivide"
        Me.rbdivide.Size = New System.Drawing.Size(55, 17)
        Me.rbdivide.TabIndex = 3
        Me.rbdivide.TabStop = True
        Me.rbdivide.Text = "Divide"
        Me.rbdivide.UseVisualStyleBackColor = True
        '
        'rbmultiply
        '
        Me.rbmultiply.AutoSize = True
        Me.rbmultiply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbmultiply.Location = New System.Drawing.Point(6, 65)
        Me.rbmultiply.Name = "rbmultiply"
        Me.rbmultiply.Size = New System.Drawing.Size(60, 17)
        Me.rbmultiply.TabIndex = 2
        Me.rbmultiply.TabStop = True
        Me.rbmultiply.Text = "Multiply"
        Me.rbmultiply.UseVisualStyleBackColor = True
        '
        'rbsubtract
        '
        Me.rbsubtract.AutoSize = True
        Me.rbsubtract.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbsubtract.Location = New System.Drawing.Point(6, 42)
        Me.rbsubtract.Name = "rbsubtract"
        Me.rbsubtract.Size = New System.Drawing.Size(65, 17)
        Me.rbsubtract.TabIndex = 1
        Me.rbsubtract.TabStop = True
        Me.rbsubtract.Text = "Subtract"
        Me.rbsubtract.UseVisualStyleBackColor = True
        '
        'rbadd
        '
        Me.rbadd.AutoSize = True
        Me.rbadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbadd.Location = New System.Drawing.Point(6, 19)
        Me.rbadd.Name = "rbadd"
        Me.rbadd.Size = New System.Drawing.Size(44, 17)
        Me.rbadd.TabIndex = 0
        Me.rbadd.TabStop = True
        Me.rbadd.Text = "Add"
        Me.rbadd.UseVisualStyleBackColor = True
        '
        'btnsubmit
        '
        Me.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubmit.Location = New System.Drawing.Point(142, 94)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit.TabIndex = 6
        Me.btnsubmit.Text = "&Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclear.Location = New System.Drawing.Point(142, 134)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 7
        Me.btnclear.Text = "&Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'MDASRadio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(240, 201)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MDASRadio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDASRadio"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbdivide As RadioButton
    Friend WithEvents rbmultiply As RadioButton
    Friend WithEvents rbsubtract As RadioButton
    Friend WithEvents rbadd As RadioButton
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsubmit As Button
End Class
