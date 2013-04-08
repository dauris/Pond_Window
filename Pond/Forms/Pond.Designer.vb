<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pond
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
        Me.components = New System.ComponentModel.Container()
        Me.pondTabControl = New System.Windows.Forms.TabControl()
        Me.pondFavIco = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'pondTabControl
        '
        Me.pondTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pondTabControl.ImageList = Me.pondFavIco
        Me.pondTabControl.Location = New System.Drawing.Point(0, 0)
        Me.pondTabControl.Name = "pondTabControl"
        Me.pondTabControl.SelectedIndex = 0
        Me.pondTabControl.Size = New System.Drawing.Size(1008, 730)
        Me.pondTabControl.TabIndex = 0
        '
        'pondFavIco
        '
        Me.pondFavIco.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.pondFavIco.ImageSize = New System.Drawing.Size(16, 16)
        Me.pondFavIco.TransparentColor = System.Drawing.Color.Transparent
        '
        'Pond
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.pondTabControl)
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "Pond"
        Me.Text = "Pond"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pondTabControl As System.Windows.Forms.TabControl
    Friend WithEvents pondFavIco As System.Windows.Forms.ImageList

End Class
