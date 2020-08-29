Public Class frmChordBuilder
    Dim TempRoot As String 'Temporarily stores the root from the main window here, so that when a chord is built its root is shown in red
    Dim SplitSymbol() As String
    Sub GenSemitoneChecks(WhatNotes As String)
        'Checks the appropriate semitones on the expanded form
        'uses CSV as argument

        Dim NoteSplit() As String

        NoteSplit = Split(WhatNotes, ",")

        cb0.Checked = False
        cb1.Checked = False
        cb2.Checked = False
        cb3.Checked = False
        cb4.Checked = False
        cb5.Checked = False
        cb6.Checked = False
        cb7.Checked = False
        cb8.Checked = False
        cb9.Checked = False
        cb10.Checked = False
        cb11.Checked = False
        cb12.Checked = False

        For Each sNote In NoteSplit
            If Val(sNote) = 0 Then cb0.Checked = True
            If Val(sNote) = 1 Then cb1.Checked = True
            If Val(sNote) = 2 Then cb2.Checked = True
            If Val(sNote) = 3 Then cb3.Checked = True
            If Val(sNote) = 4 Then cb4.Checked = True
            If Val(sNote) = 5 Then cb5.Checked = True
            If Val(sNote) = 6 Then cb6.Checked = True
            If Val(sNote) = 7 Then cb7.Checked = True
            If Val(sNote) = 8 Then cb8.Checked = True
            If Val(sNote) = 9 Then cb9.Checked = True
            If Val(sNote) = 10 Then cb10.Checked = True
            If Val(sNote) = 11 Then cb11.Checked = True
            If Val(sNote) = 12 Then cb12.Checked = True
        Next

    End Sub
    Private Sub cbQuick_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbQuick.SelectedIndexChanged
        cbSymbol.SelectedIndex = cbQuick.SelectedIndex
        cbIntervals.SelectedIndex = cbQuick.SelectedIndex
        txtNotes.Text = GenChordFromCSV(cbRoot.Text, cbIntervals.Text)



        If InStr(cbSymbol.Text, "/") > 0 Then
            If cbSymbol.Text = "min/maj7" Then
                txtName.Text = cbRoot.Text & cbSymbol.Text
            Else
                SplitSymbol = Split(cbSymbol.Text, "/")
                txtName.Text = cbRoot.Text & SplitSymbol(0)
            End If
        Else
            txtName.Text = cbRoot.Text & cbSymbol.Text
        End If


        GenSemitoneChecks(cbIntervals.Text)

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
        Me.Height = 140


    End Sub

    Private Sub cbIntervals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIntervals.SelectedIndexChanged
        cbQuick.SelectedIndex = cbIntervals.SelectedIndex
    End Sub

    Private Sub cbRoot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRoot.SelectedIndexChanged

        If InStr(cbSymbol.Text, "/") > 0 Then
            If cbSymbol.Text = "min/maj7" Then
                txtName.Text = cbRoot.Text & cbSymbol.Text
            Else
                SplitSymbol = Split(cbSymbol.Text, "/")
                txtName.Text = cbRoot.Text & SplitSymbol(0)
            End If
        Else
            txtName.Text = cbRoot.Text & cbSymbol.Text
        End If

        txtNotes.Text = GenChordFromCSV(cbRoot.Text, cbIntervals.Text)

        GenSemitoneChecks(cbIntervals.Text)

        If chkAutoDisplay.Checked = True Then
            TempRoot = RootNote
            RootNote = cbRoot.Text
            frmTabTool.DrawKeyboard(txtNotes.Text)
            frmTabTool.DrawFretBoard(txtNotes.Text)
            RootNote = TempRoot
        End If
    End Sub

    Private Sub cmdShow_Click(sender As Object, e As EventArgs) Handles cmdShow.Click
        'Updates the keyboard or fretboard

        TempRoot = RootNote
        RootNote = cbRoot.Text
        frmTabTool.DrawKeyboard(txtNotes.Text)
        frmTabTool.DrawFretBoard(txtNotes.Text)
        RootNote = TempRoot
    End Sub

    Private Sub txtNotes_TextChanged(sender As Object, e As EventArgs) Handles txtNotes.TextChanged
        frmTabTool.txtChord.Text = txtNotes.Text

    End Sub

    Private Sub chkOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnTop.CheckedChanged
        Me.TopMost = chkOnTop.Checked
    End Sub

    Private Sub cmdSize_Click(sender As Object, e As EventArgs) Handles cmdSize.Click
        If cmdSize.Text = "More" Then
            Me.Height = 496
            cmdSize.Text = "Less"
        ElseIf cmdSize.Text = "Less" Then
            Me.Height = 140
            cmdSize.Text = "More"
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        'Swaps aug fourth and dim fifth on form

        If lblSpec.Text = "Augmented Fourth" Then
            lblSpec.Text = "Diminished Fifth"
            lblShort.Text = "d5"
        ElseIf lblSpec.Text = "Diminished Fifth" Then
            lblSpec.Text = "Augmented Fourth"
            lblShort.Text = "A4"
        End If
    End Sub

    Private Sub cmdShowChord_Click(sender As Object, e As EventArgs) Handles cmdShowChord.Click
        Dim ChordStack As String

        ChordStack = ""

        If cb0.Checked = True Then ChordStack += "0,"
        If cb1.Checked = True Then ChordStack += "1,"
        If cb2.Checked = True Then ChordStack += "2,"
        If cb3.Checked = True Then ChordStack += "3,"
        If cb4.Checked = True Then ChordStack += "4,"
        If cb5.Checked = True Then ChordStack += "5,"
        If cb6.Checked = True Then ChordStack += "6,"
        If cb7.Checked = True Then ChordStack += "7,"
        If cb8.Checked = True Then ChordStack += "8,"
        If cb9.Checked = True Then ChordStack += "9,"
        If cb10.Checked = True Then ChordStack += "10,"
        If cb11.Checked = True Then ChordStack += "11,"
        If cb12.Checked = True Then ChordStack += "12,"

        ChordStack = Mid(ChordStack, 1, Len(ChordStack) - 1)

        txtNotes.Text = GenChordFromCSV(cbRoot.Text, ChordStack)

        frmTabTool.DrawKeyboard(txtNotes.Text)
        frmTabTool.DrawFretBoard(txtNotes.Text)

    End Sub
End Class