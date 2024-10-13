Imports System.ComponentModel
Imports System.Data.OleDb
Public Class FrmVendor
    Dim con As OleDbConnection
    Dim dtclient As DataTable
    Dim cmd As OleDbCommand
    Private Sub FrmVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            dtclient = New DataTable("Vendor")
            con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=inventory.mdb;")
            con.Open()
            Dim selectQuery As String = "SELECT * FROM Vendor"
            Dim DataAdapter As New OleDbDataAdapter(selectQuery, con)
            DataAdapter.Fill(dtclient)

            Txtvid.DataBindings.Add("Text", dtclient, "vid")
            Txtvname.DataBindings.Add("Text", dtclient, "vname")
            Txtvmobile.DataBindings.Add("Text", dtclient, "vmobile")
            Txtvaddr.DataBindings.Add("Text", dtclient, "vaddr")

            Txtvname.Enabled = False
            Txtvaddr.Enabled = False
            Txtvmobile.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Txtvid.Text = ""
        Txtvname.Text = ""
        Txtvmobile.Text = ""
        Txtvaddr.Text = ""



        btndisabled()
        BtnSave.Enabled = True
        BtnReset.Enabled = True
        Txtvname.Enabled = True
        Txtvaddr.Enabled = True
        Txtvmobile.Enabled = True
        Txtvname.Focus()
        Txtvid.Text = ""
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
        If Txtvname.Text = "" Then
            MsgBox("Please enter Vendor name")
            Txtvname.Focus()
            Return False
        ElseIf IsNumeric(Txtvname.Text) Then
            MsgBox("Please enter alphabets only for Vendor name")
            Txtvname.Focus()
            Return False
        ElseIf Txtvaddr.Text = "" Then
            MsgBox("Please enter address")
            Txtvaddr.Focus()
            Return False
        ElseIf Txtvmobile.Text = "" Then
            MsgBox("Please enter mobile number")
            Txtvmobile.Focus()
            Return False
        ElseIf Len(Txtvmobile.Text) <> 10 Then
            MsgBox("Please enter 10 digit mobile number")
            Txtvmobile.Focus()
            Return False
        ElseIf Not IsNumeric(Txtvmobile.Text) Then
            MsgBox("Please enter numeric mobile number")
            Txtvmobile.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub clear_binding()
        Txtvid.DataBindings.Clear()
        Txtvname.DataBindings.Clear()
        Txtvmobile.DataBindings.Clear()
        Txtvaddr.DataBindings.Clear()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not IsValidForm() Then
            Exit Sub
        End If

        Dim str As String
        Try
            str = "INSERT into Vendor( vname,  vmobile,vaddr) VALUES ('" & Txtvname.Text & "'," & CType(Txtvmobile.Text, Decimal) & ",'" & Txtvaddr.Text & "')"
            con.Open()
            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()

            con.Close()
            MsgBox("Record Inserted Successfully", MsgBoxStyle.Information, "Save")

            clear_binding()
            FrmVendor_Load(sender, e)


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
        Txtvname.Enabled = True
        Txtvaddr.Enabled = True
        Txtvmobile.Enabled = True
        Txtvname.Focus()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        clear_binding()
        btnenabled()
        FrmVendor_Load(sender, e)


    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim str As String

        If Not IsValidForm() Then
            Exit Sub
        End If

        Try
            str = "UPDATE Vendor SET vname = '" & Txtvname.Text & "' ,vaddr = '" & Txtvaddr.Text & "', vmobile=" & Txtvmobile.Text & " WHERE vid = " & dtclient.Rows(Me.BindingContext(dtclient).Position)("vid")
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
            str = "DELETE FROM Vendor WHERE vid = " & dtclient.Rows(Me.BindingContext(dtclient).Position)("vid")
            con.Open()

            cmd = New OleDbCommand(str, con)
            cmd.ExecuteNonQuery()

            con.Close()
            MsgBox("Record Deleted Successfully", MsgBoxStyle.Information, "DELETE")

            clear_binding()
            FrmVendor_Load(sender, e)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            Dim cname As String
            cname = InputBox("Please enter vendor name to search")

            For i As Integer = 0 To dtclient.Rows.Count - 1
                If UCase(dtclient.Rows(i)("vname")) = UCase(cname) Then
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

    Private Sub Txtvmobile_TextChanged(sender As Object, e As EventArgs) Handles Txtvname.TextChanged

    End Sub



    Private Sub Txtcname_Validating(sender As Object, e As CancelEventArgs) Handles Txtvname.Validating
        If (Txtvname.Text = "") Then
            e.Cancel = True
            ErrorProvider1.SetError(Txtvname, "Please enter the vendor name")
        End If
    End Sub

    Private Sub Txtcname_Validated(sender As Object, e As EventArgs) Handles Txtvname.Validated
        ErrorProvider1.SetError(Txtvname, "")
    End Sub
End Class