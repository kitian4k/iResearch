Public Class APPROVAL
    Dim path, pathretrieval As String
    Dim connect As New OleDb.OleDbConnection
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim Items As Integer
    Private Sub Form10_Load(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles MyBase.Load
        connect.ConnectionString = "provider=Microsoft.ace.oleDb.12.0;data source = |datadirectory|/research.accdb."
    End Sub

    Private Sub btnadd_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles btnadd.Click
        If txttitle.Text = "" Then
            MsgBox("Research Title is empty")
        End If

        If txtcat.Text = "" Then
            MsgBox("Research Category is empty")
        End If

        If txtnum.Text = "" Then
            MsgBox("Number is empty")
        End If
        If txtaut.Text = "" Then
            MsgBox("Author(s) info is empty")
        End If
        If txtdate.Text = "" Then
            MsgBox("Date Published is empty")
        End If
        If txtkeyword.Text = "" Then
            MsgBox("URL is empty")
        End If

        If txturl.Text = "" Then
            MsgBox("URL is empty")
        End If

        If txtnum.Text = "" Or txtaut.Text = "" Or txtkeyword.Text = "" Or txtdate.Text = "" Or txtcat.Text = "" Or txturl.Text = "" Or txttitle.Text = "" Then
            MsgBox("Please fill out all the fields")
        Else
            connect.Open()
            Dim cmd2 As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM tblresearchapproval where Research_Number='" & txtnum.Text & "'", connect)
            Dim sdr As OleDb.OleDbDataReader = cmd2.ExecuteReader
            If sdr.HasRows = True Then
                MessageBox.Show("Research Number Already Exists")
                connect.Close()
            Else
                Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * tblresearchapproval", connect)
                sql = "insert into tblresearchapproval values ('" & txtnum.Text & "','" & txttitle.Text & "','" & txtaut.Text & "','" & txtcat.Text & "','" & txtkeyword.Text & "','" & txtdate.Text & "', '" & txturl.Text & " ')"
                cmd = New OleDb.OleDbCommand(Sql, connect)
                cmd.ExecuteNonQuery()
                connect.Close()
                MsgBox("Save")
            End If
        End If

    End Sub

    Private Sub btnclear_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles btnclear.Click

    End Sub

    Private Sub btnback_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles btnback.Click
        Me.Hide()
        STUDENT.Show()
    End Sub
End Class