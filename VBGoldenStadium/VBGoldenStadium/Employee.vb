Imports MySql.Data.MySqlClient
Public Class Employee
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click

        If Names.Text = "" Or Gender.Text = "" Or Address.Text = "" Or Phone.Text = "" Or Position.Text = "" Or Salary.Text = "" Or Username.Text = "" Or Password.Text = "" Then
            MessageBox.Show("Please Fill All Field To Insert", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString =
            "server=localhost;userid=root;database=goldenstadium"
            Dim READER As MySqlDataReader

            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "insert into goldenstadium.employee (name, Gender, Address, phonenumber, Position, Salary, Username, Password) values ('" & Names.Text & "','" & Gender.Text & "','" & Address.Text & "','" & Phone.Text & "','" & Position.Text & "','" & Salary.Text & "','" & Username.Text & "','" & Password.Text & "')"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MessageBox.Show("Employee Data Saved", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MySqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try
        End If
        Load_Table()

    End Sub


    Private Sub Phone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Phone.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


    Private Sub Salary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Salary.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub



    Private Sub UpdateE_Click(sender As Object, e As EventArgs) Handles UpdateE.Click
        If Address.Text = "" Or Phone.Text = "" Or Position.Text = "" Or Salary.Text = "" Or Username.Text = "" Or Password.Text = "" Then
            MessageBox.Show("Please Fill All Field To Update", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString =
            "server=localhost;userid=root;database=goldenstadium"
            Dim READER As MySqlDataReader

            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "update goldenstadium.employee set address='" & Address.Text & "',phonenumber='" & Phone.Text & "',position='" & Position.Text & "',salary='" & Salary.Text & "',username='" & Username.Text & "',password='" & Password.Text & "' where empid='" & Id.Text & "'"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MessageBox.Show("Employee Data Updated", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MySqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()

            End Try
        End If
        Load_Table()
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If Id.Text = "" Then
            MessageBox.Show("Please Fill Employee Id To Delete", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString =
            "server=localhost;userid=root;database=goldenstadium"
            Dim READER As MySqlDataReader

            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "Delete from goldenstadium.employee where empid='" & Id.Text & "'"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                MessageBox.Show("Employee Data Deleted", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Query = "select * from goldenstadium.employee"
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

            Id.Text = row.Cells("empid").Value.ToString
            Names.Text = row.Cells("name").Value.ToString
            Gender.Text = row.Cells("gender").Value.ToString
            Address.Text = row.Cells("address").Value.ToString
            Phone.Text = row.Cells("phonenumber").Value.ToString
            Position.Text = row.Cells("position").Value.ToString
            Salary.Text = row.Cells("salary").Value.ToString
            Username.Text = row.Cells("username").Value.ToString
            Password.Text = row.Cells("password").Value.ToString
        End If
    End Sub



    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("name Like '%{0}%' OR gender Like '%{0}%' OR address Like '%{0}%' OR phonenumber Like '%{0}%' OR position Like '%{0}%' OR username Like '%{0}%' OR password Like '%{0}%'", Search.Text)
        TableEmp.DataSource = DV
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Admin.Show()
        Hide()
    End Sub

    Private Sub TableEmp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableEmp.CellContentClick

    End Sub
End Class