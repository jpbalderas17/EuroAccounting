<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Income_Statement
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
        Me.pnlIncMain = New System.Windows.Forms.Panel()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblNet = New System.Windows.Forms.Label()
        Me.lvIncomeStatement = New System.Windows.Forms.ListView()
        Me.chAccounts = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDebit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chCredit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlPrint = New System.Windows.Forms.Panel()
        Me.btnPrintAttack = New System.Windows.Forms.Button()
        Me.btnCancelPrintattack = New System.Windows.Forms.Button()
        Me.crvInc = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pnlIncMain.SuspendLayout()
        Me.pnlPrint.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlIncMain
        '
        Me.pnlIncMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlIncMain.BackColor = System.Drawing.Color.Silver
        Me.pnlIncMain.Controls.Add(Me.txtDescription)
        Me.pnlIncMain.Controls.Add(Me.txtTitle)
        Me.pnlIncMain.Controls.Add(Me.lblNet)
        Me.pnlIncMain.Controls.Add(Me.lvIncomeStatement)
        Me.pnlIncMain.Controls.Add(Me.btnPrint)
        Me.pnlIncMain.Controls.Add(Me.btn_Cancel)
        Me.pnlIncMain.Controls.Add(Me.Label2)
        Me.pnlIncMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlIncMain.Name = "pnlIncMain"
        Me.pnlIncMain.Size = New System.Drawing.Size(812, 553)
        Me.pnlIncMain.TabIndex = 20
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(286, 147)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(269, 26)
        Me.txtDescription.TabIndex = 248
        Me.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(286, 115)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(269, 26)
        Me.txtTitle.TabIndex = 247
        Me.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNet
        '
        Me.lblNet.AutoSize = True
        Me.lblNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNet.Location = New System.Drawing.Point(31, 18)
        Me.lblNet.Name = "lblNet"
        Me.lblNet.Size = New System.Drawing.Size(37, 20)
        Me.lblNet.TabIndex = 246
        Me.lblNet.Text = "Net"
        Me.lblNet.Visible = False
        '
        'lvIncomeStatement
        '
        Me.lvIncomeStatement.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvIncomeStatement.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvIncomeStatement.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chAccounts, Me.chDebit, Me.chCredit})
        Me.lvIncomeStatement.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvIncomeStatement.FullRowSelect = True
        Me.lvIncomeStatement.GridLines = True
        Me.lvIncomeStatement.Location = New System.Drawing.Point(13, 176)
        Me.lvIncomeStatement.Name = "lvIncomeStatement"
        Me.lvIncomeStatement.Size = New System.Drawing.Size(789, 359)
        Me.lvIncomeStatement.TabIndex = 227
        Me.lvIncomeStatement.UseCompatibleStateImageBehavior = False
        Me.lvIncomeStatement.View = System.Windows.Forms.View.Details
        '
        'chAccounts
        '
        Me.chAccounts.Text = ""
        Me.chAccounts.Width = 500
        '
        'chDebit
        '
        Me.chDebit.Text = ""
        Me.chDebit.Width = 300
        '
        'chCredit
        '
        Me.chCredit.Text = ""
        Me.chCredit.Width = 300
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Gold
        Me.btnPrint.Location = New System.Drawing.Point(576, 30)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(115, 34)
        Me.btnPrint.TabIndex = 44
        Me.btnPrint.Text = "Preview"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_Cancel.FlatAppearance.BorderSize = 0
        Me.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Cancel.ForeColor = System.Drawing.Color.Gold
        Me.btn_Cancel.Location = New System.Drawing.Point(697, 30)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(115, 34)
        Me.btn_Cancel.TabIndex = 43
        Me.btn_Cancel.Text = "Cancel"
        Me.btn_Cancel.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(0, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(812, 34)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "    Income Statement Report"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlPrint
        '
        Me.pnlPrint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrint.BackColor = System.Drawing.Color.Silver
        Me.pnlPrint.Controls.Add(Me.btnPrintAttack)
        Me.pnlPrint.Controls.Add(Me.btnCancelPrintattack)
        Me.pnlPrint.Controls.Add(Me.crvInc)
        Me.pnlPrint.Controls.Add(Me.Label3)
        Me.pnlPrint.Location = New System.Drawing.Point(13, 3)
        Me.pnlPrint.Name = "pnlPrint"
        Me.pnlPrint.Size = New System.Drawing.Size(782, 506)
        Me.pnlPrint.TabIndex = 21
        Me.pnlPrint.Visible = False
        '
        'btnPrintAttack
        '
        Me.btnPrintAttack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintAttack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPrintAttack.FlatAppearance.BorderSize = 0
        Me.btnPrintAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintAttack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintAttack.ForeColor = System.Drawing.Color.Gold
        Me.btnPrintAttack.Location = New System.Drawing.Point(546, 20)
        Me.btnPrintAttack.Name = "btnPrintAttack"
        Me.btnPrintAttack.Size = New System.Drawing.Size(115, 34)
        Me.btnPrintAttack.TabIndex = 84
        Me.btnPrintAttack.Text = "Print"
        Me.btnPrintAttack.UseVisualStyleBackColor = False
        '
        'btnCancelPrintattack
        '
        Me.btnCancelPrintattack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelPrintattack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCancelPrintattack.FlatAppearance.BorderSize = 0
        Me.btnCancelPrintattack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelPrintattack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPrintattack.ForeColor = System.Drawing.Color.Gold
        Me.btnCancelPrintattack.Location = New System.Drawing.Point(667, 20)
        Me.btnCancelPrintattack.Name = "btnCancelPrintattack"
        Me.btnCancelPrintattack.Size = New System.Drawing.Size(115, 34)
        Me.btnCancelPrintattack.TabIndex = 83
        Me.btnCancelPrintattack.Text = "Cancel"
        Me.btnCancelPrintattack.UseVisualStyleBackColor = False
        '
        'crvInc
        '
        Me.crvInc.ActiveViewIndex = -1
        Me.crvInc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvInc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvInc.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvInc.Location = New System.Drawing.Point(3, 66)
        Me.crvInc.Name = "crvInc"
        Me.crvInc.Size = New System.Drawing.Size(776, 437)
        Me.crvInc.TabIndex = 82
        Me.crvInc.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(-27, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(809, 34)
        Me.Label3.TabIndex = 85
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Income_Statement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.pnlPrint)
        Me.Controls.Add(Me.pnlIncMain)
        Me.Name = "Income_Statement"
        Me.Size = New System.Drawing.Size(812, 555)
        Me.pnlIncMain.ResumeLayout(False)
        Me.pnlIncMain.PerformLayout()
        Me.pnlPrint.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlIncMain As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btn_Cancel As System.Windows.Forms.Button
    Friend WithEvents lvIncomeStatement As System.Windows.Forms.ListView
    Friend WithEvents chAccounts As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDebit As System.Windows.Forms.ColumnHeader
    Friend WithEvents chCredit As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblNet As System.Windows.Forms.Label
    Friend WithEvents pnlPrint As System.Windows.Forms.Panel
    Friend WithEvents crvInc As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnPrintAttack As System.Windows.Forms.Button
    Friend WithEvents btnCancelPrintattack As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox

End Class
