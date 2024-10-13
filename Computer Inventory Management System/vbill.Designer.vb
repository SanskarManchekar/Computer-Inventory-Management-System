<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmvbill
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
        Me.Txtfamt = New System.Windows.Forms.TextBox()
        Me.Txttax = New System.Windows.Forms.TextBox()
        Me.Lblbdate = New System.Windows.Forms.Label()
        Me.Lblfamt = New System.Windows.Forms.Label()
        Me.Lbltax = New System.Windows.Forms.Label()
        Me.Txtamt = New System.Windows.Forms.TextBox()
        Me.Txtbillid = New System.Windows.Forms.TextBox()
        Me.Lblamt = New System.Windows.Forms.Label()
        Me.Lblvoid = New System.Windows.Forms.Label()
        Me.Lblbillid = New System.Windows.Forms.Label()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.Cmbvoid = New System.Windows.Forms.ComboBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Txtfamt
        '
        Me.Txtfamt.BackColor = System.Drawing.Color.White
        Me.Txtfamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfamt.Location = New System.Drawing.Point(282, 276)
        Me.Txtfamt.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtfamt.Multiline = True
        Me.Txtfamt.Name = "Txtfamt"
        Me.Txtfamt.Size = New System.Drawing.Size(324, 36)
        Me.Txtfamt.TabIndex = 4
        '
        'Txttax
        '
        Me.Txttax.BackColor = System.Drawing.Color.White
        Me.Txttax.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttax.Location = New System.Drawing.Point(282, 226)
        Me.Txttax.Margin = New System.Windows.Forms.Padding(4)
        Me.Txttax.Multiline = True
        Me.Txttax.Name = "Txttax"
        Me.Txttax.Size = New System.Drawing.Size(324, 36)
        Me.Txttax.TabIndex = 3
        '
        'Lblbdate
        '
        Me.Lblbdate.AutoSize = True
        Me.Lblbdate.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblbdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblbdate.Location = New System.Drawing.Point(86, 327)
        Me.Lblbdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblbdate.Name = "Lblbdate"
        Me.Lblbdate.Size = New System.Drawing.Size(156, 40)
        Me.Lblbdate.TabIndex = 47
        Me.Lblbdate.Text = "Bill Date :-"
        '
        'Lblfamt
        '
        Me.Lblfamt.AutoSize = True
        Me.Lblfamt.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfamt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblfamt.Location = New System.Drawing.Point(20, 276)
        Me.Lblfamt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblfamt.Name = "Lblfamt"
        Me.Lblfamt.Size = New System.Drawing.Size(221, 40)
        Me.Lblfamt.TabIndex = 46
        Me.Lblfamt.Text = "Final Amount :-"
        '
        'Lbltax
        '
        Me.Lbltax.AutoSize = True
        Me.Lbltax.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbltax.Location = New System.Drawing.Point(147, 226)
        Me.Lbltax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbltax.Name = "Lbltax"
        Me.Lbltax.Size = New System.Drawing.Size(93, 40)
        Me.Lbltax.TabIndex = 45
        Me.Lbltax.Text = "Tax :-"
        '
        'Txtamt
        '
        Me.Txtamt.BackColor = System.Drawing.Color.White
        Me.Txtamt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtamt.Location = New System.Drawing.Point(282, 175)
        Me.Txtamt.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtamt.Multiline = True
        Me.Txtamt.Name = "Txtamt"
        Me.Txtamt.Size = New System.Drawing.Size(324, 36)
        Me.Txtamt.TabIndex = 2
        '
        'Txtbillid
        '
        Me.Txtbillid.BackColor = System.Drawing.Color.White
        Me.Txtbillid.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbillid.Location = New System.Drawing.Point(282, 74)
        Me.Txtbillid.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtbillid.Multiline = True
        Me.Txtbillid.Name = "Txtbillid"
        Me.Txtbillid.Size = New System.Drawing.Size(324, 36)
        Me.Txtbillid.TabIndex = 0
        '
        'Lblamt
        '
        Me.Lblamt.AutoSize = True
        Me.Lblamt.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblamt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblamt.Location = New System.Drawing.Point(93, 175)
        Me.Lblamt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblamt.Name = "Lblamt"
        Me.Lblamt.Size = New System.Drawing.Size(147, 40)
        Me.Lblamt.TabIndex = 41
        Me.Lblamt.Text = "Amount :-"
        '
        'Lblvoid
        '
        Me.Lblvoid.AutoSize = True
        Me.Lblvoid.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblvoid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblvoid.Location = New System.Drawing.Point(13, 124)
        Me.Lblvoid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblvoid.Name = "Lblvoid"
        Me.Lblvoid.Size = New System.Drawing.Size(237, 40)
        Me.Lblvoid.TabIndex = 40
        Me.Lblvoid.Text = "Vendor Ord ID :-"
        '
        'Lblbillid
        '
        Me.Lblbillid.AutoSize = True
        Me.Lblbillid.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblbillid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblbillid.Location = New System.Drawing.Point(118, 74)
        Me.Lblbillid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblbillid.Name = "Lblbillid"
        Me.Lblbillid.Size = New System.Drawing.Size(122, 40)
        Me.Lblbillid.TabIndex = 39
        Me.Lblbillid.Text = "Bill ID :-"
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnReset.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.Maroon
        Me.BtnReset.Location = New System.Drawing.Point(820, 74)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(159, 66)
        Me.BtnReset.TabIndex = 93
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnDelete.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.Maroon
        Me.BtnDelete.Location = New System.Drawing.Point(820, 143)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(159, 69)
        Me.BtnDelete.TabIndex = 89
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnUpdate.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.Maroon
        Me.BtnUpdate.Location = New System.Drawing.Point(655, 74)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(159, 66)
        Me.BtnUpdate.TabIndex = 88
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnLast
        '
        Me.BtnLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLast.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.ForeColor = System.Drawing.Color.Maroon
        Me.BtnLast.Location = New System.Drawing.Point(806, 517)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(173, 51)
        Me.BtnLast.TabIndex = 98
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = False
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnFirst.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.ForeColor = System.Drawing.Color.Maroon
        Me.BtnFirst.Location = New System.Drawing.Point(194, 517)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(173, 51)
        Me.BtnFirst.TabIndex = 97
        Me.BtnFirst.Text = "First"
        Me.BtnFirst.UseVisualStyleBackColor = False
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnPrevious.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.ForeColor = System.Drawing.Color.Maroon
        Me.BtnPrevious.Location = New System.Drawing.Point(403, 517)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(173, 51)
        Me.BtnPrevious.TabIndex = 96
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnNext.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.ForeColor = System.Drawing.Color.Maroon
        Me.BtnNext.Location = New System.Drawing.Point(597, 517)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(173, 51)
        Me.BtnNext.TabIndex = 95
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'Cmbvoid
        '
        Me.Cmbvoid.BackColor = System.Drawing.Color.White
        Me.Cmbvoid.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbvoid.FormattingEnabled = True
        Me.Cmbvoid.Location = New System.Drawing.Point(282, 124)
        Me.Cmbvoid.Name = "Cmbvoid"
        Me.Cmbvoid.Size = New System.Drawing.Size(324, 44)
        Me.Cmbvoid.TabIndex = 99
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnEdit.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnEdit.Location = New System.Drawing.Point(655, 143)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(159, 66)
        Me.BtnEdit.TabIndex = 105
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAdd.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.Maroon
        Me.BtnAdd.Location = New System.Drawing.Point(338, 374)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(159, 66)
        Me.BtnAdd.TabIndex = 104
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSearch.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSearch.Location = New System.Drawing.Point(655, 215)
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
        Me.BtnSave.Location = New System.Drawing.Point(820, 218)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(159, 66)
        Me.BtnSave.TabIndex = 110
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(282, 327)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(324, 41)
        Me.DateTimePicker1.TabIndex = 111
        '
        'Frmvbill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1204, 580)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Cmbvoid)
        Me.Controls.Add(Me.BtnLast)
        Me.Controls.Add(Me.BtnFirst)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.Txtfamt)
        Me.Controls.Add(Me.Txttax)
        Me.Controls.Add(Me.Lblbdate)
        Me.Controls.Add(Me.Lblfamt)
        Me.Controls.Add(Me.Lbltax)
        Me.Controls.Add(Me.Txtamt)
        Me.Controls.Add(Me.Txtbillid)
        Me.Controls.Add(Me.Lblamt)
        Me.Controls.Add(Me.Lblvoid)
        Me.Controls.Add(Me.Lblbillid)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frmvbill"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "vbill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtfamt As TextBox
    Friend WithEvents Txttax As TextBox
    Friend WithEvents Lblbdate As Label
    Friend WithEvents Lblfamt As Label
    Friend WithEvents Lbltax As Label
    Friend WithEvents Txtamt As TextBox
    Friend WithEvents Txtbillid As TextBox
    Friend WithEvents Lblamt As Label
    Friend WithEvents Lblvoid As Label
    Friend WithEvents Lblbillid As Label
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnLast As Button
    Friend WithEvents BtnFirst As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents Cmbvoid As ComboBox
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
