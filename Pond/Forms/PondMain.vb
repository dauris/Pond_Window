Public Class PondMain

    'Primariy controls'
#Region "-Address Bar'"
    Private Sub pondBack_ButtonClick(sender As Object, e As EventArgs) Handles pondBack.ButtonClick
        AxWebBrowser1.GoBack()
    End Sub

    Private Sub pondURL_KeyDown(sender As Object, e As KeyEventArgs) Handles pondURL.KeyDown
        'This allow the users to press enter and surf'
        If e.KeyCode = Keys.Enter Then
            If pondURL.Text <> "" Then
                AxWebBrowser1.Navigate(pondURL.Text)
            End If
        End If
    End Sub

    Private Sub pondForward_ButtonClick(sender As Object, e As EventArgs) Handles pondForward.ButtonClick
        AxWebBrowser1.GoForward()
    End Sub

    Private Sub pondStop_Click(sender As Object, e As EventArgs) Handles pondStop.Click
        AxWebBrowser1.Stop()
    End Sub

    Private Sub pondRefresh_Click(sender As Object, e As EventArgs) Handles pondRefresh.Click
        AxWebBrowser1.Refresh()
    End Sub
#End Region

#Region "-Tab Name'"
    Private Sub AxWebBrowser1_NavigateComplete2(sender As Object, e As AxSHDocVw.DWebBrowserEvents2_NavigateComplete2Event) Handles AxWebBrowser1.NavigateComplete2
        Parent.Text = AxWebBrowser1.LocationName
        Pond.Text = AxWebBrowser1.LocationName
        pondURL.Text = AxWebBrowser1.LocationURL
        If Not My.Settings.History.Contains(AxWebBrowser1.LocationURL.ToString) Then
            My.Settings.History.Add(AxWebBrowser1.LocationURL.ToString)
        End If

        'pondURL.Text = AxWebBrowser1.LocationURL.ToString
        'Dim url As Uri = New Uri(pondURL.Text)
        'If url.HostNameType = UriHostNameType.Dns Then
        '    Dim icons = "https://" & url.Host & "/favicon.ico"
        '    Dim req As System.Net.WebRequest = System.Net.HttpWebRequest.Create(icons)
        '    Dim res As System.Net.HttpWebResponse = req.GetResponse
        '    Dim stream As System.IO.Stream = res.GetResponseStream
        '    Dim fav = Image.FromStream(stream)
        '    Me.pondFavicon.Image = fav
        'End If
    End Sub

    Private Sub AxWebBrowser1_DocumentComplete(sender As Object, e As AxSHDocVw.DWebBrowserEvents2_DocumentCompleteEvent) Handles AxWebBrowser1.DocumentComplete
        Pond.pondTabControl.SelectedTab.Text = AxWebBrowser1.LocationName.ToString
        Dim url As Uri = New Uri(pondURL.Text)
        If url.HostNameType = UriHostNameType.Dns Then
            Dim icon = "http://" & url.Host & "/favicon.ico"
            Dim request As System.Net.WebRequest = System.Net.HttpWebRequest.Create(icon)
            Dim response As System.Net.HttpWebResponse = request.GetResponse
            Dim stream As System.IO.Stream = response.GetResponseStream
            Dim image1 = Image.FromStream(stream)
            Pond.pondFavIco.Images.Add(image1)
            Pond.pondTabControl.SelectedTab.ImageIndex = Pond.pondFavIco.Images.Count - 1
        End If
    End Sub
#End Region

#Region "-Go Home'"
    Private Sub pondHome_Click(sender As Object, e As EventArgs) Handles pondHome.Click
        AxWebBrowser1.Navigate(My.Settings.Homepage)
    End Sub
#End Region

    'Secondary controls (will be invisible)' 
#Region "-File'"
    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_PRINT, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER)
    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_PRINTPREVIEW, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER)
    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PageSetupToolStripMenuItem.Click
        AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_PAGESETUP, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER)
    End Sub

    Private Sub PropertiesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PropertiesToolStripMenuItem.Click
        AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_PROPERTIES, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER)
    End Sub

    Private Sub NewTabToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewTabToolStripMenuItem1.Click
        Dim pondTab As New TabPage
        Dim newTab As New PondMain
        newTab.Show()
        newTab.Dock = DockStyle.Fill
        newTab.TopLevel = False
        newTab.Visible = True
        pondTab.Controls.Add(newTab)
        Pond.pondTabControl.TabPages.Add(pondTab)
    End Sub

    Private Sub RemoveTabToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RemoveTabToolStripMenuItem1.Click
        If Pond.pondTabControl.TabCount = 1 Then
            Dim pondTab As New TabPage
            Dim newTab As New PondMain
            newTab.Show()
            newTab.Dock = DockStyle.Fill
            newTab.TopLevel = False
            newTab.Visible = True
            pondTab.Controls.Add(newTab)
            Pond.pondTabControl.TabPages.Add(pondTab)
            Pond.pondTabControl.SelectedTab.Dispose()
        Else
            Pond.pondTabControl.SelectedTab.Dispose()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_OPEN, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_SAVE, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER)
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_SAVEAS, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Pond.Close()
    End Sub

    Private Sub DuplicateTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DuplicateTabToolStripMenuItem.Click
        Dim pondWindow As New Pond
        pondWindow.Show()
    End Sub
#End Region

#Region "-Edit'"
    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_UNDO, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER)
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_REDO, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER)
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_COPY, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER)
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_CUT, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER)
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_PASTE, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER)
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_DELETE, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER)
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_SELECTALL, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_DONTPROMPTUSER)
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        AxWebBrowser1.ExecWB(SHDocVw.OLECMDID.OLECMDID_FIND, SHDocVw.OLECMDEXECOPT.OLECMDEXECOPT_PROMPTUSER)
    End Sub
#End Region

#Region "-View'"
    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        mainMenu.Visible = MenuToolStripMenuItem.Checked
    End Sub
#End Region

#Region "-History'"
    Private Sub ShowAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAllToolStripMenuItem.Click
        History.Show()
    End Sub
#End Region

#Region "-Toolz'"
    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Options.Show()
    End Sub
    '--Foundation of Homepage'
    Private Sub PondMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWebBrowser1.Navigate(My.Settings.Homepage)
    End Sub

    Private Sub AxWebBrowser1_Enter(sender As Object, e As EventArgs) Handles AxWebBrowser1.Enter

    End Sub
#End Region

#Region "Bookmarkz"
    Private Sub ShowAllBookmarksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAllBookmarksToolStripMenuItem.Click
        Bookmarkz.Show()
    End Sub

    Private Sub BookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BookToolStripMenuItem.Click
        ' My.Settings.Bookmarkz.Add(AxWebBrowser1.LocationURL.
    End Sub

    Private Sub AddCustomBookmarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCustomBookmarkToolStripMenuItem.Click
        bookmarkzAdd.ShowDialog()
        bookmarkzAdd.pondBookText.Text = AxWebBrowser1.LocationURL
    End Sub
#End Region

#Region "-Help"
    Private Sub AboutPondToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutPondToolStripMenuItem.Click
        About_Pond.Show()
    End Sub
#End Region


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Not My.Settings.Bookmarkz.Count = 0 Then
            Dim p2 As New Integer
            If Not pondBook.DropDownItems.Count = My.Settings.Bookmarkz.Count Then
                pondBook.DropDownItems.Clear()
                Do Until p2 = My.Settings.Bookmarkz.Count
                    Dim bmenu As New ToolStripMenuItem
                    bmenu.Text = My.Settings.Bookmarkz(p2)
                    AddHandler bmenu.Click, AddressOf BclickToolStripMenuItem_Click
                    pondBook.DropDownItems.Add(bmenu)
                    p2 += 1
                Loop
            End If
        End If
    End Sub
    Private Sub BclickToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AxWebBrowser1.Navigate(sender.text)
    End Sub

End Class