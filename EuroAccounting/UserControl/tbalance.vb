
Public Class tbalance
    Dim ledger_id As Integer
    Dim dr As SqlClient.SqlDataReader
    Dim cdm As SqlClient.SqlCommand
    Dim db As New DBHelper(My.Settings.connectionString)
    Private Sub load_tbalance()
        '#get journals
        Dim journals(0) As String
        Dim journal_id_sql As String
        Dim counter As Integer
        Dim dbl_total_debit, dbl_total_credit, debit, credit As New Double
        Dim Item As ListViewItem

        dr = db.ExecuteReader("SELECT id FROM journals WHERE ledger_id=" & Me.ledger_id)
        counter = 0
        If dr.HasRows Then
            Try
                Do While dr.Read
                    ReDim Preserve journals(counter)
                    journals(counter) = (dr.Item(0))
                    counter += 1
                Loop
                journal_id_sql = String.Join(",", journals)

                dr = db.ExecuteReader("SELECT a.id,a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1 and account_id=a.id) as debit,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=0 and account_id=a.id)as credit FROM accounts a WHERE a.id IN (SELECT account_id FROM journal_details jd WHERE jd.journal_id IN(" & journal_id_sql & ") )")
                If dr.HasRows Then
                    Do While dr.Read

                        If IsDBNull(dr.Item("debit")) Then
                            debit = 0
                        Else
                            debit = CDbl(dr.Item("debit"))
                        End If
                        If IsDBNull(dr.Item("credit")) Then
                            credit = 0
                        Else
                            credit = CDbl(dr.Item("credit"))
                        End If

                        Item = Me.lvtbalance.Items.Add(dr.Item("name").ToString)

                        With Item
                            If debit > credit Then
                                .SubItems.Add(FormatNumber(debit - credit, 2))
                                .SubItems.Add("")

                                dbl_total_debit += debit - credit
                            Else
                                .SubItems.Add("")
                                .SubItems.Add(FormatNumber(credit - debit, 2))
                                dbl_total_credit += credit - debit
                            End If

                        End With
                    Loop
                    Item = Me.lvtbalance.Items.Add("Total")
                    Item.SubItems.Add(FormatNumber(dbl_total_debit, 2))
                    Item.SubItems.Add(FormatNumber(dbl_total_credit, 2))
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("No journal entry found in the selected ledger", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "NO JOURNAL ENTRY FOUND")
        End If

    End Sub
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        'showUSC(uscViewJournal)
        'uscViewJournal.cmbPost.Text = ""
        showUSC(uscMainMenu)
    End Sub

    Private Sub tbalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        Me.ledger_id = select_ledger.cbo_ledger.SelectedValue
        load_tbalance()
    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged
        lbltitle1.Text = txtname.Text
    End Sub

    Private Sub txtmisc_TextChanged(sender As Object, e As EventArgs) Handles txtmisc.TextChanged
        lbltitle2.Text = txtmisc.Text
    End Sub
End Class