Imports System.Data.SqlClient
Imports System.Text
Imports System.Runtime.InteropServices

Public Class Income_Statement
    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub SetCueText(ByVal control As Control, ByVal text As String)
        SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
    End Sub
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Dim ledger_id As Integer
    Dim net As Double
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        'showUSC(uscViewJournal)
        'uscViewJournal.cmbPost.Text = ""
        showUSC(uscMainMenu)
        uscIncomeStatement = New Income_Statement
    End Sub

    Private Sub Income_Statement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        Me.ledger_id = select_ledger.cbo_ledger.SelectedValue

       
        SetCueText(txtTitle, "Title")
        SetCueText(txtDescription, "Description")

    End Sub

    Private Function strToDate(str As String) As Date
        str = str.Substring(4, 2) & "/" & str.Substring(6, 2) & "/" & str.Substring(0, 4)
        Return str 'Format(str, "Short date")
    End Function
    Public Sub lvwIncome_statementinList()
        Dim parameters As New Dictionary(Of String, Object)
        'Dim j_entry_dr As SqlDataReader
        Dim dbl_total_expense As Double = 0
        Dim dbl_total_revenue As Double = 0
        Dim debit, credit As New Double
        'lvIncomeStatement.Items.Clear()
        Dim Item As ListViewItem
        Dim journals(0) As String
        Dim journal_id_sql As String
        Dim counter As Integer


        dr = db.ExecuteReader("SELECT id FROM journals WHERE ledger_id=" & uscLedgers.lvljournal.FocusedItem.Text)
        counter = 0
        If dr.HasRows Then
            Try
                Do While dr.Read
                    ReDim Preserve journals(counter)
                    journals(counter) = (dr.Item(0))
                    counter += 1
                Loop
                journal_id_sql = String.Join(",", journals)

                'para sa revenue
                'dr = db.ExecuteReader("SELECT DISTINCT(a.id), a.name, IIF(jd.is_debit=0,jd.amount,0) as debit FROM journal_details jd JOIN accounts a ON jd.account_id=a.id where a.type=1")
                'dr = db.ExecuteReader("SELECT a.id,a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1 AND type=1 AND account_id=a.id) as debit,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=0 and account_id=a.id and a.type=3)as credit FROM accounts a WHERE a.type=1 AND a.id IN (SELECT account_id FROM journal_details jd WHERE jd.journal_id IN(" & journal_id_sql & ") )")
                dr = db.ExecuteReader("SELECT a.id,a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1  AND account_id=a.id) as debit,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=0 and account_id=a.id )as credit FROM accounts a WHERE a.type=1 AND a.id IN (SELECT account_id FROM journal_details jd WHERE jd.journal_id IN(" & journal_id_sql & ") )")
                Item = Me.lvIncomeStatement.Items.Add("Revenue")
                Item.SubItems.Add("")
                Item.SubItems.Add("")
                If dr.HasRows Then
                    Do While dr.Read

                        Item = Me.lvIncomeStatement.Items.Add("          " & dr.Item("name").ToString)
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

                        With Item
                            If debit > credit Then
                                .SubItems.Add(FormatNumber(debit - credit, 2))
                                .SubItems.Add("")
                                dbl_total_revenue += debit - credit
                            Else
                                .SubItems.Add(FormatNumber(credit - debit, 2))
                                .SubItems.Add("")
                                dbl_total_revenue += credit - debit
                            End If

                        End With

                    Loop
                    Item = Me.lvIncomeStatement.Items.Add("          " & "Total Revenues")
                    Item.SubItems.Add("")
                    Item.SubItems.Add(FormatNumber(dbl_total_revenue, 2))
                End If



                'para sa expenses
                dr = db.ExecuteReader("SELECT a.id,a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1  AND account_id=a.id) as debit,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=0 and account_id=a.id )as credit FROM accounts a WHERE a.type=3 AND a.id IN (SELECT account_id FROM journal_details jd WHERE jd.journal_id IN(" & journal_id_sql & ") )")
                'dr = db.ExecuteReader("SELECT DISTINCT(a.id),a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1 and account_id=a.id) as debit FROM journal_details jd JOIN accounts a ON jd.account_id=a.id where a.type=3")
                'dr = db.ExecuteReader("SELECT a.id,a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1 AND type=3 AND account_id=a.id) as debit,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=0 and account_id=a.id and a.type=3)as credit FROM accounts a WHERE a.id IN (SELECT account_id FROM journal_details jd WHERE jd.journal_id IN(" & journal_id_sql & ") )")
                Item = Me.lvIncomeStatement.Items.Add("Expenses")
                Item.SubItems.Add("")
                Item.SubItems.Add("")
                If dr.HasRows Then
                    Do While dr.Read
                        Item = Me.lvIncomeStatement.Items.Add("          " & dr.Item("name").ToString)
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

                        With Item
                            If debit > credit Then
                                .SubItems.Add(FormatNumber(debit - credit, 2))
                                .SubItems.Add("")
                                dbl_total_expense += debit - credit
                            Else
                                .SubItems.Add(FormatNumber(credit - debit, 2))
                                .SubItems.Add("")
                                dbl_total_expense += credit - debit
                            End If

                        End With
                    Loop
                    Item = Me.lvIncomeStatement.Items.Add("          " & "Total Expenses")
                    Item.SubItems.Add("")
                    Item.SubItems.Add(FormatNumber(dbl_total_expense, 2))
                End If

                Dim net_income = dbl_total_revenue - dbl_total_expense
                Item = Me.lvIncomeStatement.Items.Add("")
                Item.SubItems.Add("")
                Item.SubItems.Add("")
                Item = lvIncomeStatement.Items.Add("NET INCOME")
                Item.SubItems.Add("")
                Item.SubItems.Add(net_income)
                'lblNet.Text = net_income
                'uscBalanceSheet.lblNet.Text = net_income
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        Else
            MsgBox("No journal entry found in the selected ledger", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "NO JOURNAL ENTRY FOUND")
            'select_ledger.Show()
            'select_ledger.cbo_ledger.SelectedValue = Nothing
        End If
    End Sub
    Public Sub lvwIncome_statementInCBO(Optional dt_from As String = "", Optional dt_to As String = "")
        Dim parameters As New Dictionary(Of String, Object)
        'Dim j_entry_dr As SqlDataReader
        Dim dbl_total_expense As Double = 0
        Dim dbl_total_revenue As Double = 0
        Dim debit, credit As New Double
        'lvIncomeStatement.Items.Clear()
        Dim Item As ListViewItem
        Dim journals(0) As String
        Dim journal_id_sql As String
        Dim counter As Integer


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

                'para sa revenue
                'dr = db.ExecuteReader("SELECT DISTINCT(a.id), a.name, IIF(jd.is_debit=0,jd.amount,0) as debit FROM journal_details jd JOIN accounts a ON jd.account_id=a.id where a.type=1")
                'dr = db.ExecuteReader("SELECT a.id,a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1 AND type=1 AND account_id=a.id) as debit,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=0 and account_id=a.id and a.type=3)as credit FROM accounts a WHERE a.type=1 AND a.id IN (SELECT account_id FROM journal_details jd WHERE jd.journal_id IN(" & journal_id_sql & ") )")
                dr = db.ExecuteReader("SELECT a.id,a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1  AND account_id=a.id) as debit,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=0 and account_id=a.id )as credit FROM accounts a WHERE a.type=1 AND a.id IN (SELECT account_id FROM journal_details jd WHERE jd.journal_id IN(" & journal_id_sql & ") )")
                Item = Me.lvIncomeStatement.Items.Add("Revenue")
                Item.SubItems.Add("")
                Item.SubItems.Add("")
                If dr.HasRows Then
                    Do While dr.Read

                        Item = Me.lvIncomeStatement.Items.Add("          " & dr.Item("name").ToString)
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

                        With Item
                            If debit > credit Then
                                .SubItems.Add(FormatNumber(debit - credit, 2))
                                .SubItems.Add("")
                                dbl_total_revenue += debit - credit
                            Else
                                .SubItems.Add(FormatNumber(credit - debit, 2))
                                .SubItems.Add("")
                                dbl_total_revenue += credit - debit
                            End If

                        End With

                    Loop
                    Item = Me.lvIncomeStatement.Items.Add("          " & "Total Revenues")
                    Item.SubItems.Add("")
                    Item.SubItems.Add(FormatNumber(dbl_total_revenue, 2))
                End If



                'para sa expenses
                dr = db.ExecuteReader("SELECT a.id,a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1  AND account_id=a.id) as debit,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=0 and account_id=a.id )as credit FROM accounts a WHERE a.type=3 AND a.id IN (SELECT account_id FROM journal_details jd WHERE jd.journal_id IN(" & journal_id_sql & ") )")
                'dr = db.ExecuteReader("SELECT DISTINCT(a.id),a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1 and account_id=a.id) as debit FROM journal_details jd JOIN accounts a ON jd.account_id=a.id where a.type=3")
                'dr = db.ExecuteReader("SELECT a.id,a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1 AND type=3 AND account_id=a.id) as debit,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=0 and account_id=a.id and a.type=3)as credit FROM accounts a WHERE a.id IN (SELECT account_id FROM journal_details jd WHERE jd.journal_id IN(" & journal_id_sql & ") )")
                Item = Me.lvIncomeStatement.Items.Add("Expenses")
                Item.SubItems.Add("")
                Item.SubItems.Add("")
                If dr.HasRows Then
                    Do While dr.Read
                        Item = Me.lvIncomeStatement.Items.Add("          " & dr.Item("name").ToString)
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

                        With Item
                            If debit > credit Then
                                .SubItems.Add(FormatNumber(debit - credit, 2))
                                .SubItems.Add("")
                                dbl_total_expense += debit - credit
                            Else
                                .SubItems.Add(FormatNumber(credit - debit, 2))
                                .SubItems.Add("")
                                dbl_total_expense += credit - debit
                            End If

                        End With
                    Loop
                    Item = Me.lvIncomeStatement.Items.Add("          " & "Total Expenses")
                    Item.SubItems.Add("")
                    Item.SubItems.Add(FormatNumber(dbl_total_expense, 2))
                End If

                Dim net_income = dbl_total_revenue - dbl_total_expense
                Item = Me.lvIncomeStatement.Items.Add("")
                Item.SubItems.Add("")
                Item.SubItems.Add("")
                Item = lvIncomeStatement.Items.Add("NET INCOME")
                Item.SubItems.Add("")
                Item.SubItems.Add(net_income)
                'lblNet.Text = net_income
                'uscBalanceSheet.lblNet.Text = net_income
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        Else
            MsgBox("No journal entry found in the selected ledger", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "NO JOURNAL ENTRY FOUND")
            'select_ledger.Show()
            'select_ledger.cbo_ledger.SelectedValue = Nothing
        End If








        'Exit Sub
        'Try
        '    '***PARA SA REVENUES
        '    dr = db.ExecuteReader("Select * from journal_details where account_id=1")
        '    If dr.HasRows Then
        '        Item = lvIncomeStatement.Items.Add("Revenues")
        '        Do While dr.Read
        '            Dim acct_name = dr.Item("account_name")
        '            Item = lvIncomeStatement.Items.Add("          " & acct_name)
        '            Item.SubItems.Add(dr.Item("amount"))
        '            Dim price = dr.Item("amount")
        '            dbl_total_revenue += price
        '        Loop
        '        Item = lvIncomeStatement.Items.Add("Total Revenues")
        '        Item.SubItems.Add("")
        '        Item.SubItems.Add(dbl_total_revenue)
        '    End If


        '    '***PARA SA EXPENSES
        '    dr = db.ExecuteReader("SELECT * FROM journal_details where account_id=3 ")
        '    If dr.HasRows Then
        '        Item = lvIncomeStatement.Items.Add("Expenses")
        '        Do While dr.Read
        '            Item = lvIncomeStatement.Items.Add("          " & dr.Item("account_name"))
        '            Item.SubItems.Add(dr.Item("amount"))
        '            Dim price = dr.Item("amount")
        '            dbl_total_expense += price
        '        Loop
        '        Item = lvIncomeStatement.Items.Add("Total Expenses")
        '        Item.SubItems.Add("")
        '        Item.SubItems.Add(dbl_total_expense)
        '        'Else
        '        '    'MsgBox("No expense.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error!")
        '    End If
        '    Dim net_income = dbl_total_revenue - dbl_total_expense
        '    Item = lvIncomeStatement.Items.Add("NET INCOME")
        '    Item.SubItems.Add("")
        '    Item.SubItems.Add(net_income)

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'Finally
        '    db.Dispose()
        'End Try
    End Sub

    Private Sub cmbDate_SelectedIndexChanged_1(sender As Object, e As EventArgs)
        'Dim selectedIndex As Integer
        'selectedIndex = cmbDate.SelectedIndex
        'If selectedIndex = 1 Then '#####DATE TODAY
        '    dt_from.Value = DateTime.Now
        '    dt_to.Value = DateTime.Now

        'ElseIf selectedIndex = 2 Then '#####THIS MONTH
        '    Dim firstDay As DateTime = New DateTime(Now.Year, Now.Month, 1)
        '    dt_from.Value = firstDay
        '    Dim lastDay As DateTime = New DateTime(Now.Year, Now.Month, 1).AddMonths(1).AddDays(-1)
        '    dt_to.Value = lastDay

        'ElseIf selectedIndex = 3 Then '#####LAST MONTH
        '    Dim firstDay As DateTime = New DateTime(Now.Year, Now.Month, 1).AddMonths(-1)
        '    dt_from.Value = firstDay
        '    Dim lastDay As DateTime = firstDay.AddMonths(1).AddDays(-1)
        '    dt_to.Value = lastDay

        'ElseIf selectedIndex = 4 Then '#####THIS QUARTER


        'ElseIf selectedIndex = 5 Then '#####LAST QUARTER


        'ElseIf selectedIndex = 6 Then '#####THIS YEAR


        'ElseIf selectedIndex = 7 Then '#####LAST YEAR

        'End If
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs)
        'Income_Statement_Load(DateToStr(dt_from.Text), DateToStr(dt_to.Text))
    End Sub
    Private Sub showINC(mode As Boolean)
        pnlPrint.Visible = mode
        pnlIncMain.Enabled = Not mode
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        'Me.Hide()
        'tbalance_journal.ShowDialog()
        'codes
        If Trim(txtTitle.Text = "") Or Trim(txtDescription.Text) = "" Then
            MsgBox("Please Set the title and the description", vbExclamation + vbOKOnly, "No title and description")
            Exit Sub
        End If
        Try
            Dim row1 As DataRow = Nothing

            Dim DS As New DataSet
            Dim rptINC As New IncomeStatement
            'mag a-add na sa dataset (DS)
            DS.Tables.Add("IncomeStatement")
            'lagay tayo ng columns
            With DS.Tables(0).Columns
                .Add("Entries")
                .Add("Debit")
                .Add("Credit")
                .Add("Title")
                .Add("Description")
            End With
            For x = 1 To lvIncomeStatement.Items.Count Step 1
                row1 = DS.Tables(0).NewRow
                row1(0) = lvIncomeStatement.Items(x - 1).Text
                row1(1) = lvIncomeStatement.Items(x - 1).SubItems(1).Text
                row1(2) = lvIncomeStatement.Items(x - 1).SubItems(2).Text
                row1(3) = txtTitle.Text
                row1(4) = txtDescription.Text
                DS.Tables(0).Rows.Add(row1)
            Next


            DS.WriteXml("XML\IncomeStatement.xml")

            Dim dsINC As New DataSet
            dsINC = New DSreportsAccounting
            Dim dsINCTemp As New DataSet
            dsINCTemp = New DataSet()
            'dsINCTemp = New DSreports
            dsINCTemp.ReadXml("XML\IncomeStatement.xml")
            dsINC.Merge(dsINCTemp.Tables(0))

            'MsgBox(dsINCTemp.Tables(0).Rows(0).Item(0).ToString)
            rptINC = New IncomeStatement
            rptINC.SetDataSource(dsINCTemp.Tables(0))
            crvInc.ReportSource = rptINC
            showINC(True)

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)

        End Try

    End Sub

    ''METHODS
    Private Sub showPrintMe(mode As Boolean)
        pnlPrint.Visible = mode
        pnlIncMain.Enabled = Not mode
    End Sub

    Private Sub btnCancelPrintattack_Click(sender As Object, e As EventArgs) Handles btnCancelPrintattack.Click
        showINC(False)
    End Sub

    Private Sub btnPrintAttack_Click(sender As Object, e As EventArgs) Handles btnPrintAttack.Click
        crvInc.PrintReport()
    End Sub

    Public Function postTO(x As Integer)
        If x = 1 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class