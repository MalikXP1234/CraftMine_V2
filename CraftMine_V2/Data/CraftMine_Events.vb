Imports System.IO

Module CraftMine_Events

    Public Filewriter As New StreamWriter(LeaderboardFile, True)

    Public WithEvents CraftMine_Timer_Movement As New Timer
    Public WithEvents CraftMine_Timer_Collision As New Timer
    Public WithEvents CraftMine_InGameTimer As New Timer

    Public formlist As New List(Of Form)
    Public treestorage, fruitstorage, rockstorage, Coalstorage, Ironstorage, Goldstorage, characterlist As New List(Of PictureBox)


    Public Sub CraftMine_Movement() Handles CraftMine_Timer_Movement.Tick '  Controls The Movement of The player 

        CraftMine_Timer_Movement.Interval = 30

        If GrassLand.Visible = True Then

            PlayerG.Movement()

        ElseIf SnowLand.Visible = True Then

            PlayerS.Movement()

        ElseIf Forest.Visible = True Then

            PlayerF.Movement()

        ElseIf Mountains.Visible = True Then

            PlayerM.Movement()

        ElseIf Beach.Visible = True Then

            PlayerB.Movement()

        End If

        CraftMine_InGameTimer.Start()

    End Sub

    Public Sub CraftMine_Data() Handles CraftMine_Timer_Collision.Tick  ' Controls all data in CraftMine

        Craftmine_Timer_Data.Interval = 1

        CraftMine_label()

        If GrassLand.Visible = True Then

            PlayerG.Collosion()
            PlayerG.GrassLand_Barrier()

        ElseIf SnowLand.Visible = True Then

            PlayerS.Collosion()
            PlayerS.SnowLand_Barrier()

        ElseIf Forest.Visible = True Then

            PlayerF.Collosion()
            PlayerF.Forest_Barrier()
            PlayerF.Puzzle_collision()

        ElseIf Mountains.Visible = True Then

            PlayerM.Collosion()
            PlayerM.Mountain_Barrier()

        ElseIf Beach.Visible = True Then

            PlayerB.Collosion()
            PlayerB.Beach_Barrier()
            PlayerB.Ship_collision()

        End If

        For Each form In formlist
            If form.Visible = True Then

                form.Controls.Add(Mining)

                form.Controls.Add(ui)

                form.Controls.Add(Respawn)

                Beach.Controls.Add(Shipp)

                Forest.Controls.Add(message)
            End If
        Next


    End Sub

    Public Sub CraftMine_Timer() Handles CraftMine_InGameTimer.Tick ' Ingame timer checks how long the user has played

        CraftMine_InGameTimer.Interval = 1000

        seconds += 1

        If seconds > 59 Then
            seconds = 0
            minutes += 1
            If minutes = 59 Then
                minutes = 0
                hour = 1
            End If
        End If

    End Sub

End Module
