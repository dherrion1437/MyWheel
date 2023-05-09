
Option Explicit On
Option Infer Off
Imports System.Diagnostics.Eventing.Reader

Public Class Form1
    Dim value As Integer
    Dim number As Integer
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        If Number = Value Then
            EndImage()
            Number = 0
            Timer.Interval = 30
            Timer.Enabled = False
            Exit Sub
        End If
        number += 1

        If number Mod 25 = 0 Then
            Picwheel.Image = My.Resources.og1
            SpinWheel()
        ElseIf number Mod 25 = 1 Then
            Picwheel.Image = My.Resources._2
            SpinWheel()
        ElseIf number Mod 25 = 2 Then
            Picwheel.Image = My.Resources._3
            SpinWheel()
        ElseIf number Mod 25 = 3 Then
            Picwheel.Image = My.Resources._4
            SpinWheel()
        ElseIf number Mod 25 = 4 Then
            Picwheel.Image = My.Resources._5
            SpinWheel()
        ElseIf number Mod 25 = 5 Then
            Picwheel.Image = My.Resources._6
            SpinWheel()
        ElseIf number Mod 25 = 6 Then
            Picwheel.Image = My.Resources._7
            SpinWheel()
        ElseIf number Mod 25 = 7 Then
            Picwheel.Image = My.Resources._8
            SpinWheel()
        ElseIf number Mod 25 = 8 Then
            Picwheel.Image = My.Resources._9
            SpinWheel()
        ElseIf number Mod 25 = 9 Then
            Picwheel.Image = My.Resources._10
            SpinWheel()
        ElseIf number Mod 25 = 10 Then
            Picwheel.Image = My.Resources._11
            SpinWheel()
        ElseIf number Mod 25 = 11 Then
            Picwheel.Image = My.Resources._12
            SpinWheel()
        ElseIf number Mod 25 = 12 Then
            Picwheel.Image = My.Resources._13
            SpinWheel()
        ElseIf number Mod 25 = 13 Then
            Picwheel.Image = My.Resources._14
            SpinWheel()
        ElseIf number Mod 25 = 14 Then
            Picwheel.Image = My.Resources._15
            SpinWheel()
        ElseIf number Mod 25 = 15 Then
            Picwheel.Image = My.Resources._16
            SpinWheel()
        ElseIf number Mod 25 = 16 Then
            Picwheel.Image = My.Resources._17
            SpinWheel()
        ElseIf number Mod 25 = 17 Then
            Picwheel.Image = My.Resources._18
            SpinWheel()
        ElseIf number Mod 25 = 18 Then
            Picwheel.Image = My.Resources._19
            SpinWheel()
        ElseIf number Mod 25 = 19 Then
            Picwheel.Image = My.Resources._20
            SpinWheel()
        ElseIf number Mod 25 = 20 Then
            Picwheel.Image = My.Resources._21
            SpinWheel()
        ElseIf number Mod 25 = 21 Then
            Picwheel.Image = My.Resources._22
            SpinWheel()
        ElseIf number Mod 25 = 22 Then
            Picwheel.Image = My.Resources._23
            SpinWheel()
        ElseIf number Mod 25 = 23 Then
            Picwheel.Image = My.Resources._24
            SpinWheel()
        ElseIf number Mod 25 = 24 Then
            Picwheel.Image = My.Resources._25
            SpinWheel()
        End If

    End Sub

    Private Sub SpinWheel()
        If number = Int(value / 2) Then
            Timer.Interval = 50
        ElseIf number = Int(value / 1.5) Then
            Timer.Interval = 100
        ElseIf number = Int(value / 1.25) Then
            Timer.Interval = 200
        ElseIf number = Int(value / 1.1) Then
            Timer.Interval = 350
        ElseIf number = value - 1 Then
            Timer.Interval = 1000
        End If
    End Sub

    Private Sub EndImage()
        If number Mod 25 = 0 Then
            Picwheel.Image = My.Resources.og1
            lblbox.Text = "BANKRUPT"
        ElseIf number Mod 25 = 1 Then
            Picwheel.Image = My.Resources._2
            lblbox.Text = "$1000"
        ElseIf number Mod 25 = 2 Then
            Picwheel.Image = My.Resources._3
            lblbox.Text = "$2000"
        ElseIf number Mod 25 = 3 Then
            Picwheel.Image = My.Resources._4
            lblbox.Text = "$1000"
        ElseIf number Mod 25 = 4 Then
            Picwheel.Image = My.Resources._5
            lblbox.Text = "$5000"
        ElseIf number Mod 25 = 5 Then
            Picwheel.Image = My.Resources._6
            lblbox.Text = "$1000"
        ElseIf number Mod 25 = 6 Then
            Picwheel.Image = My.Resources._7
            lblbox.Text = "SKIP"
        ElseIf number Mod 25 = 7 Then
            Picwheel.Image = My.Resources._8
            lblbox.Text = "$2000"
        ElseIf number Mod 25 = 8 Then
            Picwheel.Image = My.Resources._9
            lblbox.Text = "$1000"
        ElseIf number Mod 25 = 9 Then
            Picwheel.Image = My.Resources._10
            lblbox.Text = "$1000"
        ElseIf number Mod 25 = 10 Then
            Picwheel.Image = My.Resources._11
            lblbox.Text = "$2000"
        ElseIf number Mod 25 = 11 Then
            Picwheel.Image = My.Resources._12
            lblbox.Text = "BANKRUPT"
        ElseIf number Mod 25 = 12 Then
            Picwheel.Image = My.Resources._13
            lblbox.Text = "$1000"
        ElseIf number Mod 25 = 13 Then
            Picwheel.Image = My.Resources._14
            lblbox.Text = "$1000"
        ElseIf number Mod 25 = 14 Then
            Picwheel.Image = My.Resources._15
            lblbox.Text = "10000"
        ElseIf number Mod 25 = 15 Then
            Picwheel.Image = My.Resources._16
            lblbox.Text = "5000"
        ElseIf number Mod 25 = 16 Then
            Picwheel.Image = My.Resources._17
            lblbox.Text = "SKIP"
        ElseIf number Mod 25 = 17 Then
            Picwheel.Image = My.Resources._18
            lblbox.Text = "$2000"
        ElseIf number Mod 25 = 18 Then
            Picwheel.Image = My.Resources._19
            lblbox.Text = "$5000"

        ElseIf number Mod 25 = 19 Then
            Picwheel.Image = My.Resources._20
            lblbox.Text = "$2000"
        ElseIf number Mod 25 = 20 Then
            Picwheel.Image = My.Resources._21
            lblbox.Text = "$1000"
        ElseIf number Mod 25 = 21 Then
            Picwheel.Image = My.Resources._22
            lblbox.Text = "$1000"
        ElseIf number Mod 25 = 22 Then
            Picwheel.Image = My.Resources._23
            lblbox.Text = "$2000"
        ElseIf number Mod 25 = 23 Then
            Picwheel.Image = My.Resources._24
            lblbox.Text = "SKIP"
        ElseIf number Mod 25 = 24 Then
            Picwheel.Image = My.Resources._25
            lblbox.Text = "$1000"
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lblbox.Text = String.Empty
        number = 0
        Timer.Interval = 30
        Randomize()
        value = Int((Rnd() * 50) + 25)
        Timer.Enabled = True
    End Sub

    Private Sub Btnexit_Click(sender As Object, e As EventArgs) Handles Btnexit.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btnguess_Click(sender As Object, e As EventArgs) Handles Btnguess.Click
        Me.Visible = False
        Form2.Visible = True
    End Sub

    Private Sub BtnA_Click(sender As Object, e As EventArgs) Handles BtnA.Click

    End Sub
End Class