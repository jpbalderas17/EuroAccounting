﻿Public Class Archives


    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader

    Private Sub Archives_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim parameters As New Dictionary(Of String, Object)
        lvljournal.Items.Clear()
        Dim Item As ListViewItem
        'parameters.Add("keyword", "%" & txtSearch.Text & "%")

        Try
            dr = db.ExecuteReader("SELECT id, name, description FROM ledgers WHERE is_archive = 1", parameters)
            If dr.HasRows Then
                Do While dr.Read
                    'Dim utype = (CInt(dr.Item("user_type")))
                    Item = lvljournal.Items.Add(dr.Item("id").ToString)
                    With Item
                        .SubItems.Add(dr.Item("name"))
                        .SubItems.Add(dr.Item("description"))
                    End With
                Loop
            Else
                MsgBox("No record of journals", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No journals.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        If lvljournal.SelectedItems.Count = 0 Then
            MsgBox("Please select a ledger", vbInformation + vbOKOnly, "Select")
            Exit Sub
        End If
        Select Case MsgBox("Are you sure you want to delete this ledger?" & vbCrLf & "- " & lvljournal.FocusedItem.SubItems(1).Text, _
                       vbQuestion + vbYesNo, "Delete?")

            Case vbYes
                restore_Ledger()
        End Select
    End Sub
    '''METhODS

    Private Sub restore_Ledger()
        'restore
        'fake deletion
        Dim data As New Dictionary(Of String, Object)
        Try
            data.Add("is_archive", 0)
            Dim rec = db.ExecuteNonQuery("UPDATE ledgers SET is_archive = @is_archive WHERE id =  " & lvljournal.FocusedItem.Text, data)
            data.Clear()

            MsgBox("Ledger was deleted.", vbInformation + vbOKOnly, "Deleted")
            lvLoadListview()
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical)
        Finally
            db.Dispose()
        End Try
    End Sub
    Public Sub lvLoadListview()
        Dim parameters As New Dictionary(Of String, Object)
        lvljournal.Items.Clear()
        Dim Item As ListViewItem
        'parameters.Add("keyword", "%" & txtSearch.Text & "%")

        Try
            dr = db.ExecuteReader("SELECT id, name, description FROM ledgers WHERE is_archive = 1", parameters)
            If dr.HasRows Then
                Do While dr.Read
                    'Dim utype = (CInt(dr.Item("user_type")))
                    Item = lvljournal.Items.Add(dr.Item("id").ToString)
                    With Item
                        .SubItems.Add(dr.Item("name"))
                        .SubItems.Add(dr.Item("description"))
                    End With
                Loop
            Else
                MsgBox("No record of journals", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No journals.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        showUSC(uscMainMenu)
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub
End Class
