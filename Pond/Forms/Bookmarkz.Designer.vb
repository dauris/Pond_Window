<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bookmarkz
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
        Me.pondSubtract = New System.Windows.Forms.Button()
        Me.pondAdd = New System.Windows.Forms.Button()
        Me.pondBookzList = New System.Windows.Forms.ListBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pondSubtract)
        Me.Panel1.Controls.Add(Me.pondAdd)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 316)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 30)
        Me.Panel1.TabIndex = 1
        '
        'pondSubtract
        '
        Me.pondSubtract.Location = New System.Drawing.Point(12, 3)
        Me.pondSubtract.Name = "pondSubtract"
        Me.pondSubtract.Size = New System.Drawing.Size(75, 23)
        Me.pondSubtract.TabIndex = 1
        Me.pondSubtract.Text = "-"
        Me.pondSubtract.UseVisualStyleBackColor = True
        '
        'pondAdd
        '
        Me.pondAdd.Location = New System.Drawing.Point(283, 3)
        Me.pondAdd.Name = "pondAdd"
        Me.pondAdd.Size = New System.Drawing.Size(75, 23)
        Me.pondAdd.TabIndex = 0
        Me.pondAdd.Text = "+"
        Me.pondAdd.UseVisualStyleBackColor = True
        '
        'pondBookzList
        '
        Me.pondBookzList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pondBookzList.FormattingEnabled = True
        Me.pondBookzList.Location = New System.Drawing.Point(0, 0)
        Me.pondBookzList.Name = "pondBookzList"
        Me.pondBookzList.Size = New System.Drawing.Size(370, 316)
        Me.pondBookzList.TabIndex = 2
        '
        'Bookmarkz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 346)
        Me.Controls.Add(Me.pondBookzList)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Bookmarkz"
        Me.ShowIcon = False
        Me.Text = "Your Bookmark'z"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents pondSubtract As System.Windows.Forms.Button
    Friend WithEvents pondAdd As System.Windows.Forms.Button
    Friend WithEvents pondBookzList As System.Windows.Forms.ListBox
End Class
