Public Class MultiFunctionCalculator

    Private Sub btnSolveCoGS_Click(sender As Object, e As EventArgs) Handles btnSolveCoGS.Click
        txtCoGS.Text = Val(txtBegInven.Text) + Val(txtPirchases.Text) - Val(txtEndInvent.Text)
    End Sub

    Private Sub btnSolveSLD_Click(sender As Object, e As EventArgs) Handles btnSolveSLD.Click
        txtAnnualDepExSLD.Text = (Val(txtIniCostSLD.Text) - Val(txtScrapValSLD.Text)) _
    / Val(txtLifeExp.Text)
    End Sub
    Private Sub btnSolveBalRed_Click(sender As Object, e As EventArgs) Handles btnSolveBalRed.Click
        txtAnnualDepExBalRed.Text = ((Val(txtInitialCostBalRed.Text) - Val(txtAccuDep.Text)) _
            - Val(txtScrapValBalRed.Text)) * Val(txtPercentage.Text)

    End Sub
    Private Sub TabControl1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPirchases.KeyPress, txtEndInvent.KeyPress, txtBegInven.KeyPress, TabControl1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If e.Handled = (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") Then
                e.Handled = True
            End If
        End If
    End Sub

 
   
    Private Sub txtIniCostSLD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScrapValSLD.KeyPress, txtLifeExp.KeyPress, txtIniCostSLD.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If e.Handled = (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtInitialCostBalRed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtScrapValBalRed.KeyPress, txtInitialCostBalRed.KeyPress, txtAccuDep.KeyPress, txtPercentage.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If e.Handled = (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") Then
                e.Handled = True
            End If
        End If
    End Sub

    
    

End Class