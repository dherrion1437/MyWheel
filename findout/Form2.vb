Public Class Form2
    Private Sub BtnA_Click(sender As Object, e As EventArgs) Handles BtnA.Click
        BtnA.Enabled = False
        BtnA.BackColor = Color.Green


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles BtnB.Click
        BtnB.BackColor = Color.Green
    End Sub
End Class