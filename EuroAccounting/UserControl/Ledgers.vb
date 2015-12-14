

Public Class Ledgers
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs)
        'showUSC(uscViewJournal)
        'uscViewJournal.cmbPost.Text = ""
        showUSC(uscMainMenu)
    End Sub
    Private Sub showAddEditLedger(mode As Boolean)
        pnl.Visible = mode
        pnlMain.Enabled = Not mode
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
            dr = db.ExecuteReader("SELECT id, name, description FROM ledgers WHERE is_archive = 0", parameters)
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
        If lvljournal.SelectedItems.Count = 0 Then
            MsgBox("Please select ledger ", vbExclamation + vbOKOnly, "No ledger")
            Exit Sub
        End If
        showUSC(uscViewJournal)
        uscViewJournal.loadJournal()
    End Sub

    Private Sub pnlMain_Paint(sender As Object, e As PaintEventArgs) Handles pnlMain.Paint

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lblAddEdit.Text = "Add new ledger"
        showAddEditLedger(True)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        showAddEditLedger(False)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Trim(txtNameofLedger.Text) = "" Then
            MsgBox("Ledger must have a name", vbExclamation + vbOKOnly, "No name")
            Exit Sub
        End If
        If lblAddEdit.Text = "Add new ledger" Then
            save_Ledger()
            showAddEditLedger(False)
        Else
            update_Ledger()
            showAddEditLedger(False)
        End If

    End Sub
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        If lvljournal.SelectedItems.Count = 0 Then
            MsgBox("Please select a ledger", vbExclamation + vbOKOnly, "Choose a ledger")
            Exit Sub
        End If
        lblAddEdit.Text = "Edit ledger"
        showAddEditLedger(True)
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' next 
        If lvljournal.SelectedItems.Count = 0 Then
            MsgBox("Please select a ledger", vbExclamation + vbOKOnly, "Choose a ledger")
            Exit Sub
        End If
        Select Case MsgBox("Are you sure you want to archive this ledger?" & vbCrLf & "- " & lvljournal.FocusedItem.SubItems(1).Text, _
                       vbQuestion + vbYesNo, "Archive?")

            Case vbYes
                delete_Ledger()
        End Select

    End Sub
    ''' METHODS
    Private Sub save_Ledger()
        Dim data As New Dictionary(Of String, Object)
        Try
            data.Add("name", txtNameofLedger.Text)
            data.Add("description", Trim(txtDesc.Text))
            data.Add("is_archive", 0)
            Dim rec = db.ExecuteNonQuery("INSERT INTO ledgers (name , description,is_archive) VALUES " & _
                                     "(@name, @description, @is_archive)", data)
            data.Clear()
            MsgBox("New ledger was created successfully.", vbInformation + vbOKOnly, "Ledger was added.")
            lvLoadListview()
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical)
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub update_Ledger()
        Dim data As New Dictionary(Of String, Object)
        Try
            data.Add("name", txtNameofLedger.Text)
            data.Add("description", Trim(txtDesc.Text))
            Dim rec = db.ExecuteNonQuery("UPDATE ledgers SET name = @name,  description = @description WHERE id =  " & lvljournal.FocusedItem.Text, data)
            data.Clear()

            MsgBox("New ledger was updated successfully.", vbInformation + vbOKOnly, "Ledger was edited.")
            lvLoadListview()
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical)
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub delete_Ledger()
        'fake deletion
        Dim data As New Dictionary(Of String, Object)
        Try
            data.Add("is_archive", 1)
            Dim rec = db.ExecuteNonQuery("UPDATE ledgers SET is_archive = @is_archive WHERE id =  " & lvljournal.FocusedItem.Text, data)
            data.Clear()

            MsgBox("Ledger was in the archive.", vbInformation + vbOKOnly, "Archived")
            lvLoadListview()
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical)
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub btnSearchLedger_Click(sender As Object, e As EventArgs) Handles btnSearchLedger.Click
        If txtSearchLedger.Text.Contains("'") Then
            MsgBox("Invalid text search, please remove single qoute", vbExclamation + vbOKOnly, "Invalid")
            Exit Sub
        End If
        Try
            dr = db.ExecuteReader("SELECT id,name, description FROM (SELECT * FROM ledgers where is_archive= 0) as tbl_ledgers where name like '%" & txtSearchLedger.Text & "%' OR" & _
                              " description like '%" & txtSearchLedger.Text & "%'")
            lvljournal.Items.Clear()
            If dr.HasRows Then
                Do While dr.Read
                    Dim itm As ListViewItem = lvljournal.Items.Add(dr.Item("id").ToString)
                    itm.SubItems.Add(dr.Item("name").ToString)
                    itm.SubItems.Add(dr.Item("description").ToString)

                Loop
            Else
                MsgBox("No results found", vbExclamation + vbOKOnly, "No ledger")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, vbCritical)
        Finally
            db.Dispose()
        End Try
        
        
    End Sub
End Class