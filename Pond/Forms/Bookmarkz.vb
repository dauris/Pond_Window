Public Class Bookmarkz

    Private Sub pondAdd_Click(sender As Object, e As EventArgs) Handles pondAdd.Click
        bookmarkzAdd.ShowDialog()
        pondBookzList.Items.Clear()
        If Not My.Settings.Bookmarkz.Count = 0 Then
            Dim book As Integer
            Do Until My.Settings.Bookmarkz.Count = book
                pondBookzList.Items.Add(My.Settings.Bookmarkz(book))
                book += 1
            Loop
        End If
    End Sub

    Private Sub pondSubtract_Click(sender As Object, e As EventArgs) Handles pondSubtract.Click
        My.Settings.Bookmarkz.Remove(pondBookzList.Text)
        pondBookzList.Items.Remove(pondBookzList.SelectedItem)
    End Sub
End Class