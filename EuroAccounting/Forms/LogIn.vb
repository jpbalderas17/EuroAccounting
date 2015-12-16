Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
'Imports System.Drawing.Imaging
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class LogIn
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand
    Private Const EM_SETCUEBANNER As Integer = &H1501

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub SetCueText(ByVal control As Control, ByVal text As String)
        SendMessage(control.Handle, EM_SETCUEBANNER, 0, text)
    End Sub
    Private Shared DES As New TripleDESCryptoServiceProvider
    Private Shared MD5 As New MD5CryptoServiceProvider

    Public Shared Function MD5Hash(ByVal value As String) As Byte()
        Return MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(value))
    End Function

    Public Shared Function Encrypt(ByVal stringToEncrypt As String, ByVal key As String) As String
        DES.Key = LogIn.MD5Hash(key)
        DES.Mode = CipherMode.ECB
        Dim Buffer As Byte() = ASCIIEncoding.ASCII.GetBytes(stringToEncrypt)
        Return Convert.ToBase64String(DES.CreateEncryptor().TransformFinalBlock(Buffer, 0, Buffer.Length))
    End Function
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim user As String = txtUsername.Text
        Dim pass As String = txtPassword.Text
        Dim Usertype As String = lbl_utype.Text
        
        Try

            If txtUsername.Text = "" Or txtPassword.Text = "" Then
                MsgBox("Please provide username and password.", MsgBoxStyle.Exclamation, "Authentication Error")
            Else
                'Dim parameters As New Dictionary(Of String, Object)()
                'parameters.Add("username", txtUsername.Text)
                'parameters.Add("password", txtPassword.Text)
                dr = db.ExecuteReader("SELECT * FROM users where username ='" & txtUsername.Text & "' and password = '" & Encrypt(txtPassword.Text, "Keys") & "' ")
                If dr.HasRows Then
                    dr.Read()
                    Dim encryptPass = Encrypt(txtPassword.Text, "Keys")
                    'MsgBox(encryptPass)
                    'Exit Sub
                    Dim uname = (dr.Item("username").ToString)
                    Dim upass = (dr.Item("password").ToString)
                    Dim utype = (CInt(dr.Item("user_type")))
                    Dim userfullname = dr.Item("full_name").ToString
                    lbl_utype.Text = utype
                    If uname = txtUsername.Text And upass = encryptPass Then
                        uscMainMenu.lblHeader.Text = ("       Welcome " & userfullname)
                        Me.Hide()
                        MainMenu.Show()
                    Else
                        MsgBox("Username and Password do not match.")
                    End If
                Else
                    MsgBox("Invalid Username/Password", MsgBoxStyle.Exclamation, "Invalid Username/Password")
                End If
                'Do While dr.Read
                '    MsgBox(dr.Item(1).ToString)
                'Loop

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            'try natin i restore here :D lagyan ko pwede bukas
        Finally
            db.Dispose() '<--------CHECK THIS!
        End Try

    End Sub

    Private Sub LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Text = ""
        txtPassword.Text = ""
        SetCueText(txtUsername, "Username")
        SetCueText(txtPassword, "Password")
    End Sub
    Private Sub thisIsOnlyYourAccess()

    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin_Click(sender, e)
        End If
    End Sub


End Class