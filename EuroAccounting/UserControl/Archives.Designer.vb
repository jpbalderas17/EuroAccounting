﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Archives
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
        Me.pnlMain = New System.Windows.Forms.Panel()
        Me.lvljournal = New System.Windows.Forms.ListView()
        Me.chID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDesc = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlMain
        '
        Me.pnlMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMain.Controls.Add(Me.lvljournal)
        Me.pnlMain.Controls.Add(Me.btnDelete)
        Me.pnlMain.Controls.Add(Me.btnRestore)
        Me.pnlMain.Controls.Add(Me.btn_Close)
        Me.pnlMain.Controls.Add(Me.Label2)
        Me.pnlMain.Location = New System.Drawing.Point(0, 0)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1030, 482)
        Me.pnlMain.TabIndex = 21
        '
        'lvljournal
        '
        Me.lvljournal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvljournal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lvljournal.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chID, Me.chName, Me.chDesc})
        Me.lvljournal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvljournal.FullRowSelect = True
        Me.lvljournal.GridLines = True
        Me.lvljournal.Location = New System.Drawing.Point(15, 148)
        Me.lvljournal.Name = "lvljournal"
        Me.lvljournal.Size = New System.Drawing.Size(1001, 311)
        Me.lvljournal.TabIndex = 233
        Me.lvljournal.UseCompatibleStateImageBehavior = False
        Me.lvljournal.View = System.Windows.Forms.View.Details
        '
        'chID
        '
        Me.chID.Text = "ID"
        Me.chID.Width = 147
        '
        'chName
        '
        Me.chName.Text = "Name"
        Me.chName.Width = 468
        '
        'chDesc
        '
        Me.chDesc.Text = "Description"
        Me.chDesc.Width = 505
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Gold
        Me.btnDelete.Location = New System.Drawing.Point(835, 58)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(93, 34)
        Me.btnDelete.TabIndex = 230
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnRestore
        '
        Me.btnRestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestore.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnRestore.FlatAppearance.BorderSize = 0
        Me.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestore.ForeColor = System.Drawing.Color.Gold
        Me.btnRestore.Location = New System.Drawing.Point(736, 58)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(93, 34)
        Me.btnRestore.TabIndex = 229
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = False
        '
        'btn_Close
        '
        Me.btn_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Close.BackColor = System.Drawing.Color.MidnightBlue
        Me.btn_Close.FlatAppearance.BorderSize = 0
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Close.ForeColor = System.Drawing.Color.Gold
        Me.btn_Close.Location = New System.Drawing.Point(934, 58)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(93, 34)
        Me.btn_Close.TabIndex = 228
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = False
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
        Me.Label2.Size = New System.Drawing.Size(1027, 34)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "    Archives of Ledgers"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Archives
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "Archives"
        Me.Size = New System.Drawing.Size(1030, 550)
        Me.pnlMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlMain As System.Windows.Forms.Panel
    Friend WithEvents lvljournal As System.Windows.Forms.ListView
    Friend WithEvents chID As System.Windows.Forms.ColumnHeader
    Friend WithEvents chName As System.Windows.Forms.ColumnHeader
    Friend WithEvents chDesc As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class