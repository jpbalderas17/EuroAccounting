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
        Me.btn_View_Journal = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_View_Journal
        '
        Me.btn_View_Journal.Location = New System.Drawing.Point(25, 29)
        Me.btn_View_Journal.Name = "btn_View_Journal"
        Me.btn_View_Journal.Size = New System.Drawing.Size(114, 92)
        Me.btn_View_Journal.TabIndex = 0
        Me.btn_View_Journal.Text = "View Journal"
        Me.btn_View_Journal.UseVisualStyleBackColor = True
        '
        'MainMenu2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btn_View_Journal)
        Me.Name = "MainMenu2"
        Me.Size = New System.Drawing.Size(842, 403)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_View_Journal As System.Windows.Forms.Button

End Class
