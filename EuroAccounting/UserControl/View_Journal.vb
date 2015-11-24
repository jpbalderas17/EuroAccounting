Public Class View_Journal

    Private Sub View_Journal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'pnl_Journal.Width -= 10
    End Sub

    Private Sub View_Journal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'Try

        '    For Each ex_ni_jenny In Me.pnl_Journal.Controls
        '        If TypeOf ex_ni_jenny Is Journal_Entry Then
        '            ex_ni_jenny.width = pnl_Journal.Width

        '        End If
        '    Next

        '    'j_entry.Width = pnl_Journal.Width
        '    'j_entry.Height = pnl_Journal.Height

        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        showUSC(uscAddJournal)
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click


    End Sub

    Private Sub pnl_Journal_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Journal.Paint

    End Sub
End Class
