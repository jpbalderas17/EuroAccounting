<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DatabaseBackupRestore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.folderSelect = New System.Windows.Forms.FolderBrowserDialog()
        Me.timerProc = New System.Windows.Forms.Timer(Me.components)
        Me.openfileRes = New System.Windows.Forms.OpenFileDialog()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.processTech = New System.Windows.Forms.ProgressBar()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.radRes = New System.Windows.Forms.RadioButton()
        Me.radBack = New System.Windows.Forms.RadioButton()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_initialize = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnCancelVeri = New System.Windows.Forms.Button()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.pnl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'openfileRes
        '
        Me.openfileRes.FileName = "OpenFileDialog1"
        '
        'pnl1
        '
        Me.pnl1.Controls.Add(Me.Label4)
        Me.pnl1.Controls.Add(Me.Label3)
        Me.pnl1.Controls.Add(Me.txtname)
        Me.pnl1.Controls.Add(Me.Label2)
        Me.pnl1.Controls.Add(Me.processTech)
        Me.pnl1.Controls.Add(Me.btnBrowse)
        Me.pnl1.Controls.Add(Me.Label1)
        Me.pnl1.Controls.Add(Me.txtAddress)
        Me.pnl1.Controls.Add(Me.radRes)
        Me.pnl1.Controls.Add(Me.radBack)
        Me.pnl1.Controls.Add(Me.btn_cancel)
        Me.pnl1.Controls.Add(Me.btn_initialize)
        Me.pnl1.Location = New System.Drawing.Point(0, 7)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Size = New System.Drawing.Size(459, 282)
        Me.pnl1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(457, 32)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Note: Error may occured when you back up and your database in system" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "directory. " & _
    "We recommend to create folder that is not address to system drive. "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Name"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(13, 146)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(243, 22)
        Me.txtname.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Processing"
        '
        'processTech
        '
        Me.processTech.Location = New System.Drawing.Point(13, 244)
        Me.processTech.MarqueeAnimationSpeed = 50
        Me.processTech.Maximum = 0
        Me.processTech.Name = "processTech"
        Me.processTech.Size = New System.Drawing.Size(243, 22)
        Me.processTech.Step = 1
        Me.processTech.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.processTech.TabIndex = 19
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnBrowse.FlatAppearance.BorderSize = 0
        Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowse.ForeColor = System.Drawing.Color.Gold
        Me.btnBrowse.Location = New System.Drawing.Point(374, 185)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(66, 22)
        Me.btnBrowse.TabIndex = 18
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 169)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "File address"
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(13, 185)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ReadOnly = True
        Me.txtAddress.Size = New System.Drawing.Size(361, 22)
        Me.txtAddress.TabIndex = 16
        '
        'radRes
        '
        Me.radRes.AutoSize = True
        Me.radRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radRes.Location = New System.Drawing.Point(13, 95)
        Me.radRes.Name = "radRes"
        Me.radRes.Size = New System.Drawing.Size(74, 20)
        Me.radRes.TabIndex = 15
        Me.radRes.TabStop = True
        Me.radRes.Text = "Restore"
        Me.radRes.UseVisualStyleBackColor = True
        '
        'radBack
        '
        Me.radBack.AutoSize = True
        Me.radBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBack.Location = New System.Drawing.Point(13, 72)
        Me.radBack.Name = "radBack"
        Me.radBack.Size = New System.Drawing.Size(75, 20)
        Me.radBack.TabIndex = 14
        Me.radBack.TabStop = True
        Me.radBack.Text = "Back up"
        Me.radBack.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Gold
        Me.btn_cancel.Location = New System.Drawing.Point(365, 229)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 37)
        Me.btn_cancel.TabIndex = 13
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'btn_initialize
        '
        Me.btn_initialize.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_initialize.FlatAppearance.BorderSize = 0
        Me.btn_initialize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_initialize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_initialize.ForeColor = System.Drawing.Color.Gold
        Me.btn_initialize.Location = New System.Drawing.Point(284, 229)
        Me.btn_initialize.Name = "btn_initialize"
        Me.btn_initialize.Size = New System.Drawing.Size(75, 37)
        Me.btn_initialize.TabIndex = 12
        Me.btn_initialize.Text = "Start"
        Me.btn_initialize.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancelVeri)
        Me.Panel1.Controls.Add(Me.btn_ok)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(85, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(298, 191)
        Me.Panel1.TabIndex = 13
        Me.Panel1.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(1, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(370, 27)
        Me.Label5.TabIndex = 187
        Me.Label5.Text = "Verify Account"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(29, 102)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtPassword.Size = New System.Drawing.Size(258, 26)
        Me.txtPassword.TabIndex = 189
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(29, 70)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(258, 26)
        Me.txtUsername.TabIndex = 188
        '
        'btnCancelVeri
        '
        Me.btnCancelVeri.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCancelVeri.FlatAppearance.BorderSize = 0
        Me.btnCancelVeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelVeri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelVeri.ForeColor = System.Drawing.Color.Gold
        Me.btnCancelVeri.Location = New System.Drawing.Point(212, 134)
        Me.btnCancelVeri.Name = "btnCancelVeri"
        Me.btnCancelVeri.Size = New System.Drawing.Size(75, 37)
        Me.btnCancelVeri.TabIndex = 191
        Me.btnCancelVeri.Text = "Cancel"
        Me.btnCancelVeri.UseVisualStyleBackColor = False
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.Gold
        Me.btn_ok.Location = New System.Drawing.Point(131, 134)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(75, 37)
        Me.btn_ok.TabIndex = 190
        Me.btn_ok.Text = "Ok"
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'DatabaseBackupRestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(459, 285)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DatabaseBackupRestore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Database back-up and restore"
        Me.pnl1.ResumeLayout(False)
        Me.pnl1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents folderSelect As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents timerProc As System.Windows.Forms.Timer
    Friend WithEvents openfileRes As System.Windows.Forms.OpenFileDialog
    Friend WithEvents pnl1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents processTech As System.Windows.Forms.ProgressBar
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents radRes As System.Windows.Forms.RadioButton
    Friend WithEvents radBack As System.Windows.Forms.RadioButton
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_initialize As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelVeri As System.Windows.Forms.Button
    Friend WithEvents btn_ok As System.Windows.Forms.Button
End Class
