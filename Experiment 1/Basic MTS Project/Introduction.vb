Public Class GlobalVariables
    Public Shared CompOne As Integer
    Public Shared CompTwo As Integer
    Public Shared CompThree As Integer
    Public Shared CorrectResponse As Integer
    Public Shared randomnumber As Integer
    Public Shared count As Integer
    Public Shared count2 As Integer
    Public Shared count3 As Integer
    Public Shared randomtwo As Integer
    Public Shared SampleTime As New Stopwatch
    Public Shared ComparisonTime As New Stopwatch
    Public Shared et As TimeSpan
    Public Shared timestring As String
    Public Shared timestring2 As String
    Public Shared timestring3 As String
    Public Shared timestring4 As String
    Public Shared timestring5 As String
    Public Shared qutstring As String
    Public Shared SampleImage
    Public Shared SampleMaskTime As New Stopwatch
    Public Shared SMTTR As New Stopwatch
    Public Shared SMTBL As New Stopwatch
    Public Shared SMTBR As New Stopwatch
    Public Shared ComparisonMaskTime As New Stopwatch
    Public Shared CMTTR As New Stopwatch
    Public Shared CMTBL As New Stopwatch
    Public Shared CMTBR As New Stopwatch
    Public Shared position(99) As Integer
    Public Shared poscnt As Integer
    Public Shared A1cnt As Integer
    Public Shared A2cnt As Integer
    Public Shared A3cnt As Integer
    Public Shared QuadTime As New Stopwatch
    Public Shared times(99) As TimeSpan
End Class

Public Class Introduction
    Public count As Integer = 0
    Public count2 As Integer = 0
    Public count3 As Integer = 0
    Public poscnt As Integer = 0
    Public A1cnt As Integer = 0
    Public A2cnt As Integer = 0
    Public A3cnt As Integer = 0

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub ChooseSampleImage()
        If A1cnt = 2 And A2cnt = 2 And A3cnt = 2 Then
            A1cnt = 0
            A2cnt = 0
            A3cnt = 0
        End If

        ' Initialize the random-number generator.
        Randomize()
        ' Generate random value between 1 and 3. 
        GlobalVariables.randomnumber = CInt(Int((3 * Rnd()) + 1))

        If A1cnt = 2 Then
            If A2cnt < 2 And A3cnt < 2 Then
                ' Generate random value between 2 and 3.
                GlobalVariables.randomnumber = CInt(Int((2 * Rnd()) + 2))
            ElseIf A2cnt = 2 Then
                GlobalVariables.randomnumber = 3
            ElseIf A3cnt = 2 Then
                GlobalVariables.randomnumber = 2
            End If
        End If

        'Only Run If A1 Isn't At Two Yet
        If A2cnt = 2 And A1cnt < 2 Then
            If A3cnt < 2 Then
                ' Generate random value between 1 and 2. 
                GlobalVariables.randomnumber = CInt(Int((2 * Rnd()) + 1))
                'If random number is 2 then make it 3
                If GlobalVariables.randomnumber = 2 Then GlobalVariables.randomnumber += 1
            Else
                GlobalVariables.randomnumber = 1
            End If
        End If

        'Only Run If A1 and A2 Aren't At Two Yet
        If A3cnt = 2 And A1cnt < 2 And A2cnt < 2 Then
            ' Generate random value between 1 and 2. 
            GlobalVariables.randomnumber = CInt(Int((2 * Rnd()) + 1))
        End If

        'Choose Image
        Select Case GlobalVariables.randomnumber
            Case 1
                Sample.PictureBox1.Image = Global.Compound_Sample_Mask.My.Resources.Resources.A4
                A1cnt += 1
            Case 2
                Sample.PictureBox1.Image = Global.Compound_Sample_Mask.My.Resources.Resources.A5
                A2cnt += 1
            Case 3
                Sample.PictureBox1.Image = Global.Compound_Sample_Mask.My.Resources.Resources.A6
                A3cnt += 1
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

        My.Computer.FileSystem.WriteAllText("C://ParticipantData/participantdata.txt", "Sample Image, Sample Timer, SMT TL, SMT TR, SMT BL, SMT BR, Comparison Response, Comparison Timer, CMT TL, CMT TR, CMT BL, CMT BR, Correct Response " + vbCrLf, True)

        Me.ChooseSampleImage()
        GlobalVariables.SampleTime.Start()
        Sample.Show()
        Me.Hide()
    End Sub
End Class