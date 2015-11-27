Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class Users
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand

    Private Shared DES As New TripleDESCryptoServiceProvider
    Private Shared MD5 As New MD5CryptoServiceProvider

    Public Shared Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function

    Public Shared Function Encrypt(ByVal stringToEncrypt As String, ByVal key As String) As String
        DES.Key = Users.MD5Hash(key)
        DES.Mode = CipherMode.ECB
        Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function

    Public Shared Function Decrypt(ByVal encryptedString As String, ByVal key As String) As String

        DES.Key = Users.MD5Hash(key)
        DES.Mode = CipherMode.ECB

        Dim Buffer As Byte() = Convert.FromBase64String(encryptedString)
        Return ASCIIEncoding.ASCII.GetString(DES.CreateDecryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function
    Private Sub clearUserGroup()

        For Each Control In gbxAddEdit.Controls
            If TypeOf Control Is ComboBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control

        For Each Control In gbxAddEdit.Controls
            If TypeOf Control Is TextBox Then
                Control.Text = ""     'Clear all text
            End If
        Next Control
    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        showUSC(uscMainMenu)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        clearUserGroup()
        gbxAddEdit.Text = "Add Users"
        pnl_user.Visible = True
    End Sub
    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvLoadListview()
    End Sub
    Public Sub lvLoadListview()
        Dim parameters As New Dictionary(Of String, Object)
        lvlUsers.Items.Clear()
        Dim Item As ListViewItem
        'parameters.Add("keyword", "%" & txtSearch.Text & "%")

        Try
            dr = db.ExecuteReader("SELECT id, full_name, username, password, user_type FROM users", parameters)
            If dr.HasRows Then
                Do While dr.Read
                    Dim utype = (CInt(dr.Item("user_type")))
                    Item = Me.lvlUsers.Items.Add(dr.Item("id").ToString)
                    With Item
                        .SubItems.Add(dr.Item("full_name"))
                        .SubItems.Add(dr.Item("username"))
                        If utype = "0" Then
                            .SubItems.Add("Super Administrator")
                        ElseIf utype = "1" Then
                            .SubItems.Add("Administrator")
                        End If
                        '.SubItems.Add(dr.Item("user_type"))
                        .SubItems.Add(dr.Item("password"))
                    End With
                Loop
            Else
                MsgBox("No record of users", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No users")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose()
        End Try
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        If gbxAddEdit.Text = "Add Users" Then
            If txtfullname.Text = "" Or txtuname.Text = "" Or txtpwd.Text = "" Or txtconfirmpwd.Text = "" Or cmbUtype.Text = "" Then
                MsgBox("Please fill in the blank fields.", MsgBoxStyle.Exclamation, "Fill in the fields.")
                Exit Sub
            End If
            '==ADD USERS INFO
            Dim rec As Integer
            Dim data As New Dictionary(Of String, Object)
            'Dim pwd As String

            Try
                Dim encryptPass = Encrypt(txtpwd.Text, "Keys")
                'Dim encryptPass2 = Encrypt(txtconfirmpwd.Text, "Keys")
                data.Add("full_name", txtfullname.Text)
                data.Add("username", txtuname.Text)
                If cmbUtype.Text = "Super Administrator" Then 'in process
                    data.Add("user_type", "0")
                ElseIf cmbUtype.Text = "Administrator" Then
                    data.Add("user_type", "1")
                End If
                If txtpwd.Text = txtconfirmpwd.Text Then
                    data.Add("password", encryptPass)
                Else
                    MessageBox.Show("Password do not match!", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If

                rec = db.ExecuteNonQuery("INSERT INTO users values(@full_name,@username,@password,@user_type)", data)

                If Not rec < 1 Then
                    MessageBox.Show("Record saved!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    pnl_user.Visible = False
                    clearUserGroup()
                    lvLoadListview()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                db.Dispose() '<--------CHECK THIS!
            End Try


            'UPDATING USERS DATA
        ElseIf gbxAddEdit.Text = "Edit Users" Then
            Dim rec As Integer
            Dim data As New Dictionary(Of String, Object)

            Try
                Dim encryptPass = Encrypt(txtpwd.Text, "Keys")
                data.Add("full_name", txtfullname.Text)
                data.Add("username", txtuname.Text)
                If cmbUtype.Text = "Super Administrator" Then 'in process
                    data.Add("user_type", "0")
                ElseIf cmbUtype.Text = "Administrator" Then
                    data.Add("user_type", "1")
                End If
                If txtpwd.Text = txtconfirmpwd.Text Then
                    data.Add("password", encryptPass)
                Else
                    MessageBox.Show("Password do not match!", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                    Exit Sub
                End If

                rec = db.ExecuteNonQuery("UPDATE users SET full_name=@full_name, username=@username, password=@password, user_type=@user_type WHERE id=" & txtUid.Text, data)

                If Not rec < 1 Then
                    MessageBox.Show("Record updated!", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    lvlUsers.SelectedItems.Clear()
                    pnl_user.Visible = False
                    clearUserGroup()
                    lvLoadListview()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                db.Dispose() '<--------CHECK THIS!
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        lvlUsers.SelectedItems.Clear()
        pnl_user.Visible = False
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EditItemInListView()
    End Sub
    Sub ShowMsg(txt As String)
        uscMainMenu.lblHeader.ForeColor = Color.Goldenrod
    End Sub
    Private Sub EditItemInListView()
        clearUserGroup()
        If lvlUsers.SelectedItems.Count > 0 Then 'make sure there is a selected item to modify
            gbxAddEdit.Text = "Edit Users"
            txtUid.Text = lvlUsers.FocusedItem.Text
            Try
                dr = db.ExecuteReader("select * from users WHERE id=" & lvlUsers.FocusedItem.Text)
                pnl_user.Visible = True
                If dr.HasRows Then
                    Dim pass = lvlUsers.SelectedItems(0).SubItems(4).Text
                    Dim decryptPass = Decrypt(pass, "Keys")
                    txtpwd.Text = decryptPass
                    txtconfirmpwd.Text = decryptPass

                    txtfullname.Text = lvlUsers.SelectedItems(0).SubItems(1).Text
                    txtuname.Text = lvlUsers.SelectedItems(0).SubItems(2).Text
                    cmbUtype.Text = lvlUsers.SelectedItems(0).SubItems(3).Text
                    txtpwd.Text = lvlUsers.SelectedItems(0).SubItems(4).Text
                    txtconfirmpwd.Text = lvlUsers.SelectedItems(0).SubItems(4).Text
                    'txtuname.Text = dr.Item("username")
                    'txtpwd.Text = dr.Item("password")
                    'txtconfirmpwd.Text = dr.Item("password")
                    'If dr.Item("user_type") = 0 Then
                    '    cmbUtype.Text = "Super Administrator"
                    'ElseIf dr.Item("user_type") = 1 Then
                    '    cmbUtype.Text = "Administrator"
                    'End If

                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                db.Dispose() '<--------CHECK THIS!
            End Try

        Else
            MessageBox.Show("Please select record to edit.", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub
End Class
