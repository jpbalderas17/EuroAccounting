<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiFunctionCalculator
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnSolveCoGS = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCoGS = New System.Windows.Forms.TextBox()
        Me.txtEndInvent = New System.Windows.Forms.TextBox()
        Me.txtPirchases = New System.Windows.Forms.TextBox()
        Me.txtBegInven = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnSolveSLD = New System.Windows.Forms.Button()
        Me.txtAnnualDepExSLD = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtLifeExp = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtScrapValSLD = New System.Windows.Forms.TextBox()
        Me.txtIniCostSLD = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtAnnualDepExBalRed = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPercentage = New System.Windows.Forms.TextBox()
        Me.txtScrapValBalRed = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAccuDep = New System.Windows.Forms.TextBox()
        Me.txtInitialCostBalRed = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSolveBalRed = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(12, 23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(644, 176)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnSolveCoGS)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtCoGS)
        Me.TabPage1.Controls.Add(Me.txtEndInvent)
        Me.TabPage1.Controls.Add(Me.txtPirchases)
        Me.TabPage1.Controls.Add(Me.txtBegInven)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(636, 147)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cost of Good Sold"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnSolveCoGS
        '
        Me.btnSolveCoGS.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSolveCoGS.FlatAppearance.BorderSize = 0
        Me.btnSolveCoGS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSolveCoGS.ForeColor = System.Drawing.Color.Gold
        Me.btnSolveCoGS.Location = New System.Drawing.Point(519, 108)
        Me.btnSolveCoGS.Name = "btnSolveCoGS"
        Me.btnSolveCoGS.Size = New System.Drawing.Size(75, 23)
        Me.btnSolveCoGS.TabIndex = 11
        Me.btnSolveCoGS.Text = "Solve"
        Me.btnSolveCoGS.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(451, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "="
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(305, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "+"
        '
        'txtCoGS
        '
        Me.txtCoGS.Location = New System.Drawing.Point(472, 45)
        Me.txtCoGS.Name = "txtCoGS"
        Me.txtCoGS.ReadOnly = True
        Me.txtCoGS.Size = New System.Drawing.Size(122, 22)
        Me.txtCoGS.TabIndex = 7
        '
        'txtEndInvent
        '
        Me.txtEndInvent.Location = New System.Drawing.Point(323, 45)
        Me.txtEndInvent.Name = "txtEndInvent"
        Me.txtEndInvent.Size = New System.Drawing.Size(122, 22)
        Me.txtEndInvent.TabIndex = 6
        '
        'txtPirchases
        '
        Me.txtPirchases.Location = New System.Drawing.Point(177, 45)
        Me.txtPirchases.Name = "txtPirchases"
        Me.txtPirchases.Size = New System.Drawing.Size(122, 22)
        Me.txtPirchases.TabIndex = 5
        '
        'txtBegInven
        '
        Me.txtBegInven.Location = New System.Drawing.Point(28, 45)
        Me.txtBegInven.Name = "txtBegInven"
        Me.txtBegInven.Size = New System.Drawing.Size(122, 22)
        Me.txtBegInven.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(469, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cost of Good Sold"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(332, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ending Inventory"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Purchases"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Beginning Inventory"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnSolveSLD)
        Me.TabPage2.Controls.Add(Me.txtAnnualDepExSLD)
        Me.TabPage2.Controls.Add(Me.Label25)
        Me.TabPage2.Controls.Add(Me.Label24)
        Me.TabPage2.Controls.Add(Me.txtLifeExp)
        Me.TabPage2.Controls.Add(Me.Label23)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.txtScrapValSLD)
        Me.TabPage2.Controls.Add(Me.txtIniCostSLD)
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(636, 147)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Straight Line Depreciation"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnSolveSLD
        '
        Me.btnSolveSLD.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSolveSLD.FlatAppearance.BorderSize = 0
        Me.btnSolveSLD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSolveSLD.ForeColor = System.Drawing.Color.Gold
        Me.btnSolveSLD.Location = New System.Drawing.Point(538, 110)
        Me.btnSolveSLD.Name = "btnSolveSLD"
        Me.btnSolveSLD.Size = New System.Drawing.Size(75, 23)
        Me.btnSolveSLD.TabIndex = 51
        Me.btnSolveSLD.Text = "Solve"
        Me.btnSolveSLD.UseVisualStyleBackColor = False
        '
        'txtAnnualDepExSLD
        '
        Me.txtAnnualDepExSLD.Location = New System.Drawing.Point(381, 67)
        Me.txtAnnualDepExSLD.Name = "txtAnnualDepExSLD"
        Me.txtAnnualDepExSLD.ReadOnly = True
        Me.txtAnnualDepExSLD.Size = New System.Drawing.Size(122, 22)
        Me.txtAnnualDepExSLD.TabIndex = 50
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(352, 47)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(185, 16)
        Me.Label25.TabIndex = 49
        Me.Label25.Text = "Annual Depreciation Expense"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(311, 70)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(15, 16)
        Me.Label24.TabIndex = 48
        Me.Label24.Text = "="
        '
        'txtLifeExp
        '
        Me.txtLifeExp.Location = New System.Drawing.Point(86, 110)
        Me.txtLifeExp.Name = "txtLifeExp"
        Me.txtLifeExp.Size = New System.Drawing.Size(122, 22)
        Me.txtLifeExp.TabIndex = 47
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(94, 91)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(102, 16)
        Me.Label23.TabIndex = 46
        Me.Label23.Text = "Life Expectancy"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(14, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(274, 16)
        Me.Label22.TabIndex = 45
        Me.Label22.Text = "______________________________________"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(143, 44)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(12, 16)
        Me.Label21.TabIndex = 44
        Me.Label21.Text = "-"
        '
        'txtScrapValSLD
        '
        Me.txtScrapValSLD.Location = New System.Drawing.Point(161, 41)
        Me.txtScrapValSLD.Name = "txtScrapValSLD"
        Me.txtScrapValSLD.Size = New System.Drawing.Size(122, 22)
        Me.txtScrapValSLD.TabIndex = 43
        '
        'txtIniCostSLD
        '
        Me.txtIniCostSLD.Location = New System.Drawing.Point(15, 41)
        Me.txtIniCostSLD.Name = "txtIniCostSLD"
        Me.txtIniCostSLD.Size = New System.Drawing.Size(122, 22)
        Me.txtIniCostSLD.TabIndex = 42
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(181, 22)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 16)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "Scrap Value"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(40, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 16)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "Initial Cost"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtAnnualDepExBalRed)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.txtPercentage)
        Me.TabPage3.Controls.Add(Me.txtScrapValBalRed)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.txtAccuDep)
        Me.TabPage3.Controls.Add(Me.txtInitialCostBalRed)
        Me.TabPage3.Controls.Add(Me.Label11)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.btnSolveBalRed)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(636, 147)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Balance Reduction"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtAnnualDepExBalRed
        '
        Me.txtAnnualDepExBalRed.Location = New System.Drawing.Point(57, 106)
        Me.txtAnnualDepExBalRed.Name = "txtAnnualDepExBalRed"
        Me.txtAnnualDepExBalRed.ReadOnly = True
        Me.txtAnnualDepExBalRed.Size = New System.Drawing.Size(122, 22)
        Me.txtAnnualDepExBalRed.TabIndex = 45
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(33, 83)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(185, 16)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Annual Depreciation Expense"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(22, 109)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 16)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "="
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(474, 41)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 16)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(456, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(12, 16)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = ")"
        '
        'txtPercentage
        '
        Me.txtPercentage.Location = New System.Drawing.Point(492, 38)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.Size = New System.Drawing.Size(122, 22)
        Me.txtPercentage.TabIndex = 40
        '
        'txtScrapValBalRed
        '
        Me.txtScrapValBalRed.Location = New System.Drawing.Point(328, 37)
        Me.txtScrapValBalRed.Name = "txtScrapValBalRed"
        Me.txtScrapValBalRed.Size = New System.Drawing.Size(122, 22)
        Me.txtScrapValBalRed.TabIndex = 39
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(310, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(12, 16)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(164, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(12, 16)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "-"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(12, 16)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "("
        '
        'txtAccuDep
        '
        Me.txtAccuDep.Location = New System.Drawing.Point(182, 38)
        Me.txtAccuDep.Name = "txtAccuDep"
        Me.txtAccuDep.Size = New System.Drawing.Size(122, 22)
        Me.txtAccuDep.TabIndex = 35
        '
        'txtInitialCostBalRed
        '
        Me.txtInitialCostBalRed.Location = New System.Drawing.Point(36, 38)
        Me.txtInitialCostBalRed.Name = "txtInitialCostBalRed"
        Me.txtInitialCostBalRed.Size = New System.Drawing.Size(122, 22)
        Me.txtInitialCostBalRed.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(544, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(20, 16)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(346, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 16)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Scrap Value"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(164, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 16)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Accumulated Depreciation"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(61, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 16)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Initial Cost"
        '
        'btnSolveBalRed
        '
        Me.btnSolveBalRed.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnSolveBalRed.FlatAppearance.BorderSize = 0
        Me.btnSolveBalRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSolveBalRed.ForeColor = System.Drawing.Color.Gold
        Me.btnSolveBalRed.Location = New System.Drawing.Point(539, 105)
        Me.btnSolveBalRed.Name = "btnSolveBalRed"
        Me.btnSolveBalRed.Size = New System.Drawing.Size(75, 23)
        Me.btnSolveBalRed.TabIndex = 29
        Me.btnSolveBalRed.Text = "Solve"
        Me.btnSolveBalRed.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(500, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Solve"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MultiFunctionCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 217)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MultiFunctionCalculator"
        Me.Text = "Multi Function Calculator"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCoGS As System.Windows.Forms.TextBox
    Friend WithEvents txtEndInvent As System.Windows.Forms.TextBox
    Friend WithEvents txtPirchases As System.Windows.Forms.TextBox
    Friend WithEvents txtBegInven As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSolveCoGS As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtScrapValSLD As System.Windows.Forms.TextBox
    Friend WithEvents txtIniCostSLD As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtAnnualDepExBalRed As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPercentage As System.Windows.Forms.TextBox
    Friend WithEvents txtScrapValBalRed As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAccuDep As System.Windows.Forms.TextBox
    Friend WithEvents txtInitialCostBalRed As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSolveBalRed As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtLifeExp As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnSolveSLD As System.Windows.Forms.Button
    Friend WithEvents txtAnnualDepExSLD As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
End Class
