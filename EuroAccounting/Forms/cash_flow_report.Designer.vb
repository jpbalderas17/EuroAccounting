<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cash_flow_report
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
        Me.pnlPrint = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnCancelPrintattack = New System.Windows.Forms.Button()
        Me.crvCF = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlPrint.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlPrint
        '
        Me.pnlPrint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlPrint.BackColor = System.Drawing.Color.Silver
        Me.pnlPrint.Controls.Add(Me.btnPrint)
        Me.pnlPrint.Controls.Add(Me.btnCancelPrintattack)
        Me.pnlPrint.Controls.Add(Me.crvCF)
        Me.pnlPrint.Controls.Add(Me.Label5)
        Me.pnlPrint.Location = New System.Drawing.Point(2, 1)
        Me.pnlPrint.Name = "pnlPrint"
        Me.pnlPrint.Size = New System.Drawing.Size(853, 460)
        Me.pnlPrint.TabIndex = 251
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Gold
        Me.btnPrint.Location = New System.Drawing.Point(617, 33)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(115, 34)
        Me.btnPrint.TabIndex = 84
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnCancelPrintattack
        '
        Me.btnCancelPrintattack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelPrintattack.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnCancelPrintattack.FlatAppearance.BorderSize = 0
        Me.btnCancelPrintattack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelPrintattack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelPrintattack.ForeColor = System.Drawing.Color.Gold
        Me.btnCancelPrintattack.Location = New System.Drawing.Point(738, 33)
        Me.btnCancelPrintattack.Name = "btnCancelPrintattack"
        Me.btnCancelPrintattack.Size = New System.Drawing.Size(115, 34)
        Me.btnCancelPrintattack.TabIndex = 83
        Me.btnCancelPrintattack.Text = "Cancel"
        Me.btnCancelPrintattack.UseVisualStyleBackColor = False
        '
        'crvCF
        '
        Me.crvCF.ActiveViewIndex = -1
        Me.crvCF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvCF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvCF.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvCF.Location = New System.Drawing.Point(4, 77)
        Me.crvCF.Name = "crvCF"
        Me.crvCF.Size = New System.Drawing.Size(847, 364)
        Me.crvCF.TabIndex = 82
        Me.crvCF.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gold
        Me.Label5.Location = New System.Drawing.Point(-27, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(880, 34)
        Me.Label5.TabIndex = 85
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cash_flow_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(856, 463)
        Me.Controls.Add(Me.pnlPrint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cash_flow_report"
        Me.Text = "cash_flow_report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlPrint.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlPrint As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnCancelPrintattack As System.Windows.Forms.Button
    Friend WithEvents crvCF As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
