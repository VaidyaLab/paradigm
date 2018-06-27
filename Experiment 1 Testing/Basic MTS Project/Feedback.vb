Public Class Feedback
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Introduction.ChooseSampleImage()

        'Start Sample Timer
        GlobalVariables.SampleTime.Start()
        If (GlobalVariables.count = 120) Then
            Me.Close()
            Application.Exit()
        End If

        Sample.Show()
        Me.Close()
    End Sub
End Class