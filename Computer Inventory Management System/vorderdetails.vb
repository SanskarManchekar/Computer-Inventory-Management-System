Imports System.Data.OleDb
Public Class Frmvorderdetails
    Dim con As OleDbConnection
    Dim dtvorderdetails, dtvorder, dtitem As DataTable
    Dim cmd As OleDbCommand

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        btndisabled()
        BtnSave.Enabled = True
        BtnReset.Enabled = True
        Txtvoidd.Text = ""
        Cmbvoid.Text = ""
        Cmbiid.Text = ""
        Txtqty.Text = ""
        Cmbvoid.Enabled = True
        Cmbiid.Enabled = True
        Txtqty.Enabled = True

        clear_binding()
        Cmbvoid.Focus()
    End Sub

    Private Sub clear_binding()
        Txtvoidd.DataBindings.Clear()
        Cmbvoid.DataBindings.Clear()
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
        If Cmbvoid.Text = "" Then
            MsgBox("Please Select Vendor ID")
            Cmbvoid.Focus()
        ElseIf Cmbiid.Text = "" Then
            MsgBox("Please Select Vendor Name")
            Cmbiid.Focus()
            Exit Sub
        End If
        Dim str As String
        Try
            con.Open()
            str = "INSERT INTO vorderdetails(void,iid,qty) VALUES (" & Cmbvoid.SelectedValue & "," & Cmbiid.SelectedValue & "," & Txtqty.Text & ")"
            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()

            con.Close()
            MsgBox("Record Inserted Successfully", MsgBoxStyle.Information, "Save")



            clear_binding()
            Frmvorderdetails_Load(sender, e)


            btnenabled()

        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Btnfirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        Me.BindingContext(dtvorderdetails).Position = 0
    End Sub

    Private Sub Btnnext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Me.BindingContext(dtvorderdetails).Position += 1
    End Sub

    Private Sub Btnprevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        Me.BindingContext(dtvorderdetails).Position -= 1
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        Me.BindingContext(dtvorderdetails).Position = dtvorderdetails.Rows.Count - 1
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            Dim oid As Integer
            oid = Val(InputBox("Please enter vendor order details id"))

            For i As Integer = 0 To dtvorderdetails.Rows.Count - 1
                If dtvorderdetails.Rows(i)("voidd") = oid Then
                    Me.BindingContext(dtvorderdetails).Position = i
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
        Frmvorderdetails_Load(sender, e)

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim str As String

        Try

            If MsgBox("Are you sure you want to delete selected record?", vbYesNo + vbCritical) = vbNo Then
                Exit Sub
            End If
            str = "DELETE FROM vorderdetails WHERE voidd = " & dtvorderdetails.Rows(Me.BindingContext(dtvorderdetails).Position)("voidd")
            con.Open()

            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Record Deleted Successfully", MsgBoxStyle.Information, "DELETE")

            clear_binding()
            Frmvorderdetails_Load(sender, e)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Btnedit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        btndisabled()

        BtnUpdate.Enabled = True
        Cmbvoid.Enabled = True
        Cmbiid.Enabled = True
        Txtqty.Enabled = True

        Cmbvoid.Focus()
        Cmbiid.Focus()
    End Sub

    Private Sub Txtcodid_TextChanged(sender As Object, e As EventArgs) Handles Txtvoidd.TextChanged

    End Sub

    Private Sub Cmbcoid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbvoid.SelectedIndexChanged

    End Sub

    Private Sub Cmbiid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmbiid.SelectedIndexChanged

    End Sub

    Private Sub Txtqty_TextChanged(sender As Object, e As EventArgs) Handles Txtqty.TextChanged

    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim str As String
        If Cmbvoid.Text = "" And Cmbiid.Text = "" Then
            MsgBox("Please Select vendor Order ID ")
            Cmbvoid.Focus()
            Cmbiid.Focus()
            Exit Sub
        End If

        Try
            con.Open()
            str = "UPDATE vorderdetails SET void=" & Cmbvoid.SelectedValue & ",'iid=" & Cmbiid.SelectedValue & ", qty=" & Txtqty.Text & "' WHERE voidd = " & dtvorderdetails.Rows(Me.BindingContext(dtvorderdetails).Position)("voidd")


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

    Private Sub Frmvorderdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtvorderdetails = New DataTable("vorderdetails")
            dtvorder = New DataTable("vorder")
            dtitem = New DataTable("item")
            con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=inventory.mdb;")
            con.Open()
            Dim selectQuery As String = "SELECT * FROM vorder"
            Dim DataAdapter As New OleDbDataAdapter(selectQuery, con)
            DataAdapter.Fill(dtvorder)

            Cmbvoid.ValueMember = "void"
            Cmbvoid.DisplayMember = "void"
            Cmbvoid.DataSource = dtvorder

            selectQuery = "SELECT * FROM item"
            DataAdapter = New OleDbDataAdapter(selectQuery, con)
            DataAdapter.Fill(dtitem)

            Cmbiid.ValueMember = "iid"
            Cmbiid.DisplayMember = "iname"
            Cmbiid.DataSource = dtitem

            selectQuery = "SELECT * FROM vorderdetails"
            DataAdapter = New OleDbDataAdapter(selectQuery, con)
            DataAdapter.Fill(dtvorderdetails)

            If dtvorderdetails.Rows.Count > 0 Then
                Txtvoidd.DataBindings.Add("Text", dtvorderdetails, "voidd")
                Cmbvoid.DataBindings.Add("SelectedValue", dtvorderdetails, "void")
                Cmbiid.DataBindings.Add("SelectedValue", dtvorderdetails, "iid")
                Txtqty.DataBindings.Add("Text", dtvorderdetails, "qty")
            End If
            Cmbvoid.Enabled = False
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