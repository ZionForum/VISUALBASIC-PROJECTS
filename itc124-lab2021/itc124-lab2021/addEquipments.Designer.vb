<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addEquipments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addEquipments))
        Me.btncancel = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.cmbbranch = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtserial = New System.Windows.Forms.TextBox()
        Me.txtasset = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        Me.txtmanufacturer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtyrmodel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbdept = New System.Windows.Forms.ComboBox()
        Me.txtdescription = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbstatus = New System.Windows.Forms.ComboBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.Location = New System.Drawing.Point(392, 367)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(75, 23)
        Me.btncancel.TabIndex = 19
        Me.btncancel.Text = "&Cancel"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnsave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.Location = New System.Drawing.Point(295, 367)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(75, 23)
        Me.btnsave.TabIndex = 18
        Me.btnsave.Text = "&Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'cmbbranch
        '
        Me.cmbbranch.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmbbranch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbbranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbbranch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbbranch.FormattingEnabled = True
        Me.cmbbranch.Items.AddRange(New Object() {"Andres Bonifacio", "Apolinario Mabini", "Elisa Esguerra", "Jose Abad Santos", "Jose Rizal", "Juan Sumulong", "Plaridel"})
        Me.cmbbranch.Location = New System.Drawing.Point(199, 148)
        Me.cmbbranch.Name = "cmbbranch"
        Me.cmbbranch.Size = New System.Drawing.Size(268, 24)
        Me.cmbbranch.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Goldenrod
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(133, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Branch:"
        '
        'txtserial
        '
        Me.txtserial.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtserial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtserial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtserial.Location = New System.Drawing.Point(199, 43)
        Me.txtserial.Name = "txtserial"
        Me.txtserial.Size = New System.Drawing.Size(268, 22)
        Me.txtserial.TabIndex = 14
        '
        'txtasset
        '
        Me.txtasset.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtasset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtasset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtasset.Location = New System.Drawing.Point(199, 17)
        Me.txtasset.Name = "txtasset"
        Me.txtasset.Size = New System.Drawing.Size(268, 22)
        Me.txtasset.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Goldenrod
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Equipment Type:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Goldenrod
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Serial Number:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Goldenrod
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Asset Number:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cmbtype
        '
        Me.cmbtype.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmbtype.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"MONITOR", "CPU", "KEYBOARD", "MOUSE", "AVR", "MAC", "PRINTER", "PROJECTOR"})
        Me.cmbtype.Location = New System.Drawing.Point(199, 69)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(268, 24)
        Me.cmbtype.TabIndex = 20
        '
        'txtmanufacturer
        '
        Me.txtmanufacturer.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtmanufacturer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtmanufacturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmanufacturer.Location = New System.Drawing.Point(199, 96)
        Me.txtmanufacturer.Name = "txtmanufacturer"
        Me.txtmanufacturer.Size = New System.Drawing.Size(268, 22)
        Me.txtmanufacturer.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Goldenrod
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(92, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Manufacturer:"
        '
        'txtyrmodel
        '
        Me.txtyrmodel.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtyrmodel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtyrmodel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtyrmodel.Location = New System.Drawing.Point(199, 122)
        Me.txtyrmodel.Name = "txtyrmodel"
        Me.txtyrmodel.Size = New System.Drawing.Size(268, 22)
        Me.txtyrmodel.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Goldenrod
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Equipment Year Model:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Goldenrod
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(101, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Department:"
        '
        'cmbdept
        '
        Me.cmbdept.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmbdept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbdept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdept.FormattingEnabled = True
        Me.cmbdept.Items.AddRange(New Object() {"Dean, Graduate School of Education", "Dean, Graduate School of Nursing", "Dean, Graduate School of Business", "OIC, School of Liberal Arts, Social Sciences, and Humanities", "Cluster Dean, School of Business, Technology & Management", "Department Chair, College of Business Administration", "Cluster Dean, School of Science and Mathematics", "Department Chair, College of Nursing", "Cluster Dean, School of Education, Industrial Arts, Skills Training and Continuin" &
                "g Education", "Department Chair, College of Education", "Department Chair, Hospitality & Tourism Mgt.", "Department Chair, Institute of Accountancy", "Department Chair, College of Radiologic Technology", "Department Chair, School of Computer Science", "Director, International Nursing Program", "Department Chair, College of Medical Laboratory Science", "Department Chair, College of Pharmacy", "Department Chair, College of Physical Therapy", "Department Chair, School of Midwifery", "Department Chair, BS Psychology", "Department Chair, College of Criminal Justice", "Dean, Arellano University School of Law"})
        Me.cmbdept.Location = New System.Drawing.Point(199, 175)
        Me.cmbdept.Name = "cmbdept"
        Me.cmbdept.Size = New System.Drawing.Size(268, 24)
        Me.cmbdept.TabIndex = 26
        '
        'txtdescription
        '
        Me.txtdescription.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtdescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescription.Location = New System.Drawing.Point(109, 260)
        Me.txtdescription.Multiline = True
        Me.txtdescription.Name = "txtdescription"
        Me.txtdescription.Size = New System.Drawing.Size(358, 101)
        Me.txtdescription.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Goldenrod
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(106, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(209, 16)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Description of the equipment:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Goldenrod
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(138, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Status:"
        '
        'cmbstatus
        '
        Me.cmbstatus.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cmbstatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbstatus.FormattingEnabled = True
        Me.cmbstatus.Items.AddRange(New Object() {"RETIRE", "ON-REPAIR", "WORKING"})
        Me.cmbstatus.Location = New System.Drawing.Point(199, 203)
        Me.cmbstatus.Name = "cmbstatus"
        Me.cmbstatus.Size = New System.Drawing.Size(268, 24)
        Me.cmbstatus.TabIndex = 30
        '
        'addEquipments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(506, 395)
        Me.Controls.Add(Me.cmbstatus)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtdescription)
        Me.Controls.Add(Me.cmbdept)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtyrmodel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtmanufacturer)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbtype)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cmbbranch)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtserial)
        Me.Controls.Add(Me.txtasset)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "addEquipments"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adding Equipments"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncancel As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents cmbbranch As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtserial As TextBox
    Friend WithEvents txtasset As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents txtyrmodel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtmanufacturer As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbtype As ComboBox
    Friend WithEvents cmbdept As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdescription As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbstatus As ComboBox
End Class
