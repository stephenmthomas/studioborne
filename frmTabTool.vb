Public Class frmTabTool

    Public Sub GenRootDiff(WhatNote)
        RootDiff = Note2Value(WhatNote) - 0
    End Sub
    Public Sub GenValues()
        CurrentSemitones = GenSemiCSV(cbInt.Text)
        txtVals.Text = CurrentSemitones
    End Sub
    Sub SaveOptions()
        Dim ConfigFile As System.IO.StreamWriter
        Dim NewOpts As String

        NewOpts = ""

        NewOpts += "autoshow=" & oAutoshow & ","
        NewOpts += "notes=" & oNotes & ","
        NewOpts += "tones=" & oTones & ","
        NewOpts += "tabroots=" & oTabroot & ","
        NewOpts += "icons=" & oIcon & ","
        NewOpts += "ontop=" & oOnTop & ","
        NewOpts += "transparency=" & Str(Transparency) & ","
        NewOpts += "transparent=" & oTransparent & ","
        NewOpts += "fretmin=" & FretMin & ","
        NewOpts += "fretmax=" & FretMax & ","
        NewOpts += "expanded=" & oExpanded & ","
        NewOpts += "fretload=" & oFretLoad & ","
        NewOpts += "keyload=" & oKeyLoad & ","
        NewOpts += "mode=" & cbMode.SelectedIndex & ","
        NewOpts += "key=" & cbKey.SelectedIndex & ","
        NewOpts += "frettune=" & Replace(Tuning, ",", "-")

        ConfigFile = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\settings.cfg", False)
        ConfigFile.WriteLine(NewOpts)
        ConfigFile.Close()
    End Sub
    Sub LoadOptions()
        Dim ConfigFile As System.IO.StreamWriter
        Dim SBOptions As String
        Dim Opts(), CurOpt() As String
        Dim LdError As Integer

        On Error GoTo LoadError

LoadConfig:
        'IF THE CONFIGURATION FILE EXISTS:
        If System.IO.File.Exists(Application.StartupPath & "\settings.cfg") Then
            SBOptions = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\settings.cfg")
            Opts = Split(SBOptions, ",")

            For Each opt In Opts
                CurOpt = Split(opt, "=")
                If CurOpt(0) = "autoshow" Then oAutoshow = CurOpt(1)
                If CurOpt(0) = "notes" Then oNotes = CurOpt(1)
                If CurOpt(0) = "tones" Then oTones = CurOpt(1)
                If CurOpt(0) = "tabroots" Then oTabroot = CurOpt(1)
                If CurOpt(0) = "icons" Then oIcon = CurOpt(1)
                If CurOpt(0) = "ontop" Then oOnTop = CurOpt(1)
                If CurOpt(0) = "transparency" Then Transparency = Val(CurOpt(1))
                If CurOpt(0) = "transparent" Then oTransparent = CurOpt(1)
                If CurOpt(0) = "fretmin" Then FretMin = CurOpt(1)
                If CurOpt(0) = "fretmax" Then FretMax = CurOpt(1)
                If CurOpt(0) = "expanded" Then oExpanded = CurOpt(1)
                If CurOpt(0) = "fretload" Then oFretLoad = CurOpt(1)
                If CurOpt(0) = "keyload" Then oKeyLoad = CurOpt(1)
                If CurOpt(0) = "mode" Then cbMode.SelectedIndex = CurOpt(1)
                If CurOpt(0) = "key" Then cbKey.SelectedIndex = CurOpt(1)
                If CurOpt(0) = "frettune" Then Tuning = Replace(CurOpt(1), "-", ",")
            Next

        Else 'NO CONFIGURATION FILE PRESENT
            ConfigFile = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\settings.cfg", False)
            ConfigFile.WriteLine(DefaultOpts)
            ConfigFile.Close()
            cbMode.SelectedIndex = 0
            CurrentNotes = GenNotesCSV(cbInt.Text)
            cbKey.SelectedIndex = 3
            FretMin = 0
            FretMax = 17
        End If

        'SET OPTIONS
        CurrentKey = cbKey.Text
        CurrentMode = cbMode.Text
        RootNote = CurrentKey

        Exit Sub

LoadError: 'ERROR HANDLER; 6 = yes, 7 = no
        LdError = MsgBox("There appears to be an error loading the configuration file.  Would you like to reset the configuration file and try again? (Recommended!)", vbYesNo, "Load Error!")
        If LdError = 6 Then
            ConfigFile = My.Computer.FileSystem.OpenTextFileWriter(Application.StartupPath & "\settings.cfg", False)
            ConfigFile.WriteLine(DefaultOpts)
            ConfigFile.Close()
            cbKey.SelectedIndex = 3
            cbMode.SelectedIndex = 0
            CurrentNotes = GenNotesCSV(cbInt.Text)
            FretMin = 0
            FretMax = 17
            GoTo LoadConfig
        ElseIf LdError = 7 Then
            MsgBox("You should probably reset the configuration file, or close the program and delete it manually.  Studioborne will continue to run, but may encounter bugs.", vbOKOnly, "Well...")
        End If

    End Sub
    Private Sub frmTabTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadOptions()

        Me.Text = Me.Text & " - " & SBVersion
        If oExpanded = True Then
            Me.Height = 227
            Me.Width = 504
        Else
            Me.Height = 113
            Me.Width = 367
        End If

        GenValues()

        If oFretLoad = True Then frmFretboard.Show()
        If oKeyLoad = True Then frmKeyboard.Show()

        RefreshAllForms()

    End Sub


    Private Sub cbMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMode.SelectedIndexChanged
        cbInt.SelectedIndex = cbMode.SelectedIndex
        CurrentMode = cbMode.Text
        CurrentNotes = GenNotesCSV(cbInt.Text)
        frmInfo.txtNotes.Text = CurrentNotes
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

        RefreshAllForms()

    End Sub

    Private Sub cbInt_SelectedIndexChanged(sender As Object, e As EventArgs)
        cbMode.SelectedIndex = cbInt.SelectedIndex
    End Sub
    Private Sub cbInt_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbInt.SelectedIndexChanged
        cbMode.SelectedIndex = cbInt.SelectedIndex
    End Sub
    Private Sub cbKey_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbKey.SelectedIndexChanged
        CurrentKey = cbKey.Text
        RootNote = CurrentKey

        GenRootDiff(CurrentKey)
        CurrentNotes = GenNotesCSV(cbInt.Text)
        GenValues()
        RefreshAllForms()
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
                                If oTones = True Then
                                    frmFretboard.FretDraw(CurString, CurFret, Color.Red, Trim(Str(CurNote + 1)))
                                Else
                                    frmFretboard.FretDraw(CurString, CurFret, Color.Red, ScaleNotes(CurNote))
                                End If
                            Else
                                If oTones = True Then
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
    Sub DrawTriadForm()
        'Draws triads on the triad viewer
        frmKeyTriad.KeyClearAll()
        For DegreeX = 1 To 7
            DrawTriad(DegreeX)
        Next

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

        If oAutoshow = True Then
            TempRoot = Split(ChordStr, ",")
            RootNote = TempRoot(0)
            DrawKeyboard(ChordStr)
            DrawFretBoard(ChordStr)
            RootNote = CurrentKey
        End If

        If frmProgressor.Timer1.Enabled = True Then
            If frmProgressor.chkKey.Checked = True Then
                DrawKeyboard(ChordStr)
                frmKeyboard.Text = "Keyboard - " & CurrentKey & " " & CurrentMode & " " & WhatDegree & " Chord"
            End If
            If frmProgressor.chkFret.Checked = True Then
                DrawFretBoard(ChordStr)
                frmFretboard.Text = "Fretboard - " & CurrentKey & " " & CurrentMode & " " & WhatDegree & " Chord"
            End If
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
                    If oTones = True Then
                        frmKeyboard.KeyDraw(Note, Color.Red, Trim(Str(NoteStep)))
                    Else
                        frmKeyboard.KeyDraw(Note, Color.Red, Note)
                    End If
                Else
                    If oTones = True Then
                        frmKeyboard.KeyDraw(Note, Color.Green, Trim(Str(NoteStep)))
                    Else
                        frmKeyboard.KeyDraw(Note, Color.Green, Note)
                    End If

                End If
            End If
            NoteStep += 1
        Next
    End Sub



    Private Sub cmdChord1_Click(sender As Object, e As EventArgs) Handles cmdChord1.Click
        CurrentChord = GenerateChord(1)
        Dim SplitChord() As String
        SplitChord = Split(CurrentChord, ",")

        frmFretboard.Text = "Fretboard - " & CurrentKey & " " & CurrentMode & " " & cmdChord1.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(CurrentSemitones)
        frmKeyboard.Text = "Keyboard - " & CurrentKey & " " & CurrentMode & " " & cmdChord1.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(CurrentSemitones)

        frmInfo.txtChord.Text = CurrentChord

    End Sub
    Private Sub cmdChord2_Click(sender As Object, e As EventArgs) Handles cmdChord2.Click
        CurrentChord = GenerateChord(2)
        Dim SplitChord() As String
        SplitChord = Split(CurrentChord, ",")

        frmFretboard.Text = "Fretboard - " & CurrentKey & " " & CurrentMode & " " & cmdChord2.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(CurrentSemitones)
        frmKeyboard.Text = "Keyboard - " & CurrentKey & " " & CurrentMode & " " & cmdChord2.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(CurrentSemitones)

        frmInfo.txtChord.Text = CurrentChord
    End Sub

    Private Sub cmdChord3_Click(sender As Object, e As EventArgs) Handles cmdChord3.Click
        CurrentChord = GenerateChord(3)
        Dim SplitChord() As String
        SplitChord = Split(CurrentChord, ",")

        frmFretboard.Text = "Fretboard - " & CurrentKey & " " & CurrentMode & " " & cmdChord3.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(CurrentSemitones)
        frmKeyboard.Text = "Keyboard - " & CurrentKey & " " & CurrentMode & " " & cmdChord3.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(CurrentSemitones)

        frmInfo.txtChord.Text = CurrentChord
    End Sub

    Private Sub cmdChord4_Click(sender As Object, e As EventArgs) Handles cmdChord4.Click
        CurrentChord = GenerateChord(4)
        Dim SplitChord() As String
        SplitChord = Split(CurrentChord, ",")

        frmFretboard.Text = "Fretboard - " & CurrentKey & " " & CurrentMode & " " & cmdChord4.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(CurrentSemitones)
        frmKeyboard.Text = "Keyboard - " & CurrentKey & " " & CurrentMode & " " & cmdChord4.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(CurrentSemitones)

        frmInfo.txtChord.Text = CurrentChord
    End Sub

    Private Sub cmdChord5_Click(sender As Object, e As EventArgs) Handles cmdChord5.Click
        CurrentChord = GenerateChord(5)
        Dim SplitChord() As String
        SplitChord = Split(CurrentChord, ",")

        frmFretboard.Text = "Fretboard - " & CurrentKey & " " & CurrentMode & " " & cmdChord5.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(CurrentSemitones)
        frmKeyboard.Text = "Keyboard - " & CurrentKey & " " & CurrentMode & " " & cmdChord5.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(CurrentSemitones)

        frmInfo.txtChord.Text = CurrentChord
    End Sub

    Private Sub cmdChord6_Click(sender As Object, e As EventArgs) Handles cmdChord6.Click
        CurrentChord = GenerateChord(6)
        Dim SplitChord() As String
        SplitChord = Split(CurrentChord, ",")

        frmFretboard.Text = "Fretboard - " & CurrentKey & " " & CurrentMode & " " & cmdChord6.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(CurrentSemitones)
        frmKeyboard.Text = "Keyboard - " & CurrentKey & " " & CurrentMode & " " & cmdChord6.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(CurrentSemitones)

        frmInfo.txtChord.Text = CurrentChord
    End Sub

    Private Sub cmdChord7_Click(sender As Object, e As EventArgs) Handles cmdChord7.Click
        CurrentChord = GenerateChord(7)
        Dim SplitChord() As String
        SplitChord = Split(CurrentChord, ",")

        frmFretboard.Text = "Fretboard - " & CurrentKey & " " & CurrentMode & " " & cmdChord7.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(CurrentSemitones)
        frmKeyboard.Text = "Keyboard - " & CurrentKey & " " & CurrentMode & " " & cmdChord7.Text & " Chord" & " - " & SplitChord(0) & " " & ChordTypeFromCSV(CurrentSemitones)

        frmInfo.txtChord.Text = CurrentChord
    End Sub



    Private Sub cmdFretboard_Click(sender As Object, e As EventArgs) Handles cmdFretboard.Click
        frmFretboard.Show()
        RefreshAllForms()
    End Sub

    Private Sub cmdKeyboard_Click(sender As Object, e As EventArgs) Handles cmdKeyboard.Click
        frmKeyboard.Show()
        RefreshAllForms()
    End Sub

    Private Sub cmdMaximize_Click(sender As Object, e As EventArgs) Handles cmdMaximize.Click
        If cmdMaximize.Text = "Expand" Then
            Me.Height = 227
            Me.Width = 504
            cmdMaximize.Text = "Shrink"
        ElseIf cmdMaximize.Text = "Shrink" Then
            Me.Height = 113
            Me.Width = 367
            cmdMaximize.Text = "Expand"
        End If
    End Sub
    Private Sub cmdBuilder_Click(sender As Object, e As EventArgs) Handles cmdBuilder.Click
        frmChordBuilder.Show()
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

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        frmOptions.Show()

    End Sub

    Private Sub cmdInfo_Click(sender As Object, e As EventArgs) Handles cmdInfo.Click
        frmInfo.Show()
    End Sub

    Private Sub cmdAbout_Click(sender As Object, e As EventArgs)
        frmAbout.Show()
    End Sub

    Private Sub cmdTabEditor_Click(sender As Object, e As EventArgs) Handles cmdTabEditor.Click
        frmTabEdit.Show()
    End Sub

    Private Sub cmdProgressor_Click(sender As Object, e As EventArgs) Handles cmdProgressor.Click
        frmProgressor.Show()
    End Sub
End Class
