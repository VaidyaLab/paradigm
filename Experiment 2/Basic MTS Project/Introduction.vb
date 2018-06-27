Public Class Introduction
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub ChooseSampleImage()
        If GlobalVariables.A1cnt = 2 And GlobalVariables.A2cnt = 2 And GlobalVariables.A3cnt = 2 Then
            GlobalVariables.A1cnt = 0
            GlobalVariables.A2cnt = 0
            GlobalVariables.A3cnt = 0
        End If

        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 3. 
        GlobalVariables.randomnumber = CInt(Int((3 * Rnd()) + 1))

        If GlobalVariables.A1cnt = 2 Then
            If GlobalVariables.A2cnt < 2 And GlobalVariables.A3cnt < 2 Then
                ' Generate random value between 2 and 3.
                GlobalVariables.randomnumber = CInt(Int((2 * Rnd()) + 2))
            ElseIf GlobalVariables.A2cnt = 2 Then
                GlobalVariables.randomnumber = 3
            ElseIf GlobalVariables.A3cnt = 2 Then
                GlobalVariables.randomnumber = 2
            End If
        End If

        'Only Run If A1 Isn't At Two Yet
        If GlobalVariables.A2cnt = 2 And GlobalVariables.A1cnt < 2 Then
            If GlobalVariables.A3cnt < 2 Then
                ' Generate random value between 1 and 2. 
                GlobalVariables.randomnumber = CInt(Int((2 * Rnd()) + 1))
                'If random number is 2 then make it 3
                If GlobalVariables.randomnumber = 2 Then GlobalVariables.randomnumber += 1
            Else
                GlobalVariables.randomnumber = 1
            End If
        End If

        'Only Run If A1 and A2 Aren't At Two Yet
        If GlobalVariables.A3cnt = 2 And GlobalVariables.A1cnt < 2 And GlobalVariables.A2cnt < 2 Then
            ' Generate random value between 1 and 2. 
            GlobalVariables.randomnumber = CInt(Int((2 * Rnd()) + 1))
        End If

        'Choose Image
        Select Case GlobalVariables.randomnumber
            Case 1
                Sample.PictureBox1.Image = Global.Experiment_2.My.Resources.Resources.A1
                GlobalVariables.A1cnt += 1
            Case 2
                Sample.PictureBox1.Image = Global.Experiment_2.My.Resources.Resources.A2
                GlobalVariables.A2cnt += 1
            Case 3
                Sample.PictureBox1.Image = Global.Experiment_2.My.Resources.Resources.A3
                GlobalVariables.A3cnt += 1
                '            Case 4
                '                Sample.PictureBox1.Image = Global.Simple_Sample_Mask.My.Resources.Resources.A4
                '            Case 5
                '                Sample.PictureBox1.Image = Global.Simple_Sample_Mask.My.Resources.Resources.A5
                '            Case 6
                '                Sample.PictureBox1.Image = Global.Simple_Sample_Mask.My.Resources.Resources.A6
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GlobalVariables.count = 0
        GlobalVariables.count2 = 0
        GlobalVariables.count3 = 0

        My.Computer.FileSystem.WriteAllText("C://ParticipantData/participantdata.txt", "Sample Image, Sample Timer, SMT TL, SMT TR, SMT BL, SMT BR, Comparison Response, Comparison Timer, CMT TL, CMT TR, CMT BL, CMT BR, Correct Response " + vbCrLf, True)

        Me.ChooseSampleImage()
        GlobalVariables.SampleTime.Start()
        Sample.Show()
        Me.Hide()
    End Sub
End Class