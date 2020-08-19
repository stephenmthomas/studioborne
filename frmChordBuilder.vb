Public Class frmChordBuilder
    Dim TempRoot As String 'Temporarily stores the root from the main window here, so that when a chord is built its root is shown in red

    Private Sub cbQuick_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbQuick.SelectedIndexChanged
        cbSymbol.SelectedIndex = cbQuick.SelectedIndex
        cbIntervals.SelectedIndex = cbQuick.SelectedIndex
        txtName.Text = cbRoot.Text & cbSymbol.Text
        txtNotes.Text = GenChordFromCSV(cbRoot.Text, cbIntervals.Text)

        If chkAutoDisplay.Checked = True Then
            TempRoot = RootNote
            RootNote = cbRoot.Text
            frmTabTool.DrawKeyboard(txtNotes.Text)
            frmTabTool.DrawFretBoard(txtNotes.Text)
            RootNote = TempRoot
        End If
    End Sub

    Private Sub cbSymbol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSymbol.SelectedIndexChanged
        cbQuick.SelectedIndex = cbSymbol.SelectedIndex

    End Sub

    Private Sub frmChordBuilder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbQuick.SelectedIndex = 0
        cbRoot.SelectedIndex = 3

    End Sub

    Private Sub cbIntervals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIntervals.SelectedIndexChanged
        cbQuick.SelectedIndex = cbIntervals.SelectedIndex
    End Sub

    Private Sub cbRoot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRoot.SelectedIndexChanged

        txtName.Text = cbRoot.Text & cbSymbol.Text
        txtNotes.Text = GenChordFromCSV(cbRoot.Text, cbIntervals.Text)

        If chkAutoDisplay.Checked = True Then
            TempRoot = RootNote
            RootNote = cbRoot.Text
            frmTabTool.DrawKeyboard(txtNotes.Text)
            frmTabTool.DrawFretBoard(txtNotes.Text)
            RootNote = TempRoot
        End If
    End Sub

    Private Sub cmdShow_Click(sender As Object, e As EventArgs) Handles cmdShow.Click

        TempRoot = RootNote
        RootNote = cbRoot.Text
        frmTabTool.DrawKeyboard(txtNotes.Text)
        frmTabTool.DrawFretBoard(txtNotes.Text)
        RootNote = TempRoot
    End Sub

    Private Sub txtNotes_TextChanged(sender As Object, e As EventArgs) Handles txtNotes.TextChanged

    End Sub

    Private Sub chkOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnTop.CheckedChanged
        Me.TopMost = chkOnTop.Checked
    End Sub
End Class