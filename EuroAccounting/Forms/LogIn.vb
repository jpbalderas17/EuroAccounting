Imports System.Data.SqlClient
Public Class LogIn
    Dim db As New DBHelper(My.Settings.connectionString)
    Dim dr As SqlClient.SqlDataReader
    Dim cmd As SqlClient.SqlCommand

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try

            If txtUsername.Text = "" Or txtPassword.Text = "" Then
                MsgBox("Enter username and password", MsgBoxStyle.Exclamation, "Invalid Username/Password")
            Else
                Dim db As New DBHelper(My.Settings.connectionString)
                Dim dr As SqlDataReader
                Dim parameters As New Dictionary(Of String, Object)()
                parameters.Add("username", txtUsername.Text)
                parameters.Add("password", txtPassword.Text)

                dr = db.ExecuteReader("SELECT * FROM users WHERE username=@username AND password=@password", parameters)
                If dr.HasRows Then
                    dr.Read()
                    lbl_utype.Text = CInt(dr.Item("user_type"))
                    Me.Hide()
                    MainMenu.Show()
                Else
                    MsgBox("Invalid Username/Password", MsgBoxStyle.Exclamation, "Invalid Username/Password")
                End If
                'Do While dr.Read
                '    MsgBox(dr.Item(1).ToString)
                'Loop

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            db.Dispose() '<--------CHECK THIS!
        End Try

    End Sub
End Class