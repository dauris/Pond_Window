<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookmarkzAdd
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
        Me.pondBookText = New System.Windows.Forms.TextBox()
        Me.pondBookAdd = New System.Windows.Forms.Button()
        Me.pondBookCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pondBookText
        '
        Me.pondBookText.Location = New System.Drawing.Point(13, 13)
        Me.pondBookText.Name = "pondBookText"
        Me.pondBookText.Size = New System.Drawing.Size(492, 20)
        Me.pondBookText.TabIndex = 0
        '
        'pondBookAdd
        '
        Me.pondBookAdd.Location = New System.Drawing.Point(430, 39)
        Me.pondBookAdd.Name = "pondBookAdd"
        Me.pondBookAdd.Size = New System.Drawing.Size(75, 23)
        Me.pondBookAdd.TabIndex = 1
        Me.pondBookAdd.Text = "Add"
        Me.pondBookAdd.UseVisualStyleBackColor = True
        '
        'pondBookCancel
        '
        Me.pondBookCancel.Location = New System.Drawing.Point(349, 39)
        Me.pondBookCancel.Name = "pondBookCancel"
        Me.pondBookCancel.Size = New System.Drawing.Size(75, 23)
        Me.pondBookCancel.TabIndex = 2
        Me.pondBookCancel.Text = "Cancel"
        Me.pondBookCancel.UseVisualStyleBackColor = True
        '
        'bookmarkzAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 70)
        Me.Controls.Add(Me.pondBookCancel)
        Me.Controls.Add(Me.pondBookAdd)
        Me.Controls.Add(Me.pondBookText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "bookmarkzAdd"
        Me.ShowIcon = False
        Me.Text = "Add Custom Bookmark"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pondBookText As System.Windows.Forms.TextBox
    Friend WithEvents pondBookAdd As System.Windows.Forms.Button
    Friend WithEvents pondBookCancel As System.Windows.Forms.Button
End Class
