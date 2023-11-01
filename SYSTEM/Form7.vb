Public Class Form7
    Dim connect As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim db As OleDb.OleDbDataAdapter
    Dim dc As OleDb.OleDbDataAdapter
    Dim sql, sql2, product, invoice As String
    Dim inc As Integer
    Dim MaxRows As Integer
    

    Private Sub Form7_Load(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles MyBase.Load
        connect.ConnectionString = "Provider=Microsoft.ace.OLEDB.12.0; data source = |datadirectory|\research.accdb"

        connect.Open()
        sql = "select * from tblresearch"
        da = New OleDb.OleDbDataAdapter(sql, connect)
        da.Fill(ds, "tblresearch")
        txtnum.Text = ds.Tables("tblresearch").Rows(inc).Item(0)
        txttitle.Text = ds.Tables("tblresearch").Rows(inc).Item(1)
        txtdate.Text = ds.Tables("tblresearch").Rows(inc).Item(2)
        txtaut.Text = ds.Tables("tblresearch").Rows(inc).Item(3)
        txtkeyword.Text = ds.Tables("tblresearch").Rows(inc).Item(4)
        txtcat.Text = ds.Tables("tblresearch").Rows(inc).Item(5)
        txturl.Text = ds.Tables("tblresearch").Rows(inc).Item(6)
        MaxRows = ds.Tables("tblresearch").Rows.Count
        inc = 0
        connect.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Button2.Click
        connect.Open()
        ds.Clear()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM tblresearch", connect)
        da.Fill(ds, "tblresearch")
        Dim dv As New DataView(ds.Tables("tblresearch"))
        Dim dv1 As New DataView(ds.Tables("tblresearch"))
        DataGridView1.DataSource = dv
        connect.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Button1.Click
        Me.Hide()
        TEACHER.Show()
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

    Private Sub Edit_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Edit.Click
        connect.Open()
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM tblresearch", connect)
        sql = "Update tblresearch set Research_Title='" & txttitle.Text & "',Research_Author ='" & txtaut.Text & "',Research_Date_Published ='" & txtdate.Text & "',Research_Keywords ='" & txtdate.Text & "',Research_Category ='" & txtcat.Text & "',Research_URL='" & txturl.Text & "' where Research_Number='" & txtnum.Text & "'"
        cmd = New OleDb.OleDbCommand(sql, connect)
        cmd.ExecuteNonQuery()
        connect.Close()
        MsgBox("Updated")
    End Sub

    Private Sub Button7_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs)
        connect.Open()
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM tblresearch where Research_Number ='" & txtnum.Text & "'", connect)
        Dim sdr As OleDb.OleDbDataReader = cmd.ExecuteReader
        If (MsgBox("Are you sure you want to delete this record?", vbOKCancel) = vbOK) Then
            sql = "Delete * from tblresearch where Research_Num ='" & txtnum.Text & "'"
            cmd = New OleDb.OleDbCommand(sql, connect)
            cmd.ExecuteNonQuery()
            connect.Close()
        Else
            MsgBox("Operation Cancelled")
            connect.Close()
            Exit Sub
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        Dim i2 As Integer
        i2 = DataGridView2.CurrentRow.Index
        TextBox1.Text = DataGridView2.Item(0, i2).Value
        TextBox2.Text = DataGridView2.Item(1, i2).Value
    End Sub

    Private Sub Button4_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Button4.Click
        connect.Open()
        ds.Clear()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM PictureFile ", connect)
        da.Fill(ds, "PictureFile")
        Dim dv As New DataView(ds.Tables("PictureFile"))
        Dim dv1 As New DataView(ds.Tables("PictureFile"))
        DataGridView2.DataSource = dv1
        connect.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs)
        connect.Open()
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("SELECT * FROM PictureFile where RESEARCHTITLE='" & TextBox1.Text & "'" & "'", connect)
        Dim sdr As OleDb.OleDbDataReader = cmd.ExecuteReader
        If (MsgBox("Are you sure you want to delete this record?", vbOKCancel) = vbOK) Then
            sql = "Delete * from PictureFile where RESEARCHTITLE='" & TextBox1.Text & "'"
            cmd = New OleDb.OleDbCommand(sql, connect)
            cmd.ExecuteNonQuery()
            connect.Close()
        Else
            MsgBox("Operation Cancelled")
            connect.Close()
            Exit Sub
        End If
    End Sub

    Private Sub txtkeyword_TextChanged(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles txtkeyword.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Label3.Click

    End Sub

    Private Sub txttitle_TextChanged(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles txttitle.TextChanged

    End Sub

    Private Sub txtnum_TextChanged(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles txtnum.TextChanged

    End Sub

    Private Sub Label4_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtcat_TextChanged(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles txtcat.TextChanged

    End Sub

    Private Sub Label6_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtaut_TextChanged(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles txtaut.TextChanged

    End Sub

    Private Sub Label7_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Label7.Click

    End Sub

    Private Sub txturl_TextChanged(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles txturl.TextChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Label8.Click

    End Sub
End Class