Public Class SEARCH
    Dim connect As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim db As OleDb.OleDbDataAdapter
    Dim dc As OleDb.OleDbDataAdapter
    Dim sql, sql2, product, invoice As String
    Dim RDATE As String
    Dim RCat As String
    Dim RKey As String
    Dim path, pathretrieval As String
    Private Sub Form3_Load(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles MyBase.Load

        connect.ConnectionString = "Provider=Microsoft.ace.OLEDB.12.0; data source = |datadirectory|\research.accdb"

        connect.Open()
        sql = "select * from PictureFile"
        Dim da As New OleDb.OleDbDataAdapter(sql, connect)
        da.Fill(ds, "PictureFile")
        Dim count As Integer
        count = ds.Tables("PictureFile").Rows.Count
        For i As Integer = 0 To count - 1
            ComboBox1.Items.Add(ds.Tables("PictureFile").Rows(i).Item(0))
        Next
        connect.Close()

        TextBox3.Visible = False
        ComboBox1.Visible = False

    End Sub

    Private Sub btncancel_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles btncancel.Click
        Me.Hide()
        STUDENT.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs)
        connect.Open()
        ds.Clear()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM tblresearch", connect)
        da.Fill(ds, "tblresearch")
        Dim dv As New DataView(ds.Tables("tblresearch"))
        Dim dv1 As New DataView(ds.Tables("tblresearch"))
        DataGridView1.DataSource = dv
        connect.Close()
    End Sub

    Private Sub btnsearch_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles btnsearch.Click
        RCat = TextBox2.Text
        connect.Open()
        ds.Clear()
        db = New OleDb.OleDbDataAdapter("SELECT * FROM tblresearch", connect)
        db.Fill(ds, "tblresearch")
        Dim dv1 As New DataView(ds.Tables("tblresearch"))
        ' the filtering in dv.rowfilter is considered a string
        ' any position
        dv1.RowFilter = "Research_Category LIKE '%" & RCat & "%'"
        ' end
        dv1.RowFilter = "Research_Category LIKE'%" & RCat & "'"
        'beginning
        dv1.RowFilter = "Research_Category LIKE '" & RCat & "%'"
        DataGridView1.DataSource = dv1
        connect.Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox3.Text = DataGridView1.Item(6, i).Value
        ComboBox1.Text = DataGridView1.Item(1, i).Value

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles TextBox3.TextChanged
        WebBrowser1.Navigate(TextBox3.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Button1.Click
        RDATE = TextBox1.Text
        connect.Open()
        ds.Clear()
        db = New OleDb.OleDbDataAdapter("SELECT * FROM tblresearch", connect)
        db.Fill(ds, "tblresearch")
        Dim dv1 As New DataView(ds.Tables("tblresearch"))
        ' the filtering in dv.rowfilter is considered a string
        ' any position
        dv1.RowFilter = "Research_Date_Published LIKE '%" & RDATE & "%'"
        ' end
        dv1.RowFilter = "Research_Date_Published LIKE'%" & RDATE & "'"
        'beginning
        dv1.RowFilter = "Research_Date_Published LIKE '" & RDATE & "%'"
        DataGridView1.DataSource = dv1
        connect.Close()
        

    End Sub
    Private Sub Button2_Click_1(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Button2.Click
        RKey = TextBox4.Text
        connect.Open()
        ds.Clear()
        db = New OleDb.OleDbDataAdapter("SELECT * FROM tblresearch", connect)
        db.Fill(ds, "tblresearch")
        Dim dv1 As New DataView(ds.Tables("tblresearch"))
        ' the filtering in dv.rowfilter is considered a string
        ' any position
        dv1.RowFilter = "Research_Keywords LIKE '%" & RKey & "%'"
        ' end
        'dv1.RowFilter = "Research_Keywords LIKE'%" & RKey & "'"
        'beginning
        'dv1.RowFilter = "Research_Keywords LIKE '" & RKey & "%'"
        DataGridView1.DataSource = dv1
        connect.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Button3.Click
        connect.Open()
        ds.Clear()
        da = New OleDb.OleDbDataAdapter("SELECT * FROM tblresearch", connect)
        da.Fill(ds, "tblresearch")
        Dim dv As New DataView(ds.Tables("tblresearch"))
        DataGridView1.DataSource = dv
        connect.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles Button4.Click
        TextBox4.Clear()
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As SYSTEM.Object, ByVal e As SYSTEM.EventArgs) Handles ComboBox1.SelectedIndexChanged
        connect.Open()
        Dim cmd As OleDb.OleDbCommand = New OleDb.OleDbCommand("Select * from PictureFile where RESEARCHTITLE='" & ComboBox1.SelectedItem & "'", connect)
        Dim sdr As OleDb.OleDbDataReader = cmd.ExecuteReader
        If sdr.HasRows = True Then
            While sdr.Read
                pathretrieval = sdr(1)
                PictureBox2.Image = Image.FromFile(pathretrieval)
            End While
        End If
        connect.Close()
    End Sub
End Class