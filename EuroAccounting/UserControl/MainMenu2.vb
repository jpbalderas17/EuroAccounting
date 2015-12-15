Public Class MainMenu2
    Public getter As String
    Private Sub showChoices(mode As Boolean)

    End Sub
    Private Sub btn_View_Journal_Click(sender As Object, e As EventArgs) Handles btn_View_Journal.Click
        'showUSC(uscViewJournal)
        uscLedgers.lvLoadListview()
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

    Private Sub btn_Ledger_Click(sender As Object, e As EventArgs)
        ''showUSC(uscLedger)
        'selectDate.lblview.Text = "Ledger"
        'selectDate.Show()


        '# Create new ledger to reset data
        uscLedger = New Ledger
        select_ledger.ShowDialog()
    End Sub
    Private Sub btn_Balance_Sheet_Click(sender As Object, e As EventArgs) Handles btn_Balance_Sheet.Click
        'selectDate.lblview.Text = "Balance Sheet"
        'selectDate.Show()
        getter = "Balance sheet"
        select_ledger.ShowDialog()
    End Sub

    Private Sub btn_Cash_Flow_Click(sender As Object, e As EventArgs) Handles btn_Cash_Flow.Click
        getter = "Cash flow"
        select_ledger.ShowDialog()
    End Sub

    Private Sub btn_Trial_Balance_Click(sender As Object, e As EventArgs) Handles btn_Trial_Balance.Click
        'selectPeriod.lblview.Text = "Trial Balance"
        'selectPeriod.Show()
        getter = "Trial balance"
        select_ledger.ShowDialog()
    End Sub

    Private Sub btn_Income_Statement_Click(sender As Object, e As EventArgs) Handles btn_Income_Statement.Click
        'selectPeriod.lblview.Text = "Income Statement"
        'selectPeriod.Show()
        


        getter = "Income statement"
        select_ledger.ShowDialog()


    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        LogIn.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LogIn.Show()
        MainMenu.Hide()
    End Sub

    Private Sub btn_archives_Click(sender As Object, e As EventArgs) Handles btn_archives.Click
        uscArchives.lvLoadListview()
        showUSC(uscArchives)
    End Sub



    Private Sub btn3ColLedger_Click(sender As Object, e As EventArgs) Handles btn3ColLedger.Click
        getter = "3 Column ledger"
        select_ledger.ShowDialog()
    End Sub

    Private Sub btnDbBackUp_Click(sender As Object, e As EventArgs) Handles btnDbBackUp.Click
        DatabaseBackupRestore.ShowDialog()
    End Sub
End Class
