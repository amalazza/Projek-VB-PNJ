
Imports MySql.Data.MySqlClient
Public Class MatchManage
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable



    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click

        If Names.Text = "" Or datee.Text = "" Or time.Text = "" Or tournament.Text = "" Then
            MessageBox.Show("Please Fill All Field To Insert", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString =
            "server=localhost;userid=root;database=goldenstadium"
            Dim READER As MySqlDataReader

            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "insert into goldenstadium.matchhh (matchh, datee, timee, tournament_name) values ('" & Names.Text & "','" & datee.Text & "','" & time.Text & "','" & tournament.Text & "')"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MessageBox.Show("Match Data Saved", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MySqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try
        End If
        Load_Table()

    End Sub

    Private Sub UpdateM_Click(sender As Object, e As EventArgs) Handles UpdateM.Click
        If Names.Text = "" Or datee.Text = "" Or time.Text = "" Or tournament.Text = "" Then
            MessageBox.Show("Please Fill All Field To Update", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString =
            "server=localhost;userid=root;database=goldenstadium"
            Dim READER As MySqlDataReader

            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "update goldenstadium.matchhh Set matchh='" & Names.Text & "',datee='" & datee.Text & "',timee='" & time.Text & "',tournament_name='" & tournament.Text & "' where matchid='" & Code.Text & "'"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MessageBox.Show("Match Data Updated", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Query = "select * from goldenstadium.matchhh"
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

            Code.Text = row.Cells("matchid").Value.ToString
            Names.Text = row.Cells("matchh").Value.ToString
            datee.Text = row.Cells("datee").Value.ToString
            time.Text = row.Cells("timee").Value.ToString
            tournament.Text = row.Cells("tournament_name").Value.ToString
        End If
    End Sub



    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("matchh Like '%{0}%' OR datee Like '%{0}%' OR timee Like '%{0}%' OR tournament_name Like '%{0}%'", Search.Text)
        TableEmp.DataSource = DV
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Admin.Show()
        Hide()
    End Sub


End Class