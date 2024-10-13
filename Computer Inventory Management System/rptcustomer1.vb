Imports System.Data.OleDb
Public Class rptcustomer1
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

    Private Sub rptcustomer1_Load(sender As Object, e As EventArgs) Handles Me.Load
        dt = New DataTable
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=inventory.mdb;")
        con.Open()

        If str = "stock" Then
            selectCommand = "select * from item"

            Dim da As New OleDbDataAdapter(selectCommand, con)
            da.Fill(dt)

            '    Dim rpt As New stockrpt
            '    rpt.SetDataSource(dt)
            '    CrystalReportViewer1.ReportSource = rpt
            'ElseIf str = "client" Then
            '    selectCommand = "select * from client"

            '    Dim da As New OleDbDataAdapter(selectCommand, con)
            '    da.Fill(dt)

            '    Dim rpt As New clientrpt
            '    rpt.SetDataSource(dt)
            '    CrystalReportViewer1.ReportSource = rpt
            'Else
            '    selectCommand = "select billid,corder.orderid,cname,prodname, proddesc,grossamt,billdate from client,product,corder,clientbill where client.clientid=corder.custid and product.prodid=corder.prodid and corder.orderid=clientbill.orderid and billid=" & CInt(str)

            '    Dim da As New OleDbDataAdapter(selectCommand, con)
            '    da.Fill(dt)
            '    Dim rpt As New rptcustomer
            '    'Dim rpt As New CrystalReport1
            '    rpt.SetDataSource(dt)
            '    CrystalReportViewer1.ReportSource = rpt


        End If

    End Sub
End Class