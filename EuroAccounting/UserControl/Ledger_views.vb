Public Class Ledger_views
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        'Me.Width = Me.Parent.Width

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Shadows Sub resize()
        Me.Width = Panel1.Width '= new_width
        'MsgBox("asdasd")
    End Sub
End Class
