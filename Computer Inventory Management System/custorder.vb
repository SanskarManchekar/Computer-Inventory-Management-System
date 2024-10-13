﻿Imports System.Data.OleDb
Public Class Frmcustorder
    Dim con As OleDbConnection
    Dim dtclient, dtclservice As DataTable
    Dim cmd As OleDbCommand

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        btndisabled()
        BtnSave.Enabled = True
        BtnReset.Enabled = True
        Txtcoid.Text = ""
        CmbCid.Text = ""
        DateTimePicker1.Value = Now
        CmbCid.Enabled = True
        DateTimePicker1.Enabled = True
        CmbCid.Focus()
    End Sub

    Private Sub clear_binding()
        Txtcoid.DataBindings.Clear()
        CmbCid.DataBindings.Clear()
        DateTimePicker1.DataBindings.Clear()
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
        If CmbCid.Text = "" Then
            MsgBox("Please Select Customer")
            CmbCid.Focus()
            Exit Sub
        End If
        Dim str As String
        Try
            con.Open()
            str = "INSERT into custorder(cid,odate) VALUES (" & CmbCid.SelectedValue & ",'" & DateTimePicker1.Value & "')"
            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()

            con.Close()
            MsgBox("Record Inserted Successfully", MsgBoxStyle.Information, "Save")



            clear_binding()
            Frmcustorder_Load(sender, e)


            btnenabled()

        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Btnfirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        Me.BindingContext(dtclservice).Position = 0
    End Sub

    Private Sub Btnnext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Me.BindingContext(dtclservice).Position += 1
    End Sub

    Private Sub Btnprevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        Me.BindingContext(dtclservice).Position -= 1
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        Me.BindingContext(dtclservice).Position = dtclservice.Rows.Count - 1
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            Dim oid As Integer
            oid = Val(InputBox("Please enter customer order id"))

            For i As Integer = 0 To dtclservice.Rows.Count - 1
                If dtclservice.Rows(i)("coid") = oid Then
                    Me.BindingContext(dtclservice).Position = i
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
        Frmcustorder_Load(sender, e)

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim str As String

        Try

            If MsgBox("Are you sure you want to delete selected record?", vbYesNo + vbCritical) = vbNo Then
                Exit Sub
            End If
            str = "DELETE FROM custorder WHERE coid = " & dtclservice.Rows(Me.BindingContext(dtclservice).Position)("coid")
            con.Open()

            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Record Deleted Successfully", MsgBoxStyle.Information, "DELETE")

            clear_binding()
            Frmcustorder_Load(sender, e)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Btnedit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        btndisabled()

        BtnUpdate.Enabled = True
        CmbCid.Enabled = True
        DateTimePicker1.Enabled = True

        CmbCid.Focus()
    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim str As String
        If CmbCid.Text = "" Then
            MsgBox("Please Select customer")
            CmbCid.Focus()
            Exit Sub
        End If

        Try
            con.Open()
            str = "UPDATE custorder SET cid=" & CmbCid.SelectedValue & ", odate = '" & DateTimePicker1.Text & "' WHERE coid = " & dtclservice.Rows(Me.BindingContext(dtclservice).Position)("coid")


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

    Private Sub Frmcustorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtclient = New DataTable("customer")
            dtclservice = New DataTable("clservice")
            con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=inventory.mdb;")
            con.Open()
            Dim selectQuery As String = "SELECT * FROM customer"
            Dim DataAdapter As New OleDbDataAdapter(selectQuery, con)
            DataAdapter.Fill(dtclient)

            CmbCid.ValueMember = "cid"
            CmbCid.DisplayMember = "cname"
            CmbCid.DataSource = dtclient

            selectQuery = "SELECT * FROM custorder"
            DataAdapter = New OleDbDataAdapter(selectQuery, con)
            DataAdapter.Fill(dtclservice)
            If dtclservice.Rows.Count > 0 Then
                Txtcoid.DataBindings.Add("Text", dtclservice, "coid")
                CmbCid.DataBindings.Add("SelectedValue", dtclservice, "cid")
                DateTimePicker1.DataBindings.Add("Text", dtclservice, "odate")
            End If
            CmbCid.Enabled = False
            DateTimePicker1.Enabled = False
            btnenabled()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub
End Class