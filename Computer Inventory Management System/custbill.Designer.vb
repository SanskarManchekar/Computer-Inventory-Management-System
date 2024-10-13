<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmcustbill
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
        Me.Txtamt = New System.Windows.Forms.TextBox()
        Me.Txtbillid = New System.Windows.Forms.TextBox()
        Me.Lblamt = New System.Windows.Forms.Label()
        Me.Lblcoid = New System.Windows.Forms.Label()
        Me.Lblbillid = New System.Windows.Forms.Label()
        Me.Txtfamt = New System.Windows.Forms.TextBox()
        Me.Txttax = New System.Windows.Forms.TextBox()
        Me.Lblbdate = New System.Windows.Forms.Label()
        Me.Lblfamt = New System.Windows.Forms.Label()
        Me.Lbltax = New System.Windows.Forms.Label()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Cmbcoid = New System.Windows.Forms.ComboBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txtamt
        '
        Me.Txtamt.BackColor = System.Drawing.Color.White
        Me.Txtamt.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtamt.Location = New System.Drawing.Point(373, 184)
        Me.Txtamt.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtamt.Multiline = True
        Me.Txtamt.Name = "Txtamt"
        Me.Txtamt.Size = New System.Drawing.Size(268, 36)
        Me.Txtamt.TabIndex = 2
        '
        'Txtbillid
        '
        Me.Txtbillid.BackColor = System.Drawing.Color.White
        Me.Txtbillid.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtbillid.Location = New System.Drawing.Point(373, 62)
        Me.Txtbillid.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtbillid.Multiline = True
        Me.Txtbillid.Name = "Txtbillid"
        Me.Txtbillid.Size = New System.Drawing.Size(268, 36)
        Me.Txtbillid.TabIndex = 0
        '
        'Lblamt
        '
        Me.Lblamt.AutoSize = True
        Me.Lblamt.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblamt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblamt.Location = New System.Drawing.Point(193, 184)
        Me.Lblamt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblamt.Name = "Lblamt"
        Me.Lblamt.Size = New System.Drawing.Size(139, 40)
        Me.Lblamt.TabIndex = 29
        Me.Lblamt.Text = "Amount:-"
        '
        'Lblcoid
        '
        Me.Lblcoid.AutoSize = True
        Me.Lblcoid.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcoid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblcoid.Location = New System.Drawing.Point(49, 123)
        Me.Lblcoid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblcoid.Name = "Lblcoid"
        Me.Lblcoid.Size = New System.Drawing.Size(289, 40)
        Me.Lblcoid.TabIndex = 28
        Me.Lblcoid.Text = "Customer Order ID:-"
        '
        'Lblbillid
        '
        Me.Lblbillid.AutoSize = True
        Me.Lblbillid.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblbillid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblbillid.Location = New System.Drawing.Point(210, 65)
        Me.Lblbillid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblbillid.Name = "Lblbillid"
        Me.Lblbillid.Size = New System.Drawing.Size(122, 40)
        Me.Lblbillid.TabIndex = 27
        Me.Lblbillid.Text = "Bill ID :-"
        '
        'Txtfamt
        '
        Me.Txtfamt.BackColor = System.Drawing.Color.White
        Me.Txtfamt.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfamt.Location = New System.Drawing.Point(373, 293)
        Me.Txtfamt.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtfamt.Multiline = True
        Me.Txtfamt.Name = "Txtfamt"
        Me.Txtfamt.Size = New System.Drawing.Size(268, 36)
        Me.Txtfamt.TabIndex = 4
        '
        'Txttax
        '
        Me.Txttax.BackColor = System.Drawing.Color.White
        Me.Txttax.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txttax.Location = New System.Drawing.Point(373, 239)
        Me.Txttax.Margin = New System.Windows.Forms.Padding(4)
        Me.Txttax.Multiline = True
        Me.Txttax.Name = "Txttax"
        Me.Txttax.Size = New System.Drawing.Size(268, 36)
        Me.Txttax.TabIndex = 3
        '
        'Lblbdate
        '
        Me.Lblbdate.AutoSize = True
        Me.Lblbdate.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblbdate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblbdate.Location = New System.Drawing.Point(186, 347)
        Me.Lblbdate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblbdate.Name = "Lblbdate"
        Me.Lblbdate.Size = New System.Drawing.Size(148, 40)
        Me.Lblbdate.TabIndex = 35
        Me.Lblbdate.Text = "Bill Date:-"
        '
        'Lblfamt
        '
        Me.Lblfamt.AutoSize = True
        Me.Lblfamt.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblfamt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblfamt.Location = New System.Drawing.Point(120, 293)
        Me.Lblfamt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblfamt.Name = "Lblfamt"
        Me.Lblfamt.Size = New System.Drawing.Size(213, 40)
        Me.Lblfamt.TabIndex = 34
        Me.Lblfamt.Text = "Final Amount:-"
        '
        'Lbltax
        '
        Me.Lbltax.AutoSize = True
        Me.Lbltax.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltax.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbltax.Location = New System.Drawing.Point(247, 239)
        Me.Lbltax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbltax.Name = "Lbltax"
        Me.Lbltax.Size = New System.Drawing.Size(85, 40)
        Me.Lbltax.TabIndex = 33
        Me.Lbltax.Text = "Tax:-"
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnUpdate.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.Maroon
        Me.BtnUpdate.Location = New System.Drawing.Point(687, 78)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(159, 66)
        Me.BtnUpdate.TabIndex = 36
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnDelete.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.Maroon
        Me.BtnDelete.Location = New System.Drawing.Point(852, 150)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(159, 66)
        Me.BtnDelete.TabIndex = 38
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnNext.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.ForeColor = System.Drawing.Color.Maroon
        Me.BtnNext.Location = New System.Drawing.Point(606, 539)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(173, 51)
        Me.BtnNext.TabIndex = 39
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnPrevious.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.ForeColor = System.Drawing.Color.Maroon
        Me.BtnPrevious.Location = New System.Drawing.Point(412, 539)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(173, 51)
        Me.BtnPrevious.TabIndex = 40
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnFirst.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.ForeColor = System.Drawing.Color.Maroon
        Me.BtnFirst.Location = New System.Drawing.Point(203, 539)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(173, 51)
        Me.BtnFirst.TabIndex = 41
        Me.BtnFirst.Text = "First"
        Me.BtnFirst.UseVisualStyleBackColor = False
        '
        'BtnLast
        '
        Me.BtnLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLast.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.ForeColor = System.Drawing.Color.Maroon
        Me.BtnLast.Location = New System.Drawing.Point(815, 539)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(173, 51)
        Me.BtnLast.TabIndex = 42
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = False
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnReset.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.Maroon
        Me.BtnReset.Location = New System.Drawing.Point(852, 78)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(159, 66)
        Me.BtnReset.TabIndex = 43
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Cmbcoid
        '
        Me.Cmbcoid.BackColor = System.Drawing.Color.White
        Me.Cmbcoid.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmbcoid.FormattingEnabled = True
        Me.Cmbcoid.Location = New System.Drawing.Point(373, 120)
        Me.Cmbcoid.Name = "Cmbcoid"
        Me.Cmbcoid.Size = New System.Drawing.Size(268, 39)
        Me.Cmbcoid.TabIndex = 44
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnEdit.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnEdit.Location = New System.Drawing.Point(687, 150)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(159, 66)
        Me.BtnEdit.TabIndex = 103
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAdd.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.Maroon
        Me.BtnAdd.Location = New System.Drawing.Point(345, 405)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(159, 66)
        Me.BtnAdd.TabIndex = 102
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSearch.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSearch.Location = New System.Drawing.Point(687, 222)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(159, 66)
        Me.BtnSearch.TabIndex = 104
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(373, 347)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(268, 34)
        Me.DateTimePicker1.TabIndex = 105
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSave.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSave.Location = New System.Drawing.Point(852, 222)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(159, 66)
        Me.BtnSave.TabIndex = 108
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnPrint.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.Maroon
        Me.BtnPrint.Location = New System.Drawing.Point(1049, 531)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(159, 66)
        Me.BtnPrint.TabIndex = 109
        Me.BtnPrint.Text = "Print Bill"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'Frmcustbill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1249, 602)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Cmbcoid)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnLast)
        Me.Controls.Add(Me.BtnFirst)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnNext)
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
        Me.Controls.Add(Me.Lblcoid)
        Me.Controls.Add(Me.Lblbillid)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frmcustbill"
        Me.Text = "custbill"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtamt As TextBox
    Friend WithEvents Txtbillid As TextBox
    Friend WithEvents Lblamt As Label
    Friend WithEvents Lblcoid As Label
    Friend WithEvents Lblbillid As Label
    Friend WithEvents Txtfamt As TextBox
    Friend WithEvents Txttax As TextBox
    Friend WithEvents Lblbdate As Label
    Friend WithEvents Lblfamt As Label
    Friend WithEvents Lbltax As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnFirst As Button
    Friend WithEvents BtnLast As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Cmbcoid As ComboBox
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnPrint As Button
End Class
