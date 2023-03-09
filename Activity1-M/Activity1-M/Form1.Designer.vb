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
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtTangent = New System.Windows.Forms.TextBox()
        Me.txtCosine = New System.Windows.Forms.TextBox()
        Me.txtSine = New System.Windows.Forms.TextBox()
        Me.txtHypotenuse = New System.Windows.Forms.TextBox()
        Me.txtAdjacent = New System.Windows.Forms.TextBox()
        Me.txtOpposite = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.btnClear.Location = New System.Drawing.Point(287, 127)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 27
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCompute.Location = New System.Drawing.Point(191, 127)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 23)
        Me.btnCompute.TabIndex = 26
        Me.btnCompute.Text = "&Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'txtTangent
        '
        Me.txtTangent.Enabled = False
        Me.txtTangent.Location = New System.Drawing.Point(405, 75)
        Me.txtTangent.Name = "txtTangent"
        Me.txtTangent.Size = New System.Drawing.Size(136, 20)
        Me.txtTangent.TabIndex = 25
        '
        'txtCosine
        '
        Me.txtCosine.Enabled = False
        Me.txtCosine.Location = New System.Drawing.Point(405, 45)
        Me.txtCosine.Name = "txtCosine"
        Me.txtCosine.Size = New System.Drawing.Size(136, 20)
        Me.txtCosine.TabIndex = 24
        '
        'txtSine
        '
        Me.txtSine.Enabled = False
        Me.txtSine.Location = New System.Drawing.Point(405, 14)
        Me.txtSine.Name = "txtSine"
        Me.txtSine.Size = New System.Drawing.Size(136, 20)
        Me.txtSine.TabIndex = 23
        '
        'txtHypotenuse
        '
        Me.txtHypotenuse.Location = New System.Drawing.Point(147, 75)
        Me.txtHypotenuse.Name = "txtHypotenuse"
        Me.txtHypotenuse.Size = New System.Drawing.Size(136, 20)
        Me.txtHypotenuse.TabIndex = 22
        '
        'txtAdjacent
        '
        Me.txtAdjacent.Location = New System.Drawing.Point(147, 45)
        Me.txtAdjacent.Name = "txtAdjacent"
        Me.txtAdjacent.Size = New System.Drawing.Size(136, 20)
        Me.txtAdjacent.TabIndex = 21
        '
        'txtOpposite
        '
        Me.txtOpposite.Location = New System.Drawing.Point(147, 14)
        Me.txtOpposite.Name = "txtOpposite"
        Me.txtOpposite.Size = New System.Drawing.Size(136, 20)
        Me.txtOpposite.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(320, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Tangent:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(320, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Cosine:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Sine:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Input Hypotenuse:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Input Adjacent:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Input Opposite:"
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
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(559, 165)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtTangent)
        Me.Controls.Add(Me.txtCosine)
        Me.Controls.Add(Me.txtSine)
        Me.Controls.Add(Me.txtHypotenuse)
        Me.Controls.Add(Me.txtAdjacent)
        Me.Controls.Add(Me.txtOpposite)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
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
    Friend WithEvents btnCompute As Button
    Friend WithEvents txtTangent As TextBox
    Friend WithEvents txtCosine As TextBox
    Friend WithEvents txtSine As TextBox
    Friend WithEvents txtHypotenuse As TextBox
    Friend WithEvents txtAdjacent As TextBox
    Friend WithEvents txtOpposite As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
