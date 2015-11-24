
Public Class AddEntry
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Dim j_entry = New Journal_Entry
        'j_entry.Width = pnl_Journal.Width
        'pnl_Journal.Controls.Add(j_entry)
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        showUSC(uscViewJournal)
    End Sub
End Class