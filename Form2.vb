Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For n = 1 To 10
            Me.Chart1.Series("Series1").Points.AddXY(m(n), n)
        Next

    End Sub
End Class