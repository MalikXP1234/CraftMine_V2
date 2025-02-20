Public Class Main_Menu

    Private Sub Play1_Click(sender As Object, e As EventArgs) Handles Play1.Click ' Takes User to the Play Menu Form

        Me.Visible = False
        Play_Menu.Visible = True

    End Sub

    Private Sub Quit1_Click(sender As Object, e As EventArgs) Handles Quit1.Click ' Ask User to leave the game or not

        If MsgBox("Would you like to quit the cool game?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Me.Visible = True

            End

        End If

    End Sub

    Private Sub Lead1_Click(sender As Object, e As EventArgs) Handles Lead1.Click ' Takes User to LeaderBoard Form to see Score

        ' Place for LeaderBoard Form

        Me.Visible = False
        LeaderBoard.Visible = True

    End Sub

    Private Sub Main_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class