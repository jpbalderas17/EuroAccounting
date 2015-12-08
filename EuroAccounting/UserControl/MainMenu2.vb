Public Class MainMenu2
    Private Sub showChoices(mode As Boolean)

    End Sub
    Private Sub btn_View_Journal_Click(sender As Object, e As EventArgs) Handles btn_View_Journal.Click
        'showUSC(uscViewJournal)
        showUSC(uscLedgers)
    End Sub

    Private Sub btn_Users_Click(sender As Object, e As EventArgs) Handles btn_Users.Click
        showUSC(uscUsers)
    End Sub

    Private Sub btn_Manage_Acc_Click(sender As Object, e As EventArgs) Handles btn_Manage_Acct.Click
        showUSC(uscAccounts)
    End Sub

    'Private Sub btn_Services_Click(sender As Object, e As EventArgs) Handles btn_Services.Click
    '    uscServiceSupplyEntry.lbl_journal_type.Text = "Service"
    '    showUSC(uscServiceSupplyEntry)
    'End Sub

    'Private Sub btn_Purchase_Click(sender As Object, e As EventArgs) Handles btn_Purchase.Click
    '    uscServiceSupplyEntry.lbl_journal_type.Text = "Purchase Supplies"
    '    showUSC(uscServiceSupplyEntry)
    'End Sub

    'Private Sub btn_sales_Click(sender As Object, e As EventArgs) Handles btn_sales.Click
    '    uscServiceSupplyEntry.lbl_journal_type.Text = "Sales"
    '    showUSC(uscServiceSupplyEntry)
    'End Sub

    Private Sub btn_Ledger_Click(sender As Object, e As EventArgs) Handles btn_Ledger.Click
        'showUSC(uscLedger)
        selectDate.lblview.Text = "Ledger"
        selectDate.Show()
    End Sub
    Private Sub btn_Balance_Sheet_Click(sender As Object, e As EventArgs) Handles btn_Balance_Sheet.Click
        selectDate.lblview.Text = "Balance Sheet"
        selectDate.Show()
    End Sub

    Private Sub btn_Cash_Flow_Click(sender As Object, e As EventArgs) Handles btn_Cash_Flow.Click
        selectPeriod.lblview.Text = "Cash Flow"
        selectPeriod.Show()
    End Sub

    Private Sub btn_Trial_Balance_Click(sender As Object, e As EventArgs) Handles btn_Trial_Balance.Click
        selectPeriod.lblview.Text = "Trial Balance"
        selectPeriod.Show()
    End Sub

    Private Sub btn_Income_Statement_Click(sender As Object, e As EventArgs) Handles btn_Income_Statement.Click
        selectPeriod.lblview.Text = "Income Statement"
        selectPeriod.Show()
    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LogIn.Show()
        MainMenu.Hide()
    End Sub
End Class
