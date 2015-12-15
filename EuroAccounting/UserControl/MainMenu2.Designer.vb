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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu2))
        Me.btn_View_Journal = New System.Windows.Forms.Button()
        Me.btn_Manage_Acct = New System.Windows.Forms.Button()
        Me.btn_Users = New System.Windows.Forms.Button()
        Me.btn_Tools = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btn_Cash_Flow = New System.Windows.Forms.Button()
        Me.btn_Balance_Sheet = New System.Windows.Forms.Button()
        Me.gbx_Choices = New System.Windows.Forms.GroupBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.pnl_mains = New System.Windows.Forms.Panel()
        Me.btn3ColLedger = New System.Windows.Forms.Button()
        Me.btnDbBackUp = New System.Windows.Forms.Button()
        Me.btn_archives = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btn_Income_Statement = New System.Windows.Forms.Button()
        Me.btn_Trial_Balance = New System.Windows.Forms.Button()
        Me.gbx_Choices.SuspendLayout()
        Me.pnl_mains.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_View_Journal
        '
        Me.btn_View_Journal.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_View_Journal.FlatAppearance.BorderSize = 0
        Me.btn_View_Journal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_View_Journal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_View_Journal.ForeColor = System.Drawing.Color.Gold
        Me.btn_View_Journal.Image = CType(resources.GetObject("btn_View_Journal.Image"), System.Drawing.Image)
        Me.btn_View_Journal.Location = New System.Drawing.Point(33, 112)
        Me.btn_View_Journal.Name = "btn_View_Journal"
        Me.btn_View_Journal.Size = New System.Drawing.Size(231, 129)
        Me.btn_View_Journal.TabIndex = 0
        Me.btn_View_Journal.Text = "View Journal"
        Me.btn_View_Journal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_View_Journal.UseVisualStyleBackColor = False
        '
        'btn_Manage_Acct
        '
        Me.btn_Manage_Acct.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_Manage_Acct.FlatAppearance.BorderSize = 0
        Me.btn_Manage_Acct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Manage_Acct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Manage_Acct.ForeColor = System.Drawing.Color.Gold
        Me.btn_Manage_Acct.Location = New System.Drawing.Point(507, 381)
        Me.btn_Manage_Acct.Name = "btn_Manage_Acct"
        Me.btn_Manage_Acct.Size = New System.Drawing.Size(231, 129)
        Me.btn_Manage_Acct.TabIndex = 2
        Me.btn_Manage_Acct.Text = "Manage Accounts"
        Me.btn_Manage_Acct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Manage_Acct.UseVisualStyleBackColor = False
        '
        'btn_Users
        '
        Me.btn_Users.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_Users.FlatAppearance.BorderSize = 0
        Me.btn_Users.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Users.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Users.ForeColor = System.Drawing.Color.Gold
        Me.btn_Users.Image = CType(resources.GetObject("btn_Users.Image"), System.Drawing.Image)
        Me.btn_Users.Location = New System.Drawing.Point(270, 112)
        Me.btn_Users.Name = "btn_Users"
        Me.btn_Users.Size = New System.Drawing.Size(231, 128)
        Me.btn_Users.TabIndex = 3
        Me.btn_Users.Text = "Users"
        Me.btn_Users.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Users.UseVisualStyleBackColor = False
        '
        'btn_Tools
        '
        Me.btn_Tools.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_Tools.FlatAppearance.BorderSize = 0
        Me.btn_Tools.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Tools.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Tools.ForeColor = System.Drawing.Color.Gold
        Me.btn_Tools.Image = CType(resources.GetObject("btn_Tools.Image"), System.Drawing.Image)
        Me.btn_Tools.Location = New System.Drawing.Point(507, 112)
        Me.btn_Tools.Name = "btn_Tools"
        Me.btn_Tools.Size = New System.Drawing.Size(231, 128)
        Me.btn_Tools.TabIndex = 4
        Me.btn_Tools.Text = "Tools"
        Me.btn_Tools.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Tools.UseVisualStyleBackColor = False
        '
        'lblHeader
        '
        Me.lblHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeader.BackColor = System.Drawing.Color.MidnightBlue
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Gold
        Me.lblHeader.Location = New System.Drawing.Point(0, 30)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(1024, 34)
        Me.lblHeader.TabIndex = 5
        Me.lblHeader.Text = "       Welcome! user123"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.Color.Gold
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(876, 30)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(53, 34)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btn_Cash_Flow
        '
        Me.btn_Cash_Flow.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_Cash_Flow.FlatAppearance.BorderSize = 0
        Me.btn_Cash_Flow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cash_Flow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cash_Flow.ForeColor = System.Drawing.Color.Gold
        Me.btn_Cash_Flow.Location = New System.Drawing.Point(270, 248)
        Me.btn_Cash_Flow.Name = "btn_Cash_Flow"
        Me.btn_Cash_Flow.Size = New System.Drawing.Size(231, 128)
        Me.btn_Cash_Flow.TabIndex = 11
        Me.btn_Cash_Flow.Text = "Cash Flow"
        Me.btn_Cash_Flow.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Cash_Flow.UseVisualStyleBackColor = False
        '
        'btn_Balance_Sheet
        '
        Me.btn_Balance_Sheet.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_Balance_Sheet.FlatAppearance.BorderSize = 0
        Me.btn_Balance_Sheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Balance_Sheet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Balance_Sheet.ForeColor = System.Drawing.Color.Gold
        Me.btn_Balance_Sheet.Location = New System.Drawing.Point(33, 248)
        Me.btn_Balance_Sheet.Name = "btn_Balance_Sheet"
        Me.btn_Balance_Sheet.Size = New System.Drawing.Size(231, 128)
        Me.btn_Balance_Sheet.TabIndex = 12
        Me.btn_Balance_Sheet.Text = "Balance Sheet"
        Me.btn_Balance_Sheet.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Balance_Sheet.UseVisualStyleBackColor = False
        '
        'gbx_Choices
        '
        Me.gbx_Choices.Controls.Add(Me.btn_cancel)
        Me.gbx_Choices.Controls.Add(Me.Label2)
        Me.gbx_Choices.Controls.Add(Me.ComboBox1)
        Me.gbx_Choices.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Choices.Location = New System.Drawing.Point(250, 178)
        Me.gbx_Choices.Name = "gbx_Choices"
        Me.gbx_Choices.Size = New System.Drawing.Size(326, 105)
        Me.gbx_Choices.TabIndex = 13
        Me.gbx_Choices.TabStop = False
        '
        'btn_cancel
        '
        Me.btn_cancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.ForeColor = System.Drawing.Color.Gold
        Me.btn_cancel.Location = New System.Drawing.Point(239, 69)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(70, 25)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(58, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(251, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'pnl_mains
        '
        Me.pnl_mains.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_mains.BackColor = System.Drawing.Color.Silver
        Me.pnl_mains.Controls.Add(Me.btn3ColLedger)
        Me.pnl_mains.Controls.Add(Me.btnDbBackUp)
        Me.pnl_mains.Controls.Add(Me.btn_archives)
        Me.pnl_mains.Controls.Add(Me.btnExit)
        Me.pnl_mains.Controls.Add(Me.btnLogout)
        Me.pnl_mains.Controls.Add(Me.btn_Income_Statement)
        Me.pnl_mains.Controls.Add(Me.btn_Trial_Balance)
        Me.pnl_mains.Controls.Add(Me.btn_Balance_Sheet)
        Me.pnl_mains.Controls.Add(Me.btn_View_Journal)
        Me.pnl_mains.Controls.Add(Me.btn_Cash_Flow)
        Me.pnl_mains.Controls.Add(Me.btn_Manage_Acct)
        Me.pnl_mains.Controls.Add(Me.btn_Users)
        Me.pnl_mains.Controls.Add(Me.btn_Tools)
        Me.pnl_mains.Controls.Add(Me.lblHeader)
        Me.pnl_mains.Location = New System.Drawing.Point(0, 14)
        Me.pnl_mains.Name = "pnl_mains"
        Me.pnl_mains.Size = New System.Drawing.Size(1024, 529)
        Me.pnl_mains.TabIndex = 14
        '
        'btn3ColLedger
        '
        Me.btn3ColLedger.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn3ColLedger.FlatAppearance.BorderSize = 0
        Me.btn3ColLedger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3ColLedger.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3ColLedger.ForeColor = System.Drawing.Color.Gold
        Me.btn3ColLedger.Location = New System.Drawing.Point(270, 382)
        Me.btn3ColLedger.Name = "btn3ColLedger"
        Me.btn3ColLedger.Size = New System.Drawing.Size(231, 128)
        Me.btn3ColLedger.TabIndex = 18
        Me.btn3ColLedger.Text = "3 Column Ledger"
        Me.btn3ColLedger.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn3ColLedger.UseVisualStyleBackColor = False
        '
        'btnDbBackUp
        '
        Me.btnDbBackUp.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnDbBackUp.FlatAppearance.BorderSize = 0
        Me.btnDbBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDbBackUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDbBackUp.ForeColor = System.Drawing.Color.Gold
        Me.btnDbBackUp.Location = New System.Drawing.Point(744, 246)
        Me.btnDbBackUp.Name = "btnDbBackUp"
        Me.btnDbBackUp.Size = New System.Drawing.Size(231, 129)
        Me.btnDbBackUp.TabIndex = 17
        Me.btnDbBackUp.Text = "Database Back up"
        Me.btnDbBackUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDbBackUp.UseVisualStyleBackColor = False
        '
        'btn_archives
        '
        Me.btn_archives.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_archives.FlatAppearance.BorderSize = 0
        Me.btn_archives.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_archives.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_archives.ForeColor = System.Drawing.Color.Gold
        Me.btn_archives.Location = New System.Drawing.Point(744, 381)
        Me.btn_archives.Name = "btn_archives"
        Me.btn_archives.Size = New System.Drawing.Size(231, 129)
        Me.btn_archives.TabIndex = 16
        Me.btn_archives.Text = "Archives"
        Me.btn_archives.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_archives.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Gold
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(926, 30)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(53, 34)
        Me.btnExit.TabIndex = 15
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btn_Income_Statement
        '
        Me.btn_Income_Statement.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_Income_Statement.FlatAppearance.BorderSize = 0
        Me.btn_Income_Statement.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Income_Statement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Income_Statement.ForeColor = System.Drawing.Color.Gold
        Me.btn_Income_Statement.Location = New System.Drawing.Point(33, 381)
        Me.btn_Income_Statement.Name = "btn_Income_Statement"
        Me.btn_Income_Statement.Size = New System.Drawing.Size(231, 128)
        Me.btn_Income_Statement.TabIndex = 14
        Me.btn_Income_Statement.Text = "Income Statement"
        Me.btn_Income_Statement.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Income_Statement.UseVisualStyleBackColor = False
        '
        'btn_Trial_Balance
        '
        Me.btn_Trial_Balance.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_Trial_Balance.FlatAppearance.BorderSize = 0
        Me.btn_Trial_Balance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Trial_Balance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Trial_Balance.ForeColor = System.Drawing.Color.Gold
        Me.btn_Trial_Balance.Location = New System.Drawing.Point(507, 246)
        Me.btn_Trial_Balance.Name = "btn_Trial_Balance"
        Me.btn_Trial_Balance.Size = New System.Drawing.Size(231, 128)
        Me.btn_Trial_Balance.TabIndex = 13
        Me.btn_Trial_Balance.Text = "Trial Balance"
        Me.btn_Trial_Balance.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Trial_Balance.UseVisualStyleBackColor = False
        '
        'MainMenu2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.pnl_mains)
        Me.Controls.Add(Me.gbx_Choices)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainMenu2"
        Me.Size = New System.Drawing.Size(1024, 555)
        Me.gbx_Choices.ResumeLayout(False)
        Me.gbx_Choices.PerformLayout()
        Me.pnl_mains.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_View_Journal As System.Windows.Forms.Button
    Friend WithEvents btn_Manage_Acct As System.Windows.Forms.Button
    Friend WithEvents btn_Users As System.Windows.Forms.Button
    Friend WithEvents btn_Tools As System.Windows.Forms.Button
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btn_Cash_Flow As System.Windows.Forms.Button
    Friend WithEvents btn_Balance_Sheet As System.Windows.Forms.Button
    Friend WithEvents gbx_Choices As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents pnl_mains As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Income_Statement As System.Windows.Forms.Button
    Friend WithEvents btn_Trial_Balance As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btn_archives As System.Windows.Forms.Button
    Friend WithEvents btnDbBackUp As System.Windows.Forms.Button
    Friend WithEvents btn3ColLedger As System.Windows.Forms.Button

End Class
