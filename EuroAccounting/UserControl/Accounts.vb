Public Class Accounts
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        'Me.Dispose()
        showUSC(uscMainMenu)
    End Sub
    Private Sub lvw_accounts_load()
        Try
            lvw_accounts.Items.Clear()
            dr = db.ExecuteReader("SELECT a.id,a.name,at.name as type FROM accounts a JOIN account_types at ON a.type=at.id WHERE a.is_deleted=0")
            If dr.HasRows Then
                Do While dr.Read
                    With lvw_accounts.Items.Add(dr.Item("id").ToString)
                        .SubItems.Add(dr.Item("name"))
                        .SubItems.Add(dr.Item("type"))
                    End With
                Loop
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical + vbOKOnly, "Error")

        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub Accounts_Load(sender As Object, e As EventArgs) Handles Me.Load
        lvw_accounts_load()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frm_accounts.reset_form()
        frm_accounts.cbo_account_type_load()
        lvw_accounts.SelectedItems.Clear()
        Me.Enabled = False
        frm_accounts.ShowDialog()
        Me.Enabled = True
        lvw_accounts_load()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        frm_accounts.cbo_account_type_load()
        If lvw_accounts.SelectedItems.Count = 1 Then
            '## EDIT
            ' With lvw_accounts.SelectedItems.Item(0)
            Me.Enabled = False
            frm_accounts.txt_account_name.Text = lvw_accounts.FocusedItem.SubItems(1).Text
            frm_accounts.lbl_account_id.Text = lvw_accounts.FocusedItem.Text
            With frm_accounts.cbo_account_type
                .SelectedIndex = .FindStringExact(lvw_accounts.FocusedItem.SubItems(2).Text)
            End With
            frm_accounts.ShowDialog()
            Me.Enabled = True
            lvw_accounts_load()

            ' End With
        ElseIf lvw_accounts.SelectedItems.Count < 1 Then
            MsgBox("Please select an account to edit.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Account Selected")
        ElseIf lvw_accounts.SelectedItems.Count > 1 Then
            MsgBox("Multiple accounts selected. You can only edit one account at a time", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Multiple Accounts Selected")
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
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
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical + vbOKOnly, "Error")

        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub btnSearchAccounts_Click(sender As Object, e As EventArgs) Handles btnSearchAccounts.Click
        If txtSearchAccounts.Text.Contains("'") Then
            MsgBox("Invalid text search, please remove single qoute", vbExclamation + vbOKOnly, "Invalid")
            Exit Sub
        End If
        Try
            dr = db.ExecuteReader("SELECT a.id,a.name as name,at.name as type FROM (SELECT id ,name,type from accounts where is_deleted = 0) as a JOIN account_types as at ON a.type=at.id WHERE  a.id like '%" & txtSearchAccounts.Text & "%' OR" & _
                              " a.name like '%" & txtSearchAccounts.Text & "%' OR  at.name like '%" & txtSearchAccounts.Text & "%'")
            lvw_accounts.Items.Clear()
            If dr.HasRows Then
                Do While dr.Read
                    Dim itm As ListViewItem = lvw_accounts.Items.Add(dr.Item("id").ToString)
                    itm.SubItems.Add(dr.Item("name").ToString)
                    itm.SubItems.Add(dr.Item("type").ToString)
                   


                Loop
            Else
                MsgBox("No results found", vbExclamation + vbOKOnly, "No record")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical)
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub txtSearchAccounts_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearchAccounts.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSearchAccounts_Click(sender, e)
        End If
    End Sub

End Class
