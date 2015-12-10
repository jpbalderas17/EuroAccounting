Imports System.Data.SqlClient

Public Class Ledgers
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs)
        'showUSC(uscViewJournal)
        'uscViewJournal.cmbPost.Text = ""
        showUSC(uscMainMenu)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Ledger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("MM/dd/yyyy")
    End Sub

    Private Sub cmbjournal_SelectedIndexChanged(sender As Object, e As EventArgs)
        showUSC(uscViewJournal)
    End Sub

    Private Sub Ledgers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvLoadListview()
    End Sub
    Public Sub lvLoadListview()
        Dim parameters As New Dictionary(Of String, Object)
        lvljournal.Items.Clear()
        Dim Item As ListViewItem
        'parameters.Add("keyword", "%" & txtSearch.Text & "%")

        Try
            dr = db.ExecuteReader("SELECT id, name, description FROM ledgers", parameters)
            If dr.HasRows Then
                Do While dr.Read
                    'Dim utype = (CInt(dr.Item("user_type")))
                    Item = lvljournal.Items.Add(dr.Item("id").ToString)
                    With Item
                        .SubItems.Add(dr.Item("name"))
                        .SubItems.Add(dr.Item("description"))
                    End With
                Loop
            Else
                MsgBox("No record of journals", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No journals.")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose()
        End Try
    End Sub
    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        showUSC(uscMainMenu)
    End Sub
    Private Sub viewJournal()
        If lvljournal.SelectedItems.Count > 0 Then
            Dim id As Integer = lvljournal.FocusedItem.Text
            Try
                dr = db.ExecuteReader("select * from ledgers WHERE id=" & lvljournal.FocusedItem.Text)
                If dr.HasRows Then
                    showUSC(uscViewJournal)

                    'Dim pass = lvlUsers.SelectedItems(0).SubItems(4).Text
                    'Dim decryptPass = Decrypt(pass, "Keys")
                    'txtpwd.Text = decryptPass
                    'txtconfirmpwd.Text = decryptPass

                    'txtfullname.Text = lvlUsers.SelectedItems(0).SubItems(1).Text
                    'txtuname.Text = lvlUsers.SelectedItems(0).SubItems(2).Text
                    'cmbUtype.Text = lvlUsers.SelectedItems(0).SubItems(3).Text
                    'txtpwd.Text = lvlUsers.SelectedItems(0).SubItems(4).Text
                    'txtconfirmpwd.Text = lvlUsers.SelectedItems(0).SubItems(4).Text
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                db.Dispose() '<--------CHECK THIS!
            End Try
        Else
            MessageBox.Show("Please select ledger to view journals.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub
    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        showUSC(uscViewJournal)
        uscViewJournal.loadJournal()
    End Sub
End Class