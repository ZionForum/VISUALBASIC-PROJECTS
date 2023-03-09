<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmequipment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmequipment))
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnworking = New System.Windows.Forms.Button()
        Me.btnrepair = New System.Windows.Forms.Button()
        Me.btnretire = New System.Windows.Forms.Button()
        Me.btnrefresh = New System.Windows.Forms.Button()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView2.Location = New System.Drawing.Point(25, 47)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(543, 322)
        Me.DataGridView2.TabIndex = 6
        '
        'txtsearch
        '
        Me.txtsearch.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(361, 19)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(207, 22)
        Me.txtsearch.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(294, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Search:"
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(86, 380)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(75, 29)
        Me.btnedit.TabIndex = 19
        Me.btnedit.Text = "&Update"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(5, 380)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 29)
        Me.btnadd.TabIndex = 18
        Me.btnadd.Text = "&Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(167, 380)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 29)
        Me.btndelete.TabIndex = 20
        Me.btndelete.Text = "&Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnworking
        '
        Me.btnworking.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnworking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnworking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnworking.Location = New System.Drawing.Point(248, 380)
        Me.btnworking.Name = "btnworking"
        Me.btnworking.Size = New System.Drawing.Size(75, 29)
        Me.btnworking.TabIndex = 21
        Me.btnworking.Text = "&Working"
        Me.btnworking.UseVisualStyleBackColor = False
        '
        'btnrepair
        '
        Me.btnrepair.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnrepair.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrepair.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrepair.Location = New System.Drawing.Point(329, 380)
        Me.btnrepair.Name = "btnrepair"
        Me.btnrepair.Size = New System.Drawing.Size(83, 29)
        Me.btnrepair.TabIndex = 22
        Me.btnrepair.Text = "&On-repair"
        Me.btnrepair.UseVisualStyleBackColor = False
        '
        'btnretire
        '
        Me.btnretire.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnretire.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnretire.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnretire.Location = New System.Drawing.Point(418, 380)
        Me.btnretire.Name = "btnretire"
        Me.btnretire.Size = New System.Drawing.Size(83, 29)
        Me.btnretire.TabIndex = 23
        Me.btnretire.Text = "&Retire"
        Me.btnretire.UseVisualStyleBackColor = False
        '
        'btnrefresh
        '
        Me.btnrefresh.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnrefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrefresh.Location = New System.Drawing.Point(507, 380)
        Me.btnrefresh.Name = "btnrefresh"
        Me.btnrefresh.Size = New System.Drawing.Size(83, 29)
        Me.btnrefresh.TabIndex = 24
        Me.btnrefresh.Text = "R&efresh"
        Me.btnrefresh.UseVisualStyleBackColor = False
        '
        'frmequipment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(595, 421)
        Me.Controls.Add(Me.btnrefresh)
        Me.Controls.Add(Me.btnretire)
        Me.Controls.Add(Me.btnrepair)
        Me.Controls.Add(Me.btnworking)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmequipment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Equipment"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnedit As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnworking As Button
    Friend WithEvents btnrepair As Button
    Friend WithEvents btnretire As Button
    Friend WithEvents btnrefresh As Button
End Class
