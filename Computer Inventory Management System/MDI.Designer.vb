<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDI
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MAINFORMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUSTOMERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VENDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ITEMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSACTIONFORMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUSTOMERORDERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VENDORORDERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUSTOMERORDERDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUSTOMERBILLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CUSTOMERREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VENDORREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ITEMREPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MAINFORMSToolStripMenuItem, Me.TRANSACTIONFORMSToolStripMenuItem, Me.REPORTSToolStripMenuItem, Me.EXITToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(981, 28)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MAINFORMSToolStripMenuItem
        '
        Me.MAINFORMSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CUSTOMERToolStripMenuItem, Me.VENDORToolStripMenuItem, Me.ITEMToolStripMenuItem})
        Me.MAINFORMSToolStripMenuItem.Name = "MAINFORMSToolStripMenuItem"
        Me.MAINFORMSToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.MAINFORMSToolStripMenuItem.Text = "MAIN FORMS"
        '
        'CUSTOMERToolStripMenuItem
        '
        Me.CUSTOMERToolStripMenuItem.Name = "CUSTOMERToolStripMenuItem"
        Me.CUSTOMERToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.CUSTOMERToolStripMenuItem.Text = "CUSTOMER"
        '
        'VENDORToolStripMenuItem
        '
        Me.VENDORToolStripMenuItem.Name = "VENDORToolStripMenuItem"
        Me.VENDORToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.VENDORToolStripMenuItem.Text = "VENDOR"
        '
        'ITEMToolStripMenuItem
        '
        Me.ITEMToolStripMenuItem.Name = "ITEMToolStripMenuItem"
        Me.ITEMToolStripMenuItem.Size = New System.Drawing.Size(159, 26)
        Me.ITEMToolStripMenuItem.Text = "ITEM"
        '
        'TRANSACTIONFORMSToolStripMenuItem
        '
        Me.TRANSACTIONFORMSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CUSTOMERORDERToolStripMenuItem, Me.VENDORORDERToolStripMenuItem, Me.CUSTOMERORDERDETAILSToolStripMenuItem, Me.CUSTOMERBILLToolStripMenuItem})
        Me.TRANSACTIONFORMSToolStripMenuItem.Name = "TRANSACTIONFORMSToolStripMenuItem"
        Me.TRANSACTIONFORMSToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.TRANSACTIONFORMSToolStripMenuItem.Text = "TRANSACTION FORMS "
        '
        'CUSTOMERORDERToolStripMenuItem
        '
        Me.CUSTOMERORDERToolStripMenuItem.Name = "CUSTOMERORDERToolStripMenuItem"
        Me.CUSTOMERORDERToolStripMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.CUSTOMERORDERToolStripMenuItem.Text = "CUSTOMER ORDER"
        '
        'VENDORORDERToolStripMenuItem
        '
        Me.VENDORORDERToolStripMenuItem.Name = "VENDORORDERToolStripMenuItem"
        Me.VENDORORDERToolStripMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.VENDORORDERToolStripMenuItem.Text = "VENDOR ORDER"
        '
        'CUSTOMERORDERDETAILSToolStripMenuItem
        '
        Me.CUSTOMERORDERDETAILSToolStripMenuItem.Name = "CUSTOMERORDERDETAILSToolStripMenuItem"
        Me.CUSTOMERORDERDETAILSToolStripMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.CUSTOMERORDERDETAILSToolStripMenuItem.Text = "CUSTOMER ORDER DETAILS"
        '
        'CUSTOMERBILLToolStripMenuItem
        '
        Me.CUSTOMERBILLToolStripMenuItem.Name = "CUSTOMERBILLToolStripMenuItem"
        Me.CUSTOMERBILLToolStripMenuItem.Size = New System.Drawing.Size(270, 26)
        Me.CUSTOMERBILLToolStripMenuItem.Text = "CUSTOMER BILL"
        '
        'REPORTSToolStripMenuItem
        '
        Me.REPORTSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CUSTOMERREPORTToolStripMenuItem, Me.VENDORREPORTToolStripMenuItem, Me.ITEMREPORTToolStripMenuItem})
        Me.REPORTSToolStripMenuItem.Name = "REPORTSToolStripMenuItem"
        Me.REPORTSToolStripMenuItem.Size = New System.Drawing.Size(81, 24)
        Me.REPORTSToolStripMenuItem.Text = "REPORTS"
        '
        'CUSTOMERREPORTToolStripMenuItem
        '
        Me.CUSTOMERREPORTToolStripMenuItem.Name = "CUSTOMERREPORTToolStripMenuItem"
        Me.CUSTOMERREPORTToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.CUSTOMERREPORTToolStripMenuItem.Text = "CUSTOMER REPORT"
        '
        'VENDORREPORTToolStripMenuItem
        '
        Me.VENDORREPORTToolStripMenuItem.Name = "VENDORREPORTToolStripMenuItem"
        Me.VENDORREPORTToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.VENDORREPORTToolStripMenuItem.Text = "VENDOR REPORT"
        '
        'ITEMREPORTToolStripMenuItem
        '
        Me.ITEMREPORTToolStripMenuItem.Name = "ITEMREPORTToolStripMenuItem"
        Me.ITEMREPORTToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.ITEMREPORTToolStripMenuItem.Text = "ITEM REPORT"
        '
        'EXITToolStripMenuItem
        '
        Me.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem"
        Me.EXITToolStripMenuItem.Size = New System.Drawing.Size(50, 24)
        Me.EXITToolStripMenuItem.Text = "EXIT"
        '
        'MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Computer_Inventory_Management_System.My.Resources.Resources.Inventory
        Me.ClientSize = New System.Drawing.Size(981, 569)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDI"
        Me.Text = "MDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MAINFORMSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CUSTOMERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TRANSACTIONFORMSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents REPORTSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EXITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VENDORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ITEMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CUSTOMERORDERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VENDORORDERToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CUSTOMERORDERDETAILSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CUSTOMERBILLToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CUSTOMERREPORTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VENDORREPORTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ITEMREPORTToolStripMenuItem As ToolStripMenuItem
End Class
