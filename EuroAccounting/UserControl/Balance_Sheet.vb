Imports System.Data.SqlClient
Imports System.Text
Imports System.Runtime.InteropServices

Public Class Balance_Sheet
    Dim ledger_id As Integer
    Dim ledger_name, ledger_description As String
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim net, total_oe As Double
    Private Const EM_SETCUEBANNER As Integer = &H1501
    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub SetCueText(ByVal control As Control, ByVal text As String)
        SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        showUSC(uscMainMenu)
        uscBalanceSheet = New Balance_Sheet
    End Sub
    Private Sub Balance_Sheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCueText(txtTitle, "Enter Title")
        SetCueText(txtDescription, "Enter Description")

        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        Me.ledger_id = select_ledger.cbo_ledger.SelectedValue
        getNet()
        load_balanceSheet()


    End Sub
    Private Sub load_balanceSheet()
        '#get journals
        Dim parameters As New Dictionary(Of String, Object)
        Dim dbl_total_liabilities As Double = 0
        Dim dbl_total_asset As Double = 0
        Dim dbl_total_Oequity As Double = 0
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

                'para sa asset
                dr = db.ExecuteReader("SELECT a.id,a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1  AND account_id=a.id) as debit,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=0 and account_id=a.id )as credit FROM accounts a WHERE a.type in (4,5) AND a.id IN (SELECT account_id FROM journal_details jd WHERE jd.journal_id IN(" & journal_id_sql & ") )")
                If dr.HasRows Then
                    Item = Me.lvbalance_sheet.Items.Add("ASSET")
                    Item.SubItems.Add("")
                    Item.SubItems.Add("")
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


                        Item = Me.lvbalance_sheet.Items.Add(dr.Item("name").ToString)

                        With Item
                            If debit > credit Then
                                .SubItems.Add(FormatNumber(debit - credit, 2))
                                .SubItems.Add("")
                                dbl_total_asset += debit - credit
                            Else
                                .SubItems.Add("")
                                .SubItems.Add(FormatNumber(credit - debit, 2))
                                dbl_total_asset += credit - debit
                            End If

                        End With
                    Loop
                    Item = Me.lvbalance_sheet.Items.Add("          " & "Total Current Assets")
                    Item.SubItems.Add("")
                    Item.SubItems.Add(FormatNumber(dbl_total_asset, 2))
                End If




                'para sa liabilities
                dr = db.ExecuteReader("SELECT a.id,a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1  AND account_id=a.id) as debit,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=0 and account_id=a.id )as credit FROM accounts a WHERE a.type in (6) AND a.id IN (SELECT account_id FROM journal_details jd WHERE jd.journal_id IN(" & journal_id_sql & ") )")
                If dr.HasRows Then
                    Item = Me.lvbalance_sheet.Items.Add("")
                    Item.SubItems.Add("")
                    Item.SubItems.Add("")
                    Item = Me.lvbalance_sheet.Items.Add("LIABILITIES")
                    Item.SubItems.Add("")
                    Item.SubItems.Add("")
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


                        Item = Me.lvbalance_sheet.Items.Add(dr.Item("name").ToString)

                        With Item
                            If debit > credit Then
                                .SubItems.Add(FormatNumber(debit - credit, 2))
                                .SubItems.Add("")
                                dbl_total_liabilities += debit - credit
                            Else
                                .SubItems.Add(FormatNumber(credit - debit, 2))
                                .SubItems.Add("")
                                dbl_total_liabilities += credit - debit
                            End If

                        End With
                    Loop
                    Item = Me.lvbalance_sheet.Items.Add("          " & "Total Current Liabilities")
                    Item.SubItems.Add("")
                    Item.SubItems.Add(FormatNumber(dbl_total_liabilities, 2))
                End If



                'para sa owner's equity
                dr = db.ExecuteReader("SELECT a.id,a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1  AND account_id=a.id) as debit,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=0 and account_id=a.id )as credit FROM accounts a WHERE a.type in (8,9) AND a.id IN (SELECT account_id FROM journal_details jd WHERE jd.journal_id IN(" & journal_id_sql & ") )")
                If dr.HasRows Then
                    Item = Me.lvbalance_sheet.Items.Add("")
                    Item.SubItems.Add("")
                    Item.SubItems.Add("")
                    Item = Me.lvbalance_sheet.Items.Add("OWNER'S EQUITY")
                    Item.SubItems.Add("")
                    Item.SubItems.Add("")
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


                        Item = Me.lvbalance_sheet.Items.Add(dr.Item("name").ToString)

                        With Item
                            If debit > credit Then
                                .SubItems.Add(FormatNumber(debit - credit, 2))
                                .SubItems.Add("")
                                dbl_total_Oequity += debit - credit
                            Else
                                .SubItems.Add(FormatNumber(credit - debit, 2))
                                .SubItems.Add("")
                                dbl_total_Oequity += credit - debit
                            End If

                        End With
                    Loop
                    Item = Me.lvbalance_sheet.Items.Add("Retained Earnings")
                    Item.SubItems.Add(FormatNumber(net, 2))
                    Item.SubItems.Add("")

                    Item = Me.lvbalance_sheet.Items.Add("          " & "Total Current Owner's Equity")
                    Item.SubItems.Add("")
                    total_oe = net + dbl_total_Oequity
                    Item.SubItems.Add(FormatNumber(total_oe, 2))
                End If

                'COMPUTATION
                Dim total_liabilities_equity As Double = dbl_total_liabilities + total_oe
                Item = lvbalance_sheet.Items.Add("")
                Item.SubItems.Add("")
                Item.SubItems.Add("")
                Item = lvbalance_sheet.Items.Add("TOTAL LIABILITIES AND OWNER'S EQUITY")
                Item.SubItems.Add("")
                Item.SubItems.Add(FormatNumber(total_liabilities_equity, 2))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        Else
            MsgBox("No journal entry found in the selected ledger", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "NO JOURNAL ENTRY FOUND")
        End If
    End Sub

    Private Sub getNet()
        Dim parameters As New Dictionary(Of String, Object)
        Dim dbl_total_expense As Double = 0
        Dim dbl_total_revenue As Double = 0
        Dim debit, credit As New Double
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
                dr = db.ExecuteReader("SELECT a.id,a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1  AND account_id=a.id) as debit,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=0 and account_id=a.id )as credit FROM accounts a WHERE a.type=1 AND a.id IN (SELECT account_id FROM journal_details jd WHERE jd.journal_id IN(" & journal_id_sql & ") )")
                'dr = db.ExecuteReader("SELECT DISTINCT(a.id), a.name, IIF(jd.is_debit=0,jd.amount,0) as debit FROM journal_details jd JOIN accounts a ON jd.account_id=a.id where a.type=1")
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

                        If debit > credit Then
                            FormatNumber(debit - credit, 2)
                            dbl_total_revenue += debit - credit
                        Else
                            FormatNumber(credit - debit, 2)
                            dbl_total_revenue += credit - debit
                        End If

                    Loop
                End If

                'para sa expenses
                dr = db.ExecuteReader("SELECT a.id,a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1  AND account_id=a.id) as debit,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=0 and account_id=a.id )as credit FROM accounts a WHERE a.type=3 AND a.id IN (SELECT account_id FROM journal_details jd WHERE jd.journal_id IN(" & journal_id_sql & ") )")
                'dr = db.ExecuteReader("SELECT DISTINCT(a.id),a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1 and account_id=a.id) as debit FROM journal_details jd JOIN accounts a ON jd.account_id=a.id where a.type=3")
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

                        If debit > credit Then
                            FormatNumber(debit - credit, 2)
                            dbl_total_expense += debit - credit
                        Else
                            FormatNumber(credit - debit, 2)
                            dbl_total_expense += credit - debit
                        End If
                    Loop
                End If
                net = dbl_total_revenue - dbl_total_expense
                'MsgBox(dbl_total_revenue)
                'MsgBox(dbl_total_expense)
                'MsgBox(net_income)
                'lblNet.Text = net
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

    'Private Sub cmbDate_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    Dim selectedIndex As Integer
    '    selectedIndex = cmbDate.SelectedIndex
    '    If selectedIndex = 1 Then '#####TODAY
    '        dtpDate.Value = DateTime.Now

    '    ElseIf selectedIndex = 2 Then '#####YESTERDAY
    '        dtpDate.Value = DateTime.Now.AddDays(-1)

    '    ElseIf selectedIndex = 3 Then '#####END OF LAST MONTH
    '        Dim petsa = New DateTime(Now.Year, Now.Month, 1).AddMonths(-1).AddDays(-1)
    '        dtpDate.Value = petsa

    '    ElseIf selectedIndex = 4 Then '#####END OF LAST YEAR
    '        Dim dlastDay As DateTime = CType("12/31/" & Date.Now.Year, Date).AddYears(-1)
    '        dtpDate.Value = dlastDay.ToString()
    '    End If
    'End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        If Trim(txtTitle.Text = "") Or Trim(txtDescription.Text) = "" Then
            MsgBox("Please Set the title and the description", vbExclamation + vbOKOnly, "No title and description")
            Exit Sub
        Else
            balance_sheet_report.ShowDialog()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class