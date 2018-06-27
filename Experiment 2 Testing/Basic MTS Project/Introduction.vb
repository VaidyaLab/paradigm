Public Class GlobalVariables
    Public Shared CompOne As Integer
    Public Shared CompTwo As Integer
    Public Shared CompThree As Integer
    Public Shared CorrectResponse As Integer
    Public Shared randomnumber As Integer
    Public Shared count As Integer
    Public Shared randomtwo As Integer
    Public Shared SampleTime As New Stopwatch()
    Public Shared ComparisonTime As New Stopwatch()
    Public Shared et As TimeSpan
    Public Shared timestring As String
    Public Shared SampleImage
    Public Shared A1cnt As Integer
    Public Shared A2cnt As Integer
    Public Shared A3cnt As Integer
    Public Shared locate As Integer
End Class

Public Class Introduction
    Public count As Integer = 0
    Public A1cnt As Integer = 0
    Public A2cnt As Integer = 0
    Public A3cnt As Integer = 0
    Public locate As Integer = 0

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub ChooseSampleImage()
        If A1cnt = 1 And A2cnt = 1 And A3cnt = 1 Then
            A1cnt = 0
            A2cnt = 0
            A3cnt = 0
            GlobalVariables.locate += 1
        End If

        If GlobalVariables.locate = 4 Then GlobalVariables.locate = 0

        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 3. 
        GlobalVariables.randomnumber = CInt(Int((3 * Rnd()) + 1))

        While A1cnt = 1
            If A2cnt = 0 And A3cnt = 0 Then
                ' Generate random value between 2 and 3.
                GlobalVariables.randomnumber = CInt(Int((2 * Rnd()) + 2))
                A1cnt += 1
            ElseIf A2cnt = 1 Then
                GlobalVariables.randomnumber = 3
                A1cnt += 1
            ElseIf A3cnt = 1 Then
                GlobalVariables.randomnumber = 2
                A1cnt += 1
            End If
        End While

        While A2cnt = 1
            If A1cnt = 2 Then
                A2cnt += 1
            Else
                If A3cnt = 0 Then
                    ' Generate random value between 1 and 3, and check to see if it's two
                    GlobalVariables.randomnumber = CInt(Int((3 * Rnd()) + 1))
                    If GlobalVariables.randomnumber <> 2 Then
                        A2cnt += 1
                    End If
                Else
                    GlobalVariables.randomnumber = 1
                    A2cnt += 1
                End If
            End If
        End While

        While A3cnt = 1
            If A1cnt = 2 Then
                A3cnt += 1
            ElseIf A2cnt = 2 Then
                A3cnt += 1
            Else
                ' Generate random value between 1 and 2. 
                GlobalVariables.randomnumber = CInt(Int((2 * Rnd()) + 1))
                A3cnt += 1
            End If
        End While

        If A1cnt = 2 Then A1cnt = 1
        If A2cnt = 2 Then A2cnt = 1
        If A3cnt = 2 Then A3cnt = 1

        Select Case GlobalVariables.randomnumber
            Case 1
                A1cnt += 1
            Case 2
                A2cnt += 1
            Case 3
                A3cnt += 1
        End Select

        Select Case GlobalVariables.locate
            Case 0
                'Choose Top Left Image
                Select Case GlobalVariables.randomnumber
                    Case 1
                        Sample.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A1TLR
                    Case 2
                        Sample.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A2TLR
                    Case 3
                        Sample.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A3TLR
                End Select
            Case 1
                'Choose Top Right Image
                Select Case GlobalVariables.randomnumber
                    Case 1
                        Sample.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A1TRR
                    Case 2
                        Sample.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A2TRR
                    Case 3
                        Sample.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A3TRR
                End Select
            Case 2
                'Choose Bottom Left Image
                Select Case GlobalVariables.randomnumber
                    Case 1
                        Sample.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A1BLR
                    Case 2
                        Sample.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A2BLR
                    Case 3
                        Sample.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A3BLR
                End Select
            Case 3
                'Choose Bottom Right Image
                Select Case GlobalVariables.randomnumber
                    Case 1
                        Sample.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A1BRR
                    Case 2
                        Sample.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A2BRR
                    Case 3
                        Sample.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A3BRR
                End Select
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GlobalVariables.count = 0

        My.Computer.FileSystem.WriteAllText("C://ParticipantData/participantdata.txt", "Sample Image, Revealed Location, Sample Timer, Comparison Response, Comparison Timer, Correct Response " + vbCrLf, True)

        Me.ChooseSampleImage()

        GlobalVariables.SampleTime.Start()
        Sample.Show()
        Me.Hide()
    End Sub
End Class