Public Class MainMenu23

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'showUSC(uscEntry)
    End Sub
    Private Sub MainMenu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            currentUSC.Width = panelMain.Width
            currentUSC.Height = panelMain.Height
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'currentUSC = uscEntry
        'currentUSC.Parent = Me.panelMain
        'currentUSC.Width = Me.panelMain.Width
        'currentUSC.Height = Me.panelMain.Height
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub AddEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEntryToolStripMenuItem.Click
        showUSC(uscAddJournal)
    End Sub
End Class
