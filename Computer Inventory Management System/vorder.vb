Imports System.Data.OleDb
Public Class Frmvorder
    Dim con As OleDbConnection
    Dim dtclient, dtclservice As DataTable
    Dim cmd As OleDbCommand

    Private Sub Btnadd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        btndisabled()
        BtnSave.Enabled = True
        BtnReset.Enabled = True
        Txtvoid.Text = ""
        Cmbvid.Text = ""
        DateTimePicker1.Value = Now
        Cmbvid.Enabled = True
        DateTimePicker1.Enabled = True
        Cmbvid.Focus()
    End Sub

    Private Sub clear_binding()
        Txtvoid.DataBindings.Clear()
        Cmbvid.DataBindings.Clear()
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
        If Cmbvid.Text = "" Then
            MsgBox("Please Select Vendor")
            Cmbvid.Focus()
            Exit Sub
        End If
        Dim str As String
        Try
            con.Open()
            str = "INSERT into vorder(vid,vodate) VALUES (" & Cmbvid.SelectedValue & ",'" & DateTimePicker1.Value & "')"
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

    Private Sub BtnFirst_Click(sender As Object, e As EventArgs) Handles BtnFirst.Click
        Me.BindingContext(dtclservice).Position = 0
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Me.BindingContext(dtclservice).Position += 1
    End Sub

    Private Sub BtnPrevious_Click(sender As Object, e As EventArgs) Handles BtnPrevious.Click
        Me.BindingContext(dtclservice).Position -= 1
    End Sub

    Private Sub BtnLast_Click(sender As Object, e As EventArgs) Handles BtnLast.Click
        Me.BindingContext(dtclservice).Position = dtclservice.Rows.Count - 1
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Try
            Dim oid As Integer
            oid = Val(InputBox("Please enter vendor order id"))

            For i As Integer = 0 To dtclservice.Rows.Count - 1
                If dtclservice.Rows(i)("void") = oid Then
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

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        clear_binding()
        Frmcustorder_Load(sender, e)

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim str As String

        Try

            If MsgBox("Are you sure you want to delete selected record?", vbYesNo + vbCritical) = vbNo Then
                Exit Sub
            End If
            str = "DELETE FROM vorder WHERE void = " & dtclservice.Rows(Me.BindingContext(dtclservice).Position)("void")
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

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        btndisabled()

        BtnUpdate.Enabled = True
        Cmbvid.Enabled = True
        DateTimePicker1.Enabled = True

        Cmbvid.Focus()
    End Sub

    Private Sub Btnupdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Dim str As String
        If Cmbvid.Text = "" Then
            MsgBox("Please Select vendor")
            Cmbvid.Focus()
            Exit Sub
        End If

        Try
            con.Open()
            str = "UPDATE vorder SET vid=" & Cmbvid.SelectedValue & ", vodate = '" & DateTimePicker1.Text & "' WHERE void = " & dtclservice.Rows(Me.BindingContext(dtclservice).Position)("void")


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
            dtclient = New DataTable("Vendor")
            dtclservice = New DataTable("clservice")
            con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=inventory.mdb;")
            con.Open()
            Dim selectQuery As String = "SELECT * FROM Vendor"
            Dim DataAdapter As New OleDbDataAdapter(selectQuery, con)
            DataAdapter.Fill(dtclient)

            Cmbvid.ValueMember = "vid"
            Cmbvid.DisplayMember = "vname"
            Cmbvid.DataSource = dtclient

            selectQuery = "SELECT * FROM vorder"
            DataAdapter = New OleDbDataAdapter(selectQuery, con)
            DataAdapter.Fill(dtclservice)
            If dtclservice.Rows.Count > 0 Then
                Txtvoid.DataBindings.Add("Text", dtclservice, "void")
                Cmbvid.DataBindings.Add("SelectedValue", dtclservice, "vid")
                DateTimePicker1.DataBindings.Add("Text", dtclservice, "vodate")
            End If
            Cmbvid.Enabled = False
            DateTimePicker1.Enabled = False
            btnenabled()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            con.Close()
        End Try
    End Sub
End Class