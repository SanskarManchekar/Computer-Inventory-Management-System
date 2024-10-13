<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmcustomer
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
        Me.Txtcmobile = New System.Windows.Forms.TextBox()
        Me.Txtcaddr = New System.Windows.Forms.TextBox()
        Me.Txtcname = New System.Windows.Forms.TextBox()
        Me.Txtcid = New System.Windows.Forms.TextBox()
        Me.Lblcmobile = New System.Windows.Forms.Label()
        Me.Lblcaddr = New System.Windows.Forms.Label()
        Me.Lblcname = New System.Windows.Forms.Label()
        Me.Lblcid = New System.Windows.Forms.Label()
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
        'Txtcmobile
        '
        Me.Txtcmobile.BackColor = System.Drawing.Color.White
        Me.Txtcmobile.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcmobile.ForeColor = System.Drawing.Color.Black
        Me.Txtcmobile.Location = New System.Drawing.Point(330, 343)
        Me.Txtcmobile.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtcmobile.MaxLength = 10
        Me.Txtcmobile.Multiline = True
        Me.Txtcmobile.Name = "Txtcmobile"
        Me.Txtcmobile.Size = New System.Drawing.Size(268, 36)
        Me.Txtcmobile.TabIndex = 7
        '
        'Txtcaddr
        '
        Me.Txtcaddr.BackColor = System.Drawing.Color.White
        Me.Txtcaddr.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcaddr.ForeColor = System.Drawing.Color.Black
        Me.Txtcaddr.Location = New System.Drawing.Point(330, 231)
        Me.Txtcaddr.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtcaddr.Multiline = True
        Me.Txtcaddr.Name = "Txtcaddr"
        Me.Txtcaddr.Size = New System.Drawing.Size(268, 84)
        Me.Txtcaddr.TabIndex = 6
        '
        'Txtcname
        '
        Me.Txtcname.BackColor = System.Drawing.Color.White
        Me.Txtcname.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcname.ForeColor = System.Drawing.Color.Black
        Me.Txtcname.Location = New System.Drawing.Point(330, 173)
        Me.Txtcname.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtcname.Multiline = True
        Me.Txtcname.Name = "Txtcname"
        Me.Txtcname.Size = New System.Drawing.Size(268, 36)
        Me.Txtcname.TabIndex = 5
        '
        'Txtcid
        '
        Me.Txtcid.BackColor = System.Drawing.Color.White
        Me.Txtcid.Font = New System.Drawing.Font("Arial Unicode MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtcid.ForeColor = System.Drawing.Color.Black
        Me.Txtcid.Location = New System.Drawing.Point(330, 113)
        Me.Txtcid.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtcid.Multiline = True
        Me.Txtcid.Name = "Txtcid"
        Me.Txtcid.Size = New System.Drawing.Size(268, 36)
        Me.Txtcid.TabIndex = 4
        '
        'Lblcmobile
        '
        Me.Lblcmobile.AutoSize = True
        Me.Lblcmobile.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcmobile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblcmobile.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Lblcmobile.Location = New System.Drawing.Point(37, 339)
        Me.Lblcmobile.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblcmobile.Name = "Lblcmobile"
        Me.Lblcmobile.Size = New System.Drawing.Size(272, 40)
        Me.Lblcmobile.TabIndex = 3
        Me.Lblcmobile.Text = "Customer Mobile :-"
        '
        'Lblcaddr
        '
        Me.Lblcaddr.AutoSize = True
        Me.Lblcaddr.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcaddr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblcaddr.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Lblcaddr.Location = New System.Drawing.Point(63, 231)
        Me.Lblcaddr.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblcaddr.Name = "Lblcaddr"
        Me.Lblcaddr.Size = New System.Drawing.Size(246, 40)
        Me.Lblcaddr.TabIndex = 2
        Me.Lblcaddr.Text = "Customer Addr :-"
        '
        'Lblcname
        '
        Me.Lblcname.AutoSize = True
        Me.Lblcname.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblcname.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Lblcname.Location = New System.Drawing.Point(51, 173)
        Me.Lblcname.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblcname.Name = "Lblcname"
        Me.Lblcname.Size = New System.Drawing.Size(263, 40)
        Me.Lblcname.TabIndex = 1
        Me.Lblcname.Text = "Customer Name :-"
        '
        'Lblcid
        '
        Me.Lblcid.AutoSize = True
        Me.Lblcid.Font = New System.Drawing.Font("Arial Unicode MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lblcid.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Lblcid.Location = New System.Drawing.Point(99, 113)
        Me.Lblcid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblcid.Name = "Lblcid"
        Me.Lblcid.Size = New System.Drawing.Size(212, 40)
        Me.Lblcid.TabIndex = 0
        Me.Lblcid.Text = "Customer ID :-"
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnReset.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.Maroon
        Me.BtnReset.Location = New System.Drawing.Point(846, 81)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(159, 66)
        Me.BtnReset.TabIndex = 10
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'BtnLast
        '
        Me.BtnLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnLast.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLast.ForeColor = System.Drawing.Color.Maroon
        Me.BtnLast.Location = New System.Drawing.Point(846, 529)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(173, 51)
        Me.BtnLast.TabIndex = 19
        Me.BtnLast.Text = "Last"
        Me.BtnLast.UseVisualStyleBackColor = False
        '
        'BtnFirst
        '
        Me.BtnFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnFirst.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFirst.ForeColor = System.Drawing.Color.Maroon
        Me.BtnFirst.Location = New System.Drawing.Point(234, 529)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(173, 51)
        Me.BtnFirst.TabIndex = 16
        Me.BtnFirst.Text = "First"
        Me.BtnFirst.UseVisualStyleBackColor = False
        '
        'BtnPrevious
        '
        Me.BtnPrevious.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnPrevious.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrevious.ForeColor = System.Drawing.Color.Maroon
        Me.BtnPrevious.Location = New System.Drawing.Point(641, 529)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(173, 51)
        Me.BtnPrevious.TabIndex = 17
        Me.BtnPrevious.Text = "Previous"
        Me.BtnPrevious.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnNext.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNext.ForeColor = System.Drawing.Color.Maroon
        Me.BtnNext.Location = New System.Drawing.Point(425, 529)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(173, 51)
        Me.BtnNext.TabIndex = 18
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnDelete.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.Maroon
        Me.BtnDelete.Location = New System.Drawing.Point(846, 153)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(159, 66)
        Me.BtnDelete.TabIndex = 12
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnUpdate.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.Maroon
        Me.BtnUpdate.Location = New System.Drawing.Point(672, 81)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(159, 66)
        Me.BtnUpdate.TabIndex = 9
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnEdit.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.Maroon
        Me.BtnEdit.Location = New System.Drawing.Point(672, 153)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(159, 66)
        Me.BtnEdit.TabIndex = 11
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnAdd.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.Maroon
        Me.BtnAdd.Location = New System.Drawing.Point(383, 420)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(159, 66)
        Me.BtnAdd.TabIndex = 8
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSearch.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSearch.Location = New System.Drawing.Point(672, 225)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(159, 66)
        Me.BtnSearch.TabIndex = 13
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnSave.Font = New System.Drawing.Font("Arial Unicode MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Maroon
        Me.BtnSave.Location = New System.Drawing.Point(846, 225)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(159, 66)
        Me.BtnSave.TabIndex = 15
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Frmcustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1253, 600)
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
        Me.Controls.Add(Me.Txtcmobile)
        Me.Controls.Add(Me.Txtcaddr)
        Me.Controls.Add(Me.Txtcname)
        Me.Controls.Add(Me.Txtcid)
        Me.Controls.Add(Me.Lblcmobile)
        Me.Controls.Add(Me.Lblcaddr)
        Me.Controls.Add(Me.Lblcname)
        Me.Controls.Add(Me.Lblcid)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frmcustomer"
        Me.Text = "customer"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtcmobile As TextBox
    Friend WithEvents Txtcaddr As TextBox
    Friend WithEvents Txtcname As TextBox
    Friend WithEvents Txtcid As TextBox
    Friend WithEvents Lblcmobile As Label
    Friend WithEvents Lblcaddr As Label
    Friend WithEvents Lblcname As Label
    Friend WithEvents Lblcid As Label
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
