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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnTangent = New System.Windows.Forms.Button()
        Me.btnCosine = New System.Windows.Forms.Button()
        Me.btnSine = New System.Windows.Forms.Button()
        Me.txthypotenuse = New System.Windows.Forms.TextBox()
        Me.txtadjacent = New System.Windows.Forms.TextBox()
        Me.txtopposite = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Location = New System.Drawing.Point(271, 142)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnTangent
        '
        Me.btnTangent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTangent.Location = New System.Drawing.Point(190, 142)
        Me.btnTangent.Name = "btnTangent"
        Me.btnTangent.Size = New System.Drawing.Size(75, 23)
        Me.btnTangent.TabIndex = 18
        Me.btnTangent.Text = "&Tangent"
        Me.btnTangent.UseVisualStyleBackColor = True
        '
        'btnCosine
        '
        Me.btnCosine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCosine.Location = New System.Drawing.Point(109, 142)
        Me.btnCosine.Name = "btnCosine"
        Me.btnCosine.Size = New System.Drawing.Size(75, 23)
        Me.btnCosine.TabIndex = 17
        Me.btnCosine.Text = "&Cosine"
        Me.btnCosine.UseVisualStyleBackColor = True
        '
        'btnSine
        '
        Me.btnSine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSine.Location = New System.Drawing.Point(28, 142)
        Me.btnSine.Name = "btnSine"
        Me.btnSine.Size = New System.Drawing.Size(75, 23)
        Me.btnSine.TabIndex = 16
        Me.btnSine.Text = "&Sine"
        Me.btnSine.UseVisualStyleBackColor = True
        '
        'txthypotenuse
        '
        Me.txthypotenuse.Location = New System.Drawing.Point(176, 98)
        Me.txthypotenuse.Name = "txthypotenuse"
        Me.txthypotenuse.Size = New System.Drawing.Size(100, 20)
        Me.txthypotenuse.TabIndex = 15
        '
        'txtadjacent
        '
        Me.txtadjacent.Location = New System.Drawing.Point(176, 62)
        Me.txtadjacent.Name = "txtadjacent"
        Me.txtadjacent.Size = New System.Drawing.Size(100, 20)
        Me.txtadjacent.TabIndex = 14
        '
        'txtopposite
        '
        Me.txtopposite.Location = New System.Drawing.Point(176, 26)
        Me.txtopposite.Name = "txtopposite"
        Me.txtopposite.Size = New System.Drawing.Size(100, 20)
        Me.txtopposite.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Hypotenuse:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Adjacent:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Opposite:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(375, 191)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTangent)
        Me.Controls.Add(Me.btnCosine)
        Me.Controls.Add(Me.btnSine)
        Me.Controls.Add(Me.txthypotenuse)
        Me.Controls.Add(Me.txtadjacent)
        Me.Controls.Add(Me.txtopposite)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Triangle"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnTangent As Button
    Friend WithEvents btnCosine As Button
    Friend WithEvents btnSine As Button
    Friend WithEvents txthypotenuse As TextBox
    Friend WithEvents txtadjacent As TextBox
    Friend WithEvents txtopposite As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
