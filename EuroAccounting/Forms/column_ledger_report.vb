Public Class column_ledger_report

    Private Sub column_ledger_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim row1 As DataRow = Nothing
            Dim lvColumnLedger = uscLedger.lvw_ledger
            Dim DS As New DataSet
            Dim rptCL As New ColumnLedger
            'mag a-add na sa dataset (DS)
            DS.Tables.Add("ColumnLedger")
            'lagay tayo ng columns
            With DS.Tables(0).Columns
                .Add("Accounts")
                .Add("Debit")
                .Add("Credit")
                .Add("Balance")
            End With
            For x = 1 To lvColumnLedger.Items.Count Step 1
                row1 = DS.Tables(0).NewRow
                row1(0) = lvColumnLedger.Items(x - 1).Text
                row1(1) = lvColumnLedger.Items(x - 1).SubItems(1).Text
                row1(2) = lvColumnLedger.Items(x - 1).SubItems(2).Text
                row1(3) = lvColumnLedger.Items(x - 1).SubItems(3).Text
                'row1(3) = uscBalanceSheet.txtTitle.Text
                'row1(4) = uscBalanceSheet.txtDescription.Text
                DS.Tables(0).Rows.Add(row1)
            Next


            DS.WriteXml("XML\ColumnLedger.xml")
            'MsgBox("XML created.")
            'Exit Sub


            Dim dsINC As New DataSet
            dsINC = New DSreportsAccounting
            Dim dsINCTemp As New DataSet
            dsINCTemp = New DataSet()
            'dsINCTemp = New DSreports
            dsINCTemp.ReadXml("XML\ColumnLedger.xml")
            dsINC.Merge(dsINCTemp.Tables(0))

            'MsgBox(dsINCTemp.Tables(0).Rows(0).Item(0).ToString)
            rptCL = New ColumnLedger
            rptCL.SetDataSource(dsINCTemp.Tables(0))
            crvCL.ReportSource = rptCL
            'showINC(True)

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        crvCL.PrintReport()
    End Sub

    Private Sub btnCancelPrintattack_Click(sender As Object, e As EventArgs) Handles btnCancelPrintattack.Click
        Me.Hide()
        showUSC(uscLedger)
    End Sub
End Class