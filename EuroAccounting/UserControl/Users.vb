Public Class Users

    Private Sub clearUserGroup()

        For Each Control In pnl_user.Controls
            If TypeOf Control Is ComboBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control

        For Each Control In pnl_user.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        showUSC(uscMainMenu)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        pnl_user.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        pnl_user.Visible = False
        clearUserGroup()
    End Sub

End Class
