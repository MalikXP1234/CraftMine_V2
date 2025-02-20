<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Play_Menu
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
        Me.Game1 = New System.Windows.Forms.Button()
        Me.Back1 = New System.Windows.Forms.Button()
        Me.SignupLogin1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Game1
        '
        Me.Game1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Game1.Location = New System.Drawing.Point(182, 171)
        Me.Game1.Name = "Game1"
        Me.Game1.Size = New System.Drawing.Size(359, 70)
        Me.Game1.TabIndex = 9
        Me.Game1.Text = "Game!!!"
        Me.Game1.UseVisualStyleBackColor = True
        '
        'Back1
        '
        Me.Back1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back1.Location = New System.Drawing.Point(182, 416)
        Me.Back1.Name = "Back1"
        Me.Back1.Size = New System.Drawing.Size(359, 70)
        Me.Back1.TabIndex = 8
        Me.Back1.Text = "Go Back"
        Me.Back1.UseVisualStyleBackColor = True
        '
        'SignupLogin1
        '
        Me.SignupLogin1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignupLogin1.Location = New System.Drawing.Point(182, 290)
        Me.SignupLogin1.Name = "SignupLogin1"
        Me.SignupLogin1.Size = New System.Drawing.Size(359, 70)
        Me.SignupLogin1.TabIndex = 7
        Me.SignupLogin1.Text = "SignUp/Login"
        Me.SignupLogin1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(108, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(496, 108)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Play Menu"
        '
        'Play_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 586)
        Me.Controls.Add(Me.Game1)
        Me.Controls.Add(Me.Back1)
        Me.Controls.Add(Me.SignupLogin1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Play_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Game1 As Button
    Friend WithEvents Back1 As Button
    Friend WithEvents SignupLogin1 As Button
    Friend WithEvents Label1 As Label
End Class
