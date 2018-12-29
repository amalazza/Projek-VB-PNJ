
Imports MySql.Data.MySqlClient
Public Class Transaction
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

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
            Query = "SELECT transacid, employee.name, matchhh.matchh, matchhh.datee, matchhh.timee, seat.tribune_name, seat.gate, seat.capacity, total_price FROM goldenstadium.transac INNER JOIN employee ON employee.empid = transac.empid INNER JOIN seat ON seat.matchid = transac.matchid INNER JOIN matchhh ON matchhh.matchid = transac.matchid"
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


    Private Sub TableEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.TableEmp.Rows(e.RowIndex)

            transacidd.Text = row.Cells("transacid").Value.ToString
            e_name.Text = row.Cells("name").Value.ToString
            matchh.Text = row.Cells("matchh").Value.ToString
            datee.Text = row.Cells("datee").Value.ToString
            timee.Text = row.Cells("timee").Value.ToString
            tribune_name.Text = row.Cells("tribune_name").Value.ToString
            gate.Text = row.Cells("gate").Value.ToString
            quantity.Text = row.Cells("capacity").Value.ToString
            total_price.Text = row.Cells("total_price").Value.ToString


        End If
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs)
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("transacid Like '%{0}%' OR name Like '%{0}%' OR matchh Like '%{0}%' OR datee Like '%{0}%' OR timee Like '%{0}%' OR tribune_name Like '%{0}%' OR gate Like '%{0}%' OR capacity Like '%{0}%' OR total_price Like '%{0}%'", Search.Text)
        TableEmp.DataSource = DV
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Admin.Show()
        Me.Hide()
    End Sub

End Class