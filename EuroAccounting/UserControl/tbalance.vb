Imports System.Data.SqlClient
Imports System.Text
Imports System.Runtime.InteropServices

Public Class tbalance
    Public ledger_id As Integer
    Dim ledger_name, ledger_description As String
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Dim db As New DBHelper(My.Settings.connectionString)
    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub SetCueText(ByVal control As Control, ByVal text As String)
        SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
    End Sub
    Public Sub load_tbalance(Optional dt_from = "", Optional dt_to = "")
        '#get journals

        Dim journals(0) As String
        Dim journal_id_sql As String
        Dim counter As Integer
        Dim dbl_total_debit, dbl_total_credit, debit, credit As New Double
        Dim Item As ListViewItem
        lvtbalance.Items.Clear()
        If dt_from <> "" And dt_to = "" Then
            MsgBox("Please select End Date.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INVALID FILTER")
            Exit Sub
        ElseIf dt_to <> "" And dt_from = "" Then
            MsgBox("Please select Start Date.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INVALID FILTER")
            Exit Sub
        End If

        If dt_from <> "" And dt_to <> "" Then

            dr = db.ExecuteReader("SELECT id FROM journals WHERE ledger_id=" & uscMainMenu.ledger_id & "AND journal_date BETWEEN " & dt_from & " AND " & dt_to)
        Else
            dr = db.ExecuteReader("SELECT id FROM journals WHERE ledger_id=" & uscMainMenu.ledger_id)
        End If
        counter = 0
        Try
            If dr.HasRows Then

                Do While dr.Read
                    ReDim Preserve journals(counter)
                    journals(counter) = (dr.Item(0))
                    counter += 1
                Loop
                journal_id_sql = String.Join(",", journals)


                dr = db.ExecuteReader("SELECT a.id,a.name,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=1 and account_id=a.id) as debit,(SELECT SUM(amount) FROM journal_details WHERE journal_id IN (" & journal_id_sql & ") AND is_debit=0 and account_id=a.id)as credit FROM accounts a WHERE a.id IN (SELECT account_id FROM journal_details jd WHERE jd.journal_id IN(" & journal_id_sql & ") )")

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


                        Item = Me.lvtbalance.Items.Add(dr.Item("name").ToString)

                        With Item
                            If debit > credit Then
                                .SubItems.Add(FormatNumber(debit - credit, 2))
                                .SubItems.Add("")
                                dbl_total_debit += debit - credit
                            Else
                                .SubItems.Add("")
                                .SubItems.Add(FormatNumber(credit - debit, 2))
                                dbl_total_credit += credit - debit
                            End If

                        End With
                    Loop
                    Item = Me.lvtbalance.Items.Add("")

                    With Item
                        .SubItems.Add("")
                        .SubItems.Add("")
                    End With

                    Item = Me.lvtbalance.Items.Add("Total")
                    Item.SubItems.Add(FormatNumber(dbl_total_debit, 2))
                    Item.SubItems.Add(FormatNumber(dbl_total_credit, 2))
                End If
           
        Else
                If dt_from <> "" And dt_to = "" Then
                    MsgBox("No journal entry found within the selected dates", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "NO JOURNAL ENTRY FOUND")

                    Exit Sub
                ElseIf dt_to <> "" And dt_from = "" Then
                    MsgBox("No journal entry found in the selected ledger", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "NO JOURNAL ENTRY FOUND")

                    Exit Sub
                End If
        End If
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical + vbOKOnly, "Error")
        Finally
            db.Dispose()
        End Try
    End Sub
    
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        'showUSC(uscViewJournal)
        'uscViewJournal.cmbPost.Text = ""
        showUSC(uscMainMenu)
        uscTrialBalance = New tbalance
    End Sub
    Public Sub get_ledger_details()
        'Try
        dr = db.ExecuteReader("SELECT id,name,description FROM ledgers WHERE id=" & uscMainMenu.ledger_id)
        If dr.HasRows Then
            dr.Read()
            If IsDBNull(dr.Item("description")) = True Then
                Me.ledger_description = ""
            Else
                Me.ledger_description = dr.Item("description")
            End If
            If IsDBNull(dr.Item("name")) = True Then
                Me.ledger_name = ""
            Else
                Me.ledger_name = dr.Item("name")
            End If
        End If
        'Catch ex As Exception
        '    MsgBox(ex.ToString, vbCritical + vbOKOnly, "Error")
        'Finally
        '    db.Dispose()
        'End Try
    End Sub
   


    Private Sub tbalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
        'Me.ledger_id = select_ledger.cbo_ledger.SelectedValue
        'load_tbalance()

        SetCueText(txtTitle, "Enter Title")
        SetCueText(txtDescription, "Enter Description")

    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs)
        'lbl_ledger_name.Text = txtname.Text
    End Sub

    Private Sub txtmisc_TextChanged(sender As Object, e As EventArgs)
        'lbl_ledger_description.Text = txtmisc.Text
    End Sub

    Private Sub btn_filter_Click(sender As Object, e As EventArgs) Handles btn_filter.Click
        load_tbalance(DateToStr(dt_from.Text), DateToStr(dt_to.Text))
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        If Trim(txtTitle.Text = "") Or Trim(txtDescription.Text) = "" Then
            MsgBox("Please Set the title and the description", vbExclamation + vbOKOnly, "No title and description")
            Exit Sub
        Else
            tbalance_report.ShowDialog()
        End If
    End Sub
End Class