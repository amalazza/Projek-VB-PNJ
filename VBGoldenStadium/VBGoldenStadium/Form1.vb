Imports MySql.Data.MySqlClient
Public Class Form1
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
            "server=localhost;userid=root;database=goldenstadium"


        Try
            MySqlConn.Open()
            MessageBox.Show("Connection Succesful")
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

        If TBUsername.Text = "" Or TBPassword.Text = "" Then
            MessageBox.Show("Please Fill UserName and Password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString =
            "server=localhost;userid=root;database=goldenstadium"
            Dim READER As MySqlDataReader

            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "select * from goldenstadium.employee where username='" & TBUsername.Text & "' and password='" & TBPassword.Text & "'"
                COMMAND = New MySqlCommand(Query, MySqlConn)
                READER = COMMAND.ExecuteReader
                Dim count As Integer
                count = 0
                While READER.Read
                    count = count + 1

                End While

                If count = 1 Then
                    Dim usertype = READER.GetString("position")
                    If usertype = "Admin" Then
                        ID.Text = READER.GetString("empid")
                        MessageBox.Show("Login Admin Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Admin.Show()
                        Hide()
                        TBUsername.Clear()
                        TBPassword.Clear()
                    Else
                        ID.Text = READER.GetString("empid")
                        MessageBox.Show("Login Employee Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Hide()
                        Dim OBJ As New BuyTicket
                        OBJ.ID = ID.Text
                        OBJ.Show()
                    End If

                ElseIf count > 1 Then
                    MessageBox.Show("Username and Password Duplicate", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    MessageBox.Show("Username or Password False", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

                MySqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                MySqlConn.Dispose()

            End Try
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = Color.Transparent
        Label2.BackColor = Color.Transparent
        Label3.BackColor = Color.Transparent
        ID.Visible = False
    End Sub
End Class
