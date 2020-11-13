Public Class frmTabTool

    Public Sub GenRootDiff(WhatNote)
        RootDiff = Note2Value(WhatNote) - 0
    End Sub
    Public Sub GenNotes()
        txtNotes.Text = GenNotesCSV(cbInt.Text)

    End Sub
    Public Sub GenValues()
        txtVals.Text = GenSemiCSV(cbInt.Text)
    End Sub
    Sub SaveOptions()
        Dim ConfigFile As System.IO.StreamWriter
        Dim NewOpts As String

        NewOpts = ""

        NewOpts += "autoshow=" & chkAutoChord.Checked & ","
        NewOpts += "notes=" & chkNoteText.Checked & ","
        NewOpts += "tones=" & chkTones.Checked & ","
        NewOpts += "tabroots=" & chkTabRoot.Checked & ","
        NewOpts += "icons=" & chkNoteIcon.Checked & ","
        NewOpts += "ontop=" & chkOnTop.Checked & ","
        NewOpts += "transparency=" & Str(Transparency) & ","
        NewOpts += "transparent=" & chkTransparency.Checked & ","
        NewOpts += "fretmin=" & txtFretMin.Text & ","
        NewOpts += "fretmax=" & txtFretMax.Text

        ConfigFile = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\settings.cfg", False)
        ConfigFile.WriteLine(NewOpts)
        ConfigFile.Close()
    End Sub
    Sub LoadOptions()
        Dim ConfigFile As System.IO.StreamWriter
        Dim SBOptions As String
        Dim Opts(), CurOpt() As String

        If System.IO.File.Exists(Application.StartupPath & "\settings.cfg") Then
            SBOptions = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\settings.cfg")
            Opts = Split(SBOptions, ",")

            For Each opt In Opts
                CurOpt = Split(opt, "=")
                If CurOpt(0) = "autoshow" Then chkAutoChord.Checked = CurOpt(1)
                If CurOpt(0) = "notes" Then chkNoteText.Checked = CurOpt(1)
                If CurOpt(0) = "tones" Then chkTones.Checked = CurOpt(1)
                If CurOpt(0) = "tabroots" Then chkTabRoot.Checked = CurOpt(1)
                If CurOpt(0) = "icons" Then chkNoteIcon.Checked = CurOpt(1)
                If CurOpt(0) = "ontop" Then chkOnTop.Checked = CurOpt(1)
                If CurOpt(0) = "transparency" Then Transparency = Val(CurOpt(1))
                If CurOpt(0) = "transparent" Then chkTransparency.Checked = CurOpt(1)
                If CurOpt(0) = "fretmin" Then txtFretMin.Text = CurOpt(1)
                If CurOpt(0) = "fretmax" Then txtFretMax.Text = CurOpt(1)
            Next

        Else
            ConfigFile = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\settings.cfg", False)
            ConfigFile.WriteLine(DefaultOpts)
            ConfigFile.Close()
        End If
    End Sub
    Private Sub frmTabTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOptions()
        Me.Text = Me.Text & " - " & SBVersion
        Me.Height = 219
        Me.Width = 525
        cbKey.SelectedIndex = 3
        cbMode.SelectedIndex = 0
        GenNotes()
        GenValues()
    End Sub
    Sub DrawTriadForm()
        'Draws triads on the triad viewer
        frmKeyTriad.KeyClearAll()
        For DegreeX = 1 To 7
            DrawTriad(DegreeX)
        Next

    End Sub
    Sub RefreshAllForms()
        'Refreshes all forms
        DrawKeyboard(CurrentNotes)
        DrawFretBoard(CurrentNotes)
        DrawTriadForm()

        frmFretboard.Text = "Fretboard - " & cbKey.Text & " " & cbMode.Text
        frmKeyboard.Text = "Keyboard - " & cbKey.Text & " " & cbMode.Text
        frmKeyTriad.Text = "Triads - " & cbKey.Text & " " & cbMode.Text

    End Sub
    Private Sub cbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMode.SelectedIndexChanged
        cbInt.SelectedIndex = cbMode.SelectedIndex
        GenNotes()
        GenValues()

        cmdChord1.Text = ChordDegButton(ScaleDegIntFromNotes(CurrentNotes & "," & CurrentNotes, 1), "I")
        cmdChord2.Text = ChordDegButton(ScaleDegIntFromNotes(CurrentNotes & "," & CurrentNotes, 2), "II")
        cmdChord3.Text = ChordDegButton(ScaleDegIntFromNotes(CurrentNotes & "," & CurrentNotes, 3), "III")
        cmdChord4.Text = ChordDegButton(ScaleDegIntFromNotes(CurrentNotes & "," & CurrentNotes, 4), "IV")
        cmdChord5.Text = ChordDegButton(ScaleDegIntFromNotes(CurrentNotes & "," & CurrentNotes, 5), "V")
        cmdChord6.Text = ChordDegButton(ScaleDegIntFromNotes(CurrentNotes & "," & CurrentNotes, 6), "VI")
        cmdChord7.Text = ChordDegButton(ScaleDegIntFromNotes(CurrentNotes & "," & CurrentNotes, 7), "VII")

        If frmKeyTriad.Visible = True Then
            frmKeyTriad.cb1.Text = cmdChord1.Text
            frmKeyTriad.cb2.Text = cmdChord2.Text
            frmKeyTriad.cb3.Text = cmdChord3.Text
            frmKeyTriad.cb4.Text = cmdChord4.Text
            frmKeyTriad.cb5.Text = cmdChord5.Text
            frmKeyTriad.cb6.Text = cmdChord6.Text
            frmKeyTriad.cb7.Text = cmdChord7.Text
        End If

    End Sub

    Private Sub cbInt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbInt.SelectedIndexChanged
        cbMode.SelectedIndex = cbInt.SelectedIndex
    End Sub

    Private Sub cbKey_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKey.SelectedIndexChanged
        On Error Resume Next
        RootNote = cbKey.Text
        GenRootDiff(cbKey.Text)
        GenNotes()
        GenValues()




    End Sub
    Public Sub GenerateTabScale(WhatNotes As String)
        'First, split string text in to notes
        'Grab last note and add tab line first
        'process through 24 semitones, placing tab/fret values when they apply


        Dim ScaleNotes(), TuningNotes() As String
        Dim CurString, CurNote As Integer
        Dim StringTuning, FretPitch As String

        ScaleNotes = Split(WhatNotes, ",")
        TuningNotes = Split(Tuning, ",")
        StringNo = UBound(TuningNotes) + 1

        For CurString = 1 To StringNo 'For each string on instrument
            StringTuning = TuningNotes(StringNo - CurString) 'Current Tuning of String
            txtTab.Text = txtTab.Text & StringTuning & "-|-"

            For CurFret = FretMin To FretMax 'Search each fret open to 24
                FretPitch = Fret2Note(StringTuning, CurFret) 'Current pitch of current fret

                If CurFret > 9 Then
                    txtTab.Text += "--"
                Else
                    txtTab.Text += "-"
                End If

                If chkTabRoot.Checked = True And Not FretPitch = RootNote Then
                    txtTab.Text += "-"
                End If

                For CurNote = LBound(ScaleNotes) To UBound(ScaleNotes) '- 1 'Search each note of the scale to see if it matches the fret
                    'ScaleNote(CurNote) = note in scale to look for
                    If FretPitch = ScaleNotes(CurNote) Then 'If the current note is in the scale [GUITAR MONEY MAKER]
                        If CurFret > 9 Then
                            txtTab.Text = Mid(txtTab.Text, 1, Len(txtTab.Text) - 2)
                        Else
                            txtTab.Text = Mid(txtTab.Text, 1, Len(txtTab.Text) - 1)
                        End If

                        If chkTabRoot.Checked = True And FretPitch = RootNote Then
                            txtTab.Text += "[" & Replace(Str(CurFret), " ", "") & "]" 'Add the Fret
                        Else
                            txtTab.Text += Replace(Str(CurFret), " ", "") 'Add the Fret
                        End If

                    End If
                Next CurNote

                If CurFret > 9 Then
                    txtTab.Text += "--"
                Else
                    txtTab.Text += "-"
                End If

                If chkTabRoot.Checked = True And Not FretPitch = RootNote Then
                    txtTab.Text += "-"
                End If

            Next CurFret

            txtTab.Text += vbNewLine

        Next CurString

        txtTab.Text += vbNewLine

    End Sub
    Public Sub DrawFretBoard(WhatNotes As String)
        'Modified version of 'GenerateTabScale' which draws on Guitar Fretboard

        'First, split string text in to notes
        'Grab last note and add tab line first
        'process through 24 semitones, placing tab/fret values when they apply


        Dim ScaleNotes(), TuningNotes() As String
        Dim CurString, CurNote As Integer
        Dim StringTuning, FretPitch As String

        ScaleNotes = Split(WhatNotes, ",")
        TuningNotes = Split(Tuning, ",")
        StringNo = UBound(TuningNotes) + 1

        frmFretboard.FretClearAll() 'Clear Fretboard

        For CurString = 1 To StringNo 'For each string on instrument
            StringTuning = TuningNotes(StringNo - CurString) 'Current Tuning of String
            For CurFret = FretMin To FretMax 'Search each fret with in range
                FretPitch = Fret2Note(StringTuning, CurFret) 'Current pitch of current fret
                For CurNote = LBound(ScaleNotes) To UBound(ScaleNotes) '- 1 'Search each note of the scale to see if it matches the fret
                    'ScaleNote(CurNote) = note in scale to look for
                    If FretPitch = ScaleNotes(CurNote) Then 'If the current note is in the scale [GUITAR MONEY MAKER]
                        If frmFretboard.Visible = True Then
                            If FretPitch = RootNote Then
                                If chkTones.Checked = True Then
                                    frmFretboard.FretDraw(CurString, CurFret, Color.Red, Trim(Str(CurNote + 1)))
                                Else
                                    frmFretboard.FretDraw(CurString, CurFret, Color.Red, ScaleNotes(CurNote))
                                End If
                            Else
                                If chkTones.Checked = True Then
                                    frmFretboard.FretDraw(CurString, CurFret, Color.Green, Trim(Str(CurNote + 1)))
                                Else
                                    frmFretboard.FretDraw(CurString, CurFret, Color.Green, ScaleNotes(CurNote))
                                End If
                            End If
                        End If
                    End If
                Next CurNote
            Next CurFret
        Next CurString

    End Sub
    Sub DrawTriad(WhatDegree As Integer)
        'Draws the triad chords on the triad viewer
        Dim CurNotes() As String 'Notes of current mode
        Dim ChordStr As String 'Chords generated from the current notes
        Dim nRoot, nThird, nFifth As String

        CurNotes = Split(CurrentNotes & "," & CurrentNotes & "," & CurrentNotes & "," & CurrentNotes, ",")

        nRoot = CurNotes(2 * 0 + (WhatDegree - 1)) 'Add the Root
        nThird = CurNotes(2 * 1 + (WhatDegree - 1)) 'Add the Third Scale Degree
        nFifth = CurNotes(2 * 2 + (WhatDegree - 1)) 'Add the Fifth Scale Degree

        ChordStr = nRoot & "," & nThird & "," & nFifth

        CurNotes = Split(ChordStr, ",")

        For Each Note In CurNotes
            If frmKeyTriad.Visible = True Then
                If Note = CurNotes(0) Then
                    frmKeyTriad.KeyDraw(Note, Color.Red, WhatDegree)
                Else
                    frmKeyTriad.KeyDraw(Note, Color.Green, WhatDegree)
                End If
            End If
        Next

    End Sub
    Public Function GenerateChord(WhatDegree As Integer) As String
        'Generates basic chords from the notes list, output as CSV data
        Dim ScaleNotes() As String '
        Dim ChordStr As String 'Used multiple times throughout for various purposes
        Dim nRoot, nThird, nFifth, nSeventh, nNinth, nEleventh, n13th As String
        Dim TempRoot() As String
        Dim i As Integer 'WhatDegree

        i = WhatDegree - 1

        ChordStr = CurrentNotes & "," & CurrentNotes & "," & CurrentNotes & "," & CurrentNotes

        ScaleNotes = Split(ChordStr, ",")
        ChordStr = ""

        nRoot = ScaleNotes(2 * 0 + i) 'Add the Root
        nThird = ScaleNotes(2 * 1 + i) 'Add the Third Scale Degree
        nFifth = ScaleNotes(2 * 2 + i) 'Add the Fifth Scale Degree
        nSeventh = ScaleNotes(2 * 3 + i) 'Get the seventh
        nNinth = ScaleNotes(2 * 4 + i) 'Get the ninth
        nEleventh = ScaleNotes(2 * 5 + i) 'Get the eleventh
        n13th = ScaleNotes(2 * 6 + i) 'Get the 13th

        'Check Third Degree Options (sus2, 4)
        If chkSus2.Checked = True Then
            nThird = ChangePitch(nThird, -2)
        ElseIf chkSus4.Checked = True Then
            nThird = ChangePitch(nThird, 1)
        ElseIf chkMin.Checked = True Then
            nThird = ChangePitch(nThird, -1)
        End If

        'Check Fifth Degree Options
        If chkDim.Checked = True Then
            nFifth = ChangePitch(nFifth, -1)
        ElseIf chkAug.Checked = True Then
            nFifth = ChangePitch(nFifth, 1)
        ElseIf chkAug7.Checked = True Then
            chk7.Checked = True
            nFifth = ChangePitch(nFifth, 1)
            nSeventh = ChangePitch(nSeventh, -1)
        ElseIf chkDim7.Checked = True Then
            chk7.Checked = True
            nThird = ChangePitch(nThird, -1)
            nFifth = ChangePitch(nFifth, -1)
            nSeventh = ChangePitch(nSeventh, -2)
        End If

        ChordStr = nRoot & "," & nThird & "," & nFifth

        'Check Extended Chord
        If chk7.Checked = True Then ChordStr += "," & nSeventh
        If chk9.Checked = True Then ChordStr += "," & nNinth
        If chk11.Checked = True Then ChordStr += "," & nEleventh

        LastChord = WhatDegree
        GenerateChord = ChordStr

        If chkAutoChord.Checked = True Then
            TempRoot = Split(ChordStr, ",")
            RootNote = TempRoot(0)
            DrawKeyboard(ChordStr)
            DrawFretBoard(ChordStr)
            RootNote = cbKey.Text
        End If

    End Function
    Sub DrawKeyboard(WhatNotes As String) 'Accepts CSV
        Dim AddNotes() As String
        Dim NoteStep As Integer

        NoteStep = 0
        AddNotes = Split(WhatNotes, ",")
        frmKeyboard.KeyClearAll()

        For Each Note In AddNotes
            If frmKeyboard.Visible = True Then
                If Note = RootNote Then
                    If chkTones.Checked = True Then
                        frmKeyboard.KeyDraw(Note, Color.Red, Trim(Str(NoteStep)))
                    Else
                        frmKeyboard.KeyDraw(Note, Color.Red, Note)
                    End If
                Else
                    If chkTones.Checked = True Then
                        frmKeyboard.KeyDraw(Note, Color.Green, Trim(Str(NoteStep)))
                    Else
                        frmKeyboard.KeyDraw(Note, Color.Green, Note)
                    End If

                End If
            End If
            NoteStep += 1
        Next
    End Sub

    Private Sub cmdDraw_Click(sender As Object, e As EventArgs) Handles cmdDraw.Click
        txtTab.Text += "Generating " & cbKey.Text & " " & cbMode.Text & " as tab:" & vbNewLine
        frmFretboard.FretClearAll()
        GenerateTabScale(txtNotes.Text)
        DrawFretBoard(txtNotes.Text)
    End Sub
    Private Sub cmdAddChord_Click(sender As Object, e As EventArgs) Handles cmdAddChord.Click
        Dim TempRoot() As String

        TempRoot = Split(txtChord.Text, ",")
        RootNote = TempRoot(0)
        DrawKeyboard(txtChord.Text)
        'frmFretboard.FretClearAll()
        txtTab.Text += "Generating " & cbKey.Text & " " & cbMode.Text & " degree " & Str(LastChord) & " chord:" & vbNewLine
        GenerateTabScale(txtChord.Text)
        RootNote = cbKey.Text
    End Sub
    Private Sub txtTuning_TextChanged(sender As Object, e As EventArgs) Handles txtTuning.TextChanged
        Tuning = txtTuning.Text
    End Sub

    Private Sub cmdChord1_Click(sender As Object, e As EventArgs) Handles cmdChord1.Click
        txtChord.Text = GenerateChord(1)
        Dim SplitChord() As String
        SplitChord = Split(txtChord.Text, ",")

        frmFretboard.Text = "Fretboard - " & cbKey.Text & " " & cbMode.Text & " " & cmdChord1.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(txtVals.Text)
        frmKeyboard.Text = "Keyboard - " & cbKey.Text & " " & cbMode.Text & " " & cmdChord1.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(txtVals.Text)
    End Sub
    Private Sub cmdChord2_Click(sender As Object, e As EventArgs) Handles cmdChord2.Click
        txtChord.Text = GenerateChord(2)
        Dim SplitChord() As String
        SplitChord = Split(txtChord.Text, ",")

        frmFretboard.Text = "Fretboard - " & cbKey.Text & " " & cbMode.Text & " " & cmdChord2.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(txtVals.Text)
        frmKeyboard.Text = "Keyboard - " & cbKey.Text & " " & cbMode.Text & " " & cmdChord2.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(txtVals.Text)
    End Sub

    Private Sub cmdChord3_Click(sender As Object, e As EventArgs) Handles cmdChord3.Click
        txtChord.Text = GenerateChord(3)
        Dim SplitChord() As String
        SplitChord = Split(txtChord.Text, ",")

        frmFretboard.Text = "Fretboard - " & cbKey.Text & " " & cbMode.Text & " " & cmdChord3.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(txtVals.Text)
        frmKeyboard.Text = "Keyboard - " & cbKey.Text & " " & cbMode.Text & " " & cmdChord3.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(txtVals.Text)
    End Sub

    Private Sub cmdChord4_Click(sender As Object, e As EventArgs) Handles cmdChord4.Click
        txtChord.Text = GenerateChord(4)
        Dim SplitChord() As String
        SplitChord = Split(txtChord.Text, ",")

        frmFretboard.Text = "Fretboard - " & cbKey.Text & " " & cbMode.Text & " " & cmdChord4.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(txtVals.Text)
        frmKeyboard.Text = "Keyboard - " & cbKey.Text & " " & cbMode.Text & " " & cmdChord4.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(txtVals.Text)
    End Sub

    Private Sub cmdChord5_Click(sender As Object, e As EventArgs) Handles cmdChord5.Click
        txtChord.Text = GenerateChord(5)
        Dim SplitChord() As String
        SplitChord = Split(txtChord.Text, ",")

        frmFretboard.Text = "Fretboard - " & cbKey.Text & " " & cbMode.Text & " " & cmdChord5.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(txtVals.Text)
        frmKeyboard.Text = "Keyboard - " & cbKey.Text & " " & cbMode.Text & " " & cmdChord5.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(txtVals.Text)
    End Sub

    Private Sub cmdChord6_Click(sender As Object, e As EventArgs) Handles cmdChord6.Click
        txtChord.Text = GenerateChord(6)
        Dim SplitChord() As String
        SplitChord = Split(txtChord.Text, ",")

        frmFretboard.Text = "Fretboard - " & cbKey.Text & " " & cbMode.Text & " " & cmdChord6.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(txtVals.Text)
        frmKeyboard.Text = "Keyboard - " & cbKey.Text & " " & cbMode.Text & " " & cmdChord6.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(txtVals.Text)
    End Sub

    Private Sub cmdChord7_Click(sender As Object, e As EventArgs) Handles cmdChord7.Click
        txtChord.Text = GenerateChord(7)
        Dim SplitChord() As String
        SplitChord = Split(txtChord.Text, ",")

        frmFretboard.Text = "Fretboard - " & cbKey.Text & " " & cbMode.Text & " " & cmdChord7.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(txtVals.Text)
        frmKeyboard.Text = "Keyboard - " & cbKey.Text & " " & cbMode.Text & " " & cmdChord7.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(txtVals.Text)
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        txtTab.Text = ""

    End Sub

    Private Sub cmdFretboard_Click(sender As Object, e As EventArgs) Handles cmdFretboard.Click
        frmFretboard.Show()
        RefreshAllForms()
    End Sub

    Private Sub cmdKeyboard_Click(sender As Object, e As EventArgs) Handles cmdKeyboard.Click
        frmKeyboard.Show()
        RefreshAllForms()
    End Sub

    Private Sub txtNotes_TextChanged(sender As Object, e As EventArgs) Handles txtNotes.TextChanged
        CurrentNotes = txtNotes.Text
        RefreshAllForms()
    End Sub

    Private Sub cmdMaximize_Click(sender As Object, e As EventArgs) Handles cmdMaximize.Click
        If cmdMaximize.Text = "Expand" Then
            Me.Height = 863
            Me.Width = 913
            cmdMaximize.Text = "Shrink"
        ElseIf cmdMaximize.Text = "Shrink" Then
            Me.Height = 219
            Me.Width = 525
            cmdMaximize.Text = "Expand"
            cmdHideTab.Text = "Hide Tab"
        End If
    End Sub

    Private Sub cbProgressions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProgressions.SelectedIndexChanged
        cbProgList.SelectedIndex = cbProgressions.SelectedIndex
        ToolTip.SetToolTip(Me.cbProgressions, Me.cbProgressions.Text)
    End Sub

    Private Sub cbProgList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProgList.SelectedIndexChanged
        cbProgressions.SelectedIndex = cbProgList.SelectedIndex
    End Sub
    Private Sub cmdHideTab_Click(sender As Object, e As EventArgs) Handles cmdHideTab.Click
        If cmdHideTab.Text = "Hide Tab" Then
            Me.Height = 257
            cmdHideTab.Text = "Show Tab"
        ElseIf cmdHideTab.Text = "Show Tab" Then
            Me.Height = 863
            cmdHideTab.Text = "Hide Tab"
        End If
    End Sub
    Private Sub chkOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles chkOnTop.CheckedChanged
        Me.TopMost = chkOnTop.Checked
        frmKeyboard.chkOnTop.Checked = chkOnTop.Checked
        frmFretboard.chkOnTop.Checked = chkOnTop.Checked
        frmChordBuilder.chkOnTop.Checked = chkOnTop.Checked
        frmKeyTriad.chkOnTop.Checked = chkOnTop.Checked

    End Sub
    Private Sub chkTransparency_CheckedChanged(sender As Object, e As EventArgs) Handles chkTransparency.CheckedChanged
        Dim tVal As Single
        If chkTransparency.Checked = True Then
            tVal = InputBox("What level of transparency would you like? 0 is invisible, 1 is visible.  0.5 is a good setting.", "Set Level", Transparency)
            Transparency = tVal
            Me.Opacity = tVal
            frmKeyboard.Opacity = tVal
            frmFretboard.Opacity = tVal
            frmChordBuilder.Opacity = tVal
            frmKeyTriad.Opacity = tVal
        ElseIf chkTransparency.Checked = False Then
            Me.Opacity = 1
            frmKeyboard.Opacity = 1
            frmFretboard.Opacity = 1
            frmChordBuilder.Opacity = 1
            frmKeyTriad.Opacity = 1
        End If
    End Sub

    Private Sub cmdBuilder_Click(sender As Object, e As EventArgs) Handles cmdBuilder.Click
        frmChordBuilder.Show()
    End Sub

    Private Sub cmdAbout_Click(sender As Object, e As EventArgs) Handles cmdAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub txtFretMin_TextChanged(sender As Object, e As EventArgs) Handles txtFretMin.TextChanged
        FretMin = Val(txtFretMin.Text)
    End Sub


    Private Sub txtFretMin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFretMin.KeyPress
        'Ensures only numbers can be entered in to text box:
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtFretMax_TextChanged(sender As Object, e As EventArgs) Handles txtFretMax.TextChanged
        FretMax = Val(txtFretMax.Text)
    End Sub

    Private Sub txtFretMax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFretMax.KeyPress
        'Ensures only numbers can be entered in to text box:
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cmdTriadView_Click(sender As Object, e As EventArgs) Handles cmdTriadView.Click
        frmKeyTriad.Show()
        RefreshAllForms()
        frmKeyTriad.cb1.Text = cmdChord1.Text
        frmKeyTriad.cb2.Text = cmdChord2.Text
        frmKeyTriad.cb3.Text = cmdChord3.Text
        frmKeyTriad.cb4.Text = cmdChord4.Text
        frmKeyTriad.cb5.Text = cmdChord5.Text
        frmKeyTriad.cb6.Text = cmdChord6.Text
        frmKeyTriad.cb7.Text = cmdChord7.Text
    End Sub

    Private Sub frmTabTool_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveOptions()
    End Sub

    Private Sub txtChord_TextChanged(sender As Object, e As EventArgs) Handles txtChord.TextChanged
        txtVals.Text = GenIntsFromNotes(txtChord.Text)

    End Sub
End Class
