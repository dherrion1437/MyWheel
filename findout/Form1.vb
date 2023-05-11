
Option Explicit On
Option Infer Off
Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports LanguageExt.ClassInstances.Pred

Public Class Form1
    Public strFileName As String
    Public Letters As Char
    Dim strShortName As String
    Dim Phrase As String
    Dim Dash As String
    Dim value As Integer
    Dim number As Integer
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick

        If number = value Then
            EndImage()
            number = 0
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

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Btnspin.Click
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
        lblPhrase.Visible = False
        Txtsolve.Visible = False
        BtnA.Visible = False
        BtnB.Visible = False
        BtnC.Visible = False
        BtnD.Visible = False
        btnE.Visible = False
        BtnF.Visible = False
        BtnG.Visible = False
        BtnH.Visible = False
        BtnI.Visible = False
        btnJ.Visible = False
        Btnk.Visible = False
        BtnL.Visible = False
        btnm.Visible = False
        btnn.Visible = False
        Btno.Visible = False
        Btnp.Visible = False
        Btnq.Visible = False
        Btnr.Visible = False
        Btns.Visible = False
        Btnt.Visible = False
        Btnu.Visible = False
        Btnv.Visible = False
        Btnw.Visible = False
        Btnx.Visible = False
        Btny.Visible = False
        btnz.Visible = False
        Btnsolve.Visible = False
    End Sub

    Private Sub Btnguess_Click(sender As Object, e As EventArgs) Handles Btnguess.Click
        Picwheel.Visible = False
        Btnspin.Visible = False
        Btnguess.Visible = False
        BtnA.Enabled = True
        BtnB.Enabled = True
        BtnC.Enabled = True
        BtnD.Enabled = True
        btnE.Enabled = True
        BtnF.Enabled = True
        BtnG.Enabled = True
        BtnH.Enabled = True
        BtnI.Enabled = True
        btnJ.Enabled = True
        Btnk.Enabled = True
        BtnL.Enabled = True
        btnm.Enabled = True
        btnn.Enabled = True
        Btno.Enabled = True
        Btnp.Enabled = True
        Btnq.Enabled = True
        Btnr.Enabled = True
        Btns.Enabled = True
        Btnt.Enabled = True
        Btnu.Enabled = True
        Btnv.Enabled = True
        Btnw.Enabled = True
        Btnx.Enabled = True
        Btny.Enabled = True
        btnz.Enabled = True
        lblPhrase.Visible = True
        Txtsolve.Visible = True
        BtnA.Visible = True
        BtnB.Visible = True
        BtnC.Visible = True
        BtnD.Visible = True
        btnE.Visible = True
        BtnF.Visible = True
        BtnG.Visible = True
        BtnH.Visible = True
        BtnI.Visible = True
        btnJ.Visible = True
        Btnk.Visible = True
        BtnL.Visible = True
        btnm.Visible = True
        btnn.Visible = True
        Btno.Visible = True
        Btnp.Visible = True
        Btnq.Visible = True
        Btnr.Visible = True
        Btns.Visible = True
        Btnt.Visible = True
        Btnu.Visible = True
        Btnv.Visible = True
        Btnw.Visible = True
        Btnx.Visible = True
        Btny.Visible = True
        btnz.Visible = True
        Btnsolve.Visible = True

    End Sub

    Private Sub BtnA_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NewGame()
        lblPhrase.Text = String.Empty
        BtnA.Enabled = True
        BtnB.Enabled = True
        BtnC.Enabled = True
        BtnD.Enabled = True
        btnE.Enabled = True
        BtnF.Enabled = True
        BtnG.Enabled = True
        BtnH.Enabled = True
        BtnI.Enabled = True
        btnJ.Enabled = True
        Btnk.Enabled = True
        BtnL.Enabled = True
        btnm.Enabled = True
        btnn.Enabled = True
        Btno.Enabled = True
        Btnp.Enabled = True
        Btnq.Enabled = True
        Btnr.Enabled = True
        Btns.Enabled = True
        Btnt.Enabled = True
        Btnu.Enabled = True
        Btnv.Enabled = True
        Btnw.Enabled = True
        Btnx.Enabled = True
        Btny.Enabled = True
        btnz.Enabled = True



    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        strFileName = String.Empty
        Dim Open As New OpenFileDialog()
        Dim myStreamReader As StreamReader
        Open.Filter = "Text [*.txt*]|*.txt|All Files [*.*]|*.*"
        Open.CheckFileExists = True
        Open.Title = "OpenFile"
        Open.ShowDialog(Me)
        Try
            strFileName = Open.FileName
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        myStreamReader = File.OpenText(Open.FileName)
        Do Until myStreamReader.Peek = -1
            ListBox1.Items.Add(myStreamReader.ReadLine())
        Loop


    End Sub

    Private Sub Btnsolve_Click(sender As Object, e As EventArgs) Handles Btnsolve.Click

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        Dash = String.Empty
        Phrase = String.Empty
        lblbox.Text = String.Empty

        Phrase = ListBox1.Items.Item(Int((ListBox1.Items.Count * Rnd())))
        Phrase = Phrase.ToUpper()

        For Each Letters In Phrase
            If Letters <> " " Then
                Dash = Dash + "-"
            Else
                Dash = Dash + " "
            End If
        Next
        lblPhrase.Text = Dash
    End Sub

    Private Sub BtnA_Click_1(sender As Object, e As EventArgs) Handles BtnA.Click

        If Phrase.Contains("A") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "A" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "A")
                End If
            Next letter
            lblPhrase.Text = Dash
            BtnA.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            BtnA.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnB_Click(sender As Object, e As EventArgs) Handles BtnB.Click
        If Phrase.Contains("B") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "B" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "B")
                End If
            Next letter
            lblPhrase.Text = Dash
            BtnB.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            BtnB.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        If Phrase.Contains("C") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "C" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "C")
                End If
            Next letter
            lblPhrase.Text = Dash
            BtnC.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            BtnC.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnD_Click(sender As Object, e As EventArgs) Handles BtnD.Click
        If Phrase.Contains("D") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "D" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "D")
                End If
            Next letter
            lblPhrase.Text = Dash
            BtnD.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            BtnD.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        If Phrase.Contains("E") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "E" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "E")
                End If
            Next letter
            lblPhrase.Text = Dash
            btnE.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            btnE.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnF_Click(sender As Object, e As EventArgs) Handles BtnF.Click
        If Phrase.Contains("F") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "F" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "F")
                End If
            Next letter
            lblPhrase.Text = Dash
            BtnF.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            BtnF.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnG_Click(sender As Object, e As EventArgs) Handles BtnG.Click
        If Phrase.Contains("G") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "G" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "G")
                End If
            Next letter
            lblPhrase.Text = Dash
            BtnG.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            BtnG.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnH_Click(sender As Object, e As EventArgs) Handles BtnH.Click
        If Phrase.Contains("H") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "H" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "H")
                End If
            Next letter
            lblPhrase.Text = Dash
            BtnH.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            BtnH.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnI_Click(sender As Object, e As EventArgs) Handles BtnI.Click
        If Phrase.Contains("I") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "I" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "I")
                End If
            Next letter
            lblPhrase.Text = Dash
            BtnI.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            BtnI.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        If Phrase.Contains("J") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "J" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "J")
                End If
            Next letter
            lblPhrase.Text = Dash
            btnJ.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            btnJ.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnK_Click(sender As Object, e As EventArgs) Handles Btnk.Click
        If Phrase.Contains("K") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "K" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "K")
                End If
            Next letter
            lblPhrase.Text = Dash
            Btnk.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            Btnk.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnL_Click(sender As Object, e As EventArgs) Handles BtnL.Click
        If Phrase.Contains("L") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "L" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "L")
                End If
            Next letter
            lblPhrase.Text = Dash
            BtnL.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            BtnL.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnM_Click_1(sender As Object, e As EventArgs) Handles btnm.Click

        If Phrase.Contains("M") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "M" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "M")
                End If
            Next letter
            lblPhrase.Text = Dash
            Btnm.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            btnm.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnN_Click(sender As Object, e As EventArgs) Handles btnn.Click
        If Phrase.Contains("N") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "N" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "N")
                End If
            Next letter
            lblPhrase.Text = Dash
            btnn.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            btnn.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnO_Click(sender As Object, e As EventArgs) Handles Btno.Click
        If Phrase.Contains("O") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "O" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "O")
                End If
            Next letter
            lblPhrase.Text = Dash
            Btno.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            Btno.BackColor = Color.Red
        End If
    End Sub

    Private Sub BtnP_Click(sender As Object, e As EventArgs) Handles Btnp.Click
        If Phrase.Contains("p") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "P" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "P")
                End If
            Next letter
            lblPhrase.Text = Dash
            Btnp.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            Btnp.BackColor = Color.Red
        End If
    End Sub

    Private Sub Btnq_Click(sender As Object, e As EventArgs) Handles Btnq.Click
        If Phrase.Contains("q") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "q" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "q")
                End If
            Next letter
            lblPhrase.Text = Dash
            Btnq.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            Btnq.BackColor = Color.Red
        End If
    End Sub

    Private Sub Btnr_Click(sender As Object, e As EventArgs) Handles Btnr.Click
        If Phrase.Contains("r") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "r" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "r")
                End If
            Next letter
            lblPhrase.Text = Dash
            Btnr.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            Btnr.BackColor = Color.Red
        End If
    End Sub

    Private Sub Btns_Click(sender As Object, e As EventArgs) Handles Btns.Click
        If Phrase.Contains("s") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "s" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "s")
                End If
            Next letter
            lblPhrase.Text = Dash
            Btns.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            Btns.BackColor = Color.Red
        End If
    End Sub

    Private Sub Btnt_Click(sender As Object, e As EventArgs) Handles Btnt.Click
        If Phrase.Contains("t") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "t" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "t")
                End If
            Next letter
            lblPhrase.Text = Dash
            Btnt.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            Btnt.BackColor = Color.Red
        End If
    End Sub

    Private Sub Btnu_Click(sender As Object, e As EventArgs) Handles Btnu.Click
        If Phrase.Contains("u") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "u" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "u")
                End If
            Next letter
            lblPhrase.Text = Dash
            Btnu.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            Btnu.BackColor = Color.Red
        End If
    End Sub

    Private Sub Btnv_Click(sender As Object, e As EventArgs) Handles Btnv.Click
        If Phrase.Contains("v") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "v" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "v")
                End If
            Next letter
            lblPhrase.Text = Dash
            Btnv.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            Btnv.BackColor = Color.Red
        End If
    End Sub

    Private Sub Btnw_Click(sender As Object, e As EventArgs) Handles Btnw.Click
        If Phrase.Contains("w") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "w" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "w")
                End If
            Next letter
            lblPhrase.Text = Dash
            Btnw.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            Btnw.BackColor = Color.Red
        End If
    End Sub

    Private Sub Btnx_Click(sender As Object, e As EventArgs) Handles Btnx.Click
        If Phrase.Contains("x") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "x" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "x")
                End If
            Next letter
            lblPhrase.Text = Dash
            Btny.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            Btny.BackColor = Color.Red
        End If
    End Sub

    Private Sub Btny_Click(sender As Object, e As EventArgs) Handles Btny.Click
        If Phrase.Contains("y") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "y" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "y")
                End If
            Next letter
            lblPhrase.Text = Dash
            Btny.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            Btny.BackColor = Color.Red
        End If
    End Sub

    Private Sub Btnz_Click(sender As Object, e As EventArgs) Handles btnz.Click
        If Phrase.Contains("z") Then
            For letter As Integer = 0 To Phrase.Length - 1
                If Phrase(letter) = "z" Then
                    Dash = Dash.Remove(letter, 1)
                    Dash = Dash.Insert(letter, "z")
                End If
            Next letter
            lblPhrase.Text = Dash
            btnz.BackColor = Color.Green

        Else
            MsgBox("Try Again")
            btnz.BackColor = Color.Red
        End If
    End Sub

    Private Sub lblPhrase_Click(sender As Object, e As EventArgs) Handles lblPhrase.Click

    End Sub
End Class