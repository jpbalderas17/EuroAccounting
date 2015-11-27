Public Class MainMenu2
    Private Sub showChoices(mode As Boolean)

    End Sub
    Private Sub btn_View_Journal_Click(sender As Object, e As EventArgs) Handles btn_View_Journal.Click
        showUSC(uscViewJournal)
    End Sub

    Private Sub btn_Users_Click(sender As Object, e As EventArgs) Handles btn_Users.Click
        showUSC(uscUsers)
    End Sub

    Private Sub btn_Manage_Acc_Click(sender As Object, e As EventArgs) Handles btn_Manage_Acc.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        LogIn.Show()
        MainMenu.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

  

    Private Sub btn_Services_Click(sender As Object, e As EventArgs) Handles btn_Services.Click
        uscServiceSupplyEntry.lbl_journal_type.Text = "Service"
        showUSC(uscServiceSupplyEntry)
    End Sub

    Private Sub btn_Purchase_Click(sender As Object, e As EventArgs) Handles btn_Purchase.Click
        uscServiceSupplyEntry.lbl_journal_type.Text = "Purchase Supplies"
        showUSC(uscServiceSupplyEntry)
    End Sub

    Private Sub btn_payments_Click(sender As Object, e As EventArgs) Handles btn_payments.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles pnl_mains.Paint

    End Sub

    Private Sub btn_Completion_Click(sender As Object, e As EventArgs) Handles btn_Completion.Click

    End Sub

    Private Sub btn_sales_Click(sender As Object, e As EventArgs) Handles btn_sales.Click
        uscServiceSupplyEntry.lbl_journal_type.Text = "Sales"
        showUSC(uscServiceSupplyEntry)
    End Sub
End Class
