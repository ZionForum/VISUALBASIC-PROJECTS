<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Triangle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Triangle))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chckboxTangent = New System.Windows.Forms.CheckBox()
        Me.chckboxCosine = New System.Windows.Forms.CheckBox()
        Me.chckboxSine = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.txtHypotenuse = New System.Windows.Forms.TextBox()
        Me.txtOpposite = New System.Windows.Forms.TextBox()
        Me.txtAdjacent = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Controls.Add(Me.chckboxTangent)
        Me.GroupBox1.Controls.Add(Me.chckboxCosine)
        Me.GroupBox1.Controls.Add(Me.chckboxSine)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox1.Location = New System.Drawing.Point(17, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 91)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Operations"
        '
        'chckboxTangent
        '
        Me.chckboxTangent.AutoSize = True
        Me.chckboxTangent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chckboxTangent.Location = New System.Drawing.Point(6, 65)
        Me.chckboxTangent.Name = "chckboxTangent"
        Me.chckboxTangent.Size = New System.Drawing.Size(73, 17)
        Me.chckboxTangent.TabIndex = 2
        Me.chckboxTangent.Text = "Tangent"
        Me.chckboxTangent.UseVisualStyleBackColor = True
        '
        'chckboxCosine
        '
        Me.chckboxCosine.AutoSize = True
        Me.chckboxCosine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chckboxCosine.Location = New System.Drawing.Point(6, 42)
        Me.chckboxCosine.Name = "chckboxCosine"
        Me.chckboxCosine.Size = New System.Drawing.Size(64, 17)
        Me.chckboxCosine.TabIndex = 1
        Me.chckboxCosine.Text = "Cosine"
        Me.chckboxCosine.UseVisualStyleBackColor = True
        '
        'chckboxSine
        '
        Me.chckboxSine.AutoSize = True
        Me.chckboxSine.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.chckboxSine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chckboxSine.Location = New System.Drawing.Point(6, 19)
        Me.chckboxSine.Name = "chckboxSine"
        Me.chckboxSine.Size = New System.Drawing.Size(51, 17)
        Me.chckboxSine.TabIndex = 0
        Me.chckboxSine.Text = "Sine"
        Me.chckboxSine.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Crimson
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(192, 153)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 36)
        Me.btnClear.TabIndex = 39
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.SpringGreen
        Me.btnCompute.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(192, 111)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(75, 36)
        Me.btnCompute.TabIndex = 38
        Me.btnCompute.Text = "&Submit"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'txtHypotenuse
        '
        Me.txtHypotenuse.BackColor = System.Drawing.Color.SpringGreen
        Me.txtHypotenuse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHypotenuse.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHypotenuse.ForeColor = System.Drawing.Color.Gray
        Me.txtHypotenuse.Location = New System.Drawing.Point(147, 73)
        Me.txtHypotenuse.Name = "txtHypotenuse"
        Me.txtHypotenuse.Size = New System.Drawing.Size(136, 20)
        Me.txtHypotenuse.TabIndex = 37
        '
        'txtOpposite
        '
        Me.txtOpposite.BackColor = System.Drawing.Color.SpringGreen
        Me.txtOpposite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOpposite.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpposite.ForeColor = System.Drawing.Color.Gray
        Me.txtOpposite.Location = New System.Drawing.Point(147, 43)
        Me.txtOpposite.Name = "txtOpposite"
        Me.txtOpposite.Size = New System.Drawing.Size(136, 20)
        Me.txtOpposite.TabIndex = 36
        '
        'txtAdjacent
        '
        Me.txtAdjacent.BackColor = System.Drawing.Color.SpringGreen
        Me.txtAdjacent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdjacent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdjacent.ForeColor = System.Drawing.Color.Gray
        Me.txtAdjacent.Location = New System.Drawing.Point(147, 12)
        Me.txtAdjacent.Name = "txtAdjacent"
        Me.txtAdjacent.Size = New System.Drawing.Size(136, 20)
        Me.txtAdjacent.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(17, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Input Hypotenuse:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(34, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Input Opposite:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(34, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Input Adjacent:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Triangle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(300, 206)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtHypotenuse)
        Me.Controls.Add(Me.txtOpposite)
        Me.Controls.Add(Me.txtAdjacent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Triangle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Triangle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chckboxTangent As CheckBox
    Friend WithEvents chckboxCosine As CheckBox
    Friend WithEvents chckboxSine As CheckBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents txtHypotenuse As TextBox
    Friend WithEvents txtOpposite As TextBox
    Friend WithEvents txtAdjacent As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
