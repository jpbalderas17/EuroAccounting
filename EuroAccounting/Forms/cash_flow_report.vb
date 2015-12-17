Public Class cash_flow_report

    Private Sub cash_flow_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim row1 As DataRow = Nothing
            Dim lvCashFlow = uscCashFlow.lvw_cashflow
            Dim DS As New DataSet
            Dim rptCF As New CashFlow
            'mag a-add na sa dataset (DS)
            DS.Tables.Add("CashFlow")
            'lagay tayo ng columns
            With DS.Tables(0).Columns
                .Add("Date")
                .Add("Accounts")
                .Add("Debit")
                .Add("Credit")
                .Add("Balance")
                .Add("Title")
                .Add("Description")
            End With
            For x = 1 To lvCashFlow.Items.Count Step 1
                row1 = DS.Tables(0).NewRow
                row1(0) = lvCashFlow.Items(x - 1).Text
                row1(1) = lvCashFlow.Items(x - 1).SubItems(1).Text
                row1(2) = lvCashFlow.Items(x - 1).SubItems(2).Text
                row1(3) = lvCashFlow.Items(x - 1).SubItems(3).Text
                row1(4) = lvCashFlow.Items(x - 1).SubItems(4).Text
                row1(5) = uscCashFlow.txtTitle.Text
                row1(6) = uscCashFlow.txtDescription.Text
                DS.Tables(0).Rows.Add(row1)
            Next

            'Creating XML file of data
            DS.WriteXml("XML\CashFlow.xml")
            'MsgBox("XML created.")
            'Exit Sub

            Dim dsINC As New DataSet
            dsINC = New DSreportsAccounting
            Dim dsINCTemp As New DataSet
            dsINCTemp = New DataSet()
            'Reading XML file
            dsINCTemp.ReadXml("XML\CashFlow.xml")
            dsINC.Merge(dsINCTemp.Tables(0))

            'MsgBox(dsINCTemp.Tables(0).Rows(0).Item(0).ToString)
            rptCF = New CashFlow
            rptCF.SetDataSource(dsINCTemp.Tables(0))
            crvCF.ReportSource = rptCF
            'showINC(True)
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical + vbOKOnly, "Error")
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        crvCF.PrintReport()
    End Sub

    Private Sub btnCancelPrintattack_Click(sender As Object, e As EventArgs) Handles btnCancelPrintattack.Click
        Me.Hide()
        showUSC(uscCashFlow)
    End Sub

    Private Sub crvCF_Load(sender As Object, e As EventArgs) Handles crvCF.Load

    End Sub
End Class