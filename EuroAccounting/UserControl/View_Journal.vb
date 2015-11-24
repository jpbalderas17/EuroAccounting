Public Class View_Journal
    'Dim j_entry As New Journal_Entry
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j_entry = New Journal_Entry
        'j_entry.Width = currentUSC.Width - 20
        'j_entry.resize(currentUSC.Width - 20)
        j_entry.Width = pnl_Journal.Width
        pnl_Journal.Controls.Add(j_entry)

    End Sub

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click

    End Sub

    Private Sub pnl_Journal_Paint(sender As Object, e As PaintEventArgs) Handles pnl_Journal.Paint

    End Sub

    Private Sub View_Journal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnl_Journal.Width -= 10
    End Sub

    Private Sub View_Journal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Try

            For Each ex_ni_jenny In Me.pnl_Journal.Controls
                If TypeOf ex_ni_jenny Is Journal_Entry Then
                    ex_ni_jenny.width = pnl_Journal.Width

                End If
            Next

            'j_entry.Width = pnl_Journal.Width
            'j_entry.Height = pnl_Journal.Height

        Catch ex As Exception

        End Try
    End Sub
End Class
