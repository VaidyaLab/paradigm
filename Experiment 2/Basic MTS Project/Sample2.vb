Public Class Sample2
    Private Property Form1 As Object

    Public Sub ChooseComparisonImages()
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6. 
        GlobalVariables.randomtwo = CInt(Int((3 * Rnd()) + 1))

        'Choose Sample
        Select Case GlobalVariables.randomnumber
            Case 1
                Comparison2.PictureBox1.Image = Global.Experiment_2.My.Resources.Resources.A1
            Case 2
                Comparison2.PictureBox1.Image = Global.Experiment_2.My.Resources.Resources.A2
            Case 3
                Comparison2.PictureBox1.Image = Global.Experiment_2.My.Resources.Resources.A3
                '            Case 4
                '                Comparison.PictureBox1.Image = Global.Simple_Sample_Mask.My.Resources.Resources.A4
                '            Case 5
                '                Comparison.PictureBox1.Image = Global.Simple_Sample_Mask.My.Resources.Resources.A5
                '            Case 6
                '                Comparison.PictureBox1.Image = Global.Simple_Sample_Mask.My.Resources.Resources.A6
        End Select

        'Choose Comparisons
        Select Case GlobalVariables.randomnumber
            Case 1 To 3
                Select Case GlobalVariables.randomtwo
                    Case 1
                        Comparison2.PictureBox2.Image = Global.Experiment_2.My.Resources.Resources.B1
                        Comparison2.PictureBox3.Image = Global.Experiment_2.My.Resources.Resources.B2
                        Comparison2.PictureBox4.Image = Global.Experiment_2.My.Resources.Resources.B3
                        GlobalVariables.CompOne = 1
                        GlobalVariables.CompTwo = 2
                        GlobalVariables.CompThree = 3
                    Case 2
                        Comparison2.PictureBox2.Image = Global.Experiment_2.My.Resources.Resources.B1
                        Comparison2.PictureBox3.Image = Global.Experiment_2.My.Resources.Resources.B3
                        Comparison2.PictureBox4.Image = Global.Experiment_2.My.Resources.Resources.B2
                        GlobalVariables.CompOne = 1
                        GlobalVariables.CompTwo = 3
                        GlobalVariables.CompThree = 2
                    Case 3
                        Comparison2.PictureBox2.Image = Global.Experiment_2.My.Resources.Resources.B2
                        Comparison2.PictureBox3.Image = Global.Experiment_2.My.Resources.Resources.B1
                        Comparison2.PictureBox4.Image = Global.Experiment_2.My.Resources.Resources.B3
                        GlobalVariables.CompOne = 2
                        GlobalVariables.CompTwo = 1
                        GlobalVariables.CompThree = 3
                    Case 4
                        Comparison2.PictureBox2.Image = Global.Experiment_2.My.Resources.Resources.B2
                        Comparison2.PictureBox3.Image = Global.Experiment_2.My.Resources.Resources.B3
                        Comparison2.PictureBox4.Image = Global.Experiment_2.My.Resources.Resources.B1
                        GlobalVariables.CompOne = 2
                        GlobalVariables.CompTwo = 3
                        GlobalVariables.CompThree = 1
                    Case 5
                        Comparison2.PictureBox2.Image = Global.Experiment_2.My.Resources.Resources.B3
                        Comparison2.PictureBox3.Image = Global.Experiment_2.My.Resources.Resources.B1
                        Comparison2.PictureBox4.Image = Global.Experiment_2.My.Resources.Resources.B2
                        GlobalVariables.CompOne = 3
                        GlobalVariables.CompTwo = 1
                        GlobalVariables.CompThree = 2
                    Case 6
                        Comparison2.PictureBox2.Image = Global.Experiment_2.My.Resources.Resources.B3
                        Comparison2.PictureBox3.Image = Global.Experiment_2.My.Resources.Resources.B2
                        Comparison2.PictureBox4.Image = Global.Experiment_2.My.Resources.Resources.B1
                        GlobalVariables.CompOne = 3
                        GlobalVariables.CompTwo = 2
                        GlobalVariables.CompThree = 1
                End Select
        End Select
    End Sub

    Private Sub ContinueClick(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.ChooseComparisonImages()

        'Reset Stopwatch and add stopwatch info
        GlobalVariables.SampleTime.Stop()
        GlobalVariables.et = GlobalVariables.SampleTime.Elapsed
        GlobalVariables.timestring = String.Format("{0:N5}", GlobalVariables.et.TotalSeconds)
        GlobalVariables.SampleTime.Reset()

        'Add Info to File
        My.Computer.FileSystem.WriteAllText("C://ParticipantData/participantdata.txt", GlobalVariables.randomnumber.ToString + ", " + GlobalVariables.timestring + ", ", True)

        'Start Comparison Timer
        GlobalVariables.ComparisonTime.Start()

        'Start Comparison Form
        Comparison2.Show()
        Me.Close()
    End Sub
End Class