Public Class selectPeriod

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim title As String = lblview.Text
        Select Case title
            Case "Trial Balance"
                showUSC(uscTrialBalance)
                Me.Close()
            Case "Income Statement"
                showUSC(uscIncomeStatement)
                Me.Close()
            Case "Cash Flow"
                Me.Close()

        End Select
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub selectDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDate.SelectedIndex = 2
    End Sub
    Public Function LastDayOfMonth(ByVal sourceDate As DateTime) As DateTime
        Dim lastDay As DateTime = New DateTime(sourceDate.Year, sourceDate.Month, 1)
        Return lastDay.AddMonths(1).AddDays(-1)
    End Function

    Private Sub cmbDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDate.SelectedIndexChanged
        Dim selectedIndex As Integer
        selectedIndex = cmbDate.SelectedIndex
        If selectedIndex = 1 Then '#####DATE TODAY
            dtpStartDate.Value = DateTime.Now
            dtpEndDate.Value = DateTime.Now

        ElseIf selectedIndex = 2 Then '#####THIS MONTH
            Dim firstDay As DateTime = New DateTime(Now.Year, Now.Month, 1)
            dtpStartDate.Value = firstDay
            Dim lastDay As DateTime = New DateTime(Now.Year, Now.Month, 1).AddMonths(1).AddDays(-1)
            dtpEndDate.Value = lastDay

        ElseIf selectedIndex = 3 Then '#####LAST MONTH
            Dim firstDay As DateTime = New DateTime(Now.Year, Now.Month, 1).AddMonths(-1)
            dtpStartDate.Value = firstDay
            Dim lastDay As DateTime = firstDay.AddMonths(1).AddDays(-1)
            dtpEndDate.Value = lastDay

        ElseIf selectedIndex = 4 Then '#####THIS QUARTER


        ElseIf selectedIndex = 5 Then '#####LAST QUARTER


        ElseIf selectedIndex = 6 Then '#####THIS YEAR


        ElseIf selectedIndex = 7 Then '#####LAST YEAR

        End If
    End Sub
End Class