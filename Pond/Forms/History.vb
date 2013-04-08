Public Class History

    Private Sub pondHistoryOk_Click(sender As Object, e As EventArgs) Handles pondHistoryOk.Click
        Me.Close()
    End Sub

    Private Sub pondHistoryDelete_Click(sender As Object, e As EventArgs) Handles pondHistoryDelete.Click
        My.Settings.History.Clear()
        pondHistoryList.Items.Remove(pondHistoryList.SelectedItem)
    End Sub

    Private Sub pondHistoryDeleteAll_Click(sender As Object, e As EventArgs) Handles pondHistoryDeleteAll.Click
        My.Settings.History.Clear()
        pondHistoryList.Items.Clear()
        MsgBox("History Cleaned")
    End Sub

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not My.Settings.History.Count = 0 Then
            Dim pondHistory As Integer
            Do Until pondHistoryList.Items.Count = My.Settings.History.Count
                pondHistoryList.Items.Add(My.Settings.History(pondHistory))
                pondHistory += 1
            Loop
        End If
    End Sub
End Class