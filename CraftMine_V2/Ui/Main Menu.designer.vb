<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Menu
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
        Me.Lead1 = New System.Windows.Forms.Button()
        Me.Quit1 = New System.Windows.Forms.Button()
        Me.Play1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lead1
        '
        Me.Lead1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lead1.Location = New System.Drawing.Point(182, 290)
        Me.Lead1.Name = "Lead1"
        Me.Lead1.Size = New System.Drawing.Size(359, 70)
        Me.Lead1.TabIndex = 10
        Me.Lead1.Text = "LeaderBoard"
        Me.Lead1.UseVisualStyleBackColor = True
        '
        'Quit1
        '
        Me.Quit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quit1.Location = New System.Drawing.Point(182, 416)
        Me.Quit1.Name = "Quit1"
        Me.Quit1.Size = New System.Drawing.Size(359, 70)
        Me.Quit1.TabIndex = 9
        Me.Quit1.Text = "Quit"
        Me.Quit1.UseVisualStyleBackColor = True
        '
        'Play1
        '
        Me.Play1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Play1.Location = New System.Drawing.Point(182, 171)
        Me.Play1.Name = "Play1"
        Me.Play1.Size = New System.Drawing.Size(359, 70)
        Me.Play1.TabIndex = 7
        Me.Play1.Text = "Play"
        Me.Play1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 65.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(702, 98)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Craft-Mine Island"
        '
        'Main_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 586)
        Me.Controls.Add(Me.Lead1)
        Me.Controls.Add(Me.Quit1)
        Me.Controls.Add(Me.Play1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Main_Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "S"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lead1 As Button
    Friend WithEvents Quit1 As Button
    Friend WithEvents Play1 As Button
    Friend WithEvents Label1 As Label
End Class
