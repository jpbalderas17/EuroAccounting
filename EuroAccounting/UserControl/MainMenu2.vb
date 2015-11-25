Public Class MainMenu2

    Private Sub btn_View_Journal_Click(sender As Object, e As EventArgs) Handles btn_View_Journal.Click
        showUSC(uscViewJournal)
    End Sub

    Private Sub btn_Users_Click(sender As Object, e As EventArgs) Handles btn_Users.Click
        showUSC(uscUsers)
    End Sub

    Private Sub btn_Manage_Acc_Click(sender As Object, e As EventArgs) Handles btn_Manage_Acc.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        LogIn.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
