<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu2
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_View_Journal = New System.Windows.Forms.Button()
        Me.btn_Manage_user = New System.Windows.Forms.Button()
        Me.btn_Manage_Acc = New System.Windows.Forms.Button()
        Me.btn_Users = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_View_Journal
        '
        Me.btn_View_Journal.Location = New System.Drawing.Point(73, 62)
        Me.btn_View_Journal.Name = "btn_View_Journal"
        Me.btn_View_Journal.Size = New System.Drawing.Size(198, 129)
        Me.btn_View_Journal.TabIndex = 0
        Me.btn_View_Journal.Text = "View Journal"
        Me.btn_View_Journal.UseVisualStyleBackColor = True
        '
        'btn_Manage_user
        '
        Me.btn_Manage_user.Location = New System.Drawing.Point(73, 203)
        Me.btn_Manage_user.Name = "btn_Manage_user"
        Me.btn_Manage_user.Size = New System.Drawing.Size(198, 128)
        Me.btn_Manage_user.TabIndex = 1
        Me.btn_Manage_user.Text = "Manage Users"
        Me.btn_Manage_user.UseVisualStyleBackColor = True
        '
        'btn_Manage_Acc
        '
        Me.btn_Manage_Acc.Location = New System.Drawing.Point(277, 62)
        Me.btn_Manage_Acc.Name = "btn_Manage_Acc"
        Me.btn_Manage_Acc.Size = New System.Drawing.Size(198, 129)
        Me.btn_Manage_Acc.TabIndex = 2
        Me.btn_Manage_Acc.Text = "Manage Accounts"
        Me.btn_Manage_Acc.UseVisualStyleBackColor = True
        '
        'btn_Users
        '
        Me.btn_Users.Location = New System.Drawing.Point(277, 203)
        Me.btn_Users.Name = "btn_Users"
        Me.btn_Users.Size = New System.Drawing.Size(198, 128)
        Me.btn_Users.TabIndex = 3
        Me.btn_Users.Text = "Users"
        Me.btn_Users.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(481, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 129)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Tools"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainMenu2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Users)
        Me.Controls.Add(Me.btn_Manage_Acc)
        Me.Controls.Add(Me.btn_Manage_user)
        Me.Controls.Add(Me.btn_View_Journal)
        Me.Name = "MainMenu2"
        Me.Size = New System.Drawing.Size(897, 469)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_View_Journal As System.Windows.Forms.Button
    Friend WithEvents btn_Manage_user As System.Windows.Forms.Button
    Friend WithEvents btn_Manage_Acc As System.Windows.Forms.Button
    Friend WithEvents btn_Users As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
