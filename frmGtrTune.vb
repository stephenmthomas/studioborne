Public Class frmGtrTune

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        Dim HelpMsg As String

        HelpMsg = ""
        HelpMsg += "You can tune the fretboard here.  Note that a usable tuning should be comma separate notes.  The tuning also determines how many strings the fretboard has."
        HelpMsg += vbNewLine & vbNewLine
        HelpMsg += "Example: Standard Guitar Tuning is E,A,D,G,B,E." & vbNewLine & vbNewLine
        HelpMsg += "Because there are six letters, Studioborne knows there are six strings." & vbNewLine & vbNewLine
        HelpMsg += "Likewise, a standard tuned 5 string bass would be: E,A,D,G,B"

        MsgBox(HelpMsg, vbInformation, "Help")

    End Sub

    Private Sub frmGtrTune_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbTune.SelectedIndex = 47

        txtCurTune.Text = Tuning

        If cbTuning.Items.Contains(txtCurTune.Text) Then
            cbTuning.SelectedIndex = cbTuning.FindStringExact(txtCurTune.Text)
            cbTune.SelectedIndex = cbTuning.SelectedIndex
        End If
    End Sub

    Private Sub cbTune_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTune.SelectedIndexChanged
        cbTuning.SelectedIndex = cbTune.SelectedIndex

    End Sub

    Private Sub cbTuning_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTuning.SelectedIndexChanged
        txtNewTune.Text = cbTuning.Text
    End Sub

    Private Sub txtNewTune_TextChanged(sender As Object, e As EventArgs) Handles txtNewTune.TextChanged
        Dim TuningNotes() As String
        Dim StringCount As Integer

        On Error GoTo ErrHandler

        TuningNotes = Split(txtNewTune.Text, ",")
        StringCount = UBound(TuningNotes) + 1

        txtStrings.Text = StringCount

        If Val(txtStrings.Text) > 6 Then
            MsgBox("You've selected a tuning with more than 6 strings. Unfortunately, Studioborne's fretboard does not currently draw more than 6 strings.", vbInformation, "Yeet!")
        End If

        Exit Sub
ErrHandler:

        MsgBox("There appears to be an issue with the tuning.  Be sure the tuning is comma separated notes." & vbNewLine & vbNewLine & "Example: E,A,D,G,B,E", vbCritical, "Ooops!")
        cbTune.SelectedIndex = 47

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdAccept_Click(sender As Object, e As EventArgs) Handles cmdAccept.Click
        frmOptions.txtTuning.Text = txtNewTune.Text

        If frmFretboard.Visible = True Then
            frmTabTool.DrawFretBoard(CurrentNotes)
            frmFretboard.Text = "Fretboard - " & RootNote & " " & CurrentMode
        End If

        Me.Close()

    End Sub
End Class