<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnclear = New System.Windows.Forms.Button()
        Me.txtresult = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.btndivide = New System.Windows.Forms.Button()
        Me.btnmultiply = New System.Windows.Forms.Button()
        Me.btnsubtract = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnclear
        '
        Me.btnclear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnclear.Location = New System.Drawing.Point(240, 134)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(75, 23)
        Me.btnclear.TabIndex = 22
        Me.btnclear.Text = "&Clear"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'txtresult
        '
        Me.txtresult.Enabled = False
        Me.txtresult.Location = New System.Drawing.Point(93, 138)
        Me.txtresult.Name = "txtresult"
        Me.txtresult.Size = New System.Drawing.Size(100, 20)
        Me.txtresult.TabIndex = 21
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(93, 46)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.txtnum2.TabIndex = 20
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(93, 8)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 19
        '
        'btndivide
        '
        Me.btndivide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndivide.Location = New System.Drawing.Point(240, 106)
        Me.btndivide.Name = "btndivide"
        Me.btndivide.Size = New System.Drawing.Size(75, 23)
        Me.btndivide.TabIndex = 18
        Me.btndivide.Text = "&Divide"
        Me.btndivide.UseVisualStyleBackColor = True
        '
        'btnmultiply
        '
        Me.btnmultiply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmultiply.Location = New System.Drawing.Point(240, 77)
        Me.btnmultiply.Name = "btnmultiply"
        Me.btnmultiply.Size = New System.Drawing.Size(75, 23)
        Me.btnmultiply.TabIndex = 17
        Me.btnmultiply.Text = "&Multiply"
        Me.btnmultiply.UseVisualStyleBackColor = True
        '
        'btnsubtract
        '
        Me.btnsubtract.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsubtract.Location = New System.Drawing.Point(240, 48)
        Me.btnsubtract.Name = "btnsubtract"
        Me.btnsubtract.Size = New System.Drawing.Size(75, 23)
        Me.btnsubtract.TabIndex = 16
        Me.btnsubtract.Text = "&Subtract"
        Me.btnsubtract.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.Location = New System.Drawing.Point(240, 19)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 15
        Me.btnadd.Text = "&Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Result:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Enter Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Enter Number:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 166)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.txtresult)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Controls.Add(Me.btndivide)
        Me.Controls.Add(Me.btnmultiply)
        Me.Controls.Add(Me.btnsubtract)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnclear As Button
    Friend WithEvents txtresult As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents btndivide As Button
    Friend WithEvents btnmultiply As Button
    Friend WithEvents btnsubtract As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
