Public Class balance_sheet_report

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        crvBS.PrintReport()
    End Sub

    Private Sub btnCancelPrintattack_Click(sender As Object, e As EventArgs) Handles btnCancelPrintattack.Click
        Me.Hide()
        showUSC(uscBalanceSheet)
    End Sub

    Private Sub balance_sheet_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim row1 As DataRow = Nothing
            Dim lvBalanceSheet = uscBalanceSheet.lvbalance_sheet
            Dim DS As New DataSet
            Dim rptINC As New BalanceSheet
            'mag a-add na sa dataset (DS)
            DS.Tables.Add("BalanceSheet")
            'lagay tayo ng columns
            With DS.Tables(0).Columns
                .Add("Account")
                .Add("Amount")
                .Add("Total")
                .Add("Title")
                .Add("Description")
            End With
            For x = 1 To lvBalanceSheet.Items.Count Step 1
                row1 = DS.Tables(0).NewRow
                row1(0) = lvBalanceSheet.Items(x - 1).Text
                row1(1) = lvBalanceSheet.Items(x - 1).SubItems(1).Text
                row1(2) = lvBalanceSheet.Items(x - 1).SubItems(2).Text
                row1(3) = uscBalanceSheet.txtTitle.Text
                row1(4) = uscBalanceSheet.txtDescription.Text
                DS.Tables(0).Rows.Add(row1)
            Next


            DS.WriteXml("XML\BalanceSheet.xml")
            'MsgBox("XML created.")
            'Exit Sub


            Dim dsINC As New DataSet
            dsINC = New DSreportsAccounting
            Dim dsINCTemp As New DataSet
            dsINCTemp = New DataSet()
            'dsINCTemp = New DSreports
            dsINCTemp.ReadXml("XML\BalanceSheet.xml")
            dsINC.Merge(dsINCTemp.Tables(0))

            'MsgBox(dsINCTemp.Tables(0).Rows(0).Item(0).ToString)
            rptINC = New BalanceSheet
            rptINC.SetDataSource(dsINCTemp.Tables(0))
            crvBS.ReportSource = rptINC
            'showINC(True)

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)

        End Try
    End Sub
End Class