Imports System.Data.OleDb
Public Class Frmcustorderdetails
    Dim con As OleDbConnection
    Dim dtcustorderdetails, dtcustorder, dtitem As DataTable
    Dim cmd As OleDbCommand

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        btndisabled()
        BtnSave.Enabled = True
        BtnReset.Enabled = True
        Txtcodid.Text = ""
        Cmbcoid.Text = ""
        Cmbiid.Text = ""
        Txtqty.Text = ""
        Cmbcoid.Enabled = True
        Cmbiid.Enabled = True
        Txtqty.Enabled = True

        clear_binding()
        Cmbcoid.Focus()
    End Sub

    Private Sub clear_binding()
        Txtcodid.DataBindings.Clear()
        Cmbcoid.DataBindings.Clear()
        Cmbiid.DataBindings.Clear()
        Txtqty.DataBindings.Clear()

    End Sub
    Private Sub btndisabled()
        BtnEdit.Enabled = False
        BtnUpdate.Enabled = False
        BtnAdd.Enabled = False
        BtnSave.Enabled = False
        BtnDelete.Enabled = False

        BtnNext.Enabled = False
        BtnPrevious.Enabled = False
        BtnLast.Enabled = False
        BtnFirst.Enabled = False
        BtnSearch.Enabled = False

    End Sub

    Private Sub btnenabled()
        BtnEdit.Enabled = True
        BtnUpdate.Enabled = True
        BtnAdd.Enabled = True
        BtnSave.Enabled = True
        BtnDelete.Enabled = True

        BtnNext.Enabled = True
        BtnPrevious.Enabled = True
        BtnLast.Enabled = True
        BtnFirst.Enabled = True
        BtnSearch.Enabled = True

    End Sub
    Private Sub Btnsave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Cmbcoid.Text = "" Then
            MsgBox("Please Select Item ID")
            Cmbcoid.Focus()
        ElseIf Cmbiid.Text = "" Then
            MsgBox("Please Select Item Name")
            Cmbiid.Focus()
            Exit Sub
        End If
        Dim str As String
        Try
            con.Open()
            str = "INSERT INTO custorderdetails(coid,iid,qty) VALUES (" & Cmbcoid.SelectedValue & "," & Cmbiid.SelectedValue & "," & Txtqty.Text & ")"
            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()

            con.Close()
            MsgBox("Record Inserted Successfully", MsgBoxStyle.Information, "Save")



            clear_binding()
            Frmcustorderdetails_Load(sender, e)


            btnenabled()

        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Btnfirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        Me.BindingContext(dtcustorderdetails).Position = 0
    End Sub

    Private Sub Btnnext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Me.BindingContext(dtcustorderdetails).Position += 1
    End Sub

    Private Sub Btnprevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        Me.BindingContext(dtcustorderdetails).Position -= 1
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        Me.BindingContext(dtcustorderdetails).Position = dtcustorderdetails.Rows.Count - 1
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            Dim oid As Integer
            oid = Val(InputBox("Please enter customer order details id"))

            For i As Integer = 0 To dtcustorderdetails.Rows.Count - 1
                If dtcustorderdetails.Rows(i)("codid") = oid Then
                    Me.BindingContext(dtcustorderdetails).Position = i
                    MsgBox("Record found", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Next

            MsgBox("Record not found", MsgBoxStyle.Critical)

        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        clear_binding()
        Frmcustorderdetails_Load(sender, e)

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim str As String

        Try

            If MsgBox("Are you sure you want to delete selected record?", vbYesNo + vbCritical) = vbNo Then
                Exit Sub
            End If
            str = "DELETE FROM custorderdetails WHERE codid = " & dtcustorderdetails.Rows(Me.BindingContext(dtcustorderdetails).Position)("codid")
            con.Open()

            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Record Deleted Successfully", MsgBoxStyle.Information, "DELETE")

            clear_binding()
            Frmcustorderdetails_Load(sender, e)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Btnedit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        btndisabled()

        BtnUpdate.Enabled = True
        Cmbcoid.Enabled = True
        Cmbiid.Enabled = True
        Txtqty.Enabled = True

        Cmbcoid.Focus()
        Cmbiid.Focus()
    End Sub

    Private Sub Txtcodid_TextChanged(sender As Object, e As EventArgs) Handles Txtcodid.TextChanged

    End Sub

    Private Sub Cmbcoid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbcoid.SelectedIndexChanged

    End Sub

    Private Sub Cmbiid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbiid.SelectedIndexChanged

    End Sub

    Private Sub Txtqty_TextChanged(sender As Object, e As EventArgs) Handles Txtqty.TextChanged

    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim str As String
        If Cmbcoid.Text = "" And Cmbiid.Text = "" Then
            MsgBox("Please Select customer Order ID And Item ID")
            Cmbcoid.Focus()
            Cmbiid.Focus()
            Exit Sub
        End If

        Try
            con.Open()
            str = "UPDATE custorderdetails SET coid=" & Cmbcoid.SelectedValue & ",'iid=" & Cmbiid.SelectedValue & ", qty=" & Txtqty.Text & "' WHERE codid = " & dtcustorderdetails.Rows(Me.BindingContext(dtcustorderdetails).Position)("codid")


            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()
            MsgBox("Record Updated Successfully", MsgBoxStyle.Information, "Update")
            con.Close()
            BtnDelete.Enabled = True


        Catch ep As Exception
            MsgBox(ep.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Frmcustorderdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtcustorderdetails = New DataTable("custorderdetails")
            dtcustorder = New DataTable("custorder")
            dtitem = New DataTable("item")
            con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=inventory.mdb;")
            con.Open()
            Dim selectQuery As String = "SELECT * FROM custorder"
            Dim DataAdapter As New OleDbDataAdapter(selectQuery, con)
            DataAdapter.Fill(dtcustorder)

            Cmbcoid.ValueMember = "coid"
            Cmbcoid.DisplayMember = "coid"
            Cmbcoid.DataSource = dtcustorder

            selectQuery = "SELECT * FROM item"
            DataAdapter = New OleDbDataAdapter(selectQuery, con)
            DataAdapter.Fill(dtitem)

            Cmbiid.ValueMember = "iid"
            Cmbiid.DisplayMember = "iname"
            Cmbiid.DataSource = dtitem

            selectQuery = "SELECT * FROM custorderdetails"
            DataAdapter = New OleDbDataAdapter(selectQuery, con)
            DataAdapter.Fill(dtcustorderdetails)

            If dtcustorderdetails.Rows.Count > 0 Then
                Txtcodid.DataBindings.Add("Text", dtcustorderdetails, "codid")
                Cmbcoid.DataBindings.Add("SelectedValue", dtcustorderdetails, "coid")
                Cmbiid.DataBindings.Add("SelectedValue", dtcustorderdetails, "iid")
                Txtqty.DataBindings.Add("Text", dtcustorderdetails, "qty")
            End If
            Cmbcoid.Enabled = False
            Cmbiid.Enabled = False
            Txtqty.Enabled = False
            btnenabled()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

End Class