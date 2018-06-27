Public Class Feedback2
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If Participant has gotten 5/10 correct, then the application moves to the second section
        If GlobalVariables.count = 5 Then
            'Start Sample Timer
            GlobalVariables.SampleTime.Start()

            'Move to Next Phase
            Introduction.Show()
            Me.Close()
            Sample2.Close()
        Else
            'Next Trial
            Introduction2.ChooseSampleImage()

            'Start Sample Timer
            GlobalVariables.SampleTime.Start()

            'Move to Next Phase
            Sample2.Show()
            Me.Close()
        End If
    End Sub
End Class