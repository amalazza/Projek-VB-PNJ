
Imports MySql.Data.MySqlClient
Public Class SeatManage
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable



    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click

        If matchid.Text = "" Or tribune_name.Text = "" Or gate.Text = "" Or capacity.Text = "" Or price.Text = "" Then
            MessageBox.Show("Please Fill All Field To Insert", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString =
            "server=localhost;userid=root;database=goldenstadium"
            Dim READER As MySqlDataReader

            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "insert into goldenstadium.seat (matchid, tribune_name, gate, capacity, price) values ('" & matchid.Text & "','" & tribune_name.Text & "','" & gate.Text & "','" & capacity.Text & "','" & price.Text & "')"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MessageBox.Show("Seat Data Saved", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MySqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try
        End If
        Load_Table()

    End Sub

    Private Sub UpdateS_Click(sender As Object, e As EventArgs) Handles UpdateS.Click
        If matchid.Text = "" Or tribune_name.Text = "" Or gate.Text = "" Or capacity.Text = "" Or price.Text = "" Then
            MessageBox.Show("Please Fill All Field To Update", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString =
            "server=localhost;userid=root;database=goldenstadium"
            Dim READER As MySqlDataReader

            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "update goldenstadium.seat Set price='" & price.Text & "',tribune_name='" & tribune_name.Text & "',gate='" & gate.Text & "',capacity='" & capacity.Text & "' where matchid='" & matchid.Text & "'"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MessageBox.Show("Seat Data Updated", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MySqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()

            End Try
        End If
        Load_Table()
    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label11.BackColor = Color.Transparent
        Load_Table()
    End Sub

    Private Sub Load_Table()
        dbDataSet.Clear()
        TableEmp.DataSource = dbDataSet
        TableEmp.DataSource = Nothing

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost;userid=root;database=goldenstadium"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "select * from goldenstadium.seat"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            TableEmp.DataSource = bSource
            SDA.Update(dbDataSet)

            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub


    Private Sub TableEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableEmp.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = TableEmp.Rows(e.RowIndex)

            matchid.Text = row.Cells("matchid").Value.ToString
            tribune_name.Text = row.Cells("tribune_name").Value.ToString
            gate.Text = row.Cells("gate").Value.ToString
            capacity.Text = row.Cells("capacity").Value.ToString
            price.Text = row.Cells("price").Value.ToString
        End If
    End Sub

    Private Sub Searchh_TextChanged(sender As Object, e As EventArgs) Handles Searchh.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("Convert(matchid, 'System.String') LIKE '%{0}%' OR Convert(tribune_name, 'System.String') LIKE '%{0}%' OR Convert(gate, 'System.String') LIKE '%{0}%' OR Convert(capacity, 'System.String') LIKE '%{0}%'", Searchh.Text)
        TableEmp.DataSource = DV
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Admin.Show()
        Me.Hide()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If matchid.Text = "" Then
            MessageBox.Show("Please Fill Match Id To Delete", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString =
            "server=localhost;userid=root;database=goldenstadium"
            Dim READER As MySqlDataReader

            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "Delete from goldenstadium.seat where matchid='" & matchid.Text & "'"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MessageBox.Show("Seat Data Deleted", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MySqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try
        End If
        Load_Table()
    End Sub

    Private Sub TableEmp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableEmp.CellContentClick

    End Sub
End Class