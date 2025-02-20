Imports System.IO

Public Class Login

    ' Login Data 
    Public username1, password1 As String
    Friend username2, password2 As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Signup1_Click(sender As Object, e As EventArgs) Handles Signup1.Click

        Dim ASCII_data As Integer

        ' Inputs data for user
        username1 = signuser.Text
        password1 = signpass.Text

        ' Find error
        If username1 = "" Then
            MsgBox("Please say something for username here")
            Exit Sub
        End If

        ' Find errors
        For i = 1 To Len(username1)
            ASCII_data = Asc(Mid(username1, i, 1))

            If ASCII_data = 32 Then
                MsgBox("Please, dont add any spaces to your username")
                Exit Sub
            End If

            If ASCII_data >= 58 And ASCII_data <= 64 Then
                MsgBox("Please, you are not allowed to use these special characters. Remove them and try again")
                Exit Sub
            End If

            If ASCII_data >= 33 And ASCII_data <= 47 Then
                MsgBox("Please, you are not allowed to use these special characters. Remove them and try again")
                Exit Sub
            End If

        Next

        For i = 1 To Len(password1)
            ASCII_data = Asc(Mid(password1, i, 1))

            If ASCII_data = 32 Then
                MsgBox("Please, dont add any spaces to your password")
                Exit Sub
            End If

        Next

        ' checks if the user has not said anthing for the password
        If password1 = "" Then
            MsgBox("Please put something for password here")
            Exit Sub
        End If


        MsgBox(" Welcome! " & username1 & " To the Craft-Mine club ")

        ' Creates file for system to fill
        Dim Filewriter As New StreamWriter(DataFile, True)
        Filewriter.WriteLine(username1 & ":" & password1) ' Inputs data from user
        Filewriter.Close()

        signuser.Text = ""
        signpass.Text = ""



    End Sub



    Private Sub Login1_Click(sender As Object, e As EventArgs) Handles Login1.Click


        Dim word As String ' Stores username and password

        Dim A, B As Integer ' stores letters to add up

        Dim check As Boolean ' Checks if both inputs are correct

        Dim letters As String '  A and B store it in here


        ' Holds the file to be read by the system
        Dim fileholder = File.ReadAllLines(DataFile)

        username2 = loguser.Text

        password2 = logpass.Text

        ' Checks if the user has not said anything for the username
        If username2 = "" Then
            MsgBox("Please say something for login username here")
            Exit Sub
        End If

        ' checks if the user has not said anthing for the password
        If password2 = "" Then
            MsgBox("Please put something for login password here")
            Exit Sub
        End If


        ' Checks word in file
        For Each word In fileholder
            For A = 1 To Len(word) ' checks the length
                letters = Mid(word, A, 1) ' add the letter
                If letters <> ":" Then ' if it reaches ":" then it would stop
                    correctuser &= letters ' add the full word
                End If

                If letters = ":" Then GoTo checkpassword ' Goes and repeat for the next word (Password)
            Next A

checkpassword:

            For B = A + 1 To Len(word)
                letters = Mid(word, B, 1)
                correctpass &= letters
            Next B

            ' if the loop did it correctly and if the user input is the same then it would make the check be true
            If correctuser = username2 And correctpass = password2 Then
                check = True
            End If

            If check = True Then Exit For ' Exit the code

            correctuser = ""
            correctpass = ""

        Next word ' continues for the last step

        ' Finally it will say to the user, you are loggin in and you can play
        If check = True Then
            MsgBox(" Hey, " & username2 & " You are now logged in :D ")

            Me.Visible = False
            Play_Menu.Visible = True

            LoginChecker = True

            Exit Sub

        Else
            MsgBox("Account has not been found") ' Error if system has not found the file

        End If


    End Sub


End Class