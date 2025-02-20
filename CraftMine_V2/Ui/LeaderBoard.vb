Imports System.IO

Public Class LeaderBoard

    Dim FirstTry As Integer = 0

    Private Sub LeaderBoard_Button(sender As Object, e As EventArgs) Handles LeaderBoardButton.Click

        FirstTry += 1

        ' Reads the file which contains the Leaderboard

        ' List for Storing the UserName/Password
        Dim UList As New List(Of String)
        Dim PList As New List(Of Integer)
        Dim Player_Points As New Integer
        'Used to store the correct versions back to the list
        Dim NameHolder As String
        Dim PointsHolder As String
        Dim Sections As String()
        Dim outputs As String

        If File.Exists(LeaderboardFile) Then

            Dim fileholder = File.ReadAllLines(LeaderboardFile)

            MsgBox("Your datafile has been found!")

            For Each Part In fileholder

                Sections = Part.Split(":") ' indicates when there is a split

                ' Splits the Words into two sections
                UList.Add(Sections(0))
                PList.Add(Sections(1))

            Next


            Player_Points = PList.Count ' Gets the points

            ' Bubble Sort beings here
            For i = 0 To Player_Points - 2 ' Checks the length of the points

                If PList(i) < PList(i + 1) Then ' Compares the value of points

                    ' Swaps name around
                    NameHolder = UList(i)
                    UList(i) = UList(i + 1)
                    UList(i + 1) = NameHolder
                    ' Swaps Points around
                    PointsHolder = PList(i)
                    PList(i) = PList(i + 1)
                    PList(i + 1) = PointsHolder

                End If

            Next

            MsgBox("Data has been collected")

            ' Display the items in the listbox to showcase the user's Points
            If FirstTry = 1 Then

                ListBox1.Items.Add("Here is the list of user's Points from File Data")
                ListBox1.Items.Add("-----------------------------------")

                For i As Integer = 0 To UList.Count - 1

                    outputs = UList(i) & " : " & PList(i) & " Point "


                    ListBox1.Items.Add(outputs)
                    ListBox1.Items.Add("-----------------------------------")
                Next

            End If

        Else
            MsgBox("Sorry to let you know that there is no file that has data to be displayed")

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Visible = False
        Main_Menu.Visible = True

        ListBox1.Items.Clear()
        FirstTry = 0

    End Sub

    Private Sub LeaderBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class