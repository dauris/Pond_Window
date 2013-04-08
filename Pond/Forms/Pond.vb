Public Class Pond

    Private Sub PondTab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pondTab As New TabPage
        Dim newTab As New PondMain
        newTab.Show()
        newTab.Dock = DockStyle.Fill
        newTab.TopLevel = False
        newTab.Visible = True
        pondTab.Controls.Add(newTab)
        pondTabControl.TabPages.Add(pondTab)
    End Sub
End Class
