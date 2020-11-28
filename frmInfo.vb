Imports System.ComponentModel

Public Class frmInfo


    Private Sub frmInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtChord.Text = CurrentChord
        txtVals.Text = CurrentSemitones
        txtNotes.Text = CurrentNotes
        cbInt.SelectedIndex = frmTabTool.cbInt.SelectedIndex
        cbKey.SelectedIndex = frmTabTool.cbKey.SelectedIndex
        cbMode.SelectedIndex = frmTabTool.cbMode.SelectedIndex

        chkOnTop.Checked = oOnTop

        If oExpanded = True Then
            Me.Height = 397
            Me.Width = 454
            cmdMaximize.Text = "Shrink"
        Else
            Me.Height = 125
            Me.Width = 454
            cmdMaximize.Text = "Expand"
        End If
    End Sub

    Private Sub chkOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnTop.CheckedChanged
        Me.TopMost = chkOnTop.Checked
    End Sub

    Private Sub cmdMaximize_Click(sender As Object, e As EventArgs) Handles cmdMaximize.Click
        If cmdMaximize.Text = "Expand" Then
            Me.Height = 397
            Me.Width = 454
            cmdMaximize.Text = "Shrink"
        ElseIf cmdMaximize.Text = "Shrink" Then
            Me.Height = 125
            Me.Width = 454
            cmdMaximize.Text = "Expand"
        End If
    End Sub

    Private Sub frmInfo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

    End Sub

    Private Sub frmInfo_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
            Hide()
        End If
    End Sub

    Private Sub txtChord_TextChanged(sender As Object, e As EventArgs) Handles txtChord.TextChanged
        Dim SplitChord() As String
        SplitChord = Split(txtChord.Text, ",") 'st SplitChord(0) is the root

        CurrentChord = txtChord.Text

    End Sub

    Private Sub txtNotes_TextChanged(sender As Object, e As EventArgs) Handles txtNotes.TextChanged

    End Sub

    Private Sub txtVals_TextChanged(sender As Object, e As EventArgs) Handles txtVals.TextChanged

    End Sub
End Class