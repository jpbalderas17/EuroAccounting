Public Class AddJournalEntry
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnAddEntry_Click(sender As Object, e As EventArgs) Handles btnAddEntry.Click

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
        End If

        dr = db.ExecuteReader("SELECT name from accounts where name = '" & dAccount.Text & "'")
        If Not dr.HasRows Then
            Select Case MsgBox("The account doesn't exist do you want to add the account?", MsgBoxStyle.Information + vbYesNo, "Add account?")
                Case vbYes
                    MsgBox("yo")
                    'codes 
            End Select

        End If

    End Sub
End Class
