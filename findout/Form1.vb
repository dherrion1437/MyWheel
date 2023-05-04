Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Dim number As Integer
    Dim random As Decimal
    Dim number2 As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Picwheel.Visible = True
        Timermain.Enabled = True
        random = Int((Rnd() * 7 + 1))
        Button1.Text = random
        number = 0
        number2 = 0

    End Sub

    Private Sub Timermain_Tick(sender As Object, e As EventArgs) Handles Timermain.Tick
        'Number += 1
        number2 += 1

        If number2 = 5 Then
            Picwheel.Image = My.Resources.og1
        ElseIf number2 = 10 Then
            Picwheel.Image = My.Resources._2
        ElseIf number2 = 15 Then
            Picwheel.Image = My.Resources._3
        ElseIf number2 = 20 Then
            Picwheel.Image = My.Resources._4
        ElseIf number2 = 25 Then
            Picwheel.Image = My.Resources._5
        ElseIf number2 = 30 Then
            Picwheel.Image = My.Resources._6
        ElseIf number2 = 35 Then
            Picwheel.Image = My.Resources._7
        ElseIf number2 = 40 Then
            Picwheel.Image = My.Resources._8
        ElseIf number2 = 45 Then
            Picwheel.Image = My.Resources._9
        ElseIf number2 = 50 Then
            Picwheel.Image = My.Resources._10
        ElseIf number2 = 55 Then
            Picwheel.Image = My.Resources._11
        ElseIf number2 = 60 Then
            Picwheel.Image = My.Resources._12
        ElseIf number2 = 65 Then
            Picwheel.Image = My.Resources._13
        ElseIf number2 = 70 Then
            Picwheel.Image = My.Resources._14
        ElseIf number2 = 75 Then
            Picwheel.Image = My.Resources._15
        ElseIf number2 = 80 Then
            Picwheel.Image = My.Resources._16
        ElseIf number2 = 85 Then
            Picwheel.Image = My.Resources._17
        ElseIf number2 = 90 Then
            Picwheel.Image = My.Resources._18
        ElseIf number2 = 95 Then
            Picwheel.Image = My.Resources._19
        ElseIf number2 = 100 Then
            Picwheel.Image = My.Resources._20
        ElseIf number2 = 105 Then
            Picwheel.Image = My.Resources._21
        ElseIf number2 = 110 Then
            Picwheel.Image = My.Resources._21
        ElseIf number2 = 115 Then
            Picwheel.Image = My.Resources._23
        ElseIf number2 = 120 Then
            Picwheel.Image = My.Resources._24
        ElseIf number2 = 125 Then
            Picwheel.Image = My.Resources._25
            number += 1
            If number <> 25 Then
                number2 = 0
            End If
        End If





    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Timermain.Enabled = False
        Button1.Text = "Spin"
    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

    End Sub
End Class
