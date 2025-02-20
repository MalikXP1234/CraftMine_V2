Public Class Play_Menu
    Private Sub SignupLogin1_Click(sender As Object, e As EventArgs) Handles SignupLogin1.Click ' Takes User for Account Creation

        Me.Visible = False
        Login.Visible = True

    End Sub

    Private Sub Back1_Click(sender As Object, e As EventArgs) Handles Back1.Click ' Takes User back to Main Menu Form

        Me.Visible = False
        Main_Menu.Visible = True

    End Sub

    Private Sub Game1_Click(sender As Object, e As EventArgs) Handles Game1.Click ' Checks if you created a Account and asking if you are ready to play

        If LoginChecker = True And MsgBox("Would you like to start you great Adventure??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Me.Visible = False
            Beach.Visible = True
        End If

        If LoginChecker = False Then
            MsgBox("REMINDER: Create a account to play")

        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Play_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class