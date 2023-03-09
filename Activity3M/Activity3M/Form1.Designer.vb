<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtNoOfSeats = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbOneWay = New System.Windows.Forms.RadioButton()
        Me.rbTwoWay = New System.Windows.Forms.RadioButton()
        Me.cmbClassCode = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtClassification = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSeatFare = New System.Windows.Forms.TextBox()
        Me.txtGrossFare = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTrip = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNoOfSeats
        '
        Me.txtNoOfSeats.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtNoOfSeats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoOfSeats.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoOfSeats.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfSeats.Location = New System.Drawing.Point(209, 39)
        Me.txtNoOfSeats.Name = "txtNoOfSeats"
        Me.txtNoOfSeats.Size = New System.Drawing.Size(189, 21)
        Me.txtNoOfSeats.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gray
        Me.GroupBox1.Controls.Add(Me.rbOneWay)
        Me.GroupBox1.Controls.Add(Me.rbTwoWay)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Orange
        Me.GroupBox1.Location = New System.Drawing.Point(17, 67)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 75)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Operations"
        '
        'rbOneWay
        '
        Me.rbOneWay.AutoSize = True
        Me.rbOneWay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbOneWay.Location = New System.Drawing.Point(6, 23)
        Me.rbOneWay.Name = "rbOneWay"
        Me.rbOneWay.Size = New System.Drawing.Size(104, 19)
        Me.rbOneWay.TabIndex = 5
        Me.rbOneWay.TabStop = True
        Me.rbOneWay.Text = "One way trip"
        Me.rbOneWay.UseVisualStyleBackColor = True
        '
        'rbTwoWay
        '
        Me.rbTwoWay.AutoSize = True
        Me.rbTwoWay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbTwoWay.Location = New System.Drawing.Point(6, 46)
        Me.rbTwoWay.Name = "rbTwoWay"
        Me.rbTwoWay.Size = New System.Drawing.Size(104, 19)
        Me.rbTwoWay.TabIndex = 6
        Me.rbTwoWay.TabStop = True
        Me.rbTwoWay.Text = "Two way trip"
        Me.rbTwoWay.UseVisualStyleBackColor = True
        '
        'cmbClassCode
        '
        Me.cmbClassCode.AccessibleName = ""
        Me.cmbClassCode.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmbClassCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbClassCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbClassCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbClassCode.ForeColor = System.Drawing.Color.Black
        Me.cmbClassCode.FormattingEnabled = True
        Me.cmbClassCode.Items.AddRange(New Object() {"A.   SPECIAL        5000", "B.   ECONOMY      7000", "C.   FIRST CLASS   9000", "D.   EXECUTIVE    15000"})
        Me.cmbClassCode.Location = New System.Drawing.Point(209, 12)
        Me.cmbClassCode.Name = "cmbClassCode"
        Me.cmbClassCode.Size = New System.Drawing.Size(189, 23)
        Me.cmbClassCode.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.Location = New System.Drawing.Point(20, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Input Number of Seats:"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.SpringGreen
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(242, 80)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(122, 29)
        Me.btnSubmit.TabIndex = 11
        Me.btnSubmit.Text = "&Submit Request"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Red
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(267, 113)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 29)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Orange
        Me.Label3.Location = New System.Drawing.Point(46, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Select Class Code:"
        '
        'txtClassification
        '
        Me.txtClassification.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtClassification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClassification.Enabled = False
        Me.txtClassification.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClassification.Location = New System.Drawing.Point(209, 182)
        Me.txtClassification.Name = "txtClassification"
        Me.txtClassification.Size = New System.Drawing.Size(189, 21)
        Me.txtClassification.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Orange
        Me.Label2.Location = New System.Drawing.Point(17, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Selected Classification:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Orange
        Me.Label4.Location = New System.Drawing.Point(101, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Seat Fare:"
        '
        'txtSeatFare
        '
        Me.txtSeatFare.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtSeatFare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSeatFare.Enabled = False
        Me.txtSeatFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeatFare.Location = New System.Drawing.Point(209, 209)
        Me.txtSeatFare.Name = "txtSeatFare"
        Me.txtSeatFare.Size = New System.Drawing.Size(189, 21)
        Me.txtSeatFare.TabIndex = 17
        '
        'txtGrossFare
        '
        Me.txtGrossFare.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtGrossFare.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrossFare.Enabled = False
        Me.txtGrossFare.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrossFare.Location = New System.Drawing.Point(209, 236)
        Me.txtGrossFare.Name = "txtGrossFare"
        Me.txtGrossFare.Size = New System.Drawing.Size(189, 21)
        Me.txtGrossFare.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Orange
        Me.Label5.Location = New System.Drawing.Point(93, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Gross Fare:"
        '
        'txtTax
        '
        Me.txtTax.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTax.Enabled = False
        Me.txtTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTax.Location = New System.Drawing.Point(209, 264)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(189, 21)
        Me.txtTax.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Orange
        Me.Label6.Location = New System.Drawing.Point(143, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 15)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Tax:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(209, 289)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(189, 21)
        Me.txtTotal.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Orange
        Me.Label7.Location = New System.Drawing.Point(134, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Orange
        Me.Label8.Location = New System.Drawing.Point(88, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 15)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Kind of Trip:"
        '
        'txtTrip
        '
        Me.txtTrip.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtTrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTrip.Enabled = False
        Me.txtTrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrip.Location = New System.Drawing.Point(209, 155)
        Me.txtTrip.Name = "txtTrip"
        Me.txtTrip.Size = New System.Drawing.Size(189, 21)
        Me.txtTrip.TabIndex = 25
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(417, 323)
        Me.Controls.Add(Me.txtTrip)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtGrossFare)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSeatFare)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtClassification)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbClassCode)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtNoOfSeats)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Commuter's Receipt"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNoOfSeats As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbClassCode As ComboBox
    Friend WithEvents rbOneWay As RadioButton
    Friend WithEvents rbTwoWay As RadioButton
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtGrossFare As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSeatFare As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtClassification As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTrip As TextBox
    Friend WithEvents Label8 As Label
End Class
