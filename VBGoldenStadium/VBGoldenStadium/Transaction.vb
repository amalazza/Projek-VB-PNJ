
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
        TableEmp.DataSource = dbDataSet

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost;userid=root;database=goldenstadium"
        Dim SDA As New MySqlDataAdapter

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT transacid, employee.name, matchhh.matchh, matchhh.datee, matchhh.timee, seat.tribune_name, seat.gate, seat.capacity, total_price FROM goldenstadium.transac INNER JOIN employee ON employee.empid = transac.empid INNER JOIN seat ON seat.matchid = transac.matchid INNER JOIN matchhh ON matchhh.matchid = transac.matchid"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            TableEmp.DataSource = dbDataSet

            MySqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub



    Private Sub TableEmp_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles TableEmp.CellMouseClick

        If e.RowIndex >= 0 Then

            transacidd.Text = TableEmp.Rows(e.RowIndex).Cells(0).Value
            e_namee.Text = TableEmp.Rows(e.RowIndex).Cells(1).Value
            matchhh.Text = TableEmp.Rows(e.RowIndex).Cells(2).Value
            dateee.Text = TableEmp.Rows(e.RowIndex).Cells(3).Value
            timeee.Text = TableEmp.Rows(e.RowIndex).Cells(4).Value
            tribune_namee.Text = TableEmp.Rows(e.RowIndex).Cells(5).Value
            gatee.Text = TableEmp.Rows(e.RowIndex).Cells(6).Value
            quantityy.Text = TableEmp.Rows(e.RowIndex).Cells(7).Value
            total_pricee.Text = TableEmp.Rows(e.RowIndex).Cells(8).Value

        End If
    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs)
        TableEmp.ClearSelection()
        For Each row As DataGridViewRow In TableEmp.Rows
            For Each cell As DataGridViewCell In row.Cells

                If cell.Value.StartsWith(Search.Text, StringComparison.InvariantCultureIgnoreCase) Then
                    cell.Selected = True
                    TableEmp.CurrentCell = TableEmp.SelectedCells(0)
                    'Exit For

                End If

            Next
        Next

        TableEmp.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Admin.Show()
        Me.Hide()
    End Sub

End Class