<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItem
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
        Me.Lbliid = New System.Windows.Forms.Label()
        Me.Lbliname = New System.Windows.Forms.Label()
        Me.Lblprice = New System.Windows.Forms.Label()
        Me.Lblstock = New System.Windows.Forms.Label()
        Me.Txtiid = New System.Windows.Forms.TextBox()
        Me.Txtiname = New System.Windows.Forms.TextBox()
        Me.Txtprice = New System.Windows.Forms.TextBox()
        Me.Txtstock = New System.Windows.Forms.TextBox()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lbliid
        '
        Me.Lbliid.AutoSize = True
        Me.Lbliid.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbliid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbliid.Location = New System.Drawing.Point(110, 122)
        Me.Lbliid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbliid.Name = "Lbliid"
        Me.Lbliid.Size = New System.Drawing.Size(139, 40)
        Me.Lbliid.TabIndex = 0
        Me.Lbliid.Text = "Item ID :-"
        '
        'Lbliname
        '
        Me.Lbliname.AutoSize = True
        Me.Lbliname.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbliname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbliname.Location = New System.Drawing.Point(62, 178)
        Me.Lbliname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbliname.Name = "Lbliname"
        Me.Lbliname.Size = New System.Drawing.Size(190, 40)
        Me.Lbliname.TabIndex = 1
        Me.Lbliname.Text = "Item Name :-"
        '
        'Lblprice
        '
        Me.Lblprice.AutoSize = True
        Me.Lblprice.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblprice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblprice.Location = New System.Drawing.Point(134, 236)
        Me.Lblprice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblprice.Name = "Lblprice"
        Me.Lblprice.Size = New System.Drawing.Size(112, 40)
        Me.Lblprice.TabIndex = 2
        Me.Lblprice.Text = "Price :-"
        '
        'Lblstock
        '
        Me.Lblstock.AutoSize = True
        Me.Lblstock.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblstock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblstock.Location = New System.Drawing.Point(127, 292)
        Me.Lblstock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblstock.Name = "Lblstock"
        Me.Lblstock.Size = New System.Drawing.Size(118, 40)
        Me.Lblstock.TabIndex = 3
        Me.Lblstock.Text = "Stock :-"
        '
        'Txtiid
        '
        Me.Txtiid.BackColor = System.Drawing.Color.White
        Me.Txtiid.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtiid.Location = New System.Drawing.Point(282, 122)
        Me.Txtiid.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtiid.Multiline = True
        Me.Txtiid.Name = "Txtiid"
        Me.Txtiid.Size = New System.Drawing.Size(268, 36)
        Me.Txtiid.TabIndex = 0
        '
        'Txtiname
        '
        Me.Txtiname.BackColor = System.Drawing.Color.White
        Me.Txtiname.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtiname.Location = New System.Drawing.Point(282, 178)
        Me.Txtiname.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtiname.Multiline = True
        Me.Txtiname.Name = "Txtiname"
        Me.Txtiname.Size = New System.Drawing.Size(268, 36)
        Me.Txtiname.TabIndex = 1
        '
        'Txtprice
        '
        Me.Txtprice.BackColor = System.Drawing.Color.White
        Me.Txtprice.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtprice.Location = New System.Drawing.Point(280, 236)
        Me.Txtprice.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtprice.Multiline = True
        Me.Txtprice.Name = "Txtprice"
        Me.Txtprice.Size = New System.Drawing.Size(268, 36)
        Me.Txtprice.TabIndex = 2
        '
        'Txtstock
        '
        Me.Txtstock.BackColor = System.Drawing.Color.White
        Me.Txtstock.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtstock.Location = New System.Drawing.Point(282, 292)
        Me.Txtstock.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtstock.Multiline = True
        Me.Txtstock.Name = "Txtstock"
        Me.Txtstock.Size = New System.Drawing.Size(268, 36)
        Me.Txtstock.TabIndex = 3
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnReset.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.Maroon
        Me.BtnReset.Location = New System.Drawing.Point(752, 118)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(159, 66)
        Me.BtnReset.TabIndex = 59
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'BtnLast
        '
        Me.BtnLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLast.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.ForeColor = System.Drawing.Color.Maroon
        Me.BtnLast.Location = New System.Drawing.Point(818, 537)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(173, 51)
        Me.BtnLast.TabIndex = 58
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = False
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnFirst.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.ForeColor = System.Drawing.Color.Maroon
        Me.BtnFirst.Location = New System.Drawing.Point(206, 537)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(173, 51)
        Me.BtnFirst.TabIndex = 57
        Me.BtnFirst.Text = "First"
        Me.BtnFirst.UseVisualStyleBackColor = False
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnPrevious.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.ForeColor = System.Drawing.Color.Maroon
        Me.BtnPrevious.Location = New System.Drawing.Point(415, 537)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(173, 51)
        Me.BtnPrevious.TabIndex = 56
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnNext.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.ForeColor = System.Drawing.Color.Maroon
        Me.BtnNext.Location = New System.Drawing.Point(609, 537)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(173, 51)
        Me.BtnNext.TabIndex = 55
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnDelete.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.Maroon
        Me.BtnDelete.Location = New System.Drawing.Point(752, 186)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(159, 70)
        Me.BtnDelete.TabIndex = 54
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnUpdate.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.Maroon
        Me.BtnUpdate.Location = New System.Drawing.Point(578, 114)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(159, 74)
        Me.BtnUpdate.TabIndex = 53
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnEdit.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnEdit.Location = New System.Drawing.Point(578, 194)
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
        Me.BtnAdd.Location = New System.Drawing.Point(328, 347)
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
        Me.BtnSearch.Location = New System.Drawing.Point(578, 262)
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
        Me.BtnSave.Location = New System.Drawing.Point(752, 262)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(159, 66)
        Me.BtnSave.TabIndex = 107
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1201, 596)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnLast)
        Me.Controls.Add(Me.BtnFirst)
        Me.Controls.Add(Me.BtnPrevious)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.Txtstock)
        Me.Controls.Add(Me.Txtprice)
        Me.Controls.Add(Me.Txtiname)
        Me.Controls.Add(Me.Txtiid)
        Me.Controls.Add(Me.Lblstock)
        Me.Controls.Add(Me.Lblprice)
        Me.Controls.Add(Me.Lbliname)
        Me.Controls.Add(Me.Lbliid)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmItem"
        Me.Text = "Item"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbliid As Label
    Friend WithEvents Lbliname As Label
    Friend WithEvents Lblprice As Label
    Friend WithEvents Lblstock As Label
    Friend WithEvents Txtiid As TextBox
    Friend WithEvents Txtiname As TextBox
    Friend WithEvents Txtprice As TextBox
    Friend WithEvents Txtstock As TextBox
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnLast As Button
    Friend WithEvents BtnFirst As Button
    Friend WithEvents BtnPrevious As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
