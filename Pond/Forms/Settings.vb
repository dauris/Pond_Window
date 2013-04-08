Public Class Options

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        currentHome.Text = My.Settings.Homepage
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles pondHomepageChange.TextChanged
        My.Settings.Homepage = pondHomepageChange.Text
    End Sub

    Private Sub pondSetHomepage_Click(sender As Object, e As EventArgs) Handles pondSetHomepage.Click
        If pondCurrentPage.Checked Then
            My.Settings.Homepage = currentPage.Text
        End If
        If pondNewHome.Checked Then
            If pondHomepageChange.Text = "" Then
                pondHomepageChange.Focus()
                Exit Sub
            End If

            Dim newPondURL As String
            newPondURL = pondHomepageChange.Text
            If newPondURL.Contains("http://") = False Then
                pondHomepageChange.Text = "http://" & newPondURL & ".com"

                My.Settings.Homepage = pondHomepageChange.Text
                currentHome.Text = My.Settings.Homepage
            End If

        End If
    End Sub
End Class