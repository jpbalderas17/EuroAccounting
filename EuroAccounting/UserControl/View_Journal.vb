Public Class View_Journal

    Private Sub View_Journal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pnl_Journal.Width -= 10
    End Sub

    Private Sub View_Journal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'Try

        '    For Each ex_ni_jenny In Me.pnl_Journal.Controls
        '        If TypeOf ex_ni_jenny Is Journal_Entry Then
        '            ex_ni_jenny.width = pnl_Journal.Width

        '        End If
        '    Next

        '    'j_entry.Width = pnl_Journal.Width
        '    'j_entry.Height = pnl_Journal.Height

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnAdd_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
        showUSC(uscAddJournal)
    End Sub

    Private Sub btn_Close_Click_1(sender As Object, e As EventArgs) Handles btn_Close.Click
        showUSC(uscMainMenu)
    End Sub

    Private Sub cmbPost_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPost.SelectedIndexChanged
        If cmbPost.Text = "Trial Balance" Then
            showUSC(uscTrialBalance)
        ElseIf cmbPost.Text = "Ledger (3 Column Ledger)" Then
            showUSC(uscLedger)
        ElseIf cmbPost.Text = "Income Statement" Then
            showUSC(uscIncomeStatement)
        ElseIf cmbPost.Text = "Balance Sheet" Then
            showUSC(uscBalanceSheet)
        End If



    End Sub
End Class
