<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tbalance
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.lvtbalance = New System.Windows.Forms.ListView()
        Me.chAccounts = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDebit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCredit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_description = New System.Windows.Forms.TextBox()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.btn_filter = New System.Windows.Forms.Button()
        Me.dt_to = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt_from = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(0, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(806, 34)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "    Trial Balance Report"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_Cancel.FlatAppearance.BorderSize = 0
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.Gold
        Me.btn_Cancel.Location = New System.Drawing.Point(694, 58)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(115, 34)
        Me.btn_Cancel.TabIndex = 43
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Gold
        Me.btnPrint.Location = New System.Drawing.Point(573, 58)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(115, 34)
        Me.btnPrint.TabIndex = 44
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'lvtbalance
        '
        Me.lvtbalance.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvtbalance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvtbalance.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chAccounts, Me.chDebit, Me.chCredit})
        Me.lvtbalance.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvtbalance.GridLines = True
        Me.lvtbalance.Location = New System.Drawing.Point(5, 246)
        Me.lvtbalance.Name = "lvtbalance"
        Me.lvtbalance.Size = New System.Drawing.Size(801, 273)
        Me.lvtbalance.TabIndex = 211
        Me.lvtbalance.UseCompatibleStateImageBehavior = False
        Me.lvtbalance.View = System.Windows.Forms.View.Details
        '
        'chAccounts
        '
        Me.chAccounts.Text = "Accounts"
        Me.chAccounts.Width = 800
        '
        'chDebit
        '
        Me.chDebit.Text = "Debit"
        Me.chDebit.Width = 300
        '
        'chCredit
        '
        Me.chCredit.Text = "Credit"
        Me.chCredit.Width = 248
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(81, 106)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(79, 20)
        Me.lblDate.TabIndex = 215
        Me.lblDate.Text = "Date Now"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.txt_description)
        Me.Panel1.Controls.Add(Me.txt_title)
        Me.Panel1.Controls.Add(Me.btn_filter)
        Me.Panel1.Controls.Add(Me.dt_to)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dt_from)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lvtbalance)
        Me.Panel1.Controls.Add(Me.btnPrint)
        Me.Panel1.Controls.Add(Me.btn_Cancel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(809, 555)
        Me.Panel1.TabIndex = 20
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(272, 209)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Size = New System.Drawing.Size(326, 20)
        Me.txt_description.TabIndex = 246
        Me.txt_description.Text = "Description"
        Me.txt_description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_title
        '
        Me.txt_title.Location = New System.Drawing.Point(272, 181)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(326, 20)
        Me.txt_title.TabIndex = 245
        Me.txt_title.Text = "Title"
        Me.txt_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_filter
        '
        Me.btn_filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_filter.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_filter.ForeColor = System.Drawing.Color.Gold
        Me.btn_filter.Location = New System.Drawing.Point(738, 101)
        Me.btn_filter.Name = "btn_filter"
        Me.btn_filter.Size = New System.Drawing.Size(69, 33)
        Me.btn_filter.TabIndex = 244
        Me.btn_filter.Text = "Filter"
        Me.btn_filter.UseVisualStyleBackColor = False
        '
        'dt_to
        '
        Me.dt_to.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_to.Location = New System.Drawing.Point(551, 107)
        Me.dt_to.Name = "dt_to"
        Me.dt_to.Size = New System.Drawing.Size(181, 20)
        Me.dt_to.TabIndex = 243
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(524, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 20)
        Me.Label4.TabIndex = 242
        Me.Label4.Text = "To:"
        '
        'dt_from
        '
        Me.dt_from.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_from.Location = New System.Drawing.Point(324, 107)
        Me.dt_from.Name = "dt_from"
        Me.dt_from.Size = New System.Drawing.Size(181, 20)
        Me.dt_from.TabIndex = 241
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(268, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 240
        Me.Label3.Text = "From:"
        '
        'tbalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "tbalance"
        Me.Size = New System.Drawing.Size(812, 555)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents lvtbalance As System.Windows.Forms.ListView
    Friend WithEvents chAccounts As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDebit As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCredit As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_description As System.Windows.Forms.TextBox
    Friend WithEvents txt_title As System.Windows.Forms.TextBox
    Friend WithEvents btn_filter As System.Windows.Forms.Button
    Friend WithEvents dt_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dt_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
