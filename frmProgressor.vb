Public Class frmProgressor
    Dim nCycles As Long = 2500
    Dim ProgSpeed As Long
    Dim ProgSteps As Integer
    Dim CurStep As Integer
    Dim ChordDegs() As String

    Private Sub frmProgressor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbProgressions.SelectedIndex = 0

    End Sub
    Private Sub cbProgressions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProgressions.SelectedIndexChanged
        cbProgList.SelectedIndex = cbProgressions.SelectedIndex
    End Sub

    Private Sub cbProgList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProgList.SelectedIndexChanged
        cbProgressions.SelectedIndex = cbProgList.SelectedIndex
    End Sub

    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click

        ChordDegs = Split(txtProg.Text, ",")
        ProgSteps = UBound(ChordDegs)

        nCycles = txtCycles.Text
        CurStep = 0
        ProgSpeed = (60000 / Val(txtSpeed.Text))

        Timer1.Interval = ProgSpeed
        Timer1.Enabled = True

    End Sub

    Private Sub cmdStop_Click(sender As Object, e As EventArgs) Handles cmdStop.Click
        Timer1.Enabled = False
    End Sub

    Private Sub txtCycles_TextChanged(sender As Object, e As EventArgs) Handles txtCycles.TextChanged
        nCycles = txtCycles.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim ChordToShow As Integer

        Me.Text = "Progressor: " & nCycles

        nCycles -= 1


        If nCycles = 0 Then
            nCycles = txtCycles.Text
            Timer1.Enabled = False
            Me.Text = "Progressor"
            Exit Sub
        End If

        If CurStep > ProgSteps Then CurStep = 0

        ChordToShow = Str(ChordDegs(CurStep))

        frmTabTool.GenerateChord(ChordToShow)

        CurStep += 1

    End Sub

    Private Sub txtSpeed_TextChanged(sender As Object, e As EventArgs) Handles txtSpeed.TextChanged
        '60,000 / BPM = Timer interval

        ProgSpeed = (60000 / Val(txtSpeed.Text)) * 4 '60,000 ms over BPM is one tick per second, x 4 makes it a 4 times slower than the bpm

    End Sub
End Class