Public Class Journal_Entry

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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
