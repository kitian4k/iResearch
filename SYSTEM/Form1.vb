Public Class LOGIN
    Dim connect As New OleDb.OleDbConnection
    Dim ds As New DataSet
    ' Dim da as oleDb.oleDbDataAdapter
    Dim sql, accesslevel As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider=Microsoft.ace.OLEDB.12.0;data source = |datadirectory|/login1.accdb"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Teacher" Then
            accesslevel = "Teacher"
        End If
        connect.Open()
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("Select * from tblLog where Username='" & TextBox1.Text & "' and Userpassword = '" & TextBox2.Text & "' and Accesslevel = '" & accesslevel & "'", connect)
        Dim sdr As OleDb.OleDbDataReader = cmd.ExecuteReader
        If sdr.HasRows = True Then
            accesslevel = "Teacher"
            MsgBox("Teacher")
            connect.Close()
            Me.Hide()
            TEACHER.Show()

        Else
            MsgBox("Illegal Username or Password")
            connect.Close()
        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs)

    End Sub

    Private Sub btnexit_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles btnexit.Click
        Me.Hide()
        WELCOME.Show()
    End Sub
End Class
