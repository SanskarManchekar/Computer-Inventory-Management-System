Imports System.Data.OleDb
Public Class rptcustomer2
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dt As DataTable
    Dim str As String
    Dim selectCommand As String

    Public Sub New(ByVal flag As String)
        str = flag
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmReport1_Load(sender As Object, e As EventArgs) Handles Me.Load
        dt = New DataTable
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=inventory.mdb;")
        con.Open()

        If str = "customer" Then
            selectCommand = "select * from customer"

            Dim da As New OleDbDataAdapter(selectCommand, con)
            da.Fill(dt)

            Dim rpt As New rptcustomer
            rpt.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rpt
        ElseIf str = "vendor" Then
            selectCommand = "select * from vendor"

            Dim da As New OleDbDataAdapter(selectCommand, con)
            da.Fill(dt)

            Dim rpt As New rptvendor

            rpt.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rpt
        ElseIf str = "item" Then
            selectCommand = "select * from item"

            Dim da As New OleDbDataAdapter(selectCommand, con)
            da.Fill(dt)

            Dim rpt As New rptitem

            rpt.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rpt
        Else
            selectCommand = "select billid,custbill.coid,cname,iname,amt,tax,famt,bdate from customer,custorderdetails,item,custorder,custbill where item.iid=custorderdetails.iid and customer.cname and customer.cid=custorder.cid and custorder.coid=custbill.coid and billid=" & CInt(str)

            Dim da As New OleDbDataAdapter(selectCommand, con)
            da.Fill(dt)
            Dim rpt As New rptcustbill
            'Dim rpt As New CrystalReport1
            rpt.SetDataSource(dt)
            CrystalReportViewer1.ReportSource = rpt


        End If

    End Sub
End Class