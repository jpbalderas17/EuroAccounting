Public Class MainMenu


    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frm_MainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        showUSC(uscMainMenu)

    End Sub

    Private Sub frm_MainMenu_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try
            panelMain.Width = Me.Width
            panelMain.Height = Me.Height
            currentUSC.Width = Me.Width

        Catch ex As Exception

        End Try
    End Sub
End Class