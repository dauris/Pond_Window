Public Class bookmarkzAdd

    Private Sub pondBookAdd_Click(sender As Object, e As EventArgs) Handles pondBookAdd.Click
        My.Settings.Bookmarkz.Add(pondBookText.Text)
        pondBookText.Clear()
        Me.Close()
    End Sub

    Private Sub pondBookCancel_Click(sender As Object, e As EventArgs) Handles pondBookCancel.Click
        pondBookText.Clear()
        Me.Close()
    End Sub

    Private Sub pondBookText_KeyDown(sender As Object, e As KeyEventArgs) Handles pondBookText.KeyDown
        If e.KeyCode = Keys.Enter Then
            pondBookAdd.PerformClick()
        End If
    End Sub
End Class