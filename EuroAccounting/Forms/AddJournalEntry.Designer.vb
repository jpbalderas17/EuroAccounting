<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddJournalEntry
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
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbxCredit = New System.Windows.Forms.GroupBox()
        Me.lvCredit = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmeneCred = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsCredRemover = New System.Windows.Forms.ToolStripMenuItem()
        Me.crAccount = New System.Windows.Forms.ComboBox()
        Me.crAdd = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.crAmount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmenuDeb = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsDebRemover = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbxDebit = New System.Windows.Forms.GroupBox()
        Me.lvDebit = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.dAdd = New System.Windows.Forms.Button()
        Me.dAmount = New System.Windows.Forms.TextBox()
        Me.dAccount = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtAddJourn = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddEntry = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbxCredit.SuspendLayout()
        Me.cmeneCred.SuspendLayout()
        Me.cmenuDeb.SuspendLayout()
        Me.gbxDebit.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(91, 433)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(614, 22)
        Me.txtDescription.TabIndex = 45
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 436)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 16)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Description:"
        '
        'gbxCredit
        '
        Me.gbxCredit.Controls.Add(Me.lvCredit)
        Me.gbxCredit.Controls.Add(Me.crAccount)
        Me.gbxCredit.Controls.Add(Me.crAdd)
        Me.gbxCredit.Controls.Add(Me.Label10)
        Me.gbxCredit.Controls.Add(Me.crAmount)
        Me.gbxCredit.Controls.Add(Me.Label9)
        Me.gbxCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxCredit.Location = New System.Drawing.Point(369, 133)
        Me.gbxCredit.Name = "gbxCredit"
        Me.gbxCredit.Size = New System.Drawing.Size(336, 294)
        Me.gbxCredit.TabIndex = 43
        Me.gbxCredit.TabStop = False
        Me.gbxCredit.Text = "Credit"
        '
        'lvCredit
        '
        Me.lvCredit.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader6})
        Me.lvCredit.ContextMenuStrip = Me.cmeneCred
        Me.lvCredit.FullRowSelect = True
        Me.lvCredit.GridLines = True
        Me.lvCredit.Location = New System.Drawing.Point(25, 86)
        Me.lvCredit.Name = "lvCredit"
        Me.lvCredit.Size = New System.Drawing.Size(291, 183)
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
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "id"
        Me.ColumnHeader6.Width = 0
        '
        'cmeneCred
        '
        Me.cmeneCred.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsCredRemover})
        Me.cmeneCred.Name = "ContextMenuStrip1"
        Me.cmeneCred.Size = New System.Drawing.Size(118, 26)
        '
        'tsCredRemover
        '
        Me.tsCredRemover.Name = "tsCredRemover"
        Me.tsCredRemover.Size = New System.Drawing.Size(117, 22)
        Me.tsCredRemover.Text = "Remove"
        '
        'crAccount
        '
        Me.crAccount.FormattingEnabled = True
        Me.crAccount.Location = New System.Drawing.Point(103, 22)
        Me.crAccount.Name = "crAccount"
        Me.crAccount.Size = New System.Drawing.Size(214, 24)
        Me.crAccount.TabIndex = 10
        '
        'crAdd
        '
        Me.crAdd.BackColor = System.Drawing.Color.MidnightBlue
        Me.crAdd.FlatAppearance.BorderSize = 0
        Me.crAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.crAdd.ForeColor = System.Drawing.Color.Gold
        Me.crAdd.Location = New System.Drawing.Point(236, 52)
        Me.crAdd.Name = "crAdd"
        Me.crAdd.Size = New System.Drawing.Size(81, 26)
        Me.crAdd.TabIndex = 14
        Me.crAdd.Text = "Add"
        Me.crAdd.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(22, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 16)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Account(s):"
        '
        'crAmount
        '
        Me.crAmount.Location = New System.Drawing.Point(103, 53)
        Me.crAmount.Name = "crAmount"
        Me.crAmount.Size = New System.Drawing.Size(126, 22)
        Me.crAmount.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Amount:"
        '
        'cmenuDeb
        '
        Me.cmenuDeb.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsDebRemover})
        Me.cmenuDeb.Name = "cmenuDeb"
        Me.cmenuDeb.Size = New System.Drawing.Size(118, 26)
        '
        'tsDebRemover
        '
        Me.tsDebRemover.Name = "tsDebRemover"
        Me.tsDebRemover.Size = New System.Drawing.Size(117, 22)
        Me.tsDebRemover.Text = "Remove"
        '
        'gbxDebit
        '
        Me.gbxDebit.Controls.Add(Me.lvDebit)
        Me.gbxDebit.Controls.Add(Me.dAdd)
        Me.gbxDebit.Controls.Add(Me.dAmount)
        Me.gbxDebit.Controls.Add(Me.dAccount)
        Me.gbxDebit.Controls.Add(Me.Label5)
        Me.gbxDebit.Controls.Add(Me.Label4)
        Me.gbxDebit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDebit.Location = New System.Drawing.Point(17, 133)
        Me.gbxDebit.Name = "gbxDebit"
        Me.gbxDebit.Size = New System.Drawing.Size(336, 294)
        Me.gbxDebit.TabIndex = 42
        Me.gbxDebit.TabStop = False
        Me.gbxDebit.Text = "Debit"
        '
        'lvDebit
        '
        Me.lvDebit.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5})
        Me.lvDebit.ContextMenuStrip = Me.cmenuDeb
        Me.lvDebit.FullRowSelect = True
        Me.lvDebit.GridLines = True
        Me.lvDebit.Location = New System.Drawing.Point(21, 86)
        Me.lvDebit.Name = "lvDebit"
        Me.lvDebit.Size = New System.Drawing.Size(292, 183)
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
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "id"
        Me.ColumnHeader5.Width = 0
        '
        'dAdd
        '
        Me.dAdd.BackColor = System.Drawing.Color.MidnightBlue
        Me.dAdd.FlatAppearance.BorderSize = 0
        Me.dAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dAdd.ForeColor = System.Drawing.Color.Gold
        Me.dAdd.Location = New System.Drawing.Point(232, 54)
        Me.dAdd.Name = "dAdd"
        Me.dAdd.Size = New System.Drawing.Size(81, 26)
        Me.dAdd.TabIndex = 6
        Me.dAdd.Text = "Add"
        Me.dAdd.UseVisualStyleBackColor = False
        '
        'dAmount
        '
        Me.dAmount.Location = New System.Drawing.Point(99, 55)
        Me.dAmount.Name = "dAmount"
        Me.dAmount.Size = New System.Drawing.Size(126, 22)
        Me.dAmount.TabIndex = 5
        '
        'dAccount
        '
        Me.dAccount.FormattingEnabled = True
        Me.dAccount.Location = New System.Drawing.Point(99, 25)
        Me.dAccount.Name = "dAccount"
        Me.dAccount.Size = New System.Drawing.Size(214, 24)
        Me.dAccount.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Amount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Account(s):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(108, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "00000"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Journal No.:"
        Me.Label2.Visible = False
        '
        'dtAddJourn
        '
        Me.dtAddJourn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtAddJourn.Location = New System.Drawing.Point(421, 105)
        Me.dtAddJourn.Name = "dtAddJourn"
        Me.dtAddJourn.Size = New System.Drawing.Size(241, 22)
        Me.dtAddJourn.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(375, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Date:"
        '
        'btnAddEntry
        '
        Me.btnAddEntry.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnAddEntry.FlatAppearance.BorderSize = 0
        Me.btnAddEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEntry.ForeColor = System.Drawing.Color.Gold
        Me.btnAddEntry.Location = New System.Drawing.Point(537, 461)
        Me.btnAddEntry.Name = "btnAddEntry"
        Me.btnAddEntry.Size = New System.Drawing.Size(81, 26)
        Me.btnAddEntry.TabIndex = 46
        Me.btnAddEntry.Text = "Add entry"
        Me.btnAddEntry.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Gold
        Me.btnCancel.Location = New System.Drawing.Point(624, 461)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(81, 26)
        Me.btnCancel.TabIndex = 47
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gold
        Me.Label6.Location = New System.Drawing.Point(-2, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(735, 34)
        Me.Label6.TabIndex = 215
        Me.Label6.Text = "    Add entry"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AddJournalEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(733, 515)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAddEntry)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gbxCredit)
        Me.Controls.Add(Me.gbxDebit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtAddJourn)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddJournalEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add entry"
        Me.gbxCredit.ResumeLayout(False)
        Me.gbxCredit.PerformLayout()
        Me.cmeneCred.ResumeLayout(False)
        Me.cmenuDeb.ResumeLayout(False)
        Me.gbxDebit.ResumeLayout(False)
        Me.gbxDebit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gbxCredit As System.Windows.Forms.GroupBox
    Friend WithEvents lvCredit As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents crAccount As System.Windows.Forms.ComboBox
    Friend WithEvents crAdd As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents crAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gbxDebit As System.Windows.Forms.GroupBox
    Friend WithEvents lvDebit As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents dAdd As System.Windows.Forms.Button
    Friend WithEvents dAmount As System.Windows.Forms.TextBox
    Friend WithEvents dAccount As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtAddJourn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAddEntry As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cmenuDeb As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsDebRemover As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmeneCred As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsCredRemover As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
