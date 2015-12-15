
Public Class Ledger
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Public ledger_id As Integer
    Public Sub load_lvw(Optional dt_from As String = "", Optional dt_to As String = "")
        Dim dr1 As SqlClient.SqlDataReader
        Dim journal_sql As String = ""
        Dim Item As ListViewItem
        Dim cur_balance As Double

        If dt_from <> "" And dt_to = "" Then
            MsgBox("Please select End Date.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INVALID FILTER")
            Exit Sub
        ElseIf dt_to <> "" And dt_from = "" Then
            MsgBox("Please select Start Date.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INVALID FILTER")
            Exit Sub
        End If
        journal_sql = get_journals(Me.ledger_id)
        If IsNothing(journal_sql) Then
            MsgBox("No Journal Entry found.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Journal Entry")
            Exit Sub
        Else
            journal_sql = CStr(String.Join(",", journal_sql))
        End If

        '## Get Account Titles
        Try
            lvw_ledger.Items.Clear()
            dr = db.ExecuteReader("SELECT a.id,a.name,a.type FROM accounts a JOIN account_types at ON a.type=at.id WHERE a.is_deleted=0 ORDER BY at.id")

            If dr.HasRows Then
                Do While dr.Read()
                    If dt_from <> "" And dt_to <> "" Then
                        dr1 = db.ExecuteReader("SELECT amount,is_debit,j.journal_date,jd.id FROM journal_details jd JOIN journals j ON j.id=jd.journal_id JOIN accounts a ON a.id=jd.account_id WHERE journal_id IN (" & journal_sql & ") AND a.id=" & dr.Item("id") & " AND j.journal_date BETWEEN " & dt_from & " AND " & dt_to & " ORDER BY jd.id ")

                    Else
                        dr1 = db.ExecuteReader("SELECT amount,is_debit,j.journal_date,jd.id FROM journal_details jd JOIN journals j ON j.id=jd.journal_id JOIN accounts a ON a.id=jd.account_id WHERE journal_id IN (" & journal_sql & ") AND a.id=" & dr.Item("id") & " ORDER BY jd.id ")

                    End If
                    If dr1.HasRows Then
                        lvw_ledger.Items.Add(dr.Item("name"))
                        cur_balance = 0
                        Do While dr1.Read
                            Item = lvw_ledger.Items.Add("     " & StrToDate(dr1.Item("journal_date")))
                            With Item
                                If dr1.Item("is_debit") = 1 Then
                                    .SubItems.Add(FormatNumber(dr1.Item("amount"), 2))
                                    .SubItems.Add("")
                                Else
                                    .SubItems.Add("")
                                    .SubItems.Add(FormatNumber(dr1.Item("amount"), 2))
                                End If
                                If is_debitted(CInt(dr.Item("type"))) Then
                                    '## positive increase if debit 
                                    If dr1.Item("is_debit") = 1 Then
                                        cur_balance += CDbl(dr1.Item("amount"))
                                    Else
                                        cur_balance -= CDbl(dr1.Item("amount"))
                                    End If
                                Else
                                    '## positive increase if credit 
                                    If dr1.Item("is_debit") = 0 Then
                                        cur_balance += CDbl(dr1.Item("amount"))
                                    Else
                                        cur_balance -= CDbl(dr1.Item("amount"))
                                    End If
                                End If
                                .SubItems.Add(FormatNumber(cur_balance, 2))
                            End With
                        Loop
                        lvw_ledger.Items.Add("")
                    Else
                        '## No records FOund
                        'If dt_from <> "" And dt_to <> "" Then
                        '    MsgBox("No Journal Entry found." & vbCrLf & "From: " & StrToDate(dt_from) & vbCrLf & "To: " & StrToDate(dt_to), MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Journal Entry")

                        'Else
                        '    MsgBox("No Journal Entry found.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Journal Entry")

                        'End If
                    End If

                Loop

            Else
                MsgBox("No account found", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Records Found")
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        'showUSC(uscViewJournal)
        'uscViewJournal.cmbPost.Text = ""
        showUSC(uscMainMenu)
        uscTrialBalance = New tbalance

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

    End Sub

    Private Sub Ledger_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        'load_lvw()
    End Sub

    Private Sub Ledger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ledger_id = select_ledger.cbo_ledger.SelectedValue
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        'load_lvw()
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        load_lvw(DateToStr(dt_from.Text), DateToStr(dt_to.Text))
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class