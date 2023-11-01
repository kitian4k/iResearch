Public Class FORAPPROVAL
    Dim path, pathretrieval As String
    Dim connect As New OleDb.OleDbConnection
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim Items As Integer
    Private Sub btnadd_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles btnadd.Click
        If txtnum.Text = "" Or txtaut.Text = "" Or txtkeyword.Text = "" Or txtdate.Text = "" Or txtcat.Text = "" Or txturl.Text = "" Or txttitle.Text = "" Then
            MsgBox("Please fill out all the fields")
        Else
            connect.Open()
            Dim cmd2 As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM tblresearch where Research_Number='" & txtnum.Text & "'", connect)
            Dim sdr As OleDb.OleDbDataReader = cmd2.ExecuteReader
            If sdr.HasRows = True Then
                MessageBox.Show("Research Number Already Exists")
                connect.Close()
            Else
                Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * tblresearch", connect)
                Sql = "insert into tblresearch values ('" & txtnum.Text & "','" & txttitle.Text & "','" & txtaut.Text & "','" & txtcat.Text & "','" & txtkeyword.Text & "','" & txtdate.Text & "', '" & txturl.Text & " ')"
                cmd = New OleDb.OleDbCommand(Sql, connect)
                cmd.ExecuteNonQuery()
                connect.Close()
                MsgBox("Save")
            End If
        End If
    End Sub

    Private Sub Form11_Load(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles MyBase.Load
        connect.ConnectionString = "provider=Microsoft.ace.oleDb.12.0;data source = |datadirectory|/research.accdb."
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtnum.Text = DataGridView1.Item(0, i).Value
        txttitle.Text = DataGridView1.Item(1, i).Value
        txtaut.Text = DataGridView1.Item(2, i).Value
        txtcat.Text = DataGridView1.Item(3, i).Value
        txtkeyword.Text = DataGridView1.Item(4, i).Value
        txtdate.Text = DataGridView1.Item(5, i).Value
        txturl.Text = DataGridView1.Item(6, i).Value
    End Sub

    Private Sub Button2_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Button2.Click
        connect.Open()
        ds.Clear()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM tblresearchapproval", connect)
        da.Fill(ds, "tblresearchapproval")
        Dim dv As New DataView(ds.Tables("tblresearchapproval"))
        DataGridView1.DataSource = dv
        connect.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Button1.Click
        Me.Hide()
        TEACHER.Show()
    End Sub

    Private Sub btnback_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs)

    End Sub

    Private Sub btnclear_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles btnclear.Click
        txttitle.Clear()
        txturl.Clear()
        txtcat.Clear()
        txtnum.Clear()
        txtaut.Clear()
        txtdate.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Button3.Click
        connect.Open()
        Dim cmd1 As OleDb.OleDbCommand = New OleDb.OleDbCommand("Select * fromtblresearchapproval", connect)
        If (MsgBox("Are you sure you want to delete this record?", vbOKCancel) = vbOK) Then
            sql = "Delete * from tblresearchapproval where Research_Number = '" & txtnum.Text & "'"
            cmd1 = New OleDb.OleDbCommand(sql, connect)
            cmd1.ExecuteNonQuery()
            connect.Close()
        Else
            MsgBox("Operation Cancelled")
            connect.Close()
        End If
    End Sub
End Class