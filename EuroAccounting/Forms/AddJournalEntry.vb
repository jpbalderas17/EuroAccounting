Public Class AddJournalEntry
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddEntry_Click(sender As Object, e As EventArgs) Handles btnAddEntry.Click
        'code here for the ledger
        'save ledger , journal , journal
        equalAcc()


    End Sub

    Private Sub AddJournalEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtAddJourn.Value = Date.Now
        dAccount.Items.Clear()
        crAccount.Items.Clear()
        'get all accounts
        dr = db.ExecuteReader("SELECT name, type from accounts")
        Do While dr.Read
            dAccount.Items.Add(dr.Item("name").ToString)
            crAccount.Items.Add(dr.Item("name").ToString)
        Loop
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dAdd_Click(sender As Object, e As EventArgs) Handles dAdd.Click
        If Trim(dAccount.Text) = "" Then
            MsgBox("Debit entry is empty please add account", vbExclamation + vbOKOnly, "Field is empty")
            Exit Sub
        ElseIf dAmount.Text = "" Then
            MsgBox("Amount is empty", vbExclamation + vbOKOnly, "No amount input")
            Exit Sub
        End If

        dr = db.ExecuteReader("SELECT name from accounts where name = '" & dAccount.Text & "'")
        If Not dr.HasRows Then
            Select Case MsgBox("The account doesn't exist do you want to add the account?", MsgBoxStyle.Information + vbYesNo, "Add account?")
                Case vbYes

                    frm_accounts.ShowDialog()
                    'codes 
            End Select

        End If


        'lagay sa listview
        Dim itm = lvDebit.Items.Add(dAccount.Text)
        itm.SubItems.Add(dAmount.Text)

    End Sub

    Private Sub crAdd_Click(sender As Object, e As EventArgs) Handles crAdd.Click
        If Trim(crAccount.Text) = "" Then
            MsgBox("Credit entry is empty please add account", vbExclamation + vbOKOnly, "Field is empty")
            Exit Sub
        ElseIf crAmount.Text = "" Then
            MsgBox("Amount is empty", vbExclamation + vbOKOnly, "No amount input")
        End If

        dr = db.ExecuteReader("SELECT name from accounts where name = '" & crAccount.Text & "'")
        If Not dr.HasRows Then
            Select Case MsgBox("The account doesn't exist do you want to add the account?", MsgBoxStyle.Information + vbYesNo, "Add account?")
                Case vbYes

                    frm_accounts.ShowDialog()
                    'codes 
            End Select
        End If
        'lagay sa listview
        Dim itm = lvCredit.Items.Add(crAccount.Text)
        itm.SubItems.Add(crAmount.Text)
    End Sub
   

    Private Sub dAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dAmount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If e.Handled = (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub crAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles crAmount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If e.Handled = (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") Then
                e.Handled = True
            End If
        End If
    End Sub


   
    Private Sub tsDebRemover_Click(sender As Object, e As EventArgs) Handles tsDebRemover.Click
        If lvDebit.SelectedItems.Count > 0 Then
            Select Case MsgBox("Are you sure you want to remove this account?", vbExclamation + vbYesNo, "Removing account")
                Case vbYes
                    lvDebit.FocusedItem.Remove()
            End Select
        Else
            MsgBox("No account selected", vbExclamation + vbOKOnly, "Please select")
        End If
    End Sub

    Private Sub tsCredRemover_Click(sender As Object, e As EventArgs) Handles tsCredRemover.Click

    End Sub

    '''methods
    Private Sub equalAcc()
        Dim debitVal, creditVal As Double
        debitVal = 0
        creditVal = 0
        For x = 1 To lvDebit.Items.Count
            debitVal += CDbl(lvDebit.Items(x - 1).SubItems(1).Text)
        Next

        For x = 1 To lvCredit.Items.Count
            creditVal += CDbl(lvCredit.Items(x - 1).SubItems(1).Text)
        Next
        If debitVal <> creditVal Then
            MsgBox("The debit and credit entry is not equal", vbExclamation + vbOKOnly, "Not equal value")

        ElseIf debitVal = 0 And creditVal = 0 Then
            MsgBox("No accounts", vbExclamation + vbOKOnly, "Empty list")
        Else
            MsgBox("tuloy")
        End If

    End Sub
    Private Sub saveEntries()
        'una sa journal kuhain ang ledger_id
        Dim data As New Dictionary(Of String, Object)
        data.Add("journal_date", DateToStr(dtAddJourn.Value))
        data.Add("description", txtDescription.Text)
        data.Add("ledger_id", uscLedgers.lvljournal.FocusedItem.Text)
        Dim rec = db.ExecuteNonQuery("BEGIN trans " & _
        "INSERT FROM journals (journal_date, description, ledger_id) VALUES (@journal_date, @description, @ledger_id)" & _
        "COMMIT", data) 'transactions multiple insert"

    End Sub
End Class
