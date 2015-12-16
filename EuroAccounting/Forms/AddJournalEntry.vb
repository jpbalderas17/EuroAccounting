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
        Try
            dr = db.ExecuteReader("SELECT name, type from accounts")
            Do While dr.Read
                dAccount.Items.Add(dr.Item("name").ToString)
                crAccount.Items.Add(dr.Item("name").ToString)
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub dAdd_Click(sender As Object, e As EventArgs) Handles dAdd.Click
        If Trim(dAccount.Text) = "" Then
            MsgBox("Debit entry is empty please add account", vbExclamation + vbOKOnly, "Field is empty")
            Exit Sub
        ElseIf Trim(dAmount.Text) = "" Then
            MsgBox("Amount is empty", vbExclamation + vbOKOnly, "No amount input")
            Exit Sub
        End If
        Try
            dr = db.ExecuteReader("SELECT name, id from accounts where name = '" & Trim(dAccount.Text) & "'")
            If Not dr.HasRows Then
                Select Case MsgBox("The account doesn't exist do you want to add the account?", MsgBoxStyle.Information + vbYesNo, "Add account?")
                    Case vbYes
                        frm_accounts.txt_account_name.Text = dAccount.Text
                        frm_accounts.ShowDialog()
                        Exit Sub
                    Case vbNo
                        Exit Sub
                End Select

            End If

            'lagay sa listview
            dr.Read()
            Dim itm = lvDebit.Items.Add(dAccount.Text)
            itm.SubItems.Add(dAmount.Text)
            itm.SubItems.Add(dr.Item("id").ToString)
            dAccount.Text = ""
            dAmount.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub crAdd_Click(sender As Object, e As EventArgs) Handles crAdd.Click
        If Trim(crAccount.Text) = "" Then
            MsgBox("Credit entry is empty please add account", vbExclamation + vbOKOnly, "Field is empty")
            Exit Sub
        ElseIf Trim(crAmount.Text) = "" Then
            MsgBox("Amount is empty", vbExclamation + vbOKOnly, "No amount input")
            Exit Sub
        End If
        Try
            dr = db.ExecuteReader("SELECT name,id from accounts where name = '" & Trim(crAccount.Text) & "'")
            If Not dr.HasRows Then
                Select Case MsgBox("The account doesn't exist do you want to add the account?", MsgBoxStyle.Information + vbYesNo, "Add account?")
                    Case vbYes


                        frm_accounts.txt_account_name.Text = crAccount.Text
                        frm_accounts.ShowDialog()
                        Exit Sub
                    Case vbNo
                        Exit Sub
                End Select
            End If
            'lagay sa listview
            dr.Read()
            Dim itm = lvCredit.Items.Add(Trim(crAccount.Text))
            itm.SubItems.Add(crAmount.Text)
            itm.SubItems.Add(dr.Item("id").ToString)
            crAccount.Text = ""
            crAmount.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        Finally
            db.Dispose()
        End Try
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
        If lvCredit.SelectedItems.Count > 0 Then
            Select Case MsgBox("Are you sure you want to remove this account?", vbExclamation + vbYesNo, "Removing account")
                Case vbYes
                    lvCredit.FocusedItem.Remove()
            End Select
        Else
            MsgBox("No account selected", vbExclamation + vbOKOnly, "Please select")
        End If
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
            saveEntries()
            MsgBox("Entries saved!", vbInformation + vbOKOnly, "New entry saved!")
            txtDescription.Clear()
            lvDebit.Items.Clear()
            lvCredit.Items.Clear()

            uscViewJournal.loadJournal()
            Me.Close()
        End If

    End Sub
    Private Sub saveEntries()
        'una sa journal kuhain ang ledger_id
        Dim query, firstState, lastState As String
        firstState = "BEGIN TRANSACTION "
        lastState = "COMMIT "
        Dim data As New Dictionary(Of String, Object)
        data.Add("journal_date", DateToStr(dtAddJourn.Value))
        data.Add("description", "'" & txtDescription.Text & "'")
        data.Add("ledger_id", uscLedgers.lvljournal.FocusedItem.Text)
        query = "INSERT INTO journals (journal_date, description, ledger_id) VALUES (@journal_date, @description, @ledger_id)" & vbCrLf &
        " DECLARE @j_id INT " & vbCrLf &
        " SET @j_id = SCOPE_IDENTITY()" & vbCrLf

        'Dim rec = db.ExecuteScalar("INSERT INTO journals (journal_date, description, ledger_id) VALUES (@journal_date, @description, @ledger_id)" & _
        '                           "; SET @j_id = SELECT SCOPE_IDENTITY()", data)
        'Dim j_ID As Integer
        'j_ID = rec


        'loop of entries
        
        For x = 1 To lvDebit.Items.Count Step 1

            query += "INSERT INTO journal_details (journal_id, amount, is_debit, account_id) " & _
                "VALUES (@j_id , " & lvDebit.Items(x - 1).SubItems(1).Text & ",1 , '" & lvDebit.Items(x - 1).SubItems(2).Text & "')" & vbCrLf ' number na ito!

        Next
        For x = 1 To lvCredit.Items.Count Step 1
            query += "INSERT INTO journal_details (journal_id, amount, is_debit, account_id) " & _
                "VALUES (@j_id, " & lvCredit.Items(x - 1).SubItems(1).Text & ",0 , '" & lvCredit.Items(x - 1).SubItems(2).Text & "')" & vbCrLf ' number na ito!
        Next
        'MsgBox(firstState & vbCrLf & query & vbCrLf & lastState)
        Dim rec = db.ExecuteNonQuery(firstState & vbCrLf & query & vbCrLf & lastState, data)
        data.Clear()

    End Sub
End Class
