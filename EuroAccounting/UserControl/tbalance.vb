
Public Class tbalance
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        'showUSC(uscViewJournal)
        'uscViewJournal.cmbPost.Text = ""
        showUSC(uscMainMenu)
    End Sub

    Private Sub tbalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged
        lbltitle1.Text = txtname.Text
    End Sub

    Private Sub txtmisc_TextChanged(sender As Object, e As EventArgs) Handles txtmisc.TextChanged
        lbltitle2.Text = txtmisc.Text
    End Sub
End Class