<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sample_Reports
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
        Me.crvInc = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvInc
        '
        Me.crvInc.ActiveViewIndex = -1
        Me.crvInc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvInc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvInc.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvInc.Location = New System.Drawing.Point(12, 12)
        Me.crvInc.Name = "crvInc"
        Me.crvInc.Size = New System.Drawing.Size(831, 435)
        Me.crvInc.TabIndex = 81
        Me.crvInc.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Sample_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 459)
        Me.Controls.Add(Me.crvInc)
        Me.Name = "Sample_Reports"
        Me.Text = "Sample_Reports"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvInc As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
