Imports MySql.Data.MySqlClient
Public Class BuyTicket
    Dim MySqlConn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim matchid As String
    Public match As String
    Public matchdate As String
    Public tribune As String
    Public quantity As String
    Dim seatleft As Integer
    Public totprice As String
    Public empid As String
    Public Property ID As String
    Private Sub BuyTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTime.Enabled = False
        txtGate.Enabled = False
        txtTotPrice.Enabled = False
        txtEmpId.Text = ID
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost;userid=root;database=goldenstadium"

        Try
            MySqlConn.Open()
            Dim str As String
            str = "select matchh from goldenstadium.matchhh"
            cmd = New MySqlCommand(str, MySqlConn)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                Do While reader.Read
                    cboMatch.Items.Add(reader("matchh"))
                Loop
                txtEmpId.Text = ID
            Else
            End If
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub cboMatch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMatch.SelectedIndexChanged
        match = cboMatch.SelectedItem
        cboDate.Items.Clear()
        txtTime.Text = ""
        txtGate.Text = ""
        cboTribune.Items.Clear()
        lblHargaTiketSatuan.Text = ""
        lblSeatLeft.Text = ""

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost;userid=root;database=goldenstadium"

        Try
            MySqlConn.Open()
            Dim str As String
            str = "select datee from goldenstadium.matchhh where matchh = '" & match & "'"
            cmd = New MySqlCommand(str, MySqlConn)
            reader = cmd.ExecuteReader
            If reader.HasRows Then

                cboDate.Text = "--Select Date--"
                Do While reader.Read
                    cboDate.Items.Add(reader("datee"))
                Loop
            Else
            End If
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub cboDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDate.SelectedIndexChanged
        matchdate = cboDate.SelectedItem
        txtTime.Text = ""
        txtGate.Text = ""
        cboTribune.Items.Clear()
        lblHargaTiketSatuan.Text = ""
        lblSeatLeft.Text = ""

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost;userid=root;database=goldenstadium"

        Try
            MySqlConn.Open()
            Dim str As String
            str = "select * from goldenstadium.matchhh inner join goldenstadium.seat on goldenstadium.matchhh.matchid = goldenstadium.seat.matchid where matchh = '" & match & "' and datee = '" & matchdate & "'"
            cmd = New MySqlCommand(str, MySqlConn)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                Do While reader.Read
                    cboTribune.Items.Clear()
                    txtTime.Text = reader.Item("timee")
                    cboTribune.Items.Add(reader("tribune_name"))
                Loop
            Else
            End If
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub cboTribune_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTribune.SelectedIndexChanged
        tribune = cboTribune.SelectedItem


        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost;userid=root;database=goldenstadium"

        Try
            MySqlConn.Open()
            Dim str As String
            str = "select * from goldenstadium.matchhh inner join goldenstadium.seat on goldenstadium.matchhh.matchid = goldenstadium.seat.matchid where matchh = '" & match & "' and datee = '" & matchdate & "' and tribune_name = '" & tribune & "'"
            cmd = New MySqlCommand(str, MySqlConn)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    lblHargaTiketSatuan.Text = reader.Item("price")
                    txtGate.Text = reader.Item("gate")
                    lblSeatLeft.Text = reader.Item("capacity").ToString
                End While
            Else
            End If
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost;userid=root;database=goldenstadium"

        Try
            MySqlConn.Open()
            Dim str As String
            str = "select * from goldenstadium.matchhh inner join goldenstadium.seat on goldenstadium.matchhh.matchid = goldenstadium.seat.matchid where matchh = '" & match & "' and datee = '" & matchdate & "' and tribune_name = '" & tribune & "'"
            cmd = New MySqlCommand(str, MySqlConn)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    lblSeatLeft.Text = reader.Item("capacity").ToString
                End While
            Else
            End If
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try

        If txtQuantity.Text = "" Then
            MessageBox.Show("Please input the Quantity!")
        ElseIf Integer.Parse(txtQuantity.Text) > Integer.Parse(lblSeatLeft.Text) Then
            MessageBox.Show("Only " & lblSeatLeft.Text & " seats left!")
        Else
            seatleft = Integer.Parse(lblSeatLeft.Text) - Integer.Parse(txtQuantity.Text)
            lblSeatLeft.Text = seatleft
            txtTotPrice.Text = (Integer.Parse(txtQuantity.Text) * Integer.Parse(lblHargaTiketSatuan.Text)).ToString
        End If
    End Sub

    Private Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click
        empid = txtEmpId.Text
        totprice = txtTotPrice.Text
        quantity = txtQuantity.Text
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString =
        "server=localhost;userid=root;database=goldenstadium"

        Try
            MySqlConn.Open()
            Dim str As String
            str = "select matchid from goldenstadium.matchhh where matchh = '" & match & "' and datee = '" & matchdate & "'"
            cmd = New MySqlCommand(str, MySqlConn)
            reader = cmd.ExecuteReader
            If reader.HasRows Then
                While reader.Read
                    matchid = reader.Item("matchid")
                End While
            Else
            End If
            MySqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()
        End Try

        If matchid = "" Or empid = "" Or txtQuantity.Text = "" Or totprice = "" Then
            MessageBox.Show("Please Complete the Form!")
        Else
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString =
        "server=localhost;userid=root;database=goldenstadium"

            Try
                MySqlConn.Open()
                Dim str As String
                str = "insert into goldenstadium.transac (empid, matchid, quantity, total_price) values ('" & empid & "','" & matchid & "','" & quantity & "','" & totprice & "')"
                cmd = New MySqlCommand(str, MySqlConn)
                reader = cmd.ExecuteReader
                MessageBox.Show("Seat Data Saved", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
                MySqlConn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try

            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString =
            "server=localhost;userid=root;database=goldenstadium"

            Try
                MySqlConn.Open()
                Dim str As String
                str = "update goldenstadium.seat set capacity = '" & lblSeatLeft.Text & "' where matchid = '" & matchid & "' and tribune_name = '" & tribune & "'"
                cmd = New MySqlCommand(str, MySqlConn)
                reader = cmd.ExecuteReader
                MySqlConn.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            Finally
                MySqlConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class