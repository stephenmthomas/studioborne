Public Class frmChordBuilder
    Dim TempRoot As String 'Temporarily stores the root from the main window here, so that when a chord is built its root is shown in red
    Dim SplitSymbol() As String
    Dim ChordStack As String 'Intervals in CSV for the chord
    Sub ClearChecks()
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
    End Sub
    Sub GenSemitoneChecks(WhatIntervals As String)
        'Checks the appropriate semitones on the expanded form
        'uses CSV as argument

        Dim NoteSplit() As String

        NoteSplit = Split(WhatIntervals, ",")

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
    Sub GenChordFromChecks()
        Dim CheckStack As String = ""

        If cb0.Checked = True Then CheckStack += "0,"
        If cb1.Checked = True Then CheckStack += "1,"
        If cb2.Checked = True Then CheckStack += "2,"
        If cb3.Checked = True Then CheckStack += "3,"
        If cb4.Checked = True Then CheckStack += "4,"
        If cb5.Checked = True Then CheckStack += "5,"
        If cb6.Checked = True Then CheckStack += "6,"
        If cb7.Checked = True Then CheckStack += "7,"
        If cb8.Checked = True Then CheckStack += "8,"
        If cb9.Checked = True Then CheckStack += "9,"
        If cb10.Checked = True Then CheckStack += "10,"
        If cb11.Checked = True Then CheckStack += "11,"
        If cb12.Checked = True Then CheckStack += "12,"
        If cb13.Checked = True Then CheckStack += "13,"
        If cb14.Checked = True Then CheckStack += "14,"
        If cb15.Checked = True Then CheckStack += "15,"
        If cb16.Checked = True Then CheckStack += "16,"
        If cb17.Checked = True Then CheckStack += "17,"
        If cb18.Checked = True Then CheckStack += "18,"
        If cb19.Checked = True Then CheckStack += "19,"
        If cb20.Checked = True Then CheckStack += "20,"
        If cb21.Checked = True Then CheckStack += "21,"
        If cb22.Checked = True Then CheckStack += "22,"
        If cb23.Checked = True Then CheckStack += "23,"
        If cb24.Checked = True Then CheckStack += "24,"


        If Len(CheckStack) > 0 Then
            CheckStack = Mid(CheckStack, 1, Len(CheckStack) - 1)
            CurrentSemitones = CheckStack
            txtNotes.Text = GenChordFromCSV(cbRoot.Text, CheckStack)
            frmInfo.txtChord.Text = GenChordFromCSV(cbRoot.Text, CheckStack)
        End If


    End Sub
    Sub FindChord(WhatIntCSV As String)
        If cbSymbol.Items.Contains(ChordTypeFromCSV(WhatIntCSV)) Then
            cbSymbol.SelectedIndex = cbSymbol.Items.IndexOf(ChordTypeFromCSV(WhatIntCSV))
        End If
    End Sub
    Private Sub cbSymbol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSymbol.SelectedIndexChanged
        cbQuick.SelectedIndex = cbSymbol.SelectedIndex
    End Sub
    Private Sub cbQuick_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbQuick.SelectedIndexChanged
        cbSymbol.SelectedIndex = cbQuick.SelectedIndex
        cbIntervals.SelectedIndex = cbQuick.SelectedIndex
    End Sub
    Private Sub cbIntervals_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIntervals.SelectedIndexChanged
        cbQuick.SelectedIndex = cbIntervals.SelectedIndex
        frmTabTool.txtVals.Text = cbIntervals.Text

        ClearChecks()
        GenSemitoneChecks(cbIntervals.Text)

    End Sub
    Private Sub cbRoot_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbRoot.SelectedIndexChanged
        ClearChecks()
        GenSemitoneChecks(cbIntervals.Text)
    End Sub

    Private Sub frmChordBuilder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'PRELOAD TO PREVENT CRASHING
        cbRoot.Text = frmTabTool.cbKey.Text
        cbSymbol.Text = "Δ/maj"
        cbIntervals.Text = "0,4,7"


        'cbIntervals.SelectedIndex = 21
        Me.Height = 140
        chkOnTop.Checked = oOnTop
        'cbRoot.SelectedIndex = frmTabTool.cbKey.SelectedIndex
    End Sub


    Private Sub cmdShow_Click(sender As Object, e As EventArgs) Handles cmdShow.Click
        'Updates the keyboard or fretboard
        frmTabTool.DrawKeyboard(CurrentChord, True)
        frmTabTool.DrawFretBoard(CurrentChord)
    End Sub

    Private Sub txtNotes_TextChanged(sender As Object, e As EventArgs) Handles txtNotes.TextChanged
        CurrentChord = txtNotes.Text
        ProcessChord()

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
    Sub ProcessChord()

        If InStr(cbSymbol.Text, "/") > 0 Then
            If cbSymbol.Text = "min/maj7" Then
                txtName.Text = cbRoot.Text & cbSymbol.Text
            Else
                SplitSymbol = Split(cbSymbol.Text, "/")
                txtName.Text = cbRoot.Text & SplitSymbol(0)
            End If
        Else
            txtName.Text = cbRoot.Text & " " & cbSymbol.Text
        End If

        If chkAutoDisplay.Checked = True Then
            frmTabTool.DrawKeyboard(CurrentChord, True)
            frmTabTool.DrawFretBoard(CurrentChord)
            frmKeyboard.Text = "Keyboard - " & cbRoot.Text & " " & ChordTypeFromCSV(CurrentSemitones)
            frmFretboard.Text = "Fretboard - " & cbRoot.Text & " " & ChordTypeFromCSV(CurrentSemitones)
        End If
    End Sub
    Private Sub cmdShowChord_Click(sender As Object, e As EventArgs) Handles cmdShowChord.Click
        ProcessChord()
        FindChord(ChordStack)
    End Sub

    Private Sub frmChordBuilder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        RefreshAllForms()
    End Sub

    Private Sub cb0_CheckedChanged(sender As Object, e As EventArgs) Handles cb0.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub chkAutoDisplay_CheckedChanged(sender As Object, e As EventArgs) Handles chkAutoDisplay.CheckedChanged
    End Sub

    Private Sub cb1_CheckedChanged(sender As Object, e As EventArgs) Handles cb1.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb2_CheckedChanged(sender As Object, e As EventArgs) Handles cb2.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb3_CheckedChanged(sender As Object, e As EventArgs) Handles cb3.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb4_CheckedChanged(sender As Object, e As EventArgs) Handles cb4.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb5_CheckedChanged(sender As Object, e As EventArgs) Handles cb5.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb6_CheckedChanged(sender As Object, e As EventArgs) Handles cb6.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb7_CheckedChanged(sender As Object, e As EventArgs) Handles cb7.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb8_CheckedChanged(sender As Object, e As EventArgs) Handles cb8.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb9_CheckedChanged(sender As Object, e As EventArgs) Handles cb9.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb10_CheckedChanged(sender As Object, e As EventArgs) Handles cb10.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb11_CheckedChanged(sender As Object, e As EventArgs) Handles cb11.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb12_CheckedChanged(sender As Object, e As EventArgs) Handles cb12.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb13_CheckedChanged(sender As Object, e As EventArgs) Handles cb13.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb14_CheckedChanged(sender As Object, e As EventArgs) Handles cb14.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb15_CheckedChanged(sender As Object, e As EventArgs) Handles cb15.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb16_CheckedChanged(sender As Object, e As EventArgs) Handles cb16.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb17_CheckedChanged(sender As Object, e As EventArgs) Handles cb17.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb18_CheckedChanged(sender As Object, e As EventArgs) Handles cb18.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb19_CheckedChanged(sender As Object, e As EventArgs) Handles cb19.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb20_CheckedChanged(sender As Object, e As EventArgs) Handles cb20.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb21_CheckedChanged(sender As Object, e As EventArgs) Handles cb21.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb22_CheckedChanged(sender As Object, e As EventArgs) Handles cb22.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb23_CheckedChanged(sender As Object, e As EventArgs) Handles cb23.CheckedChanged
        GenChordFromChecks()
    End Sub

    Private Sub cb24_CheckedChanged(sender As Object, e As EventArgs) Handles cb24.CheckedChanged
        GenChordFromChecks()
    End Sub
End Class