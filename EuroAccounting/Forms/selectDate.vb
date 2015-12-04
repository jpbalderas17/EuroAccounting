Public Class selectDate

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim title As String = lblview.Text
        Select Case title
            Case "Balance Sheet"
                showUSC(uscBalanceSheet)
                Me.Close()
            Case "Ledger"
                showUSC(uscLedger)
                Me.Close()
        End Select
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        Me.Close()
    End Sub

    Private Sub selectDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDate.SelectedIndex = 0
    End Sub

    Private Sub cmbDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDate.SelectedIndexChanged
        Dim selectedIndex As Integer
        selectedIndex = cmbDate.SelectedIndex
        If selectedIndex = 1 Then '#####TODAY
            dtpDate.Value = DateTime.Now

        ElseIf selectedIndex = 2 Then '#####YESTERDAY
            dtpDate.Value = DateTime.Now.AddDays(-1)

        ElseIf selectedIndex = 3 Then '#####END OF LAST MONTH
            Dim petsa = New DateTime(Now.Year, Now.Month, 1).AddMonths(-1).AddDays(-1)
            dtpDate.Value = petsa

        ElseIf selectedIndex = 4 Then '#####END OF LAST YEAR
            Dim dlastDay As DateTime = CType("12/31/" & Date.Now.Year, Date).AddYears(-1)
            dtpDate.Value = dlastDay.ToString()
        End If
    End Sub
End Class