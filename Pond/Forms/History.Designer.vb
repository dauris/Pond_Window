<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pondHistoryDeleteAll = New System.Windows.Forms.Button()
        Me.pondHistoryDelete = New System.Windows.Forms.Button()
        Me.pondHistoryOk = New System.Windows.Forms.Button()
        Me.pondHistoryList = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pondHistoryDeleteAll)
        Me.Panel1.Controls.Add(Me.pondHistoryDelete)
        Me.Panel1.Controls.Add(Me.pondHistoryOk)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 272)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 33)
        Me.Panel1.TabIndex = 1
        '
        'pondHistoryDeleteAll
        '
        Me.pondHistoryDeleteAll.Location = New System.Drawing.Point(108, 7)
        Me.pondHistoryDeleteAll.Name = "pondHistoryDeleteAll"
        Me.pondHistoryDeleteAll.Size = New System.Drawing.Size(75, 23)
        Me.pondHistoryDeleteAll.TabIndex = 4
        Me.pondHistoryDeleteAll.Text = "Delete All"
        Me.pondHistoryDeleteAll.UseVisualStyleBackColor = True
        '
        'pondHistoryDelete
        '
        Me.pondHistoryDelete.Location = New System.Drawing.Point(3, 6)
        Me.pondHistoryDelete.Name = "pondHistoryDelete"
        Me.pondHistoryDelete.Size = New System.Drawing.Size(99, 23)
        Me.pondHistoryDelete.TabIndex = 3
        Me.pondHistoryDelete.Text = "Delete Selected"
        Me.pondHistoryDelete.UseVisualStyleBackColor = True
        '
        'pondHistoryOk
        '
        Me.pondHistoryOk.Location = New System.Drawing.Point(356, 6)
        Me.pondHistoryOk.Name = "pondHistoryOk"
        Me.pondHistoryOk.Size = New System.Drawing.Size(75, 23)
        Me.pondHistoryOk.TabIndex = 2
        Me.pondHistoryOk.Text = "OK"
        Me.pondHistoryOk.UseVisualStyleBackColor = True
        '
        'pondHistoryList
        '
        Me.pondHistoryList.FormattingEnabled = True
        Me.pondHistoryList.Location = New System.Drawing.Point(0, 0)
        Me.pondHistoryList.Name = "pondHistoryList"
        Me.pondHistoryList.Size = New System.Drawing.Size(443, 277)
        Me.pondHistoryList.TabIndex = 5
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 305)
        Me.Controls.Add(Me.pondHistoryList)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "History"
        Me.Text = "History"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pondHistoryOk As System.Windows.Forms.Button
    Friend WithEvents pondHistoryDeleteAll As System.Windows.Forms.Button
    Friend WithEvents pondHistoryDelete As System.Windows.Forms.Button
    Friend WithEvents pondHistoryList As System.Windows.Forms.ListBox
End Class
