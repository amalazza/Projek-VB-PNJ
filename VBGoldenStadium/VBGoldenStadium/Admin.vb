Public Class Admin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Employee.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MatchManage.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Transaction.Show()
        Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Hide()
    End Sub

    Private Sub Seat_Click(sender As Object, e As EventArgs) Handles Seat.Click
        SeatManage.Show()
        Hide()
    End Sub
End Class