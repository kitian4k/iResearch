Public Class TEACHERSTUDENT

    Private Sub btnteacher_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles btnteacher.Click
        Me.Hide()
        LOGIN.Show()
    End Sub

    Private Sub btnstudent_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles btnstudent.Click
        Me.Hide()
        STUDENT.Show()
    End Sub

    Private Sub btnexit_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles btnexit.Click
        Me.Close()
        WELCOME.Show()
    End Sub
End Class