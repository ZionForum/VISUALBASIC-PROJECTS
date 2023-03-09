<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDASCheckbox
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkadd = New System.Windows.Forms.CheckBox()
        Me.chksubtract = New System.Windows.Forms.CheckBox()
        Me.chkmultiply = New System.Windows.Forms.CheckBox()
        Me.chkdivide = New System.Windows.Forms.CheckBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnclear
        '
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclear.Location = New System.Drawing.Point(139, 152)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 22
        Me.btnclear.Text = "&Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btnsubmit
        '
        Me.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubmit.Location = New System.Drawing.Point(56, 152)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit.TabIndex = 21
        Me.btnsubmit.Text = "&Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(125, 42)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(105, 20)
        Me.txtnum2.TabIndex = 20
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(125, 17)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(105, 20)
        Me.txtnum1.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Enter number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Enter number:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkdivide)
        Me.GroupBox1.Controls.Add(Me.chkmultiply)
        Me.GroupBox1.Controls.Add(Me.chksubtract)
        Me.GroupBox1.Controls.Add(Me.chkadd)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(184, 61)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Operations"
        '
        'chkadd
        '
        Me.chkadd.AutoSize = True
        Me.chkadd.Location = New System.Drawing.Point(3, 16)
        Me.chkadd.Name = "chkadd"
        Me.chkadd.Size = New System.Drawing.Size(45, 17)
        Me.chkadd.TabIndex = 0
        Me.chkadd.Text = "Add"
        Me.chkadd.UseVisualStyleBackColor = True
        '
        'chksubtract
        '
        Me.chksubtract.AutoSize = True
        Me.chksubtract.Location = New System.Drawing.Point(3, 38)
        Me.chksubtract.Name = "chksubtract"
        Me.chksubtract.Size = New System.Drawing.Size(66, 17)
        Me.chksubtract.TabIndex = 1
        Me.chksubtract.Text = "Subtract"
        Me.chksubtract.UseVisualStyleBackColor = True
        '
        'chkmultiply
        '
        Me.chkmultiply.AutoSize = True
        Me.chkmultiply.Location = New System.Drawing.Point(90, 16)
        Me.chkmultiply.Name = "chkmultiply"
        Me.chkmultiply.Size = New System.Drawing.Size(61, 17)
        Me.chkmultiply.TabIndex = 2
        Me.chkmultiply.Text = "Multiply"
        Me.chkmultiply.UseVisualStyleBackColor = True
        '
        'chkdivide
        '
        Me.chkdivide.AutoSize = True
        Me.chkdivide.Location = New System.Drawing.Point(90, 38)
        Me.chkdivide.Name = "chkdivide"
        Me.chkdivide.Size = New System.Drawing.Size(56, 17)
        Me.chkdivide.TabIndex = 3
        Me.chkdivide.Text = "Divide"
        Me.chkdivide.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'MDASCheckbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 181)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "MDASCheckbox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDASCheckbox"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkdivide As CheckBox
    Friend WithEvents chkmultiply As CheckBox
    Friend WithEvents chksubtract As CheckBox
    Friend WithEvents chkadd As CheckBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
