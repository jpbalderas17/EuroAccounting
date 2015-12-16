Imports System.Data.SqlClient
Imports System.Text
Imports System.Runtime.InteropServices
Public Class Cash_Flow
    Dim ledger_id As Integer
    Dim cash_id As Integer
    Dim dr As SqlClient.SqlDataReader
    Dim db As New DBHelper(My.Settings.connectionString)

    Private Const EM_SETCUEBANNER As Integer = &H1501
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub SetCueText(ByVal control As Control, ByVal text As String)
        SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
    End Sub

    Class journal_entry
        Public account_name As String
        Public amount As Double
        Public is_debit As Boolean
        Public account_type As Integer
        Public account_id As Integer
        Public Sub New(account_name As String, amount As Double, is_debit As Boolean, account_type As Integer, account_id As Integer)
            Me.account_name = account_name
            Me.amount = amount
            Me.is_debit = is_debit
            Me.account_type = account_type
            Me.account_id = account_id
        End Sub
    End Class

    Public Sub load_lvw(Optional dt_from As String = "", Optional dt_to As String = "")
        Dim dr1 As SqlClient.SqlDataReader
        Dim journal_sql As String = ""
        Dim Item As ListViewItem
        Dim cur_balance As Double
        Dim last_journal_id As Integer = 0
        Dim debit As New ArrayList
        Dim credit As New ArrayList
        Dim cashflow, temp_cashflow As New ArrayList
        'Dim cash_in_debit As Boolean
        Dim account_name As String
        Dim accounts As New List(Of String)

        If dt_from <> "" And dt_to = "" Then
            MsgBox("Please select End Date.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INVALID FILTER")
            Exit Sub
        ElseIf dt_to <> "" And dt_from = "" Then
            MsgBox("Please select Start Date.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INVALID FILTER")
            Exit Sub
        End If
        journal_sql = get_journals(uscMainMenu.ledger_id)
        If IsNothing(journal_sql) Then
            MsgBox("No Journal Entry found.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Journal Entry")
            Exit Sub
        Else
            journal_sql = CStr(String.Join(",", journal_sql))
        End If

        '## LOOP cash
        Try
            dr = db.ExecuteReader("SELECT id FROM accounts WHERE name='CASH'")
            If dr.HasRows Then
                dr.Read()
                cash_id = CInt(dr.Item("id"))
            Else
                MsgBox("No Cash account found", MsgBoxStyle.OkOnly, "NO RECORDS")
                Exit Sub
            End If
            lvw_cashflow.Items.Clear()

            If dt_from <> "" And dt_to <> "" Then
                dr1 = db.ExecuteReader("SELECT amount,is_debit,j.journal_date,jd.id,a.type,j.id as journal_id FROM journal_details jd JOIN journals j ON j.id=jd.journal_id JOIN accounts a ON a.id=jd.account_id WHERE journal_id IN (" & journal_sql & ") AND a.id=" & cash_id & " AND j.journal_date BETWEEN " & dt_from & " AND " & dt_to & " ORDER BY jd.id ")

            Else
                dr1 = db.ExecuteReader("SELECT amount,is_debit,j.journal_date,jd.id,a.type,j.id as journal_id FROM journal_details jd JOIN journals j ON j.id=jd.journal_id JOIN accounts a ON a.id=jd.account_id WHERE journal_id IN (" & journal_sql & ") AND a.id=" & cash_id & " ORDER BY jd.id ")

            End If
            If dr1.HasRows Then
                cur_balance = 0
                Do While dr1.Read
                    Item = lvw_cashflow.Items.Add(StrToDate(dr1.Item("journal_date")))
                    With Item
                        If dr1.Item("is_debit") = 1 Then
                            dr = db.ExecuteReader("SELECT a.name FROM journal_details jd JOIN accounts a ON a.id=jd.account_id WHERE jd.is_debit=0 AND jd.journal_id=" & dr1.Item("journal_id"))
                        Else
                            dr = db.ExecuteReader("SELECT a.name FROM journal_details jd JOIN accounts a ON a.id=jd.account_id WHERE jd.is_debit=1 AND jd.journal_id=" & dr1.Item("journal_id"))
                        End If
                        account_name = ""
                        accounts = New List(Of String)
                        Do While dr.Read
                            'account_name &= dr.Item("name") & vbCrLf
                            accounts.Add(dr.Item("name"))
                        Loop
                        account_name = String.Join(",", accounts)
                        .SubItems.Add(account_name)

                        If dr1.Item("is_debit") = 1 Then
                            .SubItems.Add(FormatNumber(dr1.Item("amount"), 2))
                            .SubItems.Add("")
                        Else
                            .SubItems.Add("")
                            .SubItems.Add(FormatNumber(dr1.Item("amount"), 2))
                        End If
                        If is_debitted(CInt(dr1.Item("type"))) Then
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
                'lvw_cashflow.Items.Add("")
            Else
                MsgBox("No account found", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Records Found")

            End If



            'If dt_from <> "" And dt_to <> "" Then
            '    dr = db.ExecuteReader("SELECT jd.id,a.name,amount,is_debit,j.journal_date,jd.journal_id,a.type,a.id as account_id FROM journal_details jd JOIN journals j ON j.id=jd.journal_id JOIN accounts a ON a.id=jd.account_id AND jd. journal_id IN (SELECT DISTINCT(jd.journal_id) FROM journal_details jd JOIN accounts a ON jd.account_id=a.id  WHERE a.id=" & cash_id & ") AND j.id IN (" & journal_sql & ") AND j.journal_date BETWEEN " & dt_from & " AND " & dt_to)
            'Else
            '    dr = db.ExecuteReader("SELECT jd.id,a.name,amount,is_debit,j.journal_date,jd.journal_id,a.type,a.id as account_id FROM journal_details jd JOIN journals j ON j.id=jd.journal_id JOIN accounts a ON a.id=jd.account_id AND jd. journal_id IN (SELECT DISTINCT(jd.journal_id) FROM journal_details jd JOIN accounts a ON jd.account_id=a.id  WHERE a.id=" & cash_id & ") AND j.id IN (" & journal_sql & ")")
            'End If

            'If dr.HasRows Then
            '    Do While dr.Read()
            '        If (last_journal_id = dr.Item("journal_id") Or temp_cashflow.Count = 0) Then
            '            '## same journal
            '            last_journal_id = dr.Item("journal_id")
            '            temp_cashflow.Add(New journal_entry(dr.Item("name"), dr.Item("amount"), dr.Item("is_debit"), dr.Item("type"), dr.Item("account_id")))
            '        ElseIf (last_journal_id <> dr.Item("journal_id")) Then
            '            '##New Journal ID
            '            cash_in_debit = 0
            '            cash_value = 0
            '            add_to_cashflow(cashflow, temp_cashflow)
            '            temp_cashflow = New ArrayList
            '            temp_cashflow.Add(New journal_entry(dr.Item("name"), dr.Item("amount"), dr.Item("is_debit"), dr.Item("type"), dr.Item("account_id")))
            '            last_journal_id = dr.Item("journal_id")

            '        End If
            '    Loop
            '    add_to_cashflow(cashflow, temp_cashflow)
            '    lvw_cashflow.Items.Clear()
            '    For Each x As journal_entry In cashflow
            '        Item = lvw_cashflow.Items.Add(x.account_name)
            '        With Item
            '            Item.SubItems.Add(x.amount)
            '        End With
            '    Next



            'Else
            'MsgBox("No account found", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Records Found")
            'Exit Sub
            'End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub add_to_cashflow(ByRef cashflow As ArrayList, temp_cashflow As ArrayList)
        Dim is_inside As Boolean
        Dim array_index As Integer
        Dim revenue = {1, 2}
        Dim assets = {1, 2}
        Dim liabilities = {1, 2}


        If temp_cashflow.Count > 0 Then


            For Each x As journal_entry In temp_cashflow

                If (cashflow.Count = 0) Then
                    If (x.account_id <> cash_id) Then
                        cashflow.Add(x)
                    Else
                        'cash_value = x.amount
                    End If
                Else
                    If x.account_id <> cash_id Then
                        is_inside = False
                        array_index = -1
                        For Each y As journal_entry In cashflow

                            If y.account_id = x.account_id Then
                                is_inside = True
                                array_index = cashflow.IndexOf(y)
                                Exit For
                            End If
                        Next

                        If is_inside = True Then
                            'add or subtract
                            If x.is_debit = 1 Then
                                cashflow.Item(array_index).amount += x.amount
                            Else
                                cashflow.Item(array_index).amount -= x.amount
                            End If

                        Else
                            'add to chasflow
                            cashflow.Add(x)
                        End If
                    End If
                End If

            Next
        End If
    End Sub
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        showUSC(uscMainMenu)
        uscCashFlow = New Cash_Flow

    End Sub

    Private Sub cash_flow_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetCueText(txtTitle, "Enter Title")
        SetCueText(txtDescription, "Enter Description")
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        'Me.ledger_id = select_ledger.cbo_ledger.SelectedValue
        load_lvw()
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        'load_lvw(DateToStr(dt_from.Text), DateToStr(dt_to.Text))
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        If Trim(txtTitle.Text = "") Or Trim(txtDescription.Text) = "" Then
            MsgBox("Please Set the title and the description", vbExclamation + vbOKOnly, "No title and description")
            Exit Sub
        Else
            cash_flow_report.ShowDialog()
        End If

    End Sub
End Class
