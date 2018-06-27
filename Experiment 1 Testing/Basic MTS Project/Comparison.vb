Public Class Comparison        'Add Correct Values for each Comparison Image
    'Checks to See If Participant's Selection from the Comparison Array is Correct
    Private Sub ClickOne(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If (GlobalVariables.randomnumber = GlobalVariables.CompOne) Then
            GlobalVariables.CorrectResponse = 1
            GlobalVariables.count += 1
        Else
            GlobalVariables.CorrectResponse = 0
            GlobalVariables.count += 1
        End If

        ComparisonDone()
    End Sub

    Private Sub ClickTwo(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If (GlobalVariables.randomnumber = GlobalVariables.CompTwo) Then
            GlobalVariables.CorrectResponse = 1
            GlobalVariables.count += 1
        Else
            GlobalVariables.CorrectResponse = 0
            GlobalVariables.count += 1
        End If

        ComparisonDone()
    End Sub

    Private Sub ClickThree(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If (GlobalVariables.randomnumber = GlobalVariables.CompThree) Then
            GlobalVariables.CorrectResponse = 1
            GlobalVariables.count += 1
        Else
            GlobalVariables.CorrectResponse = 0
            GlobalVariables.count += 1
        End If

        ComparisonDone()
    End Sub

    Private Sub ComparisonDone()
        'Reset Stopwatch and add stopwatch info
        GlobalVariables.ComparisonTime.Stop()
        GlobalVariables.et = GlobalVariables.ComparisonTime.Elapsed
        GlobalVariables.timestring = String.Format("{0:N5}", GlobalVariables.et.TotalSeconds)
        GlobalVariables.ComparisonTime.Reset()

        'Add Info to File
        My.Computer.FileSystem.WriteAllText("C://ParticipantData/participantdata.txt", GlobalVariables.randomtwo.ToString + ", " + GlobalVariables.timestring + ", " + GlobalVariables.CorrectResponse.ToString + vbCrLf, True)

        Feedback.Show()
        Me.Hide()
    End Sub
End Class