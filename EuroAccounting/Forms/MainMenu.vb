Public Class MainMenu
    Private Sub frm_MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        showUSC(uscMainMenu)

    End Sub

    Private Sub frm_MainMenu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            currentUSC.Width = panelMain.Width
            currentUSC.Height = panelMain.Height
        Catch ex As Exception

        End Try
    End Sub
End Class