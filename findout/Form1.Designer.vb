<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Picwheel = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timermain = New System.Windows.Forms.Timer(Me.components)
        Me.Btnexit = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Picwheel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picwheel
        '
        Me.Picwheel.Image = Global.findout.My.Resources.Resources.og1
        Me.Picwheel.Location = New System.Drawing.Point(314, 79)
        Me.Picwheel.Name = "Picwheel"
        Me.Picwheel.Size = New System.Drawing.Size(451, 424)
        Me.Picwheel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picwheel.TabIndex = 0
        Me.Picwheel.TabStop = False
        Me.Picwheel.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(935, 291)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 54)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Spin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timermain
        '
        Me.Timermain.Interval = 10
        '
        'Btnexit
        '
        Me.Btnexit.Location = New System.Drawing.Point(1080, 21)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(116, 38)
        Me.Btnexit.TabIndex = 3
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1208, 702)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Picwheel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Picwheel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Picwheel As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timermain As Timer
    Friend WithEvents Btnexit As Button
    Friend WithEvents Timer2 As Timer
End Class
