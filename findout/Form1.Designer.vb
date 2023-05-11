<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Btnspin = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Btnexit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblbox = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Btnguess = New System.Windows.Forms.Button()
        Me.Picwheel = New System.Windows.Forms.PictureBox()
        Me.Btnsolve = New System.Windows.Forms.Button()
        Me.Btno = New System.Windows.Forms.Button()
        Me.Btnp = New System.Windows.Forms.Button()
        Me.Btnq = New System.Windows.Forms.Button()
        Me.Btnr = New System.Windows.Forms.Button()
        Me.Btns = New System.Windows.Forms.Button()
        Me.Btnt = New System.Windows.Forms.Button()
        Me.Btnu = New System.Windows.Forms.Button()
        Me.Btnv = New System.Windows.Forms.Button()
        Me.Btnw = New System.Windows.Forms.Button()
        Me.Btnx = New System.Windows.Forms.Button()
        Me.Btny = New System.Windows.Forms.Button()
        Me.btnz = New System.Windows.Forms.Button()
        Me.btnn = New System.Windows.Forms.Button()
        Me.BtnB = New System.Windows.Forms.Button()
        Me.BtnC = New System.Windows.Forms.Button()
        Me.BtnD = New System.Windows.Forms.Button()
        Me.btnE = New System.Windows.Forms.Button()
        Me.BtnF = New System.Windows.Forms.Button()
        Me.BtnG = New System.Windows.Forms.Button()
        Me.BtnH = New System.Windows.Forms.Button()
        Me.BtnI = New System.Windows.Forms.Button()
        Me.btnJ = New System.Windows.Forms.Button()
        Me.Btnk = New System.Windows.Forms.Button()
        Me.BtnL = New System.Windows.Forms.Button()
        Me.btnm = New System.Windows.Forms.Button()
        Me.BtnA = New System.Windows.Forms.Button()
        Me.La = New System.Windows.Forms.Label()
        Me.Txtsolve = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.lblPhrase = New System.Windows.Forms.Label()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Picwheel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btnspin
        '
        Me.Btnspin.Location = New System.Drawing.Point(531, 26)
        Me.Btnspin.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnspin.Name = "Btnspin"
        Me.Btnspin.Size = New System.Drawing.Size(83, 44)
        Me.Btnspin.TabIndex = 1
        Me.Btnspin.Text = "Spin"
        Me.Btnspin.UseVisualStyleBackColor = True
        '
        'Timer
        '
        Me.Timer.Interval = 1
        '
        'Btnexit
        '
        Me.Btnexit.Location = New System.Drawing.Point(1118, 11)
        Me.Btnexit.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(87, 31)
        Me.Btnexit.TabIndex = 3
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(881, 155)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 5
        '
        'lblbox
        '
        Me.lblbox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblbox.Location = New System.Drawing.Point(531, 72)
        Me.lblbox.Name = "lblbox"
        Me.lblbox.Size = New System.Drawing.Size(83, 103)
        Me.lblbox.TabIndex = 7
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(908, 27)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 134)
        Me.ListBox1.TabIndex = 35
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip1.TabIndex = 36
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "file"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.OpenToolStripMenuItem.Text = "open"
        '
        'Btnguess
        '
        Me.Btnguess.Location = New System.Drawing.Point(618, 26)
        Me.Btnguess.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnguess.Name = "Btnguess"
        Me.Btnguess.Size = New System.Drawing.Size(97, 37)
        Me.Btnguess.TabIndex = 37
        Me.Btnguess.Text = "Go guess"
        Me.Btnguess.UseVisualStyleBackColor = True
        '
        'Picwheel
        '
        Me.Picwheel.Image = Global.findout.My.Resources.Resources.og1
        Me.Picwheel.Location = New System.Drawing.Point(221, 26)
        Me.Picwheel.Margin = New System.Windows.Forms.Padding(2)
        Me.Picwheel.Name = "Picwheel"
        Me.Picwheel.Size = New System.Drawing.Size(306, 294)
        Me.Picwheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picwheel.TabIndex = 0
        Me.Picwheel.TabStop = False
        '
        'Btnsolve
        '
        Me.Btnsolve.Location = New System.Drawing.Point(93, 59)
        Me.Btnsolve.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnsolve.Name = "Btnsolve"
        Me.Btnsolve.Size = New System.Drawing.Size(92, 40)
        Me.Btnsolve.TabIndex = 186
        Me.Btnsolve.Text = "Solve"
        Me.Btnsolve.UseVisualStyleBackColor = True
        '
        'Btno
        '
        Me.Btno.Location = New System.Drawing.Point(149, 420)
        Me.Btno.Margin = New System.Windows.Forms.Padding(2)
        Me.Btno.Name = "Btno"
        Me.Btno.Size = New System.Drawing.Size(50, 40)
        Me.Btno.TabIndex = 185
        Me.Btno.Text = "O"
        Me.Btno.UseVisualStyleBackColor = True
        '
        'Btnp
        '
        Me.Btnp.Location = New System.Drawing.Point(218, 420)
        Me.Btnp.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnp.Name = "Btnp"
        Me.Btnp.Size = New System.Drawing.Size(50, 40)
        Me.Btnp.TabIndex = 184
        Me.Btnp.Text = "P"
        Me.Btnp.UseVisualStyleBackColor = True
        '
        'Btnq
        '
        Me.Btnq.Location = New System.Drawing.Point(290, 420)
        Me.Btnq.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnq.Name = "Btnq"
        Me.Btnq.Size = New System.Drawing.Size(50, 40)
        Me.Btnq.TabIndex = 183
        Me.Btnq.Text = "Q"
        Me.Btnq.UseVisualStyleBackColor = True
        '
        'Btnr
        '
        Me.Btnr.Location = New System.Drawing.Point(369, 420)
        Me.Btnr.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnr.Name = "Btnr"
        Me.Btnr.Size = New System.Drawing.Size(50, 40)
        Me.Btnr.TabIndex = 182
        Me.Btnr.Text = "R"
        Me.Btnr.UseVisualStyleBackColor = True
        '
        'Btns
        '
        Me.Btns.Location = New System.Drawing.Point(445, 420)
        Me.Btns.Margin = New System.Windows.Forms.Padding(2)
        Me.Btns.Name = "Btns"
        Me.Btns.Size = New System.Drawing.Size(50, 40)
        Me.Btns.TabIndex = 181
        Me.Btns.Text = "S"
        Me.Btns.UseVisualStyleBackColor = True
        '
        'Btnt
        '
        Me.Btnt.Location = New System.Drawing.Point(514, 420)
        Me.Btnt.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnt.Name = "Btnt"
        Me.Btnt.Size = New System.Drawing.Size(50, 40)
        Me.Btnt.TabIndex = 180
        Me.Btnt.Text = "T"
        Me.Btnt.UseVisualStyleBackColor = True
        '
        'Btnu
        '
        Me.Btnu.Location = New System.Drawing.Point(590, 420)
        Me.Btnu.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnu.Name = "Btnu"
        Me.Btnu.Size = New System.Drawing.Size(50, 40)
        Me.Btnu.TabIndex = 179
        Me.Btnu.Text = "U"
        Me.Btnu.UseVisualStyleBackColor = True
        '
        'Btnv
        '
        Me.Btnv.Location = New System.Drawing.Point(652, 420)
        Me.Btnv.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnv.Name = "Btnv"
        Me.Btnv.Size = New System.Drawing.Size(50, 40)
        Me.Btnv.TabIndex = 178
        Me.Btnv.Text = "V"
        Me.Btnv.UseVisualStyleBackColor = True
        '
        'Btnw
        '
        Me.Btnw.Location = New System.Drawing.Point(717, 420)
        Me.Btnw.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnw.Name = "Btnw"
        Me.Btnw.Size = New System.Drawing.Size(50, 40)
        Me.Btnw.TabIndex = 177
        Me.Btnw.Text = "W"
        Me.Btnw.UseVisualStyleBackColor = True
        '
        'Btnx
        '
        Me.Btnx.Location = New System.Drawing.Point(784, 418)
        Me.Btnx.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnx.Name = "Btnx"
        Me.Btnx.Size = New System.Drawing.Size(50, 40)
        Me.Btnx.TabIndex = 176
        Me.Btnx.Text = "X"
        Me.Btnx.UseVisualStyleBackColor = True
        '
        'Btny
        '
        Me.Btny.Location = New System.Drawing.Point(838, 418)
        Me.Btny.Margin = New System.Windows.Forms.Padding(2)
        Me.Btny.Name = "Btny"
        Me.Btny.Size = New System.Drawing.Size(50, 40)
        Me.Btny.TabIndex = 175
        Me.Btny.Text = "Y"
        Me.Btny.UseVisualStyleBackColor = True
        '
        'btnz
        '
        Me.btnz.Location = New System.Drawing.Point(897, 420)
        Me.btnz.Margin = New System.Windows.Forms.Padding(2)
        Me.btnz.Name = "btnz"
        Me.btnz.Size = New System.Drawing.Size(50, 40)
        Me.btnz.TabIndex = 174
        Me.btnz.Text = "Z"
        Me.btnz.UseVisualStyleBackColor = True
        '
        'btnn
        '
        Me.btnn.Location = New System.Drawing.Point(81, 420)
        Me.btnn.Margin = New System.Windows.Forms.Padding(2)
        Me.btnn.Name = "btnn"
        Me.btnn.Size = New System.Drawing.Size(50, 40)
        Me.btnn.TabIndex = 173
        Me.btnn.Text = "N"
        Me.btnn.UseVisualStyleBackColor = True
        '
        'BtnB
        '
        Me.BtnB.Location = New System.Drawing.Point(149, 360)
        Me.BtnB.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnB.Name = "BtnB"
        Me.BtnB.Size = New System.Drawing.Size(50, 40)
        Me.BtnB.TabIndex = 172
        Me.BtnB.Text = "B"
        Me.BtnB.UseVisualStyleBackColor = True
        '
        'BtnC
        '
        Me.BtnC.Location = New System.Drawing.Point(218, 360)
        Me.BtnC.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnC.Name = "BtnC"
        Me.BtnC.Size = New System.Drawing.Size(50, 40)
        Me.BtnC.TabIndex = 171
        Me.BtnC.Text = "C"
        Me.BtnC.UseVisualStyleBackColor = True
        '
        'BtnD
        '
        Me.BtnD.Location = New System.Drawing.Point(290, 360)
        Me.BtnD.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnD.Name = "BtnD"
        Me.BtnD.Size = New System.Drawing.Size(50, 40)
        Me.BtnD.TabIndex = 170
        Me.BtnD.Text = "D"
        Me.BtnD.UseVisualStyleBackColor = True
        '
        'btnE
        '
        Me.btnE.Location = New System.Drawing.Point(369, 360)
        Me.btnE.Margin = New System.Windows.Forms.Padding(2)
        Me.btnE.Name = "btnE"
        Me.btnE.Size = New System.Drawing.Size(50, 40)
        Me.btnE.TabIndex = 169
        Me.btnE.Text = "E"
        Me.btnE.UseVisualStyleBackColor = True
        '
        'BtnF
        '
        Me.BtnF.Location = New System.Drawing.Point(445, 360)
        Me.BtnF.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnF.Name = "BtnF"
        Me.BtnF.Size = New System.Drawing.Size(50, 40)
        Me.BtnF.TabIndex = 168
        Me.BtnF.Text = "F"
        Me.BtnF.UseVisualStyleBackColor = True
        '
        'BtnG
        '
        Me.BtnG.Location = New System.Drawing.Point(514, 360)
        Me.BtnG.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnG.Name = "BtnG"
        Me.BtnG.Size = New System.Drawing.Size(50, 40)
        Me.BtnG.TabIndex = 167
        Me.BtnG.Text = "G"
        Me.BtnG.UseVisualStyleBackColor = True
        '
        'BtnH
        '
        Me.BtnH.Location = New System.Drawing.Point(590, 360)
        Me.BtnH.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnH.Name = "BtnH"
        Me.BtnH.Size = New System.Drawing.Size(50, 40)
        Me.BtnH.TabIndex = 166
        Me.BtnH.Text = "H"
        Me.BtnH.UseVisualStyleBackColor = True
        '
        'BtnI
        '
        Me.BtnI.Location = New System.Drawing.Point(652, 360)
        Me.BtnI.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnI.Name = "BtnI"
        Me.BtnI.Size = New System.Drawing.Size(50, 40)
        Me.BtnI.TabIndex = 165
        Me.BtnI.Text = "I"
        Me.BtnI.UseVisualStyleBackColor = True
        '
        'btnJ
        '
        Me.btnJ.Location = New System.Drawing.Point(717, 360)
        Me.btnJ.Margin = New System.Windows.Forms.Padding(2)
        Me.btnJ.Name = "btnJ"
        Me.btnJ.Size = New System.Drawing.Size(50, 40)
        Me.btnJ.TabIndex = 164
        Me.btnJ.Text = "J"
        Me.btnJ.UseVisualStyleBackColor = True
        '
        'Btnk
        '
        Me.Btnk.Location = New System.Drawing.Point(784, 358)
        Me.Btnk.Margin = New System.Windows.Forms.Padding(2)
        Me.Btnk.Name = "Btnk"
        Me.Btnk.Size = New System.Drawing.Size(50, 40)
        Me.Btnk.TabIndex = 163
        Me.Btnk.Text = "K"
        Me.Btnk.UseVisualStyleBackColor = True
        '
        'BtnL
        '
        Me.BtnL.Location = New System.Drawing.Point(838, 358)
        Me.BtnL.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnL.Name = "BtnL"
        Me.BtnL.Size = New System.Drawing.Size(50, 40)
        Me.BtnL.TabIndex = 162
        Me.BtnL.Text = "L"
        Me.BtnL.UseVisualStyleBackColor = True
        '
        'btnm
        '
        Me.btnm.Location = New System.Drawing.Point(897, 360)
        Me.btnm.Margin = New System.Windows.Forms.Padding(2)
        Me.btnm.Name = "btnm"
        Me.btnm.Size = New System.Drawing.Size(50, 40)
        Me.btnm.TabIndex = 161
        Me.btnm.Text = "M"
        Me.btnm.UseVisualStyleBackColor = True
        '
        'BtnA
        '
        Me.BtnA.Location = New System.Drawing.Point(81, 360)
        Me.BtnA.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnA.Name = "BtnA"
        Me.BtnA.Size = New System.Drawing.Size(50, 40)
        Me.BtnA.TabIndex = 160
        Me.BtnA.Text = "A"
        Me.BtnA.UseVisualStyleBackColor = True
        '
        'La
        '
        Me.La.AutoSize = True
        Me.La.Location = New System.Drawing.Point(701, 335)
        Me.La.Name = "La"
        Me.La.Size = New System.Drawing.Size(0, 13)
        Me.La.TabIndex = 159
        '
        'Txtsolve
        '
        Me.Txtsolve.Location = New System.Drawing.Point(93, 105)
        Me.Txtsolve.Name = "Txtsolve"
        Me.Txtsolve.Size = New System.Drawing.Size(100, 20)
        Me.Txtsolve.TabIndex = 188
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(732, 38)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 189
        Me.btnNew.Text = "New Phrase"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'lblPhrase
        '
        Me.lblPhrase.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblPhrase.Location = New System.Drawing.Point(630, 212)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(236, 83)
        Me.lblPhrase.TabIndex = 190
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1028, 519)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.Txtsolve)
        Me.Controls.Add(Me.Btnsolve)
        Me.Controls.Add(Me.Btno)
        Me.Controls.Add(Me.Btnp)
        Me.Controls.Add(Me.Btnq)
        Me.Controls.Add(Me.Btnr)
        Me.Controls.Add(Me.Btns)
        Me.Controls.Add(Me.Btnt)
        Me.Controls.Add(Me.Btnu)
        Me.Controls.Add(Me.Btnv)
        Me.Controls.Add(Me.Btnw)
        Me.Controls.Add(Me.Btnx)
        Me.Controls.Add(Me.Btny)
        Me.Controls.Add(Me.btnz)
        Me.Controls.Add(Me.btnn)
        Me.Controls.Add(Me.BtnB)
        Me.Controls.Add(Me.BtnC)
        Me.Controls.Add(Me.BtnD)
        Me.Controls.Add(Me.btnE)
        Me.Controls.Add(Me.BtnF)
        Me.Controls.Add(Me.BtnG)
        Me.Controls.Add(Me.BtnH)
        Me.Controls.Add(Me.BtnI)
        Me.Controls.Add(Me.btnJ)
        Me.Controls.Add(Me.Btnk)
        Me.Controls.Add(Me.BtnL)
        Me.Controls.Add(Me.btnm)
        Me.Controls.Add(Me.BtnA)
        Me.Controls.Add(Me.La)
        Me.Controls.Add(Me.Btnguess)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblbox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.Btnspin)
        Me.Controls.Add(Me.Picwheel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Picwheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picwheel As PictureBox
    Friend WithEvents Btnspin As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents Btnexit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblbox As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents PerformanceCounter1 As PerformanceCounter
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Btnguess As Button
    Friend WithEvents Btnsolve As Button
    Friend WithEvents Btno As Button
    Friend WithEvents Btnp As Button
    Friend WithEvents Btnq As Button
    Friend WithEvents Btnr As Button
    Friend WithEvents Btns As Button
    Friend WithEvents Btnt As Button
    Friend WithEvents Btnu As Button
    Friend WithEvents Btnv As Button
    Friend WithEvents Btnw As Button
    Friend WithEvents Btnx As Button
    Friend WithEvents Btny As Button
    Friend WithEvents btnz As Button
    Friend WithEvents btnn As Button
    Friend WithEvents BtnB As Button
    Friend WithEvents BtnC As Button
    Friend WithEvents BtnD As Button
    Friend WithEvents btnE As Button
    Friend WithEvents BtnF As Button
    Friend WithEvents BtnG As Button
    Friend WithEvents BtnH As Button
    Friend WithEvents BtnI As Button
    Friend WithEvents btnJ As Button
    Friend WithEvents Btnk As Button
    Friend WithEvents BtnL As Button
    Friend WithEvents btnm As Button
    Friend WithEvents BtnA As Button
    Friend WithEvents La As Label
    Friend WithEvents Txtsolve As TextBox
    Friend WithEvents btnNew As Button
    Friend WithEvents lblPhrase As Label
End Class
