Imports System.Diagnostics.SymbolStore
Imports System.IO
Imports System.Reflection.Emit

Public Class Inventory

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Update_Labels()

        ' When the user crafts the item, The boolean would be true and therefore would show that the user has the item in the character form

        ' Each if statment is connected to a specific picturebox
        If Craftingtable = True Then
            pic1.Image = My.Resources.Crafting_Table
        End If

        If furnace = True Then
            pic2.Image = My.Resources.Furnace
        End If

        If anvil = True Then
            pic3.Image = My.Resources.Anvil
        End If

        If woodarmor = True Then
            pic4.Image = My.Resources.Wooden_Armor
        End If

        If ironarmor = True Then
            pic5.Image = My.Resources.Iron_Armor
        End If

        If goldarmor = True Then
            pic6.Image = My.Resources.Golden_Armor
        End If

        If woodensword = True Then
            pic12.Image = My.Resources.Wooden_Sword
        End If

        If woodenpick = True Then
            pic7.Image = My.Resources.Wooden_Pickaxe
        End If

        If stonepick = True Then
            pic8.Image = My.Resources.Stone_Pick
        End If

        If ironpick = True Then
            pic9.Image = My.Resources.Iron_Pick
        End If

        If goldpick = True Then
            'pic10.Image = My.Resources.Golden_Pick
        End If

        If goldaxe = True Then
            pic11.Image = My.Resources.Golden_Axe
        End If


    End Sub

    Public Sub Update_Labels()

        ' This is to update what the player has when they craft something
        Labelwood.Text = Format("Wood:  " & wood)
        Labelstone.Text = Format("Stone:  " & stone)
        Labelcoal.Text = Format("Coal:  " & coal)
        LabelIron.Text = Format("Iron:  " & iron)
        Labelgold.Text = Format("Gold:  " & gold)
        LabelIronbar.Text = Format("Iron Bar:  " & ironbar)
        Labelgoldbar.Text = Format("Gold Bar:  " & goldbar)

        LabelPoints.Text = Format("You have collected these points: " & Points)
        LabelTime.Text = Format("You have played for: " & " Hours:  " & hour & " , Minutes:  " & minutes & " , Seconds:  " & seconds)
        Labeltrees.Text = Format("You have destroyed " & treevalue & " of Trees ")
        LabelRock.Text = Format("You have destroyed " & rockvalue & " of Rocks ")
        Label23.Text = Format("You have destroyed " & mineralvalue & " of Minerals ")

        Quest1.Text = Format(" - Get 5 Wood")
        Quest2.Text = Format(" - Get a Crafting Table")
        Quest3.Text = Format(" - Create a Wooden Pickaxe")
        Quest4.Text = Format(" - Get 5 Coal, 5 Iron, 5 Gold")
        Quest5.Text = Format(" - Get 10 Gold Bars")
        Quest6.Text = Format(" - Get 150 Points")
        Quest7.Text = Format(" - Create Ship")


        ' This is for the Quest and if the requirements are good then it would change and you would get points

        Dim Q1, Q2, Q3, Q4, Q5, Q6 As Boolean

        Select Case Visible

            Case wood >= 5 And Q1 = False
                Q1 = True

            Case Craftingtable = True And Q2 = False
                Q2 = True

            Case woodenpick = True And Q3 = False
                Q3 = True

            Case coal >= 5 And iron >= 5 And gold >= 5 And Q4 = False
                Q4 = True

            Case goldbar >= 10 And Q5 = False
                Q5 = True

            Case Points >= 150 And Q6 = False
                Q6 = True

        End Select

        If Q1 = True Then

            Quest1.Text = Format(" - Get 5 Wood - DONE")
            Quest1.ForeColor = Color.Green

        ElseIf Q2 = True Then
            Quest2.Text = Format(" - Get a Crafting Table - DONE")
            Quest2.ForeColor = Color.Green

        ElseIf Q3 = True Then
            Quest3.Text = Format(" - Create a Wooden Pickaxe - DONE")
            Quest3.ForeColor = Color.Green

        ElseIf Q4 = True Then
            Quest4.Text = Format(" - Get 5 Coal, 5 Iron, 5 Gold - DONE")
            Quest4.ForeColor = Color.Green

        ElseIf Q5 = True Then
            Quest5.Text = Format(" - Get 10 Gold Bars - DONE")
            Quest5.ForeColor = Color.Green

        ElseIf Q6 = True Then
            Quest6.Text = Format(" - Get 150 Points - DONE")
            Quest6.ForeColor = Color.Green

        End If




    End Sub
    Private Sub Export1_Click(sender As Object, e As EventArgs) Handles Export1.Click

        correctuser = "Bob"
        Points = 50
        level = 5
        wood = 2
        stone = 6
        coal = 8
        iron = 3
        ironbar = 15
        goldbar = 20
        treevalue = 37
        rockvalue = 23
        mineralvalue = 50

        ' This is used to write 

        Dim Filewriter As New StreamWriter(infofile, True)

        If MsgBox("Would you like to put your data in a file so you can show off to your friends?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Filewriter.WriteLine("

-----------------------------------------------------------------------------------------------------

This infomation is for the username called " & correctuser & ", Here is all of your thing which are provided by the Craft-Mine Security 

In your journey, You have colleted " & Points & " points and you are level" & level & ", Nice :)

As you are a theif to nature, You have collected " & wood & " Wood, " & stone & " Stone, " & coal & " Coal, " & iron & " Iron, " & gold & " Gold, " & ironbar & " Iron Bars, " & goldbar & " gold Bars, 

You are a danger to nature!!, You have destroyed " & treevalue & " Trees, " & rockvalue & " Rocks, " & mineralvalue & " Minerals

Dammm thats a lot. 

-----------------------------------------------------------------------------------------------------

")
            Filewriter.Close()  ' Uses the varible from the user input

        End If

    End Sub


    Private Sub Craftpress1_Click(sender As Object, e As EventArgs) Handles Craftpress1.Click ' Crafting Table

        ironpick = True

        If Craftingtable = False Then

            If wood < 4 Then

                MsgBox("You need to get more materials to get the item")

            ElseIf wood >= 4 Then

                MsgBox("Nice, you have a crafting table now :)")
                wood -= 4
                Craftingtable = True


            End If

        End If

    End Sub

    Private Sub Craftpress2_Click(sender As Object, e As EventArgs) Handles Craftpress2.Click ' Furnace


        If furnace = False Then

            If Craftingtable = False Then
                MsgBox("Get a crafting Table first")

            ElseIf stone < 9 Then
                MsgBox("You need to get more materials to get the item")

            ElseIf stone >= 9 Then

                MsgBox("Nice, you have a Furnace now :)")
                stone -= 9
                furnace = True

            End If

        End If


    End Sub

    Private Sub Craftpress3_Click(sender As Object, e As EventArgs) Handles Craftpress3.Click ' Anvil

        If ironbar < 7 And anvil = False Then

            MsgBox("You need to get more materials to get the item")

        ElseIf ironbar >= 7 Then

            MsgBox("Nice, you have a crafting table now :)")
            ironbar -= 7
            anvil = True


        End If

    End Sub

    Private Sub Armorpress1_Click(sender As Object, e As EventArgs) Handles Armorpress1.Click ' Wooden armor

        If wood < 5 And woodarmor = False Then

            MsgBox("You need to get more materials to get the item")

        ElseIf Craftingtable = False Then
            MsgBox("Get a crafting Table first")

        ElseIf wood >= 5 And Craftingtable = True Then

            MsgBox("Nice, you have Wooden Armor now :)")
            wood -= 5
            woodarmor = True
            Update_Labels()

        End If

    End Sub

    Private Sub Armorpress2_Click(sender As Object, e As EventArgs) Handles Armorpress2.Click ' Iron armor

        If ironbar < 5 And ironbar = False Then

            MsgBox("You need to get more materials to get the item")

        ElseIf anvil = False Then
            MsgBox("Get a Anvil first")

        ElseIf ironbar >= 5 And Craftingtable = True Then

            MsgBox("Nice, you have Iron Armor now :)")
            ironbar -= 5
            ironarmor = True
            Update_Labels()

        End If

    End Sub

    Private Sub Armorpress3_Click(sender As Object, e As EventArgs) Handles Armorpress3.Click ' Gold armor

        If goldbar < 5 And goldarmor = False Then

            MsgBox("You need to get more materials to get the item")

        ElseIf anvil = False Then
            MsgBox("Get a Anvil first")

        ElseIf goldbar >= 5 And anvil = True Then

            MsgBox("Nice, you have Gold Armor now :)")
            goldbar -= 5
            goldarmor = True
            Update_Labels()

        End If

    End Sub

    Private Sub Toolpress1_Click(sender As Object, e As EventArgs) Handles Toolpress1.Click ' Wooden Sword

        If wood < 4 And woodensword = False Then

            MsgBox("You need to get more materials to get the item")

        ElseIf Craftingtable = False Then
            MsgBox("Get a crafting Table first")

        ElseIf wood >= 4 And Craftingtable = True Then

            MsgBox("Nice, you have Wooden Sword now :)")
            wood -= 4
            woodensword = True
            Update_Labels()

        End If

    End Sub

    Private Sub Toolpress2_Click(sender As Object, e As EventArgs) Handles Toolpress2.Click ' Wooden Pickaxe

        If wood < 5 And woodenpick = False Then

            MsgBox("You need to get more materials to get the item")

        ElseIf Craftingtable = False Then
            MsgBox("Get a crafting Table first")

        ElseIf wood >= 5 And Craftingtable = True Then

            MsgBox("Nice, you have a Wooden Pickaxe now :)")
            wood -= 5
            woodenpick = True
            Update_Labels()

        End If

    End Sub

    Private Sub Toolpress3_Click(sender As Object, e As EventArgs) Handles Toolpress3.Click ' Stone Pickaxe

        If stone < 5 And stonepick = False Then

            MsgBox("You need to get more materials to get the item")

        ElseIf Craftingtable = False Then
            MsgBox("Get a crafting Table first")

        ElseIf stone >= 5 And Craftingtable = True Then
            MsgBox("Nice, you have a Stone Pickaxe now :)")
            stone -= 5
            stonepick = True
            Update_Labels()

        End If

    End Sub

    Private Sub Toolpress4_Click(sender As Object, e As EventArgs) Handles Toolpress4.Click ' Iron pickaxe

        If ironbar < 5 And ironpick = False Then

            MsgBox("You need to get more materials to get the item")

        ElseIf anvil = False Then
            MsgBox("Get a Anvil first")

        ElseIf ironbar >= 5 And anvil = True Then
            MsgBox("Nice, you have a Stone Pickaxe now :)")
            ironbar -= 5
            ironpick = True
            Update_Labels()

        End If

    End Sub

    Private Sub Toolpress5_Click(sender As Object, e As EventArgs) Handles Toolpress5.Click ' Golden Pickaxe

        If goldbar < 5 And goldpick = False Then

            MsgBox("You need to get more materials to get the item")

        ElseIf anvil = False Then
            MsgBox("Get a Anvil first")

        ElseIf goldbar >= 5 And anvil = True Then
            MsgBox("Nice, you have a Golden Pickaxe now :)")
            goldbar -= 5
            goldpick = True
            Update_Labels()

        End If

    End Sub

    Private Sub Toolpress6_Click(sender As Object, e As EventArgs) Handles Toolpress6.Click ' Golden Axe

        If goldbar < 5 And goldaxe = False Then

            MsgBox("You need to get more materials to get the item")

        ElseIf anvil = False Then
            MsgBox("Get a Anvil first")

        ElseIf goldbar >= 5 And anvil = True Then
            MsgBox("Nice, you have a Golden axe now :)")
            goldbar -= 5
            goldaxe = True
            Update_Labels()

        End If

    End Sub

    Private Sub Ironbar1_Click(sender As Object, e As EventArgs) Handles Ironbar1.Click ' Iron Bar

        If iron < 1 And coal < 1 Then

            MsgBox("You need to get more materials to get the item")

        ElseIf furnace = False Then
            MsgBox("Get a furnace first")

        ElseIf iron >= 1 And coal >= 1 And furnace = True Then
            MsgBox("Nice, you have a Iron bar now :)")
            coal -= 1
            iron -= 1
            ironbar += 1
            Update_Labels()

        End If

    End Sub

    Private Sub Goldbar1_Click(sender As Object, e As EventArgs) Handles Goldbar1.Click ' Gold Bar

        If gold < 1 And coal < 1 Then

            MsgBox("You need to get more materials to get the item")

        ElseIf furnace = False Then
            MsgBox("Get a furnace first")

        ElseIf gold >= 1 And coal >= 1 And furnace = True Then
            MsgBox("Nice, you have a Iron bar now :)")
            gold -= 1
            iron -= 1
            goldbar += 1
            Update_Labels()

        End If

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Would you like to leave the game?, You points will be added up together and will be put into the LeaderBoard", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            totalpoints = Points + wood + stone + coal + iron + gold + ironbar + goldbar + treevalue + rockvalue + mineralvalue ' This will add all of the points together and this would then be placed into the leaderboard 

            MsgBox("You have gained " & totalpoints & " Points, Amazing! " & correctuser)

        Else

        End If


        Filewriter.WriteLine(correctuser & ":" & totalpoints) ' Uses the varible from the user input 
        Filewriter.Close()

        For Each form In formlist

            form.Visible = False

            Me.Visible = False

            Close()

        Next

    End Sub

End Class