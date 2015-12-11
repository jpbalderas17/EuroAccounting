Public Class Accounts
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        'Me.Dispose()
        showUSC(uscMainMenu)
    End Sub
    Private Sub lvw_accounts_load()
        dr = db.ExecuteReader("SELECT a.id,a.name,at.name as type FROM accounts a JOIN account_types at ON a.type=at.id WHERE a.is_deleted=0")
        If dr.HasRows Then
            Do While dr.Read
                With lvw_accounts.Items.Add(dr.Item("id").ToString)
                    .SubItems.Add(dr.Item("name"))
                    .SubItems.Add(dr.Item("type"))
                End With
            Loop
        End If
    End Sub

    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles Me.Load
        lvw_accounts_load()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lvw_accounts.SelectedItems.Clear()
        Me.Enabled = False
        frm_accounts.ShowDialog()
        Me.Enabled = True
        lvw_accounts_load()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If lvw_accounts.SelectedItems.Count = 1 Then
            '## EDIT
            With lvw_accounts.SelectedItems.Item(0)
                Me.Enabled = False
                frm_accounts.ShowDialog()
                Me.Enabled = True
                lvw_accounts_load()

            End With
        ElseIf lvw_accounts.SelectedItems.Count < 1 Then
            MsgBox("Please select an account to edit.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Account Selected")
        ElseIf lvw_accounts.SelectedItems.Count > 1 Then
            MsgBox("Multiple accounts selected. You can only edit one account at a time", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Multiple Accounts Selected")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim account_id As Integer

        If lvw_accounts.SelectedItems.Count = 1 Then
            '## Delete
            account_id = lvw_accounts.SelectedItems.Item(0).Text
            If MsgBox("Delete this account?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Delete Account") = MsgBoxResult.Ok Then
                db.ExecuteNonQuery("UPDATE accounts SET is_deleted=1 WHERE id=" & account_id)
                lvw_accounts_load()
            End If

        ElseIf lvw_accounts.SelectedItems.Count < 1 Then
            MsgBox("Please select an account to Delete.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Account Selected")
        ElseIf lvw_accounts.SelectedItems.Count > 1 Then
            MsgBox("Multiple accounts selected. You can only delete one account at a time", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Multiple Accounts Selected")
        End If
    End Sub
End Class
