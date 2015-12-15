Public Class tbalance_report
    Private Sub btnCancelPrintattack_Click(sender As Object, e As EventArgs) Handles btnCancelPrintattack.Click
        Me.Hide()
        showUSC(uscTrialBalance)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        crvTB.PrintReport()
    End Sub

    Private Sub tbalance_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim row1 As DataRow = Nothing
        Dim lvTrialBalance = uscTrialBalance.lvtbalance

        Try
            Dim DS As New DataSet
            Dim rptTb As New TrialBalance
            'mag a-add na sa dataset (DS)
            DS.Tables.Add("TrialBalance")
            'lagay tayo ng columns
            With DS.Tables(0).Columns
                .Add("Accounts")
                .Add("Debit")
                .Add("Credit")
                .Add("Title")
                .Add("Description")
            End With
            For x = 1 To lvTrialBalance.Items.Count Step 1
                row1 = DS.Tables(0).NewRow
                row1(0) = lvTrialBalance.Items(x - 1).Text
                row1(1) = lvTrialBalance.Items(x - 1).SubItems(1).Text
                row1(2) = lvTrialBalance.Items(x - 1).SubItems(2).Text
                row1(3) = uscTrialBalance.txtTitle.Text
                row1(4) = uscTrialBalance.txtDescription.Text
                DS.Tables(0).Rows.Add(row1)
            Next


            DS.WriteXml("XML\TrialBalance.xml")

            Dim dsINC As New DataSet
            dsINC = New DSreportsAccounting
            Dim dsINCTemp As New DataSet
            dsINCTemp = New DataSet()
            'dsINCTemp = New DSreports
            dsINCTemp.ReadXml("XML\TrialBalance.xml")
            dsINC.Merge(dsINCTemp.Tables(0))
            'MsgBox(dsINCTemp.Tables(0).Rows(0).Item(0).ToString)
            rptTb = New TrialBalance
            rptTb.SetDataSource(dsINCTemp.Tables(0))
            crvTB.ReportSource = rptTb
            'crvTbalance.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub
End Class