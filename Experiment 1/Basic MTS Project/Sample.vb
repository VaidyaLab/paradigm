Public Class Sample
    Private Property Form1 As Object

    Public Sub ChooseComparisonImages()
        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 6. 
        GlobalVariables.randomtwo = CInt(Int((3 * Rnd()) + 1))

        'Choose Sample
        Select Case GlobalVariables.randomnumber
            Case 1
                Comparison.PictureBox1.Image = Global.Compound_Sample_Mask.My.Resources.Resources.A4
            Case 2
                Comparison.PictureBox1.Image = Global.Compound_Sample_Mask.My.Resources.Resources.A5
            Case 3
                Comparison.PictureBox1.Image = Global.Compound_Sample_Mask.My.Resources.Resources.A6
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
                        Comparison.PictureBox2.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B4
                        Comparison.PictureBox3.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B5
                        Comparison.PictureBox4.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B6
                        GlobalVariables.CompOne = 1
                        GlobalVariables.CompTwo = 2
                        GlobalVariables.CompThree = 3
                    Case 2
                        Comparison.PictureBox2.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B4
                        Comparison.PictureBox3.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B6
                        Comparison.PictureBox4.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B5
                        GlobalVariables.CompOne = 1
                        GlobalVariables.CompTwo = 3
                        GlobalVariables.CompThree = 2
                    Case 3
                        Comparison.PictureBox2.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B5
                        Comparison.PictureBox3.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B4
                        Comparison.PictureBox4.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B6
                        GlobalVariables.CompOne = 2
                        GlobalVariables.CompTwo = 1
                        GlobalVariables.CompThree = 3
                    Case 4
                        Comparison.PictureBox2.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B5
                        Comparison.PictureBox3.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B6
                        Comparison.PictureBox4.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B4
                        GlobalVariables.CompOne = 2
                        GlobalVariables.CompTwo = 3
                        GlobalVariables.CompThree = 1
                    Case 5
                        Comparison.PictureBox2.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B6
                        Comparison.PictureBox3.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B4
                        Comparison.PictureBox4.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B5
                        GlobalVariables.CompOne = 3
                        GlobalVariables.CompTwo = 1
                        GlobalVariables.CompThree = 2
                    Case 6
                        Comparison.PictureBox2.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B6
                        Comparison.PictureBox3.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B5
                        Comparison.PictureBox4.Image = Global.Compound_Sample_Mask.My.Resources.Resources.B4
                        GlobalVariables.CompOne = 3
                        GlobalVariables.CompTwo = 2
                        GlobalVariables.CompThree = 1
                End Select
                '            Case 4 To 6
                '                Select Case GlobalVariables.randomtwo
                '            Case 1
                '                Comparison.PictureBox2.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B4
                '                Comparison.PictureBox3.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B5
                '                Comparison.PictureBox4.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B6
                '                GlobalVariables.CompOne = 4
                '                GlobalVariables.CompTwo = 5
                '                GlobalVariables.CompThree = 6
                '            Case 2
                '                Comparison.PictureBox2.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B4
                '                Comparison.PictureBox3.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B6
                '                Comparison.PictureBox4.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B5
                '                GlobalVariables.CompOne = 4
                '                GlobalVariables.CompTwo = 6
                '                GlobalVariables.CompThree = 5
                '            Case 3
                '                Comparison.PictureBox2.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B5
                '                Comparison.PictureBox3.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B4
                '                Comparison.PictureBox4.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B6
                '                GlobalVariables.CompOne = 5
                '                GlobalVariables.CompTwo = 4
                '                GlobalVariables.CompThree = 6
                '            Case 4
                '                Comparison.PictureBox2.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B5
                '                Comparison.PictureBox3.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B6
                '                Comparison.PictureBox4.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B4
                '                GlobalVariables.CompOne = 5
                '                GlobalVariables.CompTwo = 6
                '                GlobalVariables.CompThree = 4
                '            Case 5
                '                Comparison.PictureBox2.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B6
                '                Comparison.PictureBox3.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B4
                '                Comparison.PictureBox4.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B5
                '                GlobalVariables.CompOne = 6
                '                GlobalVariables.CompTwo = 4
                '                GlobalVariables.CompThree = 5
                '            Case 6
                '                Comparison.PictureBox2.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B6
                '                Comparison.PictureBox3.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B5
                '                Comparison.PictureBox4.Image = Global.Simple_Sample_Mask.My.Resources.Resources.B4
                '                GlobalVariables.CompOne = 6
                '                GlobalVariables.CompTwo = 5
                '                GlobalVariables.CompThree = 4
                '        End Select
        End Select
    End Sub


    Private Sub ContinueClick(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.ChooseComparisonImages()

        'Reset Stopwatch and add stopwatch info
        GlobalVariables.SampleTime.Stop()
        GlobalVariables.et = GlobalVariables.SampleTime.Elapsed
        GlobalVariables.timestring = String.Format("{0:N5}", GlobalVariables.et.TotalSeconds)
        GlobalVariables.et = GlobalVariables.SampleMaskTime.Elapsed
        GlobalVariables.timestring2 = String.Format("{0:N5}", GlobalVariables.et.TotalSeconds)
        GlobalVariables.et = GlobalVariables.SMTTR.Elapsed
        GlobalVariables.timestring3 = String.Format("{0:N5}", GlobalVariables.et.TotalSeconds)
        GlobalVariables.et = GlobalVariables.SMTBL.Elapsed
        GlobalVariables.timestring4 = String.Format("{0:N5}", GlobalVariables.et.TotalSeconds)
        GlobalVariables.et = GlobalVariables.SMTBR.Elapsed
        GlobalVariables.timestring5 = String.Format("{0:N5}", GlobalVariables.et.TotalSeconds)
        GlobalVariables.SampleTime.Reset()
        GlobalVariables.SampleMaskTime.Reset()
        GlobalVariables.SMTTR.Reset()
        GlobalVariables.SMTBL.Reset()
        GlobalVariables.SMTBR.Reset()

        GlobalVariables.QuadTime.Stop()
        GlobalVariables.times(GlobalVariables.poscnt) = GlobalVariables.QuadTime.Elapsed
        GlobalVariables.QuadTime.Reset()


        'Add Info to File
        My.Computer.FileSystem.WriteAllText("C://ParticipantData/participantdata.txt", GlobalVariables.randomnumber.ToString + ", " + GlobalVariables.timestring + ", " + GlobalVariables.timestring2 + ", " + GlobalVariables.timestring3 + ", " + GlobalVariables.timestring4 + ", " + GlobalVariables.timestring5 + ", ", True)
        For index As Integer = 0 To GlobalVariables.poscnt - 1
            My.Computer.FileSystem.WriteAllText("C://ParticipantData/patternsamp.txt", GlobalVariables.position(index).ToString + ", ", True)
        Next
        My.Computer.FileSystem.WriteAllText("C://ParticipantData/patternsamp.txt", vbCrLf, True)

        For index2 As Integer = 1 To GlobalVariables.poscnt
            GlobalVariables.qutstring = String.Format("{0:N5}", GlobalVariables.times(index2).TotalSeconds)
            My.Computer.FileSystem.WriteAllText("C://ParticipantData/timesamp.txt", GlobalVariables.qutstring + ", ", True)
        Next
        My.Computer.FileSystem.WriteAllText("C://ParticipantData/timesamp.txt", vbCrLf, True)

        'Reset position counter
        GlobalVariables.poscnt = 0

        'Start Comparison Timer
        GlobalVariables.ComparisonTime.Start()

        'Start Comparison Form
        Comparison.Show()
        Me.Hide()
    End Sub

    Private Sub MaskReveal(sender As Object, e As EventArgs) Handles Mask1.MouseEnter
        Mask1.Visible = False
        GlobalVariables.SampleMaskTime.Start()
        GlobalVariables.position(GlobalVariables.poscnt) = 1

        GlobalVariables.QuadTime.Stop()
        GlobalVariables.times(GlobalVariables.poscnt) = GlobalVariables.QuadTime.Elapsed
        GlobalVariables.QuadTime.Reset()
        GlobalVariables.QuadTime.Start()

        GlobalVariables.poscnt += 1
    End Sub

    Private Sub MaskRevealalt(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        If (Mask1.Visible = False) Then
            GlobalVariables.SampleMaskTime.Start()
            GlobalVariables.SMTTR.Stop()
            GlobalVariables.SMTBL.Stop()
            GlobalVariables.SMTBR.Stop()
            Mask1.Visible = False
        End If

        If (Mask2.Visible = False) Then
            GlobalVariables.SampleMaskTime.Stop()
            GlobalVariables.SMTTR.Start()
            GlobalVariables.SMTBL.Stop()
            GlobalVariables.SMTBR.Stop()
            Mask2.Visible = False
        End If

        If (Mask3.Visible = False) Then
            GlobalVariables.SampleMaskTime.Stop()
            GlobalVariables.SMTTR.Stop()
            GlobalVariables.SMTBL.Start()
            GlobalVariables.SMTBR.Stop()
            Mask3.Visible = False
        End If

        If (Mask4.Visible = False) Then
            GlobalVariables.SampleMaskTime.Stop()
            GlobalVariables.SMTTR.Stop()
            GlobalVariables.SMTBL.Stop()
            GlobalVariables.SMTBR.Start()
            Mask4.Visible = False
        End If
    End Sub

    Private Sub MaskHide(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Mask1.Visible = True
        Mask2.Visible = True
        Mask3.Visible = True
        Mask4.Visible = True
        GlobalVariables.SampleMaskTime.Stop()
        GlobalVariables.SMTTR.Stop()
        GlobalVariables.SMTBL.Stop()
        GlobalVariables.SMTBR.Stop()
    End Sub

    Private Sub MaskReveal2(sender As Object, e As EventArgs) Handles Mask2.MouseEnter
        Mask2.Visible = False
        GlobalVariables.SMTTR.Start()
        GlobalVariables.position(GlobalVariables.poscnt) = 2

        GlobalVariables.QuadTime.Stop()
        GlobalVariables.times(GlobalVariables.poscnt) = GlobalVariables.QuadTime.Elapsed
        GlobalVariables.QuadTime.Reset()
        GlobalVariables.QuadTime.Start()

        GlobalVariables.poscnt += 1
    End Sub

    Private Sub MaskReveal3(sender As Object, e As EventArgs) Handles Mask3.MouseEnter
        Mask3.Visible = False
        GlobalVariables.SMTBL.Start()
        GlobalVariables.position(GlobalVariables.poscnt) = 3

        GlobalVariables.QuadTime.Stop()
        GlobalVariables.times(GlobalVariables.poscnt) = GlobalVariables.QuadTime.Elapsed
        GlobalVariables.QuadTime.Reset()
        GlobalVariables.QuadTime.Start()

        GlobalVariables.poscnt += 1
    End Sub

    Private Sub MaskReveal4(sender As Object, e As EventArgs) Handles Mask4.MouseEnter
        Mask4.Visible = False
        GlobalVariables.SMTBR.Start()
        GlobalVariables.position(GlobalVariables.poscnt) = 4

        GlobalVariables.QuadTime.Stop()
        GlobalVariables.times(GlobalVariables.poscnt) = GlobalVariables.QuadTime.Elapsed
        GlobalVariables.QuadTime.Reset()
        GlobalVariables.QuadTime.Start()

        GlobalVariables.poscnt += 1
    End Sub
End Class
