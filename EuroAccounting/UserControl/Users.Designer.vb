<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnl_user = New System.Windows.Forms.Panel()
        Me.cmbUtype = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtconfirmpwd = New System.Windows.Forms.TextBox()
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnl_user.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.pnl_user)
        Me.Panel1.Controls.Add(Me.ListView1)
        Me.Panel1.Location = New System.Drawing.Point(0, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(938, 337)
        Me.Panel1.TabIndex = 0
        '
        'pnl_user
        '
        Me.pnl_user.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.pnl_user.Controls.Add(Me.cmbUtype)
        Me.pnl_user.Controls.Add(Me.Label6)
        Me.pnl_user.Controls.Add(Me.btnSave)
        Me.pnl_user.Controls.Add(Me.btnCancel)
        Me.pnl_user.Controls.Add(Me.Label3)
        Me.pnl_user.Controls.Add(Me.Label2)
        Me.pnl_user.Controls.Add(Me.Label1)
        Me.pnl_user.Controls.Add(Me.txtconfirmpwd)
        Me.pnl_user.Controls.Add(Me.txtpwd)
        Me.pnl_user.Controls.Add(Me.txtuname)
        Me.pnl_user.Controls.Add(Me.Label5)
        Me.pnl_user.Location = New System.Drawing.Point(283, 67)
        Me.pnl_user.Name = "pnl_user"
        Me.pnl_user.Size = New System.Drawing.Size(441, 199)
        Me.pnl_user.TabIndex = 9
        Me.pnl_user.Visible = False
        '
        'cmbUtype
        '
        Me.cmbUtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUtype.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUtype.FormattingEnabled = True
        Me.cmbUtype.Items.AddRange(New Object() {"Super Administrator", "Administrator"})
        Me.cmbUtype.Location = New System.Drawing.Point(152, 97)
        Me.cmbUtype.Name = "cmbUtype"
        Me.cmbUtype.Size = New System.Drawing.Size(268, 29)
        Me.cmbUtype.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 21)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "User Type"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Gold
        Me.btnSave.Location = New System.Drawing.Point(243, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(93, 38)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Gold
        Me.btnCancel.Location = New System.Drawing.Point(342, 10)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(93, 38)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Confirm Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 21)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 21)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "User name"
        '
        'txtconfirmpwd
        '
        Me.txtconfirmpwd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconfirmpwd.Location = New System.Drawing.Point(152, 164)
        Me.txtconfirmpwd.Name = "txtconfirmpwd"
        Me.txtconfirmpwd.Size = New System.Drawing.Size(268, 29)
        Me.txtconfirmpwd.TabIndex = 4
        '
        'txtpwd
        '
        Me.txtpwd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwd.Location = New System.Drawing.Point(152, 130)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.Size = New System.Drawing.Size(268, 29)
        Me.txtpwd.TabIndex = 3
        '
        'txtuname
        '
        Me.txtuname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuname.Location = New System.Drawing.Point(152, 64)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(268, 29)
        Me.txtuname.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(1, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(440, 38)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "User Form"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListView1
        '
        Me.ListView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(14, 7)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(908, 369)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "User ID"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "User name"
        Me.ColumnHeader2.Width = 221
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "User type"
        Me.ColumnHeader3.Width = 350
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Gold
        Me.btnDelete.Location = New System.Drawing.Point(730, 57)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(93, 34)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Gold
        Me.btnAdd.Location = New System.Drawing.Point(532, 57)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(93, 34)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.Gold
        Me.btnEdit.Location = New System.Drawing.Point(631, 57)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(93, 34)
        Me.btnEdit.TabIndex = 13
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btn_Close
        '
        Me.btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Close.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_Close.FlatAppearance.BorderSize = 0
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Close.ForeColor = System.Drawing.Color.Gold
        Me.btn_Close.Location = New System.Drawing.Point(829, 57)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(93, 34)
        Me.btn_Close.TabIndex = 12
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gold
        Me.Label4.Location = New System.Drawing.Point(-5, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(943, 34)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "    System Users"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Users"
        Me.Size = New System.Drawing.Size(938, 450)
        Me.Panel1.ResumeLayout(False)
        Me.pnl_user.ResumeLayout(False)
        Me.pnl_user.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents pnl_user As System.Windows.Forms.Panel
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtconfirmpwd As System.Windows.Forms.TextBox
    Friend WithEvents txtpwd As System.Windows.Forms.TextBox
    Friend WithEvents txtuname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbUtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
