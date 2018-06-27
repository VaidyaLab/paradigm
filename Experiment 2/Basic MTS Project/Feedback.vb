Public Class Feedback
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Introduction.ChooseSampleImage()

        'If Participant has gotten 8/10 correct in 3 consecutive blocks, the application finishes
        If (GlobalVariables.count2 = 10) Then
            If GlobalVariables.count <= 7 Then GlobalVariables.count3 = 0
            If GlobalVariables.count >= 8 Then GlobalVariables.count3 += 1

            If (GlobalVariables.count3 = 3) Then
                Me.Close()
                Application.Exit()
            End If

            GlobalVariables.count = 0
            GlobalVariables.count2 = 0
        End If

        'Disable Continue Button on Sample Screen
        Sample.Mask1.Visible = True

        'Start Sample Timer
        GlobalVariables.SampleTime.Start()
        Sample.Show()
        Me.Close()
    End Sub
End Class