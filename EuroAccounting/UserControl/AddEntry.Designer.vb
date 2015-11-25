<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEntry
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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbxCredit = New System.Windows.Forms.GroupBox()
        Me.lvCredit = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.crAccount = New System.Windows.Forms.ComboBox()
        Me.crAdd = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.crAmount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.crType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbxDebit = New System.Windows.Forms.GroupBox()
        Me.lvDebit = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dAdd = New System.Windows.Forms.Button()
        Me.dAmount = New System.Windows.Forms.TextBox()
        Me.dType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dAccount = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gbxCredit.SuspendLayout()
        Me.gbxDebit.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.gbxCredit)
        Me.Panel1.Controls.Add(Me.gbxDebit)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(982, 626)
        Me.Panel1.TabIndex = 20
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(224, 477)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(617, 25)
        Me.TextBox2.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(147, 481)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 17)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Description:"
        '
        'gbxCredit
        '
        Me.gbxCredit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxCredit.Controls.Add(Me.lvCredit)
        Me.gbxCredit.Controls.Add(Me.crAccount)
        Me.gbxCredit.Controls.Add(Me.crAdd)
        Me.gbxCredit.Controls.Add(Me.Label10)
        Me.gbxCredit.Controls.Add(Me.crAmount)
        Me.gbxCredit.Controls.Add(Me.Label9)
        Me.gbxCredit.Controls.Add(Me.crType)
        Me.gbxCredit.Controls.Add(Me.Label8)
        Me.gbxCredit.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCredit.Location = New System.Drawing.Point(627, 186)
        Me.gbxCredit.Name = "gbxCredit"
        Me.gbxCredit.Size = New System.Drawing.Size(336, 259)
        Me.gbxCredit.TabIndex = 35
        Me.gbxCredit.TabStop = False
        Me.gbxCredit.Text = "Credit"
        '
        'lvCredit
        '
        Me.lvCredit.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvCredit.FullRowSelect = True
        Me.lvCredit.GridLines = True
        Me.lvCredit.Location = New System.Drawing.Point(25, 118)
        Me.lvCredit.Name = "lvCredit"
        Me.lvCredit.Size = New System.Drawing.Size(291, 125)
        Me.lvCredit.TabIndex = 15
        Me.lvCredit.UseCompatibleStateImageBehavior = False
        Me.lvCredit.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Accounts"
        Me.ColumnHeader3.Width = 180
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Amount"
        Me.ColumnHeader4.Width = 100
        '
        'crAccount
        '
        Me.crAccount.FormattingEnabled = True
        Me.crAccount.Location = New System.Drawing.Point(103, 22)
        Me.crAccount.Name = "crAccount"
        Me.crAccount.Size = New System.Drawing.Size(214, 25)
        Me.crAccount.TabIndex = 10
        '
        'crAdd
        '
        Me.crAdd.Location = New System.Drawing.Point(236, 77)
        Me.crAdd.Name = "crAdd"
        Me.crAdd.Size = New System.Drawing.Size(81, 23)
        Me.crAdd.TabIndex = 14
        Me.crAdd.Text = "Add"
        Me.crAdd.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 17)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Account(s):"
        '
        'crAmount
        '
        Me.crAmount.Location = New System.Drawing.Point(103, 78)
        Me.crAmount.Name = "crAmount"
        Me.crAmount.Size = New System.Drawing.Size(126, 25)
        Me.crAmount.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Amount:"
        '
        'crType
        '
        Me.crType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.crType.FormattingEnabled = True
        Me.crType.Items.AddRange(New Object() {"Revenue (Main)", "Revunue (Side)", "Contra (Revenue)", "Cost of Goods Sold", "Expenses", "Assets (Non-current)", "Assets (Current)", "Contra (Current Assets)", "Contra (Non-current Assets)", "Liabilities (Non-current)", "Liabilitites (Current)", "Owner's Equity (Capital)", "Owner's Equity (Drawings)"})
        Me.crType.Location = New System.Drawing.Point(103, 49)
        Me.crType.Name = "crType"
        Me.crType.Size = New System.Drawing.Size(214, 25)
        Me.crType.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Type(s):"
        '
        'gbxDebit
        '
        Me.gbxDebit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.gbxDebit.Controls.Add(Me.lvDebit)
        Me.gbxDebit.Controls.Add(Me.dAdd)
        Me.gbxDebit.Controls.Add(Me.dAmount)
        Me.gbxDebit.Controls.Add(Me.dType)
        Me.gbxDebit.Controls.Add(Me.Label6)
        Me.gbxDebit.Controls.Add(Me.dAccount)
        Me.gbxDebit.Controls.Add(Me.Label5)
        Me.gbxDebit.Controls.Add(Me.Label4)
        Me.gbxDebit.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDebit.Location = New System.Drawing.Point(150, 186)
        Me.gbxDebit.Name = "gbxDebit"
        Me.gbxDebit.Size = New System.Drawing.Size(336, 259)
        Me.gbxDebit.TabIndex = 34
        Me.gbxDebit.TabStop = False
        Me.gbxDebit.Text = "Debit"
        '
        'lvDebit
        '
        Me.lvDebit.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvDebit.FullRowSelect = True
        Me.lvDebit.GridLines = True
        Me.lvDebit.Location = New System.Drawing.Point(21, 118)
        Me.lvDebit.Name = "lvDebit"
        Me.lvDebit.Size = New System.Drawing.Size(292, 125)
        Me.lvDebit.TabIndex = 7
        Me.lvDebit.UseCompatibleStateImageBehavior = False
        Me.lvDebit.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Accounts"
        Me.ColumnHeader1.Width = 180
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Amount"
        Me.ColumnHeader2.Width = 100
        '
        'dAdd
        '
        Me.dAdd.Location = New System.Drawing.Point(232, 80)
        Me.dAdd.Name = "dAdd"
        Me.dAdd.Size = New System.Drawing.Size(81, 23)
        Me.dAdd.TabIndex = 6
        Me.dAdd.Text = "Add"
        Me.dAdd.UseVisualStyleBackColor = True
        '
        'dAmount
        '
        Me.dAmount.Location = New System.Drawing.Point(99, 81)
        Me.dAmount.Name = "dAmount"
        Me.dAmount.Size = New System.Drawing.Size(126, 25)
        Me.dAmount.TabIndex = 5
        '
        'dType
        '
        Me.dType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dType.FormattingEnabled = True
        Me.dType.Items.AddRange(New Object() {"Revenue (Main)", "Revunue (Side)", "Contra (Revenue)", "Cost of Goods Sold", "Expenses", "Assets (Non-current)", "Assets (Current)", "Contra (Current Assets)", "Contra (Non-current Assets)", "Liabilities (Non-current)", "Liabilitites (Current)", "Owner's Equity (Capital)", "Owner's Equity (Drawings)"})
        Me.dType.Location = New System.Drawing.Point(99, 52)
        Me.dType.Name = "dType"
        Me.dType.Size = New System.Drawing.Size(214, 25)
        Me.dType.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Type(s):"
        '
        'dAccount
        '
        Me.dAccount.FormattingEnabled = True
        Me.dAccount.Location = New System.Drawing.Point(99, 25)
        Me.dAccount.Name = "dAccount"
        Me.dAccount.Size = New System.Drawing.Size(214, 25)
        Me.dAccount.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 81)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Account(s):"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(736, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "00000"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(651, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Journal No.:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(209, 140)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(241, 25)
        Me.DateTimePicker1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Date:"
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Gold
        Me.btnSave.Location = New System.Drawing.Point(747, 58)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(115, 34)
        Me.btnSave.TabIndex = 47
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_Cancel.FlatAppearance.BorderSize = 0
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.Gold
        Me.btn_Cancel.Location = New System.Drawing.Point(868, 58)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(115, 34)
        Me.btn_Cancel.TabIndex = 46
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Gold
        Me.Label12.Location = New System.Drawing.Point(0, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(980, 34)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "    Add New Journal Entry"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AddEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AddEntry"
        Me.Size = New System.Drawing.Size(982, 626)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbxCredit.ResumeLayout(False)
        Me.gbxCredit.PerformLayout()
        Me.gbxDebit.ResumeLayout(False)
        Me.gbxDebit.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gbxCredit As System.Windows.Forms.GroupBox
    Friend WithEvents crAccount As System.Windows.Forms.ComboBox
    Friend WithEvents crAdd As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents crAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents crType As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbxDebit As System.Windows.Forms.GroupBox
    Friend WithEvents dAdd As System.Windows.Forms.Button
    Friend WithEvents dAmount As System.Windows.Forms.TextBox
    Friend WithEvents dType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lvDebit As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvCredit As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
