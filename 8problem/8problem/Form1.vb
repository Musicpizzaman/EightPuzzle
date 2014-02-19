Imports System.IO
Public Class Form1
    Dim numlist(8) As Integer

    Private Sub btnSolve_Click(sender As Object, e As EventArgs) Handles btnSolve.Click
        MsgBox("Thanks for clicking the depth first solve button. This is fairly quick most of the time. *Warning it can take fifteen minutes at times.")
        loading.Show()
        Dim StreamWrite As StreamWriter = File.CreateText("path.txt")
        Do
            Dim antiRedundancy As Integer
            Dim Level As Integer
            Dim Direction As Integer = CInt(Int((4 * Rnd()))) 'Tells the program to pick a random int from 0-3
            If Direction = antiRedundancy Then
                Direction = CInt(Int((4 * Rnd())))
            End If
            StreamWrite.WriteLine(Level & " | " & Direction)
            Select Case Direction 'Starts the case block
                Case 0 'LEFT
                    If Label9.Text = "" Then
                        Label9.Text = Label8.Text
                        Label8.Text = ""
                    ElseIf Label6.Text = "" Then
                        Label6.Text = Label7.Text
                        Label7.Text = ""
                    ElseIf Label2.Text = "" Then
                        Label2.Text = Label1.Text
                        Label1.Text = ""
                    ElseIf Label3.Text = "" Then
                        Label3.Text = Label2.Text
                        Label2.Text = ""
                    ElseIf Label4.Text = "" Then
                        Label4.Text = Label9.Text
                        Label9.Text = ""
                    ElseIf Label5.Text = "" Then
                        Label5.Text = Label6.Text
                        Label6.Text = ""
                    End If
                Case 1 'RIGHT
                    If Label9.Text = "" Then
                        Label9.Text = Label4.Text
                        Label4.Text = ""
                    ElseIf Label6.Text = "" Then
                        Label6.Text = Label5.Text
                        Label5.Text = ""
                    ElseIf Label2.Text = "" Then
                        Label2.Text = Label3.Text
                        Label3.Text = ""
                    ElseIf Label1.Text = "" Then
                        Label1.Text = Label2.Text
                        Label2.Text = ""
                    ElseIf Label8.Text = "" Then
                        Label8.Text = Label9.Text
                        Label9.Text = ""
                    ElseIf Label7.Text = "" Then
                        Label7.Text = Label6.Text
                        Label6.Text = ""
                    End If
                Case 2 'UP
                    If Label9.Text = "" Then
                        Label9.Text = Label2.Text
                        Label2.Text = ""
                    ElseIf Label8.Text = "" Then
                        Label8.Text = Label1.Text
                        Label1.Text = ""
                    ElseIf Label4.Text = "" Then
                        Label4.Text = Label3.Text
                        Label3.Text = ""
                    ElseIf Label7.Text = "" Then
                        Label7.Text = Label8.Text
                        Label8.Text = ""
                    ElseIf Label6.Text = "" Then
                        Label6.Text = Label9.Text
                        Label9.Text = ""
                    ElseIf Label5.Text = "" Then
                        Label5.Text = Label4.Text
                        Label4.Text = ""
                    End If
                Case 3 'DOWN
                    If Label9.Text = "" Then
                        Label9.Text = Label6.Text
                        Label6.Text = ""
                    ElseIf Label8.Text = "" Then
                        Label8.Text = Label7.Text
                        Label7.Text = ""
                    ElseIf Label4.Text = "" Then
                        Label4.Text = Label5.Text
                        Label5.Text = ""
                    ElseIf Label3.Text = "" Then
                        Label3.Text = Label4.Text
                        Label4.Text = ""
                    ElseIf Label2.Text = "" Then
                        Label2.Text = Label9.Text
                        Label9.Text = ""
                    ElseIf Label1.Text = "" Then
                        Label1.Text = Label8.Text
                        Label8.Text = ""
                    End If
            End Select 'End the case block
            Level += 1 ' intcrement for level counter
            antiRedundancy = Direction
            If Level = 35000000 Then

                'Label1.Text = numlist(1)
                Exit Do
                MsgBox("Ok. Seriously this problem is taking way to long. It might be because it's unsolvable or perhaps it's just that complex. Either way just generate a new data set.")
                Me.Close()
            End If
            'check if puzzle is sovled and exit loop if it is
        Loop Until Label1.Text = "1" And Label2.Text = "2" And Label3.Text = "3" And Label4.Text = "4" And Label5.Text = "5" And Label6.Text = "6" And Label7.Text = "7" And Label8.Text = "8" And Label9.Text = ""
        My.Computer.Audio.Stop()
        loading.Close()
        MsgBox("Wow! Now open path.txt located in the debug folder.")
        Me.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim solvable As Boolean
        Do
            Dim a(8), i, RN As Integer
            Dim j As Integer = 0
            Dim flag As Boolean
            solvable = False

            flag = False
            i = 1
            a(j) = 1

            Do While i <= 8
                Randomize()
                RN = CInt(Int((8 * Rnd()) + 1))

                For j = 1 To i
                    If (a(j) = RN) Then
                        flag = True
                        Exit For
                    End If
                Next

                If flag = True Then
                    flag = False
                Else
                    a(i) = RN
                    i = i + 1
                End If
            Loop

            For index As Byte = 0 To a.Length - 1
                numlist(index) = a(index)
            Next


            Label1.Text = a(1)
            Label2.Text = a(2)
            Label3.Text = a(3)
            Label4.Text = a(4)
            Label5.Text = a(5)
            Label6.Text = a(6)
            Label7.Text = a(7)
            Label8.Text = a(8)
            Label9.Text = ""

            Dim Count As Integer = 0
            If Label1.Text = "1" And Label2.Text = "2" And Label3.Text = "3" And Label4.Text = "4" And Label5.Text = "5" And Label6.Text = "6" And Label7.Text = "7" And Label8.Text = "8" And Label9.Text = "" Then
                Exit Do
                MsgBox("Wow")
            End If
            If Label1.Text = "8" Then
                Count += 7
            ElseIf Label1.Text = "7" Then
                Count += 6
            ElseIf Label1.Text = "6" Then
                Count += 5
            ElseIf Label1.Text = "5" Then
                Count += 4
            ElseIf Label1.Text = "4" Then
                Count += 3
            ElseIf Label1.Text = "3" Then
                Count += 2
            ElseIf Label1.Text = "2" Then
                Count += 1
            End If
            If Label2.Text = "8" Then
                Count += 6
            ElseIf Label2.Text = "7" Then
                Count += 5
            ElseIf Label2.Text = "6" Then
                Count += 4
            ElseIf Label2.Text = "5" Then
                Count += 3
            ElseIf Label2.Text = "4" Then
                Count += 2
            ElseIf Label2.Text = "3" Then
                Count += 1
            ElseIf Label2.Text = "1" Then
                Count += 7
            End If
            If Label3.Text = "8" Then
                Count += 5
            ElseIf Label3.Text = "7" Then
                Count += 4
            ElseIf Label3.Text = "6" Then
                Count += 3
            ElseIf Label3.Text = "5" Then
                Count += 2
            ElseIf Label3.Text = "4" Then
                Count += 1
            ElseIf Label3.Text = "2" Then
                Count += 7
            ElseIf Label3.Text = "1" Then
                Count += 6
            End If
            If Label4.Text = "8" Then
                Count += 4
            ElseIf Label4.Text = "7" Then
                Count += 3
            ElseIf Label4.Text = "6" Then
                Count += 2
            ElseIf Label4.Text = "5" Then
                Count += 1
            ElseIf Label4.Text = "3" Then
                Count += 7
            ElseIf Label4.Text = "2" Then
                Count += 6
            ElseIf Label4.Text = "1" Then
                Count += 5
            End If
            If Label5.Text = "8" Then
                Count += 3
            ElseIf Label5.Text = "7" Then
                Count += 2
            ElseIf Label5.Text = "6" Then
                Count += 1
            ElseIf Label5.Text = "4" Then
                Count += 7
            ElseIf Label5.Text = "3" Then
                Count += 6
            ElseIf Label5.Text = "2" Then
                Count += 5
            ElseIf Label5.Text = "1" Then
                Count += 4
            End If
            If Label6.Text = "8" Then
                Count += 2
            ElseIf Label6.Text = "7" Then
                Count += 1
            ElseIf Label6.Text = "5" Then
                Count += 7
            ElseIf Label6.Text = "4" Then
                Count += 6
            ElseIf Label6.Text = "3" Then
                Count += 5
            ElseIf Label6.Text = "2" Then
                Count += 4
            ElseIf Label6.Text = "1" Then
                Count += 3
            End If
            If Label7.Text = "8" Then
                Count += 1
            ElseIf Label7.Text = "6" Then
                Count += 7
            ElseIf Label7.Text = "5" Then
                Count += 6
            ElseIf Label7.Text = "4" Then
                Count += 5
            ElseIf Label7.Text = "3" Then
                Count += 4
            ElseIf Label7.Text = "2" Then
                Count += 3
            ElseIf Label7.Text = "1" Then
                Count += 2
            End If
            If Label8.Text = "7" Then
                Count += 7
            ElseIf Label8.Text = "6" Then
                Count += 6
            ElseIf Label8.Text = "5" Then
                Count += 5
            ElseIf Label8.Text = "4" Then
                Count += 4
            ElseIf Label8.Text = "3" Then
                Count += 3
            ElseIf Label8.Text = "2" Then
                Count += 2
            ElseIf Label8.Text = "1" Then
                Count += 1
            End If

            If Count Mod 2 = 0 Then
                solvable = True
            End If

            If Label1.Text = "2" And Label2.Text = "1" Then
                solvable = False
            ElseIf Label1.Text = "2" And Label2.Text = "1" Then
                solvable = False
            ElseIf Label1.Text = "3" And Label2.Text = "2" Then
                solvable = False
            ElseIf Label1.Text = "4" And Label2.Text = "3" Then
                solvable = False
            ElseIf Label1.Text = "5" And Label2.Text = "4" Then
                solvable = False
            ElseIf Label1.Text = "6" And Label2.Text = "5" Then
                solvable = False
            ElseIf Label1.Text = "7" And Label2.Text = "6" Then
                solvable = False
            ElseIf Label1.Text = "8" And Label2.Text = "7" Then
                solvable = False
            End If
            If Label2.Text = "2" And Label3.Text = "1" Then
                solvable = False
            ElseIf Label2.Text = "2" And Label3.Text = "1" Then
                solvable = False
            ElseIf Label2.Text = "3" And Label3.Text = "2" Then
                solvable = False
            ElseIf Label2.Text = "4" And Label3.Text = "3" Then
                solvable = False
            ElseIf Label2.Text = "5" And Label3.Text = "4" Then
                solvable = False
            ElseIf Label2.Text = "6" And Label3.Text = "5" Then
                solvable = False
            ElseIf Label2.Text = "7" And Label3.Text = "6" Then
                solvable = False
            ElseIf Label2.Text = "8" And Label3.Text = "7" Then
                solvable = False
            End If
            If Label3.Text = "2" And Label4.Text = "1" Then
                solvable = False
            ElseIf Label3.Text = "2" And Label4.Text = "1" Then
                solvable = False
            ElseIf Label3.Text = "3" And Label4.Text = "2" Then
                solvable = False
            ElseIf Label3.Text = "4" And Label4.Text = "3" Then
                solvable = False
            ElseIf Label3.Text = "5" And Label4.Text = "4" Then
                solvable = False
            ElseIf Label3.Text = "6" And Label4.Text = "5" Then
                solvable = False
            ElseIf Label3.Text = "7" And Label4.Text = "6" Then
                solvable = False
            ElseIf Label3.Text = "8" And Label4.Text = "7" Then
                solvable = False
            End If
            If Label4.Text = "2" And Label5.Text = "1" Then
                solvable = False
            ElseIf Label4.Text = "2" And Label5.Text = "1" Then
                solvable = False
            ElseIf Label4.Text = "3" And Label5.Text = "2" Then
                solvable = False
            ElseIf Label4.Text = "4" And Label5.Text = "3" Then
                solvable = False
            ElseIf Label4.Text = "5" And Label5.Text = "4" Then
                solvable = False
            ElseIf Label4.Text = "6" And Label5.Text = "5" Then
                solvable = False
            ElseIf Label4.Text = "7" And Label5.Text = "6" Then
                solvable = False
            ElseIf Label4.Text = "8" And Label5.Text = "7" Then
                solvable = False
            End If
            If Label5.Text = "2" And Label6.Text = "1" Then
                solvable = False
            ElseIf Label5.Text = "2" And Label6.Text = "1" Then
                solvable = False
            ElseIf Label5.Text = "3" And Label6.Text = "2" Then
                solvable = False
            ElseIf Label5.Text = "4" And Label6.Text = "3" Then
                solvable = False
            ElseIf Label5.Text = "5" And Label6.Text = "4" Then
                solvable = False
            ElseIf Label5.Text = "6" And Label6.Text = "5" Then
                solvable = False
            ElseIf Label5.Text = "7" And Label6.Text = "6" Then
                solvable = False
            ElseIf Label5.Text = "8" And Label6.Text = "7" Then
                solvable = False
            End If
            If Label6.Text = "2" And Label7.Text = "1" Then
                solvable = False
            ElseIf Label6.Text = "2" And Label7.Text = "1" Then
                solvable = False
            ElseIf Label6.Text = "3" And Label7.Text = "2" Then
                solvable = False
            ElseIf Label6.Text = "4" And Label7.Text = "3" Then
                solvable = False
            ElseIf Label6.Text = "5" And Label7.Text = "4" Then
                solvable = False
            ElseIf Label6.Text = "6" And Label7.Text = "5" Then
                solvable = False
            ElseIf Label6.Text = "7" And Label7.Text = "6" Then
                solvable = False
            ElseIf Label6.Text = "8" And Label7.Text = "7" Then
                solvable = False
            End If
            If Label8.Text = "2" And Label8.Text = "1" Then
                solvable = False
            ElseIf Label7.Text = "2" And Label8.Text = "1" Then
                solvable = False
            ElseIf Label7.Text = "3" And Label8.Text = "2" Then
                solvable = False
            ElseIf Label7.Text = "4" And Label8.Text = "3" Then
                solvable = False
            ElseIf Label7.Text = "5" And Label8.Text = "4" Then
                solvable = False
            ElseIf Label7.Text = "6" And Label8.Text = "5" Then
                solvable = False
            ElseIf Label7.Text = "7" And Label8.Text = "6" Then
                solvable = False
            ElseIf Label7.Text = "8" And Label8.Text = "7" Then
                solvable = False
            End If


        Loop Until solvable = True
        'loop random start number until solvable puzzle is found
    End Sub

    Private Sub btnBreadth_Click(sender As Object, e As EventArgs) Handles btnBreadth.Click
        MsgBox("Thanks for clicking the depth first solve button. *Warning it may never solve.")
        loading.Show()
        Dim Level As Integer
        Dim toLong As Boolean
        Dim StreamWrite As StreamWriter = File.CreateText("path.txt")
        Do
            Label1.Text = numlist(1)
            Label2.Text = numlist(2)
            Label3.Text = numlist(3)
            Label4.Text = numlist(4)
            Label5.Text = numlist(5)
            Label6.Text = numlist(6)
            Label7.Text = numlist(7)
            Label8.Text = numlist(8)
            Label9.Text = ""
            Do
                Dim antiRedundancy As Integer
                Dim branch As Decimal
                Dim Direction As Integer = CInt(Int((4 * Rnd()))) 'Tells the program to pick a random int from 0-3
                If Direction = antiRedundancy Then
                    Direction = CInt(Int((4 * Rnd())))
                End If
                StreamWrite.WriteLine(branch & " | " & Level & " | " & Direction)
                Select Case Direction 'Starts the case block
                    Case 0 'LEFT
                        If Label9.Text = "" Then
                            Label9.Text = Label8.Text
                            Label8.Text = ""
                        ElseIf Label6.Text = "" Then
                            Label6.Text = Label7.Text
                            Label7.Text = ""
                        ElseIf Label2.Text = "" Then
                            Label2.Text = Label1.Text
                            Label1.Text = ""
                        ElseIf Label3.Text = "" Then
                            Label3.Text = Label2.Text
                            Label2.Text = ""
                        ElseIf Label4.Text = "" Then
                            Label4.Text = Label9.Text
                            Label9.Text = ""
                        ElseIf Label5.Text = "" Then
                            Label5.Text = Label6.Text
                            Label6.Text = ""
                        End If
                    Case 1 'RIGHT
                        If Label9.Text = "" Then
                            Label9.Text = Label4.Text
                            Label4.Text = ""
                        ElseIf Label6.Text = "" Then
                            Label6.Text = Label5.Text
                            Label5.Text = ""
                        ElseIf Label2.Text = "" Then
                            Label2.Text = Label3.Text
                            Label3.Text = ""
                        ElseIf Label1.Text = "" Then
                            Label1.Text = Label2.Text
                            Label2.Text = ""
                        ElseIf Label8.Text = "" Then
                            Label8.Text = Label9.Text
                            Label9.Text = ""
                        ElseIf Label7.Text = "" Then
                            Label7.Text = Label6.Text
                            Label6.Text = ""
                        End If
                    Case 2 'UP
                        If Label9.Text = "" Then
                            Label9.Text = Label2.Text
                            Label2.Text = ""
                        ElseIf Label8.Text = "" Then
                            Label8.Text = Label1.Text
                            Label1.Text = ""
                        ElseIf Label4.Text = "" Then
                            Label4.Text = Label3.Text
                            Label3.Text = ""
                        ElseIf Label7.Text = "" Then
                            Label7.Text = Label8.Text
                            Label8.Text = ""
                        ElseIf Label6.Text = "" Then
                            Label6.Text = Label9.Text
                            Label9.Text = ""
                        ElseIf Label5.Text = "" Then
                            Label5.Text = Label4.Text
                            Label4.Text = ""
                        End If
                    Case 3 'DOWN
                        If Label9.Text = "" Then
                            Label9.Text = Label6.Text
                            Label6.Text = ""
                        ElseIf Label8.Text = "" Then
                            Label8.Text = Label7.Text
                            Label7.Text = ""
                        ElseIf Label4.Text = "" Then
                            Label4.Text = Label5.Text
                            Label5.Text = ""
                        ElseIf Label3.Text = "" Then
                            Label3.Text = Label4.Text
                            Label4.Text = ""
                        ElseIf Label2.Text = "" Then
                            Label2.Text = Label9.Text
                            Label9.Text = ""
                        ElseIf Label1.Text = "" Then
                            Label1.Text = Label8.Text
                            Label8.Text = ""
                        End If
                End Select 'End the case block
                Level += 1 ' intcrement for level counter
                branch += 0.1
                If branch = 350000 Then
                    Exit Do
                    toLong = True
                End If
                antiRedundancy = Direction
                'check if puzzle is sovled and exit loop if it is
            Loop Until Level = 10
            Level = 0
            If toLong = True Then
                Exit Do
                MsgBox("Ok. Seriously this problem is taking way to long. It might be because it's unsolvable or perhaps it's just that complex. Either way just generate a new data set.")
                Me.Close()
            End If
        Loop Until Label1.Text = "1" And Label2.Text = "2" And Label3.Text = "3" And Label4.Text = "4" And Label5.Text = "5" And Label6.Text = "6" And Label7.Text = "7" And Label8.Text = "8" And Label9.Text = ""

        My.Computer.Audio.Stop()
        loading.Close()
        MsgBox("Wow! Now open path.txt located in the debug folder.")
        Me.Show()
    End Sub
End Class
