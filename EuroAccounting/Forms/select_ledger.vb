Imports System.Data.SqlClient
Public Class select_ledger
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Dim next_control As UserControl
    Private Sub load_cbo()
        Dim ledgers As New ArrayList
        dr = db.ExecuteReader("SELECT id,name FROM ledgers WHERE is_archive= 0 ORDER by ID DESC")
        If dr.HasRows Then
            Do While dr.Read
                ledgers.Add(New MyCombo(dr.Item("id"), dr.Item("name")))
            Loop
            With cbo_ledger
                .DataSource = ledgers
                .DisplayMember = "Description"
                .ValueMember = "ID"
            End With
        End If
    End Sub
    Private Sub select_ledger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_cbo()
    End Sub
    'Public Overloads Sub Showdialog(nextControl As UserControl)
    '    next_control = nextControl
    '    Me.ShowDialog()

    'End Sub

   
    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
       
        getReport()
        
        Me.Close()

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    ''METHODS
    Private Sub getReport()
        Select Case uscMainMenu.getter

            Case "Income statement"
                showUSC(uscIncomeStatement)
                Dim y As Integer
                y = 0
                If uscIncomeStatement.postTO(y) = True Then
                    uscIncomeStatement.lvwIncome_statementinList()
                Else
                    uscIncomeStatement.lvwIncome_statementInCBO()
                End If
            Case "Balance sheet"
                showUSC(uscBalanceSheet)
            Case "Cash flow"
                MsgBox("Wala pa!")
            Case "Trial balance"
                showUSC(uscTrialBalance)
            Case "3 Column ledger"
                showUSC(uscLedger)
        End Select

    End Sub

End Class