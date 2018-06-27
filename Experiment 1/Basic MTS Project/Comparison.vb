Public Class Comparison        'Add Correct Values for each Comparison Image
    'Checks to See If Participant's Selection from the Comparison Array is Correct
    Private Sub ClickOne(sender As Object, e As EventArgs) Handles PictureBox2.Click
        GlobalVariables.count2 += 1
        If (GlobalVariables.randomnumber = GlobalVariables.CompOne) Then
            GlobalVariables.CorrectResponse = 1
            Feedback.TextBox1.Text = "Correct"
            GlobalVariables.count += 1
        Else
            GlobalVariables.CorrectResponse = 0
            Feedback.TextBox1.Text = "Incorrect"
        End If

        ComparisonDone()
    End Sub

    Private Sub ClickTwo(sender As Object, e As EventArgs) Handles PictureBox3.Click
        GlobalVariables.count2 += 1
        If (GlobalVariables.randomnumber = GlobalVariables.CompTwo) Then
            GlobalVariables.CorrectResponse = 1
            Feedback.TextBox1.Text = "Correct"
            GlobalVariables.count += 1
        Else
            GlobalVariables.CorrectResponse = 0
            Feedback.TextBox1.Text = "Incorrect"
        End If

        ComparisonDone()
    End Sub

    Private Sub ClickThree(sender As Object, e As EventArgs) Handles PictureBox4.Click
        GlobalVariables.count2 += 1
        If (GlobalVariables.randomnumber = GlobalVariables.CompThree) Then
            GlobalVariables.CorrectResponse = 1
            Feedback.TextBox1.Text = "Correct"
            GlobalVariables.count += 1
        Else
            GlobalVariables.CorrectResponse = 0
            Feedback.TextBox1.Text = "Incorrect"
        End If

        ComparisonDone()
    End Sub

    Private Sub ComparisonDone()
        'Reset Stopwatch and add stopwatch info
        GlobalVariables.ComparisonTime.Stop()
        GlobalVariables.et = GlobalVariables.ComparisonTime.Elapsed
        GlobalVariables.timestring = String.Format("{0:N5}", GlobalVariables.et.TotalSeconds)
        GlobalVariables.et = GlobalVariables.ComparisonMaskTime.Elapsed
        GlobalVariables.timestring2 = String.Format("{0:N5}", GlobalVariables.et.TotalSeconds)
        GlobalVariables.et = GlobalVariables.CMTTR.Elapsed
        GlobalVariables.timestring3 = String.Format("{0:N5}", GlobalVariables.et.TotalSeconds)
        GlobalVariables.et = GlobalVariables.CMTBL.Elapsed
        GlobalVariables.timestring4 = String.Format("{0:N5}", GlobalVariables.et.TotalSeconds)
        GlobalVariables.et = GlobalVariables.CMTBR.Elapsed
        GlobalVariables.timestring5 = String.Format("{0:N5}", GlobalVariables.et.TotalSeconds)
        GlobalVariables.ComparisonTime.Reset()
        GlobalVariables.ComparisonMaskTime.Reset()
        GlobalVariables.CMTTR.Reset()
        GlobalVariables.CMTBL.Reset()
        GlobalVariables.CMTBR.Reset()

        GlobalVariables.QuadTime.Stop()
        GlobalVariables.times(GlobalVariables.poscnt) = GlobalVariables.QuadTime.Elapsed
        GlobalVariables.QuadTime.Reset()

        'Add Info to File
        My.Computer.FileSystem.WriteAllText("C://ParticipantData/participantdata.txt", GlobalVariables.randomtwo.ToString + ", " + GlobalVariables.timestring + ", " + GlobalVariables.timestring2 + ", " + GlobalVariables.timestring3 + ", " + GlobalVariables.timestring4 + ", " + GlobalVariables.timestring5 + ", " + GlobalVariables.CorrectResponse.ToString + vbCrLf, True)
        For index As Integer = 0 To GlobalVariables.poscnt - 1
            My.Computer.FileSystem.WriteAllText("C://ParticipantData/patterncomp.txt", GlobalVariables.position(index).ToString + ", ", True)
        Next
        My.Computer.FileSystem.WriteAllText("C://ParticipantData/patterncomp.txt", vbCrLf, True)

        For index2 As Integer = 1 To GlobalVariables.poscnt
            GlobalVariables.qutstring = String.Format("{0:N5}", GlobalVariables.times(index2).TotalSeconds)
            My.Computer.FileSystem.WriteAllText("C://ParticipantData/timecomp.txt", GlobalVariables.qutstring + ", ", True)
        Next
        My.Computer.FileSystem.WriteAllText("C://ParticipantData/timecomp.txt", vbCrLf, True)

        'Reset position counter
        GlobalVariables.poscnt = 0

        Feedback.Show()
        Me.Hide()
    End Sub

    Private Sub MaskReveal5(sender As Object, e As EventArgs) Handles MaskTL.MouseEnter
        MaskTL.Visible = False
        GlobalVariables.ComparisonMaskTime.Start()
        GlobalVariables.position(GlobalVariables.poscnt) = 1

        GlobalVariables.QuadTime.Stop()
        GlobalVariables.times(GlobalVariables.poscnt) = GlobalVariables.QuadTime.Elapsed
        GlobalVariables.QuadTime.Reset()
        GlobalVariables.QuadTime.Start()

        GlobalVariables.poscnt += 1
    End Sub

    Private Sub MaskReveal6(sender As Object, e As EventArgs) Handles MaskTR.MouseEnter
        MaskTR.Visible = False
        GlobalVariables.CMTTR.Start()
        GlobalVariables.position(GlobalVariables.poscnt) = 2

        GlobalVariables.QuadTime.Stop()
        GlobalVariables.times(GlobalVariables.poscnt) = GlobalVariables.QuadTime.Elapsed
        GlobalVariables.QuadTime.Reset()
        GlobalVariables.QuadTime.Start()

        GlobalVariables.poscnt += 1
    End Sub

    Private Sub MaskReveal7(sender As Object, e As EventArgs) Handles MaskBL.MouseEnter
        MaskBL.Visible = False
        GlobalVariables.CMTBL.Start()
        GlobalVariables.position(GlobalVariables.poscnt) = 3

        GlobalVariables.QuadTime.Stop()
        GlobalVariables.times(GlobalVariables.poscnt) = GlobalVariables.QuadTime.Elapsed
        GlobalVariables.QuadTime.Reset()
        GlobalVariables.QuadTime.Start()

        GlobalVariables.poscnt += 1
    End Sub

    Private Sub MaskReveal8(sender As Object, e As EventArgs) Handles MaskBR.MouseEnter
        MaskBR.Visible = False
        GlobalVariables.CMTBR.Start()
        GlobalVariables.position(GlobalVariables.poscnt) = 4

        GlobalVariables.QuadTime.Stop()
        GlobalVariables.times(GlobalVariables.poscnt) = GlobalVariables.QuadTime.Elapsed
        GlobalVariables.QuadTime.Reset()
        GlobalVariables.QuadTime.Start()

        GlobalVariables.poscnt += 1
    End Sub

    Private Sub MaskRevealalt2(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        If (MaskTL.Visible = False) Then
            GlobalVariables.ComparisonMaskTime.Start()
            GlobalVariables.CMTTR.Stop()
            GlobalVariables.CMTBL.Stop()
            GlobalVariables.CMTBR.Stop()
            MaskTL.Visible = False
        End If

        If (MaskTR.Visible = False) Then
            GlobalVariables.ComparisonMaskTime.Stop()
            GlobalVariables.CMTTR.Start()
            GlobalVariables.CMTBL.Stop()
            GlobalVariables.CMTBR.Stop()
            MaskTR.Visible = False
        End If

        If (MaskBL.Visible = False) Then
            GlobalVariables.ComparisonMaskTime.Stop()
            GlobalVariables.CMTTR.Stop()
            GlobalVariables.CMTBL.Start()
            GlobalVariables.CMTBR.Stop()
            MaskBL.Visible = False
        End If

        If (MaskBR.Visible = False) Then
            GlobalVariables.ComparisonMaskTime.Stop()
            GlobalVariables.CMTTR.Stop()
            GlobalVariables.CMTBL.Stop()
            GlobalVariables.CMTBR.Start()
            MaskBR.Visible = False
        End If
    End Sub

    Private Sub MaskHide(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        MaskTL.Visible = True
        MaskTR.Visible = True
        MaskBL.Visible = True
        MaskBR.Visible = True
        GlobalVariables.ComparisonMaskTime.Stop()
        GlobalVariables.CMTTR.Stop()
        GlobalVariables.CMTBL.Stop()
        GlobalVariables.CMTBR.Stop()
    End Sub
End Class