Public Class Sample
    Private Property Form1 As Object

    Public Sub ChooseComparisonImages()
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6. 
        GlobalVariables.randomtwo = CInt(Int((6 * Rnd()) + 1))

        Select Case GlobalVariables.locate
            Case 0
                'Choose Top Left Image
                Select Case GlobalVariables.randomnumber
                    Case 1
                        Comparison.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A1TLR
                    Case 2
                        Comparison.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A2TLR
                    Case 3
                        Comparison.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A3TLR
                End Select
            Case 1
                'Choose Top Right Image
                Select Case GlobalVariables.randomnumber
                    Case 1
                        Comparison.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A1TRR
                    Case 2
                        Comparison.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A2TRR
                    Case 3
                        Comparison.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A3TRR
                End Select
            Case 2
                'Choose Bottom Left Image
                Select Case GlobalVariables.randomnumber
                    Case 1
                        Comparison.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A1BLR
                    Case 2
                        Comparison.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A2BLR
                    Case 3
                        Comparison.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A3BLR
                End Select
            Case 3
                'Choose Bottom Right Image
                Select Case GlobalVariables.randomnumber
                    Case 1
                        Comparison.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A1BRR
                    Case 2
                        Comparison.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A2BRR
                    Case 3
                        Comparison.PictureBox1.Image = Global.FT_MTS.My.Resources.Resources.A3BRR
                End Select
        End Select

        'Choose Comparisons
        Select Case GlobalVariables.randomnumber
            Case 1 To 6
                Select Case GlobalVariables.randomtwo
                    Case 1
                        Comparison.PictureBox2.Image = Global.FT_MTS.My.Resources.Resources.B1
                        Comparison.PictureBox3.Image = Global.FT_MTS.My.Resources.Resources.B2
                        Comparison.PictureBox4.Image = Global.FT_MTS.My.Resources.Resources.B3
                        GlobalVariables.CompOne = 1
                        GlobalVariables.CompTwo = 2
                        GlobalVariables.CompThree = 3
                    Case 2
                        Comparison.PictureBox2.Image = Global.FT_MTS.My.Resources.Resources.B1
                        Comparison.PictureBox3.Image = Global.FT_MTS.My.Resources.Resources.B3
                        Comparison.PictureBox4.Image = Global.FT_MTS.My.Resources.Resources.B2
                        GlobalVariables.CompOne = 1
                        GlobalVariables.CompTwo = 3
                        GlobalVariables.CompThree = 2
                    Case 3
                        Comparison.PictureBox2.Image = Global.FT_MTS.My.Resources.Resources.B2
                        Comparison.PictureBox3.Image = Global.FT_MTS.My.Resources.Resources.B1
                        Comparison.PictureBox4.Image = Global.FT_MTS.My.Resources.Resources.B3
                        GlobalVariables.CompOne = 2
                        GlobalVariables.CompTwo = 1
                        GlobalVariables.CompThree = 3
                    Case 4
                        Comparison.PictureBox2.Image = Global.FT_MTS.My.Resources.Resources.B2
                        Comparison.PictureBox3.Image = Global.FT_MTS.My.Resources.Resources.B3
                        Comparison.PictureBox4.Image = Global.FT_MTS.My.Resources.Resources.B1
                        GlobalVariables.CompOne = 2
                        GlobalVariables.CompTwo = 3
                        GlobalVariables.CompThree = 1
                    Case 5
                        Comparison.PictureBox2.Image = Global.FT_MTS.My.Resources.Resources.B3
                        Comparison.PictureBox3.Image = Global.FT_MTS.My.Resources.Resources.B1
                        Comparison.PictureBox4.Image = Global.FT_MTS.My.Resources.Resources.B2
                        GlobalVariables.CompOne = 3
                        GlobalVariables.CompTwo = 1
                        GlobalVariables.CompThree = 2
                    Case 6
                        Comparison.PictureBox2.Image = Global.FT_MTS.My.Resources.Resources.B3
                        Comparison.PictureBox3.Image = Global.FT_MTS.My.Resources.Resources.B2
                        Comparison.PictureBox4.Image = Global.FT_MTS.My.Resources.Resources.B1
                        GlobalVariables.CompOne = 3
                        GlobalVariables.CompTwo = 2
                        GlobalVariables.CompThree = 1
                End Select
        End Select
    End Sub


    Private Sub SampleClick(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.ChooseComparisonImages()

        'Reset Stopwatch and add stopwatch info
        GlobalVariables.SampleTime.Stop()
        GlobalVariables.et = GlobalVariables.SampleTime.Elapsed
        GlobalVariables.timestring = String.Format("{0:N5}", GlobalVariables.et.TotalSeconds)
        GlobalVariables.SampleTime.Reset()

        'Add Info to File
        My.Computer.FileSystem.WriteAllText("C://ParticipantData/participantdata.txt", GlobalVariables.randomnumber.ToString + ", " + GlobalVariables.locate.ToString + ", " + GlobalVariables.timestring + ", ", True)

        'Start Comparison Timer
        GlobalVariables.ComparisonTime.Start()

        'Start Comparison Form
        Comparison.Show()
        Me.Hide()
    End Sub
End Class
