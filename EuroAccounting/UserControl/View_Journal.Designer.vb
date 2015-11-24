<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Journal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnl_Journal = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pnl_ViewList = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_journal_date = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnl_ViewList.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(267, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Journal Entries"
        '
        'pnl_Journal
        '
        Me.pnl_Journal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_Journal.AutoScroll = True
        Me.pnl_Journal.BackColor = System.Drawing.SystemColors.Control
        Me.pnl_Journal.Location = New System.Drawing.Point(6, 275)
        Me.pnl_Journal.Name = "pnl_Journal"
        Me.pnl_Journal.Size = New System.Drawing.Size(829, 185)
        Me.pnl_Journal.TabIndex = 1
        '
        'btn_Close
        '
        Me.btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Close.Location = New System.Drawing.Point(728, 16)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(93, 35)
        Me.btn_Close.TabIndex = 2
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(616, 17)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(106, 35)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add New Entry"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'pnl_ViewList
        '
        Me.pnl_ViewList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_ViewList.Controls.Add(Me.Label2)
        Me.pnl_ViewList.Controls.Add(Me.Label3)
        Me.pnl_ViewList.Controls.Add(Me.DataGridView1)
        Me.pnl_ViewList.Controls.Add(Me.txt_journal_date)
        Me.pnl_ViewList.Controls.Add(Me.Label4)
        Me.pnl_ViewList.Location = New System.Drawing.Point(15, 72)
        Me.pnl_ViewList.Name = "pnl_ViewList"
        Me.pnl_ViewList.Size = New System.Drawing.Size(806, 197)
        Me.pnl_ViewList.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Journal No."
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Journal No.:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(2, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(802, 137)
        Me.DataGridView1.TabIndex = 5
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Account Titles and Explanation"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Debit"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Credit"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'txt_journal_date
        '
        Me.txt_journal_date.AutoSize = True
        Me.txt_journal_date.Location = New System.Drawing.Point(78, 11)
        Me.txt_journal_date.Name = "txt_journal_date"
        Me.txt_journal_date.Size = New System.Drawing.Size(61, 13)
        Me.txt_journal_date.TabIndex = 8
        Me.txt_journal_date.Text = "Journal No."
        '
        'Label4
        '
        Me.Label4.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Date:"
        '
        'View_Journal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.pnl_ViewList)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pnl_Journal)
        Me.Name = "View_Journal"
        Me.Size = New System.Drawing.Size(841, 463)
        Me.pnl_ViewList.ResumeLayout(False)
        Me.pnl_ViewList.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnl_Journal As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents pnl_ViewList As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_journal_date As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
