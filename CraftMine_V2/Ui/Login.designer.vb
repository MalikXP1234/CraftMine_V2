<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Signup1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.signuser = New System.Windows.Forms.TextBox()
        Me.signpass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Login1 = New System.Windows.Forms.Button()
        Me.loguser = New System.Windows.Forms.TextBox()
        Me.logpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Signup1
        '
        Me.Signup1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Signup1.Location = New System.Drawing.Point(224, 261)
        Me.Signup1.Name = "Signup1"
        Me.Signup1.Size = New System.Drawing.Size(291, 50)
        Me.Signup1.TabIndex = 27
        Me.Signup1.Text = "Sign Up"
        Me.Signup1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 33)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Password :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 33)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Username :"
        '
        'signuser
        '
        Me.signuser.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signuser.Location = New System.Drawing.Point(193, 135)
        Me.signuser.Name = "signuser"
        Me.signuser.Size = New System.Drawing.Size(322, 40)
        Me.signuser.TabIndex = 24
        '
        'signpass
        '
        Me.signpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signpass.Location = New System.Drawing.Point(193, 195)
        Me.signpass.Name = "signpass"
        Me.signpass.Size = New System.Drawing.Size(322, 40)
        Me.signpass.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 73)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Sign Up"
        '
        'Login1
        '
        Me.Login1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login1.Location = New System.Drawing.Point(822, 261)
        Me.Login1.Name = "Login1"
        Me.Login1.Size = New System.Drawing.Size(291, 50)
        Me.Login1.TabIndex = 21
        Me.Login1.Text = "Login"
        Me.Login1.UseVisualStyleBackColor = True
        '
        'loguser
        '
        Me.loguser.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loguser.Location = New System.Drawing.Point(791, 135)
        Me.loguser.Name = "loguser"
        Me.loguser.Size = New System.Drawing.Size(322, 40)
        Me.loguser.TabIndex = 20
        '
        'logpass
        '
        Me.logpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logpass.Location = New System.Drawing.Point(791, 195)
        Me.logpass.Name = "logpass"
        Me.logpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.logpass.Size = New System.Drawing.Size(322, 40)
        Me.logpass.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(619, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 33)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Username :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(626, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 33)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(619, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 73)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Login"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1134, 336)
        Me.Controls.Add(Me.Signup1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.signuser)
        Me.Controls.Add(Me.signpass)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Login1)
        Me.Controls.Add(Me.loguser)
        Me.Controls.Add(Me.logpass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Signup1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents signuser As TextBox
    Friend WithEvents signpass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Login1 As Button
    Friend WithEvents loguser As TextBox
    Friend WithEvents logpass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
