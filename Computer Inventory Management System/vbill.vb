Imports System.Data.OleDb
Public Class Frmvbill
    Dim con As OleDbConnection
    Dim dtvorder As DataTable
    Dim DTCoBill As DataTable
    Dim DTvorderdetails As DataTable
    Dim cmd As OleDbCommand
    Dim rate As Double

    Private Sub Frmvbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            dtvorder = New DataTable("vbill")
            DTCoBill = New DataTable("item")
            DTvorderdetails = New DataTable("vorderdetails")
            con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=inventory.mdb;")
            con.Open()
            Dim selectQuery As String = "SELECT * FROM vorder"
            Dim DataAdapter As New OleDbDataAdapter(selectQuery, con)
            DataAdapter.Fill(dtvorder)

            Cmbvoid.ValueMember = "void"
            Cmbvoid.DisplayMember = "void"
            Cmbvoid.DataSource = dtvorder

            Dim selectPackageBookingInfo As String = "SELECT * FROM vbill order by billid"
            DataAdapter = New OleDbDataAdapter(selectPackageBookingInfo, con)
            DataAdapter.Fill(DTCoBill)

            'EmptyTextFields()
            BtnAdd.Enabled = True
            Txtbillid.DataBindings.Add("Text", DTCoBill, "billid")
            Cmbvoid.DataBindings.Add("SelectedValue", DTCoBill, "void")
            Txtamt.DataBindings.Add("Text", DTCoBill, "amt")
            Txttax.DataBindings.Add("Text", DTCoBill, "tax")
            Txtfamt.DataBindings.Add("Text", DTCoBill, "famt")

            DateTimePicker1.DataBindings.Add("Text", DTCoBill, "bdate")


            con.Close()

            BtnSave.Enabled = False
            'btnUpdate.Enabled = False

            disablecontrol()
            'Btnfirst_Click(sender, e)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub cmbcoid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbvoid.SelectedIndexChanged
        Dim dtCoBill As New DataTable("cobill")
        Try
            If Cmbvoid.Text <> "" Then
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                Dim selectCoBill As String = "SELECT price,qty FROM vorderdetails, item where item.iid=vorderdetails.iid and void=" & Cmbvoid.SelectedValue
                Dim DataAdapter As New OleDbDataAdapter(selectCoBill, con)
                DataAdapter.Fill(dtCoBill)
                Dim amt As Integer
                If dtCoBill.Rows.Count > 0 Then
                    For index = 0 To dtCoBill.Rows.Count - 1
                        amt = amt + dtCoBill.Rows(index)(0) * dtCoBill.Rows(index)(1)
                    Next

                    Txtamt.Text = amt
                    Txttax.Text = amt * 0.18
                    Txtfamt.Text = Val(Txtamt.Text) + Val(Txttax.Text)
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        EmptyTextFields()
        Cmbvoid.Focus()
        enablecontrol()
        clear_binding()
    End Sub
    Private Sub EmptyTextFields()
        Cmbvoid.Text = ""
        Txtamt.Text = ""
        Txttax.Text = ""
        Txtfamt.Text = ""

        BtnAdd.Enabled = False
        BtnSave.Enabled = True
        BtnDelete.Enabled = False
    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReset.Click
        clear_binding()
        Frmvbill_Load(sender, e)

        BtnAdd.Enabled = True
        BtnEdit.Enabled = True
    End Sub
    Private Sub clear_binding()
        Txtbillid.DataBindings.Clear()
        Cmbvoid.DataBindings.Clear()

        Txtamt.DataBindings.Clear()
        Txttax.DataBindings.Clear()
        Txtfamt.DataBindings.Clear()
        DateTimePicker1.DataBindings.Clear()
    End Sub

    Private Function IsValidForm() As Boolean
        If Cmbvoid.Text = "" Then
            MsgBox("Please select vendor order id")
            Cmbvoid.Focus()
            Return False

        Else
            Return True
        End If

    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If Not IsValidForm() Then
            Exit Sub
        End If

        Dim str As String
        Try
            str = "INSERT INTO vbill(void, amt, tax, famt, bdate) VALUES (" & Cmbvoid.SelectedValue & "," & CType(Txtamt.Text, Decimal) & "," & CType(Txttax.Text, Decimal) & "," & CType(Txtfamt.Text, Decimal) & ",'" & DateTimePicker1.Value & "')"
            con.Open()
            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()

            con.Close()
            MsgBox("Record Inserted Successfully", MsgBoxStyle.Information, "Save")
            clear_binding()
            Frmvbill_Load(sender, e)

            BtnAdd.Enabled = True
            BtnEdit.Enabled = True
            BtnDelete.Enabled = True

            disablecontrol()
        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Btnfirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        Me.BindingContext(DTCoBill).Position = 0
    End Sub

    Private Sub Btnlast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        Me.BindingContext(DTCoBill).Position = DTCoBill.Rows.Count - 1
    End Sub

    Private Sub Btnprevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevious.Click
        Me.BindingContext(DTCoBill).Position -= 1
    End Sub

    Private Sub Btnnext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        Me.BindingContext(DTCoBill).Position += 1
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Cmbvoid.Focus()
        BtnUpdate.Enabled = True
        enablecontrol()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String

        If Not IsValidForm() Then
            Exit Sub
        End If

        Try
            str = "UPDATE vbill SET billid = " & Cmbvoid.SelectedValue & ",amt = " & CType(Txtamt.Text, Decimal) & " ,tax = " & CType(Txttax.Text, Decimal) & " ,famt= " & CType(Txtfamt.Text, Decimal) & ",bdate = '" & DateTimePicker1.Value & "' WHERE vbill = " & DTCoBill.Rows(Me.BindingContext(DTCoBill).Position)("billid")
            con.Open()

            cmd = New OleDbCommand(str, con)
            MsgBox("Record Updated Successfully", MsgBoxStyle.Information, "Update")
            con.Close()
            BtnDelete.Enabled = True

            disablecontrol()
        Catch ep As Exception
            MsgBox(ep.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dim str As String

        Try

            If MsgBox("Are you sure you want to delete selected record?", vbYesNo + vbCritical) = vbNo Then
                Exit Sub
            End If
            str = "DELETE FROM vbill WHERE billid = " & DTCoBill.Rows(Me.BindingContext(DTCoBill).Position)("billid")
            con.Open()

            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Record Deleted Successfully", MsgBoxStyle.Information, "DELETE")
            clear_binding()
            Frmvbill_Load(sender, e)

            disablecontrol()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Try
            Dim CoBillno As Integer
            CoBillno = Val(InputBox("Please enter vendor bill no"))

            For i As Integer = 0 To DTCoBill.Rows.Count - 1
                If DTCoBill.Rows(i)("billid") = CoBillno Then
                    Me.BindingContext(DTCoBill).Position = i
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

    Private Sub enablecontrol()
        Cmbvoid.Enabled = True
        Txtamt.Enabled = True
        Txttax.Enabled = True
        Txtfamt.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub

    Private Sub disablecontrol()
        Cmbvoid.Enabled = False
        Txtamt.Enabled = False
        Txttax.Enabled = False
        Txtfamt.Enabled = False
        DateTimePicker1.Enabled = False
    End Sub


End Class