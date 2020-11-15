Public Class frmInfo


    Private Sub frmInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtChord.Text = CurrentChord
        txtVals.Text = CurrentSemitones
        txtNotes.Text = CurrentNotes
        cbInt.SelectedIndex = frmTabTool.cbInt.SelectedIndex
        cbKey.SelectedIndex = frmTabTool.cbKey.SelectedIndex
        cbMode.SelectedIndex = frmTabTool.cbMode.SelectedIndex

    End Sub
End Class