Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Public Class DatabaseBackupRestore
    Dim rec As Integer
    Dim sourcePath As String
    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub SetCueText(ByVal control As Control, ByVal text As String)
        SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
    End Sub
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs)

        whatBrowser()
    End Sub
    Public Sub showVerifyAcc(mode As Boolean)
        pnl1.Enabled = False
        Panel1.Visible = True
    End Sub






    Private Sub btn_initialize_Click(sender As Object, e As EventArgs)
        Cursor = Cursors.WaitCursor
        If Trim(txtAddress.Text) = "" Then
            MsgBox("Please select a location ", vbExclamation + vbOKOnly, "Select location")
            Exit Sub
        End If

        goInitialize()
        Cursor = Cursors.Arrow
    End Sub


    Private Sub btn_cancel_Click(sender As Object, e As EventArgs)
        'clearing of objects
        txtname.Clear()
        txtAddress.Clear()
        radBack.Checked = False
        radRes.Checked = False
        Me.Close()
    End Sub
    Private Sub radBack_Click(sender As Object, e As EventArgs)
        Label3.Enabled = True
        txtname.Text = "DbAcctng_BackupFile_" & Format(Date.Now, "yyyyMMdd_hh_mm_ss")

        clearFileAddress()
    End Sub


    Private Sub radRes_Click(sender As Object, e As EventArgs)
        Label3.Enabled = False
        txtname.Clear()
        clearFileAddress()
    End Sub
    'METHODS

    Private Sub goInitialize()

        Try
            processTech.Maximum = 100
            If radBack.Checked = True Then
                If Trim(txtname.Text) = "" Then
                    MsgBox("Please input the name of back up file ", vbExclamation + vbOKOnly, "Input name")
                    Exit Sub
                End If
                sourcePath = txtAddress.Text & "\" & Trim(txtname.Text)
                sourcePath = sourcePath.Replace("'", "''")
                ' MsgBox(sourcePath)
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
            Else
                showVerifyAcc(True)
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

    Private Sub DatabaseBackupRestore_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Label3.Enabled = True
        txtname.Enabled = True
        clearFileAddress()
    End Sub






    Private Sub DatabaseBackupRestore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_initialize_Click_1(sender As Object, e As EventArgs) Handles btn_initialize.Click

    End Sub

    Private Sub btnCancelVeri_Click(sender As Object, e As EventArgs) Handles btnCancelVeri.Click
        showVerifyAcc(False)
    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        Try
            processTech.Maximum = 100
            If radRes.Checked = True Then
                'database restore

                sourcePath = txtAddress.Text
                sourcePath = sourcePath.Replace("'", "''")

                Using db As New DBHelper(My.Settings.connectionString)
                    '                    use master
                    'ALTER DATABASE YourDatabase SET SINGLE_USER WITH ROLLBACK IMMEDIATE 

                    '--do you stuff here 

                    'ALTER DATABASE YourDatabase SET MULTI_USER
                    rec = db.ExecuteNonQuery("use master;" & vbCrLf & _
                                              "BEGIN TRANSACTION" & vbCrLf & _
                                              "ALTER DATABASE accounting SET SINGLE_USER WITH ROLLBACK IMMEDIATE" & vbCrLf & _
                                              "RESTORE DATABASE accounting FROM DISK='" & sourcePath & "'" & vbCrLf & _
                                              "ALTER DATABASE accounting SET MULTI_USER" & vbCrLf & _
                                              "COMMIT")
                End Using
                processTech.Maximum = 0
                MsgBox("Database restored successfully")
            End If
            processTech.Maximum = 0
        Catch ex As Exception
            MsgBox("Error occured for backup or restore database." & vbCrLf & ex.ToString, vbCritical + vbOKOnly, "Error")
            processTech.Maximum = 0
        End Try
    End Sub
End Class