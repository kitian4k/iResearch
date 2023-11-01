Public Class Googledrive
    Dim automate As Boolean

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Googledrive_Load(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("https://drive.google.com/drive/u/1/folders/1tzWSfL1CjoRpql_-q4qCt_n_b7cI7Lbt")
    End Sub

    Private Sub Button1_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Button1.Click
        WebBrowser1.Refresh()

    End Sub

    Private Sub Button3_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Button3.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub Button2_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Button2.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub Button4_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Button4.Click
        Me.Hide()
        TEACHER.Show()
    End Sub
End Class