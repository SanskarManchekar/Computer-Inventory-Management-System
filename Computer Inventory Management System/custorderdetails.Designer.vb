<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmcustorderdetails
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
        Me.Txtcodid = New System.Windows.Forms.TextBox()
        Me.Lbliid = New System.Windows.Forms.Label()
        Me.Lblcoid = New System.Windows.Forms.Label()
        Me.Lblcodid = New System.Windows.Forms.Label()
        Me.Txtqty = New System.Windows.Forms.TextBox()
        Me.Lblqty = New System.Windows.Forms.Label()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Cmbcoid = New System.Windows.Forms.ComboBox()
        Me.Cmbiid = New System.Windows.Forms.ComboBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txtcodid
        '
        Me.Txtcodid.BackColor = System.Drawing.Color.White
        Me.Txtcodid.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcodid.Location = New System.Drawing.Point(349, 129)
        Me.Txtcodid.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtcodid.Multiline = True
        Me.Txtcodid.Name = "Txtcodid"
        Me.Txtcodid.Size = New System.Drawing.Size(268, 39)
        Me.Txtcodid.TabIndex = 0
        '
        'Lbliid
        '
        Me.Lbliid.AutoSize = True
        Me.Lbliid.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbliid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbliid.Location = New System.Drawing.Point(188, 251)
        Me.Lbliid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbliid.Name = "Lbliid"
        Me.Lbliid.Size = New System.Drawing.Size(139, 40)
        Me.Lbliid.TabIndex = 23
        Me.Lbliid.Text = "Item ID :-"
        '
        'Lblcoid
        '
        Me.Lblcoid.AutoSize = True
        Me.Lblcoid.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcoid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblcoid.Location = New System.Drawing.Point(33, 186)
        Me.Lblcoid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblcoid.Name = "Lblcoid"
        Me.Lblcoid.Size = New System.Drawing.Size(297, 40)
        Me.Lblcoid.TabIndex = 22
        Me.Lblcoid.Text = "Customer Order ID :-"
        '
        'Lblcodid
        '
        Me.Lblcodid.AutoSize = True
        Me.Lblcodid.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcodid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblcodid.Location = New System.Drawing.Point(53, 129)
        Me.Lblcodid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblcodid.Name = "Lblcodid"
        Me.Lblcodid.Size = New System.Drawing.Size(276, 40)
        Me.Lblcodid.TabIndex = 21
        Me.Lblcodid.Text = "Cust Order Detail :-"
        '
        'Txtqty
        '
        Me.Txtqty.BackColor = System.Drawing.Color.White
        Me.Txtqty.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtqty.Location = New System.Drawing.Point(349, 310)
        Me.Txtqty.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtqty.Multiline = True
        Me.Txtqty.Name = "Txtqty"
        Me.Txtqty.Size = New System.Drawing.Size(268, 39)
        Me.Txtqty.TabIndex = 3
        '
        'Lblqty
        '
        Me.Lblqty.AutoSize = True
        Me.Lblqty.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblqty.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblqty.Location = New System.Drawing.Point(170, 310)
        Me.Lblqty.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblqty.Name = "Lblqty"
        Me.Lblqty.Size = New System.Drawing.Size(155, 40)
        Me.Lblqty.TabIndex = 27
        Me.Lblqty.Text = "Quantity :-"
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnReset.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.Maroon
        Me.BtnReset.Location = New System.Drawing.Point(826, 133)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(159, 66)
        Me.BtnReset.TabIndex = 51
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'BtnLast
        '
        Me.BtnLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLast.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.ForeColor = System.Drawing.Color.Maroon
        Me.BtnLast.Location = New System.Drawing.Point(812, 541)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(173, 51)
        Me.BtnLast.TabIndex = 50
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = False
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnFirst.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.ForeColor = System.Drawing.Color.Maroon
        Me.BtnFirst.Location = New System.Drawing.Point(200, 541)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(173, 51)
        Me.BtnFirst.TabIndex = 49
        Me.BtnFirst.Text = "First"
        Me.BtnFirst.UseVisualStyleBackColor = False
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnPrevious.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.ForeColor = System.Drawing.Color.Maroon
        Me.BtnPrevious.Location = New System.Drawing.Point(409, 541)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(173, 51)
        Me.BtnPrevious.TabIndex = 48
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnNext.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.ForeColor = System.Drawing.Color.Maroon
        Me.BtnNext.Location = New System.Drawing.Point(603, 541)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(173, 51)
        Me.BtnNext.TabIndex = 47
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnDelete.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.Maroon
        Me.BtnDelete.Location = New System.Drawing.Point(826, 202)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(159, 74)
        Me.BtnDelete.TabIndex = 46
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnUpdate.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.Maroon
        Me.BtnUpdate.Location = New System.Drawing.Point(661, 133)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(159, 70)
        Me.BtnUpdate.TabIndex = 45
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'Cmbcoid
        '
        Me.Cmbcoid.BackColor = System.Drawing.Color.White
        Me.Cmbcoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbcoid.FormattingEnabled = True
        Me.Cmbcoid.Location = New System.Drawing.Point(349, 186)
        Me.Cmbcoid.Name = "Cmbcoid"
        Me.Cmbcoid.Size = New System.Drawing.Size(268, 44)
        Me.Cmbcoid.TabIndex = 52
        '
        'Cmbiid
        '
        Me.Cmbiid.BackColor = System.Drawing.Color.White
        Me.Cmbiid.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbiid.FormattingEnabled = True
        Me.Cmbiid.Location = New System.Drawing.Point(349, 248)
        Me.Cmbiid.Name = "Cmbiid"
        Me.Cmbiid.Size = New System.Drawing.Size(268, 44)
        Me.Cmbiid.TabIndex = 53
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnEdit.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnEdit.Location = New System.Drawing.Point(661, 209)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(159, 69)
        Me.BtnEdit.TabIndex = 103
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAdd.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.Maroon
        Me.BtnAdd.Location = New System.Drawing.Point(397, 367)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(159, 74)
        Me.BtnAdd.TabIndex = 102
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSearch.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSearch.Location = New System.Drawing.Point(661, 285)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(159, 66)
        Me.BtnSearch.TabIndex = 106
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSave.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSave.Location = New System.Drawing.Point(826, 282)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(159, 66)
        Me.BtnSave.TabIndex = 108
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Frmcustorderdetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1265, 604)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Cmbiid)
        Me.Controls.Add(Me.Cmbcoid)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnLast)
        Me.Controls.Add(Me.BtnFirst)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.Txtqty)
        Me.Controls.Add(Me.Lblqty)
        Me.Controls.Add(Me.Txtcodid)
        Me.Controls.Add(Me.Lbliid)
        Me.Controls.Add(Me.Lblcoid)
        Me.Controls.Add(Me.Lblcodid)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frmcustorderdetails"
        Me.Text = "custorderdetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtcodid As TextBox
    Friend WithEvents Lbliid As Label
    Friend WithEvents Lblcoid As Label
    Friend WithEvents Lblcodid As Label
    Friend WithEvents Txtqty As TextBox
    Friend WithEvents Lblqty As Label
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnLast As Button
    Friend WithEvents BtnFirst As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents Cmbcoid As ComboBox
    Friend WithEvents Cmbiid As ComboBox
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnSave As Button
End Class
