Imports System.ComponentModel
Imports System.Data.OleDb
Public Class FrmItem
    Dim con As OleDbConnection
    Dim dtclient As DataTable
    Dim cmd As OleDbCommand
    Private Sub FrmItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtclient = New DataTable("customer")
            con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=inventory.mdb;")
            con.Open()
            Dim selectQuery As String = "SELECT * FROM item"
            Dim DataAdapter As New OleDbDataAdapter(selectQuery, con)
            DataAdapter.Fill(dtclient)

            Txtiid.DataBindings.Add("Text", dtclient, "iid")
            Txtiname.DataBindings.Add("Text", dtclient, "iname")
            Txtprice.DataBindings.Add("Text", dtclient, "price")
            Txtstock.DataBindings.Add("Text", dtclient, "stock")

            Txtiname.Enabled = False
            Txtprice.Enabled = False
            Txtstock.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Txtiid.Text = ""
        Txtiname.Text = ""
        Txtprice.Text = ""
        Txtstock.Text = ""



        btndisabled()
        BtnSave.Enabled = True
        BtnReset.Enabled = True
        Txtiname.Enabled = True
        Txtprice.Enabled = True
        Txtstock.Enabled = True
        Txtiname.Focus()
        Txtiid.Text = ""
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
        If Txtiname.Text = "" Then
            MsgBox("Please enter item name")
            Txtiname.Focus()
            Return False
        ElseIf IsNumeric(Txtiname.Text) Then
            MsgBox("Please enter alphabets only for item name")
            Txtiname.Focus()
            Return False
        ElseIf Txtprice.Text = "" Then
            MsgBox("Please enter price")
            Txtprice.Focus()
            Return False
        ElseIf Txtstock.Text = "" Then
            MsgBox("Please enter stock entries")
            Txtstock.Focus()
            Return False
            'ElseIf Len(Txtstock.Text) <> 10 Then
            'MsgBox("Please enter 10 digit mobile number")
            'Txtstock.Focus()
            'Return False
        ElseIf Not IsNumeric(Txtstock.Text) Then
            MsgBox("Please enter numeric stock number")
            Txtstock.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub clear_binding()
        Txtiid.DataBindings.Clear()
        Txtiname.DataBindings.Clear()
        Txtprice.DataBindings.Clear()
        Txtstock.DataBindings.Clear()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not IsValidForm() Then
            Exit Sub
        End If

        Dim str As String
        Try
            str = "INSERT into item( iname,  stock,price) VALUES ('" & Txtiname.Text & "'," & CType(Txtstock.Text, Decimal) & ",'" & Txtprice.Text & "')"
            con.Open()
            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()

            con.Close()
            MsgBox("Record Inserted Successfully", MsgBoxStyle.Information, "Save")

            clear_binding()
            FrmItem_Load(sender, e)


            btnenabled()

        Catch Exp As Exception
            MsgBox(Exp.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
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
        Txtiname.Enabled = True
        Txtprice.Enabled = True
        Txtstock.Enabled = True
        Txtiname.Focus()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        clear_binding()
        btnenabled()
        FrmItem_Load(sender, e)


    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim str As String

        If Not IsValidForm() Then
            Exit Sub
        End If

        Try
            str = "UPDATE item SET iname = '" & Txtiname.Text & "' ,price = '" & Txtprice.Text & "', stock=" & Txtstock.Text & " WHERE iid = " & dtclient.Rows(Me.BindingContext(dtclient).Position)("iid")
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
            str = "DELETE FROM item WHERE iid = " & dtclient.Rows(Me.BindingContext(dtclient).Position)("iid")
            con.Open()

            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()

            con.Close()
            MsgBox("Record Deleted Successfully", MsgBoxStyle.Information, "DELETE")

            clear_binding()
            FrmItem_Load(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            Dim iname As String
            iname = InputBox("Please enter item name to search")

            For i As Integer = 0 To dtclient.Rows.Count - 1
                If UCase(dtclient.Rows(i)("iname")) = UCase(iname) Then
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

    Private Sub Txtstock_TextChanged(sender As Object, e As EventArgs) Handles Txtstock.TextChanged

    End Sub



    Private Sub Txtiname_Validating(sender As Object, e As CancelEventArgs) Handles Txtiname.Validating
        If (Txtiname.Text = "") Then
            e.Cancel = True
            ErrorProvider1.SetError(Txtiname, "Please enter the item name")
        End If
    End Sub

    Private Sub Txtcname_Validated(sender As Object, e As EventArgs) Handles Txtiname.Validated
        ErrorProvider1.SetError(Txtiname, "")
    End Sub
End Class