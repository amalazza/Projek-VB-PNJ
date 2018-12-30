Imports MySql.Data.MySqlClient
Public Class BuyTicket
    Dim MySqlConn As MySqlConnection
    Private Sub BuyTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Enabled = False
        txtTime.Enabled = False
        txtGate.Enabled = False
        txtTotPrice.Enabled = False
        lblHargaTiketSatuan.Text = "Rp " + "0"
        lblSeatLeft.Text = "0"
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
End Class