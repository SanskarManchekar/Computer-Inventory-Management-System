Imports System.ComponentModel
Imports System.Data.OleDb
Public Class Frmcustomer
    Dim con As OleDbConnection
    Dim dtclient As DataTable
    Dim cmd As OleDbCommand
    Private Sub FrmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtclient = New DataTable("customer")
            con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=inventory.mdb;")
            con.Open()
            Dim selectQuery As String = "SELECT * FROM customer"
            Dim DataAdapter As New OleDbDataAdapter(selectQuery, con)
            DataAdapter.Fill(dtclient)

            Txtcid.DataBindings.Add("Text", dtclient, "cid")
            Txtcname.DataBindings.Add("Text", dtclient, "cname")
            Txtcmobile.DataBindings.Add("Text", dtclient, "cmobile")
            Txtcaddr.DataBindings.Add("Text", dtclient, "caddr")

            Txtcname.Enabled = False
            Txtcaddr.Enabled = False
            Txtcmobile.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Txtcid.Text = ""
        Txtcname.Text = ""
        Txtcmobile.Text = ""
        Txtcaddr.Text = ""



        btndisabled()
        BtnSave.Enabled = True
        BtnReset.Enabled = True
        Txtcname.Enabled = True
        Txtcaddr.Enabled = True
        Txtcmobile.Enabled = True
        Txtcname.Focus()
        Txtcid.Text = ""
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

    Private Function IsValidForm() As Boolean
        If Txtcname.Text = "" Then
            MsgBox("Please enter Customer name")
            Txtcname.Focus()
            Return False
        ElseIf IsNumeric(Txtcname.Text) Then
            MsgBox("Please enter alphabets only for Customer name")
            Txtcname.Focus()
            Return False
        ElseIf Txtcaddr.Text = "" Then
            MsgBox("Please enter address")
            Txtcaddr.Focus()
            Return False
        ElseIf Txtcmobile.Text = "" Then
            MsgBox("Please enter mobile number")
            Txtcmobile.Focus()
            Return False
        ElseIf Len(Txtcmobile.Text) <> 10 Then
            MsgBox("Please enter 10 digit mobile number")
            Txtcmobile.Focus()
            Return False
        ElseIf Not IsNumeric(Txtcmobile.Text) Then
            MsgBox("Please enter numeric mobile number")
            Txtcmobile.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub clear_binding()
        Txtcid.DataBindings.Clear()
        Txtcname.DataBindings.Clear()
        Txtcmobile.DataBindings.Clear()
        Txtcaddr.DataBindings.Clear()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not IsValidForm() Then
            Exit Sub
        End If

        Dim str As String
        Try
            str = "INSERT into customer( cname,  cmobile,caddr) VALUES ('" & Txtcname.Text & "'," & CType(Txtcmobile.Text, Decimal) & ",'" & Txtcaddr.Text & "')"
            con.Open()
            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()

            con.Close()
            MsgBox("Record Inserted Successfully", MsgBoxStyle.Information, "Save")

            clear_binding()
            FrmCustomer_Load(sender, e)


            btnenabled()

        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Me.BindingContext(dtclient).Position += 1
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        Me.BindingContext(dtclient).Position -= 1
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        Me.BindingContext(dtclient).Position = dtclient.Rows.Count - 1
    End Sub

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        Me.BindingContext(dtclient).Position = 0
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        btndisabled()
        BtnUpdate.Enabled = True
        Txtcname.Enabled = True
        Txtcaddr.Enabled = True
        Txtcmobile.Enabled = True
        Txtcname.Focus()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        clear_binding()
        btnenabled()
        FrmCustomer_Load(sender, e)


    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim str As String

        If Not IsValidForm() Then
            Exit Sub
        End If

        Try
            str = "UPDATE customer SET cname = '" & Txtcname.Text & "' ,caddr = '" & Txtcaddr.Text & "', cmobile=" & Txtcmobile.Text & " WHERE cid = " & dtclient.Rows(Me.BindingContext(dtclient).Position)("cid")
            con.Open()

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

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim str As String
        Try
            If MsgBox("Are you sure you want to delete selected record?", vbYesNo + vbCritical) = vbNo Then
                Exit Sub
            End If
            str = "DELETE FROM customer WHERE cid = " & dtclient.Rows(Me.BindingContext(dtclient).Position)("cid")
            con.Open()

            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()

            con.Close()
            MsgBox("Record Deleted Successfully", MsgBoxStyle.Information, "DELETE")

            clear_binding()
            FrmCustomer_Load(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            Dim cname As String
            cname = InputBox("Please enter customer name to search")

            For i As Integer = 0 To dtclient.Rows.Count - 1
                If UCase(dtclient.Rows(i)("cname")) = UCase(cname) Then
                    Me.BindingContext(dtclient).Position = i
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

    Private Sub Txtcmobile_TextChanged(sender As Object, e As EventArgs) Handles Txtcname.TextChanged

    End Sub



    Private Sub Txtcname_Validating(sender As Object, e As CancelEventArgs) Handles Txtcname.Validating
        If (Txtcname.Text = "") Then
            e.Cancel = True
            ErrorProvider1.SetError(Txtcname, "Please enter the customer name")
        End If
    End Sub

    Private Sub Txtcname_Validated(sender As Object, e As EventArgs) Handles Txtcname.Validated
        ErrorProvider1.SetError(Txtcname, "")
    End Sub
End Class
