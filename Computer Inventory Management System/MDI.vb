
Public Class MDI


    Private Sub VENDORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENDORToolStripMenuItem.Click
        Dim myform As New FrmVendor
        myform.MdiParent = Me
        myform.Show()

    End Sub
    Private Sub ITEMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ITEMToolStripMenuItem.Click
        Dim myform As New FrmItem
        myform.MdiParent = Me
        myform.Show()
    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        End
    End Sub

    Private Sub MDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CUSTOMERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERToolStripMenuItem.Click
        Dim myform As New Frmcustomer
        myform.MdiParent = Me
        myform.Show()
    End Sub

    Private Sub CUSTOMERORDERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERORDERToolStripMenuItem.Click
        Dim myform As New Frmcustorder
        myform.MdiParent = Me
        myform.Show()
    End Sub

    Private Sub VENDORORDERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENDORORDERToolStripMenuItem.Click
        Dim myform As New Frmvorder
        myform.MdiParent = Me
        myform.Show()
    End Sub

    Private Sub CUSTOMERORDERDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERORDERDETAILSToolStripMenuItem.Click
        Dim myform As New Frmcustorderdetails
        myform.MdiParent = Me
        myform.Show()
    End Sub

    Private Sub CUSTOMERBILLToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERBILLToolStripMenuItem.Click
        Dim myform As New Frmcustbill
        myform.MdiParent = Me
        myform.Show()
    End Sub

    Private Sub CUSTOMERREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CUSTOMERREPORTToolStripMenuItem.Click
        Dim c As New rptcustomer2("customer")
        c.MdiParent = Me
        c.Show()


    End Sub

    Private Sub VENDORREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENDORREPORTToolStripMenuItem.Click
        Dim c As New rptcustomer2("vendor")
        c.MdiParent = Me
        c.Show()
    End Sub

    Private Sub ITEMREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ITEMREPORTToolStripMenuItem.Click
        Dim c As New rptcustomer2("item")
        c.MdiParent = Me
        c.Show()
    End Sub
End Class
