Module MainPanelController
    'Public uscEntry As New Journal_Entry
    Public uscMainMenu As New MainMenu2
    Public uscViewJournal As New View_Journal
    Public uscAddJournal As New AddEntry
    Public uscUsers As New Users
    Public uscTrialBalance As New tbalance
    Public uscLedger As New Ledger
    Public uscIncomeStatement As New Income_Statement
    Public uscBalanceSheet As New Balance_Sheet
    Public uscServiceSupplyEntry As New service_supplies_entry

    Public currentUSC As Control
    Sub clearMainPanel()
        MainMenu.panelMain.Controls.Clear()
    End Sub
    Sub showUSC(usc As Control)
        currentUSC = usc
        clearMainPanel()
        currentUSC.Parent = MainMenu.panelMain
        currentUSC.Width = MainMenu.panelMain.Width
        currentUSC.Height = MainMenu.panelMain.Height
    End Sub
End Module
