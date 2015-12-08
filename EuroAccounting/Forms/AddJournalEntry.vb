Public Class AddJournalEntry
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddEntry_Click(sender As Object, e As EventArgs) Handles btnAddEntry.Click
        'code here for the ledger

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
    End Sub
    Private Sub equalAcc()
        Dim debitVal, creditVal As Double
        debitVal = 0
        creditVal = 0
        For x = 1 To lvDebit.Items.Count
            debitVal += CDbl(lvDebit.Items(x - 1).SubItems(0).Text)
        Next

        For x = 1 To lvCredit.Items.Count
            creditVal += CDbl(lvCredit.Items(x - 1).SubItems(0).Text)
        Next
        If debitVal <> creditVal Then
            MsgBox("The debit and credit entry is not equal", vbExclamation + vbOKOnly, "Not equal value")
            Exit Sub

        End If

    End Sub
End Class
