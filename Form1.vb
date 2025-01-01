Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        For i = 1 To 10
            m(i) = Int(Rnd() * 100) + 1
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim prohozeno
        Dim konec
        Dim n As Integer

zacatek: prohozeno = 0
        For n = 1 To 9
            If m(n) > m(n + 1) Then prohozeno = 1 : konec = m(n) : m(n) = m(n + 1) : m(n + 1) = konec
        Next
        If prohozeno = 1 Then GoTo zacatek

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveFileDialog1.ShowDialog()
        FileOpen(1, SaveFileDialog1.FileName, OpenMode.Output)
        For i = 1 To 10
            Write(1, m(i))
        Next
        WriteLine(1, "konec")
        FileClose()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()

    End Sub
End Class
