Imports System.IO
Public Class DatabaseBackupRestore

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        whatBrowser()
    End Sub




    Private Sub btn_initialize_Click(sender As Object, e As EventArgs) Handles btn_initialize.Click
        Cursor = Cursors.WaitCursor
        If Trim(txtAddress.Text) = "" Then
            MsgBox("Please select a location ", vbExclamation + vbOKOnly, "Select location")
            Exit Sub
        End If
        
        goInitialize()
        Cursor = Cursors.Arrow
    End Sub


    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        'clearing of objects
        Me.Close()
    End Sub
    Private Sub radBack_Click(sender As Object, e As EventArgs) Handles radBack.Click
        Label3.Enabled = True
        txtname.Enabled = True
        clearFileAddress()
    End Sub


    Private Sub radRes_Click(sender As Object, e As EventArgs) Handles radRes.Click
        Label3.Enabled = False
        txtname.Enabled = False
        clearFileAddress()
    End Sub
    'METHODS

    Private Sub goInitialize()
        Dim rec As Integer
        Dim sourcePath As String
        Try
            processTech.Maximum = 100
            If radBack.Checked = True Then
                If Trim(txtname.Text) = "" Then
                    MsgBox("Please input the name of back up file ", vbExclamation + vbOKOnly, "Input name")
                    Exit Sub
                End If
                sourcePath = txtAddress.Text & "\" & Trim(txtname.Text)
                sourcePath = sourcePath.Replace("'", "''")
                MsgBox(sourcePath)
                If File.Exists(sourcePath) Then
                    Select Case MsgBox("The database back up exist in the selected folder." & vbCrLf & _
                           "Do you want to overwrite it?", vbQuestion + vbYesNo, "File exist")

                        Case vbYes
                            'database back up
                            Using db As New DBHelper(My.Settings.connectionString)

                                rec = db.ExecuteNonQuery("use master; BACKUP DATABASE accounting TO DISK='" & sourcePath & "'")
                            End Using
                        Case vbNo
                            Exit Sub
                    End Select

                Else
                    'database back up
                    Using db As New DBHelper(My.Settings.connectionString)

                        rec = db.ExecuteNonQuery("use master; BACKUP DATABASE accounting TO DISK='" & sourcePath & "'")
                    End Using
                End If
                processTech.Maximum = 0
                MsgBox("Database back up successfully")
            ElseIf radRes.Checked = True Then
                'database restore
                sourcePath = txtAddress.Text
                sourcePath = sourcePath.Replace("'", "''")
                Using db As New DBHelper(My.Settings.connectionString)
                    rec = db.ExecuteNonQuery("use master; RESTORE DATABASE accounting FROM DISK='" & sourcePath & "'")
                End Using
                processTech.Maximum = 0
                MsgBox("Database restored successfully")
            End If

        Catch ex As Exception
            MsgBox("Error occured for backup or restore database." & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
            processTech.Maximum = 0
        End Try
    End Sub
    Private Sub whatBrowser()
        If radBack.Checked = False And radRes.Checked = False Then
            MsgBox("Please select if you want to back-up or restore the database", vbExclamation + vbOKOnly, "Select please")
            Exit Sub
        End If
        If radBack.Checked = True Then
            folderSelect.ShowDialog()
            txtAddress.Text = folderSelect.SelectedPath.ToString
        ElseIf radRes.Checked = True Then
            openfileRes.ShowDialog()
            txtAddress.Text = openfileRes.FileName
        End If
    End Sub

    Private Sub clearFileAddress()
        txtAddress.Clear()

    End Sub




End Class