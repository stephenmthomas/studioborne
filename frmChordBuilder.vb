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
        cb13.Checked = False
        cb14.Checked = False
        cb15.Checked = False
        cb16.Checked = False
        cb17.Checked = False
        cb18.Checked = False
        cb19.Checked = False
        cb20.Checked = False
        cb21.Checked = False
        cb22.Checked = False
        cb23.Checked = False
        cb24.Checked = False

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
            If Val(sNote) = 13 Then cb13.Checked = True
            If Val(sNote) = 14 Then cb14.Checked = True
            If Val(sNote) = 15 Then cb15.Checked = True
            If Val(sNote) = 16 Then cb16.Checked = True
            If Val(sNote) = 17 Then cb17.Checked = True
            If Val(sNote) = 18 Then cb18.Checked = True
            If Val(sNote) = 19 Then cb19.Checked = True
            If Val(sNote) = 20 Then cb20.Checked = True
            If Val(sNote) = 21 Then cb21.Checked = True
            If Val(sNote) = 22 Then cb22.Checked = True
            If Val(sNote) = 23 Then cb23.Checked = True
            If Val(sNote) = 24 Then cb24.Checked = True
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
        cbQuick.SelectedIndex = 21
        cbRoot.SelectedIndex = 3
        Me.Height = 140


    End Sub

    Private Sub cbIntervals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIntervals.SelectedIndexChanged
        cbQuick.SelectedIndex = cbIntervals.SelectedIndex
        frmTabTool.txtVals.Text = cbIntervals.Text
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
        CurrentChord = txtNotes.Text

    End Sub

    Private Sub chkOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnTop.CheckedChanged
        Me.TopMost = chkOnTop.Checked
    End Sub

    Private Sub cmdSize_Click(sender As Object, e As EventArgs) Handles cmdSize.Click
        If cmdSize.Text = "More" Then
            Me.Height = 563
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

        If lbld13.Text = "Diminished Thirteenth" Then
            lbld13.Text = "Tritave"
        ElseIf lbld13.Text = "Tritave" Then
            lbld13.Text = "Diminished Thirteenth"
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
        If cb13.Checked = True Then ChordStack += "13,"
        If cb14.Checked = True Then ChordStack += "14,"
        If cb15.Checked = True Then ChordStack += "15,"
        If cb16.Checked = True Then ChordStack += "16,"
        If cb17.Checked = True Then ChordStack += "17,"
        If cb18.Checked = True Then ChordStack += "18,"
        If cb19.Checked = True Then ChordStack += "19,"
        If cb20.Checked = True Then ChordStack += "20,"
        If cb21.Checked = True Then ChordStack += "21,"
        If cb22.Checked = True Then ChordStack += "22,"
        If cb23.Checked = True Then ChordStack += "23,"
        If cb24.Checked = True Then ChordStack += "24,"

        ChordStack = Mid(ChordStack, 1, Len(ChordStack) - 1)

        If cbIntervals.Items.Contains(ChordStack) Then
            cbIntervals.SelectedIndex = cbIntervals.Items.IndexOf(ChordStack)
        End If

        CurrentChord = GenChordFromCSV(cbRoot.Text, ChordStack)

        frmTabTool.DrawKeyboard(CurrentChord)
        frmTabTool.DrawFretBoard(CurrentChord)

    End Sub

    Private Sub frmChordBuilder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RefreshAllForms()
    End Sub
End Class