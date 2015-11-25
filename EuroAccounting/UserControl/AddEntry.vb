
Public Class AddEntry
    Dim itm As ListViewItem
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Dim j_entry = New Journal_Entry
        'j_entry.Width = pnl_Journal.Width
        'pnl_Journal.Controls.Add(j_entry)
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        showUSC(uscViewJournal)
    End Sub

    Private Sub clearDebitGroup()
        For Each Control In gbxDebit.Controls
            If TypeOf Control Is ComboBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control

        For Each Control In gbxDebit.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control
    End Sub

    Private Sub clearCreditGroup()

        For Each Control In gbxCredit.Controls
            If TypeOf Control Is ComboBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control

        For Each Control In gbxCredit.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control
    End Sub
    Private Sub dAdd_Click(sender As Object, e As EventArgs) Handles dAdd.Click
        LoadlDebitLV()
        clearDebitGroup()
    End Sub
    Private Sub LoadlDebitLV()
        Dim acc As String
        Dim accType As String
        Dim amt As Integer
        acc = dAccount.Text
        accType = dType.Text
        amt = dAmount.Text
        Try
            Dim item As New ListViewItem(acc)
            item.SubItems.Add(amt)
            lvDebit.Items.Add(item)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub LoadlCrebitLV()
        Dim acc As String
        Dim accType As String
        Dim amt As Integer
        acc = crAccount.Text
        accType = crType.Text
        amt = crAmount.Text
        Try
            Dim item As New ListViewItem(acc)
            item.SubItems.Add(amt)
            lvCredit.Items.Add(item)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub crAdd_Click(sender As Object, e As EventArgs) Handles crAdd.Click
        LoadlCrebitLV()
        clearCreditGroup()
    End Sub

    Private Sub dAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dAmount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If e.Handled = (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub crAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles crAmount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If e.Handled = (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dType.SelectedIndexChanged

    End Sub
End Class