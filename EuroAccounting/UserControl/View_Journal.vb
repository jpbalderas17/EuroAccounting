﻿Imports System.Data.SqlClient
Public Class View_Journal
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Private Sub View_Journal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'loadJournal()

        'pnl_Journal.Width -= 10
        'Dim parameters As New Dictionary(Of String, Object)
        'uscJournalEntry.lvlview_journal.Items.Clear()
        'Dim Item As ListViewItem
        ''parameters.Add("keyword", "%" & txtSearch.Text & "%")

        'Try
        '    dr = db.ExecuteReader("SELECT account_name, is_debit FROM journal_details ", parameters)
        '    If dr.HasRows Then
        '        Do While dr.Read
        '            Dim db_cr = (dr.Item("is_debit"))
        '            Item = uscJournalEntry.lvlview_journal.Items.Add(dr.Item("account_name").ToString)
        '            With Item
        '                '.SubItems.Add(dr.Item("is_debit"))
        '                If db_cr = "0" Then
        '                    .SubItems.Add(dr.Item("is_debit"))
        '                    .SubItems.Add(" ")
        '                ElseIf db_cr = "1" Then
        '                    .SubItems.Add(" ")
        '                    .SubItems.Add(dr.Item("is_debit"))
        '                End If
        '                '.SubItems.Add(dr.Item("user_type"))
        '                '.SubItems.Add(dr.Item("is_debit"))
        '            End With
        '        Loop
        '    Else
        '        MsgBox("No record of users", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No users")
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'Finally
        '    db.Dispose()
        'End Try
    End Sub

    Private Sub View_Journal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'Try
        '    For Each ex_ni_jenny In uscJournalEntry.lvlview_journal.Controls
        '        If TypeOf ex_ni_jenny Is Journal_Entry Then
        '            ex_ni_jenny.width = pnl_Journal.Width
        '        End If
        '    Next

        '    'j_entry.Width = pnl_Journal.Width
        '    'j_entry.Height = pnl_Journal.Height

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs)
        showUSC(uscAddJournal)
    End Sub

    Private Sub btn_Close_Click_1(sender As Object, e As EventArgs) Handles btn_Close.Click
        showUSC(uscLedgers)
    End Sub

    Private Sub cmbPost_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPost.SelectedIndexChanged
        uscMainMenu.ledger_id = uscLedgers.lvljournal.FocusedItem.Text
        If cmbPost.Text = "Trial Balance" Then
            showUSC(uscTrialBalance)
            uscTrialBalance.load_tbalance()
        ElseIf cmbPost.Text = "Ledger (3 Column Ledger)" Then
            showUSC(uscLedger)
            uscLedger.load_lvw()
        ElseIf cmbPost.Text = "Income Statement" Then

            showUSC(uscIncomeStatement)
            uscIncomeStatement.lvwIncome_statement()

        ElseIf cmbPost.Text = "Balance Sheet" Then
            showUSC(uscBalanceSheet)
            uscBalanceSheet.load_balanceSheet()
            uscBalanceSheet.getNet()
        End If

    End Sub

    Private Function strToDate(str As String) As Date
        str = str.Substring(4, 2) & "/" & str.Substring(6, 2) & "/" & str.Substring(0, 4)
        Return str 'Format(str, "Short date")
    End Function

    Private Sub pnl_Journal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'load_lvw()
        'Exit Sub
        'Dim parameters As New Dictionary(Of String, Object)
        'lvljournal.Items.Clear()
        'Dim Item As ListViewItem
        ''parameters.Add("keyword", "%" & txtSearch.Text & "%")

        'Try
        '    dr = db.ExecuteReader("SELECT journal_id, account_name, amount, is_debit, journal_date, description FROM journal_details as D left join journals as J on D.journal_id=J.id ", parameters)
        '    If dr.HasRows Then
        '        Do While dr.Read
        '            Dim db_cr = dr.Item("is_debit")
        '            Dim myNumber As Integer = dr.Item("amount")
        '            'Item = lvljournal.Items.Add(dr.Item("journal_id").ToString)
        '            Item = lvljournal.Items.Add(strToDate(dr.Item("journal_date").ToString))
        '            With Item
        '                .SubItems.Add(dr.Item("account_name"))
        '                If db_cr = "0" Then
        '                    .SubItems.Add((myNumber * 0.01).ToString("N2"))
        '                    .SubItems.Add(" ")
        '                ElseIf db_cr = "1" Then
        '                    .SubItems.Add(" ")
        '                    .SubItems.Add((myNumber * 0.01).ToString("N2"))
        '                End If
        '                '.SubItems.Add(dr.Item("user_type"))
        '                '.SubItems.Add(dr.Item("is_debit"))
        '            End With
        '        Loop
        '    Else
        '        MsgBox("No record of users", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No users")
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'Finally
        '    db.Dispose()
        'End Try
    End Sub
    Public Sub loadJournal()
        Dim parameters As New Dictionary(Of String, Object)
        Dim j_entry_dr As SqlDataReader
        lvljournal.Items.Clear()
        Dim Item As ListViewItem
        Dim group As ListViewGroup
        'parameters.Add("keyword", "%" & txtSearch.Text & "%")

        Try
            dr = db.ExecuteReader("SELECT id,  journal_date, description FROM journals where ledger_id = " & uscLedgers.lvljournal.FocusedItem.Text)
            Dim ctr As Integer
            ctr = 1
            If dr.HasRows Then
                Do While dr.Read
                    group = New ListViewGroup("No." & ctr & "   Journal ID:" & dr.Item("id"), HorizontalAlignment.Left)
                    lvljournal.Groups.Add(group)

                    Item = lvljournal.Items.Add("Date: " & strToDate(dr.Item("journal_date")))
                    Item.Group = group
                    Item = lvljournal.Items.Add("Account Titles")
                    With Item
                        .SubItems.Add("Debit")
                        .SubItems.Add("Credit")
                    End With
                    Item.Group = group
                    'Item.Group
                    j_entry_dr = db.ExecuteReader("SELECT * FROM journal_details jd JOIN accounts a ON jd.account_id=a.id AND jd.journal_id=" & dr.Item("id").ToString & "ORDER by is_debit DESC")
                    'j_entry_dr = db.ExecuteReader("SELECT * FROM journal_details WHERE journal_id=" & dr.Item("id"))
                    If j_entry_dr.HasRows Then
                        Do While j_entry_dr.Read
                            Item = lvljournal.Items.Add(j_entry_dr.Item("name"))
                            With Item
                                Dim db_cr = j_entry_dr.Item("is_debit")
                                '.SubItems.Add(j_entry_dr.Item("amount"))
                                If db_cr = "1" Then
                                    .SubItems.Add(j_entry_dr.Item("amount"))
                                    .SubItems.Add(" ")
                                ElseIf db_cr = "0" Then
                                    .SubItems.Add(" ")
                                    .SubItems.Add(j_entry_dr.Item("amount"))
                                End If

                            End With

                            Item.Group = group
                        Loop
                        If dr.Item("description").ToString <> "" Then
                            Item = lvljournal.Items.Add("  Description:(" & dr.Item("description").ToString & ")")
                            Item.Group = group

                        End If
                        
                    End If
                    ctr += 1
                Loop
            Else
                MsgBox("No record of journal", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No journal.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose()
        End Try

    End Sub
    'Private Sub load_lvw()
    '    Dim parameters As New Dictionary(Of String, Object)
    '    Dim j_entry_dr As SqlDataReader
    '    lvljournal.Items.Clear()
    '    Dim Item As ListViewItem
    '    Dim group As ListViewGroup
    '    'parameters.Add("keyword", "%" & txtSearch.Text & "%")

    '    Try
    '        dr = db.ExecuteReader("SELECT id,  journal_date, description FROM journals ")

    '        If dr.HasRows Then
    '            Do While dr.Read
    '                group = New ListViewGroup(dr.Item("id"), HorizontalAlignment.Left)
    '                lvw_test.Groups.Add(group)

    '                Item = lvw_test.Items.Add("Date: " & dr.Item("journal_date"))
    '                Item.Group = group
    '                Item = lvw_test.Items.Add("Account Titles")
    '                With Item
    '                    .SubItems.Add("Debit")
    '                    .SubItems.Add("Credit")
    '                End With
    '                Item.Group = group
    '                j_entry_dr = db.ExecuteReader("SELECT * FROM journal_details WHERE journal_id=" & dr.Item("id"))
    '                If j_entry_dr.HasRows Then
    '                    Do While j_entry_dr.Read
    '                        Item = lvw_test.Items.Add(j_entry_dr.Item("account_name"))
    '                        With Item
    '                            .SubItems.Add(j_entry_dr.Item("amount"))
    '                        End With
    '                        Item.Group = group
    '                    Loop
    '                End If
    '            Loop
    '        Else
    '            MsgBox("No record of journal", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No journal.")
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    Finally
    '        db.Dispose()
    '    End Try
    'End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddJournalEntry.ShowDialog()
    End Sub


   
    Private Sub tsRemove_Click(sender As Object, e As EventArgs) Handles tsRemove.Click
        Try
            Dim journal_id As String
            Dim splitter() As String
            journal_id = lvljournal.FocusedItem.Group.Header.ToString
            journal_id = journal_id.Replace("No.", "")
            splitter = Split(journal_id, " Journal ID:")
            Select Case MsgBox("Do you want to remove this journal entry ?", vbQuestion + vbYesNo, "Remove")
                Case vbYes
                    'deletion not fake 
                    Dim rec = db.ExecuteNonQuery("BEGIN TRANSACTION" & vbCrLf & _
                                           " DELETE FROM journals WHERE id =" & splitter(1) & vbCrLf _
                                           & "DELETE FROM journal_details where journal_id=" & splitter(1) & vbCrLf &
                                           "COMMIT")
                    MsgBox("Journal entry was removed!", vbInformation + vbOKOnly, "Removed")
                    loadJournal()
            End Select

        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try

    End Sub

 
End Class
