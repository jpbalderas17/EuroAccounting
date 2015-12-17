Imports System.Data.SqlClient
Public Class frm_accounts
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand

    Public Sub reset_form()
        lbl_account_id.Text = ""
        txt_account_name.Text = ""
    End Sub
    Private Sub frm_accounts_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' cbo_account_type_load()


        'If (uscAccounts.lvw_accounts.SelectedItems.Count = 1) Then
        '    With uscAccounts.lvw_accounts.SelectedItems.Item(0)
        '        Edit_this(CInt(.Text), CStr(.SubItems(1).Text), CStr(.SubItems(2).Text))
        '    End With
        'End If
    End Sub


    Public Overloads Sub Show(id As Integer, name As String, type As String)
        Me.Show()
        Edit_this(id, name, type)
        MsgBox(Me.Owner)
    End Sub

    Public Sub cbo_account_type_load()
        Dim account_types As New ArrayList

        dr = db.ExecuteReader("SELECT id,name FROM account_types")
        Do While dr.Read
            account_types.Add(New MyCombo(dr.Item("id"), dr.Item("name")))
        Loop

        With cbo_account_type
            .DataSource = account_types 'Set arraylist as data source of combobox
            .DisplayMember = "Description" 'as per class property
            .ValueMember = "ID" 'as per class property
        End With
    End Sub
    Private Sub save_account_type()
        Dim input As New Dictionary(Of String, Object)
        input.Add("name", Trim(txt_account_name.Text))
        input.Add("type", cbo_account_type.SelectedValue)
        Try


            If (lbl_account_id.Text = "") Then
                '## INSERT
                If db.ExecuteNonQuery("INSERT INTO accounts(name,type) VALUES(@name,@type)", input) > 0 Then
                    MsgBox("New Account Created", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "New Account")
                    Me.Dispose()
                Else
                    MsgBox("Save Failed. Please try again", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Failed")

                End If

            Else
                '##UPDATE
                input.Add("id", lbl_account_id.Text)
                If db.ExecuteNonQuery("UPDATE accounts SET name=@name,type=@type WHERE id=@id", input) > 0 Then
                    MsgBox("Account Updated", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Update Account")
                    Me.Dispose()
                Else
                    MsgBox("Save Failed. Please try again", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Save Failed")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
        reset_form()
    End Sub
    Private Function validate_account()
        Dim is_valid As Boolean = True
        Dim account_name, account_type, error_message As String

        error_message = "Please fill up the following:" & vbCrLf
        account_name = txt_account_name.Text
        account_type = cbo_account_type.Text

        If account_name = "" Then
            error_message &= "Account Name" & vbCrLf
            is_valid = False
        End If
        If account_type = "" Then
            error_message &= "Account Type" & vbCrLf
            is_valid = False
        End If

        If is_valid = False Then
            MsgBox(error_message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Invalid Data")
        End If

        Return is_valid
    End Function
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If validate_account() = True Then
            save_account_type()
            reset_form()
            AddJournalEntry.loadDcombo()
        End If
    End Sub

    Public Sub Edit_this(ByVal account_id As Integer, account_name As String, account_type As String)
        With cbo_account_type
            .SelectedIndex = .FindStringExact(account_type)
        End With

        lbl_account_id.Text = CInt(account_id)
        txt_account_name.Text = CStr(account_name)
    End Sub
End Class